Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOBUSAKASUR
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAP As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DADD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()


        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan as total,0 as state, '' as Nama_Barang from Sales.dbo.SALES_SO_D where kd_parent is null and No_sp='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SOD")
        DADD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan as total,0 as state, (select nama_barang from sif.dbo.sif_barang where Kode_Barang=Kd_Stok) as Nama_Barang  from Sales.dbo.SALES_SO_D where not kd_parent is null and No_sp='" & kode & "'", sqlconn))
        DADD.Fill(dsete, "SODD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DAP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 'test 123' as DetailPromo  from Sales.dbo.SALES_SO_D_PROMO where No_sp='" & kode & "'", sqlconn))
        DAP.Fill(dsete, "SOP")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            txtCustomer.EditValue = row.Item("Kd_Customer").ToString
            txtNamaPnrm.Text = row.Item("Nama_pnrm").ToString
            txtAlamatKirim.Text = row.Item("Almt_pnrm").ToString
            tglKirim.EditValue = row.Item("Tgl_Kirim")
            txtSales.EditValue = row.Item("Kd_sales").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            txtNomor.Text = row.Item("No_sp").ToString
            If InStr(txtNomor.Text, "1-", CompareMethod.Text) > 0 Then
                ckPPN.Checked = True
            Else
                ckPPN.Checked = False
            End If
        Else
            txtCustomer.EditValue = vbNullString
            txtSales.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglKirim.EditValue = vbNullString
            tglSO.Text = vbNullString
        End If

    End Sub

    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1, CreditLimit from SIF.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales ", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar ,h.Harga_Rupiah, b.Kode_Barang , '0' as isset from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h where b.Kd_Depart=3 and b.kd_jns_persd=1 and kd_jenis <> '102' and b.Kode_Barang=h.Kode_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")

        reload_table("XXX")

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kd_Customer"

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        repbarang.DataSource = dsete.Tables("VBARANG")
        GC.DataSource = dsete.Tables("SOD")

        Dim rl, r2 As DataRelation
        Dim dcolP(2) As DataColumn
        Dim dcolP2(1) As DataColumn
        Dim dcolC(2) As DataColumn
        Dim dColPROMO(1) As DataColumn

        dcolP(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP(2) = dsete.Tables("SOD").Columns("No_Seq")

        dcolC(0) = dsete.Tables("SODD").Columns("kd_parent")
        dcolC(1) = dsete.Tables("SODD").Columns("No_sp")
        dcolC(2) = dsete.Tables("SODD").Columns("No")

        dcolP2(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP2(1) = dsete.Tables("SOD").Columns("No_sp")

        dColPROMO(0) = dsete.Tables("SOP").Columns("KD_STOK")
        dColPROMO(1) = dsete.Tables("SOP").Columns("NO_SP")

        '        rl = dsete.Relations.Add("DAD_DSERVICE", dcolP, dcolC, False)
        '       rl.Nested = True
        '      GC.LevelTree.Nodes.Add("DAD_DSERVICE", GVD)

        r2 = dsete.Relations.Add("DAP_DSERVICE", dcolP2, dColPROMO, False)
        r2.Nested = True
        GC.LevelTree.Nodes.Add("DAP_DSERVICE", GVP)

        State = "ADD"
        tglSO.Text = Now
        prn = getParent(Me)
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In dsete.Tables("SODD").Select("NO=" & rw.Item("No_seq"))

                    rwd("NO") = i
                    rwd("No_seq") = i & "." & j
                    j += 1
                Next
                j = 1
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        txtAlamat.Text = sender.editvalue
        If sender.editvalue <> vbNullString Then
            txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
            txtCR.Text = CType(txtCustomer.Properties.GetDataSourceValue("CreditLimit", txtCustomer.ItemIndex).ToString(), Int64)
            txtCR.Text = FormatCurrency(txtCR.Text, 2)
        Else
            txtAlamatKirim.Text = ""
        End If
    End Sub
    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        txtNamaSales.Text = sender.editvalue
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim data As SqlDataReader
        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                showMessages("Nama Customer Belum Diisi")
                txtCustomer.Focus()
                Exit Sub
            End If

            If txtSales.EditValue = "" Then
                showMessages("Nama Sales Belum Diisi")
                txtSales.Focus()
                Exit Sub
            End If

            If tglKirim.Text = "" Then
                showMessages("Tanggal Kirim Belum Diisi")
                tglKirim.Focus()
                Exit Sub
            End If
            If GV.RowCount = 0 Then
                showMessages("Daftar Barang Masih Kosong")
                GV.Focus()
                Exit Sub
            End If
        End If
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DAD)
        DAD.UpdateCommand = myBuilder.GetUpdateCommand()
        DAD.InsertCommand = myBuilder.GetInsertCommand()
        DAD.DeleteCommand = myBuilder.GetDeleteCommand()

        myBuilder = New SqlClient.SqlCommandBuilder(DADD)
        DADD.UpdateCommand = myBuilder.GetUpdateCommand()
        DADD.InsertCommand = myBuilder.GetInsertCommand()
        DADD.DeleteCommand = myBuilder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DAD.UpdateCommand.Transaction = BTRANS
        DAD.InsertCommand.Transaction = BTRANS
        DAD.DeleteCommand.Transaction = BTRANS

        DADD.UpdateCommand.Transaction = BTRANS
        DADD.InsertCommand.Transaction = BTRANS
        DADD.DeleteCommand.Transaction = BTRANS

        If Not isDelete Then
            If State = "ADD" Then
                data = New SqlCommand("select SALES.dbo.nomor(NULL, '/SKB/','" + IIf(ckPPN.CheckState, "1-", "0-") + "') ", sqlconn, BTRANS).ExecuteReader
                data.Read()
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                txtNomor.Text = data.GetString(0)
                data.Close()
            ElseIf State = "EDIT" Then
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

            row.Item("No_sp") = txtNomor.Text
            row.Item("Tipe_trans") = "SPON"
            row.Item("Tgl_sp") = Now
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Nama_pnrm") = txtNamaPnrm.Text
            row.Item("Almt_pnrm") = txtAlamatKirim.Text
            row.Item("Tgl_Kirim") = tglKirim.EditValue.ToString
            row.Item("Kd_sales") = txtSales.EditValue
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Flag_Ppn") = "Y"
            row.Item("PPn") = "0"
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = "2"
            row.Item("Status") = "OK"
            row.Item("Program_Name") = Me.Name

            If State = "ADD" Then
                dsete.Tables("SO").Rows.Add(row)
            End If
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = "1"
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = "SPRING"
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = "2"
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                    rows.Item("qty_prod") = 0
                    rows.Item("qty_kirim") = 0
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                End If

            Next
            For Each rows As DataRow In dsete.Tables("SODD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = "1"
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = "SPRING"
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = "2"
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If

            Next
        End If
        Try

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DADD.Update(dsete.Tables("SODD"))

            dsete.Tables("SO").AcceptChanges()
            dsete.Tables("SOD").AcceptChanges()
            dsete.Tables("SODD").AcceptChanges()
            State = "EDIT"
            BTRANS.Commit()
            showMessages("Saved..")
            frmSOGetPromo.NOSO = txtNomor.Text
            frmSOGetPromo.ShowDialog()

        Catch e As Exception
            BTRANS.Rollback()
            dsete.Tables("SO").RejectChanges() ' untuk membatalkan row yg diupdate/insert

            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged

        Dim Total As Double
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
            GV.GetRow(e.RowHandle).item("potongan") = 0

            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")
            If GV.GetRow(e.RowHandle).item("set").ToString = "1" Then
                Exit Sub
            End If

            GV.GetRow(e.RowHandle).item("set") = rw("isset")
            GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
            GV.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Rupiah").ToString = "", 0, rw("Harga_Rupiah")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))
            Dim read As SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_Diskon_Kesepakatan where kd_customer='" & txtCustomer.EditValue & "'", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select * from sif.dbo.SIF_Diskon_Reguler", sqlconn).ExecuteReader
                read.Read()
            End If
            If read.HasRows Then
                If read.Item("Diskon1").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                End If
            End If
            read.Close()

        ElseIf e.Column Is Qty Then
            If GV.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga") * e.Value
            Total = GV.GetRow(e.RowHandle).item("total")

            Dim disk1 As Double = 0
            Dim disk2 As Double = 0
            Dim disk3 As Double = 0
            Dim disk4 As Double = 0
            Dim disk5 As Double = 0
            If Total = 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("disc1").ToString <> "" Then
                disk1 = GV.GetRow(e.RowHandle).item("disc1") * Total / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc2").ToString <> "" Then
                disk2 = GV.GetRow(e.RowHandle).item("disc2") * (Total - disk1) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc3").ToString <> "" Then
                disk3 = GV.GetRow(e.RowHandle).item("disc3") * (Total - (disk2 + disk1)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc4").ToString <> "" Then
                disk4 = GV.GetRow(e.RowHandle).item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc5").ToString <> "" Then
                disk5 = GV.GetRow(e.RowHandle).item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
            End If
            GV.GetRow(e.RowHandle).item("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
            GV.GetRow(e.RowHandle).Item("total") = GV.GetRow(e.RowHandle).Item("total") - GV.GetRow(e.RowHandle).Item("potongan")
        ElseIf e.Column Is Sete Then
            ' 
            If GV.GetRow(e.RowHandle).item("Kd_Stok").ToString <> "" Then
                For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & GV.GetRow(e.RowHandle).item("Kd_Stok") & "'")
                    rw.Delete()
                Next
                GV.GetRow(e.RowHandle).item("Kd_Stok") = vbNullString
            End If
        End If
    End Sub
    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If e.Column Is Kd_Stok Then
            If e.RowHandle < 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("Kd_Stok").ToString <> "" Then
                For Each rw In dsete.Tables("SODD").Select("kd_parent='" & GV.GetRow(e.RowHandle).item("Kd_Stok") & "'")
                    rw.Delete()
                Next
            End If
            Exit Sub
        End If
    End Sub
    Private Sub GV_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If txtCustomer.EditValue = "" Then
            GV.CancelUpdateCurrentRow()
            showMessages("Harap Mengisi Daftar Customer Terlebih Dahulu")
            txtCustomer.Focus()
            Exit Sub
        End If
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
        GV.GetRow(e.RowHandle).item("set") = 0
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        'rw.Row.RowState
        If e.Row.row.RowState = DataRowState.Modified Then
            e.Row.row.item("state") = 2
        End If
        Dim hargadtl As Double = 0
        Dim potdtl As Double = 0
        Dim totdtl As Double = 0

        For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & e.Row.item("Kd_Stok") & "'")
            rw.Delete()
        Next

        If e.Row.item("set").ToString = "1" Then
            Dim tbl As SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_set_product_d where kd_set='" & e.Row.row.item("Kd_Stok") & "'", sqlconn).ExecuteReader
            Dim i As Integer = 0
            While tbl.Read
                Dim rws As DataRow = dsete.Tables("SODD").NewRow
                Dim Total As Double
                i += 1
                Dim tbls As SqlDataReader = New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar " & _
                                                           ",h.Harga_Rupiah, b.Kode_Barang , '0' as isset " & _
                                                           "from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h " & _
                                                           " where b.Kode_Barang='" & tbl.Item("KD_STOK") & "' and " & _
                                                           "b.Kode_Barang=h.Kode_Barang", sqlconn).ExecuteReader
                tbls.Read()
                rws.Item("Kd_Stok") = tbl.Item("Kd_Stok")
                rws.Item("kd_parent") = e.Row.item("Kd_Stok")
                rws.Item("No") = e.Row.item("No_seq")
                rws.Item("No_seq") = e.Row.item("No_seq") & "." & i
                rws.Item("Nama_Barang") = tbls.Item("Nama_Barang")
                rws.Item("Kd_Satuan") = tbls.Item("Kd_Satuan")
                rws.Item("Qty") = tbl.Item("Qty") * e.Row.item("Qty")
                rws.Item("harga") = tbls("Harga_Rupiah")
                hargadtl += tbls("Harga_Rupiah")
                rws.Item("total") = IIf(tbls("Harga_Rupiah").ToString = "", 0, tbls("Harga_Rupiah")) * IIf(rws.Item("Qty").ToString = "", 0, rws.Item("Qty"))


                Dim read As SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_Diskon_Kesepakatan where kd_customer='" & txtCustomer.EditValue & "'", sqlconn).ExecuteReader
                read.Read()
                If Not read.HasRows Then
                    read = New SqlCommand("select * from sif.dbo.SIF_Diskon_Reguler", sqlconn).ExecuteReader
                    read.Read()
                End If
                If read.HasRows Then
                    If read.Item("Diskon1").ToString <> "" Then
                        rws.Item("disc1") = read.Item("Diskon1")
                    End If
                    If read.Item("Diskon2").ToString <> "" Then
                        rws.Item("disc2") = read.Item("Diskon2")
                    End If
                    If read.Item("Diskon3").ToString <> "" Then
                        rws.Item("disc3") = read.Item("Diskon3")
                    End If
                    If read.Item("Diskon4").ToString <> "" Then
                        rws.Item("disc4") = read.Item("Diskon4")
                    End If
                    If read.Item("Diskon5").ToString <> "" Then
                        rws.Item("disc5") = read.Item("Diskon5")
                    End If
                End If
                read.Close()

                If rws.Item("total").ToString = "" Then Exit Sub
                Total = rws.Item("total")
                Dim disk1 As Double = 0
                Dim disk2 As Double = 0
                Dim disk3 As Double = 0
                Dim disk4 As Double = 0
                Dim disk5 As Double = 0

                If rws.Item("disc1").ToString <> "" Then
                    disk1 = rws.Item("disc1") * Total / 100
                End If
                If rws.Item("disc2").ToString <> "" Then
                    disk2 = rws.Item("disc2") * (Total - disk1) / 100
                End If
                If rws.Item("disc3").ToString <> "" Then
                    disk3 = rws.Item("disc3") * (Total - (disk2 + disk1)) / 100
                End If
                If rws.Item("disc4").ToString <> "" Then
                    disk4 = rws.Item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
                End If
                If rws.Item("disc5").ToString <> "" Then
                    disk5 = rws.Item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
                End If
                rws.Item("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
                potdtl += rws.Item("potongan")
                rws.Item("total") = rws.Item("total") - rws.Item("potongan")
                totdtl += rws.Item("total")

                dsete.Tables("SODD").Rows.Add(rws)
                tbls.Close()

            End While
            e.Row("harga") = hargadtl
            e.Row("total") = totdtl
            e.Row("potongan") = potdtl
        End If

        If CType(txtCR.Text, Double) < Total.SummaryItem.SummaryValue Then
            lblTotal.ForeColor = Color.Red
        Else
            lblTotal.ForeColor = Color.White
        End If
        lblTotal.Text = FormatCurrency(Total.SummaryItem.SummaryValue, 2)

    End Sub
    Private Sub GV_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn Is Kd_Stok Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            clone.RowFilter = "[isset] = " + row("set").ToString()
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True


        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SOD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV.SetColumnError(Kd_Stok, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid

    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal] from sales.dbo.sales_SO", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
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
            reload_table(frmCari.row(0))
            State = "EDIT"

            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            State = ""
        End If
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
    Public Sub cancel_click()
        reload_table("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        txtCustomer.EditValue = vbNullString
        txtSales.EditValue = vbNullString
        tglKirim.EditValue = vbNullString
        tglSO.Text = Now
        txtCR.Text = ""
        txtAlamatKirim.Text = ""
        txtKeterangan.Text = ""
        txtNamaPnrm.Text = ""
        lblTotal.Text = "0"
        txtNomor.Text = ""
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dsete.Tables("SOD") Is Nothing Then delete(dsete.Tables("SOD").Rows)
            If Not dsete.Tables("SODD") Is Nothing Then delete(dsete.Tables("SODD").Rows)
            If Not dsete.Tables("SODP") Is Nothing Then delete(dsete.Tables("SODP").Rows)
            If Not dsete.Tables("SO") Is Nothing Then delete(dsete.Tables("SO").Rows)

            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub

End Class