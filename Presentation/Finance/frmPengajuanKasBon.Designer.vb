<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengajuanKasBon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPengajuanKasBon))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlGrid = New DevExpress.XtraEditors.PanelControl
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LOVGridKartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kurs_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.lblError = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopScnd = New System.Windows.Forms.Panel
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.pnlTopMst = New System.Windows.Forms.Panel
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.lblState = New DevExpress.XtraEditors.LabelControl
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LOVKartu = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtketerangan = New DevExpress.XtraEditors.MemoEdit
        Me.LOVValuta = New DevExpress.XtraEditors.LookUpEdit
        Me.TglPengajuan = New DevExpress.XtraEditors.DateEdit
        Me.txtJumlah = New DevExpress.XtraEditors.TextEdit
        Me.txtKursVal = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LOV_Unit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pnl.SuspendLayout()
        CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVGridKartu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlTopScnd.SuspendLayout()
        Me.pnlTopMst.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.LOVKartu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOVValuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglPengajuan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglPengajuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKursVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOV_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(414, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(70, 212)
        Me.Panel3.TabIndex = 1
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlGrid)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.pnlTopScnd)
        Me.pnl.Controls.Add(Me.pnlTopMst)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(837, 544)
        Me.pnl.TabIndex = 3
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.GC)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 285)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(837, 228)
        Me.pnlGrid.TabIndex = 8
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(2, 2)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LOVGridKartu})
        Me.GC.Size = New System.Drawing.Size(833, 224)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GV.Appearance.Row.Options.UseFont = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomor, Me.tgl_trans, Me.kd_kartu, Me.kd_valuta, Me.kurs_valuta, Me.keterangan, Me.jml_trans})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsBehavior.Editable = False
        Me.GV.OptionsBehavior.ReadOnly = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'nomor
        '
        Me.nomor.Caption = "Nomor"
        Me.nomor.FieldName = "nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        '
        'kd_kartu
        '
        Me.kd_kartu.Caption = "Kartu"
        Me.kd_kartu.ColumnEdit = Me.LOVGridKartu
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 2
        '
        'LOVGridKartu
        '
        Me.LOVGridKartu.AutoHeight = False
        Me.LOVGridKartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVGridKartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.LOVGridKartu.Name = "LOVGridKartu"
        Me.LOVGridKartu.NullText = "[Pilih kartu]"
        '
        'kd_valuta
        '
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 3
        '
        'kurs_valuta
        '
        Me.kurs_valuta.Caption = "Kurs"
        Me.kurs_valuta.FieldName = "kurs_valuta"
        Me.kurs_valuta.Name = "kurs_valuta"
        Me.kurs_valuta.Visible = True
        Me.kurs_valuta.VisibleIndex = 4
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        '
        'jml_trans
        '
        Me.jml_trans.Caption = "Jml. Trans"
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 6
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Controls.Add(Me.lblError)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 513)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(837, 31)
        Me.pnlFooter.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblError.Appearance.Options.UseFont = True
        Me.lblError.Appearance.Options.UseForeColor = True
        Me.lblError.Location = New System.Drawing.Point(12, 6)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "..."
        '
        'pnlTopScnd
        '
        Me.pnlTopScnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopScnd.Controls.Add(Me.LabelControl8)
        Me.pnlTopScnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopScnd.Location = New System.Drawing.Point(0, 257)
        Me.pnlTopScnd.Name = "pnlTopScnd"
        Me.pnlTopScnd.Size = New System.Drawing.Size(837, 28)
        Me.pnlTopScnd.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(3, 9)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(229, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Pilih data di bawah untuk edit dan delete"
        '
        'pnlTopMst
        '
        Me.pnlTopMst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopMst.Controls.Add(Me.LabelControl19)
        Me.pnlTopMst.Controls.Add(Me.cmdDelete)
        Me.pnlTopMst.Controls.Add(Me.cmdPrint)
        Me.pnlTopMst.Controls.Add(Me.cmdSimpan)
        Me.pnlTopMst.Controls.Add(Me.lblState)
        Me.pnlTopMst.Controls.Add(Me.cmdClear)
        Me.pnlTopMst.Controls.Add(Me.cmdRefresh)
        Me.pnlTopMst.Controls.Add(Me.Panel4)
        Me.pnlTopMst.Controls.Add(Me.Panel3)
        Me.pnlTopMst.Controls.Add(Me.Panel6)
        Me.pnlTopMst.Controls.Add(Me.Panel7)
        Me.pnlTopMst.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMst.Location = New System.Drawing.Point(0, 45)
        Me.pnlTopMst.Name = "pnlTopMst"
        Me.pnlTopMst.Size = New System.Drawing.Size(837, 212)
        Me.pnlTopMst.TabIndex = 5
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(536, 190)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl19.TabIndex = 21
        Me.LabelControl19.Text = "*wajib diisi"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(536, 76)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(82, 23)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(580, 6)
        Me.cmdPrint.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(38, 38)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Visible = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(536, 47)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(82, 23)
        Me.cmdSimpan.TabIndex = 14
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.Visible = False
        '
        'lblState
        '
        Me.lblState.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblState.Appearance.Options.UseFont = True
        Me.lblState.Appearance.Options.UseForeColor = True
        Me.lblState.Location = New System.Drawing.Point(536, 132)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(15, 19)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "..."
        Me.lblState.Visible = False
        '
        'cmdClear
        '
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(624, 6)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 38)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(536, 6)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(38, 38)
        Me.cmdRefresh.TabIndex = 0
        Me.cmdRefresh.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(484, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(46, 212)
        Me.Panel4.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LOV_Unit)
        Me.Panel6.Controls.Add(Me.LOVKartu)
        Me.Panel6.Controls.Add(Me.LabelControl12)
        Me.Panel6.Controls.Add(Me.LabelControl11)
        Me.Panel6.Controls.Add(Me.LabelControl10)
        Me.Panel6.Controls.Add(Me.LabelControl9)
        Me.Panel6.Controls.Add(Me.LabelControl20)
        Me.Panel6.Controls.Add(Me.txtketerangan)
        Me.Panel6.Controls.Add(Me.LOVValuta)
        Me.Panel6.Controls.Add(Me.TglPengajuan)
        Me.Panel6.Controls.Add(Me.txtJumlah)
        Me.Panel6.Controls.Add(Me.txtKursVal)
        Me.Panel6.Controls.Add(Me.txtNomor)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(139, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(275, 212)
        Me.Panel6.TabIndex = 5
        '
        'LOVKartu
        '
        Me.LOVKartu.EditValue = "[Nama]"
        Me.LOVKartu.Location = New System.Drawing.Point(0, 46)
        Me.LOVKartu.Name = "LOVKartu"
        Me.LOVKartu.Properties.AutoComplete = False
        Me.LOVKartu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOVKartu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVKartu.Properties.ImmediatePopup = True
        Me.LOVKartu.Properties.NullText = ""
        Me.LOVKartu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LOVKartu.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LOVKartu.Properties.ShowFooter = False
        Me.LOVKartu.Properties.ShowPopupShadow = False
        Me.LOVKartu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LOVKartu.Properties.ValidateOnEnterKey = True
        Me.LOVKartu.Properties.View = Me.GridLookUpEdit1View
        Me.LOVKartu.Size = New System.Drawing.Size(245, 20)
        Me.LOVKartu.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowHorzLines = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        Me.GridLookUpEdit1View.OptionsView.ShowVertLines = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(247, 89)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl12.TabIndex = 36
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(247, 68)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl11.TabIndex = 35
        Me.LabelControl11.Text = "*"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(247, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl10.TabIndex = 34
        Me.LabelControl10.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(248, 112)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl9.TabIndex = 33
        Me.LabelControl9.Text = "*"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(248, 46)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(10, 19)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = "*"
        '
        'txtketerangan
        '
        Me.txtketerangan.EnterMoveNextControl = True
        Me.txtketerangan.Location = New System.Drawing.Point(0, 134)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(245, 45)
        Me.txtketerangan.TabIndex = 5
        '
        'LOVValuta
        '
        Me.LOVValuta.EnterMoveNextControl = True
        Me.LOVValuta.Location = New System.Drawing.Point(0, 68)
        Me.LOVValuta.Name = "LOVValuta"
        Me.LOVValuta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LOVValuta.Properties.Appearance.Options.UseBackColor = True
        Me.LOVValuta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOVValuta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama Valuta")})
        Me.LOVValuta.Properties.NullText = ""
        Me.LOVValuta.Size = New System.Drawing.Size(245, 20)
        Me.LOVValuta.TabIndex = 2
        '
        'TglPengajuan
        '
        Me.TglPengajuan.EditValue = Nothing
        Me.TglPengajuan.EnterMoveNextControl = True
        Me.TglPengajuan.Location = New System.Drawing.Point(0, 24)
        Me.TglPengajuan.Name = "TglPengajuan"
        Me.TglPengajuan.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TglPengajuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglPengajuan.Properties.Appearance.Options.UseBackColor = True
        Me.TglPengajuan.Properties.Appearance.Options.UseFont = True
        Me.TglPengajuan.Properties.Appearance.Options.UseTextOptions = True
        Me.TglPengajuan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TglPengajuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglPengajuan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.TglPengajuan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglPengajuan.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.TglPengajuan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TglPengajuan.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.TglPengajuan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TglPengajuan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.TglPengajuan.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.TglPengajuan.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TglPengajuan.Size = New System.Drawing.Size(245, 20)
        Me.TglPengajuan.TabIndex = 0
        '
        'txtJumlah
        '
        Me.txtJumlah.EnterMoveNextControl = True
        Me.txtJumlah.Location = New System.Drawing.Point(0, 112)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Properties.DisplayFormat.FormatString = "n2"
        Me.txtJumlah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJumlah.Properties.EditFormat.FormatString = "n2"
        Me.txtJumlah.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJumlah.Properties.Mask.BeepOnError = True
        Me.txtJumlah.Properties.Mask.EditMask = "n2"
        Me.txtJumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJumlah.Size = New System.Drawing.Size(245, 20)
        Me.txtJumlah.TabIndex = 4
        '
        'txtKursVal
        '
        Me.txtKursVal.EnterMoveNextControl = True
        Me.txtKursVal.Location = New System.Drawing.Point(0, 90)
        Me.txtKursVal.Name = "txtKursVal"
        Me.txtKursVal.Size = New System.Drawing.Size(245, 20)
        Me.txtKursVal.TabIndex = 3
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(0, 2)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(210, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelControl13)
        Me.Panel7.Controls.Add(Me.LabelControl7)
        Me.Panel7.Controls.Add(Me.LabelControl6)
        Me.Panel7.Controls.Add(Me.LabelControl5)
        Me.Panel7.Controls.Add(Me.LabelControl4)
        Me.Panel7.Controls.Add(Me.LabelControl3)
        Me.Panel7.Controls.Add(Me.LabelControl2)
        Me.Panel7.Controls.Add(Me.LabelControl1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 212)
        Me.Panel7.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(44, 135)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(89, 16)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Keterangan : "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(76, 113)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Jumlah : "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(45, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Kurs Valuta : "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(78, 69)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Valuta : "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(84, 47)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nama : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(70, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tanggal : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(79, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nomor : "
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
        Me.Panel1.Size = New System.Drawing.Size(837, 45)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(48, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(459, 43)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "PENGAJUAN KAS BON"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(94, 180)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl13.TabIndex = 7
        Me.LabelControl13.Text = "Unit : "
        '
        'LOV_Unit
        '
        Me.LOV_Unit.EditValue = "[Unit Bisnis]"
        Me.LOV_Unit.Location = New System.Drawing.Point(0, 181)
        Me.LOV_Unit.Name = "LOV_Unit"
        Me.LOV_Unit.Properties.AutoComplete = False
        Me.LOV_Unit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LOV_Unit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LOV_Unit.Properties.ImmediatePopup = True
        Me.LOV_Unit.Properties.NullText = ""
        Me.LOV_Unit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LOV_Unit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.LOV_Unit.Properties.ShowFooter = False
        Me.LOV_Unit.Properties.ShowPopupShadow = False
        Me.LOV_Unit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LOV_Unit.Properties.ValidateOnEnterKey = True
        Me.LOV_Unit.Properties.View = Me.GridView1
        Me.LOV_Unit.Size = New System.Drawing.Size(245, 20)
        Me.LOV_Unit.TabIndex = 37
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorzLines = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'frmPengajuanKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 544)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPengajuanKasBon"
        Me.Text = "frmPengajuanKasBon"
        Me.pnl.ResumeLayout(False)
        CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVGridKartu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlTopScnd.ResumeLayout(False)
        Me.pnlTopScnd.PerformLayout()
        Me.pnlTopMst.ResumeLayout(False)
        Me.pnlTopMst.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.LOVKartu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOVValuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglPengajuan.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglPengajuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKursVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOV_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlTopScnd As System.Windows.Forms.Panel
    Friend WithEvents pnlTopMst As System.Windows.Forms.Panel
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJumlah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKursVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TglPengajuan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LOVValuta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtketerangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pnlGrid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kurs_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LOVGridKartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LOVKartu As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LOV_Unit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
