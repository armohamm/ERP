Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls

Public Class frmPLNSPiutKaryawan
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5, dax As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim row As DataRow
    Dim mb, mb2 As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public State As String
    Public dipilih As String
    Dim table As DataTable
    Dim noInv As String

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

    Private Sub isiLOV()
        If Not ds5.Tables("_karyawon") Is Nothing Then ds5.Tables("_karyawon").Clear()
        If Not ds4.Tables("cari") Is Nothing Then ds4.Tables("cari").Clear()
        If Not ds4.Tables("rek") Is Nothing Then ds4.Tables("rek").Clear()

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_inv,a.kd_cust,a.jml_akhir,a.kd_buku_besar,b.nama from fin.dbo.fin_nota a, FIN.dbo.v_kartu b where a.kd_cust=b.kode and tipe_trans='JKK-KPT-01' and a.jml_akhir > 0 and not (a.no_posting='' OR a.no_posting is null)", sqlconn))
        da5.Fill(ds5, "_karyawon")
        lookupPeg.DataSource = ds5.Tables("_karyawon")
        lookupPeg.ValueMember = "no_inv"
        lookupPeg.DisplayMember = "no_inv"

        dax = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        dax.Fill(ds4, "cari")
        lookupnama.DataSource = ds4.Tables("cari")
        lookupnama.ValueMember = "kode"
        lookupnama.DisplayMember = "nama"

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar where kd_buku_besar like '101%' and grup_header='D'", sqlconn))
        da5.Fill(ds4, "rek")
        lookPelunasan.Properties.DataSource = ds4.Tables("rek")
        lookPelunasan.Properties.ValueMember = "kd_buku_besar"
        lookPelunasan.Properties.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        'isiGrid()
        isiLOV()

        txtno_inv.Enabled = False
        dttgl_inv.EditValue = getTanggal()

        cancel_click()
    End Sub

    Public Sub add_click()
        controlOff(False)
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        setStatus()
        State = "ADD"
        reload_table("xxx")
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("NOTA_LUNAS") Is Nothing Then ds3.Tables("NOTA_LUNAS").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select no_trans as 'No. Pelunasan', tgl_trans as 'Tanggal Pelunasan', kd_valuta as 'Valuta', jml_val_trans as 'Jumlah Valuta', jml_rp_trans as 'Jumlah Rp.', keterangan as 'Keterangan', no_posting from FIN.dbo.FIN_NOTA_LUNAS where tipe_trans = 'JKM-KPT-02' ORDER BY tgl_trans DESC", sqlconn))
        da3.Fill(ds3, "NOTA_LUNAS")

        frmCari.set_dso(ds3.Tables("NOTA_LUNAS"))
        frmCari.GV.Columns("Tanggal Pelunasan").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah Valuta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Jumlah Rp.").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("no_posting").Visible = False
        frmCari.GV.Columns("Tanggal Pelunasan").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Jumlah Valuta").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("Jumlah Rp.").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            If (frmCari.row("no_posting") = vbNullString Or TypeOf frmCari.row("No. Pelunasan") Is DBNull Or frmCari.row("No. Pelunasan") = "" Or frmCari.row("No. Pelunasan") Is Nothing) Then
                State = "EDIT"
                reload_table(frmCari.row("No. Pelunasan"))

                btnSave = True
                btnAdd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                controlOff(False)
                setStatus()
            Else
                MsgBox("Nota sudah diposting. Tidak dapat diubah.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
                reload_table(frmCari.row("No. Pelunasan"))
                btnSave = False
                btnAdd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
                setStatus()
                controlOff(True)
            End If

            'For i As Integer = 0 To GV.RowCount - 1
            '    isiNama(GV.GetRowCellValue(i, "prev_no_inv"), i)
            'Next
        End If
    End Sub

    Sub controlOff(ByVal stat As Boolean)
        txtno_inv.ReadOnly = stat
        dttgl_inv.Properties.ReadOnly = stat
        txtbayar.ReadOnly = stat
        txtketerangan.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    'Private Sub isiNama(ByVal kode As String, ByVal index As Integer)
    '    Dim rw As DataRow
    '    rw = ds5.Tables("_karyawon").Select("no_inv = '" & kode & "'")(0)
    '    Dim View As ColumnView = New DevExpress.XtraGrid.Views.Grid.GridView(GC)
    '    dax = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu where kode = '" & rw("kd_cust") & "'", sqlconn))
    '    dax.Fill(ds4, "cari")
    '    lookupnama.DataSource = ds4.Tables("cari")
    '    lookupnama.ValueMember = "kode"
    '    lookupnama.DisplayMember = "nama"

    '    View.SetRowCellValue(index, View.Columns("kd_kartu"), rw("kd_cust"))

    'End Sub

    Public Sub bersihkan()

        txtno_inv.Text = ""
        'dttgl_inv.EditValue = getTanggal()
        txtketerangan.Text = ""
        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        If Not ds1.Tables("Db_data2") Is Nothing Then ds1.Tables("Db_data2").Clear()
    End Sub

    Public Sub isiGrid()
        If Not ds1.Tables("Db_data") Is Nothing Then ds1.Tables("Db_data").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-06'", sqlconn))
        da1.Fill(ds1, "Db_data")
        GC.DataSource = ds1.Tables("Db_data")
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If State = "ADD" Or State = "EDIT" Then
                If dttgl_inv.EditValue = vbNullString Then
                    MsgBox("Tanggal Belum diisi.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    dttgl_inv.Focus()
                    Exit Sub
                End If

                If ds1.Tables("Db_data2").Rows.Count <= 0 Then
                    MsgBox("Detil pelunasan belum diisi.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    GC.Focus()
                    Exit Sub
                End If
            End If
            If State = "ADD" Then
                txtno_inv.Text = getNoTrans("JKM", dttgl_inv.EditValue)
                noInv = txtno_inv.Text
                row = ds1.Tables("Db_data1").NewRow
                row.Item("kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = "JKM-KPT-02"
                row.Item("no_trans") = txtno_inv.Text
                row.Item("tgl_trans") = dttgl_inv.EditValue
                row.Item("kd_bb_kas") = lookPelunasan.EditValue
                row.Item("thnbln") = Format(dttgl_inv.EditValue, "yyyyMM")
                row.Item("kd_valuta") = "IDR"
                row.Item("kurs_valuta") = "1"
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_tagihan") = 0
                row.Item("jml_bayar") = 0
                row.Item("keterangan") = txtketerangan.Text
                row.Item("Last_create_date") = getTanggal()
                row.Item("Last_created_by") = username
                row.Item("Program_name") = Me.Name

                ds1.Tables("Db_data1").Rows.Add(row)
            ElseIf State = "EDIT" Then
                noInv = txtno_inv.Text
                row = ds1.Tables("Db_data1").Rows(0)
                row.Item("tgl_trans") = dttgl_inv.EditValue
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("keterangan") = txtketerangan.Text
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
                row.Item("Program_name") = Me.Name
            End If

            For Each rows As DataRow In ds1.Tables("Db_data2").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = getKodeCabang()
                    rows.Item("tipe_trans") = "JKM-KPT-02"
                    rows.Item("no_trans") = txtno_inv.Text
                    rows.Item("jml_ppn") = 0
                    rows.Item("jml_pph") = 0
                    rows.Item("jml_diskon") = 0
                    rows.Item("pendp_lain") = 0
                    rows.Item("biaya_lain") = 0
                    rows.Item("status") = vbNullString
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("Programe_name") = Me.Name
                Else
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                End If
            Next
        End If

        Try
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            mb2 = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb2.GetUpdateCommand()
            da2.InsertCommand = mb2.GetInsertCommand()
            da2.DeleteCommand = mb2.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da1.Update(ds1.Tables("Db_data1"))
            da2.Update(ds1.Tables("Db_data2"))

            ds1.Tables("Db_data1").AcceptChanges()
            ds1.Tables("Db_data2").AcceptChanges()

            If State = "ADD" Or State = "EDIT" Then
                call_procedure("JKM-KPT-02", noInv, BTRANS)
            ElseIf State = "DELETE" Then
                call_procedure_del(noInv, BTRANS)
            End If

            BTRANS.Commit()

            If Not State = "DELETE" Then
                showMessages("Data Telah Disimpan..!")
                State = "ADD"
                reload_table("xxx")
                btnSave = True
                btnAdd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
                setStatus()
                bersihkan()
                isiLOV()
            Else
                showMessages("Data Telah Dihapus..!")
                cancel_click()
            End If
        Catch ex As Exception
            BTRANS.Rollback()
            ds1.Tables("Db_data1").RejectChanges()
            ds1.Tables("Db_data2").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            If Not ds1.Tables("Db_data1") Is Nothing Then
                For Each rw As DataRow In ds1.Tables("Db_data1").Rows
                    noInv = rw.Item("no_trans")
                    rw.Delete()
                Next
            End If
            If Not ds1.Tables("Db_data2") Is Nothing Then
                For Each rwx As DataRow In ds1.Tables("Db_data2").Rows
                    rwx.Delete()
                Next
            End If
            State = "DELETE"
            save_click(True)
        End If
    End Sub

    Public Sub cancel_click()
        bersihkan()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        controlOff(True)
    End Sub

    'Function getTotal() As Double
    '    Dim ttl As Double
    '    For Each rw As DataRow In ds2.Tables("Db_data2").Rows
    '        If TypeOf rw.Item("jml_bayar") Is DBNull Or rw.Item("jml_bayar") = 0 Then
    '            MsgBox("Nota/Invoice Masih Kosong, Harap diisi", MsgBoxStyle.Information)
    '            rw.Item("jml_bayar") = 0
    '            Exit Function
    '        Else
    '            ttl += rw.Item("jml_bayar")
    '        End If
    '    Next
    '    Return ttl
    'End Function

    Private Sub reload_table(ByVal kode As String)
        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        If Not ds1.Tables("Db_data2") Is Nothing Then ds1.Tables("Db_data2").Clear()

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "' and tipe_trans='JKM-KPT-02'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        If ds1.Tables("Db_data1").Rows.Count > 0 Then
            txtno_inv.Text = ds1.Tables("Db_data1").Rows(0).Item("no_trans").ToString
            dttgl_inv.EditValue = ds1.Tables("Db_data1").Rows(0).Item("tgl_trans")
            txtketerangan.Text = ds1.Tables("Db_data1").Rows(0).Item("keterangan").ToString
            lookPelunasan.EditValue = ds1.Tables("Db_data1").Rows(0).Item("kd_bb_kas").ToString
        Else
            txtno_inv.Text = vbNullString
            dttgl_inv.EditValue = getTanggal()
            txtketerangan.Text = vbNullString
            lookPelunasan.Text = vbNullString
        End If

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "' and tipe_trans='JKM-KPT-02'", sqlconn))
        da2.Fill(ds1, "Db_data2")
        GC.DataSource = ds1.Tables("Db_data2")
    End Sub

    Private Sub refreshNomer()
        Dim j As Integer = 1
        If Not GV.RowCount <= 0 Then
            For i As Integer = 0 To GV.RowCount - 1
                GV.SetRowCellValue(i, "no_seq", j)
                j += 1
            Next
        End If
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is prev_no_inv Then

            dr = New SqlCommand("select kd_cust, jml_akhir, kd_buku_besar from fin.dbo.fin_nota where no_inv = '" & GV.GetFocusedRowCellValue("prev_no_inv").ToString & "'", sqlconn).ExecuteReader
            While dr.Read
                GV.SetFocusedRowCellValue("kd_kartu", dr.Item("kd_cust"))
                GV.SetFocusedRowCellValue("jml_tagihan", dr.Item("jml_akhir"))
                GV.SetFocusedRowCellValue("kd_buku_besar", dr.Item("kd_buku_besar"))
            End While
            dr.Close()
        End If

        If e.Column Is jml_bayar Then
            GV.SetFocusedRowCellValue("jml_piut", e.Value)
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(GV.GetSelectedRows(0)).item("no_seq") = GV.RowCount + 1
        GV.SetFocusedRowCellValue("no_seq", GV.RowCount + 1)
        GV.SetFocusedRowCellValue("jml_bayar", 0)
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
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

    Private Sub GV_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "jml_bayar" Then
            Dim jmlbyr As Double = Convert.ToDouble(e.Value)
            If jmlbyr > vx.GetFocusedRowCellValue("jml_tagihan") Then
                e.Valid = False
                e.ErrorText = "Jumlah bayar tidak boleh lebih dari sisa piutang."
            End If
        End If
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                GV.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
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

    Private Sub lookupPeg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookupPeg.QueryPopUp
        isiLOV()
    End Sub
End Class