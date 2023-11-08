'Zachary Christensen
'RCET 2265
'Fall 2023
'Math Contest
'git link

Public Class MathContestForm
    'Custom Methods

    'only checks that anything is in the text boxes 
    'need to check that grade and age are within range
    'age 7-11
    'grade 1-4
    ''' <summary>
    ''' Checks if Name, Age, and Grade have been entered
    ''' </summary>
    ''' <param name="message"></param>
    ''' <returns></returns>
    Private Function ValidateUserInputs(Optional ByRef message As String = "")
        Dim isvalid As Boolean = True
        Dim errorMessage As String

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
