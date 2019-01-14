<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpk))
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kapasitas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkKegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtNoRph = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTgl_Rph = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.gc1 = New DevExpress.XtraGrid.GridControl
        Me.gv1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah_produksi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkNmBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.txtNoRph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbawah.SuspendLayout()
        CType(Me.gc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkNmBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Location = New System.Drawing.Point(7, 10)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(928, 404)
        Me.pnl.TabIndex = 0
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Controls.Add(Me.Panel1)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(926, 201)
        Me.pnlTengah.TabIndex = 1
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 58)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkKegiatan})
        Me.gc.Size = New System.Drawing.Size(926, 143)
        Me.gc.TabIndex = 7
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GridView1})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kegiatan, Me.jumlah, Me.kapasitas})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = " "
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowViewCaption = True
        Me.gv.ViewCaption = "DAFTAR PRODUKSI"
        '
        'kegiatan
        '
        Me.kegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.kegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kegiatan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.kegiatan.Caption = "Kegiatan"
        Me.kegiatan.FieldName = "kd_kegiatan"
        Me.kegiatan.Name = "kegiatan"
        Me.kegiatan.OptionsColumn.AllowEdit = False
        Me.kegiatan.Visible = True
        Me.kegiatan.VisibleIndex = 0
        Me.kegiatan.Width = 211
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Jumlah Produksi"
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowEdit = False
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 1
        '
        'kapasitas
        '
        Me.kapasitas.AppearanceHeader.Options.UseTextOptions = True
        Me.kapasitas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kapasitas.Caption = "Kapasitas Produksi"
        Me.kapasitas.FieldName = "kapasitas"
        Me.kapasitas.Name = "kapasitas"
        Me.kapasitas.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.kapasitas.Visible = True
        Me.kapasitas.VisibleIndex = 2
        '
        'lkKegiatan
        '
        Me.lkKegiatan.AutoHeight = False
        Me.lkKegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkKegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Kegiatan")})
        Me.lkKegiatan.Name = "lkKegiatan"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gc
        Me.GridView1.Name = "GridView1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 58)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(649, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 58)
        Me.Panel3.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(458, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 58)
        Me.Panel2.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtNoRph)
        Me.Panel7.Controls.Add(Me.txtTgl_Rph)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 58)
        Me.Panel7.TabIndex = 7
        '
        'txtNoRph
        '
        Me.txtNoRph.Location = New System.Drawing.Point(0, 7)
        Me.txtNoRph.Name = "txtNoRph"
        Me.txtNoRph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoRph.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_trans", "No RPH")})
        Me.txtNoRph.Properties.NullText = "[Pilih No RPH]"
        Me.txtNoRph.Properties.ShowHeader = False
        Me.txtNoRph.Size = New System.Drawing.Size(181, 20)
        Me.txtNoRph.TabIndex = 4
        '
        'txtTgl_Rph
        '
        Me.txtTgl_Rph.EditValue = Nothing
        Me.txtTgl_Rph.Location = New System.Drawing.Point(0, 31)
        Me.txtTgl_Rph.Name = "txtTgl_Rph"
        Me.txtTgl_Rph.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTgl_Rph.Properties.Appearance.Options.UseFont = True
        Me.txtTgl_Rph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTgl_Rph.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTgl_Rph.Size = New System.Drawing.Size(140, 20)
        Me.txtTgl_Rph.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 58)
        Me.Panel6.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-46, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No RPH : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-43, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tanggal : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(926, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(441, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "   Surat Perintah Kerja (SPK)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Controls.Add(Me.gc1)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 232)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(926, 170)
        Me.pnlbawah.TabIndex = 2
        '
        'gc1
        '
        Me.gc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc1.Location = New System.Drawing.Point(0, 0)
        Me.gc1.MainView = Me.gv1
        Me.gc1.Name = "gc1"
        Me.gc1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkNmBrg})
        Me.gc1.Size = New System.Drawing.Size(926, 170)
        Me.gc1.TabIndex = 8
        Me.gc1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv1, Me.GridView3})
        '
        'gv1
        '
        Me.gv1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_barang, Me.jumlah_produksi})
        Me.gv1.GridControl = Me.gc1
        Me.gv1.Name = "gv1"
        Me.gv1.OptionsView.ShowGroupPanel = False
        Me.gv1.OptionsView.ShowViewCaption = True
        Me.gv1.ViewCaption = "DETAIL PRODUKSI"
        '
        'kd_barang
        '
        Me.kd_barang.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_barang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.kd_barang.Caption = "Nama Barang"
        Me.kd_barang.FieldName = "kd_barang"
        Me.kd_barang.Name = "kd_barang"
        Me.kd_barang.OptionsColumn.AllowEdit = False
        Me.kd_barang.Visible = True
        Me.kd_barang.VisibleIndex = 0
        Me.kd_barang.Width = 211
        '
        'jumlah_produksi
        '
        Me.jumlah_produksi.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah_produksi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah_produksi.Caption = "Jumlah Produksi"
        Me.jumlah_produksi.FieldName = "jumlah_produksi"
        Me.jumlah_produksi.Name = "jumlah_produksi"
        Me.jumlah_produksi.OptionsColumn.AllowEdit = False
        Me.jumlah_produksi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah_produksi.Visible = True
        Me.jumlah_produksi.VisibleIndex = 1
        '
        'lkNmBrg
        '
        Me.lkNmBrg.AutoHeight = False
        Me.lkNmBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkNmBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.lkNmBrg.Name = "lkNmBrg"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gc1
        Me.GridView3.Name = "GridView3"
        '
        'frmSpk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 462)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSpk"
        Me.Text = "frmSpk"
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtNoRph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl_Rph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbawah.ResumeLayout(False)
        CType(Me.gc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkNmBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTgl_Rph As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents kapasitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah_produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNoRph As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkKegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkNmBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
