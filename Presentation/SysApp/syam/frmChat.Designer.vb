<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.textID = New System.Windows.Forms.TextBox
        Me.ckSelected = New System.Windows.Forms.CheckBox
        Me.LBUSER = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 62)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 119)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter your chat name :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 187)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 24)
        Me.TextBox2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Connect to Server"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textID
        '
        Me.textID.Location = New System.Drawing.Point(127, 5)
        Me.textID.Name = "textID"
        Me.textID.Size = New System.Drawing.Size(123, 20)
        Me.textID.TabIndex = 5
        Me.textID.Text = "Cow Boy"
        '
        'ckSelected
        '
        Me.ckSelected.AutoSize = True
        Me.ckSelected.Location = New System.Drawing.Point(7, 222)
        Me.ckSelected.Name = "ckSelected"
        Me.ckSelected.Size = New System.Drawing.Size(81, 17)
        Me.ckSelected.TabIndex = 7
        Me.ckSelected.Text = "CheckBox1"
        Me.ckSelected.UseVisualStyleBackColor = True
        '
        'LBUSER
        '
        Me.LBUSER.FormattingEnabled = True
        Me.LBUSER.Location = New System.Drawing.Point(256, 62)
        Me.LBUSER.Name = "LBUSER"
        Me.LBUSER.Size = New System.Drawing.Size(199, 21)
        Me.LBUSER.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter your chat name :"
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 249)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBUSER)
        Me.Controls.Add(Me.ckSelected)
        Me.Controls.Add(Me.textID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmChat"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textID As System.Windows.Forms.TextBox
    Friend WithEvents ckSelected As System.Windows.Forms.CheckBox
    Friend WithEvents LBUSER As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
