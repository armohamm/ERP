Imports System.Data.SqlClient
Public Class frmMstBOMProdSimulasi
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
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

        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom", sqlconn))
        da2.Fill(ds1, "BOM")

        If Not ds1.Tables("jnsBOM") Is Nothing Then ds1.Tables("jnsBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, kd_jenis from SIF.dbo.SIF_Barang order by Nama_Barang", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        txtBOM.Properties.DataSource = ds1.Tables("jnsBOM")
        txtBOM.Properties.ValueMember = "Kode_Barang"
        txtBOM.Properties.DisplayMember = "Nama_Barang"

        If Not ds1.Tables("jnsBOMCOPY") Is Nothing Then ds1.Tables("jnsBOMCOPY").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_bom, nama_bom,revisi from PROD.dbo.PROD_bom_simulasi_m M where revisi = " & _
                                                "(select MAX(revisi)  from PROD.dbo.PROD_bom_simulasi_m b where b.kd_bom = M.kd_bom) ", sqlconn))
        da1.Fill(ds1, "jnsBOMCOPY")
        txtCopy.Properties.DataSource = ds1.Tables("jnsBOMCOPY")
        txtCopy.Properties.ValueMember = "kd_bom"
        txtCopy.Properties.DisplayMember = "nama_bom"

        If Not ds1.Tables("jnsKegiatan") Is Nothing Then ds1.Tables("jnsKegiatan").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where Ref_Role='PROD' and Id_Ref_File='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKegiatan")
        repKegiatan.DataSource = ds1.Tables("jnsKegiatan")


        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da1.Fill(ds1, "jnsBarang")
        repBarang.DataSource = ds1.Tables("jnsBarang")

        'If Not ds1.Tables("jnsRek") Is Nothing Then ds1.Tables("jnsRek").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar order by nm_buku_besar", sqlconn))
        'da1.Fill(ds1, "jnsRek")
        'repRekening.DataSource = ds1.Tables("jnsRek")

        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from PROD.dbo.PROD_bom_simulasi_d where 1=0", sqlconn))
        da2.Fill(ds1, "dtlBOM")
        GC.DataSource = ds1.Tables("dtlBOM")

        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_bom_simulasi_d where 1=0", sqlconn))
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

        'If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
        'da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where 1=0", sqlconn))
        'da4.Fill(ds1, "dtlBOM_FIN")
        'GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")

    End Sub
    Sub Reload_LU_BOM_Copy()
        If Not ds1.Tables("jnsBOMCOPY") Is Nothing Then ds1.Tables("jnsBOMCOPY").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_bom, nama_bom,revisi from PROD.dbo.PROD_bom_simulasi_m M where revisi = " & _
                                                "(select MAX(revisi)  from PROD.dbo.PROD_bom_simulasi_m b where b.kd_bom = M.kd_bom) ", sqlconn))
        da1.Fill(ds1, "jnsBOMCOPY")
        txtCopy.Properties.DataSource = ds1.Tables("jnsBOMCOPY")
        txtCopy.Properties.ValueMember = "kd_bom"
        txtCopy.Properties.DisplayMember = "nama_bom"
    End Sub
    Public Sub reload(ByVal kdbom As String, ByVal norev As Integer)
        'If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        'If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from SIF.dbo.SIF_bom_d where 1=0", sqlconn))
        'da2.Fill(ds1, "dtlBOM")
        'GC.DataSource = ds1.Tables("dtlBOM")

        GV.OptionsView.NewItemRowPosition = 1
        'GV_BOM_FIN.OptionsView.NewItemRowPosition = 1
        'If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_bom_simulasi_m where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
        da2.Fill(ds1, "BOM")
        If ds1.Tables("BOM").Rows.Count > 0 Then
            row = ds1.Tables("BOM").Rows(0)
            txtNoDokBOM.Text = row.Item("no_dokumen_bom")
            txtKetBOM.Text = row.Item("keterangan")
            txtRevisi.Text = row.Item("revisi")
            txtBOM.EditValue = row.Item("kd_bom")
            lblTotal.EditValue = IIf(row.Item("total") Is System.DBNull.Value, 0, row.Item("total"))


            da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from PROD.dbo.PROD_bom_simulasi_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da1.Fill(ds1, "dtlBOM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_bom_simulasi_d where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            da3.Fill(ds1, "childBOM")
            GC.DataSource = ds1.Tables("dtlBOM")

            'da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom='" & kdbom & "' and revisi=" & norev & " ", sqlconn))
            'da4.Fill(ds1, "dtlBOM_FIN")
            'GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")
        Else
            showMessages("Tidak ada data" & txtRevisi.Text)
        End If


    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        'reload()
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_bom KODE, nama_bom NAMA, revisi REVISI, no_dokumen_bom [NO DOKUMEN], last_update_date TANGGAL from PROD.dbo.PROD_bom_simulasi_m order by nama_bom", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da3.Fill(ds3, "lookup_so")
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
        End If

        row.Item("kd_bom") = txtBOM.EditValue.ToString
        row.Item("revisi") = txtRevisi.Text
        row.Item("nama_bom") = txtBOM.GetColumnValue("Nama_Barang")
        row.Item("no_dokumen_bom") = txtNoDokBOM.Text
        row.Item("jenis_bom") = txtBOM.GetColumnValue("kd_jenis")
        row.Item("keterangan") = txtKetBOM.Text
        row.Item("rec_stat") = "Y"
        row.Item("last_update_date") = tgl
        row.Item("kd_cabang") = kdcabang
        row.Item("kd_departemen") = kddep
        row.Item("last_updated_by") = username
        row.Item("program_name") = Me.Name
        row.Item("total") = lblTotal.EditValue
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


        'For Each rows1 As DataRow In ds1.Tables("dtlBOM_FIN").Rows
        '    If rows1.RowState <> DataRowState.Deleted Then
        '        If rows1.RowState = DataRowState.Added Then
        '            rows1.Item("kd_bom") = txtBOM.EditValue
        '            rows1.Item("revisi") = txtRevisi.Text
        '            rows1.Item("last_create_date") = tgl
        '            rows1.Item("last_created_by") = username
        '        End If
        '        rows1.Item("last_update_date") = tgl
        '        rows1.Item("kd_cabang") = kdcabang
        '        rows1.Item("kd_departemen") = kddep
        '        rows1.Item("last_updated_by") = username
        '        rows1.Item("program_name") = Me.Name
        '    End If
        'Next
        'Dim mybuilder4 As New SqlCommandBuilder(da4)
        'da4.UpdateCommand = mybuilder4.GetUpdateCommand
        'da4.Update(ds1.Tables("dtlBOM_FIN"))
        'ds1.Tables("dtlBOM_FIN").AcceptChanges()

        showMessages("Data berhasil disimpan.")
        State = "EDIT"
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal Simpan")

        End Try


    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds1.Tables("childBOM").Rows
            ttl += rw("sub_total_harga")

        Next
        Return ttl
    End Function
    Public Sub delete_click()
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            lblTotal.EditValue = ds1.Tables("childBOM").Compute("sum(sub_total_harga)", "")
            If GC.FocusedView.Name = "GV2" Then
                refreshNomer()
            End If
        End If

    End Sub

    'Public Sub delete_click_fin()
    '    Dim x As Object
    '    x = CType(GC_BOM_FIN.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
    '    If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
    '        x.DeleteSelectedRows()
    '        If GC_BOM_FIN.FocusedView.Name = "GV_BOM_FIN" Then
    '            refreshNomer_BOM_FIN()
    '        End If
    '    End If

    'End Sub

    Public Sub cancel_click()
        State = "CANCEL"
        txtBOM.EditValue = Nothing
        txtCopy.EditValue = Nothing
        txtBOM.Properties.ReadOnly = False
        txtNoDokBOM.Text = ""
        txtKetBOM.Text = ""
        txtRevisi.Text = 0
        lblTotal.EditValue = 0

        GV.OptionsView.NewItemRowPosition = 0
        GC.DataSource = Nothing

        'GV_BOM_FIN.OptionsView.NewItemRowPosition = 0
        'GC_BOM_FIN.DataSource = Nothing


        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        Reload_LU_BOM_Copy()

    End Sub

    Private Sub GV2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged
        If e.Column.ToString = "Nama Barang" Then

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan , L.nilai_rata, L.bultah " & _
                                                               "from SIF.dbo.SIF_Barang B " & _
                                                               "left join SIF.dbo.SIF_Satuan S " & _
                                                               "on B.Kd_Satuan=S.Kode_Satuan " & _
                                                               "LEFT JOIN INV.dbo.INV_STOK_SALDO L " & _
                                                               "ON B.Kode_Barang = L.kd_stok " & _
                                                               "where B.Kode_Barang = '" & e.Value.ToString & "' " & _
                                                               "and L.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL where SL.kd_stok = B.Kode_Barang )", sqlconn).ExecuteReader
            dr.Read()
            GC.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
            GC.FocusedView.GetRow(e.RowHandle).Item("harga") = IIf(dr.Item("nilai_rata") <= 0, 1, dr.Item("nilai_rata"))
            dr.Close()
        End If
        Dim sub_total As Double
        If e.Column.ToString = "Jumlah" Then
            sub_total = IIf(GC.FocusedView.GetRow(e.RowHandle).Item("harga") <= 0, 1, GC.FocusedView.GetRow(e.RowHandle).Item("harga")) * GC.FocusedView.GetRow(e.RowHandle).Item("Jumlah")
            GC.FocusedView.GetRow(e.RowHandle).Item("sub_total_harga") = sub_total
            'lblTotal.EditValue = getTotal()
            lblTotal.EditValue = ds1.Tables("childBOM").Compute("sum(sub_total_harga)", "")

        End If

    End Sub

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
        GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC.FocusedView.RowCount + 1
        lblTotal.EditValue = ds1.Tables("childBOM").Compute("sum(sub_total_harga)", "")
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
        lblTotal.EditValue = ds1.Tables("childBOM").Compute("sum(sub_total_harga)", "")
    End Sub

    Private Sub refreshNomer() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC.FocusedView.RowCount - 1
            GC.FocusedView.GetRow(i).Item("no_urut") = i + 1
        Next
    End Sub

    'Private Sub refreshNomer_BOM_FIN() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim x As Object
    '    Dim i As Int16
    '    x = CType(GC_BOM_FIN.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
    '    For i = 0 To GC_BOM_FIN.FocusedView.RowCount - 1
    '        GC_BOM_FIN.FocusedView.GetRow(i).Item("no_urut") = i + 1
    '    Next
    'End Sub
    Private Sub txtBOM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBOM.EditValueChanged

        Dim dr As SqlDataReader

        GV.OptionsView.NewItemRowPosition = 1
        'GV_BOM_FIN.OptionsView.NewItemRowPosition = 1


        If State = "ADD" Then

            If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
            If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
            If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
            Dim newrev As Integer = 0
            dr = New SqlClient.SqlCommand("select max(revisi) revisi from PROD.dbo.PROD_bom_simulasi_m where kd_bom='" & txtBOM.EditValue & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item("revisi").ToString <> "" Then
                newrev = dr.Item("revisi") + 1
            End If
            dr.Close()
            txtRevisi.Text = newrev
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_bom_simulasi_m where 1=0", sqlconn))
            da2.Fill(ds1, "BOM")
            da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from PROD.dbo.PROD_bom_simulasi_d where 1=0", sqlconn))
            da1.Fill(ds1, "dtlBOM")
            GC.DataSource = ds1.Tables("dtlBOM")

            'If Not ds1.Tables("dtlBOM_FIN") Is Nothing Then ds1.Tables("dtlBOM_FIN").Clear()
            'da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where 1=0", sqlconn))
            'da4.Fill(ds1, "dtlBOM_FIN")
            'GC_BOM_FIN.DataSource = ds1.Tables("dtlBOM_FIN")
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
    End Sub


    Private Sub btCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCopy.Click
        If txtBOM.EditValue Is Nothing Then
            showMessages("Jenis BOM Belum Dipilih!")
            Exit Sub
        End If

        If txtCopy.EditValue Is Nothing Then
            showMessages("BOM Asal Yang Akan Disalin Belum Dipilih!")
            Exit Sub
        End If

        Dim kdbomcopy As String = txtCopy.EditValue

        If Not ds1.Tables("cBOM") Is Nothing Then ds1.Tables("cBOM").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from PROD.dbo.PROD_bom_simulasi_d where kd_bom='" & kdbomcopy & "' " & _
                                                "and revisi = (select max(revisi) from PROD.dbo.PROD_bom_simulasi_d where kd_bom='" & kdbomcopy & "') ", sqlconn))
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
        sqlCmd.CommandText = "PROD.dbo.prodp_copy_bom_simulasi"
        sqlCmd.Parameters.Add("@vkd_bom_asal", SqlDbType.Char).Value = txtCopy.EditValue
        sqlCmd.Parameters.Add("@vkd_bom_tujuan", SqlDbType.Char).Value = txtBOM.EditValue
        sqlCmd.Parameters.Add("@vrevisi", SqlDbType.Int).Value = txtRevisi.Text
        sqlCmd.Parameters.Add("@vno_dok_bom", SqlDbType.Char).Value = txtNoDokBOM.Text
        sqlCmd.Parameters.Add("@vketbom", SqlDbType.Char).Value = txtKetBOM.Text
        sqlCmd.Parameters.Add("@vkd_cab", SqlDbType.Char).Value = kdcabang
        sqlCmd.Parameters.Add("@vkd_dep", SqlDbType.Char).Value = kddep
        dr = sqlCmd.ExecuteReader
        dr.Close()

        reload(txtBOM.EditValue, txtRevisi.Text)
        showMessages("Data Berhasil Disimpan")
        State = "EDIT"
        setStatus()
    End Sub
    Public Sub cetak_click()
        showMessages("Fungsi cetak tidak ada !")
    End Sub

    'Private Sub GV_BOM_FIN_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    GC_BOM_FIN.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
    '    GC_BOM_FIN.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC_BOM_FIN.FocusedView.RowCount + 1
    'End Sub

    'Private Sub GV_BOM_FIN_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
    '    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    'End Sub

    'Private Sub GV_BOM_FIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Delete Then
    '        delete_click_fin()
    '    End If
    'End Sub
End Class