Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmBukuRetur
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
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click
        reloadTable("1")
        lblFound.Text = "Item Found(s) : " & GV.RowCount
    End Sub
    Public Sub add_click()

    End Sub

    Private Sub reloadTable(ByVal kode As String)

        Dim sql As String

        If txtCustomer.Text <> "" Then
            sql = " and Kd_Customer='" & txtCustomer.EditValue & "'"
        End If
        If tglDari.Text = "" Then
            If tglSampai.Text <> "" Then
                sql = " and Tgl_retur < " & tglSampai.Text
            End If
        Else

            If tglSampai.Text <> "" Then
                sql = " and Tgl_retur  between '" & tglDari.Text & "' and '" & tglSampai.Text & "' "
            Else
                sql = " and Tgl_retur  > " & tglDari.Text
            End If
        End If

        If Not dsete.Tables("SALES_RETUR") Is Nothing Then dsete.Tables("SALES_RETUR").Clear()
        If Not dsete.Tables("SALES_RETUR_D") Is Nothing Then dsete.Tables("SALES_RETUR_D").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR where '1'='" & kode & "' " & sql, sqlconn))
        DA.Fill(dsete, "SALES_RETUR")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR_D ", sqlconn))
        DA.Fill(dsete, "SALES_RETUR_D")
    End Sub

    Private Sub frmBukuRetur_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR_D where 1=0", sqlconn))
        DA.Fill(dsete, "SALES_RETUR_D")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR  where 1=0 ", sqlconn))
        DA.Fill(dsete, "SALES_RETUR")
        Dim rl As DataRelation
        rl = dsete.Relations.Add("Detail", dsete.Tables("SALES_RETUR").Columns("No_retur"), dsete.Tables("SALES_RETUR_D").Columns("No_retur"), False)
        GC.DataSource = dsete.Tables("SALES_RETUR")
        GC.LevelTree.Nodes.Add("Detail", GVD)

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang as b", sqlconn))
        DA.Fill(dsete, "VBARANG")
        repbarang.DataSource = dsete.Tables("VBARANG")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='JNSRTR'  and [Id_Ref_Data] = 'JNSRTR' ", sqlconn))
        DA.Fill(dsete, "JNSRTR")
        repJenis.DataSource = dsete.Tables("JNSRTR")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='ALSNRTR'  and [Id_Ref_Data] = 'ALSNRTR' ", sqlconn))
        DA.Fill(dsete, "ALSNRTR")
        repAlasa.DataSource = dsete.Tables("ALSNRTR")

        prn = frmMain
        If Not TypeOf Me.Parent Is Form Then
            prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtCustomer.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglSampai.EditValue = vbNullString

    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Laporan Buku Retur " & vbCrLf & "Periode " & tglDari.EditValue.ToString & " - " & tglSampai.EditValue.ToString)
    End Sub

End Class