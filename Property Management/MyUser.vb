Public Class MyUser
    Public Property FirstName() As String
    Public Property LastName() As String
    Public Property EmailAddress() As String
    Public Property PhoneNumber() As Integer
    Public Property Password() As String

    Private Shared TheError As String = " Email Address not found."

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As MyUser, user2 As MyUser)
        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "Email not found"
            Return False
        End If

        If (user1.EmailAddress <> user2.EmailAddress) Then
            TheError = "Email not found"
            Return False

        ElseIf (user1.Password <> user2.Password) Then
            TheError = "Email and password does not match"
                Return False

        End If
        Return True
    End Function
End Class
