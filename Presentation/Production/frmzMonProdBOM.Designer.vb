<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmzMonProdBOM
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
        Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmzMonProdBOM))
        Me.pnl = New System.Windows.Forms.Panel
        Me.TREE = New DevExpress.XtraTreeList.TreeList
        Me.colCompCode = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colCompName = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colJumlah = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.ColSatuan = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colID = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colParent = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNama_Barang = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_edit = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.TREE)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(760, 488)
        Me.pnl.TabIndex = 1
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
        Me.TREE.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCompCode, Me.colCompName, Me.colJumlah, Me.ColSatuan, Me.colID, Me.colParent})
        Me.TREE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TREE.DragExpandDelay = 500
        Me.TREE.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Expression = "[call_form]='' or [call_form] is null"
        StyleFormatCondition2.Value1 = ""
        Me.TREE.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition2})
        Me.TREE.ImageIndexFieldName = ""
        Me.TREE.Location = New System.Drawing.Point(0, 68)
        Me.TREE.LookAndFeel.SkinName = "The Asphalt World"
        Me.TREE.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TREE.Name = "TREE"
        Me.TREE.OptionsBehavior.AutoFocusNewNode = True
        Me.TREE.OptionsBehavior.AutoMoveRowFocus = True
        Me.TREE.OptionsBehavior.DragNodes = True
        Me.TREE.OptionsBehavior.EnterMovesNextColumn = True
        Me.TREE.OptionsBehavior.ResizeNodes = False
        Me.TREE.OptionsBehavior.UseTabKey = True
        Me.TREE.OptionsLayout.AddNewColumns = False
        Me.TREE.OptionsView.AutoCalcPreviewLineCount = True
        Me.TREE.OptionsView.EnableAppearanceEvenRow = True
        Me.TREE.OptionsView.EnableAppearanceOddRow = True
        Me.TREE.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.TREE.RootValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TREE.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
        Me.TREE.Size = New System.Drawing.Size(760, 420)
        Me.TREE.TabIndex = 7
        Me.TREE.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark
        '
        'colCompCode
        '
        Me.colCompCode.Caption = "Component Code"
        Me.colCompCode.FieldName = "component_code"
        Me.colCompCode.Name = "colCompCode"
        '
        'colCompName
        '
        Me.colCompName.Caption = "Nama Barang"
        Me.colCompName.FieldName = "component_name"
        Me.colCompName.Name = "colCompName"
        Me.colCompName.OptionsColumn.AllowEdit = False
        Me.colCompName.Visible = True
        Me.colCompName.VisibleIndex = 0
        Me.colCompName.Width = 444
        '
        'colJumlah
        '
        Me.colJumlah.Caption = "Jumlah"
        Me.colJumlah.FieldName = "jumlah"
        Me.colJumlah.Format.FormatString = "N3"
        Me.colJumlah.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.OptionsColumn.AllowEdit = False
        Me.colJumlah.Visible = True
        Me.colJumlah.VisibleIndex = 1
        Me.colJumlah.Width = 73
        '
        'ColSatuan
        '
        Me.ColSatuan.Caption = "Satuan"
        Me.ColSatuan.FieldName = "satuan"
        Me.ColSatuan.Name = "ColSatuan"
        Me.ColSatuan.OptionsColumn.AllowEdit = False
        Me.ColSatuan.Visible = True
        Me.ColSatuan.VisibleIndex = 2
        Me.ColSatuan.Width = 74
        '
        'colID
        '
        Me.colID.Caption = "iditem"
        Me.colID.FieldName = "iditem"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 3
        Me.colID.Width = 74
        '
        'colParent
        '
        Me.colParent.Caption = "idparent"
        Me.colParent.FieldName = "idparent"
        Me.colParent.Name = "colParent"
        Me.colParent.OptionsColumn.AllowEdit = False
        Me.colParent.OptionsColumn.ReadOnly = True
        Me.colParent.Visible = True
        Me.colParent.VisibleIndex = 4
        Me.colParent.Width = 74
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
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
        Me.Panel1.Size = New System.Drawing.Size(760, 34)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_edit)
        Me.Panel3.Controls.Add(Me.btnLoad)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(537, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 34)
        Me.Panel3.TabIndex = 7
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(6, 4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 27)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "&Refresh"
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
        'txtNama_Barang
        '
        Me.txtNama_Barang.Location = New System.Drawing.Point(0, 7)
        Me.txtNama_Barang.Name = "txtNama_Barang"
        Me.txtNama_Barang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNama_Barang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bom_code", "Kode Barang", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bom_name", "Nama Barang")})
        Me.txtNama_Barang.Properties.NullText = "[Pilih Barang]"
        Me.txtNama_Barang.Size = New System.Drawing.Size(346, 20)
        Me.txtNama_Barang.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(569, 34)
        Me.Panel7.TabIndex = 5
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
        Me.pnlTitle.Size = New System.Drawing.Size(760, 34)
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
        Me.lblTitle.Text = "MONITORING BOM PRODUKSI"
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
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(90, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(81, 27)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "&Edit BOM"
        '
        'frmzMonProdBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmzMonProdBOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmzMonProdBOM"
        Me.pnl.ResumeLayout(False)
        CType(Me.TREE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNama_Barang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TREE As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colCompName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colJumlah As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colParent As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ColSatuan As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colCompCode As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.SimpleButton
End Class
