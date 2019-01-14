Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Module umum
    Public sqlconn As New SqlConnection
    Public username As String
    Public namauser As String
    Public kdcabang As String
    Public userRole As String
    Dim DAdb As SqlDataAdapter
    Dim dset As New DataSet
    Public coll_form As New Collection
    Public imgCol As New ImageList
    Public imgColBig As New ImageList
    Private begintrans As Boolean
    Dim sqlTran As SqlTransaction

    Public Function getParent(ByVal frm As Form) As frmMain
        Dim obj As Object
        obj = frm.Parent
        While Not TypeOf obj Is Form
            obj = obj.Parent
        End While

        Return obj
    End Function

    Public Function ISNULL(ByRef OBJ As Object, ByVal VAL As String) As Object
        If OBJ = "" Then
            Return VAL
        Else
            Return OBJ

        End If
    End Function
    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function
    Public Sub showMessages(ByVal msg As String, Optional ByVal fontsize As Single = 16)
        frmMessage.lblMsg.Text = msg
        frmMessage.lblMsg.Font = New Font(frmMessage.lblMsg.Font.FontFamily, fontsize, FontStyle.Italic)
        frmMessage.ShowDialog()
    End Sub

    Public Sub collect_image()
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(App_Path() & "\icons")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.ico")
        Dim fi As IO.FileInfo
        imgCol.ColorDepth = ColorDepth.Depth16Bit
        Dim i As Int16 = 0

        For Each fi In aryFi
            Try
                If fi.Extension = "ico" Then
                    imgCol.Images.Add(i, New Icon(fi.FullName))
                    imgColBig.Images.Add(i, New Icon(fi.FullName))
                Else
                    imgCol.Images.Add(i, Image.FromFile(fi.FullName))
                    imgColBig.Images.Add(i, Image.FromFile(fi.FullName))
                End If
                i += 1
            Catch ex As Exception

            End Try
        Next
        imgCol.ImageSize = New Size(16, 16)
        imgColBig.ImageSize = New Size(32, 32)
    End Sub

    Public Sub connect()
        Dim inicls As New INICLASS()
        Dim inifile As String = App_Path() & "\ConString.ini"
        If Not sqlconn.State = ConnectionState.Open Then
            sqlconn.ConnectionString = inicls.INIRead(inifile, "CSQL", "SIF")
            If Not sqlconn.State = ConnectionState.Open Then
                Try
                    sqlconn.Open()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Connection")
                    End
                End Try
            End If
        End If
    End Sub

    Public Sub begin_trans()
        If Not begintrans Then
            sqlTran = sqlconn.BeginTransaction()
            begintrans = True
        End If
    End Sub

    Public Sub commit_Trans()
        If begintrans Then
            sqlTran.Commit()
            begintrans = False
        End If
    End Sub

    Public Sub rollback_trans()
        If begintrans Then
            sqlTran.Rollback()
            begintrans = False
        End If
    End Sub
    Public Sub createMenu(Optional ByVal Parent As String = vbNullString, Optional ByVal prnMenu As Object = vbNull)
        Dim menux As ToolStripMenuItem
        Dim dsete As New DataSet
        Dim dadbe As SqlClient.SqlDataAdapter
        Dim i As Int16 = 0
        Dim j As Int16 = 0
        If umum.username = "admin" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.menu where parent_menu ='" & Parent & "'  order by urutan", sqlconn))
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.menu where parent_menu ='" & Parent & "' and nm_menu in (select kode_menu from sif.dbo.role_menu where idrole='" & umum.userRole & "' and VALUE <> 0) order by urutan", sqlconn))
        End If

        dadbe.Fill(dsete, "menu")
        For i = 0 To dsete.Tables(0).Rows.Count - 1
            j = IIf(dsete.Tables(0).Rows(i).Item("img") = vbNull, 0, dsete.Tables(0).Rows(i).Item("img"))
            menux = New ToolStripMenuItem("", imgCol.Images.Item(j), AddressOf umum.menu_click)
            menux.Text = dsete.Tables(0).Rows(i).Item("caption").ToString
            menux.Name = dsete.Tables(0).Rows(i).Item("nm_menu").ToString
            If TypeOf prnMenu Is MenuStrip Then
                menux.ForeColor = Color.WhiteSmoke
                menux.Owner = prnMenu
                menux.Tag = "Header"
            Else
                prnMenu.DropDownItems.Add(menux)
                menux.Tag = dsete.Tables(0).Rows(i).Item("call_form").ToString
            End If
            createMenu(menux.Name, menux)
        Next i

        If i > 0 Then
            prnMenu.Tag = "Header"
        End If

        dadbe.Dispose()
        dsete.Dispose()
    End Sub
    Public Sub menu_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nbil As DevExpress.XtraNavBar.NavBarItem
        Dim i As Integer
        Dim obj As Object
        Dim exists As Boolean = False

        If sender.tag.ToString <> "Header" Then
            For i = 0 To frmMain.NBG.ItemLinks.Count - 1
                If frmMain.NBG.ItemLinks(i).ItemName = sender.tag.ToString Then
                    exists = True
                    Exit For
                End If
            Next

            If exists Then
                frmMain.NBC.SelectedLink = frmMain.NBG.ItemLinks(i)
                frmMain.NBC_LinkClicked(frmMain.NBC.SelectedLink, New DevExpress.XtraNavBar.NavBarLinkEventArgs(frmMain.NBG.ItemLinks(i)))
            Else
                nbil = frmMain.NBC.Items.Add
                nbil.Caption = sender.text
                nbil.Name = sender.tag.ToString
                nbil.SmallImage = sender.image
                obj = frmMain.NBG.ItemLinks.Add(nbil)
                Call frmMain.NBC_LinkClicked(nbil, New DevExpress.XtraNavBar.NavBarLinkEventArgs(obj))
            End If
        End If
    End Sub
    Public Function GetFormByName(ByVal formName As String) As Object
        Dim myasm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Try
            Return myasm.CreateInstance(myasm.GetName.Name.Replace(" ", "_") & "." & formName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub add_pnl(ByVal frm As Form)
        Dim pnl As New DevExpress.XtraEditors.PanelControl
        Dim btn As New DevExpress.XtraEditors.SimpleButton
        pnl.Dock = DockStyle.Bottom
        pnl.Parent = frm
        AddHandler btn.Click, AddressOf HOOKED_ME
        pnl.Size = New Size(0, 40)
        btn.Size = New Size(65, 35)
        pnl.Visible = False
        btn.Visible = True
        btn.Text = "Tautkan"

        pnl.BackColor = Color.Azure
        btn.Parent = pnl
        pnl.Name = "pnlHook"
        btn.Dock = DockStyle.Right

    End Sub
    Public Sub frm_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Parent Is Nothing Then
            sender.controls("pnlHook").Visible = True
        Else
            sender.controls("pnlHook").Visible = False
        End If
    End Sub
    Public Sub HOOKED_ME(ByVal sender As Object, ByVal e As System.EventArgs) 'ByVal FRM As Object)
        Dim NBIL As Object
        Dim OBJ As Object
        Dim frm As Object

        OBJ = sender.parent

        While Not TypeOf OBJ Is Form
            OBJ = OBJ.parent
        End While
        frm = OBJ
        AddHandler DirectCast(frm, Form).Disposed, AddressOf frmMain.FORM_DISPOSED
        AddHandler DirectCast(frm, Form).ParentChanged, AddressOf frm_ParentChanged

        frmMain.FORM_DISPOSED(frm, New System.EventArgs)
        coll_form.Add(frm, frm.NAME)
        set_pos_frm(frm)
        frmMain.pnlDisplay2.Controls.Add(frm)

        frm.Show()
        NBIL = frmMain.NBC.Items.Add
        NBIL.Caption = frm.TEXT
        NBIL.Name = frm.NAME
        'NBIL.SmallImage = FRM.icon
        OBJ = frmMain.NBG.ItemLinks.Add(NBIL)
        Call frmMain.NBC_LinkClicked(NBIL, New DevExpress.XtraNavBar.NavBarLinkEventArgs(OBJ))

    End Sub
    Public Sub set_pos_frm(ByVal frm As Form)
        frm.TopLevel = False
        frm.Left = 0
        frm.Top = 0
        frm.FormBorderStyle = 0
        'centerMe(frmSO)

        frm.Width = frmMain.pnlDisplay2.Width
        If frm.Height < frmMain.pnlDisplay2.Height Then
            frm.Height = frmMain.pnlDisplay2.Height
        End If
        frm.Controls("pnlHook").Visible = False
    End Sub
    Public Sub FillSales(ByRef sales As DevExpress.XtraEditors.LookUpEdit)
        Dim dsete As New DataSet
        Dim dadbe As SqlClient.SqlDataAdapter
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_sales as Kode, Nama from msalesman", sqlconn))

        dadbe.Fill(dsete, "MSALESMAN")
        sales.Properties.DataSource = dsete.Tables("MSALESMAN")

        sales.Properties.ValueMember = "Kode"
        sales.Properties.DisplayMember = "Nama"
        dsete.Dispose()
        dadbe.Dispose()
    End Sub
    Public Sub fade_out(ByVal frm As Form)
        Dim iCount As Integer
        frm.Opacity = 0.99
        For iCount = 90 To 10 Step -10
            frm.Opacity = iCount / 100
            frm.Refresh()
            Threading.Thread.Sleep(50)
        Next

        frm.Close()

    End Sub

    Public Sub fade_in(ByVal frm As Form)
        Dim iCount As Integer
        Dim i As Integer = 5
        While iCount < 100
            frm.Opacity = iCount / 100
            frm.Refresh()
            iCount = iCount + i
            i = i + 2
        End While

        '        For iCount = 10 To 90 Step i
        ' frm.Opacity = iCount / 100
        ' frm.Refresh()
        'Threading.Thread.Sleep(10)
        'i = i + 50
        'Next
        frm.Opacity = 0.99
    End Sub
    Public Sub default_add(ByRef prn As frmMain)
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
        End With
    End Sub
    Public Sub default_cancel(ByRef prn As frmMain)
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = True ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = True
            .btnSave.Enabled = False
        End With
    End Sub
    Public Sub Fade(ByRef picBox As PictureBox, ByVal Interval As Double)
        'Interval in seconds
        If Interval <= 0 Then Exit Sub

        Dim [then] As Double = DateAndTime.Timer
        Dim PercentRemaining As Double = 0

        'Keep fading the image while there's still time
        Do While PercentRemaining < 1

            FadeBitmap(picBox.BackgroundImage, 255 - (255 * PercentRemaining))

            'redraw the picBox so it shows the new faded image
            picBox.Invalidate()
            picBox.Update()

            'Calculate the % of time remaining
            PercentRemaining = (DateAndTime.Timer - [then]) / Interval
        Loop
        FadeBitmap(picBox.BackgroundImage, 0)
    End Sub
    Public Sub FadeBitmap(ByRef BitmapToFade As Bitmap, ByRef Alpha As Double)
        If Alpha > 255 Then Alpha = 255
        If Alpha < 0 Then Alpha = 0

        Dim bmpData As System.Drawing.Imaging.BitmapData = _
            BitmapToFade.LockBits(New Rectangle(Point.Empty, BitmapToFade.Size), _
                                  Drawing.Imaging.ImageLockMode.ReadWrite, _
                                  BitmapToFade.PixelFormat)
        Dim ptr As IntPtr = bmpData.Scan0
        Dim Bytes(bmpData.Stride * BitmapToFade.Height - 1) As Byte

        System.Runtime.InteropServices.Marshal.Copy(ptr, Bytes, 0, Bytes.Length)

        For i = 3 To UBound(Bytes) Step 4
            Bytes(i) = Alpha
        Next

        System.Runtime.InteropServices.Marshal.Copy(Bytes, 0, ptr, Bytes.Length)

        BitmapToFade.UnlockBits(bmpData)
        bmpData = Nothing
        Bytes = Nothing
        ptr = IntPtr.Zero
    End Sub

End Module
