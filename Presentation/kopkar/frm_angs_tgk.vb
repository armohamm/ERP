Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_angs_tgk
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns, ntran_cek, no_krd, no_trn As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_tbh As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1, rw_tgk, rw_hist As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, da_tbh As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, byr_piu, dibayar, kembali, pkok, angs, denda, bunga, adm, total, net_tagih, angz, bg_jln, nett, sisa_pokok, sisa_pokok_baru, jml_pinjaman As Double
    'Private BTRAN As SqlTransaction
    Private angs_ke, sisa_ang, sisa_baru As Integer
    Dim tglskrg As Date = getTanggal()

    Public Sub add_click()

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD"
        disabel()
        LUE_nama.Focus()
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
    Private Function blthn(Optional ByVal btran As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btran Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,4)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,4) as blthn", sqlconn, btran).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur(ByVal kode As String)
        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where no_trans='" & kode & "'", sqlconn))
        'DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from angsuran where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        'gc_byr_piu.DataSource = dSO1.Tables("_trans")
        da_tbh = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as sisa_pokok,0 as no_seq,'' as cek_byr,* from tunggakan where nasabah_id='" & kode & "'", sqlconn))
        da_tbh.Fill(ds_tbh, "_tbh")
        gc_byr_piu.DataSource = ds_tbh.Tables("_tbh")
        'Gc_angs.DataSource = dSO1.Tables("_trans")
    End Sub

    Private Sub loadPemb()
        If Not dSO.Tables("pembayaran") Is Nothing Then dSO.Tables("pembayaran").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar nama FROM KOPKAR.dbo.m_buku_besar WHERE pola_entry = '01' AND grup_level2 IN ('110','111') AND Rec_stat = 'Y' AND grup_header = 'D'", sqlconn))
        DA.Fill(dSO, "pembayaran")
        lckPembayaran.Properties.DataSource = dSO.Tables("pembayaran")
        lckPembayaran.Properties.DisplayMember = "nama"
        lckPembayaran.Properties.ValueMember = "kd_buku_besar"
    End Sub

    Public Sub save_click()
        If TE_byr.EditValue = vbNullString Or lckPembayaran.EditValue = vbNullString Then
            MsgBox("Nilai Bayar/Bank Tujuan belum di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        'bersihkan()
        'LoadStruktur("xxx")
    End Sub

    Public Sub simpan()

        'hitung_cicilan()
     

        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            row = dSO1.Tables("_trans").NewRow

            no_trn = get_notran()
            row.Item("no_trans") = no_trn
            row.Item("id_cabang") = getKodeCabang()
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Create_By") = username
            row.Item("cetak_ke") = 0
            row.Item("kode_lunas") = 2 '2offlie, 1:online autodebet
            row.Item("blthn") = blthn()


        End If
        row.Item("tgl_bayar") = dt_tgl.EditValue
        row.Item("nasabah_id") = LUE_nama.EditValue
        row.Item("no_kredit") = no_trn
        row.Item("rp_tagihan") = TE_jml_byr.EditValue
        row.Item("rp_pokok") = TE_jml_byr.EditValue
        row.Item("rp_total") = TE_jml_byr.EditValue
        row.Item("rp_bunga") = 0
        row.Item("rp_admin") = 0
        row.Item("rp_denda") = 0

        If STATE = "EDIT" Then
            row = dSO1.Tables("_trans").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Update_By") = username
        End If

        If STATE = "ADD" Then
            dSO1.Tables("_trans").Rows.Add(row)
        End If

        Try

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            For Each rw_tgk As DataRow In ds_tbh.Tables("_tbh").Select("cek_byr = 'Y'")
                Dim sqlcmd1 As New SqlCommand("update tunggakan set stat_lunas=1,no_ref_lunas='" & no_trn & "', user_lunas='" & namauser & "', tgl_lunas=@tgl where no_kartu='" & rw_tgk.Item("no_kartu") & "'", sqlconn, BTRANS)
                sqlcmd1.Parameters.AddWithValue("@tgl", dt_tgl.EditValue)
                sqlcmd1.ExecuteNonQuery()
            Next
           

            DA2.Update(dSO1.Tables("_trans"))

            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            prn.btnSave.Enabled = False
            prn.btnAdd.Enabled = True
        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables("_trans").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub cancel_click()
        bersihkan()
        LoadStruktur("XXX")

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False

    End Sub

    Private Sub bersihkan()

        If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()
        lb_bunga.Text = ""
        lb_denda.Text = ""
        lb_pokok.Text = ""
        TE_jml_byr.EditValue = vbNullString
        TE_byr.EditValue = vbNullString
        TE_kembali.EditValue = vbNullString
        'tx_id.Text = ""
        'tx_nama.Text = ""
        'tx_noTbg.Text = ""
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_agd").Clear()

        'LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString

    End Sub


    'Public Sub Cari()
    '    DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,k.no_trans,a.Nama,a.Almt_asal,k.JML_PINJAMAN,k.sisa_pokok,k.JML_POKOK,k.JML_BUNGA,k.LAMA_ANGS as tempo,k.sisa_angs from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.status_lunas='BELUM' and jenis <> 'BNS '", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
    '    If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
    '    DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
    '    frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
    '    frmCari.GV.Columns("JML_PINJAMAN").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    frmCari.GV.Columns("JML_POKOK").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    frmCari.GV.Columns("JML_BUNGA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    frmCari.GV.Columns("sisa_pokok").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    frmCari.GV.Columns("JML_PINJAMAN").DisplayFormat.FormatString = "n2"
    '    frmCari.GV.Columns("JML_POKOK").DisplayFormat.FormatString = "n2"
    '    frmCari.GV.Columns("JML_BUNGA").DisplayFormat.FormatString = "n2"
    '    frmCari.GV.Columns("sisa_pokok").DisplayFormat.FormatString = "n2"
    '    frmCari.ShowDialog() '<-- menampilkan form LOV
    '    If Not frmCari.row Is Nothing Then
    '        'tx_nama.Text = frmCari.row("Nama")
    '        tx_id.Text = frmCari.row("nasabah_id")
    '        'tx_alamant.Text = frmCari.row("Almt_asal")
    '        id_anggota = frmCari.row("nasabah_id")
    '        s1 = frmCari.row("sisa_angs")
    '        tx_noTbg.Text = frmCari.row("no_trans")
    '        no_krd = frmCari.row("no_trans")
    '        'tx_saldo1.Text = frmCari.row("Jml_Angsuran")
    '        bunga = frmCari.row("JML_BUNGA")
    '        pkok = frmCari.row("JML_POKOK")
    '        'adm = frmCari.row("JML_DENDA")
    '        sisa_ang = frmCari.row("sisa_angs")
    '        sisa_pokok = frmCari.row("sisa_pokok")
    '        jml_pinjaman = frmCari.row("JML_PINJAMAN")

    '        hitung_angs()
    '        'MsgBox(angs_ke)

    '    End If
    'End Sub

   

    Private Sub frm_angs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")
        dt_tgl.EditValue = Today
        loadPemb()
        lckPembayaran.EditValue = "111.01.06"
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota where Rec_Stat=1", sqlconn))
        DALOOKUP.Fill(ds_cari, "_nm")
        LUE_nama.Properties.DataSource = ds_cari.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"
    End Sub
    Public Sub cek_denda()
        bg_jln = 0

        Dim sisa, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, tgl_uplod, blnx, bln_skrg As Integer
        'sisa, denda, jml_hr, jm_hr_lalu, jm_hr_today, jm_bl_lalu, jm_bl_skrg, tgl_uplod, blnx, bln_skrg = 0
        'Dim  As Decimal

        'Dim tgl_uplod, blnx, bln_skrg As String, getdate=convert(date,'" & dt_tgl.EditValue & "',103)

        'Dim sqdr1 As SqlDataReader = New SqlCommand("select DAY(tgl_eksekusi) as tgl, MONTH(tgl_eksekusi) as blnx, month(GETDATE()) as bln_skrg, " & _
        '                                            " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
        '                                                 " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
        '                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
        '                                            " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg " & _
        '                                            " from export_log ", sqlconn).ExecuteReader
        Dim sqdr1 As SqlDataReader = New SqlCommand("select 25 as tgl, MONTH(tgl_eksekusi) as blnx, month(GETDATE()) as bln_skrg, " & _
                                                   " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
                                                   " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
                                                   " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg " & _
                                                   " from export_log ", sqlconn).ExecuteReader
        sqdr1.Read()
        If sqdr1.HasRows Then


            tgl_uplod = sqdr1.Item("tgl")
            blnx = sqdr1.Item("blnx")
            bln_skrg = sqdr1.Item("bln_skrg")
            jm_hr_lalu = sqdr1.Item("jm_hr_lalu")
            jm_hr_today = sqdr1.Item("jm_hr_today")
            jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
            jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
        Else
            MsgBox("Data Export Log Bulan Lalu Kosong", MsgBoxStyle.Exclamation)
            sqdr1.Close()
            Exit Sub
        End If
        sqdr1.Close()


        If blnx <> bln_skrg Then
            bg_jln = (bunga * jm_hr_lalu / jm_bl_lalu) + (bunga * jm_hr_today / jm_bl_skrg)
            'txr_bunga.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        Else
            bg_jln = 0
            'txr_bunga.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If

        'MsgBox(tglskrg.Day)
        'If tglskrg.Month = "24" Then
        '    'MsgBox("tgl 24")

        'End If
    End Sub
    'Public Sub hitung_angs()
    '    'cek_denda()  'tunggakan fix, ga pake bg berjalan
    '    angz = pkok + bunga
    '    net_tagih = pkok + bunga + bg_jln
    '    sisa_baru = sisa_ang - 1
    '    angs_ke = sisa_ang - sisa_baru
    '    sisa_pokok_baru = angz

    '    lb_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    lb_pokok.Text = pkok.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    TE_jml_byr.EditValue = net_tagih.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    'lb_denda.Text = denda.ToString("c", New Globalization.CultureInfo("id-ID", False))
    '    lb_denda.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
    'End Sub
    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,4)+1 as numeric)) from angsuran where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "0001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 3
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
        ntran_cek = "T" & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from angsuran where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = "T" & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = "T" & blthn() & "0001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Private Sub TE_byr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_byr.KeyDown

        If e.KeyCode = Keys.Enter Then
            If lckPembayaran.EditValue = vbNullString Then
                MsgBox("Kode Bank harus di Isi!!", MsgBoxStyle.Exclamation)
                TE_byr.Focus()
                Exit Sub
            End If
            net_tagih = TE_jml_byr.EditValue
            dibayar = TE_byr.EditValue
            kembali = dibayar - net_tagih

            If kembali <= 0 Then
                MsgBox("Nilai yg di bayar tidak mencukupi, Ulangi lagi", MsgBoxStyle.Exclamation)
                kembali = 0
                TE_kembali.EditValue = kembali.ToString("c", New Globalization.CultureInfo("id-ID", False))
                Exit Sub
            End If

            TE_kembali.EditValue = kembali.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'Dim x As Integer = 0
            'If LUE_nama.EditValue <> vbNullString Then
            '    'hitung_angs()
            '    Dim row As DataRow = dSO1.Tables("_trans").NewRow
            '    row.Item("no_trans") = get_notran()
            '    row.Item("Last_Create_Date") = getTanggal()
            '    row.Item("Last_Create_By") = username
            '    row.Item("id_cabang") = getKodeCabang()
            '    row.Item("blthn") = blthn()
            '    row.Item("tgl_bayar") = getTanggal()
            '    row.Item("nasabah_id") = LUE_nama.EditValue
            '    'row.Item("no_kredit") = tx_noTbg.Text
            '    row.Item("rp_tagihan") = jml_pinjaman
            '    row.Item("rp_pokok") = pkok
            '    row.Item("rp_bunga") = bunga
            '    row.Item("rp_admin") = 0
            '    row.Item("rp_denda") = bg_jln
            '    row.Item("rp_total") = net_tagih
            '    row.Item("sisa_angs") = sisa_baru
            '    row.Item("angsuran_ke") = angs_ke
            '    row.Item("sisa_pokok") = sisa_pokok_baru
            '    row.Item("kd_buku_besar") = lckPembayaran.EditValue
            '    row.Item("Nama") = LUE_nama.Text
            '    row.Item("Last_Create_By") = username
            '    row.Item("Last_Create_Date") = getTanggal()

            '    'row1.Item("no_kredit") = tx_noTbg.Text
            '    'row1.Item("angsuran_ke") = angs_ke
            '    'row1.Item("sisa_angs") = sisa_baru
            '    'row1.Item("nasabah_id") = id_anggota
            '    'row1.Item("tgl_bayar") = getTanggal()
            '    'row1.Item("rp_pokok") = pkok
            '    'row1.Item("rp_bunga") = bunga
            '    'row1.Item("rp_denda") = bg_jln
            '    'row1.Item("rp_total") = net_tagih
            '    'row1.Item("Nama") = tx_nama.Text
            '    'row1.Item("Last_Create_By") = username
            '    'row1.Item("Last_Create_Date") = getTanggal()
            '    'row1.Item("tgl_tempo") = 

            '    dSO1.Tables("_trans").Rows.Add(row)


            lckPembayaran.Focus()
            'End If
        End If
    End Sub

    Private Sub TE_byr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TE_byr.KeyPress
        If Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) >= 60 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub lckPembayaran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lckPembayaran.KeyDown
        If e.KeyCode = Keys.Enter Then
            save_click()
        End If
    End Sub

    Private Sub lckPembayaran_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckPembayaran.QueryPopUp
        loadPemb()

    End Sub

    Public Sub hit_centang()
        byr_piu = 0
        For Each rw_tgk As DataRow In ds_tbh.Tables("_tbh").Select("cek_byr='Y'")
            byr_piu += rw_tgk.Item("rp_tunggakan")
        Next
        'hitung_all()
        TE_jml_byr.EditValue = byr_piu
        'nett = nett - byr_piu
        'lb1_terima.Text = nett.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            enabel()
            cek_hut()

        End If
    End Sub
    Public Sub enabel()
        gc_byr_piu.Enabled = True
        TE_jml_byr.Enabled = True
    End Sub
    Public Sub disabel()
        gc_byr_piu.Enabled = False
        TE_jml_byr.Enabled = False
    End Sub
    Public Sub cek_hut()
        If STATE = "ADD" Then
            If Not ds_tbh.Tables("_tbh") Is Nothing Then
                ds_tbh.Tables("_tbh").Clear()
            End If
            Dim i As Int16 = 1
            Dim sqltgk As SqlDataReader = New SqlCommand("select * from tunggakan where nasabah_id= '" & LUE_nama.EditValue & "' and stat_lunas=0", sqlconn).ExecuteReader
            While sqltgk.Read()
                rw_tgk = ds_tbh.Tables("_tbh").NewRow

                rw_tgk.Item("no_seq") = i : i += 1
                rw_tgk.Item("rp_tunggakan") = sqltgk.Item("rp_tunggakan")
                'rw_tgk.Item("angsuran_ke") = 1
                rw_tgk.Item("tgl_trans") = sqltgk.Item("tgl_trans")
                rw_tgk.Item("jenis") = sqltgk.Item("jenis")
                'rw_tgk.Item("rp_tagihan") = sqltgk.Item("rp_tunggakan")
                rw_tgk.Item("no_kartu") = sqltgk.Item("no_kartu")
                'rw_tgk.Item("stat_lunas") = "BELUM"
                rw_tgk.Item("cek_byr") = "T"
                rw_tgk.Item("keterangan") = sqltgk.Item("keterangan")
                'rw_tgk.Item("create_date") = getTanggal()
                'rw_tgk.Item("create_by") = username

                ds_tbh.Tables("_tbh").Rows.Add(rw_tgk)
            End While
            sqltgk.Close()

            'Dim sqdrx As SqlDataReader = New SqlCommand("select JML_POKOK+JML_BUNGA as angs_dd,(LAMA_ANGS-sisa_angs)+1 as angs_ke,* from kredit where nasabah_id= '" & LUE_nama.EditValue & "'and stat_approve >= 5 and status_lunas='BELUM'", sqlconn).ExecuteReader
            'While sqdrx.Read()
            '    rw_hist = dSO1.Tables("_trans").NewRow

            '    rw_hist.Item("no_seq") = i : i += 1
            '    rw_hist.Item("rp_tagihan") = sqdrx.Item("angs_dd")
            '    rw_hist.Item("angsuran_ke") = sqdrx.Item("angs_ke")
            '    rw_hist.Item("sisa_pokok") = sqdrx.Item("sisa_pokok")
            '    rw_hist.Item("rp_tagihan") = sqdrx.Item("JML_PINJAMAN")
            '    rw_hist.Item("no_kredit") = sqdrx.Item("no_trans")
            '    rw_hist.Item("keterangan") = sqdrx.Item("jenis")
            '    rw_hist.Item("stat_lunas") = "BELUM"
            '    rw_hist.Item("cek_byr") = "T"
            '    rw_hist.Item("tgl_bayar") = dt_tgl.EditValue
            '    rw_hist.Item("Last_Create_Date") = getTanggal()
            '    rw_hist.Item("Last_Create_By") = username

            '    dSO1.Tables("_trans").Rows.Add(rw_hist)
            'End While
            'sqdrx.Close()

        End If

        'For Each row1 As DataRow In ds_tbh.Tables("_tbh").Rows
        '    row1.Item("no_trans") = row.Item("no_trans")
        '    row1.Item("tgl_trans") = getTanggal()
        '    row1.Item("create_date") = getTanggal()
        '    row1.Item("create_by") = username
        'Next

        gc_byr_piu.DataSource = ds_tbh.Tables("_tbh")
        gv_byr_piu.BestFitColumns()


    End Sub

    Private Sub gv_byr_piu_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv_byr_piu.RowUpdated
        hit_centang()
    End Sub

    Private Sub cb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_all.CheckedChanged
        If cb_all.Checked = True Then
            For i As Integer = 0 To gv_byr_piu.RowCount - 1
                gv_byr_piu.SetRowCellValue(i, "cek_byr", "Y")
            Next

        ElseIf cb_all.Checked = False Then
            For i As Integer = 0 To gv_byr_piu.RowCount - 1
                gv_byr_piu.SetRowCellValue(i, "cek_byr", "T")
            Next
        End If
        hit_centang()
    End Sub
End Class