Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmJurnal
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsJurnal, dsCari As New DataSet
    Dim daJurnal, daJurnalD, daCari, daBB, daKartu, daBP As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim kode As String
    Dim kodeCari As String
    Dim err As String = ""

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
        setStatus()
        kode = getNoTrans("JUR", getTanggal())
        loadData()
    End Sub

    Private Sub ClearAll()

        txtNoJur.Text = ""
        dtpTanggal.Text = ""
        txtRef.Text = ""
        lueValuta.EditValue = vbNullString
        txtValuta.Text = 1
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtKet.Text = ""
        gcJurnal.DataSource = vbNull
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        cek()
        If isvalid Then
            If Not isDelete Then
                If STATE = "ADD" Then
                    txtNoJur.Text = kode
                    row = dsJurnal.Tables("Jurnal").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JKK-KBB-01"
                    row.Item("no_jur") = txtNoJur.Text
                    row.Item("tgl_trans") = dtpTanggal.Value
                    row.Item("no_ref1") = txtRef.Text
                    row.Item("kd_valuta") = IIf(lueValuta.EditValue = vbNullString, "IDR", lueValuta.EditValue)
                    row.Item("kurs_valuta") = IIf(txtValuta.Text = "", 1, txtValuta.Text)
                    row.Item("nama") = txtNama.Text
                    row.Item("alamat") = txtAlamat.Text
                    row.Item("keterangan") = txtKet.Text
                    row.Item("thnbln") = dtpTanggal.Value.Year.ToString & Mid(FormatDateTime(dtpTanggal.Value, DateFormat.GeneralDate), 4, 2)
                    'row.Item("thnbln") = FormatDateTime(dtpTanggal.Value.Month, 00).ToString()
                    row.Item("jml_val_trans") = kdcabang
                    row.Item("jml_rp_trans") = kdcabang
                    row.Item("Last_create_date") = Now
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsJurnal.Tables("Jurnal").Rows.Add(row)
                Else
                    row = dsCari.Tables("JurnalCari").Rows(0)
                    row("tgl_trans") = dtpTanggal.Value
                    row("no_ref1") = txtRef.Text
                    row("kd_valuta") = lueValuta.EditValue
                    row("kurs_valuta") = txtValuta.Text
                    row("nama") = txtNama.Text
                    row("alamat") = txtAlamat.Text
                    row("keterangan") = txtKet.Text
                    row("Last_Update_Date") = Now
                    row("Last_Updated_By") = umum.username
                End If

                If Not gvJurnal.RowCount <= 0 Then
                    If STATE = "ADD" Then
                        For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                            If rw.RowState = DataRowState.Added Then
                                rw("Kd_Cabang") = kdcabang
                                rw("tipe_trans") = "JKK-KBB-01"
                                rw("no_jur") = txtNoJur.Text
                                rw("Last_Create_Date") = Now
                                rw("Last_Created_By") = umum.username
                                rw("Programe_name") = Me.Name
                            ElseIf rw.RowState = DataRowState.Modified Then
                                rw.Item("Last_Update_Date") = Now
                                rw.Item("Last_Updated_By") = username
                            End If
                        Next
                    Else
                        For Each rw As DataRow In dsCari.Tables("JurnalDCari").Rows
                            If rw.RowState = DataRowState.Added Then
                                rw("Kd_Cabang") = kdcabang
                                rw("tipe_trans") = "JKK-KBB-01"
                                rw("no_jur") = txtNoJur.Text
                                rw("Last_Create_Date") = Now
                                rw("Last_Created_By") = umum.username
                                rw("Programe_name") = Me.Name
                            ElseIf rw.RowState = DataRowState.Modified Then
                                rw.Item("Last_Update_Date") = Now
                                rw.Item("Last_Updated_By") = username
                            End If
                        Next
                    End If
                End If
            End If

            If STATE = "ADD" Then
                Try
                    If Not gvJurnal.RowCount < 0 Then
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
                    Else
                        myBuilder = New SqlCommandBuilder(daJurnal)
                        daJurnal.UpdateCommand = myBuilder.GetUpdateCommand()
                        daJurnal.InsertCommand = myBuilder.GetInsertCommand()
                        daJurnal.DeleteCommand = myBuilder.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daJurnal.UpdateCommand.Transaction = BTRANS
                        daJurnal.InsertCommand.Transaction = BTRANS
                        daJurnal.DeleteCommand.Transaction = BTRANS

                        daJurnal.Update(dsJurnal.Tables("Jurnal"))

                        dsJurnal.Tables("Jurnal").AcceptChanges()
                    End If

                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    cancel_click()
                    dsJurnal.Tables("Jurnal").Clear()
                    dsJurnal.Tables("JurnalD").Clear()
                Catch e As Exception
                    BTRANS.Rollback()
                    dsJurnal.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    dsJurnal.Tables("JurnalD").RejectChanges()
                    MsgBox(e.Message)
                End Try
            ElseIf STATE = "EDIT" Then
                Try
                    If Not gvJurnal.RowCount < 0 Then
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

                        daJurnal.Update(dsCari.Tables("JurnalCari"))
                        daJurnalD.Update(dsCari.Tables("JurnalDCari"))

                        dsCari.Tables("JurnalCari").AcceptChanges()
                        dsCari.Tables("JurnalDCari").AcceptChanges()
                    Else
                        myBuilder = New SqlCommandBuilder(daJurnal)
                        daJurnal.UpdateCommand = myBuilder.GetUpdateCommand()
                        daJurnal.InsertCommand = myBuilder.GetInsertCommand()
                        daJurnal.DeleteCommand = myBuilder.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daJurnal.UpdateCommand.Transaction = BTRANS
                        daJurnal.InsertCommand.Transaction = BTRANS
                        daJurnal.DeleteCommand.Transaction = BTRANS

                        daJurnal.Update(dsCari.Tables("JurnalCari"))

                        dsCari.Tables("JurnalCari").AcceptChanges()
                    End If

                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    dsJurnal.Tables("Jurnal").Clear()
                    dsJurnal.Tables("JurnalD").Clear()
                    cancel_click()
                Catch e As Exception
                    BTRANS.Rollback()
                    dsCari.Tables("JurnalCari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    dsCari.Tables("JurnalDCari").RejectChanges()
                    MsgBox(e.Message)
                End Try
            Else
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

                    daJurnal.Update(dsCari.Tables("JurnalCari"))
                    daJurnalD.Update(dsCari.Tables("JurnalDCari"))

                    dsCari.Tables("JurnalCari").AcceptChanges()
                    dsCari.Tables("JurnalDCari").AcceptChanges()

                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    dsCari.Tables("JurnalCari").Clear()
                    dsCari.Tables("JurnalDCari").Clear()
                    cancel_click()
                Catch e As Exception
                    BTRANS.Rollback()
                    dsCari.Tables("JurnalCari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    dsCari.Tables("JurnalDCari").RejectChanges()
                    MsgBox(e.Message)
                End Try
            End If
        Else
            MsgBox("Data berikut tidak boleh kosong :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
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

    Private Sub txtValuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValuta.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
                'MsgBox("Diisi dengan angka.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "WARNING!")
        End Select
    End Sub

    Private Sub gvJurnal_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvJurnal.CellValueChanged
        If e.Column Is saldo_val_debet Then
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString * txtValuta.Text
        End If
        If e.Column Is saldo_val_kredit Then
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString * txtValuta.Text
        End If
    End Sub

    Private Sub gvJurnal_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvJurnal.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvJurnal.RowCount + 1)
    End Sub

    Private Sub frmJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        txtValuta.Text = 1
    End Sub

    Private Sub cek()
        If txtRef.Text = "" Then
            isvalid = False
            err &= "No. Referensi" & vbCrLf
            If txtNama.Text = "" Then
                err &= "Kepada" & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat" & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan" & vbCrLf
            End If
        ElseIf txtNama.Text = "" Then
            isvalid = False
            err &= "Kepada" & vbCrLf
            If txtRef.Text = "" Then
                err &= "No. Referensi" & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat" & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan" & vbCrLf
            End If
        ElseIf txtAlamat.Text = "" Then
            isvalid = False
            err &= "Alamat" & vbCrLf
            If txtRef.Text = "" Then
                err &= "No. Referensi" & vbCrLf
            End If
            If txtNama.Text = "" Then
                err &= "Kepada" & vbCrLf
            End If
            If txtKet.Text = "" Then
                err &= "Keterangan" & vbCrLf
            End If
        ElseIf txtKet.Text = "" Then
            isvalid = False
            err &= "Keterangan" & vbCrLf
            If txtRef.Text = "" Then
                err &= "No. Referensi" & vbCrLf
            End If
            If txtNama.Text = "" Then
                err &= "Kepada" & vbCrLf
            End If
            If txtAlamat.Text = "" Then
                err &= "Alamat" & vbCrLf
            End If
        Else
            isvalid = True
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsCari = New DataSet
        daJurnal = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kodeCari = frmCari.row("no_jur").ToString
            daJurnal = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL where no_jur='" & kodeCari & "'", sqlconn)) '<- query buat ditampilkan di LOV
            daJurnal.Fill(dsCari, "JurnalCari")
            daJurnalD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL_D where no_jur='" & kodeCari & "'", sqlconn))
            daJurnalD.Fill(dsCari, "JurnalDCari") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            gcJurnal.DataSource = dsCari.Tables("JurnalDCari")

            'If dSO.Tables("SIF_AREA").Rows.Count > 0 Then
            txtNoJur.Text = kodeCari
            dtpTanggal.Value = frmCari.row("tgl_trans").ToString
            txtRef.Text = frmCari.row("no_ref1").ToString
            lueValuta.EditValue = frmCari.row("kd_valuta").ToString
            txtValuta.Text = frmCari.row("kurs_valuta").ToString
            txtNama.Text = frmCari.row("nama").ToString
            txtAlamat.Text = frmCari.row("alamat").ToString
            txtKet.Text = frmCari.row("keterangan").ToString
            'cbStatus.EditValue = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
            'Else
            '    MsgBox("Data tidak diketemukan")
            'End If
            btnSave = True
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If

    End Sub

    Private Sub loadList()
        'dsJurnal.Tables("Valuta").Clear()
        'dsJurnal.Tables("BukuBesar").Clear()
        'dsJurnal.Tables("Kartu").Clear()
        'dsJurnal.Tables("BukuPusat").Clear()
        daJurnal = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daJurnal.Fill(dsJurnal, "Valuta")
        lueValuta.Properties.DataSource = dsJurnal.Tables("Valuta")
        lueValuta.Properties.DisplayMember = "Nama_Valuta"
        lueValuta.Properties.ValueMember = "Kode_Valuta"
        daBB = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar", sqlconn))
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

    Private Sub loadData()
        If STATE = "ADD" Then
            dsJurnal = New DataSet
            daJurnal = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL", sqlconn)) '<- query buat ditampilkan di LOV
            daJurnal.Fill(dsJurnal, "Jurnal")
            daJurnalD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL_D where no_jur='" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
            daJurnalD.Fill(dsJurnal, "JurnalD")
            gcJurnal.DataSource = dsJurnal.Tables("JurnalD")
            'gvJurnal.BestFitColumns()
            'Else
            '    dsCari = New DataSet
            '    daJurnal = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL", sqlconn)) '<- query buat ditampilkan di LOV
            '    daJurnal.Fill(dsCari, "JurnalCari")
            '    daJurnalD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_JURNAL_D where no_jur='" & dsCari.Tables("JurnalCari").Rows(1).ToString & "'", sqlconn)) '<- query buat ditampilkan di LOV
            '    daJurnalD.Fill(dsCari, "JurnalDCari")
            '    gcJurnal.DataSource = dsCari.Tables("JurnalDCari")
            '    gvJurnal.BestFitColumns()
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & kodeCari & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            'STATE = "DELETE"
            If Not dsCari.Tables("JurnalCari") Is Nothing Then
                For Each rw As DataRow In dsCari.Tables("JurnalCari").Rows
                    rw.Delete()
                Next
            End If
            If Not dsCari.Tables("JurnalDCari") Is Nothing Then
                For Each rw As DataRow In dsCari.Tables("JurnalDCari").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
            STATE = ""
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        'If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In dsCari.Tables("JurnalDCari").Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("no_seq") = i
                i += 1
            End If
        Next
    End Sub

    Private Sub gcJurnal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcJurnal.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvJurnal.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Jurnal yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                    gvJurnal.DeleteSelectedRows()
                    refreshNomer()
                End If
            End If
        End If
    End Sub
End Class