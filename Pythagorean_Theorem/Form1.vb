Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim AB As Double
        Dim BC As Double
        Dim AC As Double

        If Double.TryParse(ABTextBox.Text, AB) AndAlso Double.TryParse(ACTextBox.Text, AC) AndAlso Double.TryParse(BCTextBox.Text, BC) Then

            If AB = 0 AndAlso AC = 0 AndAlso BC = 0 Then

                MessageBox.Show("Please enter valid non-zero numeric values for at least two sides.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            ElseIf AC = 0 Then
                AC = Math.Sqrt(Math.Pow(BC, 2) - Math.Pow(AB, 2))

                If Not Double.IsNaN(AC) Then
                    ACTextBox.Text = AC.ToString()

                Else
                    MessageBox.Show("Invalid input. Unable to calculate the missing side.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            ElseIf BC = 0 Then

                BC = Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2))

                If Not Double.IsNaN(BC) Then
                    BCTextBox.Text = BC.ToString()

                Else
                    MessageBox.Show("Invalid input. Unable to calculate the missing side.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            ElseIf AB = 0 Then

                AB = Math.Sqrt(Math.Pow(BC, 2) - Math.Pow(AC, 2))

                If Not Double.IsNaN(AB) Then
                    ABTextBox.Text = AB.ToString()

                Else
                    MessageBox.Show("Invalid input. Unable to calculate the missing side.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Leave any one side empty to calculate it.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Enter valid numeric values for at least two sides.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ABTextBox.Text = "0"
        BCTextBox.Text = "0"
        ACTextBox.Text = "0"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
