'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmInvBKI
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
    End Sub
    Public Sub edit_klik()

    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        Buildernya = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Buildernya.GetUpdateCommand()
        DA.InsertCommand = Buildernya.GetInsertCommand()
        DA.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(DA2)
        DA2.UpdateCommand = Buildernya.GetUpdateCommand()
        DA2.InsertCommand = Buildernya.GetInsertCommand()
        DA2.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS
        DA.DeleteCommand.Transaction = BTRANS

        DA2.UpdateCommand.Transaction = BTRANS
        DA2.InsertCommand.Transaction = BTRANS
        DA2.DeleteCommand.Transaction = BTRANS

        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bki").NewRow
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bki").Rows(0)
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = "1" ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("no_trans") = nomergen(BTRANS)
        row.Item("tipe_trans") = "JPH-MUT-01"
        row.Item("tgl_trans") = dtpTglSJ.Text
        'row.Item("no_spm") = LookupSPM.Text
        row.Item("kd_gudang") = LookupGudang.EditValue
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("Program_Name") = Me.Name
        txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bki").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bki_d").Rows
            If row1.RowState = DataRowState.Added Then
                row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = row.Item("tipe_trans")
                row1.Item("Last_Create_Date") = Now
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = "1"
            Else
                row1.Item("Last_Update_Date") = Now
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

        Next

        Try

            DA.Update(dSO.Tables("_bki"))
            DA2.Update(dSO1.Tables("_bki_d"))

            dSO.Tables("_bki").AcceptChanges()
            dSO1.Tables("_bki_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bki").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub hapus_record()

    End Sub


    Private Sub frmInvBKI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()
        
        prn = getParent(Me)
        btnhide()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'btnSimpan.Hide()
        'btnExit.Hide()

        LoadStruktur("xxxx")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepLookupBarang.DataSource = ds_cari.Tables("_lookup1")
        RepLookupBarang.ValueMember = "Kode_Barang"
        RepLookupBarang.DisplayMember = "Nama_Barang"


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup2")
        LookupGudang.Properties.ValueMember = "Kode_Gudang"
        LookupGudang.Properties.DisplayMember = "Nama_Gudang"
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bki") Is Nothing Then dSO.Tables("_bki").Clear()
        If Not dSO1.Tables("_bkid") Is Nothing Then dSO1.Tables("_bkid").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bki")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bkid")
        GcBKI_d.DataSource = dSO1.Tables("_bkid")

        If dSO.Tables("_bki").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bki").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub

    Private Sub TxbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim x As Int16 = 1
            Dim sqlread As SqlDataReader = New SqlCommand("select Kode_Barang,Kd_Satuan,0 as qty_in from SIF.dbo.SIF_Barang where Kode_Barang='" & TxbBarcode.Text & "'", sqlconn).ExecuteReader

            If sqlread.Read Then
                Dim dtrow() As DataRow = dSO1.Tables("_bkid").Select("kd_stok='" & TxbBarcode.Text & "'")
                'lblNmBrg.ForeColor = Color.Yellow
                'lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()

                Dim rw As DataRow = dSO1.Tables("_bkid").NewRow
                'rw.Item("no_seq") = x : x += 1
                rw.Item("kd_stok") = sqlread.Item("Kode_Barang")
                'rw.Item("nama_barang") = sqlread.Item("Nama_Barang")
                rw.Item("kd_satuan") = sqlread.Item("Kd_Satuan")
                rw.Item("qty_in") = sqlread.Item("qty_in") + 1
                dSO1.Tables("_bkid").Rows.Add(rw)

                'BindingContext(GcBKI_d.DataSource).Position = getPosisi(rw(i))
                'tunda()
                TxbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbBarcode.Focus()
                sqlread.Close()
                'Next
            End If
        End If
    End Sub



    Public Function nomergen(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(no_trans,'x1'),4,10) as numeric)) from INV.dbo.INV_GUDANG_OUT", sqlconn, bgtrans).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "BMI000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "BMI" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        enabel()
        btnHapus.Enabled = True
        btnSimpan.Enabled = True
        STATE = "EDIT"
        'GvBKI_d.Columns("no_seq").Visible = True
        edit_klik()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
        btnstart()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
        btnstart()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
        btnstart()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Private Sub GvBKI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBKI_d.CellValueChanged
    '    If e.Column Is qty_out Then
    '        GvBKI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBKI_d.GetRow(e.RowHandle).item("qty_ord").ToString - GvBKI_d.GetRow(e.RowHandle).item("qty_out").ToString
    '    End If
    'End Sub



    Public Sub bersihkan()
        txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        dtpTglSJ.Text = ""
        'LookupSPM.EditValue = vbNullString
        LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        'txbNmTrima.Enabled = True
        dtpTglSJ.Enabled = True
        LookupGudang.Enabled = True
        'LookupSPM.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Public Sub disabel()
        txbNoTrans.Enabled = False
        'txbNmTrima.Enabled = False
        LookupGudang.Enabled = False
        dtpTglSJ.Enabled = False
        'LookupSPM.Enabled = False
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        bersihkan()
        enabel()
        btnUbah.Enabled = False
        btnSimpan.Enabled = True
        STATE = "ADD"
        GvBKI_d.Columns("no_seq").Visible = False
    End Sub

    Private Sub btnhide()
        btnTambah.Hide()
        btnUbah.Hide()
        btnSimpan.Hide()
        btnHapus.Hide()
        btnExit.Hide()
        btnBatal.Hide()
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(700)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_bmid").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function

    Private Sub GvBKI_d_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvBKI_d.InitNewRow
        GvBKI_d.GetRow(e.RowHandle).item("no_seq") = GvBKI_d.RowCount + 1
    End Sub
End Class