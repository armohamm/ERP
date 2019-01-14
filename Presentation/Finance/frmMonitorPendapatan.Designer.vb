<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitorPendapatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitorPendapatan))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Valuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.GCMonPendapatan = New DevExpress.XtraGrid.GridControl
        Me.GVMonPendapatan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.level2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.total_rp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GVMonDet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kdBKpusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nmKDpusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GCMonPendapatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMonPendapatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMonDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(770, 6)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 38)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.ToolTip = "Eksekusi Pencarian"
        Me.SimpleButton1.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefaultToolTipController1.DefaultController.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseBackColor = True
        Me.DefaultToolTipController1.DefaultController.Appearance.Options.UseFont = True
        Me.DefaultToolTipController1.DefaultController.Rounded = True
        Me.DefaultToolTipController1.DefaultController.ShowBeak = True
        Me.DefaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 49)
        Me.Panel2.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(902, 6)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.ToolTip = "Print Data"
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdPrint.ToolTipTitle = "PRINT"
        Me.cmdPrint.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(814, 6)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.ToolTip = "Bersihkan Pencarian"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdClear.ToolTipTitle = "CLEAR"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(858, 6)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.ToolTip = "Reset Data"
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        Me.cmdRefresh.Visible = False
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.LabelControl5)
        Me.Panel4.Controls.Add(Me.LabelControl6)
        Me.Panel4.Controls.Add(Me.tglsampai)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(498, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(266, 49)
        Me.Panel4.TabIndex = 2
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(81, 3)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseBackColor = True
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(162, 20)
        Me.tglDari.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(6, 2)
        Me.LabelControl5.LookAndFeel.SkinName = "Black"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl5.TabIndex = 23
        Me.LabelControl5.Text = "Dari : "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(6, 24)
        Me.LabelControl6.LookAndFeel.SkinName = "Black"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 22)
        Me.LabelControl6.TabIndex = 26
        Me.LabelControl6.Text = "Sampai : "
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(81, 26)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseBackColor = True
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(162, 20)
        Me.tglsampai.TabIndex = 1
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(367, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 49)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Label1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.Valuta)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 49)
        Me.Panel6.TabIndex = 5
        '
        'Valuta
        '
        Me.Valuta.Location = New System.Drawing.Point(6, 15)
        Me.Valuta.Name = "Valuta"
        Me.Valuta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Valuta.Properties.Appearance.Options.UseBackColor = True
        Me.Valuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Valuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_valuta", "nama_valuta")})
        Me.Valuta.Properties.NullText = ""
        Me.Valuta.Size = New System.Drawing.Size(202, 20)
        Me.Valuta.TabIndex = 0
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 49)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 49)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Valuta : "
        '
        'PictureBox1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PictureBox1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.GCMonPendapatan)
        Me.pnl.Controls.Add(Me.Panel11)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1075, 414)
        Me.pnl.TabIndex = 3
        '
        'GCMonPendapatan
        '
        Me.GCMonPendapatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCMonPendapatan.Location = New System.Drawing.Point(0, 86)
        Me.GCMonPendapatan.LookAndFeel.SkinName = "The Asphalt World"
        Me.GCMonPendapatan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCMonPendapatan.MainView = Me.GVMonPendapatan
        Me.GCMonPendapatan.Name = "GCMonPendapatan"
        Me.GCMonPendapatan.Size = New System.Drawing.Size(1075, 292)
        Me.GCMonPendapatan.TabIndex = 8
        Me.GCMonPendapatan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMonPendapatan, Me.GVMonDet})
        '
        'GVMonPendapatan
        '
        Me.GVMonPendapatan.ActiveFilterEnabled = False
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.Empty.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVMonPendapatan.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVMonPendapatan.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVMonPendapatan.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.OddRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVMonPendapatan.Appearance.OddRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVMonPendapatan.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVMonPendapatan.Appearance.Preview.Options.UseFont = True
        Me.GVMonPendapatan.Appearance.Preview.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVMonPendapatan.Appearance.Row.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.Row.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVMonPendapatan.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVMonPendapatan.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVMonPendapatan.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVMonPendapatan.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVMonPendapatan.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVMonPendapatan.Appearance.VertLine.Options.UseBackColor = True
        Me.GVMonPendapatan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.level2, Me.nm_buku_besar, Me.no_ref3, Me.no_ref1, Me.no_ref2, Me.nama_barang, Me.nama_merk, Me.nama_tipe, Me.Nama, Me.jumlah, Me.bulan, Me.qty_total, Me.total_rp})
        Me.GVMonPendapatan.GridControl = Me.GCMonPendapatan
        Me.GVMonPendapatan.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data"
        Me.GVMonPendapatan.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "jumlah", Me.jumlah, "")})
        Me.GVMonPendapatan.Name = "GVMonPendapatan"
        Me.GVMonPendapatan.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GVMonPendapatan.OptionsBehavior.Editable = False
        Me.GVMonPendapatan.OptionsBehavior.ReadOnly = True
        Me.GVMonPendapatan.OptionsView.ColumnAutoWidth = False
        Me.GVMonPendapatan.OptionsView.EnableAppearanceEvenRow = True
        Me.GVMonPendapatan.OptionsView.EnableAppearanceOddRow = True
        Me.GVMonPendapatan.OptionsView.ShowFooter = True
        Me.GVMonPendapatan.OptionsView.ShowViewCaption = True
        Me.GVMonPendapatan.ViewCaption = "INCOME"
        '
        'level2
        '
        Me.level2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level2.AppearanceHeader.Options.UseFont = True
        Me.level2.AppearanceHeader.Options.UseTextOptions = True
        Me.level2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.level2.Caption = "Divisi"
        Me.level2.FieldName = "level2"
        Me.level2.Name = "level2"
        Me.level2.Visible = True
        Me.level2.VisibleIndex = 0
        Me.level2.Width = 39
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_buku_besar.AppearanceCell.Options.UseFont = True
        Me.nm_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.nm_buku_besar.Caption = "Penjualan"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.VisibleIndex = 1
        Me.nm_buku_besar.Width = 89
        '
        'no_ref3
        '
        Me.no_ref3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_ref3.AppearanceCell.Options.UseFont = True
<<<<<<< .mine
        Me.no_ref3.Caption = "No. Invoice"
=======
        Me.no_ref3.Caption = "No. Invoice / no_ref3"
>>>>>>> .r3346
        Me.no_ref3.FieldName = "no_ref3"
        Me.no_ref3.Name = "no_ref3"
        Me.no_ref3.Visible = True
        Me.no_ref3.VisibleIndex = 2
        Me.no_ref3.Width = 97
        '
        'no_ref1
        '
        Me.no_ref1.Caption = "No. Surat jalan"
        Me.no_ref1.FieldName = "no_ref1"
        Me.no_ref1.Name = "no_ref1"
        Me.no_ref1.Visible = True
        Me.no_ref1.VisibleIndex = 3
        Me.no_ref1.Width = 86
        '
        'no_ref2
        '
        Me.no_ref2.Caption = "No. SP"
        Me.no_ref2.FieldName = "no_ref2"
        Me.no_ref2.Name = "no_ref2"
        Me.no_ref2.Visible = True
        Me.no_ref2.VisibleIndex = 4
        Me.no_ref2.Width = 91
        '
        'nama_barang
        '
        Me.nama_barang.Caption = "Nama Barang"
        Me.nama_barang.FieldName = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Visible = True
        Me.nama_barang.VisibleIndex = 5
        Me.nama_barang.Width = 97
        '
        'nama_merk
        '
        Me.nama_merk.Caption = "Merk"
        Me.nama_merk.FieldName = "nama_merk"
        Me.nama_merk.Name = "nama_merk"
        Me.nama_merk.Visible = True
        Me.nama_merk.VisibleIndex = 6
        Me.nama_merk.Width = 78
        '
        'nama_tipe
        '
        Me.nama_tipe.Caption = "Tipe"
        Me.nama_tipe.FieldName = "nama_tipe"
        Me.nama_tipe.Name = "nama_tipe"
        Me.nama_tipe.Visible = True
        Me.nama_tipe.VisibleIndex = 7
        Me.nama_tipe.Width = 73
        '
        'Nama
        '
        Me.Nama.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.AppearanceHeader.Options.UseFont = True
        Me.Nama.Caption = "Customer"
        Me.Nama.FieldName = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 8
        Me.Nama.Width = 79
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.AppearanceHeader.Options.UseFont = True
        Me.jumlah.Caption = "Jumlah"
        Me.jumlah.DisplayFormat.FormatString = "n2"
        Me.jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 9
        Me.jumlah.Width = 85
        '
        'bulan
        '
        Me.bulan.Caption = "Bulan"
        Me.bulan.FieldName = "bulan"
        Me.bulan.Name = "bulan"
        Me.bulan.Width = 50
        '
        'qty_total
        '
        Me.qty_total.Caption = "Total QTY"
        Me.qty_total.FieldName = "qty_total"
        Me.qty_total.Name = "qty_total"
        Me.qty_total.Width = 45
        '
        'total_rp
        '
        Me.total_rp.Caption = "Total Rp"
        Me.total_rp.FieldName = "total_rp"
        Me.total_rp.Name = "total_rp"
        Me.total_rp.Width = 61
        '
        'GVMonDet
        '
        Me.GVMonDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kdBKpusat, Me.nmKDpusat, Me.Debet, Me.Kredit})
        Me.GVMonDet.GridControl = Me.GCMonPendapatan
        Me.GVMonDet.Name = "GVMonDet"
        '
        'kdBKpusat
        '
        Me.kdBKpusat.Caption = "Kode Buku Besar"
        Me.kdBKpusat.Name = "kdBKpusat"
        Me.kdBKpusat.Visible = True
        Me.kdBKpusat.VisibleIndex = 0
        '
        'nmKDpusat
        '
        Me.nmKDpusat.Caption = "Nama Buku Pusat"
        Me.nmKDpusat.Name = "nmKDpusat"
        Me.nmKDpusat.Visible = True
        Me.nmKDpusat.VisibleIndex = 1
        '
        'Debet
        '
        Me.Debet.Caption = "Debet"
        Me.Debet.Name = "Debet"
        Me.Debet.Visible = True
        Me.Debet.VisibleIndex = 2
        '
        'Kredit
        '
        Me.Kredit.Caption = "Kredit"
        Me.Kredit.Name = "Kredit"
        Me.Kredit.Visible = True
        Me.Kredit.VisibleIndex = 3
        '
        'Panel11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel11, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 378)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1075, 36)
        Me.Panel11.TabIndex = 2
        '
        'Panel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 37)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "MONITORING PENDAPATAN"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonitorPendapatan
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 414)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonitorPendapatan"
        Me.Text = "frmMonitorPendapatan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GCMonPendapatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMonPendapatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMonDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GVMonDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kdBKpusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nmKDpusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCMonPendapatan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMonPendapatan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents level2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents total_rp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Valuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
End Class
