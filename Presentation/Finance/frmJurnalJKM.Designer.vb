<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnalJKM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJurnalJKM))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
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
        Me.txtNominal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.saldo_val_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.saldo_rp_kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.txtKet = New DevExpress.XtraEditors.MemoEdit
        Me.txtAlamat = New DevExpress.XtraEditors.TextEdit
        Me.txtNama = New DevExpress.XtraEditors.TextEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtValuta = New DevExpress.XtraEditors.SpinEdit
        Me.lueValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.txtRef = New DevExpress.XtraEditors.TextEdit
        Me.dtpTanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtNoJur = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoJur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel11)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Location = New System.Drawing.Point(8, 8)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(926, 514)
        Me.pnl.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel10)
        Me.Panel11.Controls.Add(Me.Panel6)
        Me.Panel11.Controls.Add(Me.Panel9)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 34)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(926, 446)
        Me.Panel11.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.gcJurnal)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 108)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(926, 338)
        Me.Panel10.TabIndex = 9
        '
        'gcJurnal
        '
        Me.gcJurnal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJurnal.Location = New System.Drawing.Point(0, 0)
        Me.gcJurnal.MainView = Me.gvJurnal
        Me.gcJurnal.Name = "gcJurnal"
        Me.gcJurnal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueBB, Me.lueKartu, Me.lueBP, Me.txtNominal})
        Me.gcJurnal.Size = New System.Drawing.Size(926, 338)
        Me.gcJurnal.TabIndex = 0
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
        Me.gvJurnal.NewItemRowText = "Tambah data baru disini"
        Me.gvJurnal.OptionsCustomization.AllowColumnMoving = False
        Me.gvJurnal.OptionsCustomization.AllowFilter = False
        Me.gvJurnal.OptionsCustomization.AllowGroup = False
        Me.gvJurnal.OptionsMenu.EnableColumnMenu = False
        Me.gvJurnal.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvJurnal.OptionsView.EnableAppearanceEvenRow = True
        Me.gvJurnal.OptionsView.EnableAppearanceOddRow = True
        Me.gvJurnal.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvJurnal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvJurnal.OptionsView.ShowFooter = True
        Me.gvJurnal.OptionsView.ShowGroupPanel = False
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
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 43
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
        Me.kd_buku_besar.Width = 113
        '
        'lueBB
        '
        Me.lueBB.AutoHeight = False
        Me.lueBB.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBB.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Buku Besar")})
        Me.lueBB.Name = "lueBB"
        Me.lueBB.NullText = "[Pilih Rekening]"
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
        Me.kartu.Width = 90
        '
        'lueKartu
        '
        Me.lueKartu.AutoHeight = False
        Me.lueKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lueKartu.Name = "lueKartu"
        Me.lueKartu.NullText = "[Pilih Kartu]"
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
        Me.kd_buku_pusat.Width = 100
        '
        'lueBP
        '
        Me.lueBP.AutoHeight = False
        Me.lueBP.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBP.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Buku Pusat")})
        Me.lueBP.Name = "lueBP"
        Me.lueBP.NullText = "[Pilih Bagian]"
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
        Me.keterangan.Width = 120
        '
        'saldo_val_debet
        '
        Me.saldo_val_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_debet.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_debet.Caption = "Val Debet"
        Me.saldo_val_debet.ColumnEdit = Me.txtNominal
        Me.saldo_val_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_val_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_debet.FieldName = "saldo_val_debet"
        Me.saldo_val_debet.Name = "saldo_val_debet"
        Me.saldo_val_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_debet.Visible = True
        Me.saldo_val_debet.VisibleIndex = 5
        Me.saldo_val_debet.Width = 105
        '
        'txtNominal
        '
        Me.txtNominal.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtNominal.AutoHeight = False
        Me.txtNominal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtNominal.Mask.EditMask = "n2"
        Me.txtNominal.Mask.UseMaskAsDisplayFormat = True
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.NullText = "0"
        Me.txtNominal.ValidateOnEnterKey = True
        '
        'saldo_val_kredit
        '
        Me.saldo_val_kredit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_val_kredit.AppearanceHeader.Options.UseFont = True
        Me.saldo_val_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_val_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_val_kredit.Caption = "Val Kredit"
        Me.saldo_val_kredit.ColumnEdit = Me.txtNominal
        Me.saldo_val_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_val_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_val_kredit.FieldName = "saldo_val_kredit"
        Me.saldo_val_kredit.Name = "saldo_val_kredit"
        Me.saldo_val_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_val_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_val_kredit.Visible = True
        Me.saldo_val_kredit.VisibleIndex = 6
        Me.saldo_val_kredit.Width = 109
        '
        'saldo_rp_debet
        '
        Me.saldo_rp_debet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_rp_debet.AppearanceHeader.Options.UseFont = True
        Me.saldo_rp_debet.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_debet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_debet.Caption = "Rp. Debet"
        Me.saldo_rp_debet.ColumnEdit = Me.txtNominal
        Me.saldo_rp_debet.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_debet.FieldName = "saldo_rp_debet"
        Me.saldo_rp_debet.Name = "saldo_rp_debet"
        Me.saldo_rp_debet.OptionsColumn.AllowEdit = False
        Me.saldo_rp_debet.OptionsColumn.ReadOnly = True
        Me.saldo_rp_debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_debet.Visible = True
        Me.saldo_rp_debet.VisibleIndex = 7
        Me.saldo_rp_debet.Width = 107
        '
        'saldo_rp_kredit
        '
        Me.saldo_rp_kredit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_rp_kredit.AppearanceHeader.Options.UseFont = True
        Me.saldo_rp_kredit.AppearanceHeader.Options.UseTextOptions = True
        Me.saldo_rp_kredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.saldo_rp_kredit.Caption = "Rp. Kredit"
        Me.saldo_rp_kredit.ColumnEdit = Me.txtNominal
        Me.saldo_rp_kredit.DisplayFormat.FormatString = "n2"
        Me.saldo_rp_kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.saldo_rp_kredit.FieldName = "saldo_rp_kredit"
        Me.saldo_rp_kredit.Name = "saldo_rp_kredit"
        Me.saldo_rp_kredit.OptionsColumn.AllowEdit = False
        Me.saldo_rp_kredit.OptionsColumn.ReadOnly = True
        Me.saldo_rp_kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.saldo_rp_kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.saldo_rp_kredit.Visible = True
        Me.saldo_rp_kredit.VisibleIndex = 8
        Me.saldo_rp_kredit.Width = 122
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(926, 8)
        Me.Panel6.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.Panel4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(926, 100)
        Me.Panel9.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel8)
        Me.Panel12.Controls.Add(Me.Panel7)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(400, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(526, 100)
        Me.Panel12.TabIndex = 7
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtKet)
        Me.Panel8.Controls.Add(Me.txtAlamat)
        Me.Panel8.Controls.Add(Me.txtNama)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(137, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(389, 100)
        Me.Panel8.TabIndex = 6
        '
        'txtKet
        '
        Me.txtKet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKet.EnterMoveNextControl = True
        Me.txtKet.Location = New System.Drawing.Point(0, 40)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKet.Properties.ValidateOnEnterKey = True
        Me.txtKet.Size = New System.Drawing.Size(389, 60)
        Me.txtKet.TabIndex = 8
        '
        'txtAlamat
        '
        Me.txtAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAlamat.EnterMoveNextControl = True
        Me.txtAlamat.Location = New System.Drawing.Point(0, 20)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(389, 20)
        Me.txtAlamat.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNama.EnterMoveNextControl = True
        Me.txtNama.Location = New System.Drawing.Point(0, 0)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(389, 20)
        Me.txtNama.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(137, 100)
        Me.Panel7.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 60)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Keterangan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Alamat"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Kepada"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(400, 100)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtValuta)
        Me.Panel3.Controls.Add(Me.lueValuta)
        Me.Panel3.Controls.Add(Me.txtRef)
        Me.Panel3.Controls.Add(Me.dtpTanggal)
        Me.Panel3.Controls.Add(Me.txtNoJur)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(90, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 100)
        Me.Panel3.TabIndex = 4
        '
        'txtValuta
        '
        Me.txtValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtValuta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValuta.EnterMoveNextControl = True
        Me.txtValuta.Location = New System.Drawing.Point(0, 80)
        Me.txtValuta.Name = "txtValuta"
        Me.txtValuta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtValuta.Properties.Mask.EditMask = "n2"
        Me.txtValuta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValuta.Properties.ValidateOnEnterKey = True
        Me.txtValuta.Size = New System.Drawing.Size(310, 20)
        Me.txtValuta.TabIndex = 5
        '
        'lueValuta
        '
        Me.lueValuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lueValuta.EnterMoveNextControl = True
        Me.lueValuta.Location = New System.Drawing.Point(0, 60)
        Me.lueValuta.Name = "lueValuta"
        Me.lueValuta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lueValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama Valuta")})
        Me.lueValuta.Properties.NullText = "[Pilih Valuta]"
        Me.lueValuta.Size = New System.Drawing.Size(310, 20)
        Me.lueValuta.TabIndex = 4
        '
        'txtRef
        '
        Me.txtRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRef.EnterMoveNextControl = True
        Me.txtRef.Location = New System.Drawing.Point(0, 40)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(310, 20)
        Me.txtRef.TabIndex = 3
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtpTanggal.EditValue = Nothing
        Me.dtpTanggal.EnterMoveNextControl = True
        Me.dtpTanggal.Location = New System.Drawing.Point(0, 20)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpTanggal.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dtpTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtpTanggal.Properties.ShowPopupShadow = False
        Me.dtpTanggal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpTanggal.Properties.ValidateOnEnterKey = True
        Me.dtpTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpTanggal.Size = New System.Drawing.Size(310, 20)
        Me.dtpTanggal.TabIndex = 2
        '
        'txtNoJur
        '
        Me.txtNoJur.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoJur.Location = New System.Drawing.Point(0, 0)
        Me.txtNoJur.Name = "txtNoJur"
        Me.txtNoJur.Properties.ReadOnly = True
        Me.txtNoJur.Size = New System.Drawing.Size(310, 20)
        Me.txtNoJur.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 100)
        Me.Panel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kurs Valuta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valuta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Referensi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nomor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 480)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 34)
        Me.Panel1.TabIndex = 143
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(926, 34)
        Me.Panel5.TabIndex = 142
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         FORM PENCATATAN JURNAL KAS MASUK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmJurnalJKM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 667)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmJurnalJKM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Jurnal"
        Me.pnl.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNominal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.txtKet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoJur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
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
    Friend WithEvents saldo_val_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo_rp_kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNominal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txtKet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValuta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lueValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoJur As DevExpress.XtraEditors.TextEdit
End Class
