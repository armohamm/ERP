<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMonPiutLain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMonPiutLain))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlIsi = New System.Windows.Forms.Panel
        Me.pnlLunas = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.gcLunas = New DevExpress.XtraGrid.GridControl
        Me.gvLunas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_trans_d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting_l = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan_l = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar_l = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.pnlDetil = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.gcDetil = New DevExpress.XtraGrid.GridControl
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_jurnal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlPiut = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.gcPiutang = New DevExpress.XtraGrid.GridControl
        Me.gvPiutang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.pnlFull = New System.Windows.Forms.Panel
        Me.chkLunas = New DevExpress.XtraEditors.CheckEdit
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.chkDetil = New DevExpress.XtraEditors.CheckEdit
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.chkPiut = New DevExpress.XtraEditors.CheckEdit
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.pnlNav = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.pnlTrans = New System.Windows.Forms.Panel
        Me.txtNoTrans = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlKaryawan = New System.Windows.Forms.Panel
        Me.lueKaryawan = New DevExpress.XtraEditors.LookUpEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlTanggal = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.deTglAkhir = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl.SuspendLayout()
        Me.pnlIsi.SuspendLayout()
        Me.pnlLunas.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.gcLunas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLunas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.pnlDetil.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlPiut.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.gcPiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.pnlFull.SuspendLayout()
        CType(Me.chkLunas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDetil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPiut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNav.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.pnlTrans.SuspendLayout()
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKaryawan.SuspendLayout()
        CType(Me.lueKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTanggal.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.deTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlIsi)
        Me.pnl.Controls.Add(Me.Panel18)
        Me.pnl.Controls.Add(Me.Panel7)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(801, 717)
        Me.pnl.TabIndex = 144
        '
        'pnlIsi
        '
        Me.pnlIsi.Controls.Add(Me.pnlLunas)
        Me.pnlIsi.Controls.Add(Me.pnlDetil)
        Me.pnlIsi.Controls.Add(Me.pnlPiut)
        Me.pnlIsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIsi.Location = New System.Drawing.Point(0, 159)
        Me.pnlIsi.Name = "pnlIsi"
        Me.pnlIsi.Size = New System.Drawing.Size(801, 538)
        Me.pnlIsi.TabIndex = 157
        '
        'pnlLunas
        '
        Me.pnlLunas.Controls.Add(Me.Panel8)
        Me.pnlLunas.Controls.Add(Me.Panel9)
        Me.pnlLunas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLunas.Location = New System.Drawing.Point(0, 350)
        Me.pnlLunas.Name = "pnlLunas"
        Me.pnlLunas.Size = New System.Drawing.Size(801, 188)
        Me.pnlLunas.TabIndex = 149
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.gcLunas)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 30)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(801, 158)
        Me.Panel8.TabIndex = 148
        '
        'gcLunas
        '
        Me.gcLunas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLunas.Location = New System.Drawing.Point(0, 0)
        Me.gcLunas.MainView = Me.gvLunas
        Me.gcLunas.Name = "gcLunas"
        Me.gcLunas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.gcLunas.Size = New System.Drawing.Size(801, 158)
        Me.gcLunas.TabIndex = 146
        Me.gcLunas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLunas})
        '
        'gvLunas
        '
        Me.gvLunas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_trans_d, Me.tgl_trans, Me.no_trans, Me.tgl_posting_l, Me.keterangan_l, Me.jml_bayar_l})
        Me.gvLunas.GridControl = Me.gcLunas
        Me.gvLunas.Name = "gvLunas"
        Me.gvLunas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLunas.OptionsBehavior.Editable = False
        Me.gvLunas.OptionsBehavior.ReadOnly = True
        Me.gvLunas.OptionsView.EnableAppearanceEvenRow = True
        Me.gvLunas.OptionsView.EnableAppearanceOddRow = True
        Me.gvLunas.OptionsView.ShowFooter = True
        Me.gvLunas.OptionsView.ShowGroupPanel = False
        '
        'no_trans_d
        '
        Me.no_trans_d.Caption = "No. Trans"
        Me.no_trans_d.FieldName = "no_trans_d"
        Me.no_trans_d.Name = "no_trans_d"
        Me.no_trans_d.Visible = True
        Me.no_trans_d.VisibleIndex = 0
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        '
        'no_trans
        '
        Me.no_trans.Caption = "No. Jurnal"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 2
        '
        'tgl_posting_l
        '
        Me.tgl_posting_l.Caption = "Tgl. Posting"
        Me.tgl_posting_l.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_posting_l.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting_l.FieldName = "tgl_posting_l"
        Me.tgl_posting_l.Name = "tgl_posting_l"
        Me.tgl_posting_l.Visible = True
        Me.tgl_posting_l.VisibleIndex = 3
        '
        'keterangan_l
        '
        Me.keterangan_l.Caption = "Keterangan"
        Me.keterangan_l.FieldName = "keterangan_l"
        Me.keterangan_l.Name = "keterangan_l"
        Me.keterangan_l.Visible = True
        Me.keterangan_l.VisibleIndex = 4
        '
        'jml_bayar_l
        '
        Me.jml_bayar_l.Caption = "Jumlah"
        Me.jml_bayar_l.DisplayFormat.FormatString = "n2"
        Me.jml_bayar_l.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar_l.FieldName = "jml_bayar_l"
        Me.jml_bayar_l.Name = "jml_bayar_l"
        Me.jml_bayar_l.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar_l.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar_l.Visible = True
        Me.jml_bayar_l.VisibleIndex = 5
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(801, 30)
        Me.Panel9.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(799, 28)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "DATA PELUNASAN"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDetil
        '
        Me.pnlDetil.Controls.Add(Me.Panel6)
        Me.pnlDetil.Controls.Add(Me.Panel1)
        Me.pnlDetil.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDetil.Location = New System.Drawing.Point(0, 175)
        Me.pnlDetil.Name = "pnlDetil"
        Me.pnlDetil.Size = New System.Drawing.Size(801, 175)
        Me.pnlDetil.TabIndex = 148
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.gcDetil)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 145)
        Me.Panel6.TabIndex = 148
        '
        'gcDetil
        '
        Me.gcDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDetil.Location = New System.Drawing.Point(0, 0)
        Me.gcDetil.MainView = Me.gvDetil
        Me.gcDetil.Name = "gcDetil"
        Me.gcDetil.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.gcDetil.Size = New System.Drawing.Size(801, 145)
        Me.gcDetil.TabIndex = 146
        Me.gcDetil.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetil})
        '
        'gvDetil
        '
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.tgl_inv, Me.no_jurnal, Me.tgl_posting, Me.keterangan, Me.jml_tagihan, Me.jml_bayar, Me.jml_akhir})
        Me.gvDetil.GridControl = Me.gcDetil
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsBehavior.Editable = False
        Me.gvDetil.OptionsBehavior.ReadOnly = True
        Me.gvDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetil.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetil.OptionsView.ShowFooter = True
        Me.gvDetil.OptionsView.ShowGroupPanel = False
        '
        'no_inv
        '
        Me.no_inv.Caption = "No. Trans"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        '
        'tgl_inv
        '
        Me.tgl_inv.Caption = "Tanggal"
        Me.tgl_inv.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        '
        'no_jurnal
        '
        Me.no_jurnal.Caption = "No. Jurnal"
        Me.no_jurnal.FieldName = "no_jurnal"
        Me.no_jurnal.Name = "no_jurnal"
        Me.no_jurnal.OptionsColumn.AllowEdit = False
        Me.no_jurnal.Visible = True
        Me.no_jurnal.VisibleIndex = 2
        '
        'tgl_posting
        '
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.tgl_posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.OptionsColumn.AllowEdit = False
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 3
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        '
        'jml_tagihan
        '
        Me.jml_tagihan.Caption = "Jml. Piutang"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_tagihan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 5
        '
        'jml_bayar
        '
        Me.jml_bayar.Caption = "Jml. Bayar"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.OptionsColumn.AllowEdit = False
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 6
        '
        'jml_akhir
        '
        Me.jml_akhir.Caption = "Sisa Piutang"
        Me.jml_akhir.DisplayFormat.FormatString = "n2"
        Me.jml_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_akhir.FieldName = "jml_akhir"
        Me.jml_akhir.Name = "jml_akhir"
        Me.jml_akhir.OptionsColumn.AllowEdit = False
        Me.jml_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_akhir.Visible = True
        Me.jml_akhir.VisibleIndex = 7
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 30)
        Me.Panel1.TabIndex = 146
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(799, 28)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "DATA RINCIAN TRANSAKSI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPiut
        '
        Me.pnlPiut.Controls.Add(Me.Panel4)
        Me.pnlPiut.Controls.Add(Me.Panel3)
        Me.pnlPiut.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPiut.Location = New System.Drawing.Point(0, 0)
        Me.pnlPiut.Name = "pnlPiut"
        Me.pnlPiut.Size = New System.Drawing.Size(801, 175)
        Me.pnlPiut.TabIndex = 147
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gcPiutang)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(801, 145)
        Me.Panel4.TabIndex = 147
        '
        'gcPiutang
        '
        Me.gcPiutang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPiutang.Location = New System.Drawing.Point(0, 0)
        Me.gcPiutang.MainView = Me.gvPiutang
        Me.gcPiutang.Name = "gcPiutang"
        Me.gcPiutang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookBB, Me.lookKartu})
        Me.gcPiutang.Size = New System.Drawing.Size(801, 145)
        Me.gcPiutang.TabIndex = 146
        Me.gcPiutang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPiutang})
        '
        'gvPiutang
        '
        Me.gvPiutang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.kd_buku_besar, Me.kd_cust, Me.sisa})
        Me.gvPiutang.GridControl = Me.gcPiutang
        Me.gvPiutang.Name = "gvPiutang"
        Me.gvPiutang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPiutang.OptionsBehavior.Editable = False
        Me.gvPiutang.OptionsBehavior.ReadOnly = True
        Me.gvPiutang.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPiutang.OptionsView.EnableAppearanceOddRow = True
        Me.gvPiutang.OptionsView.ShowFooter = True
        Me.gvPiutang.OptionsView.ShowGroupPanel = False
        '
        'nomor
        '
        Me.nomor.Caption = "Nomor"
        Me.nomor.FieldName = "nomer"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Jenis Piutang"
        Me.kd_buku_besar.ColumnEdit = Me.lookBB
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        '
        'lookBB
        '
        Me.lookBB.AutoHeight = False
        Me.lookBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookBB.Name = "lookBB"
        Me.lookBB.NullText = "[Jenis Piutang]"
        '
        'kd_cust
        '
        Me.kd_cust.Caption = "Nama Kartu"
        Me.kd_cust.ColumnEdit = Me.lookKartu
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 2
        '
        'lookKartu
        '
        Me.lookKartu.AutoHeight = False
        Me.lookKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookKartu.Name = "lookKartu"
        Me.lookKartu.NullText = "[Nama]"
        '
        'sisa
        '
        Me.sisa.Caption = "Sisa Piutang"
        Me.sisa.DisplayFormat.FormatString = "n2"
        Me.sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa.FieldName = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.SummaryItem.DisplayFormat = "{0:n2}"
        Me.sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sisa.Visible = True
        Me.sisa.VisibleIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 30)
        Me.Panel3.TabIndex = 145
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(799, 28)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "DATA PIUTANG LAIN-LAIN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.pnlFull)
        Me.Panel18.Controls.Add(Me.Panel17)
        Me.Panel18.Controls.Add(Me.pnlNav)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 44)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(801, 115)
        Me.Panel18.TabIndex = 156
        '
        'pnlFull
        '
        Me.pnlFull.Controls.Add(Me.chkLunas)
        Me.pnlFull.Controls.Add(Me.Panel24)
        Me.pnlFull.Controls.Add(Me.chkDetil)
        Me.pnlFull.Controls.Add(Me.Panel23)
        Me.pnlFull.Controls.Add(Me.chkPiut)
        Me.pnlFull.Controls.Add(Me.Panel22)
        Me.pnlFull.Controls.Add(Me.Label11)
        Me.pnlFull.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFull.Location = New System.Drawing.Point(360, 0)
        Me.pnlFull.Name = "pnlFull"
        Me.pnlFull.Size = New System.Drawing.Size(150, 115)
        Me.pnlFull.TabIndex = 153
        '
        'chkLunas
        '
        Me.chkLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLunas.Location = New System.Drawing.Point(0, 75)
        Me.chkLunas.Name = "chkLunas"
        Me.chkLunas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkLunas.Properties.Appearance.Options.UseFont = True
        Me.chkLunas.Properties.AutoHeight = False
        Me.chkLunas.Properties.Caption = "View Piutang Lunas"
        Me.chkLunas.Size = New System.Drawing.Size(150, 20)
        Me.chkLunas.TabIndex = 160
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 70)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(150, 5)
        Me.Panel24.TabIndex = 159
        '
        'chkDetil
        '
        Me.chkDetil.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkDetil.Location = New System.Drawing.Point(0, 50)
        Me.chkDetil.Name = "chkDetil"
        Me.chkDetil.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDetil.Properties.Appearance.Options.UseFont = True
        Me.chkDetil.Properties.AutoHeight = False
        Me.chkDetil.Properties.Caption = "View Detil Piutang"
        Me.chkDetil.Size = New System.Drawing.Size(150, 20)
        Me.chkDetil.TabIndex = 158
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 45)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(150, 5)
        Me.Panel23.TabIndex = 157
        '
        'chkPiut
        '
        Me.chkPiut.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkPiut.Location = New System.Drawing.Point(0, 25)
        Me.chkPiut.Name = "chkPiut"
        Me.chkPiut.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkPiut.Properties.Appearance.Options.UseFont = True
        Me.chkPiut.Properties.AutoHeight = False
        Me.chkPiut.Properties.Caption = "View Piutang"
        Me.chkPiut.Size = New System.Drawing.Size(150, 20)
        Me.chkPiut.TabIndex = 156
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 20)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(150, 5)
        Me.Panel22.TabIndex = 155
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 20)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Filter View"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(300, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(60, 115)
        Me.Panel17.TabIndex = 148
        '
        'pnlNav
        '
        Me.pnlNav.Controls.Add(Me.Panel16)
        Me.pnlNav.Controls.Add(Me.Panel15)
        Me.pnlNav.Controls.Add(Me.Panel14)
        Me.pnlNav.Controls.Add(Me.Panel13)
        Me.pnlNav.Controls.Add(Me.pnlTrans)
        Me.pnlNav.Controls.Add(Me.pnlKaryawan)
        Me.pnlNav.Controls.Add(Me.pnlTanggal)
        Me.pnlNav.Controls.Add(Me.Panel12)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(300, 115)
        Me.pnlNav.TabIndex = 147
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.btnRefresh)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 80)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(300, 30)
        Me.Panel16.TabIndex = 157
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(200, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 149
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 75)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(300, 5)
        Me.Panel15.TabIndex = 156
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 70)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(300, 5)
        Me.Panel14.TabIndex = 155
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 65)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(300, 5)
        Me.Panel13.TabIndex = 154
        '
        'pnlTrans
        '
        Me.pnlTrans.Controls.Add(Me.txtNoTrans)
        Me.pnlTrans.Controls.Add(Me.Label10)
        Me.pnlTrans.Controls.Add(Me.Label3)
        Me.pnlTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTrans.Location = New System.Drawing.Point(0, 45)
        Me.pnlTrans.Name = "pnlTrans"
        Me.pnlTrans.Size = New System.Drawing.Size(300, 20)
        Me.pnlTrans.TabIndex = 152
        '
        'txtNoTrans
        '
        Me.txtNoTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoTrans.Location = New System.Drawing.Point(110, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.Size = New System.Drawing.Size(190, 20)
        Me.txtNoTrans.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(100, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No. Transaksi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlKaryawan
        '
        Me.pnlKaryawan.Controls.Add(Me.lueKaryawan)
        Me.pnlKaryawan.Controls.Add(Me.Label9)
        Me.pnlKaryawan.Controls.Add(Me.Label2)
        Me.pnlKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKaryawan.Location = New System.Drawing.Point(0, 25)
        Me.pnlKaryawan.Name = "pnlKaryawan"
        Me.pnlKaryawan.Size = New System.Drawing.Size(300, 20)
        Me.pnlKaryawan.TabIndex = 153
        '
        'lueKaryawan
        '
        Me.lueKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lueKaryawan.Location = New System.Drawing.Point(110, 0)
        Me.lueKaryawan.Name = "lueKaryawan"
        Me.lueKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKaryawan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama Karyawan")})
        Me.lueKaryawan.Properties.NullText = "[Nama Karyawan]"
        Me.lueKaryawan.Size = New System.Drawing.Size(190, 20)
        Me.lueKaryawan.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(100, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kartu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTanggal
        '
        Me.pnlTanggal.Controls.Add(Me.Panel11)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTanggal.Location = New System.Drawing.Point(0, 5)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(300, 20)
        Me.pnlTanggal.TabIndex = 151
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.deTglAkhir)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(250, 20)
        Me.Panel11.TabIndex = 148
        '
        'deTglAkhir
        '
        Me.deTglAkhir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deTglAkhir.EditValue = Nothing
        Me.deTglAkhir.Location = New System.Drawing.Point(110, 0)
        Me.deTglAkhir.Name = "deTglAkhir"
        Me.deTglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglAkhir.Properties.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.deTglAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglAkhir.Size = New System.Drawing.Size(140, 20)
        Me.deTglAkhir.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(300, 5)
        Me.Panel12.TabIndex = 150
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 34)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(801, 10)
        Me.Panel7.TabIndex = 146
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 697)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 20)
        Me.Panel2.TabIndex = 145
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 34)
        Me.Panel5.TabIndex = 144
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "         MONITORING PIUTANG LAIN-LAIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'formMonPiutLain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 717)
        Me.Controls.Add(Me.pnl)
        Me.Name = "formMonPiutLain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monitoring Piutang Lain-Lain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        Me.pnlIsi.ResumeLayout(False)
        Me.pnlLunas.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.gcLunas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLunas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.pnlDetil.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlPiut.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.gcPiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.pnlFull.ResumeLayout(False)
        CType(Me.chkLunas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDetil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPiut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNav.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.pnlTrans.ResumeLayout(False)
        CType(Me.txtNoTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKaryawan.ResumeLayout(False)
        CType(Me.lueKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTanggal.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.deTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlIsi As System.Windows.Forms.Panel
    Friend WithEvents pnlLunas As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents gcLunas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLunas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_trans_d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting_l As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan_l As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar_l As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlDetil As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gcDetil As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_jurnal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlPiut As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents gcPiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents pnlFull As System.Windows.Forms.Panel
    Friend WithEvents chkLunas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents chkDetil As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents chkPiut As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents pnlTrans As System.Windows.Forms.Panel
    Friend WithEvents txtNoTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlKaryawan As System.Windows.Forms.Panel
    Friend WithEvents lueKaryawan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents deTglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
End Class
