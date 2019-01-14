'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmRlsKredit
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih, id_anggota, tgl_1_dbt, tgl_1_trans, tgl_dbt, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Public tgldbet As Integer
    Private bunga, tempo, nett, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, bg_bns, prv, adm, bg_jln As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation

    Public Sub cetak_click()
        MsgBox("Cetak Realisasi harap lewat Monitoring->Laporan Realisasi", MsgBoxStyle.Exclamation)
    End Sub
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
        dSO.Relations.Clear()
        If Not dSO.Tables("_dtl") Is Nothing Then dSO.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()


        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DATEPART(d, tgl_debet) as tgldbt,*,0 as nomer,rec_bbj as bbj_lama from kredit where stat_approve =4 and stat_kabagSP='SETUJU' and (stat_rls = 0 or stat_rls is null)", sqlconn)) '
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DATEPART(d, tgl_debet) as tgldbt,*,0 as nomer from kredit where stat_approve = 4 and stat_kabagSP='SETUJU' and (stat_rls = 0 or stat_rls is null)", sqlconn))
        DA2.Fill(dSO, "_dtl")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"))
            GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_detil)
        Else
            Exit Sub
        End If
        'hit_bunga_berjalan() 'UPDATE BUNGA BERJALAN TGL SKRG
        GcINV_Ret.DataSource = dSO.Tables("_krd")
        GV_RLSKRD.BestFitColumns()

    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then
        'notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
        For Each rw1 As DataRow In dSO.Tables("_krd").Select("stat_rls=1")
            'If rw1.RowState = DataRowState.Modified Then
            '    For Each rwY In dSO.Tables("_krd").Select("stat_rls=1")

            '    Next
            rw1.Item("tgl_rls") = dt_tgl.EditValue 'approve_rls_by
            rw1.Item("approve_rls_by") = "Outstanding" 'outstanding agar di aprove realisasi oleh kabag, lalu ke FIN
        Next
        'Else
        'For Each rw1 As DataRow In dSO.Tables("_hold").Rows

        '    If rw1.RowState = DataRowState.Modified Then
        '        rw1.Item("cetak_ke") = rw1("cetak_ke") + 1

        '    End If

        'Next


        'End If

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

            DA.Update(dSO.Tables("_krd"))
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            STATE = "EDIT"
            LoadStruktur()

        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub
   
    Private Sub frmRlsKredit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        dt_tgl.EditValue = Today
        GV_RLSKRD.FocusedColumn = GV_RLSKRD.Columns("stat_rls")
        'GV_RLSKRD.Columns("nasabah_id").Visible = False

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        isinomer()
    End Sub

    'Private Sub GV_RLSKRD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_RLSKRD.Click
    '    If Not dSO1.Tables("_hist") Is Nothing Then
    '        dSO1.Tables("_hist").Clear()
    '    End If
    '    DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from angsuran a inner join kredit k on a.no_kredit=k.no_trans " & _
    '                                                              "where a.nasabah_id= '" & GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") & "'", sqlconn))
    '    'MsgBox()
    '    DA2.Fill(dSO1, "_hist")
    '    GcHist.DataSource = dSO1.Tables("_hist")
    '    Gv_hist.BestFitColumns()
    '    'If GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") = "000017" Then
    '    '    T_skor.Text = "BURUK"
    '    'ElseIf GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") = "000130" Then
    '    '    T_skor.Text = "BAIK"
    '    'Else
    '    '    T_skor.Text = ""
    '    'End If
    'End Sub

    'Private Sub GcHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    milih = GV_RLSKRD.GetFocusedRowCellValue("nasabah_id")
    '    hist_pegawai.reload_table(milih)
    '    hist_pegawai.ShowDialog()
    '    'showMessages(milih)
    '    'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
    '    'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

    '    'da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") & "'", sqlconn))
    '    'da_cari.Fill(ds1, "_crpo")


    'End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            rw1.Item("stat_rls") = 1
        Next
    End Sub

    Public Sub hit_bunga_berjalan()
        Dim sisa, hr_ini, jml_hr, jm_hr_lalu, jm_hr_dbt, jm_hr_today, jm_hr_bln, jm_bl_lalu, jm_bl_skrg, jm_bl_dbt, tgl_uplod, blnx, bln_skrg, bln_dbt As Integer
        Dim tg_DBdbt, tg_DBtrn As String
        'tempo = tx1_LamaPJM.Text
        'bsr_pjm = TE_BsrPJM.EditValue
        'pokok_pertama = bsr_pjm
        For Each rw1 As DataRow In dSO.Tables("_krd").Select("rec_bbj > 0")
            tg_DBtrn = rw1.Item("tgl_trans")
            tg_DBdbt = rw1.Item("tgl_debet")
            tgldbet = rw1.Item("tgldbt")
            tgl_1_dbt = "01/" & Month(rw1.Item("tgl_debet")).ToString & "/" & Year(rw1.Item("tgl_debet")).ToString
            bsr_pjm = rw1.Item("JML_PINJAMAN")
            bunga = rw1.Item("bunga")


            'TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'tgl_uplod_lalu = "01/" & Month(dt_tgl.EditValue) & "/" & Year(dt_tgl.EditValue)
            Dim sqdr1 As SqlDataReader = New SqlCommand("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
                                                            " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tg_DBdbt & "',103)),0)))+1 as ke_blnDebt, " & _
                                                             " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tg_DBdbt & "',103) )+1 as jm_hr_dbt,  " & _
                                                           " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & tgl_1_trans & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) )+1 as jm_hr_today,  " & _
                                                            " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_bln, " & _
                                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
                                                            " day(convert(date,'" & dt_tgl.EditValue & "',103)) as hr_ini, " & _
                                                            "DAY(DATEADD(DD,-1,DATEADD(MM,DATEDIFF(MM,-1,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_dbt, " & _
                                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103))+1,0))) as jm_bl_skrg  ", sqlconn).ExecuteReader
            '##ini jml hr asli '" datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_today, " & _
            'blnx =DateDiff(DateInterval.Month,dt_tgl.EditValue,
            sqdr1.Read()
            If sqdr1.HasRows Then
                'tgl_uplod = sqdr1.Item("tgl")
                'blnx = sqdr1.Item("blnx")

                bln_skrg = sqdr1.Item("bln_skrg")
                bln_dbt = sqdr1.Item("ke_blnDebt")
                jm_hr_bln = sqdr1.Item("jm_hr_bln")
                jm_hr_dbt = sqdr1.Item("jm_hr_dbt")
                jm_hr_today = sqdr1.Item("jm_hr_today")
                jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
                jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
                jm_bl_dbt = sqdr1.Item("jm_bl_dbt")
                hr_ini = sqdr1.Item("hr_ini")
            End If
            sqdr1.Close()


            jml_hr = jm_bl_skrg - (hr_ini - 1)
            bg_bns = bsr_pjm * (bunga / 100)
            t_bunga = 0 'ga pake bunga

            'bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
            Dim hrdbt As Integer
            If bln_dbt = 0 Then
                hrdbt = jml_hr - hr_ini
                bg_jln = ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt
                'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_bln))
            ElseIf bln_dbt = 1 Then
                'bg_jln = (bg_bns * (bln_dbt)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr)
                bg_jln = (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * jm_hr_dbt + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr))
            ElseIf bln_dbt > 1 Then
                'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
                bg_jln = (bg_bns * (bln_dbt - 1)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * (jm_hr_dbt))
            End If

            rw1.Item("rec_bbj") = bg_jln
            'If tgldbet >= 25 Then
            '    rw1.Item("rec_bbj") = 0
            'End If
        Next
        'nett = bsr_pjm - bg_jln - prv - adm
        '##JUMLAH TERIMA
        'If cb_byr_kartu.Checked = True Then
        '    nett = 0
        'End If

        'lb_bg_jln.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        ''lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        ''lb1_bunga.Text = 0
        ''lb1_total_ang.Text = 0
        ''lb1_pokok.Text = 0
        'TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub dt_tgl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_tgl.EditValueChanged
        tgl_dbt = dt_tgl.EditValue
        tgl_1_trans = "01/" & Month(dt_tgl.EditValue).ToString & "/" & Year(dt_tgl.EditValue).ToString
        If GV_RLSKRD.RowCount > 1 Then
            hit_bunga_berjalan()
        End If

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If GV_RLSKRD.RowCount >= 1 Then
            hit_bunga_berjalan()
        End If
    End Sub
End Class