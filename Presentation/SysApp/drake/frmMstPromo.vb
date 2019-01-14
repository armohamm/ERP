'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMstPromo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, ds_cari, ds_cari1 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub enabel()
        txbKdDept.Enabled = True
        'txbNoPromo.Enabled = True
        txbNamaPromo.Enabled = True
        dtpStart.Enabled = True
        dtpEnd.Enabled = True
        rtbKet.Enabled = True
        cbStat.Enabled = True
        btnCrDept.Enabled = True
        'btnCrPromo.Enabled = True
    End Sub

    Public Sub btnstart()
        btAdd.Enabled = True
        btEdit.Enabled = True
        btnSimpan.Enabled = False
        btnDel.Enabled = False
    End Sub
    Public Sub disabel()
        txbKdDept.Enabled = False
        txbNoPromo.Enabled = False
        txbNamaPromo.Enabled = False
        rtbKet.Enabled = False
        cbStat.Enabled = False
        dtpEnd.Enabled = False
        dtpStart.Enabled = False
        btnCrDept.Enabled = False
        'btnCrPromo.Enabled = False
        btnSimpan.Enabled = False
        btnDel.Enabled = False
    End Sub

    Public Sub bersihkan()
        txbKdDept.Text = ""
        txbNoPromo.Text = ""
        txbNamaPromo.Text = ""
        rtbKet.Text = ""
        cbStat.Text = ""
        dtpEnd.Text = ""
        dtpStart.Text = ""
        'GcMstPromo_d.DataSource = Nothing
        'GcMstPromo_d.DataBindings
        dSO1.Clear()
     

    End Sub

    Public Function getNextNumber(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(no_promo,'x1'),4,10) as numeric)) from SIF.dbo.SIF_Promo", sqlconn, bgtrans).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "PRM000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "PRM" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
   
    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        Buildernya = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Buildernya.GetUpdateCommand()
        DA.InsertCommand = Buildernya.GetInsertCommand()
        DA.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(DA2)
        DA2.UpdateCommand = Buildernya.GetUpdateCommand()
        DA2.InsertCommand = Buildernya.GetInsertCommand()
        DA2.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DA2.UpdateCommand.Transaction = BTRANS
        DA2.InsertCommand.Transaction = BTRANS
        DA2.DeleteCommand.Transaction = BTRANS

        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_promo").NewRow
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_promo").Rows(0)
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("no_promo") = getNextNumber(BTRANS)
        row.Item("kd_dept") = txbKdDept.Text
        row.Item("start_date") = dtpStart.Text
        row.Item("end_date") = dtpEnd.Text
        row.Item("Keterangan") = rtbKet.Text
        row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("Program_Name") = Me.Name
        txbNoPromo.Text = row.Item("no_promo")
        If STATE = "ADD" Then
            dSO.Tables("_promo").Rows.Add(row)
        End If
        For Each rows As DataRow In dSO1.Tables("_promo_d").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("no_promo") = row.Item("no_promo")
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = "1"
            Else
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
            End If
            rows.Item("Program_name") = Me.Name

        Next

        Try

            DA.Update(dSO.Tables("_promo"))
            DA2.Update(dSO1.Tables("_promo_d"))

            dSO.Tables("_promo").AcceptChanges()
            dSO1.Tables("_promo_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_promo").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub hapus_record()
        ''Dim row = dSO.Tables("_promo").Rows
        'row.Delete()
        'DA.UpdateCommand = Buildernya.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
        'DA.Update(dSO.Tables("_promo"))
        'dSO.Tables("_promo").AcceptChanges()
    End Sub
    

    Public Sub edit_klik()
        dSO = New DataSet
        dso1 = New DataSet
      
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Promo", sqlconn))
        DALOOKUP2.Fill(dSO, "_LookupPromo")
        frmCari.set_dso(dSO.Tables("_LookupPromo"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txbKdDept.Text = frmCari.row("kd_dept")
            txbNoPromo.Text = frmCari.row("no_promo").ToString
            txbNamaPromo.Text = frmCari.row("nama_promo").ToString
            rtbKet.Text = frmCari.row("Keterangan").ToString
            cbStat.Text = IIf(frmCari.row("Rec_Stat") = "Y", "AKTIF", "NonAKTIF")
        End If

        'utk master detail
        dSO1 = New DataSet
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Promo_d where no_promo='" & txbNoPromo.Text & "'", sqlconn))
        DALOOKUP2.Fill(dSO1, "_promo_d")
        GcMstPromo_d.DataSource = dSO1.Tables("_promo_d")

    End Sub

   

    Private Sub frmMstPromo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()
        'dSO1 = New DataSet
        'dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Promo where 1=0", sqlconn))
        DA.Fill(dSO, "_promo")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Promo_d where 1=0", sqlconn))
        DA2.Fill(dSO1, "_promo_d")
        GcMstPromo_d.DataSource = dSO1.Tables("_promo_d")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Merk", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupMerk.DataSource = ds_cari.Tables("_lookup1")
        LookupMerk.ValueMember = "Kode_Merk"
        LookupMerk.DisplayMember = "Nama_Merk"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Tipe", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupTipe.DataSource = ds_cari1.Tables("_lookup2")
        LookupTipe.ValueMember = "Kode_Tipe"
        LookupTipe.DisplayMember = "Nama_Tipe"

        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        btnstart()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
        hapus_record()
        btnstart()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
        btnstart()
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        bersihkan()
        enabel()
        btEdit.Enabled = False
        btnSimpan.Enabled = True
        STATE = "ADD"
        GvMstPromo_d.Columns("no_seq").Visible = False
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        enabel()
        btnDel.Enabled = True
        btnSimpan.Enabled = True
        STATE = "EDIT"
        GvMstPromo_d.Columns("no_seq").Visible = True
        edit_klik()
    End Sub

    Private Sub btnCrDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrDept.Click
        DALOOKUP = New SqlDataAdapter
        ds_cari = New DataSet
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(ds_cari, "_dept")
        frmCari.set_dso(ds_cari.Tables("_dept"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            txbKdDept.Text = frmCari.row("Kd_Departemen")
        End If
        txbNamaPromo.Focus()
    End Sub

    'Public Sub hapus_detil()
    '    'Dim builder As New SqlCommandBuilder(DA)
    '    Dim row As DataRow
    '    Dim rows() As DataRow
    '    Dim i As Integer

    '    ReDim rows(GvMstPromo_d.SelectedRowsCount - 1)
    '    For i = 0 To GvMstPromo_d.SelectedRowsCount - 1
    '        rows(i) = GvMstPromo_d.GetDataRow(GvMstPromo_d.GetSelectedRows(i))
    '    Next
    '    GvMstPromo_d.BeginSort()
    '    Try
    '        For Each row In rows
    '            row.Delete()
    '        Next
    '    Finally
    '        GvMstPromo_d.EndSort()
    '    End Try
    '    simpan()
    'End Sub

    'Private Sub btnCrPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DALOOKUP = New SqlDataAdapter
    '    ds_cari = New DataSet
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("select"))
    'End Sub


    'Public Sub simpan1()
    '    '//menyimpan data header texbox atas
    '    If STATE = "ADD" Then

    '        Dim bulder As New SqlCommandBuilder(DA)
    '        dSO = New DataSet
    '        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Promo where 1=0", sqlconn))
    '        DA.Fill(dSO, "_promo")
    '        row = dSO.Tables("_promo").NewRow
    '        row.Item("Kd_Cabang") = 1
    '        row.Item("kd_dept") = txbKdDept.Text
    '        row.Item("no_promo") = txbNoPromo.Text
    '        row("nama_promo") = txbNamaPromo.Text
    '        row("Keterangan") = rtbKet.Text
    '        row("start_date") = dtpStart.Text
    '        row("end_date") = dtpEnd.Text

    '        row("Last_Create_Date") = Now
    '        row("Last_Created_By") = umum.username
    '        row("Last_Update_Date") = Now
    '        row("Last_Updated_By") = umum.username
    '        row("Program_Name") = Me.Name
    '        DA.InsertCommand = bulder.GetInsertCommand()
    '        DA.UpdateCommand = bulder.GetUpdateCommand()
    '        DA.DeleteCommand = bulder.GetDeleteCommand()
    '        DA.Update(dSO, "_promo")
    '        dSO.Tables("_promo").AcceptChanges()
    '    ElseIf STATE = "EDIT" Then
    '        row = dSO.Tables("SIF_SALES").Rows(0)
    '        row.Item("kd_dept") = txbKdDept.Text
    '        row.Item("no_promo") = txbNoPromo.Text
    '        row("nama_promo") = txbNamaPromo.Text
    '        row("Keterangan") = rtbKet.Text
    '        row("start_date") = dtpStart.Text
    '        row("end_date") = dtpEnd.Text
    '        row = dSO.Tables("_promo").Rows(0)
    '        row("Last_Update_Date") = Now
    '        row("Last_Updated_By") = umum.username
    '        row("Program_Name") = Me.Name
    '    End If
    '    dSO.Tables("_promo").Rows.Add(row)


    '    '//// Menyimpan detail (grid)
    '    Dim builder As New SqlCommandBuilder(DA2)
    '    For Each rw As DataRow In dSO1.Tables("_promo_d").Rows
    '        If rw.RowState = DataRowState.Added Then
    '            rw("Kd_Cabang") = 1
    '            rw("Last_Create_Date") = Now
    '            rw("Last_Created_By") = umum.username
    '            rw("Program_Name") = Me.Name
    '        ElseIf rw.RowState = DataRowState.Modified Then
    '            rw.Item("Last_Update_Date") = Now
    '            rw.Item("Last_Updated_By") = username
    '        End If
    '    Next
    '    DA2.InsertCommand = builder.GetInsertCommand()
    '    DA2.UpdateCommand = builder.GetUpdateCommand()
    '    DA2.DeleteCommand = builder.GetDeleteCommand()
    '    DA2.Update(dSO1, "_promo_d")
    '    dSO1.Tables("_promo_d").AcceptChanges()
    'End Sub
End Class