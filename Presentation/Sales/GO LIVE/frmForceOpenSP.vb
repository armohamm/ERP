Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmForceOpenSP
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
        End With
    End Sub
    Public Sub edit_click()

    End Sub
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        State = ""
        setStatus()
        Me.Enabled = False
        txtNomor.EditValue = vbNullString
        txtNamaCustomer.EditValue = vbNullString
        txtTgl.EditValue = vbNullString
        txtAlasan.EditValue = vbNullString
        txtPelapor.EditValue = vbNullString
        txtSP.EditValue = vbNullString
        txtDisetujui.EditValue = vbNullString
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Private Sub frmPembatalanSP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        loadTable("xxx")
        Dim rw As DataRow
        With dsete.Tables.Add("JenisPembatalan")
            With .Columns
                .Add("Kode")
                .Add("Deskripsi")
            End With
            rw = .NewRow
            rw(0) = "CANCELED"
            rw(1) = "Dibatalkan Oleh Customer"
            .Rows.Add(rw)

            rw = .NewRow
            rw(0) = "REJECTED"
            rw(1) = "Ditolak Oleh Perusahaan"
            .Rows.Add(rw)

        End With
        prn = frmMain
    End Sub
    Private Sub loadTable(ByVal kode As String)
        If Not dsete.Tables("batal") Is Nothing Then dsete.Tables("batal").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SP_BATAL where No_Batal='" & kode & "'", sqlconn))
        DA.Fill(dsete, "batal")
        If dsete.Tables("batal").Rows.Count > 0 Then
            With dsete.Tables("batal").Rows(0)
                txtNomor.Text = .Item("No_Batal")
                txtTgl.Text = .Item("Tgl_Batal")
                txtSP.Text = .Item("No_sp")
                txtAlasan.Text = .Item("Alasan")
                txtDisetujui.Text = .Item("Disetujui")
                txtPelapor.Text = .Item("Oleh")
            End With
        Else
            txtNomor.Text = ""
            txtTgl.Text = ""
            txtSP.Text = ""
            txtAlasan.Text = ""
            txtDisetujui.Text = ""
            txtPelapor.Text = ""
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If txtSP.EditValue = "" Then
                showMessages("Nomor SP Belum Diisi", , "WARNING")
                txtSP.Focus()
                Exit Sub
            End If
            If txtAlasan.EditValue = "" Then
                showMessages("Alasan Pembatalan Belum Diisi", , "WARNING")
                txtAlasan.Focus()
                Exit Sub
            End If
            If txtPelapor.EditValue = "" Then
                showMessages("Nama Pelapor Belum Diisi", , "WARNING")
                txtPelapor.Focus()
                Exit Sub
            End If
            If txtDisetujui.EditValue = "" Then
                showMessages("Nama Menyetujui Belum Diisi", , "WARNING")
                txtDisetujui.Focus()
                Exit Sub
            End If
        End If

        If Not isDelete Then
            If State = "ADD" Then
                row = dsete.Tables("batal").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
            ElseIf State = "EDIT" Then
                row = dsete.Tables("batal").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang
            row.Item("Jenis_Pembatalan") = "FORCE_OPEN"
            row.Item("Keputusan") = "OK"
            row.Item("Tgl_Batal") = getTanggal()
            txtTgl.Text = row.Item("Tgl_Batal")
            row.Item("No_sp") = txtSP.Text
            row.Item("Alasan") = txtAlasan.Text
            row.Item("Disetujui") = txtDisetujui.Text
            row.Item("Oleh") = txtPelapor.Text
            row.Item("Program_Name") = Me.Name

            If State = "ADD" Then
                dsete.Tables("batal").Rows.Add(row)
            End If

        End If
        Try

            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                row.Item("No_Batal") = getNoTrans("SPBTL", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("No_Batal")
            End If
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("batal"))

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch e As Exception

            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("batal").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub txtSP_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSP.ButtonPressed
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans Jenis_SP , [Nama_Customer] from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and isnull(isClosed,'-') <> 'Y' and [status]='OK' order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txtSP.EditValue = frmCari.row.Item("Nomor")
            txtNamaCustomer.Text = frmCari.row.Item("Nama_Customer")
        End If
        Dim dr As SqlDataReader = New SqlCommand("select * from prod.dbo.prod_rcn_prod_d where no_sp='" & txtSP.Text & "'", sqlconn).ExecuteReader
        dr.Read()
        prn.btnSave.Enabled = False
        If dr.HasRows Then
            lblStatusSP.Text = " On Production Planing"
            prn.btnSave.Enabled = True
        End If
        dr.Close()

        dr = New SqlCommand("select * from prod.dbo.PROD_rcn_krm_d where no_sp='" & txtSP.Text & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblStatusSP.Text = " On Delivery Planing"
            prn.btnSave.Enabled = True
        End If
        If Not prn.btnSave.Enabled Then
            lblStatusSP.Text = " SP Masih Terbuka"
        End If
        dr.Close()

    End Sub
    Private Sub pembatalan(ByVal btrans As SqlTransaction)
        Dim btl As String
        Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set FORCE_OPEN='Y', alasan='" & txtAlasan.Text & "' where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
    End Sub
   

End Class