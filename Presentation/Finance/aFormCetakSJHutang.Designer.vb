<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormCetakSJHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormCetakSJHutang))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.gcDetil = New DevExpress.XtraGrid.GridControl
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_jth_tempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sts_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkCetak = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlFilter = New System.Windows.Forms.Panel
        Me.btnCari = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlNama = New System.Windows.Forms.Panel
        Me.lckCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblForm = New System.Windows.Forms.Label
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCetak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNama.SuspendLayout()
        CType(Me.lckCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFilter)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(859, 535)
        Me.pnl.TabIndex = 0
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.gcDetil)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 78)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(859, 437)
        Me.pnlGrid.TabIndex = 148
        '
        'gcDetil
        '
        Me.gcDetil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDetil.Location = New System.Drawing.Point(0, 0)
        Me.gcDetil.MainView = Me.gvDetil
        Me.gcDetil.Name = "gcDetil"
        Me.gcDetil.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkCetak})
        Me.gcDetil.Size = New System.Drawing.Size(859, 437)
        Me.gcDetil.TabIndex = 147
        Me.gcDetil.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetil})
        '
        'gvDetil
        '
        Me.gvDetil.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetil.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvDetil.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvDetil.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvDetil.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetil.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetil.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvDetil.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvDetil.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvDetil.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetil.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetil.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetil.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvDetil.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvDetil.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvDetil.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetil.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvDetil.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvDetil.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvDetil.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvDetil.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvDetil.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvDetil.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvDetil.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetil.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetil.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvDetil.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvDetil.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvDetil.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvDetil.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvDetil.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvDetil.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvDetil.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvDetil.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvDetil.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetil.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvDetil.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvDetil.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvDetil.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvDetil.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvDetil.Appearance.GroupRow.Options.UseFont = True
        Me.gvDetil.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetil.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvDetil.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvDetil.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvDetil.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvDetil.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvDetil.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvDetil.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvDetil.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetil.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvDetil.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.OddRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvDetil.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvDetil.Appearance.Preview.Options.UseBackColor = True
        Me.gvDetil.Appearance.Preview.Options.UseForeColor = True
        Me.gvDetil.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvDetil.Appearance.Row.Options.UseBackColor = True
        Me.gvDetil.Appearance.Row.Options.UseForeColor = True
        Me.gvDetil.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvDetil.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvDetil.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvDetil.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvDetil.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvDetil.Appearance.VertLine.Options.UseBackColor = True
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.tgl_inv, Me.tgl_jth_tempo, Me.no_sj, Me.keterangan, Me.jml_tagihan, Me.jml_bayar, Me.jml_akhir, Me.sts_tagihan})
        Me.gvDetil.GridControl = Me.gcDetil
        Me.gvDetil.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetil.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvDetil.OptionsPrint.UsePrintStyles = True
        Me.gvDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetil.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetil.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvDetil.OptionsView.ShowFooter = True
        Me.gvDetil.OptionsView.ShowIndicator = False
        Me.gvDetil.PaintStyleName = "Web"
        Me.gvDetil.ViewCaption = "Data Detail Piutang Usaha"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "No. Nota"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.AllowEdit = False
        Me.no_inv.OptionsColumn.ReadOnly = True
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        Me.no_inv.Width = 129
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tanggal Transaksi"
        Me.tgl_inv.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.OptionsColumn.ReadOnly = True
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        Me.tgl_inv.Width = 104
        '
        'tgl_jth_tempo
        '
        Me.tgl_jth_tempo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseFont = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_jth_tempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_jth_tempo.Caption = "Jatuh Tempo"
        Me.tgl_jth_tempo.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_jth_tempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_jth_tempo.FieldName = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Name = "tgl_jth_tempo"
        Me.tgl_jth_tempo.OptionsColumn.AllowEdit = False
        Me.tgl_jth_tempo.OptionsColumn.ReadOnly = True
        Me.tgl_jth_tempo.Visible = True
        Me.tgl_jth_tempo.VisibleIndex = 2
        Me.tgl_jth_tempo.Width = 105
        '
        'no_sj
        '
        Me.no_sj.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_sj.AppearanceHeader.Options.UseFont = True
        Me.no_sj.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sj.Caption = "No. Surat Jalan"
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.OptionsColumn.AllowEdit = False
        Me.no_sj.OptionsColumn.ReadOnly = True
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 3
        Me.no_sj.Width = 119
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 137
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jml. Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.OptionsColumn.ReadOnly = True
        Me.jml_tagihan.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_tagihan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 5
        Me.jml_tagihan.Width = 134
        '
        'jml_bayar
        '
        Me.jml_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_bayar.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar.Caption = "Jml. Bayar"
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.OptionsColumn.AllowEdit = False
        Me.jml_bayar.OptionsColumn.ReadOnly = True
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 6
        Me.jml_bayar.Width = 120
        '
        'jml_akhir
        '
        Me.jml_akhir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_akhir.AppearanceHeader.Options.UseFont = True
        Me.jml_akhir.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_akhir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_akhir.Caption = "Sisa Tagihan"
        Me.jml_akhir.DisplayFormat.FormatString = "n2"
        Me.jml_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_akhir.FieldName = "jml_akhir"
        Me.jml_akhir.Name = "jml_akhir"
        Me.jml_akhir.OptionsColumn.AllowEdit = False
        Me.jml_akhir.OptionsColumn.ReadOnly = True
        Me.jml_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_akhir.Visible = True
        Me.jml_akhir.VisibleIndex = 7
        Me.jml_akhir.Width = 123
        '
        'sts_tagihan
        '
        Me.sts_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sts_tagihan.AppearanceHeader.Options.UseFont = True
        Me.sts_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.sts_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sts_tagihan.Caption = "Cetak"
        Me.sts_tagihan.ColumnEdit = Me.chkCetak
        Me.sts_tagihan.FieldName = "sts_tagihan"
        Me.sts_tagihan.Name = "sts_tagihan"
        Me.sts_tagihan.Visible = True
        Me.sts_tagihan.VisibleIndex = 8
        Me.sts_tagihan.Width = 78
        '
        'chkCetak
        '
        Me.chkCetak.AutoHeight = False
        Me.chkCetak.Name = "chkCetak"
        Me.chkCetak.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkCetak.ValueChecked = "1"
        Me.chkCetak.ValueUnchecked = "0"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.btnCari)
        Me.pnlFilter.Controls.Add(Me.Panel3)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 34)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(859, 44)
        Me.pnlFilter.TabIndex = 147
        '
        'btnCari
        '
        Me.btnCari.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Appearance.Options.UseFont = True
        Me.btnCari.Location = New System.Drawing.Point(331, 2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(98, 36)
        Me.btnCari.TabIndex = 10
        Me.btnCari.Text = "Tampilkan"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(325, 44)
        Me.Panel3.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 5)
        Me.Panel6.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 20)
        Me.Panel1.TabIndex = 11
        '
        'pnlNama
        '
        Me.pnlNama.Controls.Add(Me.lckCustomer)
        Me.pnlNama.Controls.Add(Me.LabelControl2)
        Me.pnlNama.Controls.Add(Me.LabelControl1)
        Me.pnlNama.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlNama.Location = New System.Drawing.Point(25, 0)
        Me.pnlNama.Name = "pnlNama"
        Me.pnlNama.Size = New System.Drawing.Size(300, 20)
        Me.pnlNama.TabIndex = 3
        '
        'lckCustomer
        '
        Me.lckCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lckCustomer.EnterMoveNextControl = True
        Me.lckCustomer.Location = New System.Drawing.Point(80, 0)
        Me.lckCustomer.Name = "lckCustomer"
        Me.lckCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama")})
        Me.lckCustomer.Properties.NullText = "[Pilih disini]"
        Me.lckCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckCustomer.Size = New System.Drawing.Size(220, 20)
        Me.lckCustomer.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(70, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(325, 5)
        Me.Panel4.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(859, 20)
        Me.Panel2.TabIndex = 146
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.lblForm)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(859, 34)
        Me.Panel5.TabIndex = 145
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
        'lblForm
        '
        Me.lblForm.BackColor = System.Drawing.Color.Transparent
        Me.lblForm.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.ForeColor = System.Drawing.Color.Gold
        Me.lblForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblForm.Location = New System.Drawing.Point(39, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(456, 32)
        Me.lblForm.TabIndex = 1
        Me.lblForm.Text = "CETAK TAGIHAN OUTSTANDING SUPPLIER"
        Me.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcDetil
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(0, 0, 10, 26)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'aFormCetakSJHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 535)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormCetakSJHutang"
        Me.Text = "FORM PIUTANG OUTSTANDING"
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.gcDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCetak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlNama.ResumeLayout(False)
        CType(Me.lckCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblForm As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlNama As System.Windows.Forms.Panel
    Friend WithEvents lckCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents gcDetil As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_jth_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sts_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCetak As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
