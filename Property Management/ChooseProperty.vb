Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Public Class ChooseProperty
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")


    Private Sub ChooseProperty_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub


    Private Sub BuildingNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackIconButton_Click(sender As Object, e As EventArgs) Handles BackIconButton.Click
        LandingPage.Show()
        Me.Close()
    End Sub


    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim area As String


        Dim sqlquery As String
        Dim myCmd As MySqlCommand
        AvailableListBox.Items.Clear()

        area = AreaComboBox.Text

        'Case statement to determine sql query
        If area = "Gate A" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate A' and type = 'Studio'"
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
        ElseIf area = "Gate B" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'Studio'"
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
        ElseIf area = "Gate c" And StudioRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'Studio'"
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
        ElseIf area = "Gate A" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'Gate A' and type = 'One Bedroom'"
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
        ElseIf area = "Gate B" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'One Bedroom'"
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
        ElseIf area = "Gate C" And OneBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'One Bedroom'"
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
        ElseIf area = "Gate A" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate A' and type = 'Two Bedroom'"
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
        ElseIf area = "Gate B" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate B' and type = 'Two Bedroom'"
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
        ElseIf area = "Gate C" And TwoBedroomRadioButton.Checked = True Then
            sqlquery = "Select * from forsale where area = 'gate C' and type = 'Two Bedroom'"
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
        ElseIf area = "Gate A" And StudioRadioButton.Checked = False Then
            sqlquery = "Select * from forsale where area = 'gate A' and type = 'Two Bedroom'"
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
        Else
            MessageBox.Show("Please select both an area and a type of property.")
        End If


    End Sub

    Private Sub TypeOfApartmentGroupBox_Enter(sender As Object, e As EventArgs) Handles TypeOfApartmentGroupBox.Enter

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        BookingForm.Show()


    End Sub
End Class