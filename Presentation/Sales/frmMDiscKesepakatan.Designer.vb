<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDiscKesepakatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDiscKesepakatan))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMDiscReg = New DevExpress.XtraGrid.GridControl
        Me.GvMDiscReg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Diskon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Diskon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Diskon5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepCekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.KD_MERK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KD_CUSTOMER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Start_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.End_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KD_JENIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnBuku = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.pnl.SuspendLayout()
        CType(Me.GcMDiscReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMDiscReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMDiscReg)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 377)
        Me.pnl.TabIndex = 0
        '
        'GcMDiscReg
        '
        Me.GcMDiscReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMDiscReg.Location = New System.Drawing.Point(0, 34)
        Me.GcMDiscReg.MainView = Me.GvMDiscReg
        Me.GcMDiscReg.Name = "GcMDiscReg"
        Me.GcMDiscReg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCekStat, Me.repMerk, Me.repCust, Me.repDate, Me.repNum, Me.repTipe, Me.repukuran, Me.repJenis})
        Me.GcMDiscReg.Size = New System.Drawing.Size(1004, 343)
        Me.GcMDiscReg.TabIndex = 133
        Me.GcMDiscReg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMDiscReg})
        '
        'GvMDiscReg
        '
        Me.GvMDiscReg.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvMDiscReg.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvMDiscReg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Diskon, Me.Keterangan, Me.Diskon1, Me.Diskon2, Me.Diskon3, Me.Diskon4, Me.Diskon5, Me.Rec_stat, Me.KD_MERK, Me.KD_CUSTOMER, Me.Start_Date, Me.End_Date, Me.Kode_Tipe, Me.Ukuran, Me.KD_JENIS})
        Me.GvMDiscReg.GridControl = Me.GcMDiscReg
        Me.GvMDiscReg.Name = "GvMDiscReg"
        Me.GvMDiscReg.OptionsCustomization.AllowColumnMoving = False
        Me.GvMDiscReg.OptionsSelection.MultiSelect = True
        Me.GvMDiscReg.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMDiscReg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvMDiscReg.OptionsView.ShowGroupedColumns = True
        Me.GvMDiscReg.OptionsView.ShowGroupPanel = False
        Me.GvMDiscReg.OptionsView.ShowHorzLines = False
        '
        'Kd_Diskon
        '
        Me.Kd_Diskon.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Kd_Diskon.AppearanceCell.Options.UseBackColor = True
        Me.Kd_Diskon.Caption = "Kode Diskon"
        Me.Kd_Diskon.FieldName = "Kd_Diskon"
        Me.Kd_Diskon.Name = "Kd_Diskon"
        Me.Kd_Diskon.OptionsColumn.AllowEdit = False
        Me.Kd_Diskon.OptionsColumn.AllowFocus = False
        Me.Kd_Diskon.Visible = True
        Me.Kd_Diskon.VisibleIndex = 5
        Me.Kd_Diskon.Width = 72
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Width = 105
        '
        'Diskon1
        '
        Me.Diskon1.Caption = "Diskon 1"
        Me.Diskon1.ColumnEdit = Me.repNum
        Me.Diskon1.DisplayFormat.FormatString = "n0"
        Me.Diskon1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Diskon1.FieldName = "Diskon1"
        Me.Diskon1.Name = "Diskon1"
        Me.Diskon1.Visible = True
        Me.Diskon1.VisibleIndex = 8
        Me.Diskon1.Width = 50
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repNum.DisplayFormat.FormatString = "n0"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.EditFormat.FormatString = "n0"
        Me.repNum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'Diskon2
        '
        Me.Diskon2.Caption = "Diskon 2"
        Me.Diskon2.ColumnEdit = Me.repNum
        Me.Diskon2.DisplayFormat.FormatString = "n0"
        Me.Diskon2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Diskon2.FieldName = "Diskon2"
        Me.Diskon2.Name = "Diskon2"
        Me.Diskon2.Visible = True
        Me.Diskon2.VisibleIndex = 9
        Me.Diskon2.Width = 53
        '
        'Diskon3
        '
        Me.Diskon3.Caption = "Diskon 3"
        Me.Diskon3.ColumnEdit = Me.repNum
        Me.Diskon3.DisplayFormat.FormatString = "n0"
        Me.Diskon3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Diskon3.FieldName = "Diskon3"
        Me.Diskon3.Name = "Diskon3"
        Me.Diskon3.Visible = True
        Me.Diskon3.VisibleIndex = 10
        Me.Diskon3.Width = 56
        '
        'Diskon4
        '
        Me.Diskon4.Caption = "Diskon 4"
        Me.Diskon4.ColumnEdit = Me.repNum
        Me.Diskon4.DisplayFormat.FormatString = "n0"
        Me.Diskon4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Diskon4.FieldName = "Diskon4"
        Me.Diskon4.Name = "Diskon4"
        Me.Diskon4.Visible = True
        Me.Diskon4.VisibleIndex = 11
        Me.Diskon4.Width = 63
        '
        'Diskon5
        '
        Me.Diskon5.Caption = "Diskon 5"
        Me.Diskon5.ColumnEdit = Me.repNum
        Me.Diskon5.DisplayFormat.FormatString = "n0"
        Me.Diskon5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Diskon5.FieldName = "Diskon5"
        Me.Diskon5.Name = "Diskon5"
        Me.Diskon5.Visible = True
        Me.Diskon5.VisibleIndex = 12
        Me.Diskon5.Width = 54
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.RepCekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 13
        Me.Rec_stat.Width = 52
        '
        'RepCekStat
        '
        Me.RepCekStat.AutoWidth = True
        Me.RepCekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepCekStat.Caption = "NonAKTIF"
        Me.RepCekStat.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepCekStat.DisplayValueChecked = "AKTIF"
        Me.RepCekStat.DisplayValueUnchecked = "Non AKTIF"
        Me.RepCekStat.FullFocusRect = True
        Me.RepCekStat.Name = "RepCekStat"
        Me.RepCekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepCekStat.ValueChecked = "Y"
        Me.RepCekStat.ValueUnchecked = "T"
        '
        'KD_MERK
        '
        Me.KD_MERK.Caption = "Merk"
        Me.KD_MERK.ColumnEdit = Me.repMerk
        Me.KD_MERK.FieldName = "KD_MERK"
        Me.KD_MERK.Name = "KD_MERK"
        Me.KD_MERK.Visible = True
        Me.KD_MERK.VisibleIndex = 2
        Me.KD_MERK.Width = 79
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama_Merk")})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.NullText = ""
        Me.repMerk.PopupFormMinSize = New System.Drawing.Size(150, 300)
        Me.repMerk.PopupWidth = 200
        Me.repMerk.ValueMember = "Kode_Merk"
        '
        'KD_CUSTOMER
        '
        Me.KD_CUSTOMER.Caption = "Customer"
        Me.KD_CUSTOMER.ColumnEdit = Me.repCust
        Me.KD_CUSTOMER.FieldName = "Kd_Customer"
        Me.KD_CUSTOMER.Name = "KD_CUSTOMER"
        Me.KD_CUSTOMER.Visible = True
        Me.KD_CUSTOMER.VisibleIndex = 0
        Me.KD_CUSTOMER.Width = 129
        '
        'repCust
        '
        Me.repCust.AutoHeight = False
        Me.repCust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCust.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 190, "Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 60, "Kode")})
        Me.repCust.DisplayMember = "Nama_Customer"
        Me.repCust.Name = "repCust"
        Me.repCust.NullText = ""
        Me.repCust.PopupFormMinSize = New System.Drawing.Size(250, 300)
        Me.repCust.PopupWidth = 250
        Me.repCust.ValueMember = "Kd_Customer"
        '
        'Start_Date
        '
        Me.Start_Date.Caption = "Tgl Mulai"
        Me.Start_Date.ColumnEdit = Me.repDate
        Me.Start_Date.FieldName = "Start_Date"
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Visible = True
        Me.Start_Date.VisibleIndex = 6
        Me.Start_Date.Width = 64
        '
        'repDate
        '
        Me.repDate.AutoHeight = False
        Me.repDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDate.Name = "repDate"
        Me.repDate.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'End_Date
        '
        Me.End_Date.Caption = "Tgl Sampai"
        Me.End_Date.ColumnEdit = Me.repDate
        Me.End_Date.FieldName = "End_Date"
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Visible = True
        Me.End_Date.VisibleIndex = 7
        Me.End_Date.Width = 64
        '
        'Kode_Tipe
        '
        Me.Kode_Tipe.Caption = "Tipe"
        Me.Kode_Tipe.ColumnEdit = Me.repTipe
        Me.Kode_Tipe.FieldName = "Kode_Tipe"
        Me.Kode_Tipe.Name = "Kode_Tipe"
        Me.Kode_Tipe.Visible = True
        Me.Kode_Tipe.VisibleIndex = 3
        Me.Kode_Tipe.Width = 104
        '
        'repTipe
        '
        Me.repTipe.AutoHeight = False
        Me.repTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Tipe")})
        Me.repTipe.DisplayMember = "Nama_Tipe"
        Me.repTipe.Name = "repTipe"
        Me.repTipe.NullText = ""
        Me.repTipe.ValueMember = "Kode_Tipe"
        '
        'Ukuran
        '
        Me.Ukuran.Caption = "Ukuran"
        Me.Ukuran.ColumnEdit = Me.repukuran
        Me.Ukuran.FieldName = "Kode_Ukuran"
        Me.Ukuran.Name = "Ukuran"
        Me.Ukuran.Visible = True
        Me.Ukuran.VisibleIndex = 4
        Me.Ukuran.Width = 71
        '
        'repukuran
        '
        Me.repukuran.AutoHeight = False
        Me.repukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Ukuran")})
        Me.repukuran.DisplayMember = "Nama_Ukuran"
        Me.repukuran.Name = "repukuran"
        Me.repukuran.NullText = ""
        Me.repukuran.ValueMember = "Kode_Ukuran"
        '
        'KD_JENIS
        '
        Me.KD_JENIS.Caption = "Jenis"
        Me.KD_JENIS.ColumnEdit = Me.repJenis
        Me.KD_JENIS.FieldName = "KD_JENIS"
        Me.KD_JENIS.Name = "KD_JENIS"
        Me.KD_JENIS.Visible = True
        Me.KD_JENIS.VisibleIndex = 1
        Me.KD_JENIS.Width = 72
        '
        'repJenis
        '
        Me.repJenis.AutoHeight = False
        Me.repJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", 150, "Jenis")})
        Me.repJenis.DisplayMember = "Nama_Jenis"
        Me.repJenis.Name = "repJenis"
        Me.repJenis.NullText = ""
        Me.repJenis.ValueMember = "Kd_Jns_Brg"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBuku)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 131
        '
        'btnBuku
        '
        Me.btnBuku.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Appearance.Options.UseFont = True
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuku.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuku.Image = CType(resources.GetObject("btnBuku.Image"), System.Drawing.Image)
        Me.btnBuku.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuku.Location = New System.Drawing.Point(964, 0)
        Me.btnBuku.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnBuku.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(38, 32)
        Me.btnBuku.TabIndex = 12
        Me.btnBuku.Tag = "Tutup"
        Me.btnBuku.ToolTip = "Copy-Paste From Selected Grid"
        Me.btnBuku.ToolTipTitle = "Duplicate"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " DISKON CUSTOMER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 132
        Me.Panel2.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(440, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(359, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmMDiscKesepakatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 377)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMDiscKesepakatan"
        Me.Text = "frmMstDiscReguler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMDiscReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMDiscReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDate.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GcMDiscReg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMDiscReg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Diskon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diskon5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepCekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents KD_MERK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KD_CUSTOMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Start_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents End_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Kode_Tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBuku As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KD_JENIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
