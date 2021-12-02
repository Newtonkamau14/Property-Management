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
        Me.AvailableListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShowButton = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.TypeOfApartmentGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AreaComboBox
        '
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Items.AddRange(New Object() {"Gate A", "Gate B", "Gate C"})
        Me.AreaComboBox.Location = New System.Drawing.Point(81, 35)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(183, 33)
        Me.AreaComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(7, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Location"
        '
        'BackIconButton
        '
        Me.BackIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackIconButton.IconColor = System.Drawing.Color.Black
        Me.BackIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackIconButton.IconSize = 30
        Me.BackIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackIconButton.Location = New System.Drawing.Point(43, 775)
        Me.BackIconButton.Name = "BackIconButton"
        Me.BackIconButton.Size = New System.Drawing.Size(130, 52)
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
        Me.TypeOfApartmentGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TypeOfApartmentGroupBox.Location = New System.Drawing.Point(9, 118)
        Me.TypeOfApartmentGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TypeOfApartmentGroupBox.Name = "TypeOfApartmentGroupBox"
        Me.TypeOfApartmentGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TypeOfApartmentGroupBox.Size = New System.Drawing.Size(340, 278)
        Me.TypeOfApartmentGroupBox.TabIndex = 19
        Me.TypeOfApartmentGroupBox.TabStop = False
        Me.TypeOfApartmentGroupBox.Text = "Type of Apartment"
        '
        'PenthouseRadioButton
        '
        Me.PenthouseRadioButton.AutoSize = True
        Me.PenthouseRadioButton.Location = New System.Drawing.Point(49, 215)
        Me.PenthouseRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PenthouseRadioButton.Name = "PenthouseRadioButton"
        Me.PenthouseRadioButton.Size = New System.Drawing.Size(119, 29)
        Me.PenthouseRadioButton.TabIndex = 4
        Me.PenthouseRadioButton.TabStop = True
        Me.PenthouseRadioButton.Text = "Penthouse"
        Me.PenthouseRadioButton.UseVisualStyleBackColor = True
        '
        'LoftRadioButton
        '
        Me.LoftRadioButton.AutoSize = True
        Me.LoftRadioButton.Location = New System.Drawing.Point(51, 173)
        Me.LoftRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoftRadioButton.Name = "LoftRadioButton"
        Me.LoftRadioButton.Size = New System.Drawing.Size(68, 29)
        Me.LoftRadioButton.TabIndex = 3
        Me.LoftRadioButton.TabStop = True
        Me.LoftRadioButton.Text = "Loft"
        Me.LoftRadioButton.UseVisualStyleBackColor = True
        '
        'TwoBedroomRadioButton
        '
        Me.TwoBedroomRadioButton.AutoSize = True
        Me.TwoBedroomRadioButton.Location = New System.Drawing.Point(49, 127)
        Me.TwoBedroomRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TwoBedroomRadioButton.Name = "TwoBedroomRadioButton"
        Me.TwoBedroomRadioButton.Size = New System.Drawing.Size(148, 29)
        Me.TwoBedroomRadioButton.TabIndex = 2
        Me.TwoBedroomRadioButton.TabStop = True
        Me.TwoBedroomRadioButton.Text = "Two Bedroom"
        Me.TwoBedroomRadioButton.UseVisualStyleBackColor = True
        '
        'OneBedroomRadioButton
        '
        Me.OneBedroomRadioButton.AutoSize = True
        Me.OneBedroomRadioButton.Location = New System.Drawing.Point(49, 85)
        Me.OneBedroomRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OneBedroomRadioButton.Name = "OneBedroomRadioButton"
        Me.OneBedroomRadioButton.Size = New System.Drawing.Size(149, 29)
        Me.OneBedroomRadioButton.TabIndex = 1
        Me.OneBedroomRadioButton.TabStop = True
        Me.OneBedroomRadioButton.Text = "One Bedroom"
        Me.OneBedroomRadioButton.UseVisualStyleBackColor = True
        '
        'StudioRadioButton
        '
        Me.StudioRadioButton.AutoSize = True
        Me.StudioRadioButton.Location = New System.Drawing.Point(49, 43)
        Me.StudioRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StudioRadioButton.Name = "StudioRadioButton"
        Me.StudioRadioButton.Size = New System.Drawing.Size(178, 29)
        Me.StudioRadioButton.TabIndex = 0
        Me.StudioRadioButton.TabStop = True
        Me.StudioRadioButton.Text = "Studio Apartment"
        Me.StudioRadioButton.UseVisualStyleBackColor = True
        '
        'CheckButton
        '
        Me.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.CheckButton.IconColor = System.Drawing.Color.Black
        Me.CheckButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CheckButton.IconSize = 30
        Me.CheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckButton.Location = New System.Drawing.Point(289, 677)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(203, 52)
        Me.CheckButton.TabIndex = 21
        Me.CheckButton.Text = "Check Availability"
        Me.CheckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'AvailableListBox
        '
        Me.AvailableListBox.FormattingEnabled = True
        Me.AvailableListBox.ItemHeight = 25
        Me.AvailableListBox.Location = New System.Drawing.Point(740, 209)
        Me.AvailableListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AvailableListBox.Name = "AvailableListBox"
        Me.AvailableListBox.Size = New System.Drawing.Size(341, 304)
        Me.AvailableListBox.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AreaComboBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TypeOfApartmentGroupBox)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(289, 193)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(419, 430)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.ShowButton.IconColor = System.Drawing.Color.Black
        Me.ShowButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ShowButton.IconSize = 30
        Me.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowButton.Location = New System.Drawing.Point(818, 571)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(191, 52)
        Me.ShowButton.TabIndex = 28
        Me.ShowButton.Text = "Show Property"
        Me.ShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1484, 150)
        Me.Panel1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(205, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(481, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LOREM PROPERTY MANAGEMENT"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 66
        Me.IconPictureBox1.Location = New System.Drawing.Point(129, 38)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'ChooseProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 869)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AvailableListBox)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.BackIconButton)
        Me.Name = "ChooseProperty"
        Me.Text = "Choose Property"
        Me.TypeOfApartmentGroupBox.ResumeLayout(False)
        Me.TypeOfApartmentGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AvailableListBox As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ShowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
