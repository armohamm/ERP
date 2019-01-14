<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceSpringInternal
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
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceSpringInternal))
        Me.repBom = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.thnbuat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Bom_Service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Status_Inspeksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_REFF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNoReff = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlTengahBawah = New System.Windows.Forms.Panel
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tglSO = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnBuku = New DevExpress.XtraEditors.SimpleButton
        Me.lbljudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAsalService = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        CType(Me.repBom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNoReff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnlTengahBawah.SuspendLayout()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAsalService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repBom
        '
        Me.repBom.AutoHeight = False
        Me.repBom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBom.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_service", "Nama Service")})
        Me.repBom.DisplayMember = "nama_service"
        Me.repBom.Name = "repBom"
        Me.repBom.NullText = ""
        Me.repBom.ValueMember = "kd_service"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode3.RelationName = "Level1"
        GridLevelNode4.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbarang, Me.repBom, Me.repNoReff})
        Me.GC.Size = New System.Drawing.Size(1008, 447)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseBorderColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Kd_Stok, Me.Qty, Me.Kd_satuan, Me.jns_service, Me.Keterangan, Me.thnbuat, Me.Harga, Me.Bom_Service, Me.Status_Inspeksi, Me.NO_REFF})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, "")})
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.GV.OptionsDetail.SmartDetailHeight = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'No_seq
        '
        Me.No_seq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_seq.AppearanceCell.Options.UseFont = True
        Me.No_seq.AppearanceCell.Options.UseTextOptions = True
        Me.No_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 45
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 428
        '
        'repbarang
        '
        Me.repbarang.AutoHeight = False
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 100, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Unit")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.HideSelection = False
        Me.repbarang.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.repbarang.Name = "repbarang"
        Me.repbarang.NullText = ""
        Me.repbarang.PopupFormMinSize = New System.Drawing.Size(300, 400)
        Me.repbarang.ShowHeader = False
        Me.repbarang.ShowLines = False
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.OptionsColumn.AllowFocus = False
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Width = 39
        '
        'Kd_satuan
        '
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.AllowFocus = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 2
        Me.Kd_satuan.Width = 76
        '
        'jns_service
        '
        Me.jns_service.Caption = "Service"
        Me.jns_service.FieldName = "Jns_service"
        Me.jns_service.Name = "jns_service"
        Me.jns_service.Width = 109
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Service"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        Me.Keterangan.Width = 271
        '
        'thnbuat
        '
        Me.thnbuat.Caption = "Thn Buat"
        Me.thnbuat.FieldName = "thnbuat"
        Me.thnbuat.Name = "thnbuat"
        Me.thnbuat.Width = 74
        '
        'Harga
        '
        Me.Harga.Caption = "Biaya"
        Me.Harga.DisplayFormat.FormatString = "n"
        Me.Harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Harga.FieldName = "harga"
        Me.Harga.Name = "Harga"
        Me.Harga.OptionsColumn.AllowEdit = False
        Me.Harga.OptionsColumn.AllowFocus = False
        Me.Harga.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Harga.Width = 111
        '
        'Bom_Service
        '
        Me.Bom_Service.Caption = "Bom Service"
        Me.Bom_Service.ColumnEdit = Me.repBom
        Me.Bom_Service.FieldName = "Bom_Service"
        Me.Bom_Service.Name = "Bom_Service"
        Me.Bom_Service.Width = 200
        '
        'Status_Inspeksi
        '
        Me.Status_Inspeksi.Caption = "Status"
        Me.Status_Inspeksi.FieldName = "Status_Inspeksi"
        Me.Status_Inspeksi.Name = "Status_Inspeksi"
        Me.Status_Inspeksi.OptionsColumn.AllowEdit = False
        Me.Status_Inspeksi.OptionsColumn.AllowFocus = False
        Me.Status_Inspeksi.Width = 106
        '
        'NO_REFF
        '
        Me.NO_REFF.Caption = "Ref."
        Me.NO_REFF.ColumnEdit = Me.repNoReff
        Me.NO_REFF.FieldName = "NO_REFF"
        Me.NO_REFF.Name = "NO_REFF"
        Me.NO_REFF.Width = 167
        '
        'repNoReff
        '
        Me.repNoReff.AutoHeight = False
        Me.repNoReff.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repNoReff.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sj", 125, "Nomor SJ")})
        Me.repNoReff.DisplayMember = "no_sj"
        Me.repNoReff.Name = "repNoReff"
        Me.repNoReff.NullText = "[NO SURAT JALAN]"
        Me.repNoReff.ValueMember = "no_sj"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1008, 548)
        Me.pnl.TabIndex = 1
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.pnlTengahBawah)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(1008, 511)
        Me.pnlTengah.TabIndex = 4
        '
        'pnlTengahBawah
        '
        Me.pnlTengahBawah.Controls.Add(Me.GC)
        Me.pnlTengahBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengahBawah.Location = New System.Drawing.Point(0, 64)
        Me.pnlTengahBawah.Name = "pnlTengahBawah"
        Me.pnlTengahBawah.Size = New System.Drawing.Size(1008, 447)
        Me.pnlTengahBawah.TabIndex = 1
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.txtNoRef)
        Me.pnlTengahAtas.Controls.Add(Me.cmbAsalService)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1008, 64)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(0, 42)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(153, 20)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = " [ New ]"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(122, 64)
        Me.Panel4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(735, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(118, 64)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Controls.Add(Me.tglSO)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(853, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 64)
        Me.Panel3.TabIndex = 6
        '
        'tglSO
        '
        Me.tglSO.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSO.Enabled = False
        Me.tglSO.Location = New System.Drawing.Point(0, 20)
        Me.tglSO.Name = "tglSO"
        Me.tglSO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSO.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tglSO.Properties.Appearance.Options.UseBackColor = True
        Me.tglSO.Properties.Appearance.Options.UseForeColor = True
        Me.tglSO.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglSO.Properties.ReadOnly = True
        Me.tglSO.Size = New System.Drawing.Size(153, 20)
        Me.tglSO.TabIndex = 7
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Enabled = False
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseForeColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(153, 20)
        Me.txtNomor.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBuku)
        Me.Panel1.Controls.Add(Me.lbljudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 37)
        Me.Panel1.TabIndex = 2
        '
        'btnBuku
        '
        Me.btnBuku.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Appearance.Options.UseFont = True
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuku.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuku.Image = CType(resources.GetObject("btnBuku.Image"), System.Drawing.Image)
        Me.btnBuku.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuku.Location = New System.Drawing.Point(968, 0)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(38, 35)
        Me.btnBuku.TabIndex = 10
        Me.btnBuku.Tag = "Buku Service"
        Me.btnBuku.ToolTip = "Klik untuk melihat buku order spring"
        Me.btnBuku.ToolTipTitle = "Buku Order"
        '
        'lbljudul
        '
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbljudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.Gold
        Me.lbljudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbljudul.Location = New System.Drawing.Point(38, 0)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(496, 35)
        Me.lbljudul.TabIndex = 9
        Me.lbljudul.Text = "FORM PERMINTAAN SERVICE INTERNAL"
        Me.lbljudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Asal Service :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No Ref :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAsalService
        '
        Me.cmbAsalService.Location = New System.Drawing.Point(123, 4)
        Me.cmbAsalService.Name = "cmbAsalService"
        Me.cmbAsalService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAsalService.Properties.Items.AddRange(New Object() {"RETUR", "PRODUKSI"})
        Me.cmbAsalService.Size = New System.Drawing.Size(160, 20)
        Me.cmbAsalService.TabIndex = 8
        '
        'txtNoRef
        '
        Me.txtNoRef.Location = New System.Drawing.Point(123, 26)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Size = New System.Drawing.Size(160, 20)
        Me.txtNoRef.TabIndex = 9
        '
        'frmServiceSpringInternal
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 548)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmServiceSpringInternal"
        Me.Text = "frmSO"
        CType(Me.repBom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNoReff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlTengahBawah.ResumeLayout(False)
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAsalService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahBawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jns_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbljudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuku As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents thnbuat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bom_Service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBom As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tglSO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Status_Inspeksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents NO_REFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNoReff As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbAsalService As DevExpress.XtraEditors.ComboBoxEdit
End Class
