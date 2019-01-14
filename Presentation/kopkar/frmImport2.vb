Imports System.Data.SqlClient
Imports System
Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports System.Text.RegularExpressions

Public Class frmImport2
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ciUSA As CultureInfo = New CultureInfo("en-US")
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns, blnskrg, bln_thn As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
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

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
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
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from gagaldebet where 1=0", sqlconn))
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
            Exit Sub
        End If
        baca_txt()
    End Sub
    Public Sub baca_txt()
        'Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture
        Dim vimport As New OpenFileDialog
        bln_thn = dtp_tahun.Value.Year & "" & Lue_bln.EditValue 'blthn()

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
                            Dim tes As String
                            rw.Item("blthn") = bln_thn 'sesuai pilihan backdate bkn 'blthn()
                            rw.Item("no_seq") = x : x += 1
                            If baris.Length = 111 Then
                                rw.Item("no_trans") = baris.Substring(101, 10)
                                rw.Item("kode") = baris.Substring(106, 4)
                            Else
                                rw.Item("no_trans") = baris.Substring(baris.Length - 10)
                                rw.Item("kode") = ""
                            End If
                            tes = baris.Substring(1, 100)
                            rw.Item("norek") = baris.Substring(7, 11)
                            rw.Item("nasabah_id") = baris.Substring(101, 6)

                            rw.Item("Nama") = baris.Substring(21, 30)
                            rw.Item("rupiah") = Decimal.Parse(baris.Substring(51, 20).Trim, CultureInfo.InvariantCulture) 'Convert.ToDecimal(baris.Substring(52, 20)) 'Decimal.Parse(baris.Substring(52, 20).ToString())
                            rw.Item("createdby") = username
                            rw.Item("create_date") = getTanggal()
                            rw.Item("stat") = "GAGAL"
                            rw.Item("keterangan") = baris.Substring(73, 24)
                            'MsgBox("sukses baca : " & baris.Substring(74, 18))
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
        prc_bckp(BTRANS)
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
            Dim sqlcmd1 As New SqlCommand("insert into pelunasan (no_export,no_seq,no_trans,blthn,nasabah_id,jml_pinjaman,jenis,jml_pokok,jml_bunga,jml_lunas,tgl_lunas,lunas_by,sisa_pokok_awal,sisa_pokok_akhir,sisa_angs_awal,sisa_angs_akhir,angs_ke,tenor) " & _
   "select notrans_eksport,no_seq,no_trans,'" & bln_thn & "',nasabah_id,jml_pinjaman,jenis,pokok,bunga,rupiah,GETDATE(),'Autodebet',sisa_pokok,sisa_pokok-pokok as sisa_pokok_new,sisa_angs,sisa_angs-1 as sisa_angs_new,(lama_angs-(sisa_angs-1)) as angs_ke,lama_angs from export_log " & _
   "WHERE blthn='" & bln_thn & "' and no_trans not in (select k.no_trans from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn)", sqlconn, BTRANS)
            '"WHERE no_trans not in (select k.no_trans gagaldebet", sqlconn, BTRANS) 'Jika full exp dan imp pake app
            sqlcmd1.ExecuteNonQuery()
            'angsuran berkurang
            'Dim sqlcmd2 As New SqlCommand("UPDATE kredit set sisa_angs=sisa_angs-1,sisa_pokok=sisa_pokok-JML_POKOK where sudah_upload=0 and no_trans not in (select k.no_trans from kredit k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.jml_angsuran)", sqlconn, BTRANS)

            'tab wajib

            STATE = "EDIT"
            'pelunasan()    


            'update kredit
            Dim sqlcmd2 As New SqlCommand("UPDATE kredit set sisa_angs=sisa_angs-1,sisa_pokok=sisa_pokok-JML_POKOK where no_trans not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlcmd2.ExecuteNonQuery()

            'update ritel
            Dim sqlrtl As New SqlCommand("UPDATE retail set sisa_angs=sisa_angs-1,sisa_pokok=sisa_pokok-JML_POKOK where no_trans not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlrtl.ExecuteNonQuery()

            'tab wajib SW
            Dim sqlWjb As New SqlCommand("update tab_wajib set saldo_akhir=saldo_akhir+iuran where no_tab not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlWjb.ExecuteNonQuery() 'update tab_wajib set saldo_akhir=saldo_akhir+iuran

            'update sukarela
            Dim sqlRL As New SqlCommand("update tabung set SALDO_AKHIR=SALDO_AKHIR+iuran where JENIS_TABUNGAN='006' AND NO_TABUNGAN not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlRL.ExecuteNonQuery() 'update tab_wajib set saldo_akhir=saldo_akhir+iuran

            'update QURBAN
            Dim sqlQRB As New SqlCommand("update tabung set SALDO_AKHIR=SALDO_AKHIR+iuran where JENIS_TABUNGAN='002' AND NO_TABUNGAN not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlQRB.ExecuteNonQuery() 'update tab_wajib set saldo_akhir=saldo_akhir+iuran

            'update HAJI
            Dim sqlhj As New SqlCommand("update tabung set SALDO_AKHIR=SALDO_AKHIR+iuran where JENIS_TABUNGAN='003' AND NO_TABUNGAN not in (select DISTINCT(k.no_trans) from export_log k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.rupiah and g.blthn=k.blthn WHERE k.blthn='" & bln_thn & "')", sqlconn, BTRANS)
            sqlhj.ExecuteNonQuery() 'update tab_wajib set saldo_akhir=saldo_akhir+iuran

            'lunas jika habis 0
            Dim sqlLns As New SqlCommand("update kredit set status_lunas='LUNAS' where sisa_pokok=0 or sisa_angs<=0", sqlconn, BTRANS)
            sqlLns.ExecuteNonQuery()

            Dim sqlLns1 As New SqlCommand("update retail set status_lunas='LUNAS' where sisa_pokok=0 or sisa_angs<=0", sqlconn, BTRANS)
            sqlLns.ExecuteNonQuery()

            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            showMessages("Pembayaran berhasil di Update")

            'LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Public Sub pelunasan()
        Dim BTRANS As SqlTransaction
        Try
            BTRANS = sqlconn.BeginTransaction("1")
            Dim sqlcmd1 As New SqlCommand("insert into pelunasan (no_trans,nasabah_id,jml_pinjaman,jml_pokok,jml_bunga,jml_lunas,tgl_lunas,lunas_by,sisa_pokok_awal,sisa_pokok_akhir,sisa_angs_awal,sisa_angs_akhir,angs_ke,tenor) " & _
    "select no_trans,nasabah_id,jml_pinjaman,jml_pokok,jml_bunga,jml_angsuran,GETDATE(),'Autodebet',sisa_pokok,sisa_pokok-JML_POKOK as sisa_pokok_new,sisa_angs,sisa_angs-1 as sisa_angs_new,(lama_angs-(sisa_angs-1)) as angs_ke,lama_angs from kredit " & _
    "WHERE no_trans not in (select k.no_trans from kredit k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.jml_angsuran)", sqlconn, BTRANS)
            sqlcmd1.ExecuteNonQuery()
            Dim sqlcmd2 As New SqlCommand("UPDATE kredit set sisa_angs=sisa_angs-1,sisa_pokok=sisa_pokok-JML_POKOK where sudah_upload=0 and no_trans not in (select k.no_trans from kredit k inner join  gagaldebet g on g.nasabah_id=k.nasabah_id and g.rupiah=k.jml_angsuran)", sqlconn, BTRANS)
            sqlcmd2.ExecuteNonQuery()
            BTRANS.Commit()
            showMessages("Berhasil Debet...")
        Catch ex As Exception
            BTRANS.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal update pelunasan")
        End Try

    End Sub

    Private Sub frmImport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT id,kode,nama_bulan from m_bulan", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_bln")
        'Lue_bln.Properties.DataSource = ds_cari1.Tables("_bln")
        'Lue_bln.Properties.DisplayMember = "nama_bulan"
        'Lue_bln.Properties.ValueMember = "kode"
        baca_bln()
        dtp_tahun.Text = Now

    End Sub
    Public Sub baca_bln()

        Dim sqlbc1 As SqlDataReader = New SqlCommand("SELECT SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2)", sqlconn).ExecuteReader
        While sqlbc1.Read
            blnskrg = sqlbc1.Item(0)
            'header1 = sqlbc.Item("header1")
            'header2 = sqlbc.Item("header2")
            'header3 = sqlbc.Item("header3")
        End While
        sqlbc1.Close()
        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT id,kode,nama_bulan from m_bulan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bln")
        Lue_bln.Properties.DataSource = ds_cari1.Tables("_bln")
        Lue_bln.Properties.DisplayMember = "nama_bulan"
        Lue_bln.Properties.ValueMember = "kode"
        Lue_bln.EditValue = blnskrg

    End Sub

    Public Sub prc_bckp(ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.bckp_sblm_imp"
        'sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date).Value = tglx
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
End Class