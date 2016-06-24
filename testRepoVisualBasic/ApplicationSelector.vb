Public Class ApplicationSelector
    Dim WithEvents myCalc As Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        newCalc()
    End Sub

    Private Sub unHide() Handles myCalc.Closing
        Me.Show()
    End Sub

    Public Sub newCalc()
        If myCalc IsNot Nothing Then
            myCalc.Close()
        End If
        myCalc = New Form1
        myCalc.Show()
        myCalc.MdiParent = whateverwhocares
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class