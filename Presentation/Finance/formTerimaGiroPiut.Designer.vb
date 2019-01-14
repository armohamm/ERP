<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTerimaGiroPiut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTerimaGiroPiut))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMstCOA = New DevExpress.XtraGrid.GridControl
        Me.GvMstCOA = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.idrec = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nomor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lodTanggal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.tgl_jth_tempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_giro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupJenis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupGiro = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.divisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupdivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_bank = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupbank = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupkartu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupval = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kurs_valuta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtnominal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.jml_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GcMstCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupGiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupdivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnominal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1023, 34)
        Me.Panel1.TabIndex = 33
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
        Me.Label1.Text = "        PENERIMAAN GIRO/CEK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMstCOA)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1023, 387)
        Me.pnl.TabIndex = 1
        '
        'GcMstCOA
        '
        Me.GcMstCOA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMstCOA.Location = New System.Drawing.Point(0, 34)
        Me.GcMstCOA.LookAndFeel.SkinName = "Blue"
        Me.GcMstCOA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcMstCOA.MainView = Me.GvMstCOA
        Me.GcMstCOA.Name = "GcMstCOA"
        Me.GcMstCOA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupbank, Me.lookupkartu, Me.lookupval, Me.lodTanggal, Me.lookupGiro, Me.lookupJenis, Me.txtnominal, Me.lookupdivisi})
        Me.GcMstCOA.Size = New System.Drawing.Size(1023, 322)
        Me.GcMstCOA.TabIndex = 32
        Me.GcMstCOA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstCOA})
        '
        'GvMstCOA
        '
        Me.GvMstCOA.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.Empty.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GvMstCOA.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GvMstCOA.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GvMstCOA.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GvMstCOA.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GvMstCOA.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GvMstCOA.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GvMstCOA.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GvMstCOA.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GvMstCOA.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GvMstCOA.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GvMstCOA.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GvMstCOA.Appearance.Preview.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.Preview.Options.UseFont = True
        Me.GvMstCOA.Appearance.Preview.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GvMstCOA.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMstCOA.Appearance.Row.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.Row.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvMstCOA.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GvMstCOA.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GvMstCOA.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GvMstCOA.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMstCOA.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvMstCOA.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GvMstCOA.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMstCOA.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GvMstCOA.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Blue
        Me.GvMstCOA.Appearance.ViewCaption.Options.UseFont = True
        Me.GvMstCOA.Appearance.ViewCaption.Options.UseForeColor = True
        Me.GvMstCOA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idrec, Me.nomor, Me.tgl_trans, Me.tgl_jth_tempo, Me.jns_giro, Me.tipe_trans, Me.divisi, Me.kd_bank, Me.kartu, Me.kd_valuta, Me.kurs_valuta, Me.jml_trans, Me.keterangan, Me.status})
        Me.GvMstCOA.GridControl = Me.GcMstCOA
        Me.GvMstCOA.Name = "GvMstCOA"
        Me.GvMstCOA.NewItemRowText = "Tambah data disini"
        Me.GvMstCOA.OptionsCustomization.AllowColumnMoving = False
        Me.GvMstCOA.OptionsCustomization.AllowGroup = False
        Me.GvMstCOA.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMstCOA.OptionsView.EnableAppearanceOddRow = True
        Me.GvMstCOA.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GvMstCOA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvMstCOA.OptionsView.RowAutoHeight = True
        Me.GvMstCOA.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvMstCOA.OptionsView.ShowGroupPanel = False
        Me.GvMstCOA.PaintStyleName = "Office2003"
        '
        'idrec
        '
        Me.idrec.Caption = "GridColumn1"
        Me.idrec.FieldName = "idrec"
        Me.idrec.Name = "idrec"
        '
        'nomor
        '
        Me.nomor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.nomor.AppearanceHeader.Options.UseFont = True
        Me.nomor.AppearanceHeader.Options.UseForeColor = True
        Me.nomor.AppearanceHeader.Options.UseTextOptions = True
        Me.nomor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomor.Caption = "Nomor Giro"
        Me.nomor.FieldName = "nomor"
        Me.nomor.MinWidth = 10
        Me.nomor.Name = "nomor"
        Me.nomor.Visible = True
        Me.nomor.VisibleIndex = 0
        Me.nomor.Width = 88
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_trans.AppearanceHeader.Options.UseFont = True
        Me.tgl_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tanggal"
        Me.tgl_trans.ColumnEdit = Me.lodTanggal
        Me.tgl_trans.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 69
        '
        'lodTanggal
        '
        Me.lodTanggal.AutoHeight = False
        Me.lodTanggal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lodTanggal.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.lodTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.EditFormat.FormatString = "dd/MM/yyyy"
        Me.lodTanggal.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lodTanggal.Mask.EditMask = "d MMMM yyyy"
        Me.lodTanggal.Mask.UseMaskAsDisplayFormat = True
        Me.lodTanggal.Name = "lodTanggal"
        Me.lodTanggal.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'tgl_jth_tempo
        '
        Me.tgl_jth_tempo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_jth_tempo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseFont = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseForeColor = True
        Me.tgl_jth_tempo.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_jth_tempo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_jth_tempo.Caption = "Tgl Jatuh Tempo"
        Me.tgl_jth_tempo.ColumnEdit = Me.lodTanggal
        Me.tgl_jth_tempo.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_jth_tempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_jth_tempo.FieldName = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Name = "tgl_jth_tempo"
        Me.tgl_jth_tempo.Visible = True
        Me.tgl_jth_tempo.VisibleIndex = 2
        Me.tgl_jth_tempo.Width = 89
        '
        'jns_giro
        '
        Me.jns_giro.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jns_giro.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jns_giro.AppearanceHeader.Options.UseFont = True
        Me.jns_giro.AppearanceHeader.Options.UseForeColor = True
        Me.jns_giro.AppearanceHeader.Options.UseTextOptions = True
        Me.jns_giro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jns_giro.Caption = "Jenis"
        Me.jns_giro.ColumnEdit = Me.lookupJenis
        Me.jns_giro.FieldName = "jns_giro"
        Me.jns_giro.Name = "jns_giro"
        Me.jns_giro.Visible = True
        Me.jns_giro.VisibleIndex = 3
        Me.jns_giro.Width = 69
        '
        'lookupJenis
        '
        Me.lookupJenis.AutoHeight = False
        Me.lookupJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupJenis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Name1")})
        Me.lookupJenis.Name = "lookupJenis"
        Me.lookupJenis.NullText = "[Pilih]"
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseForeColor = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "DP/DO"
        Me.tipe_trans.ColumnEdit = Me.lookupGiro
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 4
        Me.tipe_trans.Width = 69
        '
        'lookupGiro
        '
        Me.lookupGiro.AutoHeight = False
        Me.lookupGiro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupGiro.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("attribut1", "Jenis Giro")})
        Me.lookupGiro.Name = "lookupGiro"
        Me.lookupGiro.NullText = "[Pilih]"
        '
        'divisi
        '
        Me.divisi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.divisi.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.divisi.AppearanceHeader.Options.UseFont = True
        Me.divisi.AppearanceHeader.Options.UseForeColor = True
        Me.divisi.AppearanceHeader.Options.UseTextOptions = True
        Me.divisi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.divisi.Caption = "Divisi"
        Me.divisi.ColumnEdit = Me.lookupdivisi
        Me.divisi.FieldName = "divisi"
        Me.divisi.Name = "divisi"
        '
        'lookupdivisi
        '
        Me.lookupdivisi.AutoHeight = False
        Me.lookupdivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupdivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Name7")})
        Me.lookupdivisi.Name = "lookupdivisi"
        Me.lookupdivisi.NullText = "[Divisi]"
        Me.lookupdivisi.ShowFooter = False
        Me.lookupdivisi.ShowHeader = False
        Me.lookupdivisi.ShowPopupShadow = False
        Me.lookupdivisi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookupdivisi.ValidateOnEnterKey = True
        '
        'kd_bank
        '
        Me.kd_bank.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_bank.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_bank.AppearanceHeader.Options.UseFont = True
        Me.kd_bank.AppearanceHeader.Options.UseForeColor = True
        Me.kd_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_bank.Caption = "Nama Bank"
        Me.kd_bank.ColumnEdit = Me.lookupbank
        Me.kd_bank.FieldName = "kd_bank"
        Me.kd_bank.Name = "kd_bank"
        Me.kd_bank.Visible = True
        Me.kd_bank.VisibleIndex = 5
        Me.kd_bank.Width = 135
        '
        'lookupbank
        '
        Me.lookupbank.AutoHeight = False
        Me.lookupbank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbank.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bank", "Nama bank")})
        Me.lookupbank.Name = "lookupbank"
        Me.lookupbank.NullText = "[Pilih]"
        '
        'kartu
        '
        Me.kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kartu.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kartu.AppearanceHeader.Options.UseFont = True
        Me.kartu.AppearanceHeader.Options.UseForeColor = True
        Me.kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kartu.Caption = "Nama Kartu"
        Me.kartu.ColumnEdit = Me.lookupkartu
        Me.kartu.FieldName = "kartu"
        Me.kartu.Name = "kartu"
        Me.kartu.Visible = True
        Me.kartu.VisibleIndex = 6
        Me.kartu.Width = 143
        '
        'lookupkartu
        '
        Me.lookupkartu.AutoHeight = False
        Me.lookupkartu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupkartu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama")})
        Me.lookupkartu.Name = "lookupkartu"
        Me.lookupkartu.NullText = "[Pilih]"
        '
        'kd_valuta
        '
        Me.kd_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_valuta.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kd_valuta.AppearanceHeader.Options.UseFont = True
        Me.kd_valuta.AppearanceHeader.Options.UseForeColor = True
        Me.kd_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_valuta.Caption = "Valuta"
        Me.kd_valuta.ColumnEdit = Me.lookupval
        Me.kd_valuta.FieldName = "kd_valuta"
        Me.kd_valuta.Name = "kd_valuta"
        Me.kd_valuta.Visible = True
        Me.kd_valuta.VisibleIndex = 7
        Me.kd_valuta.Width = 62
        '
        'lookupval
        '
        Me.lookupval.AutoHeight = False
        Me.lookupval.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupval.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", "Nama")})
        Me.lookupval.Name = "lookupval"
        Me.lookupval.NullText = "[Pilih]"
        '
        'kurs_valuta
        '
        Me.kurs_valuta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kurs_valuta.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.kurs_valuta.AppearanceHeader.Options.UseFont = True
        Me.kurs_valuta.AppearanceHeader.Options.UseForeColor = True
        Me.kurs_valuta.AppearanceHeader.Options.UseTextOptions = True
        Me.kurs_valuta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kurs_valuta.Caption = "Kurs"
        Me.kurs_valuta.ColumnEdit = Me.txtnominal
        Me.kurs_valuta.FieldName = "kurs_valuta"
        Me.kurs_valuta.Name = "kurs_valuta"
        Me.kurs_valuta.Visible = True
        Me.kurs_valuta.VisibleIndex = 8
        Me.kurs_valuta.Width = 69
        '
        'txtnominal
        '
        Me.txtnominal.AutoHeight = False
        Me.txtnominal.Mask.EditMask = "n2"
        Me.txtnominal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtnominal.Mask.UseMaskAsDisplayFormat = True
        Me.txtnominal.Name = "txtnominal"
        '
        'jml_trans
        '
        Me.jml_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_trans.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.jml_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_trans.AppearanceHeader.Options.UseForeColor = True
        Me.jml_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_trans.Caption = "Jumlah"
        Me.jml_trans.ColumnEdit = Me.txtnominal
        Me.jml_trans.DisplayFormat.FormatString = "n2"
        Me.jml_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.FieldName = "jml_trans"
        Me.jml_trans.GroupFormat.FormatString = "n2"
        Me.jml_trans.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_trans.Name = "jml_trans"
        Me.jml_trans.Visible = True
        Me.jml_trans.VisibleIndex = 9
        Me.jml_trans.Width = 76
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseForeColor = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 10
        Me.keterangan.Width = 137
        '
        'status
        '
        Me.status.Caption = "GridColumn1"
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 356)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 31)
        Me.Panel2.TabIndex = 31
        '
        'formTerimaGiroPiut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 387)
        Me.Controls.Add(Me.pnl)
        Me.Name = "formTerimaGiroPiut"
        Me.Text = "Maintenance Giro & Cek"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMstCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lodTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupGiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupdivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupkartu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnominal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcMstCOA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstCOA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupbank As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupkartu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupval As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tgl_jth_tempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lodTanggal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupGiro As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jns_giro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupJenis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kurs_valuta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtnominal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents divisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupdivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idrec As DevExpress.XtraGrid.Columns.GridColumn
End Class
