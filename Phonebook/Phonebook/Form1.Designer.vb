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
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(423, 100)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumber.TabIndex = 0
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(52, 100)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(231, 100)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLastName.TabIndex = 2
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(203, 20)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(185, 26)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "Phonebook Entry "
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(47, 54)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(119, 26)
        Me.LabelFirstName.TabIndex = 4
        Me.LabelFirstName.Text = "First Name"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(226, 54)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(118, 26)
        Me.LabelLastName.TabIndex = 5
        Me.LabelLastName.Text = "Last Name"
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumber.Location = New System.Drawing.Point(402, 54)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(159, 26)
        Me.LabelNumber.TabIndex = 6
        Me.LabelNumber.Text = "Phone Number"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(231, 197)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(100, 34)
        Me.ButtonAdd.TabIndex = 7
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 262)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.LabelNumber)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLastName As System.Windows.Forms.TextBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents LabelLastName As System.Windows.Forms.Label
    Friend WithEvents LabelNumber As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button

End Class
