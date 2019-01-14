Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_angs1
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns, ntran_cek, no_krd As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, dibayar, kembali, pkok, angs, denda, bunga, adm, total, net_tagih, angz, bg_jln, bg_lama, sisa_pokok, sisa_pokok_baru, jml_pinjaman As Double
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
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from angsuran where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_rec where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dso2, "_hist")
        GcHist.DataSource = dso2.Tables("_hist")
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
        bersihkan()
        LoadStruktur("xxx")
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then
        '    row = dSO1.Tables("_trans").NewRow

        '    'row.Item("no_trans") = id_anggota + jns + blthn()
        '    row.Item("Last_Create_Date") = getTanggal()
        '    row.Item("Last_Create_By") = username
        '    'row.Item("cetak_ke") = 0
        '    row.Item("blthn") = blthn()
        '    row.Item("tgl_bayar") = getTanggal()
        '    row.Item("nasabah_id") = tx_id.Text
        '    row.Item("no_kredit") = tx_noTbg.Text
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

        If STATE = "EDIT" Then
            row = dSO1.Tables("_trans").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Update_By") = username
        End If

        'If STATE = "ADD" Then
        '    dSO1.Tables("_trans").Rows.Add(row)
        'End If

        Try

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            'Dim sqlcmd1 As New SqlCommand("update kredit set sisa_angs=" & sisa_ang & " where no_trans='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.ExecuteNonQuery()

            DA2.Update(dSO1.Tables("_trans"))

            BTRANS.Commit()
            showMessages("Berhasil disimpan")
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

        If Not dso2.Tables("_krd") Is Nothing Then dso2.Tables("_agd").Clear()
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_hist").Clear()
        lb_bunga.Text = ""
        lb_denda.Text = ""
        lb_pokok.Text = ""
        lb_tot.Text = ""
        TE_byr.EditValue = vbNullString
        TE_kembali.EditValue = vbNullString
        tx_id.Text = ""
        tx_nama.Text = ""
        'tx_noTbg.Text = ""
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_agd").Clear()

        'LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString

    End Sub


    Public Sub Cari()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select a.nasabah_id,k.no_trans,a.Nama,a.Almt_asal,k.JML_PINJAMAN,k.sisa_pokok,k.JML_POKOK,k.JML_BUNGA,k.LAMA_ANGS as tempo,k.sisa_angs from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.status_lunas='BELUM' and jenis <> 'BNS '", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns("JML_PINJAMAN").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("JML_POKOK").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("JML_BUNGA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("sisa_pokok").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("JML_PINJAMAN").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("JML_POKOK").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("JML_BUNGA").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("sisa_pokok").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            tx_nama.Text = frmCari.row("Nama")
            tx_id.Text = frmCari.row("nasabah_id")
            'tx_alamant.Text = frmCari.row("Almt_asal")
            id_anggota = frmCari.row("nasabah_id")
            s1 = frmCari.row("sisa_angs")
            'tx_noTbg.Text = frmCari.row("no_trans")
            no_krd = frmCari.row("no_trans")
            'tx_saldo1.Text = frmCari.row("Jml_Angsuran")
            bunga = frmCari.row("JML_BUNGA")
            pkok = frmCari.row("JML_POKOK")
            'adm = frmCari.row("JML_DENDA")
            sisa_ang = frmCari.row("sisa_angs")
            sisa_pokok = frmCari.row("sisa_pokok")
            jml_pinjaman = frmCari.row("JML_PINJAMAN")

            hitung_angs()
            'MsgBox(angs_ke)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cari()
        TE_byr.Focus()
    End Sub

    Private Sub frm_angs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")
        dt_tgl.EditValue = Today
        loadPemb()
        lckPembayaran.EditValue = "111.01.06"
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id, Nama from anggota", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'RL_nasabah.DataSource = ds_cari.Tables("_lookup")
        'RL_nasabah.ValueMember = "nasabah_id"
        'RL_nasabah.DisplayMember = "Nama"
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
            lb_denda.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        Else
            bg_jln = 0
            lb_denda.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If
        'MsgBox(tglskrg.Day)
        'If tglskrg.Month = "24" Then
        '    'MsgBox("tgl 24")

        'End If
    End Sub
    Public Sub hitung_angs()
        cek_denda()
        angz = pkok + bunga
        net_tagih = pkok + bunga + bg_jln
        sisa_baru = sisa_ang - 1
        angs_ke = sisa_ang - sisa_baru
        sisa_pokok_baru = angz

        lb_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_pokok.Text = pkok.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_tot.Text = net_tagih.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_denda.Text = denda.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_denda.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub
    Public Function get_notran() As String
        'stat_tran = True

        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = no_krd & blthn()
        MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from angsuran where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = no_krd & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = no_krd & blthn() & "001"
            'MsgBox(ntran_cek)
        End If

        sqlr.Close()
        Return ntran_cek
    End Function
    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,16,3)+1 as numeric)) from angsuran where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
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

    Private Sub TE_byr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_byr.KeyDown

        If e.KeyCode = Keys.Enter Then
            If lckPembayaran.EditValue = vbNullString Then
                MsgBox("Kode Bank harus di Isi!!", MsgBoxStyle.Exclamation)
                TE_byr.Focus()
                Exit Sub
            End If
            dibayar = TE_byr.EditValue
            kembali = dibayar - net_tagih

            If kembali <= 0 Then
                MsgBox("Nilai yg di bayar tidak mencukupi, Ulangi lagi", MsgBoxStyle.Exclamation)
                kembali = 0
                TE_kembali.EditValue = kembali.ToString("c", New Globalization.CultureInfo("id-ID", False))
                Exit Sub
            End If

            TE_kembali.EditValue = kembali.ToString("c", New Globalization.CultureInfo("id-ID", False))
            Dim x As Integer = 0
            If tx_id.Text <> "" Then
                'hitung_angs()
                Dim row As DataRow = dSO1.Tables("_trans").NewRow
                row.Item("no_trans") = get_notran()
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Create_By") = username
                row.Item("id_cabang") = getKodeCabang()
                row.Item("blthn") = blthn()
                row.Item("tgl_bayar") = getTanggal()
                row.Item("nasabah_id") = tx_id.Text
                'row.Item("no_kredit") = tx_noTbg.Text
                row.Item("rp_tagihan") = jml_pinjaman
                row.Item("rp_pokok") = pkok
                row.Item("rp_bunga") = bunga
                row.Item("rp_admin") = 0
                row.Item("rp_denda") = bg_jln
                row.Item("rp_total") = net_tagih
                row.Item("sisa_angs") = sisa_baru
                row.Item("angsuran_ke") = angs_ke
                row.Item("sisa_pokok") = sisa_pokok_baru
                row.Item("kd_buku_besar") = lckPembayaran.EditValue
                row.Item("Nama") = tx_nama.Text
                row.Item("Last_Create_By") = username
                row.Item("Last_Create_Date") = getTanggal()

                'row1.Item("no_kredit") = tx_noTbg.Text
                'row1.Item("angsuran_ke") = angs_ke
                'row1.Item("sisa_angs") = sisa_baru
                'row1.Item("nasabah_id") = id_anggota
                'row1.Item("tgl_bayar") = getTanggal()
                'row1.Item("rp_pokok") = pkok
                'row1.Item("rp_bunga") = bunga
                'row1.Item("rp_denda") = bg_jln
                'row1.Item("rp_total") = net_tagih
                'row1.Item("Nama") = tx_nama.Text
                'row1.Item("Last_Create_By") = username
                'row1.Item("Last_Create_Date") = getTanggal()
                'row1.Item("tgl_tempo") = 

                dSO1.Tables("_trans").Rows.Add(row)


                lckPembayaran.Focus()
            End If
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
    Public Sub hit_cicilan()
        For Each rw In dso2.Tables("_hist").Select("nilai>0")

        Next
    End Sub
    
    Private Sub Gv_hist_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gv_hist.CellValueChanged
        If e.Column Is gc_nilai Then
            hit_cicilan()
        End If
    End Sub
End Class