Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmCetakDok
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
    Dim r12 As DataRelation
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With

    End Sub
    Private Sub frmCetakDok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter("select tipe_trans, No_sp, old_num, Tgl_sp, Nama_Customer, 'T' as cetak, '' as Status, last_created_by Owner from sales.dbo.vso_rep where isnull(isPrinted,'') = '' and Departement='" & kddep & "' and len(no_sp)>10 and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') order by no_sp desc ", sqlconn)
        DA.Fill(dsete, "SO")
        DAB = New SqlDataAdapter("select No_sp, isnull(Deskripsi,Nama_Barang_Asli)   as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'') = '' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and len(no_sp)>10)  and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') order by no_seq ", sqlconn)
        DAB.Fill(dsete, "SOD")
        Dim r1 As DataRelation
        r1 = dsete.Relations.Add("Detail", dsete.Tables("SO").Columns("No_sp"), dsete.Tables("SOD").Columns("No_sp"))
        GC.DataSource = dsete.Tables("SO")
        GC.LevelTree.Nodes.Add("Detail", GVD)
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Public Sub add_click()

    End Sub
    Public Sub save_click()
        Dim gvn As String
        If GC.MainView Is GV Then
            gvn = "SO"
        Else
            gvn = "SOC"
        End If

        For Each rw As DataRow In dsete.Tables(gvn).Select("cetak='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & rw("No_sp") & "'", sqlconn).ExecuteNonQuery
                'If i > 0 Then
                Dim reportfile As String
                If rw("tipe_trans") = CentianUmum Then
                    reportfile = "\report\cSoBox.rpt"
                Else
                    reportfile = "\report\vSo.rpt"
                End If
                callReport(App_Path() & reportfile, "", "PSO=" & rw("No_sp"), True, True, "DIM")

                rw("status") = "OK"
                'Else
                'rw("status") = "Dokumen SP Sudah Pernah Dicetak"
                'End If
            Catch e As Exception
                rw("status") = "Gagal Cetak : " & e.Message
                'MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                'Exit Sub
            End Try
        Next
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        btnClear_Click(btnClear, New EventArgs)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        GC.LevelTree.Nodes.Clear()
        dsete.Relations.Clear()
        If GC.MainView Is GV Then
            GC.DataSource = dsete.Tables("SO")
            GC.LevelTree.Nodes.Add("Detail", GVD)
            dsete.Tables("SOD").Clear()
            dsete.Tables("SO").Clear()

            'DA = New SqlDataAdapter("select tipe_trans, No_sp, old_num, Tgl_sp, Nama_Customer, 'T' as cetak, '' as Status, last_created_by Owner from sales.dbo.vso_rep where isnull(isPrinted,'') = '' and Departement='" & kddep & "' and len(no_sp)>10 and isnull(isClosed,'')='' and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') ", sqlconn)
            'DA.Fill(dsete, "SO")
            'DAB = New SqlDataAdapter("select No_sp, isnull(Nama_Barang_Asli, Deskripsi)   as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'') = '' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and len(no_sp)>10 and isnull(isClosed,'')='')  and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "')  order by len(no_seq), no_seq ", sqlconn)
            'DAB.Fill(dsete, "SOD")

            DA = New SqlDataAdapter("select tipe_trans, No_sp, old_num, Tgl_sp, Nama_Customer, 'T' as cetak, '' as Status, last_created_by Owner from sales.dbo.vso_rep where isnull(isPrinted,'') = '' and Departement='" & kddep & "' and len(no_sp)>10 and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') order by no_sp desc ", sqlconn)
            DA.Fill(dsete, "SO")
            DAB = New SqlDataAdapter("select No_sp, isnull(Nama_Barang_Asli, Deskripsi) as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'') = '' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and len(no_sp)>10) and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "')", sqlconn)
            DAB.Fill(dsete, "SOD")
            r12 = dsete.Relations.Add("Detail2", dsete.Tables("SO").Columns("No_sp"), dsete.Tables("SOD").Columns("No_sp"))
            GC.LevelTree.Nodes.Add("Detail2", GVC)
        Else

            If Not dsete.Tables("SODC") Is Nothing Then dsete.Tables("SODC").Clear()
            If Not dsete.Tables("SOC") Is Nothing Then dsete.Tables("SOC").Clear()

            'DA = New SqlDataAdapter("select tipe_trans, No_sp, old_num, Tgl_sp, Nama_Customer, 'T' as cetak, '' as Status, last_created_by Owner from sales.dbo.vso_rep where Departement='" & kddep & "' and len(no_sp)>10 and isnull(isClosed,'')<>'Y' and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') ", sqlconn)
            'DA.Fill(dsete, "SOC")
            'DAB = New SqlDataAdapter("select No_sp, isnull(Nama_Barang_Asli, Deskripsi)   as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'Y') = 'Y' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and len(no_sp)>10 and isnull(isClosed,'')<>'Y')  and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "')  order by len(no_seq), no_seq ", sqlconn)
            'DAB.Fill(dsete, "SODC")

            DA = New SqlDataAdapter("select tipe_trans, No_sp, old_num, Tgl_sp, Nama_Customer, 'T' as cetak, '' as Status, last_created_by Owner from sales.dbo.vso_rep where Departement='" & kddep & "' and len(no_sp)>10 and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') order by no_sp desc ", sqlconn)
            DA.Fill(dsete, "SOC")
            DAB = New SqlDataAdapter("select No_sp, isnull(Nama_Barang_Asli, Deskripsi)   as Deskripsi, Kd_satuan, Qty from sales.dbo.vsod_rep as D where exists (select 1 from sales.dbo.vso_rep as M where isnull(isPrinted,'Y') = 'Y' and m.No_sp=d.No_sp and Departement='" & kddep & "'  and len(no_sp)>10 ) and tipe_trans not in ('" & SpringInternal & "','" & SponInternal & "','" & ServiceSpringUmum & "','" & ServiceSpringInternal & "') order by no_seq ", sqlconn)
            DAB.Fill(dsete, "SODC")

            GC.DataSource = dsete.Tables("SOC")

            r12 = dsete.Relations.Add("Detail2", dsete.Tables("SOC").Columns("No_sp"), dsete.Tables("SODC").Columns("No_sp"))
            GC.LevelTree.Nodes.Add("Detail2", GVDC)

        End If
    End Sub

    Private Sub SJ_BARU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SJ_BARU.Click
        GC.MainView = GV
        btnClear_Click(btnClear, New EventArgs)
        GV.RefreshData()
    End Sub

    Private Sub Cetak_Ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cetak_Ulang.Click
        GC.MainView = GVC
        btnClear_Click(btnClear, New EventArgs)
        GVC.RefreshData()
    End Sub
End Class