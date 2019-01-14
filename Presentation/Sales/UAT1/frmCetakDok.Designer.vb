<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakDok
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
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCetakDok))
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GVC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCetak = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVDC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tglsp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cetak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SJ_BARU = New DevExpress.XtraEditors.SimpleButton
        Me.Cetak_Ulang = New DevExpress.XtraEditors.SimpleButton
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCetak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVD
        '
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Qty, Me.kd_satuan})
        Me.GVD.GridControl = Me.GC
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.Editable = False
        Me.GVD.OptionsBehavior.ReadOnly = True
        Me.GVD.OptionsCustomization.AllowColumnMoving = False
        Me.GVD.OptionsCustomization.AllowFilter = False
        Me.GVD.OptionsCustomization.AllowGroup = False
        Me.GVD.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVD.OptionsCustomization.AllowSort = False
        Me.GVD.OptionsView.ColumnAutoWidth = False
        Me.GVD.OptionsView.ShowGroupPanel = False
        '
        'Nama_Barang
        '
        Me.Nama_Barang.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Barang.AppearanceHeader.Options.UseFont = True
        Me.Nama_Barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Barang.Caption = "Deskripsi"
        Me.Nama_Barang.FieldName = "Deskripsi"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 0
        Me.Nama_Barang.Width = 479
        '
        'Qty
        '
        Me.Qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Qty.AppearanceHeader.Options.UseFont = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 46
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "Kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 1
        Me.kd_satuan.Width = 80
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVD
        GridLevelNode1.RelationName = "Detail"
        GridLevelNode2.LevelTemplate = Me.GVC
        GridLevelNode2.RelationName = "Level1"
        GridLevelNode3.LevelTemplate = Me.GVDC
        GridLevelNode3.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2, GridLevelNode3})
        Me.GC.Location = New System.Drawing.Point(0, 37)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCetak})
        Me.GC.Size = New System.Drawing.Size(934, 334)
        Me.GC.TabIndex = 5
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVC, Me.GVDC, Me.GV, Me.GVD})
        '
        'GVC
        '
        Me.GVC.Appearance.ViewCaption.BackColor = System.Drawing.Color.Gray
        Me.GVC.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVC.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black
        Me.GVC.Appearance.ViewCaption.Options.UseBackColor = True
        Me.GVC.Appearance.ViewCaption.Options.UseFont = True
        Me.GVC.Appearance.ViewCaption.Options.UseForeColor = True
        Me.GVC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.GridColumn18
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "OK"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.GridColumn17
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Y"
        Me.GVC.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GVC.GridControl = Me.GC
        Me.GVC.Name = "GVC"
        Me.GVC.OptionsCustomization.AllowGroup = False
        Me.GVC.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVC.OptionsCustomization.AllowSort = False
        Me.GVC.OptionsView.ColumnAutoWidth = False
        Me.GVC.OptionsView.EnableAppearanceOddRow = True
        Me.GVC.OptionsView.ShowGroupPanel = False
        Me.GVC.OptionsView.ShowViewCaption = True
        Me.GVC.ViewCaption = "CETAK ULANG DOKUMEN"
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Nomor SP"
        Me.GridColumn14.FieldName = "No_sp"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 142
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Customer"
        Me.GridColumn15.FieldName = "Nama_Customer"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        Me.GridColumn15.Width = 288
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Tanggal SP"
        Me.GridColumn16.FieldName = "Tgl_sp"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.AllowFocus = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        Me.GridColumn16.Width = 95
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn17.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Cetak"
        Me.GridColumn17.ColumnEdit = Me.repCetak
        Me.GridColumn17.FieldName = "cetak"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        '
        'repCetak
        '
        Me.repCetak.AutoHeight = False
        Me.repCetak.DisplayValueChecked = "Ya"
        Me.repCetak.DisplayValueUnchecked = "Tidak"
        Me.repCetak.Name = "repCetak"
        Me.repCetak.ValueChecked = "Y"
        Me.repCetak.ValueUnchecked = "T"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Status"
        Me.GridColumn18.FieldName = "Status"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.AllowFocus = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 6
        Me.GridColumn18.Width = 309
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn19.AppearanceCell.Options.UseFont = True
        Me.GridColumn19.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn19.AppearanceHeader.Options.UseFont = True
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "Old Num"
        Me.GridColumn19.FieldName = "old_num"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 102
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn20.AppearanceHeader.Options.UseFont = True
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "GridColumn2"
        Me.GridColumn20.FieldName = "tipe_trans"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn21.AppearanceCell.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn21.AppearanceHeader.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "Owner"
        Me.GridColumn21.FieldName = "Owner"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        Me.GridColumn21.Width = 131
        '
        'GVDC
        '
        Me.GVDC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GVDC.GridControl = Me.GC
        Me.GVDC.Name = "GVDC"
        Me.GVDC.OptionsBehavior.Editable = False
        Me.GVDC.OptionsBehavior.ReadOnly = True
        Me.GVDC.OptionsCustomization.AllowColumnMoving = False
        Me.GVDC.OptionsCustomization.AllowFilter = False
        Me.GVDC.OptionsCustomization.AllowGroup = False
        Me.GVDC.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVDC.OptionsCustomization.AllowSort = False
        Me.GVDC.OptionsView.ColumnAutoWidth = False
        Me.GVDC.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Deskripsi"
        Me.GridColumn11.FieldName = "Deskripsi"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 479
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Qty"
        Me.GridColumn12.FieldName = "Qty"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 46
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Satuan"
        Me.GridColumn13.FieldName = "Kd_satuan"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 80
        '
        'GV
        '
        Me.GV.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.Appearance.ViewCaption.Options.UseFont = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sp, Me.Nama_Customer, Me.Tglsp, Me.Cetak, Me.status, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.status
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "OK"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.Cetak
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "Y"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowViewCaption = True
        Me.GV.ViewCaption = "CETAK DOKUMEN"
        Me.GV.ViewCaptionHeight = 1
        '
        'no_sp
        '
        Me.no_sp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_sp.AppearanceHeader.Options.UseFont = True
        Me.no_sp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_sp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_sp.Caption = "Nomor SP"
        Me.no_sp.FieldName = "No_sp"
        Me.no_sp.Name = "no_sp"
        Me.no_sp.OptionsColumn.AllowEdit = False
        Me.no_sp.OptionsColumn.AllowFocus = False
        Me.no_sp.Visible = True
        Me.no_sp.VisibleIndex = 1
        Me.no_sp.Width = 142
        '
        'Nama_Customer
        '
        Me.Nama_Customer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Nama_Customer.AppearanceHeader.Options.UseFont = True
        Me.Nama_Customer.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Customer.Caption = "Customer"
        Me.Nama_Customer.FieldName = "Nama_Customer"
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.OptionsColumn.AllowEdit = False
        Me.Nama_Customer.OptionsColumn.AllowFocus = False
        Me.Nama_Customer.Visible = True
        Me.Nama_Customer.VisibleIndex = 0
        Me.Nama_Customer.Width = 288
        '
        'Tglsp
        '
        Me.Tglsp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tglsp.AppearanceHeader.Options.UseFont = True
        Me.Tglsp.AppearanceHeader.Options.UseTextOptions = True
        Me.Tglsp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tglsp.Caption = "Tanggal SP"
        Me.Tglsp.FieldName = "Tgl_sp"
        Me.Tglsp.Name = "Tglsp"
        Me.Tglsp.OptionsColumn.AllowEdit = False
        Me.Tglsp.OptionsColumn.AllowFocus = False
        Me.Tglsp.Visible = True
        Me.Tglsp.VisibleIndex = 3
        Me.Tglsp.Width = 95
        '
        'Cetak
        '
        Me.Cetak.AppearanceCell.Options.UseTextOptions = True
        Me.Cetak.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cetak.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Cetak.AppearanceHeader.Options.UseFont = True
        Me.Cetak.AppearanceHeader.Options.UseTextOptions = True
        Me.Cetak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cetak.Caption = "Cetak"
        Me.Cetak.ColumnEdit = Me.repCetak
        Me.Cetak.FieldName = "cetak"
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Visible = True
        Me.Cetak.VisibleIndex = 5
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.FieldName = "Status"
        Me.status.Name = "status"
        Me.status.OptionsColumn.AllowEdit = False
        Me.status.OptionsColumn.AllowFocus = False
        Me.status.Visible = True
        Me.status.VisibleIndex = 6
        Me.status.Width = 309
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Old Num"
        Me.GridColumn1.FieldName = "old_num"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "tipe_trans"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Owner"
        Me.GridColumn3.FieldName = "Owner"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 131
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(934, 371)
        Me.pnl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SJ_BARU)
        Me.Panel1.Controls.Add(Me.Cetak_Ulang)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 37)
        Me.Panel1.TabIndex = 3
        '
        'SJ_BARU
        '
        Me.SJ_BARU.BackgroundImage = CType(resources.GetObject("SJ_BARU.BackgroundImage"), System.Drawing.Image)
        Me.SJ_BARU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SJ_BARU.Dock = System.Windows.Forms.DockStyle.Right
        Me.SJ_BARU.Image = CType(resources.GetObject("SJ_BARU.Image"), System.Drawing.Image)
        Me.SJ_BARU.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SJ_BARU.Location = New System.Drawing.Point(790, 0)
        Me.SJ_BARU.Name = "SJ_BARU"
        Me.SJ_BARU.Size = New System.Drawing.Size(48, 35)
        Me.SJ_BARU.TabIndex = 10
        Me.SJ_BARU.ToolTip = "Cetak SP Baru"
        '
        'Cetak_Ulang
        '
        Me.Cetak_Ulang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cetak_Ulang.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cetak_Ulang.Image = CType(resources.GetObject("Cetak_Ulang.Image"), System.Drawing.Image)
        Me.Cetak_Ulang.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Cetak_Ulang.Location = New System.Drawing.Point(838, 0)
        Me.Cetak_Ulang.Name = "Cetak_Ulang"
        Me.Cetak_Ulang.Size = New System.Drawing.Size(48, 35)
        Me.Cetak_Ulang.TabIndex = 11
        Me.Cetak_Ulang.ToolTip = "Cetak Ulang SP"
        '
        'btnClear
        '
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnClear.Location = New System.Drawing.Point(886, 0)
        Me.btnClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(46, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.ToolTip = "Refresh Data"
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(540, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM CETAK SURAT PEMESANAN"
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
        'frmCetakDok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 371)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmCetakDok"
        Me.Text = "frmCetakDok"
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCetak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tglsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cetak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCetak As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SJ_BARU As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cetak_Ulang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GVC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVDC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class
