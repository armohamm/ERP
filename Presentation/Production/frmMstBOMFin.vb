Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Public Class frmMstBOMFin
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim rhandle As Integer
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
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

    Private Sub frmMstBOMProd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom", sqlconn))
        da2.Fill(ds1, "BOM")

        If Not ds1.Tables("jnsBOM") Is Nothing Then ds1.Tables("jnsBOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct(kd_bom), nama_bom from SIF.dbo.SIF_bom order by nama_bom", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        txtBOM.Properties.DataSource = ds1.Tables("jnsBOM")
        txtBOM.Properties.ValueMember = "kd_bom"
        txtBOM.Properties.DisplayMember = "nama_bom"

        If Not ds1.Tables("jnsKegiatan") Is Nothing Then ds1.Tables("jnsKegiatan").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where Ref_Role='PROD' and Id_Ref_File='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKegiatan")
        repKegiatan.DataSource = ds1.Tables("jnsKegiatan")
        

        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar", sqlconn))
        da1.Fill(ds1, "jnsRekening")
        repRekening.DataSource = ds1.Tables("jnsRekening")

        

        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where 1=0", sqlconn))
        da3.Fill(ds1, "childBOM")
        GC.DataSource = ds1.Tables("childBOM")

        

        GV.OptionsView.NewItemRowPosition = 0


    End Sub

    Public Sub reload(ByVal kdbom As String)
       

        GV.OptionsView.NewItemRowPosition = 1
        If Not ds1.Tables("BOM") Is Nothing Then ds1.Tables("BOM").Clear()
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom='" & kdbom & "'", sqlconn))
        da2.Fill(ds1, "BOM")
        If ds1.Tables("BOM").Rows.Count > 0 Then
            row = ds1.Tables("BOM").Rows(0)
            txtRevisi.Text = row.Item("revisi")
            txtBOM.EditValue = row.Item("kd_bom")


           

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom='" & kdbom & "'", sqlconn))
            da3.Fill(ds1, "childBOM")
            GC.DataSource = ds1.Tables("childBOM")
        Else
            showMessages("Tidak ada data" & txtRevisi.Text)
        End If


    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        'reload()
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT(b.kd_bom) KODE, a.nama_barang NAMA, b.revisi REVISI, b.last_update_date TANGGAL from SIF.dbo.SIF_bom_biaya b left join SIF.dbo.SIF_Barang a on b.kd_bom=a.Kode_Barang order by a.nama_barang", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'txtRevisi.Text = frmCari.row("REVISI")
            'txtBOM.EditValue = frmCari.row("KODE")
            reload(frmCari.row("KODE").ToString)
            State = "EDIT"
            txtBOM.Properties.ReadOnly = True
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click()
        If txtBOM.EditValue = Nothing Then
            MessageBox.Show("Jenis BOM belum dipilih.")
            Exit Sub
        End If
        
        
        Dim tgl As Date = getTanggal()


        For Each rows As DataRow In ds1.Tables("childBOM").Rows
            If rows.RowState <> DataRowState.Deleted Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_bom") = txtBOM.EditValue
                    rows.Item("revisi") = "0"
                    rows.Item("last_create_date") = tgl
                    rows.Item("last_created_by") = username
                End If
                rows.Item("last_update_date") = tgl
                rows.Item("last_updated_by") = username
                rows.Item("program_name") = Me.Name
                rows.Item("kd_cabang") = kdcabang
                rows.Item("kd_departemen") = kddep
            End If
        Next

        Dim mybuilder3 As New SqlCommandBuilder(da3)
        da3.UpdateCommand = mybuilder3.GetUpdateCommand
        da3.Update(ds1.Tables("childBOM"))
        ds1.Tables("childBOM").AcceptChanges()

        showMessages("Data berhasil disimpan.")
        State = "EDIT"
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Gagal Simpan")

        End Try

        
    End Sub

    Public Sub delete_click()
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            x.DeleteSelectedRows()
            If GC.FocusedView.Name = "GV2" Then
                refreshNomer()
            End If
        End If
        
    End Sub

    Public Sub cancel_click()
        State = "CANCEL"
        txtBOM.EditValue = Nothing
        txtBOM.Properties.ReadOnly = False
        txtRevisi.Text = 0

        GV.OptionsView.NewItemRowPosition = 0
        GC.DataSource = Nothing


        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged
        If e.Column.ToString = "Nama Barang" Then
            GV2.SetRowCellValue(e.RowHandle, "satuan", "UNITS")
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan " & _
                                                               "from SIF.dbo.SIF_Barang B " & _
                                                               "left join SIF.dbo.SIF_Satuan S " & _
                                                               "on B.Kd_Satuan=S.Kode_Satuan " & _
                                                               "where B.Kode_Barang = '" & e.Value.ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            GC.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
            dr.Close()
        End If
    End Sub
    

    Private Sub GV2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV2.InitNewRow
        GC.FocusedView.GetRow(e.RowHandle).Item("rec_stat") = "Y"
        GC.FocusedView.GetRow(e.RowHandle).Item("no_urut") = GC.FocusedView.RowCount + 1
    End Sub

    Private Sub GV2_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        GV.ExpandMasterRow(GV.GetSelectedRows(0), "Detail")
    End Sub

    Private Sub refreshNomer() '(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim x As Object
        Dim i As Int16
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To GC.FocusedView.RowCount - 1
            GC.FocusedView.GetRow(i).Item("no_urut") = i + 1
        Next
    End Sub

    
    Private Sub txtBOM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBOM.EditValueChanged

        Dim dr As SqlDataReader

        GV.OptionsView.NewItemRowPosition = 1

        
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        If Not ds1.Tables("dtlBOM") Is Nothing Then ds1.Tables("dtlBOM").Clear()
        Dim newrev As Integer = 0
        dr = New SqlClient.SqlCommand("select max(revisi) revisi from SIF.dbo.SIF_bom where kd_bom='" & txtBOM.EditValue & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.Item("revisi").ToString <> "" Then
            newrev = dr.Item("revisi") + 1
        End If
        dr.Close()
        txtRevisi.Text = newrev
        
        If Not ds1.Tables("childBOM") Is Nothing Then ds1.Tables("childBOM").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_biaya where kd_bom ='" & txtBOM.EditValue & "'", sqlconn))
        da3.Fill(ds1, "childBOM")
        GC.DataSource = ds1.Tables("childBOM")



    End Sub

    Private Sub GV2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV2.KeyDown, GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            delete_click()
        End If
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV2.ValidateRow
        Dim isValid As Boolean = True
        Dim rw() As DataRow = ds1.Tables("childBOM").Select("kd_rek = '" & e.Row.item("kd_rek") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                Dim x As Object
                x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                x.SetColumnError(clRekening2, "Jenis Rekening Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Jenis Rekening Sudah Ada dalam Daftar.")
            End If
        End If
        e.Valid = isValid
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
        link.Margins.Top = 105
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        GV2.Columns("no_urut").Visible = False
        GV2.Columns("rec_stat").Visible = False
        print_gc1(GC, "                                                                                   BIAYA PRODUKSI    " & vbCrLf & _
                 "     " & vbCrLf & _
                 vbCrLf & "Nama Barang   : " & txtBOM.Text)
        GV2.Columns("no_urut").Visible = True
        GV2.Columns("rec_stat").Visible = True
    End Sub
End Class