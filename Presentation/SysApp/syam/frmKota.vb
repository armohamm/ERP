Public Class frmKota 
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

    End Sub
    Public Sub clear_field()
        txtKeterangan.Text = ""
        txtKode.Text = ""
        txtNama.Text = ""
    End Sub

    Public Sub cancel_click()
        default_cancel(prn)
        clear_field()
        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub

    Public Sub delete_click()
        If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataRow In dSO.Tables(0).Rows
                dr.Delete()
            Next
            Try
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
                DA.Update(dSO.Tables(0))
                dSO.Tables(0).AcceptChanges()
                STATE = ""
                showMessages("Data Telah Dihapus")
                cancel_click 
            Catch e As Exception
                dSO.Tables(0).RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_KOTA", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "LOOKUP_SIF_UKURAN")
        frmCari.set_dso(dSO.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kota where Kode_Kota='" & frmCari.row("Kode_Kota").ToString & "'", sqlconn))
            DA.Fill(dSO, "SIF_UKURAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            txtKode.Text = dSO.Tables("SIF_UKURAN")(0)("Kode_Kota").ToString
            txtNama.Text = dSO.Tables("SIF_UKURAN")(0)("Nama_Kota").ToString
            txtKeterangan.Text = dSO.Tables("SIF_UKURAN")(0)("Keterangan").ToString
            optState.EditValue = dSO.Tables("SIF_UKURAN")(0)("Rec_Stat").ToString
            default_add(prn)
            STATE = "EDIT"
            setStatus()
            If dSO.Tables(0).Rows.Count > 0 Then
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

    Public Sub save_click()
        If STATE = "ADD" Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kota where 1=0", sqlconn))
            DA.Fill(dSO, "SIF_UKURAN") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            row = dSO.Tables("SIF_UKURAN").NewRow
            row.Item("Kd_Cabang") = kdcabang  ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("Kode_Kota") = getNoTrans("MKOTA", getTanggal)
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
        End If

        row.Item("Rec_Stat") = optState.Text

        row.Item("Nama_Kota") = txtNama.Text
        row.Item("Keterangan") = txtKeterangan.Text
        row("Rec_Stat") = optState.EditValue
        row.Item("Last_Create_Date") = Now
        row.Item("Last_Created_By") = umum.username
        row.Item("Last_Update_Date") = Now
        row.Item("Last_Updated_By") = umum.username
        row.Item("Program_Name") = Me.Name
        If STATE = "ADD" Then
            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            txtKode.Text = row.Item("Kode_Kota")
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(dSO.Tables(0))
            STATE = "EDIT"
            showMessages("Saved....")
        Catch e As Exception
            dSO.Tables(0).RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click() ' cuman manggil fungsi doang

    End Sub

    Private Sub kosong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        obj = getParent(Me)
        prn = obj
        Me.BackgroundImage = Parent.BackgroundImage
        'pnl.Height = Me.Height - 2
        pnl.Left = (Me.Width - pnl.Width) / 2
        pnl.Top = (Me.Height - pnl.Height) / 2

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub
End Class