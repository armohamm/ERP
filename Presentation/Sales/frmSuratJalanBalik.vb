Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSuratJalanBalik
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
    Dim myBuilder As New SqlCommandBuilder
    Public oldval As Int16
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
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
    End Sub
    Public Sub cancel_click()
        reloadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = False
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
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select NO_SJ Surat_Jalan , tgl_kirim [Tanggal], NO_SP [Nomor SP], (select Atas_nama from sales.dbo.sales_so a where a.no_sp = b.no_sp) as Customer ,case when TGL_terima is null then 'NEW' else 'EDIT' end [Status] from sales.dbo.sales_Sj b where not (TGL_Balik is null) AND isnull(sts_nota,'') <> 'NOTA' order by NO_SJ desc", sqlconn)) '
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
        If Not dsete.Tables("SALES_SJ") Is Nothing Then dsete.Tables("SALES_SJ").Clear()
        If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_sj where no_sj='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_SJ")
        If dsete.Tables("SALES_SJ").Rows.Count > 0 Then nodpb = dsete.Tables("SALES_SJ")(0)("no_dpb").ToString
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 Qty , sales.dbo.getDesc(tipe_trans, no_sp, no_seq_kirim, no_seq_box ) deskripsi , sales.dbo.getMaxKirim(no_sp, '" & nodpb & "' , no_seq_kirim,'0') TotKirim from SALES.dbo.SALES_sj_D where no_sj='" & kode & "' order by no_seq", sqlconn))
        DAD.Fill(dsete, "SALES_SJ_D")
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
            txtBiayaKirim.Value = IIf(TypeOf dsete.Tables("SALES_SJ")(0)("Biaya_kirim") Is DBNull, 0, dsete.Tables("SALES_SJ")(0)("Biaya_kirim"))
            If dsete.Tables("SALES_SJ")(0)("Biaya_kirim").ToString = "" Then txtBiayaKirim.EditValue = 0
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
            txtBiayaKirim.Value = 0
        End If
        gc.DataSource = dsete.Tables("SALES_SJ_D")
    End Sub
    'Private Sub reloadTableRTR(ByVal no_sj As String, ByVal no_sp As String)
    '    Dim nodpb As String = ""
    '    If Not dsete.Tables("SALES_SJ") Is Nothing Then dsete.Tables("SALES_SJ").Clear()
    '    If Not dsete.Tables("SALES_SJ_D") Is Nothing Then dsete.Tables("SALES_SJ_D").Clear()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_sj where no_sj='" & kode & "'", sqlconn))
    '    DA.Fill(dsete, "SALES_SJ")
    '    If dsete.Tables("SALES_SJ").Rows.Count > 0 Then nodpb = dsete.Tables("SALES_SJ")(0)("no_dpb").ToString
    '    DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 Qty , sales.dbo.getMaxKirim(no_sp, '" & nodpb & "' , no_seq_kirim) TotKirim from SALES.dbo.SALES_sj_D where no_sj='" & kode & "'", sqlconn))
    '    DAD.Fill(dsete, "SALES_SJ_D")

    '    If dsete.Tables("SALES_SJ_D").Rows.Count > 0 Then

    '        txtNomor.EditValue = dsete.Tables("SALES_SJ")(0)("no_sj").ToString

    '        tglSj.EditValue = dsete.Tables("SALES_SJ")(0)("Tgl_kirim").ToString
    '        txtNamaAgent.Text = dsete.Tables("SALES_SJ")(0)("nama_agent").ToString
    '        txtAlamatAgent.Text = dsete.Tables("SALES_SJ")(0)("Almt_agen").ToString
    '        txtKeterangan.Text = dsete.Tables("SALES_SJ")(0)("Keterangan").ToString
    '        txtKendaraan.EditValue = dsete.Tables("SALES_SJ")(0)("No_pol").ToString
    '        txtSopir.EditValue = dsete.Tables("SALES_SJ")(0)("Kd_sopir").ToString
    '        txtKernet.EditValue = dsete.Tables("SALES_SJ")(0)("kd_kenek").ToString
    '        If nodpb <> "" Then
    '            txtNomorRef.EditValue = nodpb
    '            txtNomorRef.Properties.ReadOnly = False
    '        Else
    '            txtNomorRef.Properties.ReadOnly = True
    '        End If

    '        gc.MainView = gv
    '        'txtNoSo.EditValue = dsete.Tables("SALES_SJ")(0)("No_sp").ToString
    '    Else

    '        txtNomor.EditValue = vbNullString

    '        tglSj.EditValue = vbNullString
    '        txtNamaAgent.Text = vbNullString
    '        txtAlamatAgent.Text = vbNullString
    '        txtKeterangan.Text = vbNullString
    '        txtKendaraan.EditValue = vbNullString
    '        txtSopir.EditValue = vbNullString
    '        txtKernet.EditValue = vbNullString
    '        txtNomorRef.EditValue = vbNullString
    '        txtNoSo.EditValue = vbNullString
    '        'If nodpb <> "" Then
    '        '    txtNomorRef.EditValue = vbNullString
    '        '    txtNomorRef.Properties.ReadOnly = False
    '        'Else
    '        '    txtNomorRef.Properties.ReadOnly = True
    '        'End If

    '    End If
    '    gc.DataSource = dsete.Tables("SALES_SJ_D")
    'End Sub
    Private Sub loadBarang()
        'If State = "ADD" Then
        '    Dim dr As SqlDataReader = New SqlClient.SqlCommand("select a.no_sp_dtl, sales.dbo.getMaxKirim(a.no_sp, a.no_dpb , a.no_sp_dtl) TotKirim, b.* , a.jumlah from  a, sales.dbo.sales_so_d as b " & _
        '                                                      " where b.no_seq=a.no_sp_dtl and a.no_sp=b.No_sp and no_dpb='" & txtNomorRef.EditValue & "' and a.no_sp='" & txtNoSo.EditValue & "' ", sqlconn).ExecuteReader
        '    dsete.Tables("SALES_SJ_D").Clear()
        '    Dim i As Int16 = 1
        '    While dr.Read
        '        Dim rw As DataRow = dsete.Tables("SALES_SJ_D").NewRow
        '        rw("No_sp") = dr("No_sp")
        '        rw("TotKirim") = dr("TotKirim")
        '        rw("no_seq_kirim") = dr("no_sp_dtl")
        '        rw("no_seq") = i : i += 1
        '        rw("Qty") = dr("jumlah")
        '        rw("Kd_stok") = dr("Kd_stok")
        '        rw("Kd_satuan") = dr("Kd_satuan")
        '        dsete.Tables("SALES_SJ_D").Rows.Add(rw)
        '    End While
        '    dr.Close()
        '    dr = Nothing
        'End If
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
        btnadd = False
        setStatus()
    End Sub
    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim rw As DataRow
        If Not isDelete Then
            If tglTerima.Text = "" Then
                showMessages("Harap Mengisi Tanggal Terima", , "WARNING")
                tglTerima.Focus()
                Exit Sub
            End If
            If jamTerima.Text = "" Then
                showMessages("Harap Mengisi Jam Terima ", , "WARNING")
                jamTerima.Focus()
                Exit Sub
            End If
            rw = dsete.Tables("SALES_SJ")(0)
            rw("Tgl_terima") = tglTerima.EditValue
            rw("Jam_terima") = jamTerima.EditValue
            rw("Last_update_date") = Now
            rw("Last_updated_by") = username
            rw("Biaya_kirim") = txtBiayaKirim.EditValue

            For Each row As DataRow In dsete.Tables("SALES_SJ_D").Rows
                If TypeOf row("Qty_balik") Is System.DBNull Then row("Qty_balik") = 0
                row.Item("Last_update_date") = getTanggal()
                row.Item("Last_updated_by") = username
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

            DA.Update(dsete.Tables("SALES_SJ"))
            DAD.Update(dsete.Tables("SALES_SJ_D"))

            Dim cmd As New SqlCommand
            cmd.Connection = sqlconn
            If Not BTRANS Is Nothing Then
                cmd.Transaction = BTRANS
            End If
            cmd.CommandText = "SALES.[dbo].[CloseSp]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@no_sp", SqlDbType.VarChar, 100)
            cmd.Parameters("@no_sp").Value = txtNoSo.Text
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand
            cmd.Connection = sqlconn
            If Not BTRANS Is Nothing Then
                cmd.Transaction = BTRANS
            End If
            cmd.CommandText = "prod.[dbo].[prodp_upd_krm_balik]"
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
            dsete.Tables("SALES_SJ").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsete.Tables("SALES_SJ_D").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub txtNomorRef_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs)
        'Dim dr As SqlDataReader = New SqlCommand("Select * from prod.dbo.prod_rcn_krm_d where no_dpb='" & txtNomorRef.EditValue & "'", sqlconn).ExecuteReader
        'Dim i As Int16 = 1
        'While dr.Read
        '    Dim rw As DataRow
        '    rw = dsete.Tables("SALES_SJ_D").NewRow()
        '    rw("Kd_cabang") = "1"
        '    rw("tipe_trans") = "SPRING"
        '    rw("no_sj") = txtNomor.Text
        '    rw("no_seq") = i : i += 1
        '    rw("No_sp") = txtNoSo.EditValue.ToString
        '    rw("Kd_stok") = rw("kd_barang")
        '    rw("Kd_satuan") = ""
        '    rw("Qty_kirim") = 0
        '    rw("Keterangan") = ""
        '    rw("Last_create_date") = Now
        '    rw("Last_created_by") = umum.username
        '    rw("Program_name") = Me.Name
        '    dsete.Tables("SALES_SJ_D").Rows.Add(rw)
        'End While
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
        loadBarang()
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
    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        Dim rw As DataRow = gv.GetRow(e.RowHandle).row
        If e.Column Is Qty_kirim Then
            rw("TotKirim") = rw("TotKirim") - oldval + rw("Qty_kirim")
        End If
        If e.Column Is Qty_balik Then
            If e.Value = 0 Then rw("Kirim_Ulang") = Nothing

        End If
    End Sub
    Private Sub gv_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanging
        If e.Column Is Qty_kirim Then
            oldval = IIf(gv.GetRow(e.RowHandle).item("Qty_kirim").ToString = "", 0, gv.GetRow(e.RowHandle).item("Qty_kirim"))
        End If
    End Sub
    Private Sub tglTerima_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglTerima.EditValueChanged
        jamTerima.EditValue = tglTerima.EditValue
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("Qty_balik") Is Nothing Then
            isValid = False
            gv.SetColumnError(Qty_balik, "Harap Mengisi Qty Balik Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_balik

        ElseIf e.Row("Qty_balik").ToString = "" Then
            isValid = False
            gv.SetColumnError(Qty_balik, "Harap Mengisi Qty Balik Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_balik

        ElseIf e.Row("Qty_balik") < 0 Then
            isValid = False
            gv.SetColumnError(Qty_balik, "Harap Mengisi Qty Balik Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_balik
        ElseIf e.Row("Qty_balik") > e.Row("Qty_kirim") - e.Row("Qty_batal") Then
            isValid = False
            gv.SetColumnError(Qty_balik, "Qty Balik Lebih Besar Dari Qty Kirim.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Qty_balik
        ElseIf e.Row("Kirim_Ulang") Is Nothing Then
            isValid = False
            gv.SetColumnError(Kirim_Ulang, "Harap Mengisi Status kirim Balik Atau Tidak.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Kirim_Ulang
        End If
        e.Valid = isValid
    End Sub
    Private Sub txtBiayaKirim_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles txtBiayaKirim.Spin
        e.Handled = True
    End Sub
End Class