Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmMonGdgOut
    Dim ds, ds_cari, dsLookUp, ds_cari2, ds_gdg1, ds_gdg2 As New DataSet
    Dim da, DALOOKUP, DALOOKUP2, DA_gdg1, DA_gdg2 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub

    Public Sub cetak_click()
        'GcMonBK.Refresh()
        'PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " gdo.tgl_trans > convert(date,'" & tglDari.EditValue & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdo.tgl_trans < convert(date,'" & tglsampai.EditValue & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdo.tgl_trans between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and gdo.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else
            '    'jika tgl dari kosong,tgl akhir kosong maka
            '    sqltgl = sqltgl & " gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        If Not ds.Tables("_mgdo") Is Nothing Then ds.Tables("_mgdo").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT gdo.no_trans,gdo.tgl_trans,gdo.no_ref,gdod.no_ref2,gdod.tgl_ref2,gdod.kd_stok, " & _
                                                                   "brg.Nama_Barang,brg.spek_brg,gdod.kd_satuan,gdod.gudang_asal,gdod.gudang_tujuan, " & _
                                                                   "brg.kd_jns_persd,gdod.qty_out ,0 as nomer, gdod.kd_satuan, " & _
                                                                   "isnull(gdod.Last_Updated_By,gdod.Last_Created_By) as userx from KOPKAR.dbo.INV_GUDANG_OUT as gdo  " & _
                                                                   "inner join KOPKAR.dbo.INV_GUDANG_OUT_D as gdod on gdo.no_trans=gdod.no_trans " & _
                                                                   "INNER JOIN KOPKAR.dbo.SIF_Barang as brg on brg.Kode_Barang=gdod.kd_stok " & _
                                                                   "where " & sqltgl & "", sqlconn))
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT gdo.no_trans,gdo.tgl_trans,gdo.no_ref,gdod.no_ref2,gdod.tgl_ref2,gdod.kd_stok,brg.Nama_Barang,brg.spek_brg,gdod.kd_satuan,gdod.gudang_asal,gdod.gudang_tujuan,brg.kd_jns_persd,gdod.qty_out ,0 as nomer, gdod.kd_satuan, isnull(gdod.Last_Updated_By,gdod.Last_Created_By) as userx from INV.dbo.INV_GUDANG_OUT as gdo  inner join INV.dbo.INV_GUDANG_OUT_D as gdod on gdo.no_trans=gdod.no_trans INNER JOIN SIF.dbo.SIF_Barang as brg on brg.Kode_Barang=gdod.kd_stok where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_mgdo")
    End Sub


    Private Sub frmMonGdgOut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMonBK.DataSource = ds.Tables("_mgdo")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupBarang.DataSource = ds_cari.Tables("_lookup2")
        LookupBarang.ValueMember = "Kd_Jns_Persd"
        LookupBarang.DisplayMember = "Nama_Persediaan"

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_GUDANG_OUT_D", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_gdgAsal")
        RL_GdgAsal.DataSource = ds_gdg1.Tables("_gdgAsal")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_gdg2.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"

        'Loadblthn()
    End Sub
    'Private Sub Loadblthn()
    '    If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
    '    DALOOKUP.Fill(dsLookUp, "LookPeriode")
    '    lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
    '    lookupBulanAwal.Properties.DisplayMember = "nama"
    '    lookupBulanAwal.Properties.ValueMember = "thnbln"

    'End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_mgdo").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub
    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        ReloadTable()
        isinomer()
        'ReloadTable()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub
End Class