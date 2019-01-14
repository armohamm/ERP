<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifyJurHutang
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
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerifyJurHutang))
        Me.gvdetailSJ = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcInvoice = New DevExpress.XtraGrid.GridControl
        Me.gvdetailSP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookuprek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Gvheader = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_ref2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookupkartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sts_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ckcetak = New DevExpress.XtraEditors.CheckEdit
        Me.pnlBwh = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvdetailSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookupkartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBwh.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvdetailSJ
        '
        Me.gvdetailSJ.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.gvdetailSJ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.kd_stok, Me.Kd_satuan, Me.qty1, Me.harga1, Me.jml_val_trans, Me.Keterangan})
        Me.gvdetailSJ.GridControl = Me.GcInvoice
        Me.gvdetailSJ.Name = "gvdetailSJ"
        Me.gvdetailSJ.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvdetailSJ.OptionsCustomization.AllowColumnMoving = False
        Me.gvdetailSJ.OptionsCustomization.AllowColumnResizing = False
        Me.gvdetailSJ.OptionsCustomization.AllowFilter = False
        Me.gvdetailSJ.OptionsCustomization.AllowGroup = False
        Me.gvdetailSJ.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvdetailSJ.OptionsCustomization.AllowSort = False
        Me.gvdetailSJ.OptionsView.ColumnAutoWidth = False
        Me.gvdetailSJ.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvdetailSJ.OptionsView.ShowFooter = True
        Me.gvdetailSJ.OptionsView.ShowGroupPanel = False
        Me.gvdetailSJ.PaintStyleName = "WindowsXP"
        '
        'No_seq
        '
        Me.No_seq.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.No_seq.AppearanceCell.Options.UseBackColor = True
        Me.No_seq.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.No_seq.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.No_seq.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.No_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_seq.AppearanceHeader.Options.UseBackColor = True
        Me.No_seq.AppearanceHeader.Options.UseBorderColor = True
        Me.No_seq.AppearanceHeader.Options.UseFont = True
        Me.No_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.No_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_seq.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.No_seq.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.No_seq.Caption = "Nomor"
        Me.No_seq.FieldName = "no_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 49
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.kd_stok.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.kd_stok.Caption = "Nama Barang"
        Me.kd_stok.ColumnEdit = Me.Lookupbrg
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 229
        '
        'Lookupbrg
        '
        Me.Lookupbrg.AutoHeight = False
        Me.Lookupbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupbrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode ")})
        Me.Lookupbrg.Name = "Lookupbrg"
        Me.Lookupbrg.NullText = "klik disini"
        '
        'Kd_satuan
        '
        Me.Kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.Kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_satuan.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.Kd_satuan.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 2
        Me.Kd_satuan.Width = 80
        '
        'qty1
        '
        Me.qty1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty1.AppearanceHeader.Options.UseFont = True
        Me.qty1.AppearanceHeader.Options.UseTextOptions = True
        Me.qty1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.qty1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.qty1.Caption = "Quantity"
        Me.qty1.FieldName = "qty"
        Me.qty1.Name = "qty1"
        Me.qty1.OptionsColumn.AllowEdit = False
        Me.qty1.Visible = True
        Me.qty1.VisibleIndex = 3
        Me.qty1.Width = 63
        '
        'harga1
        '
        Me.harga1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga1.AppearanceHeader.Options.UseFont = True
        Me.harga1.AppearanceHeader.Options.UseTextOptions = True
        Me.harga1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.harga1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.harga1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.harga1.Caption = "Harga Satuan"
        Me.harga1.DisplayFormat.FormatString = "n2"
        Me.harga1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga1.FieldName = "harga"
        Me.harga1.Name = "harga1"
        Me.harga1.OptionsColumn.AllowEdit = False
        Me.harga1.Visible = True
        Me.harga1.VisibleIndex = 4
        Me.harga1.Width = 100
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.jml_val_trans.AppearanceCell.Options.UseBackColor = True
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_val_trans.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.jml_val_trans.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.jml_val_trans.Caption = "Jumlah"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 5
        Me.jml_val_trans.Width = 137
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show
        Me.Keterangan.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.OptionsColumn.AllowEdit = False
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 6
        Me.Keterangan.Width = 285
        '
        'GcInvoice
        '
        Me.GcInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode3.LevelTemplate = Me.gvdetailSJ
        GridLevelNode3.RelationName = "Level1"
        GridLevelNode4.LevelTemplate = Me.gvdetailSP
        GridLevelNode4.RelationName = "Level2"
        Me.GcInvoice.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.GcInvoice.Location = New System.Drawing.Point(0, 34)
        Me.GcInvoice.MainView = Me.Gvheader
        Me.GcInvoice.Name = "GcInvoice"
        Me.GcInvoice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Lookupbrg, Me.Lookupkartu, Me.CekStat, Me.lookuprek, Me.lookupTrans})
        Me.GcInvoice.Size = New System.Drawing.Size(964, 321)
        Me.GcInvoice.TabIndex = 29
        Me.GcInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvdetailSP, Me.Gvheader, Me.GridView1, Me.gvdetailSJ})
        '
        'gvdetailSP
        '
        Me.gvdetailSP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.gvdetailSP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq1, Me.kd_buku_besar, Me.saldo_val_debet, Me.saldo_val_kredit, Me.keterangan1})
        Me.gvdetailSP.GridControl = Me.GcInvoice
        Me.gvdetailSP.Name = "gvdetailSP"
        Me.gvdetailSP.OptionsCustomization.AllowColumnMoving = False
        Me.gvdetailSP.OptionsCustomization.AllowColumnResizing = False
        Me.gvdetailSP.OptionsCustomization.AllowFilter = False
        Me.gvdetailSP.OptionsCustomization.AllowGroup = False
        Me.gvdetailSP.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvdetailSP.OptionsCustomization.AllowSort = False
        Me.gvdetailSP.OptionsView.ColumnAutoWidth = False
        Me.gvdetailSP.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvdetailSP.OptionsView.ShowFooter = True
        Me.gvdetailSP.OptionsView.ShowGroupPanel = False
        Me.gvdetailSP.PaintStyleName = "WindowsXP"
        '
        'no_seq1
        '
        Me.no_seq1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_seq1.AppearanceHeader.Options.UseFont = True
        Me.no_seq1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq1.Caption = "Nomor"
        Me.no_seq1.FieldName = "no_seq"
        Me.no_seq1.Name = "no_seq1"
        Me.no_seq1.OptionsColumn.AllowEdit = False
        Me.no_seq1.Visible = True
        Me.no_seq1.VisibleIndex = 0
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lookuprek
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.OptionsColumn.AllowEdit = False
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        Me.kd_buku_besar.Width = 292
        '
        'lookuprek
        '
        Me.lookuprek.AutoHeight = False
        Me.lookuprek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookuprek.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nam Rekening")})
        Me.lookuprek.Name = "lookuprek"
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_debet.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_debet.Caption = "Debet"
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.OptionsColumn.AllowEdit = False
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 2
        Me.saldo_val_debet.Width = 138
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_kredit.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_kredit.Caption = "Kredit"
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.OptionsColumn.AllowEdit = False
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 3
        Me.saldo_val_kredit.Width = 135
        '
        'keterangan1
        '
        Me.keterangan1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan1.AppearanceHeader.Options.UseFont = True
        Me.keterangan1.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan1.Caption = "Keterangan"
        Me.keterangan1.FieldName = "keterangan"
        Me.keterangan1.Name = "keterangan1"
        Me.keterangan1.OptionsColumn.AllowEdit = False
        Me.keterangan1.Visible = True
        Me.keterangan1.VisibleIndex = 4
        Me.keterangan1.Width = 303
        '
        'Gvheader
        '
        Me.Gvheader.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Gvheader.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gvheader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Gvheader.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.no_ref2, Me.no_ref1, Me.no_inv, Me.tgl_inv, Me.kd_supplier, Me.sts_jur})
        Me.Gvheader.GridControl = Me.GcInvoice
        Me.Gvheader.Name = "Gvheader"
        Me.Gvheader.OptionsCustomization.AllowColumnMoving = False
        Me.Gvheader.OptionsDetail.AllowExpandEmptyDetails = True
        Me.Gvheader.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.Gvheader.OptionsView.AutoCalcPreviewLineCount = True
        Me.Gvheader.OptionsView.EnableAppearanceEvenRow = True
        Me.Gvheader.OptionsView.EnableAppearanceOddRow = True
        Me.Gvheader.OptionsView.ShowGroupPanel = False
        Me.Gvheader.PaintStyleName = "Office2003"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tipe_trans.AppearanceHeader.Options.UseBackColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.Caption = "Tipe Trans."
        Me.tipe_trans.ColumnEdit = Me.lookupTrans
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 0
        Me.tipe_trans.Width = 134
        '
        'lookupTrans
        '
        Me.lookupTrans.AutoHeight = False
        Me.lookupTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupTrans.Name = "lookupTrans"
        Me.lookupTrans.NullText = "[Nomor Transaksi kosong]"
        '
        'no_ref2
        '
        Me.no_ref2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_ref2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_ref2.AppearanceHeader.Options.UseBackColor = True
        Me.no_ref2.AppearanceHeader.Options.UseFont = True
        Me.no_ref2.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref2.Caption = "No. PO"
        Me.no_ref2.FieldName = "no_ref2"
        Me.no_ref2.Name = "no_ref2"
        Me.no_ref2.Visible = True
        Me.no_ref2.VisibleIndex = 1
        Me.no_ref2.Width = 151
        '
        'no_ref1
        '
        Me.no_ref1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_ref1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_ref1.AppearanceHeader.Options.UseBackColor = True
        Me.no_ref1.AppearanceHeader.Options.UseFont = True
        Me.no_ref1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref1.Caption = "No. Inventory"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 2
        Me.no_ref1.Width = 166
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_inv.AppearanceHeader.Options.UseBackColor = True
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "No. Transaksi"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 3
        Me.no_inv.Width = 192
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_inv.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tgl Transaksi"
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 4
        Me.tgl_inv.Width = 93
        '
        'kd_supplier
        '
        Me.kd_supplier.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kd_supplier.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supplier.AppearanceHeader.Options.UseBackColor = True
        Me.kd_supplier.AppearanceHeader.Options.UseFont = True
        Me.kd_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supplier.Caption = "Supplier/Kartu"
        Me.kd_supplier.ColumnEdit = Me.Lookupkartu
        Me.kd_supplier.FieldName = "kd_supplier"
        Me.kd_supplier.Name = "kd_supplier"
        Me.kd_supplier.OptionsColumn.AllowEdit = False
        Me.kd_supplier.Visible = True
        Me.kd_supplier.VisibleIndex = 5
        Me.kd_supplier.Width = 144
        '
        'Lookupkartu
        '
        Me.Lookupkartu.AutoHeight = False
        Me.Lookupkartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookupkartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Nama")})
        Me.Lookupkartu.Name = "Lookupkartu"
        Me.Lookupkartu.NullText = "klik disini"
        '
        'sts_jur
        '
        Me.sts_jur.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sts_jur.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sts_jur.AppearanceHeader.Options.UseBackColor = True
        Me.sts_jur.AppearanceHeader.Options.UseFont = True
        Me.sts_jur.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_jur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_jur.Caption = "Proses"
        Me.sts_jur.ColumnEdit = Me.CekStat
        Me.sts_jur.FieldName = "sts_jur"
        Me.sts_jur.Name = "sts_jur"
        Me.sts_jur.Visible = True
        Me.sts_jur.VisibleIndex = 6
        Me.sts_jur.Width = 67
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CekStat.Caption = ""
        Me.CekStat.DisplayValueChecked = "Y"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GcInvoice
        Me.GridView1.Name = "GridView1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "        DAFTAR PEMBELIAN DAN HUTANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlTop.Size = New System.Drawing.Size(964, 34)
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
        'ckcetak
        '
        Me.ckcetak.Location = New System.Drawing.Point(873, 10)
        Me.ckcetak.Name = "ckcetak"
        Me.ckcetak.Properties.Caption = "Cetak semua"
        Me.ckcetak.Size = New System.Drawing.Size(89, 19)
        Me.ckcetak.TabIndex = 28
        '
        'pnlBwh
        '
        Me.pnlBwh.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBwh.Controls.Add(Me.ckcetak)
        Me.pnlBwh.Controls.Add(Me.btnDel)
        Me.pnlBwh.Controls.Add(Me.btnExit)
        Me.pnlBwh.Controls.Add(Me.cmdSimpan)
        Me.pnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBwh.Location = New System.Drawing.Point(0, 355)
        Me.pnlBwh.Name = "pnlBwh"
        Me.pnlBwh.Size = New System.Drawing.Size(964, 35)
        Me.pnlBwh.TabIndex = 28
        Me.pnlBwh.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(482, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(600, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(26, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(145, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Proses + Cetak Inv"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcInvoice)
        Me.pnl.Controls.Add(Me.pnlBwh)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(964, 390)
        Me.pnl.TabIndex = 2
        '
        'frmVerifyJurHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 390)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmVerifyJurHutang"
        Me.Text = "Verifikasi Jurnal Hutang"
        CType(Me.gvdetailSJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvdetailSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookupkartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBwh.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lookupkartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcInvoice As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvdetailSJ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookupbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvdetailSP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gvheader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_ref2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ckcetak As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnlBwh As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookuprek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
