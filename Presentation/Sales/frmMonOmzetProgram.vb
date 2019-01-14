Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonOmzetProgram
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim DAO As SqlDataAdapter
    Dim prn As frmMain
    Dim STATE As String
    Dim rw As DataRow
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmMonOmzetProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_kontrak, Nama_Customer, nama_kontrak from sales.dbo.V_REP_KONTRAK where isnull(isclosed,'')=''", sqlconn))
        DA.Fill(dsete, "kontrak")
        txtkontrak.Properties.DataSource = dsete.Tables("kontrak")
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click
        If Not dsete.Tables("data") Is Nothing Then dsete.Tables("data").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.[dbo].[PencapaianProgramOmzet]('" & txtkontrak.EditValue & "')", sqlconn))
        DA.Fill(dsete, "data")
        GC.DataSource = dsete.Tables("data")
        lblStatus.Text = "Customer Belum Memenuhi Target"

        If dsete.Tables("data").Rows(GV.RowCount - 1)("persen") >= 100 Then
            lblStatus.Text = "Customer Telah Memenuhi Target"
        End If

    End Sub

    Private Sub txtkontrak_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkontrak.EditValueChanged
        If txtkontrak.Text <> "" Then
            txtCustomer.Text = txtkontrak.GetColumnValue("Nama_Customer").ToString
        End If
    End Sub
    Public Sub add_click()

    End Sub
End Class