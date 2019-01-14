'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter


Public Class frmMstTipeTran
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Public Sub delete_click()
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        Dim builder As New SqlCommandBuilder(DA)
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        'DA.Update(dSO, "_SIF_TpTran")
        'dSO.Tables("_SIF_TpTran").AcceptChanges()

        builder = New SqlCommandBuilder(DA1)
        DA1.InsertCommand = builder.GetInsertCommand()
        DA1.UpdateCommand = builder.GetUpdateCommand()
        DA1.DeleteCommand = builder.GetDeleteCommand()
        'DA1.Update(dSO, "_tipe_trans_d")
        'dSO.Tables("_tipe_trans_d").AcceptChanges()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DA1.UpdateCommand.Transaction = BTRANS
        DA1.InsertCommand.Transaction = BTRANS
        DA1.DeleteCommand.Transaction = BTRANS

        For Each rw As DataRow In dSO.Tables("_SIF_TpTran").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = 1
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

        For Each rw1 As DataRow In dSO.Tables("_tipe_trans_d").Rows
            If rw1.RowState = DataRowState.Added Then
                rw1("Kd_Cabang") = 1
                'rw1("tipe_trans") = "JKK-KBB-01"
                rw1("Last_Create_Date") = Now
                rw1("Last_Created_By") = umum.username
                rw1("Program_Name") = Me.Name
            ElseIf rw1.RowState = DataRowState.Modified Then
                rw1.Item("Last_Update_Date") = Now
                rw1.Item("Last_Updated_By") = username
            End If
        Next

        '  Try


        DA.Update(dSO,("_SIF_TpTran"))
        DA1.Update(dSO, ("_tipe_trans_d"))

        dSO.Tables("_SIF_TpTran").AcceptChanges()
        dSO.Tables("_tipe_trans_d").AcceptChanges()
        STATE = "EDIT"
        BTRANS.Commit()
        showMessages("Berhasil disimpan..")
        'Catch e As Exception
        '    dSO.Tables("_SIF_TpTran").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    dSO.Tables("_tipe_trans_d").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        'End Try

    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvTipeTranKeu.SelectedRowsCount - 1)
        For i = 0 To GvTipeTranKeu.SelectedRowsCount - 1
            rows(i) = GvTipeTranKeu.GetDataRow(GvTipeTranKeu.GetSelectedRows(i))
        Next
        GvTipeTranKeu.BeginSort()
        Try
            For Each row In rows
                row.Delete()
                showMessages("dihapus")
            Next
        Finally
            GvTipeTranKeu.EndSort()
        End Try
        simpan()
    End Sub

    Public Sub hapus_dtl_record()
        Dim builder As New SqlCommandBuilder(DA1)
        Dim row As DataRow
        Dim rows1() As DataRow
        Dim i As Integer

        If gvtran_d.GetSelectedRows.Count > 0 Then
            gvtran_d.DeleteSelectedRows()
        End If

        ReDim rows1(gvtran_d.SelectedRowsCount - 1)
        For i = 0 To gvtran_d.SelectedRowsCount - 1
            rows1(i) = gvtran_d.GetDataRow(gvtran_d.GetSelectedRows(i))
        Next
        gvtran_d.BeginSort()
        Try
            For Each row In rows1
                row.Delete()
                showMessages("dihapus")
            Next
        Finally
            gvtran_d.EndSort()
        End Try
        'simpan()
    End Sub


    Private Sub frmMstTipeTranKeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.SIF_TIPE_TRANS", sqlconn))
        DA.Fill(dSO, "_SIF_TpTran")
        'GcTipeTranKeu.DataSource = dSO.Tables("_SIF_TpTran")

        DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from KOPKAR.dbo.SIF_TIPE_TRANS_D", sqlconn))
        DA1.Fill(dSO, "_tipe_trans_d")

        Dim rl As DataRelation
        rl = dSO.Relations.Add("Detail", dSO.Tables("_SIF_TpTran").Columns("tipe_trans"), dSO.Tables("_tipe_trans_d").Columns("tipe_trans"))

        GcTipeTranKeu.DataSource = dSO.Tables("_SIF_TpTran")
        GcTipeTranKeu.LevelTree.Nodes.Add("Detail", gvtran_d)

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lookupbesar.DataSource = ds_cari.Tables("_lookup1")
        Lookupbesar.ValueMember = "kd_buku_besar"
        Lookupbesar.DisplayMember = "nm_buku_besar"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_buku_pusat, nm_buku_pusat from KOPKAR.dbo.SIF_buku_pusat", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        Lookuppusat.DataSource = ds_cari.Tables("_lookup2")
        Lookuppusat.ValueMember = "kd_buku_pusat"
        Lookuppusat.DisplayMember = "nm_buku_pusat"
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
    '    ctk_print()
    'End Sub
    Public Sub cetak_click()
        ctk_print()
    End Sub

    Public Sub ctk_print()
        GcTipeTranKeu.Refresh()
        GcTipeTranKeu.ShowPrintPreview()
    End Sub

    Private Sub GvTipeTranKeu_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvTipeTranKeu.CellValueChanged
        Dim vtipe As String
        vtipe = GvTipeTranKeu.GetRowCellValue(e.RowHandle, "tipe_trans").ToString
        'showMessages(vtipe)
    End Sub

    Private Sub gvtran_d_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvtran_d.KeyDown
        Dim x As Object

        If e.KeyCode = Keys.Delete Then
            If MsgBox("Delete Selected Row ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                x = CType(GvTipeTranKeu.GetDetailView(rhandle, 0), DevExpress.XtraGrid.Views.Grid.GridView)
                If x.SelectedRowsCount > 0 Then
                    x.DeleteSelectedRows()
                End If
            End If
           
        End If

    End Sub

    Private Sub GvTipeTranKeu_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GvTipeTranKeu.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub

  
End Class
