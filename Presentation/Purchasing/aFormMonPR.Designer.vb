<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonPR
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonPR))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.gcPR = New DevExpress.XtraGrid.GridControl
        Me.gvPR = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_csp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supp_pilih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.col_sts_PO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.dtpAkhir = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.err = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.dtpAwal = New DevExpress.XtraEditors.DateEdit
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.gcPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dtpAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcPR)
        Me.pnl.Controls.Add(Me.PanelControl1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(978, 585)
        Me.pnl.TabIndex = 0
        '
        'gcPR
        '
        Me.gcPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPR.Location = New System.Drawing.Point(2, 92)
        Me.gcPR.MainView = Me.gvPR
        Me.gcPR.Name = "gcPR"
        Me.gcPR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVbarang, Me.LOVDate, Me.LOVSupplier})
        Me.gcPR.Size = New System.Drawing.Size(974, 466)
        Me.gcPR.TabIndex = 8
        Me.gcPR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPR})
        '
        'gvPR
        '
        Me.gvPR.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvPR.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvPR.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvPR.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvPR.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPR.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvPR.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvPR.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvPR.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvPR.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvPR.Appearance.Empty.Options.UseBackColor = True
        Me.gvPR.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPR.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvPR.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvPR.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvPR.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvPR.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvPR.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvPR.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvPR.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvPR.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvPR.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvPR.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvPR.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvPR.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvPR.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvPR.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvPR.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvPR.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvPR.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvPR.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvPR.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvPR.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvPR.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvPR.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvPR.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvPR.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvPR.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvPR.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvPR.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvPR.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvPR.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvPR.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvPR.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvPR.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvPR.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvPR.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvPR.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvPR.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvPR.Appearance.GroupRow.Options.UseFont = True
        Me.gvPR.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvPR.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvPR.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvPR.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvPR.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvPR.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvPR.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvPR.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvPR.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvPR.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvPR.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvPR.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvPR.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvPR.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvPR.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPR.Appearance.OddRow.Options.UseForeColor = True
        Me.gvPR.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPR.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvPR.Appearance.Preview.Options.UseBackColor = True
        Me.gvPR.Appearance.Preview.Options.UseForeColor = True
        Me.gvPR.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvPR.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvPR.Appearance.Row.Options.UseBackColor = True
        Me.gvPR.Appearance.Row.Options.UseForeColor = True
        Me.gvPR.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvPR.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvPR.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvPR.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvPR.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvPR.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvPR.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvPR.Appearance.VertLine.Options.UseBackColor = True
        Me.gvPR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.no_pr, Me.tgl_pr, Me.kd_stok, Me.satuan, Me.qty_order, Me.qty_pr, Me.no_csp, Me.kd_supp_pilih, Me.col_sts_PO})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[stok_min]  <= [akhir_qty_onstok]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[stok_min]  *  2 < [akhir_qty_onstok]"
        Me.gvPR.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvPR.GridControl = Me.gcPR
        Me.gvPR.GroupPanelText = "Geser nama kolom kemari untuk mengelompokan data berdasarkan kolom tersebut"
        Me.gvPR.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvPR.Name = "gvPR"
        Me.gvPR.OptionsBehavior.Editable = False
        Me.gvPR.OptionsBehavior.ReadOnly = True
        Me.gvPR.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPR.OptionsView.EnableAppearanceOddRow = True
        Me.gvPR.OptionsView.RowAutoHeight = True
        Me.gvPR.OptionsView.ShowIndicator = False
        Me.gvPR.OptionsView.ShowViewCaption = True
        Me.gvPR.PaintStyleName = "WindowsXP"
        Me.gvPR.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvPR.ViewCaption = "MONITORING PURCHASE REQUEST"
        '
        'nomor
        '
        Me.nomor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor.AppearanceHeader.Options.UseFont = True
        Me.nomor.AppearanceHeader.Options.UseTextOptions = True
        Me.nomor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomor.Caption = "No."
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        Me.nomor.Width = 38
        '
        'no_pr
        '
        Me.no_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_pr.AppearanceHeader.Options.UseFont = True
        Me.no_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.no_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_pr.Caption = "No. PR"
        Me.no_pr.FieldName = "no_pr"
        Me.no_pr.Name = "no_pr"
        Me.no_pr.Visible = True
        Me.no_pr.VisibleIndex = 1
        Me.no_pr.Width = 100
        '
        'tgl_pr
        '
        Me.tgl_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_pr.AppearanceHeader.Options.UseFont = True
        Me.tgl_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_pr.Caption = "Tgl. PR"
        Me.tgl_pr.ColumnEdit = Me.LOVDate
        Me.tgl_pr.FieldName = "tgl_pr"
        Me.tgl_pr.Name = "tgl_pr"
        Me.tgl_pr.Visible = True
        Me.tgl_pr.VisibleIndex = 2
        Me.tgl_pr.Width = 80
        '
        'LOVDate
        '
        Me.LOVDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVDate.Mask.EditMask = "d MMMM yyyy"
        Me.LOVDate.Mask.UseMaskAsDisplayFormat = True
        Me.LOVDate.Name = "LOVDate"
        Me.LOVDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.LOVbarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 3
        Me.kd_stok.Width = 230
        '
        'LOVbarang
        '
        Me.LOVbarang.AutoHeight = False
        Me.LOVbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "KODE"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "NAMA")})
        Me.LOVbarang.Name = "LOVbarang"
        Me.LOVbarang.NullText = "Kosong"
        '
        'satuan
        '
        Me.satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satuan.AppearanceHeader.Options.UseFont = True
        Me.satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 4
        Me.satuan.Width = 70
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_order.AppearanceHeader.Options.UseFont = True
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Qty. Order"
        Me.qty_order.DisplayFormat.FormatString = "N2"
        Me.qty_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 5
        Me.qty_order.Width = 73
        '
        'qty_pr
        '
        Me.qty_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_pr.AppearanceHeader.Options.UseFont = True
        Me.qty_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_pr.Caption = "Qty. PR"
        Me.qty_pr.DisplayFormat.FormatString = "N2"
        Me.qty_pr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_pr.FieldName = "qty_pr"
        Me.qty_pr.Name = "qty_pr"
        Me.qty_pr.Visible = True
        Me.qty_pr.VisibleIndex = 6
        Me.qty_pr.Width = 73
        '
        'no_csp
        '
        Me.no_csp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_csp.AppearanceHeader.Options.UseFont = True
        Me.no_csp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_csp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_csp.Caption = "No. Transaksi"
        Me.no_csp.FieldName = "no_csp"
        Me.no_csp.Name = "no_csp"
        Me.no_csp.Visible = True
        Me.no_csp.VisibleIndex = 7
        Me.no_csp.Width = 102
        '
        'kd_supp_pilih
        '
        Me.kd_supp_pilih.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supp_pilih.AppearanceHeader.Options.UseFont = True
        Me.kd_supp_pilih.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supp_pilih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supp_pilih.Caption = "Supplier"
        Me.kd_supp_pilih.ColumnEdit = Me.LOVSupplier
        Me.kd_supp_pilih.FieldName = "kd_supp_pilih"
        Me.kd_supp_pilih.Name = "kd_supp_pilih"
        Me.kd_supp_pilih.Visible = True
        Me.kd_supp_pilih.VisibleIndex = 8
        Me.kd_supp_pilih.Width = 130
        '
        'LOVSupplier
        '
        Me.LOVSupplier.AutoHeight = False
        Me.LOVSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVSupplier.Name = "LOVSupplier"
        Me.LOVSupplier.NullText = "Kosong"
        '
        'col_sts_PO
        '
        Me.col_sts_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_sts_PO.AppearanceHeader.Options.UseFont = True
        Me.col_sts_PO.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sts_PO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sts_PO.Caption = "Status PO"
        Me.col_sts_PO.FieldName = "Status_PO"
        Me.col_sts_PO.Name = "col_sts_PO"
        Me.col_sts_PO.Visible = True
        Me.col_sts_PO.VisibleIndex = 9
        Me.col_sts_PO.Width = 76
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.btnRefresh)
        Me.PanelControl1.Controls.Add(Me.dtpAwal)
        Me.PanelControl1.Controls.Add(Me.dtpAkhir)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 37)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(974, 55)
        Me.PanelControl1.TabIndex = 7
        '
        'dtpAkhir
        '
        Me.dtpAkhir.EditValue = Nothing
        Me.dtpAkhir.EnterMoveNextControl = True
        Me.dtpAkhir.Location = New System.Drawing.Point(430, 17)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAkhir.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtpAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpAkhir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpAkhir.Properties.ShowPopupShadow = False
        Me.dtpAkhir.Properties.ValidateOnEnterKey = True
        Me.dtpAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpAkhir.Size = New System.Drawing.Size(216, 20)
        Me.dtpAkhir.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 558)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 25)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 35)
        Me.Panel1.TabIndex = 5
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 33)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING PURCHASE REQUEST"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'dtpAwal
        '
        Me.dtpAwal.EditValue = Nothing
        Me.dtpAwal.EnterMoveNextControl = True
        Me.dtpAwal.Location = New System.Drawing.Point(126, 17)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAwal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.dtpAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpAwal.Properties.ShowPopupShadow = False
        Me.dtpAwal.Properties.ValidateOnEnterKey = True
        Me.dtpAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpAwal.Size = New System.Drawing.Size(175, 20)
        Me.dtpAwal.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(668, 9)
        Me.btnRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 40)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnRefresh.ToolTipTitle = "SEARCH"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 46)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(307, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 43)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "s/d"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aFormMonPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 585)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonPR"
        Me.Text = "aFormMonPR"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.gcPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dtpAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcPR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LOVbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents err As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_csp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supp_pilih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents no_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents col_sts_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtpAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
