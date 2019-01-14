'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmBKI_internal
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_cari3, ds_vbrg, dsLookUp As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3, da_brg As SqlClient.SqlDataAdapter
    Dim x As Object
    Dim fortanggal As Date

    Private BTRAN As SqlTransaction

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
        tgl_retur.EditValue = getTanggal()
        STATE = "ADD" '<-- set state add

    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

        Dim r As Integer = Me.lookupBulanAwal.Properties.GetDataSourceRowIndex(Me.lookupBulanAwal.Properties.Columns("thnbln"), "2")
        lookupBulanAwal.EditValue = Me.lookupBulanAwal.Properties.GetDataSourceValue(lookupBulanAwal.Properties.ValueMember, r)
    End Sub

    'Sub loader()
    '    If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()
    '    'DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah=(select left(convert(varchar, '" & fortanggal & "', 112),6))", sqlconn))
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah= '" & Format(tgl_retur.EditValue, "yyyyMM") & "'", sqlconn))

    '    DALOOKUP.Fill(ds_cari, "_lookup2")
    '    LookupStok.DataSource = ds_cari.Tables("_lookup2")
    '    LookupStok.ValueMember = "Kode_Barang"
    '    LookupStok.DisplayMember = "Nama_Barang"
    'End Sub

    Sub lookbrg()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah=(select left(convert(varchar, '" & fortanggal & "', 112),6))", sqlconn))
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah= '" & lookupBulanAwal.EditValue & "'", sqlconn))

        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupStok.DataSource = ds_cari.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"
    End Sub

    Sub lookbrgAll()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah=(select left(convert(varchar, '" & fortanggal & "', 112),6))", sqlconn))
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi from SIF.dbo.SIF_Barang as brg where brg.kd_jns_persd in ('2','3') ", sqlconn))

        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupStok.DataSource = ds_cari.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"
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
        If txbNoref.Text = "" Or txbNmTrima.Text = "" Then
            MsgBox("NO Referensi dan Penerima tidak boleh KOSONG")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        bersihkan()
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        bersihkan()

    End Sub
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Public Sub edit_click()
        'enabel()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where substring((no_trans),12,5)='BKI-I'", sqlconn)) '
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  d.Kd_Cabang, d.no_trans, d.blthn,d.tgl_trans, d.no_ref, d.penerima, d.Last_Created_By [dibuat oleh] from INV.DBO.INV_GUDANG_OUT d where substring((no_trans),12,5)='BKI-I' " & _
                                                                   "and d.Program_Name = 'frmBKI_internal' ", sqlconn)) '
        If Not dSO.Tables("lookup_bki") Is Nothing Then dSO.Tables("lookup_bki").Clear()
        DA.Fill(dSO, "lookup_bki")
        frmCari.set_dso(dSO.Tables("lookup_bki")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(1))
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



        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bki").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            row.Item("cetak_ke") = 0
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bki").Rows(0)
            row.Item("Last_Update_Date") = getTanggal() 'Now
            row.Item("Last_Updated_By") = username

        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If
        'End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        'row.Item("no_trans") = getNoTrans("BKI", getTanggal())

        row.Item("tipe_trans") = "JPB-KUT-01"
        row.Item("tgl_trans") = tgl_retur.EditValue
        row.Item("no_rph") = LookupRPH.EditValue
        row.Item("no_ref") = txbNoref.Text
        row.Item("kd_kegiatan") = LookupKdKeg.Text
        row.Item("jml_rp_trans") = GvBMI_d.Columns(4).SummaryItem.SummaryValue
        row.Item("penerima") = txbNmTrima.Text
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bki").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
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
                row.Item("no_trans") = getNoTrans("BKI-I", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_ref") = row.Item("no_ref")
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            'txbNoTrans.Text = row.Item("no_trans")

            DA.Update(dSO.Tables("_bki"))
            DA2.Update(dSO1.Tables("_bkid"))

            'For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
            '    'If row1.RowState = DataRowState.Added Then
            '    Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_sppb_d set qty_sisa=" & row1("qty_sisa").ToString & " where kd_kegiatan='" & txbKeg.Text & "' and no_sppb='" & txbSPPB.Text & "' and kd_barang='" & row1("kd_stok") & "' ", sqlconn, BTRANS)
            '    sqlcmd.ExecuteNonQuery()

            'Next

            '### SP1
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_tujuan").ToString, row1("qty_out"), row1("qty_lain"), BTRANS)
                End If
            Next

            ''### Sp ke 2
            'For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        'setor_prosedur2(blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '        setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '    End If
            'Next


            'dSO.Tables("_bki").AcceptChanges()
            'dSO1.Tables("_bkid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bki").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal qty_lainx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal, 32).Value = qty_outx
        sqlCmd.Parameters.Add("@qty_lain_out", SqlDbType.Decimal, 32).Value = qty_lainx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub setor_prosedur2(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_outx As Integer, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
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




    Private Sub frmBKI_internal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'tgl_retur.EditValue = getTanggal()
        'tgl_retur.EditValue = Today
        LookupGudang.EditValue = "G0004"

        LoadStruktur("xxxx")
        Loadblthn()
        formate_yayak()

        GvBMI_d.Columns("rp_trans").Visible = False
        GvBMI_d.Columns("harga").Visible = False
        GvBMI_d.Columns("kd_ukuran").Visible = False
        GvBMI_d.Columns("panjang").Visible = False
        GvBMI_d.Columns("lebar").Visible = False
        GvBMI_d.Columns("tinggi").Visible = False
        'GvBMI_d.Columns("kd_satuan").Visible = False
        GvBMI_d.Columns("gudang_asal").Visible = False

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang where Kode_Gudang in('G0004','G0005')", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_gdg3")
        LookupGudang.Properties.DataSource = ds_cari3.Tables("_gdg3")
        LookupGudang.Properties.ValueMember = "Kode_Gudang"
        LookupGudang.Properties.DisplayMember = "Nama_Gudang"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_gdg1")
        Rep_gdg_asal.DataSource = ds_cari1.Tables("_gdg1")
        Rep_gdg_asal.ValueMember = "Kode_Gudang"
        Rep_gdg_asal.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_gdg2")
        Rep_gdg_tujuan.DataSource = ds_cari2.Tables("_gdg2")
        Rep_gdg_tujuan.ValueMember = "Kode_Gudang"
        Rep_gdg_tujuan.DisplayMember = "Nama_Gudang"
        'LookupGudang.EditValue = "G0001"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,ISNULL(brg.kd_ukuran,0)as kd_ukuran,ISNULL(brg.panjang,0) as panjang,ISNULL(brg.lebar,0) as lebar,isnull(brg.tinggi,0)as tinggi,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok,brg.rek_persediaan from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah='" & lookupBulanAwal.EditValue & "'", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup2")
        'LookupStok.DataSource = ds_cari.Tables("_lookup2")
        'LookupStok.ValueMember = "Kode_Barang"
        'LookupStok.DisplayMember = "Nama_Barang"


        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_rph) from PROD.dbo.PROD_sppb_m", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_rph")
        LookupRPH.Properties.DataSource = ds_cari3.Tables("_rph")
        LookupRPH.Properties.ValueMember = "no_rph"
        LookupRPH.Properties.DisplayMember = "no_rph"

        DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD'", sqlconn))
        DA3.Fill(ds_vbrg, "_kdkeg")
        LookupKdKeg.Properties.DataSource = ds_vbrg.Tables("_kdkeg")
        LookupKdKeg.Properties.ValueMember = "kd_kegiatan"
        LookupKdKeg.Properties.DisplayMember = "desc_data"
        'txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())

    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        lookbrgAll()
        If Not dSO.Tables("_bki") Is Nothing Then dSO.Tables("_bki").Clear()
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bki")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang,0 as harga,0 as akhir_qty_onstok from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bkid")
        GcBMI_d.DataSource = dSO1.Tables("_bkid")

        'da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd='3'", sqlconn))
        'da_brg.Fill(ds_vbrg, "_vbrg")

    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvBMI_d.Columns("qty_out").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBMI_d.Columns("qty_out").DisplayFormat.FormatString = "n3"
        'GvBME_d.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvBME_d.Columns("qty_order").DisplayFormat.FormatString = "n3"
        'GvBME_d.Columns("qty_qc_service").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvBME_d.Columns("qty_qc_service").DisplayFormat.FormatString = "n3"
        'GvBME_d.Columns("qty_qc_rusak").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvBME_d.Columns("qty_qc_rusak").DisplayFormat.FormatString = "n3"
    End Sub

    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged

        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds_cari.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")(0)
            GvBMI_d.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
            GvBMI_d.GetRow(e.RowHandle).item("gudang_asal") = rw("lokasi")
            GvBMI_d.GetRow(e.RowHandle).item("kd_buku_besar") = rw("rek_persediaan")
            GvBMI_d.GetRow(e.RowHandle).item("gudang_tujuan") = LookupGudang.EditValue
            GvBMI_d.GetRow(e.RowHandle).item("harga") = rw("nilai_rata")
            GvBMI_d.GetRow(e.RowHandle).item("kd_ukuran") = rw("kd_ukuran")
            GvBMI_d.GetRow(e.RowHandle).item("panjang") = rw("panjang")
            GvBMI_d.GetRow(e.RowHandle).item("lebar") = rw("lebar")
            GvBMI_d.GetRow(e.RowHandle).item("tinggi") = rw("tinggi")
            GvBMI_d.GetRow(e.RowHandle).item("akhir_qty_onstok") = rw("akhir_qty_onstok")

        End If
        If e.Column Is qty_out Then
            'Dim rw As DataRow
            'rw = ds_cari.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")(0)
            GvBMI_d.GetRow(e.RowHandle).item("rp_trans") = GvBMI_d.GetRow(e.RowHandle).item("qty_out") * GvBMI_d.GetRow(e.RowHandle).item("harga")
        End If
    End Sub

    Private Sub GvBMI_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBMI_d.InitNewRow
        GvBMI_d.GetRow(e.RowHandle).item("no_seq") = GvBMI_d.RowCount + 1
    End Sub


    Public Sub bersihkan()
        txbNoTrans.Text = ""
        txbNmTrima.Text = ""
        txbNoref.Text = ""
        LookupKdKeg.EditValue = vbNullString
        LookupRPH.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Public Sub cetak_click()
        'If STATE = "EDIT" Then
        'STATE = "CETAK"
        'simpan()
        'End If
        callReport(App_Path() & "\report\BKI2.rpt", "", "notrans=" & txbNoTrans.Text, False, False)
        Dim sqcmd As New SqlCommand("update INV.dbo.GUDANG_OUT set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()

    End Sub



    Private Sub tgl_retur_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgl_retur.EditValueChanged
        'tgl_retur.EditValue = getTanggal()
        'fortanggal = tgl_retur.EditValue
        'loader()
        'lookbrg()
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        lookbrg()
    End Sub
End Class