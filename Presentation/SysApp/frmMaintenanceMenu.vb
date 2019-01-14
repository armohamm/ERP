Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMaintenanceMenu
    Public state As String
    Dim repImg As New RepositoryItemImageComboBox
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        TREE.DataSource = dsete
        TREE.DataMember = "menu"
        TREE.ParentFieldName = "parent_menu"
        TREE.KeyFieldName = "nm_menu"
        TREE.RootValue = 0
        TREE.Columns(0).Caption = "Caption Menu"
        TREE.Columns(0).Width = 335
        TREE.Columns(1).Caption = "Nama Form"
        TREE.Columns(1).Width = 180
        TREE.Columns(2).Caption = "No Urutan"
        TREE.Columns(3).Caption = "Icon"
        TREE.Columns(3).ColumnEditName = "imgs"
        TREE.ExpandAll()
        refreshTree()
    End Sub

    Private Sub refreshTree()
        Dim item As DevExpress.XtraTreeList.Nodes.TreeListNode
        item = TREE.Nodes.FirstNode
        While Not item Is Nothing
            If item.HasChildren Then
                item.StateImageIndex = If(item.Expanded, 1, 2)

            Else
                item.StateImageIndex = 2

            End If
            item = item.NextVisibleNode
        End While
    End Sub
    Private Sub rep_img_changed(ByVal sender As Object, ByVal e As EventArgs)
        TREE.Update()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If state <> "ADD" Then Exit Sub
        If Not TREE.FocusedNode Is Nothing Then
            If TREE.FocusedNode.GetValue("call_form") & "" <> "" Then
                MsgBox("Pilihlah Menu yang kosong", MsgBoxStyle.Information, "Tambah Menu")
                Exit Sub
            End If
            node = TREE.AppendNode("", TREE.FocusedNode)
            TREE.FocusedNode.ExpandAll()
        Else
            node = TREE.AppendNode("", vbNull)
        End If

        node.Selected = True
        TREE.SetNodeIndex(node, 0)
        TREE.Focus()
        TREE.SetFocusedNode(node)
        prn.btnSave.Enabled = True
        cmdAddParent.Enabled = False
        cmdAdd.Enabled = False

    End Sub

    Public Function save_click() As Boolean
        Dim dv As DataView
        dv = New DataView(dsete.Tables("menu"), "isnull(caption,'') =  ''", "", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then
            MsgBox("Ada Beberapa Menu Dengan Caption Masih Kosong" & vbCrLf & dv.Item(0).Item("nm_menu"), MsgBoxStyle.Information, "Warning")
            Exit Function
        End If
        Dim savestate As Boolean
        Dim myBuilder As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(dadbe)
        Try
            dadbe.UpdateCommand = myBuilder.GetUpdateCommand()
            dadbe.Update(dsete.Tables("menu"))
            dsete.Tables("menu").AcceptChanges()
            savestate = True
            showMessages("Data Telah Tersimpan")
            state = "EDIT"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Occured")
            savestate = False
        Finally
            myBuilder.Dispose()
        End Try
        Return savestate
        'cancel_click()
    End Function
    Public Sub edit_click()
        btnLoad_Click(btnLoad, New EventArgs)
        default_add(prn)
        state = "EDIT"
        cmdAddParent.Enabled = False
        cmdAdd.Enabled = False
        cmdCancel.Enabled = False
        cmdDelete.Enabled = True
        setStatus()
    End Sub
    Public Sub add_click()
        state = "ADD"
        default_add(prn)
        btnLoad_Click(btnLoad, New EventArgs)
        cmdAddParent.Enabled = True
        cmdAdd.Enabled = True
        cmdDelete.Enabled = False
        setStatus()
    End Sub
    Public Sub cancel_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select menu.* from menu order by urutan", sqlconn))
        dsete = New DataSet
        dadbe.Fill(dsete, "menu")
        TREE.DataSource = Nothing
        TREE.Refresh()
        default_cancel(prn)
        state = ""
        Me.Enabled = False
    End Sub

    Private Sub TREE_AfterCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles TREE.AfterCollapse
        e.Node.StateImageIndex = 2
    End Sub

    Private Sub TREE_AfterExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles TREE.AfterExpand
        e.Node.StateImageIndex = 1
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If node Is Nothing Then Exit Sub
        node.Selected = True
        TREE.SetNodeIndex(node, 0)
        TREE.Focus()
        TREE.SetFocusedNode(node)
        TREE.DeleteNode(TREE.FocusedNode)
        node = Nothing

        cmdAddParent.Enabled = True
        cmdAdd.Enabled = True
        cmdDelete.Enabled = True
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If state = "ADD" And node Is Nothing Then
            showMessages("Harap Mengisi Node Terlebih Dahulu", 14)
            Exit Sub
        End If
        TREE.Focus()
        TREE.SetFocusedNode(node)
        TREE.BeginUpdate()
        node.Selected = True
        TREE.EndUpdate()
    End Sub
    Private Sub frmMaintenanceMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        Dim imgitem As ImageComboBoxItem
        Dim i As Int16
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select caption ,parent_menu ,call_form ,urutan ,img, nm_menu from sif.dbo.menu order by urutan", sqlconn))
        dadbe.Fill(dsete, "menu")

        repImg.SmallImages = umum.imgCol
        repImg.TextEditStyle = TextEditStyles.Standard
        repImg.UnLockEvents()
        repImg.ReadOnly = False

        For i = 0 To imgCol.Images.Count - 1
            Dim obj As String
            obj = i
            imgitem = New ImageComboBoxItem
            imgitem.Value = obj
            imgitem.ImageIndex = i
            imgitem.Description = imgCol.Images.Keys(i)
            repImg.Items.Add(imgitem)
        Next
        AddHandler repImg.SelectedIndexChanged, New EventHandler(AddressOf rep_img_changed)
        repImg.ShowDropDown = ShowDropDown.SingleClick
        repImg.Name = "imgs"

        TREE.RepositoryItems.Add(repImg)

        Me.BackgroundImage = Parent.BackgroundImage
        obj = Me.Parent
        While Not TypeOf obj Is Form
            obj = obj.Parent
        End While
        prn = obj
    End Sub

    Private Sub frmMaintenanceMenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 0
        pnl.Height = Me.Height
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub

    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If state = "EDIT" Then
            If TREE.FocusedNode Is Nothing Then Exit Sub
            If MsgBox("Hapus Menu " & TREE.FocusedNode.GetValue("caption") & IIf(TREE.FocusedNode.HasChildren, " Beserta Turunannya ?", " ?"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            TREE.Nodes.Remove(TREE.FocusedNode)
        End If
    End Sub

    Private Sub cmdAddParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddParent.Click
        If state <> "ADD" Then Exit Sub

        TREE.CollapseAll()
        Me.Focus()
        node = TREE.AppendNode(vbNull, vbNull)
        node.SetValue("parent_menu", "0")
        refreshTree()

        node.Selected = True
        TREE.SetNodeIndex(node, 0)
        TREE.Focus()
        TREE.SetFocusedNode(node)
        cmdAddParent.Enabled = False
        cmdAdd.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpandAll.Click
        TREE.ExpandAll()
        refreshTree()
    End Sub

    Private Sub cmdCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCollapseAll.Click
        TREE.CollapseAll()
    End Sub
    Private Sub frmMaintenanceMenu_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        refreshTree()
    End Sub
End Class