<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonPObrg
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonPObrg))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repnum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.qty_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcApprvDPM = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVApprvDPM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Lookuptipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupsupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_cetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nstatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lokupbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PrintPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookuptipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.kd_satuan, Me.qty, Me.qty_kirim, Me.harga, Me.total})
        Me.GridView1.GridControl = Me.GcApprvDPM
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.ExpandAllDetails = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.no_seq, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'no_seq
        '
        Me.no_seq.Caption = "Nomor"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.MinWidth = 10
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 59
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Nama"
        Me.kd_stok.FieldName = "keterangan"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 513
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 2
        Me.kd_satuan.Width = 94
        '
        'qty
        '
        Me.qty.Caption = "Qty"
        Me.qty.ColumnEdit = Me.repnum
        Me.qty.DisplayFormat.FormatString = "n3"
        Me.qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty.FieldName = "qty"
        Me.qty.Name = "qty"
        Me.qty.OptionsColumn.AllowEdit = False
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 3
        Me.qty.Width = 98
        '
        'repnum
        '
        Me.repnum.AutoHeight = False
        Me.repnum.DisplayFormat.FormatString = "N2"
        Me.repnum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repnum.EditFormat.FormatString = "N2"
        Me.repnum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repnum.Name = "repnum"
        '
        'qty_kirim
        '
        Me.qty_kirim.Caption = "Qty Kirim"
        Me.qty_kirim.DisplayFormat.FormatString = "n3"
        Me.qty_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_kirim.FieldName = "qty_kirim"
        Me.qty_kirim.Name = "qty_kirim"
        Me.qty_kirim.OptionsColumn.AllowEdit = False
        Me.qty_kirim.Visible = True
        Me.qty_kirim.VisibleIndex = 4
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.ColumnEdit = Me.repnum
        Me.harga.DisplayFormat.FormatString = "N2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 5
        Me.harga.Width = 98
        '
        'total
        '
        Me.total.Caption = "Jumlah"
        Me.total.ColumnEdit = Me.repnum
        Me.total.FieldName = "total"
        Me.total.Name = "total"
        Me.total.OptionsColumn.AllowEdit = False
        Me.total.SummaryItem.DisplayFormat = "{0:n2}"
        Me.total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total.Visible = True
        Me.total.VisibleIndex = 6
        Me.total.Width = 123
        '
        'GcApprvDPM
        '
        Me.GcApprvDPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvDPM.EmbeddedNavigator.Enabled = False
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GridView2
        GridLevelNode2.RelationName = "Level2"
        Me.GcApprvDPM.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GcApprvDPM.Location = New System.Drawing.Point(0, 0)
        Me.GcApprvDPM.MainView = Me.GVApprvDPM
        Me.GcApprvDPM.Name = "GcApprvDPM"
        Me.GcApprvDPM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupDivisi, Me.RBrecstat, Me.Lokupbarang, Me.lookupsupplier, Me.Lookuptipe, Me.repnum})
        Me.GcApprvDPM.ShowOnlyPredefinedDetails = True
        Me.GcApprvDPM.Size = New System.Drawing.Size(1038, 292)
        Me.GcApprvDPM.TabIndex = 137
        Me.GcApprvDPM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GVApprvDPM, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_trans, Me.tgl_trans, Me.tgl_posting})
        Me.GridView2.GridControl = Me.GcApprvDPM
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsPrint.ExpandAllDetails = True
        Me.GridView2.OptionsPrint.PrintDetails = True
        Me.GridView2.OptionsPrint.PrintFilterInfo = True
        Me.GridView2.OptionsPrint.PrintHorzLines = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PaintStyleName = "WindowsXP"
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Transaksi"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 0
        Me.no_trans.Width = 239
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl Kirim"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 371
        '
        'tgl_posting
        '
        Me.tgl_posting.Caption = "Tgl Posting Finance"
        Me.tgl_posting.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.SummaryItem.FieldName = "qty_pr"
        Me.tgl_posting.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 2
        Me.tgl_posting.Width = 375
        '
        'GVApprvDPM
        '
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Empty.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVApprvDPM.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVApprvDPM.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVApprvDPM.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseFont = True
        Me.GVApprvDPM.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.OddRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.OddRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVApprvDPM.Appearance.Preview.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Preview.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVApprvDPM.Appearance.Row.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.Row.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVApprvDPM.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVApprvDPM.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVApprvDPM.Appearance.VertLine.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GVApprvDPM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GVApprvDPM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.no_po, Me.tgl_po, Me.kd_supplier, Me.kd_valuta, Me.jml_val_trans, Me.tgl_kirim, Me.keterangan, Me.status, Me.jml_cetak, Me.nstatus, Me.status_po})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[status_po]='OPEN'"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.GreenYellow
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[status_po]='CLOSE'"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[status_po]='OUTSTANDING'"
        Me.GVApprvDPM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GVApprvDPM.GridControl = Me.GcApprvDPM
        Me.GVApprvDPM.GroupPanelText = "Geser nama kolom kemari untuk mengelompokan data berdasarkan kolom tersebut"
        Me.GVApprvDPM.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.Name = "GVApprvDPM"
        Me.GVApprvDPM.OptionsBehavior.Editable = False
        Me.GVApprvDPM.OptionsBehavior.ReadOnly = True
        Me.GVApprvDPM.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVApprvDPM.OptionsPrint.ExpandAllDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintFilterInfo = True
        Me.GVApprvDPM.OptionsPrint.PrintHorzLines = False
        Me.GVApprvDPM.OptionsPrint.UsePrintStyles = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvDPM.OptionsView.RowAutoHeight = True
        Me.GVApprvDPM.PaintStyleName = "WindowsXP"
        Me.GVApprvDPM.RowHeight = 4
        Me.GVApprvDPM.RowSeparatorHeight = 1
        Me.GVApprvDPM.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.ViewCaption = "DATA MONITORING PO"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tipe_trans.AppearanceCell.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tipe_trans.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Jenis PO"
        Me.tipe_trans.ColumnEdit = Me.Lookuptipe
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.AllowEdit = False
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 0
        Me.tipe_trans.Width = 87
        '
        'Lookuptipe
        '
        Me.Lookuptipe.AutoHeight = False
        Me.Lookuptipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookuptipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_trans", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("accronim_desc", "Keterangan")})
        Me.Lookuptipe.DisplayMember = "accronim_desc"
        Me.Lookuptipe.Name = "Lookuptipe"
        Me.Lookuptipe.ValueMember = "tipe_trans"
        '
        'no_po
        '
        Me.no_po.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_po.AppearanceCell.Options.UseFont = True
        Me.no_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_po.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.no_po.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.no_po.AppearanceHeader.Options.UseFont = True
        Me.no_po.AppearanceHeader.Options.UseForeColor = True
        Me.no_po.AppearanceHeader.Options.UseTextOptions = True
        Me.no_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_po.Caption = "No PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.OptionsColumn.AllowEdit = False
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 1
        Me.no_po.Width = 109
        '
        'tgl_po
        '
        Me.tgl_po.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_po.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_po.AppearanceCell.Options.UseBackColor = True
        Me.tgl_po.AppearanceCell.Options.UseFont = True
        Me.tgl_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_po.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_po.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tgl_po.AppearanceHeader.Options.UseFont = True
        Me.tgl_po.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_po.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_po.Caption = "Tanggal"
        Me.tgl_po.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_po.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_po.FieldName = "tgl_po"
        Me.tgl_po.Name = "tgl_po"
        Me.tgl_po.OptionsColumn.AllowEdit = False
        Me.tgl_po.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.tgl_po.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        Me.tgl_po.Visible = True
        Me.tgl_po.VisibleIndex = 2
        Me.tgl_po.Width = 84
        '
        'kd_supplier
        '
        Me.kd_supplier.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_supplier.AppearanceCell.Options.UseFont = True
        Me.kd_supplier.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supplier.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_supplier.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.kd_supplier.AppearanceHeader.Options.UseFont = True
        Me.kd_supplier.AppearanceHeader.Options.UseForeColor = True
        Me.kd_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supplier.Caption = "Supplier"
        Me.kd_supplier.ColumnEdit = Me.lookupsupplier
        Me.kd_supplier.FieldName = "kd_supplier"
        Me.kd_supplier.MinWidth = 50
        Me.kd_supplier.Name = "kd_supplier"
        Me.kd_supplier.Visible = True
        Me.kd_supplier.VisibleIndex = 3
        Me.kd_supplier.Width = 170
        '
        'lookupsupplier
        '
        Me.lookupsupplier.AutoHeight = False
        Me.lookupsupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupsupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", "Kode")})
        Me.lookupsupplier.DisplayMember = "Nama_Supplier"
        Me.lookupsupplier.Name = "lookupsupplier"
        Me.lookupsupplier.ValueMember = "Kode_Supplier"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_valuta.AppearanceCell.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_valuta.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_valuta.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseForeColor = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 4
        Me.kd_valuta.Width = 59
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_val_trans.AppearanceCell.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_val_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jml_val_trans.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Options.UseForeColor = True
        Me.jml_val_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_val_trans.Caption = "Jumlah"
        Me.jml_val_trans.ColumnEdit = Me.repnum
        Me.jml_val_trans.DisplayFormat.FormatString = "n3"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 5
        Me.jml_val_trans.Width = 83
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_kirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_kirim.AppearanceCell.Options.UseBackColor = True
        Me.tgl_kirim.AppearanceCell.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_kirim.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_kirim.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Janji Kirim"
        Me.tgl_kirim.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 6
        Me.tgl_kirim.Width = 94
        '
        'keterangan
        '
        Me.keterangan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.keterangan.AppearanceCell.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.keterangan.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseForeColor = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 7
        Me.keterangan.Width = 120
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.AppearanceHeader.ForeColor = System.Drawing.Color.Maroon
        Me.status.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseForeColor = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.OptionsColumn.AllowEdit = False
        Me.status.Width = 65
        '
        'jml_cetak
        '
        Me.jml_cetak.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_cetak.AppearanceCell.Options.UseFont = True
        Me.jml_cetak.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_cetak.AppearanceHeader.Options.UseFont = True
        Me.jml_cetak.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_cetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_cetak.Caption = "Jumlah Cetak"
        Me.jml_cetak.FieldName = "jml_cetak"
        Me.jml_cetak.Name = "jml_cetak"
        Me.jml_cetak.Visible = True
        Me.jml_cetak.VisibleIndex = 9
        Me.jml_cetak.Width = 36
        '
        'nstatus
        '
        Me.nstatus.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nstatus.AppearanceCell.Options.UseFont = True
        Me.nstatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nstatus.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nstatus.AppearanceHeader.Options.UseFont = True
        Me.nstatus.AppearanceHeader.Options.UseForeColor = True
        Me.nstatus.AppearanceHeader.Options.UseTextOptions = True
        Me.nstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nstatus.Caption = "Status Data"
        Me.nstatus.FieldName = "nstatus"
        Me.nstatus.Name = "nstatus"
        Me.nstatus.Visible = True
        Me.nstatus.VisibleIndex = 8
        Me.nstatus.Width = 73
        '
        'status_po
        '
        Me.status_po.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status_po.AppearanceCell.Options.UseFont = True
        Me.status_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status_po.AppearanceHeader.Options.UseFont = True
        Me.status_po.Caption = "Status PO"
        Me.status_po.FieldName = "status_po"
        Me.status_po.Name = "status_po"
        Me.status_po.Visible = True
        Me.status_po.VisibleIndex = 10
        Me.status_po.Width = 91
        '
        'lookupDivisi
        '
        Me.lookupDivisi.AutoHeight = False
        Me.lookupDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupDivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Divisi")})
        Me.lookupDivisi.Name = "lookupDivisi"
        Me.lookupDivisi.NullText = "Klik disini"
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'Lokupbarang
        '
        Me.Lokupbarang.AutoHeight = False
        Me.Lokupbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lokupbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode")})
        Me.Lokupbarang.DisplayMember = "Nama_Barang"
        Me.Lokupbarang.Name = "Lokupbarang"
        Me.Lokupbarang.ValueMember = "Kode_Barang"
        '
        'PrintPreviewRepositoryItemComboBox1
        '
        Me.PrintPreviewRepositoryItemComboBox1.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MONITORING PO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1038, 403)
        Me.pnl.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcApprvDPM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 292)
        Me.Panel3.TabIndex = 144
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.tglsampai)
        Me.Panel4.Controls.Add(Me.cmdRefresh)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1038, 43)
        Me.Panel4.TabIndex = 143
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(340, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "s/d"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 46)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(168, 10)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.Mask.EditMask = "d MMM yyyy"
        Me.tglDari.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(166, 20)
        Me.tglDari.TabIndex = 27
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(404, 10)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.Mask.EditMask = "d MMM yyyy"
        Me.tglsampai.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(166, 20)
        Me.tglsampai.TabIndex = 28
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(615, -1)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(71, 42)
        Me.cmdRefresh.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 369)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1038, 34)
        Me.Panel2.TabIndex = 138
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprint.Location = New System.Drawing.Point(913, 0)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(125, 34)
        Me.btnprint.TabIndex = 10
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = False
        Me.btnprint.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(405, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(335, 3)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Update"
        Me.btnSimpan.UseVisualStyleBackColor = False
        Me.btnSimpan.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 34)
        Me.Panel1.TabIndex = 137
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcApprvDPM
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(0, 0, 5, 40)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'FrmMonPObrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 403)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmMonPObrg"
        Me.Text = "MONITORING PO"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookuptipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GcApprvDPM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lokupbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVApprvDPM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookuptipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupsupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repnum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents jml_cetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
