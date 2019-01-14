'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Public Class frmVerify_DPS2
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
    Private eror As String


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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select case when kabag_approve=0 THEN 'BELUM' WHEN kabag_approve=1 THEN 'SUDAH APPROVE' END AS kabag_approve,0 as nomer,* from KOPKAR.dbo.tabung where STATUS_AKTIF='PENGAJUAN' and JENIS_TABUNGAN='005' ", sqlconn))
        DA.Fill(dSO, "_krd")
        GcINV_Ret.DataSource = dSO.Tables("_krd")
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
     
        
      
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            Try
                'Buildernya = New SqlClient.SqlCommandBuilder(DA)
                'DA.UpdateCommand = Buildernya.GetUpdateCommand()
                'DA.InsertCommand = Buildernya.GetInsertCommand()
                'DA.DeleteCommand = Buildernya.GetDeleteCommand()

                'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
                'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
                'DA2.InsertCommand = Buildernya.GetInsertCommand()
                'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                'DA.UpdateCommand.Transaction = BTRANS
                'DA.InsertCommand.Transaction = BTRANS
                'DA.DeleteCommand.Transaction = BTRANS


                'DA2.UpdateCommand.Transaction = BTRANS
                'DA2.InsertCommand.Transaction = BTRANS
                'DA2.DeleteCommand.Transaction = BTRANS
               
                If rw1.Item("STATUS_AKTIF") = "AKTIF" And Not (rw1("kd_bank") Is Nothing Or TypeOf rw1("kd_bank") Is DBNull) Then
                    'MsgBox("True bos")
                    Dim sqlcmd1 As New SqlCommand("update KOPKAR.dbo.tabung set STATUS_AKTIF='AKTIF', kd_bank='" & rw1.Item("kd_bank") & "',Last_update=@tgl ,Last_Update_By='" & username & "' where NO_TABUNGAN='" & rw1.Item("NO_TABUNGAN") & "'", sqlconn, BTRANS) ' where NO_TABUNGAN='" & tx_noTbg.Text & "'
                    sqlcmd1.Parameters.AddWithValue("@tgl", getTanggal(BTRANS))
                    sqlcmd1.ExecuteNonQuery()

                    prc_automan(rw1.Item("tipe_trans"), rw1.Item("NO_TABUNGAN"), BTRANS)
                    'rw1.Item("Last_update") =
                    


                End If

                BTRANS.Commit()
            Catch e As Exception
                BTRANS.Rollback()
                dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                eror = e.Message
            End Try
        Next
        If Microsoft.VisualBasic.Len(eror) > 0 Then
            MsgBox("Ada Gagal, mohon di catat di kertas, :" & eror)
        End If
        ' End If
        'rw1.Item("Program_name") = Me.Name
        'txbNoTrans.Text = notrans

        'Next

        STATE = "EDIT"

        showMessages("Berhasil disimpan")
        LoadStruktur()



    End Sub
    Public Sub prc_automan(ByVal typex As String, ByVal no_trx As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_AUTOMAN_JURNAL"
        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 32).Value = typex
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 32).Value = no_trx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_DpsCair(ByVal notransvc As String, ByVal tglx As Date, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_CREATE_JUR_CAIR_DEPOSITO"
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 32).Value = notransvc
        sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date, 32).Value = tglx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_bunga(ByVal notransvc As String, ByVal tglx As Date, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_CREATE_JUR_BUNGA_SIMPANAN"
        sqlCmd.Parameters.Add("@notrans", SqlDbType.VarChar, 32).Value = notransvc
        sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date, 32).Value = tglx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub frmVerify_DPS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select KODE_TRANS,DESKRIPSI_TRANS from kodetranstabungan", sqlconn))
        DALOOKUP1.Fill(ds_cari, "_lookup2")
        LUE_Bank.Properties.DataSource = ds_cari.Tables("_lookup2")
        LUE_Bank.Properties.ValueMember = "KODE_TRANS"
        LUE_Bank.Properties.DisplayMember = "DESKRIPSI_TRANS"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select KODE_TRANS,DESKRIPSI_TRANS from kodetranstabungan", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_lookup3")
        RL_tran.DataSource = ds_gdg1.Tables("_lookup3")
        RL_tran.ValueMember = "KODE_TRANS"
        RL_tran.DisplayMember = "DESKRIPSI_TRANS"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select kd_bank,nama_bank from SIF_Bank", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_bank1")
        LUE_RekeningRealisasi.DataSource = ds_gdg2.Tables("_bank1")
        LUE_RekeningRealisasi.ValueMember = "kd_bank"
        LUE_RekeningRealisasi.DisplayMember = "nama_bank"

        DA2 = New SqlDataAdapter(New SqlCommand("select kd_bank,nama_bank from SIF_Bank", sqlconn))
        DA2.Fill(dSO1, "_bank2")
        LUE_Bank.Properties.DataSource = dSO1.Tables("_bank2")
        LUE_Bank.Properties.ValueMember = "kd_bank"
        LUE_Bank.Properties.DisplayMember = "nama_bank"


        isinomer()
    End Sub

    Private Sub GV_RLSKRD_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_RLSKRD.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_RLSKRD_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV_RLSKRD.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_RLSKRD_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_RLSKRD.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("kd_bank")
        If GV_RLSKRD.GetRow(e.RowHandle).item("kd_bank").ToString = vbNullString Then
            e.Valid = False
            GV_RLSKRD.SetColumnError(column1, "Rekening harus dipilih, apabila melakukan approve !")
        Else
            'GV_RLSKRD.SetColumnError(column1, "Rekening harus dipilih, apabila melakukan approve !")
            e.Valid = True
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            rw1.Item("kd_bank") = LUE_Bank.EditValue
        Next

    End Sub


    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        'For Each rw1 As DataRow In dSO.Tables("_krd").Rows
        '    rw1.Item("STATUS_AKTIF") = "AKTIF"
        'Next

        For i As Integer = 0 To GV_RLSKRD.RowCount - 1
            GV_RLSKRD.SetRowCellValue(i, "STATUS_AKTIF", "AKTIF")
        Next
    End Sub
End Class