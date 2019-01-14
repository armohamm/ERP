'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmINV_Retur
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, supp, kdsupp As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, ds_gdg2, dso2, ds_cari, ds_cari1, ds_cari2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DAL, DA_gdg2, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private BTRAN As SqlTransaction

    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
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
        'If LookupGudang.EditValue = vbNullString Then
        '    MsgBox("Gudang Tujuan belum di Set!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
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
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from inv.dbo.INV_GUDANG_OUT where no_trans like '%/INV/RTR%'", sqlconn)) '
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        DA.Fill(dSO, "_bke")
        frmCari.set_dso(dSO.Tables("_bke")) '<-- memparsing hasil dataset ke LOV
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
            row = dSO.Tables("_bke").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bke").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If

        row.Item("Kd_Cabang") = "2" ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("tipe_trans") = "JPB-KUT-03"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvINV_Ret.Columns(9).SummaryItem.SummaryValue
        row.Item("penerima") = supp
        row.Item("kd_kegiatan") = kdsupp
        'row.Item("kd_ref1") = kdsupp
        row.Item("no_ref") = LookupNoRetur.EditValue
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name

        If STATE = "ADD" Then
            dSO.Tables("_bke").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            If row1.RowState = DataRowState.Added Then
                'row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = row.Item("tipe_trans")
                row1.Item("Last_Create_Date") = getTanggal()
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = "2"
            Else
                row1.Item("Last_Update_Date") = getTanggal()
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

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

            If STATE = "ADD" Then
                row.Item("no_trans") = getNoTrans("BK-RTR", getTanggal(BTRANS), BTRANS)
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


            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                'If row1.RowState = DataRowState.Added Then
                If STATE = "ADD" Then
                    Dim sqlcmd As New SqlCommand("update PURC.dbo.PURC_RETUR_BELI_D set qty_sisa=@nilai where no_retur='" & LookupNoRetur.EditValue & "' and kd_stok='" & row1("kd_stok") & "' ", sqlconn, BTRANS)
                    sqlcmd.Parameters.AddWithValue("@nilai", row1.Item("qty_sisa"))
                    sqlcmd.ExecuteNonQuery()
                End If
            Next

            '## spc stok saldo gudang out
            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    stprc_gudang_out("2", blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_asal").ToString, row1("qty_out"), 0, BTRANS)
                    stprc_saldo_out("2", blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran"), row1("panjang"), row1("lebar"), row1("tinggi"), row1("qty_out"), row1("rp_trans"), BTRANS)
                    strprc_automan(row1("tipe_trans").ToString, row1("no_trans").ToString, BTRANS)

                End If
            Next
            '' ## sp 2
            'For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur2("2", blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
            '    End If
            'Next

            'dSO.Tables("_bke").AcceptChanges()
            'dSO1.Tables("_bke_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\INV_RTR.rpt", "", "notrans=" & txbNoTrans.Text)
        'Dim sqcmd As New SqlCommand("update INV.dbo.GUDANG_OUT set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        'sqcmd.ExecuteNonQuery()
    End Sub

    Public Sub hapus_record()

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
        LookupNoRetur.Enabled = True
        TxbPenerima.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupSPM.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        LookupNoRetur.EditValue = vbNullString
        TxbBarcode.Text = ""
        dSO1.Clear()
    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bke_d")
        GcINV_Ret.DataSource = dSO1.Tables("_bke_d")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            TxbPenerima.Text = rw("penerima").ToString
            LookupNoRetur.Text = rw("no_ref").ToString
            LookupNoRetur.Enabled = False
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub

    Private Sub frmINV_Retur_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        GvINV_Ret.Columns("rp_trans").Visible = False
        GvINV_Ret.Columns("harga").Visible = False
        GvINV_Ret.Columns("supplier").Visible = False
        'GvINV_Ret.Columns("gudang_tujuan").Visible = False
        prn = getParent(Me)
        LoadStruktur("xxxx")
        formate_yayak()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepBarang.DataSource = ds_cari.Tables("_lookup1")
        RepBarang.ValueMember = "Kode_Barang"
        RepBarang.DisplayMember = "Nama_Barang"

        DAL = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DAL.Fill(ds_cari3, "_lookup")
        RL_GdgAsal.DataSource = ds_cari3.Tables("_lookup")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_gdg2.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct(no_retur) from PURC.dbo.PURC_RETUR_BELI_D where qty_sisa <> 0", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_LookupR")
        LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_LookupR")
        LookupNoRetur.Properties.ValueMember = "no_retur"
        LookupNoRetur.Properties.DisplayMember = "no_retur"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_LookupS")
        RepSupplier.DataSource = ds_cari2.Tables("_LookupS")
        RepSupplier.ValueMember = "Kode_Supplier"
        RepSupplier.DisplayMember = "Nama_Supplier"
    End Sub

    Public Sub strprc_automan(ByVal tipetranx As String, ByVal notransR As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"
        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 25).Value = tipetranx
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 25).Value = notransR
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_gudang_out(ByVal kd_cabangx1 As String, ByVal bultah As String, ByVal kd_stokx1 As String, ByVal kd_ukuranx1 As String, ByVal satuanx1 As String, ByVal tinggix1 As Decimal, ByVal lebarx1 As Decimal, ByVal panjangx1 As Decimal, ByVal lokasix1 As String, ByVal qty_outx1 As Decimal, ByVal qty_lainx As Decimal, ByVal BTRANS As SqlTransaction)

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
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix1
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx1
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx1
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = lokasix1

        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal).Value = qty_outx1
        sqlCmd.Parameters.Add("@qty_lain_out", SqlDbType.Decimal).Value = qty_lainx
        sqlCmd.Parameters.Add("@qty_lain_out", SqlDbType.Decimal, 32).Value = qty_outx1
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo_out(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal panjangx As Decimal, ByVal lebarx As Decimal, ByVal tinggix As Decimal, ByVal qty_outx As Integer, ByVal rpnilaix As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 16).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Int).Value = qty_outx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilaix
        sqlCmd.ExecuteNonQuery()
    End Sub




    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvINV_Ret.Columns("qty_out").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_out").DisplayFormat.FormatString = "n0"
        GvINV_Ret.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_order").DisplayFormat.FormatString = "n0"
        GvINV_Ret.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvINV_Ret.Columns("qty_sisa").DisplayFormat.FormatString = "n0"
    End Sub

    Private Sub LookupNoRetur_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupNoRetur.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("select rtr.no_po,rtr.kd_supplier,sup.Nama_Supplier,rtr.no_retur,rtr.rec_stat,rtr.jml_rp_trans,rtr.tanggal,rtrd.kd_stok,rtrd.satuan,rtrd.qty,rtrd.qty_sisa,rtrd.harga,rtrd.total,brg.rek_persediaan,brg.rek_retur1,brg.lokasi,ISNULL(brg.panjang,0)as panjang,ISNULL(brg.lebar,0)as lebar, isnull(brg.tinggi,0) as tinggi,isnull(brg.kd_ukuran,0) as kd_ukuran  from PURC.dbo.PURC_RETUR_BELI as rtr INNER JOIN PURC.dbo.PURC_RETUR_BELI_D as rtrd on rtr.no_retur=rtrd.no_retur INNER JOIN SIF.dbo.SIF_Barang as brg on rtrd.kd_stok=brg.Kode_Barang inner join sif.dbo.SIF_Supplier sup on sup.Kode_Supplier=rtr.kd_supplier where rtrd.no_retur='" & LookupNoRetur.EditValue & "' ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bke_d").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
                rw.Item("Kd_Cabang") = "2"
                'rw.Item("no_trans") = "001"
                rw.Item("tipe_trans") = "JPB-KUT-03"
                rw.Item("no_seq") = i : i += 1
                rw.Item("no_ref") = sqldr.Item("no_retur")
                rw.Item("gudang_asal") = sqldr.Item("lokasi")
                rw.Item("gudang_tujuan") = "G0000"
                'rw.Item("gudang_tujuan") = sqldr.Item("lokasi")
                rw.Item("kd_stok") = sqldr.Item("kd_stok")
                rw.Item("kd_satuan") = sqldr.Item("satuan")
                rw.Item("qty_order") = sqldr.Item("qty")
                rw.Item("qty_sisa_retur") = sqldr.Item("qty")
                rw.Item("qty_out") = sqldr.Item("qty")
                rw.Item("qty_sisa") = 0
                rw.Item("harga") = sqldr.Item("harga")
                rw.Item("rp_trans") = sqldr.Item("harga") * sqldr.Item("qty")
                rw.Item("panjang") = sqldr.Item("panjang")
                rw.Item("lebar") = sqldr.Item("lebar")
                rw.Item("tinggi") = sqldr.Item("tinggi")
                rw.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_retur1")


                supp = sqldr.Item("Nama_Supplier")
                kdsupp = sqldr.Item("kd_supplier")
                TxbPenerima.Text = supp
                dSO1.Tables("_bke_d").Rows.Add(rw)
            End While
            sqldr.Close()
            TxbBarcode.Focus()
            'GvINV_Ret.FocusedColumn = GvINV_Ret.VisibleColumns(6)
        End If
    End Sub

    
    Private Sub GvINV_Ret_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvINV_Ret.CellValueChanged
        If e.Column Is qty_out Then
            If GvINV_Ret.GetRow(e.RowHandle).item("qty_out") > GvINV_Ret.GetRow(e.RowHandle).item("qty_order") Then
                MsgBox(" Quantiti keluar tidak boleh melebihi order retur")
                GvINV_Ret.GetRow(e.RowHandle).item("qty_out") = 0
                Exit Sub
            Else
                GvINV_Ret.GetRow(e.RowHandle).item("rp_trans") = GvINV_Ret.GetRow(e.RowHandle).item("harga") * GvINV_Ret.GetRow(e.RowHandle).item("qty_out")
                GvINV_Ret.GetRow(e.RowHandle).item("qty_sisa") = GvINV_Ret.GetRow(e.RowHandle).item("qty_order") - GvINV_Ret.GetRow(e.RowHandle).item("qty_out")
                GvINV_Ret.GetRow(e.RowHandle).item("qty_sisa_retur") = GvINV_Ret.GetRow(e.RowHandle).item("qty_out")

            End If
        End If
    End Sub

    Private Sub TxbBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcode.Text & "'")
            lblNmBrg.ForeColor = Color.Yellow
            lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                Application.DoEvents()
                lblStatus.Text = "OK"
                lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                TxbBarcode.SelectAll()
                If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                    dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcINV_Ret.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    TxbBarcode.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    TxbBarcode.Focus()
                    'MsgBox("barang ada")
                    'Exit Sub
                End If
            Next
            lblNmBrg.ForeColor = Color.Magenta
            lblStatus.ForeColor = Color.Magenta
            If dtrow.Count = 0 Then
                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                TxbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbBarcode.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                lblNmBrg.Text = "Barang sudah terdaftar semua"
                lblStatus.Text = "STOP!"
            End If
            TxbBarcode.SelectAll()
        End If
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(700)
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


    Private Sub LookupNoRetur_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupNoRetur.QueryPopUp
        ds_cari1.Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct(no_retur) from PURC.dbo.PURC_RETUR_BELI_D where qty_sisa <> 0", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_LookupR")
        LookupNoRetur.Properties.DataSource = ds_cari1.Tables("_LookupR")
        LookupNoRetur.Properties.ValueMember = "no_retur"
        LookupNoRetur.Properties.DisplayMember = "no_retur"

    End Sub
End Class