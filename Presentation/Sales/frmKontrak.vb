Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmKontrak
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim DAO As SqlDataAdapter
    Dim prn As frmMain
    Public STATE As String
    Dim rw As DataRow
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
        End With
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer from SIF.dbo.SIF_Customer where rec_stat='Y'", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        DA = New SqlDataAdapter(New SqlCommand("select KD_HADIAH, HADIAH from SIF.dbo.[SIF_BARANG_HADIAH]", sqlconn))
        DA.Fill(dsete, "hadiah")
        cmdHadiah.Properties.DataSource = dsete.Tables("hadiah")
        reloadTable("xx")
        tgl.Text = getTanggal()
        With dsete.Tables.Add("program")
            .Columns.Add("Kode")
            .Columns.Add("Nama")
        End With
        rw = dsete.Tables("program").NewRow
        rw(0) = umum.KD_DIV_SPRING
        rw(1) = "Div. Spring"
        dsete.Tables("program").Rows.Add(rw)
        rw = dsete.Tables("program").NewRow
        rw(0) = KD_DIV_SPON
        rw(1) = "Div. Spon"
        dsete.Tables("program").Rows.Add(rw)
        rw = dsete.Tables("program").NewRow
        rw(0) = KD_DIV_SILLY
        rw(1) = "Div. Sealy"
        dsete.Tables("program").Rows.Add(rw)
        txtProgram.Properties.DataSource = dsete.Tables("program")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [Kode_Valuta] ,[Nama_Valuta] FROM [SIF].[dbo].[SIF_Valuta] where [Rec_Stat]='Y'", sqlconn))
        DA.Fill(dsete, "VALAS")
        vValas.Properties.DataSource = dsete.Tables("VALAS")
        vValas.EditValue = "IDR"
        prn = frmMain
        setStatus()
    End Sub
    Sub reloadTable(ByVal nomor As String)
        If Not dsete.Tables("omzet") Is Nothing Then dsete.Tables("omzet").Clear()
        DAO = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_KONTRAK where No_kontrak='" & nomor & "'", sqlconn))
        DAO.Fill(dsete, "omzet")
        If dsete.Tables("omzet").Rows.Count > 0 Then
            txtCustomer.EditValue = dsete.Tables("omzet")(0)("kd_customer")
            txtNomor.Text = dsete.Tables("omzet")(0)("No_kontrak")
            tgl.Text = dsete.Tables("omzet")(0)("Last_Create_Date")
            tglMulai.EditValue = dsete.Tables("omzet")(0)("tgl_mulai")
            tglSampai.EditValue = dsete.Tables("omzet")(0)("tgl_selesai")
            txtJnsOmzet.EditValue = dsete.Tables("omzet")(0)("jns_kontrak")
            txtOmzet.EditValue = dsete.Tables("omzet")(0)("Omzet_Spring")
            txtTotOmzet.EditValue = dsete.Tables("omzet")(0)("OMZET")
            txtProgram.EditValue = dsete.Tables("omzet")(0)("PROGRAM")
            txtSelama.Text = DateDiff(DateInterval.Month, tglMulai.EditValue, tglSampai.EditValue) + 1
            txtNamaProgram.Text = dsete.Tables("omzet")(0)("nama_kontrak")
            txtHadiah.Text = dsete.Tables("omzet")(0)("HADIAH")
            vValas.EditValue = dsete.Tables("omzet")(0)("Valas")
            txtNilai.EditValue = dsete.Tables("omzet")(0)("Nilai")
            txtStatus.EditValue = dsete.Tables("omzet")(0)("Status")

            If dsete.Tables("omzet")(0)("isClosed").ToString <> "" Then
                prn.btnDelete.Enabled = True
                lblState.Text = "Closed"
                lblState.ForeColor = Color.Red
            Else
                prn.btnDelete.Enabled = False
                lblState.Text = "Open"
                lblState.ForeColor = Color.Green

            End If
        Else
            txtNamaProgram.Text = ""
            txtCustomer.EditValue = vbNullString
            txtNomor.Text = ""
            tgl.Text = ""
            tglMulai.EditValue = vbNullString
            tglSampai.EditValue = vbNullString
            txtOmzet.Text = ""
            txtJnsOmzet.SelectedIndex = -1
            txtTotOmzet.EditValue = vbNullString
            txtStatus.EditValue = "Y"
            txtSelama.Text = ""
            lblState.Text = "Open"
            lblState.ForeColor = Color.Green
            txtHadiah.Text = ""
            txtNilai.EditValue = 0
            vValas.EditValue = "IDR"
        End If
    End Sub
    Public Sub add_click()
        STATE = "ADD"
        default_add(prn)
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        If Not isDelete Then
            If txtCustomer.Text = "" Then
                showMessages("Customer Harap Diisi", , "WARNING")
                Exit Sub
            End If
            If txtNomor.Text = "" Then
                showMessages("Nomor Harap Diisi", , "WARNING")
                Exit Sub
            End If
            If txtProgram.Text = "" Then
                showMessages("Program Harap Diisi", , "WARNING")
                Exit Sub
            End If
            If tglMulai.Text = "" Then
                showMessages("Tanggal Mulai Harap Diisi", , "WARNING")
                Exit Sub
            End If
            If tglSampai.Text = "" Then
                showMessages("Tanggal Sampai Harap Diisi", , "WARNING")
                Exit Sub
            End If
            If txtSelama.EditValue <= 0 Then
                showMessages("Nilai Tanggal Sampai Salah", , "WARNING")
                Exit Sub
            End If
            If txtJnsOmzet.SelectedIndex = 0 Then
                If txtOmzet.Text = "" Then
                    showMessages("Omzet Harap Diisi", , "WARNING")
                    Exit Sub
                End If
                If txtOmzet.EditValue <= 0 Then
                    showMessages("Nilai Omzet Salah", , "WARNING")
                    Exit Sub
                End If
            Else
                If txtTotOmzet.Text = "" Then
                    showMessages("Omzet Harap Diisi", , "WARNING")
                    Exit Sub
                End If
                If txtTotOmzet.EditValue <= 0 Then
                    showMessages("Nilai Omzet Salah", , "WARNING")
                    Exit Sub
                End If
                
            End If
            'If cmdHadiah.Text = "" Then
            '    showMessages("Hadiah Harap Diisi", , "WARNING")
            '    Exit Sub
            'End If
            If STATE = "ADD" Then
                rw = dsete.Tables("omzet").NewRow
            Else
                rw = dsete.Tables("omzet")(0)
            End If
            rw("Kd_Cabang") = kdcabang
            rw("No_kontrak") = txtNomor.Text
            rw("nama_kontrak") = txtNamaProgram.Text
            rw("Tipe_trans") = ""
            rw("kd_customer") = txtCustomer.EditValue
            rw("Kd_barang_bonus") = cmdHadiah.EditValue
            rw("jns_kontrak") = txtJnsOmzet.EditValue
            rw("HADIAH") = txtHadiah.Text
            rw("Valas") = vValas.EditValue
            rw("Nilai") = txtNilai.EditValue
            rw("Omzet_Spring") = txtOmzet.EditValue
            rw("OMZET") = txtTotOmzet.EditValue

            rw("tgl_mulai") = tglMulai.EditValue
            rw("tgl_selesai") = tglSampai.EditValue
            rw("potongan") = 0
            rw("PROGRAM") = txtProgram.EditValue
            rw("Top") = 0
            rw("Status") = txtStatus.Text
            rw("Last_Create_Date") = getTanggal()
            rw("Last_Created_By") = kdpeg

            rw("Program_Name") = Me.Name
            If STATE = "ADD" Then
                dsete.Tables("omzet").Rows.Add(rw)
            Else
                rw("Last_Update_Date") = getTanggal()
                rw("Last_Updated_By") = kdpeg
            End If
        End If
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DAO)
            DAO.UpdateCommand = myBuilder.GetUpdateCommand()
            DAO.InsertCommand = myBuilder.GetInsertCommand()
            DAO.DeleteCommand = myBuilder.GetDeleteCommand()
            DAO.Update(dsete.Tables("omzet"))

            STATE = "EDIT"
            txtNomor.Properties.ReadOnly = True
            showMessages("Transaksi Telah Diproses")

        Catch e As Exception
            If STATE = "ADD" Then txtNomor.Properties.ReadOnly = False
            dsete.Tables("omzet").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Kontrak Pelanggan ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus Data") = MsgBoxResult.Ok Then
            dsete.Tables("omzet").Rows(0).Delete()
            save_click(True)
            cancel_click()
        End If
    End Sub
    Public Sub cancel_click()
        STATE = "EDIT"
        reloadTable(" b  ")
        default_cancel(prn)
    End Sub
    Public Sub edit_click()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_kontrak, nama_customer from sales.dbo.V_REP_KONTRAK", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        DA.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            
            btnadd = False
            btnEdit = False

            reloadTable(frmCari.row(0))

            STATE = "EDIT"
            btnCancel = True
            btnSave = True
            Me.Enabled = True
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub tglMulai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglMulai.EditValueChanged
        On Error Resume Next
        txtSelama.Text = DateDiff(DateInterval.Month, tglMulai.EditValue, tglSampai.EditValue) + 1
    End Sub

    Private Sub tglSampai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglSampai.EditValueChanged
        On Error Resume Next
        txtSelama.Text = DateDiff(DateInterval.Month, tglMulai.EditValue, tglSampai.EditValue) + 1
    End Sub

    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        If txtCustomer.Text <> "" Then
            txtKdCustomer.Text = txtCustomer.EditValue.ToString
        Else
            txtKdCustomer.Text = ""
        End If
    End Sub

    Private Sub txtJnsOmzet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJnsOmzet.SelectedIndexChanged
        If txtJnsOmzet.SelectedIndex = 0 Then
            If Val(txtOmzet.EditValue) > 0 Then
                txtTotOmzet.EditValue = txtOmzet.EditValue * txtSelama.EditValue
            End If
            txtTotOmzet.Properties.ReadOnly = True
            txtOmzet.Properties.ReadOnly = False

        Else
            If Val(txtTotOmzet.EditValue) > 0 Then
                txtOmzet.EditValue = txtTotOmzet.EditValue / txtSelama.EditValue
            End If
            txtOmzet.Properties.ReadOnly = True
            txtTotOmzet.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txtOmzet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOmzet.EditValueChanged
        If txtJnsOmzet.SelectedIndex = 0 And Val(txtOmzet.EditValue) > 0 Then
            txtTotOmzet.EditValue = txtOmzet.EditValue * txtSelama.EditValue
        End If
    End Sub

    Private Sub txtTotOmzet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotOmzet.EditValueChanged
        If txtJnsOmzet.SelectedIndex = 1 And Val(txtTotOmzet.EditValue) > 0 Then
            txtOmzet.EditValue = txtTotOmzet.EditValue / txtSelama.EditValue
        End If

    End Sub
End Class