
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPengbytklsng
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, ds3, ds4, dsku, dsku1, dsku2, dsedit As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, da4, sqlda, daedit, sqlda1, sqlda2 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Sub bersih()
        txtNomor.EditValue = vbNullString
        txtnama.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtnama.EditValue = vbNullString
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("BY") Is Nothing Then ds3.Tables("BY").Clear()
        If Not ds4.Tables("BYD") Is Nothing Then ds4.Tables("BYD").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BIAYA where nomor='" & kode & "'", sqlconn))
        da3.Fill(ds3, "BY")                                               ','' as nm_buku_besar,'' as nm_pusat_biaya

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BIAYA_D where nomor='" & kode & "' order by No_Seq asc", sqlconn))
        da4.Fill(ds4, "BYD")
        GC.DataSource = ds4.Tables("BYD")
        AddHandler ds4.Tables("BYD").RowDeleted, AddressOf refreshNomer
        If ds3.Tables("BY").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("BY").Rows(0)
            txtNomor.Text = row.Item("nomor").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            dtTanggal.Text = row.Item("tgl_trans")
            txtnama.EditValue = row.Item("nama_pemohon")
            txtJmlTotal.EditValue = row.Item("jml_trans")

        End If

    End Sub
    Public Sub edit_click()                                                                                                                             'where tipe_trans='MATERIAL' and rec_stat='ENTRY' or rec_stat='REJECT'
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor as [Nomor], tgl_trans as [Tanggal] from FIN.dbo.FIN_BIAYA ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup") Is Nothing Then dsedit.Tables("lookup").Clear()
        daedit.Fill(dsedit, "lookup")
        frmCari.set_dso(dsedit.Tables("lookup")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnCancel = True
            btnDelete = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        'callReport(App_Path() & "\report\rptDPM_J.rpt", "", "Nomor=" & Trim(txtNoDPM.Text))
    End Sub
    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

    End Sub
    Sub View_Rekening()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar,nm_buku_besar from sif.dbo.SIF_buku_besar", sqlconn))
        da2.Fill(ds2, "View_Rek")
        repbkbsr.DataSource = ds2.Tables("View_Rek")

    End Sub
    Sub View_PusatBiaya()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_pusat,nm_buku_pusat from sif.dbo.SIF_buku_pusat", sqlconn))
        DA.Fill(ds1, "View_PST")
        repbkpusat.DataSource = ds1.Tables("View_PST")
    End Sub
    Private Sub No_Seq(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next

    End Sub

    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If STATE = "ADD" Then

                row = ds3.Tables("BY").NewRow

                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("nama_pemohon") = txtnama.Text
                row.Item("Keterangan") = txtKeterangan.Text
                row.Item("jml_trans") = txtJmlTotal.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("BY").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If


            If STATE = "ADD" Then
                ds3.Tables("BY").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("BYD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("nomor") = row.Item("nomor")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("Program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If


            Next
        End If



        Try
            Buildernya = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = Buildernya.GetUpdateCommand()
            da3.InsertCommand = Buildernya.GetInsertCommand()
            da3.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = Buildernya.GetUpdateCommand()
            da4.InsertCommand = Buildernya.GetInsertCommand()
            da4.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS
            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS
            If STATE = "ADD" Then
                row.Item("nomor") = getNoTrans("B-TLSG", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("nomor")
                For Each rows As DataRow In ds4.Tables("BYD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("nomor") = row.Item("nomor")
                    End If
                Next
            End If



            da3.Update(ds3.Tables("BY"))
            da4.Update(ds4.Tables("BYD"))

            ds3.Tables("BY").AcceptChanges()
            ds4.Tables("BYD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("BY").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is jumlah Then
            txtJmlTotal.EditValue = getTotal()
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub GC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("BYD").Select("no_seq=" & rw.Item("no_seq"))

                    rwd("no_seq") = i
                    j = 1
                    rw("no_seq") = i
                    '  i += 1
                Next
                j = 1
                rw("no_seq") = i
                i += 1
            End If
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Data ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("BY") Is Nothing Then delete(ds3.Tables("BY").Rows)
            If Not ds4.Tables("BYD") Is Nothing Then delete(ds4.Tables("BYD").Rows)

            save_click(True)
            cancel_click()
            getTotal()
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("BYD").Rows
            If TypeOf rw.Item("jml_trans") Is DBNull Or rw.Item("jml_trans") = 0 Then
                MsgBox("Jumlah Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("jml_trans") = 0
                Exit Function
            Else
                ttl += rw("jml_trans")
            End If
        Next
        Return ttl
    End Function

    Private Sub frmPengbytklsng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        dtTanggal.Text = Date.Today

        View_Rekening()
        View_PusatBiaya()
        prn = getParent(Me)
        If txtNomor.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds4.Tables("BYD")
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        txtJmlTotal.EditValue = getTotal()
    End Sub
End Class