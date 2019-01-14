<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transfBrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_transfBrg))
        Me.Gc_TransBrg = New DevExpress.XtraGrid.GridControl
        Me.Gv_TransfBrg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_barang1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpBrg1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKdsatuan2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.angka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.kd_barang2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpLookBrg2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hasilx = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tinggi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.dteTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.Gc_TransBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv_TransfBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpBrg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKdsatuan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.angka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpLookBrg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gc_TransBrg
        '
        Me.Gc_TransBrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_TransBrg.Location = New System.Drawing.Point(0, 0)
        Me.Gc_TransBrg.MainView = Me.Gv_TransfBrg
        Me.Gc_TransBrg.Name = "Gc_TransBrg"
        Me.Gc_TransBrg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpBrg1, Me.rpLookBrg2, Me.repKdsatuan2, Me.angka})
        Me.Gc_TransBrg.Size = New System.Drawing.Size(950, 309)
        Me.Gc_TransBrg.TabIndex = 6
        Me.Gc_TransBrg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv_TransfBrg})
        '
        'Gv_TransfBrg
        '
        Me.Gv_TransfBrg.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Gv_TransfBrg.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gv_TransfBrg.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.Gv_TransfBrg.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Gv_TransfBrg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_barang1, Me.kd_satuan1, Me.qty1, Me.kd_barang2, Me.kd_satuan2, Me.qty2, Me.hasilx, Me.nilai2, Me.nilai1, Me.panjang, Me.lebar, Me.tinggi})
        Me.Gv_TransfBrg.GridControl = Me.Gc_TransBrg
        Me.Gv_TransfBrg.Name = "Gv_TransfBrg"
        Me.Gv_TransfBrg.NewItemRowText = "Tambah data disini"
        Me.Gv_TransfBrg.OptionsCustomization.AllowColumnMoving = False
        Me.Gv_TransfBrg.OptionsCustomization.AllowFilter = False
        Me.Gv_TransfBrg.OptionsCustomization.AllowGroup = False
        Me.Gv_TransfBrg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.Gv_TransfBrg.OptionsView.RowAutoHeight = True
        Me.Gv_TransfBrg.OptionsView.ShowFooter = True
        Me.Gv_TransfBrg.OptionsView.ShowGroupPanel = False
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 41
        '
        'kd_barang1
        '
        Me.kd_barang1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kd_barang1.AppearanceCell.Options.UseBackColor = True
        Me.kd_barang1.Caption = "Barang 1"
        Me.kd_barang1.ColumnEdit = Me.rpBrg1
        Me.kd_barang1.FieldName = "kd_barang1"
        Me.kd_barang1.Name = "kd_barang1"
        Me.kd_barang1.Visible = True
        Me.kd_barang1.VisibleIndex = 1
        Me.kd_barang1.Width = 178
        '
        'rpBrg1
        '
        Me.rpBrg1.AutoHeight = False
        Me.rpBrg1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpBrg1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_barang", "Nama Barang")})
        Me.rpBrg1.Name = "rpBrg1"
        Me.rpBrg1.NullText = "[Pilih disini]"
        '
        'kd_satuan1
        '
        Me.kd_satuan1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kd_satuan1.AppearanceCell.Options.UseBackColor = True
        Me.kd_satuan1.Caption = "Satuan 1"
        Me.kd_satuan1.ColumnEdit = Me.repKdsatuan2
        Me.kd_satuan1.FieldName = "kd_satuan1"
        Me.kd_satuan1.Name = "kd_satuan1"
        Me.kd_satuan1.Visible = True
        Me.kd_satuan1.VisibleIndex = 2
        Me.kd_satuan1.Width = 64
        '
        'repKdsatuan2
        '
        Me.repKdsatuan2.AutoHeight = False
        Me.repKdsatuan2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKdsatuan2.Name = "repKdsatuan2"
        Me.repKdsatuan2.NullText = "[Pilih disini]"
        '
        'qty1
        '
        Me.qty1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.qty1.AppearanceCell.Options.UseBackColor = True
        Me.qty1.Caption = "Qty 1"
        Me.qty1.ColumnEdit = Me.angka
        Me.qty1.DisplayFormat.FormatString = "n3"
        Me.qty1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty1.FieldName = "qty1"
        Me.qty1.Name = "qty1"
        Me.qty1.Visible = True
        Me.qty1.VisibleIndex = 3
        Me.qty1.Width = 64
        '
        'angka
        '
        Me.angka.AutoHeight = False
        Me.angka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.angka.EditFormat.FormatString = "n3"
        Me.angka.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.angka.Mask.EditMask = "n3"
        Me.angka.Mask.UseMaskAsDisplayFormat = True
        Me.angka.Name = "angka"
        '
        'kd_barang2
        '
        Me.kd_barang2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kd_barang2.AppearanceCell.Options.UseBackColor = True
        Me.kd_barang2.Caption = "Barang 2"
        Me.kd_barang2.ColumnEdit = Me.rpLookBrg2
        Me.kd_barang2.FieldName = "kd_barang2"
        Me.kd_barang2.Name = "kd_barang2"
        Me.kd_barang2.Visible = True
        Me.kd_barang2.VisibleIndex = 4
        Me.kd_barang2.Width = 241
        '
        'rpLookBrg2
        '
        Me.rpLookBrg2.AutoHeight = False
        Me.rpLookBrg2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpLookBrg2.Name = "rpLookBrg2"
        Me.rpLookBrg2.NullText = "[Pilih disini]"
        '
        'kd_satuan2
        '
        Me.kd_satuan2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kd_satuan2.AppearanceCell.Options.UseBackColor = True
        Me.kd_satuan2.Caption = "Satuan 2"
        Me.kd_satuan2.ColumnEdit = Me.repKdsatuan2
        Me.kd_satuan2.FieldName = "kd_satuan2"
        Me.kd_satuan2.Name = "kd_satuan2"
        Me.kd_satuan2.Visible = True
        Me.kd_satuan2.VisibleIndex = 5
        Me.kd_satuan2.Width = 92
        '
        'qty2
        '
        Me.qty2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.qty2.AppearanceCell.Options.UseBackColor = True
        Me.qty2.Caption = "Qty 2"
        Me.qty2.ColumnEdit = Me.angka
        Me.qty2.FieldName = "qty2"
        Me.qty2.Name = "qty2"
        Me.qty2.Visible = True
        Me.qty2.VisibleIndex = 6
        Me.qty2.Width = 91
        '
        'hasilx
        '
        Me.hasilx.Caption = "hasilx"
        Me.hasilx.FieldName = "hasilx"
        Me.hasilx.Name = "hasilx"
        '
        'nilai2
        '
        Me.nilai2.Caption = "nilai2"
        Me.nilai2.FieldName = "nilai2"
        Me.nilai2.Name = "nilai2"
        '
        'nilai1
        '
        Me.nilai1.Caption = "nilai1"
        Me.nilai1.FieldName = "nilai1"
        Me.nilai1.Name = "nilai1"
        '
        'panjang
        '
        Me.panjang.Caption = "panjang"
        Me.panjang.FieldName = "panjang"
        Me.panjang.Name = "panjang"
        Me.panjang.Visible = True
        Me.panjang.VisibleIndex = 7
        '
        'lebar
        '
        Me.lebar.Caption = "lebar"
        Me.lebar.FieldName = "lebar"
        Me.lebar.Name = "lebar"
        Me.lebar.Visible = True
        Me.lebar.VisibleIndex = 8
        '
        'tinggi
        '
        Me.tinggi.Caption = "tinggi"
        Me.tinggi.FieldName = "tinggi"
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Visible = True
        Me.tinggi.VisibleIndex = 9
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Gc_TransBrg)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 159)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(950, 309)
        Me.Panel5.TabIndex = 2
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
        Me.Panel1.Size = New System.Drawing.Size(950, 34)
        Me.Panel1.TabIndex = 145
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
        Me.Label1.Size = New System.Drawing.Size(426, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          TRANSFER BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.pnl.Size = New System.Drawing.Size(950, 500)
        Me.pnl.TabIndex = 147
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 468)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(950, 32)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lookupBulanAwal)
        Me.Panel3.Controls.Add(Me.txtKet)
        Me.Panel3.Controls.Add(Me.dteTanggal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txbNoTrans)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 159)
        Me.Panel3.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(46, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Bulan Tahun :"
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(148, 44)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lookupBulanAwal.Properties.Appearance.Options.UseBackColor = True
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(181, 20)
        Me.lookupBulanAwal.TabIndex = 197
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(519, 40)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(250, 84)
        Me.txtKet.TabIndex = 181
        '
        'dteTanggal
        '
        Me.dteTanggal.EditValue = Nothing
        Me.dteTanggal.Location = New System.Drawing.Point(148, 70)
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
        Me.dteTanggal.Size = New System.Drawing.Size(150, 20)
        Me.dteTanggal.TabIndex = 180
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(393, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Keterangan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Tanggal :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(390, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 15)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "No Transaksi (auto) :"
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(519, 133)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(212, 20)
        Me.txbNoTrans.TabIndex = 172
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frm_transfBrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frm_transfBrg"
        Me.Text = "frm_transfer_Barang"
        CType(Me.Gc_TransBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv_TransfBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpBrg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKdsatuan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.angka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpLookBrg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gc_TransBrg As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv_TransfBrg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_barang1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_barang2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpBrg1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rpLookBrg2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents hasilx As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tinggi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKdsatuan2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dteTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents nilai2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents angka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
End Class
