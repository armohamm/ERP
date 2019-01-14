<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdTranSpkServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdTranSpkServ))
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lkkegtn = New DevExpress.XtraEditors.LookUpEdit
        Me.lkkegiatan = New DevExpress.XtraEditors.LookUpEdit
        Me.lkspk = New DevExpress.XtraEditors.LookUpEdit
        Me.lkrph = New DevExpress.XtraEditors.LookUpEdit
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.norph = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.kapasits = New System.Windows.Forms.TextBox
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.txtjdwl = New System.Windows.Forms.TextBox
        Me.txttanggal = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.kapasitas = New System.Windows.Forms.Label
        Me.kgiatanspk = New System.Windows.Forms.Label
        Me.nospk = New System.Windows.Forms.Label
        Me.jdwlkerja = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tipe_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lktipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkkain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jumlah_produksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.clmStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5.SuspendLayout()
        CType(Me.lkkegtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkkegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkspk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkrph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lktipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lkkegtn)
        Me.Panel5.Controls.Add(Me.lkkegiatan)
        Me.Panel5.Controls.Add(Me.lkspk)
        Me.Panel5.Controls.Add(Me.lkrph)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(156, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(216, 90)
        Me.Panel5.TabIndex = 1
        '
        'lkkegtn
        '
        Me.lkkegtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkkegtn.Location = New System.Drawing.Point(0, 60)
        Me.lkkegtn.Name = "lkkegtn"
        Me.lkkegtn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkegtn.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "Nama")})
        Me.lkkegtn.Properties.NullText = "[Pilih Kegiatan SPK]"
        Me.lkkegtn.Properties.ShowHeader = False
        Me.lkkegtn.Size = New System.Drawing.Size(216, 20)
        Me.lkkegtn.TabIndex = 24
        '
        'lkkegiatan
        '
        Me.lkkegiatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkkegiatan.Location = New System.Drawing.Point(0, 40)
        Me.lkkegiatan.Name = "lkkegiatan"
        Me.lkkegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "Nama")})
        Me.lkkegiatan.Properties.NullText = "[Pilih Kegiatan]"
        Me.lkkegiatan.Properties.ShowHeader = False
        Me.lkkegiatan.Size = New System.Drawing.Size(216, 20)
        Me.lkkegiatan.TabIndex = 23
        '
        'lkspk
        '
        Me.lkspk.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkspk.Location = New System.Drawing.Point(0, 20)
        Me.lkspk.Name = "lkspk"
        Me.lkspk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkspk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_spk", "Nama")})
        Me.lkspk.Properties.NullText = "[Pilih No SPK]"
        Me.lkspk.Properties.ShowHeader = False
        Me.lkspk.Size = New System.Drawing.Size(216, 20)
        Me.lkspk.TabIndex = 21
        '
        'lkrph
        '
        Me.lkrph.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkrph.Location = New System.Drawing.Point(0, 0)
        Me.lkrph.Name = "lkrph"
        Me.lkrph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkrph.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_rph", "Name5")})
        Me.lkrph.Properties.NullText = "[Pilih No RPH]"
        Me.lkrph.Properties.ShowHeader = False
        Me.lkrph.Size = New System.Drawing.Size(216, 20)
        Me.lkrph.TabIndex = 18
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 29)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "TRANSAKSI SPK SERVICE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.norph)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(156, 90)
        Me.Panel6.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "* Kegiatan SPK : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "* Area Kegiatan : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'norph
        '
        Me.norph.Dock = System.Windows.Forms.DockStyle.Top
        Me.norph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.norph.ForeColor = System.Drawing.Color.White
        Me.norph.Location = New System.Drawing.Point(0, 20)
        Me.norph.Name = "norph"
        Me.norph.Size = New System.Drawing.Size(156, 20)
        Me.norph.TabIndex = 4
        Me.norph.Text = "* No SPK : "
        Me.norph.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "* No RPH : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 90)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.kapasits)
        Me.Panel4.Controls.Add(Me.txtjumlah)
        Me.Panel4.Controls.Add(Me.txtjdwl)
        Me.Panel4.Controls.Add(Me.txttanggal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(513, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 90)
        Me.Panel4.TabIndex = 3
        '
        'kapasits
        '
        Me.kapasits.Dock = System.Windows.Forms.DockStyle.Top
        Me.kapasits.Location = New System.Drawing.Point(0, 60)
        Me.kapasits.Name = "kapasits"
        Me.kapasits.Size = New System.Drawing.Size(235, 20)
        Me.kapasits.TabIndex = 25
        Me.kapasits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjumlah
        '
        Me.txtjumlah.BackColor = System.Drawing.Color.Gainsboro
        Me.txtjumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtjumlah.Location = New System.Drawing.Point(0, 40)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.ReadOnly = True
        Me.txtjumlah.Size = New System.Drawing.Size(235, 20)
        Me.txtjumlah.TabIndex = 24
        Me.txtjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjdwl
        '
        Me.txtjdwl.BackColor = System.Drawing.Color.Gainsboro
        Me.txtjdwl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjdwl.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtjdwl.Location = New System.Drawing.Point(0, 20)
        Me.txtjdwl.Name = "txtjdwl"
        Me.txtjdwl.ReadOnly = True
        Me.txtjdwl.Size = New System.Drawing.Size(235, 20)
        Me.txtjdwl.TabIndex = 23
        '
        'txttanggal
        '
        Me.txttanggal.BackColor = System.Drawing.Color.Gainsboro
        Me.txttanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txttanggal.Location = New System.Drawing.Point(0, 0)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(235, 20)
        Me.txttanggal.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.kapasitas)
        Me.Panel3.Controls.Add(Me.kgiatanspk)
        Me.Panel3.Controls.Add(Me.nospk)
        Me.Panel3.Controls.Add(Me.jdwlkerja)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(372, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 90)
        Me.Panel3.TabIndex = 2
        '
        'kapasitas
        '
        Me.kapasitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.kapasitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kapasitas.ForeColor = System.Drawing.Color.White
        Me.kapasitas.Location = New System.Drawing.Point(0, 60)
        Me.kapasitas.Name = "kapasitas"
        Me.kapasitas.Size = New System.Drawing.Size(141, 20)
        Me.kapasitas.TabIndex = 5
        Me.kapasitas.Text = "Kapasitas : "
        Me.kapasitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'kgiatanspk
        '
        Me.kgiatanspk.Dock = System.Windows.Forms.DockStyle.Top
        Me.kgiatanspk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgiatanspk.ForeColor = System.Drawing.Color.White
        Me.kgiatanspk.Location = New System.Drawing.Point(0, 40)
        Me.kgiatanspk.Name = "kgiatanspk"
        Me.kgiatanspk.Size = New System.Drawing.Size(141, 20)
        Me.kgiatanspk.TabIndex = 4
        Me.kgiatanspk.Text = "Jumlah : "
        Me.kgiatanspk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nospk
        '
        Me.nospk.Dock = System.Windows.Forms.DockStyle.Top
        Me.nospk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nospk.ForeColor = System.Drawing.Color.White
        Me.nospk.Location = New System.Drawing.Point(0, 20)
        Me.nospk.Name = "nospk"
        Me.nospk.Size = New System.Drawing.Size(141, 20)
        Me.nospk.TabIndex = 3
        Me.nospk.Text = "Jadwal Kerja : "
        Me.nospk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'jdwlkerja
        '
        Me.jdwlkerja.Dock = System.Windows.Forms.DockStyle.Top
        Me.jdwlkerja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jdwlkerja.ForeColor = System.Drawing.Color.White
        Me.jdwlkerja.Location = New System.Drawing.Point(0, 0)
        Me.jdwlkerja.Name = "jdwlkerja"
        Me.jdwlkerja.Size = New System.Drawing.Size(141, 20)
        Me.jdwlkerja.TabIndex = 2
        Me.jdwlkerja.Text = "Tanggal : "
        Me.jdwlkerja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(798, 31)
        Me.pnlTitle.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTools.Controls.Add(Me.gControl)
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTools.Location = New System.Drawing.Point(0, 31)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(798, 352)
        Me.pnlTools.TabIndex = 5
        '
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gControl.Location = New System.Drawing.Point(0, 90)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkbarang, Me.lktipe, Me.lkkain, Me.lkukuran})
        Me.gControl.Size = New System.Drawing.Size(796, 260)
        Me.gControl.TabIndex = 7
        Me.gControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gView})
        '
        'gView
        '
        Me.gView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gView.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Empty.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gView.Appearance.FixedLine.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gView.Appearance.GroupButton.Options.UseForeColor = True
        Me.gView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gView.Appearance.GroupRow.Options.UseFont = True
        Me.gView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.HorzLine.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.OddRow.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.Options.UseForeColor = True
        Me.gView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.Preview.Options.UseBackColor = True
        Me.gView.Appearance.Preview.Options.UseForeColor = True
        Me.gView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.Row.Options.UseBackColor = True
        Me.gView.Appearance.Row.Options.UseForeColor = True
        Me.gView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.VertLine.Options.UseBackColor = True
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_barang, Me.tipe_stok, Me.kd_kain, Me.kd_ukuran, Me.jumlah_produksi, Me.jumlah_kerja, Me.indeks})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.OptionsView.EnableAppearanceEvenRow = True
        Me.gView.OptionsView.EnableAppearanceOddRow = True
        Me.gView.OptionsView.ShowFooter = True
        Me.gView.OptionsView.ShowGroupPanel = False
        Me.gView.PaintStyleName = "Skin"
        '
        'kd_barang
        '
        Me.kd_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_barang.Caption = "Nama Barang"
        Me.kd_barang.ColumnEdit = Me.lkbarang
        Me.kd_barang.FieldName = "kd_barang"
        Me.kd_barang.Name = "kd_barang"
        Me.kd_barang.OptionsColumn.AllowEdit = False
        Me.kd_barang.Visible = True
        Me.kd_barang.VisibleIndex = 0
        Me.kd_barang.Width = 165
        '
        'lkbarang
        '
        Me.lkbarang.AutoHeight = False
        Me.lkbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Barang")})
        Me.lkbarang.DisplayMember = "Nama_Barang"
        Me.lkbarang.Name = "lkbarang"
        Me.lkbarang.ValueMember = "kd_barang"
        '
        'tipe_stok
        '
        Me.tipe_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_stok.Caption = "Tipe Barang"
        Me.tipe_stok.ColumnEdit = Me.lktipe
        Me.tipe_stok.FieldName = "kd_barang"
        Me.tipe_stok.Name = "tipe_stok"
        Me.tipe_stok.OptionsColumn.AllowEdit = False
        Me.tipe_stok.Visible = True
        Me.tipe_stok.VisibleIndex = 1
        Me.tipe_stok.Width = 152
        '
        'lktipe
        '
        Me.lktipe.AutoHeight = False
        Me.lktipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lktipe.Name = "lktipe"
        '
        'kd_kain
        '
        Me.kd_kain.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue
        Me.kd_kain.AppearanceHeader.Options.UseBackColor = True
        Me.kd_kain.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_kain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_kain.Caption = "Kain"
        Me.kd_kain.ColumnEdit = Me.lkkain
        Me.kd_kain.FieldName = "kd_barang"
        Me.kd_kain.Name = "kd_kain"
        Me.kd_kain.OptionsColumn.AllowEdit = False
        Me.kd_kain.Visible = True
        Me.kd_kain.VisibleIndex = 2
        Me.kd_kain.Width = 103
        '
        'lkkain
        '
        Me.lkkain.AutoHeight = False
        Me.lkkain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkain.Name = "lkkain"
        '
        'kd_ukuran
        '
        Me.kd_ukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_ukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.lkukuran
        Me.kd_ukuran.FieldName = "kd_barang"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.OptionsColumn.AllowEdit = False
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 3
        Me.kd_ukuran.Width = 110
        '
        'lkukuran
        '
        Me.lkukuran.AutoHeight = False
        Me.lkukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkukuran.Name = "lkukuran"
        '
        'jumlah_produksi
        '
        Me.jumlah_produksi.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.jumlah_produksi.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_produksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_produksi.Caption = "Jumlah"
        Me.jumlah_produksi.DisplayFormat.FormatString = "0"
        Me.jumlah_produksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_produksi.FieldName = "jumlah_produksi"
        Me.jumlah_produksi.Name = "jumlah_produksi"
        Me.jumlah_produksi.OptionsColumn.AllowEdit = False
        Me.jumlah_produksi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_produksi.Visible = True
        Me.jumlah_produksi.VisibleIndex = 4
        Me.jumlah_produksi.Width = 93
        '
        'jumlah_kerja
        '
        Me.jumlah_kerja.Caption = "Jumlah Dikerjakan"
        Me.jumlah_kerja.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah_kerja.FieldName = "jumlah_kerja"
        Me.jumlah_kerja.Name = "jumlah_kerja"
        Me.jumlah_kerja.Width = 116
        '
        'indeks
        '
        Me.indeks.AppearanceHeader.Options.UseTextOptions = True
        Me.indeks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.indeks.Caption = "Indeks"
        Me.indeks.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.indeks.FieldName = "indeks"
        Me.indeks.Name = "indeks"
        Me.indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.indeks.Visible = True
        Me.indeks.VisibleIndex = 5
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(800, 385)
        Me.pnl.TabIndex = 1
        '
        'clmStatus
        '
        Me.clmStatus.Caption = "Status"
        Me.clmStatus.FieldName = "rec_stat"
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.Visible = True
        Me.clmStatus.VisibleIndex = 4
        Me.clmStatus.Width = 70
        '
        'frmProdTranSpkServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 410)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdTranSpkServ"
        Me.Text = "frmProdTranSpk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        CType(Me.lkkegtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkkegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkspk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkrph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lktipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents clmStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents norph As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lkrph As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents kapasitas As System.Windows.Forms.Label
    Friend WithEvents kgiatanspk As System.Windows.Forms.Label
    Friend WithEvents nospk As System.Windows.Forms.Label
    Friend WithEvents jdwlkerja As System.Windows.Forms.Label
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tipe_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lktipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jumlah_produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkegtn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkkegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkspk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents kapasits As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtjdwl As System.Windows.Forms.TextBox
End Class
