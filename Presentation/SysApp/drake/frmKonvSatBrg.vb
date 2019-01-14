'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi                                   =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Boleh di Copy Paste asal jgn lupa Uang Rokok Surya 16 hehehhee...  =
'======================================================================

Imports System.Data.SqlClient

Public Class frmKonvSatBrg
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub

    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_SIF_JnsBrg").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = 1
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "_SIF_JnsBrg")
        dSO.Tables("_SIF_JnsBrg").AcceptChanges()
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvJnsBarang.SelectedRowsCount - 1)
        For i = 0 To GvJnsBarang.SelectedRowsCount - 1
            rows(i) = GvJnsBarang.GetDataRow(GvJnsBarang.GetSelectedRows(i))
        Next
        GvJnsBarang.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvJnsBarang.EndSort()
        End Try
        simpan()
    End Sub

End Class