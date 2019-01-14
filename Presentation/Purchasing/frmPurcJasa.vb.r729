Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPurcJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, ds3, ds4 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, da4 As SqlClient.SqlDataAdapter
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
    Private Function NomorPR(ByVal bgtrans As SqlTransaction) As String

        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_pr,'0001'),1,4))+1 from PURC.DBO.PURC_PR_D", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "0001" & "/" & "PR" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "PR" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
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
    'Sub View_NomorPR()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_Pr from PURC.DBO.PURC_PR_D", sqlconn))
    '    DA.Fill(ds1, "View_D")
    '    LENomor.Properties.DataSource = ds1.Tables("View_D")
    'End Sub
    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next

    End Sub

    Private Sub frmPurcJasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dttglpr.Text = Date.Today
        'prn = getParent(Me)
        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang from PURC.DBO.PURC_PR_D where 1=0", sqlconn))
        da4.Fill(ds4, "PRD")
        GC.DataSource = ds4.Tables("PRD")


        Dim dr As SqlDataReader = New SqlCommand(" select *  from PURC.DBO.PURC_DPM_D  where  status='APPROVE' and tipe_trans='JASA' and qty_sisa >0", sqlconn).ExecuteReader

        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "_lookup")
        lookupbrg.DataSource = ds2.Tables("_lookup")
        lookupbrg.ValueMember = "Kode_Barang"
        lookupbrg.DisplayMember = "Nama_Barang"

        While dr.Read
            Dim rw As DataRow = ds4.Tables("PRD").NewRow
            rw.Item("no_dpm") = dr.Item("no_dpm")
            rw.Item("kd_stok") = dr.Item("kd_stok")
            rw.Item("satuan") = dr.Item("satuan")
            rw.Item("qty_order") = dr.Item("qty_sisa")
            rw.Item("qty_sisa") = 0
            rw.Item("qty_pr") = 0
            ds4.Tables("PRD").Rows.Add(rw)
        End While
        GV.Columns(1).Group()
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is qty_pr Then
            GV.GetRow(e.RowHandle).item("qty_sisa") = GV.GetRow(e.RowHandle).item("qty_order").ToString - GV.GetRow(e.RowHandle).item("qty_pr").ToString
        End If

    End Sub
    Public Sub save_click()

        da3 = New SqlDataAdapter(New SqlClient.SqlCommand("select *  from PURC.DBO.PURC_DPM_D  where  status='APPROVE' and qty_sisa>0 ", sqlconn))
        da3.Fill(ds3, "DPM_D")
        ' GC.DataSource = ds3.Tables("DPM_D")

        Dim BTRANS As SqlTransaction

        'Buildernya = New SqlClient.SqlCommandBuilder(da3)
        'da3.UpdateCommand = Buildernya.GetUpdateCommand()
        'da3.InsertCommand = Buildernya.GetInsertCommand()
        'da3.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")

        'da3.UpdateCommand.Transaction = BTRANS
        'da3.InsertCommand.Transaction = BTRANS
        'da3.DeleteCommand.Transaction = BTRANS

        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS

        STATE = "ADD"
        If STATE = "ADD" Then
            txtNomor.Text = NomorPR(BTRANS)
            For Each row In ds4.Tables("PRD").Rows
                row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("No_PR") = txtNomor.Text
                row.Item("Tgl_pr") = dttglpr.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                'Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= '" & row.Item("qty_sisa") & "' where Kd_Stok='" & row.Item("Kd_Stok") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
                'Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= " & IIf(row.Item("qty_sisa").ToString = "", 0, row.Item("qty_sisa")) & " where Kd_Stok='" & row.Item("No_DPM") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
            Next


            'ElseIf STATE = "EDIT" Then
            '    For Each row In ds4.Tables("PRD").Rows
            '        row.Item("Last_Update_Date") = Now
            '        row.Item("Last_Updated_By") = username
            '        If row.RowState = DataRowState.Modified Then
            '            Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= " & row.Item("qty_sisa") & " where Kd_Stok='" & row.Item("Kd_Stok") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
            '        End If
            '    Next
        End If

        For Each rw As DataRow In (ds4.Tables("PRD").Select("qty_pr =0"))
            rw.Delete()
        Next
        For Each row In ds4.Tables("PRD").Rows
            If row.RowState <> DataRowState.Deleted Then
                Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= '" & row.Item("qty_sisa") & "' where Kd_Stok='" & row.Item("Kd_Stok") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
            End If
            'Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= " & IIf(row.Item("qty_sisa").ToString = "", 0, row.Item("qty_sisa")) & " where Kd_Stok='" & row.Item("No_DPM") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
        Next
        ' Try

        'da3.Update(ds3.Tables("DPM_D"))
        'ds3.Tables("DPM_D").AcceptChanges()

        da4.Update(ds4.Tables("PRD"))
        ds4.Tables("PRD").AcceptChanges()

        STATE = "EDIT"
        BTRANS.Commit()
        showMessages("Berhasil disimpan..")
        'Catch e As Exception
        '    BTRANS.Rollback()
        '    ds4.Tables("PRD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        'End Try
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub
End Class