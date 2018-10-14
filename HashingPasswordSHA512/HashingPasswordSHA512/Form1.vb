Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Text
Public Class Form1
    Private Function GenerateSHA512String(ByVal password) As String
        Dim SHA512 As SHA512 = SHA512Managed.Create()
        Dim Bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim Hash As Byte() = SHA512.ComputeHash(Bytes)
        Dim StringBuilder As New StringBuilder()

        For i As Integer = 0 To Hash.Length - 1
            StringBuilder.Append(Hash(i).ToString("x2"))
        Next
        Return StringBuilder.ToString
    End Function

    Private Function GenerateToBase64(ByVal password) As String
        Dim SHA512 As SHA512 = SHA512Managed.Create()
        Dim Bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim StringBuilder As New StringBuilder()

        Return Convert.ToBase64String(Bytes)
    End Function

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim PasswordInput As String = txtPassword.Text
        Dim Hashing = GenerateSHA512String(PasswordInput)
        Dim MinMaxChar As New Regex("^.{8,15}$")

        If MinMaxChar.IsMatch(PasswordInput) Then
            lbPassword.Text = "Password : " + PasswordInput
            richTextHashing.Text = Hashing
            Hashing64.Text = GenerateToBase64(PasswordInput)
        Else
            MsgBox("Minimun 8 Karakter Dan Maksimal 15 Karakter", MsgBoxStyle.OkOnly, "Validasi")
            txtPassword.Clear()
            lbPassword.Text = "Password : "
            richTextHashing.Clear()
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtPassword.MaxLength = 15
    End Sub
End Class
