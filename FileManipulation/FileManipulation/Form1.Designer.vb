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
        Me.GroupBoxFileOptions = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDownload = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUpload = New System.Windows.Forms.RadioButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonExecute = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelFilePath = New System.Windows.Forms.Label()
        Me.GroupBoxFileOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFileOptions
        '
        Me.GroupBoxFileOptions.Controls.Add(Me.RadioButtonDownload)
        Me.GroupBoxFileOptions.Controls.Add(Me.RadioButtonUpload)
        Me.GroupBoxFileOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFileOptions.Location = New System.Drawing.Point(418, 38)
        Me.GroupBoxFileOptions.Name = "GroupBoxFileOptions"
        Me.GroupBoxFileOptions.Size = New System.Drawing.Size(199, 115)
        Me.GroupBoxFileOptions.TabIndex = 1
        Me.GroupBoxFileOptions.TabStop = False
        Me.GroupBoxFileOptions.Text = "File Options"
        '
        'RadioButtonDownload
        '
        Me.RadioButtonDownload.AutoSize = True
        Me.RadioButtonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDownload.Location = New System.Drawing.Point(24, 67)
        Me.RadioButtonDownload.Name = "RadioButtonDownload"
        Me.RadioButtonDownload.Size = New System.Drawing.Size(113, 28)
        Me.RadioButtonDownload.TabIndex = 1
        Me.RadioButtonDownload.TabStop = True
        Me.RadioButtonDownload.Text = "Download"
        Me.RadioButtonDownload.UseVisualStyleBackColor = True
        '
        'RadioButtonUpload
        '
        Me.RadioButtonUpload.AutoSize = True
        Me.RadioButtonUpload.Checked = True
        Me.RadioButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUpload.Location = New System.Drawing.Point(24, 31)
        Me.RadioButtonUpload.Name = "RadioButtonUpload"
        Me.RadioButtonUpload.Size = New System.Drawing.Size(88, 28)
        Me.RadioButtonUpload.TabIndex = 0
        Me.RadioButtonUpload.TabStop = True
        Me.RadioButtonUpload.Text = "Upload"
        Me.RadioButtonUpload.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(23, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(365, 266)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'ButtonExecute
        '
        Me.ButtonExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExecute.Location = New System.Drawing.Point(459, 178)
        Me.ButtonExecute.Name = "ButtonExecute"
        Me.ButtonExecute.Size = New System.Drawing.Size(113, 33)
        Me.ButtonExecute.TabIndex = 3
        Me.ButtonExecute.Text = "Execute"
        Me.ButtonExecute.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(616, 272)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(90, 43)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelFilePath
        '
        Me.LabelFilePath.AutoSize = True
        Me.LabelFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFilePath.Location = New System.Drawing.Point(58, 291)
        Me.LabelFilePath.Name = "LabelFilePath"
        Me.LabelFilePath.Size = New System.Drawing.Size(78, 24)
        Me.LabelFilePath.TabIndex = 5
        Me.LabelFilePath.Text = "FilePath"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 341)
        Me.Controls.Add(Me.LabelFilePath)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonExecute)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBoxFileOptions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxFileOptions.ResumeLayout(False)
        Me.GroupBoxFileOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxFileOptions As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDownload As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUpload As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonExecute As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelFilePath As System.Windows.Forms.Label

End Class
