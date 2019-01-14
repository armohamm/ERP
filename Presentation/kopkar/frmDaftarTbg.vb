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

Public Class frmDaftarTbg
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dsNama, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, daNama, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, pajak, t_pajak, bunga_net, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr, bg1, bg2, bg3, bts1, bts2, bts3, t_bg As Double
    Private BTRAN As SqlTransaction
    Private ntran_cek, ket, awalan As String

    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select t.NO_TABUNGAN,a.Nama,* from tabung t inner join anggota a on t.NASABAH_ID=a.nasabah_id where t.JENIS_TABUNGAN='005' order by t.NO_TABUNGAN desc", sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        'btCari.Enabled = False
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'idJab = frmCari.row.Item("job_id").ToString
            LoadStruktur(frmCari.row(0))
        Else
            'cancel_click()
            add_click()
            btnSave = False
            'LookupPO.Enabled = False
            STATE = ""
        End If

    End Sub


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        bersihkan()

        'LUE_jnsTab.EditValue = "005"
        '   LU_bunga_dps.EditValue = "DP1"
        cb_periode.Text = 1
        cb_periode.Enabled = False
        cb_bulanan.Checked = True
        txb_bank.Text = "BCA"

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'Cari()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub
    Public Sub bersihkan()
        dSO.Clear() 'LU_bunga_dps.EditValue = vbNullString



        'LUE_jnsTab.EditValue = "DP1"
        cb_periode.Text = "1"
        LUE_nama.EditValue = vbNullString
        dtp_sd.Text = ""
        dtp_tgl.Text = ""
        TE_Setoran.EditValue = vbNullString
        cb_bg.Checked = True
        cb_no_tbg.Checked = True
        txb_no_tbg.Enabled = False
        cb_bulanan.Text = ""

        t_rek.Text = ""
        lb_alamat.Text = ""
        lb_nip.Text = ""
        lb_kota.Text = ""
        lb1_bunga.Text = ""
        lb1_pajak.Text = ""
        lb1_t_bunga.Text = ""
        txb_no_tbg.Text = ""
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
        tx_bg_khus.Enabled = False
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NO_TABUNGAN='" & kode & "' ", sqlconn))
        DA.Fill(dSO, "_krd")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            Dim rwm As DataRow = dSO.Tables("_krd").Rows(0)
            txb_no_tbg.Text = rwm.Item("NO_TABUNGAN").ToString
            LUE_nama.EditValue = rwm.Item("NASABAH_ID").ToString
            lb_nip.Text = rwm.Item("NASABAH_ID").ToString
            'lb_alamat.Text = rwm.Item("").ToString
            'lb_kota.Text = rwm.Item("").ToString
            'lb_telp.Text = rwm.Item("").ToString
            LUE_jnsTab.EditValue = IIf(rwm.IsNull("JENIS_TABUNGAN"), 0, rwm.Item("JENIS_TABUNGAN"))
            'LU_bunga_dps.EditValue = rwm.Item("").ToString
            TE_Setoran.Text = IIf(rwm.IsNull("SALDO_AWAL"), 0, rwm.Item("SALDO_AWAL"))
            dtp_tgl.Text = rwm.Item("TGL_REGISTRASI").ToString
            dtp_sd.Text = IIf(rwm.IsNull("TGL_AKHIR"), Today, rwm.Item("TGL_AKHIR").ToString)
            lb1_bunga.Text = rwm.Item("bunga").ToString
            If (rwm.Item("transfer_bg_bulanan") = True) Then
                cb_bulanan.CheckState = CheckState.Checked
            Else
                cb_bulanan.CheckState = CheckState.Unchecked
            End If
            lb1_pajak.Text = rwm.Item("pajak").ToString
            lb1_t_bunga.Text = rwm.Item("bunga").ToString
            t_rek.Text = rwm.Item("no_rek").ToString
            cb_periode.Text = IIf(rwm.IsNull("jangka_bln"), 0, rwm.Item("jangka_bln"))
        End If


    End Sub

    Public Sub save_click()
        If LUE_jnsTab.EditValue = vbNullString Then
            MsgBox("Jenis Tabungan Belum dipilih/di set", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            row = dSO.Tables("_krd").NewRow

            'row.Item("no_trans") = id_anggota + jns + blthn()
            'MsgBox(id_anggota + jns + blthn())
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            If cb_no_tbg.Checked = True Then
                If txb_no_tbg.Text <> "" Then
                    row.Item("NO_TABUNGAN") = txb_no_tbg.Text
                Else
                    MsgBox("Karena Centang aktif maka no bilyet manual, dan Harus di isi ga boleh kosong")
                    Exit Sub
                End If

            Else
                row.Item("NO_TABUNGAN") = notran()
            End If


            'row.Item("blthn") = blthn()
            'row.Item("tgl_trans") = getTanggal()

        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_krd").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If

        row.Item("NASABAH_ID") = lb_nip.Text
        row.Item("JENIS_TABUNGAN") = LUE_jnsTab.EditValue

        row.Item("TGL_REGISTRASI") = dtp_tgl.Text
        row.Item("TGL_AKHIR") = dtp_sd.Text
        row.Item("SALDO_AWAL") = TE_Setoran.EditValue
        row.Item("SALDO_AKHIR") = TE_Setoran.EditValue
        row.Item("bunga") = t_bg * 100
        row.Item("STATUS_AKTIF") = "PENGAJUAN"
        row.Item("pajak") = pajak
        row.Item("rp_pajak_bulanan") = t_pajak
        row.Item("transfer_bg_bulanan") = IIf(cb_bulanan.Checked, 1, 0)
        row.Item("KETERANGAN") = tx1_ket.Text
        row.Item("no_rek") = t_rek.Text
        row.Item("nama_bank") = txb_bank.Text
        row.Item("rec_stat") = 1
        If cb_bulanan.Checked = True Then
            row.Item("jangka_bln") = cb_periode.Text
        End If
        row.Item("jml_bg_bulanan") = bunga_net
        'row.Item("KETERANGAN") = tx1_ket.Text

        dSO.Tables("_krd").Rows.Add(row)

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
    Public Function notran() As String

        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        Dim sql_no As SqlDataReader = New SqlCommand("select awalan_nomor from m_tabungan where kd_trans='" & LU_bunga_dps.EditValue & "'", sqlconn).ExecuteReader
        If sql_no.Read Then
            awalan = sql_no.Item("awalan_nomor")
        Else
            MsgBox("Koneksi Terputus, mohon dicek")
        End If
        sql_no.Close()
        'ntran_cek = id_anggota & LUE_jnsTab.EditValue & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from tabung where NO_TABUNGAN like '" & awalan & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = awalan & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = awalan & "00001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(NO_TABUNGAN,3,5) as numeric)) from tabung where NO_TABUNGAN like '" & awalan & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            hasil = temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function

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
        'bersihkan()
    End Sub



    Public Sub Cari()
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,Nama as [Nama],a.jns_kel as [Jenis_kelamin],a.job_id,isnull(a.Almt_asal,'')as Almt_asal,CONVERT(int,ROUND(DATEDIFF(hour, isnull(convert(date,Tgl_lahir,1),''),GETDATE())/8766.0,0)) AS Umur, ISNULL(k.nama_kota,'') as nama_kota,* from anggota a left join kota k on a.kode_kota=k.kode_kota inner join m_jabatan j on a.job_id=j.job_id where a.nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not row Is Nothing Then
            LUE_nama.EditValue = row("nasabah_id")
            lb_nip.Text = row("nasabah_id")
            lb_alamat.Text = row("Almt_asal")
            lb_kota.Text = row("nama_kota")
            id_anggota = row("nasabah_id")
            lb_telp.Text = IIf(row.IsNull("telp_skrg"), "", row("telp_skrg").ToString) 'row("REKBCA2") row("telp_skrg")
            t_rek.Text = IIf(row.IsNull("REKBCA1"), 0, row("REKBCA1").ToString) 'row("REKBCA2") row("REKBCA1")

        End If
        TE_Setoran.Focus()
    End Sub

    Public Sub hitung_dpst()
        bsr_pjm = TE_Setoran.EditValue
        If bts1 > TE_Setoran.EditValue Or TE_Setoran.EditValue < bts2 Then
            t_bg = bg1 / 100
            bunga = (bsr_pjm * t_bg) / 12
            t_pajak = bunga * (pajak / 100)
            bunga_net = bunga - t_pajak

            lb1_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_pajak.Text = t_pajak.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_t_bunga.Text = bunga_net.ToString("c", New Globalization.CultureInfo("id-ID", False))

            'MsgBox(bunga)
        ElseIf TE_Setoran.EditValue >= bts2 And TE_Setoran.EditValue < bts3 Then
            t_bg = bg2 / 100
            bunga = (bsr_pjm * t_bg) / 12
            t_pajak = bunga * (pajak / 100)
            bunga_net = bunga - t_pajak
            lb1_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_pajak.Text = t_pajak.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_t_bunga.Text = bunga_net.ToString("c", New Globalization.CultureInfo("id-ID", False))
        ElseIf TE_Setoran.EditValue >= bts3 Then
            t_bg = bg3 / 100
            bunga = (bsr_pjm * t_bg) / 12
            t_pajak = bunga * (pajak / 100)
            bunga_net = bunga - t_pajak
            lb1_t_bunga.Text = bunga_net.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_pajak.Text = t_pajak.ToString("c", New Globalization.CultureInfo("id-ID", False))
            lb1_bunga.Text = bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            'MsgBox(bunga)
        End If
    End Sub

    Private Sub frmDaftarTbg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur("xxx")
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT KODE_JENIS_TABUNGAN,DESKRIPSI_JENIS_TABUNGAN FROM kodejenistabungan where KODE_JENIS_TABUNGAN='005'", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        LUE_jnsTab.Properties.DataSource = ds_cari.Tables("LookTran")
        LUE_jnsTab.Properties.DisplayMember = "DESKRIPSI_JENIS_TABUNGAN"
        LUE_jnsTab.Properties.ValueMember = "KODE_JENIS_TABUNGAN"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT kd_trans,Nama,keterangan,* FROM m_tabungan where kd_trans='DP1'", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bg")
        LU_bunga_dps.Properties.DataSource = ds_cari1.Tables("_bg")
        LU_bunga_dps.Properties.DisplayMember = "Nama"
        LU_bunga_dps.Properties.ValueMember = "kd_trans"

        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"


    End Sub

    Private Sub BTNcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cari()
    End Sub

    Private Sub LU_bunga_dps_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LU_bunga_dps.EditValueChanged
        Dim i As Integer
        Dim dr() As DataRow = ds_cari1.Tables("_bg").Select("kd_trans='" & LU_bunga_dps.EditValue & "'")
        ket = dr(i).Item("keterangan")
        lb_ket.Text = ket
        bts1 = dr(i).Item("batas1_min")
        bg1 = dr(i).Item("bunga1")
        bts2 = dr(i).Item("batas2_min")
        bg2 = dr(i).Item("bunga2")
        bts3 = dr(i).Item("batas3_min")
        bg3 = dr(i).Item("bunga3")
        pajak = dr(i).Item("pajak")
    End Sub

    
    Private Sub cb_bg_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_bg.CheckedChanged
        If cb_bg.Checked = True Then
            tx_bg_khus.Enabled = True
            LU_bunga_dps.Enabled = False
            lb_ket.Text = "Bunga Khusus Custom"
        Else
            tx_bg_khus.Enabled = False
            LU_bunga_dps.Enabled = True
            lb_ket.Text = ket
        End If
    End Sub

    Private Sub TE_Setoran_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_Setoran.EditValueChanged
        dtp_sd.Value = dtp_tgl.Value.AddYears(1)
    End Sub

    Private Sub TE_Setoran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_Setoran.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_dpst()
            'save_click()
        End If
    End Sub

    Private Sub cb_bulanan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_bulanan.CheckedChanged
        If cb_bulanan.Checked = True Then
            cb_periode.Enabled = True
        Else
            cb_periode.Enabled = False
        End If
    End Sub

    Private Sub dtp_tgl_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_tgl.ValueChanged
        dtp_sd.Value = dtp_tgl.Value.AddYears(1)
    End Sub

    Private Sub cb_no_tbg_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_no_tbg.CheckedChanged
        If cb_no_tbg.Checked = True Then
            txb_no_tbg.Enabled = True
        Else
            txb_no_tbg.Enabled = False
        End If
    End Sub

    'Private Sub LUE_nama_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LUE_nama.EditValueChanged
    '    Cari()
    '    'cek_hist()
    '    LUE_jnsTab.Focus()
    'End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
            'cek_hist()
            LUE_jnsTab.Focus()
        End If
    End Sub

   
End Class