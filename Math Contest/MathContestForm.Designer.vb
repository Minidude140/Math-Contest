<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentResponseLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentResponseTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.CurrentMathProblemGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentNameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(24, 26)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(510, 94)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(406, 27)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(343, 27)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(20, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(409, 47)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(41, 22)
        Me.GradeTextBox.TabIndex = 2
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(339, 47)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(41, 22)
        Me.AgeTextBox.TabIndex = 1
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(23, 49)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(261, 22)
        Me.StudentNameTextBox.TabIndex = 0
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentResponseLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentResponseTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(31, 135)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(332, 291)
        Me.CurrentMathProblemGroupBox.TabIndex = 1
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentResponseLabel
        '
        Me.StudentResponseLabel.AutoSize = True
        Me.StudentResponseLabel.Location = New System.Drawing.Point(15, 198)
        Me.StudentResponseLabel.Name = "StudentResponseLabel"
        Me.StudentResponseLabel.Size = New System.Drawing.Size(125, 17)
        Me.StudentResponseLabel.TabIndex = 5
        Me.StudentResponseLabel.Text = "Student Response"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(15, 111)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(110, 17)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(15, 51)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(89, 17)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        '
        'StudentResponseTextBox
        '
        Me.StudentResponseTextBox.Location = New System.Drawing.Point(18, 218)
        Me.StudentResponseTextBox.Name = "StudentResponseTextBox"
        Me.StudentResponseTextBox.Size = New System.Drawing.Size(277, 22)
        Me.StudentResponseTextBox.TabIndex = 2
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(18, 131)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(284, 22)
        Me.SecondNumberTextBox.TabIndex = 1
        Me.SecondNumberTextBox.TabStop = False
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(18, 71)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(284, 22)
        Me.FirstNumberTextBox.TabIndex = 0
        Me.FirstNumberTextBox.TabStop = False
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(373, 135)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(160, 290)
        Me.MathProblemTypeGroupBox.TabIndex = 2
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(26, 222)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(26, 163)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(26, 112)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(26, 53)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(551, 26)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(232, 398)
        Me.ButtonGroupBox.TabIndex = 1
        Me.ButtonGroupBox.TabStop = False
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(26, 204)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(189, 80)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(26, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(189, 80)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(26, 32)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(189, 80)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(26, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(189, 80)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.CurrentMathProblemGroupBox.ResumeLayout(False)
        Me.CurrentMathProblemGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents StudentResponseLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents StudentResponseTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ExitButton As Button
End Class
