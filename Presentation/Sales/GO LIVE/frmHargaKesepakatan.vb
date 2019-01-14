Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmHargaKesepakatan
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter

    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Dim prn As frmMain
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

    Private Sub frmHargaSponBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        txtFilter.Properties.DataSource = dsete.Tables("CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang  " & _
                    "from SIF.dbo.SIF_Barang " & _
                    "where kd_jenis IN (select id_data from SIF.dbo.SIF_Gen_Reff_D where ref_role ='SOD' and id_ref_file='RPSEPAKAT' and rec_stat='Y') and rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 state  from sif.dbo.SIF_Harga_SponBox a where kd_stok in (select kode_barang from sif.dbo.sif_barang where kd_jenis IN (select id_data from SIF.dbo.SIF_Gen_Reff_D where ref_role ='SOD' and id_ref_file='RPSEPAKAT' and rec_stat='Y'))", sqlconn))
        dadbe.Fill(dsete, "BOX")

        repBarang.DataSource = dsete.Tables("VBARANG")
        repCustomer.DataSource = dsete.Tables("CUSTOMER")
        GC.DataSource = dsete.Tables("BOX")
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

    End Sub
    Public Sub add_click()

    End Sub
    Public Sub cancel_click()
        If dsete.Tables("BOX").Select("state > 0 ").Count > 0 Then
            If MsgBox("Anda Yakin Membatalkan Transaksi ?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Pembatalan") = MsgBoxResult.No Then Exit Sub
        End If
        dsete.Tables("BOX").RejectChanges()
    End Sub
    Public Sub save_click()
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(dadbe)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            dadbe.Update(dsete.Tables("BOX"))
            showMessages("Data Telah Disimpan")
            For Each rw As DataRow In dsete.Tables("BOX").Select("state > 0")
                rw("state") = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Gagal Menyimpan Data")
        End Try
    End Sub
    Public Sub cetak_click()

    End Sub
    Public Sub edit_click()

    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, "state", 1)
        If txtFilter.Text <> "" Then GV.SetRowCellValue(e.RowHandle, "Kd_Customer", txtFilter.EditValue)
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        If txtFilter.Text <> "" Then
            If txtFilter.EditValue <> e.Row.item("Kd_Customer") Then
                cmdClear_Click(cmdClear, New EventArgs)
            End If
        End If
        If e.Row.item("state") = 1 Then
            e.Row.item("Kd_Cabang") = kdcabang
            e.Row.item("Last_Create_Date") = getTanggal()
            e.Row.item("Last_Created_By") = username
            e.Row.item("Program_Name") = Me.Name
        ElseIf e.Row.item("state") = 0 Then
            e.Row.item("Last_Update_Date") = getTanggal()
            e.Row.item("Last_Updated_By") = username
            e.Row.item("state") = 2
        End If

    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isvalid As Boolean = True
        If e.Row.item("harga").ToString = "" Then
            isvalid = False
            GV.SetColumnError(harga, "Harap Mengisi Kolom Harga.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = harga
        ElseIf e.Row.item("harga") <= 0 Then
            isvalid = False
            GV.SetColumnError(harga, "Harap Mengisi Kolom Harga Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = harga
        End If
        If e.Row.item("Kd_Customer").ToString = "" Then
            isvalid = False
            GV.SetColumnError(Kd_Customer, "Harap Mengisi Kolom Customer.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = Kd_Customer
        End If
        If e.Row.item("KD_STOK").ToString = "" Then
            isvalid = False
            GV.SetColumnError(KD_STOK, "Harap Mengisi Kolom Barang.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = KD_STOK
        End If
        Dim rw() As DataRow = dsete.Tables("BOX").Select("Kd_Customer = '" & e.Row.item("Kd_Customer") & "' and KD_STOK= '" & e.Row.item("KD_STOK") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isvalid = False
                GV.SetColumnError(Kd_Customer, "Customer Untuk Jenis Spon Tersebut Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isvalid
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus Data") = MsgBoxResult.No Then Exit Sub

                GV.DeleteSelectedRows()
            End If
        End If
    End Sub

    Private Sub txtFilter_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilter.EditValueChanged
        If txtFilter.Text <> "" Then
            Dim ftr As String = "Kd_Customer = '" & txtFilter.EditValue & "'"
            GV.Columns("Kd_Customer").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)
            Kd_Customer.Group()
        Else
            GV.ActiveFilter.Clear()
            Kd_Customer.UnGroup()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtFilter.EditValue = Nothing

    End Sub

    
End Class