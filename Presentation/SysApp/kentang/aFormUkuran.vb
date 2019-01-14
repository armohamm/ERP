Imports System.Data.SqlClient

Public Class aFormUkuran
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsUkuran As New DataSet
    Dim state, err, kodeUkuran, kombinasi As String
    Dim daUkuran, daIsiUkuran As SqlDataAdapter
    Dim drUkuran As SqlDataReader
    Dim bldUkuran As New SqlCommandBuilder
    Dim isValid As Boolean
    Dim row As DataRow
    Dim BTRANS As SqlTransaction

    Private Function getNextNumber() As String
        Dim hasil, temp As String
        drUkuran = New SqlCommand("SELECT MAX(u.Kode_Ukuran)+1 FROM SIF.dbo.SIF_Ukuran u", sqlconn).ExecuteReader
        drUkuran.Read()
        temp = ""
        If TypeOf drUkuran.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = drUkuran.Item(0)
            For i As Int16 = CInt(Len(hasil)) To 2
                temp = "0" & temp
            Next
            hasil = temp & hasil
        End If
        drUkuran.Close()
        Return hasil
    End Function

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cancel_click()
        txtKode.EditValue = vbNullString
        txtAlias.EditValue = vbNullString
        txtTinggi.EditValue = vbNullString
        txtLebar.EditValue = vbNullString
        txtPanjang.EditValue = vbNullString
        txtNama.EditValue = vbNullString
        state = "ADD"
    End Sub

    Private Sub aFormUkuran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Me.Enabled = True
        prn = getParent(Me)
        loadDataset("XXX")
        loadGrid()
        state = "ADD"
        txtTinggi.EditValue = 0
        txtLebar.EditValue = 0
        txtPanjang.EditValue = 0
    End Sub

    Private Sub loadGrid()
        If Not dsUkuran.Tables("ListUkuran") Is Nothing Then dsUkuran.Tables("ListUkuran").Clear()
        daIsiUkuran = New SqlDataAdapter(New SqlCommand("SELECT Kode_Ukuran, Nama_Ukuran, Alias, Tinggi, Lebar, Panjang, Keterangan FROM SIF.dbo.SIF_Ukuran", sqlconn))
        daIsiUkuran.Fill(dsUkuran, "ListUkuran")
        gcUkuran.DataSource = dsUkuran.Tables("ListUkuran")
        gvUkuran.BestFitColumns()
    End Sub

    Private Sub loadDataset(ByVal kode As String)
        If Not dsUkuran.Tables("Ukuran") Is Nothing Then dsUkuran.Tables("Ukuran").Clear()
        daUkuran = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Ukuran WHERE Kode_Ukuran='" & kode & "'", sqlconn))
        daUkuran.Fill(dsUkuran, "Ukuran")

        If dsUkuran.Tables("Ukuran").Rows.Count > 0 Then
            txtKode.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Kode_Ukuran")
            txtNama.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Nama_Ukuran")
            txtAlias.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Alias")
            txtLebar.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Lebar")
            txtTinggi.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Tinggi")
            txtPanjang.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Panjang")
            txtKeterangan.EditValue = dsUkuran.Tables("Ukuran").Rows(0).Item("Keterangan")
        End If
    End Sub

    Private Sub namaUkuran()
        If Not (txtTinggi.EditValue = vbNullString Or txtTinggi.EditValue = "0") Then
            txtNama.EditValue = Val(txtTinggi.EditValue)
            If Not (txtLebar.EditValue = vbNullString Or txtLebar.EditValue = "0") Then
                txtNama.EditValue &= " X " & Val(txtLebar.EditValue)
            Else
                txtNama.EditValue &= ""
            End If
            If Not (txtPanjang.EditValue = vbNullString Or txtPanjang.EditValue = "0") Then
                txtNama.EditValue &= " X " & Val(txtPanjang.EditValue)
            Else
                txtNama.EditValue &= ""
            End If
        ElseIf Not (txtLebar.EditValue = vbNullString Or txtLebar.EditValue = "0") Then
            txtNama.EditValue = Val(txtLebar.EditValue)
            If Not (txtTinggi.EditValue = vbNullString Or txtTinggi.EditValue = "0") Then
                txtNama.EditValue = Val(txtTinggi.EditValue) & " X " & Val(txtLebar.EditValue)
            End If
            If Not (txtPanjang.EditValue = vbNullString Or txtPanjang.EditValue = "0") Then
                txtNama.EditValue &= " X " & Val(txtPanjang.EditValue)
            Else
                txtNama.EditValue &= ""
            End If
        ElseIf Not (txtPanjang.EditValue = vbNullString Or txtPanjang.EditValue = "0") Then
            txtNama.EditValue = Val(txtPanjang.EditValue)
            If Not (txtTinggi.EditValue = vbNullString Or txtTinggi.EditValue = "0") Then
                txtNama.EditValue = Val(txtTinggi.EditValue) & " X " & Val(txtPanjang.EditValue)
            ElseIf Not (txtLebar.EditValue = vbNullString Or txtLebar.EditValue = "0") Then
                txtNama.EditValue = Val(txtTinggi.EditValue) & " X " & Val(txtLebar.EditValue) & " X " & Val(txtPanjang.EditValue)
            End If
        End If
    End Sub

    Private Sub cek()
        If state = "ADD" Then
            Dim sql As String = "SELECT count(1) FROM SIF.dbo.SIF_Ukuran WHERE Tinggi= @T AND Lebar=@L AND Panjang=@P"
            Dim cmd As New SqlCommand(sql, sqlconn)
            cmd.Parameters.Add("@T", SqlDbType.Decimal).Value = txtTinggi.EditValue
            cmd.Parameters.Add("@L", SqlDbType.Decimal).Value = txtLebar.EditValue
            cmd.Parameters.Add("@P", SqlDbType.Decimal).Value = txtPanjang.EditValue
            drUkuran = cmd.ExecuteReader
            drUkuran.Read()
        ElseIf state = "EDIT" Then
            Dim sql As String = "SELECT count(1) FROM SIF.dbo.SIF_Ukuran WHERE Tinggi= @T AND Lebar=@L AND Panjang=@P AND Kode_Ukuran <> @Kd_Ukuran"
            Dim cmd As New SqlCommand(sql, sqlconn)
            cmd.Parameters.Add("@T", SqlDbType.Decimal).Value = txtTinggi.EditValue
            cmd.Parameters.Add("@L", SqlDbType.Decimal).Value = txtLebar.EditValue
            cmd.Parameters.Add("@P", SqlDbType.Decimal).Value = txtPanjang.EditValue
            cmd.Parameters.Add("@Kd_Ukuran", SqlDbType.Decimal).Value = txtKode.Text
            drUkuran = cmd.ExecuteReader
            drUkuran.Read()
        End If
       
        If drUkuran.Item(0) = 1 Then
            isValid = False
            err &= "Kombinasi tebal, lebar dan panjang ukuran sudah ada." & vbCrLf
            If txtNama.EditValue = vbNullString Then
                err &= "Nama ukuran tidak boleh kosong." & vbCrLf
            End If
            If txtTinggi.EditValue = 0 And txtLebar.EditValue = 0 And txtPanjang.EditValue = 0 Then
                err &= "Tebal, lebar dan panjang tidak boleh kosong semua." & vbCrLf
            End If
        ElseIf txtNama.EditValue = vbNullString Then
            isValid = False
            err &= "Nama ukuran tidak boleh kosong." & vbCrLf
            If txtTinggi.EditValue = 0 And txtLebar.EditValue = 0 And txtPanjang.EditValue = 0 Then
                err &= "Tebal, lebar dan panjang tidak boleh kosong semua." & vbCrLf
            End If
            If drUkuran.Item(0) = 1 Then
                err &= "Kombinasi tebal, lebar dan panjang ukuran sudah ada." & vbCrLf
            End If
        ElseIf txtTinggi.EditValue = 0 And txtLebar.EditValue = 0 And txtPanjang.EditValue = 0 Then
            isValid = False
            err &= "Tebal, lebar dan panjang tidak boleh kosong semua." & vbCrLf
            If txtNama.EditValue = vbNullString Then
                err &= "Nama ukuran tidak boleh kosong." & vbCrLf
            End If
            If drUkuran.Item(0) = 1 Then
                err &= "Kombinasi tebal, lebar dan panjang ukuran sudah ada." & vbCrLf
            End If
        Else
            isValid = True
            err = ""
        End If
        drUkuran.Close()
    End Sub

    Public Sub save_click()
        cek()
        If isValid Then
            If state = "ADD" Then
                txtKode.EditValue = getNextNumber()
                kodeUkuran = txtKode.EditValue
                row = dsUkuran.Tables("Ukuran").NewRow
                row.Item("Kd_Cabang") = getKodeCabang()
                row.Item("Kode_Ukuran") = txtKode.EditValue
                row.Item("Nama_Ukuran") = txtNama.EditValue
                row.Item("Tinggi") = txtTinggi.EditValue
                row.Item("Lebar") = txtLebar.EditValue
                row.Item("Panjang") = txtPanjang.EditValue
                row.Item("Alias") = txtAlias.EditValue
                row.Item("Keterangan") = txtKeterangan.EditValue
                row.Item("Rec_Stat") = "Y"
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = umum.username
                row.Item("Program_Name") = Me.Name
                dsUkuran.Tables("Ukuran").Rows.Add(row)
            ElseIf state = "EDIT" Then
                row = dsUkuran.Tables("Ukuran").Rows(0)
                row.Item("Tinggi") = txtTinggi.EditValue
                row.Item("Nama_Ukuran") = txtNama.EditValue
                row.Item("Lebar") = txtLebar.EditValue
                row.Item("Panjang") = txtPanjang.EditValue
                row.Item("Alias") = txtAlias.EditValue
                row.Item("Keterangan") = txtKeterangan.EditValue
                row.Item("Rec_Stat") = "Y"
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = umum.username
            End If

            Try
                bldUkuran = New SqlCommandBuilder(daUkuran)
                daUkuran.UpdateCommand = bldUkuran.GetUpdateCommand()
                daUkuran.InsertCommand = bldUkuran.GetInsertCommand()
                daUkuran.DeleteCommand = bldUkuran.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daUkuran.UpdateCommand.Transaction = BTRANS
                daUkuran.InsertCommand.Transaction = BTRANS
                daUkuran.DeleteCommand.Transaction = BTRANS

                daUkuran.Update(dsUkuran.Tables("Ukuran"))

                'dsUkuran.Tables("Ukuran").AcceptChanges()

                BTRANS.Commit()

                showMessages("Berhasil disimpan..")
                err = ""
                If state = "ADD" Then
                    state = "EDIT"
                ElseIf state = "EDIT" Then
                    state = "ADD"
                End If
                loadDataset(kodeUkuran)
                loadGrid()
            Catch ex As Exception
                BTRANS.Rollback()
                dsUkuran.Tables("Ukuran").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        Else
            MsgBox("Ada kesalahan dalam mengisi data :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            Exit Sub
        End If
    End Sub

    Private Sub tacUkuran_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tacUkuran.SelectedPageChanged
        If e.Page.Name = "tabForm" Then
            btnSave = True
            btnCancel = True
            setStatus()
        Else
            btnSave = False
            btnCancel = False
            setStatus()
        End If
    End Sub

    Private Sub gvUkuran_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvUkuran.DoubleClick
        state = "EDIT"
        loadDataset(gvUkuran.GetFocusedRowCellValue("Kode_Ukuran").ToString)
        tacUkuran.SelectedTabPage = tabForm
    End Sub

    Private Sub txtTinggi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTinggi.EditValueChanged
        If txtTinggi.EditValue = vbNullString Then
            txtTinggi.EditValue = 0
        End If
        namaUkuran()
    End Sub

    Private Sub txtTinggi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTinggi.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 44, 46, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtLebar_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLebar.EditValueChanged
        If txtLebar.EditValue = vbNullString Then
            txtLebar.EditValue = 0
        End If
        namaUkuran()
    End Sub

    Private Sub txtLebar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLebar.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 44, 46, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPanjang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPanjang.EditValueChanged
        If txtPanjang.EditValue = vbNullString Then
            txtPanjang.EditValue = 0
        End If
        namaUkuran()
    End Sub

    Private Sub txtPanjang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPanjang.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 44, 46, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub
End Class