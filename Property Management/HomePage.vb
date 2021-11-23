Public Class HomePage

    Public Shared Fname As String
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Label1.Text += Fname + "!"
    End Sub

    Private Sub ChoosePropertyIconButton_Click(sender As Object, e As EventArgs) Handles ChoosePropertyIconButton.Click
        ChooseProperty.Show()
    End Sub


End Class