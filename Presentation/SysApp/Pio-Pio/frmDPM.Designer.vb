<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDPM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDPM))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_Seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QTY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QTYPR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QTYSISA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.dtTgl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DtTanggalgrid = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.txtRef = New DevExpress.XtraEditors.TextEdit
        Me.dtTanggal = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.LookUpEditDep = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtNoDPM = New DevExpress.XtraEditors.TextEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.LookUpEditDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtNoDPM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.Controls.Add(Me.btSimpan)
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(1027, 387)
        Me.Pnl.TabIndex = 5
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(478, 343)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 7
        Me.btSimpan.Text = "Simpan"
        '
        'GC
        '
        Me.GC.Location = New System.Drawing.Point(5, 147)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBarang, Me.rpStatus, Me.DtTanggalgrid})
        Me.GC.Size = New System.Drawing.Size(1022, 180)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_Seq, Me.Kd_Stok, Me.Satuan, Me.QTY, Me.QTYPR, Me.QTYSISA, Me.gcKeterangan, Me.gcStatus, Me.dtTgl})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'No_Seq
        '
        Me.No_Seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_Seq.AppearanceHeader.Options.UseFont = True
        Me.No_Seq.Caption = "No"
        Me.No_Seq.FieldName = "No_Seq"
        Me.No_Seq.Name = "No_Seq"
        Me.No_Seq.OptionsColumn.AllowEdit = False
        Me.No_Seq.OptionsColumn.AllowFocus = False
        Me.No_Seq.Visible = True
        Me.No_Seq.VisibleIndex = 0
        Me.No_Seq.Width = 36
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Barang"
        Me.Kd_Stok.ColumnEdit = Me.repBarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 360
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", "Satuan")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.HideSelection = False
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = "[Pilih Barang]"
        Me.repBarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowEdit = False
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        Me.Satuan.Width = 83
        '
        'QTY
        '
        Me.QTY.Caption = "QTY"
        Me.QTY.FieldName = "Qty"
        Me.QTY.Name = "QTY"
        Me.QTY.Visible = True
        Me.QTY.VisibleIndex = 3
        Me.QTY.Width = 64
        '
        'QTYPR
        '
        Me.QTYPR.Caption = "QTY PR"
        Me.QTYPR.FieldName = "Qty_PR"
        Me.QTYPR.Name = "QTYPR"
        Me.QTYPR.Visible = True
        Me.QTYPR.VisibleIndex = 4
        Me.QTYPR.Width = 72
        '
        'QTYSISA
        '
        Me.QTYSISA.Caption = "QTY SISA"
        Me.QTYSISA.FieldName = "Qty_sisa"
        Me.QTYSISA.Name = "QTYSISA"
        Me.QTYSISA.OptionsColumn.AllowEdit = False
        Me.QTYSISA.Visible = True
        Me.QTYSISA.VisibleIndex = 5
        Me.QTYSISA.Width = 69
        '
        'gcKeterangan
        '
        Me.gcKeterangan.Caption = "Keterangan"
        Me.gcKeterangan.FieldName = "Keterangan"
        Me.gcKeterangan.Name = "gcKeterangan"
        Me.gcKeterangan.Visible = True
        Me.gcKeterangan.VisibleIndex = 6
        Me.gcKeterangan.Width = 124
        '
        'gcStatus
        '
        Me.gcStatus.Caption = "Status"
        Me.gcStatus.ColumnEdit = Me.rpStatus
        Me.gcStatus.FieldName = "Status"
        Me.gcStatus.Name = "gcStatus"
        Me.gcStatus.Visible = True
        Me.gcStatus.VisibleIndex = 7
        '
        'rpStatus
        '
        Me.rpStatus.AutoHeight = False
        Me.rpStatus.AutoWidth = True
        Me.rpStatus.Caption = "TIDAK AKTIF"
        Me.rpStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.rpStatus.DisplayValueChecked = "AKTIF"
        Me.rpStatus.DisplayValueUnchecked = "TIDAK AKTIF"
        Me.rpStatus.FullFocusRect = True
        Me.rpStatus.Name = "rpStatus"
        Me.rpStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.rpStatus.NullText = "TIDAK AKTIF"
        Me.rpStatus.ValueChecked = "Y"
        Me.rpStatus.ValueUnchecked = "T"
        '
        'dtTgl
        '
        Me.dtTgl.Caption = "Tanggal diPerlukan"
        Me.dtTgl.ColumnEdit = Me.DtTanggalgrid
        Me.dtTgl.FieldName = "Tgl_Diperlukan"
        Me.dtTgl.Name = "dtTgl"
        Me.dtTgl.Visible = True
        Me.dtTgl.VisibleIndex = 8
        Me.dtTgl.Width = 118
        '
        'DtTanggalgrid
        '
        Me.DtTanggalgrid.AutoHeight = False
        Me.DtTanggalgrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTanggalgrid.Name = "DtTanggalgrid"
        Me.DtTanggalgrid.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Controls.Add(Me.Panel4)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1027, 103)
        Me.pnlTengahAtas.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cbStatus)
        Me.Panel3.Controls.Add(Me.txtRef)
        Me.Panel3.Controls.Add(Me.dtTanggal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(746, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 103)
        Me.Panel3.TabIndex = 6
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(0, 40)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(279, 21)
        Me.cbStatus.TabIndex = 72
        '
        'txtRef
        '
        Me.txtRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRef.Location = New System.Drawing.Point(0, 20)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRef.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtRef.Properties.Appearance.Options.UseBackColor = True
        Me.txtRef.Properties.Appearance.Options.UseForeColor = True
        Me.txtRef.Size = New System.Drawing.Size(279, 20)
        Me.txtRef.TabIndex = 10
        '
        'dtTanggal
        '
        Me.dtTanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtTanggal.EditValue = Nothing
        Me.dtTanggal.Location = New System.Drawing.Point(0, 0)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtTanggal.Size = New System.Drawing.Size(279, 20)
        Me.dtTanggal.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(604, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 103)
        Me.Panel2.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Status :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "No Referensi :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtKeterangan)
        Me.Panel5.Controls.Add(Me.LookUpEditDep)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(142, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(462, 103)
        Me.Panel5.TabIndex = 3
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 40)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(460, 59)
        Me.txtKeterangan.TabIndex = 12
        '
        'LookUpEditDep
        '
        Me.LookUpEditDep.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditDep.Location = New System.Drawing.Point(0, 20)
        Me.LookUpEditDep.Name = "LookUpEditDep"
        Me.LookUpEditDep.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookUpEditDep.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpEditDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditDep.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen", 115, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEditDep.Properties.DisplayMember = "Nama_Departemen"
        Me.LookUpEditDep.Properties.NullText = "[Pilih Departemen]"
        Me.LookUpEditDep.Properties.ValueMember = "Kd_Departemen"
        Me.LookUpEditDep.Size = New System.Drawing.Size(460, 20)
        Me.LookUpEditDep.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtNoDPM)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(460, 20)
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
        Me.txtNoDPM.Size = New System.Drawing.Size(460, 20)
        Me.txtNoDPM.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 103)
        Me.Panel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 59)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keterangan:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Departemen :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No DPM :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 34)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM DAFTAR PERMINTAAN MATERIAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmDPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 446)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmDPM"
        Me.Text = "DAFTAR PERMINTAAN MATERIAL"
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTanggalgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.LookUpEditDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtNoDPM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents LookUpEditDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtNoDPM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTYPR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTYSISA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtTgl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DtTanggalgrid As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
End Class
