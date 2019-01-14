Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmNotif
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim myBuilder As New SqlCommandBuilder

    Private Sub frmNotif_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        refreshgrid("20")
        GC.DataSource = dsete.Tables("notif")
        recDepo.DataSource = dsete.Tables("depo")
    End Sub
    Sub refreshgrid(ByVal JmlRecord As String)
        If Not dsete.Tables("notif") Is Nothing Then dsete.Tables("notif").Clear()
        If Not dsete.Tables("depo") Is Nothing Then dsete.Tables("depo").Clear()
        'DA = New SqlDataAdapter("select kd_cabang, nama from sif.dbo.sif_cabang", sqlconn)
        'DA.Fill(dsete, "depo")

        'DA = New SqlDataAdapter("select top " + JmlRecord + " * from sif.dbo.sif_notif where UserTujuan = '" + username + "' order by sts, Tgl", sqlconn)
        'DA.Fill(dsete, "notif")

    End Sub
End Class