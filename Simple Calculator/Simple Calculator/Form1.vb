Public Class Form1
    Dim Num1 As Single
    Dim Num2 As Single
    Dim Answer As Single
    Private Sub ButtonSubmit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubmit.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Answer = Num1 + Num2
        LabelAnswer.Text = Answer
    End Sub

    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class
