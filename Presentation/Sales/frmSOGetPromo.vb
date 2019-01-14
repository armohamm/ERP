Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOGetPromo
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public NOSO As String = ""
    Public tipetrans As String = gettipeTrans("JPJ")
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub reload_table(ByVal kode As String)
        If Not dsete.Tables("PROMO") Is Nothing Then dsete.Tables("PROMO").Clear()
        txtNomor.Text = NOSO
        DA = New SqlClient.SqlDataAdapter(New SqlCommand("select *, '' as PROMO  from Sales.dbo.SALES_SO_D_PROMO where No_sp='" & kode & "'", sqlconn))
        DA.Fill(dsete, "PROMO")
        If dsete.Tables("PROMO").Rows.Count > 0 Then
            If MsgBox("SP Tersebut Telah Diproses, Hitung Ulang Promo Untuk SP Tersebut?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Proses Promo") = MsgBoxResult.No Then Exit Sub
            If dsete.Tables("PROMO").Compute("count(Ambil)", "isnull(Ambil,'')='Y'") > 0 Then
                MsgBox("Barang Bonus Untuk SP Tersebut Telah Diporses", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
                If Not dsete.Tables("PROMO") Is Nothing Then dsete.Tables("PROMO").Clear()
                cancel_click()
                Exit Sub
            End If
        End If
        For Each rw As DataRow In dsete.Tables("PROMO").Rows
            rw.Delete()
        Next
        gc.DataSource = dsete.Tables("PROMO")
        Dim dr As SqlDataReader = New SqlCommand("select a.*, (select nama_promo from sif.dbo.sif_promo where no_promo=a.kdpromo) as PROMO " & _
                                                 " from sales.dbo.SOGetPromo('" & NOSO & "', '" & tipetrans & "') as a", sqlconn).ExecuteReader
        While dr.Read()
            Dim rw As DataRow = dsete.Tables("PROMO").NewRow
            rw("Kd_Cabang") = kdcabang
            rw("tipe_trans") = tipetrans
            rw("seq_sp") = "0"
            rw("PROMO") = dr("PROMO")
            rw("NO_SP") = NOSO
            rw("KD_PROMO") = dr("KDPROMO")
            rw("No_Seq") = dr("NOSEQ")
            rw("JML_POINT") = dr("jml_point")
            rw("CASHBACK") = dr("cash_back")
            rw("KD_BRG_BONUS") = dr("kd_brg_bonus")
            rw("QTY") = dr("free_qty")
            rw("PROMO_DESC") = dr("PROMODESC")
            rw("Programe_name") = Me.Name
            rw("Last_Create_Date") = Now
            rw("Last_Created_By") = username
            'rows.Item("Last_Update_Date") = Now
            'rows.Item("Last_Updated_By") = username
            rw("Status") = "Y"
            dsete.Tables("PROMO").Rows.Add(rw)
        End While
        dr.Close()
        dr = Nothing
        If txtNomor.Text <> "" Then
            Me.Enabled = True
            btnCancel = True
            btnEdit = False
            btnSave = True
            setStatus()
            btnSimpan.Visible = False
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal] from sales.dbo.sales_SO where isClosed='Y'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            NOSO = frmCari.row(0)
            reload_table(NOSO)
            State = "EDIT"
            btnSave = True
            btnEdit = False
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub cancel_click()
        reload_table("")
        txtCustomer.Text = ""
        txtNomor.Text = ""
        tglSO.Text = ""
        btnSave = False
        btnCancel = False
        btnEdit = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dsete.Tables("PROMO") Is Nothing Then delete(dsete.Tables("PROMO").Rows)
            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub save_click(Optional ByVal param As Boolean = False)
        If gv.RowCount = 0 Then Me.Close()
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.Update(dsete.Tables("PROMO"))
        dsete.Tables("PROMO").AcceptChanges()
        showMessages("Transaksi Telah Diproses")
    End Sub
    Private Sub frmSOGetPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = frmMain

        reload_table(NOSO)
        
    End Sub
    Private Sub txtNomor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomor.TextChanged
        If txtNomor.Text = "" Then
            tglSO.Text = ""
            txtCustomer.Text = ""
        Else
            Dim dr As SqlDataReader = New SqlCommand("select a.Tgl_sp, (select Nama_Customer from sif.dbo.sif_customer where a.Kd_Customer=Kd_Customer) " & _
                                                     " as Nama_Customer from sales.dbo.sales_so as a where no_sp = '" & NOSO & "'", sqlconn).ExecuteReader
            While dr.Read
                txtCustomer.Text = dr("Nama_Customer")
                tglSO.Text = dr("Tgl_sp")
            End While
            dr.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        save_click()
    End Sub
End Class