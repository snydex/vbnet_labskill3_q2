Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim hoursWorkedDouble, hourlyRateDouble, totalPayDouble As Double

        Try
            hoursWorkedDouble = Double.Parse(HoursWorkedTextBox.Text)
            hourlyRateDouble = Double.Parse(HourlyRateTextBox.Text)

            totalPayDouble = (hoursWorkedDouble * hourlyRateDouble)

            TotalPayLabel.Text = totalPayDouble.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Invalid Input, please try again.")
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        HoursWorkedTextBox.Clear()
        HourlyRateTextBox.Clear()
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub

    Private Sub HoursWorkedTextBox_TextChanged(sender As Object, e As EventArgs) Handles HoursWorkedTextBox.TextChanged

    End Sub

    Private Sub TotalPayLabel_Click(sender As Object, e As EventArgs) Handles TotalPayLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
