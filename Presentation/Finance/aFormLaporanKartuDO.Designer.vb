<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormLaporanKartuDO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormLaporanKartuDO))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.pnlButton = New System.Windows.Forms.Panel
        Me.btnPrev = New DevExpress.XtraEditors.SimpleButton
        Me.btnCetak = New DevExpress.XtraEditors.SimpleButton
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.pnlFilter = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnlKartu = New System.Windows.Forms.Panel
        Me.lookupKartu = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlValuta = New System.Windows.Forms.Panel
        Me.lookupValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pnlPeriode = New System.Windows.Forms.Panel
        Me.lookupPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.pnlButton.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlKartu.SuspendLayout()
        CType(Me.lookupKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlValuta.SuspendLayout()
        CType(Me.lookupValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlPeriode.SuspendLayout()
        CType(Me.lookupPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel20)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Location = New System.Drawing.Point(16, 24)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(400, 192)
        Me.pnl.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Controls.Add(Me.Panel19)
        Me.Panel20.Controls.Add(Me.Panel10)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(0, 30)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(400, 142)
        Me.Panel20.TabIndex = 150
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.pnlButton)
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 85)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(400, 30)
        Me.Panel21.TabIndex = 152
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnPrev)
        Me.pnlButton.Controls.Add(Me.btnCetak)
        Me.pnlButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlButton.Location = New System.Drawing.Point(100, 0)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(200, 30)
        Me.pnlButton.TabIndex = 154
        '
        'btnPrev
        '
        Me.btnPrev.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnPrev.Appearance.Options.UseFont = True
        Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrev.Location = New System.Drawing.Point(110, 0)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 30)
        Me.btnPrev.TabIndex = 156
        Me.btnPrev.Text = "Preview"
        '
        'btnCetak
        '
        Me.btnCetak.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCetak.Appearance.Options.UseFont = True
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCetak.Location = New System.Drawing.Point(0, 0)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(90, 30)
        Me.btnCetak.TabIndex = 155
        Me.btnCetak.Text = "Cetak"
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(100, 30)
        Me.Panel22.TabIndex = 152
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 80)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(400, 5)
        Me.Panel19.TabIndex = 18
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.pnlFilter)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(400, 80)
        Me.Panel10.TabIndex = 12
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.Panel3)
        Me.pnlFilter.Controls.Add(Me.Panel9)
        Me.pnlFilter.Controls.Add(Me.Panel4)
        Me.pnlFilter.Controls.Add(Me.Panel8)
        Me.pnlFilter.Controls.Add(Me.Panel2)
        Me.pnlFilter.Controls.Add(Me.Panel7)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilter.Location = New System.Drawing.Point(100, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(200, 80)
        Me.pnlFilter.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnlKartu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 20)
        Me.Panel3.TabIndex = 18
        '
        'pnlKartu
        '
        Me.pnlKartu.Controls.Add(Me.lookupKartu)
        Me.pnlKartu.Controls.Add(Me.Label6)
        Me.pnlKartu.Controls.Add(Me.Label7)
        Me.pnlKartu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlKartu.Location = New System.Drawing.Point(0, 0)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(200, 20)
        Me.pnlKartu.TabIndex = 7
        '
        'lookupKartu
        '
        Me.lookupKartu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookupKartu.EnterMoveNextControl = True
        Me.lookupKartu.Location = New System.Drawing.Point(60, 0)
        Me.lookupKartu.Name = "lookupKartu"
        Me.lookupKartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupKartu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lookupKartu.Properties.NullText = "[Kartu]"
        Me.lookupKartu.Properties.ShowFooter = False
        Me.lookupKartu.Properties.ShowHeader = False
        Me.lookupKartu.Properties.ShowPopupShadow = False
        Me.lookupKartu.Size = New System.Drawing.Size(140, 20)
        Me.lookupKartu.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Location = New System.Drawing.Point(50, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Kartu"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 5)
        Me.Panel9.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pnlValuta)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 20)
        Me.Panel4.TabIndex = 16
        '
        'pnlValuta
        '
        Me.pnlValuta.Controls.Add(Me.lookupValuta)
        Me.pnlValuta.Controls.Add(Me.Label3)
        Me.pnlValuta.Controls.Add(Me.Label5)
        Me.pnlValuta.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlValuta.Location = New System.Drawing.Point(0, 0)
        Me.pnlValuta.Name = "pnlValuta"
        Me.pnlValuta.Size = New System.Drawing.Size(175, 20)
        Me.pnlValuta.TabIndex = 3
        '
        'lookupValuta
        '
        Me.lookupValuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookupValuta.EnterMoveNextControl = True
        Me.lookupValuta.Location = New System.Drawing.Point(60, 0)
        Me.lookupValuta.Name = "lookupValuta"
        Me.lookupValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Valuta")})
        Me.lookupValuta.Properties.NullText = "[Valuta]"
        Me.lookupValuta.Properties.ShowFooter = False
        Me.lookupValuta.Properties.ShowHeader = False
        Me.lookupValuta.Properties.ShowPopupShadow = False
        Me.lookupValuta.Size = New System.Drawing.Size(115, 20)
        Me.lookupValuta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(50, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valuta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 25)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 5)
        Me.Panel8.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlPeriode)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 20)
        Me.Panel2.TabIndex = 14
        '
        'pnlPeriode
        '
        Me.pnlPeriode.Controls.Add(Me.lookupPeriode)
        Me.pnlPeriode.Controls.Add(Me.Label2)
        Me.pnlPeriode.Controls.Add(Me.Label1)
        Me.pnlPeriode.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlPeriode.Location = New System.Drawing.Point(0, 0)
        Me.pnlPeriode.Name = "pnlPeriode"
        Me.pnlPeriode.Size = New System.Drawing.Size(200, 20)
        Me.pnlPeriode.TabIndex = 2
        '
        'lookupPeriode
        '
        Me.lookupPeriode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lookupPeriode.EnterMoveNextControl = True
        Me.lookupPeriode.Location = New System.Drawing.Point(60, 0)
        Me.lookupPeriode.Name = "lookupPeriode"
        Me.lookupPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lookupPeriode.Properties.DisplayFormat.FormatString = "MMMM yyyy"
        Me.lookupPeriode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lookupPeriode.Properties.EditFormat.FormatString = "MMMM yyyy"
        Me.lookupPeriode.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lookupPeriode.Properties.NullText = "[Periode]"
        Me.lookupPeriode.Properties.ShowFooter = False
        Me.lookupPeriode.Properties.ShowHeader = False
        Me.lookupPeriode.Properties.ShowPopupShadow = False
        Me.lookupPeriode.Size = New System.Drawing.Size(140, 20)
        Me.lookupPeriode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(50, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Periode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 5)
        Me.Panel7.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(100, 80)
        Me.Panel11.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 20)
        Me.Panel1.TabIndex = 148
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 30)
        Me.Panel5.TabIndex = 147
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "         LAPORAN KARTU DO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aFormLaporanKartuDO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(466, 260)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormLaporanKartuDO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Laporan Kartu DO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.pnlButton.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlKartu.ResumeLayout(False)
        CType(Me.lookupKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlValuta.ResumeLayout(False)
        CType(Me.lookupValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlPeriode.ResumeLayout(False)
        CType(Me.lookupPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents pnlButton As System.Windows.Forms.Panel
    Friend WithEvents btnPrev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents lookupKartu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlValuta As System.Windows.Forms.Panel
    Friend WithEvents lookupValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlPeriode As System.Windows.Forms.Panel
    Friend WithEvents lookupPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
End Class
