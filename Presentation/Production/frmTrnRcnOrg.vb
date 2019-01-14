Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmTrnRcnOrg
    Dim ds1, ds2, ds3, ds4, dsedit As New DataSet
    Dim da1, da2, da3, da4, daedit As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State, kode As String
    Public kode1 As Date



    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    

    Private Sub frmTrnRcnOrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ' and ref_role= 'PROD' order by Desc_Data", sqlconn))
        da1.Fill(ds1, "jdwKerja")

        da4 = New SqlClient.SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTSPK' order by Desc_Data", sqlconn))
        da4.Fill(ds4, "jnsKeg")
        lkKegiatan.DataSource = ds4.Tables("jnsKeg")
        lkKegiatan.DisplayMember = "Desc_Data"
        lkKegiatan.ValueMember = "Id_Data"

        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_org where tanggal= '" & Format(tanggal.EditValue, "yyyy-MM-dd") & "' and kd_jadwal= '" & txtjadwal.EditValue & "'   ", sqlconn))
        da2.Fill(ds2, "msterkegiatan")
        gControl.DataSource = ds2.Tables("msterkegiatan")

        da3 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='GRPKERJA' order by Id_Data", sqlconn))
        da3.Fill(ds3, "group")
        lkGroup.DataSource = ds3.Tables("group")
        lkGroup.DisplayMember = "Desc_Data"
        lkGroup.ValueMember = "Id_Data"

        tanggal.EditValue = Now

        txtjadwal.Properties.DataSource = ds1.Tables("jdwKerja")
        txtjadwal.Properties.ValueMember = "Id_Data"
        txtjadwal.Properties.DisplayMember = "Desc_Data"

        

    End Sub


    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isValid As Boolean = True

        Dim rw() As DataRow = ds2.Tables("msterkegiatan").Select("kd_kegiatan = '" & e.Row.item("kd_kegiatan") & "' and kd_group_kerja= '" & e.Row.item("kd_group_kerja") & "'")

        If rw.Count = 1 Then
            isValid = False

            Dim y As Object

            y = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            y.SetColumnError(kd_kegiatan, "Kegiatan sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Kegiatan sudah ada dalam daftar.")
            Dim x As Object
            x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.SetColumnError(kd_group_kerja, "Grup Kerja sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Grup Kerja sudah ada dalam daftar.")


        End If


        If e.Row.item("jumlah").ToString = "" Then
            isValid = False
            gView.SetColumnError(jumlah, "Nilai harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        tanggal.EditValue = Now
        setStatus()

    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)


        If Not isDelete Then
            If State = "ADD" Then

                For Each rows As DataRow In ds2.Tables("msterkegiatan").Rows

                    If rows.RowState = DataRowState.Added Then

                        'rows.Item("tanggal") = Format(tanggal.EditValue, "dd/MM/yyyy")
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = username
                        rows.Item("Last_Created_By") = username
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                        rows.Item("program_name") = Me.Name
                        rows.Item("rec_stat") = "Y"
                        rows.Item("kd_cabang") = getKodeCabang()
                        rows.Item("kd_departemen") = kddep
                    Else
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                    End If


                Next
            ElseIf State = "EDIT" Then
                For Each rows As DataRow In ds2.Tables("msterkegiatan").Rows
                    If rows.RowState = DataRowState.Added Then


                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = username
                        rows.Item("Last_Created_By") = username
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                        rows.Item("program_name") = Me.Name
                        rows.Item("rec_stat") = "Y"
                        rows.Item("kd_cabang") = getKodeCabang()
                        rows.Item("kd_departemen") = kddep
                    Else
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                        rows.Item("tanggal") = tanggal.EditValue
                        rows.Item("kd_jadwal") = txtjadwal.EditValue
                    End If
                Next

            End If
        End If
        Try

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()




            da2.Update(ds2.Tables("msterkegiatan"))


            ds2.Tables("msterkegiatan").AcceptChanges()


            State = "EDIT"

            showMessages("Saved..")
            gControl.DataSource = ds2.Tables("msterkegiatan")

        Catch e As Exception

            ds2.Tables("msterkegiatan").RejectChanges() ' untuk membatalkan row yg diupdate/insert

            MessageBox.Show("Gagal Simpan Data Sudah Ada")


        End Try

    End Sub

    Public Sub edit_click()
        State = "EDIT"
        dsedit = New DataSet
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct tanggal as [Tanggal], kd_jadwal as [JadwalKerja] from PROD.dbo.PROD_rcn_org", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        daedit.Fill(dsedit, "lookup")
        frmCari.set_dso(dsedit.Tables("lookup")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            kode = frmCari.row("JadwalKerja").ToString
            kode1 = CDate(Format(frmCari.row("Tanggal"), "yyyy-MM-dd"))
            tanggal.EditValue = CDate(Format(frmCari.row("Tanggal"), "dd/MM/yyyy"))
            txtjadwal.EditValue = kode
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_org where kd_jadwal='" & kode & "' and tanggal='" & Format(kode1, "MM/dd/yyyy") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_org where kd_jadwal='" & txtjadwal.EditValue & "' and tanggal='" & kode1 & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            ''If Not ds2.Tables("msterkegiatan") Is Nothing Then ds2.Tables("mstKeg").Clear()
            'da2.Fill(ds2, "msterkegiatan")
            'row = ds2.Tables("msterkegiatan").Rows(0)
            ''tanggal.EditValue = row.Item("tanggal").ToString
            'txtjadwal.EditValue = row.Item("kd_jadwal").ToString

            'gControl.DataSource = ds2.Tables("msterkegiatan")

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

    Public Sub delete_click()
       

        'If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
        '    ds2.Tables("msterkegiatan").Rows(0).Delete()

        '    If Not ds2.Tables("msterkegiatan") Is Nothing Then ds2.Tables("msterkegiatan").Clear()
        '    Dim mybuilder As New SqlCommandBuilder(da2)
        '    da2.DeleteCommand = mybuilder.GetDeleteCommand
        '    da2.Update(ds2.Tables("msterkegiatan"))
        '    ds2.Tables("msterkegiatan").AcceptChanges()
        'End If

        If MsgBox("Hapus Baris Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            For Each dr As DataRow In ds2.Tables("msterkegiatan").Rows
                dr.Delete()
            Next


        End If
        save_click(True)
        State = ""


        cancel_click()
    End Sub

    Public Sub cancel_click()
        tanggal.Text = vbNullString
        txtjadwal.EditValue = vbNullString
        txtjadwal.EditValue = Nothing
        
        If Not ds2.Tables("msterkegiatan") Is Nothing Then ds2.Tables("msterkegiatan").Clear()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        Dim view As ColumnView = sender
        view.SetRowCellValue(e.RowHandle, "tanggal", Format(tanggal.EditValue, "dd/MM/yyyy"))
        view.SetRowCellValue(e.RowHandle, "kd_jadwal", txtjadwal.EditValue)
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
    End Sub

    Private Sub txtjadwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtjadwal.EditValueChanged
        Dim view As ColumnView = gView
        'MsgBox(Format(tanggal.EditValue, "yyyy-MM-dd"), MsgBoxStyle.Information)
        If Not ds2.Tables("msterkegiatan") Is Nothing Then ds2.Tables("msterkegiatan").Clear()

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_org where kd_jadwal='" & txtjadwal.EditValue & "' and tanggal='" & Format(tanggal.EditValue, "yyyy-MM-dd") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da2.Fill(ds2, "msterkegiatan")
        
        gControl.DataSource = ds2.Tables("msterkegiatan")
        'If Not ds2.Tables("msterkegiatan") Is Nothing Then ds2.Tables("msterkegiatan").Clear()
        'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_org where kd_jadwal='" & txtjadwal.EditValue & "' and tanggal='" & tanggal.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        'da2.Fill(ds2, "msterkegiatan")

        'gControl.DataSource = ds2.Tables("msterkegiatan")

        


    End Sub

  
End Class