Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting
'Imports DevExpress.XtraPrintingLinks

Public Class FrmMonHPRekap

    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public STATE As String
    'Public prn As frmMain '<-- untuk mengakses frmMain
    Public milih As String
    Public dtable As DataTable
    Private rw As DataRow
    Dim dSO, ds1, ds2, ds_cari As New DataSet
    Dim DA, DA2, DA3, da_cari, DALOOKUP As SqlClient.SqlDataAdapter



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        'setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

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


    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("HPP").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = kdcabang
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name

            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                rw("tgl_approve") = Now
                rw("user_approve") = umum.username
            End If
        Next

        'For Each rw1 As DataRow In ds2.Tables("_DpmApprv_d").Rows
        '    If rw1.RowState = DataRowState.Modified Then

        '        rw1("status") = rw("status")
        '    End If
        'Next

        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()

        DA.Update(dSO, "HPP")
        dSO.Tables("HPP").AcceptChanges()

      
        showMessages("HPP berhasil Update!")
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GVHPP.SelectedRowsCount - 1)
        For i = 0 To GVHPP.SelectedRowsCount - 1
            rows(i) = GVHPP.GetDataRow(GVHPP.GetSelectedRows(i))
        Next
        GVHPP.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GVHPP.EndSort()
        End Try
        simpan()
    End Sub
    Sub Load_cari_Filter()
        'connect()
        'If Not dSO.Relations("hpp") Is Nothing Then dSO.Relations.Clear()
        'If Not dSO.Relations("Detail") Is Nothing Then dSO.Relations.Clear()

        'If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        'If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()
        'COMBOLOAD()
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandTimeout = 0
        sqlcmd.Connection = sqlconn


        If lckJenis.Text = "ALL" And lckMerk.Text = "ALL" And lckTipe.Text = "ALL" Then

            If Not dSO.Tables("HPP") Is Nothing Then dSO.Tables("HPP").Clear()
            sqlcmd.CommandText = "SELECT * from FIN.dbo.FIN_HPP_HARIAN where tgl_generate=(select MAX(tgl_generate) FROM FIN.dbo.FIN_HPP_HARIAN)"
            DA3 = New SqlClient.SqlDataAdapter(sqlcmd)

            DA3.Fill(dSO, "HPP")
            GcApprvDPM.DataSource = dSO.Tables("HPP")
            GVHPP.BestFitColumns()
            If dSO.Tables("HPP").Rows.Count = 0 Then
                MessageBox.Show("DATA TIDAK DITEMUKAN")
            End If
        Else
            Dim sql1 As String

            If lckJenis.Text <> "ALL" And lckMerk.Text = "ALL" And lckTipe.Text = "ALL" Then
                'MessageBox.Show(lckJenis.EditValue)
                sql1 = " AND kd_jenis= '" & lckJenis.EditValue & "' "
            ElseIf lckJenis.Text = "ALL" And lckMerk.Text <> "ALL" And lckTipe.Text = "ALL" Then
                sql1 = " AND kd_merk= '" & lckMerk.EditValue & "' "
            ElseIf lckJenis.Text = "ALL" And lckMerk.Text = "ALL" And lckTipe.Text <> "ALL" Then
                sql1 = " AND kd_tipe= '" & lckTipe.EditValue & "' "
            ElseIf lckJenis.Text <> "ALL" And lckMerk.Text <> "ALL" And lckTipe.Text = "ALL" Then
                sql1 = " AND kd_jenis= '" & lckJenis.EditValue & "' and kd_merk='" & lckMerk.EditValue & "' "
            ElseIf lckJenis.Text <> "ALL" And lckMerk.Text = "ALL" And lckTipe.Text <> "ALL" Then
                sql1 = " AND kd_jenis= '" & lckJenis.EditValue & "' and kd_tipe='" & lckTipe.EditValue & "' "
            ElseIf lckJenis.Text = "ALL" And lckMerk.Text <> "ALL" And lckTipe.Text <> "ALL" Then
                sql1 = " AND kd_merk= '" & lckMerk.EditValue & "' and kd_tipe='" & lckTipe.EditValue & "' "
            ElseIf lckJenis.Text <> "ALL" And lckMerk.Text <> "ALL" And lckTipe.Text <> "ALL" Then
                sql1 = " AND kd_jenis= '" & lckJenis.EditValue & "' and kd_merk= '" & lckMerk.EditValue & "' and kd_tipe='" & lckTipe.EditValue & "' "





            End If
            Try
                If Not dSO.Tables("HPP") Is Nothing Then dSO.Tables("HPP").Clear()

                sqlcmd.CommandText = "SELECT * from FIN.dbo.FIN_HPP_HARIAN where tgl_generate=(select MAX(tgl_generate) FROM FIN.dbo.FIN_HPP_HARIAN) " & sql1 & ""
                DA3 = New SqlClient.SqlDataAdapter(sqlcmd)

                DA3.Fill(dSO, "HPP")
                GcApprvDPM.DataSource = dSO.Tables("HPP")
                GVHPP.BestFitColumns()

                If dSO.Tables("HPP").Rows.Count = 0 Then
                    MessageBox.Show("DATA TIDAK DITEMUKAN")
                End If
            Catch e As Exception
                MessageBox.Show(e.Message)
            End Try


        End If

        'connect()






    End Sub
    Private Sub FrmMonHPRekap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()



        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        COMBOLOAD()
        'btnSimpan.Hide()
        'btnExit.Hide()
        'btnSave = False
        'btnEdit = False
        'btnadd = False
        'setStatus()



    End Sub

    Sub COMBOLOAD()
        If Not ds1.Tables("JenisBarang") Is Nothing Then ds1.Tables("JenisBarang").Clear()
        If Not ds1.Tables("Merk") Is Nothing Then ds1.Tables("Merk").Clear()
        If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
        If Not ds1.Tables("Ukuran") Is Nothing Then ds1.Tables("Ukuran").Clear()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct '' kd_jenis, 'ALL' Nama_Jenis " & _
"from sif.dbo.SIF_Jenis_Barang union " & _
"select distinct  Kd_Jns_Brg kd_jenis,Nama_Jenis " & _
"from sif.dbo.SIF_Jenis_Barang a " & _
"inner join fin.dbo.FIN_HPP_HARIAN b " & _
"on a.Kd_Jns_Brg = b.kd_jenis " & _
"where a.Rec_Stat = 'Y' order by kd_jenis", sqlconn))
        DA2.Fill(ds1, "JenisBarang")
        lckJenis.Properties.DataSource = ds1.Tables("JenisBarang")
        lckJenis.Properties.ValueMember = "kd_jenis"
        lckJenis.Properties.DisplayMember = "Nama_Jenis"
        lookupjenis.DataSource = ds1.Tables("JenisBarang")
        lookupjenis.ValueMember = "kd_jenis"
        lookupjenis.DisplayMember = "Nama_Jenis"


        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct '' kd_merk, 'ALL' Nama_Merk " & _
"from sif.dbo.SIF_Merk union " & _
"select distinct  a.Kode_Merk kd_merk,a.Nama_Merk " & _
"from sif.dbo.SIF_Merk a " & _
"inner join fin.dbo.FIN_HPP_HARIAN b " & _
"on a.Kode_Merk = b.kd_merk " & _
"where a.Rec_Stat = 'Y' ", sqlconn))
        DA2.Fill(ds1, "Merk")
        lckMerk.Properties.DataSource = ds1.Tables("Merk")
        lckMerk.Properties.ValueMember = "kd_merk"
        lckMerk.Properties.DisplayMember = "Nama_Merk"
        Lokupmerk.DataSource = ds1.Tables("Merk")
        Lokupmerk.ValueMember = "kd_merk"
        Lokupmerk.DisplayMember = "Nama_Merk"

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
"from sif.dbo.SIF_Tipe union " & _
"select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
"from sif.dbo.SIF_Tipe a " & _
"inner join fin.dbo.FIN_HPP_HARIAN b " & _
"on a.Kode_Tipe = b.kd_tipe " & _
"where a.Rec_Stat = 'Y' order by kd_tipe", sqlconn))
        DA2.Fill(ds1, "TipeBarang")
        lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
        lckTipe.Properties.ValueMember = "kd_tipe"
        lckTipe.Properties.DisplayMember = "Nama_Tipe"
        lokuptipe.DataSource = ds1.Tables("TipeBarang")
        lokuptipe.ValueMember = "kd_tipe"
        lokuptipe.DisplayMember = "Nama_Tipe"

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct '' kd_ukuran, 'ALL' Nama_Ukuran  from sif.dbo.SIF_Ukuran union select distinct  Kode_Ukuran kd_ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran where Rec_Stat = 'Y'  ", sqlconn))
        DA2.Fill(ds1, "Ukuran")
        Lookupukuran.DataSource = ds1.Tables("Ukuran")
        Lookupukuran.ValueMember = "kd_ukuran"
        Lookupukuran.DisplayMember = "Nama_Ukuran"

    End Sub

    'Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHPP.DoubleClick
    '    milih = GVHPP.GetFocusedRowCellValue("no_po").ToString()

    '    da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
    '    da_cari.Fill(ds1, "_crpo")

    '    frmPO.cariPO(milih)
    '    frmPO.ShowDialog()
    'End Sub


    ''Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    ''    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    ''End Sub


    'Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    '    milih = GVApprvDPM.GetRow(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString()

    '    'showMessages(milih)
    '    'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
    '    'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

    '    da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & milih & "'", sqlconn))
    '    da_cari.Fill(ds1, "_dpm")

    '    frmDPM.caridpmku(milih)
    '    frmDPM.ShowDialog()

    'End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GcApprvDPM.Refresh()
        GcApprvDPM.ShowPrintPreview()

    End Sub

    Public Sub cetak_click()
        If Not GVHPP.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("")
            ph.Footer.Content.Add("Hal. [Page #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter tanggal lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Load_cari_Filter()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING HPP Rekap"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = getTanggal.ToLongDateString
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(404, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

  
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        lckJenis.EditValue = vbNullString
        lckMerk.EditValue = vbNullString
        lckTipe.EditValue = vbNullString
        COMBOLOAD()
    End Sub

    Private Sub lckMerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lckMerk.EditValueChanged
        If lckJenis.Text <> "ALL" And lckMerk.Text <> "ALL" Then
            If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe union " & _
    "select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Tipe = b.kd_tipe " & _
    "where a.Rec_Stat = 'Y'  and b.kd_merk='" & lckMerk.EditValue & "' and b.kd_jenis='" & lckJenis.EditValue & "' order by kd_tipe ", sqlconn))
            DA2.Fill(ds1, "TipeBarang")
            lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "kd_tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lokuptipe.DataSource = ds1.Tables("TipeBarang")
            lokuptipe.ValueMember = "kd_tipe"
            lokuptipe.DisplayMember = "Nama_Tipe"

        ElseIf lckJenis.Text = "ALL" And lckMerk.Text <> "ALL" Then
            If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe union " & _
    "select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Tipe = b.kd_tipe " & _
    "where a.Rec_Stat = 'Y'  and b.kd_merk='" & lckMerk.EditValue & "'  order by kd_tipe ", sqlconn))
            DA2.Fill(ds1, "TipeBarang")
            lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "kd_tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lokuptipe.DataSource = ds1.Tables("TipeBarang")
            lokuptipe.ValueMember = "kd_tipe"
            lokuptipe.DisplayMember = "Nama_Tipe"
        ElseIf lckJenis.Text <> "ALL" And lckMerk.Text = "ALL" Then
            If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe union " & _
    "select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Tipe = b.kd_tipe " & _
    "where a.Rec_Stat = 'Y'  and b.kd_jenis='" & lckJenis.EditValue & "'  order by kd_tipe ", sqlconn))
            DA2.Fill(ds1, "TipeBarang")
            lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "kd_tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lokuptipe.DataSource = ds1.Tables("TipeBarang")
            lokuptipe.ValueMember = "kd_tipe"
            lokuptipe.DisplayMember = "Nama_Tipe"
        ElseIf lckJenis.Text = "ALL" And lckMerk.Text = "ALL" Then
            If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe union " & _
    "select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Tipe = b.kd_tipe " & _
    "where a.Rec_Stat = 'Y'    order by kd_tipe ", sqlconn))
            DA2.Fill(ds1, "TipeBarang")
            lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "kd_tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lokuptipe.DataSource = ds1.Tables("TipeBarang")
            lokuptipe.ValueMember = "kd_tipe"
            lokuptipe.DisplayMember = "Nama_Tipe"

        End If
    End Sub

    Private Sub lckJenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lckJenis.EditValueChanged
        If lckJenis.Text <> "ALL" Then
            If Not ds1.Tables("Merk") Is Nothing Then ds1.Tables("Merk").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct '' kd_merk, 'ALL' Nama_Merk " & _
    "from sif.dbo.SIF_Merk union " & _
    "select distinct  a.Kode_Merk kd_merk,a.Nama_Merk " & _
    "from sif.dbo.SIF_Merk a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Merk = b.kd_merk " & _
    "where a.Rec_Stat = 'Y' and b.kd_jenis='" & lckJenis.EditValue & "'  ", sqlconn))
            DA2.Fill(ds1, "Merk")
            lckMerk.Properties.DataSource = ds1.Tables("Merk")
            lckMerk.Properties.ValueMember = "kd_merk"
            lckMerk.Properties.DisplayMember = "Nama_Merk"
            Lokupmerk.DataSource = ds1.Tables("Merk")
            Lokupmerk.ValueMember = "kd_merk"
            Lokupmerk.DisplayMember = "Nama_Merk"


            If Not ds1.Tables("TipeBarang") Is Nothing Then ds1.Tables("TipeBarang").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '' kd_tipe, 'ALL' Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe union " & _
    "select distinct  a.Kode_Tipe kd_tipe,a.Nama_Tipe " & _
    "from sif.dbo.SIF_Tipe a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Tipe = b.kd_tipe " & _
    "where a.Rec_Stat = 'Y'  and b.kd_jenis='" & lckJenis.EditValue & "'  order by kd_tipe ", sqlconn))
            DA2.Fill(ds1, "TipeBarang")
            lckTipe.Properties.DataSource = ds1.Tables("TipeBarang")
            lckTipe.Properties.ValueMember = "kd_tipe"
            lckTipe.Properties.DisplayMember = "Nama_Tipe"
            lokuptipe.DataSource = ds1.Tables("TipeBarang")
            lokuptipe.ValueMember = "kd_tipe"
            lokuptipe.DisplayMember = "Nama_Tipe"
        ElseIf lckJenis.Text = "ALL" Then
            If Not ds1.Tables("Merk") Is Nothing Then ds1.Tables("Merk").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct '' kd_merk, 'ALL' Nama_Merk " & _
    "from sif.dbo.SIF_Merk union " & _
    "select distinct  a.Kode_Merk kd_merk,a.Nama_Merk " & _
    "from sif.dbo.SIF_Merk a " & _
    "inner join fin.dbo.FIN_HPP_HARIAN b " & _
    "on a.Kode_Merk = b.kd_merk " & _
    "where a.Rec_Stat = 'Y'   ", sqlconn))
            DA2.Fill(ds1, "Merk")
            lckMerk.Properties.DataSource = ds1.Tables("Merk")
            lckMerk.Properties.ValueMember = "kd_merk"
            lckMerk.Properties.DisplayMember = "Nama_Merk"
            Lokupmerk.DataSource = ds1.Tables("Merk")
            Lokupmerk.ValueMember = "kd_merk"
            Lokupmerk.DisplayMember = "Nama_Merk"

        End If
    End Sub
End Class