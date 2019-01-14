﻿'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY all team FA     |
'|-----------------------

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmPLNSHutangUsaha3

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
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
            .btnCetak.Enabled = btnCetak
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
        LoadDataGrid("xxx")
    End Sub

    Sub LoadDataGrid(ByVal kode As String)

        If Not dsBeliLunas.Tables("beli_lunas") Is Nothing Then dsBeliLunas.Tables("beli_lunas").Clear()
        If Not dsBeliLunasD.Tables("beli_lunas_d") Is Nothing Then dsBeliLunasD.Tables("beli_lunas_d").Clear()

        daBeliLunas = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daBeliLunas.Fill(dsBeliLunas, "beli_lunas")
        daBeliLunasD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans = '" & kode & "'", sqlconn))
        daBeliLunasD.Fill(dsBeliLunasD, "beli_lunas_d")
        GC.DataSource = dsBeliLunasD.Tables("beli_lunas_d")
        'GV.BestFitColumns()

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
            LOVSupp.ItemIndex = 0
            LOVValuta.EditValue = "IDR"
            txtKurs.EditValue = 1
            LOVJenisBayar.EditValue = "01"
            Tanggal.EditValue = getTanggal()
            txtNoTrans.EditValue = vbNullString
            txtNoRef.EditValue = vbNullString
            txtKurs.EditValue = vbNullString
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
        daSupp = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_supplier", sqlconn))
        daSupp.Fill(dsSupp, "supplier")
        LOVSupp.Properties.DataSource = dsSupp.Tables("supplier")
        LOVSupp.Properties.DisplayMember = "Nama_Supplier"
        LOVSupp.Properties.ValueMember = "Kode_Supplier"

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
        'MsgBox(LOVSupp.EditValue & "  " & LOVJenisBayar.EditValue & "  " & LOVValuta.EditValue)
        daGiro = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_GIRO where kartu='" & LOVSupp.EditValue & "' and jns_giro = '" & LOVJenisBayar.EditValue & "' and kd_valuta = '" & LOVValuta.EditValue & "' and jns_trans='BELI' and status like 'KELUAR%'", sqlconn))
        daGiro.Fill(dsGiro, "giro")
        LOVGiro.Properties.DataSource = dsGiro.Tables("giro")
        LOVGiro.Properties.DisplayMember = "nomor"
        LOVGiro.Properties.ValueMember = "nomor"
    End Sub

    Sub GenLOVInvoice()
        dsInvoice.Clear()
        If STATE = "ADD" Then
            daInvoice = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select x.* from FIN.dbo.FIN_PEMBELIAN X where X.kd_supplier='" & LOVSupp.EditValue & "' and X.kd_valuta='" & LOVValuta.EditValue & "' and X.tipe_trans ='JPP-KUT-01' and X.jml_akhir > 0 and not (x.no_posting is null or x.no_posting='')", sqlconn))
        Else
            daInvoice = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select x.* from FIN.dbo.FIN_PEMBELIAN X where X.kd_supplier='" & LOVSupp.EditValue & "' and X.kd_valuta='" & LOVValuta.EditValue & "' and X.tipe_trans ='JPP-KUT-01' and not (x.no_posting is null or x.no_posting='')", sqlconn))
        End If
        daInvoice.Fill(dsInvoice, "invoice")
        RepLOVInvoice.DataSource = dsInvoice.Tables("invoice")
        RepLOVInvoice.Properties.DisplayMember = "no_inv"
        RepLOVInvoice.Properties.ValueMember = "no_inv"
    End Sub

    Private Sub frmPLNSHutangUsaha3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        GenLOV()

        Try
            LOVSupp.ItemIndex = 0
            LOVValuta.EditValue = "IDR"
            txtKurs.EditValue = "1"
            LOVJenisBayar.EditValue = "01"
            Tanggal.EditValue = getTanggal()
        Catch ex As Exception
            MsgBox("Ada masalah dengan pengisian list data, " & ex.Message)
        End Try

    End Sub

    Sub autoRupiah()
        If LOVValuta.EditValue = "IDR" Then
            txtKurs.EditValue = 1
        End If
    End Sub

    Private Sub LOVSupp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVSupp.EditValueChanged
        GenLOVInvoice()
        GenLOVGiro()
    End Sub

    Private Sub LOVValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVValuta.EditValueChanged
        GenLOVInvoice()
        autoRupiah()
        GenLOVGiro()
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim view As ColumnView = sender

        If Not dsTemp.Tables("LoadBeliLunas") Is Nothing Then dsTemp.Tables("LoadBeliLunas").Clear()
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv ='" & GV.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
        daTemp.Fill(dsTemp, "LoadBeliLunas")

        If e.Column Is prev_no_inv Then
 
            view.SetRowCellValue(e.RowHandle, "jml_tagihan", dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
            'view.SetRowCellValue(e.RowHandle, "jml_ppn", "0" & dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn").ToString)
            'view.SetRowCellValue(e.RowHandle, "jml_bayar", (dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_tagihan") + dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn")))
            view.SetRowCellValue(e.RowHandle, "kd_buku_besar", dsTemp.Tables("LoadBeliLunas").Rows(0).Item("kd_buku_besar").ToString)
            view.SetRowCellValue(e.RowHandle, "jml_piut", dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_akhir").ToString)
        End If

        If e.Column Is jml_piut Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(view.GetFocusedRowCellValue("jml_piut"), 0) + isNull(view.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(view.GetFocusedRowCellValue("jml_admin"), 0) - isNull(view.GetFocusedRowCellValue("jml_diskon"), 0))
        End If

        If e.Column Is jml_pembulatan Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(view.GetFocusedRowCellValue("jml_piut"), 0) + isNull(view.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(view.GetFocusedRowCellValue("jml_admin"), 0) - isNull(view.GetFocusedRowCellValue("jml_diskon"), 0))
        End If

        If e.Column Is jml_admin Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(view.GetFocusedRowCellValue("jml_piut"), 0) + isNull(view.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(view.GetFocusedRowCellValue("jml_admin"), 0) - isNull(view.GetFocusedRowCellValue("jml_diskon"), 0))
        End If

        If e.Column Is jml_diskon Then
            view.SetRowCellValue(e.RowHandle, "jml_bayar", isNull(view.GetFocusedRowCellValue("jml_piut"), 0) + isNull(view.GetFocusedRowCellValue("jml_pembulatan"), 0) + isNull(view.GetFocusedRowCellValue("jml_admin"), 0) - isNull(view.GetFocusedRowCellValue("jml_diskon"), 0))
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_piut"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_admin"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_diskon"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_pembulatan"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_bayar"), 0)
    End Sub

    Public Sub save_click()
        Try

            If LOVJenisBayar.EditValue = "03" Then
                tipeTrans = "JKK-KUT-04"
            Else
                tipeTrans = "JKK-KUT-01"
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
                row.Item("thnbln") = Format(Tanggal.EditValue, "yyyyMM")
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
                row.Item("thnbln") = Format(Tanggal.EditValue, "yyyyMM")
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
                For Each RW As DataRow In dsBeliLunas.Tables("beli_lunas").Rows
                    RW.Delete()
                Next

                For Each RW As DataRow In dsBeliLunasD.Tables("beli_lunas_d").Rows
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

            If STATE = "DELETE" Then
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & txtNoTrans.Text & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With

                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & txtNoTrans.Text & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
            End If

            daBeliLunas.UpdateCommand.Transaction = BTRANS
            daBeliLunas.InsertCommand.Transaction = BTRANS
            daBeliLunas.DeleteCommand.Transaction = BTRANS

            'BTRANS = sqlconn.BeginTransaction("1")
            daBeliLunasD.UpdateCommand.Transaction = BTRANS
            daBeliLunasD.InsertCommand.Transaction = BTRANS
            daBeliLunasD.DeleteCommand.Transaction = BTRANS

            daBeliLunas.Update(dsBeliLunas.Tables("beli_lunas"))
            daBeliLunasD.Update(dsBeliLunasD.Tables("beli_lunas_d"))

            If Not STATE = "DELETE" Then
                call_procedure(tipeTrans, txtNoTrans.EditValue, BTRANS)
            End If

            Try
                BTRANS.Commit()

                If STATE = "ADD" Then
                    showMessages("Data Baru Berhasil Disimpan")
                    LoadDataGrid("xxx")
                ElseIf STATE = "EDIT" Or STATE = "DELETE" Then
                    showMessages("Data Berhasil Diubah")
                    cancel_click()
                End If

            Catch ex As Exception
                BTRANS.Rollback()
                dsBeliLunas.Tables("beli_lunas").RejectChanges()
                dsBeliLunasD.Tables("beli_lunas_d").RejectChanges()
                MsgBox(ex.Message)
            End Try

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

    Private Sub controlOff(ByVal stat As Boolean)
        txtNoTrans.Properties.ReadOnly = stat
        Tanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        LOVSupp.Properties.ReadOnly = stat
        LOVValuta.Properties.ReadOnly = stat
        txtKurs.Properties.ReadOnly = stat
        LOVJenisBayar.Properties.ReadOnly = stat
        LOVGiro.Properties.ReadOnly = stat
        txtKeterangan.Properties.ReadOnly = stat
        txtJumlahGiro.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_trans as 'No. Trans', a.tgl_trans as 'Tanggal', b.Nama_Supplier as 'Supplier', a.no_posting as 'No. Posting', a.jml_val_trans as 'Jumlah' from FIN.dbo.FIN_BELI_LUNAS a, SIF.dbo.SIF_Supplier b where a.kd_kartu = b.Kode_Supplier", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        If Not dsTemp.Tables("lookup_so") Is Nothing Then dsTemp.Tables("lookup_so").Clear()
        daTemp.Fill(dsTemp, "lookup_so")
        frmCari.set_dso(dsTemp.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        'frmCari.GV.Columns(2).Visible = False
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadDataGrid(frmCari.row("No. Trans"))
            If (frmCari.row("No. Posting") = "" Or frmCari.row("No. Posting") = vbNullString) Then
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnSave = True
                btnCancel = True
                setStatus()
                Me.Enabled = True
            Else
                MsgBox("Data tidak dapat diubah karena sudah diposting.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnSave = False
                btnCancel = True
                setStatus()
                controlOff(True)
            End If
        Else
            cancel_click()
        End If
    End Sub


    Public Sub delete_click()
        If MsgBox("Apakah anda ingin menghapus ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            STATE = "DELETE"
            save_click()
            cancel_click()
        End If
    End Sub

    Private Sub txtKurs_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ErrorProvider1.Clear()
        If LOVValuta.EditValue <> "1" Then
            If txtKurs.EditValue = 0 Then
                txtKurs.EditValue = 1
                'ErrorProvider1.SetError(txtKurs, "Kurs tidak boleh 0")
            End If
        End If

    End Sub

    'Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    delete_click()
    'End Sub

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

        controlOff(False)
        LoadDataGrid("xxx")
        GenLOV()
        'LOVValuta.EditValue = "IDR"
        'LOVJenisBayar.EditValue = "01"

        STATE = ""

        btnadd = True
        btnEdit = True
        btnDelete = False
        btnSave = False
        btnCancel = False
        setStatus()
        Me.Enabled = False

    End Sub

    Private Sub txtNoRef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoRef.KeyPress, LOVSupp.KeyPress, LOVValuta.KeyPress, LOVJenisBayar.KeyPress, LOVGiro.KeyPress, txtKeterangan.KeyPress, txtJumlahGiro.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub LOVGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVGiro.EditValueChanged
        Try
            dsPilih.Clear()
            daPilih = New SqlDataAdapter(New SqlCommand("select jml_trans, kd_valuta, kurs_valuta from FIN.dbo.FIN_GIRO where nomor = '" & LOVGiro.EditValue & "'", sqlconn))
            daPilih.Fill(dsPilih, "giro")

            txtJumlahGiro.EditValue = dsPilih.Tables("giro").Rows(0).Item("jml_trans").ToString
            LOVValuta.EditValue = dsPilih.Tables("giro").Rows(0).Item("kd_valuta").ToString
            txtKurs.EditValue = dsPilih.Tables("giro").Rows(0).Item("kurs_valuta").ToString
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub LOVJenisBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVJenisBayar.EditValueChanged
        GenLOVGiro()
    End Sub

    Private Sub LOVGiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LOVGiro.QueryPopUp
        GenLOVGiro()
    End Sub
End Class