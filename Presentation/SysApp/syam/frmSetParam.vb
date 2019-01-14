Public Class frmSetParam
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim obj As Object
    Dim dSO As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete )
    Dim row As DataRowView '<-- menampung row master
    Dim DA, DAD As SqlClient.SqlDataAdapter
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public Sub setStatus()
        Exit Sub
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
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as state from KOPKAR.dbo.SIF_Gen_Reff order by Ref_Role", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "M")
        GC.DataSource = dSO.Tables("M")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as state from KOPKAR.dbo.SIF_Gen_Reff_D", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DAD.Fill(dSO, "D")
        GCD.DataSource = dSO.Tables("D")
        Dim colM(1) As DataColumn
        Dim colD(1) As DataColumn
        colM(0) = dSO.Tables("M").Columns("Id_Ref_File")
        colM(1) = dSO.Tables("M").Columns("Ref_Role")

        colD(0) = dSO.Tables("D").Columns("Id_Ref_File")
        colD(1) = dSO.Tables("D").Columns("ref_Role")

        dSO.Relations.Add("theRelation", colM, colD, False)
        'default_add(prn)
        STATE = "EDIT"
        setStatus()
        doFilter()
    End Sub

    Public Sub cancel_click()
        dSO.Tables("M").Clear()
        dSO.Tables("D").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as state from KOPKAR.dbo.SIF_Gen_Reff", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "M")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as state from KOPKAR.dbo.SIF_Gen_Reff_D", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DAD.Fill(dSO, "D")
    End Sub

    Public Sub delete_click()

    End Sub

    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.SIF_Gen_Reff", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "M")
        'default_add(prn)
        btnDelete = True
        setStatus()
    End Sub

    Public Sub save_click()
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(dSO.Tables("M"))

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            DAD.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DAD.Update(dSO.Tables("D"))

            dSO.Tables("M").AcceptChanges()
            dSO.Tables("D").AcceptChanges()

            For Each row As DataRow In (dSO.Tables(0).Rows)
                row.Item("state") = 1
            Next
            For Each row As DataRow In (dSO.Tables(1).Rows)
                row.Item("state") = 1
            Next
            showMessages("Saved....")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click() ' cuman manggil fungsi doang

    End Sub

    Private Sub kosong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        add_click()
        GV.ViewCaption = "Parameter Master"
        GVD.ViewCaption = "Parameter Detail"

    End Sub
    Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
        doFilter()
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        row = GV.GetRow(e.RowHandle)
        row("Kd_Cabang") = kdcabang
        row("Last_Create_Date") = Now
        row("Last_Created_By") = username
        row("Program_Name") = Me.Name
        row("state") = 2
    End Sub
    Private Sub GVD_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVD.InitNewRow
        If GV.RowCount > 1 Then
            Dim i As Int16 = GV.GetSelectedRows(0)
            row = GVD.GetRow(e.RowHandle)
            row("Last_Create_Date") = Now
            row("Last_Created_By") = username
            row("Program_Name") = Me.Name
            row("Kd_Cabang") = kdcabang
            row("Id_Ref_File") = GV.GetRow(i).item("Id_Ref_File")
            row("Id_Ref_Data") = GV.GetRow(i).item("Id_Table")
            row("Ref_Role") = GV.GetRow(i).item("Ref_Role")
            ' row("Id_Data") = dSO.Tables("D").Select("Id_Data=max(Id_Data) ")(0)("Desc_Data")
            row("state") = 2
        Else
            GVD.CancelUpdateCurrentRow()
            e = Nothing
        End If
    End Sub
    Sub doFilter()
        Try
            dSO.Tables("D").DefaultView.RowFilter = "Id_Ref_File = 'xxxxxx'"
            If GV.RowCount = 0 Then Exit Sub
            If GV.GetSelectedRows.Count = 0 Then Exit Sub
            If GV.GetSelectedRows(0) < 0 Then Exit Sub
            dSO.Tables("D").DefaultView.RowFilter = "Id_Ref_File = '" & GV.GetRow(GV.GetSelectedRows(0)).item("Id_Ref_File") & "'"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Delete Selected Row ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each dr As DataRow In dSO.Tables("D").Select("Id_Ref_File = '" & GV.GetRow(GV.GetSelectedRows(0)).item("Id_Ref_File") & "'")
                    dr.Delete()
                Next
                GV.DeleteSelectedRows()
                doFilter()
            End If
        End If
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        e.Row("Last_Update_Date") = Now
        e.Row("Last_Updated_By") = username
        e.Row("Program_Name") = Me.Name

        If e.Row("state") = 1 Then e.Row("state") = 3
    End Sub

    Private Sub GVD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVD.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Delete Selected Row ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                GVD.DeleteSelectedRows()
            End If
        End If
    End Sub
    Private Sub GVd_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVD.RowUpdated
        If GV.RowCount > 1 Then
            e.Row("Last_Update_Date") = Now
            e.Row("Last_Updated_By") = username
            e.Row("Program_Name") = Me.Name
            If e.Row("state") = 1 Then e.Row("state") = 3
        Else
            GVD.CancelUpdateCurrentRow()
            e = Nothing
        End If
    End Sub

End Class