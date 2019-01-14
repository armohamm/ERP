<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApprovePO1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApprovePO1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcApprvPO = New DevExpress.XtraGrid.GridControl
        Me.GvApprvPO = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LOVstatus = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GcApprvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvApprvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcApprvPO)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(979, 443)
        Me.pnl.TabIndex = 1
        '
        'GcApprvPO
        '
        Me.GcApprvPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvPO.Location = New System.Drawing.Point(0, 72)
        Me.GcApprvPO.MainView = Me.GvApprvPO
        Me.GcApprvPO.Name = "GcApprvPO"
        Me.GcApprvPO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RBrecstat, Me.lookupSupplier})
        Me.GcApprvPO.Size = New System.Drawing.Size(979, 295)
        Me.GcApprvPO.TabIndex = 145
        Me.GcApprvPO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvApprvPO})
        '
        'GvApprvPO
        '
        Me.GvApprvPO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvApprvPO.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.Empty.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvApprvPO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvApprvPO.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvApprvPO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvApprvPO.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvApprvPO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvApprvPO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvApprvPO.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvApprvPO.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvApprvPO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.GroupRow.Options.UseFont = True
        Me.GvApprvPO.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvApprvPO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvApprvPO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvApprvPO.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvApprvPO.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvApprvPO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvApprvPO.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvApprvPO.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.OddRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.OddRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvApprvPO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvApprvPO.Appearance.Preview.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.Preview.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvApprvPO.Appearance.Row.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.Row.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvApprvPO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvApprvPO.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvApprvPO.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvApprvPO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvApprvPO.Appearance.VertLine.Options.UseBackColor = True
        Me.GvApprvPO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_po, Me.tgl_po, Me.kd_supplier, Me.keterangan, Me.tgl_kirim, Me.status, Me.ket_approve, Me.status_po})
        Me.GvApprvPO.GridControl = Me.GcApprvPO
        Me.GvApprvPO.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GvApprvPO.Name = "GvApprvPO"
        Me.GvApprvPO.OptionsView.EnableAppearanceEvenRow = True
        Me.GvApprvPO.OptionsView.EnableAppearanceOddRow = True
        Me.GvApprvPO.OptionsView.RowAutoHeight = True
        Me.GvApprvPO.OptionsView.ShowFooter = True
        Me.GvApprvPO.OptionsView.ShowGroupPanel = False
        Me.GvApprvPO.PaintStyleName = "Skin"
        Me.GvApprvPO.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_po
        '
        Me.no_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_po.AppearanceHeader.Options.UseFont = True
        Me.no_po.AppearanceHeader.Options.UseTextOptions = True
        Me.no_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_po.Caption = "Nomor PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.OptionsColumn.AllowEdit = False
        Me.no_po.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 0
        Me.no_po.Width = 118
        '
        'tgl_po
        '
        Me.tgl_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_po.AppearanceHeader.Options.UseFont = True
        Me.tgl_po.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_po.Caption = "Tanggal PO"
        Me.tgl_po.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_po.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_po.FieldName = "tgl_po"
        Me.tgl_po.Name = "tgl_po"
        Me.tgl_po.OptionsColumn.AllowEdit = False
        Me.tgl_po.Visible = True
        Me.tgl_po.VisibleIndex = 1
        Me.tgl_po.Width = 76
        '
        'kd_supplier
        '
        Me.kd_supplier.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supplier.AppearanceHeader.Options.UseFont = True
        Me.kd_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supplier.Caption = "Supplier Terpilih"
        Me.kd_supplier.ColumnEdit = Me.lookupSupplier
        Me.kd_supplier.FieldName = "kd_supplier"
        Me.kd_supplier.Name = "kd_supplier"
        Me.kd_supplier.OptionsColumn.AllowEdit = False
        Me.kd_supplier.Visible = True
        Me.kd_supplier.VisibleIndex = 2
        Me.kd_supplier.Width = 210
        '
        'lookupSupplier
        '
        Me.lookupSupplier.AutoHeight = False
        Me.lookupSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupSupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama Supplier")})
        Me.lookupSupplier.Name = "lookupSupplier"
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 120
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl Janji Kirim"
        Me.tgl_kirim.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 98
        '
        'status
        '
        Me.status.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.status.AppearanceCell.Options.UseBackColor = True
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Approval"
        Me.status.ColumnEdit = Me.RBrecstat
        Me.status.FieldName = "rec_stat"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 5
        Me.status.Width = 137
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"", "APPROVE", "REJECT"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.ket_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ket_approve.Caption = "Alasan Reject"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.MinWidth = 100
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 6
        Me.ket_approve.Width = 100
        '
        'status_po
        '
        Me.status_po.Caption = "Status PO"
        Me.status_po.FieldName = "status_po"
        Me.status_po.Name = "status_po"
        Me.status_po.OptionsColumn.AllowEdit = False
        Me.status_po.Visible = True
        Me.status_po.VisibleIndex = 7
        Me.status_po.Width = 82
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 367)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(979, 37)
        Me.Panel4.TabIndex = 147
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.SimpleButton1)
        Me.Panel3.Controls.Add(Me.LOVstatus)
        Me.Panel3.Controls.Add(Me.cmdExe)
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(979, 35)
        Me.Panel3.TabIndex = 146
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(281, 2)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(50, 28)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "Semua"
        Me.SimpleButton1.ToolTip = "Eksekusi Pencarian"
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        '
        'LOVstatus
        '
        Me.LOVstatus.Location = New System.Drawing.Point(66, 5)
        Me.LOVstatus.Name = "LOVstatus"
        Me.LOVstatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVstatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rec_stat", "Status")})
        Me.LOVstatus.Properties.NullText = ""
        Me.LOVstatus.Size = New System.Drawing.Size(175, 20)
        Me.LOVstatus.TabIndex = 13
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(247, 2)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(28, 28)
        Me.cmdExe.TabIndex = 15
        Me.cmdExe.ToolTip = "Eksekusi Pencarian"
        Me.cmdExe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdExe.ToolTipTitle = "SEARCH"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Filter :"
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
        Me.Panel1.Size = New System.Drawing.Size(979, 37)
        Me.Panel1.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "APPROVAL PO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 39)
        Me.Panel2.TabIndex = 144
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(433, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(294, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "&Update"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "nama divisi")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'FrmApprovePO1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 443)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmApprovePO1"
        Me.Text = "FrmApprovePO1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GcApprvPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvApprvPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LOVstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcApprvPO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvApprvPO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LOVstatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents status_po As DevExpress.XtraGrid.Columns.GridColumn
End Class
