Imports DataAcess

Imports System.Data.SqlClient
Public Class frmCustomer
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA As SqlClient.SqlDataAdapter
    Dim myDAO As New DataAcess.CustomerDAO
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


        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
            setStatus()
        End With
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Private Function getCustomer() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kd_Customer,'x1'),4,10) as numeric)) from SIF.DBO.SIF_Customer", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "CST000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 6
                temp = "0" & temp
            Next
            hasil = "CST" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Public Sub cancel_click()
        default_cancel(prn)

        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub
    Private Sub Clear_ALL()
        txtKodeCust.Text = ""
        txtNamaCust.Text = ""
        txtAlamat1.Text = ""
        txtkota1.Text = ""
        txtTlp1.Text = ""
        txtAlamat2.Text = ""
        txtKota2.Text = ""
        txtTlp2.Text = ""
        txtFax.Text = ""
        txtNpwp.Text = ""
        txtEmail.Text = ""
        txtCP.Text = ""
        cbGrade.Text = ""
        LookUpEditArea.EditValue = ""
        cbStatus.Text = ""
        txtKet.Text = ""
        txtRupiah.Text = ""
        txtValas.Text = ""
        txtlimitPIDR.Text = ""
        txtLimitPValas.Text = ""
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
                Clear_ALL()
            Else
                MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
                ' klau error disini
            End If
        End If
    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Customer", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Customer")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Customer where [Kd_Customer]='" & frmCari.row("Kd_Customer") & "'", sqlconn))
            DA.Fill(dSO, "SIF_Customer") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txtKodeCust.Text = dSO.Tables(0).Rows(0).Item("Kd_Customer").ToString
                txtNamaCust.Text = dSO.Tables(0).Rows(0).Item("Nama_Customer").ToString
                txtAlamat1.Text = dSO.Tables(0).Rows(0).Item("Alamat1").ToString
                txtkota1.Text = dSO.Tables(0).Rows(0).Item("Kota1").ToString
                txtTlp1.Text = dSO.Tables(0).Rows(0).Item("No_Telepon1").ToString
                txtAlamat2.Text = dSO.Tables(0).Rows(0).Item("Alamat2").ToString
                txtKota2.Text = dSO.Tables(0).Rows(0).Item("Kota2").ToString
                txtTlp2.Text = dSO.Tables(0).Rows(0).Item("No_Telepon2").ToString
                txtFax.Text = dSO.Tables(0).Rows(0).Item("No_Fax").ToString
                txtNpwp.Text = dSO.Tables(0).Rows(0).Item("No_NPWP").ToString
                txtEmail.Text = dSO.Tables(0).Rows(0).Item("Email").ToString
                txtCP.Text = dSO.Tables(0).Rows(0).Item("Kontak_Person").ToString
                cbGrade.Text = dSO.Tables(0).Rows(0).Item("Grade").ToString
                LookUpEditArea.EditValue = dSO.Tables(0).Rows(0).Item("Kode_Area").ToString
                cbStatus.Text = dSO.Tables(0).Rows(0).Item("Status").ToString
                txtKet.Text = dSO.Tables(0).Rows(0).Item("Keterangan").ToString
                txtRupiah.Text = dSO.Tables(0).Rows(0).Item("Norek_Bank_Rupiah").ToString
                txtValas.Text = dSO.Tables(0).Rows(0).Item("Norek_Bank_Valas").ToString
                txtlimitPIDR.Text = dSO.Tables(0).Rows(0).Item("Limit_Piutang_Rupiah").ToString
                txtLimitPValas.Text = dSO.Tables(0).Rows(0).Item("Limit_Piutang_Valas").ToString

            End If
        End If
    End Sub

    Public Sub save_click()
      
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Customer where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_Customer") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_Customer").NewRow
            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
            ''''''''''
            row.Item("Kd_Customer") = getCustomer()
            row.Item("Nama_Customer") = txtNamaCust.Text
            row("Alamat1") = txtAlamat1.Text
            row("Kota1") = txtkota1.Text
            row("No_Telepon1") = txtTlp1.Text
            row("Kota2") = txtKota2.Text
            row("Alamat2") = txtAlamat2.Text
            row("No_Telepon2") = txtTlp2.Text
            row("No_FAX") = txtFax.Text
            row("No_NPWP") = txtNpwp.Text
            row("Email") = txtEmail.Text
            row("Kontak_Person") = txtCP.Text
            row("Grade") = cbGrade.Text
            row("Kode_Area") = LookUpEditArea.EditValue
            row("Status") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Keterangan") = txtKet.Text
            row("Norek_Bank_Rupiah") = txtRupiah.Text
            row("Norek_Bank_Valas") = txtValas.Text
            row("Limit_Piutang_Rupiah") = txtlimitPIDR.Text
            row("Limit_Piutang_Valas") = txtLimitPValas.Text
            row("Rec_Stat") = ""
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            ''''''''''
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
            row.Item("Nama_customer") = txtNamaCust.Text
            row("Alamat1") = txtAlamat1.Text
            row("Kota1") = txtkota1.Text
            row("No_Telepon1") = txtTlp1.Text
            row("Kota2") = txtKota2.Text
            row("Alamat2") = txtAlamat2.Text
            row("No_Telepon2") = txtTlp2.Text
            row("No_FAX") = txtFax.Text
            row("No_NPWP") = txtNpwp.Text
            row("Email") = txtEmail.Text
            row("Kontak_Person") = txtCP.Text
            row("Grade") = cbGrade.Text
            row("Status") = IIf(cbStatus.Text = "Y", "AKTIF", "TIDAK AKTIF")
            row("Keterangan") = txtKet.Text
            row("Norek_Bank_Rupiah") = txtRupiah.Text
            row("Norek_Bank_Valas") = txtValas.Text
            row("Limit_Piutang_Rupiah") = txtlimitPIDR.Text
            row("Limit_Piutang_Valas") = txtLimitPValas.Text
            row("Rec_Stat") = ""
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        End If

        
        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        If myDAO.save(dSO, DA, STATE) Then
            MsgBox("Saved")
            STATE = "EDIT"
            txtKodeCust.Text = dSO.Tables(0).Rows(0)("Kd_Customer")
            Clear_ALL()
            ' and Do another saved Thing
        ElseIf myDAO.save(dSO, DA, STATE) Then
            MsgBox("Updated")
            Clear_ALL()
        Else
            'MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Saving Data")
            ' klau error disini
        End If
    End Sub
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prn = getParent(Me)
        connect()
        myDAO.conn = sqlconn
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Area", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_AREA")
        LookUpEditArea.Properties.DataSource = dSO.Tables("LOOKUP_SIF_AREA")
        LookUpEditArea.Properties.ValueMember = "Kode_Area"
        LookUpEditArea.Properties.DisplayMember = "Nama_Area"
    End Sub

   
   

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
        STATE = "EDIT"

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
        Clear_ALL()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_click()
    End Sub
End Class