Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmClosingPromo
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
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

    Private Sub frmClosingPromo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        reload_table()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.[dbo].sif_customer  where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "customer")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * FROM [SIF].[dbo].[SIF_BARANG_HADIAH] ", sqlconn))
        dadbe.Fill(dsete, "hadiah")

        repCustomer.DataSource = dsete.Tables("customer")
        repCustomer.DisplayMember = "Nama_Customer"
        repCustomer.ValueMember = "Kd_Customer"

        repHadiah.DataSource = dsete.Tables("hadiah")
        repHadiah.DisplayMember = "HADIAH"
        repHadiah.ValueMember = "KD_HADIAH"

        txtPromo.Properties.DataSource = dsete.Tables("promo")
        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(0) = dsete.Tables("promod").Columns("no_promo")
        dcolP(1) = dsete.Tables("promod").Columns("no_seq")

        dcolC(0) = dsete.Tables("cust_promo").Columns("KDPROMO")
        dcolC(1) = dsete.Tables("cust_promo").Columns("NOSEQ")
        rl = dsete.Relations.Add("Customer", dcolP, dcolC)

        GC.DataSource = dsete.Tables("promod")
        GC.LevelTree.Nodes.Add("Customer", GV2)
        prn = frmMain
        setStatus()
        pnl.Height = Me.Parent.Height - 50
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Private Sub reload_table()
        If Not dsete.Tables("cust_promo") Is Nothing Then dsete.Tables("cust_promo").Clear()
        If Not dsete.Tables("promo") Is Nothing Then dsete.Tables("promo").Clear()
        If Not dsete.Tables("promod") Is Nothing Then dsete.Tables("promod").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.dbo.sif_promo where isClosed is null and rec_stat='Y' and tipe_promo='Y'", sqlconn))
        dadbe.Fill(dsete, "promo")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.dbo.sif_promo_d where no_promo = 'xxxxxx' ", sqlconn))
        dadbe.Fill(dsete, "promod")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sales.[dbo].[CustGetPromo2]('X','X')  ", sqlconn))
        dadbe.Fill(dsete, "cust_promo")
        txtPromo.EditValue = Nothing
    End Sub
    Private Sub txtPromo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPromo.EditValueChanged
        If txtPromo.EditValue Is Nothing Then
            txtKodePromo.Text = ""
            txtDari.Text = ""
            txtsampai.Text = ""
        Else
            txtKodePromo.Text = txtPromo.EditValue
            txtDari.Text = FormatDateTime(txtPromo.GetColumnValue("start_date"), DateFormat.LongDate)
            txtsampai.Text = FormatDateTime(txtPromo.GetColumnValue("end_date"), DateFormat.LongDate)
            If Not dsete.Tables("promod") Is Nothing Then dsete.Tables("promod").Clear()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        pnlLoad.Visible = True
        Try
            If txtPromo.Text = "" Then Exit Sub
            If Not dsete.Tables("promod") Is Nothing Then dsete.Tables("promod").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.dbo.sif_promo_d where no_promo = '" & txtKodePromo.Text & "' ", sqlconn))
            dadbe.Fill(dsete, "promod")
            If Not dsete.Tables("cust_promo") Is Nothing Then dsete.Tables("cust_promo").Clear()
            Dim cmd As New SqlCommand(" select * from sales.[dbo].[CustGetPromo2]('%%','" & txtKodePromo.Text & "')", sqlconn)
            cmd.CommandTimeout = 0
            dadbe = New SqlClient.SqlDataAdapter(cmd)
            dadbe.Fill(dsete, "cust_promo")
        Catch ex As Exception
            pnlLoad.Visible = False
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        End Try
        pnlLoad.Visible = False
    End Sub
    Public Sub add_click()
        btnadd = False
        btnSave = True
        setStatus()
    End Sub

    Public Sub cancel_click()
        btnadd = True
        btnSave = False
        setStatus()
    End Sub
    Public Sub save_click()
        Dim btrans As SqlTransaction
        If MsgBox("Lanjutkan Proses Penutupan Promo ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Penutupan Promo") = MsgBoxResult.No Then Exit Sub
        Try

            btrans = sqlconn.BeginTransaction
            Dim i As Int16 = New SqlCommand("update sif.dbo.sif_promo set isclosed = 'Y', Last_Updated_By = '" & kdpeg & "', Last_Update_Date = getdate() , Program_Name = '" & Me.Name & "'  where no_promo = '" & txtKodePromo.Text & "'", sqlconn, btrans).ExecuteNonQuery
            For Each rw As DataRow In dsete.Tables("cust_promo").Rows
                i = New SqlCommand("INSERT INTO [SALES].[dbo].[SALES_CUSTOMER_GET_PROMO] ([Kd_Cabang],[dept] " & _
                   " ,[tgl],[no_promo],[no_seq],[kd_brg_bonus],[kd_brg_hadiah],[kd_customer],[Keterangan],[Last_Create_Date] " & _
                   " ,[Last_Created_By],[Last_Update_Date],[Last_Updated_By],[Program_Name], qty, qtysp)  VALUES " & _
                   " ('" & kdcabang & "', '" & kddep & "' , (select getdate()) , '" & txtKodePromo.Text & "', '" & rw("NOSEQ") & "', " & _
                   " '" & rw("kd_brg_bonus") & "', '" & rw("kd_brg_hadiah") & "' , '" & rw("kd_cust") & "' , " & _
                   " '', (select getdate()), '" & kdpeg & "', null, null, '" & Me.Name & "', " & rw("free_qty") & ",0)", sqlconn, btrans).ExecuteNonQuery
            Next

            showMessages("Transaksi Telah Disimpan")
            reload_table()
            btrans.Commit()
            ' btnRefresh_Click(btnRefresh, New EventArgs)
        Catch ex As Exception
            MsgBox(ex.Message)
            If Not btrans Is Nothing  Then btrans.Rollback()

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub
End Class