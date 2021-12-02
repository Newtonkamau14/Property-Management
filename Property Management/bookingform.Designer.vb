<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.areaTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PropertyPictureBox = New System.Windows.Forms.PictureBox()
        Me.BookButton = New FontAwesome.Sharp.IconButton()
        Me.backButton = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TypeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.areaTextBox)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.PropertyPictureBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(37, 267)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(726, 490)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Property"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(457, 205)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Type"
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(553, 200)
        Me.TypeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(141, 31)
        Me.TypeTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(460, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(553, 267)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(141, 31)
        Me.PriceTextBox.TabIndex = 3
        '
        'areaTextBox
        '
        Me.areaTextBox.Location = New System.Drawing.Point(553, 138)
        Me.areaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.areaTextBox.Name = "areaTextBox"
        Me.areaTextBox.Size = New System.Drawing.Size(141, 31)
        Me.areaTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(553, 78)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(141, 31)
        Me.NameTextBox.TabIndex = 1
        '
        'PropertyPictureBox
        '
        Me.PropertyPictureBox.Location = New System.Drawing.Point(25, 53)
        Me.PropertyPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PropertyPictureBox.Name = "PropertyPictureBox"
        Me.PropertyPictureBox.Size = New System.Drawing.Size(390, 410)
        Me.PropertyPictureBox.TabIndex = 0
        Me.PropertyPictureBox.TabStop = False
        '
        'BookButton
        '
        Me.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.BookButton.IconColor = System.Drawing.Color.Black
        Me.BookButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BookButton.IconSize = 30
        Me.BookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookButton.Location = New System.Drawing.Point(789, 284)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(273, 52)
        Me.BookButton.TabIndex = 27
        Me.BookButton.Text = "Book Property"
        Me.BookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.backButton.IconColor = System.Drawing.Color.Black
        Me.backButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.backButton.IconSize = 30
        Me.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backButton.Location = New System.Drawing.Point(789, 669)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(273, 52)
        Me.backButton.TabIndex = 29
        Me.backButton.Text = "Back"
        Me.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 150)
        Me.Panel1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(205, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(481, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "LOREM PROPERTY MANAGEMENT"
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
        'BookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 867)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BookButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "BookingForm"
        Me.Text = "BookingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents areaTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PropertyPictureBox As PictureBox
    Friend WithEvents BookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents backButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
