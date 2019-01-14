<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonBKReturPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonBKReturPO))
        Me.GcINV_Ret = New DevExpress.XtraGrid.GridControl
        Me.GvINV_Ret = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_out = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gudang_asal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgAsal = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gudang_tujuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_GdgTujuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.penerima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_retur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBatal = New System.Windows.Forms.Button
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnUbah = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.btnHapus = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblNmBrg = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TxbBarcode = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvINV_Ret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcINV_Ret
        '
        Me.GcINV_Ret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcINV_Ret.Location = New System.Drawing.Point(0, 0)
        Me.GcINV_Ret.MainView = Me.GvINV_Ret
        Me.GcINV_Ret.Name = "GcINV_Ret"
        Me.GcINV_Ret.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepBarang, Me.RepSupplier, Me.RL_GdgAsal, Me.RL_GdgTujuan})
        Me.GcINV_Ret.Size = New System.Drawing.Size(1021, 270)
        Me.GcINV_Ret.TabIndex = 6
        Me.GcINV_Ret.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvINV_Ret})
        '
        'GvINV_Ret
        '
        Me.GvINV_Ret.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.Empty.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GvINV_Ret.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GvINV_Ret.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GvINV_Ret.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GvINV_Ret.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GvINV_Ret.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GvINV_Ret.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.GvINV_Ret.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GvINV_Ret.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GvINV_Ret.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GvINV_Ret.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.OddRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.OddRow.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.OddRow.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GvINV_Ret.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GvINV_Ret.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GvINV_Ret.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GvINV_Ret.Appearance.Preview.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.Preview.Options.UseBorderColor = True
        Me.GvINV_Ret.Appearance.Preview.Options.UseFont = True
        Me.GvINV_Ret.Appearance.Preview.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GvINV_Ret.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvINV_Ret.Appearance.Row.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.Row.Options.UseForeColor = True
        Me.GvINV_Ret.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GvINV_Ret.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GvINV_Ret.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvINV_Ret.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvINV_Ret.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GvINV_Ret.Appearance.VertLine.Options.UseBackColor = True
        Me.GvINV_Ret.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.no_trans, Me.tgl_trans, Me.kd_supplier, Me.kd_stok, Me.kd_satuan, Me.qty_order, Me.qty_out, Me.qty_sisa, Me.gudang_asal, Me.gudang_tujuan, Me.penerima, Me.status_retur})
        Me.GvINV_Ret.GridControl = Me.GcINV_Ret
        Me.GvINV_Ret.Name = "GvINV_Ret"
        Me.GvINV_Ret.OptionsCustomization.AllowColumnMoving = False
        Me.GvINV_Ret.OptionsCustomization.AllowFilter = False
        Me.GvINV_Ret.OptionsCustomization.AllowGroup = False
        Me.GvINV_Ret.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvINV_Ret.OptionsView.EnableAppearanceEvenRow = True
        Me.GvINV_Ret.OptionsView.EnableAppearanceOddRow = True
        Me.GvINV_Ret.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvINV_Ret.OptionsView.RowAutoHeight = True
        Me.GvINV_Ret.OptionsView.ShowFooter = True
        Me.GvINV_Ret.OptionsView.ShowGroupPanel = False
        Me.GvINV_Ret.OptionsView.ShowViewCaption = True
        Me.GvINV_Ret.ViewCaption = "Monitoring Barang Keluar Retur Pembelian (PO)"
        '
        'no_seq
        '
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 20
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Transaksi"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 1
        Me.no_trans.Width = 73
        '
        'kd_supplier
        '
        Me.kd_supplier.Caption = "Supplier"
        Me.kd_supplier.ColumnEdit = Me.RepSupplier
        Me.kd_supplier.FieldName = "kd_supplier"
        Me.kd_supplier.Name = "kd_supplier"
        Me.kd_supplier.OptionsColumn.AllowEdit = False
        Me.kd_supplier.OptionsColumn.ReadOnly = True
        Me.kd_supplier.Visible = True
        Me.kd_supplier.VisibleIndex = 3
        Me.kd_supplier.Width = 47
        '
        'RepSupplier
        '
        Me.RepSupplier.AutoHeight = False
        Me.RepSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepSupplier.Name = "RepSupplier"
        Me.RepSupplier.NullText = ""
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RepBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 4
        Me.kd_stok.Width = 297
        '
        'RepBarang
        '
        Me.RepBarang.AutoHeight = False
        Me.RepBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepBarang.Name = "RepBarang"
        Me.RepBarang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 5
        Me.kd_satuan.Width = 40
        '
        'qty_order
        '
        Me.qty_order.Caption = "Qty Retur"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 6
        Me.qty_order.Width = 56
        '
        'qty_out
        '
        Me.qty_out.Caption = "Qty Out"
        Me.qty_out.FieldName = "qty_out"
        Me.qty_out.Name = "qty_out"
        Me.qty_out.Visible = True
        Me.qty_out.VisibleIndex = 7
        Me.qty_out.Width = 46
        '
        'qty_sisa
        '
        Me.qty_sisa.Caption = "Qty sisa"
        Me.qty_sisa.FieldName = "qty_sisa"
        Me.qty_sisa.Name = "qty_sisa"
        Me.qty_sisa.OptionsColumn.AllowEdit = False
        Me.qty_sisa.OptionsColumn.ReadOnly = True
        Me.qty_sisa.Visible = True
        Me.qty_sisa.VisibleIndex = 8
        Me.qty_sisa.Width = 48
        '
        'gudang_asal
        '
        Me.gudang_asal.Caption = "Gudang Asal"
        Me.gudang_asal.ColumnEdit = Me.RL_GdgAsal
        Me.gudang_asal.FieldName = "gudang_asal"
        Me.gudang_asal.Name = "gudang_asal"
        Me.gudang_asal.OptionsColumn.AllowEdit = False
        Me.gudang_asal.OptionsColumn.ReadOnly = True
        Me.gudang_asal.Visible = True
        Me.gudang_asal.VisibleIndex = 9
        Me.gudang_asal.Width = 78
        '
        'RL_GdgAsal
        '
        Me.RL_GdgAsal.AutoHeight = False
        Me.RL_GdgAsal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgAsal.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgAsal.Name = "RL_GdgAsal"
        Me.RL_GdgAsal.NullText = ""
        '
        'gudang_tujuan
        '
        Me.gudang_tujuan.Caption = "Gudang Tujuan"
        Me.gudang_tujuan.ColumnEdit = Me.RL_GdgTujuan
        Me.gudang_tujuan.FieldName = "gudang_tujuan"
        Me.gudang_tujuan.Name = "gudang_tujuan"
        Me.gudang_tujuan.Visible = True
        Me.gudang_tujuan.VisibleIndex = 10
        Me.gudang_tujuan.Width = 85
        '
        'RL_GdgTujuan
        '
        Me.RL_GdgTujuan.AutoHeight = False
        Me.RL_GdgTujuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_GdgTujuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Gudang", "Gudang")})
        Me.RL_GdgTujuan.Name = "RL_GdgTujuan"
        Me.RL_GdgTujuan.NullText = ""
        '
        'penerima
        '
        Me.penerima.Caption = "Penerima"
        Me.penerima.FieldName = "penerima"
        Me.penerima.Name = "penerima"
        Me.penerima.OptionsColumn.AllowEdit = False
        Me.penerima.OptionsColumn.ReadOnly = True
        Me.penerima.SummaryItem.FieldName = "rp_trans"
        Me.penerima.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.penerima.Visible = True
        Me.penerima.VisibleIndex = 11
        Me.penerima.Width = 72
        '
        'status_retur
        '
        Me.status_retur.Caption = "Status Retur"
        Me.status_retur.FieldName = "status_retur"
        Me.status_retur.Name = "status_retur"
        Me.status_retur.Visible = True
        Me.status_retur.VisibleIndex = 12
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBatal.Location = New System.Drawing.Point(494, 7)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(64, 27)
        Me.btnBatal.TabIndex = 30
        Me.btnBatal.Text = "Bata&l"
        Me.btnBatal.UseVisualStyleBackColor = False
        Me.btnBatal.Visible = False
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUbah.Location = New System.Drawing.Point(253, 7)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(64, 27)
        Me.btnUbah.TabIndex = 29
        Me.btnUbah.Text = "&Edit"
        Me.btnUbah.UseVisualStyleBackColor = False
        Me.btnUbah.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(185, 7)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(62, 27)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        Me.btnTambah.Visible = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHapus.Location = New System.Drawing.Point(394, 7)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(64, 27)
        Me.btnHapus.TabIndex = 27
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        Me.btnHapus.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnUbah)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1021, 37)
        Me.Panel2.TabIndex = 152
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(591, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(324, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        Me.btnSimpan.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcINV_Ret)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 88)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1021, 270)
        Me.Panel5.TabIndex = 2
        '
        'lblNmBrg
        '
        Me.lblNmBrg.AutoSize = True
        Me.lblNmBrg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmBrg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNmBrg.Location = New System.Drawing.Point(491, 9)
        Me.lblNmBrg.Name = "lblNmBrg"
        Me.lblNmBrg.Size = New System.Drawing.Size(0, 15)
        Me.lblNmBrg.TabIndex = 157
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(352, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Kode Barcode"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1021, 88)
        Me.Panel3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 37)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1021, 51)
        Me.Panel6.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnprin)
        Me.Panel7.Controls.Add(Me.cmdClear)
        Me.Panel7.Controls.Add(Me.cmdRefresh)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1021, 51)
        Me.Panel7.TabIndex = 7
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.Image = Global.Presentation.My.Resources.Resources.printer2
        Me.btnprin.ImageIndex = 10
        Me.btnprin.Location = New System.Drawing.Point(618, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(100, 51)
        Me.btnprin.TabIndex = 38
        Me.btnprin.Text = "Cetak"
        Me.btnprin.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(569, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 51)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(520, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 51)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lookupBulanAwal)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.tglsampai)
        Me.Panel8.Controls.Add(Me.tglDari)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(211, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(309, 51)
        Me.Panel8.TabIndex = 32
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(524, 12)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(171, 20)
        Me.lookupBulanAwal.TabIndex = 57
        Me.lookupBulanAwal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "s/d"
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(169, 12)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(116, 20)
        Me.tglsampai.TabIndex = 25
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(6, 12)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 51)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Filter Tanggal : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Barang Keluar Retur Pembelian (PO)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblNmBrg)
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxbBarcode)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 358)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1021, 30)
        Me.Panel4.TabIndex = 1
        '
        'TxbBarcode
        '
        Me.TxbBarcode.BackColor = System.Drawing.Color.White
        Me.TxbBarcode.Location = New System.Drawing.Point(112, 7)
        Me.TxbBarcode.Name = "TxbBarcode"
        Me.TxbBarcode.Size = New System.Drawing.Size(218, 20)
        Me.TxbBarcode.TabIndex = 154
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
        Me.Panel1.Size = New System.Drawing.Size(1021, 38)
        Me.Panel1.TabIndex = 151
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1021, 388)
        Me.pnl.TabIndex = 153
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal Retur"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 2
        '
        'MonBKReturPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 388)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl)
        Me.Name = "MonBKReturPO"
        Me.Text = "MonBKReturPO"
        CType(Me.GcINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvINV_Ret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_GdgTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GcINV_Ret As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvINV_Ret As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_out As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gudang_asal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_GdgAsal As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gudang_tujuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_GdgTujuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents penerima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblNmBrg As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents status_retur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
End Class
