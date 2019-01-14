<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceCSOInternal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceCSOInternal))
        Me.GV_MATERIAl = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GVMNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVMMaterial = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gvmQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HARGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MARGIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TOTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC_Jns_Service = New DevExpress.XtraGrid.GridControl
        Me.GV_Jenis_Service = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSeq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_kd_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LE_JenisService = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gc_ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QualityConcern = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repcheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Toleransi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.PnlTengah = New System.Windows.Forms.Panel
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtStatusInspeksi = New DevExpress.XtraEditors.TextEdit
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMasaPakai = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtThnbuat = New DevExpress.XtraEditors.SpinEdit
        Me.LU_Barang = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LU_SO = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GV_MATERIAl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_Jns_Service, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Jenis_Service, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LE_JenisService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.PnlTengah.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtStatusInspeksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtMasaPakai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThnbuat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LU_Barang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LU_SO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV_MATERIAl
        '
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_MATERIAl.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.Empty.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_MATERIAl.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_MATERIAl.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV_MATERIAl.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_MATERIAl.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV_MATERIAl.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV_MATERIAl.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_MATERIAl.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV_MATERIAl.Appearance.Preview.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.Preview.Options.UseFont = True
        Me.GV_MATERIAl.Appearance.Preview.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_MATERIAl.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_MATERIAl.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_MATERIAl.Appearance.Row.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.Row.Options.UseBorderColor = True
        Me.GV_MATERIAl.Appearance.Row.Options.UseForeColor = True
        Me.GV_MATERIAl.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_MATERIAl.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV_MATERIAl.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_MATERIAl.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_MATERIAl.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_MATERIAl.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_MATERIAl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVMNO, Me.GVMMaterial, Me.gvmQty, Me.Satuan, Me.HARGA, Me.MARGIN, Me.TOTAL})
        Me.GV_MATERIAl.GridControl = Me.GC_Jns_Service
        Me.GV_MATERIAl.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", Me.TOTAL, "")})
        Me.GV_MATERIAl.Name = "GV_MATERIAl"
        Me.GV_MATERIAl.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_MATERIAl.OptionsView.EnableAppearanceOddRow = True
        Me.GV_MATERIAl.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_MATERIAl.OptionsView.ShowFooter = True
        Me.GV_MATERIAl.OptionsView.ShowGroupPanel = False
        '
        'GVMNO
        '
        Me.GVMNO.Caption = "No"
        Me.GVMNO.FieldName = "NO_SEQ"
        Me.GVMNO.Name = "GVMNO"
        Me.GVMNO.OptionsColumn.AllowEdit = False
        Me.GVMNO.OptionsColumn.AllowFocus = False
        Me.GVMNO.Visible = True
        Me.GVMNO.VisibleIndex = 0
        Me.GVMNO.Width = 64
        '
        'GVMMaterial
        '
        Me.GVMMaterial.Caption = "Material"
        Me.GVMMaterial.ColumnEdit = Me.repMaterial
        Me.GVMMaterial.FieldName = "KD_BARANG"
        Me.GVMMaterial.Name = "GVMMaterial"
        Me.GVMMaterial.Visible = True
        Me.GVMMaterial.VisibleIndex = 1
        Me.GVMMaterial.Width = 708
        '
        'repMaterial
        '
        Me.repMaterial.AutoHeight = False
        Me.repMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMaterial.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 150, "Material")})
        Me.repMaterial.DisplayMember = "Nama_Barang"
        Me.repMaterial.Name = "repMaterial"
        Me.repMaterial.NullText = ""
        Me.repMaterial.ValueMember = "Kode_Barang"
        '
        'gvmQty
        '
        Me.gvmQty.Caption = "Qty"
        Me.gvmQty.FieldName = "QTY"
        Me.gvmQty.Name = "gvmQty"
        Me.gvmQty.Visible = True
        Me.gvmQty.VisibleIndex = 3
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowEdit = False
        Me.Satuan.OptionsColumn.AllowFocus = False
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        Me.Satuan.Width = 74
        '
        'HARGA
        '
        Me.HARGA.Caption = "HARGA"
        Me.HARGA.FieldName = "HARGA"
        Me.HARGA.Name = "HARGA"
        '
        'MARGIN
        '
        Me.MARGIN.Caption = "MARGIN"
        Me.MARGIN.FieldName = "MARGIN"
        Me.MARGIN.Name = "MARGIN"
        '
        'TOTAL
        '
        Me.TOTAL.Caption = "TOTAL"
        Me.TOTAL.FieldName = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'GC_Jns_Service
        '
        Me.GC_Jns_Service.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV_MATERIAl
        GridLevelNode1.RelationName = "Level1"
        Me.GC_Jns_Service.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC_Jns_Service.Location = New System.Drawing.Point(0, 0)
        Me.GC_Jns_Service.MainView = Me.GV_Jenis_Service
        Me.GC_Jns_Service.Name = "GC_Jns_Service"
        Me.GC_Jns_Service.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LE_JenisService, Me.repcheck, Me.repMaterial})
        Me.GC_Jns_Service.Size = New System.Drawing.Size(938, 332)
        Me.GC_Jns_Service.TabIndex = 0
        Me.GC_Jns_Service.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Jenis_Service, Me.GV_MATERIAl})
        '
        'GV_Jenis_Service
        '
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_Jenis_Service.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.Preview.Options.UseFont = True
        Me.GV_Jenis_Service.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Jenis_Service.Appearance.Row.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.Row.Options.UseBorderColor = True
        Me.GV_Jenis_Service.Appearance.Row.Options.UseForeColor = True
        Me.GV_Jenis_Service.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_Jenis_Service.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_Jenis_Service.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Jenis_Service.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Jenis_Service.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSeq, Me.gc_kd_service, Me.gc_ket, Me.biaya, Me.QualityConcern, Me.QC, Me.Toleransi})
        Me.GV_Jenis_Service.GridControl = Me.GC_Jns_Service
        Me.GV_Jenis_Service.Name = "GV_Jenis_Service"
        Me.GV_Jenis_Service.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV_Jenis_Service.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV_Jenis_Service.OptionsDetail.ShowDetailTabs = False
        Me.GV_Jenis_Service.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Jenis_Service.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Jenis_Service.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Jenis_Service.OptionsView.ShowGroupPanel = False
        '
        'NoSeq
        '
        Me.NoSeq.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
        Me.NoSeq.AppearanceCell.Options.UseBackColor = True
        Me.NoSeq.AppearanceHeader.Options.UseTextOptions = True
        Me.NoSeq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoSeq.Caption = "No"
        Me.NoSeq.FieldName = "no_seq"
        Me.NoSeq.Name = "NoSeq"
        Me.NoSeq.OptionsColumn.AllowEdit = False
        Me.NoSeq.Visible = True
        Me.NoSeq.VisibleIndex = 0
        Me.NoSeq.Width = 44
        '
        'gc_kd_service
        '
        Me.gc_kd_service.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_kd_service.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gc_kd_service.Caption = "Jenis Service"
        Me.gc_kd_service.ColumnEdit = Me.LE_JenisService
        Me.gc_kd_service.FieldName = "Kode_Service"
        Me.gc_kd_service.Name = "gc_kd_service"
        Me.gc_kd_service.Visible = True
        Me.gc_kd_service.VisibleIndex = 1
        Me.gc_kd_service.Width = 242
        '
        'LE_JenisService
        '
        Me.LE_JenisService.AutoHeight = False
        Me.LE_JenisService.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_JenisService.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_service", 200, "Nama Service"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("QC", "QiC", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Toleransi", "Toleransi", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LE_JenisService.DisplayMember = "nama_service"
        Me.LE_JenisService.Name = "LE_JenisService"
        Me.LE_JenisService.NullText = ""
        Me.LE_JenisService.PopupWidth = 300
        Me.LE_JenisService.ValueMember = "kd_service"
        '
        'gc_ket
        '
        Me.gc_ket.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_ket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gc_ket.Caption = "Keterangan"
        Me.gc_ket.FieldName = "Keluhan"
        Me.gc_ket.Name = "gc_ket"
        Me.gc_ket.Visible = True
        Me.gc_ket.VisibleIndex = 2
        Me.gc_ket.Width = 631
        '
        'biaya
        '
        Me.biaya.Caption = "biaya"
        Me.biaya.FieldName = "biaya"
        Me.biaya.Name = "biaya"
        '
        'QualityConcern
        '
        Me.QualityConcern.Caption = "QualityConcern"
        Me.QualityConcern.FieldName = "QualityConcern"
        Me.QualityConcern.Name = "QualityConcern"
        '
        'QC
        '
        Me.QC.AppearanceHeader.Options.UseTextOptions = True
        Me.QC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.QC.Caption = "QC"
        Me.QC.ColumnEdit = Me.repcheck
        Me.QC.FieldName = "QC"
        Me.QC.Name = "QC"
        Me.QC.OptionsColumn.AllowEdit = False
        Me.QC.OptionsColumn.AllowFocus = False
        Me.QC.ToolTip = "Quality in Concernt"
        Me.QC.Width = 40
        '
        'repcheck
        '
        Me.repcheck.AllowFocused = False
        Me.repcheck.AutoHeight = False
        Me.repcheck.Caption = ""
        Me.repcheck.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repcheck.DisplayValueChecked = "Ya"
        Me.repcheck.DisplayValueUnchecked = "Tidak"
        Me.repcheck.Name = "repcheck"
        Me.repcheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repcheck.UseParentBackground = True
        Me.repcheck.ValueChecked = "Y"
        Me.repcheck.ValueUnchecked = "T"
        '
        'Toleransi
        '
        Me.Toleransi.Caption = "Tol"
        Me.Toleransi.FieldName = "Toleransi"
        Me.Toleransi.Name = "Toleransi"
        Me.Toleransi.OptionsColumn.AllowEdit = False
        Me.Toleransi.OptionsColumn.AllowFocus = False
        Me.Toleransi.Width = 45
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.PnlTengah)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(938, 466)
        Me.pnl.TabIndex = 1
        '
        'PnlTengah
        '
        Me.PnlTengah.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlTengah.Controls.Add(Me.GC_Jns_Service)
        Me.PnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlTengah.Location = New System.Drawing.Point(0, 134)
        Me.PnlTengah.Name = "PnlTengah"
        Me.PnlTengah.Size = New System.Drawing.Size(938, 332)
        Me.PnlTengah.TabIndex = 9
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(938, 100)
        Me.pnlTools.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtStatusInspeksi)
        Me.Panel2.Controls.Add(Me.txtKeterangan)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.LU_Barang)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(118, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 100)
        Me.Panel2.TabIndex = 5
        '
        'txtStatusInspeksi
        '
        Me.txtStatusInspeksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtStatusInspeksi.Location = New System.Drawing.Point(0, 80)
        Me.txtStatusInspeksi.Name = "txtStatusInspeksi"
        Me.txtStatusInspeksi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatusInspeksi.Properties.Appearance.Options.UseBackColor = True
        Me.txtStatusInspeksi.Properties.ReadOnly = True
        Me.txtStatusInspeksi.Size = New System.Drawing.Size(520, 20)
        Me.txtStatusInspeksi.TabIndex = 9
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 60)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKeterangan.Properties.Appearance.Options.UseBackColor = True
        Me.txtKeterangan.Properties.ReadOnly = True
        Me.txtKeterangan.Size = New System.Drawing.Size(520, 20)
        Me.txtKeterangan.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtMasaPakai)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtThnbuat)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 20)
        Me.Panel4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(239, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "(tahun)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMasaPakai
        '
        Me.txtMasaPakai.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtMasaPakai.Location = New System.Drawing.Point(178, 0)
        Me.txtMasaPakai.Name = "txtMasaPakai"
        Me.txtMasaPakai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMasaPakai.Properties.Appearance.Options.UseBackColor = True
        Me.txtMasaPakai.Properties.ReadOnly = True
        Me.txtMasaPakai.Size = New System.Drawing.Size(61, 20)
        Me.txtMasaPakai.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Masa Pakai  : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtThnbuat
        '
        Me.txtThnbuat.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtThnbuat.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtThnbuat.Location = New System.Drawing.Point(0, 0)
        Me.txtThnbuat.Name = "txtThnbuat"
        Me.txtThnbuat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtThnbuat.Properties.Appearance.Options.UseBackColor = True
        Me.txtThnbuat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtThnbuat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtThnbuat.Size = New System.Drawing.Size(60, 20)
        Me.txtThnbuat.TabIndex = 6
        '
        'LU_Barang
        '
        Me.LU_Barang.Dock = System.Windows.Forms.DockStyle.Top
        Me.LU_Barang.Location = New System.Drawing.Point(0, 20)
        Me.LU_Barang.Name = "LU_Barang"
        Me.LU_Barang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LU_Barang.Properties.Appearance.Options.UseBackColor = True
        Me.LU_Barang.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.LU_Barang.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LU_Barang.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.LU_Barang.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.LU_Barang.Properties.AppearanceFocused.Options.UseFont = True
        Me.LU_Barang.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LU_Barang.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.LU_Barang.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.LU_Barang.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.LU_Barang.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.LU_Barang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_Barang.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LU_Barang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 300, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Keterangan", 100, "Keterangan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Stok", "Name35", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("thnbuat", "Thnbuat", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status_Inspeksi", 75, "Inspeksi")})
        Me.LU_Barang.Properties.DisplayMember = "Nama_Barang"
        Me.LU_Barang.Properties.DropDownRows = 15
        Me.LU_Barang.Properties.HideSelection = False
        Me.LU_Barang.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.LU_Barang.Properties.NullText = "[Pilih Barang]"
        Me.LU_Barang.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.LU_Barang.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LU_Barang.Properties.PopupWidth = 525
        Me.LU_Barang.Properties.ShowHeader = False
        Me.LU_Barang.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.LU_Barang.Properties.ValueMember = "No_seq"
        Me.LU_Barang.Size = New System.Drawing.Size(520, 20)
        Me.LU_Barang.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LU_SO)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 20)
        Me.Panel3.TabIndex = 5
        '
        'LU_SO
        '
        Me.LU_SO.Dock = System.Windows.Forms.DockStyle.Left
        Me.LU_SO.Location = New System.Drawing.Point(0, 0)
        Me.LU_SO.Name = "LU_SO"
        Me.LU_SO.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.LU_SO.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.LU_SO.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.LU_SO.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.LU_SO.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.LU_SO.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.LU_SO.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.LU_SO.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.LU_SO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_SO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LU_SO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("No_sp", 100, "No. SP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer", 150, "Toko / Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tgl_sp", 75, "Tanggal")})
        Me.LU_SO.Properties.DisplayMember = "No_sp"
        Me.LU_SO.Properties.DropDownRows = 15
        Me.LU_SO.Properties.NullText = "[Pilih No. SO Service]"
        Me.LU_SO.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LU_SO.Properties.PopupWidth = 450
        Me.LU_SO.Properties.ShowHeader = False
        Me.LU_SO.Properties.ValueMember = "No_sp"
        Me.LU_SO.Size = New System.Drawing.Size(175, 20)
        Me.LU_SO.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 100)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Inspeksi : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Keterangan : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "* Tahun Buat : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "* Kode Barang : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "* No. Service : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(938, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(542, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "FORM INSPEKSI SERVICE INTERNAL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmServiceCSOInternal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 466)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmServiceCSOInternal"
        Me.Text = "frmServiceCSO"
        CType(Me.GV_MATERIAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_Jns_Service, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Jenis_Service, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LE_JenisService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repcheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.PnlTengah.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtStatusInspeksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtMasaPakai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThnbuat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LU_Barang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.LU_SO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents PnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LU_Barang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LU_SO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GC_Jns_Service As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Jenis_Service As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_kd_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LE_JenisService As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gc_ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QualityConcern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repcheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Toleransi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtMasaPakai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GV_MATERIAl As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVMNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVMMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvmQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMaterial As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtThnbuat As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStatusInspeksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HARGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MARGIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TOTAL As DevExpress.XtraGrid.Columns.GridColumn
End Class
