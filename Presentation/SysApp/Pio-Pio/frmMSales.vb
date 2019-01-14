Imports System.Data.SqlClient
Public Class frmMSales
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, dsedit As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA1,dapeg, daedit As SqlClient.SqlDataAdapter
    'Dim myDAO As New DataAcess.CustomerDAO
    Dim Buildernya As New SqlClient.SqlCommandBuilder

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
        STATE = "ADD" '<-- set state add
        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()

        txtNamaSales.Focus()

    End Sub

    Public Sub cancel_click()
        default_cancel(prn)

        setStatus()
        Me.Enabled = False
        STATE = ""
        Clear_ALL()
    End Sub
    Private Sub Clear_ALL()
        txtKodeSales.Text = ""
        txtNamaSales.Text = ""
        LEPegawai.EditValue = vbNullString
        txtNamaSales.Text = ""
        LookUpEditArea.EditValue = vbNullString
        LEDep.EditValue = vbNullString
        cbStatus.Text = ""
        txtKet.Text = ""
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()

        If MsgBox("Hapus Data SALES ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO1.Tables("SIF_SALES") Is Nothing Then delete(dSO1.Tables("SIF_SALES").Rows)


            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dSO1.Tables("SIF_Sales") Is Nothing Then dSO1.Tables("SIF_Sales").Clear()

        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where Kode_Sales='" & kode & "'", sqlconn))
        DA1.Fill(dSO1, "SIF_Sales")

        If dSO1.Tables("SIF_Sales").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean As String
            row = dSO1.Tables("SIF_Sales").Rows(0)
            txtKodeSales.Text = row.Item("Kode_Sales").ToString
            txtNamaSales.Text = row.Item("Nama_Sales").ToString
            LEPegawai.EditValue = row.Item("Kode_Pegawai")
            LEDep.EditValue = row.Item("kode_Departemen")
            LEWil.EditValue = row.Item("kode_wilayah").ToString
            LookUpEditArea.EditValue = row.Item("kode_area")
            bolean = row.Item("Rec_Stat").ToString
            cbStatus.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
            txtKet.Text = row.Item("Keterangan").ToString

        End If

    End Sub
    Public Sub edit_click()


        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Sales as [Nomor],Nama_Sales as [Nama Sales] from sif.dbo.SIF_Sales", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_Sales") Is Nothing Then dsedit.Tables("lookup_Sales").Clear()
        daedit.Fill(dsedit, "lookup_Sales")
        frmCari.set_dso(dsedit.Tables("lookup_Sales")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
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
        ' End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim isvalid As Boolean = True
        If txtNamaSales.Text = "" Then
            ErrorProvider1.SetError(txtNamaSales, "Nama belum diisi!")
            isvalid = False
        Else
            ErrorProvider1.SetError(txtNamaSales, "")
        End If

        If Not isDelete Then
            If STATE = "ADD" Then
                dSO1 = New DataSet
                DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where 1=0", sqlconn))
                DA1.Fill(dSO1, "SIF_Sales") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO1.Tables("SIF_Sales").NewRow
                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                ''''''''''''''''''''''''''''''''''''''''''
                row.Item("Kode_Sales") = getNoTrans("MSALES", getTanggal)
                txtKodeSales.Text = row.Item("Kode_Sales")
                row.Item("Nama_Sales") = txtNamaSales.Text
                row("Kode_Departemen") = LEDep.EditValue
                row("Kode_Pegawai") = LEPegawai.EditValue
                row("Kode_Area") = LookUpEditArea.EditValue
                row("Kode_Wilayah") = LEWil.EditValue
                row("Keterangan") = txtKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username

                row("Program_Name") = Me.Name
                ''''''''''
            ElseIf STATE = "EDIT" Then
                row = dSO1.Tables(0).Rows(0)
                row.Item("Nama_Sales") = txtNamaSales.Text
                row("Kode_Departemen") = LEDep.EditValue
                row("Kode_Pegawai") = LEPegawai.EditValue
                row("Kode_Area") = LookUpEditArea.EditValue
                row("Kode_Wilayah") = LEWil.EditValue
                row("Keterangan") = txtKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")

                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
            End If
        End If

        If STATE = "ADD" Then
            dSO1.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA1)
            DA1.UpdateCommand = Buildernya.GetUpdateCommand()
            DA1.InsertCommand = Buildernya.GetInsertCommand()
            DA1.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA1.UpdateCommand.Transaction = BTRANS
            DA1.InsertCommand.Transaction = BTRANS
            DA1.DeleteCommand.Transaction = BTRANS

            DA1.Update(dSO1.Tables("SIF_Sales"))
            dSO1.Tables("SIF_Sales").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")


        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try


    End Sub


    Private Sub view_Area()
        If Not dSO.Tables("LOOKUP_SIF_AREA") Is Nothing Then dSO.Tables("LOOKUP_SIF_AREA").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Area,  Nama_Area from sif.dbo.SIF_Area where kd_wilayah='" & LEWil.EditValue.ToString & "'", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_AREA")
        LookUpEditArea.Properties.DataSource = dSO.Tables("LOOKUP_SIF_AREA")
    End Sub
    Private Sub view_Wilayah()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah,  Nama_Wilayah from sif.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "Wilayah")
        LEWil.Properties.DataSource = dSO.Tables("Wilayah")

    End Sub

    Sub View_Pegawai()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Pegawai", sqlconn))
        DA.Fill(dSO, "View_Peg")
        LEPegawai.Properties.DataSource = dSO.Tables("View_Peg")

    End Sub
    Sub View_departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(dSO, "View_Dep")
        LEDep.Properties.DataSource = dSO.Tables("View_Dep")

    End Sub
    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connect()
        view_Wilayah()
        View_Pegawai()
        View_departemen()
        prn = getParent(Me)
    End Sub
   

    Private Sub validasi_entry(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            ErrorProvider1.SetError(sender, "Peringatan! Mohon isi data dengan BENAR")
            e.Handled = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtTlp1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtTlp2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNpwp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'validasi_entry(sender, e)

        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46 'spasi dan bekspes
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
        Clear_ALL()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        edit_click()
        STATE = "EDIT"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub LEWil_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEWil.EditValueChanged
        If Not LEWil.EditValue Is Nothing Then view_Area()
        Dim dr As SqlDataReader = New SqlCommand("select Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah and kode_wilayah='" & LEWil.EditValue & "'", sqlconn).ExecuteReader
        'Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah ", sqlconn).ExecuteReader
        If dr.Read() Then
            LookUpEditArea.EditValue = dr(0)
        Else
            LookUpEditArea.EditValue = vbNullString
        End If

        dr.Close()
        'view_Area()
    End Sub


End Class