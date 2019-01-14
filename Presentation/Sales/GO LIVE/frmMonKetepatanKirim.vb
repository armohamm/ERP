Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonKetepatanKirim
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
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = False
            .btnCetak.Enabled = True
        End With
    End Sub
    Public Sub add_click()
        setStatus()
    End Sub

    Private Sub frmMonKetepatanKirim_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer union select '', '','' ", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        repCustomer.DataSource = dsete.Tables("CUSTOMER")

        Dim m(3) As DataRow
        With dsete.Tables.Add("DIVISI")
            .Columns.Add("Kode_Divisi")
            .Columns.Add("Nama_Divisi")
            m(0) = .NewRow
            m(0).Item(0) = "2"
            m(0).Item(1) = "Divisi Spring"

            m(1) = .NewRow
            m(1).Item(0) = "3"
            m(1).Item(1) = "Divisi Spon"

            m(2) = .NewRow
            m(2).Item(0) = "%%"
            m(2).Item(1) = "ALL"
            .Rows.Add(m(0))
            .Rows.Add(m(1))
            .Rows.Add(m(2))
        End With


        cmbDivisi.Properties.DataSource = dsete.Tables("DIVISI")

        cmbDivisi.EditValue = kddep
        If cmbDivisi.Text = "" Then cmbDivisi.EditValue = "%%"
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click
        Dim sql As String

        If txtCustomer.Text <> "" Then
            sql = " and Kd_Customer='" & txtCustomer.EditValue & "'"
        End If

        If tglDari.Text = "" Then
            If tglSampai.Text <> "" Then
                sql = sql + " and convert(varchar,tgl_sp,112) <= " & Format(tglSampai.EditValue, "yyyyMMdd")
            End If
        Else
            If tglSampai.Text <> "" Then
                sql = sql + " and convert(varchar,tgl_sp,112)  between '" & Format(tglDari.EditValue, "yyyyMMdd") & "' and '" & Format(tglSampai.EditValue, "yyyyMMdd") & "' "
            Else
                sql = sql + " and convert(varchar,tgl_sp,112)  >= " & Format(tglDari.EditValue, "yyyyMMdd")
            End If
        End If
        If cmbDivisi.Text <> "" Then
            sql = sql + " and departement like '" & cmbDivisi.EditValue & "'"
        End If
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [SALES].[dbo].V_Ketepatan_pengiriman where tipe_trans in ('" & SpringUmum & "', '" & SponUmum & "') " & sql & " order by [No_sp] ,[No_seq]", sqlconn))
        DA.Fill(dsete, "SOD")

        GC.DataSource = dsete.Tables("SOD")
    End Sub
End Class