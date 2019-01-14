<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonRphRealTepat
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonRphRealTepat))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_rph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_tglRph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTgl_Target = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jam_target = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jam_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Merk_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTgl_SPK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNo_Realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_realisasi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kegiatan_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.group_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_mesin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_rph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_rework = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_delay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DateEditTgl = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_jumlah_delay = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_jumlah_rework = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbl_jumlah_work = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Lbl_BelumRealisasi = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_jumlah_spk = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_jumlah_rph = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbo_status_realisasi = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lueDep = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.cmdGroup = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.lueDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1028, 480)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 102)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DateEditTgl})
        Me.GC.Size = New System.Drawing.Size(1028, 306)
        Me.GC.TabIndex = 8
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseFont = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_rph, Me.col_tglRph, Me.colTgl_Target, Me.jam_target, Me.tgl_realisasi, Me.jam_realisasi, Me.nama_barang, Me.Nama_Jenis, Me.Nama_Merk, Me.Nama_Tipe, Me.Nama_Sub_Tipe, Me.Nama_Ukuran, Me.Merk_Kain, Me.no_spk, Me.colTgl_SPK, Me.colNo_Realisasi, Me.tgl_realisasi1, Me.GridColumn1, Me.kegiatan, Me.kegiatan_spk, Me.Nama_Pegawai, Me.group_kerja, Me.nama_mesin, Me.jumlah_rph, Me.jumlah, Me.jumlah_kerja, Me.jumlah_rework, Me.jumlah_delay})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[tgl_realisasi1] > [tgl_batas1]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[tgl_realisasi1] <= [tgl_batas1]"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlah_kerja", Me.jumlah_kerja, "{0:#,##0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlah_rework", Me.jumlah_rework, "{0:#,##0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlah_delay", Me.jumlah_delay, "{0:#,##0.00}")})
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GV.OptionsPrint.UsePrintStyles = True
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupedColumns = True
        '
        'no_rph
        '
        Me.no_rph.AppearanceHeader.Options.UseTextOptions = True
        Me.no_rph.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_rph.Caption = "RPH"
        Me.no_rph.FieldName = "no_rph"
        Me.no_rph.Name = "no_rph"
        Me.no_rph.OptionsColumn.AllowEdit = False
        Me.no_rph.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_rph.OptionsColumn.ReadOnly = True
        Me.no_rph.Visible = True
        Me.no_rph.VisibleIndex = 0
        Me.no_rph.Width = 149
        '
        'col_tglRph
        '
        Me.col_tglRph.Caption = "Tgl RPH"
        Me.col_tglRph.FieldName = "tanggal_rph"
        Me.col_tglRph.Name = "col_tglRph"
        Me.col_tglRph.Visible = True
        Me.col_tglRph.VisibleIndex = 1
        '
        'colTgl_Target
        '
        Me.colTgl_Target.Caption = "Tgl Batas Akhir Realisasi"
        Me.colTgl_Target.FieldName = "tgl_batas"
        Me.colTgl_Target.Name = "colTgl_Target"
        Me.colTgl_Target.OptionsColumn.AllowEdit = False
        Me.colTgl_Target.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTgl_Target.Visible = True
        Me.colTgl_Target.VisibleIndex = 2
        '
        'jam_target
        '
        Me.jam_target.Caption = "Jam Target"
        Me.jam_target.FieldName = "jam_target"
        Me.jam_target.Name = "jam_target"
        Me.jam_target.OptionsColumn.AllowEdit = False
        Me.jam_target.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jam_target.Visible = True
        Me.jam_target.VisibleIndex = 3
        '
        'tgl_realisasi
        '
        Me.tgl_realisasi.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_realisasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_realisasi.Caption = "Tgl Entry Realisasi"
        Me.tgl_realisasi.FieldName = "tgl_realisasi"
        Me.tgl_realisasi.Name = "tgl_realisasi"
        Me.tgl_realisasi.OptionsColumn.AllowEdit = False
        Me.tgl_realisasi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_realisasi.Visible = True
        Me.tgl_realisasi.VisibleIndex = 4
        '
        'jam_realisasi
        '
        Me.jam_realisasi.Caption = "Jam Entry"
        Me.jam_realisasi.FieldName = "jam_realisasi"
        Me.jam_realisasi.Name = "jam_realisasi"
        Me.jam_realisasi.OptionsColumn.AllowEdit = False
        Me.jam_realisasi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jam_realisasi.Visible = True
        Me.jam_realisasi.VisibleIndex = 5
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.Caption = "Barang"
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.nama_barang.OptionsColumn.ReadOnly = True
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 6
        Me.nama_barang.Width = 144
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Jenis.Caption = "Jenis"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.OptionsColumn.AllowEdit = False
        Me.Nama_Jenis.OptionsColumn.ReadOnly = True
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 7
        Me.Nama_Jenis.Width = 150
        '
        'Nama_Merk
        '
        Me.Nama_Merk.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Merk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Merk.Caption = "Merk"
        Me.Nama_Merk.FieldName = "Nama_Merk"
        Me.Nama_Merk.Name = "Nama_Merk"
        Me.Nama_Merk.OptionsColumn.AllowEdit = False
        Me.Nama_Merk.OptionsColumn.ReadOnly = True
        Me.Nama_Merk.Visible = True
        Me.Nama_Merk.VisibleIndex = 8
        Me.Nama_Merk.Width = 150
        '
        'Nama_Tipe
        '
        Me.Nama_Tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Tipe.Caption = "Tipe"
        Me.Nama_Tipe.FieldName = "Nama_Tipe"
        Me.Nama_Tipe.Name = "Nama_Tipe"
        Me.Nama_Tipe.OptionsColumn.AllowEdit = False
        Me.Nama_Tipe.OptionsColumn.ReadOnly = True
        Me.Nama_Tipe.Visible = True
        Me.Nama_Tipe.VisibleIndex = 9
        Me.Nama_Tipe.Width = 150
        '
        'Nama_Sub_Tipe
        '
        Me.Nama_Sub_Tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Sub_Tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Sub_Tipe.Caption = "Sub Tipe"
        Me.Nama_Sub_Tipe.FieldName = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.Name = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.OptionsColumn.AllowEdit = False
        Me.Nama_Sub_Tipe.OptionsColumn.ReadOnly = True
        Me.Nama_Sub_Tipe.Visible = True
        Me.Nama_Sub_Tipe.VisibleIndex = 10
        Me.Nama_Sub_Tipe.Width = 150
        '
        'Nama_Ukuran
        '
        Me.Nama_Ukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Ukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Ukuran.Caption = "Ukuran"
        Me.Nama_Ukuran.FieldName = "Nama_Ukuran"
        Me.Nama_Ukuran.Name = "Nama_Ukuran"
        Me.Nama_Ukuran.OptionsColumn.AllowEdit = False
        Me.Nama_Ukuran.OptionsColumn.ReadOnly = True
        Me.Nama_Ukuran.Visible = True
        Me.Nama_Ukuran.VisibleIndex = 11
        Me.Nama_Ukuran.Width = 150
        '
        'Merk_Kain
        '
        Me.Merk_Kain.AppearanceHeader.Options.UseTextOptions = True
        Me.Merk_Kain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Merk_Kain.Caption = "Kain"
        Me.Merk_Kain.FieldName = "Merk_Kain"
        Me.Merk_Kain.Name = "Merk_Kain"
        Me.Merk_Kain.OptionsColumn.AllowEdit = False
        Me.Merk_Kain.OptionsColumn.ReadOnly = True
        Me.Merk_Kain.Visible = True
        Me.Merk_Kain.VisibleIndex = 12
        Me.Merk_Kain.Width = 150
        '
        'no_spk
        '
        Me.no_spk.AppearanceHeader.Options.UseTextOptions = True
        Me.no_spk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_spk.Caption = "No SPK"
        Me.no_spk.FieldName = "no_spk"
        Me.no_spk.Name = "no_spk"
        Me.no_spk.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_spk.OptionsColumn.ReadOnly = True
        Me.no_spk.Visible = True
        Me.no_spk.VisibleIndex = 13
        Me.no_spk.Width = 150
        '
        'colTgl_SPK
        '
        Me.colTgl_SPK.Caption = "Tgl SPK"
        Me.colTgl_SPK.FieldName = "tgl"
        Me.colTgl_SPK.Name = "colTgl_SPK"
        Me.colTgl_SPK.OptionsColumn.AllowEdit = False
        Me.colTgl_SPK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.colTgl_SPK.Visible = True
        Me.colTgl_SPK.VisibleIndex = 14
        '
        'colNo_Realisasi
        '
        Me.colNo_Realisasi.Caption = "No Realisasi"
        Me.colNo_Realisasi.FieldName = "no_spk_man_rls"
        Me.colNo_Realisasi.Name = "colNo_Realisasi"
        Me.colNo_Realisasi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNo_Realisasi.OptionsColumn.ReadOnly = True
        Me.colNo_Realisasi.Visible = True
        Me.colNo_Realisasi.VisibleIndex = 15
        '
        'tgl_realisasi1
        '
        Me.tgl_realisasi1.Caption = "Tanggal Realisasi"
        Me.tgl_realisasi1.DisplayFormat.FormatString = "d/M/yyyy H:mm:ss"
        Me.tgl_realisasi1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_realisasi1.FieldName = "tgl_realisasi1"
        Me.tgl_realisasi1.Name = "tgl_realisasi1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tanggal Batas "
        Me.GridColumn1.DisplayFormat.FormatString = "d/M/yyyy H:mm:ss"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "tgl_batas1"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'kegiatan
        '
        Me.kegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.kegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kegiatan.Caption = "Kegiatan"
        Me.kegiatan.FieldName = "kegiatan"
        Me.kegiatan.Name = "kegiatan"
        Me.kegiatan.OptionsColumn.AllowEdit = False
        Me.kegiatan.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.kegiatan.OptionsColumn.ReadOnly = True
        Me.kegiatan.Visible = True
        Me.kegiatan.VisibleIndex = 16
        Me.kegiatan.Width = 200
        '
        'kegiatan_spk
        '
        Me.kegiatan_spk.AppearanceHeader.Options.UseTextOptions = True
        Me.kegiatan_spk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kegiatan_spk.Caption = "Kegiatan SPK"
        Me.kegiatan_spk.FieldName = "kegiatan_spk"
        Me.kegiatan_spk.Name = "kegiatan_spk"
        Me.kegiatan_spk.OptionsColumn.AllowEdit = False
        Me.kegiatan_spk.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.kegiatan_spk.OptionsColumn.ReadOnly = True
        Me.kegiatan_spk.Visible = True
        Me.kegiatan_spk.VisibleIndex = 17
        Me.kegiatan_spk.Width = 200
        '
        'Nama_Pegawai
        '
        Me.Nama_Pegawai.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Pegawai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Pegawai.Caption = "Pegawai"
        Me.Nama_Pegawai.FieldName = "Nama_Pegawai"
        Me.Nama_Pegawai.Name = "Nama_Pegawai"
        Me.Nama_Pegawai.OptionsColumn.AllowEdit = False
        Me.Nama_Pegawai.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Nama_Pegawai.OptionsColumn.ReadOnly = True
        Me.Nama_Pegawai.Visible = True
        Me.Nama_Pegawai.VisibleIndex = 18
        Me.Nama_Pegawai.Width = 338
        '
        'group_kerja
        '
        Me.group_kerja.AppearanceHeader.Options.UseTextOptions = True
        Me.group_kerja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.group_kerja.Caption = "Group"
        Me.group_kerja.FieldName = "group_kerja"
        Me.group_kerja.Name = "group_kerja"
        Me.group_kerja.OptionsColumn.AllowEdit = False
        Me.group_kerja.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.group_kerja.OptionsColumn.ReadOnly = True
        Me.group_kerja.Visible = True
        Me.group_kerja.VisibleIndex = 19
        Me.group_kerja.Width = 200
        '
        'nama_mesin
        '
        Me.nama_mesin.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_mesin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_mesin.Caption = "Mesin"
        Me.nama_mesin.FieldName = "nama_mesin"
        Me.nama_mesin.Name = "nama_mesin"
        Me.nama_mesin.OptionsColumn.AllowEdit = False
        Me.nama_mesin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.nama_mesin.OptionsColumn.ReadOnly = True
        Me.nama_mesin.Visible = True
        Me.nama_mesin.VisibleIndex = 20
        Me.nama_mesin.Width = 200
        '
        'jumlah_rph
        '
        Me.jumlah_rph.Caption = "Jumlah RPH"
        Me.jumlah_rph.FieldName = "jumlah_rph"
        Me.jumlah_rph.Name = "jumlah_rph"
        Me.jumlah_rph.Visible = True
        Me.jumlah_rph.VisibleIndex = 21
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Jumlah SPK"
        Me.jumlah.DisplayFormat.FormatString = "N0"
        Me.jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowEdit = False
        Me.jumlah.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.jumlah.OptionsColumn.ReadOnly = True
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 22
        Me.jumlah.Width = 65
        '
        'jumlah_kerja
        '
        Me.jumlah_kerja.AppearanceCell.Options.UseTextOptions = True
        Me.jumlah_kerja.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah_kerja.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_kerja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_kerja.Caption = "Work"
        Me.jumlah_kerja.DisplayFormat.FormatString = "n0"
        Me.jumlah_kerja.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_kerja.FieldName = "jumlah_kerja"
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.OptionsColumn.AllowEdit = False
        Me.jumlah_kerja.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_kerja.OptionsColumn.ReadOnly = True
        Me.jumlah_kerja.SummaryItem.DisplayFormat = "{0:#,##0.00}"
        Me.jumlah_kerja.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_kerja.Visible = True
        Me.jumlah_kerja.VisibleIndex = 23
        Me.jumlah_kerja.Width = 65
        '
        'jumlah_rework
        '
        Me.jumlah_rework.AppearanceCell.Options.UseTextOptions = True
        Me.jumlah_rework.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah_rework.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_rework.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_rework.Caption = "Rework"
        Me.jumlah_rework.DisplayFormat.FormatString = "n0"
        Me.jumlah_rework.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_rework.FieldName = "jumlah_rework"
        Me.jumlah_rework.Name = "jumlah_rework"
        Me.jumlah_rework.OptionsColumn.AllowEdit = False
        Me.jumlah_rework.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_rework.OptionsColumn.ReadOnly = True
        Me.jumlah_rework.SummaryItem.DisplayFormat = "{0:#,##0.00}"
        Me.jumlah_rework.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_rework.Visible = True
        Me.jumlah_rework.VisibleIndex = 24
        Me.jumlah_rework.Width = 65
        '
        'jumlah_delay
        '
        Me.jumlah_delay.AppearanceCell.Options.UseTextOptions = True
        Me.jumlah_delay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah_delay.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_delay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_delay.Caption = "Delay"
        Me.jumlah_delay.DisplayFormat.FormatString = "n0"
        Me.jumlah_delay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_delay.FieldName = "jumlah_delay"
        Me.jumlah_delay.Name = "jumlah_delay"
        Me.jumlah_delay.OptionsColumn.AllowEdit = False
        Me.jumlah_delay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_delay.OptionsColumn.ReadOnly = True
        Me.jumlah_delay.SummaryItem.DisplayFormat = "{0:#,##0.00}"
        Me.jumlah_delay.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_delay.Visible = True
        Me.jumlah_delay.VisibleIndex = 25
        Me.jumlah_delay.Width = 65
        '
        'DateEditTgl
        '
        Me.DateEditTgl.AutoHeight = False
        Me.DateEditTgl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditTgl.DisplayFormat.FormatString = "d/M/yyyy H:mm:ss"
        Me.DateEditTgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEditTgl.Name = "DateEditTgl"
        Me.DateEditTgl.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_jumlah_delay)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl_jumlah_rework)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbl_jumlah_work)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Lbl_BelumRealisasi)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl_jumlah_spk)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_jumlah_rph)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 72)
        Me.Panel1.TabIndex = 7
        '
        'lbl_jumlah_delay
        '
        Me.lbl_jumlah_delay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_delay.ForeColor = System.Drawing.Color.Black
        Me.lbl_jumlah_delay.Location = New System.Drawing.Point(653, 43)
        Me.lbl_jumlah_delay.Name = "lbl_jumlah_delay"
        Me.lbl_jumlah_delay.Size = New System.Drawing.Size(171, 22)
        Me.lbl_jumlah_delay.TabIndex = 53
        Me.lbl_jumlah_delay.Text = "0"
        Me.lbl_jumlah_delay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(500, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 22)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Total Delay ="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_jumlah_rework
        '
        Me.lbl_jumlah_rework.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_rework.ForeColor = System.Drawing.Color.Black
        Me.lbl_jumlah_rework.Location = New System.Drawing.Point(653, 22)
        Me.lbl_jumlah_rework.Name = "lbl_jumlah_rework"
        Me.lbl_jumlah_rework.Size = New System.Drawing.Size(171, 21)
        Me.lbl_jumlah_rework.TabIndex = 51
        Me.lbl_jumlah_rework.Text = "0"
        Me.lbl_jumlah_rework.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(500, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 22)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Total Rework ="
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_jumlah_work
        '
        Me.lbl_jumlah_work.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_work.ForeColor = System.Drawing.Color.Black
        Me.lbl_jumlah_work.Location = New System.Drawing.Point(653, 2)
        Me.lbl_jumlah_work.Name = "lbl_jumlah_work"
        Me.lbl_jumlah_work.Size = New System.Drawing.Size(171, 20)
        Me.lbl_jumlah_work.TabIndex = 49
        Me.lbl_jumlah_work.Text = "0"
        Me.lbl_jumlah_work.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(538, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 21)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Total Work ="
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_BelumRealisasi
        '
        Me.Lbl_BelumRealisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BelumRealisasi.ForeColor = System.Drawing.Color.Black
        Me.Lbl_BelumRealisasi.Location = New System.Drawing.Point(357, 44)
        Me.Lbl_BelumRealisasi.Name = "Lbl_BelumRealisasi"
        Me.Lbl_BelumRealisasi.Size = New System.Drawing.Size(109, 21)
        Me.Lbl_BelumRealisasi.TabIndex = 47
        Me.Lbl_BelumRealisasi.Text = "0"
        Me.Lbl_BelumRealisasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(141, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 21)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Persentase Belum Realisasi="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_jumlah_spk
        '
        Me.lbl_jumlah_spk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_spk.ForeColor = System.Drawing.Color.Black
        Me.lbl_jumlah_spk.Location = New System.Drawing.Point(357, 23)
        Me.lbl_jumlah_spk.Name = "lbl_jumlah_spk"
        Me.lbl_jumlah_spk.Size = New System.Drawing.Size(109, 21)
        Me.lbl_jumlah_spk.TabIndex = 45
        Me.lbl_jumlah_spk.Text = "0"
        Me.lbl_jumlah_spk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(202, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 21)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Jumlah SPK ="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_jumlah_rph
        '
        Me.lbl_jumlah_rph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_rph.ForeColor = System.Drawing.Color.Black
        Me.lbl_jumlah_rph.Location = New System.Drawing.Point(357, -1)
        Me.lbl_jumlah_rph.Name = "lbl_jumlah_rph"
        Me.lbl_jumlah_rph.Size = New System.Drawing.Size(109, 21)
        Me.lbl_jumlah_rph.TabIndex = 43
        Me.lbl_jumlah_rph.Text = "0"
        Me.lbl_jumlah_rph.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(262, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Jumlah RPH ="
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cbo_status_realisasi)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 65)
        Me.Panel3.TabIndex = 5
        '
        'cbo_status_realisasi
        '
        Me.cbo_status_realisasi.FormattingEnabled = True
        Me.cbo_status_realisasi.Items.AddRange(New Object() {"ALL", "TEPAT WAKTU", "TERLAMBAT"})
        Me.cbo_status_realisasi.Location = New System.Drawing.Point(708, 1)
        Me.cbo_status_realisasi.Name = "cbo_status_realisasi"
        Me.cbo_status_realisasi.Size = New System.Drawing.Size(131, 21)
        Me.cbo_status_realisasi.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(541, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 21)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Status Entry Realisasi : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(924, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(62, 62)
        Me.cmdClear.TabIndex = 34
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(862, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(62, 62)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lueDep)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tglsampai)
        Me.Panel5.Controls.Add(Me.cmdGroup)
        Me.Panel5.Controls.Add(Me.tglDari)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(127, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(411, 65)
        Me.Panel5.TabIndex = 30
        '
        'lueDep
        '
        Me.lueDep.Location = New System.Drawing.Point(0, 21)
        Me.lueDep.Name = "lueDep"
        Me.lueDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDep.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama_Departemen")})
        Me.lueDep.Properties.DisplayMember = "Nama_Departemen"
        Me.lueDep.Properties.NullText = "[Pilih Departemen]"
        Me.lueDep.Properties.ValueMember = "Kd_Departemen"
        Me.lueDep.Size = New System.Drawing.Size(411, 20)
        Me.lueDep.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(160, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Sampai Tgl : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(257, 42)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(154, 20)
        Me.tglsampai.TabIndex = 25
        '
        'cmdGroup
        '
        Me.cmdGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdGroup.EditValue = ""
        Me.cmdGroup.Location = New System.Drawing.Point(0, 0)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGroup.Properties.Appearance.Options.UseFont = True
        Me.cmdGroup.Properties.Appearance.Options.UseTextOptions = True
        Me.cmdGroup.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmdGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdGroup.Properties.DropDownRows = 14
        Me.cmdGroup.Properties.HideSelection = False
        Me.cmdGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_rph", "No RPH"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("nama_barang", "Nama Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Jenis", "Jenis", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Merk", "Merk", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Tipe", "Tipe", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Sub_Tipe", "Sub Tipe", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Ukuran", "Ukuran", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Merk_Kain", "Kain", System.Windows.Forms.CheckState.Unchecked, False), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_spk", "No SPK"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl", "Tgl SPK"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("kegiatan", "Kegiatan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("kegiatan_spk", "SPK"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Pegawai", "Pegawai"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("group_kerja", "Group"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("nama_mesin", "Mesin"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_spk_man_rls", "No Realisasi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_realisasi", "Tgl Realisasi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_batas", "Tgl Batas Akhir Realisasi")})
        Me.cmdGroup.Properties.Mask.EditMask = "d"
        Me.cmdGroup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.cmdGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdGroup.Size = New System.Drawing.Size(411, 20)
        Me.cmdGroup.TabIndex = 28
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(0, 42)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(154, 20)
        Me.tglDari.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(127, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(0, 65)
        Me.Panel4.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Kolom : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(127, 65)
        Me.Panel6.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Departemen : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Pilih Kolom : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(413, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "Monitoring RPH VS Realisasi Terlambat"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.note_view
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ChartControl1
        '
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.Size = New System.Drawing.Size(300, 200)
        Me.ChartControl1.TabIndex = 0
        '
        'frmMonRphRealTepat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 480)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmMonRphRealTepat"
        Me.Text = "frmMonRphRealTepat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditTgl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.lueDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdGroup As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbo_status_realisasi As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_jumlah_delay As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah_rework As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah_work As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Lbl_BelumRealisasi As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah_spk As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumlah_rph As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_rph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tglRph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl_Target As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jam_target As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jam_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Merk_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTgl_SPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNo_Realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_realisasi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kegiatan_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents group_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_mesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_rph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_rework As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_delay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEditTgl As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
