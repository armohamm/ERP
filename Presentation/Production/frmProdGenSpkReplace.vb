Imports System.Data.SqlClient
Public Class frmProdGenSpkReplace
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da23, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle As Integer
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Dim status_ubah As String

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

    Private Sub frmProdGenSpk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        If Not ds1.Tables("Bom") Is Nothing Then ds1.Tables("Bom").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_BOM_S", sqlconn))
        da2.Fill(ds1, "Bom")

        If Not ds1.Tables("jnsBOM") Is Nothing Then ds1.Tables("jnsBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis as Nama_Jenis  from SIF.dbo.SIF_Jenis_Barang order by Nama_Jenis", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        txtjenis.Properties.DataSource = ds1.Tables("jnsBOM")
        txtjenis.Properties.ValueMember = "Kd_Jns_Brg"
        txtjenis.Properties.DisplayMember = "Nama_Jenis"





        'If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct bar.nama_barang,keg. ", sqlconn))
        'da2.Fill(ds1, "dtlBOM")
        'GC.DataSource = ds1.Tables("dtlBOM")


        'GV2.DataSource = ds1.Tables("childBOM")
        'AddHandler ds1.Tables("childBOM").RowDeleted, AddressOf refreshNomer



    End Sub



    Public Sub reload(ByVal kdbom As String, ByVal norev As Integer)
        'If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        'If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        'da2.Fill(ds1, "dtlBOM")
        'GC.DataSource = ds1.Tables("dtlBOM")

        GV.OptionsView.NewItemRowPosition = 1

        If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
        da2.Fill(ds1, "BOM")
        If ds1.Tables("BOM").Rows.Count > 0 Then
            row = ds1.Tables("BOM").Rows(0)




            da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da1.Fill(ds1, "dtlBOM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da3.Fill(ds1, "childBOM")
            GC.DataSource = ds1.Tables("dtlBOM")

            da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da4.Fill(ds1, "dtlBOM_FIN")
            GC.DataSource = ds1.Tables("dtlBOM_FIN")
        Else

        End If


    End Sub

    Public Sub add_click()
        btnSave = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        'reload()
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da23 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_bom KODE, nama_bom NAMA, revisi REVISI, no_dokumen_bom [NO DOKUMEN], last_update_date TANGGAL from SIF.dbo.SIF_Bom order by nama_bom", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da23.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'txtRevisi.Text = frmCari.row("REVISI")
            'txtBOM.EditValue = frmCari.row("KODE")
            reload(frmCari.row("KODE").ToString, frmCari.row("REVISI").ToString)
            State = "EDIT"
            txtjenis.Properties.ReadOnly = True
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
        '' Validasi isian data
        '================================================================================
        If txtjenis.EditValue = Nothing Then
            MessageBox.Show("Jenis BOM belum dipilih.")
            Exit Sub
        End If

        If GV.RowCount < 1 Then
            MessageBox.Show("Jenis Kegiatan / Data BOM belum diisi.")
            Exit Sub
        End If
        '================================================================================



        '' Simpan Master BOM M
        '================================================================================
        Dim tgl As Date = getTanggal()
        If State = "ADD" Then
            row = ds1.Tables("BOM").NewRow
            row.Item("last_create_date") = tgl
            row.Item("last_created_by") = username
        ElseIf State = "EDIT" Then
            Dim jm As Integer = ds1.Tables("BOM").Rows.Count
            row = ds1.Tables("BOM").Rows(0)
        End If

        row.Item("kd_bom") = txtjenis.EditValue.ToString

        row.Item("rec_stat") = "Y"

        row.Item("last_updated_by") = username
        row.Item("program_name") = Me.Name
        If State = "ADD" Then
            ds1.Tables("BOM").Rows.Add(row)
        End If
        'refreshNomer()

        Dim mybuilder2 As New SqlCommandBuilder(da2)
        da2.UpdateCommand = mybuilder2.GetUpdateCommand
        da2.Update(ds1.Tables("BOM"))
        ds1.Tables("BOM").AcceptChanges()
        '================================================================================


        '' Simpan Master BOM Detail
        '================================================================================
        For Each rows As DataRow In ds1.Tables("childBOM").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_bom") = txtjenis.EditValue

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

        '================================================================================
        '' Simpan Master BOM Fin
        '================================================================================
        For Each rows1 As DataRow In ds1.Tables("dtlBOM_FIN").Rows
            If rows1.RowState <> DataRowState.Deleted Then
                If rows1.RowState = DataRowState.Added Then
                    rows1.Item("kd_bom") = txtjenis.EditValue

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


        '================================================================================
        '' Simpan Master SPK
        '================================================================================
        For Each rows As DataRow In ds2.Tables("dtlKeg").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    'rows.Item("kd_jenis") = txtJenisBrg.EditValue
                    'rows.Item("kd_tipe") = lookuptipe.EditValue
                    rows.Item("kd_bom") = txtjenis.EditValue
                    rows.Item("last_create_date") = tgl
                    rows.Item("last_created_by") = username
                End If
                rows.Item("last_update_date") = tgl
                rows.Item("last_updated_by") = username
                rows.Item("program_name") = Me.Name
                rows.Item("kd_cabang") = kdcabang
                rows.Item("kd_departemen") = kddep
            End If

        Next

        Dim mybuilder5 As New SqlCommandBuilder(da5)
        da5.UpdateCommand = mybuilder5.GetUpdateCommand
        da5.Update(ds2.Tables("dtlKeg"))
        ds2.Tables("dtlKeg").AcceptChanges()


        '===========================================================================================================

        showMessages("Data berhasil disimpan.")
        State = "EDIT"



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

    Public Sub delete_click_fin()

    End Sub

    Public Sub delete_click_spk()


    End Sub
    Public Sub cancel_click()
        State = "CANCEL"
        txtjenis.EditValue = Nothing


        GV.OptionsView.NewItemRowPosition = 0
        GC.DataSource = Nothing




        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
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
            GC.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
            dr.Close()
        End If
    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
        GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC.FocusedView.RowCount + 1
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

    Private Sub btCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtjenis.EditValue Is Nothing Then
            showMessages("Jenis BOM Belum Dipilih!")
            Exit Sub
        End If





        If Not ds1.Tables("cBOM") Is Nothing Then ds1.Tables("cBOM").Clear()

        'da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbomcopy & "' " & _
        '                                        "and revisi = (select max(revisi) from SIF.dbo.SIF_bom_d where kd_bom='" & kdbomcopy & "') ", sqlconn))
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

        sqlCmd.Parameters.Add("@vkd_cab", SqlDbType.Char).Value = kdcabang

        dr = sqlCmd.ExecuteReader
        dr.Close()

        ' reload(txtBOM.EditValue, txtRevisi.Text)
        showMessages("Data Berhasil Disimpan")
        State = "EDIT"
        setStatus()
    End Sub






    Private Sub GV_BOM_FIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            delete_click_fin()
        End If
    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        If e.Column.ToString = "Kegiatan" Or e.Column.ToString = "SPK" And e.Column.ToString = "Keterangan" And e.Column.ToString = "Status" Then
            status_ubah = "1"
        ElseIf e.Column.ToString = "Kegiatan" Or e.Column.ToString = "SPK" Then
            status_ubah = "1"
        Else
            status_ubah = "0"
        End If
    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)

        status_ubah = "1"
    End Sub



    Public Sub cetak_click()
        showMessages("Fungsi cetak tidak ada !")
    End Sub

    Private Sub txtjenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjenis.EditValueChanged
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_bom,nama_barang from" & _
                                                "(select distinct 'ALL' as kd_bom,'ALL' as nama_barang" & _
                                                "   from SIF.dbo.SIF_Bom b" & _
                                                "   left join SIF.dbo.SIF_Barang bar on bar.kode_barang=b.kd_bom" & _
                                                "   where bar.kd_jenis= '" & txtjenis.EditValue & "'  union " & _
                                                "select distinct b.kd_bom as kd_bom, bar.nama_barang as nama_barang" & _
                                                "   from SIF.dbo.SIF_Bom b" & _
                                                "   left join SIF.dbo.SIF_Barang bar on bar.kode_barang=b.kd_bom" & _
                                                "   where bar.kd_jenis = '" & txtjenis.EditValue & "') a  order by nama_barang asc ", sqlconn))
        da1.Fill(ds1, "Barang")
        txtBarang.Properties.DataSource = ds1.Tables("Barang")
        txtBarang.Properties.ValueMember = "kd_bom"
        txtBarang.Properties.DisplayMember = "nama_barang"


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_gen_spk_replace"
        sqlCmd.Parameters.Add("@vkd_jenis", SqlDbType.Char).Value = txtjenis.EditValue
        sqlCmd.Parameters.Add("@vkd_barang", SqlDbType.Char).Value = txtBarang.EditValue
        dr = sqlCmd.ExecuteReader
        dr.Close()

        If txtBarang.EditValue = "ALL" Then
            If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select distinct keg.desc_data as kd_kegiatan,spk.desc_data as kd_spk,bar.nama_barang,keg.desc_data,spk.desc_data from SIF.dbo.SIF_Bom_S s left join SIF.dbo.SIF_Barang bar on s.kd_bom=bar.kode_barang left join SIF.dbo.SIF_GEn_Reff_d keg on keg.id_data=s.kd_kegiatan left join SIF.dbo.SIF_GEn_Reff_d spk on spk.id_data=s.kd_spk where keg.ref_role='PROD' and keg.ID_REF_DATA='KGTSPK' and spk.ref_role='PROD' and spk.ID_REF_DATA='SPK' and s.generate='Y'   ", sqlconn))
            da2.Fill(ds1, "dtlBOM")
            GC.DataSource = ds1.Tables("dtlBOM")
        ElseIf txtBarang.EditValue <> "ALL" Then
            If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select distinct keg.desc_data as kd_kegiatan,spk.desc_data as kd_spk,bar.nama_barang,keg.desc_data,spk.desc_data from SIF.dbo.SIF_Bom_S s left join SIF.dbo.SIF_Barang bar on s.kd_bom=bar.kode_barang left join SIF.dbo.SIF_GEn_Reff_d keg on keg.id_data=s.kd_kegiatan left join SIF.dbo.SIF_GEn_Reff_d spk on spk.id_data=s.kd_spk where keg.ref_role='PROD' and keg.ID_REF_DATA='KGTSPK' and spk.ref_role='PROD' and spk.ID_REF_DATA='SPK' and s.generate='Y'   ", sqlconn))
            da2.Fill(ds1, "dtlBOM")
            GC.DataSource = ds1.Tables("dtlBOM")
        End If
    End Sub
End Class