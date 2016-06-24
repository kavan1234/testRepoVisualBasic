Public Class whateverwhocares
    Dim WithEvents f As ApplicationSelector
    Dim WithEvents calc As Form1

    Private Sub whateverwhocares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        applicationSelector()
    End Sub











    'rawr





























    Private Sub whateverwhocares_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo)
        If result = 7 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click

    End Sub

    Private Sub ApplicationSelectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationSelectorToolStripMenuItem.Click
        applicationSelector()
    End Sub

    Private Sub applicationSelector()
        If f Is Nothing Then
            f = New ApplicationSelector
            f.MdiParent = Me
            f.Show()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class