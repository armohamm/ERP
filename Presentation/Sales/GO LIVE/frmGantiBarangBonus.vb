Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmGantiBarangBonus
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA, DAD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public State As String
    Dim ONLOAD_STATE As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        btnadd = False
        btnDelete = False
        btnCetak = False
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
        End With
    End Sub
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        State = ""
        setStatus()
        Me.Enabled = False
        txtNomor.EditValue = vbNullString
        txtNamaCustomer.EditValue = vbNullString

    End Sub
    Public Sub add_click()
       
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        connect()
        Dim BTRANS As SqlTransaction
        Dim isError As Boolean = False

        myBuilder = New SqlClient.SqlCommandBuilder(DAD)
        myBuilder.ConflictOption = ConflictOption.OverwriteChanges
        DAD.UpdateCommand = myBuilder.GetUpdateCommand()
        DAD.InsertCommand = myBuilder.GetInsertCommand()
        DAD.DeleteCommand = myBuilder.GetDeleteCommand()

        If BTRANS Is Nothing Then BTRANS = sqlconn.BeginTransaction("1")     

        DAD.UpdateCommand.Transaction = BTRANS
        DAD.InsertCommand.Transaction = BTRANS
        DAD.DeleteCommand.Transaction = BTRANS

        DAD.Update(dsete.Tables("SOD"))

        BTRANS.Commit()

        showMessages("Transaksi Telah Tersimpan")
        State = "EDIT"
        reload_table(txtNomor.Text, "")

    End Sub
    Private Sub frmGantiBarangBonus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        reload_table("XX", "XX")
        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()
        Dim sqlcmd As New SqlCommand("select b.Nama_Barang, b.Kd_Satuan,  Kode_Barang " & _
        "from SIF.dbo.SIF_Barang b " & _
        "where b.Kd_Depart in ('" & kddep & "') and b.rec_stat='Y' and b.kd_jns_persd in ('1','2','3')", sqlconn)
        dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
        dadbe.Fill(dsete, "VBARANG")
        gc.DataSource = dsete.Tables("SOD")
        repGV.DataSource = dsete.Tables("VBARANG")
        repGV.DisplayMember = "Nama_Barang"
        repGV.ValueMember = "Kode_Barang"
        repGV.View.BestFitColumns()
        repGV.View.Columns("Kode_Barang").Visible = False

    End Sub
    Public Sub reload_table(ByVal kode As String, ByVal tipe_trans As String)
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_D where not nomor_bonus is null and No_sp='" & kode & "'  order by len(no_seq), No_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SO")
        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            txtNamaCustomer.EditValue = row.Item("Kd_Customer").ToString
            tglsp.Text = row.Item("Tgl_sp").ToString
            txtPromo.Text = row.Item("desc_promo").ToString

            Dim dr As SqlDataReader
            dr = New SqlCommand("select top 1 d.no_rph from prod.dbo.prod_rcn_prod_d d, prod.dbo.prod_rcn_prod_m m where no_sp='" & txtNomor.Text & "' and d.no_rph=m.no_rph and not no_spk is null", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On SPK"
                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            dr.Close()

            dr = New SqlCommand("select * from prod.dbo.PROD_rcn_krm_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery Planing"
                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            dr.Close()

            dr = New SqlCommand("select * from sales.dbo.sales_sj where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery"
            End If
            dr.Close()
            dr = Nothing
        
            If username.ToUpper = "ADMIN" Then
                btnSave = True
            End If

            setStatus()
        Else

            txtNamaCustomer.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglsp.Text = vbNullString
            txtPromo.Text = vbNullString
        End If
    End Sub
    Public Sub edit_click()
        tipetrans = IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum)
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], desc_promo from sales.dbo.[VSO_REP] where tipe_trans ='" & tipetrans & "' and isnull(desc_promo,'') <> '' and isClosed is null order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

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
            ONLOAD_STATE = True
            State = "EDIT"
            reload_table(frmCari.row(0), frmCari.row(2))
            ONLOAD_STATE = False

            If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
            btnCancel = True
            Me.Enabled = True

            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
                cancel_click()
            End If

            setStatus()

        Else
            cancel_click()
            State = ""
        End If
    End Sub
End Class