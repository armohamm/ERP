'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.Utils

Public Class frmKreditREC
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public _notrans As String = "xxx"
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, kd2, lb_adm, lb_prv, ntran_lama, id_anggota, jns, s_ang, notran_cek, nm_agt As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_byr_kartu, ds_cari3, ds_cari2, dso2, ds_cari, dsNama, ds_cari1, ds_gdg1, ds_gdg2, dsjab As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw_hist, rw_kartu As DataRow
    Private DA, DA1, DA2, da_byr_krt, DALOOKUP, daJab, daNama, DALOOKUP1, DA_gdg1, da_tbh As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private tgldbet As Integer
    Private bunga, pokok_akhir, ang_baru, pokok, pokok_asli, bsr_pjm, penalti, jml_rec, jml_rec_bunga, sisa_pk_lama, plafond, angs, denda, t_bunga, total, recov, tpot, pk_br, t_pk_br, r_bg_jln, prv, r_adm, adm_cek, adm, r_pen, r_jml_ut, nilai, prv_r, bg_lama, t_pot, pk_lama, pk_akhir, pot, pot_bns, pot_thr, pot_tat As Double
    Private nett, pokok_pertama, tempo, thn, angs_dua_rek As Integer
    Private BTRAN As SqlTransaction
    Public stat_tran, stat_rec, multi_rcv, stat_prv As Boolean
    Public idJab, ntran_cek, tgl_uplod_lalu, nxt_dbt, tgl_dbt, typ, tgl_bln_dbt As String
    Dim pathFoto, tgl_1_dbt, tgl_1_trans, subReport, subReport2 As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte




    Public Sub add_click()
        STATE = "ADD" '<-- set state add
        bt_hitung.Enabled = True
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        LUE_nama.Enabled = True
        setStatus()
        bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        'btCari.PerformClick()

        'GvBKE_d.Columns("no_seq").Visible = False

        'btCari_Click_1(Me, EventArgs.Empty)

    End Sub

    Private Sub bersihkan()
        lb1_total_ang1.Text = ""
        lb1_total_ang2.Text = ""
        tx_id.Text = ""
        lb1_bunga.Text = ""
        lb1_pokok.Text = ""
        lb1_recov.Text = ""
        'lb_sisaAngs.Text = ""
        LUE_nama.EditValue = ""
        lb1_total_ang.Text = ""
        lb1_jumlah.Text = ""
        TE_net.EditValue = vbNullString
        tx1_ket.Text = ""
        tx1_LamaPJM.Text = ""
        TE_prv.EditValue = vbNullString
        'lb1.Text = ""
        'tx1_asr.Text = ""
        TE_adm.EditValue = vbNullString
        TE_BsrPJM.EditValue = vbNullString
        'txr_adm.Text = ""
        lb_r_bunga.Text = ""
        lb_jmlrec.Text = ""
        te_pen.EditValue = vbNullString
        'txr_prvs.Text = ""
        lb_r_total.Text = ""
        TE_bns.EditValue = 0
        TE_thr.EditValue = 0
        TE_tat.EditValue = 0
        'ds_tbh.Clear()
        'dso2.Clear()
        If Not dso2.Tables("_agd") Is Nothing Then dso2.Tables("_agd").Clear()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_agd").Clear()

        'LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString

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
    'Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
    '    Dim hasil As String
    '    Dim sqlblth As SqlDataReader
    '    If btrans Is Nothing Then
    '        'blthn=082011
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
    '        '##blthn=201108
    '        'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
    '        sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
    '    Else
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
    '        'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
    '        sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
    '    End If
    '    sqlblth.Read()
    '    hasil = sqlblth.Item(0)
    '    'End If
    '    sqlblth.Close()
    '    Return hasil
    'End Function
    Public Sub cetak_click()
        If lb_notrans.Text <> "" Then
            callReport(App_Path() & "\report\komite.rpt", "", "n_trn=" & lb_notrans.Text, False, False)
        Else
            MsgBox("No Transaksi Kosong", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO1.Tables("_tbh") Is Nothing Then dSO1.Tables("_tbh").Clear()
        If STATE = "ADD" Then
            jml_rec = 0
        End If

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select JML_BUNGA+JML_POKOK as ang,isnull(foto_jaminan,'') as foto_jaminan, * from kredit where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as JML_PINJAMAN,0 as sisa_angs,* from kredit_pot where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_hist")
        GcHist.DataSource = dSO1.Tables("_hist")

        da_byr_krt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kartu where 1=2", sqlconn))
        da_byr_krt.Fill(ds_byr_kartu, "_kartu")
        Gc_kartu.DataSource = ds_byr_kartu.Tables("_kartu")
        'Dim sq_tgDbt As SqlDataReader = New SqlCommand("select last_debet from m_konfig", sqlconn).ExecuteReader
        'sq_tgDbt.Read()
        'If sq_tgDbt.HasRows Then
        '    de_debet.EditValue = sq_tgDbt.Item("last_debet")
        'End If
        'sq_tgDbt.Close()

        If dSO.Tables("_krd").Rows.Count > 0 Then
            Dim arr() As Byte
            Dim Pic As Object

            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)
            'Dim rw_nm = dsNama.Tables("_nm").Rows(0)
            '##milik form khusus recover
            id_anggota = rwm("nasabah_id").ToString
            ntran_lama = rwm("no_trans").ToString
            te_bg.EditValue = rwm("bunga").ToString
            LUE_nama.EditValue = rwm("nasabah_id").ToString
            LuE_Jab.EditValue = idJab
            typ = rwm("tipe").ToString
            tx_id.Text = rwm("nasabah_id").ToString
            tx1_LamaPJM.Text = rwm("LAMA_ANGS").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            lb1_pokok.Text = rwm("JML_POKOK").ToString
            lb1_bunga.Text = rwm("JML_BUNGA").ToString
            TE_adm.EditValue = rwm("JML_ADMIN").ToString
            TE_prv.EditValue = rwm("JML_PROVISI").ToString
            tx1_ket.Text = rwm("KETERANGAN").ToString
            'lb_nama.Text = rw_nm.Item("Nama")
            lb1_total_ang.Text = rwm("ang").ToString
            bunga = rwm("bunga").ToString
            txb_norek.Text = rwm("no_rek").ToString
            tx_norek_cair.Text = rwm("norek_cair").ToString
            'cb_tglbyr.Text = rwm("TGL_TAGIHAN").ToString

            r_bg_jln = IIf(rwm.IsNull("rec_bbj"), 0, rwm("rec_bbj").ToString)
            tx_jaminan.Text = IIf(rwm.IsNull("no_jaminan"), "", rwm("no_jaminan").ToString) 'row.Item("no_jaminan")
            Pic = rwm.Item("foto_jaminan")
            arr = rwm.Item("foto_jaminan")
            If arr.Length = 0 Then
                PictureBox2.Image = Presentation.My.Resources.note_view
            Else
                ' arr = row.Item("Foto")
                PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
                'PictureBox2.Image = Image.FromStream(ms)
            End If

            'If Not rwm.IsNull("stat_provisi") Then
            '    If (rwm("stat_provisi") = True) Then
            '        cb_prv.CheckState = CheckState.Checked
            '    Else
            '        cb_prv.CheckState = CheckState.Unchecked
            '    End If
            'End If
            pot_bns = IIf(rwm.IsNull("pot_bns"), 0, rwm("pot_bns").ToString) 'rwm.Item("pot_bns")
            pot_thr = IIf(rwm.IsNull("pot_thr"), 0, rwm("pot_thr").ToString) 'rwm.Item("pot_thr")
            pot_tat = IIf(rwm.IsNull("pot_tat"), 0, rwm("pot_tat").ToString) 'rwm.Item("pot_tat")

            lb_notrans.Text = rwm("no_trans").ToString
            pot = pot_bns + pot_thr + pot_tat
            t_pot = pot * (tx1_LamaPJM.Text / 12) 'lama bulan/12 = setehun/pertehun

            bunga = rwm("bunga")
            angs = rwm("ang")
            pokok_pertama = rwm("JML_POKOK")
            t_bunga = rwm("JML_BUNGA")
            r_adm = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            bsr_pjm = rwm("JML_PINJAMAN")
            pokok_asli = rwm("JML_POKOK")
            t_pk_br = IIf(rwm.IsNull("sisa_pokok_after_potong"), 0, rwm("sisa_pokok_after_potong").ToString)


            total = t_pot + t_pk_br

            lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_sisaAngs.Text = rwm("sisa_angs")
            If STATE = "EDIT" Then
                'sisa_pk_lama = IIf(rwm.IsNull("sisa_pokok_lama"), 0, rwm("sisa_pokok_lama").ToString) 'rwm("sisa_pokok_lama")
                TE_BsrPJM.EditValue = rwm("JML_PINJAMAN").ToString
                nett = rwm("JML_TERIMA").ToString
                r_adm = IIf(rwm.IsNull("rec_admin"), 0, rwm("rec_admin").ToString) 'rwm("rec_admin")
                'txr_adm.Text = r_adm
                'r_jml_ut = IIf(rwm.IsNull("rec_sisa_kredit"), 0te_bg, rwm("rec_sisa_kredit").ToString) 'rwm("rec_sisa_kredit")
                jml_rec = Gv_hist.Columns("nilai").SummaryItem.SummaryValue
                r_pen = IIf(rwm.IsNull("rec_penalty"), 0, rwm("rec_penalty").ToString) 'rwm("rec_penalty").ToString

                prv = IIf(rwm.IsNull("rec_provisi"), 0, rwm("rec_provisi").ToString) 'rwm("rec_provisi").ToString
                
                r_bg_jln = IIf(rwm.IsNull("rec_bbj"), 0, rwm("rec_bbj").ToString) 'rwm("rec_bbj").ToString
                lb_r_bunga.Text = r_bg_jln
                recov = r_adm + jml_rec + r_pen + prv + r_bg_jln
                lb1_adm2.Text = r_adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb1_prv2.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))
                'txr_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))
                te_pen.EditValue = r_pen
                lb_jmlrec.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb1_recov.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
                TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb_r_total.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
                'txr_jmlrec.Text = r_jml_ut.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb_r_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
            Else
                lb1_recov.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
                nett = (bsr_pjm) - (prv + r_adm) - (recov)
                '##JUMLAH TERIMA
                TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))

            End If
            lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            TE_adm.EditValue = r_adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
            TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'tampilan sebelah
            'lb_tpokok.Text = t_pk_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_tempo_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb_tempo.Text = tx1_LamaPJM.Text
            'lb_tempo2.Text = tx1_LamaPJM.Text
            'lb_tempo3.Text = tx1_LamaPJM.Text
            'lb_tp_bns.Text = tx1_LamaPJM.Text / 12

            'tx1_angs.Text = pokok
            'tx1_bunga.Text = bsr_pjm * bunga
            'tx1_t_angs.Text = t_bunga + pokok
            If STATE = "EDIT" Then
                'cek_recovery() '### utk recovery
                cek_hist()
                'cek_agenda()
                TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
            End If

            'jml_rec = Gv_hist.Columns("nilai").SummaryItem.SummaryValue
            'hitung_cicilan()
            Dim sqlnm As SqlDataReader = New SqlCommand("select Nama from anggota where nasabah_id= '" & id_anggota & "'", sqlconn).ExecuteReader
            sqlnm.Read()
            lb_nama.Text = sqlnm.Item(0)
            sqlnm.Close()

        End If

    End Sub
    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        'cek_notran()
        If STATE = "ADD" Then


            If Lue_SetPjm.EditValue = vbNullString Or TE_BsrPJM.EditValue = vbNullString Or tx1_LamaPJM.Text = "" Then
                MsgBox("Lengkapi data, banyak yang belum di isi/Kosong", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If Gv_hist.Columns("nilai").SummaryItem.SummaryValue = 0 Or jml_rec = 0 Then
                MsgBox("Harap mengisi Nilai Recovery SEBELAH KANAN !!! " & vbCrLf & "atau Data tidak lengkap,")
                Exit Sub
            End If
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)




    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data ENTRY-an? Data entryan akan di batalkan dan di hapus?? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("_krd") Is Nothing Then
                For Each rw As DataRow In dSO.Tables("_krd").Rows
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


    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        lb_notrans.Text = get_notran()
        Dim BTRANS As SqlTransaction
        For Each rh As DataRow In dSO1.Tables("_hist").Select("sisa_pokok = sisa")
            row.Delete()
        Next
        For Each rh As DataRow In dSO1.Tables("_hist").Rows
            rh.Item("no_trans") = lb_notrans.Text
        Next
        If Not isDelete Then
            If STATE = "ADD" Then
                row = dSO.Tables("_krd").NewRow

                row.Item("no_trans") = lb_notrans.Text
                row.Item("no_kredit") = ntran_lama
                'MsgBox(id_anggota + jns + blthn())
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("cetak_ke") = 0
                'row.Item("blthn") = blthn()

                lb_notrans.Text = get_notran()

            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Update_By") = username
            ElseIf STATE = "CETAK" Then
                row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If
            row.Item("tgl_trans") = dt_tgl.EditValue
            row.Item("kd_kredit") = "REC" '### TOP UP
            row.Item("NASABAH_ID") = tx_id.Text
            row.Item("jenis") = jns
            row.Item("tipe") = typ
            'row.Item("tipe") = Lue_tipe.EditValue
            row.Item("JML_PINJAMAN") = TE_BsrPJM.EditValue
            row.Item("JML_DENDA") = lb_denda.Text
            row.Item("JML_ADMIN") = lb_admin.Text
            row.Item("JML_POKOK") = pokok_pertama
            row.Item("JML_POKOK_TERAKHIR") = pokok
            row.Item("JML_BUNGA") = t_bunga
            row.Item("jml_angsuran") = pokok_pertama + t_bunga
            row.Item("rec_tgl_debt_lalu") = de_debet.EditValue
            row.Item("tgl_debet") = de_debet.EditValue
            'row.Item("JML_ASURANSI") = tx_asr.Text
            row.Item("JML_PROVISI") = prv
            row.Item("JML_TERIMA") = nett
            'row.Item("JML_DENDA") = tx1_LamaPJM.Text
            row.Item("TGL_PENGAJUAN") = getTanggal()
            row.Item("STATUS_AKTIF") = 0
            row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
            row.Item("sisa_angs") = tx1_LamaPJM.Text
            row.Item("TGL_TAGIHAN") = "25"
            row.Item("status_lunas") = "BELUM"
            row.Item("bunga") = bunga
            row.Item("sisa_pokok_after_potong") = t_pk_br
            row.Item("sisa_pokok") = bsr_pjm
            row.Item("sisa_pokok_lama") = 0 'sisa_pokok_lama
            row.Item("approve1_by") = "OutStanding"
            row.Item("approve2_by") = "OutStanding"
            row.Item("approve3_by") = "OutStanding"
            row.Item("approve4_by") = "OutStanding"
            row.Item("stat_approve") = 0
            row.Item("stat_cair") = 0
            row.Item("KETERANGAN") = tx1_ket.Text
            row.Item("stat_kabagSP") = "Outstanding"
            row.Item("no_rek") = txb_norek.Text
            row.Item("no_rek2") = te_rek2.EditValue
            'row.Item("nama_bank") = txb_bank.Text 'rec_lunas
            row.Item("rec_lunas") = 1
            row.Item("pot_bns") = TE_bns.EditValue
            row.Item("pot_thr") = TE_thr.EditValue
            row.Item("pot_tat") = TE_tat.EditValue
            row.Item("stat_pot_bns") = 0
            row.Item("stat_pot_thr") = 0
            row.Item("stat_pot_tat") = 0
            row.Item("no_jaminan") = tx_jaminan.Text
            row.Item("foto_jaminan") = foto
            row.Item("norek_cair") = tx_norek_cair.Text
            row.Item("no_ref") = txb_noform.Text

            row.Item("rec_jumlah") = jml_rec
            row.Item("rec_penalty") = r_pen
            row.Item("rec_provisi") = prv
            row.Item("rec_admin") = r_adm
            row.Item("rec_bbj") = r_bg_jln


            If STATE = "ADD" Then
                dSO.Tables("_krd").Rows.Add(row)
            End If

            'For Each row1 As DataRow In ds_tbh.Tables("_tbh").Rows
            '    row1.Item("no_trans") = row.Item("no_trans")
            '    row1.Item("tgl_trans") = dt_tgl.EditValue
            '    row1.Item("create_date") = getTanggal()
            '    row1.Item("create_by") = username
            'Next
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("_krd"))
            DA2.Update(dSO1.Tables("_hist"))
            ''--##Lunas diakui saat uda di posting
            'For Each rw_hist As DataRow In dSO1.Tables("_hist").Select("nilai>0")
            '    'If rw_hist("rec_lunas") = 1 Then
            '    Dim sqlcmd As New SqlCommand("update kredit set no_ref='" & row.Item("no_trans") & "' , sisa_pokok=@nilai,KETERANGAN='Recovery',Last_Update=GETDATE() where no_trans='" & rw_hist.Item("no_trans") & "' ", sqlconn, BTRANS) '
            '    sqlcmd.Parameters.AddWithValue("@nilai", rw_hist.Item("sisa"))
            '    Clipboard.SetText("update kredit set no_ref='" & row.Item("no_trans") & "' , sisa_pokok=@nilai,KETERANGAN='Recovery',Last_Update=GETDATE() where no_trans='" & rw_hist.Item("no_trans") & "'")
            '    'sqlcmd.Parameters.AddWithValue("@ket", row.Item("keterangan"))
            '    sqlcmd.ExecuteNonQuery()
            '    'End If

            'Next





            BTRANS.Commit()

            If STATE = "DELETE" Then
                showMessages("Data Entry dihapus..")
            Else
                showMessages("Berhasil disimpan")
            End If
            STATE = "EDIT"
            btnSave = False
            setStatus()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub
    Public Sub cancel_click()
        'LoadStruktur("XXX")
        'Lue_SetPjm.EditValue = vbNullString
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
        LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString
    End Sub

    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select k.nasabah_id,k.no_trans,k.tgl_trans,a.Nama,k.jenis,k.JML_PINJAMAN,k.LAMA_ANGS,k.JML_ADMIN,k.JML_PROVISI,k.rec_penalty as penalti,k.stat_kabagSP,k.stat_approve,k.stat_cair,a.job_id from kredit k left join anggota a on k.nasabah_id=a.nasabah_id  where k.stat_approve < 5 and k.kd_kredit='REC' and k.Last_Created_By='" & username & "' order by k.tgl_trans desc", sqlconn))
        If Not ds_cari2.Tables("lookup_") Is Nothing Then ds_cari2.Tables("lookup_").Clear()
        DA2.Fill(ds_cari2, "lookup_")
        frmCari.set_dso(ds_cari2.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        LUE_nama.Enabled = False
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            idJab = frmCari.row.Item("job_id").ToString
            lb_nama.Text = frmCari.row.Item("Nama").ToString
            LoadStruktur(frmCari.row(1))
            btnSave = True
            btnCancel = True
            btnDelete = True
            bt_hitung.Enabled = False
            setStatus()
        Else
            'cancel_click()
            add_click()
            btnSave = False
            'LookupPO.Enabled = False
            STATE = ""
        End If

    End Sub

    Public Sub Cari()
        'bersihkan()
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id as NIP,a.Nama as [Nama],t.no_trans,t.tgl_trans as TGL_PINJAM,t.JML_PINJAMAN,t.sisa_angs,t.status_lunas,t.jenis,a.job_id,isnull(a.Almt_asal,'')as Almt_asal ,ISNULL(k.nama_kota,'') as nama_kota,ISNULL(t.no_rek,a.REKBCA1) as no_rek,* from kredit t left JOIN anggota a on t.nasabah_id=a.nasabah_id left join kota k on a.kode_kota=k.kode_kota where t.stat_cair=1 and t.stat_approve>=5 and t.status_lunas='BELUM' and a.nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) 'and jenis in ('NOR','NON') 
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        If ds_gdg1.Tables("lookup_Pegawai").Rows.Count = 0 Then
            MsgBox("NIP tidak mempunyai hutang yg di recoovery")
            Exit Sub
        End If
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not row Is Nothing Then
            lb_nama.Text = row("Nama")
            nm_agt = row("Nama")
            LUE_nama.EditValue = row("nasabah_id")
            tx_id.Text = row("nasabah_id")
            LuE_Jab.EditValue = row("job_id")
            lb_alamat.Text = row("Almt_asal")
            lb_kota.Text = row("nama_kota")
            id_anggota = row("nasabah_id")
            'jns = row("jenis")
            'Lue_SetPjm.EditValue = jns
            ntran_lama = row("no_trans")
            'sisa_pk_lama = row("sisa_pokok")
            'lb_sisaAngs.Text = row("sisa_angs")
            'lb1_sisa_pk_lama.Text = sisa_pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'LoadStruktur(frmCari.row("no_trans"))
            'cb_tglbyr.Text = "25"
            bunga = row("bunga")
            te_bg.EditValue = bunga
            Lue_tipe.EditValue = "F"
            txb_norek.Text = row("no_rek")
            tx_norek_cair.Text = row("no_rek")
            'txb_bank.Text = "BCA"
            te_rek2.EditValue = IIf(row.IsNull("no_rek2"), 0, row("no_rek2").ToString) 'row("REKBCA2") row("no_rek2")
            'txb_bank.Text = "BCA"

            Dim i As Integer
            Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
            plafond = dr(i).Item("nilai")
            lb_plafon.Text = dr(i).Item("nilai")

            lb_bunga.Text = dr(i).Item("Bunga_KSP")
            lb_admin.Text = dr(i).Item("Adm")
            lb_prvs.Text = dr(i).Item("provisi")
            lb_denda.Text = dr(i).Item("Denda")
            TE_adm.EditValue = dr(i).Item("Adm")
            TE_prv.EditValue = dr(i).Item("provisi")
            lb1_bunga.Text = dr(i).Item("Bunga_KSP")

            'cb_tglbyr.Text = 25
            jns = dr(i).Item("kode")
            kd2 = Lue_SetPjm.EditValue
            lb_adm = dr(i).Item("Adm")
            lb_prv = dr(i).Item("provisi")
            'If adm = 0 Then
            '    'MsgBox("adm 0")
            '    cb_adm.Checked = False
            'Else
            '    cb_adm.Checked = True
            'End If
            

        End If
    End Sub
    Public Sub hitung_recovery()
        If tx1_LamaPJM.Text = "" Or TE_BsrPJM.EditValue = vbNullString Then
            Exit Sub
        End If
        t_pot = pot * (tx1_LamaPJM.Text / 12) 'lama bulan/12 = setehun/pertehun, jika ada potongan

        tempo = tx1_LamaPJM.Text
        bsr_pjm = TE_BsrPJM.EditValue
        pokok_pertama = Math.Floor(bsr_pjm / tempo)
        pokok = bsr_pjm - (pokok_pertama * (tempo - 1))
        total = t_bunga + bsr_pjm
        t_bunga = bsr_pjm * (bunga / 100)

        'If txb_norek2.Text = 0 Or txb_norek2.Text = "" Then
        '    angs = t_bunga + pokok_pertama
        'Else
        '    angs = t_bunga + pokok_pertama
        '    angs_dua_rek = angs / 2 'dibagi dua rekening

        'End If
        angs = t_bunga + pokok_pertama
        t_pk_br = bsr_pjm - t_pot
        thn = tempo / 12
        lb_tempo2.Text = thn
        lb_total2.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_total_ang1.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'tx1_angs.Text = pokok
        'tx1_bunga.Text = bsr_pjm * bunga
        'tx1_t_angs.Text = t_bunga + pokok

        cek_recovery()
        lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        nett = bsr_pjm - recov - r_adm - t_pot 'cari nett
        If stat_prv = True Then
            prv = nett * (1 / 100) '1% dr nett
        End If
        nett = bsr_pjm - recov - r_adm - t_pot - prv ' dikurangilg ama prv

        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub cek_recovery()
        'If jml_rec = 0 And r_jml_ut = 0 Then
        '    MsgBox("Belum Memilih Centang Yang akan di Recovery", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        t_pot = pot * (tx1_LamaPJM.Text / 12) 'lama bulan/12 = setehun/pertehun
        tempo = tx1_LamaPJM.Text
        thn = tempo / 12
        lb_tempo2.Text = thn
        bsr_pjm = TE_BsrPJM.EditValue
        pokok_pertama = Math.Floor(bsr_pjm / tempo)
        pokok = bsr_pjm - (pokok_pertama * (tempo - 1))
        t_bunga = bsr_pjm * (bunga / 100)
        pk_br = bsr_pjm - t_pot

        pokok_pertama = Math.Floor(pk_br / tempo)
        pokok_akhir = pk_br - (pokok_pertama * (tempo - 1))
        t_pk_br = (pokok_pertama * (tempo - 1)) + pokok_akhir

        If te_rek2.EditValue = vbNullString Or te_rek2.EditValue = 0 Then
            ang_baru = pokok_pertama + t_bunga
            angs_dua_rek = 0
        Else
            ang_baru = t_bunga + pokok_pertama
            angs_dua_rek = ang_baru / 2 'dibagi dua rekening
            'ang_baru = angs_dua_rek
        End If

        total = t_pot + t_pk_br


        Dim sqlcek As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and stat_cair=1 and status_lunas='BELUM' and jenis <> 'BNS '", sqlconn).ExecuteReader
        sqlcek.Read()
        If sqlcek.HasRows Then
            stat_rec = True

            'Dim  As Decimal
            Dim sisa, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, jm_bl_dbt, jm_hr_dbt, tgl_uplod, blnx, bln_skrg, bln_dbt, jm_hr_bln, hr_ini As Integer
            'Dim tgl_uplod, blnx, bln_skrg As String

            'Dim sqdr1 As SqlDataReader = New SqlCommand("select 25 as tgl,MONTH(getdate())-1 as blnx , month(GETDATE()) as bln_skrg, " & _
            '                                            " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
            '                                            " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
            '                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
            '                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg " & _
            '                                            " from export_log ", sqlconn).ExecuteReader

            Dim sqdr1 As SqlDataReader = New SqlCommand("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
                  " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tgl_dbt & "',103)),0)))+1 as ke_blnDebt, " & _
                  " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tgl_dbt & "',103) ) as jm_hr_dbt,  " & _
                  " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & tgl_1_trans & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) )+1 as jm_hr_today,  " & _
                  " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_bln, " & _
                  " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
                  " day(convert(date,'" & dt_tgl.EditValue & "',103)) as hr_ini, " & _
                  "DAY(DATEADD(DD,-1,DATEADD(MM,DATEDIFF(MM,-1,convert(date,'" & de_debet.EditValue & "',103)),0))) as jm_bl_dbt, " & _
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
                jm_hr_today = sqdr1.Item("jm_hr_today")
                jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
                jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
                jm_bl_dbt = sqdr1.Item("jm_bl_dbt")
                jm_hr_dbt = sqdr1.Item("jm_hr_dbt")
                hr_ini = sqdr1.Item("hr_ini")
            End If
            sqdr1.Close()


            jml_hr = jm_bl_skrg - (hr_ini - 1)
            bg_lama = bsr_pjm * (bunga / 100)
            't_bunga = 0 'ga pake bunga
            Dim hrdbt As Integer
            'bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
            If bln_dbt = 0 Then
                hrdbt = jml_hr - hr_ini
                r_bg_jln = ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt
                'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_bln))
            ElseIf bln_dbt = 1 Then
                r_bg_jln = (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jm_hr_dbt)
                '(bg_lama * (bln_dbt)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr)
            ElseIf bln_dbt > 1 Then
                'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
                r_bg_jln = (bg_lama * (bln_dbt - 1)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * (jm_hr_dbt + 1))
            End If
            If tgldbet >= 25 Then
                r_bg_jln = 0
            End If
            nett = bsr_pjm - r_bg_jln - prv - adm

            ''bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
            'If bln_dbt = 0 Then
            '    r_bg_jln = (bg_lama * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
            '    txr_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'ElseIf bln_dbt >= 0 Then
            '    'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
            '    r_bg_jln = (bg_lama * (bln_dbt)) + ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * (jml_hr)
            '    txr_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'End If
            'Else '### JIKA YG DIRECOVERY LEBIH DARI 1, 2 KEATAS/MULTI
            'sisa_pk_lama = jml_rec
            r_jml_ut = jml_rec
            bg_lama = jml_rec_bunga
            'End If
            'txr_adm.Text = lb_admin.Text

            '## cek provisi non or NOR
            If cb_lock.Checked = False Then
                If jns = "NORM" Then
                    prv = (bsr_pjm - jml_rec) * (1 / 100)

                ElseIf jns = "DNOR" Then
                    If stat_prv = False Then
                        prv = 0
                    End If
                    prv = (bsr_pjm - plafond) * (1 / 100)

                End If
            End If

            'txr_prvs.Text = prv

            te_pen.EditValue = r_pen.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_jmlrec.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'If blnx <> bln_skrg Then
            '    r_bg_jln = (bg_lama * jm_hr_lalu / jm_bl_lalu) + (bg_lama * jm_hr_today / jm_bl_skrg)
            '    txr_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'Else
            '    r_bg_jln = 0
            '    txr_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'End If
            lb_total2.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            recov = r_bg_jln + jml_rec + r_pen
            lb_r_total.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_jmlrec.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
            te_pen.EditValue = r_pen
            lb_r_bunga.Text = r_bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        Else
            stat_rec = False
            'Exit Sub
        End If
        sqlcek.Close()
        lb1_recov.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_total_ang.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_total_ang1.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False)) 'hit awal defaul rek1, cek te_rek2
        lb1_total_ang2.Text = angs_dua_rek.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_adm.EditValue = r_adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))

        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_adm2.Text = r_adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_prv2.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        nett = bsr_pjm - (recov + adm + prv) ' - t_pot
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))

        buat_kartu()
    End Sub

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) from kredit where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = temp & (hasil)
        End If
        sqlDR.Close()
        Return hasil
    End Function


    Public Function get_notran() As String
        'stat_tran = True

        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = getKodeCabang() & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from kredit where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = getKodeCabang() & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = getKodeCabang() & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn() & "001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    'Public Sub cek_agenda()
    '    If Not dso2.Tables("_agd") Is Nothing Then dso2.Tables("_agd").Clear()
    '    'If Not dso2.Tables("_agd") Is Nothing Then
    '    '    dso2.Tables("_agd").Clear()
    '    'End If
    '    DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where nasabah_id= '" & id_anggota & "' and stat_approve < 5", sqlconn))
    '    DA1.Fill(dso2, "_agd")
    '    gc_agenda.DataSource = dso2.Tables("_agd")
    '    gv_agenda.BestFitColumns()


    'End Sub
    Public Sub cek_hist()
        If STATE = "ADD" Then


            If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
            'If Not dSO1.Tables("_hist") Is Nothing Then
            '    dSO1.Tables("_hist").Clear()
            'End If
            Dim sqdr As SqlDataReader = New SqlCommand("select 0 as gc_sisa,isnull(JML_POKOK_TERAKHIR,0) as JML_POKOK_TERAKHIR,0 as nilai,* from kredit where nasabah_id= '" & id_anggota & "' and status_lunas<>'LUNAS' and stat_approve > 4", sqlconn).ExecuteReader
            Dim x As Int16 = 1
            While sqdr.Read
                Dim rw1 As DataRow = dSO1.Tables("_hist").NewRow
                rw1.Item("no_seq") = x : x += 1
                rw1.Item("tgl_trans") = sqdr.Item("tgl_trans")
                rw1.Item("jenis") = sqdr.Item("jenis")
                rw1.Item("kd_kredit") = sqdr.Item("kd_kredit")
                rw1.Item("no_trans") = sqdr.Item("no_trans")
                rw1.Item("JML_PINJAMAN") = sqdr.Item("JML_PINJAMAN")
                rw1.Item("sisa_angs") = sqdr.Item("sisa_angs")
                rw1.Item("sisa_pokok") = sqdr.Item("sisa_pokok")
                rw1.Item("nilai") = 0
                rw1.Item("sisa") = 0
                dSO1.Tables("_hist").Rows.Add(rw1)
            End While
            sqdr.Close()
            DA2.Fill(dSO1, "_hist")
            GcHist.DataSource = dSO1.Tables("_hist")
            'Gv_hist.BestFitColumns()

            '        Dim sqr2 As SqlDataReader = New SqlCommand("select 0 as gc_sisa,nasabah_id,no_trans,keterangan as jenis,create_date as tgl_trans,rupiah as Angsuran, " & _
            '"1 as LAMA_ANGS,1 as sisa_angs,rupiah as JML_PINJAMAN,rupiah sisa_pokok,* from gagaldebet where nasabah_id= '" & LUE_nama.EditValue & "' and lunas=0", sqlconn).ExecuteReader
            '        While sqr2.Read
            '            Dim rw1 As DataRow = dSO1.Tables("_hist").NewRow
            '            rw1.Item("no_seq") = x : x += 1
            '            rw1.Item("tgl_trans") = sqr2.Item("tgl_trans")
            '            rw1.Item("jenis") = sqr2.Item("jenis")
            '            rw1.Item("kd_kredit") = sqr2.Item("kode")
            '            rw1.Item("no_trans") = sqr2.Item("no_trans")
            '            rw1.Item("JML_PINJAMAN") = sqr2.Item("JML_PINJAMAN")
            '            rw1.Item("sisa_angs") = sqr2.Item("sisa_angs")
            '            rw1.Item("sisa_pokok") = sqr2.Item("sisa_pokok")
            '            rw1.Item("nilai") = 0
            '            rw1.Item("sisa") = 0
            '            dSO1.Tables("_hist").Rows.Add(rw1)
            '        End While
            '        sqdr.Close()
            DA2.Fill(dSO1, "_hist")
        End If
    End Sub

    Public Sub cek_tgl_default_debet()
        Dim sql_lalu As SqlDataReader = New SqlCommand("SELECT '25',MONTH(GETDATE()),YEAR(GETDATE()),MONTH(GETDATE())+1 as nxt", sqlconn).ExecuteReader
        While sql_lalu.Read
            Dim tgx, bnx, blnxt, thx As String
            tgx = sql_lalu.Item(0)
            bnx = sql_lalu.Item(1)
            thx = sql_lalu.Item(2)
            blnxt = sql_lalu.Item(3)
            If bnx = 1 Then
                bnx = 1
            Else
                bnx = bnx - 1
            End If
            tgl_uplod_lalu = tgx & "/" & bnx & "/" & thx
            tgl_dbt = tgx & "/" & blnxt & "/" & thx
            de_debet.EditValue = tgl_dbt
            'MsgBox(tgl_uplod_lalu)
        End While

    End Sub

    Private Sub frmKreditREC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connect()
        prn = getParent(Me)
        LoadStruktur(_notrans)

        dt_tgl.EditValue = Today
        cek_tgl_default_debet()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='KRD' and kd2 in ('01','02')", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"


        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "Looktipe")
        Lue_tipe.Properties.DataSource = ds_gdg1.Tables("Looktipe")
        Lue_tipe.Properties.DisplayMember = "nama"
        Lue_tipe.Properties.ValueMember = "tipe"

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT Nama,kode FROM m_jns_upload where kode in('THR','TAT','BNS')", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_jns_tbh")
        'RL_jns_tbh.DataSource = ds_cari1.Tables("_jns_tbh")
        'RL_jns_tbh.DisplayMember = "Nama"
        'RL_jns_tbh.ValueMember = "kode"

        daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select job_id,job_nama from m_jabatan", sqlconn))
        daJab.Fill(dsjab, "View_Jabatan")
        LuE_Jab.Properties.DataSource = dsjab.Tables("View_Jabatan")
        LuE_Jab.Properties.ValueMember = "job_id"
        LuE_Jab.Properties.DisplayMember = "job_nama"

        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota where Rec_Stat=1", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"

        Lue_tipe.EditValue = "F"

        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'cb_byr.Text = "ANGSURAN"
        'Lue_SetPjm.Enabled = False
        'Lue_tipe.Enabled = False
        cb_lock.Checked = False

    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Lue_SetPjm.EditValue = vbNullString Then
                MsgBox("Pilih dululah jenis pengajuan!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Cari()
            cek_hist()
            'cek_agenda()
            TE_BsrPJM.Focus()

        End If
    End Sub

    Private Sub btCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Lue_SetPjm.EditValue = vbNullString Then
        '    MsgBox("Jenis Pinjaman belum di pilih, silahkan pilih dahulu")
        '    Exit Sub
        'End If
        Cari()
        cek_hist()
        'cek_agenda()
        'cek_notran()
        TE_BsrPJM.Focus()
    End Sub

    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then

                cek_recovery()


            End If
            'Gv_hist.FocusedRowHandle = 7
            'Gv_hist.FocusedColumn = Gv_hist.VisibleColumns(7)
            'Gv_hist.ShowEditor()
            tx_norek_cair.Focus()
        End If

    End Sub



    'Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
    '    If STATE = "ADD" Then
    '        Dim i As Integer
    '        'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
    '        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
    '        lb_plafon.Text = dr(i).Item("nilai")

    '        lb_bunga.Text = dr(i).Item("Bunga_KSP")
    '        lb_admin.Text = dr(i).Item("adm")
    '        adm = dr(i).Item("adm")
    '        'tx_asr.Text = dr(i).Item("Asuransi")
    '        lb_prvs.Text = dr(i).Item("provisi")
    '        lb_denda.Text = dr(i).Item("Denda")
    '        'lb1_adm.Text = dr(i).Item("Adm")
    '        lb1_adm.Text = dr(i).Item("Adm")
    '        'tx1_prvs.Text = dr(i).Item("provisi")
    '        lb1_prvs.Text = dr(i).Item("provisi")
    '        'tx1_asr.Text = dr(i).Item("Asuransi")
    '        'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
    '        lb1_bunga.Text = dr(i).Item("Bunga_KSP")
    '        bunga = lb1_bunga.Text / 100
    '        cb_tglbyr.Text = 25
    '        prv = lb_prvs.Text
    '        jns = dr(i).Item("kodetrans")
    '        kd2 = Lue_SetPjm.EditValue
    '    End If
    'End Sub

    'Private Sub gv_tambahan_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    'End Sub

    Private Sub TE_BsrPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_BsrPJM.KeyDown

        If e.KeyCode = Keys.Enter Then
            bsr_pjm = TE_BsrPJM.EditValue

            If bsr_pjm <= plafond Then
                stat_prv = False
                prv = 0
                TE_prv.EditValue = prv
            Else
                Lue_SetPjm.EditValue = "DNOR"
                'plafond()
                stat_prv = True
                '    'MsgBox("PRV =0")
                '    cb_prv.Checked = False
                'Else
                '    cb_prv.Checked = True

            End If

            tx1_LamaPJM.Focus()
        End If



    End Sub

    Private Sub TE_BsrPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_BsrPJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tx1_LamaPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx1_LamaPJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
            'hitung_recovery()
            cek_recovery()
        End If

    End Sub

    'Private Sub gv_tambahan_InitNewRow1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    'End Sub

    'Private Sub gv_tambahan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Delete Then
    '        If MsgBox("Delete Selected Row ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            'For Each dr As DataRow In ds_tbh.Tables("_tbh").Rows
    '            '    dr.Delete()
    '            'Next
    '            gv_tambahan.DeleteSelectedRows()

    '        End If
    '    End If
    'End Sub


    'Private Sub cb_prv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And STATE = "ADD" Then


    '        If cb_prv.Checked = True Then
    '            If jns = "NON " Then
    '                prv = (bsr_pjm - jml_rec) * (1 / 100)

    '            ElseIf jns = "NOR " Then
    '                prv = (bsr_pjm - plafond) * (1 / 100)
    '            End If

    '            TE_prv.EditValue = prv

    '            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
    '                cek_recovery()
    '            End If

    '        Else
    '            TE_prv.EditValue = 0
    '            prv = 0
    '            prv = 0
    '            nett = (bsr_pjm) - (prv + r_adm) - (recov)
    '            TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        End If

    '    End If
    '    'bsr_pjm = TE_BsrPJM.EditValue
    '    'nett = bsr_pjm - (prv + adm_cek)
    '    ''##JUMLAH TERIMA
    '    lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    'End If
    'End Sub

    'Private Sub cb_adm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And STATE = "ADD" Then


    '        If cb_adm.Checked = True Then
    '            'adm = bsr_pjm * (1 / 100)
    '            adm_cek = adm
    '            lb1_adm.Text = adm_cek

    '            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
    '                cek_recovery()
    '            End If

    '        Else
    '            lb1_adm.Text = 0
    '            adm_cek = 0
    '        End If
    '        'If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
    '        '   hitung_recovery()
    '        'Else
    '        ' End If
    '    End If
    'End Sub

    Private Sub tx1_ket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_ket.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_noform.Focus()
        End If
    End Sub

    Private Sub txb_norek_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_norek.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_rek2.Focus()
        End If
    End Sub

    Private Sub txr_total_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'recov=txr
            nett = bsr_pjm - (recov + adm) ' - t_pot
        End If
    End Sub

    Private Sub de_debet_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles de_debet.EditValueChanged
        tgl_uplod_lalu = "25/" & Month(de_debet.EditValue).ToString & "/" & Year(de_debet.EditValue).ToString
        tgl_dbt = de_debet.EditValue
      
        tgl_1_dbt = "01/" & Month(de_debet.EditValue).ToString & "/" & Year(de_debet.EditValue).ToString
    End Sub

    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()

        If STATE = "ADD" Then
            'If Lue_SetPjm.EditValue = "TAT " Or Lue_SetPjm.EditValue = "THR " Or Lue_SetPjm.EditValue = "BNS " Then
            '    taunan = True
            '    gc_tambahan.Enabled = False
            '    jns_krd = "BNS"
            'ElseIf Lue_SetPjm.EditValue = "KHU " Then '4 char
            '    jns_krd = "KHU"
            'Else
            '    taunan = False
            '    gc_tambahan.Enabled = True
            '    jns_krd = "KRD"
            'End If
            Dim i As Integer

            'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
            Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
            'MsgBox(dr(i))

            lb_plafon.Text = dr(i).Item("nilai")

            bunga = dr(i).Item("Bunga_KSP")
            lb_bunga.Text = bunga
            te_bg.EditValue = bunga
            lb_admin.Text = dr(i).Item("Adm")
            r_adm = dr(i).Item("Adm")
            penalti = dr(i).Item("penalty")
            lb_prvs.Text = dr(i).Item("provisi")
            lb_denda.Text = dr(i).Item("Denda")
            'lb1_adm.Text = dr(i).Item("Adm")
            lb_admin.Text = dr(i).Item("Adm")
            'tx1_prvs.Text = dr(i).Item("provisi")
            lb_prvs.Text = dr(i).Item("provisi")
            'tx1_asr.Text = dr(i).Item("Asuransi")
            'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
            'lb1_bunga.Text = dr(i).Item("Bunga_KSP")

            'cb_tglbyr.Text = 25
            jns = dr(i).Item("kode")
            kd2 = Lue_SetPjm.EditValue
            lb_adm = dr(i).Item("Adm")
            lb_prv = dr(i).Item("provisi")
            'If adm = 0 Then
            '    'MsgBox("adm 0")
            '    cb_adm.Checked = False
            'Else
            '    cb_adm.Checked = True
            'End If
            'If prv = 0 Then
            '    'MsgBox("PRV =0")
            '    cb_prv.Checked = False
            'Else
            '    cb_prv.Checked = True

            'End If

            'If taunan = False Then
            '    bunga = lb1_bunga.Text

            'Else
            '    bunga = 0
            '    tx1_LamaPJM.Text = 1 'langsung lunas setahun/taunan bonus,thr,tat
            'End If

        End If
        LUE_nama.Focus()
    End Sub

    Private Sub Gv_hist_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gv_hist.CellValueChanged
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then


            If e.Column Is gc_nilai Then
                If Gv_hist.GetRow(e.RowHandle).item("sisa_pokok") < Gv_hist.GetRow(e.RowHandle).item("nilai") Then
                    MsgBox("Recovery melebihi sisa Pokok outstanding", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    Gv_hist.GetRow(e.RowHandle).item("sisa") = Gv_hist.GetRow(e.RowHandle).item("sisa_pokok") - Gv_hist.GetRow(e.RowHandle).item("nilai")
                    jml_rec = 0
                    For Each rw_hist In dSO1.Tables("_hist").Select("nilai>0")
                        jml_rec += rw_hist.Item("nilai")
                    Next
                    jml_rec_bunga = jml_rec * (bunga / 100)
                    r_pen = jml_rec * (penalti / 100)
                    recov = r_bg_jln + jml_rec + prv + r_adm + r_pen
                    lb_r_total.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
                    lb1_recov.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
                    lb_jmlrec.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))

                    cek_recovery()
                    'hitung_recovery()
                    'lb1_sisa_pk_lama.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
                    'txr_jmlHut.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
                    'lb_sisaAngs.Text = s_ang

                End If
            End If
        End If
    End Sub

    'Private Sub ce_lunas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ce_lunas.EditValueChanged

    '    'Gv_hist.PostEditor()
    '    'Gv_hist.UpdateTotalSummary()
    'End Sub

    Private Sub Gv_hist_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles Gv_hist.RowUpdated
        Dim jml_brs As Integer = 0
        If STATE = "ADD" Then

        End If
        jml_rec = 0
        jml_rec_bunga = 0
        s_ang = 0
        'Present += 1
        For Each rw_hist In dSO1.Tables("_hist").Select("nilai>0")
            'If rw_hist("rec_lunas") = 1 Then
            jml_rec += rw_hist.Item("nilai")
            'jml_rec_bunga += rw_hist.Item("JML_BUNGA")
            's_ang += rw_hist.Item("sisa_angs")
            'jml_brs += 1
            'MsgBox(row.Item("no_trans"))
            'End If
        Next
        jml_rec_bunga = jml_rec * (bunga / 100)
        r_pen = jml_rec * (penalti / 100)
        'If jml_brs >= 2 Then
        '    multi_rcv = True
        'Else
        '    multi_rcv = False
        'End Ifdsd
        'jml_rec = Gv_hist.Columns("nilai").SummaryItem.SummaryValue
        'MsgBox(jml_rec)
        recov = r_bg_jln + jml_rec + prv + r_adm + r_pen
        lb_r_total.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_recov.Text = recov.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_jmlrec.Text = jml_rec.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_sisaAngs.Text = s_ang

    End Sub


    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        Try
            OpenFileDialog1.Filter = "jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|gif (*.gif)|*.gif"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                pathFoto = OpenFileDialog1.FileName
                PictureBox2.ImageLocation = pathFoto

                Dim tmpFoto As Image = Image.FromFile(pathFoto)
                Dim asalFoto As New Bitmap(tmpFoto)

                Dim tinggi As Integer = (180 / asalFoto.Width) * asalFoto.Height
                Dim hasilFoto As New Bitmap(180, tinggi)

                Dim gbr As Graphics = Graphics.FromImage(hasilFoto)
                gbr.DrawImage(asalFoto, 0, 0, hasilFoto.Width + 1, hasilFoto.Height + 1)

                'gbrFoto = Image.FromFile(pathFoto)
                gbrFoto = hasilFoto

                'Image to byte[]     
                fotoMemoryStream = New IO.MemoryStream()
                foto = Nothing
                gbrFoto.Save(fotoMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                foto = fotoMemoryStream.GetBuffer()

                'Byte[] to image     
                fotoMemoryStream = New IO.MemoryStream(foto)
                gbrFoto = System.Drawing.Image.FromStream(fotoMemoryStream)

                'frame.Image = gbrFoto
            End If
        Catch ex As Exception
            'frame.Image = frame.InitialImage
        End Try

    End Sub

    Private Sub TE_bns_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_bns.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                cek_recovery()

            End If
            TE_thr.Focus()
        End If
    End Sub

    Private Sub TE_thr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_thr.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                cek_recovery()
            End If
            TE_tat.Focus()
        End If
    End Sub

    Private Sub TE_tat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_tat.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                cek_recovery()

            End If
            save_click(False)
        End If
    End Sub

    
    Private Sub te_bg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles te_bg.EditValueChanged
        bunga = te_bg.EditValue
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString And Lue_SetPjm.EditValue <> vbNullString Then
            'hitung_recovery()
            cek_recovery()
        End If
    End Sub

    Private Sub txb_norek2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub te_rek2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_rek2.KeyDown
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString And Lue_SetPjm.EditValue <> vbNullString Then
            If e.KeyCode = Keys.Enter Then
                'If te_rek2.EditValue = vbNullString Then
                '    MsgBox("koosng")
                'End If
                If te_rek2.EditValue = vbNullString Or te_rek2.EditValue = 0 Then
                    cek_recovery()
                Else
                    angs_dua_rek = ang_baru / 2
                    'lb1_total_ang.Text = angs_dua_rek
                    'ang_baru = angs_dua_rek
                End If

                tx_jaminan.Focus()

                'ang_baru = angs_dua_rek
                lb1_total_ang.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb1_total_ang1.Text = angs_dua_rek.ToString("c", New Globalization.CultureInfo("id-ID", False))
                lb1_total_ang2.Text = angs_dua_rek.ToString("c", New Globalization.CultureInfo("id-ID", False))

            End If
        End If
    End Sub

    Private Sub TE_prv_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_prv.EditValueChanged
        prv = TE_prv.EditValue
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            nett = bsr_pjm - recov - prv - r_adm - t_pot
            TE_net.EditValue = nett
        End If

    End Sub

    Private Sub dt_tgl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_tgl.EditValueChanged
        Dim tgle As Date
        tgl_1_trans = "01/" & Month(dt_tgl.EditValue).ToString & "/" & Year(dt_tgl.EditValue).ToString
        tgle = dt_tgl.EditValue
        tgldbet = tgle.Day.ToString
    End Sub

    Private Sub TE_net_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_net.EditValueChanged
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then


            nett = TE_net.EditValue
            'prv = nett * (1 / 100)
            TE_prv.EditValue = prv
            'nett = bsr_pjm - recov - prv - r_adm - t_pot
            TE_net.EditValue = nett
        End If
    End Sub

 
    Private Sub TE_adm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_adm.EditValueChanged
        r_adm = TE_adm.EditValue
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            nett = bsr_pjm - recov - prv - r_adm - t_pot
            TE_net.EditValue = nett
        End If
    End Sub

    Private Sub TE_net_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_net.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx_norek_cair.Focus()
        End If
    End Sub

    Private Sub tx_norek_cair_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx_norek_cair.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx1_ket.Focus()
        End If
    End Sub

    Private Sub txb_noform_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_noform.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_norek.Focus()
        End If
    End Sub

    Private Sub tx_jaminan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx_jaminan.KeyDown
        If e.KeyCode = Keys.Enter Then
            TE_bns.Focus()
        End If
    End Sub

    Private Sub TE_prv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_prv.KeyDown
        If e.KeyCode = Keys.Enter Then
            TE_adm.Focus()
        End If
    End Sub

    Private Sub TE_adm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_adm.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx_norek_cair.Focus()
        End If
    End Sub

    Public Sub buat_kartu()
        'byr_piu = 0
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()
        Dim pk_pinj As Integer = bsr_pjm
        Dim j_bln As Integer
        Dim ang_kart As Double
        'Dim nm_bln As String
        Dim k_bln As Integer = Today.Month
        Dim k_thn As Integer = Today.Year
        ' Dim jt_tmpo As Date

        ang_kart = pokok_pertama
        For y As Integer = 0 To tempo - 1
            rw_kartu = ds_byr_kartu.Tables("_kartu").NewRow()
            rw_kartu.Item("angs_ke") = y + 1
            'If k_thn = Today.Year Then
            '    x = y + 1
            'End If
            j_bln = k_bln + (y + 1)
            rw_kartu.Item("c_pokok_pinj") = pk_pinj
            rw_kartu.Item("c_pokok") = pokok_pertama
            rw_kartu.Item("c_bunga") = t_bunga
            rw_kartu.Item("c_angs") = ang_baru
            If y = tempo - 1 Then
                rw_kartu.Item("c_pokok") = pokok_akhir
                rw_kartu.Item("c_angs") = pokok_akhir + t_bunga
            End If

            'If j_bln = 4 Then
            '    rw_kartu.Item("c_bns") = pot_bns
            '    bsr_pjm = bsr_pjm - pot_bns
            'ElseIf j_bln = 7 Then
            '    rw_kartu.Item("c_thr") = pot_thr
            '    bsr_pjm = bsr_pjm - pot_thr
            'ElseIf j_bln = 12 Then
            '    rw_kartu.Item("c_tat") = pot_tat
            '    bsr_pjm = bsr_pjm - pot_tat
            'End If


            Select Case j_bln 'create tahun
                Case 13
                    k_thn = k_thn + 1
                Case 25
                    k_thn = k_thn + 1
                Case 37
                    k_thn = k_thn + 1
                Case 49
                    k_thn = k_thn + 1
                Case 61
                    k_thn = k_thn + 1
                Case 73
                    k_thn = k_thn + 1
                Case 85
                    k_thn = k_thn + 1
                Case 97
                    k_thn = k_thn + 1
                Case 109
                    k_thn = k_thn + 1
                Case 121
                    k_thn = k_thn + 1
            End Select
            rw_kartu.Item("c_tahun") = k_thn

            If j_bln > 12 Then 'bulan
                If (j_bln > 12 AndAlso j_bln <= 24) Then
                    j_bln = (k_bln + (y + 1)) - 12
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 24 AndAlso j_bln <= 36) Then
                    j_bln = (k_bln + (y + 1)) - 24
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 36 AndAlso j_bln <= 48) Then
                    j_bln = (k_bln + (y + 1)) - 36
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 48 AndAlso j_bln <= 60) Then
                    j_bln = (k_bln + (y + 1)) - 48
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 60 AndAlso j_bln <= 72) Then
                    j_bln = (k_bln + (y + 1)) - 60
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 72 AndAlso j_bln <= 84) Then
                    j_bln = (k_bln + (y + 1)) - 72
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 84 AndAlso j_bln <= 96) Then
                    j_bln = (k_bln + (y + 1)) - 84
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 96 AndAlso j_bln <= 108) Then
                    j_bln = (k_bln + (y + 1)) - 96
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                ElseIf (j_bln > 108 AndAlso j_bln <= 120) Then
                    j_bln = (k_bln + (y + 1)) - 108
                    Dim nm_bln = MonthName(j_bln, True).ToString
                    rw_kartu.Item("c_bulan") = nm_bln
                End If
            Else
                Dim nm_bln = MonthName(j_bln, True).ToString
                rw_kartu.Item("c_bulan") = nm_bln
            End If


            Select Case j_bln
                Case 4
                    rw_kartu.Item("c_bns") = pot_bns
                    bsr_pjm = bsr_pjm - pot_bns
                Case 7
                    rw_kartu.Item("c_thr") = pot_thr
                    bsr_pjm = bsr_pjm - pot_thr
                Case 12
                    rw_kartu.Item("c_tat") = pot_tat
                    bsr_pjm = bsr_pjm - pot_tat
            End Select
            ds_byr_kartu.Tables("_kartu").Rows.Add(rw_kartu)
            pk_pinj = bsr_pjm - ang_kart
            ang_kart = ang_kart + pokok_pertama

        Next

    End Sub
    Public Sub cetak_tabel()
        Gc_kartu.Refresh()

        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()

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
    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,"
        Dim reportFooter3 As String = "(  " & namauser & "  )"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Total BONUS"
        Dim reportFooter8 As String = "Total THR"
        Dim reportFooter11 As String = "Total TAT"
        Dim reportFooter9 As String = gv_kartu.Columns("c_bns").SummaryText
        Dim reportFooter10 As String = gv_kartu.Columns("c_thr").SummaryText
        Dim reportFooter12 As String = gv_kartu.Columns("c_tat").SummaryText
        Dim reportFooter13 As String = ":"
        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 20)
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
        Dim nama_h As String = "Nama   :" & nm_agt
        Dim nip_h As String = "NIP :" & id_anggota
        Dim bsr_h As String = "Besar Pinjaman :" & bsr_pjm
        Dim tempo_h As String = "Tenor " & tempo
        subReport = "Tabel Angsuran"
        'If tglDari.EditValue = tglsampai.EditValue Then
        '    subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString
        'Else
        '    subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(tglsampai.EditValue, "d MMMM yyyy").ToString
        'End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        'e.Graph.DrawImage(Presentation.My.Resources.LOGO_MSBCA1, New RectangleF(0, X25, e.Graph.ClientPageSize.Width, 20), BorderSide.None, Color.Azure)
        Dim rec As RectangleF = New RectangleF(0, 0, CSng(e.Graph.MeasureString(nama_h).Width) + 10, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, CSng(e.Graph.MeasureString(nip_h).Width) + 10, 20)
        Dim rec_judul As RectangleF = New RectangleF(300, 20, CSng(e.Graph.MeasureString(nip_h).Width) + 50, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 40, CSng(e.Graph.MeasureString(bsr_h).Width) + 10, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, CSng(e.Graph.MeasureString(tempo_h).Width) + 10, 20)
        e.Graph.DrawString(nama_h, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(nip_h, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec_judul, BorderSide.None)
        e.Graph.DrawString(bsr_h, Color.Black, rec3, BorderSide.None)
        e.Graph.DrawString(tempo_h, Color.Black, rec4, BorderSide.None)
    End Sub

    Private Sub bt_cetak_tbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cetak_tbl.Click
        cetak_tabel()
    End Sub

 
    Private Sub te_pen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_pen.KeyDown
        If e.KeyCode = Keys.Enter And TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            r_pen = te_pen.EditValue
            hitung_recovery()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lb_notrans.Text <> "" Then
            callReport(App_Path() & "\report\komite.rpt", "", "n_trn=" & lb_notrans.Text, False, False)
        Else
            MsgBox("No Transaksi Kosong", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class