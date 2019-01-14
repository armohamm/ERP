'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frm_transfBrg
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, ds_cari1, ds_cari2, ds_cari3, dsLookUp As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
    Dim x As Object

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
        Dim notran As String

        'If STATE = "ADD" Then
        '    row = dSO.Tables("_transf").NewRow
        '    row.Item("Last_Create_Date") = getTanggal()
        '    row.Item("Last_Created_By") = username
        '    row.Item("rec_stat") = "Y"
        'ElseIf STATE = "EDIT" Then
        '    row = dSO.Tables("_transf").Rows(0)
        '    row.Item("Last_Update_Date") = getTanggal()
        '    row.Item("Last_Updated_By") = username
        'End If


        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS


            If STATE = "ADD" Then
                notran = getNoTrans("TRANF", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = notran
                For Each row As DataRow In dSO.Tables("_transf").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("Last_Create_Date") = getTanggal(BTRANS)
                        row.Item("Last_Created_By") = username
                        row.Item("rec_stat") = "Y"
                        row.Item("no_trans") = notran
                        row.Item("blthn") = blthn(BTRANS)
                        row.Item("kd_cabang") = kdcabang
                    End If
                Next
            End If
            'txbNoTrans.Text = row.Item("no_trans")

            DA.Update(dSO.Tables("_transf"))
            'DA2.Update(dSO1.Tables("_bmid"))

            '### SP1
            For Each row As DataRow In dSO.Tables("_transf").Rows
                If STATE = "ADD" Then
                    stprc_gudang_in(kdcabang, blthn(BTRANS), row("kd_barang2").ToString, row("kd_satuan2"), row("kd_ukuran").ToString, row("tinggi"), row("lebar"), row("panjang"), row("lokasi").ToString, row("qty2"), BTRANS)
                    stprc_gudang_out(kdcabang, blthn(BTRANS), row("kd_barang1").ToString, row("kd_satuan1"), row("kd_ukuran").ToString, row("tinggi"), row("lebar"), row("panjang"), row("lokasi").ToString, row("qty1"), BTRANS)

                    'stprc_saldo_out(kdcabang, blthn(BTRANS), row("kd_barang1").ToString, row("kd_satuan1").ToString, row("kd_ukuran"), row("tinggi"), row("lebar"), row("panjang"), row("qty1"), 0, BTRANS)
                    'stprc_saldo_in(kdcabang, blthn(BTRANS), row("kd_barang2").ToString, row("kd_satuan2").ToString, row("kd_ukuran"), row("tinggi"), row("lebar"), row("panjang"), row("qty2"), row("nilai1"), BTRANS)
                    'stprc_saldo_in(kdcabang, blthn(BTRANS), row("kd_barang2").ToString, row("kd_satuan2").ToString, row("kd_ukuran"), row("tinggi"), row("lebar"), row("panjang"), row("qty2"), row("nilai1"), BTRANS)

                End If
            Next

            '### Sp ke 2 saldo
            'For Each row As DataRow In dSO1.Tables("_bmid").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        'setor_prosedur2(blthn(BTRANS), row("kd_stok").ToString, row("kd_satuan").ToString, row("qty_out"), row("rp_trans"), BTRANS)
            '        'stprc_onstok(kdcabang, blthn(BTRANS), row("kd_stok").ToString, row("kd_satuan").ToString, row("qty_in"), row("rp_trans"), BTRANS)
            '    End If
            'Next


            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_transf").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub stprc_gudang_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal lokasix As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = lokasix
        'sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal, 32).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_gudang_out(ByVal kd_cabangx1 As String, ByVal bultah As String, ByVal kd_stokx1 As String, ByVal kd_ukuranx1 As String, ByVal satuanx1 As String, ByVal tinggix1 As Decimal, ByVal lebarx1 As Decimal, ByVal panjangx1 As Decimal, ByVal lokasix1 As String, ByVal qty_outx1 As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx1
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx1
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx1
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx1
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix1
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx1
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx1
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = lokasix1
        'sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal, 32).Value = qty_outx1
        sqlCmd.ExecuteNonQuery()
    End Sub


    Public Sub stprc_saldo_out(ByVal kd_cabangx As String, ByVal bultahx As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal qty_outx As Integer, ByVal rpnilaix As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultahx
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Int).Value = qty_outx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilaix
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo_in(ByVal kd_cabangxx As String, ByVal bultahxx As String, ByVal kd_stokxx As String, ByVal kd_satuanxx As String, ByVal kd_ukuranxx As String, ByVal tinggixx As Decimal, ByVal lebarxx As Decimal, ByVal panjangxx As Decimal, ByVal qty_outxx As Integer, ByVal rpnilaixx As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangxx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultahxx
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokxx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanxx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranxx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggixx
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarxx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangxx
        sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Int).Value = qty_outxx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilaixx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans,* from SIF.dbo.SIF_transf_brg", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
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

    Public Sub save_click()

        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        'bersihkan()
        btnadd = True
        btnSave = False
        btnDelete = False
        Me.Enabled = False
        setStatus()
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'dtpTgl.EditValue = getTanggal()
        ' bersihkan()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Private Sub frm_transfBrg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur("xxxx")

        dteTanggal.EditValue = Today
        Gv_TransfBrg.Columns("hasilx").Visible = False
        Gv_TransfBrg.Columns("nilai1").Visible = False

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select 0 as priority,kv.kd_barang,kv.nama_barang,kv.kode_satuan_1,kv.kode_satuan_2,kv.hasil,0 as rek_persediaan,'' as lokasi,0 as kd_ukuran,0 as panjang,0 as lebar,0 as tinggi,stok.nilai_rata from sif.dbo.SIF_konversi as kv inner join INV.dbo.INV_STOK_SALDO as stok on kv.kd_barang=stok.kd_stok where stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) UNION select 1 as priority,brg.Kode_barang,brg.nama_barang,brg.Kd_Satuan,'' as kode_satuan_2,0 as hasil,brg.rek_persediaan,brg.lokasi,isnull(brg.kd_ukuran,0)as kd_ukuran,isnull(brg.panjang,0) as panjang,isnull(uk.Lebar,0)as lebar,isnull(brg.Tinggi,0) as tinggi ,stok.nilai_rata from SIF.dbo.SIF_Barang brg inner join INV.dbo.INV_STOK_SALDO as stok on brg.Kode_Barang=stok.kd_stok left join sif.dbo.SIF_Ukuran as uk on brg.kd_ukuran=uk.Kode_Ukuran where brg.kd_jns_persd in ('1','2','3') and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO)", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup1")
        'rpBrg1.DataSource = ds_cari1.Tables("_lookup1")
        'rpBrg1.ValueMember = "kd_barang"
        'rpBrg1.DisplayMember = "nama_barang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Nama_Barang,Kode_Barang,Kd_Satuan from SIF.dbo.SIF_Barang where kd_jns_persd in ('1','2','3')", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_brg2")
        rpLookBrg2.DataSource = ds_cari2.Tables("_brg2")
        rpLookBrg2.ValueMember = "Kode_Barang"
        rpLookBrg2.DisplayMember = "Nama_Barang"

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select DISTINCT(Kd_Satuan) from sif.dbo.SIF_Barang", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_sat2")
        repKdsatuan2.DataSource = ds_cari3.Tables("_sat2")
        repKdsatuan2.ValueMember = "Kd_Satuan"
        repKdsatuan2.DisplayMember = "Kd_Satuan"

        Loadblthn()

    End Sub

    Private Sub loadbrg()
        If Not ds_cari1.Tables("_lookup1") Is Nothing Then ds_cari1.Tables("_lookup2").Clear()
        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select 0 as priority,kv.kd_barang,kv.nama_barang,kv.kode_satuan_1,kv.kode_satuan_2,kv.hasil,0 as rek_persediaan,'' as lokasi,0 as kd_ukuran,0 as panjang,0 as lebar,0 as tinggi,stok.nilai_rata from sif.dbo.SIF_konversi as kv inner join INV.dbo.INV_STOK_SALDO as stok on kv.kd_barang=stok.kd_stok where stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) UNION select 1 as priority,brg.Kode_barang,brg.nama_barang,brg.Kd_Satuan,'' as kode_satuan_2,0 as hasil,brg.rek_persediaan,brg.lokasi,isnull(brg.kd_ukuran,0)as kd_ukuran,isnull(brg.panjang,0) as panjang,isnull(uk.Lebar,0)as lebar,isnull(brg.Tinggi,0) as tinggi ,stok.nilai_rata from SIF.dbo.SIF_Barang brg inner join INV.dbo.INV_STOK_SALDO as stok on brg.Kode_Barang=stok.kd_stok left join sif.dbo.SIF_Ukuran as uk on brg.kd_ukuran=uk.Kode_Ukuran where brg.kd_jns_persd in ('1','2','3') and stok.bultah='" & lookupBulanAwal.EditValue & "'", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup1")
        rpBrg1.DataSource = ds_cari1.Tables("_lookup1")
        rpBrg1.ValueMember = "kd_barang"
        rpBrg1.DisplayMember = "nama_barang"
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub


    Private Sub Gv_TransfBrg_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gv_TransfBrg.CellValueChanged
        If e.Column Is kd_barang1 Then
            Dim rw As DataRow
            rw = ds_cari1.Tables("_lookup1").Select("kd_barang='" & e.Value & "'")(0)
            Gv_TransfBrg.GetRow(e.RowHandle).item("kd_satuan1") = rw("kode_satuan_1")
            Gv_TransfBrg.GetRow(e.RowHandle).item("nilai1") = rw("nilai_rata") * rw("hasil")
            Gv_TransfBrg.GetRow(e.RowHandle).item("kd_satuan2") = rw("kode_satuan_2")
            Gv_TransfBrg.GetRow(e.RowHandle).item("hasilx") = rw("hasil")
            Gv_TransfBrg.GetRow(e.RowHandle).item("qty1") = 1
            Gv_TransfBrg.GetRow(e.RowHandle).item("qty2") = rw("hasil")
            Gv_TransfBrg.GetRow(e.RowHandle).item("kd_ukuran") = rw("kd_ukuran")
            'MsgBox(rw("panjang") & rw("lebar") & rw("tinggi") & rw("hasil"))
            Gv_TransfBrg.GetRow(e.RowHandle).item("panjang") = rw("panjang")
            Gv_TransfBrg.GetRow(e.RowHandle).item("lebar") = rw("lebar")
            Gv_TransfBrg.GetRow(e.RowHandle).item("tinggi") = rw("tinggi")
        End If

        If e.Column Is qty1 Then
            Gv_TransfBrg.GetRow(e.RowHandle).item("qty2") = Gv_TransfBrg.GetRow(e.RowHandle).item("qty1") * Gv_TransfBrg.GetRow(e.RowHandle).item("hasilx")
        End If
        If e.Column Is kd_barang2 Then
            If Gv_TransfBrg.GetRow(e.RowHandle).item("qty2") = vbNullString Then
                'MsgBox("kosong")
                Dim rw2 As DataRow
                rw2 = ds_cari2.Tables("_brg2").Select("Kode_Barang='" & e.Value & "'")(0)
                Gv_TransfBrg.GetRow(e.RowHandle).item("kd_satuan2") = rw2("Kd_Satuan")
            End If
            
        End If
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        'If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO.Tables("_transf") Is Nothing Then dSO.Tables("_transf").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as hasilx,'' as lokasi,0 as rek_persediaan from SIF.dbo.SIF_transf_brg where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_transf")

        'DA = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DA.Fill(dSO, "_transfbrg") 'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as kd_customer,'' as kode_gudang,0 as harga from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        'DA2.Fill(dSO1, "_bke_d")
        Gc_TransBrg.DataSource = dSO.Tables("_transf")

        If dSO.Tables("_transf").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_transf").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
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


    Private Sub Gv_TransfBrg_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles Gv_TransfBrg.InitNewRow
        Gv_TransfBrg.GetRow(e.RowHandle).item("no_seq") = Gv_TransfBrg.RowCount + 1
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        loadbrg()
    End Sub

    
End Class


