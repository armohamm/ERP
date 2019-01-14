Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks
Public Class FrmMonStokaseli

    Dim ds, ds_cari2, ds_cari, ds_cari1 As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
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
        btnCancel = True
        setStatus()
    End Sub

    Sub ReloadTable(ByVal kode As String)
        Dim sqltgl As String = ""
        'If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString And LookupBlthn.EditValue = vbNullString Then
        '    sqltgl = "1=0"
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
        '    '    sqltgl = " tgl_trans > '" & tglDari.EditValue & "'"
        '    'ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
        '    '    sqltgl = " tgl_trans < '" & tglsampai.EditValue & "'"
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
        '    '    sqltgl = " tgl_trans between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "' "
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And LookupBlthn.EditValue <> vbNullString Then
        '    '    sqltgl = sqltgl & "and blthn='" & LookupBlthn.Text & "'"
        'Else
        '    'jika tgl dari kosong,tgl akhir kosong maka
        '    sqltgl = sqltgl & " bultah='" & LookupBlthn.Text & "'"
        'End If
        sqltgl = sqltgl & " bultah='" & LookupBlthn.Text & "'"

        If Not ds.Tables("_MonSaldo") Is Nothing Then ds.Tables("_MonSaldo").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" SELECT *,0 as nomer from INV.dbo.v_monstok_aseli where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonSaldo")
    End Sub

    Private Sub frmMonStokGdg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable("xxx")
        GcMonSGdg.DataSource = ds.Tables("_MonSaldo")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LookupGudang.DataSource = ds_cari1.Tables("_lookup")
        LookupGudang.ValueMember = "Kode_Gudang"
        LookupGudang.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP2.Fill(ds_cari1, "_lookup")
        LookupGudang.DataSource = ds_cari1.Tables("_lookup")
        LookupGudang.ValueMember = "Kd_Jns_Persd"
        LookupGudang.DisplayMember = "Nama_Persediaan"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupBarang.DataSource = ds_cari.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"


        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(bultah) from INV.dbo.INV_STOK_SALDO", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup1")
        LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")
    End Sub

    Private Sub isitable()
        Dim i As Int16 = 1
        Dim sqldr As SqlDataReader = New SqlCommand(" SELECT * from INV.dbo.INV_STOK_GUDANG where bultah='" & LookupBlthn.EditValue & "'", sqlconn).ExecuteReader
        While sqldr.Read
            Dim row As DataRow = ds.Tables("_MonGdg").NewRow
            row.Item("nomer") = i : i += 1
            row.Item("kd_stok") = sqldr.Item("kd_stok")
            row.Item("akhir_qty") = sqldr.Item("akhir_qty")
            row.Item("kode_gudang") = sqldr.Item("kode_gudang")
            ds.Tables("_MonGdg").Rows.Add(row)
        End While
        sqldr.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        isitable()
    End Sub

    Public Sub cetak_click()
        GcMonSGdg.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub
End Class