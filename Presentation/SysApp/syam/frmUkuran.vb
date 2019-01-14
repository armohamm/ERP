Public Class frmUkuran
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim obj As Object
    Dim dSO As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA As SqlClient.SqlDataAdapter
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Dim isValid As Boolean = True
    Dim err As String = ""
    'Dim myDAO As New DataAcess.WilayahDAO

    Private Function getNextNumber() As String
        Dim hasil, temp As String
        'Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kain,'x1'),3,10) as numeric)) from SIF.DBO.SIF_Kain", sqlconn).ExecuteReader
        Dim sqlDR As SqlClient.SqlDataReader = New SqlClient.SqlCommand("select count(Kode_Ukuran)+1 from SIF.dbo.SIF_Ukuran", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = CInt(Len(hasil)) To 2
                temp = "0" & temp
            Next
            hasil = temp & hasil
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        default_add(prn)
        setStatus()
        STATE = "ADD" '<-- set state= add
        txtKode.Text = getNextNumber()
    End Sub
    Public Sub clear_field()
        txtAlias.Text = ""
        txtKeterangan.Text = ""
        txtKode.Text = ""
        txtNama.Text = ""
        txt_Lebar.Text = 0
        txt_Panjang.Text = 0
        txt_Tebal.Text = 0
    End Sub

    Public Sub cancel_click()
        default_cancel(prn)
        clear_field()
        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub

    'Public Sub delete_click()
    '    If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        For Each dr As DataRow In dSO.Tables(0).Rows
    '            dr.Delete()
    '        Next
    '        If myDAO.save(dSO, DA) Then
    '            showMessages("Data Berhasil di Update..!", 14)
    '            cancel_click()
    '            ' and Do another saved Thing
    '        Else
    '            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
    '            ' klau error disini
    '        End If
    '    End If
    'End Sub

    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran,Tinggi,Lebar,Panjang,Alias from SIF.dbo.SIF_Ukuran", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "LOOKUP_SIF_UKURAN")
        frmCari.set_dso(dSO.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Ukuran where Kode_Ukuran='" & frmCari.row("Kode_Ukuran") & "'", sqlconn))
            DA.Fill(dSO, "SIF_UKURAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            default_add(prn)
            STATE = "EDIT"
            setStatus()
            If dSO.Tables(0).Rows.Count > 0 Then
                txtKode.Text = dSO.Tables(0).Rows(0).Item("Kode_Ukuran").ToString
                txtNama.Text = dSO.Tables(0).Rows(0).Item("Nama_Ukuran").ToString
                txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("Keterangan").ToString
                txtAlias.Text = dSO.Tables(0).Rows(0).Item("Alias").ToString
                txt_Tebal.Text = dSO.Tables(0).Rows(0).Item("Tinggi").ToString
                txt_Lebar.Text = dSO.Tables(0).Rows(0).Item("Lebar").ToString
                txt_Panjang.Text = dSO.Tables(0).Rows(0).Item("Panjang").ToString
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

    Public Sub save_click()
        If txtNama.EditValue = vbNullString Or txtNama.EditValue = "" Then
            isValid = False
            err &= "Nama Ukuran tidak boleh kosong" & vbCrLf
        End If
        If isValid Then
            If STATE = "ADD" Then
                dSO = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_UKURAN where 1=0", sqlconn))
                DA.Fill(dSO, "SIF_UKURAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO.Tables("SIF_UKURAN").NewRow
                row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
                row("Kode_Ukuran") = txtKode.Text
                row("Nama_Ukuran") = txtNama.Text
                row("Keterangan") = txtKeterangan.Text
                row("Alias") = txtAlias.Text
                row("Rec_Stat") = "Y"
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
                row("Tinggi") = txt_Tebal.Text
                row("Lebar") = txt_Lebar.Text
                row("Panjang") = txt_Panjang.Text
                '  row.Item("Kode_Wilayah") = txtKode.Text ' klau edit ini tidak boleh diubah
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
                DA.Update(dSO.Tables(0))
                dSO.Tables(0).AcceptChanges()
                showMessages("Data Berhasil di Update..!", 14)
                clear_field()
                err = ""
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables(0).Rows(0)
                row.Item("Rec_Stat") = ""
                row.Item("Kode_Ukuran") = txtKode.Text
                row.Item("Nama_Ukuran") = txtNama.Text
                row.Item("Keterangan") = txtKeterangan.Text
                row.Item("Alias") = txtAlias.Text
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username
                row.Item("Program_Name") = Me.Name
                row("Tinggi") = txt_Tebal.Text
                row("Lebar") = txt_Lebar.Text
                row("Panjang") = txt_Panjang.Text
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.Update(dSO.Tables(0))
                dSO.Tables(0).AcceptChanges()
                showMessages("Data Berhasil di Update..!", 14)
                cancel_click()
                err = ""
            End If
        Else
            MsgBox("Ada kesalahan dalam mengisi data :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            Exit Sub
        End If
    End Sub

    Private Sub frmUkuran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        'myDAO.conn = sqlconn
        'myDAO.conn = sqlconn
        'myDAO.kode = "kode_ukuran"
        'myDAO.post = "U"
        'myDAO.tabel = "SIF_UKURAN"
        obj = getParent(Me)
        prn = obj
        Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        pnl.Left = (Me.Width - pnl.Width) / 2
        pnl.Top = pnl.Height / 3


    End Sub

    Private Sub namaUkuran()
        If Not (txt_Tebal.EditValue = vbNullString Or txt_Tebal.EditValue = "0") Then
            txtNama.EditValue = txt_Tebal.EditValue.ToString.ToUpper
            If Not (txt_Lebar.EditValue = vbNullString Or txt_Lebar.EditValue = "0") Then
                txtNama.EditValue &= " X " & txt_Lebar.EditValue.ToString.ToUpper
            Else
                txtNama.EditValue &= ""
            End If
            If Not (txt_Panjang.EditValue = vbNullString Or txt_Panjang.EditValue = "0") Then
                txtNama.EditValue &= " X " & txt_Panjang.EditValue.ToString.ToUpper
            Else
                txtNama.EditValue &= ""
            End If
        ElseIf Not (txt_Lebar.EditValue = vbNullString Or txt_Lebar.EditValue = "0") Then
            txtNama.EditValue = txt_Lebar.EditValue.ToString.ToUpper
            If Not (txt_Tebal.EditValue = vbNullString Or txt_Tebal.EditValue = "0") Then
                txtNama.EditValue = txt_Lebar.EditValue & " X " & txt_Lebar.EditValue.ToString.ToUpper
            End If
            If Not (txt_Panjang.EditValue = vbNullString Or txt_Panjang.EditValue = "0") Then
                txtNama.EditValue &= " X " & txt_Panjang.EditValue.ToString.ToUpper
            Else
                txtNama.EditValue &= ""
            End If
        ElseIf Not (txt_Panjang.EditValue = vbNullString Or txt_Panjang.EditValue = "0") Then
            txtNama.EditValue = txt_Panjang.EditValue.ToString.ToUpper
            If Not (txt_Tebal.EditValue = vbNullString Or txt_Tebal.EditValue = "0") Then
                txtNama.EditValue = txt_Tebal.EditValue.ToString.ToUpper & " X " & txt_Panjang.EditValue.ToString.ToUpper
            ElseIf Not (txt_Lebar.EditValue = vbNullString Or txt_Lebar.EditValue = "0") Then
                txtNama.EditValue = txt_Tebal.EditValue.ToString.ToUpper & " X " & txt_Lebar.EditValue & " X " & txt_Panjang.EditValue.ToString.ToUpper
            End If
        End If
    End Sub

    Private Sub txt_Tebal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tebal.EditValueChanged
        namaUkuran()
    End Sub

    Private Sub txt_Lebar_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Lebar.EditValueChanged
        namaUkuran()
    End Sub

    Private Sub txt_Panjang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Panjang.EditValueChanged
        namaUkuran()
    End Sub
End Class