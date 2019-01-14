<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha9 = New BlueActivity.Controls.ColorWithAlpha
        Me.pnlLogin = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.cmdkeluar = New DevExpress.XtraEditors.SimpleButton
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit
        Me.pnlRole = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.layRole = New System.Windows.Forms.TableLayoutPanel
        Me.lblPilRol = New DevExpress.XtraEditors.LabelControl
        Me.pnlLogin.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRole.SuspendLayout()
        Me.layRole.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.Yellow
        Me.ColorWithAlpha8.Parent = Nothing
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 100
        Me.ColorWithAlpha9.Color = System.Drawing.Color.Yellow
        Me.ColorWithAlpha9.Parent = Nothing
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.Border = True
        Me.pnlLogin.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlLogin.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlLogin.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlLogin.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLogin.Controls.Add(Me.cmdkeluar)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.CornerRadius = 20
        Me.pnlLogin.Corners = CType((BlueActivity.Controls.Corner.BottomLeft Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlLogin.Gradient = True
        Me.pnlLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlLogin.GradientOffset = 1.0!
        Me.pnlLogin.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLogin.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLogin.Grayscale = False
        Me.pnlLogin.Image = Nothing
        Me.pnlLogin.ImageAlpha = 75
        Me.pnlLogin.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlLogin.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlLogin.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLogin.Location = New System.Drawing.Point(22, 159)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Rounded = True
        Me.pnlLogin.Size = New System.Drawing.Size(250, 134)
        Me.pnlLogin.TabIndex = 7
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 250
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Black
        Me.ColorWithAlpha1.Parent = Me.pnlLogin
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 120
        Me.ColorWithAlpha2.Color = System.Drawing.Color.WhiteSmoke
        Me.ColorWithAlpha2.Parent = Me.pnlLogin
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cmdkeluar.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.cmdkeluar.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.cmdkeluar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.cmdkeluar.Appearance.Options.UseBackColor = True
        Me.cmdkeluar.Appearance.Options.UseBorderColor = True
        Me.cmdkeluar.Appearance.Options.UseFont = True
        Me.cmdkeluar.Appearance.Options.UseTextOptions = True
        Me.cmdkeluar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmdkeluar.Image = CType(resources.GetObject("cmdkeluar.Image"), System.Drawing.Image)
        Me.cmdkeluar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdkeluar.Location = New System.Drawing.Point(21, 96)
        Me.cmdkeluar.LookAndFeel.SkinName = "Black"
        Me.cmdkeluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(72, 28)
        Me.cmdkeluar.TabIndex = 19
        Me.cmdkeluar.Text = "Keluar"
        '
        'btnLogin
        '
        Me.btnLogin.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.btnLogin.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnLogin.Appearance.Options.UseBackColor = True
        Me.btnLogin.Appearance.Options.UseBorderColor = True
        Me.btnLogin.Appearance.Options.UseFont = True
        Me.btnLogin.Appearance.Options.UseTextOptions = True
        Me.btnLogin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btnLogin.Location = New System.Drawing.Point(157, 96)
        Me.btnLogin.LookAndFeel.SkinName = "Black"
        Me.btnLogin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(72, 28)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(22, 70)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.Properties.UseParentBackground = True
        Me.txtPassword.Size = New System.Drawing.Size(208, 20)
        Me.txtPassword.TabIndex = 14
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(21, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.txtUsername.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsername.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtUsername.Properties.UseParentBackground = True
        Me.txtUsername.Size = New System.Drawing.Size(208, 20)
        Me.txtUsername.TabIndex = 13
        '
        'pnlRole
        '
        Me.pnlRole.BackColor = System.Drawing.Color.Transparent
        Me.pnlRole.Border = True
        Me.pnlRole.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlRole.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlRole.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlRole.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlRole.Controls.Add(Me.layRole)
        Me.pnlRole.CornerRadius = 6
        Me.pnlRole.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlRole.Gradient = True
        Me.pnlRole.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlRole.GradientOffset = 1.0!
        Me.pnlRole.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlRole.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlRole.Grayscale = False
        Me.pnlRole.Image = Nothing
        Me.pnlRole.ImageAlpha = 75
        Me.pnlRole.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlRole.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlRole.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlRole.Location = New System.Drawing.Point(278, 35)
        Me.pnlRole.Name = "pnlRole"
        Me.pnlRole.Rounded = True
        Me.pnlRole.Size = New System.Drawing.Size(238, 214)
        Me.pnlRole.TabIndex = 15
        Me.pnlRole.Visible = False
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 100
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha3.Parent = Me.pnlRole
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 100
        Me.ColorWithAlpha4.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha4.Parent = Me.pnlRole
        '
        'layRole
        '
        Me.layRole.BackColor = System.Drawing.Color.Transparent
        Me.layRole.ColumnCount = 1
        Me.layRole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layRole.Controls.Add(Me.lblPilRol, 0, 0)
        Me.layRole.Location = New System.Drawing.Point(47, 14)
        Me.layRole.Name = "layRole"
        Me.layRole.RowCount = 1
        Me.layRole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.layRole.Size = New System.Drawing.Size(151, 56)
        Me.layRole.TabIndex = 0
        '
        'lblPilRol
        '
        Me.lblPilRol.Appearance.BackColor = System.Drawing.Color.DarkRed
        Me.lblPilRol.Appearance.BorderColor = System.Drawing.Color.SeaShell
        Me.lblPilRol.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPilRol.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblPilRol.Appearance.Options.UseBackColor = True
        Me.lblPilRol.Appearance.Options.UseBorderColor = True
        Me.lblPilRol.Appearance.Options.UseFont = True
        Me.lblPilRol.Appearance.Options.UseForeColor = True
        Me.lblPilRol.Appearance.Options.UseTextOptions = True
        Me.lblPilRol.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblPilRol.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPilRol.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblPilRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPilRol.Location = New System.Drawing.Point(3, 3)
        Me.lblPilRol.Name = "lblPilRol"
        Me.lblPilRol.Size = New System.Drawing.Size(145, 23)
        Me.lblPilRol.TabIndex = 17
        Me.lblPilRol.Text = "Role's Selection"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(649, 316)
        Me.Controls.Add(Me.pnlRole)
        Me.Controls.Add(Me.pnlLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRole.ResumeLayout(False)
        Me.layRole.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha9 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents pnlLogin As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlRole As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents layRole As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPilRol As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdkeluar As DevExpress.XtraEditors.SimpleButton
End Class
