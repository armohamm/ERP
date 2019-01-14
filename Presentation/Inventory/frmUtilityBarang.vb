'|---------------------------
'|  CREATED BY RENDY        |
'|  EDITED BY RENDY         |
'|---------------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmUtilityBarang

    Dim BTRANS As SqlTransaction

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public STATE As String
    Dim row As DataRow
    Public prn As frmMain
    Dim dsLOV, dsGrid As New DataSet
    Dim daGrid, daRekening, daPusat, daPers, daBrg, daSat, daUkur As SqlClient.SqlDataAdapter

    Private Sub frmUtilityBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        daGrid = New SqlDataAdapter(New SqlCommand("SELECT * FROM sif.dbo.SIF_Barang ", sqlconn))
        daGrid.Fill(dsGrid, "gudang")
        GC.DataSource = dsGrid.Tables("gudang")
        GV.BestFitColumns()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        GenLOV()

        For a As Integer = 0 To GV.Columns.Count - 1
            CCKBOXcolom.Properties.Items.Add(GV.Columns(a).Caption)
        Next
    End Sub

    Sub GenLOV()
        dsLOV.Clear()

        daRekening = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar ", sqlconn))
        daRekening.Fill(dsLOV, "rekening")
        LOVrekening.DataSource = dsLOV.Tables("rekening")
        LOVrekening.Properties.DisplayMember = "nm_buku_besar"
        LOVrekening.Properties.ValueMember = "kd_buku_besar"

        daPusat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_pusat ", sqlconn))
        daPusat.Fill(dsLOV, "pusat")
        LOVpusat.DataSource = dsLOV.Tables("pusat")
        LOVpusat.Properties.DisplayMember = "nm_buku_pusat"
        LOVpusat.Properties.ValueMember = "kd_buku_pusat"

        daPers = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jns_Persediaan ", sqlconn))
        daPers.Fill(dsLOV, "persediaan")
        LOVpersediaan.Properties.DataSource = dsLOV.Tables("persediaan")
        LOVpersediaan.Properties.DisplayMember = "Nama_Persediaan"
        LOVpersediaan.Properties.ValueMember = "Kd_Jns_Persd"

        daBrg = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        daBrg.Fill(dsLOV, "barang")
        LOVjenisBarang.Properties.DataSource = dsLOV.Tables("barang")
        LOVjenisBarang.Properties.DisplayMember = "Nama_Jenis"
        LOVjenisBarang.Properties.ValueMember = "Kd_Jns_Brg"

        daBrg = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Gudang", sqlconn))
        daBrg.Fill(dsLOV, "gudang")
        LOVgudang.Properties.DataSource = dsLOV.Tables("gudang")
        LOVgudang.Properties.DisplayMember = "Nama_Gudang"
        LOVgudang.Properties.ValueMember = "Kode_Gudang"

        daSat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Satuan", sqlconn))
        daSat.Fill(dsLOV, "satuan")
        LOVsatuan.Properties.DataSource = dsLOV.Tables("satuan")
        LOVsatuan.Properties.DisplayMember = "Nama_Satuan"
        LOVsatuan.Properties.ValueMember = "Kode_Satuan"

        daUkur = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Ukuran ", sqlconn))
        daUkur.Fill(dsLOV, "ukuran")
        LOVukuran.Properties.DataSource = dsLOV.Tables("ukuran")
        LOVukuran.Properties.DisplayMember = "Nama_Ukuran"
        LOVukuran.Properties.ValueMember = "Kode_Ukuran"

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

    Public Sub add_click()
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = True
        btnadd = False
        btnCancel = False
        setStatus()

        GV.OptionsBehavior.ReadOnly = True
        GV.OptionsBehavior.Editable = False

    End Sub

    Public Sub edit_click()
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()

        GV.OptionsBehavior.ReadOnly = False
        GV.OptionsBehavior.Editable = True

    End Sub

    Public Sub cancel_click()
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = True
        btnadd = False
        btnCancel = False
        setStatus()

        GV.OptionsBehavior.ReadOnly = True
        GV.OptionsBehavior.Editable = False

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Sub delete_click()
        If MsgBox("Hapus data Rekening : " & GV.GetFocusedRowCellDisplayText("rek_biaya") & " , Pusat Biaya : " & GV.GetFocusedRowCellDisplayText("rek_pusat_biaya"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
            GV.DeleteSelectedRows()
            simpan()
        End If
    End Sub

    Public Sub simpan()
        For Each rw As DataRow In dsGrid.Tables("gudang").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = getKodeCabang()
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw("Kd_Cabang") = getKodeCabang()
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                rw.Item("Program_Name") = Me.Name
            End If
        Next

        Try
            Dim Builder As New SqlCommandBuilder(daGrid)

            daGrid.InsertCommand = Builder.GetInsertCommand()
            daGrid.UpdateCommand = Builder.GetUpdateCommand()
            daGrid.DeleteCommand = Builder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daGrid.UpdateCommand.Transaction = BTRANS
            daGrid.InsertCommand.Transaction = BTRANS
            daGrid.DeleteCommand.Transaction = BTRANS

            daGrid.Update(dsGrid, "gudang")

            BTRANS.Commit()

            showMessages("Data Berhasil diSimpan..", 14)
            STATE = ""
        Catch ex As Exception
            MsgBox("Kombinasi Rekening Dan Pusat Biaya Sudah Ada, Detail : " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'CLEAR
        dsGrid.Clear()
        GC.DataSource = dsGrid.Tables("gudang")
        'RELOAD
        daGrid = New SqlDataAdapter(New SqlCommand("SELECT * FROM sif.dbo.SIF_Barang", sqlconn))
        daGrid.Fill(dsGrid, "gudang")
        GC.DataSource = dsGrid.Tables("gudang")
        GV.BestFitColumns()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'CLEAR
        dsGrid.Clear()
        GC.DataSource = dsGrid.Tables("gudang")
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus data yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                    simpan()
                End If
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEeditMode.CheckedChanged
        If CEeditMode.Checked = True Then
            GV.OptionsBehavior.ReadOnly = False
            GV.OptionsBehavior.Editable = True
            btnSave = True

        Else
            GV.OptionsBehavior.ReadOnly = True
            GV.OptionsBehavior.Editable = False
            btnSave = False

        End If
        setStatus()
    End Sub

    Private Sub CCKBOXcolom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CCKBOXcolom.TextChanged

        For i As Integer = 0 To CCKBOXcolom.Properties.Items.Count - 1
            GV.Columns(i).Visible = False
        Next

        For i As Integer = 0 To CCKBOXcolom.Properties.Items.Count - 1
            If CCKBOXcolom.Properties.Items(i).CheckState = CheckState.Checked Then
                GV.Columns(i).Visible = True
            End If
        Next

    End Sub
End Class