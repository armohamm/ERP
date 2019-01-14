'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'= ditambahkan samsul
'======================================================================

Imports System.Data.SqlClient

Public Class frmMDiscReguler2
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter
    Dim rhandle As Int32

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
        For Each rw As DataRow In dSO.Tables("_SIF_DiscReg").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = kdcabang
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
        DA.Update(dSO, "_SIF_DiscReg")
        dSO.Tables("_SIF_DiscReg").AcceptChanges()
        showMessages("Perubahan Data Sukses terupdate", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMDiscReg.SelectedRowsCount - 1)
        For i = 0 To GvMDiscReg.SelectedRowsCount - 1
            rows(i) = GvMDiscReg.GetDataRow(GvMDiscReg.GetSelectedRows(i))
        Next
        GvMDiscReg.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMDiscReg.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMstDiscReguler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Diskon_Reguler", sqlconn))
        DA.Fill(dSO, "_SIF_DiscReg")
        GcMDiscReg.DataSource = dSO.Tables("_SIF_DiscReg")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_Jenis_Barang where isnull(rec_stat,'')='Y' union select '%%','ALL'", sqlconn))
        DALOOKUP.Fill(ds_cari, "jenis")
        repjnsBarang.DataSource = ds_cari.Tables("jenis")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Merk, Kode_Tipe, Nama_Tipe from SIF.dbo.SIF_Tipe union select '%%', '%%', 'ALL' ", sqlconn))
        DALOOKUP.Fill(ds_cari, "tipe")
        repTipe.DataSource = ds_cari.Tables("tipe")

        LookUp.DataSource = ds_cari.Tables("_lookup")
        LookUp.ValueMember = "Kd_Departemen"
        LookUp.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select [Kode_Merk],[Nama_Merk] from [SIF].[dbo].[SIF_Merk]", sqlconn))
        DALOOKUP.Fill(ds_cari, "kd_jenis")
        repMerk.DataSource = ds_cari.Tables("kd_jenis")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select [Kd_Jns_Brg],[Nama_Jenis] from [SIF].[dbo].[SIF_Jenis_Barang] union select '%%', 'ALL'", sqlconn))
        DALOOKUP.Fill(ds_cari, "jenis_barang")
        repjnsBarang.DataSource = ds_cari.Tables("jenis_barang")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Ukuran, Nama_Ukuran from [SIF].[dbo].[SIF_Ukuran] where isnull(rec_stat,'')='Y' union select '%%', 'ALL'", sqlconn))
        DALOOKUP.Fill(ds_cari, "ukuran")
        repUkuran.DataSource = ds_cari.Tables("ukuran")

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

    Private Sub GvMDiscReg_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvMDiscReg.CellValueChanged
        If e.Column Is KD_JENIS Then GvMDiscReg.SetRowCellValue(e.RowHandle, "Kode_Tipe", Nothing)
    End Sub

    Private Sub GvMDiscReg_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvMDiscReg.InitNewRow
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Kd_Departemen", kddep)
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Diskon1", "0")
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Diskon2", "0")
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Diskon3", "0")
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Diskon4", "0")
        GvMDiscReg.SetRowCellValue(e.RowHandle, "Diskon5", "0")
        rhandle = e.RowHandle
    End Sub

    Private Sub repTipe_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repTipe.QueryPopUp
        If GvMDiscReg.GetSelectedRows.Count > 0 Then rhandle = GvMDiscReg.GetSelectedRows(0)
        If GvMDiscReg.GetRowCellValue(rhandle, "KD_MERK") Is Nothing Then e.Cancel = True : Exit Sub

        Dim kode As String = GvMDiscReg.GetRowCellValue(rhandle, "KD_MERK").ToString
        If kode = "" Then e.Cancel = True : Exit Sub
        Dim clone As DataView
        clone = New DataView(ds_cari.Tables("tipe"))
        clone.RowFilter = "Kode_Merk like '" & kode & "'"
        'MsgBox(clone.Count)
        'repTipe.DataSource
        sender.Properties.DataSource = clone
        '        repTipe.DataSource = clone
    End Sub

    Private Sub GvMDiscReg_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvMDiscReg.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvMDiscReg_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GvMDiscReg.RowUpdated
        Dim kddiskon As String
        If e.Row.row.item("Diskon1").ToString() <> "0" And e.Row.row.item("Diskon1").ToString() <> "" Then
            kddiskon = e.Row.row.item("Diskon1").ToString() + "%"
        Else
            kddiskon = "0"
        End If
        If e.Row.row.item("Diskon2").ToString() <> "0" And e.Row.row.item("Diskon2").ToString() <> "" Then
            kddiskon += "+" + e.Row.row.item("Diskon2").ToString() + "%"
        End If
        If e.Row.row.item("Diskon3").ToString() <> "0" And e.Row.row.item("Diskon3").ToString() <> "" Then
            kddiskon += "+" + e.Row.row.item("Diskon3").ToString() + "%"
        End If
        If e.Row.row.item("Diskon4").ToString() <> "0" And e.Row.row.item("Diskon4").ToString() <> "" Then
            kddiskon += "+" + e.Row.row.item("Diskon4").ToString() + "%"
        End If
        If e.Row.row.item("Diskon5").ToString() <> "0" And e.Row.row.item("Diskon5").ToString() <> "" Then
            kddiskon += "+" + e.Row.row.item("Diskon5").ToString() + "%"
        End If
        e.Row.row.item("Kd_Diskon") = kddiskon
    End Sub

    Private Sub GvMDiscReg_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvMDiscReg.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Jenis").ToString = "" Then
            isValid = False
            GvMDiscReg.SetColumnError(JENIS, "Harap Memilih Jenis Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = JENIS
        End If
        If e.Row.item("KD_MERK").ToString = "" Then
            isValid = False
            GvMDiscReg.SetColumnError(KD_JENIS, "Harap Memilih Merk Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = KD_JENIS
        End If
        If e.Row.item("Kode_Tipe").ToString = "" Then
            isValid = False
            GvMDiscReg.SetColumnError(Kode_Tipe, "Harap Memilih Tipe Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = Kode_Tipe
        End If
        If e.Row.item("Ukuran").ToString = "" Then
            isValid = False
            GvMDiscReg.SetColumnError(Ukuran, "Harap Memilih Ukuran Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = Ukuran
        End If
        If e.Row.item("Diskon1").ToString = "" Then
            isValid = False
            GvMDiscReg.SetColumnError(Diskon1, "Harap Mengisi Diskon1 Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = Diskon1
        ElseIf e.Row.item("Diskon1") < 0 Or e.Row.item("Diskon1") > 100 Then
            isValid = False
            GvMDiscReg.SetColumnError(Diskon1, "Harap Mengisi Diskon 1 Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvMDiscReg.FocusedColumn = Diskon1
        End If
        If e.Row.item("Diskon2").ToString <> "" Then
            If e.Row.item("Diskon2") < 0 Or e.Row.item("Diskon2") > 100 Then
                isValid = False
                GvMDiscReg.SetColumnError(Diskon2, "Harap Mengisi Diskon 2 Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.FocusedColumn = Diskon2
            End If
        End If
        If e.Row.item("Diskon3").ToString <> "" Then
            If e.Row.item("Diskon3") < 0 Or e.Row.item("Diskon3") > 100 Then
                isValid = False
                GvMDiscReg.SetColumnError(Diskon3, "Harap Mengisi Diskon 3 Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.FocusedColumn = Diskon3
            End If
        End If
        If e.Row.item("Diskon4").ToString <> "" Then
            If e.Row.item("Diskon4") < 0 Or e.Row.item("Diskon4") > 100 Then
                isValid = False
                GvMDiscReg.SetColumnError(Diskon4, "Harap Mengisi Diskon 4 Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.FocusedColumn = Diskon4
            End If
        End If
        If e.Row.item("Diskon5").ToString <> "" Then
            If e.Row.item("Diskon5") < 0 Or e.Row.item("Diskon5") > 100 Then
                isValid = False
                GvMDiscReg.SetColumnError(Diskon5, "Harap Mengisi Diskon 5 Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.FocusedColumn = Diskon5
            End If
        End If

        Dim rw() As DataRow = dSO.Tables("_SIF_DiscReg").Select("KD_MERK = '" & e.Row.item("KD_MERK") & "' and Kode_Tipe= '" & e.Row.item("Kode_Tipe") & "' and Ukuran = '" & e.Row.item("Ukuran") & "' and Kd_Jenis = '" & e.Row.item("Kd_Jenis") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GvMDiscReg.SetColumnError(KD_JENIS, "Merk, Tipe, Jenis dan Ukuran Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.SetColumnError(JENIS, "Merk, Tipe, Jenis dan Ukuran Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.SetColumnError(Kode_Tipe, "Merk, Tipe, Jenis dan Ukuran  Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvMDiscReg.SetColumnError(Ukuran, "Merk, Tipe, Jenis dan Ukuran  Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)

            End If
        End If
        e.Valid = isValid
    End Sub
End Class