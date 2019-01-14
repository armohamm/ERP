Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPO
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    ' Dim row As DataRow
    Dim DA, da2, da3, da4, da5, da6, da7 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

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

        End With
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
  
    Sub View_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub
    Sub View_Choice_supp()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_pr from PURC.dbo.PURC_CHOICE_SUPP", sqlconn))
        da7.Fill(ds7, "View_Choice_supp")
        LEPR.Properties.DataSource = ds7.Tables("View_Choice_supp")
    End Sub
    Sub View_Valuta()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        LEValuta.Properties.DataSource = ds6.Tables("View_Valuta")

    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub
    

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("satuan") = rw("Kd_Satuan")
        End If
        If e.Column Is QTY Then
            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString

        End If

    End Sub
    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        View_Supplier()
        View_Valuta()
        View_Choice_supp()

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(dS, "VBarang")
        repBarang.DataSource = dS.Tables("VBARANG")

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where 1=0", sqlconn))
        da3.Fill(ds3, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_cabang,tipe_trans,No_Po,no_seq,kd_stok,satuan,qty,harga,qty*harga as total,diskon,keterangan from PURC.dbo.PURC_PO_D where 1=0", sqlconn))
        da4.Fill(ds4, "POD")
        GC.DataSource = ds4.Tables("POD")
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = ""
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        txtSubTotal.Text = Total.SummaryText
    End Sub

    Private Sub cbFlag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFlag.SelectedIndexChanged
       
    End Sub

    Private Sub cbFlag_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFlag.SelectedValueChanged
        If txtJmlDiskon.Text <> "" And cbFlag.Text = "PPN SETELAH DISKON" Then
            txtJmlPPN.Text = txtSubTotal.Text - txtJmlDiskon.Text - 10 / 100
        End If
    End Sub
End Class