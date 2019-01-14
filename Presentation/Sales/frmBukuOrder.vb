Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmBukuOrder
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public init As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String)
        Dim sql As String
        Dim sqlstat As String

        For Each item As Object In rdFilter.Properties.Items
            If item.CheckState = CheckState.Checked Then
                If sqlstat = "" Then
                    sqlstat = item.Value
                Else
                    sqlstat = sqlstat & " or " & item.Value
                End If

            End If
        Next
        If sqlstat <> "" Then sqlstat = " and ( " & sqlstat & " ) "
        If txtCustomer.Text <> "" Then
            sql = " and Kd_Customer='" & txtCustomer.EditValue & "'"
        End If
        If cmdBarang.Text <> "" Then
            sql = sql + " and kd_stok='" & cmdBarang.EditValue & "'"
        End If
        If tglDari.Text = "" Then
            If tglSampai.Text <> "" Then
                sql = sql + " and convert(varchar,tgl_sp,112) <= " & Format(tglSampai.EditValue, "yyyyMMdd")
            End If
        Else
            If tglSampai.Text <> "" Then
                sql = sql + " and convert(varchar,tgl_sp,112)  between '" & Format(tglDari.EditValue, "yyyyMMdd") & "' and '" & Format(tglSampai.EditValue, "yyyyMMdd") & "' "
            Else
                sql = sql + " and convert(varchar,tgl_sp,112)  >= " & Format(tglDari.EditValue, "yyyyMMdd")
            End If
        End If
        If cmdJenis.Text <> "" Then
            sql = sql + " and kd_jenis = '" & cmdJenis.EditValue & "'"
        End If
        If cmdMerk.Text <> "" Then
            sql = sql + " and kd_merk = '" & cmdMerk.EditValue & "'"
        End If
        If cmdTipe.Text <> "" Then
            sql = sql + " and kd_tipe = '" & cmdTipe.EditValue & "'"
        End If
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        If Not Me.Parent Is Nothing Then
            lblFound.Text = "Searching..."
            lblFound.Refresh()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,Almt_pnrm,No_Telp,No_sp,old_num,Deskripsi,Qty,Keterangan,Tgl_kirim,realisasi_tgl_kirim,isClosed,Owner,Tipe_trans,desc_promo from Sales.dbo.vBuku where  '1'='" & kode & "' and departement like '" & cmbDivisi.EditValue & "' and  isnull([set],0) <> 1 and  tipe_trans in ('" & SpringUmum & "','" & SponUmum & "','" & CentianUmum & "') " & sql & sqlstat & " order by no_sp, len(no_seq), no_seq", sqlconn))
            DA.Fill(dsete, "SOB")
            Dim qry = From RW In dsete.Tables("SOB") Select RW.Item("No_sp") Distinct
            lblFound.Text = "SP Found(s) : " & qry.Count.ToString
        End If

        ' No_sp.Group()

    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reload_table("SPON")
        GC.DataSource = dsete.Tables(0)
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer union select '', '','' ", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        prn = frmMain
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang from SIF.dbo.SIF_Barang as b where b.kd_jns_persd=1", sqlconn))
        DA.Fill(dsete, "VBARANG")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Unit as Kd_Satuan, NAMA as Nama_Barang, KD_SET as Kode_Barang from SIF.dbo.SIF_SET_PRODUCT union select '','',''", sqlconn))
        DA.Fill(dsete, "VBARANG")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_Jenis_Barang as b where b.rec_stat<>'T' and Kd_Jns_Persd='1' union select '',''", sqlconn))
        DA.Fill(dsete, "VJenis")
        cmdJenis.Properties.DataSource = dsete.Tables("VJenis")


        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk , Nama_Merk from SIF.dbo.SIF_Merk as b where b.rec_stat<>'T'  union select '',''", sqlconn))
        DA.Fill(dsete, "VMerk")
        cmdMerk.Properties.DataSource = dsete.Tables("VMerk")

        cmdBarang.Properties.DataSource = dsete.Tables("VBARANG")
        If Not TypeOf Me.Parent Is Form Then
            btnBuku.Enabled = False
            prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        End If
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [tipe_trans],[tipe_desc] from [SIF].[dbo].[SIF_TIPE_TRANS]", sqlconn))
        DA.Fill(dsete, "tipe_trans")
        repTipeTrans.DataSource = dsete.Tables("tipe_trans")

        Dim m(3) As DataRow
        With dsete.Tables.Add("DIVISI")
            .Columns.Add("Kode_Divisi")
            .Columns.Add("Nama_Divisi")
            m(0) = .NewRow
            m(0).item(0) = "2"
            m(0).item(1) = "Divisi Spring"

            m(1) = .NewRow
            m(1).item(0) = "3"
            m(1).item(1) = "Divisi Spon"

            m(2) = .NewRow
            m(2).item(0) = "4"
            m(2).item(1) = "Divisi Seally"

            m(3) = .NewRow
            m(3).Item(0) = "%%"
            m(3).Item(1) = "ALL"
            .Rows.Add(m(0))
            .Rows.Add(m(1))
            .Rows.Add(m(2))
            .Rows.Add(m(3))
        End With

        'DA = New SqlClient.SqlDataAdapter("select '' a , '' b", sqlconn)
        'DA.Fill(dsete, "DUMMY")
        'rdFilter.Properties.DataSource = dsete.Tables("DUMMY")

        cmbDivisi.Properties.DataSource = dsete.Tables("DIVISI")
        'If kddep = KD_DIV_SPRING Then
        '    lblJudul.Text = " BUKU ORDER SPRING"
        'ElseIf kddep = KD_DIV_SPON Then
        '    lblJudul.Text = " BUKU ORDER SPON BUSA DAN CENTIAN"
        'ElseIf kddep = KD_DIV_SILLY Then
        '    lblJudul.Text = " BUKU ORDER SEALLY"
        'End If
        cmbDivisi.EditValue = kddep
        If cmbDivisi.Text = "" Then cmbDivisi.EditValue = "%%"
    End Sub
    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        Me.Close()
    End Sub

    Private Sub filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filter.Click

        reload_table("1")

    End Sub
    Public Sub cetak()
        Try

            GVSpon.OptionsPrint.Reset()
            GVSpon.GridControl.ShowPrintPreview()
        Catch ex As Exception
            MsgBox("Error Printing : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
        End Try
    End Sub
    Public Sub add_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Laporan Buku Order " & vbCrLf & "Periode " & tglDari.EditValue.ToString & " - " & tglSampai.EditValue.ToString)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtCustomer.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglSampai.EditValue = vbNullString
        cmdBarang.EditValue = vbNullString
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        lblFound.Text = "SP Count(s) : 0"
    End Sub

    Private Sub GVSpon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVSpon.DoubleClick
        If GVSpon.GetSelectedRows.Count > 0 Then
            Dim x As Object

            Dim tipe As String = GVSpon.GetFocusedRow.item("Tipe_trans")
            Dim no_sp As String = GVSpon.GetFocusedRow.item("No_sp")
            Dim ttrans As String = GVSpon.GetFocusedRow.item("Tipe_trans")
            If tipe = SpringUmum Or tipe = SponUmum Then
                call_form_manual("frmSO")
                x = frmMain.pnlDisplay2.Controls(0)
                x.cancel_click()
                x.no_sp = no_sp
                x.tipe_transaksi = ttrans
                x.call_edit()
            ElseIf tipe = CentianUmum Then
                call_form_manual("frmSOBOX")
                x = frmMain.pnlDisplay2.Controls(0)
                x.cancel_click()
                x.no_sp = no_sp
                x.call_edit()
            End If
        End If
    End Sub

    Private Sub cmdMerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMerk.EditValueChanged
        cmdTipe.EditValue = vbNullString
        If Not dsete.Tables("VTipe") Is Nothing Then dsete.Tables("VTipe").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe, Nama_Tipe from SIF.dbo.SIF_Tipe as b where b.rec_stat<>'T' and kode_merk='" & cmdMerk.EditValue & "' union select '%%',''", sqlconn))
        DA.Fill(dsete, "VTipe")
        cmdTipe.Properties.DataSource = dsete.Tables("VTipe")
    End Sub
End Class