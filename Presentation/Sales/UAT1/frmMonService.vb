Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonService
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
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
    Public Sub reload_table()

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Dim sql As String = "select No_sp,No_Telp, case nama_customer when 'UMUM' then Nama_pnrm else nama_customer end Customer, tgl_sp Tgl, sales.dbo.status_inspeksi(no_sp) Status, Tipe_trans from sales.dbo.vso_rep where isnull(isclosed,'') <> 'Y' and Tipe_trans = '" & IIf(kddep = "2", ServiceSpringUmum, ServiceSponUmum) & "' "
        Dim sql2 As String = "select No_sp, Nama_Barang_Asli, no_seq, case when sales.dbo.getStatusKirimBarangService(no_sp, no_seq) = '?' then Status_inspeksi else sales.dbo.getStatusKirimBarangService(no_sp, no_seq) end Status_inspeksi, realisasi_tgl_kirim from sales.dbo.vsod_rep where Tipe_trans = '" & IIf(kddep = "2", ServiceSpringUmum, ServiceSponUmum) & "'"
        Dim tglx As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                tglx &= " and CONVERT(DATE, Tgl_sp, 103) < CONVERT(DATE, '" & tglsampai.Text & "' , 103) "
            End If
        Else
            If tglsampai.Text = "" Then
                tglx &= " and tgl_sp = CONVERT(DATE, '" & tglDari.Text & "' , 103) "
            Else
                tglx &= " and CONVERT(DATE, Tgl_sp, 103) between CONVERT(DATE, '" & tglDari.Text & "' , 103) and CONVERT(DATE, '" & tglsampai.Text & "' , 103) "
            End If
        End If
        dsete.Tables("SERVICE_D").Clear()
        dsete.Tables("SERVICE").Clear()

        dadbe = New SqlDataAdapter(sql & tglx, sqlconn) : dadbe.Fill(dsete, "SERVICE")
        dadbe = New SqlDataAdapter(sql2 & tglx, sqlconn) : dadbe.Fill(dsete, "SERVICE_D")

        lblInfo.Text = dsete.Tables("SERVICE").Rows.Count & " Daftar Ditemukan   "
    End Sub

    Private Sub frmMonService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        Dim sql As String = "select No_sp,No_Telp, case nama_customer when 'UMUM' then Nama_pnrm else nama_customer end Customer, tgl_sp Tgl, sales.dbo.status_inspeksi(no_sp) Status, Tipe_trans from sales.dbo.vso_rep where 1=0"
        Dim sql2 As String = "select No_sp, Nama_Barang_Asli, no_seq, Status_Inspeksi , realisasi_tgl_kirim from sales.dbo.vsod_rep where 1=0"
        Dim tglx As String = ""
        dadbe = New SqlDataAdapter(sql & tglx, sqlconn)
        dadbe.Fill(dsete, "SERVICE")
        dadbe = New SqlDataAdapter(sql2 & tglx, sqlconn)
        dadbe.Fill(dsete, "SERVICE_D")
        gc.DataSource = dsete.Tables("SERVICE")
        Dim rl As DataRelation
        rl = dsete.Relations.Add("Detail", dsete.Tables("SERVICE").Columns("No_sp"), dsete.Tables("SERVICE_D").Columns("No_sp"))
        gc.LevelTree.Nodes.Add("Detail", gvd)
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        dsete.Tables("SERVICE").Clear() : dadbe.Fill(dsete, "SERVICE")
        dsete.Tables("SERVICE_D").Clear() : dadbe.Fill(dsete, "SERVICE_D")
        lblInfo.Text = "Hasil "
    End Sub

    Private Sub gc_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gc.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not gv.GetFocusedRow Is Nothing Then
                call_form_manual("frmService2")
                With CObj(prn.pnlDisplay2.Controls(0))
                    .noso = gv.GetFocusedRow.item("No_sp")
                    .tipetransx = gv.GetFocusedRow.item("Tipe_trans").ToString
                    .statusService = gv.GetFocusedRow.item("Status").ToString
                    .loadData()
                End With
            End If
        End If

    End Sub
End Class