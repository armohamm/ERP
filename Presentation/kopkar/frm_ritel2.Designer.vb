<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ritel2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ritel2))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GcHist = New DevExpress.XtraGrid.GridControl
        Me.Gv_hist = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JML_PINJAMAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.v_sisa_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAMA_ANGS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa_angs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gv_nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_pokok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_bunga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.tx_nama_supp = New System.Windows.Forms.TextBox
        Me.lb_nama_supp = New System.Windows.Forms.Label
        Me.btnTopUp = New System.Windows.Forms.Button
        Me.lb_line = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lb_notrans = New System.Windows.Forms.Label
        Me.te_bunga = New DevExpress.XtraEditors.TextEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.te_pokok = New DevExpress.XtraEditors.TextEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lb_sld_awal = New System.Windows.Forms.Label
        Me.Jenis_Bayar = New DevExpress.XtraEditors.LookUpEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.Lue_member = New DevExpress.XtraEditors.LookUpEdit
        Me.TE_Fee = New DevExpress.XtraEditors.TextEdit
        Me.lb_fee = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Lue_Brg = New DevExpress.XtraEditors.LookUpEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.Lue_Jns_brg = New DevExpress.XtraEditors.LookUpEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.tx1_LamaPJM = New System.Windows.Forms.TextBox
        Me.cb_bg = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lb_bg = New System.Windows.Forms.Label
        Me.Lue_SetPjm = New DevExpress.XtraEditors.LookUpEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.de_tgl = New DevExpress.XtraEditors.DateEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txb_bank = New System.Windows.Forms.TextBox
        Me.txb_norek = New System.Windows.Forms.TextBox
        Me.TE_BsrPJM1 = New DevExpress.XtraEditors.TextEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lb_dinas = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_nama = New System.Windows.Forms.Label
        Me.LUE_nama = New DevExpress.XtraEditors.LookUpEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.tx1_ket = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lb_denda = New System.Windows.Forms.Label
        Me.lb_prvs = New System.Windows.Forms.Label
        Me.lb_admin = New System.Windows.Forms.Label
        Me.lb_bunga = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.tx_nama_brg = New System.Windows.Forms.TextBox
        Me.lb_nama_brg = New System.Windows.Forms.Label
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GcHist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv_hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.te_bunga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_pokok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jenis_Bayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_member.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_Fee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_Brg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_Jns_brg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_tgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_BsrPJM1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Olive
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(600, 357)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(477, 162)
        Me.Panel4.TabIndex = 5
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "profile-photo.jpg")
        Me.ImageCollection1.Images.SetKeyName(1, "profile-photo.jpg")
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 52)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1077, 519)
        Me.pnl.TabIndex = 160
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.GcHist)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(600, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(477, 357)
        Me.Panel6.TabIndex = 3
        '
        'GcHist
        '
        Me.GcHist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcHist.Location = New System.Drawing.Point(0, 0)
        Me.GcHist.MainView = Me.Gv_hist
        Me.GcHist.Name = "GcHist"
        Me.GcHist.Size = New System.Drawing.Size(477, 357)
        Me.GcHist.TabIndex = 12
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
        Me.Gv_hist.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tgl_trans, Me.JML_PINJAMAN, Me.v_sisa_pokok, Me.LAMA_ANGS, Me.sisa_angs, Me.no_trans, Me.gv_nasabah_id, Me.jenis, Me.gc_pokok, Me.gc_bunga})
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
        Me.Gv_hist.ViewCaption = "Sisa Tanggungan Kredit belum LUNAS"
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
        Me.tgl_trans.Width = 64
        '
        'JML_PINJAMAN
        '
        Me.JML_PINJAMAN.Caption = "Jml Pinjaman"
        Me.JML_PINJAMAN.DisplayFormat.FormatString = "{0:n2}"
        Me.JML_PINJAMAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.JML_PINJAMAN.FieldName = "JML_PINJAMAN"
        Me.JML_PINJAMAN.Name = "JML_PINJAMAN"
        Me.JML_PINJAMAN.OptionsColumn.AllowEdit = False
        Me.JML_PINJAMAN.OptionsColumn.ReadOnly = True
        Me.JML_PINJAMAN.SummaryItem.DisplayFormat = "{0:n2}"
        Me.JML_PINJAMAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.JML_PINJAMAN.Visible = True
        Me.JML_PINJAMAN.VisibleIndex = 2
        Me.JML_PINJAMAN.Width = 73
        '
        'v_sisa_pokok
        '
        Me.v_sisa_pokok.Caption = "Sisa Pokok"
        Me.v_sisa_pokok.DisplayFormat.FormatString = "{0:n2}"
        Me.v_sisa_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.v_sisa_pokok.FieldName = "sisa_pokok"
        Me.v_sisa_pokok.Name = "v_sisa_pokok"
        Me.v_sisa_pokok.SummaryItem.DisplayFormat = "{0:n2}"
        Me.v_sisa_pokok.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.v_sisa_pokok.Visible = True
        Me.v_sisa_pokok.VisibleIndex = 6
        Me.v_sisa_pokok.Width = 74
        '
        'LAMA_ANGS
        '
        Me.LAMA_ANGS.Caption = "Lama Angsuran"
        Me.LAMA_ANGS.FieldName = "LAMA_ANGS"
        Me.LAMA_ANGS.Name = "LAMA_ANGS"
        Me.LAMA_ANGS.Width = 41
        '
        'sisa_angs
        '
        Me.sisa_angs.Caption = "Sisa Angsuran"
        Me.sisa_angs.FieldName = "sisa_angs"
        Me.sisa_angs.Name = "sisa_angs"
        Me.sisa_angs.Visible = True
        Me.sisa_angs.VisibleIndex = 5
        Me.sisa_angs.Width = 43
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Pengajuan"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Width = 68
        '
        'gv_nasabah_id
        '
        Me.gv_nasabah_id.Caption = "NIP"
        Me.gv_nasabah_id.FieldName = "nasabah_id"
        Me.gv_nasabah_id.Name = "gv_nasabah_id"
        Me.gv_nasabah_id.Width = 29
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 1
        Me.jenis.Width = 48
        '
        'gc_pokok
        '
        Me.gc_pokok.Caption = "Pokok"
        Me.gc_pokok.DisplayFormat.FormatString = "n0"
        Me.gc_pokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_pokok.FieldName = "JML_POKOK"
        Me.gc_pokok.Name = "gc_pokok"
        Me.gc_pokok.Visible = True
        Me.gc_pokok.VisibleIndex = 3
        Me.gc_pokok.Width = 69
        '
        'gc_bunga
        '
        Me.gc_bunga.Caption = "Bunga"
        Me.gc_bunga.DisplayFormat.FormatString = "n0"
        Me.gc_bunga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_bunga.FieldName = "JML_BUNGA"
        Me.gc_bunga.Name = "gc_bunga"
        Me.gc_bunga.Visible = True
        Me.gc_bunga.VisibleIndex = 4
        Me.gc_bunga.Width = 58
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GcHist
        Me.GridView4.Name = "GridView4"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel5.Controls.Add(Me.tx_nama_brg)
        Me.Panel5.Controls.Add(Me.lb_nama_brg)
        Me.Panel5.Controls.Add(Me.tx_nama)
        Me.Panel5.Controls.Add(Me.tx_nama_supp)
        Me.Panel5.Controls.Add(Me.lb_nama_supp)
        Me.Panel5.Controls.Add(Me.btnTopUp)
        Me.Panel5.Controls.Add(Me.lb_line)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.lb_notrans)
        Me.Panel5.Controls.Add(Me.te_bunga)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.te_pokok)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.lb_sld_awal)
        Me.Panel5.Controls.Add(Me.Jenis_Bayar)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Lue_member)
        Me.Panel5.Controls.Add(Me.TE_Fee)
        Me.Panel5.Controls.Add(Me.lb_fee)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Lue_Brg)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Lue_Jns_brg)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.tx1_LamaPJM)
        Me.Panel5.Controls.Add(Me.cb_bg)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.lb_bg)
        Me.Panel5.Controls.Add(Me.Lue_SetPjm)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.de_tgl)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label41)
        Me.Panel5.Controls.Add(Me.txb_bank)
        Me.Panel5.Controls.Add(Me.txb_norek)
        Me.Panel5.Controls.Add(Me.TE_BsrPJM1)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lb_dinas)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lb_nama)
        Me.Panel5.Controls.Add(Me.LUE_nama)
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.tx1_ket)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(600, 519)
        Me.Panel5.TabIndex = 2
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(135, 111)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(150, 20)
        Me.tx_nama.TabIndex = 367
        '
        'tx_nama_supp
        '
        Me.tx_nama_supp.Location = New System.Drawing.Point(421, 250)
        Me.tx_nama_supp.Name = "tx_nama_supp"
        Me.tx_nama_supp.Size = New System.Drawing.Size(150, 20)
        Me.tx_nama_supp.TabIndex = 366
        Me.tx_nama_supp.Visible = False
        '
        'lb_nama_supp
        '
        Me.lb_nama_supp.AutoSize = True
        Me.lb_nama_supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama_supp.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama_supp.Location = New System.Drawing.Point(307, 254)
        Me.lb_nama_supp.Name = "lb_nama_supp"
        Me.lb_nama_supp.Size = New System.Drawing.Size(89, 13)
        Me.lb_nama_supp.TabIndex = 365
        Me.lb_nama_supp.Text = "Nama Supplier"
        Me.lb_nama_supp.Visible = False
        '
        'btnTopUp
        '
        Me.btnTopUp.Location = New System.Drawing.Point(24, 472)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(75, 23)
        Me.btnTopUp.TabIndex = 364
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = True
        '
        'lb_line
        '
        Me.lb_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_line.Location = New System.Drawing.Point(21, 177)
        Me.lb_line.Name = "lb_line"
        Me.lb_line.Size = New System.Drawing.Size(560, 2)
        Me.lb_line.TabIndex = 363
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(306, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 362
        Me.Label5.Text = "No. Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(18, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 361
        Me.Label2.Text = "Jenis Kredit"
        '
        'lb_notrans
        '
        Me.lb_notrans.AutoSize = True
        Me.lb_notrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_notrans.ForeColor = System.Drawing.Color.Gold
        Me.lb_notrans.Location = New System.Drawing.Point(421, 18)
        Me.lb_notrans.Name = "lb_notrans"
        Me.lb_notrans.Size = New System.Drawing.Size(21, 13)
        Me.lb_notrans.TabIndex = 360
        Me.lb_notrans.Text = "<>"
        '
        'te_bunga
        '
        Me.te_bunga.EditValue = "0"
        Me.te_bunga.Location = New System.Drawing.Point(421, 365)
        Me.te_bunga.Name = "te_bunga"
        Me.te_bunga.Properties.Appearance.Options.UseTextOptions = True
        Me.te_bunga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_bunga.Properties.DisplayFormat.FormatString = "n0"
        Me.te_bunga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga.Properties.EditFormat.FormatString = "n0"
        Me.te_bunga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_bunga.Properties.Mask.EditMask = "n0"
        Me.te_bunga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_bunga.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_bunga.Properties.ReadOnly = True
        Me.te_bunga.Size = New System.Drawing.Size(150, 20)
        Me.te_bunga.TabIndex = 359
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Gold
        Me.Label28.Location = New System.Drawing.Point(321, 369)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 358
        Me.Label28.Text = "Bunga"
        '
        'te_pokok
        '
        Me.te_pokok.EditValue = "0"
        Me.te_pokok.Location = New System.Drawing.Point(421, 336)
        Me.te_pokok.Name = "te_pokok"
        Me.te_pokok.Properties.Appearance.Options.UseTextOptions = True
        Me.te_pokok.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_pokok.Properties.DisplayFormat.FormatString = "n0"
        Me.te_pokok.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pokok.Properties.EditFormat.FormatString = "n0"
        Me.te_pokok.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_pokok.Properties.Mask.EditMask = "n0"
        Me.te_pokok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_pokok.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.te_pokok.Properties.ReadOnly = True
        Me.te_pokok.Size = New System.Drawing.Size(150, 20)
        Me.te_pokok.TabIndex = 357
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Gold
        Me.Label26.Location = New System.Drawing.Point(306, 340)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 356
        Me.Label26.Text = "Pokok"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label23.Location = New System.Drawing.Point(18, 283)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 15)
        Me.Label23.TabIndex = 351
        Me.Label23.Text = "Saldo Awal"
        '
        'lb_sld_awal
        '
        Me.lb_sld_awal.AutoSize = True
        Me.lb_sld_awal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sld_awal.ForeColor = System.Drawing.Color.Gold
        Me.lb_sld_awal.Location = New System.Drawing.Point(135, 284)
        Me.lb_sld_awal.Name = "lb_sld_awal"
        Me.lb_sld_awal.Size = New System.Drawing.Size(21, 13)
        Me.lb_sld_awal.TabIndex = 350
        Me.lb_sld_awal.Text = "<>"
        '
        'Jenis_Bayar
        '
        Me.Jenis_Bayar.Location = New System.Drawing.Point(421, 280)
        Me.Jenis_Bayar.Name = "Jenis_Bayar"
        Me.Jenis_Bayar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Jenis_Bayar.Properties.Appearance.Options.UseBackColor = True
        Me.Jenis_Bayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Jenis_Bayar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_jenis_bayar", "Pembayaran")})
        Me.Jenis_Bayar.Properties.NullText = "[klik disini]"
        Me.Jenis_Bayar.Size = New System.Drawing.Size(150, 20)
        Me.Jenis_Bayar.TabIndex = 349
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Gold
        Me.Label22.Location = New System.Drawing.Point(306, 284)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 348
        Me.Label22.Text = "Pembayaran"
        '
        'Lue_member
        '
        Me.Lue_member.Location = New System.Drawing.Point(135, 196)
        Me.Lue_member.Name = "Lue_member"
        Me.Lue_member.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_member.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_member.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_member.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.Lue_member.Properties.NullText = "[klik disini]"
        Me.Lue_member.Size = New System.Drawing.Size(150, 20)
        Me.Lue_member.TabIndex = 345
        '
        'TE_Fee
        '
        Me.TE_Fee.EditValue = "0"
        Me.TE_Fee.Location = New System.Drawing.Point(135, 365)
        Me.TE_Fee.Name = "TE_Fee"
        Me.TE_Fee.Properties.Appearance.Options.UseTextOptions = True
        Me.TE_Fee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TE_Fee.Properties.DisplayFormat.FormatString = "n0"
        Me.TE_Fee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Fee.Properties.EditFormat.FormatString = "n0"
        Me.TE_Fee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Fee.Properties.Mask.EditMask = "n0"
        Me.TE_Fee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_Fee.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TE_Fee.Size = New System.Drawing.Size(150, 20)
        Me.TE_Fee.TabIndex = 344
        '
        'lb_fee
        '
        Me.lb_fee.AutoSize = True
        Me.lb_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fee.ForeColor = System.Drawing.Color.Gold
        Me.lb_fee.Location = New System.Drawing.Point(18, 369)
        Me.lb_fee.Name = "lb_fee"
        Me.lb_fee.Size = New System.Drawing.Size(81, 13)
        Me.lb_fee.TabIndex = 343
        Me.lb_fee.Text = "Fee Koperasi"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gold
        Me.Label19.Location = New System.Drawing.Point(18, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 342
        Me.Label19.Text = "Jns Keanggotaan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gold
        Me.Label18.Location = New System.Drawing.Point(18, 312)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 340
        Me.Label18.Text = "Nama Barang"
        '
        'Lue_Brg
        '
        Me.Lue_Brg.Location = New System.Drawing.Point(135, 251)
        Me.Lue_Brg.Name = "Lue_Brg"
        Me.Lue_Brg.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_Brg.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_Brg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_Brg.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.Lue_Brg.Properties.NullText = "[klik disini]"
        Me.Lue_Brg.Size = New System.Drawing.Size(150, 20)
        Me.Lue_Brg.TabIndex = 339
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(18, 255)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 338
        Me.Label17.Text = "Supplier"
        '
        'Lue_Jns_brg
        '
        Me.Lue_Jns_brg.Location = New System.Drawing.Point(135, 308)
        Me.Lue_Jns_brg.Name = "Lue_Jns_brg"
        Me.Lue_Jns_brg.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_Jns_brg.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_Jns_brg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_Jns_brg.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.Lue_Jns_brg.Properties.NullText = "[klik disini]"
        Me.Lue_Jns_brg.Size = New System.Drawing.Size(150, 20)
        Me.Lue_Jns_brg.TabIndex = 337
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(18, 393)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 336
        Me.Label15.Text = "Tenor"
        '
        'tx1_LamaPJM
        '
        Me.tx1_LamaPJM.Location = New System.Drawing.Point(135, 389)
        Me.tx1_LamaPJM.Name = "tx1_LamaPJM"
        Me.tx1_LamaPJM.Size = New System.Drawing.Size(34, 20)
        Me.tx1_LamaPJM.TabIndex = 335
        Me.tx1_LamaPJM.Text = "1"
        '
        'cb_bg
        '
        Me.cb_bg.AutoSize = True
        Me.cb_bg.Checked = True
        Me.cb_bg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_bg.Location = New System.Drawing.Point(306, 368)
        Me.cb_bg.Name = "cb_bg"
        Me.cb_bg.Size = New System.Drawing.Size(15, 14)
        Me.cb_bg.TabIndex = 334
        Me.cb_bg.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Label16.Location = New System.Drawing.Point(338, 395)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 15)
        Me.Label16.TabIndex = 333
        Me.Label16.Text = "Bunga Berjalan:"
        Me.Label16.Visible = False
        '
        'lb_bg
        '
        Me.lb_bg.AutoSize = True
        Me.lb_bg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bg.ForeColor = System.Drawing.Color.Gold
        Me.lb_bg.Location = New System.Drawing.Point(451, 396)
        Me.lb_bg.Name = "lb_bg"
        Me.lb_bg.Size = New System.Drawing.Size(21, 13)
        Me.lb_bg.TabIndex = 332
        Me.lb_bg.Text = "<>"
        Me.lb_bg.Visible = False
        '
        'Lue_SetPjm
        '
        Me.Lue_SetPjm.Location = New System.Drawing.Point(135, 43)
        Me.Lue_SetPjm.Name = "Lue_SetPjm"
        Me.Lue_SetPjm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_SetPjm.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_SetPjm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_SetPjm.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Jenis Kredit")})
        Me.Lue_SetPjm.Properties.NullText = "[klik disini]"
        Me.Lue_SetPjm.Size = New System.Drawing.Size(150, 20)
        Me.Lue_SetPjm.TabIndex = 331
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(306, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "Tanggal"
        '
        'de_tgl
        '
        Me.de_tgl.EditValue = Nothing
        Me.de_tgl.Location = New System.Drawing.Point(421, 43)
        Me.de_tgl.Name = "de_tgl"
        Me.de_tgl.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.de_tgl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.de_tgl.Properties.Appearance.Options.UseBackColor = True
        Me.de_tgl.Properties.Appearance.Options.UseFont = True
        Me.de_tgl.Properties.Appearance.Options.UseTextOptions = True
        Me.de_tgl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.de_tgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_tgl.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.de_tgl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.de_tgl.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.de_tgl.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.de_tgl.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.de_tgl.Size = New System.Drawing.Size(150, 20)
        Me.de_tgl.TabIndex = 329
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Gold
        Me.Label24.Location = New System.Drawing.Point(306, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(190, 13)
        Me.Label24.TabIndex = 326
        Me.Label24.Text = "*) setelah ketik NIP tekan tombol Enter"
        Me.Label24.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Gold
        Me.Label41.Location = New System.Drawing.Point(306, 228)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(52, 13)
        Me.Label41.TabIndex = 318
        Me.Label41.Text = "BANK : "
        '
        'txb_bank
        '
        Me.txb_bank.Location = New System.Drawing.Point(421, 224)
        Me.txb_bank.Name = "txb_bank"
        Me.txb_bank.Size = New System.Drawing.Size(150, 20)
        Me.txb_bank.TabIndex = 317
        '
        'txb_norek
        '
        Me.txb_norek.Location = New System.Drawing.Point(135, 224)
        Me.txb_norek.Name = "txb_norek"
        Me.txb_norek.Size = New System.Drawing.Size(150, 20)
        Me.txb_norek.TabIndex = 316
        '
        'TE_BsrPJM1
        '
        Me.TE_BsrPJM1.EditValue = "0"
        Me.TE_BsrPJM1.Location = New System.Drawing.Point(135, 336)
        Me.TE_BsrPJM1.Name = "TE_BsrPJM1"
        Me.TE_BsrPJM1.Properties.Appearance.Options.UseTextOptions = True
        Me.TE_BsrPJM1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TE_BsrPJM1.Properties.DisplayFormat.FormatString = "n0"
        Me.TE_BsrPJM1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_BsrPJM1.Properties.EditFormat.FormatString = "n0"
        Me.TE_BsrPJM1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_BsrPJM1.Properties.Mask.EditMask = "n0"
        Me.TE_BsrPJM1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_BsrPJM1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TE_BsrPJM1.Size = New System.Drawing.Size(150, 20)
        Me.TE_BsrPJM1.TabIndex = 315
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(18, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 314
        Me.Label10.Text = "No Rekening"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(18, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 313
        Me.Label9.Text = "Nominal"
        '
        'lb_dinas
        '
        Me.lb_dinas.AutoSize = True
        Me.lb_dinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dinas.ForeColor = System.Drawing.Color.Gold
        Me.lb_dinas.Location = New System.Drawing.Point(135, 140)
        Me.lb_dinas.Name = "lb_dinas"
        Me.lb_dinas.Size = New System.Drawing.Size(21, 13)
        Me.lb_dinas.TabIndex = 308
        Me.lb_dinas.Text = "<>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(18, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Tempat Dinas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(18, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 303
        Me.Label3.Text = "Nama"
        '
        'lb_nama
        '
        Me.lb_nama.AutoSize = True
        Me.lb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama.Location = New System.Drawing.Point(307, 118)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(21, 13)
        Me.lb_nama.TabIndex = 301
        Me.lb_nama.Text = "<>"
        Me.lb_nama.Visible = False
        '
        'LUE_nama
        '
        Me.LUE_nama.Location = New System.Drawing.Point(135, 81)
        Me.LUE_nama.Name = "LUE_nama"
        Me.LUE_nama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUE_nama.Properties.Appearance.Options.UseBackColor = True
        Me.LUE_nama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_nama.Properties.NullText = ""
        Me.LUE_nama.Size = New System.Drawing.Size(150, 20)
        Me.LUE_nama.TabIndex = 283
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Gold
        Me.Label32.Location = New System.Drawing.Point(18, 419)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 13)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "Keterangan"
        '
        'tx1_ket
        '
        Me.tx1_ket.Location = New System.Drawing.Point(135, 419)
        Me.tx1_ket.Multiline = True
        Me.tx1_ket.Name = "tx1_ket"
        Me.tx1_ket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tx1_ket.Size = New System.Drawing.Size(436, 32)
        Me.tx1_ket.TabIndex = 41
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Gold
        Me.Label34.Location = New System.Drawing.Point(18, 85)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(28, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "NIP"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lb_denda)
        Me.Panel1.Controls.Add(Me.lb_prvs)
        Me.Panel1.Controls.Add(Me.lb_admin)
        Me.Panel1.Controls.Add(Me.lb_bunga)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 52)
        Me.Panel1.TabIndex = 159
        '
        'lb_denda
        '
        Me.lb_denda.AutoSize = True
        Me.lb_denda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_denda.ForeColor = System.Drawing.Color.White
        Me.lb_denda.Location = New System.Drawing.Point(995, 32)
        Me.lb_denda.Name = "lb_denda"
        Me.lb_denda.Size = New System.Drawing.Size(14, 15)
        Me.lb_denda.TabIndex = 217
        Me.lb_denda.Text = "0"
        '
        'lb_prvs
        '
        Me.lb_prvs.AutoSize = True
        Me.lb_prvs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_prvs.ForeColor = System.Drawing.Color.White
        Me.lb_prvs.Location = New System.Drawing.Point(798, 33)
        Me.lb_prvs.Name = "lb_prvs"
        Me.lb_prvs.Size = New System.Drawing.Size(14, 15)
        Me.lb_prvs.TabIndex = 216
        Me.lb_prvs.Text = "0"
        '
        'lb_admin
        '
        Me.lb_admin.AutoSize = True
        Me.lb_admin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_admin.ForeColor = System.Drawing.Color.White
        Me.lb_admin.Location = New System.Drawing.Point(1013, 17)
        Me.lb_admin.Name = "lb_admin"
        Me.lb_admin.Size = New System.Drawing.Size(14, 15)
        Me.lb_admin.TabIndex = 215
        Me.lb_admin.Text = "0"
        '
        'lb_bunga
        '
        Me.lb_bunga.AutoSize = True
        Me.lb_bunga.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bunga.ForeColor = System.Drawing.Color.White
        Me.lb_bunga.Location = New System.Drawing.Point(824, 17)
        Me.lb_bunga.Name = "lb_bunga"
        Me.lb_bunga.Size = New System.Drawing.Size(14, 15)
        Me.lb_bunga.TabIndex = 214
        Me.lb_bunga.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(898, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 213
        Me.Label11.Text = "Denda (%):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(723, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "Provisi (%):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(898, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 15)
        Me.Label13.TabIndex = 211
        Me.Label13.Text = "Administrasi (Rp) :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(723, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "Bunga KSP (%) :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
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
        Me.Label1.Size = New System.Drawing.Size(771, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "              PENGAJUAN PERMOHONAN RETAIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tx_nama_brg
        '
        Me.tx_nama_brg.Location = New System.Drawing.Point(421, 308)
        Me.tx_nama_brg.Name = "tx_nama_brg"
        Me.tx_nama_brg.Size = New System.Drawing.Size(150, 20)
        Me.tx_nama_brg.TabIndex = 369
        Me.tx_nama_brg.Visible = False
        '
        'lb_nama_brg
        '
        Me.lb_nama_brg.AutoSize = True
        Me.lb_nama_brg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama_brg.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama_brg.Location = New System.Drawing.Point(306, 312)
        Me.lb_nama_brg.Name = "lb_nama_brg"
        Me.lb_nama_brg.Size = New System.Drawing.Size(83, 13)
        Me.lb_nama_brg.TabIndex = 368
        Me.lb_nama_brg.Text = "Nama Barang"
        Me.lb_nama_brg.Visible = False
        '
        'frm_ritel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 571)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_ritel2"
        Me.Text = "frm_ritel1"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.GcHist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv_hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.te_bunga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_pokok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jenis_Bayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_member.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_Fee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_Brg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_Jns_brg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_tgl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_tgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_BsrPJM1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GcHist As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gv_hist As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JML_PINJAMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents v_sisa_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LAMA_ANGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa_angs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gv_nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lb_nama As System.Windows.Forms.Label
    Friend WithEvents LUE_nama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tx1_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_dinas As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TE_BsrPJM1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txb_norek As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txb_bank As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents de_tgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Lue_SetPjm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb_denda As System.Windows.Forms.Label
    Friend WithEvents lb_prvs As System.Windows.Forms.Label
    Friend WithEvents lb_admin As System.Windows.Forms.Label
    Friend WithEvents lb_bunga As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lb_bg As System.Windows.Forms.Label
    Friend WithEvents cb_bg As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tx1_LamaPJM As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Lue_Jns_brg As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Lue_Brg As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TE_Fee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lb_fee As System.Windows.Forms.Label
    Friend WithEvents Lue_member As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Jenis_Bayar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lb_sld_awal As System.Windows.Forms.Label
    Friend WithEvents gc_pokok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_bunga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents te_bunga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents te_pokok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lb_notrans As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_line As System.Windows.Forms.Label
    Friend WithEvents btnTopUp As System.Windows.Forms.Button
    Friend WithEvents tx_nama_supp As System.Windows.Forms.TextBox
    Friend WithEvents lb_nama_supp As System.Windows.Forms.Label
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents tx_nama_brg As System.Windows.Forms.TextBox
    Friend WithEvents lb_nama_brg As System.Windows.Forms.Label
End Class
