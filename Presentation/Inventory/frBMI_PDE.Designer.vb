<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frBMI_PDE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frBMI_PDE))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnl_grid = New System.Windows.Forms.Panel
        Me.GcBKI_d = New DevExpress.XtraGrid.GridControl
        Me.GvBKI_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl_bwh = New System.Windows.Forms.Panel
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.img_small = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LookupGudang = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txbKdBrg = New System.Windows.Forms.TextBox
        Me.pnl.SuspendLayout()
        Me.pnl_grid.SuspendLayout()
        CType(Me.GcBKI_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBKI_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bwh.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnl_grid)
        Me.pnl.Controls.Add(Me.pnl_bwh)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(312, 293)
        Me.pnl.TabIndex = 0
        '
        'pnl_grid
        '
        Me.pnl_grid.Controls.Add(Me.GcBKI_d)
        Me.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_grid.Location = New System.Drawing.Point(0, 31)
        Me.pnl_grid.Name = "pnl_grid"
        Me.pnl_grid.Size = New System.Drawing.Size(312, 235)
        Me.pnl_grid.TabIndex = 2
        '
        'GcBKI_d
        '
        Me.GcBKI_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBKI_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBKI_d.MainView = Me.GvBKI_d
        Me.GcBKI_d.Name = "GcBKI_d"
        Me.GcBKI_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepLookupBarang})
        Me.GcBKI_d.Size = New System.Drawing.Size(312, 235)
        Me.GcBKI_d.TabIndex = 7
        Me.GcBKI_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBKI_d})
        '
        'GvBKI_d
        '
        Me.GvBKI_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.qty_in, Me.jml_trans})
        Me.GvBKI_d.GridControl = Me.GcBKI_d
        Me.GvBKI_d.Name = "GvBKI_d"
        Me.GvBKI_d.OptionsCustomization.AllowColumnMoving = False
        Me.GvBKI_d.OptionsCustomization.AllowFilter = False
        Me.GvBKI_d.OptionsCustomization.AllowGroup = False
        Me.GvBKI_d.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBKI_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvBKI_d.OptionsView.RowAutoHeight = True
        Me.GvBKI_d.OptionsView.ShowGroupPanel = False
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_seq.AppearanceCell.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 26
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceCell.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RepLookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 198
        '
        'RepLookupBarang
        '
        Me.RepLookupBarang.AutoHeight = False
        Me.RepLookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.RepLookupBarang.Name = "RepLookupBarang"
        Me.RepLookupBarang.NullText = "[Nama Barang]"
        '
        'qty_in
        '
        Me.qty_in.AppearanceCell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_in.AppearanceCell.Options.UseFont = True
        Me.qty_in.AppearanceHeader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_in.AppearanceHeader.Options.UseFont = True
        Me.qty_in.Caption = "Qty Masuk"
        Me.qty_in.FieldName = "qty_in"
        Me.qty_in.Name = "qty_in"
        Me.qty_in.OptionsColumn.AllowEdit = False
        Me.qty_in.Visible = True
        Me.qty_in.VisibleIndex = 2
        Me.qty_in.Width = 30
        '
        'jml_trans
        '
        Me.jml_trans.Caption = "jml_trans"
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 3
        Me.jml_trans.Width = 37
        '
        'pnl_bwh
        '
        Me.pnl_bwh.Controls.Add(Me.btnPrint)
        Me.pnl_bwh.Controls.Add(Me.btnBatal)
        Me.pnl_bwh.Controls.Add(Me.btnSimpan)
        Me.pnl_bwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bwh.Location = New System.Drawing.Point(0, 266)
        Me.pnl_bwh.Name = "pnl_bwh"
        Me.pnl_bwh.Size = New System.Drawing.Size(312, 27)
        Me.pnl_bwh.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.ImageIndex = 10
        Me.btnPrint.ImageList = Me.img_small
        Me.btnPrint.Location = New System.Drawing.Point(158, 0)
        Me.btnPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(66, 27)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Cetak"
        '
        'img_small
        '
        Me.img_small.ImageStream = CType(resources.GetObject("img_small.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_small.TransparentColor = System.Drawing.Color.Transparent
        Me.img_small.Images.SetKeyName(0, "")
        Me.img_small.Images.SetKeyName(1, "")
        Me.img_small.Images.SetKeyName(2, "")
        Me.img_small.Images.SetKeyName(3, "")
        Me.img_small.Images.SetKeyName(4, "")
        Me.img_small.Images.SetKeyName(5, "")
        Me.img_small.Images.SetKeyName(6, "")
        Me.img_small.Images.SetKeyName(7, "")
        Me.img_small.Images.SetKeyName(8, "")
        Me.img_small.Images.SetKeyName(9, "")
        Me.img_small.Images.SetKeyName(10, "")
        Me.img_small.Images.SetKeyName(11, "")
        Me.img_small.Images.SetKeyName(12, "")
        Me.img_small.Images.SetKeyName(13, "")
        Me.img_small.Images.SetKeyName(14, "")
        '
        'btnBatal
        '
        Me.btnBatal.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.Appearance.Options.UseFont = True
        Me.btnBatal.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBatal.ImageIndex = 8
        Me.btnBatal.ImageList = Me.img_small
        Me.btnBatal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(257, 0)
        Me.btnBatal.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnBatal.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(55, 27)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.Appearance.Options.UseFont = True
        Me.btnSimpan.ImageIndex = 4
        Me.btnSimpan.ImageList = Me.img_small
        Me.btnSimpan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(87, 0)
        Me.btnSimpan.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnSimpan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(58, 27)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LookupGudang)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txbKdBrg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 31)
        Me.Panel1.TabIndex = 0
        '
        'LookupGudang
        '
        Me.LookupGudang.Location = New System.Drawing.Point(203, 3)
        Me.LookupGudang.Name = "LookupGudang"
        Me.LookupGudang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookupGudang.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupGudang.Properties.Appearance.Options.UseBackColor = True
        Me.LookupGudang.Properties.Appearance.Options.UseFont = True
        Me.LookupGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Properties.DisplayMember = "Nama_Gudang"
        Me.LookupGudang.Properties.NullText = "[klik disini]"
        Me.LookupGudang.Properties.ValueMember = "Kode_Gudang"
        Me.LookupGudang.Size = New System.Drawing.Size(106, 20)
        Me.LookupGudang.TabIndex = 174
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(167, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Gdg:"
        '
        'txbKdBrg
        '
        Me.txbKdBrg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbKdBrg.Location = New System.Drawing.Point(3, 3)
        Me.txbKdBrg.Name = "txbKdBrg"
        Me.txbKdBrg.Size = New System.Drawing.Size(147, 20)
        Me.txbKdBrg.TabIndex = 0
        '
        'frBMI_PDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 293)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frBMI_PDE"
        Me.Text = "Hasil Produksi Harian (BMI)"
        Me.pnl.ResumeLayout(False)
        Me.pnl_grid.ResumeLayout(False)
        CType(Me.GcBKI_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBKI_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_bwh.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnl_grid As System.Windows.Forms.Panel
    Friend WithEvents GcBKI_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBKI_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txbKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents pnl_bwh As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img_small As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.LookUpEdit
End Class
