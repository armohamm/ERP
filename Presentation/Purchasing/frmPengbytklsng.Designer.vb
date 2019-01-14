<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengbytklsng
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPengbytklsng))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.txtJmlTotal = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSeq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbkbsr = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_pusat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbkpusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gcketerangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtnama = New DevExpress.XtraEditors.TextEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Pnl.SuspendLayout()
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbkbsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbkpusat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.txtJmlTotal)
        Me.Pnl.Controls.Add(Me.Label4)
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(1048, 467)
        Me.Pnl.TabIndex = 5
        '
        'txtJmlTotal
        '
        Me.txtJmlTotal.EditValue = 0
        Me.txtJmlTotal.Location = New System.Drawing.Point(855, 393)
        Me.txtJmlTotal.Name = "txtJmlTotal"
        Me.txtJmlTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtJmlTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtJmlTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtJmlTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseFont = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtJmlTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJmlTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJmlTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJmlTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlTotal.Properties.ReadOnly = True
        Me.txtJmlTotal.Size = New System.Drawing.Size(190, 21)
        Me.txtJmlTotal.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-31, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(880, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GC
        '
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 118)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbkbsr, Me.repbkpusat})
        Me.GC.Size = New System.Drawing.Size(1048, 269)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.Appearance.FooterPanel.Options.UseFont = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSeq, Me.Kd_buku_besar, Me.kd_buku_pusat, Me.gcketerangan, Me.jumlah})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsMenu.EnableColumnMenu = False
        Me.GV.OptionsMenu.EnableFooterMenu = False
        Me.GV.OptionsMenu.EnableGroupPanelMenu = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'NoSeq
        '
        Me.NoSeq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoSeq.AppearanceCell.Options.UseFont = True
        Me.NoSeq.AppearanceCell.Options.UseTextOptions = True
        Me.NoSeq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoSeq.AppearanceHeader.Options.UseTextOptions = True
        Me.NoSeq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoSeq.Caption = "No"
        Me.NoSeq.FieldName = "no_seq"
        Me.NoSeq.Name = "NoSeq"
        Me.NoSeq.OptionsColumn.AllowEdit = False
        Me.NoSeq.OptionsColumn.AllowFocus = False
        Me.NoSeq.Visible = True
        Me.NoSeq.VisibleIndex = 0
        Me.NoSeq.Width = 56
        '
        'Kd_buku_besar
        '
        Me.Kd_buku_besar.Caption = "Rekening"
        Me.Kd_buku_besar.ColumnEdit = Me.repbkbsr
        Me.Kd_buku_besar.FieldName = "rekening"
        Me.Kd_buku_besar.Name = "Kd_buku_besar"
        Me.Kd_buku_besar.Visible = True
        Me.Kd_buku_besar.VisibleIndex = 1
        Me.Kd_buku_besar.Width = 326
        '
        'repbkbsr
        '
        Me.repbkbsr.Appearance.Image = CType(resources.GetObject("repbkbsr.Appearance.Image"), System.Drawing.Image)
        Me.repbkbsr.Appearance.Options.UseImage = True
        Me.repbkbsr.AutoHeight = False
        Me.repbkbsr.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbkbsr.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", 130, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", 300, "Rekening")})
        Me.repbkbsr.DisplayMember = "nm_buku_besar"
        Me.repbkbsr.DropDownRows = 15
        Me.repbkbsr.HideSelection = False
        Me.repbkbsr.Name = "repbkbsr"
        Me.repbkbsr.NullText = "[Rekening]"
        Me.repbkbsr.PopupWidth = 700
        Me.repbkbsr.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repbkbsr.ValueMember = "kd_buku_besar"
        '
        'kd_buku_pusat
        '
        Me.kd_buku_pusat.Caption = "Pusat Biaya"
        Me.kd_buku_pusat.ColumnEdit = Me.repbkpusat
        Me.kd_buku_pusat.FieldName = "pusat_biaya"
        Me.kd_buku_pusat.Name = "kd_buku_pusat"
        Me.kd_buku_pusat.Visible = True
        Me.kd_buku_pusat.VisibleIndex = 2
        Me.kd_buku_pusat.Width = 323
        '
        'repbkpusat
        '
        Me.repbkpusat.AutoHeight = False
        Me.repbkpusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbkpusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", 130, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", 300, "Pusat Biaya")})
        Me.repbkpusat.DisplayMember = "nm_buku_pusat"
        Me.repbkpusat.DropDownRows = 15
        Me.repbkpusat.Name = "repbkpusat"
        Me.repbkpusat.NullText = "[Pusat Biaya]"
        Me.repbkpusat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repbkpusat.ValueMember = "kd_buku_pusat"
        '
        'gcketerangan
        '
        Me.gcketerangan.Caption = "Keterangan"
        Me.gcketerangan.FieldName = "keterangan"
        Me.gcketerangan.Name = "gcketerangan"
        Me.gcketerangan.Visible = True
        Me.gcketerangan.VisibleIndex = 3
        Me.gcketerangan.Width = 206
        '
        'jumlah
        '
        Me.jumlah.Caption = "Jumlah"
        Me.jumlah.FieldName = "jml_trans"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 4
        Me.jumlah.Width = 116
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1048, 81)
        Me.pnlTengahAtas.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtnama)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(796, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 79)
        Me.Panel3.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtnama.Location = New System.Drawing.Point(0, 0)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtnama.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtnama.Properties.Appearance.Options.UseBackColor = True
        Me.txtnama.Properties.Appearance.Options.UseForeColor = True
        Me.txtnama.Size = New System.Drawing.Size(250, 20)
        Me.txtnama.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(383, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 79)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pemohon :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dtTanggal)
        Me.Panel5.Controls.Add(Me.txtKeterangan)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 79)
        Me.Panel5.TabIndex = 3
        '
        'dtTanggal
        '
        Me.dtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtTanggal.EditValue = New Date(2011, 4, 29, 16, 0, 22, 75)
        Me.dtTanggal.Location = New System.Drawing.Point(0, 20)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtTanggal.Size = New System.Drawing.Size(241, 20)
        Me.dtTanggal.TabIndex = 13
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 40)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(241, 39)
        Me.txtKeterangan.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtNomor)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(241, 20)
        Me.Panel6.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseForeColor = True
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(241, 20)
        Me.txtNomor.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 79)
        Me.Panel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keterangan :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nomor :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 37)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM PENGAJUAN BIAYA TAK LANGSUNG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'frmPengbytklsng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 557)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmPengbytklsng"
        Me.Text = "FORM PENGAJUAN BIAYA TAK LANGSUNG"
        Me.Pnl.ResumeLayout(False)
        CType(Me.txtJmlTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbkbsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbkpusat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repbkbsr As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_buku_pusat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spec_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents repbkpusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJmlTotal As DevExpress.XtraEditors.TextEdit
End Class
