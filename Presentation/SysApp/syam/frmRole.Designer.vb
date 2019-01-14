<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRole
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRole))
        Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Me.VALUE = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.pw = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.lvlSaving = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TreeMenu = New DevExpress.XtraTreeList.TreeList
        Me.caption = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.nm_menu = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.parent_menu = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtBagian = New DevExpress.XtraEditors.TextEdit
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.pnlAtas = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.imgL = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.pw.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtBagian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        Me.SuspendLayout()
        '
        'VALUE
        '
        Me.VALUE.Caption = "VALUE"
        Me.VALUE.FieldName = "VALUE"
        Me.VALUE.Name = "VALUE"
        Me.VALUE.Width = 73
        '
        'pnl
        '
        Me.pnl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Appearance.Options.UseBackColor = True
        Me.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl.Controls.Add(Me.PanelControl2)
        Me.pnl.Controls.Add(Me.PanelControl1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(574, 484)
        Me.pnl.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.pw)
        Me.PanelControl2.Controls.Add(Me.TreeMenu)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 108)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(574, 376)
        Me.PanelControl2.TabIndex = 9
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.Transparent
        Me.pw.Border = True
        Me.pw.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.pw.Colors.Add(Me.ColorWithAlpha2)
        Me.pw.Colors.Add(Me.ColorWithAlpha4)
        Me.pw.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pw.Controls.Add(Me.lvlSaving)
        Me.pw.Controls.Add(Me.PictureBox2)
        Me.pw.Controls.Add(Me.Label1)
        Me.pw.CornerRadius = 20
        Me.pw.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pw.Gradient = True
        Me.pw.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pw.GradientOffset = 1.0!
        Me.pw.GradientSize = New System.Drawing.Size(0, 0)
        Me.pw.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pw.Grayscale = False
        Me.pw.Image = Nothing
        Me.pw.ImageAlpha = 50
        Me.pw.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pw.ImagePosition = BlueActivity.Controls.ImagePosition.TopLeft
        Me.pw.ImageSize = New System.Drawing.Size(100, 100)
        Me.pw.Location = New System.Drawing.Point(84, 93)
        Me.pw.Name = "pw"
        Me.pw.Rounded = True
        Me.pw.Size = New System.Drawing.Size(413, 107)
        Me.pw.TabIndex = 7
        Me.pw.Visible = False
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pw
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.White
        Me.ColorWithAlpha4.Parent = Me.pw
        '
        'lvlSaving
        '
        Me.lvlSaving.AutoSize = True
        Me.lvlSaving.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlSaving.ForeColor = System.Drawing.Color.Red
        Me.lvlSaving.Location = New System.Drawing.Point(118, 29)
        Me.lvlSaving.Name = "lvlSaving"
        Me.lvlSaving.Size = New System.Drawing.Size(190, 23)
        Me.lvlSaving.TabIndex = 7
        Me.lvlSaving.Text = "PROSES MENYIMPAN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(118, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harap Tunggu...."
        '
        'TreeMenu
        '
        Me.TreeMenu.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TreeMenu.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.TreeMenu.Appearance.Empty.Options.UseBackColor = True
        Me.TreeMenu.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeMenu.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.EvenRow.Options.UseBackColor = True
        Me.TreeMenu.Appearance.EvenRow.Options.UseForeColor = True
        Me.TreeMenu.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.TreeMenu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeMenu.Appearance.FocusedCell.Options.UseForeColor = True
        Me.TreeMenu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TreeMenu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TreeMenu.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TreeMenu.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TreeMenu.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TreeMenu.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TreeMenu.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TreeMenu.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TreeMenu.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TreeMenu.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.GroupButton.Options.UseBackColor = True
        Me.TreeMenu.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TreeMenu.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TreeMenu.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TreeMenu.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TreeMenu.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.TreeMenu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TreeMenu.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TreeMenu.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TreeMenu.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TreeMenu.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TreeMenu.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TreeMenu.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TreeMenu.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TreeMenu.Appearance.HorzLine.Options.UseBackColor = True
        Me.TreeMenu.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TreeMenu.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.OddRow.Options.UseBackColor = True
        Me.TreeMenu.Appearance.OddRow.Options.UseForeColor = True
        Me.TreeMenu.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TreeMenu.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.TreeMenu.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.TreeMenu.Appearance.Preview.Options.UseBackColor = True
        Me.TreeMenu.Appearance.Preview.Options.UseFont = True
        Me.TreeMenu.Appearance.Preview.Options.UseForeColor = True
        Me.TreeMenu.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeMenu.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TreeMenu.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TreeMenu.Appearance.Row.Options.UseBackColor = True
        Me.TreeMenu.Appearance.Row.Options.UseBorderColor = True
        Me.TreeMenu.Appearance.Row.Options.UseForeColor = True
        Me.TreeMenu.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TreeMenu.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeMenu.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TreeMenu.Appearance.TreeLine.Options.UseBackColor = True
        Me.TreeMenu.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TreeMenu.Appearance.VertLine.Options.UseBackColor = True
        Me.TreeMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TreeMenu.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.caption, Me.nm_menu, Me.parent_menu, Me.VALUE})
        Me.TreeMenu.Dock = System.Windows.Forms.DockStyle.Fill
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.VALUE
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition1.Value2 = ""
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.VALUE
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.VALUE
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "2"
        Me.TreeMenu.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.TreeMenu.ImageIndexFieldName = ""
        Me.TreeMenu.KeyFieldName = ""
        Me.TreeMenu.Location = New System.Drawing.Point(2, 2)
        Me.TreeMenu.LookAndFeel.SkinName = "The Asphalt World"
        Me.TreeMenu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TreeMenu.Name = "TreeMenu"
        Me.TreeMenu.OptionsBehavior.AllowIndeterminateCheckState = True
        Me.TreeMenu.OptionsBehavior.AutoFocusNewNode = True
        Me.TreeMenu.OptionsBehavior.Editable = False
        Me.TreeMenu.OptionsLayout.AddNewColumns = False
        Me.TreeMenu.OptionsSelection.UseIndicatorForSelection = True
        Me.TreeMenu.OptionsView.EnableAppearanceEvenRow = True
        Me.TreeMenu.OptionsView.EnableAppearanceOddRow = True
        Me.TreeMenu.OptionsView.ShowCheckBoxes = True
        Me.TreeMenu.RootValue = "*"
        Me.TreeMenu.Size = New System.Drawing.Size(570, 372)
        Me.TreeMenu.TabIndex = 6
        '
        'caption
        '
        Me.caption.Caption = "caption"
        Me.caption.FieldName = "caption"
        Me.caption.MinWidth = 35
        Me.caption.Name = "caption"
        Me.caption.OptionsColumn.AllowMove = False
        Me.caption.OptionsColumn.AllowSort = False
        Me.caption.Visible = True
        Me.caption.VisibleIndex = 0
        Me.caption.Width = 332
        '
        'nm_menu
        '
        Me.nm_menu.Caption = "nm_menu"
        Me.nm_menu.FieldName = "nm_menu"
        Me.nm_menu.Name = "nm_menu"
        Me.nm_menu.Visible = True
        Me.nm_menu.VisibleIndex = 1
        Me.nm_menu.Width = 72
        '
        'parent_menu
        '
        Me.parent_menu.Caption = "parent_menu"
        Me.parent_menu.FieldName = "parent_menu"
        Me.parent_menu.Name = "parent_menu"
        Me.parent_menu.Visible = True
        Me.parent_menu.VisibleIndex = 2
        Me.parent_menu.Width = 72
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Panel2)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.pnlAtas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(574, 108)
        Me.PanelControl1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtBagian)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.txtNomor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(137, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 67)
        Me.Panel2.TabIndex = 10
        '
        'txtBagian
        '
        Me.txtBagian.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBagian.Location = New System.Drawing.Point(0, 40)
        Me.txtBagian.Name = "txtBagian"
        Me.txtBagian.Properties.LookAndFeel.SkinName = "Black"
        Me.txtBagian.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtBagian.Size = New System.Drawing.Size(433, 20)
        Me.txtBagian.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(0, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.LookAndFeel.SkinName = "Black"
        Me.txtName.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtName.Size = New System.Drawing.Size(433, 20)
        Me.txtName.TabIndex = 9
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.EditValue = ""
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.LookAndFeel.SkinName = "Black"
        Me.txtNomor.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNomor.Size = New System.Drawing.Size(433, 20)
        Me.txtNomor.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(2, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 67)
        Me.Panel1.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 20)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Keterangan : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(130, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Role Name : "
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblID.Appearance.Options.UseFont = True
        Me.lblID.Appearance.Options.UseForeColor = True
        Me.lblID.Appearance.Options.UseTextOptions = True
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblID.Location = New System.Drawing.Point(0, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(130, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID Role : "
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Transparent
        Me.pnlAtas.Border = True
        Me.pnlAtas.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha5)
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
        Me.pnlAtas.ImageSize = New System.Drawing.Size(16, 16)
        Me.pnlAtas.Location = New System.Drawing.Point(2, 2)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Rounded = True
        Me.pnlAtas.Size = New System.Drawing.Size(570, 37)
        Me.pnlAtas.TabIndex = 8
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Me.pnlAtas
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlAtas
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha5.Parent = Me.pnlAtas
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl3.Appearance.ImageIndex = 0
        Me.LabelControl3.Appearance.ImageList = Me.img
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl3.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(223, 37)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "  Maintenance Role"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "62.ICO")
        Me.img.Images.SetKeyName(1, "a_execute_256.png")
        '
        'imgL
        '
        Me.imgL.ImageStream = CType(resources.GetObject("imgL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgL.TransparentColor = System.Drawing.Color.Transparent
        Me.imgL.Images.SetKeyName(0, "ckb.JPG")
        Me.imgL.Images.SetKeyName(1, "ckg.JPG")
        Me.imgL.Images.SetKeyName(2, "ckw.JPG")
        '
        'frmRole
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseImage = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 484)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRole"
        Me.Text = "frmRole"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.pw.ResumeLayout(False)
        Me.pw.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtBagian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TreeMenu As DevExpress.XtraTreeList.TreeList
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgL As System.Windows.Forms.ImageList
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlAtas As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents caption As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents nm_menu As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents parent_menu As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents VALUE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents pw As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lvlSaving As System.Windows.Forms.Label
    Friend WithEvents txtBagian As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
