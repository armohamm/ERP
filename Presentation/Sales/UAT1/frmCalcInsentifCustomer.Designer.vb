<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcInsentifCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalcInsentifCustomer))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Customer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCust = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ThnBln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.thnbln2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.omzet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.insentif = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.txtTahun = New DevExpress.XtraEditors.DateEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1006, 414)
        Me.pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1006, 338)
        Me.Panel3.TabIndex = 8
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.GV
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCust, Me.repNum, Me.repDivisi})
        Me.gc.Size = New System.Drawing.Size(1006, 338)
        Me.gc.TabIndex = 0
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Customer, Me.ThnBln, Me.Potongan, Me.thnbln2, Me.omzet, Me.insentif, Me.Divisi})
        Me.GV.GridControl = Me.gc
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Kd_Customer
        '
        Me.Kd_Customer.Caption = "Customer"
        Me.Kd_Customer.ColumnEdit = Me.repCust
        Me.Kd_Customer.FieldName = "Kd_Customer"
        Me.Kd_Customer.Name = "Kd_Customer"
        Me.Kd_Customer.Visible = True
        Me.Kd_Customer.VisibleIndex = 0
        Me.Kd_Customer.Width = 356
        '
        'repCust
        '
        Me.repCust.AutoHeight = False
        Me.repCust.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCust.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Name1")})
        Me.repCust.DisplayMember = "Nama_Customer"
        Me.repCust.Name = "repCust"
        Me.repCust.ValueMember = "Kd_Customer"
        '
        'ThnBln
        '
        Me.ThnBln.Caption = "Periode"
        Me.ThnBln.FieldName = "ThnBln"
        Me.ThnBln.Name = "ThnBln"
        '
        'Potongan
        '
        Me.Potongan.Caption = "Insentif"
        Me.Potongan.ColumnEdit = Me.repNum
        Me.Potongan.DisplayFormat.FormatString = "n2"
        Me.Potongan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Potongan.FieldName = "Potongan"
        Me.Potongan.Name = "Potongan"
        Me.Potongan.Width = 100
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.DisplayFormat.FormatString = "n2"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'thnbln2
        '
        Me.thnbln2.Caption = "Periode"
        Me.thnbln2.FieldName = "GridColumn1"
        Me.thnbln2.Name = "thnbln2"
        Me.thnbln2.UnboundExpression = "Substring([ThnBln],  4,2 ) + ' - ' +Substring([ThnBln],  0,4 )"
        Me.thnbln2.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.thnbln2.Visible = True
        Me.thnbln2.VisibleIndex = 1
        Me.thnbln2.Width = 114
        '
        'omzet
        '
        Me.omzet.Caption = "Omzet"
        Me.omzet.ColumnEdit = Me.repNum
        Me.omzet.FieldName = "Omzet"
        Me.omzet.Name = "omzet"
        Me.omzet.Visible = True
        Me.omzet.VisibleIndex = 3
        Me.omzet.Width = 115
        '
        'insentif
        '
        Me.insentif.Caption = "Potongan"
        Me.insentif.ColumnEdit = Me.repNum
        Me.insentif.FieldName = "Potongan"
        Me.insentif.Name = "insentif"
        Me.insentif.Visible = True
        Me.insentif.VisibleIndex = 4
        Me.insentif.Width = 95
        '
        'Divisi
        '
        Me.Divisi.Caption = "Divisi"
        Me.Divisi.ColumnEdit = Me.repDivisi
        Me.Divisi.FieldName = "Divisi"
        Me.Divisi.Name = "Divisi"
        Me.Divisi.Visible = True
        Me.Divisi.VisibleIndex = 2
        Me.Divisi.Width = 90
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 39)
        Me.Panel2.TabIndex = 7
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Appearance.Options.UseForeColor = True
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(373, 0)
        Me.btnRefresh.LookAndFeel.SkinName = "Lilian"
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(84, 39)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Hitung"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtCustomer)
        Me.Panel4.Controls.Add(Me.txtTahun)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(93, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(280, 39)
        Me.Panel4.TabIndex = 14
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCustomer.Location = New System.Drawing.Point(0, 20)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", "Customer")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.NullText = ""
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(280, 18)
        Me.txtCustomer.TabIndex = 29
        '
        'txtTahun
        '
        Me.txtTahun.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTahun.EditValue = Nothing
        Me.txtTahun.Location = New System.Drawing.Point(0, 0)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun.Properties.Appearance.Options.UseFont = True
        Me.txtTahun.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTahun.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTahun.Properties.DisplayFormat.FormatString = "MMM yyyy"
        Me.txtTahun.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTahun.Properties.EditFormat.FormatString = "MMM yyyy"
        Me.txtTahun.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtTahun.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtTahun.Properties.Mask.EditMask = "MMM yyyy"
        Me.txtTahun.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtTahun.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTahun.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtTahun.Size = New System.Drawing.Size(280, 20)
        Me.txtTahun.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(93, 39)
        Me.Panel5.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Customer :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Periode :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 37)
        Me.Panel1.TabIndex = 4
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
        Me.lblJudul.Text = "FORM PERHITUNGAN INSENTIF CUSTOMER"
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
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(457, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(537, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = ")* OPEN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCalcInsentifCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 414)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmCalcInsentifCustomer"
        Me.Text = "frmCalcInsentifCustomer"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtTahun As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kd_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ThnBln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCust As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents thnbln2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents omzet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents insentif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
