Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormLaporanKasBon
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
        If Not lckPeriode.EditValue = vbNullString Then
            call_procedure(lckPeriode.EditValue)
            reload()
        Else
            MsgBox("Pilih periode terlebih dahulu.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
    End Sub

    Public Sub call_procedure(ByVal periode As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.fin_isi_tmp_rep_kasbon"

        sqlCmd.Parameters.Add("@vthnbln", SqlDbType.Char).Value = periode
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub reload()
        If Not dsKasBon.Tables("KasBon") Is Nothing Then dsKasBon.Tables("KasBon").Clear()

        daKasBon = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TMP_REPORT_KASBON WHERE periode = '" & lckPeriode.EditValue & "' ORDER BY no_urut", sqlconn))
        daKasBon.Fill(dsKasBon, "KasBon")
        gcKasBon.DataSource = dsKasBon.Tables("KasBon")
        gvKasBon.BestFitColumns()
    End Sub

    Private Sub aFormLaporanKasBon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
    End Sub

    Private Sub lckPeriode_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckPeriode.QueryPopUp
        If Not dsKasBon.Tables("LookPeriode") Is Nothing Then dsKasBon.Tables("LookPeriode").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS kode, nama_bulan + ' ' + thn_buku AS nama FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsKasBon, "LookPeriode")
        lckPeriode.Properties.DataSource = dsKasBon.Tables("LookPeriode")
        lckPeriode.Properties.DisplayMember = "nama"
        lckPeriode.Properties.ValueMember = "kode"
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
        Dim reportHeader As String = "MONITORING KAS BON"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Periode"
        Dim reportHeader5 As String = lckPeriode.Text
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