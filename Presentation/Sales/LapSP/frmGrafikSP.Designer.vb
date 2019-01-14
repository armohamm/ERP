<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrafikSP
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrafikSP))
        Me.CC = New DevExpress.XtraCharts.ChartControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.xtab = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.txtProgram = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.txtSummary = New DevExpress.XtraEditors.RadioGroup
        Me.End_Date = New DevExpress.XtraEditors.DateEdit
        Me.txtPeriode = New DevExpress.XtraEditors.RadioGroup
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTipe = New DevExpress.XtraEditors.RadioGroup
        Me.txtFilter = New DevExpress.XtraEditors.CheckEdit
        Me.txtProduk = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.Start_Date = New DevExpress.XtraEditors.DateEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.CC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.xtab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtab.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CC
        '
        Me.CC.CacheToMemory = True
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.CC.Diagram = XyDiagram1
        Me.CC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CC.Location = New System.Drawing.Point(0, 242)
        Me.CC.Name = "CC"
        SideBySideBarSeriesLabel1.LineVisible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        SideBySideBarSeriesLabel2.LineVisible = True
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.Name = "Series 2"
        Me.CC.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        SideBySideBarSeriesLabel3.LineVisible = True
        Me.CC.SeriesTemplate.Label = SideBySideBarSeriesLabel3
        Me.CC.Size = New System.Drawing.Size(987, 145)
        Me.CC.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CC)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 387)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.xtab)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(987, 205)
        Me.Panel3.TabIndex = 4
        '
        'xtab
        '
        Me.xtab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtab.Location = New System.Drawing.Point(0, 0)
        Me.xtab.Name = "xtab"
        Me.xtab.SelectedTabPage = Me.XtraTabPage1
        Me.xtab.Size = New System.Drawing.Size(987, 205)
        Me.xtab.TabIndex = 0
        Me.xtab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtProgram)
        Me.XtraTabPage1.Controls.Add(Me.cmdRefresh)
        Me.XtraTabPage1.Controls.Add(Me.txtSummary)
        Me.XtraTabPage1.Controls.Add(Me.End_Date)
        Me.XtraTabPage1.Controls.Add(Me.txtPeriode)
        Me.XtraTabPage1.Controls.Add(Me.Panel4)
        Me.XtraTabPage1.Controls.Add(Me.txtTipe)
        Me.XtraTabPage1.Controls.Add(Me.txtFilter)
        Me.XtraTabPage1.Controls.Add(Me.txtProduk)
        Me.XtraTabPage1.Controls.Add(Me.Start_Date)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(980, 176)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'txtProgram
        '
        Me.txtProgram.EnterMoveNextControl = True
        Me.txtProgram.Location = New System.Drawing.Point(134, 25)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtProgram.Properties.Appearance.Options.UseBackColor = True
        Me.txtProgram.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtProgram.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtProgram.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProgram.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtProgram.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtProgram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProgram.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Divisi")})
        Me.txtProgram.Properties.DisplayMember = "Nama"
        Me.txtProgram.Properties.HideSelection = False
        Me.txtProgram.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtProgram.Properties.NullText = ""
        Me.txtProgram.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtProgram.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtProgram.Properties.PopupWidth = 400
        Me.txtProgram.Properties.ShowHeader = False
        Me.txtProgram.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtProgram.Properties.ValueMember = "Kode"
        Me.txtProgram.Size = New System.Drawing.Size(174, 20)
        Me.txtProgram.TabIndex = 9
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(843, 3)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(134, 39)
        Me.cmdRefresh.TabIndex = 8
        Me.cmdRefresh.Text = "SimpleButton1"
        '
        'txtSummary
        '
        Me.txtSummary.Location = New System.Drawing.Point(134, 113)
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtSummary.Properties.Appearance.Options.UseBackColor = True
        Me.txtSummary.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Qty"), New DevExpress.XtraEditors.Controls.RadioGroupItem("", "Omzet")})
        Me.txtSummary.Size = New System.Drawing.Size(174, 24)
        Me.txtSummary.TabIndex = 7
        '
        'End_Date
        '
        Me.End_Date.EditValue = Nothing
        Me.End_Date.Location = New System.Drawing.Point(256, 91)
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.End_Date.Properties.Appearance.Options.UseBackColor = True
        Me.End_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.End_Date.Properties.DisplayFormat.FormatString = "YYYYmmDD"
        Me.End_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.End_Date.Properties.Mask.EditMask = ""
        Me.End_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.End_Date.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.End_Date.Size = New System.Drawing.Size(116, 20)
        Me.End_Date.TabIndex = 6
        '
        'txtPeriode
        '
        Me.txtPeriode.Location = New System.Drawing.Point(134, 69)
        Me.txtPeriode.Name = "txtPeriode"
        Me.txtPeriode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtPeriode.Properties.Appearance.Options.UseBackColor = True
        Me.txtPeriode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("H", "Harian"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Bulanan"), New DevExpress.XtraEditors.Controls.RadioGroupItem("T", "Tahunan")})
        Me.txtPeriode.Size = New System.Drawing.Size(238, 20)
        Me.txtPeriode.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(128, 176)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipe Summary : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 51)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Periode : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filter Produk : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Departemen : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipe Produk : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipe
        '
        Me.txtTipe.EditValue = ""
        Me.txtTipe.Location = New System.Drawing.Point(134, 3)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTipe.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipe.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Set"), New DevExpress.XtraEditors.Controls.RadioGroupItem("", "Non Set")})
        Me.txtTipe.Size = New System.Drawing.Size(174, 20)
        Me.txtTipe.TabIndex = 1
        '
        'txtFilter
        '
        Me.txtFilter.EditValue = Nothing
        Me.txtFilter.Location = New System.Drawing.Point(134, 47)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtFilter.Properties.Caption = "Filter"
        Me.txtFilter.Size = New System.Drawing.Size(58, 19)
        Me.txtFilter.TabIndex = 2
        '
        'txtProduk
        '
        Me.txtProduk.Location = New System.Drawing.Point(198, 47)
        Me.txtProduk.Name = "txtProduk"
        Me.txtProduk.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtProduk.Properties.Appearance.Options.UseBackColor = True
        Me.txtProduk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtProduk.Size = New System.Drawing.Size(487, 20)
        Me.txtProduk.TabIndex = 3
        '
        'Start_Date
        '
        Me.Start_Date.EditValue = Nothing
        Me.Start_Date.Location = New System.Drawing.Point(134, 91)
        Me.Start_Date.Name = "Start_Date"
        Me.Start_Date.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Start_Date.Properties.Appearance.Options.UseBackColor = True
        Me.Start_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Start_Date.Properties.DisplayFormat.FormatString = "yyyyMMdd"
        Me.Start_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Start_Date.Properties.Mask.EditMask = ""
        Me.Start_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Start_Date.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Start_Date.Size = New System.Drawing.Size(116, 20)
        Me.Start_Date.TabIndex = 5
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(980, 176)
        Me.XtraTabPage2.Text = "XtraTabPage2"
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
        Me.Panel2.Size = New System.Drawing.Size(987, 37)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM SURAT PEMESANAN BUSA SENTIAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmGrafikSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGrafikSP"
        Me.Text = "frmGrafikSP"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.xtab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtab.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.txtProgram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Date.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CC As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents xtab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTipe As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtSummary As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents End_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPeriode As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtFilter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtProduk As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Start_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProgram As DevExpress.XtraEditors.LookUpEdit
End Class
