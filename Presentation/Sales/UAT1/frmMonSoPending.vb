Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonSoPending
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = False
        End With
    End Sub

    Private Sub frmMonSoPending_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DA = New SqlDataAdapter("select Kd_Customer,[Nama_Customer], sum([VALTRANS]) as [VALTRANS], isnull( sales.dbo.getCreditLimit([Kd_Customer], 'IDR'),0) SISA_CR from [SALES].[dbo].[VSO_REP] where status='PENDING' group by [Nama_Customer], [Kd_Customer]", sqlconn)
        DA.Fill(dsete, "PENDING")
        GC.DataSource = dsete.Tables("PENDING")
        DA = New SqlDataAdapter("select Kd_Customer,No_sp, Tgl_sp, [VALTRANS] from [SALES].[dbo].[VSO_REP] where status='PENDING'", sqlconn)
        DA.Fill(dsete, "PENDING_DETAIL")
        Dim rl As DataRelation
        rl = dsete.Relations.Add("Detail", dsete.Tables("PENDING").Columns("Kd_Customer"), dsete.Tables("PENDING_DETAIL").Columns("Kd_Customer"), False)
        GC.LevelTree.Nodes.Add("Detail", GVD)
        ' setStatus()
        ' prn = frmMain
    End Sub

End Class