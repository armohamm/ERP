<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonStokGudangIII
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonStokGudangIII))
        Me.GV1Det = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC1 = New DevExpress.XtraGrid.GridControl
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_jns_persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVpersediaan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVjenisBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tinggi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVmerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVtipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_sub_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsubtipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVkain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lead_time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_booked = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_available = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVukuran2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlGridLeft = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.CCKListBoxKolom = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.CCKListBoxKolom2 = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.LOVkain2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
        Me.GC2 = New DevExpress.XtraGrid.GridControl
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Gudang2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Gudang2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bultah2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Satuan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsatuan2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_merk2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVmerk2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_tipe2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVtipe2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_sub_tipe2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsubtipe2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kain2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ResetCmd = New DevExpress.XtraEditors.SimpleButton
        Me.Allcmd = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CEMonStokGudangFull = New DevExpress.XtraEditors.CheckEdit
        Me.CEStokHijau = New DevExpress.XtraEditors.CheckEdit
        Me.CEMonStokFull = New DevExpress.XtraEditors.CheckEdit
        Me.CEStokMerah = New DevExpress.XtraEditors.CheckEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.CCKBOXSetting = New System.Windows.Forms.CheckBox
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CEMonStok = New DevExpress.XtraEditors.CheckEdit
        Me.CEMonStokGud = New DevExpress.XtraEditors.CheckEdit
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.GV1Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVmerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVtipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsubtipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVkain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVukuran2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridLeft.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCKListBoxKolom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVkain2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.SCpnlMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCpnlMaster.SuspendLayout()
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsatuan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVmerk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVtipe2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsubtipe2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CEMonStokGudangFull.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEStokHijau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEMonStokFull.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEStokMerah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CEMonStok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEMonStokGud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        GridLevelNode1.LevelTemplate = Me.GV1Det
        GridLevelNode1.RelationName = "DETAIL"
        Me.GC1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC1.Location = New System.Drawing.Point(0, 0)
        Me.GC1.MainView = Me.GV1
        Me.GC1.Name = "GC1"
        Me.GC1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVpersediaan, Me.LOVjenisBarang, Me.LOVsatuan, Me.LOVmerk, Me.LOVtipe, Me.LOVsubtipe, Me.LOVkain, Me.LOVukuran})
        Me.GC1.Size = New System.Drawing.Size(892, 269)
        Me.GC1.TabIndex = 3
        Me.GC1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GV1Det})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.kd_jns_persd, Me.kd_jenis, Me.Nama_Barang, Me.Kd_Satuan, Me.panjang, Me.lebar, Me.tinggi, Me.kd_merk, Me.kd_tipe, Me.kd_sub_tipe, Me.kd_kain, Me.kd_ukuran, Me.stok_min, Me.lead_time, Me.akhir_booked, Me.akhir_qty_onstok, Me.qty_available})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[akhir_qty_onstok] <=[stok_min]  * [lead_time]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[akhir_qty_onstok] >=[stok_min]  * [lead_time]"
        Me.GV1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV1.GridControl = Me.GC1
        Me.GV1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "akhir_booked", Me.akhir_booked, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "akhir_qty_onstok", Me.akhir_qty_onstok, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty_available", Me.qty_available, "")})
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
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
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        '
        'kd_jns_persd
        '
        Me.kd_jns_persd.Caption = "Persediaan"
        Me.kd_jns_persd.ColumnEdit = Me.LOVpersediaan
        Me.kd_jns_persd.FieldName = "kd_jns_persd"
        Me.kd_jns_persd.Name = "kd_jns_persd"
        Me.kd_jns_persd.Visible = True
        Me.kd_jns_persd.VisibleIndex = 1
        '
        'LOVpersediaan
        '
        Me.LOVpersediaan.AutoHeight = False
        Me.LOVpersediaan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpersediaan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Persd", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Nama")})
        Me.LOVpersediaan.Name = "LOVpersediaan"
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Jenis Barang"
        Me.kd_jenis.ColumnEdit = Me.LOVjenisBarang
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 2
        '
        'LOVjenisBarang
        '
        Me.LOVjenisBarang.AutoHeight = False
        Me.LOVjenisBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVjenisBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Brg", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama")})
        Me.LOVjenisBarang.Name = "LOVjenisBarang"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Nama"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 3
        '
        'Kd_Satuan
        '
        Me.Kd_Satuan.Caption = "Satuan"
        Me.Kd_Satuan.ColumnEdit = Me.LOVsatuan
        Me.Kd_Satuan.FieldName = "Kd_Satuan"
        Me.Kd_Satuan.Name = "Kd_Satuan"
        Me.Kd_Satuan.Visible = True
        Me.Kd_Satuan.VisibleIndex = 4
        '
        'LOVsatuan
        '
        Me.LOVsatuan.AutoHeight = False
        Me.LOVsatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Satuan", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Satuan", "Nama")})
        Me.LOVsatuan.Name = "LOVsatuan"
        '
        'panjang
        '
        Me.panjang.Caption = "Panjang"
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.Visible = True
        Me.panjang.VisibleIndex = 10
        '
        'lebar
        '
        Me.lebar.Caption = "Lebar"
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.Visible = True
        Me.lebar.VisibleIndex = 11
        '
        'tinggi
        '
        Me.tinggi.Caption = "Tinggi"
        Me.tinggi.FieldName = "tinggi"
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Visible = True
        Me.tinggi.VisibleIndex = 12
        '
        'kd_merk
        '
        Me.kd_merk.Caption = "Merk"
        Me.kd_merk.ColumnEdit = Me.LOVmerk
        Me.kd_merk.FieldName = "kd_merk"
        Me.kd_merk.Name = "kd_merk"
        Me.kd_merk.Visible = True
        Me.kd_merk.VisibleIndex = 5
        '
        'LOVmerk
        '
        Me.LOVmerk.AutoHeight = False
        Me.LOVmerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVmerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Merk", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama")})
        Me.LOVmerk.Name = "LOVmerk"
        '
        'kd_tipe
        '
        Me.kd_tipe.Caption = "Tipe"
        Me.kd_tipe.ColumnEdit = Me.LOVtipe
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 6
        '
        'LOVtipe
        '
        Me.LOVtipe.AutoHeight = False
        Me.LOVtipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVtipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Tipe", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama")})
        Me.LOVtipe.Name = "LOVtipe"
        '
        'kd_sub_tipe
        '
        Me.kd_sub_tipe.Caption = "Sub Tipe"
        Me.kd_sub_tipe.ColumnEdit = Me.LOVsubtipe
        Me.kd_sub_tipe.FieldName = "kd_sub_tipe"
        Me.kd_sub_tipe.Name = "kd_sub_tipe"
        Me.kd_sub_tipe.Visible = True
        Me.kd_sub_tipe.VisibleIndex = 7
        '
        'LOVsubtipe
        '
        Me.LOVsubtipe.AutoHeight = False
        Me.LOVsubtipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsubtipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Sub_Tipe", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Nama")})
        Me.LOVsubtipe.Name = "LOVsubtipe"
        '
        'kd_kain
        '
        Me.kd_kain.Caption = "Kain"
        Me.kd_kain.ColumnEdit = Me.LOVkain
        Me.kd_kain.FieldName = "kd_kain"
        Me.kd_kain.Name = "kd_kain"
        Me.kd_kain.Visible = True
        Me.kd_kain.VisibleIndex = 8
        '
        'LOVkain
        '
        Me.LOVkain.AutoHeight = False
        Me.LOVkain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVkain.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Kain", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Merk_Kain", "Nama")})
        Me.LOVkain.Name = "LOVkain"
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.LOVukuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 9
        '
        'LOVukuran
        '
        Me.LOVukuran.AutoHeight = False
        Me.LOVukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Nama")})
        Me.LOVukuran.Name = "LOVukuran"
        '
        'stok_min
        '
        Me.stok_min.Caption = "Min STok"
        Me.stok_min.FieldName = "stok_min"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 13
        '
        'lead_time
        '
        Me.lead_time.Caption = "Lead Time"
        Me.lead_time.FieldName = "lead_time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.Visible = True
        Me.lead_time.VisibleIndex = 14
        '
        'akhir_booked
        '
        Me.akhir_booked.Caption = "Booked"
        Me.akhir_booked.DisplayFormat.FormatString = "n0"
        Me.akhir_booked.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.akhir_booked.FieldName = "akhir_booked"
        Me.akhir_booked.Name = "akhir_booked"
        Me.akhir_booked.SummaryItem.DisplayFormat = "{0:n0}"
        Me.akhir_booked.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir_booked.Visible = True
        Me.akhir_booked.VisibleIndex = 15
        '
        'akhir_qty_onstok
        '
        Me.akhir_qty_onstok.Caption = "Stok"
        Me.akhir_qty_onstok.DisplayFormat.FormatString = "n0"
        Me.akhir_qty_onstok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.akhir_qty_onstok.FieldName = "akhir_qty_onstok"
        Me.akhir_qty_onstok.Name = "akhir_qty_onstok"
        Me.akhir_qty_onstok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.akhir_qty_onstok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.akhir_qty_onstok.Visible = True
        Me.akhir_qty_onstok.VisibleIndex = 16
        '
        'qty_available
        '
        Me.qty_available.Caption = "Available"
        Me.qty_available.DisplayFormat.FormatString = "n0"
        Me.qty_available.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_available.FieldName = "qty_available"
        Me.qty_available.Name = "qty_available"
        Me.qty_available.SummaryItem.DisplayFormat = "{0:n0}"
        Me.qty_available.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_available.Visible = True
        Me.qty_available.VisibleIndex = 17
        '
        'LOVukuran2
        '
        Me.LOVukuran2.AutoHeight = False
        Me.LOVukuran2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVukuran2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Nama")})
        Me.LOVukuran2.Name = "LOVukuran2"
        '
        'kd_ukuran2
        '
        Me.kd_ukuran2.Caption = "Ukuran"
        Me.kd_ukuran2.ColumnEdit = Me.LOVukuran2
        Me.kd_ukuran2.FieldName = "kd_ukuran"
        Me.kd_ukuran2.Name = "kd_ukuran2"
        Me.kd_ukuran2.Visible = True
        Me.kd_ukuran2.VisibleIndex = 9
        Me.kd_ukuran2.Width = 64
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
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CCKListBoxKolom2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(136, 524)
        Me.SplitContainerControl1.SplitterPosition = 270
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
        Me.CCKListBoxKolom.Size = New System.Drawing.Size(136, 270)
        Me.CCKListBoxKolom.TabIndex = 28
        '
        'CCKListBoxKolom2
        '
        Me.CCKListBoxKolom2.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.CCKListBoxKolom2.Appearance.ForeColor = System.Drawing.Color.White
        Me.CCKListBoxKolom2.Appearance.Options.UseBackColor = True
        Me.CCKListBoxKolom2.Appearance.Options.UseForeColor = True
        Me.CCKListBoxKolom2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CCKListBoxKolom2.Location = New System.Drawing.Point(0, 0)
        Me.CCKListBoxKolom2.Name = "CCKListBoxKolom2"
        Me.CCKListBoxKolom2.Size = New System.Drawing.Size(136, 248)
        Me.CCKListBoxKolom2.TabIndex = 29
        '
        'LOVkain2
        '
        Me.LOVkain2.AutoHeight = False
        Me.LOVkain2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVkain2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Kain", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Merk_Kain", "Nama")})
        Me.LOVkain2.Name = "LOVkain2"
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
        Me.SCpnlMaster.Panel2.Controls.Add(Me.GC2)
        Me.SCpnlMaster.Panel2.Text = "Panel2"
        Me.SCpnlMaster.Size = New System.Drawing.Size(892, 524)
        Me.SCpnlMaster.SplitterPosition = 269
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
        'GC2
        '
        Me.GC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC2.Location = New System.Drawing.Point(0, 0)
        Me.GC2.MainView = Me.GV2
        Me.GC2.Name = "GC2"
        Me.GC2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVsatuan2, Me.LOVmerk2, Me.LOVtipe2, Me.LOVsubtipe2, Me.LOVkain2, Me.LOVukuran2})
        Me.GC2.Size = New System.Drawing.Size(892, 249)
        Me.GC2.TabIndex = 0
        Me.GC2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor2, Me.Kode_Gudang2, Me.Nama_Gudang2, Me.kd_stok2, Me.bultah2, Me.Nama_Barang2, Me.akhir_qty2, Me.Kd_Satuan2, Me.kd_merk2, Me.kd_tipe2, Me.kd_sub_tipe2, Me.kd_kain2, Me.kd_ukuran2})
        Me.GV2.GridControl = Me.GC2
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "akhir_qty", Me.akhir_qty2, "")})
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.ViewCaption = "STOK DAN GUDANG"
        '
        'nomor2
        '
        Me.nomor2.Caption = "No."
        Me.nomor2.FieldName = "nomor"
        Me.nomor2.Name = "nomor2"
        Me.nomor2.Width = 63
        '
        'Kode_Gudang2
        '
        Me.Kode_Gudang2.Caption = "Kode Gudang"
        Me.Kode_Gudang2.FieldName = "Kode_Gudang"
        Me.Kode_Gudang2.Name = "Kode_Gudang2"
        Me.Kode_Gudang2.Width = 63
        '
        'Nama_Gudang2
        '
        Me.Nama_Gudang2.Caption = "Nama Gudang"
        Me.Nama_Gudang2.FieldName = "Nama_Gudang"
        Me.Nama_Gudang2.Name = "Nama_Gudang2"
        Me.Nama_Gudang2.Visible = True
        Me.Nama_Gudang2.VisibleIndex = 0
        Me.Nama_Gudang2.Width = 63
        '
        'kd_stok2
        '
        Me.kd_stok2.Caption = "Kd. Stok"
        Me.kd_stok2.FieldName = "kd_stok"
        Me.kd_stok2.Name = "kd_stok2"
        Me.kd_stok2.Width = 63
        '
        'bultah2
        '
        Me.bultah2.Caption = "Periode"
        Me.bultah2.FieldName = "bultah"
        Me.bultah2.Name = "bultah2"
        Me.bultah2.Visible = True
        Me.bultah2.VisibleIndex = 1
        Me.bultah2.Width = 63
        '
        'Nama_Barang2
        '
        Me.Nama_Barang2.Caption = "Nama Barang"
        Me.Nama_Barang2.FieldName = "Nama_Barang"
        Me.Nama_Barang2.Name = "Nama_Barang2"
        Me.Nama_Barang2.Visible = True
        Me.Nama_Barang2.VisibleIndex = 2
        Me.Nama_Barang2.Width = 63
        '
        'akhir_qty2
        '
        Me.akhir_qty2.Caption = "Quantity"
        Me.akhir_qty2.FieldName = "akhir_qty"
        Me.akhir_qty2.Name = "akhir_qty2"
        Me.akhir_qty2.Visible = True
        Me.akhir_qty2.VisibleIndex = 3
        Me.akhir_qty2.Width = 63
        '
        'Kd_Satuan2
        '
        Me.Kd_Satuan2.Caption = "Satuan"
        Me.Kd_Satuan2.ColumnEdit = Me.LOVsatuan2
        Me.Kd_Satuan2.FieldName = "Kd_Satuan"
        Me.Kd_Satuan2.Name = "Kd_Satuan2"
        Me.Kd_Satuan2.Visible = True
        Me.Kd_Satuan2.VisibleIndex = 4
        Me.Kd_Satuan2.Width = 63
        '
        'LOVsatuan2
        '
        Me.LOVsatuan2.AutoHeight = False
        Me.LOVsatuan2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsatuan2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Satuan", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Satuan", "Nama")})
        Me.LOVsatuan2.Name = "LOVsatuan2"
        '
        'kd_merk2
        '
        Me.kd_merk2.Caption = "Merk"
        Me.kd_merk2.ColumnEdit = Me.LOVmerk2
        Me.kd_merk2.FieldName = "kd_merk"
        Me.kd_merk2.Name = "kd_merk2"
        Me.kd_merk2.Visible = True
        Me.kd_merk2.VisibleIndex = 5
        Me.kd_merk2.Width = 63
        '
        'LOVmerk2
        '
        Me.LOVmerk2.AutoHeight = False
        Me.LOVmerk2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVmerk2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Merk", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama")})
        Me.LOVmerk2.Name = "LOVmerk2"
        '
        'kd_tipe2
        '
        Me.kd_tipe2.Caption = "Tipe"
        Me.kd_tipe2.ColumnEdit = Me.LOVtipe2
        Me.kd_tipe2.FieldName = "kd_tipe"
        Me.kd_tipe2.Name = "kd_tipe2"
        Me.kd_tipe2.Visible = True
        Me.kd_tipe2.VisibleIndex = 6
        Me.kd_tipe2.Width = 63
        '
        'LOVtipe2
        '
        Me.LOVtipe2.AutoHeight = False
        Me.LOVtipe2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVtipe2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Tipe", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama")})
        Me.LOVtipe2.Name = "LOVtipe2"
        '
        'kd_sub_tipe2
        '
        Me.kd_sub_tipe2.Caption = "Sub Tipe"
        Me.kd_sub_tipe2.ColumnEdit = Me.LOVsubtipe2
        Me.kd_sub_tipe2.FieldName = "kd_sub_tipe"
        Me.kd_sub_tipe2.Name = "kd_sub_tipe2"
        Me.kd_sub_tipe2.Visible = True
        Me.kd_sub_tipe2.VisibleIndex = 7
        Me.kd_sub_tipe2.Width = 64
        '
        'LOVsubtipe2
        '
        Me.LOVsubtipe2.AutoHeight = False
        Me.LOVsubtipe2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsubtipe2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Sub_Tipe", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Nama")})
        Me.LOVsubtipe2.Name = "LOVsubtipe2"
        '
        'kd_kain2
        '
        Me.kd_kain2.Caption = "Kain"
        Me.kd_kain2.ColumnEdit = Me.LOVkain2
        Me.kd_kain2.FieldName = "kd_kain"
        Me.kd_kain2.Name = "kd_kain2"
        Me.kd_kain2.Visible = True
        Me.kd_kain2.VisibleIndex = 8
        Me.kd_kain2.Width = 62
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
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
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
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(814, 5)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdPrint.ToolTipTitle = "PRINT"
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
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(764, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 57)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.CEMonStokGudangFull)
        Me.Panel3.Controls.Add(Me.CEStokHijau)
        Me.Panel3.Controls.Add(Me.CEMonStokFull)
        Me.Panel3.Controls.Add(Me.CEStokMerah)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(353, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 57)
        Me.Panel3.TabIndex = 1
        '
        'CEMonStokGudangFull
        '
        Me.CEMonStokGudangFull.Location = New System.Drawing.Point(203, 2)
        Me.CEMonStokGudangFull.Name = "CEMonStokGudangFull"
        Me.CEMonStokGudangFull.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEMonStokGudangFull.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEMonStokGudangFull.Properties.Appearance.Options.UseFont = True
        Me.CEMonStokGudangFull.Properties.Appearance.Options.UseForeColor = True
        Me.CEMonStokGudangFull.Properties.Caption = "Full View Mon. Stok / Gudang"
        Me.CEMonStokGudangFull.Size = New System.Drawing.Size(185, 19)
        Me.CEMonStokGudangFull.TabIndex = 10
        '
        'CEStokHijau
        '
        Me.CEStokHijau.Location = New System.Drawing.Point(203, 27)
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
        'CEMonStokFull
        '
        Me.CEMonStokFull.Location = New System.Drawing.Point(6, 3)
        Me.CEMonStokFull.Name = "CEMonStokFull"
        Me.CEMonStokFull.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEMonStokFull.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEMonStokFull.Properties.Appearance.Options.UseFont = True
        Me.CEMonStokFull.Properties.Appearance.Options.UseForeColor = True
        Me.CEMonStokFull.Properties.Caption = "Full View Mon. Stok"
        Me.CEMonStokFull.Size = New System.Drawing.Size(185, 19)
        Me.CEMonStokFull.TabIndex = 9
        '
        'CEStokMerah
        '
        Me.CEStokMerah.Location = New System.Drawing.Point(6, 27)
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
        Me.Panel1.Controls.Add(Me.CEMonStok)
        Me.Panel1.Controls.Add(Me.CEMonStokGud)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 37)
        Me.Panel1.TabIndex = 4
        '
        'CEMonStok
        '
        Me.CEMonStok.Location = New System.Drawing.Point(358, 11)
        Me.CEMonStok.Name = "CEMonStok"
        Me.CEMonStok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEMonStok.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEMonStok.Properties.Appearance.Options.UseFont = True
        Me.CEMonStok.Properties.Appearance.Options.UseForeColor = True
        Me.CEMonStok.Properties.Caption = "Full View Mon. Stok"
        Me.CEMonStok.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEMonStok.Size = New System.Drawing.Size(185, 19)
        Me.CEMonStok.TabIndex = 0
        Me.CEMonStok.Visible = False
        '
        'CEMonStokGud
        '
        Me.CEMonStokGud.Location = New System.Drawing.Point(555, 11)
        Me.CEMonStokGud.Name = "CEMonStokGud"
        Me.CEMonStokGud.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEMonStokGud.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEMonStokGud.Properties.Appearance.Options.UseFont = True
        Me.CEMonStokGud.Properties.Appearance.Options.UseForeColor = True
        Me.CEMonStokGud.Properties.Caption = "Full View Mon. Stok / Gudang"
        Me.CEMonStokGud.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEMonStokGud.Size = New System.Drawing.Size(185, 19)
        Me.CEMonStokGud.TabIndex = 1
        Me.CEMonStokGud.Visible = False
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
        Me.lblJudul.Text = "MONITORING STOK GUDANG"
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
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(770, 5)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmMonStokGudangIII
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 700)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonStokGudangIII"
        Me.Text = "frmMonStokGudangIII"
        CType(Me.GV1Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVmerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVtipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsubtipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVkain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVukuran2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridLeft.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CCKListBoxKolom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCKListBoxKolom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVkain2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.SCpnlMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCpnlMaster.ResumeLayout(False)
        CType(Me.GC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsatuan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVmerk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVtipe2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsubtipe2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.CEMonStokGudangFull.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEStokHijau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEMonStokFull.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEStokMerah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CEMonStok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEMonStokGud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LOVukuran2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVmerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVtipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_sub_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsubtipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVkain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_booked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_available As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_ukuran2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlGridLeft As System.Windows.Forms.Panel
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CCKListBoxKolom As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents CCKListBoxKolom2 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LOVkain2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents GC2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode_Gudang2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Gudang2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bultah2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Satuan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsatuan2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_merk2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVmerk2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_tipe2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVtipe2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_sub_tipe2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsubtipe2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_kain2 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents CEMonStokGud As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEMonStok As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents CEMonStokGudangFull As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEMonStokFull As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tinggi As DevExpress.XtraGrid.Columns.GridColumn
End Class
