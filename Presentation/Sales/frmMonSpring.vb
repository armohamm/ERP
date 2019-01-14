Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonSpring
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmMtrSpring_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.vso_rep", sqlconn))
        dadbe.Fill(dsete, "so")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.vsod_rep", sqlconn))
        dadbe.Fill(dsete, "sod")
        GC.DataSource = dsete.Tables("so")

        Dim rl As DataRelation
        Dim dcolP(0) As DataColumn
        Dim dcolC(0) As DataColumn


        dcolP(0) = dsete.Tables("so").Columns("No_sp")
        dcolC(0) = dsete.Tables("sod").Columns("No_sp")
        rl = dsete.Relations.Add("Detail", dcolP, dcolC, False)
        rl.Nested = True
        GC.LevelTree.Nodes.Add("Detail", GVD)
        prn = frmMain
        setStatus()

        frmMain.btnAdd_Click(frmMain.btnAdd, New EventArgs)
    End Sub
    Public Sub add_click()

    End Sub
End Class