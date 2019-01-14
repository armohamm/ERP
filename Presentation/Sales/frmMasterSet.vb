Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMasterSet
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DAL As SqlDataAdapter
    Dim DAM As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public NOSO As String
    Dim myBuilder As New SqlCommandBuilder
    Dim addnew As Boolean = False
    Dim clone As DataView
    Dim kriteria As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnCetak.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not dsete.Tables("SETM") Is Nothing Then dsete.Tables("SETM").Clear()
        If Not dsete.Tables("SETD") Is Nothing Then dsete.Tables("SETD").Clear()
        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()

        DAM = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_SET_PRODUCT where KD_SET='" & kode & "'", sqlconn))
        DAM.Fill(dsete, "SETM")
        DAD = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_SET_PRODUCT_D where KD_SET='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SETD")
        GC.DataSource = dsete.Tables("SETD")
        If dsete.Tables("SETM").Rows.Count > 0 Then
            With New SqlCommand("select * from sif.dbo.sif_barang where kode_barang = '" & dsete.Tables("SETM")(0)("KD_SET") & "'", sqlconn).ExecuteReader
                .Read()
                If .HasRows Then
                    If Not dsete.Tables("TIPE") Is Nothing Then dsete.Tables("TIPE").Clear()
                    If Not dsete.Tables("SUBTIPE") Is Nothing Then dsete.Tables("SUBTIPE").Clear()
                    dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select Kode_Tipe, Nama_Tipe from sif.dbo.SIF_Tipe where kode_merk='" & .Item("kd_merk") & "' ", sqlconn))
                    dadbe.Fill(dsete, "TIPE")
                    dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_sub_tipe where kd_tipe='" & .Item("kd_tipe") & "' ", sqlconn))
                    dadbe.Fill(dsete, "SUBTIPE")

                    dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang,  b.Kode_Barang, kd_sub_tipe from SIF.dbo.SIF_Barang as b where  b.kd_jns_persd=1 and kd_jenis not in ('038','039') and kd_merk = '" & .Item("kd_merk") & "' and kd_tipe = '" & .Item("kd_tipe") & "'", sqlconn))
                    dadbe.Fill(dsete, "VBARANG")
                    subTipe.EditValue = .Item("kd_sub_tipe")

                    repStok.DataSource = dsete.Tables("VBARANG")
                End If
                .Close()
            End With
            txtKdSet.Text = dsete.Tables("SETM")(0)("KD_SET").ToString
            txtNamaSet.Text = dsete.Tables("SETM")(0)("NAMA").ToString
            txtSatuan.EditValue = dsete.Tables("SETM")(0)("Unit").ToString
            txtStatus.EditValue = dsete.Tables("SETM")(0)("STATUS")

            
            cmdTipe.EditValue = dsete.Tables("SETM")(0)("Tipe")
            cmdMerk.EditValue = dsete.Tables("SETM")(0)("Merk")
            cmdUkuran.EditValue = dsete.Tables("SETM")(0)("Ukuran")

        Else
            txtKdSet.Text = ""
            txtNamaSet.Text = ""
            txtSatuan.EditValue = vbNullString
            cmdTipe.EditValue = vbNullString
            cmdMerk.EditValue = vbNullString
            cmdUkuran.EditValue = vbNullString
            txtStatus.EditValue = "Y"
            repStok.DataSource = Nothing

        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select KD_SET as [Kode], NAMA as [Deskripsi] from sif.dbo.SIF_SET_PRODUCT", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then
            dsete.Tables.Remove("lookup_so")
        End If

        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            State = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub add_click()
        If Not dsete.Tables("lookup_so") Is Nothing Then
            dsete.Tables.Remove("lookup_so")
        End If

        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Columns.Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang, kd_satuan  from sif.dbo.sif_barang where " & _
    "  not exists (select 1 from sif.dbo.sif_set_product where kd_set=kode_barang ) and kd_jenis in ('038', '039') and kd_depart='" & kddep & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            With New SqlCommand("select * from sif.dbo.sif_barang where kode_barang = '" & frmCari.row("Kode_Barang") & "'", sqlconn).ExecuteReader
                .Read()
                txtKdSet.Text = .Item("Kode_Barang")
                txtNamaSet.Text = .Item("Nama_Barang")
                txtSatuan.EditValue = .Item("Kd_Satuan")
                If Not dsete.Tables("TIPE") Is Nothing Then dsete.Tables("TIPE").Clear()
                If Not dsete.Tables("SUBTIPE") Is Nothing Then dsete.Tables("SUBTIPE").Clear()
                dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select Kode_Tipe, Nama_Tipe from sif.dbo.SIF_Tipe where kode_merk='" & .Item("kd_merk") & "' ", sqlconn))
                dadbe.Fill(dsete, "TIPE")
                dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_sub_tipe where kd_tipe='" & .Item("kd_tipe") & "' ", sqlconn))
                dadbe.Fill(dsete, "SUBTIPE")

                cmdMerk.EditValue = .Item("kd_merk")
                cmdTipe.EditValue = .Item("kd_tipe")
                cmdUkuran.EditValue = .Item("kd_ukuran")
                subTipe.EditValue = .Item("kd_sub_tipe")
                txtStatus.EditValue = .Item("Rec_Stat")

                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang,  b.Kode_Barang from SIF.dbo.SIF_Barang as b where  b.kd_jns_persd=1 and kd_jenis not in ('038','039') and kd_merk = '" & .Item("kd_merk") & "' and kd_tipe = '" & .Item("kd_tipe") & "'", sqlconn))
                dadbe.Fill(dsete, "VBARANG")
                repStok.DataSource = dsete.Tables("VBARANG")
                .Close()
            End With

            State = "ADD"
            btnSave = True
            btnCancel = True
            btnDelete = False
            btnEdit = False
            btnadd = False
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub cancel_click()
        reload_table("----")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then

            Dim dr As SqlDataReader = New SqlCommand("select count(1) from sif.dbo.sif_so_d where Kd_Stok='" & txtKdSet.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Data sudah dipakai untuk transaksi", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                Exit Sub
            End If
            State = "DELETE"
            dr.Close()
            If Not dsete.Tables("SETM") Is Nothing Then delete(dsete.Tables("SETM").Rows)
            If Not dsete.Tables("SETD") Is Nothing Then delete(dsete.Tables("SETD").Rows)
            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim rw As DataRow
        If Not isDelete Then
            If txtNamaSet.Text = "" Then
                showMessages("Nama Set Belum Diisi", "WARNING")
                Exit Sub
            End If
            If GV.RowCount = 0 Then
                showMessages("Daftar Barang Masih Kosong", "WARNING")
                Exit Sub
            End If
            If State = "ADD" Then
                rw = dsete.Tables("SETM").NewRow
                rw("KD_SET") = txtKdSet.Text
                rw("Last_Create_Date") = getTanggal()
                rw("Last_Created_By") = kdpeg

            Else
                rw = dsete.Tables("SETM")(0)
                rw("Last_Update_Date") = getTanggal()
                rw("Last_Updated_By") = kdpeg
            End If
            rw("NAMA") = txtNamaSet.Text
            rw("STATUS") = txtStatus.Text
            rw("Unit") = txtSatuan.EditValue
            rw("Kd_Cabang") = kdcabang
            rw("Kd_Departemen") = kddep
            rw("Program_Name") = Me.Name
            rw("Tipe") = cmdTipe.EditValue
            rw("Merk") = cmdMerk.EditValue
            rw("Ukuran") = cmdUkuran.EditValue
            If State = "ADD" Then
                dsete.Tables("SETM").Rows.Add(rw)
            End If
            For Each row As DataRow In dsete.Tables("SETD").Rows
                If row.RowState = DataRowState.Added Then
                    row("Kd_Cabang") = kdcabang
                    row("Last_Create_Date") = getTanggal()
                    row("Last_Created_By") = umum.kdpeg
                    row("Program_Name") = Me.Name
                    row("KD_SET") = txtKdSet.Text
                ElseIf row.RowState <> DataRowState.Deleted Then
                    row.Item("Last_Update_Date") = getTanggal()
                    row.Item("Last_Updated_By") = kdpeg
                End If
            Next
        End If
        myBuilder = New SqlClient.SqlCommandBuilder(DAM)
        DAM.UpdateCommand = myBuilder.GetUpdateCommand()
        DAM.InsertCommand = myBuilder.GetInsertCommand()
        DAM.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DAD)
        DAD.UpdateCommand = myBuilder.GetUpdateCommand()
        DAD.InsertCommand = myBuilder.GetInsertCommand()
        DAD.DeleteCommand = myBuilder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DAM.UpdateCommand.Transaction = BTRANS
        DAM.InsertCommand.Transaction = BTRANS
        DAM.DeleteCommand.Transaction = BTRANS

        DAD.UpdateCommand.Transaction = BTRANS
        DAD.InsertCommand.Transaction = BTRANS
        DAD.DeleteCommand.Transaction = BTRANS

        Try
            DAM.Update(dsete.Tables("SETM"))
            DAD.Update(dsete.Tables("SETD"))
            BTRANS.Commit()
            State = "EDIT"
            showMessages("Transaksi Telah Disimpan")

        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("SETM").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsete.Tables("SETD").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        addnew = True
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub frmMasterSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.sif_satuan where Gol_Satuan='UMUM'", sqlconn))
        dadbe.Fill(dsete, "UNIT")
        dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select Kode_Merk, Nama_Merk from sif.dbo.SIF_Merk ", sqlconn))
        dadbe.Fill(dsete, "MERK")
       
        dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select Kode_Ukuran, Nama_Ukuran from sif.dbo.SIF_Ukuran ", sqlconn))
        dadbe.Fill(dsete, "UKURAN")
        dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select Kode_Tipe, Nama_Tipe from sif.dbo.SIF_Tipe where kode_merk='xx'", sqlconn))
        dadbe.Fill(dsete, "TIPE")
        dadbe = New SqlClient.SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_sub_tipe where kd_tipe='xx' ", sqlconn))
        dadbe.Fill(dsete, "SUBTIPE")

        txtSatuan.Properties.DataSource = dsete.Tables("UNIT")
        cmdMerk.Properties.DataSource = dsete.Tables("MERK")
        cmdTipe.Properties.DataSource = dsete.Tables("TIPE")
        cmdUkuran.Properties.DataSource = dsete.Tables("UKURAN")
        subTipe.Properties.DataSource = dsete.Tables("SUBTIPE")
        reload_table("XXX")
        prn = getParent(Me)
        pnl.Top = 5
        pnl.Height = prn.pnlDisplay2.Height - 20
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus List") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        addnew = False
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isvalid As Boolean = True
        Dim rw() As DataRow = dsete.Tables("SETD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "'")
        If dsete.Tables("SETD").Rows.Count = 0 Then Exit Sub

        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isvalid = False
                GV.SetColumnError(barang, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If e.Row("QTY").ToString = "" Then
            isvalid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Qty", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row("QTY") <= 0 Then
            isvalid = False
            GV.SetColumnError(Qty, "Inputan Jumlah Barang Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row("KD_STOK").ToString = "" Then
            isvalid = False
            GV.SetColumnError(barang, "Barang Masih Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isvalid
    End Sub

End Class