'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmKreditCustom
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public _notrans As String = "xxx"
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, notran_lama, ntran_cek, notran_cek, id_anggota, kd2, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_cari2, dso2, ds_cari, ds_cari1, dsNama, ds_gdg1, ds_gdg2, dsjab As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private sisaAng_baru, pokok_pertama, tempo_pt As Integer
    Private DA, DA1, DA2, DALOOKUP, DALOOKUP2, daJab, daNama, DALOOKUP1, DA_gdg1, da_tbh As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, bsr_ccl_baru, sisa_pk_lama, pokok_akhir, selisih_pokok, lama_ang, sisaAng_lama, angs, adm, denda, t_bunga, t_pot, pot, pot_bns, pot_thr, pot_tat, pot_min, total, recov, prv, bg_lama, ang_lama, pk_lama, bg_baru, ang_baru, t_pk_br, pokok_br, jml_trima As Double
    Private BTRAN As SqlTransaction
    Public stat_tran, stat_rec, cust As Boolean
    Public idJab As String


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        'btCari.Enabled = True
        setStatus()
        bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub
    Public Sub cetak_click()
        callReport(App_Path() & "\report\pengajuan.rpt", "", "no_trn=" & lb_notrans.Text)
    End Sub
    Private Sub bersihkan()

        tx_id.Text = ""
        lb_admin.Text = 0
        cb_prv.Checked = False
        'cb_pot.Checked = False
        lb_bunga.Text = 0
        lb_plafon.Text = 0
        lb_denda.Text = 0
        tx1_LamaPJM.Text = ""
        lb_tpot.Text = ""
        lb_pkBaru.Text = ""
        TE_Bsr_PJM.EditValue = vbNullString
        LUE_nama.EditValue = vbNullString
        TE_CustomAngs.EditValue = vbNullString
        lb1_terima.Text = ""
        lb_tpot.Text = ""
        lb_tpokok.Text = ""
        lb1_adm.Text = ""
        lb1_bunga.Text = ""
        lb1_pokok.Text = ""
        lb1_RPangLama.Text = ""
        lb1_prvs.Text = ""
        lb_alamat.Text = ""
        lb_kota.Text = ""
        lb_t_hit.Text = ""
        tx1_ket.Text = ""
        lb_potmin.Text = ""

        lb1_RPangLama.Text = ""
        lb_tempo_pot.Text = ""
        lb_tempo2.Text = ""
        lb_tempo3.Text = ""
        lb_tempo.Text = ""
        lb1_RPangLama.Text = ""

        te_bg.EditValue = vbNullString

        If Not dso2.Tables("_agd") Is Nothing Then dso2.Tables("_agd").Clear()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
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

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,JML_BUNGA+JML_POKOK as ang from kredit where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        'da_tbh = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_pot where no_trans='" & kode & "'", sqlconn))
        'da_tbh.Fill(ds_tbh, "_tbh")
        'gc_tambahan.DataSource = ds_tbh.Tables("_tbh")

        If dSO.Tables("_krd").Rows.Count > 0 Then

            'If ds_tbh.Tables("_tbh").Rows.Count > 0 Then
            '    cb_pot.Checked = True
            '    'gc_tambahan.Enabled = True
            'End If
            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)
            tx_id.Text = rwm("nasabah_id").ToString
            LUE_nama.EditValue = rwm("nasabah_id").ToString
            'LuE_Jab.EditValue = rwm("id_jab").ToString
            lb_notrans.Text = rwm("no_trans").ToString
            Lue_tipe.EditValue = rwm("tipe").ToString
            tx_id.Text = rwm("nasabah_id").ToString
            TE_Bsr_PJM.EditValue = rwm("JML_PINJAMAN").ToString
            tx1_LamaPJM.Text = rwm("LAMA_ANGS").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            lb1_pokok.Text = rwm("JML_POKOK").ToString
            lb1_bunga.Text = rwm("JML_BUNGA").ToString
            lb1_adm.Text = rwm("JML_ADMIN").ToString
            'MsgBox(rwm("stat_provisi").ToString)
            cb_prv.Checked = IIf(rwm("stat_provisi") = True, cb_prv.Checked = True, cb_prv.Checked = False)
            lb1_prvs.Text = rwm("JML_PROVISI").ToString
            lb_t_hit.Text = rwm("JML_PINJAMAN").ToString
            TE_CustomAngs.Text = rwm("ang").ToString

            pot_bns = IIf(rwm.IsNull("pot_bns"), 0, rwm("pot_bns").ToString) 'rwm.Item("pot_bns")
            pot_thr = IIf(rwm.IsNull("pot_thr"), 0, rwm("pot_thr").ToString) 'rwm.Item("pot_thr")
            pot_tat = IIf(rwm.IsNull("pot_tat"), 0, rwm("pot_tat").ToString) 'rwm.Item("pot_tat")

            pot = pot_bns + pot_thr + pot_tat
            t_pot = pot * (tx1_LamaPJM.Text / 12) 'lama bulan/12 = setehun/pertehun


            angs = rwm("ang")
            pokok_pertama = rwm("JML_POKOK")
            t_bunga = rwm("JML_BUNGA")
            adm = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            bsr_pjm = rwm("JML_PINJAMAN")
            pk_lama = rwm("JML_POKOK")
            t_pk_br = rwm("sisa_pokok_after_potong")
            total = t_pot + t_pk_br

            'lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_ang_baru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'tampilan sebelah
            lb_tpokok.Text = t_pk_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_tpot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

            lb_tempo.Text = tx1_LamaPJM.Text
            lb_tempo2.Text = tx1_LamaPJM.Text
            lb_tempo3.Text = tx1_LamaPJM.Text
            tempo_pt = tx1_LamaPJM.Text / 12
            lb_tempo_pot.Text = tempo_pt

            'lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'nett = bsr_pjm - (prv + adm)
            ''##JUMLAH TERIMA
            'lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If



    End Sub
    Public Sub save_click()

        'cek_notran()
        If total < TE_Bsr_PJM.EditValue Then
            MsgBox("Nilai Perhitungan harus sama atau melebihi Besar Pengajuan Pinjaman", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If LUE_nama.EditValue = vbNullString Or TE_CustomAngs.EditValue = vbNullString Then
            MsgBox("Lengkapi data, banyak yang belum di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If ds_tbh.Tables("_tbh").Rows.Count = 0 Or gv_tambahan.Columns("nilai").SummaryItem.SummaryValue = 0 Then
        '    MsgBox("Harap mengisi terlebih dahulu Komponen Tambahan Recovery Potongan Bonus, TAT dan THR !!! " & vbCrLf & "atau Total Keseluruhan Nilai Potongan =Rp.0,")
        '    Exit Sub
        If pot > 0 And pot_min > t_pot Then
            MsgBox("Potongan harus lebih diatas default= " & pot_min, MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()


    End Sub
    Public Sub simpan()

        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            row = dSO.Tables("_krd").NewRow

            row.Item("no_trans") = get_notran()
            'row.Item("no_ref") = notran_lama
            'MsgBox(id_anggota + jns + blthn())
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            row.Item("cetak_ke") = 0
            'row.Item("blthn") = blthn()
            row.Item("tgl_trans") = getTanggal()
            lb_notrans.Text = row.Item("no_trans")

        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_krd").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If

        row.Item("kd_kredit") = "CUS" '### kode kredit, mts atau Recovery

        row.Item("NASABAH_ID") = tx_id.Text
        row.Item("jenis") = Lue_SetPjm.EditValue
        row.Item("tipe") = Lue_tipe.EditValue
        'row.Item("tipe") = Lue_tipe.EditValue
        row.Item("JML_PINJAMAN") = TE_Bsr_PJM.EditValue
        row.Item("JML_DENDA") = lb_denda.Text
        row.Item("JML_ADMIN") = adm
        row.Item("JML_POKOK") = pokok_br
        row.Item("JML_BUNGA") = t_bunga
        row.Item("JML_TERIMA") = jml_trima
        row.Item("bunga") = lb_bunga.Text

        row.Item("JML_PROVISI") = prv
        row.Item("sisa_pokok") = TE_Bsr_PJM.EditValue
        row.Item("sisa_pokok_after_potong") = t_pk_br
        row.Item("TGL_PENGAJUAN") = getTanggal()
        row.Item("STATUS_AKTIF") = 1
        row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
        row.Item("sisa_angs") = tx1_LamaPJM.Text
        row.Item("TGL_TAGIHAN") = "25"
        row.Item("status_lunas") = "BELUM"
        row.Item("stat_provisi") = IIf(cb_prv.Checked, 1, 0)
        'MsgBox
        row.Item("bunga") = lb_bunga.Text
        row.Item("approve1_by") = "OutStanding"
        row.Item("approve2_by") = "OutStanding"
        row.Item("approve3_by") = "OutStanding"
        row.Item("approve4_by") = "OutStanding"
        row.Item("stat_approve") = 0
        row.Item("stat_cair") = 0
        row.Item("stat_cair_approve") = 0
        row.Item("KETERANGAN") = tx1_ket.Text
        row.Item("stat_kabagSP") = "Outstanding"
        row.Item("rec_lunas") = 0
        row.Item("pot_bns") = TE_bns.EditValue
        row.Item("pot_thr") = TE_thr.EditValue
        row.Item("pot_tat") = TE_tat.EditValue
        row.Item("stat_pot_bns") = 0
        row.Item("stat_pot_thr") = 0
        row.Item("stat_pot_tat") = 0
        'If stat_rec = True Then
        '    'row.Item("rec_sisa_kredit") = txr_jmlHut.Text
        '    'row.Item("rec_penalty") = txr_pen.Text
        '    'row.Item("rec_provisi") = txr_prvs.Text
        '    'row.Item("rec_admin") = txr_adm.Text
        '    'row.Item("rec_bbj") = txr_bunga.Text

        'End If

        dSO.Tables("_krd").Rows.Add(row)

        'For Each row1 As DataRow In ds_tbh.Tables("_tbh").Rows
        '    row1.Item("no_trans") = ntran_cek
        '    row1.Item("tgl_trans") = getTanggal()
        '    row1.Item("create_date") = getTanggal()
        '    row1.Item("create_by") = username
        'Next

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(da_tbh)
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

            'Ga perlu exec ini karena ini bukan recorevey melunasi kredit lama, terbitkan baru
            'Dim sqlcmd As New SqlCommand("update kredit set sisa_angs=0, status_lunas='LUNAS',lunas_by='" & username & "',tgl_lunas=@nilai where no_trans='" & notran_lama & "'", sqlconn, BTRANS)
            'sqlcmd.Parameters.AddWithValue("@nilai", getTanggal(BTRANS))
            ''sqlcmd.Parameters.AddWithValue("@ket", row.Item("keterangan"))
            'sqlcmd.ExecuteNonQuery()

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")

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
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select k.no_trans,a.Nama,k.nasabah_id,k.jenis,k.JML_PINJAMAN,k.LAMA_ANGS,k.stat_kabagSP,k.stat_approve,k.stat_cair,a.job_id from kredit k left join anggota a on k.nasabah_id=a.nasabah_id  where k.stat_approve < 5 and k.kd_kredit='CUS'", sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        LUE_nama.Enabled = False

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            idJab = frmCari.row.Item("job_id").ToString
            LuE_Jab.EditValue = idJab
            btnSave = True
            LoadStruktur(frmCari.row(0))

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
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,Nama as [Nama],a.jns_kel as [Jenis_kelamin],j.batas_provisi,j.batas_admin,a.job_id,isnull(a.Almt_asal,'')as Almt_asal,CONVERT(int,ROUND(DATEDIFF(hour, isnull(convert(date,Tgl_lahir,1),''),GETDATE())/8766.0,0)) AS Umur, ISNULL(k.nama_kota,'') as nama_kota,* from anggota a left join kota k on a.kode_kota=k.kode_kota inner join m_jabatan j on a.job_id=j.job_id where a.nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) '
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not row Is Nothing Then
            LoadStruktur(row(0))
            LUE_nama.EditValue = row("nasabah_id")
            tx_id.Text = row("nasabah_id")
            lb_alamat.Text = row("Almt_asal")
            lb_kota.Text = row("nama_kota")
            id_anggota = row("nasabah_id")
            LuE_Jab.EditValue = row("job_id")
            lb_nama.Text = row("Nama")
            cb_prv.Checked = True
            'Lue_tipe.EditValue = frmCari.row("tipe")
            'sisaAng_lama = frmCari.row("sisa_angs")
            'lama_ang = frmCari.row("LAMA_ANGS")
            'bsr_pjm = frmCari.row("JML_PINJAMAN")
            'pk_lama = frmCari.row("JML_POKOK")
            'bg_lama = frmCari.row("JML_BUNGA")

            'angs = (lama_ang - sisaAng_lama) * pk_lama
            'sisa_pk_lama = bsr_pjm - angs

            'lb1_sisaAngs.Text = sisaAng_lama
            'tx1_LamaPJM.Text = sisaAng_lama

            'ang_lama = bg_lama + pk_lama



            'lb1_sisa_pk.Text = sisa_pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_Pinjam.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb1_bgLama.Text = bg_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_pk_lama.Text = pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'LoadStruktur(frmCari.row("no_trans"))

            'cek_notran() 'UTK CEK NO TRANS apa adayg sama
        End If
    End Sub

    'Private Sub cek_recovery()
    '    Dim sqlcek As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and stat_cair=1 and status_lunas='BELUM'", sqlconn).ExecuteReader
    '    sqlcek.Read()
    '    If sqlcek.HasRows Then
    '        stat_rec = True
    '        Dim adm, jml_ut, nilai, prv_r, bg_lama, bg_jln, pen As Decimal
    '        Dim sisa, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, tgl_uplod, blnx, bln_skrg As Integer
    '        'Dim tgl_uplod, blnx, bln_skrg As String

    '        Dim sqdr1 As SqlDataReader = New SqlCommand("select DAY(tgl_eksekusi) as tgl, MONTH(tgl_eksekusi) as blnx, month(GETDATE()) as bln_skrg, " & _
    '                                                    " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
    '                                                    " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
    '                                                    " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
    '                                                    " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg " & _
    '                                                    " from export_log ", sqlconn).ExecuteReader
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
    '        Dim sqdr As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' ", sqlconn).ExecuteReader
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
    '        recov = bg_jln + jml_ut + prv_r + adm + pen
    '        txr_total.Text = recov
    '        If blnx <> bln_skrg Then
    '            bg_jln = (bg_lama * jm_hr_lalu / jm_bl_lalu) + (bg_lama * jm_hr_today / jm_bl_skrg)
    '            txr_bunga.Text = bg_jln
    '        End If
    '        'tx_net.Text = t_total.Text - txr_total
    '        sqdr.Close()
    '        'sqdr1.Close()
    '    Else
    '        stat_rec = False
    '        Exit Sub
    '    End If
    '    sqlcek.Close()
    'End Sub

    Private Sub frmKreditCustom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur(_notrans)

        'gc_tambahan.Enabled = False 'awal blm centang di false

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='KRD' and kd2 in ('01','02')", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"
        'MsgBox(Lue_SetPjm.EditValue)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "Looktipe")
        Lue_tipe.Properties.DataSource = ds_cari2.Tables("Looktipe")
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

        cust = False
        Lue_tipe.EditValue = "F"
        'cb_tglbyr.Text = "25"
        'cb_byr.Text = "ANGSURAN"

    End Sub

    Private Sub cek_recovery()
        Dim sqlcek As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and stat_cair=1 and status_lunas='BELUM'", sqlconn).ExecuteReader
        sqlcek.Read()
        If sqlcek.HasRows Then
            stat_rec = True
            Dim jml_ut, nilai, prv_r, bg_lama, bg_jln, pen As Decimal
            Dim sisa, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, tgl_uplod, blnx, bln_skrg As Integer
            'Dim tgl_uplod, blnx, bln_skrg As String

            Dim sqdr1 As SqlDataReader = New SqlCommand("select DAY(tgl_eksekusi) as tgl, MONTH(tgl_eksekusi) as blnx, month(GETDATE()) as bln_skrg, " & _
                                                        " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg ", sqlconn).ExecuteReader
            '" from export_log ", sqlconn).ExecuteReader
            sqdr1.Read()
            tgl_uplod = sqdr1.Item("tgl")
            blnx = sqdr1.Item("blnx")
            bln_skrg = sqdr1.Item("bln_skrg")
            jm_hr_lalu = sqdr1.Item("jm_hr_lalu")
            jm_hr_today = sqdr1.Item("jm_hr_today")
            jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
            jm_bl_skrg = sqdr1.Item("jm_bl_skrg")

            sqdr1.Close()
            'sqdr1.Close()
            'MsgBox(bln_skrg)
            'jml_hr = System.DateTime.DaysInMonth(Today.Year, Today.Month)
            Dim sqdr As SqlDataReader = New SqlCommand("select * from kredit where nasabah_id='" & id_anggota & "' and no_trans='" & ntran_cek & "' ", sqlconn).ExecuteReader
            sqdr.Read()
            If sqdr.HasRows Then
                sisa = sqdr.Item("sisa_angs")
                jml_ut = sqdr.Item("JML_POKOK") * sisa
                'bg_rcv = sqdr.Item("Bunga_KSP")
                nilai = sqdr.Item("JML_PINJAMAN")
                bg_lama = sqdr.Item("JML_BUNGA")
                prv_r = bsr_pjm * (prv / 100)
            End If

            'txr_jmlHut.Text = jml_ut
            'txr_adm.Text = lb_admin.Text
            'txr_prvs.Text = prv_r
            'adm = txr_adm.Text
            'txr_adm.Text = tx_adm.Text
            'txr_hitRec.Text = nilai * bunga
            'txr_pen.Text = nilai * (2.5 / 100)

            If blnx <> bln_skrg Then
                bg_jln = (bg_lama * jm_hr_lalu / jm_bl_lalu) + (bg_lama * jm_hr_today / jm_bl_skrg)
                'txr_bunga.Text = bg_jln
            End If
            recov = bg_jln + jml_ut + prv_r + adm + pen
            'txr_total.Text = recov
            'tx_net.Text = t_total.Text - txr_total
            sqdr.Close()
            'sqdr1.Close()
        Else
            stat_rec = False
            Exit Sub
        End If
        sqlcek.Close()
    End Sub
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

    Public Sub cek_agenda()
        If Not dso2.Tables("_agd") Is Nothing Then
            dso2.Tables("_agd").Clear()
        End If
        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where nasabah_id= '" & id_anggota & "' and stat_approve < 5", sqlconn))
        DA1.Fill(dso2, "_agd")
        gc_agenda.DataSource = dso2.Tables("_agd")
        gv_agenda.BestFitColumns()


    End Sub
    Public Sub cek_hist()
        If Not dSO1.Tables("_hist") Is Nothing Then
            dSO1.Tables("_hist").Clear()
        End If
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where nasabah_id= '" & id_anggota & "'and stat_approve >= 5 and status_lunas='BELUM'", sqlconn))
        DA2.Fill(dSO1, "_hist")
        GcHist.DataSource = dSO1.Tables("_hist")
        Gv_hist.BestFitColumns()


    End Sub



    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        If STATE = "ADD" Then
            LUE_nama.Enabled = True
            Dim i As Integer
            'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
            Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
            'MsgBox(dr(i))
            lb_plafon.Text = dr(i).Item("nilai")

            bunga = dr(i).Item("Bunga_KSP")
            lb_bunga.Text = bunga
            te_bg.EditValue = bunga
            lb_admin.Text = dr(i).Item("adm")
            'tx_asr.Text = dr(i).Item("Asuransi")
            lb_prvs.Text = dr(i).Item("provisi")
            lb_denda.Text = dr(i).Item("Denda")
            'lb1_adm.Text = dr(i).Item("Adm")
            lb_admin.Text = dr(i).Item("Adm")
            'tx1_prvs.Text = dr(i).Item("provisi")
            lb_prvs.Text = dr(i).Item("provisi")
            'tx1_asr.Text = dr(i).Item("Asuransi")
            'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
            lb_bunga.Text = dr(i).Item("Bunga_KSP")
            adm = dr(i).Item("Adm")
            'bunga = lb_bunga.Text / 100
            'te_bg.EditValue = bunga
            'cb_tglbyr.Text = 25
            jns = dr(i).Item("kode")
            kd2 = Lue_SetPjm.EditValue
            cb_prv.Checked = True
            'cek_notran()
        End If
    End Sub

    Private Sub LuE_Jab_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LuE_Jab.EditValueChanged
        Dim i As Integer
        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
        If Lue_SetPjm.EditValue = "THR" Or Lue_SetPjm.EditValue = "TAT" Or Lue_SetPjm.EditValue = "BNS" Then
            If LuE_Jab.EditValue = 6 Then
                lb_plafon.Text = dr(i).Item("nilai")
            ElseIf LuE_Jab.EditValue = 4 Then
                lb_plafon.Text = dr(i).Item("nilai2")
            ElseIf LuE_Jab.EditValue = 7 Then
                lb_plafon.Text = dr(i).Item("nilai3")
            End If
        End If

    End Sub

    Public Sub hitung_cicilan()
        pot = pot_bns + pot_thr + pot_tat
        t_pot = pot * (tx1_LamaPJM.Text / 12) 'lama
        'bersihkan()
        If angs < t_bunga Then
            MsgBox("Angsuran Tidak boleh lebih kecil dari Bunga", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If pot > 0 Then
            pot_min = (TE_Bsr_PJM.EditValue / 72) * (tx1_LamaPJM.Text / 12)
            lb_potmin.Text = pot_min.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
        'bunga = te_bg.EditValue / 100
        tempo = tx1_LamaPJM.Text
        bsr_pjm = TE_Bsr_PJM.EditValue
        pokok_pertama = Math.Floor(bsr_pjm / tempo)
        'pokok = bsr_pjm - (pokok_pertama * (tempo - 1))
        pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
        t_bunga = bsr_pjm * (bunga / 100)
        angs = t_bunga + pokok_pertama

        total = t_bunga + bsr_pjm
        prv = bsr_pjm * (1 / 100)
        ang_lama = pokok_pertama + t_bunga
        If cust = False Then
            TE_CustomAngs.EditValue = ang_lama
            pokok_br = ang_lama - t_bunga 'pokok custom= total angsuran baru - bunga
        ElseIf cust = True Then
            pokok_br = TE_CustomAngs.EditValue - t_bunga 'pokok custom= total angsuran baru - bunga
        End If

        'End If
        selisih_pokok = pokok_akhir - pokok_pertama
        t_pk_br = pokok_br * tx1_LamaPJM.Text 'dikalikan tempo lama pinjam

        jml_trima = bsr_pjm - (adm + prv)
        ang_baru = pokok_br + t_bunga
        total = t_pot + t_pk_br + selisih_pokok
        TE_CustomAngs.EditValue = ang_baru

        lb1_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

        lb_tempo.Text = tx1_LamaPJM.Text
        lb_tempo2.Text = tx1_LamaPJM.Text
        lb_tempo3.Text = tx1_LamaPJM.Text
        tempo_pt = tx1_LamaPJM.Text / 12

        lb_tempo_pot.Text = tempo_pt
        lb_tpokok.Text = t_pk_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_tpot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_pkBaru.Text = pokok_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_terima.Text = jml_trima.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_angBaru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_RPangLama.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

        'End If
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Lue_SetPjm.EditValue = vbNullString Then
            MsgBox("Jenis Pinjaman belum di pilih, silahkan pilih dahulu")
            Exit Sub
        End If
        Cari()
        'cek_notran() 'utk ganti no trans.. barnagkali ada
        TE_Bsr_PJM.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hitung_cicilan()
    End Sub

    Private Sub tx1_LamaPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tx1_LamaPJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
                hitung_cicilan()
            End If

        End If
        
    End Sub

    Private Sub TE_CustomPOKOK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_CustomAngs.KeyDown
       
        If e.KeyCode = Keys.Enter Then
            If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
                cust = True
                hitung_cicilan()
            End If

        End If
    End Sub


    Private Sub TE_CustomPOKOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_CustomAngs.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    
    Private Sub TE_Bsr_PJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_Bsr_PJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx1_LamaPJM.Focus()
        End If
    End Sub

    Private Sub TE_Bsr_PJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_Bsr_PJM.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    'Private Sub gv_tambahan_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    '    'hitung_cicilan()
    'End Sub

    'Private Sub cb_pot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
    '        If cb_pot.Checked = True And t_pot = 0 Then
    '            gc_tambahan.Enabled = True
    '            pot_min = (bsr_pjm / 72) * (tx1_LamaPJM.Text / 12)
    '            'lb_tpot.Text = pot_min.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '            lb_potmin.Text = pot_min.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '        Else
    '            gc_tambahan.Enabled = False
    '            t_pot = 0
    '        End If
    '    End If

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
 
    Private Sub cb_prv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_prv.CheckedChanged
        If cb_prv.Checked = True Then
            prv = bsr_pjm * (1 / 100)
            lb1_prvs.Text = prv
        Else
            lb1_prvs.Text = 0
            prv = 0
        End If
    End Sub

 
    Private Sub te_bg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles te_bg.EditValueChanged
        bunga = te_bg.EditValue
        If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            hitung_cicilan()
        End If

    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Lue_SetPjm.EditValue = vbNullString Then
                MsgBox("Silahkan pilih jenis Pinjaman dahulu!!!", MsgBoxStyle.Exclamation)
            Else
                Cari()
                TE_Bsr_PJM.Focus()
            End If
           
        End If
    End Sub

  
    Private Sub TE_bns_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_bns.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

            End If
            TE_thr.Focus()
        End If
    End Sub

    Private Sub TE_tat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_tat.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

            End If
            TE_thr.Focus()
        End If
    End Sub

    Private Sub TE_thr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_thr.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_Bsr_PJM.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

            End If
            TE_thr.Focus()
        End If
    End Sub
End Class