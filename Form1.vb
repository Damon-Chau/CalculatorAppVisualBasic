Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub additionRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRB.CheckedChanged
        symbolLbl.Text = "+"
        answerLbl.Text = ""
    End Sub

    Private Sub subtractRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractRB.CheckedChanged
        symbolLbl.Text = "-"
        answerLbl.Text = ""
    End Sub

    Private Sub multiplyRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplyRB.CheckedChanged
        symbolLbl.Text = "*"
        answerLbl.Text = ""
    End Sub

    Private Sub divideRb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divideRB.CheckedChanged
        symbolLbl.Text = "/"
        answerLbl.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles symbolLbl.Click

    End Sub

    Private Sub answerLbl_Click(sender As Object, e As EventArgs) Handles answerLbl.Click

    End Sub

    Private Sub calculateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateBtn.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        If userinput1Textbox.Text = "" OrElse userinput2Textbox.Text = "" Then
            MessageBox.Show("Please Enter a Number")
        ElseIf addRb.Checked = False And subtractRB.Checked = False And multiplyRB.Checked = False And divideRB.Checked = False Then
            MessageBox.Show("Please Choose an Operation")
        Else
            number1 = Double.Parse(userinput1Textbox.Text)
            number2 = Double.Parse(userinput2Textbox.Text)

            If addRB.Checked = True Then
                answer = number1 + number2
                answerLbl.Text = answer.ToString()
            ElseIf subtractRB.Checked = True Then
                answer = number1 - number2
                answerLbl.Text = answer.ToString()
            ElseIf multiplyRB.Checked = True Then
                If number1 = 0 OrElse number2 = 0 Then
                    answerLbl.Text = "0"
                Else
                    answer = number1 * number2
                    answerLbl.Text = answer.ToString()
                End If
            ElseIf divideRB.Checked = True Then
                If number1 = 0 Then
                    answerLbl.Text = "0"
                ElseIf number2 = 0 Then
                    answerLbl.Text = "Cannot Divide by Zero"
                Else
                    answer = number1 / number2
                    answerLbl.Text = answer.ToString()
                End If
            End If
        End If

    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        userinput1Textbox.Text = ""
        userinput2Textbox.Text = ""
        answerLbl.Text = ""

        If addRB.Checked = True Then
            addRB.Checked = False
            symbolLbl.Text = ""
        ElseIf subtractRB.Checked = True Then
            subtractRB.Checked = False
            symbolLbl.Text = ""
        ElseIf multiplyRB.Checked = True Then
            multiplyRB.Checked = False
            symbolLbl.Text = ""
        Else
            divideRB.Checked = False
            symbolLbl.Text = ""
        End If
    End Sub
End Class
