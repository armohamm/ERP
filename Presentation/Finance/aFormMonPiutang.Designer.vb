<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMonPiutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMonPiutang))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.gcMon = New DevExpress.XtraGrid.GridControl
        Me.gvMon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckTT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckCust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_cetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tot_diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lckBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlFilter = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.pnlKanan = New System.Windows.Forms.Panel
        Me.pnlButton = New System.Windows.Forms.Panel
        Me.cmbKolom = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.pnlTipeTrans = New System.Windows.Forms.Panel
        Me.lckTipeTrans = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.pnlKiri = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlTglAkhir = New System.Windows.Forms.Panel
        Me.dtpTglAkhir = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.pnlTglAwal = New System.Windows.Forms.Panel
        Me.dtpTglAwal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.gcMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckTT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckBB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.pnlKanan.SuspendLayout()
        Me.pnlButton.SuspendLayout()
        CType(Me.cmbKolom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipeTrans.SuspendLayout()
        CType(Me.lckTipeTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKiri.SuspendLayout()
        Me.pnlTglAkhir.SuspendLayout()
        CType(Me.dtpTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTglAwal.SuspendLayout()
        CType(Me.dtpTglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTglAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(997, 543)
        Me.pnl.TabIndex = 0
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.gcMon)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 97)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(997, 421)
        Me.pnlGrid.TabIndex = 141
        '
        'gcMon
        '
        Me.gcMon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMon.Location = New System.Drawing.Point(0, 0)
        Me.gcMon.MainView = Me.gvMon
        Me.gcMon.Name = "gcMon"
        Me.gcMon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lckCust, Me.lckStok, Me.lckBB, Me.lckTT})
        Me.gcMon.Size = New System.Drawing.Size(997, 421)
        Me.gcMon.TabIndex = 0
        Me.gcMon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMon})
        '
        'gvMon
        '
        Me.gvMon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gvMon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvMon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvMon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvMon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvMon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvMon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvMon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvMon.Appearance.Empty.Options.UseBackColor = True
        Me.gvMon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMon.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvMon.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvMon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.gvMon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvMon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvMon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvMon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvMon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvMon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvMon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvMon.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvMon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvMon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvMon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvMon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gvMon.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gvMon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvMon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvMon.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvMon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvMon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvMon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvMon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvMon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvMon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvMon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvMon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvMon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvMon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvMon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvMon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvMon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvMon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvMon.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvMon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvMon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvMon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvMon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvMon.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvMon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvMon.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gvMon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvMon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvMon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMon.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvMon.Appearance.OddRow.Options.UseForeColor = True
        Me.gvMon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvMon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvMon.Appearance.Preview.Options.UseFont = True
        Me.gvMon.Appearance.Preview.Options.UseForeColor = True
        Me.gvMon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvMon.Appearance.Row.Options.UseBackColor = True
        Me.gvMon.Appearance.Row.Options.UseForeColor = True
        Me.gvMon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvMon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvMon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvMon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvMon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvMon.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvMon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvMon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvMon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMon.Appearance.VertLine.Options.UseBackColor = True
        Me.gvMon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.no_inv, Me.tgl_inv, Me.no_ref1, Me.no_ref2, Me.kd_cust, Me.tgl_posting, Me.tgl_cetak, Me.jml_tagihan, Me.kd_stok, Me.satuan, Me.Qty, Me.harga, Me.tot_diskon, Me.jml_val_trans, Me.kd_buku_besar})
        Me.gvMon.GridControl = Me.gcMon
        Me.gvMon.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jml_val_trans", Me.jml_val_trans, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tot_diskon", Me.tot_diskon, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "harga", Me.harga, "{0:n2}")})
        Me.gvMon.Name = "gvMon"
        Me.gvMon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvMon.OptionsBehavior.Editable = False
        Me.gvMon.OptionsBehavior.ReadOnly = True
        Me.gvMon.OptionsPrint.ExpandAllGroups = False
        Me.gvMon.OptionsPrint.UsePrintStyles = True
        Me.gvMon.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMon.OptionsView.EnableAppearanceOddRow = True
        Me.gvMon.OptionsView.ShowFooter = True
        Me.gvMon.OptionsView.ShowIndicator = False
        Me.gvMon.PaintStyleName = "Office2003"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Tipe Transaksi"
        Me.tipe_trans.ColumnEdit = Me.lckTT
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        '
        'lckTT
        '
        Me.lckTT.AutoHeight = False
        Me.lckTT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckTT.Name = "lckTT"
        Me.lckTT.NullText = "[Tidak ada datal]"
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
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tgl. Nota"
        Me.tgl_inv.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        '
        'no_ref1
        '
        Me.no_ref1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref1.AppearanceHeader.Options.UseFont = True
        Me.no_ref1.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref1.Caption = "No. Ref. 1"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        '
        'no_ref2
        '
        Me.no_ref2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_ref2.AppearanceHeader.Options.UseFont = True
        Me.no_ref2.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref2.Caption = "No. Ref. 2"
        Me.no_ref2.FieldName = "no_ref2"
        Me.no_ref2.Name = "no_ref2"
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Customer"
        Me.kd_cust.ColumnEdit = Me.lckCust
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        '
        'lckCust
        '
        Me.lckCust.AutoHeight = False
        Me.lckCust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckCust.Name = "lckCust"
        Me.lckCust.NullText = "[Tidak ada datal]"
        Me.lckCust.ShowFooter = False
        Me.lckCust.ShowHeader = False
        Me.lckCust.ShowPopupShadow = False
        '
        'tgl_posting
        '
        Me.tgl_posting.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_posting.AppearanceHeader.Options.UseFont = True
        Me.tgl_posting.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_posting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_posting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        '
        'tgl_cetak
        '
        Me.tgl_cetak.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_cetak.AppearanceHeader.Options.UseFont = True
        Me.tgl_cetak.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_cetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_cetak.Caption = "Tgl. Cetak"
        Me.tgl_cetak.DisplayFormat.FormatString = "d MMM yyyy"
        Me.tgl_cetak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_cetak.FieldName = "tgl_cetak"
        Me.tgl_cetak.Name = "tgl_cetak"
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Tagihan"
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_tagihan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Stok"
        Me.kd_stok.ColumnEdit = Me.lckStok
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        '
        'lckStok
        '
        Me.lckStok.AutoHeight = False
        Me.lckStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckStok.Name = "lckStok"
        Me.lckStok.NullText = "[Tidak ada datal]"
        Me.lckStok.ShowFooter = False
        Me.lckStok.ShowHeader = False
        Me.lckStok.ShowPopupShadow = False
        '
        'satuan
        '
        Me.satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.satuan.AppearanceHeader.Options.UseFont = True
        Me.satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        '
        'Qty
        '
        Me.Qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty.AppearanceHeader.Options.UseFont = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.Caption = "Jumlah"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        '
        'harga
        '
        Me.harga.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.harga.AppearanceHeader.Options.UseFont = True
        Me.harga.AppearanceHeader.Options.UseTextOptions = True
        Me.harga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.harga.Caption = "Harga"
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.SummaryItem.DisplayFormat = "{0:n2}"
        Me.harga.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'tot_diskon
        '
        Me.tot_diskon.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tot_diskon.AppearanceHeader.Options.UseFont = True
        Me.tot_diskon.AppearanceHeader.Options.UseTextOptions = True
        Me.tot_diskon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tot_diskon.Caption = "Diskon"
        Me.tot_diskon.DisplayFormat.FormatString = "n2"
        Me.tot_diskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tot_diskon.FieldName = "tot_diskon"
        Me.tot_diskon.Name = "tot_diskon"
        Me.tot_diskon.SummaryItem.DisplayFormat = "{0:n2}"
        Me.tot_diskon.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_val_trans.Caption = "Total"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_val_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lckBB
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        '
        'lckBB
        '
        Me.lckBB.AutoHeight = False
        Me.lckBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckBB.Name = "lckBB"
        Me.lckBB.NullText = "[Tidak ada datal]"
        Me.lckBB.ShowFooter = False
        Me.lckBB.ShowHeader = False
        Me.lckBB.ShowPopupShadow = False
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.btnRefresh)
        Me.pnlFilter.Controls.Add(Me.pnlKanan)
        Me.pnlFilter.Controls.Add(Me.pnlKiri)
        Me.pnlFilter.Controls.Add(Me.Panel9)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 35)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(997, 62)
        Me.pnlFilter.TabIndex = 140
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(844, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 40)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'pnlKanan
        '
        Me.pnlKanan.Controls.Add(Me.pnlButton)
        Me.pnlKanan.Controls.Add(Me.Panel8)
        Me.pnlKanan.Controls.Add(Me.pnlTipeTrans)
        Me.pnlKanan.Controls.Add(Me.Panel7)
        Me.pnlKanan.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlKanan.Location = New System.Drawing.Point(525, 0)
        Me.pnlKanan.Name = "pnlKanan"
        Me.pnlKanan.Size = New System.Drawing.Size(292, 62)
        Me.pnlKanan.TabIndex = 12
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.cmbKolom)
        Me.pnlButton.Controls.Add(Me.LabelControl6)
        Me.pnlButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButton.Location = New System.Drawing.Point(0, 32)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(292, 23)
        Me.pnlButton.TabIndex = 12
        '
        'cmbKolom
        '
        Me.cmbKolom.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbKolom.EditValue = ""
        Me.cmbKolom.EnterMoveNextControl = True
        Me.cmbKolom.Location = New System.Drawing.Point(110, 0)
        Me.cmbKolom.Name = "cmbKolom"
        Me.cmbKolom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKolom.Properties.DropDownRows = 10
        Me.cmbKolom.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tipe_trans", "Tipe Transaksi"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_inv", "No. Nota"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_inv", "Tgl. Nota"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_ref1", "No. Referensi 1"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("no_ref2", "No. Referensi 2"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("kd_cust", "Customer"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_posting", "Tgl. Posting"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tgl_cetak", "Tgl. Cetak"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("jml_tagihan", "Tagihan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("kd_stok", "Stok"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("satuan", "Satuan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Qty", "Jumlah"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("harga", "Harga Satuan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("tot_diskon", "Diskon"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("jml_val_trans", "Total"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("kd_buku_besar", "Rekening")})
        Me.cmbKolom.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize
        Me.cmbKolom.Properties.SelectAllItemCaption = "(Pilih Semua)"
        Me.cmbKolom.Properties.ShowPopupShadow = False
        Me.cmbKolom.Properties.ValidateOnEnterKey = True
        Me.cmbKolom.Size = New System.Drawing.Size(182, 20)
        Me.cmbKolom.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(110, 23)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Pilih Kolom             :"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 27)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(292, 5)
        Me.Panel8.TabIndex = 11
        '
        'pnlTipeTrans
        '
        Me.pnlTipeTrans.Controls.Add(Me.lckTipeTrans)
        Me.pnlTipeTrans.Controls.Add(Me.LabelControl7)
        Me.pnlTipeTrans.Controls.Add(Me.LabelControl8)
        Me.pnlTipeTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTipeTrans.Location = New System.Drawing.Point(0, 5)
        Me.pnlTipeTrans.Name = "pnlTipeTrans"
        Me.pnlTipeTrans.Size = New System.Drawing.Size(292, 22)
        Me.pnlTipeTrans.TabIndex = 10
        '
        'lckTipeTrans
        '
        Me.lckTipeTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.lckTipeTrans.EnterMoveNextControl = True
        Me.lckTipeTrans.Location = New System.Drawing.Point(110, 0)
        Me.lckTipeTrans.Name = "lckTipeTrans"
        Me.lckTipeTrans.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckTipeTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckTipeTrans.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "Name1")})
        Me.lckTipeTrans.Properties.NullText = "[Tidak ada data]"
        Me.lckTipeTrans.Properties.ShowFooter = False
        Me.lckTipeTrans.Properties.ShowHeader = False
        Me.lckTipeTrans.Properties.ShowPopupShadow = False
        Me.lckTipeTrans.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckTipeTrans.Properties.ValidateOnEnterKey = True
        Me.lckTipeTrans.Size = New System.Drawing.Size(182, 20)
        Me.lckTipeTrans.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(100, 0)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(10, 22)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl8.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(100, 22)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Tipe Transaksi"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(292, 5)
        Me.Panel7.TabIndex = 9
        '
        'pnlKiri
        '
        Me.pnlKiri.Controls.Add(Me.Panel6)
        Me.pnlKiri.Controls.Add(Me.pnlTglAkhir)
        Me.pnlKiri.Controls.Add(Me.Panel5)
        Me.pnlKiri.Controls.Add(Me.pnlTglAwal)
        Me.pnlKiri.Controls.Add(Me.Panel4)
        Me.pnlKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlKiri.Location = New System.Drawing.Point(200, 0)
        Me.pnlKiri.Name = "pnlKiri"
        Me.pnlKiri.Size = New System.Drawing.Size(325, 62)
        Me.pnlKiri.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 5)
        Me.Panel6.TabIndex = 12
        '
        'pnlTglAkhir
        '
        Me.pnlTglAkhir.Controls.Add(Me.dtpTglAkhir)
        Me.pnlTglAkhir.Controls.Add(Me.LabelControl3)
        Me.pnlTglAkhir.Controls.Add(Me.LabelControl4)
        Me.pnlTglAkhir.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTglAkhir.Location = New System.Drawing.Point(0, 30)
        Me.pnlTglAkhir.Name = "pnlTglAkhir"
        Me.pnlTglAkhir.Size = New System.Drawing.Size(325, 20)
        Me.pnlTglAkhir.TabIndex = 11
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpTglAkhir.EditValue = Nothing
        Me.dtpTglAkhir.EnterMoveNextControl = True
        Me.dtpTglAkhir.Location = New System.Drawing.Point(110, 0)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.dtpTglAkhir.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTglAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTglAkhir.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpTglAkhir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTglAkhir.Properties.ShowPopupShadow = False
        Me.dtpTglAkhir.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpTglAkhir.Properties.ValidateOnEnterKey = True
        Me.dtpTglAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpTglAkhir.Size = New System.Drawing.Size(150, 20)
        Me.dtpTglAkhir.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(100, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Tanggal Akhir"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(325, 5)
        Me.Panel5.TabIndex = 10
        '
        'pnlTglAwal
        '
        Me.pnlTglAwal.Controls.Add(Me.dtpTglAwal)
        Me.pnlTglAwal.Controls.Add(Me.LabelControl2)
        Me.pnlTglAwal.Controls.Add(Me.LabelControl1)
        Me.pnlTglAwal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTglAwal.Location = New System.Drawing.Point(0, 5)
        Me.pnlTglAwal.Name = "pnlTglAwal"
        Me.pnlTglAwal.Size = New System.Drawing.Size(325, 20)
        Me.pnlTglAwal.TabIndex = 9
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpTglAwal.EditValue = Nothing
        Me.dtpTglAwal.EnterMoveNextControl = True
        Me.dtpTglAwal.Location = New System.Drawing.Point(110, 0)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.dtpTglAwal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTglAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTglAwal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpTglAwal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTglAwal.Properties.ShowPopupShadow = False
        Me.dtpTglAwal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpTglAwal.Properties.ValidateOnEnterKey = True
        Me.dtpTglAwal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpTglAwal.Size = New System.Drawing.Size(150, 20)
        Me.dtpTglAwal.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(100, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tanggal Awal"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(325, 5)
        Me.Panel4.TabIndex = 8
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 62)
        Me.Panel9.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 518)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 25)
        Me.Panel2.TabIndex = 139
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
        Me.Panel1.Size = New System.Drawing.Size(997, 35)
        Me.Panel1.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MONITORING TRANSAKSI AR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.gcMon
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.MinMargins = New System.Drawing.Printing.Margins(5, 5, 5, 5)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'aFormMonPiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 543)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMonPiutang"
        Me.Text = "FORM MONITORING"
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.gcMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckTT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckBB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlKanan.ResumeLayout(False)
        Me.pnlButton.ResumeLayout(False)
        CType(Me.cmbKolom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipeTrans.ResumeLayout(False)
        CType(Me.lckTipeTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKiri.ResumeLayout(False)
        Me.pnlTglAkhir.ResumeLayout(False)
        CType(Me.dtpTglAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTglAwal.ResumeLayout(False)
        CType(Me.dtpTglAwal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTglAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents pnlKanan As System.Windows.Forms.Panel
    Friend WithEvents pnlButton As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents pnlTipeTrans As System.Windows.Forms.Panel
    Friend WithEvents lckTipeTrans As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents pnlKiri As System.Windows.Forms.Panel
    Friend WithEvents cmbKolom As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlTglAkhir As System.Windows.Forms.Panel
    Friend WithEvents dtpTglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnlTglAwal As System.Windows.Forms.Panel
    Friend WithEvents dtpTglAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents gcMon As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckCust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_cetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tot_diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lckBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lckTT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
