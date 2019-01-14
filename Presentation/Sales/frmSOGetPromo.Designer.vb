<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOGetPromo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSOGetPromo))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KD_PROMO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PROMO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HADIAH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QTY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tglSO = New System.Windows.Forms.TextBox
        Me.txtNomor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(871, 299)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 79)
        Me.gc.LookAndFeel.SkinName = "The Asphalt World"
        Me.gc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(871, 172)
        Me.gc.TabIndex = 5
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gv.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.Empty.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.EvenRow.Options.UseBackColor = True
        Me.gv.Appearance.EvenRow.Options.UseForeColor = True
        Me.gv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gv.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.gv.Appearance.FixedLine.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.gv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gv.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gv.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gv.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupButton.Options.UseBackColor = True
        Me.gv.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gv.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gv.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gv.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.GroupRow.Options.UseBackColor = True
        Me.gv.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gv.Appearance.GroupRow.Options.UseForeColor = True
        Me.gv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.gv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gv.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gv.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.HorzLine.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.OddRow.Options.UseBackColor = True
        Me.gv.Appearance.OddRow.Options.UseForeColor = True
        Me.gv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.gv.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.gv.Appearance.Preview.Options.UseBackColor = True
        Me.gv.Appearance.Preview.Options.UseFont = True
        Me.gv.Appearance.Preview.Options.UseForeColor = True
        Me.gv.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gv.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gv.Appearance.Row.Options.UseBackColor = True
        Me.gv.Appearance.Row.Options.UseBorderColor = True
        Me.gv.Appearance.Row.Options.UseForeColor = True
        Me.gv.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gv.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gv.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.gv.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gv.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gv.Appearance.VertLine.Options.UseBackColor = True
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KD_PROMO, Me.PROMO, Me.HADIAH, Me.QTY})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.EnableAppearanceOddRow = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.OptionsView.ShowHorzLines = False
        Me.gv.OptionsView.ShowIndicator = False
        Me.gv.OptionsView.ShowPreview = True
        Me.gv.OptionsView.ShowVertLines = False
        Me.gv.PreviewFieldName = "PROMO"
        '
        'KD_PROMO
        '
        Me.KD_PROMO.Caption = "KD_PROMO"
        Me.KD_PROMO.FieldName = "KD_PROMO"
        Me.KD_PROMO.Name = "KD_PROMO"
        '
        'PROMO
        '
        Me.PROMO.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.PROMO.AppearanceCell.Options.UseForeColor = True
        Me.PROMO.Caption = "PROMO"
        Me.PROMO.FieldName = "PROMO"
        Me.PROMO.Name = "PROMO"
        Me.PROMO.OptionsColumn.AllowEdit = False
        Me.PROMO.OptionsColumn.AllowMove = False
        Me.PROMO.OptionsColumn.ReadOnly = True
        Me.PROMO.Width = 523
        '
        'HADIAH
        '
        Me.HADIAH.Caption = "Hadiah"
        Me.HADIAH.FieldName = "PROMO_DESC"
        Me.HADIAH.Name = "HADIAH"
        Me.HADIAH.OptionsColumn.AllowEdit = False
        Me.HADIAH.OptionsColumn.AllowMove = False
        Me.HADIAH.OptionsColumn.ReadOnly = True
        Me.HADIAH.Visible = True
        Me.HADIAH.VisibleIndex = 1
        Me.HADIAH.Width = 616
        '
        'QTY
        '
        Me.QTY.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTY.AppearanceCell.Options.UseFont = True
        Me.QTY.Caption = "Qty"
        Me.QTY.FieldName = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.OptionsColumn.AllowMove = False
        Me.QTY.Visible = True
        Me.QTY.VisibleIndex = 0
        Me.QTY.Width = 48
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.btnSimpan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 251)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(871, 48)
        Me.Panel5.TabIndex = 6
        Me.Panel5.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Appearance.Options.UseFont = True
        Me.btnSimpan.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(778, 0)
        Me.btnSimpan.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnSimpan.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(93, 48)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAtas.Controls.Add(Me.txtCustomer)
        Me.pnlAtas.Controls.Add(Me.Panel4)
        Me.pnlAtas.Controls.Add(Me.Panel3)
        Me.pnlAtas.Controls.Add(Me.Panel2)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 37)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(871, 42)
        Me.pnlAtas.TabIndex = 4
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Location = New System.Drawing.Point(419, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(310, 20)
        Me.txtCustomer.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(290, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(129, 42)
        Me.Panel4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tglSO)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(132, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(158, 42)
        Me.Panel3.TabIndex = 1
        '
        'tglSO
        '
        Me.tglSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSO.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSO.Location = New System.Drawing.Point(0, 20)
        Me.tglSO.Name = "tglSO"
        Me.tglSO.ReadOnly = True
        Me.tglSO.Size = New System.Drawing.Size(158, 20)
        Me.tglSO.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(158, 20)
        Me.txtNomor.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 42)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 2
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
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(871, 37)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = " FORM PROMO SURAT PEMESANAN"
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
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmSOGetPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSOGetPromo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Promo"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        Me.pnlAtas.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents tglSO As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KD_PROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HADIAH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
End Class
