Imports System.Data.SqlClient
Public Class frmPerbaikanDPM
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain   '<-- untuk mengakses frmMain


    Dim dsedit As New DataSet
    Dim daedit As SqlClient.SqlDataAdapter
    Private Sub btnPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromo.Click
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_DPM as [Nomor], tgl_DPM as [Tanggal], tipe_trans Jenis, no_ref , rec_stat Status,keterangan [Keterangan] from PURC.dbo.PURC_DPM where  rec_stat = 'APPROVE'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_DPM") Is Nothing Then dsedit.Tables("lookup_DPM").Clear()
        daedit.Fill(dsedit, "lookup_DPM")
        frmCari.set_dso(dsedit.Tables("lookup_DPM")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txtNoDPM.Text = frmCari.row("Nomor")
            tglDpm.Text = frmCari.row("Tanggal")
            txtJenisDpm.Text = frmCari.row("Jenis")
            If frmCari.row("no_ref") Is DBNull.Value Then
                txtNoref.Text = ""
            Else
                txtNoref.Text = frmCari.row("no_ref")
            End If
            txtStatus.Text = frmCari.row("Status")
        End If
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With

    End Sub
    Public Sub add_click()

    End Sub
    Public Sub save_click()
        With New SqlCommand("update purc.dbo.purc_dpm set rec_stat='PERBAIKAN' where no_dpm='" & txtNoDPM.Text & "'", sqlconn).ExecuteNonQuery

        End With
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub frmPerbaikanDPM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
End Class