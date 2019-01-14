Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmSettingInsentifSalesBali
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA, DA2 As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Private Sub frmSettingInsentifSalesBali_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlDataAdapter("select Kode_Merk, Nama_Merk from sif.dbo.sif_Merk where rec_stat='Y'", sqlconn)
        dadbe.Fill(dsete, "Merk")
        reloadTable("xxx")
        GC.DataSource = dsete.Tables("RUMUS2")
        txtMerk1.Properties.DataSource = dsete.Tables("Merk")
        txtMerk2.Properties.DataSource = dsete.Tables("Merk")
        'add_click()
        State = "ADD"
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim valid As Boolean = True
        If State = "ADD" Then
            If txtisSpon.EditValue.ToString = "" Then
                DXEP.SetError(txtisSpon, "Harap Pilih Jenis Produk")
                txtisSpon.Focus()
                valid = False
            End If
        Else
            If txtMerk1.Text = "" Then
                DXEP.SetError(txtMerk1, "Merk Masih Kosong")
                txtMerk1.Focus()
                valid = False
            End If
            If txtMerk1.Text = txtMerk2.Text Then
                DXEP.SetError(txtMerk1, "Merk1 dan Merk2 Tidak Boleh Sama")
                txtMerk1.Focus()
                valid = False
            End If
        End If
        If Not valid Then Exit Sub

        If State = "ADD" Then
            row = dsete.Tables("RUMUS").NewRow
            row("Kd_Cabang") = kdcabang
            row("Last_Create_Date") = getTanggal()
            row("Last_Created_By") = username
            row("Departement") = username
            row("Status") = "Y"
            row("Program_Name") = username
            row("Tgl") = getTanggal()
            txtTgl.EditValue = row("Tgl")
            row("Nomor") = txtNomor.Text
        Else
            row = dsete.Tables("RUMUS")(0)
            row("Last_Update_Date") = getTanggal()
            row("Last_Updated_By") = username
        End If

        row("Kd_Merk") = txtMerk1.EditValue
        If txtMerk2.Text <> "" Then row("Kd_Merk") = txtMerk2.EditValue
        row("Status") = txtStatus.Text
        dsete.Tables("RUMUS").Rows.Add(row)
        For Each item As DataRow In dsete.Tables("RUMUS2").Rows
            If item.RowState = DataRowState.Added Then
                item("Kd_Cabang") = kdcabang
                item("Last_Create_Date") = getTanggal()
                item("Last_Created_By") = username
                item("Departement") = username
                item("Status") = "Y"
                item("Program_Name") = username
                item("Nomor_D") = txtNomor.Text
            ElseIf item.RowState = DataRowState.Modified Then
                item("Last_Update_Date") = getTanggal()
                item("Last_Updated_By") = username

            End If
        Next
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DA2)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA2.UpdateCommand = myBuilder.GetUpdateCommand()
            DA2.InsertCommand = myBuilder.GetInsertCommand()
            DA2.DeleteCommand = myBuilder.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("RUMUS"))
            DA2.Update(dsete.Tables("RUMUS2"))

            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch e As Exception

            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("RUMUS").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.Sales_Rumus_Insentif where Status='Y'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnSave = True

            reloadTable(frmCari.row("Nomor"))
            State = "EDIT"
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub cancel_click()

    End Sub
    Private Sub reloadTable(ByVal kode As String)
        If Not dsete.Tables("RUMUS") Is Nothing Then dsete.Tables("RUMUS").Clear()
        If Not dsete.Tables("RUMUS2") Is Nothing Then dsete.Tables("RUMUS2").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.sales_rumus_insentif  where nomor='" & kode & "'", sqlconn))
        DA.Fill(dsete, "RUMUS")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as NO from Sales.dbo.sales_rumus_insentif_d where nomor_d='" & kode & "'", sqlconn))
        DA2.Fill(dsete, "RUMUS2")

        If dsete.Tables("RUMUS").Rows.Count > 0 Then
            Dim row As DataRow
            row = dsete.Tables("RUMUS").Rows(0)
            txtNomor.Text = row.Item("Nomor").ToString
            txtTgl.EditValue = row.Item("Tgl").ToString
            txtMerk1.EditValue = row.Item("Kd_Merk").ToString
            txtMerk2.EditValue = row.Item("Kd_Merk2").ToString
            txtStatus.Text = row.Item("Status")
        Else
            txtNomor.Text = vbNullString
            txtTgl.EditValue = vbNullString
            txtMerk1.EditValue = vbNullString
            txtMerk2.EditValue = vbNullString
            txtStatus.Text = "Y"
        End If
    End Sub

    Private Sub txtisSpon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtisSpon.SelectedIndexChanged
        DXEP.SetError(txtMerk1, "")
    End Sub

    Private Sub txtMerk1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMerk1.EditValueChanged
        DXEP.SetError(txtMerk1, "")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub
End Class