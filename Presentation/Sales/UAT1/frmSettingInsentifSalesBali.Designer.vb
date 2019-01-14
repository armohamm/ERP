<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingInsentifSalesBali
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingInsentifSalesBali))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Batas_Awal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Batas_Akhir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Komisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Pengali = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtTgl = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtMerk2 = New DevExpress.XtraEditors.LookUpEdit
        Me.txtMerk1 = New DevExpress.XtraEditors.LookUpEdit
        Me.txtisSpon = New DevExpress.XtraEditors.RadioGroup
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerk2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerk1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtisSpon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Location = New System.Drawing.Point(36, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(994, 326)
        Me.pnl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GC)
        Me.Panel1.Controls.Add(Me.txtTgl)
        Me.Panel1.Controls.Add(Me.txtNomor)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtStatus)
        Me.Panel1.Controls.Add(Me.txtMerk2)
        Me.Panel1.Controls.Add(Me.txtMerk1)
        Me.Panel1.Controls.Add(Me.txtisSpon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 292)
        Me.Panel1.TabIndex = 140
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(54, 168)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 140
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "* Produk :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GC
        '
        Me.GC.Location = New System.Drawing.Point(290, 3)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.Size = New System.Drawing.Size(701, 135)
        Me.GC.TabIndex = 139
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Batas_Awal, Me.Batas_Akhir, Me.Komisi, Me.Pengali})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'Batas_Awal
        '
        Me.Batas_Awal.Caption = "Batas_Awal"
        Me.Batas_Awal.FieldName = "Batas_Awal"
        Me.Batas_Awal.Name = "Batas_Awal"
        Me.Batas_Awal.Visible = True
        Me.Batas_Awal.VisibleIndex = 0
        '
        'Batas_Akhir
        '
        Me.Batas_Akhir.Caption = "Batas_Akhir"
        Me.Batas_Akhir.FieldName = "Batas_Akhir"
        Me.Batas_Akhir.Name = "Batas_Akhir"
        Me.Batas_Akhir.Visible = True
        Me.Batas_Akhir.VisibleIndex = 1
        '
        'Komisi
        '
        Me.Komisi.Caption = "Komisi"
        Me.Komisi.FieldName = "Komisi"
        Me.Komisi.Name = "Komisi"
        Me.Komisi.Visible = True
        Me.Komisi.VisibleIndex = 2
        '
        'Pengali
        '
        Me.Pengali.Caption = "Pengali"
        Me.Pengali.FieldName = "Pengali"
        Me.Pengali.Name = "Pengali"
        Me.Pengali.Visible = True
        Me.Pengali.VisibleIndex = 3
        '
        'txtTgl
        '
        Me.txtTgl.Location = New System.Drawing.Point(120, 23)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(164, 20)
        Me.txtTgl.TabIndex = 12
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(120, 2)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(164, 20)
        Me.txtNomor.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "* Status :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Merk 2 :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "* Merk 1 :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStatus
        '
        Me.txtStatus.EditValue = "Y"
        Me.txtStatus.Location = New System.Drawing.Point(120, 118)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStatus.Properties.Items.AddRange(New Object() {"Y", "T"})
        Me.txtStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtStatus.Size = New System.Drawing.Size(164, 20)
        Me.txtStatus.TabIndex = 15
        '
        'txtMerk2
        '
        Me.txtMerk2.Location = New System.Drawing.Point(120, 96)
        Me.txtMerk2.Name = "txtMerk2"
        Me.txtMerk2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMerk2.Properties.DisplayMember = "Nama_Merk"
        Me.txtMerk2.Properties.NullText = ""
        Me.txtMerk2.Properties.ValueMember = "Kode_Merk"
        Me.txtMerk2.Size = New System.Drawing.Size(164, 20)
        Me.txtMerk2.TabIndex = 14
        '
        'txtMerk1
        '
        Me.txtMerk1.Location = New System.Drawing.Point(120, 74)
        Me.txtMerk1.Name = "txtMerk1"
        Me.txtMerk1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMerk1.Properties.DisplayMember = "Nama_Merk"
        Me.txtMerk1.Properties.NullText = ""
        Me.txtMerk1.Properties.ValueMember = "Kode_Merk"
        Me.txtMerk1.Size = New System.Drawing.Size(164, 20)
        Me.txtMerk1.TabIndex = 13
        '
        'txtisSpon
        '
        Me.txtisSpon.Location = New System.Drawing.Point(120, 46)
        Me.txtisSpon.Name = "txtisSpon"
        Me.txtisSpon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtisSpon.Properties.Appearance.Options.UseBackColor = True
        Me.txtisSpon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtisSpon.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Spring", "Spring"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Spon", "Spon")})
        Me.txtisSpon.Size = New System.Drawing.Size(164, 22)
        Me.txtisSpon.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 34)
        Me.Panel2.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM MASTER INSENTIF SALES SPRING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmSettingInsentifSalesBali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 366)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmSettingInsentifSalesBali"
        Me.Text = "frmSettingInsentifSalesBali"
        Me.pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerk2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerk1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtisSpon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Batas_Awal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Batas_Akhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Komisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pengali As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTgl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMerk2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMerk1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtisSpon As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
