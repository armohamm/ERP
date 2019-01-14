<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifyJurAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerifyJurAR))
        Me.gvNotaDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLookBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tot_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcJAR = New DevExpress.XtraGrid.GridControl
        Me.gvNota = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLookTT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtpTglTrans = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLookKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_jurnal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlBwh = New System.Windows.Forms.Panel
        Me.ckcetak = New DevExpress.XtraEditors.CheckEdit
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcJAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookTT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTglTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTglTrans.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLookKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBwh.SuspendLayout()
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvNotaDetil
        '
        Me.gvNotaDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.satuan, Me.Qty, Me.harga, Me.tot_diskon, Me.jml_val_trans})
        Me.gvNotaDetil.GridControl = Me.gcJAR
        Me.gvNotaDetil.Name = "gvNotaDetil"
        Me.gvNotaDetil.OptionsBehavior.Editable = False
        Me.gvNotaDetil.OptionsBehavior.ReadOnly = True
        Me.gvNotaDetil.OptionsView.ShowGroupPanel = False
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama Stok"
        Me.kd_stok.ColumnEdit = Me.lueLookBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        '
        'lueLookBarang
        '
        Me.lueLookBarang.AutoHeight = False
        Me.lueLookBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookBarang.Name = "lueLookBarang"
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 2
        '
        'Qty
        '
        Me.Qty.Caption = "Jumlah"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 4
        '
        'tot_diskon
        '
        Me.tot_diskon.Caption = "Total Diskon"
        Me.tot_diskon.DisplayFormat.FormatString = "n2"
        Me.tot_diskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tot_diskon.FieldName = "tot_diskon"
        Me.tot_diskon.Name = "tot_diskon"
        Me.tot_diskon.Visible = True
        Me.tot_diskon.VisibleIndex = 5
        '
        'jml_val_trans
        '
        Me.jml_val_trans.Caption = "Jumlah Valuta"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 6
        '
        'gcJAR
        '
        Me.gcJAR.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvNotaDetil
        GridLevelNode1.RelationName = "lvlNotaDetil"
        Me.gcJAR.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcJAR.Location = New System.Drawing.Point(0, 0)
        Me.gcJAR.MainView = Me.gvNota
        Me.gcJAR.Name = "gcJAR"
        Me.gcJAR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CekStat, Me.lueLookTT, Me.lueLookKartu, Me.lueLookBarang, Me.dtpTglTrans})
        Me.gcJAR.Size = New System.Drawing.Size(965, 401)
        Me.gcJAR.TabIndex = 30
        Me.gcJAR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNota, Me.gvNotaDetil})
        '
        'gvNota
        '
        Me.gvNota.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvNota.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvNota.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.gvNota.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.no_inv, Me.tgl_inv, Me.no_ref1, Me.kd_cust, Me.keterangan, Me.jml_tagihan, Me.sts_jurnal})
        Me.gvNota.GridControl = Me.gcJAR
        Me.gvNota.Name = "gvNota"
        Me.gvNota.OptionsCustomization.AllowColumnMoving = False
        Me.gvNota.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvNota.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvNota.OptionsView.AutoCalcPreviewLineCount = True
        Me.gvNota.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNota.OptionsView.EnableAppearanceOddRow = True
        Me.gvNota.OptionsView.ShowGroupPanel = False
        Me.gvNota.PaintStyleName = "Office2003"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.Options.UseBackColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "No. Trans"
        Me.tipe_trans.ColumnEdit = Me.lueLookTT
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.AllowEdit = False
        Me.tipe_trans.OptionsColumn.ReadOnly = True
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 0
        Me.tipe_trans.Width = 161
        '
        'lueLookTT
        '
        Me.lueLookTT.AutoHeight = False
        Me.lueLookTT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookTT.Name = "lueLookTT"
        Me.lueLookTT.NullText = "[Nomor Transaksi kosong]"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "No. Trans"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.AllowEdit = False
        Me.no_inv.OptionsColumn.ReadOnly = True
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 1
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceCell.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tgl. Trans"
        Me.tgl_inv.ColumnEdit = Me.dtpTglTrans
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.OptionsColumn.ReadOnly = True
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 2
        '
        'dtpTglTrans
        '
        Me.dtpTglTrans.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpTglTrans.AutoHeight = False
        Me.dtpTglTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTglTrans.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTglTrans.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTglTrans.Mask.EditMask = "d MMM yyyy"
        Me.dtpTglTrans.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTglTrans.Name = "dtpTglTrans"
        Me.dtpTglTrans.ShowPopupShadow = False
        Me.dtpTglTrans.ValidateOnEnterKey = True
        Me.dtpTglTrans.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'no_ref1
        '
        Me.no_ref1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref1.AppearanceHeader.Options.UseFont = True
        Me.no_ref1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref1.Caption = "No. Ref."
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.OptionsColumn.AllowEdit = False
        Me.no_ref1.OptionsColumn.ReadOnly = True
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 3
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Nama Customer"
        Me.kd_cust.ColumnEdit = Me.lueLookKartu
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.OptionsColumn.AllowEdit = False
        Me.kd_cust.OptionsColumn.ReadOnly = True
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 4
        '
        'lueLookKartu
        '
        Me.lueLookKartu.AutoHeight = False
        Me.lueLookKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLookKartu.Name = "lueLookKartu"
        Me.lueLookKartu.NullText = "[Nama Customer Kosong]"
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jml. Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.OptionsColumn.ReadOnly = True
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 6
        '
        'sts_jurnal
        '
        Me.sts_jurnal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sts_jurnal.AppearanceHeader.Options.UseFont = True
        Me.sts_jurnal.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_jurnal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_jurnal.Caption = "Cek Jurnal"
        Me.sts_jurnal.ColumnEdit = Me.CekStat
        Me.sts_jurnal.FieldName = "sts_jurnal"
        Me.sts_jurnal.Name = "sts_jurnal"
        Me.sts_jurnal.Visible = True
        Me.sts_jurnal.VisibleIndex = 7
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
        Me.CekStat.ValueUnchecked = ""
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.pnlBwh)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(965, 470)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gcJAR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 401)
        Me.Panel2.TabIndex = 33
        '
        'pnlBwh
        '
        Me.pnlBwh.BackColor = System.Drawing.Color.Maroon
        Me.pnlBwh.Controls.Add(Me.ckcetak)
        Me.pnlBwh.Controls.Add(Me.btnDel)
        Me.pnlBwh.Controls.Add(Me.btnExit)
        Me.pnlBwh.Controls.Add(Me.cmdSimpan)
        Me.pnlBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBwh.Location = New System.Drawing.Point(0, 435)
        Me.pnlBwh.Name = "pnlBwh"
        Me.pnlBwh.Size = New System.Drawing.Size(965, 35)
        Me.pnlBwh.TabIndex = 32
        '
        'ckcetak
        '
        Me.ckcetak.Location = New System.Drawing.Point(873, 10)
        Me.ckcetak.Name = "ckcetak"
        Me.ckcetak.Properties.Caption = "Cetak semua"
        Me.ckcetak.Size = New System.Drawing.Size(89, 19)
        Me.ckcetak.TabIndex = 28
        Me.ckcetak.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(482, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
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
        Me.cmdSimpan.UseVisualStyleBackColor = True
        Me.cmdSimpan.Visible = False
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
        Me.pnlTop.Size = New System.Drawing.Size(965, 34)
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
        Me.Label1.Text = "         DAFTAR NOTA PIUTANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVerifyJurAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 470)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmVerifyJurAR"
        Me.Text = "frmVerifyJurnalAR"
        CType(Me.gvNotaDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcJAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookTT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTglTrans.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTglTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLookKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlBwh.ResumeLayout(False)
        CType(Me.ckcetak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlBwh As System.Windows.Forms.Panel
    Friend WithEvents ckcetak As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gcJAR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gvNotaDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tot_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_jurnal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLookTT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lueLookKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lueLookBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtpTglTrans As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
