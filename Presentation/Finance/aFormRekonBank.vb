Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormRekonBank
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsJurnal, dsCari, dsLookUp As New DataSet
    Dim daJurnal, daJurnalD, daLookUp As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim kode As String

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
        btnAdd = False
        btnCancel = True
        btnDelete = False
        setStatus()
        loadData("xxx")
        controlOff(False)
    End Sub

    Public Sub cancel_click()
        btnAdd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        Me.Enabled = False
        clear()
        STATE = ""
        controlOff(True)
    End Sub

    Private Sub clear()
        txtNoJurnal.EditValue = vbNullString
        detTanggal.EditValue = getTanggal()
        txtNoRef.EditValue = vbNullString
        lckValuta.EditValue = "IDR"
        txtKurs.EditValue = 1
        txtKurs.Properties.ReadOnly = True
        txtKeterangan.Text = vbNullString
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()
    End Sub

    Private Sub aFormRekonBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadData("xxx")
        loadLookUp()
        clear()
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("Valuta") Is Nothing Then dsLookUp.Tables("Valuta").Clear()
        If Not dsLookUp.Tables("BukuBesar") Is Nothing Then dsLookUp.Tables("BukuBesar").Clear()
        If Not dsLookUp.Tables("BukuPusat") Is Nothing Then dsLookUp.Tables("BukuPusat").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta WHERE Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsLookUp, "Valuta")
        lckValuta.Properties.DataSource = dsLookUp.Tables("Valuta")
        lckValuta.Properties.DisplayMember = "Nama_Valuta"
        lckValuta.Properties.ValueMember = "Kode_Valuta"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D' AND (kd_buku_besar LIKE '101%' OR kd_buku_besar LIKE '8%' OR kd_buku_besar LIKE '6%' OR kd_buku_besar LIKE '7%') AND NOT kd_buku_besar LIKE '1014%' AND Rec_Stat = 'Y'", sqlconn))
        daLookUp.Fill(dsLookUp, "BukuBesar")
        lckBukuBesar.DataSource = dsLookUp.Tables("BukuBesar")
        lckBukuBesar.DisplayMember = "nm_buku_besar"
        lckBukuBesar.ValueMember = "kd_buku_besar"
        RepositoryItemGridLookUpEdit1View.Columns("kd_buku_besar").Visible = False
        RepositoryItemGridLookUpEdit1View.Columns("nm_buku_besar").Caption = "Rekening"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM SIF.dbo.SIF_buku_pusat", sqlconn))
        daLookUp.Fill(dsLookUp, "BukuPusat")
        lueBP.DataSource = dsLookUp.Tables("BukuPusat")
        lueBP.DisplayMember = "nm_buku_pusat"
        lueBP.ValueMember = "kd_buku_pusat"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()

        daJurnal = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL where no_jur = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsJurnal, "Jurnal")
        daJurnalD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL_D where no_jur = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnalD.Fill(dsJurnal, "JurnalD")
        gcJurnal.DataSource = dsJurnal.Tables("JurnalD")
        gvJurnal.BestFitColumns()

        If dsJurnal.Tables("Jurnal").Rows.Count > 0 Then
            txtNoJurnal.EditValue = kode
            detTanggal.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("tgl_trans")
            txtNoRef.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("no_ref1")
            lckValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kd_valuta")
            txtKurs.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kurs_valuta")
            txtKeterangan.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("keterangan")
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & txtNoJurnal.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            If Not dsJurnal.Tables("Jurnal") Is Nothing Then
                For Each rw As DataRow In dsJurnal.Tables("Jurnal").Rows
                    rw.Delete()
                Next
            End If
            If Not dsJurnal.Tables("JurnalD") Is Nothing Then
                For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                    rw.Delete()
                Next
            End If
            STATE = "DELETE"
            save_click(True)
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If gvJurnal.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvJurnal.RowCount - 1
                gvJurnal.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub gvJurnal_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvJurnal.CellValueChanged
        Dim View As ColumnView = sender

        If e.Column Is saldo_val_debet Then
            If Not e.Value = 0 Then
                View.SetRowCellValue(e.RowHandle, "saldo_rp_debet", gvJurnal.GetRowCellValue(e.RowHandle, "saldo_val_debet") * txtKurs.EditValue)
                View.SetRowCellValue(e.RowHandle, "saldo_val_kredit", 0)
                View.SetRowCellValue(e.RowHandle, "saldo_rp_kredit", 0)
                End If
        End If

        If e.Column Is saldo_val_kredit Then
            If Not e.Value = 0 Then
                View.SetRowCellValue(e.RowHandle, "saldo_rp_kredit", gvJurnal.GetRowCellValue(e.RowHandle, "saldo_val_kredit") * txtKurs.EditValue)
                View.SetRowCellValue(e.RowHandle, "saldo_val_debet", 0)
                View.SetRowCellValue(e.RowHandle, "saldo_rp_debet", 0)
                End If
        End If

        If e.Column Is kd_buku_besar Then
            Try
                If Not gvJurnal.GetRow(e.RowHandle).item("kd_buku_besar") Is Nothing Then
                    Dim varTmp1 As String
                    Dim varTmp2 As String
                    Dim varTmp3 As String
                    Dim drPost As SqlDataReader
                    drPost = New SqlCommand("select nm_buku_besar, pola_entry, SUBSTRING(kd_buku_besar,1,1) kode from SIF.dbo.SIF_buku_besar where kd_buku_besar = '" & gvJurnal.GetRow(e.RowHandle).item("kd_buku_besar") & "'", sqlconn).ExecuteReader
                    'Do While 
                    drPost.Read()
                    varTmp1 = (drPost.Item(0))
                    varTmp2 = (drPost.Item(1))
                    varTmp3 = (drPost.Item(2))
                    'Loop
                    drPost.Close()
                    'MsgBox(varTmp1)
                    'MsgBox(varTmp2)
                    'If varTmp2 = "01" Then
                    '    gvJurnal.SetRowCellValue(e.RowHandle, "kartu", "CST00000")
                    '    gvJurnal.SetRowCellValue(e.RowHandle, "kd_buku_pusat", "00000000")
                    'ElseIf varTmp2 = "02" Then
                    '    gvJurnal.SetRowCellValue(e.RowHandle, "kd_buku_pusat", "00000000")
                    'ElseIf varTmp2 = "03" And varTmp3 = "8" Then
                    '    gvJurnal.SetRowCellValue(e.RowHandle, "kartu", "CST00000")
                    'End If

                    If varTmp3 = "8" Then
                        gvJurnal.SetRowCellValue(e.RowHandle, "kd_buku_pusat", "90000003")
                    Else
                        gvJurnal.SetRowCellValue(e.RowHandle, "kd_buku_pusat", "00000000")
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub gvJurnal_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvJurnal.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvJurnal.RowCount + 1)
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = 0
        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = 0
    End Sub

    Private Sub gvJurnal_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvJurnal.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvJurnal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvJurnal.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvJurnal.GetSelectedRows.Count > 0 Then
                gvJurnal.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        txtNoJurnal.Properties.ReadOnly = stat
        detTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        lckValuta.Properties.ReadOnly = stat
        txtKurs.Properties.ReadOnly = stat
        txtKeterangan.Properties.ReadOnly = stat
        gvJurnal.OptionsBehavior.ReadOnly = stat
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        If Not dsCari.Tables("LookJurnal") Is Nothing Then dsCari.Tables("LookJurnal").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("select no_jur as 'No. Jurnal', tgl_trans as 'Tanggal Transaksi', no_ref1 as 'No. Ref', keterangan as 'Keterangan', jml_val_trans as 'Total Transaksi' from FIN.dbo.FIN_JURNAL where tipe_trans = 'JKK-KBB-05' AND tgl_trans >= CONVERT(DATE, '01/01/2014', 103) ORDER BY tgl_trans DESC", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Total Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Total Transaksi").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Jurnal"))

            If Not TypeOf dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting") Is DBNull Or dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting") Is Nothing Then
                MsgBox("Jurnal dengan nomor : " & txtNoJurnal.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                controlOff(True)

                btnSave = False
                btnCancel = True
                btnAdd = False
                btnEdit = False
                btnDelete = False
                setStatus()
            Else
                controlOff(False)

                btnSave = True
                btnCancel = True
                btnAdd = False
                btnEdit = False
                btnDelete = True
                setStatus()
            End If
        Else
            cancel_click()
        End If
    End Sub

    Private Sub cek()
        isvalid = True
        If Not lckValuta.EditValue = "IDR" Then
            If txtKurs.EditValue = 1 Then
                isValid = False
                DxErrorProvider1.SetError(txtKurs, "Valuta non rupiah tidak boleh 1.")
            Else
                DxErrorProvider1.SetError(txtKurs, "")
            End If
        ElseIf lckValuta.EditValue = "IDR" Then
            If txtKurs.EditValue > 1 Then
                isValid = False
                DxErrorProvider1.SetError(txtKurs, "Valuta rupiah harus 1.")
            Else
                DxErrorProvider1.SetError(txtKurs, "")
            End If
        End If

        If gvJurnal.RowCount = 0 Then
            If STATE = "ADD" Then
                isValid = False
                MsgBox("Detil masih belum diisi.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            End If
        End If

        If Not txtSelisih.EditValue = 0 Then
            isValid = False
            MsgBox("Masih ada selisih antara jumlah Rp. debet dan kredit. Mohon di cek ulang.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isValid Then
                If STATE = "ADD" Then
                    txtNoJurnal.EditValue = getNoTrans("JKK", detTanggal.EditValue, BTRANS)
                    row = dsJurnal.Tables("Jurnal").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JKK-KBB-05"
                    row.Item("no_jur") = txtNoJurnal.EditValue
                    row.Item("no_doc") = getNoTrans("PDHBUKU", detTanggal.EditValue, BTRANS)
                    row.Item("thnbln") = Format(detTanggal.EditValue, "yyyyMM")
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                ElseIf STATE = "EDIT" Then
                    row = dsJurnal.Tables("Jurnal").Rows(0)
                    row("Last_Update_Date") = getTanggal()
                    row("Last_Updated_By") = username
                End If

                row.Item("tgl_trans") = detTanggal.EditValue
                row.Item("no_ref1") = txtNoRef.EditValue
                row.Item("kd_valuta") = IIf(lckValuta.EditValue = vbNullString, "IDR", lckValuta.EditValue)
                row.Item("kurs_valuta") = txtKurs.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)
                row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)

                If STATE = "ADD" Then
                    dsJurnal.Tables("Jurnal").Rows.Add(row)
                End If

                For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                    If rw.RowState = DataRowState.Added Then
                        rw("Kd_Cabang") = getKodeCabang()
                        rw("tipe_trans") = "JKK-KBB-05"
                        rw("no_jur") = txtNoJurnal.EditValue
                        rw("kartu") = "0000000"
                        rw("kd_valuta") = lckValuta.EditValue
                        rw("kurs_valuta") = txtKurs.EditValue
                        rw("Last_Create_Date") = getTanggal()
                        rw("Last_Created_By") = username
                        rw("Programe_name") = Me.Name
                    ElseIf rw.RowState = DataRowState.Modified Then
                        rw.Item("Last_Update_Date") = getTanggal()
                        rw.Item("Last_Updated_By") = username
                    End If
                Next
            Else
                Exit Sub
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daJurnal)
            daJurnal.UpdateCommand = myBuilder.GetUpdateCommand()
            daJurnal.InsertCommand = myBuilder.GetInsertCommand()
            daJurnal.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlCommandBuilder(daJurnalD)
            daJurnalD.UpdateCommand = myBuilder.GetUpdateCommand()
            daJurnalD.InsertCommand = myBuilder.GetInsertCommand()
            daJurnalD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daJurnal.UpdateCommand.Transaction = BTRANS
            daJurnal.InsertCommand.Transaction = BTRANS
            daJurnal.DeleteCommand.Transaction = BTRANS

            daJurnalD.UpdateCommand.Transaction = BTRANS
            daJurnalD.InsertCommand.Transaction = BTRANS
            daJurnalD.DeleteCommand.Transaction = BTRANS

            daJurnal.Update(dsJurnal.Tables("Jurnal"))
            daJurnalD.Update(dsJurnal.Tables("JurnalD"))

            BTRANS.Commit()

            If Not isDelete Then
                showMessages("Berhasil disimpan..")
                clear()
                loadData("xxx")
            Else
                showMessages("Berhasil dihapus..")
                cancel_click()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsJurnal.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsJurnal.Tables("JurnalD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub lckValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckValuta.EditValueChanged
        If lckValuta.EditValue = "IDR" Then
            txtKurs.EditValue = 1
            txtKurs.Properties.ReadOnly = True
        Else
            txtKurs.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtKurs_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKurs.EditValueChanged
        If txtKurs.EditValue = 0 Or txtKurs.EditValue Is Nothing Then txtKurs.EditValue = 1

        For j As Integer = 0 To gvJurnal.RowCount - 1
            If Not gvJurnal.GetRowCellValue(j, "saldo_val_debet") Is "0" Then
                gvJurnal.SetRowCellValue(j, "saldo_rp_debet", gvJurnal.GetRowCellValue(j, "saldo_val_debet") * txtKurs.EditValue)
            End If
            If Not gvJurnal.GetRowCellValue(j, "saldo_val_kredit") Is "0" Then
                gvJurnal.SetRowCellValue(j, "saldo_rp_kredit", gvJurnal.GetRowCellValue(j, "saldo_val_kredit") * txtKurs.EditValue)
            End If
        Next
    End Sub

    Private Sub gvJurnal_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvJurnal.RowUpdated
        Dim jumlahD As Double
        Dim jumlahK As Double
        Dim x As Object

        x = CType(gcJurnal.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To gcJurnal.FocusedView.RowCount - 1
            jumlahD += gcJurnal.FocusedView.GetRow(i).Item("saldo_rp_debet")
            jumlahK += gcJurnal.FocusedView.GetRow(i).Item("saldo_rp_kredit")
        Next
        txtSelisih.EditValue = jumlahD - jumlahK
    End Sub

    Private Sub gvJurnal_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvJurnal.ValidatingEditor
        Dim view As GridView = sender
        If view.FocusedColumn.FieldName = "kd_buku_besar" Then
            If Not gvJurnal.RowCount <= 0 Then
                For i As Integer = 0 To sender.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If e.Value = view.GetRowCellValue(i, kd_buku_besar) Then
                        e.Valid = False
                        e.ErrorText = "Rekening sudah ada, mohon pilih yang lain."
                    End If
                Next
            End If
        End If
    End Sub
End Class