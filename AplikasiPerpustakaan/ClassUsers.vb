Imports System.Security.Cryptography

Public Class ClassUsers
    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
        Dim credentials = New Dictionary(Of String, String) From {
            {"admin", EncryptData("admin")},
            {"user", EncryptData("user")},
            {"promecarus", EncryptData("1")}
        }

        Dim tempPassword As String = ""
        If credentials.TryGetValue(username, tempPassword) Then
            Return String.Compare(EncryptData(plainPassword), tempPassword) = 0
        End If
    End Function
End Class
