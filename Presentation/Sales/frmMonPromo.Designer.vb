<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonPromo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonPromo))
        Me.GVG = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.Customer2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repCust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.Customer = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlLoad = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.cmdCustomr = New DevExpress.XtraEditors.LookUpEdit
        Me.txtsampai = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDari = New DevExpress.XtraEditors.TextEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtPromo = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtKodePromo = New DevExpress.XtraEditors.TextEdit
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlLoad.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.cmdCustomr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtPromo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtKodePromo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVG
        '
        Me.GVG.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Customer2})
        Me.GVG.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn2})
        Me.GVG.GridControl = Me.GC
        Me.GVG.Name = "GVG"
        Me.GVG.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVG.OptionsBehavior.Editable = False
        Me.GVG.OptionsCustomization.AllowColumnMoving = False
        Me.GVG.OptionsCustomization.AllowFilter = False
        Me.GVG.OptionsCustomization.AllowGroup = False
        Me.GVG.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVG.OptionsCustomization.AllowRowSizing = True
        Me.GVG.OptionsCustomization.AllowSort = False
        Me.GVG.OptionsView.ShowGroupPanel = False
        '
        'Customer2
        '
        Me.Customer2.Caption = "Customer"
        Me.Customer2.Columns.Add(Me.BandedGridColumn2)
        Me.Customer2.Name = "Customer2"
        Me.Customer2.Width = 183
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = " "
        Me.BandedGridColumn2.ColumnEdit = Me.repCust
        Me.BandedGridColumn2.FieldName = "kd_customer"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 183
        '
        'repCust
        '
        Me.repCust.AutoHeight = False
        Me.repCust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCust.DisplayMember = "Nama_Customer"
        Me.repCust.Name = "repCust"
        Me.repCust.ValueMember = "Kd_Customer"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVG
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 100)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCust})
        Me.GC.Size = New System.Drawing.Size(926, 388)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVG})
        '
        'GV
        '
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Customer})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn1})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsView.AllowHtmlDrawHeaders = True
        Me.GV.OptionsView.ColumnAutoWidth = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Customer
        '
        Me.Customer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer.AppearanceHeader.Options.UseFont = True
        Me.Customer.Caption = "Customer"
        Me.Customer.Columns.Add(Me.BandedGridColumn1)
        Me.Customer.Name = "Customer"
        Me.Customer.Width = 142
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = " "
        Me.BandedGridColumn1.ColumnEdit = Me.repCust
        Me.BandedGridColumn1.FieldName = "kd_customer"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 142
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlLoad)
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(928, 490)
        Me.pnl.TabIndex = 0
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoad.Border = True
        Me.pnlLoad.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlLoad.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlLoad.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLoad.Controls.Add(Me.PictureBox2)
        Me.pnlLoad.Controls.Add(Me.Label4)
        Me.pnlLoad.CornerRadius = 20
        Me.pnlLoad.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlLoad.Gradient = True
        Me.pnlLoad.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlLoad.GradientOffset = 1.0!
        Me.pnlLoad.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLoad.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLoad.Grayscale = False
        Me.pnlLoad.Image = Nothing
        Me.pnlLoad.ImageAlpha = 75
        Me.pnlLoad.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlLoad.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlLoad.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLoad.Location = New System.Drawing.Point(293, 204)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Rounded = True
        Me.pnlLoad.Size = New System.Drawing.Size(380, 108)
        Me.pnlLoad.TabIndex = 8
        Me.pnlLoad.Visible = False
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlLoad
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha3.Parent = Me.pnlLoad
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlLoad
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Please Wait...."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(926, 63)
        Me.Panel3.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(471, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(76, 63)
        Me.btnRefresh.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.txtsampai)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtDari)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(132, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(339, 63)
        Me.Panel5.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.cmdCustomr)
        Me.Panel8.Location = New System.Drawing.Point(0, 42)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(339, 21)
        Me.Panel8.TabIndex = 9
        '
        'cmdCustomr
        '
        Me.cmdCustomr.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdCustomr.Location = New System.Drawing.Point(0, 0)
        Me.cmdCustomr.Name = "cmdCustomr"
        Me.cmdCustomr.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdCustomr.Properties.Appearance.Options.UseBackColor = True
        Me.cmdCustomr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdCustomr.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Customer")})
        Me.cmdCustomr.Properties.DisplayMember = "Nama_Customer"
        Me.cmdCustomr.Properties.DropDownRows = 15
        Me.cmdCustomr.Properties.HideSelection = False
        Me.cmdCustomr.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdCustomr.Properties.NullText = ""
        Me.cmdCustomr.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.cmdCustomr.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.cmdCustomr.Properties.PopupWidth = 400
        Me.cmdCustomr.Properties.ShowHeader = False
        Me.cmdCustomr.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.cmdCustomr.Properties.ValueMember = "Kd_Customer"
        Me.cmdCustomr.Size = New System.Drawing.Size(336, 20)
        Me.cmdCustomr.TabIndex = 3
        '
        'txtsampai
        '
        Me.txtsampai.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtsampai.EnterMoveNextControl = True
        Me.txtsampai.Location = New System.Drawing.Point(187, 21)
        Me.txtsampai.Name = "txtsampai"
        Me.txtsampai.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsampai.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtsampai.Properties.Appearance.Options.UseBackColor = True
        Me.txtsampai.Properties.Appearance.Options.UseFont = True
        Me.txtsampai.Properties.Appearance.Options.UseForeColor = True
        Me.txtsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtsampai.Properties.ReadOnly = True
        Me.txtsampai.Size = New System.Drawing.Size(149, 20)
        Me.txtsampai.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "  -  "
        '
        'txtDari
        '
        Me.txtDari.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtDari.EnterMoveNextControl = True
        Me.txtDari.Location = New System.Drawing.Point(0, 21)
        Me.txtDari.Name = "txtDari"
        Me.txtDari.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDari.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtDari.Properties.Appearance.Options.UseBackColor = True
        Me.txtDari.Properties.Appearance.Options.UseFont = True
        Me.txtDari.Properties.Appearance.Options.UseForeColor = True
        Me.txtDari.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDari.Properties.ReadOnly = True
        Me.txtDari.Size = New System.Drawing.Size(151, 20)
        Me.txtDari.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtPromo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(339, 21)
        Me.Panel6.TabIndex = 0
        '
        'txtPromo
        '
        Me.txtPromo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtPromo.Location = New System.Drawing.Point(0, 0)
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPromo.Properties.Appearance.Options.UseBackColor = True
        Me.txtPromo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPromo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_promo", "nama_promo", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Jenis_Omzet", "", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
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
        Me.txtPromo.Size = New System.Drawing.Size(336, 20)
        Me.txtPromo.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(132, 63)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Customer : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel2.Controls.Add(Me.txtKodePromo)
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 37)
        Me.Panel2.TabIndex = 3
        '
        'txtKodePromo
        '
        Me.txtKodePromo.EnterMoveNextControl = True
        Me.txtKodePromo.Location = New System.Drawing.Point(769, 10)
        Me.txtKodePromo.Name = "txtKodePromo"
        Me.txtKodePromo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodePromo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKodePromo.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodePromo.Properties.Appearance.Options.UseForeColor = True
        Me.txtKodePromo.Properties.ReadOnly = True
        Me.txtKodePromo.Size = New System.Drawing.Size(96, 20)
        Me.txtKodePromo.TabIndex = 5
        Me.txtKodePromo.Visible = False
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(470, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM MONITORING PROMO"
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
        'frmMonPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 490)
        Me.Controls.Add(Me.pnl)
        Me.DoubleBuffered = True
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmMonPromo"
        CType(Me.GVG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlLoad.ResumeLayout(False)
        Me.pnlLoad.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.cmdCustomr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtPromo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtKodePromo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtsampai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtPromo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmdCustomr As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Customer As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents repCust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlLoad As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKodePromo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents GVG As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Customer2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
