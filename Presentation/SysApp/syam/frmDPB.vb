Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmDPB
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
    Private Sub reloadTable(ByVal kode As String)
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_DPB where No_dpb='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_DPB")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 as QtySp, 0 as Sisa,0 as QtyTot, (select Nama_Barang from sif.dbo.sif_barang where Kode_barang=kd_stok) as Nama_Barang from SALES.dbo.SALES_DPB_D where No_dpb='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_DPB_D")
        gc.DataSource = dsete.Tables("SALES_DPB_D")
    End Sub
    Private Sub frmDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.VSALES_SO_DPB", sqlconn))
        dadbe.Fill(dsete, "BSO")
        RGC.DataSource = dsete.Tables("BSO")
        tglRetur.EditValue = Now
        reloadTable("xxx")
        Dim dr As SqlDataReader = New SqlCommand("select *, (select Nama_Barang from sif.dbo.sif_barang where Kode_barang=kd_stok) as Nama_Barang  from sales.dbo.VSO_TO_DPM ", sqlconn).ExecuteReader
        Dim i As Integer = 1
        While dr.Read
            Dim row As DataRow = dsete.Tables("SALES_DPB_D").NewRow
            row("Kd_Cabang") = "1"
            row("tipe_trans") = "SPRING"
            row("no_seq") = i
            row("QtyTot") = dr("QTYDPB")
            i += 1
            row("Kd_Stok") = dr("Kd_Stok")
            row("Nama_Barang") = dr("Nama_Barang")
            'row("no_sp") = dr("No_sp")
            row("no_seq_sp") = dr("no_seq")
            row("kd_satuan") = dr("Kd_satuan")
            row("QtySp") = dr("Qty")
            row("Sisa") = dr("Qty")
            row("Qty") = 0
            row("last_update_date") = Now
            row("last_updated_by") = umum.username
            row("last_create_date") = Now
            row("last_created_by") = umum.username
            row("program_name") = Me.Name
            dsete.Tables("SALES_DPB_D").Rows.Add(row)
        End While
        dr.Close()
        dr = Nothing
        txtBarcode.Focus()
    End Sub
    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Qty Then
            GV.GetRow(e.RowHandle).item("Sisa") = GV.GetRow(e.RowHandle).item("QtySp") - e.Value
        End If
        'dsete.Tables("BSO").Select("Kd_Stok='"&  &"' and No_sp='"&  &"'")
        'gv.GetRow(e.RowHandle).item("kd_satuan")
    End Sub
    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            GV.DeleteSelectedRows()
            refreshNomer()
        End If
    End Sub
    Public Sub save_click(Optional ByVal param As Boolean = False)
        If GV.Columns("Qty").SummaryItem.SummaryValue = 0 Then
            MsgBox("Daftar Barang Masih Kosong", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim BTRANS As SqlTransaction
        Dim rw As DataRow = dsete.Tables("SALES_DPB").NewRow
        rw("No_dpb") = txtNomor.Text
        rw("Tgl_dpb") = tglRetur.Text
        rw("tipe_trans") = "Y"
        rw("Kd_Cabang") = "2"
        rw("Last_Create_Date") = Now
        rw("Last_Created_By") = umum.username
        rw("Program_Name") = Me.Name
        dsete.Tables("SALES_DPB").Rows.Add(rw)

        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DAD)
        DAD.UpdateCommand = myBuilder.GetUpdateCommand()
        DAD.InsertCommand = myBuilder.GetInsertCommand()
        DAD.DeleteCommand = myBuilder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DAD.UpdateCommand.Transaction = BTRANS
        DAD.InsertCommand.Transaction = BTRANS
        DAD.DeleteCommand.Transaction = BTRANS

        For Each row As DataRow In dsete.Tables("SALES_DPB_D").Rows
            If row.RowState = DataRowState.Added Then
                row.Item("No_dpb") = txtNomor.Text
            ElseIf row.RowState = DataRowState.Modified Then
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If
        Next
        Try
            DA.Update(dsete.Tables("SALES_DPB"))
            DAD.Update(dsete.Tables("SALES_DPB_D"))
            dsete.Tables("SALES_DPB").AcceptChanges()
            dsete.Tables("SALES_DPB_D").AcceptChanges()
            BTRANS.Commit()
            showMessages("Saved..")
            txtBarcode.Text = ""
            txtNamaBarang.Text = ""
            txtNomor.Text = ""
            lblState.Text = ""
            For Each row As DataRow In dsete.Tables("SALES_DPB_D").Select("Sisa=0")
                row.Delete()
            Next
        Catch e As Exception
            BTRANS.Rollback()
            dsete.Tables("SALES_DPB").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub refreshNomer()
        Dim i As Integer = 1
        For Each row As DataRow In dsete.Tables("SALES_DPB_D").Rows
            If row.RowState <> DataRowState.Deleted Then
                row.Item("no_seq") = i
                i += 1
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save_click()
    End Sub
    Function getPos(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dsete.Tables("SALES_DPB_D").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function
    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            Dim dr() As DataRow = dsete.Tables("SALES_DPB_D").Select("Kd_Stok = '" & txtBarcode.Text & "'")
            txtNamaBarang.ForeColor = Color.White
            For i As Int16 = 0 To dr.Count - 1
                Application.DoEvents()
                lblState.Text = "OK"
                txtNamaBarang.Text = dr(i)("Nama_Barang").ToString
                txtBarcode.SelectAll()
                If dr(i)("Sisa") > 0 Then
                    dr(i)("Qty") = dr(i)("Qty") + 1
                    dr(i)("Sisa") = dr(i)("QtySp") - dr(i)("Qty")
                    ok = True
                    BindingContext(gc.DataSource).Position = getPos(dr(i))
                    delay()
                    txtBarcode.Focus()
                    txtNamaBarang.Text = ""
                    txtBarcode.Text = ""
                    lblState.Text = ""
                    Exit Sub
                End If
            Next
            txtNamaBarang.ForeColor = Color.Yellow
            If dr.Count = 0 Then
                txtNamaBarang.Text = "Item Tidak Diketemukan Dalam Daftar"
                lblState.Text = "Fail"
            ElseIf Not ok Then
                txtNamaBarang.Text = "Item Sudah Terdaftar Semua"
                lblState.Text = "Fail"
            End If
            txtBarcode.SelectAll()
        End If
    End Sub
    Sub delay()
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
    End Sub
End Class