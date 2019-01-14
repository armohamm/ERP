Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMst
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
    Private Sub frmRetur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='JNSRTR'  and [Id_Ref_Data] = 'JNSRTR' ", sqlconn))
        dadbe.Fill(dsete, "JNSRTR")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='ALSNRTR'  and [Id_Ref_Data] = 'ALSNRTR' ", sqlconn))
        dadbe.Fill(dsete, "ALSNRTR")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as NO from Sales.dbo.SALES_RETUR_D where 1=0", sqlconn))
        DAD.Fill(dsete, "SALES_RETUR_D")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR where 1=0", sqlconn))
        DA.Fill(dsete, "SALES_RETUR")

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kode_Customer"

        repBarang.DataSource = dsete.Tables("VBARANG")
        repJNSRTR.DataSource = dsete.Tables("JNSRTR")
        repALSNRTR.DataSource = dsete.Tables("ALSNRTR")
        GC.DataSource = dsete.Tables("SALES_RETUR_D")
        State = "ADD"
        tglRetur.Text = Now
    End Sub

    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("kd_satuan")
        End If
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
    End Sub
End Class