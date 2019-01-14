Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmJurnalJKM
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsJurnal, dsCari As New DataSet
    Dim daJurnal, daJurnalD, daBB, daKartu, daBP As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim kode As String
    Dim kodeCari As String
    Dim err As String = ""
    Dim kosong As Boolean
    Dim varTmp1 As String
    Dim varTmp2 As String

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
        STATE = "ADD"
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = False
        setStatus()
        clear()
        loadData("xxx")
        Me.Enabled = True
    End Sub

    Private Sub lookOnly(ByVal stat As Boolean)
        dtpTanggal.Properties.ReadOnly = stat
        txtRef.Properties.ReadOnly = stat
        lueValuta.Properties.ReadOnly = stat
        txtValuta.Properties.ReadOnly = stat
        txtNama.Properties.ReadOnly = stat
        txtAlamat.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvJurnal.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub clear()
        txtNoJur.EditValue = vbNullString
        dtpTanggal.EditValue = getTanggal()
        txtRef.EditValue = vbNullString
        lueValuta.EditValue = "IDR"
        txtValuta.EditValue = 1
        txtNama.EditValue = vbNullString
        txtAlamat.EditValue = vbNullString
        txtKet.EditValue = vbNullString
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)

        If Not isDelete Then
            cek()
            If isvalid Then
                If STATE = "ADD" Then
                    txtNoJur.EditValue = getNoTrans("JKM", getTanggal())
                    row = dsJurnal.Tables("Jurnal").NewRow
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JKM-KBB-01"
                    row.Item("no_jur") = txtNoJur.EditValue
                    row.Item("no_doc") = getNoTrans("JKMDOC", getTanggal(), BTRANS)
                    row.Item("thnbln") = Format(dtpTanggal.EditValue, "yyyyMM")
                    'row.Item("thnbln") = FormatDateTime(dtpTanggal.Value.Month, 00).ToString()
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                    dsJurnal.Tables("Jurnal").Rows.Add(row)
                ElseIf STATE = "EDIT" Then
                    row = dsJurnal.Tables("Jurnal").Rows(0)
                    row.Item("Last_Update_Date") = getTanggal()
                    row.Item("Last_Updated_By") = umum.username
                End If

                row.Item("tgl_trans") = dtpTanggal.EditValue
                row.Item("no_ref1") = txtRef.EditValue
                row.Item("kd_valuta") = IIf(lueValuta.EditValue = vbNullString, "IDR", lueValuta.EditValue)
                row.Item("kurs_valuta") = txtValuta.EditValue
                row.Item("nama") = txtNama.EditValue
                row.Item("alamat") = txtAlamat.EditValue
                row.Item("keterangan") = txtKet.EditValue
                row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)
                row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)

                For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                    If rw.RowState = DataRowState.Added Then
                        rw("Kd_Cabang") = getKodeCabang()
                        rw("tipe_trans") = "JKM-KBB-01"
                        rw("kd_buku_pusat") = "00000000"
                        rw("no_jur") = txtNoJur.EditValue
                        rw("kd_valuta") = lueValuta.EditValue
                        rw("kurs_valuta") = txtValuta.EditValue
                        rw("Last_Create_Date") = getTanggal()
                        rw("Last_Created_By") = umum.username
                        rw("Programe_name") = Me.Name
                    ElseIf rw.RowState = DataRowState.Modified Then
                        rw.Item("Last_Update_Date") = getTanggal()
                        rw.Item("Last_Updated_By") = username
                    End If
                Next
            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
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

            dsJurnal.Tables("Jurnal").AcceptChanges()
            dsJurnal.Tables("JurnalD").AcceptChanges()

            BTRANS.Commit()
            If isDelete Then
                showMessages("Berhasil dihapus..")
            Else
                showMessages("Berhasil disimpan..")
            End If
            'STATE = "EDIT"
            isvalid = False

            If STATE = "ADD" Then
                loadData("xxx")
            ElseIf STATE = "EDIT" Then
                cancel_click()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsJurnal.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsJurnal.Tables("JurnalD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub cancel_click()
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnDelete = False
        btnSave = False
        setStatus()
        Me.Enabled = False
        loadData("XXX")
        STATE = ""
        lookOnly(False)
    End Sub

    Private Sub frmJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        Me.Enabled = False
    End Sub

    Private Sub cek()
        If Not lueValuta.EditValue = "IDR" Then
            If txtValuta.EditValue = 1 Then
                isvalid = False
                err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                If Not (gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00")) Then
                    If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                        err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                    End If
                End If
            End If
        ElseIf Not gvJurnal.Columns("saldo_val_debet").SummaryText Like gvJurnal.Columns("saldo_val_kredit").SummaryText Then
            isvalid = False
            err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
            If txtValuta.Text = 1 Then
                If Not lueValuta.EditValue = "IDR" Then
                    isvalid = False
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
        Else
            isvalid = True
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsCari = New DataSet
        daJurnal = New SqlDataAdapter(New SqlCommand("select tgl_trans as 'Tanggal Transaksi', no_jur as 'No. Jurnal', no_ref1 as 'No. Ref', nama as 'Nama', alamat as 'Alamat', keterangan as 'Keterangan', kd_valuta as 'Valuta', kurs_valuta as 'Kurs', jml_rp_trans as 'Jumlah' from FIN.dbo.FIN_JURNAL where tipe_trans ='JKM-KBB-01' ORdER BY tgl_trans DESC", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Kurs").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Kurs").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Jurnal"))

            If Not (dsJurnal.Tables("Jurnal").Rows(0)("no_posting").ToString = vbNullString Or dsJurnal.Tables("Jurnal").Rows(0)("no_posting").ToString = "") Then
                MsgBox("Jurnal Kas dengan nomor : " & dsJurnal.Tables("Jurnal").Rows(0)("no_posting").ToString & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                lookOnly(True)

                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                setStatus()

            Else
                lookOnly(False)
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                setStatus()
            End If
        Else
            cancel_click()
        End If
    End Sub

    Private Sub loadList()
        If Not dsJurnal.Tables("Valuta") Is Nothing Then dsJurnal.Tables("Valuta").Clear()
        If Not dsJurnal.Tables("BukuBesar") Is Nothing Then dsJurnal.Tables("BukuBesar").Clear()
        If Not dsJurnal.Tables("Kartu") Is Nothing Then dsJurnal.Tables("Kartu").Clear()
        If Not dsJurnal.Tables("BukuPusat") Is Nothing Then dsJurnal.Tables("BukuPusat").Clear()

        daJurnal = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daJurnal.Fill(dsJurnal, "Valuta")
        lueValuta.Properties.DataSource = dsJurnal.Tables("Valuta")
        lueValuta.Properties.DisplayMember = "Nama_Valuta"
        lueValuta.Properties.ValueMember = "Kode_Valuta"

        daBB = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D' AND NOT flag_gl = 'T'", sqlconn))
        daBB.Fill(dsJurnal, "BukuBesar")
        lueBB.DataSource = dsJurnal.Tables("BukuBesar")
        lueBB.DisplayMember = "nm_buku_besar"
        lueBB.ValueMember = "kd_buku_besar"

        daKartu = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsJurnal, "Kartu")
        lueKartu.DataSource = dsJurnal.Tables("Kartu")
        lueKartu.DisplayMember = "nama"
        lueKartu.ValueMember = "kode"

        daBP = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM SIF.dbo.SIF_buku_pusat", sqlconn))
        daBP.Fill(dsJurnal, "BukuPusat")
        lueBP.DataSource = dsJurnal.Tables("BukuPusat")
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
            txtNoJur.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("no_jur")
            dtpTanggal.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("tgl_trans")
            txtRef.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("no_ref1")
            lueValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("kd_valuta")
            txtValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("kurs_valuta")
            txtNama.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("nama")
            txtAlamat.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("alamat")
            txtKet.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("keterangan")
        Else
            clear()
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & dsJurnal.Tables("Jurnal").Rows(0)("no_jur") & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            For Each rw As DataRow In dsJurnal.Tables("Jurnal").Rows
                rw.Delete()
            Next
            For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                rw.Delete()
            Next
            save_click(True)
            cancel_click()
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

    Private Sub gcJurnal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcJurnal.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvJurnal.GetSelectedRows.Count > 0 Then
                gvJurnal.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub gvJurnal_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvJurnal.CellValueChanged
        Dim View As ColumnView = sender
        If e.Column Is saldo_val_debet Then
            If Not (gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString = vbNullString Or gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString = "") Then
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") * txtValuta.EditValue
                gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = 0
                'View.Columns("saldo_val_kredit").OptionsColumn.AllowEdit = False
                'View.Columns("saldo_val_kredit").OptionsColumn.ReadOnly = True
            Else
                gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") * txtValuta.EditValue
            End If
        End If
        If e.Column Is saldo_val_kredit Then
            If Not (gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString = vbNullString Or gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString = "") Then
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") * txtValuta.EditValue
                gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = 0
                'View.Columns("saldo_val_debet").OptionsColumn.AllowEdit = False
                'View.Columns("saldo_val_debet").OptionsColumn.ReadOnly = True
            Else
                gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = 0
                gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") * txtValuta.EditValue
            End If
            
        End If

        If e.Column Is kd_buku_besar Then
            varTmp1 = ""
            varTmp2 = ""
            Dim drPost As SqlDataReader
            drPost = New SqlCommand("select nm_buku_besar, pola_entry from SIF.dbo.SIF_buku_besar where kd_buku_besar = '" & gvJurnal.GetRow(e.RowHandle).item("kd_buku_besar") & "'", sqlconn).ExecuteReader
            Do While drPost.Read()
                varTmp1 = (drPost.Item(0))
                varTmp2 = (drPost.Item(1))
            Loop
            drPost.Close()
            If varTmp2 = "01" Then
                gvJurnal.GetRow(e.RowHandle).item("kartu") = "S00000"
                gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            ElseIf varTmp2 = "02" Then
                gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            ElseIf varTmp2 = "03" Then
                gvJurnal.GetRow(e.RowHandle).item("kartu") = "S00000"
            End If
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

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtValuta.EditValue = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        Dim deb As String = ""
        Dim kre As String = ""
        If Not txtValuta.EditValue Like 0 Then
            For j As Integer = 0 To gvJurnal.RowCount - 1
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_debet") = 0 Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    deb = gvJurnal.GetRowCellValue(j, "saldo_val_debet")
                    gvJurnal.SetRowCellValue(j, "saldo_rp_debet", deb * txtValuta.EditValue)
                End If
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_kredit") = 0 Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    kre = gvJurnal.GetRowCellValue(j, "saldo_val_kredit")
                    gvJurnal.SetRowCellValue(j, "saldo_rp_kredit", kre * txtValuta.EditValue)
                End If
            Next
        Else
            txtValuta.EditValue = 1
        End If
    End Sub

    Private Sub gvJurnal_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvJurnal.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvJurnal_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvJurnal.InvalidValueException
        Dim vx As GridView = sender
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        'vx.SetFocusedRowCellValue("saldo_val_kredit", 0)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError

    End Sub

    Private Sub gvJurnal_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJurnal.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("kd_buku_besar")
        Dim column2 As GridColumn = view.Columns("saldo_val_debet")
        Dim column3 As GridColumn = view.Columns("saldo_val_kredit")

        If view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, column1).ToString = "" Then
            e.Valid = False
            view.SetColumnError(column1, "Rekening tidak boleh kosong.")
            Exit Sub
        Else
            e.Valid = True
        End If

        If view.GetRowCellValue(e.RowHandle, column3) = 0 And view.GetRowCellValue(e.RowHandle, column2) = 0 Then
            e.Valid = False
            view.SetColumnError(column3, "Nominal debet atau kredit harus diisi.")
            view.SetColumnError(column2, "Nominal debet atau kredit harus diisi.")
            Exit Sub
        Else
            e.Valid = True
        End If
    End Sub

    'Private Sub gvJurnal_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvJurnal.ValidateRow
    '    Dim view As ColumnView = CType(sender, ColumnView)
    '    Dim column1 As GridColumn = view.Columns("saldo_val_debet")
    '    If view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, column1).ToString = "" Then
    '        e.Valid = False
    '        view.SetRowCellValue(e.RowHandle, "saldo_val_debet", 0)
    '        view.SetColumnError(column1, "Tolong isi jumlah terlebih dahulu.")
    '    End If
    'End Sub

    Private Sub gvJurnal_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvJurnal.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "saldo_val_kredit" Then
            If Not (e.Value.ToString = vbNullString Or e.Value.ToString = "") Then
                If Microsoft.VisualBasic.Left(vx.GetFocusedRowCellValue("kd_buku_besar"), 3) Like "101" Or Microsoft.VisualBasic.Left(vx.GetFocusedRowCellValue("kd_buku_besar"), 3) Like "102" Then
                    If e.Value > 0 Then
                        e.Valid = False
                        e.ErrorText = "Hanya dapat mengisi nominal debet untuk rekening ini."
                    End If
                End If
            Else
                e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "saldo_val_debet" Then
            If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "kartu" Then
            If varTmp2 = "02" Then
                If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                    e.Valid = False
                    e.ErrorText = "Tolong pilih kartu untuk rekening ini."
                End If
            End If
        End If

        If vx.FocusedColumn.FieldName = "kd_buku_pusat" Then
            If varTmp2 = "03" Then
                If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                    e.Valid = False
                    e.ErrorText = "Tolong pilih pusat biaya untuk rekening ini."
                End If
            End If
        End If

        If vx.FocusedColumn.FieldName = "kd_buku_besar" Then
            If Not gvJurnal.RowCount <= 0 Then
                For i As Integer = 0 To gvJurnal.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If e.Value = vx.GetRowCellValue(i, kd_buku_besar) Then
                        e.Valid = False
                        e.ErrorText = "Rekening sudah ada dalam tabel ini."
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub cetak_click()
        If Not (txtNoJur.EditValue = "" Or txtNoJur.EditValue = "") Then
            callReport(App_Path() & "\report\repBuktiJKM.rpt", "", "jurnal=" & txtNoJur.EditValue, False)
        End If
    End Sub
End Class