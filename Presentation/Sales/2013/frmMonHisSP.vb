Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonHisSP

    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DAL As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If Not dsete.Tables("SOLAMA") Is Nothing Then dsete.Tables("SOLAMA").Clear()

        DAL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp, Tgl_SP, SALES.dbo.getCustomerByKode(kd_customer) Nama_Customer, Jml_Rp_Trans, FLAG_PPN, PPn from sales.dbo.sales_SO where isNull(FLAG_PPN,'X') <> 'X' and status='OK' and  Tipe_trans in ('" & SpringUmum & "','" & SponUmum & "') ", sqlconn))
        DAL.Fill(dsete, "SOLAMA")
        GC.DataSource = dsete.Tables("SOLAMA")
        If dsete.Tables("SOLAMA").Rows.Count = 0 Then
            btnSave = True
            btnCancel = False
            btnDelete = False
            btnEdit = False
            btnadd = False
            setStatus()
        End If
        ' dsete.Tables("SOLAMA").Compute("")
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Histori SP", False)
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = False
            .btnCetak.Enabled = True

        End With
    End Sub
    Private Sub frmMonHisSP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain

        frmMain.btnAdd_Click(frmMain.btnAdd, New EventArgs)
        btnSave = True
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        btnRefresh_Click(btnRefresh, New EventArgs)
    End Sub
End Class