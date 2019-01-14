Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSubTipeBarang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public obj As Object
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Dim rc As Integer
    Dim dt As DataTable
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA1, DALOOKUP As SqlClient.SqlDataAdapter
    Dim dr As SqlDataReader
    Dim newRow As DataRow
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
        End With
        setStatus()
        STATE = "ADD" '<-- set state= add
    End Sub
    Private Sub load_data()
        If Not dSO.Tables("Tipe") Is Nothing Then dSO.Tables("Tipe").Clear()
        If Not dSO.Tables("SubTipe") Is Nothing Then dSO.Tables("SubTipe").Clear()

        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe kd_tipe,Nama_Tipe from dbo.SIF_Tipe ", sqlconn)) '<- query buat ditampilkan di LOV
        DA1.Fill(dSO, "Tipe")
        RepositoryItemLookUpEdit1.DataSource = dSO.Tables("Tipe")
        RepositoryItemLookUpEdit1.ValueMember = "kd_tipe"
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Tipe"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_Sub_Tipe ", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "SubTipe")

        gc.DataSource = dSO.Tables("SubTipe")
        gc.Refresh()
    End Sub

    Private Sub frmSubTipeBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = getParent(Me)
        prn = obj
        Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        pnl.Left = (Me.Width - pnl.Width) / 2
        pnl.Top = pnl.Height / 3

        connect()
        load_data()
        'myBuilder = New SqlClient.SqlCommandBuilder(DA)
        'DA.UpdateCommand = myBuilder.GetUpdateCommand()
    End Sub

    Public Sub save_click()
        Try
            For Each rows As DataRow In dSO.Tables("SubTipe").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = getKodeCabang()
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("Program_Name") = Me.Name
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            Next
            myBuilder = New SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            DA.Update(dSO.Tables("SubTipe"))
            dSO.Tables("SubTipe").AcceptChanges()
            showMessages("Data Berhasil di Update..!", 14)
            
        Catch ex As Exception
            dSO.Tables("SubTipe").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
        End Try
    End Sub
    Public Sub cancel_click()
        default_cancel(prn)

        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_Sub_Tipe", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DALOOKUP.Fill(dSO, "LOOKUP")
        frmCari.set_dso(dSO.Tables("LOOKUP")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            If dSO.Tables("LOOKUP").Rows.Count > 0 Then
                dSO = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_Sub_Tipe where Kd_Sub_Tipe='" & frmCari.row("Kd_Sub_tipe") & "'", sqlconn)) '<- query buat ditampilkan di LOV
                DA.Fill(dSO, "SubTipe")
                gc.DataSource = dSO.Tables("SubTipe")
                STATE = "EDIT"
                'prn.btnSave.Enabled = True
                'prn.btnCancel.Enabled = True
                'prn.btnDelete.Enabled = True
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub
    Public Sub delete_click()
        If MessageBox.Show("Apakah ingin menghapus Record ini?", _
          "Delete", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub
        End If
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        gv.DeleteSelectedRows()
        MsgBox("deleted successfully")
        DA.Update(dSO, "SubTipe")
    End Sub

    'Private Sub spd_add(ByVal sender As Object, ByVal e As DataTableNewRowEventArgs)
    '    newRow = e.Row
    'End Sub

    'Private Sub row_chg(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    If e.Row.Item("Kd_Sub_Tipe").ToString = "" Then
    '        e.Row.Delete()
    '    End If
    'End Sub
    'Private Sub gc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gc.KeyDown
    '    If e.KeyCode = Keys.Down Then
    '        MsgBox(sender.ToString)
    '        If "" & newRow.Item("Kd_Sub_Tipe") = "" Then
    '            e.SuppressKeyPress = True
    '        End If
    '        e = Nothing
    '    End If
    'End Sub

    Private Sub gv_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        Dim View As ColumnView = sender
        Dim kodex As String = ""

        If Microsoft.VisualBasic.Len(gv.RowCount.ToString) = 1 Then
            kodex = "00" & gv.RowCount.ToString
        ElseIf Microsoft.VisualBasic.Len(gv.RowCount.ToString) = 2 Then
            kodex = "0" & gv.RowCount.ToString
        ElseIf Microsoft.VisualBasic.Len(gv.RowCount.ToString) = 3 Then
            kodex = gv.RowCount.ToString
        End If
        View.SetRowCellValue(e.RowHandle, View.Columns("Kd_Sub_Tipe"), kodex)
        kodex = ""
    End Sub

    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        'Try
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("Nama_Sub_Tipe")
        If view.GetRowCellValue(e.RowHandle, column1).ToString = "" Or view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Then
            e.Valid = False
            view.SetColumnError(column1, "Tidak boleh kosong.")
        End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class