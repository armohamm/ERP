Imports System.Data.SqlClient
Public Class frmMstMesin
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmMstMesin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        
    End Sub
    

    Public Sub add_click()
        If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_mesin_prod order by kd_mesin ", sqlconn))
        da1.Fill(ds1, "mesin")
        GC.DataSource = ds1.Tables("mesin")
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select columns as [] " & _
                "from SIF.dbo.table "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then


            State = "EDIT"
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If
    End Sub

    Public Sub save_click()
        Try
            Dim tgl As Date = getTanggal()
            For Each rows As DataRow In ds1.Tables("mesin").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("last_create_date") = tgl
                        rows.Item("last_created_by") = username
                    End If
                    rows.Item("last_update_date") = tgl
                    rows.Item("last_updated_by") = username
                    rows.Item("program_name") = Me.Name
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("kd_departemen") = kddep
                End If
            Next
            Dim mybuilder As New SqlCommandBuilder(da1)
            da1.UpdateCommand = mybuilder.GetUpdateCommand
            da1.Update(ds1.Tables("mesin"))
            ds1.Tables("mesin").AcceptChanges()
            showMessages("Data Berhasil Disimpan")
        Catch err As Exception
            MessageBox.Show(err.Message, "Gagal Simpan")
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then

            GV.DeleteSelectedRows()
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        'If e.Row.item("Jumlah").ToString = "" Then
        '    isValid = False
        '    gView.SetColumnError(clmJumlah, "Kolom Jumlah harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If
        Dim rw() As DataRow = ds1.Tables("mesin").Select("kd_mesin = '" & e.Row.item("kd_mesin") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV.SetColumnError(clKode, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
End Class