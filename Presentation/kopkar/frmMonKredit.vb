﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Public Class frmMonKredit
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
    Public pilih, kd_krd, nm As String


    Public Sub add_click()
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
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
        GcINV_Ret.Refresh()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        print_gc1(GcINV_Ret, "                                                                MONITORING PENGAJUAN KREDIT PINJAMAN    " & vbCrLf & _
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
        'If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
        '    sqltgl = "1=0"
        If tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"

            'OFF karena ga pake bulan tahun
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '    sqltgl = "blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        dSO.Relations.Clear()
        If Not dSO.Tables("_dtl") Is Nothing Then dSO.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_trans,qc.no_ref,qcm.sj_supplier as no_sj,qc.kd_satuan,qc.kd_stok,qc.Last_Created_By,brg.Nama_Barang,brg.spek_brg,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,ISNULL(qc.hold,0) as hold,ISNULL(qc.hold_histroy,0) as hold_histroy,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok= brg.Kode_Barang where " & sqltgl & "", sqlconn))
        'Dim sql As String = "SELECT     qc.tgl_trans, qc.no_trans, qc.no_ref, qcm.sj_supplier AS no_sj, qc.kd_satuan, qc.kd_stok, qc.Last_Created_By, brg.Nama_Barang, brg.spek_brg,  " & _
        '               " qc.qty_datang, qc.qty_order, qc.qty_qc_pass, qc.qty_qc_unpass, ISNULL(qc.hold, 0) AS hold, ISNULL(qc.hold_histroy, 0) AS hold_histroy, qc.qty_sisa, qc.rp_trans, " & _
        '               " qcm.jml_rp_trans, 0 AS nomer, qc.keterangan, SIF.dbo.SIF_Supplier.Nama_Supplier " & _
        '              " FROM         SIF.dbo.SIF_Supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC_M AS qcm ON SIF.dbo.SIF_Supplier.Kode_Supplier = qcm.kd_supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC AS qc ON qcm.no_trans = qc.no_trans LEFT OUTER JOIN " & _
        '              " SIF.dbo.SIF_Barang AS brg ON qc.kd_stok = brg.Kode_Barang "
        Dim sql As String = "select case when STATUS_AKTIF=0 THEN 'PENGAJUAN' WHEN STATUS_AKTIF=1 THEN 'SUDAH CAIR' END AS stat,(JML_POKOK+JML_BUNGA) as angs,0 as nomer,* from kredit where status_lunas='BELUM' and kd_kredit in ('NORM','DNOR','PBRG') " 'and kd_kredit='KRD' and jenis not in ('BNS ')"
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql & " and " & sqltgl, sqlconn))
        'Clipboard.SetText(sql & " where " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_pot ", sqlconn))
        DA2.Fill(dSO, "_dtl")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            'dSO.Relations.Remove(drl)
            'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
            'GcINV_Ret.DataSource = dSO.Tables("_krd")
            'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)

            dSO.Relations.Remove(drl)
            drl = New DataRelation("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
            dSO.Relations.Add(drl)
            'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), True)
            GcINV_Ret.DataSource = dSO.Tables("_krd")

            GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)
        End If
        

        'GcINV_Ret.DataSource = dSO.Tables("_krd")
        isinomer()
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        'If STATE = "EDIT" Then
        row = dSO.Tables("_krd").Rows(0)
        row.Item("Last_Update") = getTanggal()
        row.Item("Last_Updated_By") = username
        row.Item("form_by") = Me.Name
        'ElseIf STATE = "CETAK" Then
        '    row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        'End If

        'row.Item("SALDO_AKHIR") = tx_saldo2.Text
        'row.Item("JENIS_TABUNGAN") = LUE_jnsTab.EditValue
        'row.Item("NO_TABUNGAN") = id_anggota + LUE_jnsTab.EditValue
        'row.Item("TGL_REGISTRASI") = dtp_tgl.Text
        'row.Item("SALDO_AWAL") = tx1_setoran.Text
        'row.Item("SALDO_AKHIR") = tx1_setoran.Text
        ''row.Item("JML_DENDA") = t_admin.Text
        'row.Item("STATUS_AKTIF") = "PENGAJUAN"
        'row.Item("jns_bayar") = cb_byr.Text
        'row.Item("approve1_by") = "OutStanding"
        'row.Item("stat_approve") = 0
        'row.Item("stat_cair") = 0
        'row.Item("KETERANGAN") = tx1_ket.Text

        'dSO.Tables("_krd").Rows.Add(row)

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            'Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
            'sqlcmd1.ExecuteNonQuery()
            'For Each row As DataRow In dSO.Tables("_krd").Rows
            '    If row.RowState = DataRowState.Modified Then
            '        Dim sqlcmd1 As New SqlCommand("update KOPKAR.dbo.anggota set Nama='" & row.Item("nm") & "' where nasabah_id='" & row.Item("nasabah_id") & "'", sqlconn, BTRANS)
            '        sqlcmd1.ExecuteNonQuery()
            '    End If
            'Next

            DA.Update(dSO.Tables("_krd"))
            'DA2.Update(dSO1.Tables("_krd"))

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            btnSave = False
            setStatus()
            'cancel_click()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub


    Private Sub frmMonKredit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'LoadStruktur()
        tglsampai.EditValue = Today
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kd_status_agenda,keterangan from m_agenda", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        RL_stat.DataSource = ds_cari1.Tables("_lookup2")
        RL_stat.ValueMember = "kd_status_agenda"
        RL_stat.DisplayMember = "keterangan"


    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
        isinomer()
    End Sub

  
    'Private Sub GV_RLSKRD_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GcINV_Ret.DoubleClick
    '    If GV_RLSKRD.RowCount <> 0 Then
    '        'MsgBox("ini gv")
    '        'MsgBox("ini gv")
    '        pilih = GV_RLSKRD.GetRow(GV_RLSKRD.GetSelectedRows(0)).Item("no_trans").ToString()
    '        kd_krd = GV_RLSKRD.GetRow(GV_RLSKRD.GetSelectedRows(0)).Item("kd_kredit").ToString()
    '        'nm = GV_RLSKRD.GetRow(GV_RLSKRD.GetSelectedRows(0)).Item("Nama").ToString()
    '        'MsgBox(pilih & " dan " & kd_krd)
    '        If kd_krd = "KRD" Then
    '            frmKredit.STATE = "EDIT"
    '            frmKredit._notrans = pilih
    '            frmKredit.ShowDialog()
    '            frmKredit.hitung_all()
    '            'frmKredit.lb_nama.Text = nm
    '        ElseIf kd_krd = "CUS" Then
    '            frmKreditCustom.STATE = "EDIT"
    '            frmKreditCustom._notrans = pilih
    '            'frmKreditCustom.lb_nama.Text = nm
    '            frmKreditCustom.ShowDialog()

    '        ElseIf kd_krd = "MTS" Then
    '            frmKreditMTS.STATE = "EDIT"
    '            frmKreditMTS._notrans = pilih
    '            'frmKreditMTS.
    '            frmKreditMTS.ShowDialog()
    '        ElseIf kd_krd = "REC" Then
    '            frmKreditREC.STATE = "EDIT"
    '            frmKreditREC._notrans = pilih
    '            'frmKreditREC.lb_nama.Text = nm
    '            frmKreditREC.ShowDialog()

    '        End If


    '    End If

    'End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub
End Class