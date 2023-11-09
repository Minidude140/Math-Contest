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
'[]only message user once
'[]clear and focus offending text boxes

Public Class MathContestForm
    'Custom Methods

    ''' <summary>
    ''' Checks if Name, Age, and Grade have been entered
    ''' </summary>
    ''' <param name="message"></param>
    ''' <returns></returns>
    Private Function ValidateUserInputs(Optional ByRef message As String = "")
        Dim isvalid As Boolean = True
        Dim errorMessage As String
        Dim age As Integer
        Dim grade As Integer

        'Checks if each entered text box has a value
        For Each item As TextBox In StudentInfoGroupBox.Controls.OfType(Of TextBox)
            If isvalid = True Then
                item.Focus()
            End If
            If item.Text = "" Then
                isvalid = False
                errorMessage &= Replace($"{item.Name.ToString} is required{vbCrLf}", "TextBox", "")
                MsgBox(errorMessage)
            End If
        Next
        Try
            'check if age or grade are numbers
            age = CInt(AgeTextBox.Text)
            grade = CInt(GradeTextBox.Text)

            'check if age is in range
            Select Case age
                Case 7 To 11
                    'age is in range 
                    MsgBox("Age is in range")
            End Select
            'check if grade is in range
            Select Case grade
                Case 1 To 4
                    'grade is in range
                    MsgBox("Grade is in range")
            End Select
        Catch ex As Exception
            isvalid = False
            'not a number
            MsgBox("not a number")
        End Try
        Return isvalid
    End Function

    'Event Handlers
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddRadioButton.Checked = True
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ValidateUserInputs()
    End Sub
End Class
