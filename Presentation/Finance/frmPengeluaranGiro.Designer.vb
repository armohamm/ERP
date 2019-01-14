<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengeluaranGiro
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPengeluaranGiro))
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVnoINV = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_trans2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.idrec = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tangal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.tgl_jth_tempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupjns = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookUpRekening = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.jns_giro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupGiro = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_bank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupbank = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookUpSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.jns_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbjns_trans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupval = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kurs_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbStats = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbGiro = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.lodTanggal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.cbTipeTrans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdAdvance = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVnoINV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tangal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tangal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpRekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.jml_trans2})
        Me.GV2.GridControl = Me.GC
        Me.GV2.Name = "GV2"
        Me.GV2.NewItemRowText = "Tambah data baru disini"
        Me.GV2.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupedColumns = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.ViewCaption = "GIRO DETAIL"
        '
        'no_inv
        '
        Me.no_inv.Caption = "No. Inv"
        Me.no_inv.ColumnEdit = Me.LOVnoINV
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        '
        'LOVnoINV
        '
        Me.LOVnoINV.AutoHeight = False
        Me.LOVnoINV.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVnoINV.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", "No. Inv"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sj", "No. SJ"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jumlah", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.LOVnoINV.Name = "LOVnoINV"
        Me.LOVnoINV.NullText = "[Pilih No. Inv]"
        '
        'jml_trans2
        '
        Me.jml_trans2.Caption = "Jumlah Tagihan"
        Me.jml_trans2.DisplayFormat.FormatString = "n2"
        Me.jml_trans2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans2.FieldName = "jml_trans"
        Me.jml_trans2.Name = "jml_trans2"
        Me.jml_trans2.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV2
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 44)
        Me.GC.LookAndFeel.SkinName = "Blue"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbGiro, Me.lookupGiro, Me.LOVnoINV, Me.tangal, Me.RepositoryItemSpinEdit1, Me.lookupjns, Me.lookUpSupplier, Me.lookUpRekening})
        Me.GC.Size = New System.Drawing.Size(1026, 429)
        Me.GC.TabIndex = 32
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV2})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idrec, Me.nomor, Me.tgl_trans, Me.tgl_jth_tempo, Me.tipe_trans, Me.kd_buku_besar, Me.jns_giro, Me.kd_bank, Me.kartu, Me.jns_trans, Me.kd_valuta, Me.kurs_valuta, Me.jml_trans, Me.keterangan, Me.status, Me.divisi})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Tambah data baru disini"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.RowAutoHeight = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupedColumns = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.ViewCaption = "DATA PENGELUARAN GIRO"
        '
        'idrec
        '
        Me.idrec.Caption = "GridColumn1"
        Me.idrec.FieldName = "idrec"
        Me.idrec.Name = "idrec"
        '
        'nomor
        '
        Me.nomor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.nomor.AppearanceCell.Options.UseFont = True
        Me.nomor.AppearanceCell.Options.UseForeColor = True
        Me.nomor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nomor.AppearanceHeader.Options.UseFont = True
        Me.nomor.AppearanceHeader.Options.UseForeColor = True
        Me.nomor.AppearanceHeader.Options.UseTextOptions = True
        Me.nomor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomor.Caption = "No. Giro"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        Me.nomor.Width = 108
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.ColumnEdit = Me.tangal
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 66
        '
        'tangal
        '
        Me.tangal.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tangal.AutoHeight = False
        Me.tangal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tangal.Mask.EditMask = "d MMMM yyyy"
        Me.tangal.Mask.UseMaskAsDisplayFormat = True
        Me.tangal.Name = "tangal"
        Me.tangal.ShowPopupShadow = False
        Me.tangal.ValidateOnEnterKey = True
        Me.tangal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'tgl_jth_tempo
        '
        Me.tgl_jth_tempo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_jth_tempo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseFont = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_jth_tempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_jth_tempo.Caption = "Tgl. Jatuh Tempo"
        Me.tgl_jth_tempo.ColumnEdit = Me.tangal
        Me.tgl_jth_tempo.FieldName = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Name = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Visible = True
        Me.tgl_jth_tempo.VisibleIndex = 2
        Me.tgl_jth_tempo.Width = 133
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tipe_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Jenis Transaksi"
        Me.tipe_trans.ColumnEdit = Me.lookupjns
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 3
        '
        'lookupjns
        '
        Me.lookupjns.AutoHeight = False
        Me.lookupjns.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupjns.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupjns.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("accronim_desc", "Name1")})
        Me.lookupjns.Name = "lookupjns"
        Me.lookupjns.NullText = "[Transaksi]"
        Me.lookupjns.ValidateOnEnterKey = True
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_buku_besar.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseForeColor = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Jenis Bayar"
        Me.kd_buku_besar.ColumnEdit = Me.lookUpRekening
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 4
        '
        'lookUpRekening
        '
        Me.lookUpRekening.AutoHeight = False
        Me.lookUpRekening.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookUpRekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpRekening.ImmediatePopup = True
        Me.lookUpRekening.Name = "lookUpRekening"
        Me.lookUpRekening.NullText = "[Pilih Pembayaran]"
        Me.lookUpRekening.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lookUpRekening.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.lookUpRekening.PopupSizeable = False
        Me.lookUpRekening.ShowFooter = False
        Me.lookUpRekening.ShowPopupShadow = False
        Me.lookUpRekening.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookUpRekening.ValidateOnEnterKey = True
        Me.lookUpRekening.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'jns_giro
        '
        Me.jns_giro.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jns_giro.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jns_giro.AppearanceHeader.Options.UseFont = True
        Me.jns_giro.AppearanceHeader.Options.UseForeColor = True
        Me.jns_giro.Caption = "Jns. Giro"
        Me.jns_giro.ColumnEdit = Me.lookupGiro
        Me.jns_giro.FieldName = "jns_giro"
        Me.jns_giro.Name = "jns_giro"
        Me.jns_giro.Visible = True
        Me.jns_giro.VisibleIndex = 5
        Me.jns_giro.Width = 61
        '
        'lookupGiro
        '
        Me.lookupGiro.AutoHeight = False
        Me.lookupGiro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupGiro.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Id."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc.")})
        Me.lookupGiro.Name = "lookupGiro"
        Me.lookupGiro.NullText = "[Pilih Giro]"
        '
        'kd_bank
        '
        Me.kd_bank.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_bank.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_bank.AppearanceHeader.Options.UseFont = True
        Me.kd_bank.AppearanceHeader.Options.UseForeColor = True
        Me.kd_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bank.Caption = "Bank"
        Me.kd_bank.ColumnEdit = Me.lookupbank
        Me.kd_bank.FieldName = "kd_bank"
        Me.kd_bank.Name = "kd_bank"
        Me.kd_bank.Visible = True
        Me.kd_bank.VisibleIndex = 6
        '
        'lookupbank
        '
        Me.lookupbank.AutoHeight = False
        Me.lookupbank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbank.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bank", "Nama bank")})
        Me.lookupbank.Name = "lookupbank"
        Me.lookupbank.NullText = "[Pilih Bank]"
        '
        'kartu
        '
        Me.kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kartu.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kartu.AppearanceHeader.Options.UseFont = True
        Me.kartu.AppearanceHeader.Options.UseForeColor = True
        Me.kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kartu.Caption = "Kartu"
        Me.kartu.ColumnEdit = Me.lookUpSupplier
        Me.kartu.FieldName = "kartu"
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 7
        '
        'lookUpSupplier
        '
        Me.lookUpSupplier.AutoHeight = False
        Me.lookUpSupplier.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookUpSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpSupplier.ImmediatePopup = True
        Me.lookUpSupplier.Name = "lookUpSupplier"
        Me.lookUpSupplier.NullText = "[Pilih Supplier]"
        Me.lookUpSupplier.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lookUpSupplier.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.lookUpSupplier.ShowFooter = False
        Me.lookUpSupplier.ShowPopupShadow = False
        Me.lookUpSupplier.ValidateOnEnterKey = True
        Me.lookUpSupplier.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowDetailButtons = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'jns_trans
        '
        Me.jns_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jns_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jns_trans.AppearanceHeader.Options.UseFont = True
        Me.jns_trans.AppearanceHeader.Options.UseForeColor = True
        Me.jns_trans.Caption = "Jns. Trans"
        Me.jns_trans.ColumnEdit = Me.cbjns_trans
        Me.jns_trans.FieldName = "jns_trans"
        Me.jns_trans.Name = "jns_trans"
        Me.jns_trans.Width = 72
        '
        'cbjns_trans
        '
        Me.cbjns_trans.AutoHeight = False
        Me.cbjns_trans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbjns_trans.Items.AddRange(New Object() {"BELI"})
        Me.cbjns_trans.Name = "cbjns_trans"
        Me.cbjns_trans.NullValuePrompt = "klik Disini"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_valuta.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseForeColor = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.ColumnEdit = Me.lookupval
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 8
        Me.kd_valuta.Width = 50
        '
        'lookupval
        '
        Me.lookupval.AutoHeight = False
        Me.lookupval.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupval.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookupval.Name = "lookupval"
        Me.lookupval.NullText = "[Pilih Valuta]"
        '
        'kurs_valuta
        '
        Me.kurs_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kurs_valuta.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kurs_valuta.AppearanceHeader.Options.UseFont = True
        Me.kurs_valuta.AppearanceHeader.Options.UseForeColor = True
        Me.kurs_valuta.Caption = "Kurs Valuta"
        Me.kurs_valuta.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.kurs_valuta.DisplayFormat.FormatString = "n2"
        Me.kurs_valuta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.kurs_valuta.FieldName = "kurs_valuta"
        Me.kurs_valuta.Name = "kurs_valuta"
        Me.kurs_valuta.Visible = True
        Me.kurs_valuta.VisibleIndex = 9
        Me.kurs_valuta.Width = 56
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.ValidateOnEnterKey = True
        '
        'jml_trans
        '
        Me.jml_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jml_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.Options.UseForeColor = True
        Me.jml_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_trans.Caption = "Jumlah"
        Me.jml_trans.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.GroupFormat.FormatString = "n2"
        Me.jml_trans.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 10
        Me.jml_trans.Width = 42
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseForeColor = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 11
        Me.keterangan.Width = 70
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseForeColor = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.ColumnEdit = Me.cbStats
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 12
        Me.status.Width = 86
        '
        'cbStats
        '
        Me.cbStats.AutoHeight = False
        Me.cbStats.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStats.Items.AddRange(New Object() {"KELUAR"})
        Me.cbStats.Name = "cbStats"
        '
        'divisi
        '
        Me.divisi.Caption = "GridColumn1"
        Me.divisi.FieldName = "divisi"
        Me.divisi.Name = "divisi"
        '
        'cbGiro
        '
        Me.cbGiro.AutoHeight = False
        Me.cbGiro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGiro.Name = "cbGiro"
        '
        'lodTanggal
        '
        Me.lodTanggal.AutoHeight = False
        Me.lodTanggal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lodTanggal.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.EditFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.Mask.EditMask = "d MMMM yyyy"
        Me.lodTanggal.Mask.UseMaskAsDisplayFormat = True
        Me.lodTanggal.Name = "lodTanggal"
        Me.lodTanggal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'cbTipeTrans
        '
        Me.cbTipeTrans.AutoHeight = False
        Me.cbTipeTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipeTrans.Items.AddRange(New Object() {"JKK-KUT-02"})
        Me.cbTipeTrans.Name = "cbTipeTrans"
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
        Me.Panel1.Size = New System.Drawing.Size(1026, 44)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 42)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENGELUARAN GIRO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(588, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.cmdAdvance)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 473)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 53)
        Me.Panel2.TabIndex = 31
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(344, 16)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Untuk menghapus, pilih data dan tekan tombol delete"
        Me.LabelControl1.Visible = False
        '
        'cmdAdvance
        '
        Me.cmdAdvance.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAdvance.Location = New System.Drawing.Point(760, 3)
        Me.cmdAdvance.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAdvance.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdvance.Name = "cmdAdvance"
        Me.cmdAdvance.Size = New System.Drawing.Size(80, 30)
        Me.cmdAdvance.TabIndex = 30
        Me.cmdAdvance.Text = "&Advance"
        Me.cmdAdvance.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(846, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 30)
        Me.cmdClear.TabIndex = 29
        Me.cmdClear.Text = "&Bersih"
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(932, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(80, 30)
        Me.cmdRefresh.TabIndex = 28
        Me.cmdRefresh.Text = "&Reload"
        Me.cmdRefresh.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(674, 3)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 30)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        Me.cmdSimpan.Visible = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1026, 526)
        Me.pnl.TabIndex = 2
        '
        'frmPengeluaranGiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 526)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPengeluaranGiro"
        Me.Text = "admin"
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVnoINV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tangal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tangal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpRekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_jth_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents kd_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jns_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdvance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookupval As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupbank As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lodTanggal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cbStats As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbjns_trans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbTipeTrans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents jns_giro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbGiro As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lookupGiro As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kurs_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVnoINV As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tangal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idrec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupjns As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookUpSupplier As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lookUpRekening As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
End Class
