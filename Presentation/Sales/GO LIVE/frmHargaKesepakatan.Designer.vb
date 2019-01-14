<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHargaKesepakatan
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHargaKesepakatan))
        Me.states = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KD_STOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.txtFilter = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'states
        '
        Me.states.Caption = "GridColumn1"
        Me.states.FieldName = "state"
        Me.states.Name = "states"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1012, 321)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 58)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCustomer, Me.repBarang, Me.repNum})
        Me.GC.Size = New System.Drawing.Size(1012, 263)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Customer, Me.harga, Me.keterangan, Me.states, Me.KD_STOK})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.states
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.states
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = ""
        StyleFormatCondition2.Value1 = "2"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Kd_Customer
        '
        Me.Kd_Customer.Caption = "Customer"
        Me.Kd_Customer.ColumnEdit = Me.repCustomer
        Me.Kd_Customer.FieldName = "Kd_Customer"
        Me.Kd_Customer.Name = "Kd_Customer"
        Me.Kd_Customer.Visible = True
        Me.Kd_Customer.VisibleIndex = 0
        Me.Kd_Customer.Width = 247
        '
        'repCustomer
        '
        Me.repCustomer.AutoHeight = False
        Me.repCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCustomer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 200, "Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", "Kode", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.repCustomer.DisplayMember = "Nama_Customer"
        Me.repCustomer.DropDownRows = 15
        Me.repCustomer.Name = "repCustomer"
        Me.repCustomer.NullText = ""
        Me.repCustomer.PopupWidth = 300
        Me.repCustomer.ShowFooter = False
        Me.repCustomer.ShowHeader = False
        Me.repCustomer.ShowLines = False
        Me.repCustomer.ShowPopupShadow = False
        Me.repCustomer.ValueMember = "Kd_Customer"
        '
        'harga
        '
        Me.harga.Caption = "Harga"
        Me.harga.ColumnEdit = Me.repNum
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 2
        Me.harga.Width = 122
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.DisplayFormat.FormatString = "n2"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.EditFormat.FormatString = "n2"
        Me.repNum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 3
        Me.keterangan.Width = 360
        '
        'KD_STOK
        '
        Me.KD_STOK.Caption = "Kualitas"
        Me.KD_STOK.ColumnEdit = Me.repBarang
        Me.KD_STOK.FieldName = "KD_STOK"
        Me.KD_STOK.Name = "KD_STOK"
        Me.KD_STOK.Visible = True
        Me.KD_STOK.VisibleIndex = 1
        Me.KD_STOK.Width = 262
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 250, "Barang")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.DropDownRows = 15
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = ""
        Me.repBarang.PopupWidth = 300
        Me.repBarang.ShowFooter = False
        Me.repBarang.ShowHeader = False
        Me.repBarang.ShowLines = False
        Me.repBarang.ShowPopupShadow = False
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.cmdClear)
        Me.Panel2.Controls.Add(Me.txtFilter)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 21)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Location = New System.Drawing.Point(319, 0)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 21)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "Hapus Filter"
        '
        'txtFilter
        '
        Me.txtFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFilter.Location = New System.Drawing.Point(134, 0)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFilter.Properties.Appearance.Options.UseBackColor = True
        Me.txtFilter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFilter.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", 100, "Kode Customer"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 200, "Nama")})
        Me.txtFilter.Properties.DisplayMember = "Nama_Customer"
        Me.txtFilter.Properties.DropDownRows = 15
        Me.txtFilter.Properties.NullText = ""
        Me.txtFilter.Properties.PopupFormMinSize = New System.Drawing.Size(350, 0)
        Me.txtFilter.Properties.ValueMember = "Kd_Customer"
        Me.txtFilter.Size = New System.Drawing.Size(185, 20)
        Me.txtFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Customer  : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 37)
        Me.Panel1.TabIndex = 3
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
        Me.lblJudul.Text = "MAINTENANCE HARGA KESEPAKATAN"
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
        'frmHargaKesepakatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 321)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmHargaKesepakatan"
        Me.Text = "frmHargaSponBox"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents states As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KD_STOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtFilter As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
