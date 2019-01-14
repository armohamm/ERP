Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports AnalogClock
Imports System.Threading
Public Class frmMain
    Dim logouts As Boolean
    Dim imgBG As Bitmap
    Public Sub reconnect()
        connect()
    End Sub
    Public Sub showHidePanel7()
        Dim obj As Object
        If pnlDisplay2.Controls.Count = 1 Then obj = pnlDisplay2.Controls(0)
        Panel7.Visible = Not Panel7.Visible
        If Not obj Is Nothing Then
            pnlDisplay2.Controls.Clear()
            pnlDisplay2.Controls.Add(obj)
        End If
    End Sub
    Public Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
    Public Sub showChat()
        frmChat.ShowDialog()
    End Sub
    Public Sub showhidepnl()
        NBC.Visible = Not NBC.Visible
        split.Visible = Not split.Visible
    End Sub
    Private Sub centerMe(ByVal frm As Form)
        Dim res As Double
        If pnlDisplay2.Width > frm.Width Then
            res = pnlDisplay2.Width - frm.Width
            frm.Left = Int(res / 2)
            If frm.Left < 0 Then frm.Left = 0
        End If
        frm.Top = 0
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim frm As Form
        Dim obj As Object
        Dim str As String
        If pnlDisplay2.Controls.Count > 0 Then
            frm = pnlDisplay2.Controls(0)
            frm.Close()
            frm.Dispose()
            Try
                obj = NBC.SelectedLink.Group
                str = NBC.SelectedLink.Item.Name
                NBC.Items.Remove(NBC.SelectedLink.Item)
                If obj.ItemLinks.Count = 0 Then
                    NBC.Groups.Remove(obj)
                    If NBC.Groups.Count > 0 Then
                        NBC.SelectedLink = NBC.Groups(0).ItemLinks(0)
                        NBC_LinkClicked(NBC, New DevExpress.XtraNavBar.NavBarLinkEventArgs(NBC.SelectedLink))
                    Else
                        'NBC.Groups(0).Caption = ""
                        btnAdd.Enabled = False
                        btnEdit.Enabled = False
                        btnSave.Enabled = False
                        btnCancel.Enabled = False
                        btnDelete.Enabled = False

                    End If
                Else
                    NBC.SelectedLink = obj.ItemLinks(0)
                    NBC_LinkClicked(NBC, New DevExpress.XtraNavBar.NavBarLinkEventArgs(NBC.SelectedLink))
                End If
                umum.coll_form.Remove(str)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmMain_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded
        centerMe()

    End Sub
    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not logouts Then End
    End Sub
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Clock1.Running = False
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.Refresh()
        umum.connect()
        collect_image()
        umum.createMenu("0", mnMenu)
        lblUser.Text = namauser
        'lblToday.Text = Now.ToLongDateString
        frmBG.Dispose()
        frmNotif.ShowDialog(Me)
        'JAM.ClockDisplayFormat = SriClocks.ClockFormat.TwentyFourHourFormat

        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now)
        loadbg()
        Clock1.Running = True

        '// tambahan untuk menampikan default run form at start up
        Dim sqlreader As SqlClient.SqlDataReader = New SqlClient.SqlCommand("select call_form from menu mn, role_menu rl where nm_menu=kode_menu and isnull([value],0)=2 and idrole = '" & umum.userRole & "' and isnull([default],'')='Y' ", sqlconn).ExecuteReader  ''and isnull([default],'')='Y'
        While sqlreader.Read
            Try
                call_form_manual(sqlreader.Item(0))
            Catch ex As Exception
                sqlreader.Close()
                MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error Loading Default Form")
                Exit While
            End Try
        End While

        sqlreader.Close()
        Dim contextMenu As New ContextMenu
        Dim menuItem As New MenuItem("Exit")
        contextMenu.MenuItems.Add(menuItem)

        ' Associate context menu with Notify Icon 
        Notif.ContextMenu = contextMenu
        AddHandler Notif.MouseClick, AddressOf Notif_Click
        'Add functionality for menu Item click 
        AddHandler menuItem.Click, AddressOf menuItem_Click
        findNotif()

    End Sub
    Sub findNotif()

        With New SqlCommand("select count(1) from KOPKAR.[dbo].[SIF_NOTIF] where UserTujuan='" + username + "' and sts=0", sqlconn)
            With .ExecuteReader
                .Read()
                Dim jml As String = .Item(0).ToString
                .Close()
                If jml > 0 Then
                    Notif.Text = "Ada Pesan Baru"
                    Notif.BalloonTipText = "Anda Mendapatkan " + jml + " Pesan Baru"
                    Notif.BalloonTipTitle = "Pesan Baru"
                    Notif.ShowBalloonTip(10000)
                End If
            End With
        End With


    End Sub
    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Notif_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Dim frm As New frmNotif
        frmNotif.ShowDialog(Me)
    End Sub

    Sub loadbg(Optional ByVal isDel As Boolean = False)
        If System.IO.File.Exists(App_Path() & "\bg.jpg") Then
            If Not isDel Then
                Dim ios As New IO.FileStream(App_Path() & "\bg.jpg", IO.FileMode.Open)
                Dim buffer As Byte()
                ReDim buffer(ios.Length)
                ios.Read(buffer, 0, ios.Length)
                Dim stream As New IO.MemoryStream(buffer)
                pnlDisplay2.BackgroundImage = System.Drawing.Image.FromStream(stream)
                stream.Close()
                stream.Dispose()
                ios.Close()
                ios.Dispose()
            Else
                System.IO.File.Delete(App_Path() & "\bg.jpg")
                pnlDisplay2.BackgroundImage = Nothing
            End If
        End If
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
            If pnlDisplay2.Controls(0).Name = e.Link.ItemName Then 'NBC.SelectedLink.ItemName Then
                Exit Sub
            End If
        End If
        Clock1.Running = False
        If coll_form.Count > 0 Then
            Try
                obj = coll_form.Item(NBC.SelectedLink.ItemName)
            Catch ex As Exception
                obj = Nothing
            Finally
                pnlDisplay2.Controls.Clear()
            End Try
        End If
        If obj Is Nothing Then
            obj = umum.GetFormByName(e.Link.ItemName)    ')NBC.SelectedLink.ItemName)
            If Not obj Is Nothing Then
                AddHandler obj.Disposed, AddressOf FORM_DISPOSED
                If obj.Width > obj.Controls("pnl").Width Then
                    obj.Width = pnlDisplay2.Width
                End If
                If obj.Height > obj.Controls("pnl").Width Then
                    obj.Height = pnlDisplay2.Height
                End If
                ' obj.WindowState = FormWindowState.Maximized
                add_pnl(obj)
                set_pos_frm(obj)
                If obj.Controls("pnl").Dock = DockStyle.None Then
                    obj.BackgroundImage = pnlDisplay2.BackgroundImage
                    obj.BackgroundImageLayout = ImageLayout.Center
                End If
                obj.BackColor = Color.White

                pnlDisplay2.Controls.Add(obj)
                coll_form.Add(obj, obj.Name.ToString)
                obj.Text = sender.caption
                obj.Enabled = False
                centerMe()
                obj.Show()
                If coll_form.Count = 1 Then Panel7.Width = 176
            Else
                Try
                    Dim Typet As Type = Me.GetType()
                    Dim method As Reflection.MethodInfo = Me.GetType.GetMethod(NBC.SelectedLink.ItemName)
                    method.Invoke(Me, Nothing)
                    Dim a As Object = Nothing
                    If e Is Nothing Then Exit Sub
                    If e.Link.Group Is Nothing Then Exit Sub
                    If e.Link.Group.ItemLinks.Count = 1 Then
                        a = e.Link.Group

                    End If
                    e.Link.Dispose()
                    If Not a Is Nothing Then a.Dispose()
                Catch ex As Exception
                    MsgBox("Form or Procedure Name not found " + ex.Message, MsgBoxStyle.Critical)
                    Dim a As Object = Nothing
                    If e.Link.Group.ItemLinks.Count = 1 Then
                        a = e.Link.Group
                    End If
                    e.Link.Dispose()
                    If Not a Is Nothing Then a.Dispose()

                    If NBG.ItemLinks.Count > 0 Then
                        If NBG.ItemLinks.Count Then
                            NBC.SelectedLink = NBG.ItemLinks(0)
                            NBC_LinkClicked(NBC, New DevExpress.XtraNavBar.NavBarLinkEventArgs(NBC.SelectedLink))
                        End If
                    End If
                    Clock1.Running = True
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
            Try
                btnCetak.Enabled = objs.btnCetak
            Catch ex As Exception
            End Try
            centerMe()
        End If
        Clock1.Running = True

    End Sub
    Public Sub gantiPassword()
        frmGantiPassword.ShowDialog()

    End Sub
    Public Sub Logout()

        If MsgBox("Keluar Aplikasi SIKAP ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.No Then Exit Sub
        For i As Int16 = 1 To coll_form.Count
            coll_form(1).dispose()
        Next
        coll_form.Clear()
        logouts = True
        If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        Me.Dispose()
        frmBG.Show()

    End Sub
    Public Sub ExitForm()
        End
    End Sub
    Private Sub btnCloseApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseApp.Click
        If MsgBox("Tutup Aplikasi SISKOP ?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Tutup Aplikasi") = MsgBoxResult.Ok Then Me.Close()
    End Sub
    Private Sub cmdUnhook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnhook.Click
        Dim obj As Object
        If pnlDisplay2.Controls.Count = 0 Then Exit Sub
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
        'frm.state = "EDIT"
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
        frm.save_click()
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
    Public Sub centerMe(ByVal pnl As Object)
        pnl.visible = False
        pnl.left = (pnl.parent.width - pnl.width) / 2
        If pnl.Left < 0 Then pnl.left = 0
        pnl.top = 5 ' (pnl.parent.height - pnl.height) / 2
        pnl.visible = True
    End Sub
    Public Sub centerMe()
        If pnlDisplay2.Controls.Count > 0 Then
            If TypeOf pnlDisplay2.Controls(0) Is Form Then

                'pnlDisplay2.VerticalScroll.Visible = False
                'pnlDisplay2.HorizontalScroll.Visible = False
                If pnlDisplay2.Controls(0).Controls("pnl").Width < pnlDisplay2.Width Then
                    pnlDisplay2.Controls(0).Width = pnlDisplay2.Width
                    'pnlDisplay2.HorizontalScroll.Visible = False
                Else
                    pnlDisplay2.Controls(0).Width = pnlDisplay2.Controls(0).Controls("pnl").Width
                    'pnlDisplay2.HorizontalScroll.Visible = True
                End If
                If pnlDisplay2.Controls(0).Controls("pnl").Height < pnlDisplay2.Height Then
                    pnlDisplay2.Controls(0).Height = pnlDisplay2.Height
                    'pnlDisplay2.VerticalScroll.Visible = False
                Else
                    pnlDisplay2.Controls(0).Height = pnlDisplay2.Controls(0).Controls("pnl").Height
                    'pnlDisplay2.VerticalScroll.Visible = True
                End If
                If pnlDisplay2.Controls(0).Controls("pnl").Dock = DockStyle.None Then centerMe(pnlDisplay2.Controls(0).Controls("pnl"))
            End If
        End If
    End Sub
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If pnlDisplay2.Controls.Count > 0 Then
            Dim frm As Object
            frm = pnlDisplay2.Controls(0)
            frm.cetak_click()
        End If
    End Sub
    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        pnlInfo.Visible = False
    End Sub
    Public Sub setPrinter()
        frmpilihdefaultprinter.ShowDialog(Me)
    End Sub
    Private Sub pnlDisplay2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDisplay2.Resize
        If pnlDisplay2.Controls.Count > 0 Then
            Dim obj As Object = pnlDisplay2.Controls(0)
            resizeForm(obj)
        End If
    End Sub
    Public Sub change_background()
        OPD.ShowDialog()
        If OPD.FileName <> "" Then
            System.IO.File.Copy(OPD.FileName, App_Path() & "\bg.jpg", True)
            loadbg()

        End If
    End Sub
    Public Sub delete_background()
        If MsgBox("Hapus Background ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus") Then
            loadbg(True)

        End If
    End Sub
    Private Sub Clock1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Clock1.DoubleClick
        Shell("rundll32.exe shell32.dll,Control_RunDLL  timedate.cpl,,0")
    End Sub

    Private Sub split_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles Split.SplitterMoved
        If e.SplitX > 177 Then
            Panel7.Width = 177
        End If
    End Sub
    Public Sub showHideClock()
        alp.Visible = Not alp.Visible
    End Sub


End Class
