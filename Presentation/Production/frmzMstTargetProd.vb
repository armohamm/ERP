Imports System.Data
Imports System.Data.SqlClient

Public Class frmzMstTargetProd
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
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
    End Sub

    Private Sub frmzMstTargetProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='SPK' order by Desc_Data", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_produksi where 1=0", sqlconn))
        da2.Fill(ds2, "Keg")
        'da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_produksi where 1=0", sqlconn))
        'da2.Fill(ds2, "mstKeg")
        'da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where 1=0", sqlconn))
        'da3.Fill(ds3, "dtlKeg")
        gControl.DataSource = ds2.Tables("Keg")

        dtMulai.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)

        lkKegiatan.DataSource = ds1.Tables("jnsKeg")
    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gView.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    gView.DeleteSelectedRows()
                End If
            End If
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
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Dim tmpNo As String = ""

        If txtNomor.Text = "" Then
            showMessages("Nomor Transaksi harus diisi")
            txtNomor.Focus()
            Exit Sub
        End If
        mb = New SqlClient.SqlCommandBuilder(da2)
        da2.UpdateCommand = mb.GetUpdateCommand()
        da2.InsertCommand = mb.GetInsertCommand()
        da2.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da2.UpdateCommand.Transaction = BTRANS
        da2.InsertCommand.Transaction = BTRANS
        da2.DeleteCommand.Transaction = BTRANS

        Dim tgl As Date = getTanggal(BTRANS)
        If State = "EDIT" Then
            tmpNo = ds2.Tables("Keg").Rows(0).Item("no_trans")
        End If

        For Each rows As DataRow In ds2.Tables("Keg").Rows
            If rows.RowState <> DataRowState.Deleted Then
                rows.Item("kd_cabang") = kdcabang
                rows.Item("kd_departemen") = kddep
                rows.Item("no_trans") = txtNomor.Text
                rows.Item("tgl_mulai") = dtMulai.DateTime
                rows.Item("tgl_akhir") = dtAkhir.DateTime
                rows.Item("keterangan") = txtKeterangan.Text

                rows.Item("rec_stat") = "Y"
                If rows.RowState = DataRowState.Added Then
                    rows.Item("last_create_date") = tgl
                    rows.Item("last_created_by") = username
                End If
                rows.Item("last_update_date") = tgl
                rows.Item("last_updated_by") = username
                rows.Item("program_name") = Me.Name
            End If
        Next

        Try
            da2.Update(ds2.Tables("Keg"))
            ds2.Tables("Keg").AcceptChanges()

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Saved..")
        Catch e As Exception
            BTRANS.Rollback()
            ds2.Tables("Keg").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            If State = "EDIT" Then
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_target_prod_m where no_trans='" & tmpNo & "'", sqlconn))
                If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()
                da2.Fill(ds2, "Keg")
                row = ds2.Tables("Keg").Rows(0)
                txtNomor.Text = row.Item("no_trans")
                txtKeterangan.Text = row.Item("keterangan")
                dtMulai.DateTime = row.Item("tgl_mulai")
                dtAkhir.DateTime = row.Item("tgl_akhir")

                da2.Fill(ds2, "Keg")
                gControl.DataSource = ds2.Tables("Keg")
            ElseIf State = "ADD" Then
                txtNomor.Text = ""
                txtKeterangan.Text = ""
                dtMulai.DateTime = Now
                dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
                If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()
            End If
        End Try

    End Sub

    Public Sub edit_click()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [Nomor], tgl_mulai as [Tanggal Mulai], tgl_akhir as [Tanggal Berakhir], keterangan as [Keterangan] from SIF.dbo.SIF_target_produksi order by no_trans", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_target_produksi where no_trans='" & frmCari.row("Nomor") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()
            da2.Fill(ds2, "Keg")
            row = ds2.Tables("Keg").Rows(0)
            txtNomor.Text = row.Item("no_trans")
            txtKeterangan.Text = row.Item("keterangan")
            dtMulai.DateTime = row.Item("tgl_mulai")
            dtAkhir.DateTime = row.Item("tgl_akhir")

            'da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_produksi where no_trans='" & frmCari.row("Nomor") & "'", sqlconn))
            'If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()
            'da2.Fill(ds2, "Keg")
            gControl.DataSource = ds2.Tables("Keg")

            State = "EDIT"
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            ds2.Tables("Keg").Rows(0).Delete()
            Dim mybuilder As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder.GetUpdateCommand
            da2.Update(ds2.Tables("Keg"))
            ds2.Tables("Keg").AcceptChanges()
            If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()

            showMessages("Deleted..")
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        txtNomor.Text = ""
        txtKeterangan.Text = ""
        dtMulai.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
        If Not ds2.Tables("Keg") Is Nothing Then ds2.Tables("Keg").Clear()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isValid As Boolean = True
        If gView.GetRowCellValue(e.RowHandle, "kd_kegiatan") = "" Then 'e.Row.item("kd_kegiatan").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmKegiatan, "Kolom 'Kegiatan' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If IsNumeric(gView.GetRowCellValue(e.RowHandle, "jml_target")) = False Then 'e.Row.item("jml_target").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmJumlah, "Kolom 'Target (Indeks)' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If IsNumeric(gView.GetRowCellValue(e.RowHandle, "jml_target_kubik")) = False Then 'e.Row.item("jml_target_kubik").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmJumlah, "Kolom 'Target (Kubik)' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        save_click()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        add_click()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        edit_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        delete_click()
    End Sub

End Class