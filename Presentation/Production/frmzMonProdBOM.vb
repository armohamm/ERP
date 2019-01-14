Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraPrinting

Public Class frmzMonProdBOM
    Dim dsete, dsetLUE As New DataSet
    Dim dadbe, daLUE As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim prn As frmMain

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

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
        Try
            susunTree()
            refreshTree()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub refreshTree()
        Dim item As DevExpress.XtraTreeList.Nodes.TreeListNode
        While Not item Is Nothing
            If item.HasChildren Then
                item.StateImageIndex = If(item.Expanded, 1, 2)
            Else
                item.StateImageIndex = 2
            End If
            item = item.NextVisibleNode
        End While

        colID.Visible = True
        colParent.Visible = True
    End Sub

    Private Sub susunTree()
        dsete.Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT bom_code,bom_name,assembly_code,assembly_name,component_code,component_name,jumlah,satuan,level " & _
                                                                      "FROM prod.dbo.prodv_bom_prod where bom_code='" & txtNama_Barang.EditValue & "' OPTION (MAXRECURSION 0)", sqlconn))
        dadbe.Fill(dsete, "master")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT bom_code,bom_name,assembly_code,assembly_name,component_code,component_name,jumlah,satuan,level " & _
                                                                      "FROM prod.dbo.prodv_bom_prod where bom_code='" & txtNama_Barang.EditValue & "' and 1=0 OPTION (MAXRECURSION 0)", sqlconn))
        dadbe.Fill(dsete, "kosong")

        If dsete.Tables("kosong").Columns.Contains("idparent") = False Then
            dsete.Tables("kosong").Columns.Add("idparent")
        End If
        If dsete.Tables("kosong").Columns.Contains("iditem") = False Then
            dsete.Tables("kosong").Columns.Add("iditem")
        End If

        Dim addRow As DataRow = dsete.Tables("kosong").NewRow
        addRow("bom_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("bom_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("assembly_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("assembly_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("component_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("component_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("jumlah") = Format(0, "#,#0")
        addRow("satuan") = dsete.Tables("master").Rows(0).Item(7).ToString
        addRow("level") = 0
        addRow("idparent") = 0
        addRow("iditem") = 1
        dsete.Tables("kosong").Rows.Add(addRow)

        For a As Integer = 0 To dsete.Tables("master").Rows.Count - 1
            addRow = dsete.Tables("kosong").NewRow
            addRow("bom_code") = dsete.Tables("master").Rows(a).Item(0).ToString.Trim("-")
            addRow("bom_name") = dsete.Tables("master").Rows(a).Item(1).ToString
            addRow("assembly_code") = dsete.Tables("master").Rows(a).Item(2).ToString.Trim("-")
            addRow("assembly_name") = dsete.Tables("master").Rows(a).Item(3).ToString
            addRow("component_code") = dsete.Tables("master").Rows(a).Item(4).ToString.Trim("-")
            addRow("component_name") = dsete.Tables("master").Rows(a).Item(5).ToString
            addRow("jumlah") = dsete.Tables("master").Rows(a).Item(6).ToString
            addRow("level") = CInt(dsete.Tables("master").Rows(a).Item(8).ToString) + 1
            addRow("satuan") = dsete.Tables("master").Rows(a).Item(7).ToString
            addRow("idparent") = 0
            addRow("iditem") = a + 2
            dsete.Tables("kosong").Rows.Add(addRow)
        Next
        Dim level As Integer = dsete.Tables("kosong").Rows(0).Item("level")
        'Dim idparent As String = dsete.Tables("kosong").Rows(0).Item("component_code")

        For i As Integer = 1 To dsete.Tables("kosong").Rows.Count - 1
            'For a As Integer = 1 To dsete.Tables("kosong").Rows.Count - 1
            '    If dsete.Tables("kosong").Rows(a).Item("level") = level + 1 And dsete.Tables("kosong").Rows(a).Item("assembly_code") = idparent Then
            '        dsete.Tables("kosong").Rows(a).Item("idparent") = dsete.Tables("kosong").Rows(i).Item("iditem")
            '    End If
            'Next
            level = dsete.Tables("kosong").Rows(i).Item("level")
            dsete.Tables("kosong").Rows(i).Item("idparent") = cariParent(dsete.Tables("kosong").Rows(i).Item("assembly_code"), level)
            'idparent = dsete.Tables("kosong").Rows(i).Item("component_code")
        Next
        dsete.Tables("kosong").Rows(0).Delete()

        TREE.DataSource = dsete.Tables("kosong")
        TREE.ParentFieldName = "idparent"
        TREE.KeyFieldName = "iditem"
        TREE.RootValue = 0
        TREE.ExpandAll()
    End Sub

    Private Function cariParent(ByVal idItem As String, ByVal level As String) As String
        Dim retVal As String = ""
        If level = 0 Then
            retVal = 1
        Else
            For i As Integer = 1 To dsete.Tables("kosong").Rows.Count - 1
                If idItem = dsete.Tables("kosong").Rows(i).Item("component_code") And dsete.Tables("kosong").Rows(i).Item("level") = level - 1 Then
                    retVal = dsete.Tables("kosong").Rows(i).Item("iditem")
                    Exit For
                End If
            Next
        End If
        Return retVal
    End Function

    Private Sub process(ByVal idparent As String, ByVal level As Integer)
        Dim dt As DataTable = dsete.Tables("kosong")
        Dim hSelect = From y In dt.AsEnumerable Where y.Item("assembly_code") = idparent & y.Item("level") = level Select y
        For Each isiNodes In hSelect
            TREE.AppendNode(isiNodes("component_name"), idparent, 0, 0, 0)
            process(isiNodes("assembly_code"), isiNodes("level"))
        Next
    End Sub

    Private Sub frmzMonProdBOM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        daLUE = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.kd_bom as bom_code, b.Nama_Barang as bom_name from prod.dbo.PRODV_BOM_DTL a, sif.dbo.sif_barang b where a.kd_bom = b.Kode_Barang order by b.nama_barang", sqlconn))
        daLUE.Fill(dsetLUE, "lue_data")

        txtNama_Barang.Properties.DataSource = dsetLUE.Tables("lue_data")
        txtNama_Barang.Properties.ValueMember = "bom_code"
        txtNama_Barang.Properties.DisplayMember = "bom_name"

        prn = getParent(Me)
        Me.Enabled = True
        'While Not TypeOf obj Is Form
        '    obj = obj.Parent
        'End While

        If dsetLUE.Tables("lue_data").Rows.Count > 0 Then
            txtNama_Barang.ItemIndex = 0
        End If
    End Sub

    Private Sub frmzMonProdBOM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        refreshTree()
    End Sub
    
    Private Sub TREE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREE.DoubleClick
        Dim component_code, componant_name As String
        Dim dr As SqlDataReader
        'Dim columnID3 As Integer = TREE.Columns("component_code").AbsoluteIndex
        'Dim columnID4 As Integer = TREE.Columns("component_name").AbsoluteIndex
        '' Get a cell's value in the first root node. 

        'Dim cellValue As Object = TREE.Nodes(0).GetValue(columnID3)
        'Dim cellValue1 As Object = TREE.Nodes(0).GetValue(columnID4)
        component_code = TREE.FocusedNode.Item("component_code")
        componant_name = TREE.FocusedNode.Item("component_name")
        dr = New SqlClient.SqlCommand("select M.kd_bom, br.Nama_Barang as nama_bom,M.revisi from SIF.dbo.SIF_bom M " & _
                                                "left join SIF.dbo.SIF_Barang br " & _
                                                "on br.Kode_Barang = M.kd_bom " & _
                                                "where revisi = (select MAX(revisi)  from SIF.dbo.SIF_bom b where b.kd_bom = M.kd_bom) " & _
                                                "and M.kd_bom ='" & component_code & "'  ", sqlconn).ExecuteReader

        dr.Read()
        If dr.HasRows Then
            frmMstBOMProd.load_form = "MonBOM"
            frmMstBOMProd.kd_bom = dr.Item("kd_bom")
            frmMstBOMProd.revisi = dr.Item("revisi")
            frmMstBOMProd.txtBOM.EditValue = component_code
            frmMstBOMProd.ShowDialog()
        End If
        dr.Close()


        
        'MsgBox(component_code & " / " & componant_name, MsgBoxStyle.Information)


    End Sub

    Private Sub TREE_InvalidNodeException(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.InvalidNodeExceptionEventArgs) Handles TREE.InvalidNodeException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtNama_Barang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNama_Barang.EditValueChanged
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 105
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        TREE.OptionsPrint.UsePrintStyles = True
        print_gc1(TREE, "                                                                                   BOM PRODUKSI    " & vbCrLf & _
                 "     " & vbCrLf & _
                 vbCrLf & "Nama Barang   : " & txtNama_Barang.Text)
    End Sub

    Private Sub TREE_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREE.SelectionChanged
        'Dim component_code As String
        'component_code = TREE.Columns.Item("component_code").ToString
        'MsgBox(component_code, MsgBoxStyle.Information)
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim component_code, componant_name As String
        Dim dr As SqlDataReader
        component_code = txtNama_Barang.EditValue
        dr = New SqlClient.SqlCommand("select M.kd_bom, br.Nama_Barang as nama_bom,M.revisi from SIF.dbo.SIF_bom M " & _
                                                "left join SIF.dbo.SIF_Barang br " & _
                                                "on br.Kode_Barang = M.kd_bom " & _
                                                "where revisi = (select MAX(revisi)  from SIF.dbo.SIF_bom b where b.kd_bom = M.kd_bom) " & _
                                                "and M.kd_bom ='" & component_code & "'  ", sqlconn).ExecuteReader

        dr.Read()
        If dr.HasRows Then
            frmMstBOMProd.load_form = "MonBOM"
            frmMstBOMProd.kd_bom = dr.Item("kd_bom")
            frmMstBOMProd.revisi = dr.Item("revisi")
            frmMstBOMProd.txtBOM.EditValue = component_code
            frmMstBOMProd.ShowDialog()
        End If
        dr.Close()
    End Sub
End Class
