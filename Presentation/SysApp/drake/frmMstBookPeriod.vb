'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMstBookPeriod
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim builderM As New SqlCommandBuilder

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
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

    Public Sub call_procedure(ByVal no_jur As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.MUTASI_NERACA"

        sqlCmd.Parameters.Add("@vthnbln", SqlDbType.Char).Value = no_jur
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub simpan()
        Try
            For Each rw As DataRow In dSO.Tables("_SIF_BookPeriod").Rows
                If rw.RowState = DataRowState.Added Then
                    rw("Kd_Cabang") = 1
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name
                    If rw.Item("status_close").Equals(RepCek.ValueChecked) Then
                        call_procedure(rw.Item("thn_buku") + rw.Item("bln_buku"), BTRANS)
                    End If
                ElseIf rw.RowState = DataRowState.Modified Then
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                    If rw.Item("status_close").Equals(RepCek.ValueChecked) Then
                        call_procedure(rw.Item("thn_buku") + rw.Item("bln_buku"), BTRANS)
                    End If
                End If
            Next

            'Dim builder As New SqlCommandBuilder(DA)
            builderM = New SqlCommandBuilder(DA)
            DA.InsertCommand = builderM.GetInsertCommand()
            DA.UpdateCommand = builderM.GetUpdateCommand()
            DA.DeleteCommand = builderM.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO, "_SIF_BookPeriod")
            dSO.Tables("_SIF_BookPeriod").AcceptChanges()

            BTRANS.Commit()

            showMessages("Data Berhasil di Update..!", 14)
        Catch ex As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dSO.Tables("_SIF_BookPeriod").RejectChanges()
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvBookPeriod.SelectedRowsCount - 1)
        For i = 0 To GvBookPeriod.SelectedRowsCount - 1
            rows(i) = GvBookPeriod.GetDataRow(GvBookPeriod.GetSelectedRows(i))
        Next
        GvBookPeriod.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvBookPeriod.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmMstBookPeriod_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DA.Fill(dSO, "_SIF_BookPeriod")
        GcBookPeriod.DataSource = dSO.Tables("_SIF_BookPeriod")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub
End Class