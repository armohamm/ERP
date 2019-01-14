Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmMonGdgIn
    Dim ds, ds_cari2, ds_cari1, ds_cari4, dsLookUp, ds_gdg1, ds_gdg2 As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2, DALOOKUP4, DA_gdg1, DA_gdg2 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
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
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " gdi.tgl_trans > convert(date,'" & tglDari.EditValue & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdi.tgl_trans < convert(date,'" & tglsampai.EditValue & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdi.tgl_trans between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            sqltgl = sqltgl & "and gdi.blthn='" & lookupBulanAwal.EditValue & "'"
        Else
            'jika tgl dari kosong,tgl akhir kosong maka
            sqltgl = sqltgl & "gdi.blthn='" & lookupBulanAwal.EditValue & "'"
        End If
        If Not ds.Tables("_mgdi") Is Nothing Then ds.Tables("_mgdi").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT gdid.no_qc,gdi.no_trans,gdi.tgl_trans,gdid.kd_stok,gdid.qty_in,brg.Nama_Barang,brg.kd_jns_persd,gdid.gudang_asal,gdid.gudang_tujuan,0 as nomer,brg.kd_jns_persd, gdid.kd_satuan, isnull(gdid.Last_Updated_By,gdid.Last_Created_By) as userx from INV.dbo.INV_GUDANG_IN as gdi inner join INV.dbo.INV_GUDANG_IN_D as gdid on gdi.no_trans=gdid.no_trans LEFT join sif.dbo.SIF_Barang as brg on gdid.kd_stok=brg.Kode_Barang where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_mgdi")
        GcMonBM.DataSource = ds.Tables("_mgdi")
    End Sub

    Public Sub cetak_click()
        'GcMonBM.Refresh()
        'PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub frmMonGdgIn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMonBM.DataSource = ds.Tables("_mgdi")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LookupGudang.DataSource = ds_cari1.Tables("_lookup")
        LookupGudang.ValueMember = "Kode_Gudang"
        LookupGudang.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kd_Jns_Persd"
        LookupBarang.DisplayMember = "Nama_Persediaan"

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

        'DALOOKUP4 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_GUDANG_IN_D", sqlconn))
        'DALOOKUP4.Fill(ds_cari4, "_lookblth")
        'LookUBlthn.Properties.DataSource = ds_cari4.Tables("_lookblth")
        Loadblthn()
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_mgdi").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()
        isinomer()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub


    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub
End Class