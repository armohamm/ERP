Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmBomService
    Dim dsete As New DataSet
    Dim daTarif, daBom, daMaster, dabomd As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btncetak As Boolean = False
    Dim ChildCol As DataColumn
    Dim ParentCol As DataColumn
    Dim ChildCol2(1) As DataColumn
    Dim ParentCol2(1) As DataColumn
    Dim myBuilder As SqlClient.SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btncetak
        End With
    End Sub
    Public Sub add_click()
        btnadd = False
        btnSave = True
        setStatus()
    End Sub

    Public Sub cancel_click()
        reload()
    End Sub

    Private Sub frmTarifService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        reload()
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim iserror As Boolean = False

        For Each rows As DataRow In dsete.Tables("BOM").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            End If
        Next

        For Each rows As DataRow In dsete.Tables("BOMD").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            End If

        Next

        Try

            myBuilder = New SqlClient.SqlCommandBuilder(daBom)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            daBom.UpdateCommand = myBuilder.GetUpdateCommand()
            daBom.InsertCommand = myBuilder.GetInsertCommand()
            daBom.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(dabomd)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            dabomd.UpdateCommand = myBuilder.GetUpdateCommand()
            dabomd.InsertCommand = myBuilder.GetInsertCommand()
            dabomd.DeleteCommand = myBuilder.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")

            daBom.UpdateCommand.Transaction = BTRANS
            daBom.InsertCommand.Transaction = BTRANS
            daBom.DeleteCommand.Transaction = BTRANS

            dabomd.UpdateCommand.Transaction = BTRANS
            dabomd.InsertCommand.Transaction = BTRANS
            dabomd.DeleteCommand.Transaction = BTRANS

            daBom.Update(dsete.Tables("BOM"))
            dabomd.Update(dsete.Tables("BOMD"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")

            For Each rw As DataRow In dsete.Tables("BOM").Select("sts<>'0'")
                rw("sts") = "1"
            Next
            For Each rw As DataRow In dsete.Tables("BOMD").Select("sts<>'0'")
                rw("sts") = "1"
            Next
            lblJmlRec.Text = "Row Count : " & GV.RowCount
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub reload()
        If Not dsete.Tables("JENIS") Is Nothing Then dsete.Tables("JENIS").Clear()
        If Not dsete.Tables("TIPE") Is Nothing Then dsete.Tables("TIPE").Clear()
        If Not dsete.Tables("MERK") Is Nothing Then dsete.Tables("MERK").Clear()
        If Not dsete.Tables("TIPE") Is Nothing Then dsete.Tables("TIPE").Clear()
        If Not dsete.Tables("UKURAN") Is Nothing Then dsete.Tables("UKURAN").Clear()
        If Not dsete.Tables("KAIN") Is Nothing Then dsete.Tables("KAIN").Clear()

        ' If Not dsete.Tables("BARANG") Is Nothing Then dsete.Tables("BARANG").Clear()
        If Not dsete.Tables("BAHAN") Is Nothing Then dsete.Tables("BAHAN").Clear()
        If Not dsete.Tables("BOM_SERVICE") Is Nothing Then dsete.Tables("BOM_SERVICE").Clear()
        If Not dsete.Tables("BOMD") Is Nothing Then dsete.Tables("BOMD").Clear()
        If Not dsete.Tables("BOM") Is Nothing Then dsete.Tables("BOM").Clear()
        If Not dsete.Tables("TARIF") Is Nothing Then dsete.Tables("TARIF").Clear()

        daMaster = New SqlDataAdapter("select Kd_Jns_Brg, Nama_Jenis from sif.dbo.sif_jenis_barang where kd_jns_persd=1 union select '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "JENIS")
        repJenis.DataSource = dsete.Tables("JENIS")

        daMaster = New SqlDataAdapter("select Kode_Merk, Nama_Merk from sif.dbo.sif_Merk union select '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "MERK")
        RepMerk.DataSource = dsete.Tables("MERK")

        daMaster = New SqlDataAdapter("select Kode_Tipe, Nama_Tipe from sif.dbo.sif_Tipe union select '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "TIPE")
        repTipe.DataSource = dsete.Tables("TIPE")

        daMaster = New SqlDataAdapter("select Kode_Ukuran, Nama_Ukuran from sif.dbo.sif_Ukuran where isnull(tinggi,0)=0 union select '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "UKURAN")
        repUkuran.DataSource = dsete.Tables("UKURAN")

        daMaster = New SqlDataAdapter("select Nama_Barang, Kode_Barang, Kd_Satuan from sif.dbo.sif_barang where  kd_jns_perSd in ('2','3')", sqlconn)
        daMaster.Fill(dsete, "BAHAN")
        repbahan.DataSource = dsete.Tables("BAHAN")

        daMaster = New SqlDataAdapter(" SELECT [Kode_Kain],[Merk_Kain] FROM [SIF].[dbo].[SIF_Kain] where [Rec_Stat] = 'Y'", sqlconn)
        daMaster.Fill(dsete, "KAIN")
        repKain.DataSource = dsete.Tables("KAIN")

        daMaster = New SqlDataAdapter("select * from sif.dbo.SIF_bom_service", sqlconn)
        daMaster.Fill(dsete, "BOM_SERVICE")
        repjenisService.DataSource = dsete.Tables("BOM_SERVICE")

        daTarif = New SqlDataAdapter("select *,  '0' sts from sif.dbo.SIF_TARIF_SERVICE", sqlconn)
        daTarif.Fill(dsete, "TARIF")

        daBom = New SqlDataAdapter("select *, '0' sts from sif.dbo.SIF_SERVICE_BOM", sqlconn)
        daBom.Fill(dsete, "BOM")

        daBomd = New SqlDataAdapter("select *, '0' sts from sif.dbo.SIF_SERVICE_BOM_D", sqlconn)
        daBomd.Fill(dsete, "BOMD")

        GC.DataSource = dsete.Tables("TARIF")

        If ParentCol Is Nothing Then
            ParentCol = dsete.Tables("TARIF").Columns("nomor")
            ChildCol = dsete.Tables("BOM").Columns("Nomor")
            dsete.Relations.Add("BOM", ParentCol, ChildCol, False)

            ParentCol2(0) = dsete.Tables("BOM").Columns("nomor")
            ParentCol2(1) = dsete.Tables("BOM").Columns("Jenis_Kain")


            ChildCol2(0) = dsete.Tables("BOMD").Columns("Nomor")
            ChildCol2(1) = dsete.Tables("BOMD").Columns("Kd_Kain")
            dsete.Relations.Add("BOMD", ParentCol2, ChildCol2, False)


            GC.LevelTree.Nodes.Add("BOM", GV2).Nodes.Add("BOMD", gv3)
        End If
        lblJmlRec.Text = "Row Count : " & GV.RowCount
    End Sub

    Private Sub GV2_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanging
        If e.Column.Name Is Jenis_Kain.Name Then
            If Not e.Value Is Nothing Then
                Dim kd_stok_old As String
                If Not sender.GetRowCellValue(e.RowHandle, "Jenis_Kain") Is Nothing Then
                    kd_stok_old = sender.GetRowCellValue(e.RowHandle, "Jenis_Kain").ToString()

                    For Each row As Object In dsete.Tables("BOMD").Select("Nomor = " & sender.GetRowCellValue(sender.GetSelectedRows(0), "Nomor") & " and Kd_Kain = '" & kd_stok_old & "'")
                        row("Kd_Kain") = e.Value
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub GV2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV2.RowUpdated
        If e.Row("sts") = "0" Then e.Row("sts") = "2"
    End Sub

    Private Sub gv3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv3.CellValueChanged
        If e.Column.Name = Kd_Barang.Name Then
            If Not e.Value Is Nothing Then
                sender.SetRowCellValue(e.RowHandle, "Satuan", dsete.Tables("Bahan").Select("Kode_Barang='" & e.Value & "'")(0).Item("Kd_Satuan"))
            End If
        End If
    End Sub

    Private Sub GV3_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv3.RowUpdated
        If e.Row("sts") = "0" Then e.Row("sts") = "2"
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "sts", "1")
    End Sub

    Private Sub GV3_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv3.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "sts", "1")
    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV3_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv3.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV2.KeyDown
        If e.KeyCode = Keys.Delete Then
            If sender.GetSelectedRows.Length > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus") = MsgBoxResult.Ok Then
                    For Each row As Object In dsete.Tables("BOMD").Select("Nomor = " & sender.GetRowCellValue(sender.GetSelectedRows(0), "Nomor").ToString & " and Kd_Kain = '" & sender.GetRowCellValue(sender.GetSelectedRows(0), "Jenis_Kain") & "'")
                        row.delete()
                    Next
                    sender.DeleteSelectedRows()
                End If
            End If
        End If
 
    End Sub

    Private Sub GV3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv3.KeyDown
        If e.KeyCode = Keys.Delete Then
            If sender.GetSelectedRows.Length > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus") = MsgBoxResult.Ok Then
                    sender.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        Dim isValid As Boolean = True
        Dim rw() As DataRow = dsete.Tables("BOM").Select("Nomor = '" & e.Row.item("Nomor") & "' and Jenis_Kain = '" & e.Row.item("Jenis_Kain") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                sender.SetColumnError(Jenis_Kain, "Jenis Kain Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub GV3_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv3.ValidateRow
        Dim isValid As Boolean = True

        If e.Row.item("Qty") Is Nothing Then
            isValid = False
            sender.SetColumnError(sender.Columns("Qty"), "Jumlah Barang Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("Qty"), "Jumlah Barang Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Kd_Barang") Is Nothing Then
            isValid = False
            sender.SetColumnError(sender.Columns("Kd_Barang"), "Barang Belum Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("BOMD").Select("Nomor = '" & e.Row.item("Nomor") & "' and Kd_Kain = '" & e.Row.item("Kd_Kain") & "' and Kd_Barang = '" & e.Row.item("Kd_Barang") & "'")

        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                sender.SetColumnError(sender.Columns("Kd_Barang"), "Jenis Kain Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
End Class