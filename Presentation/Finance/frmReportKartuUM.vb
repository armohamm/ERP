Imports System.Data.SqlClient
Public Class frmReportKartuUM
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsLookUPValuta, dsKartu, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daKartu, daThn, daBln, daLookUp As SqlDataAdapter

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim isOK As Boolean = True

    Private Sub frmReportKartuUM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()

    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

        dsLookUPValuta.Clear()
        daLookUPValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daLookUPValuta.Fill(dsLookUPValuta, "Valuta")
        Valuta.Properties.DataSource = dsLookUPValuta.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        dsKartu.Clear()
        daKartu = New SqlDataAdapter(New SqlCommand("select nama,kode from FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsKartu, "kartu")
        KartuX.Properties.DataSource = dsKartu.Tables("kartu")
        KartuX.Properties.DisplayMember = "nama"
        KartuX.Properties.ValueMember = "kode"
    End Sub

End Class