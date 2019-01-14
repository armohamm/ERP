'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmMonKasBon
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim subReport As String

    Dim dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsDetkasBon, dsBukuBesar, dsBukuPusat As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daDetkasBon, daBukuBesar, daBukuPusat As SqlDataAdapter

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

    Private Sub frmMonKasBon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        dteAwal.EditValue = getTanggal()
        dteAkhir.EditValue = getTanggal()
        loadLookUP()
        Kartu.EditValue = "000000000"
        CEPPAll.Checked = True
        CEPPOutStanding.Checked = False

        Me.Enabled = True
    End Sub

    Private Sub refreshnomer()
        For i As Integer = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(i, "no", i + 1)
        Next
    End Sub

    Sub LoadGrid1All()
        If Not dsDetkasBon.Tables("detkasbon") Is Nothing Then dsDetkasBon.Tables("detkasbon").Clear()

        If Kartu.EditValue = "000000000" Then
            If CEPPAll.Checked = True Then
                CEPPOutStanding.Checked = False
                daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select jml_bayar, nomor as seq, KOPKAR.dbo.namabulan(LEFT(nomor,6)) as nokas, nomor, tipe_trans, tgl_trans, kd_kartu, keterangan ,jml_akhir, jml_trans from KOPKAR.dbo.FIN_KAS_BON where tgl_trans between CONVERT(DATE, '" & dteAwal.EditValue & "', 103) and CONVERT(DATE, '" & dteAkhir.EditValue & "', 103) order by tgl_trans", sqlconn))
            End If
            If CEPPOutStanding.Checked = True Then
                CEPPAll.Checked = False
                daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select jml_bayar, nomor as seq, KOPKAR.dbo.namabulan(LEFT(nomor,6)) as nokas, nomor, tipe_trans, tgl_trans, kd_kartu, keterangan ,jml_akhir, jml_trans from KOPKAR.dbo.FIN_KAS_BON where jml_akhir > 0 AND tgl_trans between CONVERT(DATE, '" & dteAwal.EditValue & "', 103) and CONVERT(DATE, '" & dteAkhir.EditValue & "', 103) order by tgl_trans", sqlconn))
            End If
        Else
            If CEPPAll.Checked = True Then
                CEPPOutStanding.Checked = False
                daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select jml_bayar, nomor as seq, KOPKAR.dbo.namabulan(LEFT(nomor,6)) as nokas, nomor, tipe_trans, tgl_trans, kd_kartu, keterangan ,jml_akhir, jml_trans from KOPKAR.dbo.FIN_KAS_BON where tgl_trans between CONVERT(DATE, '" & dteAwal.EditValue & "', 103) and CONVERT(DATE, '" & dteAkhir.EditValue & "', 103) and kd_kartu = '" & Kartu.EditValue & "' order by tgl_trans", sqlconn))
            End If
            If CEPPOutStanding.Checked = True Then
                CEPPAll.Checked = False
                daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select jml_bayar, nomor as seq, KOPKAR.dbo.namabulan(LEFT(nomor,6)) as nokas, nomor, tipe_trans, tgl_trans, kd_kartu, keterangan ,jml_akhir, jml_trans from KOPKAR.dbo.FIN_KAS_BON where jml_akhir > 0 AND tgl_trans between CONVERT(DATE, '" & dteAwal.EditValue & "', 103) and CONVERT(DATE, '" & dteAkhir.EditValue & "', 103) and kd_kartu = '" & Kartu.EditValue & "' order by tgl_trans", sqlconn))
            End If
        End If

        'dsDetkasBon.Clear()
        'daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tipe_trans ,A.tgl_trans,A.kd_kartu,A.keterangan,A.jml_akhir,A.jml_trans " & _
        '"   from FIN.dbo.FIN_KAS_BON A " & _
        '"   where a.jml_akhir >= 0", sqlconn))

        daDetkasBon.Fill(dsDetkasBon, "detkasbon")
        GC1.DataSource = dsDetkasBon.Tables("detkasbon")
        GV1.BestFitColumns()

        If Not GV1.RowCount <= 0 Then
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)
        End If

    End Sub

    Sub LoadGrid2()

        dsDetUt.Clear()
        daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY C.nomor) as 'no',C.tipe_trans,D.tipe_trans ,C.prev_nomor ,D.prev_nomor,C.nomor,D.nomor,C.tgl_trans,D.rekening ,D.pusat_biaya ,D.keterangan ,D.jml_trans " & _
        "   from KOPKAR.dbo.FIN_JURNAL B ,KOPKAR.dbo.FIN_LUNAS_KAS_BON C ,KOPKAR.dbo.FIN_LUNAS_KAS_BON_D D " & _
        "   where B.no_jur = C.nomor  " & _
        "   and  C.nomor = D.nomor ", sqlconn))
        daDetUt.Fill(dsDetUt, "pelunasan")
        GC2.DataSource = dsDetUt.Tables("pelunasan")
        GV2.BestFitColumns()

    End Sub

    Sub loadLookUP()
        If Not dsSupp.Tables("kartu") Is Nothing Then dsSupp.Tables("kartu").Clear()
        If Not dsBukuBesar.Tables("rekening") Is Nothing Then dsBukuBesar.Tables("rekening").Clear()
        If Not dsBukuPusat.Tables("pusat") Is Nothing Then dsBukuPusat.Tables("pusat").Clear()

        daSupp = New SqlDataAdapter(New SqlCommand("select a.kode,a.nama from KOPKAR.dbo.v_kartu a order by a.nama ", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVKartu.Properties.DataSource = dsSupp.Tables("kartu")
        LOVKartu.Properties.DisplayMember = "nama"
        LOVKartu.Properties.ValueMember = "kode"
        Kartu.Properties.DataSource = dsSupp.Tables("kartu")
        Kartu.Properties.DisplayMember = "nama"
        Kartu.Properties.ValueMember = "kode"

        daBukuBesar = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  SELECT * FROM KOPKAR.dbo.m_buku_besar", sqlconn))
        daBukuBesar.Fill(dsBukuBesar, "rekening")
        LOVRekBiaya.DataSource = dsBukuBesar.Tables("rekening")
        LOVRekBiaya.Properties.DisplayMember = "nm_buku_besar"
        LOVRekBiaya.Properties.ValueMember = "kd_buku_besar"

        daBukuPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.SIF_buku_pusat ", sqlconn))
        daBukuPusat.Fill(dsBukuPusat, "pusat")
        LOVPusBiaya.DataSource = dsBukuPusat.Tables("pusat")
        LOVPusBiaya.Properties.DisplayMember = "nm_buku_pusat"
        LOVPusBiaya.Properties.ValueMember = "kd_buku_pusat"
    End Sub

    'Sub listShortingGrid1()

    '    If CEPPAll.Checked = True Then

    '        dsDetkasBon.Clear()
    '        daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("   select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',a.jml_bayar, SUBSTRING(a.nomor,11,5) as seq, SIF.dbo.namabulan(LEFT(a.nomor,6)) as nokas,A.nomor,A.tipe_trans ,A.tgl_trans,A.kd_kartu,A.keterangan,A.jml_akhir,A.jml_trans   " & _
    '        "   from FIN.dbo.FIN_KAS_BON A  " & _
    '        "   where a.jml_akhir >= 0  " & _
    '        "   and A.kd_kartu = '" & Kartu.EditValue & "'  " & _
    '        "   and A.tgl_trans <= convert(date,'" & Tanggal.Text & "',103) ", sqlconn))

    '        daDetkasBon.Fill(dsDetkasBon, "detkasbon")
    '        GC1.DataSource = dsDetkasBon.Tables("detkasbon")
    '        GV1.BestFitColumns()

    '    End If

    '    If CEPPOutStanding.Checked = True Then

    '        dsDetkasBon.Clear()
    '        daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("   select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',a.jml_bayar, SUBSTRING(a.nomor,11,5) as seq, SIF.dbo.namabulan(LEFT(a.nomor,6)) as nokas,A.nomor,A.tipe_trans ,A.tgl_trans,A.kd_kartu,A.keterangan,A.jml_akhir,A.jml_trans   " & _
    '        "   from FIN.dbo.FIN_KAS_BON A  " & _
    '        "   where A.jml_akhir > 0 " & _
    '        "   and A.kd_kartu = '" & Kartu.EditValue & "' " & _
    '        "   and A.tgl_trans <= convert(date,'" & Tanggal.Text & "',103) ", sqlconn))

    '        daDetkasBon.Fill(dsDetkasBon, "detkasbon")
    '        GC1.DataSource = dsDetkasBon.Tables("detkasbon")
    '        GV1.BestFitColumns()

    '    End If

    'End Sub

    Sub loadPelunasan(Optional ByVal nomorKasBon As String = "")
        'lblError.Text = "..."
        Try

            dsDetUt.Clear()
            daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY C.nomor) as 'no', " & _
                                                                            "C.tipe_trans,D.tipe_trans ,C.prev_nomor ,D.prev_nomor, " & _
                                                                            "C.nomor, D.nomor, C.tgl_trans, D.rekening, D.pusat_biaya, D.keterangan, D.jml_trans, " & _
                                                                            "c.sisa_hutang as minusplus " & _
                                                                            "from KOPKAR.dbo.FIN_LUNAS_KAS_BON C ,KOPKAR.dbo.FIN_LUNAS_KAS_BON_D D " & _
                                                                            "where C.nomor = D.nomor " & _
                                                                            "and C.prev_nomor = '" & nomorKasBon & "' ", sqlconn))

            daDetUt.Fill(dsDetUt, "pelunasan")
            GC2.DataSource = dsDetUt.Tables("pelunasan")
            GV2.BestFitColumns()

        Catch ex As Exception
            'lblError.Text = ex.Message
        End Try
    End Sub


    Private Sub GC1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC1.Click
        'SELECT GRID 2
        Try
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)

            'MsgBox(kKb)
        Catch ex As Exception
            'lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadGrid1All()
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

    Private Sub CEPPAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPAll.CheckedChanged
        If CEPPAll.Checked = True Then
            CEPPOutStanding.Checked = False
        Else
            CEPPOutStanding.Checked = True
        End If
    End Sub

    Private Sub CEPPOutStanding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPOutStanding.CheckedChanged
        If CEPPOutStanding.Checked = True Then
            CEPPAll.Checked = False
        Else
            CEPPAll.Checked = True
        End If
    End Sub

    Private Sub CEGV1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEGV1.CheckedChanged
        If CEGV1.Checked = True Then
            CEGV2.Checked = False
        Else
            CEGV2.Checked = True
        End If
    End Sub

    Private Sub CEGV2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEGV2.CheckedChanged
        If CEGV2.Checked = True Then
            CEGV1.Checked = False
        Else
            CEGV1.Checked = True
        End If
    End Sub

    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)

            'MsgBox(kKb)
        Catch ex As Exception
            'lblError.Text = ex.Message
        End Try
    End Sub

    Public Sub cetak_click()
        GV1.OptionsView.ShowViewCaption = False
        'kd_kartu.Visible = False
        If CEGV1.Checked = True Then
            If Not GV1.RowCount <= 0 Then
                'ShowGridPreview(GCMonHTGL)
                PrintableComponentLink1.CreateDocument()
                PrintableComponentLink1.Landscape = True


                PrintableComponentLink1.ShowPreview()
            Else
                MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        Else
            If Not GV2.RowCount <= 0 Then
                'ShowGridPreview(GCMonHTGL)
                PrintableComponentLink2.CreateDocument()
                PrintableComponentLink2.Landscape = True

                PrintableComponentLink2.ShowPreview()
            Else
                MsgBox("Tidak ada data pelunasan yang dicetak. Silahkan klik pada bon gantung.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        End If
        GV1.OptionsView.ShowViewCaption = True
        kd_kartu.Visible = True
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING KARTU KAS BON"
        Dim reportHeader2 As String = "Kartu"
        Dim reportHeader3 As String = ":"
        Dim reportHeader4 As String = IIf(Kartu.EditValue = "000000000", "", Kartu.Text)
        If dteAwal.EditValue = dteAkhir.EditValue Then
            subReport = "Per tanggal " & Format(dteAwal.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = Format(dteAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(dteAkhir.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(reportHeader).Width / 2), 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec2 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(subReport).Width / 2), 25, e.Graph.MeasureString(subReport, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec3 As RectangleF = New RectangleF(0, 75, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec4 As RectangleF = New RectangleF(rec3.Width, 75, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec5 As RectangleF = New RectangleF(rec3.Width + rec4.Width, 75, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 25)

        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString(reportHeader2, Color.Black, rec3, BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec4, BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec5, BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink2_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink2.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING KARTU KAS BON"
        Dim reportHeader2 As String = "Kartu"
        Dim reportHeader3 As String = ":"
        Dim reportHeader4 As String = IIf(Kartu.EditValue = "000000000", "", Kartu.Text)
        If dteAwal.EditValue = dteAkhir.EditValue Then
            subReport = "Per tanggal " & Format(dteAwal.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = Format(dteAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(dteAkhir.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(reportHeader).Width / 2), 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec2 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 2) - (e.Graph.MeasureString(subReport).Width / 2), 25, e.Graph.MeasureString(subReport, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec3 As RectangleF = New RectangleF(0, 75, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec4 As RectangleF = New RectangleF(rec3.Width, 75, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 25)
        Dim rec5 As RectangleF = New RectangleF(rec3.Width + rec4.Width, 75, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 25)

        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString(reportHeader2, Color.Black, rec3, BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec4, BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec5, BorderSide.None)
    End Sub
End Class