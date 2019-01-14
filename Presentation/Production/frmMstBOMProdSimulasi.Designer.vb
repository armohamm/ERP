<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstBOMProdSimulasi
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstBOMProdSimulasi))
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clNoUrut2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clBarang2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.clJumlah2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clSatuan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sub_total1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clKeterangan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clStatus2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clKegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.PnlTengah = New System.Windows.Forms.Panel
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.lblTotal = New DevExpress.XtraEditors.TextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtRevisi = New DevExpress.XtraEditors.TextEdit
        Me.txtKetBOM = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtCopy = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNoDokBOM = New DevExpress.XtraEditors.TextEdit
        Me.txtBOM = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btCopy = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.PnlTengah.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtRevisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKetBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtCopy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV2
        '
        Me.GV2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Empty.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV2.Appearance.GroupRow.Options.UseFont = True
        Me.GV2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.OddRow.Options.UseBackColor = True
        Me.GV2.Appearance.OddRow.Options.UseForeColor = True
        Me.GV2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV2.Appearance.Preview.Options.UseBackColor = True
        Me.GV2.Appearance.Preview.Options.UseForeColor = True
        Me.GV2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV2.Appearance.Row.Options.UseBackColor = True
        Me.GV2.Appearance.Row.Options.UseForeColor = True
        Me.GV2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV2.Appearance.VertLine.Options.UseBackColor = True
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clNoUrut2, Me.clBarang2, Me.clJumlah2, Me.clSatuan2, Me.hrg, Me.sub_total1, Me.clKeterangan2, Me.clStatus2})
        Me.GV2.GridControl = Me.GC
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sub_total_harga", Me.sub_total1, "Numeric ""N2""", "Total Biaya")})
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.EnableAppearanceOddRow = True
        Me.GV2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupedColumns = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.PaintStyleName = "Skin"
        '
        'clNoUrut2
        '
        Me.clNoUrut2.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
        Me.clNoUrut2.AppearanceCell.Options.UseBackColor = True
        Me.clNoUrut2.AppearanceHeader.Options.UseTextOptions = True
        Me.clNoUrut2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clNoUrut2.Caption = "No Urut"
        Me.clNoUrut2.FieldName = "no_urut"
        Me.clNoUrut2.Name = "clNoUrut2"
        Me.clNoUrut2.OptionsColumn.AllowEdit = False
        Me.clNoUrut2.Visible = True
        Me.clNoUrut2.VisibleIndex = 0
        Me.clNoUrut2.Width = 40
        '
        'clBarang2
        '
        Me.clBarang2.AppearanceHeader.Options.UseTextOptions = True
        Me.clBarang2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clBarang2.Caption = "Nama Barang"
        Me.clBarang2.ColumnEdit = Me.repBarang
        Me.clBarang2.FieldName = "kd_barang"
        Me.clBarang2.Name = "clBarang2"
        Me.clBarang2.Visible = True
        Me.clBarang2.VisibleIndex = 1
        Me.clBarang2.Width = 282
        '
        'repBarang
        '
        Me.repBarang.AutoHeight = False
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Barang")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = "[Pilih Nama Barang]"
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'clJumlah2
        '
        Me.clJumlah2.AppearanceHeader.Options.UseTextOptions = True
        Me.clJumlah2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clJumlah2.Caption = "Jumlah"
        Me.clJumlah2.FieldName = "jumlah"
        Me.clJumlah2.Name = "clJumlah2"
        Me.clJumlah2.Visible = True
        Me.clJumlah2.VisibleIndex = 2
        Me.clJumlah2.Width = 73
        '
        'clSatuan2
        '
        Me.clSatuan2.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
        Me.clSatuan2.AppearanceCell.Options.UseBackColor = True
        Me.clSatuan2.AppearanceHeader.Options.UseTextOptions = True
        Me.clSatuan2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clSatuan2.Caption = "Satuan"
        Me.clSatuan2.FieldName = "satuan"
        Me.clSatuan2.Name = "clSatuan2"
        Me.clSatuan2.OptionsColumn.AllowEdit = False
        Me.clSatuan2.Visible = True
        Me.clSatuan2.VisibleIndex = 3
        Me.clSatuan2.Width = 45
        '
        'hrg
        '
        Me.hrg.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
        Me.hrg.AppearanceCell.Options.UseBackColor = True
        Me.hrg.Caption = "Harga Satuan"
        Me.hrg.DisplayFormat.FormatString = "N2"
        Me.hrg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.hrg.FieldName = "harga"
        Me.hrg.Name = "hrg"
        Me.hrg.OptionsColumn.AllowEdit = False
        Me.hrg.Visible = True
        Me.hrg.VisibleIndex = 4
        Me.hrg.Width = 63
        '
        'sub_total1
        '
        Me.sub_total1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.sub_total1.AppearanceCell.Options.UseBackColor = True
        Me.sub_total1.Caption = "Sub Total"
        Me.sub_total1.DisplayFormat.FormatString = "N2"
        Me.sub_total1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sub_total1.FieldName = "sub_total_harga"
        Me.sub_total1.Name = "sub_total1"
        Me.sub_total1.OptionsColumn.AllowEdit = False
        Me.sub_total1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.sub_total1.SummaryItem.Tag = 0
        Me.sub_total1.Visible = True
        Me.sub_total1.VisibleIndex = 5
        Me.sub_total1.Width = 61
        '
        'clKeterangan2
        '
        Me.clKeterangan2.AppearanceHeader.Options.UseTextOptions = True
        Me.clKeterangan2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clKeterangan2.Caption = "Keterangan"
        Me.clKeterangan2.FieldName = "keterangan"
        Me.clKeterangan2.Name = "clKeterangan2"
        Me.clKeterangan2.Visible = True
        Me.clKeterangan2.VisibleIndex = 6
        Me.clKeterangan2.Width = 120
        '
        'clStatus2
        '
        Me.clStatus2.AppearanceHeader.Options.UseTextOptions = True
        Me.clStatus2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clStatus2.Caption = "Status"
        Me.clStatus2.ColumnEdit = Me.repStatus
        Me.clStatus2.FieldName = "rec_stat"
        Me.clStatus2.Name = "clStatus2"
        Me.clStatus2.Visible = True
        Me.clStatus2.VisibleIndex = 7
        Me.clStatus2.Width = 55
        '
        'repStatus
        '
        Me.repStatus.AutoHeight = False
        Me.repStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.repStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repStatus.DisplayValueChecked = "Y"
        Me.repStatus.DisplayValueUnchecked = "T"
        Me.repStatus.Name = "repStatus"
        Me.repStatus.ValueChecked = "Y"
        Me.repStatus.ValueUnchecked = "T"
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GV2
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 0)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repKegiatan, Me.repBarang, Me.repStatus})
        Me.GC.Size = New System.Drawing.Size(908, 409)
        Me.GC.TabIndex = 7
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GV2})
        '
        'GV
        '
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clKegiatan})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'clKegiatan
        '
        Me.clKegiatan.Caption = "Jenis Kegiatan"
        Me.clKegiatan.ColumnEdit = Me.repKegiatan
        Me.clKegiatan.FieldName = "kd_kegiatan"
        Me.clKegiatan.Name = "clKegiatan"
        Me.clKegiatan.SummaryItem.FieldName = "sub_total_harga"
        Me.clKegiatan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.clKegiatan.Visible = True
        Me.clKegiatan.VisibleIndex = 0
        '
        'repKegiatan
        '
        Me.repKegiatan.AutoHeight = False
        Me.repKegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Data", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Kegiatan")})
        Me.repKegiatan.DisplayMember = "Desc_Data"
        Me.repKegiatan.Name = "repKegiatan"
        Me.repKegiatan.NullText = "[Pilih Jenis Proses]"
        Me.repKegiatan.ValueMember = "Id_Data"
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.PnlTengah)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(908, 518)
        Me.pnl.TabIndex = 0
        '
        'PnlTengah
        '
        Me.PnlTengah.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PnlTengah.Controls.Add(Me.GC)
        Me.PnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlTengah.Location = New System.Drawing.Point(0, 109)
        Me.PnlTengah.Name = "PnlTengah"
        Me.PnlTengah.Size = New System.Drawing.Size(908, 409)
        Me.PnlTengah.TabIndex = 9
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.lblTotal)
        Me.pnlTools.Controls.Add(Me.Panel5)
        Me.pnlTools.Controls.Add(Me.Panel4)
        Me.pnlTools.Controls.Add(Me.Panel3)
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(908, 75)
        Me.pnlTools.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotal.EditValue = ""
        Me.lblTotal.Enabled = False
        Me.lblTotal.Location = New System.Drawing.Point(853, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Properties.Appearance.Options.UseBackColor = True
        Me.lblTotal.Properties.Appearance.Options.UseBorderColor = True
        Me.lblTotal.Properties.Appearance.Options.UseFont = True
        Me.lblTotal.Properties.Appearance.Options.UseForeColor = True
        Me.lblTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.lblTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.lblTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblTotal.Properties.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(55, 22)
        Me.lblTotal.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LabelControl5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(733, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 75)
        Me.Panel5.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl5.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseBorderColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl5.Location = New System.Drawing.Point(0, 51)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(120, 24)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Total Harga Bahan : "
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtRevisi)
        Me.Panel4.Controls.Add(Me.txtKetBOM)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(551, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(182, 75)
        Me.Panel4.TabIndex = 7
        '
        'txtRevisi
        '
        Me.txtRevisi.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRevisi.Location = New System.Drawing.Point(0, 20)
        Me.txtRevisi.Name = "txtRevisi"
        Me.txtRevisi.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.txtRevisi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRevisi.Properties.Appearance.Options.UseBackColor = True
        Me.txtRevisi.Properties.Appearance.Options.UseFont = True
        Me.txtRevisi.Properties.ReadOnly = True
        Me.txtRevisi.Size = New System.Drawing.Size(182, 20)
        Me.txtRevisi.TabIndex = 3
        '
        'txtKetBOM
        '
        Me.txtKetBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKetBOM.Location = New System.Drawing.Point(0, 0)
        Me.txtKetBOM.Name = "txtKetBOM"
        Me.txtKetBOM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKetBOM.Size = New System.Drawing.Size(182, 20)
        Me.txtKetBOM.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(460, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(91, 75)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Revisi : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keterangan : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.txtCopy)
        Me.Panel2.Controls.Add(Me.txtNoDokBOM)
        Me.Panel2.Controls.Add(Me.txtBOM)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(149, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 75)
        Me.Panel2.TabIndex = 5
        '
        'txtCopy
        '
        Me.txtCopy.Location = New System.Drawing.Point(0, 40)
        Me.txtCopy.Name = "txtCopy"
        Me.txtCopy.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCopy.Properties.Appearance.Options.UseBackColor = True
        Me.txtCopy.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCopy.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopy.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtCopy.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCopy.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtCopy.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCopy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCopy.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCopy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_bom", "Kode", 150, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama_bom", 200, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("revisi", "Revisi", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.txtCopy.Properties.DropDownRows = 15
        Me.txtCopy.Properties.HideSelection = False
        Me.txtCopy.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCopy.Properties.NullText = "[Pilih Bill Of Material]"
        Me.txtCopy.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCopy.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCopy.Properties.PopupWidth = 400
        Me.txtCopy.Properties.ShowHeader = False
        Me.txtCopy.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCopy.Size = New System.Drawing.Size(311, 20)
        Me.txtCopy.TabIndex = 2
        '
        'txtNoDokBOM
        '
        Me.txtNoDokBOM.Location = New System.Drawing.Point(0, 20)
        Me.txtNoDokBOM.Name = "txtNoDokBOM"
        Me.txtNoDokBOM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoDokBOM.Size = New System.Drawing.Size(311, 20)
        Me.txtNoDokBOM.TabIndex = 1
        '
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(0, 0)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBOM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_jenis", "Jenis", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 200, "Nama")})
        Me.txtBOM.Properties.NullText = "[Pilih Bill Of Material]"
        Me.txtBOM.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtBOM.Properties.PopupWidth = 400
        Me.txtBOM.Properties.ShowHeader = False
        Me.txtBOM.Size = New System.Drawing.Size(311, 20)
        Me.txtBOM.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btCopy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 75)
        Me.Panel1.TabIndex = 4
        '
        'btCopy
        '
        Me.btCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btCopy.Appearance.Options.UseFont = True
        Me.btCopy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btCopy.Location = New System.Drawing.Point(17, 41)
        Me.btCopy.Name = "btCopy"
        Me.btCopy.Size = New System.Drawing.Size(117, 23)
        Me.btCopy.TabIndex = 5
        Me.btCopy.Text = "Copy BOM Simulasi"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "* No. Dokumen : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "* Bill Of Material : "
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
        Me.pnlTitle.Size = New System.Drawing.Size(908, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "SIMULASI BOM PRODUKSI"
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
        'frmMstBOMProdSimulasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 542)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstBOMProdSimulasi"
        Me.Text = "frmMstBOMProd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.PnlTengah.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtRevisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKetBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtCopy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtRevisi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKetBOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNoDokBOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btCopy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PnlTengah As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clNoUrut2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clBarang2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents clSatuan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clJumlah2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clKeterangan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clStatus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clKegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtCopy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents hrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sub_total1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
