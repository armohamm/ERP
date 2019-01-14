Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonNeraca
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dsAktiva, dsLookUp As New DataSet
    Dim daAktiva, daLookUp As SqlDataAdapter

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

    Private Sub aFormMonAktiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        gvAktiva.BestFitColumns()

        loadLookUp()

        lckTahun.EditValue = CStr(Year(getTanggal()))
    End Sub

    Sub loadLookUp()
        If Not dsLookUp.Tables("Tahun") Is Nothing Then dsLookUp.Tables("Tahun").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT thn_buku FROM KOPKAR.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "Tahun")
        lckTahun.Properties.DataSource = dsLookUp.Tables("Tahun")
        lckTahun.Properties.DisplayMember = "thn_buku"
        lckTahun.Properties.ValueMember = "thn_buku"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        call_procedure(lckTahun.EditValue)
        reload()
    End Sub

    Private Sub reload()
        If Not dsAktiva.Tables("AktivaTetap") Is Nothing Then dsAktiva.Tables("AktivaTetap").Clear()

        daAktiva = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.TMP_MON_NERACA WHERE tahun = '" & lckTahun.EditValue & "'", sqlconn))

        daAktiva.Fill(dsAktiva, "AktivaTetap")
        gcAktiva.DataSource = dsAktiva.Tables("AktivaTetap")
        gvAktiva.BestFitColumns()

        gridTahunSblm.Caption = "Tahun " & CStr(CInt(lckTahun.EditValue) - 1)
        gridTahunIni.Caption = "Tahun " & lckTahun.EditValue
    End Sub

    Public Sub call_procedure(ByVal tahun As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.ISI_TMP_MON_NERACA"
        sqlCmd.Parameters.Add("@tahun", SqlDbType.Char).Value = tahun
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cetak_click()
        If Not gvAktiva.RowCount <= 0 Then
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("Hal. [Page #]")
            ph.Footer.Content.Add(getTanggal.ToLongDateString)

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi tahun terlebih dahulu.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "LAPORAN NERACA PER BULAN TH. " & lckTahun.EditValue
        Dim reportHeader2 As String = "KOPKAR PT. BANK CENTRAL ASIA, Tbk"
        Dim reportHeader3 As String = "MITRA SEJAHTERA SURABAYA"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(reportHeader).Width / 2), 0, e.Graph.MeasureString(reportHeader).Width + 1, e.Graph.MeasureString(reportHeader).Height)
        Dim rec2 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(reportHeader2).Width / 2), e.Graph.MeasureString(reportHeader2).Height, e.Graph.MeasureString(reportHeader2).Width + 1, 40)
        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(reportHeader3).Width / 2), e.Graph.MeasureString(reportHeader).Height, e.Graph.MeasureString(reportHeader3).Width + 1, 60)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
End Class