<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatalPO
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatalPO))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblStatusSP = New System.Windows.Forms.Label
        Me.txtKeputusan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDisetujui = New DevExpress.XtraEditors.TextEdit
        Me.txtPelapor = New DevExpress.XtraEditors.TextEdit
        Me.txtNamaCustomer = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.txtTgl = New DevExpress.XtraEditors.TextEdit
        Me.txtAlasan = New DevExpress.XtraEditors.MemoEdit
        Me.txtSP = New DevExpress.XtraEditors.ButtonEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtKeputusan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisetujui.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPelapor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(705, 326)
        Me.pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblStatusSP)
        Me.Panel3.Controls.Add(Me.txtKeputusan)
        Me.Panel3.Controls.Add(Me.txtDisetujui)
        Me.Panel3.Controls.Add(Me.txtPelapor)
        Me.Panel3.Controls.Add(Me.txtNamaCustomer)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Controls.Add(Me.txtTgl)
        Me.Panel3.Controls.Add(Me.txtAlasan)
        Me.Panel3.Controls.Add(Me.txtSP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(147, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 289)
        Me.Panel3.TabIndex = 19
        '
        'lblStatusSP
        '
        Me.lblStatusSP.AutoSize = True
        Me.lblStatusSP.ForeColor = System.Drawing.Color.Red
        Me.lblStatusSP.Location = New System.Drawing.Point(172, 47)
        Me.lblStatusSP.Name = "lblStatusSP"
        Me.lblStatusSP.Size = New System.Drawing.Size(11, 13)
        Me.lblStatusSP.TabIndex = 12
        Me.lblStatusSP.Text = ")"
        '
        'txtKeputusan
        '
        Me.txtKeputusan.Location = New System.Drawing.Point(6, 87)
        Me.txtKeputusan.Name = "txtKeputusan"
        Me.txtKeputusan.Properties.AutoComplete = False
        Me.txtKeputusan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKeputusan.Properties.Items.AddRange(New Object() {"BATAL", "PERBAIKAN"})
        Me.txtKeputusan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtKeputusan.Size = New System.Drawing.Size(160, 20)
        Me.txtKeputusan.TabIndex = 10
        '
        'txtDisetujui
        '
        Me.txtDisetujui.Location = New System.Drawing.Point(6, 201)
        Me.txtDisetujui.Name = "txtDisetujui"
        Me.txtDisetujui.Size = New System.Drawing.Size(473, 20)
        Me.txtDisetujui.TabIndex = 8
        '
        'txtPelapor
        '
        Me.txtPelapor.Location = New System.Drawing.Point(6, 180)
        Me.txtPelapor.Name = "txtPelapor"
        Me.txtPelapor.Size = New System.Drawing.Size(473, 20)
        Me.txtPelapor.TabIndex = 7
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Location = New System.Drawing.Point(6, 65)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaCustomer.Size = New System.Drawing.Size(473, 20)
        Me.txtNamaCustomer.TabIndex = 5
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(6, 2)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(160, 20)
        Me.txtNomor.TabIndex = 3
        '
        'txtTgl
        '
        Me.txtTgl.Location = New System.Drawing.Point(6, 23)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTgl.Properties.Appearance.Options.UseBackColor = True
        Me.txtTgl.Size = New System.Drawing.Size(160, 20)
        Me.txtTgl.TabIndex = 2
        '
        'txtAlasan
        '
        Me.txtAlasan.Location = New System.Drawing.Point(6, 108)
        Me.txtAlasan.Name = "txtAlasan"
        Me.txtAlasan.Size = New System.Drawing.Size(473, 71)
        Me.txtAlasan.TabIndex = 6
        '
        'txtSP
        '
        Me.txtSP.Location = New System.Drawing.Point(6, 44)
        Me.txtSP.Name = "txtSP"
        Me.txtSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtSP.Size = New System.Drawing.Size(160, 20)
        Me.txtSP.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 289)
        Me.Panel2.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Disetujui Oleh : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama Pelapor : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 74)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alasan : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "* Keputusan : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Supplier : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "* Nomor PO : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tanggal : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nomor : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Size = New System.Drawing.Size(705, 37)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM PEMBATALAN/PERBAIKAN PO"
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
        'frmBatalPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 338)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBatalPO"
        Me.Text = "PerbaikanDPM"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtKeputusan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisetujui.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPelapor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblStatusSP As System.Windows.Forms.Label
    Friend WithEvents txtKeputusan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDisetujui As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPelapor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTgl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlasan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSP As DevExpress.XtraEditors.ButtonEdit
End Class
