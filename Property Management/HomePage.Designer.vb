<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserIconButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ChoosePropertyIconButton = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.UserIconButton)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 150)
        Me.Panel1.TabIndex = 1
        '
        'UserIconButton
        '
        Me.UserIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIconButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserIconButton.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.UserIconButton.IconColor = System.Drawing.Color.Black
        Me.UserIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UserIconButton.Location = New System.Drawing.Point(944, 26)
        Me.UserIconButton.Name = "UserIconButton"
        Me.UserIconButton.Size = New System.Drawing.Size(113, 101)
        Me.UserIconButton.TabIndex = 4
        Me.UserIconButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UserIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UserIconButton.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(238, 26)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(624, 100)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "LOREM PROPERTY MANAGEMENT"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'ChoosePropertyIconButton
        '
        Me.ChoosePropertyIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChoosePropertyIconButton.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.ChoosePropertyIconButton.IconColor = System.Drawing.Color.Black
        Me.ChoosePropertyIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ChoosePropertyIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChoosePropertyIconButton.Location = New System.Drawing.Point(472, 360)
        Me.ChoosePropertyIconButton.Name = "ChoosePropertyIconButton"
        Me.ChoosePropertyIconButton.Size = New System.Drawing.Size(176, 60)
        Me.ChoosePropertyIconButton.TabIndex = 2
        Me.ChoosePropertyIconButton.Text = "Choose Property"
        Me.ChoosePropertyIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ChoosePropertyIconButton.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 739)
        Me.Controls.Add(Me.ChoosePropertyIconButton)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HomePage"
        Me.Text = "Home Page"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ChoosePropertyIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UserIconButton As FontAwesome.Sharp.IconButton
End Class
