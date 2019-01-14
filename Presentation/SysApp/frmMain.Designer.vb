<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NBC = New DevExpress.XtraNavBar.NavBarControl
        Me.NBG = New DevExpress.XtraNavBar.NavBarGroup
        Me.img_small = New System.Windows.Forms.ImageList(Me.components)
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.mnMenu = New System.Windows.Forms.MenuStrip
        Me.thePnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlDisplay2 = New System.Windows.Forms.Panel
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlAtas = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlControl = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUnhook = New DevExpress.XtraEditors.SimpleButton
        Me.pnlNav = New DevExpress.XtraEditors.PanelControl
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnCloseApp = New DevExpress.XtraEditors.SimpleButton
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblToday = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.JAM = New SriClocks.DigitalClockCtrl
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        CType(Me.NBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thePnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thePnl.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControl.SuspendLayout()
        CType(Me.pnlNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNav.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'NBC
        '
        Me.NBC.ActiveGroup = Me.NBG
        Me.NBC.AllowSelectedLink = True
        Me.NBC.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NBC.Appearance.Background.Options.UseBackColor = True
        Me.NBC.BackColor = System.Drawing.Color.Yellow
        Me.NBC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NBC.ContentButtonHint = Nothing
        Me.NBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NBC.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NBG})
        Me.NBC.Location = New System.Drawing.Point(0, 47)
        Me.NBC.LookAndFeel.SkinName = "The Asphalt World"
        Me.NBC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NBC.Name = "NBC"
        Me.NBC.OptionsNavPane.ExpandedWidth = 200
        Me.NBC.OptionsNavPane.ShowExpandButton = False
        Me.NBC.OptionsNavPane.ShowOverflowButton = False
        Me.NBC.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar
        Me.NBC.Size = New System.Drawing.Size(162, 281)
        Me.NBC.SmallImages = Me.img_small
        Me.NBC.TabIndex = 3
        Me.NBC.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Black")
        '
        'NBG
        '
        Me.NBG.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NBG.Appearance.Options.UseBackColor = True
        Me.NBG.AppearanceBackground.BackColor = System.Drawing.Color.Transparent
        Me.NBG.AppearanceBackground.Options.UseBackColor = True
        Me.NBG.Caption = "Daftar Form"
        Me.NBG.Expanded = True
        Me.NBG.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
        Me.NBG.Name = "NBG"
        '
        'img_small
        '
        Me.img_small.ImageStream = CType(resources.GetObject("img_small.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_small.TransparentColor = System.Drawing.Color.Transparent
        Me.img_small.Images.SetKeyName(0, "")
        Me.img_small.Images.SetKeyName(1, "")
        Me.img_small.Images.SetKeyName(2, "")
        Me.img_small.Images.SetKeyName(3, "")
        Me.img_small.Images.SetKeyName(4, "")
        Me.img_small.Images.SetKeyName(5, "")
        Me.img_small.Images.SetKeyName(6, "")
        Me.img_small.Images.SetKeyName(7, "")
        Me.img_small.Images.SetKeyName(8, "")
        Me.img_small.Images.SetKeyName(9, "")
        Me.img_small.Images.SetKeyName(10, "")
        Me.img_small.Images.SetKeyName(11, "")
        Me.img_small.Images.SetKeyName(12, "")
        Me.img_small.Images.SetKeyName(13, "")
        Me.img_small.Images.SetKeyName(14, "")
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        '
        'mnMenu
        '
        Me.mnMenu.BackColor = System.Drawing.Color.Maroon
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnMenu.Size = New System.Drawing.Size(988, 24)
        Me.mnMenu.TabIndex = 3
        Me.mnMenu.Text = "MenuStrip1"
        '
        'thePnl
        '
        Me.thePnl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.thePnl.Appearance.Options.UseBackColor = True
        Me.thePnl.Controls.Add(Me.pnlMain)
        Me.thePnl.Controls.Add(Me.pnlControl)
        Me.thePnl.Controls.Add(Me.SplitterControl1)
        Me.thePnl.Controls.Add(Me.Panel3)
        Me.thePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thePnl.Location = New System.Drawing.Point(0, 24)
        Me.thePnl.LookAndFeel.SkinName = "Black"
        Me.thePnl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.thePnl.Name = "thePnl"
        Me.thePnl.Size = New System.Drawing.Size(988, 393)
        Me.thePnl.TabIndex = 6
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.pnlDisplay2)
        Me.pnlMain.Controls.Add(Me.SplitterControl2)
        Me.pnlMain.Controls.Add(Me.Panel2)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(170, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(816, 324)
        Me.pnlMain.TabIndex = 12
        '
        'pnlDisplay2
        '
        Me.pnlDisplay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay2.Location = New System.Drawing.Point(0, 53)
        Me.pnlDisplay2.Name = "pnlDisplay2"
        Me.pnlDisplay2.Size = New System.Drawing.Size(816, 271)
        Me.pnlDisplay2.TabIndex = 4
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.SplitterControl2.Appearance.Options.UseBackColor = True
        Me.SplitterControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl2.Enabled = False
        Me.SplitterControl2.Location = New System.Drawing.Point(0, 47)
        Me.SplitterControl2.LookAndFeel.SkinName = "Black"
        Me.SplitterControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(816, 6)
        Me.SplitterControl2.TabIndex = 5
        Me.SplitterControl2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.pnlAtas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(816, 47)
        Me.Panel2.TabIndex = 3
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Transparent
        Me.pnlAtas.Border = False
        Me.pnlAtas.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAtas.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.Controls.Add(Me.PictureBox2)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.CornerRadius = 5
        Me.pnlAtas.Corners = BlueActivity.Controls.Corner.None
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAtas.Gradient = True
        Me.pnlAtas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlAtas.GradientOffset = 1.0!
        Me.pnlAtas.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAtas.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAtas.Grayscale = False
        Me.pnlAtas.Image = Nothing
        Me.pnlAtas.ImageAlpha = 255
        Me.pnlAtas.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.ImagePosition = BlueActivity.Controls.ImagePosition.TopLeft
        Me.pnlAtas.ImageSize = New System.Drawing.Size(700, 90)
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Rounded = True
        Me.pnlAtas.Size = New System.Drawing.Size(816, 47)
        Me.pnlAtas.TabIndex = 10
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Me.pnlAtas
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ButtonFace
        Me.ColorWithAlpha2.Parent = Me.pnlAtas
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(284, 47)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(682, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 47)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'pnlControl
        '
        Me.pnlControl.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pnlControl.Appearance.Options.UseBackColor = True
        Me.pnlControl.Controls.Add(Me.SimpleButton1)
        Me.pnlControl.Controls.Add(Me.cmdUnhook)
        Me.pnlControl.Controls.Add(Me.pnlNav)
        Me.pnlControl.Controls.Add(Me.btnCloseApp)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControl.Location = New System.Drawing.Point(170, 326)
        Me.pnlControl.LookAndFeel.SkinName = "Black"
        Me.pnlControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(816, 65)
        Me.pnlControl.TabIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(368, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 41)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'cmdUnhook
        '
        Me.cmdUnhook.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdUnhook.Appearance.Options.UseFont = True
        Me.cmdUnhook.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdUnhook.ImageIndex = 11
        Me.cmdUnhook.ImageList = Me.img
        Me.cmdUnhook.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdUnhook.Location = New System.Drawing.Point(702, 2)
        Me.cmdUnhook.LookAndFeel.SkinName = "Black"
        Me.cmdUnhook.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdUnhook.Name = "cmdUnhook"
        Me.cmdUnhook.Size = New System.Drawing.Size(56, 61)
        Me.cmdUnhook.TabIndex = 8
        Me.cmdUnhook.Text = "Release"
        '
        'pnlNav
        '
        Me.pnlNav.AutoSize = True
        Me.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlNav.Controls.Add(Me.btnClose)
        Me.pnlNav.Controls.Add(Me.btnCancel)
        Me.pnlNav.Controls.Add(Me.btnDelete)
        Me.pnlNav.Controls.Add(Me.btnSave)
        Me.pnlNav.Controls.Add(Me.btnEdit)
        Me.pnlNav.Controls.Add(Me.btnAdd)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(2, 2)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(340, 61)
        Me.pnlNav.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.ImageIndex = 9
        Me.btnClose.ImageList = Me.img
        Me.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(282, 2)
        Me.btnClose.LookAndFeel.SkinName = "Black"
        Me.btnClose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 57)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Tutup"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImageIndex = 8
        Me.btnCancel.ImageList = Me.img
        Me.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(226, 2)
        Me.btnCancel.LookAndFeel.SkinName = "Black"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 57)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Batal"
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageIndex = 0
        Me.btnDelete.ImageList = Me.img
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(170, 2)
        Me.btnDelete.LookAndFeel.SkinName = "Black"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 57)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Hapus"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Enabled = False
        Me.btnSave.ImageIndex = 4
        Me.btnSave.ImageList = Me.img
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(114, 2)
        Me.btnSave.LookAndFeel.SkinName = "Black"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 57)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Simpan"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.Enabled = False
        Me.btnEdit.ImageIndex = 2
        Me.btnEdit.ImageList = Me.img
        Me.btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(58, 2)
        Me.btnEdit.LookAndFeel.SkinName = "Black"
        Me.btnEdit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 57)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Enabled = False
        Me.btnAdd.ImageIndex = 1
        Me.btnAdd.ImageList = Me.img
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(2, 2)
        Me.btnAdd.LookAndFeel.SkinName = "Black"
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 57)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Baru"
        '
        'btnCloseApp
        '
        Me.btnCloseApp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCloseApp.Appearance.Options.UseFont = True
        Me.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCloseApp.ImageIndex = 7
        Me.btnCloseApp.ImageList = Me.img
        Me.btnCloseApp.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCloseApp.Location = New System.Drawing.Point(758, 2)
        Me.btnCloseApp.LookAndFeel.SkinName = "Black"
        Me.btnCloseApp.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(56, 61)
        Me.btnCloseApp.TabIndex = 6
        Me.btnCloseApp.Text = "Keluar"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.SplitterControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SplitterControl1.Appearance.Options.UseBackColor = True
        Me.SplitterControl1.Appearance.Options.UseBorderColor = True
        Me.SplitterControl1.Location = New System.Drawing.Point(164, 2)
        Me.SplitterControl1.LookAndFeel.SkinName = "Black"
        Me.SplitterControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 389)
        Me.SplitterControl1.TabIndex = 10
        Me.SplitterControl1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.NBC)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(162, 389)
        Me.Panel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblToday)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 47)
        Me.Panel1.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblUser.Location = New System.Drawing.Point(0, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(162, 31)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Administrator"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.ForeColor = System.Drawing.Color.Gold
        Me.lblToday.Location = New System.Drawing.Point(6, 71)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(98, 16)
        Me.lblToday.TabIndex = 5
        Me.lblToday.Text = "Administrator"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.JAM)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 328)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(162, 61)
        Me.Panel5.TabIndex = 11
        '
        'JAM
        '
        Me.JAM.BackColor = System.Drawing.Color.Black
        Me.JAM.CountDownTime = 10000
        Me.JAM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JAM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.JAM.Location = New System.Drawing.Point(0, 0)
        Me.JAM.Name = "JAM"
        Me.JAM.SetClockType = SriClocks.ClockType.DigitalClock
        Me.JAM.Size = New System.Drawing.Size(162, 61)
        Me.JAM.TabIndex = 0
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.SystemColors.ActiveCaption
        Me.ColorWithAlpha5.Parent = Nothing
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha6.Parent = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 417)
        Me.Controls.Add(Me.thePnl)
        Me.Controls.Add(Me.mnMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thePnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thePnl.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        CType(Me.pnlNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNav.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents NBC As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NBG As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents mnMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents img_small As System.Windows.Forms.ImageList
    Friend WithEvents thePnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnlControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdUnhook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlNav As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCloseApp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents JAM As SriClocks.DigitalClockCtrl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnlDisplay2 As System.Windows.Forms.Panel
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl

End Class
