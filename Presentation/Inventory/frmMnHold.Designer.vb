<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMnHold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMnHold))
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GcMonQC = New DevExpress.XtraGrid.GridControl
        Me.GvMonQC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sj_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.spek_brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold_history = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_release = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_reject_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_act_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Last_Created_By
        '
        Me.Last_Created_By.Caption = "Petugas QC"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 4
        Me.Last_Created_By.Width = 32
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(561, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(512, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.Location = New System.Drawing.Point(610, 0)
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(75, 42)
        Me.btnprin.TabIndex = 38
        Me.btnprin.Text = "Cetak"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnprin)
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(992, 42)
        Me.Panel3.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(204, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 42)
        Me.Panel6.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "s/d"
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
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 42)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcMonQC
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(70, 50, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "MONITORING BARANG HOLD", ""}, New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'GcMonQC
        '
        Me.GcMonQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMonQC.Location = New System.Drawing.Point(0, 79)
        Me.GcMonQC.MainView = Me.GvMonQC
        Me.GcMonQC.Name = "GcMonQC"
        Me.GcMonQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang})
        Me.GcMonQC.Size = New System.Drawing.Size(992, 235)
        Me.GcMonQC.TabIndex = 7
        Me.GcMonQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMonQC})
        '
        'GvMonQC
        '
        Me.GvMonQC.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GvMonQC.Appearance.Empty.Options.UseBackColor = True
        Me.GvMonQC.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GvMonQC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GvMonQC.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GvMonQC.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GvMonQC.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMonQC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GvMonQC.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMonQC.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMonQC.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.OddRow.Options.UseBorderColor = True
        Me.GvMonQC.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GvMonQC.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMonQC.Appearance.Preview.Options.UseFont = True
        Me.GvMonQC.Appearance.Preview.Options.UseForeColor = True
        Me.GvMonQC.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMonQC.Appearance.Row.Options.UseBackColor = True
        Me.GvMonQC.Appearance.Row.Options.UseForeColor = True
        Me.GvMonQC.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMonQC.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GvMonQC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMonQC.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMonQC.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMonQC.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvMonQC.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvMonQC.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMonQC.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMonQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.tgl_trans, Me.no_trans, Me.Last_Created_By, Me.no_ref, Me.sj_supplier, Me.kd_stok, Me.kd_satuan, Me.spek_brg, Me.hold_history, Me.hold, Me.qty_release, Me.qty_reject_hold, Me.status_hold, Me.tgl_act_hold, Me.no_po, Me.qty_po, Me.qty_qc_pass})
        Me.GvMonQC.GridControl = Me.GcMonQC
        Me.GvMonQC.Name = "GvMonQC"
        Me.GvMonQC.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMonQC.OptionsView.EnableAppearanceOddRow = True
        Me.GvMonQC.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvMonQC.OptionsView.RowAutoHeight = True
        Me.GvMonQC.OptionsView.ShowFooter = True
        '
        'nomer
        '
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 20
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 32
        '
        'no_trans
        '
        Me.no_trans.Caption = "Nomor QC"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 3
        Me.no_trans.Width = 58
        '
        'no_ref
        '
        Me.no_ref.Caption = "Referensi"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 5
        Me.no_ref.Width = 44
        '
        'sj_supplier
        '
        Me.sj_supplier.Caption = "SJ Supplier"
        Me.sj_supplier.FieldName = "sj_supplier"
        Me.sj_supplier.Name = "sj_supplier"
        Me.sj_supplier.Visible = True
        Me.sj_supplier.VisibleIndex = 6
        Me.sj_supplier.Width = 51
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 7
        Me.kd_stok.Width = 178
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'kd_satuan
        '
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Visible = True
        Me.kd_satuan.VisibleIndex = 8
        Me.kd_satuan.Width = 44
        '
        'spek_brg
        '
        Me.spek_brg.Caption = "Spek"
        Me.spek_brg.FieldName = "spek_brg"
        Me.spek_brg.Name = "spek_brg"
        Me.spek_brg.Visible = True
        Me.spek_brg.VisibleIndex = 9
        Me.spek_brg.Width = 38
        '
        'hold_history
        '
        Me.hold_history.Caption = "Hold"
        Me.hold_history.FieldName = "hold_history"
        Me.hold_history.Name = "hold_history"
        Me.hold_history.Visible = True
        Me.hold_history.VisibleIndex = 12
        Me.hold_history.Width = 53
        '
        'hold
        '
        Me.hold.Caption = "Masih Hold"
        Me.hold.FieldName = "hold"
        Me.hold.Name = "hold"
        Me.hold.Visible = True
        Me.hold.VisibleIndex = 13
        Me.hold.Width = 41
        '
        'qty_release
        '
        Me.qty_release.Caption = "Qty Release"
        Me.qty_release.FieldName = "qty_release"
        Me.qty_release.Name = "qty_release"
        Me.qty_release.Visible = True
        Me.qty_release.VisibleIndex = 14
        Me.qty_release.Width = 51
        '
        'qty_reject_hold
        '
        Me.qty_reject_hold.Caption = "Tolak"
        Me.qty_reject_hold.FieldName = "qty_reject_hold"
        Me.qty_reject_hold.Name = "qty_reject_hold"
        Me.qty_reject_hold.Visible = True
        Me.qty_reject_hold.VisibleIndex = 15
        Me.qty_reject_hold.Width = 33
        '
        'status_hold
        '
        Me.status_hold.Caption = "Status Saat ini"
        Me.status_hold.FieldName = "status_hold"
        Me.status_hold.Name = "status_hold"
        Me.status_hold.Visible = True
        Me.status_hold.VisibleIndex = 16
        Me.status_hold.Width = 55
        '
        'tgl_act_hold
        '
        Me.tgl_act_hold.Caption = "Tgl Tindakan"
        Me.tgl_act_hold.FieldName = "tgl_act_hold"
        Me.tgl_act_hold.Name = "tgl_act_hold"
        Me.tgl_act_hold.Visible = True
        Me.tgl_act_hold.VisibleIndex = 17
        Me.tgl_act_hold.Width = 81
        '
        'no_po
        '
        Me.no_po.Caption = "Nomor PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 2
        Me.no_po.Width = 59
        '
        'qty_po
        '
        Me.qty_po.Caption = "Qty PO"
        Me.qty_po.FieldName = "qty_po"
        Me.qty_po.Name = "qty_po"
        Me.qty_po.Visible = True
        Me.qty_po.VisibleIndex = 10
        Me.qty_po.Width = 43
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(365, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING BARANG MASUK HOLD"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 37)
        Me.Panel2.TabIndex = 4
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMonQC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(992, 314)
        Me.pnl.TabIndex = 4
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.Caption = "Qty Good"
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.Visible = True
        Me.qty_qc_pass.VisibleIndex = 11
        Me.qty_qc_pass.Width = 58
        '
        'frmMnHold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 314)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMnHold"
        Me.Text = "frmMnHold"
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMonQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcMonQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMonQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spek_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents qty_reject_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_act_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_release As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hold_history As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sj_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
End Class
