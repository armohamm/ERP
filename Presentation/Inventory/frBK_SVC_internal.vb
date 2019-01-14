'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frBK_SVC_internal
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
        If txbNmTrima.Text = "" Then
            MsgBox("NO SPB,Jenis Kegiatan dan Penerima tidak boleh KOSONG")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        'bersihkan()
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
        'row.Item("no_ref") = LookupSPPB.EditValue
        'row.Item("no_rph") = txbRPH.Text
        'row.Item("jml_rp_trans") = GvBMI_d.Columns(5).SummaryItem.SummaryValue
        'row.Item("kode_gudang") = LookupGudang.EditValue
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
                row.Item("no_trans") = getNoTrans("BK-SVCI", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
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

            'For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
            '    'If row1.RowState = DataRowState.Added Then
            '    Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_sppb_d set qty_sisa=" & row1("qty_sisa").ToString & " where kd_kegiatan='" & txbKeg.Text & "' and no_sppb='" & txbSPPB.Text & "' and kd_barang='" & row1("kd_stok") & "' ", sqlconn, BTRANS)
            '    sqlcmd.ExecuteNonQuery()

            'Next

            '### SP1
            For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_out"), BTRANS)
                End If
            Next

            '### Sp ke 2 saldo
            'For Each row1 As DataRow In dSO1.Tables("_bkid").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        'setor_prosedur2(blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '        setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("rp_trans"), BTRANS)
            '    End If
            'Next


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

    End Sub


    Private Sub frBK_SVC_internal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        LoadStruktur("xxxx")
        GvBMI_d.Columns("rp_trans").Visible = False
        GvBMI_d.Columns("harga").Visible = False


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_gdg1")
        Rep_gdg_asal.DataSource = ds_cari1.Tables("_gdg1")
        Rep_gdg_asal.ValueMember = "Kode_Gudang"
        Rep_gdg_asal.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_gdg2")
        Rep_gdg_tujuan.DataSource = ds_cari2.Tables("_gdg2")
        Rep_gdg_tujuan.ValueMember = "Kode_Gudang"
        Rep_gdg_tujuan.DisplayMember = "Nama_Gudang"
        'LookupGudang.EditValue = "G0001"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select brg.Kode_Barang,brg.Nama_Barang,brg.Kd_Satuan,brg.lokasi,sld.nilai_rata,sld.akhir_qty_onstok from SIF.dbo.SIF_Barang as brg INNER JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where brg.kd_jns_persd in ('2','3') and sld.bultah=(select max(bultah) from INV.dbo.INV_STOK_SALDO)", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupStok.DataSource = ds_cari.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"
    End Sub

    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged

        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds_cari.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")(0)
            GvBMI_d.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
            GvBMI_d.GetRow(e.RowHandle).item("gudang_asal") = rw("lokasi")
            'If kddep = KD_DIV_SPRING Then
            GvBMI_d.GetRow(e.RowHandle).item("gudang_tujuan") = "G0008"
            'ElseIf kddep = KD_DEP_SPON Then
            'GvBMI_d.GetRow(e.RowHandle).item("gudang_tujuan") = "G0005"
            'End If
            'GvBMI_d.GetRow(e.RowHandle).item("harga") = rw("nilai_rata")
            GvBMI_d.GetRow(e.RowHandle).item("akhir_qty_onstok") = rw("akhir_qty_onstok")

        End If
        'If e.Column Is qty_out Then
        '    'Dim rw As DataRow
        '    'rw = ds_cari.Tables("_lookup2").Select("Kode_Barang='" & e.Value & "'")(0)
        '    GvBMI_d.GetRow(e.RowHandle).item("rp_trans") = GvBMI_d.GetRow(e.RowHandle).item("qty_out") * GvBMI_d.GetRow(e.RowHandle).item("harga")
        'End If
    End Sub

    Private Sub GvBMI_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBMI_d.InitNewRow
        GvBMI_d.GetRow(e.RowHandle).item("No_Seq") = GvBMI_d.RowCount + 1
    End Sub
End Class