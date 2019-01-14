Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonPiutJthTmp
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsNota, dsLookUp As New DataSet
    Dim daNota, daNotaDetil, daLookCust, daLookBarang, daLookAlamat, daLookCustomer As SqlDataAdapter
    Dim relNota As DataRelation
    Dim err As String
    Dim isSearch As Boolean = True
    Dim subReport As String

    Public Sub loadLookUp()
        '############ LOAD NAMA ############
        If Not dsLookUp.Tables("LookCust") Is Nothing Then dsLookUp.Tables("LookCust").Clear()
        daLookCust = New SqlDataAdapter(New SqlCommand("SELECT Kd_Customer, Nama_Customer FROM SIF.dbo.SIF_Customer", sqlconn))
        daLookCust.Fill(dsLookUp, "LookCust")
        lookupCust.DataSource = dsLookUp.Tables("LookCust")
        lookupCust.DisplayMember = "Nama_Customer"
        lookupCust.ValueMember = "Kd_Customer"

        '############ LOAD CUSTOMER ############
        If Not dsLookUp.Tables("LookCustomer") Is Nothing Then dsLookUp.Tables("LookCustomer").Clear()
        daLookCustomer = New SqlDataAdapter(New SqlCommand("SELECT Kd_Customer, Nama_Customer FROM SIF.dbo.SIF_Customer UNION SELECT '00000', '[Semua Customer]' ORDER BY Nama_Customer ASC", sqlconn))
        daLookCustomer.Fill(dsLookUp, "LookCustomer")
        lookupCustomer.Properties.DataSource = dsLookUp.Tables("LookCustomer")
        lookupCustomer.Properties.DisplayMember = "Nama_Customer"
        lookupCustomer.Properties.ValueMember = "Kd_Customer"

        '############ LOAD BARANG ############
        If Not dsLookUp.Tables("LookBarang") Is Nothing Then dsLookUp.Tables("LookBarang").Clear()
        daLookBarang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daLookBarang.Fill(dsLookUp, "LookBarang")
        lookupBarang.DataSource = dsLookUp.Tables("LookBarang")
        lookupBarang.DisplayMember = "Nama_Barang"
        lookupBarang.ValueMember = "Kode_Barang"

        '############ LOAD ALAMAT ############
        If Not dsLookUp.Tables("LookAlamat") Is Nothing Then dsLookUp.Tables("LookAlamat").Clear()
        daLookAlamat = New SqlDataAdapter(New SqlCommand("SELECT Kd_Customer, Alamat1 + ', ' + Kota1 AS 'alamat' FROM SIF.dbo.SIF_Customer", sqlconn))
        daLookAlamat.Fill(dsLookUp, "LookAlamat")
        lookupAlamat.DataSource = dsLookUp.Tables("LookAlamat")
        lookupAlamat.DisplayMember = "alamat"
        lookupAlamat.ValueMember = "Kd_Customer"
    End Sub

    Public Sub loadData()
        dsNota.Clear()
        dsNota.Relations.Clear()
        'If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()
        'If Not dsNota.Tables("NotaDetil") Is Nothing Then dsNota.Tables("NotaDetil").Clear()

        If lookupCustomer.EditValue = "00000" Then
            If deTglNotaAwal.EditValue = vbNullString Or deTglNotaAkhir.EditValue = vbNullString Then
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_invFROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            ElseIf Format(deTglNotaAwal.EditValue, "yyyy-MM-dd") = Format(deTglNotaAkhir.EditValue, "yyyy-MM-dd") Then  '
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_invFROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            ElseIf Format(deTglNotaAwal.EditValue, "yyyy-MM-dd") <> Format(deTglNotaAkhir.EditValue, "yyyy-MM-dd") Then
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103)", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103))", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            End If
        Else '
            If deTglNotaAwal.EditValue = vbNullString Or deTglNotaAkhir.EditValue = vbNullString Then
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_invFROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            ElseIf Format(deTglNotaAwal.EditValue, "yyyy-MM-dd") = Format(deTglNotaAkhir.EditValue, "yyyy-MM-dd") Then  '
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_invFROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv = CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            ElseIf Format(deTglNotaAwal.EditValue, "yyyy-MM-dd") <> Format(deTglNotaAkhir.EditValue, "yyyy-MM-dd") Then
                If deTglJthTmpAwal.EditValue = vbNullString Or deTglJthTmpAkhir.EditValue = vbNullString Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") = Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd") Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_inv FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo = CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                ElseIf (Format(deTglJthTmpAwal.EditValue, "yyyy-MM-dd") <> Format(deTglJthTmpAkhir.EditValue, "yyyy-MM-dd")) Then
                    daNota = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "'", sqlconn))
                    daNota.Fill(dsNota, "Nota")
                    daNotaDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (SELECT no_invFROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JPJ%' AND tgl_jth_tempo BETWEEN CONVERT(DATE,'" & deTglJthTmpAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglJthTmpAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') AND tgl_inv BETWEEN CONVERT(DATE,'" & deTglNotaAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglNotaAkhir.EditValue & "',103) AND kd_cust = '" & lookupCustomer.EditValue & "')", sqlconn))
                    daNotaDetil.Fill(dsNota, "NotaDetil")
                End If
            End If
        End If

        relNota = dsNota.Relations.Add("DetilNota", dsNota.Tables("Nota").Columns("no_inv"), dsNota.Tables("NotaDetil").Columns("no_inv"))
        gcNota.DataSource = dsNota.Tables("Nota")
        gcNota.LevelTree.Nodes.Add("DetilNota", gvNotaDetil)
        gvNota.BestFitColumns()
        gvNotaDetil.BestFitColumns()
    End Sub

    Private Sub aFormMonPiutJthTmp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        'deTglNotaAwal.EditValue = getTanggal()
        'deTglNotaAkhir.EditValue = getTanggal()
        'deTglJthTmpAwal.EditValue = getTanggal()
        'deTglJthTmpAkhir.EditValue = getTanggal()
        lookupCustomer.EditValue = "00000"
        loadLookUp()
        loadData()
    End Sub

    Private Sub deTglNotaAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglNotaAwal.EditValueChanged
        If Not deTglNotaAwal.EditValue = vbNullString Then
            If deTglNotaAkhir.EditValue < deTglNotaAwal.EditValue Then
                err &= "Tanggal nota awal tidak boleh lebih dari tanggal nota akhir." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        End If
    End Sub

    Private Sub deTglNotaAkhir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglNotaAkhir.EditValueChanged
        If Not deTglNotaAkhir.EditValue = vbNullString Then
            If deTglNotaAkhir.EditValue < deTglNotaAwal.EditValue Then
                err &= "Tanggal nota akhir tidak boleh kurang dari tanggal nota awal." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        End If
    End Sub

    Private Sub deTglJthTmpAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglJthTmpAwal.EditValueChanged
        If Not deTglJthTmpAwal.EditValue = vbNullString Then
            If deTglNotaAkhir.EditValue < deTglNotaAwal.EditValue Then
                err &= "Tanggal jatuh tempo awal tidak boleh lebih dari tanggal jatuh tempo akhir." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        End If
    End Sub

    Private Sub deTglJthTmpAkhir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglJthTmpAkhir.EditValueChanged
        If Not deTglJthTmpAkhir.EditValue = vbNullString Then
            If deTglNotaAkhir.EditValue < deTglNotaAwal.EditValue Then
                err &= "Tanggal jatuh tempo akhir tidak boleh kurang dari tanggal jatuh tempo awal." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If isSearch = True Then
            loadData()
        Else
            MsgBox(err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Private Sub chkJt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJt.CheckedChanged
        If chkJt.Checked = True Then
            chkMin7.Checked = False
            chkMax7.Checked = False
            gvNota.ActiveFilterString = "GetDate(Now()) >= tgl_jth_tempo"
        ElseIf chkJt.Checked = False Then
            gvNota.ActiveFilterString = ""
        End If
    End Sub

    Private Sub chkMin7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMin7.CheckedChanged
        If chkMin7.Checked = True Then
            chkJt.Checked = False
            chkMax7.Checked = False
            gvNota.ActiveFilterString = "GetDate(Now()) < tgl_jth_tempo And GetDate(Now()) >= GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf chkJt.Checked = False Then
            gvNota.ActiveFilterString = ""
        End If
    End Sub

    Private Sub chkMax7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMax7.CheckedChanged
        If chkMax7.Checked = True Then
            chkJt.Checked = False
            chkMin7.Checked = False
            gvNota.ActiveFilterString = "GetDate(Now()) < GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf chkJt.Checked = False Then
            gvNota.ActiveFilterString = ""
        End If
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

    Public Sub cetak_click()
        If Not gvNota.RowCount <= 0 Then
            'ShowGridPreview(gcNota)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING PIUTANG JATUH TEMPO"
        If deTglNotaAwal.EditValue = deTglNotaAkhir.EditValue Then
            subReport = Format(deTglNotaAwal.EditValue, "d MMMM yyyy").ToString
        Else
        subReport = Format(deTglNotaAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(deTglNotaAkhir.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
    End Sub
End Class