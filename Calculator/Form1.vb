Public Class Calculadores
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles displayLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "0"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "1"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "2"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "3"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "4"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "5"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "6"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "7"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "8"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "9"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.displayLabel.Text = ""
        Me.firstNumber.Text = ""
        Me.operator_Label1.Text = ""

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.operator_Label1.Text = "+"

        If (Me.displayLabel.Text = "") Then
        Else
            Me.firstNumber.Text = Me.displayLabel.Text
            Me.displayLabel.Text = ""
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.operator_Label1.Text = "-"
        If (Me.displayLabel.Text = "") Then
        Else
            Me.firstNumber.Text = Me.displayLabel.Text
            Me.displayLabel.Text = ""
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.operator_Label1.Text = "*"
        If (Me.displayLabel.Text = "") Then
        Else
            Me.firstNumber.Text = Me.displayLabel.Text
            Me.displayLabel.Text = ""
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.operator_Label1.Text = "%"
        If (Me.displayLabel.Text = "") Then
        Else
            Me.firstNumber.Text = Me.displayLabel.Text
            Me.displayLabel.Text = ""
        End If
    End Sub

    Private Sub firstNumber_Click(sender As Object, e As EventArgs) Handles firstNumber.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim firstNum As Double
        Dim secondNum As Double
        Dim result As Double

        Double.TryParse(Me.firstNumber.Text, firstNum)
        Double.TryParse(Me.displayLabel.Text, secondNum)

        If Me.operator_Label1.Text = "+" Then
            Me.displayLabel.Text = firstNum + secondNum
        ElseIf Me.operator_Label1.Text = "-" Then
            Me.displayLabel.Text = firstNum - secondNum

        ElseIf Me.operator_Label1.Text = "%" Then
            Me.displayLabel.Text = firstNum / secondNum

        ElseIf Me.operator_Label1.Text = "*" Then
            Me.displayLabel.Text = firstNum * secondNum

        End If

        Me.firstNumber.Text = ""
        Me.operator_Label1.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.displayLabel.Text = Me.displayLabel.Text + "."

    End Sub
End Class
