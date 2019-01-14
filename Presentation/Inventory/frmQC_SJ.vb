'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmQC_SJ
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    'Private thn As String = getTanggal.Year
    'Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, stathold As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dso, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private rw As DataRow
    Private DA, DA2, DA_gdg1, DA_gdg2, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
    Private e As System.EventArgs

    Public Sub add_click()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD"
        'dtpTgl.EditValue = getTanggal()
        'bersihkan()
        'LookupGudang.EditValue = "G0000"
        '<-- set state add
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
        If GvBME_d.Columns("qty_qc_pass").SummaryItem.SummaryValue > GvBME_d.Columns("qty_order").SummaryItem.SummaryValue Then
            MsgBox("Qty QC Good melebihi Qty Order, Silahkan Cek lagi nilai entrian")
            Exit Sub
        End If

        If GvBME_d.Columns(4).SummaryItem.SummaryValue - (GvBME_d.Columns(5).SummaryItem.SummaryValue + GvBME_d.Columns(6).SummaryItem.SummaryValue + GvBME_d.Columns(7).SummaryItem.SummaryValue) <> 0 Then
            MsgBox("Data tidak klop," & vbCrLf & "Jumlah Barang yang di QC harus sama dengan barang KEMBALI(qty order)", MsgBoxStyle.Information)
            Exit Sub
        End If
        If LookupSJ.EditValue = vbNullString Then
            MsgBox(" Nomer SJ tidak boleh kosong", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
        bersihkan()
    End Sub

    Public Sub cancel_click()
        'LoadStruktur("XXX")
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
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct(no_trans) from INV.dbo.INV_QC_M", sqlconn)) '
        If Not dSO1.Tables("lookup_qc") Is Nothing Then dSO1.Tables("lookup_qc").Clear()
        DA2.Fill(dSO1, "lookup_qc")
        frmCari.set_dso(dSO1.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'txbSJSupplier.Enabled = False
            load_sj()
            LoadStruktur(frmCari.row(0))
            If frmCari.row.Item("cetak_ulang") = "Y" Then
                frmMain.btnCetak.Enabled = True
                'MsgBox("cetak")
            ElseIf frmCari.row.Item("cetak_ulang") = "T" Then
                frmMain.btnCetak.Enabled = False
                'MsgBox("no cetak")
            End If

            If frmCari.row.Item("Status_Masuk_Gudang").ToString = True Then
                btnSave = False
                'txbSJSupplier.Enabled = False
                LookupSJ.Enabled = False
                STATE = "EDIT"
                Me.Enabled = True
                setStatus()
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
            ElseIf frmCari.row.Item("Status_Masuk_Gudang").ToString = False Then
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                btnSave = True
                STATE = "EDIT"
                Me.Enabled = True
                setStatus()
                'LookupPO.Enabled = False
                'txbSJSupplier.Enabled = True

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


            If STATE = "ADD" Then
                rw = dso.Tables("_qcm").NewRow
                rw.Item("Last_Create_Date") = getTanggal()
                rw.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                rw = dso.Tables("_bme").Rows(0)
                rw.Item("Last_Update_Date") = getTanggal()
                rw.Item("Last_Updated_By") = username
            End If
            rw.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            rw.Item("trx_stat") = 0
            rw.Item("no_ref") = LookupSJ.EditValue
            rw.Item("no_trans") = getNoTrans("QCSJ", getTanggal(BTRANS), BTRANS)
            rw.Item("tgl_trans") = getTanggal()
            rw.Item("jml_rp_trans") = GvBME_d.Columns(9).SummaryItem.SummaryValue
            rw.Item("blthn") = blthn(BTRANS)

            rw.Item("Program_Name") = Me.Name
            'txbNoTrans.Text = row.Item("no_trans")
            If STATE = "ADD" Then
                dso.Tables("_qcm").Rows.Add(rw)
            End If



            For Each row As DataRow In dSO1.Tables("_qc").Rows
                If row.RowState = DataRowState.Added Then
                    'row1.Item("no_trans") = row.Item("no_trans")
                    'row1.Item("tipe_trans") = row.Item("tipe_trans")
                    row.Item("tgl_trans") = getTanggal()
                    'row.Item("tgl_approve") = row.Item("tgl_trans") 'biar program ga berat gan,,,, request terus gettanggal
                    row.Item("no_ref") = LookupSJ.EditValue
                    row.Item("Last_Create_Date") = row.Item("tgl_trans")
                    row.Item("Last_Created_By") = username
                    row.Item("kd_Cabang") = kdcabang
                    'row.Item(" _stat") = 0
                Else

                    row.Item("Last_Update_Date") = getTanggal()
                    row.Item("Last_Updated_By") = username
                End If
                row.Item("Program_name") = Me.Name
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

            'nomer = getNoTrans("QC", getTanggal(BTRANS), BTRANS)
            If STATE = "ADD" Then
                For Each row As DataRow In dSO1.Tables("_qc").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("no_trans") = rw.Item("no_trans")
                        row.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            txbNoTrans.Text = rw.Item("no_trans")
            'update sisa di tbl po_d

            DA.Update(dso.Tables("_qcm"))
            DA2.Update(dSO1.Tables("_qc"))
            'If STATE = "ADD" Then

            For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                'If row1.RowState = DataRowState.Added Then
                Dim sqlcmd As New SqlCommand("update SALES.dbo.SALES_SJ_D set sudah_qc=1 where no_sj='" & LookupSJ.EditValue & "' and kd_stok='" & row1("kd_stok") & "'", sqlconn, BTRANS)
                sqlcmd.ExecuteNonQuery()
            Next

            For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                If row1("qty_good") <> 0 Then
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_good"), BTRANS)
                End If

                If row1("qty_qc_service") <> 0 Then
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_asal").ToString, "G0008", row1("qty_qc_service"), BTRANS)
                End If

                If row1("qty_qc_rusak") <> 0 Then
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_asal").ToString, "G0009", row1("qty_qc_rusak"), BTRANS)
                End If
            Next
            ''sp1
            'For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_in"), BTRANS)
            '    End If
            'Next
            '' ## sp 2
            'For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("jml_trans"), BTRANS)
            '    End If
            'Next

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            STATE = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables("_qc").RejectChanges()
            dso.Tables("_qcm").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try
        'dSO1.Tables("_qc").Clear()

    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal, 32).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\QC.rpt", "", "no_qc=" & txbNoTrans.Text)
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
        txbNoTrans.Text = ""
        'dtpTgl.EditValue = vbNullString
        LookupSJ.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
        'Me.OnLoad(e)
        LoadStruktur("xxx")

    End Sub

    Private Sub LoadStruktur(ByVal kodepo As String)
        'If Not dSO.Tables("_bme") Is Nothing Then dSO.Tables("_bme").Clear()
        If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC where no_trans='" & kodepo & "'", sqlconn))
        DA2.Fill(dSO1, "_qc")
        GcBME_d.DataSource = dSO1.Tables("_qc")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kodepo & "'", sqlconn))
        DA.Fill(dso, "_qcm")
        'GcBME_d.DataSource = dso.Tables("_qcm")

        If dSO1.Tables("_qc").Rows.Count > 0 Then
            Dim rw As DataRow = dSO1.Tables("_qc").Rows(0)
            'txbNoRef.Text = rw("no_ref").ToString
            txbNoTrans.Text = rw("no_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            LookupSJ.EditValue = rw("no_po").ToString
        End If


    End Sub
    Public Sub load_sj()
        If STATE = "ADD" Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT(no_sj) from SALES.dbo.SALES_SJ_D where qty_balik<>0 and sudah_qc=0", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupSJ.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupSJ.Properties.ValueMember = "no_sj"
            LookupSJ.Properties.DisplayMember = "no_sj"
        ElseIf STATE = "EDIT" Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct(no_trans) from INV.dbo.INV_QC_M", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupSJ.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupSJ.Properties.ValueMember = "no_sj"
            LookupSJ.Properties.DisplayMember = "no_sj"

        End If
        
    End Sub

    Private Sub frmQC_SJ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prn = getParent(Me)
        GvBME_d.Columns("harga").Visible = False
        GvBME_d.Columns("rp_trans").Visible = False
        'GvBME_d.Columns("qty_qc_rusak").Visible = False
        'GvBME_d.Columns("qty_qc_service").Visible = False

        LoadStruktur("xxxxx")
        formate_yayak()
        load_sj()
        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.DBO.SIF_Gudang", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup")
        'LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup")

        

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

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
    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvBME_d.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_qc_pass").DisplayFormat.FormatString = "n3"
        GvBME_d.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_order").DisplayFormat.FormatString = "n3"
        GvBME_d.Columns("qty_qc_service").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_qc_service").DisplayFormat.FormatString = "n3"
        GvBME_d.Columns("qty_qc_rusak").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_qc_rusak").DisplayFormat.FormatString = "n3"
    End Sub


    Private Sub LookupSJ_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSJ.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("select sj.no_sj,sj.No_sp,sj.Kd_stok,sj.Kd_satuan,sj.Qty_balik,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,*  from SALES.dbo.SALES_SJ_D as sj LEFT JOIN SIF.dbo.SIF_Barang as brg on sj.Kd_stok=brg.Kode_Barang where sj.qty_balik<>0 and sj.sudah_qc=0 and sj.no_sj='" & LookupSJ.EditValue & "'", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_qc").Clear()

            While sqdr.Read
                Dim rw1 As DataRow = dSO1.Tables("_qc").NewRow
                rw1.Item("Kd_Cabang") = kdcabang
                'rw.Item("tipe_trans") = "JPU-KUT-01"
                rw1.Item("no_seq") = i : i += 1
                rw1.Item("kd_stok") = sqdr.Item("kd_stok")
                rw1.Item("kd_satuan") = sqdr.Item("Kd_satuan")
                rw1.Item("qty_order") = sqdr.Item("Qty_balik")
                rw1.Item("gudang_asal") = "G0007"
                rw1.Item("gudang_tujuan") = sqdr.Item("lokasi")
                'rw1.Item("qty_qc_pass") = 0
                'rw1.Item("qty_qc_rusak") = 0
                'rw1.Item("harga") = sqdr.Item("harga")
                rw1.Item("kd_buku_besar") = sqdr.Item("rek_persediaan")
                rw1.Item("kd_buku_biaya") = sqdr.Item("rek_biaya")
                dSO1.Tables("_qc").Rows.Add(rw1)

            End While

            sqdr.Close()
            GvBME_d.FocusedColumn = GvBME_d.VisibleColumns(4)
        End If
    End Sub

    Private Sub GvBME_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBME_d.CellValueChanged
        If e.Column Is qty_qc_pass Then
            If GvBME_d.GetRow(e.RowHandle).item("qty_qc_pass") > GvBME_d.GetRow(e.RowHandle).item("qty_order") Then
                MsgBox("Qty Good tidak boleh melebihi barang yg kembali")
                GvBME_d.GetRow(e.RowHandle).item("qty_qc_pass") = 0
                GvBME_d.GetRow(e.RowHandle).item("qty_qc_rusak") = 0
                GvBME_d.GetRow(e.RowHandle).item("qty_qc_service") = 0

            End If
        End If
    End Sub

    Private Sub LookupSJ_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupSJ.QueryPopUp
        If STATE = "EDIT" Then e.Cancel = True

        ds_cari.Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT(no_sj) from SALES.dbo.SALES_SJ_D where qty_balik<>0 and sudah_qc=0", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupSJ.Properties.DataSource = ds_cari.Tables("_lookup1")
        LookupSJ.Properties.ValueMember = "no_sj"
        LookupSJ.Properties.DisplayMember = "no_sj"
    End Sub
End Class
