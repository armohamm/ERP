<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstCOA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstCOA))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMstCOA = New DevExpress.XtraGrid.GridControl
        Me.GvMstCOA = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_header = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cflow = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookCFlow = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_val = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LU_Valuta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.grup_level1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_level2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grup_level3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.div1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.div2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pola_entry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LuvUnit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcMstCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookCFlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LU_Valuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuvUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMstCOA)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 435)
        Me.pnl.TabIndex = 0
        '
        'GcMstCOA
        '
        Me.GcMstCOA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMstCOA.Location = New System.Drawing.Point(0, 34)
        Me.GcMstCOA.MainView = Me.GvMstCOA
        Me.GcMstCOA.Name = "GcMstCOA"
        Me.GcMstCOA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat, Me.LU_Valuta, Me.LuvUnit, Me.lookCFlow})
        Me.GcMstCOA.Size = New System.Drawing.Size(1004, 364)
        Me.GcMstCOA.TabIndex = 32
        Me.GcMstCOA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstCOA})
        '
        'GvMstCOA
        '
        Me.GvMstCOA.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.Empty.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvMstCOA.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvMstCOA.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMstCOA.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvMstCOA.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupRow.Options.UseFont = True
        Me.GvMstCOA.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMstCOA.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstCOA.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GvMstCOA.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseFont = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GvMstCOA.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GvMstCOA.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvMstCOA.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstCOA.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMstCOA.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstCOA.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvMstCOA.Appearance.Preview.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.Preview.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.Row.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.Row.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvMstCOA.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvMstCOA.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMstCOA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_buku_besar, Me.nm_buku_besar, Me.grup_header, Me.tipe_rek, Me.cflow, Me.kd_val, Me.grup_level1, Me.grup_level2, Me.grup_level3, Me.div1, Me.div2, Me.Rec_stat, Me.pola_entry})
        Me.GvMstCOA.GridControl = Me.GcMstCOA
        Me.GvMstCOA.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GvMstCOA.Name = "GvMstCOA"
        Me.GvMstCOA.NewItemRowText = "Tambah data baru disini"
        Me.GvMstCOA.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMstCOA.OptionsView.EnableAppearanceOddRow = True
        Me.GvMstCOA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvMstCOA.OptionsView.RowAutoHeight = True
        Me.GvMstCOA.OptionsView.ShowGroupedColumns = True
        Me.GvMstCOA.PaintStyleName = "WindowsXP"
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Kode COA"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 0
        Me.kd_buku_besar.Width = 125
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.nm_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nm_buku_besar.Caption = "Nama COA"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.VisibleIndex = 1
        Me.nm_buku_besar.Width = 125
        '
        'grup_header
        '
        Me.grup_header.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_header.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_header.Caption = "Grup Header"
        Me.grup_header.FieldName = "grup_header"
        Me.grup_header.Name = "grup_header"
        Me.grup_header.Visible = True
        Me.grup_header.VisibleIndex = 3
        Me.grup_header.Width = 125
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
        Me.tipe_rek.Width = 200
        '
        'cflow
        '
        Me.cflow.Caption = "Cash Flow"
        Me.cflow.ColumnEdit = Me.lookCFlow
        Me.cflow.FieldName = "cflow"
        Me.cflow.Name = "cflow"
        Me.cflow.Visible = True
        Me.cflow.VisibleIndex = 4
        '
        'lookCFlow
        '
        Me.lookCFlow.AutoHeight = False
        Me.lookCFlow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookCFlow.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Name3")})
        Me.lookCFlow.Name = "lookCFlow"
        Me.lookCFlow.NullText = "[CFlow]"
        Me.lookCFlow.ShowFooter = False
        Me.lookCFlow.ShowHeader = False
        Me.lookCFlow.ShowPopupShadow = False
        '
        'kd_val
        '
        Me.kd_val.Caption = "Kurs Valuta"
        Me.kd_val.ColumnEdit = Me.LU_Valuta
        Me.kd_val.FieldName = "kd_valuta"
        Me.kd_val.Name = "kd_val"
        Me.kd_val.Width = 66
        '
        'LU_Valuta
        '
        Me.LU_Valuta.AutoHeight = False
        Me.LU_Valuta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_Valuta.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode_valuta", "Kode Valuta")})
        Me.LU_Valuta.DisplayMember = "kd_valuta"
        Me.LU_Valuta.Name = "LU_Valuta"
        Me.LU_Valuta.NullText = "[Valuta]"
        Me.LU_Valuta.ValueMember = "kode_valuta"
        '
        'grup_level1
        '
        Me.grup_level1.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level1.Caption = "Grup level 1"
        Me.grup_level1.FieldName = "grup_level1"
        Me.grup_level1.Name = "grup_level1"
        Me.grup_level1.Visible = True
        Me.grup_level1.VisibleIndex = 6
        Me.grup_level1.Width = 73
        '
        'grup_level2
        '
        Me.grup_level2.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level2.Caption = "Grup level 2"
        Me.grup_level2.FieldName = "grup_level2"
        Me.grup_level2.Name = "grup_level2"
        Me.grup_level2.Visible = True
        Me.grup_level2.VisibleIndex = 7
        Me.grup_level2.Width = 78
        '
        'grup_level3
        '
        Me.grup_level3.AppearanceHeader.Options.UseTextOptions = True
        Me.grup_level3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grup_level3.Caption = "Grup Level 3"
        Me.grup_level3.FieldName = "grup_level3"
        Me.grup_level3.Name = "grup_level3"
        Me.grup_level3.Visible = True
        Me.grup_level3.VisibleIndex = 8
        Me.grup_level3.Width = 78
        '
        'div1
        '
        Me.div1.AppearanceHeader.Options.UseTextOptions = True
        Me.div1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div1.Caption = "Flag Kasir"
        Me.div1.ColumnEdit = Me.CekStat
        Me.div1.FieldName = "div1"
        Me.div1.Name = "div1"
        Me.div1.Visible = True
        Me.div1.VisibleIndex = 9
        Me.div1.Width = 66
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "Aktif"
        Me.CekStat.DisplayValueChecked = "Aktif"
        Me.CekStat.DisplayValueUnchecked = "NonAktif"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'div2
        '
        Me.div2.AppearanceHeader.Options.UseTextOptions = True
        Me.div2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div2.Caption = "Flag Htg"
        Me.div2.ColumnEdit = Me.CekStat
        Me.div2.FieldName = "div2"
        Me.div2.Name = "div2"
        Me.div2.Width = 66
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
        Me.Rec_stat.VisibleIndex = 10
        Me.Rec_stat.Width = 77
        '
        'pola_entry
        '
        Me.pola_entry.Caption = "Unit"
        Me.pola_entry.ColumnEdit = Me.LuvUnit
        Me.pola_entry.FieldName = "pola_entry"
        Me.pola_entry.Name = "pola_entry"
        Me.pola_entry.Visible = True
        Me.pola_entry.VisibleIndex = 5
        Me.pola_entry.Width = 99
        '
        'LuvUnit
        '
        Me.LuvUnit.AutoHeight = False
        Me.LuvUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LuvUnit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Unit")})
        Me.LuvUnit.DisplayMember = "Desc_Data"
        Me.LuvUnit.Name = "LuvUnit"
        Me.LuvUnit.NullText = "[Unit]"
        Me.LuvUnit.ShowFooter = False
        Me.LuvUnit.ShowHeader = False
        Me.LuvUnit.ShowPopupShadow = False
        Me.LuvUnit.ValueMember = "Val_kode1"
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
        Me.Panel2.Location = New System.Drawing.Point(0, 398)
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE BUKU BESAR (COA)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstCOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 435)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstCOA"
        Me.Text = "frmMstCOA"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMstCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookCFlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LU_Valuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuvUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcMstCOA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstCOA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grup_level3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents kd_val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LU_Valuta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents div1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents div2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pola_entry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LuvUnit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cflow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookCFlow As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
