Public Class Age
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Age As Integer
        Age = InputBox("Please enter your age:")
        If Age < 18 Then
            MsgBox("You are too young to vote")
        Else
            MsgBox("You have reached voting age and can proceed")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 1 To 10
            If i Mod 2 = 0 Then
                MsgBox(i)
                'Console.WriteLine(i)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   Dim currentTime As TimeOnly
        '  If currentTime <
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim first, second, third As String
        first = "Paul"
        second = "W"
        third = "Ruoya"
        MsgBox("Your first name is:" & first & "Your second name is:" & second & "Your third name is" & third)
    End Sub
End Class