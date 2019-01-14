Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting
Public Class frmMstIndeksBarang

    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, da9 As New SqlDataAdapter
    Dim row, rw As DataRow
    Dim prn As frmMain
    Dim sqlq As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public STATE As String
    Dim a, b As String
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

    Public Sub edit_click()
        gView.OptionsView.NewItemRowPosition = 0
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        setStatus()
        STATE = "EDIT"
    End Sub
    Public Sub cancel_click()
        gView.OptionsView.NewItemRowPosition = 0
        txtkegiatanppic.EditValue = vbNullString
        txtjnsbarang.EditValue = vbNullString
        If Not ds6.Tables("IndeksBrg") Is Nothing Then ds6.Tables("IndeksBrg").Clear()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        STATE = "CANCEL"
    End Sub
    Private Sub frmMstIndeksBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        prn = getParent(Me)
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTPPIC'", sqlconn))
        da1.Fill(ds1, "JnsKegiatan")
        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jenis_Barang order by Nama_Jenis", sqlconn))
        da2.Fill(ds2, "JnsBrg")
        da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_tipe where kd_jns ='" & txtjnsbarang.EditValue & "'", sqlconn))
        da3.Fill(ds3, "Tipe")

        'da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_tipe", sqlconn))
        'da3.Fill(ds3, "Tipe")

        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_sub_tipe ", sqlconn))
        da4.Fill(ds4, "SubTipe")
        da5 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_ukuran ", sqlconn))
        da5.Fill(ds5, "Ukuran")
        da6 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis ='" & txtjnsbarang.EditValue & "'", sqlconn))
        da6.Fill(ds6, "IndeksBrg")
        da7 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis= '" & txtjnsbarang.EditValue & "'and kd_tipe='" & a & "' and kd_ukuran= '" & b & "'  ", sqlconn))
        da7.Fill(ds7, "datahapus")
        gControl.DataSource = ds6.Tables("IndeksBrg")

        txtkegiatanppic.Properties.DataSource = ds1.Tables("jnsKegiatan")
        txtkegiatanppic.Properties.ValueMember = "Id_Data"
        txtkegiatanppic.Properties.DisplayMember = "Desc_Data"

        txtjnsbarang.Properties.DataSource = ds2.Tables("JnsBrg")
        txtjnsbarang.Properties.ValueMember = "Kd_Jns_Brg"
        txtjnsbarang.Properties.DisplayMember = "Nama_Jenis"

        kkd_tipe.DataSource = ds3.Tables("Tipe")
        kkd_tipe.ValueMember = "Kode_Tipe"
        kkd_tipe.DisplayMember = "Nama_Tipe"

        kkd_sub_tipe.DataSource = ds4.Tables("SubTipe")
        kkd_sub_tipe.ValueMember = "Kd_Sub_Tipe"
        kkd_sub_tipe.DisplayMember = "Nama_Sub_Tipe"

        kdukuran.DataSource = ds5.Tables("ukuran")
        kdukuran.ValueMember = "Kode_Ukuran"
        kdukuran.DisplayMember = "Nama_Ukuran"

        'gView.Columns(0).ColumnEdit = kkd_tipe
        'gView.Columns(1).ColumnEdit = kdukuran

        'gView.Columns(4).ColumnEdit = ckStatus

        gView.OptionsView.NewItemRowPosition = 0
    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged
        Dim tinggi, lebar, panjang, volume As Double
        If e.Column.ToString = "Ukuran" Then

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select Tinggi, Lebar, Panjang  from SIF.dbo.SIF_UKURAN where Kode_Ukuran ='" & e.Value.ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            tinggi = IIf(dr.Item("Tinggi") = 0, 1, dr.Item("Tinggi"))
            lebar = IIf(dr.Item("Lebar") = 0, 1, dr.Item("Lebar"))
            panjang = IIf(dr.Item("Panjang") = 0, 1, dr.Item("Panjang"))
            volume = (tinggi * lebar * panjang) / 1000000

            'gControl.FocusedView.GetRow(e.RowHandle).Item("nilai_m3") = volume
            gView.SetRowCellValue(e.RowHandle, "nilai_m3", Math.Round(volume, 2))
            dr.Close()
        End If
    End Sub

    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        If STATE = "ADD" Then
            Dim isValid As Boolean = True
            Dim rw() As DataRow = ds6.Tables("IndeksBrg").Select("kd_tipe = '" & e.Row.item("kd_tipe") & "' and kd_ukuran= '" & e.Row.item("kd_ukuran") & "' ")

            If rw.Count = 1 Then
                isValid = False

                Dim y As Object
                y = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                y.SetColumnError(kd_tipe, "Tipe sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Tipe sudah ada dalam daftar.")
                Dim x As Object
                x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                x.SetColumnError(kd_ukuran, "Ukuran sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Ukuran sudah ada dalam daftar.")


            End If

            If e.Row.item("kd_tipe").ToString = "" Then
                isValid = False
                Dim k As Object

                k = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                k.SetColumnError(kd_tipe, "Tipe tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Tipe tidak boleh kosong.")
            End If

            If e.Row.item("kd_ukuran").ToString = "" Then
                isValid = False
                Dim l As Object

                l = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                l.SetColumnError(kd_ukuran, "Ukuran tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Ukuran tidak boleh kosong.")

            End If

            If e.Row.item("nilai").ToString = "" Then
                isValid = False
                Dim j As Object
                j = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                j.SetColumnError(Nilai, "Kolom Nilai harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If

            e.Valid = isValid
        Else

        End If
       
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
       
    End Sub

    Public Sub save_click()

        If txtjnsbarang.EditValue <> "" Or txtkegiatanppic.EditValue <> "" Then
            Try
                For Each rows As DataRow In ds6.Tables("IndeksBrg").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("kd_jenis") = txtjnsbarang.EditValue
                        rows.Item("jns_kegiatan") = txtkegiatanppic.EditValue
                        rows.Item("kd_cabang") = getKodeCabang()
                        rows.Item("kd_divisi") = kddep
                        rows.Item("last_create_date") = Now
                        rows.Item("last_created_by") = username


                    End If
                Next


                Dim mybuilder As New SqlCommandBuilder(da6)
                da6.UpdateCommand = mybuilder.GetUpdateCommand

                da6.Update(ds6.Tables("IndeksBrg"))
                ds6.Tables("IndeksBrg").AcceptChanges()
                showMessages("Saved..")


                ds6.Clear()
                ds6.Reset()
                da6.Fill(ds6, "IndeksBrg")
                gControl.DataSource = ds6.Tables("IndeksBrg")



            Catch err As Exception
                MessageBox.Show(err.Message, "Gagal Simpan")
            End Try

        Else
            MessageBox.Show("Pilih Jenis Kegiatan Terlebih Dahulu!")
        End If
    End Sub
   
    Public Sub delete_click()

        

        If gView.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Record") = MsgBoxResult.Yes Then
                gView.DeleteSelectedRows()
                Dim mybuilder As New SqlCommandBuilder(da6)
                da6.UpdateCommand = mybuilder.GetUpdateCommand

                da6.Update(ds6.Tables("IndeksBrg"))
                ds6.Tables("IndeksBrg").AcceptChanges()
                showMessages("Saved..")


                ds6.Clear()
                ds6.Reset()
                da6.Fill(ds6, "IndeksBrg")
                gControl.DataSource = ds6.Tables("IndeksBrg")

            End If
        End If



       
    End Sub

    Private Sub txtkegiatanppic_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkegiatanppic.EditValueChanged
        If STATE = "ADD" Then
            gView.OptionsView.NewItemRowPosition = 1
            da6 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis ='" & txtjnsbarang.EditValue & "'", sqlconn))
            ds6.Clear()
            da6.Fill(ds6, "IndeksBrg")
            gControl.DataSource = ds6.Tables("IndeksBrg")
        ElseIf STATE = "EDIT" Then
            gView.OptionsView.NewItemRowPosition = 0
            da6 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis ='" & txtjnsbarang.EditValue & "'", sqlconn))
            ds6.Clear()
            da6.Fill(ds6, "IndeksBrg")
            gControl.DataSource = ds6.Tables("IndeksBrg")
        End If
        
    End Sub

    Private Sub txtjnsbarang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtjnsbarang.EditValueChanged
        If STATE = "ADD" Then
            gView.OptionsView.NewItemRowPosition = 1
            da6 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis ='" & txtjnsbarang.EditValue & "'", sqlconn))
            ds6.Clear()
            da6.Fill(ds6, "IndeksBrg")
            gControl.DataSource = ds6.Tables("IndeksBrg")

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_tipe ", sqlconn))
            da3.Fill(ds3, "Tipe")
            kkd_tipe.DataSource = ds3.Tables("Tipe")
            kkd_tipe.ValueMember = "Kode_Tipe"
            kkd_tipe.DisplayMember = "Nama_Tipe"
        ElseIf STATE = "EDIT" Then
            gView.OptionsView.NewItemRowPosition = 0
            da6 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan='" & txtkegiatanppic.EditValue & "' and kd_jenis ='" & txtjnsbarang.EditValue & "'", sqlconn))
            ds6.Clear()
            da6.Fill(ds6, "IndeksBrg")
            gControl.DataSource = ds6.Tables("IndeksBrg")

            da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_tipe ", sqlconn))
            da3.Fill(ds3, "Tipe")
            kkd_tipe.DataSource = ds3.Tables("Tipe")
            kkd_tipe.ValueMember = "Kode_Tipe"
            kkd_tipe.DisplayMember = "Nama_Tipe"
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
        gView.Columns("rec_stat").Visible = False
        print_gc1(gControl, "                                                                           MASTER INDEKS BARANG    " & vbCrLf & _
                 "     " & vbCrLf & _
                 "Jenis Kegiatan       : " & txtkegiatanppic.Text & vbCrLf & _
                 "Jenis Barang          : " & txtjnsbarang.Text)
        gView.Columns("rec_stat").Visible = True
    End Sub

End Class