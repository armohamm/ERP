Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonStokDetil
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsStok As New DataSet
    Dim daLookUp, daStokGudang, daStokSaldo As SqlDataAdapter
    Dim state, errX, stok As String
    Dim bldStokSaldo, bldStokGudang As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim row As DataRow
    Dim BTRANS As SqlTransaction
    Dim isOk As Integer = 0

    Private Sub aFormMonPR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        lookPeriode.EditValue = Format(getTanggal(), "yyyyMM")
        lookBarang.EditValue = "0000000000000000000000"
        lookPersd.EditValue = "1"
    End Sub

    Private Sub loadLookUp()
        If Not dsStok.Tables("Barang") Is Nothing Then dsStok.Tables("Barang").Clear()
        If Not dsStok.Tables("Ukuran") Is Nothing Then dsStok.Tables("Ukuran").Clear()
        If Not dsStok.Tables("Satuan") Is Nothing Then dsStok.Tables("Satuan").Clear()
        If Not dsStok.Tables("Periode") Is Nothing Then dsStok.Tables("Periode").Clear()
        If Not dsStok.Tables("Jenis") Is Nothing Then dsStok.Tables("Jenis").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang UNION SELECT '0000000000000000000000', '[Semua Barang]'", sqlconn))
        daLookUp.Fill(dsStok, "Barang")
        lookStok.DataSource = dsStok.Tables("Barang")
        lookStok.ValueMember = "Kode_Barang"
        lookStok.DisplayMember = "Nama_Barang"
        lookBarang.Properties.DataSource = dsStok.Tables("Barang")
        lookBarang.Properties.ValueMember = "Kode_Barang"
        lookBarang.Properties.DisplayMember = "Nama_Barang"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Ukuran, Nama_Ukuran FROM SIF.dbo.SIF_Ukuran", sqlconn))
        daLookUp.Fill(dsStok, "Ukuran")
        lookUkuran.DataSource = dsStok.Tables("Ukuran")
        lookUkuran.ValueMember = "Kode_Ukuran"
        lookUkuran.DisplayMember = "Nama_Ukuran"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Satuan, Nama_Satuan FROM SIF.dbo.SIF_Satuan", sqlconn))
        daLookUp.Fill(dsStok, "Satuan")
        lookSatuan.DataSource = dsStok.Tables("Satuan")
        lookSatuan.ValueMember = "Kode_Satuan"
        lookSatuan.DisplayMember = "Nama_Satuan"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS periode, nama_bulan + ' ' + thn_buku AS nama FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsStok, "Periode")
        lookPeriode.Properties.DataSource = dsStok.Tables("Periode")
        lookPeriode.Properties.DisplayMember = "nama"
        lookPeriode.Properties.ValueMember = "periode"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kd_Jns_Persd, Nama_Persediaan FROM SIF.dbo.SIF_Jns_Persediaan WHERE NOT (Kd_Jns_Persd = '4')", sqlconn))
        daLookUp.Fill(dsStok, "Jenis")
        lookJenis.DataSource = dsStok.Tables("Jenis")
        lookJenis.DisplayMember = "Nama_Persediaan"
        lookJenis.ValueMember = "Kd_Jns_Persd"
        lookPersd.Properties.DataSource = dsStok.Tables("Jenis")
        lookPersd.Properties.DisplayMember = "Nama_Persediaan"
        lookPersd.Properties.ValueMember = "Kd_Jns_Persd"
    End Sub

    Private Sub loadData(ByVal periode As String)
        If Not dsStok.Tables("StokSaldo") Is Nothing Then dsStok.Tables("StokSaldo").Clear()

        If lookBarang.EditValue = "0000000000000000000000" Then
            daStokSaldo = New SqlDataAdapter(New SqlCommand("SELECT a.*, b.kd_jns_persd jenis FROM INV.dbo.INV_STOK_SALDO_DETIL a, SIF.dbo.SIF_Barang b WHERE a.kd_stok=b.Kode_Barang AND a.bultah = '" & periode & "'", sqlconn))
        Else
            daStokSaldo = New SqlDataAdapter(New SqlCommand("SELECT a.*, b.kd_jns_persd jenis FROM INV.dbo.INV_STOK_SALDO_DETIL a, SIF.dbo.SIF_Barang b WHERE a.kd_stok=b.Kode_Barang AND a.bultah = '" & periode & "' AND a.kd_stok = '" & lookBarang.EditValue & "'", sqlconn))
        End If

        daStokSaldo.Fill(dsStok, "StokSaldo")
        gcStokSaldo.DataSource = dsStok.Tables("StokSaldo")
        gvStokSaldo.BestFitColumns()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadData(lookPeriode.EditValue)
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
        Dim reportHeader As String = "STOK SALDO"
        Dim subReport As String = "per " & lookPeriode.Text

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
    End Sub

    Public Sub cetak_click()
        If Not gvStokSaldo.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        callReport(App_Path() & "\report\repStokSaldo.rpt", "", "thnbln=" & lookPeriode.EditValue & "&jenis=" & lookPersd.EditValue, False)
    End Sub
End Class