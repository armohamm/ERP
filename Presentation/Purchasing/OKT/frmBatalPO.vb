Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmBatalPO
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Dim State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
   
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

    Public Sub edit_click()
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe = New SqlDataAdapter("select no_batal Nomor, tgl_batal Tanggal, no_sp Nomor_SP, Alasan from sales.dbo.sales_sp_batal", sqlconn)
        dadbe.Fill(dsete, "lookup_so")

        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            btnadd = False
            btnEdit = False
            loadTable(frmCari.row(0))
            State = "EDIT"
            btnCancel = True
            btnDelete = True
            Me.Enabled = True
            btnSave = True
            setStatus()
        Else
            cancel_click()
            State = ""
        End If
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
        txtKeputusan.EditValue = vbNullString
        txtAlasan.EditValue = vbNullString
        txtPelapor.EditValue = vbNullString
        txtSP.EditValue = vbNullString
        txtDisetujui.EditValue = vbNullString
        lblStatusSP.Text = ""
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

    Private Sub frmPerbaikanDPM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        loadTable("xxx")
        prn = frmMain
        setStatus()
    End Sub

    Private Sub loadTable(ByVal kode As String)
        If Not dsete.Tables("batal") Is Nothing Then dsete.Tables("batal").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from purc.dbo.[PURC_PO_BATAL] where Nomor='" & kode & "'", sqlconn))
        DA.Fill(dsete, "batal")
        If dsete.Tables("batal").Rows.Count > 0 Then
            With dsete.Tables("batal").Rows(0)
                txtNomor.Text = .Item("Nomor")
                txtTgl.Text = .Item("Tgl")
                txtSP.Text = .Item("no_po")
                With New SqlCommand("select Atas_nama from sales.dbo.sales_so where no_sp='" & txtSP.Text & "'", sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        txtNamaCustomer.EditValue = .Item(0)
                    End If
                    .Close()
                End With

                txtKeputusan.EditValue = .Item("Keputusan")
                txtAlasan.Text = .Item("Alasan")
                txtDisetujui.Text = .Item("Disetujui")
                txtPelapor.Text = .Item("Oleh")
                txtSP.Properties.ReadOnly = True
            End With
        Else
            txtNomor.Text = ""
            txtTgl.Text = ""
            txtSP.Text = ""
            txtAlasan.Text = ""
            txtDisetujui.Text = ""
            txtPelapor.Text = ""
            txtKeputusan.EditValue = vbNullString
            txtSP.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub txtSP_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSP.ButtonPressed
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_po [Nomor_PO], Tgl_po, Nama_Supplier Supplier from purc.dbo.vPO_REP where isnull(no_posting,'')='' and isnull(status_po,'') = '' order by no_po ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txtSP.EditValue = frmCari.row.Item("Nomor_PO")
            txtNamaCustomer.Text = frmCari.row.Item("Supplier")
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If txtSP.EditValue = "" Then
                showMessages("Nomor PO Belum Diisi", , "WARNING")
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
            row.Item("Keputusan") = txtKeputusan.Text
            row.Item("Tgl") = getTanggal()
            txtTgl.Text = row.Item("Tgl")
            row.Item("No_po") = txtSP.Text
            row.Item("Alasan") = txtAlasan.Text
            row.Item("Disetujui") = txtDisetujui.Text
            row.Item("Oleh") = txtPelapor.Text
            row.Item("Program_Name") = Me.Name

            If State = "ADD" Then
                dsete.Tables("batal").Rows.Add(row)
            End If
        Else
            dsete.Tables("batal").Rows(0).Delete()
        End If
        Try

            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                row.Item("Nomor") = getNoTrans("POBTL", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("Nomor")
            End If
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("batal"))

            With New SqlCommand("update purc.dbo.purc_po set rec_stat = null, status_po='" & txtKeputusan.EditValue & "' where no_po='" & txtSP.Text & "'", sqlconn, BTRANS).ExecuteNonQuery

            End With

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
            If isDelete Then cancel_click()
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("batal").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
End Class