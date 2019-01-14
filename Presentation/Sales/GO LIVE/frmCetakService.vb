Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmCetakService
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
            .btnCetak.Enabled = False
        End With

    End Sub
    Public Sub add_click()

    End Sub
    Public Sub save_click()
        If GC.FocusedView Is GV Then
            btnSave = False
            setStatus()
            For Each rw As DataRow In dsete.Tables("SO").Select("cetak='Y'")
                Try
                    Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & rw("No_sp") & "'", sqlconn).ExecuteNonQuery
                    callReport(App_Path() & "\report\vSoV.rpt", "", "PSO=" & rw("No_sp"), True, True, "DIM")
                    rw("status") = "OK"
                Catch e As Exception
                    rw("status") = "Gagal Cetak : " & e.Message
                End Try
            Next
            For Each rw As DataRow In dsete.Tables("SO").Select("Cetak_Form='Y'")
                Try
                    callReport(App_Path() & "\report\vSRV.rpt", "", "NO_SRV=" & rw("No_sp"), True, True, "DIM")
                    rw("status") = "OK"
                Catch e As Exception
                    rw("status") = "Gagal Cetak : " & e.Message
                End Try
            Next
            MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
            btnSave = True
            setStatus()
        End If
    End Sub
    Private Sub clear_sp()
        Dim r12 As Object
        GC.LevelTree.Nodes.Clear()
        GC.MainView = GV

        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()

        DA = New SqlDataAdapter("select tipe_trans, No_sp,  case when isnull(isPrinted,'') = '' then 'BARU' else 'CETAK ULANG' end status_cetak, Tgl_sp, Nama_Customer, 'T' as cetak, 'T' as Cetak_Form, '' as Status, last_created_by Owner from sales.dbo.vso_rep where  Departement='" & kddep & "' and  isnull(isClosed,'')='' and tipe_trans in ('" & ServiceSpringUmum & "','" & ServiceSponUmum & "') ", sqlconn)
        DA.Fill(dsete, "SO")
        DAB = New SqlDataAdapter("select No_sp, isnull(Nama_Barang_Asli, Deskripsi)   as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'') = '' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and isnull(isClosed,'')='')  and tipe_trans in ('" & ServiceSpringUmum & "','" & ServiceSponUmum & "')  order by len(no_seq), no_seq ", sqlconn)
        DAB.Fill(dsete, "SOD")

        GC.DataSource = dsete.Tables("SO")
        r12 = dsete.Relations.Add("Detail2", dsete.Tables("SO").Columns("No_sp"), dsete.Tables("SOD").Columns("No_sp"))
        GC.LevelTree.Nodes.Add("Detail", GVD)
        GC.Refresh()
    End Sub
    Private Sub clear_tarik()
        Dim r12 As Object
        GC.LevelTree.Nodes.Clear()

        GC.MainView = GVC

        If Not dsete.Tables("SODx") Is Nothing Then dsete.Tables("SODx").Clear()
        If Not dsete.Tables("SOx") Is Nothing Then dsete.Tables("SOx").Clear()

        DA = New SqlDataAdapter("select *,'T' as Cetak, '' as Status from [SALES].[dbo].[V_ST_REP]", sqlconn)
        DA.Fill(dsete, "SOx")
        DAB = New SqlDataAdapter("select no_sj, Deskripsi, Kd_satuan, Qty_kirim from [SALES].[dbo].[V_ST_D_REP]", sqlconn)
        DAB.Fill(dsete, "SODx")

        GC.DataSource = dsete.Tables("SOx")
        r12 = dsete.Relations.Add("Detail2", dsete.Tables("SOx").Columns("no_sj"), dsete.Tables("SODx").Columns("no_sj"))
        GC.LevelTree.Nodes.Add("Detail2", GVDC)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dsete.Relations.Clear()
        If txtNomor.Text = "SP/FORM SERVICE" Then
            clear_sp()
        Else
            clear_tarik()
        End If
    End Sub

    Private Sub frmCetakService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()
        clear_sp()
    End Sub

    Private Sub txtNomor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomor.SelectedIndexChanged
        dsete.Relations.Clear()
        If txtNomor.Text = "SP/FORM SERVICE" Then
            clear_sp()
        Else
            clear_tarik()
        End If
    End Sub
End Class