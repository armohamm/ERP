Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonUtangUsaha
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim saldoawal As String
    Dim saldohari As String
    Dim saldoakhir1 As String
    Dim saldoakhir2 As String

    Dim dsValuta, dsRek, dsGrid, dsSal, dsRekap, dsDetUt As New DataSet
    Dim daValuta, daJurnalD, daRek, daGrid, daSal, daRekap  , daDetUt As SqlDataAdapter

   
    Private Sub frmMonUtangUsaha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        LoadGrid1()
        LoadGrid2()
        Me.Enabled = True
        GVlvl1.BestFitColumns()
        GVlvl2.BestFitColumns()
        GVlvl3.BestFitColumns()
    End Sub

    Sub LoadGrid1()
        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
        'a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'
        'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.FIN_JURNAL B , SIF.dbo.SIF_Supplier C
        'where a.kd_supplier = c.Kode_Supplier
        'and a.no_jurnal = b.no_jur 
        'and a.tipe_trans like 'JPP%'
        'and b.no_posting is not null
        'group by a.kd_supplier  , c.Nama_Supplier

        daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total' from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.FIN_JURNAL B , SIF.dbo.SIF_Supplier C where(a.kd_supplier = c.Kode_Supplier) and a.no_jurnal = b.no_jur and a.tipe_trans like 'JPP%' and b.no_posting is not null group by a.kd_supplier  , c.Nama_Supplier", sqlconn))
        daRekap.Fill(dsRekap, "_rekap")
        GClvl1.DataSource = dsRekap.Tables("_rekap")
        GVlvl1.BestFitColumns()
    End Sub

    Sub LoadGrid2()
        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
        'a.kd_supplier,a.no_inv,a.no_jurnal,c.Nama_Supplier,a.kd_buku_besar,d.nm_buku_besar,a.jml_akhir,a.keterangan
        'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.FIN_JURNAL B , SIF.dbo.SIF_Supplier C , SIF.dbo.SIF_buku_besar D
        'where a.kd_supplier = c.Kode_Supplier
        'and a.no_jurnal = b.no_jur 
        'and a.kd_buku_besar = d.kd_buku_besar
        'and a.tipe_trans like 'JPP%'
        'and b.no_posting is not null

        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', *
        'from FIN.dbo.FIN_PEMBELIAN
        'where 
        'tipe_trans like 'JPP%'


        daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', * from FIN.dbo.FIN_PEMBELIAN where tipe_trans like 'JPP%' ", sqlconn))
        daDetUt.Fill(dsDetUt, "_DetUt")
        GClvl2.DataSource = dsDetUt.Tables("_DetUt")
        GVlvl2.BestFitColumns()
    End Sub

    Sub LoadGrid3()

    End Sub

End Class