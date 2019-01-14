Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormManualNotaJual
    Public btnadd As Boolean = True
    Public btnEdit As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnSave As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim dsNota, dsCari As New DataSet
    Dim daNota, daNotaD, daCari As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim err As String
    Dim ppn As Integer

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
        loadList()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = False
        Me.Enabled = True
        setStatus()
        clear()
        loadData("xxx")
        controlOff(False)
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        'txtNoInv.Properties.ReadOnly = stat
        dteTanggal.Properties.ReadOnly = stat
        txtNoSJ.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        lookCustomer.Properties.ReadOnly = stat
        lookSales.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvNota.OptionsBehavior.ReadOnly = stat
        chkPPN.Properties.ReadOnly = stat
        lookValuta.Properties.ReadOnly = stat
    End Sub

    Private Sub clear()
        txtNoInv.EditValue = vbNullString
        dteTanggal.EditValue = getTanggal()
        txtNoSJ.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        lookCustomer.ItemIndex = 0
        lookSales.ItemIndex = 0
        txtKet.EditValue = vbNullString
        chkPPN.EditValue = "T"
        txtPPN.EditValue = 0
        txtJumlah.EditValue = 0
        lookValuta.EditValue = "IDR"
        'txtValuta.EditValue = 1
        txtTotal.EditValue = 0
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()
        If Not dsNota.Tables("NotaD") Is Nothing Then dsNota.Tables("NotaD").Clear()
        daNota = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daNota.Fill(dsNota, "Nota")
        daNotaD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_D where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daNotaD.Fill(dsNota, "NotaD")
        gcNota.DataSource = dsNota.Tables("NotaD")
        gvNota.BestFitColumns()

        If dsNota.Tables("Nota").Rows.Count > 0 Then
            txtNoInv.EditValue = dsNota.Tables("Nota").Rows(0)("no_inv")
            dteTanggal.EditValue = dsNota.Tables("Nota").Rows(0)("tgl_inv")
            txtNoSJ.EditValue = dsNota.Tables("Nota").Rows(0)("no_sj")
            txtNoRef.EditValue = dsNota.Tables("Nota").Rows(0)("no_ref1")
            lookCustomer.EditValue = dsNota.Tables("Nota").Rows(0)("kd_cust")
            lookSales.EditValue = dsNota.Tables("Nota").Rows(0)("kd_sales")
            txtKet.EditValue = dsNota.Tables("Nota").Rows(0)("keterangan")
            chkPPN.EditValue = dsNota.Tables("Nota").Rows(0)("flag_ppn")
            txtJumlah.EditValue = dsNota.Tables("Nota").Rows(0)("jml_val_trans") - dsNota.Tables("Nota").Rows(0)("jml_val_ppn")
            txtPPN.EditValue = dsNota.Tables("Nota").Rows(0)("jml_val_ppn")
            txtTotal.EditValue = dsNota.Tables("Nota").Rows(0)("jml_tagihan")
            lookValuta.EditValue = dsNota.Tables("Nota").Rows(0)("kd_valuta")
            txtValuta.EditValue = dsNota.Tables("Nota").Rows(0)("kurs_valuta")
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                If STATE = "ADD" Then
                    txtNoInv.EditValue = IIf(chkPPN.Checked = True, getNoTrans("INVJUALP", dteTanggal.EditValue, BTRANS), getNoTrans("INVJUALNP", dteTanggal.EditValue, BTRANS))
                    row = dsNota.Tables("Nota").NewRow
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JPJ-KPT-14"
                    row.Item("no_inv") = txtNoInv.EditValue
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                ElseIf STATE = "EDIT" Then
                    row = dsNota.Tables("Nota").Rows(0)
                    row("Last_update_date") = getTanggal()
                    row("Last_updated_by") = umum.username
                End If

                row.Item("tgl_inv") = dteTanggal.EditValue
                row.Item("no_sj") = txtNoSJ.EditValue
                row.Item("kd_valuta") = lookValuta.EditValue
                row.Item("kurs_valuta") = txtValuta.EditValue
                row.Item("no_ref1") = txtNoRef.EditValue
                row.Item("kd_cust") = lookCustomer.EditValue
                row.Item("kd_sales") = lookSales.EditValue
                row.Item("keterangan") = txtKet.EditValue
                row.Item("flag_ppn") = chkPPN.EditValue
                row.Item("jml_val_trans") = txtTotal.EditValue
                row.Item("jml_rp_trans") = txtTotal.EditValue * txtValuta.EditValue
                row.Item("jml_val_ppn") = txtPPN.EditValue
                row.Item("jml_rp_ppn") = txtPPN.EditValue * txtValuta.EditValue
                row.Item("jml_tagihan") = txtTotal.EditValue

                If STATE = "ADD" Then
                    dsNota.Tables("Nota").Rows.Add(row)
                End If

                For Each rw As DataRow In dsNota.Tables("NotaD").Rows
                    If rw.RowState = DataRowState.Added Then
                        rw("Kd_Cabang") = getKodeCabang()
                        rw("tipe_trans") = "JPJ-KPT-14"
                        rw("no_inv") = txtNoInv.EditValue
                        rw("no_sj") = txtNoSJ.EditValue
                        rw("no_sp") = txtNoInv.EditValue
                        rw("Last_create_date") = getTanggal()
                        rw("Last_created_by") = username
                        rw("Programe_name") = Me.Name
                    ElseIf rw.RowState = DataRowState.Modified Then
                        rw("Last_update_date") = getTanggal()
                        rw("Last_updated_by") = username
                    End If
                Next
            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
                Exit Sub
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daNota)
            daNota.UpdateCommand = myBuilder.GetUpdateCommand()
            daNota.InsertCommand = myBuilder.GetInsertCommand()
            daNota.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlCommandBuilder(daNotaD)
            daNotaD.UpdateCommand = myBuilder.GetUpdateCommand()
            daNotaD.InsertCommand = myBuilder.GetInsertCommand()
            daNotaD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daNota.UpdateCommand.Transaction = BTRANS
            daNota.InsertCommand.Transaction = BTRANS
            daNota.DeleteCommand.Transaction = BTRANS

            daNotaD.UpdateCommand.Transaction = BTRANS
            daNotaD.InsertCommand.Transaction = BTRANS
            daNotaD.DeleteCommand.Transaction = BTRANS

            daNota.Update(dsNota.Tables("Nota"))
            daNotaD.Update(dsNota.Tables("NotaD"))

            dsNota.Tables("Nota").AcceptChanges()
            dsNota.Tables("NotaD").AcceptChanges()

            'If STATE = "ADD" Then
            '    call_procedure("JPJ-KPT-14", txtNoInv.EditValue, BTRANS)
            'End If

            BTRANS.Commit()
            If Not isDelete Then
                showMessages("Berhasil disimpan.")
                cetak_click()
                If STATE = "EDIT" Then
                    btnDelete = False
                    setStatus()
                End If
                clear()
                loadData("XXX")
            Else
                showMessages("Berhasil dihapus.")
                cancel_click()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsNota.Tables("Nota").RejectChanges()
            dsNota.Tables("NotaD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub cetak_click()
        If Not txtNoInv.EditValue = "" Then
            If MsgBox("Cetak langsung?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CETAK?") = MsgBoxResult.Yes Then
                callReport(App_Path() & "\report\repNotaJualSpringLangsung.rpt", "", "nomor=" & txtNoInv.EditValue, True)
            Else
                callReport(App_Path() & "\report\repNotaJualSpringLangsung.rpt", "", "nomor=" & txtNoInv.EditValue, False)
            End If
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

    Public Sub cancel_click()
        STATE = ""
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnDelete = False
        btnSave = False
        setStatus()
        Me.Enabled = False
        clear()
        loadData("XXX")
    End Sub

    Private Sub cek()
        isvalid = True
        If Not lookValuta.EditValue = "IDR" Then
            If txtValuta.EditValue = 1 Then
                isvalid = False
                DxErrorProvider1.SetError(txtValuta, "Valuta selain Rupiah harus lebih dari 0.")
            Else
                DxErrorProvider1.SetError(txtValuta, "")
            End If
        End If
        If txtNoSJ.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(txtNoSJ, "No. Sj harus diisi.")
        Else
            DxErrorProvider1.SetError(txtNoSJ, "")
        End If
        If gvNota.RowCount = 0 Then
            If STATE = "ADD" Then
                isvalid = False
                err &= "Detil belum diisi." & vbCrLf
            End If
        End If
    End Sub

    Private Sub loadList()
        If Not dsCari.Tables("Barang") Is Nothing Then dsCari.Tables("Barang").Clear()
        If Not dsCari.Tables("Satuan") Is Nothing Then dsCari.Tables("Satuan").Clear()
        If Not dsCari.Tables("Customer") Is Nothing Then dsCari.Tables("Customer").Clear()
        If Not dsCari.Tables("Sales") Is Nothing Then dsCari.Tables("Sales").Clear()
        If Not dsCari.Tables("Valuta") Is Nothing Then dsCari.Tables("Valuta").Clear()

        daCari = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, Kd_Satuan from SIF.dbo.SIF_Barang where kd_jns_persd in (1,2,3)", sqlconn))
        daCari.Fill(dsCari, "Barang")
        lookBrg.DataSource = dsCari.Tables("Barang")
        lookBrg.DisplayMember = "Nama_Barang"
        lookBrg.ValueMember = "Kode_Barang"

        daCari = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daCari.Fill(dsCari, "Valuta")
        lookValuta.Properties.DataSource = dsCari.Tables("Valuta")
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
        lookValuta.Properties.ValueMember = "Kode_Valuta"

        daCari = New SqlDataAdapter(New SqlCommand("select Kode_Satuan, Nama_Satuan from SIF.dbo.SIF_Satuan ", sqlconn))
        daCari.Fill(dsCari, "Satuan")
        lookSatuan.DataSource = dsCari.Tables("Satuan")
        lookSatuan.DisplayMember = "Kode_Satuan"
        lookSatuan.ValueMember = "Kode_Satuan"

        daCari = New SqlDataAdapter(New SqlCommand("select Kd_Customer, Nama_Customer from SIF.dbo.SIF_Customer where Rec_Stat = 'Y'", sqlconn))
        daCari.Fill(dsCari, "Customer")
        lookCustomer.Properties.DataSource = dsCari.Tables("Customer")
        lookCustomer.Properties.DisplayMember = "Nama_Customer"
        lookCustomer.Properties.ValueMember = "Kd_Customer"

        daCari = New SqlDataAdapter(New SqlCommand("select Kode_Sales, Nama_Sales from SIF.dbo.SIF_Sales where Rec_Stat = 'Y'", sqlconn))
        daCari.Fill(dsCari, "Sales")
        lookSales.Properties.DataSource = dsCari.Tables("Sales")
        lookSales.Properties.DisplayMember = "Nama_Sales"
        lookSales.Properties.ValueMember = "Kode_Sales"
    End Sub

    Private Sub aFormManualNotaJual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadList()
        dteTanggal.EditValue = getTanggal()
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        loadList()
        dsCari = New DataSet
        daCari = New SqlDataAdapter(New SqlCommand("select tgl_inv as 'Tanggal Transaksi', no_inv as 'No. Transaksi', no_ref1 as 'No. Ref', keterangan as 'Keterangan', jml_val_trans as 'Total', no_posting from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-14'", sqlconn)) '<- query buat ditampilkan di LOV
        daCari.Fill(dsCari, "LookNota")
        frmCari.set_dso(dsCari.Tables("LookNota"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Total").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("no_posting").Visible = False
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Transaksi"))

            If Not (dsNota.Tables("Nota").Rows(0)("no_posting").ToString = vbNullString Or dsNota.Tables("Nota").Rows(0)("no_posting").ToString = "") Then
                MsgBox("No. Invoice : " & txtNoInv.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
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

    Public Sub delete_click()
        If Not txtNoInv.EditValue = vbNullString Then
            If MsgBox("Hapus nomor invoice " & txtNoInv.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                'STATE = "DELETE"
                For Each rw As DataRow In dsNota.Tables("Nota").Rows
                    Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur='" & rw.Item("no_jurnal") & "'", sqlconn)
                    sqlx.ExecuteNonQuery()
                    Dim sqly As New SqlCommand("delete from fin.dbo.fin_jurnal_d where no_jur='" & rw.Item("no_jurnal") & "'", sqlconn)
                    sqly.ExecuteNonQuery()
                    rw.Delete()
                Next
                For Each rw As DataRow In dsNota.Tables("NotaD").Rows
                    rw.Delete()
                Next
                save_click(True)
            End If
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If gvNota.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvNota.RowCount - 1
                gvNota.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub gvNota_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvNota.CellValueChanged
        Dim View As ColumnView = sender

        If e.Column Is kd_stok Then
            Dim row As DataRow = dsCari.Tables("Barang").Select("Kode_Barang='" & e.Value & "'")(0)
            View.SetRowCellValue(e.RowHandle, "satuan", row.Item("Kd_Satuan"))
        End If

        If e.Column Is Qty Then
            If Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "harga") Is DBNull And Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "tot_diskon") Is DBNull Then
                View.SetRowCellValue(e.RowHandle, "jml_val_trans", (View.GetRowCellValue(e.RowHandle, "Qty") * View.GetRowCellValue(e.RowHandle, "harga")) - View.GetRowCellValue(e.RowHandle, "tot_diskon"))
            End If
        End If

        If e.Column Is harga Then
            If Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "Qty") Is DBNull And Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "tot_diskon") Is DBNull Then
                View.SetRowCellValue(e.RowHandle, "jml_val_trans", (View.GetRowCellValue(e.RowHandle, "Qty") * View.GetRowCellValue(e.RowHandle, "harga")) - View.GetRowCellValue(e.RowHandle, "tot_diskon"))
            End If
        End If

        If e.Column Is tot_diskon Then
            If Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "Qty") Is DBNull And Not TypeOf gvNota.GetRowCellValue(e.RowHandle, "harga") Is DBNull Then
                View.SetRowCellValue(e.RowHandle, "jml_val_trans", (View.GetRowCellValue(e.RowHandle, "Qty") * View.GetRowCellValue(e.RowHandle, "harga")) - View.GetRowCellValue(e.RowHandle, "tot_diskon"))
            End If
        End If
    End Sub

    Private Sub gcHPP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvNota.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvNota.GetSelectedRows.Count > 0 Then
                gvNota.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub gvHPP_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvNota.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvNota.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("Qty"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("harga"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("tot_diskon"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_val_trans"), 0)
    End Sub

    Private Sub gvHPP_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvNota.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvHPP_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvNota.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "kd_stok" Then
            If e.Value = vbNull Then
                e.Valid = False
                e.ErrorText = "Tolong isi Nama Barang."
            End If
        End If
    End Sub

    Private Sub hitungPPN()
        If chkPPN.Checked = True Then
            ppn = txtJumlah.EditValue / 1.1
            txtPPN.EditValue = ppn
            txtTotal.EditValue = txtJumlah.EditValue + txtPPN.EditValue
        ElseIf chkPPN.Checked = False Then
            txtPPN.EditValue = 0
            txtTotal.EditValue = txtJumlah.EditValue
        End If
    End Sub

    Private Sub chkPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPPN.CheckedChanged
        hitungPPN()
    End Sub

    Private Sub gvNota_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvNota.RowUpdated
        txtJumlah.EditValue = 0
        For i As Integer = 0 To gvNota.RowCount - 1
            txtJumlah.EditValue += gvNota.GetRowCellValue(i, "jml_val_trans")
        Next
        hitungPPN()
    End Sub

    Private Sub txtJumlah_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlah.EditValueChanged
        hitungPPN()
    End Sub

    Private Sub lookValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtValuta.EditValue = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        If txtValuta.EditValue = 0 Then
            txtValuta.EditValue = 1
        End If
    End Sub
End Class