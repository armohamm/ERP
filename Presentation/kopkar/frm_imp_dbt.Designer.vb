<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_imp_dbt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_imp_dbt))
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_nabung = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.norek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rupiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_jenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lue_bln = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.lb_dir = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1085, 346)
        Me.pnl.TabIndex = 168
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 287)
        Me.Panel2.TabIndex = 3
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_nabung
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_jenis})
        Me.Gc_nabung.Size = New System.Drawing.Size(1085, 287)
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
        Me.GV_nabung.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.norek, Me.nasabah_id, Me.kd_trans, Me.Nama, Me.rupiah, Me.jenis, Me.nomer, Me.keterangan})
        Me.GV_nabung.GridControl = Me.Gc_nabung
        Me.GV_nabung.Name = "GV_nabung"
        Me.GV_nabung.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_nabung.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_nabung.OptionsView.EnableAppearanceOddRow = True
        Me.GV_nabung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_nabung.OptionsView.RowAutoHeight = True
        Me.GV_nabung.OptionsView.ShowFooter = True
        Me.GV_nabung.OptionsView.ShowGroupPanel = False
        Me.GV_nabung.OptionsView.ShowViewCaption = True
        Me.GV_nabung.ViewCaption = "PRA EXPORT KE SISTEM"
        '
        'norek
        '
        Me.norek.Caption = "No Rek"
        Me.norek.FieldName = "norek"
        Me.norek.Name = "norek"
        Me.norek.OptionsColumn.AllowEdit = False
        Me.norek.OptionsColumn.ReadOnly = True
        Me.norek.Visible = True
        Me.norek.VisibleIndex = 1
        '
        'nasabah_id
        '
        Me.nasabah_id.Caption = "ID Pegawai"
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.OptionsColumn.AllowEdit = False
        Me.nasabah_id.OptionsColumn.ReadOnly = True
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 2
        '
        'kd_trans
        '
        Me.kd_trans.Caption = "Kode Trans"
        Me.kd_trans.FieldName = "no_trans"
        Me.kd_trans.Name = "kd_trans"
        Me.kd_trans.OptionsColumn.AllowEdit = False
        Me.kd_trans.OptionsColumn.ReadOnly = True
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 3
        '
        'rupiah
        '
        Me.rupiah.Caption = "Rupiah"
        Me.rupiah.DisplayFormat.FormatString = "n0"
        Me.rupiah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rupiah.FieldName = "rupiah"
        Me.rupiah.Name = "rupiah"
        Me.rupiah.OptionsColumn.AllowEdit = False
        Me.rupiah.OptionsColumn.ReadOnly = True
        Me.rupiah.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rupiah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rupiah.Visible = True
        Me.rupiah.VisibleIndex = 4
        Me.rupiah.Width = 126
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis Kredit"
        Me.jenis.FieldName = "kode"
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.OptionsColumn.ReadOnly = True
        '
        'nomer
        '
        Me.nomer.Caption = "No"
        Me.nomer.FieldName = "no_seq"
        Me.nomer.Name = "nomer"
        Me.nomer.SummaryItem.FieldName = "nomer"
        Me.nomer.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 25
        '
        'keterangan
        '
        Me.keterangan.Caption = "keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        '
        'RL_jenis
        '
        Me.RL_jenis.AutoHeight = False
        Me.RL_jenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_jenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_jenis.Name = "RL_jenis"
        Me.RL_jenis.NullText = ""
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dtp_tahun)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Lue_bln)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.lb_dir)
        Me.Panel5.Controls.Add(Me.btnBrowse)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1085, 59)
        Me.Panel5.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(328, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Tahun :"
        '
        'dtp_tahun
        '
        Me.dtp_tahun.CustomFormat = "yyyy"
        Me.dtp_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tahun.Location = New System.Drawing.Point(387, 23)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_tahun.Size = New System.Drawing.Size(63, 20)
        Me.dtp_tahun.TabIndex = 201
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(119, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 200
        Me.Label4.Text = "Periode :"
        '
        'Lue_bln
        '
        Me.Lue_bln.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lue_bln.Location = New System.Drawing.Point(186, 22)
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
        Me.Lue_bln.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(556, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Lokasi File :"
        '
        'lb_dir
        '
        Me.lb_dir.AutoSize = True
        Me.lb_dir.Location = New System.Drawing.Point(621, 25)
        Me.lb_dir.Name = "lb_dir"
        Me.lb_dir.Size = New System.Drawing.Size(0, 13)
        Me.lb_dir.TabIndex = 197
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBrowse.Location = New System.Drawing.Point(627, 20)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(99, 23)
        Me.btnBrowse.TabIndex = 196
        Me.btnBrowse.Text = "Browse/Cari File"
        Me.btnBrowse.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(1085, 38)
        Me.Panel1.TabIndex = 167
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
        Me.Label1.Text = "          IMPORT TXT DEBET MANUAL"
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
        'frm_imp_dbt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 384)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_imp_dbt"
        Me.Text = "frm_imp_dbt"
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_jenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_nabung As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents norek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rupiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_jenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lb_dir As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_tahun As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lue_bln As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
