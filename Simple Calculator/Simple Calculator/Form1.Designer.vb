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
        Me.LabelFirstNum = New System.Windows.Forms.Label()
        Me.LabelSecondNum = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelAnswer = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelAdd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelFirstNum
        '
        Me.LabelFirstNum.AutoSize = True
        Me.LabelFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstNum.Location = New System.Drawing.Point(41, 26)
        Me.LabelFirstNum.Name = "LabelFirstNum"
        Me.LabelFirstNum.Size = New System.Drawing.Size(138, 26)
        Me.LabelFirstNum.TabIndex = 0
        Me.LabelFirstNum.Text = "First Number"
        '
        'LabelSecondNum
        '
        Me.LabelSecondNum.AutoSize = True
        Me.LabelSecondNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecondNum.Location = New System.Drawing.Point(20, 155)
        Me.LabelSecondNum.Name = "LabelSecondNum"
        Me.LabelSecondNum.Size = New System.Drawing.Size(170, 26)
        Me.LabelSecondNum.TabIndex = 1
        Me.LabelSecondNum.Text = "Second Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 194)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'LabelAnswer
        '
        Me.LabelAnswer.AutoSize = True
        Me.LabelAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnswer.Location = New System.Drawing.Point(61, 240)
        Me.LabelAnswer.Name = "LabelAnswer"
        Me.LabelAnswer.Size = New System.Drawing.Size(85, 26)
        Me.LabelAnswer.TabIndex = 5
        Me.LabelAnswer.Text = "Answer"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(12, 298)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubmit.TabIndex = 6
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(133, 298)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 7
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelAdd
        '
        Me.LabelAdd.AutoSize = True
        Me.LabelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd.Location = New System.Drawing.Point(97, 115)
        Me.LabelAdd.Name = "LabelAdd"
        Me.LabelAdd.Size = New System.Drawing.Size(25, 26)
        Me.LabelAdd.TabIndex = 8
        Me.LabelAdd.Text = "+"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 366)
        Me.Controls.Add(Me.LabelAdd)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelAnswer)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelSecondNum)
        Me.Controls.Add(Me.LabelFirstNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFirstNum As System.Windows.Forms.Label
    Friend WithEvents LabelSecondNum As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelAnswer As System.Windows.Forms.Label
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelAdd As System.Windows.Forms.Label

End Class
