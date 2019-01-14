Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmJurnalJRR
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
        btnCetak = True
        setStatus()
        loadData("XXX")
    End Sub

    Private Sub ClearAll()
        txtNoJur.ReadOnly = True
        dtpTanggal.Enabled = True
        txtRef.ReadOnly = False
        lueValuta.Enabled = True
        txtValuta.ReadOnly = False
        lckUnit.Properties.ReadOnly = False
        txtAlamat.ReadOnly = False
        txtKet.ReadOnly = False
        gvJurnal.OptionsBehavior.ReadOnly = False
        txtNoJur.Text = ""
        dtpTanggal.Text = ""
        txtRef.Text = ""
        lueValuta.EditValue = "IDR"
        txtValuta.Text = 1
        lckUnit.EditValue = ""
        txtAlamat.Text = ""
        txtKet.Text = ""
        gcJurnal.DataSource = vbNull
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                If STATE = "ADD" Then
                    If kode Is Nothing Then
                        kode = getNoTrans("JRR", dtpTanggal.Value)
                        txtNoJur.Text = kode
                    End If
                    row = dsJurnal.Tables("Jurnal").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JRR-KBB-01"
                    row.Item("no_jur") = txtNoJur.Text
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                Else
                    row = dsJurnal.Tables("Jurnal").Rows(0)
                    row.Item("Last_Update_Date") = getTanggal()
                    row.Item("Last_Updated_By") = umum.username
                End If

                row.Item("tgl_trans") = dtpTanggal.Value
                row.Item("no_ref1") = txtRef.Text
                row.Item("kd_valuta") = "IDR"
                row.Item("kurs_valuta") = 1
                row.Item("kd_kartu") = lckUnit.EditValue
                row.Item("alamat") = txtAlamat.Text
                row.Item("keterangan") = txtKet.Text
                row.Item("thnbln") = Format(dtpTanggal.Value, "yyyyMM")
                row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)

                If STATE = "ADD" Then
                    dsJurnal.Tables("Jurnal").Rows.Add(row)
                End If

                If Not gvJurnal.RowCount = 0 Then
                    For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw("Kd_Cabang") = getKodeCabang()
                            rw("tipe_trans") = "JRR-KBB-01"
                            rw("no_jur") = txtNoJur.Text
                            rw("kd_valuta") = "IDR"
                            rw("kurs_valuta") = 1
                            rw("Last_Create_Date") = getTanggal()
                            rw("Last_Created_By") = umum.username
                            rw("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw.Item("Last_Update_Date") = getTanggal()
                            rw.Item("Last_Updated_By") = username
                        End If
                    Next
                End If
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
                showMessages("Berhasil dihapus.")
            Else
                showMessages("Berhasil disimpan.")
            End If
            cancel_click()
        Catch e As Exception
            BTRANS.Rollback()
            dsJurnal.Tables("Jurnal").RejectChanges()
            dsJurnal.Tables("JurnalD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub cancel_click()
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        btnCetak = True
        setStatus()
        Me.Enabled = False
        ClearAll()
        lueValuta.EditValue = "IDR"
        txtValuta.Text = 1
        txtValuta.ReadOnly = True
        gvJurnal.BestFitColumns()
        STATE = ""
    End Sub

    Private Sub frmJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        lueValuta.EditValue = "IDR"
        txtValuta.Text = 1
        txtValuta.ReadOnly = True
        gvJurnal.BestFitColumns()
    End Sub

    Private Sub cek()
        If Not lueValuta.EditValue = "IDR" Then
            If txtValuta.Text = 1 Then
                isvalid = False
                err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                If gvJurnal.Columns("saldo_val_debet").SummaryText.Equals(vbNullString) Or gvJurnal.Columns("saldo_val_debet").SummaryText.Equals("0,00") Then
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
        'dsCari = New DataSet
        If Not dsCari.Tables("LookJurnal") Is Nothing Then dsCari.Tables("LookJurnal").Clear()
        daJurnal = New SqlDataAdapter(New SqlCommand("select tgl_trans as 'Tanggal Transaksi', no_jur as 'No. Jurnal', no_ref1 as 'No. Ref', nama as 'Nama', keterangan as 'Keterangan', jml_val_trans AS 'Jumlah' from KOPKAR.dbo.FIN_JURNAL where tipe_trans = 'JRR-KBB-01'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsCari, "LookJurnal")
        frmCari.set_dso(dsCari.Tables("LookJurnal"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMM yyyy"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Jurnal").ToString)

            With dsJurnal.Tables("Jurnal")(0)
                txtNoJur.Text = .Item("no_jur")
                dtpTanggal.Value = .Item("tgl_trans")
                txtRef.Text = .Item("no_ref1")
                lueValuta.EditValue = .Item("kd_valuta")
                txtValuta.Text = .Item("kurs_valuta")
                lckUnit.EditValue = .Item("kd_kartu")
                txtAlamat.Text = .Item("alamat")
                txtKet.Text = .Item("keterangan")
            End With

            If Not dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting") Is DBNull.Value Or dsJurnal.Tables("Jurnal").Rows(0).Item("no_posting").Equals("") Then
                MsgBox("Jurnal Kas dengan nomor : " & kodeCari & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                txtNoJur.ReadOnly = True
                dtpTanggal.Enabled = False
                txtRef.ReadOnly = True
                lueValuta.Enabled = False
                txtValuta.ReadOnly = True
                lckUnit.Properties.ReadOnly = True
                txtAlamat.ReadOnly = True
                txtKet.ReadOnly = True

                gvJurnal.OptionsBehavior.ReadOnly = True

                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCetak = True
                setStatus()
            Else
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnCetak = True
                setStatus()
                gvJurnal.BestFitColumns()
                gcJurnal.RefreshDataSource()
            End If
        Else
            cancel_click()
        End If
    End Sub

    Private Sub loadBB(ByVal kode As String)
        If Not dsCari.Tables("rekening") Is Nothing Then dsCari.Tables("rekening").Clear()

        daBB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT b.kd_buku_besar, b.nm_buku_besar 'Rekening', (SELECT cc.nm_buku_besar FROM KOPKAR.dbo.m_buku_besar cc WHERE cc.kd_buku_besar = b.grup_level3) AS 'Grup Rekening 1', (SELECT dd.nm_buku_besar FROM KOPKAR.dbo.m_buku_besar dd WHERE dd.kd_buku_besar = b.grup_level2) AS 'Grup Rekening 2', (SELECT dd.nm_buku_besar FROM KOPKAR.dbo.m_buku_besar dd WHERE dd.kd_buku_besar = b.grup_level1) AS 'Grup Rekening 3' FROM KOPKAR.dbo.m_buku_besar b WHERE b.grup_header='D' and b.rec_stat='Y' AND b.pola_entry LIKE '%" & kode & "%' ORDER BY b.kd_buku_besar", sqlconn))
        daBB.Fill(dsCari, "rekening")
        LOVRekBiaya.DataSource = dsCari.Tables("rekening")
        LOVRekBiaya.DisplayMember = "Rekening"
        LOVRekBiaya.ValueMember = "kd_buku_besar"
        'RepositoryItemGridLookUpEdit1View.Columns("kd_buku_besar").Visible = False
    End Sub

    Private Sub loadUnit()
        If Not dsJurnal.Tables("BukuPusat") Is Nothing Then dsJurnal.Tables("BukuPusat").Clear()

        daBP = New SqlDataAdapter(New SqlCommand("SELECT Id_Data kd_buku_pusat, Desc_Data nm_buku_pusat FROM KOPKAR.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data = 'UNITKOPKAR' AND Rec_Stat = 'Y'", sqlconn))
        daBP.Fill(dsJurnal, "BukuPusat")
        lueBP.DataSource = dsJurnal.Tables("BukuPusat")
        lueBP.DisplayMember = "nm_buku_pusat"
        lueBP.ValueMember = "kd_buku_pusat"
        lckUnit.Properties.DataSource = dsJurnal.Tables("BukuPusat")
        lckUnit.Properties.DisplayMember = "nm_buku_pusat"
        lckUnit.Properties.ValueMember = "kd_buku_pusat"
    End Sub

    Private Sub loadList()
        loadBB("")
        loadUnit()
        If Not dsJurnal.Tables("Valuta") Is Nothing Then dsJurnal.Tables("Valuta").Clear()
        If Not dsJurnal.Tables("Kartu") Is Nothing Then dsJurnal.Tables("Kartu").Clear()

        daJurnal = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from KOPKAR.dbo.SIF_Valuta", sqlconn))
        daJurnal.Fill(dsJurnal, "Valuta")
        lueValuta.Properties.DataSource = dsJurnal.Tables("Valuta")
        lueValuta.Properties.DisplayMember = "Nama_Valuta"
        lueValuta.Properties.ValueMember = "Kode_Valuta"

        daKartu = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM KOPKAR.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsJurnal, "Kartu")
        lueKartu.DataSource = dsJurnal.Tables("Kartu")
        lueKartu.DisplayMember = "nama"
        lueKartu.ValueMember = "kode"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()
        daJurnal = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_JURNAL WHERE no_jur = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsJurnal, "Jurnal")
        daJurnalD = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_JURNAL_D WHERE no_jur = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnalD.Fill(dsJurnal, "JurnalD")
        gcJurnal.DataSource = dsJurnal.Tables("JurnalD")
        gvJurnal.BestFitColumns()
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & kodeCari & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
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
            save_click(True)
            STATE = ""
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If STATE = "ADD" Then
            If gvJurnal.RowCount = 0 Then
                Exit Sub
            Else
                For j As Integer = 0 To gvJurnal.RowCount - 1
                    gvJurnal.GetDataRow(j).Item("no_seq") = i
                    i += 1
                Next
            End If
        End If
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

    Private Sub gvJurnal_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvJurnal.CellValueChanged
        Dim View As ColumnView = sender
        If e.Column Is saldo_val_debet Then
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet").ToString * txtValuta.Text
            gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = "0"
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = "0"
        End If

        If e.Column Is saldo_val_kredit Then
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_kredit") = gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit").ToString * txtValuta.Text
            gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = "0"
            gvJurnal.GetRow(e.RowHandle).item("saldo_rp_debet") = "0"
        End If

        'If e.Column Is kd_buku_besar Then
        '    Dim sqlDR As SqlDataReader = New SqlCommand("SELECT pola_entry FROM KOPKAR.dbo.m_buku_besar WHERE kd_buku_besar = '" & e.Value & "'", sqlconn).ExecuteReader
        '    sqlDR.Read()
        '    If sqlDR.HasRows Then
        '        gvJurnal.GetRow(e.RowHandle).item("kd_buku_pusat") = sqlDR.Item("pola_entry")
        '    End If
        '    sqlDR.Close()
        'End If
    End Sub

    Private Sub gvJurnal_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvJurnal.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvJurnal.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_buku_pusat"), lckUnit.EditValue)
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_debet") = "0"
        gvJurnal.GetRow(e.RowHandle).item("saldo_val_kredit") = "0"
    End Sub

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtValuta.Text = 1
            txtValuta.ReadOnly = True
        Else
            txtValuta.ReadOnly = False
        End If
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

    Private Sub txtValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.TextChanged
        Dim deb As String = ""
        Dim kre As String = ""
        If Not txtValuta.Text Like 0 Then
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
        End If
    End Sub

    Public Sub cetak_click()
        If Not kodeCari.ToString = "" Then
            callReport(App_Path() & "\report\repBuktiJRR.rpt", "", "jurnal=" & kodeCari, False)
        End If
    End Sub

    Private Sub lckUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lckUnit.EditValueChanged
        loadBB(lckUnit.EditValue)
    End Sub
End Class