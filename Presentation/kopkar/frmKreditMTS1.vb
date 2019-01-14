'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmKreditMTS1
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public _notrans As String = "xxx"
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, notran_lama, notran_cek, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_hist, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2, ds_byr_kartu, dsjab, dsNama, ds_mts As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, row3 As DataRow
    Private tempo_pot, tempo, sisaAng_baru, lama_pjm, m_prv, tgldbet As Integer
    Private DA, DA1, DA2, DALOOKUP, daJab, daNama, DALOOKUP1, DA_gdg1, da_tbh, da_byr_krt As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, pokok, bg_br, s_ang, bsr_pjm, prthn, pot_min, bsr_ccl_baru, sisa_pk_br, t_pk_br, sisa_pk_lama, pot_bns, pokok_asli, pot_thr, pot_tat, lama_ang, sisaAng_lama, angs_asli, angs, adm, denda, t_bunga, pokok_pertama, t_pot, pot, pot_hrs, total, recov, prv, bg_lama, ang_lama, pk_lama, after_pot, bg_baru, pk_akhir_asli, t_bgBaru, sisa_pk_after_ptg, ang_baru, t_pk_baru, pokok_br, pokok_akhir, selisih_pokok, t_pk_br_akhir, r_jml_ut, j_bg_lama As Double
    Public byr_piu, jm_angs, nett, plfnd, bts_adm, bts1, bts2, adm_default, bts_prv_bns1, bts, jml_pjmLama, bts_prv_bns2, bg_bns, bg_jln As Double
    Private BTRAN As SqlTransaction
    Public stat_tran, stat_rec, taunan, tgk, pk_cust As Boolean
    Public idJab, ntran_cek, notrans, str2, kd2, id_jab, tgl_1_trans, tgl_1_dbt, tgl_dbt As String
    Private sisa, jml_hr, jml_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, jm_bl_dbt, jm_hr_dbt, tgl_uplod, blnx, bln_skrg, bln_dbt, jm_hr_bln, hr_ini As Integer
    Dim foto() As Byte
    Public rw_tgk, rw_kartu As DataRow
    Public resc As Boolean



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        taunan = False
        byr_piu = 0
        jm_angs = 0
        bsr_pjm = 0
        nett = 0
        STATE = "ADD" '<-- set state add
        LUE_nama.Focus()
    End Sub

    Private Sub bersihkan()
        Lue_SetPjm.EditValue = vbNullString
        tx1_LamaPJM.Text = ""
        lb1_net.Text = ""
        lb1_pokok.Text = ""
        lb1_bunga.Text = ""
        lb_pot_min.Text = ""
        lb_tempo_pot2.Text = ""
        tx1_ket.Text = ""

        TE_AngsBaru.EditValue = vbNullString
      

        If Not dso2.Tables("_agd") Is Nothing Then dso2.Tables("_agd").Clear()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
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
        callReport(App_Path() & "\report\pengajuan.rpt", "", "no_trn=" & lb_notrans_lama.Text)
    End Sub

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not ds_tbh.Tables("_tgk") Is Nothing Then ds_tbh.Tables("_tgk").Clear()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,JML_BUNGA+JML_POKOK as ang from kredit where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")

        'DA_MTS = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_mtsi where no_trans='" & kode & "'", sqlconn))
        'DA_MTS.Fill(ds_mts, "_mts")

        da_tbh = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as no_seq,'Y' as gc_rec,* from kredit_mtsi where no_trans='" & kode & "'", sqlconn))
        da_tbh.Fill(ds_tbh, "_tgk")
        gc_tgk.DataSource = ds_tbh.Tables("_tgk")

        da_byr_krt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kartu where 1=2", sqlconn))
        da_byr_krt.Fill(ds_byr_kartu, "_kartu")
        Gc_kartu.DataSource = ds_byr_kartu.Tables("_kartu")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)
            id_anggota = rwm("nasabah_id").ToString
            LUE_nama.EditValue = rwm("nasabah_id").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            Lue_tipe.EditValue = rwm("tipe").ToString
            'tx_id.Text = rwm("nasabah_id").ToString
            'lb1_Pinjam.Text = rwm("JML_PINJAMAN").ToString
            'tx1_LamaPJM.Text = rwm("LAMA_ANGS").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            'lb1_pk_lama.Text = rwm("JML_POKOK").ToString
            'lb1_bgLama.Text = rwm("JML_BUNGA").ToString
            'lb1_RPangLama.Text = rwm("ang").ToString
            lb_notrans_lama.Text = rwm("no_trans").ToString
            'MsgBox(rwm("stat_provisi").ToString)
            'cb_prv.CheckState = IIf(rwm("stat_provisi") = True, cb_prv.Checked = True, cb_prv.Checked = False)
            'lb1_prvs.Text = rwm("JML_PROVISI").ToString
            'lb_t_hit.Text = rwm("JML_PINJAMAN").ToString
            TE_AngsBaru.EditValue = rwm("ang").ToString

            pot = pot_bns + pot_thr + pot_tat
            lama_pjm = tx1_LamaPJM.Text
            t_pot = pot * (lama_pjm / 12) 'lama bulan/12 = setehun/pertehun

            angs = rwm("ang")
            pokok_pertama = rwm("JML_POKOK")
            bg_lama = rwm("JML_BUNGA")
            adm = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            bsr_pjm = rwm("JML_PINJAMAN")
            pk_lama = rwm("JML_POKOK")
            after_pot = IIf(rwm.IsNull("sisa_pokok_after_potong"), 0, rwm("sisa_pokok_after_potong").ToString)
            'total = t_pot + t_pk_br
            notran_lama = rwm("no_trans")
            sisaAng_lama = rwm("sisa_angs")
            'sisa_pk_lama = rwm("sisa_pokok")
            lama_ang = rwm("LAMA_ANGS")


            'bunga = rwm("Bunga_KSP") / 100
            txb_bg.EditValue = bunga
            'cb_tglbyr.Text = "25"
            'bunga = row("bunga")
            Lue_tipe.EditValue = "F"
            'txb_norek.Text = IIf(rwm.IsNull("no_rek"), rwm("no_rek"), rwm("no_rek").ToString)
            'txb_bank.Text = "BCA"
            txb_norek2.Text = IIf(rwm.IsNull("no_rek2"), 0, rwm("no_rek2").ToString)
            'txb_bank.Text = "BCA"

            'angs = (lama_ang - sisaAng_lama) * pk_lama
            'sisa_pk_lama = bsr_pjm - angs

            'lb1_sisaAngs.Text = sisaAng_lama
            tx1_LamaPJM.Text = sisaAng_lama

            ang_lama = bg_lama + pk_lama
            'lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_ang_baru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'tampilan sebelah
            'lb_tpokok.Text = t_pk_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_tpot.Text = pot_hrs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            ''lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb_tempo.Text = lama_pjm
            'lb_tempo2.Text = lama_pjm
            'lb_tempo3.Text = lama_pjm
            'lb_tempo_pot.Text = tempo_pot
            tempo_pot = lama_pjm / 12


            'lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'nett = bsr_pjm - (prv + adm)
            ''##JUMLAH TERIMA
            'lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If



    End Sub
    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select k.no_trans,a.Nama,k.nasabah_id,k.jenis,k.JML_PINJAMAN,k.LAMA_ANGS,k.stat_kabagSP,k.stat_approve,k.stat_cair,a.job_id from kredit k left join anggota a on k.nasabah_id=a.nasabah_id  where k.stat_approve < 5 and k.kd_kredit='MTS'", sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        'btCari.Enabled = False
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            idJab = frmCari.row.Item("job_id").ToString
            LuE_Jab.EditValue = idJab
            LoadStruktur(frmCari.row(0))
        Else
            'cancel_click()
            add_click()
            btnSave = False
            'LookupPO.Enabled = False
            STATE = ""
        End If

    End Sub

    Public Sub save_click()
        If pot_hrs > t_pot Then
            MsgBox("Nilai Potongan Harus sama atau melebihi Rumus!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If LUE_nama.EditValue = vbNullString Or TE_AngsBaru.EditValue = vbNullString Then
            MsgBox("Lengkapi data, banyak yang belum di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If pot = 0 Then 'Or gv_tambahan.Columns("nilai").SummaryItem.SummaryValue = 0 Then
        '    MsgBox("Harap mengisi terlebih dahulu Komponen Tambahan Recovery Potongan Bonus, TAT dan THR !!! " & vbCrLf & "atau Total Keseluruhan Nilai Potongan =Rp.0,")
        '    Exit Sub
        'If pot <> 0 And pot_min > t_pot Then
        '    MsgBox("Potongan harus lebih diatas default= " & pot_min & " Rumus=(Angsr baru / 72) x (Lama Pinjam / 12))", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        hitung_cicilan()
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

    End Sub
    Public Sub simpan()

        For Each row As DataRow In ds_tbh.Tables("_tgk").Select("gc_rec = 'T'")
            row.Delete()
        Next

        notrans = get_notran()
        lb_notrans_lama.Text = notrans
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            'row = dSO.Tables("_krd").Rows(0)
            row = dSO.Tables("_krd").NewRow
            row3 = ds_mts.Tables("_mts").NewRow 'krd_mts



            row.Item("no_trans") = notrans 'no_ref generate no kredt mutasi, sedang no trans tetep yg lama
            row.Item("no_ref") = notran_lama 'no ref
            txb_NoBaru.Text = notrans
            'MsgBox(id_anggota + jns + blthn())121231
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            row.Item("cetak_ke") = 0

            row.Item("tgl_trans") = getTanggal()
            lb_notrans_lama.Text = notran_lama


        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_krd").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If

        row.Item("kd_kredit") = "MTS" '### kode kredit, mts atau Recovery

        row.Item("NASABAH_ID") = id_anggota
        row.Item("jenis") = Lue_SetPjm.EditValue
        row.Item("JML_PINJAMAN") = nett
        row.Item("JML_DENDA") = lb_denda.Text
        row.Item("JML_ADMIN") = adm
        row.Item("JML_POKOK") = pokok_br
        row.Item("JML_BUNGA") = bg_lama
        row.Item("jml_angsuran") = TE_AngsBaru.EditValue
        row.Item("JML_POKOK_TERAKHIR") = pokok_akhir
        row.Item("bunga") = bunga
        row.Item("sisa_pokok_after_potong") = t_pk_baru
        row.Item("sisa_pokok") = nett
        row.Item("JML_PROVISI") = prv
        row.Item("TGL_PENGAJUAN") = dt_tgl.EditValue
        row.Item("STATUS_AKTIF") = 1
        row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
        row.Item("sisa_angs") = tx1_LamaPJM.Text
        row.Item("TGL_TAGIHAN") = 25
        row.Item("status_lunas") = "BELUM"
        row.Item("approve1_by") = "OutStanding"
        row.Item("approve2_by") = "OutStanding"
        row.Item("approve3_by") = "OutStanding"
        row.Item("approve4_by") = "OutStanding"
        row.Item("stat_approve") = 0
        row.Item("stat_cair") = 1
        row.Item("KETERANGAN") = tx1_ket.Text
        row.Item("stat_kabagSP") = "Outstanding"
        row.Item("rec_lunas") = 1
        row.Item("pot_bns") = TE_bns.EditValue
        row.Item("pot_thr") = TE_thr.EditValue
        row.Item("pot_tat") = TE_tat.EditValue
        row.Item("stat_pot_bns") = 0
        row.Item("stat_pot_thr") = 0
        row.Item("stat_pot_tat") = 0
        'row.Item("no_jaminan") = tx_jaminan.Text
        row.Item("foto_jaminan") = foto
        row.Item("no_ref") = txb_noform.Text

        

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da_tbh)
            da_tbh.UpdateCommand = Buildernya.GetUpdateCommand()
            da_tbh.InsertCommand = Buildernya.GetInsertCommand()
            da_tbh.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA_MTS)
            'DA_MTS.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA_MTS.InsertCommand = Buildernya.GetInsertCommand()
            'DA_MTS.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'DA_MTS.UpdateCommand.Transaction = BTRANS
            'DA_MTS.InsertCommand.Transaction = BTRANS
            'DA_MTS.DeleteCommand.Transaction = BTRANS


            da_tbh.UpdateCommand.Transaction = BTRANS
            da_tbh.InsertCommand.Transaction = BTRANS
            da_tbh.DeleteCommand.Transaction = BTRANS


            DA.Update(dSO.Tables("_krd"))
            da_tbh.Update(ds_tbh.Tables("_tgk"))
            'DA_MTS.Update(ds_mts.Tables("_mts"))

            Dim i As Int16 = 1
            For Each row As DataRow In ds_tbh.Tables("_tgk").Rows
                row.Item("no_trans") = notrans
                row.Item("nomer") = i : i += 1

                Dim sqlcmd As New SqlCommand("update kredit set sisa_angs=0,no_ref='" & notrans & "', status_lunas='PENDING',lunas_by='" & username & "',tgl_lunas=@tgl, KETERANGAN='RESCHEDUL KREDIT' where no_trans='" & row.Item("no_trans") & "'", sqlconn, BTRANS)
                sqlcmd.Parameters.AddWithValue("@tgl", getTanggal(BTRANS))
                sqlcmd.ExecuteNonQuery()
            Next
            'Dim sqlcmd As New SqlCommand("update kredit set sisa_angs=0,no_ref='" & notrans & "', status_lunas='PENDING',lunas_by='" & username & "',tgl_lunas=@tgl, KETERANGAN='RESCHEDUL KREDIT,ANGSURAN DIPERKECIL/BESAR' where no_trans='" & notran_lama & "'", sqlconn, BTRANS)
            'sqlcmd.Parameters.AddWithValue("@tgl", getTanggal(BTRANS))
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



    Public Sub Cari()
        ''bersihkan()
        'bersihkan()
        'DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select t.nasabah_id as NIP,a.Nama as [Nama],t.no_trans,t.JML_PINJAMAN,u.Bunga_KSP,t.sisa_angs,t.status_lunas,t.TGL_PENGAJUAN,a.job_id,isnull(a.Almt_asal,'')as Almt_asal, * from kredit t left JOIN anggota a on t.nasabah_id=a.nasabah_id left join kota k on a.kode_kota=k.kode_kota left join m_jns_upload u on t.jenis=u.kode where t.stat_cair=1 and t.stat_approve>=5 and t.status_lunas='BELUM' and jenis in ('NOR ','NON ')", sqlconn)) '<- and t.LAMA_ANGS<> t.sisa_angs ,,query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        'If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        'DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id as NIP,a.Nama as [Nama],t.no_trans,t.tgl_trans as TGL_PINJAM,t.JML_PINJAMAN,t.sisa_angs,t.status_lunas,t.jenis,a.job_id,isnull(a.Almt_asal,'')as Almt_asal ,ISNULL(k.nama_kota,'') as nama_kota,ISNULL(t.no_rek,a.REKBCA1) as no_rek,* from kredit t left JOIN anggota a on t.nasabah_id=a.nasabah_id left join kota k on a.kode_kota=k.kode_kota where t.stat_cair=1 and t.stat_approve>=5 and t.status_lunas='BELUM'  and a.nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) '<- and jenis in ('NOR','NON')
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        If ds_gdg1.Tables("lookup_Pegawai").Rows.Count = 0 Then
            MsgBox("NIP tidak mempunyai hutang yg di Rheschedule")
            Exit Sub
        End If
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        If Not row Is Nothing Then
            LUE_nama.EditValue = row("nasabah_id")
            lbNIP.Text = row("Nama")
            id_anggota = row("nasabah_id")
            lb_alamat.Text = row("Almt_asal")
            'lb_kota.Text = frmCari.row("nama_kota")  'IIf(rwm.IsNull("SALDO_AWAL"), 0, rwm.Item("SALDO_AWAL"))
            'lb_kota.Text = IIf(frmCari.row("nama_kota").IsNull, " ", frmCari.row("nama_kota"))
            id_anggota = row("nasabah_id")
            LuE_Jab.EditValue = row("job_id")
            'cb_tglbyr.Text = "25"
            id_jab = row("status_kary") 'BCA or peg kop
            bunga = row("bunga") / 100

        

            'bunga = row("bunga")
            Lue_tipe.EditValue = "F"
            txb_norek.Text = IIf(row.IsNull("no_rek"), row("REKBCA1"), row("no_rek").ToString)
            'txb_bank.Text = "BCA"
            txb_norek2.Text = IIf(row.IsNull("no_rek2"), 0, row("no_rek2").ToString)
            'txb_bank.Text = "BCA"

            'angs = (lama_ang - sisaAng_lama) * pk_lama
            'sisa_pk_lama = bsr_pjm - angs

            'lb1_sisaAngs.Text = sisaAng_lama
            tx1_LamaPJM.Text = sisaAng_lama

            ang_lama = bg_lama + pk_lama




            'LoadStruktur(row("no_trans"))
            lb1_net.Text = sisa_pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_Pinjam.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_bgLama.Text = bg_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_pk_lama.Text = pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'str2 = Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
            'cek_notran() 'UTK CEK NO TRANS apa adayg sama
        End If
        TE_AngsBaru.Focus()
    End Sub

    Public Sub hit_centang()

        Dim sqdr1 As SqlDataReader = New SqlCommand("select  month(convert(date,'" & dt_tgl.EditValue & "',103)) as bln_skrg, " & _
              " DATEDIFF(MONTH,convert(date,'" & dt_tgl.EditValue & "',103), DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & tgl_dbt & "',103)),0)))+1 as ke_blnDebt, " & _
              " datediff(day, convert(date,'" & tgl_1_dbt & "',103) , convert(date,'" & tgl_dbt & "',103) ) as jm_hr_dbt,  " & _
              " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & tgl_1_trans & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) )+1 as jm_hr_today,  " & _
              " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_bln, " & _
              " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
              " day(convert(date,'" & dt_tgl.EditValue & "',103)) as hr_ini, " & _
              " DAY(DATEADD(DD,-1,DATEADD(MM,DATEDIFF(MM,-1,convert(date,'" & de_debet.EditValue & "',103)),0))) as jm_bl_dbt, " & _
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
        jml_hr_lalu = jm_bl_lalu - (25 - 1)
        bg_br = bsr_pjm * (bunga / 100)

        j_bg_lama = 0
        bg_jln = 0
        bg_lama = 0
        byr_piu = 0
        jm_angs = 0
        sisaAng_baru = 0
        For Each rw_hist In ds_tbh.Tables("_tgk").Select("gc_rec='Y'")
            byr_piu += rw_hist.Item("sisa_pokok")
            bg_lama = rw_hist.Item("JML_BUNGA")
            jm_angs += rw_hist.Item("jml_angsuran")

            bg_jln = Math.Round(((bg_lama / jm_bl_lalu) * jml_hr_lalu) + ((bg_lama / jm_bl_dbt) * hr_ini))
            rw_hist.Item("rec_bbj") = bg_jln
            j_bg_lama += Math.Round(((bg_lama / jm_bl_lalu) * jml_hr_lalu) + ((bg_lama / jm_bl_dbt) * hr_ini))
            sisaAng_baru += rw_hist.Item("sisa_angs")
        Next
        te_bg_jln.EditValue = j_bg_lama
        If byr_piu <= 0 Then
            Exit Sub
        End If
        If TE_AngsBaru.EditValue = vbNullString Then
            '#SUGGEST NILAI AWAL
            TE_AngsBaru.EditValue = jm_angs
            sisaAng_baru = Math.Round((byr_piu + j_bg_lama) / jm_angs)
            tx1_LamaPJM.Text = sisaAng_baru
        End If
        jml_pjmLama = byr_piu
        prv_all()
        bsr_pjm = byr_piu + j_bg_lama + prv + adm
        hitung_cicilan()
        'r_jml_ut = nett

        TE_jml_byr.EditValue = byr_piu
        nett = byr_piu + j_bg_lama + prv + adm
        'nett = bsr_pjm
        lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub hitung_cicilan()
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()


        If tx1_LamaPJM.Text = "" And TE_AngsBaru.EditValue = vbNullString Then
            Exit Sub
        End If



        'bersihkan()

        If taunan = False And angs < t_bunga Then
            MsgBox("Angsuran Tidak boleh lebih kecil dari Bunga", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If taunan = False Then
            buat_kartu()
            'sisa_pk_after_ptg = byr_piu - t_pot
            'pokok_br = bsr_pjm - bg_lama 'pokok baru=angsuran baru - bunga, sudah di kurangi bunga
            'pokok_br = sisa_pk_after_ptg  'pokok baru=angsuran baru - bunga, sudah di kurangi bunga
            't_pk_baru = pokok_br * tx1_LamaPJM.Text 'dikalikan tempo sisa lama pinjam
            'pot_hrs = byr_piu - t_pk_baru
            'pokok_akhir = byr_piu - (pokok_br * (tx1_LamaPJM.Text - 1))
            'pokok_akhir = sisa_pk_lama - t_pk_baru
            't_pk_br_akhir = t_pk_baru + pokok_akhir
            'ang_baru = pokok_br + bg_baru

            'prv_all() 'non bonus
            'nett = t_pot + t_pk_baru
            total = t_pot + t_pk_baru
            prthn = t_pot / tempo_pot

            lb_t_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_prthn.Text = prthn.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_tempo_pot2.Text = tempo_pot
            lb_tempo4.Text = tempo_pot
        Else 'taunan di resc jadi bns tat thr
            bsr_ccl_baru = TE_AngsBaru.EditValue
            prv_bns() 'bonus
            cicilan_bns()


        End If

        'Else ' if taunan=true/bns
        '    cicilan_bns()
        'End If



    End Sub

    Public Sub buat_kartu()
        If byr_piu <= 0 Or tx1_LamaPJM.Text = "" Then
            Exit Sub
        End If
        'If taunan = True Then
        '    tx1_LamaPJM.Text = 1
        '    lama_pjm = tx1_LamaPJM.Text
        '    tempo_pot = 1
        'Else
        '    lama_pjm = tx1_LamaPJM.Text
        '    tempo_pot = lama_pjm / 12
        'End If
        lama_pjm = tx1_LamaPJM.Text
        tempo_pot = lama_pjm / 12
        Dim tenor_bns, tenor_thr, tenor_tat As Integer
        Dim tgl_pj As DateTime = dt_tgl.EditValue
        Dim bln_k, j_bln As DateTime
        Dim nm_bln As String
        ' If taunan = True Then Exit Sub
        t_pot = 0
        tenor_bns = 0
        tenor_thr = 0
        tenor_tat = 0
        pot_bns = TE_bns.EditValue
        pot_thr = TE_thr.EditValue
        pot_tat = TE_tat.EditValue
        'MsgBox(dt_tgl.EditValue)
        'pot_hrs=tot
        pot = pot_bns + pot_thr + pot_tat
        lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))



        't_pot = pot * tempo_pot 'lama bulan/12 = setehun/pertehun 'lama bulan/12 = setehun/pertehun



        tempo = tx1_LamaPJM.Text
        'bsr_pjm = nett

        'byr_piu = 0m 
        If Not ds_byr_kartu.Tables("_kartu") Is Nothing Then ds_byr_kartu.Tables("_kartu").Clear()
        Dim pk_pinj As Double = bsr_pjm
        Dim ang_kart As Double
        'Dim nm_bln As String
        Dim k_bln As Integer = Today.Month
        Dim k_thn As Integer = Today.Year
        'Dim jt_tmpo As Date


        For xpt As Integer = 0 To tempo - 1
            bln_k = tgl_pj.AddMonths(xpt)
            Select Case bln_k.Month
                Case xbns.Month
                    tenor_bns += 1
                    t_pot += pot_bns
                Case xthr.Month
                    tenor_thr += 1
                    t_pot += pot_thr
                Case xtat.Month
                    tenor_tat += 1
                    t_pot += pot_tat
            End Select
        Next

        lb_t_pot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        If t_pot > 0 Then
            pot_min = (bsr_pjm / 72) * (tempo_pot)
            lb_pot_min.Text = pot_min.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb_pot_min.Text = pot_hrs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
        sisa_pk_br = bsr_pjm - t_pot
        total = t_pot + t_pk_baru
        If pk_cust = True Then
            pokok_pertama = ang_baru - t_bunga
            tempo = Math.Floor(byr_piu / pokok_pertama)
            tx1_LamaPJM.Text = tempo
            pokok_akhir = byr_piu - (pokok_pertama * (tempo - 1))

        Else 'bsr_pjm+byr_piu+bungabbj
            pokok_asli = Math.Floor(bsr_pjm / tempo)
            pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
            pk_akhir_asli = bsr_pjm - (pokok_pertama * (tempo - 1))
            t_bunga = byr_piu * (bunga / 100)

            'bsr_pjm = nett
            pokok_asli = Math.Floor(bsr_pjm / tempo)
            pk_akhir_asli = bsr_pjm - ((Math.Floor(bsr_pjm / tempo)) * (tempo - 1))
            pokok_pertama = Math.Floor(sisa_pk_br / tempo)
            pokok_akhir = sisa_pk_br - (pokok_pertama * (tempo - 1))
            angs = t_bunga + pokok_pertama
            angs_asli = t_bunga + pokok_pertama
        End If

        'If pk_cust = False Then
        '    pokok_pertama = Math.Floor(sisa_pk_br / tempo)
        '    pokok_akhir = sisa_pk_br - (pokok_pertama * (tempo - 1))
        '    angs_asli = pokok_pertama + t_bunga
        'End If

        t_pk_br = (pokok_pertama * (tempo - 1)) + pokok_akhir
        ang_baru = pokok_pertama + t_bunga
        total = t_pot + t_pk_br

        ang_kart = pokok_pertama
        angs = t_bunga + pokok_pertama
        r_jml_ut = bsr_pjm
        For y As Integer = 0 To tempo - 1
            j_bln = tgl_pj.AddMonths(y)
            rw_kartu = ds_byr_kartu.Tables("_kartu").NewRow()
            rw_kartu.Item("angs_ke") = y + 1

            rw_kartu.Item("c_pokok_pinj") = pk_pinj
            rw_kartu.Item("c_pokok") = pokok_pertama
            rw_kartu.Item("c_bunga") = t_bunga
            rw_kartu.Item("c_angs") = ang_baru

            If y = tempo - 1 Then
                rw_kartu.Item("c_pokok") = pokok_akhir
                rw_kartu.Item("c_angs") = pokok_akhir + t_bunga
            End If

            rw_kartu.Item("c_tahun") = j_bln.Year
            nm_bln = MonthName(j_bln.Month, True)
            rw_kartu.Item("c_bulan") = nm_bln
            'j_bln = (k_bln + (y + 1)) - 12
            'Dim nm_bln = MonthName(j_bln, True).ToString
            'rw_kartu.Item("c_bulan") = nm_bln

            rw_kartu.Item("c_bns") = 0
            rw_kartu.Item("c_thr") = 0
            rw_kartu.Item("c_tat") = 0


            Select Case j_bln.Month
                Case xbns.Month
                    rw_kartu.Item("c_bns") = pot_bns
                    r_jml_ut = r_jml_ut - pot_bns
                Case xthr.Month
                    rw_kartu.Item("c_thr") = pot_thr
                    r_jml_ut = r_jml_ut - pot_thr
                Case xtat.Month
                    rw_kartu.Item("c_tat") = pot_tat
                    r_jml_ut = r_jml_ut - pot_tat
            End Select
            ds_byr_kartu.Tables("_kartu").Rows.Add(rw_kartu)
            pk_pinj = r_jml_ut - ang_kart
            ang_kart = ang_kart + pokok_pertama

        Next
        lb1_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        TE_AngsBaru.EditValue = ang_baru
        'lb1_total_ang1.Text = ang_baru.ToString("c", New Globalization.CultureInfo("id-ID", False)) 'hit awal defaul rek1, cek te_rek2
        'lb1_total_ang2.Text = angs_dua_rek.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_t_pot.Text = tempo_pot
    End Sub

    Public Function get_notran() As String
        'stat_tran = True
        ' getKodeCabang() &
        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kode", Lue_SetPjm.ItemIndex).ToString() & code_blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from kredit where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kode", Lue_SetPjm.ItemIndex).ToString() & code_blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kode", Lue_SetPjm.ItemIndex).ToString() & code_blthn() & "001"
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

    Public Sub cek_hut()

        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        If Not ds_tbh.Tables("_tgk") Is Nothing Then ds_tbh.Tables("_tgk").Clear()


        Dim sqdr2 As SqlDataReader = New SqlCommand("select isnull(JML_POKOK_TERAKHIR,0) as JML_POKOK_TERAKHIR, * from kredit where nasabah_id= '" & id_anggota & "' and status_lunas<>'LUNAS' and stat_approve > 4 and kd_kredit <> 'KRD'", sqlconn).ExecuteReader
        Dim y As Int16 = 1
        If sqdr2.HasRows Then
            tgk = True
        End If
        While sqdr2.Read
            Dim rw2 As DataRow = ds_tbh.Tables("_tgk").NewRow
            rw2.Item("no_seq") = y : y += 1
            rw2.Item("tgl_trans") = sqdr2.Item("tgl_trans")
            rw2.Item("jenis") = sqdr2.Item("jenis")
            rw2.Item("kd_kredit") = sqdr2.Item("kd_kredit")
            rw2.Item("no_trans") = sqdr2.Item("no_trans")
            rw2.Item("jml_pinjaman") = sqdr2.Item("JML_PINJAMAN")
            rw2.Item("jml_pokok") = sqdr2.Item("JML_POKOK")
            rw2.Item("jml_bunga") = sqdr2.Item("JML_BUNGA")
            rw2.Item("jml_angsuran") = sqdr2.Item("jml_angsuran")
            rw2.Item("sisa_angs") = sqdr2.Item("sisa_angs")
            rw2.Item("gc_rec") = "T"
            rw2.Item("sisa_pokok") = sqdr2.Item("sisa_pokok")
            tgk = True
            ds_tbh.Tables("_tgk").Rows.Add(rw2)
        End While
        sqdr2.Close()
        da_tbh.Fill(ds_tbh, "_tgk")
        gc_tgk.DataSource = ds_tbh.Tables("_tgk")

    End Sub

    'Public Sub centang_recov()
    '    'byr_rec = 0
    '    For Each rw_rec In dSO1.Tables("_hist").Select("gc_rec='Y'")
    '        byr_rec += rw_rec.Item("sisa_pokok")
    '    Next
    '    bsr_pjm = byr_piu
    '    hitung_cicilan()
    '    TE_jml_byr.EditValue = byr_rec
    '    nett = nett - byr_piu - byr_rec
    '    'lb1_terima.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    'End Sub


    Private Sub frmKreditMTS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur(_notrans)
        de_debet.Visible = False
        lb_debet.Visible = False
        dt_tgl.EditValue = Today
        de_debet.EditValue = Today.AddMonths(1)
        'cb_all.Enabled = False
        'gc_byr_piu.Enabled = False
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans in ('KRD','BNS')", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DALOOKUP.Fill(ds_cari1, "Looktipe")
        Lue_tipe.Properties.DataSource = ds_cari1.Tables("Looktipe")
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
        resc = False
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Lue_tipe.EditValue = "F"
        'Lue_SetPjm.Enabled = False
        Lue_tipe.Enabled = False
        'Panel3.Hide()
        'LUE_nama.Focus()
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bersihkan()
        Cari()
        'cek_hist()
        cek_hut()
        TE_AngsBaru.Focus()
    End Sub

    'Private Sub gv_tambahan_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    If Lue_SetPjm.EditValue <> vbNullString Then
    '        gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    '    End If


    'End Sub


    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        'bersihkan()
        If Lue_SetPjm.EditValue = "PTAT" Or Lue_SetPjm.EditValue = "PTHR" Or Lue_SetPjm.EditValue = "PBNS" Or Lue_SetPjm.EditValue = "PKHS" Then
            tx1_LamaPJM.Text = 1

            TE_AngsBaru.EditValue = bsr_pjm
            lb_debet.Visible = True
            de_debet.Visible = True
            MsgBox("Harap Setting Tanggal BNS/THR/TAT utk hitung Bunga Berjalan")

            Select Case Lue_SetPjm.EditValue
                Case "PTAT"
                    Dim tgl_tat As DateTime = New DateTime(Today.Year, xtat.Month, 25)
                    de_debet.EditValue = tgl_tat
                    lb_debet.Text = "Tgl debet TAT"
                    lb_bbj.Text = "Bunga depan"
                Case "PTHR"
                    Dim tgl_tat As DateTime = New DateTime(Today.Year, xthr.Month, 25)
                    de_debet.EditValue = tgl_tat
                    lb_debet.Text = "Tgl debet THR"
                    lb_bbj.Text = "Bunga depan"
                Case "PKHS"
                    'de_debet.EditValue = tgl_tat
                    lb_debet.Text = "Tgl debet KHS"
                Case "PBNS"
                    lb_debet.Text = "Tgl debet BNS"
                    lb_bbj.Text = "Bunga depan"
                    If Today.Month < xbns.Month Then
                        Dim tgl_tat As DateTime = New DateTime(Today.Year, xbns.Month, 25)
                        de_debet.EditValue = tgl_tat
                    Else
                        Dim tgl_tat As DateTime = New DateTime(Today.Year + 1, xbns.Month, 25)
                        de_debet.EditValue = tgl_tat
                    End If
                Case Else
                    lb_bbj.Text = "Bunga Berjalan"
            End Select
            taunan = True
            disabel_bns()
        Else
            taunan = False
            enabel_bns()
            lb_debet.Visible = False
            de_debet.Visible = False
            reset_label()
        End If

        Dim i As Integer
        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
        'MsgBox(dr(i))

        plfnd = dr(i).Item("nilai")
        lb_plafon.Text = plfnd
        lb_bunga.Text = dr(i).Item("Bunga_KSP")
        bunga = dr(i).Item("Bunga_KSP")
        txb_bg.EditValue = bunga
        lb_bunga.Text = bunga
        lb_admin.Text = dr(i).Item("Adm")
        'tx_asr.Text = dr(i).Item("Asuransi")
        lb_prvs.Text = dr(i).Item("provisi")
        lb_denda.Text = dr(i).Item("Denda")
        'lb1_adm.Text = dr(i).Item("Adm")
        lb_admin.Text = dr(i).Item("Adm")
        'tx1_prvs.Text = dr(i).Item("provisi")
        lb_prvs.Text = dr(i).Item("provisi")
        'tx1_asr.Text = dr(i).Item("Asuransi")
        'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
        lb_bunga.Text = bunga
        'te_bg_jln.Text = bunga
        'cb_tglbyr.Text = 25
        bts1 = dr(i).Item("batas_admin1")
        bts2 = dr(i).Item("batas_admin2")
        bts_prv_bns1 = dr(i).Item("batas_prv_bns1")
        bts_prv_bns2 = dr(i).Item("batas_prv_bns2") 'batas_prv_bns1
        jns = dr(i).Item("kode")
        kd2 = Lue_SetPjm.EditValue
        adm_default = dr(i).Item("Adm")
        m_prv = dr(i).Item("provisi")

        If id_jab = "1" Then
            te_bts.EditValue = bts1
            bts_adm = bts1
        Else
            te_bts.EditValue = bts2
            bts_adm = bts2
        End If

        hit_centang()
        'hitung_cicilan()
    End Sub
    Public Sub disabel_bns()
        TE_bns.EditValue = vbNullString
        TE_thr.EditValue = vbNullString
        TE_tat.EditValue = vbNullString
        TE_bns.Enabled = False
        TE_thr.Enabled = False
        TE_tat.Enabled = False
    End Sub
    Public Sub enabel_bns()
        TE_bns.Enabled = True
        TE_thr.Enabled = True
        TE_tat.Enabled = True
        TE_bns.EditValue = 0
        TE_thr.EditValue = 0
        TE_tat.EditValue = 0
    End Sub

    Public Sub reset_label()
        TE_AngsBaru.EditValue = 0
        lb1_net.Text = 0 'nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bgLama.Text = 0
        te_prv.Text = 0
        te_bg_jln.EditValue = 0
        lb_pot_min.Text = 0
        lb_tempo_pot2.Text = 0
        tx1_LamaPJM.Text = ""
    End Sub
    Public Sub prv_all()
        Dim totalpjm As Double = byr_piu
        If id_jab = "1" Then 'jika kary BCA
            'If tgk = True Then
            'totalpjm = bsr_pjm
            If byr_piu >= bts_adm Then
                adm = adm_default
                prv = byr_piu * (m_prv / 100)
                'prv = (totalpjm - bts1) * (1 / 100)
            Else
                adm = 0
                prv = 0
            End If

        Else
            If byr_piu >= bts_adm Then
                adm = adm_default
                prv = (byr_piu - bts_adm) * (m_prv / 100)
            Else
                adm = 0
                prv = 0
            End If
        End If

        te_prv.EditValue = prv
    End Sub


    Public Sub prv_bns()
        Dim totalpjm As Double = byr_piu
        If id_jab = "1" Then 'jika kary BCA
            If totalpjm >= bts_adm Then
                adm = adm_default
                prv = (totalpjm - bts) * (m_prv / 100)
            Else
                adm = 0
                prv = 0
            End If

        Else 'jika 'non BCA
            If bsr_pjm > bts_adm Then
                'cb_prv.Checked = True
                adm = adm_default
                bts = bts_prv_bns2
                prv = (bsr_pjm - bts) * (m_prv / 100)
            Else
                adm = 0
                prv = 0
            End If
        End If
        te_prv.EditValue = prv
        'If tgk = True Then
        '    totalpjm = bsr_pjm
        '    bts = bts_prv_bns1
        '    If totalpjm >= bts_prv_bns1 Then
        '        adm = adm_default
        '        prv = (totalpjm - bts) * (m_prv / 100)
        '    Else
        '        adm = 0
        '        prv = 0
        '    End If
        'Else
        '    If bsr_pjm > bts_prv_bns1 Then
        '        'cb_prv.Checked = True
        '        ';adm = bts_admin1
        '        bts = bts_prv_bns1
        '        prv = (bsr_pjm - bts) * (m_prv / 100)

        '    Else
        '        adm = 0
        '        prv = 0
        '    End If
        'End If
    End Sub


    

    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                hit_centang()
            End If


            'MsgBox(t_pot)
            ' hitung_cicilan()

        End If
    End Sub

    Public Sub cicilan_bns()
        If TE_AngsBaru.EditValue = vbNullString Or tx1_LamaPJM.Text = "" Then
            Exit Sub
        End If
        Dim sisa, hr_ini, jml_hr, jm_hr_lalu, jm_hr_dbt, jm_hr_today, jm_hr_bln, jm_bl_lalu, jm_bl_skrg, jm_bl_dbt, tgl_uplod, blnx, bln_skrg, bln_dbt As Integer
        tempo = tx1_LamaPJM.Text
        pokok_pertama = bsr_pjm
        'If bsr_pjm > bts_prv_bns1 Then
        'If cb_prv.Checked = True Then
        t_bunga = bsr_pjm * (bunga / 100)
        te_prv.Text = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
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
            bg_jln = Math.Round(((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt)
            'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * (jm_bl_skrg - jm_hr_bln))
        ElseIf bln_dbt = 1 Then
            'bg_jln = (bg_bns * (bln_dbt)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr)
            bg_jln = Math.Round((((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * jm_hr_dbt + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr)))
        ElseIf bln_dbt > 1 Then
            'bg_jln = (bg_bns * bln_dbt) + ((bsr_pjm * (bunga / 100) / jm_bl_skrg) * jm_hr_today)
            bg_jln = Math.Round((bg_bns * (bln_dbt - 1)) + (((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * jml_hr) + (((bsr_pjm * (bunga / 100)) / jm_bl_dbt) * (jm_hr_dbt)))
        End If
        'If tgldbet >= 25 Then
        '    bg_jln = 0
        'End If
        te_bg_jln.EditValue = bg_jln '.ToString("c", New Globalization.CultureInfo("id-ID", False))

        nett = bsr_pjm + bg_jln + prv + adm
        TE_AngsBaru.EditValue = nett
        tx1_LamaPJM.Text = 1 ' 1x karena bns
        'sisaAng_baru = nett / jm_angs
        'TE_AngsBaru.EditValue = jm_angs
        'tx1_LamaPJM.Text = sisaAng_baru
        ''##JUMLAH TERIMA
        'TE_AngsBaru.EditValue = nett


        'lb1_pk_lama.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        te_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        te_adm.EditValue = adm
        'TE_net.EditValue = nett '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'TE_adm.EditValue = adm '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'TE_prv.EditValue = prv '.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_jumlah.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub TE_BsrPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_AngsBaru.KeyDown
        If e.KeyCode = Keys.Enter Then

            bsr_ccl_baru = TE_AngsBaru.EditValue
            If bsr_ccl_baru < bg_lama Then
                MsgBox(" Angsuran Baru tidak boleh lebih kecil dari Bunga!!!")
                Exit Sub
            End If
            'sisaAng_baru = sisa_pk_lama / (bsr_ccl_baru - bg_lama)
            tx1_LamaPJM.Text = sisaAng_baru
            pot_bns = TE_bns.EditValue
            pot_thr = TE_thr.EditValue
            pot_tat = TE_tat.EditValue
            'MsgBox(dt_tgl.EditValue)
            pot = pot_bns + pot_thr + pot_tat

            tx1_LamaPJM.Focus()
            tx1_LamaPJM.Focus()
        End If
    End Sub

    Private Sub TE_BsrPJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_AngsBaru.KeyPress
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
            hit_centang()
        End If

    End Sub

    'Private Sub cb_pot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_pot.CheckedChanged
    '    If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And tx_id.Text <> "" Then
    '        If cb_pot.Checked = True And t_pot = 0 Then
    '            TE_tat.Enabled
    '            gc_tambahan.Enabled = True
    '            pot_min = (bsr_pjm / 72) * (tx1_LamaPJM.Text / 12)
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

    Private Sub TE_bns_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_bns.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat

                hit_centang()

            End If
            TE_thr.Focus()
        End If
    End Sub

    Private Sub TE_thr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_thr.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                ' lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hit_centang()

            End If
            TE_tat.Focus()
        End If
    End Sub

    Private Sub TE_tat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_tat.KeyDown
        If e.KeyCode = Keys.Enter Then
            'bersihkan()
            If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                pot_bns = TE_bns.EditValue
                pot_thr = TE_thr.EditValue
                pot_tat = TE_tat.EditValue
                'MsgBox(dt_tgl.EditValue)
                pot = pot_bns + pot_thr + pot_tat
                'lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hit_centang()

            End If

        End If
    End Sub



    Private Sub lb_potmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Rumus=(Angsr baru / 72) x (Lama Pinjam / 12))")
    End Sub

    Private Sub LUE_nama_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Cari()
    End Sub

    Private Sub gv_byr_piu_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        hit_centang()
    End Sub

    
    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
            cek_hut()
            Lue_SetPjm.Focus()
        End If
    End Sub

    Private Sub gv_tgk_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv_tgk.RowUpdated
        hit_centang()
        lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub dt_tgl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_tgl.EditValueChanged
        Dim tgle As Date
        tgle = dt_tgl.EditValue
        tgldbet = tgle.Day.ToString
        tgl_1_trans = "01/" & Month(dt_tgl.EditValue).ToString & "/" & Year(dt_tgl.EditValue).ToString
    End Sub

    Private Sub de_debet_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles de_debet.EditValueChanged
        tgl_dbt = de_debet.EditValue
        tgl_1_dbt = "01/" & Month(de_debet.EditValue).ToString & "/" & Year(de_debet.EditValue).ToString
        hitung_cicilan()
    End Sub


    Private Sub te_bg_jln_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_bg_jln.KeyDown
        If e.KeyCode = Keys.Enter And Lue_SetPjm.EditValue <> vbNullString And nett > 0 And tx1_LamaPJM.Text <> "" Then
            bg_jln = te_bg_jln.EditValue
            nett = byr_piu + bg_jln + prv + adm
            lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
    End Sub

    Private Sub te_adm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_adm.KeyDown
        If e.KeyCode = Keys.Enter And Lue_SetPjm.EditValue <> vbNullString And nett > 0 And tx1_LamaPJM.Text <> "" Then
            adm = te_adm.EditValue
            nett = byr_piu + bg_jln + prv + adm
            lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
    End Sub

    Private Sub te_prv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_prv.KeyDown
        If e.KeyCode = Keys.Enter And Lue_SetPjm.EditValue <> vbNullString And nett > 0 And tx1_LamaPJM.Text <> "" Then
            prv = te_prv.EditValue
            nett = byr_piu + bg_jln + prv + adm
            lb1_net.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
    End Sub

    Private Sub txb_bg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_bg.KeyDown
        If e.KeyCode = Keys.Enter And Lue_SetPjm.EditValue <> vbNullString And nett > 0 And tx1_LamaPJM.Text <> "" Then
            bunga = txb_bg.Text
        End If

    End Sub
End Class