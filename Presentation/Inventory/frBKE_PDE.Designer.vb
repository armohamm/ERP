<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frBKE_PDE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frBKE_PDE))
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.img_small = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LookupGudang = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupDPB = New DevExpress.XtraEditors.LookUpEdit
        Me.txbKdBrg = New System.Windows.Forms.TextBox
        Me.pnl_bwh = New System.Windows.Forms.Panel
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.GvBKE_d = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.qty_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcBKE_d = New DevExpress.XtraGrid.GridControl
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnl_grid = New System.Windows.Forms.Panel
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupDPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bwh.SuspendLayout()
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnl_grid.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.LookupGudang)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LookupDPB)
        Me.Panel1.Controls.Add(Me.txbKdBrg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 53)
        Me.Panel1.TabIndex = 0
        '
        'LookupGudang
        '
        Me.LookupGudang.Location = New System.Drawing.Point(224, 2)
        Me.LookupGudang.Name = "LookupGudang"
        Me.LookupGudang.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookupGudang.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupGudang.Properties.Appearance.Options.UseBackColor = True
        Me.LookupGudang.Properties.Appearance.Options.UseFont = True
        Me.LookupGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Properties.DisplayMember = "Nama_Gudang"
        Me.LookupGudang.Properties.NullText = "[klik disini]"
        Me.LookupGudang.Properties.ValueMember = "Kode_Gudang"
        Me.LookupGudang.Size = New System.Drawing.Size(88, 20)
        Me.LookupGudang.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "DPB:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(196, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Gdg:"
        '
        'LookupDPB
        '
        Me.LookupDPB.Location = New System.Drawing.Point(36, 2)
        Me.LookupDPB.Name = "LookupDPB"
        Me.LookupDPB.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LookupDPB.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookupDPB.Properties.Appearance.Options.UseBackColor = True
        Me.LookupDPB.Properties.Appearance.Options.UseFont = True
        Me.LookupDPB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupDPB.Properties.DisplayMember = "no_dpb"
        Me.LookupDPB.Properties.NullText = "[klik disini]"
        Me.LookupDPB.Properties.ValueMember = "no_dpb"
        Me.LookupDPB.Size = New System.Drawing.Size(149, 20)
        Me.LookupDPB.TabIndex = 164
        '
        'txbKdBrg
        '
        Me.txbKdBrg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbKdBrg.Location = New System.Drawing.Point(3, 27)
        Me.txbKdBrg.Name = "txbKdBrg"
        Me.txbKdBrg.Size = New System.Drawing.Size(147, 20)
        Me.txbKdBrg.TabIndex = 0
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
        'GvBKE_d
        '
        Me.GvBKE_d.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.kd_stok, Me.qty_in, Me.rp_trans})
        Me.GvBKE_d.GridControl = Me.GcBKE_d
        Me.GvBKE_d.Name = "GvBKE_d"
        Me.GvBKE_d.OptionsCustomization.AllowColumnMoving = False
        Me.GvBKE_d.OptionsCustomization.AllowFilter = False
        Me.GvBKE_d.OptionsCustomization.AllowGroup = False
        Me.GvBKE_d.OptionsNavigation.EnterMoveNextColumn = True
        Me.GvBKE_d.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvBKE_d.OptionsView.RowAutoHeight = True
        Me.GvBKE_d.OptionsView.ShowGroupPanel = False
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
        Me.kd_stok.Width = 174
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
        Me.qty_in.Width = 40
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
        Me.rp_trans.Width = 51
        '
        'GcBKE_d
        '
        Me.GcBKE_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBKE_d.Location = New System.Drawing.Point(0, 0)
        Me.GcBKE_d.MainView = Me.GvBKE_d
        Me.GcBKE_d.Name = "GcBKE_d"
        Me.GcBKE_d.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang})
        Me.GcBKE_d.Size = New System.Drawing.Size(312, 213)
        Me.GcBKE_d.TabIndex = 7
        Me.GcBKE_d.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBKE_d})
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnl_grid)
        Me.pnl.Controls.Add(Me.pnl_bwh)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(312, 293)
        Me.pnl.TabIndex = 2
        '
        'pnl_grid
        '
        Me.pnl_grid.Controls.Add(Me.GcBKE_d)
        Me.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_grid.Location = New System.Drawing.Point(0, 53)
        Me.pnl_grid.Name = "pnl_grid"
        Me.pnl_grid.Size = New System.Drawing.Size(312, 213)
        Me.pnl_grid.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(159, 30)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 172
        '
        'frBKE_PDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 293)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frBKE_PDE"
        Me.Text = "frBKE_PDE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LookupGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupDPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_bwh.ResumeLayout(False)
        CType(Me.GvBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcBKE_d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl_grid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents qty_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img_small As System.Windows.Forms.ImageList
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LookupDPB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txbKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl_bwh As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GvBKE_d As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcBKE_d As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnl_grid As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
