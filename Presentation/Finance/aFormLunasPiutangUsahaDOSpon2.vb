'tgl 19/06/2015
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class aFormLunasPiutangUsahaDOSpon2
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
    Dim param, kodeCari, err, bayar, giro As String
    Dim bank As Double
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
        Me.Enabled = True
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
        daEdit = New SqlDataAdapter(New SqlCommand("select a.no_trans as 'No. Transaksi', a.tgl_trans as 'Tanggal Transaksi', b.nama as 'Nama Customer', a.jml_rp_trans as 'Jumlah', CASE WHEN (c.Desc_Data = 'Giro' OR c.Desc_Data = 'Cek') THEN c.Desc_Data + ' : ' + SUBSTRING(a.no_giro,1,6) ELSE CASE WHEN c.Desc_Data = 'Transfer' THEN c.Desc_Data + ' : ' + (SELECT x.nama_bank FROM SIF.dbo.SIF_Bank x, FIN.dbo.FIN_NOTA_LUNAS y WHERE x.kd_bank = y.kd_bank AND y.no_trans = a.no_trans) ELSE c.Desc_Data END END as 'Pembayaran', ISNULL(a.no_posting,'NP') no_posting from FIN.dbo.FIN_NOTA_LUNAS a, FIN.dbo.v_kartu b, sif.dbo.SIF_Gen_Reff_D c where a.kd_kartu=b.kode and a.Jns_bayar = c.Id_Data AND a.tipe_trans = 'JRR-KPT-16' AND (a.Program_name = 'aFormLunasPiutangUsahaDOSpring2') AND c.Id_Ref_data='JNSBYR' order by a.tgl_trans DESC", sqlconn)) '<- query buat ditampilkan di LOV
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
            If frmCari.row("no_posting") = "NP" Then
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
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        'disableAll(Panel43, True)
        setStatus()
        Me.Enabled = False
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

    Private Sub V_Customer()
        If Not dsLookUp.Tables("View_Customer") Is Nothing Then dsLookUp.Tables("View_Customer").Clear()
        'daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.* from(select Kd_Customer as kode, Nama_Customer as nama, Alamat1 as alamat from sif.dbo.SIF_Customer UNION ALL select Kode_Pegawai as kode, Nama_Pegawai as nama, Alamat_1 as alamat from sif.dbo.SIF_Pegawai) a ORDER BY a.nama", sqlconn))
        daCust = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.* from(select distinct a.kd_cust as kode, b.Nama_Customer as nama, b.Alamat1 as alamat from FIN.dbo.FIN_NOTA a, SIF.dbo.SIF_Customer b where a.kd_cust = b.Kd_Customer and b.Rec_stat = 'Y' UNION ALL select distinct a.kd_cust as kode, b.Nama_Pegawai as nama, b.Alamat_1 as alamat from FIN.dbo.FIN_NOTA a, SIF.dbo.SIF_Pegawai b where a.kd_cust = b.Kode_Pegawai) a ORDER BY a.nama", sqlconn))
        daCust.Fill(dsLookUp, "View_Customer")
        lookcust.Properties.DataSource = dsLookUp.Tables("View_Customer")
        lookcust.Properties.ValueMember = "kode"
        lookcust.Properties.DisplayMember = "nama"
    End Sub

    Private Sub V_DO()
        If Not lookcust.EditValue = vbNullString Or LEValuta.EditValue = vbNullString Then
            If Not dsLookUp.Tables("DO") Is Nothing Then dsLookUp.Tables("DO").Clear()

            If STATE = "ADD" Then
                daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT a.nomor, a.tanggal, a.jml_akhir, a.no_ref_giro, a.jns_byr, CASE WHEN (d.Desc_Data = 'Giro' OR d.Desc_Data = 'Cek') THEN d.Desc_Data + ' : ' + LEFT(a.no_ref_giro,6) ELSE CASE WHEN d.Desc_Data = 'Transfer' THEN d.Desc_Data + ' : ' + (SELECT x.nama_bank FROM SIF.dbo.SIF_Bank x, FIN.dbo.FIN_UM y WHERE x.kd_bank = y.no_ref_giro AND y.nomor = a.nomor) ELSE d.Desc_Data END END as 'Pembayaran' FROM FIN.dbo.FIN_UM a, FIN.dbo.v_kartu b, FIN.dbo.FIN_JURNAL c, SIF.dbo.SIF_Gen_Reff_D d WHERE a.kartu = b.kode AND a.no_jurnal = c.no_jur AND a.jns_byr = d.Id_Data AND a.jml_akhir > 0 AND NOT (c.no_posting IS NULL OR c.no_posting='') AND a.kd_valuta = '" & LEValuta.EditValue & "' AND a.kartu = '" & lookcust.EditValue & "' AND d.Id_Ref_Data='JNSBYR' AND NOT a.nomor IN (SELECT DISTINCT ISNULL(no_do,'') FROM FIN.dbo.FIN_NOTA_LUNAS)", sqlconn))
            Else
                daByr = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT a.nomor, a.tanggal, a.jml_akhir, a.no_ref_giro, a.jns_byr, CASE WHEN (d.Desc_Data = 'Giro' OR d.Desc_Data = 'Cek') THEN d.Desc_Data + ' : ' + LEFT(a.no_ref_giro,6) ELSE CASE WHEN d.Desc_Data = 'Transfer' THEN d.Desc_Data + ' : ' + (SELECT x.nama_bank FROM SIF.dbo.SIF_Bank x, FIN.dbo.FIN_UM y WHERE x.kd_bank = y.no_ref_giro AND y.nomor = a.nomor) ELSE d.Desc_Data END END as 'Pembayaran' FROM FIN.dbo.FIN_UM a, FIN.dbo.v_kartu b, FIN.dbo.FIN_JURNAL c, SIF.dbo.SIF_Gen_Reff_D d WHERE a.kartu = b.kode AND a.no_jurnal = c.no_jur AND a.jns_byr = d.Id_Data AND NOT (c.no_posting IS NULL OR c.no_posting='') AND a.kd_valuta = '" & LEValuta.EditValue & "' AND a.kartu = '" & lookcust.EditValue & "' AND d.Id_Ref_Data='JNSBYR'", sqlconn))
            End If
            daByr.Fill(dsLookUp, "DO")
            lookDO.Properties.DataSource = dsLookUp.Tables("DO")
            lookDO.Properties.ValueMember = "nomor"
            lookDO.Properties.DisplayMember = "nomor"
        End If
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Private Sub bersih()
        dsNotaLunas = New DataSet
        lookcust.EditValue = vbNullString
        LEValuta.EditValue = "IDR"
        txtkurs.EditValue = "1"
        txtkurs.Enabled = False
        txtKeterangan.Text = ""
        txtNoRef.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        lookDO.EditValue = vbNullString
        txtJmlGiro.EditValue = 0
        txtSelisih.EditValue = 0
        txtJmlSub.EditValue = 0
        txtSelisih.EditValue = 0
        txtPembayaran.EditValue = 0
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If lookcust.EditValue = vbNullString Then
            MsgBox("Customer belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            lookcust.Focus()
            Exit Sub
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
                If Not TypeOf rw.Item("cek") Is DBNull Then
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
                row.Item("tipe_trans") = "JRR-KPT-16"
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("jns_giro_trans") = "JRR-KPT-13"
                row.Item("Program_Name") = Me.Name
            ElseIf STATE = "EDIT" Then
                row = dsNotaLunas.Tables("NotaLunas").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

            row.Item("tgl_trans") = dtTanggal.EditValue
            row.Item("no_ref1") = txtNoRef.EditValue
            row.Item("kd_kartu") = lookcust.EditValue
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("kd_bank") = bank
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.EditValue
            row.Item("jns_bayar") = bayar
            row.Item("no_giro") = giro
            row.Item("no_do") = lookDO.EditValue
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
                rows.Item("tipe_trans") = "JRR-KPT-16"
                rows.Item("Last_create_date") = Now
                rows.Item("Last_created_by") = username
            Next
        End If

        Try
            If isDelete Then
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & txtNomor.EditValue & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & txtNomor.EditValue & "'", sqlconn, BTRANS)
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
                call_procedure("JRR-KPT-16", txtNomor.EditValue, BTRANS)
            End If

            BTRANS.Commit()

            If STATE = "DELETE" Then
                showMessages("Berhasil dihapus.")
                cancel_click()
            Else
                showMessages("Berhasil disimpan.")
                btnDelete = False
                setStatus()
                bersih()
                reload_table("xxx")
                If STATE = "EDIT" Then STATE = "ADD"
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsNotaLunas.Tables("NotaLunas").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsNotaLunas.Tables("NotaLunasD").RejectChanges()
            MsgBox(e.Message)
        End Try
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

            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, isnull(a.jml_cashback,0) + isnull(a.jml_pot_nota,0) as jmldiskon, b.Desc_Data, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where jml_akhir > 0 and thnbln = a.thnbln and kd_cust = a.kd_cust and kd_valuta = a.kd_valuta and tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and not (len(no_posting)=0 or no_posting is null or no_posting='')) as jmltagihan, a.jml_tagihan - (select isnull(sum(jml_bayar),0) from fin.dbo.FIN_NOTA_LUNAS_D where prev_no_inv = a.no_inv) jmlsisa from FIN.dbo.FIN_Nota a, sif.dbo.sif_gen_reff_d b where a.jns_inv = b.Id_Data and a.kd_cust = '" & lookcust.EditValue & "' and a.kd_valuta = '" & LEValuta.EditValue & "' and a.tipe_trans in ('JPJ-KPT-02','JPJ-KPT-04') and a.jml_akhir > 0 and not (len(a.no_posting)=0 or a.no_posting is null or a.no_posting='') and b.Id_Ref_FIle = 'JNSINV' and a.jml_tagihan - (select isnull(sum(jml_bayar),0) from fin.dbo.FIN_NOTA_LUNAS_D where prev_no_inv = a.no_inv) > 0 order by a.no_inv desc", sqlconn))
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
            col_jenis.BestFit()
            tot_tagihan.BestFit()
            tgl_inv.BestFit()
        End If

    End Sub

    Public Sub reload_table(ByVal kode As String)
        dsNotaLunas = New DataSet
        daNotaL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS where no_trans = '" & kode & "'", sqlconn))
        daNotaL.Fill(dsNotaLunas, "NotaLunas")

        If STATE = "ADD" Then
            daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, CAST('01/01/2014' AS DATE) as tgl_inv, 0.0 as jmlsisa, 0.0 as jmltagihan, 0 as jmldiskon, '' as jenis, 'T' as cek from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
            daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        ElseIf STATE = "EDIT" Then
            daNotaLD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, jml_tagihan - (jml_bayar + jml_piut) jmlsisa, (SELECT tgl_inv FROM FIN.dbo.FIN_Nota WHERE no_inv = a.prev_no_inv) as tgl_inv, (select distinct SUM(jml_tagihan) from fin.dbo.FIN_NOTA where no_inv = a.prev_no_inv) as jmltagihan, (select y.Desc_Data FROM fin.dbo.FIN_NOTA x, sif.dbo.sif_gen_reff_d y WHERE x.jns_inv = y.Id_Data AND x.no_inv = a.prev_no_inv and y.Id_Ref_FIle = 'JNSINV' ) as jenis, 'Y' as cek from FIN.dbo.FIN_NOTA_LUNAS_D a where no_trans= '" & kode & "'", sqlconn))
            daNotaLD.Fill(dsNotaLunas, "NotaLunasD")
        End If

        GC.DataSource = dsNotaLunas.Tables("NotaLunasD")
        GV.BestFitColumns()

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
            txtNomor.EditValue = row.Item("no_trans")
            txtNoRef.EditValue = IIf(TypeOf row.Item("no_ref1") Is DBNull, "", row.Item("no_ref1"))
            LEValuta.EditValue = row.Item("kd_valuta")
            lookcust.EditValue = row.Item("kd_kartu")
            lookDO.EditValue = row.Item("no_do")
            txtkurs.EditValue = row.Item("kurs_valuta")
            dtTanggal.EditValue = row.Item("tgl_trans")
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
        dtTanggal.EditValue = getTanggal()
        LEValuta.EditValue = "IDR"
        txtkurs.Enabled = False
        txtkurs.Text = "1"
        dtTanggal.Properties.MaxValue = Today
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
        loadDataGrid()
    End Sub

    Private Sub refreshNomer(ByVal grid As GridView)
        Dim x As Object
        Dim i As Int16
        If grid.RowCount = 0 Then
            Exit Sub
        Else
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            For i = 0 To GC.FocusedView.RowCount - 1
                GC.FocusedView.GetRow(i).Item("no_seq") = i + 1
            Next
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

        If Not dsNotaLunas.Tables("LoadNota") Is Nothing Then dsNotaLunas.Tables("LoadNota").Clear()
        daNota = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv='" & view.GetFocusedRowCellValue("prev_no_inv") & "'", sqlconn))
        daNota.Fill(dsNotaLunas, "LoadNota")


        If e.Column Is cek Then
            If view.GetRowCellValue(e.RowHandle, "cek") = "Y" Then
                If txtSelisih.EditValue - view.GetRowCellValue(e.RowHandle, "jmlsisa") < 0 Then
                    If Not txtSelisih.EditValue = 0 Then
                        view.SetRowCellValue(e.RowHandle, "jml_piut", view.GetRowCellValue(e.RowHandle, "jml_piut") + (txtSelisih.EditValue - view.GetRowCellValue(e.RowHandle, "jmlsisa")))
                    End If
                End If
            End If
        End If

        If e.Column Is jml_piut Then
            If view.GetRowCellValue(e.RowHandle, "jml_piut").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "jml_piut").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "jml_piut", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")))
        End If

        If e.Column Is jml_pembulatan Then
            If view.GetRowCellValue(e.RowHandle, "jml_pembulatan").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "jml_pembulatan").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "jml_pembulatan", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")))
        End If

        If e.Column Is pendp_lain Then
            If view.GetRowCellValue(e.RowHandle, "pendp_lain").ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, "pendp_lain").ToString = "" Then
                view.SetRowCellValue(e.RowHandle, "pendp_lain", 0)
            End If
            view.SetRowCellValue(e.RowHandle, "jml_bayar", (view.GetRowCellValue(e.RowHandle, "jml_piut") + view.GetRowCellValue(e.RowHandle, "pendp_lain") + view.GetRowCellValue(e.RowHandle, "jml_pembulatan")))
        End If
    End Sub

    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If Not e.Column Is cek Then Exit Sub

        If Not TypeOf GV.GetRowCellValue(e.RowHandle, "cek") Is DBNull Then
            If GV.GetRowCellValue(e.RowHandle, "cek") = "Y" Then
                GV.SetRowCellValue(e.RowHandle, "cek", "T")
            Else
                GV.SetRowCellValue(e.RowHandle, "cek", "Y")
            End If
        Else
            GV.SetRowCellValue(e.RowHandle, "cek", "Y")
        End If
        GV.MoveNext()
        GV.MovePrev()
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        Dim View As ColumnView = sender

        GC.FocusedView.GetRow(e.RowHandle).Item("no_seq") = GC.FocusedView.RowCount + 1
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

            'If view.GetRowCellValue(e.RowHandle, column3) = 0 Then
            '    e.Valid = False
            '    view.SetColumnError(column3, "Jumlah bayar tidak boleh 0.")
            'Else
            '    e.Valid = True
            'End If

        Catch ex As Exception

        End Try
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
            V_DO()
        End If
    End Sub

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

    Private Sub lookDO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookDO.EditValueChanged
        If Not lookDO.EditValue = vbNullString Then
            bank = 0
            giro = ""
            bayar = ""
            txtJenis.EditValue = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("Pembayaran")
            txtJmlGiro.EditValue = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jml_akhir")
            txtPembayaran.EditValue = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jml_akhir")
            bayar = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jns_byr")
            If dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jns_byr") = "04" Then
                bank = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("no_ref_giro")
            ElseIf dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jns_byr") = "01" Or dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("jns_byr") = "02" Then
                giro = dsLookUp.Tables("DO").Select("nomor='" & lookDO.EditValue & "'")(0).Item("no_ref_giro")
            End If
        End If
    End Sub
End Class