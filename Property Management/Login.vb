Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.ComponentModel


Public Class Login
    Dim loginCon As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNameTextBox.SelectionStart = UserNameTextBox.Text.Length
        UserNameTextBox.SelectionLength = 0

        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub CreateAccountLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccountLinkLabel.LinkClicked
        CreateAccount.Show()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserNameTextBox.Text) AndAlso String.IsNullOrWhiteSpace(PasswordTextBox.Text)) Then
            MessageBox.Show("Please fill all the fields.")
            Return
        End If
#End Region
        Dim loginQuery As String
        Dim loginCmd As MySqlCommand
        loginQuery = "SELECT username, password FROM `users` WHERE username='" + UserNameTextBox.Text + "' AND password='" + PasswordTextBox.Text + "'"
        loginCon.Open()
        Dim loginReader As MySqlDataReader
        loginCmd = New MySqlCommand(loginQuery, loginCon)
        loginReader = loginCmd.ExecuteReader()

        If (loginReader.Read = True) Then
            MessageBox.Show("Logged in Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HomePage.Show()
            Me.Close()
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        loginReader.Close()
        loginCon.Close()


    End Sub

    Private Sub ForgotPasswordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLinkLabel.LinkClicked
        CreateNewPassword.Show()
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        Me.Close()
    End Sub

End Class