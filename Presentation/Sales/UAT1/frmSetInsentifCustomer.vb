Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSetInsentifCustomer
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
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
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = btnSave
        End With

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

    Private Sub frmSetInsentifCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        DA = New SqlDataAdapter("select * from sales.dbo.SALES_SET_INSENTIF_CUSTOMER where rec_stat='Y'", sqlconn)
        DA.Fill(dsete, "RUMUS")
        gc.DataSource = dsete.Tables("RUMUS")
        Dim m(1) As DataRow
        With dsete.Tables.Add("DIVISI")
            .Columns.Add("Kode_Divisi")
            .Columns.Add("Nama_Divisi")
            m(0) = .NewRow
            m(0).Item(0) = "2"
            m(0).Item(1) = "Divisi Spring"

            m(1) = .NewRow
            m(1).Item(0) = "3"
            m(1).Item(1) = "Divisi Spon"

 
            .Rows.Add(m(0))
            .Rows.Add(m(1))
        End With
        cmbDivisi.Properties.DataSource = dsete.Tables("DIVISI")
        repDivisi.DataSource = dsete.Tables("DIVISI")

        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub frmSetInsentifCustomer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 5
        pnl.Height = Me.Height - 20
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Try
            For Each item As DataRow In dsete.Tables("RUMUS").Rows
                If item.RowState = DataRowState.Added Then
                    item("Kd_Cabang") = kdcabang
                    item("Last_Create_Date") = getTanggal()
                    item("Last_Created_By") = username
                    item("rec_stat") = "Y"
                    item("Program_Name") = Me.Name
                ElseIf item.RowState = DataRowState.Modified Then
                    item("Last_Update_Date") = getTanggal()
                    item("Last_Updated_By") = username
                End If
            Next
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("RUMUS"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            'dsete.Tables("RUMUS").RejectChanges()
        End Try
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If cmbDivisi.Text <> "" Then GV.SetRowCellValue(e.RowHandle, "Departement", cmbDivisi.EditValue.ToString)
        GV.SetRowCellValue(e.RowHandle, "Potongan", 0)
        GV.SetRowCellValue(e.RowHandle, "Potongan2", 0)
    End Sub

End Class