Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmCustGetPromo
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim rhandle, rhandle2 As Int16
    Private Sub frmCustGetPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from   [SIF].[dbo].[SIF_Promo]", sqlconn))
        dadbe.Fill(dsete, "PROMO")
        GC.DataSource = dsete.Tables("PROMO")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from   [SIF].[dbo].[SIF_Promo_D] where tipe_promo='Y'", sqlconn))
        dadbe.Fill(dsete, "PROMOD")

        Dim rl As DataRelation
        rl = dsete.Relations.Add("PROMO", dsete.Tables("PROMO").Columns("no_promo"), dsete.Tables("PROMOD").Columns("no_promo"), False)
        GC.LevelTree.Nodes.Add("PROMO", GVP)
    End Sub

    Private Sub GVP_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GVP.MasterRowExpanded

        Dim obj As DevExpress.XtraGrid.Views.Grid.GridView = CType(GVP.GetDetailView(rhandle, "Syarat"), DevExpress.XtraGrid.Views.Grid.GridView)

        If obj.Columns.Count > 1 Then Exit Sub
        obj.Columns.Clear()
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from   [SIF].[dbo].[SIF_Promo_D] where tipe_promo='Y'", sqlconn))
        dsete.Tables("PROMOS").Clear()
        dsete.Tables("PROMOS").Columns.Add(dsete.Tables("PROMOD")(rhandle2)("promo_desc"))

        Dim dr As SqlDataReader = New SqlCommand("Select * from sif.dbo.SIF_Promo_Syarat where [no_promo] = '" & dsete.Tables("PROMOD")(rhandle2)("no_promo") & "' and [seq_detail] = '" & dsete.Tables("PROMOD")(rhandle2)("no_seq") & "'").BeginExecuteReader
        While dr.Read
            Dim drow As DataRow = dsete.Tables("PROMOS").NewRow()

        End While
    End Sub

    Private Sub GVP_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GVP.MasterRowGetLevelDefaultView
        rhandle2 = e.RowHandle
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub
End Class