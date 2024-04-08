Imports System.Transactions

Public Class times
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tim As Double
        tim = TextBox1.Text

        If tim >= 5 And tim < 12 Then
            MsgBox("Good Morning")

        ElseIf tim >= 12 And tim < 18 Then
            MsgBox("Good Afternoon")

        ElseIf tim >= 18 And tim < 21 Then
            MsgBox("Good Evening")

        ElseIf tim >= 21 Then
            MsgBox("Good Night")

        Else
            MsgBox("Incorect time format")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim first, second As Double
        Try
            first = Double.Parse(TextBox2.Text)
            second = Double.Parse(TextBox3.Text)

            If second = 0 Then
                MsgBox("Cannot divide by zero")
            Else
                Dim result As Single = first / second
                MsgBox("Result of the operation is " & result.ToString)
            End If
        Catch ex As Exception
            MsgBox("Not a valid numeric entry")
        End Try


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim first, second, product, average As Single
        first = InputBox("Enter the first Number")
        second = InputBox("the second number")

        product = first * second
        average = (first + second) / 2

        Label8.Text = ("The product is:  " & product & "  ,The average is:" & average)
    End Sub
End Class