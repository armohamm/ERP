Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOKONSINYASI
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub

    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as NO from Sales.dbo.SALES_SO_D where 1=0", sqlconn))
        DAD.Fill(dsete, "SOD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where 1=0", sqlconn))
        DA.Fill(dsete, "SO")

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kode_Customer"

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        repbarang.DataSource = dsete.Tables("VBARANG")
        GC.DataSource = dsete.Tables("SOD")
        State = "ADD"
        tglSO.Text = Now

    End Sub

    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        Dim row As DataRow
        row = dsete.Tables("CUSTOMER").Select("Kode_Customer='" & sender.editvalue & "'")(0)
        txtAlamat.Text = row("Kode_Customer")
    End Sub

    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        Dim row As DataRow
        row = dsete.Tables("SALES").Select("Kode_Sales='" & sender.editvalue & "'")(0)
        txtNamaSales.Text = row("Kode_Sales")
    End Sub
    Public Sub save_click()
        Dim row As DataRow
        State = "ADD"
        If State = "ADD" Then
            row = dsete.Tables("SO").NewRow
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = username
        ElseIf State = "EDIT" Then
            row = dsete.Tables("SO").Rows(0)
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("No_sp") = txtNomor.Text
        row.Item("Tipe_trans") = "KONSINYASI"
        row.Item("Tgl_sp") = Now
        row.Item("Kd_Customer") = txtCustomer.EditValue
        row.Item("Nama_pnrm") = txtNamaPnrm.Text
        row.Item("Almt_pnrm") = txtAlamatKirim.Text
        row.Item("Tgl_Kirim") = tglKirim.EditValue
        row.Item("Kd_sales") = txtSales.EditValue
        row.Item("Keterangan") = txtKeterangan.Text
        row.Item("Flag_Ppn") = PPN.EditValue
        row.Item("PPn") = "0"
        row.Item("Total_qty") = Qty.SummaryText
        row.Item("Departement") = "1"
        row.Item("Status") = "OK"
        row.Item("Program_Name") = Me.Name

        If State = "ADD" Then
            dsete.Tables("SO").Rows.Add(row)
        End If
        Dim a As Integer = 1
        For Each rows As DataRow In dsete.Tables("SOD").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = "1"
                rows.Item("No_sp") = txtNomor.Text
                rows.Item("No_seq") = rows.Item("NO")
                rows.Item("tipe_trans") = "SPRING"
                rows.Item("Status") = "Y"
                rows.Item("departemen") = "2"
            Else
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
            End If
            rows.Item("Programe_name") = Me.Name

        Next

        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.Update(dsete.Tables("SO"))

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()
            DAD.Update(dsete.Tables("SOD"))

            dsete.Tables("SO").AcceptChanges()
            dsete.Tables("SOD").AcceptChanges()
            State = "EDIT"
            MsgBox("saved")
        Catch e As Exception
            dsete.Tables("SO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("kd_satuan")
        End If
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("NO") = GV.RowCount + 1
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString = "" Or e.Row.item("Qty") < 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid

    End Sub
    Private Sub PPN_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        PPN.Text = IIf(PPN.Checked, "Ya", "Tidak")
    End Sub
End Class