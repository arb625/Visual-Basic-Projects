Public Class Form1
    Dim Num1 As Single
    Dim Num2 As Single
    Dim Answer As Single
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles LabelSecondNumber.Click

    End Sub

    Private Sub ButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdd.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Answer = Num1 + Num2
        LabelAnswer.Text = Answer
    End Sub

    Private Sub ButtonSubtract_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubtract.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Answer = Num1 - Num2
        LabelAnswer.Text = Answer
    End Sub

    Private Sub ButtonMultiply_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMultiply.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Answer = Num1 * Num2
        LabelAnswer.Text = Answer
    End Sub

    Private Sub ButtonDivide_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDivide.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Answer = Num1 / Num2
        LabelAnswer.Text = Answer
    End Sub

    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub LabelFirstNumber_Click(sender As System.Object, e As System.EventArgs) Handles LabelFirstNumber.Click

    End Sub
End Class
