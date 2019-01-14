Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormJasaOngkir
    Public btnadd As Boolean = True
    Public btnEdit As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnSave As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsHPP, dsCari As New DataSet
    Dim daHPP, daHPPD, daLookUp, daCari As SqlDataAdapter
    Dim drHPP As SqlDataReader
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
        lookPO.Properties.ReadOnly = stat
        lookValuta.Properties.ReadOnly = stat
        txtValuta.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvHPP.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub clear()
        txtNoTrans.EditValue = vbNullString
        dteTanggal.EditValue = getTanggal()
        lookSupplier.EditValue = vbNullString
        lookPO.EditValue = vbNullString
        lookValuta.EditValue = vbNullString
        txtValuta.EditValue = vbNullString
        txtKet.EditValue = vbNullString
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsHPP.Tables("HPP") Is Nothing Then dsHPP.Tables("HPP").Clear()
        If Not dsHPP.Tables("HPPD") Is Nothing Then dsHPP.Tables("HPPD").Clear()
        daHPP = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHPP.Fill(dsHPP, "HPP")
        daHPPD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN_D where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHPPD.Fill(dsHPP, "HPPD")
        gcHPP.DataSource = dsHPP.Tables("HPPD")
        gvHPP.BestFitColumns()

        If dsHPP.Tables("HPP").Rows.Count > 0 Then
            txtNoTrans.EditValue = dsHPP.Tables("HPP").Rows(0)("no_inv")
            dteTanggal.EditValue = dsHPP.Tables("HPP").Rows(0)("tgl_inv")
            lookSupplier.EditValue = dsHPP.Tables("HPP").Rows(0)("kd_supplier")
            lookPO.EditValue = dsHPP.Tables("HPP").Rows(0)("no_ref1")
            lookValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kd_valuta")
            txtValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kurs_valuta")
            txtKet.EditValue = dsHPP.Tables("HPP").Rows(0)("keterangan")
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                If Not isDelete Then
                    If STATE = "ADD" Then
                        If ppn = "Y" Then
                            txtNoTrans.EditValue = getNoTrans("JPPP", dteTanggal.EditValue, BTRANS)
                        Else
                            txtNoTrans.EditValue = getNoTrans("JPPNP", dteTanggal.EditValue, BTRANS)
                        End If
                        row = dsHPP.Tables("HPP").NewRow
                        row.Item("Kd_cabang") = getKodeCabang()
                        row.Item("tipe_trans") = "JPP-KUT-04"
                        row.Item("no_inv") = txtNoTrans.EditValue
                        row.Item("thnbln") = Format(dteTanggal.EditValue, "yyyyMM")
                        row.Item("kd_buku_besar") = bukubesar
                        row.Item("Last_create_date") = getTanggal()
                        row.Item("Last_created_by") = username
                        row.Item("Program_name") = Me.Name
                    ElseIf STATE = "EDIT" Then
                        row = dsHPP.Tables("HPP").Rows(0)
                        row("Last_update_date") = getTanggal()
                        row("Last_updated_by") = umum.username
                    End If

                    row.Item("tgl_inv") = dteTanggal.EditValue
                    row.Item("kd_supplier") = lookSupplier.EditValue
                    row.Item("no_ref1") = lookPO.EditValue
                    row.Item("kd_valuta") = lookValuta.EditValue
                    row.Item("kurs_valuta") = txtValuta.EditValue
                    row.Item("keterangan") = txtKet.EditValue
                    row.Item("jml_tagihan") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText)
                    row.Item("jml_val_trans") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText)
                    row.Item("jml_rp_trans") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText * txtValuta.EditValue)

                    If STATE = "ADD" Then
                        dsHPP.Tables("HPP").Rows.Add(row)
                    End If

                    For Each rw As DataRow In dsHPP.Tables("HPPD").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw("Kd_Cabang") = getKodeCabang()
                            rw("tipe_trans") = "JPP-KUT-04"
                            'rw("kd_buku_besar") = bukubesar
                            rw("no_inv") = txtNoTrans.EditValue
                            rw("Last_create_date") = getTanggal()
                            rw("Last_created_by") = username
                            rw("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw("Last_update_date") = getTanggal()
                            rw("Last_updated_by") = username
                        End If
                    Next
                End If
            Else
                If gvHPP.RowCount = 0 Then
                    MsgBox("Kesalahan dalam pengisian data :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                    err = ""
                End If
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daHPP)
            daHPP.UpdateCommand = myBuilder.GetUpdateCommand()
            daHPP.InsertCommand = myBuilder.GetInsertCommand()
            daHPP.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlCommandBuilder(daHPPD)
            daHPPD.UpdateCommand = myBuilder.GetUpdateCommand()
            daHPPD.InsertCommand = myBuilder.GetInsertCommand()
            daHPPD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daHPP.UpdateCommand.Transaction = BTRANS
            daHPP.InsertCommand.Transaction = BTRANS
            daHPP.DeleteCommand.Transaction = BTRANS

            daHPPD.UpdateCommand.Transaction = BTRANS
            daHPPD.InsertCommand.Transaction = BTRANS
            daHPPD.DeleteCommand.Transaction = BTRANS

            daHPP.Update(dsHPP.Tables("HPP"))
            daHPPD.Update(dsHPP.Tables("HPPD"))

            dsHPP.Tables("HPP").AcceptChanges()
            dsHPP.Tables("HPPD").AcceptChanges()

            If Not isDelete Then
                call_procedure("JPP-KUT-04", txtNoTrans.EditValue, BTRANS)
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
            dsHPP.Tables("HPP").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsHPP.Tables("HPPD").RejectChanges()
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
        If lookPO.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookPO, "No. PO tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookPO, "")
        End If
        If lookValuta.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookValuta, "Valuta tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookValuta, "")
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
        If gvHPP.RowCount = 0 Then
            If STATE = "ADD" Then
                isvalid = False
                err &= "Detil belum diisi." & vbCrLf
            End If
        End If
    End Sub

    Private Sub loadSatuan()
        If Not dsHPP.Tables("Satuan") Is Nothing Then dsHPP.Tables("Satuan").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Satuan, Nama_Satuan from SIF.dbo.SIF_Satuan ", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Satuan")
        lookSatuan.DataSource = dsHPP.Tables("Satuan")
        lookSatuan.DisplayMember = "Kode_Satuan"
        lookSatuan.ValueMember = "Kode_Satuan"
    End Sub

    Private Sub loadSupplier()
        If Not dsHPP.Tables("Supplier") Is Nothing Then dsHPP.Tables("Supplier").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier order by Nama_Supplier", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Supplier")
        lookSupplier.Properties.DataSource = dsHPP.Tables("Supplier")
        lookSupplier.Properties.DisplayMember = "Nama_Supplier"
        lookSupplier.Properties.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadPO()
        If Not dsHPP.Tables("PO") Is Nothing Then dsHPP.Tables("PO").Clear()

        If STATE = "ADD" Then
            daLookUp = New SqlDataAdapter(New SqlCommand("select no_po, tgl_po, jml_val_trans from PURC.dbo.PURC_PO where tipe_trans = 'JPP-KUT-02' and kd_supplier = '" & lookSupplier.EditValue & "' order by tgl_po desc", sqlconn)) '<- query buat ditampilkan di LOV
        ElseIf STATE = "EDIT" Then
            daLookUp = New SqlDataAdapter(New SqlCommand("select no_po, tgl_po, jml_val_trans from PURC.dbo.PURC_PO where no_po = '" & dsHPP.Tables("HPP").Rows(0)("no_ref1") & "'", sqlconn)) '<- query buat ditampilkan di LOV
        End If
        daLookUp.Fill(dsHPP, "PO")
        lookPO.Properties.DataSource = dsHPP.Tables("PO")
        lookPO.Properties.DisplayMember = "no_po"
        lookPO.Properties.ValueMember = "no_po"
    End Sub

    Private Sub loadValuta()
        If Not dsHPP.Tables("Valuta") Is Nothing Then dsHPP.Tables("Valuta").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Valuta")
        lookValuta.Properties.DataSource = dsHPP.Tables("Valuta")
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
        lookValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadBarang()
        If Not dsHPP.Tables("Barang") Is Nothing Then dsHPP.Tables("Barang").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang where kd_jns_persd in (1,2,3)", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Barang")
        lookBrg.DataSource = dsHPP.Tables("Barang")
        lookBrg.DisplayMember = "Nama_Barang"
        lookBrg.ValueMember = "Kode_Barang"
    End Sub

    Private Sub aFormHPP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadBarang()
        loadPO()
        loadSatuan()
        loadSupplier()
        loadValuta()
        dteTanggal.EditValue = getTanggal()
        txtValuta.EditValue = 1
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        dsCari = New DataSet
        daCari = New SqlDataAdapter(New SqlCommand("select tgl_inv as 'Tanggal Transaksi', no_inv as 'No. Transaksi', no_ref1 as 'No. Ref', keterangan as 'Keterangan', jml_val_trans as 'Total' from FIN.dbo.FIN_PEMBELIAN where tipe_trans = 'JPP-KUT-04'", sqlconn)) '<- query buat ditampilkan di LOV
        daCari.Fill(dsCari, "LookHPP")
        frmCari.set_dso(dsCari.Tables("LookHPP"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Total").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Transaksi"))

            If Not (dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = vbNullString Or dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = "") Then
                MsgBox("No. transaski: " & txtNoTrans.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
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
            If MsgBox("Hapus transaski HPP dengan nomor " & txtNoTrans.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                'STATE = "DELETE"
                For Each rw As DataRow In dsHPP.Tables("HPP").Rows
                    Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur='" & txtNoTrans.EditValue & "'", sqlconn, BTRANS)
                    sqlx.ExecuteNonQuery()
                    rw.Delete()
                Next
                For Each rw As DataRow In dsHPP.Tables("HPPD").Rows
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
        If gvHPP.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvHPP.RowCount - 1
                gvHPP.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub gcHPP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcHPP.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvHPP.GetSelectedRows.Count > 0 Then
                gvHPP.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub gvHPP_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvHPP.CellValueChanged
        Dim View As ColumnView = sender
        If e.Column Is jml_val_trans Then
            If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                gvHPP.GetRow(e.RowHandle).item("jml_val_trans") = 0
            Else
                View.SetRowCellValue(e.RowHandle, "jml_rp_trans", e.Value * txtValuta.EditValue)
            End If
        End If

        If e.Column Is kd_stok Then
            drHPP = New SqlCommand("SELECT rek_persediaan FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & e.Value & "'", sqlconn).ExecuteReader
            drHPP.Read()
            View.SetRowCellValue(e.RowHandle, "kd_buku_besar", drHPP.Item("rek_persediaan"))
            drHPP.Close()
        End If
    End Sub

    Private Sub gvHPP_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvHPP.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvHPP.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_val_trans"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("satuan"), "BUAH")
    End Sub

    Private Sub gvHPP_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvHPP.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvHPP_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvHPP.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "jml_val_trans" Then
            If Not (e.Value = vbNull) Then
                If e.Value = 0 Then
                    e.Valid = False
                    e.ErrorText = "Tolong isi detil nominal Jumlah."
                End If
            Else
                e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "kd_stok" Then
            If e.Value = vbNull Then
                e.Valid = False
                e.ErrorText = "Tolong isi Nama Barang."
            End If
        End If
    End Sub

    Private Sub lookSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookSupplier.EditValueChanged
        loadPO()
    End Sub

    Private Sub lookPO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookPO.EditValueChanged
        If Not lookPO.EditValue = vbNullString Then
            drHPP = New SqlCommand("SELECT kd_valuta, kurs_valuta FROM PURC.dbo.PURC_PO WHERE no_po = '" & lookPO.EditValue & "'", sqlconn).ExecuteReader
            drHPP.Read()
            lookValuta.EditValue = drHPP.Item("kd_valuta")
            txtValuta.EditValue = drHPP.Item("kurs_valuta")
            drHPP.Close()
            drHPP = New SqlCommand("SELECT kd_bb_besar1, kd_bb_besar2 FROM SIF.dbo.SIF_TIPE_TRANS_D WHERE tipe_trans = 'JPP-KUT-04' AND tipe_desc = 'HUTANG'", sqlconn).ExecuteReader
            drHPP.Read()
            If lookValuta.EditValue = "IDR" Then
                bukubesar = drHPP.Item("kd_bb_besar1")
            Else
                bukubesar = drHPP.Item("kd_bb_besar2")
            End If
            drHPP.Close()
        End If
    End Sub

    Private Sub lookValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtValuta.EditValue = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub lookPO_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookPO.QueryPopUp
        loadPO()
    End Sub

    Private Sub txtValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        If txtValuta.EditValue = 0 Then
            txtValuta.EditValue = 1
        End If
    End Sub
End Class