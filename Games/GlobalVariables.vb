Public Class GlobalVariables

    Public ResPath As String = "C:\Users\Krystian\Desktop\_CS\New\Games\Games\Res\"

    Public Shared Function CreateUser(username, password, email, phone) As String
        Dim QUERY As String = "INSERT INTO user_details (username, [password], email, phone) VALUES ('" & username & "', '" & password & "', '" & email & "', '" & phone & "');"
        Return QUERY
    End Function

End Class
