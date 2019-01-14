Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls

Public Class aFormPLNSPiutLain
    Dim dsLookUp, dsLunas As New DataSet
    Dim daKary, daKartu, daLunas, daLunasD, daCari As New SqlDataAdapter
    Dim bldM, bldD As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public STATE, noInv, noJur As String
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub lookKary()
        If Not dsLookUp.Tables("karyawan") Is Nothing Then dsLookUp.Tables("karyawan").Clear()
        daKary = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_inv, b.nama, a.kd_cust, a.jml_akhir, a.kd_buku_besar from FIN.dbo.FIN_NOTA a, FIN.dbo.v_kartu b where a.kd_cust=b.kode AND a.tipe_trans='JKK-KPT-02' and not (a.no_posting is null or a.no_posting='') and a.jml_akhir > 0", sqlconn))
        daKary.Fill(dsLookUp, "karyawan")
        lookupPeg.DataSource = dsLookUp.Tables("karyawan")
        lookupPeg.ValueMember = "no_inv"
        lookupPeg.DisplayMember = "no_inv"

        daKartu = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsLookUp, "kartu")
        lookupnama.DataSource = dsLookUp.Tables("kartu")
        lookupnama.ValueMember = "kode"
        lookupnama.DisplayMember = "nama"
    End Sub

    Private Sub aFormPLNSPiutLain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = False
        lookKary()
        reload_table("")
        dtpTanggal.EditValue = getTanggal()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        setStatus()
        reload_table("")
        STATE = "ADD"
    End Sub

    Public Sub clear()
        If Not dsLunas.Tables("lunas") Is Nothing Then dsLunas.Tables("lunas").Clear()
        If Not dsLunas.Tables("lunasD") Is Nothing Then dsLunas.Tables("lunasD").Clear()

        txtNomor.Text = ""
        dtpTanggal.EditValue = getTanggal()
        txtKet.Text = ""
    End Sub

    Public Sub cancel_click()
        STATE = ""
        btnSave = False
        btnAdd = True
        btnEdit = True
        btnDelete = False
        btnCancel = False
        setStatus()
        Me.Enabled = False
        clear()
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dsLunas.Tables("lunas") Is Nothing Then dsLunas.Tables("lunas").Clear()
        If Not dsLunas.Tables("lunasD") Is Nothing Then dsLunas.Tables("lunasD").Clear()

        daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "' and tipe_trans='JKM-KPT-03'", sqlconn))
        daLunas.Fill(dsLunas, "lunas")
        daLunasD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "' and tipe_trans='JKM-KPT-03'", sqlconn))
        daLunasD.Fill(dsLunas, "lunasD")
        gcLunas.DataSource = dsLunas.Tables("lunasD")
    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub call_procedure_del(ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_DELJUR_GIRO"

        sqlCmd.Parameters.Add("@nogiro", SqlDbType.Char).Value = noInvoice
        sqlCmd.Parameters.Add("@tipe", SqlDbType.Char).Value = "X"
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub edit_click()
        daCari = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where tipe_trans = 'JKM-KPT-03' and (no_posting is null or no_posting = '')", sqlconn))
        daCari.Fill(dsLookUp, "lunas")

        frmCari.set_dso(dsLookUp.Tables("lunas"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            STATE = "EDIT"
            reload_table(frmCari.row("no_trans").ToString)
            txtNomor.EditValue = dsLunas.Tables("lunas").Rows(0).Item("no_trans")
            noInv = txtNomor.EditValue
            dtpTanggal.EditValue = dsLunas.Tables("lunas").Rows(0).Item("tgl_trans")
            txtKet.EditValue = dsLunas.Tables("lunas").Rows(0).Item("keterangan")
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            If STATE = "ADD" Then
                ' ########################## CEK ########################## 
                If dtpTanggal.EditValue = vbNullString Then
                    MsgBox("Tanggal belum diisi.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    dtpTanggal.Focus()
                    Exit Sub
                End If

                If dtpTanggal.EditValue >= getTanggal() Then
                    MsgBox("Tanggal lebih besar dari tanggal hari ini.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    dtpTanggal.Focus()
                    Exit Sub
                End If

                If gvLunas.RowCount <= 0 Then
                    MsgBox("Tidak ada nota yang dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    Exit Sub
                End If
                ' ########################## cek ########################## 

                Dim row As DataRow
                txtNomor.EditValue = getNoTrans("JKM", dtpTanggal.EditValue)
                noInv = txtNomor.EditValue
                row = dsLunas.Tables("lunas").NewRow
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = "JKM-KPT-03"
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("tgl_trans") = dtpTanggal.EditValue
                row.Item("thnbln") = Format(dtpTanggal.EditValue, "yyyyMM")
                row.Item("kd_valuta") = "IDR"
                row.Item("kurs_valuta") = "1"
                row.Item("jml_val_trans") = gvLunas.Columns("jml_bayar").SummaryText
                row.Item("jml_rp_trans") = gvLunas.Columns("jml_bayar").SummaryText
                row.Item("jml_tagihan") = 0
                row.Item("jml_bayar") = 0
                row.Item("keterangan") = txtKet.EditValue
                row.Item("Last_create_date") = getTanggal()
                row.Item("Last_created_by") = username
                row.Item("Program_name") = Me.Name
                dsLunas.Tables("lunas").Rows.Add(row)
            ElseIf STATE = "EDIT" Then
                Dim row As DataRow
                row = dsLunas.Tables("lunas").Rows(0)
                row.Item("tgl_trans") = dtpTanggal.EditValue
                row.Item("thnbln") = Format(dtpTanggal.EditValue, "yyyyMM")
                row.Item("jml_val_trans") = gvLunas.Columns("jml_bayar").SummaryText
                row.Item("jml_rp_trans") = gvLunas.Columns("jml_bayar").SummaryText
                row.Item("keterangan") = txtKet.EditValue
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
                row.Item("Program_name") = Me.Name
            End If

            For Each rows As DataRow In dsLunas.Tables("lunasD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = getKodeCabang()
                    rows.Item("tipe_trans") = "JKM-KPT-03"
                    rows.Item("no_trans") = txtNomor.EditValue
                    rows.Item("jml_piut") = 0
                    rows.Item("jml_ppn") = 0
                    rows.Item("jml_pph") = 0
                    rows.Item("jml_diskon") = 0
                    rows.Item("jml_admin") = 0
                    rows.Item("pendp_lain") = 0
                    rows.Item("biaya_lain") = 0
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                End If
            Next
        End If

        Try
            bldM = New SqlCommandBuilder(daLunas)
            daLunas.UpdateCommand = bldM.GetUpdateCommand()
            daLunas.InsertCommand = bldM.GetInsertCommand()
            daLunas.DeleteCommand = bldM.GetDeleteCommand()

            bldD = New SqlCommandBuilder(daLunasD)
            daLunasD.UpdateCommand = bldD.GetUpdateCommand()
            daLunasD.InsertCommand = bldD.GetInsertCommand()
            daLunasD.DeleteCommand = bldD.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daLunas.UpdateCommand.Transaction = BTRANS
            daLunas.InsertCommand.Transaction = BTRANS
            daLunas.DeleteCommand.Transaction = BTRANS

            daLunasD.UpdateCommand.Transaction = BTRANS
            daLunasD.InsertCommand.Transaction = BTRANS
            daLunasD.DeleteCommand.Transaction = BTRANS

            daLunas.Update(dsLunas.Tables("lunas"))
            daLunasD.Update(dsLunas.Tables("lunasD"))

            If STATE = "ADD" Then
                call_procedure("JKM-KPT-03", noInv, BTRANS)
            ElseIf STATE = "DELETE" Then
                call_procedure_del(noJur, BTRANS)
            End If

            BTRANS.Commit()

            showMessages("Data Telah Disimpan..!")
            If STATE = "ADD" Then
                STATE = "EDIT"
                reload_table(noInv)
            ElseIf STATE = "DELETE" Then
                cancel_click()
                Exit Sub
            End If
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            noInv = ""
        Catch ex As Exception
            BTRANS.Rollback()
            dsLunas.Tables("lunas").RejectChanges()
            dsLunas.Tables("lunasD").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            If Not dsLunas.Tables("lunas") Is Nothing Then
                For Each rw As DataRow In dsLunas.Tables("lunas").Rows
                    noJur = rw.Item("no_trans")
                    rw.Delete()
                Next
            End If
            If Not dsLunas.Tables("lunasD") Is Nothing Then
                For Each rwx As DataRow In dsLunas.Tables("lunasD").Rows
                    rwx.Delete()
                Next
            End If
            STATE = "DELETE"
            save_click(True)
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If STATE = "ADD" Then
            If gvLunas.RowCount = 0 Then
                Exit Sub
            Else
                For j As Integer = 0 To gvLunas.RowCount - 1
                    gvLunas.GetDataRow(j).Item("no_seq") = i
                    i += 1
                Next
            End If
        Else
            If gvLunas.RowCount = 0 Then
                Exit Sub
            Else
                For Each rw As DataRow In dsLunas.Tables("lunasD").Rows
                    If rw.RowState <> DataRowState.Deleted Then
                        rw("no_seq") = i
                        i += 1
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub gvLunas_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvLunas.CellValueChanged
        If e.Column Is prev_no_inv Then
            Dim rw As DataRow
            rw = dsLookUp.Tables("karyawan").Select("no_inv = '" & e.Value & "'")(0)
            gvLunas.SetRowCellValue(e.RowHandle, "kd_kartu", rw("kd_cust"))
            gvLunas.SetRowCellValue(e.RowHandle, "jml_tagihan", rw("jml_akhir"))
            gvLunas.SetRowCellValue(e.RowHandle, "kd_buku_besar", rw("kd_buku_besar"))
            gvLunas.SetRowCellValue(e.RowHandle, "jml_bayar", "0")
        End If
    End Sub

    Private Sub gvLunas_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvLunas.InitNewRow
        gvLunas.GetRow(gvLunas.GetSelectedRows(0)).item("no_seq") = gvLunas.RowCount + 1
    End Sub

    Private Sub gvLunas_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvLunas.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvLunas_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvLunas.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "jml_bayar" Then
            Dim jmlbyr As Double = Convert.ToDouble(e.Value)
            If jmlbyr > vx.GetFocusedRowCellValue("jml_tagihan") Then
                e.Valid = False
                e.ErrorText = "Jumlah bayar tidak boleh lebih dari sisa piutang."
            End If
        End If

        If vx.FocusedColumn.FieldName = "prev_no_inv" Then
            Dim nota As String = e.Value
            For i As Integer = 0 To gvLunas.RowCount
                'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                If nota = vx.GetRowCellValue(i, prev_no_inv) Then
                    e.Valid = False
                    e.ErrorText = "Nota sudah ada, mohon pilih nota yang lain."
                End If
            Next
        End If
    End Sub

    Private Sub gcLunas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcLunas.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvLunas.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus detil nota yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    gvLunas.DeleteSelectedRows()
                    refreshNomer()
                End If
            End If
        End If
    End Sub

    Private Sub dtpTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTanggal.EditValueChanged
        If dtpTanggal.EditValue = vbNullString Then
            dtpTanggal.EditValue = getTanggal()
        End If
    End Sub

    Private Sub txtBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBayar.KeyPress
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
End Class