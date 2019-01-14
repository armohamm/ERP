Imports System.Data.SqlClient
Public Class frmUpdateVolBarang
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim ds1 As New DataSet
    Dim da1, da2, da3 As SqlDataAdapter
    Dim dr1 As SqlDataReader
    Dim bldKendaraan As New SqlCommandBuilder
    Dim state, err, kodeKendaraan As String
    Dim isValid As Boolean
    Dim row As DataRow
    Dim BTRANS As SqlTransaction
    Dim nilai_asal, p_asal, t_asal, l_asal As Double
    Private Sub frmKonversiBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Me.Enabled = False
        prn = getParent(Me)
        loadLookup()
        loadDataset("XXX")
        'loadGrid()
        state = "ADD"

    End Sub
    Public Sub add_click()


        btnAdd = False
        btnSave = True
        btnCancel = True
        btnEdit = False
        setStatus()
        loadDataset("xxx")
        state = "ADD"
        clear()
        Me.Enabled = True
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub



    Private Sub loadLookup()
        If Not ds1.Tables("BarangAsal") Is Nothing Then ds1.Tables("BarangAsal").Clear()
        'If Not ds1.Tables("BarangTujuan") Is Nothing Then ds1.Tables("BarangTujuan").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("Select b.Kode_Barang,b.Nama_Barang from SIF.dbo.SIF_Barang b " & _
                                                " ", sqlconn))
        da1.Fill(ds1, "BarangAsal")
        LU_barangAsal.Properties.DataSource = ds1.Tables("BarangAsal")
        LU_barangAsal.Properties.DisplayMember = "Nama_Barang"
        LU_barangAsal.Properties.ValueMember = "Kode_Barang"
        

        'daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 'Y' as kode, 'AKTIF' as stat UNION SELECT 'T', 'TIDAK AKTIF'", sqlconn))
        'daLookUp.Fill(dsKendaraan, "Status")
        'lookUpStat.DataSource = dsKendaraan.Tables("Status")
        'lookUpStat.ValueMember = "kode"
        'lookUpStat.DisplayMember = "stat"
    End Sub

    Private Sub loadDataset(ByVal kode As String)
        If Not ds1.Tables("Konversi") Is Nothing Then ds1.Tables("Konversi").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("SELECT Kd_Satuan,isnull(tinggi,0) as tinggi ,isnull(lebar,0) as lebar, " & _
        '                                        "isnull(panjang,0) as panjang ,isnull(volume,0) as volume FROM SIF.dbo.SIF_BARANG WHERE Kode_Barang='" & kode & "'", sqlconn))
        da2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_BARANG WHERE Kode_Barang='" & kode & "'", sqlconn))
        da2.Fill(ds1, "Konversi")

        If ds1.Tables("Konversi").Rows.Count > 0 Then
            Dim row2 As DataRow = ds1.Tables("Konversi").Rows(0)
            txt_satuanasal.Text = row2("Kd_Satuan")
            txt_P_Asal.EditValue = IIf(row2("panjang") Is DBNull.Value, 0, row2("panjang"))
            txt_L_Asal.EditValue = IIf(row2("lebar") Is DBNull.Value, 0, row2("lebar"))
            txt_T_Asal.EditValue = IIf(row2("tinggi") Is DBNull.Value, 0, row2("tinggi"))
            txt_JumlahAsal.EditValue = IIf(row2("volume") Is DBNull.Value, 0, row2("volume"))
           

            '    If ds1.Tables("Konversi").Rows(0).Item("rec_stat") = "N" Then
            '        BTN_KONFIRM.Enabled = True
            '    Else
            '        BTN_KONFIRM.Enabled = False
            '    End If
            'Else
            '    BTN_KONFIRM.Enabled = False
        End If
    End Sub
    Sub clear()

        LU_barangAsal.EditValue = Nothing
        txt_JumlahAsal.EditValue = Nothing
        txt_P_Asal.EditValue = Nothing
        txt_T_Asal.EditValue = Nothing
        txt_L_Asal.EditValue = Nothing
        txt_satuanasal.Text = Nothing
       

    End Sub
    Public Sub cancel_click()
        clear()
        btnAdd = True
        btnSave = False
        btnCancel = False
        btnEdit = True
        btnDelete = False
        setStatus()
        state = "EDIT"
        Me.Enabled = False
    End Sub
    Public Sub edit_click()
        btnAdd = False
        btnSave = True
        btnCancel = True
        btnEdit = False
        setStatus()
        loadDataset("xxx")
        state = "ADD"
        clear()
        Me.Enabled = True
    End Sub
    Public Sub save_click()
        'Dim nilai_asal As Double
       
        If state = "ADD" Then
            ''Try
            ''    dr1 = New SqlCommand(" select Isnull (I.nilai_rata,0)   as nilai_rata from  INV.dbo.INV_STOK_SALDO I " & _
            ''                       "where i.kd_stok = '" & LU_barangAsal.EditValue & "' and i.panjang = " & p_asal & " " & _
            ''                       "and i.lebar = " & l_asal & " and i.tinggi = " & t_asal & " " & _
            ''                       "and I.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL " & _
            ''                       "where(SL.kd_stok = i.kd_stok And sl.panjang = i.panjang And sl.lebar = i.lebar) " & _
            ''                       "and sl.tinggi=i.tinggi )", sqlconn).ExecuteReader
            ''    dr1.Read()
            ''    If dr1.HasRows Then
            ''        nilai_asal = dr1.Item("nilai_rata") * txt_JumlahAsal.EditValue
            ''    End If
            ''    dr1.Close()
            ''    MsgBox(nilai_asal, MsgBoxStyle.Information)
            ''Catch ex As Exception

            ''End Try

            ''txtNoTrans.Text = getNoTrans("KONV", Now)
            ''kodeKendaraan = txtKode.EditValue
            'row = ds1.Tables("Konversi").NewRow
            'row.Item("kd_cabang") = getKodeCabang()
            'row.Item("kd_departemen") = kddep

            'row.Item("last_create_date") = getTanggal()
            'row.Item("last_created_by") = umum.username
            'row.Item("program_name") = Me.Name
            'row.Item("kd_barang_asal") = LU_barangAsal.EditValue
            'row.Item("panjang_asal") = txt_P_Asal.Text
            'row.Item("tinggi_asal") = txt_T_Asal.Text
            'row.Item("lebar_asal") = txt_L_Asal.Text
            'row.Item("kd_satuan_asal") = txt_satuanasal.Text
            'row.Item("jumlah_asal") = txt_JumlahAsal.Text
            'row.Item("nilai_asal") = nilai_asal

            'ds1.Tables("Konversi").Rows.Add(row)
            row = ds1.Tables("Konversi").Rows(0)

            row.Item("panjang") = txt_P_Asal.Text
            row.Item("tinggi") = txt_T_Asal.Text
            row.Item("lebar") = txt_L_Asal.Text
            row.Item("volume") = txt_JumlahAsal.EditValue
        ElseIf state = "EDIT" Then
            row = ds1.Tables("Konversi").Rows(0)
            
            row.Item("panjang") = txt_P_Asal.Text
            row.Item("tinggi") = txt_T_Asal.Text
            row.Item("lebar") = txt_L_Asal.Text
            row.Item("volume") = txt_JumlahAsal.EditValue
            
        End If

        Try
            bldKendaraan = New SqlCommandBuilder(da2)
            da2.UpdateCommand = bldKendaraan.GetUpdateCommand()
            da2.InsertCommand = bldKendaraan.GetInsertCommand()
            da2.DeleteCommand = bldKendaraan.GetDeleteCommand()

            'BTRANS = sqlconn.BeginTransaction("1")
            'daKendaraan.UpdateCommand.Transaction = BTRANS
            'daKendaraan.InsertCommand.Transaction = BTRANS
            'daKendaraan.DeleteCommand.Transaction = BTRANS

            da2.Update(ds1.Tables("Konversi"))

            ds1.Tables("Konversi").AcceptChanges()

            'BTRANS.Commit()

            showMessages("Berhasil disimpan..")

            If state = "ADD" Then
                state = "EDIT"
            ElseIf state = "EDIT" Then
                state = "ADD"
            End If
            loadDataset(LU_barangAsal.EditValue)
            btnAdd = True
            btnSave = False
            btnCancel = False
            btnEdit = True
            setStatus()
            'loadGrid()
        Catch ex As Exception
            'BTRANS.Rollback()
            ds1.Tables("Konversi").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
        End Try

    End Sub



    Private Sub LU_barangAsal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LU_barangAsal.EditValueChanged

        loadDataset(LU_barangAsal.EditValue)

        'dr1 = New SqlCommand("SELECT b.Kd_Satuan FROM SIF.dbo.SIF_Barang b " & _
        '                     "where b.Kode_Barang = '" & LU_barangAsal.EditValue & "' ", sqlconn).ExecuteReader
        'dr1.Read()
        'If dr1.HasRows Then
        '    txt_satuanasal.Text = dr1.Item(0)
        'Else
        '    txt_satuanasal.Text = vbNullString
        'End If

        'dr1.Close()

        'Try
        '    dr1 = New SqlCommand(" select Isnull (I.nilai_rata,0)   as nilai_rata from  INV.dbo.INV_STOK_SALDO I " & _
        '                       "where i.kd_stok = '" & LU_barangAsal.EditValue & "' and i.panjang = " & p_asal & " " & _
        '                       "and i.lebar = " & l_asal & " and i.tinggi = " & t_asal & " " & _
        '                       "and I.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL " & _
        '                       "where(SL.kd_stok = i.kd_stok And sl.panjang = i.panjang And sl.lebar = i.lebar) " & _
        '                       "and sl.tinggi=i.tinggi )", sqlconn).ExecuteReader
        '    dr1.Read()
        '    If dr1.HasRows Then
        '        nilai_asal = dr1.Item("nilai_rata") * txt_JumlahAsal.EditValue
        '    End If
        '    dr1.Close()
        '    MsgBox(nilai_asal, MsgBoxStyle.Information)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub BTN_KONFIRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_KONFIRM.Click
        p_asal = IIf(txt_P_Asal.Text = Nothing, 0, txt_P_Asal.EditValue)
        l_asal = IIf(txt_L_Asal.EditValue = Nothing, 0, txt_L_Asal.EditValue)
        t_asal = IIf(txt_T_Asal.Text = Nothing, 0, txt_T_Asal.EditValue)

        nilai_asal = (p_asal * l_asal * t_asal) / 1000000
        txt_JumlahAsal.EditValue = nilai_asal

    End Sub
End Class


