<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormKalkulasiJurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormKalkulasiJurnal))
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlFill = New System.Windows.Forms.Panel
        Me.gcJurnal = New DevExpress.XtraGrid.GridControl
        Me.gvJurnal = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupRek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.debet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kredit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.pnlNoJurnal = New System.Windows.Forms.Panel
        Me.txtNoJurnal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnKalkulasi = New DevExpress.XtraEditors.SimpleButton
        Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlFill.SuspendLayout()
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupRek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlNoJurnal.SuspendLayout()
        CType(Me.txtNoJurnal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlFill)
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlHeader)
        Me.pnl.Location = New System.Drawing.Point(111, 104)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(600, 371)
        Me.pnl.TabIndex = 0
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.gcJurnal)
        Me.pnlFill.Controls.Add(Me.Panel5)
        Me.pnlFill.Controls.Add(Me.Panel4)
        Me.pnlFill.Controls.Add(Me.Panel2)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFill.Location = New System.Drawing.Point(77, 67)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(450, 178)
        Me.pnlFill.TabIndex = 8
        '
        'gcJurnal
        '
        Me.gcJurnal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcJurnal.Location = New System.Drawing.Point(0, 30)
        Me.gcJurnal.MainView = Me.gvJurnal
        Me.gcJurnal.Name = "gcJurnal"
        Me.gcJurnal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupRek})
        Me.gcJurnal.Size = New System.Drawing.Size(450, 148)
        Me.gcJurnal.TabIndex = 8
        Me.gcJurnal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJurnal})
        '
        'gvJurnal
        '
        Me.gvJurnal.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvJurnal.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvJurnal.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvJurnal.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvJurnal.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvJurnal.Appearance.ViewCaption.Options.UseFont = True
        Me.gvJurnal.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gvJurnal.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvJurnal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_buku_besar, Me.debet, Me.kredit})
        Me.gvJurnal.GridControl = Me.gcJurnal
        Me.gvJurnal.Name = "gvJurnal"
        Me.gvJurnal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvJurnal.OptionsBehavior.Editable = False
        Me.gvJurnal.OptionsBehavior.ReadOnly = True
        Me.gvJurnal.OptionsView.ShowFooter = True
        Me.gvJurnal.OptionsView.ShowGroupPanel = False
        Me.gvJurnal.OptionsView.ShowIndicator = False
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_buku_besar.AppearanceHeader.Options.UseFont = True
        Me.kd_buku_besar.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_buku_besar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_buku_besar.Caption = "Rekening"
        Me.kd_buku_besar.ColumnEdit = Me.lookupRek
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        Me.kd_buku_besar.Visible = True
        Me.kd_buku_besar.VisibleIndex = 0
        '
        'lookupRek
        '
        Me.lookupRek.AutoHeight = False
        Me.lookupRek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupRek.Name = "lookupRek"
        '
        'debet
        '
        Me.debet.Caption = "Rp. Debet"
        Me.debet.DisplayFormat.FormatString = "n2"
        Me.debet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.debet.FieldName = "debet"
        Me.debet.Name = "debet"
        Me.debet.SummaryItem.DisplayFormat = "{0:n2}"
        Me.debet.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.debet.Visible = True
        Me.debet.VisibleIndex = 1
        '
        'kredit
        '
        Me.kredit.Caption = "Rp. Kredit"
        Me.kredit.DisplayFormat.FormatString = "n2"
        Me.kredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.kredit.FieldName = "kredit"
        Me.kredit.Name = "kredit"
        Me.kredit.SummaryItem.DisplayFormat = "{0:n2}"
        Me.kredit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.kredit.Visible = True
        Me.kredit.VisibleIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(450, 5)
        Me.Panel5.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnRefresh)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.pnlNoJurnal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 20)
        Me.Panel4.TabIndex = 6
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Location = New System.Drawing.Point(305, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 20)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(300, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 20)
        Me.Panel7.TabIndex = 4
        '
        'pnlNoJurnal
        '
        Me.pnlNoJurnal.Controls.Add(Me.txtNoJurnal)
        Me.pnlNoJurnal.Controls.Add(Me.LabelControl2)
        Me.pnlNoJurnal.Controls.Add(Me.LabelControl1)
        Me.pnlNoJurnal.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNoJurnal.Location = New System.Drawing.Point(0, 0)
        Me.pnlNoJurnal.Name = "pnlNoJurnal"
        Me.pnlNoJurnal.Size = New System.Drawing.Size(300, 20)
        Me.pnlNoJurnal.TabIndex = 2
        '
        'txtNoJurnal
        '
        Me.txtNoJurnal.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNoJurnal.EnterMoveNextControl = True
        Me.txtNoJurnal.Location = New System.Drawing.Point(75, 0)
        Me.txtNoJurnal.Name = "txtNoJurnal"
        Me.txtNoJurnal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoJurnal.Properties.ValidateOnEnterKey = True
        Me.txtNoJurnal.Size = New System.Drawing.Size(225, 20)
        Me.txtNoJurnal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(70, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(5, 20)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(70, 20)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "No. Jurnal"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 5)
        Me.Panel2.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(2, 67)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(75, 178)
        Me.Panel6.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnKalkulasi)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 99)
        Me.Panel1.TabIndex = 5
        '
        'btnKalkulasi
        '
        Me.btnKalkulasi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnKalkulasi.Appearance.Options.UseFont = True
        Me.btnKalkulasi.Location = New System.Drawing.Point(221, 54)
        Me.btnKalkulasi.Name = "btnKalkulasi"
        Me.btnKalkulasi.Size = New System.Drawing.Size(155, 23)
        Me.btnKalkulasi.TabIndex = 4
        Me.btnKalkulasi.Text = "Kalkulasi Neraca"
        '
        'btnGenerate
        '
        Me.btnGenerate.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGenerate.Appearance.Options.UseFont = True
        Me.btnGenerate.Location = New System.Drawing.Point(221, 14)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(155, 23)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate Jurnal"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(596, 30)
        Me.Panel3.TabIndex = 4
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(2, 344)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(596, 25)
        Me.pnlFooter.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Maroon
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Font = New System.Drawing.Font("Arial Narrow", 16.0!)
        Me.pnlHeader.ForeColor = System.Drawing.Color.Gold
        Me.pnlHeader.Location = New System.Drawing.Point(2, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(596, 35)
        Me.pnlHeader.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 35)
        Me.lblJudul.TabIndex = 9
        Me.lblJudul.Text = "KALKULASI JURNAL"
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
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'aFormKalkulasiJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 586)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormKalkulasiJurnal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "aFormKalkulasiJurnal"
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlFill.ResumeLayout(False)
        CType(Me.gcJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJurnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupRek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlNoJurnal.ResumeLayout(False)
        CType(Me.txtNoJurnal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlFill As System.Windows.Forms.Panel
    Friend WithEvents gcJurnal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJurnal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents debet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupRek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlNoJurnal As System.Windows.Forms.Panel
    Friend WithEvents txtNoJurnal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKalkulasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
End Class
