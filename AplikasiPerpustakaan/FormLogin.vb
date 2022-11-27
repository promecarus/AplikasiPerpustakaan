Public Class FormLogin
    Dim Users As New ClassUsers

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Try
            If Users.CheckAuth(plainUsername, plainPassword) Then
                FormPerpustakaan.Show()
            Else
                MessageBox.Show("Password Salah")
            End If
        Catch ex As Exception
            MessageBox.Show("Anda Belum Terdaftar")
        End Try
    End Sub
End Class