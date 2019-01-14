<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormLK
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormLK))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.chkKas = New DevExpress.XtraEditors.CheckEdit
        Me.chkEkuitas = New DevExpress.XtraEditors.CheckEdit
        Me.chkSHU = New DevExpress.XtraEditors.CheckEdit
        Me.chkNeraca = New DevExpress.XtraEditors.CheckEdit
        Me.lckUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lckPeriode = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.cr_view = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Panel6.SuspendLayout()
        CType(Me.chkKas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEkuitas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSHU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNeraca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(32, 15)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 52)
        Me.cmdRefresh.TabIndex = 39
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.chkKas)
        Me.Panel6.Controls.Add(Me.chkEkuitas)
        Me.Panel6.Controls.Add(Me.chkSHU)
        Me.Panel6.Controls.Add(Me.chkNeraca)
        Me.Panel6.Controls.Add(Me.lckUnit)
        Me.Panel6.Controls.Add(Me.LabelControl3)
        Me.Panel6.Controls.Add(Me.LabelControl4)
        Me.Panel6.Controls.Add(Me.lckPeriode)
        Me.Panel6.Controls.Add(Me.LabelControl2)
        Me.Panel6.Controls.Add(Me.LabelControl1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(150, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(574, 82)
        Me.Panel6.TabIndex = 38
        '
        'chkKas
        '
        Me.DxErrorProvider1.SetIconAlignment(Me.chkKas, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.chkKas.Location = New System.Drawing.Point(403, 38)
        Me.chkKas.Name = "chkKas"
        Me.chkKas.Properties.AutoHeight = False
        Me.chkKas.Properties.Caption = "Arus Kas"
        Me.chkKas.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkKas.Size = New System.Drawing.Size(75, 20)
        Me.chkKas.TabIndex = 9
        '
        'chkEkuitas
        '
        Me.DxErrorProvider1.SetIconAlignment(Me.chkEkuitas, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.chkEkuitas.Location = New System.Drawing.Point(261, 38)
        Me.chkEkuitas.Name = "chkEkuitas"
        Me.chkEkuitas.Properties.AutoHeight = False
        Me.chkEkuitas.Properties.Caption = "Perubahan Ekuitas"
        Me.chkEkuitas.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkEkuitas.Size = New System.Drawing.Size(121, 20)
        Me.chkEkuitas.TabIndex = 8
        '
        'chkSHU
        '
        Me.DxErrorProvider1.SetIconAlignment(Me.chkSHU, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.chkSHU.Location = New System.Drawing.Point(403, 12)
        Me.chkSHU.Name = "chkSHU"
        Me.chkSHU.Properties.AutoHeight = False
        Me.chkSHU.Properties.Caption = "Perhitungan Hasil Usaha"
        Me.chkSHU.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkSHU.Size = New System.Drawing.Size(146, 20)
        Me.chkSHU.TabIndex = 7
        '
        'chkNeraca
        '
        Me.DxErrorProvider1.SetIconAlignment(Me.chkNeraca, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.chkNeraca.Location = New System.Drawing.Point(261, 12)
        Me.chkNeraca.Name = "chkNeraca"
        Me.chkNeraca.Properties.AutoHeight = False
        Me.chkNeraca.Properties.Caption = "Neraca"
        Me.chkNeraca.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkNeraca.Size = New System.Drawing.Size(75, 20)
        Me.chkNeraca.TabIndex = 6
        '
        'lckUnit
        '
        Me.lckUnit.EnterMoveNextControl = True
        Me.DxErrorProvider1.SetIconAlignment(Me.lckUnit, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.lckUnit.Location = New System.Drawing.Point(95, 38)
        Me.lckUnit.Name = "lckUnit"
        Me.lckUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.lckUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckUnit.Properties.ImmediatePopup = True
        Me.lckUnit.Properties.NullText = "[Kosong]"
        Me.lckUnit.Properties.ShowFooter = False
        Me.lckUnit.Properties.ShowHeader = False
        Me.lckUnit.Properties.ShowPopupShadow = False
        Me.lckUnit.Properties.ValidateOnEnterKey = True
        Me.lckUnit.Size = New System.Drawing.Size(140, 20)
        Me.lckUnit.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(78, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(11, 20)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(6, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Unit"
        '
        'lckPeriode
        '
        Me.lckPeriode.EnterMoveNextControl = True
        Me.DxErrorProvider1.SetIconAlignment(Me.lckPeriode, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.lckPeriode.Location = New System.Drawing.Point(95, 12)
        Me.lckPeriode.Name = "lckPeriode"
        Me.lckPeriode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lckPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.lckPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Name1")})
        Me.lckPeriode.Properties.ImmediatePopup = True
        Me.lckPeriode.Properties.NullText = "[Kosong]"
        Me.lckPeriode.Properties.ShowFooter = False
        Me.lckPeriode.Properties.ShowHeader = False
        Me.lckPeriode.Properties.ShowPopupShadow = False
        Me.lckPeriode.Properties.ValidateOnEnterKey = True
        Me.lckPeriode.Size = New System.Drawing.Size(140, 20)
        Me.lckPeriode.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(78, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(6, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Periode"
        '
        'btnprin
        '
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnprin.Location = New System.Drawing.Point(116, 15)
        Me.btnprin.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnprin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(53, 52)
        Me.btnprin.TabIndex = 41
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'cr_view
        '
        Me.cr_view.ActiveViewIndex = -1
        Me.cr_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr_view.DisplayGroupTree = False
        Me.cr_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cr_view.Location = New System.Drawing.Point(0, 0)
        Me.cr_view.Name = "cr_view"
        Me.cr_view.SelectionFormula = ""
        Me.cr_view.ShowCloseButton = False
        Me.cr_view.ShowGroupTreeButton = False
        Me.cr_view.ShowPrintButton = False
        Me.cr_view.ShowRefreshButton = False
        Me.cr_view.ShowZoomButton = False
        Me.cr_view.Size = New System.Drawing.Size(1016, 291)
        Me.cr_view.TabIndex = 0
        Me.cr_view.ViewTimeSelectionFormula = ""
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1016, 373)
        Me.pnl.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cr_view)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 291)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 82)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.btnprin)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(724, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 82)
        Me.Panel3.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 82)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "LAPORAN KEUANGAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'aFormLK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 373)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormLK"
        Me.Text = "aFormLK"
        Me.Panel6.ResumeLayout(False)
        CType(Me.chkKas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEkuitas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSHU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNeraca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lckPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents cr_view As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lckPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lckUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkNeraca As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEkuitas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSHU As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkKas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
