<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportHutangLain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportHutangLain))
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.KartuX = New DevExpress.XtraEditors.LookUpEdit
        Me.Valuta = New DevExpress.XtraEditors.LookUpEdit
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.CERekapHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CEDetailHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CEAgingHutang = New DevExpress.XtraEditors.CheckEdit
        Me.CEKartuHutang = New DevExpress.XtraEditors.CheckEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExe = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.lookupBulanAwal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6.SuspendLayout()
        CType(Me.KartuX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.CERekapHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEDetailHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEAgingHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEKartuHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lookupBulanAwal)
        Me.Panel6.Controls.Add(Me.KartuX)
        Me.Panel6.Controls.Add(Me.Valuta)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(104, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(197, 66)
        Me.Panel6.TabIndex = 5
        '
        'KartuX
        '
        Me.KartuX.Location = New System.Drawing.Point(0, 0)
        Me.KartuX.Name = "KartuX"
        Me.KartuX.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.KartuX.Properties.Appearance.Options.UseBackColor = True
        Me.KartuX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KartuX.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.KartuX.Properties.NullText = ""
        Me.KartuX.Size = New System.Drawing.Size(175, 20)
        Me.KartuX.TabIndex = 29
        '
        'Valuta
        '
        Me.Valuta.Location = New System.Drawing.Point(0, 21)
        Me.Valuta.Name = "Valuta"
        Me.Valuta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Valuta.Properties.Appearance.Options.UseBackColor = True
        Me.Valuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Valuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama Valuta")})
        Me.Valuta.Properties.NullText = ""
        Me.Valuta.Size = New System.Drawing.Size(175, 20)
        Me.Valuta.TabIndex = 27
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(350, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "LAPORAN HUTANG LAIN-LAIN"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 66)
        Me.Panel2.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(104, 66)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(29, 42)
        Me.LabelControl3.LookAndFeel.SkinName = "Black"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Dari Tgl. : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(0, 21)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Valuta : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.LookAndFeel.SkinName = "Black"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Kartu  : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 37)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel11)
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(2, 1)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(321, 291)
        Me.pnl.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.Controls.Add(Me.lblError)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 263)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(321, 28)
        Me.Panel11.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 8)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "..."
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.SplitContainerControl1)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 103)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(321, 188)
        Me.Panel8.TabIndex = 7
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CERekapHutang)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CEDetailHutang)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEAgingHutang)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.CEKartuHutang)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(321, 117)
        Me.SplitContainerControl1.SplitterPosition = 58
        Me.SplitContainerControl1.TabIndex = 27
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'CERekapHutang
        '
        Me.CERekapHutang.EditValue = True
        Me.CERekapHutang.Location = New System.Drawing.Point(102, 3)
        Me.CERekapHutang.Name = "CERekapHutang"
        Me.CERekapHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CERekapHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CERekapHutang.Properties.Appearance.Options.UseFont = True
        Me.CERekapHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CERekapHutang.Properties.Caption = "Rekapitulasi"
        Me.CERekapHutang.Size = New System.Drawing.Size(175, 21)
        Me.CERekapHutang.TabIndex = 24
        '
        'CEDetailHutang
        '
        Me.CEDetailHutang.Location = New System.Drawing.Point(102, 29)
        Me.CEDetailHutang.Name = "CEDetailHutang"
        Me.CEDetailHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEDetailHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEDetailHutang.Properties.Appearance.Options.UseFont = True
        Me.CEDetailHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEDetailHutang.Properties.Caption = "Detail Hutang / Piutang"
        Me.CEDetailHutang.Size = New System.Drawing.Size(175, 21)
        Me.CEDetailHutang.TabIndex = 25
        '
        'CEAgingHutang
        '
        Me.CEAgingHutang.Location = New System.Drawing.Point(102, 33)
        Me.CEAgingHutang.Name = "CEAgingHutang"
        Me.CEAgingHutang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEAgingHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEAgingHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEAgingHutang.Properties.Appearance.Options.UseBackColor = True
        Me.CEAgingHutang.Properties.Appearance.Options.UseFont = True
        Me.CEAgingHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEAgingHutang.Properties.Caption = "Aging"
        Me.CEAgingHutang.Size = New System.Drawing.Size(175, 21)
        Me.CEAgingHutang.TabIndex = 29
        Me.CEAgingHutang.Visible = False
        '
        'CEKartuHutang
        '
        Me.CEKartuHutang.EditValue = True
        Me.CEKartuHutang.Enabled = False
        Me.CEKartuHutang.Location = New System.Drawing.Point(102, 7)
        Me.CEKartuHutang.Name = "CEKartuHutang"
        Me.CEKartuHutang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CEKartuHutang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEKartuHutang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CEKartuHutang.Properties.Appearance.Options.UseBackColor = True
        Me.CEKartuHutang.Properties.Appearance.Options.UseFont = True
        Me.CEKartuHutang.Properties.Appearance.Options.UseForeColor = True
        Me.CEKartuHutang.Properties.Caption = "Kartu"
        Me.CEKartuHutang.Size = New System.Drawing.Size(175, 21)
        Me.CEKartuHutang.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdExe)
        Me.Panel3.Controls.Add(Me.cmdPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(321, 71)
        Me.Panel3.TabIndex = 26
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(154, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 6
        '
        'cmdExe
        '
        Me.cmdExe.Image = CType(resources.GetObject("cmdExe.Image"), System.Drawing.Image)
        Me.cmdExe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExe.Location = New System.Drawing.Point(110, 3)
        Me.cmdExe.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdExe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExe.Name = "cmdExe"
        Me.cmdExe.Size = New System.Drawing.Size(38, 38)
        Me.cmdExe.TabIndex = 10
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(198, 3)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 11
        '
        'lookupBulanAwal
        '
        Me.lookupBulanAwal.Location = New System.Drawing.Point(0, 42)
        Me.lookupBulanAwal.Name = "lookupBulanAwal"
        Me.lookupBulanAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBulanAwal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Periode")})
        Me.lookupBulanAwal.Properties.NullText = "[Periode]"
        Me.lookupBulanAwal.Size = New System.Drawing.Size(175, 20)
        Me.lookupBulanAwal.TabIndex = 52
        '
        'frmReportHutangLain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 374)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmReportHutangLain"
        Me.Text = "frmReportHutangLain"
        Me.Panel6.ResumeLayout(False)
        CType(Me.KartuX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.CERekapHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEDetailHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEAgingHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEKartuHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.lookupBulanAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Valuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents CEDetailHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CERekapHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KartuX As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CEAgingHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CEKartuHutang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookupBulanAwal As DevExpress.XtraEditors.LookUpEdit
End Class
