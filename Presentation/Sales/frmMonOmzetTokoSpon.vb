Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonOmzetTokoSpon
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim max_col As Int16
    Dim m As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Dim gb As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Dim target As Double = 1000000
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmMntOmzetToko_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        dsete.Tables.Add("Hasil")
        dsete.Tables("Hasil").Columns.Add("Tanggal")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales, Kode_Wilayah, Kode_Area from SIF.dbo.SIF_Sales where kode_departemen='" & KD_DIV_SPON & "' union select 'ALL','%%','',''", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where 1=0", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        txtCustomer.Properties.DataSource = dsete.Tables("Customer")

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        Dim dr As SqlDataReader = New SqlCommand("select [kd_jns_brg] ,[Nama_Jenis] FROM [SIF].[dbo].[SIF_Jenis_Barang] where [Kd_Jns_Persd]='1' and [Kd_Departemen]='3'", sqlconn).ExecuteReader
        While dr.Read
            dsete.Tables("Hasil").Columns.Add(dr(0)).DataType = System.Type.GetType("System.Decimal")
            dsete.Tables("Hasil").Columns.Add(dr(0) & "_kum").DataType = System.Type.GetType("System.Decimal")
            dsete.Tables("Hasil").Columns.Add(dr(0) & "_pro").DataType = System.Type.GetType("System.Decimal")
        End While
        dr.Close()

        m.FieldName = "Tanggal"
        m.Caption = "Tgl"
        m.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        m.Visible = True
        GV.Bands(0).Columns.Add(m)
        dr = New SqlCommand("select [kd_jns_brg] ,[Nama_Jenis] FROM [SIF].[dbo].[SIF_Jenis_Barang] where [Kd_Jns_Persd]='1' and [Kd_Departemen]='3'", sqlconn).ExecuteReader
        While dr.Read
            gb = GV.Bands.Add()
            gb.Tag = dr(0)
            gb.ToolTip = dr(1)
            gb.Caption = dr(1)
            gb.AppearanceHeader.Font = GridBand1.AppearanceHeader.Font
            gb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            gb.AppearanceHeader.ForeColor = Color.Black

            m = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
            m.Visible = True
            m.Caption = "%"
            m.FieldName = dr(0) & "_pro"
            m.ColumnEdit = repProg
            m.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            m.DisplayFormat.FormatString = "n2"
            gb.Columns.Insert(0, m)

            m = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
            m.Visible = True
            m.Caption = "Kumulatif"
            m.FieldName = dr(0) & "_kum"
            m.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            m.DisplayFormat.FormatString = "n2"
            gb.Columns.Insert(0, m)

            m = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
            m.Visible = True
            m.Caption = "Omzet"
            m.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            m.DisplayFormat.FormatString = "n2"
            m.FieldName = dr(0)
            gb.Columns.Add(m)
        End While
        dr.Close()

        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()

    End Sub
    Public Sub add_click()

    End Sub

    Sub reloadTable(ByVal sales As String, ByVal customer As String, ByVal periode As String)

        ' select distinct kode_merk from sif.dbo.sif_barang, sales

        Dim rw, rwt As DataRow
        Dim temp, last As Double
        Dim dr As SqlDataReader

        If rLingkup.EditValue = "G" Then
            For i As Int16 = 1 To GV.Bands.Count - 1
                dr = New SqlCommand("select target from [SALES].[dbo].[SALES_TARGET_SALES] where [kd_sales] = '" & txtSales.EditValue & "' and ([thn_buku] + [bln_buku]) = '" & txtTahun.DateTime.ToString("yyyyMM") & "' and [kd_jenis] = '" & GV.Bands(i).Tag & "'", sqlconn).ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    GV.Bands(i).Tag = dr(0)
                    GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target " & dr(0).ToString & " )"
                Else
                    GV.Bands(i).Tag = "~"
                    GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target n/a )"
                End If
                dr.Close()
            Next
        Else
            For i As Int16 = 1 To GV.Bands.Count - 1
                dr = New SqlCommand("select target from [SALES].[dbo].[SALES_TARGET_TOKO] where [kd_sales] = '" & txtSales.EditValue & "' and ([thn_buku] + [bln_buku]) = '" & txtTahun.DateTime.ToString("yyyyMM") & "' and [kd_jenis] = '" & GV.Bands(i).Tag & "' and [kd_customer]='" & txtCustomer.EditValue & "'", sqlconn).ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    GV.Bands(i).Tag = dr(0)
                    GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target " & dr(0).ToString & " )"
                Else
                    dr = New SqlCommand("select target from [SALES].[dbo].[SALES_TARGET_SALES] where [kd_sales] = '" & txtSales.EditValue & "' and ([thn_buku] + [bln_buku]) = '" & txtTahun.DateTime.ToString("yyyyMM") & "' and [kd_jenis] = '" & GV.Bands(i).Tag & "'", sqlconn).ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        GV.Bands(i).Tag = dr(0)
                        GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target " & dr(0).ToString & " )"
                    Else
                        GV.Bands(i).Tag = "~"
                    End If
                End If
                dr.Close()
            Next
        End If
        dsete.Tables(0).Rows.Clear()
        Dim max_day As Int16 = Date.DaysInMonth(txtTahun.DateTime.Year, txtTahun.DateTime.Month)
        For i As Int16 = 1 To max_day
            rw = dsete.Tables("Hasil").NewRow
            rw("Tanggal") = VisualBasic.Right("0" & i, 2)
            dsete.Tables("Hasil").Rows.Add(rw)
            pw.Refresh()
        Next
        GC.DataSource = dsete.Tables(0)

        rwt = dsete.Tables(0).NewRow
        For Each rw In dsete.Tables(0).Rows
            For Each col As DataColumn In dsete.Tables(0).Columns
                pw.Refresh()
                If col.ColumnName <> "Tanggal" Then
                    If VisualBasic.Right(col.ColumnName, 3) = "kum" Or VisualBasic.Right(col.ColumnName, 3) = "pro" Then
                        If VisualBasic.Right(col.ColumnName, 3) = "kum" Then
                            If rwt("Tanggal").ToString = "" Then
                                rw(col.ColumnName) = temp
                            Else
                                rw(col.ColumnName) = temp + rwt(col.ColumnName)
                            End If
                            last = rw(col.ColumnName)
                        Else
                            If GV.Columns(col.ColumnName).OwnerBand.Tag.ToString <> "~" Then
                                target = GV.Columns(col.ColumnName).OwnerBand.Tag
                                rw(col.ColumnName) = last * 100 / target
                            Else
                                rw(col.ColumnName) = "0"
                            End If

                        End If

                    Else
                        Dim sql As String

                        'If rLingkup.EditValue = "G" Then
                        '    sql = "select isnull(sum(isnull(harga,0)* isnull(qty,0)-ISNULL(potongan_total,0)),0) FROM [sales].[dbo].[sales_so_d], " & _
                        '          "SIF.dbo.SIF_Barang  " & _
                        '          "where No_sp in (select No_sp from  [sales].[dbo].[sales_so] where CONVERT(VARCHAR(30),[Tgl_sp],112) = '" & txtTahun.Text & rw("Tanggal") & "' ) and Kd_Stok=Kode_Barang " & _
                        '          "and kd_jenis = '" & col.ColumnName & "'"
                        'Else
                        '    sql = "select isnull(sum(isnull(harga,0)* isnull(qty,0)-ISNULL(potongan_total,0)),0) FROM [sales].[dbo].[sales_so_d], " & _
                        '          "SIF.dbo.SIF_Barang  " & _
                        '          "where No_sp in (select No_sp from  [sales].[dbo].[sales_so] where CONVERT(VARCHAR(30),[Tgl_sp],112) = '" & txtTahun.Text & rw("Tanggal") & "' and Kd_Customer = '" & customer & "' and Kd_sales = '" & sales & "' ) and Kd_Stok=Kode_Barang " & _
                        '          "and kd_jenis = '" & col.ColumnName & "'"
                        'End If

                        If rLingkup.EditValue = "G" Then
                            sql = "select isnull(sum(jml_rp_trans-jml_ppn),0) FROM [sales].[dbo].[vNota_d] " & _
                                  "where tgl_inv = convert(datetime, '" & rw("Tanggal") & txtTahun.EditValue.ToString.Substring(2) & "',103) " & _
                                   "and kd_jenis = '" & col.ColumnName & "' and tipe_trans not in  ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "')"
                        Else
                            sql = "select isnull(sum(jml_rp_trans-jml_ppn),0) FROM [sales].[dbo].[vNota_d] " & _
                                  "where tgl_inv =  convert(datetime, '" & rw("Tanggal") & txtTahun.EditValue.ToString.Substring(2) & "',103) and Kd_Customer = '" & customer & "' and Kd_sales = '" & sales & "' )" & _
                                   "and  kd_jenis = '" & col.ColumnName & "' and tipe_trans not in  ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "')"
                        End If

                        Dim drr As SqlDataReader = New SqlCommand(sql, sqlconn).ExecuteReader
                        If drr.Read Then
                            rw(col.ColumnName) = drr(0)
                            temp = drr(0)
                        Else
                            rw(col.ColumnName) = 0
                            temp = 0
                        End If
                        drr.Close()
                    End If
                End If
            Next
            rwt.ItemArray = rw.ItemArray
        Next
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim err As Boolean = False
        DXEP.SetError(SimpleButton1, "")
        If txtTahun.Text = "" Then
            DXEP.SetError(SimpleButton1, "Harap Mengisi Periode")
            txtTahun.Focus()
            err = True
        End If

        If txtSales.Text = "" Then txtSales.EditValue = "%%"
        If rLingkup.EditValue = "C" And txtCustomer.EditValue = "" Then
            DXEP.SetError(SimpleButton1, "Customer Belum Dipilih")
            txtCustomer.Focus()
            err = True
        End If
        If rLingkup.EditValue = "C" And txtSales.EditValue = "%%" Then
            DXEP.SetError(SimpleButton1, "Laporan Per-Customer Hanya Untuk Per-Sales")
            txtCustomer.Focus()
            err = True
        End If
        If err Then Exit Sub
        pw.Visible = True
        reloadTable(txtSales.EditValue, txtCustomer.EditValue, txtTahun.Text)
        pw.Visible = False
        GridBand1.Width = 50
    End Sub

    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        If txtSales.EditValue = "%%" Then
            txtCustomer.EditValue = vbNullString
            rLingkup.Text = "G"
            Exit Sub
        End If
        dsete.Tables("CUSTOMER").Rows.Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where Kd_Wilayah = '" & txtSales.GetColumnValue("Kode_Wilayah") & "' and Kode_Area = '" & txtSales.GetColumnValue("Kode_Area") & "'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
    End Sub

    Private Sub pnl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl.Resize
        pw.Top = GC.Top + ((GC.Height - pw.Height) / 2)
        pw.Left = (pnl.Width - pw.Width) / 2
    End Sub

    Private Sub rLingkup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rLingkup.SelectedIndexChanged
        DXEP.SetError(rLingkup, "")
    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        DXEP.SetError(txtTahun, "")
    End Sub
End Class