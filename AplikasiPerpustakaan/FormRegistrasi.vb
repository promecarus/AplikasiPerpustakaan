Public Class FormRegistrasi
    Private Sub ButtonRegistrasi_Click(sender As Object, e As EventArgs) Handles ButtonRegistrasi.Click
        FormLogin.Users.AddAuth(TextBoxUsername.Text, TextBoxPassword.Text)
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub FormRegistrasi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormLogin.Show()
    End Sub
End Class