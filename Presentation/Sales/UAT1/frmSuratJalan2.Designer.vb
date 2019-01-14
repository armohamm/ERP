<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuratJalan2
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuratJalan2))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sju = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_customeru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_sopiru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSopir = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.uno_pol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNoPol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_spu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alasan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnCetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCetak = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cetak_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kendaraan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_sopir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_cetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_rcn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_polM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_sopirM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kenekM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetakM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGLCETAK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCetaku = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.GVBuatUlang = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rJenisSp = New DevExpress.XtraEditors.RadioGroup
        Me.SJ_BARU = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Cetak_Ulang = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSopir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNoPol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCetak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCetaku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBuatUlang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.rJenisSp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVD
        '
        Me.GVD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.Empty.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.OddRow.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.Options.UseForeColor = True
        Me.GVD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVD.Appearance.Preview.Options.UseBackColor = True
        Me.GVD.Appearance.Preview.Options.UseFont = True
        Me.GVD.Appearance.Preview.Options.UseForeColor = True
        Me.GVD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.Row.Options.UseBackColor = True
        Me.GVD.Appearance.Row.Options.UseBorderColor = True
        Me.GVD.Appearance.Row.Options.UseForeColor = True
        Me.GVD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.VertLine.Options.UseBackColor = True
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sju, Me.kd_customeru, Me.kd_sopiru, Me.uno_pol, Me.no_spu, Me.Alasan, Me.btnCetak, Me.cetak_ke, Me.GridColumn1, Me.GridColumn5, Me.GridColumn6})
        Me.GVD.GridControl = Me.GC
        Me.GVD.GroupCount = 1
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.uno_pol, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'no_sju
        '
        Me.no_sju.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sju.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sju.Caption = "Nomor SJ"
        Me.no_sju.FieldName = "no_sj"
        Me.no_sju.Name = "no_sju"
        Me.no_sju.OptionsColumn.AllowEdit = False
        Me.no_sju.OptionsColumn.AllowFocus = False
        Me.no_sju.Visible = True
        Me.no_sju.VisibleIndex = 0
        Me.no_sju.Width = 163
        '
        'kd_customeru
        '
        Me.kd_customeru.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_customeru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_customeru.Caption = "Customer"
        Me.kd_customeru.ColumnEdit = Me.repCustomer
        Me.kd_customeru.FieldName = "kd_customer"
        Me.kd_customeru.Name = "kd_customeru"
        Me.kd_customeru.OptionsColumn.AllowEdit = False
        Me.kd_customeru.OptionsColumn.AllowFocus = False
        Me.kd_customeru.Visible = True
        Me.kd_customeru.VisibleIndex = 1
        Me.kd_customeru.Width = 163
        '
        'repCustomer
        '
        Me.repCustomer.AutoHeight = False
        Me.repCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Customer", "Customer")})
        Me.repCustomer.DisplayMember = "Nama_Customer"
        Me.repCustomer.Name = "repCustomer"
        Me.repCustomer.NullText = "n/a"
        Me.repCustomer.ValueMember = "Kd_Customer"
        '
        'kd_sopiru
        '
        Me.kd_sopiru.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_sopiru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_sopiru.Caption = "Sopir"
        Me.kd_sopiru.ColumnEdit = Me.repSopir
        Me.kd_sopiru.FieldName = "Kd_sopir"
        Me.kd_sopiru.Name = "kd_sopiru"
        Me.kd_sopiru.OptionsColumn.AllowEdit = False
        Me.kd_sopiru.OptionsColumn.AllowFocus = False
        Me.kd_sopiru.Visible = True
        Me.kd_sopiru.VisibleIndex = 3
        Me.kd_sopiru.Width = 196
        '
        'repSopir
        '
        Me.repSopir.AutoHeight = False
        Me.repSopir.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSopir.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sopir", "Sopir")})
        Me.repSopir.DisplayMember = "Nama_Sopir"
        Me.repSopir.Name = "repSopir"
        Me.repSopir.NullText = "n/a"
        Me.repSopir.ValueMember = "Kode_Sopir"
        '
        'uno_pol
        '
        Me.uno_pol.AppearanceHeader.Options.UseTextOptions = True
        Me.uno_pol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.uno_pol.Caption = "Kendaraan"
        Me.uno_pol.ColumnEdit = Me.repNoPol
        Me.uno_pol.FieldName = "No_pol"
        Me.uno_pol.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.uno_pol.Name = "uno_pol"
        Me.uno_pol.OptionsColumn.AllowEdit = False
        Me.uno_pol.OptionsColumn.AllowFocus = False
        Me.uno_pol.Visible = True
        Me.uno_pol.VisibleIndex = 4
        Me.uno_pol.Width = 186
        '
        'repNoPol
        '
        Me.repNoPol.AutoHeight = False
        Me.repNoPol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repNoPol.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Kendaraan", "Kendaraan")})
        Me.repNoPol.DisplayMember = "Nama_Kendaraan"
        Me.repNoPol.Name = "repNoPol"
        Me.repNoPol.NullText = "n/a"
        Me.repNoPol.ValueMember = "Kode_Kendaraan"
        '
        'no_spu
        '
        Me.no_spu.AppearanceHeader.Options.UseTextOptions = True
        Me.no_spu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_spu.Caption = "Nomor SP"
        Me.no_spu.FieldName = "No_sp"
        Me.no_spu.Name = "no_spu"
        Me.no_spu.OptionsColumn.AllowEdit = False
        Me.no_spu.OptionsColumn.AllowFocus = False
        Me.no_spu.Visible = True
        Me.no_spu.VisibleIndex = 2
        Me.no_spu.Width = 163
        '
        'Alasan
        '
        Me.Alasan.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.Alasan.AppearanceCell.Options.UseForeColor = True
        Me.Alasan.AppearanceHeader.Options.UseTextOptions = True
        Me.Alasan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Alasan.Caption = "Status"
        Me.Alasan.FieldName = "Sts"
        Me.Alasan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Alasan.Name = "Alasan"
        Me.Alasan.OptionsColumn.AllowEdit = False
        Me.Alasan.OptionsColumn.AllowFocus = False
        Me.Alasan.Visible = True
        Me.Alasan.VisibleIndex = 6
        Me.Alasan.Width = 179
        '
        'btnCetak
        '
        Me.btnCetak.AppearanceHeader.Options.UseTextOptions = True
        Me.btnCetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnCetak.ColumnEdit = Me.repCetak
        Me.btnCetak.FieldName = "cetak"
        Me.btnCetak.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.OptionsColumn.AllowMove = False
        Me.btnCetak.OptionsColumn.AllowShowHide = False
        Me.btnCetak.OptionsColumn.AllowSize = False
        Me.btnCetak.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.btnCetak.Visible = True
        Me.btnCetak.VisibleIndex = 5
        Me.btnCetak.Width = 55
        '
        'repCetak
        '
        Me.repCetak.AutoHeight = False
        Me.repCetak.Name = "repCetak"
        Me.repCetak.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repCetak.ValueChecked = "1"
        Me.repCetak.ValueUnchecked = "0"
        '
        'cetak_ke
        '
        Me.cetak_ke.Caption = "GridColumn1"
        Me.cetak_ke.FieldName = "cetak_ke"
        Me.cetak_ke.Name = "cetak_ke"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Tgl_Cetak"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Buat Ulang"
        Me.GridColumn5.ColumnEdit = Me.repCetak
        Me.GridColumn5.FieldName = "BU"
        Me.GridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nomor Kirim"
        Me.GridColumn6.FieldName = "no_krm"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVD
        GridLevelNode1.RelationName = "SJ"
        GridLevelNode2.LevelTemplate = Me.GV
        GridLevelNode2.RelationName = "DPM"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 37)
        Me.GC.MainView = Me.GVM
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCetak, Me.repNoPol, Me.repSopir, Me.repCustomer, Me.RepositoryItemDateEdit1, Me.repCetaku})
        Me.GC.Size = New System.Drawing.Size(944, 335)
        Me.GC.TabIndex = 2
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVM, Me.GVBuatUlang, Me.GVD})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseBorderColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_trans, Me.no_sp, Me.Kendaraan, Me.kd_sopir, Me.no_sj, Me.Customer, Me.cetak, Me.tgl_cetak, Me.Status, Me.tgl_rcn})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.no_sj
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "PROSES"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.no_sj
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "PROSES"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.cetak
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "1"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowColumnResizing = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'no_trans
        '
        Me.no_trans.Caption = "Nomor DPB"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 0
        Me.no_trans.Width = 144
        '
        'no_sp
        '
        Me.no_sp.Caption = "Nomor SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 2
        Me.no_sp.Width = 139
        '
        'Kendaraan
        '
        Me.Kendaraan.Caption = "Kendaraan"
        Me.Kendaraan.ColumnEdit = Me.repNoPol
        Me.Kendaraan.FieldName = "no_pol"
        Me.Kendaraan.Name = "Kendaraan"
        Me.Kendaraan.OptionsColumn.ReadOnly = True
        Me.Kendaraan.Width = 114
        '
        'kd_sopir
        '
        Me.kd_sopir.Caption = "Sopir"
        Me.kd_sopir.ColumnEdit = Me.repSopir
        Me.kd_sopir.FieldName = "kd_sopir"
        Me.kd_sopir.Name = "kd_sopir"
        Me.kd_sopir.OptionsColumn.ReadOnly = True
        Me.kd_sopir.Width = 114
        '
        'no_sj
        '
        Me.no_sj.Caption = "Nomor Surat Jalan"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.OptionsColumn.AllowEdit = False
        Me.no_sj.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.no_sj.OptionsColumn.ReadOnly = True
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 5
        Me.no_sj.Width = 111
        '
        'Customer
        '
        Me.Customer.Caption = "Customer"
        Me.Customer.ColumnEdit = Me.repCustomer
        Me.Customer.FieldName = "kd_customer"
        Me.Customer.Name = "Customer"
        Me.Customer.OptionsColumn.AllowEdit = False
        Me.Customer.OptionsColumn.ReadOnly = True
        Me.Customer.Visible = True
        Me.Customer.VisibleIndex = 3
        Me.Customer.Width = 203
        '
        'cetak
        '
        Me.cetak.Caption = "cetak"
        Me.cetak.ColumnEdit = Me.repCetak
        Me.cetak.FieldName = "cetak"
        Me.cetak.Name = "cetak"
        Me.cetak.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.cetak.Width = 43
        '
        'tgl_cetak
        '
        Me.tgl_cetak.Caption = "Tanggal Cetak"
        Me.tgl_cetak.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.tgl_cetak.FieldName = "tgl_cetak"
        Me.tgl_cetak.Name = "tgl_cetak"
        Me.tgl_cetak.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_cetak.Visible = True
        Me.tgl_cetak.VisibleIndex = 4
        Me.tgl_cetak.Width = 89
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.AllowEdit = False
        Me.Status.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 6
        Me.Status.Width = 147
        '
        'tgl_rcn
        '
        Me.tgl_rcn.Caption = "Tgl Rcn Kirim"
        Me.tgl_rcn.FieldName = "tgl_rcn"
        Me.tgl_rcn.Name = "tgl_rcn"
        Me.tgl_rcn.Visible = True
        Me.tgl_rcn.VisibleIndex = 1
        Me.tgl_rcn.Width = 90
        '
        'GVM
        '
        Me.GVM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_polM, Me.kd_sopirM, Me.kd_kenekM, Me.cetakM, Me.No_Kirim, Me.TGLCETAK})
        Me.GVM.GridControl = Me.GC
        Me.GVM.Name = "GVM"
        Me.GVM.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GVM.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVM.OptionsDetail.ShowDetailTabs = False
        Me.GVM.OptionsView.ColumnAutoWidth = False
        Me.GVM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVM.OptionsView.ShowGroupPanel = False
        '
        'no_polM
        '
        Me.no_polM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.no_polM.AppearanceCell.Options.UseFont = True
        Me.no_polM.Caption = "Kendaraan"
        Me.no_polM.ColumnEdit = Me.repNoPol
        Me.no_polM.FieldName = "no_pol"
        Me.no_polM.Name = "no_polM"
        Me.no_polM.OptionsColumn.AllowEdit = False
        Me.no_polM.Visible = True
        Me.no_polM.VisibleIndex = 1
        Me.no_polM.Width = 165
        '
        'kd_sopirM
        '
        Me.kd_sopirM.Caption = "Sopir"
        Me.kd_sopirM.ColumnEdit = Me.repSopir
        Me.kd_sopirM.FieldName = "kd_sopir"
        Me.kd_sopirM.Name = "kd_sopirM"
        Me.kd_sopirM.OptionsColumn.AllowEdit = False
        Me.kd_sopirM.Visible = True
        Me.kd_sopirM.VisibleIndex = 2
        Me.kd_sopirM.Width = 191
        '
        'kd_kenekM
        '
        Me.kd_kenekM.Caption = "Asisten Sopir"
        Me.kd_kenekM.ColumnEdit = Me.repSopir
        Me.kd_kenekM.FieldName = "kd_kenek"
        Me.kd_kenekM.Name = "kd_kenekM"
        Me.kd_kenekM.OptionsColumn.AllowEdit = False
        Me.kd_kenekM.Visible = True
        Me.kd_kenekM.VisibleIndex = 3
        Me.kd_kenekM.Width = 195
        '
        'cetakM
        '
        Me.cetakM.AppearanceHeader.Options.UseTextOptions = True
        Me.cetakM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cetakM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cetakM.Caption = "Cetak"
        Me.cetakM.ColumnEdit = Me.repCetak
        Me.cetakM.FieldName = "cetak"
        Me.cetakM.Name = "cetakM"
        Me.cetakM.Visible = True
        Me.cetakM.VisibleIndex = 5
        Me.cetakM.Width = 51
        '
        'No_Kirim
        '
        Me.No_Kirim.Caption = "No Kirim"
        Me.No_Kirim.FieldName = "no_trans_krm"
        Me.No_Kirim.Name = "No_Kirim"
        Me.No_Kirim.Visible = True
        Me.No_Kirim.VisibleIndex = 0
        Me.No_Kirim.Width = 167
        '
        'TGLCETAK
        '
        Me.TGLCETAK.Caption = "Tgl Cetak"
        Me.TGLCETAK.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.TGLCETAK.FieldName = "TGLCETAK"
        Me.TGLCETAK.Name = "TGLCETAK"
        Me.TGLCETAK.Visible = True
        Me.TGLCETAK.VisibleIndex = 4
        Me.TGLCETAK.Width = 122
        '
        'repCetaku
        '
        Me.repCetaku.AutoHeight = False
        Me.repCetaku.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repCetaku.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.repCetaku.Name = "repCetaku"
        '
        'GVBuatUlang
        '
        Me.GVBuatUlang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GVBuatUlang.GridControl = Me.GC
        Me.GVBuatUlang.Name = "GVBuatUlang"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nomor SJ"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(944, 372)
        Me.pnl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.rJenisSp)
        Me.Panel1.Controls.Add(Me.SJ_BARU)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Cetak_Ulang)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 37)
        Me.Panel1.TabIndex = 1
        '
        'rJenisSp
        '
        Me.rJenisSp.Dock = System.Windows.Forms.DockStyle.Right
        Me.rJenisSp.EditValue = "%%"
        Me.rJenisSp.Location = New System.Drawing.Point(536, 0)
        Me.rJenisSp.Name = "rJenisSp"
        Me.rJenisSp.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rJenisSp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJenisSp.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.rJenisSp.Properties.Appearance.Options.UseBackColor = True
        Me.rJenisSp.Properties.Appearance.Options.UseFont = True
        Me.rJenisSp.Properties.Appearance.Options.UseForeColor = True
        Me.rJenisSp.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "SPRING"), New DevExpress.XtraEditors.Controls.RadioGroupItem("3", "SPON"), New DevExpress.XtraEditors.Controls.RadioGroupItem("4", "SEALY"), New DevExpress.XtraEditors.Controls.RadioGroupItem("%%", "ALL")})
        Me.rJenisSp.Size = New System.Drawing.Size(264, 37)
        Me.rJenisSp.TabIndex = 9
        '
        'SJ_BARU
        '
        Me.SJ_BARU.BackgroundImage = CType(resources.GetObject("SJ_BARU.BackgroundImage"), System.Drawing.Image)
        Me.SJ_BARU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SJ_BARU.Dock = System.Windows.Forms.DockStyle.Right
        Me.SJ_BARU.Image = CType(resources.GetObject("SJ_BARU.Image"), System.Drawing.Image)
        Me.SJ_BARU.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SJ_BARU.Location = New System.Drawing.Point(800, 0)
        Me.SJ_BARU.Name = "SJ_BARU"
        Me.SJ_BARU.Size = New System.Drawing.Size(48, 37)
        Me.SJ_BARU.TabIndex = 7
        Me.SJ_BARU.ToolTip = "Cetak SJ Baru"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(218, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "  CETAK SURAT JALAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Cetak_Ulang
        '
        Me.Cetak_Ulang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cetak_Ulang.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cetak_Ulang.Image = CType(resources.GetObject("Cetak_Ulang.Image"), System.Drawing.Image)
        Me.Cetak_Ulang.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Cetak_Ulang.Location = New System.Drawing.Point(848, 0)
        Me.Cetak_Ulang.Name = "Cetak_Ulang"
        Me.Cetak_Ulang.Size = New System.Drawing.Size(48, 37)
        Me.Cetak_Ulang.TabIndex = 8
        Me.Cetak_Ulang.ToolTip = "Cetak Ulang SJ"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(896, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(48, 37)
        Me.cmdRefresh.TabIndex = 6
        Me.cmdRefresh.ToolTip = "Refresh Data"
        '
        'frmSuratJalan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 372)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSuratJalan2"
        Me.Text = "frmSuratJalan2"
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSopir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNoPol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCetak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCetaku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBuatUlang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.rJenisSp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kendaraan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sopir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCetak As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repNoPol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repSopir As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tgl_cetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Cetak_Ulang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SJ_BARU As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents no_sju As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_customeru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sopiru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents uno_pol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_spu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alasan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCetaku As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cetak_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_polM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sopirM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kenekM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetakM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rJenisSp As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GVBuatUlang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_rcn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGLCETAK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
