Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight As Double
        weight = Val(txtWeight.Text)
        Dim height As Double
        height = Val(txtHeight.Text)
        Dim bmi As Double

        bmi = weight / (height * height)

        If bmi < 18.5 Then
            txtBMI.Text = bmi
            txtRemark.Text = "UNDERWEIGHT"
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            txtBMI.Text = bmi
            txtRemark.Text = "NORMAL"
        ElseIf bmi >= 25 And bmi <= 29.9 Then
            txtBMI.Text = bmi
            txtRemark.Text = "OVERWEIGHT"
        ElseIf bmi >= 30 And bmi <= 39.9 Then
            txtBMI.Text = bmi
            txtRemark.Text = "OBESE"
        ElseIf bmi > 40 Then
            txtBMI.Text = bmi
            txtRemark.Text = "MORBID OBESE"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtHeight.Text = " "
        txtWeight.Text = " "
        txtBMI.Text = " "
        txtRemark.Text = " "
    End Sub
End Class
