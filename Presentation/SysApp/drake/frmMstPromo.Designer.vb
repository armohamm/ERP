<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstPromo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstPromo))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.btnCrDept = New System.Windows.Forms.Button
        Me.cbStat = New System.Windows.Forms.ComboBox
        Me.rtbKet = New System.Windows.Forms.RichTextBox
        Me.txbNamaPromo = New System.Windows.Forms.TextBox
        Me.txbNoPromo = New System.Windows.Forms.TextBox
        Me.txbKdDept = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.GcMstPromo_d = New DevExpress.XtraGrid.GridControl
        Me.GvMstPromo_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_promo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.promo_desc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_beli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_point = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cash_back = New DevExpress.XtraGrid.Columns.GridColumn
        Me.free_qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_brg_bonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GcMstPromo_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstPromo_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 422)
        Me.pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.GcMstPromo_d)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 351)
        Me.Panel3.TabIndex = 141
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.dtpEnd)
        Me.Panel5.Controls.Add(Me.dtpStart)
        Me.Panel5.Controls.Add(Me.btnCrDept)
        Me.Panel5.Controls.Add(Me.cbStat)
        Me.Panel5.Controls.Add(Me.rtbKet)
        Me.Panel5.Controls.Add(Me.txbNamaPromo)
        Me.Panel5.Controls.Add(Me.txbNoPromo)
        Me.Panel5.Controls.Add(Me.txbKdDept)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(239, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(765, 159)
        Me.Panel5.TabIndex = 140
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(6, 79)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 6
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(6, 59)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 5
        '
        'btnCrDept
        '
        Me.btnCrDept.BackColor = System.Drawing.Color.DarkGray
        Me.btnCrDept.Location = New System.Drawing.Point(222, 0)
        Me.btnCrDept.Name = "btnCrDept"
        Me.btnCrDept.Size = New System.Drawing.Size(46, 20)
        Me.btnCrDept.TabIndex = 8
        Me.btnCrDept.Text = "Cari..."
        Me.btnCrDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrDept.UseVisualStyleBackColor = False
        '
        'cbStat
        '
        Me.cbStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbStat.FormattingEnabled = True
        Me.cbStat.Items.AddRange(New Object() {"AKTIF", "NonAKTIF"})
        Me.cbStat.Location = New System.Drawing.Point(6, 132)
        Me.cbStat.Name = "cbStat"
        Me.cbStat.Size = New System.Drawing.Size(93, 21)
        Me.cbStat.TabIndex = 8
        '
        'rtbKet
        '
        Me.rtbKet.Location = New System.Drawing.Point(6, 100)
        Me.rtbKet.Name = "rtbKet"
        Me.rtbKet.Size = New System.Drawing.Size(719, 31)
        Me.rtbKet.TabIndex = 7
        Me.rtbKet.Text = ""
        '
        'txbNamaPromo
        '
        Me.txbNamaPromo.Location = New System.Drawing.Point(6, 40)
        Me.txbNamaPromo.Name = "txbNamaPromo"
        Me.txbNamaPromo.Size = New System.Drawing.Size(719, 20)
        Me.txbNamaPromo.TabIndex = 4
        '
        'txbNoPromo
        '
        Me.txbNoPromo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoPromo.Location = New System.Drawing.Point(6, 20)
        Me.txbNoPromo.Name = "txbNoPromo"
        Me.txbNoPromo.Size = New System.Drawing.Size(212, 20)
        Me.txbNoPromo.TabIndex = 1
        '
        'txbKdDept
        '
        Me.txbKdDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbKdDept.Location = New System.Drawing.Point(6, 0)
        Me.txbKdDept.Name = "txbKdDept"
        Me.txbKdDept.Size = New System.Drawing.Size(212, 20)
        Me.txbKdDept.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(239, 159)
        Me.Panel4.TabIndex = 139
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label8)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 131)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(239, 21)
        Me.Panel12.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(195, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Status"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 100)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(239, 31)
        Me.Panel11.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(166, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Keterangan"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 80)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(239, 20)
        Me.Panel10.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(182, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "End Date"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 60)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(239, 20)
        Me.Panel9.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(175, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Start Date"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 40)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(239, 20)
        Me.Panel8.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(158, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama Promo"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 20)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(239, 20)
        Me.Panel7.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(176, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Promo"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(239, 20)
        Me.Panel6.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(130, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Departemen"
        '
        'GcMstPromo_d
        '
        Me.GcMstPromo_d.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GcMstPromo_d.Location = New System.Drawing.Point(0, 159)
        Me.GcMstPromo_d.MainView = Me.GvMstPromo_d
        Me.GcMstPromo_d.Name = "GcMstPromo_d"
        Me.GcMstPromo_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupTipe, Me.LookupMerk, Me.CekStat})
        Me.GcMstPromo_d.Size = New System.Drawing.Size(1004, 192)
        Me.GcMstPromo_d.TabIndex = 138
        Me.GcMstPromo_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstPromo_d})
        '
        'GvMstPromo_d
        '
        Me.GvMstPromo_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_promo, Me.no_seq, Me.kd_merk, Me.kd_tipe, Me.promo_desc, Me.jml_beli, Me.jml_point, Me.cash_back, Me.free_qty, Me.kd_brg_bonus, Me.Rec_stat})
        Me.GvMstPromo_d.GridControl = Me.GcMstPromo_d
        Me.GvMstPromo_d.Name = "GvMstPromo_d"
        Me.GvMstPromo_d.OptionsCustomization.AllowColumnMoving = False
        Me.GvMstPromo_d.OptionsCustomization.AllowFilter = False
        Me.GvMstPromo_d.OptionsCustomization.AllowGroup = False
        Me.GvMstPromo_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvMstPromo_d.OptionsView.RowAutoHeight = True
        Me.GvMstPromo_d.OptionsView.ShowGroupPanel = False
        '
        'no_promo
        '
        Me.no_promo.Caption = "No. Promo"
        Me.no_promo.FieldName = "no_promo"
        Me.no_promo.Name = "no_promo"
        Me.no_promo.Visible = True
        Me.no_promo.VisibleIndex = 0
        Me.no_promo.Width = 83
        '
        'no_seq
        '
        Me.no_seq.Caption = "Urut"
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 1
        Me.no_seq.Width = 37
        '
        'kd_merk
        '
        Me.kd_merk.Caption = "Kode Merk"
        Me.kd_merk.ColumnEdit = Me.LookupMerk
        Me.kd_merk.FieldName = "kd_merk"
        Me.kd_merk.Name = "kd_merk"
        Me.kd_merk.Visible = True
        Me.kd_merk.VisibleIndex = 2
        Me.kd_merk.Width = 106
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'kd_tipe
        '
        Me.kd_tipe.Caption = "Kode Tipe"
        Me.kd_tipe.ColumnEdit = Me.LookupTipe
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 3
        Me.kd_tipe.Width = 191
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'promo_desc
        '
        Me.promo_desc.Caption = "Deskripsi Promo"
        Me.promo_desc.FieldName = "promo_desc"
        Me.promo_desc.Name = "promo_desc"
        Me.promo_desc.Visible = True
        Me.promo_desc.VisibleIndex = 4
        Me.promo_desc.Width = 191
        '
        'jml_beli
        '
        Me.jml_beli.Caption = "Jumlah Beli"
        Me.jml_beli.FieldName = "jml_beli"
        Me.jml_beli.Name = "jml_beli"
        Me.jml_beli.Visible = True
        Me.jml_beli.VisibleIndex = 5
        Me.jml_beli.Width = 66
        '
        'jml_point
        '
        Me.jml_point.Caption = "Jumlah Poin"
        Me.jml_point.FieldName = "jml_point"
        Me.jml_point.Name = "jml_point"
        Me.jml_point.Visible = True
        Me.jml_point.VisibleIndex = 6
        Me.jml_point.Width = 70
        '
        'cash_back
        '
        Me.cash_back.Caption = "Cash Back"
        Me.cash_back.FieldName = "cash_back"
        Me.cash_back.Name = "cash_back"
        Me.cash_back.Visible = True
        Me.cash_back.VisibleIndex = 7
        Me.cash_back.Width = 63
        '
        'free_qty
        '
        Me.free_qty.Caption = "Free Qty"
        Me.free_qty.FieldName = "free_qty"
        Me.free_qty.Name = "free_qty"
        Me.free_qty.Visible = True
        Me.free_qty.VisibleIndex = 8
        Me.free_qty.Width = 57
        '
        'kd_brg_bonus
        '
        Me.kd_brg_bonus.Caption = "Kode Barang Bonus"
        Me.kd_brg_bonus.FieldName = "kd_brg_bonus"
        Me.kd_brg_bonus.Name = "kd_brg_bonus"
        Me.kd_brg_bonus.Visible = True
        Me.kd_brg_bonus.VisibleIndex = 9
        Me.kd_brg_bonus.Width = 105
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 10
        Me.Rec_stat.Width = 51
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "AKTIF"
        Me.CekStat.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CekStat.DisplayValueChecked = "AKTIF"
        Me.CekStat.DisplayValueUnchecked = "NonAKTIF"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btEdit)
        Me.Panel2.Controls.Add(Me.btAdd)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 140
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(580, 6)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(64, 27)
        Me.btnBatal.TabIndex = 30
        Me.btnBatal.Text = "Bata&l"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(339, 6)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(64, 27)
        Me.btEdit.TabIndex = 29
        Me.btEdit.Text = "&Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(271, 6)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(62, 27)
        Me.btAdd.TabIndex = 28
        Me.btAdd.Text = "&Tambah"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(480, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(677, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(410, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 139
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE MASTER PROMO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'frmMstPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 422)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstPromo"
        Me.Text = "frmMstPromo"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.GcMstPromo_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstPromo_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCrDept As System.Windows.Forms.Button
    Friend WithEvents cbStat As System.Windows.Forms.ComboBox
    Friend WithEvents rtbKet As System.Windows.Forms.RichTextBox
    Friend WithEvents txbNamaPromo As System.Windows.Forms.TextBox
    Friend WithEvents txbNoPromo As System.Windows.Forms.TextBox
    Friend WithEvents txbKdDept As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GcMstPromo_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstPromo_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_promo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents promo_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_beli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_point As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cash_back As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents free_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_brg_bonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
