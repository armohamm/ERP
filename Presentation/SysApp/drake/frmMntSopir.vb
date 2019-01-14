'===================================================
'= dikerjakan oleh Yahya Drake Rozi                =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com =
'= Project: Dinasty group american pillow @2011    =
'===================================================

Imports System.Data.SqlClient
Public Class frmMntSopir

    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DAs As SqlClient.SqlDataAdapter
    Dim sopirDAO As New DataAcess.MstSopirDAO


    Private Sub frmMntSopir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        sopirDAO.conn = sqlconn
        enabel()
    End Sub

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
            setStatus()
        End With
    End Sub
    Public Sub add_clcik()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        'txbKdSup.TabIndex = Focus()

        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True
        '    setStatus()
        'End With
        STATE = "ADD" '<-- set state= add

    End Sub

    Public Sub cancel_click()
        STATE = ""
        bersihkan()

    End Sub

    Private Sub bersihkan()
        txbKdSopir.Text = ""
        txbKdPeg.Text = ""
        txbNamaPeg.Text = ""
        cbJob.Text = ""
        txbKet.Text = ""
        cbStatus.Text = ""
    End Sub

    Private Sub enabel()
        txbKdSopir.Enabled = False
        txbKdPeg.Enabled = False
        txbNamaPeg.Enabled = False
    End Sub


    Public Sub save_click()
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_SOPIR") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_SOPIR").NewRow
            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
            ''>>>>>>>>>>>>>>>>
            row.Item("Kode_Sopir") = txbKdSopir.Text ' klau edit ini tidak boleh diubah
            row.Item("Kode_Pegawai") = txbKdPeg.Text
            row("Nama_Sopir") = txbNamaPeg.Text
            row("Stat_job") = cbJob.Text
            row("Keterangan") = txbKet.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        ElseIf STATE = "EDIT" Then

            row = dSO.Tables("SIF_SOPIR").Rows(0)
            row.Item("Kode_Pegawai") = txbKdPeg.Text
            row("Nama_Sopir") = txbNamaPeg.Text
            row("Stat_job") = cbJob.Text
            'row("kode_wilayah") = txbKdWil.Text
            row("Keterangan") = txbKet.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        End If
        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_SALES"

            sopirDAO.save(dSO, DA, "ADD")
            MsgBox("Data Telah Disimpan")
            STATE = ""
            txbKdSopir.Text = dSO.Tables("SIF_SOPIR").Rows(0)("Kode_Sopir")
            bersihkan()

            ' and Do another saved Thing
        ElseIf sopirDAO.save(dSO, DA, "EDIT") Then
            MsgBox("Data telah di Updated")
            STATE = ""
            bersihkan()
        Else
            MsgBox(sopirDAO.errorMsg, MsgBoxStyle.Critical, "Error Saving Data")
            ' klau error disini
        End If
    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "LOOKUP_SIF_SOPIR")
        frmCari.set_dso(dSO.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih

            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where Kode_Sopir='" & frmCari.row("Kode_Sopir") & "'", sqlconn))
            DA.Fill(dSO, "SIF_SOPIR") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_SALES(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txbKdSopir.Text = dSO.Tables(0).Rows(0).Item("Kode_Sopir").ToString
                txbKdPeg.Text = dSO.Tables(0).Rows(0).Item("Kode_Pegawai").ToString
                txbNamaPeg.Text = dSO.Tables(0).Rows(0).Item("Nama_Sopir").ToString
                cbJob.Text = dSO.Tables(0).Rows(0).Item("Stat_job").ToString

                cbStatus.Text = IIf(dSO.Tables(0).Rows(0).Item("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
                txbKet.Text = dSO.Tables(0).Rows(0).Item("Keterangan").ToString

            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        bersihkan()
        btnCekPeg.Focus()
        add_clcik()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        STATE = "EDIT"
        edit_click()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Anda ingin keluar dari program ??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnCekPeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCekPeg.Click
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Pegawai", sqlconn))  'query table pegawai
        If Not dSO.Tables("_peg") Is Nothing Then
            dSO.Tables("_peg").Clear()
        End If
        DAs.Fill(dSO, "_peg")

        frmCari.set_dso(dSO.Tables("_peg"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txbKdPeg.Text = frmCari.row("Kode_Pegawai").ToString
            lblKdPeg.Text = frmCari.row("Nama_Pegawai").ToString
        End If
    End Sub
End Class