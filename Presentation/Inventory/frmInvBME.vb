'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmInvBME
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public btnCetak As Boolean
    'Private thn As String = getTanggal.Year
    'Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, no_po, sj_sup, p_np, noqc, hapus, spv As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2, ds_gdg2, ds_gdg1 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DA3, DA_gdg2, DA_gdg1, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
    Dim x As Object
    Private BTRAN As SqlTransaction
    Private kdcust As String


    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "HAPUS") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            For Each row As DataRow In dSO.Tables("_bme").Rows
                Dim sqlm As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur ='" & row.Item("no_jurnal") & "'", sqlconn)
                sqlm.ExecuteNonQuery()
                Dim sqld As New SqlCommand("delete from fin.dbo.fin_jurnal_d where no_jur ='" & row.Item("no_jurnal") & "'", sqlconn)
                sqld.ExecuteNonQuery()
                row.Delete()
            Next
            For Each row As DataRow In dSO1.Tables("_bme_d").Rows
                row.Delete()
            Next
            save_click()
        End If
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        bersihkan()
        LoadStruktur("xxxxx")
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnCetak = False
        setStatus()
        'dtpTgl.EditValue = getTanggal()
        'bersihkan()
        enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
        LookupJenisBM.Enabled = True
        LookupJenisBM.Focus()
        LookupQC.Enabled = False
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub save_click()
        If LookupQC.EditValue = vbNullString Or txbNmTrima.Text = "" Then
            MsgBox("Harap isi Nama yang meyerahkan Barang!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        'cetak_click()
        'cancel_click()
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        btnCetak = False
        setStatus()
        Me.Enabled = False
        bersihkan()
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        LookupJenisBM.EditValue = vbNullString
        LookupJenisBM.Enabled = False
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans,no_qc,no_ref,tgl_trans from INV.DBO.INV_GUDANG_IN where substring((no_trans),10,3)='JPP'", sqlconn)) '
        If Not dSO.Tables("lookup_bme") Is Nothing Then dSO.Tables("lookup_bme").Clear()
        DA.Fill(dSO, "lookup_bme")
        frmCari.set_dso(dSO.Tables("lookup_bme")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            load_qc()
            LoadStruktur(frmCari.row(0))


            btnSave = False
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            btnCetak = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        If Not STATE = "DELETE" Then
            'STATE = "ADD"
            If STATE = "ADD" Then
                row = dSO.Tables("_bme").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Last_Updated_By") = username
                row("kd_customer") = kdcust
                row.Item("cetak_ke") = 0
                If p_np = "Y" Then
                    row.Item("no_trans") = getNoTrans("JPPP", getTanggal(BTRANS), BTRANS)
                Else
                    row.Item("no_trans") = getNoTrans("JPPNP", getTanggal(BTRANS), BTRANS)
                End If
                txbNoTrans.Text = row.Item("no_trans")
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_bme").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
                'ElseIf STATE = "CETAK" Then
                'row = dSO.Tables("_bme").Rows(0)
                'row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

            'row.Item("no_trans") = getNoTrans("BME", getTanggal(BTRANS), BTRANS)
            row.Item("no_qc") = noqc
            If STATE = "ADD" Or STATE = "EDIT" Then
                row.Item("tgl_trans") = getTanggal()
                row.Item("no_ref") = no_po
                row.Item("jml_rp_trans") = GvBME_d.Columns(7).SummaryItem.SummaryValue
                row.Item("penyerah") = txbNmTrima.Text
                row.Item("blthn") = blthn()
                row.Item("Program_Name") = Me.Name
                row.Item("sj_supplier") = sj_sup
            End If
            'row.Item("tgl_trans") = getTanggal()
            'row.Item("no_qc") = LookupQC.EditValue
            'row.Item("no_ref") = no_po
            'row.Item("jml_rp_trans") = GvBME_d.Columns(7).SummaryItem.SummaryValue
            'row.Item("penyerah") = txbNmTrima.Text
            'row.Item("blthn") = blthn()
            'row.Item("Program_Name") = Me.Name
            'row.Item("sj_supplier") = sj_sup
            'txbNoTrans.Text = row.Item("no_trans")


            '####Barang Service atau barang dari Pembelian
            'MsgBox(row.Item("no_qc").ToString.Substring(11, 3))
            If STATE = "ADD" Or STATE = "EDIT" Then
                If row.Item(4).ToString.Substring(11, 2) = "QJ" Then
                    row.Item("tipe_trans") = "JPP-KUT-02"
                    'MsgBox(row.Item(4).ToString.Substring(12, 2))
                    'strprc_finbeli_svc(row("no_trans").ToString, BTRANS)
                ElseIf row.Item(4).ToString.Substring(11, 2) = "QC" Then
                    row.Item("tipe_trans") = "JPP-KUT-01"
                    'MsgBox(row.Item(4).ToString.Substring(11, 2))
                    'strprc_finbeli(row("no_trans").ToString, BTRANS)
                ElseIf row.Item(4).ToString.Substring(11, 3) = "RTR" Then
                    row.Item("tipe_trans") = "ReturGudangIn"
                End If
            End If


            If STATE = "ADD" Then
                dSO.Tables("_bme").Rows.Add(row)
            End If
            For Each row1 As DataRow In dSO1.Tables("_bme_d").Rows
                If row1.RowState = DataRowState.Added Then
                    row1.Item("no_trans") = row.Item("no_trans")
                    row1.Item("tipe_trans") = row.Item("tipe_trans")
                    row1.Item("Last_Create_Date") = getTanggal()
                    row1.Item("Last_Created_By") = username
                    row1.Item("kd_Cabang") = kdcabang
                    'Dim sqlrd As SqlDataReader=New SqlCommand("update 
                Else
                    row1.Item("Last_Update_Date") = getTanggal()
                    row1.Item("Last_Updated_By") = username
                End If
                row1.Item("Program_name") = Me.Name
            Next
        End If
        
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

                For Each row1 As DataRow In dSO1.Tables("_bme_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If
            'update sisa di tbl po_d

            DA.Update(dSO.Tables("_bme"))
            DA2.Update(dSO1.Tables("_bme_d"))
            'If STATE = "ADD" Then  '## sudah di update di form qc
            'For Each row1 As DataRow In dSO1.Tables("_bme_d").Rows
            '    'If row1.RowState = DataRowState.Added Then
            '    Dim sqlcmd As New SqlCommand("update PURC.dbo.PURC_PO_D set qty_sisa=" & row1("qty_sisa").ToString & " where no_po='" & LookupQC.EditValue & "' and kd_stok='" & row1("kd_stok") & "'", sqlconn, BTRANS)
            '    sqlcmd.ExecuteNonQuery()
            'Next

            'Update trx_stat  '' <<<< tak perlu karena sudah ada QC_M.status_qc=ENTRY,APPROVED,REJECT
            'For Each row1 As DataRow In dSO1.Tables("_bme_d").Rows




            'update status QCM dan PURC
            If Not STATE = "DELETE" Then
                Dim sqlcmd2 As New SqlCommand("update INV.dbo.INV_QC_M set trx_stat=1 where no_trans='" & LookupQC.EditValue & "'", sqlconn, BTRANS)
                sqlcmd2.ExecuteNonQuery()

                Dim sqlpobyr As New SqlCommand("update PURC.dbo.PURC_PO set tgl_bayar=dateadd(week,isnull(lama_bayar,0),getdate()) where no_po='" & no_po & "'", sqlconn, BTRANS)
                sqlpobyr.ExecuteNonQuery()

                'Next
                If row.Item(4).ToString.Substring(11, 2) = "QJ" Then
                    'Store Prosedudr FIN INS NOTA BELI SERVICE
                    'MsgBox(row.Item(4).ToString.Substring(11, 2))
                    strprc_finbeli_svc(row("no_trans").ToString, BTRANS)
                ElseIf row.Item(4).ToString.Substring(11, 2) = "QC" Then
                    'Store Prosedudr FIN INS NOTA BELI
                    'MsgBox(row.Item(4).ToString.Substring(11, 2))
                    strprc_finbeli(row("no_trans").ToString, BTRANS)
                ElseIf row.Item(4).ToString.Substring(11, 3) = "RTR" Then
                    Dim sqlcmd As New SqlCommand
                    sqlcmd.Connection = sqlconn
                    sqlcmd.Transaction = BTRANS
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"
                    sqlcmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 30)
                    sqlcmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 30)
                    sqlcmd.Parameters("@tipe_trans").Value = "ReturGudangIn"
                    sqlcmd.Parameters("@no_inv").Value = txbNoTrans.Text
                    sqlcmd.ExecuteNonQuery()
                End If

                ' ## Kumpulan str procedur
                For Each row1 As DataRow In dSO1.Tables("_bme_d").Rows
                    If STATE = "ADD" Then
                        Dim sqlcmdpo As New SqlCommand("update PURC.dbo.PURC_PO_D set inv_stat=1 where kd_stok='" & row1("kd_stok") & "' and no_po='" & no_po & "'", sqlconn, BTRANS)
                        sqlcmdpo.ExecuteNonQuery()
                    End If
                Next
            End If

            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            'STATE = "EDIT"
            
            btnadd = True
            btnEdit = True
            btnCancel = False
            btnDelete = False
            btnSave = False
            btnCetak = True
            setStatus()

            LookupQC.Enabled = False
            STATE = ""
            bersihkan()
            LoadStruktur("xxx")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bme").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try
    End Sub

    Public Sub cetak_click()
        'If STATE = "EDIT" Then
        '    STATE = "CETAK"
        '    simpan()
        'End If
        
        callReport(App_Path() & "\report\BME.rpt", "", "notrans=" & txbNoTrans.Text & "&jenisBM=" & LookupJenisBM.Text & "&spv=" & spv, False, True)
        Dim sqcmd As New SqlCommand("update INV.dbo.INV_GUDANG_IN set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txbNoTrans.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()
    End Sub

    Public Sub hapus_record()

    End Sub

    Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal tinggix As Decimal, ByVal lebarx As Decimal, ByVal panjangx As Decimal, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_inx As Integer, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggix
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebarx
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjangx
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
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
    Public Sub strprc_finbeli(ByVal notranx As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_BELI"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 25).Value = notranx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub strprc_stsPO(ByVal no_pox As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PURC.dbo.proses_sts_po"
        sqlCmd.Parameters.Add("@xno_po", SqlDbType.VarChar, 25).Value = no_pox
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub strprc_finbeli_svc(ByVal notransvc As String, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_BELI_SERVICE"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 25).Value = notransvc
        sqlCmd.ExecuteNonQuery()
    End Sub

    'Public Sub stprc_automan(ByVal tipe_transx As String, ByVal no_tranx As String, ByVal BTRAN As SqlTransaction)
    '    Dim sqlCmd As New SqlCommand
    '    sqlCmd.Connection = sqlconn
    '    sqlCmd.Transaction = BTRAN
    '    sqlCmd.CommandType = CommandType.StoredProcedure
    '    sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"
    '    sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 24).Value = tipe_transx
    '    sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 32).Value = no_tranx
    '    'sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
    '    'sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
    '    'sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Int).Value = qty_inx
    '    'sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
    '    sqlCmd.ExecuteNonQuery()
    'End Sub

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
    'Public Function nomergen()
    '    Dim hasil, temp As String
    '    Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,5,3) as numeric)) from INV.DBO.INV_GUDANG_OUT where substring(no_trans,1,3)='BME'", sqlconn).ExecuteReader
    '    sqlDR.Read()
    '    temp = ""
    '    If TypeOf sqlDR.Item(0) Is DBNull Then
    '        hasil = "BME/001/" & thn & "/" & bln
    '    Else
    '        hasil = sqlDR.Item(0)
    '        For i As Int16 = Len(hasil) To 2
    '            temp = "0" & temp
    '        Next
    '        hasil = "BME/" & temp & (hasil + 1) & "/" & thn & "/" & bln
    '    End If
    '    sqlDR.Close()
    '    Return hasil
    'End Function


    Private Sub frmInvBME_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()

        prn = getParent(Me)

        GvBME_d.Columns("harga").Visible = False
        GvBME_d.Columns("rp_trans").Visible = False
        GvBME_d.Columns("gudang_asal").Visible = False

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select id_data kode,desc_data nama_jenis, keterangan from sif.dbo.sif_gen_reff_d where ref_role='INV' and id_ref_file='BRGMASUK'", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_jenisBM")
        'LookupJenisBM.Properties.DataSource = ds_cari1.Tables("_jenisBM")
        'LookupJenisBM.Properties.ValueMember = "kode"
        'LookupJenisBM.Properties.DisplayMember = "nama_jenis"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kode,nama_jenis from INV.dbo.JENIS_BRG_MASUK", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_jenisBM")
        LookupJenisBM.Properties.DataSource = ds_cari1.Tables("_jenisBM")
        LookupJenisBM.Properties.ValueMember = "kode"
        LookupJenisBM.Properties.DisplayMember = "nama_jenis"
        
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

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

        btnhide()

        load_qc()
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(no_trans) as no_qc from INV.dbo.INV_QC_M", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
        'LookupQC.Properties.ValueMember = "no_qc"
        'LookupQC.Properties.DisplayMember = "no_qc"
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnDelete = False
        btnSave = False
        btnCetak = False
        setStatus()
    End Sub

    Public Sub load_qc()
        If STATE = "ADD" Then
            MsgBox("add")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 order by qcm.no_trans", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"

        ElseIf STATE = "EDIT" Then
            'MsgBox("edit")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct(no_qc) from INV.DBO.INV_GUDANG_IN where substring((no_trans),10,3)='JPP'", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"
        End If

    End Sub
    Public Sub v_qc()
        
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 order by qcm.no_trans", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
        LookupQC.Properties.ValueMember = "no_qc"
        LookupQC.Properties.DisplayMember = "no_qc"
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        LookupQC.Properties.ReadOnly = stat
        txbNmTrima.ReadOnly = stat
        txbNoRef.ReadOnly = stat
        txbNoTrans.ReadOnly = stat
    End Sub

    Private Sub format_y2k()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvBME_d.Columns("qty_in").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_in").DisplayFormat.FormatString = "n3"
        GvBME_d.Columns("qty_lain").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("qty_lain").DisplayFormat.FormatString = "n3"
        GvBME_d.Columns("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("harga").DisplayFormat.FormatString = "n2"
        GvBME_d.Columns("rp_trans").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvBME_d.Columns("rp_trans").DisplayFormat.FormatString = "n2"

    End Sub


    Public Sub LoadStruktur(ByVal kodepo As String)
        If Not dSO.Tables("_bme") Is Nothing Then dSO.Tables("_bme").Clear()
        If Not dSO1.Tables("_bme_d") Is Nothing Then dSO1.Tables("_bme_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kodepo & "'", sqlconn))
        DA.Fill(dSO, "_bme")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as qty_qc_unpass,'' as xno_po from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kodepo & "'", sqlconn))
        DA2.Fill(dSO1, "_bme_d")
        GcBME_d.DataSource = dSO1.Tables("_bme_d")


        'LookupPO.Properties.ValueMember = "no_ref"
        'LookupPO.Properties.DisplayMember = "no_ref"

        'ngisi label header
        If dSO.Tables("_bme").Rows.Count > 0 Then
            Dim rwm As DataRow = dSO.Tables("_bme").Rows(0)
            txbNoRef.Text = rwm("no_ref").ToString
            txbNoTrans.Text = rwm("no_trans").ToString
            txbNmTrima.Text = rwm("penyerah").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            noqc = rwm("no_qc").ToString
            'MsgBox(noqc)
            LookupQC.EditValue = noqc
            LookupJenisBM.EditValue = rwm("tipe_trans").ToString
            If InStr(noqc, "QC", CompareMethod.Text) > 0 Then
                LookupJenisBM.EditValue = "QC"
                spv = "SPV Logistik"
            ElseIf InStr(noqc, "QJ", CompareMethod.Text) > 0 Then
                LookupJenisBM.EditValue = "QJ"
                spv = "SPV Logistik"
            ElseIf InStr(noqc, "RT", CompareMethod.Text) > 0 Then
                LookupJenisBM.EditValue = "RT"
                spv = "SPV Finance"
            Else
                LookupJenisBM.EditValue = "SV"
                spv = "SPV Logistik"
            End If
        End If
    End Sub

    'Private Sub GvBKE_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBME_d.CellValueChanged
    '    Dim rw As DataRow = dSO1.Tables("_bme_d").Rows(0)

    '    If e.Column Is qty_in Then
    '        GvBME_d.GetRow(e.RowHandle).item("qty_sisa") = GvBME_d.GetRow(e.RowHandle).item("qty_order").ToString - GvBME_d.GetRow(e.RowHandle).item("qty_in").ToString
    '        'GvBME_d.GetRow(e.RowHandle).item("jml_trans") = GvBME_d.GetRow(e.RowHandle).item("harga").ToString * GvBME_d.GetRow(e.RowHandle).item("qty_in").ToString
    '    End If
    'End Sub

    Private Sub LookupPO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookupQC.EditValueChanged
        If STATE = "ADD" And Not LookupQC.EditValue Is Nothing Then
            noqc = ""
            If Not dSO1.Tables("_bme_d") Is Nothing Then dSO1.Tables("_bme_d").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("select m.no_trans,m.no_ref,m.sj_supplier,m.p_np,d.kd_stok,d.keterangan,d.kd_satuan,d.kd_ukuran,brg.lokasi,isnull(uk.Panjang,0) as panjang,isnull(uk.Lebar,0)as lebar,isnull(uk.Tinggi,0)as tinggi,d.qty_order,isnull(d.qty_qc_pass,0) as qty_qc_pass ,d.qty_qc_unpass,d.qty_sisa,isnull(d.harga,0) as harga,d.rp_trans,d.gudang_asal,d.gudang_tujuan,m.jml_rp_trans,d.kd_buku_besar,d.kd_buku_biaya, isnull(kd_supplier,'') kd_supplier from INV.dbo.INV_QC_M as m INNER JOIN INV.dbo.INV_QC as d on m.no_trans=d.no_trans inner JOIN sif.dbo.SIF_Barang as brg on d.kd_stok=brg.Kode_Barang left join sif.dbo.sif_ukuran uk on brg.kd_ukuran=uk.Kode_Ukuran where d.no_trans='" & LookupQC.EditValue & "' ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bme_d").Clear()

            While sqdr.Read
                kdcust = sqdr.Item("kd_supplier")
                Dim row1 As DataRow = dSO1.Tables("_bme_d").NewRow
                row1.Item("Kd_Cabang") = kdcabang
                'row1.Item("tipe_trans") = sqdr.Item("tipe_trans")
                row1.Item("no_seq") = i : i += 1
                row1.Item("kd_stok") = sqdr.Item("kd_stok")
                row1.Item("keterangan") = sqdr.Item("keterangan")
                row1.Item("kd_satuan") = sqdr.Item("kd_satuan")
                row1.Item("kd_ukuran") = sqdr.Item("kd_ukuran")
                row1.Item("panjang") = sqdr.Item("Panjang")
                row1.Item("lebar") = sqdr.Item("Lebar")
                row1.Item("tinggi") = sqdr.Item("Tinggi")
                row1.Item("xno_po") = sqdr.Item("no_ref")
                row1.Item("no_qc") = sqdr.Item("no_trans")
                'rw.Item("qty_sisa") = sqdr.Item("qty_sisa")
                row1.Item("qty_in") = sqdr.Item("qty_qc_pass")
                row1.Item("harga") = sqdr.Item("harga")
                row1.Item("rp_trans") = sqdr.Item("harga") * row1.Item("qty_in")
                row1.Item("gudang_asal") = sqdr.Item("gudang_asal")
                row1.Item("gudang_tujuan") = sqdr.Item("gudang_tujuan")
                row1.Item("kd_buku_besar") = sqdr.Item("kd_buku_besar")
                row1.Item("kd_buku_biaya") = sqdr.Item("kd_buku_biaya")
                dSO1.Tables("_bme_d").Rows.Add(row1)
                no_po = sqdr.Item("no_ref")
                noqc = sqdr.Item("no_trans")
                sj_sup = sqdr.Item("sj_supplier").ToString
                If Not sqdr.Item("p_np") Is DBNull.Value Then p_np = sqdr.Item("p_np")
            End While
            sqdr.Close()
            GvBME_d.FocusedColumn = GvBME_d.VisibleColumns(4)

            txbNoRef.Text = no_po
        End If
    End Sub

    Private Sub btnhide()
        btnTambah.Hide()
        btnUbah.Hide()
        btnSimpan.Hide()
        btnHapus.Hide()
        btnExit.Hide()
        btnBatal.Hide()
    End Sub

    Public Sub bersihkan()
        txbNoTrans.Text = ""
        txbNoRef.Text = ""
        txbNmTrima.Text = ""
        LookupJenisBM.EditValue = vbNullString
        'dtpTgl.EditValue = vbNullString
        LookupQC.EditValue = vbNullString
        'LookupGudang.EditValue = vbNullString
        dSO1.Clear()
        ds_cari.Clear()
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        txbNoRef.Enabled = True
        'dtpTgl.Enabled = True
        'LookupGudang.Enabled = True
        LookupQC.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Public Sub disabel()
        txbNoTrans.Enabled = False
        txbNoRef.Enabled = False
        'LookupGudang.Enabled = False
        'dtpTgl.Enabled = False
        LookupQC.Enabled = False
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        bersihkan()
        ' enabel()
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
        STATE = "ADD"
        'GvBME_d.Columns("no_seq").Visible = False
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        enabel()
        btnHapus.Enabled = True
        btnSimpan.Enabled = True
        STATE = "EDIT"
        'GvBME_d.Columns("no_seq").Visible = True
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


    'Private Sub LookupQC_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LookupQC.QueryPopUp
    '    ds_cari.Clear()
    '    'ds_cari.Tables("_lookup1").Clear()
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 order by qcm.no_trans", sqlconn))
    '    DALOOKUP.Fill(ds_cari, "_lookup1")
    '    LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
    'End Sub

    Private Sub LookupJenisBM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupJenisBM.EditValueChanged
        If STATE = "EDIT" Then Exit Sub
        If LookupJenisBM.EditValue = "QC" Then
            'MsgBox("Beli")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 and SUBSTRING(qcm.no_trans,12,2)='QC' order by qcm.no_trans", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"
            'msg(ds_cari.Tables("_lookup1").Rows.Count)
            spv = "SPV Logistik"

        ElseIf LookupJenisBM.EditValue = "QJ" Then
            'MsgBox("Jasa")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 and SUBSTRING(qcm.no_trans,12,2)='QJ' order by qcm.no_trans", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"
            'msg(ds_cari.Tables("_lookup1").Rows.Count)
            spv = "SPV Logistik"
        ElseIf LookupJenisBM.EditValue = "RT" Then
            'MsgBox("Retur")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 and SUBSTRING(qcm.no_trans,12,2)='RT' order by qcm.no_trans", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"
            'msg(ds_cari.Tables("_lookup1").Rows.Count)
            spv = "SPV Finance"
        ElseIf LookupJenisBM.EditValue = "SV" Then
            'MsgBox("Retur")
            If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
            DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 and SUBSTRING(qcm.no_trans,12,2)='SV' order by qcm.no_trans", sqlconn))
            DALOOKUP.Fill(ds_cari, "_lookup1")
            LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
            LookupQC.Properties.ValueMember = "no_qc"
            LookupQC.Properties.DisplayMember = "no_qc"
            'msg(ds_cari.Tables("_lookup1").Rows.Count)
            spv = "SPV Logistik"
        End If
        'If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select DISTINCT(qcm.no_trans) as no_qc from INV.dbo.INV_QC qc LEFT JOIN INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qcm.trx_stat=0 and tipe_trans='" & LookupJenisBM.EditValue & "'", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'LookupQC.Properties.DataSource = ds_cari.Tables("_lookup1")
        'LookupQC.Properties.ValueMember = "no_qc"
        'LookupQC.Properties.DisplayMember = "no_qc"
        'spv = LookupJenisBM.GetSelectedDataRow.item("keterangan")
        If Not dSO1.Tables("_bme_d") Is Nothing Then dSO1.Tables("_bme_d").Clear()
        LookupQC.EditValue = vbNullString
        txbNoRef.Text = ""
        LookupQC.Enabled = True
    End Sub
End Class