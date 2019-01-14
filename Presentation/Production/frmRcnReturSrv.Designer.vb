<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRcnReturSrv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRcnReturSrv))
        Me.gvDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.prioritas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_indeks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_kapasitas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtNoTrans = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtJnsTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtJnsTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetail
        '
        Me.gvDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetail.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvDetail.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.FocusedRow.Options.UseFont = True
        Me.gvDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetail.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDetail.Appearance.GroupRow.Options.UseFont = True
        Me.gvDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDetail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvDetail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetail.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetail.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetail.Appearance.Preview.Options.UseForeColor = True
        Me.gvDetail.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDetail.Appearance.Row.Options.UseBackColor = True
        Me.gvDetail.Appearance.Row.Options.UseForeColor = True
        Me.gvDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvDetail.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvDetail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDetail.Appearance.SelectedRow.Options.UseFont = True
        Me.gvDetail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDetail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetail.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.nama_customer, Me.nama_barang, Me.sisa, Me.tgl_kirim, Me.prioritas, Me.jumlah, Me.jml_indeks, Me.kd_stok})
        Me.gvDetail.GridControl = Me.gc
        Me.gvDetail.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "jml", Nothing, "")})
        Me.gvDetail.Name = "gvDetail"
        Me.gvDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetail.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetail.OptionsView.ShowFooter = True
        Me.gvDetail.OptionsView.ShowGroupPanel = False
        Me.gvDetail.OptionsView.ShowViewCaption = True
        Me.gvDetail.PaintStyleName = "Skin"
        Me.gvDetail.ViewCaption = "DAFTAR SISA BARANG"
        '
        'no_sp
        '
        Me.no_sp.AppearanceCell.Options.UseTextOptions = True
        Me.no_sp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "No SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.ReadOnly = True
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 0
        Me.no_sp.Width = 134
        '
        'nama_customer
        '
        Me.nama_customer.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.nama_customer.AppearanceCell.Options.UseBorderColor = True
        Me.nama_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_customer.Caption = "Pelanggan"
        Me.nama_customer.FieldName = "nama_customer"
        Me.nama_customer.Name = "nama_customer"
        Me.nama_customer.OptionsColumn.AllowEdit = False
        Me.nama_customer.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.nama_customer.OptionsColumn.ReadOnly = True
        Me.nama_customer.Visible = True
        Me.nama_customer.VisibleIndex = 1
        Me.nama_customer.Width = 140
        '
        'nama_barang
        '
        Me.nama_barang.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.nama_barang.AppearanceCell.Options.UseBorderColor = True
        Me.nama_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_barang.Caption = "Nama Barang"
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.OptionsColumn.AllowEdit = False
        Me.nama_barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.nama_barang.OptionsColumn.ReadOnly = True
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 2
        Me.nama_barang.Width = 246
        '
        'sisa
        '
        Me.sisa.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.sisa.AppearanceCell.Options.UseBorderColor = True
        Me.sisa.AppearanceCell.Options.UseTextOptions = True
        Me.sisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.sisa.AppearanceHeader.Options.UseTextOptions = True
        Me.sisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sisa.Caption = "Sisa"
        Me.sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisa.FieldName = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.OptionsColumn.AllowEdit = False
        Me.sisa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.sisa.OptionsColumn.ReadOnly = True
        Me.sisa.Visible = True
        Me.sisa.VisibleIndex = 3
        Me.sisa.Width = 65
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.tgl_kirim.AppearanceCell.Options.UseBorderColor = True
        Me.tgl_kirim.AppearanceCell.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl Kirim"
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.tgl_kirim.OptionsColumn.ReadOnly = True
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 4
        Me.tgl_kirim.Width = 108
        '
        'prioritas
        '
        Me.prioritas.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.prioritas.AppearanceCell.Options.UseBorderColor = True
        Me.prioritas.AppearanceHeader.Options.UseTextOptions = True
        Me.prioritas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prioritas.Caption = "Prioritas"
        Me.prioritas.FieldName = "prioritas"
        Me.prioritas.Name = "prioritas"
        Me.prioritas.OptionsColumn.AllowEdit = False
        Me.prioritas.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.prioritas.OptionsColumn.ReadOnly = True
        Me.prioritas.Visible = True
        Me.prioritas.VisibleIndex = 5
        Me.prioritas.Width = 97
        '
        'jumlah
        '
        Me.jumlah.AppearanceCell.Options.UseTextOptions = True
        Me.jumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Jml Kirim"
        Me.jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 6
        Me.jumlah.Width = 71
        '
        'jml_indeks
        '
        Me.jml_indeks.AppearanceCell.BorderColor = System.Drawing.Color.Black
        Me.jml_indeks.AppearanceCell.Options.UseBorderColor = True
        Me.jml_indeks.AppearanceCell.Options.UseTextOptions = True
        Me.jml_indeks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_indeks.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_indeks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_indeks.Caption = "Indeks"
        Me.jml_indeks.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_indeks.FieldName = "jml_indeks"
        Me.jml_indeks.Name = "jml_indeks"
        Me.jml_indeks.OptionsColumn.AllowEdit = False
        Me.jml_indeks.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.jml_indeks.OptionsColumn.ReadOnly = True
        Me.jml_indeks.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_indeks.Visible = True
        Me.jml_indeks.VisibleIndex = 7
        Me.jml_indeks.Width = 77
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "kd stok"
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.kd_stok.OptionsColumn.AllowShowHide = False
        Me.kd_stok.Width = 77
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Detail"
        Me.gc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gc.Location = New System.Drawing.Point(0, 58)
        Me.gc.MainView = Me.gvDetail
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(959, 393)
        Me.gc.TabIndex = 6
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetail, Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama_jenis, Me.jumlah_kapasitas})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvMain.OptionsView.ShowGroupPanel = False
        '
        'nama_jenis
        '
        Me.nama_jenis.Caption = "Nama Jenis"
        Me.nama_jenis.FieldName = "Nama_Jenis"
        Me.nama_jenis.Name = "nama_jenis"
        Me.nama_jenis.OptionsColumn.AllowEdit = False
        Me.nama_jenis.OptionsColumn.ReadOnly = True
        Me.nama_jenis.Visible = True
        Me.nama_jenis.VisibleIndex = 0
        '
        'jumlah_kapasitas
        '
        Me.jumlah_kapasitas.Caption = "Kapasitas"
        Me.jumlah_kapasitas.FieldName = "jml_kapasitas"
        Me.jumlah_kapasitas.Name = "jumlah_kapasitas"
        Me.jumlah_kapasitas.Visible = True
        Me.jumlah_kapasitas.VisibleIndex = 1
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
        Me.pnl.Size = New System.Drawing.Size(961, 484)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(959, 451)
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
        Me.Panel1.Size = New System.Drawing.Size(959, 58)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNoTrans)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(609, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 58)
        Me.Panel3.TabIndex = 7
        '
        'txtNoTrans
        '
        Me.txtNoTrans.BackColor = System.Drawing.Color.LightGreen
        Me.txtNoTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoTrans.Location = New System.Drawing.Point(0, 0)
        Me.txtNoTrans.Name = "txtNoTrans"
        Me.txtNoTrans.ReadOnly = True
        Me.txtNoTrans.Size = New System.Drawing.Size(240, 21)
        Me.txtNoTrans.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(374, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 58)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. Transaksi : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtJnsTrans)
        Me.Panel7.Controls.Add(Me.txtTanggal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 58)
        Me.Panel7.TabIndex = 5
        '
        'txtJnsTrans
        '
        Me.txtJnsTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJnsTrans.Location = New System.Drawing.Point(0, 20)
        Me.txtJnsTrans.Name = "txtJnsTrans"
        Me.txtJnsTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJnsTrans.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Transaksi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Val_kode1", "Kode")})
        Me.txtJnsTrans.Properties.DisplayMember = "Desc_Data"
        Me.txtJnsTrans.Properties.NullText = "[Pilih Jenis Transaksi]"
        Me.txtJnsTrans.Properties.ValueMember = "Id_Data"
        Me.txtJnsTrans.Size = New System.Drawing.Size(183, 20)
        Me.txtJnsTrans.TabIndex = 5
        '
        'txtTanggal
        '
        Me.txtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(0, 0)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTanggal.Properties.Appearance.Options.UseFont = True
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTanggal.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTanggal.Size = New System.Drawing.Size(183, 20)
        Me.txtTanggal.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 58)
        Me.Panel6.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis Transaksi : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.LabelControl1.Text = "   PLANNING KIRIM RETUR DAN SERVICE"
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
        'frmRcnReturSrv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRcnReturSrv"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtJnsTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gvDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prioritas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_indeks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_kapasitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJnsTrans As DevExpress.XtraEditors.LookUpEdit
End Class
