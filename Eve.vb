Imports System.Diagnostics.Eventing.Reader

Public Class Eve
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim h, v, w, l As Integer
        h = 10
        w = 20
        l = 15
        v = l * w * h
        Label1.Text = "The volume is" & v.ToString()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a As Integer
        a = InputBox("Enter your age")
        If a < 18 Then
            MsgBox("You are too young to vote")
        Else
            MsgBox("You have reached voting age and can proceed")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As Decimal
        t = TextBox2.Text

        If t >= 5 AndAlso t <= 12 Then
            MsgBox("Good Morning")
        ElseIf t >= 12 AndAlso t <= 18 Then
            MsgBox("Good Afternoon")
        ElseIf t >= 18 AndAlso t <= 9 Then
            MsgBox("Good Evening")
        ElseIf t >= 21 Then
            MsgBox("Good Night")
        Else
            MsgBox("Incorrect time formaat")
        End If


    End Sub
End Class