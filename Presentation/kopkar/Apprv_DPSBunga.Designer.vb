<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apprv_DPSBunga
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Apprv_DPSBunga))
        Me.gv_tbh_krd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.trans_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_tbh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GV_AppBgDps = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NASABAH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SALDO_AWAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_REGISTRASI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_bunga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_bg_gros = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_bg_net = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total_dps = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_pajak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kabag_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_stat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.Btn_pilih = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_AppBgDps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_tbh_krd
        '
        Me.gv_tbh_krd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.trans_tbh, Me.no_tbh, Me.jns_tbh, Me.rp_tbh})
        Me.gv_tbh_krd.GridControl = Me.GcINV_Ret
        Me.gv_tbh_krd.Name = "gv_tbh_krd"
        '
        'trans_tbh
        '
        Me.trans_tbh.Caption = "no_trans"
        Me.trans_tbh.FieldName = "no_trans"
        Me.trans_tbh.Name = "trans_tbh"
        Me.trans_tbh.Visible = True
        Me.trans_tbh.VisibleIndex = 3
        Me.trans_tbh.Width = 241
        '
        'no_tbh
        '
        Me.no_tbh.Caption = "No"
        Me.no_tbh.FieldName = "no_seq"
        Me.no_tbh.Name = "no_tbh"
        Me.no_tbh.Visible = True
        Me.no_tbh.VisibleIndex = 0
        Me.no_tbh.Width = 25
        '
        'jns_tbh
        '
        Me.jns_tbh.Caption = "Jenis"
        Me.jns_tbh.FieldName = "jenis"
        Me.jns_tbh.Name = "jns_tbh"
        Me.jns_tbh.Visible = True
        Me.jns_tbh.VisibleIndex = 1
        Me.jns_tbh.Width = 348
        '
        'rp_tbh
        '
        Me.rp_tbh.Caption = "Rp"
        Me.rp_tbh.FieldName = "nilai"
        Me.rp_tbh.Name = "rp_tbh"
        Me.rp_tbh.Visible = True
        Me.rp_tbh.VisibleIndex = 2
        Me.rp_tbh.Width = 351
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gv_tbh_krd
        GridLevelNode1.RelationName = "Level1"
        Me.GcINV_Ret.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GV_AppBgDps
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RLnama, Me.RL_stat})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1226, 242)
        Me.GcINV_Ret.TabIndex = 6
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_AppBgDps, Me.gv_tbh_krd})
        '
        'GV_AppBgDps
        '
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.Empty.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_AppBgDps.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_AppBgDps.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GV_AppBgDps.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GV_AppBgDps.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GV_AppBgDps.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_AppBgDps.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GV_AppBgDps.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV_AppBgDps.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GV_AppBgDps.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GV_AppBgDps.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GV_AppBgDps.Appearance.Preview.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.Preview.Options.UseBorderColor = True
        Me.GV_AppBgDps.Appearance.Preview.Options.UseFont = True
        Me.GV_AppBgDps.Appearance.Preview.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GV_AppBgDps.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_AppBgDps.Appearance.Row.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.Row.Options.UseForeColor = True
        Me.GV_AppBgDps.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV_AppBgDps.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GV_AppBgDps.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_AppBgDps.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_AppBgDps.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GV_AppBgDps.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_AppBgDps.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.NO_TABUNGAN, Me.NASABAH_ID, Me.Nama, Me.SALDO_AWAL, Me.TGL_REGISTRASI, Me.TGL_TRANS, Me.gc_bunga, Me.rp_bg_gros, Me.rp_bg_net, Me.total_dps, Me.rp_pajak, Me.no_rek, Me.kabag_approve})
        Me.GV_AppBgDps.GridControl = Me.GcINV_Ret
        Me.GV_AppBgDps.Name = "GV_AppBgDps"
        Me.GV_AppBgDps.OptionsCustomization.AllowColumnMoving = False
        Me.GV_AppBgDps.OptionsCustomization.AllowFilter = False
        Me.GV_AppBgDps.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_AppBgDps.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_AppBgDps.OptionsView.EnableAppearanceOddRow = True
        Me.GV_AppBgDps.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_AppBgDps.OptionsView.RowAutoHeight = True
        Me.GV_AppBgDps.OptionsView.ShowFooter = True
        Me.GV_AppBgDps.OptionsView.ShowViewCaption = True
        Me.GV_AppBgDps.ViewCaption = "APPROVAL KABAG"
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 35
        '
        'NO_TABUNGAN
        '
        Me.NO_TABUNGAN.Caption = "No Bilyet"
        Me.NO_TABUNGAN.FieldName = "NO_TABUNGAN"
        Me.NO_TABUNGAN.Name = "NO_TABUNGAN"
        Me.NO_TABUNGAN.OptionsColumn.AllowEdit = False
        Me.NO_TABUNGAN.OptionsColumn.ReadOnly = True
        Me.NO_TABUNGAN.Visible = True
        Me.NO_TABUNGAN.VisibleIndex = 3
        Me.NO_TABUNGAN.Width = 71
        '
        'NASABAH_ID
        '
        Me.NASABAH_ID.Caption = "ID Nasabah"
        Me.NASABAH_ID.FieldName = "NASABAH_ID"
        Me.NASABAH_ID.Name = "NASABAH_ID"
        Me.NASABAH_ID.OptionsColumn.AllowEdit = False
        Me.NASABAH_ID.OptionsColumn.ReadOnly = True
        Me.NASABAH_ID.Visible = True
        Me.NASABAH_ID.VisibleIndex = 1
        Me.NASABAH_ID.Width = 47
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "NASABAH_ID"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 2
        Me.Nama.Width = 227
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'SALDO_AWAL
        '
        Me.SALDO_AWAL.Caption = "Nilai Deposito"
        Me.SALDO_AWAL.DisplayFormat.FormatString = "n0"
        Me.SALDO_AWAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AWAL.FieldName = "SALDO_AWAL"
        Me.SALDO_AWAL.Name = "SALDO_AWAL"
        Me.SALDO_AWAL.OptionsColumn.AllowEdit = False
        Me.SALDO_AWAL.OptionsColumn.ReadOnly = True
        Me.SALDO_AWAL.SummaryItem.DisplayFormat = "{0:n0}"
        Me.SALDO_AWAL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.SALDO_AWAL.Visible = True
        Me.SALDO_AWAL.VisibleIndex = 6
        Me.SALDO_AWAL.Width = 85
        '
        'TGL_REGISTRASI
        '
        Me.TGL_REGISTRASI.Caption = "Tgl Reg"
        Me.TGL_REGISTRASI.FieldName = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.Name = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.OptionsColumn.AllowEdit = False
        Me.TGL_REGISTRASI.OptionsColumn.ReadOnly = True
        Me.TGL_REGISTRASI.Visible = True
        Me.TGL_REGISTRASI.VisibleIndex = 8
        Me.TGL_REGISTRASI.Width = 73
        '
        'TGL_TRANS
        '
        Me.TGL_TRANS.Caption = "Jatuh Tempo"
        Me.TGL_TRANS.FieldName = "TGL_TRANS"
        Me.TGL_TRANS.Name = "TGL_TRANS"
        Me.TGL_TRANS.OptionsColumn.AllowEdit = False
        Me.TGL_TRANS.OptionsColumn.ReadOnly = True
        Me.TGL_TRANS.Visible = True
        Me.TGL_TRANS.VisibleIndex = 9
        Me.TGL_TRANS.Width = 74
        '
        'gc_bunga
        '
        Me.gc_bunga.Caption = "Bunga"
        Me.gc_bunga.FieldName = "bunga"
        Me.gc_bunga.Name = "gc_bunga"
        Me.gc_bunga.OptionsColumn.AllowEdit = False
        Me.gc_bunga.OptionsColumn.ReadOnly = True
        Me.gc_bunga.Visible = True
        Me.gc_bunga.VisibleIndex = 7
        Me.gc_bunga.Width = 47
        '
        'rp_bg_gros
        '
        Me.rp_bg_gros.Caption = "Bunga Gros"
        Me.rp_bg_gros.DisplayFormat.FormatString = "n0"
        Me.rp_bg_gros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_bg_gros.FieldName = "rp_bg_gros"
        Me.rp_bg_gros.Name = "rp_bg_gros"
        Me.rp_bg_gros.OptionsColumn.AllowEdit = False
        Me.rp_bg_gros.OptionsColumn.ReadOnly = True
        Me.rp_bg_gros.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rp_bg_gros.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_bg_gros.Visible = True
        Me.rp_bg_gros.VisibleIndex = 10
        Me.rp_bg_gros.Width = 73
        '
        'rp_bg_net
        '
        Me.rp_bg_net.Caption = "Bunga Netto"
        Me.rp_bg_net.DisplayFormat.FormatString = "n0"
        Me.rp_bg_net.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_bg_net.FieldName = "rp_bg_net"
        Me.rp_bg_net.Name = "rp_bg_net"
        Me.rp_bg_net.OptionsColumn.AllowEdit = False
        Me.rp_bg_net.OptionsColumn.ReadOnly = True
        Me.rp_bg_net.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rp_bg_net.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_bg_net.Visible = True
        Me.rp_bg_net.VisibleIndex = 12
        Me.rp_bg_net.Width = 99
        '
        'total_dps
        '
        Me.total_dps.Caption = "Tot Deposito"
        Me.total_dps.DisplayFormat.FormatString = "n0"
        Me.total_dps.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total_dps.FieldName = "total_dps"
        Me.total_dps.Name = "total_dps"
        Me.total_dps.OptionsColumn.AllowEdit = False
        Me.total_dps.OptionsColumn.ReadOnly = True
        Me.total_dps.SummaryItem.DisplayFormat = "{0:n0}"
        Me.total_dps.SummaryItem.FieldName = "total_bg_dps"
        Me.total_dps.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total_dps.Visible = True
        Me.total_dps.VisibleIndex = 5
        Me.total_dps.Width = 119
        '
        'rp_pajak
        '
        Me.rp_pajak.Caption = "Pajak"
        Me.rp_pajak.DisplayFormat.FormatString = "n0"
        Me.rp_pajak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_pajak.FieldName = "rp_pajak"
        Me.rp_pajak.Name = "rp_pajak"
        Me.rp_pajak.OptionsColumn.AllowEdit = False
        Me.rp_pajak.OptionsColumn.ReadOnly = True
        Me.rp_pajak.SummaryItem.DisplayFormat = "{0:n0}"
        Me.rp_pajak.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_pajak.Visible = True
        Me.rp_pajak.VisibleIndex = 11
        Me.rp_pajak.Width = 59
        '
        'no_rek
        '
        Me.no_rek.Caption = "Rekening"
        Me.no_rek.FieldName = "no_rek"
        Me.no_rek.Name = "no_rek"
        Me.no_rek.OptionsColumn.AllowEdit = False
        Me.no_rek.OptionsColumn.ReadOnly = True
        Me.no_rek.Visible = True
        Me.no_rek.VisibleIndex = 4
        Me.no_rek.Width = 110
        '
        'kabag_approve
        '
        Me.kabag_approve.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kabag_approve.AppearanceCell.Options.UseBackColor = True
        Me.kabag_approve.Caption = "Approve Kabag"
        Me.kabag_approve.FieldName = "kabag_approve"
        Me.kabag_approve.Name = "kabag_approve"
        Me.kabag_approve.Visible = True
        Me.kabag_approve.VisibleIndex = 13
        Me.kabag_approve.Width = 86
        '
        'RL_stat
        '
        Me.RL_stat.AutoHeight = False
        Me.RL_stat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_stat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("keterangan", "keterangan")})
        Me.RL_stat.Name = "RL_stat"
        Me.RL_stat.NullText = ""
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(169, 12)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(116, 20)
        Me.tglsampai.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Controls.Add(Me.Btn_pilih)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1226, 42)
        Me.Panel2.TabIndex = 7
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(708, 0)
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
        Me.cmdRefresh.Location = New System.Drawing.Point(659, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(102, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(557, 42)
        Me.Panel6.TabIndex = 32
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(6, 12)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "s/d"
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
        Me.Label4.Text = "Filter Tanggal Cair : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(679, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "            APPROVAL PEMBAYARAN BUNGA DEPOSITO DAN RETUR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
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
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 284)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1226, 25)
        Me.Panel4.TabIndex = 1
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1226, 242)
        Me.Panel5.TabIndex = 2
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
        Me.Panel1.Size = New System.Drawing.Size(1226, 38)
        Me.Panel1.TabIndex = 165
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1226, 42)
        Me.Panel3.TabIndex = 0
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
        Me.pnl.Size = New System.Drawing.Size(1226, 309)
        Me.pnl.TabIndex = 166
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Btn_pilih
        '
        Me.Btn_pilih.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_pilih.ImageIndex = 3
        Me.Btn_pilih.ImageList = Me.img
        Me.Btn_pilih.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Btn_pilih.Location = New System.Drawing.Point(757, 0)
        Me.Btn_pilih.LookAndFeel.SkinName = "The Asphalt World"
        Me.Btn_pilih.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(109, 42)
        Me.Btn_pilih.TabIndex = 43
        Me.Btn_pilih.Text = "Approve ALL"
        Me.Btn_pilih.ToolTip = "Celar Filter"
        '
        'Apprv_DPSBunga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 347)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Apprv_DPSBunga"
        Me.Text = "Apprv_DPSBunga"
        CType(Me.gv_tbh_krd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_AppBgDps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_stat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_tbh_krd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trans_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jns_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_tbh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_AppBgDps As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NASABAH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SALDO_AWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_REGISTRASI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_stat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents gc_bunga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_bg_gros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_bg_net As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total_dps As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_pajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kabag_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Btn_pilih As DevExpress.XtraEditors.SimpleButton
End Class
