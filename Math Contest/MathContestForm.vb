'Zachary Christensen
'RCET 2265
'Fall 2023
'Math Contest
'git link

'TODO
'[~]need to check that grade and age are within range
'[~]only checks that anything is in the text boxes 
'[~]age 7-11
'[~]grade 1-4
'[~]only message user once
'[]clear and focus offending text boxes

'questions
'getting blank msgbox when all fields correct
'activate/deactivate buttons when fields are filled

Public Class MathContestForm
    'Custom Methods

    ''' <summary>
    ''' Checks if Name, Age, and Grade have been entered properly
    ''' </summary>
    ''' <param name="message"></param>
    ''' <returns></returns>
    Private Function ValidateUserInputs(Optional ByRef message As String = "")
        Dim isvalid As Boolean = True
        Dim errorMessage As String

        'Checks if each entered text box has a value
        For Each item As TextBox In StudentInfoGroupBox.Controls.OfType(Of TextBox)
            If isvalid = True Then
                item.Focus()
            End If
            If item.Text = "" Then
                isvalid = False
                errorMessage &= Replace($"{item.Name.ToString} is required{vbCrLf}", "TextBox", "")
            End If
        Next
        If AgeAndGradeCheck() = False Then
            MsgBox("Student is not eligible to compete")
        End If

        MsgBox(errorMessage)
        Return isvalid
    End Function

    ''' <summary>
    ''' Checks if Age and Grade text box contents are numbers and in range
    ''' </summary>
    ''' <returns></returns>
    Private Function AgeAndGradeCheck() As Boolean
        Dim age As Integer
        Dim grade As Integer
        Dim validAgeAndGrade As Boolean = True
        Try
            'check if age or grade are numbers
            age = CInt(AgeTextBox.Text)
            grade = CInt(GradeTextBox.Text)
            'check if age is in range
            Select Case age
                Case 7 To 11
                    'age is in range 
                    'MsgBox("Age is in range")
                Case Else
                    validAgeAndGrade = False
            End Select
            'check if grade is in range
            Select Case grade
                Case 1 To 4
                    'grade is in range
                    'MsgBox("Grade is in range")
                Case Else
                    validAgeAndGrade = False
            End Select
        Catch ex As Exception
            'validAgeAndGrade = False
            'not a number
            MsgBox("not a number")
        End Try
        Return validAgeAndGrade
    End Function

    ''' <summary>
    ''' enables or disable various user controls
    ''' </summary>
    ''' <param name="activate"></param>
    Sub EnableControls(activate As Boolean)
        If activate Then
            AddRadioButton.Enabled = True
            SubtractRadioButton.Enabled = True
            MultiplyRadioButton.Enabled = True
            DivideRadioButton.Enabled = True
            SummaryButton.Enabled = True
        Else
            AddRadioButton.Enabled = False
            SubtractRadioButton.Enabled = False
            MultiplyRadioButton.Enabled = False
            DivideRadioButton.Enabled = False
            SummaryButton.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' sets default text boxes and buttons
    ''' </summary>
    Sub SetDefaults()
        AddRadioButton.Checked = True
        StudentNameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentResponseTextBox.Text = ""
    End Sub

    'Event Handlers
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        EnableControls(False)
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ValidateUserInputs()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
End Class
