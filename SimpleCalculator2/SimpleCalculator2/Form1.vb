Public Class Form1
    Dim Num1 As Single
    Dim Num2 As Single
    Dim Answer As Single
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub RadioButtonAdd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonAdd.CheckedChanged
        LabelSign.Text = "+"
    End Sub

    Private Sub RadioButtonSubtract_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonSubtract.CheckedChanged
        LabelSign.Text = "-"
    End Sub

    Private Sub RadioButtonMultiply_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonMultiply.CheckedChanged
        LabelSign.Text = "x"
    End Sub

    Private Sub RadioButtonDivide_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonDivide.CheckedChanged
        LabelSign.Text = "/"
    End Sub

    Private Sub RadioButtonSquareRoot_CheckedChanged(sender As System.Object, e As System.EventArgs)
        LabelSign.Text = "√"
    End Sub

    Private Sub ButtonSubmit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubmit.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        If RadioButtonAdd.Checked = True Then
            Answer = Num1 + Num2
        ElseIf RadioButtonSubtract.Checked = True Then
            Answer = Num1 - Num2
        ElseIf RadioButtonMultiply.Checked = True Then
            Answer = Num1 * Num2
        ElseIf RadioButtonDivide.Checked = True Then
            Answer = Num1 / Num2
        End If
        LabelAnswer.Text = Answer
    End Sub
End Class
