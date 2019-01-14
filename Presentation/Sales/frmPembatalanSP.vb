Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmPembatalanSP
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
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
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
        txtJenisPembatalan.EditValue = vbNullString
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
        txtJenisPembatalan.Properties.DataSource = dsete.Tables("JenisPembatalan")
        prn = frmMain
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Pembatalan ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            save_click(True)
        End If
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
                With New SqlCommand("select Atas_nama from sales.dbo.sales_so where no_sp='" & txtSP.Text & "'", sqlconn).ExecuteReader
                    .Read()
                    If .HasRows Then
                        txtNamaCustomer.EditValue = .Item(0)
                    End If
                    .Close()
                End With

                txtKeputusan.EditValue = .Item("Keputusan")
                txtJenisPembatalan.EditValue = .Item("Jenis_Pembatalan")
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
            txtJenisPembatalan.EditValue = vbNullString

            txtSP.Properties.ReadOnly = False
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
            row.Item("Jenis_Pembatalan") = txtJenisPembatalan.EditValue
            row.Item("Keputusan") = txtKeputusan.Text
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
                row.Item("No_Batal") = getNoTrans("SPBTL", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("No_Batal")
            End If
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("batal"))
            If txtKeputusan.Text = "INTERNAL" Then
                to_internal(BTRANS)
            Else
                pembatalan(BTRANS, isDelete)
            End If

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
    Private Sub txtSP_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSP.ButtonPressed
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans Jenis_SP , [Nama_Customer] from sales.dbo.[VSO_REP] where isnull(isClosed,'-') <> 'Y' and [status]='OK' order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            txtSP.EditValue = frmCari.row.Item("Nomor")
            txtNamaCustomer.Text = frmCari.row.Item("Nama_Customer")
        End If
        Dim dr As SqlDataReader = New SqlCommand("select 1 from prod.dbo.prod_rcn_prod_d d, prod.dbo.prod_rcn_prod_m m where no_sp='" & txtSP.Text & "' and d.no_rph=m.no_rph and not no_spk is null", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblStatusSP.Text = " On SPK"
        End If
        dr.Close()

        dr = New SqlCommand("select 1 from prod.dbo.PROD_rcn_krm_d where no_sp='" & txtSP.Text & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblStatusSP.Text = " On Delivery Planing"
            'prn.btnSave.Enabled = False
        End If
        dr.Close()

    End Sub
    Private Sub to_internal(ByVal btrans As SqlTransaction)
        Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set Kd_customer='INTERNAL', JENIS_SP='INTERNAL', jml_rp_trans=0,JML_VALAS_TRANS=0,Biaya=0, Tipe_trans'" & gettipeTrans("JPJ", "INTERNAL") & "' where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
        i = New SqlCommand("update sales.dbo.sales_sod set harga=0, potongan_total=0, potongan=0, disc1=0,disc2=0,disc3=0,disc4=0,disc5=0, Tipe_trans'" & gettipeTrans("JPJ", "INTERNAL") & "' where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
        i = New SqlCommand("delete sales.dbo.SALES_SO_BIAYA where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
        i = New SqlCommand("delete sales.dbo.SALES_SO_PROMO where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
    End Sub
    Private Sub pembatalan(ByVal btrans As SqlTransaction, Optional ByVal isdelete As Boolean = False)
        Dim btl As String
        If txtKeputusan.Text = "BATAL" Then
            btl = "CANCEL"
        Else
            btl = "OK"
        End If
        If Not isdelete Then
            Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set isClosed='Y', [status]='" & btl & "' , alasan='" & txtAlasan.Text & "' where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
        Else
            Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set isClosed=null, [status]='OK' , alasan='' where no_sp='" & txtSP.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
        End If
    End Sub

    Private Sub txtKeputusan_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKeputusan.EditValueChanging
        'If lblStatusSP.Text <> "" And txtKeputusan.Text = "BATAL" Then
        '    MsgBox("SP tidak bisa dibatalkan", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Batal SP")
        '    e.Cancel = True
        '    txtKeputusan.EditValue = vbNullString
        'End If
    End Sub
    Private Sub txtKeputusan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeputusan.SelectedIndexChanged

        If sender.text = "" Then
            lblState.Text = ""
        ElseIf sender.text = "INTERNAL" Then
            lblState.Text = "Dijadikan SP Internal"
        ElseIf sender.text = "TUTUP" Then
            lblState.Text = "Menutup SP (Masih memproses barang yang outstanding)"
        ElseIf sender.text = "BATAL" Then
            lblState.Text = "Membatalkan SP (Tidak ada proses lebih lanjut)"
        End If
    End Sub
End Class