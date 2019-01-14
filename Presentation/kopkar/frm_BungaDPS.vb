'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frm_BungaDPS
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
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Dim tipe_transaksi_peengajuan, pilih, kd_krd As String

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
    Public Sub cancel_click()
        'LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next
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

    Public Sub LoadStruktur()

        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT *,0 as sudah_transf_bg,'' as rec_stat,'' AS TGL_REGISTRASI,'' AS TGL_AKHIR from tabtrans where 1=0", sqlconn))
        DA.Fill(dSO, "_krd")
        GcINV_Ret.DataSource = dSO.Tables("_krd")
        load_data()
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub load_data()
        Dim i As Int16 = 1

        Dim sqdr As SqlDataReader = New SqlCommand("SELECT *,0 as nomer FROM KOPKAR.dbo.tabung " & _
                                                                   "WHERE RIGHT(CONVERT(VARCHAR(8), tgl_registrasi,112),4) BETWEEN RIGHT(CONVERT(VARCHAR(8), last_transf_bg,112),4) " & _
                                                                   "AND RIGHT(CONVERT(VARCHAR(8), GETDATE()+1,112),4) " & _
                                                                   "and jenis_tabungan='005' and rec_stat=1 and transfer_bg_bulanan=1  ", sqlconn).ExecuteReader
        While sqdr.Read
            Dim row1 As DataRow = dSO.Tables("_krd").NewRow
            row1.Item("kd_cabang") = kdcabang
            row1.Item("no_seq") = i : i += 1
            row1.Item("TGL_TRANS") = getTanggal()
            row1.Item("NO_TABUNGAN") = sqdr.Item("NO_TABUNGAN")
            row1.Item("TGL_REGISTRASI") = sqdr.Item("TGL_REGISTRASI") 'TGL_REGISTRASI\
            row1.Item("TGL_AKHIR") = sqdr.Item("TGL_AKHIR") 'TGL_AKHIR
            row1.Item("NASABAH_ID") = sqdr.Item("NASABAH_ID")
            row1.Item("rec_stat") = sqdr.Item("STATUS_AKTIF")
            row1.Item("KODE_TRANS") = "08" 'SEE KODETRANSTABUNG 08=BUNGA
            row1.Item("SALDO_AWAL") = sqdr.Item("SALDO_AKHIR")
            row1.Item("bunga") = sqdr.Item("bunga")
            row1.Item("SALDO_TRANS") = ((row1.Item("bunga") / 100) / 12) * row1.Item("SALDO_AWAL") 'RP BUNGA
            row1.Item("rp_pajak") = row1.Item("SALDO_TRANS") * (10 / 100)
            row1.Item("total_terima") = row1.Item("SALDO_TRANS") - row1.Item("rp_pajak")
            row1.Item("SALDO_AKHIR") = sqdr.Item("SALDO_AKHIR") + row1.Item("total_terima")
            row1.Item("sudah_transf_bg") = sqdr.Item("sudah_transf_bg") 'sudah_transf_bg

            dSO.Tables("_krd").Rows.Add(row1)
        End While

    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            'notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
            For Each rw1 As DataRow In dSO.Tables("_krd").Rows
                If RL_CE.ValueChecked = True Then
                    MsgBox("ok1")
                    'If RL_CE.ValueChecked = True Then
                    '    MsgBox("ok1")
                    'End If
                    'If IIf(rw1.Item("stat_cair_approve") Is DBNull.Value, False, rw1.Item("stat_cair_approve")) = True Then
                    'MsgBox("True bos")
                    'rw1.Item("stat_cair") = 1
                    'rw1.Item("tgl_cair") = getTanggal()
                    rw1.Item("Last_Updated_By") = username
                    rw1.Item("Last_Update_Date") = getTanggal()
                    'End If

                End If

            Next
        Else
            'For Each rw1 As DataRow In dSO.Tables("_krd").Rows

            '    If rw1.RowState = DataRowState.Modified Then
            '        rw1.Item("cetak_ke") = rw1("cetak_ke") + 1

            '    End If

            'Next


        End If

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

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadStruktur()
    End Sub

    Private Sub frm_BungaDPS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()

        'GV_RLSKRD.FocusedColumn = GV_RLSKRD.Columns("stat_kabagSPx  ")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT KODE_JENIS_TABUNGAN,DESKRIPSI_JENIS_TABUNGAN FROM kodejenistabungan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup1")
        RL_jnsTabg.DataSource = ds_cari1.Tables("_lookup1")
        RL_jnsTabg.ValueMember = "KODE_JENIS_TABUNGAN"
        RL_jnsTabg.DisplayMember = "DESKRIPSI_JENIS_TABUNGAN"

        'isinomer()
    End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        For Each klik As DataRow In dSO.Tables("_krd").Rows
            klik.Item("sudah_transf_bg") = 1
        Next
    End Sub

    Private Sub btn_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deselect.Click
        btn_deselect.Enabled = False
        Btn_pilih.Enabled = True
        For Each klik As DataRow In dSO.Tables("_krd").Rows
            klik.Item("sudah_transf_bg") = 0
        Next
    End Sub
End Class