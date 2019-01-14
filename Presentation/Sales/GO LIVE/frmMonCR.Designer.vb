<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonCR
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonCR))
        Me.GVSpring = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sisaSpring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GVSpon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CR_Spring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SisaCrSpring = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CRSpon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SisaCRSpon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GVSpring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVSpring
        '
        Me.GVSpring.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.Tanggal, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.sisaSpring})
        Me.GVSpring.GridControl = Me.GC
        Me.GVSpring.Name = "GVSpring"
        Me.GVSpring.OptionsBehavior.Editable = False
        Me.GVSpring.OptionsView.ShowFooter = True
        Me.GVSpring.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nomor SP"
        Me.GridColumn1.FieldName = "No_sp"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Tanggal
        '
        Me.Tanggal.Caption = "Tanggal"
        Me.Tanggal.FieldName = "tgl_sp"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Visible = True
        Me.Tanggal.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Total"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "JML_RP_TRANS"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nota"
        Me.GridColumn4.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Nota"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Bayar"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Bayar"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'sisaSpring
        '
        Me.sisaSpring.Caption = "Sisa"
        Me.sisaSpring.DisplayFormat.FormatString = "{0:n2}"
        Me.sisaSpring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sisaSpring.FieldName = "Sisa"
        Me.sisaSpring.Name = "sisaSpring"
        Me.sisaSpring.SummaryItem.DisplayFormat = "{0:n2}"
        Me.sisaSpring.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sisaSpring.UnboundExpression = "[JML_RP_TRANS] - [Nota]"
        Me.sisaSpring.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.sisaSpring.Visible = True
        Me.sisaSpring.VisibleIndex = 5
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVSpring
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GVSpon
        GridLevelNode2.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 37)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(907, 298)
        Me.GC.TabIndex = 7
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSpon, Me.GV, Me.GVSpring})
        '
        'GVSpon
        '
        Me.GVSpon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.GVSpon.GridControl = Me.GC
        Me.GVSpon.Name = "GVSpon"
        Me.GVSpon.OptionsView.ShowFooter = True
        Me.GVSpon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nomor SP"
        Me.GridColumn2.FieldName = "No_sp"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tanggal"
        Me.GridColumn7.FieldName = "tgl_sp"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Total"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "JML_RP_TRANS"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Bayar"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Bayar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Sisa"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Sisa"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn10.UnboundExpression = "[JML_RP_TRANS] - [Bayar]"
        Me.GridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 5
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Nota"
        Me.GridColumn11.FieldName = "Nota"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_customer, Me.CR_Spring, Me.SisaCrSpring, Me.CRSpon, Me.SisaCRSpon})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'kd_customer
        '
        Me.kd_customer.Caption = "Customer"
        Me.kd_customer.FieldName = "Nama_Customer"
        Me.kd_customer.Name = "kd_customer"
        Me.kd_customer.Visible = True
        Me.kd_customer.VisibleIndex = 0
        '
        'CR_Spring
        '
        Me.CR_Spring.Caption = "CR Spring"
        Me.CR_Spring.DisplayFormat.FormatString = "{0:n2}"
        Me.CR_Spring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CR_Spring.FieldName = "Limit_Piutang_Rupiah"
        Me.CR_Spring.Name = "CR_Spring"
        Me.CR_Spring.Visible = True
        Me.CR_Spring.VisibleIndex = 1
        '
        'SisaCrSpring
        '
        Me.SisaCrSpring.Caption = "Sisa CR Spring"
        Me.SisaCrSpring.DisplayFormat.FormatString = "{0:n2}"
        Me.SisaCrSpring.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SisaCrSpring.FieldName = "SisaSpring"
        Me.SisaCrSpring.Name = "SisaCrSpring"
        Me.SisaCrSpring.Visible = True
        Me.SisaCrSpring.VisibleIndex = 2
        '
        'CRSpon
        '
        Me.CRSpon.Caption = "CR Spon"
        Me.CRSpon.DisplayFormat.FormatString = "{0:n2}"
        Me.CRSpon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CRSpon.FieldName = "Limit_Piutang_Spon"
        Me.CRSpon.Name = "CRSpon"
        Me.CRSpon.Visible = True
        Me.CRSpon.VisibleIndex = 3
        '
        'SisaCRSpon
        '
        Me.SisaCRSpon.Caption = "Sisa CR Spon"
        Me.SisaCRSpon.DisplayFormat.FormatString = "{0:n2}"
        Me.SisaCRSpon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SisaCRSpon.FieldName = "SisaSpon"
        Me.SisaCRSpon.Name = "SisaCRSpon"
        Me.SisaCRSpon.Visible = True
        Me.SisaCRSpon.VisibleIndex = 4
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(907, 335)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 37)
        Me.Panel2.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(863, 0)
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(42, 35)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Tag = "Pembatalan Order"
        Me.btnRefresh.ToolTip = "Klik Untuk Pembatalan SP"
        Me.btnRefresh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Exclamation
        Me.btnRefresh.ToolTipTitle = "Pembatalan SP"
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(413, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM MONITORING CREDIT LIMIT"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'frmMonCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 335)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonCR"
        Me.Text = "frmMonCR"
        CType(Me.GVSpring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVSpring As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVSpon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CR_Spring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SisaCrSpring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CRSpon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SisaCRSpon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sisaSpring As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
End Class
