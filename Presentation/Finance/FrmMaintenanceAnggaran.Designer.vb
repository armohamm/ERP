<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintenanceAnggaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaintenanceAnggaran))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.Anggaran = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.kd_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RnmBkBsr = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PusatBiaya = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.rKode_BK_PST = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.liat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.lnkDetail = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView
        Me.KD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Me.LayoutView2 = New DevExpress.XtraGrid.Views.Layout.LayoutView
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_kd_buku_besar = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_PusatBiaya = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumn3 = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_kd_valuta = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumn4 = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_jml_trans = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumn5 = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_liat = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.LookUpPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnmBkBsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rKode_BK_PST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lnkDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_kd_buku_besar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_PusatBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_kd_valuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_jml_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_liat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        Me.pnl1.SuspendLayout()
        CType(Me.LookUpPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GC
        Me.GridView2.Name = "GridView2"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GC.Location = New System.Drawing.Point(0, 69)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lnkDetail, Me.RnmBkBsr})
        Me.GC.Size = New System.Drawing.Size(784, 381)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.CardView1, Me.LayoutView1, Me.LayoutView2, Me.GridView2})
        '
        'GV
        '
        Me.GV.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.BandPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.BandPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.BandPanel.Options.UseBackColor = True
        Me.GV.Appearance.BandPanel.Options.UseBorderColor = True
        Me.GV.Appearance.BandPanel.Options.UseFont = True
        Me.GV.Appearance.BandPanel.Options.UseForeColor = True
        Me.GV.Appearance.BandPanelBackground.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseFont = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.HeaderPanelBackground.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Anggaran})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.kd_buku_besar, Me.PusatBiaya, Me.kd_valuta, Me.jml_trans, Me.liat, Me.nm_buku_besar})
        Me.GV.CustomizationFormBounds = New System.Drawing.Rectangle(627, 395, 215, 205)
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'Anggaran
        '
        Me.Anggaran.Caption = "Anggaran"
        Me.Anggaran.Columns.Add(Me.kd_buku_besar)
        Me.Anggaran.Columns.Add(Me.nm_buku_besar)
        Me.Anggaran.Columns.Add(Me.PusatBiaya)
        Me.Anggaran.Columns.Add(Me.kd_valuta)
        Me.Anggaran.Columns.Add(Me.jml_trans)
        Me.Anggaran.Columns.Add(Me.liat)
        Me.Anggaran.MinWidth = 20
        Me.Anggaran.Name = "Anggaran"
        Me.Anggaran.Width = 1176
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.Caption = "Kode Rekening"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.OptionsColumn.AllowEdit = False
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.Width = 154
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nm_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.nm_buku_besar.Caption = "NM. KODE BESAR"
        Me.nm_buku_besar.ColumnEdit = Me.RnmBkBsr
        Me.nm_buku_besar.FieldName = "kd_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.OptionsColumn.AllowEdit = False
        Me.nm_buku_besar.OptionsColumn.AllowFocus = False
        Me.nm_buku_besar.OptionsColumn.AllowSize = False
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.Width = 281
        '
        'RnmBkBsr
        '
        Me.RnmBkBsr.AutoHeight = False
        Me.RnmBkBsr.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RnmBkBsr.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Bk Besar")})
        Me.RnmBkBsr.Name = "RnmBkBsr"
        Me.RnmBkBsr.NullText = "[Buku Besar is null]"
        '
        'PusatBiaya
        '
        Me.PusatBiaya.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PusatBiaya.AppearanceHeader.Options.UseFont = True
        Me.PusatBiaya.Caption = "Pusat Biaya"
        Me.PusatBiaya.ColumnEdit = Me.rKode_BK_PST
        Me.PusatBiaya.FieldName = "kd_buku_pusat"
        Me.PusatBiaya.Name = "PusatBiaya"
        Me.PusatBiaya.Visible = True
        Me.PusatBiaya.Width = 280
        '
        'rKode_BK_PST
        '
        Me.rKode_BK_PST.AutoHeight = False
        Me.rKode_BK_PST.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rKode_BK_PST.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "kd_buku_pusat"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "nm_buku_pusat")})
        Me.rKode_BK_PST.DisplayMember = "kd_buku_pusat"
        Me.rKode_BK_PST.Name = "rKode_BK_PST"
        Me.rKode_BK_PST.NullText = "[Pilih Kode BK Pusat]"
        Me.rKode_BK_PST.NullValuePrompt = "[Pilih Kode BK Pusat]"
        Me.rKode_BK_PST.ValueMember = "kd_buku_pusat"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceCell.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.Width = 61
        '
        'jml_trans
        '
        Me.jml_trans.AppearanceCell.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!)
        Me.jml_trans.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.jml_trans.AppearanceCell.Options.UseFont = True
        Me.jml_trans.AppearanceCell.Options.UseTextOptions = True
        Me.jml_trans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_trans.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.jml_trans.Caption = "Jml. Transaksi"
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.Visible = True
        Me.jml_trans.Width = 281
        '
        'liat
        '
        Me.liat.AppearanceCell.Options.UseTextOptions = True
        Me.liat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.liat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.liat.AppearanceHeader.Options.UseFont = True
        Me.liat.AppearanceHeader.Options.UseTextOptions = True
        Me.liat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.liat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.liat.Caption = "View Detail"
        Me.liat.ColumnEdit = Me.lnkDetail
        Me.liat.Name = "liat"
        Me.liat.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.liat.Visible = True
        Me.liat.Width = 119
        '
        'lnkDetail
        '
        Me.lnkDetail.AutoHeight = False
        Me.lnkDetail.Name = "lnkDetail"
        Me.lnkDetail.NullText = "Detail"
        Me.lnkDetail.NullValuePrompt = "Detail"
        '
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KD, Me.Nama})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GC
        Me.CardView1.Name = "CardView1"
        '
        'KD
        '
        Me.KD.Caption = "GridColumn1"
        Me.KD.Name = "KD"
        Me.KD.Visible = True
        Me.KD.VisibleIndex = 0
        '
        'Nama
        '
        Me.Nama.Caption = "GridColumn1"
        Me.Nama.Name = "Nama"
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 1
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.GC
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'LayoutView2
        '
        Me.LayoutView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.LayoutViewColumn1, Me.LayoutViewColumn2, Me.LayoutViewColumn3, Me.LayoutViewColumn4, Me.LayoutViewColumn5})
        Me.LayoutView2.GridControl = Me.GC
        Me.LayoutView2.Name = "LayoutView2"
        Me.LayoutView2.TemplateCard = Me.LayoutViewCard2
        '
        'LayoutViewColumn1
        '
        Me.LayoutViewColumn1.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LayoutViewColumn1.AppearanceHeader.Options.UseFont = True
        Me.LayoutViewColumn1.Caption = "Kode Rekening"
        Me.LayoutViewColumn1.FieldName = "kd_buku_besar"
        Me.LayoutViewColumn1.LayoutViewField = Me.layoutViewField_kd_buku_besar
        Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
        Me.LayoutViewColumn1.OptionsColumn.AllowEdit = False
        Me.LayoutViewColumn1.Width = 171
        '
        'layoutViewField_kd_buku_besar
        '
        Me.layoutViewField_kd_buku_besar.EditorPreferredWidth = 120
        Me.layoutViewField_kd_buku_besar.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_kd_buku_besar.Name = "layoutViewField_kd_buku_besar"
        Me.layoutViewField_kd_buku_besar.Size = New System.Drawing.Size(203, 20)
        Me.layoutViewField_kd_buku_besar.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutViewColumn2
        '
        Me.LayoutViewColumn2.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LayoutViewColumn2.AppearanceHeader.Options.UseFont = True
        Me.LayoutViewColumn2.Caption = "Pusat Biaya"
        Me.LayoutViewColumn2.FieldName = "kartu"
        Me.LayoutViewColumn2.LayoutViewField = Me.layoutViewField_PusatBiaya
        Me.LayoutViewColumn2.Name = "LayoutViewColumn2"
        Me.LayoutViewColumn2.Width = 311
        '
        'layoutViewField_PusatBiaya
        '
        Me.layoutViewField_PusatBiaya.EditorPreferredWidth = 120
        Me.layoutViewField_PusatBiaya.Location = New System.Drawing.Point(0, 20)
        Me.layoutViewField_PusatBiaya.Name = "layoutViewField_PusatBiaya"
        Me.layoutViewField_PusatBiaya.Size = New System.Drawing.Size(203, 20)
        Me.layoutViewField_PusatBiaya.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutViewColumn3
        '
        Me.LayoutViewColumn3.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LayoutViewColumn3.AppearanceHeader.Options.UseFont = True
        Me.LayoutViewColumn3.Caption = "Valuta"
        Me.LayoutViewColumn3.FieldName = "kd_valuta"
        Me.LayoutViewColumn3.LayoutViewField = Me.layoutViewField_kd_valuta
        Me.LayoutViewColumn3.Name = "LayoutViewColumn3"
        Me.LayoutViewColumn3.Width = 76
        '
        'layoutViewField_kd_valuta
        '
        Me.layoutViewField_kd_valuta.EditorPreferredWidth = 120
        Me.layoutViewField_kd_valuta.Location = New System.Drawing.Point(0, 40)
        Me.layoutViewField_kd_valuta.Name = "layoutViewField_kd_valuta"
        Me.layoutViewField_kd_valuta.Size = New System.Drawing.Size(203, 20)
        Me.layoutViewField_kd_valuta.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutViewColumn4
        '
        Me.LayoutViewColumn4.AppearanceCell.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!)
        Me.LayoutViewColumn4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.LayoutViewColumn4.AppearanceCell.Options.UseFont = True
        Me.LayoutViewColumn4.AppearanceHeader.Options.UseFont = True
        Me.LayoutViewColumn4.Caption = "Jml. Transaksi"
        Me.LayoutViewColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LayoutViewColumn4.FieldName = "jml_trans"
        Me.LayoutViewColumn4.LayoutViewField = Me.layoutViewField_jml_trans
        Me.LayoutViewColumn4.Name = "LayoutViewColumn4"
        Me.LayoutViewColumn4.Width = 205
        '
        'layoutViewField_jml_trans
        '
        Me.layoutViewField_jml_trans.EditorPreferredWidth = 120
        Me.layoutViewField_jml_trans.Location = New System.Drawing.Point(0, 60)
        Me.layoutViewField_jml_trans.Name = "layoutViewField_jml_trans"
        Me.layoutViewField_jml_trans.Size = New System.Drawing.Size(203, 20)
        Me.layoutViewField_jml_trans.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutViewColumn5
        '
        Me.LayoutViewColumn5.Caption = "View Detail"
        Me.LayoutViewColumn5.ColumnEdit = Me.lnkDetail
        Me.LayoutViewColumn5.LayoutViewField = Me.layoutViewField_liat
        Me.LayoutViewColumn5.Name = "LayoutViewColumn5"
        Me.LayoutViewColumn5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'layoutViewField_liat
        '
        Me.layoutViewField_liat.EditorPreferredWidth = 120
        Me.layoutViewField_liat.Location = New System.Drawing.Point(0, 80)
        Me.layoutViewField_liat.Name = "layoutViewField_liat"
        Me.layoutViewField_liat.Size = New System.Drawing.Size(203, 20)
        Me.layoutViewField_liat.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_kd_buku_besar, Me.layoutViewField_PusatBiaya, Me.layoutViewField_kd_valuta, Me.layoutViewField_jml_trans, Me.layoutViewField_liat})
        Me.LayoutViewCard2.Name = "LayoutViewCard2"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(784, 450)
        Me.pnl.TabIndex = 0
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.White
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(784, 35)
        Me.pnlTools.TabIndex = 5
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.LookUpPeriode)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(511, 35)
        Me.pnl1.TabIndex = 0
        '
        'LookUpPeriode
        '
        Me.LookUpPeriode.Location = New System.Drawing.Point(206, 5)
        Me.LookUpPeriode.Name = "LookUpPeriode"
        Me.LookUpPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpPeriode.Properties.NullText = "[Silahkan Pilih]"
        Me.LookUpPeriode.Size = New System.Drawing.Size(305, 20)
        Me.LookUpPeriode.TabIndex = 3
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(200, 35)
        Me.pnl11.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pilih Periode Anggaran :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(784, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(704, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MAINTENANCE ANGGARAN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 468)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Simpan"
        '
        'FrmMaintenanceAnggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmMaintenanceAnggaran"
        Me.Text = "FrmMaintenanceAnggaran"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnmBkBsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rKode_BK_PST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lnkDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_kd_buku_besar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_PusatBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_kd_valuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_jml_trans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_liat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        CType(Me.LookUpPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LookUpPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PusatBiaya As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents KD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rKode_BK_PST As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents liat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lnkDetail As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Anggaran As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LayoutView2 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_kd_buku_besar As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_PusatBiaya As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn3 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_kd_valuta As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn4 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_jml_trans As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_liat As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard2 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents RnmBkBsr As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
