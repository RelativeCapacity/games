Public Class Start

    Public CURRENT_USER As New User

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Avatar.BackgroundImage = CURRENT_USER.Avatar
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginRegister.Show()
    End Sub
End Class