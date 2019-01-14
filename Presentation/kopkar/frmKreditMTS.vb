'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmKreditMTS
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
    Private dSO, dSO1, ds_tbh, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2, dsjab, dsNama, ds_mts As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, row3 As DataRow
    Private tempo_pot, sisaAng_baru, lama_pjm As Integer
    Private DA, DA1, DA2, DALOOKUP, daJab, daNama, DALOOKUP1, DA_gdg1, da_tbh, DA_MTS As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, pot_min, bsr_ccl_baru, sisa_pk_lama, pot_bns, pot_thr, pot_tat, lama_ang, sisaAng_lama, angs, adm, denda, t_bunga, pokok_pertama, t_pot, pot,pot_hrs,total, recov, prv, bg_lama, ang_lama, pk_lama, after_pot, bg_baru, t_bgBaru, sisa_pk_after_ptg, ang_baru, t_pk_baru, pokok_br, pokok_akhir, selisih_pokok, t_pk_br_akhir As Double
    Private BTRAN As SqlTransaction
    Public stat_tran, stat_rec As Boolean
    Public idJab, ntran_cek, notrans, str2 As String
    Dim foto() As Byte



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Private Sub bersihkan()
        'tx_id.Text = ""
        'lb1_bg_baru.Text = ""
        lb1_pk_lama.Text = ""
        LUE_nama.EditValue = vbNullString
        'lb1_angBaru.Text = ""
        'lb1_jumlah.Text = ""
        'lb1_net.Text = ""
        tx1_ket.Text = ""
        'tx1_LamaPJM.Text = ""
        lb1_RPangLama.Text = ""
        'lb1.Text = ""
        'tx1_asr.Text = ""
        lb1_RPangLama.Text = ""
        TE_AngsBaru.EditValue = vbNullString
        'txr_adm.Text = ""
        'txr_bunga.Text = ""
        'txr_jmlHut.Text = ""
        'txr_pen.Text = ""
        'txr_prvs.Text = ""
        'txr_total.Text = ""

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
        If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,JML_BUNGA+JML_POKOK as ang from kredit where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")

        DA_MTS = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_mtsi where no_trans='" & kode & "'", sqlconn))
        DA_MTS.Fill(ds_mts, "_mts")

        'da_tbh = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_pot where no_trans='" & kode & "'", sqlconn))
        'da_tbh.Fill(ds_tbh, "_tbh")
        'gc_tambahan.DataSource = ds_tbh.Tables("_tbh")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)
            id_anggota = rwm("nasabah_id").ToString
            LUE_nama.EditValue = rwm("nasabah_id").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            Lue_tipe.EditValue = rwm("tipe").ToString
            'tx_id.Text = rwm("nasabah_id").ToString
            lb1_Pinjam.Text = rwm("JML_PINJAMAN").ToString
            tx1_LamaPJM.Text = rwm("LAMA_ANGS").ToString
            Lue_SetPjm.EditValue = rwm("jenis").ToString
            lb1_pk_lama.Text = rwm("JML_POKOK").ToString
            lb1_bgLama.Text = rwm("JML_BUNGA").ToString
            lb1_RPangLama.Text = rwm("ang").ToString
            lb_notrans_lama.Text = rwm("no_trans").ToString
            'MsgBox(rwm("stat_provisi").ToString)
            'cb_prv.CheckState = IIf(rwm("stat_provisi") = True, cb_prv.Checked = True, cb_prv.Checked = False)
            'lb1_prvs.Text = rwm("JML_PROVISI").ToString
            lb_t_hit.Text = rwm("JML_PINJAMAN").ToString
            TE_AngsBaru.EditValue = rwm("ang").ToString

            pot = pot_bns + pot_thr + pot_tat
            lama_pjm = tx1_LamaPJM.Text
            t_pot = pot * (lama_pjm / 12) 'lama bulan/12 = setehun/pertehun

            angs = rwm("ang")
            pokok_pertama = rwm("JML_POKOK")
            t_bunga = rwm("JML_BUNGA")
            adm = rwm("JML_ADMIN")
            prv = rwm("JML_PROVISI")
            bsr_pjm = rwm("JML_PINJAMAN")
            pk_lama = rwm("JML_POKOK")
            after_pot = IIf(rwm.IsNull("sisa_pokok_after_potong"), 0, rwm("sisa_pokok_after_potong").ToString)
            'total = t_pot + t_pk_br

            'lb1_pokok.Text = pokok_asli.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_pokok_br.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_bunga_br.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_ang_baru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_total_ang.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'lb1_prvs.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'tampilan sebelah
            lb_tpokok.Text = t_pk_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_tpot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_pkBaru.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))

            lb_tempo.Text = lama_pjm
            lb_tempo2.Text = lama_pjm
            lb_tempo3.Text = lama_pjm
            lb_tempo_pot.Text = lama_pjm / 12

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
        btCari.Enabled = False
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
        If pot_hrs <> pot Then
            MsgBox("Nilai Potongan Harus seusia Rumus,!", MsgBoxStyle.Critical)
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
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

    End Sub
    Public Sub simpan()
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
        row.Item("tipe") = Lue_tipe.EditValue
        'row.Item("tipe") = Lue_tipe.EditValue
        row.Item("JML_PINJAMAN") = bsr_pjm
        'row.Item("JML_PINJAMAN") = sisa_pk_lama
        row.Item("JML_DENDA") = lb_denda.Text
        row.Item("JML_ADMIN") = bg_lama
        row.Item("JML_POKOK") = pokok_br
        row.Item("JML_BUNGA") = bg_lama
        row.Item("JML_POKOK_TERAKHIR") = pokok_akhir
        row.Item("bunga") = bunga
        row.Item("sisa_pokok_after_potong") = t_pk_baru
        row.Item("sisa_pokok") = sisa_pk_lama


        row.Item("JML_PROVISI") = prv


        row.Item("TGL_PENGAJUAN") = getTanggal()
        row.Item("STATUS_AKTIF") = 1
        row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
        row.Item("sisa_angs") = tx1_LamaPJM.Text
        row.Item("TGL_TAGIHAN") = cb_tglbyr.Text
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
        row.Item("no_jaminan") = tx_jaminan.Text
        row.Item("foto_jaminan") = foto
        dSO.Tables("_krd").Rows.Add(row)

        row3.Item("no_trans") = notrans
        row3.Item("no_kredit") = notran_lama
        row3.Item("jml_pinjaman") = bsr_pjm
        row3.Item("jml_denda") = lb_denda.Text
        row3.Item("jml_admin") = bg_lama
        row3.Item("jml_pokok") = pokok_br
        row3.Item("jml_bunga") = bg_baru
        row3.Item("bunga") = bunga
        row3.Item("bunga") = bunga
        row3.Item("sisa_pokok_after_potong") = t_pk_baru
        row3.Item("sisa_pokok") = sisa_pk_lama
        row3.Item("create_by") = username
        row3.Item("create_date") = getTanggal()
        row3.Item("tgl_trans") = getTanggal()
        row3.Item("jml_pokok_lama") = pk_lama
        row3.Item("jml_bunga_lama") = bg_lama
        row3.Item("lama_angs") = sisaAng_lama
        row3.Item("sisa_angs") = tx1_LamaPJM.Text


        'row.Item("no_rek") = txb_norek.Text
        'row.Item("nama_bank") = txb_bank.Text

        ds_mts.Tables("_mts").Rows.Add(row3)
        'If STATE = "ADD" Then  ''## karena mutasi tidak perlu ada perubahan no kredit atau record baru di table kredit
        '    dSO.Tables("_krd").Rows.Add(row)
        'End If


        'For Each row1 As DataRow In ds_tbh.Tables("_tbh").Rows
        '    row1.Item("no_trans") = row.Item("no_trans")
        '    row1.Item("tgl_trans") = getTanggal()
        '    row1.Item("create_date") = getTanggal()
        '    row1.Item("create_by") = username
        'Next
        'tabel mutasi mrd-mts

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(da_tbh)
            'da_tbh.UpdateCommand = Buildernya.GetUpdateCommand()
            'da_tbh.InsertCommand = Buildernya.GetInsertCommand()
            'da_tbh.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA_MTS)
            DA_MTS.UpdateCommand = Buildernya.GetUpdateCommand()
            DA_MTS.InsertCommand = Buildernya.GetInsertCommand()
            DA_MTS.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA_MTS.UpdateCommand.Transaction = BTRANS
            DA_MTS.InsertCommand.Transaction = BTRANS
            DA_MTS.DeleteCommand.Transaction = BTRANS


            'da_tbh.UpdateCommand.Transaction = BTRANS
            'da_tbh.InsertCommand.Transaction = BTRANS
            'da_tbh.DeleteCommand.Transaction = BTRANS


            DA.Update(dSO.Tables("_krd"))
            'da_tbh.Update(ds_tbh.Tables("_tbh"))
            DA_MTS.Update(ds_mts.Tables("_mts"))

            Dim sqlcmd As New SqlCommand("update kredit set sisa_angs=0,no_ref='" & notrans & "', status_lunas='PENDING',lunas_by='" & username & "',tgl_lunas=@tgl, KETERANGAN='RESCHEDUL KREDIT,ANGSURAN DIPERKECIL/BESAR' where no_trans='" & notran_lama & "'", sqlconn, BTRANS)
            sqlcmd.Parameters.AddWithValue("@tgl", getTanggal(BTRANS))
            'sqlcmd.Parameters.AddWithValue("@ket", row.Item("keterangan"))
            sqlcmd.ExecuteNonQuery()

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
        'bersihkan()
        bersihkan()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Nama as [Nama],t.no_trans,t.JML_PINJAMAN,u.Bunga_KSP,t.sisa_angs,t.status_lunas,t.TGL_PENGAJUAN,a.job_id,isnull(a.Almt_asal,'')as Almt_asal, * from kredit t left JOIN anggota a on t.nasabah_id=a.nasabah_id left join kota k on a.kode_kota=k.kode_kota left join m_jns_upload u on t.jenis=u.kode where t.stat_cair=1 and t.stat_approve>=5 and t.status_lunas='BELUM' and jenis in ('NOR ','NON ')", sqlconn)) '<- and t.LAMA_ANGS<> t.sisa_angs ,,query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            LUE_nama.EditValue = frmCari.row("nasabah_id")
            lbNIP.Text = frmCari.row("nasabah_id")
            id_anggota = frmCari.row("nasabah_id")
            lb_alamat.Text = frmCari.row("Almt_asal")
            'lb_kota.Text = frmCari("nama_kota")  'IIf(rwm.IsNull("SALDO_AWAL"), 0, rwm.Item("SALDO_AWAL"))
            'lb_kota.Text = IIf(frmCari.row("nama_kota").IsNull, " ", frmCari.row("nama_kota"))
            id_anggota = frmCari.row("nasabah_id")
            LuE_Jab.EditValue = frmCari.row("job_id")
            notran_lama = frmCari.row("no_trans")
            sisaAng_lama = frmCari.row("sisa_angs")
            sisa_pk_lama = frmCari.row("sisa_pokok")
            lama_ang = frmCari.row("LAMA_ANGS")
            bsr_pjm = frmCari.row("JML_PINJAMAN")
            pk_lama = frmCari.row("JML_POKOK")
            bg_lama = frmCari.row("JML_BUNGA")

            bunga = frmCari.row("Bunga_KSP") / 100
            txb_bg.EditValue = bunga
            cb_tglbyr.Text = "25"
            'bunga = row("bunga")
            Lue_tipe.EditValue = "F"
            txb_norek.Text = IIf(frmCari.row.IsNull("no_rek"), frmCari.row("REKBCA1"), frmCari.row("no_rek").ToString)
            txb_bank.Text = "BCA"
            txb_norek2.Text = IIf(frmCari.row.IsNull("no_rek2"), 0, frmCari.row("no_rek2").ToString)
            txb_bank.Text = "BCA"

            'angs = (lama_ang - sisaAng_lama) * pk_lama
            'sisa_pk_lama = bsr_pjm - angs

            lb1_sisaAngs.Text = sisaAng_lama
            tx1_LamaPJM.Text = sisaAng_lama

            ang_lama = bg_lama + pk_lama



            
            LoadStruktur(frmCari.row("no_trans"))
            lb1_sisa_pk.Text = sisa_pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_Pinjam.Text = bsr_pjm.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_bgLama.Text = bg_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_pk_lama.Text = pk_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))

            str2 = Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
            'cek_notran() 'UTK CEK NO TRANS apa adayg sama
        End If
        TE_AngsBaru.Focus()
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
    Public Function get_notran() As String
        'M=Mutasi
        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from kredit_mtsi where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = "M" & Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString() & blthn() & "001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) from kredit_mtsi where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
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
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,no_kartu as no_trans,keterangan as jenis,tgl_trans,rp_tunggakan as Angsuran, " & _
"1 as LAMA_ANGS,1 as sisa_angs,rp_tunggakan as JML_PINJAMAN,rp_tunggakan sisa_pokok from tunggakan where nasabah_id= '" & LUE_nama.EditValue & "' and stat_lunas=0", sqlconn))
        DA2.Fill(dSO1, "_hist") ''tunggakan history

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,JML_POKOK+JML_BUNGA as Angsuran from kredit where nasabah_id= '" & LUE_nama.EditValue & "'and stat_approve >= 5 and status_lunas='BELUM'", sqlconn))
        DA2.Fill(dSO1, "_hist")

        GcHist.DataSource = dSO1.Tables("_hist")
        Gv_hist.BestFitColumns()


    End Sub

    Private Sub frmKreditMTS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur(_notrans)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='KRD' and kd2 in ('01','02')", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DALOOKUP.Fill(ds_cari, "Looktipe")
        Lue_tipe.Properties.DataSource = ds_cari.Tables("Looktipe")
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
        LUE_nama.Properties.DisplayMember = "Nama"

        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Lue_tipe.EditValue = "F"
        Lue_SetPjm.Enabled = False
        Lue_tipe.Enabled = False
        Panel3.Hide()
    End Sub

    Private Sub btCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCari.Click
        Cari()
        cek_hist()
        TE_AngsBaru.Focus()
    End Sub

    'Private Sub gv_tambahan_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    If Lue_SetPjm.EditValue <> vbNullString Then
    '        gv_tambahan.GetRow(e.RowHandle).item("no_seq") = gv_tambahan.RowCount + 1
    '    End If


    'End Sub


    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        Dim i As Integer
        'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
        lb_plafon.Text = dr(i).Item("nilai")

        bunga = dr(i).Item("Bunga_KSP")
        txb_bg.EditValue = bunga
        lb_bg.Text = bunga
        lb_admin.Text = dr(i).Item("adm")
        adm = dr(i).Item("adm")
        'tx_asr.Text = dr(i).Item("Asuransi")
        lb_prvs.Text = dr(i).Item("provisi")
        lb_denda.Text = dr(i).Item("Denda")
        'lb1_adm.Text = dr(i).Item("Adm")
        'lb1_adm.Text = dr(i).Item("Adm")
        'tx1_prvs.Text = dr(i).Item("provisi")
        'lb1_prvs.Text = dr(i).Item("provisiq")
        'tx1_asr.Text = dr(i).Item("Asuransi")
        'tx1_bunga.Text = dr(i).Item("Bunga_KSP")
        'lb1_bunga.Text = dr(i).Item("Bunga_KSP")
        'bunga = txb_bg.EditValue / 100
        cb_tglbyr.Text = 25
        prv = lb_prvs.Text
        jns = Lue_SetPjm.EditValue

    End Sub


    Private Sub hitung_cicilan()
        pot_bns = TE_bns.EditValue
        pot_thr = TE_thr.EditValue
        pot_tat = TE_tat.EditValue
        'MsgBox(dt_tgl.EditValue)
        'pot_hrs=tot
        pot = pot_bns + pot_thr + pot_tat

        lama_pjm = tx1_LamaPJM.Text
        tempo_pot = lama_pjm / 12
        t_pot = pot * tempo_pot 'lama bulan/12 = setehun/pertehun 'lama bulan/12 = setehun/pertehun

        'bersihkan()

        If angs < t_bunga Then
            MsgBox("Angsuran Tidak boleh lebih kecil dari Bunga", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'If cb_pot.Checked Then
        'pot_min = (TE_AngsBaru.EditValue / 72) * (tx1_LamaPJM.Text / 12)
        'lb_potmin.Text = pot_min.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'End If


        sisa_pk_after_ptg = sisa_pk_lama - t_pot
        'bg_baru = sisa_pk_after_ptg * (bunga / 100) 'RP bunga Bulanan baru
        't_bgBaru = bg_baru * tx1_LamaPJM.Text
        pokok_br = TE_AngsBaru.EditValue - bg_lama 'pokok baru=angsuran baru - bunga, sudah di kurangi bunga
        t_pk_baru = pokok_br * tx1_LamaPJM.Text 'dikalikan tempo sisa lama pinjam
        pot_hrs = sisa_pk_lama - t_pk_baru
        pokok_akhir = sisa_pk_lama - (pokok_br * (tx1_LamaPJM.Text - 1))
        'pokok_akhir = sisa_pk_lama - t_pk_baru
        t_pk_br_akhir = t_pk_baru + pokok_akhir
        'End If
        'If TE_AngsBaru.EditValue = vbNullString Then
        '    ang_lama = pokok_pertama + t_bunga
        '    TE_AngsBaru.EditValue = ang_lama
        '    pokok_br = ang_lama - t_bunga 'pokok custom= total angsuran baru - bunga
        'Else
        '    'pokok_br = TE_AngsBaru.EditValue - t_bunga 'pokok custom= total angsuran baru - bunga
        'End If

        ang_baru = pokok_br + bg_baru
        total = t_pot + t_pk_baru


        'lb_tempo4.Text = tx1_LamaPJM.Text

        lb_pot_harus.Text = pot_hrs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_tpokok.Text = t_pk_baru.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_tpot.Text = t_pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_pkBaru.Text = pokok_br.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_t_hit.Text = total.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_t_pot.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb1_RPangLama.Text = ang_lama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_terima.Text = jml_trima.ToString("c", New Globalization.CultureInfo("id-ID", False))

        lb_tempo.Text = tx1_LamaPJM.Text
        lb_tempo2.Text = tx1_LamaPJM.Text
        lb_tempo3.Text = tx1_LamaPJM.Text
        lb_tempo_pot.Text = tempo_pot
        lb_tempo_pot2.Text = tempo_pot


        'lb1_bg_baru.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_angBaru.Text = angs.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_adm.Text = adm.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_RPangLama.Text = prv.ToString("c", New Globalization.CultureInfo("id-ID", False))


    End Sub

    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString Then
                hitung_cicilan()
            End If


            'MsgBox(t_pot)
            ' hitung_cicilan()

        End If
    End Sub


    Private Sub TE_BsrPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_AngsBaru.KeyDown
        If e.KeyCode = Keys.Enter Then
            bsr_ccl_baru = TE_AngsBaru.EditValue
            sisaAng_baru = sisa_pk_lama / bsr_ccl_baru
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
            hitung_cicilan()
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
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

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
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

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
                lb_tpot1.Text = pot.ToString("c", New Globalization.CultureInfo("id-ID", False))
                hitung_cicilan()

            End If

        End If
    End Sub

    

    Private Sub lb_potmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Rumus=(Angsr baru / 72) x (Lama Pinjam / 12))")
    End Sub

    Private Sub txb_bg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txb_bg.EditValueChanged
        bunga = txb_bg.EditValue
        If TE_AngsBaru.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" Then
            hitung_cicilan()
        End If

    End Sub

   
    Private Sub LUE_nama_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LUE_nama.DoubleClick
        Cari()
    End Sub
End Class