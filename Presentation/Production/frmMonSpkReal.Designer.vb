﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonSpkReal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonSpkReal))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_rph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kegiatan_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Merk_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_realisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_real = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.group_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_mesin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_rework = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_delay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.selisih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
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
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 102)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(1028, 378)
        Me.GC.TabIndex = 6
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
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
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
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_rph, Me.kegiatan, Me.kegiatan_spk, Me.nama_barang, Me.jumlah, Me.Nama_Jenis, Me.Nama_Merk, Me.Nama_Tipe, Me.Nama_Sub_Tipe, Me.Nama_Ukuran, Me.Merk_Kain, Me.no_spk, Me.tgl_realisasi, Me.no_realisasi, Me.tgl_real, Me.Nama_Pegawai, Me.group_kerja, Me.nama_mesin, Me.jumlah_kerja, Me.jumlah_rework, Me.jumlah_delay, Me.selisih})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[jumlah] != [jumlah_kerja]"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GV.OptionsPrint.UsePrintStyles = True
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupedColumns = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Skin"
        Me.GV.RowHeight = 1
        '
        'no_rph
        '
        Me.no_rph.AppearanceHeader.Options.UseTextOptions = True
        Me.no_rph.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_rph.Caption = "RPH"
        Me.no_rph.FieldName = "no_rph"
        Me.no_rph.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.no_rph.Name = "no_rph"
        Me.no_rph.OptionsColumn.AllowEdit = False
        Me.no_rph.OptionsColumn.ReadOnly = True
        Me.no_rph.Visible = True
        Me.no_rph.VisibleIndex = 0
        Me.no_rph.Width = 142
        '
        'kegiatan
        '
        Me.kegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.kegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kegiatan.Caption = "Kegiatan"
        Me.kegiatan.FieldName = "kegiatan"
        Me.kegiatan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.kegiatan.Name = "kegiatan"
        Me.kegiatan.OptionsColumn.AllowEdit = False
        Me.kegiatan.OptionsColumn.ReadOnly = True
        Me.kegiatan.Visible = True
        Me.kegiatan.VisibleIndex = 1
        Me.kegiatan.Width = 100
        '
        'kegiatan_spk
        '
        Me.kegiatan_spk.AppearanceHeader.Options.UseTextOptions = True
        Me.kegiatan_spk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kegiatan_spk.Caption = "Kegiatan SPK"
        Me.kegiatan_spk.FieldName = "kegiatan_spk"
        Me.kegiatan_spk.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.kegiatan_spk.Name = "kegiatan_spk"
        Me.kegiatan_spk.OptionsColumn.AllowEdit = False
        Me.kegiatan_spk.OptionsColumn.ReadOnly = True
        Me.kegiatan_spk.Visible = True
        Me.kegiatan_spk.VisibleIndex = 2
        Me.kegiatan_spk.Width = 126
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.Caption = "Barang"
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.nama_barang.OptionsColumn.ReadOnly = True
        Me.nama_barang.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.nama_barang.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 3
        Me.nama_barang.Width = 242
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Qty"
        Me.jumlah.DisplayFormat.FormatString = "n0"
        Me.jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowEdit = False
        Me.jumlah.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah.OptionsColumn.ReadOnly = True
        Me.jumlah.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 4
        Me.jumlah.Width = 60
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Jenis.Caption = "Jenis"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.OptionsColumn.AllowEdit = False
        Me.Nama_Jenis.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Nama_Jenis.OptionsColumn.ReadOnly = True
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 5
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
        Me.Nama_Merk.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Nama_Merk.OptionsColumn.ReadOnly = True
        Me.Nama_Merk.Visible = True
        Me.Nama_Merk.VisibleIndex = 6
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
        Me.Nama_Tipe.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Nama_Tipe.OptionsColumn.ReadOnly = True
        Me.Nama_Tipe.Visible = True
        Me.Nama_Tipe.VisibleIndex = 7
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
        Me.Nama_Sub_Tipe.VisibleIndex = 8
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
        Me.Nama_Ukuran.OptionsColumn.AllowIncrementalSearch = False
        Me.Nama_Ukuran.OptionsColumn.ReadOnly = True
        Me.Nama_Ukuran.Visible = True
        Me.Nama_Ukuran.VisibleIndex = 9
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
        Me.Merk_Kain.OptionsColumn.AllowIncrementalSearch = False
        Me.Merk_Kain.OptionsColumn.ReadOnly = True
        Me.Merk_Kain.Visible = True
        Me.Merk_Kain.VisibleIndex = 10
        Me.Merk_Kain.Width = 150
        '
        'no_spk
        '
        Me.no_spk.AppearanceHeader.Options.UseTextOptions = True
        Me.no_spk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_spk.Caption = "No SPK"
        Me.no_spk.FieldName = "no_spk"
        Me.no_spk.Name = "no_spk"
        Me.no_spk.OptionsColumn.AllowEdit = False
        Me.no_spk.OptionsColumn.ReadOnly = True
        Me.no_spk.Visible = True
        Me.no_spk.VisibleIndex = 11
        Me.no_spk.Width = 150
        '
        'tgl_realisasi
        '
        Me.tgl_realisasi.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_realisasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_realisasi.Caption = "Tgl SPK"
        Me.tgl_realisasi.FieldName = "tgl"
        Me.tgl_realisasi.Name = "tgl_realisasi"
        Me.tgl_realisasi.OptionsColumn.AllowEdit = False
        Me.tgl_realisasi.OptionsColumn.ReadOnly = True
        Me.tgl_realisasi.Visible = True
        Me.tgl_realisasi.VisibleIndex = 12
        '
        'no_realisasi
        '
        Me.no_realisasi.Caption = "No Realisasi"
        Me.no_realisasi.FieldName = "no_spk_man_rls"
        Me.no_realisasi.Name = "no_realisasi"
        Me.no_realisasi.OptionsColumn.AllowEdit = False
        Me.no_realisasi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.no_realisasi.OptionsColumn.ReadOnly = True
        Me.no_realisasi.Visible = True
        Me.no_realisasi.VisibleIndex = 13
        '
        'tgl_real
        '
        Me.tgl_real.Caption = "Tgl Realisasi"
        Me.tgl_real.FieldName = "tgl_realisasi"
        Me.tgl_real.Name = "tgl_real"
        Me.tgl_real.OptionsColumn.AllowEdit = False
        Me.tgl_real.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_real.OptionsColumn.ReadOnly = True
        Me.tgl_real.Visible = True
        Me.tgl_real.VisibleIndex = 14
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
        Me.Nama_Pegawai.VisibleIndex = 15
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
        Me.group_kerja.VisibleIndex = 16
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
        Me.nama_mesin.OptionsColumn.ReadOnly = True
        Me.nama_mesin.Visible = True
        Me.nama_mesin.VisibleIndex = 17
        Me.nama_mesin.Width = 200
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
        Me.jumlah_kerja.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.OptionsColumn.AllowEdit = False
        Me.jumlah_kerja.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_kerja.OptionsColumn.ReadOnly = True
        Me.jumlah_kerja.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.jumlah_kerja.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_kerja.Visible = True
        Me.jumlah_kerja.VisibleIndex = 18
        Me.jumlah_kerja.Width = 60
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
        Me.jumlah_rework.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.jumlah_rework.Name = "jumlah_rework"
        Me.jumlah_rework.OptionsColumn.AllowEdit = False
        Me.jumlah_rework.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_rework.OptionsColumn.ReadOnly = True
        Me.jumlah_rework.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.jumlah_rework.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_rework.Visible = True
        Me.jumlah_rework.VisibleIndex = 19
        Me.jumlah_rework.Width = 60
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
        Me.jumlah_delay.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.jumlah_delay.Name = "jumlah_delay"
        Me.jumlah_delay.OptionsColumn.AllowEdit = False
        Me.jumlah_delay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah_delay.OptionsColumn.ReadOnly = True
        Me.jumlah_delay.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.jumlah_delay.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_delay.Visible = True
        Me.jumlah_delay.VisibleIndex = 20
        Me.jumlah_delay.Width = 60
        '
        'selisih
        '
        Me.selisih.AppearanceCell.Options.UseTextOptions = True
        Me.selisih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.selisih.AppearanceHeader.Options.UseTextOptions = True
        Me.selisih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.selisih.Caption = "Diff"
        Me.selisih.DisplayFormat.FormatString = "n0"
        Me.selisih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.selisih.FieldName = "selisih"
        Me.selisih.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.selisih.Name = "selisih"
        Me.selisih.OptionsColumn.AllowEdit = False
        Me.selisih.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.selisih.OptionsColumn.ReadOnly = True
        Me.selisih.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.selisih.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.selisih.Visible = True
        Me.selisih.VisibleIndex = 21
        Me.selisih.Width = 60
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(601, 0)
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
        Me.cmdRefresh.Location = New System.Drawing.Point(539, 0)
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
        Me.cmdGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Jenis", "Jenis"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Merk", "Merk"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Tipe", "Tipe"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Sub_Tipe", "Sub Tipe"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Ukuran", "Ukuran"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Merk_Kain", "Kain"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_spk", "No SPK"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl", "Tgl SPK"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_realisasi", "Tanggal Realisasi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_spk_man_rls", "No Realisasi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Pegawai", "Pegawai"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("group_kerja", "Group"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("nama_mesin", "Mesin")})
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
        Me.lblJudul.Text = "Monitoring SPK VS Realisasi"
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
        'frmMonSpkReal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 480)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmMonSpkReal"
        Me.Text = "frmMonSpkReal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Merk_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kegiatan_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents group_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_mesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_rework As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_delay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lueDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents no_realisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_real As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents selisih As DevExpress.XtraGrid.Columns.GridColumn
End Class
