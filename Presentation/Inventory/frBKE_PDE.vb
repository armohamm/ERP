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

Public Class frBKE_PDE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, notrans As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
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

    'Private Function bulan0(ByVal x As Object)
    '    If Len(bln) = 1 Then
    '        bulan0 = "0" & bln
    '    End If
    '    Return bln
    'End Function


    Public Sub save_click()

        If LookupDPB.EditValue = vbNullString Or LookupGudang.EditValue = vbNullString Then
            MsgBox("Data belum lengkap, lengkapi sebelum menyimpan !", MsgBoxStyle.Information)
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

        'row.Item("no_trans") = getNoTrans("BKE", getTanggal())
        row.Item("tipe_trans") = "JPB-KUT-01"
        row.Item("tgl_trans") = getTanggal()

        row.Item("no_dpb") = LookupDPB.EditValue
        row.Item("kode_gudang") = LookupGudang.EditValue
        row.Item("jml_rp_trans") = GvBKE_d.Columns(3).SummaryItem.SummaryValue
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bke").Rows.Add(row)
        End If
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
                row.Item("no_trans") = getNoTrans("BKE", getTanggal(BTRANS), BTRANS)
                notrans = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            DA.Update(dSO.Tables("_bke"))
            DA2.Update(dSO1.Tables("_bke_d"))

            'update sisa ke table prod_dpb_d dialukukan via triger karena memungkinkan, lain dgn BKI(sppb) dan BME (po)

            '## spc stok saldo gudang out
            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
                    setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_out"), BTRANS)
                End If
            Next
            '## spc on stok gudang saldo
            For Each row1 As DataRow In dSO1.Tables("_bke_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_out"), row1("jml_trans"), BTRANS)
                End If
            Next
            'dSO.Tables("_bke").AcceptChanges()
            'dSO1.Tables("_bke_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()

            showMessages("Berhasil disimpan..!")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges() ' untuk membatalkan row yg diupdate/insert

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

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & notrans)
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bke")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bke_d")
        GcBKE_d.DataSource = dSO1.Tables("_bke_d")

        If dSO.Tables("_bke").Rows.Count > 0 Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_dpb) FROM INV.dbo.INV_GUDANG_OUT", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupDPB.Properties.DataSource = ds_cari.Tables("_lookup1")

            Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
            notrans = rw("no_trans").ToString
            'txbNmTrima.Text = rw("no_dpb").ToString
            LookupDPB.EditValue = rw("no_dpb").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            LookupGudang.EditValue = rw("kode_gudang").ToString

        Else
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_trans) as no_dpb FROM PROD.dbo.PROD_dpb_d where sisa <> 0 ", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupDPB.Properties.DataSource = ds_cari.Tables("_lookup1")

        End If

    End Sub

    Public Sub bersihkan()
        'txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        LookupDPB.EditValue = vbNullString
        LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        save_click()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        cetak_click()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        cancel_click()

    End Sub

    Private Sub txbKdBrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbKdBrg.KeyPress
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim dtrow() As DataRow = dSO1.Tables("_bke_d").Select("kd_stok='" & txbKdBrg.Text & "'")
            'lblNmBrg.ForeColor = Color.Yellow
            lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                Application.DoEvents()
                lblStatus.Text = "OK"
                'lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                txbKdBrg.SelectAll()
                If dtrow(i)("qty_ord") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                    dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                    ok = True
                    BindingContext(GcBKE_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    txbKdBrg.Text = ""
                    'lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    txbKdBrg.Focus()
                    'MsgBox("barang ada")
                    'Exit Sub
                End If
            Next
            'lblNmBrg.ForeColor = Color.Magenta
            lblStatus.ForeColor = Color.Magenta
            If dtrow.Count = 0 Then
                MsgBox("Item tidak ada dalam Daftar", MsgBoxStyle.Information, "Barang KOSONG")
                'lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                txbKdBrg.Text = ""
                'lblNmBrg.Text = ""
                lblStatus.Text = ""
                txbKdBrg.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                'lblNmBrg.Text = "Barang sudah terdaftar semua"
                lblStatus.Text = "STOP!"
                MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Critical, "STOP..!")
            End If
            txbKdBrg.SelectAll()
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

    Private Sub frBKE_PDE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        connect()
        prn = getParent(Me)
        GvBKE_d.Columns("rp_trans").Visible = False

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup")
        LookupGudang.EditValue = "G0001"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        LoadStruktur("xxx")


    End Sub

    Private Sub LookupDPB_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupDPB.EditValueChanged

        If STATE = "ADD" Then
            If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bke_d").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("select dpbd.no_sp,dpbd.no_sp_dtl,dpbd.no_trans,sod.Kd_stok,sod.harga,sod.kd_satuan,dpbd.jumlah,dpbd.sisa,brg.rek_persediaan,brg.rek_biaya,0 as qty_out from PROD.dbo.PROD_dpb_d as dpbd inner join SALES.dbo.SALES_SO_D as sod on dpbd.no_sp = sod.No_sp and dpbd.no_sp_dtl=sod.No_seq inner join SIF.dbo.SIF_Barang as brg on sod.Kd_Stok=brg.Kode_Barang where dpbd.no_trans='" & LookupDPB.EditValue & "' and dpbd.sisa <> 0", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bke_d").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bke_d").NewRow
                rw.Item("Kd_Cabang") = kdcabang
                'rw.Item("no_trans") = "001"
                'rw.Item("tipe_trans") = "JPU-KUT-01"
                rw.Item("no_seq") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("Kd_stok")
                rw.Item("kd_satuan") = sqldr.Item("Kd_satuan")
                rw.Item("qty_ord") = sqldr.Item("jumlah")
                rw.Item("no_sp") = sqldr.Item("no_sp")
                rw.Item("no_sp_dtl") = sqldr.Item("no_sp_dtl")
                rw.Item("qty_sisa") = sqldr.Item("sisa")
                rw.Item("harga") = sqldr.Item("harga")
                rw.Item("qty_out") = sqldr.Item("qty_out")
                'rw.Item("jml_trans") = rw("qty_out") * rw("harga")
                rw.Item("kd_buku_besar") = sqldr.Item("rek_persediaan")
                rw.Item("kd_buku_biaya") = sqldr.Item("rek_biaya")



                dSO1.Tables("_bke_d").Rows.Add(rw)
            End While
            sqldr.Close()
            GvBKE_d.FocusedColumn = GvBKE_d.VisibleColumns(2)
        End If
    End Sub



End Class