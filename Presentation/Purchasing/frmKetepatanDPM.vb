Imports System.Data.SqlClient
'Imports DevExpress.XtraPrintingLinks
Public Class frmKetepatanDPM
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
    Private Sub reloadTable()
        Dim sql, sql1 As String
        Dim kolom As String = ""

        'If tglDari.Text = "" Then
        '    If tglsampai.Text <> "" Then
        '        sql = " where Tgl_DPM < convert(date,'" & tglsampai.EditValue & "',103)"
        '    End If
        'Else

        '    If tglsampai.Text <> "" Then
        '        sql = " where Tgl_DPM between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) "
        '    Else
        '        sql = " where Tgl_DPM < convert(date,'" & tglDari.EditValue & "',103)"
        '    End If
        'End If

        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " convert(varchar, Tgl_DPM, 103) < " & tglsampai.EditValue
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " Tgl_DPM  between '" & Format(tglDari.EditValue, "yyyy/MM/dd") & "' and '" & Format(tglsampai.EditValue, "yyyy/MM/dd") & "' ORDER by NO_DPM,qty, Kd_Stok "
            Else
                sql = " convert(varchar, Tgl_DPM, 103) > " & tglDari.EditValue
            End If
        End If

        For Each itm As Object In cbkolom.Properties.Items
            GVApprvDPM.Columns(itm.Value).visible = False
            GVApprvDPM.Columns(itm.Value).UnGroup()
            If itm.CheckState = CheckState.Checked Then
                ' If itm.Value <> "cek_po" Then
                If itm.Value <> "cek_gd" Then
                    kolom &= itm.Value & ","
                End If
                ' End If
                GVApprvDPM.Columns(itm.Value).visible = True
            End If

        Next

        If kolom = "" Then Exit Sub
        kolom = kolom.Substring(0, Len(kolom) - 1)
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT " & kolom & ", no_seq,0 as qtybelumdatang, status_approve from PURC.dbo.v_mon_pencapaianDPM where" & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")




        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql1 = " convert(varchar, Tgl_DPM, 103) < " & tglsampai.EditValue
            End If
        Else

            If tglsampai.Text <> "" Then
                sql1 = " Tgl_DPM  between '" & Format(tglDari.EditValue, "yyyy/MM/dd") & "' and '" & Format(tglsampai.EditValue, "yyyy/MM/dd") & "'  "
            Else
                sql1 = " convert(varchar, Tgl_DPM, 103) > " & tglDari.EditValue
            End If
        End If

        Dim dr As SqlDataReader = New SqlCommand("SELECT count(daydpm) Sesuai_dpm from PURC.dbo.v_mon_pencapaianDPM where daydpm <= 7 and" & sql1, sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lbl_DPM_Sesuai.Text = dr.Item(0)
        End If
        dr.Close()

        Dim dr1 As SqlDataReader = New SqlCommand("SELECT count(daydpm) Sesuai_dpm from PURC.dbo.v_mon_pencapaianDPM where daydpm > 7 and" & sql1, sqlconn).ExecuteReader
        dr1.Read()
        If dr1.HasRows Then
            Lbl_DPMTidakSesuai.Text = dr1.Item(0)
        End If
        dr1.Close()

        Dim dr2 As SqlDataReader = New SqlCommand("select count(isnull(daydpm,-1))  from  PURC.dbo.v_mon_pencapaianDPM where isnull(daydpm,-1)=-1 and" & sql1, sqlconn).ExecuteReader
        dr2.Read()
        If dr2.HasRows Then
            Lbl_BelumProseDPM.Text = dr2.Item(0)
        End If
        dr2.Close()

        Dim dr3 As SqlDataReader = New SqlCommand("select count(daypo)  from  PURC.dbo.v_mon_pencapaianDPM where daypo <= 0 and daypo >= -200 and" & sql1, sqlconn).ExecuteReader
        dr3.Read()
        If dr3.HasRows Then
            lbl_PO1.Text = dr3.Item(0)
        End If
        dr3.Close()

        Dim dr4 As SqlDataReader = New SqlCommand("select count(daypo)  from  PURC.dbo.v_mon_pencapaianDPM where daypo > 0 and" & sql1, sqlconn).ExecuteReader
        dr4.Read()

        If dr4.HasRows Then
            lbl_PO2.Text = dr4.Item(0)
        End If
        dr4.Close()

        Dim dr5 As SqlDataReader = New SqlCommand("select count(isnull(daypo,-201))  from  PURC.dbo.v_mon_pencapaianDPM where isnull(daypo,-201)=-201 and" & sql1, sqlconn).ExecuteReader
        dr5.Read()
        If dr5.HasRows Then
            lbl_PO3.Text = dr5.Item(0)
        End If
        dr5.Close()

        Dim row As DataRow
        Dim row1 As DataRow
        Dim s As Integer
        For i As Integer = 0 To dSO.Tables("_DpmApprv").Rows.Count - 1
            row = dSO.Tables("_DpmApprv").Rows(i)
            If i = 0 Then
                row("qtybelumdatang") = row("qty") - row("qty_qc_pass")

            ElseIf i > 0 Then
                s = i - 1
                row1 = dSO.Tables("_DpmApprv").Rows(s)

                If row("No_DPM") = row1("No_DPM") Then
                    If row("Kd_Stok") = row1("Kd_Stok") Then


                        If row1("qtybelumdatang") >= row("qty_qc_pass") Then
                            row("qtybelumdatang") = row1("qtybelumdatang") - row("qty_qc_pass")
                        ElseIf row1("qtybelumdatang") < row("qty_qc_pass") Then
                            row("qtybelumdatang") = 0
                        End If

                    ElseIf row("Kd_Stok") <> row1("Kd_Stok") Then
                        row("qtybelumdatang") = row("qty") - row("qty_qc_pass")




                    End If

                ElseIf row("No_DPM") <> row1("No_DPM") Then
                    row("qtybelumdatang") = row("qty") - row("qty_qc_pass")


                End If

            End If
        Next



    End Sub

    'Sub Hitung_JumlahStatus()

    'End Sub

    Private Sub FrmApproveDPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.v_mon_pencapaianDPM", sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        'DA2 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_DPM_D", sqlconn))
        'DA2.Fill(dSO, "_DpmApprv_d")

        'DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PR_D", sqlconn))
        'DA3.Fill(dSO, "_DpmApprv_dpr")

        'Dim rl As DataRelation
        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("No_DPM"), dSO.Tables("_DpmApprv_d").Columns("No_DPM"))

        'Dim col1(2) As DataColumn
        'Dim col2(2) As DataColumn
        'col1(0) = dSO.Tables("_DpmApprv_d").Columns("No_DPM")
        'col1(1) = dSO.Tables("_DpmApprv_d").Columns("Kd_Stok")
        'col1(2) = dSO.Tables("_DpmApprv_d").Columns("tipe_trans")

        'col2(0) = dSO.Tables("_DpmApprv_dpr").Columns("no_dpm")
        'col2(1) = dSO.Tables("_DpmApprv_dpr").Columns("kd_stok")
        'col2(2) = dSO.Tables("_DpmApprv_dpr").Columns("jns_dpm")

        'Dim rl2 As DataRelation
        'rl2 = dSO.Relations.Add("Detail_", col1, col2, False)

        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        'GcApprvDPM.LevelTree.Nodes.Add("Detail", GridView1).Nodes.Add("Detail_", GridView2)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        lookupDivisi.ValueMember = "Kd_Departemen"
        lookupDivisi.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang ORDER BY Nama_Barang ASC", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)


        tglDari.EditValue = Date.Now
        tglsampai.EditValue = Date.Now
        'btnSimpan.Hide()
        'btnExit.Hide()
        'btnSave = False
        'btnEdit = False
        'btnadd = False
        'setStatus()



    End Sub


    'Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    '    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub


    'Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GcApprvDPM.DoubleClick

    '    milih = GVApprvDPM.GetRow(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString()

    '    'showMessages(milih)
    '    'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
    '    'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

    '    da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & milih & "'", sqlconn))
    '    da_cari.Fill(ds1, "_dpm")

    '    frmDPM.caridpmku(milih)
    '    frmDPM.ShowDialog()

    'End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GcApprvDPM.Refresh()
        'GcApprvDPM.ShowPrintPreview()
        print_gc(GcApprvDPM, "Ketepatan DPM", True)


        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()

    End Sub

    Public Sub cetak_click()
        GcApprvDPM.Refresh()
        'GcApprvDPM.ShowPrintPreview()
        print_gc(GcApprvDPM, "Ketepatan DPM", True)


    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reloadTable()
    End Sub

    Private Sub tglDari_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglDari.EditValueChanged

    End Sub

    Private Sub cbkolom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkolom.EditValueChanged

    End Sub
End Class