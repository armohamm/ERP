'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls


Public Class frmMstUltahCustomer
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter
    Dim bulan, hari As String
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        connect()
        'DA = New SqlDataAdapter(New SqlCommand("Select c.Kd_Customer, c.Nama_Customer,C.Alamat1, c.No_Telepon1 " & _
        '                                       ", c.Limit_Piutang_Rupiah, c.Limit_Piutang_Valas " & _
        '                                       "From SIF.dbo.SIF_Customer c ", sqlconn))
        If Not dSO.Tables("_SIF_Cust") Is Nothing Then dSO.Tables("_SIF_Cust").Clear()
        DA = New SqlDataAdapter(New SqlCommand("Select DISTINCT so.Kd_Customer, so.Atas_Nama, so.Almt_pnrm, case WHEN so.Kd_Customer not like 'UMUM' " & _
                                               "then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END as tgl_lahir , so.No_Telp " & _
                                               "From SALES.dbo.SALES_SO so " & _
                                               "left join SIF.dbo.SIF_Customer Cs " & _
                                               "on cs.Kd_Customer = so.Kd_Customer " & _
                                               "where so.No_sp like '%SRV%' " & _
                                               "ORDER BY so.Atas_Nama", sqlconn))
        '"and case WHEN so.Kd_Customer not like 'UMUM' " & _
        '"then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END  like '%06-11' " & _


        DA.Fill(dSO, "_SIF_Cust")
        GcTipe.DataSource = dSO.Tables("_SIF_Cust")
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

    Public Sub delete_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)

        For Each rw As DataRow In dSO.Tables("_SIF_Cust").Rows
            If rw.RowState = DataRowState.Added Then
                'rw("Kd_Jns") = "1"
                'rw("Kd_Cabang") = kdcabang
                'rw("Last_Create_Date") = Now
                'rw("Last_Created_By") = umum.username
                'rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If

        Next
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "_SIF_Cust")
        dSO.Tables("_SIF_Cust").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvTipe.SelectedRowsCount - 1)
        For i = 0 To GvTipe.SelectedRowsCount - 1
            rows(i) = GvTipe.GetDataRow(GvTipe.GetSelectedRows(i))
        Next
        GvTipe.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvTipe.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMstTipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'DA = New SqlDataAdapter(New SqlCommand("Select c.Kd_Customer, c.Nama_Customer,C.Alamat1, c.No_Telepon1 " & _
        '                                       ", c.Limit_Piutang_Rupiah, c.Limit_Piutang_Valas " & _
        '                                       "From SIF.dbo.SIF_Customer c ", sqlconn))
        If Not dSO.Tables("_SIF_Cust") Is Nothing Then dSO.Tables("_SIF_Cust").Clear()
        DA = New SqlDataAdapter(New SqlCommand("Select DISTINCT so.Kd_Customer, so.Atas_Nama, so.Almt_pnrm, case WHEN so.Kd_Customer not like 'UMUM' " & _
                                               "then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END as tgl_lahir , so.No_Telp " & _
                                               "From SALES.dbo.SALES_SO so " & _
                                               "left join SIF.dbo.SIF_Customer Cs " & _
                                               "on cs.Kd_Customer = so.Kd_Customer " & _
                                               "where so.No_sp like '%SRV%' " & _
                                               "ORDER BY so.Atas_Nama", sqlconn))
        '"and case WHEN so.Kd_Customer not like 'UMUM' " & _
        '"then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END  like '%06-11' " & _


        DA.Fill(dSO, "_SIF_Cust")
        GcTipe.DataSource = dSO.Tables("_SIF_Cust")

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "cari_barang")
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Merk, Nama_Merk from SIF.dbo.SIF_Merk", sqlconn))
        'DALOOKUP.Fill(ds_cari, "Merk")
        'LookupJnsBrg.DataSource = ds_cari.Tables("cari_barang")
        'LookupJnsBrg.ValueMember = "Kd_Jns_Brg"
        'LookupJnsBrg.DisplayMember = "Nama_Jenis"

        'repMerk.DataSource = ds_cari.Tables("Merk")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    'Private Sub GvTipe_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvTipe.InitNewRow
    '    Dim View As ColumnView = sender
    '    View.SetRowCellValue(e.RowHandle, View.Columns("Kode_Tipe"), GvTipe.RowCount + 1)
    'End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        connect()
        If DE_TglUltah.DateTime.Month < 10 Then
            bulan = "0" & DE_TglUltah.DateTime.Month
        ElseIf DE_TglUltah.DateTime.Month >= 10 Then
            bulan = DE_TglUltah.DateTime.Month
        End If

        If DE_TglUltah.DateTime.Day < 10 Then
            hari = "0" & DE_TglUltah.DateTime.Day
        ElseIf DE_TglUltah.DateTime.Month >= 10 Then
            hari = DE_TglUltah.DateTime.Day
        End If

        'DA = New SqlDataAdapter(New SqlCommand("Select c.Kd_Customer, c.Nama_Customer,C.Alamat1, c.No_Telepon1 " & _
        '                                       ", c.Limit_Piutang_Rupiah, c.Limit_Piutang_Valas " & _
        '                                       "From SIF.dbo.SIF_Customer c ", sqlconn))
        If Not dSO.Tables("_SIF_Cust") Is Nothing Then dSO.Tables("_SIF_Cust").Clear()
        DA = New SqlDataAdapter(New SqlCommand("Select DISTINCT so.Kd_Customer, so.Atas_Nama, so.Almt_pnrm, case WHEN so.Kd_Customer not like 'UMUM' " & _
                                               "then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END as tgl_lahir , so.No_Telp " & _
                                               "From SALES.dbo.SALES_SO so " & _
                                               "left join SIF.dbo.SIF_Customer Cs " & _
                                               "on cs.Kd_Customer = so.Kd_Customer " & _
                                               "where so.No_sp like '%SRV%' " & _
                                               "and case WHEN so.Kd_Customer not like 'UMUM' " & _
                                               "then isnull(cs.Tgl_Lahir,GETDATE()) ELSE so.tgl_lahir_umum END  like '%" & bulan & "-" & hari & "' " & _
                                               "ORDER BY so.Atas_Nama", sqlconn))
        


        DA.Fill(dSO, "_SIF_Cust")
        GcTipe.DataSource = dSO.Tables("_SIF_Cust")
        GcTipe.Refresh()
    End Sub
End Class