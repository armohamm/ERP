<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApprovSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApprovSupplier))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcSuppPilih = New DevExpress.XtraGrid.GridControl
        Me.GvSuppPilih = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_csp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_csp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_supp_pilih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcSuppPilih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvSuppPilih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcSuppPilih)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 357)
        Me.pnl.TabIndex = 0
        '
        'GcSuppPilih
        '
        Me.GcSuppPilih.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcSuppPilih.Location = New System.Drawing.Point(0, 34)
        Me.GcSuppPilih.MainView = Me.GvSuppPilih
        Me.GcSuppPilih.Name = "GcSuppPilih"
        Me.GcSuppPilih.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupBarang, Me.RBrecstat, Me.LookupSupplier})
        Me.GcSuppPilih.Size = New System.Drawing.Size(792, 280)
        Me.GcSuppPilih.TabIndex = 142
        Me.GcSuppPilih.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvSuppPilih})
        '
        'GvSuppPilih
        '
        Me.GvSuppPilih.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Red
        Me.GvSuppPilih.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvSuppPilih.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_csp, Me.tgl_csp, Me.no_pr, Me.kd_stok, Me.kd_supp_pilih, Me.keterangan, Me.rec_stat, Me.ket_approve})
        Me.GvSuppPilih.GridControl = Me.GcSuppPilih
        Me.GvSuppPilih.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GvSuppPilih.Name = "GvSuppPilih"
        Me.GvSuppPilih.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GvSuppPilih.OptionsView.EnableAppearanceEvenRow = True
        Me.GvSuppPilih.OptionsView.EnableAppearanceOddRow = True
        Me.GvSuppPilih.OptionsView.RowAutoHeight = True
        Me.GvSuppPilih.OptionsView.ShowFooter = True
        Me.GvSuppPilih.PaintStyleName = "Office2003"
        Me.GvSuppPilih.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_csp
        '
        Me.no_csp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_csp.AppearanceHeader.Options.UseFont = True
        Me.no_csp.AppearanceHeader.Options.UseTextOptions = True
        Me.no_csp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_csp.Caption = "Nomor"
        Me.no_csp.FieldName = "no_csp"
        Me.no_csp.Name = "no_csp"
        Me.no_csp.OptionsColumn.AllowEdit = False
        Me.no_csp.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_csp.Visible = True
        Me.no_csp.VisibleIndex = 0
        Me.no_csp.Width = 66
        '
        'tgl_csp
        '
        Me.tgl_csp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_csp.AppearanceHeader.Options.UseFont = True
        Me.tgl_csp.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_csp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_csp.Caption = "Tanggal"
        Me.tgl_csp.FieldName = "tgl_csp"
        Me.tgl_csp.Name = "tgl_csp"
        Me.tgl_csp.OptionsColumn.AllowEdit = False
        Me.tgl_csp.Visible = True
        Me.tgl_csp.VisibleIndex = 1
        Me.tgl_csp.Width = 66
        '
        'no_pr
        '
        Me.no_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_pr.AppearanceHeader.Options.UseFont = True
        Me.no_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.no_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_pr.Caption = "No. PR"
        Me.no_pr.FieldName = "no_pr"
        Me.no_pr.Name = "no_pr"
        Me.no_pr.OptionsColumn.AllowEdit = False
        Me.no_pr.Visible = True
        Me.no_pr.VisibleIndex = 2
        Me.no_pr.Width = 66
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_stok.AppearanceHeader.Options.UseFont = True
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.lookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 3
        Me.kd_stok.Width = 60
        '
        'lookupBarang
        '
        Me.lookupBarang.AutoHeight = False
        Me.lookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.lookupBarang.Name = "lookupBarang"
        '
        'kd_supp_pilih
        '
        Me.kd_supp_pilih.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supp_pilih.AppearanceHeader.Options.UseFont = True
        Me.kd_supp_pilih.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supp_pilih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supp_pilih.Caption = "Supplier Terpilih"
        Me.kd_supp_pilih.ColumnEdit = Me.LookupSupplier
        Me.kd_supp_pilih.FieldName = "kd_supp_pilih"
        Me.kd_supp_pilih.Name = "kd_supp_pilih"
        Me.kd_supp_pilih.OptionsColumn.AllowEdit = False
        Me.kd_supp_pilih.Visible = True
        Me.kd_supp_pilih.VisibleIndex = 4
        Me.kd_supp_pilih.Width = 87
        '
        'LookupSupplier
        '
        Me.LookupSupplier.AutoHeight = False
        Me.LookupSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupSupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama Supplier")})
        Me.LookupSupplier.Name = "LookupSupplier"
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.AllowEdit = False
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        Me.keterangan.Width = 103
        '
        'rec_stat
        '
        Me.rec_stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec_stat.AppearanceHeader.Options.UseFont = True
        Me.rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rec_stat.Caption = "Aproved"
        Me.rec_stat.ColumnEdit = Me.RBrecstat
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 6
        Me.rec_stat.Width = 98
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.ket_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ket_approve.Caption = "Alasan Reject"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.MinWidth = 100
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 7
        Me.ket_approve.Width = 209
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 314)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 43)
        Me.Panel2.TabIndex = 141
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(425, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(294, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "&Update"
        Me.btnSimpan.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(792, 34)
        Me.Panel1.TabIndex = 140
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FORM APPROVAL SUPPLIER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmApprovSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 357)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmApprovSupplier"
        Me.Text = "FORM APPROVAL SUPPLIER"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcSuppPilih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvSuppPilih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcSuppPilih As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvSuppPilih As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_csp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_csp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_supp_pilih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
