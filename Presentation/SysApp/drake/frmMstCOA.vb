'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMstCOA
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_SIF_COA").Rows
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
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "_SIF_COA")
        dSO.Tables("_SIF_COA").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMstCOA.SelectedRowsCount - 1)
        For i = 0 To GvMstCOA.SelectedRowsCount - 1
            rows(i) = GvMstCOA.GetDataRow(GvMstCOA.GetSelectedRows(i))
        Next
        GvMstCOA.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMstCOA.EndSort()
        End Try
        simpan()
    End Sub

    'Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
    '    If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    'End Sub

    'Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    '    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Private Sub loadData()
        If Not dSO.Tables("_SIF_COA") Is Nothing Then dSO.Tables("_SIF_COA").Clear()

        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.m_buku_besar_fixed ", sqlconn))
        DA.Fill(dSO, "_SIF_COA")
        GcMstCOA.DataSource = dSO.Tables("_SIF_COA")
    End Sub

    Private Sub loadUnit()
        If Not ds_cari.Tables("Unit") Is Nothing Then ds_cari.Tables("Unit").Clear()

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select a.Val_kode1,a.Desc_Data from kopkar.dbo.SIF_Gen_Reff_D a where a.Id_Ref_Data = 'UNITKOPKAR' ", sqlconn))
        DALOOKUP3.Fill(ds_cari, "Unit")
        LuvUnit.DataSource = ds_cari.Tables("Unit")
        LuvUnit.DisplayMember = "Desc_Data"
        LuvUnit.ValueMember = "Val_kode1"
    End Sub

    Private Sub loadCFlow()
        If Not ds_cari.Tables("CFlow") Is Nothing Then ds_cari.Tables("CFlow").Clear()

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select a.Val_kode1,a.Desc_Data from kopkar.dbo.SIF_Gen_Reff_D a where a.Id_Ref_Data = 'CFLOWKK'", sqlconn))
        DALOOKUP3.Fill(ds_cari, "CFlow")
        lookCFlow.DataSource = ds_cari.Tables("CFlow")
        lookCFlow.DisplayMember = "Desc_Data"
        lookCFlow.ValueMember = "Val_kode1"
    End Sub

    Private Sub frmMstCOA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        loadData()
        loadUnit()
        loadCFlow()

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT kode_valuta, nama_valuta FROM KOPKAR.dbo.SIF_valuta ", sqlconn))
        DALOOKUP2.Fill(ds_cari, "Valuta")
        LU_Valuta.DataSource = ds_cari.Tables("Valuta")
        LU_Valuta.DisplayMember = "nama_valuta"
        LU_Valuta.ValueMember = "kode_valuta"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()
    End Sub

    Public Sub ctk_print()
        GcMstCOA.Refresh()
        GcMstCOA.ShowPrintPreview()
    End Sub

    Public Sub cetak_click()
        ctk_print()
    End Sub
End Class