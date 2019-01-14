Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmLapJanjiKirim
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
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

    Private Sub frmLapJanjiKirim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reloadTable("xxx")
        gc.DataSource = dsete.Tables("sp")
        Dim rl As DataRelation
        rl = dsete.Relations.Add("detail", dsete.Tables("sp").Columns("No_sp"), dsete.Tables("spd").Columns("No_sp"), False)
        gc.LevelTree.Nodes.Add("detail", GVD)
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer from SIF.dbo.SIF_Customer where Kd_Customer <> 'INTERNAL'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [tipe_trans],[tipe_desc] from [SIF].[dbo].[SIF_TIPE_TRANS]", sqlconn))
        dadbe.Fill(dsete, "tipe_trans")
        repTipeTrans.DataSource = dsete.Tables("tipe_trans")
        Dim rw As DataRow = dsete.Tables("CUSTOMER").NewRow()
        rw(0) = "ALL"
        rw(1) = "%%"
        dsete.Tables("CUSTOMER").Rows.InsertAt(rw, 0)
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()

    End Sub

    Sub reloadTable(ByVal kdcust As String)
        Dim sql As String

        sql = "select * from sales.dbo.vSO_REP where kd_customer like '" & kdcust & "' and kd_customer <> 'INTERNAL' and isnull(isClosed,'') <> 'Y'"
        If tglDari.Text <> "" Then
            sql = sql & " and substring(CONVERT (varchar, tgl_sp,112 ),1,6) = " & tglDari.Text
        End If
        If Not dsete.Tables("sp") Is Nothing Then dsete.Tables("sp").Clear()
        If Not dsete.Tables("spd") Is Nothing Then dsete.Tables("spd").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, sqlconn))
        dadbe.Fill(dsete, "sp")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sales.dbo.vSOD_REP where isnull([set],'0')='0'", sqlconn))
        dadbe.Fill(dsete, "spd")
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click
        reloadTable(txtCustomer.EditValue)
    End Sub
    Public Sub cetak_click()
        gc.Print()
    End Sub
    Public Sub add_click()

    End Sub
End Class