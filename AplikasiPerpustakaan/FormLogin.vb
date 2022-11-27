Public Class FormLogin
    Dim Users As New ClassUsers

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)

        If AuthStatus Then
            FormPerpustakaan.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub
End Class