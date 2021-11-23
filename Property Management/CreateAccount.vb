Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class CreateAccount
    Private fcon As New FirebaseConfig() With
    {
    .AuthSecret = "re22bCVTGFZl7VQRE7251agFMYdxr2rPJywGAm6d",
    .BasePath = "https://property-management-b7c8c-default-rtdb.firebaseio.com/"
    }

    Public client As IFirebaseClient


    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(FirstNameTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(LastNameTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(EmailAddressTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(CreatePasswordTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text)) Then
            MessageBox.Show("Please fill all the fields.")
            Return
        End If
#End Region
        Dim reg As New HomePage
        reg.ShowDialog()
        Dim NewUser As New MyUser() With
        {
        .FirstName = FirstNameTextBox.Text,
        .LastName = LastNameTextBox.Text,
        .EmailAddress = EmailAddressTextBox.Text,
        .PhoneNumber = PhoneNumberTextBox.Text,
        .Password = ConfirmPasswordTextBox.Text
        }

        Dim setter = client.Set("Users/" + EmailAddressTextBox.Text, NewUser)
        MessageBox.Show("registered successfully")
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            CreatePasswordTextBox.UseSystemPasswordChar = True
            ConfirmPasswordTextBox.UseSystemPasswordChar = True
        Else
            CreatePasswordTextBox.UseSystemPasswordChar = False
            ConfirmPasswordTextBox.UseSystemPasswordChar = False
        End If
    End Sub
End Class