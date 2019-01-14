<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstUltahCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstUltahCustomer))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcTipe = New DevExpress.XtraGrid.GridControl
        Me.GvTipe = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Telp1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_Lahir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupJnsBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DE_TglUltah = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Btn_Refresh = New DevExpress.XtraEditors.SimpleButton
        Me.pnl.SuspendLayout()
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DE_TglUltah.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DE_TglUltah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcTipe)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 373)
        Me.pnl.TabIndex = 0
        '
        'GcTipe
        '
        Me.GcTipe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcTipe.Location = New System.Drawing.Point(0, 45)
        Me.GcTipe.MainView = Me.GvTipe
        Me.GcTipe.Name = "GcTipe"
        Me.GcTipe.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupJnsBrg, Me.CekStat, Me.repMerk, Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1})
        Me.GcTipe.Size = New System.Drawing.Size(1004, 328)
        Me.GcTipe.TabIndex = 32
        Me.GcTipe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvTipe})
        '
        'GvTipe
        '
        Me.GvTipe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Cust, Me.Nama_cust, Me.Alamat1, Me.No_Telp1, Me.Tgl_Lahir})
        Me.GvTipe.GridControl = Me.GcTipe
        Me.GvTipe.Name = "GvTipe"
        Me.GvTipe.OptionsCustomization.AllowColumnMoving = False
        Me.GvTipe.OptionsCustomization.AllowGroup = False
        Me.GvTipe.OptionsView.ColumnAutoWidth = False
        Me.GvTipe.OptionsView.RowAutoHeight = True
        Me.GvTipe.OptionsView.ShowGroupPanel = False
        '
        'Kd_Cust
        '
        Me.Kd_Cust.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Cust.Caption = "Kode Customer"
        Me.Kd_Cust.FieldName = "Kd_Customer"
        Me.Kd_Cust.Name = "Kd_Cust"
        Me.Kd_Cust.OptionsColumn.AllowEdit = False
        Me.Kd_Cust.Visible = True
        Me.Kd_Cust.VisibleIndex = 0
        Me.Kd_Cust.Width = 91
        '
        'Nama_cust
        '
        Me.Nama_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_cust.Caption = "Nama Customer"
        Me.Nama_cust.FieldName = "Atas_Nama"
        Me.Nama_cust.Name = "Nama_cust"
        Me.Nama_cust.OptionsColumn.AllowEdit = False
        Me.Nama_cust.Visible = True
        Me.Nama_cust.VisibleIndex = 1
        Me.Nama_cust.Width = 279
        '
        'Alamat1
        '
        Me.Alamat1.AppearanceHeader.Options.UseTextOptions = True
        Me.Alamat1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Alamat1.Caption = "Alamat Customer"
        Me.Alamat1.FieldName = "Almt_pnrm"
        Me.Alamat1.Name = "Alamat1"
        Me.Alamat1.OptionsColumn.AllowEdit = False
        Me.Alamat1.Visible = True
        Me.Alamat1.VisibleIndex = 2
        Me.Alamat1.Width = 549
        '
        'No_Telp1
        '
        Me.No_Telp1.AppearanceHeader.Options.UseTextOptions = True
        Me.No_Telp1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_Telp1.Caption = "No Telpon"
        Me.No_Telp1.FieldName = "No_Telp"
        Me.No_Telp1.Name = "No_Telp1"
        Me.No_Telp1.OptionsColumn.AllowEdit = False
        Me.No_Telp1.Visible = True
        Me.No_Telp1.VisibleIndex = 3
        Me.No_Telp1.Width = 136
        '
        'Tgl_Lahir
        '
        Me.Tgl_Lahir.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Tgl_Lahir.AppearanceCell.Options.UseBackColor = True
        Me.Tgl_Lahir.AppearanceHeader.Options.UseTextOptions = True
        Me.Tgl_Lahir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tgl_Lahir.Caption = "Tanggal Lahir"
        Me.Tgl_Lahir.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.Tgl_Lahir.FieldName = "tgl_lahir"
        Me.Tgl_Lahir.Name = "Tgl_Lahir"
        Me.Tgl_Lahir.OptionsColumn.AllowEdit = False
        Me.Tgl_Lahir.Visible = True
        Me.Tgl_Lahir.VisibleIndex = 4
        Me.Tgl_Lahir.Width = 115
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LookupJnsBrg
        '
        Me.LookupJnsBrg.AutoHeight = False
        Me.LookupJnsBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupJnsBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Jenis Barang")})
        Me.LookupJnsBrg.DropDownRows = 10
        Me.LookupJnsBrg.Name = "LookupJnsBrg"
        Me.LookupJnsBrg.NullText = "klik disini"
        Me.LookupJnsBrg.PopupWidth = 250
        Me.LookupJnsBrg.ShowFooter = False
        Me.LookupJnsBrg.ShowHeader = False
        Me.LookupJnsBrg.ShowLines = False
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "Y"
        Me.CekStat.DisplayValueChecked = "Y"
        Me.CekStat.DisplayValueUnchecked = "T"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'repMerk
        '
        Me.repMerk.AutoHeight = False
        Me.repMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", 250, "Merk")})
        Me.repMerk.DisplayMember = "Nama_Merk"
        Me.repMerk.Name = "repMerk"
        Me.repMerk.NullText = ""
        Me.repMerk.PopupWidth = 250
        Me.repMerk.ShowFooter = False
        Me.repMerk.ShowHeader = False
        Me.repMerk.ShowLines = False
        Me.repMerk.ValueMember = "Kode_Merk"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "0.00"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_Refresh)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DE_TglUltah)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 45)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Monitoring Hari Ulang Tahun Customer Service"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DE_TglUltah
        '
        Me.DE_TglUltah.EditValue = Nothing
        Me.DE_TglUltah.Location = New System.Drawing.Point(624, 8)
        Me.DE_TglUltah.Name = "DE_TglUltah"
        Me.DE_TglUltah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DE_TglUltah.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DE_TglUltah.Size = New System.Drawing.Size(146, 20)
        Me.DE_TglUltah.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(529, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Filter Tanggal :"
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.Location = New System.Drawing.Point(785, 5)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Refresh.TabIndex = 186
        Me.Btn_Refresh.Text = "Refresh"
        '
        'frmMstUltahCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstUltahCustomer"
        Me.Text = "frmMstLimitPiutang"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DE_TglUltah.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DE_TglUltah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcTipe As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvTipe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_Lahir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupJnsBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_Telp1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DE_TglUltah As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_Refresh As DevExpress.XtraEditors.SimpleButton
End Class
