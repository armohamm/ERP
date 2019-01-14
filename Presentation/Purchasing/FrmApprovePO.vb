'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================


Imports System.Data.SqlClient
Public Class FrmApprovePO
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih As String '<-- untuk mengecek rec_stat saat ini (ADD, EDIT, delete)
    Private dSO, ds_cari, ds1 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DALOOKUP, da_cari As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

        dSO.Clear()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PO where rec_stat <> 'APPROVE' ", sqlconn)) ' where status <> 'APPROVE'
        DA.Fill(dSO, "_ApprvPO")
        GcApprvPO.DataSource = dSO.Tables("_ApprvPO")

        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        Buildernya = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Buildernya.GetUpdateCommand()
        DA.InsertCommand = Buildernya.GetInsertCommand()
        DA.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        For Each rw As DataRow In dSO.Tables("_ApprvPO").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = kdcabang
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name


            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                rw("tgl_approve") = Now
                rw("user_approve") = umum.username
            End If
        Next
        'DA.InsertCommand = builder.GetInsertCommand()
        'DA.UpdateCommand = builder.GetUpdateCommand()
        'DA.DeleteCommand = builder.GetDeleteCommand()
        Try
            DA.Update(dSO, "_ApprvPO")
            dSO.Tables("_ApprvPO").AcceptChanges()
            showMessages("Approval PO berhasil di Update!")
            STATE = "EDIT"
            BTRANS.Commit()
        Catch ex As Exception
            BTRANS.Rollback()
            dSO.Tables("_ApprvPO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

    End Sub

    Private Sub FrmApprovePO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()


        DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PO where rec_stat <> 'APPROVE'", sqlconn)) ' where status <> 'APPROVE'
        DA.Fill(dSO, "_ApprvPO")
        GcApprvPO.DataSource = dSO.Tables("_ApprvPO")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        lookupSupplier.DataSource = ds_cari.Tables("_lookup")
        lookupSupplier.ValueMember = "Kode_Supplier"
        lookupSupplier.DisplayMember = "Nama_Supplier"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()


    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub GvApprvPO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvApprvPO.DoubleClick
        milih = GvApprvPO.GetRow(GvApprvPO.GetSelectedRows(0)).Item(2).ToString()

        'showMessages(milih)
        'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
        'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

        da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
        da_cari.Fill(ds1, "_crpo")

        frmPO.cariPO(milih)
        frmPO.ShowDialog()
    End Sub
End Class