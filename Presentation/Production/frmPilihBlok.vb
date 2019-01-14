Imports System.Data.SqlClient
Public Class frmPilihBlok
    Dim ds1 As New DataSet
    Dim da1 As New SqlDataAdapter

    Public nama_barang, Jenis_RPH, nama_blok As String
    Dim TemplatePur As String = "TemplateRPH"

    Private Sub frmCetakRPH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtJadwal.EditValue = Nothing
        If Not ds1.Tables("BlokBusa") Is Nothing Then ds1.Tables("BlokBusa").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan, " & _
        '                                        "SIF_Barang.Nama_Barang FROM SIF.dbo.SIF_Barang SIF_Barang where SIF_Barang.kd_jenis = '072' AND Kd_Depart= '3'  and SIF_Barang.Nama_Barang like '" & nama_barang & "%'", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan, " & _
                                                "SIF_Barang.Nama_Barang FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                                                "inner join SIF.dbo.SIF_Jenis_Barang JB " & _
                                                "on JB.Kd_Jns_Brg = SIF_Barang.kd_jenis " & _
                                                "where jb.[group] = '06' AND Kd_Depart= '3'  " & _
                                                "and SIF_Barang.Nama_Barang like '" & nama_barang & "%' order by SIF_Barang.Nama_Barang asc ", sqlconn))

        da1.Fill(ds1, "BlokBusa")
        If ds1.Tables("BlokBusa").Rows.Count = 0 Then
            Me.txtJadwal.Properties.NullText = "[Data Tidak Ditemukan]"
        Else
            Me.txtJadwal.Properties.NullText = "[Pilih Blok Busa]"
        End If
        Me.txtJadwal.Properties.DataSource = ds1.Tables("BlokBusa")
        Me.txtJadwal.Properties.ValueMember = "Kode_Barang"
        Me.txtJadwal.Properties.DisplayMember = "Nama_Barang"

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Jenis_RPH = ""
        'no_rph = ""
        Me.Close()
    End Sub



    Private Sub Pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pilih.Click
        nama_blok = txtJadwal.EditValue
        Me.Hide()
    End Sub
End Class