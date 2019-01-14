<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOTP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOTP))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdCetak = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ckDelete = New DevExpress.XtraEditors.CheckEdit
        Me.cmdGenerated = New DevExpress.XtraEditors.SimpleButton
        Me.lblhasil = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ckDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.ckDelete)
        Me.pnl.Controls.Add(Me.cmdGenerated)
        Me.pnl.Controls.Add(Me.lblhasil)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(2, 2)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(443, 156)
        Me.pnl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdCetak)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 36)
        Me.Panel1.TabIndex = 140
        '
        'cmdCetak
        '
        Me.cmdCetak.Image = CType(resources.GetObject("cmdCetak.Image"), System.Drawing.Image)
        Me.cmdCetak.Location = New System.Drawing.Point(282, 2)
        Me.cmdCetak.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdCetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCetak.Name = "cmdCetak"
        Me.cmdCetak.Size = New System.Drawing.Size(75, 31)
        Me.cmdCetak.TabIndex = 140
        Me.cmdCetak.Text = "Cetak"
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(363, 2)
        Me.cmdClose.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 30)
        Me.cmdClose.TabIndex = 139
        Me.cmdClose.Text = "Tutup"
        '
        'ckDelete
        '
        Me.ckDelete.Location = New System.Drawing.Point(3, 97)
        Me.ckDelete.Name = "ckDelete"
        Me.ckDelete.Properties.Caption = "Hapus Data Password Sebelumnya"
        Me.ckDelete.Size = New System.Drawing.Size(195, 19)
        Me.ckDelete.TabIndex = 139
        '
        'cmdGenerated
        '
        Me.cmdGenerated.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerated.Appearance.Options.UseFont = True
        Me.cmdGenerated.Location = New System.Drawing.Point(173, 41)
        Me.cmdGenerated.Name = "cmdGenerated"
        Me.cmdGenerated.Size = New System.Drawing.Size(104, 25)
        Me.cmdGenerated.TabIndex = 138
        Me.cmdGenerated.Text = "GENERATE"
        '
        'lblhasil
        '
        Me.lblhasil.Location = New System.Drawing.Point(41, 69)
        Me.lblhasil.Name = "lblhasil"
        Me.lblhasil.Size = New System.Drawing.Size(363, 23)
        Me.lblhasil.TabIndex = 137
        Me.lblhasil.Text = "( IDLE )"
        Me.lblhasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 34)
        Me.Panel2.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM OTP GENERATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'frmOTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ckDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ckDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdGenerated As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblhasil As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCetak As DevExpress.XtraEditors.SimpleButton
End Class
