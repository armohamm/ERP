Imports System.Data.SqlClient

Public Class MutasiBrgStok_BC
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, stat_del, stat_data, notrans, bultah As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_byg, dso2, ds_keypress, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, rwx As DataRow
    Private DA, DA2, da_byg, DALOOKUP, DALOOKUP1, DALookup2, DA_gdg1, DA_gdg2, DA_keypres As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private noseq As Integer
    'Public Sub btnstart()
    '    btnTambah.Enabled = True
    '    btnUbah.Enabled = True
    '    btnSimpan.Enabled = False
    '    btnHapus.Enabled = False
    'End Sub
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
        mts()

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
        'If TxbPenerima.Text = "" Then
        '    MsgBox("Harap isi Nama yang meyerahkan Barang!!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
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
        enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_IN where substring((no_trans),8,3)='BMI'", sqlconn)) '
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

    

    Public Sub call_procedure_in(ByVal btrans As SqlTransaction)
        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.Connection = sqlconn
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "INV.dbo.invp_gudang_in"
        sqlCmd1.Transaction = btrans

        sqlCmd1.Parameters.Add("@vno_trans", SqlDbType.Char).Value = txbNoTrans.Text
        sqlCmd1.Parameters.Add("@vbultah", SqlDbType.Char).Value = Format(dtpTanggal.EditValue, "yyyyMM")
        sqlCmd1.ExecuteNonQuery()

    End Sub


    Public Sub cetak_click()
        callReport(App_Path() & "\report\BMI.rpt", "", "notrans_bmi=" & txbNoTrans.Text, False, True)
    End Sub

    Public Sub hapus_record()

    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal tinggix As Double, ByVal lebarx As Double, ByVal panjangx As Double, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

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
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_outx As Integer, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
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
        If Not dSO1.Tables("_bmi_d") Is Nothing Then dSO1.Tables("_bmi_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as qty_onstok from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmi_d")

        'da_byg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as qty_onstok from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        'da_byg.Fill(ds_byg, "_byg")
        GcINV_Ret.DataSource = dSO1.Tables("_bmi_d")



        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bmi").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub

    Public Sub bersihkan()
        txbNoTrans.Text = ""
        LookGd7an.EditValue = vbNullString
        LookGdgAsal.EditValue = vbNullString
        dtpTanggal.EditValue = Today

        dSO1.Clear()
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        TxbBarcode.Enabled = False
        LookGd7an.Enabled = False
        LookGdgAsal.Enabled = False
        btnTambah.Enabled = True
        btnHapus.Enabled = True

    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1500)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_bmi_d").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function

    Private Sub MutasiBrgStok_BC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        prn = getParent(Me)
        connect()

        GvINV_Ret.Columns("qty_onstok").Visible = False
        bultah = blthn()
        txb_qty.Text = 1
        dtpTanggal.EditValue = Today
        'dtpTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        dtpTanggal.Properties.EditFormat.FormatString = "dd/MM/yyyy"

        LoadStruktur("xxxx")

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_gdg1, "_gdgAsal1")
        LookGdgAsal.Properties.DataSource = ds_gdg1.Tables("_gdgAsal1")
        LookGdgAsal.Properties.ValueMember = "Kode_Gudang"
        LookGdgAsal.Properties.DisplayMember = "Nama_Gudang"

        DALookup2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALookup2.Fill(ds_gdg2, "_luGdg7_1")
        LookGd7an.Properties.DataSource = ds_gdg2.Tables("_luGdg7_1")
        LookGd7an.Properties.ValueMember = "Kode_Gudang"
        LookGd7an.Properties.DisplayMember = "Nama_Gudang"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepLookupBarang.DataSource = ds_cari.Tables("_lookup1")
        RepLookupBarang.ValueMember = "Kode_Barang"
        RepLookupBarang.DisplayMember = "Nama_Barang"

        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_gdgAsal")
        RL_GdgAsal.DataSource = ds_gdg1.Tables("_gdgAsal")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_gdg2.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"



        TxbBarcode.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        mts()
    End Sub

    Private Sub txb_qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_qty.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxbBarcode.Focus()
        End If
    End Sub
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        hps_mts()
    End Sub

    Public Sub mts()
        LookGd7an.Enabled = True
        LookGdgAsal.Enabled = True
        TxbBarcode.Enabled = True
        txt_status.Text = "MUTASI GUDANG"
        stat_del = "MTS"
        stat_data = "BARU"
        pnl_Status.BackColor = Color.YellowGreen
        btnHapus.Enabled = True
        btnTambah.Enabled = False
    End Sub

    Public Sub hps_mts()
        LookGd7an.Enabled = True
        LookGdgAsal.Enabled = True
        TxbBarcode.Enabled = True
        txt_status.Text = "PEMBATALAN MUTASI"
        stat_del = "BATAL"
        pnl_Status.BackColor = Color.Red
        btnHapus.Enabled = False
        btnTambah.Enabled = True
    End Sub


    Private Sub TxbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress
        If stat_data = "BARU" Then
            cek_data()
        End If
        cek_data()
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim kodebrg1 As String = TxbBarcode.Text
            Dim kd As String = kodebrg1.Substring(0, kodebrg1.Length - 4)
            MsgBox(kd)
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan, " & _
            "isnull(brg.panjang,0) as panjang,isnull(brg.lebar,0) as lebar,isnull(brg.tinggi,0) as tinggi,brg.kd_ukuran, " & _
            "brg.rek_persediaan,brg.rek_biaya,0 as qty_out,isnull(stok.nilai_rata,0) as harga, isnull(stok.akhir_qty_onstok,0) as qty_onstok " & _
            "from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang " & _
            "where stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & kd & "'", sqlconn))

            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_bmi_d").Select("kd_stok='" & kd & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                'If dtrow.Count = 0 Then
                DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,isnull(brg.panjang,0) as panjang,isnull(brg.lebar,0) as lebar,isnull(brg.tinggi,0) as tinggi,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_out,isnull(stok.nilai_rata,0) as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & kd & "'", sqlconn))
                DA_keypres.Fill(ds_keypress, "_keypres")
                rwx = ds_keypress.Tables("_keypres").Rows(0)
                rw = dSO1.Tables("_bmi_d").NewRow
                If stat_data = "LANJUT" Then
                    rw.Item("no_seq") = noseq
                Else
                    rw.Item("no_seq") = x : x += 1
                End If

                rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                rw.Item("panjang") = rwx.Item("panjang")
                rw.Item("lebar") = rwx.Item("lebar")
                rw.Item("tinggi") = rwx.Item("tinggi")
                rw.Item("qty_onstok") = rwx.Item("qty_onstok")
                'rw.Item("qty_out") = rwx.Item("qty_out") + 1 'pake qty textbox
                rw.Item("qty_out") = txb_qty.Text
                rw.Item("Last_Created_by") = username
                rw.Item("Last_Create_Date") = dtpTanggal.EditValue
                rw.Item("gudang_asal") = LookGdgAsal.EditValue
                rw.Item("gudang_tujuan") = LookGd7an.EditValue

                If stat_del = "MTS" Then
                    rw.Item("stat") = 1
                Else
                    rw.Item("stat") = 0
                End If


                'rw.Item("harga") = rwx.Item("harga")
                'rw.Item("rp_trans") = rw("harga") * rw("qty_in")
                dSO1.Tables("_bmi_d").Rows.Add(rw)

                TxbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txb_qty.Text = 1
                TxbBarcode.Focus()

                If stat_data = "BARU" Then
                    If stat_del = "MTS" Then
                        insert_baru()
                    Else
                        delete_baru()
                    End If

                Else
                    If stat_del = "MTS" Then
                        insert_lanjut()
                    Else
                        delete_lanjut()
                    End If

                End If

                Exit Sub
                'Else
                '    For i As Int16 = 0 To dtrow.Count - 1
                '        'Application.DoEvents()
                '        lblStatus.Text = "OK"
                '        lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                '        TxbBarcode.SelectAll()
                '        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                '        'If dtrow.Count > 0 Then
                '        dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1

                '        'dtrow(i)("rp_trans") = dtrow(i)("qty_in") * dtrow(i)("harga")
                '        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                '        ok = True
                '        BindingContext(GcINV_Ret.DataSource).Position = getPosisi(dtrow(i))
                '        tunda()
                '        TxbBarcode.Text = ""
                '        lblNmBrg.Text = ""
                '        lblStatus.Text = ""
                '        TxbBarcode.Focus()
                '        'MsgBox("barang ada")
                '        Exit Sub
                '        'End If
                '    Next

                'End If
            Else
                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta

                lblNmBrg.Text = "Stok barang Tidak ada!!"
                lblStatus.Text = "KOSONG"
                tunda()
                TxbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbBarcode.Focus()
            End If
            TxbBarcode.SelectAll()
        End If
        ds_keypress.Clear()
    End Sub


    Private Sub LookGd7an_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookGd7an.EditValueChanged
        notrans = LookGdgAsal.EditValue & "/" & LookGd7an.EditValue & "/" & dtpTanggal.Text
        TxbBarcode.Focus()
        Dim sqlcek As SqlDataReader = New SqlCommand("select no_trans from INV.dbo.INV_GUDANG_OUT where no_trans='" & LookGdgAsal.EditValue & "/" & LookGd7an.EditValue & "/" & dtpTanggal.Text & "'", sqlconn).ExecuteReader
        'Clipboard.SetText("select no_trans from INV.dbo.INV_GUDANG_OUT where no_trans='" & LookGdgAsal.EditValue & "/" & LookGd7an.EditValue & "/" & dtpTanggal.Text & "'")
        sqlcek.Read()

        If sqlcek.HasRows Then
            sqlcek.Close()
            stat_data = "LANJUT"
            cek_noseq()
            LoadStruktur(notrans)
        Else
            sqlcek.Close()
            Exit Sub
        End If
    End Sub

    Public Sub cek_noseq()
        Dim drnoseq As SqlDataReader = New SqlCommand("select max(no_seq)+1 from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & notrans & "'", sqlconn).ExecuteReader
        If drnoseq.Read Then
            noseq = drnoseq.Item(0)
            drnoseq.Close()
        Else
            MsgBox("ada masalah di koneksi")
        End If

    End Sub

    Public Sub cek_data()
        Dim sqlcek As SqlDataReader = New SqlCommand("select no_trans from INV.dbo.INV_GUDANG_OUT where no_trans='" & LookGdgAsal.EditValue & "/" & LookGd7an.EditValue & "/" & dtpTanggal.Text & "'", sqlconn).ExecuteReader
        'Clipboard.SetText("select no_trans from INV.dbo.INV_GUDANG_OUT where no_trans='" & LookGdgAsal.EditValue & "/" & LookGd7an.EditValue & "/" & dtpTanggal.Text & "'")
        sqlcek.Read()

        If sqlcek.HasRows Then
            sqlcek.Close()
            stat_data = "LANJUT"
            'MsgBox(stat_data)
            'insert_lanjut()
        Else
            sqlcek.Close()
            stat_data = "BARU"
            'MsgBox(stat_data)
            'insert_baru()
        End If

    End Sub

    Public Sub insert_lanjut()
        cek_noseq()

        Dim BTRANS As SqlTransaction
        BTRANS = sqlconn.BeginTransaction("1")

        Dim sqlcmd_d As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & noseq & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1)", sqlconn, BTRANS)
        sqlcmd_d.Parameters.AddWithValue("@pjg", rwx.Item("panjang"))
        sqlcmd_d.Parameters.AddWithValue("@lbr", rwx.Item("lebar"))
        sqlcmd_d.Parameters.AddWithValue("@tgi", rwx.Item("tinggi"))
        sqlcmd_d.Parameters.AddWithValue("@qty", txb_qty.Text)

        Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & noseq & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1")
        sqlcmd_d.ExecuteNonQuery()

        'Excute Procedure
        stprc_gudang(kdcabang, bultah, rwx.Item("Kode_Barang").ToString, rwx.Item("kd_ukuran").ToString, rwx("kd_satuan").ToString, LookGdgAsal.EditValue, LookGd7an.EditValue, rwx("tinggi"), rwx("lebar"), rwx("panjang"), txb_qty.Text, BTRANS)

        BTRANS.Commit()
        showMessages("Data Berhasil di Mutasi")
        lbl_sukses.Text = "Data " & rwx.Item("Kode_Barang") & " Berhasil di Mutasi"
        tunda()
        lbl_sukses.Text = ""
    End Sub
    Public Sub insert_baru()
        Dim BTRANS As SqlTransaction
        BTRANS = sqlconn.BeginTransaction("1")

        Dim sqlcmd_h As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT " & _
                                       "(Kd_Cabang,no_trans,tipe_trans,jml_rp_trans,blthn,Last_Create_Date,Last_Created_By,Program_Name) " & _
                                       "values ('" & kdcabang & "','" & notrans & "','JPB-KUT-99',0,'" & bultah & "'," & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "')", sqlconn, BTRANS)
        'Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT " & _
        '                               "(Kd_Cabang,no_trans,tipe_trans,blthn,Last_Create_Date,Last_Created_By,Program_Name) " & _
        '                               "values ('" & kdcabang & "','" & notrans & "','JPB-KUT-99','" & blthn() & "','" & username & "'," & dtpTanggal.EditValue & ",'" & Me.Name & "')")
        sqlcmd_h.ExecuteNonQuery()

        Dim sqlcmd_d As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & rw.Item("no_seq") & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',0)", sqlconn, BTRANS)
        sqlcmd_d.Parameters.AddWithValue("@pjg", rwx.Item("panjang"))
        sqlcmd_d.Parameters.AddWithValue("@lbr", rwx.Item("lebar"))
        sqlcmd_d.Parameters.AddWithValue("@tgi", rwx.Item("tinggi"))
        sqlcmd_d.Parameters.AddWithValue("@qty", txb_qty.Text)

        'Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT_D " & _
        '                               "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
        '                               "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
        '                               "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & rw.Item("no_seq") & ", " & _
        '                               "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("Kd_Satuan") & "'," & rwx.Item("kd_ukuran") & "," & rwx.Item("panjang") & "," & _
        '                               "" & rwx.Item("lebar") & "," & rwx.Item("tinggi") & ", " & _
        '                               "" & txb_qty.Text & ",'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "', " & _
        '                               "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1)")
        sqlcmd_d.ExecuteNonQuery()

        'Excute Procedure
        stprc_gudang(kdcabang, bultah, rwx.Item("Kode_Barang").ToString, rwx.Item("kd_ukuran").ToString, rwx("kd_satuan").ToString, LookGdgAsal.EditValue, LookGd7an.EditValue, rwx("tinggi"), rwx("lebar"), rwx("panjang"), txb_qty.Text, BTRANS)

        BTRANS.Commit()
        showMessages("Data Berhasil di Mutasi")
        lbl_sukses.Text = "Data " & rwx.Item("Kode_Barang") & " Berhasil di Mutasi"
        tunda()
        lbl_sukses.Text = ""
        stat_data = "LANJUT"
    End Sub

    Public Sub delete_lanjut()
        cek_noseq()

        Dim BTRANS As SqlTransaction
        BTRANS = sqlconn.BeginTransaction("1")

        Dim sqlcmd_d As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & noseq & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1)", sqlconn, BTRANS)
        sqlcmd_d.Parameters.AddWithValue("@pjg", rwx.Item("panjang"))
        sqlcmd_d.Parameters.AddWithValue("@lbr", rwx.Item("lebar"))
        sqlcmd_d.Parameters.AddWithValue("@tgi", rwx.Item("tinggi"))
        sqlcmd_d.Parameters.AddWithValue("@qty", txb_qty.Text)

        Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & noseq & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',0")
        sqlcmd_d.ExecuteNonQuery()

        'Excute Procedure
        stprc_gudang(kdcabang, bultah, rwx.Item("Kode_Barang").ToString, rwx.Item("kd_ukuran").ToString, rwx("kd_satuan").ToString, LookGdgAsal.EditValue, LookGd7an.EditValue, rwx("tinggi"), rwx("lebar"), rwx("panjang"), txb_qty.Text, BTRANS)

        BTRANS.Commit()
        showMessages("Data Berhasil di Mutasi")
        lbl_sukses.Text = "Data " & rwx.Item("Kode_Barang") & " Berhasil di Mutasi"
        tunda()
        lbl_sukses.Text = ""
    End Sub

    Public Sub delete_baru()
        Dim BTRANS As SqlTransaction
        BTRANS = sqlconn.BeginTransaction("1")

        Dim sqlcmd_h As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT " & _
                                       "(Kd_Cabang,no_trans,tipe_trans,jml_rp_trans,blthn,Last_Create_Date,Last_Created_By,Program_Name) " & _
                                       "values ('" & kdcabang & "','" & notrans & "','JPB-KUT-99',0,'" & bultah & "'," & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "')", sqlconn, BTRANS)
        'Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT " & _
        '                               "(Kd_Cabang,no_trans,tipe_trans,blthn,Last_Create_Date,Last_Created_By,Program_Name) " & _
        '                               "values ('" & kdcabang & "','" & notrans & "','JPB-KUT-99','" & blthn() & "','" & username & "'," & dtpTanggal.EditValue & ",'" & Me.Name & "')")
        sqlcmd_h.ExecuteNonQuery()

        Dim sqlcmd_d As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT_D " & _
                                       "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
                                       "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
                                       "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & rw.Item("no_seq") & "," & _
                                       "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("kd_ukuran") & "','" & rwx.Item("Kd_Satuan") & "',@pjg,@lbr,@tgi," & _
                                       "@qty,'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "'," & _
                                       "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1)", sqlconn, BTRANS)
        sqlcmd_d.Parameters.AddWithValue("@pjg", rwx.Item("panjang"))
        sqlcmd_d.Parameters.AddWithValue("@lbr", rwx.Item("lebar"))
        sqlcmd_d.Parameters.AddWithValue("@tgi", rwx.Item("tinggi"))
        sqlcmd_d.Parameters.AddWithValue("@qty", txb_qty.Text)

        'Clipboard.SetText("insert into INV.dbo.INV_GUDANG_OUT_D " & _
        '                               "(Kd_Cabang,no_trans,no_ref,tipe_trans,no_seq,kd_stok,kd_ukuran,kd_satuan,panjang,lebar,tinggi, " & _
        '                               "qty_out,gudang_asal,gudang_tujuan,blthn,kd_buku_besar,Last_Create_Date,Last_Created_By,Program_Name,stat) " & _
        '                               "VALUES ('" & kdcabang & "','" & notrans & "','" & notrans & "','JPB-KUT-99', " & rw.Item("no_seq") & ", " & _
        '                               "'" & rwx.Item("Kode_Barang") & "','" & rwx.Item("Kd_Satuan") & "'," & rwx.Item("kd_ukuran") & "," & rwx.Item("panjang") & "," & _
        '                               "" & rwx.Item("lebar") & "," & rwx.Item("tinggi") & ", " & _
        '                               "" & txb_qty.Text & ",'" & LookGdgAsal.EditValue & "','" & LookGd7an.EditValue & "','" & bultah & "', " & _
        '                               "'" & rwx.Item("rek_persediaan") & "', " & dtpTanggal.EditValue & ",'" & username & "','" & Me.Name & "',1)")
        sqlcmd_d.ExecuteNonQuery()

        'Excute Procedure
        stprc_gudang(kdcabang, bultah, rwx.Item("Kode_Barang").ToString, rwx.Item("kd_ukuran").ToString, rwx("kd_satuan").ToString, LookGdgAsal.EditValue, LookGd7an.EditValue, rwx("tinggi"), rwx("lebar"), rwx("panjang"), txb_qty.Text, BTRANS)

        BTRANS.Commit()
        showMessages("Data Berhasil di Mutasi")
        lbl_sukses.Text = "Data " & rwx.Item("Kode_Barang") & " Berhasil di Mutasi"
        tunda()
        lbl_sukses.Text = ""
        stat_data = "LANJUT"
    End Sub


    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bmi").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            row.Item("no_trans") = "tes"
            'row.Item("no_trans") = LookGdgAsal.EditValue+"/"+LookGd7an.EditValue"/"+
            txbNoTrans.Text = row.Item("no_trans")
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bmi").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

        'row.Item("no_trans") = getNoTrans("BMI", getTanggal(BTRANS), BTRANS)
        row.Item("tipe_trans") = "JPB-KUT-99"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvINV_Ret.Columns(6).SummaryItem.SummaryValue
        'row.Item("no_ref") = 
        'row.Item("penyerah") = TxbPenerima.Text
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bmi").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
            If row1.RowState = DataRowState.Added Then
                'row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = "JPB-KUT-99"
                row1.Item("Last_Create_Date") = getTanggal()
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = kdcabang
                row1.Item("no_ref") = txbNoTrans.Text
            Else
                row1.Item("Last_Update_Date") = getTanggal()
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

        Next
        'txbNoTrans.Text = row.Item("no_trans")



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

                For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = row.Item("blthn")
                    End If
                Next
            End If


            DA.Update(dSO.Tables("_bmi"))
            DA2.Update(dSO1.Tables("_bmi_d"))
            'sp1
            For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_out"), BTRANS)
                    'stprc_saldo(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
                End If
            Next

            call_procedure_in(BTRANS)
            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmi_d").AcceptChanges()
            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

End Class