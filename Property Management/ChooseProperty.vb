Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Public Class ChooseProperty
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")


    Private Sub ChooseProperty_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        'con.Open()
        'If con.State = ConnectionState.Open Then
        'MsgBox("Database connected!")
        'Else
        'MsgBox("Error connecting to database.")
        'End If







    End Sub




    Private Sub BuildingNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        LandingPage.Show()
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        ' MessageBox.Show()
    End Sub

    Private Sub nextIconButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles BookButton.Click

    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim area As String

        Dim sqlquery As String
        Dim myCmd As MySqlCommand
        AvailableListBox.Items.Clear()

        area = AreaComboBox.Text

        'If statement to determine sql query
        If area = "Gate A" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate A' and type = 'Studio'"
        ElseIf area = "Gate B" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'Studio'"
        ElseIf area = "Gate c" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'Studio'"
        ElseIf area = "Gate A" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'Gate A' and type = 'One Bedroom'"
        ElseIf area = "Gate B" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'One Bedroom'"
        ElseIf area = "Gate C" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'One Bedroom'"
        ElseIf area = "Gate A" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate A' and type = 'Two Bedroom'"
        ElseIf area = "Gate B" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'Two Bedroom'"
        ElseIf area = "Gate C" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'Two Bedroom'"
        End If
        con.Open()

        myCmd = New MySqlCommand(sqlquery, con)
        Dim myReader As MySqlDataReader
        myReader = myCmd.ExecuteReader()



        While (myReader.Read())
            'Add the items from db one by one into the list box.
            AvailableListBox.Items.Add(myReader.GetString(1))
        End While

        'Close the reader and the connection.
        myReader.Close()
        con.Close()






















    End Sub

    Private Sub TypeOfApartmentGroupBox_Enter(sender As Object, e As EventArgs) Handles TypeOfApartmentGroupBox.Enter

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim selectedprop As String
        selectedprop = AvailableListBox.SelectedIndex.ToString
        MessageBox.Show(selectedprop)
    End Sub
End Class