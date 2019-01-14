<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerbaikanMaster
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repkdjenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TIPE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.subtipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repssubtipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repUkuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekJualExt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekJualInt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekReturExt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekReturInt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekBonusExt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekBonusInt = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckRekHPP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ckBom = New DevExpress.XtraEditors.CheckEdit
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repkdjenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repssubtipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekJualExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekJualInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekReturExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekReturInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekBonusExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekBonusInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckRekHPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ckBom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(976, 532)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 39)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repkdjenis, Me.repMerk, Me.repUkuran, Me.repJenis, Me.repTipe, Me.repssubtipe, Me.repKain, Me.repSatuan, Me.lckRekJualExt, Me.lckRekJualInt, Me.lckRekReturInt, Me.lckRekReturExt, Me.lckRekBonusInt, Me.lckRekBonusExt, Me.lckRekHPP})
        Me.GC.Size = New System.Drawing.Size(976, 493)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseFont = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.TIPE, Me.subtipe, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn5, Me.GridColumn6, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nama_Barang", Me.GridColumn1, "")})
        Me.GV.Name = "GV"
        Me.GV.OptionsSelection.MultiSelect = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Deskripsi"
        Me.GridColumn1.FieldName = "Nama_Barang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 199
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Jenis"
        Me.GridColumn2.ColumnEdit = Me.repJenis
        Me.GridColumn2.FieldName = "kd_jenis"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 87
        '
        'repJenis
        '
        Me.repJenis.AutoHeight = False
        Me.repJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Name1")})
        Me.repJenis.DisplayMember = "Nama_Jenis"
        Me.repJenis.Name = "repJenis"
        Me.repJenis.ValueMember = "Kd_Jns_Brg"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Persedian"
        Me.GridColumn3.ColumnEdit = Me.repkdjenis
        Me.GridColumn3.FieldName = "kd_jns_persd"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 87
        '
        'repkdjenis
        '
        Me.repkdjenis.AutoHeight = False
        Me.repkdjenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repkdjenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Persediaan", "Name2")})
        Me.repkdjenis.DisplayMember = "Nama_Persediaan"
        Me.repkdjenis.Name = "repkdjenis"
        Me.repkdjenis.ValueMember = "Kd_Jns_Persd"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Merk"
        Me.GridColumn4.ColumnEdit = Me.repMerk
        Me.GridColumn4.FieldName = "kd_merk"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 87
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Name3")})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.ValueMember = "Kode_Merk"
        '
        'TIPE
        '
        Me.TIPE.Caption = "Tipe"
        Me.TIPE.ColumnEdit = Me.repTipe
        Me.TIPE.FieldName = "kd_tipe"
        Me.TIPE.Name = "TIPE"
        Me.TIPE.Visible = True
        Me.TIPE.VisibleIndex = 5
        Me.TIPE.Width = 87
        '
        'repTipe
        '
        Me.repTipe.AutoHeight = False
        Me.repTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Name1")})
        Me.repTipe.DisplayMember = "Nama_Tipe"
        Me.repTipe.Name = "repTipe"
        Me.repTipe.ValueMember = "Kode_Tipe"
        '
        'subtipe
        '
        Me.subtipe.Caption = "Sub Tipe"
        Me.subtipe.ColumnEdit = Me.repssubtipe
        Me.subtipe.FieldName = "kd_sub_tipe"
        Me.subtipe.Name = "subtipe"
        Me.subtipe.Visible = True
        Me.subtipe.VisibleIndex = 6
        Me.subtipe.Width = 87
        '
        'repssubtipe
        '
        Me.repssubtipe.AutoHeight = False
        Me.repssubtipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repssubtipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Name2")})
        Me.repssubtipe.DisplayMember = "Nama_Sub_Tipe"
        Me.repssubtipe.Name = "repssubtipe"
        Me.repssubtipe.ValueMember = "Kd_Sub_Tipe"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Ukuran"
        Me.GridColumn7.ColumnEdit = Me.repUkuran
        Me.GridColumn7.FieldName = "kd_ukuran"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 87
        '
        'repUkuran
        '
        Me.repUkuran.AutoHeight = False
        Me.repUkuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repUkuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Name4")})
        Me.repUkuran.DisplayMember = "Nama_Ukuran"
        Me.repUkuran.Name = "repUkuran"
        Me.repUkuran.ValueMember = "Kode_Ukuran"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Kain"
        Me.GridColumn8.ColumnEdit = Me.repKain
        Me.GridColumn8.FieldName = "kd_kain"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 97
        '
        'repKain
        '
        Me.repKain.AutoHeight = False
        Me.repKain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKain.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Merk_Kain", "Name3")})
        Me.repKain.DisplayMember = "Merk_Kain"
        Me.repKain.Name = "repKain"
        Me.repKain.ValueMember = "Kode_Kain"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Satuan"
        Me.GridColumn9.ColumnEdit = Me.repSatuan
        Me.GridColumn9.FieldName = "Kd_Satuan"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 79
        '
        'repSatuan
        '
        Me.repSatuan.AutoHeight = False
        Me.repSatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Satuan", "Satuan")})
        Me.repSatuan.DisplayMember = "Kode_Satuan"
        Me.repSatuan.Name = "repSatuan"
        Me.repSatuan.ValueMember = "Kode_Satuan"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Kode Barang"
        Me.GridColumn5.FieldName = "Kode_Barang"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Departemen"
        Me.GridColumn6.FieldName = "Kd_Depart"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 58
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Rek Jual EXT"
        Me.GridColumn10.ColumnEdit = Me.lckRekJualExt
        Me.GridColumn10.FieldName = "rek_penjualan1"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 165
        '
        'lckRekJualExt
        '
        Me.lckRekJualExt.AutoHeight = False
        Me.lckRekJualExt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekJualExt.Name = "lckRekJualExt"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Rek Jual INT"
        Me.GridColumn11.ColumnEdit = Me.lckRekJualInt
        Me.GridColumn11.FieldName = "rek_penjualan2"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 184
        '
        'lckRekJualInt
        '
        Me.lckRekJualInt.AutoHeight = False
        Me.lckRekJualInt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekJualInt.Name = "lckRekJualInt"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Rek Retur EXT"
        Me.GridColumn12.ColumnEdit = Me.lckRekReturExt
        Me.GridColumn12.FieldName = "rek_retur1"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 12
        Me.GridColumn12.Width = 174
        '
        'lckRekReturExt
        '
        Me.lckRekReturExt.AutoHeight = False
        Me.lckRekReturExt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekReturExt.Name = "lckRekReturExt"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Rek Retur INT"
        Me.GridColumn13.ColumnEdit = Me.lckRekReturInt
        Me.GridColumn13.FieldName = "rek_retur2"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 13
        Me.GridColumn13.Width = 176
        '
        'lckRekReturInt
        '
        Me.lckRekReturInt.AutoHeight = False
        Me.lckRekReturInt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekReturInt.Name = "lckRekReturInt"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Rek Bonus EXT"
        Me.GridColumn14.ColumnEdit = Me.lckRekBonusExt
        Me.GridColumn14.FieldName = "rek_bonus1"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 14
        Me.GridColumn14.Width = 140
        '
        'lckRekBonusExt
        '
        Me.lckRekBonusExt.AutoHeight = False
        Me.lckRekBonusExt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekBonusExt.Name = "lckRekBonusExt"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Rek Bonus INT"
        Me.GridColumn15.ColumnEdit = Me.lckRekBonusInt
        Me.GridColumn15.FieldName = "rek_bonus2"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 15
        Me.GridColumn15.Width = 142
        '
        'lckRekBonusInt
        '
        Me.lckRekBonusInt.AutoHeight = False
        Me.lckRekBonusInt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekBonusInt.Name = "lckRekBonusInt"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Rek HPP"
        Me.GridColumn16.ColumnEdit = Me.lckRekHPP
        Me.GridColumn16.FieldName = "rek_hpp"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 16
        Me.GridColumn16.Width = 129
        '
        'lckRekHPP
        '
        Me.lckRekHPP.AutoHeight = False
        Me.lckRekHPP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckRekHPP.Name = "lckRekHPP"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckEdit1)
        Me.Panel1.Controls.Add(Me.ckBom)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 39)
        Me.Panel1.TabIndex = 5
        '
        'ckBom
        '
        Me.ckBom.Location = New System.Drawing.Point(228, 10)
        Me.ckBom.Name = "ckBom"
        Me.ckBom.Properties.Caption = "BOM"
        Me.ckBom.Size = New System.Drawing.Size(92, 19)
        Me.ckBom.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Location = New System.Drawing.Point(111, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "cetak"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "RELOAD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(866, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(304, 10)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "TIDAK ADA BOM"
        Me.CheckEdit1.Size = New System.Drawing.Size(124, 19)
        Me.CheckEdit1.TabIndex = 5
        '
        'frmPerbaikanMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 532)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPerbaikanMaster"
        Me.Text = "frmPerbaikanMaster"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repkdjenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repssubtipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekJualExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekJualInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekReturExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekReturInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekBonusExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekBonusInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckRekHPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ckBom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repkdjenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TIPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents subtipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repssubtipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repUkuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekJualExt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekJualInt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekReturExt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekReturInt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekBonusExt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekBonusInt As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckRekHPP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ckBom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
