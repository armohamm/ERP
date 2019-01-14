Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmCetakLembarOpname
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True

    Private Sub frmCetakLembarOpname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        dadbe = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd, Nama_Persediaan from sif_jns_persediaan WHERE isnull(rec_stat,'') = 'Y' union select '','' ", sqlconn))
        dadbe.Fill(dsete, "persediaan")
        cmdJnsPers.Properties.DataSource = dsete.Tables("persediaan")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang, Nama_Gudang from sif.dbo.SIF_Gudang union select '','' ", sqlconn))
        dadbe.Fill(dsete, "Gudang")

        cmdKdGud.Properties.DataSource = dsete.Tables("Gudang")

        prn = frmMain
        Me.Enabled = True
        setStatus()
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With

    End Sub

    Public Sub add_click()

    End Sub

    Public Sub cetak_click()
        'print_gc(gc, "Draf Opname", False)

        If Not gv.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        'Dim reportHeader As String = "DRAFT OPNAME"

        'e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        'e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        'e.Graph.BackColor = Color.White
        'Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 100)
        'e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.All)
        Dim subReport1 As String = "Jenis Persediaan"
        Dim subReport2 As String = "Jenis Barang"
        Dim subReport3 As String = ":"
        Dim subReport4 As String = cmdJnsPers.Text
        Dim subReport5 As String = cmdJnsBrg.Text
        Dim subReport6 As String = "SEMUA JENIS PERSEDIAAN"
        Dim subReport7 As String = "SEMUA JENIS BARANG"

        Dim subReport8 As String = "Gudang"
        Dim subReport9 As String = cmdKdGud.Text
        Dim subReport10 As String = "SEMUA GUDANG"

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Regular)
        e.Graph.BackColor = Color.White

        Dim rec As RectangleF = New RectangleF(0, 25, CSng(e.Graph.MeasureString(subReport1).Width) + 2, 20)
        Dim rec1 As RectangleF = New RectangleF(120, 25, CSng(e.Graph.MeasureString(subReport3).Width) + 2, 20)
        Dim rec2 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 25, CSng(e.Graph.MeasureString(subReport4).Width) + 2, 20)

        Dim rec3 As RectangleF = New RectangleF(0, 45, CSng(e.Graph.MeasureString(subReport2).Width) + 2, 25)
        Dim rec4 As RectangleF = New RectangleF(120, 45, CSng(e.Graph.MeasureString(subReport3).Width) + 2, 25)
        Dim rec5 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 45, CSng(e.Graph.MeasureString(subReport5).Width) + 2, 25)

        Dim rec8 As RectangleF = New RectangleF(0, 65, CSng(e.Graph.MeasureString(subReport8).Width) + 2, 30)
        Dim rec9 As RectangleF = New RectangleF(120, 65, CSng(e.Graph.MeasureString(subReport3).Width) + 2, 30)
        Dim rec10 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 65, CSng(e.Graph.MeasureString(subReport9).Width) + 2, 30)


        Dim rec6 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 25, CSng(e.Graph.MeasureString(subReport6).Width) + 2, 20)
        Dim rec7 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 45, CSng(e.Graph.MeasureString(subReport7).Width) + 2, 25)
        Dim rec11 As RectangleF = New RectangleF(120 + CSng(e.Graph.MeasureString(subReport3).Width) + 2, 65, CSng(e.Graph.MeasureString(subReport10).Width) + 2, 30)


        e.Graph.DrawString(subReport1, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(subReport3, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        If Not cmdJnsPers.EditValue = vbNullString Then
            e.Graph.DrawString(subReport4, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        Else
            e.Graph.DrawString(subReport6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        End If

        e.Graph.DrawString(subReport2, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(subReport3, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        If Not cmdJnsBrg.EditValue = vbNullString Then
            e.Graph.DrawString(subReport5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
        Else
            e.Graph.DrawString(subReport7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.None)
        End If

        e.Graph.DrawString(subReport8, Color.Black, rec8, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(subReport3, Color.Black, rec9, DevExpress.XtraPrinting.BorderSide.None)
        If Not cmdKdGud.EditValue = vbNullString Then
            e.Graph.DrawString(subReport9, Color.Black, rec10, DevExpress.XtraPrinting.BorderSide.None)
        Else
            e.Graph.DrawString(subReport10, Color.Black, rec11, DevExpress.XtraPrinting.BorderSide.None)
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim sql As String
        If cmdJnsPers.Text <> "" Then
            sql = " and a.kd_jns_persd = '" & cmdJnsPers.EditValue & "'"
            'Dim ftr As String = " kd_jns_persd = '" & cmdJnsPers.EditValue & "'"
            'gv.Columns(JnsPersd.FieldName).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)

        End If
        If cmdJnsBrg.Text <> "" Then
            sql &= sql + " and a.kd_jenis = '" & cmdJnsBrg.EditValue & "'"
            'Dim ftr As String = " kd_jenis = '" & cmdJnsBrg.EditValue & "'"
            'gv.Columns(Jenis.FieldName).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, ftr)

        End If

        If cmdKdGud.Text <> "" Then
            If Not dsete.Tables("saldo") Is Nothing Then dsete.Tables("saldo").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Kd_Depart, g.Nama_Departemen, a.Kode_Barang, a.Nama_Barang, a.kd_jns_persd, b.Nama_Persediaan, " & _
                                                                       "a.kd_jenis, c.Nama_Jenis, a.lokasi, d.Nama_Gudang, a.Kd_Satuan, e.Nama_Satuan, " & _
                                                                          "isnull(a.tinggi,0) tinggi, isnull(a.panjang,0) panjang, isnull(a.lebar,0) lebar, isnull(f.akhir_qty,0) saldo " & _
                                                                          "from sif.dbo.sif_barang a " & _
                                                                          "inner join sif.dbo.SIF_Jns_Persediaan b on a.kd_jns_persd = b.Kd_Jns_Persd " & _
                                                                          "inner join sif.dbo.SIF_Jenis_Barang c on a.kd_jenis = c.Kd_Jns_Brg " & _
                                                                          "inner join sif.dbo.SIF_Gudang d on a.lokasi = d.Kode_Gudang " & _
                                                                          "inner join sif.dbo.SIF_Satuan e on a.Kd_Satuan = e.Kode_Satuan " & _
                                                                          "left outer join inv.dbo.INV_STOK_GUDANG f on a.Kode_Barang = f.kd_stok and a.Kd_Satuan = f.kd_satuan and f.bultah = convert(char(6), getdate(), 112) and f.kode_gudang = '" & cmdKdGud.EditValue & "'" & _
                                                                          "inner join sif.dbo.SIF_Departemen g on a.Kd_Depart = g.Kd_Departemen " & _
                                                                          "where a.Rec_Stat = 'Y' " & sql & _
                                                                          "order by a.Nama_Barang", sqlconn))
            'dadbe = New SqlDataAdapter(New SqlCommand("select  (select Kd_Depart from sif.dbo.sif_barang where kode_barang=kd_stok) Kd_Depart,  kd_satuan, kd_stok, tinggi, lebar, panjang,akhir_qty_onstok from inv.dbo.inv_stok_saldo where bultah=convert(char(6), getdate(), 112) " & _
            dadbe.Fill(dsete, "saldo")
            gc.DataSource = dsete.Tables("saldo")
            gv.BestFitColumns()
        Else
            If Not dsete.Tables("saldo") Is Nothing Then dsete.Tables("saldo").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Kd_Depart, g.Nama_Departemen, a.Kode_Barang, a.Nama_Barang, a.kd_jns_persd, b.Nama_Persediaan, " & _
                                                                       "a.kd_jenis, c.Nama_Jenis, a.lokasi, d.Nama_Gudang, a.Kd_Satuan, e.Nama_Satuan, " & _
                                                                          "isnull(a.tinggi,0) tinggi, isnull(a.panjang,0) panjang, isnull(a.lebar,0) lebar, isnull(f.akhir_qty_onstok,0) saldo " & _
                                                                          "from sif.dbo.sif_barang a " & _
                                                                          "inner join sif.dbo.SIF_Jns_Persediaan b on a.kd_jns_persd = b.Kd_Jns_Persd " & _
                                                                          "inner join sif.dbo.SIF_Jenis_Barang c on a.kd_jenis = c.Kd_Jns_Brg " & _
                                                                          "inner join sif.dbo.SIF_Gudang d on a.lokasi = d.Kode_Gudang " & _
                                                                          "inner join sif.dbo.SIF_Satuan e on a.Kd_Satuan = e.Kode_Satuan " & _
                                                                          "left outer join inv.dbo.INV_STOK_SALDO f on a.Kode_Barang = f.kd_stok and a.Kd_Satuan = f.kd_satuan and f.bultah = convert(char(6), getdate(), 112) " & _
                                                                          "inner join sif.dbo.SIF_Departemen g on a.Kd_Depart = g.Kd_Departemen " & _
                                                                          "where a.Rec_Stat = 'Y' " & sql & _
                                                                          "order by a.Nama_Barang", sqlconn))
            'dadbe = New SqlDataAdapter(New SqlCommand("select  (select Kd_Depart from sif.dbo.sif_barang where kode_barang=kd_stok) Kd_Depart,  kd_satuan, kd_stok, tinggi, lebar, panjang,akhir_qty_onstok from inv.dbo.inv_stok_saldo where bultah=convert(char(6), getdate(), 112) " & _
            dadbe.Fill(dsete, "saldo")
            gc.DataSource = dsete.Tables("saldo")
            gv.BestFitColumns()
        End If

        'dsete.Tables("saldo").Clear()
        'dadbe = New SqlDataAdapter(New SqlCommand("select  (select Kd_Depart from sif.dbo.sif_barang where kode_barang=kd_stok) Kd_Depart,  kd_satuan, kd_stok, tinggi, lebar, panjang,akhir_qty_onstok from inv.dbo.inv_stok_saldo where bultah=convert(char(6), getdate(), 112) " & _
        '" and exists (select 1 from sif.dbo.sif_barang WHERE kd_stok=kode_barang and isnull(rec_stat,'') = 'Y' " & sql & _
        '" and not exists (select 1 from sif.dbo.sif_ukuran where kd_ukuran=kode_ukuran and ALIAS='KHS')  ) ", sqlconn))
        'dadbe.Fill(dsete, "saldo")
    End Sub

    Private Sub cmdJnsBrg_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmdJnsBrg.QueryPopUp
        If Not dsete.Tables("jenis") Is Nothing Then dsete.Tables("jenis").Clear()
        dadbe = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis  from sif_jenis_barang WHERE isnull(rec_stat,'') = 'Y' and kd_jns_persd='" & cmdJnsPers.EditValue & "' union select '','' ", sqlconn))
        dadbe.Fill(dsete, "jenis")
        cmdJnsBrg.Properties.DataSource = dsete.Tables("jenis")
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        gv.ClearColumnsFilter()
        cmdJnsBrg.EditValue = vbNullString
        cmdJnsPers.EditValue = vbNullString
        cmdKdGud.EditValue = vbNullString
        If Not dsete.Tables("saldo") Is Nothing Then dsete.Tables("saldo").Clear()

    End Sub

End Class