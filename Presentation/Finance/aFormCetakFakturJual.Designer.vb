<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormCetakFakturJual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormCetakFakturJual))
        Me.gvdetailSJ = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcInvoice = New DevExpress.XtraGrid.GridControl
        Me.Gvheader = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupcust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupvaluta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_ppn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_ppn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.btnDel = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlBwh = New System.Windows.Forms.Panel
        Me.ckcetak = New DevExpress.XtraEditors.CheckEdit
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupcust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupvaluta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlBwh.SuspendLayout()
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvdetailSJ
        '
        Me.gvdetailSJ.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvdetailSJ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.kd_stok, Me.Qty, Me.satuan, Me.jml_rp_trans, Me.keterangan})
        Me.gvdetailSJ.GridControl = Me.GcInvoice
        Me.gvdetailSJ.Name = "gvdetailSJ"
        Me.gvdetailSJ.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvdetailSJ.OptionsCustomization.AllowColumnMoving = False
        Me.gvdetailSJ.OptionsCustomization.AllowColumnResizing = False
        Me.gvdetailSJ.OptionsCustomization.AllowFilter = False
        Me.gvdetailSJ.OptionsCustomization.AllowGroup = False
        Me.gvdetailSJ.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvdetailSJ.OptionsCustomization.AllowSort = False
        Me.gvdetailSJ.OptionsView.ShowGroupPanel = False
        Me.gvdetailSJ.OptionsView.ShowIndicator = False
        Me.gvdetailSJ.PaintStyleName = "Style3D"
        '
        'No_seq
        '
        Me.No_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_seq.AppearanceHeader.Options.UseFont = True
        Me.No_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.No_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_seq.Caption = "Nomor"
        Me.No_seq.FieldName = "no_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 54
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.Lookupbrg
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 251
        '
        'Lookupbrg
        '
        Me.Lookupbrg.AutoHeight = False
        Me.Lookupbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupbrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama_Barang")})
        Me.Lookupbrg.Name = "Lookupbrg"
        Me.Lookupbrg.NullText = "klik disini"
        '
        'Qty
        '
        Me.Qty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Qty.AppearanceCell.Options.UseBackColor = True
        Me.Qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.AppearanceHeader.Options.UseFont = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.Caption = "Jumlah"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 100
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
        Me.satuan.OptionsColumn.AllowEdit = False
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 3
        Me.satuan.Width = 88
        '
        'jml_rp_trans
        '
        Me.jml_rp_trans.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jml_rp_trans.AppearanceCell.Options.UseBackColor = True
        Me.jml_rp_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_rp_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_rp_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_rp_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_rp_trans.Caption = "Jumlah Bayar"
        Me.jml_rp_trans.DisplayFormat.FormatString = "n2"
        Me.jml_rp_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_rp_trans.FieldName = "jml_rp_trans"
        Me.jml_rp_trans.Name = "jml_rp_trans"
        Me.jml_rp_trans.OptionsColumn.AllowEdit = False
        Me.jml_rp_trans.Visible = True
        Me.jml_rp_trans.VisibleIndex = 4
        Me.jml_rp_trans.Width = 107
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        Me.keterangan.Width = 353
        '
        'GcInvoice
        '
        Me.GcInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvdetailSJ
        GridLevelNode1.RelationName = "Level1"
        Me.GcInvoice.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcInvoice.Location = New System.Drawing.Point(0, 34)
        Me.GcInvoice.MainView = Me.Gvheader
        Me.GcInvoice.Name = "GcInvoice"
        Me.GcInvoice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lookupbrg, Me.Lookupcust, Me.CekStat, Me.lookupvaluta})
        Me.GcInvoice.Size = New System.Drawing.Size(974, 316)
        Me.GcInvoice.TabIndex = 29
        Me.GcInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvheader, Me.gvdetailSJ})
        '
        'Gvheader
        '
        Me.Gvheader.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gvheader.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gvheader.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.Empty.Options.UseBackColor = True
        Me.Gvheader.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Gvheader.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gvheader.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Gvheader.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gvheader.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Gvheader.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Gvheader.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gvheader.Appearance.GroupRow.Options.UseFont = True
        Me.Gvheader.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Gvheader.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gvheader.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gvheader.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gvheader.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Gvheader.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Gvheader.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gvheader.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gvheader.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.OddRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.OddRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvheader.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Gvheader.Appearance.Preview.Options.UseBackColor = True
        Me.Gvheader.Appearance.Preview.Options.UseForeColor = True
        Me.Gvheader.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gvheader.Appearance.Row.Options.UseBackColor = True
        Me.Gvheader.Appearance.Row.Options.UseForeColor = True
        Me.Gvheader.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gvheader.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Gvheader.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Gvheader.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gvheader.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Gvheader.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Gvheader.Appearance.VertLine.Options.UseBackColor = True
        Me.Gvheader.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.tgl_inv, Me.no_sj, Me.kd_cust, Me.kd_valuta, Me.jml_tagihan, Me.jml_ppn, Me.sts_ppn})
        Me.Gvheader.GridControl = Me.GcInvoice
        Me.Gvheader.Name = "Gvheader"
        Me.Gvheader.OptionsCustomization.AllowColumnMoving = False
        Me.Gvheader.OptionsCustomization.AllowGroup = False
        Me.Gvheader.OptionsDetail.AllowExpandEmptyDetails = True
        Me.Gvheader.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.Gvheader.OptionsView.EnableAppearanceEvenRow = True
        Me.Gvheader.OptionsView.EnableAppearanceOddRow = True
        Me.Gvheader.OptionsView.RowAutoHeight = True
        Me.Gvheader.OptionsView.ShowFooter = True
        Me.Gvheader.PaintStyleName = "Office2003"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_inv.AppearanceHeader.Options.UseBackColor = True
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "No. Nota"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.AllowEdit = False
        Me.no_inv.SummaryItem.FieldName = "no_sj"
        Me.no_inv.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        Me.no_inv.Width = 111
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_inv.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tanggal Nota"
        Me.tgl_inv.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        Me.tgl_inv.Width = 91
        '
        'no_sj
        '
        Me.no_sj.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_sj.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_sj.AppearanceHeader.Options.UseBackColor = True
        Me.no_sj.AppearanceHeader.Options.UseFont = True
        Me.no_sj.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sj.Caption = "No. SJ"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.OptionsColumn.AllowEdit = False
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 2
        Me.no_sj.Width = 89
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_cust.AppearanceHeader.Options.UseBackColor = True
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Customer"
        Me.kd_cust.ColumnEdit = Me.Lookupcust
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.OptionsColumn.AllowEdit = False
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 3
        Me.kd_cust.Width = 172
        '
        'Lookupcust
        '
        Me.Lookupcust.AutoHeight = False
        Me.Lookupcust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupcust.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Nama")})
        Me.Lookupcust.Name = "Lookupcust"
        Me.Lookupcust.NullText = "klik disini"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_valuta.AppearanceHeader.Options.UseBackColor = True
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.ColumnEdit = Me.lookupvaluta
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.OptionsColumn.AllowEdit = False
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 4
        Me.kd_valuta.Width = 174
        '
        'lookupvaluta
        '
        Me.lookupvaluta.AutoHeight = False
        Me.lookupvaluta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupvaluta.Name = "lookupvaluta"
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceHeader.Options.UseBackColor = True
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jumlah Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 5
        Me.jml_tagihan.Width = 146
        '
        'jml_ppn
        '
        Me.jml_ppn.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.jml_ppn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_ppn.AppearanceHeader.Options.UseBackColor = True
        Me.jml_ppn.AppearanceHeader.Options.UseFont = True
        Me.jml_ppn.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_ppn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_ppn.Caption = "Jumlah PPN"
        Me.jml_ppn.DisplayFormat.FormatString = "n2"
        Me.jml_ppn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_ppn.FieldName = "jml_ppn"
        Me.jml_ppn.Name = "jml_ppn"
        Me.jml_ppn.OptionsColumn.AllowEdit = False
        Me.jml_ppn.Visible = True
        Me.jml_ppn.VisibleIndex = 6
        '
        'sts_ppn
        '
        Me.sts_ppn.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sts_ppn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sts_ppn.AppearanceHeader.Options.UseBackColor = True
        Me.sts_ppn.AppearanceHeader.Options.UseFont = True
        Me.sts_ppn.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_ppn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_ppn.Caption = "Cetak"
        Me.sts_ppn.ColumnEdit = Me.CekStat
        Me.sts_ppn.FieldName = "sts_ppn"
        Me.sts_ppn.Name = "sts_ppn"
        Me.sts_ppn.Visible = True
        Me.sts_ppn.VisibleIndex = 7
        Me.sts_ppn.Width = 48
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CekStat.Caption = ""
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(482, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcInvoice)
        Me.pnl.Controls.Add(Me.pnlBwh)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(974, 385)
        Me.pnl.TabIndex = 1
        '
        'pnlBwh
        '
        Me.pnlBwh.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBwh.Controls.Add(Me.ckcetak)
        Me.pnlBwh.Controls.Add(Me.btnDel)
        Me.pnlBwh.Controls.Add(Me.btnExit)
        Me.pnlBwh.Controls.Add(Me.cmdSimpan)
        Me.pnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBwh.Location = New System.Drawing.Point(0, 350)
        Me.pnlBwh.Name = "pnlBwh"
        Me.pnlBwh.Size = New System.Drawing.Size(974, 35)
        Me.pnlBwh.TabIndex = 28
        '
        'ckcetak
        '
        Me.ckcetak.Dock = System.Windows.Forms.DockStyle.Right
        Me.ckcetak.Location = New System.Drawing.Point(885, 0)
        Me.ckcetak.Name = "ckcetak"
        Me.ckcetak.Properties.Caption = "Cetak semua"
        Me.ckcetak.Size = New System.Drawing.Size(89, 19)
        Me.ckcetak.TabIndex = 28
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(600, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(26, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(145, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Proses + Cetak Inv"
        Me.cmdSimpan.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(974, 34)
        Me.pnlTop.TabIndex = 30
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          CETAK FAKTUR PENJUALAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aFormCetakFakturJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 385)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormCetakFakturJual"
        Me.Text = "Cetak Nota Penjualan"
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupcust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupvaluta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlBwh.ResumeLayout(False)
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvdetailSJ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookupbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookupcust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcInvoice As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gvheader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_ppn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlBwh As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckcetak As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lookupvaluta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jml_ppn As DevExpress.XtraGrid.Columns.GridColumn
End Class
