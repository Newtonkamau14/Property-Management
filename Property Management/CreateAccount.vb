Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.ComponentModel


Public Class CreateAccount



    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        ToolTip1.SetToolTip(CreatePasswordTextBox, "Password must have uppercase letter,8 characters long & special character")
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


        Dim createCon As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")
        Dim createCmd As New MySqlCommand("INSERT INTO `users`(`username`, `firstname`, `lastname`, `emailaddress`, `phonenumber`, `gender`, `password`) 
            VALUES 
                    ('" + UserNameTextBox.Text + "','" + FirstNameTextBox.Text + "','" + LastNameTextBox.Text + "',
                     '" + EmailAddressTextBox.Text + "','" + PhoneNumberTextBox.Text + "','" + GenderComboBox.SelectedItem.ToString() + "',
                     '" + ConfirmPasswordTextBox.Text + "'
                    )", createCon)

        createCon.Open()
        createCmd.ExecuteNonQuery()

        MessageBox.Show("registered successfully")
        createCon.Close()
        HomePage.Show()
        Me.Close()
    End Sub

    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function



    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 1,
        Optional ByVal numLower As Integer = 2,
        Optional ByVal numNumbers As Integer = 1,
        Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function
    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            CreatePasswordTextBox.UseSystemPasswordChar = False
            ConfirmPasswordTextBox.UseSystemPasswordChar = False
        Else
            CreatePasswordTextBox.UseSystemPasswordChar = True
            ConfirmPasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        Me.Close()
    End Sub

    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        If CreatePasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            PasswordMatchLabel.Text = "Passwords Match"
            PasswordMatchLabel.ForeColor = Color.Lime
        Else
            PasswordMatchLabel.Text = "Passwords Don't Match"
            PasswordMatchLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub EmailAddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles EmailAddressTextBox.Validating
        Dim email As String = EmailAddressTextBox.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." &
                                       " Do you want re-enter it?", "Invalid Email Address",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub CreatePasswordTextBox_Validating(sender As Object, e As EventArgs) Handles CreatePasswordTextBox.Validating
        Dim strongPassword As String
        strongPassword = CreatePasswordTextBox.Text 'textbox containing password
        If ValidatePassword(strongPassword) = True Then
            MessageBox.Show("Strong Password")
        Else
            MessageBox.Show("Weak Password")
        End If
    End Sub
End Class