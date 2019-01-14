Imports System.Data.SqlClient
Public Class frmMasterDept
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, DsDept As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA2, DALOOKUP, DAs As SqlClient.SqlDataAdapter
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
    Private Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kd_Departemen,'x1'),4,10) as numeric)) from SIF.DBO.SIF_Departemen", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "DPT001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = "DPT" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
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

    End Sub
    Private Sub clear_field()
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen where 1=0", sqlconn)) '<- query buat ditampilkan di LOV
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_BAGIAN where 1=0", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "DEPT")
        DA2.Fill(dSO, "BAGIAN")
        gc.DataSource = dSO.Tables("BAGIAN")
        AddHandler dSO.Tables("BAGIAN").TableNewRow, New DataTableNewRowEventHandler(AddressOf spd_add)
        AddHandler dSO.Tables("BAGIAN").RowChanged, New DataRowChangeEventHandler(AddressOf row_chg)
        txtKeterangan.Text = ""
        txtKodeDept.Text = ""
        txtNamaDept.Text = ""
        cbStatus.EditValue = vbNullString
    End Sub

    Private Sub spd_add(ByVal sender As Object, ByVal e As DataTableNewRowEventArgs)
        newRow = e.Row
    End Sub

    Private Sub row_chg(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If e.Row.Item("Nama_Bagian").ToString = "" Then
            e.Row.Delete()
        End If
    End Sub
    Private Function getMaxNumberBag() As String
        Dim hasil, temp As String
        'Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kain,'x1'),3,10) as numeric)) from SIF.DBO.SIF_Kain", sqlconn).ExecuteReader
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Bagian,'x1'),1,10)+1 as numeric)) from SIF.DBO.SIF_Bagian", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            ' hasil = "KN" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Private Function getMaxNumberDEP() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kd_Departemen,'x1'),1,10)+1 as numeric)) from SIF.DBO.SIF_Departemen", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            ' hasil = "KN" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Sub tampil_GCDept()
        If Not DsDept.Relations("Detail") Is Nothing Then DsDept.Relations.Clear()
        If Not DsDept.Tables("Bagian") Is Nothing Then DsDept.Tables("Bagian").Clear()
        If Not DsDept.Tables("Departemen") Is Nothing Then DsDept.Tables("Departemen").Clear()

        DAs = New SqlDataAdapter(New SqlCommand("SELECT * from SIF.dbo.SIF_Departemen", sqlconn))
        DAs.Fill(DsDept, "Departemen")
        GcDept.DataSource = DsDept.Tables("Departemen")

        DAs = New SqlDataAdapter(New SqlCommand("SELECT * from SIF.dbo.SIF_Bagian", sqlconn))
        DAs.Fill(DsDept, "Bagian")


        rl = DsDept.Relations.Add("Detail", DsDept.Tables("Departemen").Columns("Kd_Departemen"), DsDept.Tables("Bagian").Columns("Kd_Departemen"), False)

        GcDept.DataSource = DsDept.Tables("Departemen")
        GcDept.LevelTree.Nodes.Add("Detail", GV_Bagian)

    End Sub
    Private Sub frmMasterDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As Object
        connect()
        tampil_GCDept()
        clear_field()
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
        ' bila menggunakan form cari
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dSO.Tables("lookup_Edit") Is Nothing Then dSO.Tables("lookup_Edit").Clear()
        DALOOKUP.Fill(dSO, "lookup_Edit")
        frmCari.set_dso(dSO.Tables("lookup_Edit")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        'If Not frmCari.row Is Nothing Then


        '    reload_table(frmCari.row(0))


        '    STATE = "EDIT"
        '    btnDelete = True
        '    btnSave = True
        '    btnEdit = False
        '    btnadd = False
        '    setStatus()
        'Else
        '    cancel_click()
        '    STATE = ""
        'End If
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            If dSO.Tables("LOOKUP_Edit").Rows.Count > 0 Then
                dSO = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen where Kd_Departemen='" & frmCari.row("Kd_Departemen") & "'", sqlconn)) '<- query buat ditampilkan di LOV
                DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_BAGIAN where Kd_Departemen='" & frmCari.row("Kd_Departemen") & "'", sqlconn)) '<- query buat ditampilkan di LOV

                DA.Fill(dSO, "DEPT")
                txtKodeDept.Text = dSO.Tables("DEPT")(0)("Kd_Departemen")
                txtNamaDept.Text = dSO.Tables("DEPT")(0)("Nama_Departemen")
                txtKeterangan.Text = dSO.Tables("DEPT")(0)("Keterangan").ToString
                cbStatus.Text = IIf(dSO.Tables("DEPT")(0)("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")

                DA2.Fill(dSO, "BAGIAN")
                gc.DataSource = dSO.Tables("BAGIAN")
                STATE = "EDIT"
                prn.btnSave.Enabled = True
                prn.btnCancel.Enabled = True
                prn.btnDelete.Enabled = True
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub
    Public Sub cancel_click()
        clear_field()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        XtraTabControl1.SelectedTabPage = XtraTabPage2
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dSO.Tables("DEPT") Is Nothing Then dSO.Tables("DEPT").Clear()
        If Not dSO.Tables("BAGIAN") Is Nothing Then dSO.Tables("BAGIAN").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen where Kd_Departemen='" & kode & "'", sqlconn))
        DA.Fill(dSO, "DEPT")

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_BAGIAN where Kd_Departemen='" & kode & "'", sqlconn))
        DA2.Fill(dSO, "BAGIAN")
        gc.DataSource = dSO.Tables("BAGIAN")

        If dSO.Tables("DEPT").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean As String
            row = dSO.Tables("DEPT").Rows(0)
            txtKodeDept.Text = row.Item("Kd_Departemen").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            txtNamaDept.Text = row.Item("Nama_Departemen").ToString
            bolean = row.Item("Rec_Stat").ToString
            cbStatus.EditValue = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK")
        End If

    End Sub
    'Public Sub delete_click()
    '    If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        For Each dr As DataRow In dSO.Tables(0).Rows
    '            dr.Delete()
    '        Next
    '        If myDAO.save(dSO, DA, "DELETE") Then
    '            MsgBox("Deleted")
    '            STATE = ""
    '            ' and Do another saved Thing
    '            Clear_ALL()
    '        Else
    '            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
    '            ' klau error disini
    '        End If
    '    End If
    'End Sub
    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            MsgBox(sender.ToString)
            If "" & newRow.Item("Nama_Bagian") = "" Then
                e.SuppressKeyPress = True
            End If
            e = Nothing
        End If
    End Sub
   

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim BTRANS As SqlTransaction


        If Not isDelete Then
            If STATE = "ADD" Then
                row = dSO.Tables("DEPT").NewRow

                row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("Kd_Departemen") = getNoTrans("MDEP", getTanggal)
                txtKodeDept.Text = row.Item("Kd_Departemen")
                row.Item("Nama_Departemen") = txtNamaDept.Text
                row.Item("Keterangan") = txtKeterangan.Text
                row.Item("Rec_Stat") = IIf(cbStatus.EditValue = "AKTIF", "Y", "T")
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Program_Name") = Me.Name
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("DEPT").Rows(0)
                row.Item("Nama_Departemen") = txtNamaDept.Text
                row.Item("Keterangan") = txtKeterangan.Text
                row.Item("Rec_Stat") = IIf(cbStatus.EditValue = "AKTIF", "Y", "T")
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

            If STATE = "ADD" Then
                dSO.Tables("DEPT").Rows.Add(row)
            End If


            For Each rows As DataRow In dSO.Tables("BAGIAN").Rows

                If rows.RowState = DataRowState.Added Then
                    Dim a As String = getNoTrans("MBAG", getTanggal)
                    rows.Item("Kd_Cabang") = kdcabang
                    rows("Kd_Departemen") = row.Item("Kd_Departemen")
                    rows("Kode_Bagian") = a
                    'rows("Nama_Bagian") = row.Item("Nama_Bagian")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Program_Name") = Me.Name
                End If
            Next
        End If
        tampil_GCDept()
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            'DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            'BTRANS = sqlconn.BeginTransaction("1")
            'DA.UpdateCommand.Transaction = BTRANS
            'DA.InsertCommand.Transaction = BTRANS
            'DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("DEPT"))
            DA2.Update(dSO.Tables("BAGIAN"))

            STATE = "EDIT"
            'BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            tampil_GCDept()
            
        Catch e As Exception
            'BTRANS.Rollback()
            dSO.Tables("DEPT").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try


    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_click()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        edit_click()
    End Sub

    Private Sub frmMasterDept_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 0
        pnl.Height = Me.Height
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data  ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("DEPT") Is Nothing Then delete(dSO.Tables("DEPT").Rows)
            If Not dSO.Tables("BAGIAN") Is Nothing Then delete(dSO.Tables("BAGIAN").Rows)


            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub gc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If gv.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    gv.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub


    Private Sub GcDept_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GcDept.DoubleClick
        reload_table(GVApprvDPM.GetRow(GVApprvDPM.GetSelectedRows(0)).item("Kd_Departemen").ToString)
        STATE = "EDIT"
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = True
        prn.btnAdd.Enabled = False
        prn.btnEdit.Enabled = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
    End Sub

  
End Class