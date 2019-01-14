<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstSpk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstSpk))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_kegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_spk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkKegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.lkspk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtJenisBrg = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.colStatHPP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CE_StatusHPP = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnl.SuspendLayout()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkspk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtJenisBrg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_StatusHPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.gControl)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(893, 406)
        Me.pnl.TabIndex = 0
        '
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gControl.Location = New System.Drawing.Point(0, 78)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkKegiatan, Me.ckStatus, Me.lkspk, Me.CE_StatusHPP})
        Me.gControl.Size = New System.Drawing.Size(893, 328)
        Me.gControl.TabIndex = 5
        Me.gControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gView})
        '
        'gView
        '
        Me.gView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gView.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Empty.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gView.Appearance.FixedLine.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gView.Appearance.GroupButton.Options.UseForeColor = True
        Me.gView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gView.Appearance.GroupRow.Options.UseFont = True
        Me.gView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.HorzLine.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.OddRow.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.Options.UseForeColor = True
        Me.gView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.Preview.Options.UseBackColor = True
        Me.gView.Appearance.Preview.Options.UseForeColor = True
        Me.gView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.Row.Options.UseBackColor = True
        Me.gView.Appearance.Row.Options.UseForeColor = True
        Me.gView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.VertLine.Options.UseBackColor = True
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_kegiatan, Me.kd_spk, Me.clmKeterangan, Me.rec_stat, Me.colStatHPP})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.NewItemRowText = "Klik di sini untuk menambah item baru"
        Me.gView.OptionsPrint.UsePrintStyles = True
        Me.gView.OptionsView.EnableAppearanceEvenRow = True
        Me.gView.OptionsView.EnableAppearanceOddRow = True
        Me.gView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gView.OptionsView.ShowGroupPanel = False
        Me.gView.PaintStyleName = "Skin"
        '
        'kd_kegiatan
        '
        Me.kd_kegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_kegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_kegiatan.Caption = "Kegiatan"
        Me.kd_kegiatan.FieldName = "kd_kegiatan"
        Me.kd_kegiatan.Name = "kd_kegiatan"
        Me.kd_kegiatan.Visible = True
        Me.kd_kegiatan.VisibleIndex = 0
        '
        'kd_spk
        '
        Me.kd_spk.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_spk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_spk.Caption = "SPK"
        Me.kd_spk.FieldName = "kd_spk"
        Me.kd_spk.Name = "kd_spk"
        Me.kd_spk.Visible = True
        Me.kd_spk.VisibleIndex = 1
        '
        'clmKeterangan
        '
        Me.clmKeterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.clmKeterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmKeterangan.Caption = "Keterangan"
        Me.clmKeterangan.FieldName = "keterangan"
        Me.clmKeterangan.Name = "clmKeterangan"
        Me.clmKeterangan.Visible = True
        Me.clmKeterangan.VisibleIndex = 2
        '
        'rec_stat
        '
        Me.rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rec_stat.Caption = "Status"
        Me.rec_stat.ColumnEdit = Me.ckStatus
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 3
        '
        'lkKegiatan
        '
        Me.lkKegiatan.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lkKegiatan.AutoHeight = False
        Me.lkKegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkKegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Kegiatan")})
        Me.lkKegiatan.Name = "lkKegiatan"
        Me.lkKegiatan.NullText = "[Pilih Jenis Kegiatan]"
        Me.lkKegiatan.ShowHeader = False
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.Caption = "Aktif"
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
        '
        'lkspk
        '
        Me.lkspk.AutoHeight = False
        Me.lkspk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkspk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "kd_spk")})
        Me.lkspk.Name = "lkspk"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 44)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtJenisBrg)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(232, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(481, 44)
        Me.Panel4.TabIndex = 1
        '
        'txtJenisBrg
        '
        Me.txtJenisBrg.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtJenisBrg.Location = New System.Drawing.Point(0, 0)
        Me.txtJenisBrg.Name = "txtJenisBrg"
        Me.txtJenisBrg.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJenisBrg.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bom", "Nama Bom")})
        Me.txtJenisBrg.Properties.NullText = "[Pilih Nama Bom]"
        Me.txtJenisBrg.Properties.ShowHeader = False
        Me.txtJenisBrg.Size = New System.Drawing.Size(481, 20)
        Me.txtJenisBrg.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 44)
        Me.Panel3.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Bom : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(893, 34)
        Me.pnlTitle.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(194, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER SPK"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'colStatHPP
        '
        Me.colStatHPP.Caption = "Status Generate HPP"
        Me.colStatHPP.ColumnEdit = Me.CE_StatusHPP
        Me.colStatHPP.FieldName = "status_hpp"
        Me.colStatHPP.Name = "colStatHPP"
        Me.colStatHPP.Visible = True
        Me.colStatHPP.VisibleIndex = 4
        '
        'CE_StatusHPP
        '
        Me.CE_StatusHPP.AutoHeight = False
        Me.CE_StatusHPP.Caption = "Aktif"
        Me.CE_StatusHPP.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CE_StatusHPP.Name = "CE_StatusHPP"
        Me.CE_StatusHPP.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CE_StatusHPP.ValueChecked = "Y"
        Me.CE_StatusHPP.ValueUnchecked = "N"
        '
        'frmMstSpk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 462)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstSpk"
        Me.Text = "frmMstSpk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkspk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtJenisBrg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_StatusHPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtJenisBrg As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_kegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkKegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents kd_spk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkspk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colStatHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_StatusHPP As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
