Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Public Class frmProdMasterBOMService1
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle As Integer
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
  
    Public Sub reload()

        GV_BOMService.OptionsView.NewItemRowPosition = 1
        If Not ds1.Tables("BOM_SERVICE") Is Nothing Then ds1.Tables("BOM_SERVICE").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_service ", sqlconn))
        da4.Fill(ds1, "BOM_SERVICE")

        GC_Bahan.DataSource = ds1.Tables("BOM_SERVICE")

    End Sub


    Private Sub frmProdMasterBOMService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        reload()
        Me.Enabled = True
        'LoadBahan()
        'LoadGCBiaya()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        ''LoadBahan()
        ''LoadGCBiaya()
        'reload()
    End Sub

    Public Sub cancel_click()
        State = "CANCEL"
        reload()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        setStatus()
        Me.Enabled = True
    End Sub

   

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim notrans As String
        Dim tgl As Date = getTanggal()
        Dim builder As New SqlCommandBuilder(da4)


        For Each rw As DataRow In ds1.Tables("BOM_SERVICE").Rows
            If rw.RowState = DataRowState.Added Then
                notrans = getNoTrans("BOMSERV", getTanggal())
                rw("kd_cabang") = getKodeCabang()
                rw("kd_departemen") = kddep
                rw("kd_service") = notrans
                rw("rec_stat") = "Y"
                rw("last_create_date") = Now
                rw("last_created_by") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("last_update_date") = Now
                rw.Item("last_updated_by") = username
            End If
        Next

        da4.InsertCommand = builder.GetInsertCommand()
        da4.UpdateCommand = builder.GetUpdateCommand()
        Da4.DeleteCommand = builder.GetDeleteCommand()
        da4.Update(ds1, "BOM_SERVICE")
        ds1.Tables("BOM_SERVICE").AcceptChanges()
        showMessages("Data Berhasil di simpan..!", 14)


    End Sub

    Private Sub GC_Bahan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC_Bahan.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_BOMService.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar Bahan BOM Service") = MsgBoxResult.Yes Then
                    GV_BOMService.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub


    Private Sub frmProdMasterBOMService1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Height = Me.Height - 10
    End Sub

    Private Sub GV_BOMService_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_BOMService.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


    Private Sub GV_BOMService_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_BOMService.ValidateRow
        Dim isValid As Boolean = True
        If GV_BOMService.GetRow(e.RowHandle).Item("toleransi") < 0 Then
            isValid = False
            GV_BOMService.SetColumnError(ColToleransi, "Nila toleransi tidak boleh lebih kecil dari 0", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            'MessageBox.Show("Ukuran sudah ada dalam daftar.")
            MessageBox.Show("Nila toleransi tidak boleh lebih kecil dari 0")
            e.Valid = isValid
        End If
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
        'gView.Columns("rec_stat").Visible = False
        print_gc1(GC_Bahan, "                                                                                      BOM SERVICE    " & vbCrLf & _
                 "     " & vbCrLf)
        'gView.Columns("rec_stat").Visible = True
    End Sub

End Class