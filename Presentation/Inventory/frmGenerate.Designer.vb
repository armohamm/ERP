<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GcGen_Brg = New DevExpress.XtraGrid.GridControl
        Me.GvGen_Brg = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_cabang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_persediaan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jenis_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GcGen_Brg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvGen_Brg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Text = "          Generate Kode Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
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
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.Panel1.Size = New System.Drawing.Size(792, 34)
        Me.Panel1.TabIndex = 145
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcGen_Brg)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 272)
        Me.Panel5.TabIndex = 2
        '
        'GcGen_Brg
        '
        Me.GcGen_Brg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcGen_Brg.Location = New System.Drawing.Point(0, 0)
        Me.GcGen_Brg.MainView = Me.GvGen_Brg
        Me.GcGen_Brg.Name = "GcGen_Brg"
        Me.GcGen_Brg.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang})
        Me.GcGen_Brg.Size = New System.Drawing.Size(792, 272)
        Me.GcGen_Brg.TabIndex = 6
        Me.GcGen_Brg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvGen_Brg})
        '
        'GvGen_Brg
        '
        Me.GvGen_Brg.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_cabang, Me.divisi, Me.jns_persediaan, Me.jenis_barang, Me.merk, Me.tipe, Me.ukuran, Me.kain, Me.nama_brg, Me.harga, Me.kd_barang})
        Me.GvGen_Brg.GridControl = Me.GcGen_Brg
        Me.GvGen_Brg.Name = "GvGen_Brg"
        Me.GvGen_Brg.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvGen_Brg.OptionsView.RowAutoHeight = True
        '
        'kd_cabang
        '
        Me.kd_cabang.Caption = "Kd Cabang"
        Me.kd_cabang.FieldName = "kd_cabang"
        Me.kd_cabang.Name = "kd_cabang"
        Me.kd_cabang.OptionsColumn.ReadOnly = True
        Me.kd_cabang.Visible = True
        Me.kd_cabang.VisibleIndex = 0
        Me.kd_cabang.Width = 27
        '
        'divisi
        '
        Me.divisi.Caption = "Divisi"
        Me.divisi.FieldName = "divisi"
        Me.divisi.Name = "divisi"
        Me.divisi.OptionsColumn.AllowEdit = False
        Me.divisi.OptionsColumn.ReadOnly = True
        Me.divisi.Visible = True
        Me.divisi.VisibleIndex = 1
        Me.divisi.Width = 36
        '
        'jns_persediaan
        '
        Me.jns_persediaan.Caption = "Jns Persd"
        Me.jns_persediaan.FieldName = "jns_persediaan"
        Me.jns_persediaan.Name = "jns_persediaan"
        Me.jns_persediaan.OptionsColumn.AllowEdit = False
        Me.jns_persediaan.OptionsColumn.ReadOnly = True
        Me.jns_persediaan.Visible = True
        Me.jns_persediaan.VisibleIndex = 2
        Me.jns_persediaan.Width = 78
        '
        'jenis_barang
        '
        Me.jenis_barang.Caption = "Jenis Barang"
        Me.jenis_barang.FieldName = "jns_barang"
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.OptionsColumn.AllowEdit = False
        Me.jenis_barang.OptionsColumn.ReadOnly = True
        Me.jenis_barang.Visible = True
        Me.jenis_barang.VisibleIndex = 3
        Me.jenis_barang.Width = 73
        '
        'merk
        '
        Me.merk.Caption = "Merk"
        Me.merk.FieldName = "merk"
        Me.merk.Name = "merk"
        Me.merk.Visible = True
        Me.merk.VisibleIndex = 4
        Me.merk.Width = 65
        '
        'tipe
        '
        Me.tipe.Caption = "Tipe"
        Me.tipe.FieldName = "tipe"
        Me.tipe.Name = "tipe"
        Me.tipe.Visible = True
        Me.tipe.VisibleIndex = 5
        Me.tipe.Width = 80
        '
        'ukuran
        '
        Me.ukuran.Caption = "Ukuran"
        Me.ukuran.FieldName = "ukuran"
        Me.ukuran.Name = "ukuran"
        Me.ukuran.OptionsColumn.AllowEdit = False
        Me.ukuran.OptionsColumn.ReadOnly = True
        Me.ukuran.Visible = True
        Me.ukuran.VisibleIndex = 6
        Me.ukuran.Width = 77
        '
        'kain
        '
        Me.kain.Caption = "Kain"
        Me.kain.FieldName = "kain"
        Me.kain.Name = "kain"
        Me.kain.Visible = True
        Me.kain.VisibleIndex = 7
        Me.kain.Width = 80
        '
        'nama_brg
        '
        Me.nama_brg.Caption = "Nama Barang"
        Me.nama_brg.FieldName = "nama_brg"
        Me.nama_brg.Name = "nama_brg"
        Me.nama_brg.SummaryItem.FieldName = "jml_trans"
        Me.nama_brg.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.nama_brg.Visible = True
        Me.nama_brg.VisibleIndex = 8
        Me.nama_brg.Width = 80
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 9
        Me.harga.Width = 80
        '
        'kd_barang
        '
        Me.kd_barang.Caption = "Kode Barang"
        Me.kd_barang.FieldName = "kd_barang"
        Me.kd_barang.Name = "kd_barang"
        Me.kd_barang.Visible = True
        Me.kd_barang.VisibleIndex = 10
        Me.kd_barang.Width = 95
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = "[klik disini]"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel4)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 346)
        Me.pnl.TabIndex = 147
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_generate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 305)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 41)
        Me.Panel4.TabIndex = 1
        '
        'btn_generate
        '
        Me.btn_generate.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Appearance.Options.UseFont = True
        Me.btn_generate.Location = New System.Drawing.Point(333, 0)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(169, 41)
        Me.btn_generate.TabIndex = 1
        Me.btn_generate.Text = "Generate Kode Barang!"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 33)
        Me.Panel3.TabIndex = 0
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 146
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmGenerate"
        Me.Text = "frmGenerate"
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GcGen_Brg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvGen_Brg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GcGen_Brg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvGen_Brg As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_cabang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jns_persediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jenis_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_barang As DevExpress.XtraGrid.Columns.GridColumn
End Class
