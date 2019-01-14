Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data
Imports System.Windows.Forms
Public Class frmSpk
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim row As DataRow
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public com As New SqlCommand
    Public skapasitas As TextBox
    Public FirstName As TextBox
    Public txtkapasitas As String
    Public State As String
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmSpk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = getParent(Me)
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_trans from PROD.dbo.PROD_spk_m order by no_trans", sqlconn))
        da1.Fill(ds1, "rph")

        da2 = New SqlDataAdapter(New SqlCommand(" select * from PROD.dbo.PROD_spk_m where no_trans='" & txtNoRph.EditValue & "'", sqlconn))
        ds2.Reset()
        da2.Fill(ds2, "srph")

        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Barang", sqlconn))
        da3.Fill(ds3, "nmBrg")

        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        ds4.Reset()
        da4.Fill(ds4, "jnsKegiatan")

        gc.DataSource = ds2.Tables("srph")

        da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_trans='" & txtNoRph.EditValue & "'", sqlconn))
        da5.Fill(ds5, "prodspkm")
        gc1.DataSource = ds5.Tables("prodspkm")


        State = "ADD"

        txtTgl_Rph.Text = Now
        txtNoRph.Properties.DataSource = ds1.Tables("rph")
        txtNoRph.Properties.ValueMember = "no_trans"
        txtNoRph.Properties.DisplayMember = "no_trans"

        lkKegiatan.DataSource = ds4.Tables("jnsKegiatan")
        lkKegiatan.ValueMember = "Id_Data"
        lkKegiatan.DisplayMember = "Desc_Data"



        lkNmBrg.DataSource = ds3.Tables("nmBrg")
        lkNmBrg.ValueMember = "Kode_Barang"
        lkNmBrg.DisplayMember = "Nama_Barang"

        gv.Columns(0).ColumnEdit = lkKegiatan
        gv1.Columns(0).ColumnEdit = lkNmBrg

        gv.OptionsView.NewItemRowPosition = 0

    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True

        'End With
        ' setStatus()
        'btnSave = True
        'btnCancel = True
        'btnDelete = True
        'btnEdit = False
        'btnadd = False
        'setStatus()
        'btnSave = True
        'btnCancel = True
        'btnDelete = False
        'btnEdit = False
        'btnAdd = False
        'setStatus()
        State = "ADD"
        

    End Sub

    Public Sub edit_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True

        'End With
        ' setStatus()
        State = "EDIT" '<-- set state add
        'btnSave = True
        'setStatus()
    End Sub

    Public Sub cancel_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        
        State = " " '<-- set state add

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub save_click()
        If txtNoRph.EditValue <> "" Then
            Try
                If gv.RowCount <> 0 Then
                    myBuilder = New SqlClient.SqlCommandBuilder(da2)
                    da2.UpdateCommand = myBuilder.GetUpdateCommand
                    da2.Update(ds2.Tables("srph"))
                    ds2.Tables("srph").AcceptChanges()
                    showMessages("Saved..")
                Else
                    Me.Close()
                End If
                cancel_click()

                gv.OptionsView.NewItemRowPosition = 0

            Catch err As Exception
                MessageBox.Show(err.Message, "Gagal Simpan")
            End Try

        Else
            MessageBox.Show("Pilih No RPH Terlebih Dahulu!")
        End If
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        'GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
    End Sub

    Private Sub txtNoRph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoRph.EditValueChanged

        da2 = New SqlDataAdapter(New SqlCommand(" select * from PROD.dbo.PROD_spk_m where no_trans='" & txtNoRph.EditValue & "'", sqlconn))
        ds2.Reset()
        da2.Fill(ds2, "srph")
        gc.DataSource = ds2.Tables("srph")

        da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_trans='" & txtNoRph.EditValue & "'", sqlconn))
        ds5.Reset()
        da5.Fill(ds5, "prodspkm")
        gc1.DataSource = ds5.Tables("prodspkm")

        'gv.OptionsView.NewItemRowPosition = 1

        If gv.RowCount > 0 Then
            btnSave = True
            btnCancel = True
            btnDelete = False
            btnEdit = False
            btnAdd = False
            setStatus()
        Else
            btnSave = False
            btnCancel = True
            btnDelete = False
            btnEdit = False
            btnAdd = False
            setStatus()
        End If
        
    End Sub

    Private Sub gv_InvalidRowException1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        'e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        
        'Dim view As ColumnView = CType(sender, ColumnView)
        'Dim jml As GridColumn = view.Columns("jumlah")
        'Dim kps As GridColumn = view.Columns("kapasitas")
        'Dim jml2 As Int32 = CType(view.GetRowCellValue(e.RowHandle, jml), Int32)
        'Dim kps2 As Int32 = CType(view.GetRowCellValue(e.RowHandle, kps), Int32)


        'If kps2 > jml2 Then

        '    e.Valid = False

        '    view.SetColumnError(kps, "Nilai kapasitas Produksi tidak lebih boleh dari Jumlah Produksi")
        'End If

    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        'ColumnView view = sender as ColumnView


    End Sub
End Class