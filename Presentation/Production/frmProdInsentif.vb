Imports System.Data
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Public Class frmProdInsentif
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da7 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim subReport As String
    Dim r, y As Integer
    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPrintPreview()
    End Sub
    Public Sub cetak_click()
        If Not gView.RowCount <= 0 Then
            'ShowGridPreview(gControl)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "INSENTIF PRODUKSI"
        If dtAkhir.EditValue = dtMulai.EditValue Then
            subReport = "Per tanggal " & Format(dtAkhir.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = Format(dtAkhir.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(dtMulai.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)

    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub



    Private Sub frmProdInsentif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)
        r = 1
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_insentif_prod_m where 1=0", sqlconn))
        da2.Fill(ds2, "mstKeg")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='SPK' order by Desc_Data", sqlconn))
        da1.Fill(ds1, "jnsKeg")

        dtMulai.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
        lkkegtn.Properties.DataSource = ds1.Tables("jnsKeg")
        lkkegtn.Properties.ValueMember = "Id_Data"
        lkkegtn.Properties.DisplayMember = "Desc_Data"
        gControl.Visible = False
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
            row.Item("tgl_mulai") = dtAkhir.DateTime
            row.Item("tgl_akhir") = dtAkhir.DateTime
            row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
            row.Item("jenis_insentif") = jnsins.Text
            row.Item("last_create_date") = tgl
            row.Item("last_created_by") = username
            row.Item("program_name") = Me.Name
            row.Item("kd_cabang") = kdcabang
            row.Item("kd_departemen") = kddep
            ds2.Tables("mstKeg").Rows.Add(row)

        ElseIf State = "EDIT" Then
            tmpNo = ds2.Tables("mstKeg").Rows(0).Item("no_trans")
            row = ds2.Tables("mstKeg").Rows(0)
            row.Item("no_trans") = txtNomor.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("tgl_mulai") = dtAkhir.DateTime
            row.Item("tgl_akhir") = dtAkhir.DateTime
            row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
            row.Item("jenis_insentif") = jnsins.Text
            row.Item("last_update_date") = tgl
            row.Item("last_updated_by") = username
            row.Item("program_name") = Me.Name
            row.Item("kd_cabang") = kdcabang
            row.Item("kd_departemen") = kddep
        End If

        For Each rows As DataRow In ds3.Tables("dtlKeg").Rows
            If rows.RowState <> DataRowState.Deleted Then
                rows.Item("no_trans") = txtNomor.Text
                If rows.RowState = DataRowState.Added Then
                    rows.Item("last_create_date") = tgl
                    rows.Item("last_created_by") = username
                    rows.Item("kd_kegiatan_spk") = lkkegtn.EditValue

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
                dtAkhir.DateTime = row.Item("tgl_mulai")
                dtAkhir.DateTime = row.Item("tgl_akhir")
                lkkegtn.EditValue = row.Item("kd_kegiatan_spk")
                jnsins.Text = row.Item("jenis_insentif")

                da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where no_trans='" & tmpNo & "'", sqlconn))
                If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
                da3.Fill(ds3, "dtlKeg")
                gControl.DataSource = ds3.Tables("dtlKeg")
            ElseIf State = "ADD" Then
                txtNomor.Text = ""
                txtKeterangan.Text = ""
                dtAkhir.DateTime = Now
                dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
                If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
                If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
            End If
        End Try

    End Sub
    Private Sub refreshNomer() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To gControl.FocusedView.RowCount - 1
            gControl.FocusedView.GetRow(i).Item("no_urut") = i + 1
        Next
    End Sub
    Public Sub delete_click1()
        Dim x As Object
        x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            If gControl.FocusedView.Name = "gView" Then
                refreshNomer()
            End If
        End If

    End Sub
    Public Sub cancel_click()
        txtNomor.Text = ""
        txtKeterangan.Text = ""
        lkkegtn.EditValue = Nothing
        dtMulai.DateTime = Now
        dtAkhir.DateTime = Now
        dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
        jnsins.SelectedItem = Nothing
        If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
        If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
        If Not ds3.Tables("baru") Is Nothing Then ds3.Tables("baru").Clear()
        r = 1
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub


    Public Sub edit_click()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_trans as [Nomor], a.tgl_mulai as [Tanggal Mulai], a.tgl_akhir as [Tanggal Berakhir], a.keterangan as [Keterangan], b.desc_data as [Kegiatan] " & _
                                                                    "from SIF.dbo.SIF_insentif_prod_m a inner join SIF.dbo.SIF_Gen_Reff_D b on a.kd_kegiatan_spk = b.id_data and b.Id_Ref_Data='SPK' order by a.no_trans", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_insentif_prod_m where no_trans='" & frmCari.row("Nomor") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
            da2.Fill(ds2, "mstKeg")
            row = ds2.Tables("mstKeg").Rows(0)
            txtNomor.Text = row.Item("no_trans")
            txtKeterangan.Text = row.Item("keterangan")
            dtMulai.DateTime = row.Item("tgl_mulai")
            dtAkhir.DateTime = row.Item("tgl_akhir")
            lkkegtn.EditValue = row.Item("kd_kegiatan_spk")
            jnsins.Text = row.Item("jenis_insentif")

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_insentif_prod_d where no_trans='" & frmCari.row("Nomor") & "'", sqlconn))
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


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
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

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    
    Private Sub jnsins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jnsins.SelectedIndexChanged
        gControl.Visible = True
        If jnsins.Text = "SATUAN" Then
            gView.Columns.Item("jumlah").Visible = True
            gView.Columns.Item("jumlah1").Visible = False
            gView.Columns.Item("jumlah2").Visible = False
            gView.Columns.Item("jumlah").VisibleIndex = 0
        Else
            'gView.Columns.Item("jumlah").Visible = False
            'gView.Columns.Item("jumlah1").Visible = True
            'gView.Columns.Item("jumlah2").Visible = True
            'gView.Columns.Item("jumlah1").VisibleIndex = 0
            'gView.Columns.Item("jumlah2").VisibleIndex = 1
            gView.Columns.Item("jumlah").Visible = True
            gView.Columns.Item("jumlah1").Visible = False
            gView.Columns.Item("jumlah2").Visible = False
            gView.Columns.Item("jumlah").VisibleIndex = 0

        End If
        If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
        If Not ds3.Tables("baru") Is Nothing Then ds3.Tables("baru").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_insentif_prod_d where 1=0", sqlconn))
        da3.Fill(ds3, "dtlKeg")

        da7 = New SqlDataAdapter(New SqlCommand("select *, isnull(max(no_urut),0) no_urut from SIF.dbo.SIF_insentif_prod_d where kd_kegiatan_spk='" & lkkegtn.EditValue & "' group by [kd_cabang] " & _
      ",[kd_departemen],[no_trans],[kd_kegiatan_spk],[no_urut],[jumlah],[jumlah1],[jumlah2],[nilai_insentif],[total_insentif],[keterangan],[rec_stat],[last_create_date],[last_created_by],[last_update_date] " & _
      ",[last_updated_by],[program_name]", sqlconn))
        da7.Fill(ds3, "baru")

        gControl.DataSource = ds3.Tables("dtlKeg")

    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        'If ds3.Tables("dtlKeg").Rows.Count > 0 Then
        '    y = ds3.Tables("dtlKeg").Rows(0).Item("no_urut") + r
        'Else
        '    y = 1

        'End If
        'y = IIf(ds3.Tables("baru").Rows(0).Item("no_urut") = Nothing, 0, ds3.Tables("baru").Rows(0).Item("no_urut")) + r
        'y = ds3.Tables("dtlKeg").Rows(0).Item("no_urut") + r

        gControl.FocusedView.GetRow(e.RowHandle).Item("no_urut") = gControl.FocusedView.RowCount + 1

        'gControl.FocusedView.GetRow(e.RowHandle).Item("no_urut") = y
        'r += 1
    End Sub

    Private Sub gView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click1()
        End If
    End Sub
End Class