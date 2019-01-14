'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

'this is was succes Tested in Form Main BG! (sudah di tes run lewat form utama)
'Note ada perubahan major code,query,gv di BOM dan BOM_Detail karena ada perubahan data,
'jika ingin menggandakan, gunakan kopas ke form baru, jangan save as menyebabkan error designer.vb
'jika ingin load dari Form utama BG, aktifkan "prn = getParent(Me)" Load events



Imports System.Data.SqlClient

Public Class frmMstBOM
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dso1, ds_cari As New DataSet
    Dim Bulder As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DALOOKUP, DALOOKUP2 As SqlClient.SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add

        bersihkan()
        enabel()
        GvMstBOM_d.Columns("kd_bom").Visible = False
    End Sub

    Public Sub cancel_click()
        If MsgBox("Form akan di bersihkan dan mulai dari awal lagi??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
        btnstart()
    End Sub


    Public Sub edit_click()
      
        STATE = "EDIT"
        enabel()
        edit_klik()
        btnadd = False
        btnSave = True
        btnDelete = True
        setStatus()
    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        bersihkan()
        btnstart()
    End Sub


    Public Sub edit_klik()
        dSO = New DataSet
        DA = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom", sqlconn))
        DA.Fill(dSO, "_bom")
        frmCari.set_dso(dSO.Tables("_bom"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txbKdBOM.Text = frmCari.row("kd_BOM").ToString
            txbNamaBOM.Text = frmCari.row("nama_BOM").ToString
            txbNoDocBOM.Text = frmCari.row("no_dokumen_BOM").ToString
            txbJenisBOM.Text = frmCari.row("jenis_BOM").ToString
            rtbKet.Text = frmCari.row("keterangan").ToString
            cbStatus.Text = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "NonAKTIF")
        End If

        dso1 = New DataSet
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_bom_d where kd_BOM='" & txbKdBOM.Text & "'", sqlconn))
        DALOOKUP2.Fill(dso1, "_bom_d")
        GcMstBOM_d.DataSource = dso1.Tables("_bom_d")
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            row("no_urut") = i
            i += 1
        Next
    End Sub

    Private Sub GvMstBOM_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        GvMstBOM_d.GetRow(e.RowHandle).item("no_urut") = GvMstBOM_d.RowCount + 1
    End Sub

    Public Sub hapus_record()

    End Sub


    Private Sub frmMstBOM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()

        prn = getParent(Me)      '''' <========aktifkan ini, jika load dari form login utama
        form_utama()             ''''<== aktifkan ini juga jika load dari form login utama

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_bom where 1=0", sqlconn))
        DA.Fill(dSO, "_bom")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        DA2.Fill(dso1, "_bom_d")
        GcMstBOM_d.DataSource = dso1.Tables("_bom_d")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupBrg.DataSource = ds_cari.Tables("_lookup1")
        LookupBrg.ValueMember = "Kode_Barang"
        LookupBrg.DisplayMember = "Nama_Barang"
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        Bulder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Bulder.GetUpdateCommand()
        DA.InsertCommand = Bulder.GetInsertCommand()
        DA.DeleteCommand = Bulder.GetDeleteCommand()

        Bulder = New SqlClient.SqlCommandBuilder(DA2)
        DA2.UpdateCommand = Bulder.GetUpdateCommand()
        DA2.InsertCommand = Bulder.GetInsertCommand()
        DA2.DeleteCommand = Bulder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DA2.UpdateCommand.Transaction = BTRANS
        DA2.InsertCommand.Transaction = BTRANS
        DA2.DeleteCommand.Transaction = BTRANS

        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bom").NewRow
            row.Item("last_create_date") = Now
            row.Item("last_created_by") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bom").Rows(0)
            row.Item("last_update_date") = Now
            row.Item("last_updated_by") = username
        End If
        row.Item("kd_cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("kd_BOM") = txbKdBOM.Text
        row.Item("nama_BOM") = txbNamaBOM.Text
        row.Item("no_dokumen_BOM") = txbNoDocBOM.Text
        row.Item("jenis_bom") = txbJenisBOM.Text
        row.Item("keterangan") = rtbKet.Text
        row.Item("rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
        row.Item("program_name") = Me.Name

        If STATE = "ADD" Then
            dSO.Tables("_bom").Rows.Add(row)
        End If
        For Each rows As DataRow In dso1.Tables("_bom_d").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("kd_BOM") = row.Item("kd_BOM")
                rows.Item("last_create_date") = Now
                rows.Item("last_created_by") = username
                rows.Item("kd_cabang") = "1"
            Else
                rows.Item("last_update_date") = Now
                rows.Item("last_updated_by") = username
            End If
            rows.Item("program_name") = Me.Name

        Next

        Try

            DA.Update(dSO.Tables("_bom"))
            DA2.Update(dso1.Tables("_bom_d"))

            dSO.Tables("_bom").AcceptChanges()
            dso1.Tables("_bom_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan...")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bom").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub


    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        enabel()
        btnDel.Enabled = True
        'GvMstBOM_d.Columns("kd_BOM").Visible = True
        edit_klik()
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        If MsgBox("Form akan di bersihkan dan mulai dari awal lagi??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
        btnstart()
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        bersihkan()
        enabel()
        STATE = "ADD"
        GvMstBOM_d.Columns("kd_bom").Visible = False
        btEdit.Enabled = False
        btSave.Enabled = True
    End Sub


    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        bersihkan()
        btnstart()
    End Sub

    Public Sub btnstart()
        btAdd.Enabled = True
        btEdit.Enabled = True
        btSave.Enabled = False
        btnDel.Enabled = False
    End Sub

    Public Sub bersihkan()
        txbJenisBOM.Text = ""
        txbKdBOM.Text = ""
        txbNamaBOM.Text = ""
        txbNoDocBOM.Text = ""
        rtbKet.Text = ""
        dso1.Clear()
    End Sub

    Public Sub enabel()
        txbKdBOM.Enabled = True
        txbJenisBOM.Enabled = True
        txbNamaBOM.Enabled = True
        txbNoDocBOM.Enabled = True
        btSave.Enabled = True
    End Sub

    Public Sub disabel()
        txbKdBOM.Enabled = False
        txbJenisBOM.Enabled = False
        txbNamaBOM.Enabled = False
        txbNoDocBOM.Enabled = False
    End Sub

    Public Sub form_utama()
        btAdd.Hide()
        btCancel.Hide()
        btEdit.Hide()
        btnDel.Hide()
        btSave.Hide()
        btnExit.Hide()
    End Sub

    'Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    bersihkan()
    '    btnstart()
    'End Sub

    'Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    '    btnstart()
    'End Sub

    'Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    '    bersihkan()
    '    btnstart()
    'End Sub

    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bersihkan()
    '    STATE = "EDIT"
    '    edit_klik()
    'End Sub

    'Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bersihkan()
    '    STATE = "ADD"
    'End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub


End Class