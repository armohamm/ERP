'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_config
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
    Private row As DataRow
    Private DA, DA2, daketua1, daketua2, daketua3, daketua4, da_bdhr, da_kabag1, da_kabag2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        LoadStruktur()
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
    Public Sub cancel_click()

        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Public Sub save_click()
        'If TE_Setor.EditValue = vbNullString Then
        '    MsgBox("Nilai Setoran belim di isi/Kosong", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        'If STATE = "EDIT" Then
        row = dSO.Tables("_krd").Rows(0)
        row.Item("Last_Update") = getTanggal()
        row.Item("Last_Updated_By") = username
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
            'DA2.Update(dSO1.Tables("_trans"))
            '            Dim sqlcmd1 As New SqlCommand("update tabung set bunga=(select  case " & _
            '"when SALDO_AWAL between @batas1_min and @batas1_max then @bg1 " & _
            '"when SALDO_AWAL between @batas2_min and @batas2_max then @bg2 " & _
            '"when SALDO_AWAL between @batas3_min and @batas3_max then @bg3 " & _
            '"when SALDO_AWAL between @batas4_min and @batas4_max then @bg4  end),Last_Update_By='" & username & "', Last_Update=@tgl " & _
            '"WHERE JENIS_TABUNGAN='005' and status_anggota='BIASA'", sqlconn, BTRANS)
            '            sqlcmd1.Parameters.AddWithValue("@batas1_min", row.Item("batas1_min"))
            '            sqlcmd1.Parameters.AddWithValue("@batas1_max", row.Item("batas1_max"))
            '            sqlcmd1.Parameters.AddWithValue("@batas2_min", row.Item("batas2_min"))
            '            sqlcmd1.Parameters.AddWithValue("@batas2_max", row.Item("batas2_max"))
            '            sqlcmd1.Parameters.AddWithValue("@batas3_min", row.Item("batas3_min"))
            '            sqlcmd1.Parameters.AddWithValue("@batas3_max", row.Item("batas3_max"))
            '            sqlcmd1.Parameters.AddWithValue("@batas4_min", row.Item("batas4_min"))
            '            sqlcmd1.Parameters.AddWithValue("@batas4_max", row.Item("batas4_max"))
            '            sqlcmd1.Parameters.AddWithValue("@bg1", row.Item("bunga1"))
            '            sqlcmd1.Parameters.AddWithValue("@bg2", row.Item("bunga2"))
            '            sqlcmd1.Parameters.AddWithValue("@bg3", row.Item("bunga3"))
            '            sqlcmd1.Parameters.AddWithValue("@bg4", row.Item("bunga4"))
            '            sqlcmd1.Parameters.AddWithValue("@tgl", getTanggal(BTRANS))
            '            sqlcmd1.ExecuteNonQuery()

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            cancel_click()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub
    Public Sub LoadStruktur()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from m_konfig", sqlconn))
        DA.Fill(dSO, "_krd")
        GcINV_Ret.DataSource = dSO.Tables("_krd")
    End Sub

    Private Sub frm_config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()
        load_nama()

    End Sub

    Public Sub load_nama()

        daketua1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        daketua1.Fill(ds_cari, "_kt1")
        RL_ketua1.DataSource = ds_cari.Tables("_kt1")
        RL_ketua1.ValueMember = "nasabah_id"
        RL_ketua1.DisplayMember = "Nama"

        daketua2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        daketua2.Fill(ds_cari, "_kt2")
        RL_ketua2.DataSource = ds_cari.Tables("_kt2")
        RL_ketua2.ValueMember = "nasabah_id"
        RL_ketua2.DisplayMember = "Nama"

        daketua3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        daketua3.Fill(ds_cari, "_kt3")
        RL_ketua3.DataSource = ds_cari.Tables("_kt3")
        RL_ketua3.ValueMember = "nasabah_id"
        RL_ketua3.DisplayMember = "Nama"

        daketua4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        daketua4.Fill(ds_cari, "_kt4")
        RL_ketua4.DataSource = ds_cari.Tables("_kt4")
        RL_ketua4.ValueMember = "nasabah_id"
        RL_ketua4.DisplayMember = "Nama"

        da_bdhr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        da_bdhr.Fill(ds_cari, "_bdhr")
        RL_bdhr.DataSource = ds_cari.Tables("_bdhr")
        RL_bdhr.ValueMember = "nasabah_id"
        RL_bdhr.DisplayMember = "Nama"

        da_kabag1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        da_kabag1.Fill(ds_cari, "_kabag1")
        RL_sp.DataSource = ds_cari.Tables("_kabag1")
        RL_sp.ValueMember = "nasabah_id"
        RL_sp.DisplayMember = "Nama"

        da_kabag2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        da_kabag2.Fill(ds_cari, "_kabag2")
        RL_keu.DataSource = ds_cari.Tables("_kabag2")
        RL_keu.ValueMember = "nasabah_id"
        RL_keu.DisplayMember = "Nama"

    End Sub
End Class