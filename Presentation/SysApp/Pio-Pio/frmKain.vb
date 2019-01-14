Imports System.Data.SqlClient

Public Class frmKain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Dim rc As Integer
    Dim dt As DataTable
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DALOOKUP As SqlDataAdapter
    Dim newRow As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Function getNextNumber() As String
        '  Dim hasil, temp As String
        'Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kain,'x1'),3,10) as numeric)) from SIF.DBO.SIF_Kain", sqlconn).ExecuteReader
        'Dim sqlDR As SqlDataReader = New SqlCommand("select COUNT(Kode_Kain) from DBO.SIF_Kain", sqlconn).ExecuteReader
        'sqlDR.Read()
        'temp = ""
        Dim hasil, temp, nilai_max As String
        nilai_max = dSO.Tables("KAIN").Compute(" max(Kode_Kain)", "").ToString
        'drUkuran = New SqlCommand("SELECT MAX(u.Kd_Sub_Tipe)+1 FROM SIF.dbo.SIF_Sub_Tipe u", sqlconn).ExecuteReader
        'drUkuran.Read()
        nilai_max = Val(nilai_max) + 1

        temp = ""
        If nilai_max = "" Then
            hasil = "001"
        Else
            'hasil = drUkuran.Item(0)
            hasil = nilai_max
            For i As Int16 = CInt(Len(hasil)) To 2
                temp = "0" & temp
            Next
            hasil = temp & hasil
        End If
        'drUkuran.Close()
        Return hasil

        'If gv.RowCount = 0 Then
        '    hasil = "000"
        'Else
        '    If gv.RowCount >= 1 And gv.RowCount <= 9 Then
        '        hasil = "00" & gv.RowCount
        '    ElseIf gv.RowCount >= 10 And gv.RowCount <= 99 Then
        '        hasil = "0" & gv.RowCount
        '    Else
        '        hasil = gv.RowCount
        '    End If
        '    ' hasil = "KN" & temp & (hasil + 1)
        'End If
        ''sqlDR.Close()
        'Return hasil
    End Function

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        btnadd = False
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnSave = True
        setStatus()
        STATE = "ADD" '<-- set state= add

    End Sub
    Public Sub cancel_click()
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub

    Private Sub load_data()
        If Not dSO.Tables("KAIN") Is Nothing Then dSO.Tables("KAIN").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_Kain ", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "KAIN")
        gc.DataSource = dSO.Tables("KAIN")
    End Sub

    Private Sub frmKain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        load_data()
    End Sub

    Public Sub save_click()
        For Each rows As DataRow In dSO.Tables("KAIN").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Kd_Cabang") = getKodeCabang()
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
                'kd_kain = kd_kain + 1
            ElseIf rows.RowState = DataRowState.Modified Then
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
            End If
            'rows.Item("Kode_Kain") = kd_kain - 1
        Next

        Try
            myBuilder = New SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()
            DA.Update(dSO.Tables("KAIN"))
            dSO.Tables("KAIN").AcceptChanges()

            showMessages("Data Berhasil di Update..!", 14)
        Catch ex As Exception
            dSO.Tables("KAIN").RejectChanges()
            MsgBox("Kesalahan dalam mengisi data : " & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
        End Try

    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_KAIN", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DALOOKUP.Fill(dSO, "LOOKUP")
        frmCari.set_dso(dSO.Tables("LOOKUP")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            If dSO.Tables("LOOKUP").Rows.Count > 0 Then
                If Not dSO.Tables("KAIN") Is Nothing Then dSO.Tables("KAIN").Clear()
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_KAIN where Kode_Kain='" & frmCari.row("Kode_Kain") & "'", sqlconn)) '<- query buat ditampilkan di LOV
                DA.Fill(dSO, "KAIN")
                gc.DataSource = dSO.Tables("KAIN")
                STATE = "EDIT"
                'prn.btnSave.Enabled = True
                'prn.btnCancel.Enabled = True
                'prn.btnDelete.Enabled = True
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

    Public Sub delete_click()
        If MessageBox.Show("Apakah ingin menghapus Record ini?", _
          "Delete", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Warning) = DialogResult.Yes Then
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            gv.DeleteSelectedRows()
            'MsgBox("deleted successfully")
            showMessages("Data Berhasil di Update..!", 14)
            DA.Update(dSO, "KAIN")
            Exit Sub
        End If

    End Sub

    Private Sub gv_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.SetRowCellValue(e.RowHandle, "Kode_Kain", getNextNumber())
    End Sub
End Class