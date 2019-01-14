Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmUpdateJanjiKirim
    Dim dsete As New DataSet
    Dim DA, dadbe As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String, ByVal tipe_trans As String)
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
   
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "' order by No_seq", sqlconn))
        DAD.Fill(dsete, "SOD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        If GC.DataSource Is Nothing Then GC.DataSource = dsete.Tables("SOD")
        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            txtTgl.Text = row.Item("Tgl_sp").ToString
            txtKode.EditValue = row.Item("Kd_Customer").ToString
            TglKirim.EditValue = row.Item("Tgl_Kirim")
        Else
            txtNomor.Text = ""
            txtTgl.Text = ""
            txtKode.EditValue = Nothing
            TglKirim.EditValue = Nothing
        End If
    End Sub

    Private Sub txtKode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKode.EditValueChanged
        If txtKode.Text = "" Then
            txtCustomer.Text = ""
        Else
            Dim dr As SqlDataReader = New SqlCommand("select nama_customer from sif.dbo.sif_Customer where Kd_Customer='" & txtKode.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtCustomer.Text = dr(0)
            Else
                txtCustomer.Text = ""
            End If
            dr.Close()
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer] from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and tipe_trans in ('JPJ-KPT-05','" & gettipeTrans("JPJ") & "') order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim dr As SqlDataReader = New SqlCommand("select sales.dbo.isSoProccesed('" & txtNomor.Text & "') ", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item(0) > 0 Then
                btnSave = False
            Else
                btnSave = True
            End If
            dr.Close()
            dr = Nothing
            btnadd = False
            btnEdit = False
            reload_table(frmCari.row(0), frmCari.row(2))

            btnCancel = True
            Me.Enabled = True
            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        edit_click()
    End Sub

    Private Sub frmUpdateJanjiKirim_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang from SIF.dbo.SIF_Barang as b where b.Kd_Depart = '" & kddep & "' and b.kd_jns_persd=1  and b.rec_stat='Y' order  by Nama_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        repStok.DataSource = dsete.Tables("VBARANG")
        prn = frmMain
        setStatus()
    End Sub

    Private Sub frmUpdateJanjiKirim_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Top = 10
        Me.Height = Me.Parent.Height - 10
    End Sub
End Class