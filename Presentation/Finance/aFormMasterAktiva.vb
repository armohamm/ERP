Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMasterAktiva
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsAktiva As New DataSet
    Dim daLookUp, daAktiva, daAktivaSave As SqlDataAdapter
    Dim state As String
    Dim bldAktiva As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim err, kode As String
    Dim row As DataRow
    Dim hasil, temp As String
    Dim loaded As Boolean
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsAktiva.Tables("Rekening") Is Nothing Then dsAktiva.Tables("Rekening").Clear()
        If Not dsAktiva.Tables("RekAktiva") Is Nothing Then dsAktiva.Tables("RekAktiva").Clear()
        If Not dsAktiva.Tables("RekPeny") Is Nothing Then dsAktiva.Tables("RekPeny").Clear()
        If Not dsAktiva.Tables("RekBiaya") Is Nothing Then dsAktiva.Tables("RekBiaya").Clear()
        If Not dsAktiva.Tables("RekPusatBiaya") Is Nothing Then dsAktiva.Tables("RekPusatBiaya").Clear()
        'If Not dsAktiva.Tables("Satuan") Is Nothing Then dsAktiva.Tables("Satuan").Clear()
        If Not dsAktiva.Tables("StatusPeny") Is Nothing Then dsAktiva.Tables("StatusPeny").Clear()

        'daLookUp = New SqlDataAdapter(New SqlCommand("select kode_satuan, nama_satuan from KOPKAR.dbo.SIF_Satuan", sqlconn))
        'daLookUp.Fill(dsAktiva, "Satuan")
        'lckSatuan.Properties.DataSource = dsAktiva.Tables("Satuan")
        'lckSatuan.Properties.DisplayMember = "nama_satuan"
        'lckSatuan.Properties.ValueMember = "kode_satuan"

        daLookUp = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from KOPKAR.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'STATAKTV'", sqlconn))
        daLookUp.Fill(dsAktiva, "StatusPeny")
        lckStatusPeny.Properties.DataSource = dsAktiva.Tables("StatusPeny")
        lckStatusPeny.Properties.DisplayMember = "Desc_Data"
        lckStatusPeny.Properties.ValueMember = "Id_Data"
        lookupStatus.DataSource = dsAktiva.Tables("StatusPeny")
        lookupStatus.DisplayMember = "Desc_Data"
        lookupStatus.ValueMember = "Id_Data"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar", sqlconn))
        daLookUp.Fill(dsAktiva, "Rekening")
        lookupRekening.DataSource = dsAktiva.Tables("Rekening")
        lookupRekening.ValueMember = "kd_buku_besar"
        lookupRekening.DisplayMember = "nm_buku_besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar where grup_level2 like '131' and grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsAktiva, "RekAktiva")
        lckRekAktiva.Properties.DataSource = dsAktiva.Tables("RekAktiva")
        lckRekAktiva.Properties.ValueMember = "kd_buku_besar"
        lckRekAktiva.Properties.DisplayMember = "nm_buku_besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar where grup_level2 like '132' and grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsAktiva, "RekPeny")
        lckRekPeny.Properties.DataSource = dsAktiva.Tables("RekPeny")
        lckRekPeny.Properties.ValueMember = "kd_buku_besar"
        lckRekPeny.Properties.DisplayMember = "nm_buku_besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from KOPKAR.dbo.m_buku_besar where div4 = 'Y' AND grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsAktiva, "RekBiaya")
        lckRekBiaya.Properties.DataSource = dsAktiva.Tables("RekBiaya")
        lckRekBiaya.Properties.ValueMember = "kd_buku_besar"
        lckRekBiaya.Properties.DisplayMember = "nm_buku_besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_pusat, nm_buku_pusat from KOPKAR.dbo.SIF_buku_pusat", sqlconn))
        daLookUp.Fill(dsAktiva, "RekPusatBiaya")
        lckRekPus.Properties.DataSource = dsAktiva.Tables("RekPusatBiaya")
        lckRekPus.Properties.ValueMember = "kd_buku_pusat"
        lckRekPus.Properties.DisplayMember = "nm_buku_pusat"
        lookupBukuPusat.DataSource = dsAktiva.Tables("RekPusatBiaya")
        lookupBukuPusat.ValueMember = "kd_buku_pusat"
        lookupBukuPusat.DisplayMember = "nm_buku_pusat"
    End Sub

    Private Sub loadGrid()
        If Not dsAktiva.Tables("LoadAktiva") Is Nothing Then dsAktiva.Tables("LoadAktiva").Clear()
        daAktiva = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_MST_AKTIVA", sqlconn))
        daAktiva.Fill(dsAktiva, "LoadAktiva")
        gcBarangJadi.DataSource = dsAktiva.Tables("LoadAktiva")
        gvBarangJadi.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsAktiva.Tables("Aktiva") Is Nothing Then dsAktiva.Tables("Aktiva").Clear()
        daAktivaSave = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_MST_AKTIVA WHERE no_aktiva = '" & kode & "'", sqlconn))
        daAktivaSave.Fill(dsAktiva, "Aktiva")
        'gvBarangJadi.BestFitColumns()

        If dsAktiva.Tables("Aktiva").Rows.Count > 0 Then
            txtNoAktiva.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("no_aktiva")
            txtNamaAktiva.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("nama_aktiva")
            lckSatuan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("satuan")
            txtJumlah.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("jml_aktiva")
            lckRekAktiva.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("rek_aktiva")
            lckRekPeny.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("rek_penyusutan")
            lckRekBiaya.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("rek_biaya")
            lckRekPus.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("rek_pusat_biaya")
            txtNilaiPerolehan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("harga_perolehan")
            txtNilaiPerolehan.Enabled = False
            txtNilaiBuku.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("nilai_buku")
            txtResidu.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("residu")
            cmbStatus.EditValue = IIf(dsAktiva.Tables("Aktiva").Rows(0).Item("status") = "Y", "AKTIF", "TIDAK AKTIF")
            lckStatusPeny.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("sts_aktv")
            dtpTglPerolehan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("tgl_perolehan")
            txtMasaManfaat.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("masa_manfaat")
            dtpTglPenyusutan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("tgl_mulai_penyusutan")
            txtNilaiPenyusutan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("penyusutan_bulan")
            txtAkumPenyusutan.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("akum_penyusutan")
            txtKondisiTeknis.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("kondisi_teknis")
            txtKondisiEkonomis.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("kondisi_ekonomis")
            txtKet.EditValue = dsAktiva.Tables("Aktiva").Rows(0).Item("Keterangan")
        Else
            txtNilaiPerolehan.Enabled = True
        End If

    End Sub

    Public Sub add_click()
        tacBarangJadi.TabPages(0).PageEnabled = True
        Me.Enabled = True
        state = "ADD"
        tacBarangJadi.SelectedTabPage = tabForm
        clear()
        loadData("xxx")
        btnAdd = False
        btnEdit = False
        btnSave = True
        btnDelete = False
        btnCancel = True
        btnCetak = False
        setStatus()
        tacBarangJadi.TabPages(1).PageEnabled = False
    End Sub

    Public Sub edit_click()
        tacBarangJadi.TabPages(1).PageEnabled = True
        Me.Enabled = True
        state = "EDIT"
        tacBarangJadi.TabPages(0).PageEnabled = False
        tacBarangJadi.SelectedTabPage = tabList
        btnAdd = False
        btnEdit = False
        btnSave = False
        btnDelete = False
        btnCancel = True
        btnCetak = True
        setStatus()
    End Sub

    Private Sub aFormBarangJadi1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
        loadGrid()
        'txtNamaBarang.Focus()
    End Sub

    Private Sub clear()
        txtNoAktiva.EditValue = vbNullString
        txtNamaAktiva.EditValue = vbNullString
        lckSatuan.ItemIndex = 0
        txtJumlah.EditValue = 1
        lckRekAktiva.ItemIndex = 0
        lckRekPeny.ItemIndex = 0
        lckRekBiaya.ItemIndex = 0
        lckRekPus.ItemIndex = 0
        txtNilaiPerolehan.EditValue = 1
        txtResidu.EditValue = 1
        cmbStatus.EditValue = "AKTIF"
        lckStatusPeny.ItemIndex = 0
        dtpTglPerolehan.EditValue = getTanggal()
        txtNilaiBuku.EditValue = 1
        txtMasaManfaat.EditValue = 1
        dtpTglPenyusutan.EditValue = getTanggal()
        txtNilaiPenyusutan.EditValue = 1
        txtAkumPenyusutan.EditValue = 0
        txtKondisiTeknis.EditValue = vbNullString
        txtKondisiEkonomis.EditValue = vbNullString
        txtKet.EditValue = vbNullString
    End Sub

    Public Sub cancel_click()
        clear()
        txtNamaAktiva.Focus()
        tacBarangJadi.TabPages(0).PageEnabled = True
        tacBarangJadi.SelectedTabPage = tabForm
        Me.Enabled = False
        btnAdd = True
        btnEdit = True
        btnSave = False
        btnDelete = False
        btnCancel = False
        btnCetak = False
        setStatus()
        state = ""
    End Sub

    Private Sub kodeAktiva()
        Try
            Dim dr2 As SqlDataReader = New SqlCommand("select COUNT(no_aktiva) from KOPKAR.dbo.FIN_MST_AKTIVA", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                If dr2.Item(0) < 10 Then
                    kode = ("0000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9 And dr2.Item(0) < 99 Then
                    kode = ("000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 99 And dr2.Item(0) < 999 Then
                    kode = ("00" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 999 And dr2.Item(0) < 9999 Then
                    kode = ("0" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9999 Then
                    kode = (dr2.Item(0) + 1)
                End If
            End If
            dr2.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cek()
        isValid = True
        If txtNamaAktiva.EditValue = vbNullString Then
            errData.SetError(txtNamaAktiva, "Nama aktiva belum diisi!")
            isValid = False
            If dtpTglPerolehan.EditValue = vbNullString Then
                errData.SetError(dtpTglPerolehan, "Tanggal perolehan belum diisi!")
            Else
                errData.SetError(dtpTglPerolehan, "")
            End If
            If txtNilaiBuku.EditValue = vbNullString Or txtNilaiBuku.EditValue = 0 Then
                errData.SetError(txtNilaiBuku, "Nilai perolehan harus diisi lebih dari 0!")
            Else
                errData.SetError(txtNilaiBuku, "")
            End If
            If txtMasaManfaat.EditValue = vbNullString Or txtMasaManfaat.EditValue = 0 Then
                errData.SetError(txtMasaManfaat, "Masa manfaat belum diisi!")
            Else
                errData.SetError(txtMasaManfaat, "")
            End If
        ElseIf dtpTglPerolehan.EditValue = vbNullString Then
            errData.SetError(dtpTglPerolehan, "Tanggal perolehan belum diisi!")
            isValid = False
            If txtNamaAktiva.EditValue = vbNullString Then
                errData.SetError(txtNamaAktiva, "Nama aktiva belum diisi!")
            Else
                errData.SetError(txtNamaAktiva, "")
            End If
            If txtNilaiBuku.EditValue = vbNullString Or txtNilaiBuku.EditValue = 0 Then
                errData.SetError(txtNilaiBuku, "Nilai perolehan harus diisi lebih dari 0!")
            Else
                errData.SetError(txtNilaiBuku, "")
            End If
            If txtMasaManfaat.EditValue = vbNullString Or txtMasaManfaat.EditValue = 0 Then
                errData.SetError(txtMasaManfaat, "Masa manfaat belum diisi!")
            Else
                errData.SetError(txtMasaManfaat, "")
            End If
        ElseIf txtNilaiBuku.EditValue = vbNullString Or txtNilaiBuku.EditValue = 0 Then
            errData.SetError(txtNilaiBuku, "Nilai perolehan harus diisi lebih dari 0!")
            isValid = False
            If txtNamaAktiva.EditValue = vbNullString Then
                errData.SetError(txtNamaAktiva, "Nama aktiva belum diisi!")
            Else
                errData.SetError(txtNamaAktiva, "")
            End If
            If dtpTglPerolehan.EditValue = vbNullString Then
                errData.SetError(dtpTglPerolehan, "Tanggal perolehan belum diisi!")
            Else
                errData.SetError(dtpTglPerolehan, "")
            End If
            If txtMasaManfaat.EditValue = vbNullString Or txtMasaManfaat.EditValue = 0 Then
                errData.SetError(txtMasaManfaat, "Masa manfaat belum diisi!")
            Else
                errData.SetError(txtMasaManfaat, "")
            End If
        ElseIf txtMasaManfaat.EditValue = vbNullString Or txtMasaManfaat.EditValue = 0 Then
            errData.SetError(txtMasaManfaat, "Masa manfaat belum diisi!")
            isValid = False
            If txtNamaAktiva.EditValue = vbNullString Then
                errData.SetError(txtNamaAktiva, "Nama aktiva belum diisi!")
            Else
                errData.SetError(txtNamaAktiva, "")
            End If
            If dtpTglPerolehan.EditValue = vbNullString Then
                errData.SetError(dtpTglPerolehan, "Tanggal perolehan belum diisi!")
            Else
                errData.SetError(dtpTglPerolehan, "")
            End If
            If txtNilaiBuku.EditValue = vbNullString Or txtNilaiBuku.EditValue = 0 Then
                errData.SetError(txtNilaiBuku, "Nilai perolehan harus diisi lebih dari 0!")
            Else
                errData.SetError(txtNilaiBuku, "")
            End If
        Else
            errData.SetError(txtNamaAktiva, "")
            errData.SetError(dtpTglPerolehan, "")
            errData.SetError(txtNilaiBuku, "")
            errData.SetError(txtMasaManfaat, "")
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        cek()
        If Not isDelete Then
            If isValid Then
                If MsgBox("Simpan aktiva?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then
                    If state = "ADD" Then
                        kodeAktiva()
                        txtNoAktiva.EditValue = kode
                        row = dsAktiva.Tables("Aktiva").NewRow
                        row.Item("Kd_Cabang") = getKodeCabang()
                        row.Item("no_aktiva") = txtNoAktiva.EditValue
                        row.Item("Last_create_date") = getTanggal()
                        row.Item("Last_created_by") = username
                        row.Item("Program_name") = Me.Name
                    ElseIf state = "EDIT" Then
                        row = dsAktiva.Tables("Aktiva").Rows(0)
                        row.Item("Last_update_date") = getTanggal()
                        row.Item("Last_updated_by") = username
                    End If

                    row.Item("nama_aktiva") = txtNamaAktiva.EditValue
                    row.Item("satuan") = "BUAH"
                    row.Item("id_table") = "MASTER"
                    row.Item("jml_aktiva") = txtJumlah.EditValue
                    row.Item("rek_aktiva") = lckRekAktiva.EditValue
                    row.Item("rek_penyusutan") = lckRekPeny.EditValue
                    row.Item("rek_biaya") = lckRekBiaya.EditValue
                    row.Item("rek_pusat_biaya") = lckRekPus.EditValue
                    row.Item("nilai_buku") = txtNilaiBuku.EditValue
                    row.Item("residu") = txtResidu.EditValue
                    row.Item("status") = IIf(cmbStatus.EditValue = "AKTIF", "Y", "T")
                    row.Item("sts_aktv") = lckStatusPeny.EditValue
                    row.Item("tgl_perolehan") = dtpTglPerolehan.EditValue
                    row.Item("harga_perolehan") = txtNilaiPerolehan.EditValue
                    row.Item("masa_manfaat") = txtMasaManfaat.EditValue
                    row.Item("tgl_mulai_penyusutan") = dtpTglPenyusutan.EditValue
                    row.Item("penyusutan_bulan") = txtNilaiPenyusutan.EditValue
                    row.Item("akum_penyusutan") = txtAkumPenyusutan.EditValue
                    row.Item("kondisi_teknis") = txtKondisiTeknis.EditValue
                    row.Item("kondisi_ekonomis") = txtKondisiEkonomis.EditValue
                    row.Item("keterangan") = txtKet.EditValue

                    If state = "ADD" Then
                        dsAktiva.Tables("Aktiva").Rows.Add(row)
                    End If
                Else
                    Exit Sub
                End If
                'Else
                'MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                'Exit Sub
                Try
                    bldAktiva = New SqlCommandBuilder(daAktivaSave)
                    daAktivaSave.UpdateCommand = bldAktiva.GetUpdateCommand()
                    daAktivaSave.InsertCommand = bldAktiva.GetInsertCommand()
                    daAktivaSave.DeleteCommand = bldAktiva.GetDeleteCommand()

                    BTRANS = sqlconn.BeginTransaction("1")
                    daAktivaSave.UpdateCommand.Transaction = BTRANS
                    daAktivaSave.InsertCommand.Transaction = BTRANS
                    daAktivaSave.DeleteCommand.Transaction = BTRANS

                    daAktivaSave.Update(dsAktiva.Tables("Aktiva"))

                    dsAktiva.Tables("Aktiva").AcceptChanges()

                    BTRANS.Commit()

                    showMessages("Berhasil disimpan..")
                    err = ""
                    loadGrid()
                    clear()
                Catch ex As Exception
                    BTRANS.Rollback()
                    dsAktiva.Tables("Aktiva").RejectChanges()
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                End Try
            End If
        End If
    End Sub

    Private Sub gvBarangJadi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvBarangJadi.DoubleClick
        tacBarangJadi.TabPages(0).PageEnabled = True
        loadData(gvBarangJadi.GetFocusedRowCellValue("no_aktiva").ToString)
        tacBarangJadi.SelectedTabPage = tabForm
        btnSave = True
        setStatus()
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPrintPreview()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MASTER AKTIVA"

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
    End Sub

    Public Sub cetak_click()
        If Not gvBarangJadi.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub txtNilaiBuku_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNilaiBuku.EditValueChanged
        'txtNilaiBuku.EditValue = txtNilaiPerolehan.EditValue - txtAkumPenyusutan.EditValue
        If txtNilaiBuku.EditValue = vbNull Then
            txtNilaiBuku.EditValue = 1
        End If
    End Sub

    Private Sub txtAkumPenyusutan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAkumPenyusutan.EditValueChanged
        If txtAkumPenyusutan.EditValue = vbNull Then
            txtAkumPenyusutan.EditValue = 1
        End If
    End Sub

    Private Sub txtMasaManfaat_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMasaManfaat.EditValueChanged
        If txtMasaManfaat.EditValue = vbNull Then
            txtMasaManfaat.EditValue = 1
        End If
        If Not (txtMasaManfaat.EditValue = 0 Or txtMasaManfaat.EditValue = vbNullString) Then
            txtNilaiPenyusutan.EditValue = CDbl(txtNilaiPerolehan.EditValue / txtMasaManfaat.EditValue)
        End If
    End Sub

    Private Sub lckRekAktiva_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lckRekAktiva.EditValueChanged
        If Not lckRekAktiva.EditValue = "131.01.01" Then
            Select Case lckRekAktiva.EditValue
                Case "131.01.02" : lckRekPeny.EditValue = "132.01.02" : lckRekBiaya.EditValue = "521.01.18" : lckRekPus.EditValue = "90000002"
                Case "131.01.03" : lckRekPeny.EditValue = "132.01.03" : lckRekBiaya.EditValue = "521.01.18" : lckRekPus.EditValue = "90000002"
                Case "131.01.04" : lckRekPeny.EditValue = "132.01.04" : lckRekBiaya.EditValue = "521.01.18" : lckRekPus.EditValue = "90000002"
                Case "131.02.04" : lckRekPeny.EditValue = "132.02.04" : lckRekBiaya.EditValue = "521.02.04" : lckRekPus.EditValue = "90000003"
                Case "131.03.04" : lckRekPeny.EditValue = "132.03.04" : lckRekBiaya.EditValue = "521.03.07" : lckRekPus.EditValue = "90000004"
                Case "131.04.01" : lckRekPeny.EditValue = "132.04.01" : lckRekBiaya.EditValue = "521.04.04" : lckRekPus.EditValue = "90000005"
            End Select
        End If
    End Sub

    Private Sub txtNilaiPerolehan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNilaiPerolehan.EditValueChanged
        If state = "ADD" Then
            txtNilaiBuku.EditValue = txtNilaiPerolehan.EditValue
            If Not (txtMasaManfaat.EditValue = 0 Or txtMasaManfaat.EditValue = vbNullString) Then
                txtNilaiPenyusutan.EditValue = CDbl(txtNilaiPerolehan.EditValue / txtMasaManfaat.EditValue)
            End If
        End If
        If txtNilaiPerolehan.EditValue = vbNull Then
            txtNilaiPerolehan.EditValue = 1
        End If
    End Sub

    Private Sub txtResidu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResidu.EditValueChanged
        If txtResidu.EditValue = vbNull Then
            txtResidu.EditValue = 1
        End If
        If txtNilaiBuku.EditValue = vbNull Then
            txtNilaiBuku.EditValue = txtNilaiPerolehan.EditValue - txtResidu.EditValue
        End If
    End Sub

    Private Sub txtNilaiPenyusutan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNilaiPenyusutan.EditValueChanged
        If txtNilaiPenyusutan.EditValue = vbNull Then
            txtNilaiPenyusutan.EditValue = 1
        End If
    End Sub
End Class