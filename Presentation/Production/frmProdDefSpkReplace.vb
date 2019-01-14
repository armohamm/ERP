Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmProdDefSpkReplace
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
    Public btnEdit As Boolean = True
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

    Private Sub frmProdDefSpk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        awal()



    End Sub

    Sub awal()
        If Not ds1.Tables("jnsBOM") Is Nothing Then ds1.Tables("jnsBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis as Nama_Jenis  from SIF.dbo.SIF_Jenis_Barang ", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        txtjenis.Properties.DataSource = ds1.Tables("jnsBOM")
        txtjenis.Properties.ValueMember = "Kd_Jns_Brg"
        txtjenis.Properties.DisplayMember = "Nama_Jenis"


        If Not ds1.Tables("kegBOM") Is Nothing Then ds1.Tables("kegBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct id_data,desc_data from SIF.dbo.SIF_GEn_Reff_d keg  where keg.ref_role='PROD' and keg.ID_REF_DATA='KGTSPK'    ", sqlconn))
        da1.Fill(ds1, "kegBOM")
        repKegiatan.DataSource = ds1.Tables("kegBOM")
        repKegiatan.ValueMember = "id_data"
        repKegiatan.DisplayMember = "desc_data"

        If Not ds1.Tables("spkBOM") Is Nothing Then ds1.Tables("spkBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct id_data,desc_data  from SIF.dbo.SIF_GEn_Reff_d spk where spk.ref_role='PROD' and spk.ID_REF_DATA='SPK'   ", sqlconn))
        da1.Fill(ds1, "spkBOM")
        repSpk.DataSource = ds1.Tables("spkBOM")
        repSpk.ValueMember = "id_data"
        repSpk.DisplayMember = "desc_data"

        GV.Columns(0).ColumnEdit = repKegiatan
        GV.Columns(1).ColumnEdit = repSpk
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("" & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(username & vbCrLf & getTanggal.ToShortDateString)




        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Footer.LineAlignment = BrickAlignment.Near

        ph.Header.Font = New Font("Tahoma", 8, FontStyle.Bold)




        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 90
        link.Margins.Top = 90
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub

    Public Sub reload(ByVal kdbom As String)


        GV.OptionsView.NewItemRowPosition = 1

        If Not ds2.Tables("dtlBOM") Is Nothing Then ds2.Tables("dtlBOM").Clear()
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()

        da2 = New SqlDataAdapter(New SqlCommand("select distinct keg.desc_data as kd_kegiatan,spk.desc_data as kd_spk,keg.desc_data,spk.desc_data from SIF.dbo.SIF_default_spk s left join SIF.dbo.SIF_GEn_Reff_d keg on keg.id_data=s.kd_kegiatan left join SIF.dbo.SIF_GEn_Reff_d spk on spk.id_data=s.kd_spk where keg.ref_role='PROD' and keg.ID_REF_DATA='KGTSPK' and spk.ref_role='PROD' and spk.ID_REF_DATA='SPK' and s.kd_jns='" & kdbom & "' ", sqlconn))
        da2.Fill(ds1, "BOM")
        If ds1.Tables("BOM").Rows.Count > 0 Then
            row = ds1.Tables("BOM").Rows(0)

            da3 = New SqlDataAdapter(New SqlCommand("select distinct * from SIF.dbo.SIF_default_spk s where  s.kd_jns='" & kdbom & "'   ", sqlconn))
            da3.Fill(ds2, "dtlBOM")
            GC.DataSource = ds2.Tables("dtlBOM")
            Dim dr As DataRow
            dr = ds2.Tables("dtlBOM").Rows(0)
            txtjenis.EditValue = dr.Item("kd_jns")

        End If


    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        txtjenis.Properties.ReadOnly = False
        awal()
        setStatus()

        'reload()
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da23 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct s.kd_jns as JENIS,b.Nama_Jenis as Nama_Jenis from SIF.dbo.SIF_default_spk s left join SIF.dbo.SIF_Jenis_Barang b on b.Kd_Jns_Brg=s.kd_jns     ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da23.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih

            reload(frmCari.row("JENIS").ToString)
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

        '' Simpan Master BOM Detail
        '================================================================================
        For Each rows As DataRow In ds2.Tables("dtlBom").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_jns") = txtjenis.EditValue.ToString

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
        da3.Update(ds2.Tables("dtlBOM"))
        ds2.Tables("dtlBOM").AcceptChanges()

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


    Public Sub cancel_click()
        State = "CANCEL"
        txtjenis.EditValue = Nothing


        GV.OptionsView.NewItemRowPosition = 1
        GC.DataSource = Nothing

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
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

        setStatus()
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
        'GV.ExpandMasterRow(0, "Detail")
        'GV.Columns("rec_stat").Visible = False
        'GV.Columns("no_urut").Visible = False
        'GV.Columns("satuan").AppearanceCell.BackColor = Color.White
        print_gc1(GC, "Default Spk    " & vbCrLf & _
                                "                                                                                                    " & "Nama Jenis       : " & txtjenis.Text)




    End Sub

    Private Sub txtjenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjenis.EditValueChanged

        If Not ds2.Tables("dtlBOM") Is Nothing Then ds2.Tables("dtlBOM").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select distinct * from SIF.dbo.SIF_default_spk s where s.kd_jns='" & txtjenis.EditValue & "'   ", sqlconn))
        da3.Fill(ds2, "dtlBOM")
        GC.DataSource = ds2.Tables("dtlBOM")


    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow

    End Sub
End Class