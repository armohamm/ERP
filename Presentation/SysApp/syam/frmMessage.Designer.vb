<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessage))
        Me.TMR = New System.Windows.Forms.Timer(Me.components)
        Me.pnlError = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblMsg = New DevExpress.XtraEditors.LabelControl
        Me.pnlInfo = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        Me.lblMsg2 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.pnlWarning = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha
        Me.pnlLoading = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha9 = New BlueActivity.Controls.ColorWithAlpha
        Me.lblMsg4 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lblMsg3 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pnlError.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWarning.SuspendLayout()
        Me.pnlLoading.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMR
        '
        Me.TMR.Interval = 1000
        '
        'pnlError
        '
        Me.pnlError.BackColor = System.Drawing.Color.Transparent
        Me.pnlError.Border = True
        Me.pnlError.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlError.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlError.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlError.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlError.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlError.Controls.Add(Me.PictureBox1)
        Me.pnlError.Controls.Add(Me.lblMsg)
        Me.pnlError.CornerRadius = 10
        Me.pnlError.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlError.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlError.Gradient = True
        Me.pnlError.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlError.GradientOffset = 1.0!
        Me.pnlError.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlError.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlError.Grayscale = False
        Me.pnlError.Image = Nothing
        Me.pnlError.ImageAlpha = 75
        Me.pnlError.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlError.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlError.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlError.Location = New System.Drawing.Point(0, 0)
        Me.pnlError.Name = "pnlError"
        Me.pnlError.Rounded = True
        Me.pnlError.Size = New System.Drawing.Size(414, 55)
        Me.pnlError.TabIndex = 8
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlError
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 170
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Red
        Me.ColorWithAlpha2.Parent = Me.pnlError
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 250
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlError
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblMsg
        '
        Me.lblMsg.Appearance.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblMsg.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg.Appearance.Options.UseFont = True
        Me.lblMsg.Appearance.Options.UseForeColor = True
        Me.lblMsg.Appearance.Options.UseTextOptions = True
        Me.lblMsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblMsg.Location = New System.Drawing.Point(79, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(323, 55)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Test"
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlInfo.Border = True
        Me.pnlInfo.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlInfo.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlInfo.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlInfo.Controls.Add(Me.lblMsg2)
        Me.pnlInfo.Controls.Add(Me.PictureBox2)
        Me.pnlInfo.CornerRadius = 10
        Me.pnlInfo.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlInfo.Gradient = True
        Me.pnlInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlInfo.GradientOffset = 1.0!
        Me.pnlInfo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlInfo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlInfo.Grayscale = False
        Me.pnlInfo.Image = Nothing
        Me.pnlInfo.ImageAlpha = 75
        Me.pnlInfo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlInfo.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlInfo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlInfo.Location = New System.Drawing.Point(0, 65)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Rounded = True
        Me.pnlInfo.Size = New System.Drawing.Size(414, 58)
        Me.pnlInfo.TabIndex = 9
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha4.Parent = Me.pnlInfo
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 150
        Me.ColorWithAlpha5.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha5.Parent = Me.pnlInfo
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.RoyalBlue
        Me.ColorWithAlpha6.Parent = Me.pnlInfo
        '
        'lblMsg2
        '
        Me.lblMsg2.Appearance.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMsg2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg2.Appearance.Options.UseFont = True
        Me.lblMsg2.Appearance.Options.UseForeColor = True
        Me.lblMsg2.Appearance.Options.UseTextOptions = True
        Me.lblMsg2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMsg2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblMsg2.Location = New System.Drawing.Point(79, 3)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(323, 55)
        Me.lblMsg2.TabIndex = 4
        Me.lblMsg2.Text = "Test2"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'pnlWarning
        '
        Me.pnlWarning.BackColor = System.Drawing.Color.Transparent
        Me.pnlWarning.Border = True
        Me.pnlWarning.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlWarning.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlWarning.Colors.Add(Me.ColorWithAlpha8)
        Me.pnlWarning.Colors.Add(Me.ColorWithAlpha9)
        Me.pnlWarning.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlWarning.Controls.Add(Me.lblMsg3)
        Me.pnlWarning.Controls.Add(Me.PictureBox3)
        Me.pnlWarning.CornerRadius = 10
        Me.pnlWarning.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlWarning.Gradient = True
        Me.pnlWarning.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlWarning.GradientOffset = 1.0!
        Me.pnlWarning.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlWarning.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlWarning.Grayscale = False
        Me.pnlWarning.Image = Nothing
        Me.pnlWarning.ImageAlpha = 75
        Me.pnlWarning.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlWarning.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlWarning.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlWarning.Location = New System.Drawing.Point(0, 129)
        Me.pnlWarning.Name = "pnlWarning"
        Me.pnlWarning.Rounded = True
        Me.pnlWarning.Size = New System.Drawing.Size(414, 58)
        Me.pnlWarning.TabIndex = 10
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha7.Parent = Me.pnlWarning
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Border = True
        Me.pnlLoading.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlLoading.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlLoading.Colors.Add(Me.ColorWithAlpha8)
        Me.pnlLoading.Colors.Add(Me.ColorWithAlpha9)
        Me.pnlLoading.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLoading.Controls.Add(Me.lblMsg4)
        Me.pnlLoading.Controls.Add(Me.PictureBox4)
        Me.pnlLoading.CornerRadius = 10
        Me.pnlLoading.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlLoading.Gradient = True
        Me.pnlLoading.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlLoading.GradientOffset = 1.0!
        Me.pnlLoading.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLoading.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLoading.Grayscale = False
        Me.pnlLoading.Image = Nothing
        Me.pnlLoading.ImageAlpha = 75
        Me.pnlLoading.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlLoading.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlLoading.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLoading.Location = New System.Drawing.Point(0, 191)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Rounded = True
        Me.pnlLoading.Size = New System.Drawing.Size(414, 58)
        Me.pnlLoading.TabIndex = 11
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 150
        Me.ColorWithAlpha8.Color = System.Drawing.Color.Silver
        Me.ColorWithAlpha8.Parent = Me.pnlWarning
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 255
        Me.ColorWithAlpha9.Color = System.Drawing.SystemColors.MenuHighlight
        Me.ColorWithAlpha9.Parent = Me.pnlWarning
        '
        'lblMsg4
        '
        Me.lblMsg4.Appearance.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg4.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblMsg4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg4.Appearance.Options.UseFont = True
        Me.lblMsg4.Appearance.Options.UseForeColor = True
        Me.lblMsg4.Appearance.Options.UseTextOptions = True
        Me.lblMsg4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMsg4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblMsg4.Location = New System.Drawing.Point(79, 2)
        Me.lblMsg4.Name = "lblMsg4"
        Me.lblMsg4.Size = New System.Drawing.Size(323, 55)
        Me.lblMsg4.TabIndex = 5
        Me.lblMsg4.Text = "Test2"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'lblMsg3
        '
        Me.lblMsg3.Appearance.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg3.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMsg3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg3.Appearance.Options.UseFont = True
        Me.lblMsg3.Appearance.Options.UseForeColor = True
        Me.lblMsg3.Appearance.Options.UseTextOptions = True
        Me.lblMsg3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMsg3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblMsg3.Location = New System.Drawing.Point(79, 2)
        Me.lblMsg3.Name = "lblMsg3"
        Me.lblMsg3.Size = New System.Drawing.Size(323, 55)
        Me.lblMsg3.TabIndex = 5
        Me.lblMsg3.Text = "Test2"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 56)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.pnlWarning)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMessage"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.pnlError.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWarning.ResumeLayout(False)
        Me.pnlLoading.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TMR As System.Windows.Forms.Timer
    Friend WithEvents pnlError As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfo As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblMsg2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlWarning As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha9 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblMsg3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlLoading As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents lblMsg4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
