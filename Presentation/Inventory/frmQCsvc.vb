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


Public Class frmQCsvc
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
        LookupPO.Enabled = True
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
            '.btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        'For Each
        If STATE = "BATAL" Then 'JIKA PEMBATALAN
            If MsgBox("Pembatalan akan dilakukan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        End If
        If GvQCsvc.Columns("qty_qc_pass").SummaryItem.SummaryValue > GvQCsvc.Columns("qty_order").SummaryItem.SummaryValue Then
            MsgBox("Qty QC Good melebihi Qty Order, Silahkan Cek lagi nilai entrian")
            Exit Sub
        End If

        'If dSO1.Tables("_qc").Select("[qty_qc_pass] is null").Count > 0 Then
        'MsgBox("Qty Datang atau Qty Pass Tidak boleh kosong", MsgBoxStyle.Critical)
        'Exit Sub
        'End If
        If LookupPO.EditValue = vbNullString Then
            MsgBox(" Nomer PO / Gudang Tujuan dahulu! Tidak Boleh kosong", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Not isDel Then
            If txbSJSupplier.Text = "" Then
                MsgBox("Surat Jalan Supplier Harap di isi/dilengkapi sebelum menyimpan!!")
                txbSJSupplier.Focus()
                Exit Sub
            End If
            If txbSJSupplier.Text = LookupPO.Text Then
                MsgBox("Surat Jalan Supplier Tidak Boleh Sama Dengan Nomor PO")
                txbSJSupplier.Focus()
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
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [No QC],tgl_trans as Tanggal,no_ref as no_po,Last_Created_By as [Petugas QC],case when trx_stat=0 then 'Belum Masuk Gudang' when trx_stat=1 then 'Sudah Masuk Gudang' end as Status_Masuk_Gudang,,cetak_ulang from INV.dbo.INV_QC_M where SUBSTRING(no_trans,14,1)='J' ", sqlconn))
        If Not dSO1.Tables("lookup_qc") Is Nothing Then dSO1.Tables("lookup_qc").Clear()
        DA2.Fill(dSO1, "lookup_qc")
        frmCari.set_dso(dSO1.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txbSJSupplier.Enabled = False
            load_po()
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
                LookupPO.Enabled = False
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
        End If
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        'For Each row As DataRow In dSO1.Tables("_qc").Rows
        '    If row.Item("qty_order") = row.Item("qty_sisa") Then
        '        row.Delete()
        '    End If
        'Next
        For Each row As DataRow In dSO1.Tables("_qc").Select("qty_order = qty_sisa")
            row.Delete()
        Next
        If Not isDelete Then
            If STATE = "ADD" Then
                rw = dso.Tables("_qcm").NewRow
                rw.Item("Last_Create_Date") = getTanggal()
                rw.Item("Last_Created_By") = username
                rw.Item("Last_Updated_By") = username
                rw.Item("no_trans") = getNoTrans("QCJ", getTanggal(BTRANS), BTRANS)
                rw.Item("tgl_trans") = getTanggal()
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
            rw.Item("no_ref") = LookupPO.EditValue
            rw.Item("p_np") = p_np
            rw.Item("jml_rp_trans") = GvQCsvc.Columns(10).SummaryItem.SummaryValue
            rw.Item("sj_supplier") = txbSJSupplier.Text
            rw.Item("Program_Name") = Me.Name
            'txbNoTrans.Text = row.Item("no_trans")
            If STATE = "ADD" Then
                dso.Tables("_qcm").Rows.Add(rw)
            End If

            'STR PROSEDUR
            str_stsPO(rw("no_ref").ToString, BTRANS)
            'end

            For Each row As DataRow In dSO1.Tables("_qc").Rows
                If row.RowState = DataRowState.Added Then
                    row.Item("tgl_trans") = getTanggal()
                    row.Item("no_ref") = LookupPO.EditValue
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

            If Not STATE = "DELETE" Then
                txbNoTrans.Text = rw.Item("no_trans")
                'update sisa di tbl po_d

                DA.Update(dso.Tables("_qcm"))
                DA2.Update(dSO1.Tables("_qc"))
                'If STATE = "ADD" Then
                For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                    'If row1.RowState = DataRowState.Added Then
                    Dim sqlcmd As New SqlCommand("update PURC.dbo.PURC_PO_D set qty_sisa=@nilai where no_po='" & LookupPO.EditValue & "' and kd_stok='" & row1("kd_stok") & "' and keterangan='" & row1("keterangan") & "'", sqlconn, BTRANS)
                    sqlcmd.Parameters.AddWithValue("@nilai", row1.Item("qty_sisa"))
                    sqlcmd.ExecuteNonQuery()

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


            Else

                DA.Update(dso.Tables("_qcm"))
                DA2.Update(dSO1.Tables("_qc"))
            End If

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            'STATE = "EDIT"
            frmMain.btnSave.Enabled = False
            frmMain.btnAdd.Enabled = True

        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables("_qc").RejectChanges()
            dso.Tables("_qcm").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try
        'dSO1.Tables("_qc").Clear()

    End Sub
    Public Sub str_stsPO(ByVal no_refx As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PURC.dbo.proses_sts_po"
        sqlCmd.Parameters.Add("@xno_po", SqlDbType.VarChar, 25).Value = no_refx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cetak_click()
        'If STATE = "EDIT" Then
        'STATE = "CETAK"
        'simpan()
        'End If
        callReport(App_Path() & "\report\QC.rpt", "", "no_qc=" & txbNoTrans.Text, False, False)
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
        LookupPO.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
        'Me.OnLoad(e)
        LoadStruktur("xxx")

    End Sub

    'Private Sub lookPO()
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct POD.no_po as no_ref FROM PURC.dbo.PURC_PO_D POD, PURC.dbo.PURC_PO PO where POD.no_po=PO.no_PO and POD.qty_sisa <> 0 and PO.rec_stat = 'APPROVE'", sqlconn))
    '    DALOOKUP.Fill(ds_cari, "_lookup1")
    '    LookupPO.Properties.DataSource = ds_cari.Tables("_lookup1")
    '    LookupPO.Properties.ValueMember = "no_ref"
    '    LookupPO.Properties.DisplayMember = "no_ref"
    'End Sub

    Private Sub frmQCsvc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        prn = getParent(Me)
        GvQCsvc.Columns("harga").Visible = False
        GvQCsvc.Columns("rp_trans").Visible = False
        GvQCsvc.Columns("status_hold").Visible = False

        LoadStruktur("xxxxx")
        formate_yayak()

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct POD.no_po as no_ref FROM PURC.dbo.PURC_PO_D POD, PURC.dbo.PURC_PO PO where POD.no_po=PO.no_PO and POD.qty_sisa <> 0 and PO.rec_stat = 'APPROVE'", sqlconn))
        



        'DA_palsu = New SqlDataAdapter(New SqlCommand("SELECT distinct no_ref FROM INV.dbo.INV_QC_M", sqlconn))
        'DA_palsu.Fill(ds_palsu, "_lookup1")
        'LookupPO2.Properties.DataSource = ds_palsu.Tables("_lookup1")
        'LookupPO2.Properties.ValueMember = "no_ref"
        'LookupPO2.Properties.DisplayMember = "no_ref"

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

        load_po()

    End Sub
    Private Sub load_po()
        If STATE = "ADD" Then
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct (no_po) from(select po.rec_stat, po.no_po,po.flag_ppn,pod.kd_stok,pod.keterangan,pod.kd_satuan,pod.harga,(select qty_order from INV.dbo.v_saldo_qc_pass_jasa where no_po= po.no_po and kd_stok=pod.kd_stok and no_seq=pod.no_seq)as qty_ordered, pod.qty,pod.qty_sisa, brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya, 0 as qty_qc_pass from PURC.DBO.PURC_PO_D_BARANG pod inner join PURC.DBO.PURC_PO po on pod.no_po=po.no_po inner join SIF.dbo.SIF_Barang brg on pod.kd_stok=brg.Kode_Barang where po.rec_stat='APPROVE')a where a.qty_ordered is not null", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupPO.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupPO.Properties.ValueMember = "no_po"
            LookupPO.Properties.DisplayMember = "no_po"
        ElseIf STATE = "EDIT" Then
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct (no_ref)as no_po  from INV.dbo.INV_QC_M", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupPO.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupPO.Properties.ValueMember = "no_po"
            LookupPO.Properties.DisplayMember = "no_po"
        End If
        
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvQCsvc.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_order").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("hold").DisplayFormat.FormatString = "n2"
        GvQCsvc.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCsvc.Columns("qty_sisa").DisplayFormat.FormatString = "n2"
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
            txbSJSupplier.Text = rwm("sj_supplier").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            LookupPO.EditValue = rwm("no_ref").ToString
            'LookupPO2.EditValue = rw("no_ref").ToString

            'MsgBox(rw("no_ref").ToString)
        End If
    End Sub

    Private Sub GvQCsvc_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvQCsvc.CellValueChanged
        
        If e.Column Is qty_qc_pass Then

            If GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass") > GvQCsvc.GetRow(e.RowHandle).item("qty_order") And GvQCsvc.GetRow(e.RowHandle).item("qty_order") = GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") Then
                If MsgBox("Barang Quantity Good lebih besar dari Order, apakah dilanjutkan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") = 0
                    GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass") = GvQCsvc.GetRow(e.RowHandle).item("qty_order")
                    Exit Sub
                Else
                    GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass") = 0
                End If

            End If
            GvQCsvc.GetRow(e.RowHandle).item("rp_trans") = GvQCsvc.GetRow(e.RowHandle).item("harga").ToString * GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass").ToString
            GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") = GvQCsvc.GetRow(e.RowHandle).item("qty_order") - GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass")
        End If
        'If GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") <> GvQCsvc.GetRow(e.RowHandle).item("qty_order") Then

        'Else
        '    GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") = GvQCsvc.GetRow(e.RowHandle).item("qty_order") - GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass")
        'End If


        If e.Column Is hold Then
            If GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") = 0 Then
                GvQCsvc.GetRow(e.RowHandle).item("status_hold") = "Over Order"
            ElseIf GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") > 0 Then
                GvQCsvc.GetRow(e.RowHandle).item("status_hold") = "Quality Issue"
            End If

            'If GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") <> 0 Then
            '    If GvQCsvc.GetRow(e.RowHandle).item("hold") + GvQCsvc.GetRow(e.RowHandle).item("qty_qc_pass") > GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") Then
            '        hold_po = GvQCsvc.GetRow(e.RowHandle).item("hold") - GvQCsvc.GetRow(e.RowHandle).item("qty_sisa")
            '        MsgBox("Barang HOLD telah memenuhi PO/Order! " & vbCrLf & "Untuk Barang Sisa yang Hold Sebanyak " & hold_po & " Silahkan di entry menggunakan form Entry Barang HOLD", MsgBoxStyle.Information, "MOHON DIBACA!!!")
            '        GvQCsvc.GetRow(e.RowHandle).item("hold") = GvQCsvc.GetRow(e.RowHandle).item("qty_sisa")
            '        GvQCsvc.GetRow(e.RowHandle).item("qty_sisa") = 0
            '        'Else

            '    End If
            'End If

        End If
    End Sub

    Private Sub LookupPO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupPO.EditValueChanged
        'Dim x As Double
        If STATE = "ADD" Then
            If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("select a.* from(select po.no_po,po.flag_ppn,pod.no_seq,pod.kd_stok,pod.keterangan,pod.kd_satuan,ISNULL(pod.harga,0) as harga,(select qty_order from INV.dbo.v_saldo_qc_pass_jasa where no_po= po.no_po and kd_stok=pod.kd_stok and no_seq=pod.no_seq)as qty_ordered, pod.qty,isnull(pod.qty_sisa,0) as qty_sisa, brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya, 0 as qty_qc_pass from PURC.DBO.PURC_PO_D_BARANG pod inner join PURC.DBO.PURC_PO po on pod.no_po=po.no_po inner join SIF.dbo.SIF_Barang brg on pod.kd_stok=brg.Kode_Barang where pod.no_po='" & LookupPO.EditValue & "')a where a.qty_ordered is not null", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_qc").Clear()

            While sqdr.Read
                Dim rw1 As DataRow = dSO1.Tables("_qc").NewRow
                rw1.Item("Kd_Cabang") = kdcabang
                'rw.Item("tipe_trans") = "JBM-KUT-03"
                rw1.Item("no_seq") = sqdr.Item("no_seq")
                rw1.Item("kd_stok") = sqdr.Item("kd_stok")
                rw1.Item("keterangan") = sqdr.Item("keterangan")
                rw1.Item("kd_satuan") = sqdr.Item("kd_satuan")
                rw1.Item("kd_ukuran") = sqdr.Item("kd_ukuran")
                rw1.Item("qty_sisa") = sqdr.Item("qty_ordered")
                rw1.Item("qty_qc_unpass") = 0
                'rw1.Item("gudang_asal") = sqdr.Item("lokasi")
                rw1.Item("gudang_tujuan") = sqdr.Item("lokasi")
                rw1.Item("qty_order") = sqdr.Item("qty_ordered")
                rw1.Item("harga") = sqdr.Item("harga")
                rw1.Item("kd_buku_besar") = sqdr.Item("rek_persediaan")
                rw1.Item("kd_buku_biaya") = sqdr.Item("rek_biaya")
                p_np = sqdr.Item("flag_ppn")
                dSO1.Tables("_qc").Rows.Add(rw1)

                sisa_asli = sqdr.Item("qty_sisa")
            End While

            sqdr.Close()
            GvQCsvc.FocusedColumn = GvQCsvc.VisibleColumns(5)
        End If
    End Sub

    Private Sub LookupPO_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupPO.QueryPopUp
        ds_cari.Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct (no_po) from(select po.rec_stat, po.no_po,po.flag_ppn,pod.kd_stok,pod.keterangan,pod.kd_satuan,pod.harga,(select qty_order from INV.dbo.v_saldo_qc_pass_jasa where no_po= po.no_po and kd_stok=pod.kd_stok and no_seq=pod.no_seq)as qty_ordered, pod.qty,pod.qty_sisa, brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya, 0 as qty_qc_pass from PURC.DBO.PURC_PO_D_BARANG pod inner join PURC.DBO.PURC_PO po on pod.no_po=po.no_po inner join SIF.dbo.SIF_Barang brg on pod.kd_stok=brg.Kode_Barang where po.rec_stat='APPROVE')a where a.qty_ordered is not null", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupPO.Properties.DataSource = ds_cari.Tables("_lookup1")
        LookupPO.Properties.ValueMember = "no_po"
        LookupPO.Properties.DisplayMember = "no_po"

    End Sub
    Private Sub txbSJSupplier_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txbSJSupplier.Validating
        If LookupPO.Text.ToString <> "" Then
            If txbSJSupplier.Text = "" Or LookupPO.Text = txbSJSupplier.Text Then
                DXEP.SetError(sender, "Isian Tidak Boleh Kosong Atau Sama dengan Nomor PO")
                e.Cancel = True
                'txbSJSupplier.Focus()

            Else
                DXEP.SetError(sender, "")
                e.Cancel = False
            End If
        End If
    End Sub
End Class
