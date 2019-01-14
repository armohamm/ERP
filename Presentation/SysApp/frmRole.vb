Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Public Class frmRole
    Public STATE As String
    Dim dRO As New DataSet
    Dim row_update As DataRow
    Dim row As DataRow
    Dim DA As SqlClient.SqlDataAdapter
    Dim DA2 As SqlClient.SqlDataAdapter
    Dim DA3 As SqlClient.SqlDataAdapter
    Dim prn As frmMain
    Dim obj As Object
    Dim hinfo As DevExpress.XtraTreeList.TreeListHitInfo
    Public saveState As Boolean
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private Sub frmRole_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        redrawImg()
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
    Private Sub frmRole_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        query(dRO, DA, "select * from sif.dbo.mROLE where 1=0", "MROLE")
        txtNomor.DataBindings.Add("EditValue", dRO.Tables("MROLE"), "IDROLE")
        txtName.DataBindings.Add("EditValue", dRO.Tables("MROLE"), "NAMA")
        query(dRO, DA2, "select ROLE_MENU.*, 0 as VALUE from sif.dbo.ROLE_MENU where 1=0", "ROLE_MENU")
        TreeMenu.DataMember = "vROLE_MENU"
        TreeMenu.ParentFieldName = "parent_menu"
        TreeMenu.KeyFieldName = "nm_menu"
        TreeMenu.RootValue = "*"
        Me.BackgroundImage = Parent.BackgroundImage
        obj = Me.Parent
        While Not TypeOf obj Is Form
            obj = obj.Parent
        End While
        prn = obj
    End Sub
    Private Sub query(ByRef dros As DataSet, ByRef das As SqlClient.SqlDataAdapter, ByVal sql As String, ByVal tbl As String)
        If Not dros.Tables(tbl) Is Nothing Then dros.Tables(tbl).Clear()
        das = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, sqlconn))
        das.Fill(dRO, tbl)
    End Sub
    Public Sub add_click()
        query(dRO, DA, "select * from mROLE where 1=0", "MROLE")
        query(dRO, DA2, "select ROLE_MENU.*, 0 as VALUE from sif.dbo.ROLE_MENU where 1=0", "ROLE_MENU")
        query(dRO, DA3, "select caption, nm_menu, parent_menu, 0 as VALUE from sif.dbo.Menu", "vROLE_MENU")
        row = dRO.Tables("MROLE").NewRow()
        loadTree()
        STATE = "ADD"
        setStatus()
        default_add(prn)
    End Sub

    Private Sub loadTree()
        TreeMenu.DataMember = "vROLE_MENU"
        TreeMenu.DataSource = dRO
        TreeMenu.ParentFieldName = "parent_menu"
        TreeMenu.KeyFieldName = "nm_menu"
        TreeMenu.RootValue = "*"
        redrawImg()
        saveState = False
        ' TreeMenu.Columns("VALUE").Visible = False
    End Sub
    Private Sub redrawImg()
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        TreeMenu.ExpandAll()
        node = TreeMenu.Nodes.FirstNode
        'TreeMenu.BeginUpdate()
        While Not node Is Nothing
            If node.Item("VALUE").ToString = "" Then
                node.StateImageIndex = 0
            Else
                node.StateImageIndex = node.Item("VALUE").ToString
            End If
            node = node.NextVisibleNode
        End While
        'TreeMenu.EndUpdate()
    End Sub
    Private Sub redrawImg(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
        node.StateImageIndex = node.Item("VALUE").ToString
        node = node.FirstNode
        While Not node Is Nothing
            node.StateImageIndex = node.Item("VALUE").ToString
            node = node.NextNode
        End While
    End Sub
    Public Function save_click() As Boolean
        Dim myBuilder As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(DA)
        Dim myBuilder2 As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(DA2)
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
        Try
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA2.UpdateCommand = myBuilder2.GetUpdateCommand()
            If STATE = "ADD" Then
                row("IDROLE") = txtNomor.Text
                row("NAMA") = txtName.Text
                dRO.Tables("MROLE").Rows.Add(row)
            Else
                row_update("NAMA") = txtName.Text
                DA.Update(dRO.Tables("MROLE"))
                row_update.AcceptChanges()
                dRO.Tables("MROLE").AcceptChanges()
            End If

            TreeMenu.ExpandAll()
            For Each dr As DataRow In dRO.Tables("ROLE_MENU").Rows
                dr.Delete()
            Next
            node = TreeMenu.Nodes.FirstNode
            While Not node Is Nothing
                row = dRO.Tables("ROLE_MENU").NewRow()
                row("idrole") = txtNomor.Text
                row("kode_menu") = node.GetValue("nm_menu")
                row("value") = node.StateImageIndex
                dRO.Tables("ROLE_MENU").Rows.Add(row)
                node = node.NextVisibleNode
            End While

            DA.Update(dRO.Tables("MROLE"))
            DA2.Update(dRO.Tables("ROLE_MENU"))
            dRO.Tables("MROLE").AcceptChanges()
            dRO.Tables("ROLE_MENU").AcceptChanges()
            saveState = True
            MsgBox("Saved")
            STATE = "EDIT"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Occured")
            saveState = False
        Finally
            myBuilder.Dispose()
            myBuilder2.Dispose()
        End Try
        Return saveState
    End Function

    Private Sub TreeMenu_AfterCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles TreeMenu.AfterCheckNode
        SetCheckedChildNodes(e.Node, e.Node.CheckState)
        SetCheckedParentNodes(e.Node, e.Node.CheckState)
        SetValueChildNodes(e.Node, e.Node.CheckState)
    End Sub

    Private Sub SetCheckedChildNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As CheckState)
        For i As Int16 = 0 To node.Nodes.Count - 1
            Dim m As Object = node.Nodes(i)
            m.CheckState = check
            SetCheckedChildNodes(m, check)
        Next
    End Sub
    Private Sub SetValueChildNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As CheckState)
        For i As Int16 = 0 To node.Nodes.Count - 1
            Dim m As Object = node.Nodes(i)
            m.setvalue("VALUE", IIf(check = CheckState.Checked, 2, 0))
            SetValueChildNodes(m, check)
        Next
    End Sub

    Private Sub SetCheckedParentNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As CheckState)
        If Not node.ParentNode Is Nothing Then
            Dim b As Boolean = False
            Dim state As CheckState
            For i As Int16 = 0 To node.ParentNode.Nodes.Count - 1
                state = node.ParentNode.Nodes(i).CheckState
                If Not check.Equals(state) Then
                    b = Not b
                    Exit For
                End If
            Next
            node.ParentNode.CheckState = IIf(b, CheckState.Indeterminate, check)
            node.ParentNode.Item("VALUE") = IIf(b, 1, IIf(check = CheckState.Checked, 2, 0))
            SetCheckedParentNodes(node.ParentNode, check)
        End If
        
    End Sub

    Private Sub TreeMenu_BeforeCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CheckNodeEventArgs) Handles TreeMenu.BeforeCheckNode
        Dim x As Integer = TreeMenu.SetFocusedNode(e.Node)

        e.State = IIf(e.PrevState = CheckState.Checked, CheckState.Unchecked, CheckState.Checked)
        e.Node.Item("VALUE") = IIf(e.State = CheckState.Unchecked, 0, 2)
    End Sub

    Private Sub txtNomor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNomor.ButtonClick
        Dim dipilih As String
        If STATE = "EDIT" Then
            query(dRO, DA, "select * from mROLE", "VROLE")
            frmCari.set_dso(dRO.Tables("VROLE"))
            frmCari.ShowDialog()
            dipilih = frmCari.dipilih
            If dipilih <> "" Then
                query(dRO, DA, "select * from mROLE where IDROLE='" & dipilih & "'", "MROLE")
                query(dRO, DA3, "select caption, nm_menu, parent_menu,  VALUE from getmenus('" & dipilih & "') ", "vROLE_MENU")
                query(dRO, DA3, "select ROLE_MENU.*, 0 as VALUE from ROLE_MENU where IDROLE='" & dipilih & "'", "ROLE_MENU")
                row_update = dRO.Tables("MROLE").Rows(0)
                loadTree()
                prn.btnDelete.Enabled = True
                prn.btnCancel.Enabled = True
                prn.btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub frmRole_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Height = Me.Height
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub
    Public Sub delete_click()
        Dim sqlc As New SqlClient.SqlCommand
        If MsgBox("Hapus Role " & txtName.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus") = MsgBoxResult.Yes Then
            Try
                sqlc.CommandText = "Delete from mrole where idrole='" & txtNomor.Text & "'"
                sqlc.Connection = sqlconn
                sqlc.ExecuteNonQuery()
                cancel_click()
            Catch ex As Exception
                MsgBox("Error Delete " & ex.Message)
            End Try
        End If
    End Sub
    Public Sub edit_click()
        STATE = "EDIT"
        setStatus()
        default_add(prn)

    End Sub
    Public Sub cancel_click()

        TreeMenu.DataSource = Nothing
        TreeMenu.Refresh()
        default_cancel(prn)
        setStatus()
        txtNomor.Text = ""
        txtName.Text = ""
        txtBagian.Text = ""
        Me.Enabled = False
        STATE = ""
    End Sub
End Class