<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMHPiutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPMHPiutang))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupPeg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookuprek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.txtketerangan = New System.Windows.Forms.TextBox
        Me.txtjml_val_trans = New DevExpress.XtraEditors.TextEdit
        Me.Lookkaryawan = New DevExpress.XtraEditors.LookUpEdit
        Me.Lookrekening = New DevExpress.XtraEditors.LookUpEdit
        Me.dttgl_inv = New DevExpress.XtraEditors.DateEdit
        Me.txtno_inv = New System.Windows.Forms.TextBox
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btSave = New DevExpress.XtraEditors.SimpleButton
        Me.btDel = New DevExpress.XtraEditors.SimpleButton
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl12.SuspendLayout()
        CType(Me.txtjml_val_trans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookkaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookrekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(4, 2)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(695, 476)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 188)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupPeg, Me.lookuprek})
        Me.GC.Size = New System.Drawing.Size(695, 288)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_inv, Me.kd_cust, Me.kd_buku_besar, Me.jml_val_trans, Me.tgl_inv})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.PaintStyleName = "Office2003"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "Nomor"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.AllowEdit = False
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 0
        Me.no_inv.Width = 128
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Nama"
        Me.kd_cust.ColumnEdit = Me.lookupPeg
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.OptionsColumn.AllowEdit = False
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 2
        Me.kd_cust.Width = 121
        '
        'lookupPeg
        '
        Me.lookupPeg.AutoHeight = False
        Me.lookupPeg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupPeg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama")})
        Me.lookupPeg.Name = "lookupPeg"
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
        Me.kd_buku_besar.VisibleIndex = 3
        Me.kd_buku_besar.Width = 159
        '
        'lookuprek
        '
        Me.lookuprek.AutoHeight = False
        Me.lookuprek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookuprek.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Rekening")})
        Me.lookuprek.Name = "lookuprek"
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
        Me.jml_val_trans.VisibleIndex = 4
        Me.jml_val_trans.Width = 169
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tanggal"
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.AllowEdit = False
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 1
        Me.tgl_inv.Width = 97
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.LightGray
        Me.pnlTools.Controls.Add(Me.pnl2)
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(695, 154)
        Me.pnlTools.TabIndex = 5
        '
        'pnl2
        '
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(612, 0)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(30, 154)
        Me.pnl2.TabIndex = 1
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(612, 154)
        Me.pnl1.TabIndex = 0
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.txtketerangan)
        Me.pnl12.Controls.Add(Me.txtjml_val_trans)
        Me.pnl12.Controls.Add(Me.Lookkaryawan)
        Me.pnl12.Controls.Add(Me.Lookrekening)
        Me.pnl12.Controls.Add(Me.dttgl_inv)
        Me.pnl12.Controls.Add(Me.txtno_inv)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(160, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(452, 154)
        Me.pnl12.TabIndex = 3
        '
        'txtketerangan
        '
        Me.txtketerangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtketerangan.Location = New System.Drawing.Point(0, 100)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(452, 52)
        Me.txtketerangan.TabIndex = 4
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
        Me.txtjml_val_trans.Size = New System.Drawing.Size(452, 20)
        Me.txtjml_val_trans.TabIndex = 11
        '
        'Lookkaryawan
        '
        Me.Lookkaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lookkaryawan.Location = New System.Drawing.Point(0, 60)
        Me.Lookkaryawan.Name = "Lookkaryawan"
        Me.Lookkaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookkaryawan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Pegawai", "NIP")})
        Me.Lookkaryawan.Properties.NullText = "[Klik coy]"
        Me.Lookkaryawan.Size = New System.Drawing.Size(452, 20)
        Me.Lookkaryawan.TabIndex = 9
        '
        'Lookrekening
        '
        Me.Lookrekening.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lookrekening.Location = New System.Drawing.Point(0, 40)
        Me.Lookrekening.Name = "Lookrekening"
        Me.Lookrekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookrekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Rekening")})
        Me.Lookrekening.Properties.NullText = "[Klik coy]"
        Me.Lookrekening.Size = New System.Drawing.Size(452, 20)
        Me.Lookrekening.TabIndex = 12
        '
        'dttgl_inv
        '
        Me.dttgl_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttgl_inv.EditValue = Nothing
        Me.dttgl_inv.Location = New System.Drawing.Point(0, 20)
        Me.dttgl_inv.Name = "dttgl_inv"
        Me.dttgl_inv.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dttgl_inv.Properties.Appearance.Options.UseForeColor = True
        Me.dttgl_inv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttgl_inv.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttgl_inv.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttgl_inv.Size = New System.Drawing.Size(452, 20)
        Me.dttgl_inv.TabIndex = 6
        Me.dttgl_inv.ToolTip = "Format : dd/mm/yyyy"
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
        Me.txtno_inv.Size = New System.Drawing.Size(452, 20)
        Me.txtno_inv.TabIndex = 0
        '
        'pnl11
        '
        Me.pnl11.Controls.Add(Me.Label5)
        Me.pnl11.Controls.Add(Me.Label4)
        Me.pnl11.Controls.Add(Me.Label1)
        Me.pnl11.Controls.Add(Me.Label3)
        Me.pnl11.Controls.Add(Me.Label2)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(160, 154)
        Me.pnl11.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keterangan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Karyawan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Jenis Piutang :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(160, 20)
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
        Me.Label6.Size = New System.Drawing.Size(160, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(695, 34)
        Me.pnlTitle.TabIndex = 4
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
        Me.lblTitle.Text = "PERMOHONAN PIUTANG"
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
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(118, 484)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 1
        Me.btAdd.Text = "Baru"
        Me.btAdd.Visible = False
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(218, 484)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 2
        Me.btEdit.Text = "Edit"
        Me.btEdit.Visible = False
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(319, 484)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Simpan"
        Me.btSave.Visible = False
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(415, 484)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(75, 23)
        Me.btDel.TabIndex = 4
        Me.btDel.Text = "Hapus"
        Me.btDel.Visible = False
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(513, 484)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "Batal"
        Me.btCancel.Visible = False
        '
        'frmPMHPiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 509)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPMHPiutang"
        Me.Text = "Frm_PMH_Piutang"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookuprek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl12.ResumeLayout(False)
        Me.pnl12.PerformLayout()
        CType(Me.txtjml_val_trans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookkaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookrekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtno_inv As System.Windows.Forms.TextBox
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dttgl_inv As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lookkaryawan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtjml_val_trans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lookupPeg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookrekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookuprek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
