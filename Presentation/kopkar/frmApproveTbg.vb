'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmApproveTbg
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from tabung where status_aktif='PENGAJUAN'", sqlconn))
        DA.Fill(dSO, "_krd")
        GcINV_Ret.DataSource = dSO.Tables("_krd")
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub frmApproveTbg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'btnEdit = False
        ' setStatus()
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        RLnama.DataSource = ds_cari.Tables("_lookup")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("SELECT kd_trans,Nama,keterangan FROM m_tabungan", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_bg")
        RL_bunga.DataSource = ds_gdg1.Tables("_bg")
        RL_bunga.ValueMember = "kd_trans"
        RL_bunga.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT KODE_JENIS_TABUNGAN,DESKRIPSI_JENIS_TABUNGAN FROM kodejenistabungan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup1")
        RL_jnsTabg.DataSource = ds_cari1.Tables("_lookup1")
        RL_jnsTabg.ValueMember = "KODE_JENIS_TABUNGAN"
        RL_jnsTabg.DisplayMember = "DESKRIPSI_JENIS_TABUNGAN"

        isinomer()
        loadBank()
    End Sub

    Private Sub loadBank()
        If Not ds_cari1.Tables("Bank") Is Nothing Then ds_cari1.Tables("Bank").Clear()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT kd_bank, nama_bank FROM SIF_Bank WHERE Rec_Stat = 'Y'", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "Bank")
        lckBank.DataSource = ds_cari1.Tables("Bank")
        lckBank.ValueMember = "kd_bank"
        lckBank.DisplayMember = "nama_bank"
        RepositoryItemGridLookUpEdit1View.Columns("kd_bank").Visible = False
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            'notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
            For Each rw1 As DataRow In dSO.Tables("_krd").Rows
                If rw1.RowState = DataRowState.Modified Then
                    If rw1.Item("STATUS_AKTIF") = "APPROVE" Then
                        rw1.Item("STATUS_AKTIF") = "AKTIF"
                        rw1.Item("kabag_approve") = 1
                        rw1.Item("approve_date") = getTanggal()
                        rw1.Item("approve_by") = username
                    End If
                    'End If
                    

                End If
                'rw1.Item("Program_name") = Me.Name
                'txbNoTrans.Text = notrans
            Next
            'Else
            '    For Each rw1 As DataRow In dSO.Tables("_krd").Rows

            '        If rw1.RowState = DataRowState.Modified Then
            '            rw1.Item("cetak_ke") = rw1("cetak_ke") + 1

            '        End If

            '    Next


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

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub lookBank_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        loadBank()
    End Sub
End Class