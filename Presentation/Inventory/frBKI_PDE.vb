﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frBKI_PDE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, notrans As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_cari3 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2, DALOOKUP3 As SqlClient.SqlDataAdapter
    Dim x As Object
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
        If LookupGudang.EditValue = vbNullString Or LookupSPPB.EditValue = vbNullString Then
            MsgBox("Tanggal, Gudang, Kode SPPB")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub




    Public Sub cancel_click()
        bersihkan()
    End Sub
    'Public Sub btnstart()
    '    btnTambah.Enabled = True
    '    btnUbah.Enabled = True
    '    btnSimpan.Enabled = False
    '    btnHapus.Enabled = False
    'End Sub

    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where substring((no_trans),8,3)='BKI'", sqlconn)) '
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

    Public Sub simpan()
        Dim BTRANS As SqlTransaction



        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bki").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bki").Rows(0)
            row.Item("Last_Update_Date") = getTanggal() 'Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        'row.Item("no_trans") = getNoTrans("BKI", getTanggal())
        row.Item("tipe_trans") = "JPB-KUT-01"
        row.Item("tgl_trans") = getTanggal()
        row.Item("no_sppb") = LookupSPPB.EditValue
        row.Item("jml_rp_trans") = GvBKI_d.Columns(3).SummaryItem.SummaryValue
        row.Item("kode_gudang") = LookupGudang.EditValue
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bki").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
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
                notrans = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            'txbNoTrans.Text = row.Item("no_trans")

            DA.Update(dSO.Tables("_bki"))
            DA2.Update(dSO1.Tables("_bkid"))

            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                'If row1.RowState = DataRowState.Added Then
                Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_sppb_d set qty_sisa=" & row1("qty_sisa").ToString & " where kd_kegiatan='" & LookupKdKeg.EditValue & "' and no_sppb='" & LookupSPPB.EditValue & "' and kd_barang='" & row1("kd_stok") & "' ", sqlconn, BTRANS)
                sqlcmd.ExecuteNonQuery()

            Next

            '### SP1
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_out"), BTRANS)
                End If
            Next

            '### Sp ke 2
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    'setor_prosedur2(blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("jml_trans"), BTRANS)
                    setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
                End If
            Next


            'dSO.Tables("_bki").AcceptChanges()
            'dSO1.Tables("_bkid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bki").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub setor_prosedur(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kode_gudangx As String, ByVal qty_outx As Integer, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 30).Value = kode_gudangx
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Int).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub setor_prosedur2(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_outx As Integer, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
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


    Public Sub hapus_record()

    End Sub

    Private Sub frBKI_PDE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        connect()

        GvBKI_d.Columns("rp_trans").Visible = False

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup")
        LookupGudang.EditValue = "G0001"

        'DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Id_Data,Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_File='KGTSPK'", sqlconn))
        'DALOOKUP3.Fill(ds_cari3, "_lookup3")
        'LookupKdKeg.Properties.DataSource = ds_cari3.tables("_lookup3")

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        'RepLookupSatuan.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"





        prn = getParent(Me)
        ' btnhide()

        LoadStruktur("xxxx")
    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bki") Is Nothing Then dSO.Tables("_bki").Clear()
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bki")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bkid")
        GcBKI_d.DataSource = dSO1.Tables("_bkid")

        If dSO.Tables("_bki").Rows.Count > 0 Then  'ngisi label header
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_sppb) from INV.dbo.INV_GUDANG_OUT ", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupSPPB.Properties.DataSource = ds_cari.Tables("_lookup1")

            'DA3 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from INV.dbo.INV_GUDANG_IN", sqlconn))
            DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD'", sqlconn))
            DA3.Fill(ds_cari2, "_kdkeg")
            LookupKdKeg.Properties.DataSource = ds_cari2.Tables("_kdkeg")

            Dim rw As DataRow = dSO.Tables("_bki").Rows(0)
            'txbNmTrima.Text = rw("no_nm_terima").ToString
            'txbNoTrans.Text = rw("no_trans").ToString
            LookupGudang.EditValue = rw("kode_gudang").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            LookupSPPB.EditValue = rw("no_sppb").ToString
            LookupKdKeg.EditValue = rw("kd_kegiatan").ToString
        Else
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_sppb) from PROD.DBO.PROD_sppb_d ", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupSPPB.Properties.DataSource = ds_cari.Tables("_lookup1")
        End If
    End Sub

    Private Sub LookupSPPB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSPPB.Click
        If Not dSO1.Tables("_bkid") Is Nothing Then
            dSO1.Clear()
        End If
    End Sub

    Private Sub LookupSPPB_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSPPB.EditValueChanged
        DA3 = New SqlDataAdapter(New SqlCommand("select distinct sppbd.kd_kegiatan,genref.desc_data from PROD.dbo.PROD_sppb_d sppbd  inner join SIF.dbo.SIF_Gen_Reff_D genref on sppbd.kd_kegiatan=genref.Id_Data where  genref.Id_Ref_File='KGTSPK' and genref.Ref_Role='PROD' and sppbd.no_sppb='" & LookupSPPB.EditValue & "'", sqlconn))
        DA3.Fill(ds_cari2, "_kdkeg")
        LookupKdKeg.Properties.DataSource = ds_cari2.Tables("_kdkeg")
    End Sub

    Private Sub LookupKdKeg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupKdKeg.Click
        If Not dSO1.Tables("_bkid") Is Nothing Then
            dSO1.Clear()
        End If
    End Sub


    Private Sub LookupKdKeg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupKdKeg.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("select sppbd.no_sppb,sppbd.kd_kegiatan,sppbd.kd_barang,sppbd.jumlah,sld.nilai_rata,sppbd.qty_sisa,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya,brg.Nama_Barang,0 as qty_out from PROD.dbo.PROD_sppb_d as sppbd inner join SIF.dbo.SIF_Barang as brg on sppbd.kd_barang=brg.Kode_Barang INNER JOIN INV.dbo.INV_STOK_SALDO as sld on sppbd.kd_barang=sld.kd_stok where sppbd.no_sppb='" & LookupSPPB.EditValue & "' and sppbd.kd_kegiatan='" & LookupKdKeg.EditValue & "' and sppbd.qty_sisa <> 0 ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bkid").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bkid").NewRow
                'rw.Item("Kd_Cabang") = kdcabang
                rw.Item("tipe_trans") = "JPU-KUT-01"
                rw.Item("no_seq") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("kd_barang").ToString
                rw.Item("nama_barang") = sqldr.Item("Nama_Barang")
                rw.Item("kd_satuan") = sqldr.Item("Kd_Satuan")       'alangkah baiknya jika di tabelsppb ditambahi unit
                rw.Item("qty_ord") = sqldr.Item("jumlah")
                rw.Item("qty_out") = sqldr.Item("qty_out")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")
                rw.Item("harga") = sqldr.Item("nilai_rata")
                rw.Item("qty_sisa") = sqldr.Item("qty_sisa")

                dSO1.Tables("_bkid").Rows.Add(rw)
            End While
            sqldr.Close()
            GvBKI_d.FocusedColumn = GvBKI_d.VisibleColumns(2)
        End If
    End Sub

    Private Sub txbKdBrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbKdBrg.KeyPress
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim dtrow() As DataRow = dSO1.Tables("_bkid").Select("kd_stok='" & txbKdBrg.Text & "'")
            'lblNmBrg.ForeColor = Color.Yellow
            'lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                Application.DoEvents()
                'lblStatus.Text = "OK"
                'lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                txbKdBrg.SelectAll()
                If dtrow(i)("qty_ord") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                    dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    txbKdBrg.Text = ""
                    'lblNmBrg.Text = ""
                    'lblStatus.Text = ""
                    'txbBarcode.Focus()
                    ''MsgBox("barang ada")
                    ''Exit Sub
                End If
            Next
            'lblNmBrg.ForeColor = Color.Red
            'lblStatus.ForeColor = Color.Red
            If dtrow.Count = 0 Then
                MsgBox("Item tidak ada dalam Daftar", MsgBoxStyle.Information, "Barang KOSONG")
                'lblNmBrg.Text = "Item tidak ada dalam Daftar"
                'lblStatus.Text = "KOSONG"
                tunda()
                txbKdBrg.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                txbKdBrg.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Critical, "STOP..!")
                'lblNmBrg.Text = "Barang sudah terdaftar semua"
                'lblStatus.Text = "STOP!"
            End If
            txbKdBrg.SelectAll()
        End If
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(700)
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
    Public Sub bersihkan()
        txbKdBrg.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        LookupSPPB.EditValue = vbNullString
        LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        save_click()
    End Sub


    Public Sub cetak_click()
        callReport(App_Path() & "\report\BKI.rpt", "", "notrans=" & notrans)
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        cetak_click()
    End Sub
End Class