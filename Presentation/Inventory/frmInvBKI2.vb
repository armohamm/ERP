'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmInvBKI2
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_vbrg, ds_cari3 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, da_brg, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
    Dim x As Object
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
        enabel()
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
        End With
    End Sub

    Public Sub save_click()
        If LookupSPPB.EditValue = vbNullString Or txbNmTrima.Text = "" Then
            MsgBox("Lengkapi data! / Penerima tidak boleh kosong!")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        'cancel_click()

        'sbersihkan()
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
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Public Sub edit_click()
        enabel()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where substring((no_trans),12,3)='BKI'", sqlconn)) '
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  d.Kd_Cabang,d.no_trans, d.tgl_trans, d.no_ref,d.no_rph,d.kd_kegiatan, d.penerima, d.Last_Created_By [dibuat oleh] " & _
                                                                   "from INV.DBO.INV_GUDANG_OUT d where  d.Program_Name = 'frmInvBKI2'", sqlconn)) '

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

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        For Each row As DataRow In dSO1.Tables("_bkid").Select("qty_out = 0")
            row.Delete()
        Next

        'STATE = "ADD"
        If Not isDelete Then
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
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            'row.Item("no_trans") = getNoTrans("BKI", getTanggal())
            row.Item("tipe_trans") = "JPB-KUT-01"
            row.Item("tgl_trans") = getTanggal()
            row.Item("no_ref") = LookupSPPB.EditValue
            row.Item("kd_kegiatan") = LookupKdKeg.Text
            row.Item("no_rph") = txbRPH.Text
            row.Item("jml_rp_trans") = GvBMI_d.Columns(8).SummaryItem.SummaryValue
            row.Item("penerima") = txbNmTrima.Text
            row.Item("blthn") = blthn()
            row.Item("Program_Name") = Me.Name
            'txbNoTrans.Text = row.Item("no_trans")
            If STATE = "ADD" Then
                dSO.Tables("_bki").Rows.Add(row)
            End If
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If row1.RowState = DataRowState.Added Then
                    row1.Item("no_ref") = row.Item("no_ref")
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
                row.Item("no_trans") = getNoTrans("BKI", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            txbNoTrans.Text = row.Item("no_trans")

            DA.Update(dSO.Tables("_bki"))
            DA2.Update(dSO1.Tables("_bkid"))

            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                'If row1.RowState = DataRowState.Added Then
                Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_sppb_d set qty_sisa=@nilai where kd_kegiatan='" & LookupKdKeg.EditValue & "' and no_sppb='" & LookupSPPB.EditValue & "' and kd_barang='" & row1("kd_stok") & "' ", sqlconn, BTRANS)
                sqlcmd.Parameters.AddWithValue("@nilai", row1.Item("qty_sisa"))
                sqlcmd.ExecuteNonQuery()

            Next

            '### SP1
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_tujuan").ToString, row1("qty_out"), row1("qty_lain"), BTRANS)
                    'stprc_bookedOut(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("qty_out"), BTRANS)
                End If
            Next

            '### Sp ke 2
            'For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        'setor_prosedur2(blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '        stprc_saldo(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '    End If
            'Next


            'dSO.Tables("_bki").AcceptChanges()
            'dSO1.Tables("_bkid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            frmMain.btnSave.Enabled = False
            'btnSimpan.Enabled = False

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

    'Public Sub stprc_bookedOut(ByVal kd_cabangx As String, ByVal bultahx As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal booked_outx As Decimal, ByVal BTRANX As SqlTransaction)
    '    Dim sqlCmd As New SqlCommand
    '    sqlCmd.Connection = sqlconn
    '    sqlCmd.Transaction = BTRANX
    '    sqlCmd.CommandType = CommandType.StoredProcedure
    '    sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_booked_out"
    '    sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
    '    sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultahx
    '    sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
    '    sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = kd_satuanx
    '    sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
    '    sqlCmd.Parameters.Add("@booked_out", SqlDbType.Decimal, 32).Value = booked_outx
    '    sqlCmd.ExecuteNonQuery()
    'End Sub

    'Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal kd_satuanx As String, ByVal gudang_tujuanx As Integer, ByVal qtyx As Decimal, ByVal BTRAN As SqlTransaction)
    '    Dim sqlCmd As New SqlCommand
    '    sqlCmd.Connection = sqlconn
    '    sqlCmd.Transaction = BTRAN
    '    sqlCmd.CommandType = CommandType.StoredProcedure
    '    sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_gudang"
    '    sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
    '    sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
    '    sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
    '    sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
    '    sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = kd_satuanx
    '    'sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.Int).Value = qty_outx
    '    sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 32).Value = gudang_tujuanx
    '    sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal, 30).Value = qtyx
    '    sqlCmd.ExecuteNonQuery()
    'End Sub

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

    Private Sub frmInvBMI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()
        prn = getParent(Me)

        btnhide()
        LoadStruktur("xxxx")

        GvBMI_d.Columns("rp_trans").Visible = False
        GvBMI_d.Columns("harga").Visible = False
        'GvBMI_d.Columns("akhir_qty_onstok").Visible = False
        formate_yayak()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_gdgAsal")
        RL_GdgAsal.DataSource = ds_cari1.Tables("_gdgAsal")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_cari3.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupStok.DataSource = ds_cari2.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(sppbd.no_sppb) from PROD.dbo.PROD_sppb_m as sppbm inner join PROD.dbo.PROD_sppb_d as sppbd on sppbm.no_sppb=sppbd.no_sppb where sppbd.qty_sisa <>0", sqlconn))
        DALOOKUP.Fill(ds_cari, "_sppb")
        LookupSPPB.Properties.DataSource = ds_cari.Tables("_sppb")

        'txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())

    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bki") Is Nothing Then dSO.Tables("_bki").Clear()
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()


        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bki")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang,0 as akhir_qty_onstok from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bkid")
        GcBMI_d.DataSource = dSO1.Tables("_bkid")

        'da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd='3'", sqlconn))
        'da_brg.Fill(ds_vbrg, "_vbrg")

        If dSO.Tables("_bki").Rows.Count > 0 Then  'ngisi label header
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_ref) from INV.dbo.INV_GUDANG_OUT where SUBSTRING(no_ref,13,4)='SPBB'", sqlconn))
            DALOOKUP.Fill(ds_cari, "_sppb")
            LookupSPPB.Properties.DataSource = ds_cari.Tables("_sppb")
            LookupSPPB.Properties.DisplayMember = "no_sppb"
            LookupSPPB.Properties.ValueMember = "no_sppb"

            'DA3 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from INV.dbo.INV_GUDANG_IN", sqlconn))
            DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD'", sqlconn))
            DA3.Fill(ds_cari2, "_kdkeg")
            LookupKdKeg.Properties.DataSource = ds_cari2.Tables("_kdkeg")
            LookupKdKeg.Properties.DisplayMember = "desc_data"
            LookupKdKeg.Properties.ValueMember = "kd_kegiatan"

            Dim rw As DataRow = dSO.Tables("_bki").Rows(0)
            'txbNmTrima.Text = rw("no_nm_terima").ToString
            txbNoTrans.Text = rw("no_trans").ToString
            LookupSPPB.EditValue = rw("no_ref").ToString
            LookupKdKeg.EditValue = rw("kd_kegiatan").ToString
            txbNmTrima.Text = rw("penerima").ToString
            txbRPH.Text = rw("no_rph")
        End If
    End Sub

    

    Private Sub LookupSPPB_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSPPB.EditValueChanged

        DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD' and sppbd.no_sppb='" & LookupSPPB.EditValue & "'", sqlconn))
        DA3.Fill(ds_vbrg, "_kdkeg")
        LookupKdKeg.Properties.DataSource = ds_vbrg.Tables("_kdkeg")
    End Sub

    Private Sub LookupSPPB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSPPB.Click
        If Not ds_cari2.Tables("_kdkeg") Is Nothing Then ds_cari2.Tables("_kdkeg").Clear()
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Clear()

    End Sub
    Private Sub LookupKdKeg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupKdKeg.Click
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Clear()

    End Sub

    Private Sub LookupKdKeg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupKdKeg.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("SELECT sppbd.kd_departemen,sppbd.no_rph,sppbd.no_sppb,sppbd.kd_kegiatan,sppbd.kd_barang,sppbd.jumlah,sld.nilai_rata,sld.akhir_qty_onstok,sppbd.qty_sisa,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya,brg.Nama_Barang,brg.kd_ukuran,uk.Panjang,uk.Lebar,uk.Tinggi,brg.lokasi,0 as qty_out from PROD.dbo.PROD_sppb_d as sppbd inner join SIF.dbo.SIF_Barang as brg on sppbd.kd_barang=brg.Kode_Barang INNER JOIN INV.dbo.INV_STOK_SALDO as sld on sppbd.kd_barang=sld.kd_stok INNER JOIN SIF.dbo.SIF_Ukuran as uk on brg.kd_ukuran=uk.Kode_Ukuran where sld.bultah=(select max(bultah) from INV.dbo.INV_STOK_SALDO) and sppbd.no_sppb='" & LookupSPPB.EditValue & "' and sppbd.kd_kegiatan='" & LookupKdKeg.EditValue & "' and sppbd.qty_sisa <> 0 ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bkid").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bkid").NewRow
                'rw.Item("Kd_Cabang") = kdcabang
                rw.Item("kd_dept") = sqldr.Item("kd_departemen")
                If rw.Item("kd_dept") = "2" Then
                    rw.Item("gudang_tujuan") = "G0004"
                ElseIf rw.Item("kd_dept") = "3" Then
                    rw.Item("gudang_tujuan") = "G0005"
                End If
                rw.Item("tipe_trans") = "JPU-KUT-01"
                rw.Item("no_seq") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("kd_barang").ToString
                rw.Item("nama_barang") = sqldr.Item("Nama_Barang")
                rw.Item("kd_satuan") = sqldr.Item("Kd_Satuan")       'alangkah baiknya jika di tabelsppb ditambahi unit
                rw.Item("qty_order") = sqldr.Item("jumlah")
                rw.Item("gudang_asal") = sqldr.Item("lokasi")
                rw.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                rw.Item("tinggi") = sqldr.Item("tinggi")
                rw.Item("lebar") = sqldr.Item("lebar")
                rw.Item("panjang") = sqldr.Item("panjang")
                rw.Item("qty_lain") = 0
                rw.Item("rp_trans") = 0
                rw.Item("qty_out") = 0
                rw.Item("harga") = sqldr.Item("nilai_rata")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")
                rw.Item("harga") = sqldr.Item("nilai_rata")
                rw.Item("qty_sisa") = sqldr.Item("qty_sisa")
                rw.Item("akhir_qty_onstok") = sqldr.Item("akhir_qty_onstok")
                dSO1.Tables("_bkid").Rows.Add(rw)
                txbRPH.Text = sqldr.Item("no_rph").ToString
            End While
            'txbRPH.Text = sqldr.Item("no_rph")
            sqldr.Close()
            GvBMI_d.FocusedColumn = GvBMI_d.VisibleColumns(4)
        End If
    End Sub

    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged
        If e.Column Is qty_out Then
            If GvBMI_d.GetRow(e.RowHandle).item("qty_out") > GvBMI_d.GetRow(e.RowHandle).item("akhir_qty_onstok") Then 'Jika melebihi stok saldo yg tersedia
                MsgBox("Qty out tidak boleh melebihi Stok yang TERSEDIA !!", MsgBoxStyle.Exclamation)
                GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBMI_d.GetRow(e.RowHandle).item("qty_order")
                GvBMI_d.GetRow(e.RowHandle).item("qty_out") = 0
                GvBMI_d.FocusedColumn = GvBMI_d.VisibleColumns(10)
            ElseIf GvBMI_d.GetRow(e.RowHandle).item("qty_out") > GvBMI_d.GetRow(e.RowHandle).item("qty_order") Then
                GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = 0
                GvBMI_d.GetRow(e.RowHandle).item("rp_trans") = GvBMI_d.GetRow(e.RowHandle).item("harga") * GvBMI_d.GetRow(e.RowHandle).item("qty_out")
                'GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBMI_d.GetRowCellValue((e.RowHandle), "qty_order") - GvBMI_d.GetRowCellValue((e.RowHandle), "qty_out")


            Else
                GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBMI_d.GetRowCellValue((e.RowHandle), "qty_order") - GvBMI_d.GetRowCellValue((e.RowHandle), "qty_out")
                GvBMI_d.GetRow(e.RowHandle).item("rp_trans") = GvBMI_d.GetRow(e.RowHandle).item("harga") * GvBMI_d.GetRow(e.RowHandle).item("qty_out")
                'If GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = 0 Then
                '    GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = 0
                'End If
            End If
        End If
    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvBMI_d.Columns("qty_out").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBMI_d.Columns("qty_out").DisplayFormat.FormatString = "n3"
        GvBMI_d.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBMI_d.Columns("qty_order").DisplayFormat.FormatString = "n3"
        GvBMI_d.Columns("qty_lain").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBMI_d.Columns("qty_lain").DisplayFormat.FormatString = "n3"
        'GvBMI_d.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvBMI_d.Columns("hold").DisplayFormat.FormatString = "n0"
        GvBMI_d.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBMI_d.Columns("qty_sisa").DisplayFormat.FormatString = "n3"
    End Sub

    'Private Sub txbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbBarcode.KeyPress
    '    Dim ok As Boolean = False
    '    If e.KeyChar = Chr(13) Then
    '        Dim dtrow() As DataRow = dSO1.Tables("_bkid").Select("kd_stok='" & txbBarcode.Text & "'")
    '        lblNmBrg.ForeColor = Color.Yellow
    '        lblStatus.ForeColor = Color.Yellow
    '        For i As Int16 = 0 To dtrow.Count - 1
    '            'Application.DoEvents()
    '            lblStatus.Text = "OK"
    '            lblNmBrg.Text = dtrow(i)("nama_barang").ToString
    '            txbBarcode.SelectAll()
    '            If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
    '                'If dtrow.Count > 0 Then
    '                dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
    '                dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
    '                dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
    '                ok = True
    '                BindingContext(GcBMI_d.DataSource).Position = getPosisi(dtrow(i))
    '                tunda()
    '                txbBarcode.Text = ""
    '                lblNmBrg.Text = ""
    '                lblStatus.Text = ""
    '                txbBarcode.Focus()
    '                'MsgBox("barang ada")
    '                Exit Sub
    '            End If
    '        Next
    '        lblNmBrg.ForeColor = Color.Red
    '        lblStatus.ForeColor = Color.Red
    '        If dtrow.Count = 0 Then
    '            lblNmBrg.Text = "Item tidak ada dalam Daftar"
    '            lblStatus.Text = "KOSONG"
    '            tunda()
    '            txbBarcode.Text = ""
    '            lblNmBrg.Text = ""
    '            lblStatus.Text = ""
    '            txbBarcode.Focus()

    '            'MsgBox("barang tidak ada")
    '        ElseIf Not ok Then
    '            MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Critical, "STOP..!")
    '            lblNmBrg.Text = "Barang sudah terdaftar semua"
    '            lblStatus.Text = "STOP!"
    '        End If
    '        txbBarcode.SelectAll()
    '    End If
    'End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BKI.rpt", "", "notrans=" & txbNoTrans.Text, False, True)
        Dim sqcmd As New SqlCommand("update INV.dbo.GUDANG_OUT set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()
    End Sub



    'Public Function nomergen(ByVal bgtrans As SqlTransaction) As String
    '    Dim hasil, temp As String
    '    Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,5,3) as numeric))from INV.DBO.INV_GUDANG_IN where substring(no_trans,1,3)='BKI'", sqlconn, bgtrans).ExecuteReader
    '    sqlDR.Read()
    '    temp = ""
    '    If TypeOf sqlDR.Item(0) Is DBNull Then
    '        hasil = "BKI/001/" & thn & "/" & bln
    '    Else
    '        hasil = sqlDR.Item(0)
    '        For i As Int16 = Len(hasil) To 2
    '            temp = "0" & temp
    '        Next
    '        hasil = "BKI/" & temp & (hasil + 1) & "/" & thn & "/" & bln
    '    End If
    '    sqlDR.Close()
    '    Return hasil
    'End Function


    Private Sub btnhide()
        btnTambah.Hide()
        btnUbah.Hide()
        btnSimpan.Hide()
        btnHapus.Hide()
        btnExit.Hide()
        btnBatal.Hide()
    End Sub

    Public Sub bersihkan()
        txbNoTrans.Text = ""
        txbRPH.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        LookupSPPB.EditValue = vbNullString
        LookupKdKeg.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
        LoadStruktur("xxx")
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        'txbNmTrima.Enabled = True
        'dtpTgl.Enabled = True
        'LookupGudang.Enabled = True
        LookupSPPB.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Public Sub disabel()
        txbNoTrans.Enabled = False
        'txbNmTrima.Enabled = False
        'LookupGudang.Enabled = False
        'dtpTgl.Enabled = False
        LookupSPPB.Enabled = False
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1200)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_bkid").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function

    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            Dim sqlread As SqlDataReader = New SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya,0 as qty_out,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd='3' or brg.kd_jns_persd='2' and brg.Nama_Barang ='" & txtcari.Text & "'", sqlconn).ExecuteReader
            If sqlread.Read Then
                Dim dtrow() As DataRow = dSO1.Tables("_bkid").Select("nama_barang='" & txtcari.Text & "'")
                'lblNmBrg.ForeColor = Color.Yellow
                'lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    Dim rw As DataRow = dSO1.Tables("_bkid").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = sqlread.Item("Kode_Barang")
                    rw.Item("nama_barang") = sqlread.Item("Nama_Barang")
                    rw.Item("kd_satuan") = sqlread.Item("Kd_Satuan")
                    rw.Item("kd_buku_besar") = sqlread.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = sqlread.Item("rek_biaya")
                    rw.Item("hold_po") = sqlread.Item("qty_out") + 1
                    rw.Item("gudang_tujuan") = sqlread.Item("lokasi")
                    rw.Item("harga") = sqlread.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_out")
                    dSO1.Tables("_bkid").Rows.Add(rw)
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                        txtcari.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        'BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        txtcari.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        txtcari.Focus()
                        'MsgBox("barang ada")
                        Exit Sub
                        'End If
                    Next
                End If

                'BindingContext(GcBKI_d.DataSource).Position = getPosisi(rw(i))
                'tunda()
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txtcari.Focus()
                sqlread.Close()
                'Next

            Else
                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta

                lblNmBrg.Text = "Barang tidak terdaftar di Master"
                lblStatus.Text = "KOSONG"
                tunda()
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txtcari.Focus()

                'MsgBox("barang tidak ada")
                'ElseIf Not ok Then
                '    lblNmBrg.Text = "Barang sudah terdaftar semua"
                '    lblStatus.Text = "STOP!"
            End If
            txtcari.SelectAll()
        End If

    End Sub


    Private Sub LookupSPPB_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupSPPB.QueryPopUp
        ds_cari.Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(sppbd.no_sppb) from PROD.dbo.PROD_sppb_m as sppbm inner join PROD.dbo.PROD_sppb_d as sppbd on sppbm.no_sppb=sppbd.no_sppb where sppbd.qty_sisa <>0", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupSPPB.Properties.DataSource = ds_cari.Tables("_lookup1")

        'LoadStruktur("xxxx")
    End Sub


    Private Sub LookupKdKeg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupKdKeg.QueryPopUp
        ds_vbrg.Clear()
        DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD' and sppbd.no_sppb='" & LookupSPPB.EditValue & "'", sqlconn))
        DA3.Fill(ds_vbrg, "_kdkeg")
        LookupKdKeg.Properties.DataSource = ds_vbrg.Tables("_kdkeg")
    End Sub
End Class