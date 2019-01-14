Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Public Class frmDtlSO3
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, da9 As New SqlDataAdapter
    Public jml_barang As Integer
    Public kd_bom, notrans_simulasi As String

    Private Sub frmDtlSO3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not ds1.Tables("Barangdet") Is Nothing Then ds1.Tables("Barangdet").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select d.kd_brg,d.jumlah ,b.nama_barang , p.Nama_Persediaan,b.Kd_Satuan as satuan, " & _
                                                                    "ISNULL(d.jumlah_stok,0) jml_available, ISNULL(d.jumlah_stok_gudang,0) jml_gudang , (ISNULL(d.jumlah_stok_gudang,0) - ISNULL(d.jumlah,0) ) as sisa_stok,  d.keterangan " & _
                                                                    "from Prod.dbo.PROD_simul_bhn_d_temp d " & _
                                                                    "inner join SIF.dbo.SIF_Barang b " & _
                                                                    "on  b.Kode_Barang = d.kd_brg " & _
                                                                    "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                    "on p.Kd_Jns_Persd = b.kd_jns_persd " & _
                                                                    "where d.no_trans ='" & notrans_simulasi & "'", sqlconn))
        '"LEFT outer join PROD.dbo.PRODV_MON_STOCK S " & _
        '"on S.kd_stok = d.kd_brg " & _
        
        da3.Fill(ds1, "Barangdet")



        GC_DetilBOM.DataSource = ds1.Tables("Barangdet")
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim qstr As String
        Dim dr As SqlDataReader
        qstr = "delete from Prod.dbo.PROD_simul_bhn_m_temp_mstr "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

        qstr = "delete from Prod.dbo.PROD_simul_bhn_m_temp "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

        qstr = "delete from Prod.dbo.PROD_simul_bhn_d_temp "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()
        Me.Close()
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'GV.ExpandMasterRow(0, "Detail")
        'GV2.Columns("rec_stat").Visible = False
        'GV2.Columns("no_urut").Visible = False
        'GV2.Columns("satuan").AppearanceCell.BackColor = Color.White
        print_gc1(GC_DetilBOM, "                                                                                   Kebutuhan Bahan    ")

    End Sub
End Class