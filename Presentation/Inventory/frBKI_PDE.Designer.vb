<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frBKI_PDE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frBKI_PDE))
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.img_small = New System.Windows.Forms.ImageList(Me.components)
        Me.pnl_bwh = New System.Windows.Forms.Panel
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnl_grid = New System.Windows.Forms.Panel
        Me.GcBKI_d = New DevExpress.XtraGrid.GridControl
        Me.GvBKI_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.LookupGudang = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupKdKeg = New DevExpress.XtraEditors.LookUpEdit
        Me.LookupSPPB = New DevExpress.XtraEditors.LookUpEdit
        Me.txbKdBrg = New System.Windows.Forms.TextBox
        Me.pnl_bwh.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnl_grid.SuspendLayout()
        CType(Me.GcBKI_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBKI_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupKdKeg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupSPPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnSimpan.Location = New System.Drawing.Point(85, 0)
        Me.btnSimpan.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnSimpan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(58, 27)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Save"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnl_grid)
        Me.pnl.Controls.Add(Me.pnl_bwh)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(312, 293)
        Me.pnl.TabIndex = 1
        '
        'pnl_grid
        '
        Me.pnl_grid.Controls.Add(Me.GcBKI_d)
        Me.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_grid.Location = New System.Drawing.Point(0, 53)
        Me.pnl_grid.Name = "pnl_grid"
        Me.pnl_grid.Size = New System.Drawing.Size(312, 213)
        Me.pnl_grid.TabIndex = 2
        '
        'GcBKI_d
        '
        Me.GcBKI_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBKI_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBKI_d.MainView = Me.GvBKI_d
        Me.GcBKI_d.Name = "GcBKI_d"
        Me.GcBKI_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang})
        Me.GcBKI_d.Size = New System.Drawing.Size(312, 213)
        Me.GcBKI_d.TabIndex = 7
        Me.GcBKI_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBKI_d})
        '
        'GvBKI_d
        '
        Me.GvBKI_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.qty_in, Me.rp_trans})
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
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 181
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = "[Nama Barang]"
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
        Me.qty_in.OptionsColumn.ReadOnly = True
        Me.qty_in.Visible = True
        Me.qty_in.VisibleIndex = 2
        Me.qty_in.Width = 37
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "rp_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.OptionsColumn.AllowEdit = False
        Me.rp_trans.OptionsColumn.ReadOnly = True
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Visible = True
        Me.rp_trans.VisibleIndex = 3
        Me.rp_trans.Width = 47
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LookupGudang)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LookupKdKeg)
        Me.Panel1.Controls.Add(Me.LookupSPPB)
        Me.Panel1.Controls.Add(Me.txbKdBrg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(165, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "Gdg:"
        '
        'LookupGudang
        '
        Me.LookupGudang.Location = New System.Drawing.Point(203, 29)
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
        Me.LookupGudang.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "SPPB:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(216, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Keg:"
        '
        'LookupKdKeg
        '
        Me.LookupKdKeg.Location = New System.Drawing.Point(246, 3)
        Me.LookupKdKeg.Name = "LookupKdKeg"
        Me.LookupKdKeg.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookupKdKeg.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupKdKeg.Properties.Appearance.Options.UseBackColor = True
        Me.LookupKdKeg.Properties.Appearance.Options.UseFont = True
        Me.LookupKdKeg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupKdKeg.Properties.DisplayMember = "kd_kegiatan"
        Me.LookupKdKeg.Properties.NullText = "[klik disini]"
        Me.LookupKdKeg.Properties.ValueMember = "kd_kegiatan"
        Me.LookupKdKeg.Size = New System.Drawing.Size(66, 20)
        Me.LookupKdKeg.TabIndex = 166
        '
        'LookupSPPB
        '
        Me.LookupSPPB.Location = New System.Drawing.Point(36, 3)
        Me.LookupSPPB.Name = "LookupSPPB"
        Me.LookupSPPB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookupSPPB.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupSPPB.Properties.Appearance.Options.UseBackColor = True
        Me.LookupSPPB.Properties.Appearance.Options.UseFont = True
        Me.LookupSPPB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupSPPB.Properties.DisplayMember = "no_sppb"
        Me.LookupSPPB.Properties.NullText = "[klik disini]"
        Me.LookupSPPB.Properties.ValueMember = "no_sppb"
        Me.LookupSPPB.Size = New System.Drawing.Size(174, 20)
        Me.LookupSPPB.TabIndex = 164
        '
        'txbKdBrg
        '
        Me.txbKdBrg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbKdBrg.Location = New System.Drawing.Point(3, 27)
        Me.txbKdBrg.Name = "txbKdBrg"
        Me.txbKdBrg.Size = New System.Drawing.Size(147, 20)
        Me.txbKdBrg.TabIndex = 0
        '
        'frBKI_PDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 293)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frBKI_PDE"
        Me.Text = "frBKI_PDE"
        Me.pnl_bwh.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.pnl_grid.ResumeLayout(False)
        CType(Me.GcBKI_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBKI_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupKdKeg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupSPPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img_small As System.Windows.Forms.ImageList
    Friend WithEvents pnl_bwh As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnl_grid As System.Windows.Forms.Panel
    Friend WithEvents GcBKI_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBKI_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txbKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents LookupSPPB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookupKdKeg As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
