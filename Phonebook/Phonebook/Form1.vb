Public Class Form1

    Private Sub ButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdd.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("F:\Phonebook.txt", True)
        file.WriteLine(TextBoxFirstName.Text + " " + TextBoxLastName.Text + " " + TextBoxNumber.Text)
        file.Close()
    End Sub
End Class
