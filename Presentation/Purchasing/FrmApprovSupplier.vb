'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================


Imports System.Data.SqlClient

Public Class FrmApprovSupplier
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, ds1, ds2, ds_klik As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, da_klik As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add
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

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        dSO.Clear()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat <> 'APPROVE' ", sqlconn)) ' where status <> 'APPROVE'
        DA.Fill(dSO, "_ApSupp")
        GcSuppPilih.DataSource = dSO.Tables("_ApSupp")
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

        For Each rw As DataRow In dSO.Tables("_ApSupp").Rows
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
            DA.Update(dSO, "_ApSupp")
            dSO.Tables("_ApSupp").AcceptChanges()
            showMessages("Approval Supplier berhasil di Update!")
            STATE = "EDIT"
            BTRANS.Commit()
        Catch ex As Exception
            BTRANS.Rollback()
            dSO.Tables("_ApSupp").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
        
    End Sub

    Private Sub FrmApprovSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        If Not dSO.Tables("_ApSupp") Is Nothing Then
            dSO.Clear()
        End If

        DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat <> 'APPROVE'", sqlconn))
        DA.Fill(dSO, "_ApSupp")
        GcSuppPilih.DataSource = dSO.Tables("_ApSupp")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds1, "_lookup")
        LookupSupplier.DataSource = ds1.Tables("_lookup")
        LookupSupplier.ValueMember = "Kode_Supplier"
        LookupSupplier.DisplayMember = "Nama_Supplier"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP1.Fill(ds2, "_lookup1")
        lookupBarang.DataSource = ds2.Tables("_lookup1")
        lookupBarang.ValueMember = "Kode_Barang"
        lookupBarang.DisplayMember = "Nama_Barang"
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub GvSuppPilih_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvSuppPilih.DoubleClick

        milih = GvSuppPilih.GetRow(GvSuppPilih.GetSelectedRows(0)).Item(1).ToString()

        'MsgBox(milih.ToString)
        'showMessages(milih)
        'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
        'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

        da_klik = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where no_csp='" & milih & "'", sqlconn))
        da_klik.Fill(ds_klik, "_crsup")

        FrmPilihSupplier1.suppleyer(milih)
        FrmPilihSupplier1.ShowDialog()
    End Sub
End Class