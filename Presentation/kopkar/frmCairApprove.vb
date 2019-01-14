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
Public Class frmCairApprove
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit where stat_approve = 4 and stat_cair=0 and stat_rls=1 and stat_approve_rls=1 ", sqlconn))
        DA.Fill(dSO, "_krd")
        GcINV_Ret.DataSource = dSO.Tables("_krd")
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            'notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
            For Each rw1 As DataRow In dSO.Tables("_krd").Select("stat_cair_approve=1")
                rw1.Item("stat_approve") = 5 'cair
                rw1.Item("stat_cair") = 0
                rw1.Item("stat_cair_approve") = 0
                ' If rw1.RowState = DataRowState.Modified Then
                'If IIf(rw1.Item("stat_cair_approve") Is DBNull.Value, False, rw1.Item("stat_cair_approve")) = True Then
                'If rw1.Item("stat_cair") = 4 Then
                'MsgBox("True bos")
                'rw1.Item("stat_cair_approve") = 0
                'rw1.Item("stat_cair") = -0
                'rw1.Item("cair_by") = username

                'End If

                'End If
                'rw1.Item("Program_name") = Me.Name
                'txbNoTrans.Text = notrans
            Next
        Else
            For Each rw1 As DataRow In dSO.Tables("_krd").Rows

                If rw1.RowState = DataRowState.Modified Then
                    If IIf(rw1.Item("stat_cair_approve") Is DBNull.Value, False, rw1.Item("stat_cair_approve")) = True Then
                        'MsgBox("True bos")
                        rw1.Item("stat_cair") = 0
                        'rw1.Item("tgl_cair") = getTanggal()
                        'rw1.Item("cair_by") = username
                        rw1.Item("stat_approve") = 5
                    End If
                    rw1.Item("cetak_ke") = rw1("cetak_ke") + 1

                End If

            Next


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

    Private Sub frmCair_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        DALOOKUP = New SqlDataAdapter(New SqlCommand("Select d.Val_kode1 kd_buku_besar, bb.nm_buku_besar " & _
                                                     "From KOPKAR.dbo.SIF_Gen_Reff_D d " & _
                                                     "inner join KOPKAR.dbo.m_buku_besar bb " & _
                                                     "on bb.kd_buku_besar = d.Val_kode1 " & _
                                                     "where d.Id_Ref_Data = 'KBL' or d.Id_Ref_Data = 'KKL'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LUE_RekeningRealisasi.DataSource = ds_cari.Tables("_lookup2")
        LUE_RekeningRealisasi.ValueMember = "kd_buku_besar"
        LUE_RekeningRealisasi.DisplayMember = "nm_buku_besar"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("Select d.Val_kode1 kd_buku_besar, bb.nm_buku_besar " & _
                                                     "From KOPKAR.dbo.SIF_Gen_Reff_D d " & _
                                                     "inner join KOPKAR.dbo.m_buku_besar bb " & _
                                                     "on bb.kd_buku_besar = d.Val_kode1 " & _
                                                     "where d.Id_Ref_Data = 'KBL' or d.Id_Ref_Data = 'KKL'", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bank")
        LUE_Bank.Properties.DataSource = ds_cari1.Tables("_bank")
        LUE_Bank.Properties.ValueMember = "kd_buku_besar"
        LUE_Bank.Properties.DisplayMember = "nm_buku_besar"


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
        Dim column1 As GridColumn = view.Columns("rek_pencairan")
        If GV_RLSKRD.GetRow(e.RowHandle).item("rek_pencairan").ToString = vbNullString Then
            e.Valid = False
            GV_RLSKRD.SetColumnError(column1, "Rekening harus dipilih, apabila melakukan approve !")
        Else
            'GV_RLSKRD.SetColumnError(column1, "Rekening harus dipilih, apabila melakukan approve !")
            e.Valid = True
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadStruktur()
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            rw1.Item("rek_pencairan") = LUE_Bank.EditValue
        Next
    End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        For Each rw1 As DataRow In dSO.Tables("_krd").Rows
            rw1.Item("stat_cair_approve") = 1
        Next
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        LoadStruktur()
    End Sub
End Class