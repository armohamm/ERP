<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRlsRphServiceClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRlsRphServiceClosing))
        Me.GV_RPH_Service = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml = New DevExpress.XtraGrid.Columns.GridColumn
        Me.indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV_Bom_Serv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.bom_serv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nm_Serv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.warna = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gctotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran90 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran100 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran120 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran140 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran150 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran160 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran180 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran200 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukurankhs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC_Ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txt_jns_prod = New DevExpress.XtraEditors.TextEdit
        Me.txtJadwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.txtTgl_Rph = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.btOpen = New DevExpress.XtraEditors.SimpleButton
        Me.btClossing = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GV_RPH_Service, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Bom_Serv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_jns_prod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbawah.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_RPH_Service
        '
        Me.GV_RPH_Service.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.Barang, Me.qty_order, Me.tgl_kirim, Me.Prioritas, Me.jml, Me.indeks})
        Me.GV_RPH_Service.GridControl = Me.gc
        Me.GV_RPH_Service.Name = "GV_RPH_Service"
        Me.GV_RPH_Service.OptionsBehavior.Editable = False
        '
        'no_sp
        '
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "No. SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 167
        '
        'Barang
        '
        Me.Barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Barang.Caption = "Nama Barang"
        Me.Barang.FieldName = "Nama_Barang"
        Me.Barang.Name = "Barang"
        Me.Barang.Visible = True
        Me.Barang.VisibleIndex = 1
        Me.Barang.Width = 279
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Order Service"
        Me.qty_order.FieldName = "Sisa"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 2
        Me.qty_order.Width = 184
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tanggal Kirim"
        Me.tgl_kirim.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 104
        '
        'Prioritas
        '
        Me.Prioritas.AppearanceHeader.Options.UseTextOptions = True
        Me.Prioritas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Prioritas.Caption = "Prioritas"
        Me.Prioritas.FieldName = "priroritas"
        Me.Prioritas.Name = "Prioritas"
        Me.Prioritas.Visible = True
        Me.Prioritas.VisibleIndex = 4
        Me.Prioritas.Width = 79
        '
        'jml
        '
        Me.jml.AppearanceHeader.Options.UseTextOptions = True
        Me.jml.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml.Caption = "Jumlah"
        Me.jml.FieldName = "jumlah"
        Me.jml.Name = "jml"
        Me.jml.Visible = True
        Me.jml.VisibleIndex = 5
        Me.jml.Width = 92
        '
        'indeks
        '
        Me.indeks.AppearanceHeader.Options.UseTextOptions = True
        Me.indeks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.indeks.Caption = "Indeks"
        Me.indeks.FieldName = "jml_indeks"
        Me.indeks.Name = "indeks"
        Me.indeks.Visible = True
        Me.indeks.VisibleIndex = 6
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV_RPH_Service
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GV_Bom_Serv
        GridLevelNode2.RelationName = "Level2"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.gc.Location = New System.Drawing.Point(0, 54)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(926, 308)
        Me.gc.TabIndex = 7
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Bom_Serv, Me.gv, Me.GV_RPH_Service})
        '
        'GV_Bom_Serv
        '
        Me.GV_Bom_Serv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.bom_serv, Me.Nm_Serv})
        Me.GV_Bom_Serv.GridControl = Me.gc
        Me.GV_Bom_Serv.Name = "GV_Bom_Serv"
        Me.GV_Bom_Serv.OptionsBehavior.Editable = False
        '
        'bom_serv
        '
        Me.bom_serv.AppearanceHeader.Options.UseTextOptions = True
        Me.bom_serv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bom_serv.Caption = "Kd. Bom Service"
        Me.bom_serv.FieldName = "bom_service"
        Me.bom_serv.Name = "bom_serv"
        Me.bom_serv.Visible = True
        Me.bom_serv.VisibleIndex = 0
        '
        'Nm_Serv
        '
        Me.Nm_Serv.AppearanceHeader.Options.UseTextOptions = True
        Me.Nm_Serv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nm_Serv.Caption = "Nama Service"
        Me.Nm_Serv.FieldName = "nama_service"
        Me.Nm_Serv.Name = "Nm_Serv"
        Me.Nm_Serv.Visible = True
        Me.Nm_Serv.VisibleIndex = 1
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
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.jenis, Me.merk, Me.tipe, Me.warna, Me.gctotal, Me.ukuran90, Me.ukuran100, Me.ukuran120, Me.ukuran140, Me.ukuran150, Me.ukuran160, Me.ukuran180, Me.ukuran200, Me.ukurankhs, Me.GC_Ket})
        Me.gv.GridControl = Me.gc
        Me.gv.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.gctotal, "")})
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowViewCaption = True
        Me.gv.PaintStyleName = "Skin"
        Me.gv.ViewCaption = "DAFTAR REALISASI PRODUKSI HARIAN"
        '
        'jenis
        '
        Me.jenis.AppearanceHeader.Options.UseTextOptions = True
        Me.jenis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jenis.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.jenis.Caption = "Jenis"
        Me.jenis.FieldName = "Nama_Jenis_Group"
        Me.jenis.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.jenis.Name = "jenis"
        Me.jenis.OptionsColumn.AllowEdit = False
        Me.jenis.SummaryItem.FieldName = "qty"
        Me.jenis.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 0
        Me.jenis.Width = 77
        '
        'merk
        '
        Me.merk.AppearanceHeader.Options.UseTextOptions = True
        Me.merk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.merk.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.merk.Caption = "Nama Merk"
        Me.merk.DisplayFormat.FormatString = "d"
        Me.merk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.merk.FieldName = "Nama_Merk"
        Me.merk.Name = "merk"
        Me.merk.OptionsColumn.AllowEdit = False
        Me.merk.Visible = True
        Me.merk.VisibleIndex = 1
        Me.merk.Width = 77
        '
        'tipe
        '
        Me.tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tipe.Caption = "Tipe"
        Me.tipe.FieldName = "Nama_Tipe"
        Me.tipe.Name = "tipe"
        Me.tipe.OptionsColumn.AllowEdit = False
        Me.tipe.Visible = True
        Me.tipe.VisibleIndex = 2
        Me.tipe.Width = 107
        '
        'warna
        '
        Me.warna.AppearanceHeader.Options.UseTextOptions = True
        Me.warna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.warna.Caption = "Warna"
        Me.warna.FieldName = "Warna"
        Me.warna.Name = "warna"
        Me.warna.OptionsColumn.AllowEdit = False
        Me.warna.SummaryItem.FieldName = "jumlah"
        Me.warna.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.warna.Visible = True
        Me.warna.VisibleIndex = 4
        Me.warna.Width = 66
        '
        'gctotal
        '
        Me.gctotal.AppearanceHeader.Options.UseTextOptions = True
        Me.gctotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gctotal.Caption = "Total"
        Me.gctotal.DisplayFormat.FormatString = "N0"
        Me.gctotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gctotal.FieldName = "Total"
        Me.gctotal.GroupFormat.FormatString = "N0"
        Me.gctotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gctotal.Name = "gctotal"
        Me.gctotal.Visible = True
        Me.gctotal.VisibleIndex = 3
        Me.gctotal.Width = 43
        '
        'ukuran90
        '
        Me.ukuran90.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran90.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran90.Caption = "90"
        Me.ukuran90.DisplayFormat.FormatString = "N0"
        Me.ukuran90.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran90.FieldName = "uk90"
        Me.ukuran90.Name = "ukuran90"
        Me.ukuran90.OptionsColumn.AllowEdit = False
        Me.ukuran90.Visible = True
        Me.ukuran90.VisibleIndex = 5
        Me.ukuran90.Width = 49
        '
        'ukuran100
        '
        Me.ukuran100.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran100.Caption = "100"
        Me.ukuran100.DisplayFormat.FormatString = "N0"
        Me.ukuran100.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran100.FieldName = "uk100"
        Me.ukuran100.Name = "ukuran100"
        Me.ukuran100.OptionsColumn.AllowEdit = False
        Me.ukuran100.Visible = True
        Me.ukuran100.VisibleIndex = 6
        Me.ukuran100.Width = 39
        '
        'ukuran120
        '
        Me.ukuran120.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran120.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran120.Caption = "120"
        Me.ukuran120.DisplayFormat.FormatString = "N0"
        Me.ukuran120.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran120.FieldName = "uk120"
        Me.ukuran120.Name = "ukuran120"
        Me.ukuran120.OptionsColumn.AllowEdit = False
        Me.ukuran120.Visible = True
        Me.ukuran120.VisibleIndex = 7
        Me.ukuran120.Width = 39
        '
        'ukuran140
        '
        Me.ukuran140.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran140.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran140.Caption = "140"
        Me.ukuran140.DisplayFormat.FormatString = "N0"
        Me.ukuran140.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran140.FieldName = "uk140"
        Me.ukuran140.Name = "ukuran140"
        Me.ukuran140.OptionsColumn.AllowEdit = False
        Me.ukuran140.Visible = True
        Me.ukuran140.VisibleIndex = 8
        Me.ukuran140.Width = 39
        '
        'ukuran150
        '
        Me.ukuran150.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran150.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran150.Caption = "150"
        Me.ukuran150.DisplayFormat.FormatString = "N0"
        Me.ukuran150.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran150.FieldName = "uk150"
        Me.ukuran150.Name = "ukuran150"
        Me.ukuran150.OptionsColumn.AllowEdit = False
        Me.ukuran150.Visible = True
        Me.ukuran150.VisibleIndex = 9
        Me.ukuran150.Width = 39
        '
        'ukuran160
        '
        Me.ukuran160.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran160.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran160.Caption = "160"
        Me.ukuran160.DisplayFormat.FormatString = "N0"
        Me.ukuran160.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran160.FieldName = "uk160"
        Me.ukuran160.Name = "ukuran160"
        Me.ukuran160.OptionsColumn.AllowEdit = False
        Me.ukuran160.Visible = True
        Me.ukuran160.VisibleIndex = 10
        Me.ukuran160.Width = 39
        '
        'ukuran180
        '
        Me.ukuran180.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran180.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran180.Caption = "180"
        Me.ukuran180.DisplayFormat.FormatString = "N0"
        Me.ukuran180.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran180.FieldName = "uk180"
        Me.ukuran180.Name = "ukuran180"
        Me.ukuran180.OptionsColumn.AllowEdit = False
        Me.ukuran180.Visible = True
        Me.ukuran180.VisibleIndex = 11
        Me.ukuran180.Width = 39
        '
        'ukuran200
        '
        Me.ukuran200.AppearanceHeader.Options.UseTextOptions = True
        Me.ukuran200.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukuran200.Caption = "200"
        Me.ukuran200.DisplayFormat.FormatString = "N0"
        Me.ukuran200.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukuran200.FieldName = "uk200"
        Me.ukuran200.Name = "ukuran200"
        Me.ukuran200.OptionsColumn.AllowEdit = False
        Me.ukuran200.Visible = True
        Me.ukuran200.VisibleIndex = 12
        Me.ukuran200.Width = 39
        '
        'ukurankhs
        '
        Me.ukurankhs.AppearanceHeader.Options.UseTextOptions = True
        Me.ukurankhs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ukurankhs.Caption = "Khusus"
        Me.ukurankhs.DisplayFormat.FormatString = "N0"
        Me.ukurankhs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ukurankhs.FieldName = "ukKHS"
        Me.ukurankhs.Name = "ukurankhs"
        Me.ukurankhs.OptionsColumn.AllowEdit = False
        Me.ukurankhs.Visible = True
        Me.ukurankhs.VisibleIndex = 13
        Me.ukurankhs.Width = 57
        '
        'GC_Ket
        '
        Me.GC_Ket.AppearanceHeader.Options.UseTextOptions = True
        Me.GC_Ket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GC_Ket.Caption = "Ukuran/Keterangan"
        Me.GC_Ket.FieldName = "ket"
        Me.GC_Ket.Name = "GC_Ket"
        Me.GC_Ket.OptionsColumn.AllowEdit = False
        Me.GC_Ket.Visible = True
        Me.GC_Ket.VisibleIndex = 14
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Location = New System.Drawing.Point(8, 10)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(928, 426)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(926, 362)
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
        Me.Panel1.Size = New System.Drawing.Size(926, 54)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_jns_prod)
        Me.Panel3.Controls.Add(Me.txtJadwal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(610, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 54)
        Me.Panel3.TabIndex = 7
        '
        'txt_jns_prod
        '
        Me.txt_jns_prod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_jns_prod.Location = New System.Drawing.Point(0, 20)
        Me.txt_jns_prod.Name = "txt_jns_prod"
        Me.txt_jns_prod.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_jns_prod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jns_prod.Properties.Appearance.Options.UseBackColor = True
        Me.txt_jns_prod.Properties.Appearance.Options.UseFont = True
        Me.txt_jns_prod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_jns_prod.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_jns_prod.Properties.ReadOnly = True
        Me.txt_jns_prod.Size = New System.Drawing.Size(201, 22)
        Me.txt_jns_prod.TabIndex = 3
        '
        'txtJadwal
        '
        Me.txtJadwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJadwal.Location = New System.Drawing.Point(0, 0)
        Me.txtJadwal.Name = "txtJadwal"
        Me.txtJadwal.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtJadwal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJadwal.Properties.Appearance.Options.UseBackColor = True
        Me.txtJadwal.Properties.Appearance.Options.UseFont = True
        Me.txtJadwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJadwal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJadwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal")})
        Me.txtJadwal.Properties.DisplayMember = "Desc_Data"
        Me.txtJadwal.Properties.NullText = "[Pilih Jadwal Kerja]"
        Me.txtJadwal.Properties.ReadOnly = True
        Me.txtJadwal.Properties.ValueMember = "Id_Data"
        Me.txtJadwal.Size = New System.Drawing.Size(201, 20)
        Me.txtJadwal.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(419, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 54)
        Me.Panel2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jenis Produksi : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "* Jadwal Kerja : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextEdit1)
        Me.Panel7.Controls.Add(Me.txtTgl_Rph)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(228, 54)
        Me.Panel7.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextEdit1.Location = New System.Drawing.Point(0, 20)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TextEdit1.Size = New System.Drawing.Size(228, 22)
        Me.TextEdit1.TabIndex = 5
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
        Me.txtTgl_Rph.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtTgl_Rph.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl_Rph.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTgl_Rph.Size = New System.Drawing.Size(228, 20)
        Me.txtTgl_Rph.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label2)
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
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No RPH : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "* Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(-39, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 0)
        Me.Label6.TabIndex = 2
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
        Me.pnlAtas.Size = New System.Drawing.Size(926, 31)
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
        Me.LabelControl1.Text = "RENCANA PRODUKSI SERVICE HARIAN"
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
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Controls.Add(Me.btOpen)
        Me.pnlbawah.Controls.Add(Me.btClossing)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 393)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(926, 31)
        Me.pnlbawah.TabIndex = 2
        '
        'btOpen
        '
        Me.btOpen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btOpen.Appearance.Options.UseFont = True
        Me.btOpen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btOpen.Location = New System.Drawing.Point(466, 4)
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(107, 23)
        Me.btOpen.TabIndex = 7
        Me.btOpen.Text = "Proses Open"
        '
        'btClossing
        '
        Me.btClossing.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btClossing.Appearance.Options.UseFont = True
        Me.btClossing.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btClossing.Location = New System.Drawing.Point(311, 4)
        Me.btClossing.Name = "btClossing"
        Me.btClossing.Size = New System.Drawing.Size(107, 23)
        Me.btClossing.TabIndex = 6
        Me.btClossing.Text = "Proses Clossing"
        '
        'frmRlsRphServiceClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 443)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRlsRphServiceClosing"
        Me.Text = "frmRlsRph"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV_RPH_Service, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Bom_Serv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txt_jns_prod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJadwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbawah.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents warna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_Bom_Serv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTgl_Rph As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ukuran90 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran140 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran150 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran160 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran180 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran200 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukurankhs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtJadwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ukuran120 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RPH_Service As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bom_serv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nm_Serv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_jns_prod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gctotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC_Ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btOpen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btClossing As DevExpress.XtraEditors.SimpleButton
End Class
