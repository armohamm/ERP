<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPiutangLain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiutangLain))
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Lookrekening = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Lookkaryawan = New DevExpress.XtraEditors.LookUpEdit
        Me.btDel = New DevExpress.XtraEditors.SimpleButton
        Me.btSave = New DevExpress.XtraEditors.SimpleButton
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton
        Me.txtjml_val_trans = New DevExpress.XtraEditors.TextEdit
        Me.lookupPeg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.txtketerangan = New System.Windows.Forms.TextBox
        Me.dttgl_inv = New DevExpress.XtraEditors.DateEdit
        Me.txtno_inv = New System.Windows.Forms.TextBox
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookuprek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Lookrekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        CType(Me.Lookkaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtjml_val_trans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl12.SuspendLayout()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(288, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Jenis Piutang Lain :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(657, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "PERMOHONAN PIUTANG LAIN-LAIN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(288, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kartu :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(288, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keterangan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lookrekening
        '
        Me.Lookrekening.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lookrekening.Location = New System.Drawing.Point(0, 60)
        Me.Lookrekening.Name = "Lookrekening"
        Me.Lookrekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookrekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Rekening")})
        Me.Lookrekening.Properties.NullText = "[Klik coy]"
        Me.Lookrekening.Size = New System.Drawing.Size(424, 20)
        Me.Lookrekening.TabIndex = 3
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label5)
        Me.pnl11.Controls.Add(Me.Label4)
        Me.pnl11.Controls.Add(Me.Label3)
        Me.pnl11.Controls.Add(Me.Label1)
        Me.pnl11.Controls.Add(Me.Label2)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(288, 172)
        Me.pnl11.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(288, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(288, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(288, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lookkaryawan
        '
        Me.Lookkaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lookkaryawan.EnterMoveNextControl = True
        Me.Lookkaryawan.Location = New System.Drawing.Point(0, 40)
        Me.Lookkaryawan.Name = "Lookkaryawan"
        Me.Lookkaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookkaryawan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode")})
        Me.Lookkaryawan.Properties.NullText = "[Klik coy]"
        Me.Lookkaryawan.Size = New System.Drawing.Size(424, 20)
        Me.Lookkaryawan.TabIndex = 2
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(418, 601)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(75, 23)
        Me.btDel.TabIndex = 10
        Me.btDel.Text = "Hapus"
        Me.btDel.Visible = False
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(322, 601)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 9
        Me.btSave.Text = "Simpan"
        Me.btSave.Visible = False
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(221, 601)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 8
        Me.btEdit.Text = "Edit"
        Me.btEdit.Visible = False
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
        Me.pnlTitle.Size = New System.Drawing.Size(975, 34)
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
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(121, 601)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 7
        Me.btAdd.Text = "Baru"
        Me.btAdd.Visible = False
        '
        'txtjml_val_trans
        '
        Me.txtjml_val_trans.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtjml_val_trans.EditValue = "0"
        Me.txtjml_val_trans.EnterMoveNextControl = True
        Me.txtjml_val_trans.Location = New System.Drawing.Point(0, 80)
        Me.txtjml_val_trans.Name = "txtjml_val_trans"
        Me.txtjml_val_trans.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtjml_val_trans.Properties.Appearance.Options.UseBackColor = True
        Me.txtjml_val_trans.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Silver
        Me.txtjml_val_trans.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtjml_val_trans.Properties.DisplayFormat.FormatString = "n2"
        Me.txtjml_val_trans.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtjml_val_trans.Properties.EditFormat.FormatString = "n2"
        Me.txtjml_val_trans.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtjml_val_trans.Properties.Mask.EditMask = "###,###,###,###"
        Me.txtjml_val_trans.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtjml_val_trans.Properties.Mask.ShowPlaceHolders = False
        Me.txtjml_val_trans.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtjml_val_trans.Size = New System.Drawing.Size(424, 20)
        Me.txtjml_val_trans.TabIndex = 4
        '
        'lookupPeg
        '
        Me.lookupPeg.AutoHeight = False
        Me.lookupPeg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupPeg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama")})
        Me.lookupPeg.Name = "lookupPeg"
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.txtketerangan)
        Me.pnl12.Controls.Add(Me.txtjml_val_trans)
        Me.pnl12.Controls.Add(Me.Lookrekening)
        Me.pnl12.Controls.Add(Me.Lookkaryawan)
        Me.pnl12.Controls.Add(Me.dttgl_inv)
        Me.pnl12.Controls.Add(Me.txtno_inv)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(288, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(424, 172)
        Me.pnl12.TabIndex = 3
        '
        'txtketerangan
        '
        Me.txtketerangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtketerangan.Location = New System.Drawing.Point(0, 100)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(424, 68)
        Me.txtketerangan.TabIndex = 5
        '
        'dttgl_inv
        '
        Me.dttgl_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttgl_inv.EditValue = Nothing
        Me.dttgl_inv.EnterMoveNextControl = True
        Me.dttgl_inv.Location = New System.Drawing.Point(0, 20)
        Me.dttgl_inv.Name = "dttgl_inv"
        Me.dttgl_inv.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dttgl_inv.Properties.Appearance.Options.UseForeColor = True
        Me.dttgl_inv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttgl_inv.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttgl_inv.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttgl_inv.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dttgl_inv.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dttgl_inv.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttgl_inv.Size = New System.Drawing.Size(424, 20)
        Me.dttgl_inv.TabIndex = 1
        '
        'txtno_inv
        '
        Me.txtno_inv.BackColor = System.Drawing.Color.Cornsilk
        Me.txtno_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtno_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_inv.ForeColor = System.Drawing.Color.Yellow
        Me.txtno_inv.Location = New System.Drawing.Point(0, 0)
        Me.txtno_inv.Name = "txtno_inv"
        Me.txtno_inv.ReadOnly = True
        Me.txtno_inv.Size = New System.Drawing.Size(424, 20)
        Me.txtno_inv.TabIndex = 0
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Nama Kartu"
        Me.kd_cust.ColumnEdit = Me.lookupPeg
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.OptionsColumn.AllowEdit = False
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 3
        Me.kd_cust.Width = 209
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lookuprek
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.OptionsColumn.AllowEdit = False
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 4
        Me.kd_buku_besar.Width = 228
        '
        'lookuprek
        '
        Me.lookuprek.AutoHeight = False
        Me.lookuprek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookuprek.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Rekening")})
        Me.lookuprek.Name = "lookuprek"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "Nota"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.AllowEdit = False
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 1
        Me.no_inv.Width = 161
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(1, 1)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(975, 599)
        Me.pnl.TabIndex = 6
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 206)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupPeg, Me.lookuprek})
        Me.GC.Size = New System.Drawing.Size(975, 373)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no, Me.no_inv, Me.kd_cust, Me.kd_buku_besar, Me.jml_val_trans, Me.tgl_inv, Me.GridColumn1})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Appearance.Options.UseImage = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.GridColumn1
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "REJECT"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.PaintStyleName = "Office2003"
        '
        'no
        '
        Me.no.AppearanceCell.Options.UseTextOptions = True
        Me.no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no.AppearanceHeader.Options.UseFont = True
        Me.no.AppearanceHeader.Options.UseTextOptions = True
        Me.no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no.Caption = "No."
        Me.no.Name = "no"
        Me.no.Visible = True
        Me.no.VisibleIndex = 0
        Me.no.Width = 36
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceCell.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_val_trans.Caption = "Jml. Piutang"
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.OptionsColumn.AllowEdit = False
        Me.jml_val_trans.OptionsColumn.ReadOnly = True
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 5
        Me.jml_val_trans.Width = 192
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tgl Transaksi"
        Me.tgl_inv.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 2
        Me.tgl_inv.Width = 132
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 579)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 20)
        Me.Panel1.TabIndex = 6
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.LightGray
        Me.pnlTools.Controls.Add(Me.pnl2)
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(975, 172)
        Me.pnlTools.TabIndex = 5
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.Panel4)
        Me.pnl2.Controls.Add(Me.Panel6)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(712, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(264, 172)
        Me.pnl2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(8, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(121, 27)
        Me.Panel4.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(121, 20)
        Me.Panel3.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(20, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Nota di Reject"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(121, 4)
        Me.Panel5.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(264, 104)
        Me.Panel6.TabIndex = 19
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(712, 172)
        Me.pnl1.TabIndex = 0
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(538, 460)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 11
        Me.btCancel.Text = "Batal"
        Me.btCancel.Visible = False
        '
        'frmPiutangLain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 625)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btCancel)
        Me.Name = "frmPiutangLain"
        Me.Text = "Form Permohonan Piutang Lain-lain"
        CType(Me.Lookrekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        CType(Me.Lookkaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtjml_val_trans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl12.ResumeLayout(False)
        Me.pnl12.PerformLayout()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lookrekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lookkaryawan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtjml_val_trans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lookupPeg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents dttgl_inv As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtno_inv As System.Windows.Forms.TextBox
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookuprek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents no As DevExpress.XtraGrid.Columns.GridColumn
End Class
