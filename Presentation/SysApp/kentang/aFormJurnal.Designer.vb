<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormJurnal
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormJurnal))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlGrid = New DevExpress.XtraEditors.PanelControl
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.gcJurnal = New DevExpress.XtraGrid.GridControl
        Me.gvJurnal = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueBB = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueBP = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_val_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.secNominal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlFilter = New DevExpress.XtraEditors.PanelControl
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.pnlFilter2 = New DevExpress.XtraEditors.PanelControl
        Me.pnlKeterangan = New System.Windows.Forms.Panel
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.pnlAlamat = New System.Windows.Forms.Panel
        Me.txtAlamat = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.pnlKepada = New System.Windows.Forms.Panel
        Me.txtKepada = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.pnlFilter1 = New DevExpress.XtraEditors.PanelControl
        Me.pnlKurs = New System.Windows.Forms.Panel
        Me.txtKurs = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.pnlValuta = New System.Windows.Forms.Panel
        Me.lckValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.pnlNoRef = New System.Windows.Forms.Panel
        Me.txtNoRef = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnlTanggal = New System.Windows.Forms.Panel
        Me.decTanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlNo = New System.Windows.Forms.Panel
        Me.txtNoJurnal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.pnlFilter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter2.SuspendLayout()
        Me.pnlKeterangan.SuspendLayout()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlamat.SuspendLayout()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKepada.SuspendLayout()
        CType(Me.txtKepada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter1.SuspendLayout()
        Me.pnlKurs.SuspendLayout()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlValuta.SuspendLayout()
        CType(Me.lckValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoRef.SuspendLayout()
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTanggal.SuspendLayout()
        CType(Me.decTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNo.SuspendLayout()
        CType(Me.txtNoJurnal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFilter)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Location = New System.Drawing.Point(16, 8)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(850, 500)
        Me.pnl.TabIndex = 0
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.Panel14)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(2, 187)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(846, 286)
        Me.pnlGrid.TabIndex = 146
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.gcJurnal)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(2, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(842, 282)
        Me.Panel14.TabIndex = 0
        '
        'gcJurnal
        '
        Me.gcJurnal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJurnal.Location = New System.Drawing.Point(0, 0)
        Me.gcJurnal.MainView = Me.gvJurnal
        Me.gcJurnal.Name = "gcJurnal"
        Me.gcJurnal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueBB, Me.lueKartu, Me.lueBP, Me.secNominal})
        Me.gcJurnal.Size = New System.Drawing.Size(842, 282)
        Me.gcJurnal.TabIndex = 1
        Me.gcJurnal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJurnal})
        '
        'gvJurnal
        '
        Me.gvJurnal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvJurnal.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvJurnal.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvJurnal.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.Empty.Options.UseBackColor = True
        Me.gvJurnal.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvJurnal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvJurnal.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvJurnal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvJurnal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvJurnal.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvJurnal.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvJurnal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvJurnal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvJurnal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvJurnal.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvJurnal.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvJurnal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvJurnal.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvJurnal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvJurnal.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvJurnal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvJurnal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvJurnal.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvJurnal.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvJurnal.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvJurnal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.GroupRow.Options.UseFont = True
        Me.gvJurnal.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvJurnal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvJurnal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvJurnal.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvJurnal.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvJurnal.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvJurnal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvJurnal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvJurnal.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvJurnal.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvJurnal.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.OddRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.OddRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvJurnal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvJurnal.Appearance.Preview.Options.UseBackColor = True
        Me.gvJurnal.Appearance.Preview.Options.UseForeColor = True
        Me.gvJurnal.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvJurnal.Appearance.Row.Options.UseBackColor = True
        Me.gvJurnal.Appearance.Row.Options.UseForeColor = True
        Me.gvJurnal.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvJurnal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvJurnal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvJurnal.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvJurnal.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvJurnal.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvJurnal.Appearance.VertLine.Options.UseBackColor = True
        Me.gvJurnal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_buku_besar, Me.kartu, Me.kd_buku_pusat, Me.keterangan, Me.saldo_val_debet, Me.saldo_val_kredit, Me.saldo_rp_debet, Me.saldo_rp_kredit})
        Me.gvJurnal.GridControl = Me.gcJurnal
        Me.gvJurnal.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gvJurnal.Name = "gvJurnal"
        Me.gvJurnal.NewItemRowText = "Tambah data disini."
        Me.gvJurnal.OptionsCustomization.AllowColumnMoving = False
        Me.gvJurnal.OptionsCustomization.AllowFilter = False
        Me.gvJurnal.OptionsCustomization.AllowGroup = False
        Me.gvJurnal.OptionsMenu.EnableColumnMenu = False
        Me.gvJurnal.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvJurnal.OptionsView.EnableAppearanceEvenRow = True
        Me.gvJurnal.OptionsView.EnableAppearanceOddRow = True
        Me.gvJurnal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvJurnal.OptionsView.ShowFooter = True
        Me.gvJurnal.OptionsView.ShowGroupPanel = False
        Me.gvJurnal.OptionsView.ShowIndicator = False
        Me.gvJurnal.PaintStyleName = "Office2003"
        '
        'no_seq
        '
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 45
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lueBB
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 1
        Me.kd_buku_besar.Width = 111
        '
        'lueBB
        '
        Me.lueBB.AutoHeight = False
        Me.lueBB.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBB.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Buku Besar")})
        Me.lueBB.Name = "lueBB"
        Me.lueBB.NullText = "[Buku Besar]"
        '
        'kartu
        '
        Me.kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kartu.AppearanceHeader.Options.UseFont = True
        Me.kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kartu.Caption = "Kartu"
        Me.kartu.ColumnEdit = Me.lueKartu
        Me.kartu.FieldName = "kartu"
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 2
        '
        'lueKartu
        '
        Me.lueKartu.AutoHeight = False
        Me.lueKartu.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lueKartu.Name = "lueKartu"
        Me.lueKartu.NullText = "[Kartu]"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_pusat.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_pusat.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_pusat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_pusat.Caption = "Pusat Biaya"
        Me.kd_buku_pusat.ColumnEdit = Me.lueBP
        Me.kd_buku_pusat.FieldName = "kd_buku_pusat"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 3
        Me.kd_buku_pusat.Width = 105
        '
        'lueBP
        '
        Me.lueBP.AutoHeight = False
        Me.lueBP.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueBP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBP.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.lueBP.Name = "lueBP"
        Me.lueBP.NullText = "[Buku Pusat]"
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
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 116
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_debet.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_debet.Caption = "Val Debet"
        Me.saldo_val_debet.ColumnEdit = Me.secNominal
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 5
        Me.saldo_val_debet.Width = 111
        '
        'secNominal
        '
        Me.secNominal.AutoHeight = False
        Me.secNominal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.secNominal.EditFormat.FormatString = "n2"
        Me.secNominal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.secNominal.Mask.EditMask = "n2"
        Me.secNominal.Mask.UseMaskAsDisplayFormat = True
        Me.secNominal.Name = "secNominal"
        Me.secNominal.ValidateOnEnterKey = True
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_kredit.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_kredit.Caption = "Val Kredit"
        Me.saldo_val_kredit.ColumnEdit = Me.secNominal
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 6
        Me.saldo_val_kredit.Width = 105
        '
        'saldo_rp_debet
        '
        Me.saldo_rp_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_rp_debet.AppearanceHeader.Options.UseFont = True
        Me.saldo_rp_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_debet.Caption = "Rp. Debet"
        Me.saldo_rp_debet.ColumnEdit = Me.secNominal
        Me.saldo_rp_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_debet.FieldName = "saldo_rp_debet"
        Me.saldo_rp_debet.Name = "saldo_rp_debet"
        Me.saldo_rp_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_debet.Visible = True
        Me.saldo_rp_debet.VisibleIndex = 7
        Me.saldo_rp_debet.Width = 100
        '
        'saldo_rp_kredit
        '
        Me.saldo_rp_kredit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_rp_kredit.AppearanceHeader.Options.UseFont = True
        Me.saldo_rp_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_kredit.Caption = "Rp. Kredit"
        Me.saldo_rp_kredit.ColumnEdit = Me.secNominal
        Me.saldo_rp_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_kredit.FieldName = "saldo_rp_kredit"
        Me.saldo_rp_kredit.Name = "saldo_rp_kredit"
        Me.saldo_rp_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_kredit.Visible = True
        Me.saldo_rp_kredit.VisibleIndex = 8
        Me.saldo_rp_kredit.Width = 106
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.Panel12)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(2, 37)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(846, 150)
        Me.pnlFilter.TabIndex = 145
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.pnlFilter2)
        Me.Panel12.Controls.Add(Me.pnlFilter1)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(2, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(842, 146)
        Me.Panel12.TabIndex = 0
        '
        'pnlFilter2
        '
        Me.pnlFilter2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlFilter2.Controls.Add(Me.pnlKeterangan)
        Me.pnlFilter2.Controls.Add(Me.Panel19)
        Me.pnlFilter2.Controls.Add(Me.pnlAlamat)
        Me.pnlFilter2.Controls.Add(Me.Panel21)
        Me.pnlFilter2.Controls.Add(Me.pnlKepada)
        Me.pnlFilter2.Controls.Add(Me.Panel23)
        Me.pnlFilter2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilter2.Location = New System.Drawing.Point(423, 0)
        Me.pnlFilter2.Name = "pnlFilter2"
        Me.pnlFilter2.Size = New System.Drawing.Size(400, 146)
        Me.pnlFilter2.TabIndex = 8
        '
        'pnlKeterangan
        '
        Me.pnlKeterangan.BackColor = System.Drawing.Color.Transparent
        Me.pnlKeterangan.Controls.Add(Me.txtKet)
        Me.pnlKeterangan.Controls.Add(Me.LabelControl19)
        Me.pnlKeterangan.Controls.Add(Me.LabelControl20)
        Me.pnlKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKeterangan.Location = New System.Drawing.Point(0, 55)
        Me.pnlKeterangan.Name = "pnlKeterangan"
        Me.pnlKeterangan.Size = New System.Drawing.Size(400, 80)
        Me.pnlKeterangan.TabIndex = 12
        '
        'txtKet
        '
        Me.txtKet.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKet.Location = New System.Drawing.Point(100, 0)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(275, 80)
        Me.txtKet.TabIndex = 2
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl19.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl19.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Padding = New System.Windows.Forms.Padding(0, 0, 0, 60)
        Me.LabelControl19.Size = New System.Drawing.Size(10, 80)
        Me.LabelControl19.TabIndex = 1
        Me.LabelControl19.Text = ":"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl20.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl20.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Padding = New System.Windows.Forms.Padding(0, 0, 0, 60)
        Me.LabelControl20.Size = New System.Drawing.Size(90, 80)
        Me.LabelControl20.TabIndex = 0
        Me.LabelControl20.Text = "Keterangan"
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 50)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(400, 5)
        Me.Panel19.TabIndex = 11
        '
        'pnlAlamat
        '
        Me.pnlAlamat.BackColor = System.Drawing.Color.Transparent
        Me.pnlAlamat.Controls.Add(Me.txtAlamat)
        Me.pnlAlamat.Controls.Add(Me.LabelControl21)
        Me.pnlAlamat.Controls.Add(Me.LabelControl22)
        Me.pnlAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAlamat.Location = New System.Drawing.Point(0, 30)
        Me.pnlAlamat.Name = "pnlAlamat"
        Me.pnlAlamat.Size = New System.Drawing.Size(400, 20)
        Me.pnlAlamat.TabIndex = 10
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtAlamat.Location = New System.Drawing.Point(100, 0)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Properties.ValidateOnEnterKey = True
        Me.txtAlamat.Size = New System.Drawing.Size(275, 20)
        Me.txtAlamat.TabIndex = 3
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl21.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl21.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl21.TabIndex = 1
        Me.LabelControl21.Text = ":"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl22.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl22.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl22.TabIndex = 0
        Me.LabelControl22.Text = "Alamat"
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 25)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(400, 5)
        Me.Panel21.TabIndex = 9
        '
        'pnlKepada
        '
        Me.pnlKepada.BackColor = System.Drawing.Color.Transparent
        Me.pnlKepada.Controls.Add(Me.txtKepada)
        Me.pnlKepada.Controls.Add(Me.LabelControl23)
        Me.pnlKepada.Controls.Add(Me.LabelControl24)
        Me.pnlKepada.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKepada.Location = New System.Drawing.Point(0, 5)
        Me.pnlKepada.Name = "pnlKepada"
        Me.pnlKepada.Size = New System.Drawing.Size(400, 20)
        Me.pnlKepada.TabIndex = 8
        '
        'txtKepada
        '
        Me.txtKepada.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKepada.Location = New System.Drawing.Point(100, 0)
        Me.txtKepada.Name = "txtKepada"
        Me.txtKepada.Size = New System.Drawing.Size(150, 20)
        Me.txtKepada.TabIndex = 2
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl23.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl23.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl23.TabIndex = 1
        Me.LabelControl23.Text = ":"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl24.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl24.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl24.TabIndex = 0
        Me.LabelControl24.Text = "Kepada"
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(400, 5)
        Me.Panel23.TabIndex = 7
        '
        'pnlFilter1
        '
        Me.pnlFilter1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlFilter1.Controls.Add(Me.pnlKurs)
        Me.pnlFilter1.Controls.Add(Me.Panel10)
        Me.pnlFilter1.Controls.Add(Me.pnlValuta)
        Me.pnlFilter1.Controls.Add(Me.Panel9)
        Me.pnlFilter1.Controls.Add(Me.pnlNoRef)
        Me.pnlFilter1.Controls.Add(Me.Panel6)
        Me.pnlFilter1.Controls.Add(Me.pnlTanggal)
        Me.pnlFilter1.Controls.Add(Me.Panel4)
        Me.pnlFilter1.Controls.Add(Me.pnlNo)
        Me.pnlFilter1.Controls.Add(Me.Panel3)
        Me.pnlFilter1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilter1.Location = New System.Drawing.Point(48, 0)
        Me.pnlFilter1.Name = "pnlFilter1"
        Me.pnlFilter1.Size = New System.Drawing.Size(375, 146)
        Me.pnlFilter1.TabIndex = 7
        '
        'pnlKurs
        '
        Me.pnlKurs.BackColor = System.Drawing.Color.Transparent
        Me.pnlKurs.Controls.Add(Me.txtKurs)
        Me.pnlKurs.Controls.Add(Me.LabelControl9)
        Me.pnlKurs.Controls.Add(Me.LabelControl10)
        Me.pnlKurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKurs.Location = New System.Drawing.Point(0, 105)
        Me.pnlKurs.Name = "pnlKurs"
        Me.pnlKurs.Size = New System.Drawing.Size(375, 20)
        Me.pnlKurs.TabIndex = 22
        '
        'txtKurs
        '
        Me.txtKurs.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKurs.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtKurs.EnterMoveNextControl = True
        Me.txtKurs.Location = New System.Drawing.Point(100, 0)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtKurs.Properties.EditFormat.FormatString = "n2"
        Me.txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Properties.Mask.EditMask = "n2"
        Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKurs.Properties.ValidateOnEnterKey = True
        Me.txtKurs.Size = New System.Drawing.Size(125, 20)
        Me.txtKurs.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl9.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = ":"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl10.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "Kurs Valuta"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 100)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(375, 5)
        Me.Panel10.TabIndex = 21
        '
        'pnlValuta
        '
        Me.pnlValuta.BackColor = System.Drawing.Color.Transparent
        Me.pnlValuta.Controls.Add(Me.lckValuta)
        Me.pnlValuta.Controls.Add(Me.LabelControl7)
        Me.pnlValuta.Controls.Add(Me.LabelControl8)
        Me.pnlValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlValuta.Location = New System.Drawing.Point(0, 80)
        Me.pnlValuta.Name = "pnlValuta"
        Me.pnlValuta.Size = New System.Drawing.Size(375, 20)
        Me.pnlValuta.TabIndex = 20
        '
        'lckValuta
        '
        Me.lckValuta.Dock = System.Windows.Forms.DockStyle.Left
        Me.lckValuta.EnterMoveNextControl = True
        Me.lckValuta.Location = New System.Drawing.Point(100, 0)
        Me.lckValuta.Name = "lckValuta"
        Me.lckValuta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lckValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Name1")})
        Me.lckValuta.Properties.NullText = "[Kosong]"
        Me.lckValuta.Properties.ShowFooter = False
        Me.lckValuta.Properties.ShowHeader = False
        Me.lckValuta.Properties.ShowPopupShadow = False
        Me.lckValuta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lckValuta.Properties.ValidateOnEnterKey = True
        Me.lckValuta.Size = New System.Drawing.Size(150, 20)
        Me.lckValuta.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = ":"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl8.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Valuta"
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 75)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(375, 5)
        Me.Panel9.TabIndex = 19
        '
        'pnlNoRef
        '
        Me.pnlNoRef.BackColor = System.Drawing.Color.Transparent
        Me.pnlNoRef.Controls.Add(Me.txtNoRef)
        Me.pnlNoRef.Controls.Add(Me.LabelControl5)
        Me.pnlNoRef.Controls.Add(Me.LabelControl6)
        Me.pnlNoRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoRef.Location = New System.Drawing.Point(0, 55)
        Me.pnlNoRef.Name = "pnlNoRef"
        Me.pnlNoRef.Size = New System.Drawing.Size(375, 20)
        Me.pnlNoRef.TabIndex = 18
        '
        'txtNoRef
        '
        Me.txtNoRef.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoRef.Location = New System.Drawing.Point(100, 0)
        Me.txtNoRef.Name = "txtNoRef"
        Me.txtNoRef.Properties.ValidateOnEnterKey = True
        Me.txtNoRef.Size = New System.Drawing.Size(250, 20)
        Me.txtNoRef.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl5.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "No. Referensi"
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(375, 5)
        Me.Panel6.TabIndex = 17
        '
        'pnlTanggal
        '
        Me.pnlTanggal.BackColor = System.Drawing.Color.Transparent
        Me.pnlTanggal.Controls.Add(Me.decTanggal)
        Me.pnlTanggal.Controls.Add(Me.LabelControl3)
        Me.pnlTanggal.Controls.Add(Me.LabelControl4)
        Me.pnlTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTanggal.Location = New System.Drawing.Point(0, 30)
        Me.pnlTanggal.Name = "pnlTanggal"
        Me.pnlTanggal.Size = New System.Drawing.Size(375, 20)
        Me.pnlTanggal.TabIndex = 16
        '
        'decTanggal
        '
        Me.decTanggal.Dock = System.Windows.Forms.DockStyle.Left
        Me.decTanggal.EditValue = Nothing
        Me.decTanggal.EnterMoveNextControl = True
        Me.decTanggal.Location = New System.Drawing.Point(100, 0)
        Me.decTanggal.Name = "decTanggal"
        Me.decTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.decTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.decTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.decTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.decTanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.decTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.decTanggal.Properties.ShowPopupShadow = False
        Me.decTanggal.Properties.ValidateOnEnterKey = True
        Me.decTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.decTanggal.Size = New System.Drawing.Size(150, 20)
        Me.decTanggal.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Tanggal"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(375, 5)
        Me.Panel4.TabIndex = 15
        '
        'pnlNo
        '
        Me.pnlNo.BackColor = System.Drawing.Color.Transparent
        Me.pnlNo.Controls.Add(Me.txtNoJurnal)
        Me.pnlNo.Controls.Add(Me.LabelControl2)
        Me.pnlNo.Controls.Add(Me.LabelControl1)
        Me.pnlNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNo.Location = New System.Drawing.Point(0, 5)
        Me.pnlNo.Name = "pnlNo"
        Me.pnlNo.Size = New System.Drawing.Size(375, 20)
        Me.pnlNo.TabIndex = 14
        '
        'txtNoJurnal
        '
        Me.txtNoJurnal.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoJurnal.Enabled = False
        Me.txtNoJurnal.Location = New System.Drawing.Point(100, 0)
        Me.txtNoJurnal.Name = "txtNoJurnal"
        Me.txtNoJurnal.Size = New System.Drawing.Size(200, 20)
        Me.txtNoJurnal.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(90, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nomor"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 5)
        Me.Panel3.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(48, 146)
        Me.Panel13.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 473)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 25)
        Me.Panel1.TabIndex = 144
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(846, 35)
        Me.Panel5.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM JURNAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'aFormJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 530)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormJurnal"
        Me.Text = "aFormJurnal"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secNominal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.pnlFilter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter2.ResumeLayout(False)
        Me.pnlKeterangan.ResumeLayout(False)
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlamat.ResumeLayout(False)
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKepada.ResumeLayout(False)
        CType(Me.txtKepada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter1.ResumeLayout(False)
        Me.pnlKurs.ResumeLayout(False)
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlValuta.ResumeLayout(False)
        CType(Me.lckValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoRef.ResumeLayout(False)
        CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTanggal.ResumeLayout(False)
        CType(Me.decTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNo.ResumeLayout(False)
        CType(Me.txtNoJurnal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlGrid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents gcJurnal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJurnal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueBB As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueBP As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_val_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents secNominal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlFilter As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents pnlFilter2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlFilter1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents pnlKeterangan As System.Windows.Forms.Panel
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents pnlAlamat As System.Windows.Forms.Panel
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents pnlKepada As System.Windows.Forms.Panel
    Friend WithEvents txtKepada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents pnlKurs As System.Windows.Forms.Panel
    Friend WithEvents txtKurs As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pnlValuta As System.Windows.Forms.Panel
    Friend WithEvents lckValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents pnlNoRef As System.Windows.Forms.Panel
    Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlTanggal As System.Windows.Forms.Panel
    Friend WithEvents decTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlNo As System.Windows.Forms.Panel
    Friend WithEvents txtNoJurnal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
