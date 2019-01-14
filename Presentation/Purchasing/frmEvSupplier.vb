Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmEvSupplier
    Dim dsete, ds As New DataSet
    Dim dadbe, da As SqlDataAdapter
    Dim max_col As Int16
    Dim m As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Dim gb As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Dim target As Double = 1000000
    Dim prn As frmMain
    Public STATE As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim no_trans As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub V_Supplier()
        If Not dsete.Tables("View_Supplier") Is Nothing Then dsete.Tables("View_Supplier").Clear()
        If Not dsete.Tables("View_Barang") Is Nothing Then dsete.Tables("View_Barang").Clear()
        If Not dsete.Tables("View_Periode") Is Nothing Then dsete.Tables("View_Periode").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        dadbe.Fill(dsete, "View_Supplier")
        txtSupplier.Properties.DataSource = dsete.Tables("View_Supplier")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from sif.dbo.SIF_Barang", sqlconn))
        dadbe.Fill(dsete, "View_Barang")
        RepositoryItemLookUpEdit1.DataSource = dsete.Tables("View_Barang")
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
        RepositoryItemLookUpEdit1.ValueMember = "Kode_Barang"

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select thn_buku+bln_buku AS periode ,nama_bulan+' '+thn_buku AS nama from sif.dbo.SIF_Periode_Buku", sqlconn))
        dadbe.Fill(dsete, "View_Periode")
        lckPeriodeAwal.Properties.DataSource = dsete.Tables("View_Periode")
        lckPeriodeAwal.Properties.DisplayMember = "nama"
        lckPeriodeAwal.Properties.ValueMember = "periode"
        lckPeriodeAkhir.Properties.DataSource = dsete.Tables("View_Periode")
        lckPeriodeAkhir.Properties.DisplayMember = "nama"
        lckPeriodeAkhir.Properties.ValueMember = "periode"

    End Sub

    Private Sub rekomensupp()

        Dim dr1 As SqlDataReader = New SqlCommand("  Select COUNT(b.no_trans) jumlah_kurang from (Select top 3 a.* from  ( Select ISNULL(e.no_trans,'') no_trans,e.periode1, e.periode2,e.periode, e.kd_supplier,s.Nama_Supplier " & _
                                                  ",sum(e.total) /  COUNT(e.periode) as nilai " & _
                                                  "From PURC.dbo.PURC_EVALUASI_SUPPLIER e " & _
                                                  "left join SIF.dbo.SIF_Supplier s " & _
                                                  "on s.Kode_Supplier = e.kd_supplier " & _
                                                  "where e.kd_supplier = '" & txtSupplier.EditValue & "' " & _
                                                  "GROUP BY ISNULL(e.no_trans,''),e.periode1, e.periode2,e.periode, e.kd_supplier,s.Nama_Supplier " & _
                                                  "having e.periode1 =max(e.periode1) ) a " & _
                                                  "ORDER BY  a.no_trans DESC) b " & _
                                                  "where b.nilai < 60 ", sqlconn).ExecuteReader
        dr1.Read()
        If dr1.HasRows Then
            lblRekomendasi.Text = "Supplier " & txtSupplier.Text & " : "
            If dr1.Item("jumlah_kurang") = 3 Then
                lblHasil.ForeColor = Color.Red
                lblHasil.Text = "TIDAK DIREKOMENDASIKAN"
                lbl_unapprove.Visible = True
                btn_unapprove.Visible = True

                lbl_approve.Visible = False
                btn_approve.Visible = False
            Else
                lblHasil.ForeColor = Color.Green
                lblHasil.Text = "DIREKOMENDASIKAN"
                lbl_approve.Visible = True
                btn_approve.Visible = True

                lbl_unapprove.Visible = False
                btn_unapprove.Visible = False
            End If
        End If
        dr1.Close()

        
    End Sub

    Private Sub refreshNomer()
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        ' If State = "DELETE" Then Exit Sub
        For Each rwd As DataRow In ds.Tables("EVSX").Rows
            rwd("No_seq") = i
            i += 1
        Next
    End Sub

    Dim persen, persen1, persen2 As Double
    Dim ss, ts, ss1, ts1 As Integer

    Private Sub reload_table()                   'ByVal periode As String
        'If Not ds.Tables("EVS") Is Nothing Then ds.Tables("EVS").Clear()
        If Not ds.Tables("EVSX") Is Nothing Then ds.Tables("EVSX").Clear()

        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as no_seq ,'' as st1,'' as nilai_2 ,'' as st3,'' as st4,'' as stqa,'' as ovast from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "' ", sqlconn))
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,( qty - qty * 0.1)qtymin, '' as nilai_2 from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "'and periode = '" & txtTahun.Text & "'", sqlconn))
        'da.Fill(ds, "EVS")
        'GcEvSupplier.DataSource = ds.Tables("EVS")
        'AddHandler ds.Tables("EVS").RowDeleted, AddressOf refreshNomer

        If CInt(lckPeriodeAwal.EditValue) > CInt(lckPeriodeAkhir.EditValue) Then
            MsgBox("Tolong pemilihan periode dimulai dari bulan dan tahun terkecil ke besar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If

        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode BETWEEN " & CInt(lckPeriodeAwal.EditValue) & " AND " & CInt(lckPeriodeAkhir.EditValue) & " ORDER BY no_po", sqlconn))
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode1 = '" & lckPeriodeAwal.EditValue & "' AND periode2 = '" & lckPeriodeAkhir.EditValue & "' ORDER BY no_po", sqlconn))
        da.Fill(ds, "EVSX")
        GcEvSupplier.DataSource = ds.Tables("EVSX")

        Dim dr1 As SqlDataReader = New SqlCommand("SELECT Distinct no_trans FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode1 = '" & lckPeriodeAwal.EditValue & "' AND periode2 = '" & lckPeriodeAkhir.EditValue & "' ", sqlconn).ExecuteReader
        dr1.Read()
        If dr1.HasRows Then
            no_trans = dr1.Item("no_trans")
        Else
            no_trans = getNoTrans("EVSUPP", getTanggal)
        End If
        dr1.Close()

        If ds.Tables("EVSX").Rows.Count > 0 Then
            If MsgBox("Supplier " & txtSupplier.Text & " untuk periode " & lckPeriodeAwal.Text & " s/d " & lckPeriodeAkhir.Text & " sudah ada dalam tabel. Kalkulasi ulang jurnal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KALKULASI ULANG?") = MsgBoxResult.Yes Then
                call_procedure(no_trans, txtSupplier.EditValue, lckPeriodeAwal.EditValue, lckPeriodeAkhir.EditValue)

                If Not ds.Tables("EVSX") Is Nothing Then ds.Tables("EVSX").Clear()
                'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode BETWEEN " & CInt(lckPeriodeAwal.EditValue) & " AND " & CInt(lckPeriodeAkhir.EditValue) & " ORDER BY no_po", sqlconn))
                da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode1 = '" & lckPeriodeAwal.EditValue & "' AND periode2 = '" & lckPeriodeAkhir.EditValue & "' ORDER BY no_po", sqlconn))
                da.Fill(ds, "EVSX")
                GcEvSupplier.DataSource = ds.Tables("EVSX")
            End If
        Else
            call_procedure(no_trans, txtSupplier.EditValue, lckPeriodeAwal.EditValue, lckPeriodeAkhir.EditValue)
            If Not ds.Tables("EVSX") Is Nothing Then ds.Tables("EVSX").Clear()
            'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode BETWEEN " & CInt(lckPeriodeAwal.EditValue) & " AND " & CInt(lckPeriodeAkhir.EditValue) & " ORDER BY no_po", sqlconn))
            da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT '' AS no_seq, * FROM PURC.dbo.PURC_EVALUASI_SUPPLIER WHERE kd_supplier='" & txtSupplier.EditValue & "' AND periode1 = '" & lckPeriodeAwal.EditValue & "' AND periode2 = '" & lckPeriodeAkhir.EditValue & "' ORDER BY no_po", sqlconn))
            da.Fill(ds, "EVSX")
            GcEvSupplier.DataSource = ds.Tables("EVSX")
        End If

        Try
            'Dim dr As SqlDataReader = New SqlCommand("SELECT count(dayact) sesuai from PURC.dbo.v_ev_supplier where dayact < 5 and dayact >= 0 and kd_supplier='" & txtSupplier.EditValue & "'", sqlconn).ExecuteReader
            'dr.Read()
            'If dr.HasRows Then
            '    txtjmlkdss.Text = dr.Item(0)
            'End If
            'dr.Close()

            'Dim dr1 As SqlDataReader = New SqlCommand("SELECT count(dayact) tidak_sesuai from PURC.dbo.v_ev_supplier where dayact < 0  and kd_supplier='" & txtSupplier.EditValue & "' or dayact > 5 and kd_supplier='" & txtSupplier.EditValue & "' ", sqlconn).ExecuteReader
            'dr1.Read()
            'If dr1.HasRows Then
            '    txtjmlkdts.Text = dr1.Item(0)
            'End If
            'dr1.Close()

            'ss = txtjmlkdss.Text
            'ts = txtjmlkdts.Text
            'persen = (100 / (ss + ts))
            ''txtjmlqlss.Text = persen
            'txtjmlkdre.Text = (100 - (ts * persen))


            'Dim dr2 As SqlDataReader = New SqlCommand("SELECT sum(qty) jumlah_sesuai from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "'", sqlconn).ExecuteReader
            'dr2.Read()
            'If dr2.HasRows Then
            '    txtjmlqtss.Text = dr2.Item(0)
            'End If
            'dr2.Close()

            'Dim dr3 As SqlDataReader = New SqlCommand("SELECT sum(qty_kirim) Jumlah_TidakSesuai from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "'", sqlconn).ExecuteReader
            'dr3.Read()
            'If dr3.HasRows Then
            '    txtjmlqts.Text = dr3.Item(0) - txtjmlqtss.Text
            'End If
            'dr3.Close()

            'persen1 = 100 / (txtjmlqtss.Text)
            'txtjmlqtre.Text = 100 - (txtjmlqts.Text * persen1)

            '------- PARAMETER QUANTITY
            'Dim dr4 As SqlDataReader = New SqlCommand("select *,( qty - qty * 0.1)qtymin from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "'", sqlconn).ExecuteReader
            'Dim n As Integer = 0
            'While dr4.Read()
            '    n += 1
            '    Dim rw As DataRow = ds.Tables("EVS").Rows(dr4.HasRows + n)

            '    'If dr4.HasRows Then
            '    If dr4.Item(9) < dr4.Item(8) Then
            '        If dr4.Item(9) < dr4.Item(13) Then
            '            rw.Item("nilai_2") = 0 '"Tidak Sesuai" 
            '            'ds.Tables("EVS").Rows.Add(rw)
            '            'MsgBox("Tidak Sesuai Qty Min" & dr4.Item(9) & "<" & dr4.Item(13), MsgBoxStyle.Information, "Information")
            '        ElseIf dr4.Item(9) >= dr4.Item(13) Then
            '            rw.Item("nilai_2") = 25 '"Sesuai"
            '            'ds.Tables("EVS").Rows.Add(1)
            '            'MsgBox("Sesuai Qty Min" & dr4.Item(9) & ">" & dr4.Item(13), MsgBoxStyle.Information, "Information")
            '        End If

            '    End If
            '    If dr4.Item(9) >= dr4.Item(8) Then
            '        If dr4.Item(9) > dr4.Item(10) Then
            '            rw.Item("nilai_2") = 0 '"Tidak Sesuai"
            '            'ds.Tables("EVS").Rows.Add(2)
            '            'MsgBox("Tidak Sesuai Qty Max" & dr4.Item(9) & ">" & dr4.Item(10), MsgBoxStyle.Information, "Information")
            '        ElseIf dr4.Item(9) <= dr4.Item(10) Then
            '            rw.Item("nilai_2") = 25 '"Sesuai"
            '            'ds.Tables("EVS").Rows.Add(3)
            '            'MsgBox("SesuaiQty Max" & dr4.Item(9) & "<" & dr4.Item(10), MsgBoxStyle.Information, "Information")
            '        End If
            '    End If
            '    'End If
            'End While

            'Dim dr5 As SqlDataReader = New SqlCommand("SELECT count(dayact) sesuai from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "'", sqlconn).ExecuteReader
            'dr5.Read()
            'If dr5.HasRows Then
            '    txtjmlPO.Text = dr5.Item(0)
            'End If
            'dr5.Close()
        Catch ex As Exception
            MsgBox("Data tidak ditemukan, Pilih Supplier Dulu", MsgBoxStyle.Information, "Informasi")
        End Try

        refreshNomer()
        rekomensupp()

        'persen = 100 / (txtjmlkdss.Text + txtjmlkdts.Text)
        'txtjmlkdre.Text = 100 - (txtjmlkdts.Text * persen)
    End Sub

    Public Sub call_procedure(ByVal notrans As String, ByVal supplier As String, ByVal periode1 As String, ByVal periode2 As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PURC.dbo.proses_eval_supplier"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans
        sqlCmd.Parameters.Add("@vkd_supplier", SqlDbType.Char).Value = supplier
        sqlCmd.Parameters.Add("@periode1", SqlDbType.Char).Value = periode1
        sqlCmd.Parameters.Add("@periode2", SqlDbType.Char).Value = periode2
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        'setStatus()
        STATE = "ADD" '<-- set state add

    End Sub



    Private Sub frmEvSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'If Not ds.Tables("EVS") Is Nothing Then ds.Tables("EVS").Clear()

        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as no_seq ,'' as st1,'' as nilai_2 ,'' as st3,'' as st4,'' as stqa,'' as ovast from PURC.dbo.v_ev_supplier where 1=0 ", sqlconn))
        'da.Fill(ds, "EVS")
        'GcEvSupplier.DataSource = ds.Tables("EVS")
        'AddHandler ds.Tables("EVS").RowDeleted, AddressOf refreshNomer


        V_Supplier()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        If Not ds.Tables("SParam") Is Nothing Then ds.Tables("SParam").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as no_seq ,'' as st1,'' as nilai_2 ,'' as st3,'' as st4,'' as stqa,'' as ovast from PURC.dbo.v_ev_supplier where 1=0 ", sqlconn))
        da.Fill(ds, "EVS")
        'reload_table()

    End Sub

    Private Sub txtSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplier.EditValueChanged
        'If txtSupplier.Text = "" Then
        '    If Not ds.Tables("EVS") Is Nothing Then ds.Tables("EVS").Clear()
        '    Exit Sub                                                                                                                                                                                                'and periode='" & txtTahun.Text & "'             ' 
        'End If
        'Dim dr As SqlDataReader = New SqlCommand("select *  ,'' as no_seq,'' as st1,'' as nilai_2 ,'' as st3,'' as st4,'' as stqa,'' as ovast from PURC.dbo.v_ev_supplier where kd_supplier='" & txtSupplier.EditValue & "' ", sqlconn).ExecuteReader
        'Dim i As Int16 = 1
        'While dr.Read

        '    Dim rw As DataRow = ds.Tables("EVS").NewRow
        '    rw.Item("no_po") = dr.Item("no_po")
        '    rw.Item("nama_barang") = dr.Item("nama_barang")
        '    rw.Item("tgl_kirim") = dr.Item("tgl_kirim")
        '    rw.Item("tgl_kirim_act") = dr.Item("tgl_kirim_act")
        '    rw.Item("st1") = dr.Item("st1")
        '    rw.Item("qty") = dr.Item("qty")
        '    rw.Item("qty_kirim") = dr.Item("qty_kirim")
        '    rw.Item("nilai_2") = dr.Item("nilai_2")
        '    rw.Item("stqa") = dr.Item("stqa")
        '    rw.Item("st3") = dr.Item("st3")
        '    rw.Item("tgl_bayar") = dr.Item("tgl_bayar")
        '    rw.Item("term_bayar") = dr.Item("term_bayar")
        '    rw.Item("st4") = dr.Item("st4")
        '    rw.Item("ovast") = dr.Item("ovast")
        '    rw.Item("no_seq") = i
        '    i += 1
        '    ds.Tables("EVS").Rows.Add(rw)
        'End While
        'dr.Close()


    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        reload_table()
    End Sub

    Public Sub cetak_click()
        If Not AdvBandedGv.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("[Page #]")
            ph.Footer.Content.Add(getTanggal.ToLongDateString)

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi supplier dan periode lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,"
        Dim reportFooter2 As String = "Ka. Bag. Purchasing"
        Dim reportFooter3 As String = "(_______________________)"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter5 As String = "Dep. Dir. Komersial"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Nilai Rata-rata :"
        Dim reportFooter8 As String = "Status Supplier :"
        Dim reportFooter9 As String = AdvBandedGv.Columns("total").SummaryText
        Dim reportFooter10 As String = lblHasil.Text
        Dim rec1 As RectangleF = New RectangleF(100, 100, 300, 20)
        Dim rec2 As RectangleF = New RectangleF(100, 120, 300, 80)
        Dim rec3 As RectangleF = New RectangleF(100, 200, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(750, 100, 300, 20)
        Dim rec5 As RectangleF = New RectangleF(750, 120, 300, 80)
        Dim rec6 As RectangleF = New RectangleF(750, 200, 300, 20)
        Dim rec7 As RectangleF = New RectangleF(750, 30, 150, 20)
        Dim rec8 As RectangleF = New RectangleF(750, 50, 150, 20)
        Dim rec9 As RectangleF = New RectangleF(900, 30, 50, 20)
        Dim rec10 As RectangleF = New RectangleF(900, 50, 200, 20)
        e.Graph.DrawString(reportFooter1, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter8, Color.Black, rec8, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter9, Color.Black, rec9, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter10, Color.Black, rec10, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "EVALUASI SUPPLIER"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Nama Supplier"
        Dim reportHeader5 As String = txtSupplier.Text
        Dim reportHeader6 As String = "Periode"
        Dim reportHeader7 As String = lckPeriodeAwal.Text & " s/d " & lckPeriodeAkhir.Text
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.MeasureString(reportHeader4, 200).Width.ToString)
        Dim rec As RectangleF = New RectangleF(404, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2a As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2b As RectangleF = New RectangleF(125, 80, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, 180, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec6 As RectangleF = New RectangleF(0, 80, e.Graph.MeasureString(reportHeader6, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec7 As RectangleF = New RectangleF(150, 80, e.Graph.MeasureString(reportHeader7, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2a, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2b, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    
End Class