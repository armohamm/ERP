<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterGroupkerja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterGroupkerja))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.group_kerja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GcDept = New DevExpress.XtraGrid.GridControl
        Me.GVApprvGroup = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Desc_Data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LokupPegawai = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
        Me.GV_Bagian = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KdBagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaBag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KetBagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RecStatBag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GcDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LokupPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Bagian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(893, 35)
        Me.Panel1.TabIndex = 19
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
        Me.Label1.Text = "         MAINTENANCE GROUP KERJA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 35)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(893, 482)
        Me.XtraTabControl1.TabIndex = 70
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel6)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(886, 453)
        Me.XtraTabPage1.Text = "Maintenance Data Group Kerja"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.cmdCancel)
        Me.Panel6.Controls.Add(Me.cmdDelete)
        Me.Panel6.Controls.Add(Me.gc)
        Me.Panel6.Controls.Add(Me.cmdSave)
        Me.Panel6.Controls.Add(Me.cmdAdd)
        Me.Panel6.Controls.Add(Me.cmdEdit)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(886, 453)
        Me.Panel6.TabIndex = 71
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 27)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(357, 333)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(287, 333)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.gc.Size = New System.Drawing.Size(886, 453)
        Me.gc.TabIndex = 66
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GridView3})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_pegawai, Me.group_kerja})
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
        'kd_pegawai
        '
        Me.kd_pegawai.Caption = "Nama Pegawai"
        Me.kd_pegawai.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.kd_pegawai.FieldName = "kd_pegawai"
        Me.kd_pegawai.Name = "kd_pegawai"
        Me.kd_pegawai.Visible = True
        Me.kd_pegawai.VisibleIndex = 0
        Me.kd_pegawai.Width = 302
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama_Pegawai")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama_Pegawai"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "kd_pegawai"
        '
        'group_kerja
        '
        Me.group_kerja.Caption = "GridColumn4"
        Me.group_kerja.Name = "group_kerja"
        Me.group_kerja.Visible = True
        Me.group_kerja.VisibleIndex = 1
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gc
        Me.GridView3.Name = "GridView3"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.Location = New System.Drawing.Point(201, 323)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(61, 323)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 27)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(131, 323)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GcDept)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(886, 453)
        Me.XtraTabPage2.Text = "Daftar Member Group Kerja"
        '
        'GcDept
        '
        Me.GcDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcDept.EmbeddedNavigator.Enabled = False
        Me.GcDept.Location = New System.Drawing.Point(0, 0)
        Me.GcDept.LookAndFeel.SkinName = "Money Twins"
        Me.GcDept.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GcDept.LookAndFeel.UseWindowsXPTheme = True
        Me.GcDept.MainView = Me.GVApprvGroup
        Me.GcDept.Name = "GcDept"
        Me.GcDept.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LokupPegawai, Me.RepositoryItemLookUpEdit2})
        Me.GcDept.ShowOnlyPredefinedDetails = True
        Me.GcDept.Size = New System.Drawing.Size(886, 453)
        Me.GcDept.TabIndex = 138
        Me.GcDept.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVApprvGroup, Me.GridView1, Me.GridView2, Me.GV_Bagian})
        '
        'GVApprvGroup
        '
        Me.GVApprvGroup.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GVApprvGroup.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVApprvGroup.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvGroup.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvGroup.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVApprvGroup.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GVApprvGroup.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvGroup.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GVApprvGroup.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.GVApprvGroup.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvGroup.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.GVApprvGroup.AppearancePrint.Lines.BackColor = System.Drawing.Color.White
        Me.GVApprvGroup.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GVApprvGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GVApprvGroup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Desc_Data, Me.Nama_Pegawai})
        Me.GVApprvGroup.DetailHeight = 600
        Me.GVApprvGroup.GridControl = Me.GcDept
        Me.GVApprvGroup.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvGroup.Name = "GVApprvGroup"
        Me.GVApprvGroup.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GVApprvGroup.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVApprvGroup.OptionsPrint.ExpandAllDetails = True
        Me.GVApprvGroup.OptionsPrint.PrintDetails = True
        Me.GVApprvGroup.OptionsPrint.PrintFilterInfo = True
        Me.GVApprvGroup.OptionsPrint.PrintHorzLines = False
        Me.GVApprvGroup.OptionsPrint.UsePrintStyles = True
        Me.GVApprvGroup.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GVApprvGroup.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvGroup.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvGroup.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.GVApprvGroup.OptionsView.ShowGroupedColumns = True
        Me.GVApprvGroup.PaintStyleName = "WindowsXP"
        Me.GVApprvGroup.RowHeight = 4
        Me.GVApprvGroup.RowSeparatorHeight = 1
        Me.GVApprvGroup.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Desc_Data
        '
        Me.Desc_Data.Caption = "Group Kerja"
        Me.Desc_Data.FieldName = "Desc_Data"
        Me.Desc_Data.Name = "Desc_Data"
        Me.Desc_Data.Visible = True
        Me.Desc_Data.VisibleIndex = 0
        '
        'Nama_Pegawai
        '
        Me.Nama_Pegawai.Caption = "Nama Pegawai"
        Me.Nama_Pegawai.FieldName = "Nama_Pegawai"
        Me.Nama_Pegawai.Name = "Nama_Pegawai"
        Me.Nama_Pegawai.Visible = True
        Me.Nama_Pegawai.VisibleIndex = 1
        '
        'LokupPegawai
        '
        Me.LokupPegawai.AutoHeight = False
        Me.LokupPegawai.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LokupPegawai.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama_Pegawai")})
        Me.LokupPegawai.DisplayMember = "Nama_Pegawai"
        Me.LokupPegawai.Name = "LokupPegawai"
        Me.LokupPegawai.ValueMember = "Kode_Pegawai"
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
        Me.Kd_Stok.ColumnEdit = Me.LokupPegawai
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
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Controls.Add(Me.XtraTabControl1)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(893, 517)
        Me.pnl.TabIndex = 69
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc_Data")})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Desc_Data"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Id_data"
        '
        'frmMasterGroupkerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(893, 517)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMasterGroupkerja"
        Me.TransparencyKey = System.Drawing.Color.PowderBlue
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GcDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LokupPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Bagian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GcDept As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVApprvGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Desc_Data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LokupPegawai As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents GV_Bagian As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KdBagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaBag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KetBagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecStatBag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents group_kerja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
