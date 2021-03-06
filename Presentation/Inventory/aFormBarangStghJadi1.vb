﻿Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormBarangStghJadi1
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsBarangJadi As New DataSet
    Dim daLookUp, daBarangJadi, daBarangJadiSave As SqlDataAdapter
    Dim state As String
    Dim bldBarangJadi As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim err As String
    Dim row As DataRow
    Dim hasil, temp As String
    Dim loaded As Boolean
    Dim BTRANS As SqlTransaction
    Dim JmlBarang As Int16 = 0
    Dim OldName As String
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
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
        If Not dsBarangJadi.Tables("RekHPP") Is Nothing Then dsBarangJadi.Tables("RekHPP").Clear()
        If Not dsBarangJadi.Tables("RekReturInt") Is Nothing Then dsBarangJadi.Tables("RekReturInt").Clear()
        If Not dsBarangJadi.Tables("RekReturExt") Is Nothing Then dsBarangJadi.Tables("RekReturExt").Clear()
        If Not dsBarangJadi.Tables("RekPenjInt") Is Nothing Then dsBarangJadi.Tables("RekPenjInt").Clear()
        If Not dsBarangJadi.Tables("RekPenjExt") Is Nothing Then dsBarangJadi.Tables("RekPenjExt").Clear()
        If Not dsBarangJadi.Tables("RekBonusInt") Is Nothing Then dsBarangJadi.Tables("RekBonusInt").Clear()
        If Not dsBarangJadi.Tables("RekBonusExt") Is Nothing Then dsBarangJadi.Tables("RekBonusExt").Clear()
        If Not dsBarangJadi.Tables("RekeniPersediaan") Is Nothing Then dsBarangJadi.Tables("RekeningPersediaan").Clear()
        If Not dsBarangJadi.Tables("Status") Is Nothing Then dsBarangJadi.Tables("Status").Clear()
        If Not dsBarangJadi.Tables("TipeStok") Is Nothing Then dsBarangJadi.Tables("TipeStok").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Satuan, Nama_Satuan from sif.dbo.SIF_Satuan where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Satuan")
        lckSatuan.Properties.DataSource = dsBarangJadi.Tables("Satuan")
        lckSatuan.Properties.ValueMember = "Kode_Satuan"
        lckSatuan.Properties.DisplayMember = "Nama_Satuan"
        lookupsatuan.DataSource = dsBarangJadi.Tables("Satuan")
        lookupsatuan.ValueMember = "Kode_Satuan"
        lookupsatuan.DisplayMember = "Nama_Satuan"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen WHERE Kd_Departemen between 1 and 9 and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Departemen")
        lckDivisi.Properties.DataSource = dsBarangJadi.Tables("Departemen")
        lckDivisi.Properties.ValueMember = "Kd_Departemen"
        lckDivisi.Properties.DisplayMember = "Nama_Departemen"
        lookupdepartemen.DataSource = dsBarangJadi.Tables("Departemen")
        lookupdepartemen.ValueMember = "Kd_Departemen"
        lookupdepartemen.DisplayMember = "Nama_Departemen"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg,Nama_Jenis from sif.dbo.SIF_Jenis_Barang where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "JenisBarang")
        lckJenis.Properties.DataSource = dsBarangJadi.Tables("JenisBarang")
        lckJenis.Properties.ValueMember = "Kd_Jns_Brg"
        lckJenis.Properties.DisplayMember = "Nama_Jenis"
        lookupjenisbarang.DataSource = dsBarangJadi.Tables("JenisBarang")
        lookupjenisbarang.ValueMember = "Kd_Jns_Brg"
        lookupjenisbarang.DisplayMember = "Nama_Jenis"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk,Nama_Merk from sif.dbo.SIF_Merk where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Merk")
        lckMerk.Properties.DataSource = dsBarangJadi.Tables("Merk")
        lckMerk.Properties.ValueMember = "Kode_Merk"
        lckMerk.Properties.DisplayMember = "Nama_Merk"
        lookupmerk.DataSource = dsBarangJadi.Tables("Merk")
        lookupmerk.ValueMember = "Kode_Merk"
        lookupmerk.DisplayMember = "Nama_Merk"

        lckTipe.Enabled = False
        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "TipeBarang")
        lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
        lckTipe.Properties.ValueMember = "Kode_Tipe"
        lckTipe.Properties.DisplayMember = "Nama_Tipe"
        lookuptipe.DataSource = dsBarangJadi.Tables("TipeBarang")
        lookuptipe.ValueMember = "Kode_Tipe"
        lookuptipe.DisplayMember = "Nama_Tipe"

        lckSubTipe.Enabled = False
        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "SubTipe")
        lckSubTipe.Properties.DataSource = dsBarangJadi.Tables("SubTipe")
        lckSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        lckSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
        lookupsubtipe.DataSource = dsBarangJadi.Tables("SubTipe")
        lookupsubtipe.ValueMember = "Kd_Sub_Tipe"
        lookupsubtipe.DisplayMember = "Nama_Sub_Tipe"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Ukuran")
        lckUkuran.Properties.DataSource = dsBarangJadi.Tables("Ukuran")
        lckUkuran.Properties.ValueMember = "Kode_Ukuran"
        lckUkuran.Properties.DisplayMember = "Nama_Ukuran"
        lookupukuran.DataSource = dsBarangJadi.Tables("Ukuran")
        lookupukuran.ValueMember = "Kode_Ukuran"
        lookupukuran.DisplayMember = "Nama_Ukuran"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain,Merk_Kain from sif.dbo.SIF_Kain where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Kain")
        lckKain.Properties.DataSource = dsBarangJadi.Tables("Kain")
        lckKain.Properties.ValueMember = "Kode_Kain"
        lckKain.Properties.DisplayMember = "Merk_Kain"
        lookupkain.DataSource = dsBarangJadi.Tables("Kain")
        lookupkain.ValueMember = "Kode_Kain"
        lookupkain.DisplayMember = "Merk_Kain"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang,Nama_Gudang from sif.dbo.SIF_Gudang where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Gudang")
        lckGudang.Properties.DataSource = dsBarangJadi.Tables("Gudang")
        lckGudang.Properties.ValueMember = "Kode_Gudang"
        lckGudang.Properties.DisplayMember = "Nama_Gudang"
        lookuplokasi.DataSource = dsBarangJadi.Tables("Gudang")
        lookuplokasi.ValueMember = "Kode_Gudang"
        lookuplokasi.DisplayMember = "Nama_Gudang"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '41%' and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekPenjExt")
        lckRekJualExt.Properties.DataSource = dsBarangJadi.Tables("RekPenjExt")
        lckRekJualExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualExt.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenjint.DataSource = dsBarangJadi.Tables("RekPenjExt")
        lookuppenjint.ValueMember = "Kd_Buku_Besar"
        lookuppenjint.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '43%' and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekPenjInt")
        lckRekJualInt.Properties.DataSource = dsBarangJadi.Tables("RekPenjInt")
        lckRekJualInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualInt.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenjext.DataSource = dsBarangJadi.Tables("RekPenjInt")
        lookuppenjext.ValueMember = "Kd_Buku_Besar"
        lookuppenjext.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '44%' and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekReturInt")
        lckRekReturInt.Properties.DataSource = dsBarangJadi.Tables("RekReturInt")
        lckRekReturInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturInt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '42%' and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekReturExt")
        lckRekReturExt.Properties.DataSource = dsBarangJadi.Tables("RekReturExt")
        lckRekReturExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturExt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '452%' and Rec_Stat = 'Y' OR Kd_Buku_Besar LIKE '453%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekBonusInt")
        lckRekBonusInt.Properties.DataSource = dsBarangJadi.Tables("RekBonusInt")
        lckRekBonusInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusInt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '451%' and Rec_Stat = 'Y' OR Kd_Buku_Besar LIKE '454%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekBonusExt")
        lckRekBonusExt.Properties.DataSource = dsBarangJadi.Tables("RekBonusExt")
        lckRekBonusExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusExt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '511%' and Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekHPP")
        lckRekHPP.Properties.DataSource = dsBarangJadi.Tables("RekHPP")
        lckRekHPP.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekHPP.Properties.DisplayMember = "Nm_Buku_Besar"

        'daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar where grup_header = 'D'", sqlconn))
        'daLookUp.Fill(dsBarangJadi, "RekeningPersediaan")
        'lookuppenj3.DataSource = dsBarangJadi.Tables("RekeningPersediaan")
        'lookuppenj3.ValueMember = "Kd_Buku_Besar"
        'lookuppenj3.DisplayMember = "Nm_Buku_Besar"

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

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from sif.dbo.SIF_Jns_Persediaan where Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Jenis_Persediaan")
        lookupjnspersediaan.DataSource = dsBarangJadi.Tables("Jenis_Persediaan")
        lookupjnspersediaan.ValueMember = "Kd_Jns_Persd"
        lookupjnspersediaan.DisplayMember = "Nama_Persediaan"
    End Sub

    Private Sub loadGrid()
        If Not dsBarangJadi.Tables("BarangJadi") Is Nothing Then dsBarangJadi.Tables("BarangJadi").Clear()
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE kd_jns_persd='2'", sqlconn))
        daBarangJadi.Fill(dsBarangJadi, "BarangJadi")
        gcBarangJadi.DataSource = dsBarangJadi.Tables("BarangJadi")
        gvBarangJadi.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsBarangJadi.Tables("Barang") Is Nothing Then dsBarangJadi.Tables("Barang").Clear()
        daBarangJadiSave = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & kode & "'", sqlconn))
        daBarangJadiSave.Fill(dsBarangJadi, "Barang")
        gvBarangJadi.BestFitColumns()

        If dsBarangJadi.Tables("Barang").Rows.Count > 0 Then
            lckSatuan.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kd_Satuan")
            lckDivisi.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kd_Depart")
            lckJenis.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_jenis")
            lckMerk.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_merk")
            lckTipe.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_tipe")
            lckSubTipe.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_sub_tipe")
            lckUkuran.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_ukuran")
            lckKain.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("kd_kain")
            lckGudang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("lokasi")
            lckStatus.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Rec_Stat")
            lckTipeStok.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("tipe_stok")
            txtNamaBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Nama_Barang")
            txtKodeBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kode_Barang")
            txtNamaJual.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("nm_jual")
            lckRekJualInt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_penjualan2")
            lckRekJualExt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_penjualan1")
            lckRekReturInt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_retur2")
            lckRekReturExt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_retur1")
            lckRekBonusInt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_bonus2")
            lckRekBonusExt.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_bonus1")
            lckRekHPP.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_hpp")
            txtStokMin.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_min")
            txtStokMax.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("stok_max_av")
            txtKet.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Keterangan")
            OldName = txtNamaBarang.Text
        Else
            OldName = ""
        End If
    End Sub

    Public Sub add_click()
        tacBarangJadi.TabPages(0).PageEnabled = True
        Me.Enabled = True
        state = "ADD"
        tacBarangJadi.SelectedTabPage = tabForm
        loadData("xxx")
        btnAdd = False
        btnEdit = False
        btnSave = True
        btnDelete = False
        btnCancel = True
        btnCetak = False
        setStatus()
        tacBarangJadi.TabPages(1).PageEnabled = False
        lckSatuan.EditValue = "NA"
        lckDivisi.EditValue = "4"
        lckJenis.EditValue = "000"
        lckTipe.EditValue = "000"
        lckMerk.EditValue = "00"
        lckSubTipe.EditValue = "000"
        lckUkuran.EditValue = "000"
        lckKain.EditValue = "000"
        lckGudang.EditValue = "G0002"
        lckSubTipe.Enabled = False
        lckTipe.Enabled = False
    End Sub

    Public Sub edit_click()
        tacBarangJadi.TabPages(1).PageEnabled = True
        Me.Enabled = True
        state = "EDIT"
        tacBarangJadi.TabPages(0).PageEnabled = False
        tacBarangJadi.SelectedTabPage = tabList
        btnAdd = False
        btnEdit = False
        btnSave = False
        btnDelete = False
        btnCancel = True
        btnCetak = True
        setStatus()
    End Sub

    Private Sub aFormBarangJadi1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
        lckGudang.EditValue = "G0002"
        loadGrid()
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
        If Not lckMerk.EditValue = "00" Then
            lckTipe.Enabled = True
            If Not dsBarangJadi.Tables("TipeBarang") Is Nothing Then dsBarangJadi.Tables("TipeBarang").Clear()
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe where Rec_Stat = 'Y' and (kode_merk='" & lckMerk.EditValue & "' or kode_merk='00')", sqlconn))
            daLookUp.Fill(dsBarangJadi, "TipeBarang")
            lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "Kode_Tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lckTipe.EditValue = "000"
        Else
            If Not dsBarangJadi.Tables("TipeBarang") Is Nothing Then dsBarangJadi.Tables("TipeBarang").Clear()
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe where Rec_Stat = 'Y' and kode_merk='" & lckMerk.EditValue & "'", sqlconn))
            daLookUp.Fill(dsBarangJadi, "TipeBarang")
            lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "Kode_Tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lckTipe.Enabled = True

        End If

        If lckMerk.EditValue = "01" Then
            lckRekJualExt.EditValue = "4100001"
            lckRekJualInt.EditValue = "4300001"
            lckRekReturExt.EditValue = "4200001"
            lckRekReturInt.EditValue = "4400001"
            lckRekBonusExt.EditValue = "4540001"
            lckRekBonusInt.EditValue = "4530001"
            lckRekHPP.EditValue = "5111001"
        End If

        If lckMerk.EditValue = "03" Then
            lckRekJualExt.EditValue = "4100002"
            lckRekJualInt.EditValue = "4300002"
            lckRekReturExt.EditValue = "4200002"
            lckRekReturInt.EditValue = "4400002"
            lckRekBonusExt.EditValue = "4540002"
            lckRekBonusInt.EditValue = "4530002"
            lckRekHPP.EditValue = "5111002"
        End If

        If lckMerk.EditValue = "05" Then
            lckRekJualExt.EditValue = "4100003"
            lckRekJualInt.EditValue = "4300003"
            lckRekReturExt.EditValue = "4200003"
            lckRekReturInt.EditValue = "4400003"
            lckRekBonusExt.EditValue = "4540003"
            lckRekBonusInt.EditValue = "4530003"
            lckRekHPP.EditValue = "5111003"
        End If

        If lckMerk.EditValue = "08" Then
            lckRekJualExt.EditValue = "4100004"
            lckRekJualInt.EditValue = "4300004"
            lckRekReturExt.EditValue = "4200004"
            lckRekReturInt.EditValue = "4400004"
            lckRekBonusExt.EditValue = "4540004"
            lckRekBonusInt.EditValue = "4530004"
            lckRekHPP.EditValue = "5111004"
        End If

        If lckMerk.EditValue = "07" Then
            lckRekJualExt.EditValue = "4100005"
            lckRekJualInt.EditValue = "4300005"
            lckRekReturExt.EditValue = "4200005"
            lckRekReturInt.EditValue = "4400005"
            lckRekBonusExt.EditValue = "4540005"
            lckRekBonusInt.EditValue = "4530005"
            lckRekHPP.EditValue = "5111005"
        End If

        If lckMerk.EditValue = "06" Then
            lckRekJualExt.EditValue = "4100006"
            lckRekJualInt.EditValue = "4300006"
            lckRekReturExt.EditValue = "4200006"
            lckRekReturInt.EditValue = "4400006"
            lckRekBonusExt.EditValue = "4540006"
            lckRekBonusInt.EditValue = "4530006"
            lckRekHPP.EditValue = "5111006"
        End If

        If lckMerk.EditValue = "11" Then
            lckRekJualExt.EditValue = "4100010"
            lckRekJualInt.EditValue = "4300010"
            lckRekReturExt.EditValue = "4200010"
            lckRekReturInt.EditValue = "4400010"
            lckRekBonusExt.EditValue = "4540009"
            lckRekBonusInt.EditValue = "4530009"
            lckRekHPP.EditValue = "5111010"
        End If
    End Sub

    Private Sub lckTipe_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckTipe.EditValueChanged
        If lckTipe.EditValue = "000" Then
            namaBarang()
            lckSubTipe.Enabled = True
            If Not dsBarangJadi.Tables("SubTipe") Is Nothing Then dsBarangJadi.Tables("SubTipe").Clear()
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe where Rec_Stat = 'Y' and (kd_tipe='" & lckTipe.EditValue & "' or kd_tipe='000')", sqlconn))
            daLookUp.Fill(dsBarangJadi, "SubTipe")
            lckSubTipe.Properties.DataSource = dsBarangJadi.Tables("SubTipe")
            lckSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
            lckSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
            lckSubTipe.ItemIndex = 0
        Else
            If Not dsBarangJadi.Tables("TipeBarang") Is Nothing Then dsBarangJadi.Tables("TipeBarang").Clear()
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe where Rec_Stat = 'Y' and kode_merk='" & lckMerk.EditValue & "'", sqlconn))
            daLookUp.Fill(dsBarangJadi, "TipeBarang")
            lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "Kode_Tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lckTipe.Enabled = True
        End If
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
        If txtNamaBarang.Text = "" Then
            errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            isValid = False
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckSatuan.EditValue = vbNullString Then
            errData.SetError(lckSatuan, "Satuan harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckDivisi.EditValue = vbNullString Then
            errData.SetError(lckDivisi, "Divisi harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckJenis.EditValue = vbNullString Then
            errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckMerk.EditValue = vbNullString Then
            errData.SetError(lckMerk, "Merk harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckTipe.EditValue = vbNullString Then
            errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckSubTipe.EditValue = vbNullString Then
            errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckUkuran.EditValue = vbNullString Then
            errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckKain.EditValue = vbNullString Then
                errData.SetError(lckKain, "Kain harus dipilih!")
            Else
                errData.SetError(lckKain, "")
            End If
        ElseIf lckKain.EditValue = vbNullString Then
            errData.SetError(lckKain, "Kain harus dipilih!")
            isValid = False
            If txtNamaBarang.Text = "" Then
                errData.SetError(txtNamaBarang, "Nama barang belum diisi!")
            Else
                errData.SetError(txtNamaBarang, "")
            End If
            If lckSatuan.EditValue = vbNullString Then
                errData.SetError(lckSatuan, "Satuan harus dipilih!")
            Else
                errData.SetError(lckSatuan, "")
            End If
            If lckDivisi.EditValue = vbNullString Then
                errData.SetError(lckDivisi, "Divisi harus dipilih!")
            Else
                errData.SetError(lckDivisi, "")
            End If
            If lckJenis.EditValue = vbNullString Then
                errData.SetError(lckJenis, "Jenis barang harus dipilih!")
            Else
                errData.SetError(lckJenis, "")
            End If
            If lckMerk.EditValue = vbNullString Then
                errData.SetError(lckMerk, "Merk harus dipilih!")
            Else
                errData.SetError(lckMerk, "")
            End If
            If lckTipe.EditValue = vbNullString Then
                errData.SetError(lckTipe, "Tipe barang harus dipilih!")
            Else
                errData.SetError(lckTipe, "")
            End If
            If lckSubTipe.EditValue = vbNullString Then
                errData.SetError(lckSubTipe, "Sub tipe barang harus dipilih!")
            Else
                errData.SetError(lckSubTipe, "")
            End If
            If lckUkuran.EditValue = vbNullString Then
                errData.SetError(lckUkuran, "Ukuran harus dipilih!")
            Else
                errData.SetError(lckUkuran, "")
            End If
        Else
            'cekRek()
            isValid = True
            errData.SetError(txtNamaBarang, "")
            errData.SetError(lckSatuan, "")
            errData.SetError(lckDivisi, "")
            errData.SetError(lckJenis, "")
            errData.SetError(lckMerk, "")
            errData.SetError(lckTipe, "")
            errData.SetError(lckSubTipe, "")
            errData.SetError(lckUkuran, "")
            errData.SetError(lckKain, "")
        End If
    End Sub

    Private Sub cekRek()
        err = ""
        If lckRekJualInt.EditValue = vbNullString Then
            err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekJualExt.EditValue = vbNullString Then
            err &= "Rekening penjualan external harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekReturInt.EditValue = vbNullString Then
            err &= "Rekening retur internal harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekReturExt.EditValue = vbNullString Then
            err &= "Rekening retur external harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekBonusInt.EditValue = vbNullString Then
            err &= "Rekening bonus internal harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekBonusExt.EditValue = vbNullString Then
            err &= "Rekening bonus external harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekHPP.EditValue = vbNullString Then
                err &= "Rekening HPP harus dipilih." & vbCrLf
            End If
        ElseIf lckRekHPP.EditValue = vbNullString Then
            err &= "Rekening HPP harus dipilih." & vbCrLf
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                err &= "Rekening penjualan internal harus dipilih." & vbCrLf
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                err &= "Rekening penjualan external harus dipilih." & vbCrLf
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                err &= "Rekening retur internal harus dipilih." & vbCrLf
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                err &= "Rekening retur external harus dipilih." & vbCrLf
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                err &= "Rekening bonus internal harus dipilih." & vbCrLf
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                err &= "Rekening bonus external harus dipilih." & vbCrLf
            End If
        Else
            isValid = True
        End If
    End Sub

    Public Sub cancel_click()
        lckSatuan.EditValue = "NA"
        lckDivisi.EditValue = "4"
        lckJenis.EditValue = "000"
        lckTipe.EditValue = "000"
        lckMerk.EditValue = "00"
        lckSubTipe.EditValue = "000"
        lckUkuran.EditValue = "000"
        lckKain.EditValue = "000"
        lckGudang.EditValue = "G0002"
        lckStatus.EditValue = vbNullString
        lckTipeStok.EditValue = vbNullString
        lckRekJualInt.EditValue = vbNullString
        lckRekJualExt.EditValue = vbNullString
        lckRekReturInt.EditValue = vbNullString
        lckRekReturExt.EditValue = vbNullString
        lckRekBonusInt.EditValue = vbNullString
        lckRekBonusExt.EditValue = vbNullString
        lckRekHPP.EditValue = vbNullString
        txtStokMin.EditValue = vbNullString
        txtStokMax.EditValue = vbNullString
        txtKet.EditValue = vbNullString
        txtNamaBarang.Text = ""
        txtKodeBarang.Text = ""
        txtNamaJual.Text = ""
        txtNamaBarang.Focus()
        tacBarangJadi.TabPages(0).PageEnabled = True
        tacBarangJadi.SelectedTabPage = tabForm
        Me.Enabled = False
        btnAdd = True
        btnEdit = True
        btnSave = False
        btnDelete = False
        btnCancel = False
        btnCetak = False
        setStatus()
        state = ""
    End Sub

    Private Sub kodebarang()
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '" & lckDivisi.EditValue & "' AND kd_jns_persd = '2' AND kd_jenis= '" & lckJenis.EditValue & "' AND kd_merk='" & lckMerk.EditValue & "' AND kd_tipe= '" & lckTipe.EditValue & "' AND kd_sub_tipe= '" & lckSubTipe.EditValue & "' AND kd_ukuran='" & lckUkuran.EditValue & "'AND kd_kain= '" & lckKain.EditValue & "' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Private Sub kodebarang2()

        Dim sqlDR As SqlDataReader = New SqlCommand("select count(Kode_Barang)+1 from SIF.dbo.SIF_Barang where Kode_Barang LIKE '" & lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & "%'", sqlconn).ExecuteReader
        sqlDR.Read()

        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "2" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        cek()
        If Not isDelete Then
            If isValid Then
                If MsgBox("Simpan master barang 1/2 jadi?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If JmlBarang > 0 And state = "ADD" Then
                        If MsgBox("Nama Barang Sudah Ada. Lanjutkan Simpan Barang ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.No Then Exit Sub
                    ElseIf JmlBarang > 1 And state = "EDIT" Then
                        If MsgBox("Nama Barang Sudah Ada. Lanjutkan Simpan Barang ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.No Then Exit Sub
                    ElseIf JmlBarang = 1 And state = "EDIT" And txtNamaBarang.Text <> OldName Then
                        If MsgBox("Nama Barang Sudah Ada. Lanjutkan Simpan Barang ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.No Then Exit Sub
                    End If
                    If state = "ADD" Then
                        'kodebarang()
                        kodebarang2()
                        txtKodeBarang.EditValue = hasil
                        row = dsBarangJadi.Tables("Barang").NewRow
                        row.Item("Kd_Cabang") = getKodeCabang()
                        row.Item("Kd_jns_persd") = "2"
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
                    row.Item("nm_jual") = txtNamaJual.EditValue
                    row.Item("lokasi") = lckGudang.EditValue
                    row.Item("stok_min") = txtStokMin.Text
                    row.Item("stok_max_av") = txtStokMax.Text
                    row.Item("Keterangan") = txtKet.EditValue
                    row.Item("rek_penjualan2") = lckRekJualInt.EditValue
                    row.Item("rek_penjualan1") = lckRekJualExt.EditValue
                    row.Item("rek_retur2") = lckRekReturInt.EditValue
                    row.Item("rek_retur1") = lckRekReturExt.EditValue
                    row.Item("rek_bonus2") = lckRekBonusInt.EditValue
                    row.Item("rek_bonus1") = lckRekBonusExt.EditValue
                    row.Item("rek_hpp") = lckRekHPP.EditValue
                    row.Item("rek_persediaan") = "1063001"
                    row.Item("Rec_Stat") = lckStatus.EditValue

                    If state = "ADD" Then
                        dsBarangJadi.Tables("Barang").Rows.Add(row)
                    End If
                Else
                    Exit Sub
                End If
                'Else
                '    MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                '    Exit Sub
                Try
                    bldBarangJadi = New SqlCommandBuilder(daBarangJadiSave)
                    daBarangJadiSave.UpdateCommand = bldBarangJadi.GetUpdateCommand()
                    daBarangJadiSave.InsertCommand = bldBarangJadi.GetInsertCommand()
                    daBarangJadiSave.DeleteCommand = bldBarangJadi.GetDeleteCommand()

                    BTRANS = sqlconn.BeginTransaction("1")
                    daBarangJadiSave.UpdateCommand.Transaction = BTRANS
                    daBarangJadiSave.InsertCommand.Transaction = BTRANS
                    daBarangJadiSave.DeleteCommand.Transaction = BTRANS

                    daBarangJadiSave.Update(dsBarangJadi.Tables("Barang"))

                    dsBarangJadi.Tables("Barang").AcceptChanges()

                    BTRANS.Commit()

                    showMessages("Berhasil disimpan..")
                    err = ""
                    loadLookUp()
                    loadGrid()
                    cancel_click()
                Catch ex As Exception
                    BTRANS.Rollback()
                    dsBarangJadi.Tables("Barang").RejectChanges()
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                End Try
            End If
        End If
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

    Private Sub gvBarangJadi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvBarangJadi.DoubleClick
        tacBarangJadi.TabPages(0).PageEnabled = True
        loadData(gvBarangJadi.GetFocusedRowCellValue("Kode_Barang").ToString)
        tacBarangJadi.SelectedTabPage = tabForm
        btnSave = True
        setStatus()
    End Sub

    'Private Sub tacBarangJadi_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tacBarangJadi.SelectedPageChanged
    '    If e.Page.Name = "tabForm" Then
    '        btnSave = True
    '        btnCancel = True
    '        setStatus()
    '    Else
    '        btnSave = False
    '        btnCancel = False
    '        setStatus()
    '    End If
    'End Sub

    Private Sub txtNamaBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNamaBarang.TextChanged
        txtNamaJual.Text = txtNamaBarang.Text
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPrintPreview()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "STOK BARANG 1/2 JADI"

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
    End Sub

    Public Sub cetak_click()
        If Not gvBarangJadi.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub
    Public Function CekBarang() As Int16
        Dim hasil As Int16 = 0
        With New SqlCommand(" select count(0) from sif.dbo.sif_barang where isnull(rec_stat,'') <> 'T' and nama_barang=@nama", sqlconn)
            .Parameters.Add("@nama", SqlDbType.Char).Value = txtNamaBarang.Text
            With .ExecuteReader
                .Read()
                hasil = .Item(0)
                .Close()
            End With
        End With
        CekBarang = hasil
    End Function
End Class