Imports DataAcess
Imports System.Data.SqlClient

Public Class frmMasterGudang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dSO, dsedit, DsGudang As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, daedit, DAs As SqlClient.SqlDataAdapter
    'Dim myDAO As New DataAcess.GudangDAO
    Dim myBuilder, Buildernya As New SqlClient.SqlCommandBuilder

    Private Function getNextNumber() As String
        Dim hasil, temp As String
        'Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kode_Kain,'x1'),3,10) as numeric)) from SIF.DBO.SIF_Kain", sqlconn).ExecuteReader
        Dim sqlDR As SqlDataReader = New SqlCommand("select count(Kode_Gudang) from DBO.SIF_Gudang", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "G0001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            hasil = "G" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub clear_all()
        txtKodeGudang.Text = ""
        txtNamaGudang.Text = ""
        txtKeterangan.Text = ""
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        STATE = "ADD" '<-- set state add
        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

   
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim isvalid As Boolean = True
        If txtNamaGudang.Text = "" Then
            ErrorProvider1.SetError(txtNamaGudang, "Nama Gudang belum diisi!")
            isvalid = False
        Else
            ErrorProvider1.SetError(txtNamaGudang, "")
        End If
        If Not isDelete Then

            If STATE = "ADD" Then
                dSO = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Gudang where 1=0", sqlconn))
                DA.Fill(dSO, "SIF_Gudang") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_.....(nama table bisa diisi sembarang)

                row = dSO.Tables("SIF_Gudang").NewRow
                row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("Kode_Gudang") = get_next_counter_master("G", Nothing)
                txtKodeGudang.Text = row.Item("Kode_Gudang")
                row.Item("Nama_Gudang") = txtNamaGudang.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Keterangan") = txtKeterangan.Text
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Program_Name") = Me.Name
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables(0).Rows(0)
                row.Item("Nama_Gudang") = txtNamaGudang.Text
                row("Keterangan") = txtKeterangan.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
            End If
        End If
        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("SIF_Gudang"))
            dSO.Tables("SIF_Gudang").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan...")


        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dSO.Tables("SIF_Gudang") Is Nothing Then dSO.Tables("SIF_Gudang").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_gudang where [Kode_Gudang]='" & kode & "'", sqlconn))
        DA.Fill(dSO, "SIF_Gudang")

        If dSO.Tables("SIF_Gudang").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean As String
            row = dSO.Tables("SIF_Gudang").Rows(0)
            txtKodeGudang.Text = row.Item("Kode_Gudang").ToString
            txtNamaGudang.Text = row.Item("Nama_Gudang").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            bolean = row.Item("Rec_Stat").ToString
            cbStatus.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
        End If

    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang,Nama_Gudang from sif.dbo.SIF_gudang", sqlconn)) '<- query buat ditampilkan di LOV
        If Not dsedit.Tables("LOOKUP_Gudang") Is Nothing Then dsedit.Tables("LOOKUP_Gudang").Clear()
        daedit.Fill(dsedit, "LOOKUP_Gudang")
        frmCari.set_dso(dsedit.Tables("LOOKUP_Gudang"))
        frmCari.ShowDialog()

       

        If Not frmCari.row Is Nothing Then
            reload_table(frmCari.row(0))
            STATE = "EDIT"
            btnDelete = True
            btnSave = True
            btnEdit = False
            btnadd = False
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If

        'If Not frmCari.row Is Nothing Then
        '    dSO = New DataSet
        '    daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_gudang where [Kode_gudang]='" & frmCari.row("Kode_gudang") & "'", sqlconn))
        '    daedit.Fill(dSO, "SIF_Gudang") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
        '    default_add(prn)
        '    STATE = "EDIT"
        '    btnDelete = True
        '    btnSave = True
        '    btnEdit = False
        '    btnadd = False
        '    setStatus()
        '    If dSO.Tables(0).Rows.Count > 0 Then
        '        txtKodeGudang.Text = dSO.Tables(0).Rows(0).Item("Kode_gudang").ToString
        '        txtNamaGudang.Text = dSO.Tables(0).Rows(0).Item("nama_gudang").ToString
        '        txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("keterangan").ToString
        '        cbStatus.Text = dSO.Tables(0).Rows(0).Item("Rec_Stat").ToString
        '    Else
        '        MsgBox("Data tidak diketemukan")
        '    End If
        'End If
    End Sub
    Public Sub cancel_click()
        default_cancel(prn)
        clear_all()
        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()
        'If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    For Each dr As DataRow In dSO.Tables(0).Rows
        '        dr.Delete()
        '    Next
        '    If myDAO.save(dSO, DA) Then
        '        MsgBox("Deleted")
        '        STATE = ""
        '         and Do another saved Thing
        '        clear_all()
        '    Else
        '        MsgBox(myDAO.errorMsg, MsgBoxStyle.Critical, "Error Delete Data")
        '         klau error disini
        '    End If
        'End If
        If MsgBox("Hapus Data Gudang ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("SIF_Gudang") Is Nothing Then delete(dSO.Tables("SIF_Gudang").Rows)
            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Sub TampilGC_Gudang()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select * From SIF.dbo.SIF_Gudang", sqlconn))
        DAs.Fill(DsGudang, "Gudang")
        GC_Gudang.DataSource = DsGudang.Tables(0)
        GVSpon.BestFitColumns()
    End Sub
    Private Sub frmMasterGudang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = getParent(Me)
        Panel2.Visible = False
        TampilGC_Gudang()
       End Sub

End Class