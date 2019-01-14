'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frBM_Rtr_ext
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public btncetak As Boolean
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, dsLookUp, ds_cari3, ds_vbrg As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3, da_brg As SqlClient.SqlDataAdapter
    Dim x As Object
    Private BTrans As SqlTransaction
    Dim maxbultahx As String

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
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
            .btnCetak.Enabled = btncetak
        End With
    End Sub

    Public Sub save_click()
        If LookupCust.EditValue = "" Then
            MsgBox("Nama Customer tidak boleh KOSONG")
            Exit Sub
        End If
        If GvBMI_d.RowCount = 0 Then
            MsgBox("Daftar barang retur masih KOSONG")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        'bersihkan()
    End Sub


    Public Sub bersihkan()
        LookupCust.EditValue = vbNullString
        txbNmTrima.Text = ""
        txbNoTrans.Text = ""
        txbToko.Text = ""
        dSO.Tables("_bmi").Clear()
        dSO1.Tables("_bmid").Clear()

    End Sub

    Public Sub cancel_click()
        bersihkan()
        btnEdit = True
        btnadd = True
        btnDelete = False
        btnCancel = False
        btnSave = False
        btncetak = False
        Me.Enabled = False
        setStatus()
    End Sub
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans, tgl_trans, no_ref, penyerah from INV.DBO.INV_Retur where no_trans not in (select no_ref from inv.dbo.inv_qc where tipe_trans='" & ReturGudangIn & "')", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row("no_trans"))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            btncetak = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bmi").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bmi").Rows(0)
            row.Item("Last_Update_Date") = getTanggal() 'Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        'row.Item("no_trans") = getNoTrans("BKI", getTanggal())
        row.Item("tipe_trans") = ReturGudangIn
        row.Item("kd_customer") = LookupCust.EditValue
        row.Item("tgl_trans") = tgl_retur.EditValue
        row.Item("no_ref") = txbToko.Text
        row.Item("penyerah") = txbNmTrima.Text
        row.Item("jml_rp_trans") = GvBMI_d.Columns(7).SummaryItem.SummaryValue
        'row.Item("kode_gudang") = LookupGudang.EditValue
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        row.Item("cetak_ke") = 0
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bmi").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bmid").Rows
            If row1.RowState = DataRowState.Added Then
                'row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = row.Item("tipe_trans")

                row1.Item("Last_Create_Date") = getTanggal() ' Now
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = kdcabang
            Else
                row1.Item("Last_Update_Date") = getTanggal() 'Now
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

        Next


        'BTRANS = sqlconn.BeginTransaction("1")
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
                row.Item("no_trans") = getNoTrans("JBM", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bmid").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            'txbNoTrans.Text = row.Item("no_trans")

            DA.Update(dSO.Tables("_bmi"))
            DA2.Update(dSO1.Tables("_bmid"))

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            'Me.Enabled = False
            btnSave = True
            btnCancel = True
            btnDelete = False
            btnEdit = False
            btncetak = True
            btnadd = False
            setStatus()

        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Integer, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Int).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_onstok(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_outx As Integer, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Int).Value = qty_outx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
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

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bmi") Is Nothing Then dSO.Tables("_bmi").Clear()
        If Not dSO1.Tables("_bmid") Is Nothing Then dSO1.Tables("_bmid").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_RETUR where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang,0 as harga from INV.dbo.INV_RETUR_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmid")
        GcBMI_d.DataSource = dSO1.Tables("_bmid")

        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim row As DataRow = dSO.Tables("_bmi").Rows(0)
            'txbNoRef.Text = rw("no_ref").ToString
            txbNoTrans.Text = row("no_trans").ToString
            tgl_retur.EditValue = row("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            txbToko.Text = row("no_ref").ToString
            'LookupPO2.EditValue = rw("no_ref").ToString

            'MsgBox(rw("no_ref").ToString)
        End If

        'da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd='3'", sqlconn))
        'da_brg.Fill(ds_vbrg, "_vbrg")

    End Sub
    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Private Sub frBM_Rtr_ext_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        tgl_retur.EditValue = Today
        LoadStruktur("xxxx")

        GvBMI_d.Columns("gudang_tujuan").Visible = False
        GvBMI_d.Columns("harga").Visible = False
        GvBMI_d.Columns("rp_trans").Visible = False

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer where rec_stat='Y' order by Nama_Customer", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupCust.Properties.DataSource = ds_cari1.Tables("_lookup2")
        LookupCust.Properties.ValueMember = "Kd_Customer"
        LookupCust.Properties.DisplayMember = "Nama_Customer"
        maxbultahx = maxbultah()
        lookbrg()
        btnEdit = True
        btnadd = True
        btnDelete = False
        btnCancel = False
        btnSave = False
        setStatus()
    End Sub

    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged

        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds_cari.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")(0)
            GvBMI_d.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
            GvBMI_d.GetRow(e.RowHandle).item("gudang_tujuan") = rw("lokasi")
            GvBMI_d.GetRow(e.RowHandle).item("harga") = rw("nilai_rata")
            GvBMI_d.GetRow(e.RowHandle).item("kd_buku_besar") = rw("rek_persediaan")
        End If
        If e.Column Is qty_in Then
            GvBMI_d.GetRow(e.RowHandle).item("rp_trans") = GvBMI_d.GetRow(e.RowHandle).item("harga") * GvBMI_d.GetRow(e.RowHandle).item("qty_in")
        End If
        'If e.Column Is stat_brg_retur Then
        '    If GvBMI_d.GetRow(e.RowHandle).item("stat_brg_retur") = "NOT OK" Then
        '        GvBMI_d.GetRow(e.RowHandle).item("gudang_tujuan") = "G0009"
        '    End If
        'End If
    End Sub

    Private Sub GvBMI_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBMI_d.InitNewRow
        GvBMI_d.GetRow(e.RowHandle).item("no_Seq") = GvBMI_d.RowCount + 1
    End Sub

    Public Sub cetak_click()
        Dim sqcmd As New SqlCommand("update INV.dbo.INV_RETUR set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTrans)
        sqcmd.ExecuteNonQuery()
        callReport(App_Path() & "\report\inv_ReturJual.rpt", "", "vnotrans=" & txbNoTrans.Text, False, False)
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        lookbrg()
    End Sub

    Private Sub lookbrg()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.rek_persediaan,brg.Kd_Satuan,brg.lokasi,sld.nilai_rata from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('1','2','3') and sld.bultah='" & maxbultahx & "' order by Nama_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")

        LookupStok.DataSource = ds_cari.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"
    End Sub
    Function maxbultah() As String
        Dim hasil As String
        Dim read As SqlDataReader = New SqlCommand("select max(bultah) from inv.dbo.inv_stok_saldo", sqlconn).ExecuteReader
        read.Read()
        If read.HasRows Then hasil = read(0)
        read.Close()
        maxbultah = hasil
    End Function
    Private Sub GvBMI_d_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvBMI_d.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvBMI_d_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvBMI_d.ValidateRow
        Dim isvalid As Boolean = True
        If GvBMI_d.GetRowCellValue(e.RowHandle, "qty_in") Is Nothing Then
            isvalid = False
            GvBMI_d.SetColumnError(qty_in, "Harap mengisi Qty retur.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvBMI_d.FocusedColumn = qty_in
        ElseIf GvBMI_d.GetRowCellValue(e.RowHandle, "qty_in") <= 0 Then
            isvalid = False
            GvBMI_d.SetColumnError(qty_in, "Harap mengisi Qty retur dengan benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvBMI_d.FocusedColumn = qty_in
        End If
    End Sub
End Class