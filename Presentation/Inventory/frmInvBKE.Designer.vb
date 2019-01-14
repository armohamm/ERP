<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvBKE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvBKE))
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.slesai = New System.Windows.Forms.Button
        Me.lblRcnKrm = New System.Windows.Forms.Label
        Me.LookDPB = New DevExpress.XtraEditors.LookUpEdit
        Me.btnHapus = New System.Windows.Forms.Button
        Me.lblBarcDel = New System.Windows.Forms.Label
        Me.TxbBarcDel = New System.Windows.Forms.TextBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GcBKE_d = New DevExpress.XtraGrid.GridControl
        Me.GvBKE_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp_dtl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tinggi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gudang_asal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gudang_tujuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_pol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_batal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.aliasbrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deskripsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.akhir_qty_onstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyGudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtySaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblNmBrg = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblRcnKrm1 = New System.Windows.Forms.Label
        Me.txbBarcode = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.CbRcnKrm = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LookDPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbRcnKrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
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
        Me.Panel1.Size = New System.Drawing.Size(1016, 34)
        Me.Panel1.TabIndex = 139
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          DAFTAR PENGIRIMAN BARANG "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.slesai)
        Me.Panel2.Controls.Add(Me.lblRcnKrm)
        Me.Panel2.Controls.Add(Me.LookDPB)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.lblBarcDel)
        Me.Panel2.Controls.Add(Me.TxbBarcDel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 37)
        Me.Panel2.TabIndex = 140
        '
        'slesai
        '
        Me.slesai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.slesai.Location = New System.Drawing.Point(694, 8)
        Me.slesai.Name = "slesai"
        Me.slesai.Size = New System.Drawing.Size(75, 23)
        Me.slesai.TabIndex = 181
        Me.slesai.Text = "Selesai"
        Me.slesai.UseVisualStyleBackColor = False
        '
        'lblRcnKrm
        '
        Me.lblRcnKrm.AutoSize = True
        Me.lblRcnKrm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcnKrm.ForeColor = System.Drawing.Color.White
        Me.lblRcnKrm.Location = New System.Drawing.Point(93, 11)
        Me.lblRcnKrm.Name = "lblRcnKrm"
        Me.lblRcnKrm.Size = New System.Drawing.Size(87, 15)
        Me.lblRcnKrm.TabIndex = 180
        Me.lblRcnKrm.Text = "No Renc Kirim"
        '
        'LookDPB
        '
        Me.LookDPB.Location = New System.Drawing.Point(186, 9)
        Me.LookDPB.Name = "LookDPB"
        Me.LookDPB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookDPB.Properties.NullText = "[No Rencana Kirim]"
        Me.LookDPB.Size = New System.Drawing.Size(155, 20)
        Me.LookDPB.TabIndex = 158
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(12, 7)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 157
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'lblBarcDel
        '
        Me.lblBarcDel.AutoSize = True
        Me.lblBarcDel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcDel.ForeColor = System.Drawing.Color.White
        Me.lblBarcDel.Location = New System.Drawing.Point(377, 12)
        Me.lblBarcDel.Name = "lblBarcDel"
        Me.lblBarcDel.Size = New System.Drawing.Size(87, 15)
        Me.lblBarcDel.TabIndex = 156
        Me.lblBarcDel.Text = "Kode Barcode"
        '
        'TxbBarcDel
        '
        Me.TxbBarcDel.BackColor = System.Drawing.Color.White
        Me.TxbBarcDel.Location = New System.Drawing.Point(470, 9)
        Me.TxbBarcDel.Name = "TxbBarcDel"
        Me.TxbBarcDel.Size = New System.Drawing.Size(213, 20)
        Me.TxbBarcDel.TabIndex = 155
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1016, 473)
        Me.pnl.TabIndex = 141
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcBKE_d)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1016, 332)
        Me.Panel5.TabIndex = 2
        '
        'GcBKE_d
        '
        Me.GcBKE_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBKE_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBKE_d.MainView = Me.GvBKE_d
        Me.GcBKE_d.Name = "GcBKE_d"
        Me.GcBKE_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcBKE_d.Size = New System.Drawing.Size(1016, 332)
        Me.GcBKE_d.TabIndex = 6
        Me.GcBKE_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBKE_d})
        '
        'GvBKE_d
        '
        Me.GvBKE_d.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBKE_d.Appearance.OddRow.Options.UseBackColor = True
        Me.GvBKE_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp_dtl, Me.no_ref, Me.no_sp, Me.kd_stok, Me.kd_satuan, Me.panjang, Me.lebar, Me.tinggi, Me.qty_order, Me.qty_out, Me.qty_sisa, Me.gudang_asal, Me.gudang_tujuan, Me.rp_trans, Me.harga, Me.no_pol, Me.sopir, Me.qty_batal, Me.aliasbrg, Me.no_seq, Me.deskripsi, Me.akhir_qty_onstok, Me.QtyGudang, Me.QtySaldo, Me.keterangan})
        Me.GvBKE_d.GridControl = Me.GcBKE_d
        Me.GvBKE_d.Name = "GvBKE_d"
        Me.GvBKE_d.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBKE_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvBKE_d.OptionsView.RowAutoHeight = True
        Me.GvBKE_d.OptionsView.ShowFooter = True
        Me.GvBKE_d.PaintStyleName = "Web"
        '
        'no_sp_dtl
        '
        Me.no_sp_dtl.Caption = "Urut SP"
        Me.no_sp_dtl.FieldName = "no_sp_dtl"
        Me.no_sp_dtl.Name = "no_sp_dtl"
        Me.no_sp_dtl.OptionsColumn.AllowEdit = False
        Me.no_sp_dtl.OptionsColumn.ReadOnly = True
        Me.no_sp_dtl.Width = 52
        '
        'no_ref
        '
        Me.no_ref.Caption = "No Rencana Kirim"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.AllowEdit = False
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 1
        Me.no_ref.Width = 96
        '
        'no_sp
        '
        Me.no_sp.Caption = "No SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 2
        Me.no_sp.Width = 86
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "kd_stok"
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Width = 138
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 5
        Me.kd_satuan.Width = 53
        '
        'panjang
        '
        Me.panjang.Caption = "P"
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.OptionsColumn.AllowEdit = False
        Me.panjang.OptionsColumn.ReadOnly = True
        Me.panjang.Width = 20
        '
        'lebar
        '
        Me.lebar.Caption = "L"
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.OptionsColumn.AllowEdit = False
        Me.lebar.OptionsColumn.ReadOnly = True
        Me.lebar.Width = 20
        '
        'tinggi
        '
        Me.tinggi.Caption = "T"
        Me.tinggi.FieldName = "tinggi"
        Me.tinggi.Name = "tinggi"
        Me.tinggi.OptionsColumn.AllowEdit = False
        Me.tinggi.OptionsColumn.ReadOnly = True
        Me.tinggi.Width = 20
        '
        'qty_order
        '
        Me.qty_order.Caption = "Qty Order"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 8
        Me.qty_order.Width = 61
        '
        'qty_out
        '
        Me.qty_out.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.qty_out.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_out.AppearanceCell.Options.UseBackColor = True
        Me.qty_out.AppearanceCell.Options.UseFont = True
        Me.qty_out.Caption = "Qty Out"
        Me.qty_out.FieldName = "qty_out"
        Me.qty_out.Name = "qty_out"
        Me.qty_out.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_out.Visible = True
        Me.qty_out.VisibleIndex = 9
        Me.qty_out.Width = 64
        '
        'qty_sisa
        '
        Me.qty_sisa.Caption = "Sisa"
        Me.qty_sisa.FieldName = "qty_sisa"
        Me.qty_sisa.Name = "qty_sisa"
        Me.qty_sisa.OptionsColumn.AllowEdit = False
        Me.qty_sisa.OptionsColumn.ReadOnly = True
        Me.qty_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_sisa.UnboundExpression = "[qty_order] - [qty_out]"
        Me.qty_sisa.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.qty_sisa.Visible = True
        Me.qty_sisa.VisibleIndex = 10
        Me.qty_sisa.Width = 49
        '
        'gudang_asal
        '
        Me.gudang_asal.Caption = "Gudang Asal"
        Me.gudang_asal.ColumnEdit = Me.RL_GdgAsal
        Me.gudang_asal.FieldName = "gudang_asal"
        Me.gudang_asal.Name = "gudang_asal"
        Me.gudang_asal.OptionsColumn.AllowEdit = False
        Me.gudang_asal.OptionsColumn.ReadOnly = True
        Me.gudang_asal.Width = 22
        '
        'RL_GdgAsal
        '
        Me.RL_GdgAsal.AutoHeight = False
        Me.RL_GdgAsal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgAsal.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgAsal.Name = "RL_GdgAsal"
        Me.RL_GdgAsal.NullText = ""
        '
        'gudang_tujuan
        '
        Me.gudang_tujuan.Caption = "Gudang Tujuan"
        Me.gudang_tujuan.ColumnEdit = Me.RL_GdgTujuan
        Me.gudang_tujuan.FieldName = "gudang_tujuan"
        Me.gudang_tujuan.Name = "gudang_tujuan"
        Me.gudang_tujuan.OptionsColumn.AllowEdit = False
        Me.gudang_tujuan.OptionsColumn.ReadOnly = True
        Me.gudang_tujuan.Width = 22
        '
        'RL_GdgTujuan
        '
        Me.RL_GdgTujuan.AutoHeight = False
        Me.RL_GdgTujuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgTujuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgTujuan.Name = "RL_GdgTujuan"
        Me.RL_GdgTujuan.NullText = ""
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "rp_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.OptionsColumn.AllowEdit = False
        Me.rp_trans.OptionsColumn.ReadOnly = True
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Width = 44
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.OptionsColumn.ReadOnly = True
        Me.harga.Width = 28
        '
        'no_pol
        '
        Me.no_pol.Caption = "no_pol"
        Me.no_pol.FieldName = "no_pol"
        Me.no_pol.Name = "no_pol"
        Me.no_pol.OptionsColumn.AllowEdit = False
        Me.no_pol.OptionsColumn.ReadOnly = True
        Me.no_pol.Width = 37
        '
        'sopir
        '
        Me.sopir.Caption = "sopir"
        Me.sopir.FieldName = "sopir"
        Me.sopir.Name = "sopir"
        Me.sopir.OptionsColumn.AllowEdit = False
        Me.sopir.OptionsColumn.ReadOnly = True
        Me.sopir.Width = 37
        '
        'qty_batal
        '
        Me.qty_batal.Caption = "batal"
        Me.qty_batal.FieldName = "qty_batal"
        Me.qty_batal.Name = "qty_batal"
        Me.qty_batal.OptionsColumn.AllowEdit = False
        Me.qty_batal.OptionsColumn.ReadOnly = True
        Me.qty_batal.Visible = True
        Me.qty_batal.VisibleIndex = 11
        Me.qty_batal.Width = 101
        '
        'aliasbrg
        '
        Me.aliasbrg.Caption = "aliasbrg"
        Me.aliasbrg.FieldName = "aliasbrg"
        Me.aliasbrg.Name = "aliasbrg"
        Me.aliasbrg.OptionsColumn.AllowEdit = False
        Me.aliasbrg.OptionsColumn.ReadOnly = True
        Me.aliasbrg.Width = 58
        '
        'no_seq
        '
        Me.no_seq.Caption = "No DPB"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 44
        '
        'deskripsi
        '
        Me.deskripsi.Caption = "Nama Barang"
        Me.deskripsi.FieldName = "deskripsi"
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.OptionsColumn.AllowEdit = False
        Me.deskripsi.OptionsColumn.ReadOnly = True
        Me.deskripsi.Visible = True
        Me.deskripsi.VisibleIndex = 4
        Me.deskripsi.Width = 214
        '
        'akhir_qty_onstok
        '
        Me.akhir_qty_onstok.Caption = "Tersedia"
        Me.akhir_qty_onstok.FieldName = "akhir_qty_onstok"
        Me.akhir_qty_onstok.Name = "akhir_qty_onstok"
        Me.akhir_qty_onstok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'QtyGudang
        '
        Me.QtyGudang.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QtyGudang.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyGudang.AppearanceCell.Options.UseBackColor = True
        Me.QtyGudang.AppearanceCell.Options.UseFont = True
        Me.QtyGudang.Caption = "Qty Gdg"
        Me.QtyGudang.FieldName = "qtyGudang"
        Me.QtyGudang.Name = "QtyGudang"
        Me.QtyGudang.OptionsColumn.AllowEdit = False
        Me.QtyGudang.OptionsColumn.AllowFocus = False
        Me.QtyGudang.Visible = True
        Me.QtyGudang.VisibleIndex = 6
        Me.QtyGudang.Width = 51
        '
        'QtySaldo
        '
        Me.QtySaldo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QtySaldo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.QtySaldo.AppearanceCell.Options.UseBackColor = True
        Me.QtySaldo.AppearanceCell.Options.UseFont = True
        Me.QtySaldo.Caption = "Qty Saldo"
        Me.QtySaldo.FieldName = "qtySaldo"
        Me.QtySaldo.Name = "QtySaldo"
        Me.QtySaldo.OptionsColumn.AllowEdit = False
        Me.QtySaldo.OptionsColumn.AllowFocus = False
        Me.QtySaldo.Visible = True
        Me.QtySaldo.VisibleIndex = 7
        Me.QtySaldo.Width = 63
        '
        'keterangan
        '
        Me.keterangan.Caption = "Atas Nama"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 3
        Me.keterangan.Width = 67
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblNmBrg)
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Controls.Add(Me.lblRcnKrm1)
        Me.Panel4.Controls.Add(Me.txbBarcode)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 405)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1016, 68)
        Me.Panel4.TabIndex = 1
        '
        'lblNmBrg
        '
        Me.lblNmBrg.AutoSize = True
        Me.lblNmBrg.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmBrg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNmBrg.Location = New System.Drawing.Point(471, 8)
        Me.lblNmBrg.Name = "lblNmBrg"
        Me.lblNmBrg.Size = New System.Drawing.Size(0, 16)
        Me.lblNmBrg.TabIndex = 157
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(323, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 156
        '
        'lblRcnKrm1
        '
        Me.lblRcnKrm1.AutoSize = True
        Me.lblRcnKrm1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcnKrm1.ForeColor = System.Drawing.Color.White
        Me.lblRcnKrm1.Location = New System.Drawing.Point(9, 8)
        Me.lblRcnKrm1.Name = "lblRcnKrm1"
        Me.lblRcnKrm1.Size = New System.Drawing.Size(87, 15)
        Me.lblRcnKrm1.TabIndex = 155
        Me.lblRcnKrm1.Text = "Kode Barcode"
        '
        'txbBarcode
        '
        Me.txbBarcode.BackColor = System.Drawing.Color.White
        Me.txbBarcode.Location = New System.Drawing.Point(104, 6)
        Me.txbBarcode.Name = "txbBarcode"
        Me.txbBarcode.Size = New System.Drawing.Size(213, 20)
        Me.txbBarcode.TabIndex = 154
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lookupBulanAwal)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.CbRcnKrm)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1016, 73)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(353, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Periode "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(413, 44)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(187, 20)
        Me.lookupBulanAwal.TabIndex = 184
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(616, 37)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 30)
        Me.cmdRefresh.TabIndex = 183
        Me.cmdRefresh.Text = "c"
        '
        'CbRcnKrm
        '
        Me.CbRcnKrm.EditValue = "[Pilih No Rencana Kirim]"
        Me.CbRcnKrm.Location = New System.Drawing.Point(113, 44)
        Me.CbRcnKrm.Name = "CbRcnKrm"
        Me.CbRcnKrm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CbRcnKrm.Properties.Appearance.Options.UseBackColor = True
        Me.CbRcnKrm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbRcnKrm.Properties.SelectAllItemCaption = "(Pilih Semua)"
        Me.CbRcnKrm.Size = New System.Drawing.Size(179, 20)
        Me.CbRcnKrm.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Rencana Kirim"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmInvBKE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmInvBKE"
        Me.Text = "frmInvBKE"
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LookDPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbRcnKrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GcBKE_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBKE_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp_dtl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblRcnKrm1 As System.Windows.Forms.Label
    Friend WithEvents txbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNmBrg As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gudang_asal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gudang_tujuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CbRcnKrm As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblBarcDel As System.Windows.Forms.Label
    Friend WithEvents TxbBarcDel As System.Windows.Forms.TextBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents LookDPB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblRcnKrm As System.Windows.Forms.Label
    Friend WithEvents slesai As System.Windows.Forms.Button
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tinggi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_pol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_batal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents aliasbrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deskripsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents akhir_qty_onstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtySaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
