'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmGenerate
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private DA, DA2 As SqlDataAdapter
    Private ds, ds2 As New DataSet
    Dim rw, rwa As DataRow


    Private Sub btn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click
        Dim ji, ro, lu, pat, mo, nem, tu, wolu As String

        'Dim tes, i As Int16
        'Dim sqldr As SqlDataReader = New SqlCommand("select count(*) as kosong from sif.dbo.temp_barang where kd_barang is NULL", sqlconn).ExecuteReader
        'If sqldr.Read Then
        '    tes = sqldr.Item(0)
        '    sqldr.Close()
        '    MsgBox(tes)
        '    For i = 0 To tes
        '        Dim sqldr1 As SqlDataReader = New SqlCommand("", sqlconn).ExecuteReader
        '        While sqldr1.Read

        '        End While
        '    Next
        'Else
        '    MsgBox("data sudah terisi semua!")
        'End If

        Dim sqldr As SqlDataReader = New SqlCommand("select isnull(dep.Kd_Departemen,0),isnull(psd.Kd_Jns_Persd,0),isnull(jns.Kd_Jns_Brg,0),isnull(mrk.Kode_Merk,0),isnull(tpe.Kode_Tipe,'000'),isnull(stp.Kd_Sub_Tipe,'000'),isnull(uk.Kode_Ukuran,'000'),isnull(kai.Kode_Kain,'000') from SIF.dbo.temp_barang as tmp LEFT join sif.dbo.SIF_Departemen as dep on dep.Nama_Departemen=tmp.divisi LEFT join SIF.dbo.SIF_Jns_Persediaan as psd on tmp.jns_persediaan=psd.Nama_Persediaan LEFT join SIF.dbo.SIF_Jenis_Barang as jns on tmp.jenis_barang=jns.Nama_Jenis LEFT JOIN sif.dbo.SIF_Merk as mrk on tmp.merk=mrk.Nama_Merk LEFT JOIN sif.dbo.SIF_Tipe as tpe on tmp.tipe=tpe.Nama_Tipe LEFT JOIN sif.dbo.SIF_Tipe as tp on tmp.tipe=tp.Nama_Tipe left join sif.dbo.SIF_Sub_Tipe as stp on tp.Kode_Tipe=stp.Kd_Tipe LEFT join SIF.dbo.SIF_Ukuran as uk on tmp.ukuran=uk.Nama_Ukuran LEFT JOIN sif.dbo.SIF_Kain as kai on tmp.kain=kai.Merk_Kain", sqlconn).ExecuteReader
        While sqldr.Read
            rw = ds2.Tables("_brg2").NewRow
            'Dim rw As DataRow = dSO1.Tables("_bkid").NewRow
            ji = sqldr.Item(0)
            ro = sqldr.Item(1)
            lu = sqldr.Item(2)
            pat = sqldr.Item(3)
            mo = sqldr.Item(4)
            nem = sqldr.Item(5)
            tu = sqldr.Item(6)
            wolu = sqldr.Item(7)
            rw.Item("kd_barang") = ji & ro & lu & pat & mo & nem & tu & wolu
            ds2.Tables("_brg2").Rows.Add(rw)

        End While
        sqldr.Close()

        'ds.Merge(ds2.Tables("_brg2"))
        For i As Int32 = 0 To ds.Tables("_brg").Rows.Count - 1
            ds.Tables("_brg").Rows(i).Item("kd_barang") = ds2.Tables("_brg2").Rows(i).Item("kd_barang")
        Next


        'For Each rwa As DataRow In ds.Tables("_brg").Rows
        '    rwa.Item("kd_barang") = rw.Item("kd_barang")
        'Next


    End Sub

    Private Sub frmGenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.temp_barang", sqlconn))
        DA.Fill(ds, "_brg")
        GcGen_Brg.DataSource = ds.Tables("_brg")

        DA2 = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.temp_barang2 where 1=0", sqlconn))
        DA2.Fill(ds2, "_brg2")


    End Sub
End Class