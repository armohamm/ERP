'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmINV_SJ
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public STATE, temp_po, p_np As String
    Private dSO, ds1, ds2 As New DataSet
    Private DA, DA1, DA_gdo, DA_gdod As SqlClient.SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw As DataRow

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
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
        simpan()
        frmINV_SJ_Load(Me, Nothing)
    End Sub

    Public Sub update_batal(ByVal no_kirim As String, ByVal BTRANX As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANX
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_upd_krm_batal"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100).Value = no_kirim
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        

        'BTRANS = sqlconn.BeginTransaction("1")
        Try
            '    Buildernya = New SqlClient.SqlCommandBuilder(DA)
            '    DA.UpdateCommand = Buildernya.GetUpdateCommand()
            '    DA.InsertCommand = Buildernya.GetInsertCommand()
            '    DA.DeleteCommand = Buildernya.GetDeleteCommand()

            '    Buildernya = New SqlClient.SqlCommandBuilder(DA1)
            '    DA1.UpdateCommand = Buildernya.GetUpdateCommand()
            '    DA1.InsertCommand = Buildernya.GetInsertCommand()
            '    DA1.DeleteCommand = Buildernya.GetDeleteCommand()

            '    BTRANS = sqlconn.BeginTransaction("1")
            '    DA.UpdateCommand.Transaction = BTRANS
            '    DA.InsertCommand.Transaction = BTRANS
            '    DA.DeleteCommand.Transaction = BTRANS

            '    DA1.UpdateCommand.Transaction = BTRANS
            '    DA1.InsertCommand.Transaction = BTRANS
            '    DA1.DeleteCommand.Transaction = BTRANS
            BTRANS = sqlconn.BeginTransaction("1")

            'For Each row In dSO.Tables("_bke").Rows
            For i As Integer = 0 To dSO.Tables("_bke").Rows.Count - 1
                If dSO.Tables("_bke").Rows(i).Item("sudah_sj") = True Then
                    'MsgBox(dSO.Tables("_bke").Rows(i).Item("no_trans").ToString)

                    'UPDATE NOPOL dan SOPIR
                    ' Dim sqlcomx As New SqlCommand("update INV.dbo.INV_BKE_D set no_pol ='" & dSO.Tables("_bke").Rows(i).Item("no_pol").ToString & "', sopor='" & dSO.Tables("_bke").Rows(i).Item("sopir").ToString & "'  where no_trans = '" & dSO.Tables("_bke").Rows(i).Item("no_trans").ToString & "'", sqlconn, BTRANS)
                    'sqlcomx.ExecuteNonQuery()

                    '##UPDATE SIAP SJ
                    Dim sqlcom As New SqlCommand("update INV.dbo.INV_BKE set sudah_sj = 1 where no_trans = '" & dSO.Tables("_bke").Rows(i).Item("no_trans").ToString & "'", sqlconn, BTRANS)
                    sqlcom.ExecuteNonQuery()

                    Dim sqlcom1 As New SqlCommand("update INV.dbo.INV_BKE_D set siap_sj = 1 where no_trans = '" & dSO.Tables("_bke").Rows(i).Item("no_trans").ToString & "'", sqlconn, BTRANS)
                    sqlcom1.ExecuteNonQuery()

                    '##COPY PASTE HEADER BKE KE GUDANG_OUT
                    Dim sqlinsertgdo As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT select * from INV.dbo.INV_BKE where no_trans='" & dSO.Tables("_bke").Rows(i).Item("no_trans").ToString & "'", sqlconn, BTRANS)
                    sqlinsertgdo.ExecuteNonQuery()

                    '##COPY PASTE DR BKE_D KE GUDANG_OUT_D
                    Dim sqlinsertgdod As New SqlCommand("insert into INV.dbo.INV_GUDANG_OUT_D select * from INV.dbo.INV_BKE_D where no_trans='" & dSO.Tables("_bke").Rows(i).Item("no_trans").ToString & "'", sqlconn, BTRANS)
                    sqlinsertgdod.ExecuteNonQuery()

                    '##update inv_stat DI TABEL PRODUKSI
                    Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_dpb_m set inv_stat = 1 where PROD.dbo.PROD_dpb_m.no_trans_krm = '" & dSO.Tables("_bke").Rows(i).Item("no_ref").ToString & "'", sqlconn, BTRANS)
                    sqlcmd.ExecuteNonQuery()

                    Dim sqlcmdr As New SqlCommand("update PROD.dbo.PROD_rcn_krm_m set rec_stat = 'T' where PROD.dbo.PROD_rcn_krm_m.no_trans = '" & dSO.Tables("_bke").Rows(i).Item("no_ref").ToString & "'", sqlconn, BTRANS)
                    sqlcmdr.ExecuteNonQuery()

                    update_batal(dSO.Tables("_bke").Rows(i).Item("no_ref").ToString, BTRANS)

                    'update PROD.dbo.PROD_rcn_krm_m set rec_stat = 'S' where PROD.dbo.PROD_rcn_krm_m.no_trans = '
                    'stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran").ToString, row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_out"), BTRANS)
                    'stprc_bookedOut(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("qty_out"), BTRANS)
                    'Next
                End If
            Next


            'If STATE = "ADD" Then
            '    'row.Item("no_trans") = getNoTrans("KRM_T", getTanggal(BTRANS), BTRANS)
            '    'txbNoTrans.Text = row.Item("no_trans")
            '    For Each row1 As DataRow In ds1.Tables("_bke_d").Rows
            '        If row1.RowState = DataRowState.Added Then
            '            row1.Item("no_trans") = row.Item("no_trans")
            '            row1.Item("blthn") = blthn(BTRANS)
            '        End If
            '    Next
            'End If
            'DA.Update(dSO.Tables("_bke"))
            'DA1.Update(ds1.Tables("_bke_d"))

            ''UPDATE status di prod.dpb_m status 1 supaya yg sudah terkirim tak muncul lagi
            'For Each row As DataRow In dSO.Tables("_bke").Rows
            '    If RepCekSJ.ValueChecked = True Then
            '        Dim sqlcmd As New SqlCommand("update PROD.dbo.PROD_dpb_m set inv_stat = 1 where PROD.dbo.PROD_dpb_m.no_trans_krm = '" & row.Item("no_ref").ToString & "'", sqlconn, BTRANS)
            '        sqlcmd.ExecuteNonQuery()
            '    End If

            'Next

            ''## spc stok saldo gudang out
            'For Each row1 As DataRow In ds1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "SET", "G001", 2, BTRANS)
            '        stprc_gudang(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_ukuran").ToString, row1("kd_satuan").ToString, row1("gudang_asal").ToString, row1("gudang_tujuan").ToString, row1("qty_out"), BTRANS)

            '    End If
            'Next
            ' ''## spc BOOKED OUT
            'For Each row1 As DataRow In ds1.Tables("_bke_d").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        stprc_bookedOut(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("kd_ukuran").ToString, row1("qty_out"), BTRANS)
            '    End If
            'Next
            ''dSO.Tables("_bke").AcceptChanges()
            ''dSO1.Tables("_bke_d").AcceptChanges()
            BTRANS.Commit()

            showMessages("Berhasil disimpan..!")
            STATE = "EDIT"
            frmMain.btnSave.Enabled = False
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bke").RejectChanges() ' untuk membatalkan row yg diupdate/insert

            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
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

    Private Sub frmINV_SJ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        
        LoadStruktur()
        frmMain.btnCetak.Enabled = False
    End Sub

    Private Sub LoadStruktur()

        If Not dSO.Tables("_bke") Is Nothing Then dSO.Tables("_bke").Clear()
        If Not ds1.Tables("_bke_d") Is Nothing Then ds1.Tables("_bke_d").Clear()

        DA = New SqlDataAdapter(New SqlCommand("SELECT *,0 as nomer from INV.dbo.INV_BKE where sudah_sj=0", sqlconn)) ' where status <> 'APPROVE'
        DA.Fill(dSO, "_bke")
        DA = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_BKE_D where no_trans in (SELECT no_trans as nomer from INV.dbo.INV_BKE where sudah_sj=0)", sqlconn)) ' where status <> 'APPROVE'
        DA.Fill(ds1, "_bke_d")
        GcSiapSJ.DataSource = dSO.Tables("_bke")

        'DA_gdo = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_OUT where no_trans='" & kode & "'", sqlconn))
        'DA_gdo.Fill(dSO, "_gdo")
        'DA_gdod = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as sisa from INV.dbo.INV_GUDANG_OUT_D where no_trans='" & kode & "'", sqlconn))
        'DA_gdod.Fill(ds1, "_gdod")
        'GcSiapSJ.DataSource = ds1.Tables("_bke_d")

        'If dSO.Tables("_bke").Rows.Count > 0 Then
        '    DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_ref) FROM INV.dbo.INV_GUDANG_OUT", sqlconn))
        '    DALOOKUP.Fill(ds_cari, "_lookup1")
        '    CBeditKirim.Properties.DataSource = ds_cari.Tables("_lookup1")

        '    Dim rw As DataRow = dSO.Tables("_bke").Rows(0)
        '    txbNoTrans.Text = rw("no_trans").ToString
        '    txbNmTrima.Text = rw("no_dpb").ToString
        '    CBeditKirim.EditValue = rw("no_dpb").ToString
        '    'dtpTgl.EditValue = rw("tgl_trans").ToString
        '    'LookupGudang.EditValue = rw("kode_gudang").ToString

        'End If
        isinomer()
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_bke").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub
    'STORE PROSEDUR GUDANG DAN BOOKEDOUT ADA DI TRIGGER GUDANG_OUT_D
    'Public Sub stprc_gudang(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_ukuranx As String, ByVal satuanx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)
    '    Dim sqlCmd As New SqlCommand
    '    sqlCmd.Connection = sqlconn
    '    sqlCmd.Transaction = BTRANS
    '    sqlCmd.CommandType = CommandType.StoredProcedure
    '    sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
    '    sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
    '    sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
    '    sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
    '    sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
    '    sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
    '    sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
    '    sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
    '    sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal, 30).Value = qty_outx
    '    sqlCmd.ExecuteNonQuery()
    'End Sub

    'Public Sub stprc_bookedOut(ByVal kd_cabangx As String, ByVal bultahx As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal booked_outx As Decimal, ByVal BTRANX As SqlTransaction)
    '    Dim sqlCmd As New SqlCommand
    '    sqlCmd.Connection = sqlconn
    '    sqlCmd.Transaction = BTRANX
    '    sqlCmd.CommandType = CommandType.StoredProcedure
    '    sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_booked_out"
    '    sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
    '    sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultahx
    '    sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
    '    sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = kd_satuanx
    '    sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
    '    sqlCmd.Parameters.Add("@booked_out", SqlDbType.Decimal, 32).Value = booked_outx
    '    sqlCmd.ExecuteNonQuery()
    'End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
    End Sub
End Class