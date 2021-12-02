Imports MySql.Data.MySqlClient



Public Class BookingForm
    Dim displaycon As New MySqlConnection("server=localhost; user=root; password=; database=property_management;")


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PropertyPictureBox.Click

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()

    End Sub

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selectedprop As String
        selectedprop = ChooseProperty.AvailableListBox.SelectedItem
        NameTextBox.Text = selectedprop
        Dim displayquery As String
        Dim displayCmd As MySqlCommand


        displayquery = "SELECT area,price,type FROM `forsale` WHERE name LIKE '" & selectedprop & "'"
        displaycon.Open()
        Dim displayReader As MySqlDataReader
        displayCmd = New MySqlCommand(displayquery, displaycon)
        displayReader = displayCmd.ExecuteReader()



        While (displayReader.Read())
            'Add the items from db one by one into the list box.
            areaTextBox.Text = (displayReader.GetString(0))
            PriceTextBox.Text = (displayReader.GetInt32(1))
            TypeTextBox.Text = (displayReader.GetString(2))


        End While

        'Close the reader and the connection.
        displayReader.Close()
        displaycon.Close()

        PropertyPictureBox.BackgroundImage = Image.FromFile("C:\\Users\\Kiguta\\Property-Management\\res\\onebedroompic.jpg")
        PropertyPictureBox.BackgroundImageLayout = ImageLayout.Stretch


    End Sub
End Class