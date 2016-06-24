Public Class Class1
    Inherits GroupBox
    Dim var As New Label
    Private _borderColor As Color
    Public Sub New()
        MyBase.New
        Me.Text = "This Box"
        Me.Size = New Size(100, 100)
        Me._borderColor = Color.Black
        var.Text = "This text label"
        var.Size = New Size(80, 13)
        var.Location = New Point(10, 50)
        Controls.Add(var)
    End Sub

    'Stuff for border color DO NOT MESS WITH

    Public Property BorderColor() As Color
        Get
            Return Me._borderColor
        End Get
        Set(ByVal value As Color)
            Me._borderColor = value
        End Set
    End Property

    Protected Overrides Sub OnMove(e As EventArgs)
        Me.Invalidate()
        MyBase.OnMove(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        Me.Update()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = (borderRect.Y + (tSize.Height / 2))
        borderRect.Height = (borderRect.Height - (tSize.Height / 2))
        ControlPaint.DrawBorder(e.Graphics, borderRect, Me._borderColor,
        ButtonBorderStyle.Solid)
        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), textRect)
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect)
    End Sub

End Class
