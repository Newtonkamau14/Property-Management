<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChooseProperty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackIconButton = New FontAwesome.Sharp.IconButton()
        Me.TypeOfApartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.PenthouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.LoftRadioButton = New System.Windows.Forms.RadioButton()
        Me.TwoBedroomRadioButton = New System.Windows.Forms.RadioButton()
        Me.OneBedroomRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudioRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckButton = New FontAwesome.Sharp.IconButton()
        Me.BookButton = New FontAwesome.Sharp.IconButton()
        Me.AvailableListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowButton = New FontAwesome.Sharp.IconButton()
        Me.TypeOfApartmentGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AreaComboBox
        '
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Items.AddRange(New Object() {"Gate A", "Gate B", "Gate C"})
        Me.AreaComboBox.Location = New System.Drawing.Point(57, 21)
        Me.AreaComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(129, 23)
        Me.AreaComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Location"
        '
        'BackIconButton
        '
        Me.BackIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackIconButton.IconColor = System.Drawing.Color.Black
        Me.BackIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackIconButton.IconSize = 30
        Me.BackIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackIconButton.Location = New System.Drawing.Point(30, 11)
        Me.BackIconButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackIconButton.Name = "BackIconButton"
        Me.BackIconButton.Size = New System.Drawing.Size(91, 31)
        Me.BackIconButton.TabIndex = 16
        Me.BackIconButton.Text = "Back"
        Me.BackIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackIconButton.UseVisualStyleBackColor = True
        '
        'TypeOfApartmentGroupBox
        '
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.PenthouseRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.LoftRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.TwoBedroomRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.OneBedroomRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.StudioRadioButton)
        Me.TypeOfApartmentGroupBox.Location = New System.Drawing.Point(6, 71)
        Me.TypeOfApartmentGroupBox.Name = "TypeOfApartmentGroupBox"
        Me.TypeOfApartmentGroupBox.Size = New System.Drawing.Size(238, 167)
        Me.TypeOfApartmentGroupBox.TabIndex = 19
        Me.TypeOfApartmentGroupBox.TabStop = False
        Me.TypeOfApartmentGroupBox.Text = "Type of Apartment"
        '
        'PenthouseRadioButton
        '
        Me.PenthouseRadioButton.AutoSize = True
        Me.PenthouseRadioButton.Location = New System.Drawing.Point(34, 129)
        Me.PenthouseRadioButton.Name = "PenthouseRadioButton"
        Me.PenthouseRadioButton.Size = New System.Drawing.Size(81, 19)
        Me.PenthouseRadioButton.TabIndex = 4
        Me.PenthouseRadioButton.TabStop = True
        Me.PenthouseRadioButton.Text = "Penthouse"
        Me.PenthouseRadioButton.UseVisualStyleBackColor = True
        '
        'LoftRadioButton
        '
        Me.LoftRadioButton.AutoSize = True
        Me.LoftRadioButton.Location = New System.Drawing.Point(36, 104)
        Me.LoftRadioButton.Name = "LoftRadioButton"
        Me.LoftRadioButton.Size = New System.Drawing.Size(46, 19)
        Me.LoftRadioButton.TabIndex = 3
        Me.LoftRadioButton.TabStop = True
        Me.LoftRadioButton.Text = "Loft"
        Me.LoftRadioButton.UseVisualStyleBackColor = True
        '
        'TwoBedroomRadioButton
        '
        Me.TwoBedroomRadioButton.AutoSize = True
        Me.TwoBedroomRadioButton.Location = New System.Drawing.Point(34, 76)
        Me.TwoBedroomRadioButton.Name = "TwoBedroomRadioButton"
        Me.TwoBedroomRadioButton.Size = New System.Drawing.Size(98, 19)
        Me.TwoBedroomRadioButton.TabIndex = 2
        Me.TwoBedroomRadioButton.TabStop = True
        Me.TwoBedroomRadioButton.Text = "Two Bedroom"
        Me.TwoBedroomRadioButton.UseVisualStyleBackColor = True
        '
        'OneBedroomRadioButton
        '
        Me.OneBedroomRadioButton.AutoSize = True
        Me.OneBedroomRadioButton.Location = New System.Drawing.Point(34, 51)
        Me.OneBedroomRadioButton.Name = "OneBedroomRadioButton"
        Me.OneBedroomRadioButton.Size = New System.Drawing.Size(99, 19)
        Me.OneBedroomRadioButton.TabIndex = 1
        Me.OneBedroomRadioButton.TabStop = True
        Me.OneBedroomRadioButton.Text = "One Bedroom"
        Me.OneBedroomRadioButton.UseVisualStyleBackColor = True
        '
        'StudioRadioButton
        '
        Me.StudioRadioButton.AutoSize = True
        Me.StudioRadioButton.Location = New System.Drawing.Point(34, 26)
        Me.StudioRadioButton.Name = "StudioRadioButton"
        Me.StudioRadioButton.Size = New System.Drawing.Size(119, 19)
        Me.StudioRadioButton.TabIndex = 0
        Me.StudioRadioButton.TabStop = True
        Me.StudioRadioButton.Text = "Studio Apartment"
        Me.StudioRadioButton.UseVisualStyleBackColor = True
        '
        'CheckButton
        '
        Me.CheckButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.CheckButton.IconColor = System.Drawing.Color.Black
        Me.CheckButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CheckButton.IconSize = 30
        Me.CheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckButton.Location = New System.Drawing.Point(12, 341)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(142, 31)
        Me.CheckButton.TabIndex = 21
        Me.CheckButton.Text = "Check Availability"
        Me.CheckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'BookButton
        '
        Me.BookButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.BookButton.IconColor = System.Drawing.Color.Black
        Me.BookButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BookButton.IconSize = 30
        Me.BookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookButton.Location = New System.Drawing.Point(723, 366)
        Me.BookButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(191, 31)
        Me.BookButton.TabIndex = 22
        Me.BookButton.Text = "Book Property"
        Me.BookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'AvailableListBox
        '
        Me.AvailableListBox.FormattingEnabled = True
        Me.AvailableListBox.ItemHeight = 15
        Me.AvailableListBox.Location = New System.Drawing.Point(327, 71)
        Me.AvailableListBox.Name = "AvailableListBox"
        Me.AvailableListBox.Size = New System.Drawing.Size(240, 184)
        Me.AvailableListBox.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(602, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 294)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Property"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(69, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 108)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AreaComboBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TypeOfApartmentGroupBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 258)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 215)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'ShowButton
        '
        Me.ShowButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.ShowButton.IconColor = System.Drawing.Color.Black
        Me.ShowButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ShowButton.IconSize = 30
        Me.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowButton.Location = New System.Drawing.Point(348, 282)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(134, 31)
        Me.ShowButton.TabIndex = 28
        Me.ShowButton.Text = "Show Property"
        Me.ShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ChooseProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 449)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AvailableListBox)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.BackIconButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChooseProperty"
        Me.Text = "Choose Property"
        Me.TypeOfApartmentGroupBox.ResumeLayout(False)
        Me.TypeOfApartmentGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AreaComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents TypeOfApartmentGroupBox As GroupBox
    Friend WithEvents PenthouseRadioButton As RadioButton
    Friend WithEvents LoftRadioButton As RadioButton
    Friend WithEvents TwoBedroomRadioButton As RadioButton
    Friend WithEvents OneBedroomRadioButton As RadioButton
    Friend WithEvents StudioRadioButton As RadioButton
    Friend WithEvents CheckButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AvailableListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ShowButton As FontAwesome.Sharp.IconButton
End Class
