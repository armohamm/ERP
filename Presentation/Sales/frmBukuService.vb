Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmBukuService
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public init As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String)
        Dim sql As String
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        If txtCustomer.Text <> "" Then
            sql = " and Kd_Customer='" & txtCustomer.EditValue & "'"
        End If
        If tglDari.Text = "" Then
            If tglSampai.Text <> "" Then
                sql = " and convert(varchar,tgl_sp,112) < " & tglSampai.Text
            End If
        Else

            If tglSampai.Text <> "" Then
                sql = " and convert(varchar,tgl_sp,112)  between '" & tglDari.Text & "' and '" & tglSampai.Text & "' "
            Else
                sql = " and convert(varchar,tgl_sp,112)  > " & tglDari.Text
            End If
        End If

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.vBuku where '1' = '" & kode & "' and tipe_trans in ('" & gettipeTrans("JPJ", "UMUM", "SERVICE") & "', '" & gettipeTrans("JPJ", "INTERNAL", "SERVICE") & "') and Departement='" & kddep & "' and isnull(isClosed,'') = '' " & sql, sqlconn))
        DA.Fill(dsete, "SOB")
        
    End Sub

    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reload_table("SPON")
        GC.DataSource = dsete.Tables("SOB")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer ", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        prn = frmMain
        If Not TypeOf Me.Parent Is Form Then
            btnBuku.Enabled = False
            prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        End If
    End Sub

    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        Me.Close()
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click
        reload_table("1")
        lblFound.Text = "Item Found(s) : " & GVSpon.RowCount
    End Sub
    Public Sub cetak()
        Try
            GVSpon.OptionsPrint.Reset()
            GVSpon.GridControl.ShowPrintPreview()
        Catch ex As Exception
            MsgBox("Error Printing : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
        End Try
    End Sub
    Public Sub add_click()

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtCustomer.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglSampai.EditValue = vbNullString
    End Sub
End Class