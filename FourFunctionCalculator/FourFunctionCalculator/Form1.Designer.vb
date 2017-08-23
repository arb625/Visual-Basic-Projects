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
        Me.LabelFirstNumber = New System.Windows.Forms.Label()
        Me.LabelSecondNumber = New System.Windows.Forms.Label()
        Me.LabelAnswer = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelFirstNumber
        '
        Me.LabelFirstNumber.AutoSize = True
        Me.LabelFirstNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstNumber.Location = New System.Drawing.Point(35, 19)
        Me.LabelFirstNumber.Name = "LabelFirstNumber"
        Me.LabelFirstNumber.Size = New System.Drawing.Size(138, 26)
        Me.LabelFirstNumber.TabIndex = 0
        Me.LabelFirstNumber.Text = "First Number"
        '
        'LabelSecondNumber
        '
        Me.LabelSecondNumber.AutoSize = True
        Me.LabelSecondNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecondNumber.Location = New System.Drawing.Point(231, 19)
        Me.LabelSecondNumber.Name = "LabelSecondNumber"
        Me.LabelSecondNumber.Size = New System.Drawing.Size(170, 26)
        Me.LabelSecondNumber.TabIndex = 1
        Me.LabelSecondNumber.Text = "Second Number"
        '
        'LabelAnswer
        '
        Me.LabelAnswer.AutoSize = True
        Me.LabelAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnswer.Location = New System.Drawing.Point(178, 194)
        Me.LabelAnswer.Name = "LabelAnswer"
        Me.LabelAnswer.Size = New System.Drawing.Size(85, 26)
        Me.LabelAnswer.TabIndex = 2
        Me.LabelAnswer.Text = "Answer"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(51, 102)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(47, 41)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.Location = New System.Drawing.Point(252, 102)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(47, 41)
        Me.ButtonMultiply.TabIndex = 4
        Me.ButtonMultiply.Text = "x"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubtract.Location = New System.Drawing.Point(150, 102)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(47, 41)
        Me.ButtonSubtract.TabIndex = 5
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(354, 102)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(47, 41)
        Me.ButtonDivide.TabIndex = 6
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(262, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "32"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "66"
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(165, 243)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(98, 39)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 312)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelAnswer)
        Me.Controls.Add(Me.LabelSecondNumber)
        Me.Controls.Add(Me.LabelFirstNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFirstNumber As System.Windows.Forms.Label
    Friend WithEvents LabelSecondNumber As System.Windows.Forms.Label
    Friend WithEvents LabelAnswer As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonMultiply As System.Windows.Forms.Button
    Friend WithEvents ButtonSubtract As System.Windows.Forms.Button
    Friend WithEvents ButtonDivide As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
