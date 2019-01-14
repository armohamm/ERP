'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmInvBMI2
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, dso2, ds_keypress, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2, DA_keypres As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
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
        If TxbPenerima.Text = "" Then
            MsgBox("Harap isi Nama yang meyerahkan Barang!!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
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

        'row.Item("no_trans") = getNoTrans("BMI", getTanggal(BTRANS), BTRANS)
        row.Item("tipe_trans") = "JPP-KUT-02"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvINV_Ret.Columns(6).SummaryItem.SummaryValue
        'row.Item("no_ref") = 
        row.Item("penyerah") = TxbPenerima.Text
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
                row.Item("no_trans") = getNoTrans("BMI", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
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
                    stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran"), row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_in"), BTRANS)
                    'stprc_saldo(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
                End If
            Next

            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmi_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BMI.rpt", "", "notrans_bmi=" & txbNoTrans.Text, False, True)
    End Sub

    Public Sub hapus_record()

    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

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


    Private Sub frmInvBKI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        prn = getParent(Me)
        connect()

        GvINV_Ret.Columns("rp_trans").Visible = False

        btnhide()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'btnSimpan.Hide()
        'btnExit.Hide()

        LoadStruktur("xxxx")

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

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bmi") Is Nothing Then dSO.Tables("_bmi").Clear()
        If Not dSO1.Tables("_bmi_d") Is Nothing Then dSO1.Tables("_bmi_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmi_d")
        GcINV_Ret.DataSource = dSO1.Tables("_bmi_d")



        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bmi").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub

    Private Sub TxbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress

        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim kodebrg1 As String = TxbBarcode.Text
            Dim kd As String = kodebrg1.Substring(0, kodebrg1.Length - 4)

            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & kd & "'", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_bmi_d").Select("kd_stok='" & kd & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,isnull(brg.panjang,0) as panjang,isnull(brg.lebar,0) as lebar,isnull(brg.tinggi,0) as tinggi,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,isnull(stok.nilai_rata,0) as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.lokasi='G0001' and stok.bultah=(select MAX(bultah) from inv.dbo.INV_STOK_SALDO) and brg.Kode_Barang ='" & kd & "'", sqlconn))
                    DA_keypres.Fill(ds_keypress, "_keypres")
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_bmi_d").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("panjang") = rwx.Item("panjang")
                    rw.Item("lebar") = rwx.Item("lebar")
                    rw.Item("tinggi") = rwx.Item("tinggi")
                    rw.Item("qty_in") = rwx.Item("qty_in") + 1
                    rw.Item("gudang_asal") = "G0004"
                    rw.Item("gudang_tujuan") = rwx.Item("lokasi")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_in")
                    dSO1.Tables("_bmi_d").Rows.Add(rw)

                    TxbBarcode.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    TxbBarcode.Focus()
                    Exit Sub
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                        TxbBarcode.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("qty_in") = dtrow(i)("qty_in") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("qty_in") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        BindingContext(GcINV_Ret.DataSource).Position = getPosisi(dtrow(i))
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



    'Public Function nomergen(ByVal bgtrans As SqlTransaction) As String
    '    Dim hasil, temp As String
    '    Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,5,3) as numeric)) from INV.DBO.INV_GUDANG_IN where substring(no_trans,1,3)='BMI'", sqlconn, bgtrans).ExecuteReader
    '    sqlDR.Read()
    '    temp = ""
    '    If TypeOf sqlDR.Item(0) Is DBNull Then
    '        hasil = "BMI/001/" & thn & "/" & bln
    '    Else
    '        hasil = sqlDR.Item(0)
    '        For i As Int16 = Len(hasil) To 2
    '            temp = "0" & temp
    '        Next
    '        hasil = "BMI/" & temp & (hasil + 1) & "/" & thn & "/" & bln
    '    End If
    '    sqlDR.Close()
    '    Return hasil
    'End Function

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        enabel()
        btnHapus.Enabled = True
        btnSimpan.Enabled = True
        STATE = "EDIT"
        'GvBKI_d.Columns("no_seq").Visible = True
        edit_click()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        btnstart()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
        btnstart()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
        btnstart()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Private Sub GvBKI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKI_d.CellValueChanged
    '    If e.Column Is qty_out Then
    '        GvBKI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKI_d.GetRow(e.RowHandle).item("qty_ord").ToString - GvBKI_d.GetRow(e.RowHandle).item("qty_out").ToString
    '    End If
    'End Sub



    Public Sub bersihkan()
        txbNoTrans.Text = ""
        TxbPenerima.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupSPM.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        TxbPenerima.Enabled = True
        'dtpTgl.Enabled = True
        'LookupGudang.Enabled = True
        'LookupSPM.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    'Public Sub disabel()
    '    'txbNoTrans.Enabled = False
    '    'TxbPenerima.Enabled = False
    '    'LookupGudang.Enabled = False
    '    'dtpTgl.Enabled = False
    '    'LookupSPM.Enabled = False
    'End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        bersihkan()
        enabel()
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
        STATE = "ADD"
        GvINV_Ret.Columns("no_seq").Visible = False
    End Sub

    Private Sub btnhide()
        btnTambah.Hide()
        btnUbah.Hide()
        btnSimpan.Hide()
        btnHapus.Hide()
        btnExit.Hide()
        btnBatal.Hide()
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

    Private Sub GvBKI_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvINV_Ret.InitNewRow
        GvINV_Ret.GetRow(e.RowHandle).item("no_seq") = GvINV_Ret.RowCount + 1
    End Sub

End Class