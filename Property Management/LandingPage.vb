Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class LandingPage

    Private fcon As New FirebaseConfig() With
    {
    .AuthSecret = "re22bCVTGFZl7VQRE7251agFMYdxr2rPJywGAm6d",
    .BasePath = "https://property-management-b7c8c-default-rtdb.firebaseio.com/"
    }

    Public client As IFirebaseClient
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("There was a problem with your Internet")
        End Try

        Me.WindowState = FormWindowState.Maximized

        Dim OpacityPercentage As Single
        OpacityPercentage = 0.3

        'PictureBox1.Image = Image.FromFile("C:\Users\Admin\Desktop\bitmap branco.png")
        'PictureBox1.Image.Dispose()
        'PictureBox1.Image = ChangeOpacity(Image.FromFile("C:\Users\Admin\Desktop\bitmap branco.png"), OpacityPercentage)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Login.Show()
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        CreateAccount.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
