Public Class helloWorld

    Dim waitTime As Integer = 500 'ms
    Dim speed As Integer = 40 'ms

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        okButton.Location = New Point(okButton.Location.X, okButton.Location.Y + 1)
        If okButton.Location.Y = 240 Then
            animationTimer.Enabled = False
        End If

    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        waitTimer.Enabled = False
        animationTimer.Enabled = True
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        MessageBox.Show("Hello World!!")

    End Sub

    Private Sub helloWorld_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animationTimer.Enabled = True
        animationTimer.Interval = speed
        waitTimer.Interval = waitTime
        waitTimer.Enabled = True

    End Sub
End Class
