Imports System.Data

Public Class frmUser
    Public STATE As String
    Dim dSO As New DataSet
    Dim row As DataRow
    Dim DA As SqlClient.SqlDataAdapter, sp, spd, da2
    Public saveState As Boolean
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearField()
        GView.Columns("cek").ColumnEdit = repCek
        Me.BackgroundImage = Parent.BackgroundImage
        prn = getParent(Me)
    End Sub
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub edit_click()
        clearField()
        STATE = "EDIT"
        txtUser.Enabled = True
        txtNewuser.Enabled = False
        default_add(prn)
        setStatus()
    End Sub
    Public Sub cancel_click()
        clearField()
        default_cancel(prn)
        Me.Enabled = False
        setStatus()
    End Sub
    Public Sub add_click()
        clearField()
        STATE = "ADD"
        default_add(prn)
        txtUser.Enabled = False
        txtNewuser.Enabled = True
        setStatus()
    End Sub
    Public Function save_click() As Boolean
        Dim myBuilder As SqlClient.SqlCommandBuilder
        Dim row As DataRow
        Dim id As String
        Dim hasil As Boolean = False
        If STATE = "ADD" Then
            row = dSO.Tables("SPM").NewRow
            id = txtNewuser.Text
        Else
            row = dSO.Tables("SPM").Rows(0)
            id = txtUser.Text
        End If

        row.Item(0) = id
        row.Item(1) = txtNama.Text
        row.Item(2) = id
        If STATE = "ADD" Then dSO.Tables("SPM").Rows.Add(row)
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(sp)
            sp.UpdateCommand = myBuilder.GetUpdateCommand()
            sp.Update(dSO.Tables("SPM"))

            For Each rw As DataRow In dSO.Tables("SPD").Rows
                rw.Delete()
            Next
            For Each rw As DataRow In dSO.Tables("SP").Rows
                If rw.Item("cek") = 1 Then
                    row = dSO.Tables("SPD").NewRow
                    row.Item(0) = id
                    row.Item(1) = rw.Item("idrole")

                    dSO.Tables("SPD").Rows.Add(row)
                End If
            Next
            myBuilder = New SqlClient.SqlCommandBuilder(spd)
            spd.UpdateCommand = myBuilder.GetUpdateCommand()
            spd.Update(dSO.Tables("SPD"))

            dSO.Tables("SPM").AcceptChanges()
            dSO.Tables("SPD").AcceptChanges()
            showMessages("Saved..")
            hasil = (True)
            STATE = "EDIT"
        Catch ex As Exception
            showMessages(ex.Message, 12)
            hasil = False
        End Try
        myBuilder.Dispose()
        Return hasil
    End Function
    Private Sub clearField()

        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from muser", sqlconn))
        DA.Fill(dSO, "SP_LOOKUP")

        sp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from muser where 1=0", sqlconn))
        sp.Fill(dSO, "SPM")

        spd = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from MUSER_ROLE where 1=0", sqlconn))
        spd.Fill(dSO, "SPD")

        txtUser.Properties.DataSource = dSO.Tables("SP_LOOKUP")
        txtUser.Properties.DisplayMember = "userid"
        txtUser.Properties.ValueMember = "userid"
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from getUserRole('')", sqlconn))
        DA.Fill(dSO, "SP")

        Gridc.DataSource = dSO.Tables("SP")
        Gridc.Refresh()
        GView.Columns("idrole").Visible = False
        GView.Columns("cek").Caption = "Pilih"
        GView.Columns("iduser").Visible = False
        GView.Columns("bagian").Visible = False
        GView.Columns("nama").Width = Gridc.Width - 100
        GView.Columns("nama").Caption = "Nama Role"

    End Sub

    Private Sub txtUser_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)

        sp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from getUserRole('" & e.Value & "')", sqlconn))
        dSO.Tables("SP").Clear()
        sp.Fill(dSO, "SP")
        Gridc.RefreshDataSource()
        Gridc.Refresh()
        dSO.Tables("SPD").Clear()
        spd = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from MUSER_ROLE where iduser='" & e.Value & "'", sqlconn))
        spd.Fill(dSO, "SPD")
    End Sub

    Private Sub txtUser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtNama.Text = dSO.Tables("SP_LOOKUP").Rows(txtUser.ItemIndex()).Item("nama")
        sp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from muser where userid='" & txtUser.Text & "'", sqlconn))
        sp.Fill(dSO, "SPM")
    End Sub

    Private Sub frmUser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub
End Class