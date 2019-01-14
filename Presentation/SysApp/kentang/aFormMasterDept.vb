Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormMasterDept
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim bldDept, bldBagian As New SqlCommandBuilder
    Dim dsDeptBag, dsPost As New DataSet
    Dim daDept, daBag, daLookUp, daPost, daDetil As SqlDataAdapter
    Dim drDept As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim row As DataRow
    Dim noDept As String
    Dim rl As DataRelation

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub clear()
        txtNoDept.EditValue = vbNullString
        txtNamaDept.EditValue = vbNullString
        cmbStatus.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
        lckRek.EditValue = vbNullString
        If Not dsDeptBag.Tables("Bagian") Is Nothing Then dsDeptBag.Tables("Bagian").Clear()
    End Sub

    Private Sub loadList()
        dsPost = New DataSet
        daPost = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Departemen", sqlconn))
        daPost.Fill(dsPost, "LookDepartemen")
        daDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Bagian", sqlconn))
        daDetil.Fill(dsPost, "LookBagian")
        rl = dsPost.Relations.Add("DetailDeptBag", dsPost.Tables("LookDepartemen").Columns("Kd_Departemen"), dsPost.Tables("LookBagian").Columns("Kd_Departemen"))
        gcList.DataSource = dsPost.Tables("LookDepartemen")
        gcList.LevelTree.Nodes.Add("DetailDeptBag", gvListBag)
        gvListDept.BestFitColumns()
        gvListBag.BestFitColumns()
    End Sub

    Private Sub loadLookUp()
        If Not dsDeptBag.Tables("Rekening") Is Nothing Then dsDeptBag.Tables("Rekening").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select kd_buku_pusat, nm_buku_pusat from SIF.dbo.SIF_buku_pusat", sqlconn))
        daLookUp.Fill(dsDeptBag, "Rekening")
        lckRek.Properties.DataSource = dsDeptBag.Tables("Rekening")
        lckRek.Properties.DisplayMember = "nm_buku_pusat"
        lckRek.Properties.ValueMember = "kd_buku_pusat"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsDeptBag.Tables("Departemen") Is Nothing Then dsDeptBag.Tables("Departemen").Clear()
        If Not dsDeptBag.Tables("Bagian") Is Nothing Then dsDeptBag.Tables("Bagian").Clear()

        daDept = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Departemen where Kd_Departemen = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daDept.Fill(dsDeptBag, "Departemen")
        daBag = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Bagian where Kd_Departemen = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daBag.Fill(dsDeptBag, "Bagian")
        gcBagian.DataSource = dsDeptBag.Tables("Bagian")
        gvBagian.BestFitColumns()

        If dsDeptBag.Tables("Departemen").Rows.Count >= 1 Then
            txtNoDept.EditValue = dsDeptBag.Tables("Departemen").Rows(0).Item("Kd_Departemen")
            txtNamaDept.EditValue = dsDeptBag.Tables("Departemen").Rows(0).Item("Nama_Departemen")
            lckRek.EditValue = dsDeptBag.Tables("Departemen").Rows(0).Item("Rek_Pusat_Biaya")
            cmbStatus.EditValue = IIf(dsDeptBag.Tables("Departemen").Rows(0).Item("Rec_Stat") = "Y", "AKTIF", "TIDAK AKTIF")
            txtKeterangan.EditValue = dsDeptBag.Tables("Departemen").Rows(0).Item("Keterangan")
            btnAdd = False
            btnCancel = True
            btnDelete = True
            btnEdit = False
            btnSave = True
            setStatus()
        End If
        loadAC()
    End Sub

    Private Sub loadAC()
        If Not dsDeptBag.Tables("NamaDepartemen") Is Nothing Then dsDeptBag.Tables("NamaDepartemen").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("select Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        daLookUp.Fill(dsDeptBag, "NamaDepartemen")
        For Each row As DataRow In dsDeptBag.Tables("NamaDepartemen").Rows
            txtNamaDept.Properties.Items.Add(row("Nama_Departemen").ToString)
        Next
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If gvBagian.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvBagian.RowCount - 1
                gvBagian.GetDataRow(j).Item("Kode_Bagian") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub aFormMasterDept_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        STATE = "ADD"
        loadList()
        loadLookUp()
        loadData("xxx")
        Me.Enabled = True
        XtraTabControl1.SelectedTabPage = tabList
    End Sub

    Public Sub cetak_click()
        MsgBox("Tidak dipakai.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO!")
    End Sub

    Public Sub cancel_click()
        btnAdd = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = True
        setStatus()
        clear()
        STATE = "ADD"
        loadData("xxx")
        noDept = ""
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Departemen " & txtNamaDept.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS") = MsgBoxResult.Yes Then
            If Not dsDeptBag.Tables("Departemen") Is Nothing Then
                For Each rw As DataRow In dsDeptBag.Tables("Departemen").Rows
                    rw.Delete()
                Next
            End If
            If Not dsDeptBag.Tables("Bagian") Is Nothing Then
                For Each rw As DataRow In dsDeptBag.Tables("Bagian").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
        End If
    End Sub

    Private Sub cek()
        isvalid = True

        If txtNamaDept.Text = "" Then
            errDept.SetError(txtNamaDept, "Nama Departemen belum diisi!")
            txtNamaDept.Focus()
            isvalid = False
        Else
            errDept.SetError(txtNamaDept, "")
        End If

        If Not STATE = "EDIT" Then
            For Each rows In dsDeptBag.Tables("NamaDepartemen").Rows
                If txtNamaDept.EditValue.Equals(rows("Nama_Departemen")) Then
                    errDept.SetError(txtNamaDept, "Nama Departemen sudah ada!")
                    txtNamaDept.Focus()
                    isvalid = False
                    Exit For
                Else
                    errDept.SetError(txtNamaDept, "")
                End If
            Next

            drDept = New SqlCommand("select count(Nama_Departemen) as number from SIF.dbo.SIF_Departemen where Nama_Departemen like '%" & txtNamaDept.EditValue & "%'", sqlconn).ExecuteReader
            drDept.Read()
            If drDept.Item(0) > 0 Then
                errDept.SetError(txtNamaDept, "Nama Departemen sudah ada!")
                txtNamaDept.Focus()
                isvalid = False
            Else
                errDept.SetError(txtNamaDept, "")
            End If
            drDept.Close()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        cek()

        If Not isvalid = False Then
            If Not isDelete Then
                If STATE = "ADD" Then
                    row = dsDeptBag.Tables("Departemen").NewRow
                    drDept = New SqlCommand("select MAX(cast(Kd_Departemen as numeric)+1) from SIF.dbo.SIF_Departemen", sqlconn).ExecuteReader
                    drDept.Read()
                    noDept = drDept.Item(0)
                    drDept.Close()
                    row("Kd_Departemen") = noDept
                ElseIf STATE = "EDIT" Then
                    row = dsDeptBag.Tables("Departemen").Rows(0)
                End If

                row("Kd_Cabang") = getKodeCabang()
                row("Nama_Departemen") = txtNamaDept.EditValue
                row("Keterangan") = txtKeterangan.EditValue
                row("Rec_Stat") = IIf(cmbStatus.EditValue = "AKTIF", "Y", "T")
                row("Rek_Pusat_Biaya") = lckRek.EditValue
                row("Last_Create_Date") = getTanggal()
                row("Last_Created_By") = username
                row("Program_Name") = Me.Name

                If STATE = "ADD" Then
                    dsDeptBag.Tables("Departemen").Rows.Add(row)
                End If

                If Not gvBagian.RowCount = 0 Then
                    For Each rw As DataRow In dsDeptBag.Tables("Bagian").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw.Item("Kd_Cabang") = getKodeCabang()
                            rw.Item("Kd_Departemen") = IIf(txtNoDept.EditValue = vbNullString, noDept, txtNoDept.EditValue)
                            rw.Item("Rec_Stat") = "Y"
                            rw.Item("Last_Create_Date") = getTanggal()
                            rw.Item("Last_Created_By") = username
                            rw.Item("Program_Name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Added Then
                            rw.Item("Last_Update_Date") = getTanggal()
                            rw.Item("Last_Updated_By") = username
                        End If
                    Next
                End If
            End If

            Try
                bldDept = New SqlCommandBuilder(daDept)
                daDept.UpdateCommand = bldDept.GetUpdateCommand()
                daDept.InsertCommand = bldDept.GetInsertCommand()
                daDept.DeleteCommand = bldDept.GetDeleteCommand()

                If Not gvBagian.RowCount = 0 Then
                    bldBagian = New SqlCommandBuilder(daBag)
                    daBag.UpdateCommand = bldBagian.GetUpdateCommand()
                    daBag.InsertCommand = bldBagian.GetInsertCommand()
                    daBag.DeleteCommand = bldBagian.GetDeleteCommand()
                End If

                BTRANS = sqlconn.BeginTransaction("1")
                daDept.UpdateCommand.Transaction = BTRANS
                daDept.InsertCommand.Transaction = BTRANS
                daDept.DeleteCommand.Transaction = BTRANS

                daDept.Update(dsDeptBag.Tables("Departemen"))
                dsDeptBag.Tables("Departemen").AcceptChanges()

                If Not gvBagian.RowCount = 0 Then
                    daBag.UpdateCommand.Transaction = BTRANS
                    daBag.InsertCommand.Transaction = BTRANS
                    daBag.DeleteCommand.Transaction = BTRANS

                    daBag.Update(dsDeptBag.Tables("Bagian"))
                    dsDeptBag.Tables("Bagian").AcceptChanges()
                End If

                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                isvalid = False
                If isDelete = True Then
                    cancel_click()
                    loadList()
                Else
                    loadData(noDept)
                    loadList()
                End If
            Catch e As Exception
                BTRANS.Rollback()
                dsDeptBag.Tables("Departemen").RejectChanges()
                If Not gvBagian.RowCount < 0 Then
                    dsDeptBag.Tables("Bagian").RejectChanges()
                End If
                MsgBox(e.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
            End Try
        End If
    End Sub

    Private Sub gcBagian_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcBagian.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvBagian.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus bagian departemen yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS") = MsgBoxResult.Yes Then
                    gvBagian.DeleteSelectedRows()
                    refreshNomer()
                End If
            End If
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If e.Page.Name = "tabForm" Then
            btnSave = True
            btnCancel = True
            setStatus()
        Else
            btnSave = False
            btnCancel = False
            btnDelete = False
            setStatus()
        End If
    End Sub

    Private Sub gvBagian_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvBagian.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("Kode_Bagian"), gvBagian.RowCount + 1)
    End Sub

    Private Sub gcList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gcList.DoubleClick
        loadData(gvListDept.GetRow(gvListDept.GetSelectedRows(0)).Item("Kd_Departemen").ToString)
        STATE = "EDIT"
        XtraTabControl1.SelectedTabPage = tabForm
    End Sub
End Class