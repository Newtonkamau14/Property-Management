Public Class HomePage

    Public Shared Fname As String
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        UserIconButton.Text += Fname
    End Sub

    Private Sub ChoosePropertyIconButton_Click(sender As Object, e As EventArgs) Handles ChoosePropertyIconButton.Click
        Form1.Show()
    End Sub


End Class