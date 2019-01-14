<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonRcnRphKetepatan
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNoTrans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColTanggalRealisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoSpkRls = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKegtn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColTipeBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColKain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUkuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJmlRealisasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GC_Rekap = New DevExpress.XtraGrid.GridControl
        Me.GV_Rekap = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.deTglSelesai = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lueDep = New DevExpress.XtraEditors.LookUpEdit
        Me.deTglMulai = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GC_Rekap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Rekap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.lueDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.ForeColor = System.Drawing.Color.Black
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(985, 508)
        Me.pnl.TabIndex = 2
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.TabControl1)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(983, 475)
        Me.pnlTengah.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 431)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(975, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laporan Hasil Produksi Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(3, 3)
        Me.gc.LookAndFeel.SkinName = "Black"
        Me.gc.MainView = Me.gvMain
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(969, 399)
        Me.gc.TabIndex = 7
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvMain.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Empty.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvMain.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseFont = True
        Me.gvMain.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvMain.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.Options.UseForeColor = True
        Me.gvMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.Preview.Options.UseBackColor = True
        Me.gvMain.Appearance.Preview.Options.UseForeColor = True
        Me.gvMain.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.Row.Options.UseBackColor = True
        Me.gvMain.Appearance.Row.Options.UseForeColor = True
        Me.gvMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.VertLine.Options.UseBackColor = True
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoTrans, Me.colTanggal, Me.ColTanggalRealisasi, Me.colNoSP, Me.colNoSpkRls, Me.colKegtn, Me.colKegiatan, Me.ColBarang, Me.ColTipeBarang, Me.ColKain, Me.colUkuran, Me.colSatuan, Me.colJmlRealisasi})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[tanggal] > [tanggal_realisasi]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[tanggal]  <=  [tanggal_realisasi]"
        Me.gvMain.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvMain.OptionsView.ColumnAutoWidth = False
        Me.gvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMain.OptionsView.EnableAppearanceOddRow = True
        Me.gvMain.OptionsView.ShowFooter = True
        Me.gvMain.OptionsView.ShowViewCaption = True
        Me.gvMain.PaintStyleName = "Skin"
        Me.gvMain.ViewCaption = "DAFTAR HASIL PRODUKSI DETAIL"
        '
        'colNoTrans
        '
        Me.colNoTrans.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoTrans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoTrans.Caption = "No. RPH"
        Me.colNoTrans.FieldName = "no_rph"
        Me.colNoTrans.Name = "colNoTrans"
        Me.colNoTrans.OptionsColumn.AllowEdit = False
        Me.colNoTrans.OptionsColumn.ReadOnly = True
        Me.colNoTrans.Visible = True
        Me.colNoTrans.VisibleIndex = 0
        '
        'colTanggal
        '
        Me.colTanggal.AppearanceHeader.Options.UseTextOptions = True
        Me.colTanggal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTanggal.Caption = "Tanggal Realisasi"
        Me.colTanggal.FieldName = "tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.OptionsColumn.AllowEdit = False
        Me.colTanggal.OptionsColumn.ReadOnly = True
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        '
        'ColTanggalRealisasi
        '
        Me.ColTanggalRealisasi.Caption = "Tanggal Target Realisasi"
        Me.ColTanggalRealisasi.FieldName = "tanggal_realisasi"
        Me.ColTanggalRealisasi.Name = "ColTanggalRealisasi"
        Me.ColTanggalRealisasi.OptionsColumn.AllowEdit = False
        Me.ColTanggalRealisasi.Visible = True
        Me.ColTanggalRealisasi.VisibleIndex = 2
        '
        'colNoSP
        '
        Me.colNoSP.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoSP.Caption = "No. SPK"
        Me.colNoSP.FieldName = "no_spk_man_m"
        Me.colNoSP.Name = "colNoSP"
        Me.colNoSP.OptionsColumn.AllowEdit = False
        Me.colNoSP.OptionsColumn.ReadOnly = True
        Me.colNoSP.Visible = True
        Me.colNoSP.VisibleIndex = 3
        '
        'colNoSpkRls
        '
        Me.colNoSpkRls.AppearanceHeader.Options.UseTextOptions = True
        Me.colNoSpkRls.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNoSpkRls.Caption = "No. Realisasi"
        Me.colNoSpkRls.FieldName = "no_spk_man_rls"
        Me.colNoSpkRls.Name = "colNoSpkRls"
        Me.colNoSpkRls.OptionsColumn.AllowEdit = False
        Me.colNoSpkRls.OptionsColumn.ReadOnly = True
        Me.colNoSpkRls.Visible = True
        Me.colNoSpkRls.VisibleIndex = 4
        '
        'colKegtn
        '
        Me.colKegtn.AppearanceHeader.Options.UseTextOptions = True
        Me.colKegtn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKegtn.Caption = "Kegiatan"
        Me.colKegtn.FieldName = "nama_kegiatan"
        Me.colKegtn.Name = "colKegtn"
        Me.colKegtn.OptionsColumn.AllowEdit = False
        Me.colKegtn.OptionsColumn.ReadOnly = True
        Me.colKegtn.Visible = True
        Me.colKegtn.VisibleIndex = 5
        '
        'colKegiatan
        '
        Me.colKegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.colKegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKegiatan.Caption = "Kegiatan SPK"
        Me.colKegiatan.FieldName = "nama_spk"
        Me.colKegiatan.Name = "colKegiatan"
        Me.colKegiatan.OptionsColumn.AllowEdit = False
        Me.colKegiatan.OptionsColumn.ReadOnly = True
        Me.colKegiatan.Visible = True
        Me.colKegiatan.VisibleIndex = 6
        '
        'ColBarang
        '
        Me.ColBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBarang.Caption = "Barang"
        Me.ColBarang.FieldName = "Nama_Barang"
        Me.ColBarang.Name = "ColBarang"
        Me.ColBarang.OptionsColumn.AllowEdit = False
        Me.ColBarang.Visible = True
        Me.ColBarang.VisibleIndex = 7
        Me.ColBarang.Width = 153
        '
        'ColTipeBarang
        '
        Me.ColTipeBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTipeBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTipeBarang.Caption = "Tipe Barang"
        Me.ColTipeBarang.FieldName = "Nama_Tipe"
        Me.ColTipeBarang.Name = "ColTipeBarang"
        Me.ColTipeBarang.OptionsColumn.AllowEdit = False
        Me.ColTipeBarang.Visible = True
        Me.ColTipeBarang.VisibleIndex = 8
        Me.ColTipeBarang.Width = 96
        '
        'ColKain
        '
        Me.ColKain.AppearanceHeader.Options.UseTextOptions = True
        Me.ColKain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColKain.Caption = "Kain"
        Me.ColKain.FieldName = "Merk_Kain"
        Me.ColKain.Name = "ColKain"
        Me.ColKain.OptionsColumn.AllowEdit = False
        Me.ColKain.Visible = True
        Me.ColKain.VisibleIndex = 9
        Me.ColKain.Width = 76
        '
        'colUkuran
        '
        Me.colUkuran.AppearanceHeader.Options.UseTextOptions = True
        Me.colUkuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUkuran.Caption = "Ukuran"
        Me.colUkuran.FieldName = "Nama_Ukuran"
        Me.colUkuran.Name = "colUkuran"
        Me.colUkuran.OptionsColumn.AllowEdit = False
        Me.colUkuran.OptionsColumn.ReadOnly = True
        Me.colUkuran.Visible = True
        Me.colUkuran.VisibleIndex = 10
        Me.colUkuran.Width = 108
        '
        'colSatuan
        '
        Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
        Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.FieldName = "Nama_Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.OptionsColumn.AllowEdit = False
        Me.colSatuan.OptionsColumn.ReadOnly = True
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 11
        Me.colSatuan.Width = 98
        '
        'colJmlRealisasi
        '
        Me.colJmlRealisasi.AppearanceHeader.Options.UseTextOptions = True
        Me.colJmlRealisasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJmlRealisasi.Caption = "Hasil Realisasi"
        Me.colJmlRealisasi.FieldName = "jumlah_kerja"
        Me.colJmlRealisasi.Name = "colJmlRealisasi"
        Me.colJmlRealisasi.OptionsColumn.AllowEdit = False
        Me.colJmlRealisasi.OptionsColumn.ReadOnly = True
        Me.colJmlRealisasi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colJmlRealisasi.Visible = True
        Me.colJmlRealisasi.VisibleIndex = 12
        Me.colJmlRealisasi.Width = 89
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GC_Rekap)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(975, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Laporan Hasil Produksi Rekap"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GC_Rekap
        '
        Me.GC_Rekap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Rekap.Location = New System.Drawing.Point(3, 3)
        Me.GC_Rekap.LookAndFeel.SkinName = "Black"
        Me.GC_Rekap.MainView = Me.GV_Rekap
        Me.GC_Rekap.Name = "GC_Rekap"
        Me.GC_Rekap.Size = New System.Drawing.Size(969, 399)
        Me.GC_Rekap.TabIndex = 8
        Me.GC_Rekap.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Rekap})
        '
        'GV_Rekap
        '
        Me.GV_Rekap.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Rekap.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Rekap.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Rekap.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Rekap.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_Rekap.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_Rekap.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Rekap.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Rekap.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_Rekap.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Rekap.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.GroupRow.Options.UseFont = True
        Me.GV_Rekap.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Rekap.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_Rekap.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Rekap.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Rekap.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_Rekap.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_Rekap.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Rekap.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Rekap.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_Rekap.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Rekap.Appearance.Row.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.Row.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_Rekap.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Rekap.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Rekap.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_Rekap.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_Rekap.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Rekap.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GV_Rekap.GridControl = Me.GC_Rekap
        Me.GV_Rekap.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV_Rekap.Name = "GV_Rekap"
        Me.GV_Rekap.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV_Rekap.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV_Rekap.OptionsView.ColumnAutoWidth = False
        Me.GV_Rekap.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Rekap.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Rekap.OptionsView.ShowFooter = True
        Me.GV_Rekap.OptionsView.ShowViewCaption = True
        Me.GV_Rekap.PaintStyleName = "Skin"
        Me.GV_Rekap.ViewCaption = "DAFTAR HASIL PRODUKSI REKAP"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Barang"
        Me.GridColumn7.FieldName = "Nama_Barang"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 368
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Tipe Barang"
        Me.GridColumn8.FieldName = "Nama_Tipe"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 182
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Kain"
        Me.GridColumn9.FieldName = "Merk_Kain"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 103
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Ukuran"
        Me.GridColumn10.FieldName = "Nama_Ukuran"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 106
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Satuan"
        Me.GridColumn11.FieldName = "Nama_Satuan"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 110
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Hasil Realisasi"
        Me.GridColumn12.FieldName = "jumlah_kerja"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 118
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(797, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 31)
        Me.btnRefresh.TabIndex = 148
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.deTglSelesai)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(551, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 44)
        Me.Panel3.TabIndex = 7
        '
        'deTglSelesai
        '
        Me.deTglSelesai.Dock = System.Windows.Forms.DockStyle.Top
        Me.deTglSelesai.EditValue = Nothing
        Me.deTglSelesai.Location = New System.Drawing.Point(0, 0)
        Me.deTglSelesai.Name = "deTglSelesai"
        Me.deTglSelesai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.deTglSelesai.Properties.Appearance.Options.UseFont = True
        Me.deTglSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglSelesai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglSelesai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglSelesai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deTglSelesai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglSelesai.Size = New System.Drawing.Size(183, 20)
        Me.deTglSelesai.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(374, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(177, 44)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal Selesai : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lueDep)
        Me.Panel7.Controls.Add(Me.deTglMulai)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 44)
        Me.Panel7.TabIndex = 5
        '
        'lueDep
        '
        Me.lueDep.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lueDep.Location = New System.Drawing.Point(0, 24)
        Me.lueDep.Name = "lueDep"
        Me.lueDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDep.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama_Departemen")})
        Me.lueDep.Properties.DisplayMember = "Nama_Departemen"
        Me.lueDep.Properties.NullText = "[Pilih Departemen]"
        Me.lueDep.Properties.ValueMember = "Kd_Departemen"
        Me.lueDep.Size = New System.Drawing.Size(183, 20)
        Me.lueDep.TabIndex = 5
        '
        'deTglMulai
        '
        Me.deTglMulai.Dock = System.Windows.Forms.DockStyle.Top
        Me.deTglMulai.EditValue = Nothing
        Me.deTglMulai.Location = New System.Drawing.Point(0, 0)
        Me.deTglMulai.Name = "deTglMulai"
        Me.deTglMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.deTglMulai.Properties.Appearance.Options.UseFont = True
        Me.deTglMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglMulai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deTglMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglMulai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTglMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglMulai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.deTglMulai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTglMulai.Size = New System.Drawing.Size(183, 20)
        Me.deTglMulai.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 44)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Departemen : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal Mulai : "
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
        Me.pnlAtas.Size = New System.Drawing.Size(983, 31)
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
        Me.LabelControl1.Text = "   MONITORING HASIL PRODUKSI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMonRcnRph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonRcnRph"
        Me.Text = "frmMonRcnKrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GC_Rekap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Rekap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.deTglSelesai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.lueDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents deTglMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deTglSelesai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNoTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSpkRls As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKegtn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTipeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUkuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJmlRealisasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC_Rekap As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Rekap As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTanggalRealisasi As DevExpress.XtraGrid.Columns.GridColumn
End Class
