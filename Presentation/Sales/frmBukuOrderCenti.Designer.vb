<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBukuOrderCenti

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBukuOrderCenti))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.isClosed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GVSpon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_customer_spring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_NoTelp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtySpring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.janji_kirim_spring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMem = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Realisasi_Kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desc_promo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Owner = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTipeTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblFound = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.rdFilter = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmdBarang = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.filter = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmdTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdMerk = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdJenis = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbDivisi = New DevExpress.XtraEditors.LookUpEdit
        Me.tglSampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnBuku = New DevExpress.XtraEditors.SimpleButton
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTipeTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.rdFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.cmdTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'isClosed
        '
        Me.isClosed.Caption = "CLOSED"
        Me.isClosed.FieldName = "isClosed"
        Me.isClosed.Name = "isClosed"
        Me.isClosed.Width = 57
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 20
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1001, 418)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.BackgroundImage = CType(resources.GetObject("GC.BackgroundImage"), System.Drawing.Image)
        Me.GC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 119)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.GVSpon
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repTipeTrans, Me.repMem})
        Me.GC.Size = New System.Drawing.Size(1001, 299)
        Me.GC.TabIndex = 1
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSpon})
        '
        'GVSpon
        '
        Me.GVSpon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSpon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.Empty.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVSpon.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSpon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVSpon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSpon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSpon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Options.UseBackColor = True
        Me.GVSpon.Appearance.Preview.Options.UseFont = True
        Me.GVSpon.Appearance.Preview.Options.UseForeColor = True
        Me.GVSpon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.Row.Options.UseBackColor = True
        Me.GVSpon.Appearance.Row.Options.UseBorderColor = True
        Me.GVSpon.Appearance.Row.Options.UseForeColor = True
        Me.GVSpon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSpon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVSpon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSpon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_customer_spring, Me.Alamat_cust, Me.col_NoTelp, Me.QtySpring, Me.janji_kirim_spring, Me.No_sp, Me.ukuran, Me.Keterangan, Me.Realisasi_Kirim, Me.GridColumn1, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn2, Me.isClosed, Me.desc_promo, Me.Status, Me.Owner, Me.Tipe_trans})
        Me.GVSpon.FixedLineWidth = 1
        Me.GVSpon.GridControl = Me.GC
        Me.GVSpon.GroupFormat = "{0}: [#image]{1}{2}"
        Me.GVSpon.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.QtySpring, "{0:#,##0}")})
        Me.GVSpon.Name = "GVSpon"
        Me.GVSpon.OptionsBehavior.Editable = False
        Me.GVSpon.OptionsBehavior.ReadOnly = True
        Me.GVSpon.OptionsCustomization.AllowColumnMoving = False
        Me.GVSpon.OptionsPrint.ExpandAllDetails = True
        Me.GVSpon.OptionsView.AllowCellMerge = True
        Me.GVSpon.OptionsView.ColumnAutoWidth = False
        Me.GVSpon.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSpon.OptionsView.EnableAppearanceOddRow = True
        Me.GVSpon.OptionsView.ShowChildrenInGroupPanel = True
        Me.GVSpon.OptionsView.ShowFooter = True
        Me.GVSpon.OptionsView.ShowGroupPanel = False
        Me.GVSpon.RowHeight = 1
        Me.GVSpon.Tag = "Double Klik Untuk Melihat Detail SP"
        '
        'kd_customer_spring
        '
        Me.kd_customer_spring.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_customer_spring.AppearanceCell.Options.UseFont = True
        Me.kd_customer_spring.Caption = "Customer"
        Me.kd_customer_spring.FieldName = "Nama_Customer"
        Me.kd_customer_spring.Name = "kd_customer_spring"
        Me.kd_customer_spring.Visible = True
        Me.kd_customer_spring.VisibleIndex = 0
        Me.kd_customer_spring.Width = 149
        '
        'Alamat_cust
        '
        Me.Alamat_cust.Caption = "Alamat"
        Me.Alamat_cust.FieldName = "Almt_pnrm"
        Me.Alamat_cust.Name = "Alamat_cust"
        Me.Alamat_cust.Visible = True
        Me.Alamat_cust.VisibleIndex = 1
        Me.Alamat_cust.Width = 185
        '
        'col_NoTelp
        '
        Me.col_NoTelp.Caption = "No. Telp"
        Me.col_NoTelp.FieldName = "No_Telp"
        Me.col_NoTelp.Name = "col_NoTelp"
        Me.col_NoTelp.Visible = True
        Me.col_NoTelp.VisibleIndex = 2
        '
        'QtySpring
        '
        Me.QtySpring.Caption = "Jml"
        Me.QtySpring.DisplayFormat.FormatString = "n0"
        Me.QtySpring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QtySpring.FieldName = "Qty"
        Me.QtySpring.Name = "QtySpring"
        Me.QtySpring.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.QtySpring.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.QtySpring.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QtySpring.Visible = True
        Me.QtySpring.VisibleIndex = 9
        Me.QtySpring.Width = 64
        '
        'janji_kirim_spring
        '
        Me.janji_kirim_spring.Caption = "Janji Kirim"
        Me.janji_kirim_spring.DisplayFormat.FormatString = "d"
        Me.janji_kirim_spring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.janji_kirim_spring.FieldName = "Tgl_kirim"
        Me.janji_kirim_spring.Name = "janji_kirim_spring"
        Me.janji_kirim_spring.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.janji_kirim_spring.Visible = True
        Me.janji_kirim_spring.VisibleIndex = 12
        Me.janji_kirim_spring.Width = 84
        '
        'No_sp
        '
        Me.No_sp.Caption = "Nomor SP"
        Me.No_sp.FieldName = "No_sp"
        Me.No_sp.Name = "No_sp"
        Me.No_sp.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.No_sp.ToolTip = "Double Klik Baris Untuk Melihat Detail SP"
        Me.No_sp.Visible = True
        Me.No_sp.VisibleIndex = 3
        Me.No_sp.Width = 143
        '
        'ukuran
        '
        Me.ukuran.Caption = "Ukuran"
        Me.ukuran.FieldName = "Nama_Ukuran"
        Me.ukuran.Name = "ukuran"
        Me.ukuran.Width = 97
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.ColumnEdit = Me.repMem
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 10
        Me.Keterangan.Width = 168
        '
        'repMem
        '
        Me.repMem.Name = "repMem"
        Me.repMem.ReadOnly = True
        '
        'Realisasi_Kirim
        '
        Me.Realisasi_Kirim.Caption = "Realisasi Kirim"
        Me.Realisasi_Kirim.FieldName = "realisasi_tgl_kirim"
        Me.Realisasi_Kirim.Name = "Realisasi_Kirim"
        Me.Realisasi_Kirim.Visible = True
        Me.Realisasi_Kirim.VisibleIndex = 13
        Me.Realisasi_Kirim.Width = 87
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Deskripsi"
        Me.GridColumn1.FieldName = "Deskripsi"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 328
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tebal"
        Me.GridColumn4.FieldName = "tebal"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Lebar"
        Me.GridColumn5.FieldName = "lebar"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Panjang"
        Me.GridColumn6.FieldName = "panjang"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "OldNum"
        Me.GridColumn2.FieldName = "old_num"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 66
        '
        'desc_promo
        '
        Me.desc_promo.Caption = "Promo"
        Me.desc_promo.ColumnEdit = Me.repMem
        Me.desc_promo.FieldName = "desc_promo"
        Me.desc_promo.Name = "desc_promo"
        Me.desc_promo.Visible = True
        Me.desc_promo.VisibleIndex = 11
        Me.desc_promo.Width = 155
        '
        'Owner
        '
        Me.Owner.Caption = "Owner"
        Me.Owner.FieldName = "Owner"
        Me.Owner.Name = "Owner"
        Me.Owner.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Owner.Visible = True
        Me.Owner.VisibleIndex = 14
        Me.Owner.Width = 63
        '
        'Tipe_trans
        '
        Me.Tipe_trans.FieldName = "Tipe_trans"
        Me.Tipe_trans.Name = "Tipe_trans"
        '
        'repTipeTrans
        '
        Me.repTipeTrans.AutoHeight = False
        Me.repTipeTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTipeTrans.DisplayMember = "tipe_desc"
        Me.repTipeTrans.Name = "repTipeTrans"
        Me.repTipeTrans.NullText = ""
        Me.repTipeTrans.ValueMember = "tipe_trans"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.cmdBarang)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.filter)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1001, 82)
        Me.Panel2.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblFound)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(864, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(137, 82)
        Me.Panel6.TabIndex = 35
        '
        'lblFound
        '
        Me.lblFound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFound.ForeColor = System.Drawing.Color.White
        Me.lblFound.Location = New System.Drawing.Point(0, 61)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(137, 21)
        Me.lblFound.TabIndex = 17
        Me.lblFound.Text = "SP Count(s) : 0"
        Me.lblFound.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.rdFilter)
        Me.Panel5.Location = New System.Drawing.Point(512, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 33)
        Me.Panel5.TabIndex = 23
        '
        'rdFilter
        '
        Me.rdFilter.EditValue = "( status='OK' and isnull(isclosed,'') = 'Y' ), ( status='OK' and isnull(isclosed," & _
            "'') = '' )"
        Me.rdFilter.Location = New System.Drawing.Point(11, 3)
        Me.rdFilter.Name = "rdFilter"
        Me.rdFilter.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rdFilter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFilter.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.rdFilter.Properties.Appearance.Options.UseBackColor = True
        Me.rdFilter.Properties.Appearance.Options.UseFont = True
        Me.rdFilter.Properties.Appearance.Options.UseForeColor = True
        Me.rdFilter.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.rdFilter.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.rdFilter.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.rdFilter.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.rdFilter.Properties.AutoHeight = False
        Me.rdFilter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdFilter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rdFilter.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rdFilter.Properties.DisplayMember = "a"
        Me.rdFilter.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("( status='OK' and isnull(isclosed,'') = 'Y' )", "LUNAS / TUTUP", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("( status='OK' and isnull(isclosed,'') = '' )", "OPEN / OUTSTANDING", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(" ( status<>'OK' )", "BATAL / REJECT")})
        Me.rdFilter.Properties.ValueMember = "b"
        Me.rdFilter.Size = New System.Drawing.Size(320, 27)
        Me.rdFilter.TabIndex = 22
        '
        'cmdBarang
        '
        Me.cmdBarang.Location = New System.Drawing.Point(632, 42)
        Me.cmdBarang.Name = "cmdBarang"
        Me.cmdBarang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBarang.Properties.Appearance.Options.UseFont = True
        Me.cmdBarang.Properties.Appearance.Options.UseTextOptions = True
        Me.cmdBarang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmdBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdBarang.Properties.DisplayMember = "Nama_Barang"
        Me.cmdBarang.Properties.NullText = ""
        Me.cmdBarang.Properties.PopupFormMinSize = New System.Drawing.Size(400, 0)
        Me.cmdBarang.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.cmdBarang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdBarang.Properties.ValueMember = "Kode_Barang"
        Me.cmdBarang.Properties.View = Me.GridLookUpEdit1View
        Me.cmdBarang.Size = New System.Drawing.Size(209, 20)
        Me.cmdBarang.TabIndex = 31
        Me.cmdBarang.Visible = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Kode_Satuan, Me.GridColumn3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 1
        Me.Nama_Barang.Width = 470
        '
        'Kode_Satuan
        '
        Me.Kode_Satuan.Caption = "Kode Satuan"
        Me.Kode_Satuan.FieldName = "Kd_Satuan"
        Me.Kode_Satuan.Name = "Kode_Satuan"
        Me.Kode_Satuan.Visible = True
        Me.Kode_Satuan.VisibleIndex = 2
        Me.Kode_Satuan.Width = 170
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Kode"
        Me.GridColumn3.FieldName = "Kode_Barang"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 152
        '
        'cmdClear
        '
        Me.cmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(571, 37)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(55, 42)
        Me.cmdClear.TabIndex = 20
        Me.cmdClear.ToolTip = "Bersihkan Kolom"
        '
        'filter
        '
        Me.filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.filter.Image = CType(resources.GetObject("filter.Image"), System.Drawing.Image)
        Me.filter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.filter.Location = New System.Drawing.Point(512, 37)
        Me.filter.LookAndFeel.SkinName = "The Asphalt World"
        Me.filter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(55, 42)
        Me.filter.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cmdTipe)
        Me.Panel4.Controls.Add(Me.cmdMerk)
        Me.Panel4.Controls.Add(Me.cmdJenis)
        Me.Panel4.Controls.Add(Me.cmbDivisi)
        Me.Panel4.Controls.Add(Me.tglSampai)
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.txtCustomer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(160, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(346, 82)
        Me.Panel4.TabIndex = 1
        '
        'cmdTipe
        '
        Me.cmdTipe.Location = New System.Drawing.Point(234, 40)
        Me.cmdTipe.Name = "cmdTipe"
        Me.cmdTipe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.Appearance.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdTipe.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdTipe.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdTipe.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTipe.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdTipe.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", 150, "Nama")})
        Me.cmdTipe.Properties.DisplayMember = "Nama_Tipe"
        Me.cmdTipe.Properties.HideSelection = False
        Me.cmdTipe.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdTipe.Properties.NullText = ""
        Me.cmdTipe.Properties.PopupWidth = 300
        Me.cmdTipe.Properties.ShowHeader = False
        Me.cmdTipe.Properties.ValueMember = "Kode_Tipe"
        Me.cmdTipe.Size = New System.Drawing.Size(111, 20)
        Me.cmdTipe.TabIndex = 35
        '
        'cmdMerk
        '
        Me.cmdMerk.Location = New System.Drawing.Point(122, 40)
        Me.cmdMerk.Name = "cmdMerk"
        Me.cmdMerk.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.Appearance.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdMerk.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdMerk.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdMerk.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMerk.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdMerk.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", 150, "Nama")})
        Me.cmdMerk.Properties.DisplayMember = "Nama_Merk"
        Me.cmdMerk.Properties.HideSelection = False
        Me.cmdMerk.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdMerk.Properties.NullText = ""
        Me.cmdMerk.Properties.PopupWidth = 300
        Me.cmdMerk.Properties.ShowHeader = False
        Me.cmdMerk.Properties.ValueMember = "Kode_Merk"
        Me.cmdMerk.Size = New System.Drawing.Size(111, 20)
        Me.cmdMerk.TabIndex = 34
        '
        'cmdJenis
        '
        Me.cmdJenis.Location = New System.Drawing.Point(0, 40)
        Me.cmdJenis.Name = "cmdJenis"
        Me.cmdJenis.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.Appearance.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmdJenis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmdJenis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdJenis.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJenis.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdJenis.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", 150, "Nama")})
        Me.cmdJenis.Properties.DisplayMember = "Nama_Jenis"
        Me.cmdJenis.Properties.HideSelection = False
        Me.cmdJenis.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdJenis.Properties.NullText = ""
        Me.cmdJenis.Properties.PopupWidth = 300
        Me.cmdJenis.Properties.ShowHeader = False
        Me.cmdJenis.Properties.ValueMember = "Kd_Jns_Brg"
        Me.cmdJenis.Size = New System.Drawing.Size(120, 20)
        Me.cmdJenis.TabIndex = 33
        '
        'cmbDivisi
        '
        Me.cmbDivisi.Location = New System.Drawing.Point(0, 61)
        Me.cmbDivisi.Name = "cmbDivisi"
        Me.cmbDivisi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.Appearance.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmbDivisi.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivisi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmbDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Divisi", 150, "Nama")})
        Me.cmbDivisi.Properties.DisplayMember = "Nama_Divisi"
        Me.cmbDivisi.Properties.HideSelection = False
        Me.cmbDivisi.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbDivisi.Properties.NullText = ""
        Me.cmbDivisi.Properties.PopupWidth = 300
        Me.cmbDivisi.Properties.ShowHeader = False
        Me.cmbDivisi.Properties.ValueMember = "Kode_Divisi"
        Me.cmbDivisi.Size = New System.Drawing.Size(346, 20)
        Me.cmbDivisi.TabIndex = 32
        '
        'tglSampai
        '
        Me.tglSampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tglSampai.EditValue = Nothing
        Me.tglSampai.Location = New System.Drawing.Point(176, 20)
        Me.tglSampai.Name = "tglSampai"
        Me.tglSampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampai.Properties.Appearance.Options.UseFont = True
        Me.tglSampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglSampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglSampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglSampai.Size = New System.Drawing.Size(170, 20)
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
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(176, 20)
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
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 150, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 200, "Alamat")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.DropDownRows = 15
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(346, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 82)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filter Divisi :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Filter Jenis/Merk/Tipe :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
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
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Filter Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.btnBuku)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 37)
        Me.Panel1.TabIndex = 0
        '
        'btnBuku
        '
        Me.btnBuku.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Appearance.Options.UseFont = True
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuku.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuku.Image = CType(resources.GetObject("btnBuku.Image"), System.Drawing.Image)
        Me.btnBuku.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuku.Location = New System.Drawing.Point(963, 0)
        Me.btnBuku.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnBuku.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(38, 37)
        Me.btnBuku.TabIndex = 10
        Me.btnBuku.Tag = "Tutup"
        Me.btnBuku.ToolTip = "Klik untuk melihat buku order spring"
        Me.btnBuku.ToolTipTitle = "Buku Order"
        Me.btnBuku.Visible = False
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
        Me.lblJudul.Text = "MONITORING DAFTAR SALES ORDER"
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
        Me.XtraGridBlending1.AlphaStyles.AddReplace("OddRow", 232)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("Preview", 255)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("EvenRow", 255)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("Row", 255)
        Me.XtraGridBlending1.GridControl = Me.GC
        '
        'frmBukuOrderCenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 418)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBukuOrderCenti"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBukuOrder"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTipeTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.rdFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmdTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSpon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_customer_spring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtySpring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents janji_kirim_spring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnBuku As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents filter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdBarang As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Realisasi_Kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repTipeTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbDivisi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdFilter As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents isClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMem As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Owner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdMerk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFound As System.Windows.Forms.Label
    Friend WithEvents Tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desc_promo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_NoTelp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
