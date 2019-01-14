<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstHPPFin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstHPPFin))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clmNoUrut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmRekening = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkRekening = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.clmNilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.txtBOM = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkRekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gControl.Location = New System.Drawing.Point(0, 59)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkRekening, Me.ckStatus})
        Me.gControl.Size = New System.Drawing.Size(760, 429)
        Me.gControl.TabIndex = 7
        Me.gControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gView})
        '
        'gView
        '
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmNoUrut, Me.clmRekening, Me.clmNilai, Me.clmKeterangan, Me.clmStatus})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gView.OptionsView.ShowGroupPanel = False
        '
        'clmNoUrut
        '
        Me.clmNoUrut.Caption = "No Urut"
        Me.clmNoUrut.FieldName = "no_urut"
        Me.clmNoUrut.Name = "clmNoUrut"
        Me.clmNoUrut.OptionsColumn.AllowFocus = False
        Me.clmNoUrut.OptionsColumn.ReadOnly = True
        Me.clmNoUrut.Visible = True
        Me.clmNoUrut.VisibleIndex = 0
        Me.clmNoUrut.Width = 76
        '
        'clmRekening
        '
        Me.clmRekening.Caption = "Rekening"
        Me.clmRekening.ColumnEdit = Me.lkRekening
        Me.clmRekening.FieldName = "kd_rek"
        Me.clmRekening.Name = "clmRekening"
        Me.clmRekening.Visible = True
        Me.clmRekening.VisibleIndex = 1
        Me.clmRekening.Width = 164
        '
        'lkRekening
        '
        Me.lkRekening.AutoHeight = False
        Me.lkRekening.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkRekening.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Rekening")})
        Me.lkRekening.DisplayMember = "nm_buku_besar"
        Me.lkRekening.Name = "lkRekening"
        Me.lkRekening.NullText = "[Pilih Rekening]"
        Me.lkRekening.ValueMember = "kd_buku_besar"
        '
        'clmNilai
        '
        Me.clmNilai.Caption = "Nilai"
        Me.clmNilai.FieldName = "nilai_biaya"
        Me.clmNilai.Name = "clmNilai"
        Me.clmNilai.Visible = True
        Me.clmNilai.VisibleIndex = 2
        Me.clmNilai.Width = 127
        '
        'clmKeterangan
        '
        Me.clmKeterangan.Caption = "Keterangan"
        Me.clmKeterangan.FieldName = "keterangan"
        Me.clmKeterangan.Name = "clmKeterangan"
        Me.clmKeterangan.Visible = True
        Me.clmKeterangan.VisibleIndex = 3
        Me.clmKeterangan.Width = 286
        '
        'clmStatus
        '
        Me.clmStatus.Caption = "Status"
        Me.clmStatus.ColumnEdit = Me.ckStatus
        Me.clmStatus.FieldName = "rec_stat"
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.Visible = True
        Me.clmStatus.VisibleIndex = 4
        Me.clmStatus.Width = 86
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.DisplayValueChecked = "Y"
        Me.ckStatus.DisplayValueUnchecked = "N"
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.txtBOM)
        Me.pnlTools.Controls.Add(Me.Label1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(760, 25)
        Me.pnlTools.TabIndex = 5
        '
        'txtBOM
        '
        Me.txtBOM.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtBOM.Location = New System.Drawing.Point(304, 0)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.Properties.Appearance.BackColor = System.Drawing.Color.Pink
        Me.txtBOM.Properties.Appearance.Options.UseBackColor = True
        Me.txtBOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAMA", "Nama")})
        Me.txtBOM.Properties.DisplayMember = "NAMA"
        Me.txtBOM.Properties.NullText = "[Pilih Bill of Material]"
        Me.txtBOM.Properties.ShowHeader = False
        Me.txtBOM.Properties.ValueMember = "KODE"
        Me.txtBOM.Size = New System.Drawing.Size(310, 20)
        Me.txtBOM.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bill Of Material : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblTitle.Size = New System.Drawing.Size(266, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER HPP FINANCE"
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
        'frmMstHPPFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstHPPFin"
        Me.Text = "frmMstHPPFin"
        Me.pnl.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkRekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents txtBOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmNoUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkRekening As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents clmNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
