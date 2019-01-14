'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmQC_returExt
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public btnCetak As Boolean
    'Private thn As String = getTanggal.Year
    'Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Private STATE, stathold, p_np As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dso, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_gdg1, ds_gdg2, ds_palsu As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private rw As DataRow
    Dim sisa_asli As Decimal
    Private DA, DA2, DA_gdg1, DA_gdg2, DALOOKUP, DALOOKUP1, DALOOKUP2, DA_palsu As SqlClient.SqlDataAdapter
    Private e As System.EventArgs
    Private BTRAN As SqlTransaction

    Public Sub add_click()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD"
        txbSJSupplier.Text = ""
        'load_toko()
        'LoadStruktur("xxx")
        'lookPO()
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
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        'For Each
        If GvQCsvc.Columns("qty_qc_pass").SummaryItem.SummaryValue > GvQCsvc.Columns("qty_order").SummaryItem.SummaryValue Then
            MsgBox("Qty QC Good melebihi Qty Order, Silahkan Cek lagi nilai entrian")
            Exit Sub
        End If

        If STATE = "BATAL" Then 'JIKA PEMBATALAN
            If MsgBox("Pembatalan akan dilakukan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        End If

        If Not isDel Then
            If txbSJSupplier.Text = "" Then
                MsgBox("Nama Penerima masih kosong")
                Exit Sub
            End If

            If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
        Else
            simpan(isDel)
        End If
        'cancel_click()

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

    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [No QC],tgl_trans as Tanggal,no_ref ,Last_Created_By as [Petugas QC],case when trx_stat=0 then 'Belum Masuk Gudang' when trx_stat=1 then 'Sudah Masuk Gudang' end as Status_Masuk_Gudang,cetak_ulang from INV.dbo.INV_QC_M where no_trans like '%RTR%' and not exists (select 1 from inv.dbo.inv_gudang_in where INV.dbo.INV_QC_M.no_trans=no_qc)", sqlconn))
        If Not dSO1.Tables("lookup_qc") Is Nothing Then dSO1.Tables("lookup_qc").Clear()
        DA2.Fill(dSO1, "lookup_qc")
        frmCari.set_dso(dSO1.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txbSJSupplier.Enabled = False
            load_toko()
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
                txbSJSupplier.Enabled = True

            Else
                cancel_click()
                'LookupPO.Enabled = False
                STATE = ""
            End If
            btnCetak = True
            setStatus()
        End If
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        For Each row As DataRow In dSO1.Tables("_qc").Select("qty_order = qty_sisa and qty_qc_unpass=0")
            row.Delete()
        Next

        If LookupCust.EditValue = "" Then
            MsgBox("Customer belum diisi")
            LookupCust.Focus()
            Exit Sub
        End If
        If GvQCsvc.RowCount = 0 Then
            MsgBox("Barang belum diisi")
            GvQCsvc.Focus()
            Exit Sub
        End If

        If Not isDelete Then
            If STATE = "ADD" Then
                rw = dso.Tables("_qcm").NewRow
                rw.Item("Last_Create_Date") = getTanggal()
                rw.Item("Last_Created_By") = username
                rw.Item("Last_Updated_By") = username
                rw.Item("no_trans") = getNoTrans("QC-RTR", getTanggal(BTRANS), BTRANS)
                rw.Item("tgl_trans") = tgl_retur.EditValue
                rw.Item("blthn") = blthn(BTRANS)
                rw.Item("cetak_ke") = 0
                rw.Item("cetak_ulang") = "Y"
            ElseIf STATE = "EDIT" Then
                rw = dso.Tables("_qcm").Rows(0)
                rw.Item("Last_Update_Date") = getTanggal()
                rw.Item("Last_Updated_By") = username

            ElseIf STATE = "CETAK" Then
                rw.Item("cetak_ke") = rw.Item("cetak_ke") + 1

            End If
            'rw.Item("cetak_ulang") = "T"
            rw.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            rw.Item("trx_stat") = 0
            rw.Item("no_ref") = txbToko.Text
            rw.Item("p_np") = 0
            rw.Item("kd_supplier") = LookupCust.EditValue
            rw.Item("jml_rp_trans") = dSO1.Tables("_qc").Compute("sum(rp_trans)", "")
            rw.Item("penyerah") = txbSJSupplier.Text
            rw.Item("Program_Name") = Me.Name
            'txbNoTrans.Text = row.Item("no_trans")
            If STATE = "ADD" Then
                dso.Tables("_qcm").Rows.Add(rw)
            End If

            For Each row As DataRow In dSO1.Tables("_qc").Rows
                If row.RowState = DataRowState.Added Then
                    row.Item("tgl_trans") = tgl_retur.EditValue
                    row.Item("tipe_trans") = ReturGudangIn
                    row.Item("no_ref") = txbToko.Text
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
                        row.Item("tipe_trans") = ReturGudangIn
                        row.Item("no_trans") = rw.Item("no_trans")
                        row.Item("blthn") = rw.Item("blthn")
                    End If
                Next
            End If

            If Not STATE = "DELETE" Then
                txbNoTrans.Text = rw.Item("no_trans")

                DA.Update(dso.Tables("_qcm"))
                DA2.Update(dSO1.Tables("_qc"))

                'Dim sqlcmd As New SqlCommand("exec inv.dbo.closeRetur '" & LookupSO.EditValue & "', '" & txbNoTrans.Text & "'", sqlconn, BTRANS)
                'sqlcmd.ExecuteNonQuery()

            Else

                DA.Update(dso.Tables("_qcm"))
                DA2.Update(dSO1.Tables("_qc"))
            End If

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            STATE = "EDIT"
            btnCancel = True
            btnCetak = True
            btnDelete = True
            setStatus()

        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables("_qc").RejectChanges()
            dso.Tables("_qcm").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try
        'dSO1.Tables("_qc").Clear()
    End Sub

    Public Sub cetak_click()
        'If STATE = "EDIT" Then
        'STATE = "CETAK"
        'simpan()
        'End If
        callReport(App_Path() & "\report\QC_Retur_Jual.rpt", "", "no_qc=" & txbNoTrans.Text, False, False)
        Dim sqcmd As New SqlCommand("update INV.dbo.INV_QC_M set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()

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
        'txbNoRef.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
        'Me.OnLoad(e)
        LoadStruktur("xxx")

    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvQCsvc.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_order").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("qty_qc_service").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_qc_service").DisplayFormat.FormatString = "n2"
    End Sub

    Private Sub LoadStruktur(ByVal kodepo As String)
        If Not dso.Tables("_qcm") Is Nothing Then dso.Tables("_qcm").Clear()
        If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC where no_trans='" & kodepo & "'", sqlconn))
        DA2.Fill(dSO1, "_qc")
        GcQCsvc.DataSource = dSO1.Tables("_qc")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kodepo & "'", sqlconn))
        DA.Fill(dso, "_qcm")

        If dso.Tables("_qcm").Rows.Count > 0 Then
            Dim rwm As DataRow = dso.Tables("_qcm").Rows(0)
            'txbNoRef.Text = rw("no_ref").ToString
            txbNoTrans.Text = rwm("no_trans").ToString
            txbToko.Text = rwm("no_ref").ToString
            tgl_retur.EditValue = rwm("tgl_trans").ToString
            txbSJSupplier.Text = rwm("penyerah").ToString
            LookupCust.EditValue = rwm("kd_supplier").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'LookupPO2.EditValue = rw("no_ref").ToString

            'MsgBox(rw("no_ref").ToString)
        End If
    End Sub

    Private Sub frmQC_returExt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        prn = getParent(Me)

        LoadStruktur("xxxxx")
        formate_yayak()

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct POD.no_po as no_ref FROM PURC.dbo.PURC_PO_D POD, PURC.dbo.PURC_PO PO where POD.no_po=PO.no_PO and POD.qty_sisa <> 0 and PO.rec_stat = 'APPROVE'", sqlconn))
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select nilai_rata, kd_stok from inv.dbo.inv_stok_saldo where bultah = '" & blthn() & "'", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "hpp")
        tgl_retur.EditValue = getTanggal()

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang, kd_satuan, lokasi, rek_persediaan, rek_biaya from SIF.dbo.SIF_Barang where isnull(rec_stat,'') = 'Y' and kd_jns_persd in ('1','2','3') order by Nama_Barang", sqlconn))
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

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer where rec_stat='Y' order by Nama_Customer", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup2")
        'LookupCust.Properties.DataSource = ds_cari1.Tables("_lookup2")
        'LookupCust.Properties.ValueMember = "Kd_Customer"
        'LookupCust.Properties.DisplayMember = "Nama_Customer"
        load_toko()

        btnadd = True
        btnEdit = True
        setStatus()
    End Sub
    Public Sub load_toko()
        If STATE = "ADD" Then
            If Not ds_cari1.Tables("_lookup2") Is Nothing Then ds_cari1.Tables("_lookup2").Clear()
            DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer where rec_stat='Y' order by Nama_Customer", sqlconn))
            DALOOKUP1.Fill(ds_cari1, "_lookup2")
            LookupCust.Properties.DataSource = ds_cari1.Tables("_lookup2")
            LookupCust.Properties.ValueMember = "Kd_Customer"
            LookupCust.Properties.DisplayMember = "Nama_Customer"
        ElseIf STATE = "EDIT" Then
            If Not ds_cari1.Tables("_lookup2") Is Nothing Then ds_cari1.Tables("_lookup2").Clear()
            DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer order by Nama_Customer", sqlconn))
            DALOOKUP1.Fill(ds_cari1, "_lookup2")
            LookupCust.Properties.DataSource = ds_cari1.Tables("_lookup2")
            LookupCust.Properties.ValueMember = "Kd_Customer"
            LookupCust.Properties.DisplayMember = "Nama_Customer"
        Else
            If Not ds_cari1.Tables("_lookup2") Is Nothing Then ds_cari1.Tables("_lookup2").Clear()
            DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer where rec_stat='Y' order by Nama_Customer", sqlconn))
            DALOOKUP1.Fill(ds_cari1, "_lookup2")
            LookupCust.Properties.DataSource = ds_cari1.Tables("_lookup2")
            LookupCust.Properties.ValueMember = "Kd_Customer"
            LookupCust.Properties.DisplayMember = "Nama_Customer"
        End If
    End Sub

    Private Sub GvQCsvc_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvQCsvc.CellValueChanged
        If e.Column Is kd_stok Then
            With ds_cari2.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")
                If .Count > 0 Then
                    GvQCsvc.SetRowCellValue(e.RowHandle, "kd_satuan", .ElementAt(0)("kd_satuan"))
                    GvQCsvc.SetRowCellValue(e.RowHandle, "gudang_tujuan", .ElementAt(0)("lokasi"))
                    GvQCsvc.SetRowCellValue(e.RowHandle, "kd_buku_besar", .ElementAt(0)("rek_persediaan"))
                    GvQCsvc.SetRowCellValue(e.RowHandle, "kd_buku_biaya", .ElementAt(0)("rek_biaya"))
                Else
                    GvQCsvc.SetRowCellValue(e.RowHandle, "kd_satuan", "N/A")
                End If
            End With
            With ds_cari2.Tables("hpp").Select("kd_stok='" & e.Value & "'")
                If .Count > 0 Then
                    GvQCsvc.SetRowCellValue(e.RowHandle, "harga", .ElementAt(0)("nilai_rata"))
                    GvQCsvc.SetRowCellValue(e.RowHandle, "rp_trans", .ElementAt(0)("nilai_rata") * GvQCsvc.GetRowCellValue(e.RowHandle, "qty_qc_pass"))
                Else
                    GvQCsvc.SetRowCellValue(e.RowHandle, "harga", "0")
                    GvQCsvc.SetRowCellValue(e.RowHandle, "rp_trans", 0)
                End If
            End With
        ElseIf e.Column Is qty_qc_pass Then
            GvQCsvc.SetRowCellValue(e.RowHandle, "rp_trans", GvQCsvc.GetRowCellValue(e.RowHandle, "harga") * e.Value)
            GvQCsvc.SetRowCellValue(e.RowHandle, "qty_order", e.Value)
            GvQCsvc.SetRowCellValue(e.RowHandle, "TotalQC", e.Value)
        End If
    End Sub

    Private Sub GvQCsvc_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvQCsvc.InitNewRow
        GvQCsvc.SetRowCellValue(e.RowHandle, "harga", 0)
        GvQCsvc.SetRowCellValue(e.RowHandle, "qty_qc_pass", 0)
        GvQCsvc.SetRowCellValue(e.RowHandle, "qty_order", 0)
        GvQCsvc.SetRowCellValue(e.RowHandle, "rp_trans", 0)
        GvQCsvc.SetRowCellValue(e.RowHandle, "no_seq", GvQCsvc.RowCount)
        GvQCsvc.SetRowCellValue(e.RowHandle, "qty_qc_unpass", 0)
        GvQCsvc.SetRowCellValue(e.RowHandle, "qty_qc_service", 0)
    End Sub

    Private Sub GvQCsvc_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvQCsvc.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvQCsvc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GvQCsvc.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GvQCsvc.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar") = MsgBoxResult.Yes Then
                    GvQCsvc.DeleteSelectedRows()
                    Dim i As Int16 = 1
                    For Each item As DataRow In dSO1.Tables("_qc").Rows
                        If Not item.RowState = DataRowState.Deleted Then
                            item("no_seq") = i
                            i += 1
                        End If
                    Next

                End If
            End If
        End If
    End Sub

    Private Sub GvQCsvc_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvQCsvc.ValidateRow
        Dim isvalid As Boolean = True
        If GvQCsvc.GetRowCellValue(e.RowHandle, "qty_qc_pass") Is Nothing Then
            isvalid = False
            GvQCsvc.SetColumnError(qty_qc_pass, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvQCsvc.FocusedColumn = qty_qc_pass
        ElseIf GvQCsvc.GetRowCellValue(e.RowHandle, "qty_qc_pass") <= 0 Then
            isvalid = False
            GvQCsvc.SetColumnError(qty_qc_pass, "Jumlah QC dengan benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvQCsvc.FocusedColumn = qty_qc_pass
        ElseIf GvQCsvc.GetRowCellValue(e.RowHandle, "qty_qc_pass") > 0 Then
            If GvQCsvc.GetRowCellValue(e.RowHandle, "kd_stok") Is Nothing Then
                GvQCsvc.SetColumnError(kd_stok, "Harap mengisi barang dahulu", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GvQCsvc.FocusedColumn = kd_stok
            End If
        End If

        e.Valid = isvalid
    End Sub

End Class