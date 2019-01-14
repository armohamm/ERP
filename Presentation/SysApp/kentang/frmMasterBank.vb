'####### by KENTANG ######

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMasterBank
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dsBank, dsBB As New DataSet
    Dim daBank, daLookUpBB As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim bld As New SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        If Not dsBank.Tables("SIF_Bank") Is Nothing Then dsBank.Tables("SIF_Bank").Clear()
        daBank = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.SIF_Bank", sqlconn))
        daBank.Fill(dsBank, "SIF_Bank")
        gcBank.DataSource = dsBank.Tables("SIF_Bank")
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        btnDelete = True
        setStatus()
    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub delete_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus()
    End Sub

    Public Sub simpan()

        For Each rw As DataRow In dsBank.Tables("SIF_Bank").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = getKodeCabang()
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If

        Next
        Try
            bld = New SqlCommandBuilder(daBank)
            daBank.InsertCommand = bld.GetInsertCommand()
            daBank.UpdateCommand = bld.GetUpdateCommand()
            daBank.DeleteCommand = bld.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daBank.UpdateCommand.Transaction = BTRANS
            daBank.InsertCommand.Transaction = BTRANS
            daBank.DeleteCommand.Transaction = BTRANS

            daBank.Update(dsBank, "SIF_Bank")
            dsBank.Tables("SIF_Bank").AcceptChanges()
            BTRANS.Commit()
            showMessages("Data Berhasil di Update..!", 14)
        Catch ex As Exception
            BTRANS.Rollback()
            dsBank.Tables("SIF_Bank").RejectChanges()
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Public Sub hapus()
        Dim builder As New SqlCommandBuilder(daBank)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(gvBank.SelectedRowsCount - 1)
        For i = 0 To gvBank.SelectedRowsCount - 1
            rows(i) = gvBank.GetDataRow(gvBank.GetSelectedRows(i))
        Next
        gvBank.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            gvBank.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMasterBank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        fillBB()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub gvBank_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles gvBank.InitNewRow
        Dim View As ColumnView = sender
        'View.SetRowCellValue(e.RowHandle, View.Columns("kd_bank"), CInt(View.GetRowCellValue(e.RowHandle, "kd_bank")) + 1)
    End Sub

    Private Sub fillBB()
        daLookUpBB = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar where kd_buku_besar like '111%' and grup_header = 'D'", sqlconn))
        daLookUpBB.Fill(dsBB, "cari_BB")
        LookUpEditBkBsr.DataSource = dsBB.Tables("cari_BB")
        LookUpEditBkBsr.ValueMember = "kd_buku_besar"
        LookUpEditBkBsr.DisplayMember = "nm_buku_besar"
    End Sub
End Class