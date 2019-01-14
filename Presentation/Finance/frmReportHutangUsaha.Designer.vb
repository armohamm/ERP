<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportHutangUsaha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportHutangUsaha))
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.PanelFootPage = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.PanelFootNav = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.CEDetailHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CERekapHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CEAgingHutangJthTempo = New DevExpress.XtraEditors.CheckEdit
        Me.CEAgingHutangNota = New DevExpress.XtraEditors.CheckEdit
        Me.CEAgingHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CEKartuHutang = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Supplier = New DevExpress.XtraEditors.LookUpEdit
        Me.Valuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelFootPage.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelFootNav.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CEDetailHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CERekapHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEAgingHutangJthTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEAgingHutangNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEAgingHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEKartuHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(99, 3)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(38, 38)
        Me.cmdExe.TabIndex = 10
        Me.cmdExe.ToolTip = "Eksekusi Pencarian"
        Me.cmdExe.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdExe.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdExe.ToolTipTitle = "OK"
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
        'PanelFootPage
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PanelFootPage, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PanelFootPage.BackColor = System.Drawing.Color.Maroon
        Me.PanelFootPage.Controls.Add(Me.lblError)
        Me.PanelFootPage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFootPage.Location = New System.Drawing.Point(0, 222)
        Me.PanelFootPage.Name = "PanelFootPage"
        Me.PanelFootPage.Size = New System.Drawing.Size(329, 27)
        Me.PanelFootPage.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 8)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "..."
        '
        'Panel8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel8, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.PanelFootNav)
        Me.Panel8.Controls.Add(Me.SplitContainerControl1)
        Me.Panel8.Controls.Add(Me.PanelFootPage)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 103)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(329, 249)
        Me.Panel8.TabIndex = 7
        '
        'PanelFootNav
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PanelFootNav, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PanelFootNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelFootNav.Controls.Add(Me.cmdClear)
        Me.PanelFootNav.Controls.Add(Me.cmdPrint)
        Me.PanelFootNav.Controls.Add(Me.cmdExe)
        Me.PanelFootNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFootNav.Location = New System.Drawing.Point(0, 179)
        Me.PanelFootNav.Name = "PanelFootNav"
        Me.PanelFootNav.Size = New System.Drawing.Size(329, 43)
        Me.PanelFootNav.TabIndex = 13
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(143, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.ToolTip = "Bersihkan Isian Pada Control"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning
        Me.cmdClear.ToolTipTitle = "Clear"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(187, 2)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.ToolTip = "Cetak Laporan Ke Printer"
        Me.cmdPrint.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application
        Me.cmdPrint.ToolTipTitle = "Print"
        '
        'SplitContainerControl1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.SplitContainerControl1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CEDetailHutang)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CERekapHutang)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEAgingHutangJthTempo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEAgingHutangNota)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEAgingHutang)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEKartuHutang)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(329, 222)
        Me.SplitContainerControl1.SplitterPosition = 59
        Me.SplitContainerControl1.TabIndex = 12
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CEDetailHutang
        '
        Me.CEDetailHutang.Location = New System.Drawing.Point(102, 31)
        Me.CEDetailHutang.Name = "CEDetailHutang"
        Me.CEDetailHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEDetailHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEDetailHutang.Properties.Appearance.Options.UseFont = True
        Me.CEDetailHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEDetailHutang.Properties.Caption = "Detail Hutang"
        Me.CEDetailHutang.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEDetailHutang.Size = New System.Drawing.Size(175, 21)
        Me.CEDetailHutang.TabIndex = 25
        '
        'CERekapHutang
        '
        Me.CERekapHutang.EditValue = True
        Me.CERekapHutang.Location = New System.Drawing.Point(102, 5)
        Me.CERekapHutang.Name = "CERekapHutang"
        Me.CERekapHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CERekapHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CERekapHutang.Properties.Appearance.Options.UseFont = True
        Me.CERekapHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CERekapHutang.Properties.Caption = "Rekapitulasi"
        Me.CERekapHutang.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CERekapHutang.Size = New System.Drawing.Size(175, 21)
        Me.CERekapHutang.TabIndex = 24
        '
        'CEAgingHutangJthTempo
        '
        Me.CEAgingHutangJthTempo.Location = New System.Drawing.Point(175, 71)
        Me.CEAgingHutangJthTempo.Name = "CEAgingHutangJthTempo"
        Me.CEAgingHutangJthTempo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEAgingHutangJthTempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEAgingHutangJthTempo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEAgingHutangJthTempo.Properties.Appearance.Options.UseBackColor = True
        Me.CEAgingHutangJthTempo.Properties.Appearance.Options.UseFont = True
        Me.CEAgingHutangJthTempo.Properties.Appearance.Options.UseForeColor = True
        Me.CEAgingHutangJthTempo.Properties.Caption = "Tgl. Jatuh Tempo"
        Me.CEAgingHutangJthTempo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEAgingHutangJthTempo.Size = New System.Drawing.Size(137, 21)
        Me.CEAgingHutangJthTempo.TabIndex = 29
        '
        'CEAgingHutangNota
        '
        Me.CEAgingHutangNota.EditValue = True
        Me.CEAgingHutangNota.Location = New System.Drawing.Point(175, 44)
        Me.CEAgingHutangNota.Name = "CEAgingHutangNota"
        Me.CEAgingHutangNota.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEAgingHutangNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEAgingHutangNota.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEAgingHutangNota.Properties.Appearance.Options.UseBackColor = True
        Me.CEAgingHutangNota.Properties.Appearance.Options.UseFont = True
        Me.CEAgingHutangNota.Properties.Appearance.Options.UseForeColor = True
        Me.CEAgingHutangNota.Properties.Caption = "Tgl. Invoice"
        Me.CEAgingHutangNota.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEAgingHutangNota.Size = New System.Drawing.Size(116, 21)
        Me.CEAgingHutangNota.TabIndex = 28
        '
        'CEAgingHutang
        '
        Me.CEAgingHutang.Location = New System.Drawing.Point(102, 44)
        Me.CEAgingHutang.Name = "CEAgingHutang"
        Me.CEAgingHutang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEAgingHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEAgingHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEAgingHutang.Properties.Appearance.Options.UseBackColor = True
        Me.CEAgingHutang.Properties.Appearance.Options.UseFont = True
        Me.CEAgingHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEAgingHutang.Properties.Caption = "Aging"
        Me.CEAgingHutang.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEAgingHutang.Size = New System.Drawing.Size(74, 21)
        Me.CEAgingHutang.TabIndex = 27
        '
        'CEKartuHutang
        '
        Me.CEKartuHutang.EditValue = True
        Me.CEKartuHutang.Location = New System.Drawing.Point(102, 17)
        Me.CEKartuHutang.Name = "CEKartuHutang"
        Me.CEKartuHutang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEKartuHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEKartuHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEKartuHutang.Properties.Appearance.Options.UseBackColor = True
        Me.CEKartuHutang.Properties.Appearance.Options.UseFont = True
        Me.CEKartuHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEKartuHutang.Properties.Caption = "Kartu"
        Me.CEKartuHutang.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CEKartuHutang.Size = New System.Drawing.Size(74, 21)
        Me.CEKartuHutang.TabIndex = 26
        '
        'PanelControl1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PanelControl1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PanelControl1.Location = New System.Drawing.Point(99, 39)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(227, 69)
        Me.PanelControl1.TabIndex = 30
        '
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.Supplier)
        Me.Panel6.Controls.Add(Me.Valuta)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(104, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(187, 66)
        Me.Panel6.TabIndex = 5
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(0, 42)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = ""
        Me.lookupBulanAwal.Size = New System.Drawing.Size(175, 20)
        Me.lookupBulanAwal.TabIndex = 53
        '
        'Supplier
        '
        Me.Supplier.Location = New System.Drawing.Point(0, 0)
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Supplier.Properties.Appearance.Options.UseBackColor = True
        Me.Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Supplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama Supplier")})
        Me.Supplier.Properties.NullText = ""
        Me.Supplier.Size = New System.Drawing.Size(175, 20)
        Me.Supplier.TabIndex = 28
        '
        'Valuta
        '
        Me.Valuta.Location = New System.Drawing.Point(0, 21)
        Me.Valuta.Name = "Valuta"
        Me.Valuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Valuta.Properties.Appearance.Options.UseBackColor = True
        Me.Valuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Valuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama Valuta")})
        Me.Valuta.Properties.NullText = ""
        Me.Valuta.Size = New System.Drawing.Size(175, 20)
        Me.Valuta.TabIndex = 27
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(104, 66)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(1, 41)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 21)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Bulan / Tahun :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Valuta : "
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
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Supplier  : "
        '
        'lblJudul
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.lblJudul, DevExpress.Utils.DefaultBoolean.[Default])
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "LAPORAN HUTANG USAHA"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel2, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 66)
        Me.Panel2.TabIndex = 5
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
        Me.Panel1.Size = New System.Drawing.Size(329, 37)
        Me.Panel1.TabIndex = 4
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(329, 352)
        Me.pnl.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmReportHutangUsaha
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 401)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmReportHutangUsaha"
        Me.Text = "frmReportHutangUsaha"
        Me.PanelFootPage.ResumeLayout(False)
        Me.PanelFootPage.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.PanelFootNav.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CEDetailHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CERekapHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEAgingHutangJthTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEAgingHutangNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEAgingHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEKartuHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelFootPage As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Supplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Valuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CEDetailHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CERekapHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CEAgingHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEKartuHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelFootNav As System.Windows.Forms.Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CEAgingHutangJthTempo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEAgingHutangNota As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
