'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMntSysParam

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter


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

    Public Sub delete_click()
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
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
        'Dim builder As New SqlCommandBuilder(DA)
        'For Each rw As DataRow In dSO.Tables("SIF_Parameter").Rows

        '    rw("Kd_Cabang") = 1
        '    rw("Last_Create_Date") = Now
        '    rw("Last_Created_By") = umum.username
        '    rw("Program_Name") = Me.Name
        '    'dSO.Tables("SIF_Parameter").Rows.Add(rw)
        'Next

        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("SIF_Parameter").Rows
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
        DA.Update(dSO, "SIF_Parameter")
        dSO.Tables("SIF_Parameter").AcceptChanges()
        showMessages("Data berhasil di Update..", 14)
    End Sub
    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GVParam.SelectedRowsCount - 1)
        For i = 0 To GVParam.SelectedRowsCount - 1
            rows(i) = GVParam.GetDataRow(GVParam.GetSelectedRows(i))
        Next
        GVParam.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GVParam.EndSort()
        End Try

        simpan()
    End Sub

    Private Sub frmMntSysParam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Parameter", sqlconn))
        DA.Fill(dSO, "SIF_Parameter")
        gcSysParam.DataSource = dSO.Tables("SIF_Parameter")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        Button1.Hide()
        btnDel.Hide()

    End Sub


   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Baris tersebut akan dihapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub GVParam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Delete) Then
            If MsgBox("Data dalam baris tersebut akan dihapus?", MsgBoxStyle.YesNo) <> MsgBoxResult.No Then Exit Sub
            btnDel_Click(sender, e)
        End If
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Data akan disimpan ke Database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
End Class