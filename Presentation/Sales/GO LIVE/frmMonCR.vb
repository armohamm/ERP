Imports System.Data.SqlClient
Imports System.Data
Public Class frmMonCR
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim prn As frmMain

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Dim rl, rl2 As DataRelation
    Public Sub add_click()

    End Sub

    Private Sub frmMonCR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DA = New SqlDataAdapter("select *, 0.1 SisaSpring, 0.1 SisaSpon from sif.dbo.sif_customer where rec_stat = 'Y'", sqlconn)
        DA.Fill(dsete, "Customer")
        GC.DataSource = dsete.Tables("Customer")

        DA = New SqlDataAdapter("select No_sp, tgl_sp, JML_RP_TRANS,Kd_Customer,sales.dbo.getJmlRpNotaPerSP(no_sp) Nota ,sales.dbo.getJmlBayarNotaPerSP(No_Sp) Bayar from sales.dbo.sales_so where Status='OK' and isnull(islunas,'') <> 'Y' and tipe_trans = '" & SpringUmum & "'", sqlconn)
        DA.Fill(dsete, "SOSpring")

        DA = New SqlDataAdapter("select No_sp, tgl_sp, JML_RP_TRANS,Kd_Customer,sales.dbo.getJmlRpNotaPerSP(no_sp) Nota ,sales.dbo.getJmlBayarNotaPerSP(No_Sp) Bayar from sales.dbo.sales_so where Status='OK' and isnull(islunas,'') <> 'Y' and tipe_trans in ('" & SponUmum & "','" & CentianUmum & "')", sqlconn)
        DA.Fill(dsete, "SOSpon")

        rl = dsete.Relations.Add("Spring", dsete.Tables("Customer").Columns("Kd_Customer"), dsete.Tables("SOSpring").Columns("Kd_Customer"), False)
        rl.Nested = True
        GC.LevelTree.Nodes.Add("Spring", GVSpring)

        rl2 = dsete.Relations.Add("Spon", dsete.Tables("Customer").Columns("Kd_Customer"), dsete.Tables("SOSpon").Columns("Kd_Customer"), False)
        rl2.Nested = True
        GC.LevelTree.Nodes.Add("Spon", GVSpring)
        reload()
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dsete.Tables("Customer").Clear()
        dsete.Tables("SOSpring").Clear()
        dsete.Tables("SOSpon").Clear()

        DA = New SqlDataAdapter("select *, 0 SisaSpring, 0 SisaSpon from sif.dbo.sif_customer where rec_stat = 'Y'", sqlconn)
        DA.Fill(dsete, "Customer")
        GC.DataSource = dsete.Tables("Customer")

        DA = New SqlDataAdapter("select No_sp, tgl_sp, JML_RP_TRANS,Kd_Customer,sales.dbo.getJmlRpNotaPerSP(no_sp) Nota ,sales.dbo.getJmlBayarNotaPerSP(No_Sp) Bayar from sales.dbo.sales_so where Status='OK' and isnull(islunas,'') <> 'Y' and tipe_trans = '" & SpringUmum & "'", sqlconn)
        DA.Fill(dsete, "SOSpring")

        DA = New SqlDataAdapter("select No_sp, tgl_sp, JML_RP_TRANS,Kd_Customer,sales.dbo.getJmlRpNotaPerSP(no_sp) Nota ,sales.dbo.getJmlBayarNotaPerSP(No_Sp) Bayar from sales.dbo.sales_so where Status='OK' and isnull(islunas,'') <> 'Y' and tipe_trans in ('" & SponUmum & "','" & CentianUmum & "')", sqlconn)
        DA.Fill(dsete, "SOSpon")
        reload()
    End Sub
    Sub reload()
        Dim sisa As Decimal
        For Each rw As DataRow In dsete.Tables("Customer").Rows
            If dsete.Tables("SOSpring").Select("Kd_Customer = '" & rw("Kd_Customer") & "'").Count > 0 Then
                sisa = dsete.Tables("SOSpring").Compute("SUM(JML_RP_TRANS)", "Kd_Customer = '" & rw("Kd_Customer") & "'")
                rw("SisaSpring") = sisa - dsete.Tables("SOSpring").Compute("SUM(Bayar)", "Kd_Customer = '" & rw("Kd_Customer") & "'")
            Else
                rw("SisaSpring") = 0
            End If
            If dsete.Tables("SOSpon").Select("Kd_Customer = '" & rw("Kd_Customer") & "'").Count > 0 Then
                sisa = dsete.Tables("SOSpon").Compute("SUM(JML_RP_TRANS)", "Kd_Customer = '" & rw("Kd_Customer") & "'")
                rw("SisaSpon") = sisa - dsete.Tables("SOSpon").Compute("SUM(Bayar)", "Kd_Customer = '" & rw("Kd_Customer") & "'")
            Else
                rw("SisaSpon") = 0
            End If
        Next
    End Sub
End Class