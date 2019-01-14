'*******************************
' // CREATED BY YAYA         \\
' \\ EDITED BY DIDIER DROGBA //
'*******************************

Imports System.Data.SqlClient

Public Class FrmApprovePO1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, milih As String '<-- untuk mengecek rec_stat saat ini (ADD, EDIT, delete)

    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow

    Private dSO, ds_cari, ds1, dsLOV As New DataSet
    Private DA, DALOOKUP, da_cari, DAStat, DAsave As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

        'dSO.Clear()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PO where rec_stat <> 'APPROVE' ", sqlconn)) ' where status <> 'APPROVE'
        'DA.Fill(dSO, "_ApprvPO")
        'GcApprvPO.DataSource = dSO.Tables("_ApprvPO")

        simpan()

        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
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

    Public Sub simpan()
        Dim BTRANS As SqlTransaction

        Try

            BTRANS = sqlconn.BeginTransaction("1")

            For Each rw As DataRow In dSO.Tables("_ApprvPO").Select("isnull(rec_stat,'')<>''", "")
                If rw.RowState = DataRowState.Added Then
                    With New SqlCommand("update PURC.dbo.PURC_PO set rec_stat = '" & rw.Item("rec_stat") & "' where no_po = '" & rw("no_po") & "'  ", sqlconn, BTRANS).ExecuteNonQuery
                    End With
                ElseIf rw.RowState = DataRowState.Modified Then
                    With New SqlCommand("update PURC.dbo.PURC_PO set rec_stat = '" & rw.Item("rec_stat") & "' where no_po = '" & rw("no_po") & "'  ", sqlconn, BTRANS).ExecuteNonQuery
                    End With
                ElseIf rw.RowState = DataRowState.Deleted Then
                    With New SqlCommand("update PURC.dbo.PURC_PO set rec_stat = '" & rw.Item("rec_stat") & "' where no_po = '" & rw("no_po") & "'  ", sqlconn, BTRANS).ExecuteNonQuery
                    End With
                End If
                If Not rw("status_po") Is DBNull.Value Then
                    If rw("status_po") = "PERBAIKAN" Then
                        If rw.Item("rec_stat") = "APPROVE" Then
                            With New SqlCommand("exec PURC.dbo.perbaikanPO '" & rw("no_po") & "'", sqlconn, BTRANS).ExecuteNonQuery
                            End With
                        End If
                    End If
                End If
            Next

            STATE = "EDIT"
            BTRANS.Commit()

            showMessages("Approval PO berhasil di Update!")
        Catch ex As Exception
            BTRANS.Rollback()
            dSO.Tables("_ApprvPO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        btnDelete = False

        setStatus()

        search()
    End Sub

    Sub ClearData()
        If Not dSO.Tables("_ApprvPO") Is Nothing Then dSO.Tables("_ApprvPO").Clear()
        dSO.Clear()
    End Sub

    Private Sub FrmApprovePO1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        If Not dSO.Tables("_ApprvPO") Is Nothing Then
            dSO.Tables("_ApprvPO").Clear()
        End If

       
        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO po " & _
        "  WHERE po.rec_stat = 'ENTRY' " , sqlconn))
        DA.Fill(dSO, "_ApprvPO")
        GcApprvPO.DataSource = dSO.Tables("_ApprvPO")


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        lookupSupplier.DataSource = ds_cari.Tables("_lookup")
        lookupSupplier.ValueMember = "Kode_Supplier"
        lookupSupplier.DisplayMember = "Nama_Supplier"

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        btnSimpan.Hide()
        btnExit.Hide()

        dsLOV.Tables.Add("stat").Columns.Add("rec_stat")
        Dim rw As DataRow
        rw = dsLOV.Tables("stat").NewRow : rw(0) = "ENTRY"
        dsLOV.Tables("stat").Rows.Add(rw)
        rw = dsLOV.Tables("stat").NewRow : rw(0) = "APPROVE"
        dsLOV.Tables("stat").Rows.Add(rw)
        rw = dsLOV.Tables("stat").NewRow : rw(0) = "PERBAIKAN"
        dsLOV.Tables("stat").Rows.Add(rw)

        LOVstatus.Properties.DataSource = dsLOV.Tables("stat")
        LOVstatus.Properties.ValueMember = "rec_stat"
        LOVstatus.Properties.DisplayMember = "rec_stat"

        LOVstatus.Properties.NullText = "ENTRY"
        LOVstatus.EditValue = "ENTRY"

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub GvApprvPO_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvApprvPO.DoubleClick
        If GvApprvPO.RowCount <> 0 Then


            'milih = GvApprvPO.GetRow(GvApprvPO.GetSelectedRows(0)).Item(2).ToString()
            milih = GvApprvPO.GetFocusedRowCellValue("no_po").ToString()
            'showMessages(milih)
            'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
            'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

            da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
            da_cari.Fill(ds1, "_crpo")
            Dim row As DataRow
            row = ds1.Tables("_crpo").Rows(0)
            If row.Item("tipe_trans") = "JPP-KUT-01" Then
                frmPO.cariPO(milih)
                frmPO.ShowDialog()
            ElseIf row.Item("tipe_trans") = "JPP-KUT-02" Then
                frmPOJasa.cariPO(milih)
                frmPOJasa.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        search()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        dSO.Tables("_ApprvPO").Clear()

        'DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO po,PURC.dbo.PURC_PO_D pod   " & _
        '"  where  po.no_po = pod.no_po " & _
        '"  and pod.inv_stat = 0 ", sqlconn))
        ' where status <> 'APPROVE'

        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO po order by po.no_po desc ", sqlconn))
        DA.Fill(dSO, "_ApprvPO")
        GcApprvPO.DataSource = dSO.Tables("_ApprvPO")
    End Sub

    Sub search()
        dSO.Tables("_ApprvPO").Clear()

        DAsave = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO po " & _
        "  where  po.rec_stat = '" & LOVstatus.EditValue & "' or status_po='" & LOVstatus.EditValue & "' order by po.no_po desc ", sqlconn))

        DAsave.Fill(dSO, "_ApprvPO")
        GcApprvPO.DataSource = dSO.Tables("_ApprvPO")
    End Sub


    Private Sub LOVstatus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVstatus.EditValueChanged
        search()
    End Sub
End Class