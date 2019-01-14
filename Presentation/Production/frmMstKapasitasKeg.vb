Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting

Public Class frmMstKapasitasKeg

    Dim dsPPIC, dsJenis, dsKapasitas As New DataSet
    Dim daPPIC, daJenis, daKapasitas As SqlDataAdapter
    Dim row As DataRow
    Dim prn As frmMain
    Dim sqlq As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public STATE As String
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        setStatus()
        STATE = "ADD"
    End Sub
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
        STATE = "CANCEL"
    End Sub
    Public Sub delete_click()
        If gView.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                gView.DeleteSelectedRows()
            End If
        End If
    End Sub
    Public Sub view()
        daKapasitas = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_kapasitas_prod", sqlconn))
        dsKapasitas.Reset()
        daKapasitas.Fill(dsKapasitas, "Kapasitas")
        gControl.DataSource = dsKapasitas.Tables("Kapasitas")
        gControl.Refresh()
    End Sub
    Private Sub frmMstKapasitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        STATE = "ADD"
        prn = getParent(Me)

        daPPIC = New SqlDataAdapter(New SqlCommand("select id_data, desc_data from SIF_Gen_Reff_D where ref_role = 'PROD' and id_ref_file = 'SPK'", sqlconn))
        daPPIC.Fill(dsPPIC, "jnsKeg")
        daKapasitas = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_kapasitas_prod", sqlconn)) 'where jns_kegiatan ='" & txtkegiatanppic.EditValue & "'", sqlconn))
        daKapasitas.Fill(dsKapasitas, "Kapasitas")
        daJenis = New SqlDataAdapter(New SqlCommand("select id_data, desc_data from SIF_Gen_Reff_D where ref_role = 'PROD' and id_ref_file = 'GRPKERJA'", sqlconn))
        daJenis.Fill(dsJenis, "jnsGrp")

        gControl.DataSource = dsKapasitas.Tables("Kapasitas")

        cbKegiatan.DataSource = dsPPIC.Tables("jnsKeg")
        cbKegiatan.ValueMember = "id_data"
        cbKegiatan.DisplayMember = "desc_data"

        cbGroup.DataSource = dsJenis.Tables("jnsGrp")
        cbGroup.ValueMember = "id_data"
        cbGroup.DisplayMember = "desc_data"

    End Sub


    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged
        'If e.Column.Name = "clmKegiatan" Then
        'Dim foundRows As Integer = ds2.Tables("dtlKeg").Select("kd_kegiatan='" & e.Value.ToString & "'").Length
        'If foundRows >= 1 Then
        'gView.SetColumnError(clmKegiatan, "Jenis Kegiatan sudah ada.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'gView.FocusedRowHandle = e.RowHandle
        'gView.FocusedColumn = gView.Columns("clmKegiatan")
        'End If
        'End If
    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kd_kegiatan_spk").ToString = "" Then
            isValid = False
            gView.SetColumnError(kd_kegiatan_spk, "Kolom 'Kegiatan' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("kd_group_kerja").ToString = "" Then
            isValid = False
            gView.SetColumnError(kd_group_kerja, "Kolom 'Jenis Barang' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("jumlah_kapasitas").ToString = "" Then
            isValid = False
            gView.SetColumnError(jumlah_kapasitas, "Kolom 'Jumlah' harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gView.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Kegiatan Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Kegiatan") = MsgBoxResult.Yes Then
                    gView.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Public Sub bersihkan()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        'If State = "ADD" Then
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub save_click()
        Try
            For Each rows As DataRow In dsKapasitas.Tables("Kapasitas").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_cabang") = getKodeCabang()
                    rows.Item("last_create_date") = getTanggal()
                    rows.Item("last_created_by") = username
                    'rows.Item("last_update_date") = getTanggal()
                    'rows.Item("last_updated_by") = username
                    rows.Item("program_name") = Me.Name
                End If
            Next

            Dim mybuilder As New SqlCommandBuilder(daKapasitas)
            daKapasitas.UpdateCommand = mybuilder.GetUpdateCommand
            daKapasitas.Update(dsKapasitas.Tables("Kapasitas"))
            dsKapasitas.Tables("Kapasitas").AcceptChanges()
            showMessages("Data Telah Disimpan..!")
        Catch err As Exception
            MessageBox.Show(err.Message, "Gagal Simpan")
        End Try

        bersihkan()
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
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        gView.Columns("rec_stat").Visible = False
        print_gc1(gControl, "                                                                       MASTER KAPASITAS KEGIATAN    " & vbCrLf & _
                 "     " & vbCrLf)
        gView.Columns("rec_stat").Visible = True
    End Sub

End Class