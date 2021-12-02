<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.CreateAccountLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ForgotPasswordLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.BackIconButton = New FontAwesome.Sharp.IconButton()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShowPasswordCheckBox)
        Me.GroupBox1.Controls.Add(Me.CreateAccountLinkLabel)
        Me.GroupBox1.Controls.Add(Me.ForgotPasswordLinkLabel)
        Me.GroupBox1.Controls.Add(Me.LoginButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(489, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(229, 243)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(157, 29)
        Me.ShowPasswordCheckBox.TabIndex = 8
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'CreateAccountLinkLabel
        '
        Me.CreateAccountLinkLabel.AutoSize = True
        Me.CreateAccountLinkLabel.Location = New System.Drawing.Point(357, 313)
        Me.CreateAccountLinkLabel.Name = "CreateAccountLinkLabel"
        Me.CreateAccountLinkLabel.Size = New System.Drawing.Size(132, 25)
        Me.CreateAccountLinkLabel.TabIndex = 7
        Me.CreateAccountLinkLabel.TabStop = True
        Me.CreateAccountLinkLabel.Text = "Create Account"
        '
        'ForgotPasswordLinkLabel
        '
        Me.ForgotPasswordLinkLabel.AutoSize = True
        Me.ForgotPasswordLinkLabel.Location = New System.Drawing.Point(55, 313)
        Me.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel"
        Me.ForgotPasswordLinkLabel.Size = New System.Drawing.Size(146, 25)
        Me.ForgotPasswordLinkLabel.TabIndex = 6
        Me.ForgotPasswordLinkLabel.TabStop = True
        Me.ForgotPasswordLinkLabel.Text = "Forgot Password"
        '
        'LoginButton
        '
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Location = New System.Drawing.Point(55, 367)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(112, 34)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Email Address"
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(55, 80)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(282, 31)
        Me.EmailAddressTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(55, 189)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(282, 31)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1600, 150)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(205, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOREM PROPERTY MANAGEMENT"
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
        'BackIconButton
        '
        Me.BackIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackIconButton.IconColor = System.Drawing.Color.Black
        Me.BackIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackIconButton.Location = New System.Drawing.Point(129, 692)
        Me.BackIconButton.Name = "BackIconButton"
        Me.BackIconButton.Size = New System.Drawing.Size(132, 53)
        Me.BackIconButton.TabIndex = 17
        Me.BackIconButton.Text = "Back"
        Me.BackIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackIconButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 757)
        Me.Controls.Add(Me.BackIconButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CreateAccountLinkLabel As LinkLabel
    Friend WithEvents ForgotPasswordLinkLabel As LinkLabel
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label3 As Label
End Class
