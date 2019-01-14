Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormJurnal
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Public STATE As String
    Dim bldJurnal, bldJurnalD As New SqlCommandBuilder
    Dim dsJurnal As New DataSet
    Dim daJurnal, daJurnalD, daLookUp As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim row As DataRow
    Dim noJur As String
    Dim err As String = ""

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub clear()
        txtNoJurnal.EditValue = vbNullString
        decTanggal.EditValue = getTanggal()
        txtNoRef.EditValue = vbNullString
        lckValuta.EditValue = "IDR"
        txtKurs.EditValue = 1
        txtKurs.Properties.ReadOnly = True
        txtKepada.EditValue = vbNullString
        txtAlamat.Text = vbNullString
        txtKet.Text = vbNullString
        If Not dsJurnal.Tables("JurnalD") Is Nothing Then dsJurnal.Tables("JurnalD").Clear()
    End Sub

    Private Sub loadList()
        If Not dsJurnal.Tables("Valuta") Is Nothing Then dsJurnal.Tables("Valuta").Clear()
        If Not dsJurnal.Tables("BukuBesar") Is Nothing Then dsJurnal.Tables("BukuBesar").Clear()
        If Not dsJurnal.Tables("Kartu") Is Nothing Then dsJurnal.Tables("Kartu").Clear()
        If Not dsJurnal.Tables("BukuPusat") Is Nothing Then dsJurnal.Tables("BukuPusat").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daLookUp.Fill(dsJurnal, "Valuta")
        lckValuta.Properties.DataSource = dsJurnal.Tables("Valuta")
        lckValuta.Properties.DisplayMember = "Nama_Valuta"
        lckValuta.Properties.ValueMember = "Kode_Valuta"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D'", sqlconn))
        daLookUp.Fill(dsJurnal, "BukuBesar")
        lueBB.DataSource = dsJurnal.Tables("BukuBesar")
        lueBB.DisplayMember = "nm_buku_besar"
        lueBB.ValueMember = "kd_buku_besar"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookUp.Fill(dsJurnal, "Kartu")
        lueKartu.DataSource = dsJurnal.Tables("Kartu")
        lueKartu.DisplayMember = "nama"
        lueKartu.ValueMember = "kode"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM SIF.dbo.SIF_buku_pusat", sqlconn))
        daLookUp.Fill(dsJurnal, "BukuPusat")
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

        If dsJurnal.Tables("Jurnal").Rows.Count >= 1 Then
            txtNoJurnal.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("no_jur")
            decTanggal.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("tgl_trans")
            txtNoRef.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("no_ref1")
            lckValuta.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kd_valuta")
            txtKurs.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("kurs_valuta")
            txtKepada.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("nama")
            txtAlamat.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("alamat")
            txtKet.EditValue = dsJurnal.Tables("Jurnal").Rows(0).Item("keterangan")
            btnAdd = False
            btnCancel = True
            btnDelete = False
            btnEdit = False
            btnSave = True
            setStatus()
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

    Private Sub cek()
        If Not lckValuta.EditValue = "IDR" Then
            If txtKurs.EditValue = 1 Then
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
            If txtKurs.Text = 1 Then
                If Not lckValuta.EditValue = "IDR" Then
                    isvalid = False
                    err &= "Kurs valuta asing tidak boleh 1." & vbCrLf
                End If
            End If
        Else
            isvalid = True
        End If
    End Sub

    Private Sub aFormJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        loadList()
        prn = getParent(Me)
        lckValuta.EditValue = "IDR"
        txtKurs.EditValue = 1
        txtKurs.Properties.ReadOnly = True
    End Sub

    Public Sub cetak_click()
        MsgBox("Tidak dipakai.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO!")
    End Sub

    Public Sub cancel_click()
        btnAdd = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        clear()
        Me.Enabled = False
        STATE = ""
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Jurnal dengan nomor " & noJur & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
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
            save_click(True)
            STATE = ""
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsJurnal = New DataSet
        daJurnal = New SqlDataAdapter(New SqlCommand("select tgl_trans as 'Tanggal Transaksi', no_jur as 'No. Jurnal', no_ref1 as 'No. Ref', nama as 'Nama', alamat as 'Alamat', keterangan as 'Keterangan', kd_valuta as 'Valuta', kurs_valuta as 'Kurs' from FIN.dbo.FIN_JURNAL", sqlconn)) '<- query buat ditampilkan di LOV
        daJurnal.Fill(dsJurnal, "LookJurnal")
        frmCari.set_dso(dsJurnal.Tables("LookJurnal"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            noJur = frmCari.row("No. Jurnal").ToString
            loadData(noJur)
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                row = dsJurnal.Tables("Jurnal").Rows(0)
                row("tgl_trans") = decTanggal.EditValue
                row("no_ref1") = txtNoRef.EditValue
                row("kd_valuta") = lckValuta.EditValue
                row("kurs_valuta") = txtKurs.EditValue
                row.Item("jml_val_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                row.Item("jml_rp_trans") = IIf(gvJurnal.Columns("saldo_val_debet").SummaryText = vbNullString, kdcabang, gvJurnal.Columns("saldo_val_debet").SummaryText)
                row("nama") = txtKepada.EditValue
                row("alamat") = txtAlamat.EditValue
                row("keterangan") = txtKet.EditValue
                row("Last_Update_Date") = getTanggal()
                row("Last_Updated_By") = umum.username

                If Not gvJurnal.RowCount = 0 Then
                    For Each rw As DataRow In dsJurnal.Tables("JurnalD").Rows
                        If rw.RowState = DataRowState.Modified Then
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
            bldJurnal = New SqlCommandBuilder(daJurnal)
            daJurnal.UpdateCommand = bldJurnal.GetUpdateCommand()
            daJurnal.InsertCommand = bldJurnal.GetInsertCommand()
            daJurnal.DeleteCommand = bldJurnal.GetDeleteCommand()

            If Not gvJurnal.RowCount < 0 Then
                bldJurnalD = New SqlCommandBuilder(daJurnalD)
                daJurnalD.UpdateCommand = bldJurnalD.GetUpdateCommand()
                daJurnalD.InsertCommand = bldJurnalD.GetInsertCommand()
                daJurnalD.DeleteCommand = bldJurnalD.GetDeleteCommand()
            End If

            BTRANS = sqlconn.BeginTransaction("1")
            daJurnal.UpdateCommand.Transaction = BTRANS
            daJurnal.InsertCommand.Transaction = BTRANS
            daJurnal.DeleteCommand.Transaction = BTRANS

            daJurnal.Update(dsJurnal.Tables("Jurnal"))
            dsJurnal.Tables("Jurnal").AcceptChanges()

            If Not gvJurnal.RowCount < 0 Then
                daJurnalD.UpdateCommand.Transaction = BTRANS
                daJurnalD.InsertCommand.Transaction = BTRANS
                daJurnalD.DeleteCommand.Transaction = BTRANS

                daJurnalD.Update(dsJurnal.Tables("JurnalD"))
                dsJurnal.Tables("JurnalD").AcceptChanges()
            End If

            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            isvalid = False
        Catch e As Exception
            BTRANS.Rollback()
            dsJurnal.Tables("Jurnal").RejectChanges()
            If Not gvJurnal.RowCount < 0 Then
                dsJurnal.Tables("JurnalD").RejectChanges()
            End If
            MsgBox(e.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
        End Try
    End Sub

    Private Sub txtKurs_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKurs.EditValueChanged
        Dim deb As String = ""
        Dim kre As String = ""
        If Not txtKurs.EditValue Like 0 Then
            For j As Integer = 0 To gvJurnal.RowCount - 1
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_debet") Is "0" Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    deb = gvJurnal.GetRowCellValue(j, "saldo_val_debet")
                    If Not txtKurs.Text = "" Then
                        gvJurnal.SetRowCellValue(j, "saldo_rp_debet", deb * txtKurs.EditValue)
                    End If
                End If
                If Not gvJurnal.GetRowCellValue(j, "saldo_val_kredit") Is "0" Then
                    'gvJurnal.SetRowCellValue(j, "saldo_rp_debet", 0)
                    kre = gvJurnal.GetRowCellValue(j, "saldo_val_kredit")
                    If Not txtKurs.Text = "" Then
                        gvJurnal.SetRowCellValue(j, "saldo_rp_kredit", kre * txtKurs.EditValue)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub lckValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckValuta.EditValueChanged
        If lckValuta.EditValue = "IDR" Then
            txtKurs.EditValue = 1
            txtKurs.Properties.ReadOnly = True
        Else
            txtKurs.Properties.ReadOnly = False
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
End Class