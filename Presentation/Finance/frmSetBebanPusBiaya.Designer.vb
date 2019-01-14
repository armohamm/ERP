<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetBebanPusBiaya
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetBebanPusBiaya))
        Me.cmdAdvance = New DevExpress.XtraEditors.SimpleButton
        Me.lookupval = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupbank = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lodTanggal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.lookupjns = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupkartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbStats = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.cbjns_trans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cbTipeTrans = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.rek_biaya = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LOVrekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.rek_pusat_biaya = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LOVpusat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.prosen1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.prosen2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.prosen3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.keterangan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LOVstatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdvance
        '
        Me.cmdAdvance.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdAdvance.Location = New System.Drawing.Point(760, 3)
        Me.cmdAdvance.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdAdvance.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdvance.Name = "cmdAdvance"
        Me.cmdAdvance.Size = New System.Drawing.Size(80, 30)
        Me.cmdAdvance.TabIndex = 30
        Me.cmdAdvance.Text = "&Advance"
        Me.cmdAdvance.Visible = False
        '
        'lookupval
        '
        Me.lookupval.AutoHeight = False
        Me.lookupval.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupval.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookupval.Name = "lookupval"
        '
        'lookupbank
        '
        Me.lookupbank.AutoHeight = False
        Me.lookupbank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbank.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bank", "Nama bank")})
        Me.lookupbank.Name = "lookupbank"
        '
        'lodTanggal
        '
        Me.lodTanggal.AutoHeight = False
        Me.lodTanggal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lodTanggal.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.EditFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.Mask.EditMask = "dd MMMM yyyy"
        Me.lodTanggal.Name = "lodTanggal"
        Me.lodTanggal.ReadOnly = True
        Me.lodTanggal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'lookupjns
        '
        Me.lookupjns.AutoHeight = False
        Me.lookupjns.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupjns.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_trans", "Tipe"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipe_desc", "Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("accronim_desc", "Accronim")})
        Me.lookupjns.Name = "lookupjns"
        '
        'lookupkartu
        '
        Me.lookupkartu.AutoHeight = False
        Me.lookupkartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupkartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Supplier", "Kode."), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama")})
        Me.lookupkartu.Name = "lookupkartu"
        '
        'cbStats
        '
        Me.cbStats.AutoHeight = False
        Me.cbStats.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStats.Items.AddRange(New Object() {"KELUAR"})
        Me.cbStats.Name = "cbStats"
        '
        'cbjns_trans
        '
        Me.cbjns_trans.AutoHeight = False
        Me.cbjns_trans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbjns_trans.Items.AddRange(New Object() {"BELI"})
        Me.cbjns_trans.Name = "cbjns_trans"
        Me.cbjns_trans.NullValuePrompt = "klik Disini"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.cmdAdvance)
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 438)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1129, 53)
        Me.Panel2.TabIndex = 31
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(344, 16)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Untuk menghapus, pilih data dan tekan tombol delete"
        '
        'cmdClear
        '
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(846, 3)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 30)
        Me.cmdClear.TabIndex = 29
        Me.cmdClear.Text = "&Bersih"
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(932, 3)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(80, 30)
        Me.cmdRefresh.TabIndex = 28
        Me.cmdRefresh.Text = "&Reload"
        Me.cmdRefresh.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(674, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(80, 30)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(588, 3)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(80, 30)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        Me.cmdSimpan.Visible = False
        '
        'cbTipeTrans
        '
        Me.cbTipeTrans.AutoHeight = False
        Me.cbTipeTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipeTrans.Items.AddRange(New Object() {"JKK-KUT-02"})
        Me.cbTipeTrans.Name = "cbTipeTrans"
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
        Me.Panel1.Size = New System.Drawing.Size(1129, 49)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 47)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SETTING PEMBEBANAN PUSAT BIAYA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1129, 491)
        Me.pnl.TabIndex = 3
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 49)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVrekening, Me.LOVpusat, Me.LOVstatus})
        Me.GC.Size = New System.Drawing.Size(1129, 389)
        Me.GC.TabIndex = 34
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.GridBand3})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.rek_biaya, Me.rek_pusat_biaya, Me.prosen1, Me.prosen2, Me.prosen3, Me.keterangan, Me.status})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowViewCaption = True
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand1.AppearanceHeader.Options.UseFont = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Biaya"
        Me.GridBand1.Columns.Add(Me.rek_biaya)
        Me.GridBand1.Columns.Add(Me.rek_pusat_biaya)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 150
        '
        'rek_biaya
        '
        Me.rek_biaya.Caption = "Rekening"
        Me.rek_biaya.ColumnEdit = Me.LOVrekening
        Me.rek_biaya.FieldName = "rek_biaya"
        Me.rek_biaya.Name = "rek_biaya"
        Me.rek_biaya.Visible = True
        '
        'LOVrekening
        '
        Me.LOVrekening.AutoHeight = False
        Me.LOVrekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVrekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", " Nama")})
        Me.LOVrekening.Name = "LOVrekening"
        '
        'rek_pusat_biaya
        '
        Me.rek_pusat_biaya.Caption = "Pusat Biaya"
        Me.rek_pusat_biaya.ColumnEdit = Me.LOVpusat
        Me.rek_pusat_biaya.FieldName = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Name = "rek_pusat_biaya"
        Me.rek_pusat_biaya.Visible = True
        '
        'LOVpusat
        '
        Me.LOVpusat.AutoHeight = False
        Me.LOVpusat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVpusat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_pusat", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_pusat", "Nama")})
        Me.LOVpusat.Name = "LOVpusat"
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Pembebanan"
        Me.gridBand2.Columns.Add(Me.prosen1)
        Me.gridBand2.Columns.Add(Me.prosen2)
        Me.gridBand2.Columns.Add(Me.prosen3)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Width = 249
        '
        'prosen1
        '
        Me.prosen1.Caption = "Spring (%)"
        Me.prosen1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.prosen1.FieldName = "prosen1"
        Me.prosen1.Name = "prosen1"
        Me.prosen1.Visible = True
        Me.prosen1.Width = 83
        '
        'prosen2
        '
        Me.prosen2.Caption = "Spoon (%)"
        Me.prosen2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.prosen2.FieldName = "prosen2"
        Me.prosen2.Name = "prosen2"
        Me.prosen2.Visible = True
        Me.prosen2.Width = 83
        '
        'prosen3
        '
        Me.prosen3.Caption = "Extended (%)"
        Me.prosen3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.prosen3.FieldName = "prosen3"
        Me.prosen3.Name = "prosen3"
        Me.prosen3.Visible = True
        Me.prosen3.Width = 83
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBand3.AppearanceHeader.Options.UseFont = True
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "Keterangan"
        Me.GridBand3.Columns.Add(Me.keterangan)
        Me.GridBand3.Columns.Add(Me.status)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 150
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        '
        'status
        '
        Me.status.Caption = "Status"
        Me.status.ColumnEdit = Me.LOVstatus
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        '
        'LOVstatus
        '
        Me.LOVstatus.AutoHeight = False
        Me.LOVstatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVstatus.Items.AddRange(New Object() {"ACTIVE", "TIDAK ACTIVE"})
        Me.LOVstatus.Name = "LOVstatus"
        '
        'frmSetBebanPusBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 491)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSetBebanPusBiaya"
        Me.Text = "frmSetBebanPusBiaya"
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupjns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbjns_trans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbTipeTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVrekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVpusat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdvance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookupval As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupbank As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lodTanggal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents lookupjns As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupkartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbStats As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbjns_trans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cbTipeTrans As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents rek_biaya As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rek_pusat_biaya As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents prosen1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents prosen2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LOVrekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVpusat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVstatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents prosen3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
