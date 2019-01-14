Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonKelPel
    Dim dsete As New DataSet
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = True
        End With
    End Sub

    Public Sub add_click()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Private Sub frmMonKelPel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Sub reload()
        Dim tgl As String
        Dim cust As String
        If cmbCustomer.Text = "UMUM" Then cust = " and kd_customer='UMUM' "
        If cmbCustomer.Text = "TOKO" Then cust = " and kd_customer<>'UMUM' "
        If cmbCustomer.Text = "ALL" Then cust = " "
        If tglPeriode.Text.ToString <> "" Then tgl = "and convert(VARCHAR(7), tgl_sp, 102) = " + Format(tglPeriode.EditValue, "yyyy.MM")
        If Not dsete.Tables("mon") Is Nothing Then dsete.Tables("mon").Clear()

        With New SqlDataAdapter("select * from sales.dbo.VKeluhanPelanggan where tipe_trans in ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "') and isnull(Status,'') = 'OK' " + cust + tgl, sqlconn)
            .Fill(dsete, "mon")
            GC.DataSource = dsete.Tables("mon")
        End With
    End Sub

    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        reload()
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Laporan Keluhan Pelanggan " & vbCrLf & "Periode " & tglPeriode.Text)
    End Sub

End Class