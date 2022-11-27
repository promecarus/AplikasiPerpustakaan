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
        Dim realPassword As String = EncryptData("1234")
        Dim realUsername As String = "promecarus"

        If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
