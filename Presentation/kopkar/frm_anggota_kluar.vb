'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization


Public Class frm_anggota_kluar

    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, dsJab, dsNama As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row1, rw, row2 As DataRow
    Private DA, DA1, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, daNama, daJab As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Private awalan, ntran_cek, idJab As String
    Private row As DataRow
    Private tgk As Boolean
    'Dim Pic As Object
    Dim pathFoto As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        tgk = False
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
        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO.Tables("_trans") Is Nothing Then dSO.Tables("_trans").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NO_TABUNGAN='" & kode & "'", sqlconn))
        'DA.Fill(dSO, "_krd")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from anggota where nasabah_id='" & kode & "' ", sqlconn))
        DA.Fill(dSO, "_trans")
        'gc_agenda.DataSource = dSO1.Tables("_trans")
    End Sub

    Public Sub save_click()
        'If tgk = True Or TE_BsrPJM.EditValue > 0 Then
        If tgk = True Then
            MsgBox("Anggota tsb Masih Punya Kewajiban/Saldo simpanan Wajib, Anggota tidak bisa di proses keluar!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If STATE = "ADD" Then
            If LUE_nama.EditValue = vbNullString Then
                MsgBox("Data belum di isi/Kosong", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub cetak_click()
        'If tgk = True Or TE_BsrPJM.EditValue > 0 Then
        If tgk = True Then
            MsgBox("Anggota tsb Masih Punya Kewajiban/Saldo simpanan Wajib, Anggota tidak bisa di proses keluar!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If STATE = "ADD" Then
            If LUE_nama.EditValue = vbNullString Then
                MsgBox("Data belum di isi/Kosong", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If MsgBox("Permohonan Keluar akan di proses dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
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

        If STATE = "ADD" Then
            row = dSO.Tables("_trans").Rows(0)
            'row.Item("Rec_Stat") = IIf(cbstatus.Text = "AKTIF", True, False)

            row.Item("Rec_Stat") = 0
            row.Item("Keterangan") = tx1_ket.Text
            row.Item("tgl_keluar") = getTanggal()
            row.Item("Last_Update") = getTanggal()
            row.Item("update_by") = username
            'ElseIf STATE = "CETAK" Then
            '    row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If

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
        'If STATE = "ADD" Then
        '    dSO1.Tables("_trans").Rows.Add(row)
        'End If


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

            If STATE = "ADD" Then
                Dim sqlcmd1 As New SqlCommand("update tab_wajib set Rec_stat=0  where nasabah_id='" & LUE_nama.EditValue & "'", sqlconn, BTRANS)
                sqlcmd1.Parameters.AddWithValue("@nilai", getTanggal(BTRANS))
                'Clipboard.SetText("update anggota set Rec_stat=0,Keterangan='" & tx1_ket.Text & "',tgl_keluar=@nilai where nasabah_id='" & LUE_nama.EditValue & "'")
                sqlcmd1.ExecuteNonQuery()

            End If

            'DA.Update(dSO.Tables("_krd"))
            DA.Update(dSO.Tables("_trans"))

            ''STATE = "EDIT"
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

    Public Sub simp_tbw()
        If Not ds_cari3.Tables("_tbw") Is Nothing Then ds_cari3.Tables("_tbw").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tab_wajib where nasabah_id='" & LUE_nama.EditValue & "' ", sqlconn)) '<- query buat domitampilkan di LOV, pakailah alias colom biar enak dibaca
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If
        DALOOKUP.Fill(ds_cari3, "_tbw")
        Dim row = ds_cari3.Tables("_tbw").Rows(0)
        If Not row Is Nothing Then
            TE_BsrPJM.EditValue = row("saldo_akhir")
        End If
    End Sub


    Public Sub Cari()
        Dim arr() As Byte
        Dim Pic As Object

        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(Foto,'') as Foto,* from anggota where nasabah_id='" & LUE_nama.EditValue & "' ", sqlconn)) '<- query buat domitampilkan di LOV, pakailah alias colom biar enak dibaca
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If

        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        If Not row Is Nothing Then
            lb_nama.Text = row("Nama")
            id_anggota = row("nasabah_id")
            tx_id.Text = row("nasabah_id")
            lb_nama.Text = row("Nama")
            id_anggota = row("nasabah_id")
            lb_alamat.Text = row("Almt_asal")
            lb_reg.Text = row("tgl_masuk")
            lb_dinas.Text = IIf(row.IsNull("job_nama"), "", row.Item("job_nama").ToString) 'row("job_nama")
            lb_hp.Text = row("telp_asal")
            lb_stat.Text = IIf(row.IsNull("status_anggota"), "BIASA", row.Item("status_anggota").ToString) 'row("status_anggota") 
            'cbstatus.EditValue = IIf(row("Rec_Stat") = True, "AKTIF", "TIDAK AKTIF")
            LuE_Jab.EditValue = row("job_id")
            arr = row.Item("Foto") 'IIf(row.IsNull(row.Item("Foto"), 0, row.Item("Foto")))
            If arr.Length = 0 Then
                PictureBox2.Image = Presentation.My.Resources.profile_photo
            Else
                ' arr = row.Item("Foto")
                PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
                'PictureBox2.Image = Image.FromStream(ms)
            End If

            LoadStruktur(id_anggota)
            cek_agenda()
            cek_hist()
            cek_ritel()

        End If
    End Sub

    Public Sub cek_ritel()
        If Not dso2.Tables("_rtl") Is Nothing Then dso2.Tables("_rtl").Clear()
        'If Not dso2.Tables("_agd") Is Nothing Then
        '    dso2.Tables("_agd").Clear()
        'End If
        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(JML_POKOK_TERAKHIR,0) as JML_POKOK_TERAKHIR,* from retail where nasabah_id= '" & id_anggota & "' and status_lunas<>'LUNAS'", sqlconn))
        DALOOKUP1.Fill(dso2, "_rtl")
        gc_tab_wjb.DataSource = dso2.Tables("_rtl")
        gv_denda.BestFitColumns()


    End Sub

    Public Sub cek_agenda()
        If Not ds_cari.Tables("_agd") Is Nothing Then ds_cari.Tables("_agd").Clear()
        'If Not dso2.Tables("_agd") Is Nothing Then
        '    dso2.Tables("_agd").Clear()
        'End If
        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NASABAH_ID= '" & id_anggota & "' and STATUS_AKTIF='AKTIF' and JENIS_TABUNGAN='003'", sqlconn))
        DA1.Fill(ds_cari, "_agd")
        gc_dps.DataSource = ds_cari.Tables("_agd")
        gv_dps.BestFitColumns()


    End Sub
    Public Sub cek_hist()
        If Not dSO1.Tables("_hist") Is Nothing Then dSO1.Tables("_hist").Clear()
        'If Not dSO1.Tables("_hist") Is Nothing Then
        '    dSO1.Tables("_hist").Clear()
        'End If
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(JML_POKOK_TERAKHIR,0) as JML_POKOK_TERAKHIR,* from kredit where nasabah_id= '" & id_anggota & "' and status_lunas<>'LUNAS' and stat_approve > 4", sqlconn))
        DA2.Fill(dSO1, "_hist")
        GcHist.DataSource = dSO1.Tables("_hist")
        'Gv_hist.BestFitColumns()


    End Sub
    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id as NIP,Nama,* from anggota  where Rec_Stat=0 order by tgl_keluar desc  ", sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        'btCari.Enabled = False
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih

            idJab = frmCari.row.Item("job_id").ToString


            Dim arr() As Byte
            Dim Pic As Object
            Dim rwL As DataRow = dSO1.Tables("lookup_").Rows(0)
            idJab = frmCari.row.Item("job_id").ToString
            'Pic = frmCari.row.Item("Foto")
            'arr = frmCari.row.Item("Foto")
            lb_nama.Text = frmCari.row.Item("Nama")
            id_anggota = frmCari.row("nasabah_id")
            lb_alamat.Text = frmCari.row("Almt_asal")
            'TE_BsrPJM1.EditValue = frmCari.row("totalx") 'totalx
            lb_reg.Text = frmCari.row("tgl_masuk")
            lb_dinas.Text = frmCari.row("job_nama")
            lb_hp.Text = frmCari.row("telp_asal")
            'cbstatus.EditValue = IIf(frmCari.row("Rec_Stat") = True, "AKTIF", "TIDAK AKTIF")
            'txb_bank.Text = "BCA"
            lb_stat.Text = frmCari.row("status_anggota")
            LuE_Jab.EditValue = frmCari.row("job_id")
            'If arr.Length = 0 Then
            '    PictureBox2.Image = Presentation.My.Resources.profile_photo
            'Else
            '    ' arr = row.Item("Foto")
            '    PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
            '    'PictureBox2.Image = Image.FromStream(ms)
            'End If

            LoadStruktur(frmCari.row("nasabah_id"))
            btnSave = True
            btnDelete = True
        Else
            'cancel_click()
            add_click()
            btnSave = False
            'LookupPO.Enabled = False
            STATE = ""
        End If
        setStatus()
    End Sub


    Private Sub frm_anggota_kluar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama,nasabah_id from anggota where Rec_Stat=1", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"

        daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select job_id,job_nama from m_jabatan", sqlconn))
        daJab.Fill(dsjab, "View_Jabatan")
        LuE_Jab.Properties.DataSource = dsjab.Tables("View_Jabatan")
        LuE_Jab.Properties.ValueMember = "job_id"
        LuE_Jab.Properties.DisplayMember = "job_nama"


        LoadStruktur("xxx")
        LUE_nama.Focus()
    End Sub


    Private Sub tx1_ket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_ket.KeyDown
        If e.KeyCode = Keys.Enter Then
            save_click()
        End If
    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
            simp_tbw()
            tx1_ket.Focus()
        End If
    End Sub

End Class