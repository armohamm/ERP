Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSuratJalanTarik
    Dim dsete As New DataSet
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
    Public old As Double
    Dim myBuilder As New SqlCommandBuilder
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
        tglRetur.Text = getTanggal()
        DT_TglSO.EditValue = tglRetur.EditValue
        dsete.Tables("SO").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp,Nama_Customer,Kd_Customer, Tipe_trans from sales.dbo.VSO_REP where  No_sp like '%SRV%' and no_sp not in (select no_sp from sales.dbo.sales_st)", sqlconn))
        dadbe.Fill(dsete, "SO")

    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub cancel_click()
        reloadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False

        txtNomor.Text = ""
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dsete.Tables("SOD") Is Nothing Then delete(dsete.Tables("SALES_st_D").Rows)
            If Not dsete.Tables("DSERVICE") Is Nothing Then delete(dsete.Tables("SALES_st").Rows)
            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sj [Suraj Jalan] , Nama_Customer, Tgl_kirim from sales.dbo.v_st_rep", sqlconn)) '
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reloadTable(frmCari.row(0))
            State = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub reloadTable(ByVal kode As String)
        If Not dsete.Tables("SALES_st") Is Nothing Then dsete.Tables("SALES_st").Clear()
        If Not dsete.Tables("SALES_st_D") Is Nothing Then dsete.Tables("SALES_st_D").Clear()

        
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_st where no_sj='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_ST")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.*, 0 QtySP, (select isnull(sum(qty_kirim),0) from SALES.dbo.SALES_st_D B where B.no_sp = a.no_sp and a.no_seq_kirim=b.No_seq ) TotTarik from SALES.dbo.SALES_st_D A where no_sj='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_st_D")
        gc.DataSource = dsete.Tables("SALES_st_D")
        txtNomor.Text = ""
        txtNomorRef.EditValue = vbNullString
        tglRetur.Text = getTanggal()
        DT_TglSO.EditValue = tglRetur.EditValue
        txtKendaraan.EditValue = vbNullString
        txtSopir.EditValue = vbNullString
        txtKernet.EditValue = vbNullString
        txtKodeCust.Text = vbNullString
        txtNamaAgent.Text = vbNullString
        txtAlamatAgent.Text = vbNullString
        txtKeterangan.Text = vbNullString
        If dsete.Tables("SALES_st").Rows.Count > 0 Then
           
            Dim rw As DataRow = dsete.Tables("SALES_st").Rows(0)
            dsete.Tables("SO").Clear()

            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp,case when Kd_Customer='UMUM' then nama_pnrm else Nama_Customer end as Nama_Customer,Kd_Customer, Tipe_trans  from sales.dbo.VSO_REP where  No_sp like '%SRV%' and no_sp = '" & rw("No_sp").ToString & "'", sqlconn))
            dadbe.Fill(dsete, "SO")

            txtNomor.Text = rw("no_sj").ToString
            tglRetur.Text = rw("Tgl_kirim").ToString
            DT_TglSO.EditValue = rw("Tgl_kirim")
            txtNomorRef.EditValue = rw("No_sp").ToString
            txtKendaraan.EditValue = rw("No_pol").ToString
            txtSopir.EditValue = rw("Kd_sopir").ToString
            txtKernet.EditValue = rw("kd_kenek").ToString
            txtKodeCust.Text = rw("kd_customer")
            txtNamaAgent.Text = rw("nama_agent")
            txtAlamatAgent.Text = rw("Almt_agen")
            txtKeterangan.Text = rw("Keterangan")

        End If
    End Sub
    Private Sub frmSuratJalanTarik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Tgl_sp, No_sp,case when Kd_Customer='UMUM' then nama_pnrm else Nama_Customer end as Nama_Customer,Kd_Customer, Tipe_trans from sales.dbo.VSO_REP where  Tipe_trans in  ('" & ServiceSpringUmum & "') and no_sp not in (select no_sp from sales.dbo.sales_st where status='OK')", sqlconn))
        dadbe.Fill(dsete, "SO")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kendaraan, (Nama_Kendaraan + '-' + No_Polisi) as Nama_Kendaraan from sif.dbo.SIF_Kendaraan", sqlconn))
        dadbe.Fill(dsete, "Kendaraan")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        dadbe.Fill(dsete, "Sopir")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang from sif.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "Barang")
        repBarang.DataSource = dsete.Tables("Barang")
        txtKendaraan.Properties.DataSource = dsete.Tables("Kendaraan")
        txtSopir.Properties.DataSource = dsete.Tables("Sopir")
        txtKernet.Properties.DataSource = dsete.Tables("Sopir")
        txtNomorRef.Properties.DataSource = dsete.Tables("SO")
        reloadTable("xxx")
        prn = frmMain
    End Sub
    Private Sub txtNomorRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomorRef.EditValueChanged
        If State = "ADD" Then
            If Not dsete.Tables("SALES_st_D") Is Nothing Then dsete.Tables("SALES_st_D").Clear()
            If txtNomorRef.EditValue.ToString <> "" Then
                loadBarang()
                txtNamaCust.Text = txtNomorRef.GetColumnValue("Nama_Customer").ToString
                txtKodeCust.Text = txtNomorRef.GetColumnValue("Kd_Customer").ToString
                tab.SelectedTabPage = tabSopir
                tab.SelectedTabPage = tabAlamat
                DXEP.SetError(txtNomorRef, "")
            End If
        End If
    End Sub
    Private Sub loadBarang()
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select b.*, (select isnull(sum(qty_kirim),0) from SALES.dbo.SALES_st_D a where a.no_sp = b.no_sp and a.no_seq_kirim=b.No_seq ) TOT from sales.dbo.sales_so_d as b " & _
                                                          " where  b.no_sp ='" & txtNomorRef.EditValue & "' ", sqlconn).ExecuteReader
        dsete.Tables("SALES_st_D").Clear()
        Dim i As Int16 = 1
        While dr.Read
            Dim rw As DataRow = dsete.Tables("SALES_st_D").NewRow
            rw("no_seq") = i : i += 1
            rw("No_sp") = dr("No_sp")
            rw("Qty_kirim") = dr("Qty")
            rw("QtySP") = dr("Qty")
            rw("Kd_stok") = dr("Kd_stok")
            rw("Deskripsi") = dr("Deskripsi")
            rw("Keterangan") = dr("Keterangan")
            rw("no_seq_box") = 0
            rw("Kd_satuan") = dr("Kd_satuan")
            rw("Kd_cabang") = kdcabang
            ' rw("tipe_trans") = txtKodeCust.Text = txtNomorRef.GetColumnValue("Tipe_trans").ToString
            rw("TotTarik") = dr("TOT")
            dsete.Tables("SALES_st_D").Rows.Add(rw)
        End While
        dr.Close()
        dr = Nothing
        txtKendaraan.EditValue = Nothing
        txtSopir.EditValue = Nothing
        txtKernet.EditValue = Nothing
    End Sub
    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim rw As DataRow
        Dim iserror As Boolean = False
        If txtNomorRef.Text = "" Then
            txtNomorRef.Focus()
            DXEP.SetError(txtNomorRef, "Harap Memilih Nomor DPB")
            iserror = True
        End If
        If iserror Then Exit Sub
        If State = "ADD" Then
            rw = dsete.Tables("SALES_st").NewRow
            rw("tipe_trans") = txtNomorRef.GetColumnValue("Tipe_trans").ToString
            rw("Kd_cabang") = kdcabang
            rw("Tgl_kirim") = DT_TglSO.EditValue
            rw("Tgl_balik") = DT_TglSO.EditValue
            rw("No_sp") = txtNomorRef.EditValue.ToString
            rw("kd_customer") = txtKodeCust.Text
        Else
            rw = dsete.Tables("SALES_st")(0)
          
        End If
        If Not txtKendaraan.EditValue Is Nothing Then rw("No_pol") = txtKendaraan.EditValue.ToString
        If Not txtSopir.EditValue Is Nothing Then rw("Kd_sopir") = txtSopir.EditValue.ToString
        If Not txtKernet.EditValue Is Nothing Then rw("kd_kenek") = txtKernet.EditValue.ToString
        rw("nama_agent") = txtNamaAgent.Text
        rw("Almt_agen") = txtAlamatAgent.Text
        rw("Keterangan") = txtKeterangan.Text

        rw("Program_Name") = Me.Name
        If State = "ADD" Then
            rw("Last_create_date") = Now
            rw("Last_created_by") = username
            dsete.Tables("SALES_st").Rows.Add(rw)
        Else
            rw("Last_update_date") = Now
            rw("Last_updated_by") = username
        End If

        For Each row As DataRow In dsete.Tables("SALES_st_D").Rows
            If State = "ADD" Then
                If row.RowState = DataRowState.Added Then
                    row.Item("no_sj") = txtNomor.Text
                    row.Item("Last_create_date") = Now
                    row.Item("Kd_cabang") = kdcabang
                    row.Item("tipe_trans") = rw("tipe_trans")

                    row.Item("Last_created_by") = username
                End If
            Else
                If row.RowState = DataRowState.Modified Then
                    row.Item("Last_update_date") = Now
                    row.Item("Last_updated_by") = username
                End If
            End If
        Next
        Try
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
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            If State = "ADD" Then
                dsete.Tables("SALES_st")(0)("no_sj") = getNumber(BTRANS)
                txtNomor.Text = dsete.Tables("SALES_ST")(0)("no_sj")
                For Each row As DataRow In dsete.Tables("SALES_ST_D").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("no_sj") = txtNomor.Text
                    End If
                Next
            End If

            DA.Update(dsete.Tables("SALES_ST"))
            DAD.Update(dsete.Tables("SALES_ST_D"))
            BTRANS.Commit()
            showMessages("Data Telah Disimpan")
            State = "EDIT"
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("SALES_ST").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsete.Tables("SALES_ST_D").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Function isYT() As Boolean
        If InStr("/Y", txtNomorRef.Text, CompareMethod.Text) > 0 Then
            isYT = True
        Else
            isYT = False
        End If
    End Function
    Function getNumber(ByVal btrans As SqlTransaction) As String
        Return getNoTrans("ST", getTanggal(btrans), btrans)
    End Function
    Private Sub txtKendaraan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txtketKendaraan.Text = txtKendaraan.EditValue
    End Sub
    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged

        If e.Column Is Qty_kirim Then
            Dim rw As DataRow = gv.GetRow(e.RowHandle).row
            rw("TotTarik") = rw("TotTarik") - old + rw("Qty_kirim")
        End If
    End Sub
    Private Sub gv_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanging
        If e.Column Is Qty_kirim Then
            old = gv.GetRow(e.RowHandle).item("Qty_kirim")
        End If
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim valid As Boolean = True
        If e.Row("Qty_kirim").ToString <> "" Then
            If e.Row("Qty_kirim") < 0 Then
                valid = False
                gv.SetColumnError(Qty_kirim, "Inputan Jumlah Kirim Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            ElseIf e.Row("TotTarik") > e.Row("QtySP") Then
                valid = False
                gv.SetColumnError(Qty_kirim, "Inputan Jumlah Kirim Harus Lebih Kecil Dengan Qty SP Service", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

        End If
        e.Valid = valid
    End Sub
    Private Sub txtSopir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txtKetSopir.Text = txtSopir.EditValue

    End Sub
    Private Sub txtKernet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txtKetKernet.Text = txtKernet.EditValue
    End Sub
    Public Sub cetak_click()
        Try
            prn.btnCetak.Enabled = False
            showMessages("Printing...", , "LOADING")
            Dim i As Int16 = New SqlCommand("update sales.dbo.SALES_ST set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sj='" & txtNomor.Text & "'", sqlconn).ExecuteNonQuery
            If kddep = KD_DIV_SPRING Then
                callReport(App_Path() & "\report\ST.rpt", "", "NO_ST=" & txtNomor.Text, True, True, "DIM")
            Else
                callReport(App_Path() & "\report\STSpon.rpt", "", "NO_ST=" & txtNomor.Text, True, True, "DIM")
            End If
            frmMessage.Hide()
            prn.btnCetak.Enabled = True
        Catch ex As Exception
            frmMessage.Hide()
            prn.btnCetak.Enabled = True
        End Try
    End Sub

    Private Sub txtNomorRef_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNomorRef.EditValueChanging
        If State = "EDIT" Then
            e.Cancel = True

        End If

    End Sub
End Class