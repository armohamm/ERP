Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSatpamSJ
    Dim dsete As New DataSet
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim isKirim As Boolean = False
    Dim isSet As Boolean = True
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

    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoSJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            isSet = True
            isKirim = False
            Dim dr As SqlDataReader = New SqlCommand("Select * from sales.dbo.v_sj_rep where no_sj='" & txtNoSJ.Text & "' and tgl_terima is null", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cmdSimpan.Focus()
                txtKendaraan.Text = dr("No_Polisi").ToString & " " & dr("Nama_Kendaraan").ToString
                txtSopir.Text = dr("Sopir").ToString
                TglKirim.EditValue = dr("Tgl_kirim").ToString
                jamkirim.EditValue = dr("Jam_kirim").ToString
                tglBalik.EditValue = dr("Tgl_balik").ToString
                jamBalik.EditValue = dr("Jam_balik").ToString
                If TglKirim.Text = "" Then
                    TglKirim.EditValue = Now
                    jamkirim.EditValue = Now
                    TglKirim.BackColor = Color.GreenYellow
                    jamkirim.BackColor = Color.GreenYellow
                    isKirim = True
                Else
                    TglKirim.BackColor = Color.Pink
                    jamkirim.BackColor = Color.Pink
                    If tglBalik.Text = "" Then
                        tglBalik.BackColor = Color.GreenYellow
                        jamBalik.BackColor = Color.GreenYellow
                        tglBalik.EditValue = Now
                        jamBalik.EditValue = Now
                        lblStatus.Text = "Barang Kembali"

                        isKirim = False
                    Else
                        tglBalik.BackColor = Color.Pink
                        jamBalik.BackColor = Color.Pink
                        lblStatus.Text = "Pengiriman Barang"
                        isSet = True
                    End If

                End If
            Else
                txtKendaraan.Text = "Tidak Diketemukan"
                lblStatus.Text = "?"
                txtSopir.Text = ""
                TglKirim.EditValue = vbNullString
                jamkirim.EditValue = vbNullString
                tglBalik.EditValue = vbNullString
                jamBalik.EditValue = vbNullString
                TglKirim.BackColor = Color.Empty
                jamkirim.BackColor = Color.Empty
                tglBalik.BackColor = Color.Empty
                jamBalik.BackColor = Color.Empty
            End If
            dr.Close()
        End If
    End Sub
    Public Sub save_click()
        Dim dr As Int16
        If isSet Then
            If isKirim Then
                dr = New SqlCommand("update sales.dbo.sales_SJ  set Tgl_kirim=getDate() , Jam_kirim=getdate() where no_sj='" & txtNoSJ.Text & "'", sqlconn).ExecuteNonQuery
            Else
                dr = New SqlCommand("update sales.dbo.sales_SJ  set Tgl_balik=getDate() , Jam_balik=getdate() where no_sj='" & txtNoSJ.Text & "'", sqlconn).ExecuteNonQuery
            End If
            showMessages("Data Telah Disimpan")
            txtNoSJ.Focus()
        End If
    End Sub

    Private Sub frmSatpamSJ_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNoSJ.Focus()
    End Sub
    Private Sub frmSatpamSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        TglKirim.EditValue = vbNullString
        jamkirim.EditValue = vbNullString
        tglBalik.EditValue = vbNullString
        jamBalik.EditValue = vbNullString
        prn = frmMain
        btnadd = False : btnCancel = False : btnDelete = False : btnEdit = False : btnSave = False
        setStatus()
        lblStatus.Text = ""
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        txtNoSJ.Focus()
    End Sub
    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        save_click()
        TglKirim.EditValue = vbNullString
        jamkirim.EditValue = vbNullString
        tglBalik.EditValue = vbNullString
        jamBalik.EditValue = vbNullString
        txtNoSJ.Text = ""
        txtKendaraan.Text = ""
        txtSopir.Text = ""
        lblStatus.Text = ""
    End Sub

    Private Sub txtNoSJ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSJ.TextChanged

    End Sub
End Class