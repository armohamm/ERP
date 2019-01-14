Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting

Public Class frmMstSpk
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String
    Dim a1, b1 As String
    Dim ganti As String
    Dim a, b, c As Integer
   
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmMstSpk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "EDIT"
        prn = getParent(Me)
        da1 = New SqlDataAdapter(New SqlCommand("select distinct kd_bom,br.Nama_Barang as nama_bom from SIF.dbo.SIF_bom a " & _
                                                "left join SIF.dbo.SIF_Barang br " & _
                                                "on br.Kode_Barang = a.kd_bom union " & _
"                                               select distinct kd_service,nama_service from [SIF] .[dbo].[SIF_bom_service] b ", sqlconn))
        da1.Fill(ds1, "jnsBrg")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='SPK'", sqlconn))
        da1.Fill(ds1, "spk")
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Tipe ", sqlconn))
        da1.Fill(ds1, "tipe")
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_s where kd_bom='" & txtJenisBrg.EditValue & "'", sqlconn))
        da2.Fill(ds2, "dtlKeg")


        gControl.DataSource = ds2.Tables("dtlKeg")

        txtJenisBrg.Properties.DataSource = ds1.Tables("jnsBrg")
        txtJenisBrg.Properties.ValueMember = "kd_bom"
        txtJenisBrg.Properties.DisplayMember = "nama_bom"

        lkKegiatan.DataSource = ds1.Tables("jnsKeg")
        lkKegiatan.ValueMember = "Id_Data"
        lkKegiatan.DisplayMember = "Desc_Data"

        lkspk.DataSource = ds1.Tables("spk")
        lkspk.ValueMember = "Id_Data"
        lkspk.DisplayMember = "Desc_Data"


        gView.Columns(0).ColumnEdit = lkKegiatan
        gView.Columns(1).ColumnEdit = lkspk
        gView.Columns(3).ColumnEdit = ckStatus
        gView.Columns(4).ColumnEdit = CE_StatusHPP

        gView.OptionsView.NewItemRowPosition = 0

    End Sub

    Private Sub txtJenisBrg_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJenisBrg.EditValueChanged
        If Not ds2.Tables("dtlKeg") Is Nothing Then ds2.Tables("dtlKeg").Clear()


        gView.OptionsView.NewItemRowPosition = 1

        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_s where kd_bom='" & txtJenisBrg.EditValue & "'", sqlconn))
        da2.Fill(ds2, "dtlKeg")
        
        gControl.DataSource = ds2.Tables("dtlKeg")

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged

        If e.Column.ToString = "Kegiatan" Or e.Column.ToString = "SPK" And e.Column.ToString = "Keterangan" Then
            ganti = "1"
        ElseIf e.Column.ToString = "Kegiatan" Or e.Column.ToString = "SPK" Then
            ganti = "1"
        Else

            ganti = "0"
        End If
    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
        gView.GetRow(e.RowHandle).item("status_hpp") = "Y"
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        If ganti = "1" Then

            Dim isValid As Boolean = True
            Dim rw() As DataRow = ds2.Tables("dtlKeg").Select("kd_kegiatan = '" & e.Row.item("kd_kegiatan") & "' and kd_spk= '" & e.Row.item("kd_spk") & "' ")
            If rw.Count = 1 Then
                isValid = False

                Dim y As Object
                y = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                y.SetColumnError(kd_kegiatan, "Kode Kegiatan sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Kode Kegiatan sudah ada dalam daftar.")
                Dim x As Object
                x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                x.SetColumnError(kd_spk, "Kode Sp sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Kode Spk sudah ada dalam daftar.")
            End If

            e.Valid = isValid
        Else
            Dim isValid As Boolean = True
            e.Valid = isValid

        End If
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gView.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Kegiatan Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    gView.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Public Sub save_click()
        Dim tgl As Date = getTanggal()
        If txtJenisBrg.EditValue <> "" Then
            Try
                For Each rows As DataRow In ds2.Tables("dtlKeg").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("kd_bom") = txtJenisBrg.EditValue
                        rows.Item("last_create_date") = tgl
                        rows.Item("last_created_by") = username
                    End If
                    rows.Item("last_update_date") = tgl
                    rows.Item("last_updated_by") = username
                    rows.Item("program_name") = Me.Name
                    rows.Item("kd_cabang") = kdcabang
                    rows.Item("kd_departemen") = kddep
                Next

                Dim mybuilder As New SqlCommandBuilder(da2)
                da2.UpdateCommand = mybuilder.GetUpdateCommand
                da2.Update(ds2.Tables("dtlKeg"))
                ds2.Tables("dtlKeg").AcceptChanges()
                showMessages("Saved..")
            Catch
                MessageBox.Show("Data Sudah ada")
            End Try

        Else
            MessageBox.Show("Pilih Jenis Barang Terlebih Dahulu!")
        End If
    End Sub
    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        setStatus()
        State = "ADD"
    End Sub

    Public Sub edit_click()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct kd_bom [KODE],nama_bom [NAMA BARANG] from SIF.dbo.SIF_bom a union " & _
                                                                    "select distinct kd_service [KODE],nama_service [NAMA BARANG] from [SIF] .[dbo].[SIF_bom_service] b ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_bom_s where kd_bom='" & frmCari.row("KODE") & "'", sqlconn)) '<- query buat ditampilkan di LOV
            da2.Fill(ds2, "dtlKeg")
            gControl.DataSource = ds2.Tables("dtlKeg")
            txtJenisBrg.EditValue = frmCari.row("KODE")
            State = "EDIT"
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            setStatus()
            Me.Enabled = True
        End If


    End Sub
    Public Sub delete_click()
        If gView.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                gView.DeleteSelectedRows()
                Dim mybuilder As New SqlCommandBuilder(da2)
                da2.UpdateCommand = mybuilder.GetUpdateCommand
                da2.Update(ds2.Tables("dtlKeg"))
                ds2.Tables("dtlKeg").AcceptChanges()
                showMessages("Deleted..")
                ds2.Clear()
                ds2.Reset()
                da2.Fill(ds2, "dtlKeg")
                gControl.DataSource = ds2.Tables("dtlKeg")

            End If
        End If
    End Sub

    Public Sub cancel_click()
        txtJenisBrg.EditValue = vbNullString
        If Not ds2.Tables("dtlKeg") Is Nothing Then ds2.Tables("dtlKeg").Clear()
        gControl.DataSource = Nothing

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
        State = "CANCEL"
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_s ", sqlconn))
        ds2.Clear()
        ds2.Reset()
        da2.Fill(ds2, "dtlKeg")
        gControl.DataSource = ds2.Tables("dtlKeg")
        txtJenisBrg.EditValue = Nothing
        txtJenisBrg.Properties.NullText = "[Pilih Jenis Barang]"

    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 100
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        gView.Columns("rec_stat").Visible = False
        print_gc1(gControl, "                                                                                      MASTER SPK    " & vbCrLf & _
                 "     " & vbCrLf & _
                 "Nama BOM         : " & txtJenisBrg.Text)
        gView.Columns("rec_stat").Visible = True
        gView.Columns("status_hpp").Visible = True
    End Sub

  
End Class