Imports System.IO
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Public Class frmcetakulangdok
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, dsedit, dSO2, dseditq As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row, rows As DataRow
    Dim DA, DA1, daedit, DA2, daeditq As SqlClient.SqlDataAdapter
    Dim kode As String
    Dim Buildernya, Buildernya1 As New SqlClient.SqlCommandBuilder
    Public Sub setStatus()

        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cancel_click()
        If Not dsedit.Tables("LookSPK") Is Nothing Then dsedit.Tables("LookSPK").Clear()
        If Not dSO.Tables("RETUR") Is Nothing Then dSO.Tables("RETUR").Clear()
        If Not dSO.Tables("SJ") Is Nothing Then dSO.Tables("SJ").Clear()
        If Not dSO.Tables("SO") Is Nothing Then dSO.Tables("SO").Clear()
        If Not dseditq.Tables("EDIT") Is Nothing Then dseditq.Tables("EDIT").Clear()
        txtalasan.Text = ""
        TextBoxnama.Text = ""
        ComboBox1.Text = ""
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub add_click()
        STATE = "ADD"


        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False

        setStatus()
    End Sub

    Private Sub frmcetakulangdok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = getParent(Me)
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_CETAK_ULANG where 1=0", sqlconn))
        DA.Fill(dSO1, "DOKUMEN")
    End Sub
    Public Sub save_click()
        If STATE = "ADD" Then

            row = dSO1.Tables("DOKUMEN").NewRow
            row.Item("Kd_Cabang") = kdcabang
            row.Item("Jenis_Dokumen") = ComboBox1.Text
            row.Item("No_Dokumen") = TextBoxnama.Text
            row.Item("Tgl") = getTanggal()
            row.Item("Alasan") = txtalasan.Text
            dSO1.Tables("DOKUMEN").Rows.Add(row)

            If ComboBox1.Text = "SO" Then

                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SO where No_sp  = '" & TextBoxnama.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next
            ElseIf ComboBox1.Text = "SJ" Then

                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SJ where no_sj  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV SJ
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next
            ElseIf ComboBox1.Text = "SURAT TARIKAN" Then
                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_ST where no_sj  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV SJ
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next
            Else
                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_RETUR where No_retur  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next

            End If
            Try
                Buildernya = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = Buildernya.GetUpdateCommand()
                DA.InsertCommand = Buildernya.GetInsertCommand()
                DA.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(DA2)
                DA2.UpdateCommand = Buildernya1.GetUpdateCommand()
                DA2.InsertCommand = Buildernya1.GetInsertCommand()
                DA2.DeleteCommand = Buildernya1.GetDeleteCommand()

                DA.Update(dSO1.Tables("DOKUMEN"))
                DA2.Update(dSO2.Tables("CEK"))
                dSO1.Tables("DOKUMEN").AcceptChanges()
                dSO2.Tables("CEK").AcceptChanges()
                'STATE = "EDIT"

                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch e As Exception
                'BTRANS.Rollback()
                dSO1.Tables("DOKUMEN").RejectChanges()
                dSO2.Tables("CEK").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message)
            End Try

        ElseIf STATE = "EDIT" Then
            row = dseditq.Tables("EDIT").Rows(0)
            row.Item("Jenis_Dokumen") = ComboBox1.Text
            row.Item("No_Dokumen") = TextBoxnama.Text
            row.Item("Alasan") = txtalasan.Text

            If ComboBox1.Text = "SO" Then

                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SO where No_sp  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next



            ElseIf ComboBox1.Text = "SJ" Then

                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SJ where no_sj  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV SJ
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next



            Else

                If Not dSO2.Tables("CEK") Is Nothing Then dSO2.Tables("CEK").Clear()
                DA2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_RETUR where No_retur  = '" & TextBoxnama.Text & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                DA2.Fill(dSO2, "CEK")
                For i As Integer = dSO2.Tables("CEK").Rows.Count - 1 To 0 Step -1
                    rows = dSO2.Tables("CEK").Rows(i)
                    rows.Item("isPrinted") = vbNullString
                Next


            End If



            Try
                Buildernya = New SqlClient.SqlCommandBuilder(daeditq)
                daeditq.UpdateCommand = Buildernya.GetUpdateCommand()
                daeditq.InsertCommand = Buildernya.GetInsertCommand()
                daeditq.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(DA2)
                DA2.UpdateCommand = Buildernya1.GetUpdateCommand()
                DA2.InsertCommand = Buildernya1.GetInsertCommand()
                DA2.DeleteCommand = Buildernya1.GetDeleteCommand()


                daeditq.Update(dseditq.Tables("EDIT"))
                DA2.Update(dSO2.Tables("CEK"))


                dseditq.Tables("EDIT").AcceptChanges()
                dSO2.Tables("CEK").AcceptChanges()


                showMessages("Berhasil diedit..")


            Catch e As Exception
                'BTRANS.Rollback()
                dseditq.Tables("EDIT").RejectChanges()
                dSO2.Tables("CEK").RejectChanges()
                MsgBox(e.Message)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save_click()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        edit_click()
    End Sub
    Public Sub edit_click()

        State = "EDIT"
        ' bila menggunakan form cari

        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_CETAK_ULANG ", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "LookSPK")
        frmCari.set_dso(dsedit.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("No_Dokumen").ToString

            If Not dseditq.Tables("EDIT") Is Nothing Then dseditq.Tables("EDIT").Clear()
            daeditq = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_CETAK_ULANG where  No_Dokumen ='" & kode & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            daeditq.Fill(dseditq, "EDIT")
          

            row = dseditq.Tables("EDIT").Rows(0)
            ComboBox1.Text = row.Item("Jenis_Dokumen").ToString
            TextBoxnama.Text = row.Item("No_Dokumen").ToString
            txtalasan.Text = row.Item("Alasan").ToString
            

            btnSave = True
            btnCancel = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            setStatus()

        Else
            cancel_click()
            State = ""
        End If

    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If ComboBox1.Text = "SO" Then
            dsedit = New DataSet
            daedit = New SqlDataAdapter(New SqlCommand("select no_sp, old_num, tgl_sp, nama_customer, Last_created_by Owner from SALES.dbo.VSO_REP where isnull(isclosed,'')<>'Y' and isnull(isPrinted,'') = 'Y'", sqlconn)) '<- query buat ditampilkan di LOV
            daedit.Fill(dsedit, "LookSPK")
            frmCari.set_dso(dsedit.Tables("LookSPK"))
            frmCari.ShowDialog()

            If Not frmCari.row Is Nothing Then
                kode = frmCari.row("No_sp").ToString
                If Not dSO.Tables("SO") Is Nothing Then dSO.Tables("SO").Clear()
                DA1 = New SqlDataAdapter(New SqlCommand("select no_sp, tgl_sp, nama_customer from SALES.dbo.VSO_REP where No_sp  = '" & kode & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                DA1.Fill(dSO, "SO")
                row = dSO.Tables("SO").Rows(0)
                TextBoxnama.Text = row.Item("No_sp").ToString
            Else
                cancel_click()
                STATE = ""

            End If

        ElseIf ComboBox1.Text = "SJ" Then
            dsedit = New DataSet
            daedit = New SqlDataAdapter(New SqlCommand("select no_sj, no_sp, no_polisi, nama_kendaraan, sopir, Last_created_by Owner  from SALES.dbo.V_SJ_REP where  isnull(isPrinted,'') = 'Y' ", sqlconn)) '<- query buat ditampilkan di LOV
            daedit.Fill(dsedit, "LookSPK")
            frmCari.set_dso(dsedit.Tables("LookSPK"))
            frmCari.ShowDialog()

            If Not frmCari.row Is Nothing Then
                kode = frmCari.row("no_sj").ToString
                If Not dSO.Tables("SJ") Is Nothing Then dSO.Tables("SJ").Clear()
                DA1 = New SqlDataAdapter(New SqlCommand("select no_sj, no_polisi, nama_kendaraan, sopir from SALES.dbo.V_SJ_REP where no_sj  = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV SJ
                DA1.Fill(dSO, "SJ")
                row = dSO.Tables("SJ").Rows(0)
                TextBoxnama.Text = row.Item("no_sj").ToString
            Else
                cancel_click()
                STATE = ""

            End If
        ElseIf ComboBox1.Text = "SURAT TARIKAN" Then
            dsedit = New DataSet
            daedit = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.sales_st where  isnull(isPrinted,'') = 'Y' ", sqlconn)) '<- query buat ditampilkan di LOV
            daedit.Fill(dsedit, "LookSPK")
            frmCari.set_dso(dsedit.Tables("LookSPK"))
            frmCari.ShowDialog()

            If Not frmCari.row Is Nothing Then
                kode = frmCari.row("no_sj").ToString
                TextBoxnama.Text = kode
            Else
                cancel_click()
                STATE = ""

            End If
        Else
            dsedit = New DataSet
            daedit = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.VRETUR_REP", sqlconn)) '<- query buat ditampilkan di LOV REP
            daedit.Fill(dsedit, "LookSPK")
            frmCari.set_dso(dsedit.Tables("LookSPK"))
            frmCari.ShowDialog()

            If Not frmCari.row Is Nothing Then
                kode = frmCari.row("No_retur").ToString
                If Not dSO.Tables("RETUR") Is Nothing Then dSO.Tables("RETUR").Clear()
                DA1 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.VRETUR_REP where No_retur  = '" & kode & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                DA1.Fill(dSO, "RETUR")
                row = dSO.Tables("RETUR").Rows(0)
                TextBoxnama.Text = row.Item("No_retur").ToString
            Else
                cancel_click()
                STATE = ""

            End If
        End If
    End Sub
End Class