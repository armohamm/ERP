'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormSelisihKursParam
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
    Dim isEdit As Boolean = False
    Dim row As DataRow
    Dim bldTrans As SqlClient.SqlCommandBuilder
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

        If Not dsLookUp.Tables("LookValuta") Is Nothing Then dsLookUp.Tables("LookValuta").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta,Nama_Valuta as nama from sif.dbo.SIF_valuta", sqlconn))
        daLookUp.Fill(dsLookUp, "LookValuta")
        LU_Valuta.Properties.DataSource = dsLookUp.Tables("LookValuta")
        LU_Valuta.Properties.DisplayMember = "nama"
        LU_Valuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadData()
        If Not dsData.Tables("kurs") Is Nothing Then dsData.Tables("kurs").Clear()
        daData = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_SELISIH_KURS_PARAM", sqlconn))
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
            If LU_Valuta.EditValue = vbNullString Then
                err &= "Rekenning valas belum dipilih." & vbCrLf
            End If
        ElseIf LU_Valuta.EditValue = vbNullString Then
            isOK = False
            err &= "Rekenning valas belum dipilih." & vbCrLf
            If txtKurs.Text = "" Then
                err &= "Nilai kurs belum diisi." & vbCrLf
            End If
            If lookUpPeriode.EditValue = vbNullString Then
                err &= "Periode belum dipilih." & vbCrLf
            End If
        ElseIf txtKurs.Text = "" Then
            isOK = False
            err &= "Nilai kurs belum diisi." & vbCrLf
            If lookUpPeriode.EditValue = vbNullString Then
                err &= "Periode belum dipilih." & vbCrLf
            End If

            If LU_Valuta.EditValue = vbNullString Then
                err &= "Rekenning valas belum dipilih." & vbCrLf
            End If
        Else
            isOK = True
        End If


        Dim drPost As SqlDataReader = New SqlCommand("SELECT * FROM FIN.dbo.FIN_SELISIH_KURS_PARAM  WHERE thnbln = '" & lookUpPeriode.EditValue & "' and rek_valas = '" & LU_Valuta.EditValue & "' ", sqlconn).ExecuteReader
        drPost.Read()
        If drPost.HasRows Then
            isEdit = True
        End If
        drPost.Close()
    End Sub

    Public Sub cancel_click()
        LU_Valuta.EditValue = vbNullString
        lookUpPeriode.EditValue = vbNullString
        txtKurs.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
        isEdit = False
    End Sub

    Public Sub save_click()
        cek()
        If isOK Then
            If isEdit = False Then
                row = dsData.Tables("kurs").NewRow
                row.Item("Kd_cabang") = getKodeCabang()
                '   row.Item("tipe_trans") = "JRR-KBB-03"
                row.Item("thnbln") = lookUpPeriode.EditValue
                row.Item("tgl_trans") = getTanggal()
                row.Item("rek_valas") = LU_Valuta.EditValue
                row.Item("kurs") = txtKurs.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("Last_create_date") = getTanggal()
                row.Item("Last_created_by") = umum.username
                row.Item("Program_name") = Me.Name
                dsData.Tables("kurs").Rows.Add(row)



                Try
                    bldTrans = New SqlClient.SqlCommandBuilder(daData)
                    daData.UpdateCommand = bldTrans.GetUpdateCommand()
                    '  dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
                    daData.Update(dsData.Tables("kurs"))
                    dsData.Tables("kurs").AcceptChanges()

                    'bldTrans = New SqlClient.SqlCommandBuilder(daData)
                    'daData.UpdateCommand = bldTrans.GetUpdateCommand()
                    'daData.InsertCommand = bldTrans.GetInsertCommand()
                    'daData.DeleteCommand = bldTrans.GetDeleteCommand()

                    'BTRANS = sqlconn.BeginTransaction("1")
                    'daData.UpdateCommand.Transaction = BTRANS
                    'daData.InsertCommand.Transaction = BTRANS
                    'daData.DeleteCommand.Transaction = BTRANS

                    'daData.Update(dsData.Tables("kurs"))
                    'BTRANS.Commit()
                    call_procedure(lookUpPeriode.EditValue, LU_Valuta.EditValue)
                    showMessages("Berhasil disimpan..")
                    cancel_click()
                Catch ex As Exception
                    dsData.Tables("kurs").RejectChanges()
                    MsgBox("Terdapat error pada saat menyimpan data : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
                    'BTRANS.Rollback()
                End Try
            ElseIf isEdit = True Then

                If Not dsData.Tables("kurs") Is Nothing Then dsData.Tables("kurs").Clear()
                daData = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_SELISIH_KURS_PARAM  WHERE thnbln = '" & lookUpPeriode.EditValue & "' and rek_valas = '" & LU_Valuta.EditValue & "' ", sqlconn))
                daData.Fill(dsData, "kurs")

                row = dsData.Tables("kurs").Rows(0)
                row.Item("Kd_cabang") = getKodeCabang()
                '   row.Item("tipe_trans") = "JRR-KBB-03"
                row.Item("thnbln") = lookUpPeriode.EditValue
                row.Item("tgl_trans") = getTanggal()
                row.Item("rek_valas") = LU_Valuta.EditValue
                row.Item("kurs") = txtKurs.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("Last_update_date") = getTanggal()
                row.Item("Last_updated_by") = umum.username
                row.Item("Program_name") = Me.Name
                'dsData.Tables("kurs").Rows.Add(row)



                Try
                    bldTrans = New SqlClient.SqlCommandBuilder(daData)
                    daData.UpdateCommand = bldTrans.GetUpdateCommand()
                    '  dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
                    daData.Update(dsData.Tables("kurs"))
                    dsData.Tables("kurs").AcceptChanges()

                    'bldTrans = New SqlClient.SqlCommandBuilder(daData)
                    'daData.UpdateCommand = bldTrans.GetUpdateCommand()
                    'daData.InsertCommand = bldTrans.GetInsertCommand()
                    'daData.DeleteCommand = bldTrans.GetDeleteCommand()

                    'BTRANS = sqlconn.BeginTransaction("1")
                    'daData.UpdateCommand.Transaction = BTRANS
                    'daData.InsertCommand.Transaction = BTRANS
                    'daData.DeleteCommand.Transaction = BTRANS

                    'daData.Update(dsData.Tables("kurs"))
                    'BTRANS.Commit()
                    call_procedure(lookUpPeriode.EditValue, LU_Valuta.EditValue)
                    showMessages("Berhasil disimpan..")
                    cancel_click()
                Catch ex As Exception
                    dsData.Tables("kurs").RejectChanges()
                    MsgBox("Terdapat error pada saat menyimpan data : " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
                    'BTRANS.Rollback()
                End Try
            End If
          
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

    Public Sub call_procedure(ByVal bultah As String, ByVal kd_valuta As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.fin_create_jurnal_kurs_bln"

        sqlCmd.Parameters.Add("@pThnBln", SqlDbType.Char).Value = bultah
        sqlCmd.Parameters.Add("@pKd_Valuta", SqlDbType.Char).Value = kd_valuta
        sqlCmd.ExecuteNonQuery()
    End Sub

End Class