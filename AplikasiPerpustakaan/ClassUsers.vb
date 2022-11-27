Imports System.Security.Cryptography

Public Class ClassUsers
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private user As ArrayList = New ArrayList()

    Public Sub New()
        user.Add({"admin", EncryptData("admin")})
        user.Add({"user", EncryptData("user")})
        user.Add({"promecarus", EncryptData("1")})
    End Sub

    Public Function EncryptData(plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, plainPassword As String) As String
        For Each item In user
            If item(0) = username Then
                Return String.Compare(EncryptData(plainPassword), item(1)) = 0
            End If
        Next
    End Function

    Public Function AddAuth(username As String, password As String) As String
        user.Add({username, EncryptData(password)})
    End Function
End Class
