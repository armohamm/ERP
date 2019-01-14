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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnlRear = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlDisplay2 = New System.Windows.Forms.Panel
        Me.pnlInfo = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha11 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha12 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha13 = New BlueActivity.Controls.ColorWithAlpha
        Me.btnHide = New DevExpress.XtraEditors.SimpleButton
        Me.pnlControl = New DevExpress.XtraEditors.PanelControl
        Me.btnCetak = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUnhook = New DevExpress.XtraEditors.SimpleButton
        Me.pnlNav = New DevExpress.XtraEditors.PanelControl
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnCloseApp = New DevExpress.XtraEditors.SimpleButton
        Me.split = New DevExpress.XtraEditors.SplitterControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.alp = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha14 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha15 = New BlueActivity.Controls.ColorWithAlpha
        Me.Clock1 = New AnalogClock.Clock
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlAtas = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.lblJudul = New System.Windows.Forms.Label
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha9 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha10 = New BlueActivity.Controls.ColorWithAlpha
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        Me.OPD = New System.Windows.Forms.OpenFileDialog
        Me.Notif = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.NBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thePnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thePnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlRear.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControl.SuspendLayout()
        CType(Me.pnlNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNav.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.alp.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'NBC
        '
        Me.NBC.ActiveGroup = Me.NBG
        Me.NBC.AllowSelectedLink = True
        Me.NBC.Appearance.ItemActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NBC.Appearance.ItemActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NBC.Appearance.ItemActive.Options.UseBackColor = True
        Me.NBC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NBC.ContentButtonHint = Nothing
        Me.NBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NBC.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NBG})
        Me.NBC.Location = New System.Drawing.Point(0, 0)
        Me.NBC.LookAndFeel.SkinName = "The Asphalt World"
        Me.NBC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NBC.Name = "NBC"
        Me.NBC.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.NBC.OptionsNavPane.ExpandedWidth = 200
        Me.NBC.OptionsNavPane.ShowExpandButton = False
        Me.NBC.OptionsNavPane.ShowOverflowButton = False
        Me.NBC.OptionsNavPane.ShowOverflowPanel = False
        Me.NBC.OptionsNavPane.ShowSplitter = False
        Me.NBC.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.NBC.Size = New System.Drawing.Size(177, 197)
        Me.NBC.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
        Me.NBC.SmallImages = Me.img_small
        Me.NBC.TabIndex = 3
        Me.NBC.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("The Asphalt World")
        '
        'NBG
        '
        Me.NBG.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.NBG.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NBG.Appearance.Options.UseBackColor = True
        Me.NBG.Appearance.Options.UseFont = True
        Me.NBG.AppearanceBackground.BackColor = System.Drawing.Color.Transparent
        Me.NBG.AppearanceBackground.Options.UseBackColor = True
        Me.NBG.Caption = ""
        Me.NBG.Expanded = True
        Me.NBG.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small
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
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'mnMenu
        '
        Me.mnMenu.BackColor = System.Drawing.Color.Navy
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.Size = New System.Drawing.Size(988, 24)
        Me.mnMenu.TabIndex = 3
        Me.mnMenu.Text = "MenuStrip1"
        '
        'thePnl
        '
        Me.thePnl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.thePnl.Appearance.Options.UseBackColor = True
        Me.thePnl.Controls.Add(Me.Panel3)
        Me.thePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thePnl.Location = New System.Drawing.Point(0, 24)
        Me.thePnl.LookAndFeel.SkinName = "Black"
        Me.thePnl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.thePnl.Name = "thePnl"
        Me.thePnl.Size = New System.Drawing.Size(988, 393)
        Me.thePnl.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.pnlRear)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 389)
        Me.Panel3.TabIndex = 1
        '
        'pnlRear
        '
        Me.pnlRear.Controls.Add(Me.pnlMain)
        Me.pnlRear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRear.Location = New System.Drawing.Point(0, 34)
        Me.pnlRear.Name = "pnlRear"
        Me.pnlRear.Size = New System.Drawing.Size(984, 355)
        Me.pnlRear.TabIndex = 14
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Controls.Add(Me.pnlControl)
        Me.pnlMain.Controls.Add(Me.split)
        Me.pnlMain.Controls.Add(Me.Panel7)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(984, 355)
        Me.pnlMain.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pnlDisplay2)
        Me.Panel1.Controls.Add(Me.pnlInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(183, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 284)
        Me.Panel1.TabIndex = 13
        '
        'pnlDisplay2
        '
        Me.pnlDisplay2.AutoScroll = True
        Me.pnlDisplay2.AutoSize = True
        Me.pnlDisplay2.BackColor = System.Drawing.Color.Transparent
        Me.pnlDisplay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlDisplay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay2.Location = New System.Drawing.Point(0, 0)
        Me.pnlDisplay2.Name = "pnlDisplay2"
        Me.pnlDisplay2.Size = New System.Drawing.Size(801, 257)
        Me.pnlDisplay2.TabIndex = 4
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlInfo.Border = True
        Me.pnlInfo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha11)
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha12)
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha13)
        Me.pnlInfo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlInfo.Controls.Add(Me.btnHide)
        Me.pnlInfo.CornerRadius = 20
        Me.pnlInfo.Corners = BlueActivity.Controls.Corner.None
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfo.Gradient = True
        Me.pnlInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlInfo.GradientOffset = 1.0!
        Me.pnlInfo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlInfo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlInfo.Grayscale = False
        Me.pnlInfo.Image = Nothing
        Me.pnlInfo.ImageAlpha = 75
        Me.pnlInfo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlInfo.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlInfo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlInfo.Location = New System.Drawing.Point(0, 257)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Rounded = True
        Me.pnlInfo.Size = New System.Drawing.Size(801, 27)
        Me.pnlInfo.TabIndex = 12
        Me.pnlInfo.Visible = False
        '
        'ColorWithAlpha11
        '
        Me.ColorWithAlpha11.Alpha = 200
        Me.ColorWithAlpha11.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha11.Parent = Me.pnlInfo
        '
        'ColorWithAlpha12
        '
        Me.ColorWithAlpha12.Alpha = 255
        Me.ColorWithAlpha12.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha12.Parent = Me.pnlInfo
        '
        'ColorWithAlpha13
        '
        Me.ColorWithAlpha13.Alpha = 200
        Me.ColorWithAlpha13.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha13.Parent = Me.pnlInfo
        '
        'btnHide
        '
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(769, 0)
        Me.btnHide.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnHide.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 27)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Tag = "Hide"
        '
        'pnlControl
        '
        Me.pnlControl.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlControl.Appearance.Options.UseBackColor = True
        Me.pnlControl.Controls.Add(Me.btnCetak)
        Me.pnlControl.Controls.Add(Me.cmdUnhook)
        Me.pnlControl.Controls.Add(Me.pnlNav)
        Me.pnlControl.Controls.Add(Me.btnCloseApp)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControl.Location = New System.Drawing.Point(183, 284)
        Me.pnlControl.LookAndFeel.SkinName = "Black"
        Me.pnlControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnlControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(801, 71)
        Me.pnlControl.TabIndex = 11
        '
        'btnCetak
        '
        Me.btnCetak.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCetak.Appearance.Options.UseFont = True
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCetak.ImageIndex = 10
        Me.btnCetak.ImageList = Me.img
        Me.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCetak.Location = New System.Drawing.Point(633, 3)
        Me.btnCetak.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnCetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(55, 65)
        Me.btnCetak.TabIndex = 12
        Me.btnCetak.Text = "Cetak"
        '
        'cmdUnhook
        '
        Me.cmdUnhook.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdUnhook.Appearance.Options.UseFont = True
        Me.cmdUnhook.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdUnhook.ImageIndex = 11
        Me.cmdUnhook.ImageList = Me.img
        Me.cmdUnhook.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdUnhook.Location = New System.Drawing.Point(688, 3)
        Me.cmdUnhook.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdUnhook.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdUnhook.Name = "cmdUnhook"
        Me.cmdUnhook.Size = New System.Drawing.Size(55, 65)
        Me.cmdUnhook.TabIndex = 8
        Me.cmdUnhook.Text = "Release"
        Me.cmdUnhook.Visible = False
        '
        'pnlNav
        '
        Me.pnlNav.AutoSize = True
        Me.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlNav.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlNav.Controls.Add(Me.btnClose)
        Me.pnlNav.Controls.Add(Me.btnCancel)
        Me.pnlNav.Controls.Add(Me.btnDelete)
        Me.pnlNav.Controls.Add(Me.btnSave)
        Me.pnlNav.Controls.Add(Me.btnEdit)
        Me.pnlNav.Controls.Add(Me.btnAdd)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(3, 3)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(330, 65)
        Me.pnlNav.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.ImageIndex = 15
        Me.btnClose.ImageList = Me.img
        Me.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(275, 0)
        Me.btnClose.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnClose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(55, 65)
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
        Me.btnCancel.Location = New System.Drawing.Point(220, 0)
        Me.btnCancel.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 65)
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
        Me.btnDelete.Location = New System.Drawing.Point(165, 0)
        Me.btnDelete.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 65)
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
        Me.btnSave.Location = New System.Drawing.Point(110, 0)
        Me.btnSave.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 65)
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
        Me.btnEdit.Location = New System.Drawing.Point(55, 0)
        Me.btnEdit.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnEdit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(55, 65)
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
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 65)
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
        Me.btnCloseApp.Location = New System.Drawing.Point(743, 3)
        Me.btnCloseApp.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnCloseApp.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(55, 65)
        Me.btnCloseApp.TabIndex = 6
        Me.btnCloseApp.Text = "Keluar"
        '
        'split
        '
        Me.split.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.split.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.split.Appearance.Options.UseBackColor = True
        Me.split.Appearance.Options.UseBorderColor = True
        Me.split.Location = New System.Drawing.Point(177, 0)
        Me.split.LookAndFeel.SkinName = "Black"
        Me.split.LookAndFeel.UseDefaultLookAndFeel = False
        Me.split.Name = "split"
        Me.split.Size = New System.Drawing.Size(6, 355)
        Me.split.TabIndex = 11
        Me.split.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.NBC)
        Me.Panel7.Controls.Add(Me.alp)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(177, 355)
        Me.Panel7.TabIndex = 14
        '
        'alp
        '
        Me.alp.BackColor = System.Drawing.Color.Transparent
        Me.alp.Border = True
        Me.alp.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.alp.Colors.Add(Me.ColorWithAlpha14)
        Me.alp.Colors.Add(Me.ColorWithAlpha15)
        Me.alp.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.alp.Controls.Add(Me.Clock1)
        Me.alp.CornerRadius = 3
        Me.alp.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.alp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.alp.Gradient = True
        Me.alp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.alp.GradientOffset = 1.0!
        Me.alp.GradientSize = New System.Drawing.Size(0, 0)
        Me.alp.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.alp.Grayscale = False
        Me.alp.Image = CType(resources.GetObject("alp.Image"), System.Drawing.Image)
        Me.alp.ImageAlpha = 100
        Me.alp.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.alp.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.alp.ImageSize = New System.Drawing.Size(177, 158)
        Me.alp.Location = New System.Drawing.Point(0, 197)
        Me.alp.Name = "alp"
        Me.alp.Rounded = True
        Me.alp.Size = New System.Drawing.Size(177, 158)
        Me.alp.TabIndex = 13
        '
        'ColorWithAlpha14
        '
        Me.ColorWithAlpha14.Alpha = 255
        Me.ColorWithAlpha14.Color = System.Drawing.Color.White
        Me.ColorWithAlpha14.Parent = Me.alp
        '
        'ColorWithAlpha15
        '
        Me.ColorWithAlpha15.Alpha = 255
        Me.ColorWithAlpha15.Color = System.Drawing.Color.White
        Me.ColorWithAlpha15.Parent = Me.alp
        '
        'Clock1
        '
        Me.Clock1.BackColor = System.Drawing.Color.Transparent
        Me.Clock1.BackgroundImage = CType(resources.GetObject("Clock1.BackgroundImage"), System.Drawing.Image)
        Me.Clock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Clock1.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Triangle, True, 79.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, "")}
        Me.Clock1.CenterPoint.Color = System.Drawing.Color.Yellow
        Me.Clock1.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.CenterPoint.RelativeRadius = 0.06!
        Me.Clock1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Clock1.ForeColor = System.Drawing.Color.Black
        Me.Clock1.FrameColor = System.Drawing.Color.Peru
        Me.Clock1.HourHand.Color = System.Drawing.Color.Red
        Me.Clock1.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.HourHand.RelativeRadius = 0.65!
        Me.Clock1.HourHand.Style = AnalogClock.HandStyle.Pointed
        Me.Clock1.HourHand.Width = 8.0!
        Me.Clock1.Location = New System.Drawing.Point(10, 2)
        Me.Clock1.MinuteHand.Color = System.Drawing.Color.Teal
        Me.Clock1.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.MinuteHand.RelativeRadius = 0.8!
        Me.Clock1.MinuteHand.SmoothMode = AnalogClock.SmoothMode.HighSpeed
        Me.Clock1.MinuteHand.Style = AnalogClock.HandStyle.Pointed
        Me.Clock1.MinuteHand.Width = 6.0!
        Me.Clock1.Name = "Clock1"
        Me.Clock1.SecondHand.Color = System.Drawing.Color.WhiteSmoke
        Me.Clock1.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.SecondHand.RelativeRadius = 0.9!
        Me.Clock1.SecondHand.Style = AnalogClock.HandStyle.Pointed
        Me.Clock1.SecondHand.Width = 3.0!
        Me.Clock1.Size = New System.Drawing.Size(158, 158)
        Me.Clock1.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, False, 79.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, "")}
        Me.Clock1.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 0, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 1, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 2, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 3, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 4, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 5, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 6, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 7, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 8, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 9, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 10, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 11, False, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, "")}
        Me.Clock1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.pnlAtas)
        Me.Panel4.Controls.Add(Me.AlphaGradientPanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(984, 34)
        Me.Panel4.TabIndex = 13
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.White
        Me.pnlAtas.Border = True
        Me.pnlAtas.BorderColor = System.Drawing.Color.Goldenrod
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAtas.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.Controls.Add(Me.lblJudul)
        Me.pnlAtas.CornerRadius = 5
        Me.pnlAtas.Corners = BlueActivity.Controls.Corner.None
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAtas.Gradient = True
        Me.pnlAtas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlAtas.GradientOffset = 1.0!
        Me.pnlAtas.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAtas.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAtas.Grayscale = False
        Me.pnlAtas.Image = Nothing
        Me.pnlAtas.ImageAlpha = 255
        Me.pnlAtas.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.ImagePosition = BlueActivity.Controls.ImagePosition.TopLeft
        Me.pnlAtas.ImageSize = New System.Drawing.Size(700, 90)
        Me.pnlAtas.Location = New System.Drawing.Point(182, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Rounded = True
        Me.pnlAtas.Size = New System.Drawing.Size(800, 32)
        Me.pnlAtas.TabIndex = 13
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 125
        Me.ColorWithAlpha7.Color = System.Drawing.SystemColors.ActiveBorder
        Me.ColorWithAlpha7.Parent = Me.pnlAtas
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 175
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Me.pnlAtas
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 125
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ActiveBorder
        Me.ColorWithAlpha2.Parent = Me.pnlAtas
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Black
        Me.lblJudul.Location = New System.Drawing.Point(0, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(618, 32)
        Me.lblJudul.TabIndex = 13
        Me.lblJudul.Text = "  KOPERASI KARYAWAN BANK BCA"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha8)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha9)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha10)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.Panel6)
        Me.AlphaGradientPanel1.Controls.Add(Me.Panel2)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = BlueActivity.Controls.Corner.None
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight), BlueActivity.Controls.ImagePosition)
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(32, 32)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(182, 32)
        Me.AlphaGradientPanel1.TabIndex = 12
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.IndianRed
        Me.ColorWithAlpha8.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 255
        Me.ColorWithAlpha9.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha9.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha10
        '
        Me.ColorWithAlpha10.Alpha = 255
        Me.ColorWithAlpha10.Color = System.Drawing.Color.Firebrick
        Me.ColorWithAlpha10.Parent = Me.AlphaGradientPanel1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblUser)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(32, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(150, 32)
        Me.Panel6.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(0, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(150, 16)
        Me.lblUser.TabIndex = 4
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selamat Datang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 32)
        Me.Panel2.TabIndex = 0
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
        'OPD
        '
        Me.OPD.Filter = "JPG FILES|*.jpg|BMP FILES|*.bmp|PNG FILES|*.png"
        '
        'Notif
        '
        Me.Notif.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Notif.BalloonTipTitle = "New Notif Available"
        Me.Notif.Icon = CType(resources.GetObject("Notif.Icon"), System.Drawing.Icon)
        Me.Notif.Text = "Notif"
        Me.Notif.Visible = True
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIKAP MAIN WINDOW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thePnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thePnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlRear.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        CType(Me.pnlNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNav.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.alp.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnlDisplay2 As System.Windows.Forms.Panel
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents btnCetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha9 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha10 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents split As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents pnlRear As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColorWithAlpha11 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha12 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha13 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents btnHide As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents OPD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents alp As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha14 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha15 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Notif As System.Windows.Forms.NotifyIcon

End Class
