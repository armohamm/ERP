Imports System.Data.SqlClient
Public Class frmServiceCSO
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle, umur As Integer
    Dim biaya_service As Double = 0
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim clone As Object
    Public isload As Boolean = False
    Public nomor As Int16 = -1
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmServiceCSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        With New SqlCommand("select val_kode1, val_kode2 from sif.dbo.sif_gen_reff_d where ref_role='SERVICE' and id_data='01'", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then
                umur = .Item(0)
                biaya_service = .Item(1)
            End If
            .Close()
        End With
        reload()
        reload_edit("", "")
        LU_SO.Properties.DataSource = ds1.Tables("SO")
        LE_JenisService.DataSource = ds1.Tables("Jns_Srv")
        GC_Jns_Service.DataSource = ds1.Tables("BOM_Jns_Srv")
        LU_Barang.Properties.DataSource = ds1.Tables("Barang")
        repMaterial.DataSource = ds1.Tables("jnsBarang")

        Dim r1 As DataRelation
        Dim dcolP(2) As DataColumn
        Dim dcolC(2) As DataColumn

        dcolP(0) = ds1.Tables("BOM_Jns_Srv").Columns("Nomor_SO")
        dcolP(1) = ds1.Tables("BOM_Jns_Srv").Columns("sp_seq")
        dcolP(2) = ds1.Tables("BOM_Jns_Srv").Columns("Kode_Service")

        dcolC(0) = ds1.Tables("BOM_Barang").Columns("NO_SP")
        dcolC(1) = ds1.Tables("BOM_Barang").Columns("NO_SEQ_SP")
        dcolC(2) = ds1.Tables("BOM_Barang").Columns("Kd_Service")

        r1 = ds1.Relations.Add("Material", dcolP, dcolC, False)
        r1.Nested = True
        GC_Jns_Service.LevelTree.Nodes.Add("Material", GV_MATERIAl)

        repKain.DataSource = ds1.Tables("TIPE")
        repJnsKain.DataSource = ds1.Tables("KAIN")
    End Sub
    Public Sub reload()
        If Not ds1.Tables("SO") Is Nothing Then ds1.Tables("SO").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("Select d.No_sp, case d.Nama_Customer when 'UMUM' then Nama_pnrm else d.Nama_Customer end as Customer, d.Tgl_sp, No_telp from SALES.dbo.vso_rep d where Tipe_trans='" & ServiceSpringUmum & "' and d.No_sp like '%SRV%' and isnull(isPrinted,'')='' and status='OK' and isnull(isClosed,'')='' and ((select count(1) from SALES.dbo.sales_so_d dd where dd.no_sp= d.No_sp) <> (select count(distinct sp_seq) from sales.dbo.sales_produk_service ss where ss.nomor_so=d.no_sp)) ", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("Select d.No_sp, case d.Nama_Customer when 'UMUM' then Nama_pnrm else d.Nama_Customer end as Customer, d.Tgl_sp, No_telp from SALES.dbo.vso_rep d where Tipe_trans in ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "') and isnull(isPrinted,'')='' and status='OK' and isnull(isClosed,'')='' and ((select count(1) from SALES.dbo.sales_so_d dd where dd.no_sp= d.No_sp) <> (select count(distinct sp_seq) from sales.dbo.sales_produk_service ss where ss.nomor_so=d.no_sp)) ", sqlconn))
        da1.Fill(ds1, "SO")

        If Not ds1.Tables("Jns_Srv") Is Nothing Then ds1.Tables("Jns_Srv").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_service, nama_service, QC, toleransi from [SIF].[dbo].SIF_bom_service where rec_stat='Y' ", sqlconn))
        da1.Fill(ds1, "Jns_Srv")

        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, KD_SATUAN from SIF.dbo.SIF_Barang where kd_jns_persd not in  (1,5) and  Rec_Stat='Y'", sqlconn))
        da1.Fill(ds1, "jnsBarang")

        If Not ds1.Tables("KAIN") Is Nothing Then ds1.Tables("KAIN").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain, Merk_Kain + ' ' + isnull(Warna,'')  as Kain from SIF.dbo.SIF_Kain where rec_stat='Y' union select '','' ", sqlconn))
        da1.Fill(ds1, "KAIN")

        If Not ds1.Tables("TIPE") Is Nothing Then ds1.Tables("TIPE").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk, Kode_Tipe, Nama_Tipe from SIF.dbo.SIF_TIPE where rec_stat='Y' and 1=0 union select '', '', 'IDEM' ", sqlconn))
        da1.Fill(ds1, "TIPE")


    End Sub
    Public Sub reload_edit(ByVal no_sp As String, ByVal no_seq As String)
        If Not ds1.Tables("BOM_Jns_Srv") Is Nothing Then ds1.Tables("BOM_Jns_Srv").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select *, case Terima_Rekomendasi when 'Y' then 'YA' when 'T' then 'TIDAK' else '' end Rek from SALES.dbo.SALES_PRODUK_SERVICE S where S.Nomor_SO ='" & no_sp & "' and S.sp_seq ='" & no_seq & "' order by s.no_seq", sqlconn))
        da2.Fill(ds1, "BOM_Jns_Srv")
        GC_Jns_Service.DataSource = ds1.Tables("BOM_Jns_Srv")

        If Not ds1.Tables("BOM_Barang") Is Nothing Then ds1.Tables("BOM_Barang").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select *, (select Kd_Satuan from SIF.dbo.SIF_Barang b where S.KD_BARANG = b.Kode_Barang) as satuan  from SALES.dbo.SALES_BOM_SERVICE S " & _
                                                "where S.NO_SP ='" & no_sp & "' and S.NO_SEQ_SP ='" & no_seq & "' order by s.no_seq", sqlconn))
        da3.Fill(ds1, "BOM_Barang")
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select Distinct d.Kd_Stok, d.Keterangan, d.No_sp, Status_Inspeksi " & _
                                                ",d.No_seq, d.Deskripsi as Nama_Barang, thnbuat, CONFIRMED from SALES.dbo.SALES_SO_D d " & _
                                                "LEFT JOIN SIF.dbo.SIF_Barang b " & _
                                                "on d.Kd_Stok = b.Kode_Barang " & _
                                                "LEFT JOIN SALES.dbo.SALES_PRODUK_SERVICE p " & _
                                                "on p.Nomor_SO = d.No_sp and p.sp_seq = d.No_seq " & _
                                                "and p.kd_stok = d.Kd_Stok " & _
                                                "LEFT JOIN SALES.dbo.SALES_BOM_SERVICE s " & _
                                                "on s.NO_SP = d.No_sp and s.NO_SEQ_SP = d.No_seq " & _
                                                "where d.No_sp = '" & no_sp & "' and d.No_seq ='" & no_seq & "'", sqlconn))
        da1.Fill(ds1, "Barang")
        LU_Barang.Properties.DataSource = ds1.Tables("Barang")
    End Sub
    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        LU_SO.Enabled = True
        reload()
        LU_SO.Properties.ReadOnly = False
        LU_Barang.Properties.ReadOnly = False
    End Sub
    Public Sub cancel_click()
        State = "CANCEL"
        txt_NamaCust.Text = ""
        LU_Barang.EditValue = vbNullString
        LU_SO.EditValue = vbNullString
        txt_NamaCust.Text = ""
        txtKeterangan.Text = ""
        txtMasaPakai.EditValue = vbNullString
        txtStatusInspeksi.EditValue = vbNullString
        txtThnbuat.EditValue = vbNullString
        txtStatusKonfirmasi.EditValue = vbNullString
        txtNamaBaru.EditValue = vbNullString
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        reload()
        reload_edit("", "")
    End Sub

    Private Sub LU_SO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LU_SO.EditValueChanged
        If LU_SO.Text = "[Pilih No. SO]" Then
            txt_NamaCust.Text = ""
            Exit Sub
        End If
        LU_Barang.EditValue = vbNullString
        txt_NamaCust.Text = LU_SO.GetColumnValue("Customer")
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        If State = "ADD" Then
            da1 = New SqlDataAdapter(New SqlCommand("select Kd_Stok, Deskripsi as Nama_Barang, No_seq, Keterangan, thnbuat, CONFIRMED, Status_Inspeksi, kd_merk, kd_tipe from sales.dbo.vsod_rep where no_sp='" & LU_SO.EditValue & "' and no_seq not in (select sp_seq from sales.dbo.sales_produk_service where nomor_so='" & LU_SO.EditValue & "' )", sqlconn))
            da1.Fill(ds1, "Barang")
        Else
            da1 = New SqlDataAdapter(New SqlCommand("select Kd_Stok, Deskripsi as Nama_Barang, No_seq, Keterangan, thnbuat, CONFIRMED, Status_Inspeksi, kd_merk, kd_tipe from sales.dbo.vsod_rep where no_sp='" & LU_SO.EditValue & "' and no_seq in (select sp_seq from sales.dbo.sales_produk_service where nomor_so='" & LU_SO.EditValue & "' )", sqlconn))
            da1.Fill(ds1, "Barang")
        End If
        LU_Barang.Properties.DataSource = ds1.Tables("Barang")


    End Sub

    Private Sub GV_MATERIAl_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_MATERIAl.CellValueChanged
        If e.Column.Name = "GVMMaterial" Then
            If e.Value.ToString = "" Then
                sender.SetRowCellValue(e.RowHandle, "satuan", vbNullString)
                sender.SetRowCellValue(e.RowHandle, "HARGA", vbNullString)
                sender.SetRowCellValue(e.RowHandle, "MARGIN", vbNullString)
                sender.SetRowCellValue(e.RowHandle, "TOTAL", vbNullString)
                sender.SetRowCellValue(e.RowHandle, "QTY", vbNullString)
            Else
                sender.SetRowCellValue(e.RowHandle, "QTY", vbNullString)
                sender.SetRowCellValue(e.RowHandle, "satuan", ds1.Tables("jnsBarang").Select("Kode_Barang='" & e.Value & "'")(0)("KD_SATUAN"))
                If GV_Jenis_Service.GetRowCellValue(rhandle, "FromTarif").ToString = "T" Then
                    Dim harga As Double = 0
                    With New SqlCommand("select isnull(harga_rupiah,0) from sif.dbo.sif_harga where Kode_Barang = '" & e.Value & "'", sqlconn).ExecuteReader
                        .Read()
                        If .HasRows Then
                            harga = .Item(0)
                        Else
                            harga = 0
                        End If
                        .Close()
                    End With

                    sender.SetRowCellValue(e.RowHandle, "HARGA", harga)
                    sender.SetRowCellValue(e.RowHandle, "MARGIN", MarginService)
                End If
            End If
        ElseIf e.Column.Name = "gvmQty" Then
            If e.Value.ToString = "" Then Exit Sub
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If view.GetRowCellValue(e.RowHandle, "HARGA").ToString = "" Then Exit Sub

            view.SetRowCellValue(e.RowHandle, "TOTAL", view.GetRowCellValue(e.RowHandle, "QTY") * (view.GetRowCellValue(e.RowHandle, "HARGA") + (view.GetRowCellValue(e.RowHandle, "HARGA") * view.GetRowCellValue(e.RowHandle, "MARGIN") / 100)))
        End If
    End Sub


    Private Sub refreshNomer(ByVal sender As Object)
        Dim i As Int16
        Try
            For i = 0 To sender.RowCount - 1
                sender.GetRow(i).Item("NO_SEQ") = i + 1
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub refreshNomer2()
        Dim i As Int16
        Try
            For i = 0 To GV_Jenis_Service.RowCount - 1
                GV_Jenis_Service.GetRow(i).Item("no_seq") = i + 1
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub delete_click(ByVal sender As Object)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            sender.DeleteSelectedRows()
            refreshNomer(sender)
        End If
    End Sub

    Private Sub GV2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_MATERIAl.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click(sender)
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_MATERIAl.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("KD_BARANG").ToString = "" Then
            e.Valid = False
            sender.SetColumnError(GVMMaterial, "Barang Belum Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Dim rw() As DataRow = ds1.Tables("BOM_Barang").Select("KD_BARANG = '" & e.Row.item("KD_BARANG") & "' and Kd_Service = '" & GV_Jenis_Service.GetRowCellValue(rhandle, "Kode_Service") & "'")
            If rw.Count = 1 Then
                If Not rw(0) Is e.Row.row Then
                    isValid = False
                    sender.SetColumnError(GVMMaterial, "Jenis Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                End If
            End If
        End If
        If e.Row.item("QTY").ToString = "" Then
            e.Valid = False
            sender.SetColumnError(gvmQty, "Qty Barang Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("QTY") <= 0 Then
            e.Valid = False
            sender.SetColumnError(gvmQty, "Qty Barang Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub
    Public Sub delete_click2()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            For Each item As DataRow In ds1.Tables("BOM_Barang").Select("Kd_Service = '" + GV_Jenis_Service.GetRowCellValue(GV_Jenis_Service.GetSelectedRows(0), "Kode_Service") + "'")
                item.Delete()
            Next
            GV_Jenis_Service.DeleteSelectedRows()

            refreshNomer2()
        End If
    End Sub
    Private Sub GV_Jenis_Service_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Jenis_Service.CellValueChanged
        Dim biayax As Double
        
        If e.Column Is gc_kd_service Then
            If Not e.Value Is Nothing Then
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "QC", ds1.Tables("Jns_Srv").Select("kd_service='" & e.Value & "'")(0)("QC"))
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Toleransi", ds1.Tables("Jns_Srv").Select("kd_service='" & e.Value & "'")(0)("toleransi"))

                biayax = getTarif(sender.GetRowCellValue(e.RowHandle, "Kode_Service").ToString, LU_Barang.GetColumnValue("Kd_Stok").ToString, sender.GetRowCellValue(e.RowHandle, "Kain").ToString)
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Biaya_Satuan", biayax)

                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "biaya", 0)
                'If GV_Jenis_Service.GetRowCellValue(e.RowHandle, "biaya") > 0 Then
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "FromTarif", "Y")

                'Else
                '    GV_Jenis_Service.SetRowCellValue(e.RowHandle, "FromTarif", "T")
                'End I
                For Each dr As DataRow In ds1.Tables("BOM_Barang").Select("Kd_Service='" & e.Value & "'")
                    dr.Delete()
                Next
                Dim i As Int32 = 1
                Dim jenis, merk, tipe, ukuran, kain As String
                With New SqlCommand("select * from sif.dbo.sif_barang where kode_barang='" & LU_Barang.GetColumnValue("Kd_Stok") & "'", sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        jenis = .Item("kd_jenis")
                        merk = .Item("kd_merk")
                        tipe = .Item("kd_tipe")
                        ukuran = .Item("kd_ukuran")
                        kain = .Item("kd_kain")
                    End If
                    .Close()
                End With
                Dim kd_kain As String
                If GV_Jenis_Service.GetRowCellValue(e.RowHandle, "kd_kain") Is Nothing Then
                    kd_kain = kain
                Else
                    kd_kain = GV_Jenis_Service.GetRowCellValue(e.RowHandle, "kd_kain").ToString
                End If

                Dim Sql As String = "select  nomor from sif.dbo.SIF_Tarif_Service where Jenis_Service='" & e.Value & "' and (JENIS = '" & jenis & "' or JENIS='%%') and (MERK = '" & merk & "' or MERK='%%') and (TIPE = '" & tipe & "' OR TIPE='%%') and (UKURAN = '" & ukuran & "' or UKURAN='%%')"
                With New SqlCommand(Sql, sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        nomor = .Item(0)
                    End If
                    .Close()
                End With

                With New SqlCommand("select bd.* " & _
                                    "from sif.dbo.SIF_SERVICE_BOM B, sif.dbo.SIF_SERVICE_BOM_D BD where kd_barang='" & LU_Barang.GetColumnValue("Kd_Stok") & "' and b.nomor=bd.nomor and b.Jenis_Kain=bd.kd_kain and bd.kd_kain='" & kain & "'", sqlconn).ExecuteReader
                    While .Read()
                        Dim drow As DataRow = ds1.Tables("BOM_Barang").NewRow
                        drow("NO_SEQ") = i : i += 1
                        drow("NO_SP") = LU_Barang.EditValue
                        drow("satuan") = .Item("Satuan")
                        drow("KD_BARANG") = .Item("Kd_Barang")
                        drow("Kd_Service") = e.Value
                        drow("QTY") = .Item("Qty")
                        drow("HARGA") = 0
                        drow("TOTAL") = 0
                        drow("MARGIN") = 0

                        ds1.Tables("BOM_Barang").Rows.Add(drow)
                    End While
                    .Close()
                End With
            End If
        ElseIf e.Column Is Kain Then
            If e.Value.ToString = "" Then
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "kd_kain", vbNullString)
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Kode_Service", GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Kode_Service"))
            End If
        ElseIf e.Column Is jnsKain Then
            If GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Kode_Service") Is Nothing Then Exit Sub
            If Not e.Value Is Nothing Then
                Dim service As String = GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Kode_Service").ToString
                For Each dr As DataRow In ds1.Tables("BOM_Barang").Select("Kd_Service='" & service & "'")
                    dr.Delete()
                Next
                biayax = getTarif(sender.GetRowCellValue(e.RowHandle, "Kode_Service").ToString, LU_Barang.GetColumnValue("Kd_Stok").ToString, sender.GetRowCellValue(e.RowHandle, "Kain").ToString, sender.GetRowCellValue(e.RowHandle, "kd_kain").ToString)
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Biaya_Satuan", biayax)
                Dim i As Int32 = 1
                Dim jenis, merk, tipe, ukuran As String
                With New SqlCommand("select * from sif.dbo.sif_barang where kode_barang='" & LU_Barang.GetColumnValue("Kd_Stok") & "'", sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        jenis = .Item("kd_jenis")
                        merk = .Item("kd_merk")
                        tipe = .Item("kd_tipe")
                        ukuran = .Item("kd_ukuran")

                    End If
                    .Close()
                End With

                Dim Sql As String = "select  nomor from sif.dbo.SIF_Tarif_Service where Jenis_Service='" & service & "' and (JENIS = '" & jenis & "' or JENIS='%%') and (MERK = '" & merk & "' or MERK='%%') and (TIPE = '" & tipe & "' OR TIPE='%%') and (UKURAN = '" & ukuran & "' or UKURAN='%%')"
                With New SqlCommand(Sql, sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        nomor = .Item(0)
                    End If
                    .Close()
                End With

                With New SqlCommand("select bd.* " & _
                                    "from sif.dbo.SIF_SERVICE_BOM B, sif.dbo.SIF_SERVICE_BOM_D BD where kd_barang='" & LU_Barang.GetColumnValue("Kd_Stok") & "' and b.nomor=bd.nomor and b.Jenis_Kain=bd.kd_kain and bd.kd_kain='" & e.Value & "'", sqlconn).ExecuteReader
                    While .Read()
                        Dim drow As DataRow = ds1.Tables("BOM_Barang").NewRow
                        drow("NO_SEQ") = i : i += 1
                        drow("NO_SP") = LU_Barang.EditValue
                        drow("satuan") = .Item("Satuan")
                        drow("KD_BARANG") = .Item("Kd_Barang")
                        drow("Kd_Service") = GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Kode_Service")
                        drow("QTY") = .Item("Qty")
                        drow("HARGA") = 0
                        drow("TOTAL") = 0
                        drow("MARGIN") = 0

                        ds1.Tables("BOM_Barang").Rows.Add(drow)
                    End While
                    .Close()
                End With
            End If
            'ElseIf e.Column Is Qty Then
            '    biaya = getTarif(sender.GetRowCellValue(e.RowHandle, "Kode_Service").ToString, LU_Barang.GetColumnValue("Kd_Stok").ToString, sender.GetRowCellValue(e.RowHandle, "Kain").ToString)
            '    GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Biaya_Satuan", biaya)
        End If
    End Sub

    Private Sub GV_Jenis_Service_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_Jenis_Service.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub GV_Jenis_Service_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_Jenis_Service.InitNewRow
        GV_Jenis_Service.GetRow(e.RowHandle).Item("no_seq") = GV_Jenis_Service.RowCount
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Nomor_SO") = GV_Jenis_Service.RowCount
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Jns_Service") = "REKOMENDASI"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Garansi") = "T"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Status") = "OK"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Qty") = 1
        GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Biaya_Satuan", 0)
    End Sub

    Private Sub GV_Jenis_Service_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_Jenis_Service.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click2()
        End If
    End Sub

    Private Sub GV_Jenis_Service_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_Jenis_Service.RowUpdated
        If txtStatusInspeksi.Text.ToString = "AKHIR" Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
            Dim detailView As DevExpress.XtraGrid.Views.Grid.GridView
            view.SetMasterRowExpanded(view.FocusedRowHandle, True)
            view.ExpandGroupRow(e.RowHandle)
            detailView = view.GetDetailView(view.FocusedRowHandle, 0)
            If Not detailView Is Nothing Then
                If detailView.RowCount = 0 Then
                    e.Row.row("Biaya_Satuan") = getTarif(e.Row.row("Kode_Service"), LU_Barang.GetColumnValue("Kd_Stok").ToString, e.Row.row("Kain").ToString)
                    e.Row.row("biaya") = e.Row.row("Biaya_Satuan") * e.Row.row("Qty")
                Else
                    detailView.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub GV_Jenis_Service_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_Jenis_Service.ShownEditor
        'If sender.FocusedColumn.Name = Kain.Name Then

        '    Dim row As DataRow
        '    row = sender.GetDataRow(sender.FocusedRowHandle)

        '    Dim edit As DevExpress.XtraEditors.LookUpEdit
        '    Dim table As DataTable
        '    edit = CType(sender.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
        '    table = CType(edit.Properties.DataSource, DataTable)
        '    clone = New DataView(table)
        '    Dim merk As String
        '    With New SqlCommand("select kd_merk from sif.dbo.sif_barang where kode_barang='" & LU_Barang.GetColumnValue("Kd_Stok").ToString & "'", sqlconn).ExecuteReader
        '        .Read()
        '        If .HasRows Then
        '            merk = .Item(0)
        '        End If
        '        .Close()
        '    End With

        '    clone.RowFilter = "Kode_Merk ='" & merk & "'"
        '    edit.Properties.DataSource = clone
        'End If
    End Sub
    Private Sub gvm_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_Jenis_Service.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gvd_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_MATERIAl.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_Jenis_Service_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Jenis_Service.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kode_Service") Is Nothing Then
            sender.SetColumnError(gc_kd_service, "Jenis Service Masih Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        Else
            Dim rw() As DataRow = ds1.Tables("BOM_Jns_Srv").Select("Kode_Service = '" & e.Row.item("Kode_Service") & "'")

            If rw.Count = 1 Then
                If Not rw(0) Is e.Row.row Then
                    isValid = False
                    sender.SetColumnError(gc_kd_service, "Jenis Service Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    MessageBox.Show("Jenis Service Sudah Ada dalam Daftar.")
                End If
            End If
        End If
        If e.Row.item("Jns_Service").ToString = "" Then
            sender.SetColumnError(Jns_Service, "Status Service Masih Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        End If
        If e.Row.item("Qty").ToString = "" Then
            sender.SetColumnError(Qty, "Qty Masih Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        ElseIf e.Row.item("Qty") <= 0 Then
            sender.SetColumnError(Qty, "Nilai Qty Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        End If
        If e.Row.item("Garansi").ToString = "" Then
            sender.SetColumnError(garansi, "Status Garansi Masih Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        End If
        e.Valid = isValid
    End Sub

    Public Sub save_click()
        Dim btrans As SqlTransaction
        If LU_SO.EditValue = Nothing Then
            MessageBox.Show("No. SO belum dipilih.")
            Exit Sub
        End If
        If LU_Barang.EditValue = Nothing Then
            MessageBox.Show("Barang belum dipilih.")
            Exit Sub
        End If
        If txtMasaPakai.Text = "" Then
            MessageBox.Show("Tahun pembuatan Belum Diisi.")
            Exit Sub
        End If
        If GV_Jenis_Service.RowCount < 1 Then
            MessageBox.Show("Data Jenis Service belum diisi.")
            Exit Sub
        End If
        Dim fnd As Boolean = False
        For i As Int16 = 0 To GV_Jenis_Service.RowCount - 1
            If GV_Jenis_Service.GetRowCellDisplayText(i, "Kode_Service").Contains("GANTI KAIN") And txtNamaBaru.Text = "" Then
                fnd = True
                If MsgBox("Service Ganti Kain Ditemukan, Ganti Nama Barang ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    txtNamaBaru.Focus()
                    Exit Sub
                End If
            End If
            If fnd Then Exit For
        Next

        Dim tgl As Date = getTanggal()

        For Each rows As DataRow In ds1.Tables("BOM_Jns_Srv").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("Nomor_SO") = LU_SO.EditValue.ToString
                    rows.Item("sp_seq") = LU_Barang.GetColumnValue("No_seq")
                    rows.Item("kd_stok") = LU_Barang.EditValue
                    rows.Item("departemen") = kddep
                    rows.Item("Last_create_date") = tgl
                    rows.Item("Last_created_by") = username
                    rows.Item("Programe_name") = Me.Name
                End If
                rows.Item("Last_update_date") = tgl
                rows.Item("kd_cabang") = kdcabang
                rows.Item("departemen") = kddep
                rows.Item("Last_updated_by") = username
                rows.Item("Programe_name") = Me.Name
            End If
        Next

        For Each rows As DataRow In ds1.Tables("BOM_Barang").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("NO_SP") = LU_SO.EditValue.ToString
                    rows.Item("NO_SEQ_SP") = LU_Barang.GetColumnValue("No_seq")
                End If
            End If
        Next

        Try
            Dim mybuilder2 As New SqlCommandBuilder(da2)
            mybuilder2.ConflictOption = ConflictOption.OverwriteChanges
            da2.UpdateCommand = mybuilder2.GetUpdateCommand
            da2.InsertCommand = mybuilder2.GetInsertCommand
            da2.DeleteCommand = mybuilder2.GetDeleteCommand

            mybuilder2 = New SqlCommandBuilder(da3)
            mybuilder2.ConflictOption = ConflictOption.OverwriteChanges
            da3.UpdateCommand = mybuilder2.GetUpdateCommand
            da3.InsertCommand = mybuilder2.GetInsertCommand
            da3.DeleteCommand = mybuilder2.GetDeleteCommand

            btrans = sqlconn.BeginTransaction("1")

            da2.UpdateCommand.Transaction = btrans
            da2.InsertCommand.Transaction = btrans
            da2.DeleteCommand.Transaction = btrans

            da3.UpdateCommand.Transaction = btrans
            da3.InsertCommand.Transaction = btrans
            da3.DeleteCommand.Transaction = btrans

            da2.Update(ds1.Tables("BOM_Jns_Srv"))
            da3.Update(ds1.Tables("BOM_Barang"))
            'Dim bs As Double = 0
            'If umur > 0 And txtMasaPakai.EditValue > 0 Then
            '    If umur <= txtMasaPakai.EditValue Then
            '        'Dim dr As SqlDataReader = New SqlCommand("select count(1) from sif.dbo.sif_barang, sif.dbo.sif_jenis_barang where kode_barang='" & LU_Barang.EditValue & "' and Kd_Jns_Brg=kd_jns_persd and (group='01' or  Kd_Jns_Brg = '014') ", sqlconn).ExecuteReader
            '        Dim dr As SqlDataReader = New SqlCommand("select count(1) from sif.dbo.sif_barang B, sif.dbo.sif_jenis_barang A where kode_barang='" & LU_Barang.EditValue & "' and a.Kd_Jns_Brg=B.kd_jenis and (A.[group]='01' or  A.Kd_Jns_Brg = '014')  ", sqlconn).ExecuteReader

            '        dr.Read()
            '        If dr.HasRows Then bs = biaya_service
            '    End If
            'End If
            'With New SqlCommand("update sales.dbo.sales_so_d set harga = isnull(harga,0) + " & bs & ", Biaya_Service=" & bs & " ,thnbuat=" & txtThnbuat.Text & ", Status_Inspeksi='" & txtStatusInspeksi.Text & "' where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

            'End With
            'If txtNamaBaru.Text <> "" Then
            '    With New SqlCommand("update sales.dbo.sales_so_d set Deskripsi = '" & txtNamaBaru.Text & "' where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

            '    End With
            'End If
            'If txtStatusInspeksi.Text = "AKHIR" Then
            '    Dim biaya As Double = 0
            '    For Each rw As DataRow In ds1.Tables("BOM_Jns_Srv").Select("Rek ='YA' and Status='OK'")
            '        biaya += rw.Item("biaya")
            '    Next

            '    With New SqlCommand("update sales.dbo.sales_so_d set harga = @BIAYA where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans)
            '        .Parameters.Add("@BIAYA", SqlDbType.Decimal, 10).Value = biaya + bs
            '        .ExecuteNonQuery()
            '    End With
            'End If

            Dim bs As Double = 0
            If umur > 0 And txtMasaPakai.EditValue > 0 Then
                'If umur <= txtMasaPakai.EditValue Then
                If umur < txtMasaPakai.EditValue Then

                    'Dim dr As SqlDataReader = New SqlCommand("select count(1) from sif.dbo.sif_barang, sif.dbo.sif_jenis_barang where kode_barang='" & LU_Barang.EditValue & "' and Kd_Jns_Brg=kd_jns_persd and (group='01' or  Kd_Jns_Brg = '014') ", sqlconn).ExecuteReader
                    Dim dr As SqlDataReader = New SqlCommand("select count(1) from sif.dbo.sif_barang B, sif.dbo.sif_jenis_barang A where kode_barang='" & LU_Barang.EditValue & "' and a.Kd_Jns_Brg=B.kd_jenis and (A.[group]='01' or  A.Kd_Jns_Brg = '014')  ", sqlconn, btrans).ExecuteReader

                    dr.Read()
                    If dr.HasRows Then bs = biaya_service
                    dr.Close()
                End If
            End If
            With New SqlCommand("update sales.dbo.sales_so_d set harga = isnull(harga,0) + " & bs & ", Biaya_Service=" & bs & " ,thnbuat=" & txtThnbuat.Text & ", Status_Inspeksi='" & txtStatusInspeksi.Text & "' where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

            End With
            If txtNamaBaru.Text <> "" Then
                With New SqlCommand("update sales.dbo.sales_so_d set Deskripsi = '" & txtNamaBaru.Text & "' where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

                End With
            End If
            If txtStatusInspeksi.Text = "AKHIR" Then
                Dim biaya As Double = 0
                For Each rw As DataRow In ds1.Tables("BOM_Jns_Srv").Select("Rek ='YA' and Status='OK'")
                    biaya += rw.Item("biaya")
                Next

                With New SqlCommand("update sales.dbo.sales_so_d set harga = @BIAYA where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans)
                    .Parameters.Add("@BIAYA", SqlDbType.Decimal, 10).Value = biaya + bs
                    .ExecuteNonQuery()
                End With
            End If
            If ds1.Tables("BOM_Jns_Srv").Rows.Count = 0 Then
                With New SqlCommand("update sales.dbo.sales_so_d set [Status_Inspeksi] = null where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

                End With
            End If
            btrans.Commit()
            showMessages("Data berhasil disimpan.")
            State = "EDIT"

            cancel_click()
        Catch ex As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            MessageBox.Show(ex.Message, "Gagal Simpan")

        End Try
    End Sub
    Private Function getTarif(ByVal kd_bom As String, ByVal kd_stok As String, Optional ByVal kd_kain As String = "", Optional ByVal merk_kain As String = "")
        Dim hasil As Double = 0

        Dim jenis, merk, tipe, subtipe, ukuran, kain, sql As String
        With New SqlCommand("select * from sif.dbo.sif_barang where kode_barang='" & kd_stok & "'", sqlconn).ExecuteReader
            .Read()
            sql = ""

            If .HasRows Then
                jenis = .Item("kd_jenis")
                merk = .Item("kd_merk")
                tipe = .Item("kd_tipe")
                ukuran = .Item("kd_ukuran")
                subtipe = .Item("kd_kain")
                kain = .Item("kd_sub_tipe")
            End If
            .Close()
            If kd_kain = "" Then kd_kain = tipe
            If merk_kain = "" Then merk_kain = kain
            sql = "select top 1 Tarif from sif.dbo.SIF_Tarif_Service where Jenis_Service='" & kd_bom & "' and (JENIS = '" & jenis & "' or JENIS='%%') and (MERK = '" & merk & "' or MERK='%%') and  (TIPE = '" & kd_kain & "' OR TIPE='%%') and  (SUBTIPE = '" & subtipe & "' OR SUBTIPE='%%') and  (UKURAN = '" & ukuran & "' or UKURAN='%%')  and  (KAIN = '" & kain & "' or KAIN='%%') order by SUBTIPE desc"
            With New SqlCommand(sql, sqlconn).ExecuteReader
                .Read()
                If .HasRows Then
                    hasil = .Item(0)
                End If
                .Close()
            End With
        End With
        Return hasil
    End Function
    Public Sub edit_click()
        isload = False
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        'da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, case Nama_Customer when 'UMUM' then nama_pnrm else Nama_Customer end Customer, tgl_sp TGL, " & _
        '" nama_barang_asli Barang, no_seq, Kd_Stok " & _
        '" from [SALES].[dbo].[vSOD_REP] sod where isClosed is null and  isnull(confirmed,'0') <> '2' and tipe_trans='" & ServiceSpringUmum & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, case Nama_Customer when 'UMUM' then nama_pnrm else Nama_Customer end Customer, tgl_sp TGL, " & _
       " sod.Deskripsi Barang, no_seq, Kd_Stok " & _
       " from [SALES].[dbo].[vSOD_REP] sod where isClosed is null and  isnull(confirmed,'0') <> '2' and Status_inspeksi='SUDAH INSPEKSI' and tipe_trans in ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "')", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns("no_seq").Visible = False
        frmCari.GV.Columns("Kd_Stok").Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            isload = True
            Dim kd_stok As String = frmCari.row("Kd_Stok").ToString
            'txtStatusKonfirmasi.Text = frmCari.row("STATUS KONFIRMASI").ToString
            If Not ds1.Tables("SO") Is Nothing Then ds1.Tables("SO").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select d.No_sp, case d.Nama_Customer when 'UMUM' then Nama_pnrm else d.Nama_Customer end as Customer, d.Tgl_sp, No_telp from SALES.dbo.vso_rep d where d.no_sp='" & frmCari.row("No_sp") & "' ", sqlconn))
            da1.Fill(ds1, "SO")

            LU_SO.EditValue = frmCari.row("No_sp")
            txt_NamaCust.Text = ds1.Tables("SO")(0)("Customer").ToString
            reload_edit(frmCari.row("No_sp").ToString, frmCari.row("no_seq").ToString)

            LU_Barang.EditValue = frmCari.row("no_seq").ToString

            Try
                txtThnbuat.Text = ds1.Tables("Barang")(0)("thnbuat")
            Catch ex As Exception
                txtThnbuat.Text = 0
            End Try
            State = "EDIT"
            LU_SO.Properties.ReadOnly = True
            LU_Barang.Properties.ReadOnly = True
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
            isload = False
        Else
            cancel_click()
        End If
    End Sub

    Private Sub LU_Barang_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LU_Barang.QueryPopUp
        If State <> "ADD" Then
            e.Cancel = True
            showMessages("Tidak Bisa Mengganti SP Service")
        End If
    End Sub

    Private Sub frmServiceCSO_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 0
        pnl.Height = Me.Height
        pnl.Left = (Me.Width - pnl.Width) / 2
    End Sub

    Private Sub LU_Barang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LU_Barang.EditValueChanged
        If Not LU_Barang.EditValue Is Nothing Then
            txtKeterangan.Text = LU_Barang.GetColumnValue("Keterangan").ToString

            If LU_Barang.GetColumnValue("Status_Inspeksi").ToString = "" Then
                txtStatusInspeksi.Text = "AWAL"
            ElseIf LU_Barang.GetColumnValue("Status_Inspeksi").ToString = "AWAL" And LU_Barang.GetColumnValue("CONFIRMED").ToString <> "" Then
                txtStatusInspeksi.Text = "AKHIR"
            Else
                txtStatusInspeksi.Text = "AKHIR"
            End If
            If Not isload Then
                ds1.Tables("BOM_Barang").Clear()
                ds1.Tables("BOM_Jns_Srv").Clear()
            End If
            If Not ds1.Tables("TIPE") Is Nothing Then ds1.Tables("TIPE").Clear()
            da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk, Kode_Tipe, Nama_Tipe from SIF.dbo.SIF_TIPE as sf , sif.dbo.sif_barang where sf.rec_stat='Y' and Kode_Barang='" & LU_Barang.Properties.GetDataSourceValue("Kd_Stok", LU_Barang.ItemIndex).ToString() & "' and kd_tipe=kode_tipe and kd_merk = Kode_Merk   union select '', '', 'IDEM' ", sqlconn))
            da1.Fill(ds1, "TIPE")

            If Not ds1.Tables("KAIN") Is Nothing Then ds1.Tables("KAIN").Clear()
            da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain, Merk_Kain + ' ' + isnull(Warna,'')  as Kain from SIF.dbo.SIF_Kain where rec_stat='Y' and Kode_Kain in (select kd_kain from sif.dbo.sif_barang where kd_merk='" & LU_Barang.Properties.GetDataSourceValue("kd_merk", LU_Barang.ItemIndex).ToString() & "' and kd_tipe='" & LU_Barang.Properties.GetDataSourceValue("kd_tipe", LU_Barang.ItemIndex).ToString() & "') union select '','' ", sqlconn))
            da1.Fill(ds1, "KAIN")
        Else
            txtThnbuat.Text = vbNullString
            txtKeterangan.Text = ""
            txtMasaPakai.Text = ""
        End If


    End Sub
    Public Sub cetak_click()
        If State = "EDIT" Then
            Try
                callReport(App_Path() & "\report\vBomService.rpt", "", "No_sp=" & LU_SO.EditValue & ";No_seq='" & LU_Barang.EditValue & "'", True, True)
                If ds1.Tables("BOM_Jns_Srv").Select("QC= 'Y' and toleransi > " & txtMasaPakai.Text).Count > 0 Then
                    callReport(App_Path() & "\report\vBomService.rpt", "", "", True, True)
                End If
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
            End Try
        End If
    End Sub

    Private Sub GV_MATERIAl_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_MATERIAl.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "NO_SEQ", sender.RowCount + 1)

    End Sub

    Private Sub txtThnbuat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThnbuat.EditValueChanged
        If txtThnbuat.Text <> "" Then
            txtMasaPakai.Text = getTanggal.Year - (txtThnbuat.EditValue)
        Else
            txtMasaPakai.Text = ""
        End If
    End Sub
    Private Sub GV_Jenis_Service_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV_Jenis_Service.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub

    'Private Sub GV_MATERIAl_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_MATERIAl.RowUpdated
    ' Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
    ' GV_Jenis_Service.SetRowCellValue(rhandle, "biaya", view.Columns("TOTAL").SummaryItem.SummaryValue)
    'End Sub

    Private Sub repStatus_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles repStatus.EditValueChanging
        If txtStatusInspeksi.Text.ToString <> "AKHIR" Then
            e.Cancel = True
        ElseIf e.NewValue = "BATAL" Then
            If MsgBox("Batalkan Service ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                For Each rw As DataRow In ds1.Tables("BOM_Barang").Select("Kd_Service='" & GV_Jenis_Service.GetRowCellValue(rhandle, "Kode_Service").ToString & "'")
                    rw.Delete()
                Next

            End If
        End If
    End Sub

    Private Sub GV_Jenis_Service_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GV_Jenis_Service.MasterRowExpanding
        If txtStatusInspeksi.Text.ToString <> "AKHIR" Then
            e.Allow = False
        ElseIf GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Status").ToString = "BATAL" Then
            e.Allow = False
        ElseIf GV_Jenis_Service.GetRowCellValue(e.RowHandle, "Rek").ToString = "TIDAK" Then
            e.Allow = False
        End If
    End Sub

    Private Sub GV_Jenis_Service_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GV_Jenis_Service.ShowingEditor
        If Not GV_Jenis_Service.GetRowCellValue(GV_Jenis_Service.GetSelectedRows(0), "Kode_Service") Is Nothing Then
            If GV_Jenis_Service.GetRowCellValue(GV_Jenis_Service.GetSelectedRows(0), "Rek").ToString = "TIDAK" Then
                e.Cancel = True
            ElseIf GV_Jenis_Service.GetRowCellValue(GV_Jenis_Service.GetSelectedRows(0), "Status").ToString = "BATAL" Then
                If sender.FocusedColumn.Name = Status.Name Or sender.FocusedColumn.Name = gc_ket.Name Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If

            End If
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class