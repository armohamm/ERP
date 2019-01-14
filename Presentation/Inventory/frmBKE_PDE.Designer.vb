<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBKE_PDE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBKE_PDE))
        Me.img_small = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txbBarcode = New System.Windows.Forms.TextBox
        Me.txbNmTrima = New System.Windows.Forms.TextBox
        Me.CbRcnKrm = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.pnl_bwh = New System.Windows.Forms.Panel
        Me.lblBarcDel = New System.Windows.Forms.Label
        Me.slesai = New DevExpress.XtraEditors.SimpleButton
        Me.TxbBarcDel = New System.Windows.Forms.TextBox
        Me.LookRcnKrm = New DevExpress.XtraEditors.LookUpEdit
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnl_grid = New System.Windows.Forms.Panel
        Me.GcBKE_d = New DevExpress.XtraGrid.GridControl
        Me.GvBKE_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_pol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1.SuspendLayout()
        CType(Me.CbRcnKrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bwh.SuspendLayout()
        CType(Me.LookRcnKrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnl_grid.SuspendLayout()
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_small
        '
        Me.img_small.ImageStream = CType(resources.GetObject("img_small.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_small.TransparentColor = System.Drawing.Color.Transparent
        Me.img_small.Images.SetKeyName(0, "")
        Me.img_small.Images.SetKeyName(1, "")
        Me.img_small.Images.SetKeyName(2, "")
        Me.img_small.Images.SetKeyName(3, "")
        Me.img_small.Images.SetKeyName(4, "")
        Me.img_small.Images.SetKeyName(5, "")
        Me.img_small.Images.SetKeyName(6, "")
        Me.img_small.Images.SetKeyName(7, "")
        Me.img_small.Images.SetKeyName(8, "")
        Me.img_small.Images.SetKeyName(9, "")
        Me.img_small.Images.SetKeyName(10, "")
        Me.img_small.Images.SetKeyName(11, "")
        Me.img_small.Images.SetKeyName(12, "")
        Me.img_small.Images.SetKeyName(13, "")
        Me.img_small.Images.SetKeyName(14, "")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txbBarcode)
        Me.Panel1.Controls.Add(Me.txbNmTrima)
        Me.Panel1.Controls.Add(Me.CbRcnKrm)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "Kode"
        '
        'txbBarcode
        '
        Me.txbBarcode.BackColor = System.Drawing.Color.White
        Me.txbBarcode.Location = New System.Drawing.Point(34, 28)
        Me.txbBarcode.Name = "txbBarcode"
        Me.txbBarcode.Size = New System.Drawing.Size(149, 20)
        Me.txbBarcode.TabIndex = 155
        '
        'txbNmTrima
        '
        Me.txbNmTrima.BackColor = System.Drawing.Color.White
        Me.txbNmTrima.Location = New System.Drawing.Point(213, 3)
        Me.txbNmTrima.Name = "txbNmTrima"
        Me.txbNmTrima.Size = New System.Drawing.Size(97, 20)
        Me.txbNmTrima.TabIndex = 184
        '
        'CbRcnKrm
        '
        Me.CbRcnKrm.EditValue = "[Pilih No Rencana Kirim]"
        Me.CbRcnKrm.Location = New System.Drawing.Point(36, 3)
        Me.CbRcnKrm.Name = "CbRcnKrm"
        Me.CbRcnKrm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CbRcnKrm.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbRcnKrm.Properties.Appearance.Options.UseBackColor = True
        Me.CbRcnKrm.Properties.Appearance.Options.UseFont = True
        Me.CbRcnKrm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbRcnKrm.Properties.SelectAllItemCaption = "(Pilih Semua)"
        Me.CbRcnKrm.Size = New System.Drawing.Size(173, 21)
        Me.CbRcnKrm.TabIndex = 183
        '
        'btnBatal
        '
        Me.btnBatal.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.Appearance.Options.UseFont = True
        Me.btnBatal.Enabled = False
        Me.btnBatal.ImageIndex = 8
        Me.btnBatal.ImageList = Me.img_small
        Me.btnBatal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(254, 23)
        Me.btnBatal.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnBatal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 27)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Rcn:"
        '
        'btnOK
        '
        Me.btnOK.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOK.Appearance.Options.UseFont = True
        Me.btnOK.Enabled = False
        Me.btnOK.ImageIndex = 3
        Me.btnOK.ImageList = Me.img_small
        Me.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(189, 24)
        Me.btnOK.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnOK.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(44, 27)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        '
        'pnl_bwh
        '
        Me.pnl_bwh.Controls.Add(Me.lblBarcDel)
        Me.pnl_bwh.Controls.Add(Me.slesai)
        Me.pnl_bwh.Controls.Add(Me.TxbBarcDel)
        Me.pnl_bwh.Controls.Add(Me.LookRcnKrm)
        Me.pnl_bwh.Controls.Add(Me.btnHapus)
        Me.pnl_bwh.Controls.Add(Me.btnSimpan)
        Me.pnl_bwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bwh.Location = New System.Drawing.Point(0, 274)
        Me.pnl_bwh.Name = "pnl_bwh"
        Me.pnl_bwh.Size = New System.Drawing.Size(312, 52)
        Me.pnl_bwh.TabIndex = 1
        '
        'lblBarcDel
        '
        Me.lblBarcDel.AutoSize = True
        Me.lblBarcDel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcDel.ForeColor = System.Drawing.Color.Black
        Me.lblBarcDel.Location = New System.Drawing.Point(5, 32)
        Me.lblBarcDel.Name = "lblBarcDel"
        Me.lblBarcDel.Size = New System.Drawing.Size(35, 14)
        Me.lblBarcDel.TabIndex = 185
        Me.lblBarcDel.Text = "Kode"
        '
        'slesai
        '
        Me.slesai.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.slesai.Appearance.Options.UseFont = True
        Me.slesai.Enabled = False
        Me.slesai.ImageIndex = 3
        Me.slesai.ImageList = Me.img_small
        Me.slesai.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.slesai.Location = New System.Drawing.Point(242, 24)
        Me.slesai.LookAndFeel.SkinName = "The Asphalt World"
        Me.slesai.LookAndFeel.UseDefaultLookAndFeel = False
        Me.slesai.Name = "slesai"
        Me.slesai.Size = New System.Drawing.Size(66, 27)
        Me.slesai.TabIndex = 161
        Me.slesai.Text = "Selesai"
        '
        'TxbBarcDel
        '
        Me.TxbBarcDel.BackColor = System.Drawing.Color.White
        Me.TxbBarcDel.Location = New System.Drawing.Point(46, 29)
        Me.TxbBarcDel.Name = "TxbBarcDel"
        Me.TxbBarcDel.Size = New System.Drawing.Size(182, 20)
        Me.TxbBarcDel.TabIndex = 160
        '
        'LookRcnKrm
        '
        Me.LookRcnKrm.Location = New System.Drawing.Point(46, 4)
        Me.LookRcnKrm.Name = "LookRcnKrm"
        Me.LookRcnKrm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookRcnKrm.Properties.NullText = "[No Rencana Kirim]"
        Me.LookRcnKrm.Size = New System.Drawing.Size(182, 20)
        Me.LookRcnKrm.TabIndex = 159
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(3, 0)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(37, 27)
        Me.btnHapus.TabIndex = 158
        Me.btnHapus.Text = "DEL"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.Appearance.Options.UseFont = True
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.ImageIndex = 4
        Me.btnSimpan.ImageList = Me.img_small
        Me.btnSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(243, 3)
        Me.btnSimpan.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnSimpan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(66, 27)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Save"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnl_grid)
        Me.pnl.Controls.Add(Me.pnl_bwh)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(312, 326)
        Me.pnl.TabIndex = 2
        '
        'pnl_grid
        '
        Me.pnl_grid.Controls.Add(Me.GcBKE_d)
        Me.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_grid.Location = New System.Drawing.Point(0, 53)
        Me.pnl_grid.Name = "pnl_grid"
        Me.pnl_grid.Size = New System.Drawing.Size(312, 221)
        Me.pnl_grid.TabIndex = 2
        '
        'GcBKE_d
        '
        Me.GcBKE_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBKE_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBKE_d.MainView = Me.GvBKE_d
        Me.GcBKE_d.Name = "GcBKE_d"
        Me.GcBKE_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcBKE_d.Size = New System.Drawing.Size(312, 221)
        Me.GcBKE_d.TabIndex = 7
        Me.GcBKE_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBKE_d})
        '
        'GvBKE_d
        '
        Me.GvBKE_d.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBKE_d.Appearance.OddRow.Options.UseBackColor = True
        Me.GvBKE_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.qty_order, Me.qty_out, Me.qty_sisa, Me.rp_trans, Me.harga, Me.no_pol, Me.sopir})
        Me.GvBKE_d.GridControl = Me.GcBKE_d
        Me.GvBKE_d.Name = "GvBKE_d"
        Me.GvBKE_d.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBKE_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvBKE_d.OptionsView.RowAutoHeight = True
        Me.GvBKE_d.OptionsView.ShowFooter = True
        Me.GvBKE_d.PaintStyleName = "Web"
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 20
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
        Me.kd_stok.Width = 82
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'qty_order
        '
        Me.qty_order.Caption = "Ord"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 2
        Me.qty_order.Width = 37
        '
        'qty_out
        '
        Me.qty_out.Caption = "Out"
        Me.qty_out.FieldName = "qty_out"
        Me.qty_out.Name = "qty_out"
        Me.qty_out.OptionsColumn.AllowEdit = False
        Me.qty_out.OptionsColumn.ReadOnly = True
        Me.qty_out.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_out.Visible = True
        Me.qty_out.VisibleIndex = 3
        Me.qty_out.Width = 34
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
        Me.qty_sisa.VisibleIndex = 4
        Me.qty_sisa.Width = 32
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "rp_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.OptionsColumn.AllowEdit = False
        Me.rp_trans.OptionsColumn.ReadOnly = True
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Visible = True
        Me.rp_trans.VisibleIndex = 6
        Me.rp_trans.Width = 29
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 5
        Me.harga.Width = 20
        '
        'no_pol
        '
        Me.no_pol.Caption = "no_pol"
        Me.no_pol.FieldName = "no_pol"
        Me.no_pol.Name = "no_pol"
        Me.no_pol.Visible = True
        Me.no_pol.VisibleIndex = 7
        Me.no_pol.Width = 26
        '
        'sopir
        '
        Me.sopir.Caption = "sopir"
        Me.sopir.FieldName = "sopir"
        Me.sopir.Name = "sopir"
        Me.sopir.Visible = True
        Me.sopir.VisibleIndex = 8
        Me.sopir.Width = 23
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
        'frmBKE_PDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 326)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBKE_PDE"
        Me.Text = "frmBKE_PDE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CbRcnKrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_bwh.ResumeLayout(False)
        Me.pnl_bwh.PerformLayout()
        CType(Me.LookRcnKrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl_grid.ResumeLayout(False)
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_small As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl_bwh As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnl_grid As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbRcnKrm As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents LookRcnKrm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TxbBarcDel As System.Windows.Forms.TextBox
    Friend WithEvents txbNmTrima As System.Windows.Forms.TextBox
    Friend WithEvents slesai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBarcDel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents GcBKE_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBKE_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_pol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
End Class
