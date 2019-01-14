'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmPLNSHutangLain2

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Public obj As Object
    Dim xDS, dsValuta, dsSupp, dsJnsByr, dsGiro, dsInvoice, dsBeliLunasD, dsBeliLunas, dsTemp, dsPilih As New DataSet
    Dim xDA, daValuta, daSupp, daJnsByr, daGiro, daInvoice, daBeliLunasD, daBeliLunas, daTemp, daPilih As SqlClient.SqlDataAdapter

    Dim kode, tampung, cabang, tipeTrans As String

    Public STATE As String
    Dim row As DataRow

    Dim myBuilder, myBuilderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dr As SqlDataReader
    Dim param, ParamGenKode As String


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
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
    End Sub

    Sub LoadDataGrid(ByVal kode As String)


        If Not dsBeliLunas.Tables("beli_lunas") Is Nothing Then dsBeliLunas.Tables("beli_lunas").Clear()
        If Not dsBeliLunasD.Tables("beli_lunas_d") Is Nothing Then dsBeliLunasD.Tables("beli_lunas_d").Clear()
        daBeliLunasD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans = '" & kode & "'", sqlconn))
        daBeliLunasD.Fill(dsBeliLunasD, "beli_lunas_d")
        GC.DataSource = dsBeliLunasD.Tables("beli_lunas_d")
        GV.BestFitColumns()

        daBeliLunas = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daBeliLunas.Fill(dsBeliLunas, "beli_lunas")

        If dsBeliLunas.Tables("beli_lunas").Rows.Count > 0 Then
            With dsBeliLunas.Tables("beli_lunas")(0)
                txtNoTrans.EditValue = .Item("no_trans")
                txtNoRef.EditValue = .Item("no_ref1")
                LOVSupp.EditValue = .Item("kd_kartu")
                LOVValuta.EditValue = .Item("kd_valuta")
                txtKurs.EditValue = .Item("kurs_valuta")
                LOVJenisBayar.EditValue = .Item("jns_bayar")
                LOVGiro.EditValue = .Item("kd_giro")
                txtKeterangan.EditValue = .Item("keterangan")
            End With
        Else
            txtNoTrans.EditValue = vbNullString
            txtNoRef.EditValue = vbNullString
            LOVSupp.EditValue = vbNullString
            LOVValuta.EditValue = vbNullString
            txtKurs.EditValue = vbNullString
            LOVJenisBayar.EditValue = vbNullString
            LOVGiro.EditValue = vbNullString
            txtKeterangan.EditValue = vbNullString
        End If

    End Sub


    Sub GenLOV()
        dsValuta.Clear()
        daValuta = New SqlDataAdapter(New SqlCommand("select kode_valuta,nama_valuta from sif.dbo.SIF_valuta", sqlconn))
        daValuta.Fill(dsValuta, "valuta")
        LOVValuta.Properties.DataSource = dsValuta.Tables("valuta")
        LOVValuta.Properties.DisplayMember = "nama_valuta"
        LOVValuta.Properties.ValueMember = "kode_valuta"

        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.v_kartu", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVSupp.Properties.DataSource = dsSupp.Tables("kartu")
        LOVSupp.Properties.DisplayMember = "nama"
        LOVSupp.Properties.ValueMember = "kode"

        dsJnsByr.Clear()
        daJnsByr = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_gen_reff_d where id_ref_data='JNSBYR'", sqlconn))
        daJnsByr.Fill(dsJnsByr, "jenis_bayar")
        LOVJenisBayar.Properties.DataSource = dsJnsByr.Tables("jenis_bayar")
        LOVJenisBayar.Properties.DisplayMember = "Desc_Data"
        LOVJenisBayar.Properties.ValueMember = "Id_Data"

        dsGiro.Clear()
        daGiro = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_GIRO where kartu='" & LOVSupp.EditValue & "' and jns_giro = '" & LOVJenisBayar.EditValue & "' and kd_valuta = '" & LOVValuta.EditValue & "' and jns_trans='BELI' and status = 'CLEARING'", sqlconn))
        daGiro.Fill(dsGiro, "giro")
        LOVGiro.Properties.DataSource = dsGiro.Tables("giro")
        LOVGiro.Properties.DisplayMember = "nomor"
        LOVGiro.Properties.ValueMember = "nomor"

    End Sub

    Sub GenLOVGiro()
        dsGiro.Clear()
        daGiro = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_GIRO where kartu='" & LOVSupp.EditValue & "' and jns_giro = '" & LOVJenisBayar.EditValue & "' and kd_valuta = '" & LOVValuta.EditValue & "' and jns_trans='BELI' and status = 'CLEARING'", sqlconn))
        daGiro.Fill(dsGiro, "giro")
        LOVGiro.Properties.DataSource = dsGiro.Tables("giro")
        LOVGiro.Properties.DisplayMember = "nomor"
        LOVGiro.Properties.ValueMember = "nomor"
    End Sub

    Sub GenLOVInvoice()
        dsInvoice.Clear()
        daInvoice = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select x.*,Y.nama  from FIN.dbo.FIN_PEMBELIAN X,FIN.dbo.v_kartu Y  where X.kd_supplier = Y.kode  and X.kd_supplier='" & LOVSupp.EditValue & "' and X.kd_valuta='" & LOVValuta.EditValue & "' and X.tipe_trans ='JKM-KUT-01' and X.jml_akhir>0 ", sqlconn))
        daInvoice.Fill(dsInvoice, "invoice")
        RepLOVInvoice.DataSource = dsInvoice.Tables("invoice")
        RepLOVInvoice.Properties.DisplayMember = "no_inv"
        RepLOVInvoice.Properties.ValueMember = "no_inv"
    End Sub

    Private Sub frmPLNSHutangLain2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        LoadDataGrid("xxx")

        GenLOV()

        Try
            LOVSupp.ItemIndex = 0
            LOVValuta.EditValue = "IDR"
            LOVJenisBayar.EditValue = "01"
            Tanggal.EditValue = getTanggal()
        Catch ex As Exception
            MsgBox("Ada masalah dengan pengisian list data, " & ex.Message)
        End Try

    End Sub

    Sub autoRupiah()
        If LOVValuta.EditValue = "IDR" Then
            txtKurs.EditValue = "1"
        End If
    End Sub

    Private Sub LOVSupp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVSupp.EditValueChanged
        GenLOVInvoice()
        GenLOVGiro()
    End Sub

    Private Sub LOVValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVValuta.EditValueChanged
        GenLOVInvoice()
        autoRupiah()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmCari.ShowDialog()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim view As ColumnView = sender

        If Not dsTemp.Tables("LoadBeliLunas") Is Nothing Then dsTemp.Tables("LoadBeliLunas").Clear()
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN  where no_inv ='" & GV.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
        daTemp.Fill(dsTemp, "LoadBeliLunas")

        If e.Column Is prev_no_inv Then

            view.SetRowCellValue(e.RowHandle, "jml_tagihan", "0" & dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
            'view.SetRowCellValue(e.RowHandle, "jml_ppn", "0" & dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn").ToString)
            'view.SetRowCellValue(e.RowHandle, "jml_bayar", (dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_tagihan") + dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn")))
            view.SetRowCellValue(e.RowHandle, "kd_buku_besar", dsTemp.Tables("LoadBeliLunas").Rows(0).Item("kd_buku_besar").ToString)

        End If

        If e.Column Is jml_piut Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", CInt("0" & view.GetFocusedRowCellValue("jml_piut")) + CInt("0" & view.GetFocusedRowCellValue("jml_pembulatan")) + CInt("0" & view.GetFocusedRowCellValue("jml_admin")) - CInt("0" & view.GetFocusedRowCellValue("jml_diskon")))
        End If

        If e.Column Is jml_pembulatan Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", CInt("0" & view.GetFocusedRowCellValue("jml_piut")) + CInt("0" & view.GetFocusedRowCellValue("jml_pembulatan")) + CInt("0" & view.GetFocusedRowCellValue("jml_admin")) - CInt("0" & view.GetFocusedRowCellValue("jml_diskon")))
        End If

        If e.Column Is jml_admin Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", CInt("0" & view.GetFocusedRowCellValue("jml_piut")) + CInt("0" & view.GetFocusedRowCellValue("jml_pembulatan")) + CInt("0" & view.GetFocusedRowCellValue("jml_admin")) - CInt("0" & view.GetFocusedRowCellValue("jml_diskon")))
        End If

        If e.Column Is jml_diskon Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", CInt("0" & view.GetFocusedRowCellValue("jml_piut")) + CInt("0" & view.GetFocusedRowCellValue("jml_pembulatan")) + CInt("0" & view.GetFocusedRowCellValue("jml_admin")) - CInt("0" & view.GetFocusedRowCellValue("jml_diskon")))
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)
    End Sub

    Public Sub save_click()
        Try

            If LOVJenisBayar.EditValue = "03" Then
                tipeTrans = "JKK-KUT-03"
            Else
                tipeTrans = "JKK-KUT-07"
            End If

            'MsgBox(tipeTrans)

            Try
                txtRPtrans.EditValue = GV.Columns("jml_bayar").SummaryText * txtKurs.Text
            Catch ex As Exception
                lblError.Text = ex.Message
            End Try


            If STATE = "ADD" Then

                txtNoTrans.EditValue = getNoTrans("JKK", getTanggal)
                kode = txtNoTrans.EditValue
                row = dsBeliLunas.Tables("beli_lunas").NewRow

                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = tipeTrans
                row.Item("no_trans") = txtNoTrans.EditValue

                row.Item("tgl_trans") = Tanggal.EditValue
                row.Item("no_ref1") = txtNoRef.EditValue
                row.Item("thnbln") = Tanggal.DateTime.Year & Tanggal.DateTime.Month
                row.Item("kd_kartu") = LOVSupp.EditValue
                row.Item("kd_valuta") = LOVValuta.EditValue
                row.Item("kurs_valuta") = txtKurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtKurs.Text
                row.Item("jns_bayar") = LOVJenisBayar.EditValue
                row.Item("kd_giro") = LOVGiro.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue

                row.Item("last_create_date") = getTanggal()
                row.Item("last_created_by") = umum.username
                row.Item("program_name") = Me.Name

                dsBeliLunas.Tables("beli_lunas").Rows.Add(row)

                '======================================================================

                For Each rows As DataRow In dsBeliLunasD.Tables("beli_lunas_d").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("Kd_Cabang") = getKodeCabang()
                        rows.Item("tipe_trans") = tipeTrans
                        rows.Item("no_trans") = kode
                        rows.Item("kd_kartu") = LOVSupp.EditValue

                        rows.Item("Programe_name") = Me.Name
                        rows.Item("Last_create_date") = getTanggal()
                        rows.Item("Last_created_by") = umum.username
                    ElseIf rows.RowState = DataRowState.Modified Then
                        rows.Item("Last_update_date") = getTanggal()
                        rows.Item("Last_updated_by") = username
                    End If
                Next

            ElseIf STATE = "EDIT" Then

                row = dsBeliLunas.Tables("beli_lunas").Rows(0)

                row.Item("tgl_trans") = Tanggal.EditValue
                row.Item("no_ref1") = txtNoRef.EditValue
                row.Item("thnbln") = Tanggal.DateTime.Year & Tanggal.DateTime.Month
                row.Item("kd_kartu") = LOVSupp.EditValue
                row.Item("kd_valuta") = LOVValuta.EditValue
                row.Item("kurs_valuta") = txtKurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtKurs.Text
                row.Item("jns_bayar") = LOVJenisBayar.EditValue
                row.Item("kd_giro") = LOVGiro.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue

                row.Item("last_update_date") = getTanggal()
                row.Item("last_updated_by") = umum.username

                '======================================================================

                For Each rows As DataRow In dsBeliLunasD.Tables("beli_lunas_d").Rows
                    If rows.RowState = DataRowState.Added Then

                        rows.Item("Kd_Cabang") = getKodeCabang()
                        rows.Item("tipe_trans") = tipeTrans
                        rows.Item("kd_kartu") = LOVSupp.EditValue
                        rows.Item("Programe_name") = Me.Name

                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = username

                        rows.Item("last_create_date") = getTanggal()
                        rows.Item("last_created_by") = umum.username
                    ElseIf rows.RowState = DataRowState.Modified Then
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                        rows.Item("Programe_name") = Me.Name
                    End If
                Next

            ElseIf STATE = "DELETE" Then
                For Each RW As DataRow In dsBeliLunas.Tables(0).Rows
                    RW.Delete()
                Next

                For Each RW As DataRow In dsBeliLunasD.Tables(0).Rows
                    RW.Delete()
                Next

            End If

            'call_procedure(tipeTrans, txtNoTrans.EditValue, BTRANS)

            myBuilder = New SqlCommandBuilder(daBeliLunas)
            daBeliLunas.UpdateCommand = myBuilder.GetUpdateCommand()
            daBeliLunas.InsertCommand = myBuilder.GetInsertCommand()
            daBeliLunas.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilderD = New SqlCommandBuilder(daBeliLunasD)
            daBeliLunasD.UpdateCommand = myBuilderD.GetUpdateCommand()
            daBeliLunasD.InsertCommand = myBuilderD.GetInsertCommand()
            daBeliLunasD.DeleteCommand = myBuilderD.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daBeliLunas.UpdateCommand.Transaction = BTRANS
            daBeliLunas.InsertCommand.Transaction = BTRANS
            daBeliLunas.DeleteCommand.Transaction = BTRANS

            'BTRANS = sqlconn.BeginTransaction("1")
            daBeliLunasD.UpdateCommand.Transaction = BTRANS
            daBeliLunasD.InsertCommand.Transaction = BTRANS
            daBeliLunasD.DeleteCommand.Transaction = BTRANS

            daBeliLunas.Update(dsBeliLunas.Tables("beli_lunas"))
            daBeliLunasD.Update(dsBeliLunasD.Tables("beli_lunas_d"))

            call_procedure(tipeTrans, txtNoTrans.EditValue, BTRANS)

            BTRANS.Commit()
            showMessages("Data Baru Berhasil Disimpan")

            'dsAktiva.Tables("Aktiva").AcceptChanges()

            'Try
            '    BTRANS.Commit()
            '    showMessages("Data Baru Berhasil Disimpan")
            'Catch ex As Exception
            '    BTRANS.Rollback()
            '    dsJurnal.Tables("Jurnal").RejectChanges()
            '    MsgBox(ex.Message)
            'End Try

        Catch ex As Exception
            MsgBox("Ada masalah dalam penyimpan data, cek kembali isian data. Detail Error : " & ex.Message)
        End Try
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

    Public Sub edit_click()
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  no_trans from FIN.dbo.FIN_BELI_LUNAS", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        If Not dsTemp.Tables("lookup_so") Is Nothing Then dsTemp.Tables("lookup_so").Clear()
        daTemp.Fill(dsTemp, "lookup_so")
        frmCari.set_dso(dsTemp.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        'frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnSave = True

            LoadDataGrid(frmCari.row(0))
            STATE = "EDIT"
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            'cancel_click()
            STATE = ""
        End If
    End Sub


    Public Sub delete_click()
        If MsgBox("Apakah anda ingin menghapus ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            STATE = "DELETE"
            save_click()
            cancel_click()
        End If
    End Sub

    Private Sub txtKurs_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKurs.EditValueChanged

        ErrorProvider1.Clear()
        If LOVValuta.EditValue <> "1" Then
            If txtKurs.EditValue = 0 Then
                ErrorProvider1.SetError(txtKurs, "Kurs tidak boleh 0")
            End If
        End If

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub

    Private Sub gv_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        Dim vx As GridView = sender
        vx.SetFocusedRowCellValue("jml_bayar", 0)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError

    End Sub

    Private Sub gv_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "jml_bayar" Then
            If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
                e.Valid = False
                e.ErrorText = "Tidak boleh lebih dari hutang/tagihan"
            End If
        End If


        If vx.FocusedColumn.FieldName = "jml_piut" Then
            If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
                e.Valid = False
                e.ErrorText = "Tidak boleh lebih dari hutang/tagihan"
            End If
        End If


    End Sub

    Public Sub cancel_click()
        LoadDataGrid("xxx")

        GenLOV()
        LOVValuta.EditValue = "IDR"
        LOVJenisBayar.EditValue = "01"

        STATE = "ADD"

        btnadd = False
        btnEdit = True
        btnDelete = False
        btnSave = False

    End Sub

    Private Sub txtNoRef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoRef.KeyPress, LOVSupp.KeyPress, LOVValuta.KeyPress, txtKurs.KeyPress, LOVJenisBayar.KeyPress, LOVGiro.KeyPress, txtKeterangan.KeyPress, txtJumlahGiro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub LOVGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVGiro.EditValueChanged
        Try
            dsPilih.Clear()
            daPilih = New SqlDataAdapter(New SqlCommand("select jml_trans from FIN.dbo.FIN_GIRO where nomor = '" & LOVGiro.EditValue & "'", sqlconn))
            daPilih.Fill(dsPilih, "giro")

            txtJumlahGiro.EditValue = dsPilih.Tables("giro").Rows(0).Item("jml_trans").ToString
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class