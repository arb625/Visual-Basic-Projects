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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelSecondNum = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBoxOperator = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDivide = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMultiply = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSubtract = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAdd = New System.Windows.Forms.RadioButton()
        Me.LabelAnswer = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelSign = New System.Windows.Forms.Label()
        Me.GroupBoxOperator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelFirstNum
        '
        Me.LabelFirstNum.AutoSize = True
        Me.LabelFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstNum.Location = New System.Drawing.Point(32, 19)
        Me.LabelFirstNum.Name = "LabelFirstNum"
        Me.LabelFirstNum.Size = New System.Drawing.Size(138, 26)
        Me.LabelFirstNum.TabIndex = 1
        Me.LabelFirstNum.Text = "First Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'LabelSecondNum
        '
        Me.LabelSecondNum.AutoSize = True
        Me.LabelSecondNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecondNum.Location = New System.Drawing.Point(22, 156)
        Me.LabelSecondNum.Name = "LabelSecondNum"
        Me.LabelSecondNum.Size = New System.Drawing.Size(170, 26)
        Me.LabelSecondNum.TabIndex = 5
        Me.LabelSecondNum.Text = "Second Number"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(49, 202)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'GroupBoxOperator
        '
        Me.GroupBoxOperator.Controls.Add(Me.RadioButtonDivide)
        Me.GroupBoxOperator.Controls.Add(Me.RadioButtonMultiply)
        Me.GroupBoxOperator.Controls.Add(Me.RadioButtonSubtract)
        Me.GroupBoxOperator.Controls.Add(Me.RadioButtonAdd)
        Me.GroupBoxOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOperator.Location = New System.Drawing.Point(216, 34)
        Me.GroupBoxOperator.Name = "GroupBoxOperator"
        Me.GroupBoxOperator.Size = New System.Drawing.Size(225, 188)
        Me.GroupBoxOperator.TabIndex = 9
        Me.GroupBoxOperator.TabStop = False
        Me.GroupBoxOperator.Text = "Operation"
        '
        'RadioButtonDivide
        '
        Me.RadioButtonDivide.AutoSize = True
        Me.RadioButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDivide.Location = New System.Drawing.Point(40, 144)
        Me.RadioButtonDivide.Name = "RadioButtonDivide"
        Me.RadioButtonDivide.Size = New System.Drawing.Size(70, 24)
        Me.RadioButtonDivide.TabIndex = 3
        Me.RadioButtonDivide.TabStop = True
        Me.RadioButtonDivide.Text = "Divide"
        Me.RadioButtonDivide.UseVisualStyleBackColor = True
        '
        'RadioButtonMultiply
        '
        Me.RadioButtonMultiply.AutoSize = True
        Me.RadioButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMultiply.Location = New System.Drawing.Point(40, 108)
        Me.RadioButtonMultiply.Name = "RadioButtonMultiply"
        Me.RadioButtonMultiply.Size = New System.Drawing.Size(79, 24)
        Me.RadioButtonMultiply.TabIndex = 2
        Me.RadioButtonMultiply.TabStop = True
        Me.RadioButtonMultiply.Text = "Multiply"
        Me.RadioButtonMultiply.UseVisualStyleBackColor = True
        '
        'RadioButtonSubtract
        '
        Me.RadioButtonSubtract.AutoSize = True
        Me.RadioButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSubtract.Location = New System.Drawing.Point(40, 72)
        Me.RadioButtonSubtract.Name = "RadioButtonSubtract"
        Me.RadioButtonSubtract.Size = New System.Drawing.Size(88, 24)
        Me.RadioButtonSubtract.TabIndex = 1
        Me.RadioButtonSubtract.TabStop = True
        Me.RadioButtonSubtract.Text = "Subtract"
        Me.RadioButtonSubtract.UseVisualStyleBackColor = True
        '
        'RadioButtonAdd
        '
        Me.RadioButtonAdd.AutoSize = True
        Me.RadioButtonAdd.Checked = True
        Me.RadioButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAdd.Location = New System.Drawing.Point(40, 36)
        Me.RadioButtonAdd.Name = "RadioButtonAdd"
        Me.RadioButtonAdd.Size = New System.Drawing.Size(56, 24)
        Me.RadioButtonAdd.TabIndex = 0
        Me.RadioButtonAdd.TabStop = True
        Me.RadioButtonAdd.Text = "Add"
        Me.RadioButtonAdd.UseVisualStyleBackColor = True
        '
        'LabelAnswer
        '
        Me.LabelAnswer.AutoSize = True
        Me.LabelAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnswer.Location = New System.Drawing.Point(60, 283)
        Me.LabelAnswer.Name = "LabelAnswer"
        Me.LabelAnswer.Size = New System.Drawing.Size(85, 26)
        Me.LabelAnswer.TabIndex = 10
        Me.LabelAnswer.Text = "Answer"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Location = New System.Drawing.Point(65, 242)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubmit.TabIndex = 11
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(280, 283)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 12
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelSign
        '
        Me.LabelSign.AutoSize = True
        Me.LabelSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSign.Location = New System.Drawing.Point(71, 105)
        Me.LabelSign.Name = "LabelSign"
        Me.LabelSign.Size = New System.Drawing.Size(56, 26)
        Me.LabelSign.TabIndex = 13
        Me.LabelSign.Text = "Sign"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 341)
        Me.Controls.Add(Me.LabelSign)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelAnswer)
        Me.Controls.Add(Me.GroupBoxOperator)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LabelSecondNum)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelFirstNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxOperator.ResumeLayout(False)
        Me.GroupBoxOperator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFirstNum As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelSecondNum As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOperator As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDivide As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMultiply As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSubtract As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAdd As System.Windows.Forms.RadioButton
    Friend WithEvents LabelAnswer As System.Windows.Forms.Label
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelSign As System.Windows.Forms.Label

End Class
