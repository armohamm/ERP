<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifService
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifService))
        Me.GV_D = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nomor_d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repUkuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Service = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repService = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.isset = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tarif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repnum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Cabang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSubTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.txtSubTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.txtService = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.txtMerk = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtUkuran = New DevExpress.XtraEditors.LookUpEdit
        Me.txtJenis = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbljudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GV_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSubTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.txtSubTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtUkuran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV_D
        '
        Me.GV_D.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.GV_D.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GV_D.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_D.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_D.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_D.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.GV_D.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GV_D.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.GV_D.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GV_D.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_D.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_D.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_D.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_D.Appearance.Empty.Options.UseBackColor = True
        Me.GV_D.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GV_D.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GV_D.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GV_D.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GV_D.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_D.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_D.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_D.Appearance.FilterPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.GV_D.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GV_D.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_D.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GV_D.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_D.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_D.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GV_D.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_D.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy
        Me.GV_D.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_D.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_D.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_D.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_D.Appearance.FooterPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.FooterPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_D.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_D.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_D.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_D.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_D.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_D.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_D.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_D.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GV_D.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GV_D.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_D.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_D.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_D.Appearance.GroupPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.GV_D.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_D.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GV_D.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GV_D.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_D.Appearance.GroupPanel.Options.UseFont = True
        Me.GV_D.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_D.Appearance.GroupRow.BackColor = System.Drawing.Color.PeachPuff
        Me.GV_D.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_D.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_D.Appearance.HeaderPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.BurlyWood
        Me.GV_D.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_D.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_D.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_D.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_D.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_D.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_D.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GV_D.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GV_D.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_D.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_D.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.GV_D.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_D.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.GV_D.Appearance.Preview.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GV_D.Appearance.Preview.Options.UseBackColor = True
        Me.GV_D.Appearance.Preview.Options.UseForeColor = True
        Me.GV_D.Appearance.Row.BackColor = System.Drawing.Color.OldLace
        Me.GV_D.Appearance.Row.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GV_D.Appearance.Row.Options.UseBackColor = True
        Me.GV_D.Appearance.Row.Options.UseForeColor = True
        Me.GV_D.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_D.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV_D.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_D.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GV_D.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_D.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_D.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_D.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_D.Appearance.TopNewRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GV_D.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_D.Appearance.TopNewRow.Options.UseForeColor = True
        Me.GV_D.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.GV_D.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_D.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nomor_d, Me.Kd_Barang, Me.satuan, Me.qty})
        Me.GV_D.GridControl = Me.GC
        Me.GV_D.Name = "GV_D"
        Me.GV_D.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_D.OptionsView.ShowDetailButtons = False
        Me.GV_D.OptionsView.ShowGroupPanel = False
        '
        'Nomor_d
        '
        Me.Nomor_d.Caption = "Nomor_d"
        Me.Nomor_d.FieldName = "Nomor_d"
        Me.Nomor_d.Name = "Nomor_d"
        '
        'Kd_Barang
        '
        Me.Kd_Barang.Caption = "Barang"
        Me.Kd_Barang.ColumnEdit = Me.repBarang
        Me.Kd_Barang.FieldName = "Kd_Barang"
        Me.Kd_Barang.Name = "Kd_Barang"
        Me.Kd_Barang.Visible = True
        Me.Kd_Barang.VisibleIndex = 0
        Me.Kd_Barang.Width = 550
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 200, "Deskripsi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Satuan")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = ""
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.OptionsColumn.AllowEdit = False
        Me.satuan.OptionsColumn.AllowFocus = False
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 1
        Me.satuan.Width = 239
        '
        'qty
        '
        Me.qty.Caption = "Qty"
        Me.qty.FieldName = "qty"
        Me.qty.Name = "qty"
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 2
        Me.qty.Width = 94
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV_D
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 79)
        Me.GC.MainView = Me.gv
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repMerk, Me.repTipe, Me.repJenis, Me.repUkuran, Me.repService, Me.repnum, Me.repBarang, Me.repSubTipe})
        Me.GC.Size = New System.Drawing.Size(904, 351)
        Me.GC.TabIndex = 5
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GV_D})
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseFont = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseFont = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Merk, Me.Tipe, Me.Jenis, Me.Ukuran, Me.Service, Me.isset, Me.Tarif, Me.Status, Me.Kd_Cabang, Me.Nomor, Me.Kode_Sub_Tipe})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.Nomor
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        Me.gv.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gv.GridControl = Me.GC
        Me.gv.Name = "gv"
        Me.gv.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gv.OptionsDetail.ShowDetailTabs = False
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'Merk
        '
        Me.Merk.Caption = "Merk"
        Me.Merk.ColumnEdit = Me.repMerk
        Me.Merk.FieldName = "Merk"
        Me.Merk.Name = "Merk"
        Me.Merk.Visible = True
        Me.Merk.VisibleIndex = 1
        Me.Merk.Width = 165
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", 250, "Merk")})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.NullText = ""
        Me.repMerk.PopupFormMinSize = New System.Drawing.Size(250, 300)
        Me.repMerk.ValueMember = "Kode_Merk"
        '
        'Tipe
        '
        Me.Tipe.Caption = "Tipe"
        Me.Tipe.ColumnEdit = Me.repTipe
        Me.Tipe.FieldName = "Tipe"
        Me.Tipe.Name = "Tipe"
        Me.Tipe.Visible = True
        Me.Tipe.VisibleIndex = 2
        Me.Tipe.Width = 137
        '
        'repTipe
        '
        Me.repTipe.AutoHeight = False
        Me.repTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", 200, "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Tipe", 50, "Kode")})
        Me.repTipe.DisplayMember = "Nama_Tipe"
        Me.repTipe.Name = "repTipe"
        Me.repTipe.NullText = ""
        Me.repTipe.PopupFormMinSize = New System.Drawing.Size(250, 300)
        Me.repTipe.ValueMember = "Kode_Tipe"
        '
        'Jenis
        '
        Me.Jenis.Caption = "Jenis"
        Me.Jenis.ColumnEdit = Me.repJenis
        Me.Jenis.FieldName = "Jenis"
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Visible = True
        Me.Jenis.VisibleIndex = 0
        Me.Jenis.Width = 116
        '
        'repJenis
        '
        Me.repJenis.AutoHeight = False
        Me.repJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", 200, "Jenis"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Brg", 50, "Kode")})
        Me.repJenis.DisplayMember = "Nama_Jenis"
        Me.repJenis.Name = "repJenis"
        Me.repJenis.NullText = ""
        Me.repJenis.PopupFormMinSize = New System.Drawing.Size(250, 300)
        Me.repJenis.ValueMember = "Kd_Jns_Brg"
        '
        'Ukuran
        '
        Me.Ukuran.Caption = "Ukuran"
        Me.Ukuran.ColumnEdit = Me.repUkuran
        Me.Ukuran.FieldName = "Ukuran"
        Me.Ukuran.Name = "Ukuran"
        Me.Ukuran.Visible = True
        Me.Ukuran.VisibleIndex = 4
        Me.Ukuran.Width = 115
        '
        'repUkuran
        '
        Me.repUkuran.AutoHeight = False
        Me.repUkuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repUkuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", 200, "Ukuran"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", 50, "Kode")})
        Me.repUkuran.DisplayMember = "Nama_Ukuran"
        Me.repUkuran.Name = "repUkuran"
        Me.repUkuran.NullText = ""
        Me.repUkuran.ValueMember = "Kode_Ukuran"
        '
        'Service
        '
        Me.Service.Caption = "Service"
        Me.Service.ColumnEdit = Me.repService
        Me.Service.FieldName = "Service"
        Me.Service.Name = "Service"
        Me.Service.Visible = True
        Me.Service.VisibleIndex = 5
        Me.Service.Width = 106
        '
        'repService
        '
        Me.repService.AutoHeight = False
        Me.repService.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repService.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_service", "Service")})
        Me.repService.DisplayMember = "nama_service"
        Me.repService.Name = "repService"
        Me.repService.NullText = ""
        Me.repService.ValueMember = "kd_service"
        '
        'isset
        '
        Me.isset.Caption = "isset"
        Me.isset.FieldName = "isset"
        Me.isset.Name = "isset"
        '
        'Tarif
        '
        Me.Tarif.Caption = "Tarif"
        Me.Tarif.ColumnEdit = Me.repnum
        Me.Tarif.DisplayFormat.FormatString = "N2"
        Me.Tarif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tarif.FieldName = "Tarif"
        Me.Tarif.Name = "Tarif"
        Me.Tarif.Visible = True
        Me.Tarif.VisibleIndex = 6
        Me.Tarif.Width = 70
        '
        'repnum
        '
        Me.repnum.AutoHeight = False
        Me.repnum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repnum.DisplayFormat.FormatString = "n2"
        Me.repnum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repnum.EditFormat.FormatString = "n2"
        Me.repnum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repnum.Name = "repnum"
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "rec_stat"
        Me.Status.Name = "Status"
        Me.Status.ToolTip = "Aktif (Y) Atau Tidak Aktif (T)"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 7
        Me.Status.Width = 48
        '
        'Kd_Cabang
        '
        Me.Kd_Cabang.Caption = "GridColumn1"
        Me.Kd_Cabang.FieldName = "Kd_Cabang"
        Me.Kd_Cabang.Name = "Kd_Cabang"
        '
        'Nomor
        '
        Me.Nomor.Caption = "Nomor"
        Me.Nomor.FieldName = "Nomor"
        Me.Nomor.Name = "Nomor"
        '
        'Kode_Sub_Tipe
        '
        Me.Kode_Sub_Tipe.Caption = "Sub Tipe"
        Me.Kode_Sub_Tipe.ColumnEdit = Me.repSubTipe
        Me.Kode_Sub_Tipe.FieldName = "Sub_Tipe"
        Me.Kode_Sub_Tipe.Name = "Kode_Sub_Tipe"
        Me.Kode_Sub_Tipe.Visible = True
        Me.Kode_Sub_Tipe.VisibleIndex = 3
        Me.Kode_Sub_Tipe.Width = 126
        '
        'repSubTipe
        '
        Me.repSubTipe.AutoHeight = False
        Me.repSubTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSubTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Nama Sub Tipe")})
        Me.repSubTipe.DisplayMember = "Nama_Sub_Tipe"
        Me.repSubTipe.Name = "repSubTipe"
        Me.repSubTipe.NullText = ""
        Me.repSubTipe.ValueMember = "Kd_Sub_Tipe"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(904, 430)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 42)
        Me.Panel2.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtSubTipe)
        Me.Panel8.Controls.Add(Me.txtService)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(581, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(190, 42)
        Me.Panel8.TabIndex = 2
        '
        'txtSubTipe
        '
        Me.txtSubTipe.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSubTipe.Location = New System.Drawing.Point(0, 0)
        Me.txtSubTipe.Name = "txtSubTipe"
        Me.txtSubTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSubTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", 150, "Sub Tipe")})
        Me.txtSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
        Me.txtSubTipe.Properties.NullText = ""
        Me.txtSubTipe.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        Me.txtSubTipe.Size = New System.Drawing.Size(190, 20)
        Me.txtSubTipe.TabIndex = 0
        '
        'txtService
        '
        Me.txtService.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtService.Location = New System.Drawing.Point(0, 22)
        Me.txtService.Name = "txtService"
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtService.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_service", 150, "Service")})
        Me.txtService.Properties.DisplayMember = "nama_service"
        Me.txtService.Properties.NullText = ""
        Me.txtService.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtService.Properties.ValueMember = "kd_service"
        Me.txtService.Size = New System.Drawing.Size(190, 20)
        Me.txtService.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(494, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(87, 42)
        Me.Panel7.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SubTipe : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Service : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(862, 0)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(42, 42)
        Me.cmdClear.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtTipe)
        Me.Panel6.Controls.Add(Me.txtMerk)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(334, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(160, 42)
        Me.Panel6.TabIndex = 1
        '
        'txtTipe
        '
        Me.txtTipe.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtTipe.Location = New System.Drawing.Point(0, 22)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", 150, "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Tipe", 50, "Kode")})
        Me.txtTipe.Properties.DisplayMember = "Nama_Tipe"
        Me.txtTipe.Properties.NullText = ""
        Me.txtTipe.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtTipe.Properties.ValueMember = "Kode_Tipe"
        Me.txtTipe.Size = New System.Drawing.Size(160, 20)
        Me.txtTipe.TabIndex = 1
        '
        'txtMerk
        '
        Me.txtMerk.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMerk.Location = New System.Drawing.Point(0, 0)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", 150, "Merk"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Merk", 50, "Kode")})
        Me.txtMerk.Properties.DisplayMember = "Nama_Merk"
        Me.txtMerk.Properties.NullText = ""
        Me.txtMerk.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtMerk.Properties.ValueMember = "Kode_Merk"
        Me.txtMerk.Size = New System.Drawing.Size(160, 20)
        Me.txtMerk.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(247, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(87, 42)
        Me.Panel5.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipe : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Merk : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtUkuran)
        Me.Panel3.Controls.Add(Me.txtJenis)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(87, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 42)
        Me.Panel3.TabIndex = 0
        '
        'txtUkuran
        '
        Me.txtUkuran.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUkuran.Location = New System.Drawing.Point(0, 22)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUkuran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", 150, "Ukuran"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Ukuran", 50, "Kode")})
        Me.txtUkuran.Properties.DisplayMember = "Nama_Ukuran"
        Me.txtUkuran.Properties.NullText = ""
        Me.txtUkuran.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtUkuran.Properties.ValueMember = "Kode_Ukuran"
        Me.txtUkuran.Size = New System.Drawing.Size(160, 20)
        Me.txtUkuran.TabIndex = 1
        '
        'txtJenis
        '
        Me.txtJenis.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJenis.Location = New System.Drawing.Point(0, 0)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", 150, "Jenis"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Jns_Brg", 50, "Kode")})
        Me.txtJenis.Properties.DisplayMember = "Nama_Jenis"
        Me.txtJenis.Properties.NullText = ""
        Me.txtJenis.Properties.PopupFormMinSize = New System.Drawing.Size(300, 300)
        Me.txtJenis.Properties.ValueMember = "Kd_Jns_Brg"
        Me.txtJenis.Size = New System.Drawing.Size(160, 20)
        Me.txtJenis.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(87, 42)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ukuran : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Jenis : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbljudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 37)
        Me.Panel1.TabIndex = 3
        '
        'lbljudul
        '
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbljudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.Gold
        Me.lbljudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbljudul.Location = New System.Drawing.Point(38, 0)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(349, 35)
        Me.lbljudul.TabIndex = 9
        Me.lbljudul.Text = "FORM TARIF JASA SERVICE"
        Me.lbljudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmTarifService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 430)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmTarifService"
        Me.Text = "frmTarifService"
        CType(Me.GV_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSubTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.txtSubTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtUkuran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbljudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tarif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMerk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtService As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtUkuran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repUkuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repService As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Kd_Cabang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repnum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GV_D As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nomor_d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSubTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Kode_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSubTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
