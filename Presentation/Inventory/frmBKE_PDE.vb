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

Public Class frmBKE_PDE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, ds_batal, dso2, ds_cari, ds_rcn, ds_cari1, ds_cari2, ds_cari3 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DA_batal, DALOOKUP1, DA_rcn, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
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

    Public Sub save_click()

        If GvBKE_d.Columns(10).SummaryItem.SummaryValue <> 0 Or CbRcnKrm.EditValue = vbNullString Then
            MsgBox("Data tidak LENGKAP atau " & vbCrLf & "ADA BARANG YANG BELUM TERDAFTAR !", MsgBoxStyle.Information)
            Exit Sub
        End If
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
        '    bersihkan()
    End Sub


    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where substring((no_trans),8,3)='BKE'", sqlconn)) '
        If Not dSO.Tables("lookup_bke") Is Nothing Then dSO.Tables("lookup_bke").Clear()
        DA.Fill(dSO, "lookup_bke")
        frmCari.set_dso(dSO.Tables("lookup_bke")) '<-- memparsing hasil dataset ke LOV
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
        DA.SelectCommand.CommandTimeout = 0
        DA2.SelectCommand.CommandTimeout = 0
        DA_batal.SelectCommand.CommandTimeout = 0
        Dim BTRANS As SqlTransaction
        Dim arrNoTrans(CbRcnKrm.EditValue.ToString.Split(",").Length - 1) As String
        For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
            arrNoTrans(i) = getNoTrans("BKE", getTanggal(BTRANS), BTRANS)
            'arrno_pol(i)=
        Next
        'STATE = "ADD"

        'txbNoTrans.Text = row.Item("no_trans")

        For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
            'If CBeditKirim.Properties.Items(i).CheckState = CheckState.Checked Then
            If STATE = "ADD" Then
                row = dSO.Tables("_bke").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_bke").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

            'row.Item("no_trans") = getNoTrans("BKE", getTanggal())
            row.Item("blthn") = blthn()
            row.Item("siap_sj") = 0
            row.Item("no_trans") = arrNoTrans(i)

            row.Item("tipe_trans") = "JPB-KUT-01"
            row.Item("tgl_trans") = getTanggal()
            row.Item("no_ref") = CbRcnKrm.EditValue.ToString.Split(",")(i).Trim(" ") 'CbRcnKrm.Properties.Items(i).Value
            'MsgBox(CbRcnKrm.EditValue.ToString.Split(",")(i).Trim(" "))
            'MsgBox(CbRcnKrm.Properties.Items(i).Value.ToString)
            'row.Item("no_pol") = txbNoPol.Text
            row.Item("jml_rp_trans") = GvBKE_d.Columns(14).SummaryItem.SummaryValue
            row.Item("penerima") = txbNmTrima.Text
            row.Item("Program_Name") = Me.Name
            If STATE = "ADD" Then
                dSO.Tables("_bke").Rows.Add(row)
            End If
            'End If
        Next
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
            row1.Item("blthn") = blthn()
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

            Buildernya = New SqlClient.SqlCommandBuilder(DA_batal)
            DA_batal.UpdateCommand = Buildernya.GetUpdateCommand()
            DA_batal.InsertCommand = Buildernya.GetInsertCommand()
            DA_batal.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            'DA_batal.UpdateCommand.Transaction = BTRANS
            DA_batal.InsertCommand.Transaction = BTRANS
            'DA_batal.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then

                'txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                    End If
                Next
            End If

            Dim dView As New DataView(dSO1.Tables("_bke_d"))
            dView.Sort = "no_ref"

            Dim cekVal As String = ""
            Dim cnt As Integer = 0
            'MsgBox(arrNoTrans.Length)
            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                If row1.Item("no_ref") <> cekVal Then
                    cekVal = row1.Item("no_ref")
                    cnt += 1
                    row1.Item("no_trans") = arrNoTrans(cnt - 1)
                End If
            Next


            'For i As Integer = 0 To dSO1.Tables("_bke_d").Columns.Count - 1
            '    MsgBox(dSO1.Tables("_bke_d").Columns.Item(i).ColumnName & " : " & dSO1.Tables("_bke_d").Rows(0).Item(i).ToString.Length)
            'Next
            DA.Update(dSO.Tables("_bke"))
            DA2.Update(dSO1.Tables("_bke_d"))
            DA_batal.Update(ds_batal.Tables("_batal"))

            'UPDATE status di prod.dpb_m status 1 supaya yg sudah terkirim tak muncul lagi
            'For Each row As DataRow In dSO.Tables("_bke").Rows
            'If row1.RowState = DataRowState.Added Then
            Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_dpb_m set inv_stat = 1 where PROD.dbo.PROD_dpb_m.no_trans_krm = '" & CbRcnKrm.EditValue & "'", sqlconn, BTRANS)
            sqlcmd.ExecuteNonQuery()
            'Next

            '## spc stok saldo gudang out #### PINDAH DI TRIGGER STORE PROCEDURE PINDAH GUDANG
            'For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
            '        stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran").ToString, row1("kd_satuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_out"), BTRANS)

            '    End If
            'Next
            '## spc BOOKED OUT
            'For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        stprc_bookedOut(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("qty_out"), BTRANS)
            '    End If
            'Next
            'dSO.Tables("_bke").AcceptChanges()
            'dSO1.Tables("_bke_d").AcceptChanges()
            BTRANS.Commit()
            For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
                callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & arrNoTrans(i), True, True)
            Next

            showMessages("Berhasil disimpan..!")
            frmMain.btnSave.Enabled = False
            STATE = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges() ' untuk membatalkan row yg diupdate/insert

            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal, 30).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_bookedOut(ByVal kd_cabangx As String, ByVal bultahx As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal booked_outx As Decimal, ByVal BTRANX As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANX
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_booked_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultahx
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@booked_out", SqlDbType.Decimal, 32).Value = booked_outx
        sqlCmd.ExecuteNonQuery()
    End Sub
    Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_outx As Double, ByVal rpnilai As Decimal, ByVal BTRANX As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANX
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Float).Value = qty_outx
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
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
        If Not ds_batal.Tables("_batal") Is Nothing Then ds_batal.Tables("_batal").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_BKE where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as sisa,'' as no_pol,'' as sopir from INV.dbo.INV_BKE_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bke_d")
        GcBKE_d.DataSource = dSO1.Tables("_bke_d")

        DA_batal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_BATAL where 1=0", sqlconn))
        DA_batal.Fill(ds_batal, "_batal")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_ref) FROM INV.dbo.INV_GUDANG_OUT", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            CbRcnKrm.Properties.DataSource = ds_cari.Tables("_lookup1")

            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            'txbNoTrans.Text = rw("no_trans").ToString
            txbNmTrima.Text = rw("no_dpb").ToString
            CbRcnKrm.EditValue = rw("no_dpb").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString

        End If

    End Sub

    Private Sub LookupDPB_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not dSO1.Tables("_bke_d") Is Nothing Then
            dSO1.Clear()
        End If
    End Sub

    'Private Sub LookRcnKrm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If STATE = "ADD" Then
    '        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
    '        'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
    '        Dim sqldr As SqlDataReader = New SqlCommand("SELECT dpbm.no_trans_krm,sod.Kd_stok,sod.harga,sod.kd_satuan,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang inner join SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir where dpbm.no_trans_krm='" & LookRcnKrm.EditValue & "'", sqlconn).ExecuteReader
    '        Dim x As Int16 = 1
    '        dSO1.Tables("_bke_d").Clear()

    '        While sqldr.Read
    '            Dim rw1 As DataRow = dSO1.Tables("_bke_d").NewRow
    '            rw1.Item("Kd_Cabang") = kdcabang
    '            'rw.Item("no_trans") = "001"
    '            'rw.Item("tipe_trans") = "JPU-KUT-01"
    '            'rw.Item("no_ref") = sqldr.Item("no_dpb")
    '            'rw.Item("no_sp") = sqldr.Item("no_sp")
    '            'rw.Item("no_sp_dtl") = sqldr.Item("no_sp_dtl")
    '            rw1.Item("no_seq") = x : x += 1
    '            rw1.Item("kd_stok") = sqldr.Item("Kd_stok")
    '            rw1.Item("kd_satuan") = sqldr.Item("kd_satuan")
    '            rw1.Item("qty_order") = sqldr.Item("jumlah")
    '            rw1.Item("qty_sisa") = sqldr.Item("jumlah")
    '            rw1.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
    '            rw1.Item("harga") = sqldr.Item("harga")
    '            rw1.Item("qty_out") = sqldr.Item("qty_out")
    '            rw1.Item("rp_trans") = 0
    '            rw1.Item("gudang_asal") = sqldr.Item("lokasi") 'lokasi di master brg sbg default
    '            rw1.Item("gudang_tujuan") = "G0007" 'Gudang Expedisi sbg Default
    '            rw1.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
    '            rw1.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")

    '            txbNmTrima.Text = sqldr.Item("Nama_Sopir").ToString
    '            txbNoPol.Text = sqldr.Item("no_pol").ToString
    '            dSO1.Tables("_bke_d").Rows.Add(rw1)
    '        End While

    '        sqldr.Close()
    '        GvBKE_d.FocusedColumn = GvBKE_d.VisibleColumns(4)
    '    End If
    'End Sub

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

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1200)
    End Sub

  


    Public Sub hapus_record()

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        save_click()
    End Sub

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cetak_click()
    'End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        cancel_click()

    End Sub

    Private Sub frmBKE_PDE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        TxbBarcDel.Visible = False
        LookRcnKrm.Visible = False
        lblBarcDel.Visible = False
        'lblRcnKrm.Visible = False
        slesai.Visible = False
        connect()

        GvBKE_d.Columns("rp_trans").Visible = False
        GvBKE_d.Columns("harga").Visible = False
        GvBKE_d.Columns("no_pol").Visible = False
        GvBKE_d.Columns("sopir").Visible = False
        'GvBKE_d.GroupFormat. = GvBKE_d.Columns("no_ref")

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

        'txbNmTrima.Text = blthn(x)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        DA_rcn = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans_krm) as no_trans_krm FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0 ", sqlconn))
        DA_rcn.Fill(ds_rcn, "_redit")
        LookRcnKrm.Properties.DataSource = ds_rcn.Tables("_redit")
        LookRcnKrm.Properties.ValueMember = "no_trans_krm"
        LookRcnKrm.Properties.DisplayMember = "no_trans_krm"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans_krm) as no_trans_krm FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0 ", sqlconn)) ' 
        DALOOKUP.Fill(ds_cari, "_rcnkrm")
        CbRcnKrm.Properties.DataSource = ds_cari.Tables("_rcnkrm")
        CbRcnKrm.Properties.ValueMember = "no_trans_krm"
        CbRcnKrm.Properties.DisplayMember = "no_trans_krm"

        LoadStruktur("xxx")

        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub txbKdBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & txbBarcode.Text & "'")
            'lblNmBrg.ForeColor = Color.Yellow
            'lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                'lblStatus.Text = "OK"
                'lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                txbBarcode.SelectAll()
                If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                    dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    txbBarcode.Text = ""
                    'lblNmBrg.Text = ""
                    'lblStatus.Text = ""
                    txbBarcode.Focus()
                    'MsgBox("barang ada")
                    Exit Sub
                End If
            Next
            'lblNmBrg.ForeColor = Color.Magenta
            'lblStatus.ForeColor = Color.Magenta
            If dtrow.Count = 0 Then
                MsgBox("Item tidak ada dalam Daftar",MsgBoxStyle.Exclamation)
                'lblStatus.Text = "KOSONG"
                tunda()
                txbBarcode.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                txbBarcode.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Exclamation)
                'lblStatus.Text = "STOP!"
            End If
            txbBarcode.SelectAll()
        End If

    End Sub

    Private Sub LookRcnKrm_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookRcnKrm.QueryPopUp
        ds_cari.Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans_krm) as no_trans_krm FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0  ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        CbRcnKrm.Properties.DataSource = ds_cari.Tables("_lookup1")
        CbRcnKrm.Properties.ValueMember = "no_trans_krm"
        CbRcnKrm.Properties.DisplayMember = "no_trans_krm"
    End Sub

    Private Sub CbRcnKrm_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbRcnKrm.EditValueChanged
        If STATE = "ADD" And Not CbRcnKrm.EditValue Is Nothing Then
            If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim arrTemp() As String = CbRcnKrm.EditValue.ToString.Split(",")
            Dim whereStr As String
            For i As Integer = 0 To arrTemp.Length - 1
                arrTemp(i) = arrTemp(i).Trim(" ")
                whereStr &= "'" & arrTemp(i) & "'"
                If i <> arrTemp.Length - 1 Then
                    whereStr &= ", "
                End If
            Next
            Dim sqldr As SqlDataReader = New SqlCommand("SELECT sod.Kd_stok,sod.harga,sod.kd_satuan,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,dpbd.panjang,dpbd.lebar,dpbd.tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang inner join SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir where dpbm.no_trans_krm in (" & whereStr & ")", sqlconn).ExecuteReader
            Dim x As Int16 = 1
            dSO1.Tables("_bke_d").Clear()

            While sqldr.Read
                Dim rw1 As DataRow = dSO1.Tables("_bke_d").NewRow

                rw1.Item("Kd_Cabang") = kdcabang
                rw1.Item("no_ref") = sqldr.Item("no_trans_krm")
                rw1.Item("no_ref2") = sqldr.Item("no_dpb")
                'rw.Item("tipe_trans") = "JPU-KUT-01"
                rw1.Item("no_sp_dtl") = sqldr.Item("no_sp_dtl")
                rw1.Item("seq_dpb") = sqldr.Item("seq_dpb")
                rw1.Item("no_seq") = x : x += 1
                rw1.Item("kd_stok") = sqldr.Item("Kd_stok")
                rw1.Item("kd_satuan") = sqldr.Item("kd_satuan")
                rw1.Item("qty_order") = sqldr.Item("jumlah")
                rw1.Item("qty_sisa") = sqldr.Item("jumlah")
                rw1.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                rw1.Item("panjang") = sqldr.Item("panjang")
                rw1.Item("lebar") = sqldr.Item("lebar")
                rw1.Item("tinggi") = sqldr.Item("tinggi")
                rw1.Item("harga") = sqldr.Item("harga")
                rw1.Item("qty_out") = sqldr.Item("qty_out")
                rw1.Item("rp_trans") = 0
                rw1.Item("siap_sj") = 0
                rw1.Item("gudang_asal") = sqldr.Item("lokasi") 'lokasi di master brg sbg default
                rw1.Item("gudang_tujuan") = "G0007" 'Gudang Expedisi sbg Default
                rw1.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw1.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")
                rw1.Item("no_pol") = sqldr.Item("no_pol").ToString
                rw1.Item("sopir") = sqldr.Item("Nama_Sopir").ToString

                dSO1.Tables("_bke_d").Rows.Add(rw1)
            End While

            sqldr.Close()
            GvBKE_d.FocusedColumn = GvBKE_d.VisibleColumns(4)
        End If
    End Sub

    Private Sub hapus_item()
        txbBarcode.Visible = False
        TxbBarcDel.Visible = True
        LookRcnKrm.Visible = True
        lblBarcDel.Visible = True
        'lblRcnKrm.Visible = True
        'lblRcnKrm1.Visible = False
        slesai.Visible = True
    End Sub
    Private Sub afterdel()
        txbBarcode.Visible = True
        TxbBarcDel.Visible = False
        LookRcnKrm.Visible = False
        lblBarcDel.Visible = False
        'lblRcnKrm.Visible = False
        'lblRcnKrm1.Visible = True
        slesai.Visible = False
    End Sub


    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Anda Yakin Akan Menghapus Item? Apakah Sudah Kordinasi PPIC?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_item()
    End Sub

    Private Sub slesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slesai.Click
        afterdel()
    End Sub

    
    Private Sub TxbBarcDel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcDel.KeyPress
        Dim ok As Boolean = False
        Dim y As Int16 = 1
        If e.KeyChar = Chr(13) Then


            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcDel.Text & "' and no_ref='" & LookRcnKrm.EditValue & "'")
            'lblNmBrg.ForeColor = Color.Yellow
            'lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()

                'lblStatus.Text = "OK"
                'lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                TxbBarcDel.SelectAll()

                If dtrow(i)("qty_out") > 0 Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_order") = dtrow(i)("qty_order") - 1
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") - 1
                    'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    'TxbBarcDel.Text = ""
                    'lblNmBrg.Text = ""
                    'lblStatus.Text = ""
                    TxbBarcDel.Focus()



                    'MsgBox("barang ada")
                    Exit Sub
                ElseIf dtrow(i)("qty_out") = 0 And dtrow(i)("qty_order") > 0 Then
                    dtrow(i)("qty_order") = dtrow(i)("qty_order") - 1
                    'dtrow(i)("qty_out") = dtrow(i)("qty_out") - 1
                    'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    'TxbBarcDel.Text = ""
                    'lblNmBrg.Text = ""
                    'lblStatus.Text = ""
                    TxbBarcDel.Focus()

                    Dim btl As DataRow = ds_batal.Tables("_batal").NewRow
                    btl.Item("no") = y : y += 1
                    btl.Item("no_ref") = dtrow(i).Item("no_ref").ToString
                    btl.Item("tgl_batal") = getTanggal()
                    btl.Item("kd_stok") = dtrow(i).Item("kd_stok").ToString
                    btl.Item("kd_satuan") = dtrow(i).Item("kd_satuan").ToString
                    btl.Item("petugas") = username
                    ds_batal.Tables("_batal").Rows.Add(btl)

                    If dtrow(i)("qty_out") = 0 And dtrow(i)("qty_order") = 0 Then
                        GvBKE_d.BeginSort()
                        Try
                            For Each rw In dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcDel.Text & "'and no_ref='" & LookRcnKrm.EditValue & "'")
                                rw.Delete()
                            Next
                        Finally
                            GvBKE_d.EndSort()
                        End Try

                    End If
                End If

            Next

            'lblNmBrg.ForeColor = Color.Magenta
            'lblStatus.ForeColor = Color.Magenta
            If dtrow.Count = 0 Then
                MsgBox("Item tidak ada dalam Daftar", MsgBoxStyle.Exclamation)
                'MsgBox("KOSONG")
                tunda()
                txbBarcode.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                TxbBarcDel.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Exclamation)
                'lblStatus.Text = "STOP!"
            End If
            TxbBarcDel.SelectAll()
        End If
    End Sub
End Class