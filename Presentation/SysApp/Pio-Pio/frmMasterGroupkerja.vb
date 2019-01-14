Imports System.Data.SqlClient
Public Class frmMasterGroupkerja
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public uq, kdkeg, keg, groupker, kdmesin As String
    Dim dSO, Dsgroup, Dsgroup1, Dsgroup2 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA2, DALOOKUP, DAs, das1, da3 As SqlClient.SqlDataAdapter
    Dim newRow As DataRow
    Dim myBuilder, myBuilder2, Buildernya As New SqlClient.SqlCommandBuilder
    Dim rl As DataRelation
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
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        STATE = "ADD" '<-- set state add
        btnSave = True
        btnCancel = True
        btnEdit = False
        btnadd = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        setStatus()
        cmdSave.Visible = True
       

    End Sub
    Private Sub clear_field()
       
       
    End Sub

 
   

    Sub tampil_GCgroup()

        If Not Dsgroup.Tables("Group") Is Nothing Then Dsgroup.Clear()


        DAs = New SqlDataAdapter(New SqlCommand("SELECT " & _
  "a.group_kerja group_kerja, " & _
  "a.kd_pegawai kd_pegawai, " & _
  "b.Desc_Data Desc_Data, " & _
        "c.Nama_Pegawai Nama_Pegawai " & _
        "FROM " & _
        "PROD.dbo.PROD_rls_spk_man_p a " & _
  "LEFT OUTER JOIN SIF.dbo.SIF_Gen_Reff_D b ON (a.group_kerja = b.Id_Data) " & _
  "left join SIF.dbo.SIF_Pegawai c on (c.Kode_Pegawai=a.kd_pegawai) " & _
        "WHERE " & _
  "b.id_ref_file = 'GRPKERJA'", sqlconn))
        DAs.Fill(Dsgroup, "Group")
        GcDept.DataSource = Dsgroup.Tables("Group")

    End Sub
    Sub LOKUP()
        If Not Dsgroup1.Tables("grpeg") Is Nothing Then Dsgroup1.Tables("grpeg").Clear()


        das1 = New SqlDataAdapter(New SqlCommand("SELECT Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        das1.Fill(Dsgroup1, "grpeg")
        RepositoryItemLookUpEdit1.DataSource = Dsgroup1.Tables("grpeg")
        RepositoryItemLookUpEdit1.ValueMember = "kd_pegawai"
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Pegawai"

       


    End Sub
    Private Sub frmMasterGroupkerja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As Object
        connect()
        prn = getParent(Me)
        tampil_GCgroup()
        LOKUP()

        If Not Dsgroup.Tables("master") Is Nothing Then Dsgroup.Clear()
        DA = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rls_spk_man_p", sqlconn))
        DA.Fill(Dsgroup, "master")
        gc.DataSource = Dsgroup.Tables("master")

        'myBuilder = New SqlClient.SqlCommandBuilder(DA)
        'DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana

        'myBuilder2 = New SqlClient.SqlCommandBuilder(DA2)
        'DA2.UpdateCommand = myBuilder2.GetUpdateCommand()
        'Me.BackgroundImage = Parent.BackgroundImage
        obj = getParent(Me)
        prn = obj
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        Me.Enabled = True
    End Sub


    Public Sub edit_click()
        '    ' bila menggunakan form cari
        '    DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        '    If Not dSO.Tables("lookup_Edit") Is Nothing Then dSO.Tables("lookup_Edit").Clear()
        '    DALOOKUP.Fill(dSO, "lookup_Edit")
        '    frmCari.set_dso(dSO.Tables("lookup_Edit")) '<-- memparsing hasil dataset ke LOV
        '    frmCari.ShowDialog() '<-- menampilkan form LOV

        '    'If Not frmCari.row Is Nothing Then


        '    '    reload_table(frmCari.row(0))


        '    '    STATE = "EDIT"
        '    '    btnDelete = True
        '    '    btnSave = True
        '    '    btnEdit = False
        '    '    btnadd = False
        '    '    setStatus()
        '    'Else
        '    '    cancel_click()
        '    '    STATE = ""
        '    'End If
        '    If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
        '        If dSO.Tables("LOOKUP_Edit").Rows.Count > 0 Then
        '            dSO = New DataSet
        '            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen where Kd_Departemen='" & frmCari.row("Kd_Departemen") & "'", sqlconn)) '<- query buat ditampilkan di LOV
        '            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_BAGIAN where Kd_Departemen='" & frmCari.row("Kd_Departemen") & "'", sqlconn)) '<- query buat ditampilkan di LOV

        '            DA.Fill(dSO, "DEPT")


        '            DA2.Fill(dSO, "BAGIAN")
        '            gc.DataSource = dSO.Tables("BAGIAN")
        '            STATE = "EDIT"
        '            prn.btnSave.Enabled = True
        '            prn.btnCancel.Enabled = True
        '            prn.btnDelete.Enabled = True
        '            XtraTabControl1.SelectedTabPage = XtraTabPage1
        '        Else
        '            MsgBox("Data tidak diketemukan")
        '        End If
        '    End If
        'End Sub
        'Public Sub cancel_click()
        '    clear_field()
        '    btnSave = False
        '    btnCancel = False
        '    btnDelete = False
        '    btnEdit = True
        '    btnadd = True
        '    setStatus()
        '    XtraTabControl1.SelectedTabPage = XtraTabPage2
        'End Sub

        'Private Sub reload_table(ByVal kode As String)
        '    If Not dSO.Tables("DEPT") Is Nothing Then dSO.Tables("DEPT").Clear()
        '    If Not dSO.Tables("BAGIAN") Is Nothing Then dSO.Tables("BAGIAN").Clear()

        '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen where Kd_Departemen='" & kode & "'", sqlconn))
        '    DA.Fill(dSO, "DEPT")

        '    DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_BAGIAN where Kd_Departemen='" & kode & "'", sqlconn))
        '    DA2.Fill(dSO, "BAGIAN")
        '    gc.DataSource = dSO.Tables("BAGIAN")

        '    If dSO.Tables("DEPT").Rows.Count > 0 Then
        '        Dim row As DataRow
        '        Dim bolean As String
        '        row = dSO.Tables("DEPT").Rows(0)


        '    End If

        'End Sub
        ''Public Sub delete_click()
        ''    If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        ''        For Each dr As DataRow In dSO.Tables(0).Rows
        ''            dr.Delete()
        ''        Next
        ''        If myDAO.save(dSO, DA, "DELETE") Then
        ''            MsgBox("Deleted")
        ''            STATE = ""
        ''            ' and Do another saved Thing
        ''            Clear_ALL()
        ''        Else
        ''            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
        ''            ' klau error disini
        ''        End If
        ''    End If
        ''End Sub
        'Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '    If e.KeyCode = Keys.Down Then
        '        MsgBox(sender.ToString)
        '        If "" & newRow.Item("Nama_Bagian") = "" Then
        '            e.SuppressKeyPress = True
        '        End If
        '        e = Nothing
        '    End If
    End Sub


    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim BTRANS As SqlTransaction
        Dim tgl As Date = getTanggal()

        If Not isDelete Then
            'If STATE = "ADD" Then
            '    row = dSO.Tables("DEPT").NewRow

            '    row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            '    row.Item("Kd_Departemen") = getNoTrans("MDEP", getTanggal)


            '    row.Item("Last_Create_Date") = Now
            '    row.Item("Last_Created_By") = username
            '    row.Item("Program_Name") = Me.Name
            'ElseIf STATE = "EDIT" Then
            '    row = dSO.Tables("DEPT").Rows(0)

            '    row.Item("Last_Update_Date") = Now
            '    row.Item("Last_Updated_By") = username
            'End If

            'If STATE = "ADD" Then
            '    dSO.Tables("DEPT").Rows.Add(row)
            'End If

            Dim notrans As String
            notrans = getNoTrans("PRODSPKRLS", tgl)
            frmzRlsSpkInsentif.notrans1 = notrans
            For Each rows As DataRow In Dsgroup.Tables("master").Rows

                If rows.RowState = DataRowState.Added Then
                   
                    frmzRlsSpkInsentif.notrans1 = notrans
                    rows("no_spk_man") = uq
                    rows("no_spk_man_rls") = notrans
                    rows("kd_kegiatan") = kdkeg
                    rows("kd_kegiatan_spk") = keg
                    rows("no_spk_man_rls") = notrans
                    rows("tanggal") = tgl
                    rows("group_kerja") = groupker
                    rows("kd_mesin") = kdmesin

                    rows.Item("Kd_Cabang") = kdcabang
                    rows("Kd_Departemen") = kddep
                    rows("kd_pegawai") = rows.Item("kd_pegawai").ToString
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Program_Name") = Me.Name
                End If
            Next
        End If

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DAs)
            DAs.UpdateCommand = Buildernya.GetUpdateCommand()
            DAs.InsertCommand = Buildernya.GetInsertCommand()
            'DA.DeleteCommand = Buildernya.GetDeleteCommand()

           
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            'BTRANS = sqlconn.BeginTransaction("1")
            'DA.UpdateCommand.Transaction = BTRANS
            'DA.InsertCommand.Transaction = BTRANS
            'DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            DAs.Update(Dsgroup.Tables("MASTER"))


            STATE = "EDIT"
            'BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            If Not Dsgroup.Tables("detil") Is Nothing Then Dsgroup2.Clear()
            da3 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rls_spk_man_p", sqlconn))
            da3.Fill(Dsgroup2, "detil")
            GcDept.DataSource = Dsgroup2.Tables("detil")

        Catch e As Exception
            'BTRANS.Rollback()
            Dsgroup.Tables("MASTER").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try


    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cancel_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'edit_click()
    End Sub

    Private Sub frmMasterDept_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 0
        pnl.Height = Me.Height
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data  ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not Dsgroup.Tables("Master") Is Nothing Then delete(Dsgroup.Tables("master").Rows)

            save_click(True)
            'cancel_click()
            STATE = ""

        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    'Private Sub gc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Delete Then
    '        If gv.GetSelectedRows.Count > 0 Then
    '            If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
    '                gv.DeleteSelectedRows()
    '            End If
    '        End If
    '    End If
    'End Sub


    'Private Sub GcD_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GcDept.DoubleClick
    '    'reload_table(GVApprvGroup.GetRow(GVApprvGroup.GetSelectedRows(0)).item("Kd_Departemen").ToString)
    '    STATE = "EDIT"
    '    prn.btnSave.Enabled = True
    '    prn.btnCancel.Enabled = True
    '    prn.btnDelete.Enabled = True
    '    prn.btnAdd.Enabled = False
    '    prn.btnEdit.Enabled = False
    '    XtraTabControl1.SelectedTabPage = XtraTabPage1
    'End Sub


    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub
End Class