<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstBOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstBOM))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlheder2 = New System.Windows.Forms.Panel
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.rtbKet = New System.Windows.Forms.RichTextBox
        Me.txbJenisBOM = New System.Windows.Forms.TextBox
        Me.txbNoDocBOM = New System.Windows.Forms.TextBox
        Me.txbNamaBOM = New System.Windows.Forms.TextBox
        Me.txbKdBOM = New System.Windows.Forms.TextBox
        Me.pnlHeder1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.GcMstBOM_d = New DevExpress.XtraGrid.GridControl
        Me.GvMstBOM_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_BOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Urut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1.SuspendLayout()
        Me.pnlheder2.SuspendLayout()
        Me.pnlHeder1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.GcMstBOM_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstBOM_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlheder2)
        Me.Panel1.Controls.Add(Me.pnlHeder1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 186)
        Me.Panel1.TabIndex = 0
        '
        'pnlheder2
        '
        Me.pnlheder2.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlheder2.Controls.Add(Me.cbStatus)
        Me.pnlheder2.Controls.Add(Me.rtbKet)
        Me.pnlheder2.Controls.Add(Me.txbJenisBOM)
        Me.pnlheder2.Controls.Add(Me.txbNoDocBOM)
        Me.pnlheder2.Controls.Add(Me.txbNamaBOM)
        Me.pnlheder2.Controls.Add(Me.txbKdBOM)
        Me.pnlheder2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlheder2.Location = New System.Drawing.Point(219, 34)
        Me.pnlheder2.Name = "pnlheder2"
        Me.pnlheder2.Size = New System.Drawing.Size(785, 152)
        Me.pnlheder2.TabIndex = 77
        '
        'cbStatus
        '
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "NonAKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(0, 116)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(785, 21)
        Me.cbStatus.TabIndex = 93
        '
        'rtbKet
        '
        Me.rtbKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbKet.Location = New System.Drawing.Point(0, 80)
        Me.rtbKet.Name = "rtbKet"
        Me.rtbKet.Size = New System.Drawing.Size(785, 36)
        Me.rtbKet.TabIndex = 92
        Me.rtbKet.Text = ""
        '
        'txbJenisBOM
        '
        Me.txbJenisBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbJenisBOM.Location = New System.Drawing.Point(0, 60)
        Me.txbJenisBOM.Name = "txbJenisBOM"
        Me.txbJenisBOM.Size = New System.Drawing.Size(785, 20)
        Me.txbJenisBOM.TabIndex = 91
        '
        'txbNoDocBOM
        '
        Me.txbNoDocBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbNoDocBOM.Location = New System.Drawing.Point(0, 40)
        Me.txbNoDocBOM.Name = "txbNoDocBOM"
        Me.txbNoDocBOM.Size = New System.Drawing.Size(785, 20)
        Me.txbNoDocBOM.TabIndex = 90
        '
        'txbNamaBOM
        '
        Me.txbNamaBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbNamaBOM.Location = New System.Drawing.Point(0, 20)
        Me.txbNamaBOM.Name = "txbNamaBOM"
        Me.txbNamaBOM.Size = New System.Drawing.Size(785, 20)
        Me.txbNamaBOM.TabIndex = 89
        '
        'txbKdBOM
        '
        Me.txbKdBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbKdBOM.Location = New System.Drawing.Point(0, 0)
        Me.txbKdBOM.Name = "txbKdBOM"
        Me.txbKdBOM.Size = New System.Drawing.Size(785, 20)
        Me.txbKdBOM.TabIndex = 88
        '
        'pnlHeder1
        '
        Me.pnlHeder1.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlHeder1.Controls.Add(Me.Label7)
        Me.pnlHeder1.Controls.Add(Me.Label6)
        Me.pnlHeder1.Controls.Add(Me.Label5)
        Me.pnlHeder1.Controls.Add(Me.Label4)
        Me.pnlHeder1.Controls.Add(Me.Label3)
        Me.pnlHeder1.Controls.Add(Me.Label2)
        Me.pnlHeder1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHeder1.Location = New System.Drawing.Point(0, 34)
        Me.pnlHeder1.Name = "pnlHeder1"
        Me.pnlHeder1.Size = New System.Drawing.Size(219, 152)
        Me.pnlHeder1.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(140, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Status :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(111, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Keterangan :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(116, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Jenis BOM :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(77, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "No Dokumen BOM :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(116, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Nama BOM :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(120, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Kode BOM :"
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
        Me.Label1.Text = "          Maintenance BOM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 25)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1004, 25)
        Me.Panel6.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.GcMstBOM_d)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 211)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1004, 338)
        Me.Panel3.TabIndex = 2
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
        Me.Panel7.Location = New System.Drawing.Point(0, 301)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1004, 37)
        Me.Panel7.TabIndex = 140
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
        'GcMstBOM_d
        '
        Me.GcMstBOM_d.Dock = System.Windows.Forms.DockStyle.Top
        Me.GcMstBOM_d.Location = New System.Drawing.Point(0, 0)
        Me.GcMstBOM_d.MainView = Me.GvMstBOM_d
        Me.GcMstBOM_d.Name = "GcMstBOM_d"
        Me.GcMstBOM_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBrg})
        Me.GcMstBOM_d.Size = New System.Drawing.Size(1004, 298)
        Me.GcMstBOM_d.TabIndex = 139
        Me.GcMstBOM_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstBOM_d})
        '
        'GvMstBOM_d
        '
        Me.GvMstBOM_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_BOM, Me.No_Urut, Me.Kode_Barang, Me.Jumlah, Me.Satuan, Me.Rec_Stat})
        Me.GvMstBOM_d.GridControl = Me.GcMstBOM_d
        Me.GvMstBOM_d.Name = "GvMstBOM_d"
        Me.GvMstBOM_d.OptionsCustomization.AllowColumnMoving = False
        Me.GvMstBOM_d.OptionsCustomization.AllowFilter = False
        Me.GvMstBOM_d.OptionsCustomization.AllowGroup = False
        Me.GvMstBOM_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvMstBOM_d.OptionsView.RowAutoHeight = True
        Me.GvMstBOM_d.OptionsView.ShowGroupPanel = False
        '
        'Kode_BOM
        '
        Me.Kode_BOM.Caption = "Kode BOM"
        Me.Kode_BOM.FieldName = "Kode_BOM"
        Me.Kode_BOM.Name = "Kode_BOM"
        Me.Kode_BOM.Visible = True
        Me.Kode_BOM.VisibleIndex = 0
        Me.Kode_BOM.Width = 83
        '
        'No_Urut
        '
        Me.No_Urut.Caption = "Urut"
        Me.No_Urut.FieldName = "No_Urut"
        Me.No_Urut.Name = "No_Urut"
        Me.No_Urut.OptionsColumn.ReadOnly = True
        Me.No_Urut.Width = 37
        '
        'Kode_Barang
        '
        Me.Kode_Barang.Caption = "Kode Barang"
        Me.Kode_Barang.ColumnEdit = Me.LookupBrg
        Me.Kode_Barang.FieldName = "Kode_Barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.Visible = True
        Me.Kode_Barang.VisibleIndex = 1
        Me.Kode_Barang.Width = 106
        '
        'LookupBrg
        '
        Me.LookupBrg.AutoHeight = False
        Me.LookupBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBrg.Name = "LookupBrg"
        Me.LookupBrg.NullText = "klik disini"
        '
        'Jumlah
        '
        Me.Jumlah.Caption = "Jumlah"
        Me.Jumlah.FieldName = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Visible = True
        Me.Jumlah.VisibleIndex = 2
        Me.Jumlah.Width = 191
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 3
        Me.Satuan.Width = 191
        '
        'Rec_Stat
        '
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.FieldName = "Rec_Stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 4
        Me.Rec_Stat.Width = 51
        '
        'frmMstBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 549)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMstBOM"
        Me.Text = "frmMstBOM"
        Me.Panel1.ResumeLayout(False)
        Me.pnlheder2.ResumeLayout(False)
        Me.pnlheder2.PerformLayout()
        Me.pnlHeder1.ResumeLayout(False)
        Me.pnlHeder1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.GcMstBOM_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstBOM_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnlHeder1 As System.Windows.Forms.Panel
    Friend WithEvents pnlheder2 As System.Windows.Forms.Panel
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents rtbKet As System.Windows.Forms.RichTextBox
    Friend WithEvents txbJenisBOM As System.Windows.Forms.TextBox
    Friend WithEvents txbNoDocBOM As System.Windows.Forms.TextBox
    Friend WithEvents txbNamaBOM As System.Windows.Forms.TextBox
    Friend WithEvents txbKdBOM As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GcMstBOM_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstBOM_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_BOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No_Urut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents LookupBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
