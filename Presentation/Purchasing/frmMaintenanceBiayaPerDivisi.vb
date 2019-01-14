
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmMaintenanceBiayaPerDivisi
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, ds3, ds4, dsku, dsku1, dsku2, dsedit As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, da4, sqlda, daedit, sqlda1, sqlda2 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Sub bersih()
        
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("BIAYA") Is Nothing Then ds3.Tables("BIAYA").Clear()

      
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_buku_besar where kd_buku_besar like '6%'", sqlconn))
        da3.Fill(ds3, "BIAYA")
        GC.DataSource = ds3.Tables("BIAYA")

    End Sub
    Public Sub edit_click()
       
    End Sub
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        'callReport(App_Path() & "\report\rptDPM_J.rpt", "", "Nomor=" & Trim(txtNo.Text))
    End Sub
    Public Sub add_click()
        'STATE = "ADD"
        btnSave = True
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()


    End Sub

 
   
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = True
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            


            For Each rows As DataRow In ds3.Tables("BIAYA").Rows
                If rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("Program_name") = Me.Name
                   
                End If
            Next
        End If



        Try
            Buildernya = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = Buildernya.GetUpdateCommand()
            da3.InsertCommand = Buildernya.GetInsertCommand()
            da3.DeleteCommand = Buildernya.GetDeleteCommand()

          

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS
           

            da3.Update(ds3.Tables("BIAYA"))

            ds3.Tables("BIAYA").AcceptChanges()

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("BIAYA").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub delete_click()
        
    End Sub
 

    Private Sub frmMaintenanceBiayaPerDivisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        connect()

        reload_table("xxx")
        'GC.DataSource = ds3.Tables("BIAYA")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        add_click()
        prn = getParent(Me)
    End Sub
End Class