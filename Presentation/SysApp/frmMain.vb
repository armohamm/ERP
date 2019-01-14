Imports System.Windows.Forms
Public Class frmMain
    Dim logouts As Boolean
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As Object

        frm = pnlDisplay2.Controls(0)
        frm.Enabled = True
        'Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.btnAdd.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        frm.add_click()
    End Sub


    Private Sub centerMe(ByVal frm As Form)
        Dim res As Double
        If pnlDisplay2.Width > frm.Width Then
            res = pnlDisplay2.Width - frm.Width
            frm.Left = Int(res / 2)
        End If
        If pnlDisplay2.Height > frm.Height Then
            res = pnlDisplay2.Height - frm.Height
            frm.Top = Int(res / 2)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim frm As Form
        If pnlDisplay2.Controls.Count > 0 Then

            frm = pnlDisplay2.Controls(0)
            frm.Close()
            frm.Dispose()
            Try
                umum.coll_form.Remove(NBC.SelectedLink.ItemName)

            Catch ex As Exception

            End Try
        End If
        If NBG.ItemLinks.Count > 0 Then
            NBC.SelectedLink.Dispose()
            If NBG.ItemLinks.Count Then
                NBC.SelectedLink = NBG.ItemLinks(0)
                NBC_LinkClicked(NBC, New DevExpress.XtraNavBar.NavBarLinkEventArgs(NBC.SelectedLink))
            End If
        End If
        If pnlDisplay2.Controls.Count = 0 Then
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnDelete.Enabled = False
            'pnlDisplay.Controls.Add(Label4)
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmBG.Dispose()
        'JAM.SetDigitalColor = SriClocks.DigitalColor.GreenColor
        JAM.ClockDisplayFormat = SriClocks.ClockFormat.TwentyFourHourFormat
    End Sub


    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not logouts Then End
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        umum.connect()
        collect_image()
        umum.createMenu("0", mnMenu)
        lblUser.Text = namauser
        lblToday.Text = Now.ToLongDateString
    End Sub

    Public Sub FORM_DISPOSED(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            umum.coll_form.Remove(sender.NAME)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub NBC_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NBC.LinkClicked
        Dim str As String = ""
        Dim obj As Form = Nothing
        Dim objs As Object
        If pnlDisplay2.Controls.Count > 0 Then
            If pnlDisplay2.Controls(0).Name <> e.Link.ItemName Then 'NBC.SelectedLink.ItemName Then
                pnlDisplay2.Controls.Clear()
            Else
                Exit Sub
            End If
        End If
        If coll_form.Count > 0 Then
            Try
                obj = coll_form.Item(NBC.SelectedLink.ItemName)
            Catch ex As Exception
                obj = Nothing
            End Try
        End If
        If obj Is Nothing Then
            obj = umum.GetFormByName(e.Link.ItemName)    ')NBC.SelectedLink.ItemName)
            If Not obj Is Nothing Then
                AddHandler obj.Disposed, AddressOf FORM_DISPOSED
                obj.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                add_pnl(obj)
                set_pos_frm(obj)
                pnlDisplay2.Controls.Add(obj)
                coll_form.Add(obj, obj.Name)
                obj.Text = sender.caption
                obj.Show()
                obj.Enabled = False
            Else
                Try
                    Dim Typet As Type = Me.GetType()
                    Dim method As Reflection.MethodInfo = Me.GetType.GetMethod(NBC.SelectedLink.ItemName)
                    method.Invoke(Me, Nothing)
                Catch ex As Exception
                    MsgBox("Form or Procedure Name not found " + ex.Message, MsgBoxStyle.Critical)
                    e.Link.Dispose()
                    If NBG.ItemLinks.Count > 0 Then
                        If NBG.ItemLinks.Count Then
                            NBC.SelectedLink = NBG.ItemLinks(0)
                            NBC_LinkClicked(NBC, New DevExpress.XtraNavBar.NavBarLinkEventArgs(NBC.SelectedLink))
                        End If
                    End If
                    Exit Sub
                End Try

            End If
        Else
            set_pos_frm(obj)
            pnlDisplay2.Controls.Add(obj)
            obj.Show()
        End If
        objs = obj
        If Not objs Is Nothing Then
            btnSave.Enabled = objs.btnSave
            btnAdd.Enabled = objs.btnadd
            btnEdit.Enabled = objs.btnEdit
            btnCancel.Enabled = objs.btnCancel
            btnDelete.Enabled = objs.btnDelete
        End If
    End Sub
    Public Sub Logout()
        frmLogin.Show()
        logouts = True
        Me.Close()
    End Sub
    Public Sub ExitForm()
        End
    End Sub

    Private Sub btnCloseApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseApp.Click
        Me.Close()
    End Sub

    Private Sub cmdUnhook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnhook.Click
        Dim obj As Object

        obj = pnlDisplay2.Controls(0)
        obj.PARENT = Nothing
        obj.visible = False
        obj.TopLevel = True
        obj.TopMost = True
        obj.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        DirectCast(obj, Form).MinimizeBox = False
        DirectCast(obj, Form).MaximizeBox = False
        btnClose.PerformClick()
        obj.Controls("pnlHook").Visible = True
        obj.Show()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frm As Object
        frm = pnlDisplay2.Controls(0)
        frm.Enabled = True
        frm.state = "EDIT"
        'Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.btnAdd.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        frm.edit_click()
    End Sub

    Private Sub pnlDisplay_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs)
        Dim frm As Object
        frm = pnlDisplay2.Controls(0)
        If Not TypeOf frm Is Form Then Exit Sub
        If frm.STATE = "" Then
            Me.btnSave.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnCancel.Enabled = False
            Me.btnAdd.Enabled = True
            Me.btnEdit.Enabled = True
        ElseIf frm.state = "ADD" Then
            Me.btnSave.Enabled = True
            Me.btnCancel.Enabled = True
            Me.btnAdd.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnDelete.Enabled = False
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim frm As Object
        frm = pnlDisplay2.Controls(0)
        If frm.save_click() Then
            'umum.save(frm.name)
            '  Me.btnSave.Enabled = False
            '  Me.btnCancel.Enabled = False

            '  Me.btnAdd.Enabled = True
            '  Me.btnEdit.Enabled = True
            '  Me.btnDelete.Enabled = False
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim frm As Object
        frm = pnlDisplay2.Controls(0)
        frm.cancel_click()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim frm As Object
        frm = pnlDisplay2.Controls(0)
        frm.delete_click()
    End Sub
End Class
