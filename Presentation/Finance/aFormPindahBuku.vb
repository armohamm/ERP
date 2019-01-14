Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormPindahBuku
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsJurnal, dsCari As New DataSet
    Dim daJurnal, daJurnalD, daBB, daKartu, daBP As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean = True
    Dim kode As String = ""
    Dim kodeCari As String
    Dim err As String = ""
    Dim kosong As Boolean

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
        loadData("xxx")
    End Sub

    Private Sub ClearAll()
        txtNoJur.EditValue = vbNullString
        dtpTanggal.EditValue = getTanggal()
        txtNoRef.EditValue = vbNullString
        lueValuta.EditValue = "IDR"
        txtValuta.EditValue = 1
        txtValuta.Properties.ReadOnly = True
        txtNama.EditValue = vbNullString
        txtAlamat.EditValue = vbNullString
        txtKet.Text = vbNullString
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)

        'cek()
        isvalid = True

        If Not isDelete Then
            If Not lueValuta.EditValue = "IDR" Then
                If txtValuta.Text = 1 Then
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                    isvalid = False
                End If
            End If

            If gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString Or gvJurnal.Columns("saldo_val_debet").SummaryText = "0,00" Or gvJurnal.Columns("saldo_val_kredit").SummaryText = vbNullString Or gvJurnal.Columns("saldo_val_kredit").SummaryText = "0,00" Then
                err &= "Jumlah debet atau kredit masih ada yang kosong." & vbCrLf
                isvalid = False
            End If

            If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                isvalid = False
            End If
        End If

        If isvalid Then
            If Not isDelete Then
                If STATE = "ADD" Then
                    kode = getNoTrans("JKK", getTanggal(), BTRANS)
                    txtNoJur.Text = kode
                    row = dsJurnal.Tables("Jurnal").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JKK-KBB-05"
                    row.Item("no_jur") = txtNoJur.Text
                    row.Item("no_doc") = getNoTrans("PDHBUKU", getTanggal(), BTRANS)
                    row.Item("tgl_trans") = dtpTanggal.EditValue
                    row.Item("no_ref1") = txtNoRef.Text
                    row.Item("kd_valuta") = IIf(lueValuta.EditValue = vbNullString, "IDR", lueValuta.EditValue)
                    row.Item("kurs_valuta") = txtValuta.EditValue
                    row.Item("nama") = txtNama.Text
                    row.Item("alamat") = txtAlamat.Text
                    row.Item("keterangan") = txtKet.Text
                    row.Item("thnbln") = Format(dtpTanggal.EditValue, "yyyyMM")
                    row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                    row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsJurnal.Tables("Jurnal").Rows.Add(row)
                Else
                    row = dsJurnal.Tables("Jurnal").Rows(0)
                    row("tgl_trans") = dtpTanggal.EditValue
                    row("no_ref1") = txtNoRef.Text
                    row("kd_valuta") = IIf(lueValuta.EditValue = vbNullString, "IDR", lueValuta.EditValue)
                    row("kurs_valuta") = txtValuta.EditValue
                    row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                    row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                    row("nama") = txtNama.Text
                    row("alamat") = txtAlamat.Text
                    row("keterangan") = txtKet.Text
                    row("Last_Update_Date") = getTanggal()
                    row("Last_Updated_By") = umum.username
                End If

                If Not gvJurnal.RowCount = 0 Then
                    For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw("Kd_Cabang") = getKodeCabang()
                            rw("tipe_trans") = "JKK-KBB-05"
                            rw("no_jur") = txtNoJur.Text
                            rw("kd_valuta") = lueValuta.EditValue
                            rw("kurs_valuta") = txtValuta.Text
                            rw("Last_Create_Date") = getTanggal()
                            rw("Last_Created_By") = umum.username
                            rw("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw.Item("Last_Update_Date") = getTanggal()
                            rw.Item("Last_Updated_By") = username
                        End If
                    Next
                End If
            End If

            Try
                myBuilder = New SqlCommandBuilder(daJurnal)
                daJurnal.UpdateCommand = myBuilder.GetUpdateCommand()
                daJurnal.InsertCommand = myBuilder.GetInsertCommand()
                daJurnal.DeleteCommand = myBuilder.GetDeleteCommand()

                If Not gvJurnal.RowCount < 0 Then
                    myBuilder = New SqlCommandBuilder(daJurnalD)
                    daJurnalD.UpdateCommand = myBuilder.GetUpdateCommand()
                    daJurnalD.InsertCommand = myBuilder.GetInsertCommand()
                    daJurnalD.DeleteCommand = myBuilder.GetDeleteCommand()
                End If

                BTRANS = sqlconn.BeginTransaction("1")
                daJurnal.UpdateCommand.Transaction = BTRANS
                daJurnal.InsertCommand.Transaction = BTRANS
                daJurnal.DeleteCommand.Transaction = BTRANS

                If Not gvJurnal.RowCount < 0 Then
                    daJurnalD.UpdateCommand.Transaction = BTRANS
                    daJurnalD.InsertCommand.Transaction = BTRANS
                    daJurnalD.DeleteCommand.Transaction = BTRANS
                End If

                daJurnal.Update(dsJurnal.Tables("Jurnal"))

                If Not gvJurnal.RowCount < 0 Then
                    daJurnalD.Update(dsJurnal.Tables("JurnalD"))
                End If

                BTRANS.Commit()

                If Not isDelete Then
                    showMessages("Berhasil disimpan..")
                    ClearAll()
                    loadData("xxx")
                Else
                    showMessages("Berhasil dihapus..")
                    cancel_click()
                End If
            Catch e As Exception
                BTRANS.Rollback()
                dsJurnal.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                If Not gvJurnal.RowCount < 0 Then
                    dsJurnal.Tables("JurnalD").RejectChanges()
                End If
                MsgBox(e.Message)
            End Try
        Else
            MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Public Sub cancel_click()
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        Me.Enabled = False
        ClearAll()
        STATE = ""
    End Sub

    Private Sub aFormPindahBuku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        lueValuta.EditValue = "IDR"
        txtValuta.Text = 1
        txtValuta.Properties.ReadOnly = True
        dtpTanggal.EditValue = getTanggal()
        gvJurnal.BestFitColumns()
    End Sub

    Private Sub cek()
        If txtNoRef.Text = "" Then
            isvalid = False
            err &= "No. Referensi tidak boleh kosong." & vbCrLf
            If txtNama.Text = "" Then
                err &= "Kepada tidak boleh kosong." & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat tidak boleh kosong." & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan tidak boleh kosong." & vbCrLf
            End If
            If Not lueValuta.EditValue = "IDR" Then
                If txtValuta.Text = 1 Then
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
            If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                    err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                End If
            End If
        ElseIf txtNama.Text = "" Then
            isvalid = False
            err &= "Kepada tidak boleh kosong." & vbCrLf
            If txtNoRef.Text = "" Then
                err &= "No. Referensi tidak boleh kosong." & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat tidak boleh kosong." & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan tidak boleh kosong." & vbCrLf
            End If
            If Not lueValuta.EditValue = "IDR" Then
                If txtValuta.Text = 1 Then
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
            If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                    err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                End If
            End If
        ElseIf txtAlamat.Text = "" Then
            isvalid = False
            err &= "Alamat tidak boleh kosong." & vbCrLf
            If txtNoRef.Text = "" Then
                err &= "No. Referensi tidak boleh kosong." & vbCrLf
            End If
            If txtNama.Text = "" Then
                err &= "Kepada tidak boleh kosong." & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan tidak boleh kosong." & vbCrLf
            End If
            If Not lueValuta.EditValue = "IDR" Then
                If txtValuta.Text = 1 Then
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
            If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                    err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                End If
            End If
        ElseIf txtKet.Text = "" Then
            isvalid = False
            err &= "Keterangan tidak boleh kosong." & vbCrLf
            If txtNoRef.Text = "" Then
                err &= "No. Referensi tidak boleh kosong." & vbCrLf
            End If
            If txtNama.Text = "" Then
                err &= "Kepada tidak boleh kosong." & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat tidak boleh kosong." & vbCrLf
            End If
            If Not lueValuta.EditValue = "IDR" Then
                If txtValuta.Text = 1 Then
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
            If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                    err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                End If
            End If
        ElseIf Not lueValuta.EditValue = "IDR" Then
            If txtValuta.Text = 1 Then
                isvalid = False
                err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                If txtNoRef.Text = "" Then
                    err &= "No. Referensi tidak boleh kosong." & vbCrLf
                End If
                If txtNama.Text = "" Then
                    err &= "Kepada tidak boleh kosong." & vbCrLf
                End If
                If txtAlamat.Text = "" Then
                    err &= "Alamat tidak boleh kosong." & vbCrLf
                End If
                If txtKet.Text = "" Then
                    err &= "Keterangan tidak boleh kosong." & vbCrLf
                End If
                If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                    If Not gvJurnal.Columns("saldo_val_debet").SummaryText = gvJurnal.Columns("saldo_val_kredit").SummaryText Then
                        err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                    End If
                End If
            End If
        ElseIf Not gvJurnal.Columns("saldo_val_debet").SummaryText Like gvJurnal.Columns("saldo_val_kredit").SummaryText Then
            isvalid = False
            err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
            If txtNoRef.Text = "" Then
                err &= "No. Referensi tidak boleh kosong." & vbCrLf
            End If
            If txtNama.Text = "" Then
                err &= "Kepada tidak boleh kosong." & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat tidak boleh kosong." & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan tidak boleh kosong." & vbCrLf
            End If
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
        daJurnal = New SqlDataAdapter(New SqlCommand("select tgl_trans as 'Tanggal Transaksi', no_jur as 'No. Jurnal', no_ref1 as 'No. Ref', nama as 'Nama', alamat as 'Alamat', keterangan as 'Keterangan', kd_valuta as 'Valuta', kurs_valuta as 'Kurs', jml_val_trans as 'Total Transaksi' from FIN.dbo.FIN_JURNAL where tipe_trans = 'JKK-KBB-05'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Total Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Total Transaksi").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kodeCari = frmCari.row("No. Jurnal")
            loadData(kodeCari)

            btnSave = True
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            setStatus()

            If Not TypeOf dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting") Is DBNull Or dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting") Is Nothing Then
                MsgBox("Jurnal Kas dengan nomor : " & kodeCari & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                txtNoJur.Properties.ReadOnly = True
                dtpTanggal.Enabled = False
                txtNoRef.Properties.ReadOnly = True
                lueValuta.Enabled = False
                txtValuta.Properties.ReadOnly = True
                txtNama.Properties.ReadOnly = True
                txtAlamat.Properties.ReadOnly = True
                txtKet.Properties.ReadOnly = True

                gvJurnal.OptionsBehavior.ReadOnly = True

                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
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
        lueKurs.DataSource = dsJurnal.Tables("Valuta")
        lueKurs.DisplayMember = "Nama_Valuta"
        lueKurs.ValueMember = "Kode_Valuta"

        daBB = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D' AND (kd_buku_besar LIKE '101%' OR kd_buku_besar LIKE '8%') AND NOT (kd_buku_besar LIKE '1014%')", sqlconn))
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
            txtNoJur.Text = kode
            dtpTanggal.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("tgl_trans")
            txtNoRef.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("no_ref1")
            lueValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kd_valuta")
            txtValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kurs_valuta")
            txtNama.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("nama")
            txtAlamat.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("alamat")
            txtKet.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("keterangan")
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & kodeCari & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            'STATE = "DELETE"
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
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString * txtValuta.Text
            gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = "0"
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = "0"
            'View.Columns("saldo_val_kredit").OptionsColumn.AllowEdit = False
            'View.Columns("saldo_val_kredit").OptionsColumn.ReadOnly = True
        End If
        If e.Column Is saldo_val_kredit Then
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString * txtValuta.Text
            gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = "0"
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = "0"
            'View.Columns("saldo_val_debet").OptionsColumn.AllowEdit = False
            'View.Columns("saldo_val_debet").OptionsColumn.ReadOnly = True
        End If

        If e.Column Is kd_buku_besar Then
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
            If varTmp2 = "01" Then
                gvJurnal.GetRow(e.RowHandle).item("kartu") = "CST00000"
                gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            ElseIf varTmp2 = "02" Then
                gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            ElseIf varTmp2 = "03" Then
                gvJurnal.GetRow(e.RowHandle).item("kartu") = "CST00000"
            End If

            If varTmp3 = "8" Then
                gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "90000003"
            End If
        End If
    End Sub

    Private Sub gvJurnal_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvJurnal.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvJurnal.RowCount + 1)
        gvJurnal.GetRow(e.RowHandle).item("kd_valuta") = "IDR"
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = "0"
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = "0"
        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = "0"
        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = "0"
    End Sub

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtValuta.Text = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        Dim deb As String = ""
        Dim kre As String = ""
        If Not txtValuta.EditValue = 0 Then
            For j As Integer = 0 To gvJurnal.RowCount - 1
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_debet") Is "0" Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    deb = gvJurnal.GetRowCellValue(j, "saldo_val_debet")
                    If Not txtValuta.Text = "" Then
                        gvJurnal.SetRowCellValue(j, "saldo_rp_debet", deb * txtValuta.Text)
                    End If
                End If
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_kredit") Is "0" Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    kre = gvJurnal.GetRowCellValue(j, "saldo_val_kredit")
                    If Not txtValuta.Text = "" Then
                        gvJurnal.SetRowCellValue(j, "saldo_rp_kredit", kre * txtValuta.Text)
                    End If
                End If
            Next
        Else
            txtValuta.EditValue = 1
        End If
    End Sub

    Public Sub cetak_click()
        If Not kodeCari.ToString = "" Then
            callReport(App_Path() & "\report\repBuktiJKK.rpt", "", "jurnal=" & kodeCari, False)
        End If
    End Sub
End Class