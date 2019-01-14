Imports DataAcess
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmArea
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dSO, dsCari As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, daArea, daWil As SqlDataAdapter
    Dim myDAO As New AreaDAO
    Dim myBuilder As New SqlCommandBuilder
    Dim kode As String
    Dim rwx As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub clear_all()
        'txtKodeWilayah.Text = ""
        cmdLingkup.EditValue = vbNullString
        txtNamaWilayah.Text = ""
        txtWilKet.Text = ""
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain

        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True
        'End With
        btnadd = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = True
        setStatus()
        STATE = "ADD" '<-- set state add
        kode = getNoTrans("MWIL", getTanggal())
        loadList()
        'txtKodeWilayah.Text = getNoTrans("MWIL", getTanggal())
    End Sub

    Public Sub cancel_click()
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        clear_all()
        Me.Enabled = False
        If STATE = "EDIT" Then
            dsCari.Tables("AreaCari").Clear()
        End If
        STATE = ""

    End Sub

    Public Sub delete_click()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer


        If MsgBox("Hapus data Area?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'For Each dr As DataRow In dSO.Tables(0).Rows
            '    dr.Delete()
            'Next
            'If myDAO.save(dSO, DA) Then
            '    MsgBox("Deleted")
            '    STATE = ""
            '    ' and Do another saved Thing
            '    clear_all()
            'Else
            '    MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
            '    ' klau error disini
            'End If
            ReDim rows(gvArea.SelectedRowsCount - 1)
            For i = 0 To gvArea.SelectedRowsCount - 1
                rows(i) = gvArea.GetDataRow(gvArea.GetSelectedRows(i))
            Next
            gvArea.BeginSort()
            Try
                For Each row In rows
                    row.Delete()
                Next
            Finally
                gvArea.EndSort()
            End Try
            'STATE = "DELETE"
            save_click()
        End If
    End Sub
    Public Sub edit_click()
        STATE = "EDIT"
        ' bila menggunakan form cari
        loadList()
        'dSO = New DataSet
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV
        'DA.Fill(dSO, "LOOKUP_SIF_Wilayah")
        frmCari.set_dso(dsCari.Tables("WilCari"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            rwx = frmCari.row("Kode_Wilayah").ToString
            'dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Area where [Kd_Wilayah]='" & frmCari.row("Kode_Wilayah").ToString & "'", sqlconn))
            DA.Fill(dsCari, "AreaCari") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            gcArea.DataSource = dsCari.Tables("AreaCari")

            'If dSO.Tables("SIF_AREA").Rows.Count > 0 Then
            Dim xx As String = frmCari.row("Rec_Stat").ToString
            txtNamaWilayah.Text = frmCari.row("Nama_Wilayah").ToString
            txtWilKet.Text = frmCari.row("Keterangan").ToString
            cmdLingkup.EditValue = frmCari.row("Lingkup").ToString
            cbStatus.EditValue = IIf(xx.ToString = "Y", "AKTIF", "TIDAK AKTIF")
            'Else
            '    MsgBox("Data tidak diketemukan")
            'End If
        Else
            cancel_click()
        End If

        btnSave = True
        btnCancel = True
        btnadd = False
        btnEdit = False
        btnDelete = True
        setStatus()

    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction

        If STATE = "ADD" Then
            'dSO = New DataSet
            'DA = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_Wilayah where 1=0", sqlconn))
            'DA.Fill(dSO, "SIF_WILAYAH") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("Wil").NewRow
            row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            row("Kode_Wilayah") = kode
            row("Nama_Wilayah") = txtNamaWilayah.Text
            row("Keterangan") = txtWilKet.Text
            row("Lingkup") = cmdLingkup.EditValue 
            row("Rec_Stat") = IIf(cbStatus.EditValue = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Program_Name") = Me.Name
            '  row.Item("Kode_Wilayah") = txtKode.Text ' klau edit ini tidak boleh diubah
            dSO.Tables("Wil").Rows.Add(row)
        ElseIf STATE = "EDIT" Then
            DA = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_Wilayah where Kode_Wilayah='" & rwx & "'", sqlconn))
            DA.Fill(dsCari, "SIF_WILAYAH")
            row = dsCari.Tables("SIF_WILAYAH").Rows(0)
            row("Nama_Wilayah") = txtNamaWilayah.Text
            row("Keterangan") = txtWilKet.Text
            row("Rec_Stat") = IIf(cbStatus.EditValue = "AKTIF", "Y", "T")
            row("Last_Update_Date") = Now
            row("Lingkup") = cmdLingkup.EditValue
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        End If

        ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        If STATE = "ADD" Then
            For Each rw As DataRow In dSO.Tables("Area").Rows
                If rw.RowState = DataRowState.Added Then
                    rw("Kd_Cabang") = getKodeCabang()
                    rw("Kd_Wilayah") = kode
                    rw("Rec_Stat") = "Y"
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name
                ElseIf rw.RowState = DataRowState.Modified Then
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                End If
            Next
        Else
            For Each rw As DataRow In dsCari.Tables("AreaCari").Rows
                If rw.RowState = DataRowState.Added Then
                    rw("Kd_Cabang") = 1
                    rw("Kd_Wilayah") = kode
                    rw("Rec_Stat") = "Y"
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name
                ElseIf rw.RowState = DataRowState.Modified Then
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                End If
            Next
        End If

        If STATE = "ADD" Then
            Try
                myBuilder = New SqlCommandBuilder(daWil)
                daWil.UpdateCommand = myBuilder.GetUpdateCommand()
                daWil.InsertCommand = myBuilder.GetInsertCommand()
                daWil.DeleteCommand = myBuilder.GetDeleteCommand()

                myBuilder = New SqlCommandBuilder(daArea)
                daArea.UpdateCommand = myBuilder.GetUpdateCommand()
                daArea.InsertCommand = myBuilder.GetInsertCommand()
                daArea.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daWil.UpdateCommand.Transaction = BTRANS
                daWil.InsertCommand.Transaction = BTRANS
                daWil.DeleteCommand.Transaction = BTRANS

                daArea.UpdateCommand.Transaction = BTRANS
                daArea.InsertCommand.Transaction = BTRANS
                daArea.DeleteCommand.Transaction = BTRANS

                daWil.Update(dSO.Tables("Wil"))
                daArea.Update(dSO.Tables("Area"))

                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch e As Exception
                BTRANS.Rollback()
                dSO.Tables("Wil").RejectChanges()
                dSO.Tables("Area").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message)
            End Try
        Else
            Try
                myBuilder = New SqlCommandBuilder(daWil)
                daWil.UpdateCommand = myBuilder.GetUpdateCommand()
                daWil.InsertCommand = myBuilder.GetInsertCommand()
                daWil.DeleteCommand = myBuilder.GetDeleteCommand()

                myBuilder = New SqlCommandBuilder(daArea)
                daArea.UpdateCommand = myBuilder.GetUpdateCommand()
                daArea.InsertCommand = myBuilder.GetInsertCommand()
                daArea.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daWil.UpdateCommand.Transaction = BTRANS
                daWil.InsertCommand.Transaction = BTRANS
                daWil.DeleteCommand.Transaction = BTRANS

                daArea.UpdateCommand.Transaction = BTRANS
                daArea.InsertCommand.Transaction = BTRANS
                daArea.DeleteCommand.Transaction = BTRANS

                daWil.Update(dsCari.Tables("SIF_WILAYAH"))
                daArea.Update(dsCari.Tables("AreaCari"))
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                cancel_click()
                dsCari.Tables("AreaCari").Clear()
            Catch e As Exception
                BTRANS.Rollback()
                dsCari.Tables("WilCari").RejectChanges()
                dsCari.Tables("AreaCari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message)
            End Try
        End If

        cancel_click()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub frmArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        obj = getParent(Me)
        prn = obj
        'Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        'pnl.Left = (Me.Width - pnl.Width) / 2
        'pnl.Top = (Me.Height - pnl.Height) / 2
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub gvArea_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvArea.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("Kode_Area"), getNoTrans("MAR", getTanggal()))
    End Sub

    Private Sub loadList()
        If STATE = "ADD" Then
            dSO = New DataSet
            daWil = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV
            daWil.Fill(dSO, "Wil")
            daArea = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Area where Kd_Wilayah='" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
            daArea.Fill(dSO, "Area")
            gcArea.DataSource = dSO.Tables("Area")
        Else
            dsCari = New DataSet
            daWil = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV
            daWil.Fill(dsCari, "WilCari")
            daArea = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Area where Kd_Wilayah='" & dsCari.Tables("WilCari").Rows(1).ToString & "'", sqlconn)) '<- query buat ditampilkan di LOV
            daArea.Fill(dsCari, "AreaCari")
            gcArea.DataSource = dsCari.Tables("AreaCari")
        End If
    End Sub
End Class