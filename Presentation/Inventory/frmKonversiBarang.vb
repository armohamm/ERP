Imports System.Data.SqlClient
Public Class frmKonversiBarang
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public dtable As DataTable
    Dim dSO As New DataSet
    Dim DAMaster, DA As SqlClient.SqlDataAdapter
    Dim pengali As Double

    Private Sub frmKonversiBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DAMaster = New SqlDataAdapter("select Kode_Barang, Nama_Barang, Kd_Satuan, kd_ukuran, u.Tinggi, u.Lebar, u.Panjang from sif.dbo.sif_barang b, sif.dbo.sif_ukuran u where kode_ukuran=kd_ukuran and kd_jns_persd in ('1','2','3') and b.rec_stat='Y' order by Nama_Barang", sqlconn)
        DAMaster.Fill(dSO, "BARANG")
        DAMaster = New SqlDataAdapter("select Kode_Gudang, Nama_Gudang from sif.dbo.sif_gudang where rec_stat='Y'", sqlconn)
        DAMaster.Fill(dSO, "GUDANG")
        DA = New SqlDataAdapter("select * from inv.dbo.inv_konversi_barang where 1=0", sqlconn)
        DA.Fill(dSO, "KONVERSI")
        cmdBarangAsal.Properties.DataSource = dSO.Tables("Barang")
        For Each col As Object In cmdBarangAsal.Properties.View.Columns
            col.Visible = False
        Next
        cmdBarangAsal.Properties.View.Columns(1).Visible = True

        cmdBarangTujuan.Properties.DataSource = dSO.Tables("Barang")
        For Each col As Object In cmdBarangTujuan.Properties.View.Columns
            col.Visible = False
        Next
        cmdBarangTujuan.Properties.View.Columns(1).Visible = True

        cmdGudang.Properties.DataSource = dSO.Tables("GUDANG")
        cmdGudang.Properties.View.Columns(0).Visible = False

        keGudang.Properties.DataSource = dSO.Tables("GUDANG")
        keGudang.Properties.View.Columns(0).Visible = False

        dtpTanggal.EditValue = getTanggal()
        prn = frmMain
        setstatus()
    End Sub
    Public Sub add_click()
        btnadd = False
        btnCancel = True
        btnSave = True
        setstatus()
    End Sub
    Sub setstatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
        End With
    End Sub
    Sub carisaldo(ByVal saldo As Object, ByVal hpp As Object, ByVal kdbarang As String)
        saldo.Text = 0
        hpp.Text = 0
        Dim bultah1 As String = Format(dtpTanggal.EditValue, "yyyyMM")
        Dim dr As SqlDataReader = New SqlCommand("select sum(isnull(akhir_qty,0)) akhir_qty, count(1) jml from inv.dbo.inv_stok_gudang where bultah = '" & bultah1 & "' and kode_gudang = '" & cmdGudang.EditValue & "' and kd_stok = '" & kdbarang & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If Not TypeOf dr.Item(0) Is System.DBNull Then
                saldo.Text = dr.Item(0)
            Else
                saldo.Text = 0
            End If
        End If
        dr.Close()
        dr = New SqlCommand("select nilai_rata from inv.dbo.inv_stok_saldo where bultah = '" & bultah1 & "' and kd_stok = '" & kdbarang & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If Not TypeOf dr.Item(0) Is System.DBNull Then
                hpp.Text = dr.Item(0)
            Else
                hpp.Text = 0
            End If
        End If
        dr.Close()
    End Sub

    Private Sub cmdGudang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGudang.EditValueChanged
        If cmdGudang.EditValue = "" Then Exit Sub
        If keGudang.EditValue = "" Then keGudang.EditValue = cmdGudang.EditValue
        carisaldo(txtSaldo, txtHpp, cmdBarangAsal.EditValue)
        carisaldo(txtsaldo2, txtHpp2, cmdBarangTujuan.EditValue)
    End Sub

    Private Sub cmdBarangAsal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarangAsal.EditValueChanged
        If cmdBarangAsal.EditValue <> "" Then
            carisaldo(txtSaldo, txtHpp, cmdBarangAsal.EditValue)
            txtSatuan.Text = cmdBarangAsal.GetSelectedDataRow.item("Kd_Satuan")
            txtQty.Text = 0
            With New SqlCommand("select top 1 kd_barang_tujuan from inv.dbo.inv_konversi_barang where kd_barang_asal='" & cmdBarangAsal.EditValue & "' order by no_trans asc", sqlconn).ExecuteReader
                Try
                    .Read()
                    If .HasRows Then
                        cmdBarangTujuan.EditValue = .Item(0)
                    End If
                    .Close()
                Catch ex As Exception
                    .Close()
                End Try
                If Not .IsClosed Then .Close()
            End With
            cari_konversi()
        Else
            txtSatuan.Text = vbNullString
            txtHpp.Text = 0
            txtQty.Text = 0
        End If
    End Sub
    Private Sub cmdBarangTujuan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarangTujuan.EditValueChanged
        If cmdBarangTujuan.EditValue <> "" Then
            carisaldo(txtsaldo2, txtHpp2, cmdBarangTujuan.EditValue)
            txtSatuan2.Text = cmdBarangTujuan.GetSelectedDataRow.item("Kd_Satuan")
            txtQtyHasil.Text = 0
            cari_konversi()
        Else
            txtSatuan2.Text = vbNullString
            txtHpp2.Text = 0
            txtQtyHasil.Text = 0
        End If
    End Sub
    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Dim Buildernya As New SqlClient.SqlCommandBuilder
        Dim row As DataRow

        If cmdGudang.Text = "" Then
            MsgBox("Harap Mengisi Kolom Gudang Asal", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            cmdGudang.Focus()
            Exit Sub
        End If
        If cmdBarangAsal.Text = "" Then
            MsgBox("Harap Mengisi Kolom Barang Asal", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            cmdBarangAsal.Focus()
            Exit Sub
        End If
        If txtQty.Text = "" Or Val(txtQty.Text) <= 0 Then
            MsgBox("Harap Mengisi Kolom Jumlah Diperlukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            txtQty.Focus()
            Exit Sub
        End If
        If txtSaldo.EditValue < Val(txtQty.Text) Then
            MsgBox("Stok Barang Kurang", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            txtSaldo.Focus()
            Exit Sub
        End If
        If cmdBarangTujuan.Text = "" Then
            MsgBox("Harap Mengisi Kolom Barang Tujuan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            cmdBarangTujuan.Focus()
            Exit Sub
        End If
        If txtQtyHasil.Text = "" Or Val(txtQtyHasil.Text) <= 0 Then
            MsgBox("Harap Mengisi Kolom Jumlah Hasil", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
            txtQtyHasil.Focus()
            Exit Sub
        End If
        Buildernya = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Buildernya.GetUpdateCommand()
        DA.InsertCommand = Buildernya.GetInsertCommand()
        DA.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        txtNomor.Text = getNoTrans("TRANF", getTanggal(BTRANS), BTRANS)
        row = dSO.Tables("KONVERSI").NewRow

        row.Item("kd_cabang") = kdcabang
        row.Item("no_trans") = txtNomor.Text
        row.Item("kd_barang_asal") = cmdBarangAsal.EditValue
        row.Item("kd_satuan_asal") = txtSatuan.EditValue
        row.Item("jumlah_asal") = txtQty.EditValue
        row.Item("nilai_asal") = txtHpp.EditValue
        row.Item("kd_barang_tujuan") = cmdBarangTujuan.EditValue
        row.Item("kd_satuan_tujuan") = txtSatuan2.EditValue
        row.Item("jumlah_tujuan") = txtQtyHasil.EditValue
        row.Item("nilai_tujuan") = txtHpp.EditValue
        row.Item("rec_stat") = "Y"
        row.Item("last_create_date") = dtpTanggal.EditValue
        row.Item("last_created_by") = username
        row.Item("program_name") = Me.Name
        dSO.Tables("KONVERSI").Rows.Add(row)
        Try

            DA.Update(dSO.Tables("KONVERSI"))
            dSO.Tables("KONVERSI").AcceptChanges()

            stprc_gudang_in(kdcabang, Format(dtpTanggal.EditValue, "yyyyMM"), cmdBarangTujuan.EditValue, txtSatuan2.Text, "0", "", keGudang.EditValue, txtQtyHasil.EditValue, BTRANS)
            stprc_saldo_in(kdcabang, Format(dtpTanggal.EditValue, "yyyyMM"), cmdBarangTujuan.EditValue, txtSatuan2.Text, "0", txtQtyHasil.Text, txtHpp.EditValue * txtQtyHasil.EditValue, BTRANS)

            stprc_gdout(kdcabang, Format(dtpTanggal.EditValue, "yyyyMM"), cmdBarangAsal.EditValue, txtSatuan.Text, 0, cmdGudang.EditValue, "XXXXX", txtQty.EditValue, BTRANS)
            stprc_saldo(kdcabang, Format(dtpTanggal.EditValue, "yyyyMM"), cmdBarangAsal.EditValue, txtSatuan.Text, 0, txtQty.Text, txtQty.EditValue * txtHpp.EditValue, BTRANS)

            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            btnSave = False
            setstatus()
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dSO.Tables("KONVERSI").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub cancel_click()
        txtHpp.Text = ""
        txtNomor.Text = ""
        txtQty.EditValue = 0
        txtQtyHasil.EditValue = 0
        txtSaldo.EditValue = 0
        txtsaldo2.EditValue = 0
        txtSatuan.Text = ""
        txtSatuan2.Text = ""
        cmdBarangAsal.EditValue = vbNullString
        cmdBarangTujuan.EditValue = vbNullString
        cmdGudang.EditValue = vbNullString
        btnadd = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = False

        setstatus()
    End Sub
    Public Sub stprc_gudang_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_inx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = cmdBarangTujuan.GetSelectedDataRow.item("kd_ukuran")
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Tinggi")
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Lebar")
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Panjang")
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@qty_lain_in", SqlDbType.Decimal).Value = 0
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = cmdBarangTujuan.GetSelectedDataRow.item("kd_ukuran")
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Tinggi")
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Lebar")
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = cmdBarangTujuan.GetSelectedDataRow.item("Panjang")
        sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
    End Sub
    Public Sub stprc_gdout(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = cmdBarangAsal.GetSelectedDataRow.item("kd_ukuran")
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Tinggi")
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Lebar")
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Panjang")
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.Parameters.Add("@qty_lain_out", SqlDbType.Decimal).Value = 0
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = cmdBarangAsal.GetSelectedDataRow.item("kd_ukuran")
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Tinggi")
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Lebar")
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = cmdBarangAsal.GetSelectedDataRow.item("Panjang")
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
    End Sub
    Sub cari_konversi()
        If cmdBarangAsal.EditValue = "" Then Exit Sub
        If cmdBarangTujuan.EditValue = "" Then Exit Sub
        If txtQty.EditValue = "" Then Exit Sub
        If txtQty.EditValue < 0 Then Exit Sub
        pengali = 0
        With New SqlCommand("select top 1 jumlah_tujuan/jumlah_asal pengali from inv.dbo.inv_konversi_barang where kd_barang_tujuan='" & cmdBarangTujuan.EditValue & "' and kd_barang_asal='" & cmdBarangAsal.EditValue & "' order by no_trans asc", sqlconn).ExecuteReader
            Try
                .Read()
                If .HasRows Then
                    txtQtyHasil.EditValue = txtQty.EditValue * .Item(0)
                    pengali = .Item(0)
                End If
                .Close()
            Catch ex As Exception
                .Close()
            End Try
            If Not .IsClosed Then .Close()
        End With
    End Sub

    Private Sub txtQty_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.EditValueChanged
        If pengali = 0 Then Exit Sub
        txtQtyHasil.EditValue = txtQty.EditValue * pengali
    End Sub
End Class