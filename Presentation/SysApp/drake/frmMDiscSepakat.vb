'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMDiscSepakat
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter

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

    Public Sub delete_click()
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
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
        For Each rw As DataRow In dSO.Tables("_SIF_DiscOK").Rows
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
        DA.Update(dSO, "_SIF_DiscOK")
        dSO.Tables("_SIF_DiscOK").AcceptChanges()
        showMessages("Perubahan Data Sukses terupdate", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMDiscSepakat.SelectedRowsCount - 1)
        For i = 0 To GvMDiscSepakat.SelectedRowsCount - 1
            rows(i) = GvMDiscSepakat.GetDataRow(GvMDiscSepakat.GetSelectedRows(i))
        Next
        GvMDiscSepakat.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMDiscSepakat.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmDiscSepakat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Diskon_Kesepakatan", sqlconn))
        DA.Fill(dSO, "_SIF_DiscOK")
        GcMDiscSepakat.DataSource = dSO.Tables("_SIF_DiscOK")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from SIF.dbo.SIF_Customer", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        Lookup.DataSource = ds_cari.Tables("_lookup")
        Lookup.ValueMember = "Kd_Customer"
        Lookup.DisplayMember = "Nama_Customer"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub
End Class