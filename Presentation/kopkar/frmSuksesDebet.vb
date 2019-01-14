Imports System.Data.SqlClient
Imports System
Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports System.Text.RegularExpressions

Public Class frmSuksesDebet
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ciUSA As CultureInfo = New CultureInfo("en-US")
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    'Private rec As Integer
    Private rptot, rec As Decimal


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub save_click()
       
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

    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur()
        If Not dSO.Tables("_imp") Is Nothing Then dSO.Tables("_imp").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kopkar.dbo.export_log where 1=0", sqlconn))
        DA.Fill(dSO, "_imp")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from simpanan_anggota_bayar where 1=0", sqlconn))
        'DA2.Fill(dSO1, "_trans")
        Gc_nabung.DataSource = dSO.Tables("_imp")
    End Sub
    Public Sub Reload(ByVal bultah As String)
        If Not dSO.Tables("_imp") Is Nothing Then dSO.Tables("_imp").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  Select e.no_trans, e.no_seq, e.Nama,e.REKBCA1 norek,e.rupiah,k.JML_POKOK,k.JML_POKOK_TERAKHIR, " & _
        '                                                           "k.JML_BUNGA, k.LAMA_ANGS, e.nasabah_id, k.jenis,j.Nama kode, e.tgl_eksekusi " & _
        '                                                           "From KOPKAR.dbo.export_log e left join KOPKAR.dbo.kredit k " & _
        '                                                           "on k.no_trans = e.no_trans    left join KOPKAR.dbo.m_jns_upload j " & _
        '                                                           "on J.kode = k.jenis   where e.blthn = '" & bultah & "' " & _
        '                                                           "and e.no_trans not in (Select g.no_trans From KOPKAR.dbo.gagaldebet g " & _
        '                                                           "where g.blthn = '" & bultah & "')", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  Select e.no_trans, e.notrans_eksport,  " & _
                                                                   "cast(SUBSTRING(e.notrans_eksport,5,6) as numeric ) no_seq, " & _
                                                                   "e.Nama,e.REKBCA1 norek,e.rupiah,k.JML_POKOK,k.JML_POKOK_TERAKHIR, " & _
                                                                   "k.JML_BUNGA, k.LAMA_ANGS, k.nasabah_id, k.jenis,j.Nama kode, e.tgl_eksekusi " & _
                                                                   "From KOPKAR.dbo.export_log e " & _
                                                                   "left join KOPKAR.dbo.kredit k " & _
                                                                   "on k.no_trans = e.no_trans " & _
                                                                   "left join KOPKAR.dbo.m_jns_upload j " & _
                                                                   "on J.kode = k.jenis  " & _
                                                                   "where e.blthn = '" & bultah & "' and e.jenis_debit = 'PINJAMAN' " & _
                                                                   "and e.notrans_eksport not in (Select g.no_trans From KOPKAR.dbo.gagaldebet g " & _
                                                                   "where g.blthn = '" & bultah & "' )", sqlconn))

        DA.Fill(dSO, "_imp")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from simpanan_anggota_bayar where 1=0", sqlconn))
        'DA2.Fill(dSO1, "_trans")
        Gc_nabung.DataSource = dSO.Tables("_imp")
    End Sub
    'Public Sub bersihkan()
    '    tx_id.Text = ""
    '    tx_nama.Text = ""
    '    'tx_iuran.Text = ""
    '    tx_setor.Text = ""
    '    tx_kembali.Clear()

    'End Sub

    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If Lue_bln.EditValue = vbNullString Then
            MsgBox("Set Periode Bulan Belum dahulu!!", MsgBoxStyle.Exclamation)
            btn_proses.Enabled = False
            Exit Sub
        End If
        Reload(dtp_tahun.Text & Lue_bln.EditValue)
        If dSO.Tables("_imp").Rows.Count > 0 Then
            btn_proses.Enabled = True
        Else
            MsgBox("Data Export Autodebit periode terpilih tida ditemukan !", MsgBoxStyle.Exclamation)
            btn_proses.Enabled = False
        End If
        'baca_txt()
    End Sub
    Public Sub baca_txt()
        'Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture
        Dim vimport As New OpenFileDialog


        vimport.Filter = "Text File(*.txt)| *.txt"
        'vimport.InitialDirectory = My.Application.Info.DirectoryPath & "\DATA\"
        vimport.InitialDirectory = "D:\"

        If OpenFileDialog1.FileName <> "" Then
            'Dim regex As Regex = New Regex("/^\d*$/")
            If vimport.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
            lb_dir.Text = vimport.FileName.ToString
            Dim myfile As String = vimport.FileName
            Dim bacafile As New System.IO.StreamReader(myfile)
            'Dim bacaALL As String = bacafile.ReadToEnd
            Dim baris As String
            Dim x As Int16 = 1
            Dim tgl_ex As String
            'bacafile.
            Try
                Do While Not bacafile.EndOfStream
                    'Do While bacafile.Peek >= 0


                    'Dim r As String = sr.ReadLine()
                    'Dim items As String() = r.Split(delimiter.ToCharArray())
                    baris = bacafile.ReadLine
                    'MsgBox(baris.First)
                    'If baris.Substring(9, 1) <> " " Then
                    If baris.Length > 8 Then


                        If Regex.IsMatch(baris.Substring(8, 1), "^[0-9]$") Then
                            'MsgBox("sukses baca norek: " & baris.Substring(8, 11) & ", Nama: " & baris.Substring(22, 30).Trim & ", No Trans: " & baris.Substring(102, 10) & ", Rupiah:" & baris.Substring(52, 20).Trim & ", NIP:" & baris.Substring(102, 6) & ", kode: " & baris.Substring(108, 4))
                            'MsgBox(Decimal.Parse(baris.Substring(52, 20).Trim, CultureInfo.InvariantCulture))
                            'MsgBox("sukses baca NIP: " & baris.Substring(102, 6))
                            Dim rw As DataRow = dSO.Tables("_imp").NewRow
                            rw.Item("blthn") = dtp_tahun.Value.Year & "" & Lue_bln.EditValue 'blthn()
                            rw.Item("no_seq") = x : x += 1
                            rw.Item("no_trans") = baris.Substring(102, 10)
                            rw.Item("norek") = baris.Substring(8, 11)
                            rw.Item("nasabah_id") = baris.Substring(102, 6)
                            rw.Item("kode") = baris.Substring(108, 4)
                            rw.Item("Nama") = baris.Substring(22, 30)
                            rw.Item("rupiah") = Decimal.Parse(baris.Substring(52, 20).Trim, CultureInfo.InvariantCulture) 'Convert.ToDecimal(baris.Substring(52, 20)) 'Decimal.Parse(baris.Substring(52, 20).ToString())
                            rw.Item("createdby") = username
                            rw.Item("create_date") = getTanggal()
                            'rw.Item("tgl_eksekusi") = x : x += 1
                            'End If
                            dSO.Tables("_imp").Rows.Add(rw)
                        End If
                        'dSO.Tables("_imp").Rows.Add(rw)
                    End If
                Loop

            Finally

                '   bacafile.Close()
            End Try

            bacafile.Close()

            simpan()
        End If

        'frame.Image = frame.InitialImage

    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("_imp"))

            'For Each row As DataRow In dSO1.Tables("_qc").Rows
            '    If row.RowState = DataRowState.Added Then
            '        row.Item("no_trans") = rw.Item("no_trans")
            '        row.Item("blthn") = blthn(BTRANS)
            '    End If
            'Next

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan ke database")
            'LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Private Sub frmImport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT id,kode,nama_bulan from m_bulan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bln")
        Lue_bln.Properties.DataSource = ds_cari1.Tables("_bln")
        Lue_bln.Properties.DisplayMember = "nama_bulan"
        Lue_bln.Properties.ValueMember = "kode"

        dtp_tahun.Text = Now

    End Sub
    Public Sub call_procedure(ByVal bultah As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandTimeout = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_CREATE_PELUNASAN_PIUTANG"
        sqlCmd.Parameters.Add("@vblthn", SqlDbType.VarChar).Value = bultah
        
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
    Private Sub btn_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proses.Click
        Try
            call_procedure(dtp_tahun.Text & Lue_bln.EditValue)
            showMessages("Berhasil disimpan")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try

    End Sub
End Class