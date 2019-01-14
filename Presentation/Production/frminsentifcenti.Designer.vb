<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminsentifcenti
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminsentifcenti))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.date1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.HasilProduksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Parameter = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkpegawai = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Hasil_Produksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_insentif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total_insentif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV_RPH_Service = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml = New DevExpress.XtraGrid.Columns.GridColumn
        Me.indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV_Bom_Serv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.bom_serv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nm_Serv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtJam = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKegiatan = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTgl_Awal = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlbawah = New System.Windows.Forms.Panel
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RPH_Service, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Bom_Serv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtJam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Awal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Awal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tanggal, Me.HasilProduksi, Me.Parameter, Me.Total})
        Me.GridView2.GridControl = Me.gc
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'tanggal
        '
        Me.tanggal.Caption = "Tanggal"
        Me.tanggal.ColumnEdit = Me.date1
        Me.tanggal.DisplayFormat.FormatString = "d"
        Me.tanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tanggal.FieldName = "tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.OptionsColumn.AllowEdit = False
        Me.tanggal.Visible = True
        Me.tanggal.VisibleIndex = 0
        '
        'date1
        '
        Me.date1.AutoHeight = False
        Me.date1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date1.Name = "date1"
        Me.date1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'HasilProduksi
        '
        Me.HasilProduksi.Caption = "Hasil Produksi"
        Me.HasilProduksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.HasilProduksi.FieldName = "jumlah"
        Me.HasilProduksi.Name = "HasilProduksi"
        Me.HasilProduksi.Visible = True
        Me.HasilProduksi.VisibleIndex = 1
        '
        'Parameter
        '
        Me.Parameter.Caption = "Parameter"
        Me.Parameter.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Parameter.FieldName = "indeks"
        Me.Parameter.Name = "Parameter"
        Me.Parameter.Visible = True
        Me.Parameter.VisibleIndex = 2
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "total"
        Me.Total.Name = "Total"
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 3
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.gc.Location = New System.Drawing.Point(0, 57)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkpegawai, Me.date1})
        Me.gc.Size = New System.Drawing.Size(959, 364)
        Me.gc.TabIndex = 9
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GV_RPH_Service, Me.GV_Bom_Serv, Me.GridView1, Me.GridView2})
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
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_pegawai, Me.Hasil_Produksi, Me.nilai_insentif, Me.total_insentif})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowViewCaption = True
        Me.gv.PaintStyleName = "Skin"
        Me.gv.ViewCaption = "Detil Transaksi"
        '
        'kd_pegawai
        '
        Me.kd_pegawai.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_pegawai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_pegawai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.kd_pegawai.Caption = "Pegawai"
        Me.kd_pegawai.ColumnEdit = Me.lkpegawai
        Me.kd_pegawai.FieldName = "kd_pegawai"
        Me.kd_pegawai.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.kd_pegawai.Name = "kd_pegawai"
        Me.kd_pegawai.OptionsColumn.AllowEdit = False
        Me.kd_pegawai.SummaryItem.FieldName = "qty"
        Me.kd_pegawai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.kd_pegawai.Visible = True
        Me.kd_pegawai.VisibleIndex = 0
        Me.kd_pegawai.Width = 77
        '
        'lkpegawai
        '
        Me.lkpegawai.AutoHeight = False
        Me.lkpegawai.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpegawai.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama_Pegawai"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Pegawai", "Kode_Pegawai")})
        Me.lkpegawai.DisplayMember = "Nama_Pegawai"
        Me.lkpegawai.Name = "lkpegawai"
        Me.lkpegawai.ValidateOnEnterKey = True
        Me.lkpegawai.ValueMember = "Kode_Pegawai"
        '
        'Hasil_Produksi
        '
        Me.Hasil_Produksi.AppearanceHeader.Options.UseTextOptions = True
        Me.Hasil_Produksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Hasil_Produksi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Hasil_Produksi.Caption = "Hasil Produksi"
        Me.Hasil_Produksi.FieldName = "jumlah"
        Me.Hasil_Produksi.Name = "Hasil_Produksi"
        Me.Hasil_Produksi.Visible = True
        Me.Hasil_Produksi.VisibleIndex = 1
        Me.Hasil_Produksi.Width = 77
        '
        'nilai_insentif
        '
        Me.nilai_insentif.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_insentif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nilai_insentif.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.nilai_insentif.Caption = "Nilai Insentif"
        Me.nilai_insentif.FieldName = "nilai_insentif"
        Me.nilai_insentif.Name = "nilai_insentif"
        Me.nilai_insentif.Visible = True
        Me.nilai_insentif.VisibleIndex = 2
        Me.nilai_insentif.Width = 107
        '
        'total_insentif
        '
        Me.total_insentif.AppearanceHeader.Options.UseTextOptions = True
        Me.total_insentif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.total_insentif.Caption = "Total Insentif"
        Me.total_insentif.FieldName = "total_insentif"
        Me.total_insentif.Name = "total_insentif"
        Me.total_insentif.SummaryItem.FieldName = "jumlah"
        Me.total_insentif.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total_insentif.Visible = True
        Me.total_insentif.VisibleIndex = 3
        Me.total_insentif.Width = 66
        '
        'GV_RPH_Service
        '
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.Empty.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RPH_Service.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RPH_Service.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_RPH_Service.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_RPH_Service.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.GroupRow.Options.UseFont = True
        Me.GV_RPH_Service.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_RPH_Service.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_RPH_Service.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_RPH_Service.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_RPH_Service.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_RPH_Service.Appearance.Preview.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.Preview.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_RPH_Service.Appearance.Row.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.Row.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_RPH_Service.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_RPH_Service.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_RPH_Service.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_RPH_Service.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_RPH_Service.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_RPH_Service.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.Barang, Me.qty_order, Me.tgl_kirim, Me.Prioritas, Me.jml, Me.indeks})
        Me.GV_RPH_Service.GridControl = Me.gc
        Me.GV_RPH_Service.Name = "GV_RPH_Service"
        Me.GV_RPH_Service.OptionsBehavior.Editable = False
        Me.GV_RPH_Service.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_RPH_Service.OptionsView.EnableAppearanceOddRow = True
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
        'GV_Bom_Serv
        '
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Bom_Serv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Bom_Serv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.GroupRow.Options.UseFont = True
        Me.GV_Bom_Serv.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Bom_Serv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Bom_Serv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Bom_Serv.Appearance.Row.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.Row.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Bom_Serv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Bom_Serv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_Bom_Serv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Bom_Serv.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Bom_Serv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.bom_serv, Me.Nm_Serv})
        Me.GV_Bom_Serv.GridControl = Me.gc
        Me.GV_Bom_Serv.Name = "GV_Bom_Serv"
        Me.GV_Bom_Serv.OptionsBehavior.Editable = False
        Me.GV_Bom_Serv.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Bom_Serv.OptionsView.EnableAppearanceOddRow = True
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
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.gc
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 57)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(541, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 57)
        Me.Panel3.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(258, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "HASIL PRODUKSI"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(105, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GENERATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtJam)
        Me.Panel7.Controls.Add(Me.txtKegiatan)
        Me.Panel7.Controls.Add(Me.txtTgl_Awal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(350, 57)
        Me.Panel7.TabIndex = 5
        '
        'txtJam
        '
        Me.txtJam.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJam.Location = New System.Drawing.Point(0, 40)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtJam.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtJam.Properties.Appearance.Options.UseBackColor = True
        Me.txtJam.Properties.Appearance.Options.UseFont = True
        Me.txtJam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJam.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal")})
        Me.txtJam.Properties.DisplayMember = "Desc_Data"
        Me.txtJam.Properties.NullText = "[Pilih Jam Kerja]"
        Me.txtJam.Properties.ValueMember = "Id_Data"
        Me.txtJam.Size = New System.Drawing.Size(350, 20)
        Me.txtJam.TabIndex = 9
        '
        'txtKegiatan
        '
        Me.txtKegiatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKegiatan.Location = New System.Drawing.Point(0, 20)
        Me.txtKegiatan.Name = "txtKegiatan"
        Me.txtKegiatan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKegiatan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtKegiatan.Properties.Appearance.Options.UseBackColor = True
        Me.txtKegiatan.Properties.Appearance.Options.UseFont = True
        Me.txtKegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jadwal")})
        Me.txtKegiatan.Properties.DisplayMember = "Desc_Data"
        Me.txtKegiatan.Properties.NullText = "[Pilih Kegiatan]"
        Me.txtKegiatan.Properties.ValueMember = "kd_kegiatan"
        Me.txtKegiatan.Size = New System.Drawing.Size(350, 20)
        Me.txtKegiatan.TabIndex = 6
        '
        'txtTgl_Awal
        '
        Me.txtTgl_Awal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTgl_Awal.EditValue = Nothing
        Me.txtTgl_Awal.Location = New System.Drawing.Point(0, 0)
        Me.txtTgl_Awal.Name = "txtTgl_Awal"
        Me.txtTgl_Awal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTgl_Awal.Properties.Appearance.Options.UseFont = True
        Me.txtTgl_Awal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl_Awal.Properties.DisplayFormat.FormatString = "y"
        Me.txtTgl_Awal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl_Awal.Properties.EditFormat.FormatString = "y"
        Me.txtTgl_Awal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTgl_Awal.Properties.Mask.EditMask = "y"
        Me.txtTgl_Awal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTgl_Awal.Size = New System.Drawing.Size(350, 20)
        Me.txtTgl_Awal.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 57)
        Me.Panel6.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jam Kerja : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kegiatan : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bulan / Tahun : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel5)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(959, 431)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 421)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(959, 10)
        Me.Panel5.TabIndex = 2
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
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 484)
        Me.pnl.TabIndex = 1
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
        Me.LabelControl1.Text = "INSENTIF"
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
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 462)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(959, 20)
        Me.pnlbawah.TabIndex = 2
        '
        'frminsentifcenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frminsentifcenti"
        Me.Text = "frminsentifcenti"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RPH_Service, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Bom_Serv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtJam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Awal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Awal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtTgl_Awal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents txtKegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents HasilProduksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Parameter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpegawai As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Hasil_Produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_insentif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total_insentif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RPH_Service As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_Bom_Serv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bom_serv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nm_Serv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJam As DevExpress.XtraEditors.LookUpEdit
End Class
