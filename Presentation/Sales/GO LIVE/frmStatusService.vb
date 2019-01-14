Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmStatusService
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
    Public filter As String
    Const counter As Int16 = 60
    Dim i As Int16
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim dscopy As DataSet
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()

    End Sub
    Sub reload()
        'Timer1.Enabled = False
        btnRefresh.Enabled = False
        GC.DataSource = ""

        dsete.Tables("sp").Clear()
        dadbe = New SqlDataAdapter(New SqlCommand("select * from [SALES].[dbo].[vStatusSP] where isClosed is null and Status='OK' and tipe_trans = '" & ServiceSpringUmum & "'", sqlconn))
        dadbe.Fill(dsete, "sp")
        If dscopy Is Nothing Then dscopy = dsete.Clone
       
        dscopy = dsete.Copy
        If GC.DataSource Is Nothing Then GC.DataSource = dscopy.Tables("sp")

        i = counter
        Timer1.Enabled = True
        btnRefresh.Enabled = True

    End Sub
    Private Sub frmStatusSP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        setStatus()
        dadbe = New SqlDataAdapter(New SqlCommand("select * from [SALES].[dbo].[vStatusSP] where isClosed is null and Status='OK' and tipe_trans = '" & ServiceSpringUmum & "'", sqlconn))
        dadbe.Fill(dsete, "sp")
        GC.DataSource = dsete.Tables("sp")
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnRefresh.Text = counter
        i = counter
        Timer1.Enabled = True
        Nama_Customer.Group()
        No_sp.Group()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 0 Then
            reload()
        End If
        btnRefresh.Text = i

        i -= 1

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'reload()
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Daftar Status SP")
    End Sub

    Private Sub rdFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dsete.Tables("sp").Clear()
        dadbe = New SqlDataAdapter(New SqlCommand("select * from [SALES].[dbo].[vStatusSP] where isClosed is null and Status='OK' and tipe_trans = '" & ServiceSpringUmum & "'", sqlconn))
        dadbe.Fill(dsete, "sp")
        i = 60
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        reload()
    End Sub
End Class