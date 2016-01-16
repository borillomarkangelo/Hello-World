<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helloWorld
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
        Me.components = New System.ComponentModel.Container()
        Me.okButton = New System.Windows.Forms.Button()
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.okButton.Location = New System.Drawing.Point(95, 43)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(115, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "&OK"
        Me.okButton.UseVisualStyleBackColor = False
        '
        'animationTimer
        '
        '
        'waitTimer
        '
        '
        'helloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(303, 260)
        Me.Controls.Add(Me.okButton)
        Me.Name = "helloWorld"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents animationTimer As System.Windows.Forms.Timer
    Friend WithEvents waitTimer As System.Windows.Forms.Timer

End Class
