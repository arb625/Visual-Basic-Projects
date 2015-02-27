
Public Class Form1

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://www.espncricinfo.com/")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("http://espn.go.com/nba/")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://www.atpworldtour.com/")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Label1.Text = "Hello World!"
    End Sub

    Private Sub Form1_ResizeBegin(sender As System.Object, e As System.EventArgs) Handles MyBase.ResizeBegin
        Label1.Text = "You can resize the form as you wish."
    End Sub

    Private Sub Form1_ResizeEnd(sender As System.Object, e As System.EventArgs) Handles MyBase.ResizeEnd
        Label1.Text = "Pop up"
    End Sub

    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
        Label1.Text = "This is a great site for learning about cricket."
    End Sub

    Private Sub Button2_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button2.MouseHover
        Label1.Text = "You can check basketball scores here."
    End Sub

    Private Sub Button3_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button3.MouseHover
        Label1.Text = "Click on this button if you like tennis."
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Label1.Text = "Pop up"
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Label1.Text = "Pop up"
    End Sub

    Private Sub Button3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button3.MouseLeave
        Label1.Text = "Pop up"
    End Sub

    Private Sub Button4_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button4.MouseHover
        Label1.Text = "Do you want to leave the client?"
    End Sub

    Private Sub Button4_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button4.MouseLeave
        Label1.Text = "Pop up"
    End Sub
End Class
