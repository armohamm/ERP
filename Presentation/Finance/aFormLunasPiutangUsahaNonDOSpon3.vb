'tgl 19/06/2015
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class aFormLunasPiutangUsahaNonDOSpon3
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dsNotaLunas, dsEdit, dsLookUp As New DataSet
    Public STATE, statex As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim rw, row As DataRow
    Dim kode, tampung, cabang, kodehapus As String
    Dim DA, daEdit, daGiro, daNota, daNotaLEdit, daNotaLDEdit, daNotaLDPEdit, daNotaL, daNotaLD, daNotaLDP, daCust, daVal, daByr, daDO, daRek As SqlDataAdapter
    Dim builderM, builderD, builderDD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim drPost As SqlDataReader
    Dim param, kodeCari, err As String
    Dim rhandel As Integer
    Dim rl, r2 As DataRelation

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
        disableAll(pnl, True)
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
        reload_table("xxx")
    End Sub

    Public Sub cetak_click()
        If Not txtNomor.Text = vbNullString Or txtNomor.Text = "" Then
            callReport(App_Path() & "\report\repNotaLunasCustomer.rpt", "", "&nomor=" & txtNomor.Text)
        Else
            MsgBox("Tidak ada data untuk dicetak. Mohon isi dan simpan data baru atau buka kembali data yang sudah disimpan.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        'dsEdit = New DataSet
        If Not dsEdit.Tables("NotaLunasEdit") Is Nothing Then dsEdit.Tables("NotaLunasEdit").Clear()
        daEdit = New SqlDataAdapter(New SqlCommand("select a.no_trans as 'No. Transaksi', a.tgl_trans as 'Tanggal Transaksi', b.nama as 'Nama Customer', a.jml_rp_trans as 'Jumlah', CASE WHEN (c.Desc_Data = 'Giro' OR c.Desc_Data = 'Cek') THEN c.Desc_Data + ' : ' + SUBSTRING(a.no_giro,1,6) ELSE CASE WHEN c.Desc_Data = 'Transfer' THEN c.Desc_Data + ' : ' + (SELECT x.nama_bank FROM SIF.dbo.SIF_Bank x, FIN.dbo.FIN_NOTA_LUNAS y WHERE x.kd_bank = y.kd_bank AND y.no_trans = a.no_trans) ELSE c.Desc_Data END END as 'Pembayaran', a.no_posting from FIN.dbo.FIN_NOTA_LUNAS a, FIN.dbo.v_kartu b, sif.dbo.SIF_Gen_Reff_D c where a.kd_kartu=b.kode and a.Jns_bayar = c.Id_Data AND (a.tipe_trans = 'JKM-KPT-06' OR tipe_trans = 'JKM-KPT-01') AND (a.Program_name = 'aFormLunasPiutangUsahaNonDOSpon' OR a.Program_name = 'aFormLunasPiutangUsahaNonDOSpon1' OR a.Program_name = 'aFormLunasPiutangUsahaNonDOSpon2' OR a.Program_name = 'aFormLunasPiutangUsahaNonDOSpon3') AND c.Id_Ref_data='JNSBYR' order by a.tgl_trans DESC", sqlconn)) '<- query buat ditampilkan di LOV
        daEdit.Fill(dsEdit, "NotaLunasEdit")
        frmCari.set_dso(dsEdit.Tables("NotaLunasEdit"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.GV.Columns("no_posting").Visible = False
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("No. Transaksi").ToString
            reload_table(kode)
            If TypeOf frmCari.row("no_posting") Is DBNull Or frmCari.row("no_posting") Is Nothing Then
                'cabang = frmCari.row("Kd_cabang").ToString
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                setStatus()
            Else
                disableAll(pnl, False)
                MsgBox("Transaksi sudah diposting,data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN")

                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                setStatus()
            End If
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        'disableAll(Panel43, True)
        setStatus()
        Me.Enabled = False
        bersih()
    End Sub

    Private Sub disableAll(ByVal pnlname As Panel, ByVal active As Boolean)
        For Each ctrl As Control In pnlname.Controls
            If TypeOf (ctrl) Is Panel Then
                disableAll(ctrl, active)
            Else
                If Not TypeOf (ctrl) Is Label Then
                    ctrl.Enabled = active
                End If
            End If
        Next
    End Sub

    Sub View_Valuta()
        If Not dsLookUp.Tables("View_Valuta") Is Nothing Then dsLookUp.Tables("View_Valuta").Clear()
        daVal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        daVal.Fill(dsLookUp, "View_Valuta")
        LEValuta.Properties.DataSource = dsLookUp.Tables("View_Valuta")
        LEValuta.Properties.ValueMember = "Kode_Valuta"
        LEValuta.Properties.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub v_nota()
        'EDITED BY RENDY
        If Not dsLookUp.Tables("vnota") Is Nothing Then dsLookUp.Tables("vnota").Clear()
        'ds2.Clear()
        If STATE = "ADD" Then
            daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, b.Desc_Data, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where jml_akhir > 0 and MONTH(tgl_inv) = MONTH(a.tgl_inv) and kd_cust = a.kd_cust and kd_valuta = a.kd_valuta and tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and not (len(no_posting)=0 or no_posting is null or no_posting='')) as jmltagihan from FIN.dbo.FIN_Nota a, sif.dbo.sif_gen_reff_d b where a.jns_inv = b.Id_Data and a.kd_cust = '" & lookcust.EditValue & "' and a.kd_valuta = '" & LEValuta.EditValue & "' and a.tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and a.jml_akhir > 0 and not (len(a.no_posting)=0 or a.no_posting is null or a.no_posting='') and b.Id_Ref_FIle = 'JNSINV'", sqlconn))
        Else
            daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, b.Desc_Data, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where jml_akhir > 0 and MONTH(tgl_inv) = MONTH(a.tgl_inv) and kd_cust = a.kd_cust and kd_valuta = a.kd_valuta and tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and not (len(no_posting)=0 or no_posting is null or no_posting='')) as jmltagihan from FIN.dbo.FIN_Nota a, sif.dbo.sif_gen_reff_d b where a.jns_inv = b.Id_Data and a.kd_cust = '" & lookcust.EditValue & "' and a.kd_valuta = '" & LEValuta.EditValue & "' and a.tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and not (len(a.no_posting)=0 or a.no_posting is null or a.no_posting='') and b.Id_Ref_FIle = 'JNSINV'", sqlconn))
        End If
        daNota.Fill(dsLookUp, "vnota")
        repBrg.DataSource = dsLookUp.Tables("vnota")
        repBrg.ValueMember = "no_inv"
        repBrg.DisplayMember = "no_inv"
        'no_inv, tgl_inv, jml_val_trans, jml_val_ppn, jml_val_trans+jml_val_ppn as jml_tagihan, tgl_jth_tempo
    End Sub

    Private Sub V_Customer()
        If Not dsLookUp.Tables("View_Customer") Is Nothing Then dsLookUp.Tables("View_Customer").Clear()
        'daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.* from(select Kd_Customer as kode, Nama_Customer as nama, Alamat1 as alamat from sif.dbo.SIF_Customer UNION ALL select Kode_Pegawai as kode, Nama_Pegawai as nama, Alamat_1 as alamat from sif.dbo.SIF_Pegawai) a ORDER BY a.nama", sqlconn))
        daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.* from(select distinct a.kd_cust as kode, b.Nama_Customer as nama, b.Alamat1 as alamat from FIN.dbo.FIN_NOTA a, SIF.dbo.SIF_Customer b where a.kd_cust = b.Kd_Customer and b.Rec_stat = 'Y' UNION ALL select distinct a.kd_cust as kode, b.Nama_Pegawai as nama, b.Alamat_1 as alamat from FIN.dbo.FIN_NOTA a, SIF.dbo.SIF_Pegawai b where a.kd_cust = b.Kode_Pegawai) a ORDER BY a.nama", sqlconn))
        daCust.Fill(dsLookUp, "View_Customer")
        lookcust.Properties.DataSource = dsLookUp.Tables("View_Customer")
        lookcust.Properties.ValueMember = "kode"
        lookcust.Properties.DisplayMember = "nama"
    End Sub

    Private Sub V_pembayaran()
        'MsgBox("vpembayaran")
        If Not dsLookUp.Tables("View_bayar") Is Nothing Then dsLookUp.Tables("View_bayar").Clear()
        daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data,Desc_Data from sif.dbo.SIF_Gen_Reff_D where Id_Ref_data='JNSBYR'", sqlconn))
        daByr.Fill(dsLookUp, "View_bayar")
        lookbayar.Properties.DataSource = dsLookUp.Tables("View_bayar")
        lookbayar.Properties.ValueMember = "Id_Data"
        lookbayar.Properties.DisplayMember = "Desc_Data"
    End Sub

    Private Sub V_Rek()
        'MsgBox("vrek")
        If Not dsLookUp.Tables("View_Rek") Is Nothing Then dsLookUp.Tables("View_Rek").Clear()
        daRek = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar WHERE kd_buku_besar LIKE '4%' AND grup_header = 'D' UNION SELECT '0000000', 'N/A'", sqlconn))
        daRek.Fill(dsLookUp, "View_Rek")
        lookRek.DataSource = dsLookUp.Tables("View_Rek")
        lookRek.ValueMember = "kd_buku_besar"
        lookRek.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub V_Bank()
        'MsgBox("vbank")
        If Not dsLookUp.Tables("View_Bank") Is Nothing Then dsLookUp.Tables("View_Bank").Clear()
        daRek = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank from SIF.dbo.SIF_Bank", sqlconn))
        daRek.Fill(dsLookUp, "View_Bank")
        lookBank.Properties.DataSource = dsLookUp.Tables("View_Bank")
        lookBank.Properties.ValueMember = "kd_bank"
        lookBank.Properties.DisplayMember = "nama_bank"
    End Sub

    Private Sub V_giro()
        'MsgBox("vgiro")
        If Not dsLookUp.Tables("View_giro") Is Nothing Then dsLookUp.Tables("View_giro").Clear()
        If lookcust.EditValue = vbNullString Or STATE = "EDIT" Then
            Lookgiro.Enabled = False
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select idrec, nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO -- where jns_giro='" & lookbayar.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-10' and status='CLEARING' AND NOT (no_jur IS NULL OR no_jur = '')", sqlconn))
        Else
            Lookgiro.Enabled = True
            daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select idrec, nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where divisi = '3' and kartu='" & lookcust.EditValue.ToString & "' and jns_giro='" & lookbayar.EditValue.ToString & "' and kd_valuta='" & LEValuta.EditValue.ToString & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-10' and status IN ('CAIR','CLEARING') and not idrec in (select isnull(no_giro,'') from FIN.dbo.FIN_NOTA_LUNAS where kd_kartu = '" & lookcust.EditValue.ToString & "')", sqlconn))
        End If

        daGiro.Fill(dsLookUp, "View_giro")
        Lookgiro.Properties.DataSource = dsLookUp.Tables("View_giro")
        Lookgiro.Properties.ValueMember = "idrec"
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
        If Not dsNotaLunas.Tables("NotaLunasDPot") Is Nothing Then dsNotaLunas.Tables("NotaLunasDPot").Clear()
        If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
        If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then dsNotaLunas.Tables("NotaLunas").Clear()

        dsNotaLunas = New DataSet
        lookcust.EditValue = vbNullString
        lookbayar.EditValue = "03"
        Lookgiro.EditValue = vbNullString
        LEValuta.EditValue = "IDR"
        txtkurs.EditValue = "1"
        txtkurs.Enabled = False
        txtKeterangan.Text = ""
        txtNoRef.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        txtJmlGiro.EditValue = 0
        txtSelisih.EditValue = 0
        txtJmlSub.EditValue = 0
        'lblSelisih.Text = ""
        txtPembayaran.EditValue = 0
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If lookcust.EditValue = vbNullString Then
            MsgBox("Customer belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            lookcust.Focus()
            Exit Sub
        End If
        If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
            If dsLookUp.Tables("View_giro").Rows.Count <= 0 Then
                MsgBox("Tidak ada nota giro/cek untuk Customer ini." & vbCrLf & "Mohon ganti jenis pembayarannya.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                lookbayar.Focus()
                Exit Sub
            End If
        End If
        If Not isDelete Then
            If Not txtJmlSub.EditValue = txtPembayaran.EditValue Then
                MsgBox("Jumlah Sub Total tidak sama dengan jumlah pembayaran.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                Exit Sub
            End If
            If Not txtJmlGiro.EditValue = 0 Then
                If Not txtJmlSub.EditValue = txtJmlGiro.EditValue Then
                    MsgBox("Jumlah Sub Total tidak sama dari jumlah Giro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    Exit Sub
                End If
            End If
            Dim itung As Integer = dsNotaLunas.Tables("NotaLunasD").Rows.Count
            Dim jml As Integer = 0
            For Each rw As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
                If TypeOf rw.Item("cek") Is DBNull Then
                    jml += 1
                End If
            Next
            If jml = itung Then
                MsgBox("Detil pelunasan masih belum dicentang.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                Exit Sub
            End If
        End If

        If Not isDelete Then

            If STATE = "ADD" Then
                row = dsNotaLunas.Tables("NotaLunas").NewRow
                txtNomor.EditValue = getNoTrans("JKM", dtTanggal.EditValue, BTRANS)
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("jns_giro_trans") = IIf(Lookgiro.EditValue = vbNullString, "", "JRR-KPT-10")
                row.Item("Program_Name") = Me.Name
            ElseIf STATE = "EDIT" Then
                row = dsNotaLunas.Tables("NotaLunas").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

            If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                row.Item("tipe_trans") = "JKM-KPT-01"
            Else
                row.Item("tipe_trans") = "JKM-KPT-06"
            End If
            row.Item("tgl_trans") = dtTanggal.EditValue
            row.Item("no_ref1") = txtNoRef.Text
            row.Item("kd_kartu") = lookcust.EditValue
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("kd_bank") = IIf(lookBank.EditValue = vbNullString, 0, lookBank.EditValue)
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.EditValue
            row.Item("jns_bayar") = lookbayar.EditValue
            row.Item("no_giro") = Lookgiro.EditValue
            row.Item("thnbln") = dtTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtTanggal.EditValue, DateFormat.GeneralDate), 4, 2)

            For Each item As DataRow In dsNotaLunas.Tables("NotaLunasD").Select("isnull(cek,'T')<>'Y'")
                If Not item.RowState = DataRowState.Deleted Then item.Delete()
            Next

            'refreshNomer(GV)

            row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
            row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText

            If STATE = "ADD" Then
                dsNotaLunas.Tables("NotaLunas").Rows.Add(row)
            End If

            For Each rows As DataRow In dsNotaLunas.Tables("NotaLunasD").Select("cek='Y'")
                rows.Item("Kd_Cabang") = getKodeCabang()
                rows.Item("Programe_name") = Me.Name
                rows.Item("kd_kartu") = lookcust.EditValue
                rows.Item("no_trans") = txtNomor.EditValue
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    rows.Item("tipe_trans") = "JKM-KPT-01"
                Else
                    rows.Item("tipe_trans") = "JKM-KPT-06"
                End If
                rows.Item("Last_create_date") = Now
                rows.Item("Last_created_by") = username
            Next

            For Each rowx As DataRow In dsNotaLunas.Tables("NotaLunasDPot").Rows
                If rowx.RowState = DataRowState.Added Then
                    rowx.Item("Last_create_date") = Now
                    rowx.Item("Last_created_by") = username
                    rowx.Item("Kd_Cabang") = getKodeCabang()
                    rowx.Item("no_trans") = txtNomor.EditValue
                    rowx.Item("Programe_name") = Me.Name
                    If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                        rowx.Item("tipe_trans") = "JKM-KPT-01"
                    Else
                        rowx.Item("tipe_trans") = "JKM-KPT-06"
                    End If
                ElseIf rowx.RowState = DataRowState.Modified Then
                    rowx.Item("Last_Update_Date") = Now
                    rowx.Item("Last_Updated_By") = username
                End If
            Next
        End If

        Try

            If isDelete Then
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & kodehapus & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & kodehapus & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
            End If

            builderM = New SqlCommandBuilder(daNotaL)
            daNotaL.UpdateCommand = builderM.GetUpdateCommand()
            daNotaL.InsertCommand = builderM.GetInsertCommand()
            daNotaL.DeleteCommand = builderM.GetDeleteCommand()

            builderD = New SqlCommandBuilder(daNotaLD)
            daNotaLD.UpdateCommand = builderD.GetUpdateCommand()
            daNotaLD.InsertCommand = builderD.GetInsertCommand()
            daNotaLD.DeleteCommand = builderD.GetDeleteCommand()

            If Not GVDetil.RowCount < 0 Then
                builderDD = New SqlCommandBuilder(daNotaLDP)
                daNotaLDP.UpdateCommand = builderDD.GetUpdateCommand()
                daNotaLDP.InsertCommand = builderDD.GetInsertCommand()
                daNotaLDP.DeleteCommand = builderDD.GetDeleteCommand()
            End If

            BTRANS = sqlconn.BeginTransaction("1")

            daNotaL.UpdateCommand.Transaction = BTRANS
            daNotaL.InsertCommand.Transaction = BTRANS
            daNotaL.DeleteCommand.Transaction = BTRANS

            daNotaLD.UpdateCommand.Transaction = BTRANS
            daNotaLD.InsertCommand.Transaction = BTRANS
            daNotaLD.DeleteCommand.Transaction = BTRANS

            daNotaLDP.UpdateCommand.Transaction = BTRANS
            daNotaLDP.InsertCommand.Transaction = BTRANS
            daNotaLDP.DeleteCommand.Transaction = BTRANS

            daNotaL.Update(dsNotaLunas.Tables("NotaLunas"))
            daNotaLD.Update(dsNotaLunas.Tables("NotaLunasD"))
            daNotaLDP.Update(dsNotaLunas.Tables("NotaLunasDPot"))

            dsNotaLunas.Tables("NotaLunas").AcceptChanges()
            dsNotaLunas.Tables("NotaLunasD").AcceptChanges()
            dsNotaLunas.Tables("NotaLunasDPot").AcceptChanges()

            If Not isDelete Then
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    call_procedure("JKM-KPT-01", txtNomor.EditValue, BTRANS)
                Else
                    call_procedure("JKM-KPT-06", txtNomor.EditValue, BTRANS)
                End If
            End If

            BTRANS.Commit()

            If STATE = "DELETE" Then
                showMessages("Berhasil dihapus.")
                cancel_click()
            Else
                showMessages("Berhasil disimpan.")
                btnDelete = False
                setStatus()
                'STATE = "EDIT"
                'kodeCari = kode
                bersih()
                reload_table("xxx")
                If STATE = "EDIT" Then STATE = "ADD"
                'btnDelete = True
                'setStatus()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsNotaLunas.Tables("NotaLunas").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsNotaLunas.Tables("NotaLunasD").RejectChanges()
            dsNotaLunas.Tables("NotaLunasDPot").RejectChanges()
            MsgBox(e.Message)
        End Try
        Lookgiro.Enabled = True
        'MsgBox("OK")
    End Sub

    Private Sub loadDataGrid()
        If STATE = "ADD" Then
            If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
        End If
        If Not (lookcust.EditValue = vbNullString Or STATE = "EDIT") Then
            If Not dsLookUp.Tables("NotaLunasGrid") Is Nothing Then dsLookUp.Tables("NotaLunasGrid").Clear()
            'If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
            'reload_table("xxx")

            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, isnull(a.jml_cashback,0) + isnull(a.jml_pot_nota,0) as jmldiskon, b.Desc_Data, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where jml_akhir > 0 and thnbln = a.thnbln and kd_cust = a.kd_cust and kd_valuta = a.kd_valuta and tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and not (len(no_posting)=0 or no_posting is null or no_posting='')) as jmltagihan, a.jml_tagihan - (select isnull(sum(jml_bayar),0) from fin.dbo.FIN_NOTA_LUNAS_D where prev_no_inv = a.no_inv) jmlsisa from FIN.dbo.FIN_Nota a, sif.dbo.sif_gen_reff_d b where a.jns_inv = b.Id_Data and a.kd_cust = '" & lookcust.EditValue & "' and a.kd_valuta = '" & LEValuta.EditValue & "' and a.tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and a.jml_akhir > 0 and not (len(a.no_posting)=0 or a.no_posting is null or a.no_posting='') and b.Id_Ref_FIle = 'JNSINV' and a.jml_tagihan - (select isnull(sum(jml_bayar),0) from fin.dbo.FIN_NOTA_LUNAS_D where prev_no_inv = a.no_inv) > 0 order by a.tgl_inv desc", sqlconn))
            DA.Fill(dsLookUp, "NotaLunasGrid")
            Dim i As Integer = 1

            For Each rowcok As DataRow In dsLookUp.Tables("NotaLunasGrid").Rows
                Dim rowGrid As DataRow = dsNotaLunas.Tables("NotaLunasD").NewRow
                rowGrid.Item("tgl_inv") = rowcok.Item("tgl_inv")
                rowGrid.Item("jmltagihan") = rowcok.Item("jmltagihan")
                rowGrid.Item("jmldiskon") = rowcok.Item("jmldiskon")
                rowGrid.Item("jmlsisa") = rowcok.Item("jmlsisa")
                rowGrid.Item("jenis") = rowcok.Item("Desc_Data")

                rowGrid.Item("prev_no_inv") = rowcok.Item("no_inv")
                rowGrid.Item("jml_tagihan") = rowcok.Item("jml_akhir") + rowcok.Item("jmldiskon")
                rowGrid.Item("jml_piut") = IIf(rowcok.Item("jmlsisa") = 0, 0, rowcok.Item("jmlsisa"))
                rowGrid.Item("pendp_lain") = 0
                rowGrid.Item("no_seq") = i : i += 1 : rowGrid.Item("jml_biaya1") = 0
                rowGrid.Item("jml_pembulatan") = 0
                rowGrid.Item("jml_bayar") = rowGrid.Item("jml_piut") + rowGrid.Item("jml_biaya1") + rowGrid.Item("jml_pembulatan")
                rowGrid.Item("kd_buku_besar") = rowcok.Item("kd_buku_besar")
                dsNotaLunas.Tables("NotaLunasD").Rows.Add(rowGrid)
                'If STATE = "EDIT" Then
                '    rowGrid.Item("cek") = "Y"
                'End If
            Next
            GV.BestFitColumns()
            GVDetil.BestFitColumns()
            col_jenis.BestFit()
            tot_tagihan.BestFit()
            tgl_inv.BestFit()
            'param = "OK"
        End If
    End Sub

    Public Sub reload_table(ByVal kode As String)
        'If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then dsNotaLunas.Tables("NotaLunas").Clear()
        'If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
        'If Not dsNotaLunas.Tables("NotaLunasDPotongan") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()
        'dsNotaLunas.Relations.Clear()
        dsNotaLunas = New DataSet
        'MsgBox("reload" & kode)
        daNotaL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daNotaL.Fill(dsNotaLunas, "NotaLunas")

        If STATE = "ADD" Then
            daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,CAST('01/01/2014' AS DATE) as tgl_inv, 0.0 as jmlsisa, 0 as jmltagihan, 0 as jmldiskon, '' as jenis, 'T' as cek from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
            daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        ElseIf STATE = "EDIT" Then
            daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, jml_tagihan - (jml_bayar + jml_piut) jmlsisa,(SELECT tgl_inv FROM FIN.dbo.FIN_Nota WHERE no_inv = a.prev_no_inv) as tgl_inv, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where no_inv = a.prev_no_inv) as jmltagihan, (select y.Desc_Data FROM fin.dbo.FIN_NOTA x, sif.dbo.sif_gen_reff_d y WHERE x.jns_inv = y.Id_Data AND x.no_inv = a.prev_no_inv and y.Id_Ref_FIle = 'JNSINV' ) as jenis, 'Y' as cek from FIN.dbo.FIN_NOTA_LUNAS_D a where no_trans= '" & kode & "'", sqlconn))
            daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        End If

        daNotaLDP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D_D where no_trans= '" & kode & "'", sqlconn))
        daNotaLDP.Fill(dsNotaLunas, "NotaLunasDPot")
        'AddHandler ds4.Tables("PODcari").RowDeleted, AddressOf refreshNomer

        Dim colLunasD As DataColumn
        Dim colLunasDP As DataColumn

        ' colLunasD(0) = dsNotaLunas.Tables("NotaLunasD").Columns("no_trans")
        'colLunasD(1) = dsNotaLunas.Tables("NotaLunasD").Columns("prev_no_inv")
        colLunasD = dsNotaLunas.Tables("NotaLunasD").Columns("no_seq")

        ' colLunasDP(0) = dsNotaLunas.Tables("NotaLunasDPot").Columns("no_trans")
        ' colLunasDP(1) = dsNotaLunas.Tables("NotaLunasDPot").Columns("prev_no_inv")
        colLunasDP = dsNotaLunas.Tables("NotaLunasDPot").Columns("no_seq")

        rl = dsNotaLunas.Relations.Add("DetailDetail", colLunasD, colLunasDP)

        GC.DataSource = dsNotaLunas.Tables("NotaLunasD")
        GC.LevelTree.Nodes.Add("DetailDetail", GVDetil)
        GV.BestFitColumns()
        GVDetil.BestFitColumns()

        If STATE = "EDIT" Then
            Dim jumlah As Double
            jumlah = 0
            For Each row As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
                row.Item("cek") = "Y"
                jumlah += row.Item("jml_bayar")
            Next
            txtJmlSub.EditValue = jumlah
            txtPembayaran.EditValue = jumlah
            txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
        End If

        If dsNotaLunas.Tables("NotaLunas").Rows.Count > 0 Then
            row = dsNotaLunas.Tables("NotaLunas").Rows(0)
            txtNomor.Text = row.Item("no_trans")
            txtNoRef.Text = row.Item("no_ref1")
            LEValuta.EditValue = row.Item("kd_valuta")
            txtkurs.EditValue = row.Item("kurs_valuta")
            dtTanggal.EditValue = row.Item("tgl_trans")
            lookbayar.EditValue = row.Item("jns_bayar")
            lookcust.EditValue = row.Item("kd_kartu")
            Lookgiro.EditValue = row.Item("no_giro")
            lookBank.EditValue = row.Item("kd_bank")
            txtKeterangan.Text = row.Item("keterangan")
            'txtSubTotal.EditValue = row.Item("jml_val_trans")
        End If

    End Sub

    Private Sub aFormLunasPiutangUsahaNonDOSpring1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        btnCetak = True
        setStatus()
    End Sub

    Private Sub aFormLunasPiutangUsahaNonDOSpring1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        View_Valuta()
        V_Customer()
        V_pembayaran()
        V_Rek()
        V_Bank()
        lookbayar.EditValue = "03"
        dtTanggal.EditValue = getTanggal()
        LEValuta.EditValue = "IDR"
        txtkurs.Enabled = False
        txtkurs.Text = "1"
        dtTanggal.Properties.MaxValue = Today
        'btnCetak = True
        'setStatus()

        'If txtNomor.Text = "" Then
        '    reload_table("xxx")
        'End If
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Enabled = False
            txtkurs.Text = "1"
        Else
            txtkurs.Enabled = True
            txtkurs.Focus()
        End If
        'V_giro()
        'v_nota()
        loadDataGrid()
        'If dsLookUp.Tables("View_giro").Rows.Count <= 0 Then
        '    Lookgiro.EditValue = vbNullString
        '    txtJmlGiro.EditValue = vbNullString
        '    'lookbayar.EditValue = "03"
        'End If
    End Sub

    Private Sub refreshNomer(ByVal grid As GridView)
        Dim x As Object
        Dim i As Int16
        If grid.RowCount = 0 Then
            Exit Sub
        Else
            If grid Is GV Then
                'For j As Integer = 0 To grid.RowCount - 1
                '    grid.SetRowCellValue(j, "no_seq", i)
                '    i += 1
                'Next
                x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                For i = 0 To GC.FocusedView.RowCount - 1
                    GC.FocusedView.GetRow(i).Item("no_seq") = i + 1
                Next
            ElseIf grid Is GVDetil Then
                'For j As Integer = 0 To grid.RowCount - 1
                '    grid.SetRowCellValue(j, "no_seq_d", i)
                '    i += 1
                'Next
                x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                For i = 0 To GC.FocusedView.RowCount - 1
                    GC.FocusedView.GetRow(i).Item("no_seq_d") = i + 1
                Next
            End If
        End If
    End Sub

    Public Sub delete_click()
        STATE = "DELETE"
        If MsgBox("Hapus Nota dengan nomor " & txtNomor.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
            If Not dsNotaLunas.Tables("NotaLunasDPot") Is Nothing Then
                For Each rw As DataRow In dsNotaLunas.Tables("NotaLunasDPot").Rows
                    rw.Delete()
                Next
            End If
            If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then
                For Each rw As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
                    rw.Delete()
                Next
            End If
            If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then
                For Each rw As DataRow In dsNotaLunas.Tables("NotaLunas").Rows
                    kodehapus = rw.Item("no_trans")
                    rw.Delete()
                Next
            End If
            save_click(True)
            STATE = ""
        End If
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim view As ColumnView = sender
        'MsgBox(view.GetRowCellValue(e.RowHandle, "prev_no_inv").ToString)

        If Not dsNotaLunas.Tables("LoadNota") Is Nothing Then dsNotaLunas.Tables("LoadNota").Clear()
        daNota = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv='" & view.GetFocusedRowCellValue("prev_no_inv") & "'", sqlconn))
        daNota.Fill(dsNotaLunas, "LoadNota")

        'If e.Column Is prev_no_inv Then
        '    param = ""
        '    statex = "XXX"

        '    view.SetFocusedRowCellValue("jml_tagihan", dsNotaLunas.Tables("LoadNota").Rows(0).Item("jml_akhir"))
        '    view.SetFocusedRowCellValue("jml_piut", dsNotaLunas.Tables("LoadNota").Rows(0).Item("jml_akhir"))
        '    view.SetFocusedRowCellValue("pendp_lain", "0")
        '    view.SetFocusedRowCellValue("jml_biaya1", "0")
        '    view.SetFocusedRowCellValue("jml_pembulatan", "0")
        '    view.SetFocusedRowCellValue("jml_bayar", view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "jml_biaya1") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan"))
        '    view.SetFocusedRowCellValue("kd_buku_besar", dsNotaLunas.Tables("LoadNota").Rows(0).Item("kd_buku_besar"))

        '    param = "OK"
        '    statex = ""
        'End If

        'If STATE = "EDIT" Then
        '    If statex = "XXX" Then
        '        param = ""
        '    Else
        '        param = "OK"
        '    End If
        'End If

        'If param = "OK" Or param = "UBAH" Then

        If e.Column Is cek Then
            If view.GetRowCellValue(e.RowHandle, "cek") = "Y" Then
                If txtSelisih.EditValue - view.GetRowCellValue(e.RowHandle, "jmlsisa") < 0 Then
                    If Not txtSelisih.EditValue = 0 Then
                        view.SetRowCellValue(e.RowHandle, "jml_piut", view.GetRowCellValue(e.RowHandle, "jml_piut") + (txtSelisih.EditValue - view.GetRowCellValue(e.RowHandle, "jmlsisa")))
                    End If
                End If
            ElseIf view.GetRowCellValue(e.RowHandle, "cek") = "T" Then
                view.SetRowCellValue(e.RowHandle, "jml_piut", view.GetRowCellValue(e.RowHandle, "jml_tagihan"))
            End If
        End If

        If e.Column Is jml_piut Then
            If view.GetRowCellValue(e.RowHandle, "jml_piut").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "jml_piut").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "jml_piut", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
        End If

        If e.Column Is jml_biaya1 Then
            If view.GetRowCellValue(e.RowHandle, "jml_biaya1").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "jml_biaya1").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "jml_biaya1", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
        End If

        If e.Column Is jml_pembulatan Then
            If view.GetRowCellValue(e.RowHandle, "jml_pembulatan").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "jml_pembulatan").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "jml_pembulatan", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
        End If

        If e.Column Is pendp_lain Then
            If view.GetRowCellValue(e.RowHandle, "pendp_lain").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "pendp_lain").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "pendp_lain", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
        End If
        'End If
    End Sub

    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If Not e.Column Is cek Then Exit Sub

        If Not TypeOf GV.GetRowCellValue(e.RowHandle, "cek") Is DBNull Then
            'MsgBox("a")
            If GV.GetRowCellValue(e.RowHandle, "cek") = "Y" Then
                GV.SetRowCellValue(e.RowHandle, "cek", "T")
            Else
                GV.SetRowCellValue(e.RowHandle, "cek", "Y")
            End If
        Else
            'MsgBox("b")
            GV.SetRowCellValue(e.RowHandle, "cek", "Y")
        End If
        GV.MoveNext()
        GV.MovePrev()
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        'View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)

        GC.FocusedView.GetRow(e.RowHandle).Item("no_seq") = GC.FocusedView.RowCount + 1
        'GC.FocusedView.GetRow(e.RowHandle).Item("no_trans") = txtNomor.EditValue
    End Sub

    'Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
    '    If e.KeyCode = Keys.Delete Then
    '        If GV.GetSelectedRows.Count > 0 Then
    '            If MsgBox("Hapus detil nota yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
    '                GV.DeleteSelectedRows()
    '                refreshNomer(GC.FocusedView)
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub lookcust_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookcust.EditValueChanged
    '    'lookbayar.EditValue = System.DBNull.Value
    '    'Lookgiro.EditValue = System.DBNull.Value
    '    If STATE = "EDIT" Then

    '        'v_nota()
    '    End If
    '    loadDataGrid()
    '    V_pembayaran()
    '    V_giro()
    '    If dsLookUp.Tables("View_giro").Rows.Count <= 0 Then
    '        Lookgiro.EditValue = vbNullString
    '        txtJmlGiro.EditValue = vbNullString
    '        'lookbayar.EditValue = "03"
    '    End If
    'End Sub

    Private Sub lookbayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookbayar.EditValueChanged
        'Lookgiro.EditValue = System.DBNull.Value
        'ds1.Clear()
        'V_giro()
        'If dsLookUp.Tables("View_giro").Rows.Count <= 0 Then
        '    Lookgiro.EditValue = vbNullString
        '    txtJmlGiro.EditValue = vbNullString
        'End If

        If lookbayar.EditValue = "04" Then
            lookBank.Visible = True
            lookBank.ItemIndex = 0
        Else
            lookBank.Visible = False
            lookBank.EditValue = vbNullString
        End If
    End Sub

    Private Sub Lookgiro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookgiro.EditValueChanged
        'drPost = New SqlCommand("SELECT jml_trans FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & Lookgiro.EditValue & "'", sqlconn).ExecuteReader
        'While drPost.Read()
        '    txtJmlGiro.Text = drPost.Item("jml_trans")
        'End While
        'drPost.Close()
        If Not (Lookgiro.EditValue Is Nothing Or TypeOf Lookgiro.EditValue Is DBNull) Then
            Dim row As DataRow = dsLookUp.Tables("View_giro").Select("idrec='" & Lookgiro.EditValue & "'")(0)
            txtJmlGiro.EditValue = row.Item("jml_trans")
            txtPembayaran.EditValue = row.Item("jml_trans")
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

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim x As Object
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.DeleteSelectedRows()
            For i = 0 To GC.FocusedView.RowCount - 1
                GC.FocusedView.GetRow(i).Item("no_seq") = i + 1
            Next
        End If
    End Sub

    Private Sub GV_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GV.MasterRowExpanding
        'If TypeOf GV.GetRowCellValue(e.RowHandle, "cek") Is DBNull Then
        '    e.Allow = False
        'Else
        '    e.Allow = True
        'End If
        'If dsNotaLunas.Tables("NotaLunasD").Rows(e.RowHandle).Item("cek").Equals("Y") Then
        '    e.Allow = True
        'Else
        '    e.Allow = False
        'End If
        If GV.GetRowCellValue(e.RowHandle, "cek").Equals("Y") Then
            e.Allow = True
        Else
            e.Allow = False
        End If
    End Sub

    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandel = e.RowHandle
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        Dim viewD As ColumnView = sender
        Dim viewM As ColumnView = GV.Columns.View
        Dim jumlah As Double
        Dim x As Object

        If Not txtPembayaran.EditValue = 0 Then

            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            For i = 0 To GC.FocusedView.RowCount - 1
                If Not TypeOf GC.FocusedView.GetRow(i).Item("cek") Is DBNull Then
                    If GC.FocusedView.GetRow(i).Item("cek") = "Y" Then
                        jumlah += GC.FocusedView.GetRow(i).Item("jml_bayar")
                    End If
                End If
            Next
            txtJmlSub.EditValue = jumlah
            txtSelisih.EditValue = txtPembayaran.EditValue - jumlah

        End If
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
            Dim column7 As GridColumn = view.Columns("rek_biaya1")
            Dim column8 As GridColumn = view.Columns("cek")

            'If view.GetRowCellValue(e.RowHandle, column3) > view.GetRowCellValue(e.RowHandle, column1) Then
            '    e.Valid = False
            'Set errors with specific descriptions for the columns
            'If view.FocusedColumn.FieldName = "jml_piut" Or view.FocusedColumn.FieldName = "jml_biaya1" Or view.FocusedColumn.FieldName = "jml_pembulatan" Or view.FocusedColumn.FieldName = "keterangan" Then
            'view.SetColumnError(column3, "Penambahan jumlah bayar terlalu banyak,tidak boleh melebihi tagihan.")
            'End If
            'If view.FocusedColumn.FieldName = "jml_piut" Or view.FocusedColumn.FieldName = "jml_biaya1" Or view.FocusedColumn.FieldName = "jml_pembulatan" Or view.FocusedColumn.FieldName = "keterangan" Then
            '    view.SetColumnError(column4, "Penambahan jumlah biaya terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
            'End If
            'If view.FocusedColumn.FieldName = "jml_piut" Or view.FocusedColumn.FieldName = "jml_biaya1" Or view.FocusedColumn.FieldName = "jml_pembulatan" Or view.FocusedColumn.FieldName = "keterangan" Then
            '    view.SetColumnError(column5, "Penambahan jumlah pembulatan terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
            'End If
            'If view.FocusedColumn.FieldName = "jml_piut" Or view.FocusedColumn.FieldName = "jml_biaya1" Or view.FocusedColumn.FieldName = "jml_pembulatan" Or view.FocusedColumn.FieldName = "keterangan" Then
            '    view.SetColumnError(column2, "Jumlah bayar melebihi jumlah tagihan.")
            'End If
            'End If

            If Not view.GetRowCellValue(e.RowHandle, column4) = 0 Then
                If Microsoft.VisualBasic.Len(view.GetRowCellValue(e.RowHandle, column7).ToString) <= 0 Then
                    e.Valid = False
                    view.SetColumnError(column7, "Rekening biaya harus dipilih jika jumlah biaya lebih dari 0.")
                    'If view.FocusedColumn.FieldName = "jml_piut" Or view.FocusedColumn.FieldName = "jml_biaya1" Or view.FocusedColumn.FieldName = "jml_pembulatan" Or view.FocusedColumn.FieldName = "keterangan" Then

                    'End If
                Else
                    e.Valid = True
                End If
            End If

            'If view.GetRowCellValue(e.RowHandle, column3) = 0 Then
            '    e.Valid = False
            '    view.SetColumnError(column3, "Jumlah bayar tidak boleh 0.")
            'Else
            '    e.Valid = True
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        'If vx.FocusedColumn.FieldName = "prev_no_inv" Then
        '    If Not GV.RowCount <= 0 Then
        '        Dim noInv As String = e.Value
        '        For i As Integer = 0 To GV.RowCount
        '            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
        '            If noInv = vx.GetRowCellValue(i, prev_no_inv) Then
        '                e.Valid = False
        '                e.ErrorText = "Nota sudah ada, mohon pilih nota yang lain."
        '            End If
        '        Next
        '    End If
        'End If

        'If vx.FocusedColumn.FieldName = "jml_piut" Then
        '    If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
        '        e.Valid = False
        '        e.ErrorText = "Tidak boleh lebih dari tagihan"
        '    End If
        'End If
    End Sub

    'Private Sub txtNominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNominal.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 57 'dari 0-9
    '            e.Handled = False
    '        Case 8, 45, 127
    '            e.Handled = False
    '        Case Else
    '            e.Handled = True
    '    End Select
    'End Sub

    'Private Sub txtPemb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPemb.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 57 'dari 0-9
    '            e.Handled = False
    '        Case 8, 45, 127
    '            e.Handled = False
    '        Case Else
    '            e.Handled = True
    '    End Select
    'End Sub

    Private Sub repBrg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repBrg.QueryPopUp
        'v_nota()
    End Sub

    Private Sub GVDetil_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVDetil.CellValueChanged
        Dim viewD As ColumnView = sender
        Dim viewM As ColumnView = GV.Columns.View
        Dim jumlah As Double
        Dim x As Object

        If viewD.GetRowCellValue(e.RowHandle, "jumlah").ToString = "" Or viewD.GetRowCellValue(e.RowHandle, "jumlah").ToString = vbNullString Then
            viewD.SetRowCellValue(e.RowHandle, "jumlah", "0")
            viewD.SetRowCellValue(e.RowHandle, "prev_no_inv", viewM.GetRowCellValue(rhandel, "prev_no_inv"))
        End If

        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC.FocusedView.RowCount - 1
            jumlah += GC.FocusedView.GetRow(i).Item("jumlah")
        Next
        viewM.SetRowCellValue(rhandel, "jml_biaya1", jumlah)
        viewM.SetRowCellValue(rhandel, "jml_bayar", (viewM.GetRowCellValue(rhandel, "jml_piut") + viewM.GetRowCellValue(rhandel, "pendp_lain") + viewM.GetRowCellValue(rhandel, "jml_pembulatan")) - viewM.GetRowCellValue(rhandel, "jml_biaya1"))
        jumlah = 0
        For i = 0 To viewM.RowCount - 1
            If Not TypeOf viewM.GetRow(i).Item("cek") Is DBNull Then
                If viewM.GetRow(i).Item("cek") = "Y" Then
                    jumlah += viewM.GetRow(i).Item("jml_bayar")
                End If
            End If
        Next
        txtJmlSub.EditValue = jumlah
        txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
    End Sub

    Private Sub GVDetil_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVDetil.InitNewRow
        'Dim View As ColumnView = sender
        sender.SetRowCellValue(e.RowHandle, "no_seq_d", sender.RowCount + 1)
        'View.SetRowCellValue(e.RowHandle, View.Columns("no_seq_d"), GVDetil.RowCount + 1)
        sender.SetRowCellValue(e.RowHandle, "jumlah", 0)
    End Sub

    Private Sub GVDetil_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVDetil.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GVDetil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVDetil.KeyDown
        Dim viewD As ColumnView = sender
        Dim viewM As ColumnView = GV.Columns.View
        Dim jumlah As Double
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

        If e.KeyCode = Keys.Delete Then
            x.DeleteSelectedRows()
            For i = 0 To GC.FocusedView.RowCount - 1
                GC.FocusedView.GetRow(i).Item("no_seq_d") = i + 1
            Next

            If Not GVDetil.RowCount > 0 Then
                For i = 0 To GC.FocusedView.RowCount - 1
                    jumlah += GC.FocusedView.GetRow(i).Item("jumlah")
                Next
                viewM.SetRowCellValue(rhandel, "jml_biaya1", jumlah)
                viewM.SetRowCellValue(rhandel, "jml_bayar", (viewM.GetRowCellValue(rhandel, "jml_piut") + viewM.GetRowCellValue(rhandel, "pendp_lain") + viewM.GetRowCellValue(rhandel, "jml_pembulatan")) - viewM.GetRowCellValue(rhandel, "jml_biaya1"))
                jumlah = 0
                For i = 0 To viewM.RowCount - 1
                    If Not TypeOf viewM.GetRow(i).Item("cek") Is DBNull Then
                        If viewM.GetRow(i).Item("cek") = "Y" Then
                            jumlah += viewM.GetRow(i).Item("jml_bayar")
                        End If
                    End If
                Next
                txtJmlSub.EditValue = jumlah
                txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
            Else
                jumlah = 0
                viewM.SetRowCellValue(rhandel, "jml_biaya1", jumlah)
                viewM.SetRowCellValue(rhandel, "jml_bayar", (viewM.GetRowCellValue(rhandel, "jml_piut") + viewM.GetRowCellValue(rhandel, "pendp_lain") + viewM.GetRowCellValue(rhandel, "jml_pembulatan")) - viewM.GetRowCellValue(rhandel, "jml_biaya1"))

                txtJmlSub.EditValue = jumlah
                txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
            End If

        End If
    End Sub

    Private Sub GVDetil_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVDetil.RowUpdated
        Dim viewD As ColumnView = sender
        Dim viewM As ColumnView = GV.Columns.View
        Dim jumlah As Double
        Dim x As Object

        'If viewD.GetRowCellValue(e.RowHandle, "jumlah").ToString = "" Or viewD.GetRowCellValue(e.RowHandle, "jumlah").ToString = vbNullString Then
        '    viewD.SetRowCellValue(e.RowHandle, "jumlah", "0")
        'End If

        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC.FocusedView.RowCount - 1
            jumlah += GC.FocusedView.GetRow(i).Item("jumlah")
        Next
        viewM.SetRowCellValue(rhandel, "jml_biaya1", jumlah)
        viewM.SetRowCellValue(rhandel, "jml_bayar", (viewM.GetRowCellValue(rhandel, "jml_piut") + viewM.GetRowCellValue(rhandel, "pendp_lain") + viewM.GetRowCellValue(rhandel, "jml_pembulatan")) - viewM.GetRowCellValue(rhandel, "jml_biaya1"))
        jumlah = 0
        For i = 0 To viewM.RowCount - 1
            If Not TypeOf viewM.GetRow(i).Item("cek") Is DBNull Then
                If viewM.GetRow(i).Item("cek") = "Y" Then
                    jumlah += viewM.GetRow(i).Item("jml_bayar")
                End If
            End If
        Next
        txtJmlSub.EditValue = jumlah
        txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
    End Sub

    Private Sub GVDetil_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVDetil.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("jumlah")
        If view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, column1).ToString = "" Then
            e.Valid = False
            view.SetRowCellValue(e.RowHandle, "jumlah", 0)
            view.SetColumnError(column1, "Tolong isi jumlah terlebih dahulu.")
        End If
    End Sub

    Private Sub GVDetil_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GVDetil.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "kd_buku_besar" Then
            If Not GV.RowCount <= 0 Then
                For i As Integer = 0 To GVDetil.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If e.Value = vbNullString Or e.Value = "" Then
                        e.Valid = False
                        e.ErrorText = "Rekening harus diisi."
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Lookgiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lookgiro.QueryPopUp
        V_giro()
    End Sub

    Private Sub txtPembayaran_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPembayaran.EditValueChanged
        Dim jumlah As Double
        Dim x As Object

        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GV.RowCount - 1
            If Not TypeOf GV.GetRow(i).Item("cek") Is DBNull Then
                If GV.GetRow(i).Item("cek") = "Y" Then
                    jumlah += GV.GetRow(i).Item("jml_bayar")
                End If
            End If
        Next
        txtJmlSub.EditValue = jumlah
        txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
    End Sub

    Private Sub lookcust_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookcust.EditValueChanged
        If Not lookcust.EditValue Is Nothing Then
            loadDataGrid()
            'V_pembayaran()
            V_giro()
            If dsLookUp.Tables("View_giro").Rows.Count < 0 Then
                Lookgiro.EditValue = vbNullString
                txtJmlGiro.EditValue = vbNullString
                'lookbayar.EditValue = "03"
            End If
        End If
    End Sub

    'Private Sub lookcust_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookcust.LostFocus
    '    loadDataGrid()
    '    'V_pembayaran()
    '    'V_giro()
    '    If dsLookUp.Tables("View_giro").Rows.Count <= 0 Then
    '        Lookgiro.EditValue = vbNullString
    '        txtJmlGiro.EditValue = vbNullString
    '        'lookbayar.EditValue = "03"
    '    End If
    'End Sub

    Private Sub btnCentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang.Click
        For i As Integer = 0 To GV.RowCount - 1
            GV.SetRowCellValue(i, "cek", "Y")
        Next
        Dim jumlah As Double
        Dim x As Object

        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GV.RowCount - 1
            If Not TypeOf GV.GetRow(i).Item("cek") Is DBNull Then
                If GV.GetRow(i).Item("cek") = "Y" Then
                    jumlah += GV.GetRow(i).Item("jml_bayar")
                End If
            End If
        Next
        txtJmlSub.EditValue = jumlah
        txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
    End Sub

    Private Sub btnCentang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang2.Click
        For i As Integer = 0 To GV.RowCount - 1
            GV.SetRowCellValue(i, "cek", "T")
        Next
        Dim jumlah As Double
        Dim x As Object

        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GV.RowCount - 1
            If Not TypeOf GV.GetRow(i).Item("cek") Is DBNull Then
                If GV.GetRow(i).Item("cek") = "Y" Then
                    jumlah += GV.GetRow(i).Item("jml_bayar")
                End If
            End If
        Next
        txtJmlSub.EditValue = jumlah
        txtSelisih.EditValue = txtPembayaran.EditValue - jumlah
    End Sub
End Class