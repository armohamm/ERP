'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormLunasHutangLain
    Public btnadd As Boolean = True
    Public btnEdit As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnSave As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsHutang, dsCari As New DataSet
    Dim daHutang, daHutangD, daLookUp, daCari As SqlDataAdapter
    Dim drHutang As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim err, bukubesar, ppn As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = False
        Me.Enabled = True
        setStatus()
        loadData("xxx")
        controlOff(False)
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        txtNoTrans.Properties.ReadOnly = stat
        dteTanggal.Properties.ReadOnly = stat
        lookSupplier.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        lookValuta.Properties.ReadOnly = stat
        txtValuta.Properties.ReadOnly = stat
        lookBayar.Properties.ReadOnly = stat
        lookBank.Properties.ReadOnly = stat
        lookGiro.Properties.ReadOnly = stat
        txtGiro.Properties.ReadOnly = stat
        txtBayar.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvHutang.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub clear()
        txtNoTrans.EditValue = vbNullString
        dteTanggal.EditValue = getTanggal()
        lookSupplier.ItemIndex = 0
        txtNoRef.EditValue = vbNullString
        lookValuta.EditValue = "IDR"
        txtValuta.EditValue = 1
        lookBayar.EditValue = "03"
        lookBank.EditValue = vbNullString
        lookGiro.EditValue = vbNullString
        txtGiro.EditValue = 0
        txtBayar.EditValue = 0
        txtKet.EditValue = vbNullString
        lblSelisih.Text = vbNullString
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsHutang.Tables("Hutang") Is Nothing Then dsHutang.Tables("Hutang").Clear()
        If Not dsHutang.Tables("HutangD") Is Nothing Then dsHutang.Tables("HutangD").Clear()

        daHutang = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHutang.Fill(dsHutang, "Hutang")
        daHutangD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHutangD.Fill(dsHutang, "HutangD")
        gcHutang.DataSource = dsHutang.Tables("HutangD")
        gvHutang.BestFitColumns()

        If dsHutang.Tables("Hutang").Rows.Count > 0 Then
            txtNoTrans.EditValue = dsHutang.Tables("Hutang").Rows(0)("no_trans")
            dteTanggal.EditValue = dsHutang.Tables("Hutang").Rows(0)("tgl_trans")
            txtNoRef.EditValue = dsHutang.Tables("Hutang").Rows(0)("no_ref1")
            lookSupplier.EditValue = dsHutang.Tables("Hutang").Rows(0)("kd_kartu")
            lookValuta.EditValue = dsHutang.Tables("Hutang").Rows(0)("kd_valuta")
            txtValuta.EditValue = dsHutang.Tables("Hutang").Rows(0)("kurs_valuta")
            lookBayar.EditValue = dsHutang.Tables("Hutang").Rows(0)("jns_bayar")
            lookGiro.EditValue = dsHutang.Tables("Hutang").Rows(0)("kd_giro")
            lookBank.EditValue = dsHutang.Tables("Hutang").Rows(0)("kd_bank")
            txtKet.EditValue = dsHutang.Tables("Hutang").Rows(0)("keterangan")
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                If Not isDelete Then
                    If STATE = "ADD" Then
                        txtNoTrans.EditValue = getNoTrans("JKK", getTanggal())
                        row = dsHutang.Tables("Hutang").NewRow
                        row.Item("Kd_cabang") = getKodeCabang()
                        row.Item("tipe_trans") = IIf(lookBayar.EditValue = "03", "JKK-KUT-03", "JKK-KUT-07")
                        row.Item("no_trans") = txtNoTrans.EditValue
                        row.Item("thnbln") = Format(dteTanggal.EditValue, "yyyyMM")
                        row.Item("Last_create_date") = getTanggal()
                        row.Item("Last_created_by") = username
                        row.Item("program_name") = Me.Name
                    ElseIf STATE = "EDIT" Then
                        row = dsHutang.Tables("Hutang").Rows(0)
                        row("Last_update_date") = getTanggal()
                        row("Last_updated_by") = umum.username
                    End If

                    row.Item("tgl_trans") = dteTanggal.EditValue
                    row.Item("no_ref1") = txtNoRef.EditValue
                    row.Item("kd_kartu") = lookSupplier.EditValue
                    row.Item("kd_valuta") = lookValuta.EditValue
                    row.Item("kurs_valuta") = txtValuta.EditValue
                    row.Item("jml_val_trans") = IIf(gvHutang.Columns("jml_bayar").SummaryText = vbNullString, 0, gvHutang.Columns("jml_bayar").SummaryText)
                    row.Item("jml_rp_trans") = IIf(gvHutang.Columns("jml_bayar").SummaryText = vbNullString, 0, gvHutang.Columns("jml_bayar").SummaryText * txtValuta.EditValue)
                    row.Item("jns_bayar") = lookBayar.EditValue
                    row.Item("kd_giro") = lookGiro.EditValue
                    row.Item("kd_bank") = IIf(lookBank.EditValue = vbNullString, 0, lookBank.EditValue)
                    row.Item("keterangan") = txtKet.EditValue

                    If STATE = "ADD" Then
                        dsHutang.Tables("Hutang").Rows.Add(row)
                    End If

                    For Each rw As DataRow In dsHutang.Tables("HutangD").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw("Kd_Cabang") = getKodeCabang()
                            rw("tipe_trans") = IIf(lookBayar.EditValue = "03", "JKK-KUT-03", "JKK-KUT-07")
                            'rw("kd_buku_besar") = bukubesar
                            rw("no_trans") = txtNoTrans.EditValue
                            rw("Last_create_date") = getTanggal()
                            rw("kd_kartu") = lookSupplier.EditValue
                            rw("Last_created_by") = username
                            rw("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw("Last_update_date") = getTanggal()
                            rw("Last_updated_by") = username
                        End If
                    Next
                End If
            Else
                MsgBox("Kesalahan dalam pengisian data :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
                Exit Sub
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daHutang)
            daHutang.UpdateCommand = myBuilder.GetUpdateCommand()
            daHutang.InsertCommand = myBuilder.GetInsertCommand()
            daHutang.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlCommandBuilder(daHutangD)
            daHutangD.UpdateCommand = myBuilder.GetUpdateCommand()
            daHutangD.InsertCommand = myBuilder.GetInsertCommand()
            daHutangD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daHutang.UpdateCommand.Transaction = BTRANS
            daHutang.InsertCommand.Transaction = BTRANS
            daHutang.DeleteCommand.Transaction = BTRANS

            daHutangD.UpdateCommand.Transaction = BTRANS
            daHutangD.InsertCommand.Transaction = BTRANS
            daHutangD.DeleteCommand.Transaction = BTRANS

            daHutang.Update(dsHutang.Tables("Hutang"))
            daHutangD.Update(dsHutang.Tables("HutangD"))

            dsHutang.Tables("Hutang").AcceptChanges()
            dsHutang.Tables("HutangD").AcceptChanges()

            If Not isDelete Then
                call_procedure(IIf(lookBayar.EditValue = "03", "JKK-KUT-03", "JKK-KUT-07"), txtNoTrans.EditValue, BTRANS)
            End If

            BTRANS.Commit()
            If Not isDelete Then
                showMessages("Berhasil disimpan.")
                If STATE = "EDIT" Then
                    btnDelete = False
                    setStatus()
                End If
                clear()
                loadData("XXX")
            Else
                showMessages("Berhasil dihapus.")
                cancel_click()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsHutang.Tables("Hutang").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsHutang.Tables("HutangD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub cetak_click()
        If Not txtNoTrans.EditValue = "" Then
            'callReport(App_Path() & "\report\repPenyesuaianHPP.rpt", "", "nomor=" & txtNoTrans.EditValue, True)
        End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cancel_click()
        STATE = ""
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnDelete = False
        btnSave = False
        setStatus()
        Me.Enabled = False
        clear()
        loadData("XXX")
    End Sub

    Private Sub cek()
        isvalid = True
        If lookSupplier.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookSupplier, "Supplier tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookSupplier, "")
        End If
        If Not lookValuta.EditValue = "IDR" Then
            If txtValuta.EditValue = 1 Then
                isvalid = False
                DxErrorProvider1.SetError(txtValuta, "Valuta non rupiah tidak boleh 1.")
            Else
                DxErrorProvider1.SetError(txtValuta, "")
            End If
        ElseIf lookValuta.EditValue = "IDR" Then
            If txtValuta.EditValue > 1 Then
                isvalid = False
                DxErrorProvider1.SetError(txtValuta, "Valuta rupiah harus 1.")
            Else
                DxErrorProvider1.SetError(txtValuta, "")
            End If
        End If
        If lookBayar.EditValue = "01" Or lookBayar.EditValue = "02" Then
            If lookGiro.EditValue = vbNullString Then
                isvalid = False
                DxErrorProvider1.SetError(lookGiro, "Giro tidak boleh kosong.")
            Else
                DxErrorProvider1.SetError(lookGiro, "")
            End If
        ElseIf lookBayar.EditValue = "04" Then
            If lookBank.EditValue = vbNullString Then
                isvalid = False
                DxErrorProvider1.SetError(lookBank, "Bank tidak boleh kosong.")
            Else
                DxErrorProvider1.SetError(lookBank, "")
            End If
        End If
        If gvHutang.RowCount = 0 Then
            If STATE = "ADD" Then
                isvalid = False
                err &= "Detil belum diisi." & vbCrLf
            End If
        End If
    End Sub

    Private Sub loadSupplier()
        If Not dsCari.Tables("Supplier") Is Nothing Then dsCari.Tables("Supplier").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier where Rec_Stat = 'Y' order by Nama_Supplier", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsCari, "Supplier")
        lookSupplier.Properties.DataSource = dsCari.Tables("Supplier")
        lookSupplier.Properties.DisplayMember = "Nama_Supplier"
        lookSupplier.Properties.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadValuta()
        If Not dsCari.Tables("Valuta") Is Nothing Then dsCari.Tables("Valuta").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsCari, "Valuta")
        lookValuta.Properties.DataSource = dsCari.Tables("Valuta")
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
        lookValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadInvoice()
        If Not dsCari.Tables("Invoice") Is Nothing Then dsCari.Tables("Invoice").Clear()

        If STATE = "ADD" Then
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select x.* from FIN.dbo.FIN_PEMBELIAN X where X.kd_supplier='" & lookSupplier.EditValue & "' and X.kd_valuta='" & lookValuta.EditValue & "' and X.tipe_trans ='JKM-KUT-01' and not (x.no_posting is null or x.no_posting='') and X.jml_akhir>0 ", sqlconn))
        Else
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select x.* from FIN.dbo.FIN_PEMBELIAN X where X.kd_supplier='" & lookSupplier.EditValue & "' and X.kd_valuta='" & lookValuta.EditValue & "' and X.tipe_trans ='JKM-KUT-01' and not (x.no_posting is null or x.no_posting='')", sqlconn))
        End If

        daLookUp.Fill(dsCari, "Invoice")
        lookInv.DataSource = dsCari.Tables("Invoice")
        lookInv.DisplayMember = "no_inv"
        lookInv.ValueMember = "no_inv"
    End Sub

    Private Sub loadBank()
        If Not dsCari.Tables("Bank") Is Nothing Then dsCari.Tables("Bank").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank from SIF.dbo.SIF_Bank", sqlconn))
        daLookUp.Fill(dsCari, "Bank")
        lookBank.Properties.DataSource = dsCari.Tables("Bank")
        lookBank.Properties.ValueMember = "kd_bank"
        lookBank.Properties.DisplayMember = "nama_bank"
    End Sub

    Private Sub loadJenisBayar()
        If Not dsCari.Tables("Jenis") Is Nothing Then dsCari.Tables("Jenis").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Desc_Data, Id_Data from sif.dbo.SIF_gen_reff_d where id_ref_data='JNSBYR'", sqlconn))
        daLookUp.Fill(dsCari, "Jenis")
        lookBayar.Properties.DataSource = dsCari.Tables("Jenis")
        lookBayar.Properties.DisplayMember = "Desc_Data"
        lookBayar.Properties.ValueMember = "Id_Data"
    End Sub

    Private Sub loadGiro()
        If Not dsCari.Tables("Giro") Is Nothing Then dsCari.Tables("Giro").Clear()

        If lookSupplier.EditValue = vbNullString Then
            lookGiro.Enabled = False
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where jns_giro='" & lookBayar.EditValue & "' and kd_valuta='" & lookValuta.EditValue & "' and jns_trans='BELI' and tipe_trans='JRR-KUT-01' and status LIKE 'KELUAR%' and nomor not in (select kd_giro from FIN.dbo.FIN_BELI_LUNAS) AND NOT (no_jur IS NULL OR no_jur = '')", sqlconn))
        Else
            lookGiro.Enabled = True
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan, tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kartu='" & lookSupplier.EditValue & "' and jns_giro='" & lookBayar.EditValue & "' and kd_valuta='" & lookValuta.EditValue & "' and jns_trans='BELI' and tipe_trans='JRR-KUT-01' and status LIKE 'KELUAR%' and nomor not in (select distinct isnull(kd_giro,'kosong') from FIN.dbo.FIN_BELI_LUNAS) AND NOT (no_jur IS NULL OR no_jur = '')", sqlconn))
        End If

        daLookUp.Fill(dsCari, "Giro")
        lookGiro.Properties.DataSource = dsCari.Tables("Giro")
        lookGiro.Properties.DisplayMember = "nomor"
        lookGiro.Properties.ValueMember = "nomor"
    End Sub

    Private Sub aFormHPP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadSupplier()
        loadValuta()
        loadJenisBayar()
        loadBank()
        STATE = "ADD"
        clear()
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        If Not dsCari.Tables("LookHutang") Is Nothing Then dsCari.Tables("LookHutang").Clear()

        daCari = New SqlDataAdapter(New SqlCommand("select a.no_trans as 'No. Trans', a.tgl_trans as 'Tanggal', b.Nama_Supplier as 'Supplier', a.no_posting as 'No. Posting', a.jml_val_trans as 'Jumlah', CASE WHEN (c.Desc_Data = 'Giro' OR c.Desc_Data = 'Cek') THEN c.Desc_Data + ' : ' + a.kd_giro ELSE CASE WHEN c.Desc_Data = 'Transfer' THEN c.Desc_Data + ' : ' + (SELECT x.nama_bank FROM SIF.dbo.SIF_Bank x, FIN.dbo.FIN_BELI_LUNAS y WHERE x.kd_bank = y.kd_bank AND y.no_trans = a.no_trans) ELSE c.Desc_Data END END as 'Pembayaran' from FIN.dbo.FIN_BELI_LUNAS a, SIF.dbo.SIF_Supplier b, sif.dbo.SIF_Gen_Reff_D c where a.kd_kartu = b.Kode_Supplier AND a.Jns_bayar = c.Id_Data AND c.Id_Ref_data='JNSBYR' AND a.tipe_trans IN ('JKK-KUT-03','JKK-KUT-07')order by tgl_trans", sqlconn)) '<- query buat ditampilkan di LOV
        daCari.Fill(dsCari, "LookHutang")
        frmCari.set_dso(dsCari.Tables("LookHutang"))
        frmCari.GV.Columns("Tanggal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Trans"))

            If Not (frmCari.row("No. Posting") = "" Or frmCari.row("No. Posting") = vbNullString) Then
                MsgBox("No. Transaksi: " & txtNoTrans.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                setStatus()
                controlOff(True)
            Else
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                setStatus()
                controlOff(False)
            End If
        Else
            cancel_click()
        End If
    End Sub

    Public Sub delete_click()
        If Not txtNoTrans.EditValue = vbNullString Then
            If MsgBox("Hapus pelunasan hutang dengan nomor " & txtNoTrans.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                'STATE = "DELETE"
                For Each rw As DataRow In dsHutang.Tables("Hutang").Rows
                    Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur='" & txtNoTrans.EditValue & "'", sqlconn, BTRANS)
                    sqlx.ExecuteNonQuery()
                    rw.Delete()
                Next
                For Each rw As DataRow In dsHutang.Tables("HutangD").Rows
                    Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal_D where no_jur='" & txtNoTrans.EditValue & "'", sqlconn, BTRANS)
                    sqlx.ExecuteNonQuery()
                    rw.Delete()
                Next
                save_click(True)
            End If
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If gvHutang.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvHutang.RowCount - 1
                gvHutang.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub gcHPP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcHutang.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvHutang.GetSelectedRows.Count > 0 Then
                gvHutang.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub gvHPP_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvHutang.CellValueChanged
        Dim View As ColumnView = sender

        If e.Column Is prev_no_inv Then
            If Not dsCari.Tables("LoadBeliLunas") Is Nothing Then dsCari.Tables("LoadBeliLunas").Clear()

            daCari = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv ='" & gvHutang.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
            daCari.Fill(dsCari, "LoadBeliLunas")

            View.SetRowCellValue(e.RowHandle, "jml_tagihan", dsCari.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
            View.SetRowCellValue(e.RowHandle, "kd_buku_besar", dsCari.Tables("LoadBeliLunas").Rows(0).Item("kd_buku_besar").ToString)
            If txtBayar.EditValue = 0 Then
                View.SetRowCellValue(e.RowHandle, "jml_piut", dsCari.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
            Else
                View.SetRowCellValue(e.RowHandle, "jml_piut", txtBayar.EditValue)
                If View.GetRowCellValue(e.RowHandle, "jml_piut") > View.GetRowCellValue(e.RowHandle, "jml_tagihan") Then
                    View.SetRowCellValue(e.RowHandle, "jml_piut", dsCari.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
                End If
            End If
        End If

        If e.Column Is jml_piut Then
            'View.SetRowCellValue(e.RowHandle, "jml_piut", e.Value * txtValuta.EditValue)
            View.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(View.GetFocusedRowCellValue("jml_piut"), 0) + isNull(View.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(View.GetFocusedRowCellValue("jml_admin"), 0) - isNull(View.GetFocusedRowCellValue("jml_diskon"), 0))
        End If

        If e.Column Is jml_pembulatan Then
            'View.SetRowCellValue(e.RowHandle, "jml_pembulatan", e.Value * txtValuta.EditValue)
            View.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(View.GetFocusedRowCellValue("jml_piut"), 0) + isNull(View.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(View.GetFocusedRowCellValue("jml_admin"), 0) - isNull(View.GetFocusedRowCellValue("jml_diskon"), 0))

            Dim jumlah As Double
            Dim x As Object

            x = CType(gcHutang.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            For i = 0 To gcHutang.FocusedView.RowCount - 1
                jumlah += gcHutang.FocusedView.GetRow(i).Item("jml_bayar")
            Next
            lblSelisih.Text = "Selisih : " & CStr(formatNumber(CStr(txtBayar.EditValue - jumlah)))
        End If

        If e.Column Is jml_admin Then
            'View.SetRowCellValue(e.RowHandle, "jml_admin", e.Value * txtValuta.EditValue)
            View.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(View.GetFocusedRowCellValue("jml_piut"), 0) + isNull(View.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(View.GetFocusedRowCellValue("jml_admin"), 0) - isNull(View.GetFocusedRowCellValue("jml_diskon"), 0))
        End If

        If e.Column Is jml_diskon Then
            'View.SetRowCellValue(e.RowHandle, "jml_diskon", e.Value * txtValuta.EditValue)
            View.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(View.GetFocusedRowCellValue("jml_piut"), 0) + isNull(View.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(View.GetFocusedRowCellValue("jml_admin"), 0) - isNull(View.GetFocusedRowCellValue("jml_diskon"), 0))
        End If
    End Sub

    Private Sub gvHPP_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvHutang.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvHutang.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_piut"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_admin"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_diskon"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_pembulatan"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_bayar"), 0)
    End Sub

    Private Sub gvHutang_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvHutang.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvHutang_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvHutang.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvHutang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvHutang.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim x As Object
            x = CType(gcHutang.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.DeleteSelectedRows()
            For i = 0 To gcHutang.FocusedView.RowCount - 1
                gcHutang.FocusedView.GetRow(i).Item("no_seq") = i + 1
            Next
        End If
    End Sub

    Private Sub gvHutang_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvHutang.RowUpdated
        Dim jumlah As Double
        Dim x As Object

        x = CType(gcHutang.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To gcHutang.FocusedView.RowCount - 1
            jumlah += gcHutang.FocusedView.GetRow(i).Item("jml_bayar")
        Next
        lblSelisih.Text = "Selisih : " & CStr(formatNumber(CStr(txtBayar.EditValue - jumlah)))
    End Sub

    Private Sub gvHutang_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvHutang.ValidateRow
        'Dim view As ColumnView = CType(sender, ColumnView)
        'Dim column1 As GridColumn = view.Columns("jml_tagihan")
        'Dim column2 As GridColumn = view.Columns("jml_admin")
        'Dim column3 As GridColumn = view.Columns("jml_diskon")
        'Dim column4 As GridColumn = view.Columns("jml_pembulatan")
        'Dim column5 As GridColumn = view.Columns("jml_bayar")

        'If view.GetRowCellValue(e.RowHandle, column5) > view.GetRowCellValue(e.RowHandle, column1) Then
        '    e.Valid = False
        '    view.SetColumnError(column3, "Penambahan jumlah bayar terlalu banyak, tidak boleh melebihi tagihan.")
        'End If
    End Sub

    Private Sub gvHPP_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvHutang.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "jml_bayar" Then
            If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
                e.Valid = False
                e.ErrorText = "Tidak boleh lebih dari hutang/tagihan"
            End If
        End If

        If vx.FocusedColumn.FieldName = "prev_no_inv" Then
            If Not gvHutang.RowCount <= 0 Then
                Dim noInv As String = e.Value
                For i As Integer = 0 To gvHutang.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If noInv = vx.GetRowCellValue(i, prev_no_inv) Then
                        e.Valid = False
                        e.ErrorText = "Nota sudah ada, mohon pilih nota yang lain."
                    End If
                Next
            End If
        End If

        If vx.FocusedColumn.FieldName = "jml_piut" Then
            If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
                e.Valid = False
                e.ErrorText = "Tidak boleh lebih dari hutang/tagihan"
            End If
        End If
    End Sub

    Private Sub lookSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookSupplier.EditValueChanged
        loadInvoice()
        loadGiro()
        If dsCari.Tables("Giro").Rows.Count <= 0 Then
            lookGiro.EditValue = vbNullString
            txtGiro.EditValue = vbNullString
            'lookBayar.EditValue = "03"
        End If
    End Sub

    Private Sub lookValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtValuta.EditValue = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
        loadInvoice()
        loadGiro()
        If dsCari.Tables("Giro").Rows.Count <= 0 Then
            lookGiro.EditValue = vbNullString
            txtGiro.EditValue = vbNullString
            'lookBayar.EditValue = "03"
        End If
    End Sub

    Private Sub txtValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        If txtValuta.EditValue = 0 Then
            txtValuta.EditValue = 1
        End If
    End Sub

    Private Sub lookSupplier_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookSupplier.QueryPopUp
        loadSupplier()
    End Sub

    Private Sub lookValuta_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookValuta.QueryPopUp
        loadValuta()
    End Sub

    Private Sub lookGiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookGiro.QueryPopUp
        loadGiro()
    End Sub

    Private Sub lookGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookGiro.EditValueChanged
        If Not dsCari.Tables("CekGiro") Is Nothing Then dsCari.Tables("CekGiro").Clear()

        daCari = New SqlDataAdapter(New SqlCommand("select jml_trans, kd_valuta, kurs_valuta from FIN.dbo.FIN_GIRO where nomor = '" & lookGiro.EditValue & "'", sqlconn))
        daCari.Fill(dsCari, "CekGiro")

        If Not dsCari.Tables("CekGiro").Rows.Count <= 0 Then
            txtGiro.EditValue = dsCari.Tables("CekGiro").Rows(0).Item("jml_trans").ToString
            lookValuta.EditValue = dsCari.Tables("CekGiro").Rows(0).Item("kd_valuta").ToString
            txtValuta.EditValue = dsCari.Tables("CekGiro").Rows(0).Item("kurs_valuta").ToString
        End If
    End Sub

    Private Sub txtBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.EditValueChanged
        Dim jumlah As Double
        Dim x As Object

        x = CType(gcHutang.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To gcHutang.FocusedView.RowCount - 1
            jumlah += gcHutang.FocusedView.GetRow(i).Item("jml_bayar")
        Next
        lblSelisih.Text = "Selisih : " & CStr(formatNumber(CStr(txtBayar.EditValue - jumlah)))
    End Sub

    Private Sub lookInv_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookInv.QueryPopUp
        loadInvoice()
    End Sub

    Private Sub lookBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookBayar.EditValueChanged
        loadGiro()
        If dsCari.Tables("Giro").Rows.Count <= 0 Then
            lookGiro.EditValue = vbNullString
            txtGiro.EditValue = vbNullString
        End If

        If lookBayar.EditValue = "04" Then
            lookBank.Visible = True
        Else
            lookBank.Visible = False
        End If
        lookBank.ItemIndex = 0
    End Sub

    Private Sub lookBank_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookBank.QueryPopUp
        loadBank()
    End Sub

    'Private Sub lookBayar_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookBayar.QueryPopUp
    '    loadJenisBayar()
    'End Sub

    Private Sub txtGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGiro.EditValueChanged
        If txtGiro.EditValue > 0 Then
            txtBayar.EditValue = txtGiro.EditValue
        End If
    End Sub
End Class