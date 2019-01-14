Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSatpamNopol
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
    Dim BTRANS As SqlTransaction
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
        txtNopol.Focus()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKendaraan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As SqlDataReader = New SqlCommand("Select * from sales.dbo.v_sj_rep where No_Polisi='" & txtKendaraan.Text & "' and tgl_balik is null", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                isSet = True
                isKirim = False
                cmdSimpan.Focus()
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
                    lblStatus.Text = "Pengiriman Barang"
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
                isSet = False
                txtKendaraan.SelectAll()
                lblStatus.Text = "Data Tidak Ada"
                txtSopir.Text = "???"
                txtNopol.Focus()
                txtNopol.SelectAll()
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
        Dim NOPOL As String

        If isSet Then
            With New SqlCommand("SELECT KODE_KENDARAAN FROM SIF.DBO.SIF_KENDARAAN WHERE NO_POLISI ='" & txtKendaraan.Text & "' and rec_stat='Y'", sqlconn).ExecuteReader
                .Read()
                If .HasRows Then NOPOL = .Item(0)
                .Close()
            End With
            If isKirim Then
                dr = New SqlCommand("update sales.dbo.sales_SJ  set KM_BERANGKAT='" & txtKm.Text & "' , Tgl_kirim=getDate() , Jam_kirim=getdate() where no_pol='" & NOPOL & "' AND tgl_kirim is null", sqlconn).ExecuteNonQuery
            Else
                Try
                    With New SqlCommand("select no_krm from sales.dbo.sales_SJ  where no_pol='" & NOPOL & "' AND not tgl_kirim is null and tgl_balik is null", sqlconn).ExecuteReader
                        .Read()
                        If .HasRows Then
                            Dim cmd As SqlCommand = New SqlCommand
                            cmd.Connection = sqlconn
                            cmd.CommandText = "prod.[dbo].[prodp_closing_krm]"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
                            cmd.Parameters("@vno_trans").Value = .Item("no_krm").ToString
                            .Close()
                            BTRANS = sqlconn.BeginTransaction("1")
                            If Not BTRANS Is Nothing Then
                                cmd.Transaction = BTRANS
                            End If
                            cmd.ExecuteNonQuery()
                            dr = New SqlCommand("update sales.dbo.sales_SJ  set KM_KEMBALI='" & txtKm.Text & "', Tgl_balik=getDate() , Jam_balik=getdate() where no_pol='" & NOPOL & "' AND not tgl_kirim is null and tgl_balik is null", sqlconn, BTRANS).ExecuteNonQuery
                            BTRANS.Commit()
                        Else
                            dr = 0
                            .Close()
                        End If

                        lblStatus.Tag = ""

                    End With
                Catch ex As Exception
                    If Not BTRANS Is Nothing Then BTRANS.Rollback()
                    lblStatus.Text = "Error - Hubungi ADMIN"
                    lblStatus.Tag = ex.Message
                End Try
            End If
            If dr > 0 Then
                showMessages("Data Telah Disimpan")
            ElseIf dr = 0 Then
                MsgBox("Nopol Kendaraan Sudah Pernah Diproses", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
            End If
        End If
    End Sub

    Private Sub frmSatpamSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        TglKirim.EditValue = vbNullString
        jamkirim.EditValue = vbNullString
        tglBalik.EditValue = vbNullString
        jamBalik.EditValue = vbNullString
        txtKm.Text = vbNullString
        prn = frmMain

        With New SqlDataAdapter("select * from sif.dbo.sif_kendaraan where isnull(rec_stat,'')='Y' ", sqlconn)
            .Fill(dsete, "nopol")
            txtNopol.Properties.DataSource = dsete.Tables("nopol")
        End With
        btnadd = False : btnCancel = False : btnDelete = False : btnEdit = False : btnSave = False
        setStatus()
        lblStatus.Text = ""
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        txtNopol.Focus()
    End Sub
    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If TglKirim.Text = "" Then
            showMessages("Data Belum Lengkap", , "WARNING")
            txtKendaraan.Focus()
            Exit Sub
        ElseIf txtKm.Text = "" Then
            showMessages("Data Kilometer Kendaraan Wajib Diisi", , "WARNING")
            txtKm.Focus()
            Exit Sub
        End If
        save_click()
        TglKirim.EditValue = vbNullString
        jamkirim.EditValue = vbNullString
        tglBalik.EditValue = vbNullString
        jamBalik.EditValue = vbNullString
        txtKm.Text = vbNullString
        txtNopol.EditValue = vbNullString
        txtKendaraan.Text = ""
        txtSopir.Text = ""
        lblStatus.Text = ""
        txtNopol.Focus()
    End Sub

    Private Sub txtNopol_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNopol.EditValueChanged
        txtKendaraan.Text = txtNopol.Text
    End Sub

    Private Sub txtNopol_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNopol.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1_KeyDown(txtKendaraan, e)
        End If
    End Sub

    Private Sub txtKm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKm.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1_KeyDown(txtKendaraan, e)
        End If
    End Sub
End Class