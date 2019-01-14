<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcetakulangdok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcetakulangdok))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.btnCari = New DevExpress.XtraEditors.SimpleButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtalasan = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.TextBoxnama = New System.Windows.Forms.TextBox
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Appearance.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnl.Appearance.Options.UseBackColor = True
        Me.pnl.Controls.Add(Me.btnCari)
        Me.pnl.Controls.Add(Me.Button3)
        Me.pnl.Controls.Add(Me.Button2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.txtalasan)
        Me.pnl.Controls.Add(Me.ComboBox1)
        Me.pnl.Controls.Add(Me.Label32)
        Me.pnl.Controls.Add(Me.Label34)
        Me.pnl.Controls.Add(Me.Label36)
        Me.pnl.Controls.Add(Me.TextBoxnama)
        Me.pnl.Location = New System.Drawing.Point(25, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Padding = New System.Windows.Forms.Padding(3)
        Me.pnl.Size = New System.Drawing.Size(436, 143)
        Me.pnl.TabIndex = 238
        '
        'btnCari
        '
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(402, 64)
        Me.btnCari.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnCari.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(29, 20)
        Me.btnCari.TabIndex = 223
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 222
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 221
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(426, 34)
        Me.Panel5.TabIndex = 220
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(425, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "          CETAK ULANG DOKUMEN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtalasan
        '
        Me.txtalasan.Location = New System.Drawing.Point(160, 85)
        Me.txtalasan.Multiline = True
        Me.txtalasan.Name = "txtalasan"
        Me.txtalasan.Size = New System.Drawing.Size(271, 53)
        Me.txtalasan.TabIndex = 218
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"SO", "SJ", "RETUR"})
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SO", "SJ", "SURAT TARIKAN", "RETUR"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(271, 21)
        Me.ComboBox1.TabIndex = 217
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(6, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(139, 20)
        Me.Label32.TabIndex = 201
        Me.Label32.Text = "No Dokumen :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(6, 43)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 20)
        Me.Label34.TabIndex = 200
        Me.Label34.Text = "Cetak Dokumen:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(6, 84)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(139, 53)
        Me.Label36.TabIndex = 202
        Me.Label36.Text = "Alasan :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxnama
        '
        Me.TextBoxnama.BackColor = System.Drawing.Color.White
        Me.TextBoxnama.Location = New System.Drawing.Point(160, 64)
        Me.TextBoxnama.Name = "TextBoxnama"
        Me.TextBoxnama.ReadOnly = True
        Me.TextBoxnama.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxnama.TabIndex = 216
        '
        'frmcetakulangdok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 178)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmcetakulangdok"
        Me.Text = "frmcetakulangdok"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnama As System.Windows.Forms.TextBox
    Friend WithEvents txtalasan As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
End Class
