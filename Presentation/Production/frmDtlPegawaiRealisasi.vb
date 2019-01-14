Imports System.Data.SqlClient
Public Class frmDtlPegawaiRealisasi
    Public dipilih As String
    Public row As Data.DataRow
    Dim table As DataTable
    Dim da1, da2 As New SqlDataAdapter
    Dim ds1 As New DataSet
    Public state, no_rls As String
    Private Sub frmDtlSO1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        set_dso()
        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai order by Nama_Pegawai", sqlconn))
        da1.Fill(ds1, "pegawai")
        lkpegawai.DataSource = ds1.Tables("pegawai")
    End Sub
    Sub set_dso()
        If state = "ADD" Then
            If Not ds1.Tables("spkmDetilPegawaiTemp") Is Nothing Then ds1.Tables("spkmDetilPegawaiTemp").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select kd_pegawai, '' Nama_Bagian from PROD.dbo.PROD_rls_spk_man_p where 1=0", sqlconn))
            da2.Fill(ds1, "spkmDetilPegawaiTemp")
            GridControl1.DataSource = ds1.Tables("spkmDetilPegawaiTemp")
        ElseIf state = "EDIT" Then
            If Not ds1.Tables("spkmDetilPegawaiTemp") Is Nothing Then ds1.Tables("spkmDetilPegawaiTemp").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select kd_pegawai, '' Nama_Bagian from PROD.dbo.PROD_rls_spk_man_p where no_spk_man_rls ='" & no_rls & "'", sqlconn))
            da2.Fill(ds1, "spkmDetilPegawaiTemp")
            GridControl1.DataSource = ds1.Tables("spkmDetilPegawaiTemp")
        End If
      
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim tgl As Date = getTanggal()
        Dim frm As Object

        frm = frmMain.pnlDisplay2.Controls(0)
        frm.set_dso_peg(ds1.Tables("spkmDetilPegawaiTemp"))
        Me.Close()

        '    For i = ds1.Tables("spkmDetilPegawaiTemp").Rows.Count - 1 To 0 Step -1
        '        Dim rows As DataRow = ds1.Tables("spkmDetilPegawaiTemp").Rows(i)

        '        frmzRlsSpkInsentif.set_dspeg(rows("kd_pegawai"))
        '    Next

    End Sub
End Class