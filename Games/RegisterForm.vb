Imports System.Data.OleDb

Public Class RegisterForm

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        user.Text = ""
        pass.Text = ""
        email.Text = ""
        phone.Text = ""
        Me.Hide()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Krystian\Desktop\_CS\New\Games\USERS.accdb")
            Connection.Open()
            Dim QUERY As String = ""
            QUERY = GlobalVariables.CreateUser(user.Text, pass.Text, email.Text, phone.Text)
            MsgBox(QUERY.ToString)
            Dim Command As New OleDbCommand(QUERY, Connection)
            Command.ExecuteNonQuery()
        End Using
    End Sub
End Class