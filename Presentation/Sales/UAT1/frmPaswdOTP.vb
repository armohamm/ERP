Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmPaswdOTP
    Public allowed As Boolean = False
    Public btrans As SqlTransaction = Nothing
    Public PENDING As Boolean = False
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        Dim cmd As New SqlCommand
        If Not btrans Is Nothing Then cmd.Transaction = btrans
        lblState.Text = ")"
        If e.KeyCode = Keys.Escape Then
            allowed = False
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If ckPending.EditValue Then
                PENDING = True
                Close()
                Exit Sub
            End If
            cmd.Connection = sqlconn
            cmd.CommandText = "select 1 from sif.dbo.sif__OTP where pwd='" & txtPassword.Text & "' and expired is null"
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cmd.CommandText = "update sif.dbo.sif__OTP set expired='Y', used_by='" & username & "', tgl_used = getDate() where pwd='" & txtPassword.Text & "' and expired is null"
                Dim i As Double = cmd.ExecuteNonQuery
                If i > 0 Then
                    allowed = True
                    lblState.Text = "Password Diterima.."
                    lblState.Refresh()
                    System.Threading.Thread.Sleep(500)
                    dr.Close()
                    Me.Close()
                Else
                    lblState.Text = "Password Ditolak.."
                    txtPassword.SelectAll()
                End If
            Else
                lblState.Text = "Password Ditolak.."
                txtPassword.SelectAll()
            End If
            dr.Close()
        End If

    End Sub

    Private Sub frmPaswdOTP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        txtPassword.Text = ""
    End Sub

    Private Sub ckPending_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckPending.KeyDown
        If ckPending.EditValue Then
            If e.KeyCode = Keys.Enter Then
                txtPassword_KeyDown(txtPassword, e)
            End If
        End If
    End Sub

End Class