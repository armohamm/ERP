'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmQC_returPO
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, supp, p_np As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private BTRAN As SqlTransaction

    Public Sub btnstart()

    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data QC ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dso.Tables("_qcm") Is Nothing Then
                For Each rw As DataRow In dso.Tables("_qcm").Rows
                    rw.Delete()
                Next
            End If
            If Not dSO1.Tables("_qc") Is Nothing Then
                For Each rw As DataRow In dSO1.Tables("_qc").Rows
                    rw.Delete()
                Next
            End If

            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub


    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        If GvINV_Ret.Columns("qty_qc_pass").SummaryItem.SummaryValue > GvINV_Ret.Columns("qty_order").SummaryItem.SummaryValue Then
            MsgBox("Qty QC Good melebihi Qty Order, Silahkan Cek lagi nilai entrian")
            Exit Sub
        End If

        'If LookupGudang.EditValue = vbNullString Then
        '    MsgBox("Gudang Tujuan belum di Set!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
        '    Exit Sub
        'End If
        If Not isDel Then
            If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
        Else
            simpan(isDel)
        End If

    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
    End Sub
    Public Sub edit_click()
        'enabel()
        STATE = "EDIT"
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [No QC],tgl_trans as Tanggal,no_ref,Last_Created_By as [Petugas QC],case when trx_stat=0 then 'Belum Masuk Gudang' when trx_stat=1 then 'Sudah Masuk Gudang' end as Status_Masuk_Gudang,cetak_ulang from INV.DBO.INV_QC_M where substring((no_trans),12,5)='QC-RT'", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        'If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
        '    LoadStruktur(frmCari.row(1))
        '    STATE = "EDIT"
        '    btnSave = True
        '    btnadd = False
        '    btnEdit = False
        '    btnDelete = True
        '    btnCancel = True
        '    setStatus()
        '    Me.Enabled = True

        'Else
        '    cancel_click()
        '    STATE = ""
        'End If
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            TxbPenerima.Enabled = False
            load_po_retur()
            LoadStruktur(frmCari.row(0))
            If frmCari.row.Item("cetak_ulang") = "Y" Then
                frmMain.btnCetak.Enabled = True
                'MsgBox("cetak")
            ElseIf frmCari.row.Item("cetak_ulang") = "T" Then
                frmMain.btnCetak.Enabled = False
                'MsgBox("no cetak")
            End If

            If frmCari.row.Item("Status_Masuk_Gudang").ToString = "Sudah Masuk Gudang" Then
                btnSave = False
                'txbSJSupplier.Enabled = False
                LookupNoRetur.Enabled = False
                STATE = "EDIT"
                Me.Enabled = True
                setStatus()
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
            ElseIf frmCari.row.Item("Status_Masuk_Gudang").ToString = "Belum Masuk Gudang" Then
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                btnSave = True
                STATE = "EDIT"
                Me.Enabled = True
                setStatus()
                'LookupPO.Enabled = False
                TxbPenerima.Enabled = True

            Else
                cancel_click()
                'LookupPO.Enabled = False
                STATE = ""
            End If
        End If

    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        For Each row As DataRow In dSO1.Tables("_qc").Select("qty_order = qty_sisa and qty_qc_unpass=0")
            row.Delete()
        Next
        If Not isDelete Then


            'STATE = "ADD"
            If STATE = "ADD" Then
                row = dSO.Tables("_qcm").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("cetak_ke") = 0
                row.Item("trx_stat") = 0
                row.Item("cetak_ulang") = "Y"
                'row.Item("p_np") = p_np

            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_qcm").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username

            ElseIf STATE = "CETAK" Then
                row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If

            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            'row.Item("tipe_trans") = "JPB-KUT-03"
            row.Item("tgl_trans") = getTanggal()
            row.Item("jml_rp_trans") = GvINV_Ret.Columns("rp_trans").SummaryItem.SummaryValue
            'MsgBox(GvINV_Ret.Columns("rp_trans").SummaryItem.SummaryValue)
            row.Item("penyerah") = TxbPenerima.Text
            row.Item("kd_supplier") = TxbPenerima.EditValue
            row.Item("no_ref") = LookupNoRetur.EditValue
            'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
            row.Item("blthn") = blthn()
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                dSO.Tables("_qcm").Rows.Add(row)
            End If
            For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                If row1.RowState = DataRowState.Added Then
                    'row1.Item("no_trans") = row.Item("no_trans")
                    row1.Item("tgl_trans") = Now
                    row1.Item("Last_Create_Date") = getTanggal()
                    row1.Item("Last_Created_By") = username
                    row1.Item("kd_Cabang") = kdcabang
                Else
                    row1.Item("Last_Update_Date") = getTanggal()
                    row1.Item("Last_Updated_By") = username
                End If
                row1.Item("Program_name") = Me.Name

            Next
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then
                row.Item("no_trans") = getNoTrans("QC-RT", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")

                For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If

            DA.Update(dSO.Tables("_qcm"))
            DA2.Update(dSO1.Tables("_qc"))


            For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                'If row1.RowState = DataRowState.Added Then

                Dim sqlcmd1 As New SqlCommand("update INV.dbo.INV_GUDANG_OUT_D set qty_sisa_retur=@nilai where no_trans='" & LookupNoRetur.Text & "' and kd_stok='" & row1("kd_stok").ToString & "' ", sqlconn, BTRANS)
                sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("qty_sisa"))
                sqlcmd1.ExecuteNonQuery()
                'MsgBox(LookupNoRetur.Text)

            Next

            ''strprc_finbeli(row("no_trans").ToString, BTRANS)
            '## spc stok saldo gudang out
            'For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            '    If STATE = "ADD" Then
            '        setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
            '        stprc_gudang_in("2", blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("gudang_tujuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_qc_pass"), 0, BTRANS)

            '        setor_prosedur2("2", blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '    End If
            'Next

            'dSO.Tables("_qcm").AcceptChanges()
            'dSO1.Tables("_qc").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_qcm").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub stprc_gudang_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukurx As String, ByVal kd_gdx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal qty_inx As Decimal, ByVal qty_lainx As Decimal, ByVal BTRANS As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukurx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = kd_gdx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx
        'sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@qty_lain_in", SqlDbType.Decimal).Value = qty_lainx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub strprc_finbeli(ByVal notranx As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_BELI"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 25).Value = notranx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\QC.rpt", "", "no_qc=" & txbNoTrans.Text, False, False)
        Dim sqcmd As New SqlCommand("update INV.dbo.INV_QC_M set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()

    End Sub

    Public Sub hapus_record()

    End Sub

    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub bersihkan()
        LookupNoRetur.Enabled = True
        TxbPenerima.Text = ""
        txbNoTrans.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupSPM.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        LookupNoRetur.EditValue = vbNullString
        TxbBarcode.Text = ""
        dSO1.Clear()
    End Sub
    Private Sub load_po_retur()
        If STATE = "ADD" Then
            If Not ds_cari1.Tables("_lookupRTO") Is Nothing Then ds_cari1.Tables("_lookupRTO").Clear()
            'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct POD.no_po as no_ref FROM PURC.dbo.PURC_PO_D POD, PURC.dbo.PURC_PO PO where POD.no_po=PO.no_PO and POD.qty_sisa <> 0 and PO.rec_stat = 'APPROVE'", sqlconn))
            DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct gdo.no_trans, gdo.no_ref from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans where substring((gdo.no_trans),12,3)='RTR' and (gdod.qty_sisa_retur is null or gdod.qty_sisa_retur > 0) AND gdo.no_trans IN (SELECT a.no_trans FROM INV.dbo.INV_GUDANG_OUT a, PURC.dbo.PURC_RETUR_BELI b WHERE a.no_ref = b.no_retur AND a.no_trans = gdo.no_trans AND b.status = 'Y')", sqlconn))
            DALOOKUP1.Fill(ds_cari1, "_lookupRTO")
            LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_lookupRTO")
            LookupNoRetur.Properties.ValueMember = "no_trans"
            LookupNoRetur.Properties.DisplayMember = "no_trans"


        ElseIf STATE = "EDIT" Then
            If Not ds_cari1.Tables("_lookupRTO") Is Nothing Then ds_cari1.Tables("_lookupRTO").Clear()
            DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct gdo.no_trans, gdo.no_ref from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans where substring((gdo.no_trans),12,3)='RTR'", sqlconn))
            DALOOKUP1.Fill(ds_cari1, "_lookupRTO")
            LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_lookupRTO")
            LookupNoRetur.Properties.ValueMember = "no_trans"
            LookupNoRetur.Properties.DisplayMember = "no_trans"
        End If
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_qcm") Is Nothing Then dSO.Tables("_qcm").Clear()
        If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_qcm")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_brg from INV.dbo.INV_QC where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_qc")
        GcINV_Ret.DataSource = dSO1.Tables("_qc")

        If dSO.Tables("_qcm").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_qcm").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            TxbPenerima.EditValue = rw("kd_supplier")
            LookupNoRetur.EditValue = rw("no_ref").ToString
            'MsgBox(rw("no_ref").ToString)
            LookupNoRetur.Enabled = False
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub

    Private Sub frm_QC_returPO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        GvINV_Ret.Columns("rp_trans").Visible = False
        GvINV_Ret.Columns("harga").Visible = False
        GvINV_Ret.Columns("tinggi").Visible = False
        GvINV_Ret.Columns("lebar").Visible = False
        GvINV_Ret.Columns("panjang").Visible = False
        prn = getParent(Me)


        LoadStruktur("xxxx")
        load_po_retur()

        If Not ds_cari.Tables("LookKar") Is Nothing Then ds_cari.Tables("LookKar").Clear()
        'If Not ds_cari1.Tables("_lookupRTO") Is Nothing Then ds_cari1.Tables("_lookupRTO").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT Nama_Supplier, Kode_Supplier FROM SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookKar")
        TxbPenerima.Properties.DataSource = ds_cari.Tables("LookKar")
        TxbPenerima.Properties.DisplayMember = "Nama_Supplier"
        TxbPenerima.Properties.ValueMember = "Kode_Supplier"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepBarang.DataSource = ds_cari.Tables("_lookup1")
        RepBarang.ValueMember = "Kode_Barang"
        RepBarang.DisplayMember = "Nama_Barang"


        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select gdo.no_trans from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans where substring((gdo.no_trans),12,3)='RTR' and (gdod.qty_sisa_retur is null or gdod.qty_sisa_retur > 0) AND gdo.no_trans IN (SELECT a.no_trans FROM INV.dbo.INV_GUDANG_OUT a, PURC.dbo.PURC_RETUR_BELI b WHERE a.no_ref = b.no_retur AND a.no_trans = gdo.no_trans AND b.status = 'Y')", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookupRTO")
        'LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_lookupRTO")
        'LookupNoRetur.Properties.ValueMember = "no_trans"
        'LookupNoRetur.Properties.DisplayMember = "no_trans"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_gdgAsal")
        RL_GdgAsal.DataSource = ds_gdg1.Tables("_gdgAsal")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_gdg2.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"

        formate_yayak()

    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvINV_Ret.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_qc_pass").DisplayFormat.FormatString = "n3"
        GvINV_Ret.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_order").DisplayFormat.FormatString = "n3"
        GvINV_Ret.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_sisa").DisplayFormat.FormatString = "n3"
    End Sub

    Private Sub LookupNoRetur_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupNoRetur.EditValueChanged

        If STATE = "ADD" Then
            If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            'MsgBox(LookupNoRetur.Text)
            Dim sqldr As SqlDataReader = New SqlCommand("select DISTINCT gdo.no_trans,gdo.tipe_trans,gdo.penerima,gdod.kd_stok,gdod.qty_sisa_retur,gdod.kd_satuan,brg.Nama_Barang,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,brg.lokasi,uk.lebar,uk.Tinggi,uk.Panjang,rtrd.harga ,rtr.kd_supplier from inv.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans inner join SIF.dbo.SIF_Barang brg on gdod.kd_stok=brg.Kode_Barang inner join SIF.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran inner join PURC.dbo.PURC_RETUR_BELI rtr on rtr.no_retur=gdo.no_ref inner join PURC.dbo.PURC_RETUR_BELI_D rtrd on rtr.no_retur=rtrd.no_retur and rtrd.kd_stok = brg.Kode_Barang where gdo.no_trans='" & LookupNoRetur.EditValue & "'", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_qc").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_qc").NewRow
                rw.Item("Kd_Cabang") = kdcabang
                'rw.Item("no_trans") = "001"
                rw.Item("tipe_trans") = "JPB-KUT-03"
                rw.Item("no_seq") = i : i += 1
                rw.Item("nama_brg") = sqldr.Item("Nama_Barang")
                supp = sqldr.Item("kd_supplier")
                rw.Item("kd_stok") = sqldr.Item("kd_stok")
                rw.Item("kd_satuan") = sqldr.Item("kd_satuan")
                rw.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                'rw.Item("tinggi") = sqldr.Item("tinggi")
                'rw.Item("panjang") = sqldr.Item("panjang")
                'rw.Item("lebar") = sqldr.Item("lebar")
                rw.Item("qty_order") = sqldr.Item("qty_sisa_retur")
                rw.Item("qty_sisa") = 0
                rw.Item("gudang_asal") = "G0000"
                rw.Item("gudang_tujuan") = sqldr.Item("lokasi")
                'rw.Item("qty_in") = sqldr.Item("qty_sisa_retur")
                rw.Item("harga") = sqldr.Item("harga")
                'rw.Item("rp_trans") = sqldr.Item("harga") * sqldr.Item("qty_sisa_retur")
                rw.Item("qty_qc_pass") = sqldr.Item("qty_sisa_retur")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")

                dSO1.Tables("_qc").Rows.Add(rw)
                TxbPenerima.EditValue = supp
                'p_np = sqldr.Item("flag_ppn")
            End While
            sqldr.Close()
            TxbBarcode.Focus()
            GvINV_Ret.FocusedColumn = GvINV_Ret.VisibleColumns(4)
        End If

    End Sub

    Private Sub GvINV_Ret_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvINV_Ret.CellValueChanged
        If e.Column Is qty_qc_pass Then
            If GvINV_Ret.GetRow(e.RowHandle).item("qty_qc_pass") > GvINV_Ret.GetRow(e.RowHandle).item("qty_order") Then
                MsgBox(" Quantiti Masuk tidak boleh melebihi order retur")
                GvINV_Ret.GetRow(e.RowHandle).item("qty_out") = 0
                Exit Sub
            Else
                GvINV_Ret.GetRow(e.RowHandle).item("rp_trans") = GvINV_Ret.GetRow(e.RowHandle).item("harga") * GvINV_Ret.GetRow(e.RowHandle).item("qty_qc_pass")
                GvINV_Ret.GetRow(e.RowHandle).item("qty_sisa") = GvINV_Ret.GetRow(e.RowHandle).item("qty_order") - GvINV_Ret.GetRow(e.RowHandle).item("qty_qc_pass")
                'GvINV_Ret.GetRow(e.RowHandle).item("qty_sisa_retur") = GvINV_Ret.GetRow(e.RowHandle).item("qty_out")

            End If
        End If
    End Sub

    Private Sub LookupNoRetur_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupNoRetur.QueryPopUp
        'ds_cari1.Clear()
        If STATE = "EDIT" Then e.Cancel = True
        ds_cari1.Clear()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct gdo.no_trans, gdo.no_ref from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans where substring((gdo.no_trans),12,3)='RTR' and (gdod.qty_sisa_retur is null or gdod.qty_sisa_retur > 0) AND gdo.no_trans IN (SELECT a.no_trans FROM INV.dbo.INV_GUDANG_OUT a, PURC.dbo.PURC_RETUR_BELI b WHERE a.no_ref = b.no_retur AND a.no_trans = gdo.no_trans AND b.status = 'Y')", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookupRTO")
        LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_lookupRTO")
        LookupNoRetur.Properties.ValueMember = "no_trans"
        LookupNoRetur.Properties.DisplayMember = "no_trans"
    End Sub
End Class