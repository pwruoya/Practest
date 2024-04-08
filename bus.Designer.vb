<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        ListView1 = New ListView()
        Button8 = New Button()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 20)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter First No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 4
        Label3.Text = "Enter Second No"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(77, 143)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(147, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(142, 114)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(89, 172)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 68)
        Button3.TabIndex = 10
        Button3.Text = "Numeric DTypes"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 166)
        Button4.Name = "Button4"
        Button4.Size = New Size(71, 42)
        Button4.TabIndex = 11
        Button4.Text = "Name"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(190, 172)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 53)
        Button5.TabIndex = 12
        Button5.Text = "Area"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(12, 246)
        Button6.Name = "Button6"
        Button6.Size = New Size(103, 21)
        Button6.TabIndex = 13
        Button6.Text = "Vote"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(150, 248)
        Button7.Name = "Button7"
        Button7.Size = New Size(119, 29)
        Button7.TabIndex = 14
        Button7.Text = "trycatch"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(491, 30)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(162, 76)
        ListView1.TabIndex = 15
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(10, 278)
        Button8.Name = "Button8"
        Button8.Size = New Size(85, 24)
        Button8.TabIndex = 16
        Button8.Text = "Odd no"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(462, 147)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(240, 129)
        ProgressBar1.TabIndex = 17
        ' 
        ' bus
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(Button8)
        Controls.Add(ListView1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "bus"
        Text = "bus"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button8 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
