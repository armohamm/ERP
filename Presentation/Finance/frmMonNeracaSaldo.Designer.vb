<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonNeracaSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonNeracaSaldo))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LookUpSaldo = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.BandedGV = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.nm_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tipe_rek = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.grup_level1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.januari = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.februari = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maret = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.april = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.mei = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.juni = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.juli = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.agustus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.september = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.oktober = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.november = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.desember = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.total = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LookUpValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.txtThn = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.LookUpValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(815, 3)
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
        'Panel5
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel5, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(266, 21)
        Me.Panel5.TabIndex = 0
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
        Me.lblJudul.Text = "MONITORING NERACA SALDO"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel4, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(541, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(266, 43)
        Me.Panel4.TabIndex = 2
        '
        'pnlFooter
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlFooter, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 511)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1170, 36)
        Me.pnlFooter.TabIndex = 2
        '
        'Panel7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel7, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 43)
        Me.Panel7.TabIndex = 9
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
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(139, 21)
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
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 21)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Tahun : "
        '
        'Panel3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel3, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel3.Controls.Add(Me.LookUpSaldo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(367, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 43)
        Me.Panel3.TabIndex = 1
        '
        'LookUpSaldo
        '
        Me.LookUpSaldo.Location = New System.Drawing.Point(6, 12)
        Me.LookUpSaldo.Name = "LookUpSaldo"
        Me.LookUpSaldo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.pnl.Size = New System.Drawing.Size(1170, 547)
        Me.pnl.TabIndex = 4
        '
        'pnlGrid
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.pnlGrid, DevExpress.Utils.DefaultBoolean.[Default])
        Me.pnlGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGrid.Controls.Add(Me.GC)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 80)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1170, 431)
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
        Me.GC.Size = New System.Drawing.Size(1170, 431)
        Me.GC.TabIndex = 9
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGV})
        '
        'BandedGV
        '
        Me.BandedGV.ActiveFilterEnabled = False
        Me.BandedGV.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.BandPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BandedGV.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.BandPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.BandPanel.Options.UseBorderColor = True
        Me.BandedGV.Appearance.BandPanel.Options.UseFont = True
        Me.BandedGV.Appearance.BandPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.BandedGV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.BandedGV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.BandedGV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.Empty.Options.UseBackColor = True
        Me.BandedGV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.EvenRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.BandedGV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BandedGV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BandedGV.Appearance.FixedLine.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.BandedGV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.BandedGV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.BandedGV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupButton.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupButton.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BandedGV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BandedGV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BandedGV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.GroupRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.BandedGV.Appearance.GroupRow.Options.UseFont = True
        Me.BandedGV.Appearance.GroupRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BandedGV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BandedGV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseFont = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.BandedGV.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGV.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGV.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.BandedGV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BandedGV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BandedGV.Appearance.HorzLine.Options.UseBackColor = True
        Me.BandedGV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.OddRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BandedGV.Appearance.Preview.Options.UseBackColor = True
        Me.BandedGV.Appearance.Preview.Options.UseForeColor = True
        Me.BandedGV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.BandedGV.Appearance.Row.Options.UseBackColor = True
        Me.BandedGV.Appearance.Row.Options.UseForeColor = True
        Me.BandedGV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.BandedGV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BandedGV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.BandedGV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.BandedGV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BandedGV.Appearance.VertLine.Options.UseBackColor = True
        Me.BandedGV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.GridBand2, Me.GridBand3})
        Me.BandedGV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.nm_buku_besar, Me.tipe_rek, Me.grup_level1, Me.januari, Me.februari, Me.maret, Me.april, Me.mei, Me.juni, Me.juli, Me.agustus, Me.september, Me.oktober, Me.november, Me.desember, Me.total})
        Me.BandedGV.GridControl = Me.GC
        Me.BandedGV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.total, "{0:n2}")})
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
        Me.gridBand1.Columns.Add(Me.tipe_rek)
        Me.gridBand1.Columns.Add(Me.grup_level1)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.RowCount = 2
        Me.gridBand1.Width = 191
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.Caption = "Nama Rek"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.Width = 63
        '
        'tipe_rek
        '
        Me.tipe_rek.Caption = "Tipe Rek"
        Me.tipe_rek.FieldName = "tipe_rek"
        Me.tipe_rek.Name = "tipe_rek"
        Me.tipe_rek.Visible = True
        Me.tipe_rek.Width = 63
        '
        'grup_level1
        '
        Me.grup_level1.Caption = "Grup"
        Me.grup_level1.FieldName = "grup_level1"
        Me.grup_level1.Name = "grup_level1"
        Me.grup_level1.Visible = True
        Me.grup_level1.Width = 65
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.GridBand2.AppearanceHeader.BackColor2 = System.Drawing.Color.Yellow
        Me.GridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridBand2.AppearanceHeader.Options.UseBackColor = True
        Me.GridBand2.AppearanceHeader.Options.UseBorderColor = True
        Me.GridBand2.AppearanceHeader.Options.UseFont = True
        Me.GridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridBand2.Caption = "Mutasi"
        Me.GridBand2.Columns.Add(Me.januari)
        Me.GridBand2.Columns.Add(Me.februari)
        Me.GridBand2.Columns.Add(Me.maret)
        Me.GridBand2.Columns.Add(Me.april)
        Me.GridBand2.Columns.Add(Me.mei)
        Me.GridBand2.Columns.Add(Me.juni)
        Me.GridBand2.Columns.Add(Me.juli)
        Me.GridBand2.Columns.Add(Me.agustus)
        Me.GridBand2.Columns.Add(Me.september)
        Me.GridBand2.Columns.Add(Me.oktober)
        Me.GridBand2.Columns.Add(Me.november)
        Me.GridBand2.Columns.Add(Me.desember)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 810
        '
        'januari
        '
        Me.januari.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.januari.AppearanceCell.Options.UseBackColor = True
        Me.januari.Caption = "Januari"
        Me.januari.DisplayFormat.FormatString = "n2"
        Me.januari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.januari.FieldName = "januari"
        Me.januari.Name = "januari"
        Me.januari.SummaryItem.DisplayFormat = "{0:n2}"
        Me.januari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.januari.Visible = True
        Me.januari.Width = 91
        '
        'februari
        '
        Me.februari.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.februari.AppearanceCell.Options.UseBackColor = True
        Me.februari.Caption = "Februari"
        Me.februari.DisplayFormat.FormatString = "n2"
        Me.februari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.februari.FieldName = "februari"
        Me.februari.Name = "februari"
        Me.februari.SummaryItem.DisplayFormat = "{0:n2}"
        Me.februari.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.februari.Visible = True
        Me.februari.Width = 63
        '
        'maret
        '
        Me.maret.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.maret.AppearanceCell.Options.UseBackColor = True
        Me.maret.Caption = "Maret"
        Me.maret.DisplayFormat.FormatString = "n2"
        Me.maret.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.maret.FieldName = "maret"
        Me.maret.Name = "maret"
        Me.maret.SummaryItem.DisplayFormat = "{0:n2}"
        Me.maret.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.maret.Visible = True
        Me.maret.Width = 63
        '
        'april
        '
        Me.april.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.april.AppearanceCell.Options.UseBackColor = True
        Me.april.Caption = "April"
        Me.april.DisplayFormat.FormatString = "n2"
        Me.april.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.april.FieldName = "april"
        Me.april.Name = "april"
        Me.april.SummaryItem.DisplayFormat = "{0:n2}"
        Me.april.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.april.Visible = True
        Me.april.Width = 63
        '
        'mei
        '
        Me.mei.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.mei.AppearanceCell.Options.UseBackColor = True
        Me.mei.Caption = "Mei"
        Me.mei.DisplayFormat.FormatString = "n2"
        Me.mei.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.mei.FieldName = "mei"
        Me.mei.Name = "mei"
        Me.mei.SummaryItem.DisplayFormat = "{0:n2}"
        Me.mei.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.mei.Visible = True
        Me.mei.Width = 63
        '
        'juni
        '
        Me.juni.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.juni.AppearanceCell.Options.UseBackColor = True
        Me.juni.Caption = "Juni"
        Me.juni.DisplayFormat.FormatString = "n2"
        Me.juni.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.juni.FieldName = "juni"
        Me.juni.Name = "juni"
        Me.juni.SummaryItem.DisplayFormat = "{0:n2}"
        Me.juni.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.juni.Visible = True
        Me.juni.Width = 63
        '
        'juli
        '
        Me.juli.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.juli.AppearanceCell.Options.UseBackColor = True
        Me.juli.Caption = "Juli"
        Me.juli.DisplayFormat.FormatString = "n2"
        Me.juli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.juli.FieldName = "juli"
        Me.juli.Name = "juli"
        Me.juli.SummaryItem.DisplayFormat = "{0:n2}"
        Me.juli.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.juli.Visible = True
        Me.juli.Width = 63
        '
        'agustus
        '
        Me.agustus.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.agustus.AppearanceCell.Options.UseBackColor = True
        Me.agustus.Caption = "Agustus"
        Me.agustus.DisplayFormat.FormatString = "n2"
        Me.agustus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.agustus.FieldName = "agustus"
        Me.agustus.Name = "agustus"
        Me.agustus.SummaryItem.DisplayFormat = "{0:n2}"
        Me.agustus.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.agustus.Visible = True
        Me.agustus.Width = 63
        '
        'september
        '
        Me.september.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.september.AppearanceCell.Options.UseBackColor = True
        Me.september.Caption = "September"
        Me.september.DisplayFormat.FormatString = "n2"
        Me.september.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.september.FieldName = "september"
        Me.september.Name = "september"
        Me.september.SummaryItem.DisplayFormat = "{0:n2}"
        Me.september.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.september.Visible = True
        Me.september.Width = 63
        '
        'oktober
        '
        Me.oktober.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.oktober.AppearanceCell.Options.UseBackColor = True
        Me.oktober.Caption = "Oktober"
        Me.oktober.DisplayFormat.FormatString = "n2"
        Me.oktober.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.oktober.FieldName = "oktober"
        Me.oktober.Name = "oktober"
        Me.oktober.SummaryItem.DisplayFormat = "{0:n2}"
        Me.oktober.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.oktober.Visible = True
        Me.oktober.Width = 63
        '
        'november
        '
        Me.november.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.november.AppearanceCell.Options.UseBackColor = True
        Me.november.Caption = "November"
        Me.november.DisplayFormat.FormatString = "n2"
        Me.november.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.november.FieldName = "november"
        Me.november.Name = "november"
        Me.november.SummaryItem.DisplayFormat = "{0:n2}"
        Me.november.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.november.Visible = True
        Me.november.Width = 63
        '
        'desember
        '
        Me.desember.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.desember.AppearanceCell.Options.UseBackColor = True
        Me.desember.Caption = "Desember"
        Me.desember.DisplayFormat.FormatString = "n2"
        Me.desember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.desember.FieldName = "desember"
        Me.desember.Name = "desember"
        Me.desember.SummaryItem.DisplayFormat = "{0:n2}"
        Me.desember.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.desember.Visible = True
        Me.desember.Width = 89
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand3.AppearanceHeader.Options.UseFont = True
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "Total"
        Me.GridBand3.Columns.Add(Me.total)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 89
        '
        'total
        '
        Me.total.Caption = "Total"
        Me.total.DisplayFormat.FormatString = "n2"
        Me.total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.total.FieldName = "total"
        Me.total.Name = "total"
        Me.total.SummaryItem.DisplayFormat = "{0:n2}"
        Me.total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.total.UnboundExpression = "[januari] + [februari] + [maret] + [april] + [mei] + [juni] + [juli] + [agustus] " & _
            "+ [september] + [oktober] + [november] + [desember]"
        Me.total.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.total.Visible = True
        Me.total.Width = 89
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
        Me.Panel2.Size = New System.Drawing.Size(1170, 43)
        Me.Panel2.TabIndex = 5
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(947, 5)
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
        Me.cmdClear.Location = New System.Drawing.Point(859, 3)
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
        Me.cmdRefresh.Location = New System.Drawing.Point(903, 3)
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
        'Panel6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.Panel6, DevExpress.Utils.DefaultBoolean.[Default])
        Me.Panel6.Controls.Add(Me.LookUpValuta)
        Me.Panel6.Controls.Add(Me.txtThn)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 43)
        Me.Panel6.TabIndex = 5
        '
        'LookUpValuta
        '
        Me.LookUpValuta.Location = New System.Drawing.Point(0, 22)
        Me.LookUpValuta.Name = "LookUpValuta"
        Me.LookUpValuta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LookUpValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode")})
        Me.LookUpValuta.Properties.NullText = "Valuta"
        Me.LookUpValuta.Size = New System.Drawing.Size(202, 20)
        Me.LookUpValuta.TabIndex = 1
        '
        'txtThn
        '
        Me.txtThn.Location = New System.Drawing.Point(0, 1)
        Me.txtThn.Name = "txtThn"
        Me.txtThn.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtThn.Properties.Appearance.Options.UseBackColor = True
        Me.txtThn.Properties.DisplayFormat.FormatString = "d"
        Me.txtThn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtThn.Properties.EditFormat.FormatString = "d"
        Me.txtThn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtThn.Properties.NullText = "Tahun"
        Me.txtThn.Size = New System.Drawing.Size(202, 20)
        Me.txtThn.TabIndex = 2
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
        Me.Panel1.Size = New System.Drawing.Size(1170, 37)
        Me.Panel1.TabIndex = 4
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMonNeracaSaldo
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 547)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonNeracaSaldo"
        Me.Text = "frmMonNeracaSaldo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.LookUpSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.LookUpValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LookUpValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tipe_rek As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents grup_level1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents januari As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents februari As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents maret As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents april As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents mei As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents juni As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents juli As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents agustus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents september As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents oktober As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents november As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents desember As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents total As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpSaldo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtThn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
End Class
