<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGantiPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGantiPassword))
        Me.pnlDasar = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtRetype = New System.Windows.Forms.TextBox
        Me.txtPasswdBaru = New System.Windows.Forms.TextBox
        Me.txtPaswdLama = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlControl = New System.Windows.Forms.Panel
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.AlphaGradientPanel2 = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha11 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha9 = New BlueActivity.Controls.ColorWithAlpha
        Me.pnlDasar.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDasar
        '
        Me.pnlDasar.Controls.Add(Me.pnlTengah)
        Me.pnlDasar.Controls.Add(Me.pnlControl)
        Me.pnlDasar.Controls.Add(Me.pnlTitle)
        Me.pnlDasar.Location = New System.Drawing.Point(7, 8)
        Me.pnlDasar.Name = "pnlDasar"
        Me.pnlDasar.Size = New System.Drawing.Size(427, 169)
        Me.pnlDasar.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(427, 99)
        Me.pnlTengah.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtRetype)
        Me.Panel1.Controls.Add(Me.txtPasswdBaru)
        Me.Panel1.Controls.Add(Me.txtPaswdLama)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 97)
        Me.Panel1.TabIndex = 2
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(136, 61)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRetype.Size = New System.Drawing.Size(289, 20)
        Me.txtRetype.TabIndex = 6
        '
        'txtPasswdBaru
        '
        Me.txtPasswdBaru.Location = New System.Drawing.Point(136, 30)
        Me.txtPasswdBaru.Name = "txtPasswdBaru"
        Me.txtPasswdBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswdBaru.Size = New System.Drawing.Size(289, 20)
        Me.txtPasswdBaru.TabIndex = 3
        '
        'txtPaswdLama
        '
        Me.txtPaswdLama.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPaswdLama.Location = New System.Drawing.Point(136, 0)
        Me.txtPaswdLama.Name = "txtPaswdLama"
        Me.txtPaswdLama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPaswdLama.Size = New System.Drawing.Size(289, 20)
        Me.txtPaswdLama.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 97)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ulang Password : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password Baru : "
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
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Lama : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlControl.Controls.Add(Me.cmdOk)
        Me.pnlControl.Controls.Add(Me.cmdCancel)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControl.Location = New System.Drawing.Point(0, 136)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(427, 33)
        Me.pnlControl.TabIndex = 2
        '
        'cmdOk
        '
        Me.cmdOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.cmdOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.Location = New System.Drawing.Point(275, 0)
        Me.cmdOk.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdOk.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(76, 33)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Simpan"
        '
        'cmdCancel
        '
        Me.cmdCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(351, 0)
        Me.cmdCancel.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(76, 33)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Batal"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.Controls.Add(Me.lblJudul)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(427, 37)
        Me.pnlTitle.TabIndex = 0
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(40, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(204, 37)
        Me.lblJudul.TabIndex = 12
        Me.lblJudul.Text = " GANTI PASSWORD"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.IndianRed
        Me.ColorWithAlpha5.Parent = Nothing
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha6.Parent = Nothing
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.PeachPuff
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel2.Border = True
        Me.AlphaGradientPanel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha8)
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha11)
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha9)
        Me.AlphaGradientPanel2.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.pnlDasar)
        Me.AlphaGradientPanel2.CornerRadius = 20
        Me.AlphaGradientPanel2.Corners = BlueActivity.Controls.Corner.None
        Me.AlphaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlphaGradientPanel2.Gradient = True
        Me.AlphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel2.GradientOffset = 1.0!
        Me.AlphaGradientPanel2.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel2.Grayscale = False
        Me.AlphaGradientPanel2.Image = Nothing
        Me.AlphaGradientPanel2.ImageAlpha = 75
        Me.AlphaGradientPanel2.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel2.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel2.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New System.Drawing.Size(442, 186)
        Me.AlphaGradientPanel2.TabIndex = 1
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColorWithAlpha8.Parent = Me.AlphaGradientPanel2
        '
        'ColorWithAlpha11
        '
        Me.ColorWithAlpha11.Alpha = 255
        Me.ColorWithAlpha11.Color = System.Drawing.Color.Gray
        Me.ColorWithAlpha11.Parent = Me.AlphaGradientPanel2
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 255
        Me.ColorWithAlpha9.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColorWithAlpha9.Parent = Me.AlphaGradientPanel2
        '
        'frmGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 186)
        Me.Controls.Add(Me.AlphaGradientPanel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGantiPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDasar.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDasar As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPasswdBaru As System.Windows.Forms.TextBox
    Friend WithEvents txtPaswdLama As System.Windows.Forms.TextBox
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents txtRetype As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlphaGradientPanel2 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha9 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorWithAlpha11 As BlueActivity.Controls.ColorWithAlpha
End Class
