Public Class frmEnkrip 

    Private Sub cmdEkrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEkrip.Click
        If txtenkrip.Text <> "" Then
            If txtkey.Text <> "" Then
                txtdekrip.Text = AES_Encrypt(txtenkrip.Text, txtkey.Text)
            End If
        End If
    End Sub

    Private Sub cmdDekrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDekrip.Click
        If txtdekrip.Text <> "" Then
            If txtkey.Text <> "" Then
                txtenkrip.Text = AES_Decrypt(txtdekrip.Text, txtkey.Text)
            End If
        End If
    End Sub
End Class