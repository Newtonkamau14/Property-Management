<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Me.components = New System.ComponentModel.Container()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordMatchLabel = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.CreatePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.BackIconButton = New FontAwesome.Sharp.IconButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(96, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(241, 31)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(434, 141)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(241, 31)
        Me.ConfirmPasswordTextBox.TabIndex = 3
        Me.ConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(96, 240)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(241, 31)
        Me.EmailAddressTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(96, 141)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(241, 31)
        Me.LastNameTextBox.TabIndex = 5
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(96, 328)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(241, 31)
        Me.PhoneNumberTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Create Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Confirm Passsword"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Controls.Add(Me.PasswordMatchLabel)
        Me.GroupBox1.Controls.Add(Me.ShowPasswordCheckBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.SignUpButton)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.CreatePasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(305, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 564)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Username"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(96, 441)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(241, 31)
        Me.UserNameTextBox.TabIndex = 17
        '
        'PasswordMatchLabel
        '
        Me.PasswordMatchLabel.AutoSize = True
        Me.PasswordMatchLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordMatchLabel.Location = New System.Drawing.Point(437, 246)
        Me.PasswordMatchLabel.Name = "PasswordMatchLabel"
        Me.PasswordMatchLabel.Size = New System.Drawing.Size(0, 22)
        Me.PasswordMatchLabel.TabIndex = 16
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(616, 196)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(157, 29)
        Me.ShowPasswordCheckBox.TabIndex = 15
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GenderComboBox)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(437, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 119)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.GenderComboBox.Location = New System.Drawing.Point(22, 45)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(182, 33)
        Me.GenderComboBox.TabIndex = 0
        '
        'SignUpButton
        '
        Me.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpButton.Location = New System.Drawing.Point(536, 488)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(112, 34)
        Me.SignUpButton.TabIndex = 13
        Me.SignUpButton.Text = "Sign Up"
        Me.SignUpButton.UseVisualStyleBackColor = True
        '
        'CreatePasswordTextBox
        '
        Me.CreatePasswordTextBox.Location = New System.Drawing.Point(434, 36)
        Me.CreatePasswordTextBox.Name = "CreatePasswordTextBox"
        Me.CreatePasswordTextBox.Size = New System.Drawing.Size(241, 31)
        Me.CreatePasswordTextBox.TabIndex = 2
        Me.CreatePasswordTextBox.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1620, 150)
        Me.Panel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(208, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(481, 32)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "LOREM PROPERTY MANAGEMENT"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 66
        Me.IconPictureBox1.Location = New System.Drawing.Point(132, 36)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.IconPictureBox1.TabIndex = 2
        Me.IconPictureBox1.TabStop = False
        '
        'BackIconButton
        '
        Me.BackIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackIconButton.IconColor = System.Drawing.Color.Black
        Me.BackIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackIconButton.Location = New System.Drawing.Point(132, 786)
        Me.BackIconButton.Name = "BackIconButton"
        Me.BackIconButton.Size = New System.Drawing.Size(132, 53)
        Me.BackIconButton.TabIndex = 17
        Me.BackIconButton.Text = "Back"
        Me.BackIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackIconButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Property_Management.My.Resources.Resources.houses_6757774
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1620, 866)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1620, 866)
        Me.Controls.Add(Me.BackIconButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreateAccount"
        Me.Text = "Create Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SignUpButton As Button
    Friend WithEvents CreatePasswordTextBox As TextBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PasswordMatchLabel As Label
    Friend WithEvents BackIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
