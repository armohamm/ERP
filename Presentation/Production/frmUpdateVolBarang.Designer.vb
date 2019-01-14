<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateVolBarang
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
        Me.Pnl = New System.Windows.Forms.Panel
        Me.pnl_tengah = New DevExpress.XtraEditors.PanelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txt_JumlahAsal = New DevExpress.XtraEditors.TextEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txt_P_Asal = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_L_Asal = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_T_Asal = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.BTN_KONFIRM = New DevExpress.XtraEditors.SimpleButton
        Me.txt_satuanasal = New System.Windows.Forms.TextBox
        Me.LU_barangAsal = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pnl.SuspendLayout()
        CType(Me.pnl_tengah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_tengah.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_JumlahAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txt_P_Asal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_L_Asal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_T_Asal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LU_barangAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.Controls.Add(Me.pnl_tengah)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 3)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(712, 253)
        Me.Pnl.TabIndex = 91
        '
        'pnl_tengah
        '
        Me.pnl_tengah.Controls.Add(Me.Panel2)
        Me.pnl_tengah.Controls.Add(Me.Panel3)
        Me.pnl_tengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_tengah.Location = New System.Drawing.Point(0, 37)
        Me.pnl_tengah.Name = "pnl_tengah"
        Me.pnl_tengah.Size = New System.Drawing.Size(712, 216)
        Me.pnl_tengah.TabIndex = 93
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(2, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 58)
        Me.Panel2.TabIndex = 99
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_JumlahAsal)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.BTN_KONFIRM)
        Me.Panel3.Controls.Add(Me.txt_satuanasal)
        Me.Panel3.Controls.Add(Me.LU_barangAsal)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(708, 156)
        Me.Panel3.TabIndex = 97
        '
        'txt_JumlahAsal
        '
        Me.txt_JumlahAsal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_JumlahAsal.Location = New System.Drawing.Point(153, 63)
        Me.txt_JumlahAsal.Name = "txt_JumlahAsal"
        Me.txt_JumlahAsal.Properties.DisplayFormat.FormatString = "N2"
        Me.txt_JumlahAsal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_JumlahAsal.Properties.Mask.EditMask = "N2"
        Me.txt_JumlahAsal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_JumlahAsal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_JumlahAsal.Properties.NullText = "0,00"
        Me.txt_JumlahAsal.Size = New System.Drawing.Size(488, 20)
        Me.txt_JumlahAsal.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txt_P_Asal)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.txt_L_Asal)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.txt_T_Asal)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(153, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(488, 23)
        Me.Panel6.TabIndex = 3
        '
        'txt_P_Asal
        '
        Me.txt_P_Asal.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_P_Asal.Location = New System.Drawing.Point(283, 0)
        Me.txt_P_Asal.Name = "txt_P_Asal"
        Me.txt_P_Asal.Properties.DisplayFormat.FormatString = "N2"
        Me.txt_P_Asal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_P_Asal.Properties.Mask.EditMask = "N2"
        Me.txt_P_Asal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_P_Asal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_P_Asal.Properties.NullText = "0,00"
        Me.txt_P_Asal.Size = New System.Drawing.Size(100, 20)
        Me.txt_P_Asal.TabIndex = 135
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(256, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 21)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "P :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_L_Asal
        '
        Me.txt_L_Asal.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_L_Asal.Location = New System.Drawing.Point(156, 0)
        Me.txt_L_Asal.Name = "txt_L_Asal"
        Me.txt_L_Asal.Properties.DisplayFormat.FormatString = "N2"
        Me.txt_L_Asal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_L_Asal.Properties.Mask.EditMask = "N2"
        Me.txt_L_Asal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_L_Asal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_L_Asal.Properties.NullText = "0,00"
        Me.txt_L_Asal.Size = New System.Drawing.Size(100, 20)
        Me.txt_L_Asal.TabIndex = 132
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(129, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 21)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "L :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_T_Asal
        '
        Me.txt_T_Asal.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_T_Asal.Location = New System.Drawing.Point(27, 0)
        Me.txt_T_Asal.Name = "txt_T_Asal"
        Me.txt_T_Asal.Properties.DisplayFormat.FormatString = "N2"
        Me.txt_T_Asal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_T_Asal.Properties.Mask.EditMask = "N2"
        Me.txt_T_Asal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_T_Asal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_T_Asal.Properties.NullText = "0,00"
        Me.txt_T_Asal.Size = New System.Drawing.Size(102, 20)
        Me.txt_T_Asal.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 21)
        Me.Label13.TabIndex = 130
        Me.Label13.Text = "T :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_KONFIRM
        '
        Me.BTN_KONFIRM.Image = Global.Presentation.My.Resources.Resources.check2
        Me.BTN_KONFIRM.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BTN_KONFIRM.Location = New System.Drawing.Point(513, 98)
        Me.BTN_KONFIRM.Name = "BTN_KONFIRM"
        Me.BTN_KONFIRM.Size = New System.Drawing.Size(128, 38)
        Me.BTN_KONFIRM.TabIndex = 125
        Me.BTN_KONFIRM.Text = "KALKULASI"
        '
        'txt_satuanasal
        '
        Me.txt_satuanasal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_satuanasal.Location = New System.Drawing.Point(153, 20)
        Me.txt_satuanasal.MaxLength = 12
        Me.txt_satuanasal.Name = "txt_satuanasal"
        Me.txt_satuanasal.ReadOnly = True
        Me.txt_satuanasal.Size = New System.Drawing.Size(488, 20)
        Me.txt_satuanasal.TabIndex = 2
        '
        'LU_barangAsal
        '
        Me.LU_barangAsal.Dock = System.Windows.Forms.DockStyle.Top
        Me.LU_barangAsal.Location = New System.Drawing.Point(153, 0)
        Me.LU_barangAsal.Name = "LU_barangAsal"
        Me.LU_barangAsal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_barangAsal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", 100, "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 500, "Nama Barang")})
        Me.LU_barangAsal.Properties.NullText = "Pilih Barang"
        Me.LU_barangAsal.Size = New System.Drawing.Size(488, 20)
        Me.LU_barangAsal.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(641, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(67, 156)
        Me.Panel5.TabIndex = 109
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(153, 156)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Volume Barang :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Dimensi Barang :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 20)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Satuan Barang :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Nama Barang :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 37)
        Me.Panel1.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UPDATE VOLUME BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUpdateVolBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 261)
        Me.Controls.Add(Me.Pnl)
        Me.Name = "frmUpdateVolBarang"
        Me.Text = "frmKonversiBarang"
        Me.Pnl.ResumeLayout(False)
        CType(Me.pnl_tengah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_tengah.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txt_JumlahAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txt_P_Asal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_L_Asal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_T_Asal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LU_barangAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl_tengah As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_satuanasal As System.Windows.Forms.TextBox
    Friend WithEvents LU_barangAsal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BTN_KONFIRM As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_JumlahAsal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_T_Asal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_P_Asal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_L_Asal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
