Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class frmDPM
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, da4 As SqlClient.SqlDataAdapter
    Dim dS, ds1, ds2, ds3, ds4 As New DataSet
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
        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True

        'End With
        ' setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Sub View_Barang()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "View_Barang")
        repBarang.DataSource = ds2.Tables("View_Barang")
    End Sub
    'Sub View_Data_Satuan()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from sif.dbo.SIF_Barang", sqlconn))
    '    DA.Fill(dSO, "View_Kode_Stokx")
    '    LookUpEditKdStok.DataSource = dSO.Tables("View_Kode_Stokx")
    'End Sub
    Sub View_Departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(dS1, "View_D")
        LookUpEditDep.Properties.DataSource = ds1.Tables("View_D")
    End Sub
    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("No_Seq") = i
            i += 1
        Next

    End Sub
    Public Function getNextNumberDPM(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(No_DPM,'x1'),4,10) as numeric)) from PURC.DBO.PURC_DPM", sqlconn, bgtrans).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "DPM000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "DPM" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Private Sub frmDPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'txtNoDPM.Text = getNextNumberDPM()
        View_Departemen()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(dS, "VBarang")
        repBarang.DataSource = dS.Tables("VBARANG")

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM where 1=0", sqlconn))
        da3.Fill(ds3, "PD")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D where 1=0", sqlconn))
        da4.Fill(ds4, "PDD")
        GC.DataSource = ds4.Tables("PDD")


    End Sub
    Public Sub save_click()
        Dim BTRANS As SqlTransaction

        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        da3.InsertCommand = Buildernya.GetInsertCommand()
        da3.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da3.UpdateCommand.Transaction = BTRANS
        da3.InsertCommand.Transaction = BTRANS
        da3.DeleteCommand.Transaction = BTRANS

        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS

        State = "ADD"
        If State = "ADD" Then
           
            row = ds3.Tables("PD").NewRow
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = ds3.Tables("PD").Rows(0)
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("No_DPM") = getNextNumberDPM(BTRANS)
        row.Item("Tgl_DPM") = dtTanggal.EditValue
        row.Item("No_Ref") = txtRef.Text
        row.Item("Departemen") = LookUpEditDep.EditValue
        row.Item("Keterangan") = txtKeterangan.Text
        row.Item("Status") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
        row.Item("Program_Name") = Me.Name

        If State = "ADD" Then
            ds3.Tables("PD").Rows.Add(row)
        End If
        For Each rows As DataRow In ds4.Tables("PDD").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("No_DPM") = row.Item("No_DPM")
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = "1"

            Else
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
            End If
            rows.Item("Program_name") = Me.Name

        Next

        Try

            da3.Update(ds3.Tables("PD"))
            da4.Update(ds4.Tables("PDD"))

            ds3.Tables("PD").AcceptChanges()
            ds4.Tables("PDD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_Seq") = GV.RowCount + 1
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dS.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Satuan") = rw("Kd_Satuan")
        End If
        If e.Column Is QTYPR Then
            GV.GetRow(e.RowHandle).item("Qty_sisa") = GV.GetRow(e.RowHandle).item("Qty").ToString - GV.GetRow(e.RowHandle).item("Qty_PR").ToString
        End If
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        If dtTanggal.Text = "" Then
            'showMessages("Tanggal Harap diisi !")
            MsgBox("Tanggal Harap diisi !")
            dtTanggal.Focus()
        End If
        save_click()
    End Sub

    Private Sub GC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
End Class