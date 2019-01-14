Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOBonus
    Dim dsete As New DataSet
    Dim dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public no_sp As String = "XXX"
    Dim rhandel As Integer
    Public ONLOAD_STATE As Boolean = False
    Private tipetrans As String = IIf(kddep = KD_DIV_SPRING, SpringBonus, SponBonus)
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
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        txtCustomer.Focus()
    End Sub
    Public Sub cancel_click()
        reloadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        State = ""

        setStatus()
        Me.Enabled = False
        txtCustomer.EditValue = vbNullString
        tglSO.Text = getTanggal()
        txtAlamatKirim.Text = ""
        txtKeterangan.Text = ""
        txtNamaPnrm.Text = ""
        lblTotal.EditValue = Nothing
        txtNomor.Text = ""
    End Sub
    Private Sub reloadTable(ByVal kode As String)
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()

        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipetrans & "' order by No_seq", sqlconn))
        DAD.Fill(dsete, "SOD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipetrans & "'", sqlconn))
        DA.Fill(dsete, "SO")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            txtCustomer.EditValue = row.Item("Kd_Customer").ToString
            txtNamaPnrm.Text = row.Item("Nama_pnrm").ToString
            txtAlamatKirim.Text = row.Item("Almt_pnrm").ToString
            tglKirimMarketing.EditValue = row.Item("Tgl_Kirim_Marketing")
            txtKeterangan.Text = row.Item("Keterangan").ToString
            cmdWilayah.EditValue = row.Item("Kode_Wilayah")
            tglKirim.EditValue = row.Item("Tgl_Kirim")
            txtBiaya.EditValue = CType(row("Biaya").ToString, Double)
            lblTotal.EditValue = CType(row("JML_RP_TRANS").ToString, Double)

            btnSave = False
            btnCancel = True
            btnDelete = False

            setStatus()
        Else

            txtCustomer.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglKirimMarketing.EditValue = vbNullString
            tglKirim.EditValue = vbNullString
            cmdWilayah.EditValue = vbNullString
            tglSO.Text = vbNullString
            lblTotal.EditValue = 0
            txtBiaya.EditValue = 0
        End If
    End Sub
    Private Sub frmSOBonus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where rec_stat='Y' order by Nama_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * FROM [SIF].[dbo].[SIF_Area] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "AREA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.sif_wilayah where rec_stat='Y' ", sqlconn))
        dadbe.Fill(dsete, "WILAYAH")

        reloadTable("xxx")
        GC.DataSource = dsete.Tables("SOD")

        State = "ADD"
        tglSO.Text = getTanggal()
        prn = frmMain

    End Sub
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        If Not sender.editvalue Is Nothing Then
            txtKodeCust.Text = sender.editvalue
            If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Rows.Clear()
            Dim dr As SqlDataReader = New SqlCommand("select * from sales.dbo.V_BARANG_BONUS_ALL where kd_customer='" & txtCustomer.EditValue & "' and Tipe_trans='" & tipetrans & "'", sqlconn).ExecuteReader
            Dim i As Int16 = 0
            Dim drw As DataRow
            While dr.Read
                drw = dsete.Tables("SOD").NewRow
                drw("Kd_Cabang") = kdcabang
                drw("tipe_trans") = tipetrans
                i += 1
                drw("No_seq") = i
                drw("Kd_Stok") = dr("kode_barang")
                drw("Qty") = dr("qty")
                drw("kd_satuan") = dr("Kd_Satuan")
                drw("departemen") = kddep
                drw("Deskripsi") = dr("Nama_Barang")
                drw("Nomor_Bonus") = dr("nomor")
                drw("Last_Create_Date") = getTanggal()
                drw("Last_Created_By") = username
                drw("tipe_trans") = tipetrans
                drw("key_bonus") = dr("nomor")
                drw("reff") = dr("reff")
                drw("Status") = "Y"
                drw("Programe_name") = Me.Name
                drw("Qty_sisa") = drw("qty")
                drw("qty_prod") = 0
                drw("qty_kirim") = 0
                dsete.Tables("SOD").Rows.Add(drw)
            End While
            dr.Close()
            txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
            Dim area As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString()
            Dim wil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString()
            cmdWilayah.EditValue = wil
            If State = "ADD" Then
                Dim kdwil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString
                Dim kdarea As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString
                With dsete.Tables("AREA").Select("Kd_Wilayah = '" & kdwil & "' and Kode_Area='" & kdarea & "'")
                    If .Count > 0 Then tglKirimMarketing.EditValue = getTanggal.AddDays(.ElementAt(0).Item("Leat_Time")) : tglKirim.EditValue = tglKirimMarketing.EditValue
                End With
            End If
            DXEP.SetError(txtKodeCust, "")
        Else
            txtKodeCust.Text = ""
            txtAlamatKirim.Text = ""
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim isError As Boolean = False
        If State <> "ADD" Then
            Dim dr As SqlDataReader = New SqlCommand("select [status] from sales.dbo.sales_so where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr(0).ToString = "BATAL" Then
                    MsgBox("Data Sales Order Tersebut Sudah Dibatalkan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                    cancel_click()
                    dr.Close()
                    Exit Sub
                End If
            Else
                MsgBox("Data Sales Order Tersebut Tidak Diketemukan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                cancel_click()
                dr.Close()
                Exit Sub
            End If
            dr.Close()
        End If
        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                DXEP.SetError(txtKodeCust, "Nama Customer Belum Diisi")
                txtCustomer.Focus()
                isError = True
            End If
            If tglKirimMarketing.Text = "" Then
                tglKirimMarketing.ErrorText = "Tanggal Kirim Belum Diisi"
                tglKirimMarketing.Focus()
                isError = True
            End If
            If DateDiff(DateInterval.Day, Convert.ToDateTime(tglSO.Text), tglKirimMarketing.EditValue) < 0 Then
                tglKirimMarketing.ErrorText = "Tanggal Janji Kirim Harus Lebih Besar Dari Tanggal Order"
                tglKirimMarketing.Focus()
                isError = True
            End If
            If GV.RowCount = 0 Then
                lblTotal.ErrorText = "Daftar Barang Masih Kosong"
                lblTotal.Focus()
                isError = True
            End If

        End If
        If isError = True Then
            showMessages("Isian Masih Belum Benar, Harap Periksa Kembali", 10, "WARNING")
            Exit Sub
        End If
        If Not isDelete Then
            If State = "ADD" Then
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
            ElseIf State = "EDIT" Then
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang
            row.Item("Tipe_trans") = tipetrans
            row.Item("Tgl_sp") = getTanggal()
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Nama_pnrm") = txtNamaPnrm.Text
            row.Item("Almt_pnrm") = txtAlamatKirim.Text
            row.Item("Kode_Wilayah") = cmdWilayah.EditValue.ToString
            row.Item("Tgl_Kirim") = tglKirim.EditValue.ToString
            row.Item("Tgl_Kirim_Marketing") = tglKirimMarketing.EditValue.ToString()
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Flag_Ppn") = "Y"
            row.Item("PPn") = "0"
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = kddep
            row.Item("Status") = "OK"
            row.Item("JML_RP_TRANS") = 0
            row.Item("Valas") = "IDR"
            row.Item("Kurs") = 1
            row.Item("JML_VALAS_TRANS") = 1
            row.Item("Biaya") = txtBiaya.EditValue
            row.Item("Program_Name") = Me.Name
            row("Jenis_sp") = "BONUS"
            If State = "ADD" Then
                dsete.Tables("SO").Rows.Add(row)
            End If
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = tipetrans
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                    rows.Item("qty_prod") = 0
                    rows.Item("qty_kirim") = 0
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                End If
            Next
        End If
        Try
            dsete2 = dsete.Clone
            dsete2 = dsete.Copy

            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()
            DAD.InsertCommand = myBuilder.GetInsertCommand()
            DAD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                txtNomor.Text = getNoTrans("SPSBNS", row.Item("Tgl_sp"), BTRANS)
                row.Item("No_sp") = txtNomor.Text

                For Each rows As DataRow In dsete.Tables("SOD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_sp") = txtNomor.Text
                    End If
                Next
            End If
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Transaksi Telah Tersimpan")
        Catch e As Exception
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
End Class