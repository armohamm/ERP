<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMon_debet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMon_debet))
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.gc_byr_piu = New DevExpress.XtraGrid.GridControl
        Me.gv_byr_piu = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gb_no_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_angs_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gb_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_ket2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_lunas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lunas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis_debit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_Jenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_cek_byr = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RL_nama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.gc_byr_piu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_byr_piu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_Jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_cek_byr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_nama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.ImageIndex = 10
        Me.btnprin.Location = New System.Drawing.Point(521, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(71, 42)
        Me.btnprin.TabIndex = 35
        Me.btnprin.Text = "Cetak"
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(472, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 34
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(423, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(102, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(321, 42)
        Me.Panel6.TabIndex = 32
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(119, 11)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Bulan Tahun :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.btnprin)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1087, 42)
        Me.Panel2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 42)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Filter Periode : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Size = New System.Drawing.Size(616, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         MONITORING  DEBET"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gc_byr_piu)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1087, 224)
        Me.Panel5.TabIndex = 2
        '
        'gc_byr_piu
        '
        Me.gc_byr_piu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_byr_piu.Location = New System.Drawing.Point(0, 0)
        Me.gc_byr_piu.MainView = Me.gv_byr_piu
        Me.gc_byr_piu.Name = "gc_byr_piu"
        Me.gc_byr_piu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_cek_byr, Me.RL_nama, Me.RL_Jenis})
        Me.gc_byr_piu.Size = New System.Drawing.Size(1087, 224)
        Me.gc_byr_piu.TabIndex = 341
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
        Me.gv_byr_piu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gb_no_kartu, Me.gb_nilai, Me.gb_angs_ke, Me.gb_no, Me.gb_tgl_trans, Me.gb_Jenis, Me.gc_ket2, Me.Nama, Me.tgl_lunas, Me.lunas, Me.jenis_debit, Me.kode})
        Me.gv_byr_piu.GridControl = Me.gc_byr_piu
        Me.gv_byr_piu.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nilai", Me.gb_nilai, "{0:c2}")})
        Me.gv_byr_piu.Name = "gv_byr_piu"
        Me.gv_byr_piu.OptionsBehavior.ReadOnly = True
        Me.gv_byr_piu.OptionsNavigation.EnterMoveNextColumn = True
        Me.gv_byr_piu.OptionsView.EnableAppearanceEvenRow = True
        Me.gv_byr_piu.OptionsView.EnableAppearanceOddRow = True
        Me.gv_byr_piu.OptionsView.RowAutoHeight = True
        Me.gv_byr_piu.OptionsView.ShowFooter = True
        Me.gv_byr_piu.OptionsView.ShowGroupPanel = False
        Me.gv_byr_piu.OptionsView.ShowViewCaption = True
        Me.gv_byr_piu.ViewCaption = "Monitoring Debet Anggota"
        '
        'gb_no_kartu
        '
        Me.gb_no_kartu.Caption = "No Kartu"
        Me.gb_no_kartu.FieldName = "no_trans"
        Me.gb_no_kartu.Name = "gb_no_kartu"
        Me.gb_no_kartu.Visible = True
        Me.gb_no_kartu.VisibleIndex = 1
        Me.gb_no_kartu.Width = 55
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
        Me.gb_nilai.FieldName = "rupiah"
        Me.gb_nilai.Name = "gb_nilai"
        Me.gb_nilai.SummaryItem.DisplayFormat = "{0:n0}"
        Me.gb_nilai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.gb_nilai.Visible = True
        Me.gb_nilai.VisibleIndex = 10
        Me.gb_nilai.Width = 225
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
        Me.gb_no.FieldName = "nomer"
        Me.gb_no.Name = "gb_no"
        Me.gb_no.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.gb_no.Visible = True
        Me.gb_no.VisibleIndex = 0
        Me.gb_no.Width = 22
        '
        'gb_tgl_trans
        '
        Me.gb_tgl_trans.Caption = "Tanggal"
        Me.gb_tgl_trans.FieldName = "tgl_eksekusi"
        Me.gb_tgl_trans.Name = "gb_tgl_trans"
        Me.gb_tgl_trans.Visible = True
        Me.gb_tgl_trans.VisibleIndex = 7
        Me.gb_tgl_trans.Width = 56
        '
        'gb_Jenis
        '
        Me.gb_Jenis.Caption = "Bulan tahun"
        Me.gb_Jenis.FieldName = "blthn"
        Me.gb_Jenis.Name = "gb_Jenis"
        Me.gb_Jenis.Visible = True
        Me.gb_Jenis.VisibleIndex = 4
        Me.gb_Jenis.Width = 66
        '
        'gc_ket2
        '
        Me.gc_ket2.Caption = "User"
        Me.gc_ket2.FieldName = "createdby"
        Me.gc_ket2.Name = "gc_ket2"
        Me.gc_ket2.Visible = True
        Me.gc_ket2.VisibleIndex = 8
        Me.gc_ket2.Width = 45
        '
        'Nama
        '
        Me.Nama.Caption = "NIP"
        Me.Nama.FieldName = "nasabah_id"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 2
        Me.Nama.Width = 50
        '
        'tgl_lunas
        '
        Me.tgl_lunas.Caption = "No Rek"
        Me.tgl_lunas.FieldName = "REKBCA1"
        Me.tgl_lunas.Name = "tgl_lunas"
        Me.tgl_lunas.Visible = True
        Me.tgl_lunas.VisibleIndex = 9
        Me.tgl_lunas.Width = 59
        '
        'lunas
        '
        Me.lunas.Caption = "Nama"
        Me.lunas.FieldName = "Nama"
        Me.lunas.Name = "lunas"
        Me.lunas.Visible = True
        Me.lunas.VisibleIndex = 3
        Me.lunas.Width = 234
        '
        'jenis_debit
        '
        Me.jenis_debit.Caption = "Jenis"
        Me.jenis_debit.ColumnEdit = Me.RL_Jenis
        Me.jenis_debit.FieldName = "jenis_debit"
        Me.jenis_debit.Name = "jenis_debit"
        Me.jenis_debit.Visible = True
        Me.jenis_debit.VisibleIndex = 5
        Me.jenis_debit.Width = 196
        '
        'RL_Jenis
        '
        Me.RL_Jenis.AutoHeight = False
        Me.RL_Jenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_Jenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_Jenis.Name = "RL_Jenis"
        Me.RL_Jenis.NullText = ""
        '
        'kode
        '
        Me.kode.Caption = "Kode"
        Me.kode.FieldName = "jenis_debit"
        Me.kode.Name = "kode"
        Me.kode.Visible = True
        Me.kode.VisibleIndex = 6
        Me.kode.Width = 58
        '
        'RL_cek_byr
        '
        Me.RL_cek_byr.AutoHeight = False
        Me.RL_cek_byr.Name = "RL_cek_byr"
        Me.RL_cek_byr.ValueChecked = "Y"
        Me.RL_cek_byr.ValueGrayed = "T"
        Me.RL_cek_byr.ValueUnchecked = "T"
        '
        'RL_nama
        '
        Me.RL_nama.AutoHeight = False
        Me.RL_nama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_nama.Name = "RL_nama"
        Me.RL_nama.NullText = ""
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gc_byr_piu
        Me.GridView3.Name = "GridView3"
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
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gc_byr_piu
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.ImageCollection.Images.SetKeyName(0, "LOGO_MSBCA1.png")
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Image 0]", "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LAPORAN RITEL DAN OMNI", ""}, New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Hal [Page # of Pages #]", "", "Tanngal Cetak: [Date Printed]"}, New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1087, 291)
        Me.pnl.TabIndex = 160
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 266)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1087, 25)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1087, 42)
        Me.Panel3.TabIndex = 0
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
        Me.Panel1.Size = New System.Drawing.Size(1087, 38)
        Me.Panel1.TabIndex = 159
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'frmMon_debet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 329)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMon_debet"
        Me.Text = "frmMon_debet"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.gc_byr_piu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_byr_piu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_Jenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_cek_byr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_nama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents gc_byr_piu As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_byr_piu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RL_cek_byr As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gb_no_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_angs_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gb_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc_ket2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_nama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tgl_lunas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lunas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_Jenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kode As DevExpress.XtraGrid.Columns.GridColumn
End Class
