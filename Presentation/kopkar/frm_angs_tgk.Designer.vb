<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_angs_tgk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_angs_tgk))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
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
        Me.lb_nama = New System.Windows.Forms.Label
        Me.lb_pilih_all = New System.Windows.Forms.Label
        Me.cb_all = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gc_byr_piu = New DevExpress.XtraGrid.GridControl
        Me.gv_byr_piu = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cek_byr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_cek_byr = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.gb_no_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_angs_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_ket2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btCari = New System.Windows.Forms.Button
        Me.LUE_nama = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TE_jml_byr = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.dt_tgl = New DevExpress.XtraEditors.DateEdit
        Me.lckPembayaran = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TE_kembali = New DevExpress.XtraEditors.TextEdit
        Me.TE_byr = New DevExpress.XtraEditors.TextEdit
        Me.lb_denda = New System.Windows.Forms.Label
        Me.lb_bunga = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lb_pokok = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gc_byr_piu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_byr_piu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_cek_byr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.TE_jml_byr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckPembayaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(713, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          PEMBAYARAN TUNGGAKAN DAN GAGAL DEBET ANGGOTA"
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
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1002, 412)
        Me.pnl.TabIndex = 162
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.lb_nama)
        Me.Panel2.Controls.Add(Me.lb_pilih_all)
        Me.Panel2.Controls.Add(Me.cb_all)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.gc_byr_piu)
        Me.Panel2.Controls.Add(Me.btCari)
        Me.Panel2.Controls.Add(Me.LUE_nama)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 247)
        Me.Panel2.TabIndex = 3
        '
        'lb_nama
        '
        Me.lb_nama.AutoSize = True
        Me.lb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama.Location = New System.Drawing.Point(296, 21)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(21, 13)
        Me.lb_nama.TabIndex = 346
        Me.lb_nama.Text = "<>"
        '
        'lb_pilih_all
        '
        Me.lb_pilih_all.AutoSize = True
        Me.lb_pilih_all.ForeColor = System.Drawing.Color.Lime
        Me.lb_pilih_all.Location = New System.Drawing.Point(25, 72)
        Me.lb_pilih_all.Name = "lb_pilih_all"
        Me.lb_pilih_all.Size = New System.Drawing.Size(62, 13)
        Me.lb_pilih_all.TabIndex = 341
        Me.lb_pilih_all.Text = "Pilih Semua"
        Me.lb_pilih_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_all
        '
        Me.cb_all.AutoSize = True
        Me.cb_all.Location = New System.Drawing.Point(15, 71)
        Me.cb_all.Name = "cb_all"
        Me.cb_all.Size = New System.Drawing.Size(15, 14)
        Me.cb_all.TabIndex = 340
        Me.cb_all.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(49, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 345
        Me.Label9.Text = "NIP :"
        '
        'gc_byr_piu
        '
        Me.gc_byr_piu.Location = New System.Drawing.Point(93, 44)
        Me.gc_byr_piu.MainView = Me.gv_byr_piu
        Me.gc_byr_piu.Name = "gc_byr_piu"
        Me.gc_byr_piu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_cek_byr})
        Me.gc_byr_piu.Size = New System.Drawing.Size(886, 191)
        Me.gc_byr_piu.TabIndex = 340
        Me.gc_byr_piu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_byr_piu, Me.GridView3})
        '
        'gv_byr_piu
        '
        Me.gv_byr_piu.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.Empty.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gv_byr_piu.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gv_byr_piu.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.gv_byr_piu.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.gv_byr_piu.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gv_byr_piu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gv_byr_piu.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.gv_byr_piu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gv_byr_piu.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gv_byr_piu.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gv_byr_piu.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.OddRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.OddRow.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.OddRow.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv_byr_piu.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv_byr_piu.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.gv_byr_piu.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gv_byr_piu.Appearance.Preview.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.Preview.Options.UseBorderColor = True
        Me.gv_byr_piu.Appearance.Preview.Options.UseFont = True
        Me.gv_byr_piu.Appearance.Preview.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.gv_byr_piu.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv_byr_piu.Appearance.Row.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.Row.Options.UseForeColor = True
        Me.gv_byr_piu.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv_byr_piu.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.gv_byr_piu.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv_byr_piu.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv_byr_piu.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gv_byr_piu.Appearance.VertLine.Options.UseBackColor = True
        Me.gv_byr_piu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cek_byr, Me.gb_no_kartu, Me.gb_nilai, Me.gb_angs_ke, Me.gb_no, Me.gb_tgl_trans, Me.gb_Jenis, Me.gc_ket2})
        Me.gv_byr_piu.GridControl = Me.gc_byr_piu
        Me.gv_byr_piu.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nilai", Me.gb_nilai, "{0:c2}")})
        Me.gv_byr_piu.Name = "gv_byr_piu"
        Me.gv_byr_piu.OptionsNavigation.EnterMoveNextColumn = True
        Me.gv_byr_piu.OptionsView.EnableAppearanceEvenRow = True
        Me.gv_byr_piu.OptionsView.EnableAppearanceOddRow = True
        Me.gv_byr_piu.OptionsView.RowAutoHeight = True
        Me.gv_byr_piu.OptionsView.ShowFooter = True
        Me.gv_byr_piu.OptionsView.ShowGroupPanel = False
        Me.gv_byr_piu.OptionsView.ShowViewCaption = True
        Me.gv_byr_piu.ViewCaption = "Centang Kredit yang akan di Bayar"
        '
        'cek_byr
        '
        Me.cek_byr.Caption = "Bayar"
        Me.cek_byr.ColumnEdit = Me.RL_cek_byr
        Me.cek_byr.FieldName = "cek_byr"
        Me.cek_byr.Name = "cek_byr"
        Me.cek_byr.Visible = True
        Me.cek_byr.VisibleIndex = 1
        Me.cek_byr.Width = 63
        '
        'RL_cek_byr
        '
        Me.RL_cek_byr.AutoHeight = False
        Me.RL_cek_byr.Name = "RL_cek_byr"
        Me.RL_cek_byr.ValueChecked = "Y"
        Me.RL_cek_byr.ValueGrayed = "T"
        Me.RL_cek_byr.ValueUnchecked = "T"
        '
        'gb_no_kartu
        '
        Me.gb_no_kartu.Caption = "No Kartu"
        Me.gb_no_kartu.FieldName = "no_kartu"
        Me.gb_no_kartu.Name = "gb_no_kartu"
        Me.gb_no_kartu.Visible = True
        Me.gb_no_kartu.VisibleIndex = 2
        Me.gb_no_kartu.Width = 110
        '
        'gb_nilai
        '
        Me.gb_nilai.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_nilai.AppearanceCell.Options.UseFont = True
        Me.gb_nilai.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gb_nilai.AppearanceHeader.Options.UseFont = True
        Me.gb_nilai.Caption = "Nilai"
        Me.gb_nilai.DisplayFormat.FormatString = "n0"
        Me.gb_nilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gb_nilai.FieldName = "rp_tunggakan"
        Me.gb_nilai.Name = "gb_nilai"
        Me.gb_nilai.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gb_nilai.SummaryItem.FieldName = "nilai"
        Me.gb_nilai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gb_nilai.Visible = True
        Me.gb_nilai.VisibleIndex = 5
        Me.gb_nilai.Width = 76
        '
        'gb_angs_ke
        '
        Me.gb_angs_ke.Caption = "angs ke"
        Me.gb_angs_ke.FieldName = "angs_ke"
        Me.gb_angs_ke.Name = "gb_angs_ke"
        Me.gb_angs_ke.Width = 49
        '
        'gb_no
        '
        Me.gb_no.Caption = "no"
        Me.gb_no.FieldName = "no_seq"
        Me.gb_no.Name = "gb_no"
        Me.gb_no.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.gb_no.Visible = True
        Me.gb_no.VisibleIndex = 0
        Me.gb_no.Width = 58
        '
        'gb_tgl_trans
        '
        Me.gb_tgl_trans.Caption = "Tanggal"
        Me.gb_tgl_trans.FieldName = "tgl_trans"
        Me.gb_tgl_trans.Name = "gb_tgl_trans"
        Me.gb_tgl_trans.Visible = True
        Me.gb_tgl_trans.VisibleIndex = 4
        Me.gb_tgl_trans.Width = 137
        '
        'gb_Jenis
        '
        Me.gb_Jenis.Caption = "Jenis"
        Me.gb_Jenis.FieldName = "jenis"
        Me.gb_Jenis.Name = "gb_Jenis"
        Me.gb_Jenis.Visible = True
        Me.gb_Jenis.VisibleIndex = 3
        Me.gb_Jenis.Width = 33
        '
        'gc_ket2
        '
        Me.gc_ket2.Caption = "Keterangan"
        Me.gc_ket2.FieldName = "keterangan"
        Me.gc_ket2.Name = "gc_ket2"
        Me.gc_ket2.Visible = True
        Me.gc_ket2.VisibleIndex = 7
        Me.gc_ket2.Width = 375
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gc_byr_piu
        Me.GridView3.Name = "GridView3"
        '
        'btCari
        '
        Me.btCari.BackColor = System.Drawing.Color.Green
        Me.btCari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btCari.Location = New System.Drawing.Point(233, 16)
        Me.btCari.Name = "btCari"
        Me.btCari.Size = New System.Drawing.Size(36, 23)
        Me.btCari.TabIndex = 344
        Me.btCari.Text = "Cari"
        Me.btCari.UseVisualStyleBackColor = False
        '
        'LUE_nama
        '
        Me.LUE_nama.Location = New System.Drawing.Point(93, 18)
        Me.LUE_nama.Name = "LUE_nama"
        Me.LUE_nama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUE_nama.Properties.Appearance.Options.UseBackColor = True
        Me.LUE_nama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_nama.Properties.NullText = ""
        Me.LUE_nama.Size = New System.Drawing.Size(134, 20)
        Me.LUE_nama.TabIndex = 343
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.Controls.Add(Me.TE_jml_byr)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dt_tgl)
        Me.Panel5.Controls.Add(Me.lckPembayaran)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.TE_kembali)
        Me.Panel5.Controls.Add(Me.TE_byr)
        Me.Panel5.Controls.Add(Me.lb_denda)
        Me.Panel5.Controls.Add(Me.lb_bunga)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lb_pokok)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 247)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1002, 165)
        Me.Panel5.TabIndex = 2
        '
        'TE_jml_byr
        '
        Me.TE_jml_byr.EditValue = "0"
        Me.TE_jml_byr.Location = New System.Drawing.Point(137, 15)
        Me.TE_jml_byr.Name = "TE_jml_byr"
        Me.TE_jml_byr.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_jml_byr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_jml_byr.Properties.EditFormat.FormatString = "n2"
        Me.TE_jml_byr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_jml_byr.Properties.Mask.EditMask = "n2"
        Me.TE_jml_byr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_jml_byr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TE_jml_byr.Size = New System.Drawing.Size(112, 20)
        Me.TE_jml_byr.TabIndex = 342
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(47, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 280
        Me.Label6.Text = "Tgl Lunas :"
        '
        'dt_tgl
        '
        Me.dt_tgl.EditValue = Nothing
        Me.dt_tgl.Location = New System.Drawing.Point(145, 49)
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
        'lckPembayaran
        '
        Me.lckPembayaran.Location = New System.Drawing.Point(143, 76)
        Me.lckPembayaran.Name = "lckPembayaran"
        Me.lckPembayaran.Properties.AutoHeight = False
        Me.lckPembayaran.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.lckPembayaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(46, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Pembayaran :"
        '
        'TE_kembali
        '
        Me.TE_kembali.Location = New System.Drawing.Point(373, 105)
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
        Me.TE_byr.Location = New System.Drawing.Point(144, 105)
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
        Me.lb_denda.Location = New System.Drawing.Point(600, 16)
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
        Me.lb_bunga.Location = New System.Drawing.Point(467, 16)
        Me.lb_bunga.Name = "lb_bunga"
        Me.lb_bunga.Size = New System.Drawing.Size(41, 15)
        Me.lb_bunga.TabIndex = 65
        Me.lb_bunga.Text = "<Rp>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(549, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Denda="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(430, 18)
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
        Me.lb_pokok.Location = New System.Drawing.Point(334, 16)
        Me.lb_pokok.Name = "lb_pokok"
        Me.lb_pokok.Size = New System.Drawing.Size(41, 15)
        Me.lb_pokok.TabIndex = 62
        Me.lb_pokok.Text = "<Rp>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(260, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Rincian Pokok="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(299, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Kembali :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(31, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Jumlah Angsuran :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkGray
        Me.Label27.Location = New System.Drawing.Point(46, 106)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 15)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Dibayar :"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'frm_angs_tgk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 450)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_angs_tgk"
        Me.Text = "frm_angs_tgk"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.gc_byr_piu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_byr_piu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_cek_byr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.TE_jml_byr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckPembayaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_kembali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_byr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lb_pilih_all As System.Windows.Forms.Label
    Friend WithEvents cb_all As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_tgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lckPembayaran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TE_kembali As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TE_byr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lb_denda As System.Windows.Forms.Label
    Friend WithEvents lb_bunga As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb_pokok As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_byr_piu As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_byr_piu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cek_byr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_cek_byr As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gb_no_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_angs_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btCari As System.Windows.Forms.Button
    Friend WithEvents LUE_nama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gc_ket2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lb_nama As System.Windows.Forms.Label
    Friend WithEvents TE_jml_byr As DevExpress.XtraEditors.TextEdit
End Class
