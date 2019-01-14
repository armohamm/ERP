'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmInvBMI
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dSO1, dso2, ds_cari, ds_cari1, ds_cari2 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DALOOKUP, DALOOKUP1, DALOOKUP2 As SqlClient.SqlDataAdapter
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
        If dtpTglSJ.Text = vbNullString Or LookupGudang.EditValue = vbNullString Or LookupSPPB.EditValue = vbNullString Then
            MsgBox("Tanggal, Gudang, Kode SPPB")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        bersihkan()
    End Sub
    Public Sub btnstart()
        btnTambah.Enabled = True
        btnUbah.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Public Sub edit_klik()
        enabel()
        STATE = "EDIT"
        'GvBMI_d.Columns("no_seq").Visible = True
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
            row = dSO.Tables("_bmi").NewRow
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bmi").Rows(0)
            row.Item("Last_Update_Date") = Now
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("no_trans") = nomergen(BTRANS)
        row.Item("tipe_trans") = "JPB-KUT-01"
        row.Item("tgl_trans") = dtpTglSJ.Text
        row.Item("no_sppb") = LookupSPPB.EditValue
        row.Item("kode_gudang") = LookupGudang.EditValue
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("Program_Name") = Me.Name
        txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bmi").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bmid").Rows
            If row1.RowState = DataRowState.Added Then
                'row1.Item("no_trans") = row.Item("no_trans")
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
        txbNoTrans.Text = row.Item("no_trans")
        Try

            DA.Update(dSO.Tables("_bmi"))
            DA2.Update(dSO1.Tables("_bmid"))

            dSO.Tables("_bmi").AcceptChanges()
            dSO1.Tables("_bmid").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub hapus_record()

    End Sub

    Private Sub frmInvBMI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT distinct(no_sppb) from PROD.DBO.PROD_sppb_d ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        LookupSPPB.Properties.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup")

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupStok.DataSource = ds_cari2.Tables("_lookup2")
        'RepLookupSatuan.DataSource = ds_cari2.Tables("_lookup2")
        LookupStok.ValueMember = "Kode_Barang"
        LookupStok.DisplayMember = "Nama_Barang"


        prn = getParent(Me)
        btnhide()
      
        LoadStruktur("xxxx")
    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bmi") Is Nothing Then dSO.Tables("_bmi").Clear()
        If Not dSO1.Tables("_bmid") Is Nothing Then dSO1.Tables("_bmid").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmid")
        GcBMI_d.DataSource = dSO1.Tables("_bmid")

        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bmi").Rows(0)
            'txbNmTrima.Text = rw("no_nm_terima").ToString
            txbNoTrans.Text = rw("no_trans").ToString
            LookupGudang.EditValue = rw("kode_gudang").ToString
            LookupSPPB.EditValue = rw("no_sppb").ToString
            LookupKdKeg.EditValue = rw("kd_kegiatan").ToString
        End If
    End Sub

    Private Sub LookupSPPB_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupSPPB.EditValueChanged
        DA3 = New SqlDataAdapter(New SqlCommand("select distinct(kd_kegiatan) from PROD.DBO.PROD_sppb_d where no_sppb='" & LookupSPPB.EditValue & "'", sqlconn))
        DA3.Fill(ds_cari2, "_nosppb")
        LookupKdKeg.Properties.DataSource = ds_cari2.Tables("_nosppb")
    End Sub

    Private Sub LookupKdKeg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookupKdKeg.EditValueChanged
        If STATE = "ADD" Then
            If Not dSO1.Tables("_bke_d") Is Nothing Then dSO1.Tables("_bmid").Clear()
            'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
            Dim sqldr As SqlDataReader = New SqlCommand("select kd_cabang,kd_kegiatan,no_sppb,kd_barang,jumlah,0 as qty_in,0 as qty_sisa from PROD.dbo.PROD_sppb_d where no_sppb='" & LookupSPPB.EditValue & "' and kd_kegiatan='" & LookupKdKeg.EditValue & "'", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            dSO1.Tables("_bmid").Clear()

            While sqldr.Read
                Dim rw As DataRow = dSO1.Tables("_bmid").NewRow
                rw.Item("Kd_Cabang") = "1"
                rw.Item("no_trans") = "001"
                rw.Item("tipe_trans") = "JPU-KUT-01"
                rw.Item("no_seq") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("kd_barang").ToString
                rw.Item("kd_satuan") = "UNIT"
                rw.Item("qty_ord") = sqldr.Item("jumlah")
                rw.Item("qty_in") = sqldr.Item("qty_in")
                rw.Item("qty_sisa") = sqldr.Item("qty_sisa")



                dSO1.Tables("_bmid").Rows.Add(rw)
            End While
            sqldr.Close()
            GvBMI_d.FocusedColumn = GvBMI_d.VisibleColumns(4)
        End If
    End Sub

    Private Sub txbBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbBarcode.KeyPress
        Dim ok As Boolean = False
        If e.KeyChar = Chr(13) Then
            Dim dtrow() As DataRow = dSO1.Tables("_bmid").Select("kd_stok='" & txbBarcode.Text & "'")
            lblNmBrg.ForeColor = Color.Yellow
            lblStatus.ForeColor = Color.Yellow
            For i As Int16 = 0 To dtrow.Count - 1
                Application.DoEvents()
                lblStatus.Text = "OK"
                lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                txbBarcode.SelectAll()
                If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                    'If dtrow.Count > 0 Then
                    dtrow(i)("qty_in") = dtrow(i)("qty_in") + 1
                    dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_in")
                    ok = True
                    BindingContext(GcBMI_d.DataSource).Position = getPosisi(dtrow(i))
                    tunda()
                    txbBarcode.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    txbBarcode.Focus()
                    'MsgBox("barang ada")
                    'Exit Sub
                End If
            Next
            lblNmBrg.ForeColor = Color.Red
            lblStatus.ForeColor = Color.Red
            If dtrow.Count = 0 Then
                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                txbBarcode.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txbBarcode.Focus()

                'MsgBox("barang tidak ada")
            ElseIf Not ok Then
                MsgBox("Barang sudah terdaftar semua", MsgBoxStyle.Critical, "STOP..!")
                lblNmBrg.Text = "Barang sudah terdaftar semua"
                lblStatus.Text = "STOP!"
            End If
            txbBarcode.SelectAll()
        End If
    End Sub
    Private Sub GvBMI_d_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvBMI_d.CellValueChanged
        'If e.Column Is kd_stok Then
        '    Dim row As DataRow
        '    row = ds_cari2.Tables("_lookup2").Select("Kd_Satuan='" & e.Value & "'")(0)
        '    GvBMI_d.GetRow(e.RowHandle).item("kd_satuan") = row("Kd_Satuan")
        'If e.Column Is qty_in Then
        '    GvBMI_d.GetRow(e.RowHandle).item("qty_sisa") = GvBMI_d.GetRow(e.RowHandle).item("qty_ord").ToString - GvBMI_d.GetRow(e.RowHandle).item("qty_in").ToString
        'End If
    End Sub

    Public Function nomergen(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(no_trans,'x1'),4,10) as numeric)) from INV.dbo.INV_GUDANG_IN", sqlconn, bgtrans).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "BKI000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "BKI" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function


    Private Sub btnhide()
        btnTambah.Hide()
        btnUbah.Hide()
        btnSimpan.Hide()
        btnHapus.Hide()
        btnExit.Hide()
        btnBatal.Hide()
    End Sub

    Public Sub bersihkan()
        txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        dtpTglSJ.Text = ""
        LookupSPPB.EditValue = vbNullString
        LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

    Public Sub enabel()
        txbNoTrans.Enabled = True
        'txbNmTrima.Enabled = True
        dtpTglSJ.Enabled = True
        LookupGudang.Enabled = True
        LookupSPPB.Enabled = True
        btnSimpan.Enabled = True
    End Sub

    Public Sub disabel()
        txbNoTrans.Enabled = False
        'txbNmTrima.Enabled = False
        LookupGudang.Enabled = False
        dtpTglSJ.Enabled = False
        LookupSPPB.Enabled = False
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
End Class