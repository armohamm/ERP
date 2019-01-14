Public Class frmODBC
    Private hasil As Boolean
    Public Function test() As Boolean
        Dim sqlcon As New SqlClient.SqlConnection
        lblState.Text = "Menghubungkan..."
        sqlconn.ConnectionString = "Data Source=" & txtServer.Text & ";Initial Catalog=SIF;Integrated Security=false;user=" & txtuser.Text & ";password=" & txtPasswd.Text & ";MultipleActiveResultSets=True"
        Try
            sqlconn.Open()
            lblState.Text = "Koneksi Berhasil"
            lblState.ForeColor = Color.Green
            Return True
            sqlcon.Close()
        Catch ex As Exception
            lblState.Text = "Koneksi Gagal. " & vbCrLf & ex.Message
            lblState.ForeColor = Color.Red
            Return False
        End Try
    End Function

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        hasil = test()
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click

    End Sub
End Class