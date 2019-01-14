Imports System.Data.SqlClient
Imports System.Globalization

Public Class Ms_Setting
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
    Private row1, rw, row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
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
        If Not dSO.Tables("_trans") Is Nothing Then dSO.Tables("_trans").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NO_TABUNGAN='" & kode & "'", sqlconn))
        'DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from m_jns_upload", sqlconn))
        DA2.Fill(dSO1, "_trans")
        Gc_nabung.DataSource = dSO1.Tables("_trans")
    End Sub

    Private Sub Ms_Setting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()
    End Sub
    Public Sub save_click()
        'If TE_Setor.EditValue = vbNullString Then
        '    MsgBox("Nilai Setoran belim di isi/Kosong", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
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

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        If STATE = "EDIT" Then
            row = dSO.Tables("_trans").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
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

        'dSO.Tables("_krd").Rows.Add(row)

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
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

            'Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
            'sqlcmd1.ExecuteNonQuery()

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

End Class