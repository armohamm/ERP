Imports DataAcess
Imports System.Data.SqlClient

Public Class frmSatuan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
 
    Dim dSO, ds_cari As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DALOOKUP As SqlDataAdapter
    'Dim myDAO As New DataAcess.SatuanDAO
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
        txtKodeSatuan.Text = ""
        txtNamaSatuan.Text = ""
        txtKeterangan.Text = ""
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
        'Load_LU_JnsSatuan()
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Public Sub cancel_click()
        default_cancel(prn)
        'LookUpEditGol.Properties.DataSource = Nothing
        setStatus()
        Me.Enabled = False
        STATE = ""
        clear_all()
    End Sub
    'Public Sub delete_click()
    '    If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        For Each dr As DataRow In dSO.Tables(0).Rows
    '            dr.Delete()
    '        Next
    '        If myDAO.save(dSO, DA) Then
    '            MsgBox("Deleted")
    '            STATE = ""
    '            ' and Do another saved Thing
    '            clear_all()
    '        Else
    '            MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
    '            ' klau error disini
    '        End If
    '    End If
    'End Sub
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Satuan", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Satuan")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Satuan where [Kode_Satuan]='" & frmCari.row("Kode_Satuan") & "'", sqlconn))
            DA.Fill(dSO, "SIF_Satuan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                LookUpEditGol.EditValue = LookUpEditGol.Properties.GetKeyValueByDisplayText(dSO.Tables(0).Rows(0).Item("Gol_Satuan").ToString)
                txtKodeSatuan.Text = dSO.Tables(0).Rows(0).Item("Kode_Satuan").ToString
                txtNamaSatuan.Text = dSO.Tables(0).Rows(0).Item("Nama_Satuan").ToString
                txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("keterangan").ToString
            Else
                MsgBox("Data tidak diketemukan")
            End If
        Else
            cancel_click()
        End If

    End Sub

    Public Sub save_click()
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Satuan where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_Satuan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_Satuan").NewRow
            row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            row("Gol_satuan") = LookUpEditGol.EditValue
            row("Kode_Satuan") = txtKodeSatuan.Text
            row("Nama_Satuan") = txtNamaSatuan.Text
            row("Keterangan") = txtKeterangan.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            '  row.Item("Kode_Wilayah") = txtKode.Text ' klau edit ini tidak boleh diubah
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
            DA.Update(dSO.Tables(0))
            dSO.Tables(0).AcceptChanges()
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
            row("Gol_satuan") = LookUpEditGol.EditValue
            row("Nama_Satuan") = txtNamaSatuan.Text
            row("Keterangan") = txtKeterangan.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.Update(dSO.Tables(0))
            dSO.Tables(0).AcceptChanges()
        End If
        showMessages("Data Berhasil di Update..!", 14)

        'If myDAO.save(dSO, DA) Then
        '    
        '    
        '    ' and Do another saved Thing
        'Else
        '    MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Saving Data")
        '    ' klau error disini
        'End If
        cancel_click()
    End Sub
    Public Sub Load_LU_JnsSatuan()
        If Not ds_cari.Tables("_lookup") Is Nothing Then ds_cari.Tables("_lookup").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct Gol_Satuan from SIF.dbo.SIF_Satuan", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        LookUpEditGol.Properties.DataSource = ds_cari.Tables("_lookup")
        LookUpEditGol.Properties.ValueMember = "Gol_Satuan"
        LookUpEditGol.Properties.DisplayMember = "Gol_Satuan"
    End Sub
    Private Sub frmSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = getParent(Me)
        prn = obj
        Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        pnl.Left = (Me.Width - pnl.Width) / 2
        pnl.Top = pnl.Height / 3
        connect()
        'myDAO.conn = sqlconn
        If Not ds_cari.Tables("_lookup") Is Nothing Then ds_cari.Tables("_lookup").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct Gol_Satuan from SIF.dbo.SIF_Satuan", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        LookUpEditGol.Properties.DataSource = ds_cari.Tables("_lookup")
        LookUpEditGol.Properties.ValueMember = "Gol_Satuan"
        LookUpEditGol.Properties.DisplayMember = "Gol_Satuan"
    End Sub

End Class