Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Public Class frmMonRphReal
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim dsMon, dsMon1, dsNoTrans, dsmon2, dsNoRPH As New DataSet
    Dim daMon, daMon1, daNoTrans, daNoRPH As SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Sub reload_table()
        Dim sql As String = ""
        Dim kolom As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " and tgl < convert(date, '" & tglsampai.EditValue & "', 103)"
            End If
        Else
            If tglsampai.Text <> "" Then
                sql = " and tgl between convert(date, '" & tglDari.EditValue & "', 103) and  convert(date, '" & tglsampai.EditValue & "', 103)"
            Else
                sql = " and tgl  > convert(date, '" & tglDari.EditValue & "', 103)"
            End If
        End If
        If Not dsete.Tables("sp") Is Nothing Then dsete.Tables("sp").Clear()

        For Each itm As CheckedListBoxItem In cmdGroup.Properties.Items
            GV.Columns(itm.Value).visible = False
            GV.Columns(itm.Value).UnGroup()
            If itm.CheckState = CheckState.Checked Then
                kolom &= "[" & itm.Value & "],"
                GV.Columns(itm.Value).visible = True
            End If
        Next
        If kolom = "" Then
            'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select Nama_Barang, sum(Qty*(harga-potongan)) Total, Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln from sales.dbo.vsod_rep as s where ISNULL(s.[set],0)=0 " & sql & " group by Nama_Barang,  Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln ", sqlconn))
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  no_rph, nama_barang, jumlah, sum(jumlah_kerja) jumlah_kerja, sum(jumlah_rework) jumlah_rework, sum(jumlah_delay) jumlah_delay, jumlah - sum(jumlah_kerja) selisih from prod.dbo.PRODV_MON_PROD_RPH as s where s.kd_departemen= " & lueDep.EditValue & sql & " group by no_rph, nama_barang, jumlah ", sqlconn))
            dadbe.Fill(dsete, "sp")
            GC.DataSource = dsete.Tables("sp")
        Else
            kolom = kolom.Substring(0, Len(kolom) - 1)
            'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select Nama_Barang, sum(Qty*(harga-potongan)) Total, Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln from sales.dbo.vsod_rep as s where ISNULL(s.[set],0)=0 " & sql & " group by Nama_Barang,  Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln ", sqlconn))
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  no_rph, nama_barang, jumlah, sum(jumlah_kerja) jumlah_kerja, sum(jumlah_rework) jumlah_rework, sum(jumlah_delay) jumlah_delay, jumlah - sum(jumlah_kerja) selisih, " & kolom & " from prod.dbo.PRODV_MON_PROD_RPH as s where s.kd_departemen= " & lueDep.EditValue & sql & " group by no_rph, nama_barang, jumlah, " & kolom, sqlconn))
            dadbe.Fill(dsete, "sp")
            GC.DataSource = dsete.Tables("sp")
        End If
    End Sub
    Private Sub frmMonSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        LoadLUE()
        'reload_table()
        GC.DataSource = dsete.Tables("sp")

        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Private Sub LoadLUE()
        If kddep = "2" Then
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen where Kd_Departemen='2'  "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
            Dim row As DataRow
            row = dsmon2.Tables("dep").Rows(0)
            lueDep.EditValue = row.Item("Kd_Departemen").ToString
            lueDep.Properties.ReadOnly = True
            'LoadGrid()
        ElseIf kddep = "3" Then
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen where Kd_Departemen='3'  "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
            Dim row As DataRow
            row = dsmon2.Tables("dep").Rows(0)
            lueDep.EditValue = row.Item("Kd_Departemen").ToString
            lueDep.Properties.ReadOnly = True

            'LoadGrid()
        Else
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
        End If

    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reload_table()
    End Sub

    Public Sub add_click()

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

        '  ps.PageSetup()


        link.Component = xGc
        link.Landscape = True
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 55
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.PrintingSystem.Document.AutoFitToPagesWidth = 0
        link.PrintingSystem.Document.ScaleFactor = 0.95F
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        'GV.Columns("no_spk").Visible = False
        'GV.Columns("tgl").Visible = False
        'GV.Columns("no_spk_man_rls").Visible = False
        'GV.Columns("kegiatan").Visible = False
        'GV.Columns("kegiatan_spk").Visible = False
        'GV.Columns("Nama_Pegawai").Visible = False
        'GV.Columns("group_kerja").Visible = False
        'GV.Columns("nama_mesin").Visible = False

        'GV.Columns("Merk_Kain").Visible = False
        'GV.Columns("Nama_Ukuran").Visible = False
        'GV.Columns("Nama_Sub_Tipe").Visible = False
        'GV.Columns("Nama_Tipe").Visible = False
        'GV.Columns("Nama_Merk").Visible = False
        'GV.Columns("Nama_Jenis").Visible = False
        'print_gc1(GC, "                                                                                                         Laporan RPH vs Realisasi  " & vbCrLf & _
        '              "                                 Per-" & cmdGroup.Text & vbCrLf & "                                                                                                 Periode " & tglDari.Text & " - " & tglsampai.Text)

        ''print_gc1(GC, "Laporan RPH vs Realisasi Terlambat " & vbCrLf & "Per-" & cmdGroup.Text & vbCrLf & "Periode " & tglDari.Text & " - " & tglsampai.Text)
        'GV.Columns("no_spk").Visible = True
        'GV.Columns("tgl").Visible = True
        'GV.Columns("no_spk_man_rls").Visible = True
        'GV.Columns("kegiatan").Visible = True
        'GV.Columns("kegiatan_spk").Visible = True
        'GV.Columns("Nama_Pegawai").Visible = True
        'GV.Columns("group_kerja").Visible = True
        'GV.Columns("nama_mesin").Visible = True

        'GV.Columns("Merk_Kain").Visible = True
        'GV.Columns("Nama_Ukuran").Visible = True
        'GV.Columns("Nama_Sub_Tipe").Visible = True
        'GV.Columns("Nama_Tipe").Visible = True
        'GV.Columns("Nama_Merk").Visible = True
        'GV.Columns("Nama_Jenis").Visible = True
        ''print_gc1(GC, "Laporan Pemenuhan RPH " & vbCrLf & "Per-" & cmdGroup.Text & vbCrLf & "Periode " & tglDari.Text & " - " & tglsampai.Text)

        print_gc(GC, "Laporan RPH vs Realisasi " & vbCrLf & "Per-" & cmdGroup.Text & vbCrLf & "Periode " & tglDari.Text & " - " & tglsampai.Text)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        For Each itm As CheckedListBoxItem In cmdGroup.Properties.Items
            'GV.Columns(itm.Value).visible = False
            'GV.Columns(itm.Value).UnGroup()
            'If 
            itm.CheckState = CheckState.Unchecked
            'kolom &= "[" & itm.Value & "],"
            'GV.Columns(itm.Value).visible = True
            ' End If
        Next

        tglDari.Text = ""
        tglsampai.Text = ""
        'cbo_status_realisasi.Text = ""
        GC.DataSource = Nothing
    End Sub

End Class