Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmEXPEDISI
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
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
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Private Sub reloadTable(ByVal kode As String)
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_Expedisi where no_expedisi='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_EXPEDISI")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as seq, ex.*, (select Almt_pnrm from sales.dbo.sales_so where no_sp = ex.no_sp) as Alamat from SALES.dbo.SALES_Expedisi_D as ex where no_expedisi='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_EXPEDISI_D")
        gc.DataSource = dsete.Tables("SALES_EXPEDISI_D")
    End Sub
    Private Sub loadBarang()
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select a.* , b.Kd_Customer, b.Almt_pnrm from SALES.dbo.SALES_DPB_D as a, sales.dbo.sales_so as b " & _
                                                          " where a.no_sp=b.no_sp and no_dpb='" & txtNomorRef.EditValue & "'", sqlconn).ExecuteReader
        dsete.Tables("SALES_EXPEDISI_D").Clear()
        Dim i As Int16 = 1
        While dr.Read
            Dim rw As DataRow = dsete.Tables("SALES_EXPEDISI_D").NewRow
            rw("No_sp") = dr("No_sp")
            rw("seq") = i
            i += 1
            rw("Kd_stok") = dr("Kd_stok")
            rw("Kd_satuan") = dr("Kd_satuan")
            rw("Alamat") = dr("Almt_pnrm")
            dsete.Tables("SALES_EXPEDISI_D").Rows.Add(rw)
        End While
        dr.Close()
        dr = Nothing
    End Sub
    Private Sub frmDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_DPB", sqlconn))
        dadbe.Fill(dsete, "DPB")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "Barang")
        repBarang.DataSource = dsete.Tables("Barang")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Sopir, Nama_Sopir from SIF.dbo.SIF_Sopir", sqlconn))
        dadbe.Fill(dsete, "SIF_Sopir")
        cmdSopir.Properties.DataSource = dsete.Tables("SIF_Sopir")
        cmdkernet.Properties.DataSource = dsete.Tables("SIF_Sopir")

        tglSj.EditValue = Now
        txtNomorRef.Properties.DataSource = dsete.Tables("DPB")
        reloadTable("xxx")
    End Sub
    Private Sub txtNomorRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomorRef.EditValueChanged
        loadBarang()
    End Sub
End Class