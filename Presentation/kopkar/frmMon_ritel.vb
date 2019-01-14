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

Public Class frmMon_ritel
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

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
        LoadStruktur()
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
    Public Sub edit_click()

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- s
        LoadStruktur()
    End Sub

    Public Sub cetak_click()
        GcINV_Ret.Refresh()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        'print_gc1(GcINV_Ret, "                   LAPORAN PEMBAYARAN BUNGA DEPOSITO    " & vbCrLf & _
        '        "                                                                                          Per Tanggal " & tglDari.EditValue & " s/d  " & tglsampai.EditValue & "    ")
        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()
        'PrintableComponentLink1.CreateDocument()
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
        Dim reportFooter2 As String = "  "
        Dim reportFooter3 As String = "(  " & namauser & "  )"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Total Bunga"
        Dim reportFooter8 As String = "Total Pokok"
        Dim reportFooter11 As String = "Total Debet"
        Dim reportFooter9 As String = GV_RLSKRD.Columns("JML_BUNGA").SummaryText
        Dim reportFooter10 As String = GV_RLSKRD.Columns("JML_POKOK").SummaryText
        Dim reportFooter12 As String = GV_RLSKRD.Columns("JML_PINJAMAN").SummaryText
        Dim reportFooter13 As String = ":"
        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 20)

        Dim rec2 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 50, 100, 10, 70)

        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 150, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 100, 300, 20)
        Dim rec6 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 150, 300, 20)
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
        e.Graph.DrawString(reportFooter2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
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
        'Dim reportHeader As String = "LAPORAN PEMBAYARAN BUNGA DEPOSITO"
        'Dim reportHeader1 As String = "Per Tanggal "
        If tglDari.EditValue = tglsampai.EditValue Then
            subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(tglsampai.EditValue, "d MMMM yyyy").ToString
        End If

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

    Public Sub delete_click()
        If MsgBox("Hapus Data ENTRY-an? Data entryan akan di batalkan dan di hapus?? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("_krd") Is Nothing Then
                For Each rw As DataRow In dSO.Tables("_krd").Select("gc_hapus='Y'")
                    rw.Delete()
                Next
            End If
            'If Not dSO1.Tables("_qc") Is Nothing Then
            '    For Each rw As DataRow In dSO1.Tables("_qc").Rows
            '        rw.Delete()
            '    Next
            'End If

            save_click(True)
            cancel_click()
            STATE = ""
        End If
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
        'If Not dSO.Tables("_dtl") Is Nothing Then dSO.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        
        Dim sql_user As String = "select *,0 as nomer,'T' as gc_hapus from retail where status_lunas='BELUM' and Last_Created_By='" & username & "'  "
        'Dim sql_adm As String = "select *,0 as nomer from retail where status_lunas='BELUM' and jenis='" & Lue_SetPjm.EditValue & "' "
        If kddep = "2" Or kddep = "3" Then
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql_user & " and " & sqltgl, sqlconn))
        Else
            Lue_SetPjm.Visible = True
            If Lue_SetPjm.EditValue = "all" Then
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer,'T' as gc_hapus from retail where status_lunas='BELUM' and " & sqltgl, sqlconn))
            Else
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer,'T' as gc_hapus from retail where status_lunas='BELUM' and jenis='" & Lue_SetPjm.EditValue & "' and " & sqltgl, sqlconn))
            End If
        End If

        'Clipboard.SetText(sql & " where " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_tbh ", sqlconn))
        'DA2.Fill(dSO, "_dtl")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
            GcINV_Ret.DataSource = dSO.Tables("_krd")
            'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)
        End If


        'GcINV_Ret.DataSource = dSO.Tables("_krd")
        isinomer()
    End Sub
    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        If Not isDel Then
            If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
        Else
            simpan(isDel)
        End If
    End Sub
    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        'If STATE = "EDIT" Then
        If Not isDelete Then


            If STATE = "ADD" Then

            

                row = dSO.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If

            'row.Item("form_by") = Me.Name
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
        End If
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

    Private Sub frmMon_ritel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'LoadStruktur()
        Lue_SetPjm.Visible = False
        tglsampai.EditValue = Today
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RL_nama.DataSource = ds_cari.Tables("_lookup1")
        RL_nama.ValueMember = "nasabah_id"
        RL_nama.DisplayMember = "Nama"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT kode,Nama FROM m_jns_upload where tipe_trans='RTL' union ALL SELECT 'all' as kode,'SEMUA' as Nama", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"
        Lue_SetPjm.EditValue = "all"

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

    'Private Sub GV_RLSKRD_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_RLSKRD.DoubleClick
    '    If GV_RLSKRD.RowCount <> 0 Then
    '        'MsgBox("ini gv")
    '        'MsgBox("ini gv")
    '        pilih = GV_RLSKRD.GetRow(GV_RLSKRD.GetSelectedRows(0)).Item("no_trans").ToString()
    '        kd_krd = GV_RLSKRD.GetRow(GV_RLSKRD.GetSelectedRows(0)).Item("kd_kredit").ToString()
    '        'MsgBox(pilih & " dan " & kd_krd)
    '        'If kd_krd = "KRD" Then
    '        frm_ritel1.STATE = "EDIT"
    '        frm_ritel1._notrans = pilih
    '        frm_ritel1.ShowDialog()
    '        'ElseIf kd_krd = "CUS" Then
    '        '    frmKreditCustom.STATE = "EDIT"
    '        '    frmKreditCustom._notrans = pilih
    '        '    frmKreditCustom.ShowDialog()
    '        'ElseIf kd_krd = "MTS" Then
    '        '    frmKreditMTS.STATE = "EDIT"
    '        '    frmKreditMTS._notrans = pilih
    '        '    frmKreditMTS.ShowDialog()
    '        'ElseIf kd_krd = "REC" Then
    '        '    frmKreditREC.STATE = "EDIT"
    '        '    frmKreditREC._notrans = pilih
    '        '    frmKreditREC.ShowDialog()
    '        'End If


    '    End If
    'End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub

    Private Sub GV_RLSKRD_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_RLSKRD.CellValueChanged
        If e.Column Is gc_rptot Then
            'If GV_RLSKRD.GetRow(e.RowHandle).item("sisa_pokok") < GV_RLSKRD.GetRow(e.RowHandle).item("nilai") Then
            '    MsgBox("Tidak Boleh kosong")
            'End If
            GV_RLSKRD.GetRow(e.RowHandle).item("gc_rptot") = GV_RLSKRD.GetRow(e.RowHandle).item("JML_POKOK") + GV_RLSKRD.GetRow(e.RowHandle).item("JML_BUNGA")

        End If
        If e.Column Is JML_PINJAMAN Then
            GV_RLSKRD.GetRow(e.RowHandle).item("JML_POKOK") = GV_RLSKRD.GetRow(e.RowHandle).item("JML_PINJAMAN")
        End If
        If e.Column Is JML_POKOK Then
            GV_RLSKRD.GetRow(e.RowHandle).item("JML_PINJAMAN") = GV_RLSKRD.GetRow(e.RowHandle).item("JML_POKOK")
        End If
    End Sub
End Class