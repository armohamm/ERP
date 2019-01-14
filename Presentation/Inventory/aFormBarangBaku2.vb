Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class aFormBarangBaku2
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsBarangJadi As New DataSet
    Dim daLookUp, daBarangJadi, daBarangJadiSave, daCari As SqlDataAdapter
    Dim state As String
    Dim bldBarangJadi As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim err, kodeCari As String
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

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Satuan, Nama_Satuan from sif.dbo.SIF_Satuan", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Satuan")
        lckSatuan.Properties.DataSource = dsBarangJadi.Tables("Satuan")
        lckSatuan.Properties.ValueMember = "Kode_Satuan"
        lckSatuan.Properties.DisplayMember = "Nama_Satuan"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen WHERE Kd_Departemen between 1 and 9", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Departemen")
        lckDivisi.Properties.DataSource = dsBarangJadi.Tables("Departemen")
        lckDivisi.Properties.ValueMember = "Kd_Departemen"
        lckDivisi.Properties.DisplayMember = "Nama_Departemen"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg,Nama_Jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        daLookUp.Fill(dsBarangJadi, "JenisBarang")
        lckJenis.Properties.DataSource = dsBarangJadi.Tables("JenisBarang")
        lckJenis.Properties.ValueMember = "Kd_Jns_Brg"
        lckJenis.Properties.DisplayMember = "Nama_Jenis"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk,Nama_Merk from sif.dbo.SIF_Merk", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Merk")
        lckMerk.Properties.DataSource = dsBarangJadi.Tables("Merk")
        lckMerk.Properties.ValueMember = "Kode_Merk"
        lckMerk.Properties.DisplayMember = "Nama_Merk"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe", sqlconn))
        daLookUp.Fill(dsBarangJadi, "TipeBarang")
        lckTipe.Properties.DataSource = dsBarangJadi.Tables("TipeBarang")
        lckTipe.Properties.ValueMember = "Kode_Tipe"
        lckTipe.Properties.DisplayMember = "Nama_Tipe"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe", sqlconn))
        daLookUp.Fill(dsBarangJadi, "SubTipe")
        lckSubTipe.Properties.DataSource = dsBarangJadi.Tables("SubTipe")
        lckSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        lckSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Ukuran")
        lckUkuran.Properties.DataSource = dsBarangJadi.Tables("Ukuran")
        lckUkuran.Properties.ValueMember = "Kode_Ukuran"
        lckUkuran.Properties.DisplayMember = "Nama_Ukuran"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain,Merk_Kain from sif.dbo.SIF_Kain", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Kain")
        lckKain.Properties.DataSource = dsBarangJadi.Tables("Kain")
        lckKain.Properties.ValueMember = "Kode_Kain"
        lckKain.Properties.DisplayMember = "Merk_Kain"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang,Nama_Gudang from sif.dbo.SIF_Gudang", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Gudang")
        lckGudang.Properties.DataSource = dsBarangJadi.Tables("Gudang")
        lckGudang.Properties.ValueMember = "Kode_Gudang"
        lckGudang.Properties.DisplayMember = "Nama_Gudang"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '41%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekPenjExt")
        lckRekJualExt.Properties.DataSource = dsBarangJadi.Tables("RekPenjExt")
        lckRekJualExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualExt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '43%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekPenjInt")
        lckRekJualInt.Properties.DataSource = dsBarangJadi.Tables("RekPenjInt")
        lckRekJualInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualInt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '44%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekReturInt")
        lckRekReturInt.Properties.DataSource = dsBarangJadi.Tables("RekReturInt")
        lckRekReturInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturInt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '42%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekReturExt")
        lckRekReturExt.Properties.DataSource = dsBarangJadi.Tables("RekReturExt")
        lckRekReturExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturExt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '452%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekBonusInt")
        lckRekBonusInt.Properties.DataSource = dsBarangJadi.Tables("RekBonusInt")
        lckRekBonusInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusInt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '451%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "RekBonusExt")
        lckRekBonusExt.Properties.DataSource = dsBarangJadi.Tables("RekBonusExt")
        lckRekBonusExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusExt.Properties.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '511%'", sqlconn))
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

        'daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from sif.dbo.SIF_Jns_Persediaan", sqlconn))
        'daLookUp.Fill(dsBarangJadi, "Jenis_Persediaan")
        'lookupjnspersediaan.DataSource = dsBarangJadi.Tables("Jenis_Persediaan")
        'lookupjnspersediaan.ValueMember = "Kd_Jns_Persd"
        'lookupjnspersediaan.DisplayMember = "Nama_Persediaan"
    End Sub

    Public Sub add_click()
        Me.Enabled = True
        state = "ADD"
        btnAdd = False
        btnEdit = False
        btnSave = True
        btnDelete = False
        btnCancel = True
        setStatus()
        loadData("xxx")
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsBarangJadi.Tables("Barang") Is Nothing Then dsBarangJadi.Tables("Barang").Clear()
        daBarangJadiSave = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & kode & "'", sqlconn))
        daBarangJadiSave.Fill(dsBarangJadi, "Barang")
        'gvBarangJadi.BestFitColumns()

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
        End If
    End Sub

    Private Sub aFormBarangJadi1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'Me.Enabled = True
        loadLookUp()
        lckGudang.EditValue = "G0003"
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
        If lckRekJualInt.EditValue = vbNullString Then
            errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            isValid = False
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekJualExt.EditValue = vbNullString Then
            errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekReturInt.EditValue = vbNullString Then
            errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekReturExt.EditValue = vbNullString Then
            errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekBonusInt.EditValue = vbNullString Then
            errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekBonusExt.EditValue = vbNullString Then
            errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekHPP.EditValue = vbNullString Then
                errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            Else
                errData.SetError(lckRekHPP, "")
            End If
        ElseIf lckRekHPP.EditValue = vbNullString Then
            errData.SetError(lckRekHPP, "Rekening HPP harus dipilih!")
            isValid = False
            If lckRekJualInt.EditValue = vbNullString Then
                errData.SetError(lckRekJualInt, "Rekening penjualan internal harus dipilih!")
            Else
                errData.SetError(lckRekJualInt, "")
            End If
            If lckRekJualExt.EditValue = vbNullString Then
                errData.SetError(lckRekJualExt, "Rekening penjualan external harus dipilih!")
            Else
                errData.SetError(lckRekJualExt, "")
            End If
            If lckRekReturInt.EditValue = vbNullString Then
                errData.SetError(lckRekReturInt, "Rekening retur internal harus dipilih!")
            Else
                errData.SetError(lckRekReturInt, "")
            End If
            If lckRekReturExt.EditValue = vbNullString Then
                errData.SetError(lckRekReturExt, "Rekening retur external harus dipilih!")
            Else
                errData.SetError(lckRekReturExt, "")
            End If
            If lckRekBonusInt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusInt, "Rekening bonus internal harus dipilih!")
            Else
                errData.SetError(lckRekBonusInt, "")
            End If
            If lckRekBonusExt.EditValue = vbNullString Then
                errData.SetError(lckRekBonusExt, "Rekening bonus external harus dipilih!")
            Else
                errData.SetError(lckRekBonusExt, "")
            End If
        Else
            isValid = True
            errData.SetError(lckRekJualInt, "")
            errData.SetError(lckRekJualExt, "")
            errData.SetError(lckRekReturInt, "")
            errData.SetError(lckRekReturExt, "")
            errData.SetError(lckRekBonusInt, "")
            errData.SetError(lckRekBonusExt, "")
            errData.SetError(lckRekHPP, "")
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
        lckGudang.EditValue = "G0003"
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
        state = "ADD"
        Me.Enabled = False
        btnAdd = True
        btnEdit = True
        btnSave = False
        btnDelete = False
        btnCancel = False
        setStatus()
    End Sub

    Private Sub kodebarang()
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '" & lckDivisi.EditValue & "' AND kd_jns_persd = '1' AND kd_jenis= '" & lckJenis.EditValue & "' AND kd_merk='" & lckMerk.EditValue & "' AND kd_tipe= '" & lckTipe.EditValue & "' AND kd_sub_tipe= '" & lckSubTipe.EditValue & "' AND kd_ukuran='" & lckUkuran.EditValue & "'AND kd_kain= '" & lckKain.EditValue & "' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Private Sub kodebarang2()

        Dim sqlDR As SqlDataReader = New SqlCommand("select count(Kode_Barang)+1 from SIF.dbo.SIF_Barang where Kode_Barang LIKE '" & lckDivisi.EditValue & "3" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & "%'", sqlconn).ExecuteReader
        sqlDR.Read()

        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = lckDivisi.EditValue & "1" & lckJenis.EditValue & lckMerk.EditValue & lckTipe.EditValue & lckSubTipe.EditValue & lckUkuran.EditValue & lckKain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
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
        cek()
        If Not isDelete Then
            If isValid Then
                If MsgBox("Simpan master barang jadi?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If state = "ADD" Then
                        'kodebarang()
                        kodebarang2()
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
                'MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                'Exit Sub
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
                    'loadData(hasil)
                    cancel_click()
                Catch ex As Exception
                    BTRANS.Rollback()
                    dsBarangJadi.Tables("Barang").RejectChanges()
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                End Try
            End If
        End If
    End Sub

    Public Sub edit_click()
        If Not dsBarangJadi.Tables("LookBarang") Is Nothing Then dsBarangJadi.Tables("LookBarang").Clear()
        state = "EDIT"
        Me.Enabled = True
        btnAdd = False
        btnEdit = False
        btnSave = True
        btnDelete = False
        btnCancel = True
        setStatus()
        daCari = New SqlDataAdapter(New SqlCommand("SELECT a.Kode_Barang, a.Kd_Satuan, a.Nama_Barang, b.Nama_Departemen, c.Nama_Merk, d.Nama_Tipe, e.Nama_Sub_Tipe, f.Nama_Ukuran, g.Merk_Kain FROM SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Departemen b, SIF.dbo.SIF_Merk c, SIF.dbo.SIF_Tipe d, SIF.dbo.SIF_Sub_Tipe e, SIF.dbo.SIF_Ukuran f, SIF.dbo.SIF_Kain g WHERE a.Kd_Depart = b.Kd_Departemen AND a.kd_merk = c.Kode_Merk AND a.kd_tipe = d.Kode_Tipe AND a.kd_sub_tipe = e.Kd_Sub_Tipe AND a.kd_ukuran = f.Kode_Ukuran AND a.kd_kain = g.Kode_Kain AND Kd_jns_persd = '3'", sqlconn))
        daCari.Fill(dsBarangJadi, "LookBarang")
        frmCari.set_dso(dsBarangJadi.Tables("LookBarang"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kodeCari = frmCari.row("Kode_Barang").ToString
            loadData(kodeCari)
        Else
            cancel_click()
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

    Private Sub txtNamaBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNamaBarang.TextChanged
        txtNamaJual.Text = txtNamaBarang.Text
    End Sub
End Class