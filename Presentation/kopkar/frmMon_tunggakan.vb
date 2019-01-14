'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Public Class frmMon_tunggakan
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns, subReport, subReport2 As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation
    Public pilih, kd_krd As String


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cetak_click()
        gc_byr_piu.Refresh()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()

        'gc_byr_piu.Refresh()
        ''GcMonQC.OptionsPrint.UsePrintStyles = True
        'print_gc1(gc_byr_piu, "                                                                MONITORING GAGAL DEBET    " & vbCrLf & _
        '         "     ")
        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & xreportHeader)
        ph.Header.Content.Add("")
        'ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        'ph.Footer.Cont
        'ph.Footer.Content.Add("Dibuat Oleh")
        'ph.Footer.Content.Add("          ")
        'ph.Footer.Content.Add("(          )")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 105
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.Landscape = True
        link.CreateDocument()
        link.ShowPreview()

    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,"
        Dim reportFooter3 As String = "(  " & namauser & "  )"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Total Rekening"
        Dim reportFooter8 As String = "Total Gagal Debet"
        'Dim reportFooter11 As String = "Total Debet"
        Dim reportFooter9 As String = gv_byr_piu.Columns("nomer").SummaryText
        Dim reportFooter10 As String = gv_byr_piu.Columns("rupiah").SummaryText
        'Dim reportFooter12 As String = gv_byr_piu.Columns("JML_PINJAMAN").SummaryText
        Dim reportFooter13 As String = ":"
        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 20)
        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 150, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 100, 300, 20)
        Dim rec6 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 150, 300, 20)
        Dim rec7 As RectangleF = New RectangleF(25, 10, CSng(e.Graph.MeasureString(reportFooter7).Width), 20)
        Dim rec8 As RectangleF = New RectangleF(25, 30, CSng(e.Graph.MeasureString(reportFooter8).Width), 20)
        'Dim rec11 As RectangleF = New RectangleF(25, 50, CSng(e.Graph.MeasureString(reportFooter11).Width), 20)
        Dim rec9 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter9).Width) - 160), 10, CSng(e.Graph.MeasureString(reportFooter9).Width) + 10, 20)
        Dim rec10 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter10).Width) - 160), 30, CSng(e.Graph.MeasureString(reportFooter10).Width) + 10, 20)
        'Dim rec12 As RectangleF = New RectangleF(125 - (CSng(e.Graph.MeasureString(reportFooter12).Width) - 160), 50, CSng(e.Graph.MeasureString(reportFooter12).Width) + 10, 20)
        Dim rec13 As RectangleF = New RectangleF(155, 10, 10, 20)
        Dim rec14 As RectangleF = New RectangleF(155, 30, 10, 20)
        Dim rec15 As RectangleF = New RectangleF(155, 50, 10, 20)
        e.Graph.DrawString(reportFooter1, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter8, Color.Black, rec8, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter11, Color.Black, rec11, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter9, Color.Black, rec9, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter10, Color.Black, rec10, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter12, Color.Black, rec12, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec13, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec14, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter13, Color.Black, rec15, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        'Dim reportHeader As String = "LAPORAN PEMBAYARAN BUNGA DEPOSITO"
        'Dim reportHeader1 As String = "Per Tanggal "
        'If tglDari.EditValue = tglsampai.EditValue Then
        '    subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString
        'Else
        '    subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(tglsampai.EditValue, "d MMMM yyyy").ToString
        'End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'e.Graph.DrawImage(Presentation.My.Resources.LOGO_MSBCA1, New RectangleF(0, 25, e.Graph.ClientPageSize.Width, 20), BorderSide.None, Color.Azure)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        'Dim rec3 As RectangleF = New RectangleF(0, 70, CSng(e.Graph.MeasureString(reportHeader1).Width) + 10, 20)
        'e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        'e.Graph.DrawString(reportHeader1, Color.Black, rec3, BorderSide.None)
    End Sub

    Public Sub cancel_click()
        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur()



        Dim sqltgl As String = ""
        If Lue_Periode.EditValue = "PILIH" Then
            sqltgl = " where 1=0"
        ElseIf Lue_Periode.EditValue <> "PILIH" Then
            sqltgl = " where blthn='" & Lue_Periode.EditValue & "'"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString And Lue_Periode.EditValue = "PILIH" Then
            '    sqltgl = " where tgl_lunas > convert(date,'" & tglDari.Text & "',103)"
            'ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString And Lue_Periode.EditValue = "PILIH" Then
            '    sqltgl = " where tgl_lunas < convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And Lue_Periode.EditValue = "PILIH" Then
            '    sqltgl = " where tgl_lunas between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"

            'OFF karena ga pake bulan tahun
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '    sqltgl = "blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        dSO.Relations.Clear()
        If Not dSO.Tables("_dtl") Is Nothing Then dSO.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()

        'Dim sql_user As String = "select *,0 as nomer from angsuran where kode_lunas=2 and Last_Create_By='" & username & "'  "
        'Dim sql_adm As String = "select *,0 as nomer from angsuran where kode_lunas=2 "
        'If kddep = "2" Or kddep = "3" Then
        '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql_user & " and " & sqltgl, sqlconn))
        'Else
        '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql_adm & " and " & sqltgl, sqlconn))
        'End If
        Dim sql_adm As String = " "
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as nomer,case when lunas=0 THEN 'BELUM' WHEN lunas=1 THEN 'LUNAS' END AS lunas, * from gagaldebet " & sqltgl, sqlconn))
        'Clipboard.SetText(sql & " where " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_tbh ", sqlconn))
        'DA2.Fill(dSO, "_dtl")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
            gc_byr_piu.DataSource = dSO.Tables("_krd")
            'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)
        End If


        'GcINV_Ret.DataSource = dSO.Tables("_krd")
        isinomer()
    End Sub
    Public Sub save_click()

    End Sub
    Public Sub simpan()

    End Sub

    Private Sub frmMon_ritel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'LoadStruktur()
        'tglsampai.EditValue = Today
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RL_nama.DataSource = ds_cari.Tables("_lookup1")
        RL_nama.ValueMember = "nasabah_id"
        RL_nama.DisplayMember = "Nama"


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kode,Nama from m_jns_upload", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_jns")
        RL_jenis.DataSource = ds_cari1.Tables("_jns")
        RL_jenis.ValueMember = "kode"
        RL_jenis.DisplayMember = "Nama"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select DISTINCT(blthn) as periode from gagaldebet union ALL SELECT 'PILIH' as periode order by blthn desc", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_periode")
        Lue_Periode.Properties.DataSource = ds_gdg1.Tables("_periode")
        Lue_Periode.Properties.DisplayMember = "periode"
        Lue_Periode.Properties.ValueMember = "periode"
        Lue_Periode.EditValue = "PILIH"

        'tglsampai.EditValue = Today
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        LoadStruktur()
        isinomer()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
        isinomer()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub
End Class