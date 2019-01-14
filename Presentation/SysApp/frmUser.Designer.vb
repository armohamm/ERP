<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.Gridc = New DevExpress.XtraGrid.GridControl
        Me.GView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.repCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtNewuser = New DevExpress.XtraEditors.TextEdit
        Me.pnl = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtNama = New DevExpress.XtraEditors.TextEdit
        Me.txtUser = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Gridc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gridc
        '
        Me.Gridc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Gridc.Location = New System.Drawing.Point(0, 104)
        Me.Gridc.MainView = Me.GView
        Me.Gridc.Name = "Gridc"
        Me.Gridc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCek})
        Me.Gridc.Size = New System.Drawing.Size(550, 226)
        Me.Gridc.TabIndex = 1
        Me.Gridc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GView})
        '
        'GView
        '
        Me.GView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GView.Appearance.Empty.Options.UseBackColor = True
        Me.GView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.GView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GView.Appearance.EvenRow.Options.UseBackColor = True
        Me.GView.Appearance.EvenRow.Options.UseForeColor = True
        Me.GView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GView.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GView.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GView.Appearance.FixedLine.Options.UseBackColor = True
        Me.GView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GView.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupButton.Options.UseBackColor = True
        Me.GView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GView.Appearance.GroupButton.Options.UseForeColor = True
        Me.GView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.GView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.GView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GView.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GView.Appearance.GroupPanel.Options.UseFont = True
        Me.GView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GView.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GView.Appearance.GroupRow.Options.UseBackColor = True
        Me.GView.Appearance.GroupRow.Options.UseForeColor = True
        Me.GView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.HorzLine.Options.UseBackColor = True
        Me.GView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GView.Appearance.OddRow.Options.UseBackColor = True
        Me.GView.Appearance.OddRow.Options.UseForeColor = True
        Me.GView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GView.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GView.Appearance.Preview.Options.UseBackColor = True
        Me.GView.Appearance.Preview.Options.UseForeColor = True
        Me.GView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.Row.Options.UseBackColor = True
        Me.GView.Appearance.Row.Options.UseForeColor = True
        Me.GView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.GView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GView.Appearance.VertLine.Options.UseBackColor = True
        Me.GView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GView.GridControl = Me.Gridc
        Me.GView.Name = "GView"
        Me.GView.OptionsCustomization.AllowColumnMoving = False
        Me.GView.OptionsCustomization.AllowColumnResizing = False
        Me.GView.OptionsCustomization.AllowFilter = False
        Me.GView.OptionsCustomization.AllowGroup = False
        Me.GView.OptionsLayout.Columns.AddNewColumns = False
        Me.GView.OptionsView.ColumnAutoWidth = False
        Me.GView.OptionsView.EnableAppearanceEvenRow = True
        Me.GView.OptionsView.EnableAppearanceOddRow = True
        Me.GView.OptionsView.ShowGroupPanel = False
        Me.GView.PaintStyleName = "Skin"
        '
        'repCek
        '
        Me.repCek.AutoHeight = False
        Me.repCek.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.repCek.Caption = ""
        Me.repCek.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repCek.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repCek.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.repCek.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repCek.Name = "repCek"
        Me.repCek.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repCek.ValueChecked = 1
        Me.repCek.ValueUnchecked = 0
        '
        'txtNewuser
        '
        Me.txtNewuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNewuser.Location = New System.Drawing.Point(0, 0)
        Me.txtNewuser.Name = "txtNewuser"
        Me.txtNewuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNewuser.Size = New System.Drawing.Size(438, 20)
        Me.txtNewuser.TabIndex = 3
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Border = True
        Me.pnl.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnl.Colors.Add(Me.ColorWithAlpha1)
        Me.pnl.Colors.Add(Me.ColorWithAlpha2)
        Me.pnl.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Gridc)
        Me.pnl.CornerRadius = 5
        Me.pnl.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnl.Gradient = True
        Me.pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnl.GradientOffset = 1.0!
        Me.pnl.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnl.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnl.Grayscale = False
        Me.pnl.Image = Nothing
        Me.pnl.ImageAlpha = 255
        Me.pnl.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnl.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight), BlueActivity.Controls.ImagePosition)
        Me.pnl.ImageSize = New System.Drawing.Size(16, 16)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Rounded = True
        Me.pnl.Size = New System.Drawing.Size(550, 330)
        Me.pnl.TabIndex = 10
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Me.pnl
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ButtonFace
        Me.ColorWithAlpha2.Parent = Me.pnl
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gold
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(107, 41)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 63)
        Me.Panel6.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Controls.Add(Me.txtUser)
        Me.Panel3.Controls.Add(Me.txtNewuser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(112, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(438, 63)
        Me.Panel3.TabIndex = 9
        '
        'txtNama
        '
        Me.txtNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNama.Location = New System.Drawing.Point(0, 42)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNama.Size = New System.Drawing.Size(438, 20)
        Me.txtNama.TabIndex = 6
        '
        'txtUser
        '
        Me.txtUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtUser.Location = New System.Drawing.Point(0, 20)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtUser.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtUser.Properties.HideSelection = False
        Me.txtUser.Properties.NullText = "[Pilih User]"
        Me.txtUser.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.txtUser.Properties.PopupFormMinSize = New System.Drawing.Size(250, 0)
        Me.txtUser.Properties.PopupWidth = 250
        Me.txtUser.Size = New System.Drawing.Size(438, 22)
        Me.txtUser.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LabelControl2)
        Me.Panel2.Controls.Add(Me.LabelControl3)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 63)
        Me.Panel2.TabIndex = 8
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
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Nama User : "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "ID User : "
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
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "ID User Baru : "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 41)
        Me.Panel1.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(550, 5)
        Me.Panel4.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.ImageIndex = 0
        Me.LabelControl4.Appearance.ImageList = Me.img
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl4.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(223, 31)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "  Maintenance User"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "62.ICO")
        Me.img.Images.SetKeyName(1, "a_execute_256.png")
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 369)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        CType(Me.Gridc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gridc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents repCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtNewuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnl As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
