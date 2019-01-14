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

Public Class frmMonDepst_bln

    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation


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
    Public Sub cancel_click()
        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next

        For Each row1 As DataRow In dSO1.Tables("_pnpt").Rows
            row1.Item("nomer") = j : j += 1
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
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO1.Tables("_pnpt") Is Nothing Then dSO1.Tables("_pnpt").Clear()
        Dim sqltgl As String = ""
        Dim sqltgl2 As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
            sqltgl2 = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " TGL_TRANS > convert(date,'" & tglDari.Text & "',103)"
            sqltgl2 = " TGL_REGISTRASI > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " TGL_TRANS < convert(date,'" & tglsampai.Text & "',103)"
            sqltgl2 = " TGL_REGISTRASI < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " TGL_TRANS between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            sqltgl2 = " TGL_REGISTRASI between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"

            'OFF karena ga pake bulan tahun
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '    sqltgl = "blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_trans,qc.no_ref,qcm.sj_supplier as no_sj,qc.kd_satuan,qc.kd_stok,qc.Last_Created_By,brg.Nama_Barang,brg.spek_brg,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,ISNULL(qc.hold,0) as hold,ISNULL(qc.hold_histroy,0) as hold_histroy,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok= brg.Kode_Barang where " & sqltgl & "", sqlconn))
        'Dim sql As String = "SELECT     qc.tgl_trans, qc.no_trans, qc.no_ref, qcm.sj_supplier AS no_sj, qc.kd_satuan, qc.kd_stok, qc.Last_Created_By, brg.Nama_Barang, brg.spek_brg,  " & _
        '               " qc.qty_datang, qc.qty_order, qc.qty_qc_pass, qc.qty_qc_unpass, ISNULL(qc.hold, 0) AS hold, ISNULL(qc.hold_histroy, 0) AS hold_histroy, qc.qty_sisa, qc.rp_trans, " & _
        '               " qcm.jml_rp_trans, 0 AS nomer, qc.keterangan, SIF.dbo.SIF_Supplier.Nama_Supplier " & _
        '              " FROM         SIF.dbo.SIF_Supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC_M AS qcm ON SIF.dbo.SIF_Supplier.Kode_Supplier = qcm.kd_supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC AS qc ON qcm.no_trans = qc.no_trans LEFT OUTER JOIN " & _
        '              " SIF.dbo.SIF_Barang AS brg ON qc.kd_stok = brg.Kode_Barang "
        Dim sql As String = "select *,0 as nomer from tabung t inner join tabtrans tr on t.NO_TABUNGAN=tr.NO_TABUNGAN where tr.KODE_TRANS='02' "
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql & " and " & sqltgl, sqlconn))
        Clipboard.SetText(sql & " and " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans ", sqlconn))
        'DA2.Fill(dSO, "_dtl")

        'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
        gc_cair.DataSource = dSO.Tables("_krd")
        'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)

        'GcINV_Ret.DataSource = dSO.Tables("_krd")


        If Not dSO1.Tables("_pnpt") Is Nothing Then dSO1.Tables("_pnpt").Clear()
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from tabung where JENIS_TABUNGAN='005' AND STATUS_AKTIF='AKTIF' and " & sqltgl2, sqlconn))
        DA2.Fill(dSO1, "_pnpt")
        gc_pnpt.DataSource = dSO1.Tables("_pnpt")
        isinomer()
    End Sub

    Public Sub cetak_click()
        gc_pnpt.Refresh()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        print_gc1(gc_pnpt, "                                                                MONITORING DEPOSITO    " & vbCrLf & _
                 "     ")
        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
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

    Public Sub save_click()
        'If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub simpan()

    End Sub

    Private Sub frmMonDepst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select t.nasabah_id,a.Nama from tabung t left join anggota a on t.NASABAH_ID = a.nasabah_id where t.JENIS_TABUNGAN='005'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota where Rec_Stat=1", sqlconn))
        DA_gdg1.Fill(ds_cari3, "_lookup3")
        rep1_nama.DataSource = ds_cari3.Tables("_lookup3")
        rep1_nama.ValueMember = "nasabah_id"
        rep1_nama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kd_status_agenda,keterangan from m_agenda", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        RL_stat.DataSource = ds_cari1.Tables("_lookup2")
        RL_stat.ValueMember = "kd_status_agenda"

        LoadStruktur()
        tglsampai.Text = Today

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub
End Class