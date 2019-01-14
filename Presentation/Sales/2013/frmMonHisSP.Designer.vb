<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonHisSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonHisSP))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NO_SP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_sp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jml_Rp_Trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FLAG_PPN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PPn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.fromTgl = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTotal = New DevExpress.XtraEditors.SpinEdit
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(902, 370)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 72)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(902, 272)
        Me.GC.TabIndex = 127
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NO_SP, Me.Tgl_sp, Me.Nama_Customer, Me.Jml_Rp_Trans, Me.FLAG_PPN, Me.PPn})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ShowFooter = True
        '
        'NO_SP
        '
        Me.NO_SP.Caption = "Nomor SP"
        Me.NO_SP.FieldName = "No_sp"
        Me.NO_SP.Name = "NO_SP"
        Me.NO_SP.Visible = True
        Me.NO_SP.VisibleIndex = 0
        '
        'Tgl_sp
        '
        Me.Tgl_sp.Caption = "Tanggal"
        Me.Tgl_sp.FieldName = "Tgl_SP"
        Me.Tgl_sp.Name = "Tgl_sp"
        Me.Tgl_sp.Visible = True
        Me.Tgl_sp.VisibleIndex = 1
        '
        'Nama_Customer
        '
        Me.Nama_Customer.Caption = "Nama Customer"
        Me.Nama_Customer.FieldName = "Nama_Customer"
        Me.Nama_Customer.Name = "Nama_Customer"
        Me.Nama_Customer.Visible = True
        Me.Nama_Customer.VisibleIndex = 2
        '
        'Jml_Rp_Trans
        '
        Me.Jml_Rp_Trans.Caption = "Nilai Transaksi"
        Me.Jml_Rp_Trans.DisplayFormat.FormatString = "N2"
        Me.Jml_Rp_Trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Jml_Rp_Trans.FieldName = "Jml_Rp_Trans"
        Me.Jml_Rp_Trans.Name = "Jml_Rp_Trans"
        Me.Jml_Rp_Trans.Visible = True
        Me.Jml_Rp_Trans.VisibleIndex = 3
        '
        'FLAG_PPN
        '
        Me.FLAG_PPN.Caption = "Flag"
        Me.FLAG_PPN.FieldName = "FLAG_PPN"
        Me.FLAG_PPN.Name = "FLAG_PPN"
        Me.FLAG_PPN.Visible = True
        Me.FLAG_PPN.VisibleIndex = 4
        '
        'PPn
        '
        Me.PPn.Caption = "Nilai"
        Me.PPn.DisplayFormat.FormatString = "N2"
        Me.PPn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PPn.FieldName = "PPn"
        Me.PPn.Name = "PPn"
        Me.PPn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PPn.Visible = True
        Me.PPn.VisibleIndex = 5
        Me.PPn.Width = 142
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.fromTgl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 38)
        Me.Panel2.TabIndex = 126
        '
        'fromTgl
        '
        Me.fromTgl.Appearance.Options.UseTextOptions = True
        Me.fromTgl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fromTgl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.fromTgl.Dock = System.Windows.Forms.DockStyle.Left
        Me.fromTgl.Location = New System.Drawing.Point(0, 0)
        Me.fromTgl.Name = "fromTgl"
        Me.fromTgl.Size = New System.Drawing.Size(76, 38)
        Me.fromTgl.TabIndex = 0
        Me.fromTgl.Text = "Tanggal : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 34)
        Me.Panel1.TabIndex = 125
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(868, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(32, 32)
        Me.btnRefresh.TabIndex = 3
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
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MONITORING HISTORI SP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Panel3.Location = New System.Drawing.Point(0, 344)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(902, 26)
        Me.Panel3.TabIndex = 128
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.lblTotal.Location = New System.Drawing.Point(0, 4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Properties.Appearance.Options.UseBackColor = True
        Me.lblTotal.Properties.Appearance.Options.UseBorderColor = True
        Me.lblTotal.Properties.Appearance.Options.UseFont = True
        Me.lblTotal.Properties.Appearance.Options.UseForeColor = True
        Me.lblTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.lblTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.lblTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.lblTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.lblTotal.Properties.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(902, 22)
        Me.lblTotal.TabIndex = 5
        '
        'frmMonHisSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 370)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonHisSP"
        Me.Text = "frmMonHisSP"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents fromTgl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NO_SP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_sp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jml_Rp_Trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FLAG_PPN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PPn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As DevExpress.XtraEditors.SpinEdit
End Class
