'-------------------'
'CREATED BY DIAZ    '
'EDITED BY RENDY    '
'Kentang            '
'-------------------'
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmzMonProdBOM1
    Dim dsete, dsetLUE, dsLoadBOM, dsRek As New DataSet
    Dim dadbe, daLUE, daLoadBOM, daRek As SqlDataAdapter
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
        eksekusi()
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
        dsete = New DataSet
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT bom_code,bom_name,assembly_code,assembly_name,component_code,component_name,jumlah,level " & _
        '                                                              "FROM prod.dbo.prodv_bom_prod where bom_code='" & txtNama_Barang.EditValue & "'", sqlconn))


        'SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, 
        'A.component_code, A.component_name, A.jumlah, A.level, 
        'case when A.component_code=A.assembly_code then 0  
        'else X.nilai_rata end as nilai
        'FROM INV.dbo.INV_STOK_SALDO X , prod.dbo.prodv_bom_prod A 
        'where(A.component_code = X.kd_stok)
        'and A.bom_code='2101401002000122003001' 
        'and X.bultah = ( select max(bultah) from INV.dbo.INV_STOK_SALDO)


        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, " & _
        '"A.component_code, A.component_name, A.jumlah, A.level, X.nilai_rata,A.satuan " & _
        '"FROM INV.dbo.INV_STOK_SALDO X " & _
        '",prod.dbo.prodv_bom_prod A " & _
        '"where(A.component_code = X.kd_stok) " & _
        '"and A.bom_code='" & txtNama_Barang.EditValue & "' " & _
        '"and X.bultah = ( select max(bultah) from INV.dbo.INV_STOK_SALDO)", sqlconn))


        'dadbe.Fill(dsete, "master")
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT bom_code,bom_name,assembly_code,assembly_name,component_code,component_name,jumlah,level " & _
        '                                                              "FROM prod.dbo.prodv_bom_prod where bom_code='" & txtNama_Barang.EditValue & "' and 1=0", sqlconn))

        '''' ASLI.....
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, " & _
        '"A.component_code, A.component_name, A.jumlah, A.level, X.nilai_rata,A.satuan " & _
        '"FROM prod.dbo.prodv_bom_prod A left outer join INV.dbo.INV_STOK_SALDO X on (A.component_code = X.kd_stok) " & _
        '"where A.bom_code='" & txtNama_Barang.EditValue & "' " & _
        '"and X.bultah = ( select max(bultah) from INV.dbo.INV_STOK_SALDO where kd_stok = A.component_code)", sqlconn))


        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, " & _
        '                                                              "A.component_code, A.component_name, A.jumlah, A.level, X.nilai_rata,A.satuan , " & _
        '                                                              "SIF.dbo.getHargaBom(A.component_code)*case " & _
        '                                                              "when A.jumlah = 0 then 1 else A.jumlah end nilai_rata1 " & _
        '                                                              "FROM prod.dbo.prodv_bom_prod A left outer join INV.dbo.INV_STOK_SALDO X " & _
        '                                                              "on (A.component_code = X.kd_stok) where A.bom_code='" & txtNama_Barang.EditValue & "' " & _
        '                                                              "and X.bultah = ( select max(bultah) from INV.dbo.INV_STOK_SALDO " & _
        '                                                              "where kd_stok = A.component_code)", sqlconn))
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, " & _
                                                                      "A.component_code, A.component_name, A.jumlah, A.level, ISNULL(X.nilai_rata,0) nilai_rata,A.satuan , " & _
                                                                      "SIF.dbo.getHargaBom_def(A.component_code)*case " & _
                                                                      "when A.jumlah = 0 then 1 else A.jumlah end nilai_rata1 " & _
                                                                      "FROM prod.dbo.prodv_bom_prod A left outer join INV.dbo.INV_HPP_DEFAULT X " & _
                                                                      "on (A.component_code = X.kd_stok) where A.jumlah > 0 and A.bom_code='" & txtNama_Barang.EditValue & "'", sqlconn))
        dadbe.Fill(dsete, "master")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT A.bom_code,A.bom_name,A.assembly_code,A.assembly_name, " & _
        "A.component_code, A.component_name, A.jumlah, A.level, ISNULL(X.nilai_rata,0) nilai_rata,A.satuan  " & _
        "FROM prod.dbo.prodv_bom_prod A left outer join INV.dbo.INV_HPP_DEFAULT X " & _
        "on (A.component_code = X.kd_stok) " & _
        "where A.jumlah > 0 and A.bom_code='" & txtNama_Barang.EditValue & "'", sqlconn))

        dadbe.Fill(dsete, "kosong")

        If dsete.Tables("kosong").Columns.Contains("idparent") = False Then
            dsete.Tables("kosong").Columns.Add("idparent")
        End If
        If dsete.Tables("kosong").Columns.Contains("iditem") = False Then
            dsete.Tables("kosong").Columns.Add("iditem")
        End If

        If Not dsete.Tables("kosong") Is Nothing Then dsete.Tables("kosong").Clear()

        Dim addRow As DataRow = dsete.Tables("kosong").NewRow
        addRow("bom_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("bom_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("assembly_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("assembly_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("component_code") = dsete.Tables("master").Rows(0).Item(0).ToString.Trim("-")
        addRow("component_name") = dsete.Tables("master").Rows(0).Item(1).ToString
        addRow("jumlah") = Format(0, "#,#0")
        addRow("level") = 0
        addRow("idparent") = 0
        addRow("iditem") = 1
        addRow("satuan") = ""

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
            addRow("level") = CInt(dsete.Tables("master").Rows(a).Item(7).ToString) + 1
            addRow("nilai_rata") = dsete.Tables("master").Rows(a).Item(10).ToString
            addRow("satuan") = dsete.Tables("master").Rows(a).Item(9).ToString

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
                    retVal = IIf(TypeOf dsete.Tables("kosong").Rows(i).Item("iditem") Is DBNull, vbNullString, dsete.Tables("kosong").Rows(i).Item("iditem"))
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

    Private Sub frmzMonProdBOM1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        LoadRekening()

        If dsetLUE.Tables("lue_data").Rows.Count > 0 Then
            txtNama_Barang.ItemIndex = 0
        End If
    End Sub

    Sub LoadRekening()
        daRek = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_buku_besar", sqlconn))
        daRek.Fill(dsRek, "rekening")

        RepRek.Properties.DataSource = dsRek.Tables("rekening")
        RepRek.Properties.ValueMember = "kd_buku_besar"
        RepRek.Properties.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub frmzMonProdBOM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        refreshTree()
    End Sub

    Private Sub TREE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREE.Click
        'MsgBox(TREE.FocusedNode(bom_code))
        'Try
        '    Dim kSp As String = ""
        '    'kSp = TREE.FocusedNode(bom_code)
        '    kSp = TREE.FocusedNode.GetValue(bom_code)
        '    'MsgBox(kSp)
        '    LoadBiayaBOM(kSp)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Sub eksekusi()
        'Try
        susunTree()
        refreshTree()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub TREE_InvalidNodeException(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.InvalidNodeExceptionEventArgs) Handles TREE.InvalidNodeException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    'Private Sub txtNama_Barang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNama_Barang.EditValueChanged
    '    eksekusi()
    'End Sub

    Sub LoadBiayaBOM(Optional ByVal kode As String = "")

        If Not dsLoadBOM.Tables("BOM") Is Nothing Then dsLoadBOM.Tables("BOM").Clear()
        daLoadBOM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  select * from SIF.dbo.SIF_bom_biaya where kd_bom = '" & kode & "'", sqlconn))
        daLoadBOM.Fill(dsLoadBOM, "BOM")

        GridControl1.DataSource = dsLoadBOM.Tables("BOM")
        GridView1.BestFitColumns()

    End Sub

End Class