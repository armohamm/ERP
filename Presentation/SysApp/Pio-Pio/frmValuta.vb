Imports System.Data.SqlClient

Public Class frmValuta
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Dim rc As Integer
    Dim dt As DataTable
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DALOOKUP As SqlClient.SqlDataAdapter
    Dim newRow As DataRow
    Dim myBuilder As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True
        'End With
        'setStatus()

    End Sub
    Private Sub load_data()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_VALUTA ", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "VALUTA")
        gc.DataSource = dSO.Tables("VALUTA")
    End Sub

    Private Sub frmValuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = Me.Parent
        While Not TypeOf obj Is Form
            obj = obj.Parent
        End While
        prn = obj
        connect()
        load_data()
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        Me.Enabled = True
        STATE = "ADD" '<-- set state= add
    End Sub
    Public Sub save_click()
        For Each rows As DataRow In dSO.Tables("VALUTA").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Kd_Cabang") = 1 'row.Item("Kd_Cabang")
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
            Else
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
            End If

            'rows.Item("Kode_Kain") = kd_kain - 1
        Next

        ' Try

        DA.Update(dSO.Tables(0))
        dSO.Tables(0).AcceptChanges()

        showMessages("Berhasil disimpan.")
    End Sub
    Public Sub delete_click()
        If MessageBox.Show("Apakah ingin menghapus Record ini?", _
          "Delete", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Batal Dihapus")
            Exit Sub
        End If
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        gv.DeleteSelectedRows()
        MsgBox("Berhasil diHapus")
        DA.Update(dSO, "VALUTA")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub
    Public Sub cancel_click()
        'default_cancel(prn)
        setStatus()
        'Me.Enabled = False
        STATE = "ADD"
    End Sub
End Class