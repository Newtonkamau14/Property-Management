Public Class ChooseProperty
    Dim area = New String() {"Gate A", "Gate B", "Gate C"}
    Dim gatea = New String() {"UAP Tower", "GTC Tower", "Prism Tower", "Britam Tower"}
    Dim gateb = New String() {"Chrysler Building", " Vanderbilt", "Park Avenue"}
    Dim gatec = New String() {"HSBC", "Heron", "Citigroup"}
    Private Sub ChooseProperty_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        AreaComboBox.MaxDropDownItems = area.Length
        For stepper = 0 To (area.Length - 1)
            AreaComboBox.Items.Add(area(stepper))
        Next


    End Sub




    Private Sub BuildingNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        ' MessageBox.Show()
    End Sub

    Private Sub nextIconButton_Click(sender As Object, e As EventArgs) Handles nextIconButton.Click
        Form2.Show()
    End Sub
End Class