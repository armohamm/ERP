Imports System.IO
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Public Class frmJabatan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim obj As Object
    Dim dSO, dSO1, dS2, Dsete As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DA1, DA2 As SqlClient.SqlDataAdapter
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Dim bolean As String
  
    Public Sub add_click()
        STATE = "ADD" '<-- set state= add

        ' MessageBox.Show(a)
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        default_add(prn)
        btnSave = True
        btnCancel = True
        btnEdit = False
        btnadd = False
        setStatus()
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        TxtNama.Focus()

    End Sub
    Public Sub clear_field()
        txtKeterangan.Text = ""
        txtKode.Text = ""
        txtNama.Text = ""
    End Sub
    Public Sub cancel_click()
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnSave = False
        btnDelete = False
        clear_field()
        setStatus()
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        Me.Enabled = True
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
                cancel_click()
            Catch e As Exception
                dSO.Tables(0).RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dSO.Tables("SIF_Jabatan") Is Nothing Then dSO.Tables("SIF_Jabatan").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF_Jabatan where Kode_Jabatan='" & kode & "'", sqlconn))
        DA.Fill(dSO, "SIF_Jabatan")



        If dSO.Tables("SIF_Jabatan").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean As String
            row = dSO.Tables("SIF_Jabatan").Rows(0)
            txtKode.Text = row.Item("Kode_Jabatan").ToString
            TxtNama.Text = row.Item("Nama_Jabatan").ToString
            TxtKeterangan.Text = row.Item("Keterangan").ToString
            bolean = row.Item("Rec_Stat").ToString
            ComboBox1.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
        End If

    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Jabatan as [Kode Jabatan],Nama_Jabatan as [Nama Jabatan], Keterangan as [Keterangan],Rec_Stat as [status] from SIF_Jabatan", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dS2.Tables("LOOKUP_SIF_Jabatan") Is Nothing Then dS2.Tables("LOOKUP_SIF_Jabatan").Clear()
        DA2.Fill(dS2, "LOOKUP_SIF_Jabatan")


        frmCari.set_dso(dS2.Tables("LOOKUP_SIF_Jabatan")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then


            reload_table(frmCari.row(0))


            STATE = "EDIT"

            btnDelete = True
            btnSave = True
            btnCancel = True
            btnEdit = False
            btnadd = False
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            setStatus()



        Else
            cancel_click()
            STATE = ""
        End If




       
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim BTRANS As SqlTransaction
        Dim isvalid As Boolean = True

        If Not isDelete Then
            If STATE = "ADD" Then
                dSO = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Jabatan where 1=0  ", sqlconn))
                DA.Fill(dSO, "SIF_Jabatan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO.Tables("SIF_Jabatan").NewRow
                row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("Rec_Stat") = IIf(ComboBox1.Text = "AKTIF", "Y", "T")
                row.Item("Kode_Jabatan") = getNoTrans("MJAB", getTanggal)
                row.Item("Nama_Jabatan") = TxtNama.Text
                row.Item("Keterangan") = TxtKeterangan.Text
                row.Item("Last_Created_By") = umum.username
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username
                row.Item("Program_Name") = Me.Name

            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("SIF_Jabatan").Rows(0)
                row.Item("Rec_Stat") = IIf(ComboBox1.Text = "AKTIF", "Y", "T")
                row.Item("Kode_Jabatan") = TxtKode.Text
                row.Item("Nama_Jabatan") = TxtNama.Text
                row.Item("Keterangan") = TxtKeterangan.Text
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = umum.username
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username
                row.Item("Program_Name") = Me.Name
            End If
        End If


        If STATE = "ADD" Then
            dSO.Tables("SIF_Jabatan").Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            'If STATE = "ADD" Then
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetInsertCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            'DA.UpdateCommand = myBuilder.GetDeleteCommand()

            'BTRANS = sqlconn.BeginTransaction("1")
            'DA.UpdateCommand.Transaction = BTRANS
            'DA.InsertCommand.Transaction = BTRANS
            'DA.DeleteCommand.Transaction = BTRANS
           
            DA.Update(dSO.Tables("SIF_Jabatan"))
            dSO.Tables("SIF_Jabatan").AcceptChanges()
            STATE = "EDIT"
            'BTRANS.Commit()
            TxtKode.Text = row("Kode_Jabatan")
            showMessages("Saved....")
            If Not dSO Is Nothing Then
                dSO.Clear()
            End If
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Jabatan", sqlconn))
            DA2.Fill(Dsete, "JABATAN")
            Dsete.Tables("JABATAN").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Jabatan", sqlconn))
            DA2.Fill(Dsete, "JABATAN")
            GridControl1.DataSource = Dsete.Tables("JABATAN")

        Catch e As Exception
            'BTRANS = sqlconn.BeginTransaction("1")
            'BTRANS.Rollback()
            dSO.Tables(0).RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical)

        End Try
        'setStatus()
        'btnadd = True
        'btnSave = True


    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmJabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Jabatan", sqlconn))
        DA2.Fill(Dsete, "JABATAN")
        GridControl1.DataSource = Dsete.Tables("JABATAN")
        GridView1.BestFitColumns()
        prn = getParent(Me)
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        Me.Enabled = True
        'Me.BackgroundImage = Parent.BackgroundImage
        ''pnl.Height = Me.Height - 2
        'pnl.Left = (Me.Width - pnl.Width) / 2
        'pnl.Top = (Me.Height - pnl.Height) / 2

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
    'Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
    '    dSO = New DataSet
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan where Kode_Jabatan='" & GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Jabatan").ToString & "'", sqlconn))
    '    DA.Fill(dSO, "SIF_Jabatan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

    '    TxtKode.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Jabatan")
    '    TxtNama.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Nama_Jabatan")
    '    TxtKeterangan.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Keterangan")
    '    ComboBox1.Text = IIf(GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
    '    STATE = "EDIT"
    '    XtraTabControl1.SelectedTabPage = XtraTabPage1
    '    txtNama.Focus()
    '    setStatus()
    'End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jabatan where Kode_Jabatan='" & GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Jabatan").ToString & "'", sqlconn))
        DA.Fill(dSO, "SIF_Jabatan") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

        TxtKode.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Jabatan")
        TxtNama.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Nama_Jabatan")
        TxtKeterangan.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Keterangan")
        ComboBox1.Text = IIf(GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
        STATE = "EDIT"
        setStatus()
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = True
        prn.btnAdd.Enabled = False
        prn.btnEdit.Enabled = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        TxtNama.Focus()
    End Sub
End Class
