Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class formLunasPiutangUsaha
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dsNotaLunas, dsEdit As New DataSet
    Public STATE, statex As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim rw, row As DataRow
    Dim kode, tampung, cabang As String
    Dim DA, daEdit, daGiro, daNota, daNotaLEdit, daNotaLDEdit, daNotaL, daNotaLD, daCust, daVal, daByr, daDO, daRek As SqlDataAdapter
    Dim builderM, builderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim drPost As SqlDataReader
    Dim param, kodeCari, err As String

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
        callReport(App_Path() & "\report\rptPOJ.rpt", "", "Nomor=" & Trim(txtNomor.Text))
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsEdit = New DataSet
        If Not dsEdit.Tables("NotaLunasEdit") Is Nothing Then dsEdit.Tables("NotaLunasEdit").Clear()
        daEdit = New SqlDataAdapter(New SqlCommand("select a.Kd_Cabang, a.no_trans as 'No. Transaksi', a.tgl_trans as 'Tanggal Transaksi', b.nama as 'Nama Customer', a.jml_rp_trans as 'Jumlah' from FIN.dbo.FIN_NOTA_LUNAS a, FIN.dbo.v_kartu b where a.kd_kartu=b.kode AND a.tipe_trans IN ('JKM-KPT-01','JKM-KPT-05')", sqlconn)) '<- query buat ditampilkan di LOV
        daEdit.Fill(dsEdit, "NotaLunasEdit")
        frmCari.set_dso(dsEdit.Tables("NotaLunasEdit"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kodeCari = frmCari.row("No. Transaksi").ToString
            cabang = frmCari.row("Kd_cabang").ToString
            If Not dsEdit.Tables("NotaLunasCari") Is Nothing Then dsEdit.Tables("NotaLunasCari").Clear()
            If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then dsEdit.Tables("NotaLunasCari").Clear()
            daNotaLEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans  = '" & kodeCari & "'", sqlconn))
            daNotaLEdit.Fill(dsEdit, "NotaLunasCari")
            daNotaLDEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans = '" & kodeCari & "'", sqlconn))
            daNotaLDEdit.Fill(dsEdit, "NotaLunasDCari")
            GC.DataSource = dsEdit.Tables("NotaLunasDCari")
            txtNomor.EditValue = kodeCari
            txtNoRef.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("no_ref1")
            LEValuta.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("kd_valuta")
            txtkurs.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("kurs_valuta")
            dtTanggal.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("tgl_trans")
            txtKeterangan.Text = dsEdit.Tables("NotaLunasCari").Rows(0).Item("keterangan")
            lookcust.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("kd_kartu")
            lookbayar.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("jns_bayar")
            Lookgiro.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("no_giro")
            lookDO.EditValue = dsEdit.Tables("NotaLunasCari").Rows(0).Item("jns_giro_trans")
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

    Sub View_Valuta()
        If Not dsNotaLunas.Tables("View_Valuta") Is Nothing Then dsNotaLunas.Tables("View_Valuta").Clear()
        daVal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        daVal.Fill(dsNotaLunas, "View_Valuta")
        LEValuta.Properties.DataSource = dsNotaLunas.Tables("View_Valuta")
        LEValuta.Properties.ValueMember = "Kode_Valuta"
        LEValuta.Properties.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub v_nota()
        'EDITED BY RENDY
        If Not dsNotaLunas.Tables("vnota") Is Nothing Then dsNotaLunas.Tables("vnota").Clear()
        'ds2.Clear()

        daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_Nota where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans in ('JPJ-KPT-01','JPJ-KPT-02') and jml_akhir>0", sqlconn))
        daNota.Fill(dsNotaLunas, "vnota")
        repBrg.DataSource = dsNotaLunas.Tables("vnota")
        repBrg.ValueMember = "no_inv"
        'no_inv, tgl_inv, jml_val_trans, jml_val_ppn, jml_val_trans+jml_val_ppn as jml_tagihan, tgl_jth_tempo
    End Sub

    Private Sub V_Customer()
        If Not dsNotaLunas.Tables("View_Customer") Is Nothing Then dsNotaLunas.Tables("View_Customer").Clear()
        daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer, Nama_Customer, Alamat1 from sif.dbo.SIF_Customer", sqlconn))
        daCust.Fill(dsNotaLunas, "View_Customer")
        lookcust.Properties.DataSource = dsNotaLunas.Tables("View_Customer")
        lookcust.Properties.ValueMember = "Kd_Customer"
        lookcust.Properties.DisplayMember = "Nama_Customer"
    End Sub

    Private Sub V_pembayaran()
        If Not dsNotaLunas.Tables("View_bayar") Is Nothing Then dsNotaLunas.Tables("View_bayar").Clear()
        daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data,Desc_Data from sif.dbo.SIF_Gen_Reff_D where Id_Ref_data='JNSBYR'", sqlconn))
        daByr.Fill(dsNotaLunas, "View_bayar")
        lookbayar.Properties.DataSource = dsNotaLunas.Tables("View_bayar")
        lookbayar.Properties.ValueMember = "Id_Data"
        lookbayar.Properties.DisplayMember = "Desc_Data"
    End Sub

    Private Sub V_DO()
        If Not dsNotaLunas.Tables("View_DO") Is Nothing Then dsNotaLunas.Tables("View_DO").Clear()
        daDO = New SqlDataAdapter(New SqlCommand("select tipe_trans, attribut1 from SIF.dbo.SIF_TIPE_TRANS WHERE tipe_trans='JRR-KPT-10' OR tipe_trans='JRR-KPT-13'", sqlconn))
        daDO.Fill(dsNotaLunas, "View_DO")
        lookDO.Properties.DataSource = dsNotaLunas.Tables("View_DO")
        lookDO.Properties.ValueMember = "tipe_trans"
        lookDO.Properties.DisplayMember = "attribut1"
    End Sub

    Private Sub V_Rek()
        If Not dsNotaLunas.Tables("View_Rek") Is Nothing Then dsNotaLunas.Tables("View_Rek").Clear()
        daRek = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar WHERE kd_buku_besar LIKE '6-%' AND grup_header = 'D'", sqlconn))
        daRek.Fill(dsNotaLunas, "View_Rek")
        lookRek.DataSource = dsNotaLunas.Tables("View_Rek")
        lookRek.ValueMember = "kd_buku_besar"
        lookRek.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub V_giro()
        If Not dsNotaLunas.Tables("View_giro") Is Nothing Then dsNotaLunas.Tables("View_giro").Clear()
        If lookcust.EditValue = vbNullString Then
            Lookgiro.Enabled = False
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where jns_giro='" & lookbayar.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='" & lookDO.EditValue & "' and status='CLEARING' and nomor not in (select no_giro from FIN.dbo.FIN_NOTA_LUNAS)", sqlconn))
        Else
            Lookgiro.Enabled = True
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kartu='" & lookcust.EditValue.ToString & "' and jns_giro='" & lookbayar.EditValue.ToString & "' and kd_valuta='" & LEValuta.EditValue.ToString & "' and jns_trans='JUAL' and tipe_trans='" & lookDO.EditValue & "' and status='CLEARING' and nomor not in (select distinct isnull(no_giro,'kosong') from FIN.dbo.FIN_NOTA_LUNAS)", sqlconn))
        End If

        daGiro.Fill(dsNotaLunas, "View_giro")
        Lookgiro.Properties.DataSource = dsNotaLunas.Tables("View_giro")
        Lookgiro.Properties.ValueMember = "nomor"
        Lookgiro.Properties.DisplayMember = "nomor"
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Private Sub bersih()
        lookcust.EditValue = vbNullString
        lookbayar.EditValue = "01"
        Lookgiro.EditValue = vbNullString
        LEValuta.EditValue = "IDR"
        txtkurs.EditValue = "1"
        txtkurs.Enabled = False
        txtKeterangan.Text = ""
        txtNoRef.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        txtJmlGiro.EditValue = 0
        If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then dsEdit.Tables("NotaLunasDCari").Clear()
        If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If lookcust.EditValue = vbNullString Then
            MsgBox("Customer belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            lookcust.Focus()
            Exit Sub
        End If
        If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
            If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
                MsgBox("Tidak ada nota giro/cek untuk Customer ini." & vbCrLf & "Mohon ganti jenis pembayarannya.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                lookbayar.Focus()
                Exit Sub
            End If
        End If
        If Not txtJmlGiro.Text = "" Or txtJmlGiro.Text = "0,00" Then
            If Not GV.Columns("jml_bayar").SummaryText.Equals(txtJmlGiro.Text) Then
                MsgBox("Jumlah Sub Total tidak sama dari jumlah Giro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                Exit Sub
            End If
        End If
        For Each rx As DataRow In dsNotaLunas.Tables("NotaLunas").Rows
            'If GV.GetRowCellValue(i, "prev_no_inv") Is Nothing Then
            '    MsgBox("Ada nota yang kosong pada detil pembayaran. Mohon dihapus terlebih dahulu", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            '    Exit Sub
            'End If
            If rw.Item("prev_no_inv") = vbNullString Then
                MsgBox("Ada nota yang kosong pada detil pembayaran. Mohon dihapus terlebih dahulu", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                Exit Sub
            End If
        Next

        If Not isDelete Then
            If STATE = "ADD" Then
                kode = getNoTrans("JKM", getTanggal)
                txtNomor.EditValue = kode
                row = dsNotaLunas.Tables("NotaLunas").NewRow
                row.Item("no_trans") = txtNomor.EditValue
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    If lookDO.EditValue = "JRR-KPT-10" Then
                        row.Item("tipe_trans") = "JKM-KPT-01"
                    Else
                        row.Item("tipe_trans") = "JKM-KPT-05"
                    End If
                Else
                    row.Item("tipe_trans") = "JKM-KPT-06"
                End If
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("no_ref1") = txtNoRef.Text
                row.Item("kd_kartu") = lookcust.EditValue
                row.Item("kd_valuta") = LEValuta.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("kurs_valuta") = txtkurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
                row.Item("jns_bayar") = lookbayar.EditValue
                row.Item("jns_giro_trans") = lookDO.EditValue
                row.Item("no_giro") = Lookgiro.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("thnbln") = dtTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtTanggal.EditValue, DateFormat.GeneralDate), 4, 2)
                dsNotaLunas.Tables("NotaLunas").Rows.Add(row)

            ElseIf STATE = "EDIT" Then
                row = dsEdit.Tables("NotaLunasCari").Rows(0)
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    If lookDO.EditValue = "JRR-KPT-10" Then
                        row.Item("tipe_trans") = "JKM-KPT-01"
                    Else
                        row.Item("tipe_trans") = "JKM-KPT-05"
                    End If
                Else
                    row.Item("tipe_trans") = "JKM-KPT-06"
                End If
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("no_ref1") = txtNoRef.Text
                row.Item("kd_kartu") = lookcust.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("kd_valuta") = LEValuta.EditValue
                row.Item("kurs_valuta") = txtkurs.EditValue
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
                row.Item("jns_bayar") = lookbayar.EditValue
                row.Item("no_giro") = Lookgiro.EditValue
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
                            rows.Item("kd_kartu") = lookcust.EditValue
                            If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                                If lookDO.EditValue = "JRR-KPT-10" Then
                                    rows.Item("tipe_trans") = "JKM-KPT-01"
                                Else
                                    rows.Item("tipe_trans") = "JKM-KPT-05"
                                End If
                            Else
                                rows.Item("tipe_trans") = "JKM-KPT-06"
                            End If
                        ElseIf rows.RowState = DataRowState.Modified Then
                            rows.Item("Last_Update_Date") = Now
                            rows.Item("Last_Updated_By") = username
                            rows.Item("Programe_name") = Me.Name
                        ElseIf Not rows.RowState = DataRowState.Deleted Then
                            If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                                If lookDO.EditValue = "JRR-KPT-10" Then
                                    rows.Item("tipe_trans") = "JKM-KPT-01"
                                Else
                                    rows.Item("tipe_trans") = "JKM-KPT-05"
                                End If
                            Else
                                rows.Item("tipe_trans") = "JKM-KPT-06"
                            End If
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
                            rows.Item("kd_kartu") = lookcust.EditValue
                            If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                                If lookDO.EditValue = "JRR-KPT-10" Then
                                    rows.Item("tipe_trans") = "JKM-KPT-01"
                                Else
                                    rows.Item("tipe_trans") = "JKM-KPT-05"
                                End If
                            Else
                                rows.Item("tipe_trans") = "JKM-KPT-06"
                            End If
                        ElseIf rows.RowState = DataRowState.Modified Then
                            rows.Item("Last_Update_Date") = Now
                            rows.Item("Last_Updated_By") = username
                            rows.Item("Programe_name") = Me.Name
                        ElseIf Not rows.RowState = DataRowState.Deleted Then
                            If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                                If lookDO.EditValue = "JRR-KPT-10" Then
                                    rows.Item("tipe_trans") = "JKM-KPT-01"
                                Else
                                    rows.Item("tipe_trans") = "JKM-KPT-05"
                                End If
                            Else
                                rows.Item("tipe_trans") = "JKM-KPT-06"
                            End If
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

                    If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                        If lookDO.EditValue = "JRR-KPT-10" Then
                            call_procedure("JKM-KPT-01", kode, BTRANS)
                        Else
                            call_procedure("JKM-KPT-05", kode, BTRANS)
                        End If
                    Else
                        call_procedure("JKM-KPT-06", kode, BTRANS)
                    End If

                    BTRANS.Commit()
                    showMessages("Berhasil disimpan..")
                    STATE = "EDIT"
                    kodeCari = kode
                    If Not dsEdit.Tables("NotaLunasCari") Is Nothing Then dsEdit.Tables("NotaLunasCari").Clear()
                    If Not dsEdit.Tables("NotaLunasDCari") Is Nothing Then dsEdit.Tables("NotaLunasDCari").Clear()
                    daNotaLEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans='" & kode & "'", sqlconn))
                    daNotaLEdit.Fill(dsEdit, "NotaLunasCari")
                    daNotaLDEdit = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans='" & kode & "'", sqlconn))
                    daNotaLDEdit.Fill(dsEdit, "NotaLunasDCari")
                    GC.DataSource = dsEdit.Tables("NotaLunasDCari")
                    GC.RefreshDataSource()
                    btnDelete = True
                    setStatus()
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

                        If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                            If lookDO.EditValue = "JRR-KPT-10" Then
                                call_procedure("JKM-KPT-01", kode, BTRANS)
                            Else
                                call_procedure("JKM-KPT-05", kode, BTRANS)
                            End If
                        Else
                            call_procedure("JKM-KPT-06", kode, BTRANS)
                        End If

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

                call_procedure_del(tampung, BTRANS)

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
        Lookgiro.Enabled = True
        MsgBox("OK")
    End Sub

    Public Sub reload_table(ByVal kode As String)
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
            txtNomor.Text = row.Item("no_trans").ToString
            txtNoRef.Text = row.Item("no_ref1").ToString
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            dtTanggal.EditValue = row.Item("tgl_trans").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            lookcust.EditValue = row.Item("kd_supplier").ToString
            lookDO.EditValue = row.Item("jns_giro_trans").ToString
            'txtSubTotal.EditValue = row.Item("jml_val_trans")
        End If
    End Sub

    Private Sub formLunasPiutangUsaha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        View_Valuta()
        V_Customer()
        V_pembayaran()
        V_DO()
        V_Rek()
        lookbayar.EditValue = "03"
        dtTanggal.EditValue = getTanggal()
        LEValuta.EditValue = "IDR"
        lookDO.EditValue = "JRR-KPT-10"
        txtkurs.Enabled = False
        txtkurs.Text = "1"
        If txtNomor.Text = "" Then
            reload_table("xxx")
        End If
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Enabled = False
            txtkurs.Text = "1"
        Else
            txtkurs.Enabled = True
            txtkurs.Focus()
        End If
        V_giro()
        v_nota()
        If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
            Lookgiro.EditValue = vbNullString
            txtJmlGiro.EditValue = vbNullString
            lookbayar.EditValue = "03"
        End If
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
                tampung = dsEdit.Tables("NotaLunasCari").Rows(0).Item("no_jurnal")
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
            param = ""
            statex = "XXX"
            view.SetRowCellValue(e.RowHandle, "jml_tagihan", dsEdit.Tables("LoadNota").Rows(0).Item("jml_akhir"))
            view.SetRowCellValue(e.RowHandle, "jml_piut", "0")
            view.SetRowCellValue(e.RowHandle, "jml_biaya1", "0")
            view.SetRowCellValue(e.RowHandle, "jml_pembulatan", "0")
            view.SetRowCellValue(e.RowHandle, "jml_bayar", view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "jml_biaya1") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan"))
            view.SetRowCellValue(e.RowHandle, "kd_buku_besar", dsEdit.Tables("LoadNota").Rows(0).Item("kd_buku_besar"))
            param = "OK"
            statex = ""
        End If

        If STATE = "EDIT" Then
            If statex = "XXX" Then
                param = ""
            Else
                param = "OK"
            End If
        End If

        If param = "OK" Or param = "UBAH" Then
            If e.Column Is jml_piut Then
                view.SetRowCellValue(e.RowHandle, "jml_bayar", view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "jml_biaya1") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan"))
            End If

            If e.Column Is jml_biaya1 Then
                view.SetRowCellValue(e.RowHandle, "jml_bayar", view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "jml_biaya1") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan"))
            End If

            If e.Column Is jml_pembulatan Then
                view.SetRowCellValue(e.RowHandle, "jml_bayar", view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "jml_biaya1") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan"))
            End If
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
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
    
    Private Sub lookcust_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookcust.EditValueChanged
        'lookbayar.EditValue = System.DBNull.Value
        'Lookgiro.EditValue = System.DBNull.Value
        v_nota()
        V_pembayaran()
        V_giro()
        If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
            Lookgiro.EditValue = vbNullString
            txtJmlGiro.EditValue = vbNullString
            lookbayar.EditValue = "03"
        End If
    End Sub

    Private Sub lookbayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookbayar.EditValueChanged
        'Lookgiro.EditValue = System.DBNull.Value
        'ds1.Clear()
        V_giro()
        If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
            Lookgiro.EditValue = vbNullString
            txtJmlGiro.EditValue = vbNullString
        End If
    End Sub

    Private Sub Lookgiro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookgiro.EditValueChanged
        drPost = New SqlCommand("SELECT jml_trans FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & Lookgiro.EditValue & "'", sqlconn).ExecuteReader
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
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub call_procedure_del(ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_DELJUR_GIRO"

        sqlCmd.Parameters.Add("@nogiro", SqlDbType.Char).Value = noG
        sqlCmd.Parameters.Add("@tipe", SqlDbType.Char).Value = "X"
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim column1 As GridColumn = view.Columns("jml_tagihan")
            Dim column2 As GridColumn = view.Columns("jml_bayar")
            Dim column3 As GridColumn = view.Columns("jml_piut")
            Dim column4 As GridColumn = view.Columns("jml_biaya1")
            Dim column5 As GridColumn = view.Columns("jml_pembulatan")
            Dim column6 As GridColumn = view.Columns("keterangan")
            If view.GetRowCellValue(e.RowHandle, column2) > view.GetRowCellValue(e.RowHandle, column1) Then
                e.Valid = False
                'Set errors with specific descriptions for the columns
                If view.FocusedColumn.FieldName = "jml_piut" Then
                    view.SetColumnError(column3, "Penambahan jumlah lunas terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                End If
                If view.FocusedColumn.FieldName = "jml_biaya1" Then
                    view.SetColumnError(column4, "Penambahan jumlah biaya terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                End If
                If view.FocusedColumn.FieldName = "jml_pembulatan" Then
                    view.SetColumnError(column5, "Penambahan jumlah pembulatan terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                End If
                If view.FocusedColumn.FieldName = "keterangan" Then
                    view.SetColumnError(column2, "Jumlah bayar melebihi jumlah tagihan.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "prev_no_inv" Then
            If Not GV.RowCount <= 0 Then
                Dim noInv As String = e.Value
                For i As Integer = 0 To GV.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If noInv = vx.GetRowCellValue(i, prev_no_inv) Then
                        e.Valid = False
                        e.ErrorText = "Nota sudah ada, mohon pilih nota yang lain."
                    End If
                Next
            End If
        End If


    End Sub

    Private Sub lookDO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookDO.EditValueChanged
        V_giro()
        If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
            Lookgiro.EditValue = vbNullString
            txtJmlGiro.EditValue = vbNullString
        End If
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

    Private Sub txtPemb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPemb.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub repBrg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repBrg.QueryPopUp
        v_nota()
    End Sub
End Class