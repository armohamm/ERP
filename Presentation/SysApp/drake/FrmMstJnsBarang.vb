'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmMstJnsBarang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1, ds_cari2 As New DataSet
    Dim drukuran As SqlDataReader
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter

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

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Public Sub delete_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub
    Private Function getNextNumber() As String
        Dim hasil, temp As String
        drUkuran = New SqlCommand("SELECT MAX(u.Kd_Jns_Brg)+1 FROM SIF.dbo.SIF_Jenis_Barang u", sqlconn).ExecuteReader
        drUkuran.Read()
        temp = ""
        If TypeOf drUkuran.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = drUkuran.Item(0)
            For i As Int16 = CInt(Len(hasil)) To 2
                temp = "0" & temp
            Next
            hasil = temp & hasil
        End If
        drUkuran.Close()
        Return hasil
    End Function
    Private Sub GvJnsPersd_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles GvJnsBarang.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("Kd_Jns_Brg"), getNextNumber)
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

    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_SIF_JnsBrg").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = getKodeCabang()
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
        DA.Update(dSO, "_SIF_JnsBrg")
        dSO.Tables("_SIF_JnsBrg").AcceptChanges()
        showMessages("Data Berhasil di update..!", 14)
    End Sub

    Public Sub hapus_record()
        'Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvJnsBarang.SelectedRowsCount - 1)
        For i = 0 To GvJnsBarang.SelectedRowsCount - 1
            rows(i) = GvJnsBarang.GetDataRow(GvJnsBarang.GetSelectedRows(i))
        Next
        GvJnsBarang.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvJnsBarang.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMstPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Jenis_Barang", sqlconn))
        DA.Fill(dSO, "_SIF_JnsBrg")
        GcJnsBarang.DataSource = dSO.Tables("_SIF_JnsBrg")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupJnsPsd.DataSource = ds_cari.Tables("_lookup1")
        LookupJnsPsd.ValueMember = "Kd_Jns_Persd"
        LookupJnsPsd.DisplayMember = "Nama_Persediaan"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupDept.DataSource = ds_cari1.Tables("_lookup2")
        LookupDept.ValueMember = "Kd_Departemen"
        LookupDept.DisplayMember = "Nama_Departemen"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Ref_Role='SIF' and Id_Ref_Data='GRPJNS'", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup3")
        LookupGroup.DataSource = ds_cari2.Tables("_lookup3")
        LookupGroup.ValueMember = "Id_Data"
        LookupGroup.DisplayMember = "Desc_Data"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
End Class