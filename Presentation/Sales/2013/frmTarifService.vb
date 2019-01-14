Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmTarifService
    Dim dsete As New DataSet
    Dim daTarif, daBom, daMaster As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btncetak As Boolean = False
    Dim ChildCol(4) As DataColumn
    Dim ParentCol(4) As DataColumn
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
            
        For Each rows As DataRow In dsete.Tables("TARIF").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("Rec_Stat") = "Y"
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            End If
        Next

        For Each rows As DataRow In dsete.Tables("BOM").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("Rec_Stat") = "Y"
            Else
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
            End If
            rows.Item("Program_name") = Me.Name
        Next

        Try
            Dim myBuilder As SqlClient.SqlCommandBuilder
            myBuilder = New SqlClient.SqlCommandBuilder(daTarif)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            daTarif.UpdateCommand = myBuilder.GetUpdateCommand()
            daTarif.InsertCommand = myBuilder.GetInsertCommand()
            daTarif.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(daBom)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            daBom.UpdateCommand = myBuilder.GetUpdateCommand()
            daBom.InsertCommand = myBuilder.GetInsertCommand()
            daBom.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
      
            daTarif.UpdateCommand.Transaction = BTRANS
            daTarif.InsertCommand.Transaction = BTRANS
            daTarif.DeleteCommand.Transaction = BTRANS

            daBom.UpdateCommand.Transaction = BTRANS
            daBom.InsertCommand.Transaction = BTRANS
            daBom.DeleteCommand.Transaction = BTRANS


            daTarif.Update(dsete.Tables("TARIF"))
            daBom.Update(dsete.Tables("BOM"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
            For Each rw As DataRow In dsete.Tables("TARIF").Select("sts<>'0'")
                rw("sts") = "1"
            Next
            For Each rw As DataRow In dsete.Tables("BOM").Select("sts<>'0'")
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
        If Not dsete.Tables("SUBTIPE") Is Nothing Then dsete.Tables("SUBTIPE").Clear()
        If Not dsete.Tables("KAIN") Is Nothing Then dsete.Tables("KAIN").Clear()

        ' If Not dsete.Tables("BARANG") Is Nothing Then dsete.Tables("BARANG").Clear()
        If Not dsete.Tables("BAHAN") Is Nothing Then dsete.Tables("BAHAN").Clear()
        If Not dsete.Tables("BOM_SERVICE") Is Nothing Then dsete.Tables("BOM_SERVICE").Clear()
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

        daMaster = New SqlDataAdapter("select Kd_Tipe, Kd_Sub_Tipe, Nama_Sub_Tipe from sif.dbo.sif_sub_Tipe union select '%%', '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "SUBTIPE")
        repSubTipe.DataSource = dsete.Tables("SUBTIPE")

        daMaster = New SqlDataAdapter("select Merk_Kain, Kode_Kain from sif.dbo.sif_kain union select 'ALL', '%%'", sqlconn)
        daMaster.Fill(dsete, "KAIN")
        repKain.DataSource = dsete.Tables("KAIN")

        'daMaster = New SqlDataAdapter("select Kode_Ukuran, Nama_Ukuran from sif.dbo.sif_Ukuran where isnull(tinggi,0)=0 union select '%%', 'ALL'", sqlconn)
        daMaster = New SqlDataAdapter("select Kode_Ukuran, Nama_Ukuran from sif.dbo.sif_Ukuran union select '%%', 'ALL'", sqlconn)
        daMaster.Fill(dsete, "UKURAN")
        repUkuran.DataSource = dsete.Tables("UKURAN")

        daMaster = New SqlDataAdapter("select Nama_Barang, Kode_Barang, Kd_Satuan from sif.dbo.sif_barang where  kd_jns_perSd<>'1'", sqlconn)
        daMaster.Fill(dsete, "BAHAN")
        repbahan.DataSource = dsete.Tables("BAHAN")

        daMaster = New SqlDataAdapter("select * from sif.dbo.SIF_bom_service", sqlconn)
        daMaster.Fill(dsete, "BOM_SERVICE")
        repjenisService.DataSource = dsete.Tables("BOM_SERVICE")

        daTarif = New SqlDataAdapter("select *,  '0' sts from sif.dbo.SIF_TARIF_SERVICE", sqlconn)
        daTarif.Fill(dsete, "TARIF")

        daBom = New SqlDataAdapter("select *, '0' sts from sif.dbo.SIF_TARIF_SERVICE_BOM", sqlconn)
        daBom.Fill(dsete, "BOM")

        GC.DataSource = dsete.Tables("TARIF")
      
        If ParentCol(0) Is Nothing Then
            ParentCol(0) = dsete.Tables("TARIF").Columns("JENIS")
            ParentCol(1) = dsete.Tables("TARIF").Columns("MERK")
            ParentCol(2) = dsete.Tables("TARIF").Columns("TIPE")
            ParentCol(3) = dsete.Tables("TARIF").Columns("UKURAN")
            ParentCol(4) = dsete.Tables("TARIF").Columns("Jenis_Service")
            ParentCol(4) = dsete.Tables("TARIF").Columns("SUBTIPE")

            ChildCol(0) = dsete.Tables("BOM").Columns("JENIS")
            ChildCol(1) = dsete.Tables("BOM").Columns("MERK")
            ChildCol(2) = dsete.Tables("BOM").Columns("TIPE")
            ChildCol(3) = dsete.Tables("BOM").Columns("UKURAN")
            ChildCol(4) = dsete.Tables("BOM").Columns("Jenis_Service")
            ChildCol(4) = dsete.Tables("BOM").Columns("SUBTIPE")

            'dsete.Relations.Add("BOM", ParentCol, ChildCol, False)
            'GC.LevelTree.Nodes.Add("BOM", GV2)
        End If
        lblJmlRec.Text = "Row Count : " & GV.RowCount
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Merk Then
            If e.Value = "%%" Then
                dsete.Tables("TIPE").Clear()
                daMaster = New SqlDataAdapter("select '%%' as Kode_Tipe, 'ALL' as Nama_Tipe", sqlconn)
                daMaster.Fill(dsete, "TIPE")
                repTipe.DataSource = dsete.Tables("TIPE")
            Else
                dsete.Tables("TIPE").Clear()
                daMaster = New SqlDataAdapter("select Kode_Tipe, Nama_Tipe from sif.dbo.sif_Tipe where kode_merk='" & e.Value & "' union select '%%', 'ALL'", sqlconn)
                daMaster.Fill(dsete, "TIPE")
                repTipe.DataSource = dsete.Tables("TIPE")
            End If
            sender.SetRowCellValue(e.RowHandle, "TIPE", "%%")
        ElseIf e.Column Is Tipe Then
            'If e.Value = "%%" Then
            '    dsete.Tables("SUBTIPE").Clear()
            '    daMaster = New SqlDataAdapter("select '%%' as Kd_Sub_Tipe, 'ALL' as Nama_Sub_Tipe", sqlconn)
            '    daMaster.Fill(dsete, "SUBTIPE")
            '    repTipe.DataSource = dsete.Tables("SUBTIPE")
            'Else
            '    dsete.Tables("SUBTIPE").Clear()
            '    daMaster = New SqlDataAdapter("select Kd_Sub_Tipe, Nama_Sub_Tipe from sif.dbo.sif_sub_Tipe where Kd_Tipe = '" & e.Value & "' union select '%%', '%%', 'ALL'", sqlconn)
            '    daMaster.Fill(dsete, "SUBTIPE")
            '    repTipe.DataSource = dsete.Tables("SUBTIPE")
            'End If
            sender.SetRowCellValue(e.RowHandle, "SUBTIPE", "%%")
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, "sts", "1")
        GV.SetRowCellValue(e.RowHandle, "MERK", "%%")
        GV.SetRowCellValue(e.RowHandle, "TIPE", "%%")
        GV.SetRowCellValue(e.RowHandle, "UKURAN", "%%")
        GV.SetRowCellValue(e.RowHandle, "KAIN", "%%")
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus") = MsgBoxResult.Ok Then
                    Dim rwm As Object = GV.GetRow(GV.GetSelectedRows(0))
                    For Each rw As DataRow In dsete.Tables("BOM").Select("JENIS='" & rwm.item("JENIS") & "' and MERK='" & rwm.item("MERK") & "' and TIPE='" & rwm.item("TIPE") & "' and UKURAN='" & rwm.item("UKURAN") & "'  and Jenis_Service='" & rwm.item("Jenis_Service") & "'")
                        rw.Delete()
                    Next
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        If e.Row("sts") = "0" Then e.Row("sts") = "2"
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "sts", "1")
    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV2.KeyDown
        If e.KeyCode = Keys.Delete Then
            If sender.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus") = MsgBoxResult.Ok Then
                    sender.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV2.RowUpdated
        If e.Row("sts") = "0" Then e.Row("sts") = "2"
    End Sub

    Private Sub GV_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        Dim clone As DataView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn Is subTipe Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            clone.RowFilter = "Kd_Tipe = '" + row("TIPE").ToString() & "' or Kd_Tipe='%%'"
            edit.Properties.DataSource = clone
        End If
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Jenis_Service").ToString = "" Then
            isValid = False
            GV.SetColumnError(Jenis_Service, "Jenis Sevice Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)

        End If
        If e.Row.item("Tarif").ToString = "" Then
            isValid = False
            GV.SetColumnError(Tarif, "Biaya Tarif Sevice Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Tarif") <= 0 Then
            isValid = False
            GV.SetColumnError(Tarif, "Biaya Tarif Sevice Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("TARIF").Select("JENIS = '" & e.Row.item("JENIS") & "' and MERK = '" & e.Row.item("MERK") & "' and TIPE = '" & e.Row.item("TIPE") & "' and SUBTIPE = '" & e.Row.item("SUBTIPE") & "' and UKURAN = '" & e.Row.item("UKURAN") & "' and KAIN = '" & e.Row.item("KAIN") & "' and Jenis_Service='" & e.Row.item("Jenis_Service") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV.SetColumnError(Jenis_Service, "Kode Barang dan Jenis Service Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Bahan").ToString = "" Then
            isValid = False
            sender.SetColumnError(Kd_Bahan, "Kode Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        
        If e.Row.item("Qty").ToString = "" Then
            isValid = False
            sender.SetColumnError(Tarif, "Qty Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            sender.SetColumnError(Qty, "Qty Barang Harus Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("BOM").Select("JENIS = '" & e.Row.item("JENIS") & "' and MERK = '" & e.Row.item("MERK") & "' and TIPE = '" & e.Row.item("TIPE") & "' and UKURAN = '" & e.Row.item("UKURAN") & "' and Jenis_Service='" & e.Row.item("Jenis_Service") & "' and Kd_Bahan = '" & e.Row.item("Kd_Bahan") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                sender.SetColumnError(Kd_Bahan, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
End Class