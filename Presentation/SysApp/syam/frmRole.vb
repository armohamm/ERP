Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Public Class frmRole
    Public STATE As String
    Dim dRO As New DataSet
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
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = False
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Private Sub frmRole_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        query(dRO, DA, "select * from KOPKAR.dbo.MROLE where 1=0", "MROLE")
        txtNomor.DataBindings.Add("EditValue", dRO.Tables("MROLE"), "IDROLE")
        txtName.DataBindings.Add("EditValue", dRO.Tables("MROLE"), "NAMA")
        query(dRO, DA2, "select ROLE_MENU.*, 0 as VALUE from KOPKAR.dbo.ROLE_MENU where 1=0", "ROLE_MENU")
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
        pnl.Height = Me.Parent.Height - 15
    End Sub
    Private Sub query(ByRef dros As DataSet, ByRef das As SqlClient.SqlDataAdapter, ByVal sql As String, ByVal tbl As String)
        If Not dros.Tables(tbl) Is Nothing Then dros.Tables(tbl).Clear()
        das = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, sqlconn))
        das.Fill(dRO, tbl)
    End Sub
    Public Sub add_click()
        query(dRO, DA, "select * from mROLE where 1=0", "MROLE")
        query(dRO, DA2, "select ROLE_MENU.*, 0 as VALUE from KOPKAR.dbo.ROLE_MENU where 1=0", "ROLE_MENU")
        query(dRO, DA3, "select caption, nm_menu, parent_menu, 0 as VALUE from KOPKAR.dbo.menu order by urutan", "vROLE_MENU")

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
            node.CheckState = IIf(node.Item("VALUE").ToString = "1", CheckState.Indeterminate, IIf(node.Item("VALUE").ToString = "2", CheckState.Checked, CheckState.Unchecked))
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
    Public Function save_click(Optional ByVal isDelete As Boolean = False) As Boolean
        Dim btrans As SqlClient.SqlTransaction
        If isDelete Then

            delete(dRO.Tables("MROLE"))
            delete(dRO.Tables("ROLE_MENU"))
        Else

            If STATE = "ADD" Then
                row = dRO.Tables("MROLE").NewRow()
                row("IDROLE") = txtNomor.Text
                row("NAMA") = txtName.Text
                dRO.Tables("MROLE").Rows.Add(row)
            Else
                row = dRO.Tables("MROLE").Rows(0)
                row("NAMA") = txtName.Text
            End If

            pw.Visible = True
            pw.Refresh()
            For Each dr As DataRow In dRO.Tables("ROLE_MENU").Rows
                dr.Delete()
                pw.Refresh()
            Next
            For Each rw As DataRow In dRO.Tables("vROLE_MENU").Rows
                row = dRO.Tables("ROLE_MENU").NewRow()
                row("idrole") = txtNomor.Text
                row("kode_menu") = rw("nm_menu")
                row("value") = rw("VALUE") 'node.StateImageIndex
                dRO.Tables("ROLE_MENU").Rows.Add(row)
                pw.Refresh()
            Next

        End If
        Dim myBuilder As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DA2)
        DA2.UpdateCommand = myBuilder.GetUpdateCommand()
        DA2.InsertCommand = myBuilder.GetInsertCommand()
        DA2.DeleteCommand = myBuilder.GetDeleteCommand()
        Try
            btrans = sqlconn.BeginTransaction("1")
            
            DA.UpdateCommand.Transaction = btrans
            DA.InsertCommand.Transaction = btrans
            DA.DeleteCommand.Transaction = btrans

            DA2.UpdateCommand.Transaction = btrans
            DA2.InsertCommand.Transaction = btrans
            DA2.DeleteCommand.Transaction = btrans

            DA.Update(dRO.Tables("MROLE"))
            DA2.Update(dRO.Tables("ROLE_MENU"))
            saveState = True
            pw.Visible = False

            btrans.Commit()
            If isDelete Then
                default_cancel(prn)
                STATE = ""
            Else
                showMessages("Data Telah Tersimpan")
                STATE = "EDIT"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Diproses")
            saveState = False
            btrans.Rollback()
            pw.Visible = False
        End Try
        Return saveState
    End Function

    Private Sub TreeMenu_AfterCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles TreeMenu.AfterCheckNode
        SetCheckedChildNodes(e.Node, e.Node.CheckState)
        SetCheckedParentNodes(e.Node, e.Node.CheckState)
        SetValueChildNodes(e.Node, e.Node.CheckState)
    End Sub
    Private Sub delete(ByVal tbl As DataTable)
        For Each rw As DataRow In tbl.Rows
            rw.Delete()
        Next
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

    Public Sub delete_click()

        If MsgBox("Hapus Role " & txtName.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus") = MsgBoxResult.Yes Then
            Dim sqlc As SqlClient.SqlDataReader

            sqlc = New SqlClient.SqlCommand("select count(*) from KOPKAR.dbo.MUSER_ROLE where idrole='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            sqlc.Read()
            If sqlc.Item(0) = 0 Then
                save_click(True)
            Else
                MsgBox("Role Tidak Dapat Dihapus, Masih Dipakai user lain", MsgBoxStyle.Information)
            End If
            sqlc.Close()
        End If
    End Sub
    Public Sub edit_click()
        Dim dipilih As String

        STATE = "EDIT"
        setStatus()
        default_add(prn)
        query(dRO, DA, "select * from mROLE", "VROLE")
        frmCari.set_dso(dRO.Tables("VROLE"))
        frmCari.ShowDialog()
        dipilih = frmCari.dipilih
        If dipilih <> "" Then
            query(dRO, DA, "select * from mROLE where IDROLE='" & dipilih & "'", "MROLE")
            query(dRO, DA3, "select caption, nm_menu, parent_menu,  VALUE from getmenus('" & dipilih & "') order by urutan", "vROLE_MENU")
            query(dRO, DA3, "select ROLE_MENU.*, 0 as VALUE from ROLE_MENU where IDROLE='" & dipilih & "'", "ROLE_MENU")
            loadTree()
            prn.btnDelete.Enabled = True
            prn.btnCancel.Enabled = True
            prn.btnSave.Enabled = True
        End If
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



    Private Sub txtNomor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomor.GotFocus
        If STATE = "EDIT" Then
            txtNomor.Properties.ReadOnly = True
        Else
            txtNomor.Properties.ReadOnly = False
        End If
    End Sub
End Class