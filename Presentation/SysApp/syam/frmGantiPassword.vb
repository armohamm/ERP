Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmGantiPassword

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtPasswdBaru.Text <> txtRetype.Text Then
            showMessages("Password Tidak Sama")
            Exit Sub
        End If
        If txtPasswdBaru.Text = "" Then
            showMessages("Password Tidak Boleh Kosong")
            Exit Sub
        End If
        Dim dr As SqlDataReader = New SqlCommand("select * from sif.dbo.muser where userid= '" & username & "' and passwd = '" & AES_Encrypt(txtPaswdLama.Text, "password") & "'", sqlconn).ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            showMessages("Password Lama Salah")
        Else
            Dim i As Int16 = New SqlCommand("update sif.dbo.muser set passwd='" & AES_Encrypt(txtPasswdBaru.Text, "password") & "' where userid= '" & username & "'", sqlconn).ExecuteNonQuery
            showMessages("Password Telah diupdate")
            Dispose()
        End If
    End Sub

    Private Sub txtPaswdLama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaswdLama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPasswdBaru.Focus()
        End If
    End Sub
    Private Sub txtPasswdBaru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPasswdBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRetype.Focus()
        End If
    End Sub
    Private Sub txtRetype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetype.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdOk_Click(cmdOk, New EventArgs)
        End If
    End Sub
End Class