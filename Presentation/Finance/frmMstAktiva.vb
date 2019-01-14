'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class frmMstAktiva
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Public obj As Object

    Public STATE As String
    Dim row As DataRow

    Dim dsJurnal, dsCari, dsAktiva, dsLOVsatuan, dsLOVtipe, dsLOVBbiaya, dsLOVBpusat, dsAktivaTemp, dsLOVRekPenyus As New DataSet
    Dim daJurnal, daJurnalD, daAktiva, daLOVsatuan, daLOVtipe, daLOVBbiaya, daLOVBpusat, daLOVRekPenyus As SqlDataAdapter

    Dim myBuilder As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dr As SqlDataReader
    Dim param, ParamGenKode As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub Cancel_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database ??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then save_click()

        STATE = "ADD"
        lblState.Text = "ADD STATE"
        GenKode()
        txtNoAktiva.Text = ParamGenKode
        bersih()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
        GenKode()
        txtNoAktiva.Text = ParamGenKode
        lblState.Text = "ADD STATE"
    End Sub

    Private Sub frmMstAktiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        GenLOV()
        setPrimaryKey()
        loadTemp()
        
    End Sub

    Sub loadTemp()
        If Not dsAktiva.Tables("Temp") Is Nothing Then dsAktiva.Tables("Temp").Clear()
        daAktiva = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_AKTIVA ", sqlconn))
        daAktiva.Fill(dsAktiva, "Temp")
        GC.DataSource = dsAktiva.Tables("Temp")
        GV.BestFitColumns()
    End Sub

    Sub GenLOV()
        daLOVsatuan = New SqlDataAdapter(New SqlCommand("select kode_satuan, nama_satuan from SIF.dbo.SIF_Satuan", sqlconn))
        daLOVsatuan.Fill(dsLOVsatuan, "Satuan")
        LOVSatuan.Properties.DataSource = dsLOVsatuan.Tables("Satuan")
        LOVSatuan.Properties.DisplayMember = "nama_satuan"
        LOVSatuan.Properties.ValueMember = "kode_satuan"

        daLOVtipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar where kd_buku_besar like '109%' and grup_header = 'D'", sqlconn))
        daLOVtipe.Fill(dsLOVtipe, "tipe")
        LOVRekAktiva.Properties.DataSource = dsLOVtipe.Tables("tipe")
        LOVRekAktiva.Properties.DisplayMember = "nm_buku_besar"
        LOVRekAktiva.Properties.ValueMember = "kd_buku_besar"

        daLOVBbiaya = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar where kd_buku_besar like '5422%' and grup_header = 'D'", sqlconn))
        daLOVBbiaya.Fill(dsLOVBbiaya, "biaya")
        LOVBbiaya.Properties.DataSource = dsLOVBbiaya.Tables("biaya")
        LOVBbiaya.Properties.DisplayMember = "nm_buku_besar"
        LOVBbiaya.Properties.ValueMember = "kd_buku_besar"

        daLOVBpusat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_pusat ", sqlconn))
        daLOVBpusat.Fill(dsLOVBpusat, "pusat")
        LOVBpusat.Properties.DataSource = dsLOVBpusat.Tables("pusat")
        LOVBpusat.Properties.DisplayMember = "nm_buku_pusat"
        LOVBpusat.Properties.ValueMember = "kd_buku_pusat"

        daLOVRekPenyus = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar where kd_buku_besar like '109%' and grup_header = 'D'", sqlconn))
        daLOVRekPenyus.Fill(dsLOVRekPenyus, "penyusutan")
        LOVRekPenyusutan.Properties.DataSource = dsLOVRekPenyus.Tables("penyusutan")
        LOVRekPenyusutan.Properties.DisplayMember = "nm_buku_besar"
        LOVRekPenyusutan.Properties.ValueMember = "kd_buku_besar"

    End Sub

    Sub setPrimaryKey(Optional ByVal no_aktiva As String = "*")
        If Not dsAktiva.Tables("Aktiva") Is Nothing Then dsAktiva.Tables("Aktiva").Clear()

        daAktiva = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_AKTIVA where no_aktiva = '" & no_aktiva & "' ", sqlconn))
        daAktiva.Fill(dsAktiva, "Aktiva")
    End Sub


    Sub GenKode()
        Try
            Dim dr2 As SqlDataReader = New SqlCommand("select COUNT(no_aktiva) from FIN.dbo.FIN_MST_AKTIVA ", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                If dr2.Item(0) < 10 Then
                    ParamGenKode = ("0000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9 Then
                    ParamGenKode = ("000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 99 Then
                    ParamGenKode = ("00" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 999 Then
                    ParamGenKode = ("0" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9999 Then
                    ParamGenKode = (dr2.Item(0) + 1)
                End If

            End If
            dr2.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick


        'row = dsAktiva.Tables("Temp").Rows(GV.GetSelectedRows(0))

        setPrimaryKey(GV.GetRow(GV.GetSelectedRows(0)).item("no_aktiva"))

        txtKdCabang.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("Kd_cabang")
        txtNoAktiva.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("no_aktiva")
        txtIdTable.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("id_table")
        txtNmAktiva.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nama_aktiva")
        LOVSatuan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("satuan")
        txtJmlAktiva.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("jml_aktiva")
        txtKonTek.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kondisi_teknis")
        txtKonEko.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kondisi_ekonomis")
        txtKeterangan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("keterangan")
        tglPerolehan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_perolehan")
        txtHargaPero.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("harga_perolehan")
        txtMasaMan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("masa_manfaat")
        tglMulaiPenyus.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_mulai_penyusutan")
        txtNilaiPenyus.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nilai_penyusutan")
        txtPenyusBulan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("penyusutan_bulan")
        txtNilaiBuku.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nilai_buku")

        LOVRekAktiva.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("rek_aktiva")
        LOVBbiaya.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("rek_biaya")
        LOVBpusat.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("rek_pusat_biaya")
        cmbStatus.EditValue = IIf(GV.GetRow(GV.GetSelectedRows(0)).item("status") = "A", "AKTIF", "DEAKTIF")

        STATE = "EDIT"
        lblState.Text = "EDIT STATE"
    End Sub


    Public Sub save_click()
        Try

            If STATE = "ADD" Then

                GenKode()

                txtNoAktiva.EditValue = ParamGenKode

                row = dsAktiva.Tables("Aktiva").NewRow

                txtKdCabang.EditValue = getKodeCabang()

                row.Item("Kd_cabang") = txtKdCabang.EditValue
                row.Item("no_aktiva") = txtNoAktiva.EditValue
                row.Item("id_table") = txtIdTable.EditValue

                row.Item("last_create_date") = getTanggal()
                row.Item("last_created_by") = umum.username
                row.Item("program_name") = Me.Name

                dsAktiva.Tables("Aktiva").Rows.Add(row)


            End If

            If STATE = "EDIT" Then

                row = dsAktiva.Tables("Aktiva").Rows(0)
                row.Item("last_update_date") = getTanggal()
                row.Item("last_updated_by") = umum.username

            End If

            row.Item("nama_aktiva") = txtNmAktiva.EditValue
            row.Item("satuan") = LOVSatuan.EditValue
            row.Item("jml_aktiva") = txtJmlAktiva.EditValue
            row.Item("kondisi_teknis") = txtKonTek.EditValue
            row.Item("kondisi_ekonomis") = txtKonEko.EditValue
            row.Item("keterangan") = txtKeterangan.EditValue
            row.Item("tgl_perolehan") = tglPerolehan.EditValue
            row.Item("harga_perolehan") = txtHargaPero.EditValue
            row.Item("masa_manfaat") = txtMasaMan.EditValue
            row.Item("tgl_mulai_penyusutan") = tglMulaiPenyus.EditValue
            row.Item("nilai_penyusutan") = txtNilaiPenyus.EditValue
            row.Item("penyusutan_bulan") = txtPenyusBulan.EditValue
            row.Item("nilai_buku") = txtNilaiBuku.EditValue

            row.Item("residu") = txtResidu.EditValue
            row.Item("akum_penyusutan") = txtAkumPenyus.EditValue
            row.Item("rek_penyusutan") = LOVRekPenyusutan.EditValue

            row.Item("rek_aktiva") = LOVRekAktiva.EditValue
            row.Item("rek_biaya") = LOVBbiaya.EditValue
            row.Item("rek_pusat_biaya") = LOVBpusat.EditValue
            row.Item("status") = IIf(cmbStatus.EditValue = "AKTIF", "A", "D")

            myBuilder = New SqlCommandBuilder(daAktiva)
            daAktiva.UpdateCommand = myBuilder.GetUpdateCommand()
            daAktiva.InsertCommand = myBuilder.GetInsertCommand()
            daAktiva.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daAktiva.UpdateCommand.Transaction = BTRANS
            daAktiva.InsertCommand.Transaction = BTRANS
            daAktiva.DeleteCommand.Transaction = BTRANS

            daAktiva.Update(dsAktiva.Tables("Aktiva"))

            'dsAktiva.Tables("Aktiva").AcceptChanges()

            Try
                BTRANS.Commit()
                showMessages("Data Baru Berhasil Disimpan")
            Catch ex As Exception
                BTRANS.Rollback()
                dsAktiva.Tables("Aktiva").RejectChanges()
                MsgBox(ex.Message)
            End Try
            loadTemp()

        Catch ex As Exception
            MsgBox("Ada masalah dalam menyimpan data. Detail Error : " & ex.Message)
        End Try
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        save_click()
    End Sub

    Sub bersih()
        txtNmAktiva.EditValue = vbNullString
        LOVSatuan.EditValue = vbNullString
        txtJmlAktiva.EditValue = vbNullString
        txtKonTek.EditValue = vbNullString
        txtKonEko.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
        tglPerolehan.EditValue = vbNullString
        txtHargaPero.EditValue = vbNullString
        txtMasaMan.EditValue = vbNullString
        tglMulaiPenyus.EditValue = vbNullString
        txtNilaiPenyus.EditValue = vbNullString
        txtPenyusBulan.EditValue = vbNullString
        txtNilaiBuku.EditValue = vbNullString
        txtResidu.EditValue = vbNullString
        txtAkumPenyus.EditValue = vbNullString
        LOVRekAktiva.EditValue = vbNullString
        LOVRekPenyusutan.EditValue = vbNullString
        LOVBbiaya.EditValue = vbNullString
        LOVBpusat.EditValue = vbNullString
        cmbStatus.EditValue = "AKTIF"
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        loadTemp()
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        ShowGridPreview(GV.GridControl)
    End Sub

    Private Sub txtHargaPero_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaPero.EditValueChanged
        txtNilaiBuku.EditValue = txtHargaPero.EditValue - txtAkumPenyus.EditValue
        txtNilaiPenyus.EditValue = CDbl(txtHargaPero.EditValue / txtMasaMan.EditValue)
    End Sub

    Private Sub txtMasaMan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMasaMan.EditValueChanged
        txtNilaiBuku.EditValue = txtHargaPero.EditValue - txtAkumPenyus.EditValue
        txtNilaiPenyus.EditValue = CDbl(txtHargaPero.EditValue / txtMasaMan.EditValue)
    End Sub

    Private Sub txtAkumPenyus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAkumPenyus.EditValueChanged
        txtNilaiBuku.EditValue = txtHargaPero.EditValue - txtAkumPenyus.EditValue
        txtNilaiPenyus.EditValue = CDbl(txtHargaPero.EditValue / txtMasaMan.EditValue)
    End Sub

    Private Sub LOVRekAktiva_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVRekAktiva.EditValueChanged
        Dim x As Integer
        x = LOVRekAktiva.ItemIndex
        txtJmlAktiva.Text = 1
        LOVRekPenyusutan.ItemIndex = x
    End Sub
End Class