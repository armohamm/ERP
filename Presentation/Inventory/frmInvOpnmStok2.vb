'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports System.Math
Imports System.Globalization

Public Class frmInvOpnmStok2
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public STATE, namafile As String
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_jns, ds_vbrg, dsLookUp, ds_jns_persd, ds_cari, ds_cari1, ds_cari2, ds_cari3 As New DataSet
    Private Buildernya As New SqlCommandBuilder
    Dim DA, DA1, DA2, da_brg, DA_jns, DA_jns_persd, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
    Dim x As Object

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = True
        setStatus()
        STATE = "ADD" '<-- set state add
        'txtcari.Enabled = False
        'txbKdBrg.Enabled = False
        ReloadTable("xxxxxx", "xxx")
        lookupBulanAwal.Enabled = True
        'LookupPersd.Enabled = True

    End Sub

    Public Sub edit_click()
        'LookupPO.Hide()
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select no_trans as [NO_TRANS], tgl_trans as [TGL_TRANS], bultah as [BULAN_TAHUN], keterangan as [KETERANGAN] from INV.dbo.INV_OPNAME", sqlconn))
        If Not dSO.Tables("lookup_qc") Is Nothing Then dSO.Tables("lookup_qc").Clear()
        DA2.Fill(dSO, "lookup_qc")
        frmCari.set_dso(dSO.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            lookupBulanAwal.Enabled = False
            'LookupPersd.EditValue = frmCari.row(1)
            'LookupPersd.Enabled = False

            txbNoTrans.Text = frmCari.row(0)
            DE_Tanggal.EditValue = frmCari.row(1)
            lookupBulanAwal.EditValue = frmCari.row(2)
            txb_keterangan.Text = frmCari.row(3)
            ReloadTable(frmCari.row(0), frmCari.row(1))

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
        ' If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        bersih()
        Me.Enabled = False
    End Sub
    Sub bersih()
        txbNoTrans.Clear()
        txb_keterangan.Clear()
        DE_Tanggal.EditValue = Now
        lookupBulanAwal.EditValue = Nothing
        GcOpnStok.DataSource = Nothing
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

    Sub call_procedure(ByVal no_trans As String, ByVal tipe_trans As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"
        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 10).Value = "JRR-KUT-10"
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 25).Value = txbNoTrans.Text
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        Dim no_trans As String

        Dim row As DataRow
        If STATE = "ADD" Then
            no_trans = getNoTrans("OPN", getTanggal(BTRANS), BTRANS)
            txbNoTrans.Text = no_trans
            row = dSO.Tables("_opn").NewRow
            row.Item("no_trans") = txbNoTrans.Text
            row.Item("Kd_Cabang") = kdcabang
            row.Item("bultah") = lookupBulanAwal.EditValue
            row.Item("tgl_trans") = getTanggal()
            row.Item("keterangan") = txb_keterangan.Text
            row.Item("last_create_date") = getTanggal()
            row.Item("last_created_by") = username
            row.Item("Program_Name") = Me.Name
            dSO.Tables("_opn").Rows.Add(row)
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_opn").Rows(0)
            ' row.Item("no_trans") = txbNoTrans.Text
            row.Item("Kd_Cabang") = kdcabang
            row.Item("bultah") = lookupBulanAwal.EditValue
            row.Item("tgl_trans") = DE_Tanggal.EditValue
            row.Item("keterangan") = txb_keterangan.Text
            row.Item("last_update_date") = getTanggal()
            row.Item("last_updated_by") = username
            row.Item("Program_Name") = Me.Name
        End If


        For Each rows As DataRow In dSO.Tables("_opn_detil").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_trans") = txbNoTrans.Text
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("last_create_date") = getTanggal()
                    rows.Item("last_created_by") = username
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("last_update_date") = getTanggal()
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("last_updated_by") = username
                    rows.Item("program_name") = Me.Name
                End If
               
            End If
        Next
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA1)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA1.UpdateCommand = Buildernya.GetUpdateCommand()
            DA1.InsertCommand = Buildernya.GetInsertCommand()
            DA1.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA1.UpdateCommand.Transaction = BTRANS
            DA1.InsertCommand.Transaction = BTRANS
            DA1.DeleteCommand.Transaction = BTRANS


            DA.Update(dSO.Tables("_opn"))
            DA1.Update(dSO.Tables("_opn_detil"))

            dSO.Tables("_opn").AcceptChanges()
            dSO.Tables("_opn_detil").AcceptChanges()

            call_procedure(txbNoTrans.Text, "JRR-KPT-10", BTRANS)

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            STATE = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_opn").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dSO.Tables("_opn_detil").RejectChanges() ' untuk membatalkan row yg diupdate/insert

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


    Sub ReloadTable(ByVal no_transx As String, ByVal jns As String)
        If STATE = "ADD" Then
            If Not dSO.Tables("_opn") Is Nothing Then dSO.Tables("_opn").Clear()
            If Not dSO.Tables("_opn_detil") Is Nothing Then dSO.Tables("_opn_detil").Clear()

            da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd not in ('4','5') ", sqlconn))
            da_brg.Fill(ds_vbrg, "_vbrg")

            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_OPNAME where 1=0 ", sqlconn))
            DA.Fill(dSO, "_opn")


            DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_OPNAME_DTL where 1=0 ", sqlconn))
            DA1.Fill(dSO, "_opn_detil")
            GcOpnStok.DataSource = dSO.Tables("_opn_detil")
        ElseIf STATE = "EDIT" Then
            If Not dSO.Tables("_opn") Is Nothing Then dSO.Tables("_opn").Clear()
            If Not dSO.Tables("_opn_detil") Is Nothing Then dSO.Tables("_opn_detil").Clear()

            da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd not in ('4','5') ", sqlconn))
            da_brg.Fill(ds_vbrg, "_vbrg")

            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_OPNAME where no_trans ='" & no_transx & "' ", sqlconn))
            DA.Fill(dSO, "_opn")


            DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_OPNAME_DTL where no_trans ='" & no_transx & "' ", sqlconn))
            DA1.Fill(dSO, "_opn_detil")
            GcOpnStok.DataSource = dSO.Tables("_opn_detil")
        End If


    End Sub

    Private Sub frmInvMtsiStok_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DE_Tanggal.EditValue = Now
        Loadblthn()
        connect()
        prn = getParent(Me)
        'GvOpnStok.Columns("nilai_manual").Visible = False

        ReloadTable("xxxx", "xx")
        formate_yayak()

        DA_jns_persd = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan where Kd_Jns_Persd not in ('4','5')", sqlconn))
        DA_jns_persd.Fill(ds_jns_persd, "_persd")


        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang,Nama_Barang, kd_jns_persd " & _
                                                     "FROM SIF.dbo.SIF_Barang " & _
                                                     "where kd_jns_persd not in ('4' ,'5') " & _
                                                     "and rec_stat = 'Y'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepLookupStok.DataSource = ds_cari.Tables("_lookup1")
        RepLookupStok.ValueMember = "Kode_Barang"
        RepLookupStok.DisplayMember = "Nama_Barang"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookGdg")
        RepLookupGudang.DataSource = ds_cari1.Tables("_lookGdg")
        RepLookupGudang.ValueMember = "Kode_Gudang"
        RepLookupGudang.DisplayMember = "Nama_Gudang"

        'txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_opn").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ambilfile As New OpenFileDialog
        ambilfile.CheckFileExists = True
        ambilfile.Filter = "TXT File (*.txt) | *.txt"
        ambilfile.Title = "file harus ber extensi .txt"
        ambilfile.Multiselect = False
        ambilfile.ShowDialog()
        namafile = ambilfile.FileName
        'txbLokasi.Text = namafile
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If txbLokasi.Text = "" Then
        '    Exit Sub
        'End If
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

        lookupBulanAwal.EditValue = vbNullString
    End Sub

    Private Sub GvOpnStok_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvOpnStok.CellValueChanged
        Dim hitung_persen As Decimal



        If e.Column Is qty_opname Then
            GvOpnStok.GetRow(e.RowHandle).item("qty_selisih") = GvOpnStok.GetRow(e.RowHandle).item("qty_data") - GvOpnStok.GetRow(e.RowHandle).item("qty_opname")
            If GvOpnStok.GetRow(e.RowHandle).item("qty_data") > 0 And GvOpnStok.GetRow(e.RowHandle).item("qty_opname") > 0 Then
                hitung_persen = (Math.Abs(GvOpnStok.GetRow(e.RowHandle).item("qty_selisih")) / GvOpnStok.GetRow(e.RowHandle).item("qty_data") * 100)

            End If

        End If



        If e.Column Is kd_stok Then
            If lookupBulanAwal.EditValue = Nothing Or lookupBulanAwal.EditValue = "" Then
                MsgBox("Pilih periode terlebih dahulu..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan,B.lokasi " & _
                                                                  "from SIF.dbo.SIF_Barang B " & _
                                                                  "left join SIF.dbo.SIF_Satuan S " & _
                                                                  "on B.Kd_Satuan=S.Kode_Satuan " & _
                                                                  "where B.Kode_Barang = '" & e.Value.ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("kd_satuan") = dr.Item("Nama_Satuan")
            GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("kode_gudang") = dr.Item("lokasi")


            dr.Close()

            'Dim dr As SqlDataReader = New SqlClient.SqlCommand("Select I.qty_available, I.nilai_rata From INV.dbo.INV_STOK_SALDO I " & _
            '                                                   "where I.kd_stok = '" & e.Value.ToString & "' and I.bultah =(Select MAX(s.bultah) " & _
            '                                                   "from INV.dbo.INV_STOK_SALDO s where s.kd_stok=I.kd_stok)", sqlconn).ExecuteReader

            Dim dr1 As SqlDataReader = New SqlClient.SqlCommand("Select I.qty_available, I.nilai_rata From INV.dbo.INV_STOK_SALDO I " & _
                                                   "where I.kd_stok = '" & e.Value.ToString & "' and I.bultah ='" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
            dr1.Read()
            If dr1.HasRows Then
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_data") = IIf(dr1.Item("qty_available") Is DBNull.Value, 0, dr1.Item("qty_available"))
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_rata") = IIf(dr1.Item("nilai_rata") Is DBNull.Value, 0, dr1.Item("nilai_rata"))
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_manual") = IIf(dr1.Item("nilai_rata") Is DBNull.Value, 0, dr1.Item("nilai_rata"))
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_selisih") = IIf(dr1.Item("qty_available") Is DBNull.Value, 0, dr1.Item("qty_available"))
            Else
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_data") = 0
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_rata") = 0
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_manual") = 0
            End If

            dr1.Close()
        ElseIf e.Column Is kd_gudang Then
            Dim dr1 As SqlDataReader = New SqlClient.SqlCommand("Select I.akhir_qty From INV.dbo.INV_STOK_GUDANG I " & _
                                                                "INNER join SIF.dbo.SIF_Barang br " & _
                                                                "on br.Kode_Barang = I.kd_stok  " & _
                                                                "and br.Kd_Satuan = I.kd_satuan and br.kd_ukuran = I.kd_ukuran " & _
                                                                "INNER join SIF.dbo.SIF_Ukuran uk " & _
                                                                "on uk.Kode_Ukuran = br.kd_ukuran  " & _
                                                                "and uk.Tinggi = i.tinggi and uk.Lebar = I.lebar and uk.Panjang = I.panjang " & _
                                                                "where I.kd_stok = '" & GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("kd_stok") & "' and I.bultah ='" & lookupBulanAwal.EditValue & "' " & _
                                                                "and I.kode_gudang = '" & GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("kode_gudang") & "' ", sqlconn).ExecuteReader
            dr1.Read()
            If dr1.HasRows Then
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_data") = IIf(dr1.Item("akhir_qty") Is DBNull.Value, 0, dr1.Item("akhir_qty"))
                'GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_rata") = IIf(dr1.Item("nilai_rata") Is DBNull.Value, 0, dr1.Item("nilai_rata"))
                'GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_manual") = IIf(dr1.Item("nilai_rata") Is DBNull.Value, 0, dr1.Item("nilai_rata"))
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_selisih") = IIf(dr1.Item("akhir_qty") Is DBNull.Value, 0, dr1.Item("akhir_qty"))
            Else
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_data") = 0
                'GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_rata") = 0
                'GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_manual") = 0
                GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_selisih") = 0
            End If

            dr1.Close()
        End If
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvOpnStok.Columns("qty_data").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvOpnStok.Columns("qty_data").DisplayFormat.FormatString = "n3"
        GvOpnStok.Columns("qty_opname").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvOpnStok.Columns("qty_opname").DisplayFormat.FormatString = "n3"
        GvOpnStok.Columns("qty_selisih").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvOpnStok.Columns("qty_selisih").DisplayFormat.FormatString = "n3"

        GvOpnStok.Columns("nilai_rata").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvOpnStok.Columns("nilai_rata").DisplayFormat.FormatString = "n2"
        GvOpnStok.Columns("nilai_manual").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvOpnStok.Columns("nilai_manual").DisplayFormat.FormatString = "n2"

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

    End Sub



    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(2000)
    End Sub


    Private Sub GvOpnStok_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvOpnStok.InitNewRow
        GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("no_seq") = GcOpnStok.FocusedView.RowCount + 1
        GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("qty_opname") = 0
        GcOpnStok.FocusedView.GetRow(e.RowHandle).Item("nilai_manual") = 0
    End Sub

    Private Sub GvOpnStok_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GvOpnStok.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click()
        End If
    End Sub

    Sub delete_click()
        Dim x As Object
        x = CType(GcOpnStok.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            If GcOpnStok.FocusedView.Name = "GvOpnStok" Then
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub refreshNomer() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(GcOpnStok.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GcOpnStok.FocusedView.RowCount - 1
            GcOpnStok.FocusedView.GetRow(i).Item("no_seq") = i + 1
        Next
    End Sub
End Class