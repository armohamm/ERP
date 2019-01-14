Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

'lebar di bawah 80 dianggap 80
'lebih dari 80 di up per 10
'contoh	30 = 80
'	82 = 90 

'panjang dibawah 200 dianggap 200
'bila kurang maka di up per 10 
'contoh 	180 = 200
'	203 = 210
Public Class frmSOBOX
    Dim dsete, dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim DAP As SqlDataAdapter
    Dim DABIAYA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = True
    Public State As String
    Public no_sp As String = ""
    Const volume = 0
    Const rumus_vol = "([Qty] * [tebal] *[lebar]*[panjang]) / 1000000"
    Const rumus_vol_up = "([Qty] * [tebal] *[lebar2]*[panjang2]) / 1000000"
    Dim oldTotal As Double = 0
    Dim rhandle As Int16 = -1
    Public isLoading As Boolean = False
    Public tblr As New DataTable
    Dim myBuilder As New SqlCommandBuilder
    'Dim kd_stok_old As String
    Dim dvCustomer As New DataView
    Dim no_seqDelete As String
    Dim rl, r2 As DataRelation

    Public Sub setStatus()
        ' If no_sp <> "" Then Exit Sub
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub
    Public Sub loadTable(ByVal no_sp As String)
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SOBIAYA") Is Nothing Then dsete.Tables("SOBIAYA").Clear()
        lblStateCR.Text = ""
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,(SELECT SUM((HARGA-POTONGAN)*QTY) FROM SALES.DBO.SALES_SOBOX_D WHERE SALES.DBO.SALES_SOBOX_D.NO_SP=Sales.dbo.SALES_SO_D.NO_SP AND Sales.dbo.SALES_SO_D.NO_SEQ=NO_SEQ_D) as total, sales.dbo.isLocked(no_sp, no_seq) isLocked  from Sales.dbo.SALES_SO_D where no_sp='" & no_sp & "' order by len(no_Seq), no_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SOBOX_D where no_sp='" & no_sp & "'", sqlconn))
        DAB.Fill(dsete, "SOB")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where no_sp='" & no_sp & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DABIAYA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_BIAYA where No_sp='" & no_sp & "'", sqlconn))
        DABIAYA.Fill(dsete, "SOBIAYA")
        DAP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, (select nama_promo from sif.dbo.sif_promo where no_promo=a.kd_promo) PROMONAME from Sales.dbo.SALES_SO_D_PROMO a where a.No_sp='" & no_sp & "'", sqlconn))
        DAP.Fill(dsete, "SOP")

        If dsete.Tables("SO").Rows.Count = 0 Then
            State = ""
            txtCustomer.EditValue = vbNullString
            txtSales.EditValue = vbNullString
            txtNomor.Text = ""
            tglSO.Text = ""
            cmdWilayah.EditValue = vbNullString
            tglKirimMarketing.EditValue = vbNullString
            txtCR.EditValue = 0
            txtKeterangan.Text = ""
            txtNamaPnrm.Text = ""
            txtAlamatKirim.Text = ""
            tglKirim.EditValue = vbNullString
            oldTotal = 0
            txtBiaya.EditValue = 0
            cmbJenisSP.EditValue = "UMUM"
            lblTotal.EditValue = 0
            txtMedia.EditValue = vbNullString
            cmbAtasNama.EditValue = vbNullString
            DT_TglSO.EditValue = Nothing
        Else
            Dim row As DataRow = dsete.Tables("SO").Rows(0)
            cmbJenisSP.EditValue = row("Jenis_sp").ToString
            txtCustomer.EditValue = row("Kd_Customer").ToString
            cmbAtasNama.EditValue = txtCustomer.Text
            txtSales.EditValue = row("Kd_sales").ToString
            txtNomor.Text = row("No_sp").ToString
            tglSO.Text = row("Tgl_sp").ToString
            DT_TglSO.EditValue = row("Tgl_sp").ToString
            txtKeterangan.Text = row("Kd_Customer").ToString
            txtNamaPnrm.Text = row("Nama_pnrm").ToString
            txtAlamatKirim.Text = row("Almt_pnrm").ToString
            cmdWilayah.EditValue = row("Kode_Wilayah").ToString
            tglKirimMarketing.EditValue = row("Tgl_Kirim_Marketing")
            tglKirim.EditValue = row("Tgl_Kirim")
            txtBiaya.EditValue = row.Item("Biaya")
            oldTotal = row("JML_RP_TRANS")
            txtMedia.EditValue = row("media")
            txtCR.EditValue = getCreditLimit() + oldTotal
            If txtCR.EditValue <= 0 Then
                lblTotal.ForeColor = Color.Red
            Else
                lblTotal.ForeColor = Color.White
            End If
            lblTotal.EditValue = row("JML_RP_TRANS")
            oldTotal = lblTotal.EditValue
            btnCetak = True

            Dim dr As SqlDataReader = New SqlCommand("select 1 from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planing"
                btnCetak = False
                btnSave = False
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
                btnCetak = False
                btnSave = False
            End If
            dr.Close()

            dr = New SqlCommand("select 1 from sales.dbo.sales_sj where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery"
                btnCetak = False
                btnSave = False
            End If
            dr.Close()


            If username = "admin" Then
                btnCetak = True
                btnSave = True
            End If
            setStatus()
            txtDesk.Text = ""
        End If
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        isi_parameter()
        cmbJenisSP.Properties.Items.Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, nama_customer2,alias, Kd_Customer, Alamat1,Kota1,Alamat2,Kota2,Alamat3,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where rec_stat='Y'and Kd_Customer <> 'INTERNAL' order by Nama_Customer", sqlconn))
        cmbJenisSP.Properties.Items.Add("UMUM")
        cmbJenisSP.Properties.Items.Add("KONSINYASI")
        dadbe.Fill(dsete, "CUSTOMER")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales", sqlconn))
        dadbe.Fill(dsete, "SALES")
        tglSO.Text = getTanggal()
        Dim sqlcmd As New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang, b.nm_jual " & _
                    "from SIF.dbo.SIF_Barang as b where 1=0", sqlconn)

        dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select id_data as kd_biaya, Desc_Data as deskripsi from sif.dbo.sif_gen_reff_d where ref_role='SOD' and id_ref_file='BIAYA' and id_ref_data='BIAYA' ", sqlconn))
        dadbe.Fill(dsete, "BIAYA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * FROM [SIF].[dbo].[SIF_Area] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "AREA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.sif_wilayah where rec_stat='Y' ", sqlconn))
        dadbe.Fill(dsete, "WILAYAH")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_ukuran where rec_stat='Y' and isnull(Tinggi,0) > 0 and isnull(Panjang,0) > 0 and isnull(Lebar,0) > 0 ", sqlconn))
        dadbe.Fill(dsete, "UKURAN")

        repBiaya.DataSource = dsete.Tables("BIAYA")

        loadTable("xxx")
        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        AddHandler dsete.Tables("SOB").RowDeleted, AddressOf refreshNomer2
        GC_Biaya.DataSource = dsete.Tables("SOBIAYA")


        Dim dcolP, dColPROMO(2), dcolC As DataColumn

        ' dcolP(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        'dcolP(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP = dsete.Tables("SOD").Columns("No_seq")

        'dcolC(0) = dsete.Tables("SOB").Columns("kd_Stok")
        'dcolC(1) = dsete.Tables("SOB").Columns("No_sp")
        dcolC = dsete.Tables("SOB").Columns("no_seq_d")

        rl = dsete.Relations.Add("Detail", dcolP, dcolC, False)

        GC.LevelTree.Nodes.Add("Detail", gv2)
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kd_Customer"

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        repbarang.DataSource = dsete.Tables("VBARANG")
        repUkuran.DataSource = dsete.Tables("UKURAN")

        GC.DataSource = dsete.Tables("SOD")
        State = "ADD"

        prn = frmMain
        If no_sp <> "" Then
            isLoading = True
            loadTable(no_sp)
            'isLoading = False
            GV.OptionsView.ColumnAutoWidth = True
        End If
    End Sub
    Private Function getHargaBox(ByVal kdstok As String) As Double
        Dim ds As SqlDataReader = New SqlCommand("select * from sif.dbo.sif_harga_sponbox where kd_customer='" & txtCustomer.EditValue & "' and kd_stok='" & kdstok & "'", sqlconn).ExecuteReader
        Dim ret As Object
        ds.Read()
        If ds.HasRows Then
            ret = ds("harga")
        Else
            ret = -1
        End If
        ds.Close()
        Return ret
    End Function
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In dsete.Tables("SOB").Select("no_seq_d=" & rw.Item("No_seq"))
                    rwd("no_seq_d") = i
                Next
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub
    Private Sub refreshNomer2(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1

        For Each rw As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & no_seqDelete & "'")
            If rw.RowState <> DataRowState.Deleted Then
                rw("No_seq") = i
                i += 1
            End If
        Next

    End Sub
    Public Function getCreditLimit(Optional ByVal btrans As SqlTransaction = Nothing) As Double
        Dim dr As SqlDataReader
        Dim hasil As Double = 0
        If btrans Is Nothing Then
            dr = New SqlCommand("select  isnull( sales.dbo.getCreditLimit2('" & txtCustomer.EditValue & "', 'IDR', '" & kddep & "'),0)", sqlconn).ExecuteReader
        Else
            dr = New SqlCommand("select isnull( sales.dbo.getCreditLimit2('" & txtCustomer.EditValue & "', 'IDR', '" & kddep & "'),0)", sqlconn, btrans).ExecuteReader
        End If
        dr.Read()
        Try
            If dr.HasRows Then hasil = CType(dr(0).ToString, Int64)
        Catch e As Exception
            hasil = 0
        End Try
        dr.Close()
        dr = Nothing
        Return hasil
    End Function
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        txtKdCustomer.Text = sender.editvalue
        If cmbJenisSP.EditValue <> "INTERNAL" Then
            If sender.editvalue <> vbNullString Then
                txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString() & " " & txtCustomer.Properties.GetDataSourceValue("Kota1", txtCustomer.ItemIndex).ToString()
                Alamat1.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
                Alamat2.Text = txtCustomer.Properties.GetDataSourceValue("Alamat2", txtCustomer.ItemIndex).ToString()
                Alamat3.Text = txtCustomer.Properties.GetDataSourceValue("Alamat2", txtCustomer.ItemIndex).ToString()

                If Not isLoading Then
                    If State = "" Then Exit Sub

                    'Dim qty As Double
                    Dim kd_stok As String
                    For i = 0 To GV.RowCount - 1
                        'qty = GV.GetRowCellValue(i, "Qty")
                        kd_stok = GV.GetRowCellValue(i, "Kd_Stok")
                        If Not kd_stok Is Nothing Then
                            GV.SetRowCellValue(i, "Kd_Stok", kd_stok)
                            'GV.SetRowCellValue(i, "Qty", qty)
                        End If
                    Next
                End If

                If Not dsete.Tables("SALES") Is Nothing Then dsete.Tables("SALES").Clear()
                txtSales.EditValue = vbNullString
                Dim area As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString()
                Dim wil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString()
                cmdWilayah.EditValue = wil
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where kode_departemen='" & kddep & "' and kode_wilayah = '" & wil & "' and kode_area ='" & area & "' and rec_stat='Y'", sqlconn))
                dadbe.Fill(dsete, "SALES")
                txtCR.EditValue = getCreditLimit()
                If dsete.Tables("SALES").Rows.Count > 0 And State = "ADD" Then
                    txtSales.EditValue = dsete.Tables("SALES").Rows(0)("Kode_Sales")
                End If
                Dim sqlcmd As New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang, b.nm_jual " & _
                   "from SIF.dbo.SIF_Barang as b, sif.dbo.SIF_Harga_SponBox sb where Kd_Depart='" & kddep & "' and kd_jenis in (select id_data from SIF.dbo.SIF_Gen_Reff_D where ref_role ='SOD' and id_ref_file='BUSAPRICE' and rec_stat='Y') and b.rec_stat='Y' and b.kode_barang=sb.kd_stok and sb.kd_customer = '" & txtCustomer.EditValue & "'", sqlconn)

                dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
                If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()
                dadbe.Fill(dsete, "VBARANG")
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
                txtCR.EditValue = 0
            End If
        Else
            txtAlamatKirim.Text = "X"
            txtSales.EditValue = vbNullString
            cmbAtasNama.EditValue = vbNullString
        End If
        DXEP.SetError(txtKdCustomer, "")
    End Sub
    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        txtNamaSales.Text = sender.editvalue
        DXEP.SetError(txtNamaSales, "")
    End Sub
    Public Sub save_click(Optional ByVal isdelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim isError As Boolean = False
        connect()
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

        If Not isdelete Then
            If DT_TglSO.EditValue Is Nothing Then
                DXEP.SetError(DT_TglSO, "Tanggal Belum Diisi")
                DT_TglSO.Focus()
                isError = True
            End If

            If txtCustomer.EditValue = "" Then
                DXEP.SetError(txtKdCustomer, "Nama Customer Belum Diisi")
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
                    DXEP.SetError(txtAlamatKirim, "Nama Sales Belum Diisi")
                    txtAlamatKirim.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If tglKirim.EditValue Is Nothing Then
                    tglKirim.ErrorText = "Tanggal Kirim Belum Diisi"
                    tglKirim.Focus()
                    isError = True
                End If
            End If
            If GV.RowCount = 0 Then
                lblTotal.ErrorText = "Daftar Barang Masih Kosong"
                lblTotal.Focus()
                isError = True
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                txtCR.EditValue = getCreditLimit()
                lblTotal_EditValueChanged(lblTotal, New EventArgs)
            End If

            Dim i As Int16 = 0
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    If dsete.Tables("SOB").Select("no_seq_d='" & rows("No_Seq") & "'").Count() = 0 Then
                        showMessages("Detail Irisan Blok Masih Ada Yang Kosong", 12, "WARNING")
                        GV.SelectRow(i)
                        GV.ExpandMasterRow(i, "Detail")
                        isError = True
                    End If
                    i += 1
                End If
            Next
        End If
        If isError = True Then
            Exit Sub
        End If
        tglSO.Text = DT_TglSO.EditValue  'getTanggal()
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
            row.Item("Tgl_sp") = DT_TglSO.EditValue  'getTanggal()
            row.Item("Last_Create_Date") = row.Item("Tgl_sp")
            row.Item("Last_Created_By") = username
            row.Item("sts_centi") = "Y"
            tglSO.Text = row.Item("Tgl_sp").ToString
            row.Item("No_sp") = txtNomor.Text
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
        row("JML_RP_TRANS") = lblTotal.EditValue
        row("Valas") = "IDR"
        row("Kurs") = 1
        row("Atas_Nama") = cmbAtasNama.Text
        row("JML_VALAS_TRANS") = lblTotal.EditValue

        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("Tipe_trans") = CentianUmum

        row.Item("Kd_Customer") = txtCustomer.EditValue
        row.Item("Nama_pnrm") = txtNamaPnrm.Text
        row.Item("Almt_pnrm") = txtAlamatKirim.Text
        If Not tglKirim.EditValue Is Nothing Then row.Item("Tgl_Kirim") = tglKirim.EditValue
        If Not tglKirimMarketing.EditValue Is Nothing Then row.Item("Tgl_Kirim_Marketing") = tglKirimMarketing.EditValue
        If Not cmdWilayah.EditValue Is Nothing Then row.Item("Kode_Wilayah") = cmdWilayah.EditValue
        row.Item("Kd_sales") = txtSales.EditValue
        row.Item("Keterangan") = txtKeterangan.Text

        row.Item("Jenis_sp") = cmbJenisSP.EditValue.ToString
        If row.Item("Flag_Ppn").ToString = "Y" And txtNomor.Text.Length > 10 Then
            row.Item("PPn") = (lblTotal.EditValue - txtBiaya.EditValue)
            row.Item("PPn") = row.Item("PPn") - row.Item("PPn") / 1.1
        End If
        row.Item("Total_qty") = Qty.SummaryText
        row.Item("Departement") = kddep
        row.Item("Status") = IIf(frmPaswdOTP.PENDING, "PENDING", "OK")
        row.Item("media") = txtMedia.EditValue
        row.Item("Biaya") = txtBiaya.EditValue
        row.Item("Program_Name") = Me.Name
        row("JML_RP_TRANS") = lblTotal.EditValue
        If row.Item("Flag_Ppn").ToString = "Y" And txtNomor.Text.Length > 10 Then
            row.Item("PPn") = (lblTotal.EditValue - txtBiaya.EditValue) / 10
        End If
        If State = "ADD" Then
            dsete.Tables("SO").Rows.Add(row)
        End If
        Dim a As Integer = 1
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

            myBuilder = New SqlClient.SqlCommandBuilder(DAB)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAB.UpdateCommand = myBuilder.GetUpdateCommand()
            DAB.InsertCommand = myBuilder.GetInsertCommand()
            DAB.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAP)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAP.UpdateCommand = myBuilder.GetUpdateCommand()
            DAP.InsertCommand = myBuilder.GetInsertCommand()
            DAP.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DABIAYA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DABIAYA.UpdateCommand = myBuilder.GetUpdateCommand()
            DABIAYA.InsertCommand = myBuilder.GetInsertCommand()
            DABIAYA.DeleteCommand = myBuilder.GetDeleteCommand()

            If BTRANS Is Nothing Then BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                If kddep = "6" Then
                    txtNomor.Text = getNoTrans("SPSRIT", row.Item("Tgl_sp"), BTRANS)
                Else
                    txtNomor.Text = get_next_So(BTRANS)
                End If
                row.Item("No_sp") = txtNomor.Text
                row.Item("old_num") = txtNomor.Text
            End If
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = tglSO.Text
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = row.Item("Tipe_trans")
                    rows.Item("Status") = "OK"
                    rows.Item("departemen") = kdcabang
                    rows.Item("Programe_name") = Me.Name
                Else
                    If rows.RowState <> DataRowState.Deleted Then
                        rows.Item("Last_Update_Date") = getTanggal(BTRANS)
                        rows.Item("Last_Updated_By") = username
                        rows.Item("Programe_name") = Me.Name
                    End If
                End If


            Next

            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = tglSO.Text
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                Else
                    If rows.RowState <> DataRowState.Deleted Then
                        rows.Item("Last_Update_Date") = getTanggal(BTRANS)
                        rows.Item("Last_Updated_By") = username
                        rows.Item("Programe_name") = Me.Name
                    End If
                End If
            Next

            For Each rows As DataRow In dsete.Tables("SOBIAYA").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows("tipe_trans") = row.Item("Tipe_trans")
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOP").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("NO_SP") = txtNomor.Text
                End If
            Next

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DAB.UpdateCommand.Transaction = BTRANS
            DAB.InsertCommand.Transaction = BTRANS
            DAB.DeleteCommand.Transaction = BTRANS

            DAP.UpdateCommand.Transaction = BTRANS
            DAP.InsertCommand.Transaction = BTRANS
            DAP.DeleteCommand.Transaction = BTRANS

            DABIAYA.UpdateCommand.Transaction = BTRANS
            DABIAYA.InsertCommand.Transaction = BTRANS
            DABIAYA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DAB.Update(dsete.Tables("SOB"))
            DAP.Update(dsete.Tables("SOP"))
            DABIAYA.Update(dsete.Tables("SOBIAYA"))

            ' untuk mengupdate kode ukuran
            'Dim cmd As New SqlCommand
            'cmd.Connection = sqlconn
            'cmd.Transaction = BTRANS
            'cmd.CommandText = "SALES.[dbo].add_ukuran_box"
            'cmd.ExecuteNonQuery()

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
            If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
            DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SOBOX_D where no_sp='" & txtNomor.Text & "'", sqlconn))
            DAB.Fill(dsete, "SOB")
            If Not dsete.Tables("UKURAN") Is Nothing Then dsete.Tables("UKURAN").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_ukuran where rec_stat='Y' and isnull(Tinggi,0) > 0 and isnull(Panjang,0) > 0 and isnull(Lebar,0) > 0 ", sqlconn))
            dadbe.Fill(dsete, "UKURAN")

            GV.CollapseAllDetails()
            loadTable(txtNomor.EditValue)
            lblStatus.Text = "EDIT"
            If btnSave = False Then
                lblStatus.Text = "LOCKED"
            End If
            setreadonly()
            btnSave = True
            setStatus()
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            If e.Value Is Nothing Then Exit Sub
            Dim rw As DataRow
            Dim harga As Double = getHargaBox(e.Value)
            If GV.GetRow(e.RowHandle).item("qty").ToString = "" Then GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("Total") = 0
            GV.GetRow(e.RowHandle).item("potongan") = 0

            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If
            GV.GetRow(e.RowHandle).item("Deskripsi") = rw("nm_jual")
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            'If rw("isset").ToString = "1" Then Exit Sub
            If cmbJenisSP.Text = "INTERNAL" Then
                GV.GetRow(e.RowHandle).item("harga") = 0
                GV.GetRow(e.RowHandle).item("total") = 0
                Exit Sub
            Else
                GV.GetRow(e.RowHandle).item("harga") = harga
                hitung_total()
                'If GV.GetRow(e.RowHandle).item("vol").ToString <> "" Then
                '    GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("vol") * harga
                'Else
                '    GV.GetRow(e.RowHandle).item("total") = 0
                'End If
            End If

            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  " b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' ", sqlconn).ExecuteReader
                read.Read()
            End If
            If read.HasRows Then
                Dim disk1 As Double = 0
                Dim disk2 As Double = 0
                Dim disk3 As Double = 0
                Dim disk4 As Double = 0
                Dim disk5 As Double = 0
                Dim total As Double = 0

                GV.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                    disk1 = GV.GetRow(e.RowHandle).item("disc1") * total / 100
                Else
                    GV.GetRow(e.RowHandle).item("disc1") = 0
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                    disk2 = GV.GetRow(e.RowHandle).item("disc2") * (total - disk1) / 100
                Else
                    GV.GetRow(e.RowHandle).item("disc2") = 0
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                    disk3 = GV.GetRow(e.RowHandle).item("disc3") * (total - (disk2 + disk1)) / 100
                Else
                    GV.GetRow(e.RowHandle).item("disc3") = 0
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                    disk4 = GV.GetRow(e.RowHandle).item("disc4") * (total - (disk1 + disk2 + disk3)) / 100
                Else
                    GV.GetRow(e.RowHandle).item("disc4") = 0
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                    disk5 = GV.GetRow(e.RowHandle).item("disc5") * (total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
                Else
                    GV.GetRow(e.RowHandle).item("disc5") = 0
                End If
                GV.GetRow(e.RowHandle).item("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
                GV.GetRow(e.RowHandle).Item("total") = GV.GetRow(e.RowHandle).Item("total") - GV.GetRow(e.RowHandle).Item("potongan")

            End If
            read.Close()
            If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(GV.GetRowCellValue(e.RowHandle, "Kd_Stok"), 6), 3) = "040" Then
                GV.SetRowCellValue(e.RowHandle, "vol", 1)
            Else
                For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                    rwx("Kd_Stok") = e.Value
                Next
            End If
        ElseIf e.Column Is Qty Or e.Column Is Vol Then
            If GV.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub
            Dim total As Double = 0
            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga") * GV.GetRow(e.RowHandle).item("Qty") * GV.GetRow(e.RowHandle).item("vol")
            total = GV.GetRow(e.RowHandle).item("total")

            Dim disk1 As Double = 0
            Dim disk2 As Double = 0
            Dim disk3 As Double = 0
            Dim disk4 As Double = 0
            Dim disk5 As Double = 0

            If total = 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("disc1").ToString <> "" Then
                disk1 = GV.GetRow(e.RowHandle).item("disc1") * total / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc2").ToString <> "" Then
                disk2 = GV.GetRow(e.RowHandle).item("disc2") * (total - disk1) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc3").ToString <> "" Then
                disk3 = GV.GetRow(e.RowHandle).item("disc3") * (total - (disk2 + disk1)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc4").ToString <> "" Then
                disk4 = GV.GetRow(e.RowHandle).item("disc4") * (total - (disk1 + disk2 + disk3)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc5").ToString <> "" Then
                disk5 = GV.GetRow(e.RowHandle).item("disc5") * (total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
            End If
            GV.GetRow(e.RowHandle).item("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
            GV.GetRow(e.RowHandle).Item("total") = GV.GetRow(e.RowHandle).Item("total") - GV.GetRow(e.RowHandle).Item("potongan")
            'If e.Column Is Qty Then
            ' cariPromo(GV.GetRow(e.RowHandle))
            'End If
        ElseIf e.Column Is tglKirims Then
            If GV.GetRowCellValue(e.RowHandle, "tgl_kirim") Is Nothing Then GV.SetRowCellValue(e.RowHandle, "tgl_kirim", e.Value)
        ElseIf e.Column Is Mark_up Then
            If e.Value.ToString = "Y" Then
                'Total.UnboundExpression = rumus_vol_up
                For Each rows As DataRow In dsete.Tables("SOB").Select("no_seq_d = '" & GV.GetRowCellValue(e.RowHandle, "No_seq").ToString & "'")
                    If rows.RowState <> DataRowState.Deleted Then
                        rows("harga") = GV.GetRowCellValue(rhandle, "harga") * ((rows("lebar_up") * rows("panjang_up") * rows("tebal") / 1000000))
                    End If
                Next
            Else
                'Total.UnboundExpression = rumus_vol
                For Each rows As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(e.RowHandle, "No_seq").ToString & "'")
                    If rows.RowState <> DataRowState.Deleted Then
                        rows("harga") = GV.GetRowCellValue(rhandle, "harga") * ((rows("lebar") * rows("panjang") * rows("tebal") / 1000000))
                    End If
                Next
            End If
            hitung_total()
        End If
        lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(total)", "")
        If lblTotal.Text = "" Then
            lblTotal.EditValue = txtBiaya.EditValue
        Else
            lblTotal.EditValue += txtBiaya.EditValue
        End If
    End Sub
    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If GV.GetRowCellValue(e.RowHandle, "Kd_Stok") Is Nothing Then Exit Sub
        'kd_stok_old = GV.GetRowCellValue(e.RowHandle, "Kd_Stok").ToString

        If e.Column Is Kd_Stok Then
            For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                If rwx.RowState <> DataRowState.Deleted Then
                    rwx.Item("Kd_Stok") = e.Value
                    get_pembulatan(rwx)

                    'If GV.GetRowCellValue(rhandle, "Mark_up").ToString = "" Then
                    '    rwx("harga") = GV.GetRowCellValue(rhandle, "harga") * ((rwx("lebar") * rwx("panjang") * rwx("tebal") / 1000000))
                    'Else
                    '    rwx("harga") = GV.GetRowCellValue(rhandle, "harga") * ((rwx("lebar_up") * rwx("panjang_up") * rwx("tebal") / 1000000))
                    'End If
                    'rwx("potongan") = GV.GetRowCellValue(rhandle, "harga")
                    'hitung_total()
                    ' hitung_total(rwx("harga"), rwx)
                End If
            Next
            GV.SetRowCellValue(e.RowHandle, "Kd_Stok", e.Value)
        End If


    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
        GV.SetRowCellValue(e.RowHandle, "Qty", 1)
        GV.SetRowCellValue(e.RowHandle, "isset", 0)
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv2.CellValueChanged
        'Dim gvd As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Column.Name = "Kode_Ukuran" Then
            With dsete.Tables("UKURAN").Select("Kode_Ukuran='" & e.Value & "'")(0)
                sender.SetRowCellValue(e.RowHandle, "panjang", .Item("Panjang"))
                sender.SetRowCellValue(e.RowHandle, "lebar", .Item("Lebar"))
                sender.SetRowCellValue(e.RowHandle, "tebal", .Item("Tinggi"))
            End With
        ElseIf e.Column.Name = "Qty2" Then
            If e.Value.ToString <> "" Then
                sender.SetRowCellValue(e.RowHandle, "Qty_pak", vbNullString)
            End If
        ElseIf e.Column.Name = "Qty_pak" Then
            If e.Value.ToString <> "" Then
                Dim hasil As Int32
                If GV.GetRowCellValue(rhandle, "Mark_up").ToString = "" Then
                    hasil = e.Value * 1000000 / (sender.GetRowCellValue(e.RowHandle, "panjang") * sender.GetRowCellValue(e.RowHandle, "lebar") * sender.GetRowCellValue(e.RowHandle, "tebal"))
                Else
                    hasil = e.Value * 1000000 / (sender.GetRowCellValue(e.RowHandle, "panjang_up") * sender.GetRowCellValue(e.RowHandle, "lebar_up") * sender.GetRowCellValue(e.RowHandle, "tebal"))
                End If
                sender.SetRowCellValue(e.RowHandle, "Qty", hasil)
            End If
        End If
    End Sub

    Private Sub gv2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv2.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "No_seq", sender.RowCount())
        sender.SetRowCellValue(e.RowHandle, "Kd_Stok", GV.GetRowCellValue(rhandle, "Kd_Stok"))
        'e.Row.rowstate(e.Row.item("No_seq") = sender.RowCount() - 1)

    End Sub
    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Not btnSave Then Exit Sub
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each row In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        row.Delete()
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
    Private Sub gv2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv2.KeyDown
        If e.KeyCode = Keys.Delete Then
            no_seqDelete = gv2.GetRowCellValue(gv2.GetSelectedRows(0), "no_seq_d")
            sender.DeleteSelectedRows()
        End If
    End Sub
    Private Sub GV2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv2.RowUpdated

        Dim sql As String = "Tinggi = '" & e.Row("tebal") & "' and Lebar = '" & e.Row("lebar") & "' and Panjang = '" & e.Row("panjang") & "'"
        Dim x As DataRow() = dsete.Tables("UKURAN").Select(sql)
        If x.Count = 0 Then
            e.Row.item("Kode_Ukuran") = vbNullString
        Else
            e.Row.item("Kode_Ukuran") = x(0)("Kode_Ukuran").ToString
        End If
        e.Row.item("Qty_Asli") = e.Row.item("Qty")

        'If e.Row("panjang") > batas_up_panjang Then
        '    e.Row("panjang_up") = e.Row("panjang") 'IIf(e.Row("panjang") Mod 10 = 0, e.Row("panjang"), (e.Row("panjang") - e.Row("panjang") Mod 10) + up_panjang)
        'Else
        '    e.Row("panjang_up") = batas_up_panjang
        'End If

        ' sementara manual dulu
        get_pembulatan(e)
        'If e.Row("lebar") > batas_up_lebar Then
        '    get_pembulatan(e)
        '    'IIf(e.Row("lebar") Mod 10 = 0, e.Row("lebar"), (e.Row("lebar") - e.Row("lebar") Mod 10) + up_lebar)
        'Else
        '    e.Row("lebar_up") = batas_up_lebar
        'End If
        If GV.GetRowCellValue(rhandle, "Mark_up").ToString = "" Then
            e.Row("harga") = GV.GetRowCellValue(rhandle, "harga") * ((e.Row("lebar") * e.Row("panjang") * e.Row("tebal") / 1000000))
        Else
            e.Row("harga") = GV.GetRowCellValue(rhandle, "harga") * ((e.Row("lebar_up") * e.Row("panjang_up") * e.Row("tebal") / 1000000))
        End If
        'e.Row("potongan") = GV.GetRowCellValue(rhandle, "harga")
        If e.Row("lebar") < batas_lebar Or e.Row("panjang") < batas_panjang Or e.Row("tebal") < batas_tebal Then
            If charge > 0 Then e.Row("charge") = charge / 100 * e.Row("harga")
            e.Row("harga") = e.Row("harga") + e.Row("charge")
        End If

        hitung_total()
        hitung_total(e.Row("harga"), e)
    End Sub

    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv2.ValidateRow
        Dim isValid As Boolean = True
        'Dim GVS As DevExpress.XtraGrid.Views.Grid.GridView = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        set_tebal_lebar(sender, e)
        If e.Row.item("tebal").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("tebal") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("lebar").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("lebar"), "Harap Mengisi Jumlah Lebar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("lebar") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("lebar"), "Harap Mengisi Jumlah Lebar Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("panjang").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("panjang"), "Harap Mengisi Jumlah Panjang.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("panjang") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("panjang"), "Harap Mengisi Jumlah Panjang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("tebal").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("tebal") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty_pak").ToString <> "" Then
            If e.Row.item("Qty_pak") < 0 Then
                isValid = False
                sender.SetColumnError(sender.Columns("Qty_pak"), "Harap Mengisi Jumlah Pak Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If e.Row.item("Qty").ToString <> "" Then
            If e.Row.item("Qty") < 0 Then
                isValid = False
                sender.SetColumnError(sender.Columns("Qty"), "Harap Mengisi Jumlah Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        Else
            isValid = False
            sender.SetColumnError(sender.Columns("Qty"), "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        e.Valid = isValid
    End Sub
    Private Sub set_tebal_lebar(ByVal sender As Object, ByVal e As Object)
        Exit Sub
        If (e.RowHandle < 0 And sender.RowCount > 1) Or e.RowHandle > 0 Then
            With sender.GetRow(0)
                sender.SetRowCellValue(e.RowHandle, "panjang", .item("panjang"))
                sender.SetRowCellValue(e.RowHandle, "lebar", .item("lebar"))
            End With
            sender.FocusedColumn = sender.Columns("tebal")
        ElseIf e.RowHandle = 0 And sender.RowCount > 1 Then
            For i As Int16 = 1 To sender.RowCount - 2
                With sender.GetRow(0)
                    sender.SetRowCellValue(i, "panjang", .item("panjang"))
                    sender.SetRowCellValue(i, "lebar", .item("lebar"))
                End With
            Next
        End If
    End Sub

    Private Sub GV_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GV.MasterRowExpanding

        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(GV.GetRowCellValue(e.RowHandle, "Kd_Stok"), 6), 3) = "040" Then
            e.Allow = False
        End If
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        Dim tot As Double = 0
        For Each rw As DataRow In dsete.Tables("SOD").Rows
            If rw.RowState <> DataRowState.Deleted Then tot += rw("total")
        Next
        cariPromo(e.Row.row)
        GV.ExpandMasterRow(GV.GetSelectedRows(0), "Detail")
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty") < 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("harga").ToString = "" Then
            isValid = False
            GV.SetColumnError(harga, "Harap Mengisi Harga Barang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
    Public Sub setreadonly()
        'GV.OptionsBehavior.Editable = btnSave
        'GV.OptionsView.NewItemRowPosition = IIf(btnSave, 1, 0)
        Panel5.Enabled = btnSave
        tglKirim.Properties.ReadOnly = Not btnSave
        tglKirimMarketing.Properties.ReadOnly = Not btnSave
        txtAlamatKirim.Properties.ReadOnly = Not btnSave
        cmdWilayah.Properties.ReadOnly = Not btnSave
        txtKeterangan.Properties.ReadOnly = Not btnSave
        txtNamaPnrm.ReadOnly = Not btnSave
        txtMedia.Properties.ReadOnly = Not btnSave
        ' repDelD.Buttons(0).Enabled = btnSave
        'repSim.Buttons(0).Enabled = btnSave
        'repSim.Buttons(1).Enabled = btnSave
    End Sub
    Public Sub add_click()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        btnCetak = False
        State = "ADD"
        setStatus()
        setreadonly()
        If kddep = "6" Then
            cmbJenisSP.EditValue = "INTERNAL"
            cmbJenisSP.Enabled = False
            txtBiaya2.Enabled = False
            txtNamaPnrm.Text = "INTERNAL"
            txtMedia.EditValue = "LANGSUNG"
            txtCustomer.Enabled = False
            txtCustomer.EditValue = "INTERNAL"
        End If
        txtCustomer.Focus()
        DT_TglSO.EditValue = getTanggal()

    End Sub
    Public Sub cancel_click()
        State = ""
        GV.CollapseAllDetails()
        loadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnCetak = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        Alamat1.Text = "Pilih Customer Terlebih Dahulu"
        Alamat2.Text = "Pilih Customer Terlebih Dahulu"
    End Sub
    Private Sub tglKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglKirim.EditValueChanged
        tglKirim.ErrorText = ""
    End Sub
    Private Sub txtCustomer_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCustomer.EditValueChanging
        If isLoading Then
            Exit Sub
        End If
        If State = "EDIT" Then
            e.Cancel = True
            showMessages("Tidak Boleh Mengganti Customer", , "WARNING")
            Exit Sub
        End If

        If GV.RowCount > 0 Then
            If MessageBox.Show("Mengganti Customer Akan Menghapus Daftar SP" & vbCrLf & "Ganti Customer ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            Else
                If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
                If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()

                lblTotal.EditValue = txtBiaya.EditValue
            End If
        End If
    End Sub
    'Private Sub txtCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtSales.Focus()
    '    End If
    'End Sub
    Private Sub txtSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSales.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.Focus()
            GV.AddNewRow()
        End If
    End Sub
    Private Sub tglKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAlamatKirim.Focus()
        End If
    End Sub
    Private Sub txtNamaPnrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub
    Private Sub txtAlamatKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtNamaPnrm.Focus()
        End If
    End Sub
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            prn.btnSave.Focus()
        End If
    End Sub
    Public Sub call_edit()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub

        If kddep <> "6" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], old_num from sales.dbo.[VSO_REP] where tipe_trans = '" & CentianUmum & "' and isClosed is null order by old_num ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], old_num from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and tipe_trans =  'JPJ-KPT-11' and isClosed is null order by old_num ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        End If

        isLoading = True
        loadTable(no_sp)
        isLoading = False
        State = "EDIT"
        If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
        btnadd = False
        btnEdit = False
        btnCancel = True
        Me.Enabled = True
        setStatus()
        setreadonly()
        If btnSave = False Then
            lblStatus.Text = "LOCKED"
        End If
    End Sub
    Public Sub edit_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub

        If kddep <> "6" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], old_num from sales.dbo.[VSO_REP] where tipe_trans = '" & CentianUmum & "' and isnull(isClosed,'') ='' order by old_num ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer], old_num from sales.dbo.[VSO_REP] where [Departement]='" & kddep & "' and tipe_trans =  'JPJ-KPT-11' and isClosed is null order by old_num ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        End If

        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
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
            isLoading = True
            loadTable(frmCari.row(0))
            isLoading = False
            State = "EDIT"
            If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
            btnCancel = True
            Me.Enabled = True
            setStatus()
            setreadonly()
            btnSave = True
            setStatus()
            If btnSave = False Then
                lblStatus.Text = "LOCKED"
            End If
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub txtCustomer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCustomer.QueryPopUp
        If State <> "ADD" Then
            e.Cancel = True
            showMessages("Tidak Dapat Mengubah Customer")
        End If
    End Sub
    Private Sub txtCR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCR.EditValueChanged
        If txtCR.EditValue < 0 Then
            txtCR.Properties.Appearance.ForeColor = Color.Red
            lblStateCR.Text = "Credit Limit Melampui Batas"
        Else
            txtCR.Properties.Appearance.ForeColor = Color.Black
            lblStateCR.Text = ""
        End If
    End Sub
    Private Sub repket_ButtonClick1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repket.ButtonClick
        If GV.FocusedValue Is Nothing Then Exit Sub
        popDesk.Show()
        txtDesk.Text = GV.FocusedValue.ToString
    End Sub
    Private Sub txtDesk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDesk.Text = "" Then Exit Sub
            GV.GetFocusedDataRow.Item("Deskripsi") = txtDesk.Text
            popDesk.Hide()
            GV.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            popDesk.Hide()
            GV.Focus()
        End If
    End Sub
    Private Function getdataTable(ByVal i As Integer, ByVal rel As Integer) As DataTable
        Dim tbl As New DataTable
        Dim rw As DataRow
        tbl.Columns.Add("T", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("L", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("P", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("%", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("V", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("J", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("Q", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("QR", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("QQ", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("Kode_Ukuran", System.Type.GetType("System.String"))
        tbl.Columns.Add("L_UP", System.Type.GetType("System.Decimal"))
        tbl.Columns.Add("P_UP", System.Type.GetType("System.Decimal"))
        For Each rws As DataRow In dsete.Tables("SOB").Select("no_seq_d = '" & GV.GetRowCellValue(i, "No_seq") & "'")
            rw = tbl.NewRow()
            rw("T") = rws("tebal")
            rw("L") = rws("lebar")
            rw("P") = rws("panjang")
            rw("Q") = rws("Qty")
            rw("QR") = rws("Qty")
            rw("Kode_Ukuran") = rws("Kode_Ukuran")
            rw("L_UP") = rws("lebar_up")
            rw("P_UP") = rws("panjang_up")
            tbl.Rows.Add(rw)
        Next

        Return tbl
    End Function
    Private Sub repSim_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repSim.ButtonClick

        If e.Button.Tag = "H" Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each row In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        row.Delete()
                    Next
                    GV.DeleteSelectedRows()
                    lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(total)", "")
                    If lblTotal.EditValue = 0 Then
                        lblTotal.EditValue = txtBiaya.EditValue
                    Else
                        lblTotal.EditValue += txtBiaya.EditValue
                    End If
                End If
            End If
        Else
            Dim i As Int16 = rhandle
            If Not frmSimulasi.tbl Is Nothing Then frmSimulasi.tbl.Clear()
            frmSimulasi.tbl = getdataTable(i, 0)
            frmSimulasi.lblBox.Text = GV.GetRowCellDisplayText(i, "Kd_Stok")
            frmSimulasi.lblQty.Text = GV.GetRowCellValue(i, "Qty")
            frmSimulasi.ShowDialog()
            If frmSimulasi.ret Then
                'Dim rw As DataRow
                Dim vol3 As Double = 0
                For Each rws As DataRow In frmSimulasi.tbl.Rows
                    For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d = '" & GV.GetRowCellValue(i, "No_seq") & "'")
                        If (rwx("tebal") & "-" & rwx("lebar") & "-" & rwx("panjang")) = (rws("T") & "-" & rws("L") & "-" & rws("P")) Then
                            'If rwx("Kode_Ukuran") = rws("Kode_Ukuran") Then
                            rwx("Qty") = IIf(rws("QQ").ToString = "", rws("Q"), rws("QQ"))
                            If State = "EDIT" Then rwx("No_sp") = txtNomor.Text
                            rwx("Kd_Cabang") = kdcabang
                            vol3 += rwx("tebal") * rwx("lebar") * rwx("panjang") * rwx("Qty")
                            Exit For

                        End If
                    Next
                Next
                If vol3 > 0 Then
                    GV.SetRowCellValue(rhandle, "vol", vol3 / 1000000)
                Else
                    GV.SetRowCellValue(rhandle, "vol", 0)
                End If
            End If
        End If
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
                GV_Biaya.DeleteSelectedRows()
                txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
            End If
        End If
    End Sub
    Private Sub GV_Biaya_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_Biaya.RowUpdated
        txtBiaya.EditValue = dsete.Tables("SOBIAYA").Compute("sum(biaya)", "")
    End Sub
    Private Sub txtBiaya_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiaya.EditValueChanged
        If lblTotal.EditValue Is Nothing Then lblTotal.EditValue = 0
        If txtBiaya.EditValue Is Nothing Then txtBiaya.EditValue = 0
        If total2.SummaryText.ToString = "" Then
            lblTotal.EditValue = 0
            Exit Sub
        End If
        lblTotal.EditValue = total2.SummaryText + txtBiaya.EditValue
    End Sub
    Sub cariPromo(ByVal e As Object)
        Exit Sub
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
            If txtNomor.Text <> "" Then rr("NO_SP") = txtNomor.Text
            dsete.Tables("SOP").Rows.Add(rr)
        End While
        dr.Close()
        dr = Nothing
    End Sub
    Private Sub cmbJenisSP_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cmbJenisSP.EditValueChanging
        'If isLoading Then Exit Sub
        'If State = "" Then Exit Sub
        'If kddep <> "6" And e.NewValue = "INTERNAL" Then
        '    e.Cancel = True
        '    Exit Sub
        'End If
        'If GV.RowCount > 0 Then
        '    If MessageBox.Show("Mengganti Jenis SP Akan Menghapus Daftar SP" & vbCrLf & "Ganti Jenis SP ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
        '        e.Cancel = True
        '    Else
        '        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        '        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        '    End If
        'End If
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

        If cmbJenisSP.Text = "KONSINYASI" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.Yellow
        ElseIf cmbJenisSP.Text = "INTERNAL" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.GreenYellow
        Else
            cmbJenisSP.Properties.Appearance.BackColor = Color.White
        End If
    End Sub
    Private Sub tglKirimMarketing_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tglKirim.EditValue Is Nothing Then tglKirim.EditValue = sender.editvalue
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" And txtNomor.Text.Length > 10 Then
            Try
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                If i > 0 Then
                    callReport(App_Path() & "\report\cSoBox.rpt", "", "PSO=" & txtNomor.Text, get_set_pinter("SO"), True)
                Else
                    MsgBox("Dokumen Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                End If
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
            End Try
        End If
    End Sub
    Private Sub lblTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.EditValueChanged
        If txtCR.EditValue = 0 Then Exit Sub
        If sender.EditValue = 0 Then Exit Sub
        If txtCR.EditValue > 0 Then
            If txtCR.EditValue < sender.EditValue Then
                sender.ForeColor = Color.Red
            Else
                sender.ForeColor = Color.White
            End If
        End If
    End Sub
    Private Sub repDelD_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDelD.ButtonClick
        ' perlu perbaikan lebih lanjut
        Dim gvs As DevExpress.XtraGrid.Views.Grid.GridView = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If gvs.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                no_seqDelete = gvs.GetRowCellValue(gvs.GetSelectedRows(0), "no_seq_d")
                gvs.DeleteSelectedRows()
                hitung_total()

                'For i As Int16 = 0 To gvs.RowCount - 1
                '    gvs.SetRowCellValue(i, "No_seq", i + 1)
                'Next
            End If
        End If
    End Sub
    Private Sub hitung_total()

        Dim volum As Double = 0
        Dim harga As Double = 0

        If GV.GetRowCellValue(rhandle, "Mark_up") Is Nothing Then Exit Sub
        If GV.GetRowCellValue(rhandle, "Mark_up").ToString = "" Then
            For Each row As DataRow In dsete.Tables("SOB").Select("no_seq_d=" & GV.GetRowCellValue(rhandle, "No_seq"))
                If row.RowState <> DataRowState.Deleted Then
                    If "0" & row("qty").ToString > 0 Then volum += row("qty") * row("panjang") * row("lebar") * row("tebal")
                End If
            Next
        Else
            For Each row As DataRow In dsete.Tables("SOB").Select("no_seq_d=" & GV.GetRowCellValue(rhandle, "No_seq"))
                If row.RowState <> DataRowState.Deleted Then
                    If "0" & row("qty").ToString > 0 Then volum += row("qty") * row("panjang_up") * row("lebar_up") * row("tebal")
                End If
            Next
        End If

        

        If volum > 0 Then
            GV.SetRowCellValue(rhandle, "vol", volum / 1000000)
        Else
            GV.SetRowCellValue(rhandle, "vol", 0)
        End If

        '-- cari diskonnya
        If GV.GetRow(rhandle).item("harga").ToString = "" Then Exit Sub
        Dim total As Double = 0
        'GV.GetRow(rhandle).item("total") = GV.GetRow(rhandle).item("harga") * GV.GetRow(rhandle).item("Qty") * GV.GetRow(rhandle).item("vol")
        If Not GV.GetDetailView(rhandle, 0) Is Nothing Then
            For i As Int16 = 0 To GV.GetDetailView(rhandle, 0).RowCount - 1
                If Not GV.GetDetailView(rhandle, 0).GetRow(i) Is Nothing Then
                    With GV.GetDetailView(rhandle, 0).GetRow(i)
                        If GV.GetRowCellValue(rhandle, "Mark_up").ToString = "" Then
                            .item("harga") = GV.GetRowCellValue(rhandle, "harga") * ((.item("lebar") * .item("panjang") * .item("tebal") / 1000000))
                        Else
                            .item("harga") = GV.GetRowCellValue(rhandle, "harga") * ((.item("lebar_up") * .item("panjang_up") * .item("tebal") / 1000000))
                        End If
                        If .item("lebar") < batas_lebar Or .item("panjang") < batas_panjang Or .item("tebal") < batas_tebal Then
                            If charge > 0 Then .item("charge") = charge / 100 * .item("harga")
                            .item("harga") = .item("harga") + .item("charge")
                        End If
                        total = total + .item("harga") * .item("Qty")
                    End With
                End If

            Next
        Else
            total = 0
        End If
        GV.GetRow(rhandle).item("total") = total

        Dim disk1 As Double = 0
        Dim disk2 As Double = 0
        Dim disk3 As Double = 0
        Dim disk4 As Double = 0
        Dim disk5 As Double = 0

        If total = 0 Then Exit Sub
        If GV.GetRow(rhandle).item("disc1").ToString <> "" Then
            disk1 = GV.GetRow(rhandle).item("disc1") * total / 100
        End If
        If GV.GetRow(rhandle).item("disc2").ToString <> "" Then
            disk2 = GV.GetRow(rhandle).item("disc2") * (total - disk1) / 100
        End If
        If GV.GetRow(rhandle).item("disc3").ToString <> "" Then
            disk3 = GV.GetRow(rhandle).item("disc3") * (total - (disk2 + disk1)) / 100
        End If
        If GV.GetRow(rhandle).item("disc4").ToString <> "" Then
            disk4 = GV.GetRow(rhandle).item("disc4") * (total - (disk1 + disk2 + disk3)) / 100
        End If
        If GV.GetRow(rhandle).item("disc5").ToString <> "" Then
            disk5 = GV.GetRow(rhandle).item("disc5") * (total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
        End If
        GV.GetRow(rhandle).item("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
        GV.GetRow(rhandle).Item("total") = GV.GetRow(rhandle).Item("total") - GV.GetRow(rhandle).Item("potongan")

        lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(total)", "")
        If lblTotal.Text = "" Then
            lblTotal.EditValue = txtBiaya.EditValue
        Else
            lblTotal.EditValue += txtBiaya.EditValue
        End If
    End Sub
    Private Sub hitung_total(ByVal total As Double, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)

        Dim disk1 As Double = 0
        Dim disk2 As Double = 0
        Dim disk3 As Double = 0
        Dim disk4 As Double = 0
        Dim disk5 As Double = 0

        If total = 0 Then Exit Sub
        If GV.GetRow(rhandle).item("disc1").ToString <> "" Then
            disk1 = GV.GetRow(rhandle).item("disc1") * total / 100
        End If
        If GV.GetRow(rhandle).item("disc2").ToString <> "" Then
            disk2 = GV.GetRow(rhandle).item("disc2") * (total - disk1) / 100
        End If
        If GV.GetRow(rhandle).item("disc3").ToString <> "" Then
            disk3 = GV.GetRow(rhandle).item("disc3") * (total - (disk2 + disk1)) / 100
        End If
        If GV.GetRow(rhandle).item("disc4").ToString <> "" Then
            disk4 = GV.GetRow(rhandle).item("disc4") * (total - (disk1 + disk2 + disk3)) / 100
        End If
        If GV.GetRow(rhandle).item("disc5").ToString <> "" Then
            disk5 = GV.GetRow(rhandle).item("disc5") * (total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
        End If

        e.Row("potongan") = disk1 + disk2 + disk3 + disk4 + disk5
    End Sub
    Private Sub txtAlamatKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlamatKirim.EditValueChanged
        DXEP.SetError(txtAlamatKirim, "")
    End Sub

    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglKirim.Properties.MinValue = DT_TglSO.EditValue
        tglKirimMarketing.Properties.MinValue = DT_TglSO.EditValue
    End Sub

    Private Sub cmbAtasNama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAtasNama.SelectedIndexChanged
        If cmbAtasNama.SelectedIndex < 0 Then Exit Sub
        txtAlamatKirim.Text = PilihAlamat.DropDownItems(cmbAtasNama.SelectedIndex).ToString
    End Sub
    Private Sub repDeske_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDeske.ButtonClick
        If GV.FocusedValue Is Nothing Then Exit Sub
        popDesk.Show()
        txtDesk.Text = GV.FocusedValue.ToString
    End Sub
    Private Sub repnum2_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles repNum2.Spin
        e.Handled = True
    End Sub
    Private Sub repnum_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles repNum.Spin
        e.Handled = True
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
    Private Sub GVD_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gv2.ShowingEditor
        If username.ToUpper = "ADMIN" Then Exit Sub

        On Error Resume Next

        Dim row As DataRow
        row = GV.GetDataRow(rhandle)
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