<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aFormKalkulasiNotaJual
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
        Me.pnl = New System.Windows.Forms.Panel
        Me.btnKalkulasi = New DevExpress.XtraEditors.SimpleButton
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.gcNota = New DevExpress.XtraGrid.GridControl
        Me.gvNotaJual = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_sj = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lookupSJ = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pnl.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.gcNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNotaJual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupSJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.btnKalkulasi)
        Me.pnl.Controls.Add(Me.Panel13)
        Me.pnl.Controls.Add(Me.Panel12)
        Me.pnl.Controls.Add(Me.pnlFooter)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Location = New System.Drawing.Point(16, 16)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(400, 359)
        Me.pnl.TabIndex = 4
        '
        'btnKalkulasi
        '
        Me.btnKalkulasi.Location = New System.Drawing.Point(163, 290)
        Me.btnKalkulasi.Name = "btnKalkulasi"
        Me.btnKalkulasi.Size = New System.Drawing.Size(75, 23)
        Me.btnKalkulasi.TabIndex = 49
        Me.btnKalkulasi.Text = "Kalkulasi"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel7)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 75)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(400, 205)
        Me.Panel13.TabIndex = 47
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.gcNota)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(75, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(250, 205)
        Me.Panel7.TabIndex = 47
        '
        'gcNota
        '
        Me.gcNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNota.Location = New System.Drawing.Point(0, 0)
        Me.gcNota.MainView = Me.gvNotaJual
        Me.gcNota.Name = "gcNota"
        Me.gcNota.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupSJ})
        Me.gcNota.Size = New System.Drawing.Size(250, 205)
        Me.gcNota.TabIndex = 0
        Me.gcNota.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNotaJual})
        '
        'gvNotaJual
        '
        Me.gvNotaJual.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gvNotaJual.Appearance.TopNewRow.Options.UseFont = True
        Me.gvNotaJual.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_sj})
        Me.gvNotaJual.GridControl = Me.gcNota
        Me.gvNotaJual.Name = "gvNotaJual"
        Me.gvNotaJual.NewItemRowText = "Tambah no. SJ disini"
        Me.gvNotaJual.OptionsCustomization.AllowColumnMoving = False
        Me.gvNotaJual.OptionsCustomization.AllowColumnResizing = False
        Me.gvNotaJual.OptionsCustomization.AllowFilter = False
        Me.gvNotaJual.OptionsCustomization.AllowGroup = False
        Me.gvNotaJual.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvNotaJual.OptionsView.EnableAppearanceEvenRow = True
        Me.gvNotaJual.OptionsView.EnableAppearanceOddRow = True
        Me.gvNotaJual.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvNotaJual.OptionsView.ShowColumnHeaders = False
        Me.gvNotaJual.OptionsView.ShowDetailButtons = False
        Me.gvNotaJual.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvNotaJual.OptionsView.ShowGroupPanel = False
        Me.gvNotaJual.OptionsView.ShowIndicator = False
        '
        'no_sj
        '
        Me.no_sj.Caption = "No. SJ"
        Me.no_sj.ColumnEdit = Me.lookupSJ
        Me.no_sj.FieldName = "no_sj"
        Me.no_sj.Name = "no_sj"
        Me.no_sj.Visible = True
        Me.no_sj.VisibleIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(75, 205)
        Me.Panel14.TabIndex = 46
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 35)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(400, 40)
        Me.Panel12.TabIndex = 46
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Maroon
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 334)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(400, 25)
        Me.pnlFooter.TabIndex = 2
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
        Me.Panel1.Size = New System.Drawing.Size(400, 35)
        Me.Panel1.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(311, 33)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "KALKULASI ULANG NOTA JUAL"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.log_copy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lookupSJ
        '
        Me.lookupSJ.AutoHeight = False
        Me.lookupSJ.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupSJ.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupSJ.Name = "lookupSJ"
        Me.lookupSJ.NullText = "[No. SJ]"
        Me.lookupSJ.ShowFooter = False
        Me.lookupSJ.ShowHeader = False
        Me.lookupSJ.ShowPopupShadow = False
        Me.lookupSJ.ValidateOnEnterKey = True
        '
        'aFormKalkulasiNotaJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 387)
        Me.Controls.Add(Me.pnl)
        Me.Name = "aFormKalkulasiNotaJual"
        Me.Text = "aFormNeracaSaldo"
        Me.pnl.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.gcNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNotaJual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupSJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents btnKalkulasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcNota As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNotaJual As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_sj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupSJ As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
