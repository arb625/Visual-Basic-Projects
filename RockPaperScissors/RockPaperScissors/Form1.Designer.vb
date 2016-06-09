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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.LabelUserChoice = New System.Windows.Forms.Label()
        Me.LabelComputerChoice = New System.Windows.Forms.Label()
        Me.LabelGameResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Rock", "Paper", "Scissors"})
        Me.ComboBox1.Location = New System.Drawing.Point(287, 84)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(320, 28)
        Me.LabelUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(72, 31)
        Me.LabelUser.TabIndex = 3
        Me.LabelUser.Text = "User"
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlay.Location = New System.Drawing.Point(299, 145)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(133, 53)
        Me.ButtonPlay.TabIndex = 5
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(604, 15)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(121, 41)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(371, 213)
        Me.LabelResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(0, 17)
        Me.LabelResult.TabIndex = 7
        '
        'LabelUserChoice
        '
        Me.LabelUserChoice.AutoSize = True
        Me.LabelUserChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserChoice.Location = New System.Drawing.Point(93, 236)
        Me.LabelUserChoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUserChoice.Name = "LabelUserChoice"
        Me.LabelUserChoice.Size = New System.Drawing.Size(164, 31)
        Me.LabelUserChoice.TabIndex = 8
        Me.LabelUserChoice.Text = "User Choice"
        '
        'LabelComputerChoice
        '
        Me.LabelComputerChoice.AutoSize = True
        Me.LabelComputerChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComputerChoice.Location = New System.Drawing.Point(433, 236)
        Me.LabelComputerChoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelComputerChoice.Name = "LabelComputerChoice"
        Me.LabelComputerChoice.Size = New System.Drawing.Size(225, 31)
        Me.LabelComputerChoice.TabIndex = 9
        Me.LabelComputerChoice.Text = "Computer Choice"
        '
        'LabelGameResult
        '
        Me.LabelGameResult.AutoSize = True
        Me.LabelGameResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGameResult.Location = New System.Drawing.Point(93, 311)
        Me.LabelGameResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGameResult.Name = "LabelGameResult"
        Me.LabelGameResult.Size = New System.Drawing.Size(92, 31)
        Me.LabelGameResult.TabIndex = 10
        Me.LabelGameResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 378)
        Me.Controls.Add(Me.LabelGameResult)
        Me.Controls.Add(Me.LabelComputerChoice)
        Me.Controls.Add(Me.LabelUserChoice)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.ComboBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelUser As System.Windows.Forms.Label
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents LabelUserChoice As System.Windows.Forms.Label
    Friend WithEvents LabelComputerChoice As System.Windows.Forms.Label
    Friend WithEvents LabelGameResult As System.Windows.Forms.Label

End Class
