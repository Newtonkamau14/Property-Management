Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Login
    Private fcon As New FirebaseConfig() With
    {
    .AuthSecret = "re22bCVTGFZl7VQRE7251agFMYdxr2rPJywGAm6d",
    .BasePath = "https://property-management-b7c8c-default-rtdb.firebaseio.com/"
    }

    Private client As IFirebaseClient
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CreateAccountLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccountLinkLabel.LinkClicked
        CreateAccount.Show()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(EmailAddressTextBox.Text) AndAlso String.IsNullOrWhiteSpace(PasswordTextBox.Text)) Then
            MessageBox.Show("Please fill all the fields.")
            Return
        End If
#End Region
        Dim res = client.Get("Users/" + EmailAddressTextBox.Text)
        Dim resUser = res.ResultAs(Of MyUser)

        Dim CurUser As New MyUser With
        {
        .EmailAddress = EmailAddressTextBox.Text,
        .Password = PasswordTextBox.Text
        }

        If (MyUser.IsEqual(resUser, CurUser)) Then

            HomePage.Fname = resUser.FirstName
            HomePage.Show()
            MessageBox.Show("Logged in Successfully")
        Else
            MyUser.ShowError()
        End If
        Me.Close()
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