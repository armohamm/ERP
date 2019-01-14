<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenanceMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceMenu))
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.TREE = New DevExpress.XtraTreeList.TreeList
        Me.imgl = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.pnlAtas = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdCollapseAll = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExpandAll = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmdAddParent = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtas.SuspendLayout()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(731, 21)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(93, 27)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load Menu"
        Me.btnLoad.Visible = False
        '
        'TREE
        '
        Me.TREE.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.TREE.Appearance.Empty.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.TREE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.TREE.Appearance.EvenRow.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.Options.UseForeColor = True
        Me.TREE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TREE.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TREE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TREE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TREE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TREE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupButton.Options.UseBackColor = True
        Me.TREE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupButton.Options.UseForeColor = True
        Me.TREE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TREE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TREE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseFont = True
        Me.TREE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TREE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.TREE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TREE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TREE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TREE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HorzLine.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TREE.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.TREE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.TREE.Appearance.OddRow.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.Options.UseForeColor = True
        Me.TREE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TREE.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.TREE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TREE.Appearance.Preview.Options.UseBackColor = True
        Me.TREE.Appearance.Preview.Options.UseForeColor = True
        Me.TREE.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.Row.Options.UseBackColor = True
        Me.TREE.Appearance.Row.Options.UseForeColor = True
        Me.TREE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.TREE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TREE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TREE.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TREE.Appearance.TreeLine.Options.UseBackColor = True
        Me.TREE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.VertLine.Options.UseBackColor = True
        Me.TREE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TREE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TREE.ImageIndexFieldName = ""
        Me.TREE.Location = New System.Drawing.Point(0, 0)
        Me.TREE.LookAndFeel.SkinName = "Black"
        Me.TREE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TREE.Name = "TREE"
        Me.TREE.OptionsBehavior.AutoFocusNewNode = True
        Me.TREE.OptionsBehavior.AutoMoveRowFocus = True
        Me.TREE.OptionsBehavior.EnterMovesNextColumn = True
        Me.TREE.OptionsBehavior.ResizeNodes = False
        Me.TREE.OptionsBehavior.UseTabKey = True
        Me.TREE.OptionsLayout.AddNewColumns = False
        Me.TREE.OptionsView.AutoCalcPreviewLineCount = True
        Me.TREE.OptionsView.AutoWidth = False
        Me.TREE.OptionsView.EnableAppearanceEvenRow = True
        Me.TREE.OptionsView.EnableAppearanceOddRow = True
        Me.TREE.RootValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TREE.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
        Me.TREE.Size = New System.Drawing.Size(695, 147)
        Me.TREE.StateImageList = Me.imgl
        Me.TREE.TabIndex = 6
        Me.TREE.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark
        '
        'imgl
        '
        Me.imgl.ImageStream = CType(resources.GetObject("imgl.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgl.TransparentColor = System.Drawing.Color.Transparent
        Me.imgl.Images.SetKeyName(0, "back.ico")
        Me.imgl.Images.SetKeyName(1, "down.ico")
        Me.imgl.Images.SetKeyName(2, "forward.ico")
        Me.imgl.Images.SetKeyName(3, "up.ico")
        Me.imgl.Images.SetKeyName(4, "insert.ico")
        Me.imgl.Images.SetKeyName(5, "ok.ico")
        Me.imgl.Images.SetKeyName(6, "error.ico")
        Me.imgl.Images.SetKeyName(7, "clean.ico")
        Me.imgl.Images.SetKeyName(8, "a_flux_diagram_256.png")
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAdd.ImageIndex = 4
        Me.cmdAdd.ImageList = Me.imgl
        Me.cmdAdd.Location = New System.Drawing.Point(339, 0)
        Me.cmdAdd.LookAndFeel.SkinName = "Black"
        Me.cmdAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 30)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add Child"
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Me.pnlAtas
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Transparent
        Me.pnlAtas.Border = True
        Me.pnlAtas.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlAtas.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.Controls.Add(Me.LabelControl3)
        Me.pnlAtas.CornerRadius = 5
        Me.pnlAtas.Corners = CType((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight), BlueActivity.Controls.Corner)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Gradient = True
        Me.pnlAtas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlAtas.GradientOffset = 1.0!
        Me.pnlAtas.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAtas.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAtas.Grayscale = False
        Me.pnlAtas.Image = Nothing
        Me.pnlAtas.ImageAlpha = 255
        Me.pnlAtas.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlAtas.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight), BlueActivity.Controls.ImagePosition)
        Me.pnlAtas.ImageSize = New System.Drawing.Size(30, 30)
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Rounded = True
        Me.pnlAtas.Size = New System.Drawing.Size(695, 35)
        Me.pnlAtas.TabIndex = 9
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha2.Parent = Me.pnlAtas
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Me.pnlAtas
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.LabelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.Appearance.ImageIndex = 2
        Me.LabelControl3.Appearance.ImageList = Me.img
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl3.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(210, 35)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "MAINTENANCE MENU"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "a_flux_diagram_256.png")
        Me.img.Images.SetKeyName(1, "c_flux_diagram_256.png")
        Me.img.Images.SetKeyName(2, "c_operator_256.png")
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 150
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha5.Parent = Nothing
        '
        'cmdCancel
        '
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdCancel.ImageIndex = 7
        Me.cmdCancel.ImageList = Me.imgl
        Me.cmdCancel.Location = New System.Drawing.Point(605, 0)
        Me.cmdCancel.LookAndFeel.SkinName = "Black"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 30)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        '
        'pnl
        '
        Me.pnl.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.pnl.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.pnl.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.pnl.Appearance.Options.UseBackColor = True
        Me.pnl.Appearance.Options.UseBorderColor = True
        Me.pnl.Appearance.Options.UseForeColor = True
        Me.pnl.Appearance.Options.UseImage = True
        Me.pnl.Controls.Add(Me.PanelControl1)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(699, 251)
        Me.pnl.TabIndex = 16
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(695, 247)
        Me.PanelControl1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 182)
        Me.Panel1.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TREE)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(695, 147)
        Me.Panel4.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.cmdCollapseAll)
        Me.Panel3.Controls.Add(Me.cmdExpandAll)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(695, 35)
        Me.Panel3.TabIndex = 4
        '
        'cmdCollapseAll
        '
        Me.cmdCollapseAll.Image = CType(resources.GetObject("cmdCollapseAll.Image"), System.Drawing.Image)
        Me.cmdCollapseAll.Location = New System.Drawing.Point(257, 2)
        Me.cmdCollapseAll.LookAndFeel.SkinName = "Black"
        Me.cmdCollapseAll.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCollapseAll.Name = "cmdCollapseAll"
        Me.cmdCollapseAll.Size = New System.Drawing.Size(86, 30)
        Me.cmdCollapseAll.TabIndex = 1
        Me.cmdCollapseAll.Text = "Collapse All"
        '
        'cmdExpandAll
        '
        Me.cmdExpandAll.Image = CType(resources.GetObject("cmdExpandAll.Image"), System.Drawing.Image)
        Me.cmdExpandAll.Location = New System.Drawing.Point(349, 3)
        Me.cmdExpandAll.LookAndFeel.SkinName = "Black"
        Me.cmdExpandAll.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExpandAll.Name = "cmdExpandAll"
        Me.cmdExpandAll.Size = New System.Drawing.Size(86, 29)
        Me.cmdExpandAll.TabIndex = 0
        Me.cmdExpandAll.Text = "Expand All"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.pnlAtas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 65)
        Me.Panel2.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Controls.Add(Me.cmdAdd)
        Me.Panel6.Controls.Add(Me.cmdAddParent)
        Me.Panel6.Controls.Add(Me.cmdDelete)
        Me.Panel6.Controls.Add(Me.cmdCancel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 35)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(695, 30)
        Me.Panel6.TabIndex = 25
        '
        'cmdAddParent
        '
        Me.cmdAddParent.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAddParent.ImageIndex = 4
        Me.cmdAddParent.ImageList = Me.imgl
        Me.cmdAddParent.Location = New System.Drawing.Point(427, 0)
        Me.cmdAddParent.LookAndFeel.SkinName = "Black"
        Me.cmdAddParent.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAddParent.Name = "cmdAddParent"
        Me.cmdAddParent.Size = New System.Drawing.Size(88, 30)
        Me.cmdAddParent.TabIndex = 5
        Me.cmdAddParent.Text = "Add Root"
        '
        'cmdDelete
        '
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdDelete.ImageIndex = 6
        Me.cmdDelete.ImageList = Me.imgl
        Me.cmdDelete.Location = New System.Drawing.Point(515, 0)
        Me.cmdDelete.LookAndFeel.SkinName = "Black"
        Me.cmdDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 30)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        '
        'frmMaintenanceMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 376)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnLoad)
        Me.DoubleBuffered = True
        Me.Name = "frmMaintenanceMenu"
        Me.Opacity = 0
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TREE As DevExpress.XtraTreeList.TreeList
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents imgl As System.Windows.Forms.ImageList
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAddParent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdExpandAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCollapseAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlAtas As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
