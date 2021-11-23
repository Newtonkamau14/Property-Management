Public Class CreateNewPassword
    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(EmailAddressTextBox.Text) Or String.IsNullOrWhiteSpace(ForgotNewPasswordTextBox.Text) Or
            String.IsNullOrWhiteSpace(ForgotConfirmPasswordTextBox.Text)) Then
            MessageBox.Show("Please fill all the fields.")
            Return
        End If

#End Region
    End Sub
End Class