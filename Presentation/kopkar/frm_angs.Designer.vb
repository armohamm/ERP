<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_angs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_angs))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tx_id = New System.Windows.Forms.TextBox
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TE_kembali = New DevExpress.XtraEditors.TextEdit
        Me.TE_byr = New DevExpress.XtraEditors.TextEdit
        Me.lb_denda = New System.Windows.Forms.Label
        Me.lb_bunga = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_pokok = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lb_tot = New System.Windows.Forms.Label
        Me.tx_noTbg = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_angs = New DevExpress.XtraGrid.GridControl
        Me.Gv_angs = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.angsuran_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_nasabah = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5.SuspendLayout()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_angs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv_angs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_nasabah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(27, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Jumlah Angsuran :"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(326, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(127, 52)
        Me.tx_id.Name = "tx_id"
        Me.tx_id.Size = New System.Drawing.Size(144, 20)
        Me.tx_id.TabIndex = 1
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(126, 16)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(170, 20)
        Me.tx_nama.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.TE_kembali)
        Me.Panel5.Controls.Add(Me.TE_byr)
        Me.Panel5.Controls.Add(Me.lb_denda)
        Me.Panel5.Controls.Add(Me.lb_bunga)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lb_pokok)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lb_tot)
        Me.Panel5.Controls.Add(Me.tx_noTbg)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.tx_id)
        Me.Panel5.Controls.Add(Me.tx_nama)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1002, 156)
        Me.Panel5.TabIndex = 2
        '
        'TE_kembali
        '
        Me.TE_kembali.Location = New System.Drawing.Point(355, 119)
        Me.TE_kembali.Name = "TE_kembali"
        Me.TE_kembali.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_kembali.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_kembali.Properties.Mask.EditMask = "n2"
        Me.TE_kembali.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_kembali.Size = New System.Drawing.Size(100, 20)
        Me.TE_kembali.TabIndex = 68
        '
        'TE_byr
        '
        Me.TE_byr.Location = New System.Drawing.Point(126, 119)
        Me.TE_byr.Name = "TE_byr"
        Me.TE_byr.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_byr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_byr.Properties.Mask.EditMask = "n2"
        Me.TE_byr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_byr.Size = New System.Drawing.Size(126, 20)
        Me.TE_byr.TabIndex = 67
        '
        'lb_denda
        '
        Me.lb_denda.AutoSize = True
        Me.lb_denda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_denda.ForeColor = System.Drawing.Color.Gold
        Me.lb_denda.Location = New System.Drawing.Point(574, 83)
        Me.lb_denda.Name = "lb_denda"
        Me.lb_denda.Size = New System.Drawing.Size(41, 15)
        Me.lb_denda.TabIndex = 66
        Me.lb_denda.Text = "<Rp>"
        '
        'lb_bunga
        '
        Me.lb_bunga.AutoSize = True
        Me.lb_bunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bunga.ForeColor = System.Drawing.Color.Gold
        Me.lb_bunga.Location = New System.Drawing.Point(441, 83)
        Me.lb_bunga.Name = "lb_bunga"
        Me.lb_bunga.Size = New System.Drawing.Size(41, 15)
        Me.lb_bunga.TabIndex = 65
        Me.lb_bunga.Text = "<Rp>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(523, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Denda="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(404, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Bunga="
        '
        'lb_pokok
        '
        Me.lb_pokok.AutoSize = True
        Me.lb_pokok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pokok.ForeColor = System.Drawing.Color.Gold
        Me.lb_pokok.Location = New System.Drawing.Point(308, 83)
        Me.lb_pokok.Name = "lb_pokok"
        Me.lb_pokok.Size = New System.Drawing.Size(41, 15)
        Me.lb_pokok.TabIndex = 62
        Me.lb_pokok.Text = "<Rp>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(234, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Rincian Pokok="
        '
        'lb_tot
        '
        Me.lb_tot.AutoSize = True
        Me.lb_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tot.ForeColor = System.Drawing.Color.Gold
        Me.lb_tot.Location = New System.Drawing.Point(127, 83)
        Me.lb_tot.Name = "lb_tot"
        Me.lb_tot.Size = New System.Drawing.Size(41, 15)
        Me.lb_tot.TabIndex = 60
        Me.lb_tot.Text = "<Rp>"
        '
        'tx_noTbg
        '
        Me.tx_noTbg.Location = New System.Drawing.Point(407, 52)
        Me.tx_noTbg.Name = "tx_noTbg"
        Me.tx_noTbg.Size = New System.Drawing.Size(100, 20)
        Me.tx_noTbg.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(327, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Nomor Kredit :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(281, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Kembali :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.DarkGray
        Me.Label33.Location = New System.Drawing.Point(28, 55)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(75, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "NIP Pegawai :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.DarkGray
        Me.Label34.Location = New System.Drawing.Point(28, 21)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Nama :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkGray
        Me.Label27.Location = New System.Drawing.Point(28, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 15)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Dibayar :"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_angs)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 164)
        Me.Panel2.TabIndex = 3
        '
        'Gc_angs
        '
        Me.Gc_angs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_angs.Location = New System.Drawing.Point(0, 0)
        Me.Gc_angs.MainView = Me.Gv_angs
        Me.Gc_angs.Name = "Gc_angs"
        Me.Gc_angs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_nasabah})
        Me.Gc_angs.Size = New System.Drawing.Size(1002, 164)
        Me.Gc_angs.TabIndex = 12
        Me.Gc_angs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv_angs, Me.GridView4})
        '
        'Gv_angs
        '
        Me.Gv_angs.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Gv_angs.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Gv_angs.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.Gv_angs.Appearance.Empty.Options.UseBackColor = True
        Me.Gv_angs.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_angs.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_angs.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.EvenRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.EvenRow.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.EvenRow.Options.UseForeColor = True
        Me.Gv_angs.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.Gv_angs.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_angs.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Gv_angs.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Gv_angs.Appearance.FixedLine.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.Gv_angs.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.FocusedCell.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FocusedCell.Options.UseForeColor = True
        Me.Gv_angs.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Gv_angs.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_angs.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Gv_angs.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gv_angs.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Gv_angs.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.FooterPanel.Options.UseForeColor = True
        Me.Gv_angs.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.GroupButton.Options.UseBackColor = True
        Me.Gv_angs.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.GroupButton.Options.UseForeColor = True
        Me.Gv_angs.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Gv_angs.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.GroupFooter.Options.UseForeColor = True
        Me.Gv_angs.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.Gv_angs.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Gv_angs.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Gv_angs.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.GroupRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.GroupRow.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.GroupRow.Options.UseForeColor = True
        Me.Gv_angs.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_angs.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Gv_angs.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Gv_angs.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.Gv_angs.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Gv_angs.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.Gv_angs.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.Gv_angs.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.HorzLine.Options.UseBackColor = True
        Me.Gv_angs.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_angs.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Gv_angs.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.OddRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.OddRow.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.OddRow.Options.UseForeColor = True
        Me.Gv_angs.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_angs.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Gv_angs.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Gv_angs.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Gv_angs.Appearance.Preview.Options.UseBackColor = True
        Me.Gv_angs.Appearance.Preview.Options.UseBorderColor = True
        Me.Gv_angs.Appearance.Preview.Options.UseFont = True
        Me.Gv_angs.Appearance.Preview.Options.UseForeColor = True
        Me.Gv_angs.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Gv_angs.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.Gv_angs.Appearance.Row.Options.UseBackColor = True
        Me.Gv_angs.Appearance.Row.Options.UseForeColor = True
        Me.Gv_angs.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gv_angs.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.Gv_angs.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Gv_angs.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Gv_angs.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.Gv_angs.Appearance.TopNewRow.Options.UseBackColor = True
        Me.Gv_angs.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Gv_angs.Appearance.VertLine.Options.UseBackColor = True
        Me.Gv_angs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_kredit, Me.angsuran_ke, Me.nasabah_id, Me.Nama, Me.rp_total, Me.sisa_angs, Me.tgl_bayar})
        Me.Gv_angs.GridControl = Me.Gc_angs
        Me.Gv_angs.Name = "Gv_angs"
        Me.Gv_angs.OptionsCustomization.AllowColumnMoving = False
        Me.Gv_angs.OptionsCustomization.AllowFilter = False
        Me.Gv_angs.OptionsCustomization.AllowGroup = False
        Me.Gv_angs.OptionsNavigation.EnterMoveNextColumn = True
        Me.Gv_angs.OptionsView.EnableAppearanceEvenRow = True
        Me.Gv_angs.OptionsView.EnableAppearanceOddRow = True
        Me.Gv_angs.OptionsView.RowAutoHeight = True
        Me.Gv_angs.OptionsView.ShowFooter = True
        Me.Gv_angs.OptionsView.ShowGroupPanel = False
        Me.Gv_angs.OptionsView.ShowViewCaption = True
        Me.Gv_angs.ViewCaption = "ANGSURAN KREDIT"
        '
        'no_kredit
        '
        Me.no_kredit.Caption = "No Kredit"
        Me.no_kredit.FieldName = "no_kredit"
        Me.no_kredit.Name = "no_kredit"
        Me.no_kredit.OptionsColumn.AllowEdit = False
        Me.no_kredit.OptionsColumn.ReadOnly = True
        Me.no_kredit.Visible = True
        Me.no_kredit.VisibleIndex = 0
        Me.no_kredit.Width = 92
        '
        'angsuran_ke
        '
        Me.angsuran_ke.Caption = "Angsuran Ke"
        Me.angsuran_ke.FieldName = "angsuran_ke"
        Me.angsuran_ke.Name = "angsuran_ke"
        Me.angsuran_ke.OptionsColumn.AllowEdit = False
        Me.angsuran_ke.OptionsColumn.ReadOnly = True
        Me.angsuran_ke.Visible = True
        Me.angsuran_ke.VisibleIndex = 1
        Me.angsuran_ke.Width = 70
        '
        'nasabah_id
        '
        Me.nasabah_id.Caption = "ID nasabah "
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 2
        Me.nasabah_id.Width = 83
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 3
        Me.Nama.Width = 162
        '
        'rp_total
        '
        Me.rp_total.Caption = "Angsuran"
        Me.rp_total.FieldName = "rp_total"
        Me.rp_total.Name = "rp_total"
        Me.rp_total.Visible = True
        Me.rp_total.VisibleIndex = 4
        Me.rp_total.Width = 180
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "Sisa Angsuran"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 5
        Me.sisa_angs.Width = 99
        '
        'tgl_bayar
        '
        Me.tgl_bayar.Caption = "Tgl Bayar"
        Me.tgl_bayar.FieldName = "tgl_bayar"
        Me.tgl_bayar.Name = "tgl_bayar"
        Me.tgl_bayar.Visible = True
        Me.tgl_bayar.VisibleIndex = 6
        Me.tgl_bayar.Width = 295
        '
        'RL_nasabah
        '
        Me.RL_nasabah.AutoHeight = False
        Me.RL_nasabah.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_nasabah.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_nasabah.Name = "RL_nasabah"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Gc_angs
        Me.GridView4.Name = "GridView4"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1002, 320)
        Me.pnl.TabIndex = 162
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'frm_angs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 358)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_angs"
        Me.Text = "frm_angs"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_angs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv_angs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_nasabah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_noTbg As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Gc_angs As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv_angs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents angsuran_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_nasabah As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lb_tot As System.Windows.Forms.Label
    Friend WithEvents lb_pokok As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_denda As System.Windows.Forms.Label
    Friend WithEvents lb_bunga As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TE_byr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TE_kembali As DevExpress.XtraEditors.TextEdit
End Class
