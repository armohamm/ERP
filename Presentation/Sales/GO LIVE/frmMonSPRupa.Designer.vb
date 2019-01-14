<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonSPRupa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonSPRupa))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sub_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Merk_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Warna = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Sales = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Area = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Wilayah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tahun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Thnbln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.cmdGroup = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.DPP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PPN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1028, 480)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.BackgroundImage = CType(resources.GetObject("GC.BackgroundImage"), System.Drawing.Image)
        Me.GC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 79)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(1028, 401)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Nama_Jenis, Me.Nama_Merk, Me.Nama_Tipe, Me.Nama_Sub_Tipe, Me.Nama_Ukuran, Me.Merk_Kain, Me.Warna, Me.Total, Me.Nama_Sales, Me.Nama_Area, Me.Nama_Wilayah, Me.Tahun, Me.Thnbln, Me.Tgl_sp, Me.Nama_Customer, Me.Qty, Me.DPP, Me.PPN})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.Total, "{0:#,##0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, "{0:#,##0}")})
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowHorzLines = False
        Me.GV.OptionsView.ShowVertLines = False
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 1
        Me.Nama_Barang.Width = 208
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.Caption = "Jenis Barang"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 2
        Me.Nama_Jenis.Width = 106
        '
        'Nama_Merk
        '
        Me.Nama_Merk.Caption = "Merk"
        Me.Nama_Merk.FieldName = "Nama_Merk"
        Me.Nama_Merk.Name = "Nama_Merk"
        Me.Nama_Merk.Visible = True
        Me.Nama_Merk.VisibleIndex = 3
        Me.Nama_Merk.Width = 110
        '
        'Nama_Tipe
        '
        Me.Nama_Tipe.Caption = "Tipe"
        Me.Nama_Tipe.FieldName = "Nama_Tipe"
        Me.Nama_Tipe.Name = "Nama_Tipe"
        Me.Nama_Tipe.Visible = True
        Me.Nama_Tipe.VisibleIndex = 4
        Me.Nama_Tipe.Width = 111
        '
        'Nama_Sub_Tipe
        '
        Me.Nama_Sub_Tipe.Caption = "Subtipe"
        Me.Nama_Sub_Tipe.FieldName = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.Name = "Nama_Sub_Tipe"
        Me.Nama_Sub_Tipe.Visible = True
        Me.Nama_Sub_Tipe.VisibleIndex = 5
        Me.Nama_Sub_Tipe.Width = 100
        '
        'Nama_Ukuran
        '
        Me.Nama_Ukuran.Caption = "Ukuran"
        Me.Nama_Ukuran.FieldName = "Nama_Ukuran"
        Me.Nama_Ukuran.Name = "Nama_Ukuran"
        Me.Nama_Ukuran.Visible = True
        Me.Nama_Ukuran.VisibleIndex = 6
        Me.Nama_Ukuran.Width = 114
        '
        'Merk_Kain
        '
        Me.Merk_Kain.Caption = "Kain"
        Me.Merk_Kain.FieldName = "Merk_Kain"
        Me.Merk_Kain.Name = "Merk_Kain"
        Me.Merk_Kain.Visible = True
        Me.Merk_Kain.VisibleIndex = 7
        Me.Merk_Kain.Width = 104
        '
        'Warna
        '
        Me.Warna.Caption = "Warna"
        Me.Warna.FieldName = "Warna"
        Me.Warna.Name = "Warna"
        Me.Warna.Visible = True
        Me.Warna.VisibleIndex = 8
        Me.Warna.Width = 90
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "n2"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "Total"
        Me.Total.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Total.Name = "Total"
        Me.Total.SummaryItem.DisplayFormat = "{0:#,##0.00}"
        Me.Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 18
        Me.Total.Width = 115
        '
        'Nama_Sales
        '
        Me.Nama_Sales.Caption = "Sales"
        Me.Nama_Sales.FieldName = "Nama_Sales"
        Me.Nama_Sales.Name = "Nama_Sales"
        Me.Nama_Sales.Visible = True
        Me.Nama_Sales.VisibleIndex = 9
        Me.Nama_Sales.Width = 99
        '
        'Nama_Area
        '
        Me.Nama_Area.Caption = "Area"
        Me.Nama_Area.FieldName = "Nama_Area"
        Me.Nama_Area.Name = "Nama_Area"
        Me.Nama_Area.Visible = True
        Me.Nama_Area.VisibleIndex = 10
        Me.Nama_Area.Width = 96
        '
        'Nama_Wilayah
        '
        Me.Nama_Wilayah.Caption = "Wilayah"
        Me.Nama_Wilayah.FieldName = "Nama_Wilayah"
        Me.Nama_Wilayah.Name = "Nama_Wilayah"
        Me.Nama_Wilayah.Visible = True
        Me.Nama_Wilayah.VisibleIndex = 11
        '
        'Tahun
        '
        Me.Tahun.Caption = "Tahun"
        Me.Tahun.FieldName = "Thn"
        Me.Tahun.Name = "Tahun"
        Me.Tahun.Visible = True
        Me.Tahun.VisibleIndex = 12
        '
        'Thnbln
        '
        Me.Thnbln.Caption = "Bulan"
        Me.Thnbln.FieldName = "Thnbln"
        Me.Thnbln.Name = "Thnbln"
        Me.Thnbln.Visible = True
        Me.Thnbln.VisibleIndex = 13
        '
        'Tgl_sp
        '
        Me.Tgl_sp.Caption = "Tanggal"
        Me.Tgl_sp.FieldName = "Tgl_sp"
        Me.Tgl_sp.Name = "Tgl_sp"
        Me.Tgl_sp.Visible = True
        Me.Tgl_sp.VisibleIndex = 14
        '
        'Nama_Customer
        '
        Me.Nama_Customer.Caption = "Customer"
        Me.Nama_Customer.FieldName = "Nama_Customer"
        Me.Nama_Customer.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.Visible = True
        Me.Nama_Customer.VisibleIndex = 0
        Me.Nama_Customer.Width = 184
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "n0"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.DisplayFormat = "{0:#,##0}"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 15
        Me.Qty.Width = 62
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 42)
        Me.Panel3.TabIndex = 5
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(589, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 34
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(539, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tglsampai)
        Me.Panel5.Controls.Add(Me.cmdGroup)
        Me.Panel5.Controls.Add(Me.tglDari)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(127, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(411, 42)
        Me.Panel5.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(160, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Sampai Tgl : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(257, 21)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(154, 20)
        Me.tglsampai.TabIndex = 25
        '
        'cmdGroup
        '
        Me.cmdGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdGroup.EditValue = ""
        Me.cmdGroup.Location = New System.Drawing.Point(0, 0)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGroup.Properties.Appearance.Options.UseFont = True
        Me.cmdGroup.Properties.Appearance.Options.UseTextOptions = True
        Me.cmdGroup.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmdGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdGroup.Properties.DropDownRows = 14
        Me.cmdGroup.Properties.HideSelection = False
        Me.cmdGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Customer", "Customer"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Barang", "Nama Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Merk_Kain", "Merk Kain"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Warna", "Warna"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Merk", "Merk"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Ukuran", "Ukuran"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Tipe", "Tipe"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Sub_Tipe", "Subtipe"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Jenis", "Jenis"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Sales", "Sales"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Area", "Area"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Nama_Wilayah", "Wilayah"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Tgl_sp", "Hari"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thnbln", "Bulan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thn", "Tahun")})
        Me.cmdGroup.Properties.Mask.EditMask = "d"
        Me.cmdGroup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.cmdGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmdGroup.Size = New System.Drawing.Size(411, 20)
        Me.cmdGroup.TabIndex = 28
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(0, 21)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(154, 20)
        Me.tglDari.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(127, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(0, 42)
        Me.Panel4.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Kolom : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(127, 42)
        Me.Panel6.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Pilih Kolom : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel2.Size = New System.Drawing.Size(1028, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(413, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM MONITORING OMZET GLOBAL"
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
        'XtraGridBlending1
        '
        Me.XtraGridBlending1.AlphaStyles.AddReplace("OddRow", 159)
        Me.XtraGridBlending1.AlphaStyles.AddReplace("EvenRow", 177)
        Me.XtraGridBlending1.GridControl = Me.GC
        '
        'ChartControl1
        '
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.Size = New System.Drawing.Size(300, 200)
        Me.ChartControl1.TabIndex = 0
        '
        'DPP
        '
        Me.DPP.Caption = "DPP"
        Me.DPP.DisplayFormat.FormatString = "n2"
        Me.DPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DPP.FieldName = "DPP"
        Me.DPP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.DPP.Name = "DPP"
        Me.DPP.Visible = True
        Me.DPP.VisibleIndex = 16
        Me.DPP.Width = 95
        '
        'PPN
        '
        Me.PPN.Caption = "PPN"
        Me.PPN.DisplayFormat.FormatString = "n2"
        Me.PPN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PPN.FieldName = "jml_rp_ppn"
        Me.PPN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.PPN.Name = "PPN"
        Me.PPN.Visible = True
        Me.PPN.VisibleIndex = 17
        Me.PPN.Width = 97
        '
        'frmMonSPRupa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 480)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmMonSPRupa"
        Me.Text = "frmMonSP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sub_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Nama_Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Merk_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Sales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Wilayah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Warna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdGroup As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Tahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Thnbln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Tgl_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PPN As DevExpress.XtraGrid.Columns.GridColumn
End Class
