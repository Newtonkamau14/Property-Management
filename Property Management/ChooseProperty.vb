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

        If AreaComboBox.SelectedIndex = 0 Then
            BuildingNameComboBox.MaxDropDownItems = area.Length
            For interval = 0 To (gatea.Length - 1)
                BuildingNameComboBox.Items.Add(gatea(interval))
            Next

        ElseIf AreaComboBox.SelectedIndex = 1 Then
            BuildingNameComboBox.MaxDropDownItems = area.Length
            For i = 0 To (gateb.Length - 1)
                BuildingNameComboBox.Items.Add(gateb(i))
            Next

        ElseIf AreaComboBox.SelectedIndex = 2 Then
            BuildingNameComboBox.MaxDropDownItems = area.Length
            For stp = 0 To (gatec.Length - 1)
                BuildingNameComboBox.Items.Add(gatec(stp))
            Next
        End If
    End Sub
    Private Sub AreaComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BuildingNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        Me.Close()
    End Sub
End Class