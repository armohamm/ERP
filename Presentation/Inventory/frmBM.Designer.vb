<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBM))
        Me.lblNmBrg = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxbBarcode = New System.Windows.Forms.TextBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GcBM = New DevExpress.XtraGrid.GridControl
        Me.GvBM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gudang_asal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_gdg_asal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gudang_tujuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_gdg_tujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tinggi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.dteTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtcari = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxbPenerima = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GcBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_gdg_asal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_gdg_tujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNmBrg
        '
        Me.lblNmBrg.AutoSize = True
        Me.lblNmBrg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmBrg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNmBrg.Location = New System.Drawing.Point(491, 9)
        Me.lblNmBrg.Name = "lblNmBrg"
        Me.lblNmBrg.Size = New System.Drawing.Size(0, 15)
        Me.lblNmBrg.TabIndex = 157
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
        Me.Panel1.Size = New System.Drawing.Size(1000, 38)
        Me.Panel1.TabIndex = 148
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
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
        Me.Label1.Size = New System.Drawing.Size(403, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Barang Masuk Bebas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(352, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 156
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblNmBrg)
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxbBarcode)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 467)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 43)
        Me.Panel4.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Kode Barcode"
        '
        'TxbBarcode
        '
        Me.TxbBarcode.BackColor = System.Drawing.Color.White
        Me.TxbBarcode.Location = New System.Drawing.Point(107, 9)
        Me.TxbBarcode.Name = "TxbBarcode"
        Me.TxbBarcode.Size = New System.Drawing.Size(218, 20)
        Me.TxbBarcode.TabIndex = 154
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
        Me.pnl.Size = New System.Drawing.Size(1000, 510)
        Me.pnl.TabIndex = 150
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcBM)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 183)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1000, 284)
        Me.Panel5.TabIndex = 2
        '
        'GcBM
        '
        Me.GcBM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBM.Location = New System.Drawing.Point(0, 0)
        Me.GcBM.MainView = Me.GvBM
        Me.GcBM.Name = "GcBM"
        Me.GcBM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_Barang, Me.RL_gdg_asal, Me.RL_gdg_tujuan})
        Me.GcBM.Size = New System.Drawing.Size(1000, 284)
        Me.GcBM.TabIndex = 155
        Me.GcBM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBM})
        '
        'GvBM
        '
        Me.GvBM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.kd_satuan, Me.qty_in, Me.gudang_asal, Me.gudang_tujuan, Me.rp_trans, Me.harga, Me.panjang, Me.lebar, Me.tinggi})
        Me.GvBM.GridControl = Me.GcBM
        Me.GvBM.Name = "GvBM"
        Me.GvBM.OptionsCustomization.AllowColumnMoving = False
        Me.GvBM.OptionsCustomization.AllowFilter = False
        Me.GvBM.OptionsCustomization.AllowGroup = False
        Me.GvBM.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBM.OptionsView.RowAutoHeight = True
        Me.GvBM.OptionsView.ShowGroupPanel = False
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
        Me.no_seq.Width = 35
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RL_Barang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 332
        '
        'RL_Barang
        '
        Me.RL_Barang.AutoHeight = False
        Me.RL_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_Barang.Name = "RL_Barang"
        Me.RL_Barang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 46
        '
        'qty_in
        '
        Me.qty_in.Caption = "Qty Masuk"
        Me.qty_in.FieldName = "qty_in"
        Me.qty_in.Name = "qty_in"
        Me.qty_in.Visible = True
        Me.qty_in.VisibleIndex = 3
        Me.qty_in.Width = 63
        '
        'gudang_asal
        '
        Me.gudang_asal.Caption = "Gudang Asal"
        Me.gudang_asal.ColumnEdit = Me.RL_gdg_asal
        Me.gudang_asal.FieldName = "gudang_asal"
        Me.gudang_asal.Name = "gudang_asal"
        Me.gudang_asal.Visible = True
        Me.gudang_asal.VisibleIndex = 4
        Me.gudang_asal.Width = 74
        '
        'RL_gdg_asal
        '
        Me.RL_gdg_asal.AutoHeight = False
        Me.RL_gdg_asal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_gdg_asal.Name = "RL_gdg_asal"
        Me.RL_gdg_asal.NullText = "Gudang Asal"
        '
        'gudang_tujuan
        '
        Me.gudang_tujuan.Caption = "Gudang Tujuan"
        Me.gudang_tujuan.ColumnEdit = Me.RL_gdg_tujuan
        Me.gudang_tujuan.FieldName = "gudang_tujuan"
        Me.gudang_tujuan.Name = "gudang_tujuan"
        Me.gudang_tujuan.Visible = True
        Me.gudang_tujuan.VisibleIndex = 5
        Me.gudang_tujuan.Width = 92
        '
        'RL_gdg_tujuan
        '
        Me.RL_gdg_tujuan.AutoHeight = False
        Me.RL_gdg_tujuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_gdg_tujuan.Name = "RL_gdg_tujuan"
        Me.RL_gdg_tujuan.NullText = "Gudang Tujuan"
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "rp_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Visible = True
        Me.rp_trans.VisibleIndex = 6
        Me.rp_trans.Width = 57
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 7
        Me.harga.Width = 44
        '
        'panjang
        '
        Me.panjang.Caption = "Panjang"
        Me.panjang.DisplayFormat.FormatString = "n2"
        Me.panjang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.Visible = True
        Me.panjang.VisibleIndex = 8
        '
        'lebar
        '
        Me.lebar.Caption = "Lebar"
        Me.lebar.DisplayFormat.FormatString = "n2"
        Me.lebar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.Visible = True
        Me.lebar.VisibleIndex = 9
        '
        'tinggi
        '
        Me.tinggi.Caption = "Tinggi"
        Me.tinggi.DisplayFormat.FormatString = "n2"
        Me.tinggi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tinggi.FieldName = "tinggi"
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Visible = True
        Me.tinggi.VisibleIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtKeterangan)
        Me.Panel3.Controls.Add(Me.dteTanggal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.TxbPenerima)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txbNoTrans)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 183)
        Me.Panel3.TabIndex = 0
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(118, 90)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(366, 62)
        Me.txtKeterangan.TabIndex = 192
        '
        'dteTanggal
        '
        Me.dteTanggal.EditValue = Nothing
        Me.dteTanggal.EnterMoveNextControl = True
        Me.dteTanggal.Location = New System.Drawing.Point(118, 68)
        Me.dteTanggal.Name = "dteTanggal"
        Me.dteTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteTanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dteTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteTanggal.Properties.ShowPopupShadow = False
        Me.dteTanggal.Properties.ShowToday = False
        Me.dteTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dteTanggal.Size = New System.Drawing.Size(175, 20)
        Me.dteTanggal.TabIndex = 191
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Tanggal"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtcari)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 159)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1000, 24)
        Me.Panel6.TabIndex = 188
        '
        'txtcari
        '
        Me.txtcari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtcari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtcari.BackColor = System.Drawing.Color.White
        Me.txtcari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtcari.Location = New System.Drawing.Point(117, 0)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(883, 20)
        Me.txtcari.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cari Barang : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxbPenerima
        '
        Me.TxbPenerima.BackColor = System.Drawing.Color.White
        Me.TxbPenerima.Location = New System.Drawing.Point(507, 42)
        Me.TxbPenerima.Name = "TxbPenerima"
        Me.TxbPenerima.Size = New System.Drawing.Size(113, 20)
        Me.TxbPenerima.TabIndex = 181
        Me.TxbPenerima.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(417, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Penerima"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(28, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "No Transaksi"
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(118, 45)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(212, 20)
        Me.txbNoTrans.TabIndex = 172
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 510)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBM"
        Me.Text = "frmBM"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GcBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_gdg_asal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_gdg_tujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNmBrg As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TxbPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GcBM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_Barang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gudang_asal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gudang_tujuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_gdg_asal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_gdg_tujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dteTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tinggi As DevExpress.XtraGrid.Columns.GridColumn
End Class
