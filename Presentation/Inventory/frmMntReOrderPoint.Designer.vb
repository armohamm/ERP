<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMntReOrderPoint
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMntReOrderPoint))
        Me.GV1Det = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tinggi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_jns_persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVpersediaan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVjenisBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.akhir_booked = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_available = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReCE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.lead_time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlGridLeft = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.CCKListBoxKolom = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lblError2 = New DevExpress.XtraEditors.LabelControl
        Me.lblError1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.SCpnlMaster = New DevExpress.XtraEditors.SplitContainerControl
        Me.lblLoad2 = New DevExpress.XtraEditors.LabelControl
        Me.lblLoad1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ResetCmd = New DevExpress.XtraEditors.SimpleButton
        Me.Allcmd = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.CCKBOXSetting = New System.Windows.Forms.CheckBox
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CEStokHijau = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.CEStokMerah = New DevExpress.XtraEditors.CheckEdit
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GV1Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReCE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridLeft.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.SCpnlMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCpnlMaster.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEStokHijau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEStokMerah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV1Det
        '
        Me.GV1Det.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Gudang, Me.Nama_Gudang, Me.Keterangan, Me.akhir_qty})
        Me.GV1Det.GridControl = Me.GC1
        Me.GV1Det.Name = "GV1Det"
        Me.GV1Det.OptionsView.ShowFooter = True
        Me.GV1Det.OptionsView.ShowGroupPanel = False
        Me.GV1Det.OptionsView.ShowViewCaption = True
        Me.GV1Det.ViewCaption = "DETAIL"
        '
        'Kode_Gudang
        '
        Me.Kode_Gudang.Caption = "Kode"
        Me.Kode_Gudang.FieldName = "Kode_Gudang"
        Me.Kode_Gudang.Name = "Kode_Gudang"
        '
        'Nama_Gudang
        '
        Me.Nama_Gudang.Caption = "Nama Gudang"
        Me.Nama_Gudang.FieldName = "Nama_Gudang"
        Me.Nama_Gudang.Name = "Nama_Gudang"
        Me.Nama_Gudang.Visible = True
        Me.Nama_Gudang.VisibleIndex = 0
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 2
        '
        'akhir_qty
        '
        Me.akhir_qty.Caption = "Stok (Akhir Qty)"
        Me.akhir_qty.FieldName = "akhir_qty"
        Me.akhir_qty.Name = "akhir_qty"
        Me.akhir_qty.SummaryItem.DisplayFormat = "{0:n0}"
        Me.akhir_qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir_qty.Visible = True
        Me.akhir_qty.VisibleIndex = 1
        '
        'GC1
        '
        Me.GC1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "DETAIL"
        Me.GC1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVpersediaan, Me.LOVjenisBarang, Me.LOVsatuan, Me.LOVukuran, Me.ReCE, Me.LOVbarang})
        Me.GC1.Size = New System.Drawing.Size(892, 469)
        Me.GC1.TabIndex = 3
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GV1Det})
        '
        'GV1
        '
        Me.GV1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GV1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.kd_stok, Me.Kd_Satuan, Me.kd_ukuran, Me.tinggi, Me.lebar, Me.panjang, Me.kd_jns_persd, Me.kd_jenis, Me.akhir_booked, Me.akhir_qty_onstok, Me.stok_min, Me.qty_available, Me.cek, Me.lead_time})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[akhir_qty_onstok] <= ([stok_min]*[lead_time])"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[akhir_qty_onstok] >= ([stok_min]*[lead_time])"
        Me.GV1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GV1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "akhir_booked", Me.akhir_booked, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "akhir_qty_onstok", Me.akhir_qty_onstok, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_available", Me.qty_available, "")})
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupedColumns = True
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.ViewCaption = "MONITORING STOK"
        '
        'nomor
        '
        Me.nomor.Caption = "No."
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.OptionsColumn.AllowEdit = False
        Me.nomor.OptionsColumn.ReadOnly = True
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LOVbarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        '
        'LOVbarang
        '
        Me.LOVbarang.AutoHeight = False
        Me.LOVbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVbarang.Name = "LOVbarang"
        Me.LOVbarang.NullText = "[Data Tidak Ada]"
        '
        'Kd_Satuan
        '
        Me.Kd_Satuan.Caption = "Satuan"
        Me.Kd_Satuan.ColumnEdit = Me.LOVsatuan
        Me.Kd_Satuan.FieldName = "Kd_Satuan"
        Me.Kd_Satuan.Name = "Kd_Satuan"
        Me.Kd_Satuan.OptionsColumn.AllowEdit = False
        Me.Kd_Satuan.OptionsColumn.ReadOnly = True
        Me.Kd_Satuan.Visible = True
        Me.Kd_Satuan.VisibleIndex = 2
        '
        'LOVsatuan
        '
        Me.LOVsatuan.AutoHeight = False
        Me.LOVsatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Satuan", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Satuan", "Nama")})
        Me.LOVsatuan.Name = "LOVsatuan"
        Me.LOVsatuan.NullText = "[Data Tidak Ada]"
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.LOVukuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.OptionsColumn.AllowEdit = False
        Me.kd_ukuran.OptionsColumn.ReadOnly = True
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 3
        '
        'LOVukuran
        '
        Me.LOVukuran.AutoHeight = False
        Me.LOVukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Nama")})
        Me.LOVukuran.Name = "LOVukuran"
        Me.LOVukuran.NullText = "[Data Tidak Ada]"
        '
        'tinggi
        '
        Me.tinggi.Caption = "Tinggi"
        Me.tinggi.FieldName = "tinggi"
        Me.tinggi.Name = "tinggi"
        Me.tinggi.OptionsColumn.AllowEdit = False
        Me.tinggi.OptionsColumn.ReadOnly = True
        Me.tinggi.Visible = True
        Me.tinggi.VisibleIndex = 4
        '
        'lebar
        '
        Me.lebar.Caption = "Lebar"
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.OptionsColumn.AllowEdit = False
        Me.lebar.OptionsColumn.ReadOnly = True
        Me.lebar.Visible = True
        Me.lebar.VisibleIndex = 5
        '
        'panjang
        '
        Me.panjang.Caption = "Panjang"
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.OptionsColumn.AllowEdit = False
        Me.panjang.OptionsColumn.ReadOnly = True
        Me.panjang.Visible = True
        Me.panjang.VisibleIndex = 6
        '
        'kd_jns_persd
        '
        Me.kd_jns_persd.Caption = "Persediaan"
        Me.kd_jns_persd.ColumnEdit = Me.LOVpersediaan
        Me.kd_jns_persd.FieldName = "kd_jns_persd"
        Me.kd_jns_persd.Name = "kd_jns_persd"
        Me.kd_jns_persd.OptionsColumn.AllowEdit = False
        Me.kd_jns_persd.OptionsColumn.ReadOnly = True
        Me.kd_jns_persd.Visible = True
        Me.kd_jns_persd.VisibleIndex = 7
        '
        'LOVpersediaan
        '
        Me.LOVpersediaan.AutoHeight = False
        Me.LOVpersediaan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpersediaan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Persd", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Nama")})
        Me.LOVpersediaan.Name = "LOVpersediaan"
        Me.LOVpersediaan.NullText = "[Data Tidak Ada]"
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Jenis Barang"
        Me.kd_jenis.ColumnEdit = Me.LOVjenisBarang
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.OptionsColumn.AllowEdit = False
        Me.kd_jenis.OptionsColumn.ReadOnly = True
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 8
        '
        'LOVjenisBarang
        '
        Me.LOVjenisBarang.AutoHeight = False
        Me.LOVjenisBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVjenisBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Brg", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama")})
        Me.LOVjenisBarang.Name = "LOVjenisBarang"
        Me.LOVjenisBarang.NullText = "[Data Tidak Ada]"
        '
        'akhir_booked
        '
        Me.akhir_booked.Caption = "Booked"
        Me.akhir_booked.DisplayFormat.FormatString = "n0"
        Me.akhir_booked.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.akhir_booked.FieldName = "akhir_booked"
        Me.akhir_booked.Name = "akhir_booked"
        Me.akhir_booked.OptionsColumn.AllowEdit = False
        Me.akhir_booked.OptionsColumn.ReadOnly = True
        Me.akhir_booked.SummaryItem.DisplayFormat = "{0:n0}"
        Me.akhir_booked.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir_booked.Visible = True
        Me.akhir_booked.VisibleIndex = 9
        '
        'akhir_qty_onstok
        '
        Me.akhir_qty_onstok.Caption = "Stok"
        Me.akhir_qty_onstok.DisplayFormat.FormatString = "n0"
        Me.akhir_qty_onstok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.akhir_qty_onstok.FieldName = "akhir_qty_onstok"
        Me.akhir_qty_onstok.Name = "akhir_qty_onstok"
        Me.akhir_qty_onstok.OptionsColumn.AllowEdit = False
        Me.akhir_qty_onstok.OptionsColumn.ReadOnly = True
        Me.akhir_qty_onstok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.akhir_qty_onstok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir_qty_onstok.Visible = True
        Me.akhir_qty_onstok.VisibleIndex = 10
        '
        'stok_min
        '
        Me.stok_min.Caption = "Stok Minimum"
        Me.stok_min.FieldName = "stok_min"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 11
        '
        'qty_available
        '
        Me.qty_available.Caption = "Available"
        Me.qty_available.DisplayFormat.FormatString = "n0"
        Me.qty_available.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_available.FieldName = "qty_available"
        Me.qty_available.Name = "qty_available"
        Me.qty_available.OptionsColumn.AllowEdit = False
        Me.qty_available.OptionsColumn.ReadOnly = True
        Me.qty_available.SummaryItem.DisplayFormat = "{0:n0}"
        Me.qty_available.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_available.Visible = True
        Me.qty_available.VisibleIndex = 12
        '
        'cek
        '
        Me.cek.Caption = "Check"
        Me.cek.ColumnEdit = Me.ReCE
        Me.cek.FieldName = "cek"
        Me.cek.Name = "cek"
        Me.cek.Visible = True
        Me.cek.VisibleIndex = 13
        '
        'ReCE
        '
        Me.ReCE.AutoHeight = False
        Me.ReCE.Name = "ReCE"
        Me.ReCE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ReCE.ValueChecked = "Y"
        Me.ReCE.ValueUnchecked = "T"
        '
        'lead_time
        '
        Me.lead_time.Caption = "Lead Time"
        Me.lead_time.FieldName = "lead_time"
        Me.lead_time.Name = "lead_time"
        '
        'pnlGridLeft
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGridLeft, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGridLeft.Controls.Add(Me.SplitContainerControl1)
        Me.pnlGridLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGridLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridLeft.Name = "pnlGridLeft"
        Me.pnlGridLeft.Size = New System.Drawing.Size(136, 524)
        Me.pnlGridLeft.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.SplitContainerControl1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CCKListBoxKolom)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(136, 524)
        Me.SplitContainerControl1.SplitterPosition = 470
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CCKListBoxKolom
        '
        Me.CCKListBoxKolom.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.CCKListBoxKolom.Appearance.ForeColor = System.Drawing.Color.White
        Me.CCKListBoxKolom.Appearance.Options.UseBackColor = True
        Me.CCKListBoxKolom.Appearance.Options.UseForeColor = True
        Me.CCKListBoxKolom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCKListBoxKolom.Location = New System.Drawing.Point(0, 0)
        Me.CCKListBoxKolom.Name = "CCKListBoxKolom"
        Me.CCKListBoxKolom.Size = New System.Drawing.Size(136, 470)
        Me.CCKListBoxKolom.TabIndex = 28
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.Panel12)
        Me.pnlFooter.Controls.Add(Me.Panel10)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 650)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1028, 50)
        Me.pnlFooter.TabIndex = 2
        '
        'Panel12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel12, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel12.BackColor = System.Drawing.Color.Maroon
        Me.Panel12.Controls.Add(Me.lblError2)
        Me.Panel12.Controls.Add(Me.lblError1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(939, 50)
        Me.Panel12.TabIndex = 14
        '
        'lblError2
        '
        Me.lblError2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError2.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError2.Appearance.Options.UseFont = True
        Me.lblError2.Appearance.Options.UseForeColor = True
        Me.lblError2.Location = New System.Drawing.Point(12, 28)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(12, 16)
        Me.lblError2.TabIndex = 14
        Me.lblError2.Text = "..."
        '
        'lblError1
        '
        Me.lblError1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError1.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError1.Appearance.Options.UseFont = True
        Me.lblError1.Appearance.Options.UseForeColor = True
        Me.lblError1.Location = New System.Drawing.Point(12, 6)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(12, 16)
        Me.lblError1.TabIndex = 13
        Me.lblError1.Text = "..."
        '
        'Panel10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel10, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel10.BackColor = System.Drawing.Color.Maroon
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(939, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(89, 50)
        Me.Panel10.TabIndex = 13
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1028, 700)
        Me.pnl.TabIndex = 4
        '
        'pnlGrid
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGrid, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGrid.BackColor = System.Drawing.Color.Maroon
        Me.pnlGrid.Controls.Add(Me.SCpnlMaster)
        Me.pnlGrid.Controls.Add(Me.pnlGridLeft)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 126)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1028, 524)
        Me.pnlGrid.TabIndex = 8
        '
        'SCpnlMaster
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.SCpnlMaster, DevExpress.Utils.DefaultBoolean.[Default])
        Me.SCpnlMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCpnlMaster.Horizontal = False
        Me.SCpnlMaster.Location = New System.Drawing.Point(136, 0)
        Me.SCpnlMaster.Name = "SCpnlMaster"
        Me.SCpnlMaster.Panel1.Controls.Add(Me.lblLoad2)
        Me.SCpnlMaster.Panel1.Controls.Add(Me.GC1)
        Me.SCpnlMaster.Panel1.Text = "Panel1"
        Me.SCpnlMaster.Panel2.Controls.Add(Me.lblLoad1)
        Me.SCpnlMaster.Panel2.Text = "Panel2"
        Me.SCpnlMaster.Size = New System.Drawing.Size(892, 524)
        Me.SCpnlMaster.SplitterPosition = 469
        Me.SCpnlMaster.TabIndex = 4
        Me.SCpnlMaster.Text = "SplitContainerControl1"
        '
        'lblLoad2
        '
        Me.lblLoad2.Appearance.BackColor = System.Drawing.Color.White
        Me.lblLoad2.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad2.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblLoad2.Appearance.Options.UseBackColor = True
        Me.lblLoad2.Appearance.Options.UseFont = True
        Me.lblLoad2.Appearance.Options.UseForeColor = True
        Me.lblLoad2.Location = New System.Drawing.Point(20, 80)
        Me.lblLoad2.Name = "lblLoad2"
        Me.lblLoad2.Size = New System.Drawing.Size(432, 39)
        Me.lblLoad2.TabIndex = 5
        Me.lblLoad2.Text = "Load Data, Silahkan Tunggu..."
        Me.lblLoad2.Visible = False
        '
        'lblLoad1
        '
        Me.lblLoad1.Appearance.BackColor = System.Drawing.Color.White
        Me.lblLoad1.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblLoad1.Appearance.Options.UseBackColor = True
        Me.lblLoad1.Appearance.Options.UseFont = True
        Me.lblLoad1.Appearance.Options.UseForeColor = True
        Me.lblLoad1.Location = New System.Drawing.Point(20, 80)
        Me.lblLoad1.Name = "lblLoad1"
        Me.lblLoad1.Size = New System.Drawing.Size(432, 39)
        Me.lblLoad1.TabIndex = 4
        Me.lblLoad1.Text = "Load Data, Silahkan Tunggu..."
        Me.lblLoad1.Visible = False
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 94)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1028, 32)
        Me.Panel8.TabIndex = 7
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(136, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(892, 32)
        Me.Panel11.TabIndex = 5
        '
        'Panel9
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel9, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel9.BackColor = System.Drawing.Color.Maroon
        Me.Panel9.Controls.Add(Me.ResetCmd)
        Me.Panel9.Controls.Add(Me.Allcmd)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1028, 32)
        Me.Panel9.TabIndex = 4
        '
        'ResetCmd
        '
        Me.ResetCmd.Location = New System.Drawing.Point(46, 3)
        Me.ResetCmd.Name = "ResetCmd"
        Me.ResetCmd.Size = New System.Drawing.Size(37, 23)
        Me.ResetCmd.TabIndex = 1
        Me.ResetCmd.Text = "N"
        '
        'Allcmd
        '
        Me.Allcmd.Location = New System.Drawing.Point(3, 3)
        Me.Allcmd.Name = "Allcmd"
        Me.Allcmd.Size = New System.Drawing.Size(37, 23)
        Me.Allcmd.TabIndex = 30
        Me.Allcmd.Text = "A"
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 57)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.SimpleButton2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(647, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 57)
        Me.Panel4.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(30, 21)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "SAVE"
        Me.SimpleButton2.Visible = False
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.cmdPrint)
        Me.Panel3.Controls.Add(Me.CEStokHijau)
        Me.Panel3.Controls.Add(Me.SimpleButton1)
        Me.Panel3.Controls.Add(Me.CEStokMerah)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(353, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 57)
        Me.Panel3.TabIndex = 1
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(241, 8)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdPrint.ToolTipTitle = "PRINT"
        Me.cmdPrint.Visible = False
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefaultToolTipController1.DefaultController.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseBackColor = True
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseFont = True
        Me.DefaultToolTipController1.DefaultController.Rounded = True
        Me.DefaultToolTipController1.DefaultController.ShowBeak = True
        Me.DefaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.CCKBOXSetting)
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(214, 57)
        Me.Panel6.TabIndex = 5
        '
        'CCKBOXSetting
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.CCKBOXSetting, DevExpress.Utils.DefaultBoolean.[Default])
        Me.CCKBOXSetting.AutoSize = True
        Me.CCKBOXSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCKBOXSetting.ForeColor = System.Drawing.Color.White
        Me.CCKBOXSetting.Location = New System.Drawing.Point(6, 27)
        Me.CCKBOXSetting.Name = "CCKBOXSetting"
        Me.CCKBOXSetting.Size = New System.Drawing.Size(101, 17)
        Me.CCKBOXSetting.TabIndex = 0
        Me.CCKBOXSetting.Text = "Show Setting"
        Me.CCKBOXSetting.UseVisualStyleBackColor = True
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(6, 6)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 53
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 57)
        Me.Panel7.TabIndex = 9
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
        Me.LabelControl2.Location = New System.Drawing.Point(3, 1)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 21)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Periode : "
        '
        'Panel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MAINTENANCE REORDER POINT"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CEStokHijau
        '
        Me.CEStokHijau.Location = New System.Drawing.Point(6, 31)
        Me.CEStokHijau.Name = "CEStokHijau"
        Me.CEStokHijau.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CEStokHijau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEStokHijau.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEStokHijau.Properties.Appearance.Options.UseBackColor = True
        Me.CEStokHijau.Properties.Appearance.Options.UseFont = True
        Me.CEStokHijau.Properties.Appearance.Options.UseForeColor = True
        Me.CEStokHijau.Properties.Caption = "Stok Aman"
        Me.CEStokHijau.Size = New System.Drawing.Size(185, 19)
        Me.CEStokHijau.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(197, 9)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 38)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        Me.SimpleButton1.Visible = False
        '
        'CEStokMerah
        '
        Me.CEStokMerah.Location = New System.Drawing.Point(6, 6)
        Me.CEStokMerah.Name = "CEStokMerah"
        Me.CEStokMerah.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CEStokMerah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEStokMerah.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEStokMerah.Properties.Appearance.Options.UseBackColor = True
        Me.CEStokMerah.Properties.Appearance.Options.UseFont = True
        Me.CEStokMerah.Properties.Appearance.Options.UseForeColor = True
        Me.CEStokMerah.Properties.Caption = "Stok Limit"
        Me.CEStokMerah.Size = New System.Drawing.Size(185, 19)
        Me.CEStokMerah.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmMntReOrderPoint
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 700)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMntReOrderPoint"
        Me.Text = "frmMonStokGudangIII"
        CType(Me.GV1Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReCE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridLeft.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.SCpnlMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCpnlMaster.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEStokHijau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEStokMerah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GV1Det As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jns_persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVpersediaan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVjenisBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents akhir_booked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_available As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlGridLeft As System.Windows.Forms.Panel
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CCKListBoxKolom As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lblError2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblError1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents SCpnlMaster As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblLoad2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoad1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ResetCmd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Allcmd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CEStokHijau As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEStokMerah As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents CCKBOXSetting As System.Windows.Forms.CheckBox
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tinggi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReCE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
