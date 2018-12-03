
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, salary, salary_year
        Dim year = 12
        name = TextBox1.Text
        salary = TextBox2.Text
        salary_year = salary * year
        Label6.Text = TextBox1.Text
        Label7.Text = TextBox2.Text
        Label8.Text = salary_year
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class



