Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonPajak
    Dim DsSales As New DataSet
    Dim obj As Object
    Dim prn As frmMain
    Public state As String
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Dim DAs As SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table()
        If Not DsSales.Tables("ppn") Is Nothing Then DsSales.Tables("ppn").Clear()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select * from sales.dbo.v_sp_ppn", sqlconn))
        DAs.Fill(DsSales, "ppn")
        gc.DataSource = DsSales.Tables("ppn")
    End Sub
    Private Sub frmMonPajak_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        state = "ADD"
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Public Sub add_click()
        State = "ADD"
        reload_table()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        reload_table()

    End Sub
End Class