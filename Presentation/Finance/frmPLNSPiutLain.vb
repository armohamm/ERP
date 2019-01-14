Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls

Public Class frmPLNSPiutLain
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5, dax As New SqlDataAdapter
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
        ds5.Clear()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_inv, b.nama, a.kd_cust, a.jml_akhir, a.kd_buku_besar from FIN.dbo.FIN_NOTA a, FIN.dbo.v_kartu b where a.kd_cust=b.kode AND a.tipe_trans='JKK-KPT-02' and not (a.no_posting is null or a.no_posting='') and a.jml_akhir > 0", sqlconn))
        da5.Fill(ds5, "_karyawon")
        lookupPeg.DataSource = ds5.Tables("_karyawon")
        lookupPeg.ValueMember = "no_inv"
        lookupPeg.DisplayMember = "no_inv"
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        reload_table("xxx")
        'isiGrid()
        isiLOV()

        txtno_inv.Enabled = False
        dttgl_inv.EditValue = getTanggal()

        cancel_click()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        bersihkan()
    End Sub

    Public Sub edit_click()
        ds3 = New DataSet
        da3 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where tipe_trans = 'JKM-KPT-03'", sqlconn))
        da3.Fill(ds3, "NOTA_LUNAS")

        frmCari.set_dso(ds3.Tables("NOTA_LUNAS"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            reload_table(frmCari.row(2))
            State = "EDIT"

            For i As Integer = 0 To GV.RowCount - 1
                isiNama(GV.GetRowCellValue(i, "prev_no_inv"), i)
            Next
        End If

        btnSave = True
        btnAdd = False
        btnEdit = False
        btnDelete = True
        btnCancel = True
        setStatus()
    End Sub

    Public Sub bersihkan()
        If Not ds1 Is Nothing Then
            ds1.Clear()
        End If
        If Not ds2 Is Nothing Then
            ds2.Clear()
        End If

        txtno_inv.Text = ""
        dttgl_inv.EditValue = getTanggal()
        txtketerangan.Text = ""

        'reload_table("xxx")
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If State = "ADD" Or State = "EDIT" Then
            If dttgl_inv.EditValue = vbNullString Then
                showMessages("Tanggal Belum Diisi")
                dttgl_inv.Focus()
                Exit Sub
            End If

            If ds2.Tables("Db_data2").Rows.Count = 0 Then
                showMessages("Data pelunasan belum Diisi")
                GC.Focus()
                Exit Sub
            End If
        End If

        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If State = "ADD" Then
                txtno_inv.Text = getNoTrans("JKM", dttgl_inv.EditValue)
                noInv = txtno_inv.Text
                row = ds1.Tables("Db_data1").NewRow
                row.Item("kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = "JKM-KPT-03"
                row.Item("no_trans") = txtno_inv.Text
                row.Item("tgl_trans") = dttgl_inv.EditValue
                row.Item("thnbln") = Format(dttgl_inv.EditValue, "yyyyMM")
                row.Item("kd_valuta") = "IDR"
                row.Item("kurs_valuta") = "1"
                row.Item("jml_val_trans") = getTotal()
                row.Item("jml_rp_trans") = getTotal()
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
                row.Item("no_trans") = txtno_inv.Text
                row.Item("tgl_trans") = dttgl_inv.EditValue
                row.Item("thnbln") = Format(dttgl_inv.EditValue, "yyyyMM")
                row.Item("jml_val_trans") = getTotal()
                row.Item("jml_rp_trans") = getTotal()
                row.Item("keterangan") = txtketerangan.Text
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
                row.Item("Program_name") = Me.Name
            End If

            For Each rows As DataRow In ds2.Tables("Db_data2").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = getKodeCabang()
                    rows.Item("tipe_trans") = "JKM-KPT-03"
                    rows.Item("no_trans") = txtno_inv.Text
                    rows.Item("jml_piut") = 0
                    rows.Item("jml_ppn") = 0
                    rows.Item("jml_pph") = 0
                    rows.Item("jml_diskon") = 0
                    rows.Item("jml_admin") = 0
                    rows.Item("pendp_lain") = 0
                    rows.Item("biaya_lain") = 0
                    rows.Item("status") = vbNullString
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState = DataRowState.Modified Then
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
            da2.Update(ds2.Tables("Db_data2"))

            ds1.Tables("Db_data1").AcceptChanges()
            ds2.Tables("Db_data2").AcceptChanges()

            If State = "ADD" Then
                call_procedure("JKM-KPT-03", noInv, BTRANS)
            ElseIf State = "EDIT" Then
                call_procedure_edit(noInv, BTRANS)
            End If

            BTRANS.Commit()

            showMessages("Data Telah Disimpan..!")
            If Not State = "DELETE" Then
                State = "EDIT"
                reload_table(noInv)
                btnSave = True
                btnAdd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                setStatus()
                isiLOV()
            Else
                cancel_click()
            End If
        Catch ex As Exception
            BTRANS.Rollback()
            ds1.Tables("Db_data1").RejectChanges()
            ds2.Tables("Db_data2").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            If Not ds1.Tables("Db_data1") Is Nothing Then
                For Each rw As DataRow In ds1.Tables("Db_data1").Rows
                    rw.Delete()
                Next
            End If
            If Not ds2.Tables("Db_data2") Is Nothing Then
                For Each rwx As DataRow In ds2.Tables("Db_data2").Rows
                    rwx.Delete()
                Next
            End If
            save_click(True)
            State = "DELETE"
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
    End Sub

    Function getTotal() As Double
        Dim ttl As Double
        For Each rw As DataRow In ds2.Tables("Db_data2").Rows
            If TypeOf rw.Item("jml_bayar") Is DBNull Or rw.Item("jml_bayar") = 0 Then
                MsgBox("Nota/Invoice Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("jml_bayar") = 0
                Exit Function
            Else
                ttl += rw.Item("jml_bayar")
            End If
        Next
        Return ttl
    End Function

    Private Sub reload_table(ByVal kode As String)
        bersihkan()
        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        If Not ds2.Tables("Db_data2") Is Nothing Then ds2.Tables("Db_data2").Clear()

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "' and tipe_trans='JKM-KPT-03'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        If ds1.Tables("Db_data1").Rows.Count > 0 Then
            txtno_inv.Text = ds1.Tables("Db_data1").Rows(0).Item("no_trans")
            dttgl_inv.EditValue = ds1.Tables("Db_data1").Rows(0).Item("tgl_trans")
            txtketerangan.Text = ds1.Tables("Db_data1").Rows(0).Item("keterangan")
        End If

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "' and tipe_trans='JKM-KPT-03'", sqlconn))
        da2.Fill(ds2, "Db_data2")
        GC.DataSource = ds2.Tables("Db_data2")
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is prev_no_inv Then
            Dim rw As DataRow
            Dim View As ColumnView = sender
            rw = ds5.Tables("_karyawon").Select("no_inv = '" & e.Value & "'")(0)

            '######################################## By Kentang ########################################
            dax = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu where kode = '" & rw("kd_cust") & "'", sqlconn))
            dax.Fill(ds4, "cari")
            lookupnama.DataSource = ds4.Tables("cari")
            lookupnama.ValueMember = "kode"
            lookupnama.DisplayMember = "nama"

            View.SetRowCellValue(e.RowHandle, View.Columns("kd_kartu"), rw("kd_cust"))
            '######################################## By Kentang ########################################

            'GV.GetRow(e.RowHandle).item("kd_kartu") = rw("kd_cust")
            GV.GetRow(e.RowHandle).item("jml_tagihan") = rw("jml_akhir")
            GV.GetRow(e.RowHandle).item("kd_buku_besar") = rw("kd_buku_besar")
            GV.GetRow(e.RowHandle).item("jml_bayar") = "0"
        End If
    End Sub

    Private Sub isiNama(ByVal kode As String, ByVal index As Integer)
        '######################################## By Kentang ########################################
        Dim rw As DataRow
        rw = ds5.Tables("_karyawon").Select("no_inv = '" & kode & "'")(0)
        Dim View As ColumnView = New DevExpress.XtraGrid.Views.Grid.GridView(GC)
        dax = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu where kode = '" & rw("kd_cust") & "'", sqlconn))
        dax.Fill(ds4, "cari")
        lookupnama.DataSource = ds4.Tables("cari")
        lookupnama.ValueMember = "kode"
        lookupnama.DisplayMember = "nama"

        View.SetRowCellValue(index, View.Columns("kd_kartu"), rw("kd_cust"))
        '######################################## By Kentang ########################################

    End Sub

    Private Sub GV_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV.CustomColumnDisplayText
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "no_seq" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
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

    Public Sub call_procedure_edit(ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_LUNAS_PIUTNON_USH"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noInvoice
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
                If MsgBox("Hapus detil nota yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
End Class