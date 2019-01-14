<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstHPPBahan
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstHPPBahan))
        Me.gChild = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cnourut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cnmbrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cjmlbrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.csatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cnilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clmNoUrut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.clmJumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmSatuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSatuan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.clmNilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnlHdrRgt = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtRevisi = New System.Windows.Forms.TextBox
        Me.txtKetBOM = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlHdrLft = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtNoDokBOM = New DevExpress.XtraEditors.TextEdit
        Me.txtBOM = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        Me.pnlHdrRgt.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlHdrLft.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gChild
        '
        Me.gChild.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cnourut, Me.cnmbrg, Me.cjmlbrg, Me.csatuan, Me.cnilai})
        Me.gChild.GridControl = Me.gControl
        Me.gChild.Name = "gChild"
        Me.gChild.OptionsView.ShowGroupPanel = False
        '
        'cnourut
        '
        Me.cnourut.Caption = "No"
        Me.cnourut.FieldName = "no_urut"
        Me.cnourut.Name = "cnourut"
        Me.cnourut.OptionsColumn.AllowEdit = False
        Me.cnourut.Visible = True
        Me.cnourut.VisibleIndex = 0
        Me.cnourut.Width = 51
        '
        'cnmbrg
        '
        Me.cnmbrg.Caption = "Nama Barang"
        Me.cnmbrg.FieldName = "Nama_Barang"
        Me.cnmbrg.Name = "cnmbrg"
        Me.cnmbrg.OptionsColumn.AllowEdit = False
        Me.cnmbrg.Visible = True
        Me.cnmbrg.VisibleIndex = 1
        Me.cnmbrg.Width = 170
        '
        'cjmlbrg
        '
        Me.cjmlbrg.Caption = "Jumlah"
        Me.cjmlbrg.FieldName = "jumlah"
        Me.cjmlbrg.Name = "cjmlbrg"
        Me.cjmlbrg.OptionsColumn.AllowEdit = False
        Me.cjmlbrg.Visible = True
        Me.cjmlbrg.VisibleIndex = 2
        Me.cjmlbrg.Width = 170
        '
        'csatuan
        '
        Me.csatuan.Caption = "Satuan"
        Me.csatuan.FieldName = "satuan"
        Me.csatuan.Name = "csatuan"
        Me.csatuan.OptionsColumn.AllowEdit = False
        Me.csatuan.Visible = True
        Me.csatuan.VisibleIndex = 3
        Me.csatuan.Width = 170
        '
        'cnilai
        '
        Me.cnilai.Caption = "Nilai"
        Me.cnilai.FieldName = "nilai_biaya"
        Me.cnilai.Name = "cnilai"
        Me.cnilai.Visible = True
        Me.cnilai.VisibleIndex = 4
        Me.cnilai.Width = 178
        '
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gChild
        GridLevelNode1.RelationName = "Level1"
        Me.gControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gControl.Location = New System.Drawing.Point(0, 94)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtBarang, Me.txtSatuan, Me.ckStatus})
        Me.gControl.Size = New System.Drawing.Size(760, 394)
        Me.gControl.TabIndex = 7
        Me.gControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gView, Me.gChild})
        '
        'gView
        '
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmNoUrut, Me.clmKodeBarang, Me.clmJumlah, Me.clmSatuan, Me.clmNilai, Me.clmKeterangan, Me.clmStatus})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.OptionsView.ShowGroupPanel = False
        '
        'clmNoUrut
        '
        Me.clmNoUrut.Caption = "No Urut"
        Me.clmNoUrut.FieldName = "no_urut"
        Me.clmNoUrut.MinWidth = 10
        Me.clmNoUrut.Name = "clmNoUrut"
        Me.clmNoUrut.OptionsColumn.AllowEdit = False
        Me.clmNoUrut.OptionsColumn.AllowFocus = False
        Me.clmNoUrut.OptionsColumn.ReadOnly = True
        Me.clmNoUrut.Visible = True
        Me.clmNoUrut.VisibleIndex = 0
        Me.clmNoUrut.Width = 53
        '
        'clmKodeBarang
        '
        Me.clmKodeBarang.Caption = "Nama Barang"
        Me.clmKodeBarang.ColumnEdit = Me.txtBarang
        Me.clmKodeBarang.FieldName = "kd_barang"
        Me.clmKodeBarang.Name = "clmKodeBarang"
        Me.clmKodeBarang.OptionsColumn.AllowEdit = False
        Me.clmKodeBarang.Visible = True
        Me.clmKodeBarang.VisibleIndex = 1
        Me.clmKodeBarang.Width = 123
        '
        'txtBarang
        '
        Me.txtBarang.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtBarang.AutoHeight = False
        Me.txtBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama")})
        Me.txtBarang.DisplayMember = "Nama_Barang"
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.NullText = "[Pilih Jenis Barang]"
        Me.txtBarang.ShowHeader = False
        Me.txtBarang.ValueMember = "Kode_Barang"
        '
        'clmJumlah
        '
        Me.clmJumlah.Caption = "Jumlah"
        Me.clmJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmJumlah.FieldName = "jumlah"
        Me.clmJumlah.Name = "clmJumlah"
        Me.clmJumlah.OptionsColumn.AllowEdit = False
        Me.clmJumlah.Visible = True
        Me.clmJumlah.VisibleIndex = 2
        Me.clmJumlah.Width = 84
        '
        'clmSatuan
        '
        Me.clmSatuan.Caption = "Satuan"
        Me.clmSatuan.ColumnEdit = Me.txtSatuan
        Me.clmSatuan.FieldName = "satuan"
        Me.clmSatuan.Name = "clmSatuan"
        Me.clmSatuan.OptionsColumn.AllowEdit = False
        Me.clmSatuan.Visible = True
        Me.clmSatuan.VisibleIndex = 3
        Me.clmSatuan.Width = 99
        '
        'txtSatuan
        '
        Me.txtSatuan.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtSatuan.AutoHeight = False
        Me.txtSatuan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txtSatuan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSatuan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Satuan", "Nama")})
        Me.txtSatuan.DisplayMember = "Nama_Satuan"
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.NullText = "[Pilih Jenis Satuan]"
        Me.txtSatuan.ShowHeader = False
        Me.txtSatuan.ValueMember = "Kode_Satuan"
        '
        'clmNilai
        '
        Me.clmNilai.Caption = "Nilai"
        Me.clmNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmNilai.FieldName = "nilai_biaya"
        Me.clmNilai.Name = "clmNilai"
        Me.clmNilai.Visible = True
        Me.clmNilai.VisibleIndex = 4
        Me.clmNilai.Width = 97
        '
        'clmKeterangan
        '
        Me.clmKeterangan.Caption = "Keterangan"
        Me.clmKeterangan.FieldName = "keterangan"
        Me.clmKeterangan.Name = "clmKeterangan"
        Me.clmKeterangan.Visible = True
        Me.clmKeterangan.VisibleIndex = 5
        Me.clmKeterangan.Width = 177
        '
        'clmStatus
        '
        Me.clmStatus.Caption = "Status"
        Me.clmStatus.ColumnEdit = Me.ckStatus
        Me.clmStatus.FieldName = "rec_stat"
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.Visible = True
        Me.clmStatus.VisibleIndex = 6
        Me.clmStatus.Width = 106
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.DisplayValueChecked = "Y"
        Me.ckStatus.DisplayValueUnchecked = "N"
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gControl)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(760, 488)
        Me.pnl.TabIndex = 0
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.pnlHdrRgt)
        Me.pnlTools.Controls.Add(Me.pnlHdrLft)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(760, 60)
        Me.pnlTools.TabIndex = 5
        '
        'pnlHdrRgt
        '
        Me.pnlHdrRgt.Controls.Add(Me.Panel5)
        Me.pnlHdrRgt.Controls.Add(Me.Panel4)
        Me.pnlHdrRgt.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHdrRgt.Location = New System.Drawing.Point(415, 0)
        Me.pnlHdrRgt.Name = "pnlHdrRgt"
        Me.pnlHdrRgt.Size = New System.Drawing.Size(345, 60)
        Me.pnlHdrRgt.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtRevisi)
        Me.Panel5.Controls.Add(Me.txtKetBOM)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(104, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 60)
        Me.Panel5.TabIndex = 4
        '
        'txtRevisi
        '
        Me.txtRevisi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRevisi.Location = New System.Drawing.Point(0, 20)
        Me.txtRevisi.Name = "txtRevisi"
        Me.txtRevisi.Size = New System.Drawing.Size(238, 20)
        Me.txtRevisi.TabIndex = 1
        '
        'txtKetBOM
        '
        Me.txtKetBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKetBOM.Location = New System.Drawing.Point(0, 0)
        Me.txtKetBOM.Name = "txtKetBOM"
        Me.txtKetBOM.Size = New System.Drawing.Size(238, 20)
        Me.txtKetBOM.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(104, 60)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. Revisi : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Keterangan : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlHdrLft
        '
        Me.pnlHdrLft.Controls.Add(Me.Panel3)
        Me.pnlHdrLft.Controls.Add(Me.Panel2)
        Me.pnlHdrLft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHdrLft.Location = New System.Drawing.Point(0, 0)
        Me.pnlHdrLft.Name = "pnlHdrLft"
        Me.pnlHdrLft.Size = New System.Drawing.Size(415, 60)
        Me.pnlHdrLft.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNoDokBOM)
        Me.Panel3.Controls.Add(Me.txtBOM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(116, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 60)
        Me.Panel3.TabIndex = 2
        '
        'txtNoDokBOM
        '
        Me.txtNoDokBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoDokBOM.Location = New System.Drawing.Point(0, 20)
        Me.txtNoDokBOM.Name = "txtNoDokBOM"
        Me.txtNoDokBOM.Size = New System.Drawing.Size(293, 20)
        Me.txtNoDokBOM.TabIndex = 1
        '
        'txtBOM
        '
        Me.txtBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBOM.Location = New System.Drawing.Point(0, 0)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.Properties.Appearance.BackColor = System.Drawing.Color.Pink
        Me.txtBOM.Properties.Appearance.Options.UseBackColor = True
        Me.txtBOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bom", "Nama")})
        Me.txtBOM.Properties.DisplayMember = "nama_bom"
        Me.txtBOM.Properties.NullText = "[Pilih Bill Of Material]"
        Me.txtBOM.Properties.ShowHeader = False
        Me.txtBOM.Properties.ValueMember = "kd_bom"
        Me.txtBOM.Size = New System.Drawing.Size(293, 20)
        Me.txtBOM.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 60)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. Dokumen : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bill Of Material : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(760, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(247, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER HPP BAHAN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmMstHPPBahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstHPPBahan"
        Me.Text = "frmMstHPPBahan"
        CType(Me.gChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.pnlHdrRgt.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.pnlHdrLft.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnlHdrRgt As System.Windows.Forms.Panel
    Friend WithEvents pnlHdrLft As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNoDokBOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtKetBOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmNoUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents clmJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSatuan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents clmKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gChild As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRevisi As System.Windows.Forms.TextBox
    Friend WithEvents cnourut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cnmbrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cjmlbrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents csatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cnilai As DevExpress.XtraGrid.Columns.GridColumn
End Class
