'|---------------------------
'|  CREATED BY RENDY        |
'|  EDITED BY RENDY         |
'|---------------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Public Class frmSetBebanPusBiaya

    Dim BTRANS As SqlTransaction

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public STATE As String
    Dim row As DataRow
    Public prn As frmMain
    Dim dsLOV, dsGrid As New DataSet
    Dim daGrid, daRekening, daPusat As SqlClient.SqlDataAdapter

    Private Sub frmSetBebanPusBiaya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        daGrid = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_MST_PSTBY_TAKLANGSUNG", sqlconn))
        daGrid.Fill(dsGrid, "BebanPusat")
        GC.DataSource = dsGrid.Tables("BebanPusat")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        GenLOV()
    End Sub

    Sub GenLOV()
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

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()

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
        For Each rw As DataRow In dsGrid.Tables("BebanPusat").Rows
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

            daGrid.Update(dsGrid, "BebanPusat")

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
        GC.DataSource = dsGrid.Tables("BebanPusat")
        'RELOAD
        daGrid = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_MST_PSTBY_TAKLANGSUNG", sqlconn))
        daGrid.Fill(dsGrid, "BebanPusat")
        GC.DataSource = dsGrid.Tables("BebanPusat")
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'CLEAR
        dsGrid.Clear()
        GC.DataSource = dsGrid.Tables("BebanPusat")
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus data yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                    simpan()
                End If
            End If
        End If
    End Sub

End Class