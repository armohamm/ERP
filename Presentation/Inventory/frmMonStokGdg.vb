Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmMonStokGdg

    Dim ds, dsLookUp, ds_cari2, ds_cari, ds_cari1, ds_cari3, ds_cari4 As New DataSet
    Dim da, da_blthn, DALOOKUP1, DALOOKUP, DALOOKUP2, DALOOKUP3, DALOOKUP4 As SqlDataAdapter
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

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        da_blthn = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        da_blthn.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "1=0"
        End If

        'Dim sqltgl As String = ""

        If LuGdg.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf LuGdg.EditValue <> vbNullString And lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "lokasi='" & LuGdg.EditValue & "'"
        ElseIf LuGdg.EditValue = vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            sqltgl = " bultah='" & lookupBulanAwal.EditValue & "'"
        Else
            sqltgl = "lokasi='" & LuGdg.EditValue & "' and bultah='" & lookupBulanAwal.EditValue & "' "
        End If


        If Not ds.Tables("_MonGdg") Is Nothing Then ds.Tables("_MonGdg").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from AMERICAN_REPORT.dbo.vy_saldocard where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonGdg")
    End Sub

    Private Sub frmMonStokGdg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMonSGdg.DataSource = ds.Tables("_MonGdg")
        Loadblthn()


        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LuGdg.Properties.DataSource = ds_cari1.Tables("_lookup")
        LuGdg.Properties.ValueMember = "Kode_Gudang"
        LuGdg.Properties.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookupG")
        LookupGudang.DataSource = ds_cari2.Tables("_lookupG")
        LookupGudang.ValueMember = "Kode_Gudang"
        LookupGudang.DisplayMember = "Nama_Gudang"

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_lookup2")
        RepLookupPersd.DataSource = ds_cari3.Tables("_lookup2")
        RepLookupPersd.ValueMember = "Kd_Jns_Persd"
        RepLookupPersd.DisplayMember = "Nama_Persediaan"

        DALOOKUP4 = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP4.Fill(ds_cari4, "_dept")
        repDept.DataSource = ds_cari4.Tables("_dept")
        repDept.ValueMember = "Kd_Departemen"
        repDept.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupBarang.DataSource = ds_cari.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"


        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(bultah) from INV.dbo.INV_STOK_GUDANG", sqlconn))
        'D'ALOOKUP2.Fill(ds_cari2, "_lookup1")
        'lookupBulanAwal.Properties.DataSource = ds_cari2.Tables("_lookup1")
    End Sub

    Private Sub isitable()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonGdg").Rows
            row.Item("nomer") = i : i += 1
        Next

        'Dim i As Int16 = 1
        'Dim sqldr As SqlDataReader = New SqlCommand(" SELECT * from INV.dbo.INV_STOK_GUDANG where bultah='" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
        'While sqldr.Read
        '    Dim row As DataRow = ds.Tables("_MonGdg").NewRow
        '    row.Item("nomer") = i : i += 1
        '    'row.Item("kd_stok") = sqldr.Item("kd_stok")
        '    'row.Item("akhir_qty") = sqldr.Item("akhir_qty")
        '    'row.Item("kode_gudang") = sqldr.Item("kode_gudang")
        '    ds.Tables("_MonGdg").Rows.Add(row)
        'End While
        'sqldr.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        pnlLoad.Visible = True
        pnlLoad.Refresh()
        ds.Clear()
        ReloadTable()
        isitable()
        pnlLoad.Visible = False
        'ReloadTable()


    End Sub

    Public Sub cetak_click()
        GcMonSGdg.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cetak_click()
    End Sub

    
End Class