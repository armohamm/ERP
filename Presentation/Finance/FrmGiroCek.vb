Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class FrmGiroCek
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, daDel, daDel2 As SqlClient.SqlDataAdapter
    Dim noGiro() As String
    Dim nG() As String
    Dim stat() As String
    Dim jml As Integer = 0
    Dim isValid As Boolean = True
    Dim err As String
    Dim giro As String

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        'STATE = "ADD" '<-- set state add

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

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim builder As New SqlCommandBuilder(DA)
        Dim builder1 As New SqlCommandBuilder(daDel)
        Dim builder2 As New SqlCommandBuilder(daDel2)
        ReDim noGiro(0)
        ReDim stat(0)
        ReDim nG(0)
        If Not isDelete = True Then
            For Each rw As DataRow In dSO.Tables("_SIF_COA").Rows
                If rw.RowState = DataRowState.Added Then
                    noGiro(noGiro.Length - 1) = rw.Item("nomor")
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name
                    rw("Kd_Cabang") = getKodeCabang()
                    rw("status") = "DITERIMA"
                    ReDim Preserve noGiro(noGiro.Length)
                ElseIf rw.RowState = DataRowState.Modified Then
                    noGiro(noGiro.Length - 1) = rw.Item("nomor")
                    nG(nG.Length - 1) = rw.Item("nomor")
                    stat(stat.Length - 1) = rw.Item("status")
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                    ReDim Preserve noGiro(noGiro.Length)
                End If
            Next

            For i As Integer = 0 To nG.Length - 1
                If Not stat(i).Equals("DITERIMA  ") Then
                    err &= "Status giro " & nG(i) & " sudah ditutup. Tidak boleh ada perubahan." & vbCrLf
                    isValid = False
                Else
                    isValid = True
                End If
            Next

            If isValid = True Then
                DA.InsertCommand = builder.GetInsertCommand()
                DA.UpdateCommand = builder.GetUpdateCommand()
                DA.DeleteCommand = builder.GetDeleteCommand()
                DA.Update(dSO, "_SIF_COA")
                dSO.Tables("_SIF_COA").AcceptChanges()
                For jml As Integer = 0 To noGiro.Length - 2
                    call_procedure("JRR-KPT-10", noGiro(jml))
                Next
                showMessages("Data Berhasil di Update..!", 14)
                loadAll()
            Else
                MsgBox("Ada kesalahan dalam pengisian data." & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                dSO.Tables("_SIF_COA").RejectChanges()
                err = ""
                isValid = True
                ReDim stat(0)
                ReDim nG(0)
            End If
        Else
            DA.InsertCommand = builder.GetInsertCommand()
            DA.UpdateCommand = builder.GetUpdateCommand()
            DA.DeleteCommand = builder.GetDeleteCommand()

            daDel.InsertCommand = builder1.GetInsertCommand()
            daDel.UpdateCommand = builder1.GetUpdateCommand()
            daDel.DeleteCommand = builder1.GetDeleteCommand()

            daDel2.InsertCommand = builder2.GetInsertCommand()
            daDel2.UpdateCommand = builder2.GetUpdateCommand()
            daDel2.DeleteCommand = builder2.GetDeleteCommand()

            DA.Update(dSO, "_SIF_COA")
            daDel.Update(dSO, "JurnalDel")
            daDel2.Update(dSO, "JurnalDDel")

            dSO.Tables("_SIF_COA").AcceptChanges()
            showMessages("Data Berhasil di Hapus..!", 14)
            loadAll()
        End If
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMstCOA.SelectedRowsCount - 1)
        For i = 0 To GvMstCOA.SelectedRowsCount - 1
            rows(i) = GvMstCOA.GetDataRow(GvMstCOA.GetSelectedRows(i))
        Next
        GvMstCOA.BeginSort()
        Try
            For Each row In rows
                If row("status") = "DITERIMA  " Then
                    If Not row("no_jur") = vbNullString Or row("no_jur") = "" Then
                        If Not dSO.Tables("JurnalDel") Is Nothing Then dSO.Tables("JurnalDel").Clear()
                        daDel = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
                        daDel.Fill(dSO, "JurnalDel")
                        For Each rw As DataRow In dSO.Tables("JurnalDel").Rows
                            rw.Delete()
                        Next
                        If Not dSO.Tables("JurnalDDel") Is Nothing Then dSO.Tables("JurnalDDel").Clear()
                        daDel2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
                        daDel2.Fill(dSO, "JurnalDDel")
                        For Each rw As DataRow In dSO.Tables("JurnalDDel").Rows
                            rw.Delete()
                        Next
                        row.Delete()
                    End If
                Else
                    MsgBox("Status giro " & row("nomor") & " sudah ditutup. Tidak boleh ada perubahan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GvMstCOA.EndSort()
        End Try
        simpan(True)
    End Sub
    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub FrmGiroCek_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        loadAll()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        cmdSimpan.Hide()
        btnExit.Hide()
        btnDel.Hide()

    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_CATALOG_MAKEJUR"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Private Sub GvMstCOA_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvMstCOA.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("tgl_trans"), getTanggal)
    End Sub

    Private Sub loadAll()
        If Not dSO.Tables("_SIF_COA") Is Nothing Then dSO.Tables("_SIF_COA").Clear()
        If Not ds_cari.Tables("_lookup4") Is Nothing Then ds_cari.Tables("_lookup4").Clear()
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()
        If Not ds_cari.Tables("_lookup3") Is Nothing Then ds_cari.Tables("_lookup3").Clear()

        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO", sqlconn))
        DA.Fill(dSO, "_SIF_COA")
        GcMstCOA.DataSource = dSO.Tables("_SIF_COA")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_Gen_Reff_D where id_ref_data='JNSBYR' and rec_stat='Y'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupjns.DataSource = ds_cari.Tables("_lookup4")
        lookupjns.ValueMember = "Id_Data"
        lookupjns.DisplayMember = "Desc_Data"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank from SIF.dbo.SIF_Bank", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        lookupbank.DataSource = ds_cari.Tables("_lookup1")
        lookupbank.ValueMember = "kd_bank"
        lookupbank.DisplayMember = "nama_bank"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupkartu.DataSource = ds_cari.Tables("_lookup2")
        lookupkartu.ValueMember = "kode"
        lookupkartu.DisplayMember = "nama"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookupval.DataSource = ds_cari.Tables("_lookup3")
        lookupval.ValueMember = "Kode_Valuta"
        lookupval.DisplayMember = "Nama_Valuta"
    End Sub

    Public Sub delete_click()
        Dim viewGiro As ColumnView = GvMstCOA
        giro = viewGiro.GetFocusedRowCellValue("nomor").ToString
        If MsgBox("Hapus giro dengan nomor " & giro & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then hapus_record()
    End Sub
End Class