Imports System.Data.SqlClient
Public Class frmMstHPPBahan
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim tmpRev As Integer
    Dim mb As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnAdd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub frmMstHPPBahan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)


        State = "ADD"
        da1 = New SqlDataAdapter(New SqlCommand("select kd_bom, nama_bom from SIF.dbo.SIF_bom order by nama_bom", sqlconn))
        da1.Fill(ds1, "jnsBOM")
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang, kd_jenis from SIF.dbo.SIF_Barang order by Nama_Barang", sqlconn))
        da1.Fill(ds1, "jnsBrg")
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Satuan, Nama_Satuan from SIF.dbo.SIF_Satuan order by Nama_Satuan", sqlconn))
        da1.Fill(ds1, "jnsSatuan")
        txtBOM.Properties.DataSource = ds1.Tables("jnsBOM")
        txtBarang.DataSource = ds1.Tables("jnsBrg")
        txtSatuan.DataSource = ds1.Tables("jnsSatuan")
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_bahan where 1=0", sqlconn))
        da3.Fill(ds3, "dtlBOM")
        gControl.DataSource = ds3.Tables("dtlBOM")
        AddHandler ds3.Tables("dtlBOM").RowDeleted, AddressOf refreshNomer

        '-------------relation
        'da1 = New SqlDataAdapter(New SqlCommand("select d.*, 0 nilai, b.Nama_Barang, b.Kd_Satuan from SIF.dbo.SIF_bom_d d left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang where 1=0", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select d.*,b.Nama_Barang, b.Kd_Satuan from PROD.dbo.PROD_hpp_bahan d left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang where 1=0", sqlconn))
        da1.Fill(ds3, "dtlBOMChild")
        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim rel As DataRelation

        colM(0) = ds3.Tables("dtlBOM").Columns("kd_barang")

        colD(0) = ds3.Tables("dtlBOMChild").Columns("kd_bom")

        rel = ds3.Relations.Add("DETAIL BOM", colM, colD, False)
        gControl.LevelTree.Nodes.Add("DETAIL BOM", gChild)

    End Sub
    Private Sub txtBOM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBOM.EditValueChanged
        Dim row As DataRow

        If State = "ADD" Then
            'gView.OptionsView.NewItemRowPosition = 1
            If Not ds2.Tables("BOM") Is Nothing Then ds2.Tables("BOM").Clear()
            If Not ds3.Tables("dtlBOM") Is Nothing Then ds3.Tables("dtlBOM").Clear()
            If Not ds3.Tables("dtlBOMChild") Is Nothing Then ds3.Tables("dtlBOMChild").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_m where kd_bom='" & txtBOM.EditValue & "' and revisi = (select max(revisi) from PROD.dbo.PROD_hpp_m where kd_bom='" & txtBOM.EditValue & "')", sqlconn))
            da2.Fill(ds2, "BOM")
            
            If ds2.Tables("BOM").Rows.Count > 0 Then
                row = ds2.Tables("BOM").Rows(0)
                txtRevisi.Text = row.Item("revisi") + 1
            Else
                txtRevisi.Text = 0
            End If
            tmpRev = txtRevisi.Text
            'da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom_d where kd_bom='" & txtBOM.EditValue & "' order by no_urut", sqlconn))
            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_bahan where 1=0", sqlconn))
            da3.Fill(ds3, "dtlBOM")
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_bom_d where kd_bom='" & txtBOM.EditValue & "' order by no_urut", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds3.Tables("dtlBOM").NewRow
                rw("no_urut") = dr.Item("no_urut")
                rw("kd_bom") = dr.Item("kd_bom")
                rw("kd_barang") = dr.Item("kd_barang")
                rw("jumlah") = dr.Item("jumlah")
                rw("satuan") = dr.Item("satuan")
                

                ds3.Tables("dtlBOM").Rows.Add(rw)
            End While
            dr.Close()


            'da1 = New SqlDataAdapter(New SqlCommand("select d.*, 0 nilai, b.Nama_Barang, b.Kd_Satuan from SIF.dbo.SIF_bom_d d left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang", sqlconn))
            da1 = New SqlDataAdapter(New SqlCommand("select d.*,b.Nama_Barang, b.Kd_Satuan from PROD.dbo.PROD_hpp_bahan d left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang where 1=0", sqlconn))
            da1.Fill(ds3, "dtlBOMChild")
            For i = 0 To ds3.Tables("dtlBOM").Rows.Count - 1
                Dim kdbom As String = ds3.Tables("dtlBOM").Rows(i).Item("kd_barang").ToString
                Dim nourut As String = ds3.Tables("dtlBOM").Rows(i).Item("no_urut").ToString
                dr = New SqlClient.SqlCommand("select d.*, b.Nama_Barang from SIF.dbo.SIF_bom_d d left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang  where d.kd_bom='" & kdbom & "'  ", sqlconn).ExecuteReader
                While dr.Read
                    Dim rw As DataRow = ds3.Tables("dtlBOMChild").NewRow
                    rw("no_urut") = nourut & "." & dr.Item("no_urut")
                    rw("kd_bom") = dr.Item("kd_bom")
                    rw("kd_barang") = dr.Item("kd_barang")
                    rw("Nama_Barang") = dr.Item("Nama_Barang")
                    rw("jumlah") = dr.Item("jumlah")
                    rw("satuan") = dr.Item("satuan")


                    ds3.Tables("dtlBOMChild").Rows.Add(rw)
                End While
                dr.Close()
            Next
            'gView.RefreshData()


            gControl.DataSource = ds3.Tables("dtlBOM")
        End If


    End Sub

    Private Sub gView_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gView.InitNewRow
        gView.GetRow(e.RowHandle).item("rec_stat") = "Y"
        gView.GetRow(e.RowHandle).item("no_urut") = gView.RowCount + 1
    End Sub

    Private Sub gView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gView.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gView.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
                    gView.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("no_urut") = i
                i += 1
            End If

        Next

    End Sub

    Private Sub gView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Jumlah").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmJumlah, "Kolom Jumlah harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If e.Row.item("nilai_biaya").ToString = "" Then
            isValid = False
            gView.SetColumnError(clmNilai, "Kolom Nilai harus diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        e.Valid = isValid
    End Sub

    Private Sub gView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gView.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Public Sub add_click()
        txtRevisi.ReadOnly = False
        txtRevisi.BackColor = Color.White
        txtBOM.Properties.ReadOnly = False

        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        State = "EDIT"

        Dim qstr As String = "select DISTINCT(P.kd_bom) as KODE, S.nama_bom as NAMA, P.revisi as REVISI, P.last_update_date as [LAST UPDATE] " & _
                "from PROD.dbo.prod_hpp_m as P " & _
                "left join SIF.dbo.SIF_bom as S " & _
                "on P.kd_bom = S.kd_bom " & _
                "order by KODE, REVISI "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            gView.OptionsView.NewItemRowPosition = 1

            If Not ds2.Tables("BOM") Is Nothing Then ds2.Tables("BOM").Clear()
            If Not ds3.Tables("dtlBOM") Is Nothing Then ds3.Tables("dtlBOM").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_m where kd_bom='" & frmCari.row("KODE") & "' and revisi = '" & frmCari.row("Revisi") & "'", sqlconn))
            da2.Fill(ds2, "BOM")
            

            row = ds2.Tables("BOM").Rows(0)
            txtBOM.EditValue = row.Item("kd_bom").ToString
            txtNoDokBOM.Text = row.Item("no_dokumen").ToString
            txtKetBOM.Text = row.Item("keterangan").ToString
            txtRevisi.Text = row.Item("revisi").ToString
            txtRevisi.ReadOnly = True
            txtRevisi.BackColor = Color.Pink
            txtBOM.Properties.ReadOnly = True
            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_bahan where kd_bom='" & txtBOM.EditValue & "' and revisi = " & txtRevisi.Text & " order by no_urut", sqlconn))
            da3.Fill(ds3, "dtlBOM")
            gControl.DataSource = ds3.Tables("dtlBOM")

            tmpRev = frmCari.row("REVISI")

            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If
    End Sub

    Public Sub save_click()
        Dim row As DataRow

        If txtBOM.EditValue <> "" Then
            If txtNoDokBOM.Text = "" Then
                MessageBox.Show("No Dokumen BOM Belum Diisi")
                txtNoDokBOM.Focus()
                Exit Sub
            End If
            If txtRevisi.Text = "" And IsNumeric(txtRevisi.Text) Then
                MessageBox.Show("No Revisi Belum Diisi")
                txtRevisi.Focus()
                Exit Sub
            End If

            If State = "ADD" Then
                If txtRevisi.Text <> tmpRev Then '<< cek kl noRev diubah dan apakah sudah ada di DB
                    da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_m where kd_bom='" & txtBOM.EditValue & "' and revisi = '" & txtRevisi.Text & "'", sqlconn))
                    da1.Fill(ds1, "tmpBOM")
                    If ds1.Tables("tmpBOM").Rows.Count > 0 Then
                        MessageBox.Show("No Revisi sudah ada!")
                        txtRevisi.Text = tmpRev
                        txtRevisi.Focus()
                        Exit Sub
                    End If
                End If
            ElseIf State = "EDIT" Then
                If txtRevisi.Text <> tmpRev Then
                    da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_hpp_m where kd_bom='" & txtBOM.EditValue & "' and revisi = '" & txtRevisi.Text & "'", sqlconn))
                    da1.Fill(ds1, "tmpBOM")
                    If ds1.Tables("tmpBOM").Rows.Count > 0 Then
                        MessageBox.Show("No Revisi sudah ada!")
                        txtRevisi.Text = tmpRev
                        txtRevisi.Focus()
                        Exit Sub
                    End If
                End If
            End If

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            If State = "ADD" Then
                row = ds2.Tables("BOM").NewRow
            ElseIf State = "EDIT" Then
                row = ds2.Tables("BOM").Rows(0)
            End If
            row.Item("kd_bom") = txtBOM.GetColumnValue("kd_bom")

            row.Item("no_dokumen") = txtNoDokBOM.Text
            row.Item("keterangan") = txtKetBOM.Text
            row.Item("revisi") = txtRevisi.Text
            row.Item("rec_stat") = "Y"
            row.Item("last_update_date") = Now
            row.Item("last_updated_by") = username

            If State = "ADD" Then
                row.Item("last_create_date") = Now
                row.Item("last_created_by") = username
                ds2.Tables("BOM").Rows.Add(row)
            End If

            For Each rows As DataRow In ds3.Tables("dtlBOM").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_bom") = txtBOM.EditValue
                    rows.Item("revisi") = txtRevisi.Text
                    row.Item("last_create_date") = Now
                    row.Item("last_created_by") = username
                End If
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Item("last_update_date") = Now
                    rows.Item("last_updated_by") = username
                    'rows.Item("Programe_name") = Me.Name
                End If
            Next

            Try

                da2.Update(ds2.Tables("BOM"))
                ds2.Tables("BOM").AcceptChanges()

                da3.Update(ds3.Tables("dtlBOM"))
                ds3.Tables("dtlBOM").AcceptChanges()

                txtRevisi.ReadOnly = True
                txtRevisi.BackColor = Color.Pink
                txtBOM.Properties.ReadOnly = True
                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                State = "EDIT"
            Catch e As Exception
                BTRANS.Rollback()
                ds2.Tables("BOM").RejectChanges()
                ds3.Tables("dtlBOM").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                If State = "ADD" Then
                    txtNoDokBOM.Text = ""
                    txtKetBOM.Text = ""
                    txtRevisi.Text = tmpRev
                    txtRevisi.ReadOnly = False
                    txtRevisi.BackColor = Color.White
                    txtBOM.Properties.ReadOnly = False
                    If Not ds2.Tables("BOM") Is Nothing Then ds2.Tables("BOM").Clear()
                    If Not ds3.Tables("dtlBOM") Is Nothing Then ds3.Tables("dtlBOM").Clear()
                End If
            End Try

        Else
            MessageBox.Show("Pilih Jenis Bill Of Material Terlebih Dahulu!")
        End If

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            ds2.Tables("BOM").Rows(0).Delete()
            Dim mybuilder As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder.GetUpdateCommand
            da2.Update(ds2.Tables("BOM"))
            ds2.Tables("BOM").AcceptChanges()
            If Not ds2.Tables("BOM") Is Nothing Then ds2.Tables("BOM").Clear()

            For Each dr As DataRow In ds3.Tables("dtlBOM").Rows
                dr.Delete()
            Next
            Dim mybuilder2 As New SqlCommandBuilder(da3)
            da3.UpdateCommand = mybuilder2.GetUpdateCommand
            da3.Update(ds3.Tables("dtlBOM"))
            ds3.Tables("dtlBOM").AcceptChanges()

            showMessages("Data Berhasil Dihapus")
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        
        txtNoDokBOM.Text = ""
        txtKetBOM.Text = ""
        txtRevisi.Text = ""
        txtBOM.EditValue = vbNullString
        If Not ds2.Tables("BOM") Is Nothing Then ds2.Tables("BOM").Clear()
        If Not ds3.Tables("dtlBOM") Is Nothing Then ds3.Tables("dtlBOM").Clear()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    
End Class