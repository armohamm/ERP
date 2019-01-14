Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes

Public Class frmzMstBrgSub
    Dim dsData, dsColNama, dsLUE, dsPilihData, dsLoad As New DataSet
    Dim daData, daColNama, daLUE, daPilihData, daLoad As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim prn As frmMain
    Public State As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Try
        '    If dsData.Tables.Contains("data") = True Then
        '        dsData.Tables("data").Clear()
        '    End If

        '    daData = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select d.no_seq,b.kd_satuan,d.kd_barang_sub,'' as last_create_date,'' as last_created_by,'' as kd_barang,'' as keterangan,'' as rec_stat,'' as last_update_date,'' as last_updated_by,'' as program_name,'' as kd_cabang,'' as kd_departemen from sif.dbo.sif_barang_sub d, sif.dbo.sif_barang b where d.kd_barang=b.Kode_Barang and d.kd_barang='" & txtNama_Barang.EditValue & "'", sqlconn))
        '    daData.Fill(dsData, "data")

        '    gcData.DataSource = dsData.Tables("data")
        '    gcData.Enabled = True

        '    btnSave = True
        '    btnCancel = True
        '    btnDelete = True
        '    btnEdit = False
        '    btnadd = False
        '    setStatus()
        '    If dsData.Tables("data").Rows.Count > 0 Then
        '        State = "EDIT"
        '    Else
        '        State = "ADD"
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Filter_Barang(txtNama_Barang.EditValue)
    End Sub

    Sub Filter_Barang(ByVal barang As String)
        Try
            If dsData.Tables.Contains("data") = True Then
                dsData.Tables("data").Clear()
            End If

            daData = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select d.no_seq,b.kd_satuan,d.kd_barang_sub,'' as last_create_date,'' as last_created_by,'' as kd_barang,'' as keterangan,'' as rec_stat,'' as last_update_date,'' as last_updated_by,'' as program_name,'' as kd_cabang,'' as kd_departemen from sif.dbo.sif_barang_sub d, sif.dbo.sif_barang b where d.kd_barang=b.Kode_Barang and d.kd_barang='" & barang & "'", sqlconn))
            daData.Fill(dsData, "data")

            gcData.DataSource = dsData.Tables("data")
            gcData.Enabled = True

            btnSave = True
            btnCancel = True
            btnDelete = True
            btnEdit = False
            btnadd = False
            setStatus()
            If dsData.Tables("data").Rows.Count > 0 Then
                State = "EDIT"
            Else
                State = "ADD"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmzMstBrgSub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        'While Not TypeOf obj Is Form
        '    obj = obj.Parent
        'End While

        If dsData.Tables.Contains("data") = True Then
            dsData.Tables("data").Clear()
        End If
        gcData.DataSource = Nothing
        gcData.Enabled = False

        If dsLUE.Tables.Contains("barang") = True Then
            dsLUE.Tables("barang").Clear()
        End If
        daLUE = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_barang,nama_barang from sif.dbo.sif_barang", sqlconn))
        daLUE.Fill(dsLUE, "barang")
        txtNama_Barang.Properties.DataSource = dsLUE.Tables("barang")
        txtNama_Barang.Properties.ValueMember = "kode_barang"
        txtNama_Barang.Properties.DisplayMember = "nama_barang"
        If dsLUE.Tables("barang").Rows.Count > 0 Then
            txtNama_Barang.ItemIndex = 0
        End If

        daColNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_barang,nama_barang,kd_satuan from sif.dbo.sif_barang", sqlconn))
        daColNama.Fill(dsColNama, "pilihan")
        lookupbarang.DataSource = dsColNama.Tables("pilihan")
        lookupbarang.ValueMember = "kode_barang"
        lookupbarang.DisplayMember = "nama_barang"

        btnSave = False
        btnadd = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        setStatus()
    End Sub

    Private Sub gvMain_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMain.CellValueChanged
        If e.Column Is colNmBrg Then
            daPilihData = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_barang,nama_barang,kd_satuan from sif.dbo.sif_barang where kode_barang='" & e.Value & "'", sqlconn))
            daPilihData.Fill(dsPilihData, "pilih")

            'gvMain.SetRowCellValue(e.RowHandle, gvMain.Columns("kd_barang_sub"), e.Value)
            gvMain.SetRowCellValue(e.RowHandle, gvMain.Columns("kd_satuan"), dsPilihData.Tables("pilih").Rows(0).Item(2))
        End If
    End Sub

    Private Sub gvMain_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvMain.InitNewRow
        gvMain.SetRowCellValue(e.RowHandle, gvMain.Columns("no_seq"), gvMain.RowCount + 1)
    End Sub

    Public Sub save_click()
        Dim tgl As Date = getTanggal()
        If gcData.Enabled = True Then
            Try
                Dim dr As SqlDataReader
                'Dim BTRANS As SqlTransaction
                'Dim mb As New SqlCommandBuilder
                'mb = New SqlClient.SqlCommandBuilder(daLoad)
                'daLoad.UpdateCommand = mb.GetUpdateCommand()
                'daLoad.InsertCommand = mb.GetInsertCommand()
                'daLoad.DeleteCommand = mb.GetDeleteCommand()
                'BTRANS = sqlconn.BeginTransaction("1")
                'daLoad.UpdateCommand.Transaction = BTRANS
                'daLoad.InsertCommand.Transaction = BTRANS
                'daLoad.DeleteCommand.Transaction = BTRANS
                'daLoad.SelectCommand.Transaction = BTRANS

                dr = New SqlClient.SqlCommand("delete from sif.dbo.sif_barang_sub where kd_barang='" & txtNama_Barang.EditValue & "'", sqlconn).ExecuteReader
                dr.Close()

                daLoad = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_barang_sub where kd_barang='" & txtNama_Barang.EditValue & "' and 1=0", sqlconn))
                daLoad.Fill(dsLoad, "load")

                'MsgBox(dsData.Tables("data").Rows.Count)
                'MsgBox(dsLoad.Tables("load").Rows.Count)
                For Each rows As DataRow In dsData.Tables("data").Rows
                    Dim nRow As DataRow
                    'If rows.RowState = DataRowState.Added Then
                    nRow = dsLoad.Tables("load").NewRow
                    nRow("last_create_date") = tgl
                    nRow("last_created_by") = username
                    nRow("kd_barang") = txtNama_Barang.EditValue
                    nRow("no_seq") = rows("no_seq")
                    nRow("kd_barang_sub") = rows("kd_barang_sub")
                    nRow("keterangan") = ""
                    nRow("rec_stat") = "Y"
                    nRow("last_update_date") = tgl
                    nRow("last_updated_by") = username
                    nRow("program_name") = Me.Name
                    nRow("kd_cabang") = kdcabang
                    nRow("kd_departemen") = kddep

                    dsLoad.Tables("load").Rows.Add(nRow)
                    'ElseIf rows.RowState = DataRowState.Modified Then
                    '    nRow = rows
                    '    nRow("last_create_date") = tgl
                    '    nRow("last_created_by") = username
                    '    nRow("kd_barang") = txtNama_Barang.EditValue
                    '    nRow("no_seq") = rows("no_seq")
                    '    nRow("kd_barang_sub") = rows("kd_barang_sub")
                    '    nRow("keterangan") = ""
                    '    nRow("rec_stat") = "Y"
                    '    nRow("last_update_date") = tgl
                    '    nRow("last_updated_by") = username
                    '    nRow("program_name") = Me.Name
                    '    nRow("kd_cabang") = kdcabang
                    '    nRow("kd_departemen") = kddep
                    'ElseIf rows.RowState = DataRowState.Deleted Then
                    'nRow = rows
                    'MsgBox(rows.Item("kd_barang_sub"))
                    'dsLoad.Tables("load").Rows.Remove(dsLoad.Tables("load").Select("kd_barang_sub='" & nRow("kd_barang_sub") & "'")(0))
                    'dsData.Tables("data").Rows.Remove(nRow)
                    'End If
                Next
                'MsgBox(dsData.Tables("data").Rows.Count)
                'MsgBox(dsLoad.Tables("load").Rows.Count)

                Dim mybuilder As New SqlCommandBuilder(daLoad)
                daLoad.UpdateCommand = mybuilder.GetUpdateCommand
                daLoad.Update(dsLoad.Tables("load"))
                dsLoad.Tables("load").AcceptChanges()
                showMessages("Saved..")

                frmzMstBrgSub_Load(Me, Nothing)
            Catch e As Exception
                MessageBox.Show("Data Sudah ada" & vbCrLf & e.Message)
            End Try
        Else
            MessageBox.Show("Pilih Barang Terlebih Dahulu!")
        End If
    End Sub

    Public Sub add_click()
    End Sub

    Public Sub edit_click()
    End Sub

    Public Sub delete_click()
        If gvMain.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                gvMain.DeleteSelectedRows()
                dsData.Tables("data").AcceptChanges()
                Dim counter As Integer = 1
                For i As Integer = 0 To dsData.Tables("data").Rows.Count - 1
                    If dsData.Tables("data").Rows(i).RowState <> DataRowState.Deleted Then
                        dsData.Tables("data").Rows(i).Item("no_seq") = counter
                        counter += 1
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub cancel_click()
        txtNama_Barang.EditValue = vbNullString
        If dsData.Tables.Contains("data") = True Then
            dsData.Tables("data").Clear()
        End If
        gcData.DataSource = Nothing
        gcData.Enabled = False
        If dsLUE.Tables("barang").Rows.Count > 0 Then
            txtNama_Barang.ItemIndex = 0
        End If

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

        State = "CANCEL"
    End Sub

    Private Sub txtNama_Barang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNama_Barang.EditValueChanged
        'If dsData.Tables.Contains("data") = True Then
        '    dsData.Tables("data").Clear()
        'End If
        'gcData.DataSource = Nothing
        'gcData.Enabled = False
        Filter_Barang(txtNama_Barang.EditValue)
    End Sub

    Private Sub gvMain_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvMain.ValidateRow

        Dim isValid As Boolean = True

        Dim rw() As DataRow = dsData.Tables("data").Select("kd_barang_sub = '" & e.Row.item("kd_barang_sub") & "' ")

        If rw.Count = 1 Then


            isValid = False


            'y = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            gvMain.SetColumnError(colNmBrg, "Barang sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Barang sudah ada dalam daftar.")


        End If

        'If e.Row.item("kd_tipe").ToString = "" Then
        '    isValid = False
        '    Dim k As Object

        '    k = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        '    k.SetColumnError(kd_tipe, "Tipe tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    MessageBox.Show("Tipe tidak boleh kosong.")
        'End If

        'If e.Row.item("kd_ukuran").ToString = "" Then
        '    isValid = False
        '    Dim l As Object

        '    l = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        '    l.SetColumnError(kd_ukuran, "Ukuran tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    MessageBox.Show("Ukuran tidak boleh kosong.")

        'End If

        'If e.Row.item("nilai_konv").ToString = "" Then
        '    isValid = False
        '    Dim j As Object
        '    j = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

        '    j.SetColumnError(nilai_konv, "Kolom Nilai harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If


        e.Valid = isValid

    End Sub
End Class
