'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports System.Math

Public Class frmInvOpnmStok
    Public btnSave As Boolean = False
    Public STATE, namafile As String
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_jns, ds_vbrg, dsLookUp, ds_jns_persd, ds_cari, ds_cari1, ds_cari2, ds_cari3 As New DataSet
    Private Buildernya As New SqlCommandBuilder
    Dim DA, DA2, da_brg, DA_jns, DA_jns_persd, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
    Dim x As Object

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        setStatus()
        STATE = "ADD" '<-- set state add
        txtcari.Enabled = False
        txbKdBrg.Enabled = False
        lookupBulanAwal.Enabled = True
        LookupPersd.Enabled = True

    End Sub

    Public Sub edit_click()
        'LookupPO.Hide()
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct opn.no_trans, opn.bultah as [Periode],opn.kd_jns_persd as [Kode Persediaan],psd.Nama_Persediaan,opn.tgl_trans as Tanggal, opn.Last_Created_By as [Petugas Opname] from INV.dbo.INV_OPNAME as opn left join SIF.dbo.SIF_Jns_Persediaan as psd on opn.kd_jns_persd=psd.Kd_Jns_Persd", sqlconn))
        If Not dSO.Tables("lookup_qc") Is Nothing Then dSO.Tables("lookup_qc").Clear()
        DA2.Fill(dSO, "lookup_qc")
        frmCari.set_dso(dSO.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            lookupBulanAwal.Enabled = False
            LookupPersd.EditValue = frmCari.row(1)
            LookupPersd.Enabled = False
            ReloadTable(frmCari.row(0), frmCari.row(1))
            'If frmCari.row.Item("cetak_ulang") = "Y" Then
            '    frmMain.btnCetak.Enabled = True
            '    'MsgBox("cetak")
            'ElseIf frmCari.row.Item("cetak_ulang") = "T" Then
            '    frmMain.btnCetak.Enabled = False
            '    'MsgBox("no cetak")
            'End If

            'If frmCari.row.Item("Status_Masuk_Gudang").ToString = True Then
            '    btnSave = False
            '    'txbSJSupplier.Enabled = False
            '    dtp2.Enabled = False
            '    STATE = "EDIT"
            '    Me.Enabled = True
            '    setStatus()
            '    btnadd = False
            '    btnEdit = False
            '    btnDelete = False
            '    btnCancel = True
            'ElseIf frmCari.row.Item("Status_Masuk_Gudang").ToString = False Then
            '    btnadd = False
            '    btnEdit = False
            '    btnDelete = True
            '    btnCancel = True
            '    btnSave = True
            '    STATE = "EDIT"
            '    Me.Enabled = True
            '    setStatus()
            '    'LookupPO.Enabled = False
            '    'txbSJSupplier.Enabled = True

            'Else
            'cancel_click()
            'LookupPO.Enabled = False
            'STATE = ""
            'End If
            btnadd = False
            btnEdit = False
            btnDelete = False
            btnCancel = True
            btnSave = True
            STATE = "EDIT"
            Me.Enabled = True
            setStatus()
        End If


    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
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



    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        Dim no_trans As String
        no_trans = getNoTrans("OPN", getTanggal(BTRANS), BTRANS)
        txbNoTrans.Text = no_trans
        For Each rw As DataRow In dSO.Tables("_opn").Rows
            If rw.RowState = DataRowState.Added Then
                rw.Item("no_trans") = no_trans
                rw.Item("Kd_Cabang") = kdcabang
                rw.Item("bultah") = lookupBulanAwal.EditValue
                rw.Item("tgl_trans") = getTanggal()
                rw.Item("Last_Create_Date") = getTanggal()
                rw.Item("Last_Created_By") = username
            Else
                rw.Item("Last_Update_Date") = getTanggal()
                rw.Item("Last_Updated_By") = username

            End If
            rw.Item("Program_Name") = Me.Name
        Next
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS


            DA.Update(dSO.Tables("_opn"))


            'For Each row As DataRow In dSO.Tables("_opn").Rows

            '    If rw.RowState = DataRowState.Modified Then
            '        If row("selisih") < 0 Then ' Jika selisih nya minus -1<
            '            stprc_gdin(kdcabang, blthn(BTRANS), row("kd_stok").ToString, row("kd_ukuran"), row("kd_satuan").ToString, row("gudang_asal").ToString, row("gudang_tujuan").ToString, row("selisih"), BTRANS)
            '        ElseIf row("selisih") > 0 Then ' Jika selisih nya surplus/lebih +1 >
            '            stprc_gdout(kdcabang, blthn(BTRANS), row("kd_stok").ToString, row("kd_ukuran"), row("kd_satuan").ToString, row("gudang_asal").ToString, row("gudang_tujuan").ToString, row("selisih"), BTRANS)
            '        End If
            '    End If

            'Next

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            STATE = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_opn").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try
        'dSO1.Tables("_qc").Clear()

    End Sub

    Public Sub stprc_gdout(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_gdin(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_inx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.ExecuteNonQuery()
    End Sub

    'Public Sub hapus_record()
    '    Dim builder As New SqlCommandBuilder(DA)
    '    Dim row As DataRow
    '    Dim rows() As DataRow
    '    Dim i As Integer

    '    ReDim rows(GvOpnStok.SelectedRowsCount - 1)
    '    For i = 0 To GvOpnStok.SelectedRowsCount - 1
    '        rows(i) = GvOpnStok.GetDataRow(GvOpnStok.GetSelectedRows(i))
    '    Next
    '    GvOpnStok.BeginSort()
    '    Try
    '        For Each row In rows
    '            row.Delete()
    '        Next
    '    Finally
    '        GvOpnStok.EndSort()
    '    End Try
    '    simpan()
    'End Sub





    Sub ReloadTable(ByVal no_transx As String, ByVal jns As String)
        If Not dSO.Tables("_opn") Is Nothing Then dSO.Tables("_opn").Clear()

        da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd not in ('4','5') ", sqlconn))
        da_brg.Fill(ds_vbrg, "_vbrg")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,(select Nama_Barang from sif.dbo.sif_barang where kode_barang=kd_stok) as nama_barang from INV.dbo.INV_OPNAME_DTL where no_trans='" & no_transx & "' and kd_jns_persd='" & jns & "'", sqlconn))
        DA.Fill(dSO, "_opn")
        GcOpnStok.DataSource = dSO.Tables("_opn")

    End Sub

    Private Sub frmInvMtsiStok_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' dtp2.EditValue = Now
        Loadblthn()
        connect()
        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'ReloadTable()
        ReloadTable("xxxx", "xx")

        DA_jns_persd = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan where Kd_Jns_Persd not in ('4','5')", sqlconn))
        DA_jns_persd.Fill(ds_jns_persd, "_persd")
        LookupPersd.Properties.DataSource = ds_jns_persd.Tables("_persd")
        LookupPersd.Properties.ValueMember = "Kd_Jns_Persd"
        LookupPersd.Properties.DisplayMember = "Nama_Persediaan"

        'DA_jns = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg,Nama_Jenis from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        'DA_jns.Fill(ds_jns, "_jns")
        'LookupJenis.Properties.DataSource = ds_jns.Tables("_jns")
        'LookupJenis.Properties.ValueMember = "Kd_Jns_Brg"
        'LookupJenis.Properties.DisplayMember = "Nama_Jenis"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang,Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepLookupStok.DataSource = ds_cari.Tables("_lookup1")
        RepLookupStok.ValueMember = "Kode_Barang"
        RepLookupStok.DisplayMember = "Nama_Barang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan where Kd_Jns_Persd<>'4'", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        RepLookupPersd.DataSource = ds_cari2.Tables("_lookup2")
        RepLookupPersd.ValueMember = "Kd_Jns_Persd"
        RepLookupPersd.DisplayMember = "Nama_Persediaan"

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg,Nama_Jenis from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_lookup3")
        RepLookupJenis.DataSource = ds_cari3.Tables("_lookup3")
        RepLookupJenis.ValueMember = "Kd_Jns_Brg"
        RepLookupJenis.DisplayMember = "Nama_Jenis"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookGdg")
        LU_Gudang.Properties.DataSource = ds_cari1.Tables("_lookGdg")
        LU_Gudang.Properties.ValueMember = "Kode_Gudang"
        LU_Gudang.Properties.DisplayMember = "Nama_Gudang"

        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_opn").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim ambilfile As New OpenFileDialog
        ambilfile.CheckFileExists = True
        ambilfile.Filter = "TXT File (*.txt) | *.txt"
        ambilfile.Title = "file harus ber extensi .txt"
        ambilfile.Multiselect = False
        ambilfile.ShowDialog()
        namafile = ambilfile.FileName
        txbLokasi.Text = namafile
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If txbLokasi.Text = "" Then
            Exit Sub
        End If
        'Dim row As DataRow
        Dim i As Int16 = 1
        Dim streamku As New System.IO.StreamReader(namafile)
        Dim hasilbaca As String
        'Dim kodebarang, gudang, qt, blthn, nilai_ As String
        Dim textperbaris As String = ""
        While Not (streamku.EndOfStream)
            hasilbaca = streamku.ReadLine
            Dim rw As DataRow = dSO.Tables("_opn").NewRow

            rw.Item("no_seq") = i : i += 1
            rw("kd_stok") = Mid(hasilbaca, 1, 22)
            rw("kode_gudang") = Mid(hasilbaca, 23, 5)
            rw("bultah") = Mid(hasilbaca, 28, 6)
            rw("qty_opname") = Mid(hasilbaca, 34, 3)
            rw("nilai_opname") = Mid(hasilbaca, 37, 3)
            rw("keterangan") = Mid(hasilbaca, 40)
            Dim sqlrd As SqlDataReader = New SqlCommand("select Kd_Satuan from SIF.dbo.SIF_Barang where Kode_Barang='" & rw("kd_stok") & "'", sqlconn).ExecuteReader
            If sqlrd.Read Then
                rw("kd_satuan") = sqlrd.Item("Kd_Satuan")
            End If

            dSO.Tables("_opn").Rows.Add(rw)

            'If rw.RowState = DataRowState.Added Then
            '    rw = ds_cari.Tables("_lookup1").Select("Kode_Barang='" & rw("kd_stok") & "'")(0)
            '    GvOpnStok.GetRow(RowHandle).item("satuan") = row("Kd_Satuan")
            'End If

            'kodebarang = Mid(hasilbaca, 1, 22)
            'gudang = Mid(hasilbaca, 23, 5)
            'blthn = Mid(hasilbaca, 28, 6)
            'qt = Mid(hasilbaca, 34, 3)
            'nilai_ = Mid(hasilbaca, 37, 3)
            'MsgBox("file tersebut berisi " & vbNewLine & "kodebarang:" & kodebarang & " Gudang:" & gudang & " Jumlah:" & qt & " Tanggal:" & blthn & " Nilai:" & nilai_)
            'If LookupStok.GetDisplayText(
            ' Dim row As DataRow '= ds_cari.Tables("_lookup1").Rows.Item("Kd_Satuan")
            'row = ds_cari.Tables("_lookup1").Select("Kode_Barang='" & e.Value & "'")(0)
            'GvOpnStok.GetRow(e.RowHandle).item("satuan") = row("Kd_Satuan")
            'End If
            sqlrd.Close()
        End While


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

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        LookupPersd.EditValue = vbNullString
        LU_Gudang.EditValue = vbNullString
        'dtp2.EditValue = vbNullString
        lookupBulanAwal.EditValue = vbNullString
    End Sub

    Private Sub GvOpnStok_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvOpnStok.CellValueChanged
        Dim hitung_persen As Decimal

        If e.Column Is qty_opname Then
            GvOpnStok.GetRow(e.RowHandle).item("qty_selisih") = GvOpnStok.GetRow(e.RowHandle).item("qty_data") - GvOpnStok.GetRow(e.RowHandle).item("qty_opname")
            If GvOpnStok.GetRow(e.RowHandle).item("qty_data") > 0 And GvOpnStok.GetRow(e.RowHandle).item("qty_opname") > 0 Then
                hitung_persen = (Math.Abs(GvOpnStok.GetRow(e.RowHandle).item("qty_selisih")) / GvOpnStok.GetRow(e.RowHandle).item("qty_data") * 100)
                'GvOpnStok.GetRow(e.RowHandle).item("persen_selisih") = hitung_persen
            End If

            'If hitung_persen = 0 Then
            '    GvOpnStok.GetRow(e.RowHandle).item("persen_selisih") = 0
            'End If
        End If
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        txtcari.Enabled = True
        txbKdBrg.Enabled = True
        'ReloadTable("xxxx")
        'pnlLoad.Visible = True
        'pnlLoad.Refresh()
        ReloadTable("xxxxx", "xx")
        Dim sqltgl As String = ""
        Dim i As Int16 = 1
        If Not dSO.Tables("_opn") Is Nothing Then dSO.Tables("_opn").Clear()
        'If LookupPersd.EditValue = vbNullString Then
        sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "' and 1=0"
        If LookupPersd.EditValue = vbNullString Then
            sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "'"
        ElseIf LookupPersd.EditValue <> vbNullString And LU_Gudang.EditValue = vbNullString Then
            sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "' and sld.kd_jns_persd='" & LookupPersd.EditValue & "'"
        ElseIf LookupPersd.EditValue = vbNullString And LU_Gudang.EditValue <> vbNullString Then
            sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "' and sld.kd_jns_persd='" & LookupPersd.EditValue & "'"
        ElseIf LookupPersd.EditValue <> vbNullString And LU_Gudang.EditValue <> vbNullString Then
            'MsgBox("ALL")
            sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "' and sld.kd_jns_persd='" & LookupPersd.EditValue & "'"

        Else
            sqltgl = "sld.bultah='" & lookupBulanAwal.EditValue & "'"
        End If

        Dim sqldr As SqlDataReader = New SqlCommand("select sld.kd_stok,sld.kd_satuan,sld.kd_ukuran,sld.spek_brg,sld.kd_jenis,sld.kd_jns_persd,sld.qty_available,sld.nilai_rata,brg.Nama_Barang,brg.lokasi from INV.dbo.INV_STOK_SALDO as sld left join SIF.dbo.SIF_Barang as brg on sld.kd_stok=brg.Kode_Barang  where " & sqltgl & " ", sqlconn).ExecuteReader
        While sqldr.Read
            Dim rw As DataRow = dSO.Tables("_opn").NewRow
            rw.Item("nomer") = i : i += 1
            rw.Item("Kd_Cabang") = kdcabang
            rw.Item("bultah") = lookupBulanAwal.EditValue
            rw.Item("kd_stok") = sqldr.Item("kd_stok")
            rw.Item("kode_gudang") = sqldr.Item("lokasi")
            rw.Item("nama_barang") = sqldr.Item("Nama_Barang")
            rw.Item("kd_satuan") = sqldr.Item("kd_satuan")
            rw.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
            rw.Item("spek_brg") = sqldr.Item("spek_brg")
            rw.Item("kd_jenis") = sqldr.Item("kd_jenis")
            rw.Item("kd_jns_persd") = sqldr.Item("kd_jns_persd")
            rw.Item("qty_data") = sqldr.Item("qty_available")
            rw.Item("qty_opname") = sqldr.Item("qty_available")
            rw.Item("nilai_rata") = sqldr.Item("nilai_rata")
            ''rw.Item("bultah
            'rw.Item("awal_nilai") = sqldr.Item("awal_nilai")
            'rw.Item("nilai_in") = sqldr.Item("nilai_in")
            'rw.Item("nilai_out") = sqldr.Item("nilai_out")
            'rw.Item("akhir_nilai") = sqldr.Item("akhir_nilai")
            'rw.Item("nilai_rata") = sqldr.Item("nilai_rata")

            dSO.Tables("_opn").Rows.Add(rw)
        End While
        sqldr.Close()
        'pnlLoad.Visible = False
    End Sub

    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            Dim dtrow() As DataRow = dSO.Tables("_opn").Select("nama_barang='" & txtcari.Text & "'")
            If dtrow.Count = 0 Then
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                lblNmBrg.ForeColor = Color.DarkRed
                lblStatus.ForeColor = Color.DarkRed
                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()

                txtcari.Focus()
            Else
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                lblStatus.Text = "OK, Barang ditemukan di list, silahkan di ADJUST!"
                lblNmBrg.Text = dtrow(0)("nama_barang").ToString
                txtcari.SelectAll()
                'If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                'If dtrow.Count > 0 Then
                'dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                ok = True
                BindingContext(GcOpnStok.DataSource).Position = getPosisi(dtrow(0))
                'tunda()

                txtcari.Focus()
                'MsgBox("barang ada")
                'Exit Sub
                'End If
                'Next


                'MsgBox("barang tidak ada")
                'ElseIf Not ok Then
                '    lblNmBrg.Text = "Barang sudah terdaftar semua"
                '    lblStatus.Text = "STOP!"
            End If
            txtcari.SelectAll()
        End If
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(2000)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO.Tables("_opn").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If
        Next
    End Function


End Class