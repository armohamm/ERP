<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsentifSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsentifSales))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Card.CardView
        Me.sales = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSales = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.target = New DevExpress.XtraGrid.Columns.GridColumn
        Me.omzet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.persen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.point_utama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.point_tambahan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_utama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_tambahan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.perolehan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.index = New DevExpress.XtraGrid.Columns.GridColumn
        Me.perolehan_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtTahun = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 37)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(977, 385)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 23)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repSales})
        Me.gc.Size = New System.Drawing.Size(977, 362)
        Me.gc.TabIndex = 1
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.ActiveFilterEnabled = False
        Me.gv.Appearance.CardCaption.BackColor = System.Drawing.Color.Silver
        Me.gv.Appearance.CardCaption.BorderColor = System.Drawing.Color.Silver
        Me.gv.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.CardCaption.Options.UseBackColor = True
        Me.gv.Appearance.CardCaption.Options.UseBorderColor = True
        Me.gv.Appearance.CardCaption.Options.UseFont = True
        Me.gv.Appearance.CardCaption.Options.UseForeColor = True
        Me.gv.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.gv.Appearance.EmptySpace.Options.UseBackColor = True
        Me.gv.Appearance.FieldCaption.BackColor = System.Drawing.Color.Silver
        Me.gv.Appearance.FieldCaption.BackColor2 = System.Drawing.Color.GhostWhite
        Me.gv.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FieldCaption.Options.UseBackColor = True
        Me.gv.Appearance.FieldCaption.Options.UseForeColor = True
        Me.gv.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FieldValue.Options.UseBackColor = True
        Me.gv.Appearance.FieldValue.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.Purple
        Me.gv.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.gv.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Purple
        Me.gv.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCardCaption.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCardCaption.Options.UseBorderColor = True
        Me.gv.Appearance.FocusedCardCaption.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.Gray
        Me.gv.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.Gray
        Me.gv.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gv.Appearance.HideSelectionCardCaption.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionCardCaption.Options.UseBorderColor = True
        Me.gv.Appearance.HideSelectionCardCaption.Options.UseForeColor = True
        Me.gv.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gv.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.SelectedCardCaption.Options.UseBackColor = True
        Me.gv.Appearance.SelectedCardCaption.Options.UseForeColor = True
        Me.gv.Appearance.SeparatorLine.BackColor = System.Drawing.Color.Silver
        Me.gv.Appearance.SeparatorLine.Options.UseBackColor = True
        Me.gv.CardCaptionFormat = "Insentif Sales "
        Me.gv.CardWidth = 300
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.sales, Me.target, Me.omzet, Me.bulan, Me.persen, Me.point_utama, Me.point_tambahan, Me.nilai_utama, Me.nilai_tambahan, Me.perolehan, Me.index, Me.perolehan_akhir})
        Me.gv.DetailHeight = 300
        Me.gv.FocusedCardTopFieldIndex = 0
        Me.gv.GridControl = Me.gc
        Me.gv.MaximumCardColumns = 4
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsBehavior.ReadOnly = True
        Me.gv.OptionsFilter.AllowColumnMRUFilterList = False
        Me.gv.OptionsFilter.AllowFilterEditor = False
        Me.gv.OptionsView.ShowCardExpandButton = False
        Me.gv.OptionsView.ShowQuickCustomizeButton = False
        Me.gv.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'sales
        '
        Me.sales.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.sales.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales.AppearanceCell.Options.UseBackColor = True
        Me.sales.AppearanceCell.Options.UseFont = True
        Me.sales.Caption = "Nama Sales"
        Me.sales.ColumnEdit = Me.repSales
        Me.sales.FieldName = "kd_sales"
        Me.sales.Name = "sales"
        Me.sales.Visible = True
        Me.sales.VisibleIndex = 0
        Me.sales.Width = 90
        '
        'repSales
        '
        Me.repSales.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repSales.Appearance.Options.UseFont = True
        Me.repSales.AutoHeight = False
        Me.repSales.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repSales.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sales", "Name1")})
        Me.repSales.DisplayMember = "Nama_Sales"
        Me.repSales.Name = "repSales"
        Me.repSales.ValueMember = "Kode_Sales"
        '
        'target
        '
        Me.target.Caption = "Taget"
        Me.target.DisplayFormat.FormatString = "n2"
        Me.target.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.target.FieldName = "Target"
        Me.target.Name = "target"
        Me.target.Visible = True
        Me.target.VisibleIndex = 1
        Me.target.Width = 90
        '
        'omzet
        '
        Me.omzet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.omzet.AppearanceHeader.Options.UseFont = True
        Me.omzet.Caption = "Omzet"
        Me.omzet.DisplayFormat.FormatString = "n2"
        Me.omzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.omzet.FieldName = "Omzet"
        Me.omzet.Name = "omzet"
        Me.omzet.Visible = True
        Me.omzet.VisibleIndex = 2
        Me.omzet.Width = 90
        '
        'bulan
        '
        Me.bulan.Caption = "Bulan"
        Me.bulan.FieldName = "bulan"
        Me.bulan.Name = "bulan"
        '
        'persen
        '
        Me.persen.Caption = "%"
        Me.persen.DisplayFormat.FormatString = "n2"
        Me.persen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.persen.FieldName = "persen"
        Me.persen.Name = "persen"
        Me.persen.UnboundExpression = "[Omzet] / [Target]*100"
        Me.persen.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.persen.Visible = True
        Me.persen.VisibleIndex = 3
        Me.persen.Width = 90
        '
        'point_utama
        '
        Me.point_utama.Caption = "Point Utama"
        Me.point_utama.DisplayFormat.FormatString = "n2"
        Me.point_utama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.point_utama.FieldName = "Point_utama1"
        Me.point_utama.Name = "point_utama"
        Me.point_utama.Visible = True
        Me.point_utama.VisibleIndex = 4
        Me.point_utama.Width = 90
        '
        'point_tambahan
        '
        Me.point_tambahan.Caption = "Point Tambahan"
        Me.point_tambahan.DisplayFormat.FormatString = "n2"
        Me.point_tambahan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.point_tambahan.FieldName = "Point_tambah1"
        Me.point_tambahan.Name = "point_tambahan"
        Me.point_tambahan.Visible = True
        Me.point_tambahan.VisibleIndex = 5
        Me.point_tambahan.Width = 90
        '
        'nilai_utama
        '
        Me.nilai_utama.Caption = "Nilai Utama"
        Me.nilai_utama.DisplayFormat.FormatString = "n2"
        Me.nilai_utama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nilai_utama.FieldName = "Nilai_point_utama"
        Me.nilai_utama.Name = "nilai_utama"
        Me.nilai_utama.Visible = True
        Me.nilai_utama.VisibleIndex = 6
        Me.nilai_utama.Width = 90
        '
        'nilai_tambahan
        '
        Me.nilai_tambahan.Caption = "Nilai Tambahan"
        Me.nilai_tambahan.DisplayFormat.FormatString = "n2"
        Me.nilai_tambahan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nilai_tambahan.FieldName = "Nilai_point_tambahan"
        Me.nilai_tambahan.Name = "nilai_tambahan"
        Me.nilai_tambahan.Visible = True
        Me.nilai_tambahan.VisibleIndex = 7
        Me.nilai_tambahan.Width = 90
        '
        'perolehan
        '
        Me.perolehan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.perolehan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perolehan.AppearanceCell.Options.UseBackColor = True
        Me.perolehan.AppearanceCell.Options.UseFont = True
        Me.perolehan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.perolehan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perolehan.AppearanceHeader.Options.UseBackColor = True
        Me.perolehan.AppearanceHeader.Options.UseFont = True
        Me.perolehan.Caption = "Perolehan"
        Me.perolehan.DisplayFormat.FormatString = "n2"
        Me.perolehan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.perolehan.FieldName = "Perolehan"
        Me.perolehan.Name = "perolehan"
        Me.perolehan.UnboundExpression = "[Nilai_point_utama] + [Nilai_point_tambahan]"
        Me.perolehan.Visible = True
        Me.perolehan.VisibleIndex = 8
        Me.perolehan.Width = 90
        '
        'index
        '
        Me.index.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.index.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.index.AppearanceCell.Options.UseBackColor = True
        Me.index.AppearanceCell.Options.UseFont = True
        Me.index.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.index.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.index.AppearanceHeader.Options.UseBackColor = True
        Me.index.AppearanceHeader.Options.UseFont = True
        Me.index.Caption = "Index Piutang"
        Me.index.DisplayFormat.FormatString = "n2"
        Me.index.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.index.FieldName = "Index"
        Me.index.Name = "index"
        Me.index.Visible = True
        Me.index.VisibleIndex = 9
        Me.index.Width = 100
        '
        'perolehan_akhir
        '
        Me.perolehan_akhir.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.perolehan_akhir.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perolehan_akhir.AppearanceCell.Options.UseBackColor = True
        Me.perolehan_akhir.AppearanceCell.Options.UseFont = True
        Me.perolehan_akhir.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.perolehan_akhir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perolehan_akhir.AppearanceHeader.Options.UseBackColor = True
        Me.perolehan_akhir.AppearanceHeader.Options.UseFont = True
        Me.perolehan_akhir.Caption = "Perolehan Akhir"
        Me.perolehan_akhir.DisplayFormat.FormatString = "n2"
        Me.perolehan_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.perolehan_akhir.FieldName = "Perolehan_Akhir"
        Me.perolehan_akhir.Name = "perolehan_akhir"
        Me.perolehan_akhir.UnboundExpression = "[Index] * [Perolehan]"
        Me.perolehan_akhir.Visible = True
        Me.perolehan_akhir.VisibleIndex = 10
        Me.perolehan_akhir.Width = 90
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 23)
        Me.Panel1.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(320, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(57, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtTahun)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(93, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(227, 23)
        Me.Panel4.TabIndex = 14
        '
        'txtTahun
        '
        Me.txtTahun.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtTahun.EditValue = Nothing
        Me.txtTahun.Location = New System.Drawing.Point(0, 0)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun.Properties.Appearance.Options.UseFont = True
        Me.txtTahun.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTahun.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTahun.Properties.DisplayFormat.FormatString = "MMMM yyyy"
        Me.txtTahun.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTahun.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtTahun.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTahun.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTahun.Size = New System.Drawing.Size(221, 22)
        Me.txtTahun.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(93, 23)
        Me.Panel3.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Periode :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(977, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(540, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " INSENTIF SALES"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmInsentifSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 422)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmInsentifSales"
        Me.Text = "frmInsentifSales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents target As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents omzet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents persen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents point_utama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents point_tambahan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_utama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_tambahan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents perolehan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents index As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents perolehan_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtTahun As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repSales As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
