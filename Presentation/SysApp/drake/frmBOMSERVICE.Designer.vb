<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOMSERVICE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOMSERVICE))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LookUpEditJnsBRG = New DevExpress.XtraEditors.LookUpEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LookUpEditJnsServis = New DevExpress.XtraEditors.LookUpEdit
        Me.LookUpEditUkuran = New DevExpress.XtraEditors.LookUpEdit
        Me.LookUpEditJnsTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookUpEditTipe = New DevExpress.XtraEditors.LookUpEdit
        Me.pnlheder2 = New System.Windows.Forms.Panel
        Me.LookUpEditMerk = New DevExpress.XtraEditors.LookUpEdit
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlHeder1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.LookUpEditJnsBRG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LookUpEditJnsServis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditUkuran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditJnsTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheder2.SuspendLayout()
        CType(Me.LookUpEditMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlHeder1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 549)
        Me.pnl.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(105, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Jenis Servis :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(117, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Jenis Tipe :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(134, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Ukuran :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LookUpEditJnsBRG
        '
        Me.LookUpEditJnsBRG.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditJnsBRG.Location = New System.Drawing.Point(0, 20)
        Me.LookUpEditJnsBRG.Name = "LookUpEditJnsBRG"
        Me.LookUpEditJnsBRG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditJnsBRG.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama_Jenis")})
        Me.LookUpEditJnsBRG.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditJnsBRG.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(151, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Tipe :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(146, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Merk :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Barang, Me.satuan, Me.qty})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Kd_Barang
        '
        Me.Kd_Barang.Caption = "Barang"
        Me.Kd_Barang.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.Kd_Barang.FieldName = "Kd_Barang"
        Me.Kd_Barang.Name = "Kd_Barang"
        Me.Kd_Barang.Visible = True
        Me.Kd_Barang.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Barang")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Kd_Barang"
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.OptionsColumn.AllowEdit = False
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 1
        '
        'qty
        '
        Me.qty.Caption = "QTY"
        Me.qty.FieldName = "qty"
        Me.qty.Name = "qty"
        Me.qty.Visible = True
        Me.qty.VisibleIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 318)
        Me.GridControl1.TabIndex = 141
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(116, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Jenis Kain :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(661, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "E&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btCancel.Location = New System.Drawing.Point(558, 5)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(64, 27)
        Me.btCancel.TabIndex = 31
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Maroon
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnExit)
        Me.Panel7.Controls.Add(Me.btCancel)
        Me.Panel7.Controls.Add(Me.btnDel)
        Me.Panel7.Controls.Add(Me.btSave)
        Me.Panel7.Controls.Add(Me.btEdit)
        Me.Panel7.Controls.Add(Me.btAdd)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 318)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1004, 37)
        Me.Panel7.TabIndex = 140
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDel.Location = New System.Drawing.Point(488, 5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 30
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btSave.Location = New System.Drawing.Point(418, 4)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(64, 27)
        Me.btSave.TabIndex = 29
        Me.btSave.Text = "&Simpan"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'btEdit
        '
        Me.btEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btEdit.Location = New System.Drawing.Point(348, 4)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(64, 27)
        Me.btEdit.TabIndex = 28
        Me.btEdit.Text = "&Edit"
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(277, 4)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(62, 27)
        Me.btAdd.TabIndex = 27
        Me.btAdd.Text = "&Tambah"
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridControl1)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 355)
        Me.Panel3.TabIndex = 4
        '
        'LookUpEditJnsServis
        '
        Me.LookUpEditJnsServis.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditJnsServis.Location = New System.Drawing.Point(0, 120)
        Me.LookUpEditJnsServis.Name = "LookUpEditJnsServis"
        Me.LookUpEditJnsServis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditJnsServis.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditJnsServis.TabIndex = 6
        '
        'LookUpEditUkuran
        '
        Me.LookUpEditUkuran.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditUkuran.Location = New System.Drawing.Point(0, 80)
        Me.LookUpEditUkuran.Name = "LookUpEditUkuran"
        Me.LookUpEditUkuran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditUkuran.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditUkuran.TabIndex = 4
        '
        'LookUpEditJnsTipe
        '
        Me.LookUpEditJnsTipe.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditJnsTipe.Location = New System.Drawing.Point(0, 100)
        Me.LookUpEditJnsTipe.Name = "LookUpEditJnsTipe"
        Me.LookUpEditJnsTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditJnsTipe.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditJnsTipe.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          BOM SERVICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookUpEditTipe
        '
        Me.LookUpEditTipe.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditTipe.Location = New System.Drawing.Point(0, 60)
        Me.LookUpEditTipe.Name = "LookUpEditTipe"
        Me.LookUpEditTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditTipe.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditTipe.TabIndex = 3
        '
        'pnlheder2
        '
        Me.pnlheder2.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheder2.Controls.Add(Me.LookUpEditJnsServis)
        Me.pnlheder2.Controls.Add(Me.LookUpEditJnsTipe)
        Me.pnlheder2.Controls.Add(Me.LookUpEditUkuran)
        Me.pnlheder2.Controls.Add(Me.LookUpEditTipe)
        Me.pnlheder2.Controls.Add(Me.LookUpEditMerk)
        Me.pnlheder2.Controls.Add(Me.LookUpEditJnsBRG)
        Me.pnlheder2.Controls.Add(Me.TextBox1)
        Me.pnlheder2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlheder2.Location = New System.Drawing.Point(213, 34)
        Me.pnlheder2.Name = "pnlheder2"
        Me.pnlheder2.Size = New System.Drawing.Size(791, 160)
        Me.pnlheder2.TabIndex = 77
        '
        'LookUpEditMerk
        '
        Me.LookUpEditMerk.Dock = System.Windows.Forms.DockStyle.Top
        Me.LookUpEditMerk.Location = New System.Drawing.Point(0, 40)
        Me.LookUpEditMerk.Name = "LookUpEditMerk"
        Me.LookUpEditMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Merk_Kain", "Merk_Kain")})
        Me.LookUpEditMerk.Size = New System.Drawing.Size(791, 20)
        Me.LookUpEditMerk.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(791, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlheder2)
        Me.Panel1.Controls.Add(Me.pnlHeder1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 194)
        Me.Panel1.TabIndex = 3
        '
        'pnlHeder1
        '
        Me.pnlHeder1.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlHeder1.Controls.Add(Me.Label8)
        Me.pnlHeder1.Controls.Add(Me.Label7)
        Me.pnlHeder1.Controls.Add(Me.Label6)
        Me.pnlHeder1.Controls.Add(Me.Label5)
        Me.pnlHeder1.Controls.Add(Me.Label4)
        Me.pnlHeder1.Controls.Add(Me.Label3)
        Me.pnlHeder1.Controls.Add(Me.Label2)
        Me.pnlHeder1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeder1.Location = New System.Drawing.Point(0, 34)
        Me.pnlHeder1.Name = "pnlHeder1"
        Me.pnlHeder1.Size = New System.Drawing.Size(213, 160)
        Me.pnlHeder1.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(137, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Nomer :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1004, 34)
        Me.Panel5.TabIndex = 28
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
        'frmBOMSERVICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 549)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBOMSERVICE"
        Me.Text = "frmMstBOM"
        Me.pnl.ResumeLayout(False)
        CType(Me.LookUpEditJnsBRG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.LookUpEditJnsServis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditUkuran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditJnsTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheder2.ResumeLayout(False)
        Me.pnlheder2.PerformLayout()
        CType(Me.LookUpEditMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlHeder1.ResumeLayout(False)
        Me.pnlHeder1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlheder2 As System.Windows.Forms.Panel
    Friend WithEvents LookUpEditJnsServis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditJnsTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditUkuran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditMerk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditJnsBRG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pnlHeder1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
