Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmTargetPajak
    Dim dSO, DsSales As New DataSet
    Dim obj As Object
    Dim prn As frmMain
    Public state As String
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Dim DA, DAC, DAs As SqlDataAdapter
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmTargetPajak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        tampil_GC()
        state = "ADD"
        setStatus()
    End Sub

    Public Sub add_click()
        State = "ADD"
        'reload()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Sub tampil_GC()
        If Not DsSales.Tables("Sales") Is Nothing Then DsSales.Tables("Sales").Clear()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select *, right(thnbln,2)+'/'+left(thnbln,4) thnblnx from SALES.dbo.SALES_TARGET_PAJAK", sqlconn))
        DAs.Fill(DsSales, "Sales")
        GC_Sales.DataSource = DsSales.Tables("Sales")
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If txtTahun.EditValue = Nothing Then
                MessageBox.Show("Periode Belum Dipilih")
                Exit Sub
            End If
            If state = "ADD" Then
                dSO = New DataSet
                DA = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_TARGET_PAJAK where 1=0", sqlconn))
                DA.Fill(dSO, "SALES_PAJAK") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                Dim row As DataRow = dSO.Tables("SALES_PAJAK").NewRow
                row("kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                row("kd_dept") = kddep
                row("thnbln") = Format(txtTahun.EditValue, "yyyyMM").ToString
                row("tglthnbln") = txtTahun.EditValue
                row("target") = txt_target.Text
                row("Keterangan") = txbKet.Text
                row("created_date") = Now
                row("created_by") = umum.username
                dSO.Tables("SALES_PAJAK").Rows.Add(row)
            ElseIf state = "EDIT" Then
                Dim row As DataRow = dSO.Tables("Sales").Rows(0)
                row("target") = txt_target.Text
                row("Keterangan") = txbKet.Text
                row("updated_date") = Now
                row("updated_by") = umum.username
            End If
        End If

        If STATE = "ADD" Then
            ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_SALES"
            Try
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.InsertCommand = myBuilder.GetInsertCommand()
                DA.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO.Tables("SALES_PAJAK"))
                dSO.Tables("SALES_PAJAK").AcceptChanges()
                STATE = "EDIT"
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                state = ""
                tampil_GC()
            Catch ex As Exception
                dSO.Tables("SALES_PAJAK").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        ElseIf STATE = "EDIT" Then
            Try
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.InsertCommand = myBuilder.GetInsertCommand()
                DA.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO.Tables("Sales"))
                dSO.Tables("Sales").AcceptChanges()
                STATE = "EDIT"
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                tampil_GC()
            Catch ex As Exception
                dSO.Tables("Sales").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        End If

    End Sub

    Public Sub cancel_click()
        txt_target.Text = 0
        txbKet.Text = ""
        txtTahun.EditValue = Nothing

        setStatus()
        state = "ADD"


    End Sub
    

    Private Sub GC_Sales_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC_Sales.DoubleClick
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_TARGET_PAJAK where thnbln='" & GVSpon.GetRow(GVSpon.GetSelectedRows(0)).item("thnbln").ToString & "'", sqlconn))
        DA.Fill(dSO, "Sales") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

        
        txt_target.Text = dSO.Tables("Sales").Rows(0).Item("target").ToString
        txbKet.Text = dSO.Tables("Sales").Rows(0).Item("keterangan").ToString
        txtTahun.EditValue = dSO.Tables("Sales").Rows(0).Item("tglthnbln")
        
        state = "EDIT"
        setStatus()
    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_TARGET_PAJAK where thnbln='" & Format(txtTahun.EditValue, "yyyyMM").ToString & "'", sqlconn))
        DA.Fill(dSO, "Sales")
        If dSO.Tables("Sales").Rows.Count > 0 Then
            txt_target.Text = dSO.Tables("Sales").Rows(0).Item("target").ToString
            txbKet.Text = dSO.Tables("Sales").Rows(0).Item("keterangan").ToString
            txtTahun.EditValue = dSO.Tables("Sales").Rows(0).Item("tglthnbln")
            state = "EDIT"
            txt_target.Focus()
            setStatus()
        Else
            txt_target.Focus()
            txt_target.Text = 0
            txbKet.Text = ""
            state = "ADD"
        End If

    End Sub
End Class