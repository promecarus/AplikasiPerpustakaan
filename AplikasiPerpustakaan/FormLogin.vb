Public Class FormLogin
    Dim Users As New ClassUsers

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        If Users.CheckAuth(plainUsername, plainPassword) Then
            FormPerpustakaan.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub
End Class