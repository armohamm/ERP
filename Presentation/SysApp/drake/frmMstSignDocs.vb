'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMstSignDocs
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnDelete = True
        btnEdit = False
        btnadd = False
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
        For Each rw As DataRow In dSO.Tables("_SIF_ttd").Rows
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
        'DA.UpdateCommand = builder.GetUpdateCommand()
        'DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "_SIF_ttd")
        dSO.Tables("_SIF_ttd").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub
    Public Sub delete_click()
       hapus_record()

    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(Gvttd.SelectedRowsCount - 1)
        For i = 0 To Gvttd.SelectedRowsCount - 1
            rows(i) = Gvttd.GetDataRow(Gvttd.GetSelectedRows(i))
        Next
        Gvttd.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            Gvttd.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMstSignDocs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Penandatangan", sqlconn))
        DA.Fill(dSO, "_SIF_ttd")
        Gcttd.DataSource = dSO.Tables("_SIF_ttd")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai,Nama_Pegawai,Kode_Jabatan from SIF.dbo.SIF_Pegawai", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupkdPeg.DataSource = ds_cari.Tables("_lookup1")
        LookupkdPeg.ValueMember = "Kode_Pegawai"
        LookupkdPeg.DisplayMember = "Nama_Pegawai"


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Jabatan,Nama_Jabatan from SIF.dbo.SIF_Jabatan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupJab.DataSource = ds_cari1.Tables("_lookup2")
        LookupJab.ValueMember = "Kode_Jabatan"
        LookupJab.DisplayMember = "Nama_Jabatan"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()

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

  
    Private Sub Gvttd_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gvttd.CellValueChanged
        If e.Column Is kd_peg Then 'masih revisi
            Dim row As DataRow
            row = ds_cari.Tables("_lookup1").Select("Kode_Pegawai='" & e.Value & "'")(0)
            Gvttd.GetRow(e.RowHandle).item("nama_peg") = row("Nama_Pegawai")

        ElseIf e.Column Is nama_peg Then
            Dim row1 As DataRow
            row1 = ds_cari1.Tables("lookup2").Select("select Kode_Jabatan where Nama_Pegawai='" & e.Value & "'")(0)
            Gvttd.GetRow(e.RowHandle).item("nama_jab") = row1("Kode_Jabatan")

        End If

    End Sub

  
End Class