Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmUpdateJanjiKirim
    Dim dsete, dsete2 As New DataSet
    Dim DA, dadbe As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String, ByVal tipe_trans As String)
        dsete.Tables.Clear()
        dsete.Tables.Add("SO")
        dsete.Tables.Add("SOD")
        dsete.Tables("SOD").Columns.Add("tgl_kirimB").DataType = System.Type.GetType("System.DateTime")
        dsete.Tables("SOD").Columns.Add("tgl_kirimSPB").DataType = System.Type.GetType("System.DateTime")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "' order by No_seq", sqlconn))
        DAD.Fill(dsete, "SOD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, convert(varchar(20),tgl_kirim,101) tglKirim, convert(varchar(20),tgl_kirim_marketing,101) as tgl_kirim_marketingB from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        
        If GC.DataSource Is Nothing Then GC.DataSource = dsete.Tables("SOD")
        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglKirimA.Text = row.Item("tglKirim").ToString
            txtKode.EditValue = row.Item("Kd_Customer").ToString
            tglKirimSPB.Text = row.Item("tgl_kirim_marketingB").ToString
            txtTgl.EditValue = row("Tgl_sp").ToString
        Else
            txtNomor.Text = ""
            txtTgl.Text = ""
            tglKirimA.Text = ""
            txtKode.EditValue = Nothing
            TglKirim.EditValue = Nothing
            txtCustomer.Text = ""
            txtKode.Text = ""
        End If
        TglKirim.EditValue = Nothing
        tglKirimSP.EditValue = Nothing
    End Sub
    Private Sub txtKode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKode.EditValueChanged
        If txtKode.Text = "" Then
            txtCustomer.Text = ""
        Else
            Dim dr As SqlDataReader = New SqlCommand("select nama_customer from sif.dbo.sif_Customer where Kd_Customer='" & txtKode.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtCustomer.Text = dr(0)
            Else
                txtCustomer.Text = ""
            End If
            dr.Close()
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer] from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and tipe_trans in ('JPJ-KPT-05','" & gettipeTrans("JPJ") & "') and len(no_sp) > 15 and [status]='OK'  order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim dr As SqlDataReader = New SqlCommand("select sales.dbo.isSoProccesed('" & txtNomor.Text & "') ", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item(0) > 0 Then
                btnSave = False
            Else
                btnSave = True
            End If
            dr.Close()
            dr = Nothing
            btnadd = False
            btnEdit = False
            reload_table(frmCari.row(0), frmCari.row(2))
            btnSave = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
                cancel_click()
            End If

        End If
    End Sub
    Public Sub cancel_click()
        btnadd = False
        btnEdit = True
        btnDelete = False
        btnSave = False
        setStatus()
        reload_table("xxx", "xxx")

        Me.Enabled = False
    End Sub
    Private Sub frmUpdateJanjiKirim_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang from SIF.dbo.SIF_Barang as b where b.Kd_Depart = '" & kddep & "' and b.kd_jns_persd=1  and b.rec_stat='Y' order  by Nama_Barang", sqlconn))
        dadbe.Fill(dsete2, "VBARANG")
        repStok.DataSource = dsete2.Tables("VBARANG")
        prn = frmMain
        setStatus()
    End Sub

    Private Sub frmUpdateJanjiKirim_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Top = 5
        pnl.Height = Me.Height - 10
    End Sub
    Public Sub save_click()
        Dim myBuilder As New SqlCommandBuilder
        Dim BTRANS As SqlTransaction
        Dim dr As SqlDataReader = New SqlCommand("select [status] from sales.dbo.sales_so where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr(0).ToString = "CANCEL" Then
                MsgBox("Data Sales Order Tersebut Sudah Dibatalkan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                cancel_click()
                dr.Close()
                Exit Sub
            End If
        Else
            MsgBox("Data Sales Order Tersebut Tidak Diketemukan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
            cancel_click()
            dr.Close()
            Exit Sub
        End If
        dr.Close()
        Dim m As Date
        m = dsete.Tables("SO")(0)("Tgl_Kirim")
        If TglKirim.EditValue <> Nothing Then
            'If TglKirim.EditValue < dsete.Tables("SO")(0)("Tgl_Kirim") Then
            '    TglKirim.ErrorText = "Tanggal Kirim Salah"
            '    Exit Sub
            'End If
            'If tglKirimSP.EditValue < dsete.Tables("SO")(0)("Tgl_Kirim_Marketing") Then
            '    tglKirimSP.ErrorText = "Tanggal Kirim Salah"
            '    Exit Sub
            'End If
            'frmPaswdOTP.lblinfo.Text = "Update Janji Kirim"
            'frmPaswdOTP.ShowDialog()

            'If Not frmPaswdOTP.allowed Then
            '    showMessages("Aborted By User", , "WARNING")
            '    Exit Sub
            'End If

            dsete.Tables("SO")(0)("Tgl_Kirim") = TglKirim.EditValue
            dsete.Tables("SO")(0)("Tgl_Kirim_Marketing") = tglKirimSP.EditValue
            dsete.Tables("SO")(0)("Last_Update_Date") = getTanggal()
            dsete.Tables("SO")(0)("Last_Updated_By") = username
        Else
            TglKirim.ErrorText = "Tanggal Kirim Harap Diisi"
            Exit Sub
        End If
        For Each item As DataRow In dsete.Tables("SOD").Rows
            If item("tgl_kirimB").ToString <> "" Then
                item("Last_Update_Date") = getTanggal()
                item("Last_Updated_By") = username
                item("tgl_kirim") = item("tgl_kirimB")
            End If
        Next
        Try

            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            DA.UpdateCommand.Transaction = BTRANS
            DAD.UpdateCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")

        Catch ex As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox("Gagal Menyimpan : " & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("tgl_kirimB").ToString <> "" Then
            If e.Row.item("tgl_kirim").ToString <> "" Then
                If getTanggal() <= e.Row.item("tgl_kirim") Then
                    isValid = False
                    GV.SetColumnError(tgl_kirim, "Tgl Janji Kirim Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    GV.FocusedColumn = tgl_kirim
                End If
            Else
                If getTanggal() <= dsete.Tables("SO")(0)("Tgl_Kirim") Then
                    isValid = False
                    GV.SetColumnError(tgl_kirim, "Tgl Janji Kirim Salah.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    GV.FocusedColumn = tgl_kirim
                End If
            End If
        End If
        e.Valid = isValid
    End Sub
End Class