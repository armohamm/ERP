
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmTarifService
    Dim dsete As New DataSet
    Dim DATarif, DABOM As SqlDataAdapter
    Dim DAMaster As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Public clone As DataView
    Dim myBuilder As New SqlCommandBuilder
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
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Public Sub add_click()

    End Sub


    Private Sub frmTarifService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran, Nama_Ukuran from SIF.dbo.SIF_Ukuran where rec_stat='Y' and isnull(tinggi,0) = 0 and (isnull(lebar,0) > 0 or isnull(panjang,0) > 0 ) ", sqlconn))
        DAMaster.Fill(dsete, "UKURAN")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk, Nama_Merk from SIF.dbo.SIF_Merk where rec_stat='Y'", sqlconn))
        DAMaster.Fill(dsete, "MERK")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe, Nama_Tipe , Kode_Merk from SIF.dbo.SIF_Tipe where rec_stat='Y'", sqlconn))
        DAMaster.Fill(dsete, "TIPE")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe , Kd_Tipe from SIF.dbo.SIF_Sub_Tipe where rec_stat='Y'", sqlconn))
        DAMaster.Fill(dsete, "SUBTIPE")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_Jenis_Barang where rec_stat='Y'", sqlconn))
        DAMaster.Fill(dsete, "JENIS")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_service, nama_service from [SIF].[dbo].SIF_bom_service where rec_stat='Y' ", sqlconn))
        DAMaster.Fill(dsete, "Bom_Service")

        DAMaster = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang, Kd_Satuan from SIF.dbo.SIF_Barang where rec_stat='Y' and Kd_jns_persd in ('3','4')", sqlconn))
        DAMaster.Fill(dsete, "BARANG")

        txtJenis.Properties.DataSource = dsete.Tables("JENIS")
        txtMerk.Properties.DataSource = dsete.Tables("MERK")
        txtTipe.Properties.DataSource = dsete.Tables("TIPE")
        txtUkuran.Properties.DataSource = dsete.Tables("UKURAN")
        txtService.Properties.DataSource = dsete.Tables("Bom_Service")

        repJenis.DataSource = dsete.Tables("JENIS")
        repMerk.DataSource = dsete.Tables("MERK")
        repTipe.DataSource = dsete.Tables("TIPE")
        repUkuran.DataSource = dsete.Tables("UKURAN")
        repService.DataSource = dsete.Tables("Bom_Service")
        repBarang.DataSource = dsete.Tables("BARANG")
        repSubTipe.DataSource = dsete.Tables("SUBTIPE")

        DATarif = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Tarif_Service order by Jenis, Merk, Tipe, Sub_Tipe ", sqlconn))
        DATarif.Fill(dsete, "TARIF")

        DABOM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.BOM_SERVICE_D ", sqlconn))
        DABOM.Fill(dsete, "BOM_SERVICE_D")

        Dim rl As DataRelation

        rl = dsete.Relations.Add("Material", dsete.Tables("TARIF").Columns("Nomor"), dsete.Tables("BOM_SERVICE_D").Columns("Nomer_d"), False)
        GC.LevelTree.Nodes.Add("Material", GV_D)

        GC.DataSource = dsete.Tables("TARIF")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        ' Jenis.Group()
        ' Merk.Group()
        ' Tipe.Group()
    End Sub
    Public Sub save_click()
        Dim btrans As SqlTransaction

        myBuilder = New SqlClient.SqlCommandBuilder(DATarif)
        DATarif.UpdateCommand = myBuilder.GetUpdateCommand()
        DATarif.InsertCommand = myBuilder.GetInsertCommand()
        DATarif.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DABOM)
        DABOM.UpdateCommand = myBuilder.GetUpdateCommand()
        DABOM.InsertCommand = myBuilder.GetInsertCommand()
        DABOM.DeleteCommand = myBuilder.GetDeleteCommand()

        btrans = sqlconn.BeginTransaction("1")

        DATarif.UpdateCommand.Transaction = btrans
        DATarif.InsertCommand.Transaction = btrans
        DATarif.DeleteCommand.Transaction = btrans

        DABOM.UpdateCommand.Transaction = btrans
        DABOM.InsertCommand.Transaction = btrans
        DABOM.DeleteCommand.Transaction = btrans
        Try
            For Each rw As DataRow In dsete.Tables("BOM_SERVICE_D").Rows
                If rw.RowState = DataRowState.Added Then
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kdcabang
                End If
            Next
            DATarif.Update(dsete.Tables("TARIF"))
            DABOM.Update(dsete.Tables("BOM_SERVICE_D"))

            btrans.Commit()
            showMessages("Transaksi Telah Disimpan")
        Catch
            btrans.Rollback()
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub gv_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub gv_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        If txtJenis.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Jenis", txtJenis.EditValue)
        End If
        If txtMerk.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Merk", txtMerk.EditValue)
        End If

        If txtTipe.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Tipe", txtTipe.EditValue)
        End If

        If txtSubTipe.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Sub_Tipe", txtSubTipe.EditValue)
        End If
        If txtUkuran.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Ukuran", txtUkuran.EditValue)
        End If
        If txtService.Text <> "" Then
            gv.SetRowCellValue(e.RowHandle, "Service", txtService.EditValue)
        End If

        gv.SetRowCellValue(e.RowHandle, "Kd_Cabang", kdcabang)
        gv.SetRowCellValue(e.RowHandle, "rec_stat", "Y")
    End Sub
    Private Sub txtTipe_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipe.QueryPopUp
        If txtMerk.Text = "" Then e.Cancel = True
    End Sub

    Private Sub txtMerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMerk.EditValueChanged
        clone = New DataView(dsete.Tables("TIPE"))
        clone.RowFilter = "Kode_Merk ='" & txtMerk.EditValue & "'"
        txtTipe.Properties.DataSource = clone
    End Sub

    Private Sub gv_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles gv.MasterRowExpanding
        If gv.GetRowCellValue(e.RowHandle, "Nomor").ToString = "" Then
            e.Allow = False
        End If
    End Sub

    Private Sub gv_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.ShownEditor
        If sender.FocusedColumn.Name = Tipe.Name Then

            Dim row As DataRow
            row = sender.GetDataRow(sender.FocusedRowHandle)

            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(sender.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kode_Merk ='" & gv.GetFocusedRowCellValue("Merk") & "'"
            edit.Properties.DataSource = clone
        ElseIf sender.FocusedColumn.Name = Kode_Sub_Tipe.Name Then

            Dim row As DataRow
            row = sender.GetDataRow(sender.FocusedRowHandle)

            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(sender.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kd_Tipe ='" & gv.GetFocusedRowCellValue("Tipe") & "'"
            edit.Properties.DataSource = clone

        End If
    End Sub

    Private Sub GV_D_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_D.CellValueChanged
        If e.Column.Name = "Kd_Barang" Then
            If e.Value.ToString = "" Then
                sender.SetRowCellValue(e.RowHandle, "satuan", "")
            Else
                Dim drows As DataRow() = dsete.Tables("BARANG").Select("Kode_Barang='" & e.Value & "'")
                sender.SetRowCellValue(e.RowHandle, "satuan", drows(0).Item("Kd_Satuan"))
            End If
        End If
    End Sub

    Private Sub GV_D_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_D.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_D_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_D.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Barang").ToString = "" Then
            isValid = False
            sender.SetColumnError(Kd_Barang, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            sender.FocusedColumn = Kd_Barang
        End If
        If e.Row.item("Qty").ToString = "" Then
            isValid = False
            sender.SetColumnError(qty, "Harap Mengisi Kolom Qty.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            sender.FocusedColumn = qty
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            sender.SetColumnError(qty, "Harap Mengisi Kolom Qty dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            sender.FocusedColumn = qty
        End If
        e.Valid = isValid
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Jenis").ToString = "" Then
            isValid = False
            gv.SetColumnError(Jenis, "Harap Memilih Jenis Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Jenis
        End If
        If e.Row.item("Merk").ToString = "" Then
            isValid = False
            gv.SetColumnError(Jenis, "Harap Memilih Merk Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Merk
        End If
        If e.Row.item("Tipe").ToString = "" Then
            isValid = False
            gv.SetColumnError(Tipe, "Harap Memilih Tipe Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Tipe
        End If
        If e.Row.item("Ukuran").ToString = "" Then
            isValid = False
            gv.SetColumnError(Ukuran, "Harap Memilih Ukuran Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Ukuran
        End If
        If e.Row.item("Service").ToString = "" Then
            isValid = False
            gv.SetColumnError(Service, "Harap Memilih Service Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Service
        End If
        If e.Row.item("Tarif").ToString = "" Then
            isValid = False
            gv.SetColumnError(Tarif, "Harap Mengisi Besar Tarif Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Tarif
        ElseIf e.Row.item("Tarif") <= 0 Then
            isValid = False
            gv.SetColumnError(Tarif, "Harap Mengisi Besar Tarif Barang Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gv.FocusedColumn = Tarif
        End If
        e.Valid = isValid
    End Sub

    Private Sub txtSubTipe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTipe.EditValueChanged

    End Sub

    Private Sub txtTipe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipe.EditValueChanged
        clone = New DataView(dsete.Tables("SUBTIPE"))
        clone.RowFilter = "Kd_Tipe ='" & txtTipe.EditValue & "'"
        txtSubTipe.Properties.DataSource = clone
    End Sub
End Class