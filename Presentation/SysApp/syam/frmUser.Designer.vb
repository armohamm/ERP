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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.Gridc = New DevExpress.XtraGrid.GridControl
        Me.GView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.idrole = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.iduser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtNewuser = New DevExpress.XtraEditors.TextEdit
        Me.pnl = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdStat = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDivisi = New DevExpress.XtraEditors.TextEdit
        Me.txtNama = New DevExpress.XtraEditors.TextEdit
        Me.cmdNip = New DevExpress.XtraEditors.LookUpEdit
        Me.txtUser = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Gridc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cmdStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gridc
        '
        Me.Gridc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gridc.Location = New System.Drawing.Point(0, 164)
        Me.Gridc.MainView = Me.GView
        Me.Gridc.Name = "Gridc"
        Me.Gridc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCek})
        Me.Gridc.Size = New System.Drawing.Size(550, 109)
        Me.Gridc.TabIndex = 1
        Me.Gridc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GView})
        '
        'GView
        '
        Me.GView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GView.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.Empty.Options.UseBackColor = True
        Me.GView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.EvenRow.Options.UseBackColor = True
        Me.GView.Appearance.EvenRow.Options.UseForeColor = True
        Me.GView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GView.Appearance.FixedLine.Options.UseBackColor = True
        Me.GView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupButton.Options.UseBackColor = True
        Me.GView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.GroupRow.Options.UseBackColor = True
        Me.GView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GView.Appearance.GroupRow.Options.UseForeColor = True
        Me.GView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.HorzLine.Options.UseBackColor = True
        Me.GView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.OddRow.Options.UseBackColor = True
        Me.GView.Appearance.OddRow.Options.UseForeColor = True
        Me.GView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GView.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GView.Appearance.Preview.Options.UseBackColor = True
        Me.GView.Appearance.Preview.Options.UseFont = True
        Me.GView.Appearance.Preview.Options.UseForeColor = True
        Me.GView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GView.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GView.Appearance.Row.Options.UseBackColor = True
        Me.GView.Appearance.Row.Options.UseBorderColor = True
        Me.GView.Appearance.Row.Options.UseForeColor = True
        Me.GView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GView.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GView.Appearance.VertLine.Options.UseBackColor = True
        Me.GView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idrole, Me.cek, Me.iduser, Me.bagian, Me.nama})
        Me.GView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GView.GridControl = Me.Gridc
        Me.GView.Name = "GView"
        Me.GView.OptionsCustomization.AllowColumnMoving = False
        Me.GView.OptionsCustomization.AllowFilter = False
        Me.GView.OptionsCustomization.AllowGroup = False
        Me.GView.OptionsLayout.Columns.AddNewColumns = False
        Me.GView.OptionsView.EnableAppearanceEvenRow = True
        Me.GView.OptionsView.EnableAppearanceOddRow = True
        Me.GView.OptionsView.ShowGroupPanel = False
        Me.GView.OptionsView.ShowHorzLines = False
        Me.GView.OptionsView.ShowIndicator = False
        Me.GView.OptionsView.ShowVertLines = False
        Me.GView.PaintStyleName = "Skin"
        '
        'idrole
        '
        Me.idrole.Caption = "idrole"
        Me.idrole.FieldName = "idrole"
        Me.idrole.Name = "idrole"
        '
        'cek
        '
        Me.cek.Caption = "Pilih"
        Me.cek.FieldName = "cek"
        Me.cek.Name = "cek"
        Me.cek.Visible = True
        Me.cek.VisibleIndex = 0
        Me.cek.Width = 55
        '
        'iduser
        '
        Me.iduser.Caption = "GridColumn3"
        Me.iduser.FieldName = "iduser"
        Me.iduser.Name = "iduser"
        '
        'bagian
        '
        Me.bagian.Caption = "GridColumn4"
        Me.bagian.FieldName = "bagian"
        Me.bagian.Name = "bagian"
        '
        'nama
        '
        Me.nama.Caption = "Role"
        Me.nama.FieldName = "nama"
        Me.nama.Name = "nama"
        Me.nama.OptionsColumn.AllowEdit = False
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 1
        Me.nama.Width = 456
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
        Me.txtNewuser.Size = New System.Drawing.Size(443, 20)
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
        Me.pnl.Controls.Add(Me.Gridc)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel1)
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
        Me.pnl.Location = New System.Drawing.Point(46, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Rounded = True
        Me.pnl.Size = New System.Drawing.Size(550, 273)
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(550, 123)
        Me.Panel5.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdStat)
        Me.Panel3.Controls.Add(Me.txtDivisi)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Controls.Add(Me.cmdNip)
        Me.Panel3.Controls.Add(Me.txtUser)
        Me.Panel3.Controls.Add(Me.txtNewuser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(107, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 123)
        Me.Panel3.TabIndex = 9
        '
        'cmdStat
        '
        Me.cmdStat.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdStat.EditValue = "AKTIF"
        Me.cmdStat.Location = New System.Drawing.Point(0, 104)
        Me.cmdStat.Name = "cmdStat"
        Me.cmdStat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdStat.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStat.Properties.Appearance.Options.UseBackColor = True
        Me.cmdStat.Properties.Appearance.Options.UseFont = True
        Me.cmdStat.Properties.Appearance.Options.UseTextOptions = True
        Me.cmdStat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmdStat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdStat.Properties.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cmdStat.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmdStat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmdStat.Size = New System.Drawing.Size(158, 20)
        Me.cmdStat.TabIndex = 10
        '
        'txtDivisi
        '
        Me.txtDivisi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDivisi.Enabled = False
        Me.txtDivisi.Location = New System.Drawing.Point(0, 84)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDivisi.Properties.Appearance.Options.UseBackColor = True
        Me.txtDivisi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDivisi.Properties.ReadOnly = True
        Me.txtDivisi.Size = New System.Drawing.Size(443, 20)
        Me.txtDivisi.TabIndex = 9
        '
        'txtNama
        '
        Me.txtNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(0, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNama.Properties.Appearance.Options.UseBackColor = True
        Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNama.Properties.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(443, 20)
        Me.txtNama.TabIndex = 8
        '
        'cmdNip
        '
        Me.cmdNip.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdNip.Location = New System.Drawing.Point(0, 42)
        Me.cmdNip.Name = "cmdNip"
        Me.cmdNip.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdNip.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("cmdNip.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cmdNip.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 200, "Nama")})
        Me.cmdNip.Properties.DisplayMember = "Nama"
        Me.cmdNip.Properties.HideSelection = False
        Me.cmdNip.Properties.NullText = "[Pilih User]"
        Me.cmdNip.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.cmdNip.Properties.PopupFormMinSize = New System.Drawing.Size(250, 0)
        Me.cmdNip.Properties.PopupWidth = 250
        Me.cmdNip.Properties.ValueMember = "nasabah_id"
        Me.cmdNip.Size = New System.Drawing.Size(443, 22)
        Me.cmdNip.TabIndex = 7
        '
        'txtUser
        '
        Me.txtUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtUser.Location = New System.Drawing.Point(0, 20)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtUser.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtUser.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("userid", 50, "User ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", 150, "Username"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nip", 50, "NIP")})
        Me.txtUser.Properties.DropDownRows = 15
        Me.txtUser.Properties.HideSelection = False
        Me.txtUser.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtUser.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtUser.Properties.NullText = "[Pilih User]"
        Me.txtUser.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.txtUser.Properties.PopupFormMinSize = New System.Drawing.Size(300, 0)
        Me.txtUser.Properties.PopupWidth = 300
        Me.txtUser.Properties.ShowHeader = False
        Me.txtUser.Properties.ShowLines = False
        Me.txtUser.Size = New System.Drawing.Size(443, 22)
        Me.txtUser.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LabelControl7)
        Me.Panel2.Controls.Add(Me.LabelControl6)
        Me.Panel2.Controls.Add(Me.LabelControl5)
        Me.Panel2.Controls.Add(Me.LabelControl2)
        Me.Panel2.Controls.Add(Me.LabelControl3)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 123)
        Me.Panel2.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl7.Location = New System.Drawing.Point(0, 104)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "* Status : "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl6.Location = New System.Drawing.Point(0, 84)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Divisi : "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl5.Location = New System.Drawing.Point(0, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "NIP : "
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
        Me.LabelControl2.Location = New System.Drawing.Point(0, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 22)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Nama Pegawai : "
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
        Me.LabelControl3.Size = New System.Drawing.Size(105, 22)
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
        Me.LabelControl1.Text = "* ID User Baru : "
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
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.LabelControl4.Text = " Maintenance User"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "62.ICO")
        Me.img.Images.SetKeyName(1, "a_execute_256.png")
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 369)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        CType(Me.Gridc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.cmdStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtUser As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents idrole As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents iduser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdNip As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDivisi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdStat As DevExpress.XtraEditors.ComboBoxEdit
End Class
