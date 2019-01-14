'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class iuran_wajib
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
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Private angs_ke, sisa_ang As Integer

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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from simpanan_anggota where nasabah_id='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from simpanan_anggota_bayar where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        Gc_angs.DataSource = dSO1.Tables("_trans")
    End Sub
    Public Sub bersihkan()
        tx_id.Text = ""
        tx_nama.Text = ""
        'tx_iuran.Text = ""
        tx_setor.Text = ""
        tx_kembali.Clear()

    End Sub
    Public Sub save_click()
        If tx_setor.Text = "" Then
            MsgBox("Nilai Bayar belim di isi/Kosong", MsgBoxStyle.Exclamation)

            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan() Else bersihkan()

    End Sub

    Public Sub simpan()
        'Dim BTRANS As SqlTransaction
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
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRAN = sqlconn.BeginTransaction("1")
            'DA.UpdateCommand.Transaction = BTRANS
            'DA.InsertCommand.Transaction = BTRANS
            'DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRAN
            'DA2.DeleteCommand.Transaction = BTRANS

            For Each row1 As DataRow In dSO1.Tables("_trans").Rows
                Dim sqlrd As SqlDataReader = New SqlCommand("select nasabah_id,tahun from simpanan_anggota where nasabah_id='" & row1.Item("nasabah_id") & "' and tahun='" & dtp_tahun.Value.Year & "'", sqlconn, BTRAN).ExecuteReader
                'Clipboard.SetText("select nasabah_id,tahun from simpanan_anggota where nasabah_id='" & row1.Item("nasabah_id") & "' and tahun='" & dtp_tahun.Value.Year & "'")
                sqlrd.Read()
                If sqlrd.HasRows Then 'Jika nasabah sudah ada di tabel 'simpanan_anggota'
                    MsgBox("ada row")
                    If Lue_SetPjm.EditValue = "01" Then '#pokok
                        Dim sqlcmd1 As New SqlCommand("update simpanan_anggota set pokok" & Lue_bln.EditValue & "=@nilai where nasabah_id='" & tx_id.Text & "' and tahun='" & dtp_tahun.Value.Year & "'", sqlconn, BTRAN)
                        sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("rp_simpanan"))
                        sqlcmd1.ExecuteNonQuery()
                    ElseIf Lue_SetPjm.EditValue = "02" Then '#Wajib
                        Dim sqlcmd1 As New SqlCommand("update simpanan_anggota set wajib" & Lue_bln.EditValue & "=@nilai where nasabah_id='" & tx_id.Text & "' and tahun='" & dtp_tahun.Value.Year & "'", sqlconn, BTRAN)
                        sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("rp_simpanan"))
                        sqlcmd1.ExecuteNonQuery()
                    End If

                Else 'jika nasabah baru, insert
                    If Lue_SetPjm.EditValue = "01" Then '#pokok
                        Dim sqlcmd2 As New SqlCommand("insert into simpanan_anggota (nasabah_id,tahun,pokok" & Lue_bln.EditValue & ") values('" & tx_id.Text & "&&','" & dtp_tahun.Value.Year & "',@nilai) ", sqlconn, BTRAN)
                        sqlcmd2.Parameters.AddWithValue("@nilai", row1.Item("rp_simpanan"))
                        sqlcmd2.ExecuteNonQuery()
                    ElseIf Lue_SetPjm.EditValue = "02" Then '#Wajib
                        Dim sqlcmd2 As New SqlCommand("insert into simpanan_anggota (nasabah_id,tahun,wajib" & Lue_bln.EditValue & ") values('" & tx_id.Text & "&&','" & dtp_tahun.Value.Year & "',nilai) ", sqlconn, BTRAN)
                        sqlcmd2.Parameters.AddWithValue("@nilai", row1.Item("rp_simpanan"))
                        sqlcmd2.ExecuteNonQuery()
                    End If


                End If



            Next
            

            'DA.Update(dSO.Tables("_krd"))
            DA2.Update(dSO1.Tables("_trans"))

            'STATE = "EDIT"
            BTRAN.Commit()
            showMessages("Berhasil disimpan")
            'cancel_click()
        Catch e As Exception
            BTRAN.Rollback()
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
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama,Almt_asal from anggota ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            tx_nama.Text = frmCari.row("Nama")
            tx_id.Text = frmCari.row("nasabah_id")
            'tx_alamant.Text = frmCari.row("Almt_asal")
            id_anggota = frmCari.row("nasabah_id")
            's1 = frmCari.row("sisa_angs")
            'tx_noTbg.Text = frmCari.row("no_trans")
            'tx_saldo1.Text = frmCari.row("Jml_Angsuran")
            'angs_ke = frmCari.row("sisa_angs") - 1
            'MsgBox(angs_ke)

        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(Now.Month)
        'Lue_bln.EditValue = 10
        Cari()
        Lue_SetPjm.Focus()
    End Sub

    Private Sub iuran_wajib_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT id,kode,nama_bulan from m_bulan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bln")
        Lue_bln.Properties.DataSource = ds_cari1.Tables("_bln")
        Lue_bln.Properties.DisplayMember = "nama_bulan"
        Lue_bln.Properties.ValueMember = "id"
        'Lue_bln.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lue_bln.EditValue = Now.Month

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT nama_transaksi,kodetrans,jum_trans FROM set_simp_angg", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "nama_transaksi"
        Lue_SetPjm.Properties.ValueMember = "kodetrans"


        DA_gdg1 = New SqlDataAdapter(New SqlCommand("SELECT nama_transaksi,kodetrans,jum_trans FROM set_simp_angg", sqlconn))
        DA_gdg1.Fill(ds_cari3, "rl_trans")
        RL_trans.DataSource = ds_cari3.Tables("rl_trans")
        RL_trans.DisplayMember = "nama_transaksi"
        RL_trans.ValueMember = "kodetrans"

       

    End Sub


    Private Sub tx_setor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx_setor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim x As Integer = 0
            If tx_id.Text <> "" Or tx_iuran.Text <> "" Or Lue_SetPjm.EditValue <> vbNullString Then
                stor = tx_setor.Text
                sisa_ang = angs_ke - 1
                Dim row1 As DataRow = dSO1.Tables("_trans").NewRow
                'row1.Item("no_kredit") = tx_id.Text
                row1.Item("status_data") = 2 'Lunas Offline
                row1.Item("nasabah_id") = id_anggota
                row1.Item("tgl_bayar") = getTanggal()
                row1.Item("kd_trans") = Lue_SetPjm.EditValue
                row1.Item("rp_simpanan") = tx_iuran.Text
                row1.Item("Nama") = tx_nama.Text
                row1.Item("Create_By") = username
                row1.Item("Create_Date") = getTanggal()
                row1.Item("blthn") = dtp_tahun.Value.Year & "" & Lue_bln.EditValue
                'MsgBox(dtp_tahun.Value.Year & "" & Lue_bln.EditValue)
                dSO1.Tables("_trans").Rows.Add(row1)

                tx_kembali.Text = tx_setor.Text - tx_iuran.Text
                save_click()
            End If
        End If

    End Sub


    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
        'Dim rw As DataRow = ds_cari.Tables("LookTran").Rows(0)
        'tx_iuran.Text = Lue_SetPjm.ItemIndex = 2
        'Lue_SetPjm.i()
        If Lue_SetPjm.EditValue = "01" Then
            tx_iuran.Text = ds_cari.Tables("LookTran").Rows(0).Item("jum_trans").ToString

        ElseIf Lue_SetPjm.EditValue = "02" Then
            tx_iuran.Text = ds_cari.Tables("LookTran").Rows(1).Item("jum_trans").ToString

        End If
    End Sub
End Class