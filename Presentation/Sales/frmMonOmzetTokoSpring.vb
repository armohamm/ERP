Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonOmzetTokoSpring
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim max_col As Int16
    Dim m As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Dim gb As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Dim target As Double = 0
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
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
        rLingkup.EditValue = "G"
        dsete.Tables.Add("Hasil")
        dsete.Tables("Hasil").Columns.Add("Tanggal")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales, Kode_Wilayah, Kode_Area from SIF.dbo.SIF_Sales where kode_departemen='" & KD_DIV_SPRING & "'  union all select 'ALL', '%%', '', ''", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where 1=0", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        Dim dr As SqlDataReader = New SqlCommand("select [Kode_Merk] ,[Nama_Merk] FROM [SIF].[dbo].[SIF_Merk]", sqlconn).ExecuteReader
        While dr.Read
            Dim ckbox As New CheckedListBoxItem
            ckbox.Value = dr(0)
            'ckbox.CheckState = CheckState.Checked
            ckbox.Description = dr(1)
            cmdMerk.Properties.Items.Add(ckbox)

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

        dr = New SqlCommand("select [Kode_Merk] ,[Nama_Merk] FROM [SIF].[dbo].[SIF_Merk]", sqlconn).ExecuteReader
        While dr.Read
            gb = GV.Bands.Add()
            gb.Name = dr(0)
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
            'm.ColumnEdit = repProg
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
                If GV.Bands(i).Visible Then
                    dr = New SqlCommand("select sum(isnull(target,0)) as target from [SALES].[dbo].[SALES_TARGET_SALES] where [kd_sales] like '" & txtSales.EditValue & "' and ([bln_buku] + [thn_buku]) = '" & txtTahun.DateTime.ToString("MMyyyy") & "' and [kd_merk] = '" & GV.Bands(i).Tag & "'", sqlconn).ExecuteReader
                    dr.Read()
                    If dr.HasRows And Not TypeOf dr(0) Is DBNull Then
                        GV.Bands(i).Tag = dr(0)
                        GV.Bands(i).Caption = GV.Bands(i).ToolTip & " Target " & FormatCurrency(dr(0), 2)
                    Else
                        GV.Bands(i).Tag = "~"
                        GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target n/a )"
                    End If
                    dr.Close()
                End If
            Next
        Else
            For i As Int16 = 1 To GV.Bands.Count - 1
                If GV.Bands(i).Visible Then
                    dr = New SqlCommand("select sum(isnull(target,0)) as target from [SALES].[dbo].[SALES_TARGET_TOKO] where [kd_sales] like '" & txtSales.EditValue & "' and ([bln_buku] + [thn_buku]) = '" & txtTahun.DateTime.ToString("MMyyyy") & "' and [kd_merk] = '" & GV.Bands(i).Tag & "' and [kd_customer]='" & txtCustomer.EditValue & "'", sqlconn).ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        GV.Bands(i).Tag = dr(0)
                        GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target " & dr(0).ToString & " )"
                    Else
                        dr = New SqlCommand("select sum(isnull(target,0)) as target from [SALES].[dbo].[SALES_TARGET_SALES] where [kd_sales] like '" & txtSales.EditValue & "' and ([bln_buku] + [thn_buku]) = '" & txtTahun.DateTime.ToString("MMyyyy") & "' and [kd_jenis] = '" & GV.Bands(i).Tag & "'", sqlconn).ExecuteReader
                        dr.Read()
                        If dr.HasRows Then
                            GV.Bands(i).Tag = dr(0)
                            GV.Bands(i).Caption = GV.Bands(i).ToolTip & " ( Target " & dr(0).ToString & " )"
                        Else
                            GV.Bands(i).Tag = "~"
                        End If
                    End If
                    dr.Close()
                End If
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

            For Each col As DataColumn In dsete.Tables("Hasil").Columns
                pw.Refresh()
                If col.ColumnName <> "Tanggal" Then
                    If isVisible(col.ColumnName) Then
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
                                    target = Val(GV.Columns(col.ColumnName.ToString).OwnerBand.Tag.ToString)
                                    If System.Math.Round(target, 0) > 0 Then
                                        rw(col.ColumnName) = last * 100 / target
                                    Else
                                        rw(col.ColumnName) = "0"
                                    End If
                                Else
                                    rw(col.ColumnName) = "0"
                                End If

                            End If
                        Else

                            Dim sql As String
                            If rLingkup.EditValue = "G" Then
                                sql = "select isnull(sum(jml_rp_trans-jml_ppn),0) FROM [sales].[dbo].[vNota_d] " & _
                                      "where tgl_inv = convert(datetime, '" & rw("Tanggal") & txtTahun.EditValue.ToString.Substring(2) & "',103) and Kd_sales like '" & sales & "' " & _
                                       "and kd_merk = '" & col.ColumnName & "' and tipe_trans = '" & SpringUmum & "'"
                            Else
                                sql = "select isnull(sum(jml_rp_trans-jml_ppn),0) FROM [sales].[dbo].[vNota_d] " & _
                                      "where tgl_inv =  convert(datetime, '" & rw("Tanggal") & txtTahun.EditValue.ToString.Substring(2) & "',103) and Kd_Customer = '" & customer & "' and Kd_sales = '" & sales & "'" & _
                                       "and  kd_merk = '" & col.ColumnName & "' and tipe_trans = '" & SpringUmum & "'"
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
        'System.Threading.Thread.Sleep(500)
        Me.Refresh()
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

    Private Function isVisible(ByVal col As String) As Boolean
        If InStr(col, "_", CompareMethod.Text) Then
            col = VisualBasic.Left(col, InStr(col, "_", CompareMethod.Text) - 1)
        End If
        Return GV.Bands(col).Visible
    End Function

    Private Sub cmdMerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMerk.EditValueChanged
        For Each nd As CheckedListBoxItem In cmdMerk.Properties.Items
            GV.Bands(nd.Value).visible = IIf(nd.CheckState = CheckState.Checked, True, False)
        Next
    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        DXEP.SetError(SimpleButton1, "")
    End Sub

    Private Sub rLingkup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rLingkup.SelectedIndexChanged
        DXEP.SetError(SimpleButton1, "")
    End Sub
End Class