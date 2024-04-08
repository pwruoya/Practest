Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer
        Dim B As Integer
        A = InputBox("enter the value of A")
        B = InputBox("enter the value of B")

        If A > B Then
            MsgBox("A is greater than B")
        End If
        If A < B Then
            MsgBox("A is smaller than B")
        End If
        If A = B Then
            MsgBox("A is equal to B")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'ComboBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim I As Double
        For I = 12 To 70
            '  MsgBox(ComboBox1.Items.Add(I)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "First_Program"
        ' Me.BackColor = blac
    End Sub
End Class
