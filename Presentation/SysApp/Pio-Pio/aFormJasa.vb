Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class aFormJasa
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsBarangJadi As New DataSet
    Dim daLookUp, daBarangJadi As SqlDataAdapter
    Dim state As String
    Dim bldBarangJadi As New SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim err As String
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
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsBarangJadi.Tables("Rekening") Is Nothing Then dsBarangJadi.Tables("Rekening").Clear()
        If Not dsBarangJadi.Tables("Status") Is Nothing Then dsBarangJadi.Tables("Status").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '54%'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Rekening")
        lckRekJual1.Properties.DataSource = dsBarangJadi.Tables("Rekening")
        lckRekJual1.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJual1.Properties.DisplayMember = "Nm_Buku_Besar"
        lookuppenj1.DataSource = dsBarangJadi.Tables("Rekening")
        lookuppenj1.ValueMember = "Kd_Buku_Besar"
        lookuppenj1.DisplayMember = "Nm_Buku_Besar"

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 'Y' as kode, 'Aktif' as stat UNION SELECT 'T', 'Tidak Aktif'", sqlconn))
        daLookUp.Fill(dsBarangJadi, "Status")
        lckStatus.Properties.DataSource = dsBarangJadi.Tables("Status")
        lckStatus.Properties.ValueMember = "kode"
        lckStatus.Properties.DisplayMember = "stat"
    End Sub

    Private Sub loadGrid()
        If Not dsBarangJadi.Tables("BarangJadi") Is Nothing Then dsBarangJadi.Tables("BarangJadi").Clear()
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE kd_jns_persd='4'", sqlconn))
        daBarangJadi.Fill(dsBarangJadi, "BarangJadi")
        gcBarangJadi.DataSource = dsBarangJadi.Tables("BarangJadi")
        gvBarangJadi.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsBarangJadi.Tables("Barang") Is Nothing Then dsBarangJadi.Tables("Barang").Clear()
        daBarangJadi = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & kode & "'", sqlconn))
        daBarangJadi.Fill(dsBarangJadi, "Barang")
        gvBarangJadi.BestFitColumns()

        If dsBarangJadi.Tables("Barang").Rows.Count > 0 Then
            txtKodeBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Kode_Barang")
            txtNamaBarang.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Nama_Barang")
            lckStatus.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Rec_Stat")
            lckRekJual1.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("rek_biaya")
            txtKet.EditValue = dsBarangJadi.Tables("Barang").Rows(0).Item("Keterangan")
        End If
    End Sub

    Private Sub aFormBarangJadi1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        loadData("xxx")
        loadGrid()
        lckStatus.EditValue = "Y"
        state = "ADD"
        'txtNamaBarang.Focus()
    End Sub

    Private Sub cek()
        err = ""
        If txtNamaBarang.Text = "" Then
            err &= "Nama Barang harus diisi." & vbCrLf
            isValid = False
        End If
    End Sub

    Public Sub cancel_click()
        txtKodeBarang.EditValue = vbNullString
        lckStatus.EditValue = vbNullString
        lckRekJual1.EditValue = vbNullString
        txtKet.EditValue = vbNullString
        txtNamaBarang.Text = ""
        txtNamaBarang.Focus()
    End Sub

    Private Sub kodebarang()
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '1' AND kd_jns_persd = '4' AND kd_jenis= '000' AND kd_merk='00' AND kd_tipe= '000' AND kd_sub_tipe= '000' AND kd_ukuran='000'AND kd_kain= '000' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = "1400000000000000000" & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = "1400000000000000000" & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = "1400000000000000000" & temp
            Else
                temp = sqlDR.Item(0)
                hasil = "1400000000000000000" & temp
            End If
        End If
        sqlDR.Close()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isValid Then

                If state = "ADD" Then
                    kodebarang()
                    txtKodeBarang.EditValue = hasil
                    row = dsBarangJadi.Tables("Barang").NewRow
                    row.Item("Kd_Cabang") = getKodeCabang()
                    row.Item("Kd_jns_persd") = "4"
                    row.Item("Kode_Barang") = txtKodeBarang.EditValue
                    row.Item("no_urut") = temp
                    row.Item("Last_Create_Date") = getTanggal()
                    row.Item("Last_Created_By") = username
                    row.Item("Program_Name") = Me.Name
                ElseIf state = "EDIT" Then
                    row = dsBarangJadi.Tables("Barang").Rows(0)
                    row.Item("Last_Update_Date") = getTanggal()
                    row.Item("Last_Updated_By") = username
                End If

                row.Item("Kd_Satuan") = "UNIT"
                row.Item("kd_Depart") = "1"
                row.Item("kd_jenis") = "000"
                row.Item("lokasi") = "G0001"
                row.Item("kd_merk") = "00"
                row.Item("kd_tipe") = "000"
                row.Item("kd_sub_tipe") = "000"
                row.Item("kd_ukuran") = "000"
                row.Item("kd_kain") = "000"
                row.Item("Nama_Barang") = txtNamaBarang.EditValue
                row.Item("Keterangan") = txtKet.EditValue
                row.Item("rek_biaya") = lckRekJual1.EditValue
                row.Item("Rec_Stat") = lckStatus.EditValue

                If state = "ADD" Then
                    dsBarangJadi.Tables("Barang").Rows.Add(row)
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
                Exit Sub
            End If
        End If

        Try
            bldBarangJadi = New SqlCommandBuilder(daBarangJadi)
            daBarangJadi.UpdateCommand = bldBarangJadi.GetUpdateCommand()
            daBarangJadi.InsertCommand = bldBarangJadi.GetInsertCommand()
            daBarangJadi.DeleteCommand = bldBarangJadi.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daBarangJadi.UpdateCommand.Transaction = BTRANS
            daBarangJadi.InsertCommand.Transaction = BTRANS
            daBarangJadi.DeleteCommand.Transaction = BTRANS

            daBarangJadi.Update(dsBarangJadi.Tables("Barang"))

            dsBarangJadi.Tables("Barang").AcceptChanges()

            BTRANS.Commit()

            showMessages("Berhasil disimpan..")
            err = ""
            state = "EDIT"
            loadData(hasil)
            loadGrid()
        Catch ex As Exception
            BTRANS.Rollback()
            dsBarangJadi.Tables("Barang").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub

    Private Sub gvBarangJadi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvBarangJadi.DoubleClick
        state = "EDIT"
        loadData(gvBarangJadi.GetFocusedRowCellValue("Kode_Barang").ToString)
        tacBarangJadi.SelectedTabPage = tabForm
    End Sub

    Private Sub tacBarangJadi_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tacBarangJadi.SelectedPageChanged
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

    Private Sub gcBarangJadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcBarangJadi.Click

    End Sub
End Class