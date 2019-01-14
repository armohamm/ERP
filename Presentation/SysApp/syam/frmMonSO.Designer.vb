<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonSO))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gcsaldo = New DevExpress.XtraGrid.GridControl
        Me.gvSaldo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nmBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Saldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NomorSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tglKirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyRph = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qtyDPB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gcsaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcsaldo)
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(89, 21)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(840, 468)
        Me.pnl.TabIndex = 0
        '
        'gcsaldo
        '
        Me.gcsaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcsaldo.Location = New System.Drawing.Point(0, 310)
        Me.gcsaldo.MainView = Me.gvSaldo
        Me.gcsaldo.Name = "gcsaldo"
        Me.gcsaldo.Size = New System.Drawing.Size(840, 120)
        Me.gcsaldo.TabIndex = 5
        Me.gcsaldo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSaldo})
        '
        'gvSaldo
        '
        Me.gvSaldo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nmBarang, Me.Saldo})
        Me.gvSaldo.GridControl = Me.gcsaldo
        Me.gvSaldo.Name = "gvSaldo"
        Me.gvSaldo.OptionsView.ColumnAutoWidth = False
        Me.gvSaldo.OptionsView.ShowGroupPanel = False
        Me.gvSaldo.OptionsView.ShowViewCaption = True
        Me.gvSaldo.ViewCaption = "SALDO PERSEDIAAN"
        '
        'nmBarang
        '
        Me.nmBarang.Caption = "Barang"
        Me.nmBarang.Name = "nmBarang"
        Me.nmBarang.Visible = True
        Me.nmBarang.VisibleIndex = 0
        Me.nmBarang.Width = 560
        '
        'Saldo
        '
        Me.Saldo.Caption = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Visible = True
        Me.Saldo.VisibleIndex = 1
        Me.Saldo.Width = 259
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Top
        Me.gc.Location = New System.Drawing.Point(0, 42)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(840, 268)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Barang, Me.NomorSO, Me.Qty, Me.tglKirim, Me.QtyRph, Me.qtyDPB, Me.Kode})
        Me.gv.GridControl = Me.gc
        Me.gv.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, "")})
        Me.gv.Name = "gv"
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowViewCaption = True
        Me.gv.ViewCaption = "DAFTAR SALES ORDER"
        '
        'Barang
        '
        Me.Barang.Caption = "Barang"
        Me.Barang.FieldName = "Nama"
        Me.Barang.Name = "Barang"
        Me.Barang.Visible = True
        Me.Barang.VisibleIndex = 1
        Me.Barang.Width = 420
        '
        'NomorSO
        '
        Me.NomorSO.Caption = "Nomor SO"
        Me.NomorSO.FieldName = "No_sp"
        Me.NomorSO.Name = "NomorSO"
        Me.NomorSO.Visible = True
        Me.NomorSO.VisibleIndex = 0
        Me.NomorSO.Width = 178
        '
        'Qty
        '
        Me.Qty.Caption = "Qty SP"
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        Me.Qty.Width = 81
        '
        'tglKirim
        '
        Me.tglKirim.Caption = "Tgl Kirim"
        Me.tglKirim.FieldName = "Tgl_Kirim"
        Me.tglKirim.Name = "tglKirim"
        Me.tglKirim.Visible = True
        Me.tglKirim.VisibleIndex = 3
        Me.tglKirim.Width = 103
        '
        'QtyRph
        '
        Me.QtyRph.Caption = "RPH"
        Me.QtyRph.FieldName = "rph"
        Me.QtyRph.Name = "QtyRph"
        Me.QtyRph.Visible = True
        Me.QtyRph.VisibleIndex = 4
        Me.QtyRph.Width = 82
        '
        'qtyDPB
        '
        Me.qtyDPB.Caption = "DPB"
        Me.qtyDPB.FieldName = "dpb"
        Me.qtyDPB.Name = "qtyDPB"
        Me.qtyDPB.Visible = True
        Me.qtyDPB.VisibleIndex = 5
        Me.qtyDPB.Width = 78
        '
        'Kode
        '
        Me.Kode.Caption = "kode"
        Me.Kode.FieldName = "Kd_Stok"
        Me.Kode.Name = "Kode"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(840, 5)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 430)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 38)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 37)
        Me.Panel1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(152, 37)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "   DAFTAR SALES ORDER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmMonSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 522)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMonSO"
        Me.Text = "frmMonSO"
        Me.pnl.ResumeLayout(False)
        CType(Me.gcsaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NomorSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tglKirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyRph As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qtyDPB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsaldo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSaldo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nmBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kode As DevExpress.XtraGrid.Columns.GridColumn
End Class
