<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonSJ
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonSJ))
        Me.Qty_balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_batal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_terima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_balik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_pol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNopol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSopir = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_krm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNopol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSopir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qty_balik
        '
        Me.Qty_balik.Caption = "Qty Balik"
        Me.Qty_balik.FieldName = "Qty_balik"
        Me.Qty_balik.Name = "Qty_balik"
        Me.Qty_balik.Visible = True
        Me.Qty_balik.VisibleIndex = 3
        Me.Qty_balik.Width = 86
        '
        'Qty_batal
        '
        Me.Qty_batal.Caption = "Qty Batal"
        Me.Qty_batal.DisplayFormat.FormatString = "n0"
        Me.Qty_batal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty_batal.FieldName = "Qty_batal"
        Me.Qty_batal.Name = "Qty_batal"
        Me.Qty_batal.Visible = True
        Me.Qty_batal.VisibleIndex = 4
        '
        'GVD
        '
        Me.GVD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.Empty.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.OddRow.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.Options.UseForeColor = True
        Me.GVD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVD.Appearance.Preview.Options.UseBackColor = True
        Me.GVD.Appearance.Preview.Options.UseFont = True
        Me.GVD.Appearance.Preview.Options.UseForeColor = True
        Me.GVD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.Row.Options.UseBackColor = True
        Me.GVD.Appearance.Row.Options.UseBorderColor = True
        Me.GVD.Appearance.Row.Options.UseForeColor = True
        Me.GVD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.VertLine.Options.UseBackColor = True
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_stok, Me.Qty_kirim, Me.Kd_satuan, Me.Qty_balik, Me.Keterangan, Me.Qty_batal})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.Qty_balik
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.Qty_batal
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = 0
        Me.GVD.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GVD.GridControl = Me.GC
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.Editable = False
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.OptionsView.ShowIndicator = False
        '
        'Kd_stok
        '
        Me.Kd_stok.Caption = "Barang"
        Me.Kd_stok.FieldName = "Nama_Barang"
        Me.Kd_stok.Name = "Kd_stok"
        Me.Kd_stok.Visible = True
        Me.Kd_stok.VisibleIndex = 0
        Me.Kd_stok.Width = 428
        '
        'Qty_kirim
        '
        Me.Qty_kirim.Caption = "Qty Kirim"
        Me.Qty_kirim.FieldName = "Qty_kirim"
        Me.Qty_kirim.Name = "Qty_kirim"
        Me.Qty_kirim.Visible = True
        Me.Qty_kirim.VisibleIndex = 2
        Me.Qty_kirim.Width = 80
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 1
        Me.Kd_satuan.Width = 82
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        Me.Keterangan.Width = 281
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVD
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 85)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repNopol, Me.repSopir})
        Me.GC.Size = New System.Drawing.Size(961, 182)
        Me.GC.TabIndex = 3
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVD})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sj, Me.No_sp, Me.Tgl_kirim, Me.Tgl_terima, Me.Tgl_balik, Me.DPB, Me.No_pol, Me.sopir, Me.no_krm, Me.GridColumn1})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowIndicator = False
        '
        'no_sj
        '
        Me.no_sj.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.no_sj.AppearanceHeader.Options.UseForeColor = True
        Me.no_sj.Caption = "NOMOR SJ"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 0
        '
        'No_sp
        '
        Me.No_sp.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.No_sp.AppearanceHeader.Options.UseForeColor = True
        Me.No_sp.Caption = "NOMOR SP"
        Me.No_sp.FieldName = "No_sp"
        Me.No_sp.Name = "No_sp"
        Me.No_sp.Visible = True
        Me.No_sp.VisibleIndex = 1
        '
        'Tgl_kirim
        '
        Me.Tgl_kirim.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Tgl_kirim.AppearanceHeader.Options.UseForeColor = True
        Me.Tgl_kirim.Caption = "Tgl Kirim"
        Me.Tgl_kirim.FieldName = "Tgl_kirim"
        Me.Tgl_kirim.Name = "Tgl_kirim"
        Me.Tgl_kirim.Visible = True
        Me.Tgl_kirim.VisibleIndex = 5
        '
        'Tgl_terima
        '
        Me.Tgl_terima.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Tgl_terima.AppearanceHeader.Options.UseForeColor = True
        Me.Tgl_terima.Caption = "Tgl Terima"
        Me.Tgl_terima.FieldName = "Tgl_terima"
        Me.Tgl_terima.Name = "Tgl_terima"
        Me.Tgl_terima.Visible = True
        Me.Tgl_terima.VisibleIndex = 6
        '
        'Tgl_balik
        '
        Me.Tgl_balik.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Tgl_balik.AppearanceHeader.Options.UseForeColor = True
        Me.Tgl_balik.Caption = "Tgl Balik"
        Me.Tgl_balik.FieldName = "Tgl_balik"
        Me.Tgl_balik.Name = "Tgl_balik"
        Me.Tgl_balik.Visible = True
        Me.Tgl_balik.VisibleIndex = 7
        '
        'DPB
        '
        Me.DPB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DPB.AppearanceHeader.Options.UseForeColor = True
        Me.DPB.Caption = "Nomor DPB"
        Me.DPB.FieldName = "no_dpb"
        Me.DPB.Name = "DPB"
        '
        'No_pol
        '
        Me.No_pol.AppearanceHeader.BackColor = System.Drawing.Color.Black
        Me.No_pol.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.No_pol.AppearanceHeader.Options.UseBackColor = True
        Me.No_pol.AppearanceHeader.Options.UseForeColor = True
        Me.No_pol.Caption = "Nopol"
        Me.No_pol.ColumnEdit = Me.repNopol
        Me.No_pol.FieldName = "No_pol"
        Me.No_pol.Name = "No_pol"
        Me.No_pol.OptionsColumn.AllowEdit = False
        Me.No_pol.OptionsColumn.ReadOnly = True
        Me.No_pol.Visible = True
        Me.No_pol.VisibleIndex = 3
        '
        'repNopol
        '
        Me.repNopol.AutoHeight = False
        Me.repNopol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repNopol.DisplayMember = "no_polisi"
        Me.repNopol.Name = "repNopol"
        Me.repNopol.NullText = ""
        Me.repNopol.ValueMember = "kode_kendaraan"
        '
        'sopir
        '
        Me.sopir.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.sopir.AppearanceCell.Options.UseForeColor = True
        Me.sopir.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.sopir.AppearanceHeader.Options.UseForeColor = True
        Me.sopir.Caption = "Sopir"
        Me.sopir.ColumnEdit = Me.repSopir
        Me.sopir.FieldName = "Kd_sopir"
        Me.sopir.Name = "sopir"
        Me.sopir.Visible = True
        Me.sopir.VisibleIndex = 2
        '
        'repSopir
        '
        Me.repSopir.AutoHeight = False
        Me.repSopir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSopir.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", "Name1")})
        Me.repSopir.DisplayMember = "Nama_Sopir"
        Me.repSopir.Name = "repSopir"
        Me.repSopir.NullText = "[??]"
        Me.repSopir.ValueMember = "Kode_Sopir"
        '
        'no_krm
        '
        Me.no_krm.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.no_krm.AppearanceHeader.Options.UseForeColor = True
        Me.no_krm.Caption = "Nomor Kirim"
        Me.no_krm.FieldName = "no_krm"
        Me.no_krm.Name = "no_krm"
        Me.no_krm.Visible = True
        Me.no_krm.VisibleIndex = 4
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn1.Caption = "Nota"
        Me.GridColumn1.FieldName = "sts_nota"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 267)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.tglsampai)
        Me.Panel2.Controls.Add(Me.tglDari)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 48)
        Me.Panel2.TabIndex = 2
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(293, 3)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(53, 41)
        Me.cmdRefresh.TabIndex = 41
        Me.cmdRefresh.ToolTip = "Refresh Data"
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(133, 24)
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
        Me.tglsampai.TabIndex = 40
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(133, 3)
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
        Me.tglDari.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 48)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 37)
        Me.Panel1.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblJudul.Appearance.Options.UseFont = True
        Me.lblJudul.Appearance.Options.UseForeColor = True
        Me.lblJudul.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblJudul.Location = New System.Drawing.Point(44, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(275, 37)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "  MONITORING SURAT JALAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmMonSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 267)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonSJ"
        Me.Text = "XtraForm1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNopol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSopir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_terima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_balik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_pol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNopol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSopir As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_krm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_batal As DevExpress.XtraGrid.Columns.GridColumn
End Class
