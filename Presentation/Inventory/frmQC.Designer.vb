﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQC))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GcBME_d = New DevExpress.XtraGrid.GridControl
        Me.GvBME_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_unpass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ket_satuan_beli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.LookupSup = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txbSJSupplier = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LookupPO = New DevExpress.XtraEditors.LookUpEdit
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GcBME_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBME_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LookupSup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        Me.Panel1.Size = New System.Drawing.Size(792, 34)
        Me.Panel1.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          INSPEKSI BARANG MASUK PO (QC PO)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 23
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcBME_d)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 280)
        Me.Panel5.TabIndex = 2
        '
        'GcBME_d
        '
        Me.GcBME_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBME_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBME_d.MainView = Me.GvBME_d
        Me.GcBME_d.Name = "GcBME_d"
        Me.GcBME_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcBME_d.Size = New System.Drawing.Size(792, 280)
        Me.GcBME_d.TabIndex = 6
        Me.GcBME_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBME_d})
        '
        'GvBME_d
        '
        Me.GvBME_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.kd_satuan, Me.keterangan, Me.qty_order, Me.qty_qc_pass, Me.qty_qc_unpass, Me.hold, Me.qty_sisa, Me.harga, Me.rp_trans, Me.status_hold, Me.ket_satuan_beli})
        Me.GvBME_d.GridControl = Me.GcBME_d
        Me.GvBME_d.Name = "GvBME_d"
        Me.GvBME_d.OptionsCustomization.AllowColumnMoving = False
        Me.GvBME_d.OptionsCustomization.AllowFilter = False
        Me.GvBME_d.OptionsCustomization.AllowGroup = False
        Me.GvBME_d.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBME_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvBME_d.OptionsView.RowAutoHeight = True
        Me.GvBME_d.OptionsView.ShowFooter = True
        Me.GvBME_d.OptionsView.ShowGroupPanel = False
        Me.GvBME_d.OptionsView.ShowPreview = True
        Me.GvBME_d.PaintStyleName = "MixedXP"
        Me.GvBME_d.PreviewFieldName = "spek_brg"
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 205
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 34
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan brg"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 3
        Me.keterangan.Width = 40
        '
        'qty_order
        '
        Me.qty_order.Caption = "Qty Order"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 4
        Me.qty_order.Width = 69
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.qty_qc_pass.AppearanceCell.Options.UseBackColor = True
        Me.qty_qc_pass.Caption = "Qty Good"
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_pass.Visible = True
        Me.qty_qc_pass.VisibleIndex = 5
        Me.qty_qc_pass.Width = 67
        '
        'qty_qc_unpass
        '
        Me.qty_qc_unpass.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.qty_qc_unpass.AppearanceCell.Options.UseBackColor = True
        Me.qty_qc_unpass.Caption = "Qty Tolak"
        Me.qty_qc_unpass.FieldName = "qty_qc_unpass"
        Me.qty_qc_unpass.Name = "qty_qc_unpass"
        Me.qty_qc_unpass.Visible = True
        Me.qty_qc_unpass.VisibleIndex = 6
        Me.qty_qc_unpass.Width = 76
        '
        'hold
        '
        Me.hold.Caption = "Hold"
        Me.hold.FieldName = "hold"
        Me.hold.Name = "hold"
        Me.hold.Visible = True
        Me.hold.VisibleIndex = 7
        Me.hold.Width = 29
        '
        'qty_sisa
        '
        Me.qty_sisa.Caption = "Qty Sisa"
        Me.qty_sisa.FieldName = "qty_sisa"
        Me.qty_sisa.Name = "qty_sisa"
        Me.qty_sisa.Visible = True
        Me.qty_sisa.VisibleIndex = 8
        Me.qty_sisa.Width = 54
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 9
        Me.harga.Width = 79
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "jml_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Visible = True
        Me.rp_trans.VisibleIndex = 10
        Me.rp_trans.Width = 39
        '
        'status_hold
        '
        Me.status_hold.Caption = "status_hold"
        Me.status_hold.FieldName = "status_hold"
        Me.status_hold.Name = "status_hold"
        Me.status_hold.Visible = True
        Me.status_hold.VisibleIndex = 11
        Me.status_hold.Width = 62
        '
        'ket_satuan_beli
        '
        Me.ket_satuan_beli.Caption = "Ket Satuan Beli"
        Me.ket_satuan_beli.FieldName = "ket_satuan_beli"
        Me.ket_satuan_beli.Name = "ket_satuan_beli"
        Me.ket_satuan_beli.Visible = True
        Me.ket_satuan_beli.VisibleIndex = 12
        '
        'RL_GdgAsal
        '
        Me.RL_GdgAsal.AutoHeight = False
        Me.RL_GdgAsal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgAsal.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgAsal.Name = "RL_GdgAsal"
        Me.RL_GdgAsal.NullText = ""
        '
        'RL_GdgTujuan
        '
        Me.RL_GdgTujuan.AutoHeight = False
        Me.RL_GdgTujuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgTujuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgTujuan.Name = "RL_GdgTujuan"
        Me.RL_GdgTujuan.NullText = ""
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
        Me.pnl.Size = New System.Drawing.Size(792, 408)
        Me.pnl.TabIndex = 147
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 376)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 32)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LookupSup)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txbSJSupplier)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.LookupPO)
        Me.Panel3.Controls.Add(Me.txbNoTrans)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 96)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(464, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "Supplier"
        '
        'LookupSup
        '
        Me.LookupSup.Location = New System.Drawing.Point(568, 70)
        Me.LookupSup.Name = "LookupSup"
        Me.LookupSup.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LookupSup.Properties.Appearance.Options.UseBackColor = True
        Me.LookupSup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupSup.Properties.DisplayMember = "no_po"
        Me.LookupSup.Properties.NullText = "[Supplier]"
        Me.LookupSup.Properties.ReadOnly = True
        Me.LookupSup.Properties.ValueMember = "no_po"
        Me.LookupSup.Size = New System.Drawing.Size(212, 20)
        Me.LookupSup.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "No. SJ Supplier"
        '
        'txbSJSupplier
        '
        Me.txbSJSupplier.BackColor = System.Drawing.Color.White
        Me.txbSJSupplier.Location = New System.Drawing.Point(111, 70)
        Me.txbSJSupplier.Name = "txbSJSupplier"
        Me.txbSJSupplier.Size = New System.Drawing.Size(212, 20)
        Me.txbSJSupplier.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "No PO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(464, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "No Transaksi"
        '
        'LookupPO
        '
        Me.LookupPO.AllowDrop = True
        Me.LookupPO.Location = New System.Drawing.Point(111, 40)
        Me.LookupPO.Name = "LookupPO"
        Me.LookupPO.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LookupPO.Properties.Appearance.Options.UseBackColor = True
        Me.LookupPO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupPO.Properties.DisplayMember = "no_po"
        Me.LookupPO.Properties.NullText = "[klik disini]"
        Me.LookupPO.Properties.ValueMember = "no_po"
        Me.LookupPO.Size = New System.Drawing.Size(212, 20)
        Me.LookupPO.TabIndex = 173
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(568, 43)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(212, 20)
        Me.txbNoTrans.TabIndex = 172
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 408)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 146
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmQC"
        Me.Text = "frmQC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GcBME_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBME_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LookupSup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GcBME_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBME_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_unpass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LookupPO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents status_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txbSJSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LookupSup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents ket_satuan_beli As DevExpress.XtraGrid.Columns.GridColumn
End Class
