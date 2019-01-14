Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormCancelGiroLunas
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Public obj As Object
    Dim dsNotaLunas, dsEdit, dsGiro As New DataSet
    Public STATE, statex As String
    Dim rw, row As DataRow
    Dim kode, tampung, cabang As String
    Dim DA, daEdit, daGiro, daNota, daNotaLEdit, daNotaLDEdit, daNotaL, daNotaLD, daCust, daVal, daByr, daDO, daNoTrans As SqlDataAdapter
    Dim builderM, builderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim drPost As SqlDataReader
    Dim param, kodeCari As String

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

    Public Sub cetak_click()
        callReport(App_Path() & "\report\rptPOJ.rpt", "", "Nomor=" & Trim(lookNoTrans.EditValue))
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

    Private Sub View_Valuta()
        If Not dsNotaLunas.Tables("View_Valuta") Is Nothing Then dsNotaLunas.Tables("View_Valuta").Clear()
        daVal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        daVal.Fill(dsNotaLunas, "View_Valuta")
        lookValuta.Properties.DataSource = dsNotaLunas.Tables("View_Valuta")
        lookValuta.Properties.ValueMember = "Kode_Valuta"
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub View_NoTrans()
        If Not dsNotaLunas.Tables("View_NoTrans") Is Nothing Then dsNotaLunas.Tables("View_NoTrans").Clear()
        daNoTrans = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT no_trans FROM FIN.dbo.FIN_NOTA_LUNAS WHERE tipe_trans LIKE 'JKM-KPT-01' AND Jns_bayar IN ('01','02')", sqlconn))
        daNoTrans.Fill(dsNotaLunas, "View_NoTrans")
        lookNoTrans.Properties.DataSource = dsNotaLunas.Tables("View_NoTrans")
        lookNoTrans.Properties.ValueMember = "no_trans"
        lookNoTrans.Properties.DisplayMember = "no_trans"
    End Sub

    Private Sub v_nota()
        If Not dsNotaLunas.Tables("vnota") Is Nothing Then dsNotaLunas.Tables("vnota").Clear()
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_Nota where kd_cust='" & lookCust.EditValue & "' and kd_valuta='" & lookValuta.EditValue & "' and tipe_trans in ('JPJ-KPT-01','JPJ-KPT-02') and jml_akhir>0 ", sqlconn))
        daNota.Fill(dsNotaLunas, "vnota")
        repBrg.DataSource = dsNotaLunas.Tables("vnota")
    End Sub

    Private Sub V_Customer()
        If Not dsNotaLunas.Tables("View_Customer") Is Nothing Then dsNotaLunas.Tables("View_Customer").Clear()
        daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer, Nama_Customer, Alamat1 from sif.dbo.SIF_Customer", sqlconn))
        daCust.Fill(dsNotaLunas, "View_Customer")
        lookCust.Properties.DataSource = dsNotaLunas.Tables("View_Customer")
        lookCust.Properties.ValueMember = "Kd_Customer"
        lookCust.Properties.DisplayMember = "Nama_Customer"
    End Sub

    Private Sub V_giro()
        If Not dsNotaLunas.Tables("View_giro") Is Nothing Then dsNotaLunas.Tables("View_giro").Clear()
        If lookCust.EditValue = vbNullString Then
            lookGiro.Enabled = False
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kd_valuta='" & lookValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-10' and status='CLEARING'", sqlconn))
        Else
            lookGiro.Enabled = True
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kartu='" & lookCust.EditValue & "' and kd_valuta='" & lookValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-10' and status='CLEARING'", sqlconn))
        End If
        daGiro.Fill(dsNotaLunas, "View_giro")
        lookGiro.Properties.DataSource = dsNotaLunas.Tables("View_giro")
        lookGiro.Properties.ValueMember = "nomor"
        lookGiro.Properties.DisplayMember = "nomor"
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Private Sub bersih()
        lookCust.EditValue = vbNullString
        lookGiro.EditValue = vbNullString
        lookValuta.EditValue = "IDR"
        txtKurs.EditValue = "1"
        txtKurs.Enabled = False
        txtKet.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        lookNoTrans.EditValue = vbNullString
        If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then dsEdit.Tables("NotaLunasDCari").Clear()
        If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If lookCust.EditValue = vbNullString Then
            MsgBox("Customer belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            lookCust.Focus()
            Exit Sub
        End If

        If Not isDelete Then
            If STATE = "ADD" Then
                kode = getNoTrans("JKK", getTanggal)
                txtNomor.EditValue = kode
                row = dsNotaLunas.Tables("NotaLunas").NewRow
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = "JKK-KPT-03"
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("no_ref1") = lookNoTrans.EditValue
                row.Item("kd_kartu") = lookCust.EditValue
                row.Item("kd_valuta") = lookValuta.EditValue
                row.Item("keterangan") = txtKet.EditValue
                row.Item("kurs_valuta") = txtKurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtKurs.EditValue
                row.Item("no_giro") = lookGiro.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("thnbln") = dtTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtTanggal.EditValue, DateFormat.GeneralDate), 4, 2)
                dsNotaLunas.Tables("NotaLunas").Rows.Add(row)

            ElseIf STATE = "EDIT" Then
                row = dsEdit.Tables("NotaLunasCari").Rows(0)
                row.Item("tipe_trans") = "JKK-KPT-03"
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("no_ref1") = lookNoTrans.EditValue
                row.Item("kd_kartu") = lookCust.EditValue
                row.Item("keterangan") = txtKet.EditValue
                row.Item("kd_valuta") = lookValuta.EditValue
                row.Item("kurs_valuta") = txtKurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtKurs.Text
                row.Item("no_giro") = lookGiro.EditValue
                row.Item("thnbln") = dtTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtTanggal.EditValue, DateFormat.GeneralDate), 4, 2)
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

            If Not GV.RowCount = 0 Then
                If STATE = "ADD" Then
                    For Each rows As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
                        If rows.RowState = DataRowState.Added Then
                            rows.Item("Last_Create_Date") = Now
                            rows.Item("Last_Created_By") = username
                            rows.Item("Kd_Cabang") = getKodeCabang()
                            rows.Item("no_trans") = kode
                            rows.Item("Programe_name") = Me.Name
                            rows.Item("kd_kartu") = lookCust.EditValue
                            rows.Item("tipe_trans") = "JKK-KPT-03"
                        ElseIf rows.RowState = DataRowState.Modified Then
                            rows.Item("Last_Update_Date") = Now
                            rows.Item("Last_Updated_By") = username
                            rows.Item("Programe_name") = Me.Name
                        Else
                            rows.Item("tipe_trans") = "JKK-KPT-03"
                        End If
                    Next
                ElseIf STATE = "EDIT" Then
                    For Each rows As DataRow In dsEdit.Tables("NotaLunasDCari").Rows
                        If rows.RowState = DataRowState.Added Then
                            rows.Item("Last_Create_Date") = Now
                            rows.Item("Last_Created_By") = username
                            rows.Item("Kd_Cabang") = getKodeCabang()
                            rows.Item("no_trans") = kodeCari
                            rows.Item("Last_Update_Date") = Now
                            rows.Item("Last_Updated_By") = username
                            rows.Item("Programe_name") = Me.Name
                            rows.Item("kd_kartu") = lookCust.EditValue
                            rows.Item("tipe_trans") = "JKK-KPT-03"
                        ElseIf rows.RowState = DataRowState.Modified Then
                            rows.Item("Last_Update_Date") = Now
                            rows.Item("Last_Updated_By") = username
                            rows.Item("Programe_name") = Me.Name
                        Else
                            rows.Item("tipe_trans") = "JKK-KPT-03"
                        End If
                    Next
                End If
            End If

            If STATE = "ADD" Then
                Try
                    If Not GV.RowCount < 0 Then
                        builderM = New SqlCommandBuilder(daNotaL)
                        daNotaL.UpdateCommand = builderM.GetUpdateCommand()
                        daNotaL.InsertCommand = builderM.GetInsertCommand()
                        daNotaL.DeleteCommand = builderM.GetDeleteCommand()

                        builderD = New SqlCommandBuilder(daNotaLD)
                        daNotaLD.UpdateCommand = builderD.GetUpdateCommand()
                        daNotaLD.InsertCommand = builderD.GetInsertCommand()
                        daNotaLD.DeleteCommand = builderD.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daNotaL.UpdateCommand.Transaction = BTRANS
                        daNotaL.InsertCommand.Transaction = BTRANS
                        daNotaL.DeleteCommand.Transaction = BTRANS

                        daNotaLD.UpdateCommand.Transaction = BTRANS
                        daNotaLD.InsertCommand.Transaction = BTRANS
                        daNotaLD.DeleteCommand.Transaction = BTRANS

                        daNotaL.Update(dsNotaLunas.Tables("NotaLunas"))
                        daNotaLD.Update(dsNotaLunas.Tables("NotaLunasD"))

                        dsNotaLunas.Tables("NotaLunas").AcceptChanges()
                        dsNotaLunas.Tables("NotaLunasD").AcceptChanges()
                    Else
                        builderM = New SqlCommandBuilder(daNotaL)
                        daNotaL.UpdateCommand = builderM.GetUpdateCommand()
                        daNotaL.InsertCommand = builderM.GetInsertCommand()
                        daNotaL.DeleteCommand = builderM.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daNotaL.UpdateCommand.Transaction = BTRANS
                        daNotaL.InsertCommand.Transaction = BTRANS
                        daNotaL.DeleteCommand.Transaction = BTRANS

                        daNotaL.Update(dsNotaLunas.Tables("NotaLunas"))

                        dsNotaLunas.Tables("NotaLunas").AcceptChanges()
                    End If

                    'If lookDO.EditValue = "JRR-KPT-10" Then
                    '    call_procedure("JKM-KPT-01", kode, BTRANS)
                    'Else
                    '    call_procedure("JKM-KPT-05", kode, BTRANS)
                    'End If

                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    'STATE = "EDIT"
                    'kodeCari = kode
                    'If Not dsEdit.Tables("NotaLunasCari") Is Nothing Then dsEdit.Tables("NotaLunasCari").Clear()
                    'If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then dsEdit.Tables("NotaLunasDCari").Clear()
                    'daNotaLEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans='" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
                    'daNotaLEdit.Fill(dsEdit, "NotaLunasCari")
                    'daNotaLDEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans='" & kode & "'", sqlconn))
                    'daNotaLDEdit.Fill(dsEdit, "NotaLunasDCari")
                    'GC.DataSource = dsEdit.Tables("NotaLunasDCari")
                    'GC.RefreshDataSource()
                    'btnDelete = True
                    'setStatus()
                Catch e As Exception
                    BTRANS.Rollback()
                    dsNotaLunas.Tables("NotaLunas").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    dsNotaLunas.Tables("NotaLunasD").RejectChanges()
                    MsgBox(e.Message)
                End Try
            Else
                Try
                    If Not GV.RowCount < 0 Then
                        builderM = New SqlCommandBuilder(daNotaLEdit)
                        daNotaLEdit.UpdateCommand = builderM.GetUpdateCommand()
                        daNotaLEdit.InsertCommand = builderM.GetInsertCommand()
                        daNotaLEdit.DeleteCommand = builderM.GetDeleteCommand()

                        builderD = New SqlCommandBuilder(daNotaLDEdit)
                        daNotaLDEdit.UpdateCommand = builderD.GetUpdateCommand()
                        daNotaLDEdit.InsertCommand = builderD.GetInsertCommand()
                        daNotaLDEdit.DeleteCommand = builderD.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daNotaLEdit.UpdateCommand.Transaction = BTRANS
                        daNotaLEdit.InsertCommand.Transaction = BTRANS
                        daNotaLEdit.DeleteCommand.Transaction = BTRANS

                        daNotaLDEdit.UpdateCommand.Transaction = BTRANS
                        daNotaLDEdit.InsertCommand.Transaction = BTRANS
                        daNotaLDEdit.DeleteCommand.Transaction = BTRANS

                        daNotaLEdit.Update(dsEdit.Tables("NotaLunasCari"))
                        daNotaLDEdit.Update(dsEdit.Tables("NotaLunasDCari"))

                        dsEdit.Tables("NotaLunasCari").AcceptChanges()
                        dsEdit.Tables("NotaLunasDCari").AcceptChanges()
                    Else
                        builderM = New SqlCommandBuilder(daNotaLEdit)
                        daNotaLEdit.UpdateCommand = builderM.GetUpdateCommand()
                        daNotaLEdit.InsertCommand = builderM.GetInsertCommand()
                        daNotaLEdit.DeleteCommand = builderM.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daNotaLEdit.UpdateCommand.Transaction = BTRANS
                        daNotaLEdit.InsertCommand.Transaction = BTRANS
                        daNotaLEdit.DeleteCommand.Transaction = BTRANS

                        daNotaLEdit.Update(dsNotaLunas.Tables("NotaLunasCari"))

                        dsEdit.Tables("NotaLunasCari").AcceptChanges()
                    End If
                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    STATE = "EDIT"
                Catch e As Exception
                    BTRANS.Rollback()
                    dsEdit.Tables("NotaLunasCari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                    dsEdit.Tables("NotaLunasDCari").RejectChanges()
                    MsgBox(e.Message)
                End Try
            End If
        Else
            Try
                builderM = New SqlCommandBuilder(daNotaLEdit)
                daNotaLEdit.UpdateCommand = builderM.GetUpdateCommand()
                daNotaLEdit.InsertCommand = builderM.GetInsertCommand()
                daNotaLEdit.DeleteCommand = builderM.GetDeleteCommand()

                builderD = New SqlCommandBuilder(daNotaLDEdit)
                daNotaLDEdit.UpdateCommand = builderD.GetUpdateCommand()
                daNotaLDEdit.InsertCommand = builderD.GetInsertCommand()
                daNotaLDEdit.DeleteCommand = builderD.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daNotaLEdit.UpdateCommand.Transaction = BTRANS
                daNotaLEdit.InsertCommand.Transaction = BTRANS
                daNotaLEdit.DeleteCommand.Transaction = BTRANS

                daNotaLDEdit.UpdateCommand.Transaction = BTRANS
                daNotaLDEdit.InsertCommand.Transaction = BTRANS
                daNotaLDEdit.DeleteCommand.Transaction = BTRANS

                daNotaLEdit.Update(dsEdit.Tables("NotaLunasCari"))
                daNotaLDEdit.Update(dsEdit.Tables("NotaLunasDCari"))

                dsEdit.Tables("NotaLunasCari").AcceptChanges()
                dsEdit.Tables("NotaLunasDCari").AcceptChanges()

                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                STATE = ""
                cancel_click()
            Catch e As Exception
                BTRANS.Rollback()
                dsEdit.Tables("NotaLunasCari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsEdit.Tables("NotaLunasDCari").RejectChanges()
                MsgBox(e.Message)
            End Try
        End If
        lookGiro.Enabled = True
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then dsNotaLunas.Tables("NotaLunas").Clear()
        If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()

        daNotaL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daNotaL.Fill(dsNotaLunas, "NotaLunas")

        daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
        daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        GC.DataSource = dsNotaLunas.Tables("NotaLunasD")
        'AddHandler ds4.Tables("PODcari").RowDeleted, AddressOf refreshNomer

        If dsNotaLunas.Tables("NotaLunas").Rows.Count > 0 Then
            row = dsNotaLunas.Tables("NotaLunas").Rows(0)
            lookNoTrans.EditValue = row.Item("no_trans").ToString
            lookValuta.EditValue = row.Item("kd_valuta").ToString
            txtKurs.EditValue = row.Item("kurs_valuta").ToString
            dtTanggal.EditValue = row.Item("tgl_trans").ToString
            txtKet.EditValue = row.Item("keterangan").ToString
            lookCust.EditValue = row.Item("kd_supplier").ToString
        End If
    End Sub

    Private Sub aFormCancelGiroLunas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        View_Valuta()
        V_Customer()
        View_NoTrans()
        dtTanggal.EditValue = getTanggal()
        lookValuta.EditValue = "IDR"
        txtKurs.Enabled = False
        txtKurs.Text = "1"
        'If lookNoTrans.EditValue = vbNullString Then
        '    reload_table("xxx")
        'End If
    End Sub

    Private Sub lookValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtKurs.Enabled = False
            txtKurs.Text = "1"
        Else
            txtKurs.Enabled = True
            txtKurs.Focus()
        End If
        V_giro()
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If STATE = "ADD" Then
            If GV.RowCount = 0 Then
                Exit Sub
            Else
                For j As Integer = 0 To GV.RowCount - 1
                    GV.GetDataRow(j).Item("no_seq") = i
                    i += 1
                Next
            End If
        Else
            If GV.RowCount = 0 Then
                Exit Sub
            Else
                For Each rw As DataRow In dsEdit.Tables("NotaLunasDCari").Rows
                    If rw.RowState <> DataRowState.Deleted Then
                        rw("no_seq") = i
                        i += 1
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Nota dengan nomor " & kodeCari & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            If Not dsEdit.Tables("NotaLunasCari") Is Nothing Then
                For Each rw As DataRow In dsEdit.Tables("NotaLunasCari").Rows
                    rw.Delete()
                Next
            End If
            If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then
                For Each rw As DataRow In dsEdit.Tables("NotaLunasDCari").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
            STATE = ""
        End If
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim view As ColumnView = sender

        If Not dsEdit.Tables("LoadNota") Is Nothing Then dsEdit.Tables("LoadNota").Clear()
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv='" & GV.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
        daNota.Fill(dsEdit, "LoadNota")

        If e.Column Is prev_no_inv Then
            view.SetRowCellValue(e.RowHandle, "jml_piut", dsEdit.Tables("LoadNota").Rows(0).Item("jml_val_trans"))
            view.SetRowCellValue(e.RowHandle, "jml_ppn", dsEdit.Tables("LoadNota").Rows(0).Item("jml_val_ppn"))
            view.SetRowCellValue(e.RowHandle, "pendp_lain", dsEdit.Tables("LoadNota").Rows(0).Item("pendp_lain"))
            view.SetRowCellValue(e.RowHandle, "jml_diskon", dsEdit.Tables("LoadNota").Rows(0).Item("jml_diskon"))
            view.SetRowCellValue(e.RowHandle, "biaya_lain", dsEdit.Tables("LoadNota").Rows(0).Item("biaya_lain"))
            view.SetRowCellValue(e.RowHandle, "jml_bayar", dsEdit.Tables("LoadNota").Rows(0).Item("jml_bayar"))
            view.SetRowCellValue(e.RowHandle, "keterangan", dsEdit.Tables("LoadNota").Rows(0).Item("keterangan"))
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus detil nota yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                    refreshNomer()
                End If
            End If
        End If
    End Sub

    Private Sub lookCust_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookCust.EditValueChanged
        v_nota()
        V_giro()
    End Sub

    Private Sub lookGiro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookGiro.EditValueChanged
        drPost = New SqlCommand("SELECT jml_trans FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & lookGiro.EditValue & "'", sqlconn).ExecuteReader
        While drPost.Read()
            txtJmlGiro.Text = drPost.Item("jml_trans")
        End While
        drPost.Close()
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Private Sub lookNoTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookNoTrans.EditValueChanged
        If Not dsGiro.Tables("NotaLunasLoad") Is Nothing Then dsGiro.Tables("NotaLunasLoad").Clear()
        If Not dsGiro.Tables("NotaLunasDLoad") Is Nothing Then dsGiro.Tables("NotaLunasDLoad").Clear()
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans='" & lookNoTrans.EditValue & "'", sqlconn))
        daNota.Fill(dsGiro, "NotaLunasLoad")
        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans='" & lookNoTrans.EditValue & "'", sqlconn))
        daNota.Fill(dsGiro, "NotaLunasDLoad")

        dtTanggal.EditValue = dsGiro.Tables("NotaLunasLoad").Rows(0).Item("tgl_trans")
        lookCust.EditValue = dsGiro.Tables("NotaLunasLoad").Rows(0).Item("kd_kartu")
        lookValuta.EditValue = dsGiro.Tables("NotaLunasLoad").Rows(0).Item("kd_valuta")
        lookGiro.EditValue = dsGiro.Tables("NotaLunasLoad").Rows(0).Item("no_giro")
        txtKet.EditValue = dsGiro.Tables("NotaLunasLoad").Rows(0).Item("keterangan")
        GC.DataSource = dsGiro.Tables("NotaLunasDLoad")
    End Sub
End Class