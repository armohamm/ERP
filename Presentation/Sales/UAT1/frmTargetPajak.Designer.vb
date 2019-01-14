<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTargetPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTargetPajak))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.GC_Sales = New DevExpress.XtraGrid.GridControl
        Me.GVSpon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.thnbln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.target = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ktrngan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.txbKet = New System.Windows.Forms.TextBox
        Me.txt_target = New DevExpress.XtraEditors.TextEdit
        Me.txtTahun = New DevExpress.XtraEditors.DateEdit
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.GC_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txt_target.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(672, 522)
        Me.pnl.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Panel14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 459)
        Me.Panel3.TabIndex = 125
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DimGray
        Me.Panel13.Controls.Add(Me.GC_Sales)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 94)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(670, 363)
        Me.Panel13.TabIndex = 132
        '
        'GC_Sales
        '
        Me.GC_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Sales.Location = New System.Drawing.Point(0, 0)
        Me.GC_Sales.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC_Sales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC_Sales.MainView = Me.GVSpon
        Me.GC_Sales.Name = "GC_Sales"
        Me.GC_Sales.Size = New System.Drawing.Size(670, 363)
        Me.GC_Sales.TabIndex = 127
        Me.GC_Sales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSpon, Me.GridView1})
        '
        'GVSpon
        '
        Me.GVSpon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSpon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.Empty.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVSpon.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSpon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVSpon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSpon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSpon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Options.UseBackColor = True
        Me.GVSpon.Appearance.Preview.Options.UseFont = True
        Me.GVSpon.Appearance.Preview.Options.UseForeColor = True
        Me.GVSpon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.Row.Options.UseBackColor = True
        Me.GVSpon.Appearance.Row.Options.UseBorderColor = True
        Me.GVSpon.Appearance.Row.Options.UseForeColor = True
        Me.GVSpon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSpon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVSpon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSpon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.thnbln, Me.target, Me.ktrngan})
        Me.GVSpon.GridControl = Me.GC_Sales
        Me.GVSpon.GroupFormat = "{0}: [#image]{1}{2}"
        Me.GVSpon.Name = "GVSpon"
        Me.GVSpon.OptionsBehavior.Editable = False
        Me.GVSpon.OptionsBehavior.ReadOnly = True
        Me.GVSpon.OptionsPrint.ExpandAllDetails = True
        Me.GVSpon.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSpon.OptionsView.EnableAppearanceOddRow = True
        Me.GVSpon.OptionsView.ShowChildrenInGroupPanel = True
        Me.GVSpon.OptionsView.ShowGroupPanel = False
        Me.GVSpon.OptionsView.ShowViewCaption = True
        Me.GVSpon.ViewCaption = "List Target Pajak"
        '
        'thnbln
        '
        Me.thnbln.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thnbln.AppearanceCell.Options.UseFont = True
        Me.thnbln.Caption = "Tahun/Bulan"
        Me.thnbln.FieldName = "thnblnx"
        Me.thnbln.Name = "thnbln"
        Me.thnbln.Visible = True
        Me.thnbln.VisibleIndex = 0
        Me.thnbln.Width = 124
        '
        'target
        '
        Me.target.Caption = "Target Pajak"
        Me.target.DisplayFormat.FormatString = "N2"
        Me.target.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.target.FieldName = "target"
        Me.target.Name = "target"
        Me.target.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.target.Visible = True
        Me.target.VisibleIndex = 1
        Me.target.Width = 151
        '
        'ktrngan
        '
        Me.ktrngan.Caption = "Keterangan"
        Me.ktrngan.FieldName = "keterangan"
        Me.ktrngan.Name = "ktrngan"
        Me.ktrngan.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.ktrngan.Visible = True
        Me.ktrngan.VisibleIndex = 2
        Me.ktrngan.Width = 374
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GC_Sales
        Me.GridView1.Name = "GridView1"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(670, 94)
        Me.Panel14.TabIndex = 133
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.txbKet)
        Me.Panel16.Controls.Add(Me.txt_target)
        Me.Panel16.Controls.Add(Me.txtTahun)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(100, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(567, 94)
        Me.Panel16.TabIndex = 1
        '
        'txbKet
        '
        Me.txbKet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbKet.Location = New System.Drawing.Point(0, 40)
        Me.txbKet.Multiline = True
        Me.txbKet.Name = "txbKet"
        Me.txbKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbKet.Size = New System.Drawing.Size(567, 54)
        Me.txbKet.TabIndex = 126
        '
        'txt_target
        '
        Me.txt_target.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_target.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_target.Location = New System.Drawing.Point(0, 20)
        Me.txt_target.Name = "txt_target"
        Me.txt_target.Properties.DisplayFormat.FormatString = "N2"
        Me.txt_target.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_target.Properties.Mask.EditMask = "N2"
        Me.txt_target.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_target.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_target.Properties.NullText = "0.00"
        Me.txt_target.Size = New System.Drawing.Size(567, 20)
        Me.txt_target.TabIndex = 131
        '
        'txtTahun
        '
        Me.txtTahun.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTahun.EditValue = Nothing
        Me.txtTahun.Location = New System.Drawing.Point(0, 0)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun.Properties.Appearance.Options.UseFont = True
        Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTahun.Properties.DisplayFormat.FormatString = "MMMM yyyy"
        Me.txtTahun.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTahun.Properties.EditFormat.FormatString = "yyyymm"
        Me.txtTahun.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTahun.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtTahun.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTahun.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTahun.Size = New System.Drawing.Size(567, 20)
        Me.txtTahun.TabIndex = 127
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label3)
        Me.Panel15.Controls.Add(Me.Label4)
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(100, 94)
        Me.Panel15.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(0, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 36)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Keterangan : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(0, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Target : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Periode : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 34)
        Me.Panel1.TabIndex = 123
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAINTENANCE TARGET PAJAK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 493)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 29)
        Me.Panel2.TabIndex = 108
        '
        'frmTargetPajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 528)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmTargetPajak"
        Me.Text = "frmTargetPajak"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.GC_Sales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txt_target.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents GC_Sales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSpon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents thnbln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents target As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ktrngan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents txbKet As System.Windows.Forms.TextBox
    Friend WithEvents txt_target As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTahun As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
