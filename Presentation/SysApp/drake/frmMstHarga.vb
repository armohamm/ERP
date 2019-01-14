'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================

Imports System.Data.SqlClient

Public Class frmMstHarga
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_brg, ds_jnbrg, ds_merk As New DataSet
    Public dSOt As New DataSet
    'Private rw As DataRow
    Dim DA, DA_brg, DA_jnbrg, DA_merk As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        If Not dSO.Tables("_SIF_mHarga") Is Nothing Then dSO.Tables("_SIF_mHarga").Clear()
        DA = New SqlDataAdapter(New SqlCommand("SELECT *, " & _
             " (select Nama_Barang from SIF.dbo.SIF_Barang where rec_stat='Y' and h.kode_barang=kode_barang) as Nama, " & _
             " (select kd_jenis from sif.dbo.sif_barang b where h.kode_barang = b.kode_barang) as _jenisbrg  " & _
            " FROM SIF.dbo.SIF_Harga h where REC_STAT='Y' and exists (select 1 from (select h2.Kode_Barang, MAX(h2.start_date) [start_date] from SIF.dbo.SIF_Harga h2 group by h2.Kode_Barang) h3 where h3.Kode_Barang=h.Kode_Barang and h3.start_date =h.Start_Date )  AND exists (select 1 from sif.dbo.sif_barang b, sif.dbo.sif_ukuran where kode_ukuran = kd_ukuran and h.kode_barang = b.kode_barang and b.rec_stat='Y' and kd_satuan <> 'SET')", sqlconn))
        '" FROM SIF.dbo.SIF_Harga h where REC_STAT='Y' and exists (select 1 from (select h2.Kode_Barang, MAX(h2.start_date) [start_date] from SIF.dbo.SIF_Harga h2 group by h2.Kode_Barang) h3 where h3.Kode_Barang=h.Kode_Barang and h3.start_date =h.Start_Date )  AND exists (select 1 from sif.dbo.sif_barang b, sif.dbo.sif_ukuran where kode_ukuran = kd_ukuran and isnull(alias,'') <> 'KHS' and h.kode_barang = b.kode_barang and b.rec_stat='Y' and kd_satuan <> 'SET')", sqlconn))
        DA.Fill(dSO, "_SIF_mHarga")
        GcMstHarga.DataSource = dSO.Tables("_SIF_mHarga")

    End Sub
    Public Sub delete_click()
        If GvMstHarga.GetSelectedRows.Count > 0 Then
            GvMstHarga.DeleteSelectedRows()
        End If
    End Sub
    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub cetak_click()
        print_gc(GcMstHarga, "Price List", True)
    End Sub
    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_SIF_mHarga").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = kdcabang
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = getTanggal()
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = getTanggal()
                rw.Item("Last_Updated_By") = username
            End If
        Next
        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "_SIF_mHarga")
        dSO.Tables("_SIF_mHarga").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMstHarga.SelectedRowsCount - 1)
        For i = 0 To GvMstHarga.SelectedRowsCount - 1
            rows(i) = GvMstHarga.GetDataRow(GvMstHarga.GetSelectedRows(i))
        Next
        GvMstHarga.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GvMstHarga.EndSort()
        End Try
        simpan()
    End Sub

  
    Private Sub frmMstHarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'ds_cari = New DataSet
        DA = New SqlDataAdapter(New SqlCommand("SELECT *, " & _
            " (select Nama_Barang from SIF.dbo.SIF_Barang where rec_stat='Y' and h.kode_barang=kode_barang) as Nama, " & _
            " (select kd_jenis from sif.dbo.sif_barang b where h.kode_barang = b.kode_barang) as _jenisbrg  " & _
            " FROM SIF.dbo.SIF_Harga h where REC_STAT='Y' and exists (select 1 from (select h2.Kode_Barang, MAX(h2.start_date) [start_date] from SIF.dbo.SIF_Harga h2 group by h2.Kode_Barang) h3 where h3.Kode_Barang=h.Kode_Barang and h3.start_date =h.Start_Date ) AND exists (select 1 from sif.dbo.sif_barang b, sif.dbo.sif_ukuran where kode_ukuran = kd_ukuran and h.kode_barang = b.kode_barang  and b.rec_stat='Y' and kd_satuan <> 'SET')", sqlconn))

        '" FROM SIF.dbo.SIF_Harga h where REC_STAT='Y' and exists (select 1 from (select h2.Kode_Barang, MAX(h2.start_date) [start_date] from SIF.dbo.SIF_Harga h2 group by h2.Kode_Barang) h3 where h3.Kode_Barang=h.Kode_Barang and h3.start_date =h.Start_Date ) AND exists (select 1 from sif.dbo.sif_barang b, sif.dbo.sif_ukuran where kode_ukuran = kd_ukuran and isnull(alias,'') <> 'KHS' and h.kode_barang = b.kode_barang  and b.rec_stat='Y' and kd_satuan <> 'SET')", sqlconn))
        DA.Fill(dSO, "_SIF_mHarga")
        GcMstHarga.DataSource = dSO.Tables("_SIF_mHarga")

        '======== Load utk dataset cari di table barang dan mengisikan kode/nama barang yg sdh ada
        DA_brg = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang where kd_jns_persd in ('1','2','3') and rec_stat='Y'", sqlconn))
        DA_brg.Fill(ds_brg, "_lu_brg")
        repBarang.DataSource = ds_brg.Tables("_lu_brg")
        repBarang.ValueMember = "Kode_Barang"
        repBarang.DisplayMember = "Nama_Barang"

        With txtBarang.Properties.View.Columns.Add
            .Caption = "Deskripsi"
            .FieldName = "Nama_Barang"
            .Visible = True
            .AppearanceHeader.ForeColor = Color.Black
        End With
        txtBarang.Properties.DataSource = ds_brg.Tables("_lu_brg")

        DA_jnbrg = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg,Nama_Jenis from SIF.dbo.SIF_Jenis_Barang where rec_stat='Y' order by Nama_Jenis", sqlconn))
        DA_jnbrg.Fill(ds_jnbrg, "_lu_jnbrg")
        RL_jnbrg.DataSource = ds_jnbrg.Tables("_lu_jnbrg")
        RL_jnbrg.ValueMember = "Kd_Jns_Brg"
        RL_jnbrg.DisplayMember = "Nama_Jenis"
        cmdJenis.Properties.DataSource = ds_jnbrg.Tables("_lu_jnbrg")

        DA_merk = New SqlDataAdapter(New SqlCommand("select Kode_Merk,Nama_Merk from SIF.dbo.SIF_Merk where rec_stat='Y'", sqlconn))
        DA_merk.Fill(ds_merk, "_lu_merk")
        RL_merk.DataSource = ds_merk.Tables("_lu_merk")
        RL_merk.ValueMember = "Kode_Merk"
        RL_merk.DisplayMember = "Nama_Merk"
        cmdMerk.Properties.DataSource = ds_merk.Tables("_lu_merk")

        DA_merk = New SqlDataAdapter(New SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe from [SIF].[dbo].[SIF_Sub_tipe] where rec_stat='Y' order by Nama_Sub_Tipe", sqlconn))
        DA_merk.Fill(ds_merk, "subtipe")
        cmdSubTipe.Properties.DataSource = ds_merk.Tables("subtipe")

        DA_merk = New SqlDataAdapter(New SqlCommand("select kode_ukuran, nama_ukuran from [SIF].[dbo].[SIF_Ukuran] where rec_stat='Y' order by nama_ukuran", sqlconn))
        DA_merk.Fill(ds_merk, "ukuran")
        cmdUkuran.Properties.DataSource = ds_merk.Tables("ukuran")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub
    Private Sub txtCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ftr As String = "Nama Like '%" & txtCari.Text & "%'"
            GvMstHarga.Columns("Nama").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)

        End If
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If tglBerlaku.EditValue Is Nothing Then Exit Sub
        If txtBarang.Text = "" Then
            If cmdTipe.EditValue.ToString = "" Then Exit Sub
            If cmdMerk.EditValue.ToString = "" Then Exit Sub
            If cmdTipe.EditValue.ToString = "" Then Exit Sub
            With New SqlCommand("select * from SIF.dbo.SIF_Barang where kd_jenis='" & cmdJenis.EditValue & "' and kd_merk='" & cmdMerk.EditValue & "' and  kd_tipe='" & cmdTipe.EditValue & "' and  kd_ukuran='" & cmdUkuran.EditValue & "' and kd_sub_tipe like '%" & cmdSubTipe.EditValue & "%'", sqlconn).ExecuteReader
                .Read()
                If .HasRows Then
                    Do
                        Dim rw() As DataRow = dSO.Tables("_SIF_mHarga").Select("Kode_Barang = '" & .Item("Kode_Barang") & "' and Start_Date = '" & tglBerlaku.EditValue & "'")
                        If rw.Count = 0 Then
                            Dim newrow As DataRow = dSO.Tables("_SIF_mHarga").NewRow
                            newrow("Kd_Cabang") = kdcabang
                            newrow("Kode_Barang") = .Item("Kode_Barang")
                            newrow("Nama") = .Item("Nama_Barang")
                            newrow("Start_Date") = tglBerlaku.EditValue
                            newrow("Harga_Rupiah") = rupiah.EditValue
                            newrow("Harga_Dollar") = dollar.EditValue
                            newrow("Rec_Stat") = "Y"
                            newrow("kd_merk") = .Item("kd_merk")
                            newrow("kd_tipe") = .Item("kd_tipe")
                            newrow("_jenisbrg") = .Item("kd_jenis")
                            newrow("Last_Create_Date") = getTanggal()
                            newrow("Last_Created_By") = umum.username
                            newrow("Program_Name") = Me.Name
                            dSO.Tables("_SIF_mHarga").Rows.Add(newrow)
                        End If
                    Loop Until Not .Read()
                    Panel4.Visible = False
                Else
                    showMessages("No Data Found's", , "WARNING")
                End If
            End With
        Else
            With New SqlCommand("select * from SIF.dbo.SIF_Barang where Kode_Barang='" & txtBarang.EditValue & "'", sqlconn).ExecuteReader
                .Read()
                If .HasRows Then
                    Do
                        Dim rw() As DataRow = dSO.Tables("_SIF_mHarga").Select("Kode_Barang = '" & .Item("Kode_Barang") & "' and Start_Date = '" & tglBerlaku.EditValue & "'")
                        If rw.Count = 0 Then
                            Dim newrow As DataRow = dSO.Tables("_SIF_mHarga").NewRow
                            newrow("Kd_Cabang") = kdcabang
                            newrow("Kode_Barang") = .Item("Kode_Barang")
                            newrow("Nama") = .Item("Nama_Barang")
                            newrow("Start_Date") = tglBerlaku.EditValue
                            newrow("Harga_Rupiah") = rupiah.EditValue
                            newrow("Harga_Dollar") = dollar.EditValue
                            newrow("Rec_Stat") = "Y"
                            newrow("kd_merk") = .Item("kd_merk")
                            newrow("kd_tipe") = .Item("kd_tipe")
                            newrow("_jenisbrg") = .Item("kd_jenis")
                            newrow("Last_Create_Date") = getTanggal()
                            newrow("Last_Created_By") = umum.username
                            newrow("Program_Name") = Me.Name
                            dSO.Tables("_SIF_mHarga").Rows.Add(newrow)
                        End If
                    Loop Until Not .Read()
                    Panel4.Visible = False
                Else
                    showMessages("No Data Found's", , "WARNING")
                End If
            End With
        End If
    End Sub
    Private Sub btnTambah_Clicks(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtBarang.EditValue Is Nothing Then
            Exit Sub
        ElseIf txtBarang.EditValue.ToString = "" Then
            Exit Sub
        End If
        If rupiah.EditValue = 0 And dollar.EditValue = 0 Then
            Exit Sub
        End If
        If tglBerlaku.EditValue Is Nothing Then
            Exit Sub
        ElseIf tglBerlaku.Text = "" Then
            Exit Sub
        End If
        Dim newrow As DataRow = dSO.Tables("_SIF_mHarga").NewRow
        newrow("Kd_Cabang") = kdcabang
        newrow("Kode_Barang") = txtBarang.EditValue
        newrow("Start_Date") = tglBerlaku.EditValue
        newrow("Harga_Rupiah") = rupiah.EditValue
        newrow("Harga_Dollar") = dollar.EditValue
        newrow("Rec_Stat") = "Y"
        newrow("kd_merk") = txtBarang.GetSelectedDataRow.item("kd_merk") ' txtBarang.Properties.GetDataSourceValue("kd_merk", txtBarang.ItemIndex).ToString()
        newrow("kd_tipe") = txtBarang.GetSelectedDataRow.item("kd_tipe") '  txtBarang.Properties.GetDataSourceValue("kd_tipe", txtBarang.ItemIndex).ToString()
        newrow("Last_Create_Date") = getTanggal()
        newrow("Last_Created_By") = umum.username
        newrow("Program_Name") = Me.Name
        dSO.Tables("_SIF_mHarga").Rows.Add(newrow)
        txtBarang.EditValue = vbNullString
        rupiah.EditValue = 0
        dollar.EditValue = 0
        tglBerlaku.EditValue = vbNullString
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Panel4.Visible = False
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Panel4.Visible = True
        cmdJenis.Focus()
    End Sub

    Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        dSOt.Tables.Clear()
        frmSetHarga.ShowDialog(Me)
        If dSOt.Tables.Count > 0 Then
            Dim newrow As DataRow
            For Each item As DataRow In dSOt.Tables(0).Rows
                newrow = dSO.Tables("_SIF_mHarga").NewRow
                newrow("Kd_Cabang") = kdcabang
                newrow("Kode_Barang") = item("kode_barang")
                If item("end_date").ToString <> "" Then newrow("Start_Date") = item("end_date")
                If item("rp_new").ToString <> "" Then newrow("Harga_Rupiah") = item("rp_new")
                If item("usd_new").ToString <> "" Then newrow("Harga_Dollar") = item("usd_new")
                newrow("Rec_Stat") = "Y"
                newrow("kd_merk") = item("kd_merk")
                newrow("kd_tipe") = item("kd_tipex")
                newrow("_jenisbrg") = item("kd_jenis")
                newrow("Last_Create_Date") = getTanggal()
                newrow("Last_Created_By") = umum.username
                newrow("Program_Name") = Me.Name
                dSO.Tables("_SIF_mHarga").Rows.Add(newrow)
            Next
        End If
    End Sub

    Private Sub cmdMerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMerk.EditValueChanged
        If Not ds_merk.Tables("tipe") Is Nothing Then ds_merk.Tables("tipe").Clear()
        DA_merk = New SqlDataAdapter(New SqlCommand("select kode_tipe, nama_tipe from SIF.dbo.SIF_tipe where Kode_merk='" & cmdMerk.EditValue & "'  union select '', ''", sqlconn))
        DA_merk.Fill(ds_merk, "tipe")
        cmdTipe.Properties.DataSource = ds_merk.Tables("tipe")
        cmdTipe.EditValue = ""

    End Sub

    Private Sub cmdTipe_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTipe.EditValueChanged
        If Not ds_merk.Tables("subtipe") Is Nothing Then ds_merk.Tables("subtipe").Clear()
        DA_merk = New SqlDataAdapter(New SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe from [SIF].[dbo].[SIF_Sub_tipe] where rec_stat='Y' and kd_tipe='" & cmdTipe.EditValue & "' union select '', ''", sqlconn))
        DA_merk.Fill(ds_merk, "subtipe")
        cmdSubTipe.Properties.DataSource = ds_merk.Tables("subtipe")
        cmdSubTipe.EditValue = ""
    End Sub

    Private Sub cmdJenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJenis.EditValueChanged

    End Sub

    Private Sub cmdJenis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdJenis.KeyDown, cmdMerk.KeyDown, cmdSubTipe.KeyDown, cmdTipe.KeyDown, cmdUkuran.KeyDown, rupiah.KeyDown, dollar.KeyDown, tglBerlaku.KeyDown
        If sender Is txtBarang Then
            btnTambah.Focus()
        Else
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtBarang.EditValue = Nothing
    End Sub
    Private Sub GvMstHarga_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvMstHarga.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GvMstHarga_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvMstHarga.ValidateRow
        Dim isvalid As Boolean = True
        Dim rw() As DataRow = dSO.Tables("_SIF_mHarga").Select("Kode_Barang = '" & e.Row.item("Kode_Barang") & "' and Start_Date = '" & e.Row.item("Start_Date") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isvalid = False
                GvMstHarga.SetColumnError(Nama_Barang, "Kode Barang Dan Tanggal Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isvalid
    End Sub
    Private Sub repQty_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles repNum.Spin
        e.Handled = True
    End Sub
End Class