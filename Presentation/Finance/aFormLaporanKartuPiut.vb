'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormLaporanKartuPiut
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsLookUp As New DataSet
    Dim daLookPeriode, daLookValuta, daLookKartu As SqlDataAdapter
    Dim err As String
    Dim isOK As Boolean = True

    Public Sub cetak_click()

    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookPeriode = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookPeriode.Fill(dsLookUp, "LookPeriode")
        lookupPeriode.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupPeriode.Properties.DisplayMember = "nama"
        lookupPeriode.Properties.ValueMember = "thnbln"

        If Not dsLookUp.Tables("LookValuta") Is Nothing Then dsLookUp.Tables("LookValuta").Clear()
        daLookValuta = New SqlDataAdapter(New SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM SIF.dbo.SIF_Valuta", sqlconn))
        daLookValuta.Fill(dsLookUp, "LookValuta")
        lookupValuta.Properties.DataSource = dsLookUp.Tables("LookValuta")
        lookupValuta.Properties.DisplayMember = "Nama_Valuta"
        lookupValuta.Properties.ValueMember = "Kode_Valuta"

        If Not dsLookUp.Tables("LookKartu") Is Nothing Then dsLookUp.Tables("LookKartu").Clear()
        daLookKartu = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT a.kd_cust, b.nama FROM FIN.dbo.FIN_NOTA a, FIN.dbo.v_kartu b WHERE a.kd_cust=b.kode AND a.kd_valuta='" & lookupValuta.EditValue & "' AND a.tipe_trans LIKE 'JPJ%' UNION SELECT '00000', '[Semua Data]'", sqlconn))
        daLookKartu.Fill(dsLookUp, "LookKartu")
        lookupKartu.Properties.DataSource = dsLookUp.Tables("LookKartu")
        lookupKartu.Properties.DisplayMember = "nama"
        lookupKartu.Properties.ValueMember = "kd_cust"
    End Sub

    Private Sub aFormLaporanKartuPiut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        lookupValuta.EditValue = "IDR"
        loadLookUp()
        lookupKartu.EditValue = "00000"
    End Sub

    Private Sub lookupValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupValuta.EditValueChanged
        loadLookUp()
        If dsLookUp.Tables("LookKartu").Rows.Count <= 0 Then
            lookupKartu.EditValue = "00000"
        End If
    End Sub

    Private Sub radKartuPiut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKartuPiut.CheckedChanged
        If radKartuPiut.Checked = True Then
            radAgging.Checked = False
            cmbAggingPiut.Enabled = False
            If cmbKartuPiut.EditValue = "Rekap" Then
                lookupKartu.Enabled = False
            Else
                lookupKartu.Enabled = True
            End If
        Else
            cmbAggingPiut.Enabled = True
        End If
    End Sub

    Private Sub radAgging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAgging.CheckedChanged
        If radAgging.Checked = True Then
            radKartuPiut.Checked = False
            cmbKartuPiut.Enabled = False
            pnlOpt.Visible = True
            If cmbAggingPiut.EditValue = "Rekap" Then
                lookupKartu.Enabled = False
            Else
                lookupKartu.Enabled = True
            End If
        Else
            cmbKartuPiut.Enabled = True
            pnlOpt.Visible = False
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        cek()
        If isOK = True Then
            If chkMigrasi.EditValue Then
                If cmbKartuPiut.EditValue = "Rekap" Then
                    callReport(App_Path() & "\report\repKartuRekapDataMigrasi.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue, False)
                End If
            Else
                If radKartuPiut.Checked = True Then
                    If cmbKartuPiut.EditValue = "Rekap" Then
                        callReport(App_Path() & "\report\repKartuRekapCommAlt.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue, False)
                    ElseIf cmbKartuPiut.EditValue = "Rinci" Then
                        If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                            callReport(App_Path() & "\report\repKartuRinciAllComm.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue, False)
                        Else
                            callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue & "&kartu=" & lookupKartu.EditValue & "&inv=", False)
                        End If
                    End If
                Else
                    If cmbAggingPiut.EditValue = "Rekap" Then
                        If radNota.Checked = True Then
                            callReport(App_Path() & "\report\repAggingRekapPiut.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, False)
                        Else
                            callReport(App_Path() & "\report\repAggingRekapPiutJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, False)
                        End If
                    ElseIf cmbAggingPiut.EditValue = "Rinci" Then
                        If radNota.Checked = True Then
                            If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                                callReport(App_Path() & "\report\repAggingRinciPiutAll.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, False)
                            Else
                                callReport(App_Path() & "\report\repAggingRinciPiut.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue & "&cust=" & lookupKartu.EditValue, False)
                            End If
                        Else
                            If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                                callReport(App_Path() & "\report\repAggingRinciPiutAllJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, False)
                            Else
                                callReport(App_Path() & "\report\repAggingRinciPiutJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue & "&cust=" & lookupKartu.EditValue, False)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Kesalahan dalam mengisi filter laporan :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Private Sub cek()
        If lookupPeriode.EditValue = vbNullString Then
            err &= "Periode masih belum dipilih." & vbCrLf
            isOK = False
            If lookupValuta.EditValue = vbNullString Then
                err &= "Valuta masih belum dipilih." & vbCrLf
            End If
            If dsLookUp.Tables("LookKartu").Rows.Count > 0 Then
                If lookupKartu.EditValue = vbNullString Then
                    If cmbKartuPiut.EditValue = "Rinci" Or cmbAggingPiut.EditValue = "Rinci" Then
                        err &= "Kartu masih belum dipilih." & vbCrLf
                    End If
                End If
            End If
        ElseIf lookupValuta.EditValue = vbNullString Then
            err &= "Valuta masih belum dipilih." & vbCrLf
            isOK = False
            If lookupPeriode.EditValue = vbNullString Then
                err &= "Periode masih belum dipilih." & vbCrLf
            End If
            If dsLookUp.Tables("LookKartu").Rows.Count > 0 Then
                If lookupKartu.EditValue = vbNullString Then
                    If cmbKartuPiut.EditValue = "Rinci" Or cmbAggingPiut.EditValue = "Rinci" Then
                        err &= "Kartu masih belum dipilih." & vbCrLf
                    End If
                End If
            End If
        ElseIf dsLookUp.Tables("LookKartu").Rows.Count > 0 Then
            If cmbKartuPiut.EditValue = "Rinci" Or cmbAggingPiut.EditValue = "Rinci" Then
                If lookupKartu.EditValue = vbNullString Then
                    err &= "Kartu masih belum dipilih." & vbCrLf
                    isOK = False
                    If lookupValuta.EditValue = vbNullString Then
                        err &= "Valuta masih belum dipilih." & vbCrLf
                    End If
                    If lookupPeriode.EditValue = vbNullString Then
                        err &= "Periode masih belum dipilih." & vbCrLf
                    End If
                ElseIf lookupKartu.EditValue = "00000" Then
                    isOK = True
                Else
                    isOK = True
                End If
            Else
                isOK = True
            End If
        Else
            isOK = True
        End If
    End Sub

    Private Sub cmbKartuPiut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKartuPiut.EditValueChanged
        If cmbKartuPiut.EditValue = "Rekap" Then
            lookupKartu.Enabled = False
        Else
            lookupKartu.Enabled = True
        End If
    End Sub

    Private Sub cmbAggingPiut_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAggingPiut.EditValueChanged
        If cmbAggingPiut.EditValue = "Rekap" Then
            lookupKartu.Enabled = False
        Else
            lookupKartu.Enabled = True
        End If
    End Sub

    Private Sub lookupKartu_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookupKartu.QueryPopUp
        If Not dsLookUp.Tables("LookKartu") Is Nothing Then dsLookUp.Tables("LookKartu").Clear()
        daLookKartu = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT a.kd_cust, b.nama FROM FIN.dbo.FIN_NOTA a, FIN.dbo.v_kartu b WHERE a.kd_cust=b.kode AND a.kd_valuta='" & lookupValuta.EditValue & "' AND a.tipe_trans LIKE 'JPJ%' UNION SELECT '00000', '[Semua Data]'", sqlconn))
        daLookKartu.Fill(dsLookUp, "LookKartu")
        lookupKartu.Properties.DataSource = dsLookUp.Tables("LookKartu")
        lookupKartu.Properties.DisplayMember = "nama"
        lookupKartu.Properties.ValueMember = "kd_cust"
        lookupKartu.EditValue = "00000"
    End Sub

    Private Sub radNota_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radNota.CheckedChanged
        If radNota.Checked = True Then
            radJthTempo.Checked = False
        End If
    End Sub

    Private Sub radJthTempo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radJthTempo.CheckedChanged
        If radJthTempo.Checked = True Then
            radNota.Checked = False
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cek()
        If isOK = True Then
            'MsgBox(Len(lookupPeriode.EditValue))
            If radKartuPiut.Checked = True Then
                If cmbKartuPiut.EditValue = "Rekap" Then
                    callReport(App_Path() & "\report\repKartuRekapCommAlt.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue, True)
                ElseIf cmbKartuPiut.EditValue = "Rinci" Then
                    If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                        callReport(App_Path() & "\report\repKartuRinciAllComm.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue, True)
                    Else
                        callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & lookupPeriode.EditValue & "&val=" & lookupValuta.EditValue & "&kartu=" & lookupKartu.EditValue, True)
                    End If
                End If
            Else
                If cmbAggingPiut.EditValue = "Rekap" Then
                    If radNota.Checked = True Then
                        callReport(App_Path() & "\report\repAggingRekapPiut.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, True)
                    Else
                        callReport(App_Path() & "\report\repAggingRekapPiutJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, True)
                    End If
                ElseIf cmbAggingPiut.EditValue = "Rinci" Then
                    If radNota.Checked = True Then
                        If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                            callReport(App_Path() & "\report\repAggingRinciPiutAll.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, True)
                        Else
                            callReport(App_Path() & "\report\repAggingRinciPiut.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue & "&cust=" & lookupKartu.EditValue, False)
                        End If
                    Else
                        If lookupKartu.EditValue = vbNullString Or lookupKartu.EditValue = "00000" Then
                            callReport(App_Path() & "\report\repAggingRinciPiutAllJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue, False)
                        Else
                            callReport(App_Path() & "\report\repAggingRinciPiutJthTempo.rpt", "", "periode=" & lookupPeriode.EditValue & "&valuta=" & lookupValuta.EditValue & "&cust=" & lookupKartu.EditValue, False)
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Kesalahan dalam mengisi filter laporan :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub
End Class