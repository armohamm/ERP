<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonStokaseli
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonStokaseli))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GcMonSGdg = New DevExpress.XtraGrid.GridControl()
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.kd_jns_persd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookuppersediaan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.akhir_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Kd_Satuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_merk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_sub_tipe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_kain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.akhir_booked = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stok_max_av = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.qty_available = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.kode_gudang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LookupBlthn = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMonSGdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookuppersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.LookupBlthn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GcMonSGdg
        Me.GridView4.Name = "GridView4"
        '
        'GcMonSGdg
        '
        Me.GcMonSGdg.Dock = System.Windows.Forms.DockStyle.Top
        GridLevelNode1.LevelTemplate = Me.GridView4
        GridLevelNode1.RelationName = "Level1"
        Me.GcMonSGdg.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcMonSGdg.Location = New System.Drawing.Point(0, 79)
        Me.GcMonSGdg.MainView = Me.GV
        Me.GcMonSGdg.Name = "GcMonSGdg"
        Me.GcMonSGdg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.LookupGudang, Me.lookuppersediaan})
        Me.GcMonSGdg.Size = New System.Drawing.Size(955, 163)
        Me.GcMonSGdg.TabIndex = 6
        Me.GcMonSGdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GridView2, Me.GridView4})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_jns_persd, Me.akhir_qty, Me.kd_jenis, Me.Nama_Barang, Me.Kd_Satuan, Me.kd_merk, Me.kd_tipe, Me.kd_sub_tipe, Me.kd_kain, Me.kd_ukuran, Me.stok_min, Me.lead_time, Me.akhir_booked, Me.stok_max_av, Me.qty_available})
        Me.GV.GridControl = Me.GcMonSGdg
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "MONITORING STOK"
        '
        'kd_jns_persd
        '
        Me.kd_jns_persd.Caption = "Jns. Persediaan"
        Me.kd_jns_persd.ColumnEdit = Me.lookuppersediaan
        Me.kd_jns_persd.FieldName = "kd_jns_persd"
        Me.kd_jns_persd.Name = "kd_jns_persd"
        Me.kd_jns_persd.Visible = True
        Me.kd_jns_persd.VisibleIndex = 0
        Me.kd_jns_persd.Width = 78
        '
        'lookuppersediaan
        '
        Me.lookuppersediaan.AutoHeight = False
        Me.lookuppersediaan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookuppersediaan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Persd", "Kode")})
        Me.lookuppersediaan.DisplayMember = "Nama_Persediaan"
        Me.lookuppersediaan.Name = "lookuppersediaan"
        Me.lookuppersediaan.ValueMember = "Kd_Jns_Persd"
        '
        'akhir_qty
        '
        Me.akhir_qty.Caption = "Jumlah"
        Me.akhir_qty.FieldName = "akhir_qty"
        Me.akhir_qty.Name = "akhir_qty"
        Me.akhir_qty.Width = 137
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Jns Barang"
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 1
        Me.kd_jenis.Width = 72
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Nama"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 2
        Me.Nama_Barang.Width = 99
        '
        'Kd_Satuan
        '
        Me.Kd_Satuan.Caption = "Satuan"
        Me.Kd_Satuan.FieldName = "Kd_Satuan"
        Me.Kd_Satuan.Name = "Kd_Satuan"
        Me.Kd_Satuan.Visible = True
        Me.Kd_Satuan.VisibleIndex = 13
        '
        'kd_merk
        '
        Me.kd_merk.Caption = "Merk"
        Me.kd_merk.FieldNameSortGroup = "kd_merk"
        Me.kd_merk.Name = "kd_merk"
        Me.kd_merk.Visible = True
        Me.kd_merk.VisibleIndex = 3
        Me.kd_merk.Width = 34
        '
        'kd_tipe
        '
        Me.kd_tipe.Caption = "Tipe"
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 4
        Me.kd_tipe.Width = 30
        '
        'kd_sub_tipe
        '
        Me.kd_sub_tipe.Caption = "Sub tipe"
        Me.kd_sub_tipe.FieldName = "kd_sub_tipe"
        Me.kd_sub_tipe.Name = "kd_sub_tipe"
        Me.kd_sub_tipe.Visible = True
        Me.kd_sub_tipe.VisibleIndex = 5
        Me.kd_sub_tipe.Width = 30
        '
        'kd_kain
        '
        Me.kd_kain.Caption = "Kain"
        Me.kd_kain.FieldName = "kd_kain"
        Me.kd_kain.Name = "kd_kain"
        Me.kd_kain.Visible = True
        Me.kd_kain.VisibleIndex = 6
        Me.kd_kain.Width = 30
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 7
        Me.kd_ukuran.Width = 30
        '
        'stok_min
        '
        Me.stok_min.Caption = "Min Stok"
        Me.stok_min.FieldName = "stok_min"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 8
        Me.stok_min.Width = 30
        '
        'lead_time
        '
        Me.lead_time.Caption = "Lead TIme/hari"
        Me.lead_time.FieldName = "lead_time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.Visible = True
        Me.lead_time.VisibleIndex = 9
        Me.lead_time.Width = 30
        '
        'akhir_booked
        '
        Me.akhir_booked.Caption = "Booked"
        Me.akhir_booked.FieldName = "akhir_booked"
        Me.akhir_booked.Name = "akhir_booked"
        Me.akhir_booked.Visible = True
        Me.akhir_booked.VisibleIndex = 10
        Me.akhir_booked.Width = 30
        '
        'stok_max_av
        '
        Me.stok_max_av.Caption = "Stok"
        Me.stok_max_av.FieldName = "stok_max_av"
        Me.stok_max_av.Name = "stok_max_av"
        Me.stok_max_av.Visible = True
        Me.stok_max_av.VisibleIndex = 11
        Me.stok_max_av.Width = 30
        '
        'qty_available
        '
        Me.qty_available.Caption = "Available"
        Me.qty_available.FieldName = "qty_available"
        Me.qty_available.Name = "qty_available"
        Me.qty_available.Visible = True
        Me.qty_available.VisibleIndex = 12
        Me.qty_available.Width = 123
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Name = "LookupBarang"
        '
        'LookupGudang
        '
        Me.LookupGudang.AutoHeight = False
        Me.LookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Name = "LookupGudang"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GcMonSGdg
        Me.GridView2.Name = "GridView2"
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcMonSGdg
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Monitoring STOK SALDO GUDANG", ""}, New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Monitoring STOK SALDO GUDANG", "", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(0, 242)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(955, 163)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView5, Me.GridView3})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_stok, Me.kode_gudang})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowViewCaption = True
        Me.GridView1.ViewCaption = "STOK BERDASARKAN GUDANG"
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Stok"
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 839
        '
        'kode_gudang
        '
        Me.kode_gudang.Caption = "Nama Gudang"
        Me.kode_gudang.FieldName = "kode_gudang"
        Me.kode_gudang.Name = "kode_gudang"
        Me.kode_gudang.Visible = True
        Me.kode_gudang.VisibleIndex = 0
        Me.kode_gudang.Width = 95
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
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl1
        Me.GridView5.Name = "GridView5"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(955, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(393, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM MONITORING STOK SALDO GUDANG"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnprin)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(955, 42)
        Me.Panel3.TabIndex = 5
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.Location = New System.Drawing.Point(328, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(59, 42)
        Me.btnprin.TabIndex = 36
        Me.btnprin.Text = "Cetak"
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(279, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 34
        Me.cmdClear.ToolTip = "Clear Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(230, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LookupBlthn)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(118, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(112, 42)
        Me.Panel6.TabIndex = 32
        '
        'LookupBlthn
        '
        Me.LookupBlthn.Location = New System.Drawing.Point(6, 12)
        Me.LookupBlthn.Name = "LookupBlthn"
        Me.LookupBlthn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBlthn.Properties.DisplayMember = "bultah"
        Me.LookupBlthn.Properties.NullText = "[bulantahun]"
        Me.LookupBlthn.Properties.ValueMember = "bultah"
        Me.LookupBlthn.Size = New System.Drawing.Size(100, 20)
        Me.LookupBlthn.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 42)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "History Periode :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GridControl1)
        Me.pnl.Controls.Add(Me.GcMonSGdg)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(955, 430)
        Me.pnl.TabIndex = 4
        '
        'FrmMonStokaseli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 430)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmMonStokaseli"
        Me.Text = "FrmMonStokaseli"
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMonSGdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookuppersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.LookupBlthn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcMonSGdg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_jns_persd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sub_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents akhir_booked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_max_av As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_available As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kode_gudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LookupBlthn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lookuppersediaan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
