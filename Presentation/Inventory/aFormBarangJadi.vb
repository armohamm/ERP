Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class aFormBarangJadi
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsBarangJadi As New DataSet
    Dim daLookUp, daBarangJadi As SqlDataAdapter
    Dim state As String
    Dim bldBarangJadi As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim errValid As Integer = 0
    Dim row As DataRow
    Dim hasil, temp As String
    Dim loaded As Boolean
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsBarangJadi.Tables("Satuan") Is Nothing Then dsBarangJadi.Tables("Satuan").Clear()
        If Not dsBarangJadi.Tables("Departemen") Is Nothing Then dsBarangJadi.Tables("Departemen").Clear()
        If Not dsBarangJadi.Tables("JenisBarang") Is Nothing Then dsBarangJadi.Tables("JenisBarang").Clear()
        If Not dsBarangJadi.Tables("Merk") Is Nothing Then dsBarangJadi.Tables("Merk").Clear()
        If Not dsBarangJadi.Tables("TipeBarang") Is Nothing Then dsBarangJadi.Tables("TipeBarang").Clear()
        If Not dsBarangJadi.Tables("SubTipe") Is Nothing Then dsBarangJadi.Tables("SubTipe").Clear()
        If Not dsBarangJadi.Tables("Ukuran") Is Nothing Then dsBarangJadi.Tables("Ukuran").Clear()
        If Not dsBarangJadi.Tables("Kain") Is Nothing Then dsBarangJadi.Tables("Kain").Clear()
        If Not dsBarangJadi.Tables("Gudang") Is Nothing Then dsBarangJadi.Tables("Gudang").Clear()
        If Not dsBarangJadi.Tables("Rekening") Is Nothing Then dsBarangJadi.Tables("Rekening").Clear()
        If Not dsBarangJadi.Tables("RekeningPersediaan") Is Nothing Then dsBarangJadi.Tables("RekeningPersediaan").Clear()
        If Not dsBarangJadi.Tables("Status") Is Nothing Then dsBarangJadi.Tables("Status").Clear()
        If Not dsBarangJadi.Tables("TipeStok") Is Nothing Then dsBarangJadi.Tables("TipeStok").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Satuan, Nama_Satuan from sif.dbo.SIF_Satuan", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Satuan")
        lckSatuan.Properties.DataSource = dsBarangJadi.Tables("Satuan")
        lckSatuan.Properties.ValueMember = "Kode_Satuan"
        lckSatuan.Properties.DisplayMember = "Nama_Satuan"
        lookupsatuan.DataSource = dsBarangJadi.Tables("Satuan")
        lookupsatuan.ValueMember = "Kode_Satuan"
        lookupsatuan.DisplayMember = "Nama_Satuan"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Departemen")
        lckDivisi.Properties.DataSource = dsBarangJadi.Tables("Departemen")
        lckDivisi.Properties.ValueMember = "Kd_Departemen"
        lckDivisi.Properties.DisplayMember = "Nama_Departemen"
        lookupdepartemen.DataSource = dsBarangJadi.Tables("Departemen")
        lookupdepartemen.ValueMember = "Kd_Departemen"
        lookupdepartemen.DisplayMember = "Nama_Departemen"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg,Nama_Jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        daLookUp.Fill(dsBarangJadi, "JenisBarang")
        lckJenis.Properties.DataSource = dsBarangJadi.Tables("JenisBarang")
        lckJenis.Properties.ValueMember = "Kd_Jns_Brg"
        lckJenis.Properties.DisplayMember = "Nama_Jenis"
        lookupjenisbarang.DataSource = dsBarangJadi.Tables("JenisBarang")
        lookupjenisbarang.ValueMember = "Kd_Jns_Brg"
        lookupjenisbarang.DisplayMember = "Nama_Jenis"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk,Nama_Merk from sif.dbo.SIF_Merk", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Merk")
        lckMerk.Properties.DataSource = dsBarangJadi.Tables("Merk")
        lckMerk.Properties.ValueMember = "Kode_Merk"
        lckMerk.Properties.DisplayMember = "Nama_Merk"
        lookupmerk.DataSource = dsBarangJadi.Tables("Merk")
        lookupmerk.ValueMember = "Kode_Merk"
        lookupmerk.DisplayMember = "Nama_Merk"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe", sqlconn))
        daLookUp.Fill(dsBarangJadi, "TipeBarang")
        lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
        lckTipe.Properties.ValueMember = "Kode_Tipe"
        lckTipe.Properties.DisplayMember = "Nama_Tipe"
        lookuptipe.DataSource = dsBarangJadi.Tables("TipeBarang")
        lookuptipe.ValueMember = "Kode_Tipe"
        lookuptipe.DisplayMember = "Nama_Tipe"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe", sqlconn))
        daLookUp.Fill(dsBarangJadi, "SubTipe")
        lckSubTipe.Properties.DataSource = dsBarangJadi.Tables("SubTipe")
        lckSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        lckSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
        lookupsubtipe.DataSource = dsBarangJadi.Tables("SubTipe")
        lookupsubtipe.ValueMember = "Kd_Sub_Tipe"
        lookupsubtipe.DisplayMember = "Nama_Sub_Tipe"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Ukuran")
        lckUkuran.Properties.DataSource = dsBarangJadi.Tables("Ukuran")
        lckUkuran.Properties.ValueMember = "Kode_Ukuran"
        lckUkuran.Properties.DisplayMember = "Nama_Ukuran"
        lookupukuran.DataSource = dsBarangJadi.Tables("Ukuran")
        lookupukuran.ValueMember = "Kode_Ukuran"
        lookupukuran.DisplayMember = "Nama_Ukuran"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain,Merk_Kain from sif.dbo.SIF_Kain", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Kain")
        lckKain.Properties.DataSource = dsBarangJadi.Tables("Kain")
        lckKain.Properties.ValueMember = "Kode_Kain"
        lckKain.Properties.DisplayMember = "Merk_Kain"
        lookupkain.DataSource = dsBarangJadi.Tables("Kain")
        lookupkain.ValueMember = "Kode_Kain"
        lookupkain.DisplayMember = "Merk_Kain"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang,Nama_Gudang from sif.dbo.SIF_Gudang", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Gudang")
        lckGudang.Properties.DataSource = dsBarangJadi.Tables("Gudang")
        lckGudang.Properties.ValueMember = "Kode_Gudang"
        lckGudang.Properties.DisplayMember = "Nama_Gudang"
        lookuplokasi.DataSource = dsBarangJadi.Tables("Gudang")
        lookuplokasi.ValueMember = "Kode_Gudang"
        lookuplokasi.DisplayMember = "Nama_Gudang"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar where grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Rekening")
        lckRekJual1.Properties.DataSource = dsBarangJadi.Tables("Rekening")
        lckRekJual1.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJual1.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenj1.DataSource = dsBarangJadi.Tables("Rekening")
        lookuppenj1.ValueMember = "Kd_Buku_Besar"
        lookuppenj1.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar where grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekeningPersediaan")
        lckRek.Properties.DataSource = dsBarangJadi.Tables("RekeningPersediaan")
        lckRek.Properties.ValueMember = "Kd_Buku_Besar"
        lckRek.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenj3.DataSource = dsBarangJadi.Tables("RekeningPersediaan")
        lookuppenj3.ValueMember = "Kd_Buku_Besar"
        lookuppenj3.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 'Y' as kode, 'Aktif' as stat UNION SELECT 'T', 'Tidak Aktif'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Status")
        lckStatus.Properties.DataSource = dsBarangJadi.Tables("Status")
        lckStatus.Properties.ValueMember = "kode"
        lckStatus.Properties.DisplayMember = "stat"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 'FAST MOVING' as kode, 'Fast Moving' as stat UNION SELECT 'SLOW MOVING', 'Slow Moving'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "TipeStok")
        lckTipeStok.Properties.DataSource = dsBarangJadi.Tables("TipeStok")
        lckTipeStok.Properties.ValueMember = "kode"
        lckTipeStok.Properties.DisplayMember = "stat"
        lookuptipestok.DataSource = dsBarangJadi.Tables("TipeStok")
        lookuptipestok.ValueMember = "kode"
        lookuptipestok.DisplayMember = "stat"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from sif.dbo.SIF_Jns_Persediaan", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Jenis_Persediaan")
        lookupjnspersediaan.DataSource = dsBarangJadi.Tables("Jenis_Persediaan")
        lookupjnspersediaan.ValueMember = "Kd_Jns_Persd"
        lookupjnspersediaan.DisplayMember = "Nama_Persediaan"
    End Sub

    Private Sub loadGrid()
        If Not dsBarangJadi.Tables("BarangJadi") Is Nothing Then dsBarangJadi.Tables("BarangJadi").Clear()
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE kd_jns_persd='1'", sqlconn))
        daBarangJadi.Fill(dsBarangJadi, "BarangJadi")
        gcBarangJadi.DataSource = dsBarangJadi.Tables("BarangJadi")
        gvBarangJadi.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsBarangJadi.Tables("Barang") Is Nothing Then dsBarangJadi.Tables("Barang").Clear()
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & kode & "'", sqlconn))
        daBarangJadi.Fill(dsBarangJadi, "Barang")
        gvBarangJadi.BestFitColumns()

        If dsBarangJadi.Tables("Barang").Rows.Count > 0 Then
            txtNamaBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Nama_Barang")
            lckSatuan.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kd_Satuan")
            lckDivisi.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kd_Depart")
            lckJenis.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_jenis")
            lckTipe.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_tipe")
            lckMerk.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_merk")
            lckSubTipe.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_sub_tipe")
            lckUkuran.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_ukuran")
            lckKain.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_kain")
            lckGudang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("lokasi")
            lckStatus.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Rec_Stat")
            lckTipeStok.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("tipe_stok")
            lckRek.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_persediaan")
            lckRekJual1.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_penjualan1")
            txtStokMin.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_min")
            txtStokMax.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_max_av")
            txtKet.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Keterangan")
        End If
    End Sub

    Private Sub aFormBarangJadi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        lckRek.EditValue = "1-611000"
        txtStokMax.EditValue = "0"
        txtStokMin.EditValue = "0"
        loadData("xxx")
        loadGrid()
        state = "ADD"
        'txtNamaBarang.Focus()
    End Sub

    Private Sub control_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNamaBarang.Validating, lckSatuan.Validating, lckDivisi.Validating, lckJenis.Validating, lckMerk.Validating, lckTipe.Validating, lckSubTipe.Validating, lckUkuran.Validating, lckKain.Validating, lckTipeStok.Validating, lckRek.Validating, lckRekJual1.Validating
        errValid = 0
        If txtNamaBarang.EditValue = "" Or txtNamaBarang.EditValue = vbNullString Then
            errData.SetError(txtNamaBarang, "Nama barang tidak boleh kosong.")
            errData.SetIconAlignment(txtNamaBarang, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckSatuan.EditValue = vbNullString Then
            errData.SetError(lckSatuan, "Satuan harus dipilih.")
            errData.SetIconAlignment(lckSatuan, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckDivisi.EditValue = vbNullString Then
            errData.SetError(lckDivisi, "Divisi harus dipilih.")
            errData.SetIconAlignment(lckDivisi, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckJenis.EditValue = vbNullString Then
            errData.SetError(lckJenis, "Jenis barang harus dipilih.")
            errData.SetIconAlignment(lckJenis, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckMerk.EditValue = vbNullString Then
            errData.SetError(lckMerk, "Merk harus dipilih.")
            errData.SetIconAlignment(lckMerk, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckTipe.EditValue = vbNullString Then
            errData.SetError(lckTipe, "Tipe barang harus dipilih.")
            errData.SetIconAlignment(lckTipe, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckSubTipe.EditValue = vbNullString Then
            errData.SetError(lckSubTipe, "Sub tipe harus dipilih.")
            errData.SetIconAlignment(lckSubTipe, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckUkuran.EditValue = vbNullString Then
            errData.SetError(lckUkuran, "Ukuran harus dipilih.")
            errData.SetIconAlignment(lckUkuran, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckKain.EditValue = vbNullString Then
            errData.SetError(lckKain, "Kain harus dipilih.")
            errData.SetIconAlignment(lckKain, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckTipeStok.EditValue = vbNullString Then
            errData.SetError(lckTipeStok, "Tipe stok harus dipilih.")
            errData.SetIconAlignment(lckTipeStok, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckRek.EditValue = vbNullString Then
            errData.SetError(lckRek, "Rekening persediaan harus dipilih.")
            errData.SetIconAlignment(lckRek, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckRekJual1.EditValue = vbNullString Then
            errData.SetError(lckRekJual1, "Rekening jual 1 harus dipilih.")
            errData.SetIconAlignment(lckRekJual1, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckGudang.EditValue = vbNullString Then
            errData.SetError(lckGudang, "Alokasi gudang harus dipilih.")
            errData.SetIconAlignment(lckGudang, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
        If lckStatus.EditValue = vbNullString Then
            errData.SetError(lckStatus, "Status harus dipilih.")
            errData.SetIconAlignment(lckStatus, ErrorIconAlignment.MiddleRight)
            errValid += 1
        Else
            errData.ClearErrors()
        End If
    End Sub

    Private Sub cek()
        If errValid > 0 Or txtNamaBarang.EditValue = vbNullString Then
            isValid = False
        End If
    End Sub

    Public Sub cancel_click()
        txtNamaBarang.EditValue = vbNullString
        txtNamaBarang.Focus()
        lckSatuan.EditValue = vbNullString
        lckDivisi.EditValue = vbNullString
        lckJenis.EditValue = vbNullString
        lckTipe.EditValue = vbNullString
        lckMerk.EditValue = vbNullString
        lckSubTipe.EditValue = vbNullString
        lckUkuran.EditValue = vbNullString
        lckKain.EditValue = vbNullString
        lckGudang.EditValue = vbNullString
        lckStatus.EditValue = vbNullString
        lckTipeStok.EditValue = vbNullString
        lckRek.EditValue = vbNullString
        lckRekJual1.EditValue = vbNullString
        txtStokMin.EditValue = "0"
        txtStokMax.EditValue = "0"
        txtKet.EditValue = vbNullString
        errData.ClearErrors()
        errValid = 0
    End Sub

    Private Sub kodebarang()
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '" & lckDivisi.EditValue & "' AND kd_jns_persd = '1' AND kd_jenis= '" & lckJenis.EditValue & "' AND kd_merk='" & lckMerk.EditValue & "' AND kd_tipe= '" & lckTipe.EditValue & "' AND kd_sub_tipe= '" & lckSubTipe.EditValue & "' AND kd_ukuran='" & lckUkuran.EditValue & "'AND kd_kain= '" & lckKain.EditValue & "' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "01"
            hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If True Then
                If MsgBox("Simpan master barang jadi?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If state = "ADD" Then
                        kodebarang()
                        txtKodeBarang.EditValue = hasil
                        row = dsBarangJadi.Tables("Barang").NewRow
                        row.Item("Kd_Cabang") = getKodeCabang()
                        row.Item("Kd_jns_persd") = "1"
                        row.Item("Kode_Barang") = txtKodeBarang.EditValue
                        row.Item("no_urut") = temp
                        row.Item("Last_Create_Date") = getTanggal()
                        row.Item("Last_Created_By") = username
                        row.Item("Program_Name") = Me.Name
                        row.Item("Kd_Satuan") = lckSatuan.EditValue
                        row.Item("tipe_stok") = lckTipeStok.EditValue
                        row.Item("Kd_Depart") = lckDivisi.EditValue
                        row.Item("kd_jenis") = lckJenis.EditValue
                        row.Item("kd_merk") = lckMerk.EditValue
                        row.Item("kd_tipe") = lckTipe.EditValue
                        row.Item("kd_sub_tipe") = lckSubTipe.EditValue
                        row.Item("kd_ukuran") = lckUkuran.EditValue
                        row.Item("kd_kain") = lckKain.EditValue
                        row.Item("Nama_Barang") = txtNamaBarang.EditValue
                        row.Item("lokasi") = lckGudang.EditValue
                        row.Item("stok_min") = txtStokMin.EditValue
                        row.Item("stok_max_av") = txtStokMax.EditValue
                        row.Item("Keterangan") = txtKet.Text
                        row.Item("rek_penjualan1") = lckRekJual1.EditValue
                        row.Item("rek_persediaan") = lckRek.EditValue
                        row.Item("Rec_Stat") = lckStatus.EditValue
                        dsBarangJadi.Tables("Barang").Rows.Add(row)
                    ElseIf state = "EDIT" Then
                        row = dsBarangJadi.Tables("Barang").Rows(0)
                        row.Item("Kd_Satuan") = lckSatuan.EditValue
                        row.Item("tipe_stok") = lckTipeStok.EditValue
                        row.Item("Kd_Depart") = lckDivisi.EditValue
                        row.Item("kd_jenis") = lckJenis.EditValue
                        row.Item("kd_merk") = lckMerk.EditValue
                        row.Item("kd_tipe") = lckTipe.EditValue
                        row.Item("kd_sub_tipe") = lckSubTipe.EditValue
                        row.Item("kd_ukuran") = lckUkuran.EditValue
                        row.Item("kd_kain") = lckKain.EditValue
                        row.Item("Nama_Barang") = txtNamaBarang.EditValue
                        row.Item("lokasi") = lckGudang.EditValue
                        row.Item("stok_min") = txtStokMin.EditValue
                        row.Item("stok_max_av") = txtStokMax.EditValue
                        row.Item("Keterangan") = txtKet.Text
                        row.Item("rek_penjualan1") = lckRekJual1.EditValue
                        row.Item("rek_persediaan") = lckRek.EditValue
                        row.Item("Rec_Stat") = lckStatus.EditValue
                        row.Item("Last_Update_Date") = getTanggal()
                        row.Item("Last_Updated_By") = username
                    End If
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data atau nama barang belum diisi.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                Exit Sub
            End If
        End If

        Try
            bldBarangJadi = New SqlCommandBuilder(daBarangJadi)
            daBarangJadi.UpdateCommand = bldBarangJadi.GetUpdateCommand()
            daBarangJadi.InsertCommand = bldBarangJadi.GetInsertCommand()
            daBarangJadi.DeleteCommand = bldBarangJadi.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daBarangJadi.UpdateCommand.Transaction = BTRANS
            daBarangJadi.InsertCommand.Transaction = BTRANS
            daBarangJadi.DeleteCommand.Transaction = BTRANS

            daBarangJadi.Update(dsBarangJadi.Tables("Barang"))

            dsBarangJadi.Tables("Barang").AcceptChanges()

            BTRANS.Commit()

            showMessages("Berhasil disimpan..")
            state = "EDIT"
            loadData(hasil)
            loadGrid()
        Catch ex As Exception
            BTRANS.Rollback()
            dsBarangJadi.Tables("Barang").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
        End Try
    End Sub

    Private Sub txtStokMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStokMax.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtStokMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStokMin.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub

    Private Sub gvBarangJadi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvBarangJadi.DoubleClick
        state = "EDIT"
        loadData(gvBarangJadi.GetFocusedRowCellValue("Kode_Barang").ToString)
        tacBarangJadi.SelectedTabPage = tabForm
        errData.ClearErrors()
        errValid = 0
    End Sub

    Private Sub tacBarangJadi_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tacBarangJadi.SelectedPageChanged
        If e.Page.Name = "tabForm" Then
            btnSave = True
            btnCancel = True
            setStatus()
        Else
            btnSave = False
            btnCancel = False
            setStatus()
        End If
    End Sub
End Class