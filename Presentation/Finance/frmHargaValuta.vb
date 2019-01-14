Imports System.Data.SqlClient
Public Class frmHargaValuta
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal, daThn, daBln, daLookUp As SqlDataAdapter

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim isOK As Boolean = True
    Private Sub frmKalkulasiNeraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadLookUp()
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookNoPo") Is Nothing Then dsLookUp.Tables("LookNoPo").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT no_po FROM PURC.dbo.PURC_PO", sqlconn))
        daLookUp.Fill(dsLookUp, "LookNoPo")
        LookUpNoPo.Properties.DataSource = dsLookUp.Tables("LookNoPo")
        LookUpNoPo.Properties.DisplayMember = "no_po"
        LookUpNoPo.Properties.ValueMember = "no_po"

        If Not dsLookUp.Tables("LookNoCsp") Is Nothing Then dsLookUp.Tables("LookNoCsp").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT no_csp FROM PURC.dbo.PURC_CHOICE_SUPP", sqlconn))
        daLookUp.Fill(dsLookUp, "LookCsp")
        LookUpCSP.Properties.DataSource = dsLookUp.Tables("LookCsp")
        LookUpCSP.Properties.DisplayMember = "no_csp"
        LookUpCSP.Properties.ValueMember = "no_csp"
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        Try
            call_procedure(LookUpNoPo.EditValue, LookUpCSP.EditValue, TextBox2.Text)
            showMessages("Proses Berhasil Disimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub call_procedure(ByVal nopo As String, ByVal nocsp As String, ByVal harga As Integer)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PURC.dbo.update_harga_PO"

        sqlCmd.Parameters.Add("@kurs_valuta", SqlDbType.Int).Value = harga
        sqlCmd.Parameters.Add("@no_po", SqlDbType.Char).Value = nopo
        sqlCmd.Parameters.Add("@no_csp", SqlDbType.Char).Value = nocsp
        sqlCmd.ExecuteNonQuery()

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class