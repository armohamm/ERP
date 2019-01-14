<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenanceBiayaPerDivisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceBiayaPerDivisi))
        Me.Pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nm_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.div1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSPRING = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.div2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSPON = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.div3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.REPumum = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.div4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepFA = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.div5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repHRD = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repbkbesar = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSPRING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSPON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPumum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepFA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repHRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repbkbesar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.SystemColors.Control
        Me.Pnl.Controls.Add(Me.GC)
        Me.Pnl.Controls.Add(Me.pnlTengahAtas)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(1105, 465)
        Me.Pnl.TabIndex = 5
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GC.Location = New System.Drawing.Point(0, 47)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepFA, Me.repbkbesar, Me.repHRD, Me.REPumum, Me.repSPON, Me.repSPRING})
        Me.GC.Size = New System.Drawing.Size(1105, 418)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd, Me.nm_buku_besar, Me.div1, Me.div2, Me.div3, Me.div4, Me.div5})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsCustomization.AllowColumnMoving = False
        Me.GV.OptionsCustomization.AllowColumnResizing = False
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.EnableMasterViewMode = False
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsView.EnableAppearanceEvenRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'kd
        '
        Me.kd.Caption = "Kode Buku Besar"
        Me.kd.FieldName = "kd_buku_besar"
        Me.kd.Name = "kd"
        Me.kd.OptionsColumn.AllowEdit = False
        Me.kd.OptionsColumn.ReadOnly = True
        Me.kd.Visible = True
        Me.kd.VisibleIndex = 0
        Me.kd.Width = 228
        '
        'nm_buku_besar
        '
        Me.nm_buku_besar.Caption = "Nama Buku Besar"
        Me.nm_buku_besar.FieldName = "nm_buku_besar"
        Me.nm_buku_besar.Name = "nm_buku_besar"
        Me.nm_buku_besar.OptionsColumn.AllowEdit = False
        Me.nm_buku_besar.OptionsColumn.ReadOnly = True
        Me.nm_buku_besar.Visible = True
        Me.nm_buku_besar.VisibleIndex = 1
        Me.nm_buku_besar.Width = 475
        '
        'div1
        '
        Me.div1.AppearanceHeader.Options.UseTextOptions = True
        Me.div1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div1.Caption = "Spring"
        Me.div1.ColumnEdit = Me.repSPRING
        Me.div1.FieldName = "div1"
        Me.div1.Name = "div1"
        Me.div1.Visible = True
        Me.div1.VisibleIndex = 2
        Me.div1.Width = 89
        '
        'repSPRING
        '
        Me.repSPRING.AutoHeight = False
        Me.repSPRING.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.repSPRING.Caption = "TIDAK"
        Me.repSPRING.DisplayValueChecked = "YA"
        Me.repSPRING.DisplayValueUnchecked = "TIDAK"
        Me.repSPRING.Name = "repSPRING"
        Me.repSPRING.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repSPRING.NullText = "TIDAK"
        Me.repSPRING.ValueChecked = "Y"
        Me.repSPRING.ValueUnchecked = "T"
        '
        'div2
        '
        Me.div2.AppearanceHeader.Options.UseTextOptions = True
        Me.div2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div2.Caption = "Spon"
        Me.div2.ColumnEdit = Me.repSPON
        Me.div2.FieldName = "div2"
        Me.div2.Name = "div2"
        Me.div2.Visible = True
        Me.div2.VisibleIndex = 3
        Me.div2.Width = 71
        '
        'repSPON
        '
        Me.repSPON.AutoHeight = False
        Me.repSPON.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.repSPON.Caption = "TIDAK"
        Me.repSPON.DisplayValueChecked = "YA"
        Me.repSPON.DisplayValueUnchecked = "TIDAK"
        Me.repSPON.Name = "repSPON"
        Me.repSPON.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repSPON.NullText = "TIDAK"
        Me.repSPON.ValueChecked = "Y"
        Me.repSPON.ValueUnchecked = "T"
        '
        'div3
        '
        Me.div3.AppearanceHeader.Options.UseTextOptions = True
        Me.div3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div3.Caption = "Umum"
        Me.div3.ColumnEdit = Me.REPumum
        Me.div3.FieldName = "div3"
        Me.div3.Name = "div3"
        Me.div3.Visible = True
        Me.div3.VisibleIndex = 4
        Me.div3.Width = 78
        '
        'REPumum
        '
        Me.REPumum.AutoHeight = False
        Me.REPumum.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.REPumum.Caption = "TIDAK"
        Me.REPumum.DisplayValueChecked = "YA"
        Me.REPumum.DisplayValueUnchecked = "TIDAK"
        Me.REPumum.Name = "REPumum"
        Me.REPumum.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.REPumum.NullText = "TIDAK"
        Me.REPumum.ValueChecked = "Y"
        Me.REPumum.ValueUnchecked = "T"
        '
        'div4
        '
        Me.div4.AppearanceHeader.Options.UseTextOptions = True
        Me.div4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div4.Caption = "FA"
        Me.div4.ColumnEdit = Me.RepFA
        Me.div4.FieldName = "div4"
        Me.div4.Name = "div4"
        Me.div4.Visible = True
        Me.div4.VisibleIndex = 5
        Me.div4.Width = 66
        '
        'RepFA
        '
        Me.RepFA.AutoHeight = False
        Me.RepFA.AutoWidth = True
        Me.RepFA.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepFA.Caption = "TIDAK"
        Me.RepFA.DisplayValueChecked = "YA"
        Me.RepFA.DisplayValueUnchecked = "TIDAK"
        Me.RepFA.FullFocusRect = True
        Me.RepFA.Name = "RepFA"
        Me.RepFA.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepFA.NullText = "TIDAK"
        Me.RepFA.ValueChecked = "Y"
        Me.RepFA.ValueUnchecked = "T"
        '
        'div5
        '
        Me.div5.AppearanceHeader.Options.UseTextOptions = True
        Me.div5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.div5.Caption = "HRD"
        Me.div5.ColumnEdit = Me.repHRD
        Me.div5.Name = "div5"
        Me.div5.Visible = True
        Me.div5.VisibleIndex = 6
        Me.div5.Width = 77
        '
        'repHRD
        '
        Me.repHRD.AutoHeight = False
        Me.repHRD.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.repHRD.Caption = "TIDAK"
        Me.repHRD.DisplayValueChecked = "YA"
        Me.repHRD.DisplayValueUnchecked = "TIDAK"
        Me.repHRD.Name = "repHRD"
        Me.repHRD.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repHRD.NullText = "TIDAK"
        Me.repHRD.ValueChecked = "Y"
        Me.repHRD.ValueUnchecked = "T"
        '
        'repbkbesar
        '
        Me.repbkbesar.AutoHeight = False
        Me.repbkbesar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repbkbesar.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Buku Besar")})
        Me.repbkbesar.DisplayMember = "nm_buku_besar"
        Me.repbkbesar.HideSelection = False
        Me.repbkbesar.Name = "repbkbesar"
        Me.repbkbesar.NullText = "[Kode Buku Besar]"
        Me.repbkbesar.ValueMember = "kd_buku_besar"
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Size = New System.Drawing.Size(1105, 10)
        Me.pnlTengahAtas.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 37)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(37, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FORM MAINTENANCE BIAYA PER DIVISI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'frmMaintenanceBiayaPerDivisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmMaintenanceBiayaPerDivisi"
        Me.Text = " FORM MAINTENANCE BIAYA PER DIVISI"
        Me.Pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSPRING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSPON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPumum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepFA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repHRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repbkbesar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nm_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents div1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents div2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spec_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents div3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents div4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepFA As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repbkbesar As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents div5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repHRD As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents REPumum As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repSPON As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repSPRING As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
