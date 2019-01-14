<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasing
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.GcPR = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoDPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_Diperlukan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupSup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.btn_supp = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.dttglpr = New DevExpress.XtraEditors.DateEdit
        Me.txtNomor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RepBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengah.SuspendLayout()
        CType(Me.GcPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dttglpr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglpr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 34)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM PURCHASE REQUEST MATERIAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.table_selection_column
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.GcPR)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(961, 414)
        Me.pnlTengah.TabIndex = 4
        '
        'GcPR
        '
        Me.GcPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcPR.Location = New System.Drawing.Point(0, 42)
        Me.GcPR.MainView = Me.GV
        Me.GcPR.Name = "GcPR"
        Me.GcPR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.LookupGudang, Me.lookupSup, Me.lookupbrg})
        Me.GcPR.Size = New System.Drawing.Size(961, 372)
        Me.GcPR.TabIndex = 7
        Me.GcPR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoDPM, Me.no_trans, Me.sat, Me.qty_order, Me.qty_pr, Me.qty_sisa, Me.Tgl_Diperlukan, Me.Ket})
        Me.GV.GridControl = Me.GcPR
        Me.GV.Name = "GV"
        '
        'NoDPM
        '
        Me.NoDPM.Caption = "No DPM"
        Me.NoDPM.FieldName = "no_dpm"
        Me.NoDPM.Name = "NoDPM"
        Me.NoDPM.OptionsColumn.AllowEdit = False
        Me.NoDPM.OptionsColumn.AllowFocus = False
        Me.NoDPM.Visible = True
        Me.NoDPM.VisibleIndex = 0
        Me.NoDPM.Width = 120
        '
        'no_trans
        '
        Me.no_trans.Caption = "Nama Barang"
        Me.no_trans.ColumnEdit = Me.lookupbrg
        Me.no_trans.FieldName = "kd_stok"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.AllowFocus = False
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 1
        Me.no_trans.Width = 148
        '
        'lookupbrg
        '
        Me.lookupbrg.AutoHeight = False
        Me.lookupbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "NamaBarang")})
        Me.lookupbrg.Name = "lookupbrg"
        '
        'sat
        '
        Me.sat.Caption = "Satuan"
        Me.sat.FieldName = "satuan"
        Me.sat.Name = "sat"
        Me.sat.OptionsColumn.AllowEdit = False
        Me.sat.OptionsColumn.AllowFocus = False
        Me.sat.Visible = True
        Me.sat.VisibleIndex = 2
        Me.sat.Width = 67
        '
        'qty_order
        '
        Me.qty_order.Caption = "Qty Order"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.AllowFocus = False
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 3
        Me.qty_order.Width = 81
        '
        'qty_pr
        '
        Me.qty_pr.Caption = "Qty PR"
        Me.qty_pr.FieldName = "qty_pr"
        Me.qty_pr.Name = "qty_pr"
        Me.qty_pr.Visible = True
        Me.qty_pr.VisibleIndex = 4
        Me.qty_pr.Width = 108
        '
        'qty_sisa
        '
        Me.qty_sisa.Caption = "Qty Sisa"
        Me.qty_sisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_sisa.FieldName = "qty_sisa"
        Me.qty_sisa.Name = "qty_sisa"
        Me.qty_sisa.OptionsColumn.AllowEdit = False
        Me.qty_sisa.OptionsColumn.AllowFocus = False
        Me.qty_sisa.Visible = True
        Me.qty_sisa.VisibleIndex = 5
        Me.qty_sisa.Width = 94
        '
        'Tgl_Diperlukan
        '
        Me.Tgl_Diperlukan.Caption = "Tanggal Diperlukan"
        Me.Tgl_Diperlukan.FieldName = "Tgl_Diperlukan"
        Me.Tgl_Diperlukan.Name = "Tgl_Diperlukan"
        Me.Tgl_Diperlukan.OptionsColumn.AllowEdit = False
        Me.Tgl_Diperlukan.OptionsColumn.AllowFocus = False
        Me.Tgl_Diperlukan.Visible = True
        Me.Tgl_Diperlukan.VisibleIndex = 6
        Me.Tgl_Diperlukan.Width = 172
        '
        'Ket
        '
        Me.Ket.Caption = "Keterangan"
        Me.Ket.FieldName = "keterangan"
        Me.Ket.Name = "Ket"
        Me.Ket.Visible = True
        Me.Ket.VisibleIndex = 7
        Me.Ket.Width = 150
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Name = "LookupBarang"
        '
        'LookupGudang
        '
        Me.LookupGudang.AutoHeight = False
        Me.LookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Name = "LookupGudang"
        '
        'lookupSup
        '
        Me.lookupSup.AutoHeight = False
        Me.lookupSup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupSup.Name = "lookupSup"
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.btn_supp)
        Me.pnlTengahAtas.Controls.Add(Me.PanelControl1)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(961, 42)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'btn_supp
        '
        Me.btn_supp.Enabled = False
        Me.btn_supp.Location = New System.Drawing.Point(576, 3)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(75, 23)
        Me.btn_supp.TabIndex = 7
        Me.btn_supp.Text = "Pilih Supplier"
        Me.btn_supp.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.Controls.Add(Me.dttglpr)
        Me.PanelControl1.Controls.Add(Me.txtNomor)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(248, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(312, 42)
        Me.PanelControl1.TabIndex = 6
        '
        'dttglpr
        '
        Me.dttglpr.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttglpr.EditValue = Nothing
        Me.dttglpr.Location = New System.Drawing.Point(2, 22)
        Me.dttglpr.Name = "dttglpr"
        Me.dttglpr.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dttglpr.Properties.Appearance.Options.UseBackColor = True
        Me.dttglpr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttglpr.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttglpr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttglpr.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dttglpr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttglpr.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dttglpr.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttglpr.Size = New System.Drawing.Size(308, 20)
        Me.dttglpr.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(2, 2)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(308, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 42)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RepBarang
        '
        Me.RepBarang.Appearance.Options.UseImage = True
        Me.RepBarang.AutoHeight = False
        Me.RepBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 125, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 450, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 75, "Satuan")})
        Me.RepBarang.DisplayMember = "Nama_Barang"
        Me.RepBarang.DropDownRows = 15
        Me.RepBarang.HideSelection = False
        Me.RepBarang.Name = "RepBarang"
        Me.RepBarang.NullText = "[Pilih Barang]"
        Me.RepBarang.PopupWidth = 700
        Me.RepBarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepBarang.ValueMember = "Kode_Barang"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(2, 2)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(961, 448)
        Me.pnl.TabIndex = 3
        '
        'FrmPurchasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 462)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmPurchasing"
        Me.Text = "FORM PURCHASING MATERIAL"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengah.ResumeLayout(False)
        CType(Me.GcPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dttglpr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglpr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents RepBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dttglpr As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents GcPR As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoDPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupSup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_Diperlukan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_supp As DevExpress.XtraEditors.SimpleButton
End Class
