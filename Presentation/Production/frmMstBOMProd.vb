Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Public Class frmMstBOMProd
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da23, da4, da5, da6 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle As Integer
    Dim tampung As Integer
    Dim flag_include As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public load_form, kd_bom, revisi As String
    Dim u As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnAdd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub frmMstBOMProd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        tampung = 0
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom", sqlconn))
        da2.Fill(ds1, "BOM")
        u = "a"
        'tampil_LE()
        If Not ds1.Relations("Detail") Is Nothing Then ds1.Relations.Clear()
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()


        da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        da2.Fill(ds1, "dtlBOM")
        GC.DataSource = ds1.Tables("dtlBOM")


        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        da3.Fill(ds1, "childBOM")

        'GV2.DataSource = ds1.Tables("childBOM")
        'AddHandler ds1.Tables("childBOM").RowDeleted, AddressOf refreshNomer

        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim rel As DataRelation

        colM(0) = ds1.Tables("dtlBOM").Columns("kd_kegiatan")

        colD(0) = ds1.Tables("childBOM").Columns("kd_kegiatan")

        
        rel = ds1.Relations.Add("Detail", colM, colD, True)
        GC.LevelTree.Nodes.Add("Detail", GV2)

        GV.OptionsView.NewItemRowPosition = 0

        If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where 1=0", sqlconn))
        da4.Fill(ds1, "dtlBOM_FIN")

        If load_form = "MonBOM" Then
            tampil_LE()
            reload_edit()
        ElseIf load_form = "MonBOMAdd" Then
            tampil_LE()
            reload_add()
        End If
        'GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")

    End Sub
    Sub tampil_LE()

        If Not ds1.Tables("jnsBOM") Is Nothing Then ds1.Tables("jnsBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, kd_jenis from SIF.dbo.SIF_Barang where kd_jns_persd in (select id_data from sif.dbo.SIF_Gen_Reff_D where id_ref_file = 'JNSPRSDBOM') and Rec_Stat = 'Y' order by Nama_Barang", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        txtBOM.Properties.DataSource = ds1.Tables("jnsBOM")
        txtBOM.Properties.ValueMember = "Kode_Barang"
        txtBOM.Properties.DisplayMember = "Nama_Barang"

        If Not ds1.Tables("jnsBOMCOPY") Is Nothing Then ds1.Tables("jnsBOMCOPY").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select kd_bom, nama_bom,revisi from SIF.dbo.SIF_bom M where revisi = " & _
        '                                        "(select MAX(revisi)  from SIF.dbo.SIF_bom b where b.kd_bom = M.kd_bom) ORDER BY nama_bom ASC ", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select M.kd_bom, br.Nama_Barang as nama_bom,M.revisi from SIF.dbo.SIF_bom M " & _
                                                "left join SIF.dbo.SIF_Barang br " & _
                                                "on br.Kode_Barang = M.kd_bom " & _
                                                "where revisi = (select MAX(revisi)  from SIF.dbo.SIF_bom b where b.kd_bom = M.kd_bom) and br.Rec_Stat ='Y' " & _
                                                "ORDER BY br.Nama_Barang ASC", sqlconn))
        da1.Fill(ds1, "jnsBOMCOPY")
        txt_Copy.Properties.DataSource = ds1.Tables("jnsBOMCOPY")
        txt_Copy.Properties.ValueMember = "kd_bom"
        txt_Copy.Properties.DisplayMember = "nama_bom"

        If Not ds1.Tables("jnsKegiatan") Is Nothing Then ds1.Tables("jnsKegiatan").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where Ref_Role='PROD' and Id_Ref_File='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKegiatan")
        repKegiatan.DataSource = ds1.Tables("jnsKegiatan")


        'If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang where kd_jns_persd in (select id_data from sif.dbo.SIF_Gen_Reff_D where id_ref_file = 'JNSPRSDBOM') and Rec_Stat = 'Y' order by nama_barang", sqlconn))
        'da1.Fill(ds1, "jnsBarang")
        'repBarang.DataSource = ds1.Tables("jnsBarang")

        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang where kd_jns_persd in (select id_data from sif.dbo.SIF_Gen_Reff_D where id_ref_file = 'JNSPRSDBOM') and Rec_Stat = 'Y' order by nama_barang", sqlconn))
        da1.Fill(ds1, "jnsBarang")
        RepGridLUEBarang.DataSource = ds1.Tables("jnsBarang")
        RepGridLUEBarang.DisplayMember = "Nama_Barang"
        RepGridLUEBarang.ValueMember = "Kode_Barang"
        RepositoryItemGridLookUpEdit1View.Columns("Kode_Barang").Visible = True
        RepositoryItemGridLookUpEdit1View.Columns("Kode_Barang").Caption = "Kode Barang"
        RepositoryItemGridLookUpEdit1View.Columns("Nama_Barang").Caption = "Nama Barang"

        If Not ds1.Tables("jnsRek") Is Nothing Then ds1.Tables("jnsRek").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar order by nm_buku_besar", sqlconn))
        da1.Fill(ds1, "jnsRek")
        repRekening.DataSource = ds1.Tables("jnsRek")
    End Sub
    Sub reload_add()
        ' reload(kd_bom, revisi)
        btn_simpan.Visible = True
        btn_close.Visible = True
        State = "ADD"
        txtBOM.EditValue = kd_bom
        txtBOM.Properties.ReadOnly = True
        'btnSave = True
        btnAdd = False
        btnEdit = False
        'btnDelete = True
        'btnCancel = True
        setStatus()
        Me.Enabled = True
    End Sub
    Sub reload_edit()
        reload(kd_bom, revisi)
        btn_simpan.Visible = True
        btn_close.Visible = True
        State = "EDIT"
        txtBOM.Properties.ReadOnly = True
        'btnSave = True
        btnAdd = False
        btnEdit = False
        'btnDelete = True
        'btnCancel = True
        setStatus()
        Me.Enabled = True
    End Sub
    Public Sub reload(ByVal kdbom As String, ByVal norev As Integer)
        'If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        'If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        'da2.Fill(ds1, "dtlBOM")
        'GC.DataSource = ds1.Tables("dtlBOM")
        Dim dr As SqlDataReader
        Dim kd_departemen As String
        GV.OptionsView.NewItemRowPosition = 1
        'GV_BOM_FIN.OptionsView.NewItemRowPosition = 1
        If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()

       
        repKegiatan.DataSource = ds1.Tables("jnsKegiatan")
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
        da2.Fill(ds1, "BOM")
        If ds1.Tables("BOM").Rows.Count > 0 Then
            row = ds1.Tables("BOM").Rows(0)
            txtNoDokBOM.Text = row.Item("no_dokumen_bom")
            txtKetBOM.Text = row.Item("keterangan")
            txtRevisi.Text = row.Item("revisi")
            txtBOM.EditValue = row.Item("kd_bom")
            CE_Header.EditValue = row.Item("incld_header")
            dr = New SqlClient.SqlCommand("select b.Kd_Depart from SIF.dbo.SIF_Barang b " & _
                                        "where b.Kode_Barang = '" & txtBOM.EditValue & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                kd_departemen = dr.Item("Kd_Depart")
            Else
                kd_departemen = vbNullString
            End If
            dr.Close()

            If Not ds1.Tables("jnsKegiatan") Is Nothing Then ds1.Tables("jnsKegiatan").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where Ref_Role='PROD' and Id_Ref_File='KGTSPK' and kd_departemen ='" & kd_departemen & "'", sqlconn))
            da1.Fill(ds1, "jnsKegiatan")


            da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da1.Fill(ds1, "dtlBOM")

            

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da3.Fill(ds1, "childBOM")

            For Each rw As DataRow In ds1.Tables("childBOM").Rows
                dr = New SqlClient.SqlCommand("select d.*, s.Nama_Satuan as nama_satuan from SIF.dbo.SIF_bom_d  d " & _
                                          "inner join SIF.dbo.SIF_Barang b " & _
                                          "on b.Kode_Barang = d.kd_barang " & _
                                          "inner join SIF.dbo.SIF_Satuan s " & _
                                          "on S.Kode_Satuan = b.Kd_Satuan " & _
                                          "where kd_bom='" & kdbom & "' and revisi= " & norev & " ", sqlconn).ExecuteReader

                While dr.Read

                    If rw("kd_barang") = dr.Item("kd_barang") Then
                        rw("satuan") = dr.Item("nama_satuan")
                    Else
                    End If
                End While
            Next


            GC.DataSource = ds1.Tables("dtlBOM")



            da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da4.Fill(ds1, "dtlBOM_FIN")
            GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")
        Else
            showMessages("Tidak ada data" & txtRevisi.Text)
        End If


    End Sub

    Public Sub add_click()
        cancel_click()
        tampil_LE()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        Me.Enabled = True

        'reload()
    End Sub

    Public Sub edit_click()
        u = "a"
        tampung = 0
        tampil_LE()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        'da23 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_bom KODE, nama_bom NAMA, revisi REVISI, no_dokumen_bom [NO DOKUMEN], " & _
        '                                                            "last_update_date TANGGAL from SIF.dbo.SIF_Bom b " & _
        '                                                            "where b.revisi = (Select MAX(revisi) from SIF.dbo.SIF_bom b1 where b1.kd_bom = b.kd_bom ) order by nama_bom ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da23 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  br.Nama_Barang [NAMA_BARANG],b.kd_bom KODE, b.revisi REVISI, b.no_dokumen_bom [NO_DOKUMEN], " & _
                                                                    "b.last_update_date TANGGAL from SIF.dbo.SIF_Bom b " & _
                                                                    "left join SIF.dbo.SIF_Barang br " & _
                                                                    "on br.Kode_Barang = b.kd_bom " & _
                                                                    "where b.revisi = (Select MAX(revisi) from SIF.dbo.SIF_bom b1 " & _
                                                                    "where b1.kd_bom = b.kd_bom ) order by br.Nama_Barang ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da23.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'txtRevisi.Text = frmCari.row("REVISI")
            'txtBOM.EditValue = frmCari.row("KODE")
            reload(frmCari.row("KODE").ToString, frmCari.row("REVISI").ToString)
            State = "EDIT"
            txtBOM.Properties.ReadOnly = True
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

    Public Sub save_click()
        If txtBOM.EditValue = Nothing Then
            MessageBox.Show("Jenis BOM belum dipilih.")
            Exit Sub
        End If
        If Trim(txtNoDokBOM.Text) = "" Then
            MessageBox.Show("Nomor Dokumen belum diisi.")
            Exit Sub
        End If
        If GV.RowCount < 1 Then
            MessageBox.Show("Jenis Kegiatan belum diisi.")
            Exit Sub
        End If
        Dim tgl As Date = getTanggal()
        If State = "ADD" Then
            row = ds1.Tables("BOM").NewRow
            row.Item("last_create_date") = tgl
            row.Item("last_created_by") = username
        ElseIf State = "EDIT" Then
            Dim jm As Integer = ds1.Tables("BOM").Rows.Count
            row = ds1.Tables("BOM").Rows(0)
            row.Item("last_update_date") = tgl
            row.Item("last_updated_by") = username
        End If
        If CE_Header.CheckState = CheckState.Unchecked Then
            CE_Header.EditValue = "T"
        ElseIf CE_Header.CheckState = CheckState.Checked Then
            CE_Header.EditValue = "Y"
        End If
        'MsgBox(CE_Header.EditValue & " , " & txtBOM.EditValue.ToString & "," & txtRevisi.Text & "," & txtNoDokBOM.Text & "," & txtBOM.GetColumnValue("Nama_Barang") & "," & txtBOM.GetColumnValue("kd_jenis") & _
        '       "," & txtKetBOM.Text & "," & tgl & "," & kdcabang & "," & kddep & "," & username & "," & Me.Name, MsgBoxStyle.Information)
        row.Item("incld_header") = CE_Header.EditValue
        row.Item("kd_bom") = txtBOM.EditValue.ToString
        row.Item("revisi") = txtRevisi.Text
        row.Item("nama_bom") = txtBOM.GetColumnValue("Nama_Barang")
        row.Item("no_dokumen_bom") = txtNoDokBOM.Text
        row.Item("jenis_bom") = txtBOM.GetColumnValue("kd_jenis")
        row.Item("keterangan") = txtKetBOM.Text
        row.Item("rec_stat") = "Y"
        row.Item("kd_cabang") = kdcabang
        row.Item("kd_departemen") = kddep
        row.Item("program_name") = Me.Name
        If State = "ADD" Then
            ds1.Tables("BOM").Rows.Add(row)
        End If
        'refreshNomer()

        Dim mybuilder2 As New SqlCommandBuilder(da2)
        da2.UpdateCommand = mybuilder2.GetUpdateCommand
        da2.Update(ds1.Tables("BOM"))
        ds1.Tables("BOM").AcceptChanges()


        For Each rows As DataRow In ds1.Tables("childBOM").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_bom") = txtBOM.EditValue
                    rows.Item("revisi") = txtRevisi.Text
                    rows.Item("last_create_date") = tgl
                    rows.Item("last_created_by") = username
                End If
                rows.Item("last_update_date") = tgl
                rows.Item("kd_cabang") = kdcabang
                rows.Item("kd_departemen") = kddep
                rows.Item("last_updated_by") = username
                rows.Item("program_name") = Me.Name
            End If
        Next

        

        Dim mybuilder3 As New SqlCommandBuilder(da3)
        da3.UpdateCommand = mybuilder3.GetUpdateCommand
        da3.Update(ds1.Tables("childBOM"))
        ds1.Tables("childBOM").AcceptChanges()


        For Each rows1 As DataRow In ds1.Tables("dtlBOM_FIN").Rows
            If rows1.RowState <> DataRowState.Deleted Then
                If rows1.RowState = DataRowState.Added Then
                    rows1.Item("kd_bom") = txtBOM.EditValue
                    rows1.Item("revisi") = txtRevisi.Text
                    rows1.Item("last_create_date") = tgl
                    rows1.Item("last_created_by") = username
                End If
                rows1.Item("last_update_date") = tgl
                rows1.Item("kd_cabang") = kdcabang
                rows1.Item("kd_departemen") = kddep
                rows1.Item("last_updated_by") = username
                rows1.Item("program_name") = Me.Name
            End If
        Next

        Dim mybuilder4 As New SqlCommandBuilder(da4)
        da4.UpdateCommand = mybuilder4.GetUpdateCommand
        da4.Update(ds1.Tables("dtlBOM_FIN"))
        ds1.Tables("dtlBOM_FIN").AcceptChanges()

        showMessages("Data berhasil disimpan.")
        State = "EDIT"
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal Simpan")

        End Try

        
    End Sub

    Public Sub delete_click()
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            If GC.FocusedView.Name = "GV2" Then
                refreshNomer()
            End If
        End If
        
    End Sub

    Public Sub delete_click_kegiatan()
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            'If GC.FocusedView.Name = "GV" Then
            '    refreshNomer()
            'End If
        End If

    End Sub

    Public Sub delete_click_fin()
        Dim x As Object
        x = CType(GC_BOM_FIN.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            If GC_BOM_FIN.FocusedView.Name = "GV_BOM_FIN" Then
                refreshNomer_BOM_FIN()
            End If
        End If

    End Sub

    Public Sub cancel_click()
        u = "a"
        tampung = 0
        State = "CANCEL"
        txtBOM.EditValue = Nothing
        txt_Copy.EditValue = Nothing
        txtBOM.Properties.ReadOnly = False
        txtNoDokBOM.Text = ""
        txtKetBOM.Text = ""
        txtRevisi.Text = 0
        txt_nilai.Text = 1

        GV.OptionsView.NewItemRowPosition = 0
        GC.DataSource = Nothing

        GV_BOM_FIN.OptionsView.NewItemRowPosition = 0
        GC_BOM_FIN.DataSource = Nothing


        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged
        If e.Column.ToString = "Nama Barang" Then

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan " & _
                                                                   "from SIF.dbo.SIF_Barang B " & _
                                                                   "left join SIF.dbo.SIF_Satuan S " & _
                                                                   "on B.Kd_Satuan=S.Kode_Satuan " & _
                                                                   "where B.Kode_Barang = '" & e.Value.ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GC.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
            Else
                MsgBox("Pilih barang dahulu !", MsgBoxStyle.Critical)
            End If

            dr.Close()
        End If
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        If State = "ADD" Then
            GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
            GC.FocusedView.GetRow(e.RowHandle).Item("material") = "Y"
            GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC.FocusedView.RowCount + 1


        End If
        If State = "EDIT" Then
            If u = "b" Then
                GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
                GC.FocusedView.GetRow(e.RowHandle).Item("material") = "Y"
                GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = tampung + 1
                tampung = tampung + 1


            End If
            If u = "a" Then
                GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
                GC.FocusedView.GetRow(e.RowHandle).Item("material") = "Y"

                Dim dr As SqlDataReader = New SqlClient.SqlCommand("select max(no_urut) as no_urut from SIF.dbo.SIF_Bom_D  where kd_bom='" & txtBOM.EditValue & "' and kd_kegiatan= '" & GV.GetRowCellValue(GV.GetSelectedRows(0), "kd_kegiatan") & "'", sqlconn).ExecuteReader
                dr.Read()




                Dim i As Integer = 1
                GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = dr.Item("no_urut") + i
                tampung = dr.Item("no_urut") + i
                u = "b"
                dr.Close()

            End If
        End If

    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV2.RowUpdated
        GV.ExpandMasterRow(GV.GetSelectedRows(0), "Detail")
    End Sub

    Private Sub refreshNomer() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC.FocusedView.RowCount - 1
            GC.FocusedView.GetRow(i).Item("no_urut") = i + 1
        Next
    End Sub

    Private Sub refreshNomer_BOM_FIN() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(GC_BOM_FIN.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC_BOM_FIN.FocusedView.RowCount - 1
            GC_BOM_FIN.FocusedView.GetRow(i).Item("no_urut") = i + 1
        Next
    End Sub
    Private Sub txtBOM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBOM.EditValueChanged

        Dim dr As SqlDataReader

        GV.OptionsView.NewItemRowPosition = 1
        GV_BOM_FIN.OptionsView.NewItemRowPosition = 1


        If State = "ADD" Then

            If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
            If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
            If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
            Dim newrev As Integer = 0
            Dim kd_departemen As String

            'Mencari departemen barang 
            dr = New SqlClient.SqlCommand("select b.Kd_Depart from SIF.dbo.SIF_Barang b " & _
                                          "where b.Kode_Barang = '" & txtBOM.EditValue & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                kd_departemen = dr.Item("Kd_Depart")
            Else
                kd_departemen = vbNullString
            End If
            dr.Close()

            If Not ds1.Tables("jnsKegiatan") Is Nothing Then ds1.Tables("jnsKegiatan").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where Ref_Role='PROD' and Id_Ref_File='KGTSPK' and kd_departemen ='" & kd_departemen & "'", sqlconn))
            da1.Fill(ds1, "jnsKegiatan")
            repKegiatan.DataSource = ds1.Tables("jnsKegiatan")
            'dr = New SqlClient.SqlCommand("select max(revisi) revisi from SIF.dbo.SIF_bom where kd_bom='" & txtBOM.EditValue & "'", sqlconn).ExecuteReader
            dr = New SqlClient.SqlCommand("select no_dokumen_bom, revisi from SIF.dbo.SIF_bom a " & _
                                          "where kd_bom = '" & txtBOM.EditValue & "'" & _
                                          "and revisi = (Select max(revisi) from SIF.dbo.SIF_BOM where kd_bom ='" & txtBOM.EditValue & "') ", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item("revisi").ToString <> "" Then
                    newrev = dr.Item("revisi") + 1
                    txtNoDokBOM.Text = dr.Item("no_dokumen_bom")
                End If
            Else
                txtNoDokBOM.Text = vbNullString
            End If
            dr.Close()

            txtRevisi.Text = newrev
            da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom where 1=0", sqlconn))
            da2.Fill(ds1, "BOM")
            da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
            da1.Fill(ds1, "dtlBOM")
            GC.DataSource = ds1.Tables("dtlBOM")

            If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
            da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where 1=0", sqlconn))
            da4.Fill(ds1, "dtlBOM_FIN")
            GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")

            If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang where Kode_Barang <>'" & txtBOM.EditValue & "' and Rec_Stat = 'Y' ", sqlconn))
            da1.Fill(ds1, "jnsBarang")
            repBarang.DataSource = ds1.Tables("jnsBarang")

           
        End If
    End Sub

    Private Sub GV2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV2.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click()
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        Dim isValid As Boolean = True
        Dim rw() As DataRow = ds1.Tables("childBOM").Select("kd_barang = '" & e.Row.item("kd_barang") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                Dim x As Object
                x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                x.SetColumnError(clBarang2, "Jenis Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Jenis Barang Sudah Ada dalam Daftar.")
            End If
        End If
        e.Valid = isValid

        If e.Row("kd_barang") Is System.DBNull.Value Then
            isValid = False
            Dim x As Object
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.SetColumnError(clJumlah2, "Barang Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Barang Tidak Boleh Kosong.")
        End If
       
        If e.Row("jumlah") Is System.DBNull.Value Then
            isValid = False
            Dim x As Object
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.SetColumnError(clJumlah2, "Jumlah Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Tidak Boleh Kosong.")
        End If

        e.Valid = isValid

    End Sub


    Private Sub btCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCopy.Click
        If txtBOM.EditValue Is Nothing Then
            showMessages("Jenis BOM Belum Dipilih!")
            Exit Sub
        End If

        If txt_Copy.EditValue Is Nothing Then
            showMessages("BOM Asal Yang Akan Disalin Belum Dipilih!")
            Exit Sub
        End If
        If txt_nilai.EditValue Is Nothing Then
            txt_nilai.EditValue = 1
        End If
        Dim kdbomcopy As String = txt_Copy.EditValue

        If Not ds1.Tables("cBOM") Is Nothing Then ds1.Tables("cBOM").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbomcopy & "' " & _
                                                "and revisi = (select max(revisi) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbomcopy & "') ", sqlconn))
        da1.Fill(ds1, "cBOM")
        If ds1.Tables("cBOM").Rows.Count = 0 Then
            showMessages("BOM tidak ada data")
            Exit Sub
        End If

        '---- call procedure prodp_copy_bom
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        'Try
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_copy_bom"
        sqlCmd.Parameters.Add("@vkd_bom_asal", SqlDbType.Char).Value = txt_Copy.EditValue
        sqlCmd.Parameters.Add("@vkd_bom_tujuan", SqlDbType.Char).Value = txtBOM.EditValue
        sqlCmd.Parameters.Add("@vrevisi", SqlDbType.Int).Value = txtRevisi.Text
        sqlCmd.Parameters.Add("@vno_dok_bom", SqlDbType.Char).Value = txtNoDokBOM.Text
        sqlCmd.Parameters.Add("@vketbom", SqlDbType.Char).Value = txtKetBOM.Text
        sqlCmd.Parameters.Add("@vkd_cab", SqlDbType.Char).Value = kdcabang
        sqlCmd.Parameters.Add("@vkd_dep", SqlDbType.Char).Value = kddep
        sqlCmd.Parameters.Add("@vnilai_kali", SqlDbType.Decimal).Value = txt_nilai.EditValue
        dr = sqlCmd.ExecuteReader
        dr.Close()

        reload(txtBOM.EditValue, txtRevisi.Text)
        showMessages("Data Berhasil Disimpan")
        State = "EDIT"
        setStatus()
    End Sub

    
    Private Sub GV_BOM_FIN_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_BOM_FIN.InitNewRow
        GC_BOM_FIN.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
        GC_BOM_FIN.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC_BOM_FIN.FocusedView.RowCount + 1
    End Sub

    Private Sub GV_BOM_FIN_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_BOM_FIN.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_BOM_FIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_BOM_FIN.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click_fin()
        End If
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        GV.ExpandMasterRow(0, "Detail")
        GV2.Columns("rec_stat").Visible = False
        GV2.Columns("no_urut").Visible = False
        GV2.Columns("satuan").AppearanceCell.BackColor = Color.White
        print_gc1(GC, "                                                                                   BOM PRODUKSI    " & vbCrLf & _
                 "     " & vbCrLf & _
                 "Nama Barang       : " & txtBOM.Text & vbCrLf & _
                 "Nomor Dokumen     : " & txtNoDokBOM.Text & vbCrLf & _
                 "No Revisi                 : " & txtRevisi.Text)
        GV2.Columns("rec_stat").Visible = True
        GV2.Columns("no_urut").Visible = True
        GV2.Columns("satuan").AppearanceCell.BackColor = Color.LightGreen


    End Sub

   

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click_kegiatan()
        End If
    End Sub

    'Private Sub CB_Include_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE_Header.CheckedChanged
    '    If Ch.Checked = True Then
    '        flag_include = "Y"
    '    Else
    '        flag_include = "T"
    '    End If
    'End Sub

    Private Sub txt_Copy_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Copy.EditValueChanged

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        btn_simpan.Visible = False
        btn_close.Visible = False
        load_form = ""
        txtKetBOM.Text = ""
        txt_Copy.EditValue = vbNullString
        Me.Close()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        save_click()
    End Sub
End Class