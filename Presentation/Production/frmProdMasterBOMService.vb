Imports System.Data.SqlClient
Public Class frmProdMasterBOMService
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle As Integer
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_service KODE, nama_service NAMA,  no_dokumen [NO DOKUMEN], last_update_date TANGGAL from SIF.dbo.SIF_bom_service order by nama_service", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        da1.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'txtRevisi.Text = frmCari.row("REVISI")
            'txtBOM.EditValue = frmCari.row("KODE")
            reload(frmCari.row("KODE").ToString)
            State = "EDIT"
            txt_kdService.Properties.ReadOnly = True
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub
    Public Sub reload(ByVal kdbomservice As String)
        'If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        'If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        'da2.Fill(ds1, "dtlBOM")
        'GC.DataSource = ds1.Tables("dtlBOM")

        GV_BahanService.OptionsView.NewItemRowPosition = 1
        If Not ds1.Tables("BOM_SERVICE") Is Nothing Then ds1.Tables("BOM_SERVICE").Clear()
        If Not ds1.Tables("dtlBOM_BIAYA") Is Nothing Then ds1.Tables("dtlBOM_BIAYA").Clear()
        If Not ds1.Tables("dtlBOMBahan") Is Nothing Then ds1.Tables("dtlBOMBahan").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_service where kd_service='" & kdbomservice & "'", sqlconn))
        da4.Fill(ds1, "BOM_SERVICE")
        If ds1.Tables("BOM_SERVICE").Rows.Count > 0 Then
            row = ds1.Tables("BOM_SERVICE").Rows(0)
            txt_waktu.Text = row.Item("waktu")
            txtNoDokBOM.Text = row.Item("no_dokumen")
            txt_kdService.Text = row.Item("kd_service")
            Txt_namaService.Text = row.Item("nama_service")


            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_bom_service_biaya where kd_service= '" & kdbomservice & "'", sqlconn))
            da3.Fill(ds1, "dtlBOM_BIAYA")
            GC_Biaya.DataSource = ds1.Tables("dtlBOM_BIAYA")

            da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_service_bahan where kd_service= '" & kdbomservice & "'", sqlconn))
            da2.Fill(ds1, "dtlBOMBahan")
            GC_Bahan.DataSource = ds1.Tables("dtlBOMBahan")
        Else
            showMessages("Tidak ada data" & txt_kdService.Text)
        End If


    End Sub
    Sub LoadGCBiaya()
        If Not ds1.Tables("Biaya") Is Nothing Then ds1.Tables("Biaya").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar order by nm_buku_besar", sqlconn))
        da1.Fill(ds1, "Biaya")
        LEBiaya.DataSource = ds1.Tables("Biaya")
        LEBiaya.ValueMember = "kd_buku_besar"
        LEBiaya.DisplayMember = "nm_buku_besar"

        If Not ds1.Tables("dtlBOM_BIAYA") Is Nothing Then ds1.Tables("dtlBOM_BIAYA").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_bom_service_biaya where 1=0 ", sqlconn))
        da3.Fill(ds1, "dtlBOM_BIAYA")
        GC_Biaya.DataSource = ds1.Tables("dtlBOM_BIAYA")
    End Sub



    Sub LoadBahan()
        If Not ds1.Tables("BOM_SERVICE") Is Nothing Then ds1.Tables("BOM_SERVICE").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_service where 1=0 ", sqlconn))
        da4.Fill(ds1, "BOM_SERVICE")

        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, kd_jenis from SIF.dbo.SIF_Barang order by Nama_Barang", sqlconn))
        da1.Fill(ds1, "Barang")
        LE_Barang.DataSource = ds1.Tables("Barang")
        LE_Barang.ValueMember = "Kode_Barang"
        LE_Barang.DisplayMember = "Nama_Barang"

        If Not ds1.Tables("dtlBOMBahan") Is Nothing Then ds1.Tables("dtlBOMBahan").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_service_bahan where 1=0", sqlconn))
        da2.Fill(ds1, "dtlBOMBahan")
        GC_Bahan.DataSource = ds1.Tables("dtlBOMBahan")

    End Sub

    Private Sub frmProdMasterBOMService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
       
        LoadBahan()
        LoadGCBiaya()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        LoadBahan()
        LoadGCBiaya()
        'reload()
    End Sub

    Public Sub cancel_click()
        State = "CANCEL"
        Txt_namaService.EditValue = Nothing
        txt_kdService.EditValue = Nothing
        txt_kdService.Properties.ReadOnly = False
        txtNoDokBOM.Text = ""
        txt_waktu.Text = 0

        'GV_BahanService.OptionsView.NewItemRowPosition = 0
        'GC_Bahan.DataSource = Nothing
        'GV_BIAYA.OptionsView.NewItemRowPosition = 0
        'GC_Biaya.DataSource = Nothing

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_BahanService_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_BahanService.CellValueChanged
        If e.Column.ToString = "Nama Barang" Then

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan " & _
                                                                   "from SIF.dbo.SIF_Barang B " & _
                                                                   "left join SIF.dbo.SIF_Satuan S " & _
                                                                   "on B.Kd_Satuan=S.Kode_Satuan " & _
                                                                   "where B.Kode_Barang = '" & e.Value.ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            GC_Bahan.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
            dr.Close()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim notrans As String
        Dim tgl As Date = getTanggal()

        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If State = "ADD" Then

                row = ds1.Tables("BOM_SERVICE").NewRow
                row.Item("kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("kd_departemen") = kddep
                row.Item("kd_service") = notrans
                row.Item("nama_service") = Txt_namaService.Text
                row.Item("no_dokumen") = txtNoDokBOM.Text
                row.Item("waktu") = txt_waktu.Text
                row.Item("keterangan") = txt_waktu.Text
                row.Item("rec_stat") = "Y"
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf State = "EDIT" Then
                row = ds1.Tables("BOM_SERVICE").Rows(0)
                row.Item("nama_service") = Txt_namaService.Text
                row.Item("waktu") = txt_waktu.Text
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If


            If State = "ADD" Then
                ds1.Tables("BOM_SERVICE").Rows.Add(row)
            End If

            For Each rows As DataRow In ds1.Tables("dtlBOMBahan").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("kd_departemen") = kddep
                    rows.Item("kd_service") = row.Item("kd_service")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("Program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
            Next


            For Each rows1 As DataRow In ds1.Tables("dtlBOM_BIAYA").Rows
                If rows1.RowState = DataRowState.Added Then
                    rows1.Item("kd_cabang") = kdcabang
                    rows1.Item("kd_departemen") = kddep
                    rows1.Item("kd_service") = row.Item("kd_service")
                    rows1.Item("Last_Create_Date") = Now
                    rows1.Item("Last_Created_By") = username
                    rows1.Item("Program_name") = Me.Name
                ElseIf Not rows1.RowState = DataRowState.Deleted Then
                    rows1.Item("Last_Update_Date") = Now
                    rows1.Item("Last_Updated_By") = username
                End If
            Next
        End If

        mb = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = mb.GetUpdateCommand()
        da4.InsertCommand = mb.GetInsertCommand()
        da4.DeleteCommand = mb.GetDeleteCommand()

        mb = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = mb.GetUpdateCommand()
        da3.InsertCommand = mb.GetInsertCommand()
        da3.DeleteCommand = mb.GetDeleteCommand()

        mb = New SqlClient.SqlCommandBuilder(da2)
        da2.UpdateCommand = mb.GetUpdateCommand()
        da2.InsertCommand = mb.GetInsertCommand()
        da2.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS
        da3.UpdateCommand.Transaction = BTRANS
        da3.InsertCommand.Transaction = BTRANS
        da3.DeleteCommand.Transaction = BTRANS
        da2.UpdateCommand.Transaction = BTRANS
        da2.InsertCommand.Transaction = BTRANS
        da2.DeleteCommand.Transaction = BTRANS

        If State = "ADD" Then
            row.Item("kd_service") = getNoTrans("BOMSERV", getTanggal(BTRANS), BTRANS)
            txt_kdService.Text = row.Item("kd_service")
            For Each rows As DataRow In ds1.Tables("dtlBOM_BIAYA").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_service") = row.Item("kd_service")
                End If
            Next

            For Each rows As DataRow In ds1.Tables("dtlBOMBahan").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_service") = row.Item("kd_service")
                End If
            Next
        End If


        da4.Update(ds1.Tables("BOM_SERVICE"))
        da3.Update(ds1.Tables("dtlBOM_BIAYA"))
        da2.Update(ds1.Tables("dtlBOMBahan"))


        ds1.Tables("BOM_SERVICE").AcceptChanges()
        ds1.Tables("dtlBOM_BIAYA").AcceptChanges()
        ds1.Tables("dtlBOMBahan").AcceptChanges()
        State = "EDIT"
        BTRANS.Commit()
        showMessages("Berhasil disimpan..")


    End Sub

    Private Sub GC_Bahan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC_Bahan.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_BahanService.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar Bahan BOM Service") = MsgBoxResult.Yes Then
                    GV_BahanService.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GC_Biaya_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC_Biaya.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_BIAYA.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar BOM Biaya Service") = MsgBoxResult.Yes Then
                    GV_BIAYA.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV_BahanService_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_BahanService.InitNewRow
        GC_Bahan.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
    End Sub

    Private Sub GV_BIAYA_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_BIAYA.InitNewRow
        GC_Biaya.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
    End Sub
End Class