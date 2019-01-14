Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSJBatalKirim
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DABatal As SqlDataAdapter
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
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
        End With
    End Sub
    Public Sub add_click()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select NO_SJ Surat_Jalan , tgl_kirim [Tanggal], NO_SP [Nomor SP], (select Atas_nama from sales.dbo.sales_so a where a.no_sp = b.no_sp) as Customer  from sales.dbo.sales_Sj b where not (TGL_terima is null) and no_sj not in (select no_sj from sales.dbo.SALES_SJ_BATAL_KIRIM) order by NO_SJ", sqlconn)) '
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        'frmCari.GV.FormatConditions(0).Column = frmCari.GV.Columns(4)
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'If InStr("RTR", txtNoSo.Text, CompareMethod.Text) > 0 Then
            'reloadTableRTR(frmCari.row(0), reloadTable(frmCari.row(2)))
            'Else
            reloadTable(frmCari.row(0))
            'End If

            State = "ADD"
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
    Public Sub cancel_click()
        reloadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
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
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select NO_SJ Surat_Jalan , tgl_kirim [Tanggal], NO_SP [Nomor SP], (select Atas_nama from sales.dbo.sales_so a where a.no_sp = b.no_sp) as Customer from sales.dbo.sales_Sj b where not (TGL_terima is null) and no_sj in (select no_sj from sales.dbo.SALES_SJ_BATAL_KIRIM) order by NO_SJ", sqlconn)) '
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        'frmCari.GV.FormatConditions(0).Column = frmCari.GV.Columns(4)
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'If InStr("RTR", txtNoSo.Text, CompareMethod.Text) > 0 Then
            'reloadTableRTR(frmCari.row(0), reloadTable(frmCari.row(2)))
            'Else
            reloadTable(frmCari.row(0))
            'End If

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

        Dim nodpb As String = ""
        If Not dsete.Tables("SALES_SJ_BATAL") Is Nothing Then dsete.Tables("SALES_SJ_BATAL").Clear()
        If Not dsete.Tables("SALES_SJ") Is Nothing Then dsete.Tables("SALES_SJ").Clear()
        If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_sj where no_sj='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_SJ")
        If dsete.Tables("SALES_SJ").Rows.Count > 0 Then nodpb = dsete.Tables("SALES_SJ")(0)("no_dpb").ToString
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 Qty , sales.dbo.getDesc(tipe_trans, no_sp, no_seq_kirim, no_seq_box ) deskripsi , sales.dbo.getMaxKirim(no_sp, '" & nodpb & "' , no_seq_kirim,'0') TotKirim from SALES.dbo.SALES_sj_D where no_sj='" & kode & "' order by no_seq", sqlconn))
        DAD.Fill(dsete, "SALES_SJ_D")
        DABatal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_SJ_BATAL_KIRIM where no_sj='" & kode & "'", sqlconn))
        DABatal.Fill(dsete, "SALES_SJ_BATAL_KIRIM")
        For Each item In dsete.Tables("SALES_SJ_D").Rows
            If TypeOf item("Qty_balik") Is System.DBNull Then item("Qty_balik") = 0
        Next
        If dsete.Tables("SALES_SJ_D").Rows.Count > 0 Then
            txtNoSj.EditValue = dsete.Tables("SALES_SJ")(0)("no_sj").ToString
            tglSj.EditValue = dsete.Tables("SALES_SJ")(0)("TglSJ").ToString
            txtNamaAgent.Text = dsete.Tables("SALES_SJ")(0)("nama_agent").ToString
            txtAlamatAgent.Text = dsete.Tables("SALES_SJ")(0)("Almt_agen").ToString
            txtKeterangan.Text = dsete.Tables("SALES_SJ")(0)("Keterangan").ToString
            txtKendaraan.EditValue = dsete.Tables("SALES_SJ")(0)("No_pol").ToString
            txtSopir.EditValue = dsete.Tables("SALES_SJ")(0)("Kd_sopir").ToString
            tglTerima.EditValue = dsete.Tables("SALES_SJ")(0)("Tgl_terima").ToString
            jamTerima.EditValue = dsete.Tables("SALES_SJ")(0)("Jam_terima").ToString
            txtKernet.EditValue = dsete.Tables("SALES_SJ")(0)("kd_kenek").ToString
            tglTerima.Properties.MinValue = dsete.Tables("SALES_SJ")(0)("Tgl_kirim")
            tglTerima.Properties.MaxValue = dsete.Tables("SALES_SJ")(0)("Tgl_balik")
            If nodpb <> "" Then
                txtNomorRef.EditValue = nodpb
                txtNomorRef.Properties.ReadOnly = False
            Else
                txtNomorRef.Properties.ReadOnly = True
            End If
            If InStr(dsete.Tables("SALES_SJ")(0)("No_sp").ToString, "RTR", CompareMethod.Text) > 0 Then
                txtNoSo.Properties.DataSource = dsete.Tables("KIRIM2")
                gc.MainView = GVTarik
            Else
                txtNoSo.Properties.DataSource = dsete.Tables("KIRIM")
                If InStr(dsete.Tables("SALES_SJ")(0)("No_sp").ToString, "SRV", CompareMethod.Text) > 0 Then gc.MainView = gv
            End If
            txtNoSo.EditValue = dsete.Tables("SALES_SJ")(0)("No_sp").ToString
        Else
            tglSj.EditValue = vbNullString
            txtNamaAgent.Text = vbNullString
            txtAlamatAgent.Text = vbNullString
            txtKeterangan.Text = vbNullString
            txtKendaraan.EditValue = vbNullString
            txtSopir.EditValue = vbNullString
            txtKernet.EditValue = vbNullString
            txtNomorRef.EditValue = vbNullString
            txtNoSo.EditValue = vbNullString
            tglTerima.EditValue = vbNullString
            jamTerima.EditValue = vbNullString

        End If
        gc.DataSource = dsete.Tables("SALES_SJ_D")
    End Sub
    
    Private Sub frmDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_dpb, no_sj, No_sp from [sales].[dbo].[sales_sj] where not Tgl_balik is null ", sqlconn))
        dadbe.Fill(dsete, "DPB")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kendaraan, (Nama_Kendaraan + '-' + No_Polisi) as Nama_Kendaraan from sif.dbo.SIF_Kendaraan", sqlconn))
        dadbe.Fill(dsete, "Kendaraan")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        dadbe.Fill(dsete, "Sopir")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, Nama_Customer from [SALES].[dbo].[VSO_REP] where 1=0", sqlconn))
        dadbe.Fill(dsete, "KIRIM")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_retur as no_sp, Nama_Customer from [SALES].[dbo].VRetur_rep", sqlconn))
        dadbe.Fill(dsete, "KIRIM2")
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang from sif.dbo.SIF_Barang", sqlconn))
        'dadbe.Fill(dsete, "Barang")

        'repbarang.DataSource = dsete.Tables("Barang")
        txtKendaraan.Properties.DataSource = dsete.Tables("Kendaraan")
        txtSopir.Properties.DataSource = dsete.Tables("Sopir")
        txtKernet.Properties.DataSource = dsete.Tables("Sopir")

        tglSj.EditValue = Now

        txtNomorRef.Properties.DataSource = dsete.Tables("DPB")
        txtNoSo.Properties.DataSource = dsete.Tables("KIRIM")
        reloadTable("xxx")
        prn = frmMain
        'btnadd = False
        setStatus()
    End Sub
    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim rw As DataRow

        If gv.Columns("Qty_batal").SummaryItem.SummaryValue = 0 Then
            showMessages("Harap Mengisi Jumlah Batal", , "WARNING")
            tglTerima.Focus()
            Exit Sub
        End If
        If State = "ADD" Then
            rw = dsete.Tables("SALES_SJ_BATAL_KIRIM").NewRow
            rw("no_sj") = txtNoSj.EditValue
            rw("no_sp") = txtNoSo.Text
        Else
            rw = dsete.Tables("SALES_SJ_BATAL_KIRIM")(0)
        End If

        rw("Kd_cabang") = kdcabang
        rw("Tgl_batal") = getTanggal()
        rw("Last_create_date") = getTanggal()
        rw("Last_created_by") = username
        rw("Program_name") = username
        If State = "ADD" Then
            dsete.Tables("SALES_SJ_BATAL_KIRIM").Rows.Add(rw)
        Else
            rw("Last_update_date") = getTanggal()
            rw("Last_updated_by") = username
        End If
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DABatal)
            DABatal.UpdateCommand = myBuilder.GetUpdateCommand()
            DABatal.InsertCommand = myBuilder.GetInsertCommand()
            DABatal.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()
            DAD.InsertCommand = myBuilder.GetInsertCommand()
            DAD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DABatal.UpdateCommand.Transaction = BTRANS
            DABatal.InsertCommand.Transaction = BTRANS
            DABatal.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DABatal.Update(dsete.Tables("SALES_SJ_BATAL_KIRIM"))
            DAD.Update(dsete.Tables("SALES_SJ_D"))
            Dim cmd As New SqlCommand("update inv.dbo.INV_GUDANG_OUT_D set qty_batal = @jml where no_ref2=@dpb and no_sp_dtl = @no_sp_dtl and seq_dpb = @seq_dbp", sqlconn, BTRANS)
            For Each item As DataRow In dsete.Tables("SALES_SJ_D").Select("Qty_batal > 0")
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@jml", SqlDbType.Int, 10)
                cmd.Parameters.Add("@dpb", SqlDbType.VarChar, 100)
                cmd.Parameters.Add("@no_sp_dtl", SqlDbType.VarChar, 100)
                cmd.Parameters.Add("@seq_dbp", SqlDbType.VarChar, 100)
                cmd.Parameters("@jml").Value = item("Qty_batal")
                cmd.Parameters("@dpb").Value = txtNomorRef.Text
                cmd.Parameters("@no_sp_dtl").Value = item("no_seq_kirim")
                cmd.Parameters("@seq_dbp").Value = item("no_seq_box")
                cmd.ExecuteNonQuery()
            Next
            
            cmd = New SqlCommand
            cmd.Connection = sqlconn
            If Not BTRANS Is Nothing Then
                cmd.Transaction = BTRANS
            End If
            cmd.CommandText = "prod.[dbo].[prodp_upd_krm_batal_sj]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
            cmd.Parameters.Add("@vno_sp", SqlDbType.VarChar, 100)
            cmd.Parameters("@vno_trans").Value = rw("no_krm").ToString
            cmd.Parameters("@vno_sp").Value = txtNoSo.Text
            cmd.ExecuteNonQuery()

            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
            If isDelete Then
                State = ""
            Else
                State = "EDIT"
            End If

        Catch e As Exception
            BTRANS.Rollback()
            dsete.Tables("SALES_SJ_BATAL_KIRIM").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsete.Tables("SALES_SJ_D").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub txtNomorRef_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomorRef.EditValueChanged
        If txtNomorRef.EditValue <> "" Then
            txtNoSj.Text = dsete.Tables("SALES_SJ").Select("no_dpb='" & sender.editvalue & "'", "")(0)("No_sj")
            If Not dsete.Tables("KIRIM") Is Nothing Then dsete.Tables("KIRIM").Clear()
            txtNoSo.EditValue = vbNullString
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, Nama_Customer from [SALES].[dbo].[VSO_REP] where no_sp ='" & dsete.Tables("DPB").Select("no_dpb='" & sender.editvalue & "'", "")(0)("No_sp") & "'", sqlconn))
            dadbe.Fill(dsete, "KIRIM")
            txtNoSo.Properties.DataSource = dsete.Tables("KIRIM")
            txtNoSo.EditValue = txtNomorRef.GetColumnValue("No_sp").ToString
        End If
    End Sub
    Private Sub txtNoSo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSo.EditValueChanged
        If txtNoSo.EditValue <> "" Then
            'loadBarang()
            If InStr(dsete.Tables("SALES_SJ")(0)("No_sp").ToString, "RTR", CompareMethod.Text) > 0 Then
                txtNamaCustomer.Text = dsete.Tables("KIRIM2").Select("no_sp='" & sender.editvalue & "'")(0)("Nama_Customer")
                lblJenisSj.Text = ") Retur Barang"
            Else
                txtNamaCustomer.Text = dsete.Tables("KIRIM").Select("no_sp='" & sender.editvalue & "'")(0)("Nama_Customer")
                If InStr(dsete.Tables("SALES_SJ")(0)("No_sp").ToString, "SRV", CompareMethod.Text) > 0 Then
                    lblJenisSj.Text = ") Service"
                Else
                    lblJenisSj.Text = ") Penjualan Barang"
                End If
            End If

        Else
            txtNamaCustomer.Text = ""
            lblJenisSj.Text = ")"
        End If

    End Sub
    Private Sub txtSopir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txtKetSopir.Text = txtSopir.EditValue
    End Sub
    Private Sub txtKernet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txtKetKernet.Text = txtKernet.EditValue
    End Sub
    Private Sub txtKendaraan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txtketKendaraan.Text = txtKendaraan.EditValue
    End Sub
    Private Sub tglTerima_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglTerima.EditValueChanged
        jamTerima.EditValue = tglTerima.EditValue
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("Qty_batal") Is Nothing Then
            isValid = False
            gv.SetColumnError(Qty_batal, "Harap Mengisi Qty Batal Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_batal

        ElseIf e.Row("Qty_batal").ToString = "" Then
            isValid = False
            gv.SetColumnError(Qty_batal, "Harap Mengisi Qty Batal Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_batal

        ElseIf e.Row("Qty_batal") < 0 Then
            isValid = False
            gv.SetColumnError(Qty_batal, "Harap Mengisi Qty Batal Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_batal
        ElseIf e.Row("Qty_batal") > e.Row("Qty_kirim") Then
            isValid = False
            gv.SetColumnError(Qty_batal, "Qty Batal Lebih Besar Dari Qty Kirim.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_batal
            e.Row("Qty_batal") = e.Row("Qty_kirim")
        End If
        e.Valid = isValid
    End Sub
End Class