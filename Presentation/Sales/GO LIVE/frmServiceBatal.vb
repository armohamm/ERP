Imports System.IO
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Public Class frmServiceBatal
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim ds As DataSet
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim kode As String
    Dim Buildernya, Buildernya1 As New SqlClient.SqlCommandBuilder
    Public Sub save_click()
        If STATE = "ADD" Then
            Try
                With New SqlCommand("Update sales.dbo.sales_so set Alasan='" & txtalasan.Text & "',isClosed='Y', status='CANCEL' where no_sp='" & txtNoSP.Text & "'", sqlconn).ExecuteNonQuery

                End With
                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch e As Exception
                MsgBox(e.Message)
            End Try
        End If
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
    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        With New SqlDataAdapter("select no_sp, tgl_sp, nama_customer from SALES.dbo.VSO_REP where isConfirmed is null and isnull(isclosed,'')<>'Y' and tipe_trans='" & ServiceSponUmum & "'", sqlconn) '<- query buat ditampilkan di LOV
            .Fill(ds, "LookSPK")
        End With
        frmCari.set_dso(ds.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            txtNoSP.Text = frmCari.row("no_sp").ToString
            txtNamaCust.Text = frmCari.row("txtNamaCust").ToString
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub
    Public Sub cancel_click()
        txtalasan.Text = ""
        txtNoSP.Text = ""
        txtNamaCust.Text = ""
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
End Class