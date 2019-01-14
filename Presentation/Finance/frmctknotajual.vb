Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmctknotajual
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DA2, DA3, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16
    Dim drPost As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim err, msg, errmsg As String

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Data telah terproses dan cetak invoice..", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            simpan()
            'cetak_inv()
        End If
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Public Sub delete_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub

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
        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.RowState = DataRowState.Modified Then
                rw.Item("tgl_cetak") = Now
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

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
            'STATE = "EDIT"

            For rw As Integer = 0 To Gvheader.RowCount - 1
                If view.GetRowCellValue(rw, "sts_nota").ToString = "NOTA" Then
                    errmsg = view.GetRowCellValue(rw, "no_sj").ToString
                    call_procedure_dtl(view.GetRowCellValue(rw, "no_sj").ToString, BTRANS)
                    'call_procedure_fee_sharing(view.GetRowCellValue(rw, "no_sj").ToString, BTRANS)
                    'call_procedure_lain(view.GetRowCellValue(rw, "no_sj").ToString, BTRANS)
                End If
                'End If
            Next

            BTRANS.Commit()

            For rw As Integer = 0 To Gvheader.RowCount - 1
                If view.GetRowCellValue(rw, "sts_nota").ToString = "NOTA" Then
                    'If view.GetRowCellValue(rw, "tipe_trans").ToString = "JPJ-KPT-02" Or view.GetRowCellValue(rw, "tipe_trans").ToString = "JPJ-KPT-04" Then
                    '    callReport(App_Path() & "\report\repNotaJualSpon.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
                    'Else
                    '    callReport(App_Path() & "\report\repNotaJualSpring.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
                    'End If
                    If view.GetRowCellValue(rw, "tipe_trans").ToString = "JPJ-KPT-01" Then
                        callReport(App_Path() & "\report\repNotaJualSpring.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
                    ElseIf view.GetRowCellValue(rw, "tipe_trans").ToString = "JPJ-KPT-02" Then
                        callReport(App_Path() & "\report\repNotaJualSpon.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
                    Else
                        callReport(App_Path() & "\report\repNotaJualCentian.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
                    End If
                End If
            Next
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            err = "ERROR"
            BTRANS.Rollback()
            If Not BTRANS Is Nothing Then

            End If
            dSO.Tables("_invheader").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            'dSO.Tables("_tipe_trans_d").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox("Gagal simpan. " & vbCrLf & "Cek ulang SJ kembali." & vbCrLf & errmsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End Try

        'If Not err = "ERROR" Then
        '    For rw As Integer = 0 To Gvheader.RowCount - 1
        '        If view.GetRowCellValue(rw, "sts_nota").ToString = "NOTA" Then
        '            If view.GetRowCellValue(rw, "tipe_trans").ToString = "JPJ-KPT-04" Then
        '                callReport(App_Path() & "\report\repNotaJualSpon.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
        '            Else
        '                callReport(App_Path() & "\report\repNotaJualSpring.rpt", "", "no_sj=" & view.GetRowCellValue(rw, "no_sj"), True, False, "DIM")
        '            End If
        '        End If
        '    Next
        '    showMessages("Berhasil disimpan..")
        'Else
        '    MsgBox("Gagal simpan. " & vbCrLf & "Cek ulang SJ kembali." & vbCrLf & msg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        'End If
        bersihkan()
        reloadGrid()
    End Sub

    Private Sub frmctknotajual_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        setStatus()
    End Sub

    Private Sub frmMstTipeTranKeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'DA = New SqlDataAdapter(New SqlCommand("select *,(select tgl_sp from SALES.dbo.SALES_SO b where b.No_sp=a.no_sp) tgl_order from SALES.DBO.SALES_SJ a where (a.sts_nota is null or a.sts_nota ='') AND NOT (a.tgl_terima IS NULL)", sqlconn))
        'DA.Fill(dSO, "_invheader")

        'DA1 = New SqlDataAdapter(New SqlCommand("SELECT no_sj, no_seq, Kd_stok, Kd_satuan, ISNULL(Qty_kirim,0) AS kirim, ISNULL(Qty_balik,0) AS balik, Keterangan from SALES.DBO.SALES_SJ_D where no_sj in (select no_sj from SALES.DBO.SALES_SJ where (sts_nota is null or sts_nota ='') AND NOT (tgl_terima IS NULL))", sqlconn))
        'DA1.Fill(dSO, "_invdetailsj")

        'DA2 = New SqlDataAdapter(New SqlCommand("select *,(Qty*harga+Qty*potongan) total from SALES.DBO.SALES_SO_D where no_sp in (select no_sp from SALES.DBO.SALES_SJ where (sts_nota is null or sts_nota ='') and (Tgl_balik is not null or Tgl_balik <>''))and len(kd_stok) >10 ", sqlconn))
        'DA2.Fill(dSO, "_invdetailsp")

        'Dim rl, r2 As DataRelation
        'rl = dSO.Relations.Add("DetailSJ", dSO.Tables("_invheader").Columns("no_sj"), dSO.Tables("_invdetailsj").Columns("no_sj"))
        ''r2 = dSO.Relations.Add("DetailSP", dSO.Tables("_invheader").Columns("No_sp"), dSO.Tables("_invdetailsp").Columns("No_sp"))

        'GcInvoice.DataSource = dSO.Tables("_invheader")
        'GcInvoice.LevelTree.Nodes.Add("DetailSJ", gvdetailSJ)
        'GcInvoice.LevelTree.Nodes.Add("DetailSP", gvdetailSP)
        reloadGrid()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        'cmdSimpan.Show()
        btnExit.Hide()
        btnDel.Hide()

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

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Sopir, Nama_Sopir from SIF.dbo.SIF_Sopir", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookupsopir.DataSource = ds_cari.Tables("_lookup3")
        lookupsopir.ValueMember = "Kode_Sopir"
        lookupsopir.DisplayMember = "Nama_Sopir"

    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Data telah terproses dan cetak invoice..", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            simpan()
            'cetak_inv()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub cetak_inv(ByVal trans As SqlTransaction)
        Dim ctklsg As Boolean = False
        Dim i As Integer = MsgBox("Cetak langsung ?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "CETAK?")
        If i = MsgBoxResult.Cancel Then Exit Sub
        If i = MsgBoxResult.Yes Then ctklsg = True

        Dim view As ColumnView = Gvheader.Columns.View
        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

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
            STATE = "EDIT"

            For rw As Integer = 0 To Gvheader.RowCount - 1
                If view.GetRowCellValue(rw, "sts_nota").ToString = "NOTA" Then
                    call_procedure_dtl(view.GetRowCellValue(rw, "no_sj").ToString, BTRANS)
                    'call_procedure_lain(view.GetRowCellValue(rw, "no_sj").ToString, BTRANS)
                End If
            Next

            BTRANS.Commit()

            showMessages("Berhasil disimpan..")
        Catch e As Exception
            err = "ERROR"
            BTRANS.Rollback()
            dSO.Tables("_invheader").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

        'If Not err = "ERROR" Then
        '    For rw As Integer = 0 To Gvheader.RowCount - 1
        '        If view.GetRowCellValue(rw, "sts_nota").ToString = "NOTA" Then
        '            callReport(App_Path() & "\report\repNotaJual.rpt", "", "vno_sj=" & view.GetRowCellValue(rw, "no_sj"), ctklsg)
        '        End If
        '    Next
        'End If
        bersihkan()
        reloadGrid()
    End Sub
   
    Public Sub call_procedure_dtl(ByVal vnosj As String, ByVal transx As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = transx
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_JUAL"

        sqlCmd.Parameters.Add("@no_sj", SqlDbType.Char).Value = vnosj
        sqlCmd.ExecuteNonQuery()
        'showMessages("Generate detail data.......")
    End Sub

    Public Sub call_procedure_lain(ByVal no_sj As String, ByVal transx As SqlTransaction)
        drPost = New SqlCommand("SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE no_sj = '" & no_sj & "'", sqlconn, transx).ExecuteReader
        drPost.Read()

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = transx
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_JUR_INV_OUT_CUST"

        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = drPost.Item(0)
        sqlCmd.ExecuteNonQuery()
        drPost.Close()
        'showMessages("Generate detail data.......")
    End Sub

    Public Sub call_procedure_fee_sharing(ByVal no_inv As String, ByVal transx As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = transx
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_JUR_FEE_SHARING"

        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = no_inv
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub call_procedure(ByVal vnosj As String, ByVal transx As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = transx
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "SALES.dbo.islunas"

        sqlCmd.Parameters.Add("@no_sp", SqlDbType.Char).Value = vnosj
        sqlCmd.ExecuteNonQuery()
        'showMessages("Generate detail data.......")
    End Sub

    Public Sub bersihkan()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        ckcetak.Checked = False
    End Sub

    Public Sub reloadGrid()
        dSO = New DataSet

        'DA = New SqlDataAdapter(New SqlCommand("select *,(select tgl_sp from SALES.dbo.SALES_SO b where b.No_sp=a.no_sp) tgl_order from SALES.DBO.SALES_SJ a where (a.sts_nota is null or a.sts_nota ='') AND NOT (a.tgl_terima IS NULL)", sqlconn))
        DA = New SqlDataAdapter(New SqlCommand("select distinct a.*,(select tgl_sp from SALES.dbo.SALES_SO b where b.No_sp=a.no_sp) as tgl_order from SALES.DBO.SALES_SJ a, SALES.DBO.SALES_SJ_D b where a.no_sj = b.no_sj and (a.sts_nota is null or a.sts_nota ='') AND NOT (a.tgl_terima IS NULL) AND b.No_sp in (select No_sp from sales.dbo.SALES_SO where JML_RP_TRANS > 0) and not a.no_sj in (SELECT DISTINCT no_sj from SALES.DBO.SALES_SJ_D group by no_sj having sum(Qty_kirim) = sum(Qty_balik))", sqlconn))
        DA.Fill(dSO, "_invheader")

        'DA1 = New SqlDataAdapter(New SqlCommand("SELECT no_sj,no_seq, Kd_stok, Kd_satuan, ISNULL(Qty_kirim,0) AS kirim, ISNULL(Qty_balik,0) AS balik, Keterangan from SALES.DBO.SALES_SJ_D where no_sj in (select no_sj from SALES.DBO.SALES_SJ where (sts_nota is null or sts_nota ='') AND NOT (tgl_terima IS NULL))", sqlconn))
        DA1 = New SqlDataAdapter(New SqlCommand("SELECT no_sj, no_seq, Kd_stok, Kd_satuan, ISNULL(Qty_kirim,0) AS kirim, ISNULL(Qty_balik,0) AS balik, Keterangan from SALES.DBO.SALES_SJ_D where no_sj in (select distinct a.no_sj from SALES.DBO.SALES_SJ a, SALES.DBO.SALES_SJ_D b where a.no_sj = b.no_sj and (a.sts_nota is null or a.sts_nota ='') AND NOT (a.tgl_terima IS NULL) AND b.No_sp in (select No_sp from sales.dbo.SALES_SO where JML_RP_TRANS > 0) and not a.no_sj in (SELECT DISTINCT no_sj from SALES.DBO.SALES_SJ_D group by no_sj having sum(Qty_kirim) = sum(Qty_balik)))", sqlconn))
        DA1.Fill(dSO, "_invdetailsj")

        DA2 = New SqlDataAdapter(New SqlCommand("select *,(Qty*harga+Qty*potongan) total from SALES.DBO.SALES_SO_D where no_sp in (select no_sp from SALES.DBO.SALES_SJ where (sts_nota is null or sts_nota =''))and len(kd_stok) >10 ", sqlconn))
        DA2.Fill(dSO, "_invdetailsp")

        Dim rl, r2 As DataRelation
        rl = dSO.Relations.Add("DetailSJ", dSO.Tables("_invheader").Columns("no_sj"), dSO.Tables("_invdetailsj").Columns("no_sj"))
        'r2 = dSO.Relations.Add("DetailSP", dSO.Tables("_invheader").Columns("No_sp"), dSO.Tables("_invdetailsp").Columns("No_sp"))

        GcInvoice.DataSource = dSO.Tables("_invheader")
        GcInvoice.LevelTree.Nodes.Add("DetailSJ", gvdetailSJ)
        'GcInvoice.LevelTree.Nodes.Add("DetailSP", gvdetailSP)
    End Sub

    Private Sub ckcetak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckcetak.CheckedChanged
        Dim viewx As ColumnView = Gvheader
        If ckcetak.Checked = True Then
            'For Each rw As DataRow In dSO.Tables("_invheader").Rows
            '    rw.Item("sts_nota") = "NOTA"
            'Next
            For rw As Integer = 0 To Gvheader.RowCount - 1
                viewx.SetRowCellValue(rw, "sts_nota", "NOTA")
            Next
            'Else
            '    'For Each rw As DataRow In dSO.Tables("_invheader").Rows
            '    '    rw.Item("sts_nota") = vbNull
            '    'Next
            '    For rw As Integer = 0 To Gvheader.RowCount - 1
            '        viewx.SetRowCellValue(rw, "sts_nota", "SJ")
            '    Next
        End If

    End Sub

    Private Sub Gvheader_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gvheader.DoubleClick
        DA3 = New SqlDataAdapter(New SqlCommand("select *,(Qty*harga+Qty*potongan) total from SALES.DBO.SALES_SO_D where no_sp = '" & Gvheader.GetFocusedRowCellValue("No_sp").ToString & "'and len(kd_stok) >10", sqlconn))
        DA3.Fill(dSO, "ViewSP")
        'GcInvoice.DataSource = dSO.Tables("ViewSP")
        frmCari.set_dso(dSO.Tables("ViewSP"))
        frmCari.ShowDialog()
        'GcInvoice.MainView = gvdetailSP
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        reloadGrid()
    End Sub
End Class