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


Public Class frmInvBKE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, ds_batal, dso2, ds_cari, ds_rcn, ds_cari1, ds_cari2, ds_cari3, dsLookUp As New DataSet
    Dim Buildernya, Buildernyaz As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DA_batal, DALOOKUP1, DA_rcn, DALOOKUP2, DALOOKUP3, da_blthn As SqlClient.SqlDataAdapter
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
        enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    'Private Function bulan0(ByVal x As Object)
    '    If Len(bln) = 1 Then
    '        bulan0 = "0" & bln
    '    End If
    '    Return bln
    'End Function


    Public Sub save_click()
        'If GvBKE_d.Columns("qty_out").SummaryItem.SummaryValue <> 0 Or CbRcnKrm.EditValue = vbNullString Then
        'MsgBox(GvBKE_d.Columns("akhir_qty_onstok").SummaryItem.SummaryValue)
        'MsgBox(GvBKE_d.Columns("qty_out").SummaryItem.SummaryValue)
        If STATE = "ADD" Then
            If GvBKE_d.Columns("qty_out").SummaryItem.SummaryValue = 0 Or CbRcnKrm.EditValue = vbNullString Then
                MsgBox("Data tidak LENGKAP atau " & vbCrLf & "ADA BARANG YANG BELUM TERDAFTAR !", MsgBoxStyle.Information)
                Exit Sub
                'ElseIf GvBKE_d.Columns("qty_out").SummaryItem.SummaryValue >= GvBKE_d.Columns("akhir_qty_onstok").SummaryItem.SummaryValue Then
                '   MsgBox("Qty Available  QTY out " & vbCrLf & "Qty tersedia tidak mencukupi, silahkan hubungi PPIC  !", MsgBoxStyle.Information)
                '  Exit Sub
            End If
        Else
            If GvBKE_d.Columns("qty_out").SummaryItem.SummaryValue = 0 Then
                MsgBox("Qty Out blm lengkap !!!", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()


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


    Public Sub edit_click()
        enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans,no_ref[no_plan_krm],sudah_sj ,cetak_ulang from INV.DBO.INV_BKE where substring((no_trans),12,3)='BKE' ORDER BY no_ref DESC", sqlconn)) '
        If Not dSO.Tables("lookup_bke") Is Nothing Then dSO.Tables("lookup_bke").Clear()
        DA.Fill(dSO, "lookup_bke")
        frmCari.set_dso(dSO.Tables("lookup_bke")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(0))
            If frmCari.row.Item("cetak_ulang") = "Y" Then
                frmMain.btnCetak.Enabled = True
                'MsgBox("cetak")
            ElseIf frmCari.row.Item("cetak_ulang") = "T" Then
                frmMain.btnCetak.Enabled = False
                'MsgBox("no cetak")
            End If

            If cekData(dSO.Tables("_bke").Rows(0).Item("no_ref").ToString, frmCari.row(0)) Then
                If MsgBox("Ada perubahan daftar pengiriman. Reload ulang daftar pengiriman?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "RELOAD?") = MsgBoxResult.Yes Then
                    loadDataGrid()
                End If
            End If

            If frmCari.row.Item("sudah_sj").ToString = True Then
                'txbSJSupplier.Enabled = False
                LookDPB.Enabled = False
                STATE = "EDIT"
                btnSave = False
                Me.Enabled = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
                setStatus()
            ElseIf frmCari.row.Item("sudah_sj").ToString = False Then
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                btnSave = True
                STATE = "EDIT"
                Me.Enabled = True
                setStatus()
                'LookupPO.Enabled = False
                'txbNmTrima.Enabled = True
            Else
                cancel_click()
                'LookupPO.Enabled = False
                STATE = ""
            End If
        End If
    End Sub

    Public Sub simpan()
        DA.SelectCommand.CommandTimeout = 0
        DA2.SelectCommand.CommandTimeout = 0
        'DA_batal.SelectCommand.CommandTimeout = 0
        Dim BTRANS As SqlTransaction
        Dim arrNoTrans(CbRcnKrm.EditValue.ToString.Split(",").Length - 1) As String
        For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
            arrNoTrans(i) = getNoTrans("BKE", getTanggal(BTRANS), BTRANS)
            'arrno_pol(i)=
        Next
        'STATE = "ADD"
        'txbNoTrans.Text = row.Item("no_trans") (Sementara tak balikno mas yaya' gak isok ngesave)
        'txbNoTrans.Text = arrNoTrans()
        For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
            'If CBeditKirim.Properties.Items(i).CheckState = CheckState.Checked Then
            If STATE = "ADD" Then
                row = dSO.Tables("_bke").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("cetak_ulang") = "Y"
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_bke").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

            'row.Item("no_trans") = getNoTrans("BKE", getTanggal())
            row.Item("blthn") = blthn()
            row.Item("sudah_sj") = 0
            row.Item("no_trans") = arrNoTrans(i)

            row.Item("tipe_trans") = "JPB-KUT-01"
            row.Item("tgl_trans") = getTanggal()
            row.Item("no_ref") = CbRcnKrm.EditValue.ToString.Split(",")(i).Trim(" ") 'CbRcnKrm.Properties.Items(i).Value
            'MsgBox(CbRcnKrm.EditValue.ToString.Split(",")(i).Trim(" "))
            'MsgBox(CbRcnKrm.Properties.Items(i).Value.ToString)
            'row.Item("no_pol") = txbNoPol.Text
            row.Item("jml_rp_trans") = GvBKE_d.Columns(14).SummaryItem.SummaryValue
            'row.Item("penerima") = txbNmTrima.Text
            row.Item("Program_Name") = Me.Name
            If STATE = "ADD" Then
                dSO.Tables("_bke").Rows.Add(row)
            End If

            'End If
        Next
        'txbNoTrans.Text = row.Item("no_trans")

        For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            If row1.RowState = DataRowState.Added Then
                row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = row.Item("tipe_trans")
                row1.Item("Last_Create_Date") = getTanggal()
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = kdcabang
                row1.Item("blthn") = blthn()
                row1.Item("Program_name") = Me.Name
            ElseIf row1.RowState = DataRowState.Modified Then
                'Dim sqlrd As SqlDataReader=New SqlCommand("update 
                row1.Item("Last_Update_Date") = getTanggal()
                row1.Item("Last_Updated_By") = username
            ElseIf row1.RowState = DataRowState.Deleted Then
                row1.Delete()
            End If
        Next

        'BTRANS = sqlconn.BeginTransaction("1")
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernyaz = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernyaz.GetUpdateCommand()
            DA2.InsertCommand = Buildernyaz.GetInsertCommand()
            DA2.DeleteCommand = Buildernyaz.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA_batal)
            'DA_batal.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA_batal.InsertCommand = Buildernya.GetInsertCommand()
            'DA_batal.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            'DA_batal.UpdateCommand.Transaction = BTRANS
            'DA_batal.InsertCommand.Transaction = BTRANS
            'DA_batal.DeleteCommand.Transaction = BTRANS

            'If STATE = "ADD" Then

            '    'txbNoTrans.Text = row.Item("no_trans")
            '    For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '        If row1.RowState = DataRowState.Added Then
            '            row1.Item("no_trans") = row.Item("no_trans")
            '        End If
            '    Next
            'End If
            If STATE = "ADD" Then
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
            End If

            'For i As Integer = 0 To dSO1.Tables("_bke_d").Columns.Count - 1
            '    MsgBox(dSO1.Tables("_bke_d").Columns.Item(i).ColumnName & " : " & dSO1.Tables("_bke_d").Rows(0).Item(i).ToString.Length)
            'Next
            DA.Update(dSO.Tables("_bke"))
            DA2.Update(dSO1.Tables("_bke_d"))
            'DA_batal.Update(ds_batal.Tables("_batal"))

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
            'If MsgBox("Cetak Langsung ? Jika Cetak Langsung pilih Yes, Jika Cetak Nanti pilih NO", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '    For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
            '        callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & arrNoTrans(i), True, True)
            '    Next
            'End If


            showMessages("Berhasil disimpan..!")
            frmMain.btnSave.Enabled = False
            Me.Enabled = False
            STATE = "EDIT"
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges()
            dSO.Tables("_bke_d").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        da_blthn = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        da_blthn.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Public Sub cetak_click()
        MsgBox("Silahkan Menggunakan Fasilitas Cetak Ulang ada di menu, Terima kasih")
        'For i As Integer = 0 To CbRcnKrm.EditValue.ToString.Split(",").Length - 1
        'callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & txbNoTrans.Text, True, True)
        '    Next
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

    'Public Sub cetak_click()
    '    callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & txbNoTrans.Text, False, True)
    'End Sub

    Private Sub frmInvBKE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        TxbBarcDel.Visible = False
        LookDPB.Visible = False
        lblBarcDel.Visible = False
        lblRcnKrm.Visible = False
        slesai.Visible = False
        connect()

        GvBKE_d.Columns("akhir_qty_onstok").Visible = False
        GvBKE_d.Columns("rp_trans").Visible = False
        'GvBKE_d.Columns("no_seq").Visible = False
        'GvBKE_d.Columns("kd_stok").Visible = False
        GvBKE_d.Columns("harga").Visible = False
        GvBKE_d.Columns("aliasbrg").Visible = False
        GvBKE_d.Columns("no_pol").Visible = False
        GvBKE_d.Columns("sopir").Visible = False
        GvBKE_d.Columns("qty_batal").Visible = False
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

        Loadblthn()

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select sod.Kd_Stok as Kode_Barang,ISNULL(sod.Deskripsi,brg.Nama_Barang) as Nama_Barang from sales.dbo.SALES_SO_D sod inner join sif.dbo.SIF_Barang brg on  sod.Kd_Stok=brg.Kode_Barang inner join prod.dbo.PROD_rcn_krm_d as krm on sod.No_sp=krm.no_sp", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup2")
        'LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        'LookupBarang.ValueMember = "Kode_Barang"
        'LookupBarang.DisplayMember = "Nama_Barang"
        Dim cmd As New SqlCommand("SELECT distinct(dpbm.no_trans) as no_dpb FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0 ", sqlconn)
        cmd.CommandTimeout = 0
        DA_rcn = New SqlDataAdapter(cmd)
        DA_rcn.Fill(ds_rcn, "_redit")
        LookDPB.Properties.DataSource = ds_rcn.Tables("_redit")
        LookDPB.Properties.ValueMember = "no_dpb"
        LookDPB.Properties.DisplayMember = "no_dpb"

        

        LoadStruktur("xxx")

        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans_krm) FROM PROD.dbo.PROD_dpb_m where 1=0", sqlconn)) ' 
        DALOOKUP.Fill(ds_cari, "_rcnkrm")
        CbRcnKrm.Properties.DataSource = ds_cari.Tables("_rcnkrm")
        CbRcnKrm.Properties.ValueMember = "no_trans_krm"
        CbRcnKrm.Properties.DisplayMember = "no_trans_krm"

    End Sub
    Public Sub refresh_bln_thn()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(dpbm.no_trans_krm) as no_trans_krm FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0 and SUBSTRING(dpbm.no_trans_krm,1,6)='" & lookupBulanAwal.EditValue & "' order by no_trans_krm ", sqlconn)) ' 
        DALOOKUP.Fill(ds_cari, "_rcnkrm")
        CbRcnKrm.Properties.DataSource = ds_cari.Tables("_rcnkrm")
        CbRcnKrm.Properties.ValueMember = "no_trans_krm"
        CbRcnKrm.Properties.DisplayMember = "no_trans_krm"
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
        If Not ds_batal.Tables("_batal") Is Nothing Then ds_batal.Tables("_batal").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_BKE where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        If STATE = "EDIT" Then
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as seq_dpb, from INV.dbo.INV_BKE_D where no_trans='" & kode & "'", sqlconn))
        Else
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as seq_dpb,0 as sisa,0.0 qtyGudang, 0.0 qtySaldo, 0 as akhir_qty_onstok, '' as no_pol,'' as sopir from INV.dbo.INV_BKE_D where no_trans='" & kode & "'", sqlconn))
        End If
        DA2.Fill(dSO1, "_bke_d")
        GcBKE_d.DataSource = dSO1.Tables("_bke_d")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct no_ref, blthn FROM INV.dbo.INV_GUDANG_OUT where no_trans = '" & kode & "'", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            CbRcnKrm.Properties.DataSource = ds_cari.Tables("_lookup1")
            CbRcnKrm.Enabled = False
            lookupBulanAwal.Enabled = False
            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            'txbNoTrans.Text = rw("no_trans").ToString
            'txbNmTrima.Text = rw("no_dpb").ToString
            CbRcnKrm.EditValue = rw("no_ref").ToString
            lookupBulanAwal.EditValue = rw("blthn").ToString
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

    Private Sub txbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbBarcode.KeyPress
        Dim ok As Boolean = False
       


        If e.KeyChar = Chr(13) Then
            Dim kodebrg1 As String = txbBarcode.Text
            Dim kd As String = kodebrg1.Substring(0, kodebrg1.Length - 4)
            'MsgBox(kd)
            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & kd & "'")
            'Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & txbBarcode.Text & "'")
            lblNmBrg.ForeColor = Color.Yellow
            lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                lblStatus.Text = "OK"
                lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                txbBarcode.SelectAll()
                If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    ''If dtrow.Count > 0 Then
                    '#CEK KUNCI SALDO
                    'If dtrow(i)("qtyGudang") <= dtrow(i)("qty_out") Or dtrow(i)("qtySaldo") <= dtrow(i)("qty_out") Then
                    '    txbBarcode.Text = ""
                    '    lblNmBrg.Text = "Saldo Barang Tidak Mencukupi"
                    '    lblStatus.Text = "SALDO KURANG"
                    '    tunda()

                    '    txbBarcode.Focus()
                    '    Exit Sub
                    'Else
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                    dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    txbBarcode.Text = ""
                    txbBarcode.Focus()
                    'MsgBox("barang ada")
                    Exit Sub

                    'End If
                Else
                    txbBarcode.Text = ""
                    lblNmBrg.Text = "Jumlah Barang Melebihi Order"
                    lblStatus.Text = "BARANG LEBIH"
                    tunda()

                    txbBarcode.Focus()
                    Exit Sub
                End If

            Next
            lblNmBrg.ForeColor = Color.Magenta
            lblStatus.ForeColor = Color.Magenta
            If dtrow.Count = 0 Then
                txbBarcode.Text = ""
                lblNmBrg.Text = "Item Tidak Ada Dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()

                txbBarcode.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                lblNmBrg.Text = "Barang sudah terdaftar semua"
                lblStatus.Text = "STOP!"
            End If
            txbBarcode.SelectAll()
        End If
    End Sub


    'Public Function nomerGen(ByVal bgtrans As SqlTransaction) As String
    '    Dim hasil, temp As String
    '    Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,5,3) as numeric)) from INV.DBO.INV_GUDANG_OUT where substring(no_trans,1,3)='BKE'", sqlconn, bgtrans).ExecuteReader
    '    sqlDR.Read()
    '    temp = ""
    '    If TypeOf sqlDR.Item(0) Is DBNull Then
    '        hasil = "BKE/001/" & thn & "/" & bulan0()
    '    Else
    '        hasil = sqlDR.Item(0)
    '        For i As Int16 = Len(hasil) To 2
    '            temp = "0" & temp
    '        Next
    '        hasil = "BKE/" & temp & (hasil + 1) & "/" & thn & "/" & bulan0()
    '    End If
    '    sqlDR.Close()
    '    Return hasil
    'End Function

    'Private Sub GvBKE_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKE_d.CellValueChanged
    '    If e.Column Is qty_out Then
    '        GvBKE_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKE_d.GetRow(e.RowHandle).item("qty_ord").ToString - GvBKE_d.GetRow(e.RowHandle).item("qty_out").ToString
    '    End If
    'End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ServiceSpringUmu()
        'btnUbah.Enabled = False
        'btnSimpan.Enabled = True
        bersihkan()
        enabel()
        STATE = "ADD"
        'GvBKE_d.Columns("no_seq").Visible = False
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'btnHapus.Enabled = True
        'btnSimpan.Enabled = True
        enabel()
        STATE = "EDIT"
        'GvBKE_d.Columns("no_seq").Visible = True
        edit_click()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(blthn)
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub





    Public Sub bersihkan()
        'txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        CbRcnKrm.EditValue = vbNullString
        lookupBulanAwal.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Public Sub enabel()
        'txbNoTrans.Enabled = True
        'txbNmTrima.Enabled = True
        'dtpTgl.Enabled = True
        'LookupGudang.Enabled = True
        CbRcnKrm.Enabled = True
        'btnSimpan.Enabled = True
    End Sub

    Public Sub disabel()
        'txbNoTrans.Enabled = False
        'txbNmTrima.Enabled = False
        'LookupGudang.Enabled = False
        'dtpTgl.Enabled = False
        CbRcnKrm.Enabled = False
    End Sub


    'Private Sub GvBKE_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKE_d.CellValueChanged
    '    If e.Column Is qty_out Then
    '        If GvBKE_d.GetRow(e.RowHandle).item("qty_out") > GvBKE_d.GetRow(e.RowHandle).item("qty_sisa") Then
    '            Exit Sub
    '        Else
    '            GvBKE_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKE_d.GetRowCellValue((e.RowHandle), "qty_order") - GvBKE_d.GetRowCellValue((e.RowHandle), "qty_out")
    '            GvBKE_d.GetRow(e.RowHandle).item("rp_trans") = GvBKE_d.GetRow(e.RowHandle).item("harga") * GvBKE_d.GetRow(e.RowHandle).item("qty_out")
    '        End If
    '    End If
    'End Sub

    Private Sub LookRcnKrm_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ds_cari.Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans_krm) as no_trans_krm FROM PROD.dbo.PROD_dpb_m as dpbm inner join PROD.dbo.PROD_dpb_d as dpbd on dpbm.no_trans=dpbd.no_trans where inv_stat = 0  ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        CbRcnKrm.Properties.DataSource = ds_cari.Tables("_lookup1")
        CbRcnKrm.Properties.ValueMember = "no_trans_krm"
        CbRcnKrm.Properties.DisplayMember = "no_trans_krm"
    End Sub

    Private Sub CBeditKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbRcnKrm.EditValueChanged
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
            'stok saldo
            'Dim sqldr As SqlDataReader = New SqlCommand("SELECT sod.Kd_stok,isnull(sld.akhir_qty_onstok,0) as akhir_qty_onstok,sld.bultah,sod.harga,sod.Deskripsi as deskripsi,sod.kd_satuan,dpbm.tanggal,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0) as lebar,isnull(uk.Tinggi,0) as tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans  and dpbd.no_sp=dpbm.no_sp INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang left join sif.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran LEFT join  SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir inner join INV.dbo.INV_STOK_SALDO as sld on sld.kd_stok=sod.Kd_Stok where dpbm.no_trans_krm in (" & whereStr & ") and sld.bultah=(select max(bultah) from INV.dbo.INV_STOK_SALDO) order by no_sp, len(no_sp_dtl),no_sp_dtl ", sqlconn).ExecuteReader
            'Dim sqldr As SqlDataReader = New SqlCommand("SELECT sod.Kd_stok,sod.harga,sod.Deskripsi as deskripsi,sod.kd_satuan,dpbm.tanggal,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0) as lebar,isnull(uk.Tinggi,0) as tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans  and dpbd.no_sp=dpbm.no_sp INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang left join sif.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran LEFT join  SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir where dpbm.no_trans_krm in (" & whereStr & ") order by no_sp_dtl, len(no_sp_dtl) ", sqlconn).ExecuteReader

            Dim sqldr As SqlDataReader = New SqlCommand("SELECT dpbm.no_trans,so.Atas_Nama,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,sod.Kd_stok,sod.harga,sod.Deskripsi as deskripsi,sod.kd_satuan,dpbm.tanggal,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0) as lebar,isnull(uk.Tinggi,0) as tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out " & _
                      "from PROD.dbo.PROD_dpb_d as dpbd inner join " & _
                      "PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans  and dpbd.no_sp=dpbm.no_sp " & _
                      "INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq " & _
                      "inner join SALES.dbo.SALES_SO so on sod.No_sp=so.No_sp " & _
                      "inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang " & _
                      "left join sif.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran " & _
                      "LEFT join  SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir " & _
                      "where dpbm.no_trans_krm in (" & whereStr & ") order by dpbm.no_trans, so.Atas_Nama,seq_dpb,dpbd.no_sp_dtl ", sqlconn).ExecuteReader
            Dim x As Int16 = 1
            dSO1.Tables("_bke_d").Clear()

            While sqldr.Read
                Dim rw1 As DataRow = dSO1.Tables("_bke_d").NewRow

                rw1.Item("Kd_Cabang") = kdcabang
                rw1.Item("no_ref") = sqldr.Item("no_trans_krm")
                rw1.Item("no_ref2") = sqldr.Item("no_dpb")
                rw1.Item("tgl_ref2") = sqldr.Item("tanggal")
                rw1.Item("no_sp") = sqldr.Item("no_sp")
                rw1.Item("no_sp_dtl") = sqldr.Item("no_sp_dtl")
                rw1.Item("seq_dpb") = sqldr.Item("seq_dpb")
                rw1.Item("keterangan") = sqldr.Item("Atas_Nama")
                rw1.Item("no_seq") = x : x += 1
                rw1.Item("kd_stok") = sqldr.Item("Kd_stok")
                rw1.Item("kd_satuan") = sqldr.Item("kd_satuan")
                rw1.Item("qty_order") = sqldr.Item("jumlah")
                'rw1.Item("qty_sisa") = sqldr.Item("jumlah") '' sementara
                rw1.Item("qty_out") = sqldr.Item("jumlah") ''SEMENTARA DI ANGGAP KLUAR SEMUA
                rw1.Item("qty_sisa") = rw1.Item("qty_order") - rw1.Item("qty_out")
                rw1.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                rw1.Item("panjang") = sqldr.Item("panjang")
                rw1.Item("lebar") = sqldr.Item("lebar")
                rw1.Item("tinggi") = sqldr.Item("tinggi")
                rw1.Item("harga") = sqldr.Item("harga")
                rw1.Item("deskripsi") = sqldr.Item("Deskripsi")
                'rw1.Item("qty_out") = sqldr.Item("qty_out")
                rw1.Item("rp_trans") = 0
                rw1.Item("qty_batal") = rw1.Item("qty_order") - rw1.Item("qty_out")
                rw1.Item("gudang_asal") = KodeGudangBarangJadi  'sqldr.Item("lokasi") 'lokasi di master brg sbg default
                rw1.Item("gudang_tujuan") = "G0007" 'Gudang Expedisi sbg Default
                rw1.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw1.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")
                rw1.Item("no_pol") = sqldr.Item("no_pol").ToString
                rw1.Item("sopir") = sqldr.Item("Nama_Sopir").ToString
                With New SqlCommand("select akhir_qty from inv.dbo.inv_stok_gudang where kode_gudang='" & KodeGudangBarangJadi & "' and kd_stok='" & sqldr.Item("Kd_stok") & "' and bultah = '" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
                    .Read()
                    Try
                        If .HasRows Then
                            rw1.Item("qtyGudang") = .Item(0)
                        Else
                            rw1.Item("qtyGudang") = 0
                        End If
                        .Close()
                    Catch ex As Exception
                        MsgBox("Error Occured : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        If Not .IsClosed Then .Close()
                    End Try
                End With
                With New SqlCommand("select akhir_qty_onstok from inv.dbo.inv_stok_saldo where kd_stok='" & sqldr.Item("Kd_stok") & "' and bultah = '" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
                    .Read()
                    Try
                        If .HasRows Then
                            rw1.Item("qtySaldo") = .Item(0)
                        Else
                            rw1.Item("qtySaldo") = 0
                        End If
                        .Close()
                    Catch ex As Exception
                        MsgBox("Error Occured : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                        If Not .IsClosed Then .Close()
                    End Try

                End With

                'rw1.Item("akhir_qty_onstok") = sqldr.Item("akhir_qty_onstok")

                dSO1.Tables("_bke_d").Rows.Add(rw1)
            End While

            sqldr.Close()
            GcBKE_d.DataSource = dSO1.Tables("_bke_d")
            GvBKE_d.FocusedColumn = GvBKE_d.VisibleColumns(6)
        End If
    End Sub

    Private Sub hapus_item()
        txbBarcode.Visible = False
        TxbBarcDel.Visible = True
        LookDPB.Visible = True
        lblBarcDel.Visible = True
        lblRcnKrm.Visible = True
        lblRcnKrm1.Visible = False
        slesai.Visible = True
        btnHapus.Enabled = False
        '###INV_BATAL
        'DA_batal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_BATAL where 1=0", sqlconn))
        'DA_batal.Fill(ds_batal, "_batal")

    End Sub
    Private Sub afterdel()
        txbBarcode.Visible = True
        TxbBarcDel.Visible = False
        LookDPB.Visible = False
        lblBarcDel.Visible = False
        lblRcnKrm.Visible = False
        lblRcnKrm1.Visible = True
        slesai.Visible = False
        btnHapus.Enabled = True
    End Sub


    Private Sub TxbBarcDel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcDel.KeyPress
        Dim ok As Boolean = False
        Dim y As Int16 = 1
        If e.KeyChar = Chr(13) Then


            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcDel.Text & "' and no_ref2='" & LookDPB.EditValue & "'")
            'MsgBox("ketemu")
            lblNmBrg.ForeColor = Color.Yellow
            lblStatus.ForeColor = Color.Yellow
            If dtrow.Count <> 0 Then


                For i As Int16 = 0 To dtrow.Count - 1
                    'MsgBox("perluangan")
                    'Application.DoEvents()

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                    TxbBarcDel.SelectAll()

                    If dtrow(i)("qty_out") > 0 Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        'dtrow(i)("qty_order") = dtrow(i)("qty_order") - 1 ''### sementara order ga bole berkurang, yg bole outnya aja
                        dtrow(i)("qty_out") = dtrow(i)("qty_out") - 1
                        dtrow(i)("qty_batal") = dtrow(i)("qty_batal") + 1
                        dtrow(i)("status_brg_batal") = "OPEN"
                        'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        'TxbBarcDel.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        TxbBarcDel.Focus()

                        '### barang batal di inv_batal
                        'Dim btl As DataRow = ds_batal.Tables("_batal").NewRow
                        'btl.Item("no") = y + 1
                        'btl.Item("renc_krm") = dtrow(i).Item("no_ref").ToString
                        'btl.Item("no_dpb") = dtrow(i).Item("no_ref2").ToString
                        'btl.Item("tgl_batal_trans") = getTanggal()
                        'btl.Item("kd_stok") = dtrow(i).Item("kd_stok").ToString
                        'btl.Item("kd_satuan") = dtrow(i).Item("kd_satuan").ToString
                        'btl.Item("petugas") = username
                        'ds_batal.Tables("_batal").Rows.Add(btl)

                        Exit Sub
                    ElseIf dtrow(i)("qty_out") = 0 Then
                        For Each rw In dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcDel.Text & "'and no_ref2='" & LookDPB.EditValue & "'")
                            rw.Delete()
                        Next
                        'ElseIf dtrow(i)("qty_out") = 0 And dtrow(i)("qty_order") > 0 Then
                        'dtrow(i)("qty_order") = dtrow(i)("qty_order") - 1
                        'dtrow(i)("qty_out") = dtrow(i)("qty_out") - 1
                        'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        'TxbBarcDel.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        TxbBarcDel.Focus()


                        'If dtrow(i)("qty_out") = 0 And dtrow(i)("qty_order") = 0 Then
                        '    GvBKE_d.BeginSort()
                        '    Try
                        '        For Each rw In dSO1.Tables("_bke_d").Select("kd_stok='" & TxbBarcDel.Text & "'and no_ref2='" & LookDPB.EditValue & "'")
                        '            rw.Delete()
                        '        Next
                        '    Finally
                        '        GvBKE_d.EndSort()
                        '    End Try

                        'End If
                    End If

                Next

                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta
            Else
                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                txbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbBarcDel.Focus()

                'MsgBox("barang tidak ada")
                
            End If
            If Not ok Then
                lblNmBrg.Text = "Barang sudah terdaftar semua"
                lblStatus.Text = "STOP!"
            End If

            TxbBarcDel.SelectAll()
        End If

    End Sub

    Private Sub isi_batal()

    End Sub
    Private Sub btnHapus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Anda Yakin Akan Menghapus Item? Apakah Sudah Kordinasi PPIC?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_item()
    End Sub

    Private Sub slesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slesai.Click
        afterdel()
    End Sub

    Private Sub GvBKE_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKE_d.CellValueChanged
        If e.Column Is qty_out Then
            If GvBKE_d.GetRow(e.RowHandle).item("qty_out") > GvBKE_d.GetRow(e.RowHandle).item("qty_order") Or GvBKE_d.GetRow(e.RowHandle).item("qty_out") < 0 Then
                MsgBox("Barang Quantity Good lebih besar dari Order! silahkan isi dengan benar")
                GvBKE_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKE_d.GetRow(e.RowHandle).item("qty_order")
                Exit Sub
            ElseIf GvBKE_d.GetRow(e.RowHandle).item("qty_order") > GvBKE_d.GetRow(e.RowHandle).item("qty_out") Then

                GvBKE_d.GetRow(e.RowHandle).item("qty_batal") = GvBKE_d.GetRow(e.RowHandle).item("qty_order") - GvBKE_d.GetRow(e.RowHandle).item("qty_out")

                '## Cek Stok Saldo (Data)
                'ElseIf GvBKE_d.GetRow(e.RowHandle).item("qty_out") > GvBKE_d.GetRow(e.RowHandle).item("akhir_qty_onstok") Then 'Jika melebihi stok saldo yg tersedia
                '    MsgBox("Qty out tidak boleh melebihi Stok yang TERSEDIA !!", MsgBoxStyle.Exclamation)
                '    Exit Sub
            Else
                GvBKE_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKE_d.GetRow(e.RowHandle).item("qty_order") - GvBKE_d.GetRow(e.RowHandle).item("qty_out")
            End If

        End If
    End Sub

    Private Sub GvBKE_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBKE_d.InitNewRow
        'GvBMI_d.GetRow(e.RowHandle).item("No_Seq") = GvBKE_d.RowCount + 1
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        MsgBox("silahkan klik Rencana kirim dan DRAG tombol Rencana kirim kebawah")
        ds_cari.Clear()
        CbRcnKrm.EditValue = vbNullString


        LoadStruktur("xxxx")
        refresh_bln_thn()
    End Sub

    Private Sub GvBKE_d_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvBKE_d.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvBKE_d_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvBKE_d.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("qty_order") < e.Row.item("qty_out") Then
            GvBKE_d.SetColumnError(qty_out, "Barang Keluar Berlebih.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GvBKE_d.FocusedColumn = qty_out
            isValid = False
            'ElseIf e.Row.item("qtySaldo") < e.Row.item("qty_out") Then
            '    GvBKE_d.SetColumnError(qty_out, "Saldo Barang Kurang.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            '    GvBKE_d.FocusedColumn = qty_out
            '    isValid = False
            'ElseIf e.Row.item("qtyGudang") < e.Row.item("qty_out") Then
            '    GvBKE_d.SetColumnError(qty_out, "Saldo Barang Kurang.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            '    GvBKE_d.FocusedColumn = qty_out
            'isValid = False
        End If
        If isValid Then
            e.Row.item("qty_sisa") = e.Row.item("qty_order") - e.Row.item("qty_out")
        End If
        e.Valid = isValid

    End Sub

  
    Private Sub txbBarcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBarcode.TextChanged
        lblNmBrg.Text = ""
        lblStatus.Text = ""
    End Sub

    Private Function cekData(ByVal kirim As String, ByVal inv As String)
        Dim hasil As Boolean
        Dim sqldrxx As SqlDataReader = New SqlCommand("SELECT sod.Kd_stok, dpbd.no_sp, dpbd.jumlah " & _
                                                    "from PROD.dbo.PROD_dpb_d as dpbd " & _
                                                    "inner join PROD.dbo.PROD_dpb_m as dpbm " & _
                                                    "on dpbd.no_trans=dpbm.no_trans and dpbd.no_sp=dpbm.no_sp " & _
                                                    "INNER JOIN SALES.dbo.SALES_SO_D as sod " & _
                                                    "on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq " & _
                                                    "where dpbm.no_trans_krm in ('" & kirim & "') " & _
                                                    "except " & _
                                                    "select kd_stok, no_sp, qty_order from INV.dbo.INV_BKE_D where no_trans='" & inv & "'", sqlconn).ExecuteReader
        sqldrxx.Read()
        If Not sqldrxx.HasRows Then
            hasil = False
        Else
            hasil = True
        End If

        sqldrxx.Close()
        Return hasil
    End Function

    Private Sub loadDataGrid()
        'If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
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
        'stok saldo
        For Each rw As DataRow In dSO1.Tables("_bke_d").Rows
            rw.Delete()
        Next
        'Dim sqldr As SqlDataReader = New SqlCommand("SELECT sod.Kd_stok,isnull(sld.akhir_qty_onstok,0) as akhir_qty_onstok,sld.bultah,sod.harga,sod.Deskripsi as deskripsi,sod.kd_satuan,dpbm.tanggal,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0) as lebar,isnull(uk.Tinggi,0) as tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans  and dpbd.no_sp=dpbm.no_sp INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang left join sif.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran LEFT join  SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir inner join INV.dbo.INV_STOK_SALDO as sld on sld.kd_stok=sod.Kd_Stok where dpbm.no_trans_krm in (" & whereStr & ") and sld.bultah=(select max(bultah) from INV.dbo.INV_STOK_SALDO) order by no_sp, len(no_sp_dtl),no_sp_dtl ", sqlconn).ExecuteReader
        Dim sqldr As SqlDataReader = New SqlCommand("SELECT so.Atas_nama,sod.Kd_stok,sod.harga,sod.Deskripsi as deskripsi,sod.kd_satuan,dpbm.tanggal,dpbm.no_trans_krm,dpbm.kd_customer,dpbm.no_pol,dpbm.kd_sopir,spr.Nama_Sopir,dpbm.kd_kenek,dpbd.no_trans as no_dpb,dpbm.tanggal,dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_seq as seq_dpb,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0) as lebar,isnull(uk.Tinggi,0) as tinggi,dpbd.jumlah,brg.kd_ukuran,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join PROD.dbo.PROD_dpb_m as dpbm on dpbd.no_trans=dpbm.no_trans  and dpbd.no_sp=dpbm.no_sp INNER JOIN SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join sales.dbo.SALES_SO as so on so.No_sp=sod.No_sp inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang left join sif.dbo.SIF_Ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran LEFT join  SIF.dbo.SIF_Sopir as spr on dpbm.kd_sopir=spr.Kode_Sopir where dpbm.no_trans_krm in (" & whereStr & ") order by no_sp, len(no_sp_dtl),no_sp_dtl ", sqlconn).ExecuteReader
        Dim x As Int16 = 1
        'dSO1.Tables("_bke_d").Clear()

        While sqldr.Read
            Dim rw1 As DataRow = dSO1.Tables("_bke_d").NewRow

            rw1.Item("Kd_Cabang") = kdcabang
            rw1.Item("no_ref") = sqldr.Item("no_trans_krm")
            rw1.Item("no_ref2") = sqldr.Item("no_dpb")
            rw1.Item("tgl_ref2") = sqldr.Item("tanggal")
            rw1.Item("no_sp") = sqldr.Item("no_sp")
            rw1.Item("no_sp_dtl") = sqldr.Item("no_sp_dtl")
            rw1.Item("seq_dpb") = sqldr.Item("seq_dpb")
            rw1.Item("no_seq") = x : x += 1
            rw1.Item("kd_stok") = sqldr.Item("Kd_stok")
            rw1.Item("kd_satuan") = sqldr.Item("kd_satuan")
            rw1.Item("qty_order") = sqldr.Item("jumlah")
            rw1.Item("keterangan") = sqldr.Item("Atas_Nama") '' sementara
            rw1.Item("qty_sisa") = sqldr.Item("jumlah")
            rw1.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
            rw1.Item("panjang") = sqldr.Item("panjang")
            rw1.Item("lebar") = sqldr.Item("lebar")
            rw1.Item("tinggi") = sqldr.Item("tinggi")
            rw1.Item("harga") = sqldr.Item("harga")
            rw1.Item("deskripsi") = sqldr.Item("Deskripsi")
            'rw1.Item("qty_out") = sqldr.Item("qty_out")
            rw1.Item("qty_out") = 0
            rw1.Item("rp_trans") = 0
            rw1.Item("qty_batal") = 0
            rw1.Item("gudang_asal") = KodeGudangBarangJadi  'sqldr.Item("lokasi") 'lokasi di master brg sbg default
            rw1.Item("gudang_tujuan") = "G0007" 'Gudang Expedisi sbg Default
            rw1.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
            rw1.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")
            rw1.Item("no_pol") = sqldr.Item("no_pol").ToString
            rw1.Item("sopir") = sqldr.Item("Nama_Sopir").ToString
            With New SqlCommand("select akhir_qty from inv.dbo.inv_stok_gudang where kode_gudang='" & KodeGudangBarangJadi & "' and kd_stok='" & sqldr.Item("Kd_stok") & "' and bultah = '" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
                .Read()
                Try
                    If .HasRows Then
                        rw1.Item("qtyGudang") = .Item(0)
                    Else
                        rw1.Item("qtyGudang") = 0
                    End If
                    .Close()
                Catch ex As Exception
                    MsgBox("Error Occured : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    If Not .IsClosed Then .Close()
                End Try
            End With
            With New SqlCommand("select akhir_qty_onstok from inv.dbo.inv_stok_saldo where kd_stok='" & sqldr.Item("Kd_stok") & "' and bultah = '" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
                .Read()
                Try
                    If .HasRows Then
                        rw1.Item("qtySaldo") = .Item(0)
                    Else
                        rw1.Item("qtySaldo") = 0
                    End If
                    .Close()
                Catch ex As Exception
                    MsgBox("Error Occured : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    If Not .IsClosed Then .Close()
                End Try

            End With

            'rw1.Item("akhir_qty_onstok") = sqldr.Item("akhir_qty_onstok")

            dSO1.Tables("_bke_d").Rows.Add(rw1)
        End While

        sqldr.Close()
        GcBKE_d.DataSource = dSO1.Tables("_bke_d")
        GvBKE_d.FocusedColumn = GvBKE_d.VisibleColumns(6)
    End Sub

End Class