'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient
Public Class frmMstJabatan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DA2 As SqlClient.SqlDataAdapter
    Dim myDAO As New DataAcess.MstJabatanDAO
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

    Private Sub bersihkan()
        txbKdJab.Text = ""
        txbNama.Text = ""
        txbKet.Text = ""
        cbStatus.Text = ""
    End Sub

    Private Sub validasi_entry(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar)) Then
            ErrorProvider1.SetError(sender, "Peringatan! Mohon isi data dengan BENAR")
            e.Handled = True

            'If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            '    'invaled karakter
            '    ErrorProvider1.SetError(sender, "Inputan tidak boleh Huruf alfabet")
            '    e.Handled = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'End With
        STATE = "ADD" '<-- set state= add
        txbNama.Focus()

    End Sub

    Public Sub cancel_click()
        STATE = ""
        bersihkan()

    End Sub

    Public Sub delete_click()
        If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataRow In dSO.Tables(0).Rows
                dr.Delete()
            Next
            If myDAO.save(dSO, DA, "DELETE") Then
                MsgBox("Deleted")
                STATE = ""
                ' and Do another saved Thing
            Else
                MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
                ' klau error disini
            End If
        End If
    End Sub



    Public Sub edit_click()
        btnCancel = True
        btnDelete = True
        btnadd = False
        btnSave = True
        setStatus()
        Dim bolean As String
        dSO1 = New DataSet
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA2.Fill(dSO1, "LOOKUP_SIF_JABATAN")
        frmCari.set_dso(dSO1.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan where Kode_Jabatan='" & frmCari.row("Kode_Jabatan") & "'", sqlconn))
            DA.Fill(dSO, "SIF_JABATAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_JABATAN(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txbKdJab.Text = dSO.Tables(0).Rows(0).Item("Kode_Jabatan").ToString
                txbNama.Text = dSO.Tables(0).Rows(0).Item("Nama_Jabatan").ToString
                txbKet.Text = dSO.Tables(0).Rows(0).Item("Keterangan").ToString
                bolean = dSO.Tables(0).Rows(0).Item("Rec_Stat").ToString
                cbStatus.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
            Else
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Public Sub save_click()
        If STATE = "ADD" Then
            txbKdJab.Text = getNextNumber()
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_JABATAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_JABATAN").NewRow
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            ''>>>>>>>>>>>>>>>>
            row.Item("Kode_Jabatan") = getNextNumber() ' klau edit ini tidak boleh diubah
            row.Item("Nama_Jabatan") = txbNama.Text
            row("Keterangan") = txbKet.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            dSO.Tables(0).Rows.Add(row)
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
            row.Item("Nama_Jabatan") = txbNama.Text
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
            DA.Update(dSO.Tables("SIF_JABATAN"))
            dSO.Tables("SIF_JABATAN").AcceptChanges()
            'Return True
        Catch e As Exception
            dSO.Tables("SIF_JABATAN").RejectChanges()
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
            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Saving Data")
            ' klau error disini
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txbNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        validasi_entry(sender, e)
    End Sub

    Private Sub frmMstJabatan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan where 1=0", sqlconn))
        'DA.Fill(dSO, "SIF_JABATAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
    End Sub

    Private Function getNextNumber() As String

        Dim hasil, temp As String
        Dim sqlDR As SqlClient.SqlDataReader = New SqlCommand("select MAX(cast(substring(Kode_Jabatan,5,4) as numeric)) from SIF.dbo.SIF_Jabatan", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "JAB-0001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            hasil = "JAB-" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil

    End Function

    Private Sub txbNama_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbNama.KeyPress
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