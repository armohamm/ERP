'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient
Public Class frmMstSopir

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DAs, DA2 As SqlClient.SqlDataAdapter
    Dim sopirDAO As New DataAcess.MstSopirDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder


    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'End With
        STATE = "ADD" '<-- set state= add
        btnCekPeg.Focus()

    End Sub

    Public Sub delete_click()
        If MsgBox("Yakin Data akan di Hapus?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataRow In dSO.Tables(0).Rows
                dr.Delete()
            Next
            If sopirDAO.save(dSO, DA, "DELETE") Then
                showMessages("Deleted")
                STATE = ""
                ' and Do another saved Thing
                bersihkan()
            Else
                showMessages(sopirDAO.errorMsg, MsgBoxStyle.Critical)
                ' klau error disini
            End If
        End If
    End Sub

    Public Sub cancel_click()
        STATE = ""
        bersihkan()
        btnSave = False
        btnEdit = True
        btnadd = True
        btnCancel = False
        btnDelete = False
        setStatus()

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
            txbKdSopir.Text = nomergen()
            'dSO = New DataSet
            
            row = dSO.Tables("_SIF_SOPIR").NewRow
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            ''>>>>>>>>>>>>>>>>
            row.Item("Kode_Sopir") = txbKdSopir.Text ' klau edit ini tidak boleh diubah
            row.Item("Kd_pegawai") = txbKdPeg.Text
            row("Nama_Sopir") = txbNamaPeg.Text
            row("Stat_job") = cbJob.Text
            row("Keterangan") = txbKet.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            dSO.Tables(0).Rows.Add(row)
        ElseIf STATE = "EDIT" Or STATE = "DELETE" Then
            row = dSO.Tables("_SIF_SOPIR").Rows(0)
            row.Item("Kd_pegawai") = txbKdPeg.Text
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
        Try
            
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(dSO.Tables("_SIF_SOPIR"))
            dSO.Tables("_SIF_SOPIR").AcceptChanges()
            'Return True
        Catch e As Exception
            dSO.Tables("_SIF_SOPIR").RejectChanges()
            MsgBox(e.Message)
            'Return False
        End Try
        If STATE = "ADD" Then
            showMessages("Data Telah Disimpan")
            STATE = ""
            'txbKdSopir.Text = dSO.Tables("_SIF_SOPIR").Rows(0)("Kode_Sopir")
            bersihkan()
            btnSave = False
            btnEdit = True
            btnadd = True
            btnCancel = True
            setStatus()
            ' and Do another saved Thing
        ElseIf STATE = "EDIT" Then
            showMessages("Data telah di Updated")
            STATE = ""
            bersihkan()
        Else
            MsgBox(sopirDAO.errorMsg, MsgBoxStyle.Critical, "Error Saving Data")
            ' klau error disini
        End If
    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnadd = False
        btnSave = True
        setStatus()
        dSO1 = New DataSet
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA2.Fill(dSO1, "LOOKUP_SIF_SOPIR")
        frmCari.set_dso(dSO1.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih

            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir where Kode_Sopir='" & frmCari.row("Kode_Sopir") & "'", sqlconn))
            DA.Fill(dSO, "_SIF_SOPIR") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_SALES(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txbKdSopir.Text = dSO.Tables(0).Rows(0).Item("Kode_Sopir").ToString
                txbKdPeg.Text = dSO.Tables(0).Rows(0).Item("Kd_pegawai").ToString
                txbNamaPeg.Text = dSO.Tables(0).Rows(0).Item("Nama_Sopir").ToString
                cbJob.Text = dSO.Tables(0).Rows(0).Item("Stat_job").ToString

                cbStatus.Text = IIf(dSO.Tables(0).Rows(0).Item("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
                txbKet.Text = dSO.Tables(0).Rows(0).Item("Keterangan").ToString

            Else
                MsgBox("Data tidak diketemukan")
            End If
        Else
            cancel_click()
        End If
    End Sub

    Private Sub frmMntSopir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load

        'sopirDAO.conn = sqlconn
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Sopir where 1=0", sqlconn))
        DA.Fill(dSO, "_SIF_SOPIR")
        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
      
    End Sub

    Public Function nomergen()
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX(cast(substring(Kode_Sopir,5,4) as numeric)) from SIF.dbo.SIF_Sopir", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "SPR-0001-" & kdcabang
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            hasil = "SPR-" & temp & (hasil + 1) & "-" & kdcabang
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Private Sub btnCekPeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCekPeg.Click
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Pegawai", sqlconn))  'query table pegawai
        If Not dSO.Tables("_peg") Is Nothing Then
            dSO.Tables("_peg").Clear()
        End If
        DAs.Fill(dSO, "_peg")

        frmCari.set_dso(dSO.Tables("_peg"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txbKdPeg.Text = frmCari.row("Kode_pegawai").ToString
            txbNamaPeg.Text = frmCari.row("Nama_Pegawai").ToString
        End If
        cbJob.Focus()
    End Sub

    Private Sub cbJob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbJob.KeyPress
        If e.KeyChar = Chr(13) Then
            txbKet.Focus()
        End If
    End Sub

    Private Sub txbKet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbKet.KeyPress
        If e.KeyChar = Chr(13) Then
            If MsgBox("Data akan disimpan ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then save_click()
        End If
    End Sub
End Class