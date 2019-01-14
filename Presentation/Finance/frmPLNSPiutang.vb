Imports System.Data.SqlClient
Public Class frmPLNSPiutang
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
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

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        'State = "ADD"

        'da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans='JPJ-KPT-08'", sqlconn))
        'da1.Fill(ds1, "Db_data1")
        reload_table("xxx")
        'isiGrid()

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_inv,kd_cust,jml_akhir,kd_buku_besar from fin.dbo.fin_nota where tipe_trans='JPJ-KPT-08'", sqlconn))
        da5.Fill(ds5, "_karyawon")
        lookupPeg.DataSource = ds5.Tables("_karyawon")
        lookupPeg.ValueMember = "no_inv"
        lookupPeg.DisplayMember = "no_inv"

        txtno_inv.Enabled = False
        dttgl_inv.Text = Today.Date
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        bersihkan()
    End Sub

    Public Sub edit_click()
        ds3 = New DataSet
        da3 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where tipe_trans = 'JKM-KPT-02'", sqlconn))
        da3.Fill(ds3, "NOTA_LUNAS")

        frmCari.set_dso(ds3.Tables("NOTA_LUNAS"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            reload_table(frmCari.row(2))
            'da4 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans = '" & frmCari.row("no_trans").ToString & "'", sqlconn))
            'da4.Fill(ds4, "NOTA_LUNAS_D")
            State = "EDIT"
        End If

        btnSave = True
        btnAdd = False
        btnEdit = False
        btnDelete = False
        btnCancel = True
        setStatus()
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(da2)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GV.SelectedRowsCount - 1)
        For i = 0 To GV.SelectedRowsCount - 1
            rows(i) = GV.GetDataRow(GV.GetSelectedRows(i))
        Next
        GV.BeginSort()
        Try
            For Each row In rows
                row.Delete()
                showMessages("dihapus")
            Next
        Finally
            GV.EndSort()
        End Try
        'State = "DELETE"
        'save_click()
    End Sub
    'Public Function getNoTrans(ByVal kdBukti As String, ByVal tgl As Date, Optional ByVal BTRANS As SqlTransaction = Nothing) As String
    '    Dim sqlcmd As New SqlCommand
    '    sqlcmd.Connection = sqlconn
    '    sqlcmd.CommandType = CommandType.StoredProcedure
    '    sqlcmd.CommandText = "SIF.dbo.sifp_get_no_trans"
    '    If Not BTRANS Is Nothing Then
    '        sqlcmd.Transaction = BTRANS
    '    End If
    '    sqlcmd.Parameters.Add("@vkd_bukti", SqlDbType.VarChar, 10)
    '    sqlcmd.Parameters.Add("@vtgl_trans", SqlDbType.Date)
    '    sqlcmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
    '    sqlcmd.Parameters("@vkd_bukti").Value = kdBukti
    '    sqlcmd.Parameters("@vtgl_trans").Value = tgl
    '    sqlcmd.Parameters("@vno_trans").Direction = ParameterDirection.Output
    '    sqlcmd.ExecuteNonQuery()
    '    Return sqlcmd.Parameters("@vno_trans").Value.ToString
    'End Function


    Public Sub bersihkan()
        If Not ds1 Is Nothing Then
            ds1.Clear()
        End If
        If Not ds2 Is Nothing Then
            ds2.Clear()
        End If

        txtno_inv.Text = ""
        dttgl_inv.EditValue = Format(Now, "dd/MM/yyyy")
        txtketerangan.Text = ""

        'reload_table("xxx")
    End Sub

    Public Sub isiGrid()
        bersihkan()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-06'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        GC.DataSource = ds1.Tables("Db_data1")
    End Sub

    Public Sub save_click()
        If State = "ADD" Or State = "EDIT" Then
            If dttgl_inv.EditValue = "" Then
                showMessages("Tanggal Belum Diisi")
                dttgl_inv.Focus()
                Exit Sub
            End If

            If txtketerangan.Text = "" Then
                showMessages("Keterangan Belum Diisi")
                txtketerangan.Focus()
                Exit Sub
            End If

            If ds2.Tables("Db_data2").Rows.Count = 0 Then
                showMessages("Data pelunasan belum Diisi")
                GC.Focus()
                Exit Sub
            End If
        End If

        Dim BTRANS As SqlTransaction
        'Dim tmpNo As String

        'If txtno_inv.Text = "" Then
        '    txtno_inv.Text = getNoTrans("PIUTKAR", dttgl_inv.DateTime)
        'End If

        If State = "ADD" Then
            txtno_inv.Text = getNoTrans("JKM", dttgl_inv.EditValue, BTRANS)
            row = ds1.Tables("Db_data1").NewRow
            row.Item("kd_cabang") = "1"
            row.Item("tipe_trans") = "JKM-KPT-02"
            row.Item("no_trans") = txtno_inv.Text
            row.Item("tgl_trans") = getTanggal()
            row.Item("thnbln") = Format(getTanggal, "yyyyMM")
            row.Item("kd_valuta") = "IDR"
            row.Item("kurs_valuta") = "1"
            row.Item("jml_val_trans") = getTotal()
            row.Item("jml_rp_trans") = getTotal()
            row.Item("jml_tagihan") = 0
            row.Item("jml_bayar") = 0
            row.Item("keterangan") = txtketerangan.Text
            row.Item("Last_create_date") = getTanggal()
            row.Item("Last_created_by") = username
            row.Item("Program_name") = "frmPLNSPiutang"

            ds1.Tables("Db_data1").Rows.Add(row)
        ElseIf State = "EDIT" Then
            row = ds1.Tables("Db_data1").Rows(0)
            row.Item("kd_cabang") = "1"
            row.Item("tipe_trans") = "JKM-KPT-02"
            row.Item("no_trans") = txtno_inv.Text
            row.Item("tgl_trans") = getTanggal()
            row.Item("thnbln") = Format(getTanggal, "yyyyMM")
            row.Item("kd_valuta") = "IDR"
            row.Item("kurs_valuta") = "1"
            row.Item("jml_val_trans") = getTotal()
            row.Item("jml_rp_trans") = getTotal()
            row.Item("jml_tagihan") = 0
            row.Item("jml_bayar") = 0
            row.Item("keterangan") = txtketerangan.Text
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
            row.Item("Program_name") = "frmPLNSPiutang"
        End If

        For Each rows As DataRow In ds2.Tables("Db_data2").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("kd_cabang") = "1"
                rows.Item("tipe_trans") = "JKM-KPT-02"
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
                rows.Item("kd_Cabang") = "1"
                rows.Item("Programe_name") = Me.Name
            Else
                rows.Item("kd_cabang") = "1"
                rows.Item("tipe_trans") = "JKM-KPT-02"
                rows.Item("no_trans") = txtno_inv.Text
                rows.Item("jml_piut") = 0
                rows.Item("jml_ppn") = 0
                rows.Item("jml_pph") = 0
                rows.Item("jml_diskon") = 0
                rows.Item("jml_admin") = 0
                rows.Item("pendp_lain") = 0
                rows.Item("biaya_lain") = 0
                rows.Item("status") = vbNullString
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("kd_Cabang") = "1"
                rows.Item("Programe_name") = Me.Name
            End If
        Next

        Try
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

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
            BTRANS.Commit()

            showMessages("Data Telah Disimpan..!")
            ''isiGrid()
            reload_table("xxx")

            btnSave = False
            btnAdd = True
            btnEdit = True
            btnDelete = False
            btnCancel = False
            setStatus()

        Catch ex As Exception
            BTRANS.Rollback()
            ds1.Tables("Db_data1").RejectChanges()
            ds2.Tables("Db_data2").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then hapus_record()
        ' showMessages("Deleted..")
        'cancel_click()
        'End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
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

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "' and tipe_trans='JKM-KPT-02'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        If ds1.Tables("Db_data1").Rows.Count > 0 Then
            txtno_inv.Text = ds1.Tables("Db_data1").Rows(0).Item("no_trans").ToString
            dttgl_inv.EditValue = ds1.Tables("Db_data1").Rows(0).Item("tgl_trans").ToString
            txtketerangan.Text = ds1.Tables("Db_data1").Rows(0).Item("keterangan").ToString
        End If

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "' and tipe_trans='JKM-KPT-02'", sqlconn))
        da2.Fill(ds2, "Db_data2")
        GC.DataSource = ds2.Tables("Db_data2")

        'AddHandler ds4.Tables("POD").RowDeleted, AddressOf refreshNomer

        'JPP-KUT-02'
        'If ds3.Tables("PO").Rows.Count > 0 Then
        '    Dim row As DataRow

        '    row = ds3.Tables("PO").Rows(0)
        '    txtNomor.Text = row.Item("no_po").ToString
        '    LEValuta.EditValue = row.Item("kd_valuta").ToString
        '    txtkurs.EditValue = row.Item("kurs_valuta").ToString
        '    txtNoRef.Text = row.Item("no_ref").ToString
        '    dtTanggal.Text = row.Item("tgl_po")
        '    txtketerangan.Text = row.Item("keterangan").ToString
        '    lookcust.EditValue = row.Item("kd_supplier").ToString
        '    'txtSubTotal.EditValue = row.Item("jml_val_trans")

        'End If
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is prev_no_inv Then
            Dim rw As DataRow
            rw = ds5.Tables("_karyawon").Select("no_inv = '" & e.Value & "'")(0)

            'GV.SetRowCellValue(e.RowHandle, kd_kartu, rw("kd_cust"))
            'GV.SetRowCellValue(e.RowHandle, jml_tagihan, rw("jml_akhir"))
            'GV.SetRowCellValue(e.RowHandle, kd_buku_besar, rw("kd_buku_besar"))

            GV.GetRow(e.RowHandle).item("kd_kartu") = rw("kd_cust")
            GV.GetRow(e.RowHandle).item("jml_tagihan") = rw("jml_akhir")
            GV.GetRow(e.RowHandle).item("kd_buku_besar") = rw("kd_buku_besar")
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(GV.GetSelectedRows(0)).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        add_click()
        dttgl_inv.Focus()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        cancel_click()
    End Sub

 
End Class