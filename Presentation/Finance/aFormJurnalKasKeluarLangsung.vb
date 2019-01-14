Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormJurnalKasKeluarLangsung
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
    Dim isvalid As Boolean
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
        controlOff(False)
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        txtNoJur.ReadOnly = stat
        dtpTanggal.Properties.ReadOnly = stat
        txtRef.Properties.ReadOnly = stat
        lueValuta.Properties.ReadOnly = stat
        txtValuta.Properties.ReadOnly = stat
        txtNama.Properties.ReadOnly = stat
        txtAlamat.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvJurnal.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub ClearAll()
        txtNoJur.Text = ""
        'dtpTanggal.EditValue = getTanggal()
        txtRef.EditValue = vbNullString
        lueValuta.EditValue = "IDR"
        txtValuta.EditValue = 1
        lookRekKasBank.EditValue = Nothing
        txt_selisih.EditValue = 0
        txt_JumlahBayar.EditValue = 0
        txtNama.EditValue = vbNullString
        txtAlamat.EditValue = vbNullString
        txtKet.EditValue = vbNullString
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)

        cek()
        If isvalid Then
            Try
                If Not isDelete Then
                    If STATE = "ADD" Then
                        txtNoJur.Text = getNoTrans("JKM", dtpTanggal.EditValue, BTRANS)
                        row = dsJurnal.Tables("Jurnal").NewRow
                        row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                        row.Item("tipe_trans") = "JKK-KBB-10"
                        row.Item("no_jur") = txtNoJur.Text
                        row.Item("tgl_trans") = dtpTanggal.EditValue
                        row.Item("no_ref1") = txtRef.EditValue
                        row.Item("kd_valuta") = IIf(lueValuta.EditValue = vbNullString, "IDR", lueValuta.EditValue)
                        row.Item("kurs_valuta") = txtValuta.EditValue
                        row.Item("nama") = txtNama.EditValue
                        row.Item("alamat") = txtAlamat.EditValue
                        row.Item("keterangan") = txtKet.EditValue
                        row.Item("thnbln") = dtpTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtpTanggal.EditValue, DateFormat.GeneralDate), 4, 2)
                        'row.Item("thnbln") = FormatDateTime(dtpTanggal.Value.Month, 00).ToString()
                        'row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)
                        'row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, 0, gvJurnal.Columns("saldo_val_debet").SummaryText)
                        row.Item("jml_val_trans") = IIf(txt_JumlahBayar.EditValue = vbNullString, 0, txt_JumlahBayar.EditValue)
                        row.Item("jml_rp_trans") = IIf(txt_JumlahBayar.EditValue = vbNullString, 0, txt_JumlahBayar.EditValue)
                        row.Item("Last_create_date") = getTanggal()
                        row.Item("Last_created_by") = username
                        row.Item("Program_name") = Me.Name
                        dsJurnal.Tables("Jurnal").Rows.Add(row)
                    ElseIf STATE = "EDIT" Then
                        row = dsJurnal.Tables("Jurnal").Rows(0)
                        row("tgl_trans") = dtpTanggal.EditValue
                        row("no_ref1") = txtRef.EditValue
                        row("kd_valuta") = lueValuta.EditValue
                        row("kurs_valuta") = txtValuta.EditValue
                        row.Item("jml_val_trans") = IIf(txt_JumlahBayar.EditValue = vbNullString, 0, txt_JumlahBayar.EditValue)
                        row.Item("jml_rp_trans") = IIf(txt_JumlahBayar.EditValue = vbNullString, 0, txt_JumlahBayar.EditValue)
                        row("nama") = txtNama.EditValue
                        row("alamat") = txtAlamat.EditValue
                        row("keterangan") = txtKet.EditValue
                        row("Last_Update_Date") = getTanggal()
                        row("Last_Updated_By") = umum.username
                    End If

                    If STATE = "ADD" Then
                        For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                            If rw.RowState = DataRowState.Added Then
                                rw("Kd_Cabang") = getKodeCabang()
                                rw("tipe_trans") = "JKM-KBB-04"
                                rw("kartu") = "00000000"
                                rw("kd_buku_pusat") = "00000000"
                                rw("no_jur") = txtNoJur.Text
                                rw("kd_valuta") = lueValuta.EditValue
                                rw("kurs_valuta") = txtValuta.EditValue
                                rw("Last_Create_Date") = getTanggal()
                                rw("Last_Created_By") = username
                                rw("Programe_name") = Me.Name
                            ElseIf rw.RowState = DataRowState.Modified Then
                                rw.Item("Last_Update_Date") = getTanggal()
                                rw.Item("Last_Updated_By") = username
                            End If
                        Next

                        Dim no_seq, no_seq_max As Integer

                        no_seq = dsJurnal.Tables("JurnalD").Compute(" max(no_seq)", "")
                        no_seq_max = no_seq + 1

                        row = dsJurnal.Tables("JurnalD").NewRow
                        row("Kd_Cabang") = getKodeCabang()
                        row("tipe_trans") = "JKM-KBB-04"
                        row("kartu") = "00000000"
                        row("kd_buku_pusat") = "00000000"
                        row("kd_buku_besar") = lookRekKasBank.EditValue
                        row("no_seq") = no_seq_max
                        row("kd_buku_pusat") = "00000000"
                        row("saldo_val_kredit") = txt_JumlahBayar.EditValue
                        row("saldo_rp_kredit") = txt_JumlahBayar.EditValue
                        row("saldo_val_debet") = 0
                        row("saldo_rp_debet") = 0
                        row("no_jur") = txtNoJur.Text
                        row("kd_valuta") = lueValuta.EditValue
                        row("kurs_valuta") = txtValuta.EditValue
                        row("Last_Create_Date") = getTanggal()
                        row("Last_Created_By") = username
                        row("Programe_name") = Me.Name
                        dsJurnal.Tables("JurnalD").Rows.Add(row)

                    ElseIf STATE = "EDIT" Then
                        For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                            If rw.RowState = DataRowState.Added Then
                                rw("Kd_Cabang") = getKodeCabang()
                                rw("tipe_trans") = "JKM-KBB-04"
                                rw("kartu") = "00000000"
                                rw("kd_buku_pusat") = "00000000"
                                rw("no_jur") = txtNoJur.Text
                                rw("kd_valuta") = lueValuta.EditValue
                                rw("kurs_valuta") = txtValuta.EditValue
                                rw("Last_Create_Date") = getTanggal()
                                rw("Last_Created_By") = username
                                rw("Programe_name") = Me.Name
                            ElseIf rw.RowState = DataRowState.Modified Then
                                rw.Item("Last_Update_Date") = getTanggal()
                                rw.Item("Last_Updated_By") = username
                            ElseIf rw.RowState = DataRowState.Deleted Then

                            End If
                        Next
                        Dim no_seq, no_seq_max As Integer

                        no_seq = dsJurnal.Tables("JurnalD").Compute(" max(no_seq)", "")
                        no_seq_max = no_seq + 1

                        row = dsJurnal.Tables("JurnalD").NewRow
                        row("Kd_Cabang") = getKodeCabang()
                        row("tipe_trans") = "JKM-KBB-04"
                        row("kartu") = "00000000"
                        row("kd_buku_pusat") = "00000000"
                        row("kd_buku_besar") = lookRekKasBank.EditValue
                        row("no_seq") = no_seq_max
                        row("kd_buku_pusat") = "00000000"
                        row("saldo_val_debet") = txt_JumlahBayar.EditValue
                        row("saldo_rp_debet") = txt_JumlahBayar.EditValue
                        row("saldo_val_kredit") = 0
                        row("saldo_rp_kredit") = 0
                        row("no_jur") = txtNoJur.Text
                        row("kd_valuta") = lueValuta.EditValue
                        row("kurs_valuta") = txtValuta.EditValue
                        row("Last_Create_Date") = getTanggal()
                        row("Last_Created_By") = username
                        row("Programe_name") = Me.Name
                        dsJurnal.Tables("JurnalD").Rows.Add(row)
                    End If

                End If

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
                If Not isDelete Then
                    showMessages("Berhasil disimpan.")
                    If STATE = "ADD" Then
                        cetak_click()
                    End If
                    STATE = "EDIT"
                    'ClearAll()
                    loadData(txtNoJur.Text)
                Else
                    showMessages("Berhasil dihapus.")
                    cancel_click()
                End If
            Catch e As Exception
                BTRANS.Rollback()
                dsJurnal.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsJurnal.Tables("JurnalD").RejectChanges()
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
        lueValuta.EditValue = "IDR"
        txtValuta.Text = 1
        txtValuta.Properties.ReadOnly = True
        loadData("XXX")
    End Sub

    Private Sub aFormJurnalKasBon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        dtpTanggal.EditValue = getTanggal()
        lueValuta.EditValue = "IDR"
        txtValuta.EditValue = 1
        txtValuta.Properties.ReadOnly = True
    End Sub

    Private Sub cek()
        isvalid = False
        If Not lueValuta.EditValue = "IDR" Then
            If txtValuta.Text = 1 Then
                isvalid = False
                err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
                    If Not gvJurnal.Columns("saldo_val_debet").SummaryItem.SummaryValue = txt_JumlahBayar.EditValue Then
                        err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
                        If txt_selisih.EditValue < 0 Then
                            isvalid = False
                            err &= "Transaksi tidak boleh lebih besar dari jumlah saldo kas." & vbCrLf
                        End If
                    End If
                End If
            End If
            'ElseIf Not gvJurnal.Columns("saldo_val_debet").SummaryItem.SummaryValue = txt_JumlahBayar.EditValue Then
            '    isvalid = False
            '    err &= "Jumlah Valuta debet dan kredit tidak sama." & vbCrLf
            '    If txtValuta.EditValue = 1 Then
            '        If Not lueValuta.EditValue = "IDR" Then
            '            isvalid = False
            '            err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
            '            If txt_selisih.EditValue < 0 Then
            '                isvalid = False
            '                err &= "Transaksi tidak boleh lebih besar dari jumlah saldo kas." & vbCrLf
            '            End If
            '        End If
            '    End If
        ElseIf gvJurnal.RowCount = 0 Then
            If STATE = "ADD" Then
                isvalid = False
                err &= "Data pelunasan belum diisi." & vbCrLf
            Else
                isvalid = True
            End If
        ElseIf txt_selisih.EditValue < 0 Then
            isvalid = False
            err &= "Transaksi tidak boleh lebih besar dari jumlah saldo kas." & vbCrLf

        Else

            isvalid = True
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsCari = New DataSet
        daJurnal = New SqlDataAdapter(New SqlCommand("select tgl_trans as 'Tanggal Transaksi', no_jur as 'No. Jurnal', no_ref1 as 'No. Ref', nama as 'Nama', alamat as 'Alamat', keterangan as 'Keterangan', kd_valuta as 'Valuta', kurs_valuta as 'Kurs', jml_val_trans as 'Jumlah Bayar' from KOPKAR.dbo.FIN_JURNAL where tipe_trans = 'JKM-KBB-04'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Kurs").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Jumlah Bayar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Kurs").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("Jumlah Bayar").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Jurnal"))

            If Not (dsJurnal.Tables("Jurnal").Rows(0)("no_posting").ToString = vbNullString Or dsJurnal.Tables("Jurnal").Rows(0)("no_posting").ToString = "") Then
                MsgBox("Jurnal Kas dengan nomor : " & txtNoJur.Text & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")

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

    Private Sub loadList()
        If Not dsJurnal.Tables("Valuta") Is Nothing Then dsJurnal.Tables("Valuta").Clear()
        If Not dsJurnal.Tables("BukuBesar") Is Nothing Then dsJurnal.Tables("BukuBesar").Clear()
        If Not dsJurnal.Tables("BukuBesarKas") Is Nothing Then dsJurnal.Tables("BukuBesarKas").Clear()
        If Not dsJurnal.Tables("Kartu") Is Nothing Then dsJurnal.Tables("Kartu").Clear()
        If Not dsJurnal.Tables("BukuPusat") Is Nothing Then dsJurnal.Tables("BukuPusat").Clear()

        daJurnal = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from KOPKAR.dbo.SIF_Valuta", sqlconn))
        daJurnal.Fill(dsJurnal, "Valuta")
        lueValuta.Properties.DataSource = dsJurnal.Tables("Valuta")
        lueValuta.Properties.DisplayMember = "Nama_Valuta"
        lueValuta.Properties.ValueMember = "Kode_Valuta"

        daJurnal = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar as Nama_Buku_Besar " & _
                                                     "FROM KOPKAR.dbo.m_buku_besar " & _
                                                     "WHERE grup_header='D' and " & _
                                                     "kd_buku_besar in (Select d.Val_kode1 " & _
                                                     "From KOPKAR.dbo.SIF_Gen_Reff_D d " & _
                                                     "where d.Id_Ref_Data in ('KKL','KBL')) order by kd_buku_besar ", sqlconn))
        daJurnal.Fill(dsJurnal, "BukuBesarKas")
        lookRekKasBank.Properties.DataSource = dsJurnal.Tables("BukuBesarKas")
        lookRekKasBank.Properties.DisplayMember = "Nama_Buku_Besar"
        lookRekKasBank.Properties.ValueMember = "kd_buku_besar"
        gridKasBank.Columns("kd_buku_besar").Visible = False


        daBB = New SqlDataAdapter(New SqlCommand("SELECT ( " & _
                                                "SELECT Desc_Data " & _
                                                "FROM KOPKAR.dbo.SIF_Gen_Reff_D " & _
                                                "WHERE Id_Ref_Data = 'UNITKOPKAR' " & _
                                                "AND Val_kode1= pola_entry " & _
                                                ") Unit, kd_buku_besar kode, nm_buku_besar nama " & _
                                                "FROM KOPKAR.dbo.m_buku_besar " & _
                                                "WHERE grup_header='D' AND grup_level3 LIKE '5%' and " & _
                                                "kd_buku_besar not in ( " & _
                                                "SELECT kd_buku_besar " & _
                                                "FROM KOPKAR.dbo.m_buku_besar " & _
                                                "WHERE grup_header='D' and " & _
                                                "kd_buku_besar in ( " & _
                                                "Select d.Val_kode1 " & _
                                                "From KOPKAR.dbo.SIF_Gen_Reff_D d " & _
                                                "where d.Id_Ref_Data in ('KKL','KBL'))) " & _
                                                "order by pola_entry, kd_buku_besar", sqlconn))
        daBB.Fill(dsJurnal, "BukuBesar")
        lueBB.DataSource = dsJurnal.Tables("BukuBesar")
        lueBB.DisplayMember = "nama"
        lueBB.ValueMember = "kode"
        lookBeban.DataSource = dsJurnal.Tables("BukuBesar")
        lookBeban.DisplayMember = "nama"
        lookBeban.ValueMember = "kode"
        'repGridBeban.Columns("kode").Visible = False


        daKartu = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM KOPKAR.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsJurnal, "Kartu")
        lueKartu.DataSource = dsJurnal.Tables("Kartu")
        lueKartu.DisplayMember = "nama"
        lueKartu.ValueMember = "kode"

        daBP = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM KOPKAR.dbo.SIF_buku_pusat", sqlconn))
        daBP.Fill(dsJurnal, "BukuPusat")
        lueBP.DataSource = dsJurnal.Tables("BukuPusat")
        lueBP.DisplayMember = "nm_buku_pusat"
        lueBP.ValueMember = "kd_buku_pusat"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()
        daJurnal = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_JURNAL where no_jur = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsJurnal, "Jurnal")
        daJurnalD = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_JURNAL_D where no_jur = '" & kode & "' ", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnalD.Fill(dsJurnal, "JurnalD")

        If STATE = "EDIT" Then
            For i = dsJurnal.Tables("JurnalD").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = dsJurnal.Tables("JurnalD").Rows(i)
                If rows("saldo_val_debet") > 0 Then
                    txt_JumlahBayar.EditValue = rows("saldo_val_debet")
                    lookRekKasBank.EditValue = rows("kd_buku_besar")
                    dsJurnal.Tables("JurnalD").Rows(i).Delete()
                End If
            Next
        End If

        gcJurnal.DataSource = dsJurnal.Tables("JurnalD")
        gvJurnal.BestFitColumns()

        If dsJurnal.Tables("Jurnal").Rows.Count > 0 Then
            txtNoJur.Text = dsJurnal.Tables("Jurnal").Rows(0)("no_jur")
            dtpTanggal.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("tgl_trans")
            txtRef.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("no_ref1")
            lueValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("kd_valuta")
            txtValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("kurs_valuta")
            txtNama.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("nama")
            txtAlamat.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("alamat")
            txtKet.EditValue = dsJurnal.Tables("Jurnal").Rows(0)("keterangan")
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & txtNoJur.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            'STATE = "DELETE"
            'For Each rw As DataRow In dsJurnal.Tables("Jurnal").Rows
            Dim i As Int16 = New SqlCommand("delete KOPKAR.dbo.FIN_JURNAL  where no_jur ='" & txtNoJur.Text & "'", sqlconn).ExecuteNonQuery
            Dim j As Int16 = New SqlCommand("delete KOPKAR.dbo.FIN_JURNAL_D  where no_jur ='" & txtNoJur.Text & "'", sqlconn).ExecuteNonQuery

            'Next
            'For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
            '    rw.Delete()
            'Next
            cancel_click()
            'save_click(True)
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
                If MsgBox("Hapus Daftar Jurnal yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                    gvJurnal.DeleteSelectedRows()
                    refreshNomer()
                    hitung_selisih()
                End If
            End If
        End If
    End Sub

    Private Sub gvJurnal_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvJurnal.CellValueChanged
        Dim View As ColumnView = sender
        'If e.Column Is saldo_val_kredit Then
        '    If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
        '    Else
        '        If gvJurnal.GetRowCellValue(e.RowHandle, "kd_buku_besar") = "1011001" Then
        '            gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
        '            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = 0
        '        Else
        '            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString * txtValuta.Text
        '            gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
        '            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = 0
        '        End If
        '    End If
        'End If
        'If e.Column Is saldo_val_debet Then
        '    If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = 0
        '    Else
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString * txtValuta.Text
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
        '        gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = 0
        '    End If
        '    If Not gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0 Then
        '        'gvJurnal.GetRow(e.RowHandle).item("keterangan") = ""
        '    Else
        '        gvJurnal.GetRow(e.RowHandle).item("keterangan") = ""
        '    End If
        'End If

        If e.Column Is kd_buku_besar Then
            'Dim varTmp1 As String
            'Dim varTmp2 As String
            'Dim drPost As SqlDataReader
            'drPost = New SqlCommand("select nm_buku_besar, pola_entry from KOPKAR.dbo.SIF_buku_besar where kd_buku_besar = '" & gvJurnal.GetRow(e.RowHandle).item("kd_buku_besar") & "'", sqlconn).ExecuteReader
            'Do While drPost.Read()
            '    varTmp1 = (drPost.Item(0))
            '    varTmp2 = (drPost.Item(1))
            'Loop
            'drPost.Close()
            'If varTmp2 = "01" Then
            '    gvJurnal.GetRow(e.RowHandle).item("kartu") = "CST00000"
            '    gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            'ElseIf varTmp2 = "02" Then
            '    gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "00000000"
            'ElseIf varTmp2 = "03" Then
            '    gvJurnal.GetRow(e.RowHandle).item("kartu") = "CST00000"
            'End If
        End If
    End Sub

    Private Sub gvJurnal_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvJurnal.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvJurnal.RowCount + 1)
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = 0
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = 0
        gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = "90000001"
    End Sub

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtValuta.Text = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub gvJurnal_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvJurnal.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvJurnal_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvJurnal.InvalidRowException
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
        Else
            e.Valid = True
        End If

        'If view.GetRowCellValue(e.RowHandle, column1).ToString = "1011001" Then
        '    If view.GetRowCellValue(e.RowHandle, column3) = 0 Then
        '        e.Valid = False
        '        view.SetColumnError(column3, "Nominal kredit untuk kas kecil tidak boleh 0.")
        '    Else
        '        e.Valid = True
        '    End If
        '    If view.GetRowCellValue(e.RowHandle, column2) > 0 Then
        '        e.Valid = False
        '        view.SetColumnError(column2, "Nominal debet untuk kas kecil harus 0.")
        '    Else
        '        e.Valid = True
        '    End If
        'End If

    End Sub

    'Private Sub gvJurnal_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs)
    '    Dim vx As GridView = sender

    '    If vx.FocusedColumn.FieldName = "saldo_val_kredit" Then
    '        If vx.GetFocusedRowCellValue("kd_buku_besar").ToString = "1011001" Then
    '            If Not (e.Value = vbNull) Then
    '                If e.Value > 0 Then
    '                    e.Valid = False
    '                    e.Value = 0
    '                    e.ErrorText = "Hanya dapat mengisi nominal kredit untuk rekening ini."
    '                End If
    '            Else
    '                e.Value = 0
    '            End If
    '        End If
    '    End If

    '    If vx.FocusedColumn.FieldName = "saldo_val_debet" Then
    '        If Not (vx.GetFocusedRowCellValue("kd_buku_besar").ToString = "1011001") Then
    '            If Not (e.Value = vbNull) Then
    '                If e.Value > 0 Then
    '                    e.Valid = False
    '                    e.Value = 0
    '                    e.ErrorText = "Hanya dapat mengisi nominal debet untuk rekening selain Kas Kecil."
    '                End If
    '            End If
    '        End If
    '    End If

    '    'If vx.FocusedColumn.FieldName = "kd_buku_pusat" Then
    '    '    If Not gvJurnal.RowCount <= 0 Then
    '    '        For i As Integer = 0 To gvJurnal.RowCount
    '    '            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
    '    '            If Not e.Value = vx.GetRowCellValue(i, kd_buku_pusat) Then
    '    '                e.Valid = False
    '    '                e.ErrorText = "Pusat biaya tidak sama."
    '    '            End If
    '    '        Next
    '    '    End If
    '    'End If
    'End Sub

    Public Sub cetak_click()
        If Not txtNoJur.Text = "" Then
            If MsgBox("Cetak?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CETAK?") = MsgBoxResult.Yes Then
                Dim sqlx As New SqlCommand("update KOPKAR.dbo.fin_jurnal set jml_cetak=isnull(jml_cetak,0)+1, tgl_cetak=getdate() where no_jur='" & txtNoJur.Text & "'", sqlconn)
                sqlx.ExecuteNonQuery()
                callReport(App_Path() & "\report\CRBuktiJKKLangsung.rpt", "", "jurnal=" & txtNoJur.Text & "&nomor=" & txtNoJur.Text, True)
            Else
                'callReport(App_Path() & "\report\CRBuktiJKKLangsung.rpt", "", "jurnal=" & txtNoJur.Text & "&nomor=" & txtNoJur.Text, False, False, "", False)

            End If
        End If
    End Sub

    Private Sub txtValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        Dim deb As String = ""
        Dim kre As String = ""

        If txtValuta.EditValue.ToString = vbNullString Or txtValuta.EditValue.ToString = "" Then
            txtValuta.EditValue = 1
        End If

        If Not txtValuta.EditValue = 1 Then
            For j As Integer = 0 To gvJurnal.RowCount - 1
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_debet") = 0 Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    deb = gvJurnal.GetRowCellValue(j, "saldo_val_debet")

                    gvJurnal.SetRowCellValue(j, "saldo_rp_debet", deb * txtValuta.Text)
                End If
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_kredit") = 0 Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    kre = gvJurnal.GetRowCellValue(j, "saldo_val_kredit")

                    gvJurnal.SetRowCellValue(j, "saldo_rp_kredit", kre * txtValuta.Text)
                End If
            Next
        End If
    End Sub

    Private Sub lue_kas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookRekKasBank.EditValueChanged
        'txt_SaldoKas.Focus()
        reload_kas()
    End Sub
    Sub hitung_selisih()
        Dim total_selisih, jumlah_debet As Double
        'jumlah_debet = gvJurnal.Columns("saldo_val_debet").SummaryItem.SummaryValue
        If dsJurnal.Tables("JurnalD").Compute("sum(saldo_val_debet)", "").ToString <> "" Then jumlah_debet = dsJurnal.Tables("JurnalD").Compute("sum(saldo_val_debet)", "")
        total_selisih = txt_SaldoKas.EditValue + jumlah_debet
        txt_selisih.EditValue = total_selisih
        txt_JumlahBayar.EditValue = jumlah_debet
    End Sub
    Private Sub reload_kas()
        Dim dr As SqlDataReader = New SqlCommand("SELECT KOPKAR.dbo.hitungsaldoawal('" & lookRekKasBank.EditValue & "', 'IDR','" & Now.Year & "', '" & Now.Month & "', '" & IIf(Now.Day - 1 = 0, Now.Day, Now.Day) & "')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txt_SaldoKas.EditValue = dr.Item(0)
        Else
            txt_SaldoKas.EditValue = 0
        End If
        dr.Close()

    End Sub
    Private Sub txt_JumlahBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_JumlahBayar.EditValueChanged
        hitung_selisih()
    End Sub

    Private Sub gvJurnal_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvJurnal.RowUpdated
        hitung_selisih()
        txt_JumlahBayar.EditValue = gvJurnal.Columns("saldo_val_debet").SummaryItem.SummaryValue
    End Sub
End Class