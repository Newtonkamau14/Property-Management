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
        Me.StudioRadioButton = New System.Windows.Forms.RadioButton()
        Me.OneBedroomRadioButton = New System.Windows.Forms.RadioButton()
        Me.TwoBedroomRadioButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.nextIconButton = New FontAwesome.Sharp.IconButton()
        Me.TypeOfApartmentGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AreaComboBox
        '
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(378, 48)
        Me.AreaComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(129, 23)
        Me.AreaComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(403, 31)
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
        Me.BackIconButton.Location = New System.Drawing.Point(266, 288)
        Me.BackIconButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackIconButton.Name = "BackIconButton"
        Me.BackIconButton.Size = New System.Drawing.Size(121, 31)
        Me.BackIconButton.TabIndex = 16
        Me.BackIconButton.Text = "Back"
        Me.BackIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackIconButton.UseVisualStyleBackColor = True
        '
        'TypeOfApartmentGroupBox
        '
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.RadioButton2)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.RadioButton1)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.TwoBedroomRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.OneBedroomRadioButton)
        Me.TypeOfApartmentGroupBox.Controls.Add(Me.StudioRadioButton)
        Me.TypeOfApartmentGroupBox.Location = New System.Drawing.Point(305, 92)
        Me.TypeOfApartmentGroupBox.Name = "TypeOfApartmentGroupBox"
        Me.TypeOfApartmentGroupBox.Size = New System.Drawing.Size(238, 167)
        Me.TypeOfApartmentGroupBox.TabIndex = 19
        Me.TypeOfApartmentGroupBox.TabStop = False
        Me.TypeOfApartmentGroupBox.Text = "Type of Apartment"
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(36, 104)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Loft"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(34, 129)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 19)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Penthouse"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'nextIconButton
        '
        Me.nextIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nextIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.nextIconButton.IconColor = System.Drawing.Color.Black
        Me.nextIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nextIconButton.IconSize = 30
        Me.nextIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nextIconButton.Location = New System.Drawing.Point(473, 288)
        Me.nextIconButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextIconButton.Name = "nextIconButton"
        Me.nextIconButton.Size = New System.Drawing.Size(121, 31)
        Me.nextIconButton.TabIndex = 20
        Me.nextIconButton.Text = "Next"
        Me.nextIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nextIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.nextIconButton.UseVisualStyleBackColor = True
        '
        'ChooseProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 449)
        Me.Controls.Add(Me.nextIconButton)
        Me.Controls.Add(Me.TypeOfApartmentGroupBox)
        Me.Controls.Add(Me.BackIconButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AreaComboBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ChooseProperty"
        Me.Text = "Choose Property"
        Me.TypeOfApartmentGroupBox.ResumeLayout(False)
        Me.TypeOfApartmentGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AreaComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents TypeOfApartmentGroupBox As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TwoBedroomRadioButton As RadioButton
    Friend WithEvents OneBedroomRadioButton As RadioButton
    Friend WithEvents StudioRadioButton As RadioButton
    Friend WithEvents nextIconButton As FontAwesome.Sharp.IconButton
End Class
