Imports System.Data
Imports System.Data.SqlClient

Public Class frmMstTargetJadi
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

    Private Sub frmMstTargetJadi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='SPK' order by Desc_Data", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JAMPROD' order by Desc_Data", sqlconn))
        da1.Fill(ds1, "jamKerja")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='GRPKERJA' order by Id_Data", sqlconn))
        da1.Fill(ds1, "group")
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_m where 1=0", sqlconn))
        da2.Fill(ds2, "mstKeg")
        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where 1=0", sqlconn))
        da3.Fill(ds3, "dtlKeg")
        gControl.DataSource = ds3.Tables("dtlKeg")

        dtMulai.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)

        lkKegiatan.DataSource = ds1.Tables("jnsKeg")
        lkJam.DataSource = ds1.Tables("jamKerja")
        lkGroup.DataSource = ds1.Tables("group")
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
        Dim tmpNo As String

        If txtNomor.Text = "" Then
            showMessages("Nomor Transaksi harus diisi")
            txtNomor.Focus()
            Exit Sub
        End If
        mb = New SqlClient.SqlCommandBuilder(da2)
        da2.UpdateCommand = mb.GetUpdateCommand()
        da2.InsertCommand = mb.GetInsertCommand()
        da2.DeleteCommand = mb.GetDeleteCommand()

        mb = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = mb.GetUpdateCommand()
        da3.InsertCommand = mb.GetInsertCommand()
        da3.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da2.UpdateCommand.Transaction = BTRANS
        da2.InsertCommand.Transaction = BTRANS
        da2.DeleteCommand.Transaction = BTRANS

        da3.UpdateCommand.Transaction = BTRANS
        da3.InsertCommand.Transaction = BTRANS
        da3.DeleteCommand.Transaction = BTRANS
        Dim tgl As Date = getTanggal(BTRANS)
        If State = "ADD" Then
            If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
            row = ds2.Tables("mstKeg").NewRow
            row.Item("no_trans") = txtNomor.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("rec_stat") = "Y"
            row.Item("tgl_mulai") = dtMulai.DateTime
            row.Item("tgl_akhir") = dtAkhir.DateTime
            row.Item("last_create_date") = tgl
            row.Item("last_created_by") = username
            ds2.Tables("mstKeg").Rows.Add(row)
            row.Item("program_name") = Me.Name
            row.Item("kd_cabang") = kdcabang
            row.Item("kd_departemen") = kddep
        ElseIf State = "EDIT" Then
            tmpNo = ds2.Tables("mstKeg").Rows(0).Item("no_trans")
            row = ds2.Tables("mstKeg").Rows(0)
            row.Item("no_trans") = txtNomor.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("tgl_mulai") = dtMulai.DateTime
            row.Item("tgl_akhir") = dtAkhir.DateTime
            row.Item("last_update_date") = tgl
            row.Item("last_updated_by") = username
        End If

        For Each rows As DataRow In ds3.Tables("dtlKeg").Rows
            If rows.RowState <> DataRowState.Deleted Then
                rows.Item("no_trans") = txtNomor.Text
                If rows.RowState = DataRowState.Added Then
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

        Try

            da2.Update(ds2.Tables("mstKeg"))
            da3.Update(ds3.Tables("dtlKeg"))
            ds2.Tables("mstKeg").AcceptChanges()
            ds3.Tables("dtlKeg").AcceptChanges()

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Saved..")
        Catch e As Exception
            BTRANS.Rollback()
            ds2.Tables("mstKeg").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            ds3.Tables("dtlKeg").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            If State = "EDIT" Then
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_target_prod_m where no_trans='" & tmpNo & "'", sqlconn))
                If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
                da2.Fill(ds2, "mstKeg")
                row = ds2.Tables("mstKeg").Rows(0)
                txtNomor.Text = row.Item("no_trans")
                txtKeterangan.Text = row.Item("keterangan")
                dtMulai.DateTime = row.Item("tgl_mulai")
                dtAkhir.DateTime = row.Item("tgl_akhir")

                da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where no_trans='" & tmpNo & "'", sqlconn))
                If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
                da3.Fill(ds3, "dtlKeg")
                gControl.DataSource = ds3.Tables("dtlKeg")
            ElseIf State = "ADD" Then
                txtNomor.Text = ""
                txtKeterangan.Text = ""
                dtMulai.DateTime = Now
                dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
                If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
                If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
            End If
        End Try

    End Sub

    Public Sub edit_click()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [Nomor], tgl_mulai as [Tanggal Mulai], tgl_akhir as [Tanggal Berakhir], keterangan as [Keterangan] from SIF.dbo.SIF_target_prod_m order by no_trans", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_target_prod_m where no_trans='" & frmCari.row("Nomor") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
            da2.Fill(ds2, "mstKeg")
            row = ds2.Tables("mstKeg").Rows(0)
            txtNomor.Text = row.Item("no_trans")
            txtKeterangan.Text = row.Item("keterangan")
            dtMulai.DateTime = row.Item("tgl_mulai")
            dtAkhir.DateTime = row.Item("tgl_akhir")

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where no_trans='" & frmCari.row("Nomor") & "'", sqlconn))
            If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
            da3.Fill(ds3, "dtlKeg")
            gControl.DataSource = ds3.Tables("dtlKeg")

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
            ds2.Tables("mstKeg").Rows(0).Delete()
            Dim mybuilder As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder.GetUpdateCommand
            da2.Update(ds2.Tables("mstKeg"))
            ds2.Tables("mstKeg").AcceptChanges()
            If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()

            For Each dr As DataRow In ds3.Tables("dtlKeg").Rows
                dr.Delete()
            Next
            Dim mybuilder2 As New SqlCommandBuilder(da3)
            da3.UpdateCommand = mybuilder2.GetUpdateCommand
            da3.Update(ds3.Tables("dtlKeg"))
            ds3.Tables("dtlKeg").AcceptChanges()

            showMessages("Deleted..")
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        txtNomor.Text = ""
        txtKeterangan.Text = ""
        dtMulai.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
        If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
        If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
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
        If e.Row.item("kd_kegiatan_spk").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmKegiatan, "Kolom 'Kegiatan' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("kd_jam").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmJam, "Kolom 'Jam' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("kd_group_kerja").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmGroup, "Kolom 'Group' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("jumlah_target").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmJumlah, "Kolom 'Jumlah' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

End Class