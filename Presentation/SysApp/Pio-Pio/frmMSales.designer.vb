<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSales
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSales))
        Me.pnl = New System.Windows.Forms.Panel
        Me.LEWil = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNamaSales = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.LEDep = New DevExpress.XtraEditors.LookUpEdit
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.txtKet = New System.Windows.Forms.TextBox
        Me.LookUpEditArea = New DevExpress.XtraEditors.LookUpEdit
        Me.txtKodeSales = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.LEPegawai = New DevExpress.XtraEditors.LookUpEdit
        Me.pnl.SuspendLayout()
        CType(Me.LEWil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LEPegawai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.LEPegawai)
        Me.pnl.Controls.Add(Me.LEWil)
        Me.pnl.Controls.Add(Me.txtNamaSales)
        Me.pnl.Controls.Add(Me.Label22)
        Me.pnl.Controls.Add(Me.LEDep)
        Me.pnl.Controls.Add(Me.cbStatus)
        Me.pnl.Controls.Add(Me.txtKet)
        Me.pnl.Controls.Add(Me.LookUpEditArea)
        Me.pnl.Controls.Add(Me.txtKodeSales)
        Me.pnl.Controls.Add(Me.Label20)
        Me.pnl.Controls.Add(Me.Label19)
        Me.pnl.Controls.Add(Me.Label2)
        Me.pnl.Controls.Add(Me.Label6)
        Me.pnl.Controls.Add(Me.Label5)
        Me.pnl.Controls.Add(Me.Label3)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(678, 558)
        Me.pnl.TabIndex = 0
        '
        'LEWil
        '
        Me.LEWil.Location = New System.Drawing.Point(182, 127)
        Me.LEWil.Name = "LEWil"
        Me.LEWil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEWil.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Wilayah", "Nama Wilayah")})
        Me.LEWil.Properties.DisplayMember = "Nama_Wilayah"
        Me.LEWil.Properties.NullText = ""
        Me.LEWil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LEWil.Properties.ValueMember = "Kode_Wilayah"
        Me.LEWil.Size = New System.Drawing.Size(126, 20)
        Me.LEWil.TabIndex = 186
        '
        'txtNamaSales
        '
        Me.txtNamaSales.Location = New System.Drawing.Point(182, 87)
        Me.txtNamaSales.Name = "txtNamaSales"
        Me.txtNamaSales.Size = New System.Drawing.Size(186, 20)
        Me.txtNamaSales.TabIndex = 185
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(21, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 20)
        Me.Label22.TabIndex = 184
        Me.Label22.Text = "Nama Sales :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LEDep
        '
        Me.LEDep.Location = New System.Drawing.Point(182, 107)
        Me.LEDep.Name = "LEDep"
        Me.LEDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEDep.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.LEDep.Properties.DisplayMember = "Nama_Departemen"
        Me.LEDep.Properties.NullText = "[Departemen]"
        Me.LEDep.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LEDep.Properties.ValueMember = "Kd_Departemen"
        Me.LEDep.Size = New System.Drawing.Size(147, 20)
        Me.LEDep.TabIndex = 182
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(182, 187)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(140, 21)
        Me.cbStatus.TabIndex = 181
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(182, 147)
        Me.txtKet.Multiline = True
        Me.txtKet.Name = "txtKet"
        Me.txtKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKet.Size = New System.Drawing.Size(271, 40)
        Me.txtKet.TabIndex = 180
        '
        'LookUpEditArea
        '
        Me.LookUpEditArea.Location = New System.Drawing.Point(314, 127)
        Me.LookUpEditArea.Name = "LookUpEditArea"
        Me.LookUpEditArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditArea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Area", "Area")})
        Me.LookUpEditArea.Properties.DisplayMember = "Nama_Area"
        Me.LookUpEditArea.Properties.NullText = ""
        Me.LookUpEditArea.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEditArea.Properties.ValueMember = "Kode_Area"
        Me.LookUpEditArea.Size = New System.Drawing.Size(139, 20)
        Me.LookUpEditArea.TabIndex = 177
        '
        'txtKodeSales
        '
        Me.txtKodeSales.Location = New System.Drawing.Point(182, 47)
        Me.txtKodeSales.MaxLength = 10
        Me.txtKodeSales.Name = "txtKodeSales"
        Me.txtKodeSales.ReadOnly = True
        Me.txtKodeSales.Size = New System.Drawing.Size(120, 20)
        Me.txtKodeSales.TabIndex = 162
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(21, 187)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 20)
        Me.Label20.TabIndex = 157
        Me.Label20.Text = "Status :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(21, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 39)
        Me.Label19.TabIndex = 161
        Me.Label19.Text = "Keterangan :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Kode Wilayah / Area :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Departemen :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Pegawai :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Kode :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel5.Size = New System.Drawing.Size(678, 34)
        Me.Panel5.TabIndex = 141
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
        Me.Label1.Size = New System.Drawing.Size(574, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "         Master Sales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdExit)
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Location = New System.Drawing.Point(0, 695)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(569, 37)
        Me.Panel2.TabIndex = 118
        Me.Panel2.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(450, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(64, 27)
        Me.cmdExit.TabIndex = 26
        Me.cmdExit.Text = "E&Xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(347, 7)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 22
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(277, 7)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 21
        Me.cmdDelete.Text = "&Hapus"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(207, 6)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "&Simpan"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(137, 6)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 19
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(66, 6)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(62, 27)
        Me.cmdAdd.TabIndex = 18
        Me.cmdAdd.Text = "&Tambah"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'LEPegawai
        '
        Me.LEPegawai.Location = New System.Drawing.Point(182, 67)
        Me.LEPegawai.Name = "LEPegawai"
        Me.LEPegawai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEPegawai.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama Pegawai")})
        Me.LEPegawai.Properties.DisplayMember = "Nama_Pegawai"
        Me.LEPegawai.Properties.NullText = "[Pegawai]"
        Me.LEPegawai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LEPegawai.Properties.ValueMember = "Kode_Pegawai"
        Me.LEPegawai.Size = New System.Drawing.Size(147, 20)
        Me.LEPegawai.TabIndex = 187
        '
        'frmMSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1054, 732)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Name = "frmMSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Sales"
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.LEWil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.LEPegawai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents LookUpEditArea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKodeSales As System.Windows.Forms.TextBox
    Friend WithEvents LEDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSales As System.Windows.Forms.TextBox
    Friend WithEvents LEWil As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LEPegawai As DevExpress.XtraEditors.LookUpEdit
End Class
