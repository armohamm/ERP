<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmincentifkrg
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
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_pegawai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lepegawai = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tanggal_absen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Kode_bagian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkbagian = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lepegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkbagian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.LookAndFeel.SkinName = "Black"
        Me.gc.MainView = Me.gvMain
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lepegawai, Me.tgl, Me.tgl1, Me.lkbagian})
        Me.gc.Size = New System.Drawing.Size(983, 475)
        Me.gc.TabIndex = 6
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvMain.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Empty.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvMain.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gvMain.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gvMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupButton.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gvMain.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gvMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvMain.Appearance.GroupRow.Options.UseFont = True
        Me.gvMain.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvMain.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvMain.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvMain.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvMain.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.OddRow.Options.UseBackColor = True
        Me.gvMain.Appearance.OddRow.Options.UseForeColor = True
        Me.gvMain.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gvMain.Appearance.Preview.Options.UseBackColor = True
        Me.gvMain.Appearance.Preview.Options.UseForeColor = True
        Me.gvMain.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvMain.Appearance.Row.Options.UseBackColor = True
        Me.gvMain.Appearance.Row.Options.UseForeColor = True
        Me.gvMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gvMain.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gvMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvMain.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gvMain.Appearance.VertLine.Options.UseBackColor = True
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_pegawai, Me.tanggal_absen, Me.tanggal, Me.Kode_bagian})
        Me.gvMain.GridControl = Me.gc
        Me.gvMain.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMain.OptionsView.EnableAppearanceOddRow = True
        Me.gvMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvMain.OptionsView.ShowFooter = True
        Me.gvMain.OptionsView.ShowViewCaption = True
        Me.gvMain.ViewCaption = "DAFTAR ABSEN PEGAWAI SPON"
        '
        'kd_pegawai
        '
        Me.kd_pegawai.Caption = "Pegawai"
        Me.kd_pegawai.ColumnEdit = Me.lepegawai
        Me.kd_pegawai.FieldName = "kd_pegawai"
        Me.kd_pegawai.Name = "kd_pegawai"
        Me.kd_pegawai.Visible = True
        Me.kd_pegawai.VisibleIndex = 0
        '
        'lepegawai
        '
        Me.lepegawai.AutoHeight = False
        Me.lepegawai.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lepegawai.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_pegawai", "kd_pegawai"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Pegawai", "Nama_Pegawai")})
        Me.lepegawai.DisplayMember = "Nama_Pegawai"
        Me.lepegawai.Name = "lepegawai"
        Me.lepegawai.ValueMember = "kd_pegawai"
        '
        'tanggal_absen
        '
        Me.tanggal_absen.Caption = "Tanggal Absen"
        Me.tanggal_absen.ColumnEdit = Me.tgl
        Me.tanggal_absen.FieldName = "tanggal_absen"
        Me.tanggal_absen.Name = "tanggal_absen"
        Me.tanggal_absen.Visible = True
        Me.tanggal_absen.VisibleIndex = 1
        '
        'tgl
        '
        Me.tgl.AutoHeight = False
        Me.tgl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl.Name = "tgl"
        Me.tgl.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'tanggal
        '
        Me.tanggal.Caption = "Bulan / Tahun"
        Me.tanggal.ColumnEdit = Me.tgl1
        Me.tanggal.FieldName = "tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.OptionsColumn.AllowEdit = False
        Me.tanggal.Visible = True
        Me.tanggal.VisibleIndex = 2
        '
        'tgl1
        '
        Me.tgl1.AutoHeight = False
        Me.tgl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl1.DisplayFormat.FormatString = "Y"
        Me.tgl1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl1.Mask.EditMask = "Y"
        Me.tgl1.Name = "tgl1"
        Me.tgl1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Kode_bagian
        '
        Me.Kode_bagian.Caption = "Kode_bagian"
        Me.Kode_bagian.FieldName = "Kode_bagian"
        Me.Kode_bagian.Name = "Kode_bagian"
        '
        'lkbagian
        '
        Me.lkbagian.AutoHeight = False
        Me.lkbagian.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkbagian.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_bagian", "Kode_bagian")})
        Me.lkbagian.DisplayMember = "Kode_bagian"
        Me.lkbagian.Name = "lkbagian"
        Me.lkbagian.ValueMember = "Kode_bagian"
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(985, 508)
        Me.pnl.TabIndex = 2
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.gc)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 31)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(983, 475)
        Me.pnlTengah.TabIndex = 1
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(983, 31)
        Me.pnlAtas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.LookAndFeel.SkinName = "Black"
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "ABSEN PEGAWAI SPON"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmincentifkrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 508)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmincentifkrg"
        Me.Text = "frmAbsnPegSpon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lepegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkbagian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents kd_pegawai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggal_absen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lepegawai As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tgl As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents tgl1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Kode_bagian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkbagian As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
