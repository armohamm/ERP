Imports System.Data
Imports System.Data.SqlClient
Public Class frmUser
    Public STATE As String
    Dim dSO, dso2 As New DataSet
    Dim row As DataRow
    Dim DA, sp, spd, da2 As SqlClient.SqlDataAdapter
    Public saveState As Boolean
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearField()
        
        GView.Columns("cek").ColumnEdit = repCek
        Me.BackgroundImage = Parent.BackgroundImage
        prn = getParent(Me)
        pnl.Height = Me.Height - 10
    End Sub
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub edit_click()
        clearField()
        STATE = "EDIT"
        txtUser.Enabled = True
        txtNewuser.Enabled = False
        default_add(prn)
        setStatus()
        cmdNip.Properties.ReadOnly = True
    End Sub
    Public Sub cancel_click()
        clearField()
        txtDivisi.Text = ""
        txtNama.Text = ""
        txtNewuser.Text = ""
        txtUser.EditValue = ""
        cmdNip.EditValue = ""
        'txtUser.EditValue = vbNullString
        'cmdNip.EditValue = vbNullString
        default_cancel(prn)
        Me.Enabled = False
        setStatus()
        cmdNip.Properties.ReadOnly = False
    End Sub
    Public Sub add_click()
        clearField()
        STATE = "ADD"
        default_add(prn)
        txtUser.Enabled = False
        txtNewuser.Enabled = True
        setStatus()
        cmdNip.Properties.ReadOnly = False
    End Sub
    Public Function save_click() As Boolean
        Dim myBuilder As SqlClient.SqlCommandBuilder
        Dim row As DataRow
        Dim id As String
        Dim hasil As Boolean = False
        Dim valid As Boolean = True
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            If txtNewuser.Text = "" Then
                DXEP.SetError(txtNewuser, "Id User Baru Masih Kosong")
                txtNewuser.Focus()
                valid = False
            End If
        Else
            If txtUser.Text = "" Then
                DXEP.SetError(txtUser, "Id User Masih Kosong")
                txtUser.Focus()
                valid = False
            End If
        End If
        If cmdNip.Text = "" Then
            DXEP.SetError(cmdNip, "NIP Pegawai Masih Kosong")
            cmdNip.Focus()
            valid = False
        End If
        If Not valid Then Exit Function
        If STATE = "ADD" Then
            row = dSO.Tables("SPM").NewRow
            id = txtNewuser.Text
            row.Item("Last_create_date") = Now
            row.Item("Last_created_by") = kdpeg
            row.Item("Program_name") = Name
        Else
            row = dSO.Tables("SPM").Rows(0)
            row.Item("Last_update_date") = Now
            row.Item("Last_updated_by") = kdpeg
            id = txtUser.Text
        End If

        row.Item("userid") = id
        row.Item("nama") = txtNama.Text
        row.Item("passwd") = AES_Encrypt(id, "password")
        row.Item("NIP") = cmdNip.EditValue
        row("rec_stat") = IIf(cmdStat.Text = "AKTIF", "Y", "T")
        If STATE = "ADD" Then dSO.Tables("SPM").Rows.Add(row)
        Try
            dso2 = dSO.Clone
            dso2 = dSO.Copy

            myBuilder = New SqlClient.SqlCommandBuilder(sp)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            sp.UpdateCommand = myBuilder.GetUpdateCommand()
            sp.InsertCommand = myBuilder.GetInsertCommand()
            sp.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(spd)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            spd.UpdateCommand = myBuilder.GetUpdateCommand()
            spd.InsertCommand = myBuilder.GetInsertCommand()
            spd.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            sp.UpdateCommand.Transaction = BTRANS
            sp.InsertCommand.Transaction = BTRANS
            sp.DeleteCommand.Transaction = BTRANS
            sp.Update(dSO.Tables("SPM"))

            spd.UpdateCommand.Transaction = BTRANS
            spd.InsertCommand.Transaction = BTRANS
            spd.DeleteCommand.Transaction = BTRANS

            For Each rw As DataRow In dSO.Tables("SPD").Rows
                rw.Delete()
            Next
            For Each rw As DataRow In dSO.Tables("SP").Rows
                If rw.Item("cek") = 1 Then
                    row = dSO.Tables("SPD").NewRow
                    row.Item(0) = id
                    row.Item(1) = rw.Item("idrole")

                    dSO.Tables("SPD").Rows.Add(row)
                End If
            Next
            
            spd.Update(dSO.Tables("SPD"))

            BTRANS.Commit()
            showMessages("Data Telah Disimpan")
            hasil = (True)
            STATE = "EDIT"
        Catch ex As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dSO = dso2.Clone
            dSO = dso2.Copy
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Gagal Simpan")
            hasil = False
        End Try
        myBuilder.Dispose()
        Return hasil
    End Function
    Private Sub clearField()
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select userid, nama, nip, rec_stat from KOPKAR.dbo.muser", sqlconn))
        DA.Fill(dSO, "SP_LOOKUP")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.anggota a left join KOPKAR.dbo.depsec d on a.depsec=d.depsec", sqlconn))
        DA.Fill(dSO, "Pegawai")
        sp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.muser where 1=0", sqlconn))
        sp.Fill(dSO, "SPM")

        spd = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.MUSER_ROLE where 1=0", sqlconn))
        spd.Fill(dSO, "SPD")

        cmdNip.Properties.DataSource = dSO.Tables("Pegawai")
        txtUser.Properties.DataSource = dSO.Tables("SP_LOOKUP")
        txtUser.Properties.DisplayMember = "userid"
        txtUser.Properties.ValueMember = "userid"
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from getUserRole('')", sqlconn))
        DA.Fill(dSO, "SP")

        Gridc.DataSource = dSO.Tables("SP")
    End Sub
    Private Sub txtUser_CloseUp(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles txtUser.CloseUp
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from getUserRole('" & e.Value & "')", sqlconn))
        dSO.Tables("SP").Clear()
        DA.Fill(dSO, "SP")
        Gridc.RefreshDataSource()
        Gridc.Refresh()
        dSO.Tables("SPD").Clear()
        spd = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from MUSER_ROLE where iduser='" & e.Value & "'", sqlconn))
        spd.Fill(dSO, "SPD")
    End Sub

    Private Sub txtUser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.EditValueChanged
        If txtNama.EditValue Is Nothing Then
            txtNama.Text = ""
            cmdNip.EditValue = vbNullString
            cmdStat.Text = "AKTIF"
        ElseIf txtUser.EditValue.ToString <> "" Then
            txtNama.Text = txtUser.GetColumnValue("Nama")
            cmdNip.EditValue = txtUser.GetColumnValue("nasabah_id")
            cmdStat.Text = IIf(txtUser.GetColumnValue("rec_stat") = "Y", "AKTIF", "TIDAK AKTIF")
            If Not dSO.Tables("SPM") Is Nothing Then dSO.Tables("SPM").Clear()
            sp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from muser where userid='" & txtUser.EditValue & "'", sqlconn))
            sp.Fill(dSO, "SPM")
        End If
    End Sub

    Private Sub cmdNip_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNip.EditValueChanged
        If cmdNip.EditValue Is Nothing Then
            txtNama.Text = ""
            txtDivisi.Text = ""
        ElseIf cmdNip.EditValue.ToString <> "" Then
            txtNama.Text = cmdNip.GetColumnValue("nasabah_id").ToString
            txtDivisi.Text = cmdNip.GetColumnValue("nama_depsec").ToString
        End If
    End Sub
End Class