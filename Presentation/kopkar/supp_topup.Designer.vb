<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supp_topup
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.te_saldo_akhir = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.te_saldo = New DevExpress.XtraEditors.TextEdit
        Me.lb_state = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.le_supplier = New DevExpress.XtraEditors.LookUpEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.te_jumlah = New DevExpress.XtraEditors.TextEdit
        Me.dt_tgl_trans = New DevExpress.XtraEditors.DateEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GCTopup = New DevExpress.XtraGrid.GridControl
        Me.GVTopup = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.g_tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.g_jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1.SuspendLayout()
        CType(Me.te_saldo_akhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.le_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.te_jumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl_trans.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_tgl_trans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GCTopup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVTopup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.te_saldo_akhir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.te_saldo)
        Me.Panel1.Controls.Add(Me.lb_state)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.le_supplier)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.te_jumlah)
        Me.Panel1.Controls.Add(Me.dt_tgl_trans)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 324)
        Me.Panel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(103, 210)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 27)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Saldo Akhir"
        '
        'te_saldo_akhir
        '
        Me.te_saldo_akhir.Location = New System.Drawing.Point(132, 174)
        Me.te_saldo_akhir.Name = "te_saldo_akhir"
        Me.te_saldo_akhir.Properties.Appearance.Options.UseTextOptions = True
        Me.te_saldo_akhir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_saldo_akhir.Properties.DisplayFormat.FormatString = "n0"
        Me.te_saldo_akhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_saldo_akhir.Properties.EditFormat.FormatString = "n0"
        Me.te_saldo_akhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_saldo_akhir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_saldo_akhir.Properties.ReadOnly = True
        Me.te_saldo_akhir.Size = New System.Drawing.Size(120, 20)
        Me.te_saldo_akhir.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Saldo Awal"
        '
        'te_saldo
        '
        Me.te_saldo.Location = New System.Drawing.Point(132, 75)
        Me.te_saldo.Name = "te_saldo"
        Me.te_saldo.Properties.Appearance.Options.UseTextOptions = True
        Me.te_saldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_saldo.Properties.DisplayFormat.FormatString = "n0"
        Me.te_saldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_saldo.Properties.EditFormat.FormatString = "n0"
        Me.te_saldo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_saldo.Properties.ReadOnly = True
        Me.te_saldo.Size = New System.Drawing.Size(120, 20)
        Me.te_saldo.TabIndex = 9
        '
        'lb_state
        '
        Me.lb_state.AutoSize = True
        Me.lb_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_state.ForeColor = System.Drawing.Color.Red
        Me.lb_state.Location = New System.Drawing.Point(10, 9)
        Me.lb_state.Name = "lb_state"
        Me.lb_state.Size = New System.Drawing.Size(63, 15)
        Me.lb_state.TabIndex = 8
        Me.lb_state.Text = "Mode <>"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(190, 210)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 27)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Tutup"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier"
        '
        'le_supplier
        '
        Me.le_supplier.Location = New System.Drawing.Point(132, 42)
        Me.le_supplier.Name = "le_supplier"
        Me.le_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.le_supplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama Supplier")})
        Me.le_supplier.Properties.NullText = ""
        Me.le_supplier.Size = New System.Drawing.Size(120, 20)
        Me.le_supplier.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jumlah Top Up"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(16, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal Top Up"
        '
        'te_jumlah
        '
        Me.te_jumlah.Location = New System.Drawing.Point(132, 141)
        Me.te_jumlah.Name = "te_jumlah"
        Me.te_jumlah.Properties.Appearance.Options.UseTextOptions = True
        Me.te_jumlah.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.te_jumlah.Properties.DisplayFormat.FormatString = "n0"
        Me.te_jumlah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jumlah.Properties.EditFormat.FormatString = "n0"
        Me.te_jumlah.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.te_jumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.te_jumlah.Size = New System.Drawing.Size(120, 20)
        Me.te_jumlah.TabIndex = 1
        '
        'dt_tgl_trans
        '
        Me.dt_tgl_trans.EditValue = Nothing
        Me.dt_tgl_trans.Location = New System.Drawing.Point(132, 108)
        Me.dt_tgl_trans.Name = "dt_tgl_trans"
        Me.dt_tgl_trans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_tgl_trans.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dt_tgl_trans.Size = New System.Drawing.Size(120, 20)
        Me.dt_tgl_trans.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GCTopup)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(266, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 324)
        Me.Panel2.TabIndex = 1
        '
        'GCTopup
        '
        Me.GCTopup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCTopup.Location = New System.Drawing.Point(0, 0)
        Me.GCTopup.MainView = Me.GVTopup
        Me.GCTopup.Name = "GCTopup"
        Me.GCTopup.Size = New System.Drawing.Size(299, 324)
        Me.GCTopup.TabIndex = 0
        Me.GCTopup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTopup})
        '
        'GVTopup
        '
        Me.GVTopup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.g_tgl_trans, Me.g_jumlah})
        Me.GVTopup.GridControl = Me.GCTopup
        Me.GVTopup.Name = "GVTopup"
        Me.GVTopup.OptionsView.ShowGroupPanel = False
        Me.GVTopup.OptionsView.ShowViewCaption = True
        Me.GVTopup.ViewCaption = "Histori Top Up"
        '
        'g_tgl_trans
        '
        Me.g_tgl_trans.Caption = "Tanggal"
        Me.g_tgl_trans.FieldName = "tgl_trans"
        Me.g_tgl_trans.Name = "g_tgl_trans"
        Me.g_tgl_trans.OptionsColumn.AllowEdit = False
        Me.g_tgl_trans.Visible = True
        Me.g_tgl_trans.VisibleIndex = 0
        '
        'g_jumlah
        '
        Me.g_jumlah.Caption = "Jumlah"
        Me.g_jumlah.DisplayFormat.FormatString = "n0"
        Me.g_jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.g_jumlah.FieldName = "jumlah"
        Me.g_jumlah.Name = "g_jumlah"
        Me.g_jumlah.OptionsColumn.AllowEdit = False
        Me.g_jumlah.Visible = True
        Me.g_jumlah.VisibleIndex = 1
        '
        'supp_topup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 324)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "supp_topup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Top Up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.te_saldo_akhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.le_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.te_jumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl_trans.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_tgl_trans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCTopup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVTopup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents le_supplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents te_jumlah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dt_tgl_trans As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lb_state As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents te_saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents te_saldo_akhir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCTopup As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVTopup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents g_tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents g_jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
