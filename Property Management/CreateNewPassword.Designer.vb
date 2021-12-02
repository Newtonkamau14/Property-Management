<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateNewPassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CreateNewPasswordLabel = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ForgotConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ForgotNewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CreateNewPasswordLabel)
        Me.GroupBox1.Controls.Add(Me.ShowPasswordCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ForgotConfirmPasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.ContinueButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.ForgotNewPasswordTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(434, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 515)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CreateNewPasswordLabel
        '
        Me.CreateNewPasswordLabel.AutoSize = True
        Me.CreateNewPasswordLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreateNewPasswordLabel.Location = New System.Drawing.Point(55, 426)
        Me.CreateNewPasswordLabel.Name = "CreateNewPasswordLabel"
        Me.CreateNewPasswordLabel.Size = New System.Drawing.Size(0, 22)
        Me.CreateNewPasswordLabel.TabIndex = 10
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(319, 377)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(157, 29)
        Me.ShowPasswordCheckBox.TabIndex = 9
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Confirm Password"
        '
        'ForgotConfirmPasswordTextBox
        '
        Me.ForgotConfirmPasswordTextBox.Location = New System.Drawing.Point(55, 314)
        Me.ForgotConfirmPasswordTextBox.Name = "ForgotConfirmPasswordTextBox"
        Me.ForgotConfirmPasswordTextBox.Size = New System.Drawing.Size(282, 31)
        Me.ForgotConfirmPasswordTextBox.TabIndex = 6
        Me.ForgotConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'ContinueButton
        '
        Me.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueButton.Location = New System.Drawing.Point(456, 456)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(112, 34)
        Me.ContinueButton.TabIndex = 5
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password"
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
        'ForgotNewPasswordTextBox
        '
        Me.ForgotNewPasswordTextBox.Location = New System.Drawing.Point(55, 189)
        Me.ForgotNewPasswordTextBox.Name = "ForgotNewPasswordTextBox"
        Me.ForgotNewPasswordTextBox.Size = New System.Drawing.Size(282, 31)
        Me.ForgotNewPasswordTextBox.TabIndex = 1
        Me.ForgotNewPasswordTextBox.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1541, 150)
        Me.Panel1.TabIndex = 2
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
        'CreateNewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1541, 762)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreateNewPassword"
        Me.Text = "Create New Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ForgotConfirmPasswordTextBox As TextBox
    Friend WithEvents ContinueButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents ForgotNewPasswordTextBox As TextBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents CreateNewPasswordLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
