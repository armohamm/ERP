'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormSelisihKurs
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsLookUp, dsData As New DataSet
    Dim daLookUp, daData As SqlDataAdapter
    Dim err As String
    Dim isOK As Boolean = True
    Dim row As DataRow
    Dim bldTrans As SqlCommandBuilder
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookUpPeriode.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookUpPeriode.Properties.DisplayMember = "nama"
        lookUpPeriode.Properties.ValueMember = "thnbln"
    End Sub

    Private Sub loadData()
        If Not dsData.Tables("kurs") Is Nothing Then dsData.Tables("kurs").Clear()
        daData = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_SELISIH_KURS", sqlconn))
        daData.Fill(dsData, "kurs")
    End Sub

    Private Sub aFormSelisihKurs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        loadData()
    End Sub

    Private Sub cek()
        If lookUpPeriode.EditValue = vbNullString Then
            isOK = False
            err &= "Periode belum dipilih." & vbCrLf
            If txtKurs.Text = "" Then
                err &= "Nilai kurs belum diisi." & vbCrLf
            End If
        ElseIf txtKurs.Text = "" Then
            isOK = False
            err &= "Nilai kurs belum diisi." & vbCrLf
            If lookUpPeriode.EditValue = vbNullString Then
                err &= "Periode belum dipilih." & vbCrLf
            End If
        Else
            isOK = True
        End If
    End Sub

    Public Sub cancel_click()
        lookUpPeriode.EditValue = vbNullString
        txtKurs.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
    End Sub

    Public Sub save_click()
        cek()
        If isOK Then
            row = dsData.Tables("kurs").NewRow
            row.Item("Kd_cabang") = getKodeCabang()
            row.Item("tipe_trans") = "JRR-KBB-03"
            row.Item("thnbln") = lookUpPeriode.EditValue
            row.Item("tgl_trans") = getTanggal()
            row.Item("kurs") = txtKurs.EditValue
            row.Item("keterangan") = txtKeterangan.EditValue
            row.Item("Last_create_date") = getTanggal()
            row.Item("Last_created_by") = umum.username
            row.Item("Program_name") = Me.Name
            dsData.Tables("kurs").Rows.Add(row)

            Try
                bldTrans = New SqlCommandBuilder(daData)
                daData.UpdateCommand = bldTrans.GetUpdateCommand()
                daData.InsertCommand = bldTrans.GetInsertCommand()
                daData.DeleteCommand = bldTrans.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daData.UpdateCommand.Transaction = BTRANS
                daData.InsertCommand.Transaction = BTRANS
                daData.DeleteCommand.Transaction = BTRANS

                daData.Update(dsData.Tables("kurs"))
                BTRANS.Commit()

                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch ex As Exception
                dsData.Tables("kurs").RejectChanges()
                MsgBox("Terdapat error pada saat menyimpan data : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
                BTRANS.Rollback()
            End Try
        Else
            MsgBox("Terdapat kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            err = ""
        End If
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        save_click()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        cancel_click()
    End Sub
End Class