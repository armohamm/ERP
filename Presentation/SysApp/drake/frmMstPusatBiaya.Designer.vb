<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstPusatBiaya
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstPusatBiaya))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcBukuPusat = New DevExpress.XtraGrid.GridControl
        Me.GvBukuPusat = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_header = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_level1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_level2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_level3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupDept = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcBukuPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBukuPusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcBukuPusat)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 313)
        Me.pnl.TabIndex = 0
        '
        'GcBukuPusat
        '
        Me.GcBukuPusat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBukuPusat.Location = New System.Drawing.Point(0, 34)
        Me.GcBukuPusat.MainView = Me.GvBukuPusat
        Me.GcBukuPusat.Name = "GcBukuPusat"
        Me.GcBukuPusat.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupDept, Me.CekStat})
        Me.GcBukuPusat.Size = New System.Drawing.Size(1004, 242)
        Me.GcBukuPusat.TabIndex = 32
        Me.GcBukuPusat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBukuPusat})
        '
        'GvBukuPusat
        '
        Me.GvBukuPusat.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBukuPusat.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.Empty.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBukuPusat.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBukuPusat.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBukuPusat.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvBukuPusat.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvBukuPusat.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBukuPusat.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBukuPusat.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBukuPusat.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvBukuPusat.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.GroupRow.Options.UseFont = True
        Me.GvBukuPusat.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBukuPusat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBukuPusat.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBukuPusat.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvBukuPusat.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBukuPusat.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvBukuPusat.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvBukuPusat.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.OddRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.OddRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBukuPusat.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBukuPusat.Appearance.Preview.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.Preview.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvBukuPusat.Appearance.Row.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.Row.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvBukuPusat.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvBukuPusat.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvBukuPusat.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvBukuPusat.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvBukuPusat.Appearance.VertLine.Options.UseBackColor = True
        Me.GvBukuPusat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_buku_pusat, Me.nm_buku_pusat, Me.grup_header, Me.tipe_rek, Me.grup_level1, Me.grup_level2, Me.grup_level3, Me.kd_departemen, Me.Rec_stat})
        Me.GvBukuPusat.GridControl = Me.GcBukuPusat
        Me.GvBukuPusat.Name = "GvBukuPusat"
        Me.GvBukuPusat.OptionsView.EnableAppearanceEvenRow = True
        Me.GvBukuPusat.OptionsView.EnableAppearanceOddRow = True
        Me.GvBukuPusat.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvBukuPusat.OptionsView.RowAutoHeight = True
        Me.GvBukuPusat.PaintStyleName = "WindowsXP"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_pusat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_pusat.Caption = "Kode Pusat Biaya"
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 0
        Me.kd_buku_pusat.Width = 107
        '
        'nm_buku_pusat
        '
        Me.nm_buku_pusat.AppearanceHeader.Options.UseTextOptions = True
        Me.nm_buku_pusat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_buku_pusat.Caption = "Nama Pusat Biaya"
        Me.nm_buku_pusat.FieldName = "nm_buku_pusat"
        Me.nm_buku_pusat.Name = "nm_buku_pusat"
        Me.nm_buku_pusat.Visible = True
        Me.nm_buku_pusat.VisibleIndex = 1
        Me.nm_buku_pusat.Width = 107
        '
        'grup_header
        '
        Me.grup_header.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_header.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_header.Caption = "Grup Header"
        Me.grup_header.FieldName = "grup_header"
        Me.grup_header.Name = "grup_header"
        Me.grup_header.Width = 107
        '
        'tipe_rek
        '
        Me.tipe_rek.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_rek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_rek.Caption = "Tipe Rekening"
        Me.tipe_rek.FieldName = "tipe_rek"
        Me.tipe_rek.Name = "tipe_rek"
        Me.tipe_rek.Visible = True
        Me.tipe_rek.VisibleIndex = 2
        Me.tipe_rek.Width = 107
        '
        'grup_level1
        '
        Me.grup_level1.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level1.Caption = "Grup Level1"
        Me.grup_level1.FieldName = "grup_level1"
        Me.grup_level1.Name = "grup_level1"
        Me.grup_level1.Width = 94
        '
        'grup_level2
        '
        Me.grup_level2.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level2.Caption = "Grup Level2"
        Me.grup_level2.FieldName = "grup_level2"
        Me.grup_level2.Name = "grup_level2"
        '
        'grup_level3
        '
        Me.grup_level3.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level3.Caption = "Grup Level 3"
        Me.grup_level3.FieldName = "grup_level3"
        Me.grup_level3.Name = "grup_level3"
        '
        'kd_departemen
        '
        Me.kd_departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_departemen.Caption = "Kode Departemen"
        Me.kd_departemen.ColumnEdit = Me.LookupDept
        Me.kd_departemen.FieldName = "kd_departemen"
        Me.kd_departemen.Name = "kd_departemen"
        Me.kd_departemen.Visible = True
        Me.kd_departemen.VisibleIndex = 3
        Me.kd_departemen.Width = 232
        '
        'LookupDept
        '
        Me.LookupDept.AutoHeight = False
        Me.LookupDept.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupDept.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Dept"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Departemen", "Kode Dept")})
        Me.LookupDept.DisplayMember = "Nama_Departemen"
        Me.LookupDept.HideSelection = False
        Me.LookupDept.Name = "LookupDept"
        Me.LookupDept.NullText = "[klik disini]"
        Me.LookupDept.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookupDept.ValueMember = "Kd_Departemen"
        '
        'Rec_stat
        '
        Me.Rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 4
        Me.Rec_stat.Width = 65
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "Y"
        Me.CekStat.DisplayValueChecked = "Y"
        Me.CekStat.DisplayValueUnchecked = "T"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 276)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 31
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(473, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(591, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(392, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE PUSAT BIAYA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstPusatBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 313)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstPusatBiaya"
        Me.Text = "frmMstPusatBiaya"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcBukuPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBukuPusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcBukuPusat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBukuPusat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupDept As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
