
'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmRLS_kabag
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation


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
        dSO.Relations.Clear()
        If Not dSO.Tables("_dtl") Is Nothing Then dSO.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()


        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer,(JML_POKOK+JML_BUNGA) as JML_ANGS from kredit where stat_approve = 4 and stat_rls=1 and stat_approve_rls=0", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where stat_approve = 4 and stat_rls=1 and stat_approve_rls=0", sqlconn))
        DA2.Fill(dSO, "_dtl")
        If dSO.Tables("_krd").Rows.Count > 0 Then
            drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"))
            GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_dtl_rls)
        Else
            Exit Sub
        End If
        GcINV_Ret.DataSource = dSO.Tables("_krd")
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub cetak_click()
        MsgBox("Cetak Silahkan menggunakan Laporan Realisasi di menu Monitoring", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then
        'notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
        For Each rw1 As DataRow In dSO.Tables("_krd").Select("stat_approve_rls=1")
            rw1.Item("tgl_approve_rls") = getTanggal()
            rw1.Item("approve_rls_by") = username
        Next
        'Else
        'For Each rw1 As DataRow In dSO.Tables("_krd").Rows

        '    If rw1.RowState = DataRowState.Modified Then
        '        rw1.Item("cetak_ke") = rw1("cetak_ke") + 1

        '    End If

        'Next


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

            DA.Update(dSO.Tables("_krd"))
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            STATE = "EDIT"
            LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Private Sub frmApproveKRD2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        GV_RLSKRD.FocusedColumn = GV_RLSKRD.Columns("stat_approve_rls")
        'GV_RLSKRD.Columns("nasabah_id").Visible = False

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        isinomer()
    End Sub

    '    Private Sub GV_RLSKRD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_RLSKRD.Click
    '        If Not dSO1.Tables("_hist") Is Nothing Then
    '            dSO1.Tables("_hist").Clear()
    '        End If
    '        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from angsuran a inner join kredit k on a.no_kredit=k.no_trans " & _
    '                                                                  "where a.nasabah_id= '" & GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") & "'", sqlconn))
    '        'MsgBox()
    '        DA2.Fill(dSO1, "_hist")
    '        GcHist.DataSource = dSO1.Tables("_hist")
    '        Gv_hist.BestFitColumns()
    '        If GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") = "000017" Then
    '            T_skor.Text = "BURUK"
    '        ElseIf GV_RLSKRD.GetFocusedRowCellValue("nasabah_id") = "000130" Then
    '            T_skor.Text = "BAIK"
    '        Else
    '            T_skor.Text = ""
    '        End If

    '    End Sub

    '    Private Sub GcHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        milih = GV_RLSKRD.GetFocusedRowCellValue("nasabah_id")
    '        hist_pegawai.reload_table(milih)
    '        hist_pegawai.ShowDialog()
    '    End Sub
End Class