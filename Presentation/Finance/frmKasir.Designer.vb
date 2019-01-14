<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKasir))
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLookBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLookBP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dketerangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.xx = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPost = New DevExpress.XtraGrid.GridControl
        Me.gvPost = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.noref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dePosting = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.verifikasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ceCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCentang2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCentang = New DevExpress.XtraEditors.SimpleButton
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookBP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePosting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePosting.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_buku_besar, Me.kd_buku_pusat, Me.saldo_val_debet, Me.saldo_val_kredit, Me.saldo_rp_debet, Me.saldo_rp_kredit, Me.dketerangan, Me.xx})
        Me.gvDetil.GridControl = Me.gcPost
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsCustomization.AllowColumnMoving = False
        Me.gvDetil.OptionsCustomization.AllowColumnResizing = False
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
        Me.kd_buku_besar.Width = 151
        '
        'lueLookBB
        '
        Me.lueLookBB.AutoHeight = False
        Me.lueLookBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookBB.Name = "lueLookBB"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.Caption = "Pusat Biaya"
        Me.kd_buku_pusat.ColumnEdit = Me.lueLookBP
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 2
        '
        'lueLookBP
        '
        Me.lueLookBP.AutoHeight = False
        Me.lueLookBP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookBP.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.lueLookBP.Name = "lueLookBP"
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
        Me.saldo_val_debet.VisibleIndex = 3
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
        Me.saldo_val_kredit.VisibleIndex = 4
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
        Me.saldo_rp_debet.VisibleIndex = 5
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
        Me.saldo_rp_kredit.VisibleIndex = 6
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
        Me.dketerangan.VisibleIndex = 7
        Me.dketerangan.Width = 192
        '
        'xx
        '
        Me.xx.Caption = "GridColumn1"
        Me.xx.FieldName = "no_jur"
        Me.xx.Name = "xx"
        '
        'gcPost
        '
        Me.gcPost.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvDetil
        GridLevelNode1.RelationName = "lvlJurnalDetil"
        Me.gcPost.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcPost.Location = New System.Drawing.Point(0, 0)
        Me.gcPost.LookAndFeel.SkinName = "Blue"
        Me.gcPost.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.gcPost.LookAndFeel.UseWindowsXPTheme = True
        Me.gcPost.MainView = Me.gvPost
        Me.gcPost.Name = "gcPost"
        Me.gcPost.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceCek, Me.lueTrans, Me.lueBB, Me.dePosting, Me.lueLookBB, Me.lueLookBP, Me.lookSupplier})
        Me.gcPost.Size = New System.Drawing.Size(1006, 274)
        Me.gcPost.TabIndex = 0
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
        Me.gvPost.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_jur, Me.tgl_trans, Me.noref, Me.tipe_trans, Me.kd_kartu, Me.kd_valuta, Me.jml_val_trans, Me.jml_rp_trans, Me.keterangan, Me.rek_attribute1, Me.tgl_posting, Me.verifikasi})
        Me.gvPost.GridControl = Me.gcPost
        Me.gvPost.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data."
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
        Me.gvPost.OptionsView.ShowGroupedColumns = True
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
        Me.no_jur.VisibleIndex = 0
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
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 100
        '
        'noref
        '
        Me.noref.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noref.AppearanceHeader.Options.UseBackColor = True
        Me.noref.AppearanceHeader.Options.UseFont = True
        Me.noref.Caption = "No. Ref"
        Me.noref.FieldName = "noref"
        Me.noref.Name = "noref"
        Me.noref.OptionsColumn.ReadOnly = True
        Me.noref.Visible = True
        Me.noref.VisibleIndex = 2
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
        Me.tipe_trans.VisibleIndex = 3
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
        'kd_kartu
        '
        Me.kd_kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_kartu.AppearanceHeader.Options.UseBackColor = True
        Me.kd_kartu.AppearanceHeader.Options.UseFont = True
        Me.kd_kartu.Caption = "Kepada"
        Me.kd_kartu.ColumnEdit = Me.lookSupplier
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.OptionsColumn.ReadOnly = True
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 4
        Me.kd_kartu.Width = 100
        '
        'lookSupplier
        '
        Me.lookSupplier.AutoHeight = False
        Me.lookSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookSupplier.Name = "lookSupplier"
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
        Me.kd_valuta.VisibleIndex = 5
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
        Me.jml_val_trans.VisibleIndex = 6
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
        Me.jml_rp_trans.VisibleIndex = 7
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
        Me.keterangan.VisibleIndex = 8
        '
        'rek_attribute1
        '
        Me.rek_attribute1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rek_attribute1.AppearanceHeader.Options.UseBackColor = True
        Me.rek_attribute1.AppearanceHeader.Options.UseFont = True
        Me.rek_attribute1.Caption = "Rek. Kas/Bank"
        Me.rek_attribute1.ColumnEdit = Me.lueBB
        Me.rek_attribute1.FieldName = "rek_attribute1"
        Me.rek_attribute1.Name = "rek_attribute1"
        Me.rek_attribute1.Visible = True
        Me.rek_attribute1.VisibleIndex = 9
        '
        'lueBB
        '
        Me.lueBB.AutoHeight = False
        Me.lueBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBB.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Rekening")})
        Me.lueBB.Name = "lueBB"
        Me.lueBB.NullText = "[Rekening]"
        '
        'tgl_posting
        '
        Me.tgl_posting.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_posting.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_posting.AppearanceHeader.Options.UseFont = True
        Me.tgl_posting.Caption = "Tgl. Verifikasi"
        Me.tgl_posting.ColumnEdit = Me.dePosting
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 10
        Me.tgl_posting.Width = 88
        '
        'dePosting
        '
        Me.dePosting.AutoHeight = False
        Me.dePosting.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dePosting.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.dePosting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePosting.Name = "dePosting"
        Me.dePosting.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'verifikasi
        '
        Me.verifikasi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verifikasi.AppearanceHeader.Options.UseBackColor = True
        Me.verifikasi.AppearanceHeader.Options.UseFont = True
        Me.verifikasi.Caption = "Verifikasi"
        Me.verifikasi.ColumnEdit = Me.ceCek
        Me.verifikasi.FieldName = "verifikasi"
        Me.verifikasi.Name = "verifikasi"
        Me.verifikasi.Visible = True
        Me.verifikasi.VisibleIndex = 11
        Me.verifikasi.Width = 83
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
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1006, 342)
        Me.pnl.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gcPost)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 274)
        Me.Panel1.TabIndex = 3
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
        Me.Label1.Text = "        FORM KASIR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.btnCentang2)
        Me.Panel2.Controls.Add(Me.btnCentang)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 308)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 34)
        Me.Panel2.TabIndex = 2
        '
        'btnCentang2
        '
        Me.btnCentang2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCentang2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCentang2.Appearance.Options.UseFont = True
        Me.btnCentang2.Image = CType(resources.GetObject("btnCentang2.Image"), System.Drawing.Image)
        Me.btnCentang2.Location = New System.Drawing.Point(827, 6)
        Me.btnCentang2.Name = "btnCentang2"
        Me.btnCentang2.Size = New System.Drawing.Size(165, 23)
        Me.btnCentang2.TabIndex = 3
        Me.btnCentang2.Text = "Tidak Centang Semua"
        Me.btnCentang2.ToolTip = "Centang Semua yang ada di tabel"
        '
        'btnCentang
        '
        Me.btnCentang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCentang.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCentang.Appearance.Options.UseFont = True
        Me.btnCentang.Image = CType(resources.GetObject("btnCentang.Image"), System.Drawing.Image)
        Me.btnCentang.Location = New System.Drawing.Point(693, 6)
        Me.btnCentang.Name = "btnCentang"
        Me.btnCentang.Size = New System.Drawing.Size(128, 23)
        Me.btnCentang.TabIndex = 2
        Me.btnCentang.Text = "Centang Semua"
        Me.btnCentang.ToolTip = "Centang Semua yang ada di tabel"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(48, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Proses + Cetak Semua"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'frmKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 342)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmKasir"
        Me.Text = "Form Posting Kasir"
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookBP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePosting.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePosting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gcPost As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gvPost As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_attribute1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents verifikasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lueTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dePosting As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lueLookBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLookBP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents xx As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCentang2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCentang As DevExpress.XtraEditors.SimpleButton
End Class
