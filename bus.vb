Imports System.Linq.Expressions

Public Class bus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' For i As Integer = 1 To 10
        ' If i Mod 2 <> 0 Then
        'MsgBox(i)
        'End If
        'Next '


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim first, second, product, average As Single
        'first = InputBox("Enter the First No:")
        'second = InputBox("Enter the Second No:")
        first = TextBox2.Text
        second = TextBox3.Text
        product = first * second
        average = (first + second) / 2
        Label2.Text = "Product is :" & product
        Label3.Text = "average is " & average
    End Sub

    Private Sub bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim u As Integer
        Dim i As Single
        i = 22 / 7
        Button3.Text = i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name, age As String
        name = InputBox("Enter your Name:")
        age = InputBox("Enter your Age")
        MsgBox(name & age)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Const pi As Single = 3.1427
        Dim circumference, area As Single
        circumference = pi * 7 ^ 2
        area = pi * (7 ^ 2)
        Button5.Text = (circumference & area)
        Console.WriteLine("Hello")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim age As Integer
        age = InputBox("Enter your age")
        If age < 18 Then
            MsgBox("You have not reached voting Age")
        ElseIf age >= 18 Then
            MsgBox("You have reached voting age")
        Else
            MsgBox("Incorrect input")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim x, y As Integer
            Dim z As Single = x / y
            x = InputBox("First No")
            y = InputBox("Second No")
            z = x / y
            MsgBox("Result is " & z)
        Catch ex As Exception
            MsgBox("An error occured")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i As Integer
        For i = 1 To 10
            If i Mod 2 = 0 Then
                MsgBox(i)
            End If
        Next
    End Sub
End Class