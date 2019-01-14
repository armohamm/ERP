Imports System.Data
Imports System.Windows.Forms
Imports Presentation.frmMain
Imports System.Data.SqlClient
Public Class frmOTP
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Private Sub frmOTP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub add_click()

    End Sub
    Private Sub cmdGenerated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerated.Click
        Dim k As Int16
        Dim pwd As String
        If ckDelete.Checked Then
            If MsgBox("Hapus Password Sebelumnya Yang Belum Terpakai ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Password") = MsgBoxResult.No Then
                Exit Sub
            Else
                lblhasil.Text = "Menghapus Password"
                lblhasil.Refresh()
                k = New SqlCommand("delete from sif.dbo.sif__otp where tgl_used is null", sqlconn).ExecuteNonQuery
            End If
        End If
        For i As Int16 = 1 To 200
            pwd = umum.GetRandomPasswordUsingGUID(15)
            k = New SqlCommand("insert into sif.dbo.sif__otp values('" & pwd & "',null,null,'','')", sqlconn).ExecuteNonQuery
            lblhasil.Text = pwd
            lblhasil.Refresh()
            lblhasil.Text = "Done"
        Next
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub ckDelete_QueryCheckStateByValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs) Handles ckDelete.QueryCheckStateByValue
        If e.CheckState = CheckState.Checked Then
            ckDelete.ForeColor = Color.Red
        Else
            ckDelete.ForeColor = Color.Black
        End If
    End Sub
End Class