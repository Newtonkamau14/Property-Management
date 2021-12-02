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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.UserIconButton = New FontAwesome.Sharp.IconButton()
        Me.ChoosePropertyIconButton = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.UserIconButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 150)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(231, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOREM PROPERTY MANAGEMENT"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 66
        Me.IconPictureBox1.Location = New System.Drawing.Point(155, 35)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.IconPictureBox1.TabIndex = 3
        Me.IconPictureBox1.TabStop = False
        '
        'UserIconButton
        '
        Me.UserIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        'ChoosePropertyIconButton
        '
        Me.ChoosePropertyIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChoosePropertyIconButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChoosePropertyIconButton.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.ChoosePropertyIconButton.IconColor = System.Drawing.Color.Black
        Me.ChoosePropertyIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ChoosePropertyIconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChoosePropertyIconButton.Location = New System.Drawing.Point(597, 370)
        Me.ChoosePropertyIconButton.Name = "ChoosePropertyIconButton"
        Me.ChoosePropertyIconButton.Size = New System.Drawing.Size(176, 60)
        Me.ChoosePropertyIconButton.TabIndex = 2
        Me.ChoosePropertyIconButton.Text = "Choose Property"
        Me.ChoosePropertyIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ChoosePropertyIconButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Property_Management.My.Resources.Resources.berlin_307382
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1129, 739)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 739)
        Me.Controls.Add(Me.ChoosePropertyIconButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "HomePage"
        Me.Text = "Home Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChoosePropertyIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UserIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
