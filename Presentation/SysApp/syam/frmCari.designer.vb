<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCari))
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.repCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmbKolom = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCari = New System.Windows.Forms.Button
        Me.txtcari = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKolom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtcari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(15, 69)
        Me.GC.LookAndFeel.SkinName = "Black"
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCheck})
        Me.GC.Size = New System.Drawing.Size(947, 314)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.GridControl = Me.GC
        Me.GV.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsCustomization.AllowRowSizing = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.RowAutoHeight = True
        Me.GV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'repCheck
        '
        Me.repCheck.AutoHeight = False
        Me.repCheck.Name = "repCheck"
        Me.repCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repCheck.ValueChecked = "1"
        Me.repCheck.ValueUnchecked = "0"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(15, 15)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelControl1.Size = New System.Drawing.Size(947, 34)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "  PENCARIAN"
        '
        'cmbKolom
        '
        Me.cmbKolom.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.cmbKolom.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbKolom.EditValue = "<Null>"
        Me.cmbKolom.EnterMoveNextControl = True
        Me.cmbKolom.Location = New System.Drawing.Point(110, 0)
        Me.cmbKolom.Name = "cmbKolom"
        Me.cmbKolom.Properties.Appearance.BackColor = System.Drawing.Color.FloralWhite
        Me.cmbKolom.Properties.Appearance.Options.UseBackColor = True
        Me.cmbKolom.Properties.AutoHeight = False
        Me.cmbKolom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmbKolom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKolom.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.cmbKolom.Properties.PopupSizeable = True
        Me.cmbKolom.Size = New System.Drawing.Size(185, 20)
        Me.cmbKolom.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GC)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.LabelControl1)
        Me.Panel5.Location = New System.Drawing.Point(12, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel5.Size = New System.Drawing.Size(979, 439)
        Me.Panel5.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmdOK)
        Me.Panel3.Controls.Add(Me.btnBatal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(15, 383)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(947, 39)
        Me.Panel3.TabIndex = 7
        '
        'cmdOK
        '
        Me.cmdOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(789, 0)
        Me.cmdOK.LookAndFeel.SkinName = "Black"
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(78, 37)
        Me.cmdOK.TabIndex = 5
        Me.cmdOK.Text = "Pilih"
        '
        'btnBatal
        '
        Me.btnBatal.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(867, 0)
        Me.btnBatal.LookAndFeel.SkinName = "Black"
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(78, 37)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Tutup"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.txtcari)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.cmbKolom)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 20)
        Me.Panel1.TabIndex = 8
        '
        'btnCari
        '
        Me.btnCari.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(915, 0)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(32, 20)
        Me.btnCari.TabIndex = 9
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcari.Location = New System.Drawing.Point(405, 0)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Properties.Appearance.BackColor = System.Drawing.Color.FloralWhite
        Me.txtcari.Properties.Appearance.Options.UseBackColor = True
        Me.txtcari.Size = New System.Drawing.Size(542, 20)
        Me.txtcari.TabIndex = 6
        Me.txtcari.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtcari.ToolTipTitle = "Masukan kata Kunci Untuk Menyaring Data"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.BackColor2 = System.Drawing.Color.Gray
        Me.LabelControl3.Appearance.BorderColor = System.Drawing.Color.Yellow
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseBorderColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl3.Location = New System.Drawing.Point(295, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(110, 20)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Kata Kunci : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.BackColor2 = System.Drawing.Color.Gray
        Me.LabelControl2.Appearance.BorderColor = System.Drawing.Color.Yellow
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseBorderColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 20)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Berdasarkan : "
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 170
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 100
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 170
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'frmCari
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 463)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmCari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmCari"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKolom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtcari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbKolom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtcari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents repCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnCari As System.Windows.Forms.Button
End Class
