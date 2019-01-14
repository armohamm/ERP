Imports System.Data.SqlClient
Public Class frmMstHPPFin
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnAdd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Dim qstr As String = "select DISTINCT(P.kd_bom) as KODE, S.nama_bom as NAMA " & _
                "from PROD.dbo.prod_hpp_m as P " & _
                "left join SIF.dbo.SIF_bom as S " & _
                "on P.kd_bom = S.kd_bom " & _
                "order by NAMA"
        da1 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
        da1.Fill(ds1, "BOM")
        da1 = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar order by nm_buku_besar", sqlconn))
        da1.Fill(ds1, "Rekening")

        txtBOM.Properties.DataSource = ds1.Tables("BOM")
        lkRekening.DataSource = ds1.Tables("Rekening")
        gView.OptionsView.NewItemRowPosition = 0
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_biaya where 1=0", sqlconn))
        da2.Fill(ds2, "dtlBiaya")
        AddHandler ds2.Tables("dtlBiaya").RowDeleted, AddressOf refreshNomer
    End Sub
    Private Sub txtBOM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBOM.EditValueChanged
        gView.OptionsView.NewItemRowPosition = 1
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_biaya where kd_bom = '" & txtBOM.EditValue & "' order by no_urut", sqlconn))
        ds2.Clear()
        da2.Fill(ds2, "dtlBiaya")
        gControl.DataSource = ds2.Tables("dtlBiaya")
    End Sub
    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
        gView.GetRow(e.RowHandle).item("no_urut") = gView.RowCount + 1
    End Sub

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("no_urut") = i
                i += 1
            End If
        Next
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kd_rek").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmRekening, "Kolom Keterangan harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        e.Valid = isValid
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gView.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    gView.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Public Sub add_click()
        txtBOM.EditValue = vbNullString
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        State = "EDIT"
        Dim qstr As String = "select DISTINCT(P.kd_bom) as KODE, S.nama_bom as NAMA " & _
                "from PROD.dbo.prod_hpp_m as P " & _
                "left join SIF.dbo.SIF_bom as S " & _
                "on P.kd_bom = S.kd_bom " & _
                "order by NAMA"
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            gView.OptionsView.NewItemRowPosition = 1
            txtBOM.EditValue = frmCari.row("KODE")
            
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
        If txtBOM.EditValue <> "" Then
            Try
                For Each rows As DataRow In ds2.Tables("dtlBiaya").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("kd_bom") = txtBOM.EditValue

                    End If
                    'rows.Item("Programe_name") = Me.Name
                Next

                Dim mybuilder As New SqlCommandBuilder(da2)
                da2.UpdateCommand = mybuilder.GetUpdateCommand
                da2.Update(ds2.Tables("dtlBiaya"))
                ds2.Tables("dtlBiaya").AcceptChanges()
                showMessages("Data Berhasil Disimpan")
            Catch err As Exception
                MessageBox.Show(err.Message, "Gagal Simpan")
            End Try

        Else
            MessageBox.Show("Pilih Jenis Bill Of Material Terlebih Dahulu!")
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            For Each dr As DataRow In ds2.Tables("dtlBiaya").Rows
                dr.Delete()
            Next
            Dim mybuilder2 As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder2.GetUpdateCommand
            da2.Update(ds2.Tables("dtlBiaya"))
            ds2.Tables("dtlBiaya").AcceptChanges()
            showMessages("Data Berhasil Dihapus")
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
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
End Class