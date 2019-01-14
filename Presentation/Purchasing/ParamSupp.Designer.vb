<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamSupp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParamSupp))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSeq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kriteria = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bobotmax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepKirim = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepKdBayar = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtNoDPM = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dttglmulai = New DevExpress.XtraEditors.DateEdit
        Me.dttglakhir = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.bobotmin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepKdBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.txtNoDPM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglmulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglmulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglakhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglakhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.SystemColors.Control
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(1048, 465)
        Me.Pnl.TabIndex = 5
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 118)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repbarang, Me.RepKirim, Me.RepKdBayar, Me.DtTanggalgrid, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemRichTextEdit1})
        Me.GC.Size = New System.Drawing.Size(1048, 347)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSeq, Me.kriteria, Me.ket, Me.nilai, Me.bobotmax, Me.bobotmin})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowColumnResizing = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
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
        Me.NoSeq.Width = 26
        '
        'repbarang
        '
        Me.repbarang.Appearance.Image = CType(resources.GetObject("repbarang.Appearance.Image"), System.Drawing.Image)
        Me.repbarang.Appearance.Options.UseImage = True
        Me.repbarang.AutoHeight = False
        Me.repbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 125, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 450, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 75, "Unit"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("spek_brg", 90, "Spek. Barang")})
        Me.repbarang.DisplayMember = "Nama_Barang"
        Me.repbarang.DropDownRows = 15
        Me.repbarang.HideSelection = False
        Me.repbarang.Name = "repbarang"
        Me.repbarang.NullText = "[Pilih Barang]"
        Me.repbarang.PopupWidth = 700
        Me.repbarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repbarang.ValueMember = "Kode_Barang"
        '
        'kriteria
        '
        Me.kriteria.Caption = "Kriteria"
        Me.kriteria.FieldName = "kriteria"
        Me.kriteria.Name = "kriteria"
        Me.kriteria.OptionsColumn.AllowEdit = False
        Me.kriteria.OptionsColumn.AllowFocus = False
        Me.kriteria.OptionsColumn.ReadOnly = True
        Me.kriteria.Visible = True
        Me.kriteria.VisibleIndex = 1
        Me.kriteria.Width = 100
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        '
        'ket
        '
        Me.ket.Caption = "Keterangan"
        Me.ket.FieldName = "keterangan"
        Me.ket.Name = "ket"
        Me.ket.Visible = True
        Me.ket.VisibleIndex = 2
        Me.ket.Width = 98
        '
        'nilai
        '
        Me.nilai.Caption = "Nilai"
        Me.nilai.FieldName = "nilai"
        Me.nilai.Name = "nilai"
        Me.nilai.Visible = True
        Me.nilai.VisibleIndex = 3
        '
        'bobotmax
        '
        Me.bobotmax.Caption = "Bobot Max(%)"
        Me.bobotmax.FieldName = "bobot_max"
        Me.bobotmax.Name = "bobotmax"
        Me.bobotmax.Visible = True
        Me.bobotmax.VisibleIndex = 4
        '
        'DtTanggalgrid
        '
        Me.DtTanggalgrid.AutoHeight = False
        Me.DtTanggalgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'RepKirim
        '
        Me.RepKirim.AutoHeight = False
        Me.RepKirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepKirim.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Deskripsi")})
        Me.RepKirim.DisplayMember = "Desc_Data"
        Me.RepKirim.Name = "RepKirim"
        Me.RepKirim.NullText = "[Kode]"
        Me.RepKirim.ValueMember = "Id_Data"
        '
        'RepKdBayar
        '
        Me.RepKdBayar.AutoHeight = False
        Me.RepKdBayar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepKdBayar.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Deskripsi")})
        Me.RepKdBayar.DisplayMember = "Desc_Data"
        Me.RepKdBayar.Name = "RepKdBayar"
        Me.RepKdBayar.NullText = "[Kode]"
        Me.RepKdBayar.ValueMember = "Id_Data"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
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
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(796, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 79)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(383, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 79)
        Me.Panel2.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dttglakhir)
        Me.Panel5.Controls.Add(Me.dttglmulai)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 79)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtNoDPM)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(241, 20)
        Me.Panel6.TabIndex = 2
        '
        'txtNoDPM
        '
        Me.txtNoDPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoDPM.Location = New System.Drawing.Point(0, 0)
        Me.txtNoDPM.Name = "txtNoDPM"
        Me.txtNoDPM.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoDPM.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNoDPM.Properties.Appearance.Options.UseBackColor = True
        Me.txtNoDPM.Properties.Appearance.Options.UseForeColor = True
        Me.txtNoDPM.Properties.ReadOnly = True
        Me.txtNoDPM.Size = New System.Drawing.Size(241, 20)
        Me.txtNoDPM.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 79)
        Me.Panel4.TabIndex = 2
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
        Me.Label5.Text = "No  :"
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
        Me.Label1.Text = " FORM PARAMATER SUPPLIER PERPORMANCE"
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dttglmulai
        '
        Me.dttglmulai.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttglmulai.EditValue = New Date(2011, 4, 29, 16, 0, 22, 75)
        Me.dttglmulai.Location = New System.Drawing.Point(0, 20)
        Me.dttglmulai.Name = "dttglmulai"
        Me.dttglmulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttglmulai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttglmulai.Size = New System.Drawing.Size(241, 20)
        Me.dttglmulai.TabIndex = 5
        '
        'dttglakhir
        '
        Me.dttglakhir.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttglakhir.EditValue = New Date(2011, 4, 29, 16, 0, 22, 75)
        Me.dttglakhir.Location = New System.Drawing.Point(0, 40)
        Me.dttglakhir.Name = "dttglakhir"
        Me.dttglakhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttglakhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttglakhir.Size = New System.Drawing.Size(241, 20)
        Me.dttglakhir.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Status :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bobotmin
        '
        Me.bobotmin.Caption = "Bobot Min(%)"
        Me.bobotmin.FieldName = "bobot_min"
        Me.bobotmin.Name = "bobotmin"
        Me.bobotmin.Visible = True
        Me.bobotmin.VisibleIndex = 5
        '
        'frmParamSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmParamSupp"
        Me.Text = " FORM PARAMATER SUPPLIER PERPORMANCE"
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepKirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepKdBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtNoDPM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglmulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglmulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglakhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglakhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtNoDPM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoSeq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kriteria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepKirim As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepKdBayar As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bobotmax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents spec_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dttglmulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dttglakhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bobotmin As DevExpress.XtraGrid.Columns.GridColumn
End Class
