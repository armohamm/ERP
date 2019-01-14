Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSalesPoint
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim obj As Object
    Dim dSo As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA As SqlDataAdapter
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub cancel_click()
        default_cancel(prn)
        txtKode.Text = ""
        txtTglStart.EditValue = ""
        txtTglEnd.EditValue = ""
        txtPointUtama1.Text = ""
        txtPointUtama2.Text = ""
        txtPointTambahan1.Text = ""
        txtPointTambahan2.Text = ""
        txtNPU.Text = ""
        txtNPT.Text = ""
        txtKeterangan.Text = ""
        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub

    Private Sub frmSalesPoint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        prn = frmMain
    End Sub

    Public Function save_click(Optional ByVal isdelete As Boolean = False) As Boolean
        If Not isdelete Then
            If txtTglStart.Text = "" Then
                showMessages("Tanggal dimulai belum diisi ", "WARNING")
                Exit Function
            End If
            If txtTglEnd.Text = "" Then
                showMessages("Tanggal selesai belum diisi ", "WARNING")
                Exit Function
            End If
            If txtTglEnd.Text = "" Then
                showMessages("Tanggal selesai belum diisi ", "WARNING")
                Exit Function
            End If
            If txtPointUtama1.Text = "" Then
                showMessages("point utama belum diisi ", "WARNING")
                Exit Function
            End If
            If STATE = "ADD" Then
                dSo = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_sales_point where 1=0", sqlconn))
                DA.Fill(dSo, "SP") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSo.Tables("SP").NewRow
                row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = umum.username
            ElseIf STATE = "EDIT" Then
                row = dSo.Tables(0).Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username

            End If

            row.Item("Kode") = txtKode.Text
            row.Item("Start_date") = txtTglStart.EditValue
            row.Item("End_date") = txtTglEnd.EditValue
            row.Item("Point_utama1") = txtPointUtama1.Text
            row.Item("Point_utama2") = txtPointUtama2.Text
            row.Item("Point_tambah1") = txtPointTambahan1.Text
            row.Item("Point_tambah2") = txtPointTambahan2.Text
            row.Item("Nilai_point_utama") = txtNPU.Text
            row.Item("Nilai_point_tambahan") = txtNPT.Text
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Rec_Stat") = "T"
            row.Item("Program_Name") = "Sikap"

            If STATE = "ADD" Then
                dSo.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
            End If
        End If
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(dSo.Tables(0))
            STATE = "EDIT"
            showMessages("Data telah diproses")
        Catch e As Exception
            dSo.Tables(0).RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        'default_add(prn)
        ' setStatus()
        STATE = "ADD" '<-- set state= add

    End Sub
    Public Sub edit_click()
        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM [SIF].[dbo].[SIF_Sales_Point]", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSo, "SP")
        frmCari.set_dso(dSO.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from sif.dbo.SIF_Sales_Point where kode='" & frmCari.row("kode") & "'", sqlconn))
            DA.Fill(dSo, "SP") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            'default_add(prn)
            STATE = "EDIT"
            'setStatus()
            If dSo.Tables(0).Rows.Count > 0 Then
                row = dSo.Tables(0)(0)
                txtKode.Text = row.Item("Kode").ToString
                txtTglStart.EditValue = row.Item("Start_date").ToString
                txtTglEnd.EditValue = row.Item("End_date").ToString
                txtPointUtama1.Text = row.Item("Point_utama1").ToString
                txtPointUtama2.Text = row.Item("Point_utama2").ToString
                txtPointTambahan1.Text = row.Item("Point_tambah1").ToString
                txtPointTambahan2.Text = row.Item("Point_tambah2").ToString
                txtNPU.Text = row.Item("Nilai_point_utama").ToString
                txtNPT.Text = row.Item("Nilai_point_tambahan").ToString
                txtKeterangan.Text = row.Item("Keterangan").ToString
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_click() ' cuman manggil fungsi doang

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus data sales poin? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            dSo.Tables(0).Rows(0).Delete()
            save_click(True)
            cancel_click()
        End If
    End Sub
    Public Sub cetak_click()

    End Sub
End Class