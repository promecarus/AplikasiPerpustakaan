Public Class FormLogin
    Public Shared Perpustakaan As ClassPerpustakaan
    Public Shared Users As ClassUsers

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New ClassPerpustakaan()
        Users = New ClassUsers()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSUsername = data_user(1)
            FormPerpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If
    End Sub

    Private Sub LinkLabelRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRegister.LinkClicked
        Me.Hide()
        FormRegistrasi.Show()
    End Sub
End Class