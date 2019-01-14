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
        Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceMenu))
        Me.nm_menu = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.caption = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.call_form = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.TREE = New DevExpress.XtraTreeList.TreeList
        Me.parent_menu = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.urutan = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.imgs = New DevExpress.XtraTreeList.Columns.TreeListColumn
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
        Me.pnlLoad = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.pnlLoad.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'nm_menu
        '
        Me.nm_menu.Caption = "nm_menu"
        Me.nm_menu.FieldName = "nm_menu"
        Me.nm_menu.Name = "nm_menu"
        '
        'caption
        '
        Me.caption.Caption = "Caption Menu"
        Me.caption.FieldName = "caption"
        Me.caption.Name = "caption"
        Me.caption.Visible = True
        Me.caption.VisibleIndex = 0
        Me.caption.Width = 446
        '
        'call_form
        '
        Me.call_form.Caption = "Nama Form"
        Me.call_form.FieldName = "call_form"
        Me.call_form.Name = "call_form"
        Me.call_form.Visible = True
        Me.call_form.VisibleIndex = 1
        Me.call_form.Width = 134
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(794, 52)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 27)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load Menu"
        Me.btnLoad.Visible = False
        '
        'TREE
        '
        Me.TREE.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.Empty.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TREE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.EvenRow.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.Options.UseForeColor = True
        Me.TREE.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TREE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TREE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.TREE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TREE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TREE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TREE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TREE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TREE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TREE.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupButton.Options.UseBackColor = True
        Me.TREE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupButton.Options.UseForeColor = True
        Me.TREE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TREE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TREE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TREE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.TREE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TREE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TREE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TREE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TREE.Appearance.HorzLine.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.OddRow.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.Options.UseForeColor = True
        Me.TREE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TREE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TREE.Appearance.Preview.Options.UseBackColor = True
        Me.TREE.Appearance.Preview.Options.UseForeColor = True
        Me.TREE.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.Row.Options.UseBackColor = True
        Me.TREE.Appearance.Row.Options.UseForeColor = True
        Me.TREE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TREE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TREE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TREE.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TREE.Appearance.TreeLine.Options.UseBackColor = True
        Me.TREE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TREE.Appearance.VertLine.Options.UseBackColor = True
        Me.TREE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TREE.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.caption, Me.parent_menu, Me.call_form, Me.urutan, Me.imgs, Me.nm_menu})
        Me.TREE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TREE.DragExpandDelay = 500
        Me.TREE.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.nm_menu
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "IsNullOrEmpty([nm_menu])"
        StyleFormatCondition2.Value1 = ""
        Me.TREE.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition2})
        Me.TREE.ImageIndexFieldName = ""
        Me.TREE.Location = New System.Drawing.Point(0, 0)
        Me.TREE.LookAndFeel.SkinName = "The Asphalt World"
        Me.TREE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TREE.Name = "TREE"
        Me.TREE.OptionsBehavior.AutoFocusNewNode = True
        Me.TREE.OptionsBehavior.AutoMoveRowFocus = True
        Me.TREE.OptionsBehavior.DragNodes = True
        Me.TREE.OptionsBehavior.EnterMovesNextColumn = True
        Me.TREE.OptionsBehavior.ResizeNodes = False
        Me.TREE.OptionsBehavior.UseTabKey = True
        Me.TREE.OptionsLayout.AddNewColumns = False
        Me.TREE.OptionsView.AutoCalcPreviewLineCount = True
        Me.TREE.OptionsView.EnableAppearanceEvenRow = True
        Me.TREE.OptionsView.EnableAppearanceOddRow = True
        Me.TREE.RootValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TREE.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
        Me.TREE.Size = New System.Drawing.Size(768, 143)
        Me.TREE.StateImageList = Me.imgl
        Me.TREE.TabIndex = 6
        Me.TREE.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark
        '
        'parent_menu
        '
        Me.parent_menu.Caption = "parent_menu"
        Me.parent_menu.FieldName = "parent_menu"
        Me.parent_menu.Name = "parent_menu"
        '
        'urutan
        '
        Me.urutan.Caption = "No"
        Me.urutan.FieldName = "urutan"
        Me.urutan.Name = "urutan"
        Me.urutan.Visible = True
        Me.urutan.VisibleIndex = 2
        Me.urutan.Width = 59
        '
        'imgs
        '
        Me.imgs.Caption = "Icon"
        Me.imgs.FieldName = "img"
        Me.imgs.Name = "imgs"
        Me.imgs.Visible = True
        Me.imgs.VisibleIndex = 3
        Me.imgs.Width = 87
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
        Me.cmdAdd.Location = New System.Drawing.Point(412, 0)
        Me.cmdAdd.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 28)
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
        Me.pnlAtas.Size = New System.Drawing.Size(768, 37)
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
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.LabelControl3.Size = New System.Drawing.Size(256, 37)
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
        Me.cmdCancel.Location = New System.Drawing.Point(678, 0)
        Me.cmdCancel.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.Visible = False
        '
        'pnl
        '
        Me.pnl.Appearance.BackColor = System.Drawing.Color.Transparent
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
        Me.pnl.Size = New System.Drawing.Size(776, 251)
        Me.pnl.TabIndex = 16
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(772, 247)
        Me.PanelControl1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 178)
        Me.Panel1.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.pnlLoad)
        Me.Panel4.Controls.Add(Me.TREE)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(768, 143)
        Me.Panel4.TabIndex = 5
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoad.Border = True
        Me.pnlLoad.BorderColor = System.Drawing.Color.Transparent
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlLoad.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLoad.Controls.Add(Me.PictureBox2)
        Me.pnlLoad.Controls.Add(Me.Label1)
        Me.pnlLoad.CornerRadius = 8
        Me.pnlLoad.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlLoad.Gradient = True
        Me.pnlLoad.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlLoad.GradientOffset = 1.0!
        Me.pnlLoad.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLoad.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLoad.Grayscale = False
        Me.pnlLoad.Image = Nothing
        Me.pnlLoad.ImageAlpha = 75
        Me.pnlLoad.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlLoad.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlLoad.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLoad.Location = New System.Drawing.Point(248, 29)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Rounded = True
        Me.pnlLoad.Size = New System.Drawing.Size(306, 52)
        Me.pnlLoad.TabIndex = 7
        Me.pnlLoad.Visible = False
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.DarkBlue
        Me.ColorWithAlpha7.Parent = Me.pnlLoad
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 200
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Blue
        Me.ColorWithAlpha6.Parent = Me.pnlLoad
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 52)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Harap Tunggu..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.cmdCollapseAll)
        Me.Panel3.Controls.Add(Me.cmdExpandAll)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(768, 35)
        Me.Panel3.TabIndex = 4
        '
        'cmdCollapseAll
        '
        Me.cmdCollapseAll.Image = CType(resources.GetObject("cmdCollapseAll.Image"), System.Drawing.Image)
        Me.cmdCollapseAll.Location = New System.Drawing.Point(290, 2)
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
        Me.cmdExpandAll.Location = New System.Drawing.Point(382, 3)
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
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(768, 65)
        Me.Panel2.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.cmdAdd)
        Me.Panel6.Controls.Add(Me.cmdAddParent)
        Me.Panel6.Controls.Add(Me.cmdDelete)
        Me.Panel6.Controls.Add(Me.cmdCancel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 37)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(768, 28)
        Me.Panel6.TabIndex = 25
        '
        'cmdAddParent
        '
        Me.cmdAddParent.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAddParent.ImageIndex = 4
        Me.cmdAddParent.ImageList = Me.imgl
        Me.cmdAddParent.Location = New System.Drawing.Point(500, 0)
        Me.cmdAddParent.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAddParent.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAddParent.Name = "cmdAddParent"
        Me.cmdAddParent.Size = New System.Drawing.Size(88, 28)
        Me.cmdAddParent.TabIndex = 5
        Me.cmdAddParent.Text = "Add Root"
        '
        'cmdDelete
        '
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdDelete.ImageIndex = 6
        Me.cmdDelete.ImageList = Me.imgl
        Me.cmdDelete.Location = New System.Drawing.Point(588, 0)
        Me.cmdDelete.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 28)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        '
        'frmMaintenanceMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 376)
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
        Me.pnlLoad.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents caption As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents parent_menu As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents call_form As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents urutan As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents imgs As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents nm_menu As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents pnlLoad As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
End Class
