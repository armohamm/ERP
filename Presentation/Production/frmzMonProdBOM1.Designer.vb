<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmzMonProdBOM1
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
        Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmzMonProdBOM1))
        Me.hpp = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.TREE = New DevExpress.XtraTreeList.TreeList
        Me.component_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.jumlah = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colID = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colParent = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.bom_code = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.assembly_code = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.satuan = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNama_Barang = New DevExpress.XtraEditors.LookUpEdit
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_bom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_rek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepRek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepRek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hpp
        '
        Me.hpp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.hpp.AppearanceHeader.Options.UseFont = True
        Me.hpp.AppearanceHeader.Options.UseTextOptions = True
        Me.hpp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.hpp.Caption = "HPP"
        Me.hpp.FieldName = "nilai_rata"
        Me.hpp.Format.FormatString = "n2"
        Me.hpp.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.hpp.Name = "hpp"
        Me.hpp.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
        Me.hpp.RowFooterSummaryStrFormat = "{0:n2}"
        Me.hpp.Visible = True
        Me.hpp.VisibleIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(727, 34)
        Me.Panel7.TabIndex = 5
        '
        'TREE
        '
        Me.TREE.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.TREE.Appearance.Empty.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.TREE.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.TREE.Appearance.EvenRow.Options.UseBackColor = True
        Me.TREE.Appearance.EvenRow.Options.UseForeColor = True
        Me.TREE.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TREE.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TREE.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.TREE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.TREE.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.TREE.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupButton.Options.UseBackColor = True
        Me.TREE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupButton.Options.UseForeColor = True
        Me.TREE.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TREE.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.TREE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.TREE.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TREE.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.TREE.Appearance.HeaderPanel.Options.UseFont = True
        Me.TREE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.TREE.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.TREE.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TREE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.TREE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.TREE.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.HorzLine.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TREE.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.TREE.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.TREE.Appearance.OddRow.Options.UseBackColor = True
        Me.TREE.Appearance.OddRow.Options.UseForeColor = True
        Me.TREE.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TREE.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.TREE.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TREE.Appearance.Preview.Options.UseBackColor = True
        Me.TREE.Appearance.Preview.Options.UseForeColor = True
        Me.TREE.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.TREE.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.TREE.Appearance.Row.Options.UseBackColor = True
        Me.TREE.Appearance.Row.Options.UseForeColor = True
        Me.TREE.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.TREE.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.TREE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TREE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.TREE.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TREE.Appearance.TreeLine.Options.UseBackColor = True
        Me.TREE.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TREE.Appearance.VertLine.Options.UseBackColor = True
        Me.TREE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TREE.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.component_name, Me.jumlah, Me.hpp, Me.colID, Me.colParent, Me.bom_code, Me.assembly_code, Me.satuan})
        Me.TREE.CustomizationFormBounds = New System.Drawing.Rectangle(765, 370, 216, 178)
        Me.TREE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TREE.DragExpandDelay = 500
        Me.TREE.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Expression = "[call_form]='' or [call_form] is null"
        StyleFormatCondition1.Value1 = ""
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.hpp
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[bom_code] == [component_name]"
        StyleFormatCondition2.Value1 = "-"
        Me.TREE.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.TREE.ImageIndexFieldName = ""
        Me.TREE.Location = New System.Drawing.Point(0, 0)
        Me.TREE.LookAndFeel.SkinName = "The Asphalt World"
        Me.TREE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TREE.Name = "TREE"
        Me.TREE.OptionsBehavior.AutoFocusNewNode = True
        Me.TREE.OptionsBehavior.AutoMoveRowFocus = True
        Me.TREE.OptionsBehavior.DragNodes = True
        Me.TREE.OptionsBehavior.Editable = False
        Me.TREE.OptionsBehavior.EnterMovesNextColumn = True
        Me.TREE.OptionsBehavior.ResizeNodes = False
        Me.TREE.OptionsBehavior.UseTabKey = True
        Me.TREE.OptionsLayout.AddNewColumns = False
        Me.TREE.OptionsView.AutoCalcPreviewLineCount = True
        Me.TREE.OptionsView.EnableAppearanceEvenRow = True
        Me.TREE.OptionsView.EnableAppearanceOddRow = True
        Me.TREE.OptionsView.ShowRowFooterSummary = True
        Me.TREE.OptionsView.ShowSummaryFooter = True
        Me.TREE.RootValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TREE.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
        Me.TREE.Size = New System.Drawing.Size(918, 279)
        Me.TREE.TabIndex = 7
        Me.TREE.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark
        '
        'component_name
        '
        Me.component_name.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.component_name.AppearanceHeader.Options.UseFont = True
        Me.component_name.AppearanceHeader.Options.UseTextOptions = True
        Me.component_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.component_name.Caption = "Nama Barang"
        Me.component_name.FieldName = "component_name"
        Me.component_name.Name = "component_name"
        Me.component_name.OptionsColumn.AllowEdit = False
        Me.component_name.Visible = True
        Me.component_name.VisibleIndex = 0
        Me.component_name.Width = 446
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jumlah.AppearanceHeader.Options.UseFont = True
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Jumlah"
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Format.FormatString = "n3"
        Me.jumlah.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowEdit = False
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 1
        '
        'colID
        '
        Me.colID.Caption = "ID Item"
        Me.colID.FieldName = "iditem"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colParent
        '
        Me.colParent.Caption = "ID Parent"
        Me.colParent.FieldName = "idparent"
        Me.colParent.Name = "colParent"
        Me.colParent.OptionsColumn.AllowEdit = False
        Me.colParent.OptionsColumn.ReadOnly = True
        '
        'bom_code
        '
        Me.bom_code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bom_code.AppearanceHeader.Options.UseFont = True
        Me.bom_code.AppearanceHeader.Options.UseTextOptions = True
        Me.bom_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bom_code.Caption = "Kode BOM"
        Me.bom_code.FieldName = "bom_code"
        Me.bom_code.Name = "bom_code"
        '
        'assembly_code
        '
        Me.assembly_code.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.assembly_code.AppearanceHeader.Options.UseFont = True
        Me.assembly_code.AppearanceHeader.Options.UseTextOptions = True
        Me.assembly_code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.assembly_code.Caption = "Assembly code"
        Me.assembly_code.FieldName = "assembly_code"
        Me.assembly_code.Name = "assembly_code"
        '
        'satuan
        '
        Me.satuan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.satuan.AppearanceHeader.Options.UseFont = True
        Me.satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 34)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Barang : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNama_Barang
        '
        Me.txtNama_Barang.EnterMoveNextControl = True
        Me.txtNama_Barang.Location = New System.Drawing.Point(0, 7)
        Me.txtNama_Barang.Name = "txtNama_Barang"
        Me.txtNama_Barang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNama_Barang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bom_code", "Kode Barang", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bom_name", "Nama Barang")})
        Me.txtNama_Barang.Properties.NullText = "[Pilih Barang]"
        Me.txtNama_Barang.Size = New System.Drawing.Size(346, 20)
        Me.txtNama_Barang.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(336, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MONITORING HPP BOM PRODUKSI"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNama_Barang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(191, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 34)
        Me.Panel2.TabIndex = 6
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
        Me.pnlTitle.Size = New System.Drawing.Size(918, 34)
        Me.pnlTitle.TabIndex = 4
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
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(6, 4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 27)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "&Refresh"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnLoad)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(537, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 34)
        Me.Panel3.TabIndex = 7
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(918, 603)
        Me.pnl.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainerControl1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(918, 535)
        Me.Panel4.TabIndex = 8
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TREE)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(918, 535)
        Me.SplitContainerControl1.SplitterPosition = 279
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepRek})
        Me.GridControl1.Size = New System.Drawing.Size(918, 250)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_bom, Me.kd_rek, Me.nilai, Me.Keterangan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowViewCaption = True
        Me.GridView1.ViewCaption = "TABEL BOM BIAYA"
        '
        'kd_bom
        '
        Me.kd_bom.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_bom.AppearanceHeader.Options.UseFont = True
        Me.kd_bom.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bom.Caption = "No BOM"
        Me.kd_bom.FieldName = "kd_bom"
        Me.kd_bom.Name = "kd_bom"
        Me.kd_bom.Visible = True
        Me.kd_bom.VisibleIndex = 0
        '
        'kd_rek
        '
        Me.kd_rek.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_rek.AppearanceHeader.Options.UseFont = True
        Me.kd_rek.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_rek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_rek.Caption = "Rek"
        Me.kd_rek.ColumnEdit = Me.RepRek
        Me.kd_rek.FieldName = "kd_rek"
        Me.kd_rek.Name = "kd_rek"
        Me.kd_rek.Visible = True
        Me.kd_rek.VisibleIndex = 1
        '
        'RepRek
        '
        Me.RepRek.AutoHeight = False
        Me.RepRek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepRek.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama")})
        Me.RepRek.Name = "RepRek"
        '
        'nilai
        '
        Me.nilai.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nilai.AppearanceHeader.Options.UseFont = True
        Me.nilai.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nilai.Caption = "Nilai"
        Me.nilai.FieldName = "nilai"
        Me.nilai.Name = "nilai"
        Me.nilai.Visible = True
        Me.nilai.VisibleIndex = 2
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 34)
        Me.Panel1.TabIndex = 5
        '
        'frmzMonProdBOM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 655)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmzMonProdBOM1"
        Me.Text = "frmzMonProdBOM1"
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepRek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TREE As DevExpress.XtraTreeList.TreeList
    Friend WithEvents component_name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents jumlah As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNama_Barang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents hpp As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_bom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_rek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bom_code As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents assembly_code As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepRek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents satuan As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
