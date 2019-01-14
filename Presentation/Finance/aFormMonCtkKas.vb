
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonCtkKas
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String
    Dim isvalid As Boolean

    Dim saldoawal As String
    Dim saldohari As String
    Dim saldoakhir1 As String
    Dim saldoakhir2 As String
    Dim subReport, subReport2 As String

    Dim dsValuta, dsRek, dsGrid, dsSal As New DataSet
    Dim daValuta, daJurnalD, daRek, daGrid, daGridD, daSal, daSA As SqlDataAdapter

    Dim rl As DataRelation

    Public Sub add_click()
        btnSave = False
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = False
        setStatus()
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

    Private Sub aFormMonCtkKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadList()
        Me.Enabled = True

        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()
        Rekening.EditValue = "1012001"
    End Sub

    Private Sub loadList()
        daRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar WHERE grup_header='D' --AND grup_level3 = '11' UNION SELECT '0000000', '[Semua Rekening]'", sqlconn))
        daRek.Fill(dsRek, "Rekening")
        Rekening.Properties.DataSource = dsRek.Tables("Rekening")
        Rekening.Properties.DisplayMember = "nm_buku_besar"
        Rekening.Properties.ValueMember = "kd_buku_besar"

        daRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar WHERE grup_header='D'", sqlconn))
        daRek.Fill(dsRek, "Rekening2")
        lookBB.DataSource = dsRek.Tables("Rekening2")
        lookBB.DisplayMember = "nm_buku_besar"
        lookBB.ValueMember = "kd_buku_besar"
    End Sub

    Sub LoadAllData()
        dsGrid = New DataSet

        daGrid = New SqlDataAdapter(New SqlCommand("SELECT A.no_jur, A.tgl_trans, A.tgl_trans, A.no_ref1, A.no_ref3, A.nama, isnull(B.keterangan,a.keterangan) as keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit, b.saldo_rp_debet, b.saldo_rp_kredit, case when a.Last_created_by = 'SQLSVR' then 'Otomatis' else a.Last_created_by end as inputer FROM KOPKAR.dbo.FIN_JURNAL A, KOPKAR.dbo.FIN_JURNAL_D B, KOPKAR.dbo.m_buku_besar C WHERE A.no_jur = B.no_jur AND B.kd_buku_besar = C.kd_buku_besar AND A.tgl_trans BETWEEN CONVERT(DATE,'" & tglDari.EditValue & "',103) AND CONVERT(DATE,'" & tglsampai.EditValue & "',103) AND B.kd_buku_besar = '" & Rekening.EditValue & "' AND NOT (A.no_posting IS NULL OR A.no_posting = '') ORDER BY A.no_posting", sqlconn))
        daGrid.Fill(dsGrid, "BukuBesar")
        daGridD = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL_D WHERE no_jur IN (SELECT A.no_jur FROM KOPKAR.dbo.FIN_JURNAL A, KOPKAR.dbo.FIN_JURNAL_D B WHERE A.no_jur = B.no_jur AND A.tgl_trans BETWEEN CONVERT(DATE,'" & tglDari.EditValue & "',103) AND CONVERT(DATE,'" & tglsampai.EditValue & "',103) AND B.kd_buku_besar = '" & Rekening.EditValue & "' AND NOT (A.no_posting IS NULL OR A.no_posting = '')) AND NOT kd_buku_besar = '" & Rekening.EditValue & "'", sqlconn))
        daGridD.Fill(dsGrid, "BukuBesarD")
        rl = dsGrid.Relations.Add("DetailBB", dsGrid.Tables("BukuBesar").Columns("no_jur"), dsGrid.Tables("BukuBesarD").Columns("no_jur"), False)
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GCMonHTGL.LevelTree.Nodes.Add("DetailBB", GVMonHTGLD)
        GVMonHTGL.BestFitColumns()
        GVMonHTGLD.BestFitColumns()
    End Sub

    Sub ListHarian()
        If Not dsRek.Tables("BukuBesar") Is Nothing Then dsGrid.Tables("BukuBesar").Clear()
        daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, A.tgl_trans, A.tgl_trans , A.no_ref1, A.no_ref3 , B.keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit from KOPKAR.dbo.FIN_JURNAL A, KOPKAR.dbo.FIN_JURNAL_D B , KOPKAR.dbo.m_buku_besar C where A.no_jur = B.no_jur and B.kd_buku_besar = C.kd_buku_besar and a.tgl_trans between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) and b.kd_buku_besar = '" & Rekening.EditValue & "' and not (a.no_posting is null or A.no_posting = '')", sqlconn))
        daGrid.Fill(dsRek, "BukuBesar")
        GCMonHTGL.DataSource = dsRek.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()
    End Sub

    Sub hitungDebetKredit()
        TxtDebetKredit.EditValue = GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText
    End Sub

    Sub bersih()
        Rekening.EditValue = "0000000"
        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()
        TxtDebetKredit.Text = ""
        txtSaldoAwal.Text = ""
        txtSaldoAkhir.Text = ""
    End Sub

    Private Sub cek()
        If Rekening.EditValue = vbNullString Then
            isvalid = False
            err &= "Rekening belum dipilih." & vbCrLf
            If tglDari.EditValue > tglsampai.EditValue Then
                err &= "Tanggal awal lebih besar dari tanggal akhir." & vbCrLf
            End If
            If tglsampai.EditValue < tglDari.EditValue Then
                err &= "Tanggal akhir lebih kecil dari tanggal awal." & vbCrLf
            End If
        ElseIf tglDari.EditValue > tglsampai.EditValue Then
            isvalid = False
            err &= "Tanggal awal lebih besar dari tanggal akhir." & vbCrLf
            If Rekening.EditValue = vbNullString Then
                err &= "Rekening belum dipilih." & vbCrLf
            End If
            If tglsampai.EditValue < tglDari.EditValue Then
                err &= "Tanggal akhir lebih kecil dari tanggal awal." & vbCrLf
            End If
        ElseIf tglsampai.EditValue < tglDari.EditValue Then
            isvalid = False
            err &= "Tanggal akhir lebih kecil dari tanggal awal." & vbCrLf
            If Rekening.EditValue = vbNullString Then
                err &= "Rekening belum dipilih." & vbCrLf
            End If
            If tglDari.EditValue > tglsampai.EditValue Then
                err &= "Tanggal awal lebih besar dari tanggal akhir." & vbCrLf
            End If
        Else
            isvalid = True
        End If
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

    Public Sub cetak_click()
        If Not GVMonHTGL.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            inputer.Visible = False
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
            inputer.Visible = True
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        cek()
        If isvalid = True Then
            Dim dr As SqlDataReader = New SqlCommand("SELECT KOPKAR.dbo.hitungsaldoawal('" & Rekening.EditValue & "', 'IDR','" & tglDari.DateTime.Year & "', '" & tglDari.DateTime.Month & "', '" & tglDari.DateTime.Day & "')", sqlconn).ExecuteReader
            Clipboard.SetText("SELECT KOPKAR.dbo.hitungsaldoawal('" & Rekening.EditValue & "', 'IDR','" & tglDari.DateTime.Year & "', '" & tglDari.DateTime.Month & "', '" & tglDari.DateTime.Day & "')")
            dr.Read()
            If dr.HasRows Then
                txtSaldoAwal.EditValue = dr.Item(0)
            Else
                txtSaldoAwal.EditValue = "0"
            End If
            LoadAllData()
            hitungDebetKredit()
            txtSaldoAkhir.EditValue = CDbl(txtSaldoAwal.EditValue) + CDbl(TxtDebetKredit.EditValue) 'IIf(CDbl(TxtDebetKredit.EditValue) < 0, CDbl(TxtDebetKredit.EditValue) * -1, CDbl(TxtDebetKredit.EditValue))
        Else
            MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            err = ""
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,"
        Dim reportFooter3 As String = "(_______________________)"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Saldo awal"
        Dim reportFooter8 As String = "(Debet - Kredit)"
        Dim reportFooter11 As String = "Saldo Akhir"
        Dim reportFooter9 As String = txtSaldoAwal.Text
        Dim reportFooter10 As String = TxtDebetKredit.Text
        Dim reportFooter12 As String = txtSaldoAkhir.Text
        Dim reportFooter13 As String = ":"
        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 20)
        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 200, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 100, 300, 20)
        Dim rec6 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 200, 300, 20)
        Dim rec7 As RectangleF = New RectangleF(25, 10, CSng(e.Graph.MeasureString(reportFooter7).Width), 20)
        Dim rec8 As RectangleF = New RectangleF(25, 30, CSng(e.Graph.MeasureString(reportFooter8).Width), 20)
        Dim rec11 As RectangleF = New RectangleF(25, 50, CSng(e.Graph.MeasureString(reportFooter11).Width), 20)
        Dim rec9 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter9).Width) - 160), 10, CSng(e.Graph.MeasureString(reportFooter9).Width) + 10, 20)
        Dim rec10 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter10).Width) - 160), 30, CSng(e.Graph.MeasureString(reportFooter10).Width) + 10, 20)
        Dim rec12 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter12).Width) - 160), 50, CSng(e.Graph.MeasureString(reportFooter12).Width) + 10, 20)
        Dim rec13 As RectangleF = New RectangleF(155, 10, 10, 20)
        Dim rec14 As RectangleF = New RectangleF(155, 30, 10, 20)
        Dim rec15 As RectangleF = New RectangleF(155, 50, 10, 20)
        e.Graph.DrawString(reportFooter1, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter8, Color.Black, rec8, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter11, Color.Black, rec11, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter9, Color.Black, rec9, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter10, Color.Black, rec10, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter12, Color.Black, rec12, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec13, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec14, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec15, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING HARIAN KAS"
        Dim reportHeader1 As String = "Rekening Perkiraan : " & Rekening.Text
        If tglDari.EditValue = tglsampai.EditValue Then
            subReport = "Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = Format(tglDari.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(tglsampai.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        Dim rec3 As RectangleF = New RectangleF(0, 70, CSng(e.Graph.MeasureString(reportHeader1).Width) + 10, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString(reportHeader1, Color.Black, rec3, BorderSide.None)
    End Sub

    Private Sub tglDari_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tglDari.EditValueChanged
        If tglDari.EditValue = vbNullString Then
            tglDari.EditValue = getTanggal()
            tglsampai.EditValue = DateAdd(DateInterval.Month, 1, tglDari.EditValue)
            tglsampai.EditValue = DateAdd(DateInterval.Day, -1, tglsampai.EditValue)
        End If
    End Sub

    Private Sub tglsampai_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tglsampai.EditValueChanged
        If tglsampai.EditValue = vbNullString Then
            tglsampai.EditValue = getTanggal()
        End If
    End Sub
End Class