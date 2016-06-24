Public Class Form1
    Dim num1 As String = vbNullString
    Dim num2 As String = vbNullString
    Dim operation As String = vbNullString
    Dim reset As Boolean = 0
    'get the enter key to work
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    'number button handler
    Private Sub btnNumberClick(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click,
                                                                            btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        'Handle reseting the fields
        If reset Then
            myClear()
        End If
        If GetAsyncKeyState(13) Then
            btnEquals.PerformClick()
        Else
            Dim number As Integer = Convert.ToInt16(CType(sender, Button).Name.Substring(3, 1))
            txtSum.Text &= number
        End If

    End Sub
    'Handles key presses from numpad :D
    Private Sub numpadkey(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad0
                btn0.PerformClick()
            Case Keys.NumPad1
                btn1.PerformClick()
            Case Keys.NumPad2
                btn2.PerformClick()
            Case Keys.NumPad3
                btn3.PerformClick()
            Case Keys.NumPad4
                btn4.PerformClick()
            Case Keys.NumPad5
                btn5.PerformClick()
            Case Keys.NumPad6
                btn6.PerformClick()
            Case Keys.NumPad7
                btn7.PerformClick()
            Case Keys.NumPad8
                btn8.PerformClick()
            Case Keys.NumPad9
                btn9.PerformClick()
            Case Keys.Enter
                btnEquals.PerformClick()
            Case Keys.Add
                btnPlus.PerformClick()
            Case Keys.Subtract
                btnMinus.PerformClick()
            Case Keys.Multiply
                btnMult.PerformClick()
            Case Keys.Divide
                btnDiv.PerformClick()
        End Select

    End Sub
    'operation handler
    Private Sub btnOperation(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMult.Click, btnDiv.Click
        If reset Then
            myClear()
        End If
        If txtSum.Text <> vbNullString Or operation <> vbNullString Then
            If sender Is btnPlus Then
                operation = "+"
            ElseIf sender Is btnMinus Then
                operation = "-"
            ElseIf sender Is btnMult Then
                operation = "*"
            ElseIf sender Is btnDiv Then
                operation = "/"
            End If
            setUp()
        End If
    End Sub

    'Sets up the text and clears the sum box
    Private Sub setUp()
        'setup fields
        txtOp.Text = operation
        If num1 = vbNullString Then
            num1 = txtSum.Text
            txtNum1.Text = txtSum.Text
        End If
        txtSum.Clear()
    End Sub

    'clear button handler
    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        myClear()
    End Sub

    'This function handles clearing fields
    Private Sub myClear()
        txtSum.Clear()
        txtNum1.Clear()
        txtNum2.Clear()
        txtAns.Clear()
        txtOp.Clear()
        num1 = vbNullString
        num2 = vbNullString
        operation = vbNullString
        reset = 0
    End Sub

    'Display sum, after sum displayed set reset to 1 so that new info can be entered
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        'if the operation has not been selected yet, then do nothing
        If (operation <> vbNullString) Then
            num2 = txtSum.Text
            txtNum2.Text = txtSum.Text
            If (num1 = vbNullString) Then
                num1 = "0"
                txtNum1.Text = "0"
            End If
            If (num2 = vbNullString) Then
                num2 = "0"
                txtNum2.Text = "0"
            End If
            txtAns.Text = myOperation(num1, num2, operation)
            reset = 1
        End If
    End Sub

    'Handles the math
    Private Function myOperation(ByVal first As String, ByVal second As String, ByVal operation As String) As String
        Select Case operation
            Case "+"
                Try
                    Return Convert.ToInt64(first) + Convert.ToInt64(second)
                Catch ex As Exception
                    Return "Too large of number"
                End Try
            Case "-"
                Try
                    Return Convert.ToInt64(first) - Convert.ToInt64(second)
                Catch ex As Exception
                    Return "Too small of number"
                End Try
            Case "*"
                Try
                    Return Convert.ToInt64(first) * Convert.ToInt64(second)
                Catch ex As Exception
                    Return "Too large of number"
                End Try
            Case "/"
                Try
                    Return Convert.ToInt64(first) / Convert.ToInt64(second)
                Catch ex As Exception
                    Return "Failed"
                End Try
        End Select
        Return 1
    End Function

    'Groupbox stuff
    Private Sub btnGrp_Click(sender As Object, e As EventArgs) Handles btnGrp.Click
        Dim group1 As New Class1
        panGrp.Controls.Add(group1)
    End Sub

End Class
