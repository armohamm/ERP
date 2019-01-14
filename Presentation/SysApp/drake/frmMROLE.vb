'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Public Class frmMROLE
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean

    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Dim DA As SqlClient.SqlDataAdapter

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub

    Private Sub frmMROLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.MROLE", sqlconn))
        DA.Fill(dSO, "_MROLE")
        GcMRole.DataSource = dSO.Tables("_MROLE")
    End Sub

    Public Sub simpan()

        Dim builder As New SqlCommandBuilder(DA)
        DA.InsertCommand = builder.GetInsertCommand
        DA.UpdateCommand = builder.GetUpdateCommand
        DA.DeleteCommand = builder.GetDeleteCommand
        DA.Update(dSO, "_MROLE")
        dSO.Tables("_MROLE").AcceptChanges()


    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMRole.SelectedRowsCount - 1)
        For i = 0 To GvMRole.SelectedRowsCount - 1
            rows(i) = GvMRole.GetDataRow(GvMRole.GetSelectedRows(i))
        Next
        GvMRole.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMRole.EndSort()
        End Try
        simpan()

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Data dalam baris tersebut akan dihapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub GcMRole_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GcMRole.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If MsgBox("Data dalam baris tersebut akan dihapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
        End If
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class