Imports System.Data
Public Class frmCari
    Public dipilih As String
    Public row As Data.DataRow
    Dim table As DataTable
    Private Sub frmCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Panel5.Visible = False
        Panel5.Width = Me.Width - 200
        Panel5.Height = Me.Height - 100
        Panel5.Visible = False
        Panel5.Left = (Me.Width - Panel5.Width) / 2
        Panel5.Top = (Me.Height - Panel5.Height) / 2

        Me.Refresh()
        Panel5.Visible = True

    End Sub

    Sub set_dso(ByVal table As DataTable)

        If table Is Nothing Then
            Me.Close()
        End If
        GV.Columns.Clear()
        GC.DataSource = Nothing
        Me.table = table
        GC.DataSource = Me.table
        GV.BestFitColumns()
        GC.AllowDrop = False
        Dim i As Integer
        cmbKolom.Properties.Items.Clear()
        For i = 0 To table.Columns.Count - 1
            cmbKolom.Properties.Items.Insert(i, table.Columns(i).ToString)
        Next
        cmbKolom.EditValue = cmbKolom.Properties.Items(0)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        '<<<<<<<<<  .........versi Yaya modifikasi by drake start here, utk deaktivasi gunakan coment out tanda '
        '/*
        If table.Rows.Count = 0 Then
            Me.Close()
            row = Nothing
            dipilih = ""
        Else
            '*/
            '>>>>>>>>>>>>....versi Yaya modifikasi end here


            '//ini versi asli belum di modifikasi, masih ada error jika gv/gc tidak ada datanya dan di klik pilih/dbl klik, maka terjadi eror
            'terserah suka yang mana dan silahkan di test
            '//silahkan di test tinggal di aktif/non aktif, Jangan menggunakan DEL!!!

            'If GV.GetSelectedRows.Count = 0 Then
            '    btnBatal_Click(btnBatal, New EventArgs)
            'End If

            dipilih = table.Rows(BindingContext(GC.DataSource).Position).Item(0).ToString()
            row = table.Rows(BindingContext(GC.DataSource).Position)

            Close()
        End If '<== bagian dari if diatas, silahkan non aktif jika menggunakan versi asli
    End Sub

    Private Sub GC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC.DoubleClick
        SimpleButton1_Click(cmdOK, New EventArgs)
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        row = Nothing
        dipilih = ""
        Close()
    End Sub

    Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.ClearColumnsFilter()
            Dim ftr As String = cmbKolom.Text & " Like '%" & txtcari.Text & "%'"
            GV.Columns(cmbKolom.EditValue).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)

        End If
    End Sub
    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        TextEdit1_KeyDown(txtcari, New KeyEventArgs(Keys.Enter))
    End Sub
End Class