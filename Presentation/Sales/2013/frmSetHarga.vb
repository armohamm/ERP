Imports System.Data.SqlClient

Public Class frmSetHarga
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_brg, ds_jnbrg, ds_merk As New DataSet
    Dim builder As New SqlCommandBuilder
    'Private rw As DataRow
    Dim DA, DA_brg, DA_jnbrg, DA_merk As SqlClient.SqlDataAdapter

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
    Public Sub cetak_click()
        print_gc(GcMstHarga, "Price List", True)
    End Sub
    Public Sub simpan()
        If dSO.Tables("_SIF_mHarga").Select("isnull(end_date,'')<>''", "").Count > 0 Then

            For Each row As DataRow In dSO.Tables("_SIF_mHarga").Select("isnull(end_date,'')=''", "")
                row.Delete()
            Next
        Else
            showMessages("Data Harga Baru Belum Diisi")
            Exit Sub
        End If
        If Not dSO.Tables("SIF_Harga") Is Nothing Then dSO.Tables("SIF_Harga").Clear()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * from sif.dbo.sif_harga where 1=0", sqlconn))
        DA.Fill(dSO, "SIF_Harga")

        For Each rw As DataRow In dSO.Tables("_SIF_mHarga").Rows
            Dim newrow As DataRow = dSO.Tables("SIF_Harga").NewRow
            newrow("Kd_Cabang") = kdcabang
            newrow("Kode_Barang") = rw("Kode_Barang")
            newrow("Start_Date") = rw("end_date")
            newrow("Harga_Rupiah") = rw("rp_new")
            newrow("Harga_Dollar") = rw("usd_new")
            newrow("Rec_Stat") = "Y"
            newrow("kd_merk") = rw("kd_merk")
            newrow("kd_tipe") = rw("kd_tipe")
            newrow("Last_Create_Date") = getTanggal()
            newrow("Last_Created_By") = umum.username
            newrow("Program_Name") = Me.Name
            dSO.Tables("SIF_Harga").Rows.Add(newrow)
        Next


        builder = New SqlClient.SqlCommandBuilder(DA)
        builder.ConflictOption = ConflictOption.OverwriteChanges
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "SIF_Harga")
        dSO.Tables("SIF_Harga").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMstHarga.SelectedRowsCount - 1)
        For i = 0 To GvMstHarga.SelectedRowsCount - 1
            rows(i) = GvMstHarga.GetDataRow(GvMstHarga.GetSelectedRows(i))
        Next
        GvMstHarga.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMstHarga.EndSort()
        End Try
        simpan()
    End Sub


    Private Sub frmMstHarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'ds_cari = New DataSet
        DA = New SqlDataAdapter(New SqlCommand("SELECT '0' pilih, 0 rp_new, 0 usd_new , '' as end_date, Nama_Barang, kd_jenis, kd_merk,kd_tipe kd_tipex, kd_merk + 'x' + kd_tipe kd_tipe, kd_tipe + 'x' + kd_sub_tipe as kd_sub_tipe, kd_ukuran, kd_kain, kode_barang  FROM sif.dbo.sif_barang b where kd_jns_persd in ('1','2','3') and rec_stat='Y'", sqlconn))
        DA.Fill(dSO, "_SIF_mHarga")
        GcMstHarga.DataSource = dSO.Tables("_SIF_mHarga")

        DA_jnbrg = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg,Nama_Jenis from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        DA_jnbrg.Fill(ds_jnbrg, "_lu_jnbrg")
        RL_jnbrg.DataSource = ds_jnbrg.Tables("_lu_jnbrg")
        RL_jnbrg.ValueMember = "Kd_Jns_Brg"
        RL_jnbrg.DisplayMember = "Nama_Jenis"

        DA_merk = New SqlDataAdapter(New SqlCommand("select Kode_Merk,Nama_Merk from SIF.dbo.SIF_Merk where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_merk")
        RL_merk.DataSource = ds_merk.Tables("_lu_merk")
        RL_merk.ValueMember = "Kode_Merk"
        RL_merk.DisplayMember = "Nama_Merk"

        DA_merk = New SqlDataAdapter(New SqlCommand("select kode_merk + 'x' + Kode_tipe as Kode_tipe ,Nama_Tipe from SIF.dbo.SIF_tipe where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_tipe")
        repTipe.DataSource = ds_merk.Tables("_lu_tipe")
        repTipe.ValueMember = "Kode_tipe"
        repTipe.DisplayMember = "Nama_Tipe"

        DA_merk = New SqlDataAdapter(New SqlCommand("select kd_tipe + 'x' + Kd_sub_tipe as Kode_sub_tipe ,Nama_sub_Tipe from SIF.dbo.SIF_sub_tipe where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_sub_tipe")
        repSubTipe.DataSource = ds_merk.Tables("_lu_sub_tipe")
        repSubTipe.ValueMember = "Kode_sub_tipe"
        repSubTipe.DisplayMember = "Nama_sub_Tipe"

        DA_merk = New SqlDataAdapter(New SqlCommand("select kode_ukuran, nama_ukuran from SIF.dbo.SIF_ukuran where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_ukuran")
        repUkuran.DataSource = ds_merk.Tables("_lu_ukuran")
        repUkuran.ValueMember = "kode_ukuran"
        repUkuran.DisplayMember = "nama_ukuran"

        DA_merk = New SqlDataAdapter(New SqlCommand("select kode_kain as kode_kain, Merk_Kain from SIF.dbo.SIF_kain where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_kain")
        repKain.DataSource = ds_merk.Tables("_lu_kain")
        repKain.ValueMember = "kode_kain"
        repKain.DisplayMember = "Merk_Kain"

        'prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'btnSimpan.Hide()
        'btnExit.Hide()
        'btnDel.Hide()
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

    Private Sub txtCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ftr As String = "Nama Like '%" & txtCari.Text & "%'"
            GvMstHarga.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)

        End If
    End Sub

    Private Sub GvMstHarga_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvMstHarga.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvMstHarga_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvMstHarga.ValidateRow
        'Dim isValid As Boolean = True
        'If e.Row Is Nothing Then Exit Sub
        'If e.Row.item("rp_new").ToString = "" And e.Row.item("usd_new").ToString = "" And e.Row.item("end_date").ToString <> "" Then
        '    isValid = False
        'ElseIf (e.Row.item("rp_new").ToString <> "" Or e.Row.item("usd_new").ToString <> "") And e.Row.item("end_date").ToString = "" Then
        '    isValid = False
        'ElseIf e.Row.item("rp_new").ToString <> "" Then
        '    If e.Row.item("rp_new").ToString <= 0 Then
        '        sender.SetColumnError(HargaRpBaru, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '        isValid = False
        '    End If
        'ElseIf e.Row.item("usd_new").ToString <> "" Then
        '    If e.Row.item("usd_new").ToString <= 0 Then
        '        sender.SetColumnError(HargaUsdBaru, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '        isValid = False
        '    End If
        'End If
        'e.Valid = isValid
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Dispose()
    End Sub

    Private Sub btnTerapkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerapkan.Click
        Dim owner As Object = frmMain.pnlDisplay2.Controls(0)
        owner.dSOt.Tables.Clear()
        dSO.AcceptChanges()
        owner.dSOt = dSO.Clone

        For Each item As DataRow In dSO.Tables(0).Select("pilih='1'")
            Dim newrow As DataRow = owner.dSOt.Tables(0).NewRow
            newrow("kode_barang") = item("kode_barang")
            newrow("end_date") = item("end_date")
            newrow("rp_new") = item("rp_new")
            newrow("usd_new") = item("usd_new")
            newrow("kd_merk") = item("kd_merk")
            newrow("kd_tipex") = item("kd_tipex")
            newrow("kd_jenis") = item("kd_jenis")
            owner.dSOt.Tables(0).Rows.Add(newrow)
        Next
        Me.Dispose()
    End Sub
End Class