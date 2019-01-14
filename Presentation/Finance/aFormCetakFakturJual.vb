Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormCetakFakturJual
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DA2, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16
    Dim drPost As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim err As String
    Dim rl As DataRelation

    Public Sub save_click()
        simpan()
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim view As ColumnView = Gvheader.Columns.View
        Dim counter As Integer = 0
        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                counter += 1
            End If
        Next

        If Not counter <= 0 Then
            If MsgBox("Data telah terproses dan cetak invoice..", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim builder As New SqlCommandBuilder(DA)
                DA.InsertCommand = builder.GetInsertCommand()
                DA.UpdateCommand = builder.GetUpdateCommand()
                DA.DeleteCommand = builder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                Try
                    DA.Update(dSO, ("_invheader"))
                    dSO.Tables("_invheader").AcceptChanges()

                    BTRANS.Commit()
                    STATE = "SAVED"
                    showMessages("Berhasil disimpan..")
                Catch e As Exception
                    err = "ERROR"
                    dSO.Tables("_invheader").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
                End Try

                If Not err = "ERROR" Then
                    For rw As Integer = 0 To Gvheader.RowCount - 1
                        If view.GetRowCellValue(rw, "sts_ppn").ToString = "Y" Then
                            'callReport(App_Path() & "\report\InvoiceJual.rpt", "", "vno_sj=" & view.GetRowCellValue(rw, "no_sj"), False)
                        End If
                    Next
                    err = ""
                End If
                bersihkan()
                reloadGrid()
            End If
        Else
            MsgBox("Tidak ada data yang dipilih untuk dicetak.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Private Sub aFormCetakFakturJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        STATE = "LOAD"
        reloadGrid()

        prn = getParent(Me)
        Me.Enabled = True

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Customer, Nama_Customer from SIF.dbo.SIF_Customer", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lookupcust.DataSource = ds_cari.Tables("_lookup1")
        Lookupcust.ValueMember = "Kd_Customer"
        Lookupcust.DisplayMember = "Nama_Customer"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        Lookupbrg.DataSource = ds_cari.Tables("_lookup2")
        Lookupbrg.ValueMember = "Kode_Barang"
        Lookupbrg.DisplayMember = "Nama_Barang"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookupvaluta.DataSource = ds_cari.Tables("_lookup3")
        lookupvaluta.ValueMember = "Kode_Valuta"
        lookupvaluta.DisplayMember = "Nama_Valuta"
    End Sub

    Public Sub bersihkan()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        ckcetak.Checked = False
    End Sub

    Public Sub reloadGrid()
        If STATE = "SAVED" Then
            If Not dSO.Tables("_invheader") Is Nothing Then dSO.Tables("_invheader").Clear()
            If Not dSO.Tables("_invdetailsj") Is Nothing Then dSO.Tables("_invdetailsj").Clear()
            DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE NOT (flag_ppn IS NULL OR flag_ppn = '') AND tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
            DA.Fill(dSO, "_invheader")
            DA1 = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE NOT (flag_ppn IS NULL OR flag_ppn = '') AND tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
            DA1.Fill(dSO, "_invdetailsj")
            STATE = "LOAD"
            Gvheader.BestFitColumns()
            gvdetailSJ.BestFitColumns()
        Else
            If Not dSO.Tables("_invheader") Is Nothing Then dSO.Tables("_invheader").Clear()
            If Not dSO.Tables("_invdetailsj") Is Nothing Then dSO.Tables("_invdetailsj").Clear()
            DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE NOT (flag_ppn IS NULL OR flag_ppn = '') AND tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
            DA.Fill(dSO, "_invheader")
            DA1 = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE NOT (flag_ppn IS NULL OR flag_ppn = '') AND tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
            DA1.Fill(dSO, "_invdetailsj")
            rl = dSO.Relations.Add("Detail", dSO.Tables("_invheader").Columns("no_inv"), dSO.Tables("_invdetailsj").Columns("no_inv"))
            GcInvoice.DataSource = dSO.Tables("_invheader")
            GcInvoice.LevelTree.Nodes.Add("Detail", gvdetailSJ)
            Gvheader.BestFitColumns()
            gvdetailSJ.BestFitColumns()
        End If
    End Sub

    Private Sub ckcetak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckcetak.CheckedChanged
        Dim viewx As ColumnView = Gvheader.Columns.View
        If ckcetak.Checked = True Then
            For rw As Integer = 0 To Gvheader.RowCount - 1
                viewx.SetRowCellValue(rw, "sts_ppn", "Y")
            Next
        Else
            For rw As Integer = 0 To Gvheader.RowCount - 1
                viewx.SetRowCellValue(rw, "sts_ppn", "T")
            Next
        End If
    End Sub
End Class