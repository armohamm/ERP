'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frBKSvc
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_cari2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DAL, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
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
        If GvBKSvc.Columns(7).SummaryItem.SummaryValue <> 0 Or LuSVC.EditValue = vbNullString Or TxbPenerima.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP! " & vbCrLf & "Penerima tidak diisi atau qty out blm klop !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        frmMain.btnCetak.Enabled = True
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where substring((no_trans),12,3)='SVC'", sqlconn)) '
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
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("tipe_trans") = "JPB-KUT-05"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvBKSvc.Columns(6).SummaryItem.SummaryValue
        row.Item("penerima") = TxbPenerima.Text
        row.Item("no_ref") = LuSVC.EditValue
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
                row1.Item("kd_Cabang") = kdcabang
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
                row.Item("no_trans") = getNoTrans("BK-SVC", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")

                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                        row1.Item("no_ref") = LuSVC.EditValue
                    End If
                Next
            End If

            DA.Update(dSO.Tables("_bke"))
            DA2.Update(dSO1.Tables("_bke_d"))


            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                'If row1.RowState = DataRowState.Added Then
                Dim sqlcmd As New SqlCommand("update PURC.dbo.PURC_PO_D set inv_stat=1 where no_po='" & LuSVC.EditValue & "' ", sqlconn, BTRANS)
                sqlcmd.ExecuteNonQuery()

            Next

            '## spc stok saldo gudang out
            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_out"), BTRANS)
                End If
            Next        '' ## sp 2
            'For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
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
        callReport(App_Path() & "\report\BK_SVC.rpt", "", "notrans=" & txbNoTrans.Text)
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

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

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
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 16).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 16).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 16).Value = panjangx
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub


    Public Sub bersihkan()
        txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupSPM.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        LuSVC.EditValue = vbNullString
        TxbBarcode.Text = ""
        dSO1.Clear()
    End Sub
   

    Private Sub frBKSvc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prn = getParent(Me)
        connect()

        GvBKSvc.Columns("rp_trans").Visible = False
        GvBKSvc.Columns("qty_sisa").Visible = False
        GvBKSvc.Columns("harga").Visible = False
        LoadStruktur("xxxx")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct(no_po) from PURC.dbo.PURC_PO_D where SUBSTRING(no_po,12,1)='J' and inv_stat<>1", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookSvc")
        LuSVC.Properties.DataSource = ds_cari.Tables("_lookSvc")
        LuSVC.Properties.ValueMember = "no_po"
        LuSVC.Properties.DisplayMember = "no_po"

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup2")
        'LuGdgAsal.Properties.DataSource = ds_cari1.Tables("_lookup2")
        'LuGdgAsal.Properties.ValueMember = "Kode_Gudang"
        'LuGdgAsal.Properties.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookBRG")
        RL_Barang.DataSource = ds_cari2.Tables("_lookBRG")
        RL_Barang.ValueMember = "Kode_Barang"
        RL_Barang.DisplayMember = "Nama_Barang"

    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as kd_supplier,'' as kode_gudang,0 as harga from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bke_d")
        GcBKSvc.DataSource = dSO1.Tables("_bke_d")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub
    Private Sub TxbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress
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
                    BindingContext(GcBKSvc.DataSource).Position = getPosisi(dtrow(i))
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
        System.Threading.Thread.Sleep(700)
    End Sub

    Private Sub LuSVC_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LuSVC.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("select pod.no_po,podb.kd_stok,podb.kd_satuan,ISNULL(uk.Tinggi,0) as tinggi,isnull(uk.Lebar,0) as lebar,isnull(uk.Panjang,0) as panjang,podb.spek_brg,brg.kd_ukuran,podb.qty,podb.qty_sisa,podb.harga,brg.lokasi,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PURC.dbo.PURC_PO_D as pod INNER JOIN PURC.dbo.PURC_PO_D_BARANG AS podb on pod.no_po=podb.no_po INNER JOIN SIF.dbo.SIF_Barang as brg on podb.kd_stok=brg.Kode_Barang LEFT JOIN SIF.dbo.SIF_Ukuran as uk on brg.kd_ukuran=uk.Kode_Ukuran where pod.no_po='" & LuSVC.EditValue & "'", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bke_d").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
                rw.Item("Kd_Cabang") = kdcabang
                rw.Item("no_seq") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("kd_stok")
                rw.Item("kd_satuan") = sqldr.Item("kd_satuan")
                rw.Item("kd_ukuran") = sqldr.Item("kd_ukuran")
                rw.Item("qty_order") = sqldr.Item("qty")
                rw.Item("qty_sisa") = sqldr.Item("qty_sisa")
                rw.Item("harga") = sqldr.Item("harga")
                rw.Item("tinggi") = sqldr.Item("tinggi")
                rw.Item("lebar") = sqldr.Item("lebar")
                rw.Item("gudang_asal") = sqldr.Item("lokasi")
                rw.Item("gudang_tujuan") = "G0008"
                rw.Item("panjang") = sqldr.Item("panjang")
                rw.Item("qty_out") = sqldr.Item("qty_out")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")

                dSO1.Tables("_bke_d").Rows.Add(rw)
            End While
            sqldr.Close()
            GvBKSvc.FocusedColumn = GvBKSvc.VisibleColumns(4)
        End If
    End Sub
    
    Private Sub GvBKSvc_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKSvc.CellValueChanged
        If e.Column Is qty_out Then
            GvBKSvc.GetRow(e.RowHandle).item("rp_trans") = GvBKSvc.GetRow(e.RowHandle).item("qty_out") * GvBKSvc.GetRowCellValue((e.RowHandle), "harga")
            GvBKSvc.GetRow(e.RowHandle).item("qty_sisa") = GvBKSvc.GetRow(e.RowHandle).item("qty_order") - GvBKSvc.GetRow(e.RowHandle).item("qty_out")
        End If
    End Sub

    Private Sub LuSVC_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LuSVC.QueryPopUp
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct(no_po) from PURC.dbo.PURC_PO_D where SUBSTRING(no_po,12,1)='J' and inv_stat<>1", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookSvc")
        LuSVC.Properties.DataSource = ds_cari.Tables("_lookSvc")
        LuSVC.Properties.ValueMember = "no_po"
        LuSVC.Properties.DisplayMember = "no_po"
    End Sub
End Class