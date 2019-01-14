<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpname_RP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpname_RP))
        Me.DE_Tanggal = New DevExpress.XtraEditors.DateEdit
        Me.txb_keterangan = New System.Windows.Forms.TextBox
        Me.nilai_rata = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RepLookupPersd = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepLookupJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GvOpnStok = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_gudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_opname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.angka2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.qty_selisih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_manual = New DevExpress.XtraGrid.Columns.GridColumn
        Me.angka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GcOpnStok = New DevExpress.XtraGrid.GridControl
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        CType(Me.DE_Tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DE_Tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupPersd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvOpnStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.angka2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.angka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcOpnStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DE_Tanggal
        '
        Me.DE_Tanggal.EditValue = Nothing
        Me.DE_Tanggal.Location = New System.Drawing.Point(102, 34)
        Me.DE_Tanggal.Name = "DE_Tanggal"
        Me.DE_Tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DE_Tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DE_Tanggal.Size = New System.Drawing.Size(171, 20)
        Me.DE_Tanggal.TabIndex = 190
        '
        'txb_keterangan
        '
        Me.txb_keterangan.BackColor = System.Drawing.Color.White
        Me.txb_keterangan.Location = New System.Drawing.Point(492, 7)
        Me.txb_keterangan.Multiline = True
        Me.txb_keterangan.Name = "txb_keterangan"
        Me.txb_keterangan.Size = New System.Drawing.Size(288, 74)
        Me.txb_keterangan.TabIndex = 189
        '
        'nilai_rata
        '
        Me.nilai_rata.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_rata.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nilai_rata.Caption = "Nilai Rata"
        Me.nilai_rata.FieldName = "nilai_rata"
        Me.nilai_rata.Name = "nilai_rata"
        Me.nilai_rata.OptionsColumn.AllowEdit = False
        Me.nilai_rata.Visible = True
        Me.nilai_rata.VisibleIndex = 7
        Me.nilai_rata.Width = 83
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(102, 63)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 188
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "No Transaksi :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 92)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DE_Tanggal)
        Me.Panel7.Controls.Add(Me.txb_keterangan)
        Me.Panel7.Controls.Add(Me.lookupBulanAwal)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.txbNoTrans)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.cmdClear)
        Me.Panel7.Controls.Add(Me.cmdRefresh)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(792, 92)
        Me.Panel7.TabIndex = 0
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(102, 8)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(241, 20)
        Me.txbNoTrans.TabIndex = 186
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(402, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Keterangan :"
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(452, 43)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(35, 30)
        Me.cmdClear.TabIndex = 171
        Me.cmdClear.ToolTip = "Celar Filter"
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(408, 43)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 30)
        Me.cmdRefresh.TabIndex = 170
        Me.cmdRefresh.Text = "c"
        Me.cmdRefresh.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Periode :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Tanggal :"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 348)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 32)
        Me.Panel3.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 43)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 43)
        Me.Panel4.TabIndex = 143
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 41)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Form Stok Opname Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RepLookupPersd
        '
        Me.RepLookupPersd.AutoHeight = False
        Me.RepLookupPersd.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupPersd.Name = "RepLookupPersd"
        Me.RepLookupPersd.NullText = ""
        '
        'RepLookupJenis
        '
        Me.RepLookupJenis.AutoHeight = False
        Me.RepLookupJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupJenis.Name = "RepLookupJenis"
        Me.RepLookupJenis.NullText = ""
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RepLookupStok
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 191
        '
        'RepLookupStok
        '
        Me.RepLookupStok.AutoHeight = False
        Me.RepLookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupStok.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang")})
        Me.RepLookupStok.DisplayMember = "Nama_Barang"
        Me.RepLookupStok.Name = "RepLookupStok"
        Me.RepLookupStok.NullText = ""
        Me.RepLookupStok.ValueMember = "Kode_Barang"
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 9
        Me.keterangan.Width = 158
        '
        'nomer
        '
        Me.nomer.Caption = "No"
        Me.nomer.FieldName = "no_seq"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 25
        '
        'GvOpnStok
        '
        Me.GvOpnStok.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.kd_stok, Me.kd_satuan, Me.kd_gudang, Me.qty_data, Me.qty_opname, Me.qty_selisih, Me.nilai_rata, Me.nilai_manual, Me.keterangan})
        Me.GvOpnStok.GridControl = Me.GcOpnStok
        Me.GvOpnStok.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GvOpnStok.Name = "GvOpnStok"
        Me.GvOpnStok.NewItemRowText = "Tambah Items Opname"
        Me.GvOpnStok.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvOpnStok.OptionsView.RowAutoHeight = True
        Me.GvOpnStok.OptionsView.ShowFooter = True
        Me.GvOpnStok.OptionsView.ShowGroupPanel = False
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 53
        '
        'kd_gudang
        '
        Me.kd_gudang.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_gudang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_gudang.Caption = "Gudang"
        Me.kd_gudang.ColumnEdit = Me.RepLookupGudang
        Me.kd_gudang.FieldName = "kode_gudang"
        Me.kd_gudang.Name = "kd_gudang"
        Me.kd_gudang.Visible = True
        Me.kd_gudang.VisibleIndex = 3
        Me.kd_gudang.Width = 79
        '
        'RepLookupGudang
        '
        Me.RepLookupGudang.AutoHeight = False
        Me.RepLookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupGudang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Gudang", "Kode Gudang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Nama Gudang")})
        Me.RepLookupGudang.DisplayMember = "Nama_Gudang"
        Me.RepLookupGudang.Name = "RepLookupGudang"
        Me.RepLookupGudang.NullText = ""
        Me.RepLookupGudang.ValueMember = "Kode_Gudang"
        '
        'qty_data
        '
        Me.qty_data.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_data.Caption = "Qty Data"
        Me.qty_data.FieldName = "qty_data"
        Me.qty_data.Name = "qty_data"
        Me.qty_data.OptionsColumn.AllowEdit = False
        Me.qty_data.OptionsColumn.ReadOnly = True
        Me.qty_data.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_data.Visible = True
        Me.qty_data.VisibleIndex = 4
        Me.qty_data.Width = 56
        '
        'qty_opname
        '
        Me.qty_opname.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.qty_opname.AppearanceCell.Options.UseBackColor = True
        Me.qty_opname.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_opname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_opname.Caption = "Qty Manual"
        Me.qty_opname.ColumnEdit = Me.angka2
        Me.qty_opname.FieldName = "qty_opname"
        Me.qty_opname.Name = "qty_opname"
        Me.qty_opname.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_opname.Visible = True
        Me.qty_opname.VisibleIndex = 5
        Me.qty_opname.Width = 72
        '
        'angka2
        '
        Me.angka2.AutoHeight = False
        Me.angka2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.angka2.Mask.EditMask = "n3"
        Me.angka2.Mask.UseMaskAsDisplayFormat = True
        Me.angka2.Name = "angka2"
        '
        'qty_selisih
        '
        Me.qty_selisih.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_selisih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_selisih.Caption = "Selisih"
        Me.qty_selisih.FieldName = "qty_selisih"
        Me.qty_selisih.Name = "qty_selisih"
        Me.qty_selisih.OptionsColumn.AllowEdit = False
        Me.qty_selisih.OptionsColumn.ReadOnly = True
        Me.qty_selisih.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_selisih.Visible = True
        Me.qty_selisih.VisibleIndex = 6
        Me.qty_selisih.Width = 54
        '
        'nilai_manual
        '
        Me.nilai_manual.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nilai_manual.AppearanceCell.Options.UseBackColor = True
        Me.nilai_manual.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_manual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nilai_manual.Caption = "Nilai Manual"
        Me.nilai_manual.ColumnEdit = Me.angka
        Me.nilai_manual.FieldName = "nilai_manual"
        Me.nilai_manual.Name = "nilai_manual"
        Me.nilai_manual.Visible = True
        Me.nilai_manual.VisibleIndex = 8
        Me.nilai_manual.Width = 65
        '
        'angka
        '
        Me.angka.AutoHeight = False
        Me.angka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.angka.Mask.EditMask = "n2"
        Me.angka.Mask.UseMaskAsDisplayFormat = True
        Me.angka.Name = "angka"
        '
        'GcOpnStok
        '
        Me.GcOpnStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcOpnStok.Location = New System.Drawing.Point(0, 0)
        Me.GcOpnStok.MainView = Me.GvOpnStok
        Me.GcOpnStok.Name = "GcOpnStok"
        Me.GcOpnStok.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepLookupStok, Me.RepLookupGudang, Me.RepLookupJenis, Me.RepLookupPersd, Me.angka, Me.angka2})
        Me.GcOpnStok.Size = New System.Drawing.Size(792, 213)
        Me.GcOpnStok.TabIndex = 154
        Me.GcOpnStok.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvOpnStok})
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 380)
        Me.pnl.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GcOpnStok)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 135)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(792, 213)
        Me.Panel6.TabIndex = 3
        '
        'frmOpname_RP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 380)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmOpname_RP"
        Me.Text = "frmOpname_RP"
        CType(Me.DE_Tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DE_Tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupPersd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvOpnStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.angka2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.angka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcOpnStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DE_Tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txb_keterangan As System.Windows.Forms.TextBox
    Friend WithEvents nilai_rata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepLookupPersd As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepLookupJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvOpnStok As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_opname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents angka2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents qty_selisih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_manual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents angka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GcOpnStok As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
