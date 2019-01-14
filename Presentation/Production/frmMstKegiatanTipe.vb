Imports System.Data.SqlClient

Public Class frmMstKegiatanTipe

    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9, ds10 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, da9, da10 As New SqlDataAdapter
    Dim row As DataRow
    Dim prn As frmMain
    Dim sqlq As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
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
        txtkegiatanppic.EditValue = vbNullString
        If Not ds4.Tables("kegiatan") Is Nothing Then ds4.Tables("kegiatan").Clear()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        STATE = "CANCEL"
    End Sub
    Private Sub frmMstKegiatanTipe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        STATE = "EDIT"
        prn = getParent(Me)
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='SPK'", sqlconn))
        da1.Fill(ds1, "jnsKegiatan")
        da1 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_Jenis_Barang where Rec_Stat='Y'", sqlconn))
        da1.Fill(ds1, "jnsKegiatanSPK")
        da2 = New SqlDataAdapter(New SqlCommand("select distinct Kode_Tipe, Nama_Tipe  from SIF.dbo.SIF_tipe union Select '%%', 'ALL' ", sqlconn))
        da2.Fill(ds2, "tipe")
        da10 = New SqlDataAdapter(New SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe from SIF.dbo.SIF_sub_tipe union Select '%%', 'ALL' ", sqlconn))
        da10.Fill(ds10, "subtipe")
        da3 = New SqlDataAdapter(New SqlCommand("select Kode_Ukuran, Nama_Ukuran from SIF.dbo.SIF_ukuran union Select '%%', 'ALL' ", sqlconn))
        da3.Fill(ds3, "ukuran")
        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod where kd_kegiatan=' " & txtKegiatan.EditValue & "' and jns_kegiatan ='" & txtkegiatanppic.EditValue & "'", sqlconn))
        da4.Fill(ds4, "kegiatan")
        da8 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTPPIC'", sqlconn))
        da8.Fill(ds8, "jnskegiatanppic")

        gControl.DataSource = ds4.Tables("kegiatan")

        txtKegiatan.Properties.DataSource = ds1.Tables("jnsKegiatan")
        txtKegiatan.Properties.ValueMember = "Id_Data"
        txtKegiatan.Properties.DisplayMember = "Desc_Data"

        txtkegiatanppic.Properties.DataSource = ds8.Tables("jnskegiatanppic")
        txtkegiatanppic.Properties.ValueMember = "Id_Data"
        txtkegiatanppic.Properties.DisplayMember = "Desc_Data"

        RepLE_SPK.DataSource = ds1.Tables("jnsKegiatanSPK")
        RepLE_SPK.ValueMember = "Kd_Jns_Brg"
        RepLE_SPK.DisplayMember = "Nama_Jenis"

        kkd_tipe.DataSource = ds2.Tables("tipe")
        kkd_tipe.ValueMember = "Kode_Tipe"
        kkd_tipe.DisplayMember = "Nama_Tipe"

        kkd_subtipe.DataSource = ds10.Tables("subtipe")
        kkd_subtipe.ValueMember = "Kd_Sub_Tipe"
        kkd_subtipe.DisplayMember = "Nama_Sub_Tipe"

        kdukuran.DataSource = ds3.Tables("ukuran")
        kdukuran.ValueMember = "Kode_Ukuran"
        kdukuran.DisplayMember = "Nama_Ukuran"

        ' gView.Columns(0).ColumnEdit = RepLE_SPK
        gView.Columns(1).ColumnEdit = kkd_tipe
        gView.Columns(2).ColumnEdit = kkd_subtipe
        gView.Columns(3).ColumnEdit = kdukuran
        gView.Columns(6).ColumnEdit = ckStatus

        gView.OptionsView.NewItemRowPosition = 0
    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged
        If e.Column.ToString = "Kode Tipe" Then
            If Not ds10.Tables("subtipe") Is Nothing Then ds10.Tables("subtipe").Clear()
            da10 = New SqlDataAdapter(New SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe from SIF.dbo.SIF_sub_tipe where Kd_Tipe='" & e.Value.ToString & "' union Select '%%', 'ALL' ", sqlconn))
            da10.Fill(ds10, "subtipe")

            kkd_subtipe.DataSource = ds10.Tables("subtipe")
            kkd_subtipe.ValueMember = "Kd_Sub_Tipe"
            kkd_subtipe.DisplayMember = "Nama_Sub_Tipe"
        ElseIf e.Column.ToString = "Kode Sub Tipe" Then
            If Not ds10.Tables("subtipe") Is Nothing Then ds10.Tables("subtipe").Clear()
            da10 = New SqlDataAdapter(New SqlCommand("select Kd_Sub_Tipe, Nama_Sub_Tipe from SIF.dbo.SIF_sub_tipe union Select '%%', 'ALL' ", sqlconn))
            da10.Fill(ds10, "subtipe")

            kkd_subtipe.DataSource = ds10.Tables("subtipe")
            kkd_subtipe.ValueMember = "Kd_Sub_Tipe"
            kkd_subtipe.DisplayMember = "Nama_Sub_Tipe"


        End If
    End Sub
    
    Private Sub gView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        If STATE = "ADD" Then
            Dim isValid As Boolean = True

            Dim rw() As DataRow = ds4.Tables("kegiatan").Select("kd_tipe = '" & e.Row.item("kd_tipe") & "' and kd_ukuran= '" & e.Row.item("kd_ukuran") & "' and kd_jenis= '" & e.Row.item("kd_jenis") & "' and kd_subtipe= '" & e.Row.item("kd_subtipe") & "' and nilai_konv= " & e.Row.item("nilai_konv") & " ")

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
                Dim z As Object
                y = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                y.SetColumnError(kd_subtipe, "Sub Tipe sudah ada dalam daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Sub Tipe sudah ada dalam daftar.")


            End If

            If e.Row.item("kd_tipe").ToString = "" Then
                isValid = False
                Dim k As Object

                k = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                k.SetColumnError(kd_tipe, "Tipe tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Tipe tidak boleh kosong.")
            End If

            If e.Row.item("kd_subtipe").ToString = "" Then
                isValid = False
                Dim k As Object

                k = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                k.SetColumnError(kd_tipe, "Sub Tipe tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Sub Tipe tidak boleh kosong.")
            End If

            If e.Row.item("kd_ukuran").ToString = "" Then
                isValid = False
                Dim l As Object

                l = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                l.SetColumnError(kd_ukuran, "Ukuran tidak boleh kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Ukuran tidak boleh kosong.")

            End If

            If e.Row.item("nilai_konv").ToString = "" Then
                isValid = False
                Dim j As Object
                j = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

                j.SetColumnError(nilai_konv, "Kolom Nilai harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If


            e.Valid = isValid
        End If
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

    Public Sub save_click()

        If txtKegiatan.EditValue <> "" Or txtkegiatanppic.EditValue <> "" Then
            Try
                For Each rows As DataRow In ds4.Tables("kegiatan").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("kd_kegiatan") = txtKegiatan.EditValue
                        rows.Item("jns_kegiatan") = txtkegiatanppic.EditValue

                    End If
                Next

                gControl.DataSource = ds4.Tables("kegiatan")
                Dim mybuilder As New SqlCommandBuilder(da4)
                da4.UpdateCommand = mybuilder.GetUpdateCommand
                da4.Update(ds4.Tables("kegiatan"))
                ds4.Tables("kegiatan").AcceptChanges()
                showMessages("Saved..")

                ds4.Clear()
                ds4.Reset()
                da4.Fill(ds4, "kegiatan")
                cancel_click()

                STATE = ""
            Catch err As Exception
                MessageBox.Show(err.Message, "Gagal Simpan")
            End Try
            txtKegiatan.EditValue = Nothing
            txtkegiatanppic.EditValue = Nothing
            txtKegiatan.Properties.NullText = "[Pilih Jenis Kegiatan]"
            txtkegiatanppic.Properties.NullText = "[Pilih Jenis Kegiatan PPIC]"
        Else
            MessageBox.Show("Pilih Kegiatan atau Jenis Kegiatan Terlebih Dahulu!")
        End If
    End Sub
    Public Sub edit_click()
        gView.OptionsView.NewItemRowPosition = 0
        STATE = "EDIT"
        If STATE = "EDIT" Then
            'sqlq = " select grd.id_data as [KODE] , grd.desc_data as [KEGIATAN],ppic.Id_Data as [kode_PPIC], ppic.Desc_Data as [PPIC] ,st.Nama_Tipe as [TIPE],u.Nama_Ukuran as [UKURAN] " & _
            '        " from SIF.dbo.SIF_konv_prod kp,SIF.dbo.SIF_tipe st,SIF.dbo.SIF_ukuran u, " & _
            '        " (select id_data as id_data , desc_data as desc_data from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK') grd,(select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTPPIC') ppic " & _
            '        " where(kp.kd_kegiatan = grd.id_data  " & _
            '        " and kp.jns_kegiatan = ppic.Id_Data " & _
            '        " And kp.kd_tipe = st.Kode_Tipe) " & _
            '        " and kp.kd_ukuran = u.Kode_Ukuran "

            'da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sqlq, sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            'If Not ds6.Tables("lookup_so") Is Nothing Then ds6.Tables("lookup_so").Clear()
            'da6.Fill(ds6, "lookup_so")
            'frmCari.set_dso(ds6.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
            'frmCari.ShowDialog() '<-- menampilkan form LOV
            'If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            '    da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_konv_prod where kd_kegiatan='" & frmCari.row("KODE") & "' and jns_kegiatan ='" & frmCari.row("kode_PPIC") & "'", sqlconn)) '<- query buat ditampilkan di LOV
            '    da7.Fill(ds7, "kegiatan2")
            '    gControl.DataSource = ds7.Tables("kegiatan2")
            '    txtKegiatan.EditValue = frmCari.row("KODE")
            '    txtkegiatanppic.EditValue = frmCari.row("kode_PPIC")
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If


    End Sub
    Public Sub delete_click()
        If gView.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                gView.DeleteSelectedRows()

                Dim mybuilder As New SqlCommandBuilder(da4)
                da4.UpdateCommand = mybuilder.GetUpdateCommand
                da4.Update(ds4.Tables("kegiatan"))
                ds4.Tables("kegiatan").AcceptChanges()
                showMessages("Saved..")

                ds4.Clear()
                ds4.Reset()
                da4.Fill(ds4, "kegiatan")
                gControl.DataSource = ds4.Tables("kegiatan")
            End If
        End If
    End Sub

    Private Sub txtKegiatan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKegiatan.EditValueChanged
        If STATE = "ADD" Then
            gView.OptionsView.NewItemRowPosition = 1

            If txtkegiatanppic.EditValue <> "" Then

                da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod where kd_kegiatan='" & txtKegiatan.EditValue & "' and jns_kegiatan ='" & txtkegiatanppic.EditValue & "'", sqlconn))
                'da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod ", sqlconn))
                ds4.Clear()
                ds4.Reset()
                da4.Fill(ds4, "kegiatan")
                gControl.DataSource = ds4.Tables("kegiatan")

            End If
        ElseIf STATE = "EDIT" Then
            gView.OptionsView.NewItemRowPosition = 0
            If txtkegiatanppic.EditValue <> "" Then

                da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod where kd_kegiatan='" & txtKegiatan.EditValue & "' and jns_kegiatan ='" & txtkegiatanppic.EditValue & "'", sqlconn))
                'da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod ", sqlconn))
                ds4.Clear()
                ds4.Reset()
                da4.Fill(ds4, "kegiatan")
                gControl.DataSource = ds4.Tables("kegiatan")

            End If
        End If
    End Sub

    Private Sub txtkegiatanppic_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkegiatanppic.EditValueChanged
        If STATE = "ADD" Then
            gView.OptionsView.NewItemRowPosition = 1
        Else
            
            If txtKegiatan.EditValue <> "" Then
                da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod where kd_kegiatan='" & txtKegiatan.EditValue & "' and jns_kegiatan ='" & txtkegiatanppic.EditValue & "'", sqlconn))
                ds4.Clear()
                ds4.Reset()
                da4.Fill(ds4, "kegiatan")
                gControl.DataSource = ds4.Tables("kegiatan")

            End If
        End If
        

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        da4 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_konv_prod ", sqlconn))
        ds4.Clear()
        ds4.Reset()
        da4.Fill(ds4, "kegiatan")
        gControl.DataSource = ds4.Tables("kegiatan")
        txtKegiatan.EditValue = Nothing
        txtkegiatanppic.EditValue = Nothing
        txtKegiatan.Properties.NullText = "[Pilih Jenis Kegiatan]"
        txtkegiatanppic.Properties.NullText = "[Pilih Jenis Kegiatan PPIC]"

    End Sub

    
    Public Sub cetak_click()
        If (txtKegiatan.EditValue = Nothing Or txtKegiatan.EditValue = "") And (txtkegiatanppic.EditValue = Nothing Or txtkegiatanppic.EditValue = "") Then
            'MsgBox("T1 = " + txtKegiatan.EditValue + " T2 = " + txtkegiatanppic.EditValue)
            callReport(App_Path() & "\RptIndexKegiatan2.rpt", "", "pkegiatan=*&pppic=*", "SIF")
            'callReport(App_Path() & "\RptIndexKegiatan.rpt", "", "", "SIF")
        Else

            callReport(App_Path() & "\RptIndexKegiatan2.rpt", "", "pkegiatan=" & txtKegiatan.EditValue & "&pppic=" & txtkegiatanppic.EditValue, "SIF")

        End If

        'callReport(App_Path() & "\RptIndexKegiatan.rpt", "", "pkegiatan=" & txtKegiatan.EditValue & "&pppic=" & txtkegiatanppic.EditValue, "SIF")
    End Sub


End Class