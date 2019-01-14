<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstSopir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstSopir))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbJob = New System.Windows.Forms.ComboBox
        Me.lblKdPeg = New System.Windows.Forms.Label
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txbKdPeg = New System.Windows.Forms.TextBox
        Me.txbKdSopir = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txbNamaPeg = New System.Windows.Forms.TextBox
        Me.btnCekPeg = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txbKet = New System.Windows.Forms.TextBox
        Me.lblKdWil = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.cbJob)
        Me.pnl.Controls.Add(Me.lblKdPeg)
        Me.pnl.Controls.Add(Me.cbStatus)
        Me.pnl.Controls.Add(Me.Label5)
        Me.pnl.Controls.Add(Me.Label6)
        Me.pnl.Controls.Add(Me.txbKdPeg)
        Me.pnl.Controls.Add(Me.txbKdSopir)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Label9)
        Me.pnl.Controls.Add(Me.txbNamaPeg)
        Me.pnl.Controls.Add(Me.btnCekPeg)
        Me.pnl.Controls.Add(Me.Label7)
        Me.pnl.Controls.Add(Me.Label4)
        Me.pnl.Controls.Add(Me.Label3)
        Me.pnl.Controls.Add(Me.Label2)
        Me.pnl.Controls.Add(Me.txbKet)
        Me.pnl.Controls.Add(Me.lblKdWil)
        Me.pnl.Location = New System.Drawing.Point(12, 1)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(657, 278)
        Me.pnl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 34)
        Me.Panel1.TabIndex = 142
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
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE MASTER SOPIR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbJob
        '
        Me.cbJob.FormattingEnabled = True
        Me.cbJob.Items.AddRange(New Object() {"SOPIR", "KERNET", "KERANI"})
        Me.cbJob.Location = New System.Drawing.Point(136, 120)
        Me.cbJob.Name = "cbJob"
        Me.cbJob.Size = New System.Drawing.Size(97, 21)
        Me.cbJob.TabIndex = 141
        '
        'lblKdPeg
        '
        Me.lblKdPeg.AutoSize = True
        Me.lblKdPeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdPeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKdPeg.Location = New System.Drawing.Point(284, 72)
        Me.lblKdPeg.Name = "lblKdPeg"
        Me.lblKdPeg.Size = New System.Drawing.Size(0, 15)
        Me.lblKdPeg.TabIndex = 139
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(136, 211)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(97, 21)
        Me.cbStatus.TabIndex = 131
        Me.cbStatus.Text = "AKTIF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(24, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Status Job"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(24, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Kode Area"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txbKdPeg
        '
        Me.txbKdPeg.Location = New System.Drawing.Point(136, 69)
        Me.txbKdPeg.Name = "txbKdPeg"
        Me.txbKdPeg.ReadOnly = True
        Me.txbKdPeg.Size = New System.Drawing.Size(97, 20)
        Me.txbKdPeg.TabIndex = 126
        '
        'txbKdSopir
        '
        Me.txbKdSopir.Location = New System.Drawing.Point(136, 41)
        Me.txbKdSopir.Name = "txbKdSopir"
        Me.txbKdSopir.ReadOnly = True
        Me.txbKdSopir.Size = New System.Drawing.Size(97, 20)
        Me.txbKdSopir.TabIndex = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 37)
        Me.Panel2.TabIndex = 130
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(24, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 138
        Me.Label9.Text = "Nama"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txbNamaPeg
        '
        Me.txbNamaPeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNamaPeg.Location = New System.Drawing.Point(136, 95)
        Me.txbNamaPeg.Name = "txbNamaPeg"
        Me.txbNamaPeg.ReadOnly = True
        Me.txbNamaPeg.Size = New System.Drawing.Size(262, 20)
        Me.txbNamaPeg.TabIndex = 137
        '
        'btnCekPeg
        '
        Me.btnCekPeg.BackColor = System.Drawing.SystemColors.Control
        Me.btnCekPeg.Location = New System.Drawing.Point(242, 69)
        Me.btnCekPeg.Name = "btnCekPeg"
        Me.btnCekPeg.Size = New System.Drawing.Size(36, 23)
        Me.btnCekPeg.TabIndex = 136
        Me.btnCekPeg.Text = "Cek"
        Me.btnCekPeg.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(24, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(24, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Keterangan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(24, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Kode Pegawai"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(24, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Kode Sopir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txbKet
        '
        Me.txbKet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbKet.Location = New System.Drawing.Point(136, 147)
        Me.txbKet.Multiline = True
        Me.txbKet.Name = "txbKet"
        Me.txbKet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbKet.Size = New System.Drawing.Size(394, 58)
        Me.txbKet.TabIndex = 132
        '
        'lblKdWil
        '
        Me.lblKdWil.AutoSize = True
        Me.lblKdWil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdWil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKdWil.Location = New System.Drawing.Point(284, 123)
        Me.lblKdWil.Name = "lblKdWil"
        Me.lblKdWil.Size = New System.Drawing.Size(0, 15)
        Me.lblKdWil.TabIndex = 140
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMstSopir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 278)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstSopir"
        Me.Text = "frmMntSopir"
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbJob As System.Windows.Forms.ComboBox
    Friend WithEvents lblKdPeg As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbKdPeg As System.Windows.Forms.TextBox
    Friend WithEvents txbKdSopir As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txbNamaPeg As System.Windows.Forms.TextBox
    Friend WithEvents btnCekPeg As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txbKet As System.Windows.Forms.TextBox
    Friend WithEvents lblKdWil As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
