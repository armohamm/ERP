Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonUM
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsMonitoring As New DataSet
    Dim daUM, daPelunasan, daKartu, daVal As SqlDataAdapter
    Dim noUangMuka, subReport, repNama As String

    Private Sub aFormMonUM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        SplitContainerControl1.SplitterPosition = CInt(SplitContainerControl1.Size.Height / 2)
        dtpTanggal.EditValue = getTanggal()
        loadLookUp()
        loadAll()
        lckKartu.EditValue = "00000"
    End Sub

    Private Sub loadAll()
        loadUM()
        If Not gvUM.RowCount <= 0 Then
            Dim viewUM As ColumnView = gvUM.Columns.View
            noUangMuka = viewUM.GetFocusedRowCellValue("nomor").ToString
            loadPelunasan(noUangMuka)
            noUangMuka = ""
        Else
            dsMonitoring.Tables("Pelunasan").Clear()
        End If
    End Sub

    Private Sub loadLookUp()
        If Not dsMonitoring.Tables("Kartu") Is Nothing Then dsMonitoring.Tables("Kartu").Clear()
        If Not dsMonitoring.Tables("Valuta") Is Nothing Then dsMonitoring.Tables("Valuta").Clear()

        daKartu = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu UNION SELECT '00000','[Semua Data]'", sqlconn))
        daKartu.Fill(dsMonitoring, "Kartu")
        lckKartu.Properties.DataSource = dsMonitoring.Tables("Kartu")
        lckKartu.Properties.DisplayMember = "nama"
        lckKartu.Properties.ValueMember = "kode"
        lookupKartu.DataSource = dsMonitoring.Tables("Kartu")
        lookupKartu.DisplayMember = "nama"
        lookupKartu.ValueMember = "kode"

        daKartu = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM SIF.dbo.SIF_Valuta", sqlconn))
        daKartu.Fill(dsMonitoring, "Valuta")
        lookupValuta.DataSource = dsMonitoring.Tables("Valuta")
        lookupValuta.DisplayMember = "Nama_Valuta"
        lookupValuta.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadUM()
        If Not dsMonitoring.Tables("UangMuka") Is Nothing Then dsMonitoring.Tables("UangMuka").Clear()
        If lckKartu.EditValue = vbNullString Or lckKartu.EditValue = "00000" Then
            If chkPosting.Checked = True Then
                daUM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
                " FROM FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
                " WHERE A.no_jurnal = B.no_jur " & _
                " AND NOT (B.no_posting IS NULL OR B.no_posting = '')" & _
                " AND A.tipe_trans IN ('JRR-KPT-13','JKM-KPT-04', 'JKM-KPT-08')" & _
                " AND A.tanggal <= CONVERT(DATE,'" & dtpTanggal.EditValue & "',103)", sqlconn))
            Else
                daUM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
                " FROM FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
                " WHERE A.no_jurnal = B.no_jur " & _
                " AND A.tipe_trans IN ('JRR-KPT-13','JKM-KPT-04', 'JKM-KPT-08')" & _
                " AND A.tanggal <= CONVERT(DATE,'" & dtpTanggal.EditValue & "',103)", sqlconn))
            End If
        Else
            If chkPosting.Checked = True Then
                daUM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
                " FROM FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
                " WHERE A.no_jurnal = B.no_jur " & _
                " AND NOT (B.no_posting IS NULL OR B.no_posting = '')" & _
                " AND A.tipe_trans IN ('JRR-KPT-13','JKM-KPT-04', 'JKM-KPT-08')" & _
                " AND A.tanggal <= CONVERT(DATE,'" & dtpTanggal.EditValue & "',103)" & _
                " AND A.kartu = '" & lckKartu.EditValue & "'", sqlconn))
            Else
                daUM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
                " FROM FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
                " WHERE A.no_jurnal = B.no_jur " & _
                " AND A.tipe_trans IN ('JRR-KPT-13','JKM-KPT-04', 'JKM-KPT-08')" & _
                " AND A.tanggal <= CONVERT(DATE,'" & dtpTanggal.EditValue & "',103)" & _
                " AND A.kartu = '" & lckKartu.EditValue & "'", sqlconn))
            End If
        End If

        daUM.Fill(dsMonitoring, "UangMuka")
        gcUM.DataSource = dsMonitoring.Tables("UangMuka")
        gvUM.BestFitColumns()
    End Sub

    Private Sub loadPelunasan(ByVal noUm As String)
        If Not dsMonitoring.Tables("Pelunasan") Is Nothing Then dsMonitoring.Tables("Pelunasan").Clear()
        If chkPosting.Checked = True Then
            daPelunasan = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.no_trans) as 'no',A.no_trans,D.prev_no_inv ,A.no_ref2,A.tgl_trans ,A.keterangan ,D.jml_bayar " & _
            " FROM FIN.dbo.FIN_NOTA_LUNAS A,FIN.dbo.FIN_JURNAL B, FIN.dbo.FIN_NOTA_LUNAS_D D" & _
            " WHERE A.no_trans = B.no_jur " & _
            " AND A.no_trans = D.no_trans " & _
            " AND NOT (B.no_posting IS NULL OR B.no_posting = '') " & _
            " AND A.no_do='" & noUm & "'", sqlconn))
        Else
            daPelunasan = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY A.no_trans) as 'no',A.no_trans,D.prev_no_inv ,A.no_ref2,A.tgl_trans ,A.keterangan ,D.jml_bayar " & _
            " FROM FIN.dbo.FIN_NOTA_LUNAS A,FIN.dbo.FIN_JURNAL B, FIN.dbo.FIN_NOTA_LUNAS_D D" & _
            " WHERE A.no_trans = B.no_jur " & _
            " AND A.no_trans = D.no_trans " & _
            " AND A.no_do='" & noUm & "'", sqlconn))
        End If
        daPelunasan.Fill(dsMonitoring, "Pelunasan")
        gcPelunasan.DataSource = dsMonitoring.Tables("Pelunasan")
        gvPelunasan.BestFitColumns()
    End Sub

    Private Sub gvUM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvUM.Click
        loadPelunasan(gvUM.GetFocusedRowCellValue("nomor").ToString)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadAll()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked = True Then
            chkOutStanding.Checked = False
            gvUM.ActiveFilterString = ""
        End If
    End Sub

    Private Sub chkOutStanding_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOutStanding.CheckedChanged
        If chkOutStanding.Checked = True Then
            chkAll.Checked = False
            gvUM.ActiveFilterString = "jml_akhir > 0"
        End If
    End Sub

    Public Sub cetak_click()
        MsgBox("Maaf, mohon gunakan tombol Cetak diatas.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "PEMBERITAHUAN!")
    End Sub

    Private Sub chkLapUM_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If chkLapUM.Checked = True Then
            chkLapLunas.Checked = False
            chkLapRinci.Checked = False
        End If
    End Sub

    Private Sub chkLapLunas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If chkLapLunas.Checked = True Then
            chkLapUM.Checked = False
            chkLapRinci.Checked = False
        End If
    End Sub

    Private Sub chkLapRinci_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If chkLapRinci.Checked = True Then
            chkLapUM.Checked = False
            chkLapLunas.Checked = False
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkLapUM.Checked = False And chkLapLunas.Checked = False And chkLapRinci.Checked = False Then
            MsgBox("Metode pencetakkan belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If

        If chkLapUM.Checked = True Then
            If Not gvUM.RowCount <= 0 Then
                pclUM.CreateDocument()
                pclUM.ShowPreview()
            Else
                MsgBox("Tidak ada data uang muka yang dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        ElseIf chkLapLunas.Checked = True Then
            If Not gvPelunasan.RowCount <= 0 Then
                pclLunas.CreateDocument()
                pclLunas.ShowPreview()
            Else
                MsgBox("Tidak ada data pelunasan yang dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        ElseIf chkLapRinci.Checked = True Then
            If gvUM.RowCount <= 0 And gvPelunasan.RowCount <= 0 Then
                MsgBox("Data uang muka atau pelunasannya tidak boleh kosong jika metode cetak yang dipilih adalah Rinci.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            Else
                callReport(App_Path() & "\report\repLapUM.rpt", "", "do=" & gvUM.GetFocusedRowCellValue("nomor").ToString & "&tgl=" & dtpTanggal.EditValue, False)
            End If
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

    Private Sub pclUM_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles pclUM.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING UANG MUKA"
        subReport = "Per tanggal " & Format(dtpTanggal.EditValue, "d MMMM yyyy").ToString
        repNama = "Kartu : " & lckKartu.Text

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 40, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        If Not lckKartu.EditValue = vbNullString Then
            e.Graph.DrawString(repNama, Color.Black, rec3, BorderSide.None)
        End If
    End Sub

    Private Sub pclLunas_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles pclLunas.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING PELUNASAN UANG MUKA"
        subReport = "Per tanggal " & Format(dtpTanggal.EditValue, "d MMMM yyyy").ToString
        repNama = "Kartu : " & lckKartu.Text

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 40, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        If Not lckKartu.EditValue = vbNullString Then
            e.Graph.DrawString(repNama, Color.Black, rec3, BorderSide.None)
        End If
    End Sub

    Private Sub chkPosting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPosting.CheckedChanged
        If chkPosting.Checked = True Then
            chkNonPosting.Checked = False
        End If
    End Sub

    Private Sub chkNonPosting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonPosting.CheckedChanged
        If chkNonPosting.Checked = True Then
            chkPosting.Checked = False
        End If
    End Sub
End Class