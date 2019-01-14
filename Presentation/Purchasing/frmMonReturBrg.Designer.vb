<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonReturBrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonReturBrg))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_Retur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tanggl_Po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.periode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tahun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total_rp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItem1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repDep = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.repTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmdGroup = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(997, 419)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 79)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repDep, Me.repTrans, Me.RepositoryItem1})
        Me.GC.Size = New System.Drawing.Size(997, 340)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.ActiveFilterEnabled = False
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_Retur, Me.Tanggal, Me.no_po, Me.Tanggl_Po, Me.nama_supplier, Me.nama_barang, Me.satuan, Me.qty, Me.jml_rp_trans, Me.keterangan, Me.periode, Me.tahun, Me.bulan, Me.qty_total, Me.total_rp, Me.status})
        Me.GV.GridControl = Me.GC
        Me.GV.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.PaintStyleName = "WindowsXP"
        Me.GV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GV.ViewCaption = "DATA RETUR PEMBELIAN"
        '
        'No_Retur
        '
        Me.No_Retur.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_Retur.AppearanceHeader.Options.UseFont = True
        Me.No_Retur.Caption = "Nomor Retur"
        Me.No_Retur.FieldName = "no_retur"
        Me.No_Retur.Name = "No_Retur"
        Me.No_Retur.Visible = True
        Me.No_Retur.VisibleIndex = 0
        Me.No_Retur.Width = 65
        '
        'Tanggal
        '
        Me.Tanggal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.AppearanceHeader.Options.UseFont = True
        Me.Tanggal.Caption = "Tgl.Retur"
        Me.Tanggal.DisplayFormat.FormatString = "d MMM yyyy"
        Me.Tanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggal.FieldName = "tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Tanggal.Visible = True
        Me.Tanggal.VisibleIndex = 1
        Me.Tanggal.Width = 65
        '
        'no_po
        '
        Me.no_po.Caption = "No PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 2
        Me.no_po.Width = 65
        '
        'Tanggl_Po
        '
        Me.Tanggl_Po.Caption = "Tgl.PO"
        Me.Tanggl_Po.DisplayFormat.FormatString = "d MMM yyyy"
        Me.Tanggl_Po.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Tanggl_Po.FieldName = "tgl_po"
        Me.Tanggl_Po.Name = "Tanggl_Po"
        Me.Tanggl_Po.Visible = True
        Me.Tanggl_Po.VisibleIndex = 3
        Me.Tanggl_Po.Width = 65
        '
        'nama_supplier
        '
        Me.nama_supplier.Caption = "Nama Supplier"
        Me.nama_supplier.FieldName = "nama_supplier"
        Me.nama_supplier.Name = "nama_supplier"
        Me.nama_supplier.Visible = True
        Me.nama_supplier.VisibleIndex = 4
        Me.nama_supplier.Width = 65
        '
        'nama_barang
        '
        Me.nama_barang.Caption = "Nama Barang"
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 5
        Me.nama_barang.Width = 79
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 6
        Me.satuan.Width = 63
        '
        'qty
        '
        Me.qty.Caption = "QTY"
        Me.qty.DisplayFormat.FormatString = "n2"
        Me.qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty.FieldName = "qty"
        Me.qty.Name = "qty"
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 7
        Me.qty.Width = 63
        '
        'jml_rp_trans
        '
        Me.jml_rp_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_rp_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_rp_trans.Caption = "Rupiah"
        Me.jml_rp_trans.DisplayFormat.FormatString = "n2"
        Me.jml_rp_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_rp_trans.FieldName = "jml_rp_trans"
        Me.jml_rp_trans.Name = "jml_rp_trans"
        Me.jml_rp_trans.SummaryItem.DisplayFormat = "{0:2}"
        Me.jml_rp_trans.SummaryItem.FieldName = "VALTRANS"
        Me.jml_rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_rp_trans.Visible = True
        Me.jml_rp_trans.VisibleIndex = 8
        Me.jml_rp_trans.Width = 63
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 9
        Me.keterangan.Width = 63
        '
        'periode
        '
        Me.periode.Caption = "Periode"
        Me.periode.FieldName = "periode"
        Me.periode.Name = "periode"
        Me.periode.Visible = True
        Me.periode.VisibleIndex = 10
        Me.periode.Width = 63
        '
        'tahun
        '
        Me.tahun.Caption = "Tahun"
        Me.tahun.FieldName = "tahun"
        Me.tahun.Name = "tahun"
        Me.tahun.Visible = True
        Me.tahun.VisibleIndex = 11
        Me.tahun.Width = 63
        '
        'bulan
        '
        Me.bulan.Caption = "Bulan"
        Me.bulan.FieldName = "bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.Visible = True
        Me.bulan.VisibleIndex = 12
        Me.bulan.Width = 63
        '
        'qty_total
        '
        Me.qty_total.Caption = "Total QTY"
        Me.qty_total.DisplayFormat.FormatString = "N2"
        Me.qty_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_total.FieldName = "qty_total"
        Me.qty_total.Name = "qty_total"
        Me.qty_total.Visible = True
        Me.qty_total.VisibleIndex = 13
        Me.qty_total.Width = 57
        '
        'total_rp
        '
        Me.total_rp.Caption = "Total Rp"
        Me.total_rp.DisplayFormat.FormatString = "n2"
        Me.total_rp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total_rp.FieldName = "total_rp"
        Me.total_rp.Name = "total_rp"
        Me.total_rp.Visible = True
        Me.total_rp.VisibleIndex = 14
        Me.total_rp.Width = 74
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.Caption = "Status Barang"
        Me.status.ColumnEdit = Me.RepositoryItem1
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.status.Visible = True
        Me.status.VisibleIndex = 15
        '
        'RepositoryItem1
        '
        Me.RepositoryItem1.AutoHeight = False
        Me.RepositoryItem1.DisplayValueChecked = "Y"
        Me.RepositoryItem1.DisplayValueGrayed = "N"
        Me.RepositoryItem1.DisplayValueUnchecked = "N"
        Me.RepositoryItem1.Name = "RepositoryItem1"
        Me.RepositoryItem1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItem1.ValueChecked = "Y"
        Me.RepositoryItem1.ValueGrayed = "N"
        Me.RepositoryItem1.ValueUnchecked = "N"
        '
        'repDep
        '
        Me.repDep.AutoHeight = False
        Me.repDep.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDep.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama_Departemen")})
        Me.repDep.DisplayMember = "Nama_Departemen"
        Me.repDep.Name = "repDep"
        Me.repDep.NullText = ""
        Me.repDep.ValueMember = "Kd_Departemen"
        '
        'repTrans
        '
        Me.repTrans.AutoHeight = False
        Me.repTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTrans.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "tipe_desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_trans", "Name2", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.repTrans.DisplayMember = "tipe_desc"
        Me.repTrans.Name = "repTrans"
        Me.repTrans.NullText = ""
        Me.repTrans.ValueMember = "tipe_trans"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.tglDari)
        Me.Panel2.Controls.Add(Me.tglsampai)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 42)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(641, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "s/d"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(909, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(854, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 3
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(481, 11)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.Mask.EditMask = "d MMM yyyy"
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(154, 20)
        Me.tglDari.TabIndex = 22
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(694, 11)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(154, 20)
        Me.tglsampai.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(344, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 42)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdGroup)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(205, 42)
        Me.Panel6.TabIndex = 5
        '
        'cmdGroup
        '
        Me.cmdGroup.EditValue = ""
        Me.cmdGroup.Location = New System.Drawing.Point(-14, 11)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_retur", "Nomor Retur"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tanggal", "Tgl. Retur"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_po", "No PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_po", "Tgl.PO"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("nama_supplier", "Nama Supplier"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("nama_barang", "Nama Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("satuan", "Satuan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("qty", "QTY"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("jml_rp_trans", "Jumlah Rp"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("keterangan", "Keterangan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("periode", "Periode"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tahun", "Tahun"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("bulan", "Bulan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("status", "Status")})
        Me.cmdGroup.Size = New System.Drawing.Size(216, 20)
        Me.cmdGroup.TabIndex = 32
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 42)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(-3, 11)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 20)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Filter Kolom : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(328, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING RETUR PEMBELIAN"
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
        'frmMonReturBrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 419)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonReturBrg"
        Me.Text = "MONITORING RETUR  PEMBELIAN"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_Retur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDep As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents periode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdGroup As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents total_rp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tanggl_Po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItem1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
