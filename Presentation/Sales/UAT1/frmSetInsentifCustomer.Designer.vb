<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetInsentifCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetInsentifCustomer))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.repCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Awal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repAwal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Potongan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Departement = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbDivisi = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repAwal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(24, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(804, 271)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 59)
        Me.gc.MainView = Me.GV
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCustomer, Me.repAwal, Me.repDivisi})
        Me.gc.Size = New System.Drawing.Size(804, 212)
        Me.gc.TabIndex = 5
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Awal, Me.Akhir, Me.Potongan, Me.Potongan2, Me.Departement})
        Me.GV.GridControl = Me.gc
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'repCustomer
        '
        Me.repCustomer.AutoHeight = False
        Me.repCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Customer")})
        Me.repCustomer.DisplayMember = "Nama_Customer"
        Me.repCustomer.Name = "repCustomer"
        Me.repCustomer.NullText = ""
        Me.repCustomer.ValueMember = "Kd_Customer"
        '
        'Awal
        '
        Me.Awal.Caption = "Awal"
        Me.Awal.ColumnEdit = Me.repAwal
        Me.Awal.FieldName = "Awal"
        Me.Awal.Name = "Awal"
        Me.Awal.Visible = True
        Me.Awal.VisibleIndex = 1
        Me.Awal.Width = 116
        '
        'repAwal
        '
        Me.repAwal.AutoHeight = False
        Me.repAwal.DisplayFormat.FormatString = "n2"
        Me.repAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repAwal.EditFormat.FormatString = "n2"
        Me.repAwal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repAwal.Name = "repAwal"
        '
        'Akhir
        '
        Me.Akhir.Caption = "Akhir"
        Me.Akhir.ColumnEdit = Me.repAwal
        Me.Akhir.FieldName = "Akhir"
        Me.Akhir.Name = "Akhir"
        Me.Akhir.Visible = True
        Me.Akhir.VisibleIndex = 2
        Me.Akhir.Width = 119
        '
        'Potongan
        '
        Me.Potongan.Caption = "Reward (%)"
        Me.Potongan.ColumnEdit = Me.repAwal
        Me.Potongan.FieldName = "Potongan"
        Me.Potongan.Name = "Potongan"
        Me.Potongan.Visible = True
        Me.Potongan.VisibleIndex = 3
        Me.Potongan.Width = 97
        '
        'Potongan2
        '
        Me.Potongan2.Caption = "Reward2 (%)"
        Me.Potongan2.FieldName = "Potongan2"
        Me.Potongan2.Name = "Potongan2"
        Me.Potongan2.Visible = True
        Me.Potongan2.VisibleIndex = 5
        Me.Potongan2.Width = 107
        '
        'Departement
        '
        Me.Departement.Caption = "Divisi"
        Me.Departement.ColumnEdit = Me.repDivisi
        Me.Departement.FieldName = "Departement"
        Me.Departement.Name = "Departement"
        Me.Departement.Visible = True
        Me.Departement.VisibleIndex = 0
        Me.Departement.Width = 84
        '
        'repDivisi
        '
        Me.repDivisi.AutoHeight = False
        Me.repDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDivisi.DisplayMember = "Nama_Divisi"
        Me.repDivisi.Name = "repDivisi"
        Me.repDivisi.NullText = ""
        Me.repDivisi.ValueMember = "Kode_Divisi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbDivisi)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 22)
        Me.Panel1.TabIndex = 6
        '
        'cmbDivisi
        '
        Me.cmbDivisi.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbDivisi.Location = New System.Drawing.Point(112, 0)
        Me.cmbDivisi.Name = "cmbDivisi"
        Me.cmbDivisi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.Appearance.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmbDivisi.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivisi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbDivisi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmbDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Divisi", 150, "Nama")})
        Me.cmbDivisi.Properties.DisplayMember = "Nama_Divisi"
        Me.cmbDivisi.Properties.HideSelection = False
        Me.cmbDivisi.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbDivisi.Properties.NullText = ""
        Me.cmbDivisi.Properties.PopupWidth = 300
        Me.cmbDivisi.Properties.ShowHeader = False
        Me.cmbDivisi.Properties.ValueMember = "Kode_Divisi"
        Me.cmbDivisi.Size = New System.Drawing.Size(167, 20)
        Me.cmbDivisi.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(112, 20)
        Me.Panel3.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Divisi : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(540, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM SET INSENTIF CUSTOMER"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmSetInsentifCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 342)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSetInsentifCustomer"
        Me.Text = "frmSetInsentifCustomer"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repAwal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cmbDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repAwal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDivisi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Potongan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
