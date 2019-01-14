<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonKetepatanKirim
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonKetepatanKirim))
        Me.JanjiKirimSP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JanjiKirimPPC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Nomor_SP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TglTerima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Deskripsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.filter = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmbDivisi = New DevExpress.XtraEditors.LookUpEdit
        Me.tglSampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbljudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JanjiKirimSP
        '
        Me.JanjiKirimSP.Caption = "Janji Kirim SP"
        Me.JanjiKirimSP.FieldName = "TGL_KIRIM_MARKETING"
        Me.JanjiKirimSP.Name = "JanjiKirimSP"
        Me.JanjiKirimSP.Visible = True
        Me.JanjiKirimSP.VisibleIndex = 3
        Me.JanjiKirimSP.Width = 104
        '
        'JanjiKirimPPC
        '
        Me.JanjiKirimPPC.Caption = "Janji Kirim PPC"
        Me.JanjiKirimPPC.FieldName = "TGL_KIRIM_PPC"
        Me.JanjiKirimPPC.Name = "JanjiKirimPPC"
        Me.JanjiKirimPPC.Visible = True
        Me.JanjiKirimPPC.VisibleIndex = 4
        Me.JanjiKirimPPC.Width = 104
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 97)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCustomer})
        Me.GC.Size = New System.Drawing.Size(866, 274)
        Me.GC.TabIndex = 5
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Customer, Me.Nomor_SP, Me.JanjiKirimSP, Me.JanjiKirimPPC, Me.TglTerima, Me.Deskripsi})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.JanjiKirimSP
        StyleFormatCondition1.Expression = "[TGL_KIRIM_MARKETING]  >= [Tgl_terima]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Expression = "[No_sp] < [Tgl_terima]"
        StyleFormatCondition3.Appearance.BorderColor = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green
        StyleFormatCondition3.Appearance.Options.UseBorderColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.JanjiKirimPPC
        StyleFormatCondition3.Expression = "[TGL_KIRIM_PPC] >= [Tgl_terima]"
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.Column = Me.JanjiKirimPPC
        StyleFormatCondition4.Expression = "[TGL_KIRIM_PPC] < [Tgl_terima]"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.AllowCellMerge = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Customer
        '
        Me.Customer.Caption = "Customer"
        Me.Customer.ColumnEdit = Me.repCustomer
        Me.Customer.FieldName = "Kd_Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
        Me.Customer.Visible = True
        Me.Customer.VisibleIndex = 0
        Me.Customer.Width = 241
        '
        'repCustomer
        '
        Me.repCustomer.AutoHeight = False
        Me.repCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Name1")})
        Me.repCustomer.DisplayMember = "Nama_Customer"
        Me.repCustomer.Name = "repCustomer"
        Me.repCustomer.NullText = ""
        Me.repCustomer.ValueMember = "Kd_Customer"
        '
        'Nomor_SP
        '
        Me.Nomor_SP.Caption = "Nomor SP"
        Me.Nomor_SP.FieldName = "No_sp"
        Me.Nomor_SP.Name = "Nomor_SP"
        Me.Nomor_SP.Visible = True
        Me.Nomor_SP.VisibleIndex = 1
        Me.Nomor_SP.Width = 119
        '
        'TglTerima
        '
        Me.TglTerima.Caption = "Tgl Diterima"
        Me.TglTerima.FieldName = "Tgl_terima"
        Me.TglTerima.Name = "TglTerima"
        Me.TglTerima.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.TglTerima.Visible = True
        Me.TglTerima.VisibleIndex = 5
        Me.TglTerima.Width = 110
        '
        'Deskripsi
        '
        Me.Deskripsi.Caption = "Deskripsi"
        Me.Deskripsi.FieldName = "Deskripsi"
        Me.Deskripsi.Name = "Deskripsi"
        Me.Deskripsi.Visible = True
        Me.Deskripsi.VisibleIndex = 2
        Me.Deskripsi.Width = 167
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(866, 371)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.filter)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 60)
        Me.Panel2.TabIndex = 4
        '
        'filter
        '
        Me.filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.filter.Image = CType(resources.GetObject("filter.Image"), System.Drawing.Image)
        Me.filter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.filter.Location = New System.Drawing.Point(446, 15)
        Me.filter.LookAndFeel.SkinName = "The Asphalt World"
        Me.filter.LookAndFeel.UseDefaultLookAndFeel = False
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(55, 42)
        Me.filter.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cmbDivisi)
        Me.Panel4.Controls.Add(Me.tglSampai)
        Me.Panel4.Controls.Add(Me.tglDari)
        Me.Panel4.Controls.Add(Me.txtCustomer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(160, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 60)
        Me.Panel4.TabIndex = 1
        '
        'cmbDivisi
        '
        Me.cmbDivisi.Location = New System.Drawing.Point(0, 38)
        Me.cmbDivisi.Name = "cmbDivisi"
        Me.cmbDivisi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.Appearance.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmbDivisi.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivisi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmbDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Divisi", 150, "Nama")})
        Me.cmbDivisi.Properties.DisplayMember = "Nama_Divisi"
        Me.cmbDivisi.Properties.HideSelection = False
        Me.cmbDivisi.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbDivisi.Properties.NullText = ""
        Me.cmbDivisi.Properties.PopupWidth = 300
        Me.cmbDivisi.Properties.ShowHeader = False
        Me.cmbDivisi.Properties.ValueMember = "Kode_Divisi"
        Me.cmbDivisi.Size = New System.Drawing.Size(280, 20)
        Me.cmbDivisi.TabIndex = 32
        '
        'tglSampai
        '
        Me.tglSampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tglSampai.EditValue = Nothing
        Me.tglSampai.Location = New System.Drawing.Point(143, 20)
        Me.tglSampai.Name = "tglSampai"
        Me.tglSampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSampai.Properties.Appearance.Options.UseFont = True
        Me.tglSampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglSampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglSampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglSampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglSampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglSampai.Size = New System.Drawing.Size(137, 20)
        Me.tglSampai.TabIndex = 30
        '
        'tglDari
        '
        Me.tglDari.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(0, 20)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(143, 20)
        Me.tglDari.TabIndex = 29
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 150, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 200, "Alamat")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.DropDownRows = 15
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(280, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 60)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Divisi :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tanggal Order :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbljudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 37)
        Me.Panel1.TabIndex = 3
        '
        'lbljudul
        '
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.Gold
        Me.lbljudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbljudul.Location = New System.Drawing.Point(38, 0)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(508, 35)
        Me.lbljudul.TabIndex = 9
        Me.lbljudul.Text = "MONITORING KETEPATAN PENGIRIMAN"
        Me.lbljudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMonKetepatanKirim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 371)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonKetepatanKirim"
        Me.Text = "frmMonKetepatanKirim"
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbljudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents filter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmbDivisi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tglSampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nomor_SP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JanjiKirimSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JanjiKirimPPC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TglTerima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Deskripsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
