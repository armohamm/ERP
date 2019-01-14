<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApprovePO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApprovePO))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcApprvPO = New DevExpress.XtraGrid.GridControl
        Me.GvApprvPO = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_po = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_supplier = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl.SuspendLayout()
        CType(Me.GcApprvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvApprvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcApprvPO)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 409)
        Me.pnl.TabIndex = 0
        '
        'GcApprvPO
        '
        Me.GcApprvPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvPO.Location = New System.Drawing.Point(0, 34)
        Me.GcApprvPO.MainView = Me.GvApprvPO
        Me.GcApprvPO.Name = "GcApprvPO"
        Me.GcApprvPO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RBrecstat, Me.lookupSupplier})
        Me.GcApprvPO.Size = New System.Drawing.Size(792, 336)
        Me.GcApprvPO.TabIndex = 145
        Me.GcApprvPO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvApprvPO})
        '
        'GvApprvPO
        '
        Me.GvApprvPO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_po, Me.tgl_po, Me.kd_supplier, Me.keterangan, Me.tgl_kirim, Me.status, Me.ket_approve})
        Me.GvApprvPO.GridControl = Me.GcApprvPO
        Me.GvApprvPO.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GvApprvPO.Name = "GvApprvPO"
        Me.GvApprvPO.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GvApprvPO.OptionsView.EnableAppearanceEvenRow = True
        Me.GvApprvPO.OptionsView.EnableAppearanceOddRow = True
        Me.GvApprvPO.OptionsView.RowAutoHeight = True
        Me.GvApprvPO.OptionsView.ShowFooter = True
        Me.GvApprvPO.PaintStyleName = "WindowsXP"
        Me.GvApprvPO.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_po
        '
        Me.no_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_po.AppearanceHeader.Options.UseFont = True
        Me.no_po.AppearanceHeader.Options.UseTextOptions = True
        Me.no_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_po.Caption = "Nomor PO"
        Me.no_po.FieldName = "no_po"
        Me.no_po.Name = "no_po"
        Me.no_po.OptionsColumn.AllowEdit = False
        Me.no_po.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.no_po.Visible = True
        Me.no_po.VisibleIndex = 0
        Me.no_po.Width = 71
        '
        'tgl_po
        '
        Me.tgl_po.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_po.AppearanceHeader.Options.UseFont = True
        Me.tgl_po.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_po.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_po.Caption = "Tanggal PO"
        Me.tgl_po.FieldName = "tgl_po"
        Me.tgl_po.Name = "tgl_po"
        Me.tgl_po.OptionsColumn.AllowEdit = False
        Me.tgl_po.Visible = True
        Me.tgl_po.VisibleIndex = 1
        Me.tgl_po.Width = 71
        '
        'kd_supplier
        '
        Me.kd_supplier.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_supplier.AppearanceHeader.Options.UseFont = True
        Me.kd_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_supplier.Caption = "Supplier Terpilih"
        Me.kd_supplier.ColumnEdit = Me.lookupSupplier
        Me.kd_supplier.FieldName = "kd_supplier"
        Me.kd_supplier.Name = "kd_supplier"
        Me.kd_supplier.OptionsColumn.AllowEdit = False
        Me.kd_supplier.Visible = True
        Me.kd_supplier.VisibleIndex = 2
        Me.kd_supplier.Width = 100
        '
        'lookupSupplier
        '
        Me.lookupSupplier.AutoHeight = False
        Me.lookupSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupSupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Supplier", "Nama Supplier")})
        Me.lookupSupplier.Name = "lookupSupplier"
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
        Me.keterangan.VisibleIndex = 4
        Me.keterangan.Width = 93
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.Caption = "Tgl Janji Kirim"
        Me.tgl_kirim.FieldName = "tgl_kirim"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.OptionsColumn.AllowEdit = False
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.VisibleIndex = 3
        Me.tgl_kirim.Width = 113
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Approve"
        Me.status.ColumnEdit = Me.RBrecstat
        Me.status.FieldName = "rec_stat"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 5
        Me.status.Width = 72
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
        Me.ket_approve.VisibleIndex = 6
        Me.ket_approve.Width = 235
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
        Me.Panel1.TabIndex = 143
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 6
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
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "APPROVAL PO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 370)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 39)
        Me.Panel2.TabIndex = 144
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(433, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSimpan.Location = New System.Drawing.Point(294, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "&Update"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "nama divisi")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'FrmApprovePO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 409)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmApprovePO"
        Me.Text = "APPROVAL PO"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcApprvPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvApprvPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GcApprvPO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvApprvPO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
