<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonNSperiod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonNSperiod))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.txtBulan = New DevExpress.XtraEditors.TextEdit
        Me.txtThn = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LookUpSaldo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.BandedGV = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.nm_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.saldo_awal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.debet = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.kredit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.saldo_akhir = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(596, 7)
        Me.SimpleButton1.LookAndFeel.SkinName = "The Asphalt World"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 38)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.ToolTip = "Eksekusi Pencarian"
        Me.SimpleButton1.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.SimpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.SimpleButton1.ToolTipTitle = "SEARCH"
        Me.SimpleButton1.Visible = False
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
        Me.Panel1.Size = New System.Drawing.Size(1053, 37)
        Me.Panel1.TabIndex = 4
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
        Me.lblJudul.Text = "MONITORING NERACA SALDO PERIODE"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.txtBulan)
        Me.Panel6.Controls.Add(Me.txtThn)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 51)
        Me.Panel6.TabIndex = 5
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(0, 3)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = "[Periode]"
        Me.lookupBulanAwal.Size = New System.Drawing.Size(202, 20)
        Me.lookupBulanAwal.TabIndex = 50
        '
        'txtBulan
        '
        Me.txtBulan.EditValue = ""
        Me.txtBulan.Location = New System.Drawing.Point(106, 27)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBulan.Properties.Appearance.Options.UseBackColor = True
        Me.txtBulan.Properties.DisplayFormat.FormatString = "d"
        Me.txtBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtBulan.Properties.EditFormat.FormatString = "d"
        Me.txtBulan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtBulan.Properties.NullText = "Tahun"
        Me.txtBulan.Size = New System.Drawing.Size(96, 20)
        Me.txtBulan.TabIndex = 3
        Me.txtBulan.Visible = False
        '
        'txtThn
        '
        Me.txtThn.EditValue = ""
        Me.txtThn.Location = New System.Drawing.Point(0, 27)
        Me.txtThn.Name = "txtThn"
        Me.txtThn.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtThn.Properties.Appearance.Options.UseBackColor = True
        Me.txtThn.Properties.DisplayFormat.FormatString = "d"
        Me.txtThn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtThn.Properties.EditFormat.FormatString = "d"
        Me.txtThn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtThn.Properties.NullText = "Tahun"
        Me.txtThn.Size = New System.Drawing.Size(92, 20)
        Me.txtThn.TabIndex = 2
        Me.txtThn.Visible = False
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
        Me.Panel2.Size = New System.Drawing.Size(1053, 51)
        Me.Panel2.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(679, 6)
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
        Me.cmdClear.Location = New System.Drawing.Point(638, 7)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.ToolTip = "Bersihkan Pencarian"
        Me.cmdClear.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdClear.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdClear.ToolTipTitle = "CLEAR"
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(554, 7)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.ToolTip = "Reset Data"
        Me.cmdRefresh.ToolTipController = Me.DefaultToolTipController1.DefaultController
        Me.cmdRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdRefresh.ToolTipTitle = "RELOAD"
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(541, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 51)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel5, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(28, 21)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.LookUpSaldo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(367, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 51)
        Me.Panel3.TabIndex = 1
        '
        'LookUpSaldo
        '
        Me.LookUpSaldo.Location = New System.Drawing.Point(0, 3)
        Me.LookUpSaldo.Name = "LookUpSaldo"
        Me.LookUpSaldo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpSaldo.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpSaldo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LookUpSaldo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpSaldo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kartu", "Kartu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("thn_buku", "Tahun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bln_buku", "Bulan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_debet", "Debet"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_val_kredit", "Kredit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Buku Besar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.LookUpSaldo.Properties.DropDownRows = 15
        Me.LookUpSaldo.Properties.NullText = "List Saldo"
        Me.LookUpSaldo.Size = New System.Drawing.Size(162, 20)
        Me.LookUpSaldo.TabIndex = 28
        Me.LookUpSaldo.Visible = False
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 51)
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
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 23)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Tahun / Bulan : "
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 431)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1053, 36)
        Me.pnlFooter.TabIndex = 2
        '
        'pnl
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnl, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1053, 467)
        Me.pnl.TabIndex = 5
        '
        'pnlGrid
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGrid, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGrid.Controls.Add(Me.GC)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 88)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1053, 343)
        Me.pnlGrid.TabIndex = 6
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC.MainView = Me.BandedGV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(1053, 343)
        Me.GC.TabIndex = 9
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGV})
        '
        'BandedGV
        '
        Me.BandedGV.ActiveFilterEnabled = False
        Me.BandedGV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.BandedGV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.BandedGV.Appearance.Empty.Options.UseBackColor = True
        Me.BandedGV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.EvenRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.EvenRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.BandedGV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BandedGV.Appearance.FixedLine.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.BandedGV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BandedGV.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BandedGV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.BandedGV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.GroupButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseFont = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGV.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BandedGV.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.HorzLine.Options.UseBackColor = True
        Me.BandedGV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.OddRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.OddRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.BandedGV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGV.Appearance.Preview.Options.UseFont = True
        Me.BandedGV.Appearance.Preview.Options.UseForeColor = True
        Me.BandedGV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.Row.Options.UseBackColor = True
        Me.BandedGV.Appearance.Row.Options.UseForeColor = True
        Me.BandedGV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.BandedGV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.BandedGV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.VertLine.Options.UseBackColor = True
        Me.BandedGV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2, Me.GridBand3, Me.GridBand4})
        Me.BandedGV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.kd_buku_besar, Me.nm_buku_besar, Me.saldo_awal, Me.debet, Me.kredit, Me.saldo_akhir})
        Me.BandedGV.GridControl = Me.GC
        Me.BandedGV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.saldo_akhir, "{0:n2}")})
        Me.BandedGV.Name = "BandedGV"
        Me.BandedGV.OptionsBehavior.AutoSelectAllInEditor = False
        Me.BandedGV.OptionsBehavior.Editable = False
        Me.BandedGV.OptionsBehavior.ReadOnly = True
        Me.BandedGV.OptionsView.ColumnAutoWidth = False
        Me.BandedGV.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGV.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGV.OptionsView.ShowFooter = True
        Me.BandedGV.OptionsView.ShowGroupPanel = False
        Me.BandedGV.OptionsView.ShowViewCaption = True
        Me.BandedGV.ViewCaption = "REKAPITULASI NERACA SALDO"
        '
        'gridBand1
        '
        Me.gridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBand1.AppearanceHeader.Options.UseFont = True
        Me.gridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand1.Caption = "Keterangan"
        Me.gridBand1.Columns.Add(Me.nm_buku_besar)
        Me.gridBand1.Columns.Add(Me.kd_buku_besar)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.RowCount = 2
        Me.gridBand1.Width = 63
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.Caption = "Nama Buku"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.Width = 63
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kode Buku"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Width = 63
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Awal"
        Me.gridBand2.Columns.Add(Me.saldo_awal)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Width = 63
        '
        'saldo_awal
        '
        Me.saldo_awal.Caption = "Saldo Awal"
        Me.saldo_awal.DisplayFormat.FormatString = "n2"
        Me.saldo_awal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_awal.FieldName = "saldo_awal"
        Me.saldo_awal.Name = "saldo_awal"
        Me.saldo_awal.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_awal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_awal.Visible = True
        Me.saldo_awal.Width = 63
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.GridBand3.AppearanceHeader.BackColor2 = System.Drawing.Color.Yellow
        Me.GridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridBand3.AppearanceHeader.Options.UseBackColor = True
        Me.GridBand3.AppearanceHeader.Options.UseBorderColor = True
        Me.GridBand3.AppearanceHeader.Options.UseFont = True
        Me.GridBand3.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridBand3.Caption = "D + K"
        Me.GridBand3.Columns.Add(Me.debet)
        Me.GridBand3.Columns.Add(Me.kredit)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 154
        '
        'debet
        '
        Me.debet.Caption = "Debet"
        Me.debet.DisplayFormat.FormatString = "n2"
        Me.debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.debet.FieldName = "debet"
        Me.debet.Name = "debet"
        Me.debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.debet.Visible = True
        Me.debet.Width = 91
        '
        'kredit
        '
        Me.kredit.Caption = "Kredit"
        Me.kredit.DisplayFormat.FormatString = "n2"
        Me.kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.kredit.FieldName = "kredit"
        Me.kredit.Name = "kredit"
        Me.kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.kredit.Visible = True
        Me.kredit.Width = 63
        '
        'GridBand4
        '
        Me.GridBand4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand4.AppearanceHeader.Options.UseFont = True
        Me.GridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand4.Caption = "Akhir"
        Me.GridBand4.Columns.Add(Me.saldo_akhir)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 89
        '
        'saldo_akhir
        '
        Me.saldo_akhir.Caption = "Saldo Akhir"
        Me.saldo_akhir.DisplayFormat.FormatString = "n2"
        Me.saldo_akhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_akhir.FieldName = "saldo_akhir"
        Me.saldo_akhir.Name = "saldo_akhir"
        Me.saldo_akhir.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_akhir.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_akhir.UnboundExpression = "[januari] + [februari] + [maret] + [april] + [mei] + [juni] + [juli] + [agustus] " & _
            "+ [september] + [oktober] + [november] + [desember]"
        Me.saldo_akhir.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.saldo_akhir.Visible = True
        Me.saldo_akhir.Width = 89
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonNSperiod
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 467)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonNSperiod"
        Me.Text = "frmMonNSperiod"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents saldo_awal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtThn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents saldo_akhir As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents debet As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LookUpSaldo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtBulan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
End Class
