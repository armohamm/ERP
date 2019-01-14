<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOSEALY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSOSEALY))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_StokD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HargaD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc1D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc2D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc3D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc4D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc5d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PotonganD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GVP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSeqP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Hadiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Sete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSet = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKeterangan = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.tglKirims = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTglKirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Priority = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repPrioritas = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.states = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlTengahBawah = New System.Windows.Forms.Panel
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ckPPN = New DevExpress.XtraEditors.CheckEdit
        Me.tglSO = New System.Windows.Forms.TextBox
        Me.txtNomor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtNamaSales = New DevExpress.XtraEditors.TextEdit
        Me.txtSales = New DevExpress.XtraEditors.LookUpEdit
        Me.txtCR = New DevExpress.XtraEditors.TextEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtAlamat = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.txtNamaPnrm = New System.Windows.Forms.TextBox
        Me.txtAlamatKirim = New DevExpress.XtraEditors.MemoEdit
        Me.tglKirim = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPrioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnlTengahBawah.SuspendLayout()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ckPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.txtNamaSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlbawah.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoD, Me.Kd_StokD, Me.UnitD, Me.QtyD, Me.HargaD, Me.Disc1D, Me.Disc2D, Me.Disc3D, Me.Disc4D, Me.Disc5d, Me.PotonganD, Me.TotalD, Me.Nama_Barang})
        Me.GVD.GridControl = Me.GC
        Me.GVD.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "harga", Me.HargaD, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.Nama_Barang, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "potongan", Me.PotonganD, "")})
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.Editable = False
        Me.GVD.OptionsBehavior.ReadOnly = True
        Me.GVD.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowColumnHeaders = False
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.OptionsView.ShowHorzLines = False
        Me.GVD.OptionsView.ShowIndicator = False
        Me.GVD.OptionsView.ShowVertLines = False
        '
        'NoD
        '
        Me.NoD.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.NoD.AppearanceCell.Options.UseBackColor = True
        Me.NoD.AppearanceCell.Options.UseTextOptions = True
        Me.NoD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NoD.AppearanceHeader.Options.UseTextOptions = True
        Me.NoD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NoD.Caption = "No"
        Me.NoD.FieldName = "No_seq"
        Me.NoD.Name = "NoD"
        Me.NoD.Visible = True
        Me.NoD.VisibleIndex = 0
        Me.NoD.Width = 35
        '
        'Kd_StokD
        '
        Me.Kd_StokD.Caption = "Barang"
        Me.Kd_StokD.FieldName = "Kd_Stok"
        Me.Kd_StokD.Name = "Kd_StokD"
        Me.Kd_StokD.Width = 249
        '
        'UnitD
        '
        Me.UnitD.Caption = "Satuan"
        Me.UnitD.FieldName = "Kd_satuan"
        Me.UnitD.Name = "UnitD"
        Me.UnitD.Visible = True
        Me.UnitD.VisibleIndex = 2
        Me.UnitD.Width = 54
        '
        'QtyD
        '
        Me.QtyD.Caption = "Qty"
        Me.QtyD.FieldName = "Qty"
        Me.QtyD.Name = "QtyD"
        Me.QtyD.Visible = True
        Me.QtyD.VisibleIndex = 3
        Me.QtyD.Width = 54
        '
        'HargaD
        '
        Me.HargaD.AppearanceCell.Options.UseTextOptions = True
        Me.HargaD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HargaD.AppearanceHeader.Options.UseTextOptions = True
        Me.HargaD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HargaD.Caption = "Harga"
        Me.HargaD.FieldName = "harga"
        Me.HargaD.Name = "HargaD"
        Me.HargaD.OptionsColumn.AllowEdit = False
        Me.HargaD.OptionsColumn.AllowFocus = False
        Me.HargaD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.HargaD.Visible = True
        Me.HargaD.VisibleIndex = 4
        Me.HargaD.Width = 100
        '
        'Disc1D
        '
        Me.Disc1D.Caption = "Disc1"
        Me.Disc1D.FieldName = "disc1"
        Me.Disc1D.Name = "Disc1D"
        Me.Disc1D.Width = 61
        '
        'Disc2D
        '
        Me.Disc2D.Caption = "Disc2"
        Me.Disc2D.FieldName = "disc2"
        Me.Disc2D.Name = "Disc2D"
        Me.Disc2D.Width = 61
        '
        'Disc3D
        '
        Me.Disc3D.Caption = "Disc3"
        Me.Disc3D.FieldName = "disc3"
        Me.Disc3D.Name = "Disc3D"
        Me.Disc3D.Width = 61
        '
        'Disc4D
        '
        Me.Disc4D.Caption = "Disc4"
        Me.Disc4D.FieldName = "disc4"
        Me.Disc4D.Name = "Disc4D"
        Me.Disc4D.Width = 61
        '
        'Disc5d
        '
        Me.Disc5d.Caption = "Disc5"
        Me.Disc5d.FieldName = "disc5"
        Me.Disc5d.Name = "Disc5d"
        Me.Disc5d.Width = 61
        '
        'PotonganD
        '
        Me.PotonganD.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.PotonganD.AppearanceCell.Options.UseForeColor = True
        Me.PotonganD.AppearanceCell.Options.UseTextOptions = True
        Me.PotonganD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PotonganD.AppearanceHeader.Options.UseTextOptions = True
        Me.PotonganD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PotonganD.Caption = "Potongan"
        Me.PotonganD.FieldName = "potongan"
        Me.PotonganD.Name = "PotonganD"
        Me.PotonganD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PotonganD.Visible = True
        Me.PotonganD.VisibleIndex = 5
        Me.PotonganD.Width = 98
        '
        'TotalD
        '
        Me.TotalD.AppearanceCell.Options.UseTextOptions = True
        Me.TotalD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalD.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalD.Caption = "Total"
        Me.TotalD.FieldName = "total"
        Me.TotalD.Name = "TotalD"
        Me.TotalD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalD.Visible = True
        Me.TotalD.VisibleIndex = 6
        Me.TotalD.Width = 119
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 1
        Me.Nama_Barang.Width = 362
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVD
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GVP
        GridLevelNode2.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbarang, Me.repPrioritas, Me.repTglKirim, Me.repKeterangan, Me.repSet})
        Me.GC.Size = New System.Drawing.Size(848, 334)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVP, Me.GV, Me.GVD})
        '
        'GVP
        '
        Me.GVP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVP.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVP.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVP.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.Empty.Options.UseBackColor = True
        Me.GVP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVP.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVP.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVP.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVP.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVP.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVP.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVP.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVP.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVP.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVP.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVP.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVP.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVP.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVP.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVP.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVP.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVP.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVP.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVP.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVP.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVP.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVP.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVP.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.OddRow.Options.UseBackColor = True
        Me.GVP.Appearance.OddRow.Options.UseForeColor = True
        Me.GVP.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVP.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVP.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVP.Appearance.Preview.Options.UseBackColor = True
        Me.GVP.Appearance.Preview.Options.UseFont = True
        Me.GVP.Appearance.Preview.Options.UseForeColor = True
        Me.GVP.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.Row.Options.UseBackColor = True
        Me.GVP.Appearance.Row.Options.UseBorderColor = True
        Me.GVP.Appearance.Row.Options.UseForeColor = True
        Me.GVP.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVP.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVP.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVP.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.VertLine.Options.UseBackColor = True
        Me.GVP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSeqP, Me.Hadiah, Me.QtyP, Me.GridColumn1})
        Me.GVP.GridControl = Me.GC
        Me.GVP.Name = "GVP"
        Me.GVP.OptionsView.EnableAppearanceEvenRow = True
        Me.GVP.OptionsView.EnableAppearanceOddRow = True
        Me.GVP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GVP.OptionsView.ShowGroupPanel = False
        Me.GVP.OptionsView.ShowHorzLines = False
        Me.GVP.OptionsView.ShowIndicator = False
        Me.GVP.OptionsView.ShowPreview = True
        Me.GVP.OptionsView.ShowPreviewLines = False
        Me.GVP.OptionsView.ShowVertLines = False
        Me.GVP.PreviewFieldName = "DetailPromo"
        '
        'NoSeqP
        '
        Me.NoSeqP.Caption = "No"
        Me.NoSeqP.FieldName = "No_Seq"
        Me.NoSeqP.Name = "NoSeqP"
        Me.NoSeqP.Visible = True
        Me.NoSeqP.VisibleIndex = 0
        Me.NoSeqP.Width = 34
        '
        'Hadiah
        '
        Me.Hadiah.Caption = "Hadiah"
        Me.Hadiah.FieldName = "PROMO_DESC"
        Me.Hadiah.Name = "Hadiah"
        Me.Hadiah.Visible = True
        Me.Hadiah.VisibleIndex = 3
        Me.Hadiah.Width = 440
        '
        'QtyP
        '
        Me.QtyP.Caption = "Qty"
        Me.QtyP.FieldName = "QTY"
        Me.QtyP.Name = "QtyP"
        Me.QtyP.Visible = True
        Me.QtyP.VisibleIndex = 1
        Me.QtyP.Width = 57
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Promo"
        Me.GridColumn1.FieldName = "PROMO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 296
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
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Sete, Me.Kd_Stok, Me.Qty, Me.Kd_satuan, Me.Keterangan, Me.tglKirims, Me.harga, Me.Potongan, Me.Total, Me.Priority, Me.states, Me.disc1, Me.disc2, Me.disc3, Me.disc4, Me.disc5})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightYellow
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.states
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "2"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.Total, "")})
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.SmartDetailExpand = False
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowHorzLines = False
        Me.GV.OptionsView.ShowIndicator = False
        Me.GV.OptionsView.ShowVertLines = False
        '
        'No_seq
        '
        Me.No_seq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_seq.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.No_seq.AppearanceCell.Options.UseFont = True
        Me.No_seq.AppearanceCell.Options.UseTextOptions = True
        Me.No_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 0
        Me.No_seq.Width = 33
        '
        'Sete
        '
        Me.Sete.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Sete.Caption = "Set"
        Me.Sete.ColumnEdit = Me.repSet
        Me.Sete.FieldName = "set"
        Me.Sete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Sete.Name = "Sete"
        Me.Sete.Visible = True
        Me.Sete.VisibleIndex = 1
        Me.Sete.Width = 40
        '
        'repSet
        '
        Me.repSet.AutoHeight = False
        Me.repSet.Caption = ""
        Me.repSet.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repSet.Name = "repSet"
        Me.repSet.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repSet.ValueChecked = "1"
        Me.repSet.ValueGrayed = "0"
        Me.repSet.ValueUnchecked = "0"
        '
        'Kd_Stok
        '
        Me.Kd_Stok.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 2
        Me.Kd_Stok.Width = 261
        '
        'repbarang
        '
        Me.repbarang.Appearance.Image = CType(resources.GetObject("repbarang.Appearance.Image"), System.Drawing.Image)
        Me.repbarang.Appearance.Options.UseImage = True
        Me.repbarang.AutoHeight = False
        Me.repbarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 125, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 450, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 75, "Unit")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.DropDownRows = 15
        Me.repbarang.HideSelection = False
        Me.repbarang.Name = "repbarang"
        Me.repbarang.NullText = "[Pilih Barang]"
        Me.repbarang.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.repbarang.PopupWidth = 700
        Me.repbarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "#;Zero"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 38
        '
        'Kd_satuan
        '
        Me.Kd_satuan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_satuan.AppearanceCell.Options.UseFont = True
        Me.Kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.AllowFocus = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 4
        Me.Kd_satuan.Width = 44
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.ColumnEdit = Me.repKeterangan
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 8
        Me.Keterangan.Width = 87
        '
        'repKeterangan
        '
        Me.repKeterangan.AutoHeight = False
        Me.repKeterangan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKeterangan.Name = "repKeterangan"
        '
        'tglKirims
        '
        Me.tglKirims.Caption = "Tgl Kirim"
        Me.tglKirims.ColumnEdit = Me.repTglKirim
        Me.tglKirims.FieldName = "tgl_kirim"
        Me.tglKirims.Name = "tglKirims"
        Me.tglKirims.Visible = True
        Me.tglKirims.VisibleIndex = 7
        Me.tglKirims.Width = 88
        '
        'repTglKirim
        '
        Me.repTglKirim.AutoHeight = False
        Me.repTglKirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTglKirim.Name = "repTglKirim"
        Me.repTglKirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'harga
        '
        Me.harga.AppearanceCell.Options.UseTextOptions = True
        Me.harga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga.AppearanceHeader.Options.UseTextOptions = True
        Me.harga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "#.00;[#.0];Zero"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.OptionsColumn.AllowFocus = False
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 5
        Me.harga.Width = 90
        '
        'Potongan
        '
        Me.Potongan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Potongan.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.Potongan.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.Potongan.AppearanceCell.Options.UseBackColor = True
        Me.Potongan.AppearanceCell.Options.UseForeColor = True
        Me.Potongan.AppearanceCell.Options.UseTextOptions = True
        Me.Potongan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Potongan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Potongan.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.Potongan.AppearanceHeader.Options.UseBackColor = True
        Me.Potongan.AppearanceHeader.Options.UseForeColor = True
        Me.Potongan.AppearanceHeader.Options.UseTextOptions = True
        Me.Potongan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Potongan.Caption = "Potongan"
        Me.Potongan.FieldName = "potongan"
        Me.Potongan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Potongan.Name = "Potongan"
        Me.Potongan.OptionsColumn.AllowEdit = False
        Me.Potongan.OptionsColumn.AllowFocus = False
        Me.Potongan.Visible = True
        Me.Potongan.VisibleIndex = 9
        Me.Potongan.Width = 65
        '
        'Total
        '
        Me.Total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Total.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Total.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.AppearanceCell.Options.UseBackColor = True
        Me.Total.AppearanceCell.Options.UseFont = True
        Me.Total.AppearanceCell.Options.UseTextOptions = True
        Me.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Total.AppearanceHeader.Options.UseTextOptions = True
        Me.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "#.00;[#.0];Zero"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "total"
        Me.Total.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsColumn.AllowFocus = False
        Me.Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Total.SummaryItem.Tag = "Total Order"
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 10
        Me.Total.Width = 102
        '
        'Priority
        '
        Me.Priority.Caption = "Prioritas"
        Me.Priority.ColumnEdit = Me.repPrioritas
        Me.Priority.FieldName = "prioritas"
        Me.Priority.Name = "Priority"
        Me.Priority.Visible = True
        Me.Priority.VisibleIndex = 6
        Me.Priority.Width = 67
        '
        'repPrioritas
        '
        Me.repPrioritas.AutoHeight = False
        Me.repPrioritas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repPrioritas.Items.AddRange(New Object() {"Penting", "Umum"})
        Me.repPrioritas.Name = "repPrioritas"
        '
        'states
        '
        Me.states.Caption = "state"
        Me.states.FieldName = "state"
        Me.states.Name = "states"
        '
        'disc1
        '
        Me.disc1.Caption = "disc1"
        Me.disc1.FieldName = "disc1"
        Me.disc1.Name = "disc1"
        '
        'disc2
        '
        Me.disc2.Caption = "disc2"
        Me.disc2.FieldName = "disc2"
        Me.disc2.Name = "disc2"
        '
        'disc3
        '
        Me.disc3.Caption = "disc3"
        Me.disc3.FieldName = "disc3"
        Me.disc3.Name = "disc3"
        '
        'disc4
        '
        Me.disc4.Caption = "disc4"
        Me.disc4.FieldName = "disc4"
        Me.disc4.Name = "disc4"
        '
        'disc5
        '
        Me.disc5.Caption = "disc5"
        Me.disc5.FieldName = "disc5"
        Me.disc5.Name = "disc5"
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(28, 15)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(850, 525)
        Me.pnl.TabIndex = 1
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.pnlTengahBawah)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(848, 398)
        Me.pnlTengah.TabIndex = 4
        '
        'pnlTengahBawah
        '
        Me.pnlTengahBawah.Controls.Add(Me.GC)
        Me.pnlTengahBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengahBawah.Location = New System.Drawing.Point(0, 64)
        Me.pnlTengahBawah.Name = "pnlTengahBawah"
        Me.pnlTengahBawah.Size = New System.Drawing.Size(848, 334)
        Me.pnlTengahBawah.TabIndex = 1
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(848, 64)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ckPPN)
        Me.Panel3.Controls.Add(Me.tglSO)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(711, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 64)
        Me.Panel3.TabIndex = 6
        '
        'ckPPN
        '
        Me.ckPPN.Dock = System.Windows.Forms.DockStyle.Top
        Me.ckPPN.Location = New System.Drawing.Point(0, 42)
        Me.ckPPN.Name = "ckPPN"
        Me.ckPPN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPPN.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Window
        Me.ckPPN.Properties.Appearance.Options.UseFont = True
        Me.ckPPN.Properties.Appearance.Options.UseForeColor = True
        Me.ckPPN.Properties.Caption = ""
        Me.ckPPN.Properties.LookAndFeel.SkinName = "Black"
        Me.ckPPN.Size = New System.Drawing.Size(137, 21)
        Me.ckPPN.TabIndex = 12
        '
        'tglSO
        '
        Me.tglSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSO.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSO.Location = New System.Drawing.Point(0, 21)
        Me.tglSO.Name = "tglSO"
        Me.tglSO.Size = New System.Drawing.Size(137, 21)
        Me.tglSO.TabIndex = 1
        Me.tglSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(137, 21)
        Me.txtNomor.TabIndex = 0
        Me.txtNomor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(588, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(123, 64)
        Me.Panel2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Kode :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ChartControl1)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(588, 64)
        Me.Panel5.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.txtCR)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(110, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(413, 64)
        Me.Panel7.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtNamaSales)
        Me.Panel9.Controls.Add(Me.txtSales)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 41)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(413, 22)
        Me.Panel9.TabIndex = 10
        '
        'txtNamaSales
        '
        Me.txtNamaSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNamaSales.Location = New System.Drawing.Point(277, 0)
        Me.txtNamaSales.Name = "txtNamaSales"
        Me.txtNamaSales.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaSales.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNamaSales.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaSales.Properties.Appearance.Options.UseForeColor = True
        Me.txtNamaSales.Properties.ReadOnly = True
        Me.txtNamaSales.Size = New System.Drawing.Size(136, 20)
        Me.txtNamaSales.TabIndex = 7
        '
        'txtSales
        '
        Me.txtSales.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSales.Location = New System.Drawing.Point(0, 0)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSales.Properties.Appearance.Options.UseBackColor = True
        Me.txtSales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSales.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sales", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sales", 150, "Nama")})
        Me.txtSales.Properties.NullText = "[Pilih Sales]"
        Me.txtSales.Properties.PopupWidth = 300
        Me.txtSales.Size = New System.Drawing.Size(277, 20)
        Me.txtSales.TabIndex = 6
        '
        'txtCR
        '
        Me.txtCR.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCR.Location = New System.Drawing.Point(0, 20)
        Me.txtCR.Name = "txtCR"
        Me.txtCR.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCR.Properties.Appearance.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCR.Properties.Appearance.Options.UseBackColor = True
        Me.txtCR.Properties.Appearance.Options.UseFont = True
        Me.txtCR.Properties.AutoHeight = False
        Me.txtCR.Properties.ReadOnly = True
        Me.txtCR.Size = New System.Drawing.Size(413, 21)
        Me.txtCR.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtAlamat)
        Me.Panel6.Controls.Add(Me.txtCustomer)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(413, 20)
        Me.Panel6.TabIndex = 2
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlamat.Location = New System.Drawing.Point(279, 0)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlamat.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtAlamat.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlamat.Properties.Appearance.Options.UseForeColor = True
        Me.txtAlamat.Properties.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(134, 20)
        Me.txtAlamat.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 100, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 150, "Alamat")})
        Me.txtCustomer.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Size = New System.Drawing.Size(279, 20)
        Me.txtCustomer.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(110, 64)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sales :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sisa Credit : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlbawah
        '
        Me.pnlbawah.Controls.Add(Me.Panel14)
        Me.pnlbawah.Controls.Add(Me.Panel11)
        Me.pnlbawah.Controls.Add(Me.Panel10)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 435)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(848, 88)
        Me.pnlbawah.TabIndex = 3
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Black
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.lblTotal)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(594, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(254, 88)
        Me.Panel14.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTotal.Appearance.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Appearance.Options.UseBackColor = True
        Me.lblTotal.Appearance.Options.UseBorderColor = True
        Me.lblTotal.Appearance.Options.UseFont = True
        Me.lblTotal.Appearance.Options.UseForeColor = True
        Me.lblTotal.Appearance.Options.UseTextOptions = True
        Me.lblTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTotal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotal.Location = New System.Drawing.Point(76, 0)
        Me.lblTotal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTotal.Size = New System.Drawing.Size(176, 36)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "0"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Black
        Me.Panel15.Controls.Add(Me.LabelControl5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(76, 86)
        Me.Panel15.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl5.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseBorderColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl5.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 36)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Total : "
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.txtKeterangan)
        Me.Panel11.Controls.Add(Me.LabelControl4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(359, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(235, 88)
        Me.Panel11.TabIndex = 2
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 21)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKeterangan.Size = New System.Drawing.Size(233, 65)
        Me.txtKeterangan.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(233, 21)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = " Keterangan"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.txtNamaPnrm)
        Me.Panel10.Controls.Add(Me.txtAlamatKirim)
        Me.Panel10.Controls.Add(Me.tglKirim)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(359, 88)
        Me.Panel10.TabIndex = 1
        '
        'txtNamaPnrm
        '
        Me.txtNamaPnrm.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaPnrm.Location = New System.Drawing.Point(97, 66)
        Me.txtNamaPnrm.Name = "txtNamaPnrm"
        Me.txtNamaPnrm.Size = New System.Drawing.Size(262, 21)
        Me.txtNamaPnrm.TabIndex = 4
        '
        'txtAlamatKirim
        '
        Me.txtAlamatKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAlamatKirim.Location = New System.Drawing.Point(97, 20)
        Me.txtAlamatKirim.Name = "txtAlamatKirim"
        Me.txtAlamatKirim.Size = New System.Drawing.Size(262, 46)
        Me.txtAlamatKirim.TabIndex = 3
        '
        'tglKirim
        '
        Me.tglKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglKirim.EditValue = Nothing
        Me.tglKirim.Location = New System.Drawing.Point(97, 0)
        Me.tglKirim.Name = "tglKirim"
        Me.tglKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglKirim.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglKirim.Size = New System.Drawing.Size(262, 20)
        Me.tglKirim.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Maroon
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.LabelControl3)
        Me.Panel8.Controls.Add(Me.LabelControl2)
        Me.Panel8.Controls.Add(Me.LabelControl1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(97, 88)
        Me.Panel8.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 22)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nama Pemesan : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 44)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Alamat Kirim : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tanggal Kirim : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 37)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = " FORM SURAT PEMESANAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 75
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Location = New System.Drawing.Point(548, 24)
        Me.ChartControl1.Name = "ChartControl1"
        SideBySideBarSeriesLabel1.LineVisible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        SideBySideBarSeriesLabel2.LineVisible = True
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.Name = "Series 2"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        SideBySideBarSeriesLabel3.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        Me.ChartControl1.Size = New System.Drawing.Size(319, 200)
        Me.ChartControl1.TabIndex = 5
        '
        'frmSOSEALY
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 571)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSOSEALY"
        Me.Text = "frmSO"
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPrioritas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlTengahBawah.ResumeLayout(False)
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ckPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.txtNamaSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlbawah.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahBawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tglKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAlamatKirim As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtNamaPnrm As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tglSO As System.Windows.Forms.TextBox
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtNamaSales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tglKirims As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Priority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repPrioritas As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repTglKirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repKeterangan As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents states As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckPPN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Sete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSet As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_StokD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HargaD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc1D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc2D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc4D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc5d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PotonganD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc3D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GVP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoSeqP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Hadiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
