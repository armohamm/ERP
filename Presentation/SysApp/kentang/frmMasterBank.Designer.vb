<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterBank))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gcBank = New DevExpress.XtraGrid.GridControl
        Me.gvBank = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nama_bank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_rekening = New DevExpress.XtraGrid.Columns.GridColumn
        Me.alamat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Bk_Besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookUpEditBkBsr = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CekStat = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gcBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditBkBsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcBank)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(821, 527)
        Me.pnl.TabIndex = 0
        '
        'gcBank
        '
        Me.gcBank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBank.Location = New System.Drawing.Point(0, 34)
        Me.gcBank.MainView = Me.gvBank
        Me.gcBank.Name = "gcBank"
        Me.gcBank.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.CekStat, Me.LookUpEditBkBsr})
        Me.gcBank.Size = New System.Drawing.Size(821, 493)
        Me.gcBank.TabIndex = 106
        Me.gcBank.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBank})
        '
        'gvBank
        '
        Me.gvBank.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nama_bank, Me.no_rekening, Me.alamat, Me.Kd_Bk_Besar, Me.Rec_stat})
        Me.gvBank.GridControl = Me.gcBank
        Me.gvBank.Name = "gvBank"
        Me.gvBank.NewItemRowText = "Tambah data baru disini"
        Me.gvBank.OptionsCustomization.AllowColumnMoving = False
        Me.gvBank.OptionsCustomization.AllowFilter = False
        Me.gvBank.OptionsCustomization.AllowGroup = False
        Me.gvBank.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvBank.OptionsView.RowAutoHeight = True
        Me.gvBank.OptionsView.ShowGroupPanel = False
        '
        'nama_bank
        '
        Me.nama_bank.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.nama_bank.AppearanceHeader.Options.UseFont = True
        Me.nama_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.nama_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nama_bank.Caption = "Nama Bank"
        Me.nama_bank.FieldName = "nama_bank"
        Me.nama_bank.Name = "nama_bank"
        Me.nama_bank.Visible = True
        Me.nama_bank.VisibleIndex = 1
        Me.nama_bank.Width = 146
        '
        'no_rekening
        '
        Me.no_rekening.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_rekening.AppearanceHeader.Options.UseFont = True
        Me.no_rekening.AppearanceHeader.Options.UseTextOptions = True
        Me.no_rekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_rekening.Caption = "No. Rekening"
        Me.no_rekening.FieldName = "no_rekening"
        Me.no_rekening.Name = "no_rekening"
        Me.no_rekening.Visible = True
        Me.no_rekening.VisibleIndex = 2
        Me.no_rekening.Width = 92
        '
        'alamat
        '
        Me.alamat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.alamat.AppearanceHeader.Options.UseFont = True
        Me.alamat.AppearanceHeader.Options.UseTextOptions = True
        Me.alamat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.alamat.Caption = "Alamat"
        Me.alamat.FieldName = "alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.Visible = True
        Me.alamat.VisibleIndex = 3
        Me.alamat.Width = 298
        '
        'Kd_Bk_Besar
        '
        Me.Kd_Bk_Besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Kd_Bk_Besar.AppearanceHeader.Options.UseFont = True
        Me.Kd_Bk_Besar.AppearanceHeader.Options.UseTextOptions = True
        Me.Kd_Bk_Besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kd_Bk_Besar.Caption = "Nama Buku Besar"
        Me.Kd_Bk_Besar.ColumnEdit = Me.LookUpEditBkBsr
        Me.Kd_Bk_Besar.FieldName = "Kd_Bk_Besar"
        Me.Kd_Bk_Besar.Name = "Kd_Bk_Besar"
        Me.Kd_Bk_Besar.Visible = True
        Me.Kd_Bk_Besar.VisibleIndex = 3
        Me.Kd_Bk_Besar.Width = 92
        '
        'LookUpEditBkBsr
        '
        Me.LookUpEditBkBsr.AutoHeight = False
        Me.LookUpEditBkBsr.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditBkBsr.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Buku Besar")})
        Me.LookUpEditBkBsr.Name = "LookUpEditBkBsr"
        Me.LookUpEditBkBsr.NullText = "[Pilih Disini]"
        '
        'Rec_stat
        '
        Me.Rec_stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Rec_stat.AppearanceHeader.Options.UseFont = True
        Me.Rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.CekStat
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Visible = True
        Me.Rec_stat.VisibleIndex = 4
        Me.Rec_stat.Width = 63
        '
        'CekStat
        '
        Me.CekStat.AutoHeight = False
        Me.CekStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CekStat.Caption = "AKTIF"
        Me.CekStat.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CekStat.DisplayValueChecked = "AKTIF"
        Me.CekStat.DisplayValueUnchecked = "NonAKTIF"
        Me.CekStat.Name = "CekStat"
        Me.CekStat.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CekStat.ValueChecked = "Y"
        Me.CekStat.ValueUnchecked = "T"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.Panel1.Size = New System.Drawing.Size(821, 34)
        Me.Panel1.TabIndex = 105
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "        MAINTENANCE MASTER BANK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMasterBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 527)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMasterBank"
        Me.Text = "Master Bank"
        Me.pnl.ResumeLayout(False)
        CType(Me.gcBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditBkBsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gcBank As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBank As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nama_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents alamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CekStat As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Kd_Bk_Besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditBkBsr As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_rekening As DevExpress.XtraGrid.Columns.GridColumn
End Class
