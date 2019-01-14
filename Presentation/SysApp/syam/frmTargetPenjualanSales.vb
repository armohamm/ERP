Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmTargetPenjualanSales
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public state As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Dim DA, DAC As SqlDataAdapter
    Dim clone As Object
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub reloadTable(ByVal kodeSales As String, ByVal thn As String)

        If Not dsete.Tables("TARGET") Is Nothing Then dsete.Tables("TARGET").Clear()
        Dim tahun As String = Microsoft.VisualBasic.Left(thn, 4)
        Dim bulan As String = Microsoft.VisualBasic.Right(thn, 2)
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_TARGET_SALES where kd_sales = '" & kodeSales & "' and thn_buku = '" & tahun & "' and bln_buku='" & bulan & "' ", sqlconn))
        DA.Fill(dsete, "TARGET")

    End Sub

    Private Sub frmTargetPenjualanSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        umum.connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.vRep_Sales where kode_departemen='" & kddep & "'", sqlconn))
        dadbe.Fill(dsete, "SALES")
        DAC = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_TARGET_TOKO", sqlconn))
        DAC.Fill(dsete, "TARGET_CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk, Nama_Merk from SIF.dbo.sif_Merk", sqlconn))
        dadbe.Fill(dsete, "MERK")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe, Nama_Tipe, Kode_Merk from SIF.dbo.sif_Tipe where 1=0", sqlconn))
        dadbe.Fill(dsete, "TIPE")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Persd, Kd_Jns_Brg, Nama_Jenis from SIF.dbo.sif_Jenis_Barang where Kd_Departemen='3' and Kd_Jns_Persd='1'", sqlconn))
        dadbe.Fill(dsete, "JBarang")
        txtsales.Properties.DataSource = dsete.Tables("SALES")

        reloadTable("XXX", "XXX")

        If kddep = KD_DIV_SPRING Then
            gbSpon.Visible = False
            gbSpring.Caption = "Spring"
        Else
            gbSpon.Visible = False
            gbSpring.Caption = "Spon"
        End If
        GC.DataSource = dsete.Tables("TARGET")

        repjenisBarang.DataSource = dsete.Tables("JBarang")
        RepSales.DataSource = dsete.Tables("SALES")
        RepSales.DisplayMember = "Nama_Sales"
        RepSales.ValueMember = "Kode_Sales"
        repMerk.DataSource = dsete.Tables("MERK")
        repTipe.DataSource = dsete.Tables("TIPE")

        prn = frmMain

        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Dim rl As DataRelation
        Dim colM(5) As DataColumn
        Dim colD(5) As DataColumn
        colM(0) = dsete.Tables("TARGET").Columns("kd_sales")
        colM(1) = dsete.Tables("TARGET").Columns("thn_buku")
        colM(2) = dsete.Tables("TARGET").Columns("bln_buku")
        colM(3) = dsete.Tables("TARGET").Columns("kd_jenis")
        colM(4) = dsete.Tables("TARGET").Columns("kd_merk")
        colM(5) = dsete.Tables("TARGET").Columns("kd_tipe")

        colD(0) = dsete.Tables("TARGET_CUSTOMER").Columns("kd_sales")
        colD(1) = dsete.Tables("TARGET_CUSTOMER").Columns("thn_buku")
        colD(2) = dsete.Tables("TARGET_CUSTOMER").Columns("bln_buku")
        colD(3) = dsete.Tables("TARGET_CUSTOMER").Columns("kd_jenis")
        colD(4) = dsete.Tables("TARGET_CUSTOMER").Columns("kd_merk")
        colD(5) = dsete.Tables("TARGET_CUSTOMER").Columns("kd_tipe")

        rl = dsete.Relations.Add("Customer", colM, colD, False)
        'rl.Nested = True

        GC.LevelTree.Nodes.Add("Customer", gvc)

        pnl.Top = 5
        pnl.Height = prn.pnlDisplay2.Height - 20
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Public Sub save_click()
        Dim rw As DataRow
        Dim btrans As SqlTransaction
        For Each rw In dsete.Tables("TARGET").Rows
            If rw.RowState = DataRowState.Added Then
                rw("kd_cabang") = kdcabang
                rw("last_create_date") = getTanggal()
                rw("last_created_by") = username
                rw("program_name") = Me.Name
            Else
                rw("last_update_date") = getTanggal()
                rw("last_updated_by") = username
            End If
        Next
        For Each rw In dsete.Tables("TARGET_CUSTOMER").Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("kd_cabang") = kdcabang
            End If
        Next

        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana

        myBuilder = New SqlClient.SqlCommandBuilder(DAC)
        DAC.UpdateCommand = myBuilder.GetUpdateCommand()
        DAC.InsertCommand = myBuilder.GetInsertCommand()
        DAC.DeleteCommand = myBuilder.GetDeleteCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
        Try
            btrans = sqlconn.BeginTransaction

            DA.UpdateCommand.Transaction = btrans
            DA.InsertCommand.Transaction = btrans
            DA.DeleteCommand.Transaction = btrans

            DAC.UpdateCommand.Transaction = btrans
            DAC.InsertCommand.Transaction = btrans
            DAC.DeleteCommand.Transaction = btrans

            DA.Update(dsete.Tables("TARGET"))
            DAC.Update(dsete.Tables("TARGET_CUSTOMER"))

            showMessages("Transaksi Telah Diproses")
            btrans.Commit()
        Catch e As Exception
            btrans.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtsales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsales.EditValueChanged
        If isInitialized Then Exit Sub
        txtDivisi.Text = txtsales.GetSelectedDataRow.item("Nama_Departemen").ToString
        txtArea.Text = txtsales.GetSelectedDataRow.item("Nama_Area").ToString
        Dim dep As String = txtsales.GetSelectedDataRow.item("kode_wilayah").ToString
        Dim area As String = txtsales.GetSelectedDataRow.item("kode_area").ToString
        If Not dsete.Tables("CUSTOMER") Is Nothing Then dsete.Tables("CUSTOMER").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer, Nama_Customer from SIF.dbo.SIF_Customer where Kd_Wilayah = '" & dep & "' and Kode_Area = '" & area & "'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        repCustomer.DataSource = dsete.Tables("CUSTOMER")
        If txtTahun.Text <> "" Then
            reloadTable(txtsales.EditValue, txtTahun.Text)
        End If
        txtKdSales.EditValue = txtsales.EditValue
    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        If e.Column.Name = "kd_merk" Then
            If Not dsete.Tables("TIPE") Is Nothing Then dsete.Tables("TIPE").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe, Nama_Tipe, Kode_Merk from SIF.dbo.sif_Tipe where Kode_Merk='" & e.Value & "'", sqlconn))
            dadbe.Fill(dsete, "TIPE")
            gv.SetRowCellValue(e.RowHandle, "kd_tipe", vbNullString)
        End If
    End Sub

    Private Sub gv_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    Private Sub gv_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.SetRowCellValue(e.RowHandle, "kd_cabang", kdcabang)
        gv.SetRowCellValue(e.RowHandle, "departement", txtsales.GetSelectedDataRow.item("kode_departemen").ToString)
        gv.SetRowCellValue(e.RowHandle, "kd_sales", txtsales.EditValue)
        gv.SetRowCellValue(e.RowHandle, "thn_buku", txtTahun.DateTime.Year)
        gv.SetRowCellValue(e.RowHandle, "bln_buku", Microsoft.VisualBasic.Right("0" + txtTahun.DateTime.Month.ToString, 2))
        gv.SetRowCellValue(e.RowHandle, "last_create_date", getTanggal)
        gv.SetRowCellValue(e.RowHandle, "last_created_by", username)
    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        If isInitialized Then Exit Sub
        If txtsales.Text <> "" Then
            reloadTable(txtsales.EditValue, txtTahun.DateTime.Year & Microsoft.VisualBasic.Right("0" & txtTahun.DateTime.Month, 2))
        End If
    End Sub

    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvc_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvc.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gv.ShowingEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn Is kd_tipe Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            clone.RowFilter = "Kode_Merk = " + row("kd_merk").ToString()
            edit.Properties.DataSource = clone
        End If
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        'If gbSpon.Visible Then
        '    If e.Row("kd_jenis").ToString = "" Then
        '        isValid = False
        '        gv.SetColumnError(Jenis, "Harap Memilih Jenis Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    End If
        'Else
        If e.Row("kd_merk").ToString = "" Then
            isValid = False
            gv.SetColumnError(kd_merk, "Harap Memilih Merk Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        'End If
        If e.Row("target").ToString = "" Then
            isValid = False
            gv.SetColumnError(target, "Harap Mengisi Targer Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row("target") < 0 Then
            isValid = False
            gv.SetColumnError(target, "Harap Mengisi Targer Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        'If e.Row.item("kd_jenis").ToString <> "" Then
        '    Dim rw() As DataRow = dsete.Tables("TARGET").Select("kd_jenis = '" & e.Row.item("kd_jenis") & "'")
        '    If rw.Count = 1 Then
        '        If Not rw(0) Is e.Row.row Then
        '            isValid = False
        '            gv.SetColumnError(Jenis, "Jenis Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '        End If
        '    End If
        'End If
        'If e.Row.item("kd_merk").ToString <> "" Then
        '    Dim rw() As DataRow = dsete.Tables("TARGET").Select("kd_merk = '" & e.Row.item("kd_merk") & "'")
        '    If rw.Count = 1 Then
        '        If Not rw(0) Is e.Row.row Then
        '            isValid = False
        '            gv.SetColumnError(Jenis, "Merk Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '        End If
        '    End If
        'End If
        e.Valid = isValid
    End Sub
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        txtsales.EditValue = vbNullString
        txtArea.Text = ""
        txtDivisi.Text = ""
        txtKdSales.Text = ""
        txtTahun.EditValue = vbNullString
    End Sub
End Class