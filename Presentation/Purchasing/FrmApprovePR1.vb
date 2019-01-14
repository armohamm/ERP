'*******************************
' // CREATED BY YAYA         \\
' \\ EDITED BY DIDIER DROGBA //
'*******************************

Imports System.Data.SqlClient
Public Class FrmApprovePR1

    'Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public STATE As String
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public milih As String
    Public dtable As DataTable
    Private rw As DataRow
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Dim dSO, ds1, ds2, ds_cari, dsLOV As New DataSet
    Dim DA, DA2, da_cari, DALOOKUP, DAStat As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()

        'DA = New SqlDataAdapter(New SqlCommand("SELECT distinct no_pr,jns_dpm,tgl_pr,rec_stat,ket_approve,keterangan from PURC.dbo.PURC_PR_D where rec_stat <> 'APPROVE'", sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        search()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub


    Public Sub simpan()
        Dim dr As SqlDataReader
        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            'MessageBox.Show(rw("no_pr") + " " + rw("approval"))
            dr = New SqlClient.SqlCommand("update PURC.dbo.PURC_PR_D set rec_stat='" & rw("rec_stat") & "', ket_approve='" & rw("ket_approve") & "' where no_pr='" & rw("no_pr") & "'", sqlconn).ExecuteReader
            dr.Close()
        Next
        'Exit Sub
        'Dim BTRANS As SqlTransaction
        'Buildernya = New SqlClient.SqlCommandBuilder(DA)
        'DA.UpdateCommand = Buildernya.GetUpdateCommand()
        'DA.InsertCommand = Buildernya.GetInsertCommand()
        'DA.DeleteCommand = Buildernya.GetDeleteCommand()

        'BTRANS = sqlconn.BeginTransaction("1")
        'DA.UpdateCommand.Transaction = BTRANS
        'DA.InsertCommand.Transaction = BTRANS
        'DA.DeleteCommand.Transaction = BTRANS

        'For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
        '    If rw.RowState = DataRowState.Added Then
        '        rw("Kd_Cabang") = kdcabang
        '        rw("Last_Create_Date") = Now
        '        rw("Last_Created_By") = umum.username
        '        rw("Program_Name") = Me.Name

        '    ElseIf rw.RowState = DataRowState.Modified Then
        '        rw.Item("Last_Update_Date") = Now
        '        rw.Item("Last_Updated_By") = username
        '        rw("tgl_approve") = Now
        '        rw("user_approve") = umum.username
        '    End If
        'Next
        'Try
        '    DA.Update(dSO, "_DpmApprv")
        '    dSO.Tables("_DpmApprv").AcceptChanges()
        '    STATE = "EDIT"
        '    BTRANS.Commit()
        'Catch ex As Exception
        '    BTRANS.Rollback()
        '    dSO.Tables("_DpmApprv").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        'End Try

        showMessages("Approval PR berhasil di Update!")
        GcApprvDPM.Refresh()
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GVApprvDPM.SelectedRowsCount - 1)
        For i = 0 To GVApprvDPM.SelectedRowsCount - 1
            rows(i) = GVApprvDPM.GetDataRow(GVApprvDPM.GetSelectedRows(i))
        Next
        GVApprvDPM.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GVApprvDPM.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub FrmApproveDPM1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT distinct no_pr,jns_dpm,tgl_pr,rec_stat,ket_approve,keterangan from PURC.dbo.PURC_PR_D where rec_stat <> 'APPROVE'", sqlconn))
        DA = New SqlDataAdapter(New SqlCommand("select * from  PURC.dbo.PURC_PR_D where rec_stat = 'ENTRY'and " & _
        "  no_pr  not in (select no_pr  from PURC.dbo.PURC_CHOICE_SUPP )", sqlconn))

        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        'GVApprvDPM.Columns(1).Group()

        'DA2 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_DPM_D", sqlconn))
        'DA2.Fill(ds2, "_DpmApprv_d")
        'GcApprvDPM.DataSource = ds2.Tables("_DpmApprv_d")


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        lookupDivisi.ValueMember = "Kd_Departemen"
        lookupDivisi.DisplayMember = "Nama_Departemen"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        LOVstatus.Properties.NullText = "ENTRY"
        LOVstatus.EditValue = "ENTRY"
    End Sub


    'Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    '    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub


    Private Sub GVApprvDPM_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVApprvDPM.RowClick
        Dim nopr As String = GVApprvDPM.GetRowCellValue(e.RowHandle, "no_pr").ToString
        If Not ds_cari.Tables("detailpr") Is Nothing Then ds_cari.Tables("detailpr").Clear()
        da_cari = New SqlDataAdapter(New SqlCommand("select D.*,B.nama_barang,DP.qty from PURC.dbo.PURC_PR_D D " & _
                                                    "left join PURC.dbo.PURC_DPM_D DP on D.no_dpm=DP.No_DPM and D.kd_stok=DP.Kd_Stok " & _
                                                    "left join SIF.dbo.SIF_Barang B on D.kd_stok=B.kode_barang  where D.no_pr='" & nopr & "' ", sqlconn))
        da_cari.Fill(ds_cari, "detailpr")
        If ds_cari.Tables("detailpr").Rows.Count Then
            GVInfo.ViewCaption = "Info Detail Purchase Request " + nopr
            GCInfo.DataSource = ds_cari.Tables("detailpr")
        End If

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Sub search()
        dSO.Tables("_DpmApprv").Clear()

        DA = New SqlDataAdapter(New SqlCommand("select * from  PURC.dbo.PURC_PR_D where rec_stat = '" & LOVstatus.EditValue & "'and " & _
        "  no_pr  not in (select no_pr  from PURC.dbo.PURC_CHOICE_SUPP )", sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
    End Sub


    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        search()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        dSO.Tables("_DpmApprv").Clear()

        DA = New SqlDataAdapter(New SqlCommand("select * from  PURC.dbo.PURC_PR_D where no_pr not in (select no_pr from PURC.dbo.PURC_CHOICE_SUPP )", sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
    End Sub

    Private Sub LOVstatus_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LOVstatus.QueryPopUp
        dsLOV.Clear()

        DAStat = New SqlDataAdapter(New SqlCommand("select distinct (rec_stat) from PURC.dbo.PURC_PR_D", sqlconn))
        DAStat.Fill(dsLOV, "stat")
        LOVstatus.Properties.DataSource = dsLOV.Tables("stat")
        LOVstatus.Properties.ValueMember = "rec_stat"
        LOVstatus.Properties.DisplayMember = "rec_stat"
    End Sub

End Class