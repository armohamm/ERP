'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPengajuanKasBon

    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Public obj As Object

    Public STATE As String
    Dim row As DataRow

    Dim dsValuta, dsSupp, dsKasBon, dsBukuPusat As New DataSet
    Dim daValuta, daSupp, dakasBon, dakasBon2, daBukuPusat As SqlDataAdapter

    Dim myBuilder As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim drJurnal As SqlDataReader
    Dim dr As SqlDataReader
    Dim param, ParamGenKode, bukuBesar, status As String
    Dim saldokas As Double

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub cancel_click()
        'If MsgBox("Perubahan Data akan disimpan dalam Database ??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then save_click()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        btnCetak = True

        setStatus()

        'Me.Enabled = False

        STATE = "ADD"

        'lblState.Text = "ADD STATE"
        'txtNomor.Text = getNoTrans("JKK", getTanggal)
        setPrimaryKey()
        controlOff(False)
        bersih()
        'txtNomor.EditValue = getNoTrans("KBN", getTanggal())
    End Sub

    Private Sub frmPengajuanKasBon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        STATE = "ADD"
        GenLOV()
        setPrimaryKey()
        loadTemp()
        'MsgBox(Now)

        Try
            LOVValuta.EditValue = "IDR"
            txtKursVal.EditValue = 1
            TglPengajuan.EditValue = getTanggal()
            LOVKartu.EditValue = vbNullString
        Catch ex As Exception
            MsgBox("Ada masalah dalam mengisi daftar data")
        End Try 
    End Sub

    Sub GenLOV()
        dsValuta.Clear()
        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from KOPKAR.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        LOVValuta.Properties.DataSource = dsValuta.Tables("Valuta")
        LOVValuta.Properties.DisplayMember = "Nama_Valuta"
        LOVValuta.Properties.ValueMember = "Kode_Valuta"

        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select a.kode, a.nama From KOPKAR.dbo.v_kartu a order by a.nama", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVKartu.Properties.DataSource = dsSupp.Tables("kartu")
        LOVKartu.Properties.DisplayMember = "nama"
        LOVKartu.Properties.ValueMember = "kode"
        GridLookUpEdit1View.Columns("kode").Visible = False
        LOVGridKartu.Properties.DataSource = dsSupp.Tables("kartu")
        LOVGridKartu.Properties.DisplayMember = "nama"
        LOVGridKartu.Properties.ValueMember = "kode"

        dsBukuPusat.Clear()
        daBukuPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Val_kode1 kd_buku_pusat,a.Desc_Data nm_buku_pusat from kopkar.dbo.SIF_Gen_Reff_D a where a.Id_Ref_Data = 'UNITKOPKAR'", sqlconn))
        'daBukuPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.SIF_buku_pusat where not kd_buku_pusat = '90000003'", sqlconn))
        daBukuPusat.Fill(dsBukuPusat, "pusat")
        LOV_Unit.Properties.DataSource = dsBukuPusat.Tables("pusat")
        LOV_Unit.Properties.DisplayMember = "nm_buku_pusat"
        LOV_Unit.Properties.ValueMember = "kd_buku_pusat"
    End Sub

    Sub setPrimaryKey(Optional ByVal no_kasbon As String = "*")
        If Not dsKasBon.Tables("kasbon") Is Nothing Then dsKasBon.Tables("kasbon").Clear()

        dakasBon = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_KAS_BON where nomor = '" & no_kasbon & "' ", sqlconn))
        dakasBon.Fill(dsKasBon, "kasbon")
    End Sub

    Sub GenBukuBesar()
        Try
            Dim dr As SqlDataReader = New SqlCommand("select kd_bb_besar1 from KOPKAR.dbo.SIF_TIPE_TRANS_D where tipe_trans = 'JKK-KBB-03' and tipe_desc ='KASBON' ", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                bukuBesar = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            bukuBesar = ""
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)

        'drJurnal = New SqlCommand("select isClosed from FIN.dbo.FIN_PERIODE_CLOSE_KASIR WHERE tgl_close = CONVERT(DATE, '" & TglPengajuan.EditValue & "',103)", sqlconn).ExecuteReader
        'drJurnal.Read()

        'reload_kas()
        'If saldokas < txtJumlah.EditValue Then
        '    MsgBox("Saldo Kas Kecil Tidak Mencukupi!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        '    Exit Sub
        'End If
        If LOVKartu.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
            MsgBox("Tolong isi data dengan lengkap.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        If LOV_Unit.EditValue = vbNullString Then
            MsgBox("Unit belum dipilih, tolong isi data dengan lengkap.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        If txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
            MsgBox("Tolong isi data dengan lengkap.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        ErrorProvider1.Clear()

        'If drJurnal.HasRows Then
        '    If drJurnal.Item(0) = "Y" Then
        '        MsgBox("Kasir sudah di close. Tidak bisa input data untuk tanggal " & TglPengajuan.Text & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        '        DateAdd(DateInterval.Day, 1, TglPengajuan.EditValue)
        '        Exit Sub
        '    End If
        'End If


        'drJurnal.Close()

        Try

            If Not isDelete Then

                'Dim JmlTrans As Integer
                'Dim dr As SqlDataReader = New SqlCommand("select isNUll(SUM(jml_trans),0) from FIN.dbo.FIN_KAS_BON where kd_kartu = '" & LOVKartu.EditValue & "'", sqlconn).ExecuteReader
                'dr.Read()
                'If dr.HasRows Then
                '    JmlTrans = dr.Item(0)
                'Else
                '    JmlTrans = 0
                'End If

                'dr.Close()

                'If JmlTrans > 0 Then
                '    MsgBox("Kartu masih memiliki tunggakan")
                '    ErrorProvider1.SetError(LOVKartu, "kartu masih memiliki hutang")
                '    Exit Sub
                'End If


                GenBukuBesar()

                If STATE = "ADD" Then

                    row = dsKasBon.Tables("kasbon").NewRow
                    txtNomor.EditValue = getNoTrans("KBN", TglPengajuan.EditValue)
                    'txtNoCabang.EditValue = getKodeCabang()

                    'MsgBox(txtNoCabang.EditValue)

                    row.Item("kd_cabang") = "1"
                    row.Item("nomor") = txtNomor.EditValue
                    row.Item("tipe_trans") = "JKK-KBB-03"
                    row.Item("last_create_date") = getTanggal()
                    row.Item("last_created_by") = umum.username
                    row.Item("program_name") = Me.Name


                End If

                If STATE = "EDIT" Then

                    row = dsKasBon.Tables("kasbon").Rows(0)
                    row.Item("last_update_date") = getTanggal()
                    row.Item("last_updated_by") = umum.username

                End If

                row.Item("tgl_trans") = TglPengajuan.EditValue
                row.Item("tgl_posting") = TglPengajuan.EditValue
                row.Item("kd_kartu") = LOVKartu.EditValue
                row.Item("kd_divisi") = LOV_Unit.EditValue
                row.Item("kd_valuta") = LOVValuta.EditValue
                row.Item("kurs_valuta") = txtKursVal.EditValue
                row.Item("keterangan") = txtketerangan.EditValue
                'row.Item("kd_divisi") = kddep
                row.Item("kd_buku_besar") = bukuBesar

                row.Item("jml_trans") = txtJumlah.EditValue
                row.Item("jml_bayar") = 0
                row.Item("jml_akhir") = txtJumlah.EditValue
                row.Item("jml_tambahan") = 0

                If STATE = "ADD" Then
                    dsKasBon.Tables("kasbon").Rows.Add(row)
                End If

            End If

            myBuilder = New SqlCommandBuilder(dakasBon)
            dakasBon.UpdateCommand = myBuilder.GetUpdateCommand()
            dakasBon.InsertCommand = myBuilder.GetInsertCommand()
            dakasBon.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            dakasBon.UpdateCommand.Transaction = BTRANS
            dakasBon.InsertCommand.Transaction = BTRANS
            dakasBon.DeleteCommand.Transaction = BTRANS

            dakasBon.Update(dsKasBon.Tables("kasbon"))

            'dsAktiva.Tables("Aktiva").AcceptChanges()

            If Not isDelete Then
                ' call_procedure("JKK-KBB-03", txtNomor.EditValue, BTRANS)
            End If

            Try
                'If MsgBox("Simpan dan cetak? (Jika tidak,hanya akan menyimpan)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SIMPAN?") = MsgBoxResult.Yes Then
                '    BTRANS.Commit()
                '    'cetak_click()
                'Else
                BTRANS.Commit()
                'End If
                If Not isDelete Then
                    showMessages("Data Berhasil Disimpan")
                    If MsgBox("Cetak?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CETAK?") = MsgBoxResult.Yes Then
                        cetak_click()
                    End If
                Else
                    showMessages("Data Berhasil Dihapus")
                End If
                loadTemp()
                cancel_click()
            Catch ex As Exception
                BTRANS.Rollback()
                dsKasBon.Tables("kasbon").RejectChanges()
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            dsKasBon.Tables("kasbon").RejectChanges()
            MsgBox("Cek kembali isian data, inputan wajib jangan sampai kosong. Detail Error : " & ex.Message)
        End Try

    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Sub loadTemp()
        If Not dsKasBon.Tables("Temp") Is Nothing Then dsKasBon.Tables("Temp").Clear()
        dakasBon2 = New SqlDataAdapter(New SqlCommand("select a.* from KOPKAR.dbo.FIN_KAS_BON a where MONTH(a.tgl_trans) in (MONTH(GETDATE()), MONTH(DATEADD(mm, -1, GETDATE())), MONTH(DATEADD(mm, -2, GETDATE()))) and a.tgl_posting is null order by a.tgl_trans desc", sqlconn))
        dakasBon2.Fill(dsKasBon, "Temp")
        GC.DataSource = dsKasBon.Tables("Temp")
        GV.BestFitColumns()
    End Sub

    Private Sub GV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.Click
        If Not GV.RowCount = 0 Then
            setPrimaryKey(GV.GetRow(GV.GetSelectedRows(0)).item("nomor"))
        End If
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        STATE = "EDIT"
        controlOff(False)
        Dim jumlah As String = 0
        'row = dsAktiva.Tables("Temp").Rows(GV.GetSelectedRows(0))

        setPrimaryKey(GV.GetRow(GV.GetSelectedRows(0)).item("nomor"))

        txtNomor.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nomor")
        TglPengajuan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_trans")
        LOVKartu.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kd_kartu")
        LOVValuta.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kd_valuta")
        LOV_Unit.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kd_divisi")
        txtKursVal.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kurs_valuta")
        txtJumlah.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("jml_trans")
        txtketerangan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("keterangan")

        'Dim dr As SqlDataReader = New SqlCommand("select isnull(tgl_posting,'')as tgl_posting from FIN.dbo.FIN_KAS_BON where nomor = '" & GV.GetRow(GV.GetSelectedRows(0)).item("nomor") & "' ", sqlconn).ExecuteReader
        Dim dr As SqlDataReader = New SqlCommand(" select COUNT(nomor) as tgl_posting  " & _
                                                 "from KOPKAR.dbo.FIN_KAS_BON b where nomor = '" & GV.GetRow(GV.GetSelectedRows(0)).item("nomor") & "'" & _
                                                 "and ISNULL(b.tgl_posting,'1900-01-01') = '01/01/1900' ", sqlconn).ExecuteReader

        dr.Read()
        If dr.HasRows Then
            jumlah = dr.Item(0)
        End If
        dr.Close()

        If jumlah < 1 Then
            MsgBox("Pengajuan ini sudah direalisasi,tidak dapat diubah.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "INFORMASI!")
            btnSave = False
            btnDelete = False
            btnadd = False
            btnEdit = False
            setStatus()
            controlOff(True)
            'bersih()
        Else
            btnSave = True
            btnDelete = True
            btnadd = False
            btnEdit = False
            setStatus()
            controlOff(False)
        End If
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtNomor.Properties.ReadOnly = stat
        TglPengajuan.Properties.ReadOnly = stat
        LOVKartu.Properties.ReadOnly = stat
        LOVValuta.Properties.ReadOnly = stat
        txtKursVal.Properties.ReadOnly = stat
        txtJumlah.Properties.ReadOnly = stat
        txtketerangan.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Sub bersih()
        txtNomor.EditValue = vbNullString
        txtJumlah.EditValue = vbNullString
        txtketerangan.EditValue = vbNullString
        LOVValuta.ItemIndex = 3
        txtKursVal.EditValue = 1
        'TglPengajuan.EditValue = getTanggal()
        LOVKartu.EditValue = vbNullString
    End Sub

    'Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
    '    save_click()
    'End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    loadTemp()
    'End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub

    Public Sub cetak_click()
        'ShowGridPreview(GV.GridControl)
        If Not txtNomor.Text = "" Then
            Dim sqlx As New SqlCommand("update KOPKAR.dbo.fin_kas_bon set jml_cetak=isnull(jml_cetak,0)+1, tgl_cetak=getdate() where nomor='" & txtNomor.Text & "'", sqlconn)
            sqlx.ExecuteNonQuery()
            callReport(App_Path() & "\report\repNotaPengajuanKasBon.rpt", "", "nomor=" & txtNomor.Text, False)
        Else
            MsgBox("Nomor pengajuan masih belum ada. Mohon input data baru atau pilih data yang sudah ada.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
        End If
    End Sub

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    '    ShowGridPreview(GV.GridControl)
    'End Sub

    Public Sub delete_click()
        If Not dsKasBon.Tables("kasbon") Is Nothing Then
            For Each rw As DataRow In dsKasBon.Tables("kasbon").Rows
                Dim sqlm As New SqlCommand("delete from KOPKAR.dbo.fin_jurnal where no_jur ='" & rw.Item("no_jur") & "'", sqlconn)
                sqlm.ExecuteNonQuery()
                Dim sqld As New SqlCommand("delete from KOPKAR.dbo.fin_jurnal_d where no_jur ='" & rw.Item("no_jur") & "'", sqlconn)
                sqld.ExecuteNonQuery()
                rw.Delete()
            Next
        Else
            MsgBox("Tidak ada data yang dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
        save_click(True)
    End Sub

    'Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    delete_click()
    'End Sub

    'Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
    '    txtJumlah.EditValue = vbNullString
    '    txtketerangan.EditValue = vbNullString
    'End Sub

    Private Sub LOVValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVValuta.EditValueChanged
        If LOVValuta.EditValue = "IDR" Then
            txtKursVal.EditValue = 1
        End If
    End Sub

    Private Sub LOVKartu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LOVKartu.LostFocus
        Dim angka1 As Integer
        Dim angka2 As Integer

        If Not STATE = "EDIT" Then
            dr = New SqlCommand("SELECT COUNT(nomor) AS angka FROM KOPKAR.dbo.FIN_KAS_BON WHERE kd_kartu = '" & LOVKartu.EditValue & "' AND jml_akhir > 0 AND MONTH(tgl_trans) = MONTH(GETDATE())", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                angka1 = dr.Item(0)
            End If
            dr.Close()

            dr = New SqlCommand("SELECT Val_kode1 FROM KOPKAR.dbo.SIF_Gen_Reff WHERE Id_Table = 'JANE'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                angka2 = dr.Item(0)
            End If
            dr.Close()

            If angka1 > angka2 Then
                'MsgBox(LOVKartu.Text & " masih belum melunasi lebih dari " & angka2 & " kas bon. Tidak dapat menyimpan pengajuan ini.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                'btnadd = False
                'btnCancel = True
                'btnCetak = False
                'btnDelete = True
                'btnEdit = False
                'btnSave = False
                'setStatus()
            Else
                btnadd = False
                btnCancel = True
                btnCetak = False
                btnDelete = True
                btnEdit = False
                btnSave = True
                setStatus()
            End If
        End If
    End Sub

    Private Sub reload_kas()
        Dim dr As SqlDataReader = New SqlCommand("SELECT KOPKAR.dbo.hitungsaldoawal((Select d.Val_kode1   " & _
                                                 "From KOPKAR.dbo.SIF_Gen_Reff_D d where d.Id_Ref_Data in ('REKKASBON')), 'IDR','" & Now.Year & "', '" & Now.Month & "', '" & IIf(Now.Day - 1 = 0, Now.Day, Now.Day) & "')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            saldokas = dr.Item(0)
        Else
            saldokas = 0
        End If
        dr.Close()

    End Sub
End Class