Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormLaporanKasBonHarian
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Dim dsKasBon As New DataSet
    Dim daKasBon, daLookUp As SqlDataAdapter

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If Not (dteTanggalAwal.EditValue = vbNullString Or dteTanggalAkhir.EditValue = vbNullString) Then
            'If Not dteTanggalAwal.EditValue > dteTanggalAkhir.EditValue Then

            'Else
            '    MsgBox("Tanggal awal melebihi tanggal akhir.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            '    Exit Sub
            'End If
            call_procedure()
            reload()
        Else
            MsgBox("Pilih periode terlebih dahulu.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
    End Sub

    Public Sub call_procedure()
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.fin_isi_tmp_rep_kasbon_today"
        sqlCmd.Parameters.Add("@tgldari", SqlDbType.Date).Value = FormatDateTime(dteTanggalAwal.EditValue, DateFormat.ShortDate)
        sqlCmd.Parameters.Add("@tglsampai", SqlDbType.Date).Value = FormatDateTime(dteTanggalAwal.EditValue, DateFormat.ShortDate)
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub reload()
        If Not dsKasBon.Tables("KasBon") Is Nothing Then dsKasBon.Tables("KasBon").Clear()

        daKasBon = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TMP_REPORT_KASBON_DAY WHERE tgl_periode = '" & Format(dteTanggalAwal.EditValue, "yyyy-MM-dd") & "' AND tgl_akhir = '" & Format(dteTanggalAwal.EditValue, "yyyy-MM-dd") & "' ORDER BY no_urut", sqlconn))
        daKasBon.Fill(dsKasBon, "KasBon")
        gcKasBon.DataSource = dsKasBon.Tables("KasBon")
        gvKasBon.BestFitColumns()
    End Sub

    Private Sub aFormLaporanKasBon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        dteTanggalAwal.EditValue = getTanggal()
        dteTanggalAkhir.EditValue = getTanggal()
    End Sub

    Public Sub cetak_click()
        If Not gvKasBon.RowCount <= 0 Then
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("Hal. [Page #]")
            ph.Footer.Content.Add(getTanggal.ToLongDateString)

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi periode lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING KAS BON HARIAN"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal"
        Dim reportHeader5 As String = dteTanggalAwal.Text & " s/d " & dteTanggalAkhir.Text
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(404, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
End Class