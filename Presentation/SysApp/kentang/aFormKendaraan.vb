Imports System.Data.SqlClient

Public Class aFormKendaraan
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsKendaraan As New DataSet
    Dim daKendaraan, daListKendaraan, daLookUp As SqlDataAdapter
    Dim drKendaraan As SqlDataReader
    Dim bldKendaraan As New SqlCommandBuilder
    Dim state, err, kodeKendaraan As String
    Dim isValid As Boolean
    Dim row As DataRow
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cancel_click()
        loadDataset("XXX")
        txtKode.EditValue = vbNullString
        txtNama.EditValue = vbNullString
        txtNoPol.EditValue = vbNullString
        txtKapasitasIndex.EditValue = 0
        txtKapasitasM3.EditValue = 0
        lckJenis.EditValue = vbNullString
        txtKet.EditValue = vbNullString
        cmbStatus.EditValue = "Y"
        state = "ADD"
    End Sub

    Private Sub loadLookup()
        If Not dsKendaraan.Tables("Jenis") Is Nothing Then dsKendaraan.Tables("Jenis").Clear()
        If Not dsKendaraan.Tables("Status") Is Nothing Then dsKendaraan.Tables("Status").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Id_Data, Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Ref_Role LIKE 'PROD%' AND Id_Ref_File LIKE 'JNSKDRN%'", sqlconn))
        daLookUp.Fill(dsKendaraan, "Jenis")
        lckJenis.Properties.DataSource = dsKendaraan.Tables("Jenis")
        lckJenis.Properties.DisplayMember = "Desc_Data"
        lckJenis.Properties.ValueMember = "Id_Data"
        lookUpJenis.DataSource = dsKendaraan.Tables("Jenis")
        lookUpJenis.DisplayMember = "Desc_Data"
        lookUpJenis.ValueMember = "Id_Data"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 'Y' as kode, 'AKTIF' as stat UNION SELECT 'T', 'TIDAK AKTIF'", sqlconn))
        daLookUp.Fill(dsKendaraan, "Status")
        lookUpStat.DataSource = dsKendaraan.Tables("Status")
        lookUpStat.ValueMember = "kode"
        lookUpStat.DisplayMember = "stat"
    End Sub

    Private Sub loadGrid()
        If Not dsKendaraan.Tables("ListKendaraan") Is Nothing Then dsKendaraan.Tables("ListKendaraan").Clear()
        daListKendaraan = New SqlDataAdapter(New SqlCommand("SELECT Kode_Kendaraan, Nama_Kendaraan, No_Polisi, Kapasitas, Kapasitas_m3, jns_kendaraan, Keterangan, Rec_Stat FROM SIF.dbo.SIF_Kendaraan", sqlconn))
        daListKendaraan.Fill(dsKendaraan, "ListKendaraan")
        gcKendaraan.DataSource = dsKendaraan.Tables("ListKendaraan")
        gvKendaraan.BestFitColumns()
    End Sub

    Private Sub loadDataset(ByVal kode As String)
        If Not dsKendaraan.Tables("Kendaraan") Is Nothing Then dsKendaraan.Tables("Kendaraan").Clear()
        daKendaraan = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Kendaraan WHERE Kode_Kendaraan='" & kode & "'", sqlconn))
        daKendaraan.Fill(dsKendaraan, "Kendaraan")

        If dsKendaraan.Tables("Kendaraan").Rows.Count > 0 Then
            txtKode.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("Kode_Kendaraan")
            txtNama.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("Nama_Kendaraan")
            txtNoPol.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("No_Polisi")
            txtKapasitasIndex.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("Kapasitas")
            txtKapasitasM3.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("Kapasitas_m3")
            lckJenis.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("jns_kendaraan")
            txtKet.EditValue = dsKendaraan.Tables("Kendaraan").Rows(0).Item("Keterangan")
            cmbStatus.EditValue = IIf(dsKendaraan.Tables("Kendaraan").Rows(0).Item("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
        End If
    End Sub

    Private Function getNextNumber() As String
        Dim hasil As String
        drKendaraan = New SqlCommand("SELECT COUNT(Kode_Kendaraan)+1 FROM SIF.dbo.SIF_Kendaraan", sqlconn).ExecuteReader
        drKendaraan.Read()
        If drKendaraan.Item(0) = 0 Then
            hasil = "000"
        Else
            If drKendaraan.Item(0) >= 1 And drKendaraan.Item(0) <= 9 Then
                hasil = "00" & drKendaraan.Item(0)
            ElseIf drKendaraan.Item(0) >= 10 And drKendaraan.Item(0) <= 99 Then
                hasil = "0" & drKendaraan.Item(0)
            Else
                hasil = drKendaraan.Item(0)
            End If
        End If
        drKendaraan.Close()
        Return hasil
    End Function

    Private Sub cek()
        If txtNama.EditValue = vbNullString Or txtNama.EditValue = "" Then
            isValid = False
            err &= "Nama kendaraan tidak boleh kosong." & vbCrLf
            If txtNoPol.EditValue = vbNullString Or txtNoPol.EditValue = "" Then
                err &= "No. polisi tidak boleh kosong." & vbCrLf
            End If
        ElseIf txtNoPol.EditValue = vbNullString Or txtNoPol.EditValue = "" Then
            isValid = False
            err &= "No. polisi tidak boleh kosong." & vbCrLf
            If txtNama.EditValue = vbNullString Or txtNama.EditValue = "" Then
                err &= "Nama kendaraan tidak boleh kosong." & vbCrLf
            Else
                drKendaraan = New SqlCommand("SELECT COUNT(1) FROM SIF.dbo.SIF_Kendaraan WHERE No_Polisi LIKE '" & txtNoPol.EditValue & "'", sqlconn).ExecuteReader
                drKendaraan.Read()
                If drKendaraan.Item(0) = 1 Then
                    err &= "No. polisi sudah ada." & vbCrLf
                End If
            End If
        ElseIf cmbStatus.EditValue = vbNullString Then
            cmbStatus.EditValue = "AKTIF"
            isValid = True
        Else
            isValid = True
        End If
    End Sub

    Public Sub save_click()
        cek()
        If isValid Then
            If state = "ADD" Then
                txtKode.EditValue = getNextNumber()
                kodeKendaraan = txtKode.EditValue
                row = dsKendaraan.Tables("Kendaraan").NewRow
                row.Item("Kd_Cabang") = getKodeCabang()
                row.Item("Kode_Kendaraan") = txtKode.EditValue
                row.Item("Nama_Kendaraan") = txtNama.EditValue
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = umum.username
                row.Item("Program_Name") = Me.Name
                row.Item("No_Polisi") = txtNoPol.EditValue
                row.Item("Kapasitas") = txtKapasitasIndex.EditValue
                row.Item("Kapasitas_m3") = txtKapasitasM3.EditValue
                row.Item("jns_kendaraan") = lckJenis.EditValue
                row.Item("Keterangan") = txtKet.EditValue
                row.Item("Rec_Stat") = IIf(cmbStatus.EditValue = "AKTIF", "Y", "T")
                dsKendaraan.Tables("Kendaraan").Rows.Add(row)
            ElseIf state = "EDIT" Then
                row = dsKendaraan.Tables("Kendaraan").Rows(0)
                row.Item("Nama_Kendaraan") = txtNama.EditValue
                row.Item("No_Polisi") = txtNoPol.EditValue
                row.Item("Kapasitas") = txtKapasitasIndex.EditValue
                row.Item("Kapasitas_m3") = txtKapasitasM3.EditValue
                row.Item("jns_kendaraan") = lckJenis.EditValue
                row.Item("Keterangan") = txtKet.EditValue
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Rec_Stat") = IIf(cmbStatus.EditValue = "AKTIF", "Y", "T")
                row.Item("Last_Updated_By") = umum.username
            End If

            Try
                bldKendaraan = New SqlCommandBuilder(daKendaraan)
                daKendaraan.UpdateCommand = bldKendaraan.GetUpdateCommand()
                daKendaraan.InsertCommand = bldKendaraan.GetInsertCommand()
                daKendaraan.DeleteCommand = bldKendaraan.GetDeleteCommand()

                'BTRANS = sqlconn.BeginTransaction("1")
                'daKendaraan.UpdateCommand.Transaction = BTRANS
                'daKendaraan.InsertCommand.Transaction = BTRANS
                'daKendaraan.DeleteCommand.Transaction = BTRANS

                daKendaraan.Update(dsKendaraan.Tables("Kendaraan"))

                dsKendaraan.Tables("Kendaraan").AcceptChanges()

                'BTRANS.Commit()

                showMessages("Berhasil disimpan..")
                err = ""
                If state = "ADD" Then
                    state = "EDIT"
                ElseIf state = "EDIT" Then
                    state = "ADD"
                End If
                loadDataset(kodeKendaraan)
                loadGrid()
            Catch ex As Exception
                'BTRANS.Rollback()
                dsKendaraan.Tables("Kendaraan").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        Else
            MsgBox("Ada kesalahan dalam mengisi data :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            Exit Sub
        End If
    End Sub

    Private Sub aFormKendaraan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        Me.Enabled = True
        prn = getParent(Me)
        loadLookup()
        loadDataset("XXX")
        loadGrid()
        state = "ADD"
        txtKapasitasIndex.EditValue = 0
        txtKapasitasM3.EditValue = 0
    End Sub

    Private Sub gvKendaraan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvKendaraan.DoubleClick
        state = "EDIT"
        loadDataset(gvKendaraan.GetFocusedRowCellValue("Kode_Kendaraan"))
        tacKendaraan.SelectedTabPage = tabForm
    End Sub

    Private Sub tacKendaraan_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tacKendaraan.SelectedPageChanged
        If e.Page.Name = "tabForm" Then
            btnSave = True
            btnCancel = True
            setStatus()
        Else
            btnSave = False
            btnCancel = False
            setStatus()
        End If
    End Sub

    Private Sub txtKapasitasIndex_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKapasitasIndex.EditValueChanged
        If txtKapasitasIndex.EditValue = vbNullString Then
            txtKapasitasIndex.EditValue = 0
        End If
    End Sub

    Private Sub txtKapasitasIndex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKapasitasIndex.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 44, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtKapasitasM3_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKapasitasM3.EditValueChanged
        If txtKapasitasM3.EditValue = vbNullString Then
            txtKapasitasM3.EditValue = 0
        End If
    End Sub

    Private Sub txtKapasitasM3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKapasitasM3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 44, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class