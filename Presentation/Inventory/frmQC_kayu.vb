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

Public Class frmQC_kayu
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
    Private dso, dSO1, dsos, ds_cari, ds_cari1, ds_cari2, ds_cari3, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Dim sisa_asli As Decimal
    Private rw As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Dim clone As DataView

    Public Sub add_click()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD"
        'dtpTgl.EditValue = getTanggal()
        bersihkan()
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

    Public Sub save_click()
        If dSO1.Tables("_qc").Select("[qty_qc_pass] is null").Count > 0 Then 'Or  dSO1.Tables("_qc").Select("[qty_datang] is null").Count > 0 
            MsgBox("Qty Datang atau Qty Pass Tidak boleh kosong", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'If LookupPO.EditValue = vbNullString Or LookupGudang.EditValue = vbNullString Then
        '    MsgBox("Tentukan Tanggal / Nomer PO / Gudang Tujuan dahulu! Tidak Boleh kosong", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
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

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_IN where substring((no_trans),8,3)='BME'", sqlconn)) '
        If Not dSO1.Tables("lookup_bme") Is Nothing Then dSO1.Tables("lookup_qc").Clear()
        DA2.Fill(dSO1, "lookup_bme")
        frmCari.set_dso(dSO1.Tables("lookup_bme")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(0))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub simpan()

        Dim BTRANS As SqlTransaction
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
        'rw.Item("status_qc") = "APPROVED"
        rw.Item("no_ref") = LookupPO.EditValue
        rw.Item("no_trans") = getNoTrans("QC", getTanggal(BTRANS), BTRANS)
        rw.Item("tgl_trans") = getTanggal()
        rw.Item("jml_rp_trans") = GvQCkayu.Columns(13).SummaryItem.SummaryValue
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
                Dim sqlcmd As New SqlCommand("update PURC.dbo.PURC_PO_D set qty_sisa=" & row1("qty_sisa").ToString & " where no_po='" & LookupPO.EditValue & "' and kd_stok='" & row1("kd_stok") & "'", sqlconn, BTRANS)
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

    Public Sub cetak_click()
        callReport(App_Path() & "\report\QC.rpt", "", "no_qc=" & txbNoTrans.Text, False, True)
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
    End Sub

    Private Sub frmQC_kayu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GvQCkayu.Columns("harga").Visible = False
        GvQCkayu.Columns("rp_trans").Visible = False
        GvQCkayu.Columns("gudang_asal").Visible = False
        GvQCkayu.Columns("gudang_tujuan").Visible = False
        GvQCkayu.Columns("status_hold").Visible = False

        LoadStruktur("xxxxx")
        prn = getParent(Me)
        formate_yayak()

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.DBO.SIF_Gudang", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup")
        'LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct POD.no_po FROM PURC.dbo.PURC_PO_D POD INNER JOIN PURC.dbo.PURC_PO PO on POD.no_po=PO.no_po where POD.qty_sisa <> 0 and PO.rec_stat = 'APPROVE' and POD.spek_brg LIKE 'KAYU%'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupPO.Properties.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Nama_Barang,Kode_Barang from SIF.dbo.SIF_Barang where spek_brg like 'KAYU%'", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        'de aktif metode beda
        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang,spek_brg,Nama_Barang,Kd_Satuan from SIF.dbo.SIF_Barang where spek_brg like 'KAYU%'", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_lookup3")
        RLookupSpek.DataSource = ds_cari3.Tables("_lookup3")
        RLookupSpek.ValueMember = "spek_brg"
        RLookupSpek.DisplayMember = "spek_brg"

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
        GvQCkayu.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCkayu.Columns("qty_qc_pass").DisplayFormat.FormatString = "n0"
        GvQCkayu.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCkayu.Columns("qty_order").DisplayFormat.FormatString = "n0"
        GvQCkayu.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCkayu.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n0"
        GvQCkayu.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCkayu.Columns("hold").DisplayFormat.FormatString = "n0"
        GvQCkayu.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvQCkayu.Columns("qty_sisa").DisplayFormat.FormatString = "n0"
    End Sub

    Private Sub LoadStruktur(ByVal kodepo As String)
        'If Not dSO.Tables("_bme") Is Nothing Then dSO.Tables("_bme").Clear()
        If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 asli from INV.dbo.INV_QC where no_trans='" & kodepo & "'", sqlconn))
        DA2.Fill(dSO1, "_qc")
        GcQCkayu.DataSource = dSO1.Tables("_qc")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kodepo & "'", sqlconn))
        DA.Fill(dso, "_qcm")
        'GcBME_d.DataSource = dso.Tables("_qcm")



        If dSO1.Tables("_qc").Rows.Count > 0 Then
            Dim rw As DataRow = dSO1.Tables("_qc").Rows(0)
            txbNoRef.Text = rw("no_ref").ToString
            txbNoTrans.Text = rw("no_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            LookupPO.EditValue = rw("no_po").ToString
        End If
    End Sub


    Private Sub GvQCkayu_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvQCkayu.CellValueChanged

        If e.Column Is qty_qc_pass Then
            If GvQCkayu.GetRow(e.RowHandle).item("asli") = 0 Then
                If GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass") > GvQCkayu.GetRow(e.RowHandle).item("qty_order") Then
                    If MsgBox("Barang Quantity Good lebih besar dari Order, apakah dilanjutkan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") = 0
                        Exit Sub
                    Else

                        GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass") = 0
                    End If
                End If
                GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") = GvQCkayu.GetRow(e.RowHandle).item("qty_order") - GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass")
                GvQCkayu.GetRow(e.RowHandle).item("rp_trans") = GvQCkayu.GetRow(e.RowHandle).item("harga").ToString * GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass").ToString
                'Else 'jika asli =1
                '    GvQCkayu.GetRow(e.RowHandle).item("rp_trans") = GvQCkayu.GetRow(e.RowHandle).item("harga").ToString * GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass").ToString
            End If

            If GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass") > GvQCkayu.GetRow(e.RowHandle).item("qty_order") Then
                If MsgBox("Barang Quantity Good lebih besar dari Order, apakah dilanjutkan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") = 0
                    Exit Sub
                Else

                    GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass") = 0
                End If
            End If
            GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") = GvQCkayu.GetRow(e.RowHandle).item("qty_order") - GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass")
            GvQCkayu.GetRow(e.RowHandle).item("rp_trans") = GvQCkayu.GetRow(e.RowHandle).item("harga").ToString * GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass").ToString
        End If

        'De-aktif Metode Beda
        'If e.Column Is kd_stok Then
        '    Dim clone As DataView
        '    clone = New DataView(ds_cari3.Tables("_lookup3"))
        '    clone.RowFilter = "Nama_Barang ='" & e.Value & "'"
        '    RLookupSpek.DataSource = clone
        'End If
        If e.Column Is spek_brg Then
            ' GvQCkayu.SetRowCellValue(e.RowHandle, "kd_satuan", ds_cari3.Tables("_lookup3").Select("Kode_Barang='" & e.Value & "'")(0)("Kd_Satuan"))
            GvQCkayu.GetRow(e.RowHandle).item("kd_satuan") = "Batang"
        End If

        If e.Column Is hold Then
            GvQCkayu.GetRow(e.RowHandle).item("status_hold") = "HOLD"
            'If GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") <> 0 Then
            '    If GvQCkayu.GetRow(e.RowHandle).item("hold") + GvQCkayu.GetRow(e.RowHandle).item("qty_qc_pass") > GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") Then
            '        hold_po = GvQCkayu.GetRow(e.RowHandle).item("hold") - GvQCkayu.GetRow(e.RowHandle).item("qty_sisa")
            '        MsgBox("Barang HOLD telah memenuhi PO/Order! " & vbCrLf & "Untuk Barang Sisa yang Hold Sebanyak " & hold_po & " Silahkan di entry menggunakan form Entry Barang HOLD", MsgBoxStyle.Information, "MOHON DIBACA!!!")
            '        GvQCkayu.GetRow(e.RowHandle).item("hold") = GvQCkayu.GetRow(e.RowHandle).item("qty_sisa")
            '        GvQCkayu.GetRow(e.RowHandle).item("qty_sisa") = 0
            '        'Else

            '    End If
            'If dSO1.Tables("_qc").Select("[hold] is null").Count > 0 Then
            'If GvQCkayu.GetRow(e.RowHandle).item("hold") = vbNull Then
            '    MsgBox("nol")

        End If

        'End If
        'End If
    End Sub


    Private Sub LookupPO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupPO.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("SELECT pod.no_po,pod.kd_stok,brg.spek_brg,brg.lokasi,brg.kd_satuan,pod.harga,pod.qty,pod.qty_sisa,brg.rek_persediaan,brg.rek_biaya, '' as Nama_Barang,0 as qty_qc_pass from PURC.DBO.PURC_PO_D pod  INNER JOIN SIF.dbo.SIF_Barang as brg on pod.kd_stok=brg.Kode_Barang where pod.no_po='" & LookupPO.EditValue & "' and pod.qty_sisa  > 0", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_qc").Clear()

            While sqdr.Read
                Dim rw1 As DataRow = dSO1.Tables("_qc").NewRow
                rw1.Item("Kd_Cabang") = kdcabang
                'rw.Item("tipe_trans") = "JPU-KUT-01"
                rw1.Item("no_seq") = i : i += 1
                rw1.Item("kd_stok") = sqdr.Item("kd_stok")
                'rw1.Item("Nama_Barang") = sqdr.Item("Nama_Barang")
                rw1.Item("spek_brg") = sqdr.Item("spek_brg")
                rw1.Item("kd_satuan") = sqdr.Item("kd_satuan")
                'rw1.Item("kd_ukuran") = sqdr.Item("kd_ukuran")
                rw1.Item("qty_sisa") = sqdr.Item("qty_sisa")
                rw1.Item("qty_qc_unpass") = 0
                rw1.Item("qty_order") = sqdr.Item("qty")
                rw1.Item("harga") = sqdr.Item("harga")
                rw1.Item("gudang_tujuan") = sqdr.Item("lokasi")
                rw1.Item("kd_buku_besar") = sqdr.Item("rek_persediaan")
                rw1.Item("kd_buku_biaya") = sqdr.Item("rek_biaya")
                rw1.Item("asli") = 0

                dSO1.Tables("_qc").Rows.Add(rw1)

                sisa_asli = sqdr.Item("qty_sisa")
            End While
            sqdr.Close()
            GvQCkayu.FocusedColumn = GvQCkayu.VisibleColumns(6)
        End If


    End Sub

    Private Sub GvQCkayu_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvQCkayu.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRow

        On Error Resume Next
        If view.FocusedColumn.Name = spek_brg.Name Then
            row = view.GetDataRow(view.FocusedRowHandle)
            Dim nama_barang As String = ds_cari2.Tables("_lookup2").Select("Kode_Barang='" & row("kd_stok") & "'")(0)("Nama_Barang")

            If row("kd_stok").ToString = "" Then Exit Sub
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Nama_Barang = '" & nama_barang & "'" '" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub GvQCkayu_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvQCkayu.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub GvQCkayu_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvQCkayu.InitNewRow
        GvQCkayu.SetRowCellValue(e.RowHandle, "asli", 1)
        GvQCkayu.GetRow(e.RowHandle).item("status_hold") = "HOLD"
    End Sub
End Class

