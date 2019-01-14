Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSuratJalan
    Dim dsete, dsete2 As New DataSet
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
    Dim myBuilder As New SqlCommandBuilder
    Public oldval As Int16
    Dim ppn As Boolean
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
        tglSj.Text = getTanggal().ToString
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
        txtNomorRef.EditValue = Nothing
        txtNoSo.EditValue = Nothing
        txtKendaraan.EditValue = Nothing
        txtSopir.EditValue = Nothing
        txtKernet.EditValue = Nothing
        txtKeterangan.Text = ""
        txtketKendaraan.Text = ""
        txtKetKernet.Text = ""
        txtKetSopir.Text = ""
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Surat Jalan ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select NO_SJ [Surat_Jalan] , tgl_kirim [Tanggal], NO_SP [Nomor SP] from sales.dbo.sales_Sj ", sqlconn)) '
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reloadTable(frmCari.row(0))
            If dsete.Tables("SALES_SJ")(0)("Tgl_kirim").ToString = "" Then
                btnSave = True
            Else
                btnSave = False
                btnDelete = False
            End If
            State = "EDIT"

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
        Dim nodpb As String = ""
        If Not dsete.Tables("SALES_SJ") Is Nothing Then dsete.Tables("SALES_SJ").Clear()
        If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_sj where no_sj='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_SJ")
        If dsete.Tables("SALES_SJ").Rows.Count > 0 Then nodpb = dsete.Tables("SALES_SJ")(0)("no_dpb").ToString
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select d.*, 0 Qty,  " & _
        " sales.dbo.getMaxKirim(d.no_sp, (select no_dpb from SALES.dbo.SALES_sj M where m.no_sj = d.no_sj) , no_seq_kirim)+sales.dbo.getMaxReceivedSP(d.no_sp, (select no_dpb from SALES.dbo.SALES_sj M where m.no_sj = d.no_sj) , no_seq_kirim) TotKirim " & _
        " from SALES.dbo.SALES_sj_D D where d.no_sj='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_SJ_D")
        If nodpb = "" Then
            txtNomorRef.EditValue = Nothing
            txtNoSo.EditValue = Nothing
            txtNomor.EditValue = Nothing
            tglSj.EditValue = Nothing
            txtNamaAgent.Text = Nothing
            txtAlamatAgent.Text = Nothing
            txtKeterangan.Text = Nothing
            txtKendaraan.EditValue = Nothing
            txtSopir.EditValue = Nothing
            txtKernet.EditValue = Nothing
        Else
            txtNomorRef.EditValue = nodpb
            txtNoSo.EditValue = dsete.Tables("SALES_SJ")(0)("No_sp").ToString
            txtNomor.EditValue = dsete.Tables("SALES_SJ")(0)("no_sj").ToString
            tglSj.EditValue = dsete.Tables("SALES_SJ")(0)("TglSJ").ToString
            txtNamaAgent.Text = dsete.Tables("SALES_SJ")(0)("nama_agent").ToString
            txtAlamatAgent.Text = dsete.Tables("SALES_SJ")(0)("Almt_agen").ToString
            txtKeterangan.Text = dsete.Tables("SALES_SJ")(0)("Keterangan").ToString
            txtKendaraan.EditValue = dsete.Tables("SALES_SJ")(0)("No_pol").ToString
            txtSopir.EditValue = dsete.Tables("SALES_SJ")(0)("Kd_sopir").ToString
            txtKernet.EditValue = dsete.Tables("SALES_SJ")(0)("kd_kenek").ToString
        End If
        gc.DataSource = dsete.Tables("SALES_SJ_D")
    End Sub
    Private Sub loadBarang()
        If State = "ADD" Then
            txtKendaraan.EditValue = vbNullString
            txtSopir.EditValue = vbNullString
            txtKernet.EditValue = vbNullString
            If txtNoSo.Text <> "" Then
                'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select *,  sales.dbo.getMaxKirim(no_sp,'',no_sp_dtl) TotKirim  from inv.dbo.INV_GUDANG_OUT_D where no_trans='" & txtNomorRef.GetColumnValue("no_trans").ToString & "'", sqlconn).ExecuteReader
                Dim dr As SqlDataReader = New SqlClient.SqlCommand("select *,  0 TotKirim  from inv.dbo.INV_GUDANG_OUT_D where no_trans='" & txtNomorRef.GetColumnValue("no_trans").ToString & "'", sqlconn).ExecuteReader
                dsete.Tables("SALES_SJ_D").Clear()
                Dim i As Int16 = 1
                While dr.Read
                    Dim rw As DataRow = dsete.Tables("SALES_SJ_D").NewRow
                    rw("No_sp") = dr("no_sp")
                    rw("TotKirim") = dr("TotKirim")
                    rw("no_seq_kirim") = dr("no_sp_dtl")
                    rw("no_seq") = i : i += 1
                    rw("Qty") = dr("qty_out")
                    rw("Qty_kirim") = dr("qty_out")
                    rw("Kd_stok") = dr("kd_stok")
                    rw("Kd_satuan") = dr("kd_satuan")
                    dsete.Tables("SALES_SJ_D").Rows.Add(rw)
                End While
                dr.Close()
                dr = Nothing
            Else
                dsete.Tables("SALES_SJ_D").Clear()

            End If
        End If
    End Sub
    Private Sub frmDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_dpb, [no_trans] from [INV].[dbo].[INV_GUDANG_OUT]", sqlconn))
        dadbe.Fill(dsete, "DPB")
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

        tglSj.EditValue = Now
        repBarang.DataSource = dsete.Tables("Barang")
        txtNomorRef.Properties.DataSource = dsete.Tables("DPB")
        txtNoSo.Properties.DataSource = dsete.Tables("KIRIM")
        reloadTable("xxx")
        prn = frmMain
        pnl.Height = prn.pnlDisplay2.Height - 15
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
        If txtNoSo.Text = "" Then
            txtNoSo.Focus()
            DXEP.SetError(txtNamaCustomer, "Harap Memilih Nomor SP")
            iserror = True
        End If
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
        If Not isDelete Then
            If State = "ADD" Then
                rw = dsete.Tables("SALES_SJ").NewRow
            Else
                rw = dsete.Tables("SALES_SJ")(0)
            End If
            rw("Kd_cabang") = kdcabang
            rw("tipe_trans") = txtNoSo.GetColumnValue("tipe_trans")
            
            rw("no_dpb") = txtNomorRef.EditValue
            rw("No_sp") = txtNoSo.EditValue
            rw("kd_customer") = txtKd_Customer.Text
            rw("TglSJ") = getTanggal()

            rw("No_pol") = txtketKendaraan.Text
            rw("Kd_sopir") = txtKetSopir.Text
            rw("kd_kenek") = txtKetKernet.Text
            rw("nama_agent") = txtNamaAgent.Text
            rw("Almt_agen") = txtAlamatAgent.Text
            rw("Keterangan") = txtKeterangan.Text

            rw("Program_Name") = Me.Name
            If State = "ADD" Then
                rw("Last_create_date") = rw("TglSJ")
                rw("Last_created_by") = username
                dsete.Tables("SALES_SJ").Rows.Add(rw)
            Else
                rw("Last_update_date") = getTanggal()
                rw("Last_updated_by") = username
            End If

            For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
                If State = "ADD" Then
                    If row.RowState = DataRowState.Added Then
                        row.Item("Last_create_date") = rw("TglSJ")
                        row.Item("Last_created_by") = username
                        row.Item("Kd_cabang") = kdcabang
                        row.Item("tipe_trans") = txtNoSo.GetColumnValue("tipe_trans")
                    End If
                Else
                    If row.RowState = DataRowState.Modified Then
                        row.Item("Last_update_date") = getTanggal()
                        row.Item("Last_updated_by") = username
                    End If
                End If
            Next
        Else
            For Each row As DataRow In dsete.Tables("SALES_SJ").Rows
                row.Delete()
            Next
            For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
                row.Delete()
            Next
        End If
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
                Dim nom As String
                If InStr("/Y", txtNoSo.Text, CompareMethod.Text) > 0 Then
                    nom = "SJY"
                Else
                    nom = "SJT"
                End If

                dsete.Tables("SALES_SJ")(0)("no_sj") = getNumber(BTRANS)
                txtNomor.Text = dsete.Tables("SALES_SJ")(0)("no_sj")
                For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("no_sj") = txtNomor.Text
                    End If
                Next
            End If

            dsete2 = dsete.Clone
            dsete2 = dsete.Copy
            DA.Update(dsete.Tables("SALES_SJ"))
            DAD.Update(dsete.Tables("SALES_SJ_D"))

            BTRANS.Commit()
            showMessages("Saved..")
            If isDelete Then
                State = ""

            Else
                State = "EDIT"
            End If

        Catch e As Exception
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")


        End Try
    End Sub
    Private Sub txtNomorRef_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
        Dim dr As SqlDataReader = New SqlCommand("Select * from prod.dbo.prod_rcn_krm_d where no_dpb='" & txtNomorRef.EditValue & "'", sqlconn).ExecuteReader
        Dim i As Int16 = 1
        While dr.Read
            Dim rw As DataRow
            rw = dsete.Tables("SALES_SJ_D").NewRow()
            rw("Kd_cabang") = "1"
            rw("tipe_trans") = "SPRING"
            rw("no_sj") = txtNomor.Text
            rw("no_seq") = i : i += 1
            rw("No_sp") = txtNoSo.EditValue.ToString
            rw("Kd_stok") = rw("kd_barang")
            rw("Kd_satuan") = ""
            rw("Qty_kirim") = 0
            rw("Keterangan") = ""
            rw("Last_create_date") = Now
            rw("Last_created_by") = umum.username
            rw("Program_name") = Me.Name
            dsete.Tables("SALES_SJ_D").Rows.Add(rw)
        End While
    End Sub
    Private Sub txtNomorRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomorRef.EditValueChanged
        If txtNomorRef.Text <> "" Then
            If Not dsete.Tables("KIRIM") Is Nothing Then dsete.Tables("KIRIM").Clear()
            txtNoSo.EditValue = vbNullString
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, Nama_Customer, Kd_Customer, tipe_trans, [Almt_pnrm] from [SALES].[dbo].[VSO_REP] where no_sp in (select no_sp from inv.dbo.INV_GUDANG_OUT_D where no_trans='" & txtNomorRef.GetColumnValue("no_trans").ToString & "')", sqlconn))
            dadbe.Fill(dsete, "KIRIM")
            txtNoSo.Properties.DataSource = dsete.Tables("KIRIM")
            loadBarang()
        End If
        DXEP.SetError(txtNomorRef, "")
    End Sub
    Private Sub txtNoSo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSo.EditValueChanged
        If txtNoSo.Text <> "" Then
            loadBarang()
            txtNamaCustomer.Text = txtNoSo.GetColumnValue("Nama_Customer").ToString
            txtKd_Customer.Text = txtNoSo.GetColumnValue("Kd_Customer").ToString
            Dim dr As SqlDataReader = New SqlCommand("select * from [PROD].[dbo].[PROD_dpb_m] where no_sp='" & txtNoSo.Text & "' and no_trans='" & txtNomorRef.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            tab.SelectedTabPage = tabSopir
            If dr.HasRows Then

                txtKendaraan.EditValue = dr("no_pol")
                txtSopir.EditValue = dr("kd_sopir")
                txtKernet.EditValue = dr("kd_kenek")

            End If
            dr.Close()
            tab.SelectedTabPage = tabAlamat
        Else
            txtNamaCustomer.Text = ""
            txtKendaraan.EditValue = Nothing
            txtKernet.EditValue = Nothing
            txtKernet.EditValue = Nothing
        End If
        DXEP.SetError(txtNoSo, "")
    End Sub
    Private Sub txtSopir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txtKetSopir.Text = ""
        If txtSopir.Text <> "" Then
            txtKetSopir.Text = txtSopir.EditValue
        End If
        DXEP.SetError(txtKetSopir, "")
    End Sub
    Private Sub txtKernet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txtKetKernet.Text = ""
        If txtKernet.Text <> "" Then
            txtKetKernet.Text = txtKernet.EditValue.ToString
        End If
    End Sub
    Private Sub txtKendaraan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txtketKendaraan.Text = txtKendaraan.EditValue
        DXEP.SetError(txtketKendaraan, "")
    End Sub
    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        If e.Column Is Qty_kirim Then
            Dim rw As DataRow = gv.GetRow(e.RowHandle).row
            rw("TotKirim") = rw("TotKirim") - oldval + rw("Qty_kirim")
        End If
    End Sub
    Private Sub gv_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanging
        If e.Column Is Qty_kirim Then
            oldval = IIf(gv.GetRow(e.RowHandle).item("Qty_kirim").ToString = "", 0, gv.GetRow(e.RowHandle).item("Qty_kirim"))
        End If
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        'Dim valid As Boolean = True
        'If e.Row("Qty_kirim").ToString <> "" Then
        '    If e.Row("Qty_kirim") < 0 Then
        '        valid = False
        '        gv.SetColumnError(Qty_kirim, "Inputan Jumlah Kirim Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    ElseIf e.Row("Qty") < e.Row("TotKirim") Then
        '        valid = False
        '        gv.SetColumnError(Qty_kirim, "Inputan Jumlah Kirim Melebihi Order", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    End If

        'End If
        'e.Valid = valid
    End Sub
    Function getNumber(ByVal btrans As SqlTransaction) As String
        Dim param As String
        If isYT() Then
            param = "SPSJY"
        Else
            param = "SPSJT"
        End If
        Return getNoTrans(param, getTanggal(btrans), btrans)
    End Function
    Function isYT() As Boolean
        If InStr("/Y", txtNoSo.Text, CompareMethod.Text) > 0 Then
            isYT = True
        Else
            isYT = False
        End If
    End Function
    Private Sub txtNomorRef_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNomorRef.QueryPopUp
        If State = "EDIT" Then
            e.Cancel = True
            showMessages("Tidak Dapat Edit Nomor DPB")
        End If
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" Then
            callReport(App_Path() & "\report\vSj.rpt", "", "NOSJ=" & txtNomor.Text, True)
        End If
    End Sub
End Class