<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBiayaPacking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBiayaPacking))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gcPacking = New DevExpress.XtraGrid.GridControl
        Me.gvPacking = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNamaJenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.luvNamaJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPanjangMin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPanjangMax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKdCabang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKdDepartemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luvNamaJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.gcPacking)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(838, 507)
        Me.pnl.TabIndex = 142
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
        Me.Panel1.Size = New System.Drawing.Size(838, 34)
        Me.Panel1.TabIndex = 183
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          BIAYA PACKING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gcPacking
        '
        Me.gcPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPacking.Location = New System.Drawing.Point(0, 0)
        Me.gcPacking.MainView = Me.gvPacking
        Me.gcPacking.Name = "gcPacking"
        Me.gcPacking.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luvNamaJenis})
        Me.gcPacking.Size = New System.Drawing.Size(838, 507)
        Me.gcPacking.TabIndex = 6
        Me.gcPacking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPacking})
        '
        'gvPacking
        '
        Me.gvPacking.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvPacking.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPacking.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNamaJenis, Me.colPanjangMin, Me.colPanjangMax, Me.colHarga, Me.colKdCabang, Me.colKdDepartemen})
        Me.gvPacking.GridControl = Me.gcPacking
        Me.gvPacking.Name = "gvPacking"
        Me.gvPacking.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvPacking.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvPacking.OptionsView.RowAutoHeight = True
        Me.gvPacking.OptionsView.ShowFooter = True
        Me.gvPacking.PaintStyleName = "Web"
        '
        'colNamaJenis
        '
        Me.colNamaJenis.Caption = "Nama Jenis"
        Me.colNamaJenis.ColumnEdit = Me.luvNamaJenis
        Me.colNamaJenis.FieldName = "jenis_barang"
        Me.colNamaJenis.Name = "colNamaJenis"
        Me.colNamaJenis.Visible = True
        Me.colNamaJenis.VisibleIndex = 0
        '
        'luvNamaJenis
        '
        Me.luvNamaJenis.AutoHeight = False
        Me.luvNamaJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luvNamaJenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_jenis", "Nama Jenis"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_jns_brg", "Kode Jenis", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.luvNamaJenis.Name = "luvNamaJenis"
        Me.luvNamaJenis.NullText = ""
        '
        'colPanjangMin
        '
        Me.colPanjangMin.Caption = "Panjang (Min)"
        Me.colPanjangMin.DisplayFormat.FormatString = "n0"
        Me.colPanjangMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPanjangMin.FieldName = "panjang_min"
        Me.colPanjangMin.Name = "colPanjangMin"
        Me.colPanjangMin.Visible = True
        Me.colPanjangMin.VisibleIndex = 1
        '
        'colPanjangMax
        '
        Me.colPanjangMax.Caption = "Panjang (Max)"
        Me.colPanjangMax.DisplayFormat.FormatString = "n0"
        Me.colPanjangMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPanjangMax.FieldName = "panjang_max"
        Me.colPanjangMax.Name = "colPanjangMax"
        Me.colPanjangMax.Visible = True
        Me.colPanjangMax.VisibleIndex = 2
        '
        'colHarga
        '
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n0"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.FieldName = "harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 3
        '
        'colKdCabang
        '
        Me.colKdCabang.Caption = "Kode Cabang"
        Me.colKdCabang.FieldName = "kd_cabang"
        Me.colKdCabang.Name = "colKdCabang"
        '
        'colKdDepartemen
        '
        Me.colKdDepartemen.Caption = "Kode Departemen"
        Me.colKdDepartemen.FieldName = "kd_departemen"
        Me.colKdDepartemen.Name = "colKdDepartemen"
        '
        'frmBiayaPacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 507)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmBiayaPacking"
        Me.Text = "frmBiayaPacking"
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luvNamaJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gcPacking As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPacking As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents luvNamaJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colNamaJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPanjangMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPanjangMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdCabang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdDepartemen As DevExpress.XtraGrid.Columns.GridColumn
End Class
