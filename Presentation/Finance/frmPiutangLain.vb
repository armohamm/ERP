Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmPiutangLain
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public dipilih, err As String
    Dim table As DataTable
    Dim noInv As String
    Dim isOK As Boolean = True

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        isiGrid()

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        da4.Fill(ds4, "_karyawon")
        Lookkaryawan.Properties.DataSource = ds4.Tables("_karyawon")
        Lookkaryawan.Properties.ValueMember = "kode"
        Lookkaryawan.Properties.DisplayMember = "nama"

        'da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        'da5.Fill(ds5, "_karyawan")
        lookupPeg.DataSource = ds4.Tables("_karyawon")
        lookupPeg.ValueMember = "kode"
        lookupPeg.DisplayMember = "nama"

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar where kd_buku_besar like '1-44%' and grup_header='D'", sqlconn))
        da2.Fill(ds2, "_rekening")
        Lookrekening.Properties.DataSource = ds2.Tables("_rekening")
        Lookrekening.Properties.ValueMember = "kd_buku_besar"
        Lookrekening.Properties.DisplayMember = "nm_buku_besar"

        lookuprek.DataSource = ds2.Tables("_rekening")
        lookuprek.ValueMember = "kd_buku_besar"
        lookuprek.DisplayMember = "nm_buku_besar"

        txtno_inv.Enabled = False
        dttgl_inv.EditValue = getTanggal()

    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub hapus_record()
        If Not ds1.Tables("Db_data2") Is Nothing Then
            For Each rw As DataRow In ds1.Tables("Db_data2").Rows
                noInv = rw.Item("no_inv")
                rw.Delete()
            Next
        Else
            MsgBox("Tidak ada data untuk dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        State = "DELETE"
        save_click()
    End Sub

    Public Sub bersihkan()
        txtno_inv.Text = ""
        txtjml_val_trans.EditValue = vbNullString
        Lookkaryawan.EditValue = vbNullString
        txtketerangan.Text = ""
        Lookrekening.EditValue = vbNullString
    End Sub

    Public Sub isiGrid()
        bersihkan()
        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JKK-KPT-02' and not status = 'APPROVE'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        GC.DataSource = ds1.Tables("Db_data1")
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        If Lookkaryawan.EditValue = vbNullString Or Lookkaryawan.EditValue = "CST00000" Or Lookkaryawan.EditValue = "S00000" Then
            isOK = False
            err &= "Kartu harus dipilih." & vbCrLf
            If Lookrekening.EditValue = vbNullString Then
                err &= "Jenis piutang lain harus dipilih." & vbCrLf
            End If
            If txtjml_val_trans.Text = "" Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        ElseIf Lookrekening.EditValue = vbNullString Then
            isOK = False
            err &= "Jenis piutang lain harus dipilih." & vbCrLf
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Kartu harus dipilih." & vbCrLf
            End If
            If txtjml_val_trans.Text = "" Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        ElseIf txtjml_val_trans.Text = "" Then
            isOK = False
            err &= "Jumlah tidak boleh kosong." & vbCrLf
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Kartu harus dipilih." & vbCrLf
            End If
            If Lookrekening.EditValue = vbNullString Then
                err &= "Jenis piutang lain harus dipilih." & vbCrLf
            End If
        End If

        If isOK = True Then
            If State = "ADD" Then
                noInv = getNoTrans("PIUTLAIN", getTanggal())
                txtno_inv.Text = noInv
                row = ds1.Tables("Db_data1").NewRow
                row.Item("no_inv") = txtno_inv.Text
                row.Item("Last_create_date") = getTanggal()
                row.Item("Last_created_by") = username
                row.Item("Program_name") = "frmPMHPiutang"
            ElseIf State = "EDIT" Then
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_JURNAL where no_jur = '" & txtno_inv.Text & "'", sqlconn))
                da2.Fill(ds2, "carijur")
                If Not ds2.Tables("carijur").Rows.Count <= 0 Then
                    If Not ds2.Tables("carijur").Rows(0).Item("no_posting").Equals("") Or ds2.Tables("carijur").Rows(0).Item("no_posting").Equals(vbNullString) Then
                        MsgBox("Nota " & txtno_inv.Text & " telah diposting dijurnal. Data tidak dapat diubah!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PERINGATAN!")
                        ds2.Tables("carijur").Clear()
                        Exit Sub
                    End If
                End If
                row = ds1.Tables("Db_data2").Rows(0)
                row.Item("Last_update_date") = getTanggal()
                row.Item("Last_updated_by") = username
            End If

            If (State = "ADD" Or State = "EDIT") Then
                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("tipe_trans") = "JKK-KPT-02"
                row.Item("tgl_inv") = dttgl_inv.DateTime
                row.Item("kd_cust") = Lookkaryawan.EditValue
                row.Item("keterangan") = txtketerangan.Text
                row.Item("jml_val_trans") = txtjml_val_trans.EditValue
                row.Item("jml_rp_trans") = txtjml_val_trans.EditValue
                row.Item("jml_tagihan") = txtjml_val_trans.EditValue
                row.Item("jml_bayar") = 0
                row.Item("kd_valuta") = "IDR"
                row.Item("status") = "MOHON"
                row.Item("kurs_valuta") = 1
                row.Item("kd_buku_besar") = Lookrekening.EditValue
                row.Item("thnbln") = dttgl_inv.DateTime.Year & Microsoft.VisualBasic.Right("0" & dttgl_inv.DateTime.Month, 2)
            End If

            If State = "ADD" Then
                ds1.Tables("Db_data1").Rows.Add(row)
            End If

            Try
                mb = New SqlCommandBuilder(da1)
                da1.UpdateCommand = mb.GetUpdateCommand()
                da1.InsertCommand = mb.GetInsertCommand()
                da1.DeleteCommand = mb.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                da1.UpdateCommand.Transaction = BTRANS
                da1.InsertCommand.Transaction = BTRANS
                da1.DeleteCommand.Transaction = BTRANS

                If State = "ADD" Then
                    da1.Update(ds1.Tables("Db_data1"))
                ElseIf State = "EDIT" Or State = "DELETE" Then
                    da1.Update(ds1.Tables("Db_data2"))
                End If

                BTRANS.Commit()
                
                showMessages("Data Telah Disimpan..!")
                bersihkan()
                isiGrid()
            Catch ex As Exception
                BTRANS.Rollback()
                If State = "ADD" Then
                    ds1.Tables("Db_data1").RejectChanges()
                ElseIf State = "EDIT" Or State = "DELETE" Then
                    ds1.Tables("Db_data2").RejectChanges()
                End If
                MsgBox(ex.Message)
            End Try

            If State = "ADD" Then
                State = "EDIT"
                btnSave = True
                btnCancel = True
                btnDelete = True
                btnEdit = False
                btnAdd = False
                setStatus()
            ElseIf State = "EDIT" Or State = "DELETE" Then
                State = "ADD"
                btnSave = True
                btnCancel = True
                btnDelete = False
                btnEdit = False
                btnAdd = False
                setStatus()
            End If
        Else
            MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            err = ""
        End If
        Try
            umum.coll_form.Item("aFormAppPiutKar").loadData()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub delete_click()
        Dim view As ColumnView = GV.Columns.View
        If Not ds1.Tables("posting") Is Nothing Then ds1.Tables("posting").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select no_posting from FIN.dbo.FIN_NOTA where no_inv = '" & view.GetFocusedRowCellValue("no_inv") & "'", sqlconn))
        da2.Fill(ds1, "posting")
        If Microsoft.VisualBasic.Len(ds1.Tables("posting").Rows(0).Item("no_posting").ToString) <= 0 Then
            If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then hapus_record()
        Else
            MsgBox("Nota dengan nomor : " & view.GetFocusedRowCellValue("no_inv") & " telah diposting. Data tidak dapat dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = True
        bersihkan()
        isiGrid()
        add_click()
    End Sub

    Private Sub GV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.Click
        Dim view As ColumnView = sender
        If Not ds1.Tables("Db_data2") Is Nothing Then ds1.Tables("Db_data2").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv = '" & view.GetFocusedRowCellValue("no_inv") & "'", sqlconn))
        da1.Fill(ds1, "Db_data2")
        txtno_inv.Text = ds1.Tables("Db_data2").Rows(0).Item("no_inv")
        noInv = ds1.Tables("Db_data2").Rows(0).Item("no_inv")
        dttgl_inv.DateTime = ds1.Tables("Db_data2").Rows(0).Item("tgl_inv")
        Lookkaryawan.EditValue = ds1.Tables("Db_data2").Rows(0).Item("kd_cust")
        Lookrekening.EditValue = ds1.Tables("Db_data2").Rows(0).Item("kd_buku_besar")
        txtjml_val_trans.EditValue = ds1.Tables("Db_data2").Rows(0).Item("jml_val_trans")
        txtketerangan.Text = ds1.Tables("Db_data2").Rows(0).Item("keterangan")
        State = "EDIT"
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        setStatus()
    End Sub

    Private Sub GV_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV.CustomColumnDisplayText
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "no" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        add_click()
        dttgl_inv.Focus()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        cancel_click()
    End Sub

    Public Sub call_frmCari()
        frmCari.set_dso(ds4.Tables("Db_data4"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            Lookkaryawan.Text = frmCari.row("Kode_Pegawai").ToString
            'TxtNama.Text = frmCari.row("nama_pegawai").ToString
            'txbNoDocBOM.Text = frmCari.row("no_dokumen_BOM").ToString
            'txbJenisBOM.Text = frmCari.row("jenis_BOM").ToString
            'rtbKet.Text = frmCari.row("keterangan").ToString
            'cbStatus.Text = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "NonAKTIF")
        End If

    End Sub

    Private Sub txtjml_val_trans_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtjml_val_trans.LostFocus
        txtketerangan.Focus()
    End Sub
End Class