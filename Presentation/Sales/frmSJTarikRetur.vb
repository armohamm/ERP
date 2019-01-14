Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSJTarikRetur
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
            If Not dsete.Tables("SOD") Is Nothing Then delete(dsete.Tables("SALES_SJ_D").Rows)
            If Not dsete.Tables("DSERVICE") Is Nothing Then delete(dsete.Tables("SALES_SJ").Rows)
            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select NO_SJ [Suraj Jalan] , tgl_kirim [Tanggal], NO_SP [Nomor SP] from sales.dbo.sales_Sj where no_sp like '%SRV%'", sqlconn)) '
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
        If Not dsete.Tables("SALES_SJ") Is Nothing Then dsete.Tables("SALES_SJ").Clear()
        If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_sj where no_sj='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_SJ")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.*, 0 QtySP, (select isnull(sum(qty_kirim),0) from SALES.dbo.SALES_sj_D B where B.no_sp = a.no_sp and a.no_seq_kirim=b.No_seq ) TotTarik from SALES.dbo.SALES_sj_D A where no_sj='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_SJ_D")
        gc.DataSource = dsete.Tables("SALES_SJ_D")
        txtNomor.Text = ""
        txtNomorRef.EditValue = vbNullString
        tglRetur.Text = Now
        txtKendaraan.EditValue = vbNullString
        txtSopir.EditValue = vbNullString
        txtKernet.EditValue = vbNullString
        txtKodeCust.Text = vbNullString
        txtNamaAgent.Text = vbNullString
        txtAlamatAgent.Text = vbNullString
        txtKeterangan.Text = vbNullString
        If dsete.Tables("SALES_SJ").Rows.Count > 0 Then
            Dim rw As DataRow = dsete.Tables("SALES_SJ").Rows(0)
            txtNomor.Text = rw("no_sj").ToString
            tglRetur.Text = rw("Tgl_kirim").ToString
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
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_retur, Nama_Customer,Kd_Customer, Tipe_trans  from sales.dbo.VRETUR_REP", sqlconn))
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
        If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()
        loadBarang()
        txtNamaCust.Text = txtNomorRef.GetColumnValue("Nama_Customer").ToString
        txtKodeCust.Text = txtNomorRef.GetColumnValue("Kd_Customer").ToString
        
        tab.SelectedTabPage = tabSopir
        tab.SelectedTabPage = tabAlamat
        DXEP.SetError(txtNomorRef, "")
    End Sub
    Private Sub loadBarang()
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select b.*, (select isnull(sum(qty_kirim),0) from SALES.dbo.SALES_sj_D a where a.no_sp = b.No_retur and a.no_seq_kirim=b.No_seq ) TOT from sales.dbo.sales_retur_d as b " & _
                                                          " where  b.No_retur ='" & txtNomorRef.EditValue & "' ", sqlconn).ExecuteReader
        dsete.Tables("SALES_SJ_D").Clear()
        Dim i As Int16 = 1
        While dr.Read
            Dim rw As DataRow = dsete.Tables("SALES_SJ_D").NewRow
            rw("no_seq") = i : i += 1
            rw("No_sp") = dr("No_retur")
            rw("Qty_kirim") = 0
            rw("QtySP") = dr("Qty")
            rw("Kd_stok") = dr("Kd_stok")
            rw("Kd_satuan") = dr("Kd_satuan")
            rw("Kd_cabang") = kdcabang
            rw("tipe_trans") = dr("tipe_trans")
            rw("TotTarik") = dr("TOT")
            dsete.Tables("SALES_SJ_D").Rows.Add(rw)
        End While
        dr.Close()
        dr = Nothing
        txtKendaraan.EditValue = Nothing
        txtSopir.EditValue = Nothing
        txtKernet.EditValue = Nothing
       
    End Sub
    Private Sub loadBarang_retur()
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select b.*, (select isnull(sum(qty_kirim),0) from SALES.dbo.SALES_sj_D a where a.no_sp = b.no_sp and a.kd_stok=b.No_retur ) TOT from sales.dbo.SALES_RETUR_D as b " & _
                                                          " where  b.No_retur ='" & txtNomorRef.EditValue & "' ", sqlconn).ExecuteReader
        dsete.Tables("SALES_SJ_D").Clear()
        Dim i As Int16 = 1
        While dr.Read
            Dim rw As DataRow = dsete.Tables("SALES_SJ_D").NewRow
            rw("no_seq") = i : i += 1
            rw("No_sp") = dr("No_retur")
            rw("Qty_kirim") = 0
            rw("QtySP") = dr("Qty")
            rw("Kd_stok") = dr("Kd_stok")
            rw("Kd_satuan") = dr("Kd_satuan")
            rw("Kd_cabang") = kdcabang
            rw("tipe_trans") = dr("tipe_trans").ToString
            rw("TotTarik") = dr("TOT")
            dsete.Tables("SALES_SJ_D").Rows.Add(rw)
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
        tabSopir.Focus()
        If txtKendaraan.Text = "" Then
            DXEP.SetError(txtKendaraan, "Harap Mengisi Kendaraan")
            txtKendaraan.Focus()
            iserror = True
        End If
        If txtSopir.Text = "" Then
            DXEP.SetError(txtSopir, "Harap Mengisi Sopir")
            txtSopir.Focus()
            iserror = True
        End If
        If iserror Then Exit Sub
        If State = "ADD" Then
            rw = dsete.Tables("SALES_SJ").NewRow
        Else
            rw = dsete.Tables("SALES_SJ")(0)
        End If
        rw("Kd_cabang") = kdcabang
        rw("tipe_trans") = txtNomorRef.GetColumnValue("Tipe_trans").ToString
        rw("no_sj") = txtNomor.Text
        rw("TglSj") = tglRetur.Text
        rw("No_sp") = txtNomorRef.EditValue.ToString
        rw("No_pol") = txtKendaraan.EditValue.ToString
        rw("Kd_sopir") = txtSopir.EditValue.ToString
        rw("kd_kenek") = txtKernet.EditValue.ToString
        rw("kd_customer") = txtKodeCust.Text
        rw("nama_agent") = txtNamaAgent.Text
        rw("Almt_agen") = txtAlamatAgent.Text
        rw("Keterangan") = txtKeterangan.Text

        rw("Program_Name") = Me.Name
        If State = "ADD" Then
            rw("Last_create_date") = getTanggal()
            rw("Last_created_by") = username
            dsete.Tables("SALES_SJ").Rows.Add(rw)
        Else
            rw("Last_update_date") = getTanggal()
            rw("Last_updated_by") = username
        End If

        For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
            If State = "ADD" Then
                If row.RowState = DataRowState.Added Then
                    row.Item("no_sj") = txtNomor.Text
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Kd_cabang") = kdcabang
                    row.Item("tipe_trans") = rw("tipe_trans")

                    row.Item("Last_created_by") = username
                End If
            Else
                If row.RowState = DataRowState.Modified Then
                    row.Item("Last_update_date") = getTanggal()
                    row.Item("Last_updated_by") = username
                End If
            End If
        Next
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
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
                dsete.Tables("SALES_SJ")(0)("no_sj") = getNumber(BTRANS)
                txtNomor.Text = dsete.Tables("SALES_SJ")(0)("no_sj")
                For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("no_sj") = txtNomor.Text
                    End If
                Next
            End If

            DA.Update(dsete.Tables("SALES_SJ"))
            DAD.Update(dsete.Tables("SALES_SJ_D"))
            BTRANS.Commit()
            showMessages("Saved..")
            State = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dsete.Tables("SALES_SJ").RejectChanges() ' untuk membatalkan row yg diupdate/insert
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
        Dim param As String
        If isYT() Then
            param = "SPSJY"
        Else
            param = "SPSJT"
        End If
        Return getNoTrans(param, getTanggal(btrans), btrans)
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
End Class