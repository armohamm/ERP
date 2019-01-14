Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmProdMonBooked
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsMon, ds1 As New DataSet
    Dim daMon, da1 As SqlDataAdapter

    Private Sub frmProdMonBooked_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        gvMain.BestFitColumns()
        Loadbrg()
    End Sub

    Private Sub Loadbrg()
        ds1.Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_barang ", sqlconn))
        da1.Fill(ds1, "barang")

        txtNama_Barang.Properties.DataSource = ds1.Tables("barang")
        txtNama_Barang.Properties.ValueMember = "Kode_Barang"
        txtNama_Barang.Properties.DisplayMember = "Nama_Barang"

    End Sub

    Public Sub LoadGrid()
        If Not txtNama_Barang.EditValue Is Nothing Then
            Dim strQuery As String = "select * from PROD.dbo.PRODV_MON_BOOKING " & _
                                    "where kd_stok ='" & txtNama_Barang.EditValue & "'"
            dsMon.Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monrcnkrm")
            gc.DataSource = dsMon.Tables("monrcnkrm")
            gvMain.BestFitColumns()
        End If
    End Sub

    Private Sub txtNama_Barang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama_Barang.EditValueChanged
        LoadGrid()
    End Sub
End Class