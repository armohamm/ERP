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

Public Class frmRitel_bns
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public cek_tgk As Boolean = True
    Public _notrans As String = "xxx"

    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, kd2, id_anggota, id_jab, jns, ntran_lama, ntran_cek, no_trn, nm_agt As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_byr_kartu, dsNama, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2, ds_cari3, ds_sup, dsjab As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, row1, rw_hist, rw_kartu, rw_tgk As DataRow
    Private DA, DA1, DA2, daNama, da_byr_krt, DALOOKUP, daJab, DALOOKUP1, DA_gdg1, DA_gdg2, da_sup, da_tbh As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private tgldbet, limit_pinj, min_agt_baru, bln_k, lama_pjm, tp_bns, prthn, tempo_pot As Integer
    Private aproval_khs As Integer = 0
    Private pokok_br, pot, pk_br, sisa_pk_lama, t_pk_baru, byr_piu, pot_hrs, t_pk_br, t_pot, lama_pot, bunga, tempo, bg_baru, bts, bts1, bts2, bts_prv_bns1, bts_admin1, bts_prv_bns2, pokok_akhir, t_pk_br_akhir, pokok_asli, pokok2_asli, bsr_pjm, angs, ang_baru, denda, t_bunga, bg_bns, total, recov, prv, bg_jln, adm, adm_default, adm_cek, pot_bns, pot_thr, pot_tat, plfnd As Double
    Private nett, pokok_pertama, jml_pjmLama As Long
    Private BTRAN As SqlTransaction
    Public stat_tran, stat_rec, hit, taunan, prv_lama As Boolean
    Public idJab, jns_krd, tgl_uplod_lalu, tgl_dbt, tgl_1_dbt, tgl_1_trans As String
    Dim subReport, subReport2, pathFoto As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        LUE_nama.Enabled = False 'agar nilai awal lue nama mati, klo da pilih br nyala
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        LUE_nama.Enabled = True

        prv_lama = False 'cek prv lama

        'aproval_kmt = False

        'btCari.Enabled = True
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Private Sub bersihkan()
        lb_nama.Text = ""
        lb_umur.Text = ""
        lb_notrans.Text = ""
        tx_id.Text = ""
        lb_bg_jln.Text = ""

        LUE_nama.EditValue = vbNullString

        lb1_jumlah.Text = ""
        TE_net.EditValue = vbNullString
        tx1_ket.Text = ""
        tx1_LamaPJM.Text = ""
        TE_prv.EditValue = vbNullString
        lb1_bunga_br.Text = ""
        lb1_pokok_br.Text = ""
        lb1_ang_baru.Text = ""
        lb1_ang_baru2.Text = ""
        'lb_t_hit.Text = ""
        'lb_t_pot.Text = ""
        'lb_tempo.Text = ""
        'lb_tempo_pot.Text = ""
        'lb_tempo2.Text = ""
        'lb_tempo3.Text = ""
        'lb_tp_bns.Text = ""
        'lb_tpokok.Text = ""
        'lb_pkBaru.Text = ""
        'lb1_bunga.Text = ""
        'lb1_pokok.Text = ""
        'lb1_total_ang.Text = ""

        TE_bns.EditValue = 0
        TE_thr.EditValue = 0
        TE_tat.EditValue = 0

        lb_admin.Text = ""
        lb_plafon.Text = ""
        lb_denda.Text = ""
        lb_bunga.Text = ""
        lb_prvs.Text = ""
        'lb1.Text = ""
        'tx1_asr.Text = ""
        TE_adm.EditValue = vbNullString
        TE_BsrPJM.EditValue = vbNullString
        LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString
        txb_norek_cair.Text = ""
        txb_norek.Text = ""
        tx_jaminan.Text = ""
        te_bg.Text = "0"
        txb_noform.Text = ""
        txb_norek2.Text = ""
        PictureBox2.Image = Nothing
        If Not dso2.Tables("_agd") Is Nothing Then dso2.Tables("_agd").Clear()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()
        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_agd").Clear()
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
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
    '    Dim hasil, bl, th As String
    '    Dim sqlblth As SqlDataReader
    '    If btrans Is Nothing Then
    '        'blthn=082011
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
    '        '##blthn=201108
    '        sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
    '    Else
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
    '        sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
    '    End If
    '    sqlblth.Read()

    '    hasil = sqlblth.Item(0)
    '    'End If
    '    sqlblth.Close()
    '    Return hasil
    'End Function
    Public Sub cetak_click()
        If lb_notrans.Text <> "" Then
            callReport(App_Path() & "\report\kredit.rpt", "", "notranz=" & lb_notrans.Text, False, False)
        Else
            MsgBox("No Transaksi Kosong", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Public Sub LoadStruktur(ByVal kode As String)

        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select JML_BUNGA+JML_POKOK as ang,* from retail where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")

        da_byr_krt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kartu where 1=2", sqlconn))
        da_byr_krt.Fill(ds_byr_kartu, "_kartu")
        Gc_kartu.DataSource = ds_byr_kartu.Tables("_kartu")
        'cb_prv.Checked = True
        'cb_adm.Checked = True


        Dim sqlkonfig As SqlDataReader = New SqlCommand("select limit_pinj,minim_agt_baru from m_konfig", sqlconn).ExecuteReader
        sqlkonfig.Read()
        limit_pinj = sqlkonfig.Item(0)
        min_agt_baru = sqlkonfig.Item(1)
        sqlkonfig.Close()

        If dSO.Tables("_krd").Rows.Count > 0 Then
            Dim arr() As Byte
            Dim Pic As Object
            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)

            'Dim rw_nm = dsNama.Tables("_nm").Rows(0)
            dt_tgl.EditValue = rwm("tgl_trans").ToString
            LUE_nama.EditValue = rwm("nasabah_id").ToString
            id_anggota = rwm("nasabah_id").ToString
            'LuE_Jab.EditValue = idJab
            bsr_pjm = rwm("JML_PINJAMAN")
            TE_BsrPJM.EditValue = bsr_pjm
            tx1_LamaPJM.Text = lama_pjm
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            pokok_pertama = rwm("JML_POKOK")
            lb1_pokok_br.Text = pokok_pertama
            pokok_akhir = rwm("JML_POKOK_TERAKHIR")
            t_bunga = rwm("JML_BUNGA")
            lb1_bunga_br.Text = t_bunga
            adm = rwm("JML_ADMIN")
            TE_adm.EditValue = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            TE_prv.EditValue = prv
            TE_BsrPJM.EditValue = rwm("JML_PINJAMAN").ToString
            lama_pjm = rwm("LAMA_ANGS").ToString
            tx1_LamaPJM.Text = lama_pjm
            tempo = rwm("LAMA_ANGS").ToString
            'lb1_total_ang.Text = rwm("ang").ToString
            bunga = rwm("bunga").ToString
            tx1_ket.Text = rwm("KETERANGAN").ToString
            'lb_nama.Text = rw_nm.Item("Nama")
            te_bg.EditValue = bunga
            txb_norek.Text = rwm("no_rek").ToString
            txb_norek_cair.Text = rwm("norek_cair").ToString
            txb_norek2.Text = rwm("no_rek2").ToString
            'txb_bank.Text = rwm("nama_bank").ToString
            'cb_tglbyr.Text = rwm("TGL_TAGIHAN").ToString
            bg_jln = IIf(rwm.IsNull("rec_bbj"), 0, rwm("rec_bbj").ToString)
            'tx_jaminan.Text = IIf(rwm.IsNull("no_jaminan"), "", rwm("no_jaminan").ToString) 'rwm.Item("no_jaminan")
            'Pic = rwm.Item("foto_jaminan")
            'arr = rwm.Item("foto_jaminan")
            'pot_bns = rwm.Item("pot_bns")
            'pot_thr = rwm.Item("pot_thr")
            'pot_tat = rwm.Item("pot_tat")
            LuE_Jab.EditValue = idJab
            Lue_tipe.EditValue = rwm("tipe").ToString
            tx_id.Text = rwm("nasabah_id").ToString


            Lue_SetPjm.EditValue = rwm("jenis").ToString

            bunga = rwm("bunga").ToString
            tx1_ket.Text = rwm("KETERANGAN").ToString
            'lb_nama.Text = rw_nm.Item("Nama")
            te_bg.EditValue = bunga
            txb_norek.Text = rwm("no_rek").ToString
            txb_norek_cair.Text = rwm("norek_cair").ToString
            txb_norek2.Text = rwm("no_rek2").ToString
            'txb_bank.Text = rwm("nama_bank").ToString
            'cb_tglbyr.Text = rwm("TGL_TAGIHAN").ToString
            bg_jln = IIf(rwm.IsNull("rec_bbj"), 0, rwm("rec_bbj").ToString)
            'tx_jaminan.Text = IIf(rwm.IsNull("no_jaminan"), "", rwm("no_jaminan").ToString) 'rwm.Item("no_jaminan")
            'Pic = rwm.Item("foto_jaminan")
            'arr = rwm.Item("foto_jaminan")
            'pot_bns = rwm.Item("pot_bns")
            'pot_thr = rwm.Item("pot_thr")
            'pot_tat = rwm.Item("pot_tat")
            TE_bns.EditValue = pot_bns
            TE_thr.EditValue = pot_thr
            TE_tat.EditValue = pot_tat
            LuE_Jab.EditValue = IIf(rwm.IsNull("job_id"), "", rwm("job_id").ToString) 'rwm.Item("job_id") rwm.Item("job_id")
            lb_umur.Text = IIf(rwm.IsNull("umur"), "", rwm("umur").ToString) 'rwm.Item("no_jaminan") rwm.Item("umur")
            'If arr.Length = 0 Then
            '    PictureBox2.Image = Presentation.My.Resources.profile_photo
            'Else
            '    ' arr = row.Item("Foto")
            '    PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
            '    'PictureBox2.Image = Image.FromStream(ms)
            'End If

            'If Not rwm.IsNull("stat_provisi") Then
            '    If (rwm("stat_provisi") = True) Then
            '        cb_prv.CheckState = CheckState.Checked
            '    Else
            '        cb_prv.CheckState = CheckState.Unchecked
            '    End If
            'End If

            lb_notrans.Text = rwm("no_trans").ToString
            pot = pot_bns + pot_tat + pot_thr
            tp_bns = lama_pjm / 12
            If pot > 0 Then
                t_pot = pot * tp_bns 'lama bulan/12 = setehun/pertehun
            End If
            lb_total2.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_selama.Text = tp_bns
            'bunga = rwm("bunga") / 100
            'angs = rwm("ang")
            'If rwm("jenis") <> "BNS " Then
            '    pokok_pertama = rwm("JML_POKOK")
            '    pokok_asli = rwm("JML_POKOK")
            '    If Not rwm.IsNull("sisa_pokok_after_potong") Then
            '        t_pk_br = rwm("sisa_pokok_after_potong")
            '    End If

            '    t_bunga = rwm("JML_BUNGA")
            'End If
            If rwm("jenis") = "BNS " Then
                de_debet.Visible = True 'tampil
                de_debet.EditValue = rwm("tgl_debet")
            End If
            adm = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            bsr_pjm = rwm("JML_PINJAMAN")
            ang_baru = rwm("jml_angsuran")
            total = t_pot + t_pk_br


            lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_ang_baru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_ang_baru2.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))


            TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
            TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'tampilan sebelah
            'lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_tpokok.Text = t_pk_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_tempo_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb_tempo.Text = tx1_LamaPJM.Text
            'lb_tempo2.Text = tx1_LamaPJM.Text
            'lb_tempo3.Text = tx1_LamaPJM.Text
            'If pot > 0 Then
            '    lb_tp_bns.Text = tx1_LamaPJM.Text / 12
            'End If


            'tx1_angs.Text = pokok
            'tx1_bunga.Text = bsr_pjm * bunga
            'tx1_t_angs.Text = t_bunga + pokok

            'cek_recovery()
            lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            nett = bsr_pjm - (prv + adm)
            '##JUMLAH TERIMA
            TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
            buat_kartu() 'cetak tabel angsuran
            Dim sqlnm As SqlDataReader = New SqlCommand("select Nama from anggota where nasabah_id= '" & id_anggota & "'", sqlconn).ExecuteReader
            sqlnm.Read()
            lb_nama.Text = sqlnm.Item(0)
            sqlnm.Close()
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        Select Case Lue_SetPjm.EditValue 'create tahun
            Case "NOR "
                If TE_BsrPJM.EditValue > plfnd Then
                    MsgBox("Normatif tidak boleh melebihi plafond", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Case vbNullString
                MsgBox("Pilihan Jenis Pinjaman Belum di pilih", MsgBoxStyle.Exclamation)
        End Select


        If cek_tgk = True Then
            MsgBox("Harus melewati approval komite atau Lunasi tunggakan,Outstanding Pinjaman", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LUE_nama.EditValue = vbNullString Or TE_BsrPJM.EditValue = vbNullString Then
            MsgBox("Lengkapi data:Jenis Pinjaman, Nama,besar Pinjaman mungkin kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
    End Sub
    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        'adm = adm_cek 'utk isi admin yg td centang di kenakan apa tidak
        Dim BTRANS As SqlTransaction
        'hitung_cicilan()

        If Not isDelete Then


            'Dim BTRANS As SqlTransaction
            If STATE = "ADD" Then
                row = dSO.Tables("_krd").NewRow

                row.Item("no_trans") = get_notran()
                'MsgBox(id_anggota + jns + blthn())
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("cetak_ke") = 0
                lb_notrans.Text = row.Item("no_trans")
                row.Item("stat_kabagSP") = "Outstanding"
                row.Item("TGL_TAGIHAN") = 25
                row.Item("rec_lunas") = 1
                row.Item("status_lunas") = "BELUM"
                row.Item("approve1_by") = "OutStanding"
                row.Item("approve2_by") = "OutStanding"
                row.Item("approve3_by") = "OutStanding"
                row.Item("approve4_by") = "OutStanding"
                row.Item("STATUS_AKTIF") = 0 ' ###pengajuan 0. kalo udah di approve cair posting jurnal maka 1
                row.Item("stat_approve") = 0
                row.Item("stat_cair") = 0
                row.Item("act_kabag") = 0
                row.Item("stat_cair_approve") = 0
                row.Item("stat_pot_bns") = 0
                row.Item("stat_pot_thr") = 0
                row.Item("stat_pot_tat") = 0
                row.Item("stat_rls") = 0
                row.Item("stat_approve_rls") = 0
                row.Item("kd_kredit") = Lue_SetPjm.EditValue '### kode kredit, mts atau Recovery approve_komite2
                row.Item("approve_khusus") = aproval_khs
                'If aproval_kmt = True Then
                '    row.Item("approve_khusus") =aproval_khs '### kode kredit, mts atau Recovery approve_komite2
                'End If
                row.Item("approve_khusus") = 0
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Last_Updated_By") = username
            ElseIf STATE = "CETAK" Then
                row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If
            row.Item("tgl_debet") = de_debet.EditValue
            row.Item("tgl_trans") = dt_tgl.EditValue
            row.Item("NASABAH_ID") = tx_id.Text
            row.Item("jenis") = Lue_SetPjm.EditValue
            row.Item("tipe") = Lue_tipe.EditValue
            row.Item("JML_PINJAMAN") = TE_BsrPJM.EditValue
            row.Item("JML_ADMIN") = adm
            row.Item("JML_POKOK") = pokok_pertama
            row.Item("JML_BUNGA") = t_bunga
            row.Item("jml_angsuran") = pokok_pertama + t_bunga
            row.Item("sisa_pokok") = TE_BsrPJM.EditValue
            row.Item("sisa_pokok_after_potong") = t_pk_br

            row.Item("JML_POKOK_TERAKHIR") = pokok_akhir
            'row.Item("JML_ASURANSI") = tx_asr.Text
            row.Item("JML_PROVISI") = prv
            'row.Item("stat_provisi") = IIf(cb_prv.Checked, 1, 0)
            row.Item("JML_TERIMA") = nett
            'row.Item("JML_DENDA") = tx1_LamaPJM.Text
            row.Item("TGL_PENGAJUAN") = getTanggal()
            If jns_krd = "KHS " Or jns_krd = "BNS " Then
                row.Item("JML_POKOK") = TE_BsrPJM.EditValue
                row.Item("JML_BUNGA") = tx1_LamaPJM.Text
                row.Item("JML_POKOK_TERAKHIR") = tx1_LamaPJM.Text
            End If
            row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
            row.Item("sisa_angs") = tx1_LamaPJM.Text
            row.Item("KETERANGAN") = tx1_ket.Text
            row.Item("no_rek") = txb_norek.Text
            row.Item("no_rek2") = txb_norek2.Text
            'row.Item("nama_bank") = txb_bank.Text

            row.Item("rec_bbj") = bg_jln

            'row.Item("no_jaminan") = tx_jaminan.Text
            'row.Item("foto_jaminan") = foto
            'row.Item("pot_bns") = TE_bns.EditValue
            'row.Item("pot_thr") = TE_thr.EditValue
            'row.Item("pot_tat") = TE_tat.EditValue

            row.Item("bunga") = bunga
            row.Item("job_id") = LuE_Jab.EditValue
            row.Item("umur") = lb_umur.Text
            row.Item("norek_cair") = txb_norek_cair.Text
            row.Item("no_ref") = txb_noform.Text
            row.Item("kd_dep") = kddep
            row.Item("kd_brg") = Lue_Brg.EditValue
            row.Item("kd_jns_brg") = Lue_Jns_brg.EditValue
            row.Item("kd_jns_supplier") = LueSupp.EditValue

            'If stat_rec = True Then
            '    row.Item("rec_sisa_kredit") = txr_jmlHut.Text
            '    row.Item("rec_penalty") = txr_pen.Text
            '    row.Item("rec_provisi") = txr_prvs.Text
            '    row.Item("rec_admin") = txr_adm.Text
            '    row.Item("rec_bbj") = txr_bunga.Text

            'End If

            If STATE = "ADD" Then
                dSO.Tables("_krd").Rows.Add(row)
                'ElseIf STATE = "ADD" Then
                '    row1 = dSO.Tables("_krd").Rows(0)
            End If



        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da_tbh)
            'da_tbh.UpdateCommand = Buildernya.GetUpdateCommand()
            'da_tbh.InsertCommand = Buildernya.GetInsertCommand()
            'da_tbh.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'da_tbh.UpdateCommand.Transaction = BTRANS
            'da_tbh.InsertCommand.Transaction = BTRANS
            'da_tbh.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("_krd"))
            'da_tbh.Update(ds_tbh.Tables("_tbh"))


            BTRANS.Commit()
            If STATE = "DELETE" Then
                showMessages("Data Entry dihapus..")
            Else
                showMessages("Berhasil disimpan")
            End If

            STATE = "EDIT"

            prn.btnSave.Enabled = False
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) from retail where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
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
        Dim sqlr As SqlDataReader = New SqlCommand("select * from retail where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
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

        'Lue_SetPjm.EditValue = vbNullStrin
    End Sub



    Public Sub Cari()
        'bersihkan()

        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,DATEDIFF(MONTH,tgl_masuk, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as bln_ke,tgl_masuk,Nama as [Nama],a.jns_kel as [Jenis_kelamin],j.batas_provisi,j.batas_admin,a.job_id,isnull(a.Almt_asal,'')as Almt_asal,CONVERT(int,ROUND(DATEDIFF(hour, isnull(convert(date,Tgl_lahir,1),''),GETDATE())/8766.0,0)) AS Umur, ISNULL(k.nama_kota,'') as nama_kota,* from anggota a left join kota k on a.kode_kota=k.kode_kota inner join m_jabatan j on a.job_id=j.job_id where a.nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) '
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not row Is Nothing Then
            cek_hist()
            LUE_nama.EditValue = row("nasabah_id")
            tx_id.Text = row("nasabah_id")
            bln_k = row("bln_ke")
            lb_umur.Text = row("Umur")
            lb_nama.Text = row("Nama")
            nm_agt = row("Nama")
            lb_alamat.Text = row("Almt_asal")
            lb_kota.Text = row("nama_kota")
            id_anggota = row("nasabah_id")
            LuE_Jab.EditValue = row("job_id")
            txb_norek.Text = row("REKBCA1")
            txb_norek_cair.Text = row("REKBCA1")
            txb_norek2.Text = IIf(row.IsNull("REKBCA2"), 0, row("REKBCA2").ToString) 'row("REKBCA2")
            'txb_bank.Text = "BCA"
            id_jab = row("status_kary")
            bts_prv_bns1 = row("batas_provisi")
            bts_admin1 = row("batas_admin")

            'If Not ds_byr_kartu.Tables("_krt") Is Nothing Then ds_byr_kartu.Tables("_krt").Clear()
            'da_byr_krt = New SqlDataAdapter(New SqlCommand("SELECT no_trans,JML_PINJAMAN,JML_POKOK+JML_BUNGA as angs,sisa_angs FROM KOPKAR.dbo.kredit where status_aktif=1 and status_lunas='BELUM' and stat_approve >= 5 and nasabah_id='" & id_anggota & "'", sqlconn))
            'da_byr_krt.Fill(ds_byr_kartu, "_krt")
            'Lue_Byr_kartu.Properties.DataSource = ds_byr_kartu.Tables("_krt")
            'Lue_Byr_kartu.Properties.DisplayMember = "no_trans"
            'Lue_Byr_kartu.Properties.ValueMember = "no_trans"

            If bln_k <= min_agt_baru Then
                MsgBox("Anggota Baru minimal setelah 3 bln utk pengajuan Pinjaman", MsgBoxStyle.Critical)
                aproval_khs = 1 'anggota baru < x bln
                'cek_tgk = True
            End If
        Else
            btnSave = False

        End If
    End Sub


    Private Sub frmKredit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hit = True
        connect()
        prn = getParent(Me)
        cek_tgk = False

        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        dt_tgl.EditValue = Today
        dt_tgl.Properties.MaxValue = Today

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='BNS' ", sqlconn)) 'where tipe_trans='KRD'
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"
        'MsgBox(Lue_SetPjm.EditValue)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DALOOKUP.Fill(ds_cari, "Looktipe")
        Lue_tipe.Properties.DataSource = ds_cari.Tables("Looktipe")
        Lue_tipe.Properties.DisplayMember = "nama"
        Lue_tipe.Properties.ValueMember = "tipe"

        daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select job_id,job_nama from m_jabatan", sqlconn))
        daJab.Fill(dsjab, "View_Jabatan")
        LuE_Jab.Properties.DataSource = dsjab.Tables("View_Jabatan")
        LuE_Jab.Properties.ValueMember = "job_id"
        LuE_Jab.Properties.DisplayMember = "job_nama"

        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_jns,nama from m_jns_barang", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_jnsbrg")
        Lue_Jns_brg.Properties.DataSource = ds_gdg1.Tables("_jnsbrg")
        Lue_Jns_brg.Properties.ValueMember = "kd_jns"
        Lue_Jns_brg.Properties.DisplayMember = "nama"
        Lue_Jns_brg.EditValue = 1

        DA_gdg2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_member,nama from m_jns_member", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_mbr")
        Lue_member.Properties.DataSource = ds_gdg2.Tables("_mbr")
        Lue_member.Properties.ValueMember = "kd_member"
        Lue_member.Properties.DisplayMember = "nama"
        Lue_member.EditValue = 1

        da_sup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_jns,nama from m_jns_supplier", sqlconn))
        da_sup.Fill(ds_sup, "_sup")
        LueSupp.Properties.DataSource = ds_sup.Tables("_sup")
        LueSupp.Properties.ValueMember = "kd_jns"
        LueSupp.Properties.DisplayMember = "nama"
        LueSupp.EditValue = 1

        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_brg,nama from m_barang", sqlconn))
        DALOOKUP1.Fill(ds_cari3, "_brg")
        Lue_Brg.Properties.DataSource = ds_cari3.Tables("_brg")
        Lue_Brg.Properties.ValueMember = "kd_brg"
        Lue_Brg.Properties.DisplayMember = "nama"
        Lue_Brg.EditValue = "00000008"


        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '1' as id_jenis_bayar, 'Tunai' as nama_jenis_bayar union select '2' as id_jenis_bayar, 'Debet Gaji' as nama_jenis_bayar union select '3' as id_jenis_bayar, 'Transfer' as nama_jenis_bayar", sqlconn))
        DALOOKUP1.Fill(ds_cari3, "_jenis_bayar")
        Jenis_Bayar.Properties.DataSource = ds_cari3.Tables("_jenis_bayar")
        Jenis_Bayar.Properties.ValueMember = "id_jenis_bayar"
        Jenis_Bayar.Properties.DisplayMember = "nama_jenis_bayar"
        Jenis_Bayar.EditValue = 1


        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota where Rec_Stat=1", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"
        de_debet.EditValue = Today.AddMonths(1)
        Lue_tipe.EditValue = "F"
        de_debet.Visible = False
        lb_debet.Visible = False
        'byr_hide()
        LoadStruktur(_notrans)
        LuE_Jab.Enabled = False
        cb_lock.Checked = False
    End Sub

    'Public Sub byr_unhide()
    '    gc_byr_piu.Visible = True
    '    lb_bayar_kartu.Visible = True
    '    TE_jml_byr.Visible = True
    '    lb_ctg.Visible = True
    '    cb_all.Visible = True
    '    lb_pilih_all.Visible = True
    'End Sub
    'Public Sub byr_hide()
    '    lb_ctg.Visible = False
    '    TE_jml_byr.Visible = False
    '    gc_byr_piu.Visible = False
    '    lb_bayar_kartu.Visible = False
    '    cb_all.Visible = False
    '    lb_pilih_all.Visible = False
    'End Sub

    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        Dim skrg As Date
        If STATE = "ADD" Then
            lb1_admx.Text = "Administrasi"
            'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
            If Not ds_cari.Tables("LookTran") Is Nothing Then bersihkan() '
            LUE_nama.Enabled = True
            If Lue_SetPjm.EditValue = "PTAT" Or Lue_SetPjm.EditValue = "PTHR" Or Lue_SetPjm.EditValue = "PBNS" Then
                If Lue_SetPjm.EditValue <> vbNullString Then
                    LUE_nama.Enabled = True
                End If
                taunan = True
                If Lue_SetPjm.EditValue = "PTAT" Then
                    Dim tgl_tat As DateTime = New DateTime(Today.Year, 12, 25)
                    de_debet.EditValue = tgl_tat
                ElseIf Lue_SetPjm.EditValue = "PTHR" Then
                    Dim tgl_tat As DateTime = New DateTime(Today.Year, 7, 25)
                    de_debet.EditValue = tgl_tat
                ElseIf Lue_SetPjm.EditValue = "PBNS" Then
                    If Today.Month < 4 Then
                        Dim tgl_tat As DateTime = New DateTime(Today.Year, 4, 25)
                        de_debet.EditValue = tgl_tat
                    Else
                        Dim tgl_tat As DateTime = New DateTime(Today.Year + 1, 4, 25)
                        de_debet.EditValue = tgl_tat
                    End If


                End If

                TE_bns.Enabled = False
                TE_thr.Enabled = False
                TE_tat.Enabled = False
                jns_krd = "BNS " 'bonus april tat thr
                de_debet.Visible = True
                tx1_LamaPJM.Text = 1
                lb_debet.Visible = True
                lb_debet.Text = "Tgl debet TAT/BNS/THR"
                'byr_unhide()
                MsgBox("SILAHKAN MENG SET TANGGAL DEBET THR/TAT/BNS utk menghitung bunga berjalan..!!")
            ElseIf Lue_SetPjm.EditValue = "KHS " Then '4 char
                jns_krd = "KHS "
                lb_debet.Visible = True
                de_debet.Visible = True
                lb_debet.Text = "Tgl Lunas Next"
                MsgBox("SILAHKAN MENG SET TANGGAL NEXT DBET utk menghitung bunga berjalan..!!")
                tx1_LamaPJM.Text = 1
                TE_bns.Enabled = True
                TE_thr.Enabled = True
                TE_tat.Enabled = True

                'byr_hide()
            ElseIf Lue_SetPjm.EditValue = "BRG " Then
                jns_krd = "BRG "
                lb1_admx.Text = "Fee Kop"
            Else
                taunan = False
                TE_bns.Enabled = True
                TE_thr.Enabled = True
                TE_tat.Enabled = True
                jns_krd = "KRD"
                de_debet.Visible = False
                lb_debet.Visible = False
                'byr_hide()
            End If
            Dim i As Integer

            'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
            Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
            'MsgBox(dr(i))

            plfnd = dr(i).Item("nilai")
            lb_plafon.Text = Convert.ToDecimal(plfnd).ToString("N")
            lb_bunga.Text = dr(i).Item("Bunga_KSP")
            bunga = dr(i).Item("Bunga_KSP")
            te_bg.EditValue = bunga
            lb_bunga.Text = bunga
            lb_admin.Text = Convert.ToDecimal(dr(i).Item("Adm")).ToString("N")
            'tx_asr.Text = dr(i).Item("Asuransi")
            lb_prvs.Text = dr(i).Item("provisi")
            lb_denda.Text = dr(i).Item("Denda")
            'lb1_adm.Text = dr(i).Item("Adm")
            'lb_admin.Text = dr(i).Item("Adm")
            'tx1_prvs.Text = dr(i).Item("provisi")
            lb_prvs.Text = dr(i).Item("provisi")
            'tx1_asr.Text = dr(i).Item("Asuransi")
            'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
            lb_bunga.Text = dr(i).Item("Bunga_KSP")

            'cb_tglbyr.Text = 25
            bts1 = dr(i).Item("batas_admin1")
            bts2 = dr(i).Item("batas_admin2")
            'bts_prv_bns1 = dr(i).Item("batas_prv_bns1")
            'bts_prv_bns2 = dr(i).Item("batas_prv_bns2") 'batas_prv_bns1
            jns = dr(i).Item("kode")
            kd2 = Lue_SetPjm.EditValue
            adm_default = dr(i).Item("Adm")
            prv = dr(i).Item("provisi")
            'If adm_default = 0 Then
            '    'MsgBox("adm 0")
            '    cb_adm.Checked = False

            'Else
            '    cb_adm.Checked = True
            '    lb1_adm.Text = adm_default.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'End Ifulan
            'If prv = 0 Then
            '    'MsgBox("PRV =0")
            '    cb_prv.Checked = False
            'Else
            '    cb_prv.Checked = True

            'End If

            If taunan = False Then
                'bunga = 0

            Else
                'bunga = lb1_bunga.Text 'tetep dikenakan bunga
                tx1_LamaPJM.Text = 1 'langsung lunas setahun/taunan bonus,thr,tat
            End If

        End If
        'btCari.Focus()
        LUE_nama.Focus()
    End Sub


    Private Sub LuE_Jab_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LuE_Jab.EditValueChanged
        Dim i As Integer
        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
        If Lue_SetPjm.EditValue = "PTHR" Or Lue_SetPjm.EditValue = "PTAT" Or Lue_SetPjm.EditValue = "PBNS" Then
            'taunan = True
            'MsgBox("Taunan = true")
            If LuE_Jab.EditValue = 8 Or LuE_Jab.EditValue = 0 Then
                lb_plafon.Text = dr(i).Item("nilai")
            ElseIf LuE_Jab.EditValue = 5 Or LuE_Jab.EditValue = 6 Or LuE_Jab.EditValue = 7 Or LuE_Jab.EditValue = 9 Then
                lb_plafon.Text = dr(i).Item("nilai2")
            ElseIf LuE_Jab.EditValue = 1 Or LuE_Jab.EditValue = 2 Or LuE_Jab.EditValue = 3 Or LuE_Jab.EditValue = 4 Then
                lb_plafon.Text = dr(i).Item("nilai3")
            End If
            'Else
            '    taunan = False
            '    MsgBox("Taunan = false")
        End If
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Lue_SetPjm.EditValue = vbNullString Then
            MsgBox("Jenis Pinjaman belum di pilih, silahkan pilih dahulu")
            Exit Sub
        End If
        Cari()
        cek_hist()
        'cek_agenda()
        'cek_notran()
        TE_BsrPJM.Focus()
        'cek_recovery()
    End Sub
    'Private Sub cek_recovery()
    '    Dim sqlcek As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and stat_cair=1 and status_lunas='BELUM'", sqlconn).ExecuteReader
    '    sqlcek.Read()
    '    If sqlcek.HasRows Then
    '        stat_rec = True
    '        Dim jml_ut, nilai, prv_r, bg_lama, bg_jln, pen As Decimal
    '        Dim sisa, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, tgl_uplod, blnx, bln_skrg As Integer
    '        'Dim tgl_uplod, blnx, bln_skrg As String

    '        Dim sqdr1 As SqlDataReader = New SqlCommand("select 25 as tgl,MONTH(getdate())-1 as blnx , month(GETDATE()) as bln_skrg, " & _
    '"DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
    '"datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
    '"day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu,  " & _
    '"day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg  " & _
    '"from export_log ", sqlconn).ExecuteReader
    '        sqdr1.Read()
    '        tgl_uplod = sqdr1.Item("tgl")
    '        blnx = sqdr1.Item("blnx")
    '        bln_skrg = sqdr1.Item("bln_skrg")
    '        jm_hr_lalu = sqdr1.Item("jm_hr_lalu")
    '        jm_hr_today = sqdr1.Item("jm_hr_today")
    '        jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
    '        jm_bl_skrg = sqdr1.Item("jm_bl_skrg")

    '        sqdr1.Close()
    '        'sqdr1.Close()
    '        'MsgBox(bln_skrg)
    '        'jml_hr = System.DateTime.DaysInMonth(Today.Year, Today.Month)
    '        Dim sqdr As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and no_trans='" & ntran_lama & "' ", sqlconn).ExecuteReader
    '        sqdr.Read()
    '        sisa = sqdr.Item("sisa_angs")
    '        jml_ut = sqdr.Item("JML_POKOK") * sisa
    '        'bg_rcv = sqdr.Item("Bunga_KSP")
    '        nilai = sqdr.Item("JML_PINJAMAN")
    '        bg_lama = sqdr.Item("JML_BUNGA")
    '        prv_r = bsr_pjm * (prv / 100)
    '        txr_jmlHut.Text = jml_ut
    '        txr_adm.Text = lb_admin.Text
    '        txr_prvs.Text = prv_r
    '        adm = txr_adm.Text
    '        'txr_adm.Text = tx_adm.Text
    '        'txr_hitRec.Text = nilai * bunga
    '        txr_pen.Text = nilai * (2.5 / 100)

    '        If blnx <> bln_skrg Then
    '            bg_jln = (bg_lama * jm_hr_lalu / jm_bl_lalu) + (bg_lama * jm_hr_today / jm_bl_skrg)
    '            txr_bunga.Text = bg_jln
    '        End If
    '        recov = bg_jln + jml_ut + prv_r + adm + pen
    '        txr_total.Text = recov
    '        'tx_net.Text = t_total.Text - txr_total
    '        sqdr.Close()
    '        'sqdr1.Close()
    '    Else
    '        stat_rec = False
    '        Exit Sub
    '    End If
    '    sqlcek.Close()
    'End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data ENTRY ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then
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

    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select k.no_trans,a.Nama,k.nasabah_id,k.tgl_trans,k.jenis,k.JML_PINJAMAN,k.LAMA_ANGS,k.stat_kabagSP,k.stat_approve,k.stat_cair,a.job_id from retail k left join anggota a on k.nasabah_id=a.nasabah_id  where k.Last_Created_By='" & username & "' AND k.stat_approve < 5 order by k.tgl_trans desc", sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        'btCari.Enabled = False
        btnSave = True
        btnEdit = False
        btnDelete = True
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        LUE_nama.Enabled = True
        'btCari.Enabled = True
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim i As Integer
            'btCari.Enabled = False
            LUE_nama.Enabled = False
            lb_nama.Text = frmCari.row.Item("Nama").ToString
            'LuE_Jab.EditValue = idJab
            LoadStruktur(frmCari.row(0))
            'Load baca setting pinjaman
            Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
            'MsgBox(dr(i))

            plfnd = dr(i).Item("nilai")
            lb_plafon.Text = Convert.ToDecimal(plfnd).ToString("N")
            lb_bunga.Text = dr(i).Item("Bunga_KSP")
            lb_admin.Text = Convert.ToDecimal(dr(i).Item("Adm")).ToString("N")
            lb_prvs.Text = dr(i).Item("provisi")
            lb_denda.Text = dr(i).Item("Denda")
            'TE_adm.EditValue = dr(i).Item("Adm")
            'TE_prv.EditValue = dr(i).Item("provisi")
            'lb1_bunga.Text = dr(i).Item("Bunga_KSP")
            bunga = dr(i).Item("Bunga_KSP")
            lb_bunga.Text = bunga
            'cb_tglbyr.Text = 25
            jns = dr(i).Item("kode")
            kd2 = Lue_SetPjm.EditValue
            adm_default = dr(i).Item("Adm")
            prv = dr(i).Item("provisi")
            bts1 = dr(i).Item("batas_admin1")
            bts2 = dr(i).Item("batas_admin2")
            bts1 = dr(i).Item("batas_admin1")
            bts2 = dr(i).Item("batas_admin2")
            'bts_prv_bns1 = dr(i).Item("batas_prv_bns1")
            ''bts_prv_bns2 = dr(i).Item("batas_prv_bns2") 'batas_prv_bns1
            'jns = dr(i).Item("kode")
            'kd2 = Lue_SetPjm.EditValue
            'adm_default = dr(i).Item("Adm")
            'prv = dr(i).Item("provisi")

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


        Else
            cancel_click()
            'add_click()

            'LookupPO.Enabled = False
            STATE = ""
        End If

    End Sub



    'Public Sub cek_agenda()
    '    If Not dso2.Tables("_agd") Is Nothing Then
    '        dso2.Tables("_agd").Clear()
    '    End If
    '    DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where nasabah_id= '" & id_anggota & "' and stat_approve < 5", sqlconn))
    '    DA1.Fill(dso2, "_agd")
    '    gc_agenda.DataSource = dso2.Tables("_agd")
    '    gv_agenda.BestFitColumns()


    'End Sub
    Public Sub cek_hist()
        If Not dSO1.Tables("_hist") Is Nothing Then
            dSO1.Tables("_hist").Clear()
        End If
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,no_kartu as no_trans,keterangan as jenis,tgl_trans,rp_tunggakan as Angsuran, " & _
"1 as LAMA_ANGS,1 as sisa_angs,rp_tunggakan as JML_PINJAMAN,rp_tunggakan sisa_pokok from tunggakan where nasabah_id= '" & LUE_nama.EditValue & "' and stat_lunas=0", sqlconn))
        DA2.Fill(dSO1, "_hist") ''tunggakan history
        Dim sqltgk1 As SqlDataReader = New SqlCommand("select nasabah_id,no_kartu as no_trans,keterangan as jenis,tgl_trans,rp_tunggakan as Angsuran, " & _
"1 as LAMA_ANGS,1 as sisa_angs,rp_tunggakan as JML_PINJAMAN,rp_tunggakan sisa_pokok from tunggakan where nasabah_id= '" & LUE_nama.EditValue & "' and stat_lunas=0", sqlconn).ExecuteReader
        If sqltgk1.HasRows And taunan = False Then
            warningTGK()
            aproval_khs = 3 'tunggakan dan outstanding
        End If
        sqltgk1.Close()
        If taunan = False Then
            Dim sqltgk2 As SqlDataReader = New SqlCommand("select *,JML_POKOK+JML_BUNGA as Angsuran from kredit where nasabah_id= '" & LUE_nama.EditValue & "' and status_lunas='BELUM' and kd_kredit<>'BRG '", sqlconn).ExecuteReader
            If sqltgk2.HasRows Then
                warningTGK()
                aproval_khs = 3 'tunggakan dan outstanding
                prv_lama = True
            End If
            sqltgk2.Close()
        End If
        Dim sql6bln As SqlDataReader = New SqlCommand("select top 1 DATEDIFF(MONTH,tgl_trans, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as bln_ke from kredit where nasabah_id= '" & LUE_nama.EditValue & "' and status_lunas='BELUM' and kd_kredit<>'BRG ' order by tgl_trans desc", sqlconn).ExecuteReader
        If sql6bln.Read Then
            Dim cek6bln As Integer

        End If
        sql6bln.Close()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,JML_POKOK+JML_BUNGA as Angsuran from kredit where nasabah_id= '" & LUE_nama.EditValue & "' and stat_approve >= 5 and status_lunas='BELUM'", sqlconn))
        DA2.Fill(dSO1, "_hist")

        'For Each rw_hst As DataRow In dSO1.Tables("_hist").Select("jenis = '" & Lue_SetPjm.EditValue & "'")
        '    jml_pjmLama = rw_hst.Item("JML_PINJAMAN")
        '    prv_lama = True
        'Next 'Ternyata di hitung dr sisa pokok lama dari jenis appapun
        GcHist.DataSource = dSO1.Tables("_hist")
        Gv_hist.BestFitColumns()
        jml_pjmLama = Gv_hist.Columns("sisa_pokok").SummaryItem.SummaryValue

    End Sub

    Public Sub cek_hut()
        If STATE = "ADD" Then
            If Not ds_tbh.Tables("_tbh") Is Nothing Then
                ds_tbh.Tables("_tbh").Clear()
            End If
            Dim i As Int16 = 1
            Dim sqltgk As SqlDataReader = New SqlCommand("select * from tunggakan where nasabah_id= '" & LUE_nama.EditValue & "' and stat_lunas=0", sqlconn).ExecuteReader
            If sqltgk.HasRows Then
                rw_tgk = ds_tbh.Tables("_tbh").NewRow

                rw_tgk.Item("no_seq") = i : i += 1
                rw_tgk.Item("nilai") = sqltgk.Item("rp_tunggakan")
                rw_tgk.Item("angs_ke") = 1
                rw_tgk.Item("tgl_trans") = sqltgk.Item("tgl_trans")
                rw_tgk.Item("sisa_pokok") = sqltgk.Item("rp_tunggakan")
                rw_tgk.Item("JML_PINJAMAN") = sqltgk.Item("rp_tunggakan")
                rw_tgk.Item("no_ref") = sqltgk.Item("no_kartu")
                rw_tgk.Item("stat_lunas") = "BELUM"
                rw_tgk.Item("cek_byr") = "T"
                rw_tgk.Item("jenis") = sqltgk.Item("keterangan")
                rw_tgk.Item("create_date") = getTanggal()
                rw_tgk.Item("create_by") = username

                ds_tbh.Tables("_tbh").Rows.Add(rw_tgk)

            End If
            sqltgk.Close()

            'Dim sqdrx As SqlDataReader = New SqlCommand("select JML_POKOK+JML_BUNGA as angs_dd,(LAMA_ANGS-sisa_angs)+1 as angs_ke,* from kredit where nasabah_id= '" & LUE_nama.EditValue & "'and stat_approve >= 5 and status_lunas='BELUM'", sqlconn).ExecuteReader
            'While sqdrx.Read()
            '    rw_hist = ds_tbh.Tables("_tbh").NewRow

            '    rw_hist.Item("no_seq") = i : i += 1
            '    rw_hist.Item("nilai") = sqdrx.Item("angs_dd")
            '    rw_hist.Item("angs_ke") = sqdrx.Item("angs_ke")
            '    rw_hist.Item("sisa_pokok") = sqdrx.Item("sisa_pokok")
            '    rw_hist.Item("JML_PINJAMAN") = sqdrx.Item("JML_PINJAMAN")
            '    rw_hist.Item("no_ref") = sqdrx.Item("no_trans")
            '    rw_hist.Item("jenis") = sqdrx.Item("jenis")
            '    rw_hist.Item("stat_lunas") = "BELUM"
            '    rw_hist.Item("cek_byr") = "T"
            '    rw_hist.Item("tgl_trans") = getTanggal()
            '    rw_hist.Item("create_date") = getTanggal()
            '    rw_hist.Item("create_by") = username

            '    ds_tbh.Tables("_tbh").Rows.Add(rw_hist)
            'End While
            'sqdrx.Close()

        End If

        'For Each row1 As DataRow In ds_tbh.Tables("_tbh").Rows
        '    row1.Item("no_trans") = row.Item("no_trans")
        '    row1.Item("tgl_trans") = getTanggal()
        '    row1.Item("create_date") = getTanggal()
        '    row1.Item("create_by") = username
        'Next

        'gc_byr_piu.DataSource = ds_tbh.Tables("_tbh")
        'gv_byr_piu.BestFitColumns()


    End Sub
    Public Sub warningTGK()
        If STATE = "ADD" Then
            'cek_tgk = True
            MsgBox("Anggota masih punya Tunggakan/Pinjaman Outstanding(belum lunas)", MsgBoxStyle.Exclamation)


        End If

    End Sub
    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        'recov, pokok, t_bunga, bsr_pjm, tempo = 0

        If e.KeyCode = Keys.Enter Then
            If tx1_LamaPJM.Text <> "" And TE_BsrPJM.EditValue <> vbNullString And te_bg.EditValue <> vbNullString Then
                tempo = tx1_LamaPJM.Text

                If taunan = True Then
                    If tx1_LamaPJM.Text >= 3 Then
                        MsgBox("Tempo tidak boleh lebih dari 3 tahun. 3x TAT/BONUS/TAT !!", MsgBoxStyle.Critical)
                        tx1_LamaPJM.Text = 1
                        Exit Sub
                    End If
                    'ElseIf jns_krd = "KHS " Then
                    'If tx1_LamaPJM.Text >= 7 Then
                    '    MsgBox("Pinjaman Khusus tidak boleh lewat dari 6 bulan !!", MsgBoxStyle.Critical)
                    '    tx1_LamaPJM.Text = 3
                    '    Exit Sub
                    'End If
                End If

                If jns_krd = "KHS " Then
                    If cb_lock.Checked = False Then
                        prv_khusus()
                    End If
                    cicilan_khusus()

                ElseIf jns_krd = "BNS " Then
                    If cb_lock.Checked = False Then
                        prv_bns()
                    End If
                    cicilan_bns()

                ElseIf jns_krd = "BRG " Then
                    cicilan_brg()
                    lb1_admx.Text = "Fee Kop"

                Else
                    If cb_lock.Checked = False Then
                        prv_all()
                    End If
                    hitung_cicilan() '#HITUNG CICILAN NORMA

                    'buat kartu piu
                End If
                'If hit = True Then
                '    hitung_cicilan()
                'Else

                'End If
                'bersihkan()
                tx1_ket.Focus()
                'buat_kartu()
            End If
        End If

    End Sub
    Public Sub buat_kartu()
        If taunan = True Then Exit Sub



        'byr_piu = 0m 
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()
        Dim pk_pinj As Double = bsr_pjm
        Dim j_bln As Integer
        Dim ang_kart As Double
        'Dim nm_bln As String
        Dim k_bln As Integer = Today.Month
        Dim k_thn As Integer = Today.Year
        'Dim jt_tmpo As Date

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

            ''If j_bln = 4 Then
            ''    rw_kartu.Item("c_bns") = pot_bns
            ''    bsr_pjm = bsr_pjm - pot_bns
            ''ElseIf j_bln = 7 Then
            ''    rw_kartu.Item("c_thr") = pot_thr
            ''    bsr_pjm = bsr_pjm - pot_thr
            ''ElseIf j_bln = 12 Then
            ''    rw_kartu.Item("c_tat") = pot_tat
            ''    bsr_pjm = bsr_pjm - pot_tat
            ''End If


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

    'If j_bln > 12 AndAlso j_bln < 25 Then
    '    j_bln = (k_bln + (y + 1)) - 12
    '    'If j_bln Mod 12 = 0 Then
    '    MsgBox("pas")
    '    'If j_bln = 24 Then
    'ElseIf j_bln > 12 AndAlso j_bln < 25 Then
    '    j_bln = (k_bln + (y + 1)) - 24
    '    'ElseIf j_bln = 36 Then
    '    j_bln = (k_bln + (y + 1)) - 36

    '    'End If

    'End If
    'If k_thn = Today.Year Then
    '    k_thn = k_thn + 1
    'End If



    Public Sub cicilan_brg()
        pokok_pertama = Math.Floor(bsr_pjm / tempo)
        pokok_asli = Math.Floor(bsr_pjm / tempo)
        pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
        pokok2_asli = bsr_pjm - (pokok_pertama * (tempo - 1))
        t_bunga = bsr_pjm * (bunga / 100)
        total = t_bunga + bsr_pjm
        'If cb_prv.Checked = False Then
        '    prv = 0
        'End If

        angs = t_bunga + pokok_pertama


        'adm =


        bsr_pjm = TE_BsrPJM.EditValue
        pokok_asli = Math.Floor(bsr_pjm / tempo)
        pokok2_asli = bsr_pjm - ((Math.Floor(bsr_pjm / tempo)) * (tempo - 1))
        ang_baru = t_bunga + (Math.Floor(bsr_pjm / tempo))
        'lama_pot = 
        'pot = gv_tambahan.Columns("nilai").SummaryItem.SummaryValue
        t_pot = 0
        nett = bsr_pjm - (prv + adm)
        '##JUMLAH TERIMA
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_ang_baru.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    Public Sub cicilan_bns()
        Dim sisa, hr_ini, jml_hr, jm_hr_lalu, jm_hr_dbt, jm_hr_today, jm_hr_bln, jm_bl_lalu, jm_bl_skrg, jm_bl_dbt, tgl_uplod, blnx, bln_skrg, bln_dbt As Integer
        tempo = tx1_LamaPJM.Text
        bsr_pjm = TE_BsrPJM.EditValue
        pokok_pertama = bsr_pjm
        'If bsr_pjm > bts_prv_bns1 Then
        'If cb_prv.Checked = True Then

        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'tgl_uplod_lalu = "01/" & Month(dt_tgl.EditValue) & "/" & Year(dt_tgl.EditValue)
        Dim sqdr1 As SqlDataReader = New SqlCommand("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
                                                        " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tgl_dbt & "',103)),0)))+1 as ke_blnDebt, " & _
                                                         " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tgl_dbt & "',103) )+1 as jm_hr_dbt,  " & _
                                                       " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & tgl_1_trans & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) )+1 as jm_hr_today,  " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_bln, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
                                                        " day(convert(date,'" & dt_tgl.EditValue & "',103)) as hr_ini, " & _
                                                        "DAY(DATEADD(DD,-1,DATEADD(MM,DATEDIFF(MM,-1,convert(date,'" & de_debet.EditValue & "',103)),0))) as jm_bl_dbt, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103))+1,0))) as jm_bl_skrg  ", sqlconn).ExecuteReader
        Clipboard.SetText("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
                                                        " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tgl_dbt & "',103)),0)))+1 as ke_blnDebt, " & _
                                                         " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tgl_dbt & "',103) )+1 as jm_hr_dbt,  " & _
                                                       " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & tgl_1_trans & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) )+1 as jm_hr_today,  " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_bln, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
                                                        " day(convert(date,'" & dt_tgl.EditValue & "',103)) as hr_ini, " & _
                                                        "DAY(DATEADD(DD,-1,DATEADD(MM,DATEDIFF(MM,-1,convert(date,'" & de_debet.EditValue & "',103)),0))) as jm_bl_dbt, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103))+1,0))) as jm_bl_skrg  ")
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
        Dim hrdbt As Integer
        'bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
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
        'If tgldbet >= 25 Then
        '    bg_jln = 0
        'End If
        nett = bsr_pjm - bg_jln - prv - adm
        '##JUMLAH TERIMA
        'If cb_byr_kartu.Checked = True Then
        '    nett = 0
        'End If

        lb_bg_jln.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bunga.Text = 0
        'lb1_total_ang.Text = 0
        'lb1_pokok.Text = 0
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    Public Sub prv_bns()
        Dim totalpjm As Double
        If id_jab = "1" Then 'jika kary BCA
            If prv_lama = True Then
                totalpjm = bsr_pjm + jml_pjmLama
                bts = bts_prv_bns1
                If totalpjm >= bts_prv_bns1 Then
                    adm = adm_default
                    prv = (totalpjm - bts) * (1 / 100)
                Else
                    adm = 0
                    prv = 0
                End If
            Else
                If bsr_pjm > bts_prv_bns1 Then
                    'cb_prv.Checked = True
                    ';adm = bts_admin1
                    bts = bts_prv_bns1
                    prv = (bsr_pjm - bts) * (1 / 100)

                Else
                    adm = 0
                    prv = 0
                End If
            End If
        Else 'jika 'non BCA
            If bsr_pjm > bts_prv_bns2 Then
                'cb_prv.Checked = True
                adm = adm_default
                bts = bts_prv_bns2
                prv = (bsr_pjm - bts) * (1 / 100)
            Else
                adm = 0
                prv = 0
            End If
        End If
    End Sub
    Public Sub prv_khusus()
        If id_jab = "1" Then 'jika kary BCA
            If bsr_pjm > bts1 Then
                'cb_prv.Checked = True
                adm = adm_default
                prv = (bsr_pjm - bts) * (1 / 100)
            Else
                adm = 0
                prv = 0
            End If
        Else 'jika kary non BCA
            If bsr_pjm > bts2 Then
                'cb_prv.Checked = True
                adm = adm_default
                prv = (bsr_pjm - bts) * (1 / 100)
            Else
                adm = 0
                prv = 0
            End If
        End If

    End Sub
    Public Sub prv_all()
        Dim totalpjm As Double
        If id_jab = "1" Then 'jika kary BCA
            If prv_lama = True Then
                totalpjm = bsr_pjm + jml_pjmLama
                If totalpjm >= bts1 Then
                    adm = adm_default
                    prv = bsr_pjm * (1 / 100)
                    'prv = (totalpjm - bts1) * (1 / 100)
                Else
                    adm = 0
                    prv = 0
                End If

            Else
                If bsr_pjm >= bts1 Then
                    adm = adm_default
                    prv = (bsr_pjm - bts1) * (1 / 100)
                Else
                    adm = 0
                    prv = 0
                End If
            End If

        Else 'jika kary non BCA
            If bsr_pjm > bts2 Then
                adm = adm_default
                prv = (bsr_pjm - bts2) * (1 / 100)
            Else
                adm = 0
                prv = 0
            End If
        End If

    End Sub

    'Public Sub prv_all()
    '    'If prv_lama = False Then jml_pjmLama(+bsr_pjm)
    '    If id_jab = "1" Then 'jika kary BCA
    '        If bsr_pjm >= bts1 Then

    '            adm = adm_default
    '            prv = (bsr_pjm - bts1) * (1 / 100)
    '        Else

    '            prv = (bsr_pjm - (bts1 + jml_pjmLama)) * (1 / 100)


    '    Else
    '            adm = 0
    '            prv = 0
    '        End If
    '    Else 'jika kary non BCA
    '        If bsr_pjm > bts2 Then
    '            adm = adm_default
    '            prv = (bsr_pjm - bts2) * (1 / 100)
    '        Else
    '            adm = 0
    '            prv = 0
    '        End If
    '    End If
    '    'End If
    'End Sub
    Public Sub cicilan_khusus()
        Dim sisa, jml_hr, jm_hr_lalu, jm_hr_dbt, jm_hr_today, jm_hr_bln, jm_bl_lalu, jm_bl_dbt, jm_bl_skrg, hr_ini, tgl_uplod, blnx, bln_skrg, bln_dbt As Integer
        tempo = tx1_LamaPJM.Text
        bsr_pjm = TE_BsrPJM.EditValue
        pokok_pertama = bsr_pjm



        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'tgl_uplod_lalu = "01/" & Month(dt_tgl.EditValue) & "/" & Year(dt_tgl.EditValue)
        Dim sqdr1 As SqlDataReader = New SqlCommand("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
                                                       " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tgl_dbt & "',103)),0)))+1 as ke_blnDebt, " & _
                                                       " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tgl_dbt & "',103) )+1 as jm_hr_dbt,  " & _
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
            jm_hr_dbt = sqdr1.Item("jm_hr_dbt")
            jm_hr_today = sqdr1.Item("jm_hr_today")
            jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
            jm_bl_dbt = sqdr1.Item("jm_bl_dbt")
            jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
            hr_ini = sqdr1.Item("hr_ini")
        End If
        sqdr1.Close()


        jml_hr = jm_bl_skrg - (hr_ini - 1)
        bg_bns = bsr_pjm * (bunga / 100)
        t_bunga = 0 'ga pake bunga

        'bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
        Dim hrdbt As Integer
        'bg_jln = (bg_bns * bln_april) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_today))
        If bln_dbt = 0 Then
            hrdbt = jml_hr - hr_ini
            bg_jln = ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt
            'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_bln))
        ElseIf bln_dbt = 1 Then
            'bg_jln = (bg_bns * (bln_dbt)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr)
            bg_jln = (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * jm_hr_dbt + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr))
        ElseIf bln_dbt > 1 Then
            'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
            'bg_jln = (bg_bns * (bln_dbt - 1)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * (jm_hr_dbt + 1))
            bg_jln = (bg_bns * (bln_dbt - 1)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * (jm_hr_dbt))
        End If
        'If tgldbet >= 25 Then
        '    bg_jln = 0
        'End If
        nett = bsr_pjm - bg_jln - prv - adm
        lb_bg_jln.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        '### tanpa pakai bunga berjalan, flat
        'If cb_prv.Checked = False Then
        '    prv = 0
        'End If
        't_bunga = bsr_pjm * (bunga / 100)
        'nett = bsr_pjm - (t_bunga * tempo) - prv - adm
        '##JUMLAH TERIMA

        'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    'Public Sub hitung_awal()
    '    'Dim  As Double 'sbg pembanding 'gv_tambahan.Columns("nilai").SummaryItem.SummaryValue = 0
    '    If TE_BsrPJM.EditValue <> vbNullString Or tx1_LamaPJM.Text <> "" Or gv_tambahan.Columns("nilai").SummaryItem.SummaryValue = 0 Then
    '        'MsgBox("hitung awal")
    '        tempo = tx1_LamaPJM.Text
    '        bsr_pjm = TE_BsrPJM.EditValue
    '        pokok_pertama = Math.Floor(bsr_pjm / tempo)
    '        pokok_asli = Math.Floor(bsr_pjm / tempo)
    '        pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
    '        pokok2_asli = bsr_pjm - (pokok_pertama * (tempo - 1))
    '        t_bunga = bsr_pjm * (bunga / 100)
    '        total = t_bunga + bsr_pjm

    '        'prv = bsr_pjm * (1 / 100)
    '        angs = t_bunga + pokok_pertama
    '        adm = lb_admin.Text


    '        lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_ang_baru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))

    '        lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb1_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

    '        'tampilan sebelah
    '        lb_tpokok.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb_tempo_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

    '        lb_tempo.Text = tx1_LamaPJM.Text
    '        lb_tempo2.Text = tx1_LamaPJM.Text
    '        lb_tempo3.Text = tx1_LamaPJM.Text

    '        'tx1_angs.Text = pokok
    '        'tx1_bunga.Text = bsr_pjm * bunga
    '        'tx1_t_angs.Text = t_bunga + pokok

    '        'cek_recovery()
    '        lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        nett = bsr_pjm - (prv + adm)
    '        '##JUMLAH TERIMA
    '        lb1_terima.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    End If
    '    'hit = False
    'End Sub

    Public Sub hitung_cicilan()
        If tx1_LamaPJM.Text = "" And TE_BsrPJM.EditValue = vbNullString Then
            Exit Sub
        End If
        pot_bns = TE_bns.EditValue
        pot_thr = TE_thr.EditValue
        pot_tat = TE_tat.EditValue
        'MsgBox(dt_tgl.EditValue)
        'pot_hrs=tot
        pot = pot_bns + pot_thr + pot_tat
        lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lama_pjm = tx1_LamaPJM.Text
        tempo_pot = lama_pjm / 12
        t_pot = pot * tempo_pot 'lama bulan/12 = setehun/pertehun 'lama bulan/12 = setehun/pertehun


        hit = False
        tempo = tx1_LamaPJM.Text
        bsr_pjm = TE_BsrPJM.EditValue


        'xxxxxx
        pokok_pertama = Math.Floor(bsr_pjm / tempo)
        pokok_asli = Math.Floor(bsr_pjm / tempo)
        pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
        pokok2_asli = bsr_pjm - (pokok_pertama * (tempo - 1))
        t_bunga = bsr_pjm * (bunga / 100)
        total = t_bunga + bsr_pjm
        'If cb_prv.Checked = False Then
        '    prv = 0
        'End If

        angs = t_bunga + pokok_pertama


        'adm =


        bsr_pjm = TE_BsrPJM.EditValue
        pokok_asli = Math.Floor(bsr_pjm / tempo)
        pokok2_asli = bsr_pjm - ((Math.Floor(bsr_pjm / tempo)) * (tempo - 1))
        angs = t_bunga + (Math.Floor(bsr_pjm / tempo))
        'lama_pot = 
        'pot = gv_tambahan.Columns("nilai").SummaryItem.SummaryValue
        t_pot = 0
        If TE_bns.EditValue > 0 Or TE_thr.EditValue > 0 Or TE_tat.EditValue > 0 Then
            tp_bns = lama_pjm / 12
            t_pot = pot * tp_bns 'lama bulan/12 = setehun/pertehun

            'lb_tempo_pot.Text = t_pot
            If tempo > 12 Then
                prthn = t_pot / tempo_pot
                lb_selama.Text = tempo_pot
            End If

            'lb_tp_bns.Text = tp_bns.ToString("n0")
        End If

        'bersihkan()
        If angs < t_bunga Then
            MsgBox("Angsuran Tidak boleh lebih kecil dari Bunga", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'ang_baru = bsr_ccl_baru - bg_lama
        't_bunga = bsr_ccl_baru * bunga

        'pokok_br()

        't_pk_br = bsr_pjm - t_pot
        pk_br = bsr_pjm - t_pot
        t_pk_baru = pk_br * tx1_LamaPJM.Text 'dikalikan tempo sisa lama pinjam
        'pot_hrs = sisa_pk_lama - t_pk_baru
        pokok_akhir = sisa_pk_lama - (pokok_br * (tx1_LamaPJM.Text - 1))
        'pokok_akhir = sisa_pk_lama - t_pk_baru
        t_pk_br_akhir = t_pk_baru + pokok_akhir
        ang_baru = pokok_br + bg_baru
        total = t_pot + t_pk_baru

        'lb_pot_harus.Text = pot_hrs.ToString("c", New Globalization.CultureInfo("id-ID", False))

        lb_tpot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

        lb_total2.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_prthn.Text = prthn.ToString("c", New Globalization.CultureInfo("id-ID", False))

        pokok_pertama = Math.Floor(pk_br / tempo)
        pokok_akhir = pk_br - (pokok_pertama * (tempo - 1))
        t_pk_br = (pokok_pertama * (tempo - 1)) + pokok_akhir
        ang_baru = pokok_pertama + t_bunga
        total = t_pot + t_pk_br

        'lb_tempo_pot2.Text = tempo_pot

        'lb_tempo.Text = tx1_LamaPJM.Text
        'lb_tempo2.Text = tx1_LamaPJM.Text
        'lb_tempo3.Text = tx1_LamaPJM.Text


        ' lb_pkBaru.Text = pokok_br.ToString("c", New Globalization.CultureInfo("id-ID", False))x
        'lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_tpokok.Text = t_pk_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_tpokok.Text = t_pk_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_tempo_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_ang_baru.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_ang_baru2.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))

        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))

        'lb_bgBaru.Text = bg_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))'lb1_bg_baru.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_angBaru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_RPangLama.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        nett = bsr_pjm - (prv + adm)
        '##JUMLAH TERIMA
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))

        'End If
        buat_kartu()
    End Sub

    'Private Sub gv_tambahan_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    If Lue_SetPjm.EditValue <> vbNullString Then
    '        If e.Column Is tbh_nilai Then
    '            pot = gv_tambahan.Columns("nilai").SummaryItem.SummaryValue
    '            t_pot = gv_tambahan.Columns("nilai").SummaryItem.SummaryValue * (tx1_LamaPJM.Text / 12) 'lama 
    '            hitung_cicilan()
    '        End If
    '    End If

    'End Sub

    'Private Sub gv_tambahan_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    'End Sub

    Private Sub tx1_LamaPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx1_LamaPJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TE_BsrPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_BsrPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsr_pjm = TE_BsrPJM.EditValue
            Cari()

            tx1_LamaPJM.Focus()
            Select Case Lue_SetPjm.EditValue 'create tahun
                Case "BRG "
                    adm = bsr_pjm * 0.1
                    TE_adm.EditValue = adm
                Case "NOR "
                    If TE_BsrPJM.EditValue > plfnd Then
                        TE_BsrPJM.EditValue = plfnd
                        MsgBox("Normatif tidak boleh melebihi plafond", MsgBoxStyle.Exclamation)
                        TE_BsrPJM.Focus()
                        Exit Sub
                    End If
                Case vbNullString
                    MsgBox("Pilihan Jenis Pinjaman Belum di pilih", MsgBoxStyle.Exclamation)

            End Select


            If Lue_SetPjm.EditValue = "BRG " Then
                adm = bsr_pjm * 0.1
                TE_adm.EditValue = adm
            ElseIf Lue_SetPjm.EditValue = "NOR " Then

            ElseIf Lue_SetPjm.EditValue = "NOR " Then

            End If
        End If
    End Sub

    Private Sub TE_BsrPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_BsrPJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub bt_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
            hitung_all()
            save_click(False)
        Else
            MsgBox("Isian blm lengkap, cek Besar Pinjaman,Tenor, dan NIP sudah dipilih", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Public Sub hitung_all()
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
            If taunan = True Then
                If tx1_LamaPJM.Text >= 3 Then

                    MsgBox("Tempo tidak boleh lebih dari 3 tahun. 3x TAT/BONUS/TAT !!", MsgBoxStyle.Critical)
                    tx1_LamaPJM.Text = 1
                    Exit Sub
                End If
            ElseIf jns_krd = "KHS " Then
                If tx1_LamaPJM.Text >= 7 Then
                    MsgBox("Pinjaman Khusus tidak boleh lewat dari 6 bulan !!", MsgBoxStyle.Critical)
                    tx1_LamaPJM.Text = 3
                    Exit Sub
                End If
            End If

            If jns_krd = "KHS " Then
                cicilan_khusus()
            ElseIf jns_krd = "BNS " Then
                cicilan_bns()
            ElseIf jns_krd = "BRG " Then
                cicilan_brg()
            Else
                hitung_cicilan() '#HITUNG CICILAN NORMAL
            End If

        End If

    End Sub

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
    '    If cb_prv.Checked = True Then
    '        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
    '            If jns_krd = "KHS " Then
    '                cicilan_khusus()
    '            ElseIf jns_krd = "BNS" Then
    '                cicilan_bns()
    '            Else
    '                hitung_cicilan() '#HITUNG CICILAN NORMAL
    '            End If
    '        End If
    '    Else
    '        prv = 0
    '        nett = bsr_pjm - bg_jln - prv - adm
    '        TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    End If
    '    'Else
    '    'lb1_prvs.Text = 0

    '    'bsr_pjm = TE_BsrPJM.EditValue
    '    'nett = bsr_pjm - (prv + adm_cek)
    '    'End If


    '    'Else

    '    '##JUMLAH TERIMA
    '    lb1_terima.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))

    'End Sub

    'Private Sub cb_adm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cb_adm.Checked = True Then
    '        'adm = bsr_pjm * (1 / 100)
    '        adm_cek = adm
    '        lb1_adm.Text = adm
    '    Else
    '        lb1_adm.Text = 0
    '        adm = 0
    '    End If
    '    If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
    '        If jns_krd = "KHS  " Then
    '            cicilan_khusus()
    '        Else
    '            hitung_cicilan()
    '        End If
    '    Else
    '        bsr_pjm = TE_BsrPJM.EditValue
    '        nett = bsr_pjm - (prv + adm)
    '        '##JUMLAH TERIMA
    '        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    End If
    'End Sub


    Private Sub gv_tambahan_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        hitung_cicilan()
    End Sub

    Private Sub tx1_ket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_ket.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_noform.Focus()
        End If
    End Sub
    Private Sub txb_noform_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_noform.KeyDown
        If e.KeyCode = Keys.Enter Then
            TE_net.Focus()
        End If
    End Sub

    Private Sub TE_net_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_net.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_norek_cair.Focus()
        End If
    End Sub
    Private Sub txb_norek_cair_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_norek_cair.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_norek.Focus()
        End If
    End Sub

    Private Sub txb_norek_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_norek.KeyDown
        If e.KeyCode = Keys.Enter Then
            txb_norek2.Focus()
        End If
    End Sub

    Private Sub txb_norek2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_norek2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If taunan = True Then
                'bt_hitung.Focus()
                save_click(False)
            Else
                TE_bns.Focus()
            End If

        End If
    End Sub

    Private Sub de_debet_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles de_debet.EditValueChanged
        tgl_dbt = de_debet.EditValue
        tgl_1_dbt = "01/" & Month(de_debet.EditValue).ToString & "/" & Year(de_debet.EditValue).ToString
        If TE_BsrPJM.EditValue <> vbNullString And Lue_SetPjm.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            hitung_all()
        End If
    End Sub
    Private Sub dt_tgl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_tgl.EditValueChanged
        Dim tgle As Date
        tgle = dt_tgl.EditValue
        tgldbet = tgle.Day.ToString
        tgl_1_trans = "01/" & Month(dt_tgl.EditValue).ToString & "/" & Year(dt_tgl.EditValue).ToString
        If tgle.Day > Today.Day Then
            MsgBox("Tanggal tidak boleh melebihi hari ini,(maju)", MsgBoxStyle.Exclamation)
            dt_tgl.EditValue = Today
        End If
        'tgl_uplod_lalu = "25/" & Month(de_debet.EditValue) & "/" & Year(de_debet.EditValue)


    End Sub

    'Private Sub LUE_nama_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LUE_nama.DoubleClick
    '    Cari()
    '    cek_hist()
    '    'cek_agenda()
    '    'cek_notran()
    '    TE_BsrPJM.Focus()
    'End Sub

    'Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    'End Sub



    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        cek_tgk = False
        If e.KeyCode = Keys.Enter Then
            Cari()
            cek_hist()
            TE_BsrPJM.Focus()
            cek_hut()
        End If
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
                hitung_all()

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
                hitung_all()

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
                hitung_all()
            End If
            save_click(False)
        End If
    End Sub


    'Private Sub cb_byr_kartu_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If cb_byr_kartu.Checked = True Then
    '        lb1_terima.Text = 0
    '    Else
    '        hitung_all()
    '    End If
    'End Sub


    Private Sub te_bg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles te_bg.EditValueChanged
        bunga = te_bg.EditValue
        hitung_all()
    End Sub

    'Private Sub gv_byr_piu_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv_byr_piu.InitNewRow
    '    gv_byr_piu.GetRow(e.RowHandle).item("no_seq") = gv_byr_piu.RowCount + 1
    'End Sub

    Private Sub gv_byr_piu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Delete Selected Row ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'For Each dr As DataRow In ds_tbh.Tables("_tbh").Rows
                '    dr.Delete()
                'Next
                'gv_byr_piu.DeleteSelectedRows()

            End If
        End If
    End Sub

    Private Sub gv_byr_piu_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        hit_centang()
    End Sub
    Public Sub hit_centang()
        byr_piu = 0
        For Each rw_hist In ds_tbh.Tables("_tbh").Select("cek_byr='Y'")
            byr_piu += rw_hist.Item("nilai")
        Next
        hitung_all()
        'TE_jml_byr.EditValue = byr_piu
        nett = nett - byr_piu
        TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    Private Sub TE_jml_byr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'nett = nett - TE_jml_byr.EditValue
            TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
    End Sub


    Private Sub btCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LUE_nama.EditValue = vbNullString Then
            MsgBox("ketik ID NIP atau NIP belum di pilih", MsgBoxStyle.Exclamation)
        ElseIf LUE_nama.EditValue <> vbNullString Then
            Cari()
        End If
    End Sub

    'Private Sub cb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cb_all.Checked = True Then
    '        For i As Integer = 0 To gv_byr_piu.RowCount - 1
    '            gv_byr_piu.SetRowCellValue(i, "cek_byr", "Y")
    '        Next

    '    ElseIf cb_all.Checked = False Then
    '        For i As Integer = 0 To gv_byr_piu.RowCount - 1
    '            gv_byr_piu.SetRowCellValue(i, "cek_byr", "T")
    '        Next
    '    End If
    '    hit_centang()
    'End Sub



    Private Sub TE_prv_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_prv.EditValueChanged
        prv = TE_prv.EditValue
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            nett = bsr_pjm - bg_jln - prv - adm
            TE_net.EditValue = nett
        End If

    End Sub

    Private Sub TE_net_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_net.EditValueChanged
        nett = TE_net.EditValue
    End Sub

    Private Sub TE_adm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_adm.EditValueChanged
        adm = TE_adm.EditValue
        If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            nett = bsr_pjm - bg_jln - prv - adm
            TE_net.EditValue = nett
        End If

        'If TE_BsrPJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
        '    If jns_krd = "KHS " Then
        '        cicilan_khusus()
        '    ElseIf jns_krd = "BNS" Then
        '        cicilan_bns()
        '    Else
        '        hitung_cicilan()
        '    End If
        'Else
        '    bsr_pjm = TE_BsrPJM.EditValue
        '    nett = bsr_pjm - (prv + adm)
        '    '##JUMLAH TERIMA
        '    TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'End If
    End Sub



    Private Sub TE_prv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_prv.KeyDown
        If e.KeyCode = Keys.Enter Then
            TE_adm.Focus()
        End If
    End Sub

    Private Sub TE_adm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_adm.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx1_ket.Focus()
        End If
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

    'Private Sub Gv_hist_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles Gv_hist.RowUpdated
    '    jml_pjmLama = Gv_hist.Columns("nilai").SummaryItem.SummaryValue
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lb_notrans.Text <> "" Then
            callReport(App_Path() & "\report\komite.rpt", "", "n_trn=" & lb_notrans.Text, False, False)
        Else
            MsgBox("No Transaksi Kosong", MsgBoxStyle.Exclamation)
        End If

    End Sub

    'Private Sub TE_pokok_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        pokok_pertama = TE_pokok.EditValue
    '        hitung_all()
    '    End If
    'End Sub
End Class

