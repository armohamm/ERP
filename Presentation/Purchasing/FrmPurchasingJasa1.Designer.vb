<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasingJasa1
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
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dqty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dqty_pr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GcPRJ = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoDPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_perlu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupGudang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupSup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.repJasa = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.btn_supp = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.dttglpr = New DevExpress.XtraEditors.DateEdit
        Me.txtNomor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RepBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcPRJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengah.SuspendLayout()
        Me.pnlTengahAtas.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dttglpr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttglpr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVDetail
        '
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDetail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDetail.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.Empty.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVDetail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVDetail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVDetail.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDetail.Appearance.GroupRow.Options.UseFont = True
        Me.GVDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVDetail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDetail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDetail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVDetail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVDetail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVDetail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVDetail.Appearance.Preview.Options.UseBackColor = True
        Me.GVDetail.Appearance.Preview.Options.UseForeColor = True
        Me.GVDetail.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVDetail.Appearance.Row.Options.UseBackColor = True
        Me.GVDetail.Appearance.Row.Options.UseForeColor = True
        Me.GVDetail.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVDetail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDetail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDetail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVDetail.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.dqty_order, Me.d, Me.GridColumn7, Me.dqty_pr})
        Me.GVDetail.GridControl = Me.GcPRJ
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDetail.OptionsView.EnableAppearanceOddRow = True
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        Me.GVDetail.ViewCaption = "Detail"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "no_urut"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Barang"
        Me.GridColumn2.ColumnEdit = Me.lookupbrg
        Me.GridColumn2.FieldName = "kd_stok"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 182
        '
        'lookupbrg
        '
        Me.lookupbrg.AutoHeight = False
        Me.lookupbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupbrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "NamaBarang")})
        Me.lookupbrg.Name = "lookupbrg"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Spek"
        Me.GridColumn3.FieldName = "spek_brg"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 147
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Satuan"
        Me.GridColumn4.FieldName = "kd_satuan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 83
        '
        'dqty_order
        '
        Me.dqty_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dqty_order.AppearanceHeader.Options.UseFont = True
        Me.dqty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.dqty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dqty_order.Caption = "Jml Order"
        Me.dqty_order.FieldName = "qty"
        Me.dqty_order.Name = "dqty_order"
        Me.dqty_order.OptionsColumn.AllowEdit = False
        Me.dqty_order.Visible = True
        Me.dqty_order.VisibleIndex = 3
        Me.dqty_order.Width = 129
        '
        'd
        '
        Me.d.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.d.AppearanceHeader.Options.UseFont = True
        Me.d.AppearanceHeader.Options.UseTextOptions = True
        Me.d.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.d.Caption = "Jml Sisa"
        Me.d.FieldName = "qty_sisa"
        Me.d.Name = "d"
        Me.d.OptionsColumn.AllowEdit = False
        Me.d.Visible = True
        Me.d.VisibleIndex = 5
        Me.d.Width = 129
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Keterangan"
        Me.GridColumn7.FieldName = "keterangan"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 141
        '
        'dqty_pr
        '
        Me.dqty_pr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dqty_pr.AppearanceHeader.Options.UseFont = True
        Me.dqty_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.dqty_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dqty_pr.Caption = "Jml PR"
        Me.dqty_pr.FieldName = "qty_pr"
        Me.dqty_pr.Name = "dqty_pr"
        Me.dqty_pr.Visible = True
        Me.dqty_pr.VisibleIndex = 4
        Me.dqty_pr.Width = 129
        '
        'GcPRJ
        '
        Me.GcPRJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcPRJ.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        GridLevelNode1.LevelTemplate = Me.GVDetail
        GridLevelNode1.RelationName = "Level1"
        Me.GcPRJ.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GcPRJ.Location = New System.Drawing.Point(0, 44)
        Me.GcPRJ.MainView = Me.GV
        Me.GcPRJ.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GcPRJ.Name = "GcPRJ"
        Me.GcPRJ.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.LookupGudang, Me.lookupSup, Me.lookupbrg, Me.repJasa})
        Me.GcPRJ.Size = New System.Drawing.Size(966, 384)
        Me.GcPRJ.TabIndex = 9
        Me.GcPRJ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV, Me.GVDetail})
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseFont = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseBackColor = True
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoDPM, Me.no_trans, Me.sat, Me.qty_order, Me.tgl_perlu, Me.Ket})
        Me.GV.GridControl = Me.GcPRJ
        Me.GV.Name = "GV"
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'NoDPM
        '
        Me.NoDPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NoDPM.AppearanceHeader.Options.UseFont = True
        Me.NoDPM.AppearanceHeader.Options.UseTextOptions = True
        Me.NoDPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NoDPM.Caption = "No DPM"
        Me.NoDPM.FieldName = "no_dpm"
        Me.NoDPM.Name = "NoDPM"
        Me.NoDPM.OptionsColumn.AllowEdit = False
        Me.NoDPM.OptionsColumn.AllowFocus = False
        Me.NoDPM.Visible = True
        Me.NoDPM.VisibleIndex = 0
        Me.NoDPM.Width = 120
        '
        'no_trans
        '
        Me.no_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_trans.AppearanceHeader.Options.UseFont = True
        Me.no_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.Caption = "Nama Jasa"
        Me.no_trans.ColumnEdit = Me.lookupbrg
        Me.no_trans.FieldName = "kd_stok"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.AllowFocus = False
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 1
        Me.no_trans.Width = 148
        '
        'sat
        '
        Me.sat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sat.AppearanceHeader.Options.UseFont = True
        Me.sat.AppearanceHeader.Options.UseTextOptions = True
        Me.sat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.sat.Caption = "Satuan"
        Me.sat.FieldName = "satuan"
        Me.sat.Name = "sat"
        Me.sat.OptionsColumn.AllowEdit = False
        Me.sat.OptionsColumn.AllowFocus = False
        Me.sat.Width = 67
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.qty_order.AppearanceHeader.Options.UseFont = True
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Jml Order"
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.AllowFocus = False
        Me.qty_order.Visible = True
        Me.qty_order.VisibleIndex = 2
        Me.qty_order.Width = 81
        '
        'tgl_perlu
        '
        Me.tgl_perlu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_perlu.AppearanceHeader.Options.UseFont = True
        Me.tgl_perlu.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_perlu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_perlu.Caption = "Tanggal Diperlukan"
        Me.tgl_perlu.FieldName = "Tgl_Diperlukan"
        Me.tgl_perlu.Name = "tgl_perlu"
        Me.tgl_perlu.OptionsColumn.AllowEdit = False
        Me.tgl_perlu.OptionsColumn.AllowFocus = False
        Me.tgl_perlu.Visible = True
        Me.tgl_perlu.VisibleIndex = 3
        Me.tgl_perlu.Width = 172
        '
        'Ket
        '
        Me.Ket.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Ket.AppearanceHeader.Options.UseFont = True
        Me.Ket.AppearanceHeader.Options.UseTextOptions = True
        Me.Ket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ket.Caption = "Keterangan"
        Me.Ket.FieldName = "keterangan"
        Me.Ket.Name = "Ket"
        Me.Ket.Visible = True
        Me.Ket.VisibleIndex = 4
        Me.Ket.Width = 150
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Jasa")})
        Me.LookupBarang.DisplayMember = "Nama_Barang"
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.ValueMember = "Kode_Barang"
        '
        'LookupGudang
        '
        Me.LookupGudang.AutoHeight = False
        Me.LookupGudang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupGudang.Name = "LookupGudang"
        '
        'lookupSup
        '
        Me.lookupSup.AutoHeight = False
        Me.lookupSup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupSup.Name = "lookupSup"
        '
        'repJasa
        '
        Me.repJasa.AutoHeight = False
        Me.repJasa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repJasa.Name = "repJasa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(966, 34)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(42, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM PURCHASE REQUEST JASA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.table_selection_column
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.GcPRJ)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 34)
        Me.pnlTengah.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(966, 428)
        Me.pnlTengah.TabIndex = 4
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.btn_supp)
        Me.pnlTengahAtas.Controls.Add(Me.PanelControl1)
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(966, 44)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'btn_supp
        '
        Me.btn_supp.Enabled = False
        Me.btn_supp.Location = New System.Drawing.Point(792, 4)
        Me.btn_supp.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(75, 23)
        Me.btn_supp.TabIndex = 8
        Me.btn_supp.Text = "Pilih Supplier"
        Me.btn_supp.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dttglpr)
        Me.PanelControl1.Controls.Add(Me.txtNomor)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(124, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(202, 44)
        Me.PanelControl1.TabIndex = 6
        '
        'dttglpr
        '
        Me.dttglpr.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttglpr.EditValue = Nothing
        Me.dttglpr.Location = New System.Drawing.Point(2, 22)
        Me.dttglpr.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dttglpr.Name = "dttglpr"
        Me.dttglpr.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dttglpr.Properties.Appearance.Options.UseBackColor = True
        Me.dttglpr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttglpr.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttglpr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttglpr.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dttglpr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttglpr.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dttglpr.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttglpr.Size = New System.Drawing.Size(198, 20)
        Me.dttglpr.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomor.Location = New System.Drawing.Point(2, 2)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(198, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 44)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RepBarang
        '
        Me.RepBarang.Appearance.Options.UseImage = True
        Me.RepBarang.AutoHeight = False
        Me.RepBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 125, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 450, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 75, "Satuan")})
        Me.RepBarang.DisplayMember = "Nama_Barang"
        Me.RepBarang.DropDownRows = 15
        Me.RepBarang.HideSelection = False
        Me.RepBarang.Name = "RepBarang"
        Me.RepBarang.NullText = "[Pilih Barang]"
        Me.RepBarang.PopupWidth = 700
        Me.RepBarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepBarang.ValueMember = "Kode_Barang"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(966, 462)
        Me.pnl.TabIndex = 3
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(657, 731)
        Me.btSimpan.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(125, 44)
        Me.btSimpan.TabIndex = 8
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.Visible = False
        '
        'FrmPurchasingJasa1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 462)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.pnl)
        Me.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmPurchasingJasa1"
        Me.Text = "FORM PURCHASING JASA"
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcPRJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupGudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repJasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlTengahAtas.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dttglpr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttglpr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.RepBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents RepBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents dttglpr As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcPRJ As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoDPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_perlu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupGudang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lookupSup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_supp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dqty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repJasa As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dqty_pr As DevExpress.XtraGrid.Columns.GridColumn
End Class
