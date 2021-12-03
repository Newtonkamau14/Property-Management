Imports MySql.Data.MySqlClient
Public Class HomePage

    Public Shared Fname As String
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim homeCon As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")

        Dim userName As String
        userName = Login.UserNameTextBox.Text
        Dim homeQuery As String
        Dim homeCmd As MySqlCommand


        homeQuery = "SELECT username FROM `users` WHERE username='" + userName + "'"
        homeCon.Open()
        Dim homeReader As MySqlDataReader
        homeCmd = New MySqlCommand(homeQuery, homeCon)
        homeReader = homeCmd.ExecuteReader()

        While homeReader.Read
            UserNameLabel.Text = userName
        End While

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ChoosePropertyIconButton_Click(sender As Object, e As EventArgs) Handles ChoosePropertyIconButton.Click
        ChooseProperty.Show()
    End Sub

    Private Sub LogoutIconButton_Click(sender As Object, e As EventArgs) Handles LogoutIconButton.Click
        Me.Close()
        LandingPage.Show()
    End Sub
End Class