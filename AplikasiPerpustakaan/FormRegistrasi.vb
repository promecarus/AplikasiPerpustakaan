Public Class FormRegistrasi
    Private Sub ButtonRegistrasi_Click(sender As Object, e As EventArgs) Handles ButtonRegistrasi.Click
        If TextBoxUsername.Text.Length > 0 And TextBoxPassword.Text.Length > 0 Then
            'FormLogin.Users.AddAuth(TextBoxUsername.Text, TextBoxPassword.Text)
            FormLogin.Users.AddUsersDatabase(TextBoxUsername.Text, TextBoxPassword.Text)
            Me.Close()
            FormLogin.Show()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub

    Private Sub FormRegistrasi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormLogin.Show()
    End Sub
End Class