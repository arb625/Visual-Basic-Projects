Public Class Modified

    Private Sub Modified_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = True
    End Sub

    Private Sub cmdRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRock.Click

        Label1.Visible = True

        Dim r As Random = New Random
        Dim rr As Integer = r.Next(3)
        Dim computerChoice As Integer = rr
        Dim pcChoice As String = "Rock"

        If (computerChoice = 1) Then
            pcChoice = "Paper"
        ElseIf (computerChoice = 2) Then
            pcChoice = "Scissor"
        Else : pcChoice = "Rock"
        End If

        If (pcChoice = "Paper") Then
            Label1.Text = "Paper covers rock. You lose."
        ElseIf (pcChoice = "Scissor") Then
            Label1.Text = "Rock smashes scissors. You win."
        Else
            Label1.Text = "The battle is draw"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label1.Visible = True

        Dim r As Random = New Random
        Dim rr As Integer = r.Next(3)
        Dim computerChoice As Integer = rr
        Dim pcChoice As String = "Paper"

        If (computerChoice = 1) Then
            pcChoice = "Paper"
        ElseIf (computerChoice = 2) Then
            pcChoice = "Scissor"
        Else : pcChoice = "Rock"
        End If

        If (pcChoice = "Scissor") Then
            Label1.Text = "Scissors cut paper. You lose."
        ElseIf (pcChoice = "Rock") Then
            Label1.Text = "Paper covers rock. You win."
        Else
            Label1.Text = "The battle is draw"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Label1.Visible = True

        Dim r As Random = New Random
        Dim rr As Integer = r.Next(3)
        Dim computerChoice As Integer = rr
        Dim pcChoice As String = "Scissor"

        If (computerChoice = 1) Then
            pcChoice = "Paper"
        ElseIf (computerChoice = 2) Then
            pcChoice = "Scissor"
        Else : pcChoice = "Rock"
        End If

        If (pcChoice = "Rock") Then
            Label1.Text = "Rock smashes scissors. You lose."
        ElseIf (pcChoice = "Paper") Then
            Label1.Text = "Scissors cut paper. You win."
        Else
            Label1.Text = "The battle is draw"
        End If
    End Sub

End Class