﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormAppPiutKar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aFormAppPiutKar))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gcApp = New DevExpress.XtraGrid.GridControl
        Me.gvApp = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_cust = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueNama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deTglInv = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.jml_val_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtJmlAju = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.tgl_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deTglApp = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtJmlApp = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cek_post = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_posting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rek_attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        CType(Me.gcApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglInv.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlAju, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTglApp.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gcApp)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.pnlTop)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(905, 450)
        Me.pnl.TabIndex = 0
        '
        'gcApp
        '
        Me.gcApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcApp.Location = New System.Drawing.Point(0, 44)
        Me.gcApp.LookAndFeel.SkinName = "Blue"
        Me.gcApp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.gcApp.LookAndFeel.UseWindowsXPTheme = True
        Me.gcApp.MainView = Me.gvApp
        Me.gcApp.Name = "gcApp"
        Me.gcApp.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deTglInv, Me.deTglApp, Me.cmbStatus, Me.lueNama, Me.txtJmlAju, Me.txtJmlApp})
        Me.gcApp.Size = New System.Drawing.Size(905, 372)
        Me.gcApp.TabIndex = 1
        Me.gcApp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvApp})
        '
        'gvApp
        '
        Me.gvApp.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gvApp.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gvApp.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gvApp.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gvApp.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gvApp.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gvApp.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gvApp.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gvApp.Appearance.Empty.Options.UseBackColor = True
        Me.gvApp.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvApp.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gvApp.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvApp.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.gvApp.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gvApp.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gvApp.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gvApp.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gvApp.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gvApp.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gvApp.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gvApp.Appearance.FixedLine.Options.UseBackColor = True
        Me.gvApp.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gvApp.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvApp.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvApp.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gvApp.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gvApp.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gvApp.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvApp.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gvApp.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvApp.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gvApp.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gvApp.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gvApp.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.GroupButton.Options.UseBackColor = True
        Me.gvApp.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gvApp.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gvApp.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gvApp.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gvApp.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gvApp.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gvApp.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gvApp.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.GroupRow.Options.UseBackColor = True
        Me.gvApp.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gvApp.Appearance.GroupRow.Options.UseForeColor = True
        Me.gvApp.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gvApp.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvApp.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvApp.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvApp.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gvApp.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvApp.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvApp.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gvApp.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvApp.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.HorzLine.Options.UseBackColor = True
        Me.gvApp.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.OddRow.Options.UseBackColor = True
        Me.gvApp.Appearance.OddRow.Options.UseBorderColor = True
        Me.gvApp.Appearance.OddRow.Options.UseForeColor = True
        Me.gvApp.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gvApp.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvApp.Appearance.Preview.Options.UseFont = True
        Me.gvApp.Appearance.Preview.Options.UseForeColor = True
        Me.gvApp.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gvApp.Appearance.Row.Options.UseBackColor = True
        Me.gvApp.Appearance.Row.Options.UseForeColor = True
        Me.gvApp.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvApp.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gvApp.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gvApp.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gvApp.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gvApp.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvApp.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvApp.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gvApp.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvApp.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gvApp.Appearance.VertLine.Options.UseBackColor = True
        Me.gvApp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvApp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_cust, Me.no_inv, Me.tgl_inv, Me.jml_val_trans, Me.tgl_approve, Me.jml_tagihan, Me.status, Me.ket_approve})
        Me.gvApp.GridControl = Me.gcApp
        Me.gvApp.Name = "gvApp"
        Me.gvApp.OptionsCustomization.AllowColumnMoving = False
        Me.gvApp.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvApp.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gvApp.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvApp.OptionsView.EnableAppearanceEvenRow = True
        Me.gvApp.OptionsView.EnableAppearanceOddRow = True
        Me.gvApp.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.gvApp.OptionsView.ShowChildrenInGroupPanel = True
        Me.gvApp.OptionsView.ShowGroupPanel = False
        Me.gvApp.PaintStyleName = "Office2003"
        '
        'kd_cust
        '
        Me.kd_cust.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.kd_cust.AppearanceHeader.Options.UseFont = True
        Me.kd_cust.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_cust.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_cust.Caption = "Nama"
        Me.kd_cust.ColumnEdit = Me.lueNama
        Me.kd_cust.FieldName = "kd_cust"
        Me.kd_cust.Name = "kd_cust"
        Me.kd_cust.OptionsColumn.ReadOnly = True
        Me.kd_cust.Visible = True
        Me.kd_cust.VisibleIndex = 0
        Me.kd_cust.Width = 35
        '
        'lueNama
        '
        Me.lueNama.AutoHeight = False
        Me.lueNama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNama.Name = "lueNama"
        '
        'no_inv
        '
        Me.no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.no_inv.AppearanceHeader.Options.UseFont = True
        Me.no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_inv.Caption = "No. Trans"
        Me.no_inv.FieldName = "no_inv"
        Me.no_inv.Name = "no_inv"
        Me.no_inv.OptionsColumn.ReadOnly = True
        Me.no_inv.Visible = True
        Me.no_inv.VisibleIndex = 1
        Me.no_inv.Width = 55
        '
        'tgl_inv
        '
        Me.tgl_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_inv.AppearanceHeader.Options.UseFont = True
        Me.tgl_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_inv.Caption = "Tanggal Pengajuan"
        Me.tgl_inv.ColumnEdit = Me.deTglInv
        Me.tgl_inv.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_inv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_inv.FieldName = "tgl_inv"
        Me.tgl_inv.Name = "tgl_inv"
        Me.tgl_inv.OptionsColumn.ReadOnly = True
        Me.tgl_inv.Visible = True
        Me.tgl_inv.VisibleIndex = 2
        Me.tgl_inv.Width = 100
        '
        'deTglInv
        '
        Me.deTglInv.AutoHeight = False
        Me.deTglInv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglInv.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTglInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglInv.EditFormat.FormatString = "d MMMM yyyy"
        Me.deTglInv.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglInv.Mask.EditMask = "dd MMMM yyyy"
        Me.deTglInv.Name = "deTglInv"
        Me.deTglInv.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'jml_val_trans
        '
        Me.jml_val_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_val_trans.AppearanceHeader.Options.UseFont = True
        Me.jml_val_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_val_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_val_trans.Caption = "Jumlah Pengajuan"
        Me.jml_val_trans.ColumnEdit = Me.txtJmlAju
        Me.jml_val_trans.DisplayFormat.FormatString = "n2"
        Me.jml_val_trans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_val_trans.FieldName = "jml_val_trans"
        Me.jml_val_trans.Name = "jml_val_trans"
        Me.jml_val_trans.OptionsColumn.ReadOnly = True
        Me.jml_val_trans.Visible = True
        Me.jml_val_trans.VisibleIndex = 3
        Me.jml_val_trans.Width = 95
        '
        'txtJmlAju
        '
        Me.txtJmlAju.DisplayFormat.FormatString = "n2"
        Me.txtJmlAju.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlAju.EditFormat.FormatString = "n2"
        Me.txtJmlAju.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlAju.Mask.EditMask = "n2"
        Me.txtJmlAju.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlAju.Mask.UseMaskAsDisplayFormat = True
        Me.txtJmlAju.Name = "txtJmlAju"
        Me.txtJmlAju.ValidateOnEnterKey = True
        '
        'tgl_approve
        '
        Me.tgl_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_approve.AppearanceHeader.Options.UseFont = True
        Me.tgl_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_approve.Caption = "Tanggal Approve"
        Me.tgl_approve.ColumnEdit = Me.deTglApp
        Me.tgl_approve.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.tgl_approve.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_approve.FieldName = "tgl_approve"
        Me.tgl_approve.Name = "tgl_approve"
        Me.tgl_approve.Visible = True
        Me.tgl_approve.VisibleIndex = 4
        Me.tgl_approve.Width = 90
        '
        'deTglApp
        '
        Me.deTglApp.AutoHeight = False
        Me.deTglApp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTglApp.DisplayFormat.FormatString = "d MMMM yyyy"
        Me.deTglApp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglApp.EditFormat.FormatString = "d MMMM yyyy"
        Me.deTglApp.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTglApp.Mask.EditMask = "d MMMM yyyy"
        Me.deTglApp.Name = "deTglApp"
        Me.deTglApp.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Jumlah Approve"
        Me.jml_tagihan.ColumnEdit = Me.txtJmlApp
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 5
        Me.jml_tagihan.Width = 85
        '
        'txtJmlApp
        '
        Me.txtJmlApp.DisplayFormat.FormatString = "n2"
        Me.txtJmlApp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlApp.EditFormat.FormatString = "n2"
        Me.txtJmlApp.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtJmlApp.Mask.EditMask = "n2"
        Me.txtJmlApp.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtJmlApp.Mask.UseMaskAsDisplayFormat = True
        Me.txtJmlApp.Name = "txtJmlApp"
        Me.txtJmlApp.ValidateOnEnterKey = True
        '
        'status
        '
        Me.status.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.status.AppearanceHeader.Options.UseFont = True
        Me.status.AppearanceHeader.Options.UseTextOptions = True
        Me.status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.status.Caption = "Status"
        Me.status.ColumnEdit = Me.cmbStatus
        Me.status.FieldName = "status"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 6
        Me.status.Width = 39
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoHeight = False
        Me.cmbStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Items.AddRange(New Object() {"APPROVE", "REJECT"})
        Me.cmbStatus.Name = "cmbStatus"
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.ket_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ket_approve.Caption = "Keterangan"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 7
        Me.ket_approve.Width = 64
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 10)
        Me.Panel1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 34)
        Me.Panel2.TabIndex = 33
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(256, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "SimpleButton1"
        Me.SimpleButton1.Visible = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(905, 34)
        Me.pnlTop.TabIndex = 32
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
        Me.Label1.Size = New System.Drawing.Size(600, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "       FORM APPROVE PIUTANG KARYAWAN DAN PIUTANG LAIN-LAIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cek_post
        '
        Me.cek_post.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cek_post.AppearanceHeader.Options.UseBackColor = True
        Me.cek_post.AppearanceHeader.Options.UseFont = True
        Me.cek_post.Caption = "Cek Post."
        Me.cek_post.FieldName = "cek_post"
        Me.cek_post.Name = "cek_post"
        Me.cek_post.Visible = True
        Me.cek_post.VisibleIndex = 0
        Me.cek_post.Width = 83
        '
        'tgl_posting
        '
        Me.tgl_posting.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_posting.AppearanceHeader.Options.UseBackColor = True
        Me.tgl_posting.AppearanceHeader.Options.UseFont = True
        Me.tgl_posting.Caption = "Tgl. Posting"
        Me.tgl_posting.FieldName = "tgl_posting"
        Me.tgl_posting.Name = "tgl_posting"
        Me.tgl_posting.Visible = True
        Me.tgl_posting.VisibleIndex = 0
        Me.tgl_posting.Width = 88
        '
        'rek_attribute1
        '
        Me.rek_attribute1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rek_attribute1.AppearanceHeader.Options.UseBackColor = True
        Me.rek_attribute1.AppearanceHeader.Options.UseFont = True
        Me.rek_attribute1.Caption = "Rek. Kas/Bank"
        Me.rek_attribute1.FieldName = "rek_attribute1"
        Me.rek_attribute1.Name = "rek_attribute1"
        Me.rek_attribute1.Visible = True
        Me.rek_attribute1.VisibleIndex = 0
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseBackColor = True
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.OptionsColumn.ReadOnly = True
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 0
        '
        'aFormAppPiutKar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormAppPiutKar"
        Me.Text = "aFormAppPiutKar"
        Me.pnl.ResumeLayout(False)
        CType(Me.gcApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglInv.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlAju, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglApp.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTglApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gcApp As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvApp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_cust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deTglInv As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cek_post As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_posting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rek_attribute1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_val_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deTglApp As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueNama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtJmlAju As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtJmlApp As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
