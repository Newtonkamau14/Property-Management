<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookingform
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(31, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 294)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Property"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Type"
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(387, 120)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.TypeTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(387, 160)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PriceTextBox.TabIndex = 3
        '
        'areaTextBox
        '
        Me.areaTextBox.Location = New System.Drawing.Point(387, 83)
        Me.areaTextBox.Name = "areaTextBox"
        Me.areaTextBox.Size = New System.Drawing.Size(100, 23)
        Me.areaTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(387, 47)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'PropertyPictureBox
        '
        Me.PropertyPictureBox.Location = New System.Drawing.Point(6, 22)
        Me.PropertyPictureBox.Name = "PropertyPictureBox"
        Me.PropertyPictureBox.Size = New System.Drawing.Size(273, 246)
        Me.PropertyPictureBox.TabIndex = 0
        Me.PropertyPictureBox.TabStop = False
        '
        'BookButton
        '
        Me.BookButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.BookButton.IconColor = System.Drawing.Color.Black
        Me.BookButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BookButton.IconSize = 30
        Me.BookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookButton.Location = New System.Drawing.Point(561, 49)
        Me.BookButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(191, 31)
        Me.BookButton.TabIndex = 27
        Me.BookButton.Text = "Book Property"
        Me.BookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp
        Me.backButton.IconColor = System.Drawing.Color.Black
        Me.backButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.backButton.IconSize = 30
        Me.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backButton.Location = New System.Drawing.Point(561, 291)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(191, 31)
        Me.backButton.TabIndex = 29
        Me.backButton.Text = "Back"
        Me.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.backButton.UseVisualStyleBackColor = True
        '
        'bookingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BookButton)
        Me.Name = "bookingform"
        Me.Text = "bookingform"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
