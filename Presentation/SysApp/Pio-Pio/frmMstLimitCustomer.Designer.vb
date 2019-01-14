<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstLimitCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstLimitCustomer))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcTipe = New DevExpress.XtraGrid.GridControl
        Me.GvTipe = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Alamat1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Telp1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Limit_Rupiah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Limit_Spon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Limit_Valas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupJnsBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GcTipe.Location = New System.Drawing.Point(0, 34)
        Me.GcTipe.MainView = Me.GvTipe
        Me.GcTipe.Name = "GcTipe"
        Me.GcTipe.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.LookupJnsBrg, Me.CekStat, Me.repMerk, Me.RepositoryItemTextEdit1})
        Me.GcTipe.Size = New System.Drawing.Size(1004, 339)
        Me.GcTipe.TabIndex = 32
        Me.GcTipe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvTipe})
        '
        'GvTipe
        '
        Me.GvTipe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Cust, Me.Nama_cust, Me.Alamat1, Me.No_Telp1, Me.Limit_Rupiah, Me.Limit_Spon, Me.Limit_Valas})
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
        Me.Nama_cust.FieldName = "Nama_Customer"
        Me.Nama_cust.Name = "Nama_cust"
        Me.Nama_cust.OptionsColumn.AllowEdit = False
        Me.Nama_cust.Visible = True
        Me.Nama_cust.VisibleIndex = 1
        Me.Nama_cust.Width = 277
        '
        'Alamat1
        '
        Me.Alamat1.AppearanceHeader.Options.UseTextOptions = True
        Me.Alamat1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Alamat1.Caption = "Alamat Customer"
        Me.Alamat1.FieldName = "Alamat1"
        Me.Alamat1.Name = "Alamat1"
        Me.Alamat1.OptionsColumn.AllowEdit = False
        Me.Alamat1.Visible = True
        Me.Alamat1.VisibleIndex = 2
        Me.Alamat1.Width = 284
        '
        'No_Telp1
        '
        Me.No_Telp1.AppearanceHeader.Options.UseTextOptions = True
        Me.No_Telp1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_Telp1.Caption = "No Telpon"
        Me.No_Telp1.FieldName = "No_Telepon1"
        Me.No_Telp1.Name = "No_Telp1"
        Me.No_Telp1.OptionsColumn.AllowEdit = False
        Me.No_Telp1.Visible = True
        Me.No_Telp1.VisibleIndex = 3
        Me.No_Telp1.Width = 104
        '
        'Limit_Rupiah
        '
        Me.Limit_Rupiah.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Limit_Rupiah.AppearanceCell.Options.UseBackColor = True
        Me.Limit_Rupiah.AppearanceHeader.Options.UseTextOptions = True
        Me.Limit_Rupiah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Limit_Rupiah.Caption = "Limit Piutang Rupiah Spring"
        Me.Limit_Rupiah.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Limit_Rupiah.FieldName = "Limit_Piutang_Rupiah"
        Me.Limit_Rupiah.Name = "Limit_Rupiah"
        Me.Limit_Rupiah.Visible = True
        Me.Limit_Rupiah.VisibleIndex = 4
        Me.Limit_Rupiah.Width = 115
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
        'Limit_Spon
        '
        Me.Limit_Spon.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Limit_Spon.AppearanceCell.Options.UseBackColor = True
        Me.Limit_Spon.AppearanceHeader.Options.UseTextOptions = True
        Me.Limit_Spon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Limit_Spon.Caption = "Limit Piutang Rupiah Spon"
        Me.Limit_Spon.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Limit_Spon.FieldName = "Limit_Piutang_Spon"
        Me.Limit_Spon.Name = "Limit_Spon"
        Me.Limit_Spon.Visible = True
        Me.Limit_Spon.VisibleIndex = 5
        '
        'Limit_Valas
        '
        Me.Limit_Valas.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Limit_Valas.AppearanceCell.Options.UseBackColor = True
        Me.Limit_Valas.AppearanceHeader.Options.UseTextOptions = True
        Me.Limit_Valas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Limit_Valas.Caption = "Limit Piutang Valas (USD)"
        Me.Limit_Valas.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Limit_Valas.FieldName = "Limit_Piutang_Valas"
        Me.Limit_Valas.Name = "Limit_Valas"
        Me.Limit_Valas.Visible = True
        Me.Limit_Valas.VisibleIndex = 6
        Me.Limit_Valas.Width = 149
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
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
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
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          Maintenance Limit Piutang Customer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMstLimitCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstLimitCustomer"
        Me.Text = "frmMstLimitPiutang"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupJnsBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcTipe As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvTipe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Alamat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Limit_Rupiah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Limit_Valas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupJnsBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents repMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_Telp1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Limit_Spon As DevExpress.XtraGrid.Columns.GridColumn
End Class
