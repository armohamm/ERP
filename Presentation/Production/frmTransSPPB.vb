Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Public Class frmTransSPPB
    Dim obj As Object
    Dim prn As frmMain
    Dim template As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmSpkMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        reload()
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()

        'Me.Enabled = True
    End Sub

    Private Sub reload(Optional ByVal notrans As String = "")
        If Not ds1.Tables("master") Is Nothing Then ds1.Tables("master").Clear()
        If Not ds1.Tables("detail") Is Nothing Then ds1.Tables("detail").Clear()
        If Not ds2.Tables("RPH") Is Nothing Then ds2.Tables("RPH").Clear()
        If Not ds2.Tables("SPPB") Is Nothing Then ds2.Tables("SPPB").Clear()
        If Not ds2.Tables("KEGIATAN") Is Nothing Then ds2.Tables("KEGIATAN").Clear()
        If Not ds2.Tables("JADWAL") Is Nothing Then ds2.Tables("JADWAL").Clear()
        If Not ds2.Tables("KD_KEG") Is Nothing Then ds2.Tables("KD_KEG").Clear()
        'select desc_data from sif.dbo.sif_gen_reff_d where ref_role='PROD' and id_ref_data='JDWKRJ' and id_data='01'
        da1 = New SqlDataAdapter(New SqlCommand("select * from prod.dbo.PROD_sppb_m", sqlconn))
        da1.Fill(ds1, "master")
        'da1 = New SqlDataAdapter(New SqlCommand("select d.qty_sisa,d.qty_in,d.qty_out,d.qty_order,d.jumlah,d.kd_barang from PROD.dbo.PROD_sppb_d d, sif.dbo.sif_barang b where d.kd_barang=b.kode_barang and 1=0", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select d.qty_sisa,d.qty_in,d.qty_out,d.qty_order,d.jumlah,d.kd_barang from PROD.dbo.PROD_sppb_d d where  1=0", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_sppb_d d where  1=0", sqlconn))
        da1.Fill(ds1, "detail")

        da2 = New SqlDataAdapter(New SqlCommand("select distinct(no_rph) from PROD.dbo.PROD_sppb_m where kd_departemen = '" & kddep & "'", sqlconn))
        da2.Fill(ds2, "RPH")
        da2 = New SqlDataAdapter(New SqlCommand("select distinct(kd_jadwal),no_rph from PROD.dbo.PROD_rcn_prod_m", sqlconn))
        da2.Fill(ds2, "KD_KEG")
        da2 = New SqlDataAdapter(New SqlCommand("select distinct(no_sppb) from PROD.dbo.PROD_sppb_m", sqlconn))
        da2.Fill(ds2, "SPPB")
        da2 = New SqlDataAdapter(New SqlCommand("select distinct(m.kd_kegiatan),d.desc_data from PROD.dbo.PROD_sppb_m m, SIF.dbo.SIF_Gen_Reff_D d where m.kd_kegiatan=d.id_data and d.ref_role='PROD' and d.id_ref_data='KGTSPK'", sqlconn))
        da2.Fill(ds2, "KEGIATAN")
        da2 = New SqlDataAdapter(New SqlCommand("select desc_data from sif.dbo.sif_gen_reff_d where ref_role='PROD' and id_ref_data='JDWKRJ' and 1=0", sqlconn))
        da2.Fill(ds2, "JADWAL")

        If Not ds2.Tables("jnsBarang") Is Nothing Then ds2.Tables("jnsBarang").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "jnsBarang")
        LE_Barang.DataSource = ds2.Tables("jnsBarang")
        'If Not ds2.Tables("Satuan") Is Nothing Then ds2.Tables("satuan").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select Kode_Satuan, Nama_Satuan from SIF.dbo.SIF_Satuan ", sqlconn))
        'da2.Fill(ds2, "satuan")
        'LEsatuan.DataSource = ds2.Tables("satuan")

        'where ref_role='PROD' and id_ref_data='SPK'
        'da1 = New SqlDataAdapter(New SqlCommand("select no_trans,kd_kegiatan,desc_data " & _
        '                                        "from PROD.dbo.prod_spk_m P " & _
        '                                        "left join SIF.dbo.sif_gen_reff_d S " & _
        '                                        "on P.kd_kegiatan=S.id_data " & _
        '                                        "where P.no_trans='" & txtNoRph.EditValue & "' " & _
        '                                        "and S.id_ref_data = 'KGTSPK'", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        'da1.Fill(ds1, "jnsKeg")

        txtNoRph.Properties.DataSource = ds2.Tables("RPH")
        txtNoRph.Properties.ValueMember = "no_rph"
        txtNoRph.Properties.DisplayMember = "no_rph"

        txtNoSPPB.Properties.DataSource = ds2.Tables("SPPB")
        txtNoSPPB.Properties.ValueMember = "no_sppb"
        txtNoSPPB.Properties.DisplayMember = "no_sppb"

        txtKegiatan.Properties.DataSource = ds2.Tables("KEGIATAN")
        txtKegiatan.Properties.ValueMember = "kd_kegiatan"
        txtKegiatan.Properties.DisplayMember = "desc_data"

        gc.DataSource = ds1.Tables("detail")
        If notrans <> "" Then
            txtNoRph.EditValue = notrans
        End If
    End Sub

    Private Sub txtNoSPPB_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSPPB.EditValueChanged
        If Not ds2.Tables("KEGIATAN") Is Nothing Then ds2.Tables("KEGIATAN").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select distinct(m.kd_kegiatan),d.desc_data from PROD.dbo.PROD_sppb_m m, SIF.dbo.SIF_Gen_Reff_D d where m.kd_kegiatan=d.id_data and d.ref_role='PROD' and d.id_ref_data='KGTSPK' and m.no_sppb='" & txtNoSPPB.Text & "' and m.no_rph='" & txtNoRph.Text & "'", sqlconn))
        da2.Fill(ds2, "KEGIATAN")

        txtKegiatan.Properties.DataSource = ds2.Tables("KEGIATAN")
        txtKegiatan.Properties.ValueMember = "kd_kegiatan"
        txtKegiatan.Properties.DisplayMember = "desc_data"
    End Sub

    Private Sub txtNoRph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoRph.EditValueChanged
        If txtNoRph.EditValue <> Nothing Then
            If Not ds2.Tables("SPPB") Is Nothing Then ds2.Tables("SPPB").Clear()
            If Not ds2.Tables("JADWAL") Is Nothing Then ds2.Tables("JADWAL").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select distinct(no_sppb) from PROD.dbo.PROD_sppb_m where no_rph='" & txtNoRph.Text & "'", sqlconn))
            da2.Fill(ds2, "SPPB")
            txtNoSPPB.Properties.DataSource = ds2.Tables("SPPB")
            txtNoSPPB.Properties.ValueMember = "no_sppb"
            txtNoSPPB.Properties.DisplayMember = "no_sppb"

            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select distinct tanggal from PROD.dbo.PROD_sppb_m where no_rph='" & txtNoRph.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            txtTgl_Rph.EditValue = dr.Item("tanggal")
            If dr.HasRows Then
                txtTgl_Rph.Properties.ReadOnly = True
            End If
            dr.Close()

            Dim drow As DataRow = ds2.Tables("KD_KEG").Select("no_rph='" & txtNoRph.EditValue & "'")(0)
            Dim iddata As String = drow("kd_jadwal")
            da2 = New SqlDataAdapter(New SqlCommand("select desc_data from sif.dbo.sif_gen_reff_d where ref_role='PROD' and id_ref_data='JDWKRJ' and id_data='" & iddata & "'", sqlconn))
            da2.Fill(ds2, "JADWAL")
            txtJamKerja.EditValue = ds2.Tables("JADWAL").Rows(0).Item(0)
        End If
       
    End Sub

    Private Sub txtKegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKegiatan.EditValueChanged
        Dim dr As SqlDataReader
        If Not ds1.Tables("detail") Is Nothing Then ds1.Tables("detail").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select d.qty_sisa,d.qty_in,d.qty_out,d.qty_order,d.jumlah,d.kd_barang from PROD.dbo.PROD_sppb_d d, sif.dbo.sif_barang b where d.kd_barang=b.kode_barang and d.no_sppb='" & txtNoSPPB.Text & "' and d.no_rph='" & txtNoRph.Text & "' and d.kd_kegiatan='" & txtKegiatan.EditValue & "'", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select d.qty_sisa,d.qty_in,d.qty_out,d.qty_order,d.jumlah,d.kd_barang from PROD.dbo.PROD_sppb_d d where d.no_sppb='" & txtNoSPPB.Text & "' and d.no_rph='" & txtNoRph.Text & "' and d.kd_kegiatan='" & txtKegiatan.EditValue & "'", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select d.*, '' Kode_Satuan from PROD.dbo.PROD_sppb_d d where d.no_sppb='" & txtNoSPPB.Text & "' and d.no_rph='" & txtNoRph.Text & "' and d.kd_kegiatan='" & txtKegiatan.EditValue & "' ", sqlconn))
        da1.Fill(ds1, "detail")

        For Each rw As DataRow In ds1.Tables("detail").Rows
            dr = New SqlClient.SqlCommand("select d.kd_barang,d.jumlah, b.Nama_Barang, s.Kode_Satuan from PROD.dbo.PROD_sppb_d d " & _
                                          "left join SIF.dbo.SIF_Barang b " & _
                                          "on b.Kode_Barang=d.kd_barang " & _
                                          "left join SIF.dbo.SIF_Satuan s " & _
                                          "on b.Kd_satuan=s.Kode_Satuan " & _
                                          "where d.no_sppb='" & txtNoSPPB.Text & "' " & _
                                          "and d.no_rph='" & txtNoRph.Text & "' and d.kd_kegiatan='" & txtKegiatan.EditValue & "'", sqlconn).ExecuteReader

            While dr.Read

                If rw("kd_barang") = dr.Item("kd_barang") Then
                    rw("Kode_Satuan") = dr.Item("Kode_Satuan")
                Else
                End If
            End While
        Next
        gc.DataSource = ds1.Tables("detail")
    End Sub

    Public Sub add_click()
        reload()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select tanggal [Tanggal], no_rph [No RPH], no_sppb [No SPPB],kd_kegiatan  " & _
                "from PROD.dbo.PROD_sppb_m order by tanggal "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")

        frmCari.set_dso(ds3.Tables("lookup_so"))

        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select P.* " & _
            '                                               "from PROD.dbo.PROD_sppb_m P " & _
            '                                               "where P.no_rph='" & frmCari.row("No RPH") & "' and P.no_sppb='" & frmCari.row("No SPPB") & "' order by kd_barang", sqlconn).ExecuteReader
            'While dr.Read
            '    Dim rw As DataRow = ds1.Tables("dspkm").NewRow
            '    rw("no_trans") = dr.Item("no_trans")
            '    rw("kd_kegiatan") = dr.Item("kd_kegiatan")
            '    rw("kd_barang") = dr.Item("kd_barang")
            '    rw("jumlah_produksi") = dr.Item("jumlah_produksi")
            '    rw("nama_barang") = dr.Item("Nama_Barang")
            '    'rw("tgl_kirim") = dr.Item("tgl_kirim")
            '    'rw("prioritas") = dr.Item("prioritas")
            '    rw("jumlah_kerja") = 0

            '    ds1.Tables("dspkm").Rows.Add(rw)
            'End While
            'dr.Close()

            txtTgl_Rph.DateTime = frmCari.row("Tanggal")
            txtNoRph.EditValue = frmCari.row("No RPH")
            txtNoSPPB.EditValue = frmCari.row("No SPPB")
            txtKegiatan.EditValue = frmCari.row("kd_kegiatan")

            'txtJamKerja.Text = frmCari.row("Tanggal")
            'reload(frmCari.row("No RPH"))
            State = "ADD"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = False
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If
    End Sub

    Public Sub save_click()
        If State = "ADD" Then

            Dim filledrow As Integer = ds1.Tables("detail").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah belum diisi")
                Exit Sub
            End If
            'filledrow = ds1.Tables("detail").Select("qty_in>0").Count
            'If filledrow = 0 Then
            '    MessageBox.Show("Jumlah belum diisi")
            '    Exit Sub
            'End If
            'filledrow = ds1.Tables("detail").Select("qty_out>0").Count
            'If filledrow = 0 Then
            '    MessageBox.Show("Jumlah belum diisi")
            '    Exit Sub
            'End If
            'filledrow = ds1.Tables("detail").Select("qty_order>0").Count
            'If filledrow = 0 Then
            '    MessageBox.Show("Jumlah belum diisi")
            '    Exit Sub
            'End If
            'filledrow = ds1.Tables("detail").Select("qty_sisa>0").Count
            'If filledrow = 0 Then
            '    MessageBox.Show("Sisa belum diisi")
            '    Exit Sub
            'End If

            If txtTgl_Rph.Text = "" Then
                MessageBox.Show("Tanggal Belum Diisi")
                Exit Sub
            End If
            If txtNoRph.EditValue = "" Then
                MessageBox.Show("No RPH Belum Dipilih")
                Exit Sub
            End If
            If txtNoSPPB.EditValue = "" Then
                MessageBox.Show("Group Kerja Belum Dipilih")
                Exit Sub
            End If
            If txtKegiatan.EditValue = "" Then
                MessageBox.Show("Kegiatan Belum Dipilih")
                Exit Sub
            End If

            'Dim notrans As String
            'notrans = getNoTrans("PRODSPKM", txtTgl_Rph.DateTime)
            'txtJamKerja.Text = notrans

            'If Not ds1.Tables("mspkm") Is Nothing Then ds1.Tables("mspkm").Clear()
            'da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_man_m  d where 1=0", sqlconn))
            'da2.Fill(ds1, "mspkm")
            'Dim rowm As DataRow
            'rowm = ds1.Tables("mspkm").NewRow
            'rowm("no_trans") = txtNoRph.EditValue
            'rowm("tanggal") = txtTgl_Rph.DateTime
            'rowm("kd_kegiatan") = txtKegiatan.EditValue
            'rowm("group_kerja") = txtNoSPPB.EditValue
            'rowm("no_spk") = txtJamKerja.Text

            'ds1.Tables("mspkm").Rows.Add(rowm)
            'Dim mybuilder2 As New SqlCommandBuilder(da2)
            'da2.UpdateCommand = mybuilder2.GetUpdateCommand
            'da2.Update(ds1.Tables("mspkm"))
            'ds1.Tables("mspkm").AcceptChanges()


            'For i = ds1.Tables("dspkm").Rows.Count - 1 To 0 Step -1
            '    Dim rows As DataRow = ds1.Tables("dspkm").Rows(i)
            '    If Not TypeOf rows("jumlah_kerja") Is DBNull Then
            '        If rows("jumlah_kerja") > 0 Then
            '            rows("no_spk") = txtJamKerja.Text
            '        Else
            '            ds1.Tables("dspkm").Rows(i).Delete()
            '        End If
            '    Else
            '        ds1.Tables("dspkm").Rows(i).Delete()
            '    End If
            'Next
            'gc.DataSource = ds1.Tables("dspkm")
            'Dim mybuilder As New SqlCommandBuilder(da1)
            'da1.UpdateCommand = mybuilder.GetUpdateCommand
            'da1.Update(ds1.Tables("dspkm"))
            'ds1.Tables("dspkm").AcceptChanges()
            'showMessages("Data Berhasil Disimpan")
            'btnSave = False
            'setStatus()

            For Each rows As DataRow In ds1.Tables("detail").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("no_rph") = txtNoRph.EditValue.ToString
                        rows.Item("kd_kegiatan") = txtKegiatan.EditValue.ToString
                        rows.Item("no_sppb") = txtNoSPPB.EditValue.ToString
                        rows.Item("rec_stat") = "S"
                        rows.Item("last_create_date") = getTanggal()
                        rows.Item("last_created_by") = username
                    End If
                    rows.Item("last_update_date") = getTanggal()
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("kd_departemen") = kddep
                    rows.Item("last_updated_by") = username
                    rows.Item("program_name") = Me.Name
                End If
            Next



            Dim mybuilder3 As New SqlCommandBuilder(da1)
            da1.UpdateCommand = mybuilder3.GetUpdateCommand
            da1.Update(ds1.Tables("detail"))
            ds1.Tables("detail").AcceptChanges()
            showMessages("Data Berhasil Disimpan")
            btnSave = False
            setStatus()

        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        txtTgl_Rph.DateTime = Date.Today
        txtJamKerja.Text = ""
        txtKegiatan.EditValue = Nothing
        txtNoSPPB.EditValue = Nothing
        txtNoRph.EditValue = Nothing
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        reload()
        Me.Enabled = False
    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        If e.Column.ToString = "Jumlah" Then
            gc.FocusedView.GetRow(e.RowHandle).Item("qty_sisa") = gc.FocusedView.GetRow(e.RowHandle).Item("Jumlah")
        End If
    End Sub

    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        'If e.Row("jumlah_kerja") > e.Row("sisa") Then
        '    gv.SetColumnError(qty_out, "Jumlah Kerja Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    isValid = False
        'End If
        'e.Valid = isValid


        Dim rw() As DataRow = ds1.Tables("detail").Select("kd_barang = '" & e.Row.item("kd_barang") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                Dim x As Object
                x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                x.SetColumnError(nama_barang, "Jenis Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Jenis Barang Sudah Ada dalam Daftar.")
            End If
        End If
        e.Valid = isValid

    End Sub

   
    Private Sub gc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gc.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gv.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SPPB") = MsgBoxResult.Yes Then
                    gv.DeleteSelectedRows()
                End If
            End If
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
        ''gView.Columns("rec_stat").Visible = False
        'print_gc1(gc, "                                                                 SURAT PERMINTAAN BAHAN BAKU    " & vbCrLf & _
        '         "     " & vbCrLf & _
        '         "No RPH         : " & txtNoRph.Text & vbCrLf & _
        '         "No SPBB         : " & txtNoSPPB.Text & vbCrLf & _
        '         "Kegiatan          :" & txtKegiatan.Text)
        ''gView.Columns("rec_stat").Visible = True
        callReport(App_Path() & "\report\sppb.rpt", "", "nosppb=" & txtNoSPPB.EditValue & " &KDKEG=" & txtKegiatan.EditValue & " &norph=" & txtNoRph.EditValue & " &vnama_report=" & template, False)
    End Sub
End Class