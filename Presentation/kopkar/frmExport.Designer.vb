<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GV_export = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.REKBCA1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.notrans_eksport = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rupiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ekor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txb_norekKOP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTgl = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.bt_exp = New DevExpress.XtraEditors.SimpleButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lue_bln = New DevExpress.XtraEditors.LookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_export, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.cbTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1021, 38)
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
        Me.Label1.Text = "          EXPORT DATA / TRANSFER DATA"
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
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'GV_export
        '
        Me.GV_export.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_export.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_export.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.Empty.Options.UseBackColor = True
        Me.GV_export.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_export.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_export.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_export.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_export.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_export.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_export.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_export.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_export.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_export.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_export.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_export.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_export.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_export.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_export.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_export.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_export.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_export.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_export.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_export.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_export.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_export.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_export.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_export.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_export.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.Preview.Options.UseFont = True
        Me.GV_export.Appearance.Preview.Options.UseForeColor = True
        Me.GV_export.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_export.Appearance.Row.Options.UseBackColor = True
        Me.GV_export.Appearance.Row.Options.UseForeColor = True
        Me.GV_export.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_export.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_export.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_export.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_export.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_export.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_export.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_export.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_export.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_export.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_export.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_export.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.REKBCA1, Me.notrans_eksport, Me.Nama, Me.rupiah, Me.ekor})
        Me.GV_export.GridControl = Me.Gc_nabung
        Me.GV_export.Name = "GV_export"
        Me.GV_export.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_export.OptionsPrint.PrintFooter = False
        Me.GV_export.OptionsPrint.PrintHeader = False
        Me.GV_export.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_export.OptionsView.EnableAppearanceOddRow = True
        Me.GV_export.OptionsView.RowAutoHeight = True
        Me.GV_export.OptionsView.ShowGroupPanel = False
        '
        'REKBCA1
        '
        Me.REKBCA1.Caption = "NO REK"
        Me.REKBCA1.FieldName = "REKBCA1"
        Me.REKBCA1.Name = "REKBCA1"
        Me.REKBCA1.OptionsColumn.AllowEdit = False
        Me.REKBCA1.OptionsColumn.ReadOnly = True
        Me.REKBCA1.Visible = True
        Me.REKBCA1.VisibleIndex = 0
        Me.REKBCA1.Width = 56
        '
        'notrans_eksport
        '
        Me.notrans_eksport.Caption = "No_Eksport"
        Me.notrans_eksport.FieldName = "no_trans"
        Me.notrans_eksport.Name = "notrans_eksport"
        Me.notrans_eksport.OptionsColumn.AllowEdit = False
        Me.notrans_eksport.OptionsColumn.ReadOnly = True
        Me.notrans_eksport.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.notrans_eksport.Visible = True
        Me.notrans_eksport.VisibleIndex = 1
        Me.notrans_eksport.Width = 55
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 2
        Me.Nama.Width = 202
        '
        'rupiah
        '
        Me.rupiah.Caption = "RUPIAH"
        Me.rupiah.DisplayFormat.FormatString = "{0:000000000000.00}"
        Me.rupiah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.rupiah.FieldName = "rupiah"
        Me.rupiah.Name = "rupiah"
        Me.rupiah.OptionsColumn.AllowEdit = False
        Me.rupiah.OptionsColumn.ReadOnly = True
        Me.rupiah.SummaryItem.DisplayFormat = "{0:000000000000.00}"
        Me.rupiah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rupiah.Visible = True
        Me.rupiah.VisibleIndex = 3
        Me.rupiah.Width = 92
        '
        'ekor
        '
        Me.ekor.Caption = "space"
        Me.ekor.FieldName = "ekor"
        Me.ekor.Name = "ekor"
        Me.ekor.OptionsColumn.AllowEdit = False
        Me.ekor.OptionsColumn.ReadOnly = True
        Me.ekor.Visible = True
        Me.ekor.VisibleIndex = 4
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_export
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.Size = New System.Drawing.Size(1021, 225)
        Me.Gc_nabung.TabIndex = 7
        Me.Gc_nabung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_export})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1021, 225)
        Me.Panel2.TabIndex = 3
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1021, 291)
        Me.pnl.TabIndex = 162
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txb_norekKOP)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.cbTgl)
        Me.Panel5.Controls.Add(Me.cmdRefresh)
        Me.Panel5.Controls.Add(Me.bt_exp)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dtp_tahun)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Lue_bln)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1021, 66)
        Me.Panel5.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "No Rekening Koperasi: "
        '
        'txb_norekKOP
        '
        Me.txb_norekKOP.Location = New System.Drawing.Point(172, 6)
        Me.txb_norekKOP.Name = "txb_norekKOP"
        Me.txb_norekKOP.Size = New System.Drawing.Size(160, 20)
        Me.txb_norekKOP.TabIndex = 198
        Me.txb_norekKOP.Text = "6710090007"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Tanggal Eksekusi :"
        '
        'cbTgl
        '
        Me.cbTgl.EditValue = "(tanggal)"
        Me.cbTgl.Location = New System.Drawing.Point(172, 39)
        Me.cbTgl.Name = "cbTgl"
        Me.cbTgl.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbTgl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbTgl.Properties.Appearance.Options.UseBackColor = True
        Me.cbTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTgl.Properties.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbTgl.Properties.MaxLength = 2
        Me.cbTgl.Size = New System.Drawing.Size(68, 20)
        Me.cbTgl.TabIndex = 196
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(837, 5)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(65, 57)
        Me.cmdRefresh.TabIndex = 195
        Me.cmdRefresh.Text = "REFRESH"
        '
        'bt_exp
        '
        Me.bt_exp.ImageIndex = 4
        Me.bt_exp.ImageList = Me.img
        Me.bt_exp.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bt_exp.Location = New System.Drawing.Point(908, 6)
        Me.bt_exp.LookAndFeel.SkinName = "The Asphalt World"
        Me.bt_exp.LookAndFeel.UseDefaultLookAndFeel = False
        Me.bt_exp.Name = "bt_exp"
        Me.bt_exp.Size = New System.Drawing.Size(66, 57)
        Me.bt_exp.TabIndex = 194
        Me.bt_exp.Text = "Export"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(488, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Tahun :"
        '
        'dtp_tahun
        '
        Me.dtp_tahun.CustomFormat = "yyyy"
        Me.dtp_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tahun.Location = New System.Drawing.Point(556, 39)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_tahun.Size = New System.Drawing.Size(63, 20)
        Me.dtp_tahun.TabIndex = 192
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(267, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Bulan :"
        '
        'Lue_bln
        '
        Me.Lue_bln.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lue_bln.Location = New System.Drawing.Point(331, 39)
        Me.Lue_bln.Margin = New System.Windows.Forms.Padding(0)
        Me.Lue_bln.Name = "Lue_bln"
        Me.Lue_bln.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_bln.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Lue_bln.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_bln.Properties.Appearance.Options.UseFont = True
        Me.Lue_bln.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Lue_bln.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_bln.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bulan", "Bulan")})
        Me.Lue_bln.Properties.DisplayFormat.FormatString = "mm"
        Me.Lue_bln.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Lue_bln.Properties.NullText = "(Bulan)"
        Me.Lue_bln.Properties.NullValuePrompt = "(Bulan)"
        Me.Lue_bln.Size = New System.Drawing.Size(110, 21)
        Me.Lue_bln.TabIndex = 190
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI_TRANS", "Transaksi")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 329)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmExport"
        Me.Text = "frmExport"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_export, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.cbTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GV_export As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents REKBCA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents notrans_eksport As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rupiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_exp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_tahun As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lue_bln As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTgl As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txb_norekKOP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ekor As DevExpress.XtraGrid.Columns.GridColumn
End Class
