
Public Class LandingPage


    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized

        Dim OpacityPercentage As Single
        OpacityPercentage = 0.3

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Login.Show()
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        CreateAccount.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ChooseProperty.Show()
    End Sub
End Class
