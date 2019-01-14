Imports System.Data
Imports System.Windows.Forms
Imports Presentation.frmMain
Public Class frmLogin
    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If AscW(e.KeyChar) = 13 Then
            login()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        'Me.Owner.Opacity = 0.75
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If AscW(e.KeyChar) = 13 Then
            login()
        End If
    End Sub

    Private Sub login()
        Dim dadbe As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim i As Int16 = 0
        Dim j As Int16 = 0

        If txtPassword.Text = "" Then
            txtPassword.Select()
        ElseIf txtUsername.Text = "" Then
            txtUsername.Select()
        Else
            If txtUsername.Text = "admin" Then
                username = "admin"
                frmMain.Show()

                txtUsername.Focus()
                Me.Hide()

                txtPassword.Text = ""
                txtUsername.Text = ""
                pnlRole.Visible = False
                Exit Sub
            Else
                pnlLogin.Enabled = False
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nama, mrole.idrole from sif.dbo.muser_role, sif.dbo.mrole where muser_role.idrole=mrole.idrole and iduser='" & txtUsername.Text & "'", sqlconn))
                dadbe.Fill(ds, "muser_role")
                If ds.Tables(0).Rows.Count = 0 Then
                    showMessages("Username Atau Password Salah!")
                    pnlLogin.Enabled = True
                    txtUsername.SelectAll()
                    txtUsername.Select()
                    Exit Sub
                End If
                Dim rows As New RowStyle
                Dim opt As New DevExpress.XtraEditors.SimpleButton
                username = txtUsername.Text
                layRole.Visible = False
                layRole.RowStyles.Clear()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    opt = New DevExpress.XtraEditors.SimpleButton
                    opt.Image = btnLogin.Image
                    opt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
                    opt.Height = 28
                    opt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

                    opt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
                    AddHandler opt.Click, AddressOf btn_click
                    opt.Text = ds.Tables(0).Rows(i).Item(0).ToString.ToUpperInvariant
                    opt.Tag = ds.Tables(0).Rows(i).Item(1)
                    If ds.Tables(0).Rows.Count = 1 Then
                        btn_click(opt, New EventArgs)
                        Exit Sub
                    End If
                    rows = New RowStyle
                    rows.Height = 28
                    layRole.RowStyles.Add(rows)
                    layRole.SetRow(opt, i)
                    opt.Dock = DockStyle.Top
                    opt.Parent = layRole

                Next
                layRole.Height = i * 29 + 50
                layRole.SetRow(lblPilRol, 0)
                pnlRole.Dock = DockStyle.Fill
                layRole.Top = (Me.Height - layRole.Height) / 2
                layRole.Left = (Me.Width - layRole.Width) / 2

            End If
            pnlRole.Visible = True
            layRole.Visible = True
        End If
    End Sub
    Private Sub btn_click(ByVal sender As Object, ByVal args As EventArgs)
        umum.userRole = sender.tag
        frmMain.Show()
        Me.Hide()
        txtPassword.Text = ""
        txtUsername.Text = ""
        layRole.RowStyles.Clear()
        pnlRole.Visible = False
        layRole.Visible = False
        pnlLogin.Enabled = True
        txtUsername.Focus()
    End Sub

    Private Sub cmdkeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        End
    End Sub
End Class

