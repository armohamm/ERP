Imports System.Data.SqlClient
Public Class frmServiceCSOInternal
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
    Dim clone As Object
    Public isload As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmServiceCSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
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
    End Sub
    Public Sub reload()
        If Not ds1.Tables("SO") Is Nothing Then ds1.Tables("SO").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select d.No_sp, 'INTERNAL' as Customer, d.Tgl_sp, No_telp from SALES.dbo.vso_rep d where Tipe_trans='" & ServiceSpringInternal & "' and isnull(isPrinted,'')='' and status='OK' and isnull(isClosed,'')='' and ((select count(1) from SALES.dbo.sales_so_d dd where dd.no_sp= d.No_sp) <> (select count(distinct sp_seq) from sales.dbo.sales_produk_service ss where ss.nomor_so=d.no_sp)) ", sqlconn))
        da1.Fill(ds1, "SO")

        If Not ds1.Tables("Jns_Srv") Is Nothing Then ds1.Tables("Jns_Srv").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_service, nama_service, QC, toleransi from [SIF].[dbo].SIF_bom_service where rec_stat='Y' ", sqlconn))
        da1.Fill(ds1, "Jns_Srv")

        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, KD_SATUAN from SIF.dbo.SIF_Barang where kd_jns_persd <> 1 and  Rec_Stat='Y'", sqlconn))
        da1.Fill(ds1, "jnsBarang")
    End Sub
    Public Sub reload_edit(ByVal no_sp As String, ByVal no_seq As String)
        If Not ds1.Tables("BOM_Jns_Srv") Is Nothing Then ds1.Tables("BOM_Jns_Srv").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select *, case Terima_Rekomendasi when 'Y' then 'Ya' else 'Tidak' end Rek from SALES.dbo.SALES_PRODUK_SERVICE S where S.Nomor_SO ='" & no_sp & "' and S.sp_seq ='" & no_seq & "' order by s.no_seq", sqlconn))
        da2.Fill(ds1, "BOM_Jns_Srv")
        GC_Jns_Service.DataSource = ds1.Tables("BOM_Jns_Srv")

        If Not ds1.Tables("BOM_Barang") Is Nothing Then ds1.Tables("BOM_Barang").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select *, (select Kd_Satuan from SIF.dbo.SIF_Barang b where S.KD_BARANG = b.Kode_Barang) as satuan  from SALES.dbo.SALES_BOM_SERVICE S " & _
                                                "where S.NO_SP ='" & no_sp & "' and S.NO_SEQ_SP ='" & no_seq & "' order by s.no_seq", sqlconn))
        da3.Fill(ds1, "BOM_Barang")
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select Distinct d.Kd_Stok, d.Keterangan, d.No_sp, Status_Inspeksi " & _
                                                ",d.No_seq,b.Nama_Barang, thnbuat from SALES.dbo.SALES_SO_D d " & _
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
        LU_Barang.EditValue = vbNullString
        LU_SO.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtMasaPakai.EditValue = vbNullString
        txtStatusInspeksi.EditValue = vbNullString
        txtThnbuat.EditValue = vbNullString
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
        LU_Barang.EditValue = vbNullString
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        If State = "ADD" Then
            da1 = New SqlDataAdapter(New SqlCommand("select Kd_Stok, Nama_Barang_Asli as Nama_Barang, No_seq, Keterangan, thnbuat from sales.dbo.vsod_rep where no_sp='" & LU_SO.EditValue & "' and no_seq not in (select sp_seq from sales.dbo.sales_produk_service where nomor_so='" & LU_SO.EditValue & "' )", sqlconn))
            da1.Fill(ds1, "Barang")
        Else
            da1 = New SqlDataAdapter(New SqlCommand("select Kd_Stok, Nama_Barang_Asli as Nama_Barang, No_seq, Keterangan, thnbuat from sales.dbo.vsod_rep where no_sp='" & LU_SO.EditValue & "' and no_seq in (select sp_seq from sales.dbo.sales_produk_service where nomor_so='" & LU_SO.EditValue & "' )", sqlconn))
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
                    With New SqlCommand("select harga_rupiah from sif.dbo.sif_harga where Kode_Barang = '" & e.Value & "'", sqlconn).ExecuteReader
                        .Read()
                        If .HasRows Then
                            harga = .Item(0)
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
            Dim rw() As DataRow = ds1.Tables("BOM_Barang").Select("KD_BARANG = '" & e.Row.item("KD_BARANG") & "'")
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
            GV_Jenis_Service.DeleteSelectedRows()
            refreshNomer2()
        End If
    End Sub

    Private Sub GV_Jenis_Service_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Jenis_Service.CellValueChanged
        If e.Column Is gc_kd_service Then
            If Not e.Value Is Nothing Then
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "QC", ds1.Tables("Jns_Srv").Select("kd_service='" & e.Value & "'")(0)("QC"))
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "Toleransi", ds1.Tables("Jns_Srv").Select("kd_service='" & e.Value & "'")(0)("toleransi"))
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "biaya", 0)
                'If GV_Jenis_Service.GetRowCellValue(e.RowHandle, "biaya") > 0 Then
                GV_Jenis_Service.SetRowCellValue(e.RowHandle, "FromTarif", "Y")
                'Else
                'GV_Jenis_Service.SetRowCellValue(e.RowHandle, "FromTarif", "T")
                'End If
                For Each dr As DataRow In ds1.Tables("BOM_Barang").Select("Kd_Service='" & e.Value & "'")
                    dr.Delete()
                Next
            End If
        End If
    End Sub

    Private Sub GV_Jenis_Service_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV_Jenis_Service.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub GV_Jenis_Service_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_Jenis_Service.InitNewRow
        GV_Jenis_Service.GetRow(e.RowHandle).Item("no_seq") = GV_Jenis_Service.RowCount + 1
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Terima_Rekomendasi") = "Y"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("FromTarif") = "T"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Status") = "OK"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Qty") = "0"
        GV_Jenis_Service.GetRow(e.RowHandle).Item("Biaya_Satuan") = "0"


    End Sub

    Private Sub GV_Jenis_Service_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_Jenis_Service.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click2()
        End If
    End Sub

    Private Sub GV_Jenis_Service_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_Jenis_Service.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim detailView As DevExpress.XtraGrid.Views.Grid.GridView
        view.SetMasterRowExpanded(view.FocusedRowHandle, True)
        view.ExpandGroupRow(e.RowHandle)
        detailView = view.GetDetailView(view.FocusedRowHandle, 0)
        If detailView.RowCount = 0 Then
            e.Row.row("biaya") = 0 'getTarif(e.Row.row("Kode_Service"), LU_Barang.GetColumnValue("Kd_Stok").ToString, e.Row.row("Kain").ToString)
        Else
            detailView.Focus()
        End If
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

        If GV_Jenis_Service.RowCount < 1 Then
            MessageBox.Show("Data Jenis Service belum diisi.")
            Exit Sub
        End If

        Dim tgl As Date = getTanggal()

        For Each rows As DataRow In ds1.Tables("BOM_Jns_Srv").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("Nomor_SO") = LU_SO.EditValue.ToString
                    rows.Item("sp_seq") = LU_Barang.GetColumnValue("No_seq")
                    rows.Item("kd_stok") = LU_Barang.EditValue
                    rows.Item("departemen") = KD_DIV_SPRING
                    rows.Item("Last_create_date") = tgl
                    rows.Item("Last_created_by") = username
                    rows.Item("Programe_name") = Me.Name
                End If
                rows.Item("Last_update_date") = tgl
                rows.Item("kd_cabang") = kdcabang
                rows.Item("departemen") = KD_DIV_SPRING
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
            With New SqlCommand("update sales.dbo.sales_so_d set thnbuat=" & txtThnbuat.Text & ", Status_Inspeksi='AKHIR' where no_sp='" & LU_SO.EditValue & "' and No_seq='" & LU_Barang.EditValue & "'", sqlconn, btrans).ExecuteNonQuery

            End With
            showMessages("Data berhasil disimpan.")
            State = "EDIT"
            btrans.Commit()
        Catch ex As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            MessageBox.Show(ex.Message, "Gagal Simpan")

        End Try
    End Sub
    Private Function getTarif(ByVal kd_bom As String, ByVal kd_stok As String, Optional ByVal kd_kain As String = "")
        Dim dr, dr2 As SqlDataReader
        Dim hasil As Double = 0
        dr = New SqlCommand("select * from sif.dbo.sif_barang where Kode_Barang='" & kd_stok & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If kd_kain = "" Then kd_kain = dr("kd_tipe")
            dr2 = New SqlCommand("select Tarif from sif.dbo.SIF_Tarif_Service where Merk='" & dr("kd_merk") & "' and Tipe='" & kd_kain & "' and Jenis='" & dr("kd_jenis") & "' and Ukuran='" & dr("kd_ukuran") & "' and Service='" & kd_bom & "'", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                hasil = dr2(0)
            End If
            dr2.Close()
        End If
        dr.Close()

        Return hasil
    End Function
    Public Sub edit_click()
        isload = False
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_sp, case Nama_Customer when 'UMUM' then nama_pnrm else Nama_Customer end Customer, tgl_sp TGL, nama_barang_asli Barang, no_seq, Kd_Stok from [SALES].[dbo].[vSOD_REP] sod where isClosed is null and isnull(status_inspeksi,'') <> ''", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns("no_seq").Visible = False
        frmCari.GV.Columns("Kd_Stok").Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        Dim kd_stok As String = frmCari.row("Kd_Stok").ToString
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            isload = True
            If Not ds1.Tables("SO") Is Nothing Then ds1.Tables("SO").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select d.No_sp, 'INTERNAL' Customer, d.Tgl_sp, No_telp from SALES.dbo.vso_rep d where d.no_sp='" & frmCari.row("No_sp") & "' ", sqlconn))
            da1.Fill(ds1, "SO")

            LU_SO.EditValue = frmCari.row("No_sp")
            reload_edit(frmCari.row("No_sp").ToString, frmCari.row("no_seq").ToString)

            LU_Barang.EditValue = frmCari.row("no_seq").ToString

            txtThnbuat.Text = ds1.Tables("Barang")(0)("thnbuat")
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
            txtStatusInspeksi.Text = "AKHIR"
            If Not isload Then
                ds1.Tables("BOM_Barang").Clear()
                ds1.Tables("BOM_Jns_Srv").Clear()
            End If
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
        sender.SetRowCellValue(e.RowHandle, "HARGA", 0)
        sender.SetRowCellValue(e.RowHandle, "TOTAL", 0)
        sender.SetRowCellValue(e.RowHandle, "MARGIN", 0)
    End Sub

    Private Sub txtThnbuat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThnbuat.EditValueChanged
        If txtThnbuat.Text <> "" Then
            txtMasaPakai.Text = getTanggal.Year - (txtThnbuat.EditValue - 1)
        Else
            txtMasaPakai.Text = ""
        End If
    End Sub
    Private Sub GV_Jenis_Service_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV_Jenis_Service.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub

    Private Sub GV_MATERIAl_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_MATERIAl.RowUpdated
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        GV_Jenis_Service.SetRowCellValue(rhandle, "biaya", view.Columns("TOTAL").SummaryItem.SummaryValue)
    End Sub
End Class