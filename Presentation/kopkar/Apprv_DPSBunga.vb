'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: KOPKAR group american pillow @2015                       =
'= Sebelum Coding Janhghghghghgan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils

Public Class Apprv_DPSBunga
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

        btnSave = True
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
        'If Not dSO1.Tables("_dtl") Is Nothing Then dSO1.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()

        Dim sqltgl As String = ""
       If tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then 'And LUE_Nama.EditValue = vbNullString 
            sqltgl = " TGL_TRANS > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then 'And LUE_Nama.EditValue = vbNullString 
            sqltgl = " TGL_TRANS < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then 'And LUE_Nama.EditValue = vbNullString 
            sqltgl = " TGL_TRANS between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then 'LUE_Nama.EditValue <> vbNullString
            sqltgl = " TGL_TRANS between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'OFF karena ga pake bulan tahun
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '    sqltgl = "blthn='" & lookupBulanAwal.EditValue & "'"
        End If



        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_trans,qc.no_ref,qcm.sj_supplier as no_sj,qc.kd_satuan,qc.kd_stok,qc.Last_Created_By,brg.Nama_Barang,brg.spek_brg,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,ISNULL(qc.hold,0) as hold,ISNULL(qc.hold_histroy,0) as hold_histroy,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok= brg.Kode_Barang where " & sqltgl & "", sqlconn))
        'Dim sql As String = "SELECT     qc.tgl_trans, qc.no_trans, qc.no_ref, qcm.sj_supplier AS no_sj, qc.kd_satuan, qc.kd_stok, qc.Last_Created_By, brg.Nama_Barang, brg.spek_brg,  " & _
        '               " qc.qty_datang, qc.qty_order, qc.qty_qc_pass, qc.qty_qc_unpass, ISNULL(qc.hold, 0) AS hold, ISNULL(qc.hold_histroy, 0) AS hold_histroy, qc.qty_sisa, qc.rp_trans, " & _
        '               " qcm.jml_rp_trans, 0 AS nomer, qc.keterangan, SIF.dbo.SIF_Supplier.Nama_Supplier " & _
        '              " FROM         SIF.dbo.SIF_Supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC_M AS qcm ON SIF.dbo.SIF_Supplier.Kode_Supplier = qcm.kd_supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC AS qc ON qcm.no_trans = qc.no_trans LEFT OUTER JOIN " & _
        '              " SIF.dbo.SIF_Barang AS brg ON qc.kd_stok = brg.Kode_Barang "
        Dim sql As String = "select *,0 as nomer from tabtrans where KODE_TRANS='08' and kabag_approve=0 "
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql & " and " & sqltgl, sqlconn))
        'Clipboard.SetText(sql & " and " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans ", sqlconn))
        'DA2.Fill(dSO, "_dtl")

        'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
        GcINV_Ret.DataSource = dSO.Tables("_krd")
        'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)

        'GcINV_Ret.DataSource = dSO.Tables("_krd")
        GV_AppBgDps.Columns("NASABAH_ID").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        isinomer()

    End Sub

    Public Sub cetak_click()
        GcINV_Ret.Refresh()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        print_gc1(GcINV_Ret, "                                                                    LAPORAN APPROVAL PEMBAYARAN BUNGA DEPOSITO    " & vbCrLf & _
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
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            row = dSO.Tables("_krd").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        '    row = dSO.Tables("_krd").NewRow

        '    'row.Item("no_trans") = id_anggota + jns + blthn()
        '    'MsgBox(id_anggota + jns + blthn())
        '    row.Item("Last_Create_Date") = getTanggal()
        '    row.Item("Last_Created_By") = username
        '    row.Item("cetak_ke") = 0
        '    'row.Item("blthn") = blthn()
        '    'row.Item("tgl_trans") = getTanggal()

        'ElseIf STATE = "EDIT" Then
        '    row = dSO.Tables("_krd").Rows(0)
        '    row.Item("Last_Update_Date") = getTanggal()
        '    row.Item("Last_Updated_By") = username
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

            'Dim sqlcmd1 As New SqlCommand("update anggota set Rec_stat=0,status_anggota='RESIGN', Keterangan='" & tx1_ket.Text & "',tgl_keluar=@nilai where nasabah_id='" & LUE_nama.EditValue & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", getTanggal(BTRANS))
            'Clipboard.SetText("update anggota set Rec_stat=0,Keterangan='" & tx1_ket.Text & "',tgl_keluar=@nilai where nasabah_id='" & LUE_nama.EditValue & "'")
            'sqlcmd1.ExecuteNonQuery()

            DA.Update(dSO.Tables("_krd"))
            'DA2.Update(dSO1.Tables("_trans"))

            ''STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub frmMonDPSBunga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        tglsampai.EditValue = Today
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        'DA_gdg2 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        'DA_gdg2.Fill(ds_gdg2, "_bilyet")
        'LUE_Nama.Properties.DataSource = ds_gdg2.Tables("_bilyet")
        'LUE_Nama.Properties.ValueMember = "nasabah_id"
        'LUE_Nama.Properties.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kd_status_agenda,keterangan from m_agenda", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        RL_stat.DataSource = ds_cari1.Tables("_lookup2")
        RL_stat.ValueMember = "kd_status_agenda"
        RL_stat.DisplayMember = "keterangan"
        LoadStruktur()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cetak_click()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'LUE_Nama.EditValue = vbNullString
        tglDari.EditValue = vbNullChar
        tglsampai.EditValue = Today
    End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            rw1.Item("kabag_approve") = 1
            'rw1.Item("STATUS_AKTIF") = "AKTIF"
        Next
    End Sub
End Class