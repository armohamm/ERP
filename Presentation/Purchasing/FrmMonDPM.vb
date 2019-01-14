Imports System.Data.SqlClient
'Imports DevExpress.XtraPrintingLinks
Public Class FrmMonDPM

    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
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
        End With
    End Sub


    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
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

        DA.Update(dSO, "_DpmApprv")
        dSO.Tables("_DpmApprv").AcceptChanges()

        DA2.Update(ds2, "_DpmApprv_d")
        ds2.Tables("_DpmApprv_d").AcceptChanges()

        showMessages("Approval DPM berhasil di Update!")
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GVApprvDPM.SelectedRowsCount - 1)
        For i = 0 To GVApprvDPM.SelectedRowsCount - 1
            rows(i) = GVApprvDPM.GetDataRow(GVApprvDPM.GetSelectedRows(i))
        Next
        GVApprvDPM.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GVApprvDPM.EndSort()
        End Try
        simpan()
    End Sub
    Private Sub LoadFilter()
        If Not dSO.Relations("Detail_") Is Nothing Then dSO.Relations.Clear()
        If Not dSO.Relations("Detail") Is Nothing Then dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_dpr") Is Nothing Then dSO.Tables("_DpmApprv_dpr").Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""
        'If tglDari.Text = "" Then
        '    If tglsampai.Text <> "" Then
        '        sql = " where convert(varchar, Tgl_DPM, 103) < " & tglsampai.EditValue
        '    End If
        'Else
        '    If tglsampai.Text <> "" Then
        '        sql = " Tgl_DPM convert(varchar, Tgl_DPM, 103)  between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "' "
        '    Else
        '        sql = " where convert(varchar, Tgl_DPM, 103)  > " & tglDari.EditValue
        '    End If
        'End If

        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " convert(varchar, Tgl_DPM, 103) < " & tglsampai.EditValue
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " Tgl_DPM  between '" & Format(tglDari.EditValue, "yyyy/MM/dd") & "' and '" & Format(tglsampai.EditValue, "yyyy/MM/dd") & "' "
            Else
                sql = " convert(varchar, Tgl_DPM, 103) > " & tglDari.EditValue
            End If
        End If

        DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_DPM WHERE" & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_DPM_D", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PR_D", sqlconn))
        DA3.Fill(dSO, "_DpmApprv_dpr")
        'aa
        'Dim rl As DataRelation
        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("No_DPM"), dSO.Tables("_DpmApprv_d").Columns("No_DPM"))

        Dim col1(2) As DataColumn
        Dim col2(2) As DataColumn
        Dim col3(2) As DataColumn
        'col3(0) = dSO.Tables("_DpmApprv").Columns("no_dpm")
        'col3(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        'col3(2) = dSO.Tables("_DpmApprv").Columns("jns_dpm")

        col1(0) = dSO.Tables("_DpmApprv_d").Columns("No_DPM")
        col1(1) = dSO.Tables("_DpmApprv_d").Columns("Kd_Stok")
        col1(2) = dSO.Tables("_DpmApprv_d").Columns("tipe_trans")

        col2(0) = dSO.Tables("_DpmApprv_dpr").Columns("no_dpm")
        col2(1) = dSO.Tables("_DpmApprv_dpr").Columns("kd_stok")
        col2(2) = dSO.Tables("_DpmApprv_dpr").Columns("jns_dpm")

        Dim rl2, rl3 As DataRelation
        rl2 = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("No_DPM"), dSO.Tables("_DpmApprv_d").Columns("No_DPM"), False)

        rl3 = dSO.Relations.Add("Detail_", col1, col2, False)

        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        GcApprvDPM.LevelTree.Nodes.Add("Detail", GridView1).Nodes.Add("Detail_", GridView2)


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        lookupDivisi.ValueMember = "Kd_Departemen"
        lookupDivisi.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        'prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)


        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_DPM(rw("No_DPM"))
        Next
    End Sub
    Private Sub FrmApproveDPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_DPM", sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        'DA2 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_DPM_D", sqlconn))
        'DA2.Fill(dSO, "_DpmApprv_d")

        'DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PR_D", sqlconn))
        'DA3.Fill(dSO, "_DpmApprv_dpr")

        ''Dim rl As DataRelation
        ''rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("No_DPM"), dSO.Tables("_DpmApprv_d").Columns("No_DPM"))

        'Dim col1(2) As DataColumn
        'Dim col2(2) As DataColumn
        'Dim col3(2) As DataColumn
        ''col3(0) = dSO.Tables("_DpmApprv").Columns("no_dpm")
        ''col3(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        ''col3(2) = dSO.Tables("_DpmApprv").Columns("jns_dpm")

        'col1(0) = dSO.Tables("_DpmApprv_d").Columns("No_DPM")
        'col1(1) = dSO.Tables("_DpmApprv_d").Columns("Kd_Stok")
        'col1(2) = dSO.Tables("_DpmApprv_d").Columns("tipe_trans")

        'col2(0) = dSO.Tables("_DpmApprv_dpr").Columns("no_dpm")
        'col2(1) = dSO.Tables("_DpmApprv_dpr").Columns("kd_stok")
        'col2(2) = dSO.Tables("_DpmApprv_dpr").Columns("jns_dpm")

        'Dim rl2, rl3 As DataRelation
        'rl2 = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("No_DPM"), dSO.Tables("_DpmApprv_d").Columns("No_DPM"), False)

        'rl3 = dSO.Relations.Add("Detail_", col1, col2, False)

        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        'GcApprvDPM.LevelTree.Nodes.Add("Detail", GridView1).Nodes.Add("Detail_", GridView2)


        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        tglDari.EditValue = Now.Date
        tglsampai.EditValue = Now.Date

        'For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
        '    rw("nstatus") = cek_status_DPM(rw("No_DPM"))
        'Next

        'btnSimpan.Hide()
        'btnExit.Hide()
        'btnSave = False
        'btnEdit = False
        'btnadd = False
        'setStatus()

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        ctk_print()
    End Sub

    Public Sub ctk_print()
        GcApprvDPM.Refresh()
        GcApprvDPM.ShowPrintPreview()
    End Sub

    Public Sub cetak_click()
        ctk_print()
    End Sub

    
  
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadFilter()
    End Sub
End Class