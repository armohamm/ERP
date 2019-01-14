<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kredit_Rec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kredit_Rec))
        Me.GVHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_pinjaman = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lama_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.angs_bunga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCHistory = New DevExpress.XtraGrid.GridControl
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GCKartu = New DevExpress.XtraGrid.GridControl
        Me.GVKartu = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.bt_surat = New System.Windows.Forms.Button
        Me.bt_komite = New System.Windows.Forms.Button
        Me.bt_kartu = New System.Windows.Forms.Button
        Me.te_norek_debet2 = New DevExpress.XtraEditors.TextEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.cb_biaya_provisi = New DevExpress.XtraEditors.CheckEdit
        Me.cb_jml_terima = New DevExpress.XtraEditors.CheckEdit
        Me.cb_biaya_penalty = New DevExpress.XtraEditors.CheckEdit
        Me.cb_angsuran_pokok = New DevExpress.XtraEditors.CheckEdit
        Me.le_batas_admin = New DevExpress.XtraEditors.LookUpEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.te_no_form = New DevExpress.XtraEditors.TextEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lb_line = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.te_angsuran_total = New DevExpress.XtraEditors.TextEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.te_bunga_berjalan = New DevExpress.XtraEditors.TextEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.te_angsuran_bunga = New DevExpress.XtraEditors.TextEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.te_biaya_penalty = New DevExpress.XtraEditors.TextEdit
        Me.lb_penalty = New System.Windows.Forms.Label
        Me.te_angsuran_pokok = New DevExpress.XtraEditors.TextEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.te_total_recovery = New DevExpress.XtraEditors.TextEdit
        Me.Label25 = New System.Windows.Forms.Label
        Me.te_pot_tat = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.te_pot_thr = New DevExpress.XtraEditors.TextEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.te_pot_bonus = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.te_norek_debet = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.te_norek_cair = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.te_keterangan = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.te_bunga = New DevExpress.XtraEditors.TextEdit
        Me.te_biaya_admin = New DevExpress.XtraEditors.TextEdit
        Me.te_biaya_provisi = New DevExpress.XtraEditors.TextEdit
        Me.te_jml_terima = New DevExpress.XtraEditors.TextEdit
        Me.te_lama_pinjaman = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.te_jml_pinjaman = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.lb_nasabah = New System.Windows.Forms.Label
        Me.le_nama = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lb_denda = New System.Windows.Forms.Label
        Me.lb_provisi = New System.Windows.Forms.Label
        Me.lb_bunga = New System.Windows.Forms.Label
        Me.lb_no_trans = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lb_admin = New System.Windows.Forms.Label
        Me.lb_plafond = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.le_tipe_kredit = New DevExpress.XtraEditors.LookUpEdit
        Me.le_jenis_kredit = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.dt_tanggal_debet = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.dt_tanggal = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.GVHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GCKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.te_norek_debet2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_biaya_provisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_jml_terima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_biaya_penalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_angsuran_pokok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.le_batas_admin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_no_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_angsuran_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_bunga_berjalan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_angsuran_bunga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_biaya_penalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_angsuran_pokok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_total_recovery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_pot_tat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_pot_thr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_pot_bonus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_norek_debet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_norek_cair.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_bunga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_biaya_admin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_biaya_provisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_jml_terima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_lama_pinjaman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_jml_pinjaman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.le_nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.le_tipe_kredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.le_jenis_kredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tanggal_debet.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tanggal_debet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVHistory
        '
        Me.GVHistory.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVHistory.Appearance.GroupPanel.Options.UseFont = True
        Me.GVHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tgl_trans, Me.no_trans, Me.no_ref, Me.jenis, Me.jml_pinjaman, Me.sisa_pokok, Me.lama_angs, Me.sisa_angs, Me.nilai, Me.sisa, Me.angs_bunga, Me.GridColumn3})
        Me.GVHistory.GridControl = Me.GCHistory
        Me.GVHistory.GroupPanelText = "PINJAMAN OUTSTANDING"
        Me.GVHistory.Name = "GVHistory"
        Me.GVHistory.OptionsView.ColumnAutoWidth = False
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 0
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Transaksi"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.ReadOnly = True
        '
        'no_ref
        '
        Me.no_ref.Caption = "No Form"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 1
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.ReadOnly = True
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 8
        '
        'jml_pinjaman
        '
        Me.jml_pinjaman.Caption = "Pinjaman"
        Me.jml_pinjaman.DisplayFormat.FormatString = "n0"
        Me.jml_pinjaman.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_pinjaman.FieldName = "jml_pinjaman"
        Me.jml_pinjaman.Name = "jml_pinjaman"
        Me.jml_pinjaman.OptionsColumn.ReadOnly = True
        Me.jml_pinjaman.Visible = True
        Me.jml_pinjaman.VisibleIndex = 2
        '
        'sisa_pokok
        '
        Me.sisa_pokok.Caption = "Sisa Pinjaman"
        Me.sisa_pokok.DisplayFormat.FormatString = "n0"
        Me.sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa_pokok.FieldName = "sisa_pokok"
        Me.sisa_pokok.Name = "sisa_pokok"
        Me.sisa_pokok.OptionsColumn.ReadOnly = True
        Me.sisa_pokok.Visible = True
        Me.sisa_pokok.VisibleIndex = 3
        '
        'lama_angs
        '
        Me.lama_angs.Caption = "Lama Angs."
        Me.lama_angs.DisplayFormat.FormatString = "n0"
        Me.lama_angs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lama_angs.FieldName = "lama_angs"
        Me.lama_angs.Name = "lama_angs"
        Me.lama_angs.OptionsColumn.ReadOnly = True
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "Sisa Angs."
        Me.sisa_angs.DisplayFormat.FormatString = "n0"
        Me.sisa_angs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.OptionsColumn.ReadOnly = True
        '
        'nilai
        '
        Me.nilai.Caption = "Recovery"
        Me.nilai.DisplayFormat.FormatString = "n0"
        Me.nilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nilai.FieldName = "nilai"
        Me.nilai.Name = "nilai"
        Me.nilai.Visible = True
        Me.nilai.VisibleIndex = 6
        '
        'sisa
        '
        Me.sisa.Caption = "Sisa"
        Me.sisa.DisplayFormat.FormatString = "n0"
        Me.sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa.FieldName = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.OptionsColumn.ReadOnly = True
        Me.sisa.Visible = True
        Me.sisa.VisibleIndex = 7
        '
        'angs_bunga
        '
        Me.angs_bunga.Caption = "Angs. Bunga"
        Me.angs_bunga.DisplayFormat.FormatString = "n0"
        Me.angs_bunga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.angs_bunga.FieldName = "jml_bunga"
        Me.angs_bunga.Name = "angs_bunga"
        Me.angs_bunga.OptionsColumn.ReadOnly = True
        Me.angs_bunga.Visible = True
        Me.angs_bunga.VisibleIndex = 5
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Angs. Pokok"
        Me.GridColumn3.DisplayFormat.FormatString = "n0"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "jml_pokok"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GCHistory
        '
        Me.GCHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHistory.Location = New System.Drawing.Point(0, 0)
        Me.GCHistory.MainView = Me.GVHistory
        Me.GCHistory.Name = "GCHistory"
        Me.GCHistory.Size = New System.Drawing.Size(616, 200)
        Me.GCHistory.TabIndex = 0
        Me.GCHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVHistory})
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(899, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENGAJUAN PERMOHONAN RECOVERY KREDIT (TOP UP)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 39)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1199, 532)
        Me.pnl.TabIndex = 158
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1199, 532)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1199, 463)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(583, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(616, 463)
        Me.Panel6.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GCKartu)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 200)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(616, 263)
        Me.Panel8.TabIndex = 2
        '
        'GCKartu
        '
        Me.GCKartu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCKartu.Location = New System.Drawing.Point(0, 0)
        Me.GCKartu.MainView = Me.GVKartu
        Me.GCKartu.Name = "GCKartu"
        Me.GCKartu.Size = New System.Drawing.Size(616, 263)
        Me.GCKartu.TabIndex = 1
        Me.GCKartu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVKartu})
        '
        'GVKartu
        '
        Me.GVKartu.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVKartu.Appearance.GroupPanel.Options.UseFont = True
        Me.GVKartu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn2, Me.GridColumn1, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.GVKartu.GridControl = Me.GCKartu
        Me.GVKartu.GroupPanelText = "TABEL ANGSURAN"
        Me.GVKartu.Name = "GVKartu"
        Me.GVKartu.OptionsView.ColumnAutoWidth = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "#"
        Me.GridColumn10.FieldName = "angs_ke"
        Me.GridColumn10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 30
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Bulan"
        Me.GridColumn2.FieldName = "c_bulan"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 40
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tahun"
        Me.GridColumn1.FieldName = "c_tahun"
        Me.GridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 40
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Pokok Pinjaman"
        Me.GridColumn11.DisplayFormat.FormatString = "n0"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "c_pokok_pinj"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 100
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Angs. Pokok"
        Me.GridColumn12.DisplayFormat.FormatString = "n0"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "c_pokok"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.GridColumn12.Width = 100
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Angs. Bunga"
        Me.GridColumn13.DisplayFormat.FormatString = "n0"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "c_bunga"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 100
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Total Angs."
        Me.GridColumn14.DisplayFormat.FormatString = "n0"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "c_angs"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        Me.GridColumn14.Width = 100
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Bonus"
        Me.GridColumn15.DisplayFormat.FormatString = "{0:#;;""""}"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "c_bns"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 7
        Me.GridColumn15.Width = 100
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "THR"
        Me.GridColumn16.DisplayFormat.FormatString = "{0:#;;""""}"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "c_thr"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 8
        Me.GridColumn16.Width = 100
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "TAT"
        Me.GridColumn17.DisplayFormat.FormatString = "{0:#;;""""}"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "c_tat"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 9
        Me.GridColumn17.Width = 100
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Saldo Pokok Pinjaman"
        Me.GridColumn18.DisplayFormat.FormatString = "n0"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "c_pokok_akhir"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 10
        Me.GridColumn18.Width = 100
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GCHistory)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(616, 200)
        Me.Panel7.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.bt_surat)
        Me.Panel5.Controls.Add(Me.bt_komite)
        Me.Panel5.Controls.Add(Me.bt_kartu)
        Me.Panel5.Controls.Add(Me.te_norek_debet2)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.cb_biaya_provisi)
        Me.Panel5.Controls.Add(Me.cb_jml_terima)
        Me.Panel5.Controls.Add(Me.cb_biaya_penalty)
        Me.Panel5.Controls.Add(Me.cb_angsuran_pokok)
        Me.Panel5.Controls.Add(Me.le_batas_admin)
        Me.Panel5.Controls.Add(Me.Label31)
        Me.Panel5.Controls.Add(Me.te_no_form)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.lb_line)
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.te_angsuran_total)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.te_bunga_berjalan)
        Me.Panel5.Controls.Add(Me.Label30)
        Me.Panel5.Controls.Add(Me.te_angsuran_bunga)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.te_biaya_penalty)
        Me.Panel5.Controls.Add(Me.lb_penalty)
        Me.Panel5.Controls.Add(Me.te_angsuran_pokok)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.te_total_recovery)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.te_pot_tat)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.te_pot_thr)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.te_pot_bonus)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.te_norek_debet)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.te_norek_cair)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.te_keterangan)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.te_bunga)
        Me.Panel5.Controls.Add(Me.te_biaya_admin)
        Me.Panel5.Controls.Add(Me.te_biaya_provisi)
        Me.Panel5.Controls.Add(Me.te_jml_terima)
        Me.Panel5.Controls.Add(Me.te_lama_pinjaman)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.te_jml_pinjaman)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lb_nasabah)
        Me.Panel5.Controls.Add(Me.le_nama)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(583, 463)
        Me.Panel5.TabIndex = 1
        '
        'bt_surat
        '
        Me.bt_surat.Location = New System.Drawing.Point(283, 437)
        Me.bt_surat.Name = "bt_surat"
        Me.bt_surat.Size = New System.Drawing.Size(120, 23)
        Me.bt_surat.TabIndex = 69
        Me.bt_surat.Text = "Surat Pernyataan"
        Me.bt_surat.UseVisualStyleBackColor = True
        '
        'bt_komite
        '
        Me.bt_komite.Location = New System.Drawing.Point(151, 437)
        Me.bt_komite.Name = "bt_komite"
        Me.bt_komite.Size = New System.Drawing.Size(120, 23)
        Me.bt_komite.TabIndex = 68
        Me.bt_komite.Text = "Lembar Komite"
        Me.bt_komite.UseVisualStyleBackColor = True
        '
        'bt_kartu
        '
        Me.bt_kartu.Location = New System.Drawing.Point(19, 437)
        Me.bt_kartu.Name = "bt_kartu"
        Me.bt_kartu.Size = New System.Drawing.Size(120, 23)
        Me.bt_kartu.TabIndex = 67
        Me.bt_kartu.Text = "Tabel Angsuran"
        Me.bt_kartu.UseVisualStyleBackColor = True
        '
        'te_norek_debet2
        '
        Me.te_norek_debet2.EditValue = ""
        Me.te_norek_debet2.Location = New System.Drawing.Point(430, 315)
        Me.te_norek_debet2.Name = "te_norek_debet2"
        Me.te_norek_debet2.Size = New System.Drawing.Size(117, 20)
        Me.te_norek_debet2.TabIndex = 65
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(314, 320)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(106, 15)
        Me.Label33.TabIndex = 64
        Me.Label33.Text = "Rekening Debet 2"
        '
        'cb_biaya_provisi
        '
        Me.cb_biaya_provisi.Location = New System.Drawing.Point(554, 97)
        Me.cb_biaya_provisi.Name = "cb_biaya_provisi"
        Me.cb_biaya_provisi.Properties.Caption = ""
        Me.cb_biaya_provisi.Size = New System.Drawing.Size(28, 19)
        Me.cb_biaya_provisi.TabIndex = 63
        Me.cb_biaya_provisi.Visible = False
        '
        'cb_jml_terima
        '
        Me.cb_jml_terima.Location = New System.Drawing.Point(275, 125)
        Me.cb_jml_terima.Name = "cb_jml_terima"
        Me.cb_jml_terima.Properties.Caption = ""
        Me.cb_jml_terima.Size = New System.Drawing.Size(28, 19)
        Me.cb_jml_terima.TabIndex = 62
        '
        'cb_biaya_penalty
        '
        Me.cb_biaya_penalty.Location = New System.Drawing.Point(275, 375)
        Me.cb_biaya_penalty.Name = "cb_biaya_penalty"
        Me.cb_biaya_penalty.Properties.Caption = ""
        Me.cb_biaya_penalty.Size = New System.Drawing.Size(28, 19)
        Me.cb_biaya_penalty.TabIndex = 61
        Me.cb_biaya_penalty.Visible = False
        '
        'cb_angsuran_pokok
        '
        Me.cb_angsuran_pokok.Location = New System.Drawing.Point(554, 345)
        Me.cb_angsuran_pokok.Name = "cb_angsuran_pokok"
        Me.cb_angsuran_pokok.Properties.Caption = ""
        Me.cb_angsuran_pokok.Size = New System.Drawing.Size(28, 19)
        Me.cb_angsuran_pokok.TabIndex = 60
        Me.cb_angsuran_pokok.Visible = False
        '
        'le_batas_admin
        '
        Me.le_batas_admin.Location = New System.Drawing.Point(430, 68)
        Me.le_batas_admin.Name = "le_batas_admin"
        Me.le_batas_admin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.le_batas_admin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("batas", "Nilai", 10, DevExpress.Utils.FormatType.Numeric, "n0", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.le_batas_admin.Properties.DisplayFormat.FormatString = "n0"
        Me.le_batas_admin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.le_batas_admin.Properties.DisplayMember = "batas"
        Me.le_batas_admin.Properties.NullText = ""
        Me.le_batas_admin.Properties.ValueMember = "batas"
        Me.le_batas_admin.Size = New System.Drawing.Size(117, 20)
        Me.le_batas_admin.TabIndex = 59
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(314, 70)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 15)
        Me.Label31.TabIndex = 58
        Me.Label31.Text = "Batas Admin"
        '
        'te_no_form
        '
        Me.te_no_form.EditValue = ""
        Me.te_no_form.Location = New System.Drawing.Point(428, 8)
        Me.te_no_form.Name = "te_no_form"
        Me.te_no_form.Properties.Appearance.Options.UseTextOptions = True
        Me.te_no_form.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_no_form.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_no_form.Size = New System.Drawing.Size(117, 20)
        Me.te_no_form.TabIndex = 57
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(314, 13)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 15)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "No. Form"
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Location = New System.Drawing.Point(12, 61)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(560, 2)
        Me.Label34.TabIndex = 55
        '
        'lb_line
        '
        Me.lb_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_line.Location = New System.Drawing.Point(12, 243)
        Me.lb_line.Name = "lb_line"
        Me.lb_line.Size = New System.Drawing.Size(560, 2)
        Me.lb_line.TabIndex = 53
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(314, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(58, 15)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Total Pot."
        Me.Label32.Visible = False
        '
        'te_angsuran_total
        '
        Me.te_angsuran_total.EditValue = "0"
        Me.te_angsuran_total.Location = New System.Drawing.Point(430, 403)
        Me.te_angsuran_total.Name = "te_angsuran_total"
        Me.te_angsuran_total.Properties.Appearance.Options.UseTextOptions = True
        Me.te_angsuran_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_angsuran_total.Properties.DisplayFormat.FormatString = "n2"
        Me.te_angsuran_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_total.Properties.EditFormat.FormatString = "n2"
        Me.te_angsuran_total.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_total.Properties.Mask.EditMask = "n2"
        Me.te_angsuran_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_angsuran_total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_angsuran_total.Size = New System.Drawing.Size(117, 20)
        Me.te_angsuran_total.TabIndex = 50
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(314, 407)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 15)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "Total Angsuran"
        '
        'te_bunga_berjalan
        '
        Me.te_bunga_berjalan.EditValue = "0"
        Me.te_bunga_berjalan.Location = New System.Drawing.Point(152, 403)
        Me.te_bunga_berjalan.Name = "te_bunga_berjalan"
        Me.te_bunga_berjalan.Properties.Appearance.Options.UseTextOptions = True
        Me.te_bunga_berjalan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_bunga_berjalan.Properties.DisplayFormat.FormatString = "n2"
        Me.te_bunga_berjalan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga_berjalan.Properties.EditFormat.FormatString = "n2"
        Me.te_bunga_berjalan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga_berjalan.Properties.Mask.EditMask = "n2"
        Me.te_bunga_berjalan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_bunga_berjalan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_bunga_berjalan.Properties.ReadOnly = True
        Me.te_bunga_berjalan.Size = New System.Drawing.Size(117, 20)
        Me.te_bunga_berjalan.TabIndex = 48
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 407)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 15)
        Me.Label30.TabIndex = 47
        Me.Label30.Text = "Bunga Berjalan"
        '
        'te_angsuran_bunga
        '
        Me.te_angsuran_bunga.EditValue = "0"
        Me.te_angsuran_bunga.Location = New System.Drawing.Point(430, 374)
        Me.te_angsuran_bunga.Name = "te_angsuran_bunga"
        Me.te_angsuran_bunga.Properties.Appearance.Options.UseTextOptions = True
        Me.te_angsuran_bunga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_angsuran_bunga.Properties.DisplayFormat.FormatString = "n2"
        Me.te_angsuran_bunga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_bunga.Properties.EditFormat.FormatString = "n2"
        Me.te_angsuran_bunga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_bunga.Properties.Mask.EditMask = "n2"
        Me.te_angsuran_bunga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_angsuran_bunga.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_angsuran_bunga.Properties.ReadOnly = True
        Me.te_angsuran_bunga.Size = New System.Drawing.Size(117, 20)
        Me.te_angsuran_bunga.TabIndex = 46
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(314, 378)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 15)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Angsuran Bunga"
        '
        'te_biaya_penalty
        '
        Me.te_biaya_penalty.EditValue = "0"
        Me.te_biaya_penalty.Location = New System.Drawing.Point(152, 374)
        Me.te_biaya_penalty.Name = "te_biaya_penalty"
        Me.te_biaya_penalty.Properties.Appearance.Options.UseTextOptions = True
        Me.te_biaya_penalty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_biaya_penalty.Properties.DisplayFormat.FormatString = "n2"
        Me.te_biaya_penalty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_penalty.Properties.EditFormat.FormatString = "n2"
        Me.te_biaya_penalty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_penalty.Properties.Mask.EditMask = "n2"
        Me.te_biaya_penalty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_biaya_penalty.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_biaya_penalty.Properties.ReadOnly = True
        Me.te_biaya_penalty.Size = New System.Drawing.Size(117, 20)
        Me.te_biaya_penalty.TabIndex = 44
        '
        'lb_penalty
        '
        Me.lb_penalty.AutoSize = True
        Me.lb_penalty.Location = New System.Drawing.Point(16, 378)
        Me.lb_penalty.Name = "lb_penalty"
        Me.lb_penalty.Size = New System.Drawing.Size(80, 15)
        Me.lb_penalty.TabIndex = 43
        Me.lb_penalty.Text = "Biaya Penalty"
        '
        'te_angsuran_pokok
        '
        Me.te_angsuran_pokok.EditValue = "0"
        Me.te_angsuran_pokok.Location = New System.Drawing.Point(430, 344)
        Me.te_angsuran_pokok.Name = "te_angsuran_pokok"
        Me.te_angsuran_pokok.Properties.Appearance.Options.UseTextOptions = True
        Me.te_angsuran_pokok.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_angsuran_pokok.Properties.DisplayFormat.FormatString = "n2"
        Me.te_angsuran_pokok.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_pokok.Properties.EditFormat.FormatString = "n2"
        Me.te_angsuran_pokok.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_angsuran_pokok.Properties.Mask.EditMask = "n2"
        Me.te_angsuran_pokok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_angsuran_pokok.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_angsuran_pokok.Size = New System.Drawing.Size(117, 20)
        Me.te_angsuran_pokok.TabIndex = 42
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(314, 348)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 15)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Angsuran Pokok"
        '
        'te_total_recovery
        '
        Me.te_total_recovery.EditValue = "0"
        Me.te_total_recovery.Location = New System.Drawing.Point(152, 344)
        Me.te_total_recovery.Name = "te_total_recovery"
        Me.te_total_recovery.Properties.Appearance.Options.UseTextOptions = True
        Me.te_total_recovery.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_total_recovery.Properties.DisplayFormat.FormatString = "n2"
        Me.te_total_recovery.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_total_recovery.Properties.EditFormat.FormatString = "n2"
        Me.te_total_recovery.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_total_recovery.Properties.Mask.EditMask = "n2"
        Me.te_total_recovery.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_total_recovery.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_total_recovery.Properties.ReadOnly = True
        Me.te_total_recovery.Size = New System.Drawing.Size(117, 20)
        Me.te_total_recovery.TabIndex = 40
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 348)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 15)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Total Recovery"
        '
        'te_pot_tat
        '
        Me.te_pot_tat.EditValue = "0"
        Me.te_pot_tat.Location = New System.Drawing.Point(152, 212)
        Me.te_pot_tat.Name = "te_pot_tat"
        Me.te_pot_tat.Properties.Appearance.Options.UseTextOptions = True
        Me.te_pot_tat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_pot_tat.Properties.DisplayFormat.FormatString = "n2"
        Me.te_pot_tat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_tat.Properties.EditFormat.FormatString = "n2"
        Me.te_pot_tat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_tat.Properties.Mask.EditMask = "n2"
        Me.te_pot_tat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_pot_tat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_pot_tat.Size = New System.Drawing.Size(117, 20)
        Me.te_pot_tat.TabIndex = 38
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 217)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "- Pot. TAT"
        '
        'te_pot_thr
        '
        Me.te_pot_thr.EditValue = "0"
        Me.te_pot_thr.Location = New System.Drawing.Point(152, 185)
        Me.te_pot_thr.Name = "te_pot_thr"
        Me.te_pot_thr.Properties.Appearance.Options.UseTextOptions = True
        Me.te_pot_thr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_pot_thr.Properties.DisplayFormat.FormatString = "n2"
        Me.te_pot_thr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_thr.Properties.EditFormat.FormatString = "n2"
        Me.te_pot_thr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_thr.Properties.Mask.EditMask = "n2"
        Me.te_pot_thr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_pot_thr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_pot_thr.Size = New System.Drawing.Size(117, 20)
        Me.te_pot_thr.TabIndex = 36
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 188)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 15)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "- Pot. THR"
        '
        'te_pot_bonus
        '
        Me.te_pot_bonus.EditValue = "0"
        Me.te_pot_bonus.Location = New System.Drawing.Point(152, 157)
        Me.te_pot_bonus.Name = "te_pot_bonus"
        Me.te_pot_bonus.Properties.Appearance.Options.UseTextOptions = True
        Me.te_pot_bonus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_pot_bonus.Properties.DisplayFormat.FormatString = "n2"
        Me.te_pot_bonus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_bonus.Properties.EditFormat.FormatString = "n2"
        Me.te_pot_bonus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pot_bonus.Properties.Mask.EditMask = "n2"
        Me.te_pot_bonus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_pot_bonus.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_pot_bonus.Size = New System.Drawing.Size(118, 20)
        Me.te_pot_bonus.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 15)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "- Pot. Bonus April"
        '
        'te_norek_debet
        '
        Me.te_norek_debet.EditValue = ""
        Me.te_norek_debet.Location = New System.Drawing.Point(152, 315)
        Me.te_norek_debet.Name = "te_norek_debet"
        Me.te_norek_debet.Size = New System.Drawing.Size(117, 20)
        Me.te_norek_debet.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 320)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 15)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Rekening Debet 1"
        '
        'te_norek_cair
        '
        Me.te_norek_cair.EditValue = ""
        Me.te_norek_cair.Location = New System.Drawing.Point(152, 285)
        Me.te_norek_cair.Name = "te_norek_cair"
        Me.te_norek_cair.Size = New System.Drawing.Size(117, 20)
        Me.te_norek_cair.TabIndex = 30
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 15)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Rekening Pencairan"
        '
        'te_keterangan
        '
        Me.te_keterangan.EditValue = ""
        Me.te_keterangan.Location = New System.Drawing.Point(152, 255)
        Me.te_keterangan.Name = "te_keterangan"
        Me.te_keterangan.Size = New System.Drawing.Size(395, 20)
        Me.te_keterangan.TabIndex = 28
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 260)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Keterangan"
        '
        'te_bunga
        '
        Me.te_bunga.EditValue = "0"
        Me.te_bunga.Location = New System.Drawing.Point(430, 157)
        Me.te_bunga.Name = "te_bunga"
        Me.te_bunga.Properties.Appearance.Options.UseTextOptions = True
        Me.te_bunga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_bunga.Properties.DisplayFormat.FormatString = "n2"
        Me.te_bunga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga.Properties.EditFormat.FormatString = "n2"
        Me.te_bunga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga.Properties.Mask.EditMask = "n2"
        Me.te_bunga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_bunga.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_bunga.Size = New System.Drawing.Size(117, 20)
        Me.te_bunga.TabIndex = 26
        '
        'te_biaya_admin
        '
        Me.te_biaya_admin.EditValue = "0"
        Me.te_biaya_admin.Location = New System.Drawing.Point(430, 125)
        Me.te_biaya_admin.Name = "te_biaya_admin"
        Me.te_biaya_admin.Properties.Appearance.Options.UseTextOptions = True
        Me.te_biaya_admin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_biaya_admin.Properties.DisplayFormat.FormatString = "n2"
        Me.te_biaya_admin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_admin.Properties.EditFormat.FormatString = "n2"
        Me.te_biaya_admin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_admin.Properties.Mask.EditMask = "n2"
        Me.te_biaya_admin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_biaya_admin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_biaya_admin.Properties.ReadOnly = True
        Me.te_biaya_admin.Size = New System.Drawing.Size(117, 20)
        Me.te_biaya_admin.TabIndex = 25
        '
        'te_biaya_provisi
        '
        Me.te_biaya_provisi.EditValue = "0"
        Me.te_biaya_provisi.Location = New System.Drawing.Point(430, 96)
        Me.te_biaya_provisi.Name = "te_biaya_provisi"
        Me.te_biaya_provisi.Properties.Appearance.Options.UseTextOptions = True
        Me.te_biaya_provisi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_biaya_provisi.Properties.DisplayFormat.FormatString = "n2"
        Me.te_biaya_provisi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_provisi.Properties.EditFormat.FormatString = "n2"
        Me.te_biaya_provisi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_biaya_provisi.Properties.Mask.EditMask = "n2"
        Me.te_biaya_provisi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_biaya_provisi.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_biaya_provisi.Size = New System.Drawing.Size(117, 20)
        Me.te_biaya_provisi.TabIndex = 24
        '
        'te_jml_terima
        '
        Me.te_jml_terima.EditValue = "0"
        Me.te_jml_terima.Location = New System.Drawing.Point(152, 125)
        Me.te_jml_terima.Name = "te_jml_terima"
        Me.te_jml_terima.Properties.Appearance.Options.UseTextOptions = True
        Me.te_jml_terima.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_jml_terima.Properties.DisplayFormat.FormatString = "n2"
        Me.te_jml_terima.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jml_terima.Properties.EditFormat.FormatString = "n2"
        Me.te_jml_terima.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jml_terima.Properties.Mask.EditMask = "n2"
        Me.te_jml_terima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_jml_terima.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_jml_terima.Size = New System.Drawing.Size(117, 20)
        Me.te_jml_terima.TabIndex = 23
        '
        'te_lama_pinjaman
        '
        Me.te_lama_pinjaman.EditValue = "0"
        Me.te_lama_pinjaman.Location = New System.Drawing.Point(152, 96)
        Me.te_lama_pinjaman.Name = "te_lama_pinjaman"
        Me.te_lama_pinjaman.Properties.Appearance.Options.UseTextOptions = True
        Me.te_lama_pinjaman.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_lama_pinjaman.Properties.DisplayFormat.FormatString = "n0"
        Me.te_lama_pinjaman.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_lama_pinjaman.Properties.EditFormat.FormatString = "n0"
        Me.te_lama_pinjaman.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_lama_pinjaman.Properties.Mask.EditMask = "n0"
        Me.te_lama_pinjaman.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_lama_pinjaman.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_lama_pinjaman.Size = New System.Drawing.Size(117, 20)
        Me.te_lama_pinjaman.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(314, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 15)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Bunga (%)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(314, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 15)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Biaya Admin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(314, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Biaya Provisi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Jumlah Terima"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Lama Pinjaman"
        '
        'te_jml_pinjaman
        '
        Me.te_jml_pinjaman.EditValue = "0"
        Me.te_jml_pinjaman.Location = New System.Drawing.Point(152, 67)
        Me.te_jml_pinjaman.Name = "te_jml_pinjaman"
        Me.te_jml_pinjaman.Properties.Appearance.Options.UseTextOptions = True
        Me.te_jml_pinjaman.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_jml_pinjaman.Properties.DisplayFormat.FormatString = "n2"
        Me.te_jml_pinjaman.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jml_pinjaman.Properties.EditFormat.FormatString = "n2"
        Me.te_jml_pinjaman.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jml_pinjaman.Properties.Mask.EditMask = "n2"
        Me.te_jml_pinjaman.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_jml_pinjaman.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_jml_pinjaman.Size = New System.Drawing.Size(117, 20)
        Me.te_jml_pinjaman.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Jumlah Pinjaman"
        '
        'lb_nasabah
        '
        Me.lb_nasabah.Location = New System.Drawing.Point(13, 33)
        Me.lb_nasabah.Name = "lb_nasabah"
        Me.lb_nasabah.Size = New System.Drawing.Size(532, 15)
        Me.lb_nasabah.TabIndex = 9
        Me.lb_nasabah.Text = "..."
        '
        'le_nama
        '
        Me.le_nama.Location = New System.Drawing.Point(152, 8)
        Me.le_nama.Name = "le_nama"
        Me.le_nama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.le_nama.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nasabah_id", "NIP"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.le_nama.Properties.NullText = ""
        Me.le_nama.Size = New System.Drawing.Size(118, 20)
        Me.le_nama.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "NIP"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lb_denda)
        Me.Panel3.Controls.Add(Me.lb_provisi)
        Me.Panel3.Controls.Add(Me.lb_bunga)
        Me.Panel3.Controls.Add(Me.lb_no_trans)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lb_admin)
        Me.Panel3.Controls.Add(Me.lb_plafond)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.le_tipe_kredit)
        Me.Panel3.Controls.Add(Me.le_jenis_kredit)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dt_tanggal_debet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dt_tanggal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1199, 69)
        Me.Panel3.TabIndex = 0
        '
        'lb_denda
        '
        Me.lb_denda.AutoSize = True
        Me.lb_denda.Location = New System.Drawing.Point(814, 50)
        Me.lb_denda.Name = "lb_denda"
        Me.lb_denda.Size = New System.Drawing.Size(39, 13)
        Me.lb_denda.TabIndex = 21
        Me.lb_denda.Text = "00,00"
        '
        'lb_provisi
        '
        Me.lb_provisi.AutoSize = True
        Me.lb_provisi.Location = New System.Drawing.Point(814, 28)
        Me.lb_provisi.Name = "lb_provisi"
        Me.lb_provisi.Size = New System.Drawing.Size(39, 13)
        Me.lb_provisi.TabIndex = 20
        Me.lb_provisi.Text = "00,00"
        '
        'lb_bunga
        '
        Me.lb_bunga.AutoSize = True
        Me.lb_bunga.Location = New System.Drawing.Point(814, 6)
        Me.lb_bunga.Name = "lb_bunga"
        Me.lb_bunga.Size = New System.Drawing.Size(39, 13)
        Me.lb_bunga.TabIndex = 19
        Me.lb_bunga.Text = "00,00"
        '
        'lb_no_trans
        '
        Me.lb_no_trans.Location = New System.Drawing.Point(1034, 50)
        Me.lb_no_trans.Name = "lb_no_trans"
        Me.lb_no_trans.Size = New System.Drawing.Size(128, 15)
        Me.lb_no_trans.TabIndex = 18
        Me.lb_no_trans.Text = "NR0TRH0001"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(868, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "No. Transaksi"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(724, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Bunga (%)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(725, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Denda (%)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(725, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Provisi (%)"
        '
        'lb_admin
        '
        Me.lb_admin.Location = New System.Drawing.Point(1034, 28)
        Me.lb_admin.Name = "lb_admin"
        Me.lb_admin.Size = New System.Drawing.Size(128, 15)
        Me.lb_admin.TabIndex = 13
        Me.lb_admin.Text = "Rp. 200.000"
        '
        'lb_plafond
        '
        Me.lb_plafond.Location = New System.Drawing.Point(1034, 6)
        Me.lb_plafond.Name = "lb_plafond"
        Me.lb_plafond.Size = New System.Drawing.Size(128, 15)
        Me.lb_plafond.TabIndex = 12
        Me.lb_plafond.Text = "Rp. 500.000.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(868, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Administrasi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(868, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Plafond"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipe Kredit"
        '
        'le_tipe_kredit
        '
        Me.le_tipe_kredit.Location = New System.Drawing.Point(529, 43)
        Me.le_tipe_kredit.Name = "le_tipe_kredit"
        Me.le_tipe_kredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.le_tipe_kredit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Tipe")})
        Me.le_tipe_kredit.Properties.NullText = ""
        Me.le_tipe_kredit.Size = New System.Drawing.Size(175, 20)
        Me.le_tipe_kredit.TabIndex = 8
        '
        'le_jenis_kredit
        '
        Me.le_jenis_kredit.Location = New System.Drawing.Point(152, 43)
        Me.le_jenis_kredit.Name = "le_jenis_kredit"
        Me.le_jenis_kredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.le_jenis_kredit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Jenis Kredit")})
        Me.le_jenis_kredit.Properties.NullText = ""
        Me.le_jenis_kredit.Size = New System.Drawing.Size(175, 20)
        Me.le_jenis_kredit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal Debet Berikutnya"
        '
        'dt_tanggal_debet
        '
        Me.dt_tanggal_debet.EditValue = Nothing
        Me.dt_tanggal_debet.Location = New System.Drawing.Point(529, 5)
        Me.dt_tanggal_debet.Name = "dt_tanggal_debet"
        Me.dt_tanggal_debet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_tanggal_debet.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dt_tanggal_debet.Size = New System.Drawing.Size(175, 20)
        Me.dt_tanggal_debet.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jenis Kredit"
        '
        'dt_tanggal
        '
        Me.dt_tanggal.EditValue = Nothing
        Me.dt_tanggal.Location = New System.Drawing.Point(152, 5)
        Me.dt_tanggal.Name = "dt_tanggal"
        Me.dt_tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dt_tanggal.Size = New System.Drawing.Size(175, 20)
        Me.dt_tanggal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Pengajuan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1199, 39)
        Me.Panel1.TabIndex = 157
        '
        'frm_Kredit_Rec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 571)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_Kredit_Rec"
        Me.Text = "frmKreditREC"
        CType(Me.GVHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GCKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.te_norek_debet2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_biaya_provisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_jml_terima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_biaya_penalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_angsuran_pokok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.le_batas_admin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_no_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_angsuran_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_bunga_berjalan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_angsuran_bunga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_biaya_penalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_angsuran_pokok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_total_recovery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_pot_tat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_pot_thr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_pot_bonus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_norek_debet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_norek_cair.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_bunga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_biaya_admin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_biaya_provisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_jml_terima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_lama_pinjaman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_jml_pinjaman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.le_nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.le_tipe_kredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.le_jenis_kredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tanggal_debet.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tanggal_debet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GCKartu As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVKartu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GCHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_tanggal_debet As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents le_tipe_kredit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents le_jenis_kredit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb_admin As System.Windows.Forms.Label
    Friend WithEvents lb_plafond As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lb_bunga As System.Windows.Forms.Label
    Friend WithEvents lb_no_trans As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lb_denda As System.Windows.Forms.Label
    Friend WithEvents lb_provisi As System.Windows.Forms.Label
    Friend WithEvents le_nama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lb_nasabah As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents te_jml_pinjaman As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents te_bunga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents te_biaya_admin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents te_biaya_provisi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents te_jml_terima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents te_lama_pinjaman As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents te_keterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents te_norek_debet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents te_norek_cair As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents te_pot_thr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents te_pot_bonus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents te_pot_tat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents te_angsuran_pokok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents te_total_recovery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents te_angsuran_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents te_bunga_berjalan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents te_angsuran_bunga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents te_biaya_penalty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lb_penalty As System.Windows.Forms.Label
    Friend WithEvents lb_line As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_pinjaman As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lama_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents te_no_form As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents le_batas_admin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cb_jml_terima As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_biaya_penalty As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_angsuran_pokok As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_biaya_provisi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents te_norek_debet2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents angs_bunga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bt_kartu As System.Windows.Forms.Button
    Friend WithEvents bt_surat As System.Windows.Forms.Button
    Friend WithEvents bt_komite As System.Windows.Forms.Button
End Class
