Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormMutasiBrgRusak
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsMutasi As New DataSet
    Dim builderM, builderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim daMutasiM, daMutasiD, daBarang, daSatuan, daGudang, daUkuran As SqlDataAdapter
    Dim drStok As SqlDataReader
    Dim noMutasi As String
    Dim row As DataRow
    Dim cabang() As String
    Dim thnbln() As String
    Dim stok() As String
    Dim satuan() As String
    Dim awal() As String
    Dim akhir() As String
    Dim jml() As Integer

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cancel_click()
        txtNomor.EditValue = vbNullString
        dtpTanggal.EditValue = getTanggal()
        txtKeterangan.EditValue = vbNullString
        If Not dsMutasi.Tables("MutasiD") Is Nothing Then dsMutasi.Tables("MutasiD").Clear()
        gcMutasi.RefreshDataSource()
    End Sub

    Private Sub loadLookUp()
        If Not dsMutasi.Tables("Barang") Is Nothing Then dsMutasi.Tables("Barang").Clear()
        If Not dsMutasi.Tables("Satuan") Is Nothing Then dsMutasi.Tables("Satuan").Clear()
        If Not dsMutasi.Tables("Gudang") Is Nothing Then dsMutasi.Tables("Gudang").Clear()
        If Not dsMutasi.Tables("Ukuran") Is Nothing Then dsMutasi.Tables("Ukuran").Clear()

        daBarang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daBarang.Fill(dsMutasi, "Barang")
        lckBarang.DataSource = dsMutasi.Tables("Barang")
        lckBarang.ValueMember = "Kode_Barang"
        lckBarang.DisplayMember = "Nama_Barang"

        daUkuran = New SqlDataAdapter(New SqlCommand("SELECT Kode_Ukuran, Nama_Ukuran FROM SIF.dbo.SIF_Ukuran", sqlconn))
        daUkuran.Fill(dsMutasi, "Ukuran")
        lckUkuran.DataSource = dsMutasi.Tables("Ukuran")
        lckUkuran.ValueMember = "Kode_Ukuran"
        lckUkuran.DisplayMember = "Nama_Ukuran"

        daSatuan = New SqlDataAdapter(New SqlCommand("SELECT Kode_Satuan, Nama_Satuan FROM SIF.dbo.SIF_Satuan", sqlconn))
        daSatuan.Fill(dsMutasi, "Satuan")
        lckSatuan.DataSource = dsMutasi.Tables("Satuan")
        lckSatuan.ValueMember = "Kode_Satuan"
        lckSatuan.DisplayMember = "Nama_Satuan"

        daGudang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Gudang, Nama_Gudang FROM SIF.dbo.SIF_Gudang", sqlconn))
        daGudang.Fill(dsMutasi, "Gudang")
        lckGudang1.DataSource = dsMutasi.Tables("Gudang")
        lckGudang1.ValueMember = "Kode_Gudang"
        lckGudang1.DisplayMember = "Nama_Gudang"
        lckGudang2.DataSource = dsMutasi.Tables("Gudang")
        lckGudang2.ValueMember = "Kode_Gudang"
        lckGudang2.DisplayMember = "Nama_Gudang"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsMutasi.Tables("Mutasi") Is Nothing Then dsMutasi.Tables("Mutasi").Clear()
        daMutasiM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM INV.dbo.INV_GUDANG_IN WHERE no_trans = '" & kode & "'", sqlconn))
        daMutasiM.Fill(dsMutasi, "MutasiM")
        daMutasiD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM INV.dbo.INV_GUDANG_IN_D WHERE no_trans = '" & kode & "'", sqlconn))
        daMutasiD.Fill(dsMutasi, "MutasiD")
        gcMutasi.DataSource = dsMutasi.Tables("MutasiD")
    End Sub

    Private Sub aFormMutasiBrgRusak_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        loadData("xxx")
        dtpTanggal.EditValue = getTanggal()
    End Sub

    Private Sub refreshNo()
        Dim i As Integer = 1
        If gvMutasi.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvMutasi.RowCount - 1
                gvMutasi.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngka.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub gvMutasi_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMutasi.CellValueChanged
        Dim ok As String = ""

        If e.Column Is kd_stok Then
            drStok = New SqlCommand("SELECT Kd_Satuan, rek_persediaan, kd_ukuran FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & gvMutasi.GetRowCellValue(e.RowHandle, "kd_stok") & "'", sqlconn).ExecuteReader
            While drStok.Read()
                gvMutasi.SetFocusedRowCellValue("kd_satuan", drStok.Item("Kd_Satuan"))
                gvMutasi.SetFocusedRowCellValue("kd_buku_besar", drStok.Item("rek_persediaan"))
                If Not TypeOf drStok.Item("kd_ukuran") Is DBNull Then gvMutasi.SetFocusedRowCellValue("kd_ukuran", drStok.Item("kd_ukuran")) Else gvMutasi.SetFocusedRowCellValue("kd_ukuran", "000")
            End While
            ok = "OK"
            drStok.Close()
        End If

        If ok = "OK" Then
            If Not gvMutasi.GetRowCellValue(e.RowHandle, "kd_ukuran") = "000" Then
                gvMutasi.Columns.Item("kd_ukuran").OptionsColumn.AllowEdit = False
            Else
                gvMutasi.Columns.Item("kd_ukuran").OptionsColumn.AllowEdit = True
            End If
            ok = ""
        End If
    End Sub

    Private Sub gcMutasi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcMutasi.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvMutasi.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus detil mutasi yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    gvMutasi.DeleteSelectedRows()
                    refreshNo()
                End If
            End If
        End If
    End Sub

    Public Sub save_click()
        ReDim cabang(0)
        ReDim thnbln(0)
        ReDim stok(0)
        ReDim satuan(0)
        ReDim awal(0)
        ReDim akhir(0)
        ReDim jml(0)
        If gvMutasi.RowCount <= 0 Then
            MsgBox("Detil mutasi masih belum diisi.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
            Exit Sub
        End If

        If MsgBox("Data akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SIMPAN?") = MsgBoxResult.Yes Then
            Try
                noMutasi = getNoTrans("MTS", getTanggal())
                txtNomor.EditValue = noMutasi
                row = dsMutasi.Tables("MutasiM").NewRow
                row.Item("Kd_Cabang") = getKodeCabang()
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("tipe_trans") = "JBM-KUT-04"
                row.Item("tgl_trans") = dtpTanggal.EditValue
                row.Item("jml_rp_trans") = 0
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("blthn") = Format(dtpTanggal.EditValue, "yyyyMM")
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Program_Name") = Me.Name
                dsMutasi.Tables("MutasiM").Rows.Add(row)

                For Each rows As DataRow In dsMutasi.Tables("MutasiD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("Kd_Cabang") = getKodeCabang()
                        rows.Item("no_trans") = txtNomor.EditValue
                        rows.Item("tipe_trans") = "JBM-KUT-04"
                        rows.Item("qty_in") = 0
                        rows.Item("blthn") = Format(dtpTanggal.EditValue, "yyyyMM")
                        rows.Item("Last_Create_Date") = getTanggal()
                        rows.Item("Last_Created_By") = username
                        rows.Item("Program_Name") = Me.Name
                        cabang(cabang.Length - 1) = rows.Item("Kd_Cabang")
                        thnbln(thnbln.Length - 1) = Format(dtpTanggal.EditValue, "yyyyMM")
                        stok(stok.Length - 1) = rows.Item("kd_stok")
                        satuan(satuan.Length - 1) = rows.Item("kd_satuan")
                        awal(awal.Length - 1) = rows.Item("gudang_asal")
                        akhir(akhir.Length - 1) = rows.Item("gudang_tujuan")
                        jml(jml.Length - 1) = rows.Item("qty_order")
                        ReDim Preserve cabang(cabang.Length)
                        ReDim Preserve thnbln(thnbln.Length)
                        ReDim Preserve stok(stok.Length)
                        ReDim Preserve satuan(satuan.Length)
                        ReDim Preserve awal(awal.Length)
                        ReDim Preserve akhir(akhir.Length)
                        ReDim Preserve jml(jml.Length)
                    End If
                Next

                builderM = New SqlCommandBuilder(daMutasiM)
                daMutasiM.UpdateCommand = builderM.GetUpdateCommand()
                daMutasiM.InsertCommand = builderM.GetInsertCommand()
                daMutasiM.DeleteCommand = builderM.GetDeleteCommand()

                builderD = New SqlCommandBuilder(daMutasiD)
                daMutasiD.UpdateCommand = builderD.GetUpdateCommand()
                daMutasiD.InsertCommand = builderD.GetInsertCommand()
                daMutasiD.DeleteCommand = builderD.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daMutasiM.UpdateCommand.Transaction = BTRANS
                daMutasiM.InsertCommand.Transaction = BTRANS
                daMutasiM.DeleteCommand.Transaction = BTRANS

                daMutasiD.UpdateCommand.Transaction = BTRANS
                daMutasiD.InsertCommand.Transaction = BTRANS
                daMutasiD.DeleteCommand.Transaction = BTRANS

                daMutasiM.Update(dsMutasi.Tables("MutasiM"))
                daMutasiD.Update(dsMutasi.Tables("MutasiD"))

                dsMutasi.Tables("MutasiM").AcceptChanges()
                dsMutasi.Tables("MutasiD").AcceptChanges()

                For i As Integer = 0 To cabang.Length - 2
                    call_procedure(cabang(i), thnbln(i), stok(i), satuan(i), awal(i), akhir(i), jml(i), BTRANS)
                    'MsgBox(cabang(i) & " " & thnbln(i) & " " & stok(i) & " " & satuan(i) & " " & awal(i) & " " & akhir(i) & " " & jml(i))
                Next

                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch ex As Exception
                dsMutasi.Tables("MutasiD").RejectChanges()
                BTRANS.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        End If

    End Sub

    Public Sub call_procedure(ByVal cabang As String, ByVal thnbln As String, ByVal stok As String, ByVal satuan As String, ByVal awal As String, ByVal akhir As String, ByVal qty As Integer, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"

        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.Char).Value = cabang
        sqlCmd.Parameters.Add("@bultah", SqlDbType.Char).Value = thnbln
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.Char).Value = stok
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.Char).Value = satuan
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.Char).Value = awal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.Char).Value = akhir
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Int).Value = qty
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub gvMutasi_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvMutasi.InitNewRow
        gvMutasi.SetFocusedRowCellValue("no_seq", gvMutasi.RowCount + 1)
        daGudang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Gudang, Nama_Gudang FROM SIF.dbo.SIF_Gudang", sqlconn))
        daGudang.Fill(dsMutasi, "GudangCari")
        lckGudang1.DataSource = dsMutasi.Tables("GudangCari")
        lckGudang2.DataSource = dsMutasi.Tables("GudangCari")
        gvMutasi.SetFocusedRowCellValue("gudang_asal", dsMutasi.Tables("GudangCari").Rows(0).Item("Kode_Gudang"))
        gvMutasi.SetFocusedRowCellValue("gudang_tujuan", dsMutasi.Tables("GudangCari").Rows(1).Item("Kode_Gudang"))
    End Sub

    Private Sub gvMutasi_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvMutasi.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvMutasi_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvMutasi.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvMutasi_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvMutasi.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim column3 As GridColumn = view.Columns("kd_stok")
            Dim column4 As GridColumn = view.Columns("qty_order")

            If TypeOf view.GetRowCellValue(e.RowHandle, column3) Is System.DBNull Then
                e.Valid = False
                view.SetColumnError(column3, "Barang belum diisi.")
            End If
            If TypeOf view.GetRowCellValue(e.RowHandle, column4) Is System.DBNull Then
                e.Valid = False
                view.SetColumnError(column4, "Jumlah belum diisi.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvMutasi_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvMutasi.ValidatingEditor
        Dim view As ColumnView = sender
        If view.FocusedColumn.FieldName = "kd_stok" Then
            For i As Integer = 0 To gvMutasi.RowCount
                'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                If e.Value = view.GetRowCellValue(i, kd_stok) Then
                    e.Valid = False
                    e.ErrorText = "Barang sudah ada."
                End If
                If TypeOf view.GetRowCellValue(i, kd_stok) Is System.DBNull Then
                    e.Valid = False
                    e.ErrorText = "Tidak boleh kosong."
                End If
            Next
        End If

        If view.FocusedColumn.FieldName = "gudang_asal" Then
            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
            If Not TypeOf view.GetFocusedRowCellValue("gudang_tujuan") Is System.DBNull Then
                If e.Value = view.GetFocusedRowCellValue("gudang_tujuan") Then
                    e.Valid = False
                    e.ErrorText = "Gudang asal tidak boleh sama dengan gudang tujuan."
                End If
            End If
        End If

        If view.FocusedColumn.FieldName = "gudang_tujuan" Then
            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
            If Not TypeOf view.GetFocusedRowCellValue("gudang_asal") Is System.DBNull Then
                If e.Value = view.GetFocusedRowCellValue("gudang_asal") Then
                    e.Valid = False
                    e.ErrorText = "Gudang tujuan tidak boleh sama dengan gudang asal."
                End If
            End If
        End If
    End Sub

    Private Sub dtpTanggal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTanggal.EditValueChanged
        If dtpTanggal.EditValue <= getTanggal() Then
            dtpTanggal.EditValue = getTanggal()
        End If
    End Sub
End Class