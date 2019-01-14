Public Class frmBG

    Private Sub frmBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.Culture.Name <> "id-ID" Then
            MsgBox("Harap Mengganti Regional Dengan Indonesia Terlebih Dahulu", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Peringatan!")
            End
        End If
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.Refresh()
        frmLogin.ShowDialog(Me)
    End Sub

End Class