'*******************************
' // CREATED BY YAYA         \\
' \\ EDITED BY DIDIER DROGBA //
'*******************************

Imports System.Data.SqlClient

Public Class FrmApprovSupplier1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)

    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow

    Dim dSO, ds1, ds2, ds_klik, dsLOV As New DataSet
    Dim DA, DALOOKUP, DALOOKUP1, da_klik, DAStat As SqlClient.SqlDataAdapter

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

        'DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat <> 'APPROVE' ", sqlconn)) ' where status <> 'APPROVE'
        'DA.Fill(dSO, "_ApSupp")
        'GcSuppPilih.DataSource = dSO.Tables("_ApSupp")

        search()
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

    Private Sub FrmApprovSupplier1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        If Not dSO.Tables("_ApSupp") Is Nothing Then
            dSO.Clear()
        End If

        'DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat <> 'APPROVE'", sqlconn))
        'DA.Fill(dSO, "_ApSupp")
        'GcSuppPilih.DataSource = dSO.Tables("_ApSupp")

        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat = 'ENTRY' and no_csp  not in " & _
         "  (select no_csp " & _
         "  from PURC.dbo.PURC_CHOICE_SUPP csp , PURC.dbo.PURC_PO cpo , PURC.dbo.PURC_PO_D cpod " & _
         "  where  csp.no_pr = cpo.no_pr  " & _
         "  and cpo.no_po = cpod.no_po " & _
         "  and csp.kd_stok = cpod.kd_stok  " & _
         "  and csp.kd_supp_pilih = cpo.kd_supplier ) order by no_csp desc ", sqlconn))
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

        LOVstatus.Properties.NullText = "ENTRY"
        LOVstatus.EditValue = "ENTRY"
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub GvSuppPilih_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvSuppPilih.DoubleClick
        If GvSuppPilih.RowCount <> 0 Then
            'If Not GvSuppPilih.GetRowCellValue(GvSuppPilih.GetSelectedRows(0), "no_csp") Is Nothing Then
            milih = GvSuppPilih.GetRow(GvSuppPilih.GetSelectedRows(0)).Item(1).ToString()

            'MsgBox(milih.ToString)
            'showMessages(milih)
            'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
            'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

            da_klik = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where no_csp='" & milih & "'", sqlconn))
            da_klik.Fill(ds_klik, "_crsup")

            FrmPilihSupplier1.suppleyer(milih)
            FrmPilihSupplier1.ShowDialog()
        End If
    End Sub

    Sub search()

        dSO.Tables("_ApSupp").Clear()

        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where rec_stat = '" & LOVstatus.EditValue & "' and no_csp  not in " & _
         "  (select no_csp " & _
         "  from PURC.dbo.PURC_CHOICE_SUPP csp , PURC.dbo.PURC_PO cpo , PURC.dbo.PURC_PO_D cpod " & _
         "  where  csp.no_pr = cpo.no_pr  " & _
         "  and cpo.no_po = cpod.no_po " & _
         "  and csp.kd_stok = cpod.kd_stok  " & _
         "  and csp.kd_supp_pilih = cpo.kd_supplier and csp.keterangan_barang=cpo.keterangan ) order by no_csp desc ", sqlconn))

        DA.Fill(dSO, "_ApSupp")
        GcSuppPilih.DataSource = dSO.Tables("_ApSupp")

    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        search()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        dSO.Tables("_ApSupp").Clear()

        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where no_csp  not in " & _
        "  (select no_csp " & _
        "  from PURC.dbo.PURC_CHOICE_SUPP csp , PURC.dbo.PURC_PO cpo , PURC.dbo.PURC_PO_D cpod " & _
        "  where  csp.no_pr = cpo.no_pr  " & _
        "  and cpo.no_po = cpod.no_po " & _
        "  and csp.kd_stok = cpod.kd_stok  " & _
        "  and csp.kd_supp_pilih = cpo.kd_supplier ) order by no_csp desc ", sqlconn))

        DA.Fill(dSO, "_ApSupp")
        GcSuppPilih.DataSource = dSO.Tables("_ApSupp")

    End Sub

    Private Sub LOVstatus_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LOVstatus.QueryPopUp
        dsLOV.Clear()

        DAStat = New SqlDataAdapter(New SqlCommand("select distinct (rec_stat) from PURC.dbo.PURC_CHOICE_SUPP ", sqlconn))
        DAStat.Fill(dsLOV, "stat")
        LOVstatus.Properties.DataSource = dsLOV.Tables("stat")
        LOVstatus.Properties.ValueMember = "rec_stat"
        LOVstatus.Properties.DisplayMember = "rec_stat"
    End Sub

    Private Sub LOVstatus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVstatus.EditValueChanged
        search()
    End Sub
End Class