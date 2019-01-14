Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
''Public Class cc
''    Inherits DevExpress.XtraEditors.LookUpEdit
''    Protected Overrides Sub OnPopupClosed(ByVal closeMode As DevExpress.XtraEditors.PopupCloseMode)
''        If closeMode = DevExpress.XtraEditors.PopupCloseMode.Cancel Then
''            AcceptPopupValue("XX")
''        End If
''        MyBase.OnPopupClosed(closeMode)
''    End Sub
''End Class
Public Class frmSO
    Dim dsete As New DataSet
    Dim dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim DAP As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DADD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Dim kriteria As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public no_sp As String = ""
    Public tipe_transaksi As String = ""
    Dim rhandel As Integer
    Public konsinyasi = "UMUM"
    Public ONLOAD_STATE As Boolean = False
    Public oldTotal As Double = 0
    Public isInternal As Boolean = False
    Dim FORCE_OPEN As String

    Public Sub setStatus()
        'If no_sp <> "" Then Exit Sub
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
        If State = "" Then
            lblState.Text = "IDLE"
        Else
            lblState.Text = State
        End If

    End Sub
    Public Sub reload_table(ByVal kode As String, ByVal tipe_trans As String)

        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()

        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 0 Stok, harga*qty-potongan_total as total,0 as state, sales.dbo.isLocked(no_sp, no_seq) isLocked from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and nomor_bonus is null and tipe_trans='" & tipe_trans & "' order by len(no_seq), No_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DADD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan_total as total,0 as state from Sales.dbo.SALES_SO_D where not kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DADD.Fill(dsete, "SODD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DAP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, '' Jenis, '' Merk, '' Tipe, '' Subtipe ,(select nama_promo from sif.dbo.sif_promo where no_promo=a.kd_promo) PROMONAME from Sales.dbo.SALES_SO_D_PROMO a where a.No_sp='" & kode & "' and a.tipe_trans='" & tipe_trans & "'", sqlconn))
        DAP.Fill(dsete, "SOP")
        DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_BIAYA where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DAB.Fill(dsete, "SOB")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            DT_TglSO.EditValue = row.Item("Tgl_sp")
            FORCE_OPEN = row("FORCE_OPEN").ToString

            If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()
            Dim sqlcmd As New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar ,h.Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset " & _
            "from SIF.dbo.SIF_Barang as b inner join sif.dbo.sif_harga as h on b.Kode_Barang=h.Kode_Barang " & _
            " inner join ( select kode_barang, max(start_date) start_date from  sif.dbo.sif_harga group by kode_barang )  h2 on h2.Kode_Barang=h.Kode_Barang and h2.Start_Date = h.Start_Date " & _
            "where b.Kd_Depart in ('" & kddep & "','1') and b.rec_stat='Y' and b.kd_jns_persd in ('1','2','3') and @tgl >= h.start_date order by Nama_Barang ", sqlconn)
            sqlcmd.Parameters.Add("@tgl", SqlDbType.Date)
            sqlcmd.Parameters("@tgl").Value = tglSO.EditValue
            dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
            dadbe.Fill(dsete, "VBARANG")

            cmbJenisSP.Text = row("Jenis_sp").ToString
            txtCustomer.EditValue = row.Item("Kd_Customer").ToString
            txtNamaPnrm.Text = row.Item("Nama_pnrm").ToString
            txtAlamatKirim.Text = row.Item("Almt_pnrm").ToString
            tglKirimMarketing.EditValue = row.Item("Tgl_Kirim_Marketing")
            txtSales.EditValue = row.Item("Kd_sales").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            lblPromo.Text = row.Item("desc_promo").ToString
            vValas.EditValue = row.Item("Valas").ToString
            txtKurs.Text = row.Item("Kurs").ToString
            cmdWilayah.EditValue = row.Item("Kode_Wilayah").ToString
            txtMedia.EditValue = row("media").ToString
            tglKirim.EditValue = row.Item("Tgl_Kirim").ToString
            txtBiaya.EditValue = row("Biaya").ToString
            txtCR.EditValue = getCreditLimit() + row("JML_RP_TRANS")
            cmbAtasNama.EditValue = row("Atas_Nama").ToString
            spReff.EditValue = row("SP_REFF").ToString
            If txtCR.EditValue <= 0 Then
                lblTotal.ForeColor = Color.Red
            Else
                lblTotal.ForeColor = Color.White
            End If
            lblTotal.ForeColor = Color.Red

            lblTotal.EditValue = row("JML_RP_TRANS")
            oldTotal = lblTotal.EditValue
            Dim dr As SqlDataReader
            dr = New SqlCommand("select 1 from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planning"
            End If
            dr.Close()


            dr = New SqlCommand("select 1 from prod.dbo.prod_rcn_prod_d d, prod.dbo.prod_rcn_prod_m m where no_sp='" & txtNomor.Text & "' and d.no_rph=m.no_rph and not no_spk is null", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On SPK"
                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            dr.Close()

            dr = New SqlCommand("select 1 from prod.dbo.PROD_rcn_krm_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery Planing"
                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            dr.Close()

            dr = New SqlCommand("select 1 from sales.dbo.sales_sj where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery"
                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            dr.Close()
            dr = Nothing
            colDel.OptionsColumn.AllowFocus = btnSave
            If row("Kunci").ToString = "Y" Then
                btnKunci.Appearance.BackColor = Color.Red
                btnKunci.Text = "KUNCI"
            Else
                btnKunci.Appearance.BackColor = Color.Lime
                btnKunci.Text = "BUKA"
            End If

            If row("isPrinted").ToString = "Y" Then
                btnCetak = False
            Else
                btnCetak = True
            End If
            If username.ToUpper = "ADMIN" Or txtCustomer.Properties.GetDataSourceValue("sts_group", txtCustomer.ItemIndex).ToString() = "Y" Then
                btnSave = True
            End If
            setStatus()
        Else
            oldTotal = 0
            txtCustomer.EditValue = vbNullString
            txtSales.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglKirimMarketing.EditValue = vbNullString
            tglKirim.EditValue = vbNullString
            cmdWilayah.EditValue = vbNullString
            tglSO.Text = vbNullString
            DT_TglSO.EditValue = Now.Date
            txtNamaPnrm.Text = vbNullString
            lblTotal.EditValue = 0
            lblPromo.Text = "-"
            lblStatus.Text = " [New]"
            vValas.EditValue = "IDR"
            txtMedia.EditValue = Nothing
            txtBiaya.EditValue = 0
            cmbAtasNama.EditValue = ""
            spReff.EditValue = Nothing
            btnKunci.Appearance.BackColor = Color.Lime
            btnKunci.Text = "BUKA"
        End If
        'cmbJenisSP.Text = konsinyasi
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbJenisSP.Properties.Items.Clear()
        If kddep = "6" Then
            cmbJenisSP.Properties.Items.Add("INTERNAL SPRING")
            cmbJenisSP.Properties.Items.Add("INTERNAL SPON")
        Else
            cmbJenisSP.Properties.Items.Add("UMUM")
            cmbJenisSP.Properties.Items.Add("KONSINYASI")
        End If
        connect()

        lblStateCR.Text = ""
        tglSO.Text = getTanggal()
        DT_TglSO.EditValue = getTanggal()
        DT_TglSO.Properties.MaxValue = DT_TglSO.EditValue
        reload_master()

        cmdWilayah.Properties.DataSource = dsete.Tables("WILAYAH")

        repBarang.DataSource = dsete.Tables("VBARANG")
        ' txtcari.AutoCompleteCustomSource.AddRange((From row As Object In dsete.Tables("VBARANG").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())

        repBiaya.DataSource = dsete.Tables("BIAYA")
        gcCari.DataSource = dsete.Tables("VBARANG")

        vValas.Properties.DataSource = dsete.Tables("VALAS")
        vValas.EditValue = "IDR"

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        reload_table("XXX", "XXX")

        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        GC.DataSource = dsete.Tables("SOD")
        GC_Biaya.DataSource = dsete.Tables("SOB")
        Dim r2 As DataRelation

        Dim dcolP2(2) As DataColumn
        Dim dColPROMO(2) As DataColumn
        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP(0) = dsete.Tables("SOD").Columns("No_Seq")

        dcolC(1) = dsete.Tables("SODD").Columns("kd_parent")
        dcolC(0) = dsete.Tables("SODD").Columns("No")

        rl = dsete.Relations.Add("Detail", dcolP, dcolC, False)
        rl.Nested = True
        GC.LevelTree.Nodes.Add("Detail", GVD)

        dcolP2(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP2(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP2(2) = dsete.Tables("SOD").Columns("No_seq")

        dColPROMO(0) = dsete.Tables("SOP").Columns("KD_STOK")
        dColPROMO(1) = dsete.Tables("SOP").Columns("NO_SP")
        dColPROMO(2) = dsete.Tables("SOP").Columns("seq_sp")

        r2 = dsete.Relations.Add("Promo", dcolP2, dColPROMO, False)
        r2.Nested = True

        GC.LevelTree.Nodes.Add("Promo", GVP)
        State = "ADD"

        prn = frmMain
        If no_sp <> "" Then
            ONLOAD_STATE = True
            reload_table(no_sp, tipe_transaksi)
            ONLOAD_STATE = False
        End If
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
                For Each rwd As DataRow In dsete.Tables("SOP").Select("seq_sp=" & rw.Item("No_seq"))
                    rwd("seq_sp") = i
                Next
                j = 1
                rw("No_seq") = i
                i += 1

            End If
        Next
    End Sub
    Public Function getCreditLimit(Optional ByVal btrans As SqlTransaction = Nothing) As Double
        Dim dr As SqlDataReader
        Dim hasil As Double = 0

        If btrans Is Nothing Then
            dr = New SqlCommand("select  isnull( sales.dbo.getCreditLimit2('" & txtCustomer.EditValue & "', '" & vValas.EditValue & "', '" & kddep & "'),0)", sqlconn).ExecuteReader
        Else
            dr = New SqlCommand("select isnull( sales.dbo.getCreditLimit2('" & txtCustomer.EditValue & "', '" & vValas.EditValue & "', '" & kddep & "'),0)", sqlconn, btrans).ExecuteReader
        End If
        dr.Read()
        If dr.HasRows Then hasil = CType(dr(0), Int64)
        dr.Close()
        dr = Nothing
        Return hasil
    End Function
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged

        txtKodeCust.Text = sender.editvalue

        If sender.editvalue <> vbNullString Then
            If Not dsete.Tables("SP_REFF") Is Nothing Then dsete.Tables("SP_REFF").Clear()
            With New SqlDataAdapter("select '' NO_SP,'' TGL_SP union select NO_SP, TGL_SP from sales.dbo.sales_so where kd_customer='" & txtKodeCust.Text & "'", sqlconn)
                .Fill(dsete, "SP_REFF")
                spReff.Properties.DataSource = dsete.Tables("SP_REFF")
            End With
            txtCustomer.ToolTip = txtCustomer.Text
            If txtCustomer.Properties.GetDataSourceValue("sts_group", txtCustomer.ItemIndex).ToString() = "Y" Then
                harga.OptionsColumn.AllowEdit = True
                harga.OptionsColumn.AllowFocus = True
                disc1.OptionsColumn.AllowEdit = True
                disc1.OptionsColumn.AllowFocus = True
                disc2.OptionsColumn.AllowEdit = True
                disc2.OptionsColumn.AllowFocus = True
                disc3.OptionsColumn.AllowEdit = True
                disc3.OptionsColumn.AllowFocus = True
                disc4.OptionsColumn.AllowEdit = True
                disc4.OptionsColumn.AllowFocus = True
                disc5.OptionsColumn.AllowEdit = True
                disc5.OptionsColumn.AllowFocus = True
                disc1.Visible = True
                disc2.Visible = True
                disc3.Visible = True
                disc4.Visible = True
                disc5.Visible = True
                disc1.VisibleIndex = 13
                disc2.VisibleIndex = 14
                disc3.VisibleIndex = 15
                disc4.VisibleIndex = 16
                disc5.VisibleIndex = 17
            Else
                harga.OptionsColumn.AllowEdit = False
                harga.OptionsColumn.AllowFocus = False
                disc1.OptionsColumn.AllowEdit = False
                disc1.OptionsColumn.AllowFocus = False
                disc2.OptionsColumn.AllowEdit = False
                disc2.OptionsColumn.AllowFocus = False
                disc3.OptionsColumn.AllowEdit = False
                disc3.OptionsColumn.AllowFocus = False
                disc4.OptionsColumn.AllowEdit = False
                disc4.OptionsColumn.AllowFocus = False
                disc5.OptionsColumn.AllowEdit = False
                disc5.OptionsColumn.AllowFocus = False
                disc1.Visible = False
                disc2.Visible = False
                disc3.Visible = False
                disc4.Visible = False
                disc5.Visible = False
            End If
            If GV.RowCount > 1 Then
                If Not ONLOAD_STATE Then
                    If State = "" Then Exit Sub

                    Dim qty As Double
                    Dim kd_stok As String
                    For i = 0 To GV.RowCount - 1
                        qty = GV.GetRowCellValue(i, "Qty")
                        kd_stok = GV.GetRowCellValue(i, "Kd_Stok")
                        If Not kd_stok Is Nothing Then
                            GV.SetRowCellValue(i, "Kd_Stok", kd_stok)
                            GV.SetRowCellValue(i, "Qty", qty)
                        End If
                    Next
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString() & " " & txtCustomer.Properties.GetDataSourceValue("Kota1", txtCustomer.ItemIndex).ToString()
                Alamat1.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
                Alamat2.Text = txtCustomer.Properties.GetDataSourceValue("Alamat2", txtCustomer.ItemIndex).ToString()
                Alamat3.Text = txtCustomer.Properties.GetDataSourceValue("Alamat3", txtCustomer.ItemIndex).ToString()

                If Not dsete.Tables("SALES") Is Nothing Then dsete.Tables("SALES").Clear()
                txtSales.EditValue = vbNullString
                Dim area As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString()
                Dim wil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString()
                cmdWilayah.EditValue = wil
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where kode_wilayah = '" & wil & "' and kode_area ='" & area & "' and rec_stat='Y'", sqlconn))
                dadbe.Fill(dsete, "SALES")

                txtCR.EditValue = getCreditLimit()
                If dsete.Tables("SALES").Rows.Count > 0 And State = "ADD" Then
                    txtSales.EditValue = dsete.Tables("SALES").Rows(0)("Kode_Sales")
                End If
                If State = "ADD" Then
                    Dim kdwil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString
                    Dim kdarea As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString
                    With dsete.Tables("AREA").Select("Kd_Wilayah = '" & kdwil & "' and Kode_Area='" & kdarea & "'")
                        If .Count > 0 Then tglKirimMarketing.EditValue = getTanggal.AddDays(.ElementAt(0).Item("Leat_Time")) : tglKirim.EditValue = tglKirimMarketing.EditValue
                    End With
                    cmbAtasNama.Properties.Items.Clear()
                    cmbAtasNama.Properties.Items.Add(txtCustomer.Properties.GetDataSourceValue("Nama_Customer", txtCustomer.ItemIndex).ToString())
                    If txtCustomer.Properties.GetDataSourceValue("nama_customer2", txtCustomer.ItemIndex).ToString() <> "" Then
                        cmbAtasNama.Properties.Items.Add(txtCustomer.Properties.GetDataSourceValue("nama_customer2", txtCustomer.ItemIndex).ToString())
                    End If
                    If txtCustomer.Properties.GetDataSourceValue("alias", txtCustomer.ItemIndex).ToString() <> "" Then
                        cmbAtasNama.Properties.Items.Add(txtCustomer.Properties.GetDataSourceValue("alias", txtCustomer.ItemIndex).ToString())
                    End If
                    cmbAtasNama.EditValue = txtCustomer.Text
                End If
            Else
                txtAlamatKirim.Text = ""
            End If
        Else
            txtAlamatKirim.Text = "X"
            txtSales.EditValue = vbNullString
            cmbAtasNama.EditValue = vbNullString
        End If
        DXEP.SetError(txtKodeCust, "")
    End Sub
    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        txtNamaSales.Text = sender.editvalue
        DXEP.SetError(txtNamaSales, "")
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        connect()
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim isError As Boolean = False
        If State <> "ADD" Then
            Dim dr As SqlDataReader = New SqlCommand("select [status] from sales.dbo.sales_so where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr(0).ToString = "BATAL" Then
                    MsgBox("Data Sales Order Tersebut Sudah Dibatalkan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                    cancel_click()
                    dr.Close()
                    Exit Sub
                End If
            Else
                MsgBox("Data Sales Order Tersebut Tidak Diketemukan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                cancel_click()
                dr.Close()
                Exit Sub
            End If
            dr.Close()
        End If
        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                DXEP.SetError(txtKodeCust, "Nama Customer Belum Diisi")
                txtCustomer.Focus()
                isError = True
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If txtSales.EditValue = "" Then
                    DXEP.SetError(txtNamaSales, "Nama Sales Belum Diisi")
                    txtSales.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If txtAlamatKirim.EditValue = "" Then
                    DXEP.SetError(txtAlamatKirim, "Alamat Kirim Belum Diisi")
                    txtAlamatKirim.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If tglKirimMarketing.Text = "" Then
                    tglKirimMarketing.ErrorText = "Tanggal Kirim Belum Diisi"
                    tglKirimMarketing.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If DateDiff(DateInterval.Day, Convert.ToDateTime(tglSO.Text), tglKirimMarketing.EditValue) < 0 Then
                    tglKirimMarketing.ErrorText = "Tanggal Janji Kirim Harus Lebih Besar Dari Tanggal Order"
                    tglKirimMarketing.Focus()
                    isError = True
                End If
            End If
            If GV.RowCount = 0 Then
                lblTotal.ErrorText = "Daftar Barang Masih Kosong"
                lblTotal.Focus()
                isError = True
            End If
            If GV.RowCount = 1 And GV.GetRowCellValue(0, "No_seq") Is Nothing Then
                lblTotal.ErrorText = "Daftar Barang Masih Kosong"
                lblTotal.Focus()
                isError = True
            End If

        End If
        If isError = True Then
            showMessages("Isian Masih Belum Benar, Harap Periksa Kembali", 10, "WARNING")
            Exit Sub
        End If
        If cmbJenisSP.EditValue <> "INTERNAL" Then
            txtCR.EditValue = getCreditLimit()
            lblTotal_EditValueChanged(lblTotal, New EventArgs)
        End If

        If Not isDelete Then
            If State = "ADD" Then
                If (lblTotal.ForeColor = Color.Red And cmbJenisSP.EditValue <> "INTERNAL") Then
                    'frmPaswdOTP.lblinfo.Text = "Credit Limit Melampuhi Batas"
                    'frmPaswdOTP.ShowDialog()
                    'If Not frmPaswdOTP.PENDING Then
                    '    If Not frmPaswdOTP.allowed Then
                    '        showMessages("Dibatalkan Oleh User", , "WARNING")
                    '        Exit Sub
                    '    End If
                    'End If
                End If
                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Flag_Ppn") = ""
                row.Item("PPn") = "0"
            ElseIf State = "EDIT" Then
                'If (lblTotal.ForeColor = Color.Red And oldTotal > lblTotal.EditValue) Or lblStatus.Text = "PENDING" Then
                '    frmPaswdOTP.lblinfo.Text = "Credit Limit Melampuhi Batas"
                '    frmPaswdOTP.ShowDialog()

                '    If Not frmPaswdOTP.allowed Then
                '        showMessages("Dibatalkan Oleh User", , "WARNING")
                '        Exit Sub
                '    End If
                'End If
                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang  ' <-- hanya contoh, nanti diisi dengan yg bener
            tipetrans = IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum)
            row.Item("Tipe_trans") = tipetrans
            row.Item("Kunci") = IIf(btnKunci.Text = "BUKA", "", "Y")
            'row.Item("Tgl_sp") = getTanggal()
            row.Item("Tgl_sp") = tglSO.Text
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Nama_pnrm") = txtNamaPnrm.Text
            row.Item("Almt_pnrm") = txtAlamatKirim.Text
            If Not cmdWilayah.EditValue Is Nothing Then row.Item("Kode_Wilayah") = cmdWilayah.EditValue
            If tglKirim.Text <> "" Then row.Item("Tgl_Kirim") = tglKirim.EditValue.ToString
            If tglKirimMarketing.Text <> "" Then row.Item("Tgl_Kirim_Marketing") = tglKirimMarketing.EditValue.ToString()
            row.Item("Kd_sales") = txtSales.EditValue
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Media") = txtMedia.EditValue
            row("FORCE_OPEN") = ""

            If row.Item("Flag_Ppn").ToString = "Y" And txtNomor.Text.Length > 10 Then
                row.Item("PPn") = (lblTotal.EditValue - txtBiaya.EditValue)
                row.Item("PPn") = row.Item("PPn") - row.Item("PPn") / 1.1
            End If

            row.Item("Atas_Nama") = cmbAtasNama.EditValue
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = kddep
            row.Item("Status") = IIf(frmPaswdOTP.PENDING, "PENDING", "OK")
            row.Item("JML_RP_TRANS") = lblTotal.EditValue * txtKurs.Text
            row.Item("Valas") = vValas.EditValue
            row.Item("Kurs") = txtKurs.Text
            row.Item("JML_VALAS_TRANS") = lblTotal.EditValue
            row.Item("Biaya") = txtBiaya.EditValue
            row.Item("Program_Name") = Me.Name
            If Not spReff.EditValue Is Nothing Then row.Item("SP_REFF") = spReff.EditValue

            row("Jenis_sp") = cmbJenisSP.Text
            If State = "ADD" Then
                dsete.Tables("SO").Rows.Add(row)
            End If
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = tipetrans
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                    rows.Item("qty_prod") = 0
                    rows.Item("qty_kirim") = 0
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SODD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = tipetrans
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOP").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("NO_SP") = txtNomor.Text
                    rows("tipe_trans") = tipetrans
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows("tipe_trans") = tipetrans
                End If
            Next
        End If
        Try
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()
            DAD.InsertCommand = myBuilder.GetInsertCommand()
            DAD.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DADD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DADD.UpdateCommand = myBuilder.GetUpdateCommand()
            DADD.InsertCommand = myBuilder.GetInsertCommand()
            DADD.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAP)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAP.UpdateCommand = myBuilder.GetUpdateCommand()
            DAP.InsertCommand = myBuilder.GetInsertCommand()
            DAP.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAB)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAB.UpdateCommand = myBuilder.GetUpdateCommand()
            DAB.InsertCommand = myBuilder.GetInsertCommand()
            DAB.DeleteCommand = myBuilder.GetDeleteCommand()
            If BTRANS Is Nothing Then BTRANS = sqlconn.BeginTransaction("1")
            'BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DADD.UpdateCommand.Transaction = BTRANS
            DADD.InsertCommand.Transaction = BTRANS
            DADD.DeleteCommand.Transaction = BTRANS

            DAP.UpdateCommand.Transaction = BTRANS
            DAP.InsertCommand.Transaction = BTRANS
            DAP.DeleteCommand.Transaction = BTRANS

            DAB.UpdateCommand.Transaction = BTRANS
            DAB.InsertCommand.Transaction = BTRANS
            DAB.DeleteCommand.Transaction = BTRANS

            If State = "ADD" Then
                If kddep = "6" Then
                    txtNomor.Text = getNoTrans("SPSRIT", row.Item("Tgl_sp"), BTRANS)
                Else
                    txtNomor.Text = get_next_So(BTRANS)

                End If
                row.Item("No_sp") = txtNomor.Text
                row.Item("old_num") = txtNomor.Text
                For Each rows As DataRow In dsete.Tables("SOD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_sp") = txtNomor.Text
                    End If
                Next
                For Each rows As DataRow In dsete.Tables("SODD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_sp") = txtNomor.Text
                    End If
                Next
                For Each rows As DataRow In dsete.Tables("SOP").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("NO_SP") = txtNomor.Text
                    End If
                Next
                For Each rows As DataRow In dsete.Tables("SOB").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_sp") = txtNomor.Text
                    End If
                Next
            End If

            lblState.Text = "SAVING..."

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DADD.Update(dsete.Tables("SODD"))
            DAB.Update(dsete.Tables("SOB"))
            If State <> "ADD" Then
                With New SqlCommand("delete from Sales.dbo.SALES_SO_D_PROMO where No_sp='" & txtNomor.Text & "' and Status='Y'", sqlconn, BTRANS).ExecuteNonQuery
                End With
                With New SqlCommand("delete from Sales.dbo.SALES_SO_D where No_sp='" & txtNomor.Text & "' and isnull(nomor_bonus,0) > 0", sqlconn, BTRANS).ExecuteNonQuery
                End With

            End If
            Dim desc As String
            If State <> "DELETE" And cmbJenisSP.EditValue = "UMUM" Then
                Dim dr As SqlDataReader = New SqlCommand("select a.*, (select nama_promo from sif.dbo.sif_promo where no_promo=a.kdpromo) as PROMO " & _
                                             " from sales.dbo.SOGetPromoBali('" & txtNomor.Text & "', '" & tipetrans & "') as a", sqlconn, BTRANS).ExecuteReader
                Dim i As Int16 = 1
                dsete.Tables("SOP").Clear()
                While dr.Read()
                    Dim rw As DataRow = dsete.Tables("SOP").NewRow
                    rw("Kd_Cabang") = kdcabang
                    rw("tipe_trans") = tipetrans
                    rw("Departemen") = kddep
                    rw("seq_sp") = i : i += 1
                    rw("NO_SP") = txtNomor.Text
                    rw("KD_PROMO") = dr("KDPROMO")
                    rw("No_Seq") = dr("NOSEQ")
                    rw("JML_POINT") = dr("jml_point")
                    rw("CASHBACK") = dr("cash_back")

                    rw("Potongan") = dr("potongan")
                    'If dr("potongan").ToString <> "" Then
                    '    rw("CASHBACK") = lblTotal.EditValue * dr("potongan") / 100
                    'End If
                    rw("Potongan2") = dr("potongan2")
                    'If dr("potongan2").ToString <> "" Then
                    '    rw("CASHBACK") = rw("CASHBACK") + (lblTotal.EditValue - rw("CASHBACK")) * dr("potongan2") / 100
                    'End If

                    rw("KD_BRG_BONUS") = dr("kd_brg_bonus")
                    rw("QTY") = dr("free_qty")
                    rw("PROMO_DESC") = dr("PROMODESC")
                    desc &= dr("PROMODESC") & IIf(rw("QTY") > 1, "*" & rw("QTY").ToString, "") & ", "
                    rw("Programe_name") = Me.Name
                    rw("Last_Create_Date") = getTanggal(BTRANS)
                    rw("Last_Created_By") = username
                    rw("Status") = "Y"
                    rw("SP_AKUMULASI") = "T"
                    rw("ISNAMBAH") = dr("IS_NAMBAH")
                    rw("isTerkecil") = dr("isTerkecil")
                    'rw("Jenis") = dr("Jenis")
                    'rw("Merk") = dr("Merk")
                    'rw("Tipe") = dr("Tipe")
                    'rw("Subtipe") = dr("Subtipe")
                    rw("NO_SP") = txtNomor.Text
                    dsete.Tables("SOP").Rows.Add(rw)
                End While
            End If
            lblState.Text = State

            DAP.Update(dsete.Tables("SOP"))
            With New SqlCommand("update sales.dbo.sales_so set desc_promo = '" & desc & "' where no_sp='" & txtNomor.Text & "'", sqlconn, BTRANS).ExecuteNonQuery
                lblPromo.Text = desc
            End With
            BTRANS.Commit()
            lblState.Text = "SAVED"
            showMessages("Transaksi Telah Tersimpan")
            State = "EDIT"
            reload_table(txtNomor.Text, tipetrans)
            lblState.Text = "EDIT"

            If btnSave = False Then
                lblState.Text = "LOCKED"
            End If
            setreadonly()
            btnSave = True
            setStatus()

        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            lblState.Text = "GAGAL SIMPAN"
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim Total As Double
        If e.Column Is Kd_Stok Then
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            Dim rw As DataRow
            GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
            GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
            GV.GetRow(e.RowHandle).item("potongan_total") = 0
            GV.SetRowCellValue(e.RowHandle, "ambil_bonus", vbNullString)
            rw = drows(0)
            GV.GetRow(e.RowHandle).item("Deskripsi") = rw("Nama_Barang")
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            GV.GetRow(e.RowHandle).item("set") = rw("isset")
            If rw("isset").ToString = "1" Then Exit Sub
            With New SqlCommand("select top 1 qty_available from inv.dbo.inv_stok_saldo where kd_stok='" & e.Value & "' order by bultah desc", sqlconn).ExecuteReader
                Try
                    .Read()
                    If .HasRows Then
                        GV.GetRow(e.RowHandle).item("Stok") = .Item(0)
                    End If
                    .Close()
                Catch ex As Exception
                    If Not .IsClosed Then .Close()
                    MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
                End Try

            End With
            If cmbJenisSP.Text = "INTERNAL" Then
                GV.GetRow(e.RowHandle).item("harga") = 0
                GV.GetRow(e.RowHandle).item("total") = 0
                Exit Sub
            Else
                If vValas.EditValue = "IDR" Then

                    With New SqlCommand("select harga from sif.dbo.sif_harga_sponbox where kd_stok='" & e.Value & "' and kd_customer='" & txtKodeCust.Text & "'", sqlconn).ExecuteReader
                        Try
                            .Read()
                            If .HasRows Then
                                GV.GetRow(e.RowHandle).item("harga") = .Item(0)
                            Else
                                GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
                            End If
                            .Close()
                        Catch ex As Exception
                            If Not .IsClosed Then .Close()
                            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
                        End Try

                    End With
                    GV.GetRow(e.RowHandle).item("total") = IIf(GV.GetRow(e.RowHandle).item("harga").ToString = "", 0, GV.GetRow(e.RowHandle).item("harga")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))
                Else
                GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Dollar")
                GV.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Dollar").ToString = "", 0, rw("Harga_Dollar")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))
            End If
                End If


            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  "b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe like r.kode_tipe and Kode_Barang ='" & e.Value & "' order by kd_jenis, kd_merk, kd_tipe, Ukuran desc", sqlconn).ExecuteReader
                read.Read()
            End If
            If read.HasRows Then
                GV.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                Else
                    GV.GetRow(e.RowHandle).item("disc1") = 0
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                Else
                    GV.GetRow(e.RowHandle).item("disc2") = 0
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                Else
                    GV.GetRow(e.RowHandle).item("disc3") = 0
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                Else
                    GV.GetRow(e.RowHandle).item("disc4") = 0
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                Else
                    GV.GetRow(e.RowHandle).item("disc5") = 0
                End If
            End If
            read.Close()
            read = Nothing
        ElseIf e.Column Is Qty Then
            If GV.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga") * e.Value
            Total = GV.GetRow(e.RowHandle).item("total")
            'cariPromo(GV.GetRow(e.RowHandle))
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
            GV.GetRow(e.RowHandle).item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
            GV.GetRow(e.RowHandle).Item("total") = GV.GetRow(e.RowHandle).Item("total") - GV.GetRow(e.RowHandle).Item("potongan_total")

            'ElseIf e.Column Is Sete Then
            '    ' 
            '    If GV.GetRow(e.RowHandle).item("Kd_Stok").ToString <> "" Then
            '        For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & GV.GetRow(e.RowHandle).item("Kd_Stok") & "'")
            '            rw.Delete()
            '        Next
            '        GV.GetRow(e.RowHandle).item("Kd_Stok") = vbNullString
            '    End If
        ElseIf e.Column.Name = "harga" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
        ElseIf e.Column.Name = "disc1" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
            GV.SetRowCellValue(e.RowHandle, "nama_potongan", cariNamaDiskon(GV.GetRow(e.RowHandle)))
        ElseIf e.Column.Name = "disc2" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
            GV.SetRowCellValue(e.RowHandle, "nama_potongan", cariNamaDiskon(GV.GetRow(e.RowHandle)))
        ElseIf e.Column.Name = "disc3" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
            GV.SetRowCellValue(e.RowHandle, "nama_potongan", cariNamaDiskon(GV.GetRow(e.RowHandle)))
        ElseIf e.Column.Name = "disc4" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
            GV.SetRowCellValue(e.RowHandle, "nama_potongan", cariNamaDiskon(GV.GetRow(e.RowHandle)))
        ElseIf e.Column.Name = "disc5" Then
            GV.SetRowCellValue(e.RowHandle, "Qty", GV.GetRowCellValue(e.RowHandle, "Qty"))
            GV.SetRowCellValue(e.RowHandle, "nama_potongan", cariNamaDiskon(GV.GetRow(e.RowHandle)))
        ElseIf e.Column.Name = "tglKirims" Then
            If GV.GetRowCellValue(e.RowHandle, "tgl_kirim") Is Nothing Then GV.SetRowCellValue(e.RowHandle, "tgl_kirim", e.Value)
        ElseIf e.Column Is BNS Then
            If e.Value = "Y" Then
                GV.GetRow(e.RowHandle).item("total") = 0
                GV.GetRow(e.RowHandle).item("potongan_total") = 0
                GV.GetRow(e.RowHandle).item("harga") = 0
                GV.GetRow(e.RowHandle).item("nama_potongan") = ""
                If GV.GetRow(e.RowHandle).item("set") = "1" Then
                    For Each rw In dsete.Tables("SODD").Select("No_seq='" & GV.GetRow(e.RowHandle).item("No_seq") & "'")
                        rw.Item("total") = 0
                        rw.Item("potongan_total") = 0
                        rw.Item("harga") = 0
                        rw.Item("nama_potongan") = ""
                    Next
                End If
            ElseIf e.Value = "T" And Not GV.GetRowCellValue(e.RowHandle, "Kd_Stok") Is Nothing Then
                GV.SetRowCellValue(e.RowHandle, "Kd_Stok", GV.GetRowCellValue(e.RowHandle, "Kd_Stok"))
            End If
        End If

    End Sub
    Function cariNamaDiskon(ByVal row As Object) As String
        Dim hasil As String
        If Not row.item("disc1") Is DBNull.Value Then
            If row.item("disc1") > 0 Then hasil = Val(row.item("disc1")).ToString + "%"
        End If
        If Not row.item("disc2") Is DBNull.Value Then
            If row.item("disc2") > 0 Then hasil = hasil + "+" + Val(row.item("disc2")).ToString + "%"
        End If
        If Not row.item("disc3") Is DBNull.Value Then
            If row.item("disc3") > 0 Then hasil = hasil + "+" + Val(row.item("disc3")).ToString + "%"
        End If
        If Not row.item("disc4") Is DBNull.Value Then
            If row.item("disc4") > 0 Then hasil = hasil + "+" + Val(row.item("disc4")).ToString + "%"
        End If
        If Not row.item("disc5") Is DBNull.Value Then
            If row.item("disc5") > 0 Then hasil = hasil + "+" + Val(row.item("disc5")).ToString + "%"
        End If
        cariNamaDiskon = hasil
    End Function
    Sub cariPromo(ByVal e As Object)
        Exit Sub ' untuk sementara tidak dipakai karena dihandle oeh manajemen promo
        If cmbJenisSP.Text <> "UMUM" Then Exit Sub ' klau sp konsinyasi tidak pakai perhitungan promo.
        For Each rw In dsete.Tables("SOP").Select("seq_sp='" & e("No_Seq") & "'")
            rw.Delete()
        Next
        Dim dr As SqlDataReader
        dr = New SqlCommand("select * from sales.dbo.baranggetPromo('" & e.item("Kd_Stok") & "' , GETDATE()   , " & e.item("Qty") & " ,0)", sqlconn).ExecuteReader
        While dr.Read
            Dim rr As DataRow = dsete.Tables("SOP").NewRow
            rr("tipe_trans") = e.item("tipe_trans")
            rr("Kd_Cabang") = kdcabang
            rr("KD_PROMO") = dr("KDPROMO")
            rr("JML_POINT") = dr("jml_point")
            rr("CASHBACK") = dr("cash_back")
            rr("KD_BRG_BONUS") = dr("kd_brg_bonus")
            rr("KD_BRG_HADIAH") = dr("KD_BRG_HADIAH")
            rr("POTONGAN") = dr("potongan")
            rr("POTONGAN2") = dr("Potongan2")
            rr("No_Seq") = dr("NOSEQ")
            rr("QTY") = dr("free_qty")
            rr("KD_STOK") = e.item("Kd_Stok")
            rr("PROMONAME") = dr("PROMONAME")
            rr("PROMO_DESC") = dr("PROMODESC")
            rr("seq_sp") = e.item("No_seq")
            rr("Ambil") = "Y"
            If txtNomor.Text <> "" Then rr("NO_SP") = txtNomor.Text
            dsete.Tables("SOP").Rows.Add(rr)
        End While
        dr.Close()
        dr = Nothing
    End Sub
    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If e.Column Is Kd_Stok Then
            If e.RowHandle < 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("Kd_Stok").ToString <> "" Then
                For Each rw In dsete.Tables("SODD").Select("No='" & GV.GetRow(e.RowHandle).item("No_seq") & "'")
                    rw.Delete()
                Next
            End If
        End If
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If txtCustomer.EditValue = "" Then
            BeginInvoke(New MethodInvoker(AddressOf GV.CancelUpdateCurrentRow))
            GV.DeleteRow(e.RowHandle)
            DXEP.SetError(txtKodeCust, "Nama Customer Belum Diisi")
            txtCustomer.Focus()
            Exit Sub
        End If
        GV.SetRowCellValue(e.RowHandle, "ambil_bonus", "Y")
        GV.SetRowCellValue(e.RowHandle, "no_sp", txtNomor.Text)
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount
        GV.GetRow(e.RowHandle).item("set") = 0
        GV.GetRow(e.RowHandle).item("Bonus") = "T"
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If Not btnSave Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each rw As DataRow In dsete.Tables("SODD").Select("No = '" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        rw.Delete()
                    Next
                    GV.DeleteSelectedRows()
                    lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(total)", "")
                    If lblTotal.Text = "" Then
                        lblTotal.EditValue = txtBiaya.EditValue
                    Else
                        lblTotal.EditValue += txtBiaya.EditValue
                    End If
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            tglKirimMarketing.Focus()

        End If

    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        'rw.Row.RowState

        'rw.Row.RowState

        If e.Row Is Nothing Then Exit Sub

        Dim hargadtl As Double = 0
        Dim potdtl As Double = 0
        Dim totdtl As Double = 0
        Dim disk1 As Double = 0
        Dim disk2 As Double = 0
        Dim disk3 As Double = 0
        Dim disk4 As Double = 0
        Dim disk5 As Double = 0
        Dim sqlcmd As SqlCommand
        If e.Row.item("set").ToString = "1" Then
            Dim Total As Double = 0
            Dim tbl As SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_set_product_d where kd_set='" & e.Row.row.item("Kd_Stok") & "'", sqlconn).ExecuteReader
            Dim i As Integer = 0
            If tbl.HasRows Then
                For Each rw As DataRow In dsete.Tables("SODD").Select("No='" & e.Row.item("No_seq") & "'")
                    rw.Delete()
                Next
                While tbl.Read
                    Dim rws As DataRow = dsete.Tables("SODD").NewRow

                    i += 1
                    rws.Item("Kd_Stok") = tbl.Item("Kd_Stok")
                    rws.Item("kd_parent") = e.Row.item("Kd_Stok")
                    rws.Item("No") = e.Row.item("No_seq")
                    rws.Item("No_seq") = e.Row.item("No_seq") & "." & i
                    rws.Item("No_sp") = txtNomor.Text
                    rws.Item("Qty") = tbl.Item("Qty") * e.Row.item("Qty")
                    rws.Item("set") = 0
                    rws.Item("potongan_total") = 0
                    rws.Item("potongan") = 0
                    rws.Item("total") = 0
                    rws.Item("harga") = 0
                    rws.Item("total") = 0

                    sqlcmd = New SqlCommand("select top 1 b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar " & _
                                                               ",h.Harga_Rupiah, b.Kode_Barang , '0' as isset " & _
                                                               "from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h " & _
                                                               " where b.Kode_Barang='" & tbl.Item("KD_STOK") & "' and " & _
                                                               "b.Kode_Barang=h.Kode_Barang and h.start_date <= @tgl order by start_date desc", sqlconn)
                    sqlcmd.Parameters.Add("@tgl", SqlDbType.Date)
                    sqlcmd.Parameters("@tgl").Value = tglSO.EditValue
                    Dim tbls As SqlDataReader = sqlcmd.ExecuteReader

                    tbls.Read()
                    If tbls.HasRows Then
                        rws.Item("Deskripsi") = tbls.Item("Nama_Barang")
                        rws.Item("Kd_Satuan") = tbls.Item("Kd_Satuan")
                        If e.Row.item("Bonus").ToString <> "Y" Then
                            If vValas.EditValue = "IDR" Then
                                rws.Item("harga") = tbls("Harga_Rupiah")
                                rws.Item("total") = IIf(rws.Item("harga").ToString = "", 0, rws.Item("harga")) * IIf(rws.Item("Qty").ToString = "", 0, rws.Item("Qty"))
                                hargadtl += tbls("Harga_Rupiah")
                            Else
                                rws.Item("harga") = tbls("Harga_Dollar")
                                rws.Item("total") = IIf(tbls("Harga_Dollar").ToString = "", 0, tbls("Harga_Dollar")) * IIf(rws.Item("Qty").ToString = "", 0, rws.Item("Qty"))
                                hargadtl += tbls("Harga_Dollar")
                            End If
                            Dim read As SqlClient.SqlDataReader
                            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                                  "b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK And Kode_Barang ='" & rws.Item("Kd_Stok") & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
                            read.Read()
                            If Not read.HasRows Then
                                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe like r.kode_tipe and Kode_Barang ='" & rws.Item("Kd_Stok") & "' order by kd_jenis, kd_merk, kd_tipe, Ukuran desc", sqlconn).ExecuteReader
                                read.Read()
                            End If
                            If read.HasRows Then
                                rws.Item("nama_potongan") = read.Item("Kd_Diskon")
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
                            read = Nothing
                            If rws.Item("total").ToString = "" Then Exit Sub
                            Total = rws.Item("total")


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
                            rws.Item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
                            rws.Item("potongan") = rws.Item("potongan_total") / e.Row("Qty")
                            potdtl += rws.Item("potongan_total")
                            rws.Item("total") = rws.Item("total") - rws.Item("potongan_total")
                            totdtl += rws.Item("total")
                        End If
                    End If
                    tbls.Close()
                    tbls = Nothing

                    dsete.Tables("SODD").Rows.Add(rws)

                End While
            Else

                For Each rws As DataRow In dsete.Tables("SODD").Select("no='" & e.Row.item("no_seq") & "'")
                    rws("Qty") = e.Row.item("Qty")
                    Total = rws("harga") * rws("Qty")
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
                    rws.Item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
                    rws.Item("potongan") = rws.Item("potongan_total") / e.Row("Qty")
                    potdtl += rws.Item("potongan_total")
                    rws.Item("total") = Total - rws.Item("potongan_total")
                    totdtl += rws.Item("total")
                Next
            End If

            tbl.Close()
            tbl = Nothing
            e.Row("harga") = hargadtl
            e.Row("total") = totdtl
            e.Row("potongan_total") = potdtl

        Else
            For Each rw As DataRow In dsete.Tables("SODD").Select("no='" & e.Row.item("no_seq") & "'")
                rw.Delete()
            Next
        End If

        'untuk mencari promo per-item
        e.Row("potongan") = e.Row("potongan_total") / e.Row("Qty")

        lblTotal.EditValue = Total.SummaryItem.SummaryValue + txtBiaya.EditValue
        Dim x() As DataRow = dsete.Tables("SOP").Select("seq_sp = '" & e.Row.row.item("No_seq") & "'")
        If x.Length = 0 Then
            e.Row.row.item("ambil_bonus") = Nothing
        End If
        If e.Row.row.RowState = DataRowState.Modified Then
            e.Row.row.item("state") = 2
        Else
            e.Row.row.item("state") = 1
        End If
        cariPromo(e.Row.row)


        GVD.RefreshData()
        'biaya_packing()
    End Sub
    Private Sub GV_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.ShownEditor
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        'view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        'On Error Resume Next
        'If view.FocusedColumn Is Kd_Stok Then
        '    Dim edit As DevExpress.XtraEditors.LookUpEdit
        '    Dim table As DataTable
        '    Dim row As DataRow

        '    edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

        '    table = CType(edit.Properties.DataSource, DataTable)
        '    clone = New DataView(table)
        '    row = view.GetDataRow(view.FocusedRowHandle)
        '    clone.RowFilter = "[isset] = " + row("set").ToString()
        '    edit.Properties.DataSource = clone
        'End If
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        Dim i As Double
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = Kd_Stok
        Else
            With New SqlCommand("select count(1) from sif.dbo.sif_barang b, sif.dbo.sif_ukuran u where u.kode_ukuran=b.kd_ukuran and b.kode_barang='" & e.Row.item("Kd_Stok") & "' and Alias = 'KHS'", sqlconn).ExecuteReader
                Try
                    .Read()
                    If .Item(0) > 0 Then
                        If e.Row.item("Keterangan").ToString = "" Then
                            isValid = False
                            GV.SetColumnError(Keterangan, "Harap Mengisi Ukuran Barang Pesanan Khusus di Kolom Keterangan.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                            GV.FocusedColumn = Keterangan
                        End If
                    End If
                    .Close()
                Catch ex As Exception
                    If Not .IsClosed Then .Close()
                    MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
                End Try
            End With
        End If
        If e.Row.item("tgl_kirim").ToString <> "" Then
            If e.Row.item("tgl_kirim") < DT_TglSO.DateTime Then
                isValid = False
                GV.SetColumnError(tgl_kirim_ppic, "Tanggal janji Kirim Harus Lebih Besar dari Tanggal Order", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GV.FocusedColumn = tgl_kirim_ppic
            End If
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If Not e.Row.item("disc1") Is DBNull.Value And disc1.Visible Then
            If e.Row.item("disc1") <= 0 And e.Row.item("disc1") > 100 Then
                isValid = False
                GV.SetColumnError(disc1, "Harap Mengisi Diskon Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row.item("disc2") Is DBNull.Value And disc2.Visible Then
            If e.Row.item("disc2") <= 0 And e.Row.item("disc2") > 100 Then
                isValid = False
                GV.SetColumnError(disc2, "Harap Mengisi Diskon Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row.item("disc3") Is DBNull.Value And disc3.Visible Then
            If e.Row.item("disc3") <= 0 And e.Row.item("disc3") > 100 Then
                isValid = False
                GV.SetColumnError(disc3, "Harap Mengisi Diskon Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row.item("disc4") Is DBNull.Value And disc4.Visible Then

            If e.Row.item("disc4") <= 0 And e.Row.item("disc4") > 100 Then
                isValid = False
                GV.SetColumnError(disc4, "Harap Mengisi Diskon Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row.item("disc5") Is DBNull.Value And disc5.Visible Then

            If e.Row.item("disc5") <= 0 And e.Row.item("disc5") > 100 Then
                isValid = False
                GV.SetColumnError(disc5, "Harap Mengisi Diskon Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If e.Row.item("harga").ToString = "" And e.Row.item("set") = "0" Then
            isValid = False
            GV.SetColumnError(harga, "Harga Barang Belum Diisi.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Deskripsi").ToString = "Item Not Found" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Mengisi Barang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        'Dim rw() As DataRow = dsete.Tables("SOD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "'")
        'If rw.Count = 1 Then
        '    If Not rw(0) Is e.Row.row Then
        '        isValid = False
        '        GV.SetColumnError(Kd_Stok, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    End If
        'End If
        e.Valid = isValid

    End Sub
    Public Sub call_edit()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        tipetrans = IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum)

        btnadd = False
        btnEdit = False
        ONLOAD_STATE = True

        If Not dsete.Tables("CUSTOMER") Is Nothing Then dsete.Tables("CUSTOMER").Clear()
        If kddep <> "6" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2, Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit, sts_group from SIF.dbo.SIF_Customer where Kd_Customer <> 'INTERNAL' order by Nama_Customer", sqlconn))
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit,sts_group from SIF.dbo.SIF_Customer where Kd_Customer='INTERNAL' order by Nama_Customer", sqlconn))
        End If
        dadbe.Fill(dsete, "CUSTOMER")
        State = "EDIT"
        reload_table(no_sp, tipe_transaksi)
        ONLOAD_STATE = False

        If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
        btnCancel = True
        Me.Enabled = True

        If txtNomor.Text = "" Then
            MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
            cancel_click()
        End If

        ' setStatus()

        setreadonly()
        If btnSave = False Then
            lblState.Text = "LOCKED"
        End If

    End Sub

    Public Sub edit_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        tipetrans = IIf(kddep = KD_DIV_SPRING, SpringUmum, SponUmum)
        If kddep <> "6" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], isPrinted [Telah Dicetak], old_num, last_created_by Owner, Kunci from sales.dbo.[VSO_REP] where tipe_trans ='" & tipetrans & "' and isnull(isClosed,'') ='' order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer] from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and tipe_trans =  'JPJ-KPT-11' and isClosed is null order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        End If
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        'frmCari.GV.FormatConditions(1).Column = frmCari.GV.Columns("Kunci")
        frmCari.GV.Columns(2).Visible = False
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
            btnadd = False
            btnEdit = False
            ONLOAD_STATE = True

            If Not dsete.Tables("CUSTOMER") Is Nothing Then dsete.Tables("CUSTOMER").Clear()
            If kddep <> "6" Then
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2, Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit, sts_group from SIF.dbo.SIF_Customer where Kd_Customer <> 'INTERNAL' order by Nama_Customer", sqlconn))
            Else
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit, sts_group from SIF.dbo.SIF_Customer where Kd_Customer='INTERNAL' order by Nama_Customer", sqlconn))
            End If
            dadbe.Fill(dsete, "CUSTOMER")
            State = "EDIT"
            reload_table(frmCari.row(0), frmCari.row(2))
            ONLOAD_STATE = False

            If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
            btnCancel = True
            Me.Enabled = True

            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
                cancel_click()
            End If

            setStatus()

            If (Not btnSave Or username = "admin") And FORCE_OPEN = "Y" Then
                prn.btnSave.Enabled = True
                GV.OptionsBehavior.Editable = True
                GV.OptionsView.NewItemRowPosition = 0
                For Each item As Object In GV.Columns
                    item.OptionsColumn.ReadOnly = True
                Next
                lblState.Text = "FORCE EDIT"
                GV.Columns("harga").OptionsColumn.ReadOnly = False
                GV.Columns("harga").OptionsColumn.AllowEdit = True
                GV.Columns("harga").OptionsColumn.AllowFocus = True
            End If

            If btnSave = False Then
                lblState.Text = "LOCKED"
            End If
            setreadonly()
            btnSave = True
            setStatus()
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub setreadonly()
        'GV.OptionsBehavior.Editable = btnSave
        'GV.OptionsView.NewItemRowPosition = IIf(btnSave, 2, 0)
        'For Each item As Object In GV.Columns
        'item.OptionsColumn.ReadOnly = False
        'Next
        'GV.Columns("harga").OptionsColumn.AllowFocus = False

        pnlTengahAtas.Enabled = btnSave
        Panel18.Enabled = btnSave
        tglKirim.Properties.ReadOnly = Not btnSave
        tglKirimMarketing.Properties.ReadOnly = Not btnSave
        txtAlamatKirim.Properties.ReadOnly = Not btnSave
        cmdWilayah.Properties.ReadOnly = Not btnSave
        txtKeterangan.Properties.ReadOnly = Not btnSave
        txtNamaPnrm.ReadOnly = Not btnSave
        txtMedia.Properties.ReadOnly = Not btnSave
        'repDel.Buttons(0).Enabled = btnSave
    End Sub
    Public Sub add_click()
        'popCon.Show()
        State = "ADD"
        reload_master()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        btnCetak = False
        setStatus()
        setreadonly()
        txtCustomer.Focus()
        If kddep = "6" Then
            cmbJenisSP.EditValue = "INTERNAL"
            cmbJenisSP.Enabled = False
            vValas.Enabled = False
            txtKurs.Enabled = False
            txtBiaya2.Enabled = False
            txtNamaPnrm.Text = "INTERNAL"
            txtMedia.EditValue = "LANGSUNG"
            txtCustomer.Enabled = False
            txtCustomer.EditValue = "INTERNAL"
        End If
        btnKunci.Appearance.BackColor = Color.Lime
        btnKunci.Text = "BUKA"
        colDel.OptionsColumn.AllowFocus = True
    End Sub
    Public Sub cancel_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        reload_table("XXX", "XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        btnCetak = False
        State = ""

        setStatus()
        Me.Enabled = False
        txtCustomer.EditValue = vbNullString
        txtSales.EditValue = vbNullString
        tglKirimMarketing.EditValue = vbNullString
        tglSO.Text = getTanggal()
        DT_TglSO.EditValue = getTanggal()
        txtCR.EditValue = 0
        txtAlamatKirim.Text = ""
        txtKeterangan.Text = ""
        txtNamaPnrm.Text = ""
        lblTotal.EditValue = Nothing
        txtNomor.Text = ""
        btnKunci.Appearance.BackColor = Color.Lime
        btnKunci.Text = "BUKA"
        reload_master()
        Alamat1.Text = "Pilih Customer Terlebih Dahulu"
        Alamat2.Text = "Pilih Customer Terlebih Dahulu"
        ' prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Sub reload_master()
        If Not dsete.Tables("CUSTOMER") Is Nothing Then dsete.Tables("CUSTOMER").Clear()
        If Not dsete.Tables("SALES") Is Nothing Then dsete.Tables("SALES").Clear()
        If Not dsete.Tables("VALAS") Is Nothing Then dsete.Tables("VALAS").Clear()
        If Not dsete.Tables("AREA") Is Nothing Then dsete.Tables("AREA").Clear()
        If Not dsete.Tables("BIAYA") Is Nothing Then dsete.Tables("BIAYA").Clear()
        If Not dsete.Tables("WILAYAH") Is Nothing Then dsete.Tables("WILAYAH").Clear()
        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()

        If kddep <> "6" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, alias, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2,Alamat3, Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit,sts_group, depostatus from SIF.dbo.SIF_Customer where rec_stat='Y'  and Kd_Customer <> 'INTERNAL' order by Nama_Customer", sqlconn))
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer,nama_customer2, alias, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2,Alamat3,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit, sts_group,depostatus from SIF.dbo.SIF_Customer where rec_stat='Y'and Kd_Customer='INTERNAL' order by Nama_Customer", sqlconn))
        End If

        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where 1=0 and rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [Kode_Valuta] ,[Nama_Valuta] FROM [SIF].[dbo].[SIF_Valuta] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "VALAS")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * FROM [SIF].[dbo].[SIF_Area] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "AREA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select id_data as kd_biaya, Desc_Data as deskripsi from sif.dbo.sif_gen_reff_d where ref_role='SOD' and id_ref_file='BIAYA' and id_ref_data='BIAYA'", sqlconn))
        dadbe.Fill(dsete, "BIAYA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.sif_wilayah where rec_stat='Y' ", sqlconn))
        dadbe.Fill(dsete, "WILAYAH")

        If kddep <> "6" Then
            If State = "ADD" Then
                Dim sqlcmd As New SqlCommand("select  b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar , h.Harga_Rupiah, " & _
                " b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset " & _
                " from SIF.dbo.SIF_Barang as b inner join sif.dbo.sif_harga as h on b.Kode_Barang=h.Kode_Barang " & _
                " inner join ( select kode_barang, max(start_date) start_date from  sif.dbo.sif_harga group by kode_barang ) h2 on h2.Kode_Barang=h.Kode_Barang and h2.Start_Date = h.Start_Date " & _
                " where b.Kd_Depart in ('" & kddep & "','1') and b.rec_stat='Y' and b.kd_jns_persd in ('1','2','3') and @tgl >= h.start_date order  by Nama_Barang", sqlconn)
                sqlcmd.Parameters.Add("@tgl", SqlDbType.Date)
                sqlcmd.Parameters("@tgl").Value = tglSO.EditValue
                dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
            End If
        Else
            Dim sqlcmd As New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, 0 as Harga_Dollar , 0 as Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b where  b.rec_stat='Y' order and b.Kd_Depart in ( '" & IIf(cmbJenisSP.Text = "INTERNAL SPRING", "2", "3") & "','1') and @tgl >= start_date  by Nama_Barang", sqlconn)
            sqlcmd.Parameters.Add("@tgl", SqlDbType.Date)
            sqlcmd.Parameters("@tgl").Value = tglSO.EditValue
            dadbe = New SqlClient.SqlDataAdapter(sqlcmd)

        End If
        dadbe.Fill(dsete, "VBARANG")
    End Sub
    Public Sub delete_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub

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
    Private Sub tglKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglKirimMarketing.EditValueChanged
        tglKirimMarketing.ErrorText = ""
        If tglKirimMarketing.Text <> "" Then
            If tglKirimMarketing.DateTime.DayOfWeek = DayOfWeek.Sunday Then
                tglKirimMarketing.EditValue = DateAdd(DateInterval.Day, 1, tglKirimMarketing.EditValue)
            End If
        End If
    End Sub
    Private Sub txtAlamatKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlamatKirim.EditValueChanged
        DXEP.SetError(txtAlamatKirim, "")
    End Sub
    Private Sub lblTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        lblTotal.ErrorText = ""
    End Sub
    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        call_form_manual("frmBukuOrder")
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" And txtNomor.Text.Length > 10 Then
            Try
                lblState.Text = "PRINTING..."
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                'If i > 0 Then

                callReport(App_Path() & "\report\vSo.rpt", "", "PSO=" & txtNomor.Text, get_set_pinter("SO"), True)
                'Else
                '    MsgBox("Dokumen SP Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                'End If
                lblState.Text = "[IDLE]"
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
                lblState.Text = "[IDLE]"
            End Try
        End If
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandel = e.RowHandle
    End Sub
    'Private Sub txtCustomer_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCustomer.EditValueChanging
    'If ONLOAD_STATE Then Exit Sub
    'If State = "" Then Exit Sub
    'If GV.RowCount > 1 And Not e.NewValue Is Nothing Then
    '    If MessageBox.Show("Mengganti Customer Akan Menghapus Daftar SP" & vbCrLf & "Ganti Customer ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
    '        e.Cancel = True
    '    Else
    'If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
    'If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
    'Dim qty As Double
    'Dim kd_stok As String
    'For i = 0 To GV.RowCount - 1
    '    qty = GV.GetRowCellValue(i, "Qty")
    '    kd_stok = GV.GetRowCellValue(i, "Kd_Stok")
    '    If Not kd_stok Is Nothing Then
    '        GV.SetRowCellValue(i, "Kd_Stok", kd_stok)
    '        GV.SetRowCellValue(i, "Qty", qty)
    '    End If
    'Next
    '    End If
    'End If
    'End Sub
    Private Sub txtSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSales.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.Focus()
            GV.AddNewRow()
        End If
    End Sub
    Private Sub txtSales_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSales.QueryPopUp
        If State <> "ADD" Then
            e.Cancel = True
            showMessages("Tidak Dapat Mengubah Sales")
        End If
    End Sub
    Private Sub cmbJenisSP_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbJenisSP.QueryPopUp
        If State = "ADD" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btnPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromo.Click
        If State = "EDIT" Then
            call_form_manual("frmSOGetPromo")
            coll_form("frmSOGetPromo").NOSO = txtNomor.Text
            coll_form("frmSOGetPromo").reload_table(txtNomor.Text)
        End If
    End Sub
    Private Sub cmbJenisSP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisSP.SelectedIndexChanged

        txtCR.EditValue = 0
        lblStateCR.Text = ""
        tglKirimMarketing.EditValue = Nothing
        tglKirim.EditValue = Nothing
        txtAlamatKirim.Text = ""
        cmdWilayah.EditValue = Nothing
        txtNamaPnrm.Text = ""
        txtKeterangan.Text = ""
        txtBiaya.EditValue = 0
        lblTotal.EditValue = 0
        dsete.Tables("SOB").Rows.Clear()
        If cmbJenisSP.Text = "KONSINYASI" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.Yellow
        ElseIf InStr("INTERNAL", cmbJenisSP.Text, CompareMethod.Text) > 0 Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.GreenYellow
        Else
            cmbJenisSP.Properties.Appearance.BackColor = Color.White
        End If

        ' txtcari.AutoCompleteCustomSource.Clear()
        ' txtcari.AutoCompleteCustomSource.AddRange((From row As Object In dsete.Tables("VBARANG").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub
    Private Sub tglKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglKirimMarketing.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAlamatKirim.Focus()
        End If
    End Sub
    Private Sub txtNamaPnrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaPnrm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub
    Private Sub txtAlamatKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlamatKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNamaPnrm.Focus()
        End If
    End Sub
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            prn.btnSave.Focus()
        End If
    End Sub
    Private Sub gvCari_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvCari.DoubleClick
        If gvCari.GetSelectedRows.Count > 0 Then

            If popCon.Tag = "GV" Then
                If GV.GetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok") Is Nothing Then
                    SendKeys.Send(gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Nama_Barang"))
                Else
                    GV.SetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok", gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                End If
                SendKeys.Send(vbCrLf)
                popCon.Hide()
                GV.Focus()
            Else
                Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
                If x.GetRowCellValue(x.GetSelectedRows(0), "Kd_Stok") Is Nothing Then
                    SendKeys.Send(gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Nama_Barang"))
                Else
                    x.SetRowCellValue(x.GetSelectedRows(0), "Kd_Stok", gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                End If
                popCon.Hide()
                x.Focus()
            End If
        End If
    End Sub
    Private Sub txtcari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang Like '%" & txtcari.Text & "%'")
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
    Private Sub gvCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            gvCari_DoubleClick(sender, New EventArgs)
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
    Private Sub repDes_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDes.ButtonPressed
        If GV.FocusedValue Is Nothing Then Exit Sub
        popDesk.Show()
        txtDesk.Text = GV.FocusedValue.ToString
    End Sub
    Private Sub txtDesk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDesk.Text = "" Then Exit Sub
            GV.GetFocusedDataRow.Item("Deskripsi") = txtDesk.Text
            With New SqlCommand("select count(1) from sif.dbo.sif_barang b, sif.dbo.sif_ukuran u where u.kode_ukuran=b.kd_ukuran and b.kode_barang='" & GV.GetFocusedDataRow.Item("Kd_Stok") & "' and Alias = 'KHS'", sqlconn).ExecuteReader
                Try
                    .Read()
                    If .Item(0) > 0 Then
                        Dim ukuran As String = txtDesk.Text
                        Dim awal, akhir, x As Int32

                        x = InStr(ukuran, " X ", CompareMethod.Text)
                        If x > 0 Then
                            For i = x - 2 To 0 Step -1
                                If ukuran.Chars(i) = " " Then
                                    awal = i + 1
                                    Exit For
                                End If
                            Next
                            For i = x + 2 To ukuran.Length - 1
                                If ukuran.Chars(i) = " " Then
                                    akhir = i
                                    Exit For
                                End If
                            Next
                            If awal > 0 And akhir > 0 Then
                                GV.SetFocusedRowCellValue("Keterangan", ukuran.Substring(awal, akhir - awal))
                            Else
                                GV.SetFocusedRowCellValue("Keterangan", vbNullString)
                            End If
                        Else
                            GV.SetFocusedRowCellValue("Keterangan", vbNullString)
                        End If
                    End If
                    .Close()
                Catch ex As Exception
                    If Not .IsClosed Then .Close()
                    MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
                End Try

            End With
            popDesk.Hide()
            GV.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            popDesk.Hide()
            GV.Focus()
        End If
    End Sub
    Private Sub repDes_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repDes.QueryPopUp
        If GV.FocusedValue Is Nothing Then e.Cancel = True
    End Sub
    Private Sub txtCR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCR.EditValueChanged
        If txtCR.EditValue < 0 Then
            txtCR.Properties.Appearance.ForeColor = Color.Red
            lblStateCR.Text = "Credit Limit Melampuhi Batas"
        Else
            txtCR.Properties.Appearance.ForeColor = Color.Black
            lblStateCR.Text = ""
        End If
    End Sub
    Private Sub btnBatalSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNomor.Text = "" Then Exit Sub

    End Sub
    Private Sub cmdViewStatusSp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewStatusSp.Click
        call_form_manual("frmStatusSP")
    End Sub
    Private Sub vValas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vValas.EditValueChanged
        If ONLOAD_STATE Then Exit Sub
        If vValas.EditValue = "IDR" Then
            txtKurs.Text = "1"
        Else
            txtKurs.Text = ""
        End If
    End Sub
    Private Sub vValas_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles vValas.EditValueChanging
        If ONLOAD_STATE Then Exit Sub
        If GV.RowCount > 1 Then
            If MessageBox.Show("Mengganti Valas Akan Menghapus Daftar SP" & vbCrLf & "Ganti Valas ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            Else
                If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
                If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
                If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()
            End If
        End If
    End Sub
    Private Sub vValas_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vValas.QueryPopUp
        If GV.RowCount > 1 Then
            If State = "ADD" Then
                showMessages("Valas Tidak Bisa Dirubah", , "WARNING")
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtKurs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKurs.GotFocus
        If vValas.EditValue = "IDR" Then
            txtKurs.Properties.ReadOnly = True
        Else
            txtKurs.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub GV_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GV.MasterRowExpanded
        If GV.GetDetailView(e.RowHandle, 0) Is Nothing Then Exit Sub
        If GV.GetRowCellValue(e.RowHandle, "set") = 1 Then
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Else
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        End If
    End Sub
    Private Sub RepPop_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepPop.ButtonClick
        popCon.Show()
    End Sub
    Private Sub RepPop_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepPop.QueryPopUp
        repPopD.PopupControl = Nothing
        RepPop.PopupControl = popCon
        gcCari.DataSource = ""
        txtcari.Text = ""
        popCon.Tag = "GVD"
        'gcCari.DataSource = dsete.Tables("VBARANG")
        gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang = ''")
    End Sub
    Private Sub repPopD_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repPopD.QueryPopUp
        RepPop.PopupControl = Nothing
        repPopD.PopupControl = popCon
        kriteria = Mid(GV.GetRowCellValue(rhandel, "Kd_Stok"), 6, 17)
        clone = New DataView(dsete.Tables("VBARANG"))
        clone.RowFilter = "substring(kode_barang,6,17)= '" & kriteria & "' and isset=0"
        gcCari.DataSource = clone

    End Sub
    Private Sub GVD_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVD.CellValueChanged
        Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim qty As Integer = GV.GetRowCellValue(GV.GetSelectedRows(0), "Qty")
        If e.Column.Name = "Kd_StokD" Then
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            Dim rw As DataRow
            x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
            x.GetRow(e.RowHandle).item("Qty") = qty
            x.GetRow(e.RowHandle).item("total") = 0
            x.GetRow(e.RowHandle).item("potongan") = 0
            rw = drows(0)
            x.GetRow(e.RowHandle).item("Deskripsi") = rw("Nama_Barang")
            x.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            If vValas.EditValue = "IDR" Then
                x.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
                x.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Rupiah").ToString = "", 0, rw("Harga_Rupiah")) * IIf(x.GetRow(e.RowHandle).item("Qty").ToString = "", 0, x.GetRow(e.RowHandle).item("Qty"))
            Else
                x.GetRow(e.RowHandle).item("harga") = rw("Harga_Dollar")
                x.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Dollar").ToString = "", 0, rw("Harga_Dollar")) * IIf(x.GetRow(e.RowHandle).item("Qty").ToString = "", 0, x.GetRow(e.RowHandle).item("Qty"))
            End If


            If cmbJenisSP.Text = "INTERNAL" Then Exit Sub
            'Dim read As SqlDataReader
            'read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
            '                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
            'read.Read()
            'If Not read.HasRows Then
            '    read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
            '                          " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' order by kd_jenis, Ukuran desc", sqlconn).ExecuteReader
            '    read.Read()
            '    read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
            '                         " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' order by kd_jenis, Ukuran desc", sqlconn).ExecuteReader
            '    read.Read()
            'End If
            'If read.HasRows Then
            '    If read.RecordsAffected > 1 And read.Item("Kd_Jenis").ToString = "%%" Then read.Read()
            '    x.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
            '    If read.Item("Diskon1").ToString <> "" Then
            '        x.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
            '    End If
            '    If read.Item("Diskon2").ToString <> "" Then
            '        x.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
            '    End If
            '    If read.Item("Diskon3").ToString <> "" Then
            '        x.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
            '    End If
            '    If read.Item("Diskon4").ToString <> "" Then
            '        x.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
            '    End If
            '    If read.Item("Diskon5").ToString <> "" Then
            '        x.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
            '    End If
            'End If
            'read.Close()
            'read = Nothing

            ''Tes
            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  "b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' order by kd_jenis, Ukuran desc", sqlconn).ExecuteReader
                read.Read()
            End If

            If read.HasRows Then
                GVD.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    GVD.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                Else
                    GVD.GetRow(e.RowHandle).item("disc1") = 0
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    GVD.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                Else
                    GVD.GetRow(e.RowHandle).item("disc2") = 0
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    GVD.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                Else
                    GVD.GetRow(e.RowHandle).item("disc3") = 0
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    GVD.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                Else
                    GVD.GetRow(e.RowHandle).item("disc4") = 0
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    GVD.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                Else
                    GVD.GetRow(e.RowHandle).item("disc5") = 0
                End If
            End If
            read.Close()


            '''''''---------------------------------------------------

            If x.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            Dim Total As Double
            x.GetRow(e.RowHandle).item("total") = x.GetRow(e.RowHandle).item("harga") * qty
            Total = x.GetRow(e.RowHandle).item("total")

            Dim disk1 As Double = 0
            Dim disk2 As Double = 0
            Dim disk3 As Double = 0
            Dim disk4 As Double = 0
            Dim disk5 As Double = 0
            If Total = 0 Then Exit Sub
            If x.GetRow(e.RowHandle).item("disc1").ToString <> "" Then
                disk1 = x.GetRow(e.RowHandle).item("disc1") * Total / 100
            End If
            If x.GetRow(e.RowHandle).item("disc2").ToString <> "" Then
                disk2 = x.GetRow(e.RowHandle).item("disc2") * (Total - disk1) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc3").ToString <> "" Then
                disk3 = x.GetRow(e.RowHandle).item("disc3") * (Total - (disk2 + disk1)) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc4").ToString <> "" Then
                disk4 = x.GetRow(e.RowHandle).item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc5").ToString <> "" Then
                disk5 = x.GetRow(e.RowHandle).item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
            End If
            x.GetRow(e.RowHandle).item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
            x.GetRow(e.RowHandle).Item("total") = x.GetRow(e.RowHandle).Item("total") - x.GetRow(e.RowHandle).Item("potongan_total")
        End If
    End Sub
    Private Sub GVD_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVD.InitNewRow
        Dim x As Grid.GridView = CType(GC.FocusedView, Grid.GridView)
        x.SetRowCellValue(e.RowHandle, "No_seq", x.RowCount)
    End Sub
    Private Sub GVD_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVD.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GVD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVD.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim GVS As Grid.GridView = CType(GC.FocusedView, Grid.GridView)
            Dim i As Int16 = 1
            If GVS.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    GVS.DeleteSelectedRows()
                    For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent = '" & GV.GetRowCellValue(rhandel, "Kd_Stok") & "'")
                        rw("no_seq") = i
                        i += 1
                    Next
                    GV.SetRowCellValue(rhandel, "potongan", CType(GC.FocusedView, Grid.GridView).Columns("potongan").SummaryText)
                    GV.SetRowCellValue(rhandel, "total", CType(GC.FocusedView, Grid.GridView).Columns("total").SummaryText)
                End If
            End If
        End If
    End Sub
    Private Sub GVD_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVD.RowUpdated
        GV.SetRowCellValue(rhandel, "potongan", CType(GC.FocusedView, Grid.GridView).Columns("potongan").SummaryText)
        GV.SetRowCellValue(rhandel, "total", CType(GC.FocusedView, Grid.GridView).Columns("total").SummaryText)
    End Sub
    Private Sub GVD_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVD.ValidateRow
        Dim isValid As Boolean = True
        Dim GVS As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GVS.SetColumnError(Kd_StokD, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GVS.FocusedColumn = Kd_Stok
        End If
        If e.Row.item("harga").ToString = "" Then
            isValid = False
            GVS.SetColumnError(Kd_StokD, "Harga Barang Belum Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GVS.FocusedColumn = HargaD
        End If
        If e.Row.item("Deskripsi").ToString = "Item Not Found" Then
            isValid = False
            GVS.SetColumnError(Kd_StokD, "Harap Mengisi Barang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SODD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "' and kd_parent = '" & e.Row.item("kd_parent") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GVS.SetColumnError(GVS.Columns("Kd_Stok"), "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub txtBiaya_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtBiaya2.ButtonClick
        popBiaya.Show()
    End Sub
    Private Sub GV_Biaya_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_Biaya.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_Biaya_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_Biaya.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_Biaya.SelectedRowsCount > 0 Then
                If GV_Biaya.GetRowCellValue(GV_Biaya.GetSelectedRows(0), "kd_biaya").ToString = "02" Then Exit Sub
                GV_Biaya.DeleteSelectedRows()
                txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
            End If
        End If
    End Sub
    Private Sub GV_Biaya_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_Biaya.RowUpdated
        txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
    End Sub

    Private Sub GV_Biaya_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Biaya.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kd_biaya").ToString = "" Then
            isValid = False
            GV_Biaya.SetColumnError(kd_biaya, "Harap Mengisi Nama Biaya", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("biaya").ToString = "" Then
            isValid = False
            GV_Biaya.SetColumnError(biaya, "Harap Mengisi Besar Biaya", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("biaya") <= 0 Then
            isValid = False
            GV_Biaya.SetColumnError(biaya, "Harap Mengisi Besar Biaya Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SOB").Select("kd_biaya = '" & e.Row.item("kd_biaya") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV_Biaya.SetColumnError(kd_biaya, "Nama Biaya Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub txtBiaya_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiaya.EditValueChanged
        If lblTotal.EditValue Is Nothing Then lblTotal.EditValue = 0
        If txtBiaya.EditValue Is Nothing Then txtBiaya.EditValue = 0
        If lblTotal.EditValue.ToString = "" Then lblTotal.EditValue = 0
        If txtBiaya.EditValue.ToString = "" Then txtBiaya.EditValue = 0
        If Total.SummaryText.ToString = "" Then
            lblTotal.EditValue = 0
            Exit Sub
        End If

        lblTotal.EditValue = Total.SummaryText + CType(txtBiaya.EditValue.ToString, Double)

    End Sub
    Private Sub repDel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDel.ButtonClick
        If GV.GetSelectedRows.Count > 0 Then
            Dim i As Int16 = 1
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each rw As DataRow In dsete.Tables("SODD").Select("No = '" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        rw.Delete()
                    Next
                    GV.DeleteSelectedRows()
                    lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(total)", "")
                    If lblTotal.Text = "" Then
                        lblTotal.EditValue = txtBiaya.EditValue
                    Else
                        lblTotal.EditValue += txtBiaya.EditValue
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub tglKirimMarketing_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tglKirimMarketing.QueryCloseUp
        If tglKirim.EditValue Is Nothing Then
            tglKirim.EditValue = sender.editvalue
        ElseIf tglKirim.EditValue.ToString = "" Then
            tglKirim.EditValue = sender.editvalue
        End If
    End Sub
    Private Sub lblTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.EditValueChanged
        If txtCR.Text = "" Then Exit Sub
        If sender.text = "" Then Exit Sub
        If txtCR.EditValue < sender.editvalue Then
            sender.ForeColor = Color.Red
        Else
            sender.ForeColor = Color.White
        End If
    End Sub
    Private Sub txtcari_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If e.KeyCode = Keys.Enter Then
            gcCari.DataSource = dsete.Tables("VBARANG")
            gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang Like '%" & txtcari.Text & "%'")
            If gvCari.RowCount = 1 Then
                gvCari.Focus()
                gvCari_DoubleClick(gvCari, New EventArgs)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
    Private Sub biaya_packing()
        Dim biaya As Double
        For Each item As DataRow In dsete.Tables("SOD").Rows
            Dim dr2 As SqlDataReader = New SqlCommand("select sif.dbo.sif_ukuran.lebar, kd_jenis from sif.dbo.Sif_barang, sif.dbo.sif_ukuran where kd_ukuran=kode_ukuran and kode_barang='" & item("Kd_Stok") & "'", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                With New SqlCommand("select harga from sif.dbo.sif_biaya_packing where jenis_barang='" & dr2.Item("kd_jenis") & "' and @val between panjang_min and panjang_max", sqlconn)
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@val", dr2.Item("lebar"))
                    With .ExecuteReader
                        Try
                            .Read()
                            If .HasRows Then
                                biaya += .Item(0) * item("Qty")
                            End If
                            .Close()
                        Catch ex As Exception
                            If Not .IsClosed Then .Close()
                            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
                        End Try
                    End With

                End With
            End If
            dr2.Close()
        Next

        With dsete.Tables("SOB").Select("kd_biaya='02'")
            If .Count = 0 Then
                Dim rw As DataRow = dsete.Tables("SOB").NewRow()
                rw("Kd_Cabang") = kdcabang
                rw("No_sp") = txtNomor.Text
                rw("kd_biaya") = "02"
                rw("biaya") = biaya
                rw("Deskripsi") = "Packaging"
                dsete.Tables("SOB").Rows.Add(rw)
            Else
                .ElementAt(0)("biaya") = biaya

            End If
        End With
        txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
    End Sub

    Private Sub repBiaya_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles repBiaya.EditValueChanging
        If e.NewValue = "02" Then
            e.Cancel = True
        ElseIf e.OldValue = "02" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub repNum_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles repNum.EditValueChanging
        If e.OldValue Is Nothing Then Exit Sub
        If GV_Biaya.GetRowCellValue(GV_Biaya.GetSelectedRows(0), "kd_biaya") = "02" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Alamat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Alamat1.Click, Alamat2.Click
        txtAlamatKirim.Text = sender.Text
    End Sub

    Private Sub repBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles repBarang.KeyDown
        If e.KeyCode = Keys.F9 Then
            repBarang.CancelUpdate()
            popCon.Tag = "GV"
            popCon.Show()
            txtcari.Focus()
        End If
    End Sub

    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglSO.Text = DT_TglSO.EditValue
    End Sub

    Private Sub cmbAtasNama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAtasNama.SelectedIndexChanged
        If cmbAtasNama.SelectedIndex < 0 Then Exit Sub
        txtAlamatKirim.Text = PilihAlamat.DropDownItems(cmbAtasNama.SelectedIndex).ToString
    End Sub

    Private Sub btnKunci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunci.Click
        If txtNomor.Text.Length > 10 Then
            Exit Sub
        Else
            If btnKunci.Text = "BUKA" Then
                btnKunci.Appearance.BackColor = Color.Red
                btnKunci.Text = "KUNCI"
            Else
                btnKunci.Appearance.BackColor = Color.Lime
                btnKunci.Text = "BUKA"
            End If
        End If
    End Sub

    Private Sub tglKirim_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglKirim.EditValueChanged
        If tglKirim.Text <> "" Then
            If tglKirim.DateTime.DayOfWeek = DayOfWeek.Sunday Then
                tglKirim.EditValue = DateAdd(DateInterval.Day, 1, tglKirim.EditValue)
            End If
        End If

    End Sub
    Private Sub repQty_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles repQty.Spin
        e.Handled = True
    End Sub

    Private Sub GV_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GV.RowCellClick
        rhandel = e.RowHandle
    End Sub

    Private Sub GV_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV.RowClick
        rhandel = e.RowHandle
    End Sub

    Private Sub GV_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GV.ShowingEditor
        If username.ToUpper = "ADMIN" Then Exit Sub

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        On Error Resume Next

        Dim row As DataRow
        row = view.GetDataRow(view.FocusedRowHandle)
        If Not row Is Nothing Then

            If Not TypeOf row("isLocked") Is DBNull Then
                If row("isLocked") = "1" Then
                    e.Cancel = True
                Else
                    e.Cancel = False
                End If
            Else
                e.Cancel = False
            End If
        Else
            e.Cancel = False
        End If
    End Sub
   
End Class