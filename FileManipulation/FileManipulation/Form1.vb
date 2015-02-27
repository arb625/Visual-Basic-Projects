Public Class Form1
    Private Sub ButtonExit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub ButtonExecute_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExecute.Click
        Dim OpenFile1 As New OpenFileDialog
        If RadioButtonUpload.Checked = True And RichTextBox1.Text.Trim().Length = 0 Then
            MsgBox("Error: There is no string to upload.")
        End If
        LabelFilePath.Text = OpenFileDialog1.FileName
        If RadioButtonDownload.Checked = True Then
            OpenFileDialog1.ShowDialog()
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
        If RadioButtonUpload.Checked = True And RichTextBox1.Text.Trim().Length <> 0 Then
            OpenFileDialog1.ShowDialog()
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(OpenFileDialog1.FileName, True)
            file.WriteLine(RichTextBox1.Text)
            file.Close()
        End If
    End Sub
End Class
