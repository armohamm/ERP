<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormMFee
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormMFee))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.gcFee = New DevExpress.XtraGrid.GridControl
        Me.gvFee = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_brg_bom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repLookBarangBOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_brg_fee = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repLookBarangFee = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.prosen_fee = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNumPersen = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCheckStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.gcFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repLookBarangBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repLookBarangFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNumPersen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCheckStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcFee)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(978, 550)
        Me.pnl.TabIndex = 0
        '
        'gcFee
        '
        Me.gcFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcFee.Location = New System.Drawing.Point(2, 37)
        Me.gcFee.MainView = Me.gvFee
        Me.gcFee.Name = "gcFee"
        Me.gcFee.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repLookBarangBOM, Me.repLookBarangFee, Me.repNumPersen, Me.repCheckStat})
        Me.gcFee.Size = New System.Drawing.Size(974, 486)
        Me.gcFee.TabIndex = 35
        Me.gcFee.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFee})
        '
        'gvFee
        '
        Me.gvFee.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvFee.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvFee.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvFee.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvFee.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_brg_bom, Me.kd_brg_fee, Me.prosen_fee, Me.keterangan, Me.status})
        Me.gvFee.GridControl = Me.gcFee
        Me.gvFee.Name = "gvFee"
        Me.gvFee.NewItemRowText = "Tambah data disini"
        Me.gvFee.OptionsView.EnableAppearanceEvenRow = True
        Me.gvFee.OptionsView.EnableAppearanceOddRow = True
        Me.gvFee.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvFee.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvFee.OptionsView.ShowFooter = True
        Me.gvFee.OptionsView.ShowGroupPanel = False
        Me.gvFee.OptionsView.ShowIndicator = False
        '
        'kd_brg_bom
        '
        Me.kd_brg_bom.Caption = "Barang BOM"
        Me.kd_brg_bom.ColumnEdit = Me.repLookBarangBOM
        Me.kd_brg_bom.FieldName = "kd_brg_bom"
        Me.kd_brg_bom.Name = "kd_brg_bom"
        '
        'repLookBarangBOM
        '
        Me.repLookBarangBOM.AutoHeight = False
        Me.repLookBarangBOM.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.repLookBarangBOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repLookBarangBOM.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bom", "Name1")})
        Me.repLookBarangBOM.Name = "repLookBarangBOM"
        Me.repLookBarangBOM.NullText = "[Kosong]"
        Me.repLookBarangBOM.ShowFooter = False
        Me.repLookBarangBOM.ShowHeader = False
        Me.repLookBarangBOM.ShowPopupShadow = False
        Me.repLookBarangBOM.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repLookBarangBOM.ValidateOnEnterKey = True
        '
        'kd_brg_fee
        '
        Me.kd_brg_fee.Caption = "Barang Fee"
        Me.kd_brg_fee.ColumnEdit = Me.repLookBarangFee
        Me.kd_brg_fee.FieldName = "kd_brg_fee"
        Me.kd_brg_fee.Name = "kd_brg_fee"
        Me.kd_brg_fee.Visible = True
        Me.kd_brg_fee.VisibleIndex = 0
        '
        'repLookBarangFee
        '
        Me.repLookBarangFee.AutoHeight = False
        Me.repLookBarangFee.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.repLookBarangFee.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repLookBarangFee.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bom", "Name2")})
        Me.repLookBarangFee.Name = "repLookBarangFee"
        Me.repLookBarangFee.NullText = "[Kosong]"
        Me.repLookBarangFee.ShowFooter = False
        Me.repLookBarangFee.ShowHeader = False
        Me.repLookBarangFee.ShowPopupShadow = False
        Me.repLookBarangFee.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.repLookBarangFee.ValidateOnEnterKey = True
        '
        'prosen_fee
        '
        Me.prosen_fee.Caption = "% Fee"
        Me.prosen_fee.ColumnEdit = Me.repNumPersen
        Me.prosen_fee.FieldName = "prosen_fee"
        Me.prosen_fee.Name = "prosen_fee"
        Me.prosen_fee.Visible = True
        Me.prosen_fee.VisibleIndex = 1
        '
        'repNumPersen
        '
        Me.repNumPersen.AutoHeight = False
        Me.repNumPersen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.repNumPersen.DisplayFormat.FormatString = "n2"
        Me.repNumPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNumPersen.Mask.EditMask = "n2"
        Me.repNumPersen.Mask.UseMaskAsDisplayFormat = True
        Me.repNumPersen.MaxLength = 3
        Me.repNumPersen.Name = "repNumPersen"
        Me.repNumPersen.ValidateOnEnterKey = True
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 2
        '
        'status
        '
        Me.status.Caption = "Status"
        Me.status.ColumnEdit = Me.repCheckStat
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 3
        '
        'repCheckStat
        '
        Me.repCheckStat.AutoHeight = False
        Me.repCheckStat.Name = "repCheckStat"
        Me.repCheckStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repCheckStat.ValueChecked = "Y"
        Me.repCheckStat.ValueUnchecked = "N"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 523)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 25)
        Me.Panel1.TabIndex = 34
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(974, 35)
        Me.pnlTop.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM MASTER SETTING FEE PRODUK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'aFormMFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 574)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormMFee"
        Me.Text = "aFormMFee"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.gcFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repLookBarangBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repLookBarangFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNumPersen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCheckStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gcFee As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFee As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_brg_bom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_brg_fee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prosen_fee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repLookBarangBOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repLookBarangFee As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repNumPersen As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents repCheckStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
