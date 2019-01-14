Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonJmlSrv
    Dim dsete As New DataSet
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
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

        btnSave = True
        btnCancel = True
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
        If Not dsete.Tables("mon") Is Nothing Then dsete.Tables("mon").Clear()
        Dim sql As String
        If kddep = KD_DIV_SPRING Then tipetrans = ServiceSpringUmum Else tipetrans = ServiceSponUmum
        If tglAwal.Text = "" And tglAkhir.Text = "" Then sql = "select keterangan, tgl_sp, Nama_Jenis, thnbuat, 1 Qty from sales.dbo.VKeluhanPelanggan where tipe_trans in ('" & tipetrans & "') and status='OK'"
        If tglAwal.Text <> "" And tglAkhir.Text = "" Then sql = "select keterangan, tgl_sp, Nama_Jenis, thnbuat, 1 Qty from sales.dbo.VKeluhanPelanggan where tipe_trans in ('" & tipetrans & "') and status='OK' and CONVERT(varchar(10), tgl_sp,102) >= '" & tglAwal.DateTime.ToString("yyyy.MM.dd") & "'"
        If tglAwal.Text = "" And tglAkhir.Text <> "" Then sql = "select keterangan, tgl_sp, Nama_Jenis, thnbuat, 1 Qty from sales.dbo.VKeluhanPelanggan where tipe_trans in ('" & tipetrans & "') and status='OK' and CONVERT(varchar(10), tgl_sp,102) <= '" & tglAkhir.DateTime.ToString("yyyy.MM.dd") & "'"
        If tglAwal.Text <> "" And tglAkhir.Text <> "" Then sql = "select keterangan, tgl_sp, Nama_Jenis, thnbuat, 1 Qty from sales.dbo.VKeluhanPelanggan where tipe_trans in ('" & tipetrans & "') and status='OK' and CONVERT(varchar(10), tgl_sp,102) between '" & tglAwal.DateTime.ToString("yyyy.MM.dd") & "' and '" & tglAkhir.DateTime.ToString("yyyy.MM.dd") & "'"

        With New SqlDataAdapter(sql, sqlconn)

            .Fill(dsete, "mon")
            gc.DataSource = dsete.Tables("mon")
        End With
        gv.ExpandAllGroups()
    End Sub

    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        reload()
    End Sub
End Class
