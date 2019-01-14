Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class aFormBarangBaku
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
    Dim err As String
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

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen WHERE Kd_Departemen between 1 and 9", sqlconn))
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
        lckRetur.Properties.DataSource = dsBarangJadi.Tables("Rekening")
        lckRetur.Properties.ValueMember = "Kd_Buku_Besar"
        lckRetur.Properties.DisplayMember = "Nm_Buku_Besar"
        lckRekBiaya.Properties.DataSource = dsBarangJadi.Tables("Rekening")
        lckRekBiaya.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBiaya.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenj1.DataSource = dsBarangJadi.Tables("Rekening")
        lookuppenj1.ValueMember = "Kd_Buku_Besar"
        lookuppenj1.DisplayMember = "Nm_Buku_Besar"
        lookuppenj2.DataSource = dsBarangJadi.Tables("Rekening")
        lookuppenj2.ValueMember = "Kd_Buku_Besar"
        lookuppenj2.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar where grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekeningPersediaan")
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
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE kd_jns_persd='3'", sqlconn))
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
            lckRekJual1.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_penjualan1")
            lckRetur.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_retur1")
            lckRekBiaya.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_biaya")
            txtStokMin.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_min")
            txtStokMax.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_max_av")
            txtKet.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Keterangan")
            txtNamaBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Nama_Barang")
        End If
    End Sub

    Private Sub aFormBarangBaku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        lckGudang.EditValue = "G0003"
        loadData("xxx")
        loadGrid()
        state = "ADD"
        'txtNamaBarang.Focus()
    End Sub

    Private Sub namaBarang()
        If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
            txtNamaBarang.EditValue = lckJenis.Text.ToUpper
            If Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue &= " " & lckMerk.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
        ElseIf Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
            txtNamaBarang.EditValue = lckMerk.Text.ToUpper
            If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
                txtNamaBarang.EditValue = lckJenis.Text.ToUpper & " " & lckMerk.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper
            End If
            If Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
        ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
            txtNamaBarang.EditValue = lckTipe.Text.ToUpper
            If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
                txtNamaBarang.EditValue = lckJenis.Text.ToUpper & " " & lckTipe.Text.ToUpper
            ElseIf Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper
            End If
            If Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper
            End If
            If Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
        ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
            txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper
            If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
                txtNamaBarang.EditValue = lckJenis.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            ElseIf Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper
            End If
            If Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper
            End If
            If Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckSubTipe.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper
            End If
            If Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
            If Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
        ElseIf Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
            txtNamaBarang.EditValue = lckUkuran.Text.ToUpper
            If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
                txtNamaBarang.EditValue = lckJenis.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper
            End If
            If Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper
            End If
            If Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper
            End If
            If Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckUkuran.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper
            End If
            If Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
                txtNamaBarang.EditValue &= " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue &= ""
            End If
        ElseIf Not (lckKain.EditValue = vbNullString Or lckKain.EditValue = "000") Then
            txtNamaBarang.EditValue = lckKain.Text.ToUpper
            If Not (lckJenis.EditValue = vbNullString Or lckJenis.EditValue = "000") Then
                txtNamaBarang.EditValue = lckJenis.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper & " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckKain.Text.ToUpper
            End If
            If Not (lckMerk.EditValue = vbNullString Or lckMerk.EditValue = "00") Then
                txtNamaBarang.EditValue = lckMerk.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper & " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckKain.Text.ToUpper
            End If
            If Not (lckTipe.EditValue = vbNullString Or lckTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckKain.Text.ToUpper
            End If
            If Not (lckSubTipe.EditValue = vbNullString Or lckSubTipe.EditValue = "000") Then
                txtNamaBarang.EditValue = lckSubTipe.Text.ToUpper & " " & lckKain.Text.ToUpper
            ElseIf Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper & " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckKain.Text.ToUpper
            End If
            If Not (lckUkuran.EditValue = vbNullString Or lckUkuran.EditValue = "000") Then
                txtNamaBarang.EditValue = lckUkuran.Text.ToUpper & " " & lckKain.Text.ToUpper
            Else
                txtNamaBarang.EditValue = lckKain.Text.ToUpper
            End If
        End If
    End Sub

    Private Sub lckJenis_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckJenis.EditValueChanged
        namaBarang()
    End Sub

    Private Sub lckMerk_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckMerk.EditValueChanged
        namaBarang()
    End Sub

    Private Sub lckTipe_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckTipe.EditValueChanged
        namaBarang()
    End Sub

    Private Sub lckSubTipe_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckSubTipe.EditValueChanged
        namaBarang()
    End Sub

    Private Sub lckUkuran_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckUkuran.EditValueChanged
        namaBarang()
    End Sub

    Private Sub lckKain_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckKain.EditValueChanged
        namaBarang()
    End Sub

    Private Sub cek()
        err = ""
        If txtNamaBarang.Text = "" Then
            err &= "Nama Barang harus diisi." & vbCrLf
            isValid = False
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckSatuan.EditValue = vbNullString Then
            err &= "Satuan harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckDivisi.EditValue = vbNullString Then
            err &= "DIvisi harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckJenis.EditValue = vbNullString Then
            err &= "Jenis barang harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckMerk.EditValue = vbNullString Then
            err &= "Merk harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckTipe.EditValue = vbNullString Then
            err &= "Tipe barang harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckSubTipe.EditValue = vbNullString Then
            err &= "Sub tipe barang harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckUkuran.EditValue = vbNullString Then
            err &= "Ukuran harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckKain.EditValue = vbNullString Then
                err &= "Kain harus dipilih." & vbCrLf
            End If
        ElseIf lckKain.EditValue = vbNullString Then
            err &= "Kain harus dipilih." & vbCrLf
            isValid = False
            If txtNamaBarang.Text = "" Then
                err &= "Nama Barang harus diisi." & vbCrLf
            End If
            If lckSatuan.EditValue = vbNullString Then
                err &= "Satuan harus dipilih." & vbCrLf
            End If
            If lckDivisi.EditValue = vbNullString Then
                err &= "DIvisi harus dipilih." & vbCrLf
            End If
            If lckJenis.EditValue = vbNullString Then
                err &= "Jenis barang harus dipilih." & vbCrLf
            End If
            If lckMerk.EditValue = vbNullString Then
                err &= "Merk harus dipilih." & vbCrLf
            End If
            If lckTipe.EditValue = vbNullString Then
                err &= "Tipe barang harus dipilih." & vbCrLf
            End If
            If lckSubTipe.EditValue = vbNullString Then
                err &= "Sub tipe barang harus dipilih." & vbCrLf
            End If
            If lckUkuran.EditValue = vbNullString Then
                err &= "Ukuran harus dipilih." & vbCrLf
            End If
        End If
    End Sub

    Public Sub cancel_click()
        lckSatuan.EditValue = vbNullString
        lckDivisi.EditValue = vbNullString
        lckJenis.EditValue = vbNullString
        lckTipe.EditValue = vbNullString
        lckMerk.EditValue = vbNullString
        lckSubTipe.EditValue = vbNullString
        lckUkuran.EditValue = vbNullString
        lckKain.EditValue = vbNullString
        lckGudang.EditValue = "G0003"
        lckStatus.EditValue = vbNullString
        lckTipeStok.EditValue = vbNullString
        lckRekJual1.EditValue = vbNullString
        lckRetur.EditValue = vbNullString
        lckRekBiaya.EditValue = vbNullString
        txtStokMin.EditValue = vbNullString
        txtStokMax.EditValue = vbNullString
        txtKet.EditValue = vbNullString
        txtNamaBarang.Text = ""
        txtNamaBarang.Focus()
    End Sub

    Private Sub kodebarang()
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '" & lckDivisi.EditValue & "' AND kd_jns_persd = '3' AND kd_jenis= '" & lckJenis.EditValue & "' AND kd_merk='" & lckMerk.EditValue & "' AND kd_tipe= '" & lckTipe.EditValue & "' AND kd_sub_tipe= '" & lckSubTipe.EditValue & "' AND kd_ukuran='" & lckUkuran.EditValue & "'AND kd_kain= '" & lckKain.EditValue & "' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = lckDivisi.EditValue & "3" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "3" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "3" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "3" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isValid Then
                If MsgBox("Simpan master barang jadi?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If state = "ADD" Then
                        kodebarang()
                        txtKodeBarang.EditValue = hasil
                        row = dsBarangJadi.Tables("Barang").NewRow
                        row.Item("Kd_Cabang") = getKodeCabang()
                        row.Item("Kd_jns_persd") = "3"
                        row.Item("Kode_Barang") = txtKodeBarang.EditValue
                        row.Item("no_urut") = temp
                        row.Item("Last_Create_Date") = getTanggal()
                        row.Item("Last_Created_By") = username
                        row.Item("Program_Name") = Me.Name
                    ElseIf state = "EDIT" Then
                        row = dsBarangJadi.Tables("Barang").Rows(0)
                        row.Item("Last_Update_Date") = getTanggal()
                        row.Item("Last_Updated_By") = username
                    End If

                    row.Item("Kd_Satuan") = lckSatuan.EditValue
                    row.Item("tipe_stok") = lckTipeStok.EditValue
                    row.Item("kd_Depart") = lckDivisi.EditValue
                    row.Item("kd_jenis") = lckJenis.EditValue
                    row.Item("kd_merk") = lckMerk.EditValue
                    row.Item("kd_tipe") = lckTipe.EditValue
                    row.Item("kd_sub_tipe") = lckSubTipe.EditValue
                    row.Item("kd_ukuran") = lckUkuran.EditValue
                    row.Item("kd_kain") = lckKain.EditValue
                    row.Item("Nama_Barang") = txtNamaBarang.EditValue
                    row.Item("lokasi") = lckGudang.EditValue
                    row.Item("stok_min") = txtStokMin.Text
                    row.Item("stok_max_av") = txtStokMax.Text
                    row.Item("Keterangan") = txtKet.EditValue
                    row.Item("rek_penjualan1") = lckRekJual1.EditValue
                    row.Item("rek_retur1") = lckRetur.EditValue
                    row.Item("rek_biaya") = lckRekBiaya.EditValue
                    row.Item("rek_persediaan") = "1-631000"
                    row.Item("Rec_Stat") = lckStatus.EditValue

                    If state = "ADD" Then
                        dsBarangJadi.Tables("Barang").Rows.Add(row)
                    End If
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
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
            err = ""
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