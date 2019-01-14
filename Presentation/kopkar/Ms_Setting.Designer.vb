<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ms_Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ms_Setting))
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_nabung = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.start_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.end_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Adm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.provisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Denda_gc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Bunga_KSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.setuju01 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.setuju02 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.setuju03 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.setuju04 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.setuju05 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1105, 353)
        Me.Panel2.TabIndex = 3
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_nabung
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.Size = New System.Drawing.Size(1105, 353)
        Me.Gc_nabung.TabIndex = 7
        Me.Gc_nabung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_nabung})
        '
        'GV_nabung
        '
        Me.GV_nabung.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.Empty.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_nabung.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_nabung.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.Preview.Options.UseFont = True
        Me.GV_nabung.Appearance.Preview.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.Row.Options.UseBackColor = True
        Me.GV_nabung.Appearance.Row.Options.UseForeColor = True
        Me.GV_nabung.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_nabung.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd2, Me.kode, Me.Nama, Me.ket, Me.nilai, Me.start_date, Me.end_date, Me.nilai2, Me.nilai3, Me.Adm, Me.provisi, Me.Denda_gc, Me.Bunga_KSP, Me.setuju01, Me.setuju02, Me.setuju03, Me.setuju04, Me.setuju05})
        Me.GV_nabung.GridControl = Me.Gc_nabung
        Me.GV_nabung.Name = "GV_nabung"
        Me.GV_nabung.OptionsCustomization.AllowColumnMoving = False
        Me.GV_nabung.OptionsCustomization.AllowFilter = False
        Me.GV_nabung.OptionsCustomization.AllowGroup = False
        Me.GV_nabung.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_nabung.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_nabung.OptionsView.EnableAppearanceOddRow = True
        Me.GV_nabung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_nabung.OptionsView.RowAutoHeight = True
        Me.GV_nabung.OptionsView.ShowFooter = True
        Me.GV_nabung.OptionsView.ShowGroupPanel = False
        Me.GV_nabung.OptionsView.ShowViewCaption = True
        Me.GV_nabung.ViewCaption = "SETTING TRANSAKSI"
        '
        'kd2
        '
        Me.kd2.Caption = "kd2"
        Me.kd2.FieldName = "kd2"
        Me.kd2.Name = "kd2"
        Me.kd2.Visible = True
        Me.kd2.VisibleIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1105, 40)
        Me.Panel5.TabIndex = 2
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1105, 393)
        Me.pnl.TabIndex = 166
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
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MASTER SETTING PINJAMAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(1105, 38)
        Me.Panel1.TabIndex = 165
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
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'kode
        '
        Me.kode.Caption = "kode"
        Me.kode.FieldName = "kode"
        Me.kode.Name = "kode"
        Me.kode.Visible = True
        Me.kode.VisibleIndex = 1
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 2
        '
        'ket
        '
        Me.ket.Caption = "ket"
        Me.ket.FieldName = "ket"
        Me.ket.Name = "ket"
        Me.ket.Visible = True
        Me.ket.VisibleIndex = 3
        '
        'nilai
        '
        Me.nilai.Caption = "nilai"
        Me.nilai.FieldName = "nilai"
        Me.nilai.Name = "nilai"
        Me.nilai.Visible = True
        Me.nilai.VisibleIndex = 4
        '
        'start_date
        '
        Me.start_date.Caption = "start_date"
        Me.start_date.FieldName = "start_date"
        Me.start_date.Name = "start_date"
        Me.start_date.Visible = True
        Me.start_date.VisibleIndex = 5
        '
        'end_date
        '
        Me.end_date.Caption = "end_date"
        Me.end_date.FieldName = "end_date"
        Me.end_date.Name = "end_date"
        Me.end_date.Visible = True
        Me.end_date.VisibleIndex = 6
        '
        'nilai2
        '
        Me.nilai2.Caption = "nilai2"
        Me.nilai2.FieldName = "nilai2"
        Me.nilai2.Name = "nilai2"
        Me.nilai2.Visible = True
        Me.nilai2.VisibleIndex = 7
        '
        'nilai3
        '
        Me.nilai3.Caption = "nilai3"
        Me.nilai3.FieldName = "nilai3"
        Me.nilai3.Name = "nilai3"
        Me.nilai3.Visible = True
        Me.nilai3.VisibleIndex = 8
        '
        'Adm
        '
        Me.Adm.Caption = "Adm"
        Me.Adm.FieldName = "Adm"
        Me.Adm.Name = "Adm"
        Me.Adm.Visible = True
        Me.Adm.VisibleIndex = 9
        '
        'provisi
        '
        Me.provisi.Caption = "provisi"
        Me.provisi.FieldName = "provisi"
        Me.provisi.Name = "provisi"
        Me.provisi.Visible = True
        Me.provisi.VisibleIndex = 10
        '
        'Denda_gc
        '
        Me.Denda_gc.Caption = "Denda"
        Me.Denda_gc.FieldName = "Denda"
        Me.Denda_gc.Name = "Denda_gc"
        Me.Denda_gc.Visible = True
        Me.Denda_gc.VisibleIndex = 11
        '
        'Bunga_KSP
        '
        Me.Bunga_KSP.Caption = "Bunga_KSP"
        Me.Bunga_KSP.FieldName = "Bunga_KSP"
        Me.Bunga_KSP.Name = "Bunga_KSP"
        Me.Bunga_KSP.Visible = True
        Me.Bunga_KSP.VisibleIndex = 12
        '
        'setuju01
        '
        Me.setuju01.Caption = "setuju01"
        Me.setuju01.FieldName = "setuju01"
        Me.setuju01.Name = "setuju01"
        Me.setuju01.Visible = True
        Me.setuju01.VisibleIndex = 13
        '
        'setuju02
        '
        Me.setuju02.Caption = "setuju02"
        Me.setuju02.FieldName = "setuju02"
        Me.setuju02.Name = "setuju02"
        Me.setuju02.Visible = True
        Me.setuju02.VisibleIndex = 14
        '
        'setuju03
        '
        Me.setuju03.Caption = "setuju03"
        Me.setuju03.FieldName = "setuju03"
        Me.setuju03.Name = "setuju03"
        Me.setuju03.Visible = True
        Me.setuju03.VisibleIndex = 15
        '
        'setuju04
        '
        Me.setuju04.Caption = "setuju04"
        Me.setuju04.FieldName = "setuju04"
        Me.setuju04.Name = "setuju04"
        Me.setuju04.Visible = True
        Me.setuju04.VisibleIndex = 16
        '
        'setuju05
        '
        Me.setuju05.Caption = "setuju05"
        Me.setuju05.FieldName = "setuju05"
        Me.setuju05.Name = "setuju05"
        Me.setuju05.Visible = True
        Me.setuju05.VisibleIndex = 17
        '
        'Ms_Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 431)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ms_Setting"
        Me.Text = "Ms_Setting"
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_nabung As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents start_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents end_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Adm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents provisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Denda_gc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bunga_KSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents setuju01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents setuju02 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents setuju03 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents setuju04 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents setuju05 As DevExpress.XtraGrid.Columns.GridColumn
End Class
