<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_angs1
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_angs1))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tx_id = New System.Windows.Forms.TextBox
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lb_pokok = New System.Windows.Forms.Label
        Me.dt_tgl = New DevExpress.XtraEditors.DateEdit
        Me.lb_tot = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lckPembayaran = New DevExpress.XtraEditors.LookUpEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lb_bunga = New System.Windows.Forms.Label
        Me.TE_kembali = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lb_denda = New System.Windows.Forms.Label
        Me.TE_byr = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GcHist = New DevExpress.XtraGrid.GridControl
        Me.Gv_hist = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.v_sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_lunas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gv_nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_BUNGA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Gd_bg_jln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckPembayaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcHist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv_hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(33, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Jumlah Angsuran :"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(332, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(133, 56)
        Me.tx_id.Name = "tx_id"
        Me.tx_id.Size = New System.Drawing.Size(144, 20)
        Me.tx_id.TabIndex = 1
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(132, 20)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(170, 20)
        Me.tx_nama.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1002, 331)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tx_nama)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.tx_id)
        Me.Panel4.Controls.Add(Me.lb_pokok)
        Me.Panel4.Controls.Add(Me.dt_tgl)
        Me.Panel4.Controls.Add(Me.lb_tot)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.lckPembayaran)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Controls.Add(Me.lb_bunga)
        Me.Panel4.Controls.Add(Me.TE_kembali)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.lb_denda)
        Me.Panel4.Controls.Add(Me.TE_byr)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(474, 331)
        Me.Panel4.TabIndex = 282
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(27, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 280
        Me.Label6.Text = "Tgl Lunas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(38, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Rincian Pokok="
        '
        'lb_pokok
        '
        Me.lb_pokok.AutoSize = True
        Me.lb_pokok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pokok.ForeColor = System.Drawing.Color.Gold
        Me.lb_pokok.Location = New System.Drawing.Point(112, 109)
        Me.lb_pokok.Name = "lb_pokok"
        Me.lb_pokok.Size = New System.Drawing.Size(41, 15)
        Me.lb_pokok.TabIndex = 62
        Me.lb_pokok.Text = "<Rp>"
        '
        'dt_tgl
        '
        Me.dt_tgl.EditValue = Nothing
        Me.dt_tgl.Location = New System.Drawing.Point(125, 163)
        Me.dt_tgl.Name = "dt_tgl"
        Me.dt_tgl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_tgl.Properties.Appearance.Options.UseFont = True
        Me.dt_tgl.Properties.Appearance.Options.UseTextOptions = True
        Me.dt_tgl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dt_tgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_tgl.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dt_tgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_tgl.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.dt_tgl.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.dt_tgl.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dt_tgl.Size = New System.Drawing.Size(212, 20)
        Me.dt_tgl.TabIndex = 279
        '
        'lb_tot
        '
        Me.lb_tot.AutoSize = True
        Me.lb_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tot.ForeColor = System.Drawing.Color.Gold
        Me.lb_tot.Location = New System.Drawing.Point(133, 87)
        Me.lb_tot.Name = "lb_tot"
        Me.lb_tot.Size = New System.Drawing.Size(41, 15)
        Me.lb_tot.TabIndex = 60
        Me.lb_tot.Text = "<Rp>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(38, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Bunga="
        '
        'lckPembayaran
        '
        Me.lckPembayaran.Location = New System.Drawing.Point(123, 190)
        Me.lckPembayaran.Name = "lckPembayaran"
        Me.lckPembayaran.Properties.AutoHeight = False
        Me.lckPembayaran.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.lckPembayaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.lckPembayaran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name3")})
        Me.lckPembayaran.Properties.DropDownRows = 10
        Me.lckPembayaran.Properties.ImmediatePopup = True
        Me.lckPembayaran.Properties.NullText = "{Pilih Pembayaran}"
        Me.lckPembayaran.Properties.ShowFooter = False
        Me.lckPembayaran.Properties.ShowPopupShadow = False
        Me.lckPembayaran.Properties.ValidateOnEnterKey = True
        Me.lckPembayaran.Size = New System.Drawing.Size(284, 20)
        Me.lckPembayaran.TabIndex = 70
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkGray
        Me.Label27.Location = New System.Drawing.Point(26, 220)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 15)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Dibayar :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(234, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Denda/Bg berjalan="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(26, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Pembayaran :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.DarkGray
        Me.Label34.Location = New System.Drawing.Point(34, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Nama :"
        '
        'lb_bunga
        '
        Me.lb_bunga.AutoSize = True
        Me.lb_bunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bunga.ForeColor = System.Drawing.Color.Gold
        Me.lb_bunga.Location = New System.Drawing.Point(80, 122)
        Me.lb_bunga.Name = "lb_bunga"
        Me.lb_bunga.Size = New System.Drawing.Size(41, 15)
        Me.lb_bunga.TabIndex = 65
        Me.lb_bunga.Text = "<Rp>"
        '
        'TE_kembali
        '
        Me.TE_kembali.Location = New System.Drawing.Point(353, 219)
        Me.TE_kembali.Name = "TE_kembali"
        Me.TE_kembali.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_kembali.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_kembali.Properties.Mask.EditMask = "n2"
        Me.TE_kembali.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_kembali.Size = New System.Drawing.Size(100, 20)
        Me.TE_kembali.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(279, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Kembali :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.DarkGray
        Me.Label33.Location = New System.Drawing.Point(34, 59)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(75, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "NIP Pegawai :"
        '
        'lb_denda
        '
        Me.lb_denda.AutoSize = True
        Me.lb_denda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_denda.ForeColor = System.Drawing.Color.Gold
        Me.lb_denda.Location = New System.Drawing.Point(343, 96)
        Me.lb_denda.Name = "lb_denda"
        Me.lb_denda.Size = New System.Drawing.Size(41, 15)
        Me.lb_denda.TabIndex = 66
        Me.lb_denda.Text = "<Rp>"
        '
        'TE_byr
        '
        Me.TE_byr.Location = New System.Drawing.Point(124, 219)
        Me.TE_byr.Name = "TE_byr"
        Me.TE_byr.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_byr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_byr.Properties.Mask.EditMask = "n2"
        Me.TE_byr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_byr.Size = New System.Drawing.Size(126, 20)
        Me.TE_byr.TabIndex = 67
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcHist)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(474, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(528, 331)
        Me.Panel3.TabIndex = 281
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 38)
        Me.Panel1.TabIndex = 161
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
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          PEMBAYARAN ANGSURAN KREDIT ANGGOTA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1002, 362)
        Me.pnl.TabIndex = 162
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 31)
        Me.Panel2.TabIndex = 3
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'GcHist
        '
        Me.GcHist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcHist.Location = New System.Drawing.Point(0, 0)
        Me.GcHist.MainView = Me.Gv_hist
        Me.GcHist.Name = "GcHist"
        Me.GcHist.Size = New System.Drawing.Size(528, 331)
        Me.GcHist.TabIndex = 13
        Me.GcHist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv_hist, Me.GridView4})
        '
        'Gv_hist
        '
        Me.Gv_hist.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gv_hist.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gv_hist.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.Gv_hist.Appearance.Empty.Options.UseBackColor = True
        Me.Gv_hist.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_hist.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_hist.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.EvenRow.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gv_hist.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gv_hist.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_hist.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gv_hist.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Gv_hist.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gv_hist.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gv_hist.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Gv_hist.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_hist.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gv_hist.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gv_hist.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gv_hist.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gv_hist.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gv_hist.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gv_hist.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gv_hist.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gv_hist.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_hist.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gv_hist.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gv_hist.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gv_hist.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_hist.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_hist.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gv_hist.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gv_hist.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Gv_hist.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.Gv_hist.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gv_hist.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gv_hist.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_hist.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_hist.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.OddRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.OddRow.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.OddRow.Options.UseForeColor = True
        Me.Gv_hist.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_hist.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_hist.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Gv_hist.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Gv_hist.Appearance.Preview.Options.UseBackColor = True
        Me.Gv_hist.Appearance.Preview.Options.UseBorderColor = True
        Me.Gv_hist.Appearance.Preview.Options.UseFont = True
        Me.Gv_hist.Appearance.Preview.Options.UseForeColor = True
        Me.Gv_hist.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_hist.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gv_hist.Appearance.Row.Options.UseBackColor = True
        Me.Gv_hist.Appearance.Row.Options.UseForeColor = True
        Me.Gv_hist.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_hist.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.Gv_hist.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gv_hist.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_hist.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.Gv_hist.Appearance.TopNewRow.Options.UseBackColor = True
        Me.Gv_hist.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_hist.Appearance.VertLine.Options.UseBackColor = True
        Me.Gv_hist.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tgl_trans, Me.v_sisa_pokok, Me.LAMA_ANGS, Me.sisa_angs, Me.no_kartu, Me.rec_lunas, Me.gv_nasabah_id, Me.jenis, Me.gc_nilai, Me.kd_kredit, Me.gc_sisa, Me.JML_BUNGA, Me.Gd_bg_jln})
        Me.Gv_hist.GridControl = Me.GcHist
        Me.Gv_hist.Name = "Gv_hist"
        Me.Gv_hist.OptionsCustomization.AllowGroup = False
        Me.Gv_hist.OptionsNavigation.EnterMoveNextColumn = True
        Me.Gv_hist.OptionsView.ColumnAutoWidth = False
        Me.Gv_hist.OptionsView.EnableAppearanceEvenRow = True
        Me.Gv_hist.OptionsView.EnableAppearanceOddRow = True
        Me.Gv_hist.OptionsView.RowAutoHeight = True
        Me.Gv_hist.OptionsView.ShowFooter = True
        Me.Gv_hist.OptionsView.ShowGroupPanel = False
        Me.Gv_hist.OptionsView.ShowViewCaption = True
        Me.Gv_hist.ViewCaption = "Silahkan entry nilai di kolom Bayar"
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal Pengajuan"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 0
        Me.tgl_trans.Width = 67
        '
        'v_sisa_pokok
        '
        Me.v_sisa_pokok.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.v_sisa_pokok.AppearanceCell.Options.UseBackColor = True
        Me.v_sisa_pokok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.v_sisa_pokok.AppearanceHeader.Options.UseFont = True
        Me.v_sisa_pokok.Caption = "Sisa Pokok"
        Me.v_sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.v_sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.v_sisa_pokok.FieldName = "sisa_pokok"
        Me.v_sisa_pokok.Name = "v_sisa_pokok"
        Me.v_sisa_pokok.OptionsColumn.AllowEdit = False
        Me.v_sisa_pokok.OptionsColumn.ReadOnly = True
        Me.v_sisa_pokok.SummaryItem.DisplayFormat = "{0:n0}"
        Me.v_sisa_pokok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.v_sisa_pokok.Visible = True
        Me.v_sisa_pokok.VisibleIndex = 4
        Me.v_sisa_pokok.Width = 73
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.Caption = "Lama Angsuran"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.OptionsColumn.AllowEdit = False
        Me.LAMA_ANGS.OptionsColumn.ReadOnly = True
        Me.LAMA_ANGS.Width = 53
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "Sisa Angs"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.OptionsColumn.AllowEdit = False
        Me.sisa_angs.OptionsColumn.ReadOnly = True
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 3
        Me.sisa_angs.Width = 58
        '
        'no_kartu
        '
        Me.no_kartu.Caption = "No Pengajuan"
        Me.no_kartu.FieldName = "no_kartu"
        Me.no_kartu.Name = "no_kartu"
        Me.no_kartu.OptionsColumn.AllowEdit = False
        Me.no_kartu.OptionsColumn.ReadOnly = True
        Me.no_kartu.Width = 71
        '
        'rec_lunas
        '
        Me.rec_lunas.Caption = "Lunas"
        Me.rec_lunas.FieldName = "rec_lunas"
        Me.rec_lunas.Name = "rec_lunas"
        Me.rec_lunas.OptionsColumn.AllowEdit = False
        Me.rec_lunas.OptionsColumn.ReadOnly = True
        Me.rec_lunas.Width = 46
        '
        'gv_nasabah_id
        '
        Me.gv_nasabah_id.Caption = "NIP"
        Me.gv_nasabah_id.FieldName = "nasabah_id"
        Me.gv_nasabah_id.Name = "gv_nasabah_id"
        Me.gv_nasabah_id.OptionsColumn.AllowEdit = False
        Me.gv_nasabah_id.OptionsColumn.ReadOnly = True
        Me.gv_nasabah_id.Width = 29
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.OptionsColumn.ReadOnly = True
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 1
        Me.jenis.Width = 46
        '
        'gc_nilai
        '
        Me.gc_nilai.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gc_nilai.AppearanceCell.Options.UseBackColor = True
        Me.gc_nilai.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gc_nilai.AppearanceHeader.Options.UseFont = True
        Me.gc_nilai.Caption = "diBayar"
        Me.gc_nilai.DisplayFormat.FormatString = "n0"
        Me.gc_nilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_nilai.FieldName = "nilai"
        Me.gc_nilai.Name = "gc_nilai"
        Me.gc_nilai.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gc_nilai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gc_nilai.Visible = True
        Me.gc_nilai.VisibleIndex = 5
        Me.gc_nilai.Width = 68
        '
        'kd_kredit
        '
        Me.kd_kredit.Caption = "Type"
        Me.kd_kredit.FieldName = "kd_kredit"
        Me.kd_kredit.Name = "kd_kredit"
        Me.kd_kredit.OptionsColumn.AllowEdit = False
        Me.kd_kredit.OptionsColumn.ReadOnly = True
        Me.kd_kredit.Width = 26
        '
        'gc_sisa
        '
        Me.gc_sisa.Caption = "Sisa"
        Me.gc_sisa.DisplayFormat.FormatString = "n0"
        Me.gc_sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_sisa.FieldName = "sisa"
        Me.gc_sisa.Name = "gc_sisa"
        Me.gc_sisa.OptionsColumn.AllowEdit = False
        Me.gc_sisa.OptionsColumn.ReadOnly = True
        Me.gc_sisa.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gc_sisa.SummaryItem.FieldName = "gc_sisa"
        Me.gc_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gc_sisa.Visible = True
        Me.gc_sisa.VisibleIndex = 7
        Me.gc_sisa.Width = 62
        '
        'JML_BUNGA
        '
        Me.JML_BUNGA.Caption = "Bunga"
        Me.JML_BUNGA.DisplayFormat.FormatString = "n0"
        Me.JML_BUNGA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_BUNGA.FieldName = "jml_bunga"
        Me.JML_BUNGA.Name = "JML_BUNGA"
        Me.JML_BUNGA.OptionsColumn.AllowEdit = False
        Me.JML_BUNGA.OptionsColumn.ReadOnly = True
        Me.JML_BUNGA.SummaryItem.DisplayFormat = "{0:n0}"
        Me.JML_BUNGA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_BUNGA.Visible = True
        Me.JML_BUNGA.VisibleIndex = 2
        Me.JML_BUNGA.Width = 61
        '
        'Gd_bg_jln
        '
        Me.Gd_bg_jln.Caption = "Bunga Berjalan"
        Me.Gd_bg_jln.DisplayFormat.FormatString = "n0"
        Me.Gd_bg_jln.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Gd_bg_jln.FieldName = "bg_jln"
        Me.Gd_bg_jln.Name = "Gd_bg_jln"
        Me.Gd_bg_jln.OptionsColumn.AllowEdit = False
        Me.Gd_bg_jln.OptionsColumn.ReadOnly = True
        Me.Gd_bg_jln.SummaryItem.DisplayFormat = "{0:n0}"
        Me.Gd_bg_jln.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Gd_bg_jln.Visible = True
        Me.Gd_bg_jln.VisibleIndex = 6
        Me.Gd_bg_jln.Width = 84
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GcHist
        Me.GridView4.Name = "GridView4"
        '
        'frm_angs1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 400)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_angs1"
        Me.Text = "frm_angs"
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckPembayaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcHist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv_hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tx_id As System.Windows.Forms.TextBox
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_tot As System.Windows.Forms.Label
    Friend WithEvents lb_pokok As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_denda As System.Windows.Forms.Label
    Friend WithEvents lb_bunga As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TE_byr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TE_kembali As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lckPembayaran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_tgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GcHist As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv_hist As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents v_sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_lunas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gv_nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_BUNGA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gd_bg_jln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
