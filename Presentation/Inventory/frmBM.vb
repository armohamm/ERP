'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient


Public Class frmBM
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari, ds_asal, ds_7an, ds_vbrg, ds_keypress As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, da_vbrg, DALOOKUP, DA_keypres, da_gd_asal, da_gd_7an As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Public tgl As Date
    Public notrans As String
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
        'If LookupGudang.EditValue = vbNullString Then
        '    MsgBox("Gudang Tujuan belum di Set!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
        '    Exit Sub
        'End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")
        dteTanggal.Enabled = True
        GvBM.OptionsBehavior.ReadOnly = False
        txtcari.Enabled = True
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans NoTrans,tgl_trans Tanggal from INV.DBO.INV_GUDANG_IN where tipe_trans='JBM-KUT-06'", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            STATE = "EDIT"
            tgl = frmCari.row(1)
            LoadStruktur(frmCari.row(0))


            dteTanggal.Enabled = False

            GvBM.OptionsBehavior.ReadOnly = True
            txtcari.Enabled = False
            btnSave = False
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
            
            row = dSO.Tables("_bmi").NewRow

            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bmi").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("tipe_trans") = "JBM-KUT-06"
        row.Item("tgl_trans") = dteTanggal.EditValue
        row.Item("jml_rp_trans") = GvBM.Columns(7).SummaryItem.SummaryValue
        row.Item("penyerah") = TxbPenerima.Text
        row.Item("keterangan") = txtKeterangan.EditValue
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        If STATE = "ADD" Then
            dSO.Tables("_bmi").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
            If row1.RowState = DataRowState.Added Then
                row1.Item("no_trans") = row.Item("no_trans")
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
                row.Item("no_trans") = getNoTrans("BM", getTanggal(BTRANS), BTRANS)

                notrans = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                    
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If


            DA.Update(dSO.Tables("_bmi"))
            DA2.Update(dSO1.Tables("_bmi_d"))
            'sp1
            For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                If STATE = "ADD" Then
                   
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran"), row1("gudang_tujuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_in"), row1("qty_in"), BTRANS)

                    'stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_tujuan").ToString, row1("tinggi"), row1("lebar"), row1("panjang"), row1("qty_in"), row1("qty_in"), BTRANS)
                    'call_procedure("JBM-KUT-06", txbNoTrans.Text, BTRANS)
                End If
            Next

            ' ## sp 2
            For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    stprc_saldo(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("qty_in"), row1("rp_trans"), row1("tinggi"), row1("panjang"), row1("lebar"), BTRANS)
                End If
            Next

            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmi_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            txbNoTrans.Text = notrans
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BMI.rpt", "", "notrans_bmi=" & txbNoTrans.Text)
    End Sub

    Public Sub hapus_record()

    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal kode_gudangx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal qty_inx As Decimal, ByVal qty_lain_inx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = kode_gudangx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@qty_lain_in", SqlDbType.Decimal).Value = qty_lain_inx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal tinggik As Decimal, ByVal panjangk As Decimal, ByVal lebark As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal, 30).Value = tinggik
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal, 30).Value = panjangk
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal, 30).Value = lebark

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

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmi_d")
        GcBM.DataSource = dSO1.Tables("_bmi_d")

        da_vbrg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd<>'4'", sqlconn))
        da_vbrg.Fill(ds_vbrg, "_vbrg")

        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bmi").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            dteTanggal.EditValue = tgl

            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If



    End Sub

    Private Sub TxbBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,isnull(brg.kd_ukuran,0) as kd_ukuran,isnull(brg.panjang,0)as panjang,isnull(brg.lebar,0)as lebar, isnull(brg.tinggi,0)as tinggi,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd in ('1','2','3') and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_bmi_d").Select("kd_stok='" & TxbBarcode.Text & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    'DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & TxbBarcode.Text & "'", sqlconn))
                    'DA_keypres.Fill(ds_keypress, "_keypres")
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_bmi_d").NewRow
                    rw.Item("no_seq") = dSO1.Tables("_bmi_d").Rows.Count
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("nama_barang") = rwx.Item("Nama_Barang")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("tinggi") = rwx.Item("tinggi")
                    rw.Item("lebar") = rwx.Item("lebar")
                    rw.Item("panjang") = rwx.Item("panjang")
                    rw.Item("qty_in") = rwx.Item("qty_in") + 1
                    'rw.Item("gudang_asal") = "G0000"
                    rw.Item("gudang_tujuan") = rwx.Item("lokasi")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_in")
                    dSO1.Tables("_bmi_d").Rows.Add(rw)

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = rw.Item("nama_barang")
                    TxbBarcode.SelectAll()
                    tunda()
                    TxbBarcode.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    TxbBarcode.Focus()
                    Exit Sub
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                        TxbBarcode.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("qty_in") = dtrow(i)("qty_in") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("qty_in") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcBM.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        TxbBarcode.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        TxbBarcode.Focus()
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
                TxbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbBarcode.Focus()
            End If
            TxbBarcode.SelectAll()
        End If
        ds_keypress.Clear()
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1200)
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

    Private Sub GvBM_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBM.CellValueChanged
        If e.Column Is qty_in Then
            GvBM.GetRow(e.RowHandle).item("rp_trans") = GvBM.GetRow(e.RowHandle).item("harga") * GvBM.GetRow(e.RowHandle).item("qty_in")
        End If
    End Sub

    Private Sub GvBM_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBM.InitNewRow
        GvBM.GetRow(e.RowHandle).item("no_seq") = GvBM.RowCount + 1
    End Sub

    Private Sub frmBM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        GvBM.Columns("rp_trans").Visible = False
        GvBM.Columns("harga").Visible = False
        prn = getParent(Me)
        dteTanggal.EditValue = getTanggal()
        'btnhide()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'btnSimpan.Hide()
        'btnExit.Hide()

        LoadStruktur("xxxx")
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RL_Barang.DataSource = ds_cari.Tables("_lookup1")
        RL_Barang.ValueMember = "Kode_Barang"
        RL_Barang.DisplayMember = "Nama_Barang"


        da_gd_asal = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        da_gd_asal.Fill(ds_asal, "_gdg_asal")
        RL_gdg_asal.DataSource = ds_asal.Tables("_gdg_asal")
        RL_gdg_asal.ValueMember = "Kode_Gudang"
        RL_gdg_asal.DisplayMember = "Nama_Gudang"

        da_gd_7an = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        da_gd_7an.Fill(ds_7an, "_gd_7an")
        RL_gdg_tujuan.DataSource = ds_7an.Tables("_gd_7an")
        RL_gdg_tujuan.ValueMember = "Kode_Gudang"
        RL_gdg_tujuan.DisplayMember = "Nama_Gudang"

        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub

    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga,isnull(uk.panjang,0)as panjang,isnull(uk.lebar,0)as lebar, isnull(uk.tinggi,0)as tinggi,0 as qty_in  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang inner join SIF.dbo.SIF_Ukuran as uk on uk.Kode_Ukuran=brg.kd_ukuran where brg.Nama_Barang ='" & txtcari.Text & "' and bultah = CONVERT(varchar(6),GETDATE(),112) ", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_bmi_d").Select("nama_barang='" & txtcari.Text & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_bmi_d").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("nama_barang") = rwx.Item("Nama_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("qty_in") = rwx.Item("qty_in") + 1
                    rw.Item("gudang_asal") = "G0000"
                    rw.Item("gudang_tujuan") = rwx.Item("lokasi")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_in")
                    rw.Item("tinggi") = rwx.Item("tinggi")
                    rw.Item("lebar") = rwx.Item("lebar")
                    rw.Item("panjang") = rwx.Item("panjang")
                    rw.Item("qty_in") = rwx.Item("qty_in") + 1
                    dSO1.Tables("_bmi_d").Rows.Add(rw)

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = rw.Item("nama_barang")
                    txtcari.SelectAll()
                    tunda()
                    txtcari.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
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
                        dtrow(i)("qty_in") = dtrow(i)("qty_in") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("qty_in") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcBM.DataSource).Position = getPosisi(dtrow(i))
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

                'BindingContext(GcBM.DataSource).Position = getPosisi(rw(i))
                tunda()
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txtcari.Focus()

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
End Class