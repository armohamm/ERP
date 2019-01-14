<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdDefSpk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdDefSpk))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnl_tengah2 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.xtDataBOM = New DevExpress.XtraTab.XtraTabPage
        Me.PnlTengah = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clKegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clSpk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.repSpk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.repStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtjenis = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        CType(Me.pnl_tengah2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_tengah2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtDataBOM.SuspendLayout()
        Me.PnlTengah.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSpk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtjenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.pnl_tengah2)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(979, 640)
        Me.pnl.TabIndex = 0
        '
        'pnl_tengah2
        '
        Me.pnl_tengah2.Controls.Add(Me.XtraTabControl1)
        Me.pnl_tengah2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_tengah2.Location = New System.Drawing.Point(0, 117)
        Me.pnl_tengah2.Name = "pnl_tengah2"
        Me.pnl_tengah2.Size = New System.Drawing.Size(979, 523)
        Me.pnl_tengah2.TabIndex = 8
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtDataBOM
        Me.XtraTabControl1.Size = New System.Drawing.Size(975, 519)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtDataBOM})
        '
        'xtDataBOM
        '
        Me.xtDataBOM.Controls.Add(Me.PnlTengah)
        Me.xtDataBOM.Name = "xtDataBOM"
        Me.xtDataBOM.Size = New System.Drawing.Size(968, 490)
        Me.xtDataBOM.Text = "Bahan DEFAULT"
        '
        'PnlTengah
        '
        Me.PnlTengah.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PnlTengah.Controls.Add(Me.GC)
        Me.PnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlTengah.Location = New System.Drawing.Point(0, 0)
        Me.PnlTengah.Name = "PnlTengah"
        Me.PnlTengah.Size = New System.Drawing.Size(968, 490)
        Me.PnlTengah.TabIndex = 9
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repKegiatan, Me.repSpk, Me.repStatus})
        Me.GC.Size = New System.Drawing.Size(968, 490)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV2, Me.GridView2})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clKegiatan, Me.clSpk, Me.colStatus})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'clKegiatan
        '
        Me.clKegiatan.Caption = "Kegiatan"
        Me.clKegiatan.FieldName = "kd_kegiatan"
        Me.clKegiatan.Name = "clKegiatan"
        Me.clKegiatan.Visible = True
        Me.clKegiatan.VisibleIndex = 0
        '
        'clSpk
        '
        Me.clSpk.Caption = "SPK"
        Me.clSpk.FieldName = "kd_spk"
        Me.clSpk.Name = "clSpk"
        Me.clSpk.Visible = True
        Me.clSpk.VisibleIndex = 1
        '
        'repKegiatan
        '
        Me.repKegiatan.AutoHeight = False
        Me.repKegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "kegiatan")})
        Me.repKegiatan.Name = "repKegiatan"
        Me.repKegiatan.NullText = "[Pilih Kegiatan]"
        '
        'repSpk
        '
        Me.repSpk.AutoHeight = False
        Me.repSpk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSpk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", 55, "spk")})
        Me.repSpk.Name = "repSpk"
        Me.repSpk.NullText = "[Pilih Nama Barang]"
        '
        'repStatus
        '
        Me.repStatus.AutoHeight = False
        Me.repStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.repStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repStatus.DisplayValueChecked = "Y"
        Me.repStatus.DisplayValueUnchecked = "T"
        Me.repStatus.Name = "repStatus"
        Me.repStatus.ValueChecked = "Y"
        Me.repStatus.ValueUnchecked = "T"
        '
        'GV2
        '
        Me.GV2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Empty.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupRow.Options.UseFont = True
        Me.GV2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.OddRow.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.Options.UseForeColor = True
        Me.GV2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.Preview.Options.UseBackColor = True
        Me.GV2.Appearance.Preview.Options.UseForeColor = True
        Me.GV2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.Row.Options.UseBackColor = True
        Me.GV2.Appearance.Row.Options.UseForeColor = True
        Me.GV2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.VertLine.Options.UseBackColor = True
        Me.GV2.GridControl = Me.GC
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.EnableAppearanceOddRow = True
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.PaintStyleName = "Skin"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GC
        Me.GridView2.Name = "GridView2"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.Panel4)
        Me.pnlTools.Controls.Add(Me.Panel3)
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(979, 83)
        Me.pnlTools.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(709, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(188, 83)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(618, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(91, 83)
        Me.Panel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.txtjenis)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(149, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 83)
        Me.Panel2.TabIndex = 5
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(0, 0)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtjenis.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtjenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama_Jenis")})
        Me.txtjenis.Properties.DisplayMember = "Nama_Jenis"
        Me.txtjenis.Properties.NullText = "PILIH JENIS"
        Me.txtjenis.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtjenis.Properties.PopupWidth = 400
        Me.txtjenis.Properties.ShowHeader = False
        Me.txtjenis.Properties.ValueMember = "Kd_Jns_Brg"
        Me.txtjenis.Size = New System.Drawing.Size(469, 20)
        Me.txtjenis.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 83)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama Jenis : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(979, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "DEFAULT SPK"
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status Generate Hpp"
        Me.colStatus.ColumnEdit = Me.repStatus
        Me.colStatus.FieldName = "status_hpp"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 2
        '
        'frmProdDefSpk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 664)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdDefSpk"
        Me.Text = "frm DEFAULT SPK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.pnl_tengah2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_tengah2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtDataBOM.ResumeLayout(False)
        Me.PnlTengah.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSpk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtjenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtjenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnl_tengah2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtDataBOM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PnlTengah As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clKegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clSpk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repSpk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
