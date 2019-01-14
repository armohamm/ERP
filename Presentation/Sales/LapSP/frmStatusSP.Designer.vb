<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatusSP
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
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatusSP))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.sisa = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Rkirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Nama_Customer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.No_sp = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Qty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SumKirimSJ = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SumDitermia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.SumProd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.getSumRncKirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SumKirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.tgl_kirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.MaxTglKirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CetakSP = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.tglStop = New DevExpress.XtraEditors.DateEdit
        Me.tglStart = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdFilter = New DevExpress.XtraEditors.RadioGroup
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglStop.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglStop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.rdFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sisa
        '
        Me.sisa.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sisa.AppearanceCell.Options.UseBackColor = True
        Me.sisa.Caption = "Sisa"
        Me.sisa.FieldName = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.UnboundExpression = "[Qty]-Iif(IsNull([SumDitermia]), 0 , [SumDitermia])"
        Me.sisa.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.sisa.Visible = True
        Me.sisa.Width = 63
        '
        'Rkirim
        '
        Me.Rkirim.Caption = "Dev. (hari)"
        Me.Rkirim.FieldName = "Rkirim"
        Me.Rkirim.Name = "Rkirim"
        Me.Rkirim.UnboundExpression = "Iif(IsNull([MaxTglKirim]),'Belum Terkirim',DateDiffDay([tgl_kirim],[MaxTglKirim] " & _
            "))"
        Me.Rkirim.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Rkirim.Visible = True
        Me.Rkirim.Width = 85
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1011, 384)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 81)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.gv
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(1011, 303)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.BandPanel.Options.UseBackColor = True
        Me.gv.Appearance.BandPanel.Options.UseBorderColor = True
        Me.gv.Appearance.BandPanel.Options.UseFont = True
        Me.gv.Appearance.BandPanel.Options.UseForeColor = True
        Me.gv.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.BandPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.HeaderPanelBackground.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.HorzLine.Options.UseBorderColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseBorderColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gv.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseBorderColor = True
        Me.gv.Appearance.Preview.Options.UseFont = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseBorderColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gv.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.gv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand2, Me.GridBand4})
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Nama_Customer, Me.Nama_Barang, Me.Qty, Me.tgl_kirim, Me.No_sp, Me.SumProd, Me.getSumRncKirim, Me.SumKirim, Me.SumKirimSJ, Me.SumDitermia, Me.MaxTglKirim, Me.Status, Me.Rkirim, Me.sisa})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.Rkirim
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        Me.gv.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gv.GridControl = Me.GC
        Me.gv.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsBehavior.ReadOnly = True
        Me.gv.OptionsCustomization.AllowBandMoving = False
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsCustomization.AllowFilter = False
        Me.gv.OptionsCustomization.AllowGroup = False
        Me.gv.OptionsCustomization.AllowQuickHideColumns = False
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.Nama_Customer)
        Me.GridBand1.Columns.Add(Me.No_sp)
        Me.GridBand1.Columns.Add(Me.Nama_Barang)
        Me.GridBand1.Columns.Add(Me.Status)
        Me.GridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 462
        '
        'Nama_Customer
        '
        Me.Nama_Customer.Caption = "Customer"
        Me.Nama_Customer.FieldName = "Nama_Customer"
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Nama_Customer.Width = 191
        '
        'No_sp
        '
        Me.No_sp.Caption = "Nomor SP"
        Me.No_sp.FieldName = "No_sp"
        Me.No_sp.Name = "No_sp"
        Me.No_sp.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.No_sp.Visible = True
        Me.No_sp.Width = 160
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Barang"
        Me.Nama_Barang.FieldName = "Deskripsi"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.Width = 302
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 73
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Qty Order"
        Me.GridBand3.Columns.Add(Me.Qty)
        Me.GridBand3.Columns.Add(Me.SumKirimSJ)
        Me.GridBand3.Columns.Add(Me.SumDitermia)
        Me.GridBand3.Columns.Add(Me.sisa)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 274
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "N0"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.Width = 49
        '
        'SumKirimSJ
        '
        Me.SumKirimSJ.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SumKirimSJ.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumKirimSJ.AppearanceCell.Options.UseBackColor = True
        Me.SumKirimSJ.AppearanceCell.Options.UseFont = True
        Me.SumKirimSJ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumKirimSJ.AppearanceHeader.Options.UseFont = True
        Me.SumKirimSJ.Caption = "On Dvery"
        Me.SumKirimSJ.FieldName = "SumKirimSJ"
        Me.SumKirimSJ.Name = "SumKirimSJ"
        Me.SumKirimSJ.Visible = True
        Me.SumKirimSJ.Width = 79
        '
        'SumDitermia
        '
        Me.SumDitermia.Caption = "Diterima"
        Me.SumDitermia.DisplayFormat.FormatString = "N0"
        Me.SumDitermia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SumDitermia.FieldName = "SumDitermia"
        Me.SumDitermia.Name = "SumDitermia"
        Me.SumDitermia.Visible = True
        Me.SumDitermia.Width = 83
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Status Produksi dan Pengiriman"
        Me.GridBand2.Columns.Add(Me.SumProd)
        Me.GridBand2.Columns.Add(Me.getSumRncKirim)
        Me.GridBand2.Columns.Add(Me.SumKirim)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 244
        '
        'SumProd
        '
        Me.SumProd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SumProd.AppearanceCell.Options.UseBackColor = True
        Me.SumProd.Caption = "Produksi"
        Me.SumProd.DisplayFormat.FormatString = "N0"
        Me.SumProd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SumProd.FieldName = "SumProd"
        Me.SumProd.Name = "SumProd"
        Me.SumProd.Visible = True
        Me.SumProd.Width = 85
        '
        'getSumRncKirim
        '
        Me.getSumRncKirim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.getSumRncKirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getSumRncKirim.AppearanceCell.Options.UseBackColor = True
        Me.getSumRncKirim.AppearanceCell.Options.UseFont = True
        Me.getSumRncKirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getSumRncKirim.AppearanceHeader.Options.UseFont = True
        Me.getSumRncKirim.Caption = "Rcn Krm"
        Me.getSumRncKirim.DisplayFormat.FormatString = "n0"
        Me.getSumRncKirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.getSumRncKirim.FieldName = "getSumRncKirim"
        Me.getSumRncKirim.Name = "getSumRncKirim"
        Me.getSumRncKirim.Visible = True
        Me.getSumRncKirim.Width = 83
        '
        'SumKirim
        '
        Me.SumKirim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SumKirim.AppearanceCell.Options.UseBackColor = True
        Me.SumKirim.Caption = "Gd Out"
        Me.SumKirim.DisplayFormat.FormatString = "n0"
        Me.SumKirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SumKirim.FieldName = "SumKirim"
        Me.SumKirim.Name = "SumKirim"
        Me.SumKirim.Visible = True
        Me.SumKirim.Width = 76
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Janji Kirim"
        Me.GridBand4.Columns.Add(Me.tgl_kirim)
        Me.GridBand4.Columns.Add(Me.MaxTglKirim)
        Me.GridBand4.Columns.Add(Me.Rkirim)
        Me.GridBand4.MinWidth = 20
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 265
        '
        'tgl_kirim
        '
        Me.tgl_kirim.Caption = "Janji Kirim"
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.Width = 84
        '
        'MaxTglKirim
        '
        Me.MaxTglKirim.Caption = "Tgl Diterima"
        Me.MaxTglKirim.FieldName = "MaxTglKirim"
        Me.MaxTglKirim.Name = "MaxTglKirim"
        Me.MaxTglKirim.Visible = True
        Me.MaxTglKirim.Width = 96
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CetakSP)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 44)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(446, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 14)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "*) SP yang sudah lunas / ditutup tidak ditampilkan"
        '
        'CetakSP
        '
        Me.CetakSP.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CetakSP.Appearance.Options.UseFont = True
        Me.CetakSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CetakSP.Dock = System.Windows.Forms.DockStyle.Left
        Me.CetakSP.Image = CType(resources.GetObject("CetakSP.Image"), System.Drawing.Image)
        Me.CetakSP.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CetakSP.Location = New System.Drawing.Point(384, 0)
        Me.CetakSP.Name = "CetakSP"
        Me.CetakSP.Size = New System.Drawing.Size(57, 44)
        Me.CetakSP.TabIndex = 12
        Me.CetakSP.Tag = "Buku Service"
        Me.CetakSP.ToolTip = "Klik untuk melihat buku order spring"
        Me.CetakSP.ToolTipTitle = "Buku Order"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtCustomer)
        Me.Panel4.Controls.Add(Me.tglStop)
        Me.Panel4.Controls.Add(Me.tglStart)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(97, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 44)
        Me.Panel4.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.EnterMoveNextControl = True
        Me.txtCustomer.Location = New System.Drawing.Point(2, 23)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCustomer.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCustomer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCustomer.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", "Kode", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 150, "Nama")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.DropDownRows = 15
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.ImmediatePopup = True
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ShowPopupShadow = False
        Me.txtCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.UseCtrlScroll = True
        Me.txtCustomer.Properties.ValidateOnEnterKey = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(283, 20)
        Me.txtCustomer.TabIndex = 2
        Me.txtCustomer.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtCustomer.ToolTipTitle = "Nama Customer"
        '
        'tglStop
        '
        Me.tglStop.EditValue = Nothing
        Me.tglStop.Location = New System.Drawing.Point(144, 2)
        Me.tglStop.Name = "tglStop"
        Me.tglStop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglStop.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglStop.Size = New System.Drawing.Size(140, 20)
        Me.tglStop.TabIndex = 1
        '
        'tglStart
        '
        Me.tglStart.EditValue = Nothing
        Me.tglStart.Location = New System.Drawing.Point(3, 2)
        Me.tglStart.Name = "tglStart"
        Me.tglStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglStart.Size = New System.Drawing.Size(140, 20)
        Me.tglStart.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(97, 44)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.rdFilter)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1011, 37)
        Me.Panel2.TabIndex = 3
        '
        'rdFilter
        '
        Me.rdFilter.Location = New System.Drawing.Point(593, 2)
        Me.rdFilter.Name = "rdFilter"
        Me.rdFilter.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdFilter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFilter.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdFilter.Properties.Appearance.Options.UseBackColor = True
        Me.rdFilter.Properties.Appearance.Options.UseFont = True
        Me.rdFilter.Properties.Appearance.Options.UseForeColor = True
        Me.rdFilter.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.rdFilter.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.rdFilter.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.rdFilter.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.rdFilter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdFilter.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("", "SP SPRING UMUM"), New DevExpress.XtraEditors.Controls.RadioGroupItem("", "SP SPON UMUM"), New DevExpress.XtraEditors.Controls.RadioGroupItem("", "SP SERVICE UMUM"), New DevExpress.XtraEditors.Controls.RadioGroupItem("%%", "ALL")})
        Me.rdFilter.Size = New System.Drawing.Size(274, 29)
        Me.rdFilter.TabIndex = 18
        Me.rdFilter.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Appearance.Options.UseForeColor = True
        Me.btnRefresh.Appearance.Options.UseTextOptions = True
        Me.btnRefresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnRefresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(965, 0)
        Me.btnRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 37)
        ToolTipTitleItem1.Text = "Hint"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Tekan Untuk Refresh Data"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnRefresh.SuperTip = SuperToolTip1
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "60"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(336, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = " MONITORING STATUS SP  DAN SERVICE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(878, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(133, 44)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "DONE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmStatusSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 384)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStatusSP"
        Me.Text = "frmStatusSP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglStop.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglStop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.rdFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents Nama_Customer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents No_sp As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SumProd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents getSumRncKirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SumKirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SumKirimSJ As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SumDitermia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents MaxTglKirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Rkirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents sisa As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdFilter As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglStop As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CetakSP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
