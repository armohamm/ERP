Imports DataAcess
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmKursValuta
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dSO, dso2 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2 As SqlClient.SqlDataAdapter
    Dim myDAO As New DataAcess.AreaDAO
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
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
        'setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Private Function AutoNum() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlClient.SqlDataReader = New SqlClient.SqlCommand("select MAX(substring(Nomor,1,5)+1) from DBO.SIF_Valuta_Kurs", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Private Sub Load_Data()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF_Valuta_Kurs", sqlconn))
        da2.Fill(dSO, "valuta_kurs")
        gc.DataSource = dSO.Tables("valuta_kurs")
    End Sub
    Sub View_Data()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_Valuta", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "View_Valuta_Kurs")
        LookUpEditValuta.DataSource = dSO.Tables("View_Valuta_Kurs")
    End Sub
    Public Sub save_click()
        Dim Inc As Integer = AutoNum()
        For Each rows As DataRow In dSO.Tables("valuta_kurs").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("Kd_Cabang") = getKodeCabang()
                rows.Item("Last_Created_By") = username
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
                rows.Item("Nomor") = Inc
                Inc = Inc + 1
            Else
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("Program_Name") = Me.Name
            End If

        Next

        da2.Update(dSO.Tables("valuta_kurs"))
        dSO.Tables("valuta_kurs").AcceptChanges()

        showMessages("Berhasil disimpan.")

    End Sub
    Public Sub cancel_click()
        default_cancel(prn)

        setStatus()
        Me.Enabled = False
        STATE = ""
    End Sub
    Private Sub frmKursValuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = Me.Parent
        While Not TypeOf obj Is Form
            obj = obj.Parent
        End While
        prn = obj
       
        Me.Enabled = True
        connect()
        Load_Data()
        View_Data()
        'LookUpEditValuta.ValueMember = "Kode_Valuta"
        'LookUpEditValuta.DisplayMember = "Nama_Valuta"
        Buildernya = New SqlClient.SqlCommandBuilder(da2)
        da2.UpdateCommand = Buildernya.GetUpdateCommand()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub
    Private Sub gv_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        'Dim view As ColumnView = CType(sender, ColumnView)
        'Dim gcStarDate As GridColumn = view.Columns("Start_Date")
        'Dim gcEndDate As GridColumn = view.Columns("End_Date")



        'Dim time1 As Date = CType(view.GetRowCellValue(e.RowHandle, gcStarDate), Date)
        'Dim time2 As Date = CType(view.GetRowCellValue(e.RowHandle, gcEndDate), Date)
        'If time1 >= time2 Then
        '    e.Valid = False
        '    view.SetColumnError(gcStarDate, "Tanggal harus lebih kecil dari End Date !")
        '    view.SetColumnError(gcEndDate, "Tanggal harus lebih besar dari Start Date !")
        'End If
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        ' e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Public Sub delete_click()
        If MessageBox.Show("Apakah ingin menghapus Record ini?", _
          "Delete", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Batal Dihapus")
            Exit Sub
        End If
        Buildernya = New SqlClient.SqlCommandBuilder(da2)
        gv.DeleteSelectedRows()
        MsgBox("Berhasil diHapus")
        da2.Update(dSO, "Valuta_Kurs")
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub
End Class