Public Class frmMWilayah
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnEdit As Boolean
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA As SqlClient.SqlDataAdapter
    Dim myDAO As New DataAcess.WilayahDAO
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
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "LOOKUP_SIF_WILAYAH")
        frmCari.set_dso(dSO.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Wilayah where [Kode_Wilayah]='" & frmCari.row("Kode_Wilayah") & "'", sqlconn))
            DA.Fill(dSO, "SIF_WILAYAH") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txtKode.Text = dSO.Tables(0).Rows(0).Item("Kode_Wilayah").ToString
                txtNama.Text = dSO.Tables(0).Rows(0).Item("nama_wilayah").ToString
                txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("keterangan").ToString
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

    Public Sub save_click()
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Wilayah where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_WILAYAH") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_WILAYAH").NewRow
            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("Kode_Wilayah") = txtKode.Text ' klau edit ini tidak boleh diubah
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
        End If
        row.Item("Nama_Wilayah") = txtNama.Text
        row.Item("Keterangan") = txtKeterangan.Text
        row.Item("Rec_Stat") = ""
        row.Item("Last_Create_Date") = Now
        row.Item("Last_Created_By") = umum.username
        row.Item("Last_Update_Date") = Now
        row.Item("Last_Updated_By") = umum.username
        row.Item("Program_Name") = "Sikap"
        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        If myDAO.save(dSO, DA, STATE) Then
            MsgBox("Saved")
            STATE = ""
            txtKode.Text = dSO.Tables(0).Rows(0)("kode_wilayah")
            ' and Do another saved Thing
        Else
            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Saveing Data")
            ' klau error disini
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_clcik() ' cuman manggil fungsi doang

    End Sub

    Private Sub kosong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        myDAO.conn = sqlconn
        myDAO.kode = "kode_wilayah"
        myDAO.post = "W"
        myDAO.tabel = "SIF_WILAYAH"
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub
End Class