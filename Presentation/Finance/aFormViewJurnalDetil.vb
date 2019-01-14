Imports System.Data.SqlClient

Public Class aFormViewJurnalDetil
    Dim dsCari As New DataSet
    Dim daCari, daLookup As SqlDataAdapter
    Public prn As frmMain

    Private Sub loadLookUp()
        If Not dsCari.Tables("bukubesar") Is Nothing Then dsCari.Tables("bukubesar").Clear()
        If Not dsCari.Tables("kartu") Is Nothing Then dsCari.Tables("kartu").Clear()
        If Not dsCari.Tables("bukupusat") Is Nothing Then dsCari.Tables("bukupusat").Clear()
        If Not dsCari.Tables("valuta") Is Nothing Then dsCari.Tables("valuta").Clear()

        daLookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar", sqlconn))
        daLookup.Fill(dsCari, "bukubesar")
        lookBB.DataSource = dsCari.Tables("bukubesar")
        lookBB.ValueMember = "kd_buku_besar"
        lookBB.DisplayMember = "nm_buku_besar"

        daLookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT kode, nama FROM KOPKAR.dbo.v_kartu", sqlconn))
        daLookup.Fill(dsCari, "kartu")
        lookKartu.DataSource = dsCari.Tables("kartu")
        lookKartu.ValueMember = "kode"
        lookKartu.DisplayMember = "nama"

        daLookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM KOPKAR.dbo.SIF_buku_pusat", sqlconn))
        daLookup.Fill(dsCari, "bukupusat")
        lookPusat.DataSource = dsCari.Tables("bukupusat")
        lookPusat.ValueMember = "kd_buku_pusat"
        lookPusat.DisplayMember = "nm_buku_pusat"

        daLookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM KOPKAR.dbo.SIF_Valuta", sqlconn))
        daLookup.Fill(dsCari, "valuta")
        lookVal.DataSource = dsCari.Tables("valuta")
        lookVal.ValueMember = "Kode_Valuta"
        lookVal.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub aFormViewJurnalDetil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
    End Sub

    Public Sub cariJurnal(ByVal kode As String, ByVal thnbln As String)
        If Not dsCari.Tables("jurnal") Is Nothing Then dsCari.Tables("jurnal").Clear()

        daLookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM KOPKAR.dbo.v_jurnal_detail WHERE thnbln = '" & thnbln & "' AND kd_buku_besar = '" & kode & "' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
        daLookup.Fill(dsCari, "jurnal")
        gcDetil.DataSource = dsCari.Tables("jurnal")
        gvDetil.BestFitColumns()
        
    End Sub

End Class