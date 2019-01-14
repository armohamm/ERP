Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class aFormLunasPiutangUsahaDOSpring
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
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
    Dim param, kodeCari, err, OK As String

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
        reload_table("XXX")
        STATE = "ADD"
    End Sub

    Public Sub cetak_click()
        If Not txtNomor.Text = vbNullString Or txtNomor.Text = "" Then
            callReport(App_Path() & "\report\repNotaLunasCustomerDO.rpt", "", "&nomor=" & txtNomor.Text)
        Else
            MsgBox("Tidak ada data untuk dicetak. Mohon isi dan simpan data baru atau buka kembali data yang sudah disimpan.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        dsEdit = New DataSet
        If Not dsEdit.Tables("NotaLunasEdit") Is Nothing Then dsEdit.Tables("NotaLunasEdit").Clear()
        daEdit = New SqlDataAdapter(New SqlCommand("select a.Kd_Cabang, a.no_trans as 'No. Transaksi', a.tgl_trans as 'Tanggal Transaksi', b.nama as 'Nama Customer', a.jml_rp_trans as 'Jumlah', a.no_posting as 'No. Posting' from FIN.dbo.FIN_NOTA_LUNAS a, FIN.dbo.v_kartu b where a.kd_kartu=b.kode AND a.tipe_trans IN ('JKM-KPT-05','JRR-KPT-16')", sqlconn)) '<- query buat ditampilkan di LOV
        daEdit.Fill(dsEdit, "NotaLunasEdit")
        frmCari.set_dso(dsEdit.Tables("NotaLunasEdit"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kodeCari = frmCari.row("No. Transaksi").ToString
            cabang = frmCari.row("Kd_cabang").ToString
            reload_table(kodeCari)
            If frmCari.row("No. Posting").ToString = vbNullString Then
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                setStatus()
            Else
                MsgBox("Transaski sudah diposting, tidak dapat diubah atau dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
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
        If STATE = "ADD" Then
            daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_Nota where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans = 'JPJ-KPT-01' and jml_akhir>0 and not (len(no_posting)=0 or no_posting is null or no_posting='')", sqlconn))
        Else
            daNota = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_Nota where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans = 'JPJ-KPT-01'", sqlconn))
        End If
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

    Private Sub controlOff(ByVal stat As Boolean)
        dtTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        lookcust.Properties.ReadOnly = stat
        LEValuta.Properties.ReadOnly = stat
        txtkurs.Properties.ReadOnly = stat
        lookbayar.Properties.ReadOnly = stat
        lookDO.Properties.ReadOnly = stat
        Lookgiro.Properties.ReadOnly = stat
        txtKeterangan.Properties.ReadOnly = stat
        txtJmlGiro.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub V_DO()
        If Not lookcust.EditValue = vbNullString Or LEValuta.EditValue = vbNullString Or lookbayar.EditValue = vbNullString Then
            If Not dsNotaLunas.Tables("DO") Is Nothing Then dsNotaLunas.Tables("DO").Clear()
            If STATE = "ADD" Then
                daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT a.nomor, a.tanggal, b.nama, a.jml_akhir, a.no_ref_giro FROM FIN.dbo.FIN_UM a, FIN.dbo.v_kartu b, FIN.dbo.FIN_JURNAL c WHERE a.kartu = b.kode AND a.no_jurnal = c.no_jur AND a.jml_akhir>0 AND NOT (c.no_posting IS NULL OR c.no_posting='') AND a.jns_byr = '" & lookbayar.EditValue & "' AND a.kd_valuta = '" & LEValuta.EditValue & "' AND a.kartu = '" & lookcust.EditValue & "'", sqlconn))
            Else
                daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT a.nomor, a.tanggal, b.nama, a.jml_akhir, a.no_ref_giro FROM FIN.dbo.FIN_UM a, FIN.dbo.v_kartu b, FIN.dbo.FIN_JURNAL c WHERE a.kartu = b.kode AND a.no_jurnal = c.no_jur AND NOT (c.no_posting IS NULL OR c.no_posting='') AND a.jns_byr = '" & lookbayar.EditValue & "' AND a.kd_valuta = '" & LEValuta.EditValue & "' AND a.kartu = '" & lookcust.EditValue & "'", sqlconn))
            End If
            daByr.Fill(dsNotaLunas, "DO")
            lookDO.Properties.DataSource = dsNotaLunas.Tables("DO")
            lookDO.Properties.ValueMember = "nomor"
            lookDO.Properties.DisplayMember = "nomor"
        End If
    End Sub

    Private Sub V_Rek()
        If Not dsNotaLunas.Tables("View_Rek") Is Nothing Then dsNotaLunas.Tables("View_Rek").Clear()
        daRek = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar WHERE kd_buku_besar LIKE '4%' AND grup_header = 'D' UNION SELECT '0000000', 'N/A'", sqlconn))
        daRek.Fill(dsNotaLunas, "View_Rek")
        lookRek.DataSource = dsNotaLunas.Tables("View_Rek")
        lookRek.ValueMember = "kd_buku_besar"
        lookRek.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub V_giro()
        If Not dsNotaLunas.Tables("View_giro") Is Nothing Then dsNotaLunas.Tables("View_giro").Clear()
        If lookDO.EditValue = vbNullString Then
            If lookcust.EditValue = vbNullString Then
                Lookgiro.Enabled = False
                daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where jns_giro='" & lookbayar.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-13' and status='CLEARING' and nomor not in (select no_giro from FIN.dbo.FIN_NOTA_LUNAS)", sqlconn))
            Else
                Lookgiro.Enabled = True
                daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kartu='" & lookcust.EditValue & "' and jns_giro='" & lookbayar.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and jns_trans='JUAL' and tipe_trans='JRR-KPT-13' and status='CLEARING' and nomor not in (select distinct isnull(no_giro,'kosong') from FIN.dbo.FIN_NOTA_LUNAS)", sqlconn))
            End If
        Else
            If lookcust.EditValue = vbNullString Then
                Lookgiro.Enabled = False
                daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nomor, a.keterangan, a.tgl_jth_tempo, a.jml_trans from FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_UM b where(a.nomor = b.no_ref_giro) and a.jns_giro='" & lookbayar.EditValue & "' and a.kd_valuta='" & LEValuta.EditValue & "' and a.jns_trans='JUAL' and a.tipe_trans='JRR-KPT-13' and a.status LIKE 'CLEARING%' and a.nomor not in (select distinct isnull(no_giro,'kosong') from FIN.dbo.FIN_NOTA_LUNAS) and b.nomor = '" & lookDO.EditValue & "'", sqlconn))
            Else
                Lookgiro.Enabled = True
                daGiro = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nomor, a.keterangan, a.tgl_jth_tempo, a.jml_trans from FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_UM b where(a.nomor = b.no_ref_giro) and a.jns_giro='" & lookbayar.EditValue & "' and a.kd_valuta='" & LEValuta.EditValue & "' and a.jns_trans='JUAL' and a.tipe_trans='JRR-KPT-13' and a.status LIKE 'CLEARING%' and a.kartu='" & lookcust.EditValue & "' and a.nomor not in (select distinct isnull(no_giro,'kosong') from FIN.dbo.FIN_NOTA_LUNAS) and b.nomor = '" & lookDO.EditValue & "'", sqlconn))
            End If
        End If

        daGiro.Fill(dsNotaLunas, "View_giro")
        Lookgiro.Properties.DataSource = dsNotaLunas.Tables("View_giro")
        Lookgiro.Properties.ValueMember = "nomor"
        Lookgiro.Properties.DisplayMember = "nomor"
    End Sub

    'Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    For Each rw As DataRow In sender.Rows
    '        rw("no_seq") = i
    '        i += 1
    '    Next
    'End Sub

    Private Sub bersih()
        lookcust.ItemIndex = 0
        lookbayar.EditValue = "03"
        Lookgiro.EditValue = vbNullString
        LEValuta.EditValue = "IDR"
        txtkurs.EditValue = "1"
        txtkurs.Enabled = False
        txtKeterangan.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        txtJmlGiro.EditValue = 0
        lookDO.EditValue = vbNullString
        If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then dsNotaLunas.Tables("NotaLunas").Clear()
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
        'If Not txtJmlGiro.EditValue = 0 Or txtJmlGiro.EditValue = vbNullString Then
        '    If Not GV.Columns("jml_bayar").SummaryText.Equals(txtJmlGiro.EditValue) Then
        '        MsgBox("Jumlah Sub Total tidak sama dari jumlah Giro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        '        Exit Sub
        '    End If
        'End If
        If lookDO.EditValue = vbNullString Then
            MsgBox("Nomor DO belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            lookDO.Focus()
            Exit Sub
        End If

        For Each rx As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
            'If GV.GetRowCellValue(i, "prev_no_inv") Is Nothing Then
            '    MsgBox("Ada nota yang kosong pada detil pembayaran. Mohon dihapus terlebih dahulu", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            '    Exit Sub
            'End If
            If rx.Item("prev_no_inv") = vbNullString Then
                MsgBox("Ada nota yang kosong pada detil pembayaran. Mohon dihapus terlebih dahulu", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                Exit Sub
            End If
        Next

        If Not isDelete Then
            If STATE = "ADD" Then
                txtNomor.EditValue = getNoTrans("JKM", dtTanggal.EditValue)
                row = dsNotaLunas.Tables("NotaLunas").NewRow
                row.Item("no_trans") = txtNomor.EditValue
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    row.Item("tipe_trans") = "JKM-KPT-05"
                Else
                    row.Item("tipe_trans") = "JRR-KPT-16"
                End If
                row.Item("Last_create_date") = Now
                row.Item("Last_created_by") = username
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("Program_Name") = Me.Name
                row.Item("thnbln") = dtTanggal.EditValue.Year.ToString & Mid(FormatDateTime(dtTanggal.EditValue, DateFormat.GeneralDate), 4, 2)
            ElseIf STATE = "EDIT" Then
                row = dsNotaLunas.Tables("NotaLunas").Rows(0)
                row.Item("Last_update_date") = Now
                row.Item("Last_updated_by") = username
            End If

            row.Item("no_do") = lookDO.EditValue
            row.Item("tgl_trans") = dtTanggal.EditValue
            row.Item("no_ref1") = txtNoRef.Text
            row.Item("kd_kartu") = lookcust.EditValue
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("kurs_valuta") = txtkurs.EditValue
            row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
            row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
            row.Item("jns_bayar") = lookbayar.EditValue
            row.Item("jns_giro_trans") = "JRR-KPT-13"
            row.Item("no_giro") = Lookgiro.EditValue

            If STATE = "ADD" Then
                dsNotaLunas.Tables("NotaLunas").Rows.Add(row)
            End If

            For Each rows As DataRow In dsNotaLunas.Tables("NotaLunasD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("Kd_Cabang") = getKodeCabang()
                    rows.Item("no_trans") = txtNomor.EditValue
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("kd_kartu") = lookcust.EditValue
                    If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                        rows.Item("tipe_trans") = "JKM-KPT-05"
                    Else
                        rows.Item("tipe_trans") = "JRR-KPT-16"
                    End If
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                    'ElseIf Not rows.RowState = DataRowState.Deleted Then
                    '    If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    '        rows.Item("tipe_trans") = "JKM-KPT-05"
                    '    Else
                    '        rows.Item("tipe_trans") = "JRR-KPT-16"
                    '    End If
                End If
            Next
        End If

        Try
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

            If Not isDelete Then
                If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
                    call_procedure("JKM-KPT-05", txtNomor.EditValue, BTRANS)
                Else
                    call_procedure("JRR-KPT-16", txtNomor.EditValue, BTRANS)
                End If
            End If

            BTRANS.Commit()

            If isDelete Then
                showMessages("Berhasil dihapus.")
                cancel_click()
            Else
                showMessages("Berhasil disimpan..")
                reload_table("xxx")
            End If
        Catch ex As Exception
            BTRANS.Rollback()
            dsNotaLunas.Tables("NotaLunas").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsNotaLunas.Tables("NotaLunasD").RejectChanges()
            MsgBox(ex.Message)
        End Try
        Lookgiro.Enabled = True
    End Sub

    Public Sub reload_table(ByVal kode As String)
        If Not dsNotaLunas.Tables("NotaLunas") Is Nothing Then dsNotaLunas.Tables("NotaLunas").Clear()
        If Not dsNotaLunas.Tables("NotaLunasD") Is Nothing Then dsNotaLunas.Tables("NotaLunasD").Clear()

        daNotaL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daNotaL.Fill(dsNotaLunas, "NotaLunas")

        daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
        daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        GC.DataSource = dsNotaLunas.Tables("NotaLunasD")
        GV.BestFitColumns()
        'AddHandler ds4.Tables("PODcari").RowDeleted, AddressOf refreshNomer

        If dsNotaLunas.Tables("NotaLunas").Rows.Count > 0 Then
            row = dsNotaLunas.Tables("NotaLunas").Rows(0)
            txtNomor.Text = row.Item("no_trans").ToString
            txtNoRef.Text = row.Item("no_ref1").ToString
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            dtTanggal.EditValue = row.Item("tgl_trans").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            lookcust.EditValue = row.Item("kd_kartu").ToString
            lookbayar.EditValue = row.Item("jns_bayar").ToString
            lookDO.EditValue = row.Item("no_do").ToString
            Lookgiro.EditValue = row.Item("no_giro").ToString
            'txtSubTotal.EditValue = row.Item("jml_val_trans")
        Else
            bersih()
        End If
    End Sub

    Private Sub aFormLunasPiutangUsahaDO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        View_Valuta()
        V_Customer()
        V_pembayaran()
        V_Rek()
        lookbayar.EditValue = "03"
        dtTanggal.EditValue = getTanggal()
        LEValuta.EditValue = "IDR"
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
        V_DO()
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
        If GV.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To GV.RowCount - 1
                GV.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
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
            view.SetRowCellValue(e.RowHandle, "jml_piut", dsEdit.Tables("LoadNota").Rows(0).Item("jml_akhir"))
            view.SetRowCellValue(e.RowHandle, "jml_biaya1", "0")
            view.SetRowCellValue(e.RowHandle, "jml_pembulatan", "0")
            view.SetRowCellValue(e.RowHandle, "pendp_lain", "0")
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
                view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
            End If

            If e.Column Is jml_biaya1 Then
                view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
            End If

            If e.Column Is jml_pembulatan Then
                view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")) - view.GetRowCellValue(e.RowHandle, "jml_biaya1"))
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
        V_DO()
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
        V_DO()
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
            Dim column7 As GridColumn = view.Columns("rek_biaya1")
            If view.GetRowCellValue(e.RowHandle, column2) > view.GetRowCellValue(e.RowHandle, column1) Then
                e.Valid = False
                'If view.FocusedColumn.FieldName = "jml_bayar" Then
                '    view.SetColumnError(column3, "Penambahan jumlah lunas terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                'End If
                'If view.FocusedColumn.FieldName = "jml_biaya1" Then
                '    view.SetColumnError(column4, "Penambahan jumlah biaya terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                'End If
                'If view.FocusedColumn.FieldName = "jml_pembulatan" Then
                '    view.SetColumnError(column5, "Penambahan jumlah pembulatan terlalu banyak. Jumlah bayar melebihi jumlah tagihan.")
                'End If
                'If view.FocusedColumn.FieldName = "keterangan" Then
                view.SetColumnError(column3, "Sub total tidak bisa melebihi tagihan.")
                'End If
            End If


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
            'ElseIf vx.FocusedColumn.FieldName = "jml_piut" Then
            '    If vx.GetFocusedRowCellValue("jml_piut") > vx.GetFocusedRowCellValue("jml_tagihan") Then
            '        e.Valid = False
            '        e.ErrorText = "Penambahan jumlah lunas terlalu banyak. Jumlah bayar melebihi jumlah tagihan."
            '    End If
        End If
        'If vx.FocusedColumn.FieldName = "jml_piut" Then
        '    If e.Value > (vx.GetFocusedRowCellValue("jml_tagihan")) Then
        '        e.Valid = False
        '        e.ErrorText = "Tidak boleh lebih dari tagihan"
        '    End If
        'End If
    End Sub

    Private Sub repBrg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repBrg.QueryPopUp
        v_nota()
    End Sub

    Private Sub lookDO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookDO.EditValueChanged
        If lookbayar.EditValue = "01" Or lookbayar.EditValue = "02" Then
            V_giro()
            If dsNotaLunas.Tables("View_giro").Rows.Count <= 0 Then
                Lookgiro.EditValue = vbNullString
                txtJmlGiro.EditValue = vbNullString
            End If
        Else
            drPost = New SqlCommand("SELECT jml_akhir FROM FIN.dbo.FIN_UM WHERE nomor = '" & lookDO.EditValue & "'", sqlconn).ExecuteReader
            While drPost.Read()
                txtJmlGiro.Text = drPost.Item("jml_akhir")
            End While
            drPost.Close()
        End If
    End Sub
End Class