<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormLaporanKasBon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormLaporanKasBon))
        Me.ref_data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.gcKasBon = New DevExpress.XtraGrid.GridControl
        Me.gvKasBon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_jur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.penambah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.pengurang_spr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pengurang_spn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pengurang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lckPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.gcKasBon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvKasBon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ref_data
        '
        Me.ref_data.Caption = "GridColumn4"
        Me.ref_data.FieldName = "ref_data"
        Me.ref_data.Name = "ref_data"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcKasBon)
        Me.pnl.Controls.Add(Me.Panel7)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1018, 548)
        Me.pnl.TabIndex = 0
        '
        'gcKasBon
        '
        Me.gcKasBon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcKasBon.Location = New System.Drawing.Point(2, 117)
        Me.gcKasBon.MainView = Me.gvKasBon
        Me.gcKasBon.Name = "gcKasBon"
        Me.gcKasBon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAngka})
        Me.gcKasBon.Size = New System.Drawing.Size(1014, 404)
        Me.gcKasBon.TabIndex = 20
        Me.gcKasBon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvKasBon})
        '
        'gvKasBon
        '
        Me.gvKasBon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvKasBon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvKasBon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvKasBon.Appearance.Empty.Options.UseBackColor = True
        Me.gvKasBon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvKasBon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvKasBon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvKasBon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvKasBon.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvKasBon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gvKasBon.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gvKasBon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvKasBon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvKasBon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvKasBon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvKasBon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvKasBon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvKasBon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvKasBon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvKasBon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvKasBon.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gvKasBon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvKasBon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvKasBon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvKasBon.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvKasBon.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvKasBon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvKasBon.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvKasBon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvKasBon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.OddRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvKasBon.Appearance.OddRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvKasBon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvKasBon.Appearance.Preview.Options.UseFont = True
        Me.gvKasBon.Appearance.Preview.Options.UseForeColor = True
        Me.gvKasBon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gvKasBon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvKasBon.Appearance.Row.Options.UseBackColor = True
        Me.gvKasBon.Appearance.Row.Options.UseFont = True
        Me.gvKasBon.Appearance.Row.Options.UseForeColor = True
        Me.gvKasBon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvKasBon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvKasBon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvKasBon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvKasBon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvKasBon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvKasBon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvKasBon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvKasBon.Appearance.VertLine.Options.UseBackColor = True
        Me.gvKasBon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_jur, Me.tgl, Me.keterangan, Me.ref_data, Me.penambah, Me.pengurang_spr, Me.pengurang_spn, Me.pengurang})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.ref_data
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[ref_data] = 'SUBTOTAL'  Or [ref_data] = 'TOTAL'  Or [ref_data] = 'SALDO'"
        Me.gvKasBon.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvKasBon.GridControl = Me.gcKasBon
        Me.gvKasBon.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.gvKasBon.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvKasBon.Name = "gvKasBon"
        Me.gvKasBon.OptionsBehavior.Editable = False
        Me.gvKasBon.OptionsBehavior.ReadOnly = True
        Me.gvKasBon.OptionsCustomization.AllowFilter = False
        Me.gvKasBon.OptionsCustomization.AllowGroup = False
        Me.gvKasBon.OptionsCustomization.AllowSort = False
        Me.gvKasBon.OptionsPrint.UsePrintStyles = True
        Me.gvKasBon.OptionsView.EnableAppearanceEvenRow = True
        Me.gvKasBon.OptionsView.EnableAppearanceOddRow = True
        Me.gvKasBon.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gvKasBon.OptionsView.ShowDetailButtons = False
        Me.gvKasBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvKasBon.OptionsView.ShowGroupPanel = False
        Me.gvKasBon.OptionsView.ShowIndicator = False
        '
        'no_jur
        '
        Me.no_jur.AppearanceCell.Options.UseTextOptions = True
        Me.no_jur.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_jur.Caption = "No. Jurnal"
        Me.no_jur.FieldName = "no_jur"
        Me.no_jur.Name = "no_jur"
        Me.no_jur.Visible = True
        Me.no_jur.VisibleIndex = 1
        '
        'tgl
        '
        Me.tgl.Caption = "Tanggal"
        Me.tgl.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl.FieldName = "tgl"
        Me.tgl.Name = "tgl"
        Me.tgl.Visible = True
        Me.tgl.VisibleIndex = 0
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 2
        '
        'penambah
        '
        Me.penambah.Caption = "Penambah"
        Me.penambah.ColumnEdit = Me.txtAngka
        Me.penambah.FieldName = "penambah"
        Me.penambah.Name = "penambah"
        Me.penambah.SummaryItem.DisplayFormat = "{0:n2}"
        Me.penambah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.penambah.Visible = True
        Me.penambah.VisibleIndex = 3
        '
        'txtAngka
        '
        Me.txtAngka.AutoHeight = False
        Me.txtAngka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtAngka.Mask.EditMask = "n2"
        Me.txtAngka.Mask.UseMaskAsDisplayFormat = True
        Me.txtAngka.Name = "txtAngka"
        '
        'pengurang_spr
        '
        Me.pengurang_spr.Caption = "Pengurang Spring"
        Me.pengurang_spr.ColumnEdit = Me.txtAngka
        Me.pengurang_spr.FieldName = "pengurang_spr"
        Me.pengurang_spr.Name = "pengurang_spr"
        Me.pengurang_spr.SummaryItem.DisplayFormat = "{0:n2}"
        Me.pengurang_spr.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pengurang_spr.Visible = True
        Me.pengurang_spr.VisibleIndex = 4
        '
        'pengurang_spn
        '
        Me.pengurang_spn.Caption = "Pengurang Spon"
        Me.pengurang_spn.ColumnEdit = Me.txtAngka
        Me.pengurang_spn.FieldName = "pengurang_spn"
        Me.pengurang_spn.Name = "pengurang_spn"
        Me.pengurang_spn.SummaryItem.DisplayFormat = "{0:n2}"
        Me.pengurang_spn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pengurang_spn.Visible = True
        Me.pengurang_spn.VisibleIndex = 5
        '
        'pengurang
        '
        Me.pengurang.Caption = "Bon Gantung"
        Me.pengurang.ColumnEdit = Me.txtAngka
        Me.pengurang.FieldName = "pengurang"
        Me.pengurang.Name = "pengurang"
        Me.pengurang.SummaryItem.DisplayFormat = "{0:n2}"
        Me.pengurang.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.pengurang.Visible = True
        Me.pengurang.VisibleIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(2, 107)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1014, 10)
        Me.Panel7.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(2, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1014, 60)
        Me.Panel4.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnRefresh)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(300, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(150, 60)
        Me.Panel5.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(0, 0)
        Me.btnRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 60)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTip = "Reset Data"
        Me.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnRefresh.ToolTipTitle = "RELOAD"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lckPeriode)
        Me.Panel3.Controls.Add(Me.LabelControl2)
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 60)
        Me.Panel3.TabIndex = 2
        '
        'lckPeriode
        '
        Me.lckPeriode.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckPeriode.EnterMoveNextControl = True
        Me.lckPeriode.Location = New System.Drawing.Point(76, 0)
        Me.lckPeriode.Name = "lckPeriode"
        Me.lckPeriode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lckPeriode.Properties.Appearance.Options.UseFont = True
        Me.lckPeriode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckPeriode.Properties.NullText = "[Pilih Periode]"
        Me.lckPeriode.Properties.ShowFooter = False
        Me.lckPeriode.Properties.ShowHeader = False
        Me.lckPeriode.Properties.ShowPopupShadow = False
        Me.lckPeriode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckPeriode.Properties.ValidateOnEnterKey = True
        Me.lckPeriode.Size = New System.Drawing.Size(200, 23)
        Me.lckPeriode.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(66, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.LabelControl2.Size = New System.Drawing.Size(10, 60)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 40)
        Me.LabelControl1.Size = New System.Drawing.Size(66, 60)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Periode"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(2, 37)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1014, 10)
        Me.Panel6.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 521)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 25)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 35)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(691, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MONITORING TRANSAKSI KAS BON"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcKasBon
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(10, 10, 20, 25)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'aFormLaporanKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 548)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormLaporanKasBon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "aFormLaporanKasBon"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.gcKasBon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvKasBon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gcKasBon As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvKasBon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lckPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_jur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ref_data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents penambah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pengurang_spr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pengurang_spn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pengurang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAngka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
