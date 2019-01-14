Imports System.Data.SqlClient

Public Class frmUMPurchase
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public dipilih As String
    Dim table As DataTable

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        State = "ADD"
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        'da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans='JPJ-KPT-08'", sqlconn))
        'da1.Fill(ds1, "Db_data1")

        isiGrid()

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        da4.Fill(ds4, "_karyawon")
        Lookkaryawan.Properties.DataSource = ds4.Tables("_karyawon")
        Lookkaryawan.Properties.ValueMember = "kode"
        Lookkaryawan.Properties.DisplayMember = "nama"

        'da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        'da5.Fill(ds5, "_karyawan")
        'lookupPeg.DataSource = ds4.Tables("_karyawon")
        'lookupPeg.ValueMember = "kode" 
        'lookupPeg.DisplayMember = "nama"

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.sif_valuta", sqlconn))
        da2.Fill(ds2, "_valuta")
        Lookvaluta.Properties.DataSource = ds2.Tables("_valuta")
        Lookvaluta.Properties.ValueMember = "Kode_Valuta"
        Lookvaluta.Properties.DisplayMember = "Nama_Valuta"

        txtno_inv.Enabled = False
        dttgl_inv.Text = Today.Date
        'txtno_inv.Text = getNoTrans("UMUKA", getTanggal())

    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        bersihkan()
    End Sub

    Public Sub edit_click()
        'dSO = New DataSet
        'da5 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-08'", sqlconn))
        'da5.Fill(ds5, "_bom")
        'frmCari.set_dso(ds5.Tables("_bom"))
        'frmCari.ShowDialog()
        'If Not frmCari.row Is Nothing Then
        '    txtno_inv.Text = frmCari.row("no_inv").ToString
        '    txtjml_val_trans.EditValue = frmCari.row("jml_val_trans").ToString
        '    Lookkaryawan.EditValue = frmCari.row("kd_cust").ToString
        '    txtketerangan.Text = frmCari.row("keterangan").ToString
        '    dttgl_inv.Text = frmCari.row("tgl_inv").ToString
        'End If

    End Sub
    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(da1)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GV.SelectedRowsCount - 1)
        For i = 0 To GV.SelectedRowsCount - 1
            rows(i) = GV.GetDataRow(GV.GetSelectedRows(i))
        Next
        GV.BeginSort()
        Try
            For Each row In rows
                row.Delete()
                showMessages("dihapus")
            Next
        Finally
            GV.EndSort()
        End Try
        State = "DELETE"
        save_click()
    End Sub
    'Public Function getNoTrans(ByVal kdBukti As String, ByVal tgl As Date, Optional ByVal BTRANS As SqlTransaction = Nothing) As String
    '    Dim sqlcmd As New SqlCommand
    '    sqlcmd.Connection = sqlconn
    '    sqlcmd.CommandType = CommandType.StoredProcedure
    '    sqlcmd.CommandText = "SIF.dbo.sifp_get_no_trans"
    '    If Not BTRANS Is Nothing Then
    '        sqlcmd.Transaction = BTRANS
    '    End If
    '    sqlcmd.Parameters.Add("@vkd_bukti", SqlDbType.VarChar, 10)
    '    sqlcmd.Parameters.Add("@vtgl_trans", SqlDbType.Date)
    '    sqlcmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
    '    sqlcmd.Parameters("@vkd_bukti").Value = kdBukti
    '    sqlcmd.Parameters("@vtgl_trans").Value = tgl
    '    sqlcmd.Parameters("@vno_trans").Direction = ParameterDirection.Output
    '    sqlcmd.ExecuteNonQuery()
    '    Return sqlcmd.Parameters("@vno_trans").Value.ToString
    'End Function


    Public Sub bersihkan()
        If Not ds1 Is Nothing Then
            ds1.Clear()
        End If
        'If State = "ADD" Then
        txtno_inv.Text = ""
        txtjml_val_trans.EditValue = vbNullString
        Lookkaryawan.EditValue = vbNullString
        txtketerangan.Text = ""
        txtkurs_valuta.Text = 1
        Lookvaluta.EditValue = vbNullString
        'End If
    End Sub

    Public Sub isiGrid()
        bersihkan()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_UM", sqlconn)) 'nomor,tanggal,kartu,jml_val_trans,keterangan from FIN.dbo.FIN_UM", sqlconn))
        da1.Fill(ds1, "Db_data1")
        GC.DataSource = ds1.Tables("Db_data1")
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        'Dim tmpNo As String

        'If txtno_inv.Text = "" Then
        '    txtno_inv.Text = getNoTrans("PIUTKAR", dttgl_inv.DateTime)
        'End If

        If State = "ADD" Then
            txtno_inv.Text = getNoTrans("UMUKA", getTanggal)
            row = ds1.Tables("Db_data1").NewRow
            row.Item("nomor") = txtno_inv.Text
            row.Item("Last_create_date") = getTanggal()
            row.Item("Last_created_by") = username
            row.Item("jml_bayar") = 0
            row.Item("Program_name") = Me.Name
        ElseIf State = "EDIT" Then
            'dipilih = table.Rows(GV.GetSelectedRows(0)).Item(0).ToString()
            'row = table.Rows(GV.GetSelectedRows(0))
            row = ds1.Tables("Db_data1").Rows(GV.GetSelectedRows(0))
            'row = GV.GetSelectedRows
            row.Item("Last_update_date") = getTanggal()
            row.Item("Last_updated_by") = username
            row.Item("jml_bayar") = 0
        End If

        'If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        'txtno_inv.Text = row("")
        If (State = "ADD" Or State = "EDIT") Then
            row.Item("Kd_cabang") = "1"
            row.Item("tipe_trans") = "JKM-KUT-03"
            '            row.Item("tgl_inv") = dttgl_inv.DateTime
            row.Item("tanggal") = Now
            row.Item("kartu") = Lookkaryawan.EditValue
            row.Item("keterangan") = txtketerangan.Text
            row.Item("jml_val_trans") = txtjml_val_trans.EditValue
            row.Item("jml_rp_trans") = txtjml_val_trans.EditValue
            row.Item("jml_tagihan") = txtjml_val_trans.EditValue
            row.Item("kd_valuta") = "IDR"
            row.Item("kurs_valuta") = 1
            row.Item("kd_buku_besar") = "1-511000" 'Lookvaluta.EditValue
        End If

        If State = "ADD" Then
            ds1.Tables("Db_data1").Rows.Add(row)
        End If

        Try
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS


            'ds1.Tables("Db_data1").Rows.Add(row)
            da1.Update(ds1.Tables("Db_data1"))

            ds1.Tables("Db_data1").AcceptChanges()
            BTRANS.Commit()

            showMessages("Data Telah Disimpan..!")
            bersihkan()
            isiGrid()
        Catch ex As Exception
            BTRANS.Rollback()
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then hapus_record()
        ' showMessages("Deleted..")
        'cancel_click()
        'End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        txtno_inv.Text = GV.GetRow(GV.GetSelectedRows(0)).item("nomor")
        dttgl_inv.DateTime = GV.GetRow(GV.GetSelectedRows(0)).item("tanggal")
        Lookkaryawan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kartu")
        txtjml_val_trans.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("jml_val_trans")
        txtketerangan.Text = GV.GetRow(GV.GetSelectedRows(0)).item("keterangan")
        State = "EDIT"
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        add_click()
        dttgl_inv.Focus()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        cancel_click()
    End Sub
    Public Sub call_frmCari()
        frmCari.set_dso(ds4.Tables("Db_data4"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            Lookkaryawan.Text = frmCari.row("Kode_Pegawai").ToString
            'TxtNama.Text = frmCari.row("nama_pegawai").ToString
            'txbNoDocBOM.Text = frmCari.row("no_dokumen_BOM").ToString
            'txbJenisBOM.Text = frmCari.row("jenis_BOM").ToString
            'rtbKet.Text = frmCari.row("keterangan").ToString
            'cbStatus.Text = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "NonAKTIF")
        End If

    End Sub
    Private Sub LOV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        call_frmCari()
    End Sub

    Private Sub txtkd_cust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Lookkaryawan.Text = " " Then
            call_frmCari()
        End If

    End Sub

End Class