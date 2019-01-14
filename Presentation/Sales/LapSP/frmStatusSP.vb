Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmStatusSP
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
    Public filter As String
    Const counter As Int16 = 60
    Dim i As Int16
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()

    End Sub
    Sub reload()
        'Timer1.Enabled = False
        Dim sql As String
        If tglStart.Text = "" And tglStop.Text = "" Then Exit Sub
        If tglStart.Text <> "" And tglStop.Text = "" Then sql = " and convert(varchar,tgl_sp,112) >= " & Format(tglStart.EditValue, "yyyyMMdd")
        If tglStart.Text <> "" And tglStop.Text <> "" Then sql = " and convert(varchar,tgl_sp,112) between " & Format(tglStart.EditValue, "yyyyMMdd") & " and " & Format(tglStop.EditValue, "yyyyMMdd")
        If tglStart.Text = "" And tglStop.Text <> "" Then sql = " and convert(varchar,tgl_sp,112) <= " & Format(tglStop.EditValue, "yyyyMMdd")
        If txtCustomer.Text <> "" Then sql = sql & " and Kd_Customer = '" & txtCustomer.EditValue & "'"

        btnRefresh.Enabled = False
        lblStatus.Text = "Seraching.."
        lblStatus.Refresh()
        GC.DataSource = dsete.Tables("dummy") : gv.RefreshData()
        If Not dsete.Tables("sp") Is Nothing Then dsete.Tables("sp").Clear()
        Dim cmd As SqlCommand = New SqlCommand("select * from [SALES].[dbo].[vStatusSP2] where isClosed is null and Status='OK' and isnull(isClosed,'') <> 'Y' and tipe_trans in ('" & IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum & "','" & CentianUmum) & "') " & sql & " order by len(no_seq), no_seq", sqlconn)
        cmd.CommandTimeout = 0
        dadbe = New SqlDataAdapter(cmd)
        'dadbe = New SqlDataAdapter(New SqlCommand("select * from [SALES].[dbo].[vStatusSP] where isClosed is null and Status='OK' and isnull(isClosed,'') <> 'Y' and tipe_trans = '" & IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum) & "' " & sql & " order by len(no_seq), no_seq", sqlconn))
        dadbe.Fill(dsete, "sp")
        GC.DataSource = dsete.Tables("sp")
        lblStatus.Text = "DONE"
        i = counter
        Timer1.Enabled = True
        btnRefresh.Enabled = True

    End Sub
    Private Sub frmStatusSP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        setStatus()

        dadbe = New SqlDataAdapter(New SqlCommand("select Kd_Customer, Nama_Customer from sif.dbo.sif_customer ", sqlconn))
        dadbe.Fill(dsete, "customer")
        dsete.Tables.Add("dummy")
        dsete.Tables("dummy").Columns.Add("Nama_Customer")
        dsete.Tables("dummy").Rows.Add(dsete.Tables("dummy").NewRow)
        dsete.Tables("dummy").Rows(0)(0) = "LOADING...."
        txtCustomer.Properties.DataSource = dsete.Tables("customer")
        reload()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnRefresh.Text = counter
        i = counter
        Timer1.Enabled = True
        Nama_Customer.Group()
        No_sp.Group()
        rdFilter.Properties.Items(0).Value = SpringUmum
        rdFilter.Properties.Items(1).Value = SponUmum
        rdFilter.Properties.Items(2).Value = ServiceSpringUmum
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 0 Then
            reload()
        End If
        btnRefresh.Text = i

        i -= 1

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        'reload()
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Daftar Status SP")
    End Sub

    Private Sub rdFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFilter.SelectedIndexChanged
        dsete.Tables("sp").Clear()
        dadbe = New SqlDataAdapter(New SqlCommand("select * from [SALES].[dbo].[vStatusSP] where isClosed is null and Status='OK' and tipe_trans = '" & IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum) & "'", sqlconn))
        dadbe.Fill(dsete, "sp")
        i = 60
    End Sub

    Private Sub CetakSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSP.Click
        reload()
    End Sub
End Class