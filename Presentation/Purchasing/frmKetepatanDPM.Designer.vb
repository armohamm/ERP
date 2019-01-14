<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKetepatanDPM
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKetepatanDPM))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_Seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lokupbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_PR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcApprvDPM = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVApprvDPM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.No_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_dpm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_diperlukan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatusDPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_pr1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.daydpm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cek_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_datang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.daypr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.daypo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cek_gd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_qtypr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_QtyPo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_QtyIn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKetBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qtybelumdatang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.noseq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.PrintPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbkolom = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbl_PO3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_PO2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbl_PO1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Lbl_BelumProseDPM = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lbl_DPMTidakSesuai = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_DPM_Sesuai = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cbkolom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_Seq, Me.Kd_Stok, Me.Satuan, Me.Qty, Me.Qty_PR, Me.Qty_sisa})
        Me.GridView1.GridControl = Me.GcApprvDPM
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.ExpandAllDetails = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.No_Seq, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'No_Seq
        '
        Me.No_Seq.Caption = "Nomor"
        Me.No_Seq.FieldName = "No_Seq"
        Me.No_Seq.MinWidth = 10
        Me.No_Seq.Name = "No_Seq"
        Me.No_Seq.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.No_Seq.Visible = True
        Me.No_Seq.VisibleIndex = 0
        Me.No_Seq.Width = 80
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Nama"
        Me.Kd_Stok.ColumnEdit = Me.Lokupbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.OptionsColumn.AllowEdit = False
        Me.Kd_Stok.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 521
        '
        'Lokupbarang
        '
        Me.Lokupbarang.AutoHeight = False
        Me.Lokupbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lokupbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode")})
        Me.Lokupbarang.DisplayMember = "Nama_Barang"
        Me.Lokupbarang.Name = "Lokupbarang"
        Me.Lokupbarang.ValueMember = "Kode_Barang"
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        Me.Satuan.Width = 77
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "d2"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 81
        '
        'Qty_PR
        '
        Me.Qty_PR.Caption = "Qty Purc"
        Me.Qty_PR.FieldName = "Qty_PR"
        Me.Qty_PR.Name = "Qty_PR"
        Me.Qty_PR.OptionsColumn.AllowEdit = False
        Me.Qty_PR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Qty_PR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_PR.Visible = True
        Me.Qty_PR.VisibleIndex = 4
        Me.Qty_PR.Width = 81
        '
        'Qty_sisa
        '
        Me.Qty_sisa.Caption = "Sisa"
        Me.Qty_sisa.FieldName = "Qty_sisa"
        Me.Qty_sisa.Name = "Qty_sisa"
        Me.Qty_sisa.OptionsColumn.AllowEdit = False
        Me.Qty_sisa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Qty_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_sisa.Visible = True
        Me.Qty_sisa.VisibleIndex = 5
        Me.Qty_sisa.Width = 100
        '
        'GcApprvDPM
        '
        Me.GcApprvDPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvDPM.EmbeddedNavigator.Enabled = False
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GridView2
        GridLevelNode2.RelationName = "Level2"
        Me.GcApprvDPM.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GcApprvDPM.Location = New System.Drawing.Point(0, 48)
        Me.GcApprvDPM.MainView = Me.GVApprvDPM
        Me.GcApprvDPM.Name = "GcApprvDPM"
        Me.GcApprvDPM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupDivisi, Me.RBrecstat, Me.Lokupbarang})
        Me.GcApprvDPM.ShowOnlyPredefinedDetails = True
        Me.GcApprvDPM.Size = New System.Drawing.Size(961, 313)
        Me.GcApprvDPM.TabIndex = 137
        Me.GcApprvDPM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GVApprvDPM, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_pr, Me.tgl_pr, Me.GridColumn3})
        Me.GridView2.GridControl = Me.GcApprvDPM
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsPrint.ExpandAllDetails = True
        Me.GridView2.OptionsPrint.PrintDetails = True
        Me.GridView2.OptionsPrint.PrintFilterInfo = True
        Me.GridView2.OptionsPrint.PrintHorzLines = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'no_pr
        '
        Me.no_pr.Caption = "No PR"
        Me.no_pr.FieldName = "no_pr"
        Me.no_pr.Name = "no_pr"
        Me.no_pr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.no_pr.Visible = True
        Me.no_pr.VisibleIndex = 0
        '
        'tgl_pr
        '
        Me.tgl_pr.Caption = "Tanggal"
        Me.tgl_pr.FieldName = "tgl_pr"
        Me.tgl_pr.Name = "tgl_pr"
        Me.tgl_pr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_pr.Visible = True
        Me.tgl_pr.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Qty PR"
        Me.GridColumn3.FieldName = "qty_pr"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GVApprvDPM
        '
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Empty.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVApprvDPM.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVApprvDPM.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVApprvDPM.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseFont = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.OddRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Preview.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.Row.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Row.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVApprvDPM.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.VertLine.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GVApprvDPM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GVApprvDPM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.Departemen, Me.No_DPM, Me.kd_stok1, Me.qty_dpm, Me.Tgl_DPM, Me.tgl_diperlukan, Me.colStatusDPM, Me.tgl_pr1, Me.daydpm, Me.cek_po, Me.tgl_po, Me.tgl_datang, Me.daypr, Me.no_po, Me.tgl_trans, Me.daypo, Me.cek_gd, Me.col_qtypr, Me.Col_QtyPo, Me.col_QtyIn, Me.colKetBarang, Me.qtybelumdatang, Me.qty_qc_pass, Me.noseq})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.qtybelumdatang
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[status_approve]  == 'REJECT'"
        Me.GVApprvDPM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GVApprvDPM.GridControl = Me.GcApprvDPM
        Me.GVApprvDPM.GroupPanelText = "Geser nama kolom kemari untuk mengelompokan data berdasarkan kolom tersebut"
        Me.GVApprvDPM.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.Name = "GVApprvDPM"
        Me.GVApprvDPM.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVApprvDPM.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVApprvDPM.OptionsBehavior.ReadOnly = True
        Me.GVApprvDPM.OptionsPrint.ExpandAllDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintFilterInfo = True
        Me.GVApprvDPM.OptionsPrint.PrintHorzLines = False
        Me.GVApprvDPM.OptionsPrint.UsePrintStyles = True
        Me.GVApprvDPM.OptionsView.AllowCellMerge = True
        Me.GVApprvDPM.OptionsView.ColumnAutoWidth = False
        Me.GVApprvDPM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvDPM.OptionsView.RowAutoHeight = True
        Me.GVApprvDPM.OptionsView.ShowViewCaption = True
        Me.GVApprvDPM.PaintStyleName = "WindowsXP"
        Me.GVApprvDPM.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.ViewCaption = "MONITORING KETEPATAN DPM"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tipe_trans.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.tipe_trans.AppearanceCell.Options.UseBackColor = True
        Me.tipe_trans.AppearanceCell.Options.UseBorderColor = True
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tipe_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Jenis DPM"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.AllowEdit = False
        Me.tipe_trans.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tipe_trans.OptionsColumn.AllowMove = False
        '
        'Departemen
        '
        Me.Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Departemen.Caption = "Divisi"
        Me.Departemen.ColumnEdit = Me.lookupDivisi
        Me.Departemen.FieldName = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.OptionsColumn.AllowEdit = False
        Me.Departemen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Departemen.Width = 89
        '
        'lookupDivisi
        '
        Me.lookupDivisi.AutoHeight = False
        Me.lookupDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupDivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Divisi")})
        Me.lookupDivisi.Name = "lookupDivisi"
        Me.lookupDivisi.NullText = "Klik disini"
        '
        'No_DPM
        '
        Me.No_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.No_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_DPM.Caption = "No DPM"
        Me.No_DPM.FieldName = "No_DPM"
        Me.No_DPM.Name = "No_DPM"
        Me.No_DPM.OptionsColumn.AllowEdit = False
        Me.No_DPM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.No_DPM.Width = 179
        '
        'kd_stok1
        '
        Me.kd_stok1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_stok1.AppearanceHeader.Options.UseFont = True
        Me.kd_stok1.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok1.Caption = "Nama Barang"
        Me.kd_stok1.ColumnEdit = Me.Lokupbarang
        Me.kd_stok1.FieldName = "Kd_Stok"
        Me.kd_stok1.Name = "kd_stok1"
        Me.kd_stok1.OptionsColumn.AllowEdit = False
        Me.kd_stok1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.kd_stok1.Width = 297
        '
        'qty_dpm
        '
        Me.qty_dpm.Caption = "Qty DPM"
        Me.qty_dpm.DisplayFormat.FormatString = "N2"
        Me.qty_dpm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_dpm.FieldName = "Qty"
        Me.qty_dpm.Name = "qty_dpm"
        Me.qty_dpm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Tgl_DPM
        '
        Me.Tgl_DPM.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.Tgl_DPM.AppearanceCell.Options.UseBackColor = True
        Me.Tgl_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.Tgl_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tgl_DPM.Caption = "Tgl.  DPM "
        Me.Tgl_DPM.FieldName = "Tgl_DPM"
        Me.Tgl_DPM.Name = "Tgl_DPM"
        Me.Tgl_DPM.OptionsColumn.AllowEdit = False
        Me.Tgl_DPM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Tgl_DPM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.Tgl_DPM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        Me.Tgl_DPM.Width = 143
        '
        'tgl_diperlukan
        '
        Me.tgl_diperlukan.Caption = "Tgl. Diperlukan DPM"
        Me.tgl_diperlukan.FieldName = "Tgl_Diperlukan"
        Me.tgl_diperlukan.Name = "tgl_diperlukan"
        Me.tgl_diperlukan.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_diperlukan.Width = 135
        '
        'colStatusDPM
        '
        Me.colStatusDPM.Caption = "Status Approve"
        Me.colStatusDPM.FieldName = "status_approve"
        Me.colStatusDPM.Name = "colStatusDPM"
        Me.colStatusDPM.Visible = True
        Me.colStatusDPM.VisibleIndex = 0
        '
        'tgl_pr1
        '
        Me.tgl_pr1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_pr1.AppearanceCell.Options.UseBackColor = True
        Me.tgl_pr1.Caption = "Tgl. PR"
        Me.tgl_pr1.FieldName = "tgl_pr"
        Me.tgl_pr1.Name = "tgl_pr1"
        Me.tgl_pr1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_pr1.Width = 104
        '
        'daydpm
        '
        Me.daydpm.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.daydpm.AppearanceCell.Options.UseFont = True
        Me.daydpm.AppearanceCell.Options.UseTextOptions = True
        Me.daydpm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.daydpm.Caption = "Selisih DPM-PR"
        Me.daydpm.FieldName = "daydpm"
        Me.daydpm.Name = "daydpm"
        Me.daydpm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.daydpm.Width = 126
        '
        'cek_po
        '
        Me.cek_po.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.cek_po.AppearanceCell.Options.UseBackColor = True
        Me.cek_po.AppearanceCell.Options.UseTextOptions = True
        Me.cek_po.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cek_po.AppearanceHeader.Options.UseTextOptions = True
        Me.cek_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cek_po.Caption = "cek DPM-PR"
        Me.cek_po.FieldName = "cek_po"
        Me.cek_po.Name = "cek_po"
        Me.cek_po.UnboundExpression = "Iif(IsNullOrEmpty([daydpm]),'Blm Proses',Iif([daydpm]<=7,'Sesuai','Tdk Sesuai') )" & _
            ""
        Me.cek_po.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.cek_po.Width = 116
        '
        'tgl_po
        '
        Me.tgl_po.Caption = "Tgl. PO"
        Me.tgl_po.FieldName = "tgl_po"
        Me.tgl_po.Name = "tgl_po"
        Me.tgl_po.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_po.Width = 108
        '
        'tgl_datang
        '
        Me.tgl_datang.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_datang.AppearanceCell.Options.UseBackColor = True
        Me.tgl_datang.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_datang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_datang.Caption = "Tgl.  Janji Datang"
        Me.tgl_datang.FieldName = "tgl_kirim"
        Me.tgl_datang.Name = "tgl_datang"
        Me.tgl_datang.OptionsColumn.AllowEdit = False
        Me.tgl_datang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_datang.Width = 138
        '
        'daypr
        '
        Me.daypr.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.daypr.AppearanceCell.Options.UseFont = True
        Me.daypr.AppearanceCell.Options.UseTextOptions = True
        Me.daypr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.daypr.Caption = "Selisih PR-PO"
        Me.daypr.FieldName = "daypr"
        Me.daypr.Name = "daypr"
        Me.daypr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.daypr.Width = 94
        '
        'no_po
        '
        Me.no_po.AppearanceHeader.Options.UseTextOptions = True
        Me.no_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_po.Caption = "No. PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.no_po.Width = 183
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_trans.AppearanceCell.Options.UseBackColor = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tgl.  Masuk GD"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_trans.Width = 184
        '
        'daypo
        '
        Me.daypo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.daypo.AppearanceCell.Options.UseFont = True
        Me.daypo.AppearanceCell.Options.UseTextOptions = True
        Me.daypo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.daypo.Caption = "Selisih PO-GD"
        Me.daypo.FieldName = "daypo"
        Me.daypo.Name = "daypo"
        Me.daypo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.daypo.Width = 99
        '
        'cek_gd
        '
        Me.cek_gd.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.cek_gd.AppearanceCell.Options.UseBackColor = True
        Me.cek_gd.AppearanceCell.Options.UseTextOptions = True
        Me.cek_gd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cek_gd.AppearanceHeader.Options.UseTextOptions = True
        Me.cek_gd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cek_gd.Caption = "Cek PO-GD"
        Me.cek_gd.FieldName = "cek_gd"
        Me.cek_gd.Name = "cek_gd"
        Me.cek_gd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.cek_gd.UnboundExpression = "iif(IsNullOrEmpty([tgl_trans]),'Blm Proses',Iif([tgl_trans]<=[tgl_kirim] ,'Sesuai" & _
            "'  ,'Tidak SS' ))"
        Me.cek_gd.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.cek_gd.Width = 124
        '
        'col_qtypr
        '
        Me.col_qtypr.Caption = "Qty PR"
        Me.col_qtypr.DisplayFormat.FormatString = "N2"
        Me.col_qtypr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_qtypr.FieldName = "qty_pr"
        Me.col_qtypr.Name = "col_qtypr"
        Me.col_qtypr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Col_QtyPo
        '
        Me.Col_QtyPo.Caption = "Qty PO"
        Me.Col_QtyPo.DisplayFormat.FormatString = "N2"
        Me.Col_QtyPo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_QtyPo.FieldName = "qty_po"
        Me.Col_QtyPo.Name = "Col_QtyPo"
        Me.Col_QtyPo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_QtyIn
        '
        Me.col_QtyIn.Caption = "Qty Gudang IN"
        Me.col_QtyIn.DisplayFormat.FormatString = "N2"
        Me.col_QtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_QtyIn.FieldName = "qty_in"
        Me.col_QtyIn.Name = "col_QtyIn"
        Me.col_QtyIn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'colKetBarang
        '
        Me.colKetBarang.Caption = "Keterangan Barang"
        Me.colKetBarang.FieldName = "Keterangan_barang"
        Me.colKetBarang.Name = "colKetBarang"
        Me.colKetBarang.OptionsColumn.AllowEdit = False
        Me.colKetBarang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'qtybelumdatang
        '
        Me.qtybelumdatang.Caption = "Qty Belum Datang"
        Me.qtybelumdatang.DisplayFormat.FormatString = "n2"
        Me.qtybelumdatang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qtybelumdatang.FieldName = "qtybelumdatang"
        Me.qtybelumdatang.Name = "qtybelumdatang"
        Me.qtybelumdatang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.Caption = "QTY Barang Datang"
        Me.qty_qc_pass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'noseq
        '
        Me.noseq.Caption = "no_seq"
        Me.noseq.FieldName = "no_seq"
        Me.noseq.Name = "noseq"
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'PrintPreviewRepositoryItemComboBox1
        '
        Me.PrintPreviewRepositoryItemComboBox1.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 474)
        Me.pnl.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcApprvDPM)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(961, 361)
        Me.Panel3.TabIndex = 139
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.cbkolom)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.tglsampai)
        Me.Panel4.Controls.Add(Me.cmdRefresh)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(961, 48)
        Me.Panel4.TabIndex = 138
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(651, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 46)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "s/d"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbkolom
        '
        Me.cbkolom.EditValue = ""
        Me.cbkolom.Location = New System.Drawing.Point(123, 14)
        Me.cbkolom.Name = "cbkolom"
        Me.cbkolom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbkolom.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tipe_trans", "Jenis DPM"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Departemen", "Divisi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("No_DPM", "Nomor DPM"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Kd_Stok", "Nama Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Qty", "Qty DPM"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Keterangan_barang", "Keterangan Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qty_qc_pass", "Qty Barang Datang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qtybelumdatang", "QtyBelumDatang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Tgl_DPM", "Tgl. DPM"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Tgl_Diperlukan", "Tgl. Perlu DPM"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_pr", "Tgl. PR"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qty_pr", "Qty PR"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("daydpm", "Deviasi DPM-PR"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_po", "Tgl. PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qty_po", "Qty PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("daypr", "Deviasi PR-PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_kirim", "Tgl. Janji Kedatangan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_po", "Nomor PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_trans", "Tgl. Masuk GD"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qty_in", "Qty In"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("daypo", "Deviasi PO-GD"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("cek_gd", "Cek Gdng")})
        Me.cbkolom.Size = New System.Drawing.Size(232, 20)
        Me.cbkolom.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 46)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Pilih Kolom : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(361, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 46)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(484, 14)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "yyyyMMdd"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.Mask.EditMask = "D"
        Me.tglDari.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(166, 20)
        Me.tglDari.TabIndex = 27
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(707, 13)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "yyyyMMdd"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.Mask.EditMask = "D"
        Me.tglsampai.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(143, 20)
        Me.tglsampai.TabIndex = 28
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(866, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(71, 42)
        Me.cmdRefresh.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lbl_PO3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lbl_PO2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lbl_PO1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Lbl_BelumProseDPM)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Lbl_DPMTidakSesuai)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lbl_DPM_Sesuai)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 78)
        Me.Panel2.TabIndex = 138
        '
        'lbl_PO3
        '
        Me.lbl_PO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PO3.ForeColor = System.Drawing.Color.Black
        Me.lbl_PO3.Location = New System.Drawing.Point(767, 47)
        Me.lbl_PO3.Name = "lbl_PO3"
        Me.lbl_PO3.Size = New System.Drawing.Size(171, 26)
        Me.lbl_PO3.TabIndex = 41
        Me.lbl_PO3.Text = "0"
        Me.lbl_PO3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(614, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 26)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Belum Proses PO-BME ="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_PO2
        '
        Me.lbl_PO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PO2.ForeColor = System.Drawing.Color.Black
        Me.lbl_PO2.Location = New System.Drawing.Point(767, 26)
        Me.lbl_PO2.Name = "lbl_PO2"
        Me.lbl_PO2.Size = New System.Drawing.Size(171, 26)
        Me.lbl_PO2.TabIndex = 39
        Me.lbl_PO2.Text = "0"
        Me.lbl_PO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(614, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 26)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Tidak Sesuai PO-BME ="
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_PO1
        '
        Me.lbl_PO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PO1.ForeColor = System.Drawing.Color.Black
        Me.lbl_PO1.Location = New System.Drawing.Point(767, 6)
        Me.lbl_PO1.Name = "lbl_PO1"
        Me.lbl_PO1.Size = New System.Drawing.Size(171, 26)
        Me.lbl_PO1.TabIndex = 37
        Me.lbl_PO1.Text = "0"
        Me.lbl_PO1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(652, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 26)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Sesuai PO-BME ="
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_BelumProseDPM
        '
        Me.Lbl_BelumProseDPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BelumProseDPM.ForeColor = System.Drawing.Color.Black
        Me.Lbl_BelumProseDPM.Location = New System.Drawing.Point(468, 49)
        Me.Lbl_BelumProseDPM.Name = "Lbl_BelumProseDPM"
        Me.Lbl_BelumProseDPM.Size = New System.Drawing.Size(109, 21)
        Me.Lbl_BelumProseDPM.TabIndex = 35
        Me.Lbl_BelumProseDPM.Text = "0"
        Me.Lbl_BelumProseDPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(316, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Belum Proses DPM-PR ="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_DPMTidakSesuai
        '
        Me.Lbl_DPMTidakSesuai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DPMTidakSesuai.ForeColor = System.Drawing.Color.Black
        Me.Lbl_DPMTidakSesuai.Location = New System.Drawing.Point(468, 28)
        Me.Lbl_DPMTidakSesuai.Name = "Lbl_DPMTidakSesuai"
        Me.Lbl_DPMTidakSesuai.Size = New System.Drawing.Size(109, 21)
        Me.Lbl_DPMTidakSesuai.TabIndex = 33
        Me.Lbl_DPMTidakSesuai.Text = "0"
        Me.Lbl_DPMTidakSesuai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(316, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tidak Sesuai DPM-PR ="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_DPM_Sesuai
        '
        Me.lbl_DPM_Sesuai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DPM_Sesuai.ForeColor = System.Drawing.Color.Black
        Me.lbl_DPM_Sesuai.Location = New System.Drawing.Point(468, 8)
        Me.lbl_DPM_Sesuai.Name = "lbl_DPM_Sesuai"
        Me.lbl_DPM_Sesuai.Size = New System.Drawing.Size(109, 21)
        Me.lbl_DPM_Sesuai.TabIndex = 31
        Me.lbl_DPM_Sesuai.Text = "0"
        Me.lbl_DPM_Sesuai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(354, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Sesuai DPM-PR ="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(181, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(105, 15)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Update"
        Me.btnSimpan.UseVisualStyleBackColor = False
        Me.btnSimpan.Visible = False
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
        Me.Panel1.Size = New System.Drawing.Size(961, 35)
        Me.Panel1.TabIndex = 137
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MONITORING KETEPATAN DPM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmKetepatanDPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 474)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmKetepatanDPM"
        Me.Text = "MONITORING KETEPATAN DPM"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cbkolom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents GcApprvDPM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lokupbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_PR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVApprvDPM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_datang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents kd_stok1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbkolom As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cek_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cek_gd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_pr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents daydpm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents daypr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_diperlukan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents daypo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_DPM_Sesuai As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DPMTidakSesuai As System.Windows.Forms.Label
    Friend WithEvents Lbl_BelumProseDPM As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_PO3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_PO2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_PO1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents qty_dpm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qtypr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_QtyPo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_QtyIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKetBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents qtybelumdatang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noseq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusDPM As DevExpress.XtraGrid.Columns.GridColumn
End Class
