Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormBarangGudang
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsStok As New DataSet
    Dim daLookUp, daStokGudang, daStokSaldo As SqlDataAdapter
    Dim state, err, stok As String
    Dim bldStokSaldo, bldStokGudang As New SqlCommandBuilder
    Dim isValidSaldo As Boolean = True
    Dim isValidGudang As Boolean = True
    Dim row As DataRow
    Dim BTRANS As SqlTransaction
    Dim isOk As Integer = 0

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsStok.Tables("Barang") Is Nothing Then dsStok.Tables("Barang").Clear()
        If Not dsStok.Tables("Gudang") Is Nothing Then dsStok.Tables("Gudang").Clear()
        If Not dsStok.Tables("Ukuran") Is Nothing Then dsStok.Tables("Ukuran").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daLookUp.Fill(dsStok, "Barang")
        lookStok.DataSource = dsStok.Tables("Barang")
        lookStok.ValueMember = "Kode_Barang"
        lookStok.DisplayMember = "Nama_Barang"
        lookStok2.DataSource = dsStok.Tables("Barang")
        lookStok2.ValueMember = "Kode_Barang"
        lookStok2.DisplayMember = "Nama_Barang"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Gudang, Nama_Gudang FROM SIF.dbo.SIF_Gudang", sqlconn))
        daLookUp.Fill(dsStok, "Gudang")
        lookGudang.DataSource = dsStok.Tables("Gudang")
        lookGudang.ValueMember = "Kode_Gudang"
        lookGudang.DisplayMember = "Nama_Gudang"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Ukuran, Nama_Ukuran FROM SIF.dbo.SIF_Ukuran", sqlconn))
        daLookUp.Fill(dsStok, "Ukuran")
        lookUkuran.DataSource = dsStok.Tables("Ukuran")
        lookUkuran.ValueMember = "Kode_Ukuran"
        lookUkuran.DisplayMember = "Nama_Ukuran"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Satuan, Nama_Satuan FROM SIF.dbo.SIF_Satuan", sqlconn))
        daLookUp.Fill(dsStok, "Satuan")
        lookSatuan.DataSource = dsStok.Tables("Satuan")
        lookSatuan.ValueMember = "Kode_Satuan"
        lookSatuan.DisplayMember = "Nama_Satuan"
    End Sub

    Public Sub delete_click()
        If state = "Saldo" Then
            If MsgBox("Hapus " & stok & " dari Daftar Stok Saldo?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                gvStokSaldo.DeleteSelectedRows()
                save_click(True)
                Exit Sub
            End If
        ElseIf state = "Gudang" Then
            If MsgBox("Hapus Daftar Stok Gudang yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                gvStokGudang.DeleteSelectedRows()
                save_click(True)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub loadData()
        If Not dsStok.Tables("StokSaldo") Is Nothing Then dsStok.Tables("StokSaldo").Clear()
        If Not dsStok.Tables("StokGudang") Is Nothing Then dsStok.Tables("StokGudang").Clear()

        daStokSaldo = New SqlDataAdapter(New SqlCommand("SELECT * FROM INV.dbo.INV_STOK_SALDO WHERE bultah IN (SELECT MAX(bultah) FROM INV.dbo.INV_STOK_SALDO)", sqlconn))
        daStokSaldo.Fill(dsStok, "StokSaldo")
        gcStokSaldo.DataSource = dsStok.Tables("StokSaldo")
        gvStokSaldo.BestFitColumns()

        daStokGudang = New SqlDataAdapter(New SqlCommand("SELECT * FROM INV.dbo.INV_STOK_GUDANG WHERE bultah IN (SELECT MAX(bultah) FROM INV.dbo.INV_STOK_GUDANG)", sqlconn))
        daStokGudang.Fill(dsStok, "StokGudang")
        gcStokGudang.DataSource = dsStok.Tables("StokGudang")
        gvStokGudang.BestFitColumns()
    End Sub

    Private Sub aFormBarangGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        loadData()
        sccBarangGudang.SplitterPosition = pnlFill.Height / 2
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)

        If isDelete Then
            If state = "Saldo" Then
                isValidSaldo = True
                isValidGudang = False
            ElseIf state = "Gudang" Then
                isValidSaldo = False
                isValidGudang = True
            End If
        Else
            For Each row As DataRow In dsStok.Tables("StokSaldo").Rows
                If row.RowState = DataRowState.Modified Then
                    isValidSaldo = True
                    Exit For
                ElseIf row.RowState = DataRowState.Deleted Then
                    isValidSaldo = True
                    Exit For
                Else
                    isValidSaldo = False
                End If
            Next

            For Each row As DataRow In dsStok.Tables("StokGudang").Rows
                If row.RowState = DataRowState.Modified Then
                    isValidGudang = True
                    Exit For
                ElseIf row.RowState = DataRowState.Deleted Then
                    isValidGudang = True
                    Exit For
                Else
                    isValidGudang = False
                End If
            Next
        End If

        If isValidSaldo Then
            For Each rowS As DataRow In dsStok.Tables("StokSaldo").Rows
                If rowS.RowState = DataRowState.Modified Then
                    rowS.Item("Last_Update_Date") = getTanggal()
                    rowS.Item("Last_Updated_By") = umum.username
                End If
            Next

            Try
                bldStokSaldo = New SqlCommandBuilder(daStokSaldo)
                daStokSaldo.UpdateCommand = bldStokSaldo.GetUpdateCommand()
                daStokSaldo.InsertCommand = bldStokSaldo.GetInsertCommand()
                daStokSaldo.DeleteCommand = bldStokSaldo.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daStokSaldo.UpdateCommand.Transaction = BTRANS
                daStokSaldo.InsertCommand.Transaction = BTRANS
                daStokSaldo.DeleteCommand.Transaction = BTRANS

                daStokSaldo.Update(dsStok.Tables("StokSaldo"))

                dsStok.Tables("StokSaldo").AcceptChanges()

                BTRANS.Commit()
                isOk += 1
                loadData()
            Catch ex As Exception
                BTRANS.Rollback()
                dsStok.Tables("StokSaldo").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        Else
            If Not isDelete Then
                MsgBox("Tidak ada data saldo yang diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            End If
        End If

        If isValidGudang Then
            For Each rowG As DataRow In dsStok.Tables("StokGudang").Rows
                If rowG.RowState = DataRowState.Modified Then
                    rowG.Item("Last_Update_Date") = getTanggal()
                    rowG.Item("Last_Updated_By") = umum.username
                End If
            Next

            Try
                bldStokGudang = New SqlCommandBuilder(daStokGudang)
                daStokGudang.UpdateCommand = bldStokGudang.GetUpdateCommand()
                daStokGudang.InsertCommand = bldStokGudang.GetInsertCommand()
                daStokGudang.DeleteCommand = bldStokGudang.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("2")
                daStokGudang.UpdateCommand.Transaction = BTRANS
                daStokGudang.InsertCommand.Transaction = BTRANS
                daStokGudang.DeleteCommand.Transaction = BTRANS

                daStokGudang.Update(dsStok.Tables("StokGudang"))

                dsStok.Tables("StokGudang").AcceptChanges()

                BTRANS.Commit()
                isOk += 1
                loadData()
            Catch ex As Exception
                BTRANS.Rollback()
                dsStok.Tables("StokGudang").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        Else
            If Not isDelete Then
                MsgBox("Tidak ada data gudang yang diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            End If
        End If

        If Not isDelete Then
            If isOk > 0 Then
                showMessages("Berhasil disimpan..")
            End If
        End If
    End Sub

    Public Sub cancel_click()
        loadData()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub gvStokSaldo_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvStokSaldo.CellValueChanged
        If e.Column Is awal_booked Or e.Column Is qty_booked_in Or e.Column Is qty_booked_out Then
            gvStokSaldo.SetRowCellValue(e.RowHandle, "akhir_booked", (gvStokSaldo.GetRowCellValue(e.RowHandle, "awal_booked") + gvStokSaldo.GetRowCellValue(e.RowHandle, "qty_booked_in")) - gvStokSaldo.GetRowCellValue(e.RowHandle, "qty_booked_out"))
        End If
        If e.Column Is awal_qty_onstok Or e.Column Is qty_onstok_in Or e.Column Is qty_onstok_out Then
            gvStokSaldo.SetRowCellValue(e.RowHandle, "akhir_qty_onstok", (gvStokSaldo.GetRowCellValue(e.RowHandle, "awal_qty_onstok") + gvStokSaldo.GetRowCellValue(e.RowHandle, "qty_onstok_in")) - gvStokSaldo.GetRowCellValue(e.RowHandle, "qty_onstok_out"))
        End If
        If e.Column Is akhir_booked Or e.Column Is akhir_qty_onstok Then
            gvStokSaldo.SetRowCellValue(e.RowHandle, "qty_available", gvStokSaldo.GetRowCellValue(e.RowHandle, "akhir_qty_onstok") - gvStokSaldo.GetRowCellValue(e.RowHandle, "akhir_booked"))
        End If
    End Sub

    Private Sub gvStokGudang_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvStokGudang.CellValueChanged
        If e.Column Is awal_qty Or e.Column Is qty_in Or e.Column Is qty_out Then
            gvStokGudang.SetRowCellValue(e.RowHandle, "akhir_qty", (gvStokGudang.GetRowCellValue(e.RowHandle, "awal_qty") + gvStokGudang.GetRowCellValue(e.RowHandle, "qty_in")) - gvStokGudang.GetRowCellValue(e.RowHandle, "qty_out"))
        End If
    End Sub

    Private Sub gvStokSaldo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvStokSaldo.Click
        stok = ""
        stok = gvStokSaldo.GetFocusedRowCellDisplayText(kd_stok)
        state = "Saldo"
    End Sub

    Private Sub gvStokGudang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvStokGudang.Click
        stok = ""
        state = "Gudang"
    End Sub
End Class