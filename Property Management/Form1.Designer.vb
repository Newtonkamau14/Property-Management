<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ForRentIconButton = New FontAwesome.Sharp.IconButton()
        Me.ForPurchaseIconButton = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'ForRentIconButton
        '
        Me.ForRentIconButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForRentIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.ForRentIconButton.IconChar = FontAwesome.Sharp.IconChar.Hourglass
        Me.ForRentIconButton.IconColor = System.Drawing.Color.Black
        Me.ForRentIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ForRentIconButton.IconSize = 20
        Me.ForRentIconButton.Location = New System.Drawing.Point(295, 60)
        Me.ForRentIconButton.Name = "ForRentIconButton"
        Me.ForRentIconButton.Size = New System.Drawing.Size(121, 44)
        Me.ForRentIconButton.TabIndex = 18
        Me.ForRentIconButton.Text = "For Rent"
        Me.ForRentIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ForRentIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ForRentIconButton.UseVisualStyleBackColor = True
        '
        'ForPurchaseIconButton
        '
        Me.ForPurchaseIconButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.ForPurchaseIconButton.IconColor = System.Drawing.Color.Black
        Me.ForPurchaseIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ForPurchaseIconButton.IconSize = 30
        Me.ForPurchaseIconButton.Location = New System.Drawing.Point(295, 154)
        Me.ForPurchaseIconButton.Name = "ForPurchaseIconButton"
        Me.ForPurchaseIconButton.Size = New System.Drawing.Size(121, 48)
        Me.ForPurchaseIconButton.TabIndex = 19
        Me.ForPurchaseIconButton.Text = "For Purchase"
        Me.ForPurchaseIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ForPurchaseIconButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ForPurchaseIconButton)
        Me.Controls.Add(Me.ForRentIconButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ForRentIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ForPurchaseIconButton As FontAwesome.Sharp.IconButton
End Class
