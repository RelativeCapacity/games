Public Class User

    Inherits GlobalVariables

    Public Avatar As Image
    Public Username As String

    Sub New()
        Avatar = System.Drawing.Image.FromFile(ResPath & "defaultAvatar.bmp")
    End Sub
End Class
