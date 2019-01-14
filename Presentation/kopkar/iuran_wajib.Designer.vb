<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuran_wajib
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iuran_wajib))
        Me.Gv_angs = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_trans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.thnbl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nasabah_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_simpanan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Gc_angs = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Lue_SetPjm = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lue_bln = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.tx_kembali = New System.Windows.Forms.TextBox
        Me.tx_iuran = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.tx_setor = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tx_id = New System.Windows.Forms.TextBox
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.Gv_angs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gc_angs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Gv_angs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_trans, Me.thnbl, Me.nasabah_id, Me.Nama, Me.rp_simpanan, Me.tgl_bayar})
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
        Me.Gv_angs.ViewCaption = "IURAN WAJIB ANGGOTA"
        '
        'kd_trans
        '
        Me.kd_trans.Caption = "Jenis Trans"
        Me.kd_trans.ColumnEdit = Me.RL_trans
        Me.kd_trans.FieldName = "kd_trans"
        Me.kd_trans.Name = "kd_trans"
        Me.kd_trans.OptionsColumn.AllowEdit = False
        Me.kd_trans.OptionsColumn.ReadOnly = True
        Me.kd_trans.Visible = True
        Me.kd_trans.VisibleIndex = 0
        Me.kd_trans.Width = 102
        '
        'RL_trans
        '
        Me.RL_trans.AutoHeight = False
        Me.RL_trans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_trans.Name = "RL_trans"
        Me.RL_trans.NullText = ""
        '
        'thnbl
        '
        Me.thnbl.Caption = "Bulan"
        Me.thnbl.FieldName = "blthn"
        Me.thnbl.Name = "thnbl"
        Me.thnbl.OptionsColumn.AllowEdit = False
        Me.thnbl.OptionsColumn.ReadOnly = True
        Me.thnbl.Visible = True
        Me.thnbl.VisibleIndex = 1
        Me.thnbl.Width = 78
        '
        'nasabah_id
        '
        Me.nasabah_id.Caption = "ID nasabah "
        Me.nasabah_id.FieldName = "nasabah_id"
        Me.nasabah_id.Name = "nasabah_id"
        Me.nasabah_id.Visible = True
        Me.nasabah_id.VisibleIndex = 2
        Me.nasabah_id.Width = 92
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 3
        Me.Nama.Width = 181
        '
        'rp_simpanan
        '
        Me.rp_simpanan.Caption = "Jumlah"
        Me.rp_simpanan.FieldName = "rp_simpanan"
        Me.rp_simpanan.Name = "rp_simpanan"
        Me.rp_simpanan.Visible = True
        Me.rp_simpanan.VisibleIndex = 4
        Me.rp_simpanan.Width = 58
        '
        'tgl_bayar
        '
        Me.tgl_bayar.Caption = "Tgl Bayar"
        Me.tgl_bayar.FieldName = "tgl_bayar"
        Me.tgl_bayar.Name = "tgl_bayar"
        Me.tgl_bayar.Visible = True
        Me.tgl_bayar.VisibleIndex = 5
        Me.tgl_bayar.Width = 475
        '
        'Gc_angs
        '
        Me.Gc_angs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_angs.Location = New System.Drawing.Point(0, 0)
        Me.Gc_angs.MainView = Me.Gv_angs
        Me.Gc_angs.Name = "Gc_angs"
        Me.Gc_angs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_trans})
        Me.Gc_angs.Size = New System.Drawing.Size(1007, 135)
        Me.Gc_angs.TabIndex = 12
        Me.Gc_angs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gv_angs, Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Gc_angs
        Me.GridView4.Name = "GridView4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Jumlah IURAN :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_angs)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1007, 135)
        Me.Panel2.TabIndex = 3
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1007, 291)
        Me.pnl.TabIndex = 164
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dtp_tahun)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Lue_SetPjm)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Lue_bln)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.tx_kembali)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.tx_iuran)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.tx_setor)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.tx_id)
        Me.Panel5.Controls.Add(Me.tx_nama)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1007, 156)
        Me.Panel5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Jenis Simpanan :"
        '
        'Lue_SetPjm
        '
        Me.Lue_SetPjm.Location = New System.Drawing.Point(126, 42)
        Me.Lue_SetPjm.Name = "Lue_SetPjm"
        Me.Lue_SetPjm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_SetPjm.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_SetPjm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_SetPjm.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_transaksi", "Jenis Kredit")})
        Me.Lue_SetPjm.Properties.NullText = "[klik disini]"
        Me.Lue_SetPjm.Size = New System.Drawing.Size(151, 20)
        Me.Lue_SetPjm.TabIndex = 186
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Bulan :"
        '
        'Lue_bln
        '
        Me.Lue_bln.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lue_bln.Location = New System.Drawing.Point(125, 67)
        Me.Lue_bln.Margin = New System.Windows.Forms.Padding(0)
        Me.Lue_bln.Name = "Lue_bln"
        Me.Lue_bln.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lue_bln.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Lue_bln.Properties.Appearance.Options.UseBackColor = True
        Me.Lue_bln.Properties.Appearance.Options.UseFont = True
        Me.Lue_bln.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Lue_bln.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue_bln.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bulan", "Bulan")})
        Me.Lue_bln.Properties.NullText = "(Bulan)"
        Me.Lue_bln.Properties.NullValuePrompt = "(Bulan)"
        Me.Lue_bln.Size = New System.Drawing.Size(152, 21)
        Me.Lue_bln.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Kembali :"
        '
        'tx_kembali
        '
        Me.tx_kembali.Location = New System.Drawing.Point(382, 122)
        Me.tx_kembali.Name = "tx_kembali"
        Me.tx_kembali.Size = New System.Drawing.Size(100, 20)
        Me.tx_kembali.TabIndex = 56
        '
        'tx_iuran
        '
        Me.tx_iuran.Location = New System.Drawing.Point(126, 93)
        Me.tx_iuran.Name = "tx_iuran"
        Me.tx_iuran.Size = New System.Drawing.Size(151, 20)
        Me.tx_iuran.TabIndex = 53
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(308, 47)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "ID Anggota :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
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
        Me.Label27.Location = New System.Drawing.Point(28, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 15)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Dibayar :"
        '
        'tx_setor
        '
        Me.tx_setor.Location = New System.Drawing.Point(126, 119)
        Me.tx_setor.Name = "tx_setor"
        Me.tx_setor.Size = New System.Drawing.Size(151, 20)
        Me.tx_setor.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Location = New System.Drawing.Point(326, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(382, 44)
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
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
        Me.Label1.Text = "          PEMBAYARAN IURAN WAJIB (OFFLINE)"
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
        Me.Panel1.Size = New System.Drawing.Size(1007, 38)
        Me.Panel1.TabIndex = 163
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'dtp_tahun
        '
        Me.dtp_tahun.CustomFormat = "yyyy"
        Me.dtp_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tahun.Location = New System.Drawing.Point(382, 70)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_tahun.Size = New System.Drawing.Size(100, 20)
        Me.dtp_tahun.TabIndex = 188
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "Tahun :"
        '
        'iuran_wajib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 329)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "iuran_wajib"
        Me.Text = "iuran_wajib"
        CType(Me.Gv_angs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gc_angs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Lue_SetPjm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue_bln.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gv_angs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents thnbl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nasabah_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_simpanan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gc_angs As DevExpress.XtraGrid.GridControl
    Friend WithEvents RL_trans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_kembali As System.Windows.Forms.TextBox
    Friend WithEvents tx_iuran As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tx_setor As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tx_id As System.Windows.Forms.TextBox
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lue_bln As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lue_SetPjm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_tahun As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
