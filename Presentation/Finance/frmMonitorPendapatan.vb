'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmMonitorPendapatan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim saldoawal As String
    Dim saldohari As String
    Dim saldoakhir1 As String
    Dim saldoakhir2 As String

    Dim dsPusBiaya, dsPost, dsRekBiaya, dsGrid, dsValuta As New DataSet
    Dim daDetil, daPost, daPusBiaya, daJurnalD, daRekBiaya, daGrid, daValuta As SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub frmMonitorPendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadList()
        Me.Enabled = True
        GVMonPendapatan.BestFitColumns()

        Valuta.EditValue = "IDR"
        ToolTip1.SetToolTip(Valuta, "Rekening Biaya wajib diisi")
        ToolTip1.SetToolTip(tglDari, "Tanggal Dari wajib diisi")
        ToolTip1.SetToolTip(tglsampai, "Tanggal Sampai wajib diisi")
    End Sub

    Sub LoadAllData()

        'select
        '(select nm_buku_besar 
        'FROM SIF.dbo.SIF_buku_besar 
        'where kd_buku_besar = d.grup_level2 )as level2,

        '(select nama_customer
        'from SIF.dbo.SIF_Customer 
        'where kd_customer =  a.kd_kartu) as nm_customer,

        'd.nm_buku_besar, A.no_jur,A.tgl_trans,A.no_ref1 ,A.no_ref2 ,A.no_ref3,a.Nama,b.kd_buku_besar,b.kd_obyek,
        'c.nama_barang,c.nama_merk,c.nama_tipe,b.saldo_rp_kredit as jumlah
        'from fin.dbo.FIN_JURNAL A,fin.dbo.FIN_JURNAL_D B,fin.dbo.v_barang_coy C ,  SIF.dbo.SIF_buku_besar D , SIF.dbo.SIF_Valuta E

        'where a.no_jur=b.no_jur
        'and b.kd_obyek =c.Kode_Barang 
        'and b.kd_buku_besar = d.kd_buku_besar
        'and a.tipe_trans like 'JPJ-KPT%'
        'and b.kd_buku_besar like '4-%'


        daGrid = New SqlDataAdapter(New SqlCommand("select (select nm_buku_besar FROM SIF.dbo.SIF_buku_besar where kd_buku_besar = d.grup_level2 )as level2, (select nama_customer from SIF.dbo.SIF_Customer where kd_customer =  a.kd_kartu) as nm_customer, d.nm_buku_besar, A.no_jur,A.tgl_trans,A.no_ref1 ,A.no_ref2 ,A.no_ref3,a.Nama,b.kd_buku_besar,b.kd_obyek,c.nama_barang,c.nama_merk,c.nama_tipe,b.saldo_rp_kredit as jumlah from fin.dbo.FIN_JURNAL A,fin.dbo.FIN_JURNAL_D B,fin.dbo.v_barang_coy C ,  SIF.dbo.SIF_buku_besar D, SIF.dbo.SIF_Valuta E where(a.no_jur = b.no_jur) and b.kd_obyek =c.Kode_Barang and b.kd_buku_besar = d.kd_buku_besar and a.tipe_trans like 'JPJ-KPT%' and b.kd_buku_besar like '4%'", sqlconn))
        daGrid.Fill(dsGrid, "Pendapatan")
        GCMonPendapatan.DataSource = dsGrid.Tables("Pendapatan")
        GVMonPendapatan.BestFitColumns()
    End Sub

    Sub LoadPendapatan()
        If Not dsGrid.Tables("Pendapatan") Is Nothing Then dsGrid.Tables("Pendapatan").Clear()

        dsGrid.Clear()
        daGrid = New SqlDataAdapter(New SqlCommand("select (select nm_buku_besar FROM SIF.dbo.SIF_buku_besar where kd_buku_besar = d.grup_level2 )as level2, (select nama_customer from SIF.dbo.SIF_Customer where kd_customer =  a.kd_kartu) as nm_customer, d.nm_buku_besar, A.no_jur,A.tgl_trans,A.no_ref1 ,A.no_ref2 ,A.no_ref3,a.Nama,b.kd_buku_besar,b.kd_obyek,c.nama_barang,c.nama_merk,c.nama_tipe,b.saldo_rp_kredit as jumlah from fin.dbo.FIN_JURNAL A,fin.dbo.FIN_JURNAL_D B,fin.dbo.v_barang_coy C ,  SIF.dbo.SIF_buku_besar D, SIF.dbo.SIF_Valuta E where(a.no_jur = b.no_jur) and b.kd_obyek =c.Kode_Barang and b.kd_buku_besar = d.kd_buku_besar and a.tipe_trans like 'JPJ-KPT%' and b.kd_buku_besar like '4%'  " & _
        "  and a.tgl_posting between convert (date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103) and e.Kode_Valuta = '" & Valuta.EditValue & "'", sqlconn))
        daGrid.Fill(dsGrid, "Pendapatan")
        GCMonPendapatan.DataSource = dsGrid.Tables("Pendapatan")
        GVMonPendapatan.BestFitColumns()

    End Sub

    Private Sub loadList()

        daValuta = New SqlDataAdapter(New SqlCommand("select kode_valuta, nama_valuta from SIF.dbo.SIF_valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        Valuta.Properties.DataSource = dsValuta.Tables("Valuta")
        Valuta.Properties.DisplayMember = "nama_valuta"
        Valuta.Properties.ValueMember = "kode_valuta"

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        ErrorProvider1.Clear()

        If Valuta.EditValue = vbNullString Or Valuta.EditValue = vbNullString Then
            ErrorProvider1.SetError(Valuta, "Valuta Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglDari.EditValue = vbNullString Then
            ErrorProvider1.SetError(tglDari, "Tanggal dari Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.EditValue = vbNullString Then
            ErrorProvider1.SetError(tglsampai, "Tanggal Sampai Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.EditValue < tglDari.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal sampai tidak boleh kurang dari tanggal dari")
            isvalid = False
        ElseIf tglDari.EditValue > tglsampai.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal dari tidak boleh lebih dari tanggal sampai")
            isvalid = False
        Else
            LoadPendapatan()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Sub bersih()
        dsGrid.Clear()
        GCMonPendapatan.DataSource = dsGrid.Tables("Pendapatan")
        GVMonPendapatan.BestFitColumns()

        Valuta.EditValue = "IDR"
        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadAllData()
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'ShowGridPreview(GVMonPendapatan.GridControl)
        ShowGridPreview(GCMonPendapatan)
    End Sub

    Public Sub cetak_click()
        ShowGridPreview(GCMonPendapatan)
    End Sub
End Class