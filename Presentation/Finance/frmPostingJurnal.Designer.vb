<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostingJurnal
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPostingJurnal))
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_obyek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.val_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dketerangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPost = New DevExpress.XtraGrid.GridControl
        Me.gvPost = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtpPosting = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.cek_post = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ceCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.lueLookBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl
        Me.btnCentang2 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
        Me.btnCentang = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.tglAkhir = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.tglAwal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPosting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPosting.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookBB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.tglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.tglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetil
        '
        Me.gvDetil.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvDetil.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetil.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetil.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetil.Appearance.VertLine.BackColor = System.Drawing.Color.Gainsboro
        Me.gvDetil.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_buku_besar, Me.kd_obyek, Me.val_ref1, Me.harga, Me.saldo_val_debet, Me.saldo_val_kredit, Me.saldo_rp_debet, Me.saldo_rp_kredit, Me.dketerangan})
        Me.gvDetil.GridControl = Me.gcPost
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsCustomization.AllowColumnMoving = False
        Me.gvDetil.OptionsCustomization.AllowFilter = False
        Me.gvDetil.OptionsCustomization.AllowGroup = False
        Me.gvDetil.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvDetil.OptionsView.ColumnAutoWidth = False
        Me.gvDetil.OptionsView.ShowFooter = True
        Me.gvDetil.OptionsView.ShowGroupPanel = False
        Me.gvDetil.OptionsView.ShowIndicator = False
        Me.gvDetil.PaintStyleName = "WindowsXP"
        '
        'no_seq
        '
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lueLookBB
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        Me.kd_buku_besar.Width = 301
        '
        'kd_obyek
        '
        Me.kd_obyek.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_obyek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_obyek.Caption = "Barang"
        Me.kd_obyek.ColumnEdit = Me.lueBarang
        Me.kd_obyek.FieldName = "kd_obyek"
        Me.kd_obyek.Name = "kd_obyek"
        Me.kd_obyek.OptionsColumn.AllowEdit = False
        Me.kd_obyek.OptionsColumn.ReadOnly = True
        '
        'lueBarang
        '
        Me.lueBarang.AutoHeight = False
        Me.lueBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBarang.Name = "lueBarang"
        Me.lueBarang.NullText = "[Kosong]"
        '
        'val_ref1
        '
        Me.val_ref1.Caption = "Qty"
        Me.val_ref1.DisplayFormat.FormatString = "n3"
        Me.val_ref1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.val_ref1.FieldName = "val_ref1"
        Me.val_ref1.Name = "val_ref1"
        Me.val_ref1.OptionsColumn.AllowEdit = False
        Me.val_ref1.OptionsColumn.ReadOnly = True
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "n3"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.OptionsColumn.ReadOnly = True
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_debet.Caption = "Saldo Val. Debet"
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.OptionsColumn.AllowEdit = False
        Me.saldo_val_debet.OptionsColumn.ReadOnly = True
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 2
        Me.saldo_val_debet.Width = 116
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_kredit.Caption = "Saldo Val. Kredit"
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.OptionsColumn.AllowEdit = False
        Me.saldo_val_kredit.OptionsColumn.ReadOnly = True
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 3
        Me.saldo_val_kredit.Width = 106
        '
        'saldo_rp_debet
        '
        Me.saldo_rp_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_debet.Caption = "Saldo Rp. Debet"
        Me.saldo_rp_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_debet.FieldName = "saldo_rp_debet"
        Me.saldo_rp_debet.Name = "saldo_rp_debet"
        Me.saldo_rp_debet.OptionsColumn.AllowEdit = False
        Me.saldo_rp_debet.OptionsColumn.ReadOnly = True
        Me.saldo_rp_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_debet.Visible = True
        Me.saldo_rp_debet.VisibleIndex = 4
        Me.saldo_rp_debet.Width = 104
        '
        'saldo_rp_kredit
        '
        Me.saldo_rp_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_kredit.Caption = "Saldo Rp. Kredit"
        Me.saldo_rp_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_kredit.FieldName = "saldo_rp_kredit"
        Me.saldo_rp_kredit.Name = "saldo_rp_kredit"
        Me.saldo_rp_kredit.OptionsColumn.AllowEdit = False
        Me.saldo_rp_kredit.OptionsColumn.ReadOnly = True
        Me.saldo_rp_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_kredit.Visible = True
        Me.saldo_rp_kredit.VisibleIndex = 5
        Me.saldo_rp_kredit.Width = 116
        '
        'dketerangan
        '
        Me.dketerangan.AppearanceHeader.Options.UseTextOptions = True
        Me.dketerangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dketerangan.Caption = "Keterangan"
        Me.dketerangan.FieldName = "keterangan"
        Me.dketerangan.Name = "dketerangan"
        Me.dketerangan.OptionsColumn.AllowEdit = False
        Me.dketerangan.OptionsColumn.ReadOnly = True
        Me.dketerangan.Visible = True
        Me.dketerangan.VisibleIndex = 6
        Me.dketerangan.Width = 377
        '
        'gcPost
        '
        Me.gcPost.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvDetil
        GridLevelNode1.RelationName = "lvlJurnalDetil"
        Me.gcPost.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcPost.Location = New System.Drawing.Point(2, 2)
        Me.gcPost.LookAndFeel.SkinName = "Blue"
        Me.gcPost.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.gcPost.LookAndFeel.UseWindowsXPTheme = True
        Me.gcPost.MainView = Me.gvPost
        Me.gcPost.Name = "gcPost"
        Me.gcPost.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceCek, Me.lueTrans, Me.lueLookBB, Me.dtpPosting, Me.lueBarang})
        Me.gcPost.Size = New System.Drawing.Size(1002, 407)
        Me.gcPost.TabIndex = 1
        Me.gcPost.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPost, Me.gvDetil})
        '
        'gvPost
        '
        Me.gvPost.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gvPost.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvPost.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvPost.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvPost.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvPost.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvPost.Appearance.HorzLine.BackColor = System.Drawing.Color.Lime
        Me.gvPost.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvPost.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvPost.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_jur, Me.tgl_trans, Me.no_ref1, Me.tipe_trans, Me.nama, Me.kd_valuta, Me.jml_val_trans, Me.jml_rp_trans, Me.keterangan, Me.tgl_posting, Me.cek_post})
        Me.gvPost.GridControl = Me.gcPost
        Me.gvPost.GroupPanelText = "Geser Nama kolom kemari untuk mengelompokkan data."
        Me.gvPost.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jml_val_trans", Me.jml_val_trans, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jml_rp_trans", Me.jml_rp_trans, "{0:n2}")})
        Me.gvPost.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvPost.Name = "gvPost"
        Me.gvPost.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvPost.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvPost.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvPost.OptionsView.ColumnAutoWidth = False
        Me.gvPost.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPost.OptionsView.EnableAppearanceOddRow = True
        Me.gvPost.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.gvPost.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvPost.OptionsView.ShowChildrenInGroupPanel = True
        Me.gvPost.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvPost.OptionsView.ShowFooter = True
        Me.gvPost.PaintStyleName = "Office2003"
        Me.gvPost.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_jur
        '
        Me.no_jur.AppearanceHeader.BackColor = System.Drawing.Color.Lime
        Me.no_jur.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_jur.AppearanceHeader.Options.UseBackColor = True
        Me.no_jur.AppearanceHeader.Options.UseFont = True
        Me.no_jur.Caption = "No. Jurnal"
        Me.no_jur.FieldName = "no_jur"
        Me.no_jur.Name = "no_jur"
        Me.no_jur.OptionsColumn.ReadOnly = True
        Me.no_jur.Visible = True
        Me.no_jur.VisibleIndex = 2
        Me.no_jur.Width = 125
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 3
        Me.tgl_trans.Width = 100
        '
        'no_ref1
        '
        Me.no_ref1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_ref1.AppearanceHeader.Options.UseBackColor = True
        Me.no_ref1.AppearanceHeader.Options.UseFont = True
        Me.no_ref1.Caption = "No. Ref"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.OptionsColumn.ReadOnly = True
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 4
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.Options.UseBackColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.Caption = "Tipe Jurnal"
        Me.tipe_trans.ColumnEdit = Me.lueTrans
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.ReadOnly = True
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 5
        Me.tipe_trans.Width = 100
        '
        'lueTrans
        '
        Me.lueTrans.AutoHeight = False
        Me.lueTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTrans.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "Tipe Trans")})
        Me.lueTrans.Name = "lueTrans"
        Me.lueTrans.NullText = "[Jurnal]"
        '
        'nama
        '
        Me.nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.AppearanceHeader.Options.UseBackColor = True
        Me.nama.AppearanceHeader.Options.UseFont = True
        Me.nama.Caption = "Kepada"
        Me.nama.FieldName = "nama"
        Me.nama.Name = "nama"
        Me.nama.OptionsColumn.ReadOnly = True
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 6
        Me.nama.Width = 100
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_valuta.AppearanceHeader.Options.UseBackColor = True
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.OptionsColumn.ReadOnly = True
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 7
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_val_trans.AppearanceHeader.Options.UseBackColor = True
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.Caption = "Nilai Val. Trans"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.jml_val_trans.OptionsColumn.ReadOnly = True
        Me.jml_val_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_val_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 8
        '
        'jml_rp_trans
        '
        Me.jml_rp_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_rp_trans.AppearanceHeader.Options.UseBackColor = True
        Me.jml_rp_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_rp_trans.Caption = "Nilai Rp. Trans"
        Me.jml_rp_trans.DisplayFormat.FormatString = "n2"
        Me.jml_rp_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_rp_trans.FieldName = "jml_rp_trans"
        Me.jml_rp_trans.Name = "jml_rp_trans"
        Me.jml_rp_trans.OptionsColumn.ReadOnly = True
        Me.jml_rp_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_rp_trans.Visible = True
        Me.jml_rp_trans.VisibleIndex = 9
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseBackColor = True
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 10
        '
        'tgl_posting
        '
        Me.tgl_posting.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_posting.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_posting.AppearanceHeader.Options.UseFont = True
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.ColumnEdit = Me.dtpPosting
        Me.tgl_posting.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 1
        Me.tgl_posting.Width = 88
        '
        'dtpPosting
        '
        Me.dtpPosting.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpPosting.AutoHeight = False
        Me.dtpPosting.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpPosting.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpPosting.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpPosting.Mask.EditMask = "d MMMM yyyy"
        Me.dtpPosting.Mask.UseMaskAsDisplayFormat = True
        Me.dtpPosting.Name = "dtpPosting"
        Me.dtpPosting.ShowPopupShadow = False
        Me.dtpPosting.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'cek_post
        '
        Me.cek_post.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek_post.AppearanceHeader.Options.UseBackColor = True
        Me.cek_post.AppearanceHeader.Options.UseFont = True
        Me.cek_post.Caption = "Cek Post."
        Me.cek_post.ColumnEdit = Me.ceCek
        Me.cek_post.FieldName = "cek_post"
        Me.cek_post.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.cek_post.Name = "cek_post"
        Me.cek_post.Visible = True
        Me.cek_post.VisibleIndex = 0
        Me.cek_post.Width = 83
        '
        'ceCek
        '
        Me.ceCek.AutoHeight = False
        Me.ceCek.DisplayValueChecked = "Y"
        Me.ceCek.Name = "ceCek"
        Me.ceCek.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ceCek.ValueChecked = "Y"
        Me.ceCek.ValueUnchecked = "T"
        '
        'lueLookBB
        '
        Me.lueLookBB.AutoHeight = False
        Me.lueLookBB.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueLookBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookBB.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Name1")})
        Me.lueLookBB.DisplayMember = "nm_buku_besar"
        Me.lueLookBB.Name = "lueLookBB"
        Me.lueLookBB.NullText = "[Kosong]"
        Me.lueLookBB.ShowFooter = False
        Me.lueLookBB.ShowHeader = False
        Me.lueLookBB.ShowPopupShadow = False
        Me.lueLookBB.ValueMember = "kd_buku_besar"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1006, 545)
        Me.pnl.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelControl6)
        Me.Panel1.Controls.Add(Me.PanelControl13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 486)
        Me.Panel1.TabIndex = 3
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.gcPost)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(0, 75)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1006, 411)
        Me.PanelControl6.TabIndex = 8
        '
        'PanelControl13
        '
        Me.PanelControl13.Controls.Add(Me.cmdRefresh)
        Me.PanelControl13.Controls.Add(Me.PanelControl8)
        Me.PanelControl13.Controls.Add(Me.PanelControl7)
        Me.PanelControl13.Controls.Add(Me.PanelControl3)
        Me.PanelControl13.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl13.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(1006, 75)
        Me.PanelControl13.TabIndex = 7
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Appearance.ForeColor = System.Drawing.Color.Red
        Me.cmdRefresh.Appearance.Options.UseFont = True
        Me.cmdRefresh.Appearance.Options.UseForeColor = True
        Me.cmdRefresh.Enabled = False
        Me.cmdRefresh.Location = New System.Drawing.Point(673, 14)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(48, 46)
        Me.cmdRefresh.TabIndex = 10
        Me.cmdRefresh.Text = "00"
        Me.cmdRefresh.ToolTip = "Force"
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.PanelControl12)
        Me.PanelControl8.Controls.Add(Me.PanelControl11)
        Me.PanelControl8.Controls.Add(Me.PanelControl10)
        Me.PanelControl8.Controls.Add(Me.PanelControl9)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl8.Location = New System.Drawing.Point(484, 2)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(172, 71)
        Me.PanelControl8.TabIndex = 7
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.btnCentang2)
        Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl12.Location = New System.Drawing.Point(2, 36)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(168, 24)
        Me.PanelControl12.TabIndex = 8
        '
        'btnCentang2
        '
        Me.btnCentang2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCentang2.Appearance.Options.UseFont = True
        Me.btnCentang2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCentang2.Image = CType(resources.GetObject("btnCentang2.Image"), System.Drawing.Image)
        Me.btnCentang2.Location = New System.Drawing.Point(2, 2)
        Me.btnCentang2.Name = "btnCentang2"
        Me.btnCentang2.Size = New System.Drawing.Size(165, 20)
        Me.btnCentang2.TabIndex = 2
        Me.btnCentang2.Text = "Tidak Centang Semua"
        Me.btnCentang2.ToolTip = "Centang Semua yang ada di tabel"
        '
        'PanelControl11
        '
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl11.Location = New System.Drawing.Point(2, 31)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(168, 5)
        Me.PanelControl11.TabIndex = 7
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.btnCentang)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl10.Location = New System.Drawing.Point(2, 7)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(168, 24)
        Me.PanelControl10.TabIndex = 6
        '
        'btnCentang
        '
        Me.btnCentang.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCentang.Appearance.Options.UseFont = True
        Me.btnCentang.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCentang.Image = CType(resources.GetObject("btnCentang.Image"), System.Drawing.Image)
        Me.btnCentang.Location = New System.Drawing.Point(2, 2)
        Me.btnCentang.Name = "btnCentang"
        Me.btnCentang.Size = New System.Drawing.Size(128, 20)
        Me.btnCentang.TabIndex = 1
        Me.btnCentang.Text = "Centang Semua"
        Me.btnCentang.ToolTip = "Centang Semua yang ada di tabel"
        '
        'PanelControl9
        '
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl9.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(168, 5)
        Me.PanelControl9.TabIndex = 5
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.btnRefresh)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl7.Location = New System.Drawing.Point(312, 2)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(172, 71)
        Me.PanelControl7.TabIndex = 6
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(11, 7)
        Me.btnRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 60)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTip = "Reset Data"
        Me.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnRefresh.ToolTipTitle = "RELOAD"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(310, 71)
        Me.PanelControl3.TabIndex = 4
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.tglAkhir)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 36)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(306, 24)
        Me.PanelControl2.TabIndex = 7
        '
        'tglAkhir
        '
        Me.tglAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglAkhir.EditValue = Nothing
        Me.tglAkhir.Location = New System.Drawing.Point(137, 2)
        Me.tglAkhir.Name = "tglAkhir"
        Me.tglAkhir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglAkhir.Properties.Mask.EditMask = "d MMM yyyy"
        Me.tglAkhir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglAkhir.Properties.ShowPopupShadow = False
        Me.tglAkhir.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tglAkhir.Properties.ValidateOnEnterKey = True
        Me.tglAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglAkhir.Size = New System.Drawing.Size(150, 20)
        Me.tglAkhir.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(127, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Tanggal Akhir Jurnal"
        '
        'PanelControl5
        '
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(2, 31)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(306, 5)
        Me.PanelControl5.TabIndex = 6
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.tglAwal)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 7)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(306, 24)
        Me.PanelControl1.TabIndex = 5
        '
        'tglAwal
        '
        Me.tglAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglAwal.EditValue = Nothing
        Me.tglAwal.Location = New System.Drawing.Point(137, 2)
        Me.tglAwal.Name = "tglAwal"
        Me.tglAwal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglAwal.Properties.Mask.EditMask = "d MMM yyyy"
        Me.tglAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglAwal.Properties.ShowPopupShadow = False
        Me.tglAwal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tglAwal.Properties.ValidateOnEnterKey = True
        Me.tglAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglAwal.Size = New System.Drawing.Size(150, 20)
        Me.tglAwal.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(127, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(125, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tanggal Awal Jurnal"
        '
        'PanelControl4
        '
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(306, 5)
        Me.PanelControl4.TabIndex = 4
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
        Me.pnlTop.Size = New System.Drawing.Size(1006, 34)
        Me.pnlTop.TabIndex = 31
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
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "        FORM POSTING JURNAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 25)
        Me.Panel2.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmPostingJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 545)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPostingJurnal"
        Me.Text = "Form Posting Jurnal"
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPosting.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPosting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookBB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.tglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.tglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcPost As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLookBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_obyek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents val_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvPost As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtpPosting As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cek_post As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCentang2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCentang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tglAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
