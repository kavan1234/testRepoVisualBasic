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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOp = New System.Windows.Forms.TextBox()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.panGrp = New System.Windows.Forms.Panel()
        Me.btnGrp = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(494, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Operation"
        '
        'txtOp
        '
        Me.txtOp.Enabled = False
        Me.txtOp.Location = New System.Drawing.Point(367, 65)
        Me.txtOp.MaxLength = 32769
        Me.txtOp.Name = "txtOp"
        Me.txtOp.Size = New System.Drawing.Size(121, 20)
        Me.txtOp.TabIndex = 52
        Me.txtOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(291, 133)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(37, 36)
        Me.btnDiv.TabIndex = 51
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(291, 93)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(37, 36)
        Me.btnMinus.TabIndex = 50
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(245, 133)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(40, 36)
        Me.btnMult.TabIndex = 49
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(367, 146)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(121, 23)
        Me.btnClr.TabIndex = 48
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(494, 116)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(42, 13)
        Me.lblAns.TabIndex = 47
        Me.lblAns.Text = "Answer"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(494, 93)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(53, 13)
        Me.lblNum2.TabIndex = 46
        Me.lblNum2.Text = "Number 2"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(494, 42)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(53, 13)
        Me.lblNum1.TabIndex = 45
        Me.lblNum1.Text = "Number 1"
        '
        'txtAns
        '
        Me.txtAns.Enabled = False
        Me.txtAns.Location = New System.Drawing.Point(367, 115)
        Me.txtAns.MaxLength = 32769
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(121, 20)
        Me.txtAns.TabIndex = 44
        Me.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum2
        '
        Me.txtNum2.Enabled = False
        Me.txtNum2.Location = New System.Drawing.Point(367, 89)
        Me.txtNum2.MaxLength = 32769
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(121, 20)
        Me.txtNum2.TabIndex = 43
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum1
        '
        Me.txtNum1.Enabled = False
        Me.txtNum1.Location = New System.Drawing.Point(367, 39)
        Me.txtNum1.MaxLength = 32769
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(121, 20)
        Me.txtNum1.TabIndex = 42
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panGrp
        '
        Me.panGrp.AutoScroll = True
        Me.panGrp.Location = New System.Drawing.Point(335, 323)
        Me.panGrp.Name = "panGrp"
        Me.panGrp.Size = New System.Drawing.Size(212, 157)
        Me.panGrp.TabIndex = 41
        '
        'btnGrp
        '
        Me.btnGrp.Location = New System.Drawing.Point(223, 380)
        Me.btnGrp.Name = "btnGrp"
        Me.btnGrp.Size = New System.Drawing.Size(75, 29)
        Me.btnGrp.TabIndex = 40
        Me.btnGrp.Text = "Show"
        Me.btnGrp.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(245, 179)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(83, 29)
        Me.btnEquals.TabIndex = 39
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(245, 93)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 36)
        Me.btnPlus.TabIndex = 38
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(107, 218)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(48, 36)
        Me.btn0.TabIndex = 37
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(175, 172)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(48, 36)
        Me.btn9.TabIndex = 36
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(107, 172)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(48, 36)
        Me.btn8.TabIndex = 35
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(39, 172)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(48, 36)
        Me.btn7.TabIndex = 34
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(175, 133)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(48, 36)
        Me.btn6.TabIndex = 33
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(107, 133)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(48, 36)
        Me.btn5.TabIndex = 32
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(39, 133)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(48, 36)
        Me.btn4.TabIndex = 31
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(175, 93)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(48, 36)
        Me.btn3.TabIndex = 30
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(107, 93)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(48, 36)
        Me.btn2.TabIndex = 29
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(39, 93)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(48, 36)
        Me.btn1.TabIndex = 28
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtSum
        '
        Me.txtSum.Enabled = False
        Me.txtSum.Location = New System.Drawing.Point(29, 39)
        Me.txtSum.MaxLength = 32769
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(299, 20)
        Me.txtSum.TabIndex = 27
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOp)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.panGrp)
        Me.Controls.Add(Me.btnGrp)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtSum)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOp As TextBox
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents lblAns As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents txtAns As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents panGrp As Panel
    Friend WithEvents btnGrp As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents txtSum As TextBox
End Class
