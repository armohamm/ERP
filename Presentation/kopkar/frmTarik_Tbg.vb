Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmTarik_Tbg
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, dsNama As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row1, rw, row2 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, daNama As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private tgl_reg, tgl_end As Date
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, pen, asr As Double
    Private BTRAN As SqlTransaction
    Private awalan, ntran_cek As String


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
        Lue_tab.Focus()
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
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NO_TABUNGAN='" & kode & "'", sqlconn))
        'DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        Gc_nabung.DataSource = dSO1.Tables("_trans")
    End Sub

    Public Sub save_click()
        If TE_Tarik.EditValue = vbNullString Then
            MsgBox("Nilai Setoran belum di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            hitung()
            simpan()
        End If

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

            Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & LUE_nm.Text & "'", sqlconn, BTRANS)
            sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
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
        'bersihkan()
    End Sub



    Public Sub Cari()
        If Not ds_cari3.Tables("lookup_Pegawai") Is Nothing Then ds_cari3.Tables("lookup_Pegawai").Clear()
        If Lue_tab.EditValue = "001" Then 'jika simp tab wajib
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select t.no_tab,ISNULL(a.Nama,'') as [Nama],a.tgl_masuk,t.saldo_awal,t.saldo_akhir,t.iuran,t.iuran_ke,t.blthn,a.jns_kel as [Jenis_kelamin],isnull(a.Almt_asal,'')as Almt_asal ,a.telp_skrg,a.REKBCA1 as no_rek,* from anggota a INNER JOIN tab_wajib t on a.nasabah_id=t.nasabah_id where t.nasabah_id='" & LUE_nm.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        Else
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select tb.NO_TABUNGAN,ISNULL(a.Nama,'') as [Nama],tb.TGL_REGISTRASI,tb.TGL_AKHIR,tb.SALDO_AWAL,tb.SALDO_AKHIR,a.jns_kel as [Jenis_kelamin],isnull(a.Almt_asal,'')as Almt_asal ,a.telp_skrg,isnull(tb.no_rek,a.REKBCA1)as no_rek,* from tabung tb left join anggota a on tb.NASABAH_ID=a.nasabah_id where tb.JENIS_TABUNGAN='" & Lue_tab.EditValue & "' and tb.nasabah_id='" & LUE_nm.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        End If

        If LUE_nm.EditValue = Nothing Then
            Exit Sub
        End If

        DA2.Fill(ds_cari3, "lookup_Pegawai")
        Dim row = ds_cari3.Tables("lookup_Pegawai").Rows(0)
        If Not row Is Nothing Then
            
            tx_nama.Text = row("Nama")
            lb_nip.Text = row("nasabah_id")
            lb_nama.Text = row("Nama")
            id_anggota = row("nasabah_id")
            s1 = row("SALDO_AWAL")
            s2 = row("SALDO_AKHIR")
            tx_saldo1.Text = s2
            TE_Tarik.EditValue = s2
            If Lue_tab.EditValue = "001" Then
                de_reg.EditValue = row("tgl_masuk")
                'de_end.EditValue = row("TGL_AKHIR")
            ElseIf Lue_tab.EditValue = "006" Then
                de_reg.EditValue = row("TGL_REGISTRASI")
                tgl_reg = row("TGL_REGISTRASI")
                tgl_end = tgl_reg.AddYears(2)
                de_end.EditValue = tgl_end  'IIf(row.IsNull("TGL_AKHIR"), Today, row.Item("TGL_AKHIR").ToString)  'row("Almt_asal") row("TGL_AKHIR")
            Else
                de_reg.EditValue = row("TGL_REGISTRASI")
                de_end.EditValue = IIf(row.IsNull("TGL_AKHIR"), Today, row.Item("TGL_AKHIR").ToString)  'row("Almt_asal") row("TGL_AKHIR")
            End If
            
            lb_norek.Text = row("REKBCA1")
            lb_alamat.Text = row("Almt_asal")
            total = s2

            lb_terima.Text = total.ToString("c2", New Globalization.CultureInfo("id-ID", False))
            If Lue_tab.EditValue = "006" Then
                If tgl_end = Today Then
                    denda = s2 * 2.5
                    total = s2 - denda
                    lb_pen.Text = denda.ToString("c2", New Globalization.CultureInfo("id-ID", False))
                    lb_terima.Text = total.ToString("c2", New Globalization.CultureInfo("id-ID", False))
                End If
                tx_saldo1.Text = s2.ToString("c2", New Globalization.CultureInfo("id-ID", False))
            End If
        End If
    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Cari()
    '    tx_TARIK.Focus()
    'End Sub

    'Private Sub tx_TARIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    '    End If
    'End Sub

    Public Function notran() As String

        ''Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        Dim sql_no As SqlDataReader = New SqlCommand("select prefix_trn_tarikan from m_tabungan where kd_trans='DP1'", sqlconn).ExecuteReader
        If sql_no.Read Then
            awalan = sql_no.Item("prefix_trn_tarikan")
        Else
            MsgBox("Koneksi Terputus, mohon dicek")
        End If
        sql_no.Close()
        ntran_cek = awalan & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from tabtrans where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = awalan & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = awalan & blthn() & "0001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) from tabtrans where no_trans like '" & awalan & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function


    Private Sub frmTarik_Tbg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")
        de_tglCair.EditValue = Today

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        RLnama.DataSource = ds_cari.Tables("_lookup")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select KODE_TRANS,DESKRIPSI_TRANS from kodetranstabungan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup1")
        RL_kdTrans.DataSource = ds_cari1.Tables("_lookup1")
        RL_kdTrans.ValueMember = "KODE_TRANS"
        RL_kdTrans.DisplayMember = "DESKRIPSI_TRANS"

        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select KODE_JENIS_TABUNGAN,DESKRIPSI_JENIS_TABUNGAN FROM kodejenistabungan where KODE_JENIS_TABUNGAN <> '005' ", sqlconn)) 'where t.JENIS_TABUNGAN='001'
        DA_gdg1.Fill(ds_gdg1, "_jns")
        Lue_tab.Properties.DataSource = ds_gdg1.Tables("_jns")
        Lue_tab.Properties.ValueMember = "KODE_JENIS_TABUNGAN"
        Lue_tab.Properties.DisplayMember = "DESKRIPSI_JENIS_TABUNGAN"
    End Sub

    Private Sub LUE_nama_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LUE_nm.EditValueChanged
        If Lue_tab.EditValue <> vbNullString And LUE_nm.EditValue <> vbNullString Then
            Cari()
        End If
    End Sub


    Private Sub LUE_nm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nm.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
            TE_Tarik.Focus()
        End If
    End Sub

    Private Sub TE_Tarik_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_Tarik.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx1_ket.Focus()

        End If

    End Sub

    Public Sub hitung()
        Dim x As Integer = 0
        If LUE_nm.EditValue <> vbNullString Then
            stor = TE_Tarik.EditValue
            '## SETOR TUNAI
            row1 = dSO1.Tables("_trans").NewRow
            row1.Item("URUTAN") = 1
            row1.Item("stat_cair") = 0 'stat_cair
            row1.Item("tipe_trans") = "JRR-KUT-13"
            row1.Item("kabag_approve") = 0
            row1.Item("stat_cair") = "T"
            row1.Item("id_cabang") = getKodeCabang()
            row1.Item("TGL_TRANS") = getTanggal()
            row1.Item("no_trans") = notran()
            row1.Item("NO_TABUNGAN") = LUE_nm.Text
            row1.Item("NASABAH_ID") = id_anggota
            row1.Item("KODE_TRANS") = "02" 'tarik TUNAI
            row1.Item("SALDO_AWAL") = s1
            row1.Item("SALDO_TRANS") = stor
            row1.Item("SALDO_AKHIR") = s1 - stor
            row1.Item("KETERANGAN") = tx1_ket.Text
            dSO1.Tables("_trans").Rows.Add(row1)
            '## ADMIN

            'row2 = dSO1.Tables("_trans").NewRow()
            'row2.Item("URUTAN") = 2
            'row2.Item("TGL_TRANS") = getTanggal()
            'row2.Item("NO_TABUNGAN") = tx_noTbg.Text
            'row2.Item("NASABAH_ID") = id_anggota
            'row2.Item("KODE_TRANS") = "05" 'SETOR TUNAI
            'row2.Item("SALDO_AWAL") = s1 + stor 'SALDO AKHIR SETOR JD SALDO AWAL 05 ADMIN
            'row2.Item("SALDO_TRANS") = 5000
            'row2.Item("SALDO_AKHIR") = (s1 + stor) - 5000
            'dSO1.Tables("_trans").Rows.Add(row2)
            save_click()
        End If
    End Sub

    Private Sub tx1_ket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_ket.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung()
        End If
    End Sub

    Private Sub Lue_tab_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_tab.EditValueChanged
        If Not dsNama.Tables("_nm") Is Nothing Then dsNama.Tables("_nm").Clear()
        If Lue_tab.EditValue = "001" Then
            daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,a.Nama from anggota a INNER JOIN tab_wajib t on a.nasabah_id=t.nasabah_id ", sqlconn)) 'where t.JENIS_TABUNGAN='001'
            daNama.Fill(dsNama, "_nm")
            LUE_nm.Properties.DataSource = dsNama.Tables("_nm")
            LUE_nm.Properties.ValueMember = "nasabah_id"
            LUE_nm.Properties.DisplayMember = "nasabah_id"
        Else
            daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,a.Nama from anggota a INNER JOIN tabung t on a.nasabah_id=t.NASABAH_ID where t.JENIS_TABUNGAN='" & Lue_tab.EditValue & "'", sqlconn)) 'where t.JENIS_TABUNGAN='001'
            daNama.Fill(dsNama, "_nm")
            LUE_nm.Properties.DataSource = dsNama.Tables("_nm")
            LUE_nm.Properties.ValueMember = "nasabah_id"
            LUE_nm.Properties.DisplayMember = "nasabah_id"

        End If
        LUE_nm.Focus()
    End Sub

    Private Sub lb_pen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_pen.Click
        MsgBox("2,5% dari Saldo")
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        MsgBox("2,5% dari Saldo")
    End Sub
End Class