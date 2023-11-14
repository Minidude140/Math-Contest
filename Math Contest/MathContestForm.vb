'Zachary Christensen
'RCET 2265
'Fall 2023
'Math Contest
'https://github.com/Minidude140/Math-Contest.git

'TODO
'[~]need to check that grade and age are within range
'[~]only checks that anything is in the text boxes 
'[~]age 7-11
'[~]grade 1-4
'[~]only message user once
'[~1/2]clear and focus offending text boxes
'[~]Separate 'not a number' exceptions into separate age and grade (set focus and clear)
'[~]Add tool tips and hot keys
'[~]Generate Two Random number sub
'[~]Clear math problem numbers when setdefaults
'[~]Re Generate new numbers when: ~StartButton Clicked, ~SubmitButton Clicked, ~New Operator selected
'[]submit button handler should:
'[]solve problem compare to student response --> 
'[]*add, *subtract, *multiply, divide functions
'[*]message user their result
'[*]keep track of number of questions and correct responses


Public Class MathContestForm
    Dim mathoperation As String
    Dim numberOfCorrectAnswers As Integer
    Dim totalNumberofQuestions As Integer

    'Custom Methods

    ''' <summary>
    ''' Checks if Name, Age, and Grade have been entered properly
    ''' </summary>
    ''' <param name="message"></param>
    ''' <returns></returns>
    Private Function ValidateUserInputs(Optional ByRef message As String = "")
        Dim isvalid As Boolean = True
        Dim errorMessage As String = ""

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
        'message the user if an error has occurred
        If errorMessage <> "" Then
            MsgBox(errorMessage)
        End If
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
        Dim ageAndGradeErrorMessage As String = ""
        Try
            'check if grade is a number
            grade = CInt(GradeTextBox.Text)
            'check if grade is in range
            Select Case grade
                Case 1 To 4
                    'grade is in range
                Case Else
                    GradeTextBox.Text = ""
                    GradeTextBox.Focus()
                    ageAndGradeErrorMessage = "Grade must between 1 and 4." & vbCrLf
                    validAgeAndGrade = False
            End Select
        Catch ex As Exception
            'grade not a number
            validAgeAndGrade = False
            GradeTextBox.Focus()
            ageAndGradeErrorMessage = "Grade must be a whole Number." & vbCrLf
        End Try
        Try
            'check if age is a number
            age = CInt(AgeTextBox.Text)
            'check if age is in range
            Select Case age
                Case 7 To 11
                    'age is in range 
                Case Else
                    AgeTextBox.Text = ""
                    AgeTextBox.Focus()
                    ageAndGradeErrorMessage &= "Age must be between 7 and 11." & vbCrLf
                    validAgeAndGrade = False
            End Select
        Catch ex As Exception
            'age not a number
            validAgeAndGrade = False
            AgeTextBox.Focus()
            ageAndGradeErrorMessage &= "Age must be a whole number." & vbCrLf
        End Try
        'student is not in range or wrong data entered
        If validAgeAndGrade = False Then
            MsgBox("Student is not eligible to compete" & vbCrLf & ageAndGradeErrorMessage)
        End If
        Return validAgeAndGrade
    End Function

    ''' <summary>
    ''' enables or disable controls for the student
    ''' </summary>
    ''' <param name="activate"></param>
    Sub EnableContestControls(activate As Boolean)
        If activate Then
            'enables the controls for the student during the contest
            SummaryButton.Enabled = True
            StartButton.Enabled = False
            ClearButton.Enabled = True
            MathProblemTypeGroupBox.Enabled = True
            CurrentMathProblemGroupBox.Enabled = True
            StudentInfoGroupBox.Enabled = False
        Else
            'returns to the controls for the teacher to begin a new student
            SummaryButton.Enabled = False
            StartButton.Enabled = True
            ClearButton.Enabled = False
            CurrentMathProblemGroupBox.Enabled = False
            MathProblemTypeGroupBox.Enabled = False
            StudentInfoGroupBox.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' sets default text boxes and buttons
    ''' </summary>
    Sub SetDefaults()
        'sets default text boxes, buttons, and data for new student
        AddRadioButton.Checked = True
        mathoperation = "+"
        StudentNameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentResponseTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        numberOfCorrectAnswers = 0
        totalNumberofQuestions = 0
    End Sub

    ''' <summary>
    ''' returns random number optional max default of 100
    ''' </summary>
    ''' <returns></returns>
    Function RandomNumber(Optional max As Integer = 100) As Integer
        Dim number As Integer
        Randomize(DateTime.Now.Millisecond * DateTime.Now.Second)
        number = Rnd() * max
        Return number
    End Function

    ''' <summary>
    ''' Generates two new numbers for the question
    ''' </summary>
    Sub PopulateStudentQuestion()
        'sets new random numbers 
        Dim firstNumber As Integer = RandomNumber()
        Dim secondNumber As Integer = RandomNumber()
        'assigns new numbers to text boxes
        FirstNumberTextBox.Text = firstNumber
        SecondNumberTextBox.Text = secondNumber
    End Sub

    ''' <summary>
    ''' Returns the sum of two integers
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="second"></param>
    ''' <returns></returns>
    Function AddTwoNumbers(first As Integer, second As Integer) As Integer
        Dim sum As Integer
        sum = first + second
        Return sum
    End Function

    ''' <summary>
    ''' Returns the difference of two integers
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="second"></param>
    ''' <returns></returns>
    Function SubtractTwoNumbers(first As Integer, second As Integer) As Integer
        Dim difference As Integer
        difference = first - second
        Return difference
    End Function

    ''' <summary>
    ''' Returns the Product of two Double Points
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="second"></param>
    ''' <returns></returns>
    Function MultiplyTwoNumbers(first As Double, second As Double) As Double
        Dim product As Double
        product = first * second
        Return product
    End Function

    ''' <summary>
    ''' Returns the Quotient of two Double Points
    ''' </summary>
    ''' <param name="first"></param>
    ''' <param name="second"></param>
    ''' <returns></returns>
    Function DivideTwoNumbers(first As Double, second As Double) As Double
        Dim quotient As Double
        quotient = first / second
        Return quotient
    End Function

    ''' <summary>
    ''' Checks is the student's response is correct returns true if yes
    ''' </summary>
    ''' <returns></returns>
    Function CheckStudentResponse() As Boolean
        Dim currentFirstNumber As Integer
        Dim currentSecondNumber As Integer
        Dim correctResponse As Integer
        Dim studentResponse As Integer
        Dim studentCorrect As Boolean
        Dim returnMessage As String = ""

        'sets the first and second numbers
        currentFirstNumber = CInt(Me.FirstNumberTextBox.Text)
        currentSecondNumber = CInt(Me.SecondNumberTextBox.Text)

        Try
            'try to convert student response
            studentResponse = CInt(Me.StudentResponseTextBox.Text)
            'check which operator is selected
            Select Case mathoperation
                Case = "+"
                    correctResponse = AddTwoNumbers(currentFirstNumber, currentSecondNumber)
                Case = "-"
                    correctResponse = SubtractTwoNumbers(currentFirstNumber, currentSecondNumber)
                Case = "*"
                    correctResponse = MultiplyTwoNumbers(currentFirstNumber, currentSecondNumber)
                Case = "/"
                    'need to convert to doubles to deal with decimal

            End Select

            'check if student answered correctly and answer accordingly
            If correctResponse = studentResponse Then
                'Student is correct
                studentCorrect = True
                returnMessage = "Correct!" & vbCrLf &
                    $"{currentFirstNumber} {mathoperation} {currentSecondNumber} = {correctResponse}"
                numberOfCorrectAnswers += 1
                totalNumberofQuestions += 1
            Else
                'Student is not correct
                studentCorrect = False
                returnMessage = $"Sorry, {currentFirstNumber} {mathoperation} {currentSecondNumber} = {correctResponse}" &
                vbCrLf & $"Your response: {studentResponse}"
                totalNumberofQuestions += 1
            End If
        Catch ex As Exception
            'Entered data is not an integer
            returnMessage = "Please enter a Whole Number"
        End Try
        'message student results of their answer
        MsgBox(returnMessage)
        Return studentCorrect
    End Function

    ''' <summary>
    ''' Messages the user their score and totals
    ''' </summary>
    Sub SummaryMessage()
        'creates message with number of correct and questions asked
        Dim summaryMessage As String
        summaryMessage = $"{StudentNameTextBox.Text} got {numberOfCorrectAnswers} out of {totalNumberofQuestions} correct."
        MsgBox(summaryMessage)
    End Sub

    ''' <summary>
    ''' Checks the Math Type Radio button selection and sets the mathOperator to the correct type
    ''' </summary>
    Sub CheckOperator()
        Select Case True
            Case AddRadioButton.Checked
                mathoperation = "+"
            Case SubtractRadioButton.Checked
                mathoperation = "-"
            Case MultiplyRadioButton.Checked
                mathoperation = "*"
            Case DivideRadioButton.Checked
                mathoperation = "\"
        End Select
    End Sub

    'Event Handlers
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        EnableContestControls(False)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If ValidateUserInputs() Then
            If AgeAndGradeCheck() Then
                EnableContestControls(True)
                'start contest
                PopulateStudentQuestion()
            End If
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
        EnableContestControls(False)
    End Sub

    Private Sub MathOperatorChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged,
                                                                                             SubtractRadioButton.CheckedChanged,
                                                                                             MultiplyRadioButton.CheckedChanged,
                                                                                             DivideRadioButton.CheckedChanged
        'generates new numbers and sets the math operation
        CheckOperator()
        PopulateStudentQuestion()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        CheckStudentResponse()
        PopulateStudentQuestion()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        SummaryMessage()
    End Sub
End Class
