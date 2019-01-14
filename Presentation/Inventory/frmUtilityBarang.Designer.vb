<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilityBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilityBarang))
        Me.cmdAdvance = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlMaster = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.spek_brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVsatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_jns_persd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVpersediaan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVjenisBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lokasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVgudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_max_av = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lead_time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_persediaan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVrekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rek_penjualan1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_pusat_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVpusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rek_retur1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CEeditMode = New DevExpress.XtraEditors.CheckEdit
        Me.CCKBOXcolom = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cbStats = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.lookupkartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbjns_trans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.lookupjns = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupval = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lodTanggal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.lookupbank = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbTipeTrans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl.SuspendLayout()
        Me.pnlMaster.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVgudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.CEeditMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCKBOXcolom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdvance
        '
        Me.cmdAdvance.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAdvance.Location = New System.Drawing.Point(760, 3)
        Me.cmdAdvance.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAdvance.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdvance.Name = "cmdAdvance"
        Me.cmdAdvance.Size = New System.Drawing.Size(80, 30)
        Me.cmdAdvance.TabIndex = 30
        Me.cmdAdvance.Text = "&Advance"
        Me.cmdAdvance.Visible = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlMaster)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1029, 487)
        Me.pnl.TabIndex = 4
        '
        'pnlMaster
        '
        Me.pnlMaster.Controls.Add(Me.GC)
        Me.pnlMaster.Controls.Add(Me.Panel3)
        Me.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMaster.Location = New System.Drawing.Point(0, 45)
        Me.pnlMaster.Name = "pnlMaster"
        Me.pnlMaster.Size = New System.Drawing.Size(1029, 406)
        Me.pnlMaster.TabIndex = 35
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 27)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVrekening, Me.LOVpusat, Me.LOVpersediaan, Me.LOVjenisBarang, Me.LOVgudang, Me.LOVsatuan, Me.LOVukuran})
        Me.GC.Size = New System.Drawing.Size(1029, 379)
        Me.GC.TabIndex = 34
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Kode_Barang, Me.spek_brg, Me.Kd_Satuan, Me.kd_jns_persd, Me.kd_jenis, Me.kd_ukuran, Me.lokasi, Me.stok_min, Me.stok_max_av, Me.lead_time, Me.rek_persediaan, Me.rek_penjualan1, Me.rek_biaya, Me.rek_pusat_biaya, Me.rek_retur1})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "TABEL UTILITY BARANG"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Nama Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 0
        '
        'Kode_Barang
        '
        Me.Kode_Barang.Caption = "Kode Barang"
        Me.Kode_Barang.FieldName = "Kode_Barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.Visible = True
        Me.Kode_Barang.VisibleIndex = 1
        '
        'spek_brg
        '
        Me.spek_brg.Caption = "Spesifikasi"
        Me.spek_brg.FieldName = "spek_brg"
        Me.spek_brg.Name = "spek_brg"
        Me.spek_brg.Visible = True
        Me.spek_brg.VisibleIndex = 2
        '
        'Kd_Satuan
        '
        Me.Kd_Satuan.Caption = "Satuan"
        Me.Kd_Satuan.ColumnEdit = Me.LOVsatuan
        Me.Kd_Satuan.FieldName = "Kd_Satuan"
        Me.Kd_Satuan.Name = "Kd_Satuan"
        Me.Kd_Satuan.Visible = True
        Me.Kd_Satuan.VisibleIndex = 3
        Me.Kd_Satuan.Width = 63
        '
        'LOVsatuan
        '
        Me.LOVsatuan.AutoHeight = False
        Me.LOVsatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVsatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Satuan", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Satuan", "Nama")})
        Me.LOVsatuan.Name = "LOVsatuan"
        '
        'kd_jns_persd
        '
        Me.kd_jns_persd.Caption = "Kode Jenis Pers."
        Me.kd_jns_persd.ColumnEdit = Me.LOVpersediaan
        Me.kd_jns_persd.FieldName = "kd_jns_persd"
        Me.kd_jns_persd.Name = "kd_jns_persd"
        Me.kd_jns_persd.Visible = True
        Me.kd_jns_persd.VisibleIndex = 4
        Me.kd_jns_persd.Width = 63
        '
        'LOVpersediaan
        '
        Me.LOVpersediaan.AutoHeight = False
        Me.LOVpersediaan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpersediaan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Persd", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Nama")})
        Me.LOVpersediaan.Name = "LOVpersediaan"
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Kode Jenis"
        Me.kd_jenis.ColumnEdit = Me.LOVjenisBarang
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 5
        Me.kd_jenis.Width = 63
        '
        'LOVjenisBarang
        '
        Me.LOVjenisBarang.AutoHeight = False
        Me.LOVjenisBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVjenisBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Brg", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama")})
        Me.LOVjenisBarang.Name = "LOVjenisBarang"
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Kode Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.LOVukuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 15
        '
        'LOVukuran
        '
        Me.LOVukuran.AutoHeight = False
        Me.LOVukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Nama")})
        Me.LOVukuran.Name = "LOVukuran"
        '
        'lokasi
        '
        Me.lokasi.Caption = "Lokasi"
        Me.lokasi.ColumnEdit = Me.LOVgudang
        Me.lokasi.FieldName = "lokasi"
        Me.lokasi.Name = "lokasi"
        Me.lokasi.Visible = True
        Me.lokasi.VisibleIndex = 6
        Me.lokasi.Width = 63
        '
        'LOVgudang
        '
        Me.LOVgudang.AutoHeight = False
        Me.LOVgudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVgudang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Gudang", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Nama")})
        Me.LOVgudang.Name = "LOVgudang"
        '
        'stok_min
        '
        Me.stok_min.Caption = "Stok Minimal"
        Me.stok_min.FieldName = "stok_min"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 7
        '
        'stok_max_av
        '
        Me.stok_max_av.Caption = "Stok Max Average"
        Me.stok_max_av.FieldName = "stok_max_av"
        Me.stok_max_av.Name = "stok_max_av"
        Me.stok_max_av.Visible = True
        Me.stok_max_av.VisibleIndex = 8
        '
        'lead_time
        '
        Me.lead_time.Caption = "Lead Time"
        Me.lead_time.FieldName = "lead_time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.Visible = True
        Me.lead_time.VisibleIndex = 9
        '
        'rek_persediaan
        '
        Me.rek_persediaan.Caption = "Rekening Persediaan"
        Me.rek_persediaan.ColumnEdit = Me.LOVrekening
        Me.rek_persediaan.FieldName = "rek_persediaan"
        Me.rek_persediaan.Name = "rek_persediaan"
        Me.rek_persediaan.Visible = True
        Me.rek_persediaan.VisibleIndex = 10
        Me.rek_persediaan.Width = 135
        '
        'LOVrekening
        '
        Me.LOVrekening.AutoHeight = False
        Me.LOVrekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVrekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.LOVrekening.Name = "LOVrekening"
        '
        'rek_penjualan1
        '
        Me.rek_penjualan1.Caption = "Rekening Penjualan"
        Me.rek_penjualan1.ColumnEdit = Me.LOVrekening
        Me.rek_penjualan1.FieldName = "rek_penjualan1"
        Me.rek_penjualan1.Name = "rek_penjualan1"
        Me.rek_penjualan1.Visible = True
        Me.rek_penjualan1.VisibleIndex = 11
        Me.rek_penjualan1.Width = 119
        '
        'rek_biaya
        '
        Me.rek_biaya.Caption = "Rek. Biaya"
        Me.rek_biaya.ColumnEdit = Me.LOVrekening
        Me.rek_biaya.FieldName = "rek_biaya"
        Me.rek_biaya.Name = "rek_biaya"
        Me.rek_biaya.Visible = True
        Me.rek_biaya.VisibleIndex = 12
        Me.rek_biaya.Width = 30
        '
        'rek_pusat_biaya
        '
        Me.rek_pusat_biaya.Caption = "Rek. Pusat Biaya"
        Me.rek_pusat_biaya.ColumnEdit = Me.LOVpusat
        Me.rek_pusat_biaya.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Name = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Visible = True
        Me.rek_pusat_biaya.VisibleIndex = 13
        Me.rek_pusat_biaya.Width = 30
        '
        'LOVpusat
        '
        Me.LOVpusat.AutoHeight = False
        Me.LOVpusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVpusat.Name = "LOVpusat"
        '
        'rek_retur1
        '
        Me.rek_retur1.Caption = "Rek. Return"
        Me.rek_retur1.ColumnEdit = Me.LOVrekening
        Me.rek_retur1.FieldName = "rek_retur1"
        Me.rek_retur1.Name = "rek_retur1"
        Me.rek_retur1.Visible = True
        Me.rek_retur1.VisibleIndex = 14
        Me.rek_retur1.Width = 30
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CEeditMode)
        Me.Panel3.Controls.Add(Me.CCKBOXcolom)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1029, 27)
        Me.Panel3.TabIndex = 35
        '
        'CEeditMode
        '
        Me.CEeditMode.Location = New System.Drawing.Point(887, 4)
        Me.CEeditMode.Name = "CEeditMode"
        Me.CEeditMode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEeditMode.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.CEeditMode.Properties.Appearance.Options.UseFont = True
        Me.CEeditMode.Properties.Appearance.Options.UseForeColor = True
        Me.CEeditMode.Properties.Caption = "Edit Mode"
        Me.CEeditMode.Size = New System.Drawing.Size(139, 19)
        Me.CEeditMode.TabIndex = 3
        Me.CEeditMode.Visible = False
        '
        'CCKBOXcolom
        '
        Me.CCKBOXcolom.EditValue = ""
        Me.CCKBOXcolom.Location = New System.Drawing.Point(78, 3)
        Me.CCKBOXcolom.Name = "CCKBOXcolom"
        Me.CCKBOXcolom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CCKBOXcolom.Size = New System.Drawing.Size(178, 20)
        Me.CCKBOXcolom.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Pilih Kolom"
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
        Me.Panel1.Size = New System.Drawing.Size(1029, 45)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UTILITY BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.cmdAdvance)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 451)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 36)
        Me.Panel2.TabIndex = 31
        '
        'cmdClear
        '
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(846, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 30)
        Me.cmdClear.TabIndex = 29
        Me.cmdClear.Text = "&Bersih"
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(932, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(80, 30)
        Me.cmdRefresh.TabIndex = 28
        Me.cmdRefresh.Text = "&Reload"
        Me.cmdRefresh.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(674, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(588, 3)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 30)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        Me.cmdSimpan.Visible = False
        '
        'cbStats
        '
        Me.cbStats.AutoHeight = False
        Me.cbStats.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStats.Items.AddRange(New Object() {"KELUAR"})
        Me.cbStats.Name = "cbStats"
        '
        'lookupkartu
        '
        Me.lookupkartu.AutoHeight = False
        Me.lookupkartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupkartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", "Kode."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama")})
        Me.lookupkartu.Name = "lookupkartu"
        '
        'cbjns_trans
        '
        Me.cbjns_trans.AutoHeight = False
        Me.cbjns_trans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbjns_trans.Items.AddRange(New Object() {"BELI"})
        Me.cbjns_trans.Name = "cbjns_trans"
        Me.cbjns_trans.NullValuePrompt = "klik Disini"
        '
        'lookupjns
        '
        Me.lookupjns.AutoHeight = False
        Me.lookupjns.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupjns.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_trans", "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("accronim_desc", "Accronim")})
        Me.lookupjns.Name = "lookupjns"
        '
        'lookupval
        '
        Me.lookupval.AutoHeight = False
        Me.lookupval.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupval.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookupval.Name = "lookupval"
        '
        'lodTanggal
        '
        Me.lodTanggal.AutoHeight = False
        Me.lodTanggal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lodTanggal.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.EditFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.Mask.EditMask = "dd MMMM yyyy"
        Me.lodTanggal.Name = "lodTanggal"
        Me.lodTanggal.ReadOnly = True
        Me.lodTanggal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'lookupbank
        '
        Me.lookupbank.AutoHeight = False
        Me.lookupbank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbank.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bank", "Nama bank")})
        Me.lookupbank.Name = "lookupbank"
        '
        'cbTipeTrans
        '
        Me.cbTipeTrans.AutoHeight = False
        Me.cbTipeTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipeTrans.Items.AddRange(New Object() {"JKK-KUT-02"})
        Me.cbTipeTrans.Name = "cbTipeTrans"
        '
        'frmUtilityBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 487)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmUtilityBarang"
        Me.Text = "frmUtilityBarang"
        Me.pnl.ResumeLayout(False)
        Me.pnlMaster.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVsatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVjenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVgudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CEeditMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCKBOXcolom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdvance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cbStats As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lookupkartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbjns_trans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents lookupjns As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupval As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lodTanggal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lookupbank As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbTipeTrans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spek_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jns_persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_max_av As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_persediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_penjualan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_pusat_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_retur1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVrekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVpusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVpersediaan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVjenisBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVgudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CEeditMode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Kd_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LOVsatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlMaster As System.Windows.Forms.Panel
    Friend WithEvents CCKBOXcolom As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LOVukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
