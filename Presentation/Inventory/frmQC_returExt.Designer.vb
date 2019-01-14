<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQC_returExt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQC_returExt))
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txbSJSupplier = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.tgl_retur = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LookupCust = New DevExpress.XtraEditors.LookUpEdit
        Me.txbToko = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GvQCsvc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sumQc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcQCsvc = New DevExpress.XtraGrid.GridControl
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.tgl_retur.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_retur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.LookupCust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvQCsvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcQCsvc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.DropDownRows = 15
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Penerima :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.TabIndex = 151
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          INSPEKSI BARANG MASUK RETUR PENJUALAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 362)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 32)
        Me.Panel4.TabIndex = 1
        '
        'txbSJSupplier
        '
        Me.txbSJSupplier.BackColor = System.Drawing.Color.White
        Me.txbSJSupplier.Location = New System.Drawing.Point(3, 43)
        Me.txbSJSupplier.Name = "txbSJSupplier"
        Me.txbSJSupplier.Size = New System.Drawing.Size(184, 20)
        Me.txbSJSupplier.TabIndex = 182
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 66)
        Me.Panel3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(495, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(117, 66)
        Me.Panel6.TabIndex = 197
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "Tanggal Retur :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 21)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "No Transaksi :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txbNoTrans)
        Me.Panel9.Controls.Add(Me.tgl_retur)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(612, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(180, 66)
        Me.Panel9.TabIndex = 200
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(6, 0)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(171, 20)
        Me.txbNoTrans.TabIndex = 172
        '
        'tgl_retur
        '
        Me.tgl_retur.EditValue = Nothing
        Me.tgl_retur.Location = New System.Drawing.Point(6, 22)
        Me.tgl_retur.Name = "tgl_retur"
        Me.tgl_retur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_retur.Properties.Appearance.Options.UseFont = True
        Me.tgl_retur.Properties.Appearance.Options.UseTextOptions = True
        Me.tgl_retur.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_retur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_retur.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tgl_retur.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_retur.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tgl_retur.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_retur.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_retur.Size = New System.Drawing.Size(171, 20)
        Me.tgl_retur.TabIndex = 196
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.LookupCust)
        Me.Panel8.Controls.Add(Me.txbToko)
        Me.Panel8.Controls.Add(Me.txbSJSupplier)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(121, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 66)
        Me.Panel8.TabIndex = 199
        '
        'LookupCust
        '
        Me.LookupCust.Location = New System.Drawing.Point(3, 1)
        Me.LookupCust.Name = "LookupCust"
        Me.LookupCust.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LookupCust.Properties.Appearance.Options.UseBackColor = True
        Me.LookupCust.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupCust.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Nama Toko")})
        Me.LookupCust.Properties.DropDownRows = 15
        Me.LookupCust.Properties.NullText = "[klik disini]"
        Me.LookupCust.Size = New System.Drawing.Size(184, 20)
        Me.LookupCust.TabIndex = 193
        '
        'txbToko
        '
        Me.txbToko.BackColor = System.Drawing.Color.White
        Me.txbToko.Location = New System.Drawing.Point(3, 22)
        Me.txbToko.Name = "txbToko"
        Me.txbToko.Size = New System.Drawing.Size(184, 20)
        Me.txbToko.TabIndex = 191
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(121, 66)
        Me.Panel7.TabIndex = 198
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 21)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "No Referensi :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 21)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Toko asal :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 152
        '
        'GvQCsvc
        '
        Me.GvQCsvc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.kd_satuan, Me.keterangan, Me.qty_order, Me.qty_qc_pass, Me.qty_qc_service, Me.harga, Me.rp_trans, Me.status_hold, Me.sumQc, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GvQCsvc.GridControl = Me.GcQCsvc
        Me.GvQCsvc.Name = "GvQCsvc"
        Me.GvQCsvc.OptionsCustomization.AllowColumnMoving = False
        Me.GvQCsvc.OptionsCustomization.AllowFilter = False
        Me.GvQCsvc.OptionsCustomization.AllowGroup = False
        Me.GvQCsvc.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvQCsvc.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvQCsvc.OptionsView.RowAutoHeight = True
        Me.GvQCsvc.OptionsView.ShowFooter = True
        Me.GvQCsvc.OptionsView.ShowGroupPanel = False
        Me.GvQCsvc.PaintStyleName = "Style3D"
        Me.GvQCsvc.PreviewFieldName = "spek_brg"
        '
        'no_seq
        '
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 41
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 391
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.AllowFocus = False
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 69
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 198
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Order"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Width = 63
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.qty_qc_pass.AppearanceCell.Options.UseBackColor = True
        Me.qty_qc_pass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_pass.Caption = "Qty QC"
        Me.qty_qc_pass.DisplayFormat.FormatString = "n2"
        Me.qty_qc_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_pass.Visible = True
        Me.qty_qc_pass.VisibleIndex = 3
        Me.qty_qc_pass.Width = 76
        '
        'qty_qc_service
        '
        Me.qty_qc_service.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.qty_qc_service.AppearanceCell.Options.UseBackColor = True
        Me.qty_qc_service.Caption = "Qty Service/Rusak"
        Me.qty_qc_service.FieldName = "qty_qc_service"
        Me.qty_qc_service.Name = "qty_qc_service"
        Me.qty_qc_service.Width = 76
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Width = 78
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "jml_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Width = 49
        '
        'status_hold
        '
        Me.status_hold.Caption = "status_hold"
        Me.status_hold.FieldName = "status_hold"
        Me.status_hold.Name = "status_hold"
        Me.status_hold.Width = 62
        '
        'sumQc
        '
        Me.sumQc.Caption = "Total QC"
        Me.sumQc.FieldName = "TotalQC"
        Me.sumQc.Name = "sumQc"
        Me.sumQc.OptionsColumn.AllowEdit = False
        Me.sumQc.OptionsColumn.AllowFocus = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "gudang_tujuan"
        Me.GridColumn1.FieldName = "gudang_tujuan"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "kd_buku_besar"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "kd_buku_biaya"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "kd_ukuran"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GcQCsvc
        '
        Me.GcQCsvc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcQCsvc.Location = New System.Drawing.Point(0, 0)
        Me.GcQCsvc.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcQCsvc.MainView = Me.GvQCsvc
        Me.GcQCsvc.Name = "GcQCsvc"
        Me.GcQCsvc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcQCsvc.Size = New System.Drawing.Size(792, 296)
        Me.GcQCsvc.TabIndex = 6
        Me.GcQCsvc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvQCsvc})
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcQCsvc)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 296)
        Me.Panel5.TabIndex = 2
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 34)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 394)
        Me.pnl.TabIndex = 153
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmQC_returExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 428)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQC_returExt"
        Me.Text = "frmQC_returExt"
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.tgl_retur.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_retur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.LookupCust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvQCsvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcQCsvc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txbSJSupplier As System.Windows.Forms.TextBox
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents status_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvQCsvc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcQCsvc As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sumQc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LookupCust As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txbToko As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tgl_retur As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
