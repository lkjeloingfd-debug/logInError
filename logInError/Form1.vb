Public Class Form1
    Private Sub bnt1_Click(sender As Object, e As EventArgs) Handles bnt1.Click
        Dim input1, input2 As String
        input1 = userName.Text.Trim
        input2 = password.Text.Trim
        Try
            If input1 = "admin" AndAlso input2 = "password123" Then
                output.Text = "Login successful!"
                output.ForeColor = Color.Green
            Else

                output.ForeColor = Color.Red
            End If

            'pushed

        Catch ex As Exception

        End Try




    End Sub
End Class
