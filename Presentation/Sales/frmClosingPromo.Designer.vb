<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClosingPromo
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClosingPromo))
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PROMODESC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repHadiah = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Program = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlLoad = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtsampai = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDari = New DevExpress.XtraEditors.TextEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtKodePromo = New DevExpress.XtraEditors.TextEdit
        Me.txtPromo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repHadiah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlLoad.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.txtsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtKodePromo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPromo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV2
        '
        Me.GV2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV2.Appearance.Empty.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GV2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GV2.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GV2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GV2.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GV2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GV2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.OddRow.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.Options.UseForeColor = True
        Me.GV2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GV2.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GV2.Appearance.Preview.Options.UseBackColor = True
        Me.GV2.Appearance.Preview.Options.UseFont = True
        Me.GV2.Appearance.Preview.Options.UseForeColor = True
        Me.GV2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GV2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.Row.Options.UseBackColor = True
        Me.GV2.Appearance.Row.Options.UseForeColor = True
        Me.GV2.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GV2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GV2.Appearance.VertLine.Options.UseBackColor = True
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_cust, Me.PROMODESC})
        Me.GV2.GridControl = Me.GC
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.EnableAppearanceOddRow = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_cust.AppearanceHeader.Options.UseForeColor = True
        Me.kd_cust.Caption = "Customer"
        Me.kd_cust.ColumnEdit = Me.repCustomer
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 0
        Me.kd_cust.Width = 310
        '
        'repCustomer
        '
        Me.repCustomer.AutoHeight = False
        Me.repCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Name1")})
        Me.repCustomer.Name = "repCustomer"
        '
        'PROMODESC
        '
        Me.PROMODESC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PROMODESC.AppearanceHeader.Options.UseForeColor = True
        Me.PROMODESC.Caption = "Hadiah"
        Me.PROMODESC.ColumnEdit = Me.repHadiah
        Me.PROMODESC.FieldName = "kd_brg_hadiah"
        Me.PROMODESC.Name = "PROMODESC"
        Me.PROMODESC.Width = 466
        '
        'repHadiah
        '
        Me.repHadiah.AutoHeight = False
        Me.repHadiah.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repHadiah.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HADIAH", "Name3")})
        Me.repHadiah.Name = "repHadiah"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV2
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 80)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCustomer, Me.repHadiah})
        Me.GC.Size = New System.Drawing.Size(797, 309)
        Me.GC.TabIndex = 5
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV2})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseBorderColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nomor, Me.Program})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Nomor
        '
        Me.Nomor.Caption = "Nomor"
        Me.Nomor.FieldName = "no_seq"
        Me.Nomor.Name = "Nomor"
        Me.Nomor.Visible = True
        Me.Nomor.VisibleIndex = 0
        Me.Nomor.Width = 66
        '
        'Program
        '
        Me.Program.Caption = "Program"
        Me.Program.FieldName = "promo_desc"
        Me.Program.Name = "Program"
        Me.Program.Visible = True
        Me.Program.VisibleIndex = 1
        Me.Program.Width = 412
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlLoad)
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(20, 16)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(797, 389)
        Me.pnl.TabIndex = 0
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoad.Border = True
        Me.pnlLoad.BorderColor = System.Drawing.Color.Transparent
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlLoad.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLoad.Controls.Add(Me.PictureBox2)
        Me.pnlLoad.Controls.Add(Me.Label4)
        Me.pnlLoad.CornerRadius = 8
        Me.pnlLoad.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlLoad.Gradient = True
        Me.pnlLoad.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlLoad.GradientOffset = 1.0!
        Me.pnlLoad.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLoad.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLoad.Grayscale = False
        Me.pnlLoad.Image = Nothing
        Me.pnlLoad.ImageAlpha = 75
        Me.pnlLoad.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlLoad.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlLoad.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLoad.Location = New System.Drawing.Point(241, 154)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Rounded = True
        Me.pnlLoad.Size = New System.Drawing.Size(305, 63)
        Me.pnlLoad.TabIndex = 8
        Me.pnlLoad.Visible = False
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha1.Parent = Me.pnlLoad
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Me.pnlLoad
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(4, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 63)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Harap Tunggu..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(797, 43)
        Me.Panel3.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(742, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 43)
        Me.btnRefresh.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.txtsampai)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtDari)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(132, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(610, 43)
        Me.Panel5.TabIndex = 1
        '
        'txtsampai
        '
        Me.txtsampai.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsampai.Enabled = False
        Me.txtsampai.EnterMoveNextControl = True
        Me.txtsampai.Location = New System.Drawing.Point(161, 21)
        Me.txtsampai.Name = "txtsampai"
        Me.txtsampai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsampai.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtsampai.Properties.Appearance.Options.UseBackColor = True
        Me.txtsampai.Properties.Appearance.Options.UseFont = True
        Me.txtsampai.Properties.Appearance.Options.UseForeColor = True
        Me.txtsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtsampai.Properties.ReadOnly = True
        Me.txtsampai.Size = New System.Drawing.Size(125, 20)
        Me.txtsampai.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "  -  "
        '
        'txtDari
        '
        Me.txtDari.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtDari.Enabled = False
        Me.txtDari.EnterMoveNextControl = True
        Me.txtDari.Location = New System.Drawing.Point(0, 21)
        Me.txtDari.Name = "txtDari"
        Me.txtDari.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDari.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtDari.Properties.Appearance.Options.UseBackColor = True
        Me.txtDari.Properties.Appearance.Options.UseFont = True
        Me.txtDari.Properties.Appearance.Options.UseForeColor = True
        Me.txtDari.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDari.Properties.ReadOnly = True
        Me.txtDari.Size = New System.Drawing.Size(125, 20)
        Me.txtDari.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtKodePromo)
        Me.Panel6.Controls.Add(Me.txtPromo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(610, 21)
        Me.Panel6.TabIndex = 0
        '
        'txtKodePromo
        '
        Me.txtKodePromo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKodePromo.EnterMoveNextControl = True
        Me.txtKodePromo.Location = New System.Drawing.Point(477, 0)
        Me.txtKodePromo.Name = "txtKodePromo"
        Me.txtKodePromo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodePromo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKodePromo.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodePromo.Properties.Appearance.Options.UseForeColor = True
        Me.txtKodePromo.Properties.ReadOnly = True
        Me.txtKodePromo.Size = New System.Drawing.Size(133, 20)
        Me.txtKodePromo.TabIndex = 4
        '
        'txtPromo
        '
        Me.txtPromo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtPromo.Location = New System.Drawing.Point(0, 0)
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPromo.Properties.Appearance.Options.UseBackColor = True
        Me.txtPromo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPromo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_promo", "nama_promo", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtPromo.Properties.DisplayMember = "nama_promo"
        Me.txtPromo.Properties.DropDownRows = 15
        Me.txtPromo.Properties.HideSelection = False
        Me.txtPromo.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtPromo.Properties.NullText = ""
        Me.txtPromo.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtPromo.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtPromo.Properties.PopupWidth = 400
        Me.txtPromo.Properties.ShowHeader = False
        Me.txtPromo.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtPromo.Properties.ValueMember = "no_promo"
        Me.txtPromo.Size = New System.Drawing.Size(477, 20)
        Me.txtPromo.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(132, 43)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masa Berlaku : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promo : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel2.Size = New System.Drawing.Size(797, 37)
        Me.Panel2.TabIndex = 3
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(273, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM PENUTUPAN PROMO"
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
        'frmClosingPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 417)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmClosingPromo"
        Me.Text = "frmClosingPromo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repHadiah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlLoad.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtKodePromo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPromo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPromo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKodePromo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtsampai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Program As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROMODESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repHadiah As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlLoad As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
