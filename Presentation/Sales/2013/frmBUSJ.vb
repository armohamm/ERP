Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmBuatUlangSJ

    Private Sub frmBuatUlangSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        With New SqlCommand("select * from sales.dbo.sales_soj where no_sj = '" & txtNoSj.Text & "'", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then
                If .Item("Tgl_kirim") Is Nothing Then
                    ' Do it Here
                    If proses(.Item("no_sj")) Then
                        lblStatus.Text = ")* OK"
                    Else
                        lblStatus.Text = ")* Nomor Surat Jalan gagal Diproses"
                    End If
                Else
                    lblStatus.Text = ")* Nomor Surat Jalan Sudah Diproses"
                End If
            Else
                lblStatus.Text = ")* Nomor Surat Jalan Salah"
            End If
            .Close()
        End With
    End Sub
    Private Function proses(ByVal no_sj As String) As Boolean
        Dim btrans As SqlTransaction
        Try
            btrans = sqlconn.BeginTransaction
            Dim sqlcmd As New SqlCommand
            Dim thnbln As String
            Dim tgl As Date = getTanggal(btrans).Date
            thnbln = tgl.Year.ToString & ("0" & tgl.Month.ToString).Substring(0, 2)
            sqlcmd.Connection = sqlconn
            sqlcmd.Transaction = btrans
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "sales.dbo.buatUlangSuratJalan"
            sqlcmd.Parameters.Add("@no_sj", SqlDbType.VarChar, 40).Value = no_sj
            sqlcmd.Parameters.Add("@kdpeg", SqlDbType.VarChar, 40).Value = kdpeg
            sqlcmd.ExecuteNonQuery()

            'Dim sqlcmd2 As New SqlCommand
            'sqlcmd2.Connection = sqlconn
            'sqlcmd2.Transaction = btrans
            'sqlcmd2.CommandType = CommandType.StoredProcedure
            'sqlcmd2.CommandText = "sales.[dbo].ExecBookedOut"
            'sqlcmd2.Parameters.AddWithValue("@no_sj", no_sj)
            'sqlcmd2.ExecuteNonQuery()
            btrans.Commit()
            proses = True
        Catch ex As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            proses = False
        End Try
    End Function
End Class