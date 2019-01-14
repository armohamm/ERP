'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports System.Data.SqlClient



Public Class fr_inv_batal_krm

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_cari3, ds_vbrg As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3, da_brg As SqlClient.SqlDataAdapter
    Dim x As Object
    Private BTrans As SqlTransaction

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
        End With
    End Sub

    Public Sub save_click()
        If LookupSJ.EditValue = vbNullString Then
            MsgBox("Data Harus Lengkap sebelum disimpan")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        bersihkan()
    End Sub


    Public Sub bersihkan()
        LookupSJ.EditValue = vbNullString
        tgl_retur.EditValue = Today
        txbNoTrans.Text = ""
        'txbToko.Text = ""
    End Sub

    Public Sub cancel_click()
        'bersihkan()
        btnadd = True
        btnSave = False
        btnDelete = False
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_IN where SUBSTRING(no_trans,10,3)='JBM'", sqlconn)) '
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

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        For Each row As DataRow In dSO1.Tables("_bmid").Select("qty_in = 0")
            row.Delete()
        Next

        'STATE = "ADD"
        If Not isDelete Then


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
            row.Item("tipe_trans") = "JBM-KUT-05"
            row.Item("no_ref") = LookupSJ.EditValue
            row.Item("tgl_trans") = tgl_retur.EditValue
            'row.Item("no_ref") = txbTo
            row.Item("penyerah") = txbNmTrima.Text
            row.Item("jml_rp_trans") = 0
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
                row.Item("no_trans") = getNoTrans("BKE-C", getTanggal(BTRANS), BTRANS)
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

            ''### SP1
            For Each row1 As DataRow In dSO1.Tables("_bmid").Rows
                If STATE = "ADD" Then
                    'If row1("qty_in") > 0 Then
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1.Item("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_in"), BTRANS)
                End If
            Next

            '### Sp ke 2 saldo
            'For Each row1 As DataRow In dSO1.Tables("_bmid").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        'setor_prosedur2(blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '        'stprc_onstok(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
            '    End If
            'Next


            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            Me.Enabled = False
            frmMain.btnSave.Enabled = False
            frmMain.btnAdd.Enabled = True
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BKEC.rpt", "", "notrans=" & txbNoTrans.Text, False, True)
    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal ukuranx As Decimal, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_inx As Integer, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = ukuranx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
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

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as deskripsi from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmid")
        GcBMI_d.DataSource = dSO1.Tables("_bmid")

        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim row As DataRow = dSO.Tables("_bmi").Rows(0)
            'txbNoRef.Text = rw("no_ref").ToString
            txbNoTrans.Text = row("no_trans").ToString
            tgl_retur.EditValue = row("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'txbToko.Text = row("no_ref").ToString
            'LookupPO2.EditValue = rw("no_ref").ToString

            'MsgBox(rw("no_ref").ToString)
        End If

        'da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd='3'", sqlconn))
        'da_brg.Fill(ds_vbrg, "_vbrg")

    End Sub

    Private Sub LookupSJ_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSJ.EditValueChanged

        If STATE = "ADD" Then
            'MsgBox("tes")
            'noqc = ""
            If Not dSO1.Tables("_bmid") Is Nothing Then dSO1.Tables("_bmid").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("SELECT sjb.no_sj,sj.no_dpb,sjb.No_sp,sjd.Kd_stok,sjd.no_seq_kirim,sod.Deskripsi,sjd.Qty_kirim,sjd.Qty_batal,sj.Kd_Sopir,spr.Nama_Sopir,sjd.Kd_satuan,isnull(brg.kd_ukuran,0) as kd_ukuran,isnull(brg.panjang,0) as panjang, isnull(brg.lebar,0) as lebar,isnull(brg.tinggi,0) as tinggi,brg.lokasi,brg.rek_persediaan,brg.rek_biaya from SALES.dbo.SALES_SJ_BATAL_KIRIM as sjb inner join SALES.dbo.SALES_SJ as sj on sjb.no_sj=sj.no_sj INNER JOIN SALES.dbo.SALES_SJ_D as sjd on sj.no_sj=sjd.no_sj INNER JOIN SIF.dbo.SIF_Barang as brg on sjd.Kd_stok=brg.Kode_Barang INNER JOIN SALES.dbo.SALES_SO_D as sod on sod.No_sp=sjd.No_sp and sod.No_seq=sjd.no_seq_kirim LEFT JOIN SIF.dbo.SIF_Sopir as spr on sj.Kd_sopir=spr.Kode_Sopir where sjd.no_sj='" & LookupSJ.EditValue & "'and sjd.Qty_batal > 0 order by cast(sjd.no_seq_kirim as int)", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bmid").Clear()

            While sqdr.Read
                Dim row1 As DataRow = dSO1.Tables("_bmid").NewRow
                row1.Item("Kd_Cabang") = kdcabang
                row1.Item("tipe_trans") = "JPU-KUT-01"
                row1.Item("no_seq") = sqdr.Item("no_seq_kirim")
                row1.Item("kd_stok") = sqdr.Item("kd_stok")
                row1.Item("deskripsi") = sqdr.Item("Deskripsi")
                row1.Item("kd_satuan") = sqdr.Item("kd_satuan")
                row1.Item("kd_ukuran") = sqdr.Item("kd_ukuran")
                row1.Item("panjang") = sqdr.Item("panjang")
                row1.Item("lebar") = sqdr.Item("lebar")
                row1.Item("tinggi") = sqdr.Item("tinggi")
                row1.Item("qty_order") = sqdr.Item("Qty_Kirim")
                row1.Item("qty_in") = sqdr.Item("Qty_batal")
                'row1.Item("harga") = sqdr.Item("harga")
                'row1.Item("rp_trans") = sqdr.Item("harga") * row1.Item("qty_in")
                row1.Item("gudang_asal") = "G0007"
                row1.Item("gudang_tujuan") = sqdr.Item("lokasi")
                row1.Item("kd_buku_besar") = sqdr.Item("rek_persediaan")
                row1.Item("kd_buku_biaya") = sqdr.Item("rek_biaya")
                dSO1.Tables("_bmid").Rows.Add(row1)

                txbNmTrima.Text = sqdr.Item("Nama_Sopir")
            End While
            sqdr.Close()
            GvBMI_d.FocusedColumn = GvBMI_d.VisibleColumns(5)

            'txbNoRef.Text = no_po
        End If
    End Sub

    Private Sub fr_inv_batal_krm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        tgl_retur.EditValue = Today
        LoadStruktur("xxxx")
        GvBMI_d.Columns("qty_batal").Visible = False

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct(no_sj) from sales.dbo.SALES_SJ_BATAL_KIRIM where stat_gudang<>1", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_no_sj")
        LookupSJ.Properties.DataSource = ds_cari1.Tables("_no_sj")
        LookupSJ.Properties.ValueMember = "no_sj"
        LookupSJ.Properties.DisplayMember = "no_sj"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_BARANG", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupStok.DataSource = ds_cari.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"
    End Sub

    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged
        If e.Column Is qty_in Then
            GvBMI_d.GetRow(e.RowHandle).item("qty_out") = GvBMI_d.GetRow(e.RowHandle).item("qty_out") - GvBMI_d.GetRow(e.RowHandle).item("qty_in")
            GvBMI_d.GetRow(e.RowHandle).item("qty_batal") = GvBMI_d.GetRow(e.RowHandle).item("qty_in")
        End If
    End Sub
End Class