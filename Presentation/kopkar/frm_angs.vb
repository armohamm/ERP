'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011     cek               =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_angs
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, dibayar, kembali, pkok, angs, denda, bunga, adm, total, net_tagih, bg_jln, bg_lama As Double
    Private BTRAN As SqlTransaction
    Private angs_ke, sisa_ang, sisa_baru As Integer
    Dim tglskrg As Date = getTanggal()

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

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from angsuran where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        Gc_angs.DataSource = dSO1.Tables("_trans")
    End Sub

    Public Sub save_click()
        If TE_byr.EditValue = vbNullString Then
            MsgBox("Nilai Bayar belim di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then
        '    rw = dSO.Tables("_krd").Rows(0)
        '    rw.Item("Last_Update_Date") = getTanggal()
        '    rw.Item("Last_Updated_By") = username
        'End If
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
            'Buildernya = New SqlClient.SqlCommandBuilder(DA)
            'DA.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA.InsertCommand = Buildernya.GetInsertCommand()
            'DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            'DA.UpdateCommand.Transaction = BTRANS
            'DA.InsertCommand.Transaction = BTRANS
            'DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            Dim sqlcmd1 As New SqlCommand("update kredit set sisa_angs=" & sisa_ang & " where no_trans='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("sisa_angs"))
            sqlcmd1.ExecuteNonQuery()

            'DA.Update(dSO.Tables("_krd"))
            DA2.Update(dSO1.Tables("_trans"))

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            'cancel_click()
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
        tx_noTbg.Text = ""
        'If Not ds_tbh.Tables("_tbh") Is Nothing Then ds_tbh.Tables("_tbh").Clear()

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_agd").Clear()

        'LuE_Jab.EditValue = vbNullString
        'Lue_SetPjm.EditValue = vbNullString

    End Sub


    Public Sub Cari()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select k.no_trans,a.nasabah_id,a.Nama,a.Almt_asal,k.JML_POKOK,k.JML_BUNGA,k.LAMA_ANGS as tempo,k.sisa_angs from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.status_lunas='BELUM'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            tx_nama.Text = frmCari.row("Nama")
            tx_id.Text = frmCari.row("nasabah_id")
            'tx_alamant.Text = frmCari.row("Almt_asal")
            id_anggota = frmCari.row("nasabah_id")
            s1 = frmCari.row("sisa_angs")
            tx_noTbg.Text = frmCari.row("no_trans")
            'tx_saldo1.Text = frmCari.row("Jml_Angsuran")
            bunga = frmCari.row("JML_BUNGA")
            pkok = frmCari.row("JML_POKOK")
            'adm = frmCari.row("JML_DENDA")
            sisa_ang = frmCari.row("sisa_angs")

          
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

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
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

        'Dim tgl_uplod, blnx, bln_skrg As String

        Dim sqdr1 As SqlDataReader = New SqlCommand("select DAY(tgl_eksekusi) as tgl, MONTH(tgl_eksekusi) as blnx, month(GETDATE()) as bln_skrg, " & _
                                                    " DATEDIFF(DAY,tgl_eksekusi, DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))+1 as jm_hr_lalu, " & _
                                                         " datediff(day, DATEADD(month, DATEDIFF(month, 0, getdate()), 0) , getdate() )+1 as jm_hr_today, " & _
                                                    " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))) as jm_bl_lalu, " & _
                                                    " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) as jm_bl_skrg " & _
                                                    " from export_log ", sqlconn).ExecuteReader
        sqdr1.Read()
        tgl_uplod = sqdr1.Item("tgl")
        blnx = sqdr1.Item("blnx")
        bln_skrg = sqdr1.Item("bln_skrg")
        jm_hr_lalu = sqdr1.Item("jm_hr_lalu")
        jm_hr_today = sqdr1.Item("jm_hr_today")
        jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
        jm_bl_skrg = sqdr1.Item("jm_bl_skrg")

        sqdr1.Close()

        If blnx <> bln_skrg Then
            bg_jln = (bunga * jm_hr_lalu / jm_bl_lalu) + (bunga * jm_hr_today / jm_bl_skrg)
            'txr_bunga.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        End If

        'MsgBox(tglskrg.Day)
        'If tglskrg.Month = "24" Then
        '    'MsgBox("tgl 24")

        'End If
    End Sub
    Public Sub hitung_angs()
        cek_denda()
        net_tagih = pkok + bunga + bg_jln
        sisa_baru = sisa_ang - 1
        angs_ke = sisa_ang - sisa_baru

        lb_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_pokok.Text = pkok.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_tot.Text = net_tagih.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_denda.Text = denda.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_denda.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub TE_byr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_byr.KeyDown
        If e.KeyCode = Keys.Enter Then
            dibayar = TE_byr.EditValue
            Dim x As Integer = 0
            If tx_id.Text <> "" Then
                'hitung_angs()
                Dim row1 As DataRow = dSO1.Tables("_trans").NewRow
                row1.Item("no_kredit") = tx_noTbg.Text
                row1.Item("angsuran_ke") = angs_ke
                row1.Item("sisa_angs") = sisa_baru
                row1.Item("nasabah_id") = id_anggota
                row1.Item("tgl_bayar") = getTanggal()
                row1.Item("rp_pokok") = pkok
                row1.Item("rp_bunga") = bunga
                row1.Item("rp_denda") = bg_jln
                row1.Item("rp_total") = net_tagih
                row1.Item("Nama") = tx_nama.Text
                row1.Item("Last_Created_By") = username
                row1.Item("Last_Create_Date") = getTanggal()
                'row1.Item("tgl_tempo") = 

                dSO1.Tables("_trans").Rows.Add(row1)

                kembali = dibayar - net_tagih
                TE_kembali.EditValue = kembali.ToString("c", New Globalization.CultureInfo("id-ID", False))

                save_click()
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
End Class