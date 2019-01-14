Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Public Class frmSetingInsentif
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
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Public Sub cancel_click()
        If MsgBox("Batalkan Master insentif ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Batal") = MsgBoxResult.Yes Then
            dsete.Tables("RUMUS").Clear()
            DA = New SqlDataAdapter("select * from sales.dbo.sales_rumus_insentif_d where status='Y'", sqlconn)
            DA.Fill(dsete, "RUMUS")
        End If
    End Sub
    Private Sub frmSetingInsentif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlDataAdapter("select Kode_Merk, Nama_Merk from sif.dbo.sif_Merk where rec_stat='Y'", sqlconn)
        dadbe.Fill(dsete, "Merk")
        dadbe = New SqlDataAdapter("select '%%' KODE, 'ALL' DESKRIPSI union select 'DALAM KOTA','DALAM KOTA' union select 'LUAR KOTA','LUAR KOTA' ", sqlconn)
        dadbe.Fill(dsete, "Lingkup")
        DA = New SqlDataAdapter("select * from sales.dbo.sales_rumus_insentif_d where status='Y'", sqlconn)
        DA.Fill(dsete, "RUMUS")
        GC.DataSource = dsete.Tables("RUMUS")
        repWil.DataSource = dsete.Tables("Lingkup")
        repWil.DisplayMember = "DESKRIPSI"
        repWil.ValueMember = "KODE"
        repMerk.DataSource = dsete.Tables("Merk")
        With dsete.Tables.Add("Divisi")
            .Columns.Add("Kode_Divisi")
            .Columns.Add("Nama_Divisi")
            Dim rw As DataRow = .NewRow
            rw(0) = KD_DIV_SPRING
            rw(1) = "Spring"
            .Rows.Add(rw)

            rw = .NewRow
            rw(0) = KD_DIV_SPON
            rw(1) = "Spon"
            .Rows.Add(rw)

        End With
        repDivisi.DataSource = dsete.Tables("Divisi")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Try
            For Each item As DataRow In dsete.Tables("RUMUS").Rows
                If item.RowState = DataRowState.Added Then
                    item("Kd_Cabang") = kdcabang
                    item("Last_Create_Date") = getTanggal()
                    item("Last_Created_By") = username
                    item("Status") = "Y"
                    item("Program_Name") = username
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
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Private Sub frmSetingInsentif_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 5
        pnl.Height = Me.Height - 20
    End Sub
End Class