Imports System.Data.SqlClient

Public Class frmkalharga
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds01 As New DataSet
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
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Function getNextNumber() As String
        Dim hasil As String
        'Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kain,'x1'),3,10) as numeric)) from SIF.DBO.SIF_Kain", sqlconn).ExecuteReader
        'Dim sqlDR As SqlDataReader = New SqlCommand("select COUNT(Kode_Kain) from DBO.SIF_Kain", sqlconn).ExecuteReader
        'sqlDR.Read()
        'temp = ""

        If gv.RowCount = 0 Then
            hasil = "000"
        Else
            If gv.RowCount >= 1 And gv.RowCount <= 9 Then
                hasil = "00" & gv.RowCount
            ElseIf gv.RowCount >= 10 And gv.RowCount <= 99 Then
                hasil = "0" & gv.RowCount
            Else
                hasil = gv.RowCount
            End If
            ' hasil = "KN" & temp & (hasil + 1)
        End If
        'sqlDR.Close()
        Return hasil
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
        btnEdit = False
        btnSave = False
        setStatus()
        'Me.Enabled = False
        STATE = ""
    End Sub

    Private Sub load_data()
        If Not ds01.Tables("jenis") Is Nothing Then ds01.Tables("jenis").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_jns_brg kd_jenis,Nama_Jenis from dbo.SIF_Jenis_Barang ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "jenis")
        lkjenis.DataSource = ds01.Tables("jenis")
        lkjenis.ValueMember = "kd_jenis"
        lkjenis.DisplayMember = "Nama_Jenis"

        If Not ds01.Tables("merk") Is Nothing Then ds01.Tables("merk").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk kd_merk,Nama_Merk from dbo.SIF_Merk ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "merk")
        lkmerk.DataSource = ds01.Tables("merk")
        lkmerk.ValueMember = "kd_merk"
        lkmerk.DisplayMember = "Nama_Merk"

        If Not ds01.Tables("subtipe") Is Nothing Then ds01.Tables("subtipe").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe kd_sub_tipe,Nama_Sub_Tipe from dbo.SIF_Sub_Tipe ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "subtipe")
        lksubtipe.DataSource = ds01.Tables("subtipe")
        lksubtipe.ValueMember = "kd_sub_tipe"
        lksubtipe.DisplayMember = "Nama_Sub_Tipe"

        If Not ds01.Tables("tipe") Is Nothing Then ds01.Tables("tipe").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe kd_tipe,Nama_Tipe from dbo.SIF_Tipe ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "tipe")
        lookTipe.DataSource = ds01.Tables("tipe")
        lookTipe.ValueMember = "kd_tipe"
        lookTipe.DisplayMember = "Nama_Tipe"

        If Not ds01.Tables("ukuran") Is Nothing Then ds01.Tables("ukuran").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran kd_ukuran,Nama_Ukuran from dbo.SIF_Ukuran ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "ukuran")
        lkukuran.DataSource = ds01.Tables("ukuran")
        lkukuran.ValueMember = "kd_ukuran"
        lkukuran.DisplayMember = "Nama_Ukuran"

        If Not ds01.Tables("kain") Is Nothing Then ds01.Tables("kain").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain, Merk_Kain from dbo.SIF_Kain ", sqlconn)) '<- query buat ditampilkan di LOV
        DALOOKUP.Fill(ds01, "kain")
        lkkain.DataSource = ds01.Tables("kain")
        lkkain.ValueMember = "Kode_Kain"
        lkkain.DisplayMember = "Merk_Kain"

        If Not dSO.Tables("Kal") Is Nothing Then dSO.Tables("KAIN").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from dbo.SIF_calc_harga ", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "Kal")
        gc.DataSource = dSO.Tables("Kal")

    End Sub

    Private Sub frmkalharga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        STATE = "ADD"
        Me.Enabled = True
        load_data()
    End Sub

    Public Sub save_click()
        For Each rows As DataRow In dSO.Tables("Kal").Rows
            If rows.RowState = DataRowState.Added Then

                rows.Item("last_update_Date") = getTanggal()
                rows.Item("last_update_user") = username

                'kd_kain = kd_kain + 1
            ElseIf rows.RowState = DataRowState.Modified Then
                rows.Item("last_update_Date") = getTanggal()
                rows.Item("last_update_user") = username

            End If
            'rows.Item("Kode_Kain") = kd_kain - 1
        Next

        Try
            myBuilder = New SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()
            DA.Update(dSO.Tables("Kal"))
            dSO.Tables("Kal").AcceptChanges()

            showMessages("Data Berhasil di Update..!", 14)
        Catch ex As Exception
            dSO.Tables("Kal").RejectChanges()
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
            DA.Update(dSO, "Kal")
            Exit Sub
        End If

    End Sub

    Public Sub call_procedure()
        Try
            Dim sqlCmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim sqlCmd1 As New SqlCommand
            sqlCmd1.Connection = sqlconn

            sqlCmd1.CommandType = CommandType.StoredProcedure
            sqlCmd1.CommandText = "SIF.dbo.sif_calc_mst_harga"

            dr = sqlCmd1.ExecuteReader
            dr.Close()

            sqlconn.Close()
            MessageBox.Show("proses selesai")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        call_procedure()

    End Sub
End Class