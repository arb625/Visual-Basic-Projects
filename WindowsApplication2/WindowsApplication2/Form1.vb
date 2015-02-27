Public Class Form1

    Private Sub ButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdd.Click
        Dim item As String
        item = TextBox1.Text
        ListBox1.Items.Add(item)
    End Sub

    Private Sub ButtonHelp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHelp.Click
        MsgBox("You can add items to a list by typing them in the text box and clicking add.")
    End Sub
End Class
