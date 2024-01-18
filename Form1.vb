Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Grade As String
        Grade = ComboBox1.Text

        Select Case Grade
            Case "A"
                TextBox1.Text = "High Distinction"
            Case "A-"
                TextBox1.Text = "Distinction"
            Case "B"
                TextBox1.Text = "Credit"
            Case "C"
                TextBox1.Text = "Pass"
            Case "D"
                TextBox1.Text = "Fail"
            Case Else
                TextBox1.Text = "Fail"

        End Select
    End Sub
End Class
