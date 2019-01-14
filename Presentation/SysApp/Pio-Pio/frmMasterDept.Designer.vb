<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterDept
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterDept))
        Me.GV_Bagian = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KdBagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaBag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetBagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RecStatBag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcDept = New DevExpress.XtraGrid.GridControl
        Me.GVApprvDPM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KodeDept = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RecStat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lokupbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_Seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_PR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcKet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcbStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cbStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtNamaDept = New System.Windows.Forms.TextBox
        Me.txtKodeDept = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        CType(Me.GV_Bagian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_Bagian
        '
        Me.GV_Bagian.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KdBagian, Me.NamaBag, Me.KetBagian, Me.RecStatBag})
        Me.GV_Bagian.GridControl = Me.GcDept
        Me.GV_Bagian.Name = "GV_Bagian"
        '
        'KdBagian
        '
        Me.KdBagian.Caption = "Kode Bagian"
        Me.KdBagian.FieldName = "Kode_Bagian"
        Me.KdBagian.Name = "KdBagian"
        Me.KdBagian.OptionsColumn.AllowEdit = False
        Me.KdBagian.Visible = True
        Me.KdBagian.VisibleIndex = 0
        '
        'NamaBag
        '
        Me.NamaBag.Caption = "Nama Bagian"
        Me.NamaBag.FieldName = "Nama_Bagian"
        Me.NamaBag.Name = "NamaBag"
        Me.NamaBag.OptionsColumn.AllowEdit = False
        Me.NamaBag.Visible = True
        Me.NamaBag.VisibleIndex = 1
        '
        'KetBagian
        '
        Me.KetBagian.Caption = "Keterangan"
        Me.KetBagian.FieldName = "Keterangan"
        Me.KetBagian.Name = "KetBagian"
        Me.KetBagian.OptionsColumn.AllowEdit = False
        Me.KetBagian.Visible = True
        Me.KetBagian.VisibleIndex = 2
        '
        'RecStatBag
        '
        Me.RecStatBag.Caption = "Status"
        Me.RecStatBag.FieldName = "Rec_Stat"
        Me.RecStatBag.Name = "RecStatBag"
        Me.RecStatBag.OptionsColumn.AllowEdit = False
        Me.RecStatBag.Visible = True
        Me.RecStatBag.VisibleIndex = 3
        '
        'GcDept
        '
        Me.GcDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcDept.EmbeddedNavigator.Enabled = False
        GridLevelNode1.LevelTemplate = Me.GV_Bagian
        GridLevelNode1.RelationName = "Detail Bagian"
        Me.GcDept.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcDept.Location = New System.Drawing.Point(0, 0)
        Me.GcDept.LookAndFeel.SkinName = "Money Twins"
        Me.GcDept.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GcDept.LookAndFeel.UseWindowsXPTheme = True
        Me.GcDept.MainView = Me.GVApprvDPM
        Me.GcDept.Name = "GcDept"
        Me.GcDept.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupDivisi, Me.RBrecstat, Me.Lokupbarang})
        Me.GcDept.ShowOnlyPredefinedDetails = True
        Me.GcDept.Size = New System.Drawing.Size(734, 378)
        Me.GcDept.TabIndex = 138
        Me.GcDept.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVApprvDPM, Me.GridView1, Me.GridView2, Me.GV_Bagian})
        '
        'GVApprvDPM
        '
        Me.GVApprvDPM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVApprvDPM.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVApprvDPM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvDPM.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GVApprvDPM.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvDPM.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.GVApprvDPM.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GVApprvDPM.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GVApprvDPM.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GVApprvDPM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KodeDept, Me.Departemen, Me.Ket, Me.RecStat})
        Me.GVApprvDPM.DetailHeight = 600
        Me.GVApprvDPM.GridControl = Me.GcDept
        Me.GVApprvDPM.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.Name = "GVApprvDPM"
        Me.GVApprvDPM.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GVApprvDPM.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVApprvDPM.OptionsPrint.ExpandAllDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintDetails = True
        Me.GVApprvDPM.OptionsPrint.PrintFilterInfo = True
        Me.GVApprvDPM.OptionsPrint.PrintHorzLines = False
        Me.GVApprvDPM.OptionsPrint.UsePrintStyles = True
        Me.GVApprvDPM.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GVApprvDPM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvDPM.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.GVApprvDPM.OptionsView.ShowGroupedColumns = True
        Me.GVApprvDPM.PaintStyleName = "WindowsXP"
        Me.GVApprvDPM.RowHeight = 4
        Me.GVApprvDPM.RowSeparatorHeight = 1
        Me.GVApprvDPM.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'KodeDept
        '
        Me.KodeDept.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeDept.AppearanceCell.Options.UseFont = True
        Me.KodeDept.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.KodeDept.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.KodeDept.AppearanceHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeDept.AppearanceHeader.Options.UseBackColor = True
        Me.KodeDept.AppearanceHeader.Options.UseFont = True
        Me.KodeDept.AppearanceHeader.Options.UseTextOptions = True
        Me.KodeDept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.KodeDept.Caption = "Kode Departemen"
        Me.KodeDept.FieldName = "Kd_Departemen"
        Me.KodeDept.Name = "KodeDept"
        Me.KodeDept.OptionsColumn.AllowEdit = False
        Me.KodeDept.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.KodeDept.Visible = True
        Me.KodeDept.VisibleIndex = 0
        Me.KodeDept.Width = 88
        '
        'Departemen
        '
        Me.Departemen.AppearanceHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departemen.AppearanceHeader.Options.UseFont = True
        Me.Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Departemen.Caption = "Departemen"
        Me.Departemen.FieldName = "Nama_Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.OptionsColumn.AllowEdit = False
        Me.Departemen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Departemen.Visible = True
        Me.Departemen.VisibleIndex = 1
        Me.Departemen.Width = 120
        '
        'Ket
        '
        Me.Ket.AppearanceHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ket.AppearanceHeader.Options.UseFont = True
        Me.Ket.AppearanceHeader.Options.UseTextOptions = True
        Me.Ket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ket.Caption = "Keterangan"
        Me.Ket.FieldName = "Keterangan"
        Me.Ket.Name = "Ket"
        Me.Ket.OptionsColumn.AllowEdit = False
        Me.Ket.Visible = True
        Me.Ket.VisibleIndex = 2
        Me.Ket.Width = 122
        '
        'RecStat
        '
        Me.RecStat.AppearanceHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecStat.AppearanceHeader.Options.UseFont = True
        Me.RecStat.AppearanceHeader.Options.UseTextOptions = True
        Me.RecStat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RecStat.Caption = "Status"
        Me.RecStat.FieldName = "Rec_Stat"
        Me.RecStat.Name = "RecStat"
        Me.RecStat.OptionsColumn.AllowEdit = False
        Me.RecStat.Visible = True
        Me.RecStat.VisibleIndex = 3
        Me.RecStat.Width = 78
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
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_Seq, Me.Kd_Stok, Me.Satuan, Me.Qty, Me.Qty_PR, Me.Qty_sisa})
        Me.GridView1.GridControl = Me.GcDept
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsPrint.ExpandAllDetails = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.No_Seq, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'No_Seq
        '
        Me.No_Seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_Seq.AppearanceHeader.Options.UseFont = True
        Me.No_Seq.AppearanceHeader.Options.UseTextOptions = True
        Me.No_Seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_Seq.Caption = "Nomor"
        Me.No_Seq.FieldName = "No_Seq"
        Me.No_Seq.MinWidth = 10
        Me.No_Seq.Name = "No_Seq"
        Me.No_Seq.Visible = True
        Me.No_Seq.VisibleIndex = 0
        Me.No_Seq.Width = 64
        '
        'Kd_Stok
        '
        Me.Kd_Stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kd_Stok.AppearanceHeader.Options.UseFont = True
        Me.Kd_Stok.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Stok.Caption = "Nama"
        Me.Kd_Stok.ColumnEdit = Me.Lokupbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.OptionsColumn.AllowEdit = False
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 497
        '
        'Satuan
        '
        Me.Satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Satuan.AppearanceHeader.Options.UseFont = True
        Me.Satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        '
        'Qty
        '
        Me.Qty.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.AppearanceHeader.Options.UseFont = True
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "d2"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 78
        '
        'Qty_PR
        '
        Me.Qty_PR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_PR.AppearanceHeader.Options.UseFont = True
        Me.Qty_PR.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_PR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_PR.Caption = "Qty Purc"
        Me.Qty_PR.FieldName = "Qty_PR"
        Me.Qty_PR.Name = "Qty_PR"
        Me.Qty_PR.OptionsColumn.AllowEdit = False
        Me.Qty_PR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_PR.Visible = True
        Me.Qty_PR.VisibleIndex = 4
        Me.Qty_PR.Width = 78
        '
        'Qty_sisa
        '
        Me.Qty_sisa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_sisa.AppearanceHeader.Options.UseFont = True
        Me.Qty_sisa.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty_sisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Qty_sisa.Caption = "Sisa"
        Me.Qty_sisa.FieldName = "Qty_sisa"
        Me.Qty_sisa.Name = "Qty_sisa"
        Me.Qty_sisa.OptionsColumn.AllowEdit = False
        Me.Qty_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_sisa.Visible = True
        Me.Qty_sisa.VisibleIndex = 5
        Me.Qty_sisa.Width = 91
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_pr, Me.tgl_pr, Me.GridColumn3})
        Me.GridView2.GridControl = Me.GcDept
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsPrint.ExpandAllDetails = True
        Me.GridView2.OptionsPrint.PrintDetails = True
        Me.GridView2.OptionsPrint.PrintFilterInfo = True
        Me.GridView2.OptionsPrint.PrintHorzLines = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PaintStyleName = "WindowsXP"
        '
        'no_pr
        '
        Me.no_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_pr.AppearanceHeader.Options.UseFont = True
        Me.no_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.no_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_pr.Caption = "No PR"
        Me.no_pr.FieldName = "no_pr"
        Me.no_pr.Name = "no_pr"
        Me.no_pr.Visible = True
        Me.no_pr.VisibleIndex = 0
        Me.no_pr.Width = 273
        '
        'tgl_pr
        '
        Me.tgl_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_pr.AppearanceHeader.Options.UseFont = True
        Me.tgl_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_pr.Caption = "Tanggal"
        Me.tgl_pr.FieldName = "tgl_pr"
        Me.tgl_pr.Name = "tgl_pr"
        Me.tgl_pr.Visible = True
        Me.tgl_pr.VisibleIndex = 1
        Me.tgl_pr.Width = 306
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Qty PR"
        Me.GridColumn3.FieldName = "qty_pr"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 306
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoWidth = True
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepositoryItemCheckEdit1.Caption = "TIDAK AKTIF"
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "AKTIF"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "TIDAK AKTIF"
        Me.RepositoryItemCheckEdit1.FullFocusRect = True
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.NullText = "Tidak Aktif"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "T"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(163, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(233, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(303, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         MAINTENANCE DEPARTEMEN DAN BAGIAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 35)
        Me.Panel1.TabIndex = 19
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(23, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 27)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(93, 3)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 480)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 37)
        Me.Panel2.TabIndex = 23
        Me.Panel2.Visible = False
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Controls.Add(Me.XtraTabControl1)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(23, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(748, 447)
        Me.pnl.TabIndex = 69
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 37)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(741, 407)
        Me.XtraTabControl1.TabIndex = 70
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(734, 378)
        Me.XtraTabPage1.Text = "Maintenance Data Departemen dan Bagian"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.gc)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 137)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(734, 241)
        Me.Panel6.TabIndex = 71
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(734, 241)
        Me.gc.TabIndex = 66
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNama, Me.gcKet, Me.gcbStatus})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsCustomization.AllowColumnResizing = False
        Me.gv.OptionsCustomization.AllowFilter = False
        Me.gv.OptionsCustomization.AllowGroup = False
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.RowAutoHeight = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcNama
        '
        Me.gcNama.Caption = "Nama Bagian"
        Me.gcNama.FieldName = "Nama_Bagian"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 0
        Me.gcNama.Width = 312
        '
        'gcKet
        '
        Me.gcKet.Caption = "Keterangan"
        Me.gcKet.FieldName = "Keterangan"
        Me.gcKet.Name = "gcKet"
        Me.gcKet.Visible = True
        Me.gcKet.VisibleIndex = 1
        Me.gcKet.Width = 302
        '
        'gcbStatus
        '
        Me.gcbStatus.Caption = "Status"
        Me.gcbStatus.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.gcbStatus.FieldName = "Rec_Stat"
        Me.gcbStatus.Name = "gcbStatus"
        Me.gcbStatus.Visible = True
        Me.gcbStatus.VisibleIndex = 2
        Me.gcbStatus.Width = 127
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(734, 137)
        Me.Panel3.TabIndex = 70
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.cbStatus)
        Me.Panel5.Controls.Add(Me.txtKeterangan)
        Me.Panel5.Controls.Add(Me.txtNamaDept)
        Me.Panel5.Controls.Add(Me.txtKodeDept)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(172, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(562, 137)
        Me.Panel5.TabIndex = 67
        '
        'cbStatus
        '
        Me.cbStatus.Location = New System.Drawing.Point(-1, 116)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStatus.Properties.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Size = New System.Drawing.Size(100, 20)
        Me.cbStatus.TabIndex = 69
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 40)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(560, 75)
        Me.txtKeterangan.TabIndex = 67
        '
        'txtNamaDept
        '
        Me.txtNamaDept.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaDept.Location = New System.Drawing.Point(0, 20)
        Me.txtNamaDept.Name = "txtNamaDept"
        Me.txtNamaDept.Size = New System.Drawing.Size(560, 20)
        Me.txtNamaDept.TabIndex = 66
        '
        'txtKodeDept
        '
        Me.txtKodeDept.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtKodeDept.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKodeDept.Location = New System.Drawing.Point(0, 0)
        Me.txtKodeDept.MaxLength = 12
        Me.txtKodeDept.Name = "txtKodeDept"
        Me.txtKodeDept.ReadOnly = True
        Me.txtKodeDept.Size = New System.Drawing.Size(560, 20)
        Me.txtKodeDept.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 137)
        Me.Panel4.TabIndex = 66
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(0, 115)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(170, 20)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Status :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 75)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Keterangan :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Nama Departement :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Kode Departement :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GcDept)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(734, 378)
        Me.XtraTabPage2.Text = "Daftar Departmen dan Bagian"
        '
        'frmMasterDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(893, 517)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMasterDept"
        Me.TransparencyKey = System.Drawing.Color.PowderBlue
        CType(Me.GV_Bagian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lokupbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaDept As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeDept As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcbStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GcDept As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Bagian As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVApprvDPM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KodeDept As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecStat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lokupbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_PR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KdBagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaBag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetBagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecStatBag As DevExpress.XtraGrid.Columns.GridColumn
End Class
