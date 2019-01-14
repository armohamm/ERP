Imports DataAcess
Imports System.Data.SqlClient
Public Class frmKendaraan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain   '<-- untuk mengakses frmMain

    Dim dSO, DsKend As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DAs As SqlClient.SqlDataAdapter
    Dim myDAO As New DataAcess.SatuanDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With

    End Sub
    Public Sub clear_all()
        txtKodeKnd.Text = ""
        txtNamaKnd.Text = ""
        txtKeterangan.Text = ""
        txtNopol.Text = ""
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

        End With
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Public Sub cancel_click()
        default_cancel(prn)

        setStatus()
        Me.Enabled = False
        STATE = ""
        clear_all()
    End Sub
    Private Function getNextNumberKendaraan() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kendaraan,'x1'),4,10) as numeric)) from SIF.DBO.SIF_Kendaraan", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "KDR001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = "KDR" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Public Sub delete_click()
        If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataRow In dSO.Tables(0).Rows
                dr.Delete()
            Next
            If myDAO.save(dSO, DA) Then
                MsgBox("Deleted")
                STATE = ""
                ' and Do another saved Thing
                clear_all()
            Else
                MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
                ' klau error disini
            End If
        End If
    End Sub
    Public Sub edit_click()
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
        End With

        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kendaraan", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Kendaraan")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kendaraan where [Kode_Kendaraan]='" & frmCari.row("Kode_Kendaraan") & "'", sqlconn))
            DA.Fill(dSO, "SIF_Kendaraan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txtKodeKnd.Text = dSO.Tables(0).Rows(0).Item("Kode_Kendaraan").ToString
                txtNamaKnd.Text = dSO.Tables(0).Rows(0).Item("Nama_Kendaraan").ToString
                txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("keterangan").ToString
                txtNopol.Text = dSO.Tables(0).Rows(0).Item("No_Polisi").ToString
                cbStatus.Text = IIf(dSO.Tables("SIF_Kendaraan")(0)("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If

    End Sub

    Public Sub save_click()
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kendaraan where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_Kendaraan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_Kendaraan").NewRow
            row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            row("Kode_Kendaraan") = txtKodeKnd.Text
            row("Nama_Kendaraan") = txtNamaKnd.Text
            row("No_Polisi") = txtNopol.Text
            row("Keterangan") = txtKeterangan.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            '  row.Item("Kode_Wilayah") = txtKode.Text ' klau edit ini tidak boleh diubah
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
            row("Nama_Kendaraan") = txtNamaKnd.Text
            row("No_Polisi") = txtNopol.Text
            row("Keterangan") = txtKeterangan.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        End If

        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        ElseIf STATE = "EDIT" Then
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.Update(dSO.Tables(0))
            dSO.Tables(0).AcceptChanges()
        End If
        If myDAO.save(dSO, DA) Then
            showMessages("Data Berhasil di Update..!", 14)
            STATE = "EDIT"
            cancel_click()
            ' and Do another saved Thing
        Else
            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Saveing Data")
            ' klau error disini
        End If
    End Sub
    Sub Tampil_GC_Kendaraan()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select k.Kode_Kendaraan, K.Nama_Kendaraan, K.Kapasitas, K.No_Polisi,K.Rec_Stat,K.Keterangan from SIF.dbo.SIF_Kendaraan K", sqlconn))
        DAs.Fill(DsKend, "Kendaraan")
        GC_Kendaraan.DataSource = DsKend.Tables(0)
        GVSpon.BestFitColumns()
    End Sub
    Private Sub frmKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = getParent(Me)
        prn = obj
        Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        Pnl.Left = (Me.Width - Pnl.Width) / 2
        Pnl.Top = Pnl.Height / 3

        connect()
        myDAO.conn = sqlconn
        Tampil_GC_Kendaraan()
        'obj = getParent(Me)
        'prn = obj
        'Me.BackgroundImage = Parent.BackgroundImage
        ''pnl.Height = Me.Height - 2
        'Pnl.Left = (Me.Width - Pnl.Width) / 2
        'Pnl.Top = (Me.Height - Pnl.Height) / 2
    End Sub

End Class