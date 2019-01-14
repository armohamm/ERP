<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDPB
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDPB))
        Me.Sisa = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GBSP = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.no_seq = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.no_sp = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RGC = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RGV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kdstok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qtyso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.QtySp = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Qty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.QTYTOTDPM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblState = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNamaBarang = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tglRetur = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.pnlBawah = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tglRetur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBawah.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sisa
        '
        Me.Sisa.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Sisa.AppearanceCell.Options.UseFont = True
        Me.Sisa.AppearanceCell.Options.UseTextOptions = True
        Me.Sisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Sisa.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sisa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Sisa.AppearanceHeader.Options.UseBackColor = True
        Me.Sisa.AppearanceHeader.Options.UseFont = True
        Me.Sisa.AppearanceHeader.Options.UseTextOptions = True
        Me.Sisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Sisa.Caption = "Sisa"
        Me.Sisa.FieldName = "Sisa"
        Me.Sisa.Name = "Sisa"
        Me.Sisa.OptionsColumn.AllowEdit = False
        Me.Sisa.OptionsColumn.AllowFocus = False
        Me.Sisa.Visible = True
        Me.Sisa.Width = 70
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlBawah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Location = New System.Drawing.Point(28, 15)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(889, 441)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(887, 364)
        Me.pnlTengah.TabIndex = 1
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 63)
        Me.gc.MainView = Me.GV
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RGC})
        Me.gc.Size = New System.Drawing.Size(887, 301)
        Me.gc.TabIndex = 2
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
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
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBSP, Me.gridBand1})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.no_seq, Me.Kd_Stok, Me.kd_satuan, Me.Qty, Me.Sisa, Me.no_sp, Me.QtySp, Me.QTYTOTDPM})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.Sisa
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        StyleFormatCondition2.Appearance.Options.UseImage = True
        StyleFormatCondition2.Column = Me.Sisa
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "0"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV.GridControl = Me.gc
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ColumnAutoWidth = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowHorzLines = False
        Me.GV.OptionsView.ShowIndicator = False
        Me.GV.OptionsView.ShowVertLines = False
        '
        'GBSP
        '
        Me.GBSP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSP.AppearanceHeader.Options.UseFont = True
        Me.GBSP.AppearanceHeader.Options.UseTextOptions = True
        Me.GBSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBSP.Caption = "Sales Order"
        Me.GBSP.Columns.Add(Me.no_seq)
        Me.GBSP.Columns.Add(Me.no_sp)
        Me.GBSP.Columns.Add(Me.Kd_Stok)
        Me.GBSP.Columns.Add(Me.kd_satuan)
        Me.GBSP.Columns.Add(Me.QtySp)
        Me.GBSP.Name = "GBSP"
        Me.GBSP.Width = 657
        '
        'no_seq
        '
        Me.no_seq.Caption = "No"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.AllowFocus = False
        Me.no_seq.Visible = True
        Me.no_seq.Width = 45
        '
        'no_sp
        '
        Me.no_sp.Caption = "Nomor SP"
        Me.no_sp.FieldName = "no_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.AllowFocus = False
        Me.no_sp.Visible = True
        Me.no_sp.Width = 153
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.RGC
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.OptionsColumn.AllowEdit = False
        Me.Kd_Stok.OptionsColumn.AllowFocus = False
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.Width = 325
        '
        'RGC
        '
        Me.RGC.AutoHeight = False
        Me.RGC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RGC.DisplayMember = "Nama_Barang"
        Me.RGC.Name = "RGC"
        Me.RGC.PopupFormSize = New System.Drawing.Size(700, 0)
        Me.RGC.ValueMember = "Kd_Stok"
        Me.RGC.View = Me.RGV
        '
        'RGV
        '
        Me.RGV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.RGV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.RGV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.RGV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.RGV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.RGV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.RGV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RGV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.RGV.Appearance.Empty.Options.UseBackColor = True
        Me.RGV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RGV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.EvenRow.Options.UseBackColor = True
        Me.RGV.Appearance.EvenRow.Options.UseForeColor = True
        Me.RGV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.RGV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.RGV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.RGV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RGV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.RGV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.RGV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.RGV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RGV.Appearance.FixedLine.Options.UseBackColor = True
        Me.RGV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.RGV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.RGV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.RGV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.RGV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.RGV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.RGV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.RGV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.RGV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.RGV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.RGV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupButton.Options.UseBackColor = True
        Me.RGV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.RGV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.RGV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.RGV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.RGV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RGV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.RGV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.RGV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.RGV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.GroupRow.Options.UseBackColor = True
        Me.RGV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.RGV.Appearance.GroupRow.Options.UseForeColor = True
        Me.RGV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.RGV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.RGV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.RGV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.RGV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RGV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RGV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.RGV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.RGV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.HorzLine.Options.UseBackColor = True
        Me.RGV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RGV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.OddRow.Options.UseBackColor = True
        Me.RGV.Appearance.OddRow.Options.UseForeColor = True
        Me.RGV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RGV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.RGV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.RGV.Appearance.Preview.Options.UseBackColor = True
        Me.RGV.Appearance.Preview.Options.UseFont = True
        Me.RGV.Appearance.Preview.Options.UseForeColor = True
        Me.RGV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RGV.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.RGV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.RGV.Appearance.Row.Options.UseBackColor = True
        Me.RGV.Appearance.Row.Options.UseBorderColor = True
        Me.RGV.Appearance.Row.Options.UseForeColor = True
        Me.RGV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RGV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.RGV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.RGV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RGV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.RGV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.RGV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.RGV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RGV.Appearance.VertLine.Options.UseBackColor = True
        Me.RGV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSp, Me.kdstok, Me.Nama_Barang, Me.Satuan, Me.Qtyso})
        Me.RGV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RGV.Name = "RGV"
        Me.RGV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RGV.OptionsView.EnableAppearanceEvenRow = True
        Me.RGV.OptionsView.EnableAppearanceOddRow = True
        Me.RGV.OptionsView.ShowGroupPanel = False
        '
        'NoSp
        '
        Me.NoSp.Caption = "Nomor SP"
        Me.NoSp.FieldName = "No_sp"
        Me.NoSp.Name = "NoSp"
        Me.NoSp.Visible = True
        Me.NoSp.VisibleIndex = 0
        Me.NoSp.Width = 155
        '
        'kdstok
        '
        Me.kdstok.Caption = "kdstok"
        Me.kdstok.FieldName = "Kd_Stok"
        Me.kdstok.Name = "kdstok"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 2
        Me.Nama_Barang.Width = 567
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Kd_satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 3
        Me.Satuan.Width = 83
        '
        'Qtyso
        '
        Me.Qtyso.Caption = "Qty"
        Me.Qtyso.FieldName = "Qty"
        Me.Qtyso.Name = "Qtyso"
        Me.Qtyso.Visible = True
        Me.Qtyso.VisibleIndex = 1
        Me.Qtyso.Width = 68
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.AllowFocus = False
        Me.kd_satuan.Visible = True
        Me.kd_satuan.Width = 72
        '
        'QtySp
        '
        Me.QtySp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.QtySp.AppearanceCell.Options.UseFont = True
        Me.QtySp.AppearanceCell.Options.UseTextOptions = True
        Me.QtySp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QtySp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.QtySp.AppearanceHeader.Options.UseFont = True
        Me.QtySp.AppearanceHeader.Options.UseTextOptions = True
        Me.QtySp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QtySp.Caption = "Qty"
        Me.QtySp.FieldName = "QtySp"
        Me.QtySp.Name = "QtySp"
        Me.QtySp.OptionsColumn.AllowEdit = False
        Me.QtySp.OptionsColumn.AllowFocus = False
        Me.QtySp.Visible = True
        Me.QtySp.Width = 62
        '
        'gridBand1
        '
        Me.gridBand1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBand1.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand1.AppearanceHeader.Options.UseFont = True
        Me.gridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand1.Caption = "Jumlah Barang Keluar"
        Me.gridBand1.Columns.Add(Me.Qty)
        Me.gridBand1.Columns.Add(Me.QTYTOTDPM)
        Me.gridBand1.Columns.Add(Me.Sisa)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.Width = 226
        '
        'Qty
        '
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Qty.AppearanceHeader.Options.UseBackColor = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.Width = 70
        '
        'QTYTOTDPM
        '
        Me.QTYTOTDPM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.QTYTOTDPM.AppearanceCell.Options.UseFont = True
        Me.QTYTOTDPM.AppearanceCell.Options.UseTextOptions = True
        Me.QTYTOTDPM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QTYTOTDPM.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QTYTOTDPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTYTOTDPM.AppearanceHeader.Options.UseBackColor = True
        Me.QTYTOTDPM.AppearanceHeader.Options.UseFont = True
        Me.QTYTOTDPM.AppearanceHeader.Options.UseTextOptions = True
        Me.QTYTOTDPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QTYTOTDPM.Caption = "Qty Total"
        Me.QTYTOTDPM.FieldName = "QtyTot"
        Me.QTYTOTDPM.Name = "QTYTOTDPM"
        Me.QTYTOTDPM.OptionsColumn.AllowEdit = False
        Me.QTYTOTDPM.OptionsColumn.AllowFocus = False
        Me.QTYTOTDPM.Visible = True
        Me.QTYTOTDPM.Width = 86
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 63)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.txtNamaBarang)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(603, 63)
        Me.Panel5.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblState)
        Me.Panel4.Controls.Add(Me.txtBarcode)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(601, 21)
        Me.Panel4.TabIndex = 3
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Snow
        Me.lblState.Location = New System.Drawing.Point(524, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(75, 19)
        Me.lblState.TabIndex = 4
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarcode
        '
        Me.txtBarcode.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtBarcode.Location = New System.Drawing.Point(106, 0)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(418, 21)
        Me.txtBarcode.TabIndex = 2
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BARCODE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaBarang.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.ForeColor = System.Drawing.Color.Snow
        Me.txtNamaBarang.Location = New System.Drawing.Point(0, 0)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(601, 41)
        Me.txtNamaBarang.TabIndex = 5
        Me.txtNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(603, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(109, 63)
        Me.Panel3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tglRetur)
        Me.Panel2.Controls.Add(Me.txtNomor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(712, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 63)
        Me.Panel2.TabIndex = 9
        '
        'tglRetur
        '
        Me.tglRetur.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglRetur.Location = New System.Drawing.Point(0, 20)
        Me.tglRetur.Name = "tglRetur"
        Me.tglRetur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglRetur.Properties.Appearance.Options.UseBackColor = True
        Me.tglRetur.Properties.Appearance.Options.UseTextOptions = True
        Me.tglRetur.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglRetur.Size = New System.Drawing.Size(175, 20)
        Me.tglRetur.TabIndex = 1
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Size = New System.Drawing.Size(175, 20)
        Me.txtNomor.TabIndex = 0
        '
        'pnlBawah
        '
        Me.pnlBawah.Controls.Add(Me.Button1)
        Me.pnlBawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBawah.Location = New System.Drawing.Point(0, 401)
        Me.pnlBawah.Name = "pnlBawah"
        Me.pnlBawah.Size = New System.Drawing.Size(887, 38)
        Me.pnlBawah.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(887, 37)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(44, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(262, 37)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "   DAFTAR PERMINTAAN BARANG"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmDPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 484)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmDPB"
        Me.Text = "frmDPB"
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.tglRetur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBawah.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlBawah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tglRetur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents RGC As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoSp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kdstok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qtyso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents no_sp As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents QtySp As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents QTYTOTDPM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Sisa As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GBSP As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
