<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnkrip
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
        Me.txtenkrip = New System.Windows.Forms.RichTextBox
        Me.txtdekrip = New System.Windows.Forms.RichTextBox
        Me.cmdEkrip = New System.Windows.Forms.Button
        Me.cmdDekrip = New System.Windows.Forms.Button
        Me.txtkey = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtenkrip
        '
        Me.txtenkrip.Location = New System.Drawing.Point(12, 23)
        Me.txtenkrip.Name = "txtenkrip"
        Me.txtenkrip.Size = New System.Drawing.Size(767, 122)
        Me.txtenkrip.TabIndex = 1
        Me.txtenkrip.Text = ""
        '
        'txtdekrip
        '
        Me.txtdekrip.Location = New System.Drawing.Point(12, 178)
        Me.txtdekrip.Name = "txtdekrip"
        Me.txtdekrip.Size = New System.Drawing.Size(767, 115)
        Me.txtdekrip.TabIndex = 2
        Me.txtdekrip.Text = ""
        '
        'cmdEkrip
        '
        Me.cmdEkrip.Location = New System.Drawing.Point(785, 23)
        Me.cmdEkrip.Name = "cmdEkrip"
        Me.cmdEkrip.Size = New System.Drawing.Size(77, 52)
        Me.cmdEkrip.TabIndex = 3
        Me.cmdEkrip.Text = "Enkrip"
        Me.cmdEkrip.UseVisualStyleBackColor = True
        '
        'cmdDekrip
        '
        Me.cmdDekrip.Location = New System.Drawing.Point(785, 81)
        Me.cmdDekrip.Name = "cmdDekrip"
        Me.cmdDekrip.Size = New System.Drawing.Size(77, 64)
        Me.cmdDekrip.TabIndex = 4
        Me.cmdDekrip.Text = "Dekrip"
        Me.cmdDekrip.UseVisualStyleBackColor = True
        '
        'txtkey
        '
        Me.txtkey.Location = New System.Drawing.Point(12, 151)
        Me.txtkey.Name = "txtkey"
        Me.txtkey.Size = New System.Drawing.Size(767, 21)
        Me.txtkey.TabIndex = 5
        '
        'frmEnkrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 302)
        Me.Controls.Add(Me.txtkey)
        Me.Controls.Add(Me.cmdDekrip)
        Me.Controls.Add(Me.cmdEkrip)
        Me.Controls.Add(Me.txtdekrip)
        Me.Controls.Add(Me.txtenkrip)
        Me.Name = "frmEnkrip"
        Me.Text = "frmEnkrip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtenkrip As System.Windows.Forms.RichTextBox
    Friend WithEvents txtdekrip As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdEkrip As System.Windows.Forms.Button
    Friend WithEvents cmdDekrip As System.Windows.Forms.Button
    Friend WithEvents txtkey As System.Windows.Forms.TextBox
End Class
