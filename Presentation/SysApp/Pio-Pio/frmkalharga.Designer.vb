<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkalharga
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
        Me.pnl = New System.Windows.Forms.Panel
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Button1 = New System.Windows.Forms.Button
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkjenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkmerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_sub_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lksubtipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.kd_kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkkain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tgl_akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_awal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deTanggal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.pnl.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkjenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkmerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lksubtipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.PanelControl1)
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(798, 543)
        Me.pnl.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 501)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(798, 42)
        Me.PanelControl1.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(695, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 44)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Proses Run"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 41)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookTipe, Me.lkmerk, Me.lkjenis, Me.lksubtipe, Me.lkukuran, Me.RepositoryItemSpinEdit1, Me.lkkain, Me.deTanggal})
        Me.gc.Size = New System.Drawing.Size(798, 502)
        Me.gc.TabIndex = 83
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gv.Appearance.HeaderPanel.Options.UseFont = True
        Me.gv.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_jenis, Me.tgl_awal, Me.tgl_akhir, Me.kd_kain, Me.kd_merk, Me.kd_tipe, Me.kd_sub_tipe, Me.kd_ukuran, Me.harga})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsCustomization.AllowColumnMoving = False
        Me.gv.OptionsView.ColumnAutoWidth = False
        Me.gv.OptionsView.RowAutoHeight = True
        Me.gv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "Jenis"
        Me.kd_jenis.ColumnEdit = Me.lkjenis
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        Me.kd_jenis.OptionsColumn.ReadOnly = True
        Me.kd_jenis.Visible = True
        Me.kd_jenis.VisibleIndex = 0
        Me.kd_jenis.Width = 194
        '
        'lkjenis
        '
        Me.lkjenis.AutoHeight = False
        Me.lkjenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkjenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama_Jenis")})
        Me.lkjenis.DisplayMember = "Nama_Jenis"
        Me.lkjenis.Name = "lkjenis"
        Me.lkjenis.NullText = "[Kosong]"
        Me.lkjenis.ValueMember = "kd_jenis"
        '
        'kd_merk
        '
        Me.kd_merk.Caption = "Merk "
        Me.kd_merk.ColumnEdit = Me.lkmerk
        Me.kd_merk.FieldName = "kd_merk"
        Me.kd_merk.Name = "kd_merk"
        Me.kd_merk.Visible = True
        Me.kd_merk.VisibleIndex = 4
        Me.kd_merk.Width = 176
        '
        'lkmerk
        '
        Me.lkmerk.AutoHeight = False
        Me.lkmerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkmerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama_Merk")})
        Me.lkmerk.DisplayMember = "Nama_Merk"
        Me.lkmerk.Name = "lkmerk"
        Me.lkmerk.NullText = "[Kosong]"
        Me.lkmerk.ValueMember = "kd_merk"
        '
        'kd_tipe
        '
        Me.kd_tipe.Caption = "Tipe"
        Me.kd_tipe.ColumnEdit = Me.lookTipe
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 6
        Me.kd_tipe.Width = 117
        '
        'lookTipe
        '
        Me.lookTipe.AutoHeight = False
        Me.lookTipe.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Name1")})
        Me.lookTipe.DisplayMember = "Nama_Tipe"
        Me.lookTipe.Name = "lookTipe"
        Me.lookTipe.NullText = "[Kosong]"
        Me.lookTipe.ShowFooter = False
        Me.lookTipe.ShowHeader = False
        Me.lookTipe.ShowPopupShadow = False
        Me.lookTipe.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookTipe.ValueMember = "kd_tipe"
        '
        'kd_sub_tipe
        '
        Me.kd_sub_tipe.Caption = "Sub Tipe"
        Me.kd_sub_tipe.ColumnEdit = Me.lksubtipe
        Me.kd_sub_tipe.FieldName = "kd_sub_tipe"
        Me.kd_sub_tipe.Name = "kd_sub_tipe"
        Me.kd_sub_tipe.Visible = True
        Me.kd_sub_tipe.VisibleIndex = 5
        Me.kd_sub_tipe.Width = 156
        '
        'lksubtipe
        '
        Me.lksubtipe.AutoHeight = False
        Me.lksubtipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lksubtipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Nama_Sub_Tipe")})
        Me.lksubtipe.DisplayMember = "Nama_Sub_Tipe"
        Me.lksubtipe.Name = "lksubtipe"
        Me.lksubtipe.NullText = "[Kosong]"
        Me.lksubtipe.ValueMember = "kd_sub_tipe"
        '
        'kd_ukuran
        '
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.lkukuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 7
        Me.kd_ukuran.Width = 174
        '
        'lkukuran
        '
        Me.lkukuran.AutoHeight = False
        Me.lkukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Nama_Ukuran")})
        Me.lkukuran.DisplayMember = "Nama_Ukuran"
        Me.lkukuran.Name = "lkukuran"
        Me.lkukuran.NullText = "[Kosong]"
        Me.lkukuran.ValueMember = "kd_ukuran"
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 8
        Me.harga.Width = 113
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "N2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(798, 41)
        Me.Panel3.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MASTER KALKULASI HARGA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'kd_kain
        '
        Me.kd_kain.Caption = "Kain"
        Me.kd_kain.ColumnEdit = Me.lkkain
        Me.kd_kain.FieldName = "kd_kain"
        Me.kd_kain.Name = "kd_kain"
        Me.kd_kain.Visible = True
        Me.kd_kain.VisibleIndex = 3
        '
        'lkkain
        '
        Me.lkkain.AutoHeight = False
        Me.lkkain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkain.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Merk_Kain", "Name1")})
        Me.lkkain.Name = "lkkain"
        Me.lkkain.NullText = "[Kosong]"
        '
        'tgl_akhir
        '
        Me.tgl_akhir.Caption = "Tanggal Akhir"
        Me.tgl_akhir.ColumnEdit = Me.deTanggal
        Me.tgl_akhir.FieldName = "tgl_akhir"
        Me.tgl_akhir.Name = "tgl_akhir"
        Me.tgl_akhir.Visible = True
        Me.tgl_akhir.VisibleIndex = 2
        '
        'tgl_awal
        '
        Me.tgl_awal.Caption = "Tanggal Awal"
        Me.tgl_awal.ColumnEdit = Me.deTanggal
        Me.tgl_awal.FieldName = "tgl_awal"
        Me.tgl_awal.Name = "tgl_awal"
        Me.tgl_awal.Visible = True
        Me.tgl_awal.VisibleIndex = 1
        '
        'deTanggal
        '
        Me.deTanggal.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggal.AutoHeight = False
        Me.deTanggal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.EditFormat.FormatString = "dd/MM/yyyy"
        Me.deTanggal.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Mask.EditMask = "d MMMM yyyy"
        Me.deTanggal.Mask.UseMaskAsDisplayFormat = True
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.ShowPopupShadow = False
        Me.deTanggal.ValidateOnEnterKey = True
        Me.deTanggal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'frmkalharga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(798, 543)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmkalharga"
        Me.Text = "Master Kalkulasi Harga"
        Me.pnl.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkjenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkmerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lksubtipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_sub_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kd_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkmerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkjenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lksubtipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents kd_kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tgl_awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deTanggal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents tgl_akhir As DevExpress.XtraGrid.Columns.GridColumn
End Class
