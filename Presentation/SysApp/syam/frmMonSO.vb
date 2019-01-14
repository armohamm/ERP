Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonSO
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DAS As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Private Sub frmMonSO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select (select Nama_Barang from SIF.dbo.SIF_Barang where Kode_Barang =Kd_Stok ) as Nama, so.No_sp, Kd_Customer, so.Tgl_Kirim, Kd_Stok, Qty, 0 as rph, 0 as dpb from Sales.dbo.SALES_SO_D as sod, Sales.dbo.SALES_SO as so where so.No_sp = sod.No_sp", sqlconn))
        dadbe.Fill(dsete, "SO")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        gc.DataSource = dsete.Tables("SO")
        gv.Columns(0).Group()
    End Sub
End Class