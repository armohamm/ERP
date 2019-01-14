Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormKompensasi
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Public STATE, statex, param, kode, kodeCari, err As String
    Dim BTRANS As SqlTransaction
    Dim rw, row As DataRow
    Dim dsKompensasi, dsEdit As New DataSet
    Dim daEdit, daPusat, daNota, daKompensasi, daNotaL, daNotaLD, daCust, daVal As SqlDataAdapter
    Dim builderM, builderD, builderK As New SqlCommandBuilder
    Dim drNota As SqlDataReader
    Dim nomor As String
    Dim isValid As Boolean

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
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
        reload_table("xxx")
        txtNoTrans.EditValue = nomor
    End Sub

    Public Sub cancel_click()
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub bersih()
        lookValuta.EditValue = "IDR"
        txtNoTrans.EditValue = vbNullString
        txtKurs.EditValue = "1"
        txtKurs.Enabled = False
        txtKet.EditValue = ""
        txtNoRef.EditValue = vbNullString
        deTanggal.EditValue = getTanggal()
        If Not dsKompensasi.Tables("NotaLunasD") Is Nothing Then dsKompensasi.Tables("NotaLunasD").Clear()
        If Not dsKompensasi.Tables("Kompensasi") Is Nothing Then dsKompensasi.Tables("Kompensasi").Clear()
    End Sub

    Private Sub aFormKompensasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        V_Valuta()
        v_kartu()
        v_rek()
        v_pusatbiaya()
        deTanggal.EditValue = getTanggal()
        lookValuta.EditValue = "IDR"
        txtKurs.Enabled = False
        txtKurs.Text = "1"
    End Sub

    Private Sub refreshNomerDetil()
        Dim xp As Integer = 1
        If gvNotaDetil.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvNotaDetil.RowCount - 1
                gvNotaDetil.GetDataRow(j).Item("no_seq") = xp
                xp += 1
            Next
        End If
    End Sub

    Private Sub cek()
        If gvNotaDetil.RowCount <= 0 Then
            isValid = False
            err &= "Belum ada Detil Pelunasan yang diisi." & vbCrLf
            If gvKompensasi.RowCount <= 0 Then
                err &= "Belum ada Data Kompensasi yang diisi." & vbCrLf
            End If
        ElseIf gvKompensasi.RowCount <= 0 Then
            isValid &= False
            err = "Belum ada Data Kompensasi yang diisi." & vbCrLf
            If gvNotaDetil.RowCount <= 0 Then
                err &= "Belum ada Detil Pelunasan yang diisi." & vbCrLf
            End If
        ElseIf Not gvNotaDetil.Columns("jml_piut").SummaryText.Equals(gvKompensasi.Columns("jml_bayar").SummaryText) Then
            isValid = False
            err &= "Total jumlah kompensasi tidak sama dengan total jumlah lunas detil pelunasan." & vbCrLf
        Else
            isValid = True
        End If
    End Sub

    Private Sub refreshNomerKompensasi()
        Dim xp As Integer = 1
        If gvKompensasi.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvKompensasi.RowCount - 1
                gvKompensasi.GetDataRow(j).Item("no_seq") = xp
                xp += 1
            Next
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

    Private Sub v_nota()
        If Not dsKompensasi.Tables("Nota") Is Nothing Then dsKompensasi.Tables("Nota").Clear()
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, b.nama from FIN.dbo.FIN_Nota a, FIN.dbo.v_kartu b where a.kd_cust=b.kode AND a.kd_valuta ='IDR' and a.jml_akhir > 0 and not a.no_inv like '%PKR%' and a.kd_cust = '" & lookKartu.EditValue & "'", sqlconn))
        daNota.Fill(dsKompensasi, "Nota")
        lookUpNota.DataSource = dsKompensasi.Tables("Nota")
        lookUpNota.ValueMember = "no_inv"
        lookUpNota.DisplayMember = "no_inv"
    End Sub

    Private Sub v_kartu()
        If Not dsKompensasi.Tables("Kartu") Is Nothing Then dsKompensasi.Tables("Kartu").Clear()
        daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        daCust.Fill(dsKompensasi, "Kartu")
        lookUpKartu.DataSource = dsKompensasi.Tables("Kartu")
        lookUpKartu.ValueMember = "kode"
        lookUpKartu.DisplayMember = "nama"
        lookKartu.Properties.DataSource = dsKompensasi.Tables("Kartu")
        lookKartu.Properties.ValueMember = "kode"
        lookKartu.Properties.DisplayMember = "nama"
    End Sub

    Private Sub v_rek()
        If Not dsKompensasi.Tables("Rekening") Is Nothing Then dsKompensasi.Tables("Rekening").Clear()
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar WHERE grup_header = 'D'", sqlconn))
        daNota.Fill(dsKompensasi, "Rekening")
        lookupRekening.DataSource = dsKompensasi.Tables("Rekening")
        lookupRekening.ValueMember = "kd_buku_besar"
        lookupRekening.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub v_pusatbiaya()
        If Not dsKompensasi.Tables("PusatBiaya") Is Nothing Then dsKompensasi.Tables("PusatBiaya").Clear()
        daPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_pusat, nm_buku_pusat from SIF.dbo.SIF_buku_pusat WHERE grup_header = 'D'", sqlconn))
        daPusat.Fill(dsKompensasi, "PusatBiaya")
        lookupPusatBiaya.DataSource = dsKompensasi.Tables("PusatBiaya")
        lookupPusatBiaya.ValueMember = "kd_buku_pusat"
        lookupPusatBiaya.DisplayMember = "nm_buku_pusat"
    End Sub

    Sub V_Valuta()
        If Not dsKompensasi.Tables("View_Valuta") Is Nothing Then dsKompensasi.Tables("View_Valuta").Clear()
        daVal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        daVal.Fill(dsKompensasi, "View_Valuta")
        lookValuta.Properties.DataSource = dsKompensasi.Tables("View_Valuta")
        lookValuta.Properties.ValueMember = "Kode_Valuta"
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dsKompensasi.Tables("NotaLunas") Is Nothing Then dsKompensasi.Tables("NotaLunas").Clear()
        If Not dsKompensasi.Tables("NotaLunasD") Is Nothing Then dsKompensasi.Tables("NotaLunasD").Clear()
        If Not dsKompensasi.Tables("Kompensasi") Is Nothing Then dsKompensasi.Tables("Kompensasi").Clear()

        daNotaL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daNotaL.Fill(dsKompensasi, "NotaLunas")

        daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
        daNotaLD.Fill(dsKompensasi, "NotaLunasD")
        gcNotaDetil.DataSource = dsKompensasi.Tables("NotaLunasD")
        gvNotaDetil.BestFitColumns()

        daKompensasi = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_KOMPENSASI where no_trans= '" & kode & "'", sqlconn))
        daKompensasi.Fill(dsKompensasi, "Kompensasi")
        gcKompensasi.DataSource = dsKompensasi.Tables("Kompensasi")
        gvKompensasi.BestFitColumns()

        If dsKompensasi.Tables("NotaLunas").Rows.Count > 0 Then
            txtNoTrans.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("no_trans")
            txtNoRef.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("no_ref1")
            lookValuta.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("kd_valuta")
            txtKurs.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("kurs_valuta")
            deTanggal.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("tgl_trans")
            txtKet.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("keterangan")
            lookKartu.EditValue = dsKompensasi.Tables("NotaLunas").Rows(0).Item("kd_kartu")
        End If
    End Sub

    Private Sub lookValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtKurs.Enabled = False
            txtKurs.Text = "1"
        Else
            txtKurs.Enabled = True
            txtKurs.Focus()
        End If
    End Sub

    Private Sub gvNotaDetil_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvNotaDetil.CellValueChanged
        Dim view As ColumnView = sender

        'If Not dsEdit.Tables("LoadNota") Is Nothing Then dsEdit.Tables("LoadNota").Clear()
        'daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv='" & gvNotaDetil.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
        'daNota.Fill(dsEdit, "LoadNota")

        If e.Column Is prev_no_inv Then
            'param = ""
            'statex = "XXX"
            drNota = New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE no_inv = '" & view.GetRowCellValue(e.RowHandle, "prev_no_inv") & "'", sqlconn).ExecuteReader
            While drNota.Read
                view.SetRowCellValue(e.RowHandle, "jml_tagihan", drNota.Item("jml_akhir"))
                view.SetRowCellValue(e.RowHandle, "kd_kartu", drNota.Item("kd_cust"))
                view.SetRowCellValue(e.RowHandle, bb, drNota.Item("kd_buku_besar"))
            End While
            drNota.Close()
            'param = "OK"
            'statex = ""
        End If

        'If STATE = "EDIT" Then
        '    If statex = "XXX" Then
        '        param = ""
        '    Else
        '        param = "OK"
        '    End If
        'End If

        'If param = "OK" Then
        If e.Column Is jml_piut Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", view.GetFocusedRowCellValue("jml_piut"))
        End If
        'End If
    End Sub

    Private Sub gvNotaDetil_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvNotaDetil.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvNotaDetil.RowCount + 1)
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isValid Then
                If MsgBox("Simpan data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If STATE = "ADD" Then
                        row = dsKompensasi.Tables("NotaLunas").NewRow
                        txtNoTrans.EditValue = getNoTrans("JRR", deTanggal.EditValue)
                        row.Item("no_trans") = txtNoTrans.EditValue
                        row.Item("Kd_cabang") = getKodeCabang()
                        row.Item("tipe_trans") = "JRR-KPT-15"
                        row.Item("tgl_trans") = deTanggal.EditValue
                        row.Item("kd_kartu") = lookKartu.EditValue
                        row.Item("no_ref1") = txtNoRef.EditValue
                        row.Item("thnbln") = Format(deTanggal.EditValue, "yyyyMM")
                        row.Item("kd_valuta") = lookValuta.EditValue
                        row.Item("kurs_valuta") = txtKurs.EditValue
                        row.Item("jml_val_trans") = gvNotaDetil.Columns("jml_piut").SummaryText
                        row.Item("jml_rp_trans") = gvNotaDetil.Columns("jml_piut").SummaryText * txtKurs.Text
                        row.Item("jml_tagihan") = 0
                        row.Item("jml_bayar") = 0
                        row.Item("keterangan") = txtKet.EditValue
                        row.Item("Last_create_date") = deTanggal.EditValue
                        row.Item("Last_created_by") = username
                        row.Item("Program_name") = Me.Name
                        dsKompensasi.Tables("NotaLunas").Rows.Add(row)
                    ElseIf STATE = "EDIT" Then
                        row = dsKompensasi.Tables("NotaLunas").Rows(0)
                        row.Item("no_ref1") = txtNoRef.EditValue
                        row.Item("kd_valuta") = lookValuta.EditValue
                        row.Item("kd_kartu") = lookKartu.EditValue
                        row.Item("kurs_valuta") = txtKurs.EditValue
                        row.Item("jml_val_trans") = gvNotaDetil.Columns("jml_piut").SummaryText
                        row.Item("jml_rp_trans") = gvNotaDetil.Columns("jml_piut").SummaryText * txtKurs.Text
                        row.Item("keterangan") = txtKet.EditValue
                        row.Item("Last_update_date") = deTanggal.EditValue
                        row.Item("Last_updated_by") = username
                        row.Item("Program_name") = Me.Name
                    End If

                    For Each rows As DataRow In dsKompensasi.Tables("NotaLunasD").Rows
                        If rows.RowState = DataRowState.Added Then
                            rows.Item("Kd_Cabang") = getKodeCabang()
                            rows.Item("tipe_trans") = "JRR-KPT-15"
                            rows.Item("no_trans") = txtNoTrans.EditValue
                            rows.Item("Last_create_date") = deTanggal.EditValue
                            rows.Item("Last_created_by") = username
                            rows.Item("Programe_name") = Me.Name
                        ElseIf rows.RowState = DataRowState.Modified Then
                            rows.Item("Last_update_date") = deTanggal.EditValue
                            rows.Item("Last_updated_by") = username
                        End If
                    Next

                    For Each rw As DataRow In dsKompensasi.Tables("Kompensasi").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw.Item("Kd_Cabang") = getKodeCabang()
                            rw.Item("kd_kartu") = lookKartu.EditValue
                            rw.Item("tipe_trans") = "JRR-KPT-15"
                            rw.Item("no_trans") = txtNoTrans.EditValue
                            rw.Item("Last_create_date") = deTanggal.EditValue
                            rw.Item("Last_created_by") = username
                            rw.Item("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw.Item("Last_update_date") = deTanggal.EditValue
                            rw.Item("Last_updated_by") = username
                        End If
                    Next
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data :" & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                Exit Sub
            End If
        End If

        Try
            builderM = New SqlCommandBuilder(daNotaL)
            daNotaL.UpdateCommand = builderM.GetUpdateCommand()
            daNotaL.InsertCommand = builderM.GetInsertCommand()
            daNotaL.DeleteCommand = builderM.GetDeleteCommand()

            builderD = New SqlCommandBuilder(daNotaLD)
            daNotaLD.UpdateCommand = builderD.GetUpdateCommand()
            daNotaLD.InsertCommand = builderD.GetInsertCommand()
            daNotaLD.DeleteCommand = builderD.GetDeleteCommand()

            builderK = New SqlCommandBuilder(daKompensasi)
            daKompensasi.UpdateCommand = builderK.GetUpdateCommand()
            daKompensasi.InsertCommand = builderK.GetInsertCommand()
            daKompensasi.DeleteCommand = builderK.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daNotaL.UpdateCommand.Transaction = BTRANS
            daNotaL.InsertCommand.Transaction = BTRANS
            daNotaL.DeleteCommand.Transaction = BTRANS

            daNotaLD.UpdateCommand.Transaction = BTRANS
            daNotaLD.InsertCommand.Transaction = BTRANS
            daNotaLD.DeleteCommand.Transaction = BTRANS

            daKompensasi.UpdateCommand.Transaction = BTRANS
            daKompensasi.InsertCommand.Transaction = BTRANS
            daKompensasi.DeleteCommand.Transaction = BTRANS

            daNotaL.Update(dsKompensasi.Tables("NotaLunas"))
            daNotaLD.Update(dsKompensasi.Tables("NotaLunasD"))
            daKompensasi.Update(dsKompensasi.Tables("Kompensasi"))

            dsKompensasi.Tables("NotaLunas").AcceptChanges()
            dsKompensasi.Tables("NotaLunasD").AcceptChanges()
            dsKompensasi.Tables("Kompensasi").AcceptChanges()

            call_procedure("JRR-KPT-15", nomor, BTRANS)

            BTRANS.Commit()

            showMessages("Berhasil disimpan..")
            STATE = "EDIT"
            reload_table(nomor)
            lookValuta.EditValue = "IDR"
            txtKurs.Enabled = False
            txtKurs.EditValue = 1
        Catch ex As Exception
            BTRANS.Rollback()
            dsKompensasi.Tables("NotaLunas").RejectChanges()
            dsKompensasi.Tables("NotaLunasD").RejectChanges()
            dsKompensasi.Tables("Kompensasi").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
        End Try
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        If Not dsEdit.Tables("NotaLunasEdit") Is Nothing Then dsEdit.Tables("NotaLunasEdit").Clear()
        daEdit = New SqlDataAdapter(New SqlCommand("select no_trans as 'No. Transaksi', tgl_trans as 'Tanggal Transaksi', jml_rp_trans as 'Jumlah' from FIN.dbo.FIN_NOTA_LUNAS where tipe_trans LIKE 'JRR-KPT-15'", sqlconn)) '<- query buat ditampilkan di LOV
        daEdit.Fill(dsEdit, "NotaLunasEdit")
        frmCari.set_dso(dsEdit.Tables("NotaLunasEdit"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            nomor = frmCari.row("No. Transaksi").ToString
            reload_table(nomor)
            deTanggal.Enabled = False
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

    Public Sub delete_click()
        If MsgBox("Hapus data pelunasan dengan nomor " & txtNoTrans.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            If Not dsKompensasi.Tables("NotaLunas") Is Nothing Then
                For Each rw As DataRow In dsKompensasi.Tables("NotaLunas").Rows
                    rw.Delete()
                Next
            End If
            If Not dsKompensasi.Tables("NotaLunasD") Is Nothing Then
                For Each rw As DataRow In dsKompensasi.Tables("NotaLunasD").Rows
                    rw.Delete()
                Next
            End If
            If Not dsKompensasi.Tables("Kompensasi") Is Nothing Then
                For Each rw As DataRow In dsKompensasi.Tables("Kompensasi").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub gcNotaDetil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcNotaDetil.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvNotaDetil.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus detil pelunasan yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    gvNotaDetil.DeleteSelectedRows()
                    refreshNomerDetil()
                End If
            End If
        End If
    End Sub

    Private Sub gcKompensasi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcKompensasi.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvKompensasi.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus kompensasi yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    gvKompensasi.DeleteSelectedRows()
                    refreshNomerKompensasi()
                End If
            End If
        End If
    End Sub

    Private Sub gvKompensasi_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvKompensasi.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvKompensasi.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("no_trans"), txtNoTrans.EditValue)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_bayar"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_buku_pusat"), "0-000000")
    End Sub

    Private Sub lookUpNota_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookUpNota.QueryPopUp
        v_nota()
    End Sub

    Private Sub deTanggal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTanggal.GotFocus
        'deTanggal.Properties.MinValue = getTanggal()
    End Sub

    Private Sub txtKurs_InvalidValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles txtKurs.InvalidValue
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtKurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKurs.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    
    Private Sub txtKurs_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKurs.Validating
        If txtKurs.Text = "0,00" Or txtKurs.Text = "0.00" Or txtKurs.Text = "" Then
            e.Cancel = True
            errData.SetError(txtKurs, "Kurs tidak boleh kosong atau 0.")
            errData.SetIconAlignment(txtKurs, ErrorIconAlignment.MiddleRight)
        Else
            e.Cancel = False
            errData.ClearErrors()
        End If
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngka.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNominal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub gvKompensasi_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvKompensasi.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvKompensasi_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvKompensasi.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvKompensasi_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvKompensasi.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim column1 As GridColumn = view.Columns("kd_buku_besar")
            Dim column2 As GridColumn = view.Columns("kd_buku_pusat")
            If Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "5" Or Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "6" Or Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "8" Then
                If gvKompensasi.GetFocusedRowCellValue("kd_buku_pusat").ToString = "0-000000" Then
                    e.Valid = False
                    view.SetColumnError(column2, "Untuk rekening ini,mohon pilih pusat biaya yang lain.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvKompensasi_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvKompensasi.ValidatingEditor
        If gvKompensasi.FocusedColumn.FieldName = "kd_buku_pusat" Then
            'If Not gvKompensasi.RowCount <= 0 Then
            Dim bkpusat As String = e.Value
            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
            If Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "5" Or Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "6" Or Microsoft.VisualBasic.Left(gvKompensasi.GetFocusedRowCellValue("kd_buku_besar").ToString, 1) = "8" Then
                If bkpusat = "0-000000" Then
                    e.Valid = False
                    e.ErrorText = "Untuk rekening ini,mohon pilih pusat biaya yang lain."
                End If
            End If
            'End If
        End If
    End Sub
End Class