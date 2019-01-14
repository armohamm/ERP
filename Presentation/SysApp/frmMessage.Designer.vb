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
        Me.pnlAtas = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.lblMsg = New DevExpress.XtraEditors.LabelControl
        Me.pnlAtas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TMR
        '
        Me.TMR.Interval = 1000
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Transparent
        Me.pnlAtas.Border = True
        Me.pnlAtas.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAtas.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlAtas.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlAtas.Controls.Add(Me.lblMsg)
        Me.pnlAtas.CornerRadius = 10
        Me.pnlAtas.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Gradient = True
        Me.pnlAtas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlAtas.GradientOffset = 1.0!
        Me.pnlAtas.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAtas.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAtas.Grayscale = False
        Me.pnlAtas.Image = Nothing
        Me.pnlAtas.ImageAlpha = 75
        Me.pnlAtas.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlAtas.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.pnlAtas.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Rounded = True
        Me.pnlAtas.Size = New System.Drawing.Size(414, 55)
        Me.pnlAtas.TabIndex = 8
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 200
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.Desktop
        Me.ColorWithAlpha1.Parent = Me.pnlAtas
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 150
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Me.pnlAtas
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 200
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.Desktop
        Me.ColorWithAlpha3.Parent = Me.pnlAtas
        '
        'lblMsg
        '
        Me.lblMsg.Appearance.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMsg.Appearance.Image = CType(resources.GetObject("lblMsg.Appearance.Image"), System.Drawing.Image)
        Me.lblMsg.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsg.Appearance.Options.UseFont = True
        Me.lblMsg.Appearance.Options.UseForeColor = True
        Me.lblMsg.Appearance.Options.UseImage = True
        Me.lblMsg.Appearance.Options.UseTextOptions = True
        Me.lblMsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblMsg.Location = New System.Drawing.Point(12, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(402, 55)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "LabelControl1"
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 71)
        Me.Controls.Add(Me.pnlAtas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMessage"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.pnlAtas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TMR As System.Windows.Forms.Timer
    Friend WithEvents pnlAtas As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblMsg As DevExpress.XtraEditors.LabelControl
End Class
