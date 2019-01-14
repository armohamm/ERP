<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBukuRetur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBukuRetur))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jns_retur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Jns_alasan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repAlasa = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Sts_ganti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_customer_spring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.janji_kirim_spring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_retur = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.lblFound = New System.Windows.Forms.Label
        Me.filter = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.tglSampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repAlasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVD
        '
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Stok, Me.Qty, Me.Jns_retur, Me.Jns_alasan, Me.Sts_ganti, Me.Keterangan})
        Me.GVD.GridControl = Me.GC
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.Editable = False
        Me.GVD.OptionsBehavior.ReadOnly = True
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repbarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 0
        Me.Kd_Stok.Width = 369
        '
        'repbarang
        '
        Me.repbarang.AutoHeight = False
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Barang")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.Name = "repbarang"
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 1
        Me.Qty.Width = 58
        '
        'Jns_retur
        '
        Me.Jns_retur.Caption = "Jenis"
        Me.Jns_retur.ColumnEdit = Me.repJenis
        Me.Jns_retur.FieldName = "Jns_retur"
        Me.Jns_retur.Name = "Jns_retur"
        Me.Jns_retur.Visible = True
        Me.Jns_retur.VisibleIndex = 2
        Me.Jns_retur.Width = 108
        '
        'repJenis
        '
        Me.repJenis.AutoHeight = False
        Me.repJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJenis.DisplayMember = "Desc_Data"
        Me.repJenis.Name = "repJenis"
        Me.repJenis.NullText = ""
        Me.repJenis.ValueMember = "Id_Data"
        '
        'Jns_alasan
        '
        Me.Jns_alasan.Caption = "Alasan"
        Me.Jns_alasan.ColumnEdit = Me.repAlasa
        Me.Jns_alasan.FieldName = "Jns_alasan"
        Me.Jns_alasan.Name = "Jns_alasan"
        Me.Jns_alasan.Visible = True
        Me.Jns_alasan.VisibleIndex = 3
        Me.Jns_alasan.Width = 122
        '
        'repAlasa
        '
        Me.repAlasa.AutoHeight = False
        Me.repAlasa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repAlasa.DisplayMember = "Desc_Data"
        Me.repAlasa.Name = "repAlasa"
        Me.repAlasa.NullText = ""
        Me.repAlasa.ValueMember = "Id_Data"
        '
        'Sts_ganti
        '
        Me.Sts_ganti.Caption = "Ganti"
        Me.Sts_ganti.FieldName = "Sts_ganti"
        Me.Sts_ganti.Name = "Sts_ganti"
        Me.Sts_ganti.Width = 50
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 300
        '
        'GC
        '
        Me.GC.BackgroundImage = CType(resources.GetObject("GC.BackgroundImage"), System.Drawing.Image)
        Me.GC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.LevelTemplate = Me.GVD
        GridLevelNode2.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 78)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repJenis, Me.repbarang, Me.repAlasa})
        Me.GC.Size = New System.Drawing.Size(1028, 295)
        Me.GC.TabIndex = 1
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVD})
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
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_customer_spring, Me.janji_kirim_spring, Me.No_sp, Me.Tgl_retur, Me.No_ref1})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupFormat = "{0}: [#image]{1}{2}"
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.ShowChildrenInGroupPanel = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'kd_customer_spring
        '
        Me.kd_customer_spring.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_customer_spring.AppearanceCell.Options.UseFont = True
        Me.kd_customer_spring.Caption = "Customer"
        Me.kd_customer_spring.FieldName = "Kd_Customer"
        Me.kd_customer_spring.Name = "kd_customer_spring"
        Me.kd_customer_spring.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.kd_customer_spring.Visible = True
        Me.kd_customer_spring.VisibleIndex = 1
        Me.kd_customer_spring.Width = 512
        '
        'janji_kirim_spring
        '
        Me.janji_kirim_spring.Caption = "Janji Kirim"
        Me.janji_kirim_spring.DisplayFormat.FormatString = "d"
        Me.janji_kirim_spring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.janji_kirim_spring.FieldName = "Tgl_kirim"
        Me.janji_kirim_spring.Name = "janji_kirim_spring"
        Me.janji_kirim_spring.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.janji_kirim_spring.Width = 272
        '
        'No_sp
        '
        Me.No_sp.Caption = "Nomor SP"
        Me.No_sp.FieldName = "No_retur"
        Me.No_sp.Name = "No_sp"
        Me.No_sp.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.No_sp.Visible = True
        Me.No_sp.VisibleIndex = 0
        Me.No_sp.Width = 184
        '
        'Tgl_retur
        '
        Me.Tgl_retur.Caption = "Tanggal"
        Me.Tgl_retur.FieldName = "Tgl_retur"
        Me.Tgl_retur.Name = "Tgl_retur"
        Me.Tgl_retur.Visible = True
        Me.Tgl_retur.VisibleIndex = 2
        Me.Tgl_retur.Width = 152
        '
        'No_ref1
        '
        Me.No_ref1.Caption = "Reff"
        Me.No_ref1.FieldName = "No_ref1"
        Me.No_ref1.Name = "No_ref1"
        Me.No_ref1.Visible = True
        Me.No_ref1.VisibleIndex = 3
        Me.No_ref1.Width = 159
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1028, 373)
        Me.pnl.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.lblFound)
        Me.Panel2.Controls.Add(Me.filter)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 41)
        Me.Panel2.TabIndex = 2
        '
        'cmdClear
        '
        Me.cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(447, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(45, 41)
        Me.cmdClear.TabIndex = 20
        Me.cmdClear.ToolTip = "Bersihkan Kolom"
        '
        'lblFound
        '
        Me.lblFound.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblFound.ForeColor = System.Drawing.Color.White
        Me.lblFound.Location = New System.Drawing.Point(891, 0)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(137, 41)
        Me.lblFound.TabIndex = 16
        Me.lblFound.Text = "Item Found(s) : 0"
        Me.lblFound.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'filter
        '
        Me.filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.filter.Dock = System.Windows.Forms.DockStyle.Left
        Me.filter.Image = CType(resources.GetObject("filter.Image"), System.Drawing.Image)
        Me.filter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.filter.Location = New System.Drawing.Point(402, 0)
        Me.filter.LookAndFeel.SkinName = "The Asphalt World"
        Me.filter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(45, 41)
        Me.filter.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tglSampai)
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.txtCustomer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(129, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(273, 41)
        Me.Panel4.TabIndex = 1
        '
        'tglSampai
        '
        Me.tglSampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tglSampai.EditValue = Nothing
        Me.tglSampai.Location = New System.Drawing.Point(138, 20)
        Me.tglSampai.Name = "tglSampai"
        Me.tglSampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampai.Properties.Appearance.Options.UseFont = True
        Me.tglSampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.tglSampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglSampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglSampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglSampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglSampai.Size = New System.Drawing.Size(135, 20)
        Me.tglSampai.TabIndex = 30
        '
        'tglDari
        '
        Me.tglDari.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(0, 20)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(138, 20)
        Me.tglDari.TabIndex = 29
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 100, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 150, "Alamat")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(273, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 41)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filter Tanggal :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Filter Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 37)
        Me.Panel1.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(549, 37)
        Me.lblJudul.TabIndex = 9
        Me.lblJudul.Text = "BUKU RETUR"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'XtraGridBlending1
        '
        Me.XtraGridBlending1.AlphaStyles.AddReplace("OddRow", 159)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("EvenRow", 255)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("Row", 255)
        Me.XtraGridBlending1.GridControl = Me.GC
        '
        'frmBukuRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBukuRetur"
        Me.Text = "frmBukuRetur"
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repAlasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_customer_spring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents janji_kirim_spring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents filter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jns_retur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jns_alasan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sts_ganti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repAlasa As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lblFound As System.Windows.Forms.Label
    Friend WithEvents XtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Tgl_retur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_ref1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
