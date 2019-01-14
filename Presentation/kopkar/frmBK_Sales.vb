﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient

Public Class frmBK_Sales
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, ds_cari, ds_sales, ds_asal, ds_7an, ds_vbrg, ds_keypress As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, da_gd_asal, DALOOKUP, DALOOKUP2, da_gd_7an, da_brg, DA_keypres As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private isDel As Boolean



    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        bersihkan()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD" '<-- set state add
        'Look_Sales.Focus()
        txtcari.Focus()
    End Sub



    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        'If TxbPenerima.Text = "" Then
        '    MsgBox("Gudang Tujuan Tidak Boleh KOSONG !", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
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

    Public Sub bersihkan()
        x = 1
        dSO.Clear()
        dSO1.Clear()
        tx_qty.Text = ""
        TxbBarcode.Text = ""
        txtcari.Text = ""
        txbNoTrans.Text = ""
        Look_Sales.EditValue = vbNullString
    End Sub

    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select s.Nama_Sales,g.tgl_trans,g.no_trans from INV.DBO.INV_GUDANG_OUT g left join SIF.dbo.SIF_Sales s on g.gudang_tujuan=s.Kode_Sales where substring((g.no_trans),12,3)='EXP'", sqlconn)) '
        If Not dSO.Tables("lookup_bke") Is Nothing Then dSO.Tables("lookup_bke").Clear()
        DA.Fill(dSO, "lookup_bke")
        frmCari.set_dso(dSO.Tables("lookup_bke")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(2))
            btnadd = False
            btnSave = True
            btnEdit = False
            btnDelete = True
            STATE = "EDIT"
            btnCancel = True
            Me.Enabled = True
            setStatus()

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Melakukan Hapus/Pembatalan Data QC ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data/Pembatalan?") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("_bke") Is Nothing Then
                For Each rw As DataRow In dSO.Tables("_bke").Rows
                    rw.Delete()
                Next
            End If
            If Not dSO1.Tables("_bke_d") Is Nothing Then
                For Each rw As DataRow In dSO1.Tables("_bke_d").Rows
                    rw.Delete()
                Next
            End If

            save_click(True)
            cancel_click()
            STATE = "EDIT"
        End If
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        
        Dim BTRANS As SqlTransaction

        If Not isDelete Then

            'End If
            If STATE = "ADD" Then
                row = dSO.Tables("_bke").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener


                row.Item("tipe_trans") = "JPB-KUT-01"
                row.Item("tgl_trans") = dt_tgl.EditValue
                row.Item("sj_kembali") = 0
                'row.Item("gudang_asal") = LuGdgAsal.EditValue
                row.Item("jml_rp_trans") = GvBK.Columns(7).SummaryItem.SummaryValue
                row.Item("blthn") = blthn()
                row.Item("gudang_tujuan") = Look_Sales.EditValue
                row.Item("Program_Name") = Me.Name
                'txbNoTrans.Text = row.Item("no_trans")
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_bke").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username

                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener


                row.Item("tipe_trans") = "JPJ-KPT-19"
                row.Item("tgl_trans") = dt_tgl.EditValue
                row.Item("sj_kembali") = 0
                'row.Item("gudang_asal") = LuGdgAsal.EditValue
                row.Item("jml_rp_trans") = GvBK.Columns(7).SummaryItem.SummaryValue
                row.Item("blthn") = blthn()
                row.Item("gudang_tujuan") = Look_Sales.EditValue
                row.Item("Program_Name") = Me.Name
                'txbNoTrans.Text = row.Item("no_trans")
            End If
            

            If STATE = "ADD" Then
                dSO.Tables("_bke").Rows.Add(row)
            End If
            If Not STATE = "DELETE" Then
                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("tipe_trans") = row.Item("tipe_trans")
                        row1.Item("Last_Create_Date") = getTanggal()
                        row1.Item("Last_Created_By") = username
                        row1.Item("kd_Cabang") = kdcabang
                    Else
                        'Dim sqlrd As SqlDataReader=New SqlCommand("update 
                        row1.Item("Last_Update_Date") = getTanggal()
                        row1.Item("Last_Updated_By") = username
                    End If
                    row1.Item("Program_name") = Me.Name
                Next
            End If
        End If
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
                row.Item("no_trans") = getNoTrans("POS", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            DA.Update(dSO.Tables("_bke"))
            DA2.Update(dSO1.Tables("_bke_d"))

            'update sisa ke table prod_dpb_d dialukukan via triger karena memungkinkan, lain dgn BKI(sppb) dan BME (po)

            '## spc stok saldo gudang out
            If STATE = "ADD" Then
                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    stprc_gdout(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_out"), 0, BTRANS)
                    stprc_gdout(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_out"), 0, BTRANS)
                Next
            End If

            ' ## sp 2
            'For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        stprc_onstokout(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_out"), row1("rp_trans"), BTRANS)
            '    End If
            'Next
            'dSO.Tables("_bke").AcceptChanges()
            'dSO1.Tables("_bke_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()

            showMessages("Berhasil disimpan..!")
            bersihkan()
            add_click()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges() ' untuk membatalkan row yg diupdate/insert

            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")


        End Try
    End Sub
    Public Sub stprc_gdout(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal qty_outx As Decimal, ByVal qty_lainx As Decimal, ByVal BTRANS As SqlTransaction)

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
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.Parameters.Add("@qty_lain_out", SqlDbType.Decimal).Value = qty_lainx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_onstokout(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal panjangx As Decimal, ByVal lebarx As Decimal, ByVal tinggix As Decimal, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Decimal).Value = qty_inx
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


    Public Sub hapus_record()

    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BK_Loading.rpt", "", "no_mtsi=" & txbNoTrans.Text, False, True)
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama_Barang,0 as no_seq,0 as qty_out,0 as akhir_qty_onstok from KOPKAR.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bke_d")
        GcBK.DataSource = dSO1.Tables("_bke_d")

        da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from KOPKAR.dbo.SIF_Barang where kd_jns_persd<>'4'", sqlconn))
        da_brg.Fill(ds_vbrg, "_vbrg")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_ref) FROM INV.dbo.INV_GUDANG_OUT", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            'LookupNoPOL.Properties.DataSource = ds_cari.Tables("_lookup1")

            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            Look_Sales.EditValue = rw("gudang_tujuan").ToString
            'LookupNoPOL.EditValue = rw("no_dpb").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString

        Else
            'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_ref) as no_dpb FROM PROD.dbo.PROD_dpb_m  ", sqlconn))
            'DALOOKUP.Fill(ds_cari, "_lookup1")
            'LookupNoPOL.Properties.DataSource = ds_cari.Tables("_lookup1")

        End If

    End Sub


    Private Sub frmBK_Sales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)


        connect()
        Look_Sales.Visible = False
        'GvBK.Columns("rp_trans").Visible = False
        'GvBK.Columns("harga").Visible = False
        LoadStruktur("xxx")
        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
        dt_tgl.EditValue = Today

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from KOPKAR.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RL_Barang.DataSource = ds_cari.Tables("_lookup1")
        RL_Barang.ValueMember = "Kode_Barang"
        RL_Barang.DisplayMember = "Nama_Barang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang,Keterangan from KOPKAR.dbo.SIF_Gudang", sqlconn))
        DALOOKUP2.Fill(ds_sales, "_sales")
        Look_Sales.Properties.DataSource = ds_sales.Tables("_sales")
        Look_Sales.Properties.ValueMember = "Kode_Gudang"
        Look_Sales.Properties.DisplayMember = "Nama_Gudang"

        da_gd_asal = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from KOPKAR.dbo.SIF_Gudang", sqlconn))
        da_gd_asal.Fill(ds_asal, "_gdg_asal")
        RL_gdg_asal.DataSource = ds_asal.Tables("_gdg_asal")
        RL_gdg_asal.ValueMember = "Kode_Gudang"
        RL_gdg_asal.DisplayMember = "Nama_Gudang"

        da_gd_7an = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from KOPKAR.dbo.SIF_Gudang", sqlconn))
        da_gd_7an.Fill(ds_7an, "_7an")
        RL_Gdg_Tujuan.DataSource = ds_7an.Tables("_7an")
        RL_Gdg_Tujuan.ValueMember = "Kode_Gudang"
        RL_Gdg_Tujuan.DisplayMember = "Nama_Gudang"

    End Sub

    Private Sub TxbBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress

        'sementara di non aktifkan
        'If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        'Dim ok As Boolean = False
        'If e.KeyChar = Chr(13) Then
        '    DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,isnull(brg.kd_ukuran,0) as kd_ukuran,isnull(brg.panjang,0)as panjang,isnull(brg.lebar,0)as lebar, isnull(brg.tinggi,0)as tinggi,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd in ('1','2','3') and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
        '    DA_keypres.Fill(ds_keypress, "_keypres")
        '    If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
        '        Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcode.Text & "'")
        '        lblNmBrg.ForeColor = Color.Yellow
        '        lblStatus.ForeColor = Color.Yellow
        '        'For i As Int16 = 0 To dtrow.Count - 1
        '        'Application.DoEvents()
        '        If dtrow.Count = 0 Then
        '            'DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
        '            'DA_keypres.Fill(ds_keypress, "_keypres")
        '            Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
        '            Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
        '            rw.Item("no_seq") = x : x += 1
        '            rw.Item("kd_stok") = rwx.Item("Kode_Barang")
        '            rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
        '            rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
        '            rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
        '            rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
        '            rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
        '            rw.Item("qty_out") = rwx.Item("qty_out") + 1
        '            rw.Item("gudang_asal") = rwx.Item("lokasi")
        '            rw.Item("tinggi") = rwx.Item("tinggi")
        '            rw.Item("lebar") = rwx.Item("lebar")
        '            rw.Item("panjang") = rwx.Item("panjang")
        '            rw.Item("harga") = rwx.Item("harga")
        '            rw.Item("rp_trans") = rw("harga") * rw("qty_out")
        '            dSO1.Tables("_bke_d").Rows.Add(rw)

        '            TxbBarcode.Text = ""
        '            lblNmBrg.Text = ""
        '            lblStatus.Text = ""
        '            TxbBarcode.Focus()
        '            Exit Sub
        '        Else
        '            For i As Int16 = 0 To dtrow.Count - 1
        '                'Application.DoEvents()
        '                lblStatus.Text = "OK"
        '                lblNmBrg.Text = dtrow(i)("kd_stok").ToString
        '                TxbBarcode.SelectAll()
        '                'If dtrow(i)("qty_ord") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
        '                'If dtrow.Count > 0 Then
        '                dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
        '                dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")

        '                'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
        '                ok = True
        '                BindingContext(GcBK.DataSource).Position = getPosisi(dtrow(i))
        '                tunda()
        '                TxbBarcode.Text = ""
        '                lblNmBrg.Text = ""
        '                lblStatus.Text = ""
        '                TxbBarcode.Focus()
        '                'MsgBox("barang ada")
        '                Exit Sub
        '                'End If
        '            Next

        '        End If
        '    Else
        '        lblNmBrg.ForeColor = Color.Magenta
        '        lblStatus.ForeColor = Color.Magenta

        '        lblNmBrg.Text = "Item tidak ada dalam Daftar"
        '        lblStatus.Text = "KOSONG"
        '        tunda()
        '        TxbBarcode.Text = ""
        '        lblNmBrg.Text = ""
        '        lblStatus.Text = ""
        '        TxbBarcode.Focus()
        '    End If
        '    TxbBarcode.SelectAll()
        'End If
        'ds_keypress.Clear()
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_bke_d").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function


    Private Sub txtcari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If e.KeyCode = Keys.Enter Then
            tx_qty.Focus()
        End If
        'If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        'Dim ok As Boolean = False
        'If e.KeyCode = Keys.Enter Then

        '    DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_out,stok.nilai_rata as harga,isnull(brg.panjang,0) as panjang, isnull(brg.lebar,0)as lebar, isnull(brg.tinggi,0)as tinggi from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.Nama_Barang='" & txtcari.Text & "'", sqlconn))
        '    DA_keypres.Fill(ds_keypress, "_keypres")
        '    If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
        '        Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("nama_barang='" & txtcari.Text & "'")
        '        lblNmBrg.ForeColor = Color.Yellow
        '        lblStatus.ForeColor = Color.Yellow
        '        'For i As Int16 = 0 To dtrow.Count - 1
        '        'Application.DoEvents()
        '        If dtrow.Count = 0 Then
        '            'DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
        '            'DA_keypres.Fill(ds_keypress, "_keypres")
        '            Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
        '            Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
        '            rw.Item("no_seq") = x : x += 1
        '            rw.Item("kd_stok") = rwx.Item("Kode_Barang")
        '            rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
        '            rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
        '            rw.Item("nama_barang") = rwx.Item("Nama_Barang")
        '            rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
        '            rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
        '            rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
        '            rw.Item("qty_out") = tx_qty.Text
        '            rw.Item("gudang_asal") = rwx.Item("lokasi")
        '            rw.Item("tinggi") = rwx.Item("tinggi")
        '            rw.Item("lebar") = rwx.Item("lebar")
        '            rw.Item("panjang") = rwx.Item("panjang")
        '            rw.Item("harga") = rwx.Item("harga")
        '            rw.Item("rp_trans") = rw("harga") * rw("qty_out")
        '            dSO1.Tables("_bke_d").Rows.Add(rw)

        '            lblStatus.Text = "OK"
        '            lblNmBrg.Text = rw.Item("nama_barang")
        '            txtcari.SelectAll()
        '            tunda()
        '            txtcari.Text = ""
        '            lblNmBrg.Text = ""
        '            lblStatus.Text = ""
        '            txtcari.Focus()
        '            Exit Sub
        '        Else
        '            For i As Int16 = 0 To dtrow.Count - 1
        '                'Application.DoEvents()
        '                lblStatus.Text = "OK"
        '                lblNmBrg.Text = dtrow(i)("nama_barang").ToString
        '                txtcari.SelectAll()
        '                'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
        '                'If dtrow.Count > 0 Then
        '                dtrow(i)("qty_in") = dtrow(i)("qty_out") + 1
        '                dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")

        '                'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
        '                ok = True
        '                BindingContext(GcBK.DataSource).Position = getPosisi(dtrow(i))
        '                tunda()
        '                txtcari.Text = ""
        '                lblNmBrg.Text = ""
        '                lblStatus.Text = ""
        '                txtcari.Focus()
        '                'MsgBox("barang ada")
        '                Exit Sub
        '                'End If
        '            Next

        '        End If
        '    Else
        '        lblNmBrg.ForeColor = Color.Magenta
        '        lblStatus.ForeColor = Color.Magenta

        '        lblNmBrg.Text = "Item tidak ada dalam Daftar"
        '        lblStatus.Text = "KOSONG"
        '        tunda()
        '        txtcari.Text = ""
        '        lblNmBrg.Text = ""
        '        lblStatus.Text = ""
        '        txtcari.Focus()
        '    End If
        '    txtcari.SelectAll()
        'End If
        'ds_keypress.Clear()
        ''GvBK.FocusedColumn = GvBK.VisibleColumns(3)
    End Sub



    Private Sub tx_qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx_qty.KeyDown
        'STATE = "ADD"
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            'DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,isnull(brg.rek_persediaan,0)rek_persediaan,isnull(brg.rek_biaya,0)rek_biaya,0 as qty_out,isnull(stok.akhir_qty_onstok,0)akhir_qty_onstok,isnull(stok.nilai_rata,0) as harga,isnull(brg.panjang,0) as panjang, isnull(brg.lebar,0)as lebar, isnull(brg.tinggi,0)as tinggi from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.Nama_Barang='" & txtcari.Text & "' or Kode_Barang ='" & TxbBarcode.Text & "' ", sqlconn))
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,isnull(brg.rek_persediaan,0)rek_persediaan,isnull(brg.rek_biaya,0)rek_biaya,0 as qty_out,isnull(stok.akhir_qty_onstok,0)akhir_qty_onstok,isnull(h.harga_jual,0) as harga,isnull(brg.panjang,0) as panjang, isnull(brg.lebar,0)as lebar, isnull(brg.tinggi,0)as tinggi from KOPKAR.dbo.INV_STOK_SALDO as stok left OUTER join KOPKAR.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang left outer join KOPKAR.dbo.SIF_Harga h on brg.Kode_Barang=h.Kode_Barang where brg.Nama_Barang='" & txtcari.Text & "' or brg.Kode_Barang ='" & TxbBarcode.Text & "' ", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("Nama_Barang='" & txtcari.Text & "' or kd_stok ='" & TxbBarcode.Text & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    'DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
                    'DA_keypres.Fill(ds_keypress, "_keypres")
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("nama_barang") = rwx.Item("Nama_Barang")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("qty_out") = tx_qty.Text
                    rw.Item("gudang_asal") = rwx.Item("lokasi")
                    rw.Item("gudang_tujuan") = Look_Sales.EditValue
                    rw.Item("tinggi") = rwx.Item("tinggi")
                    rw.Item("lebar") = rwx.Item("lebar")
                    rw.Item("panjang") = rwx.Item("panjang")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_out")
                    rw.Item("akhir_qty_onstok") = rwx("akhir_qty_onstok")
                    dSO1.Tables("_bke_d").Rows.Add(rw)

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = rw.Item("nama_barang")
                    txtcari.SelectAll()
                    TxbBarcode.SelectAll()
                    tunda()
                    txtcari.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    'TxbBarcode.Focus()
                    txtcari.Focus()
                    Exit Sub
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                        txtcari.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("qty_out") = dtrow(i)("qty_out") + tx_qty.Text
                        dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcBK.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        txtcari.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        TxbBarcode.Text = ""
                        'TxbBarcode.Focus()
                        txtcari.Focus()
                        'MsgBox("barang ada")
                        Exit Sub
                        'End If
                    Next

                End If
            Else
                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta

                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                tx_qty.Text = ""
                TxbBarcode.Text = ""
                'TxbBarcode.Focus()
                txtcari.Focus()
            End If
            txtcari.SelectAll()
            TxbBarcode.SelectAll()
        End If
        ds_keypress.Clear()

    End Sub

    Private Sub TxbBarcode_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxbBarcode.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.Enter Then
            save_click()
        ElseIf e.KeyCode = Keys.Enter Then
            tx_qty.Focus()
        End If
    End Sub

    Private Sub GvBK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GvBK.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Hapus baris ini? ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                GvBK.DeleteSelectedRows()
                STATE = "DELETE"

            End If

        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.Enter Then
            save_click()
        End If
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO1.Tables("_bke_d").Rows
            row.Item("no_seq") = i : i += 1
        Next
    End Sub

    Private Sub dt_tgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_tgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            'TxbBarcode.Focus()
            txtcari.Focus()
        End If
    End Sub

 
End Class