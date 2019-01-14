<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRcnRphCen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRcnRphCen))
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_Produksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clSimpan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSimpan = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.subGV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panjang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lebar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tebal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MainGV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clJnsBrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clKapasitas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJnsBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtJadwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtDPB = New System.Windows.Forms.TextBox
        Me.txtTgl_Rph = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJnsBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupButton.Options.UseForeColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseFont = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.nama_barang, Me.qty, Me.tgl_kirim, Me.prioritas, Me.Qty_Produksi, Me.Indeks, Me.clSimpan})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.PaintStyleName = "Skin"
        Me.gv.ViewCaption = "DAFTAR SALES ORDER"
        '
        'no_sp
        '
        Me.no_sp.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.no_sp.AppearanceCell.Options.UseBorderColor = True
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.no_sp.Caption = "No SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 159
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.nama_barang.AppearanceCell.Options.UseBorderColor = True
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.nama_barang.Caption = "Barang"
        Me.nama_barang.FieldName = "Nama_Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.OptionsColumn.ReadOnly = True
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 1
        Me.nama_barang.Width = 267
        '
        'qty
        '
        Me.qty.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.qty.AppearanceCell.Options.UseBorderColor = True
        Me.qty.AppearanceCell.Options.UseTextOptions = True
        Me.qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.qty.AppearanceHeader.Options.UseTextOptions = True
        Me.qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.qty.Caption = "Sisa"
        Me.qty.FieldName = "Sisa"
        Me.qty.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.qty.Name = "qty"
        Me.qty.OptionsColumn.AllowEdit = False
        Me.qty.OptionsColumn.ReadOnly = True
        Me.qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 2
        Me.qty.Width = 83
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.tgl_kirim.AppearanceCell.Options.UseBorderColor = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tgl_kirim.Caption = "Tgl. Kirim"
        Me.tgl_kirim.DisplayFormat.FormatString = "d"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 83
        '
        'prioritas
        '
        Me.prioritas.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.prioritas.AppearanceCell.Options.UseBorderColor = True
        Me.prioritas.AppearanceHeader.Options.UseTextOptions = True
        Me.prioritas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prioritas.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.prioritas.Caption = "Prioritas"
        Me.prioritas.FieldName = "prioritas"
        Me.prioritas.Name = "prioritas"
        Me.prioritas.OptionsColumn.AllowEdit = False
        Me.prioritas.OptionsColumn.ReadOnly = True
        Me.prioritas.Visible = True
        Me.prioritas.VisibleIndex = 4
        Me.prioritas.Width = 83
        '
        'Qty_Produksi
        '
        Me.Qty_Produksi.AppearanceCell.Options.UseTextOptions = True
        Me.Qty_Produksi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty_Produksi.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_Produksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_Produksi.Caption = "Jml Produksi"
        Me.Qty_Produksi.FieldName = "jumlah"
        Me.Qty_Produksi.Name = "Qty_Produksi"
        Me.Qty_Produksi.OptionsColumn.AllowEdit = False
        Me.Qty_Produksi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_Produksi.Visible = True
        Me.Qty_Produksi.VisibleIndex = 5
        Me.Qty_Produksi.Width = 83
        '
        'Indeks
        '
        Me.Indeks.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.Indeks.AppearanceCell.Options.UseBorderColor = True
        Me.Indeks.Caption = "Indeks"
        Me.Indeks.FieldName = "jml_indeks"
        Me.Indeks.Name = "Indeks"
        Me.Indeks.OptionsColumn.AllowEdit = False
        Me.Indeks.OptionsColumn.ReadOnly = True
        Me.Indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Indeks.Visible = True
        Me.Indeks.VisibleIndex = 6
        Me.Indeks.Width = 83
        '
        'clSimpan
        '
        Me.clSimpan.Caption = "Simpan"
        Me.clSimpan.ColumnEdit = Me.repSimpan
        Me.clSimpan.FieldName = "simpan"
        Me.clSimpan.Name = "clSimpan"
        Me.clSimpan.Visible = True
        Me.clSimpan.VisibleIndex = 7
        Me.clSimpan.Width = 97
        '
        'repSimpan
        '
        Me.repSimpan.AutoHeight = False
        Me.repSimpan.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repSimpan.DisplayValueChecked = "Y"
        Me.repSimpan.DisplayValueUnchecked = "N"
        Me.repSimpan.Name = "repSimpan"
        Me.repSimpan.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repSimpan.ValueChecked = "Y"
        Me.repSimpan.ValueGrayed = ""
        Me.repSimpan.ValueUnchecked = "N"
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gv
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.subGV
        GridLevelNode2.RelationName = "Level2"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.gc.Location = New System.Drawing.Point(0, 54)
        Me.gc.MainView = Me.MainGV
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repJnsBrg, Me.repSimpan})
        Me.gc.Size = New System.Drawing.Size(959, 401)
        Me.gc.TabIndex = 6
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.subGV, Me.MainGV, Me.gv})
        '
        'subGV
        '
        Me.subGV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.subGV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.subGV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.subGV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.subGV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subGV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.subGV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.subGV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.subGV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.subGV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.subGV.Appearance.Empty.Options.UseBackColor = True
        Me.subGV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.EvenRow.Options.UseBackColor = True
        Me.subGV.Appearance.EvenRow.Options.UseForeColor = True
        Me.subGV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.subGV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.subGV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.subGV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.subGV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.subGV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.subGV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.subGV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.subGV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.subGV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.subGV.Appearance.FixedLine.Options.UseBackColor = True
        Me.subGV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.subGV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.subGV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.subGV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.subGV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.subGV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.subGV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.subGV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.subGV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.subGV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.subGV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.subGV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.subGV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.GroupButton.Options.UseBackColor = True
        Me.subGV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.subGV.Appearance.GroupButton.Options.UseForeColor = True
        Me.subGV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.subGV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.subGV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.subGV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.subGV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.subGV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.subGV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.subGV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.subGV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.GroupRow.Options.UseBackColor = True
        Me.subGV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.subGV.Appearance.GroupRow.Options.UseFont = True
        Me.subGV.Appearance.GroupRow.Options.UseForeColor = True
        Me.subGV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.subGV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.subGV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.subGV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.subGV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.subGV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.subGV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.subGV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.subGV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.subGV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.subGV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.subGV.Appearance.HorzLine.Options.UseBackColor = True
        Me.subGV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.subGV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.OddRow.Options.UseBackColor = True
        Me.subGV.Appearance.OddRow.Options.UseForeColor = True
        Me.subGV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subGV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.subGV.Appearance.Preview.Options.UseBackColor = True
        Me.subGV.Appearance.Preview.Options.UseForeColor = True
        Me.subGV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.subGV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.subGV.Appearance.Row.Options.UseBackColor = True
        Me.subGV.Appearance.Row.Options.UseForeColor = True
        Me.subGV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.subGV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.subGV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.subGV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.subGV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.subGV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.subGV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.subGV.Appearance.VertLine.Options.UseBackColor = True
        Me.subGV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Jumlah, Me.Panjang, Me.Lebar, Me.Tebal})
        Me.subGV.GridControl = Me.gc
        Me.subGV.Name = "subGV"
        Me.subGV.OptionsView.EnableAppearanceEvenRow = True
        Me.subGV.OptionsView.EnableAppearanceOddRow = True
        Me.subGV.OptionsView.ShowGroupPanel = False
        Me.subGV.PaintStyleName = "Skin"
        '
        'Jumlah
        '
        Me.Jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.Jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Jumlah.Caption = "Jumlah"
        Me.Jumlah.FieldName = "Qty"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Visible = True
        Me.Jumlah.VisibleIndex = 3
        '
        'Panjang
        '
        Me.Panjang.AppearanceHeader.Options.UseTextOptions = True
        Me.Panjang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Panjang.Caption = "Panjang"
        Me.Panjang.FieldName = "panjang"
        Me.Panjang.Name = "Panjang"
        Me.Panjang.OptionsColumn.AllowEdit = False
        Me.Panjang.Visible = True
        Me.Panjang.VisibleIndex = 1
        '
        'Lebar
        '
        Me.Lebar.AppearanceHeader.Options.UseTextOptions = True
        Me.Lebar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Lebar.Caption = "Lebar"
        Me.Lebar.FieldName = "lebar"
        Me.Lebar.Name = "Lebar"
        Me.Lebar.OptionsColumn.AllowEdit = False
        Me.Lebar.Visible = True
        Me.Lebar.VisibleIndex = 2
        '
        'Tebal
        '
        Me.Tebal.AppearanceHeader.Options.UseTextOptions = True
        Me.Tebal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tebal.Caption = "Tebal"
        Me.Tebal.FieldName = "tebal"
        Me.Tebal.Name = "Tebal"
        Me.Tebal.OptionsColumn.AllowEdit = False
        Me.Tebal.Visible = True
        Me.Tebal.VisibleIndex = 0
        '
        'MainGV
        '
        Me.MainGV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clJnsBrg, Me.clKapasitas})
        Me.MainGV.GridControl = Me.gc
        Me.MainGV.Name = "MainGV"
        Me.MainGV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.MainGV.OptionsView.ShowGroupPanel = False
        Me.MainGV.OptionsView.ShowViewCaption = True
        Me.MainGV.ViewCaption = "Daftar Saler Order"
        '
        'clJnsBrg
        '
        Me.clJnsBrg.Caption = "Jenis Barang"
        Me.clJnsBrg.FieldName = "Nama_Jenis"
        Me.clJnsBrg.Name = "clJnsBrg"
        Me.clJnsBrg.OptionsColumn.AllowEdit = False
        Me.clJnsBrg.Visible = True
        Me.clJnsBrg.VisibleIndex = 0
        Me.clJnsBrg.Width = 690
        '
        'clKapasitas
        '
        Me.clKapasitas.Caption = "Kapasitas"
        Me.clKapasitas.FieldName = "jml_kapasitas"
        Me.clKapasitas.Name = "clKapasitas"
        Me.clKapasitas.OptionsColumn.AllowEdit = False
        Me.clKapasitas.Visible = True
        Me.clKapasitas.VisibleIndex = 1
        Me.clKapasitas.Width = 248
        '
        'repJnsBrg
        '
        Me.repJnsBrg.AutoHeight = False
        Me.repJnsBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJnsBrg.DisplayMember = "Nama_Barang"
        Me.repJnsBrg.Name = "repJnsBrg"
        Me.repJnsBrg.ValueMember = "Kd_Jenis"
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 488)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(959, 455)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 54)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtJadwal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(637, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 54)
        Me.Panel3.TabIndex = 7
        '
        'txtJadwal
        '
        Me.txtJadwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJadwal.Location = New System.Drawing.Point(0, 0)
        Me.txtJadwal.Name = "txtJadwal"
        Me.txtJadwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJadwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal")})
        Me.txtJadwal.Properties.DisplayMember = "Desc_Data"
        Me.txtJadwal.Properties.NullText = "[Pilih Jadwal Kerja]"
        Me.txtJadwal.Properties.ValueMember = "Id_Data"
        Me.txtJadwal.Size = New System.Drawing.Size(240, 20)
        Me.txtJadwal.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(474, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 54)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jadwal Kerja :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtDPB)
        Me.Panel7.Controls.Add(Me.txtTgl_Rph)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(283, 54)
        Me.Panel7.TabIndex = 5
        '
        'txtDPB
        '
        Me.txtDPB.BackColor = System.Drawing.Color.LightGreen
        Me.txtDPB.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDPB.Location = New System.Drawing.Point(0, 20)
        Me.txtDPB.Name = "txtDPB"
        Me.txtDPB.ReadOnly = True
        Me.txtDPB.Size = New System.Drawing.Size(283, 21)
        Me.txtDPB.TabIndex = 6
        '
        'txtTgl_Rph
        '
        Me.txtTgl_Rph.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTgl_Rph.EditValue = Nothing
        Me.txtTgl_Rph.Location = New System.Drawing.Point(0, 0)
        Me.txtTgl_Rph.Name = "txtTgl_Rph"
        Me.txtTgl_Rph.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTgl_Rph.Properties.Appearance.Options.UseFont = True
        Me.txtTgl_Rph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl_Rph.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTgl_Rph.Size = New System.Drawing.Size(283, 20)
        Me.txtTgl_Rph.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 54)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. Transaksi : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(959, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "PLANNING PRODUKSI CENTIAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmRcnRphCen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 512)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRcnRphCen"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJnsBrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents subGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Qty_Produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTgl_Rph As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDPB As System.Windows.Forms.TextBox
    Friend WithEvents Indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MainGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clJnsBrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clKapasitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJnsBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtJadwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents clSimpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSimpan As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Tebal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lebar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panjang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jumlah As DevExpress.XtraGrid.Columns.GridColumn
End Class
