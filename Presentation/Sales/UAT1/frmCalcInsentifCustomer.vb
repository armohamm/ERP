Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmCalcInsentifCustomer
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
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

    Private Sub frmCalcInsentifCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        Dim m(1) As DataRow
        With dsete.Tables.Add("DIVISI")
            .Columns.Add("Kode_Divisi")
            .Columns.Add("Nama_Divisi")
            m(0) = .NewRow
            m(0).Item(0) = "2"
            m(0).Item(1) = "Divisi Spring"

            m(1) = .NewRow
            m(1).Item(0) = "3"
            m(1).Item(1) = "Divisi Spon"


            .Rows.Add(m(0))
            .Rows.Add(m(1))
        End With
        repDivisi.DataSource = dsete.Tables("DIVISI")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_cUSTOMER where 1=0", sqlconn))
        DA.Fill(dsete, "SALES_INSENTIF_CUSTOMER")
        gc.DataSource = dsete.Tables("SALES_INSENTIF_CUSTOMER")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer, Nama_Customer from sif.dbo.sif_CUSTOMER where rec_stat='Y' union select '%%', 'All'", sqlconn))
        DA.Fill(dsete, "CUST")
        txtCustomer.Properties.DataSource = dsete.Tables("CUST")
        repCust.DataSource = dsete.Tables("CUST")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()

    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        If txtTahun.Text = "" Then Exit Sub
        hitung()
        With New SqlCommand("select count(1) from fin.dbo.fin_jurnal where tipe_trans = 'JKK-KPT-04' and thnbln = '" & txtTahun.DateTime.ToString("yyyyMM") & "'  and isnull(no_posting,'') <> ''", sqlconn).ExecuteReader
            .Read()
            If .Item(0) > 0 Then
                Label2.Text = ")* Insentif Customer Sudah Di Posting"
            Else
                Label2.Text = ")* OPEN"
            End If
            .Close()
        End With
    End Sub
    Private Sub hitung()
        'showMessages("Loading", , "LOADING")
        If Not dsete.Tables("SALES_INSENTIF_CUSTOMER") Is Nothing Then dsete.Tables("SALES_INSENTIF_CUSTOMER").Clear()
        Dim thnbln As String = txtTahun.DateTime.ToString("yyyyMM")   'txtTahun.DateTime.Year & Microsoft.VisualBasic.Right("0" & txtTahun.DateTime.Month.ToString, 2)

        If txtCustomer.Text = "" Then
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_customer where ThnBln='" & thnbln & "'", sqlconn))
        Else
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_customer where ThnBln='" & thnbln & "' and kd_customer like '" & txtCustomer.EditValue & "'", sqlconn))
        End If
        DA.Fill(dsete, "SALES_INSENTIF_CUSTOMER")
        'frmMessage.Close()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim keluar As Boolean = False
        With New SqlCommand("select count(1) from fin.dbo.fin_jurnal where tipe_trans = 'JKK-KPT-04' and thnbln = '" & txtTahun.DateTime.ToString("yyyyMM") & "' and isnull(no_posting,'') <> ''", sqlconn).ExecuteReader
            .Read()
            If .Item(0) > 0 Then
                Label2.Text = ")* Insentif Customer Sudah Di Posting"
                keluar = True
            End If
            .Close()
        End With
        If keluar Then Exit Sub
        If dsete.Tables("SALES_INSENTIF_CUSTOMER").Rows.Count > 0 Then
            If MsgBox("Data Bulan ini sudah ada, hitung ulang insentif? " & vbCrLf & "*) Perhatian : Data Bulan ini Akan Dihapus ", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Hitung Insentif") = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If
        If txtTahun.Text = "" Then
            If MsgBox("Periode Belum Diisi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hitung Insentif") Then
                Exit Sub
            End If
        End If
        If txtCustomer.Text = "" Then
            If MsgBox("Customer Belum Diisi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hitung Insentif") Then
                Exit Sub
            End If
        End If
        Dim btrans As SqlTransaction
        Dim thnbln As String = txtTahun.DateTime.Year & Microsoft.VisualBasic.Right("0" & txtTahun.DateTime.Month.ToString, 2)

        Try
            Label2.Text = ")* PROSES KALKULASI...."
            Label2.Refresh()
            btrans = sqlconn.BeginTransaction
            With New SqlCommand()
                .Transaction = btrans
                .CommandText = "SALES.[dbo].[Hitung_insentif_customer]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@kd_customerx", SqlDbType.VarChar, 30)
                .Parameters.Add("@thnbln", SqlDbType.VarChar, 30)
                .Parameters.Add("@usr", SqlDbType.VarChar, 30)
                .Parameters.Add("@kdcab", SqlDbType.VarChar, 30)
                .Parameters("@kd_customerx").Value = txtCustomer.EditValue.ToString
                .Parameters("@thnbln").Value = thnbln
                .Parameters("@usr").Value = username
                .Parameters("@kdcab").Value = kdcabang
                .Connection = sqlconn
                .ExecuteNonQuery()

                .Parameters.Clear()
                .Transaction = btrans
                .CommandType = CommandType.StoredProcedure
                .CommandText = "FIN.[dbo].FIN_AUTOMAN_JURNAL"
                .Parameters.Add("@tipe_trans", SqlDbType.VarChar, 10)
                .Parameters.Add("@no_inv", SqlDbType.VarChar, 25)
                .Parameters("@tipe_trans").Value = "JKK-KPT-04"
                .Parameters("@no_inv").Value = thnbln
                .ExecuteNonQuery()

                btrans.Commit()
            End With
            If Not dsete.Tables("SALES_INSENTIF_CUSTOMER") Is Nothing Then dsete.Tables("SALES_INSENTIF_CUSTOMER").Clear()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_customer where ThnBln='" & thnbln & "'", sqlconn))
            DA.Fill(dsete, "SALES_INSENTIF_CUSTOMER")
            Label2.Text = ")* SELESAI"
        Catch x As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            Label2.Text = ")* ERROR!!"
            MsgBox(x.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        If txtTahun.Text = "" Then Exit Sub
        If txtCustomer.Text = "" Then Exit Sub
        hitung()
        
    End Sub
    Sub add_click()
        setStatus()
    End Sub
End Class