<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_tab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_config_tab))
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.batas4_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas4_max = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas3_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas3_max = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bg_khusus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas2_max = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bunga1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV_CONFIG = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.bunga2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bunga3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pajak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas1_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas1_max = New DevExpress.XtraGrid.Columns.GridColumn
        Me.batas2_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pola_pajak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cb_pajak = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.batas_pajak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bunga4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_CONFIG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_pajak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1370, 34)
        Me.Panel5.TabIndex = 2
        '
        'batas4_min
        '
        Me.batas4_min.Caption = "batas4_min"
        Me.batas4_min.DisplayFormat.FormatString = "n0"
        Me.batas4_min.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas4_min.FieldName = "batas4_min"
        Me.batas4_min.Name = "batas4_min"
        Me.batas4_min.Visible = True
        Me.batas4_min.VisibleIndex = 11
        Me.batas4_min.Width = 67
        '
        'batas4_max
        '
        Me.batas4_max.Caption = "batas4_max"
        Me.batas4_max.DisplayFormat.FormatString = "n0"
        Me.batas4_max.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas4_max.FieldName = "batas4_max"
        Me.batas4_max.Name = "batas4_max"
        Me.batas4_max.Visible = True
        Me.batas4_max.VisibleIndex = 12
        Me.batas4_max.Width = 71
        '
        'batas3_min
        '
        Me.batas3_min.Caption = "batas3_min"
        Me.batas3_min.DisplayFormat.FormatString = "n0"
        Me.batas3_min.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas3_min.FieldName = "batas3_min"
        Me.batas3_min.Name = "batas3_min"
        Me.batas3_min.Visible = True
        Me.batas3_min.VisibleIndex = 8
        Me.batas3_min.Width = 71
        '
        'batas3_max
        '
        Me.batas3_max.Caption = "batas3_max"
        Me.batas3_max.DisplayFormat.FormatString = "n0"
        Me.batas3_max.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas3_max.FieldName = "batas3_max"
        Me.batas3_max.Name = "batas3_max"
        Me.batas3_max.Visible = True
        Me.batas3_max.VisibleIndex = 9
        Me.batas3_max.Width = 71
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
        Me.Panel1.Size = New System.Drawing.Size(1370, 38)
        Me.Panel1.TabIndex = 167
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
        Me.Label1.Text = "          KONFIGURASI TABUNGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bg_khusus
        '
        Me.bg_khusus.Caption = "Bunga Khusus"
        Me.bg_khusus.FieldName = "bg_khusus"
        Me.bg_khusus.Name = "bg_khusus"
        Me.bg_khusus.Visible = True
        Me.bg_khusus.VisibleIndex = 1
        Me.bg_khusus.Width = 79
        '
        'batas2_max
        '
        Me.batas2_max.Caption = "batas2_max"
        Me.batas2_max.DisplayFormat.FormatString = "n0"
        Me.batas2_max.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas2_max.FieldName = "batas2_max"
        Me.batas2_max.Name = "batas2_max"
        Me.batas2_max.Visible = True
        Me.batas2_max.VisibleIndex = 6
        Me.batas2_max.Width = 71
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 0
        Me.Nama.Width = 97
        '
        'bunga1
        '
        Me.bunga1.Caption = "bunga1"
        Me.bunga1.FieldName = "bunga1"
        Me.bunga1.Name = "bunga1"
        Me.bunga1.Visible = True
        Me.bunga1.VisibleIndex = 4
        Me.bunga1.Width = 48
        '
        'GV_CONFIG
        '
        Me.GV_CONFIG.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_CONFIG.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_CONFIG.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.Empty.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_CONFIG.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_CONFIG.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_CONFIG.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GV_CONFIG.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GV_CONFIG.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_CONFIG.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_CONFIG.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV_CONFIG.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_CONFIG.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.GroupRow.Options.UseFont = True
        Me.GV_CONFIG.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV_CONFIG.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_CONFIG.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_CONFIG.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_CONFIG.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GV_CONFIG.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV_CONFIG.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV_CONFIG.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GV_CONFIG.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV_CONFIG.Appearance.Preview.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.Preview.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.Row.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.Row.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_CONFIG.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GV_CONFIG.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GV_CONFIG.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_CONFIG.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_CONFIG.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV_CONFIG.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_CONFIG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama, Me.bg_khusus, Me.bunga1, Me.bunga2, Me.bunga3, Me.pajak, Me.rec_stat, Me.batas1_min, Me.batas1_max, Me.batas2_min, Me.batas2_max, Me.batas3_min, Me.batas3_max, Me.batas4_min, Me.batas4_max, Me.keterangan, Me.pola_pajak, Me.batas_pajak, Me.bunga4})
        Me.GV_CONFIG.GridControl = Me.GcINV_Ret
        Me.GV_CONFIG.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GV_CONFIG.Name = "GV_CONFIG"
        Me.GV_CONFIG.OptionsCustomization.AllowColumnMoving = False
        Me.GV_CONFIG.OptionsCustomization.AllowFilter = False
        Me.GV_CONFIG.OptionsCustomization.AllowGroup = False
        Me.GV_CONFIG.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_CONFIG.OptionsView.ColumnAutoWidth = False
        Me.GV_CONFIG.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_CONFIG.OptionsView.EnableAppearanceOddRow = True
        Me.GV_CONFIG.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_CONFIG.OptionsView.RowAutoHeight = True
        Me.GV_CONFIG.OptionsView.ShowFooter = True
        Me.GV_CONFIG.OptionsView.ShowGroupPanel = False
        Me.GV_CONFIG.OptionsView.ShowViewCaption = True
        Me.GV_CONFIG.ViewCaption = "KONFIGURASI APLIKASI"
        '
        'bunga2
        '
        Me.bunga2.Caption = "bunga2"
        Me.bunga2.FieldName = "bunga2"
        Me.bunga2.Name = "bunga2"
        Me.bunga2.Visible = True
        Me.bunga2.VisibleIndex = 7
        Me.bunga2.Width = 48
        '
        'bunga3
        '
        Me.bunga3.Caption = "bunga3"
        Me.bunga3.FieldName = "bunga3"
        Me.bunga3.Name = "bunga3"
        Me.bunga3.Visible = True
        Me.bunga3.VisibleIndex = 10
        Me.bunga3.Width = 48
        '
        'pajak
        '
        Me.pajak.Caption = "pajak"
        Me.pajak.FieldName = "pajak"
        Me.pajak.Name = "pajak"
        Me.pajak.Visible = True
        Me.pajak.VisibleIndex = 14
        Me.pajak.Width = 38
        '
        'rec_stat
        '
        Me.rec_stat.Caption = "Aktif"
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 18
        Me.rec_stat.Width = 56
        '
        'batas1_min
        '
        Me.batas1_min.Caption = "batas1_min"
        Me.batas1_min.DisplayFormat.FormatString = "n0"
        Me.batas1_min.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas1_min.FieldName = "batas1_min"
        Me.batas1_min.Name = "batas1_min"
        Me.batas1_min.Visible = True
        Me.batas1_min.VisibleIndex = 2
        Me.batas1_min.Width = 67
        '
        'batas1_max
        '
        Me.batas1_max.Caption = "batas1_max"
        Me.batas1_max.DisplayFormat.FormatString = "n0"
        Me.batas1_max.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.batas1_max.FieldName = "batas1_max"
        Me.batas1_max.Name = "batas1_max"
        Me.batas1_max.Visible = True
        Me.batas1_max.VisibleIndex = 3
        Me.batas1_max.Width = 71
        '
        'batas2_min
        '
        Me.batas2_min.Caption = "batas2_min"
        Me.batas2_min.FieldName = "batas2_min"
        Me.batas2_min.Name = "batas2_min"
        Me.batas2_min.Visible = True
        Me.batas2_min.VisibleIndex = 5
        Me.batas2_min.Width = 67
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 17
        Me.keterangan.Width = 152
        '
        'pola_pajak
        '
        Me.pola_pajak.Caption = "pola_pajak"
        Me.pola_pajak.ColumnEdit = Me.cb_pajak
        Me.pola_pajak.FieldName = "pola_pajak"
        Me.pola_pajak.Name = "pola_pajak"
        Me.pola_pajak.Visible = True
        Me.pola_pajak.VisibleIndex = 15
        Me.pola_pajak.Width = 64
        '
        'cb_pajak
        '
        Me.cb_pajak.AutoHeight = False
        Me.cb_pajak.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cb_pajak.Items.AddRange(New Object() {"NPWP", "BILYET"})
        Me.cb_pajak.Name = "cb_pajak"
        '
        'batas_pajak
        '
        Me.batas_pajak.Caption = "batas_pajak"
        Me.batas_pajak.FieldName = "batas_pajak"
        Me.batas_pajak.Name = "batas_pajak"
        Me.batas_pajak.Visible = True
        Me.batas_pajak.VisibleIndex = 16
        Me.batas_pajak.Width = 71
        '
        'bunga4
        '
        Me.bunga4.Caption = "bunga4"
        Me.bunga4.FieldName = "bunga4"
        Me.bunga4.Name = "bunga4"
        Me.bunga4.Visible = True
        Me.bunga4.VisibleIndex = 13
        Me.bunga4.Width = 48
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_CONFIG
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cb_pajak})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1370, 245)
        Me.GcINV_Ret.TabIndex = 7
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_CONFIG})
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1370, 279)
        Me.pnl.TabIndex = 168
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GcINV_Ret)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 245)
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
        'frm_config_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 317)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_config_tab"
        Me.Text = "frm_config_tab"
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_CONFIG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_pajak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents batas4_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas4_max As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas3_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas3_max As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bg_khusus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas2_max As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bunga1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_CONFIG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bunga2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bunga3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas1_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas1_max As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents batas2_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pola_pajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents batas_pajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cb_pajak As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents bunga4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
