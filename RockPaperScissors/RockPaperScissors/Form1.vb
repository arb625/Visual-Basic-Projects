Public Class Form1
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        MsgBox("Thanks for playing!")
        Close()
    End Sub

    Private Sub ButtonPlay_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlay.Click
        Dim r As Random = New Random
        Dim rr As Integer = r.Next(3)
        Dim computerChoice As Integer = rr
        Dim userChoice As String = ComboBox1.Text

        Dim pcChoice As String = "Rock"
        If (computerChoice = 1) Then
            pcChoice = "Paper"
        ElseIf (computerChoice = 2) Then
            pcChoice = "Scissors"
        Else : pcChoice = "Rock"
        End If
        If (userChoice = pcChoice) Then
            LabelGameResult.Text = "It's a draw."
        Else
        If (pcChoice = "Rock") Then
            If (userChoice = "Paper") Then
                LabelGameResult.Text = "Paper covers rock. You win."
            Else
                LabelGameResult.Text = "Rock smashes scissors. You lose."
            End If
        ElseIf (pcChoice = "Paper") Then
            If (userChoice = "Rock") Then
                LabelGameResult.Text = "Paper covers rock. You lose."
            Else
                LabelGameResult.Text = "Scissors cut paper. You win."
            End If
        Else
            If (userChoice = "Paper") Then
                LabelGameResult.Text = "Scissors cut paper. You lose."
            Else
                LabelGameResult.Text = "Rock smashes scissors. You win."
            End If
        End If
        End If
        LabelUserChoice.Text = userChoice
        LabelComputerChoice.Text = pcChoice
    End Sub

    Private Sub LabelComputerChoice_Click(sender As Object, e As EventArgs) Handles LabelComputerChoice.Click

    End Sub
End Class
