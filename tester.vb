Public Class tester
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myInt As Integer
        Dim tester As Single
        Dim longer As Long
        Dim doubler As Double

        myInt = (22 / 7)
        tester = (22 / 7)
        longer = (22 / 7)
        doubler = (22 / 7)
        MsgBox("The integer value is: " & myInt)
        MsgBox("The longer value is " & longer)
        MsgBox("The single value is " & tester)
        MsgBox("The double value is " & doubler)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' ListBox1.Items.Add(& myInt)
    End Sub
End Class